using MainUI.Procedure.Curve.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Procedure.Curve.DataModel
{

    public class Datas_Model
    {
        public List<DataLine_Model> DataModels { get; set; }
    }

    public class DataLine_Model
    {
        /// <summary>
        /// 时间
        /// </summary>
        public Time_Model Time_Model { get; set; }

        /// <summary>
        /// 试验台传感器
        /// </summary>
        public Test_Model Test_Model { get; set; }



        //public MVV_Model MVB_Model { get; set; }
    }
}
