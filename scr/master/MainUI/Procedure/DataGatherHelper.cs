using System.IO;

namespace MainUI.Procedure
{
    internal static class DataGatherHelper
    {
        public static string filePath { get; set; }
        //列名
        public static List<string> strings = ["时间", "试验台传感器", "MVB数据", "CAN数据", "以太网数据", "预留1", "预留2", "预留3", "预留4"];
        public static ConcurrentDictionary<string, ConcurrentDictionary<string, string>> keyValuePairs = new();
        public static CancellationTokenSource DataCts = new();

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
            string DirectryPath = Application.StartupPath + "Autosave\\";
            ConcurrentDictionary<string, string> pairs = new();
            if (!Directory.Exists(DirectryPath + VarHelper.ModelName))
                Directory.CreateDirectory(DirectryPath  + VarHelper.ModelName);
            string DirectryDatePath = DirectryPath + VarHelper.ModelName + "\\" + DateTime.Now.ToString("yyyy-MM-dd");
            if (!Directory.Exists(DirectryDatePath))
                Directory.CreateDirectory(DirectryDatePath);
            string fileName = DateTime.Now.ToString("HH：mm：ss") + ".csv";
            filePath = DirectryDatePath + "\\" + fileName;
            CSVHelper.CreateFile(filePath);
            DataCts = new CancellationTokenSource();
            CancellationToken Token = DataCts.Token;
            return Task.Factory.StartNew(() =>
                 {
                     while (!Token.IsCancellationRequested)
                     {
                         var timeStamp = DateTime.Now.ToString("yyyy:MM:dd HH:mm:ss fff");
                         pairs.AddOrUpdate("TimeNow", timeStamp, (key, value) => timeStamp);
                         AddData("ATime", pairs);
                         var keyValue = CSVHelper.Save(filePath, keyValuePairs);
                         Task.Delay(200).Wait();
                         //manual.WaitOne();
                     }
                 }, Token);
        }
    }
}
