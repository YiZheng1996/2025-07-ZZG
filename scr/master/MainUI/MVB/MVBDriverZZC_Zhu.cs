using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace MainUI.MVB
{
    /// <summary>
    /// 主要为构建MVB的驱动使用，众志诚MVB网卡，主站模式
    /// </summary>
    public class MVBDriverZZC_Zhu
    {
        public static MVBDriverZZC_Zhu MVB = new();

        public List<Ports> ports = [];
        public List<FullTags> tags = [];
        //public Dictionary<int, byte[]> fullData = [];//所有的数据，通过端口号进行存储
        public Dictionary<COMMData, FullTags> dicItems = [];

        public delegate void MVBStateChange(bool state);
        /// <summary>
        /// 连接成功事件
        /// </summary>
        public event MVBStateChange MVBStateChangeEvent;

        public delegate void _MVBConfigureChange(bool state);
        /// <summary>
        /// 配置成功事件
        /// </summary>
        public event _MVBConfigureChange MVBConfigureChangeEvent;

        public MVBDriverZZC_Zhu()
        {


        }

        /// <summary>
        /// 连接成功事件
        /// </summary>
        /// <param name="state"></param>
        private void Md_MVBStateChangeEvent(bool state)
        {
            Thread th = new(new ThreadStart(() =>
            {
                if (state)
                {
                    Thread.Sleep(200);
                    int yuanCount = ports.Where(x => x.IsRead == false).Count();
                    int suCount = ports.Where(x => x.IsRead == true).Count();
                    byte[] peizhiyuan = new byte[yuanCount * 4];
                    byte[] peizhisu = new byte[suCount * 4];
                    int yuan = 0;
                    foreach (var item in ports.Where(x => x.IsRead == false))
                    {
                        byte[] itemArray = new byte[4];
                        BitConverter.GetBytes(Convert.ToInt16(item.Port, 16)).Reverse().ToArray().CopyTo(itemArray, 0);
                        itemArray[2] = (byte)(Math.Log(item.DataSize, 2) - 1);

                        //《ZZCZZ_2016_001MVB主站以太网通讯技术要求2020.3.21正式B.11(增加可调上传时间）.pdf》 第7页
                        //备注3：端口周期按照如下表示：0x01=16ms、0x02=32ms、0x03=64ms、0x04=128ms、 0x05 = 256ms、0x06 = 512ms、0x07 = 1024ms依次类推。（由于MVB网卡对车辆主站而言，是从设备，并且我司MVB网卡做到端口周期自动响应，因此此参数可能并无意义，先预留接口）
                        //itemArray[3] = 16;
                        itemArray[3] = item.Rate switch
                        {
                            16 => 0x01,
                            32 => 0x02,
                            64 => 0x03,
                            128 => 0x04,
                            256 => 0x05,
                            512 => 0x06,
                            1024 => 0x07,
                            _ => 0x02,//单车系统控制源端口周期是32ms，所以此处应该是0x02
                        };
                        itemArray.CopyTo(peizhiyuan, yuan * 4);
                        yuan++;
                        //待发送源端口数据

                        //SourceData[Convert.ToInt32(item.Port, 16)] = new byte[108];
                    }
                    int su = 0;
                    foreach (var item in ports.Where(x => x.IsRead == true))
                    {
                        byte[] itemArray = new byte[4];
                        BitConverter.GetBytes(Convert.ToInt16(item.Port, 16)).Reverse().ToArray().CopyTo(itemArray, 0);
                        itemArray[2] = (byte)(Math.Log(item.DataSize, 2) - 1);
                        itemArray[3] = item.Rate switch
                        {
                            16 => 0x01,
                            32 => 0x02,
                            64 => 0x03,
                            128 => 0x04,
                            256 => 0x05,
                            512 => 0x06,
                            1024 => 0x07,
                            _ => 0x02,//单车系统接收宿端口周期是32ms，所以此处应该是0x02
                        };
                        itemArray.CopyTo(peizhisu, su * 4);
                        su++;
                    }
                    SendZPZ(peizhiyuan, peizhisu);
                }
            }));
            th.Start();
        }

        public bool isInitSucess = false;


        /// <summary>
        /// 配置成功事件
        /// </summary>
        /// <param name="state"></param>
        private void Md_MVBConfigureChangeEvent(bool state)
        {
            Thread th = new(new ThreadStart(() =>
            {
                if (state)
                {
                    isInitSucess = state;//配置成功
                    SendAction();
                    Wrtie();

                }
            }));
            th.Start();
        }

        private void Md_MVBValueChangeEvent(int port, byte[] values)
        {
            SourceData[port] = values;
        }

        /// <summary>
        /// MVB读取位
        /// </summary>
        /// <param name="targetNum"></param>
        /// <param name="bitNum"></param>
        /// <returns></returns>
        public bool GetByBit(int port, int targetNum, int bitNum)
        {
            byte value = SourceData[port][targetNum];
            int tmpInt = 1 << bitNum;
            return (value & tmpInt) / tmpInt != 0;
        }

        /// <summary>
        /// MVB读取值
        /// </summary>
        /// <param name="targetNum"></param>
        /// <param name="bitNum"></param>
        /// <returns></returns>
        public decimal GetByte(int port, int targetNum, int bit, string DataType)
        {
            decimal value = 0;
            if (!SourceData.ContainsKey(port))
                return 0;
            GetVal(ref value, DataType, targetNum, bit, SourceData[port], 0, port);
            return value;
        }

        public void GetVal(ref decimal value, string dataType, int offset, int Bit, byte[] data, int bits, int port)
        {
            byte[] temp = null;
            //offset = ConvertBit(offset, Bit)[0];
            //Bit = ConvertBit(offset, Bit)[1];
            switch (dataType)
            {
                case "B1":
                    value = GetByBit(port, offset, Bit) ? 1 : 0;
                    break;
                case "U8":
                    offset += Bit;
                    value = data[offset];
                    break;
                case "I8":
                    value = (sbyte)data[offset];//TODO：请注意，此处负数的处理
                    break;
                case "U16":
                    temp = new byte[2];
                    Array.Copy(data, offset, temp, bits, temp.Length);
                    value = BitConverter.ToUInt16(temp.Reverse().ToArray(), 0);
                    break;
                case "I16":
                    temp = new byte[2];
                    Array.Copy(data, offset, temp, bits, temp.Length);
                    value = BitConverter.ToInt16(temp.Reverse().ToArray(), 0);
                    break;
                case "U32":
                    temp = new byte[4];
                    Array.Copy(data, offset, temp, bits, temp.Length);
                    value = BitConverter.ToUInt32(temp.Reverse().ToArray(), 0);
                    break;
                case "I32":
                    temp = new byte[4];
                    Array.Copy(data, offset, temp, bits, temp.Length);
                    value = BitConverter.ToInt32(temp.Reverse().ToArray(), 0);
                    break;
                case "U64":
                    temp = new byte[8];
                    Array.Copy(data, offset, temp, bits, temp.Length);
                    value = BitConverter.ToUInt64(temp.Reverse().ToArray(), 0);
                    break;
                case "I64":
                    temp = new byte[8];
                    Array.Copy(data, offset, temp, bits, temp.Length);
                    value = BitConverter.ToInt64(temp.Reverse().ToArray(), 0);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 将字偏移装换为字节偏移
        /// </summary>
        /// <param name="offset">字偏移</param>
        /// <param name="bit">位偏移</param>
        /// <returns></returns>
        public List<int> ConvertBit(int offset, int bit)
        {
            return new List<int>() { offset * 2 + bit / 8, bit % 8 };
        }

        [DefaultValue(1000)]
        public int Timeout { get; set; }

        [DefaultValue(1000)]
        public int Interval { get; set; }


        Dictionary<int, List<FullTags>> tempLifeTag = new Dictionary<int, List<FullTags>>();//有生命信号刷新的端口

        private enum OrderCode
        {
            连接命令 = 14, 配置应答成功 = 6, 配置应答失败 = 5, 数据返回命令 = 8
        }
        public bool MVBstate
        {
            get
            {
                return _MVBstate;
            }
            set
            {
                Md_MVBStateChangeEvent(value);
                _MVBstate = value;
            }
        }
        private bool _MVBstate;
        public bool MVBConfigure
        {
            get
            {
                return _MVBConfigure;
            }
            set
            {
                _MVBConfigure = value;
                Md_MVBStateChangeEvent(value);  //hhh 2024-1-19 19:33:30  本地模拟，配置成功，同时触发连接成功事件
                Md_MVBConfigureChangeEvent(value);
            }
        }
        /// <summary>
        /// </summary>
        public bool TZ { get; set; } = true;

        private bool _MVBConfigure;

        public delegate void MVBValueChange(int port, byte[] values);
        /// <summary>
        /// 待发送源端口数据
        /// </summary>
        public Dictionary<int, byte[]> SourceData = new Dictionary<int, byte[]>();

        UDPConnet UDP = new UDPConnet();

        public byte[] peizhiyuan = new byte[] { 0x01, 0x07, 0x78, 0x04, 0x10 };//源端口:0X778
        public byte[] peizhisu = new byte[] { 0x01, 0x07, 0x18, 0x04, 0x10 };//宿端口:0X718

        private byte[] WriteLifeTou = new byte[] { 0XFE, 0X2A, 0X09, 0XEA, 0XFF };//写入数据使能自增帧尾
        private byte[] WriteTou = new byte[] { 0XFE, 0X2A, 0X09, 0X80, 0XFF };//写入数据不使能自增帧头

        private byte[] lianjie = new byte[10] { 0xfe, 0x0a, 0x0d, 0x01, 0x00, 1, 0, 0xfe, 0xfa, 0xff };//请求连接配置
        private byte[] duankai = new byte[10] { 0xfe, 0x0a, 0x0d, 0x01, 0x00, 2, 0, 0xfe, 0xfa, 0xff };//断开连接配置
        private byte[] address = new byte[] { 0x01 };
        private byte[] Zpeizhitou = new byte[4] { 0xfe, 0XFA, 0X05, 0XE0 };//主站配置帧头
        private byte[] Cpeizhitou = new byte[4] { 0xfe, 0XFA, 0X05, 0XC0 };//从站配置帧头
        private byte[] peizhiwei = new byte[3] { 0xfe, 0XFA, 0XFF };//帧尾

        private byte[] Action = new byte[] { 0XFE, 0X08, 0X07, 0X00, 0X01, 0XFE, 0XFA, 0XFF };//开始接收帧
        private byte[] Stop = new byte[] { 0XFE, 0X08, 0X07, 0X00, 0x00, 0XFE, 0XFA, 0XFF };//停止接收帧


        public void LoadData()
        {
            //Ports _SearchPort = new Ports();
            //_SearchPort.ProjectID = Var.projectID;
            //_SearchPort.WorkType = "MVB";
            //ports = PortsBLL.Instance.GetAll(_SearchPort);

            ////协议信息表
            //string ids = "";
            //foreach (var item in ports)
            //{
            //    fullData[item.PortNum] = new byte[item.DataSize];
            //    ids += item.ID + ",";
            //}
            //if (ids.Length != 0)
            //{
            //    tags = FulltagsBLL.Instance.GetfulltagsByIDS(ids.Substring(0, ids.Length - 1));
            //}
            //foreach (var item in tags)
            //{
            //    dicItems[new COMMData { ID = item.ID, Bit = item.MVBBit, Offset = item.MVBOffset, Port = Convert.ToInt32(item.MVBPort, 16) }] = item;
            //}
        }

        //MvbConfigModel _info = new MvbConfigModel();

        //public void LoadConfig()
        //{
        //    ParameterModel pm = ParameterBLL.Instance.GetParameterByType(Var.projectID, "MVB").FirstOrDefault();

        //    if (pm == null)
        //        return;
        //    _info = JsonConvert.DeserializeObject<MvbConfigModel>(pm.DataJson);
        //}

        /// <summary>
        /// 开始连接
        /// </summary>
        public void Connect()
        {
            //LoadConfig();
            //if (_info.Address == null)
            //    return;

            //Thread.Sleep(5000);//上电后等硬件初始化，再下发配置指令
            UDP.MVBValueRecive += UDP_MVBValueRecive;

            //容易报出错误“远程主机强迫关闭了一个现有的连接”
            //UDP.UDPConnect();
            //UDP.SendConnect(lianjie);

            //先连接，再接收数据
            UDP.SendConnect(lianjie);
            Thread.Sleep(200);
            UDP.UDPConnect();

        }

        bool ydstate = false;
        private void UDP_MVBValueRecive(byte[] value)
        {
            try
            {
                switch ((OrderCode)value[2])
                {
                    case OrderCode.连接命令:
                        int s = Convert.ToInt32($"{value.Skip(5).Take(1).Reverse().ToArray()[0]}", 16);
                        MVBstate = s == 1;
                        break;
                    case OrderCode.配置应答成功:
                        if (ydstate)
                        {
                            return;
                        }
                        ydstate = true;
                        var s1 = value.Skip(2).Take(1).ToArray();
                        MVBConfigure = s1[0] == 6;
                        break;
                    case OrderCode.配置应答失败:
                        var s2 = value.Skip(2).Take(1).ToArray();
                        MVBConfigure = s2[0] == 6;
                        break;
                    case OrderCode.数据返回命令:
                        int port = BitConverter.ToInt16(value.Skip(4).Take(2).Reverse().ToArray(), 0);
                        SourceData[port] = value.Skip(6).Take(32).ToArray();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        /// <summary>
        /// 关闭连接
        /// </summary>
        public void Close()
        {
            UDP.FlagReceive = false;
            UDP.SendConnect(duankai);
        }
        /// <summary>
        /// 发送主站配置数据,配置端口
        /// </summary>
        /// <param name="address">MVB卡地址</param>
        /// <param name="peizhiyuan">源端口数据</param>
        /// <param name="peizhisu">宿端口数据</param>
        public void SendZPZ(byte[] peizhiyuan, byte[] peizhisu)
        {
            byte[] peizhi = new byte[Zpeizhitou.Length + 1 + peizhiwei.Length + 242];
            Zpeizhitou.CopyTo(peizhi, 0);//添加头部信息
            address.CopyTo(peizhi, Zpeizhitou.Length);//添加mvb卡地址
            byte[] YuanNumber = new byte[] { (byte)(peizhiyuan.Length / 4) }; //添加源端口数量 
            YuanNumber.CopyTo(peizhi, Zpeizhitou.Length + address.Length);

            peizhiyuan.CopyTo(peizhi, Zpeizhitou.Length + address.Length + YuanNumber.Length);//添加源端口信息
            if (peizhiyuan.Length <= 120)
            {
                byte[] yuanM = new byte[120 - peizhiyuan.Length];
                yuanM.CopyTo(peizhi, Zpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length);//补全30个源端口

                byte[] SuNumber = new byte[] { (byte)(peizhisu.Length / 4) }; //添加宿端口数量
                SuNumber.CopyTo(peizhi, Zpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length + yuanM.Length);//添加宿端口数量
                peizhisu.CopyTo(peizhi, Zpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length + yuanM.Length + SuNumber.Length);//添加宿端口信息
                if (peizhisu.Length <= 120)
                {
                    byte[] SuM = new byte[120 - peizhisu.Length];
                    SuM.CopyTo(peizhi, Zpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length + yuanM.Length + SuNumber.Length + peizhisu.Length);//补全30个宿端口
                    peizhiwei.CopyTo(peizhi, Zpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length + yuanM.Length + SuNumber.Length + peizhisu.Length + SuM.Length);//配置尾部信息
                }
            }
            //将源端口数据更新至待发送源端口数据
            UDP.Send(peizhi);
        }


        /// <summary>
        /// 发送从站配置数据,配置端口
        /// </summary>
        /// <param name="address">MVB卡地址</param>
        /// <param name="peizhiyuan">源端口数据</param>
        /// <param name="peizhisu">宿端口数据</param>
        public void SendCPZ(byte[] peizhiyuan, byte[] peizhisu)
        {
            byte[] peizhi = new byte[Cpeizhitou.Length + 1 + peizhiwei.Length + 242];
            Cpeizhitou.CopyTo(peizhi, 0);//添加头部信息
            address.CopyTo(peizhi, Cpeizhitou.Length);//添加mvb卡地址
            byte[] YuanNumber = new byte[] { (byte)(peizhiyuan.Length / 4) }; //添加源端口数量 
            YuanNumber.CopyTo(peizhi, Cpeizhitou.Length + address.Length);

            peizhiyuan.CopyTo(peizhi, Cpeizhitou.Length + address.Length + YuanNumber.Length);//添加源端口信息
            if (peizhiyuan.Length <= 120)
            {
                byte[] yuanM = new byte[120 - peizhiyuan.Length];
                yuanM.CopyTo(peizhi, Cpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length);//补全30个源端口

                byte[] SuNumber = new byte[] { (byte)(peizhisu.Length / 4) }; //添加宿端口数量
                SuNumber.CopyTo(peizhi, Cpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length + yuanM.Length);//添加宿端口数量
                peizhisu.CopyTo(peizhi, Cpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length + yuanM.Length + SuNumber.Length);//添加宿端口信息
                if (peizhisu.Length <= 120)
                {
                    byte[] SuM = new byte[120 - peizhisu.Length];
                    SuM.CopyTo(peizhi, Cpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length + yuanM.Length + SuNumber.Length + peizhisu.Length);//补全30个宿端口
                    peizhiwei.CopyTo(peizhi, Cpeizhitou.Length + address.Length + peizhiyuan.Length + YuanNumber.Length + yuanM.Length + SuNumber.Length + peizhisu.Length + SuM.Length);//配置尾部信息
                }
            }
            //将源端口数据更新至待发送源端口数据

            UDP.Send(peizhi);
        }

        /// <summary>
        /// 开始接收数据
        /// </summary>
        public void SendAction()
        {
            UDP.Send(Action);
        }

        /// <summary>
        /// 停止接收数据
        /// </summary>
        public void SendStop()
        {
            UDP.Send(Stop);
        }
        /// <summary>
        /// 写入数据的方法
        /// </summary>
        /// <param name="port"></param>
        /// <param name="byteSet"></param>
        /// <param name="bitSet"></param>
        /// <param name="valuetype"></param>
        /// <param name="value"></param>
        public void WrtieValue(int port, int byteSet, int bitSet, string valuetype, object value)
        {
            switch (valuetype)
            {
                case "B1":
                    SetValue(port, byteSet, bitSet, value);
                    break;
                case "U8":
                    SetValue(port, byteSet, bitSet, Convert.ToByte(value));
                    break;
                case "I8":
                    SetValue(port, byteSet, bitSet, Convert.ToSByte(value));
                    break;
                case "U16":
                    SetValue(port, byteSet, bitSet, Convert.ToUInt16(value));
                    break;
                case "I16":
                    SetValue(port, byteSet, bitSet, Convert.ToInt16(value));
                    break;
                case "U32":
                    SetValue(port, byteSet, bitSet, Convert.ToUInt32(value));
                    break;
                case "I32":
                    SetValue(port, byteSet, bitSet, Convert.ToInt32(value));
                    break;
                case "U64":
                    SetValue(port, byteSet, bitSet, Convert.ToUInt64(value));
                    break;
                case "I64":
                    SetValue(port, byteSet, bitSet, Convert.ToInt64(value));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 写入数据的方法
        /// </summary>
        /// <param name="port"></param>
        /// <param name="byteSet"></param>
        /// <param name="bitSet"></param>
        /// <param name="valuetype"></param>
        /// <param name="value"></param>
        public void WrtieValue(int port, int byteSet, int bitSet, string valuetype, object value, bool PortPattern = false)
        {
            switch (valuetype)
            {
                case "B1":
                    SetValue(port, byteSet, bitSet, value, PortPattern);
                    break;
                case "U8":
                    SetValue(port, byteSet, bitSet, Convert.ToByte(value), PortPattern);
                    break;
                case "I8":
                    SetValue(port, byteSet, bitSet, Convert.ToSByte(value), PortPattern);
                    break;
                case "U16":
                    SetValue(port, byteSet, bitSet, Convert.ToUInt16(value), PortPattern);
                    break;
                case "I16":
                    SetValue(port, byteSet, bitSet, Convert.ToInt16(value), PortPattern);
                    break;
                case "U32":
                    SetValue(port, byteSet, bitSet, Convert.ToUInt32(value), PortPattern);
                    break;
                case "I32":
                    SetValue(port, byteSet, bitSet, Convert.ToInt32(value), PortPattern);
                    break;
                case "U64":
                    SetValue(port, byteSet, bitSet, Convert.ToUInt64(value), PortPattern);
                    break;
                case "I64":
                    SetValue(port, byteSet, bitSet, Convert.ToInt64(value), PortPattern);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 设置值到指定端口的字节数组中
        /// </summary>
        /// <param name="port"></param>
        /// <param name="byteSet"></param>
        /// <param name="bitSet"></param>
        /// <param name="value"></param>
        private void SetValue(int port, int byteSet, int bitSet, object value)
        {
            if (value is bool)
            {
                if (Convert.ToBoolean(value))
                    SourceData[port][byteSet] |= (byte)(1 << bitSet);
                else
                    SourceData[port][byteSet] &= (byte)~(1 << bitSet);
            }
            else if (value is byte || value is sbyte)
            {
                SourceData[port][byteSet] = Convert.ToByte(value);
            }
            else
            {
                byte[] bts = null;
                if (value is short)
                {
                    short val = (short)value;
                    bts = BitConverter.GetBytes(val).Reverse().ToArray();
                }
                else if (value is ushort)
                {
                    ushort val = (ushort)value;
                    bts = BitConverter.GetBytes(val).Reverse().ToArray();
                }
                else if (value is int)
                {
                    int val = (int)value;
                    bts = BitConverter.GetBytes(val).Reverse().ToArray();
                }
                else if (value is uint)
                {
                    uint val = (uint)value;
                    bts = BitConverter.GetBytes(val).Reverse().ToArray();
                }
                else if (value is long)
                {
                    long val = (long)value;
                    bts = BitConverter.GetBytes(val).Reverse().ToArray();
                }
                else if (value is ulong)
                {
                    ulong val = (ulong)value;
                    bts = BitConverter.GetBytes(val).Reverse().ToArray();
                }
                else if (value is float)
                {
                    float val = (float)value;
                    bts = BitConverter.GetBytes(val).Reverse().ToArray();
                }
                else if (value is double val)
                {
                    bts = BitConverter.GetBytes(val).Reverse().ToArray();
                }
                bts.CopyTo(SourceData[port], byteSet);
            }
            Debug.WriteLine($"设置端口 {port} 的数据：{BitConverter.ToString(SourceData[port])}");
            UDP.Send(SourceData[port]);
        }

        #region 改造后SetValue方法
        /// <summary>
        /// 设置值到指定端口的字节数组中
        /// </summary>
        /// <param name="port"></param>
        /// <param name="byteSet"></param>
        /// <param name="bitSet"></param>
        /// <param name="value"></param>
        /// <param name="PortPattern">是否大小端</param>
        private void SetValue(int port, int byteSet, int bitSet, object value, bool PortPattern)
        {
            switch (value)
            {
                case bool b:
                    SourceData[port][byteSet] = b
                        ? (byte)(SourceData[port][byteSet] | (1 << bitSet))
                        : (byte)(SourceData[port][byteSet] & ~(1 << bitSet));
                    break;

                case byte or sbyte:
                    SourceData[port][byteSet] = Convert.ToByte(value);
                    break;

                default:
                    byte[] bytes = GetBytes(value, PortPattern);
                    if (bytes != null)
                    {
                        Array.Copy(bytes, 0, SourceData[port], byteSet, bytes.Length);
                        Debug.WriteLine($"设置端口 {port} 的数据：{BitConverter.ToString(SourceData[port])}");
                        UDP.Send(SourceData[port]);
                    }
                    break;
            }
        }

        private static byte[] GetBytes(object value, bool portPattern)
        {
            return value switch
            {
                short val => ProcessBytes(BitConverter.GetBytes(val), portPattern),
                ushort val => ProcessBytes(BitConverter.GetBytes(val), portPattern),
                int val => ProcessBytes(BitConverter.GetBytes(val), portPattern),
                uint val => ProcessBytes(BitConverter.GetBytes(val), portPattern),
                long val => ProcessBytes(BitConverter.GetBytes(val), portPattern),
                ulong val => ProcessBytes(BitConverter.GetBytes(val), portPattern),
                float val => ProcessBytes(BitConverter.GetBytes(val), portPattern),
                double val => ProcessBytes(BitConverter.GetBytes(val), portPattern),
                _ => null
            };
        }

        private static byte[] ProcessBytes(byte[] bytes, bool portPattern) =>
            portPattern ? bytes : bytes.Reverse().ToArray();

        #endregion


        /// <summary>
        /// 返回0-255的值，数字变化代表在发送数据状态。
        /// </summary>
        public event Action<ushort> SendMVBchanged;
        ushort sendCnt = 0;
        public bool FlagSend { get; set; } = true;
        /// <summary>
        /// 循环发送数据帧，不使能自增计数器
        /// </summary>
        public void Wrtie()
        {

            Thread th = new(new ThreadStart(() =>
            {
                //  while (TZ)
                while (FlagSend)
                {
                    try
                    {
                        foreach (var item in SourceData)
                        {
                            byte[] dataMVB = new byte[WriteTou.Length + peizhiwei.Length + 34];
                            WriteTou.CopyTo(dataMVB, 0);
                            //插入写的端口地址
                            byte[] portarray = BitConverter.GetBytes((short)item.Key).Reverse().ToArray();
                            portarray.CopyTo(dataMVB, WriteTou.Length);
                            item.Value.CopyTo(dataMVB, WriteTou.Length + 2);
                            if (item.Value.Length <= 32)
                            {
                                byte[] dataM = new byte[32 - item.Value.Length];
                                dataM.CopyTo(dataMVB, WriteTou.Length + 2 + item.Value.Length);
                                peizhiwei.CopyTo(dataMVB, WriteTou.Length + 34);
                            }
                            UDP.Send(dataMVB);
                            Thread.Sleep(20);
                            //Thread.Sleep(1000); //模拟，延时
                        }
                    }
                    catch (Exception)
                    {
                    }
                    //}
                    Thread.Sleep(10);

                    sendCnt++;
                    SendMVBchanged?.Invoke(sendCnt);
                }

                //md.SendWrtie(1912, new byte[4] { i, i, i, i });

            }));
            th.Start();
        }
        /// <summary>
        /// 循环发送数据帧，使能自增计数器
        /// </summary>
        public void WrtieExcuteLife()
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                while (TZ)
                {
                    foreach (var item in SourceData)
                    {
                        byte[] dataMVB = new byte[WriteLifeTou.Length + peizhiwei.Length + 34];
                        WriteLifeTou.CopyTo(dataMVB, 0);
                        //插入写的端口地址
                        byte[] portarray = BitConverter.GetBytes((short)item.Key).Reverse().ToArray();
                        portarray.CopyTo(dataMVB, WriteLifeTou.Length);
                        item.Value.CopyTo(dataMVB, WriteLifeTou.Length + 2);
                        if (item.Value.Length <= 32)
                        {
                            byte[] dataM = new byte[32 - item.Value.Length];
                            dataM.CopyTo(dataMVB, WriteLifeTou.Length + 2 + item.Value.Length);
                            peizhiwei.CopyTo(dataMVB, WriteLifeTou.Length + 34);
                        }
                        UDP.Send(dataMVB);
                    }
                    Thread.Sleep(50);
                    //md.SendWrtie(1912, new byte[4] { i, i, i, i });

                }

            }));
            th.Start();


        }

    }

    public class UDPConnet
    {
        UdpClient client = new();
        //实际硬件IP地址
        public IPEndPoint remotePoint3001 = new IPEndPoint(IPAddress.Parse("192.168.0.178"), 3001);
        public IPEndPoint remotePoint4001 = new IPEndPoint(IPAddress.Parse("192.168.0.178"), 4001);

        ////本地测试
        //public IPEndPoint remotePoint3001 = new IPEndPoint(IPAddress.Parse("192.168.0.211"), 3001);
        ////本地测试
        //public IPEndPoint remotePoint4001 = new IPEndPoint(IPAddress.Parse("192.168.0.211"), 4002);


        public delegate void MVBReciveClientMsg(byte[] value);
        public event MVBReciveClientMsg MVBValueRecive;
        public bool FlagReceive { get; set; } = true;
        //是否应答
        public bool YDstate { get; set; } = false;

        public void UDPConnect()
        {
            try
            {
                if (client != null)
                {
                    try
                    {
                        client.Close();
                        client.Dispose();
                    }
                    catch { }
                }

                client = new UdpClient();
                client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                client.Client.Bind(new IPEndPoint(IPAddress.Any, 4001));

                Thread ReciveClientMsgThread = new(ReciveClientMsg)
                {
                    IsBackground = true
                };
                ReciveClientMsgThread.Start();

                Thread YDpdThread = new(YDpd)
                {
                    IsBackground = true
                }; //重连机制
                YDpdThread.Start();
            }
            catch (SocketException se)
            {
                NlogHelper.Default.Error("UDP连接失败：", se);
                MessageBox.Show($"UDP连接失败：{se.Message}");
                throw;
            }
        }

        private void ReciveClientMsg()
        {
            try
            {
                // while (true)
                while (FlagReceive)
                {
                    IPEndPoint clientEndPoint = new(IPAddress.Any, 0);   //初始化ip终结点
                    byte[] getData = client.Receive(ref clientEndPoint);//获取加入组播客户端的终结点
                    YDstate = true;
                    MVBValueRecive?.Invoke(getData);
                }
            }
            catch (SocketException se)
            {
                string err = "MVBDriver ReciveClientMsg() error SocketException ," + se.Message;
                NlogHelper.Default.Error("接收数据异常；", se);
                MessageBox.Show("接收数据异常；原因：" + se.Message);
            }
            catch (Exception ex)
            {
                string err = "MVBDriver ReciveClientMsg() error SocketException ," + ex.Message;
                NlogHelper.Default.Error("接收数据异常；", ex);
                MessageBox.Show("接收数据异常；原因：" + ex.Message);
            }
        }

        private void YDpd()
        {
            try
            {
                // while (true)
                while (!YDstate)
                {
                    Thread.Sleep(2000);
                    SendConnect([0xfe, 0x0a, 0x0d, 0x01, 0x00, 1, 0, 0xfe, 0xfa, 0xff]); //请求连接配置
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("配置帧异常；原因：" + ex.Message);
            }
        }
        /// <summary>
        /// 连接端口3001
        /// </summary>
        /// <param name="Msg"></param>
        public void SendConnect(byte[] Msg)
        {
            client.Send(Msg, Msg.Length, remotePoint3001);//将数据发送到远程端点

            //client.Send(Msg, Msg.Length, remotePoint4001);//本地模拟，暂时发送同一个端口，否则容易报出错误“远程主机强迫关闭了一个现有的连接”
        }
        public void Send(byte[] Msg)
        {
            client.Send(Msg, Msg.Length, remotePoint4001);//将数据发送到远程端点
        }

        public void Close()
        {
            FlagReceive = false;
            if (client != null)
            {
                try
                {
                    client.Close();
                    client.Dispose();
                    client = null;
                }
                catch { }
            }
        }
    }
}
