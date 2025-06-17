using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Data;

namespace MainUI.Model
{

    [DebuggerDisplay("{ID},{Identity},{COMMData},{DataLabel}")]
    public class CANFullTags
    {
        public int ID { get; set; }
        public string DataLabel { get; set; }
        public string DataType { get; set; }
        public string DataRange { get; set; }
        public string DataUnit { get; set; }
        public string Description { get; set; }
        public double BitValue { get; set; }

        public COMMData COMMData { get; set; }
        public bool Identity { get; set; }

        public string CANID { get; set; }
        public bool PortPattern { get; set; }

        public bool IsSensorRange { get; set; }

        public double WriteRate { get; set; }

        public double ReadRate { get; set; }
        public void Init(DataRow row)
        {
            ID = Convert.ToInt32(row["ID"].ToString());
            DataLabel = row["DataLabel"].ToString();
            DataType = row["DataType"].ToString();
            DataRange = row["DataRange"].ToString();
            DataUnit = row["DataUnit"].ToString();
            Description = row["Description"].ToString();
            Identity = Convert.ToBoolean(row["Identity"]);
            CANID = row["CANID"].ToString();
            IsSensorRange = Convert.ToBoolean(row["IsSensorRange"]);
            PortPattern = Convert.ToBoolean(row["PortPattern"]);
            BitValue = Convert.ToDouble(row["BitValue"]);
            WriteRate = Convert.ToDouble(row["BitValue"]);
            COMMData MVB = new()
            {
                Bit = row["CANBit"] == DBNull.Value ? 0 : Convert.ToInt32(row["CANBit"]),
                Offset = row["CANOffset"] == DBNull.Value ? 0 : Convert.ToInt32(row["CANOffset"]),
                Port = row["CANID"] == DBNull.Value ? 0 : Convert.ToInt32(row["CANID"].ToString(), 16)
            };
            this.COMMData = MVB;

        }

        public CANFullTags()
        {

        }

        public CANFullTags(DataRow row)
        {
            Init(row);
        }

        public override string ToString()
        {
            return string.Join(",", [ID.ToString(), Identity.ToString(), COMMData.ToString(), DataLabel.ToString()]);
        }
    }
}
