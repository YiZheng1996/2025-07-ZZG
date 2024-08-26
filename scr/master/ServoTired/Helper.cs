using RW.Driver;
using Sunny.UI;
using System.Net.NetworkInformation;

namespace ServoTired
{
    internal class Helper
    {
        public static IFreeSql? fsql;
        public static OPCDriver opcServo = new();
        public static ServoGrp? servoGrp;

        static Helper()
        {
            string kepServerName = "KEPware.KEPServerEx.V6";
            opcServo.ServerName = kepServerName;
            opcServo.Prefix = "SMART.PLC.";
        }

        public static void Init()
        {
            servoGrp = new();
            servoGrp.Init();
        }

        /// <summary>
        /// OPC打开
        /// </summary>
        public static void Connect()
        {
            opcServo.Connect();
        }

        /// <summary>
        /// OPC关闭
        /// </summary>
        public static void Close()
        {
            opcServo.Close();
        }


        public static void BindComboBox<T>(UIComboBox comboBox, string displayMember, string valueMember, IEnumerable<T>? dataSource)
        {
            comboBox.DataSource = new BindingSource(dataSource, null);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
    }
}
