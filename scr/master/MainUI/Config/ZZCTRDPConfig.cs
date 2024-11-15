using RW.Configuration;
using System.Windows.Forms;

namespace MainUI.Config
{
    public class ZZCTRDPConfig : IniConfig
    {

        public ZZCTRDPConfig()
            : base(Application.StartupPath + "\\config\\trdp.ini")
        {
            Load();
        }


        public ZZCTRDPConfig(string ininame)
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
            }
        }

        [IniKeyName("DesIP1")]
        public string DesIP1 { get; set; }
        [IniKeyName("Desport1")]
        public string Desport1 { get; set; }
        [IniKeyName("LocalIP1")]
        public string LocalIP1 { get; set; }
        [IniKeyName("LocalPort1")]
        public string LocalPort1 { get; set; }

        [IniKeyName("DesIP2")]
        public string DesIP2 { get; set; }
        [IniKeyName("Desport2")]
        public string Desport2 { get; set; }
        [IniKeyName("LocalIP2")]
        public string LocalIP2 { get; set; }
        [IniKeyName("LocalPort2")]
        public string LocalPort2 { get; set; }
    }
}
