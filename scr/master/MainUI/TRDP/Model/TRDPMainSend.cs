using RW.Configuration;
using RW.Core;
using RW.Driver.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.TRDP.Model
{

    /// <summary>
    /// TRDP配置帧主帧 3.7
    /// </summary>
    public class TRDPMainSend : IniConfig
    {
        public TRDPMainSend()
            : base(Application.StartupPath + "\\config\\trdp_eth0.ini")
        {
            DNSPort = 0x4349;
            TTDBMulticastPort = 0x4348;
            TCMSMulticastPort = 0x4348;
            TCMSPort = 0x4348;
            MinorTCMSPort = 0x4348;


            Mac = "00:00:00:00:00:00";
            IP = GateWay = SubnetMask = DNS = TTDBMulticastIP = TCMSMulticastIP = TCMSIP = MinorTCMSIP = SinglecastIP1 = SinglecastIP2 = "0.0.0.0";
            this.Load();
            ETHConfig ethconfig = new();
            if (ethconfig.ETH == 0)
                CommandType = TRDPMainCommandTypes.Eth0;
            else
                CommandType = TRDPMainCommandTypes.Eth1;
        }


        public TRDPMainSend(string ininame)
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


                DNSPort = 0x4349;
                TTDBMulticastPort = 0x4348;
                TCMSMulticastPort = 0x4348;
                TCMSPort = 0x4348;
                MinorTCMSPort = 0x4348;

                Mac = "00:00:00:00:00:00";
                IP = GateWay = SubnetMask = DNS = TTDBMulticastIP = TCMSMulticastIP = TCMSIP = MinorTCMSIP = SinglecastIP1 = SinglecastIP2 = "0.0.0.0";
                this.Load();
                ETHConfig ethconfig = new ETHConfig(iniName);
                if (ethconfig.ETH == 0)
                    CommandType = TRDPMainCommandTypes.Eth0;
                else
                    CommandType = TRDPMainCommandTypes.Eth1;
            }
        }

        /// <summary>
        /// 起始位
        /// </summary>
        public const int START = 0xFE;
        /// <summary>
        /// 命令类型，0x05，0x85
        /// </summary>
        public TRDPMainCommandTypes CommandType { get; set; }
        /// <summary>
        /// 数据长度
        /// </summary>
        public int DataLength { get; set; }
        /// <summary>
        /// MAC配置选择，默认为0x00
        /// </summary>
        public int MACAuto { get; set; }
        /// <summary>
        /// MAC地址，6字节
        /// </summary>
        public string Mac { get; set; }
        /// <summary>
        /// 模块IP地址
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 网关IP
        /// </summary>
        public string GateWay { get; set; }
        /// <summary>
        /// 子网掩码地址
        /// </summary>
        public string SubnetMask { get; set; }
        /// <summary>
        /// DNS地址
        /// </summary>
        public string DNS { get; set; }
        /// <summary>
        /// DNS端口号
        /// </summary>
        public int DNSPort { get; set; }
        /// <summary>
        /// TTDB组播地址
        /// </summary>
        public string TTDBMulticastIP { get; set; }
        /// <summary>
        /// TCMS组播地址
        /// </summary>
        public string TCMSMulticastIP { get; set; }
        /// <summary>
        /// TTDB组播端口号
        /// </summary>
        public int TTDBMulticastPort { get; set; }
        /// <summary>
        /// TCMS组播端口号
        /// </summary>
        public int TCMSMulticastPort { get; set; }
        /// <summary>
        /// 主TCMS IP 地址
        /// </summary>
        public string TCMSIP { get; set; }
        /// <summary>
        /// 主TCMS 的端口
        /// </summary>
        public int TCMSPort { get; set; }
        /// <summary>
        /// 备用TCMS IP地址
        /// </summary>
        public string MinorTCMSIP { get; set; }
        /// <summary>
        /// 备用TCMS 端口
        /// </summary>
        public int MinorTCMSPort { get; set; }
        /// <summary>
        /// 注册接收TCMS的COMID数量
        /// </summary>
        public int COMIDCount { get; set; }
        /// <summary>
        /// 注册接收TCMS的COMID1字节数据，从高到低 4字节
        /// </summary>
        public int COMID1 { get; set; }
        /// <summary>
        /// 注册接收TCMS的COMID2字节数据，从高到低 4字节
        /// </summary>
        public int COMID2 { get; set; }
        /// <summary>
        /// 注册接收TCMS的COMID3字节数据，从高到低 4字节
        /// </summary>
        public int COMID3 { get; set; }
        /// <summary>
        /// 注册接收TCMS的COMID4字节数据，从高到低 4字节
        /// </summary>
        public int COMID4 { get; set; }
        /// <summary>
        /// 注册自由单播通讯端口数量0为禁止，1，2
        /// </summary>
        public int SinglecastCount { get; set; }
        /// <summary>
        /// 单播1的目标ID地址，高低字节
        /// </summary>
        public string SinglecastIP1 { get; set; }
        /// <summary>
        /// 单播1的目标端口，高低字节
        /// </summary>
        public int SinglecastPort1 { get; set; }
        /// <summary>
        /// 单播1的源端口，高低字节
        /// </summary>
        public int SinglecastSourcePort1 { get; set; }

        /// <summary>
        /// 单播2的目标ID地址，高低字节
        /// </summary>
        public string SinglecastIP2 { get; set; }
        /// <summary>
        /// 单播2的目标端口，高低字节
        /// </summary>
        public int SinglecastPort2 { get; set; }
        /// <summary>
        /// 单播2的源端口，高低字节
        /// </summary>
        public int SinglecastSourcePort2 { get; set; }

        /// <summary>
        /// CRC校验
        /// </summary>
        public byte[] CRC { get; set; }




        public void InitData(byte[] data)
        {
            if (data.Length != 89) return;


        }

        public byte[] ToBytes()
        {
            byte[] bts = new byte[89];
            bts[0] = (byte)START;
            bts[1] = (byte)this.CommandType;
            bts[2] = 0x00;
            bts[3] = 83;
            bts[4] = 0x38;

            var byteMac = RW.RWConvert.ToMACBytes(Mac);

            Array.Copy(byteMac, 0, bts, 5, byteMac.Length);

            byte[] ip = RW.RWConvert.ToIPBytes(IP);
            Array.Copy(ip, 0, bts, 11, ip.Length);

            byte[] gateway = RW.RWConvert.ToIPBytes(GateWay);
            Array.Copy(gateway, 0, bts, 15, gateway.Length);
            byte[] subnet = RW.RWConvert.ToIPBytes(SubnetMask);
            Array.Copy(subnet, 0, bts, 19, subnet.Length);
            byte[] dns = RW.RWConvert.ToIPBytes(DNS);
            Array.Copy(dns, 0, bts, 23, dns.Length);
            byte[] dnsport = BitConverter.GetBytes((short)DNSPort);
            bts[27] = dnsport[1];
            bts[28] = dnsport[0];

            byte[] ttdbMultiIP = RW.RWConvert.ToIPBytes(TTDBMulticastIP);
            Array.Copy(ttdbMultiIP, 0, bts, 29, ttdbMultiIP.Length);
            byte[] tcmsMultiIP = RW.RWConvert.ToIPBytes(TCMSMulticastIP);
            Array.Copy(tcmsMultiIP, 0, bts, 33, tcmsMultiIP.Length);

            byte[] ttdbPort = BitConverter.GetBytes((short)TTDBMulticastPort);
            bts[37] = ttdbPort[1];
            bts[38] = ttdbPort[0];
            byte[] tcmsMultiPort = BitConverter.GetBytes((short)TCMSMulticastPort);
            bts[39] = tcmsMultiPort[1];
            bts[40] = tcmsMultiPort[0];

            byte[] tcmsIP = RW.RWConvert.ToIPBytes(TCMSIP);
            Array.Copy(tcmsIP, 0, bts, 41, tcmsIP.Length);
            byte[] tcmsPort = BitConverter.GetBytes((short)TCMSPort);
            bts[45] = tcmsPort[1];
            bts[46] = tcmsPort[0];

            byte[] minorTCMSIP = RW.RWConvert.ToIPBytes(this.MinorTCMSIP);
            Array.Copy(minorTCMSIP, 0, bts, 47, minorTCMSIP.Length);
            byte[] minorTCMSPort = BitConverter.GetBytes((short)this.MinorTCMSPort);
            bts[51] = minorTCMSPort[1];
            bts[52] = minorTCMSPort[0];

            bts[53] = (byte)COMIDCount;
            byte[] com1 = BitConverter.GetBytes(COMID1).Reverse().ToArray();
            Array.Copy(com1, 0, bts, 54, com1.Length);
            byte[] com2 = BitConverter.GetBytes(COMID2).Reverse().ToArray();
            Array.Copy(com2, 0, bts, 58, com2.Length);
            byte[] com3 = BitConverter.GetBytes(COMID3).Reverse().ToArray();
            Array.Copy(com3, 0, bts, 62, com3.Length);
            byte[] com4 = BitConverter.GetBytes(COMID4).Reverse().ToArray();
            Array.Copy(com4, 0, bts, 66, com4.Length);

            bts[70] = (byte)SinglecastCount;
            byte[] singlecastIP1 = RW.RWConvert.ToIPBytes(this.SinglecastIP1);
            Array.Copy(singlecastIP1, 0, bts, 71, singlecastIP1.Length);
            byte[] singlecastPort1 = BitConverter.GetBytes((short)this.SinglecastPort1);
            bts[75] = singlecastPort1[1];
            bts[76] = singlecastPort1[0];
            byte[] singlecastSouncePort1 = BitConverter.GetBytes((short)this.SinglecastSourcePort1);
            bts[77] = singlecastSouncePort1[1];
            bts[78] = singlecastSouncePort1[0];

            byte[] singlecastIP2 = RW.RWConvert.ToIPBytes(this.SinglecastIP2);
            Array.Copy(singlecastIP2, 0, bts, 79, singlecastIP2.Length);
            byte[] singlecastPort2 = BitConverter.GetBytes((short)this.SinglecastPort2);
            bts[83] = singlecastPort2[1];
            bts[84] = singlecastPort2[0];
            byte[] singlecastSouncePort2 = BitConverter.GetBytes((short)this.SinglecastSourcePort2);
            bts[85] = singlecastSouncePort2[1];
            bts[86] = singlecastSouncePort2[0];

            this.CRC = CRCHelper.CRC16(bts, 4, bts.Length - 2);

            //var tempbytes = RW.RWConvert.HexStringToBytes("FE 05 00 53 38 00 22 33 44 55 66 0A 80 01 1C 0A 80 01 01 FF FF FF 00 00 00 00 00 43 49 00 00 00 00 E0 01 01 09 43 49 50 44 0A 80 01 04 50 44 00 00 00 00 50 44 01 00 00 03 E8 00 00 03 E8 00 00 03 E8 00 00 03 E8 00 00 00 00 00 1F 4F 1F 4F 00 00 00 00 1F 4F 1F 4F 70 C2");

            //var tempCRC = CRCHelper.CRC16(tempbytes, 4, tempbytes.Length - 2);

            bts[87] = CRC[0];
            bts[88] = CRC[1];

            return bts;
        }


    }

    public enum TRDPMainCommandTypes
    {
        Eth0 = 0x05,
        Eth1 = 0x85,
    }

}
