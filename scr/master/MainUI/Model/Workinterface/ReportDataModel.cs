using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Model.Workinterface
{

    public class ReportDataList
    {
        /// <summary>
        /// 报表数据集合
        /// </summary>
        public List<ReportDataModel> data { get; set; }
    }


    /// <summary>
    /// 报表数据
    /// </summary>
    public class ReportDataModel
    {
        /// <summary>
        /// 试验气压(kPa)
        /// </summary>
        public double testKpa { get; set; }
        /// <summary>
        /// 稳压时长(s)	
        /// </summary>
        public int steadyTime { get; set; }
        /// <summary>
        /// 保压时长(s)	
        /// </summary>
        public double ProtectionkpaTime { get; set; }
        /// <summary>
        /// 保压前气压(kPa)
        /// </summary>
        public double frontKpa { get; set; }
        /// <summary>
        /// 保压后气压(kPa)
        /// </summary>
        public double behindKpa { get; set; }

        /// <summary>
        /// 判定标准(kPa)			
        /// </summary>
        public double standardkPa { get; set; }
        /// <summary>
        /// 泄漏值(kPa)		
        /// </summary>
        public double leakKpa { get; set; }

    }
}