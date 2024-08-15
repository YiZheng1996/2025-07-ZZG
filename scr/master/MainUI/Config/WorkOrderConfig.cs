using RW.Configuration;
using System.Windows.Forms;

namespace MainUI.Config
{
    public class WorkOrderConfig : IniConfig
    {
        public WorkOrderConfig()
          : base(Application.StartupPath + "\\config\\WorkOrder.ini")
        {
        }

        /// <summary>
        /// 接口IP地址
        /// </summary>
        [IniKeyName("IP地址")]
        public string IPaddress { get; set; }

        /// <summary>
        /// 接口端口号
        /// </summary>
        [IniKeyName("端口号")]
        public string Prot { get; set; }

        /// <summary>
        /// 身份认证
        /// </summary>
        [IniKeyName("身份认证")]
        public string Auth { get; set; }

        /// <summary>
        /// 日校验工单请求
        /// </summary>
        [IniKeyName("日校验工单请求")]
        public string ReqCheckOrder { get; set; }

        /// <summary>
        /// ReqCheckOrder
        /// </summary>
        [IniKeyName("ReqCheckOrder")]
        public string UpCheckOrderData { get; set; }

        /// <summary>
        /// 作业工单请求
        /// </summary>
        [IniKeyName("作业工单请求")]
        public string ReqOrder { get; set; }

        /// <summary>
        /// 作业工单上传
        /// </summary>
        [IniKeyName("作业工单上传")]
        public string UpOrderData { get; set; }

        /// <summary>
        /// 唯一认证编码
        /// </summary>
        [IniKeyName("唯一认证编码")]
        public string Devid { get; set; }

        /// <summary>
        /// 设备授权码
        /// </summary>
        [IniKeyName("设备授权码")]
        public string Authorization { get; set; }

        /// <summary>
        /// 作业报告版本
        /// </summary>
        [IniKeyName("作业报告版本")]
        public string JobVersions { get; set; }
    }
}
