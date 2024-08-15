using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RW.Configuration;
using System.Windows.Forms;
using System.ComponentModel;
using MainUI.Procedure.Curve;

namespace MainUI.Config
{
    public class ValueNameConfig : IniConfig
    {
        public ValueNameConfig()
          : base(Application.StartupPath + "\\config\\ValueNameConfig.ini")
        {
            Load();
        }
        public ValueNameConfig(string sectionName)
            : base(string.Format(Application.StartupPath + "config\\{0}.ini", sectionName))
        {
            SetSectionName(sectionName);
            Load();
        }

        /// <summary>
        /// 选择配置参数 数组
        /// </summary>
        [IniKeyName("选择配置参数 数组")]
        public ValueName[] ValueName { get; set; }

    }

    /// <summary>
    /// 保存名称
    /// </summary>
    public class ValueNameOperation
    {
        static ValueNameConfig nvc = new();
        static ValueNameConfig nvc2 = new("HistoryValueNameConfig");
        public static void DataSave(ValueName[] v, bool isSave = true)
        {
            if (isSave)
            {
                nvc.ValueName = v;
                nvc.Save();
            }
            else
            {
                nvc2.ValueName = v;
                nvc2.Save();
            }

        }
        public static ValueName[] DataLoading(bool isSave = true)
        {
            if (isSave)
            {
                nvc = new ValueNameConfig();
                return nvc.ValueName;
            }
            else
            {
                nvc2 = new ValueNameConfig("HistoryValueNameConfig");
                return nvc2.ValueName;
            }
        }
    }


}
