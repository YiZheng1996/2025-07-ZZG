using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace MainUI.MVB
{
    /// <summary>
    /// 通用方法类
    /// </summary>
    public class ConvertClass
    {

        /// <summary>
        /// 将2维Word数组转换为2维Byte数组
        /// </summary>
        /// <param name="arrData"></param>
        /// <returns></returns>
        public static byte[,] ConvertWordToByte(short[,] arrData)
        {
            int l0 = arrData.GetLength(0);
            int l1 = arrData.GetLength(1);

            byte[,] outData = new byte[l0, l1 * 2];

            for (int i = 0; i < l0; i++)
            {
                for (int j = 0; j < l1; j++)
                {
                    try
                    {
                        //将word类型转换为2个byte
                        byte[] arrb = BitConverter.GetBytes(arrData[i, j]);
                        //反转1维数组
                        Array.Reverse(arrb);
                        outData[i, j * 2 + 0] = arrb[0];
                        outData[i, j * 2 + 1] = arrb[1];
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            return outData;

        }

        /// <summary>
        ///  将2维byte数组转换为2维word数组
        /// </summary>
        /// <param name="arrbyte"></param>
        /// <returns></returns>
        public static ushort[,] ConvertByteToWord(byte[,] arrbyte)
        {
            int l0 = arrbyte.GetLength(0);
            int l1 = arrbyte.GetLength(1);

            ushort[,] outData = new ushort[l0, l1 / 2];

            for (int i = 0; i < l0; i++)
            {
                for (int j = 0; j < l1 / 2; j++)
                {
                    ////将word类型转换为2个byte
                    //byte[] arrb = BitConverter.GetBytes(arrData[i, j]);
                    ////反转1维数组
                    //Array.Reverse(arrb);
                    //outData[i, j * 2 + 0] = arrb[0];
                    //outData[i, j * 2 + 1] = arrb[1];
                    byte[] arrb = new byte[2] { arrbyte[i, j * 2 + 1], arrbyte[i, j * 2 + 0] };
                    outData[i, j] = (ushort)BitConverter.ToUInt16(arrb, 0);
                }
            }

            return outData;
        }

        /// <summary>
        /// 十进制数据 → bool[]  转换
        /// </summary>
        /// <param name="i10">要进行转换的十进制数</param>
        ///<returns>换换后的bool[]</returns>
        public static bool[] conversion2(int i10)
        {
            bool[] barray = new bool[8];
            try
            {
                string str2 = Convert.ToString(i10, 2);
                str2 = str2.PadLeft(8, '0');
                barray[0] = (str2.Substring(7, 1) == "1") ? true : false;
                barray[1] = (str2.Substring(6, 1) == "1") ? true : false;
                barray[2] = (str2.Substring(5, 1) == "1") ? true : false;
                barray[3] = (str2.Substring(4, 1) == "1") ? true : false;
                barray[4] = (str2.Substring(3, 1) == "1") ? true : false;
                barray[5] = (str2.Substring(2, 1) == "1") ? true : false;
                barray[6] = (str2.Substring(1, 1) == "1") ? true : false;
                barray[7] = (str2.Substring(0, 1) == "1") ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("十制数据转换二进制数据出错 \r\n" + ex.Message);
            }
            return barray;
        }

        /// <summary>
        /// (+9重载)    二进制数据 → 十进制数据  转换
        /// </summary>
        /// <param name="b0">字节第 0 位值（右起第0位）</param>
        /// <param name="b1">字节第 1 位值（右起第1位）</param>
        /// <param name="b2">字节第 2 位值（右起第2位）</param>
        /// <param name="b3">字节第 3 位值（右起第3位）</param>
        /// <param name="b4">字节第 4 位值（右起第4位）</param>
        /// <param name="b5">字节第 5 位值（右起第5位）</param>
        /// <param name="b6">字节第 6 位值（右起第6位）</param>
        /// <param name="b7">字节第 7 位值（右起第7位）</param>
        /// <returns>转换后的十进制数</returns>
        public static int conversion10(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7)
        {
            int iadd10 = 0;
            string sb0 = (b0 == true) ? "1" : "0";
            string sb1 = (b1 == true) ? "1" : "0";
            string sb2 = (b2 == true) ? "1" : "0";
            string sb3 = (b3 == true) ? "1" : "0";
            string sb4 = (b4 == true) ? "1" : "0";
            string sb5 = (b5 == true) ? "1" : "0";
            string sb6 = (b6 == true) ? "1" : "0";
            string sb7 = (b7 == true) ? "1" : "0";
            try
            {
                string stradd = sb7.Trim() + sb6.Trim() + sb5.Trim() + sb4.Trim() + sb3.Trim() + sb2.Trim() + sb1.Trim() + sb0.Trim();
                stradd = stradd.PadLeft(8, '0');
                iadd10 = Convert.ToInt32(stradd, 2);
            }
            catch (Exception)
            {
                MessageBox.Show("二制数据转换十进制数据出错");
            }
            return iadd10;
        }

        /// <summary>
        /// 设置2维byte数组指定字节数组指定bit的值
        /// </summary>
        /// <param name="sendbyte"></param>
        /// <param name="PortIndex"></param>
        /// <param name="byteIndex"></param>
        /// <param name="bitIndex"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void ConvertBoolToByte(ref byte[,] sendbyte, int PortIndex, int byteIndex, int bitIndex, bool value)
        {
            byte bytevalue = sendbyte[PortIndex, byteIndex];

            bool[] barr = conversion2((int)bytevalue);
            barr[bitIndex] = value;

            bytevalue = (byte)conversion10(barr[0], barr[1], barr[2], barr[3], barr[4], barr[5], barr[6], barr[7]);
            sendbyte[PortIndex, byteIndex] = bytevalue;

        }

        /// <summary>
        /// 将16进制整数转换为两个byte
        /// </summary>
        /// <param name="Int16"></param>
        /// <param name="bH"></param>
        /// <param name="bL"></param>
        public static void ConvertInt16ToByte(int Int16, out byte bH, out byte bL)
        {
            bH = (byte)(Int16 / 256);
            bL = (byte)(Int16 % 256);
        }
    }

    public class MvbDllCall
    {
        #region 对象定义

        /// <summary>
        /// MVB网卡操作状态枚举
        /// </summary>
        public enum GF_RESULT
        {
            /// <summary>
            /// correct termination
            /// 网卡初始化成功
            /// </summary>
            GF_OK = 0,

            /// <summary>
            /// general failure
            /// 网卡初始化失败
            /// </summary>
            GF_ERROR = 2,

            /// <summary>
            /// configuration error occurred
            /// 配置错误
            /// </summary>
            GF_CONFIG = 3,

            /// <summary>
            /// not enough memory to complete operation
            /// 没有足够的内存去完成操作
            /// </summary>
            GF_MEMORY = 4,

            /// <summary>
            /// unknown traffic store
            /// 没有识别通讯存储器
            /// </summary>
            GF_UNKNOWN_TS = 5,

            /// <summary>
            /// wrong device address
            /// 设备地址错误
            /// </summary>
            GF_DEVICE_ADDRESS = 8,

            /// <summary>
            /// wrong input line
            /// </summary>
            GF_INPUT_LINE = 9,

            /// <summary>
            /// wrong reply timeout
            /// 应答超时
            /// </summary>
            GF_REPLY_TIMEOUT = 10
        }

        public enum LP_RESULT
        {
            LP_OK = 0,
            LP_PRT_PASSIVE = 1,
            LP_ERROR = 2,
            LP_CONFIG = 3,
            LP_MEMORY = 4,
            LP_UNKNOWN_TS = 5,
            LP_RANGE = 6,
            LP_DATA_TYPE = 7,
            LP_ERROR1 = 65535
        }


        //private static GF_RESULT _gf_result;

        /// <summary>
        /// MVB网卡操作状态
        /// </summary>
        public static GF_RESULT gf_result
        {
            get
            {
                return (GF_RESULT)gf_result_status();
            }
        }

        //private static LP_RESULT _lp_result;

        /// <summary>
        /// MVB网卡数据操作状态
        /// </summary>
        public static LP_RESULT lp_result
        {
            get
            {
                return (LP_RESULT)lp_result_status();
            }
        }

        public static string GetStatus()
        {
            return GetStatus(lp_result);
        }

        /// <summary>
        /// MVB连接状态
        /// </summary>
        /// <param name="value"></param>
        public static string GetStatus(LP_RESULT value)
        {
            string valueTxt = "";
            switch (lp_result)
            {
                case LP_RESULT.LP_OK:
                    valueTxt = "连接成功";
                    break;
                //case LP_RESULT.LP_PRT_PASSIVE:
                //    valueTxt = "网卡初始化失败";
                //    break;
                case LP_RESULT.LP_ERROR:
                    valueTxt = "网卡初始化失败";
                    break;
                case LP_RESULT.LP_CONFIG:
                    valueTxt = "配置错误";
                    break;
                case LP_RESULT.LP_MEMORY:
                    valueTxt = "内存不足";
                    break;
                case LP_RESULT.LP_UNKNOWN_TS:
                    valueTxt = "没有识别通讯存储器";
                    break;
                case LP_RESULT.LP_RANGE:
                    valueTxt = "连接失败";
                    break;
                case LP_RESULT.LP_DATA_TYPE:
                    valueTxt = "连接失败";
                    break;
                case LP_RESULT.LP_ERROR1:
                    valueTxt = "网卡初始化失败";
                    break;
                default:
                    break;
            }
            return valueTxt + "；";
        }


        const string filepath = @"c:\mvbdll\";
        //const string filepath = @".\mvbdll\"; 


        /// <summary>
        /// MVB网卡地址
        /// </summary>
        public static int Mvb_Address = 0x01;

        /// <summary>
        /// 源端口地址
        /// </summary>
        public static int[] PD_src_port_address = new int[64];

        /// <summary>
        /// 源端口数据大小（单位：byte）
        /// </summary>
        public static int[] PD_src_port_size = new int[64];

        /// <summary>
        /// 宿端口地址
        /// </summary>
        public static int[] PD_snk_port_address = new int[64];

        /// <summary>
        /// 宿端口数据大小（单位：byte）
        /// </summary>
        public static int[] PD_snk_port_size = new int[64];

        /// <summary>
        /// 源端口数据
        /// </summary>
        public static short[,] Port_data_src = new short[64, 16];

        /// <summary>
        /// 发送的源端口byte数组
        /// </summary>
        public static byte[,] sendbyte = new byte[64, 32];

        /// <summary>
        /// 读取数据
        /// </summary>
        public static byte[,] readbyte = new byte[64, 32];

        /// <summary>
        /// 网络配置文件名称
        /// </summary>
        public static string Configfilename = "DK2.bin";

        /// <summary>
        /// 源宿端口配置文件名称
        /// </summary>
        public static string Configfilename_port = "MvbConfig_DK2.txt";



        #endregion

        #region 原始函数

        /// <summary>
        /// gf_result状态获取
        /// </summary>
        /// <returns></returns>
        [DllImport(filepath + "MvbSendRecv.dll", EntryPoint = "gf_result_status", CharSet = CharSet.Auto)]
        public static extern int gf_result_status();

        /// <summary>
        /// lp_result状态获取
        /// </summary>
        /// <returns></returns>
        [DllImport(filepath + "MvbSendRecv.dll", EntryPoint = "lp_result_status", CharSet = CharSet.Auto)]
        public static extern int lp_result_status();

        /// <summary>
        /// 停止MVB网卡
        /// </summary>
        /// <returns></returns>
        [DllImport(filepath + "MvbSendRecv.dll", EntryPoint = "StopMvb", CharSet = CharSet.Auto)]
        public static extern int StopMvb();

        /// <summary>
        /// 启动MVB网卡服务
        /// </summary>
        /// <param name="object_filename">BIN配置文件路径及名称</param>
        /// <param name="mvb_address">MVB网卡地址</param>
        /// <param name="pPD_src_port_address">源端口地址</param>
        /// <param name="pPD_src_port_size">源端口字节大小（0：TS_PORT_SIZE1,1：TS_PORT_SIZE2,2：TS_PORT_SIZE4,3：TS_PORT_SIZE8,4：TS_PORT_SIZE16）1SIZE=16bit=2byte=1word</param>
        /// <param name="pPD_snk_port_address">宿端口地址</param>
        /// <param name="pPD_snk_port_size">宿端口字节大小（0：TS_PORT_SIZE1,1：TS_PORT_SIZE2,2：TS_PORT_SIZE4,3：TS_PORT_SIZE8,4：TS_PORT_SIZE16）1SIZE=16bit=2byte=1word</param>
        /// <param name="pPort_data_src"></param>
        /// <returns></returns>
        [DllImport(filepath + "MvbSendRecv.dll", EntryPoint = "startMvb", CharSet = CharSet.Auto)]
        public static extern int startMvb([MarshalAs(UnmanagedType.LPStr)] StringBuilder object_filename, int mvb_address, int[] pPD_src_port_address,
            int[] pPD_src_port_size, int[] pPD_snk_port_address, int[] pPD_snk_port_size, short[,] pPort_data_src);

        /// <summary>
        /// 读取MVB数据
        /// </summary>
        /// <param name="DataSet"></param>
        /// <returns></returns>
        [DllImport(filepath + "MvbSendRecv.dll", EntryPoint = "GetCollection", CharSet = CharSet.Auto)]
        public static extern int GetCollection(short[,] DataSet);

        /// <summary>
        /// 下发MVB数据
        /// </summary>
        /// <param name="DataSet"></param>
        /// <returns></returns>
        [DllImport(filepath + "MvbSendRecv.dll", EntryPoint = "SetCollection", CharSet = CharSet.Auto)]
        public static extern int SetCollection(ushort[,] DataSet);

        /// <summary>
        /// 将源端口发送数据保存到txt文件（SrcData.txt）中
        /// </summary>
        /// <returns></returns>
        [DllImport(filepath + "MvbSendRecv.dll", EntryPoint = "SrcDataTxt", CharSet = CharSet.Auto)]
        public static extern int SrcDataTxt();

        /// <summary>
        /// 将宿端口接收数据保存到txt文件（SnkData.txt）中
        /// </summary>
        /// <returns></returns>
        [DllImport(filepath + "MvbSendRecv.dll", EntryPoint = "SnkDataTxt", CharSet = CharSet.Auto)]
        public static extern int SnkDataTxt();

        #endregion

        #region 二次封装函数
        /// <summary>
        /// 启动MVB网卡服务
        /// <returns></returns>
        public static int startMvb()
        {
            StringBuilder object_filename = new StringBuilder(124);
            object_filename.Append(Configfilename);

            int[] pPD_src_port_wordsize = new int[PD_src_port_size.Length];
            int[] pPD_snk_port_wordsize = new int[PD_snk_port_size.Length];

            //将源端口byte数据大小转换为word大小
            for (int i = 0; i < PD_src_port_size.Length; i++)
            {
                pPD_src_port_wordsize[i] = (int)Math.Log((PD_src_port_size[i] / 2), 2);
            }

            //将宿端口byte数据大小转换为word大小
            for (int i = 0; i < PD_snk_port_size.Length; i++)
            {
                pPD_snk_port_wordsize[i] = (int)Math.Log((PD_snk_port_size[i] / 2), 2);
            }

            int status = startMvb(object_filename, Mvb_Address, PD_src_port_address, pPD_src_port_wordsize, PD_snk_port_address, pPD_snk_port_wordsize, Port_data_src);
            return status;
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="readbyte">读取的数据</param>
        /// <returns></returns>
        public static int GetCollection(out byte[,] readbyte)
        {
            short[,] pDataSet = new short[PD_snk_port_address.Length, 16];
            int i = MvbDllCall.GetCollection(pDataSet);
            readbyte = ConvertClass.ConvertWordToByte(pDataSet);
            return i;
        }

        /// <summary>
        /// 读取数据
        /// </summary>        
        /// <returns></returns>
        public static int GetCollection()
        {
            short[,] pDataSet = new short[PD_snk_port_address.Length, 16];
            int i = MvbDllCall.GetCollection(pDataSet);
            readbyte = ConvertClass.ConvertWordToByte(pDataSet);
            return i;
        }

        /// <summary>
        /// 得到MVB读取数据的指定端口、字节、位索引的值
        /// </summary>
        /// <param name="PortIndex">端口索引</param>
        /// <param name="ByteIndex">字节索引</param>
        /// <param name="BitIndex">位索引</param>
        /// <returns>返回指定端口-字节-位的值</returns>
        public static bool GetCollection(int PortIndex, int ByteIndex, int BitIndex)
        {
            bool[] b = ConvertClass.conversion2(readbyte[PortIndex, ByteIndex]);
            return b[BitIndex];
        }

        /// <summary>
        /// 设置MVB数据
        /// </summary>
        /// <returns>返回发送结果</returns>
        public static int SetCollection()
        {
            ushort[,] senddata = ConvertClass.ConvertByteToWord(sendbyte);
            return SetCollection(senddata);
        }

        /// <summary>
        /// 设置源端口的地址与数据大小
        /// </summary>
        /// <param name="index">端口索引</param>
        /// <param name="Port">端口地址</param>
        /// <param name="byteLength">端口字节大小</param>
        public static void SetSrcPort(int index, int Port, int byteSize)
        {
            PD_src_port_address[index] = Port;
            PD_src_port_size[index] = byteSize;
        }

        /// <summary>
        /// 设置宿端口的地址与数据大小
        /// </summary>
        /// <param name="index">端口索引</param>
        /// <param name="Port">端口地址</param>
        /// <param name="byteLength">端口字节大小</param>
        public static void SetSnkPort(int index, int Port, int byteSize)
        {
            PD_snk_port_address[index] = Port;
            PD_snk_port_size[index] = byteSize;
        }

        /// <summary>
        /// 返回当前可执行文件夹下MvbConfig.txt文件中源端口的大小及大小
        /// </summary>
        /// <param name="port">端口地址数组</param>
        /// <param name="size">端口大小数组</param>
        public static void MvbConfigLoad(out int[] src_port, out int[] src_size, out int[] snk_port, out int[] snk_size)
        {
            src_port = new int[64];
            src_size = new int[64];
            snk_port = new int[64];
            snk_size = new int[64];

            bool b = File.Exists(Configfilename_port);
            string[] stringlines;
            if (b)
            {
                stringlines = File.ReadAllLines(Configfilename_port, Encoding.Default);
            }
            else
            {
                MessageBox.Show(Configfilename_port + "配置文件不存在");
                stringlines = new string[0];
            }


            //当前端口类型，0：空，1：源端口，2：宿端口
            int iprottype = 0;

            if (stringlines.Length > 0)
            {
                for (int i = 0; i < stringlines.Length; i++)
                {
                    //判断当前是源端口数据还是宿端口数据
                    if (stringlines[i].Trim().Contains("源端口"))
                    {
                        iprottype = 1;
                        continue;
                    }
                    else if (stringlines[i].Trim().Contains("宿端口"))
                    {
                        iprottype = 2;
                        continue;
                    }
                    else if (stringlines[i].Trim() == "")
                    {
                        iprottype = 0;
                        continue;
                    }

                    //匹配字符串，从字符串中<1>[0x102,52]中取出0x102与52
                    Match match = Regex.Match(stringlines[i], @"^<(\d)>\[(\w+)\,(\d+)\]");
                    if (match.Success)
                    {
                        string index = match.Groups[1].Value;
                        string port = match.Groups[2].Value;
                        string size = match.Groups[3].Value;

                        int iindex = Convert.ToInt32(index);
                        int iport = Convert.ToInt32(port, 16);
                        int isize = Convert.ToInt32(size);

                        if (iprottype == 1)
                        {
                            src_port[iindex] = iport;
                            src_size[iindex] = isize;
                        }
                        if (iprottype == 2)
                        {
                            snk_port[iindex] = iport;
                            snk_size[iindex] = isize;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("配置文件中无任何内容");
            }

        }

        /// <summary>
        /// 将当前可执行文件夹下MvbConfig.txt文件中源端口的大小及大小加载到端口中
        /// </summary>
        public static void MvbConfigLoad()
        {

            bool b = File.Exists(Application.StartupPath + "\\" + Configfilename_port);
            string[] stringlines;
            if (b)
            {
                stringlines = File.ReadAllLines(Configfilename_port, Encoding.Default);
            }
            else
            {
                MessageBox.Show(Configfilename_port + "配置文件不存在");
                stringlines = new string[0];
            }


            //当前端口类型，0：空，1：源端口，2：宿端口
            int iprottype = 0;

            if (stringlines.Length > 0)
            {
                for (int i = 0; i < stringlines.Length; i++)
                {
                    //判断当前是源端口数据还是宿端口数据
                    if (stringlines[i].Trim().Contains("源端口"))
                    {
                        iprottype = 1;
                        continue;
                    }
                    else if (stringlines[i].Trim().Contains("宿端口"))
                    {
                        iprottype = 2;
                        continue;
                    }
                    else if (stringlines[i].Trim() == "")
                    {
                        iprottype = 0;
                        continue;
                    }

                    //匹配字符串，从字符串中<1>[0x102,52]中取出0x102与52
                    Match match = Regex.Match(stringlines[i], @"^<(\d*)>\[(\w+)\,(\d+)\]");
                    if (match.Success)
                    {
                        string index = match.Groups[1].Value;
                        string port = match.Groups[2].Value;
                        string size = match.Groups[3].Value;

                        int iindex = Convert.ToInt32(index);
                        int iport = Convert.ToInt32(port, 16);
                        int isize = Convert.ToInt32(size);

                        if (iprottype == 1)
                        {
                            PD_src_port_address[iindex] = iport;
                            PD_src_port_size[iindex] = isize;
                        }
                        if (iprottype == 2)
                        {
                            PD_snk_port_address[iindex] = iport;
                            PD_snk_port_size[iindex] = isize;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("配置文件中无任何内容");
            }

        }

        /// <summary>
        /// 设置指定端口、指定高低字节，工程数值
        /// </summary>
        /// <param name="dvalue"></param>
        /// <param name="portIndex"></param>
        /// <param name="byteHIndex"></param>
        /// <param name="byteLIndex"></param>
        /// <param name="BitValue"></param>
        public static void SetInt16Value(double dvalue, int portIndex, int byteHIndex, int byteLIndex, double BitValue)
        {
            // 10.0 / 0.2 = 49 ，应为为50，转为整数后是49。 浮点计算的bug。
            //int bitnum = (int)(dvalue / BitValue);

            double temp = Math.Round((dvalue / BitValue), 0);
            int bitnum = Convert.ToInt16(temp);
            try
            {
                if (byteHIndex < 0)
                {
                    MvbDllCall.sendbyte[portIndex, byteLIndex] = (byte)bitnum;
                }
                else
                {
                    ConvertClass.ConvertInt16ToByte(bitnum, out MvbDllCall.sendbyte[portIndex, byteHIndex], out MvbDllCall.sendbyte[portIndex, byteLIndex]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("字节索引错误！");
            }
            MvbDllCall.SetCollection();
        }

        /// <summary>
        /// 设定指定端口、字节、位的值
        /// </summary>
        /// <param name="bvalue"></param>
        /// <param name="portIndex"></param>
        /// <param name="byteIndex"></param>
        /// <param name="bitIndex"></param>
        public static void SetBoolValue(bool bvalue, int portIndex, int byteIndex, int bitIndex)
        {
            ConvertClass.ConvertBoolToByte(ref MvbDllCall.sendbyte, portIndex, byteIndex, bitIndex, bvalue);
            MvbDllCall.SetCollection();
        }

        #endregion


        #region 自定义函数
        /// <summary>
        /// 返回指定端口的索引号
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public static int GetPortIndex(int port)
        {
            int index = Array.IndexOf(PD_src_port_address, port);
            if (index == -1)
                index = Array.IndexOf(PD_snk_port_address, port);
            return index;
        }

        public static int GetPortSize(int port)
        {
            int size = PD_snk_port_size[GetPortIndex(port)];
            if (size < 0)
                size = PD_src_port_size[GetPortIndex(port)];
            return size;
        }

        public static void SetValue(int port, int offset, object value)
        {
            SetValue(port, offset, 0, value);
        }

        public static void SetValue(int port, int offset, int bit, object value)
        {
            int portIndex = GetPortIndex(port);
            if (value is bool)
            {
                byte before = MvbDllCall.sendbyte[portIndex, offset];
                if (Convert.ToBoolean(value))
                    MvbDllCall.sendbyte[portIndex, offset] |= (byte)(1 << bit);
                else
                    MvbDllCall.sendbyte[portIndex, offset] &= (byte)~(1 << bit);
            }
            else if (value is byte || value is sbyte)
            {
                MvbDllCall.sendbyte[portIndex, offset] = Convert.ToByte(value);
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
                else if (value is double)
                {
                    double val = (double)value;
                    bts = BitConverter.GetBytes(val).Reverse().ToArray();
                }

                for (int i = 0; bts != null && i < bts.Length; i++)
                {
                    MvbDllCall.sendbyte[portIndex, offset + i] = bts[i];
                }
            }
            MvbDllCall.SetCollection();

        }




        #endregion

    }


}
