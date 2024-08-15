using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Workinterface
{
    /// <summary>
    /// 日校验工单数据上传Post模型
    /// </summary>
    public class DayWorkUploadPostModel
    {
        /// <summary>
        /// 校验工单编号，请求作业时系统下发的工单编号
        /// </summary>
        public string scheckticketno { get; set; }

        /// <summary>
        /// 作业人员工号，系统登录以工号为准
        /// </summary>
        public string sworkno { get; set; }

        /// <summary>
        /// 设备唯一编码，见设备编码表
        /// </summary>
        public string sdevid { get; set; }

        /// <summary>
        /// 校验时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string sdatetime { get; set; }

        /// <summary>
        /// 校验版本报告，V1.0，后续有变化，设备主动上传
        /// </summary>
        public string sver { get; set; }

        /// <summary>
        /// 校验报告PDF，校验报告PDF
        /// </summary>
        public string spdf { get; set; }

        /// <summary>
        /// 校验数据JOSN，设备需提供上传JSON各个字段的中文含义说明文档。
        /// </summary>
        public string sjson { get; set; }

        /// <summary>
        /// 校验结果，合格，不合格。日校验工单总结果，作为开工作业的判断依据。
        /// </summary>
        public bool sresult { get; set; }
    }



    /// <summary>
    /// 日校验工单数据上传Get模型
    /// </summary>
    public class DayWorkUploadGetModel
    {
        /// <summary>
        /// 响应状态，系统接收设备上传数据进行解析判断为有效数据后，响应状态为：成功，否则为：失败。
        /// </summary>
        public string sresponsestate { get; set; }

        /// <summary>
        /// 校验工单编号
        /// </summary>
        public string scheckticketno { get; set; }

        /// <summary>
        /// 请求结果说明，当响应状态为失败时，系统发送的原因说明。
        /// </summary>
        public string snote { get; set; }

    }
}
