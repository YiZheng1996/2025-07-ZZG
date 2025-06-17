using MathNet.Numerics;
using Org.BouncyCastle.Utilities;
using RW;
using RW.Log;
using Sunny.UI;
using System.Runtime.InteropServices;

namespace MainUI.CAN
{
    /*
     * 调用GY8508 类库说明：
     * 1、引用 ...master\Lib\CANx86Lib\ 文件夹下的3个库文件
     * 2、启动项目-右键-属性-生成-目标平台-选择x86。（x64的库，经验证，无效）
     * 
     * 方法的参数 DevType =3  (GY8508) ,  DevType=2 (GY8507)。
     */
    internal class CANDriver
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct PVCI_INIT_CONFIG
        {
            public uint AccCode;
            public uint AccMask;
            public uint Reserved;
            public byte Filter;
            public byte kCanBaud;
            public byte Timing0;
            public byte Timing1;
            public byte Mode;
            public byte CanRx_IER;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct PVCI_CAN_OBJ
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]//声明数组大小为4
            public byte[] ID; //4
            public uint TimeStamp;//C++的UINT对应32位
            public byte TimeFlag;
            public byte SendType;
            public byte RemoteFlag; //=0
            public byte ExternFlag; //=1
            public byte DataLen; //=8
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]//声明数组大小为8
            public byte[] Data; //8
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]//声明数组大小为3
            public byte[] Reserved;//3
        }

        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_OpenDevice")]
        public static extern int VCI_OpenDevice(uint Devtype, uint Devindex, uint Reserved);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_StartCAN")]
        public static extern int VCI_StartCAN(uint Devtype, uint Devindex, uint CANInd);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_CloseDevice")]
        public static extern int VCI_CloseDevice(int DeviceType, int DeviceInd);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_SetReference")]
        public static extern int VCI_SetReference(uint DeviceType, uint DeviceInd, uint CANInd, uint RefType, ref byte pData);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_InitCAN")]
        public static extern int VCI_InitCAN(uint DevType, uint DevIndex, uint CANIndex, ref PVCI_INIT_CONFIG pInitConfig);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_Transmit")]
        public static extern int VCI_Transmit(uint DevType, uint DevIndex, uint CANIndex, ref PVCI_CAN_OBJ pSend);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_Receive")]
        public static extern int VCI_Receive(uint DevType, uint DevIndex, uint CANIndex, [Out]/*声明参数为输出*/ PVCI_CAN_OBJ[] pReceive);

        public static int Open()
        {
            if (VCI_OpenDevice(3, 0, 0) != 1)
                return 0;
            else
                return 1;
        }

        public int Init(string BaudRate)
        {
            PVCI_INIT_CONFIG[] config = new PVCI_INIT_CONFIG[1];
            (byte Timing0, byte Timing1) = GetRate(BaudRate);
            config[0].AccCode = 0x80000008; //滤波位定义，
            config[0].AccMask = 0xFFFFFFFF; //过滤屏蔽码，使能滤波位，1 该位不滤波。0 该位滤波。
            config[0].Reserved = 204;
            config[0].Filter = 0;      // 单滤波，双滤波
            config[0].kCanBaud = 15;  // 波特率索引 15 1000kb
            config[0].Timing0 = Timing0;  //参见波特率表格
            config[0].Timing1 = Timing1; //参见波特率表格
            config[0].CanRx_IER = 1;
            config[0].Mode = 0;//1~自发自收模式，0~正常工作模式

            if (VCI_InitCAN(3, 0, 0, ref config[0]) != 1)
                return 0;
            return 1;
        }

        public int Start()
        {
            if (VCI_StartCAN(3, 0, 0) != 1)
                return 0;
            return 1;
        }

        public int Close()
        {
            int count = 0;
            try
            {
                count = VCI_CloseDevice(3, 0);
            }
            catch (Exception ex)
            {
                string err = "CanStation VCI_CloseDevice error : " + ex.Message;
                LogHelper.WriteLine(err);
            }
            return count;
        }

        static object locker = new();
        public int Send(byte[] data, int canID)
        {
            int flag = 0;
            try
            {
                PVCI_CAN_OBJ sendbuf = new()
                {
                    ID = new byte[4],
                    ExternFlag = 0, // 0：标准帧，1：扩展帧
                    RemoteFlag = 0,
                    DataLen = 8,
                    Data = data
                };

                canID <<= 5;
                //直接将ID 转换为4个字节的byte数组，
                byte[] sendID = BitConverter.GetBytes(canID);
                //小端格式变为大端格式
                //byte[] byteAry = new byte[4];
                //byteAry[0] = sendID[1];
                //byteAry[1] = sendID[0];
                //sendbuf.ID = byteAry;

                lock (locker)
                {
                    flag = VCI_Transmit(3, 0, 0, ref sendbuf);//CAN DATA SEND
                }
                if (flag != 1)
                {
                    if (flag == -1)
                        LogHelper.WriteLine("VCI_Transmit fail,device not open");
                    else if (flag == 0)
                        LogHelper.WriteLine("VCI_Transmit fail");
                }
            }
            catch (Exception ex)
            {
                string err = "CanStation Send error : " + ex.Message;
                LogHelper.WriteLine(err);
            }
            return flag;
        }

        public void ReceiveStart()
        {
            isReceiveing = true;
            Thread th = new(new ThreadStart(Receive));
            th.Start();
        }

        public delegate void CanReceiveHandler(int CanID, byte[] dataReceive);
        public event CanReceiveHandler CanReceiveData;

        public bool isReceiveing = false;
        private void Receive()
        {
            try
            {
                do
                {
                    //接收数据缓冲区，200帧长度，因为一次接收会有多帧数据。
                    PVCI_CAN_OBJ[] recebuf = new PVCI_CAN_OBJ[200];
                    int NumValue = 0;
                    //NumValue ：本次接收的帧数量。 每次读取会清空缓冲区。长时间不读取缓冲区帧数据会累加。
                    VarHelper.CANData = NumValue = VCI_Receive(3, 0, 0, recebuf);
                    int canID = 0; // 暂时模拟
                    //Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "--->   NumValue：" + NumValue.ToString() );
                    short canID16 = 0; // 暂时模拟
                    byte[] data = new byte[8];
                    for (int i = 0; i < 10; i++)
                    {
                        if (NumValue > recebuf.Length)
                            break;

                        PVCI_CAN_OBJ temp = recebuf[i];
                        temp.ID = recebuf[i].ID;
                        byte[] canIDbyte =
                        [
                            //大端格式转换为小端格式
                            recebuf[i].ID[1],
                            recebuf[i].ID[0],
                        ];
                        canID16 = BitConverter.ToInt16(canIDbyte, 0);

                        //标准帧ID 为11位， 右移5位。
                        canID16 = Convert.ToInt16(canID16 >> 5);
                        canID = canID16;
                        if (temp.Data != null)
                        {
                            data = temp.Data;
                            string text = RWConvert.BytesToHexString(data, " ");
                            if (canID == 0) continue;
                            //Debug.WriteLine($"ID:{canID}  DATA:{text}");
                        }
                        Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "--->   i：" + i.ToString() + ", canID : " + canID.ToString() + " , data : " + BitConverter.ToString(data, 0));
                        if (CanReceiveData != null && isReceiveing)
                            CanReceiveData(canID, data);
                    }
                    Thread.Sleep(50);
                }
                while (isReceiveing);
            }
            catch (Exception ex)
            {
                string err = "CanStation Receive error : " + ex.Message;
                LogHelper.WriteLine(err);
            }
        }

        private (byte Timing0, byte Timing1) GetRate(string BaudRate)
        {
            switch (BaudRate)
            {
                case "5":
                    return (0xBF, 0xFF);
                case "10":
                    return (0x31, 0x1C);
                case "20":
                    return (0x18, 0x1C);
                case "40":
                    return (0x87, 0xFF);
                case "50":
                    return (0x09, 0x1C);
                case "80":
                    return (0x83, 0xFF);
                case "100":
                    return (0x04, 0x1C);
                case "125":
                    return (0x03, 0x1C);
                case "200":
                    return (0x81, 0xFA);
                case "250":
                    return (0x01, 0x1C);
                case "400":
                    return (0x80, 0xFA);
                case "500":
                    return (0x00, 0x1C);
                case "666":
                    return (0x80, 0xB6);
                case "800":
                    return (0x00, 0x16);
                case "1000":
                    return (0x00, 0x14);
                default:
                    break;
            }
            return (0, 0);
        }
    }
}
