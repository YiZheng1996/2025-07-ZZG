using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace MainUI.Model
{
    /// <summary>
    /// 端口的数据模型
    /// </summary>
    public class Ports : BaseModel
    {
        public Ports()
        {

        }

        public Ports(DataRow row)
        {
            Init(row);
        }
        /// <summary>
        /// 显示ID
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// 型号显示名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 端口显示名称
        /// </summary>
        public string PortName { get; set; }
        /// <summary>
        /// 扫描周期（ms）
        /// </summary>
        public int Rate { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        public string Port { get; set; }

        public int PortNum { get { return Convert.ToInt32(Port, 16); } }
        public int ETHPortNum { get { return Convert.ToInt32(Port); } }
        /// <summary>
        /// 是否是读命令
        /// </summary>
        public bool IsRead { get; set; }

        /// <summary>
        /// 数据长度，一般MVB限值最大为32字节，网卡不限
        /// </summary>
        public int DataSize { get; set; }

        /// <summary>
        /// SMI值，每一种设备对应一个SMI值，用于CRC校验
        /// </summary>
        public uint SMIValue { get; set; }

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

        public int TRDPNo { get; set; }

        /// <summary>
        /// 型号名称
        /// </summary>
        public int ModelNameID { get; set; }
    }

    /// <summary>
    /// 基础模块类型
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// 将DataRow的名称，反射到实体
        /// </summary>
        /// <param name="row"></param>
        public virtual void Init(DataRow row)
        {
            PropertyInfo[] members = this.GetType().GetProperties();
            foreach (var item in members)
            {
                if (row.Table.Columns.Contains(item.Name))
                {
                    object value = Convert.ChangeType(row[item.Name], item.PropertyType);
                    item.SetValue(this, value, null);
                }
            }
        }
    }
}
