using RW.Configuration;

namespace MainUI.Config
{
    public class ConfigManager
    {
        static ConfigManager()
        {
            Layout = new LayoutConfig();
            System = new SystemConfig();
        }

        public static LayoutConfig Layout { get; set; }

        public static SystemConfig System { get; set; }

        /// <summary>
        /// 保存全部配置信息
        /// </summary>
        public static void Save()
        {
            Layout.Save();
            System.Save();
        }
    }
}
