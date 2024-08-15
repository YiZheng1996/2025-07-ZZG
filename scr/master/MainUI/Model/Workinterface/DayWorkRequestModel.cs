using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Workinterface
{
    /// <summary>
    /// 日校验工单请求模型
    /// </summary>
    public class DayWorkRequestPostModel
    {
        /// <summary>
        /// 作业人员工号，系统登录以工号为准
        /// </summary>
        public string sworkno { get; set; }

        /// <summary>
        /// 申请日期，格式为：yyyy-MM-dd
        /// </summary>
        public string sdate { get; set; }

        /// <summary>
        /// 设备唯一编码，见设备编码表
        /// </summary>
        public string sdevid { get; set; }
    }


    /// <summary>
    /// 日校验工单请求接收数据模型
    /// </summary>
    public class DayWorkRequestGetModel
    {
        /// <summary>
        /// 响应状态，系统按照作业人员工号判断是否具备作业资质，具备作业资质，响应状态为：成功，否则为：失败。
        /// </summary>
        public string sresponsestate { get; set; }

        /// <summary>
        /// 校验工单号，响应状态为成功时，下发校验工单号
        /// </summary>
        public string scheckticketno { get; set; }

        /// <summary>
        /// 请求结果说明，当响应状态为失败时，系统发送的原因说明。
        /// </summary>
        public string snote { get; set; }
    }

}
