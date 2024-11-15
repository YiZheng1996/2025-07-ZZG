using System.Data;

namespace MainUI.Model
{

    [DebuggerDisplay("{ID},{Identity},{COMMData},{DataLabel}")]
    public class FullTagsETH
    {
        public int ID { get; set; }
        public string DataLabel { get; set; }
        public string DataType { get; set; }
        public bool PortPattern { get; set; }
        public string DataUnit { get; set; }
        public string Description { get; set; }

        public COMMData COMMData { get; set; }
        public bool Identity { get; set; }

        public string Port { get; set; }
        public int TRDPNo { get; set; }
        public int ETHPassage { get; set; }
        public string VerNo { get; set; }
        public bool IsSensorRange { get; set; }
        public bool IsRead { get; set; }
        public double BitValue { get; set; }
        public void Init(DataRow row)
        {
            ID = Convert.ToInt32(row["ID"].ToString());
            DataLabel = row["DataLabel"].ToString();
            DataType = row["DataType"].ToString();
            PortPattern = Convert.ToBoolean(row["PortPattern"]);
            DataUnit = row["DataUnit"].ToString();
            Description = row["Description"].ToString();
            Identity = Convert.ToBoolean(row["Identity"]);
            Port = row["Port"].ToString();
            //TRDPNo = Convert.ToInt32(row["TRDPNo"].ToString());
            IsSensorRange = Convert.ToBoolean(row["IsSensorRange"]);
            VerNo = row["VerNo"].ToString();
            IsRead = Convert.ToBoolean(row["IsRead"]);
            BitValue = Convert.ToDouble(row["BitValue"]);
            COMMData ETH = new()
            {
                GroupETHBit = string.IsNullOrEmpty(value: row["GroupETHBit"].ToString()) ? "0" : row["GroupETHBit"].ToString(),
                Bit = row["ETHBit"] == DBNull.Value ? 0 : Convert.ToInt32(row["ETHBit"]),
                Offset = row["Offset"] == DBNull.Value ? 0 : Convert.ToInt32(row["Offset"]),
                Port = row["Port"] == DBNull.Value ? 0 : Convert.ToInt32(row["Port"].ToString())
            };
            COMMData = ETH;
        }

        public FullTagsETH()
        {

        }

        public FullTagsETH(DataRow row)
        {
            Init(row);
        }

        public override string ToString()
        {
            return string.Join(",", [this.ID.ToString(), this.Identity.ToString(), this.COMMData.ToString(), this.DataLabel.ToString()]);
        }
    }
}
