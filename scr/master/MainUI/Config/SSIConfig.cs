using RW.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Config
{
    public class SSIConfig : IniConfig
    {
        public SSIConfig(): base(Application.StartupPath + "config\\SSIConfig.ini")
        {
            Load();
        }

        /// <summary>
        /// 端口号
        /// </summary>
        [IniKeyName("端口号")]
        public string COMPort { get; set; }

        /// <summary>
        /// 波特率
        /// </summary>
        [IniKeyName("波特率")]
        public int BaudRate { get; set; }

        /// <summary>
        /// 数据位 5、6、7、8
        /// </summary>
        [IniKeyName("数据位")]
        public int DataBits { get; set; }

        /// <summary>
        /// 停止位 1、2
        /// </summary>
        [IniKeyName("停止位")]
        public int StopBits { get; set; }

        /// <summary>
        /// 奇、偶校验位 
        /// </summary>
        [IniKeyName("校验位")]
        public int CheckBit => 0;

        /// <summary>
        /// DTR
        /// </summary>
        [IniKeyName("DTR")]
        public bool Dtr { get; set; }

        /// <summary>
        ///  获取或设置写入操作未完成时发生超时之前的毫秒数。
        /// </summary>
        [IniKeyName("读超时(毫秒)")]
        public int ReadTimeout => 5000;
    }
}
