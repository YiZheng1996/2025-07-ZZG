﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO.Ports;

namespace MainUI.Equip
{
    public class TH2516
    {
        // 《TH2516系列直流低电阻测试仪使用说明书.pdf》 第48页，测量速度设定命令 APERture Fast/SLOW1
        /// <summary>
        /// 读取电阻的串口
        /// </summary>
        public static SerialPort serialPort2516B;
        // ----------读取TH2516B的电阻--RS232通讯，2,3，5脚接通。//2,3脚接线必须对调。//2,3脚接线必须对调。//2,3脚接线必须对调。
        //2,3脚接线必须对调。见《TH2516系列中文说明书.pdf》第38页。
        // RS:Recommended Standard，推荐标准。 2发送，3接受，5接地
        /// <summary>
        /// 线路内阻
        /// </summary>
        static double InnerDianzu = 0.0;
        /// <summary>
        /// 电阻测试仪TH2516B，读取当前电阻值。返回 电阻值或∞
        /// </summary>
        /// <returns></returns>
        public static string Read()
        {
            string dzValueRst = "∞";
            string str = "";
            bool hadRead = false; // 已经读到数据。


            int SetTimes = 2; //设定要循环读取的次数
            int curReadTimes = 0; // 每次读取电阻次数。
            try
            {
                if (!serialPort2516B.IsOpen)
                {
                    serialPort2516B.Open();

                }
                System.Threading.Thread.Sleep(20);
                //有时读取返回结果为空“”，需要多次读取结果。
                while (curReadTimes < SetTimes && hadRead == false)
                {
                    serialPort2516B.DiscardInBuffer();
                    Thread.Sleep(50);
                    serialPort2516B.DiscardOutBuffer();
                    Thread.Sleep(50);
                    //命令格式见《TH2516系列中文说明书.pdf》第47页。
                    serialPort2516B.Write("FETC:IMP?\r\n");
                    Thread.Sleep(100);
                    //str = " +221.998670E-03";  // 返回例子
                    str = serialPort2516B.ReadExisting();

                    if (str == "")
                        curReadTimes++;
                    else
                        hadRead = true;
                }
                if (str.Length > 0)
                {
                    string tmprst = str;
                    //读取当前电阻到当前双击的文本框。
                    string curDZ = GetDZResultTH2516B(str);
                    double dzValue = 0d;

                    if (curDZ != "∞")
                    {
                        //测量的值减去，参数设置的线路内阻。
                        dzValue = double.Parse(curDZ) - InnerDianzu;
                        dzValueRst = dzValue.ToString("f3");
                    }
                    else
                    {
                        dzValueRst = curDZ;
                    }
                }
                else
                    dzValueRst = "∞";
            }
            catch 
            {

            }
            return dzValueRst;
        }
        private static string GetDZResultTH2516B(string dzIn)
        {
            string result = "∞";
            try
            {
                // 正常传入参数  +1.998670E+03,+0,
                //+9.900000E+37    返回值错误代码
                // 1E+03,+0,+1.999911E+03,+0
                string unit = "kΩ";
                if (dzIn.Length > 10)
                {
                    if (dzIn.IndexOf("+9.900000E+37") > -1)
                    {
                        //result = "超量程";
                        result = "∞";
                        return result;
                    }

                    if (dzIn.Substring(1, 1) == "E")
                        return "∞";

                    if (dzIn.Substring(0, 1) == "-")
                        return "∞";
                }
                if (dzIn.Length > 10)
                {
                    result = dzIn.Substring(1, 6);
                    double r = Math.Round(double.Parse(result), 3);
                    result = r.ToString("#0.000");
                    if (dzIn.IndexOf("E-03") > -1 || dzIn.IndexOf("E-02") > -1 || dzIn.IndexOf("E-01") > -1 || dzIn.IndexOf("E-04") > -1 || dzIn.IndexOf("E-05") > -1 || dzIn.IndexOf("E-06") > -1)
                    {
                        if (dzIn.IndexOf("E-01") > -1)
                        {
                            result = Convert.ToString(double.Parse(result) * 100.0);
                        }
                        else if (dzIn.IndexOf("E-02") > -1)
                        {
                            result = Convert.ToString(double.Parse(result) * 10.0);
                        }
                        else if (dzIn.IndexOf("E-03") > -1)
                        {
                            result = Convert.ToString(double.Parse(result) * 1.0);
                        }
                        if (dzIn.IndexOf("E-04") > -1)
                        {
                            result = Convert.ToString(double.Parse(result) / 10.0);
                        }
                        else if (dzIn.IndexOf("E-05") > -1)
                        {
                            result = Convert.ToString(double.Parse(result) / 100.0);
                        }
                        else if (dzIn.IndexOf("E-06") > -1)
                        {
                            result = Convert.ToString(double.Parse(result) / 1000.0);
                        }
                        unit = "mΩ";

                    }
                    else if (dzIn.IndexOf("E+03") > -1 || dzIn.IndexOf("E+02") > -1 || dzIn.IndexOf("E+01") > -1 || dzIn.IndexOf("E+04") > -1 || dzIn.IndexOf("E+05") > -1 || dzIn.IndexOf("E+06") > -1)
                    {
                        unit = "kΩ";
                        if (dzIn.IndexOf("E+04") > -1)
                        {
                            result = Convert.ToString(double.Parse(result) * 10.0);
                        }
                        else if (dzIn.IndexOf("E+05") > -1)
                        {
                            result = Convert.ToString(double.Parse(result) * 100.0);
                        }
                        else if (dzIn.IndexOf("E+06") > -1)
                        {
                            result = Convert.ToString(double.Parse(result) * 1000.0);
                        }

                        // KO 千欧转换成mO
                        double curKO = Convert.ToDouble(result);
                        double mO = curKO * 1000 * 1000;
                        result = mO.ToString();
                    }
                    else
                    {
                        // 欧姆 转换成mO
                        double curO = Convert.ToDouble(result);
                        double mO = curO * 1000;
                        result = mO.ToString();

                        unit = "Ω";
                    }
                    return result;
                }
            }
            catch (Exception ex)
            { }
            return result;
        }
        public static string PortRead_TH2516B()
        {
            int num = 0;//循环执行次数
            bool readdata = false;//是否读取到数据
            string rst = "";
            string rst2 = "";
            string rst3 = "";
            while (num < 15 && readdata == false)
            {
                num++;
                string str = "";
                try
                {
                    if (!serialPort2516B.IsOpen)
                    {
                        serialPort2516B.Open();
                    }
                    serialPort2516B.DiscardInBuffer();
                    serialPort2516B.DiscardOutBuffer();
                    Thread.Sleep(80);
                    serialPort2516B.Write("FETC:IMP?\r\n");
                    Thread.Sleep(500);
                    str = serialPort2516B.ReadExisting();

                    rst = Read_2516B(str);

                    if (rst != "999999" && rst != "0" && rst2 == "")
                    {
                        rst2 = rst;
                    }
                    else if (rst != "999999" && rst != "0" && rst2 != "" && rst3 == "")
                    {
                        rst3 = rst;
                    }
                    if (rst2 != "")
                    {
                        if (Math.Abs(Convert.ToDouble(rst2) - Convert.ToDouble(rst3)) <= 0.1)
                        {
                            readdata = true;
                        }
                        else
                        {
                            rst2 = rst3;
                            rst3 = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    num++;
                    string err = ex.Message;
                    Debug.WriteLine("触点电阻测量异常：" + err);
                }
            }
            if (rst2 == "")
            {
                rst2 = "999999";
            }
            return rst2;
        }
        private static string Read_2516B(string data)
        {

            // 正常传入参数  +1.998670E+03,+0,
            //+9.900000E+37    返回值错误代码
            // 1E+03,+0,+1.999911E+03,+0
            string tbdz_2516 = "";
            if (data.Length >= 16)
            {
                string value1 = data.Substring(0, 1);//起始符号+
                string value2 = data.Substring(1, 8);//电阻值小数部分
                string value3 = data.Substring(10, 3);//电阻值系数部分E
                int mul = 0;//系数
                double value = 0;
                double vlaue_2516 = 0;
                if (value1 != "+")
                {
                    if (value1 == "-")
                    {
                        value = double.Parse(value2);
                        string xs = value3.Substring(1, 2);
                        mul = int.Parse(xs);
                        vlaue_2516 = value / Math.Pow(10, mul) * 1000;
                        tbdz_2516 = vlaue_2516.ToString("#0.0#");
                    }
                    //return "0";
                }
                if (value3 == "+37")
                {
                    return "999999";
                }
                else
                {
                    string xs = value3.Substring(1, 2);
                    string ss = value3.Substring(0, 1);
                    mul = int.Parse(xs);
                    value = double.Parse(value2);
                    if (ss == "-")
                    {
                        vlaue_2516 = value / Math.Pow(10, mul) * 1000;
                        tbdz_2516 = vlaue_2516.ToString();
                    }
                    if (ss == "+")
                    {
                        vlaue_2516 = value * Math.Pow(10, mul) * 1000; //统一转换成毫欧
                        tbdz_2516 = vlaue_2516.ToString();
                    }
                }
            }
            return tbdz_2516;

        }
        public static void QingLing()
        {
                serialPort2516B.Write("FETC:IMP?\r\n");
        }
    }
}
