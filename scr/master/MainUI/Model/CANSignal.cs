using System.Data;

namespace MainUI.Model
{
    public class CANSignal : BaseModel
    {
        //private string dataRange;

        public CANSignal() { }
        public CANSignal(DataRow row)
        {
            Init(row);
        }
        public int ID { get; set; }
        public string DataLabel { get; set; }
        public string DataType { get; set; }
        public string DataUnit { get; set; }
        public string CANID { get; set; }
        public int CANOffset { get; set; }
        public bool Identity { get; set; }
        public int CANBit { get; set; }
        public string Description { get; set; }
        //public string DataRange { get; set; }
        public int ModelNameID { get; set; }
        public bool IsRead { get; set; }
        public bool PortPattern { get; set; }
        public double BitValue { get; set; }
    }
}
