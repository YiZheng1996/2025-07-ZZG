using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Model.Workinterface
{
    public static class DicFormDatas
    {
        /// <summary>
        /// 作业工单请求Post
        /// </summary>
        public static Dictionary<string, string> dicJobRequest = new Dictionary<string, string>();

        /// <summary>
        /// 作业工单上传POST
        /// </summary>
        public static Dictionary<string, string> dicJobUpload = new Dictionary<string, string>();

        /// <summary>
        /// 日校验工单请求模型POST
        /// </summary>
        public static Dictionary<string, string> dicDayWorkRequest = new Dictionary<string, string>();
        /// <summary>
        /// 保存日校验工单请求反馈的数据
        /// </summary>
        public static Dictionary<string, string> dicDayWorkRequestLoad = new Dictionary<string, string>();

        /// <summary>
        /// 日校验工单数据上传Post模型
        /// </summary>
        public static Dictionary<string, string> dicDayWorkUpload = new Dictionary<string, string>();

        /// <summary>
        /// 获取Token
        /// </summary>
        public static Dictionary<string, string> dicLoadToken = new Dictionary<string, string>();
    }
}
