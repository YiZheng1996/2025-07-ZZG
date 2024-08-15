using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Model
{
    /// <summary>
    /// 端口的数据模型
    /// </summary>
    public class TRDPConfig : BaseModel
    {
        public TRDPConfig()
        {

        }

        public TRDPConfig(DataRow row)
        {
            Init(row);
        }

        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }

        public string TypeName { get; set; }
        /// <summary>
        /// 网关ip
        /// </summary>
        public string TRDPIP { get; set; }
        /// <summary>
        /// 网关端口
        /// </summary>
        public string TRDPPort { get; set; }
        /// <summary>
        /// 本地ip
        /// </summary>
        public string LocalIP { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        public string LocalPort { get; set; }

        /// <summary>
        /// 配置文件名称
        /// </summary>
        public string ConfigFileName { get; set; }
        /// <summary>
        /// 网关编号
        /// </summary>
        public string TRDPNo { get; set; }
    }

}
