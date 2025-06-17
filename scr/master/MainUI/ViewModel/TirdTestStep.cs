using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.ViewModel
{
    public class TirdTestStep
    {
        public int ID { get; set; }


        public string Model { get; set; }
        //public string Repairing { get; set; }
        //public string TestType { get; set; }
        public int Sort { get; set; }
        public int Step { get; set; }
        public string ProcessName { get; set; }
        public string ProcessKey { get; set; }
        public int LineNumber { get; set; }
        public string DSLName { get; set; }
        public string ReportRow { get; set; }

        public int ModelID { get; set; }

        /// <summary>
        /// 是否可见，1：可见；0 不可见。默认为1.
        /// </summary>
        public string IsVisible { get; set; }


        public override string ToString()
        {
            string str = "";
            str += "Model:" + Model.ToString() + "；";
            str += "Step:" + Step.ToString() + "；";
            str += "ProcessName:" + ProcessName.ToString() + "；";
            str += "ProcessKey:" + ProcessKey.ToString() + "；";
            str += "LineNumber:" + LineNumber.ToString() + "；";
            str += "ID:" + ID.ToString() + "；";
            str += "IsVisible:" + IsVisible.ToString() + "；";
            str += "DSLName:" + DSLName.ToString() + "；";
            str += "ReportRow:" + ReportRow.ToString() + "；";
            str += "ModelID:" + ModelID.ToString() + "；";
            return str;
        }
    }
}
