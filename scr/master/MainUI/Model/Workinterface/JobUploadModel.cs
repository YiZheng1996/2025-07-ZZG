using MainUI.Model.Workinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Workinterface
{
    /// <summary>
    /// 作业工单上传POST
    /// </summary>
    public class JobUploadPsotModel
    {
        /// <summary>
        /// 部件编号，请求作业时系统下发的部件编号
        /// </summary>
        public string sticketno { get; set; }

        /// <summary>
        /// 作业任务，请求作业时系统下发的作业任务名
        /// </summary>
        public string sjobname { get; set; }

        /// <summary>
        /// 修程，架修，大修
        /// </summary>
        public string srepairver { get; set; }

        /// <summary>
        /// 设备唯一编码
        /// </summary>
        public string sdevid { get; set; }

        /// <summary>
        /// 作业报告版本，V1.0，后续有变化，设备主动上传
        /// </summary>
        public string sver { get; set; }

        /// <summary>
        /// 检修部件名称，请求作业时系统下发的检修部件名称
        /// </summary>
        public string spartname { get; set; }

        /// <summary>
        /// 部件编号，请求作业时系统下发的部件编号
        /// </summary>
        public string spartid { get; set; }

        /// <summary>
        /// 作业人员
        /// </summary>
        public string sworkno { get; set; }

        /// <summary>
        /// 作业报告PDF，按照合同要求，设备应生成统一格式的PDF报告。
        /// </summary>
        public string spdf { get; set; }

        /// <summary>
        /// 作业数据JSON,设备需提供上传JSON各个字段的中文含义说明文档。
        /// </summary>
        public List<ReportDataModel> sjson { get; set; }

        /// <summary>
        /// 作业开始时间
        /// </summary>
        public string startdatetime { get; set; }

        /// <summary>
        /// 作业完成时间
        /// </summary>
        public string enddatetime { get; set; }
    }


    /// <summary>
    /// 日校验工单请求接收数据Get模型
    /// </summary>
    public class JobUploadGetModel
    {
        /// <summary>
        /// 响应状态，系统按照作业人员工号判断是否具备作业资质，具备作业资质，响应状态为：成功，否则为：失败。
        /// </summary>
        public string sresponsestate { get; set; }

        /// <summary>
        /// 工单编号
        /// </summary>
        public string sticketno { get; set; }

        /// <summary>
        /// 请求结果说明，当响应状态为失败时，系统发送的原因说明。
        /// </summary>
        public string snote { get; set; }
    }

    public class JobUploadGetModels
    {
        public JobUploadGetModel data { get; set; }
    }
}
