using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RW.Configuration;
using System.Windows.Forms;
using System.ComponentModel;

namespace MainUI.Config
{
    public class ParaConfig : IniConfig
    {
        public ParaConfig()
          : base(Application.StartupPath + "\\config\\Para.ini")
        {
        }
        public ParaConfig(string sectionName)
            : base(Application.StartupPath + "\\config\\Para.ini")
        {
            SetSectionName(sectionName);
            Load();
        }

        /// <summary>
        /// 大闸试验次数
        /// </summary>
        [IniKeyName("大闸试验次数")]
        public int bigTestNumber { get; set; }

        /// <summary>
        /// 大闸当前试验次数
        /// </summary>
        [IniKeyName("大闸当前试验次数")]
        public int bigNowTest { get; set; }

        /// <summary>
        /// 小闸试验次数
        /// </summary>
        [IniKeyName("小闸试验次数")]
        public int smallTestNumber { get; set; }

        /// <summary>
        /// 小闸当前试验次数
        /// </summary>
        [IniKeyName("小闸当前试验次数")]
        public int samllGigNowTest { get; set; }

    }
}
