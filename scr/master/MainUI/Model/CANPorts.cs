using System.Data;

namespace MainUI.Model
{
    /// <summary>
    /// 端口的数据模型
    /// </summary>
    public class CANPorts : BaseModel
    {
        public CANPorts()
        {

        }

        public CANPorts(DataRow row)
        {
            Init(row);
        }

        /// <summary>
        /// 显示ID
        /// </summary>
        public long ID { get; set; }
      
        /// <summary>
        /// 端口显示名称
        /// </summary>
        public string PortName { get; set; }
        /// <summary>
        /// 扫描周期（ms）
        /// </summary>
        public int Rate { get; set; }
        /// <summary>
        /// CANID
        /// </summary>
        public string CANID { get; set; }

        /// <summary>
        /// 波特率
        /// </summary>
        public string BaudRate { get; set; }

        public int PortNum { get { return Convert.ToInt32(CANID, 16); } }
        public int ETHPortNum { get { return Convert.ToInt32(CANID); } }
        /// <summary>
        /// 是否是读命令
        /// </summary>
        public bool IsRead { get; set; }

        /// <summary>
        /// 端口模式，大端口：高字节在前，小端口：低字节在前
        /// </summary>
        public bool PortPattern { get; set; }
        /// <summary>
        /// 软件版本
        /// </summary>
        public string VerNo { get; set; }
        /// <summary>
        /// 默认版本
        /// </summary>
        public bool DefaultVersion { get; set; }
        /// <summary>
        /// ETH通道
        /// </summary>
        public int ETHPassage { get; set; }

        /// <summary>
        /// 型号名称
        /// </summary>
        public int ModelNameID { get; set; }
    }


}
