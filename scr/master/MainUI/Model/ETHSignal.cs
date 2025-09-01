using System.ComponentModel;
using System.Data;

namespace MainUI.Model
{
    public class ETHSignal : BaseModel
    {
        public ETHSignal() { }
        public ETHSignal(DataRow row)
        {
            Init(row);
        }
        public int ID { get; set; }
        public string DataLabel { get; set; }
        public string DataType { get; set; }
        public string Port { get; set; }
        public int Offset { get; set; }
        public string ETHBit { get; set; }
        public string GroupETHBit { get; set; }
        public bool Identity { get; set; }
        public string Description { get; set; }
        public bool PortPattern { get; set; }
        public string DataUnit { get; set; }
        public double BitValue { get; set; }
        public string TypeName { get; set; }

        public int TRDPNo { get; set; }

        public string VerNo { get; set; }

        public bool IsRead { get; set; }

        [DefaultValue(true)]
        public bool DefaultVersion { get; set; }
        public int ETHPassage { get; set; }

        public bool IsCRC { get; set; } // 是否CRC校验
    }
}
