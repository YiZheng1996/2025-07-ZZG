using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MainUI.Model
{
    public class Signal : BaseModel
    {
        //private string dataRange;

        public Signal() { }
        public Signal(DataRow row)
        {
            Init(row);
        }
        public int ID { get; set; }
        public string DataLabel { get; set; }
        public string DataType { get; set; }
        public string DataUnit { get; set; }
        public string MVBPort { get; set; }
        public int  MVBOffset { get; set; }
        public bool Identity { get; set; }
        public int MVBBit { get; set; }
        public string Description { get; set; }
        //public string DataRange { get; set; }
        public int ModelNameID { get; set; }
        public bool IsRead { get; set; }
        public bool PortPattern { get; set; }
        public double BitValue { get; set; }
    }
}
