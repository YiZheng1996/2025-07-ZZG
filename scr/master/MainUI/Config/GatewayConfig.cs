using RW.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Config
{
    internal class GatewayConfig : IniConfig
    {
        public GatewayConfig()
         : base(Application.StartupPath + "config\\GatewayConfig.ini")
        {
            Load("Gateway");
        }

        [IniKeyName("TRDPIP1")]
        public string TRDPIP1 { get; set; }
        [IniKeyName("TRDPPort1")]
        public string TRDPPort1 { get; set; }
        [IniKeyName("LocalIP1")]
        public string LocalIP1 { get; set; }
        [IniKeyName("LocalPort1")]
        public string LocalPort1 { get; set; }

        [IniKeyName("TRDPIP2")]
        public string TRDPIP2 { get; set; }
        [IniKeyName("TRDPPort2")]
        public string TRDPPort2 { get; set; }
        [IniKeyName("LocalIP2")]
        public string LocalIP2 { get; set; }
        [IniKeyName("LocalPort2")]
        public string LocalPort2 { get; set; }
    }
}
