using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Model
{
    public class ResultAll
    {

        #region 气密性试验
        /// <summary>
        /// 泄漏前压力
        /// </summary>
        public string value1 { get; set; }
        /// <summary>
        /// 泄漏后压力
        /// </summary>
        public string value2{ get; set; }
        /// <summary>
        /// 泄漏量
        /// </summary>
        public string xll { get; set; }


        #endregion


        #region 启停机试验
        /// <summary>
        /// 启动→停止
        /// </summary>
        public string[] tq { get; set; } = new string[6];
        /// <summary>
        /// 停机压力卸载至300kPa耗用时
        /// </summary>
        public string[] tqx { get; set; } = new string[6];
        /// <summary>
        /// 油温
        /// </summary>
        public string[] tqy { get; set; } = new string[6];
        #endregion


    }
}
