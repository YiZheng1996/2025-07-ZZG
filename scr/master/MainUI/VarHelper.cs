using RW.Data;
using RW.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MainUI
{
    static class VarHelper
    {
        public static int ModelID; //型号ID
        public static string ModelName; //型号名称
        public static string PortName = "接口地址读取";
        public static string SoftName = "制动系统联调试验台";
        public static OPCDriver opcDOGroup = new();
        public static OPCDriver opcDIGroup = new();
        public static OPCDriver opcAOGroup = new();
        public static OPCDriver opcAIGroup = new();
        public static OPCDriver opcStatus = new();
        public static OPCDriver opcTestCon = new();
        public static OPCDriver opcServoGroup = new();
        public static OPCDriver opcIO = new("KEPware.KEPServerEx.V6", "IOCard.Device1.");//IO板，OPC节点 名称不能用中文。
        public static string rootRptSave = Application.StartupPath + "\\save";  //报表保存路径
        public static OleDB Database = new();
        public static string ConnectionString = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb;jet oledb:database password=ok";  //Acess数据库连接字符串

        public static string sQLiteConnectionString = @"Data Source=TestBed.db;";  //Sqlite数据库连接字符串
        public static SQLiteDB sQLiteDB = new();

        /// <summary>
        /// 生命信号字节
        /// </summary>
        public static int lifeport = 0;

        /// <summary>
        /// 创建OPC连接地址
        /// </summary>
        static VarHelper()
        {
            string kepServerName = "KEPware.KEPServerEx.V6";
            opcDOGroup.ServerName = kepServerName;
            opcDOGroup.Prefix = "SMART.PLC.";
            opcDIGroup.ServerName = kepServerName;
            opcDIGroup.Prefix = "SMART.PLC.";
            opcAIGroup.ServerName = kepServerName;
            opcAIGroup.Prefix = "SMART.PLC.";
            opcAOGroup.ServerName = kepServerName;
            opcAOGroup.Prefix = "SMART.PLC.";

            opcStatus.ServerName = kepServerName;
            opcStatus.Prefix = "SMART.PLC.";
            opcTestCon.ServerName = kepServerName;
            opcTestCon.Prefix = "SMART.PLC.";
        }
        /// <summary>
        /// OPC打开
        /// </summary>
        public static void Connect()
        {
            opcDOGroup.Connect();
            opcDIGroup.Connect();
            opcAIGroup.Connect();
            opcAOGroup.Connect();
            opcStatus.Connect();
            opcTestCon.Connect();
            opcIO.Connect();

        }
        /// <summary>
        /// OPC关闭
        /// </summary>
        public static void Close()
        {
            opcDOGroup.Close();
            opcDIGroup.Close();
            opcAIGroup.Close();
            opcAOGroup.Close();
            opcStatus.Close();
            opcTestCon.Close();
            opcIO.Close();
        }
        /// <summary>
        /// 量程转换
        /// </summary>
        /// <param name="input"></param>
        /// <param name="inputL">4</param>
        /// <param name="inputH">20</param>
        /// <param name="outL">0</param>
        /// <param name="outH">1000</param>
        /// <returns></returns>
        public static double AIAO_Convert(double input, double inputL, double inputH, double outL, double outH)
        {
            double rst = (outH - outL) * (input - inputL) / (inputH - inputL) + outL;
            rst = Math.Round(rst, 3);
            return rst;
        }
        /// <summary>
        /// 将板卡数据保存至CSV文件
        /// </summary>
        /// <param name="chutouVolt">板卡数据数组</param>
        public static void TxtWrite(double[,] chutouVolt)
        {
            try
            {
                string flleName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";
                string fllePath = Application.StartupPath + "\\Autosave\\";
                if (System.IO.Directory.Exists(fllePath) == false)
                    System.IO.Directory.CreateDirectory(fllePath);

                string fullPath = fllePath + flleName;
                System.IO.StreamWriter sw = new(fullPath, false, Encoding.GetEncoding("GB2312"));
                string txtContent = "ChuTou,220V,110V,24V" + "\r\n";
                sw.Write(txtContent);
                for (int i = 0; i < chutouVolt.GetLength(1); i++)
                {
                    txtContent = string.Format("{0},{1},{2},{3}\r\n", chutouVolt[0, i], chutouVolt[10, i], chutouVolt[8, i], chutouVolt[9, i]);
                    sw.Write(txtContent);
                }
                sw.Close();
            }
            catch (Exception ex)
            {

                string err = ex.Message;
            }
        }
        /// <summary>
        /// 将CSV数据转成集合数据
        /// </summary>
        /// <param name="filePath">CSV文件地址</param>
        /// <returns></returns>
        public static List<ListPoint> ReadCSV(string filePath)
        {
            Encoding encoding = Encoding.Default;
            System.IO.FileStream fs = new(filePath, System.IO.FileMode.Open,
                System.IO.FileAccess.Read);
            System.IO.StreamReader sr = new(fs, encoding);
            string txt = "";
            List<ListPoint> listPoint = [];
            while ((txt = sr.ReadLine()) != null)
            {
                ListPoint lp = new();
                string[] s = txt.Split(',');
                if (s == null || s.Length < 2)
                    continue;
                lp.X = double.Parse(s[1]);
                lp.Y = double.Parse(s[0]);
                listPoint.Add(lp);
            }
            fs.Close();
            return listPoint;
        }
        public static bool ToBool(this object obj, bool ret = false)
        {
            bool.TryParse(obj + "", out ret);
            return ret;
        }
        public static int ToInt(this object obj, int ret = 0)
        {
            int.TryParse(obj + "", out ret);
            return ret;
        }
        public static double ToDouble(this object obj, double ret = 0)
        {
            double.TryParse(obj + "", out ret);
            return ret;
        }
        public static decimal ToDecimal(this object obj, decimal ret = 0)
        {
            decimal.TryParse(obj + "", out ret);
            return ret;
        }

    }
    public class ListPoint
    {
        public ListPoint() { }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
