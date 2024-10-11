using RW.Configuration;
using System;
using System.Windows.Forms;

namespace MainUI.TRDP.Model
{
    /// <summary>
    /// TRDP配置帧SMI 
    /// </summary>
    public class TRDPSMI : IniConfig
    {
        public TRDPSMI()
            : base(Application.StartupPath + "\\config\\trdp.ini")
        {

            this.Load();
            ETHConfig ethconfig = new();
            if (ethconfig.ETH == 0)
                CommandType = TRDPSMICommandTypes.Eth0;
            else
                CommandType = TRDPSMICommandTypes.Eth1;
        }


        public TRDPSMI(string ininame)
        {
            iniName = ininame;
            this.Name = ininame;
        }

        /// <summary>
        /// 根据ini名称加载不同 ini文件
        /// </summary>
        public static string iniName = "trdp";


        private string _Name;

        /// <summary>
        /// Name
        /// </summary>
        protected string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                this.Filename = Application.StartupPath + "\\config\\" + iniName + ".ini";
                this.Load();
                ETHConfig ethconfig = new ETHConfig(Filename);
                if (ethconfig.ETH == 0)
                    CommandType = TRDPSMICommandTypes.Eth0;
                else
                    CommandType = TRDPSMICommandTypes.Eth1;

            }
        }

        /// <summary>
        /// 起始位
        /// </summary>
        public const int START = 0xFE;
        /// <summary>
        /// 命令类型，0x04，0x84
        /// </summary>
        public TRDPSMICommandTypes CommandType { get; set; }

        ///// <summary>
        ///// 数据长度
        ///// </summary>
        //public int DataLength { get; set; }

        /// <summary>
        /// SMI地址
        /// </summary>
        public int SMI { get; set; }


        /// <summary>
        /// 以后主版本：
        /// </summary>
        public int UserDataVerH { get; set; }
        /// <summary>
        /// 以后子版本：
        /// </summary>
        public int UserDataVerL { get; set; }


        /// <summary>
        /// 编组唯一标识符
        /// </summary>
        public int ConsistID { get; set; }
        /// <summary>
        /// 安全拓扑计数器
        /// </summary>
        public int SafeTopoCount { get; set; }

        /// <summary>
        /// 注册接收 SMI 数量
        /// </summary>
        public int SMIcount { get; set; }
        /// <summary>
        /// SMI1
        /// </summary>
        public int ReceiveSMI1 { get; set; }
        /// <summary>
        /// SMI2
        /// </summary>
        public int ReceiveSMI2 { get; set; }

        /// <summary>
        /// SMI3
        /// </summary>
        public int ReceiveSMI3 { get; set; }

        /// <summary>
        /// SMI4
        /// </summary>
        public int ReceiveSMI4 { get; set; }


        /// <summary>
        /// SMI5
        /// </summary>
        public int ReceiveSMI5 { get; set; }

        /// <summary>
        /// SMI6
        /// </summary>
        public int ReceiveSMI6 { get; set; }

        /// <summary>
        /// CRC校验
        /// </summary>
        public byte[] CRC { get; set; }

        public void InitData(byte[] data)
        {
            if (data.Length != 89) return;


        }

        public byte[] SMIToBytes()
        {
            byte[] bts = new byte[57];
            bts[0] = START;
            bts[1] = (Byte)this.CommandType;
            bts[2] = 0x00;
            bts[3] = 0x33;

            //发送 SMI 安全信息标识
            byte[] dnsport = BitConverter.GetBytes(SMI);
            bts[4] = dnsport[3];
            bts[5] = dnsport[2];
            bts[6] = dnsport[1];
            bts[7] = dnsport[0];


            //重要过程数据主版本号 默认 0x01
            bts[8] = (byte)UserDataVerH;
            //重要过程数据子版本号 默认 0x01
            bts[9] = (byte)UserDataVerL;

            //编组唯一标识符  不确定情况下全部填 0
            bts[10] = 0x00;
            bts[11] = 0x00;
            bts[12] = 0x00;
            bts[13] = 0x00;
            bts[14] = 0x00;
            bts[15] = 0x00;
            bts[16] = 0x00;
            bts[17] = 0x00;
            bts[18] = 0x00;
            bts[19] = 0x00;
            bts[20] = 0x00;
            bts[21] = 0x00;
            bts[22] = 0x00;
            bts[23] = 0x00;
            bts[24] = 0x00;
            bts[25] = 0x00;

            //安全拓扑计数器
            byte[] SafeTopoCountByte = BitConverter.GetBytes(SafeTopoCount);
            bts[26] = SafeTopoCountByte[3];
            bts[27] = SafeTopoCountByte[2];
            bts[28] = SafeTopoCountByte[1];
            bts[29] = SafeTopoCountByte[0];

            //注册接收 SMI 数量
            bts[30] = (byte)SMIcount;

            //允许接收 SMI 安全信息标识 1
            byte[] SMI1 = BitConverter.GetBytes(ReceiveSMI1);
            bts[31] = SMI1[3];
            bts[32] = SMI1[2];
            bts[33] = SMI1[1];
            bts[34] = SMI1[0];

            //允许接收 SMI 安全信息标识 2
            byte[] SMI2 = BitConverter.GetBytes(ReceiveSMI2);
            bts[35] = SMI2[3];
            bts[36] = SMI2[2];
            bts[37] = SMI2[1];
            bts[38] = SMI2[0];

            //允许接收 SMI 安全信息标识 3
            byte[] SMI3 = BitConverter.GetBytes(ReceiveSMI3);
            bts[39] = SMI3[3];
            bts[40] = SMI3[2];
            bts[41] = SMI3[1];
            bts[42] = SMI3[0];


            //允许接收 SMI 安全信息标识 4
            byte[] SMI4 = BitConverter.GetBytes(ReceiveSMI4);
            bts[43] = SMI4[3];
            bts[44] = SMI4[2];
            bts[45] = SMI4[1];
            bts[46] = SMI4[0];


            //允许接收 SMI 安全信息标识 5
            byte[] SMI5 = BitConverter.GetBytes(ReceiveSMI5);
            bts[47] = SMI5[3];
            bts[48] = SMI5[2];
            bts[49] = SMI5[1];
            bts[50] = SMI5[0];

            //允许接收 SMI 安全信息标识 6
            byte[] SMI6 = BitConverter.GetBytes(ReceiveSMI6);
            bts[51] = SMI6[3];
            bts[52] = SMI6[2];
            bts[53] = SMI6[1];
            bts[54] = SMI6[0];


            this.CRC = CRCHelper.CRC16(bts, 4, bts.Length - 2);
            bts[55] = CRC[0];
            bts[56] = CRC[1];


            //var tempbytes = RWConvert.HexStringToBytes("FE 05 00 53 38 00 22 33 44 55 66 0A 80 01 1C 0A 80 01 01 FF FF FF 00 00 00 00 00 43 49 00 00 00 00 E0 01 01 09 43 49 50 44 0A 80 01 04 50 44 00 00 00 00 50 44 01 00 00 03 E8 00 00 03 E8 00 00 03 E8 00 00 03 E8 00 00 00 00 00 1F 4F 1F 4F 00 00 00 00 1F 4F 1F 4F 70 C2");

            //var tempCRC = CRCHelper.CRC16(tempbytes, 4, tempbytes.Length - 2);


            return bts;
        }
        public enum TRDPSMICommandTypes
        {
            Eth0 = 0x04,
            Eth1 = 0x84,
        }

    }
}
