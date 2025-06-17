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
          : base(Application.StartupPath + "config\\Para.ini")
        {
            Load();
        }
        public ParaConfig(string sectionName)
            : base(Application.StartupPath + "config\\Para.ini")
        {
            SetSectionName(sectionName);
            Load();
        }


        /// <summary>
        /// 试验次数
        /// </summary>
        [IniKeyName("试验次数")]
        public int TestNumber { get; set; }

        ///// <summary>
        ///// 当前试验次数
        ///// </summary>
        //[IniKeyName("当前试验次数")]
        //public int NowTestNumber { get; set; }

        ///// <summary>
        ///// 大闸试验次数
        ///// </summary>
        //[IniKeyName("大闸试验次数")]
        //public int bigTestNumber { get; set; }

        /// <summary>
        /// 大闸当前试验次数
        /// </summary>
        [IniKeyName("大闸当前试验次数")]
        public int bigNowTest { get; set; }

        ///// <summary>
        ///// 小闸试验次数
        ///// </summary>
        //[IniKeyName("小闸试验次数")]
        //public int smallTestNumber { get; set; }

        /// <summary>
        /// 小闸当前试验次数
        /// </summary>
        [IniKeyName("小闸当前试验次数")]
        public int smallGigNowTest { get; set; }

        /// <summary>
        /// 大闸一次循环时间
        /// </summary>
        [IniKeyName("大闸一次循环时间")]
        public int BigCycleTime { get; set; }

        /// <summary>
        /// 大闸一次循环时间
        /// </summary>
        [IniKeyName("小闸一次循环时间")]
        public int SmallCycleTime { get; set; }
    }
}
