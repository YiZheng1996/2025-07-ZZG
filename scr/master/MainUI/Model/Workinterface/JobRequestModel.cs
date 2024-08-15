using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Workinterface
{
    /// <summary>
    /// 作业工单请求Post
    /// </summary>
    public class JobRequestPostModel
    {
        /// <summary>
        /// 作业人员工号，系统登录以工号为准
        /// </summary>
        public string sworkno { get; set; }

        /// <summary>
        /// 设备唯一编码，见设备编码表
        /// </summary>
        public string sdevid { get; set; }
    }


    /// <summary>
    /// 作业工单请求
    /// </summary>
    public class JobRequestGetModel
    {
        /// <summary>
        /// 响应状态，系统按照作业人员工号判断是否具备作业资质，具备作业资质，响应状态为：成功，否则为：失败。
        /// </summary>
        public string sresponsestate { get; set; }

        /// <summary>
        /// 作业工单号，响应状态为成功时，下发作业工单号
        /// </summary>
        public string sticketno { get; set; }

        /// <summary>
        /// 作业部件编号，系统发送即将上料的部件编号
        /// </summary>
        public string spartid { get; set; }

        /// <summary>
        /// 检修部件名称，系统发送即将上料的部件名称
        /// </summary>
        public string spartname { get; set; }

        /// <summary>
        /// 请求结果说明，当响应状态为失败时，系统发送的原因说明。
        /// </summary>
        public string snote { get; set; }

        /// <summary>
        /// 作业任务名称
        /// </summary>
        public string sjobname { get; set; }
    }

    public class JobRequestGetModels
    {
        public JobRequestGetModel data { get; set; }
    }



}
