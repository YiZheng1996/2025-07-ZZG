using System;
using Newtonsoft.Json;

namespace MainUI.Model.Workinterface
{
    [Serializable]
    public class JobTokenModel
    {
        /// <summary>
        /// 空簧试验台
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// Token
        /// </summary>

        public string accessToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string refreshToken { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int expiresIn { get; set; }

    }

    public class JobTokenModels
    {
        public JobTokenModel data { get; set; }
    }
}
