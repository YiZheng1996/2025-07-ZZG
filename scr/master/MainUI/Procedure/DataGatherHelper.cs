using MainUI.CurrencyHelper;
using Sunny.UI.Win32;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Procedure
{
    internal static class DataGatherHelper
    {
        //列名
        public static List<string> strings = new() { "时间", "试验台传感器", "MVB数据", "CAN数据", "以太网数据", "预留1", "预留2", "预留3", "预留4" };
        public static ConcurrentDictionary<string, ConcurrentDictionary<string, string>> keyValuePairs = new();
        public static CancellationTokenSource DataCts = new();
        public static ManualResetEvent manual = new(true);
        /// <summary>
        /// 添加实时数据集合
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="dic"></param>
        public static void AddData(string keyName, ConcurrentDictionary<string, string> dic)
        {
            keyValuePairs.AddOrUpdate(keyName, dic, (key, value) => dic);
        }

        /// <summary>
        /// 记录实时值
        /// </summary>
        public static Task DataGather()
        {
            ConcurrentDictionary<string, string> pairs = new();
            string fileName = DateTime.Now.ToString("yyyy_MM_dd") + ".csv";
            string filePath = Application.StartupPath + "Autosave\\" + fileName;
            CSVHelper.CreateFile(filePath);
            CancellationToken Token = DataCts.Token;
            return Task.Factory.StartNew(() =>
                 {
                     while (!Token.IsCancellationRequested)
                     {
                         var timeStamp = DateTime.Now.ToString("yyyy:MM:dd HH:mm:ss fff");
                         pairs.AddOrUpdate("TimeNow", timeStamp, (key, value) => timeStamp);
                         AddData("ATime", pairs);
                         var a = CSVHelper.Save(filePath, keyValuePairs);
                         Task.Delay(200).Wait();
                         manual.WaitOne();
                     }
                 }, Token);
        }
    }
}
