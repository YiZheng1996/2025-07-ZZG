using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Data;

namespace MainUI.Model
{

    [DebuggerDisplay("{ID},{Identity},{COMMData},{DataLabel}")]
    public class FullTags
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

        public string MVBPort { get; set; }
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
            MVBPort = row["MVBPort"].ToString();
            IsSensorRange = Convert.ToBoolean(row["IsSensorRange"]);
            PortPattern = Convert.ToBoolean(row["PortPattern"]);
            BitValue = Convert.ToDouble(row["BitValue"]);
            COMMData MVB = new()
            {
                Bit = row["MVBBit"] == DBNull.Value ? 0 : Convert.ToInt32(row["MVBBit"]),
                Offset = row["MVBOffset"] == DBNull.Value ? 0 : Convert.ToInt32(row["MVBOffset"]),
                Port = row["MVBPort"] == DBNull.Value ? 0 : Convert.ToInt32(row["MVBPort"].ToString(), 16)
            };
            this.COMMData = MVB;

        }

        public FullTags()
        {

        }

        public FullTags(DataRow row)
        {
            Init(row);
        }

        public override string ToString()
        {
            return string.Join(",", [this.ID.ToString(), this.Identity.ToString(), this.COMMData.ToString(), this.DataLabel.ToString()]);
        }
    }
}
