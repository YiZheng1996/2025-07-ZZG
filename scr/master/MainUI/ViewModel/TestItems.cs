using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.ViewModel
{
    /// <summary>
    /// 试验时选择的试验项点信息。
    /// </summary>
    public class TestItems
    {
        public string Model { get; set; }

        public string ProcessKey { get; set; }

        public string ProcessName { get; set; }

        public bool IsSelected { get; set; }

        public string DSLName { get; set; }

        public string ReportRow { get; set; }


        /// <summary>
        /// listView中的行索引。
        /// </summary>
        public int RowIndex { get; set; }

        public override string ToString()
        {
            string str = "";
            str += "Model：" + Model + "；";
            str += "ProcessKey：" + ProcessKey + "；";
            str += "ProcessName：" + ProcessName + "；";
            str += "IsSelected：" + IsSelected.ToString() + "；";
            str += "RowIndex：" + RowIndex.ToString() + "；";
            str += "DSLName：" + DSLName.ToString() + "；";
            str += "ReportRow：" + ReportRow.ToString() + "；";
            return str;
        }
    }
}
