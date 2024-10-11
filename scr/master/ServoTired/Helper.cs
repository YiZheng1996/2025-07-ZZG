using RW.Driver;
using Sunny.UI;
using System.Net.NetworkInformation;

namespace ServoTired
{
    internal class Helper
    {
        public static IFreeSql? fsql;
        public static OPCDriver opcServo = new();
        public static OPCDriver opcDI = new();
        public static ServoGrp servoGrp;
        public static DIGrp opcDIGroup;


        #pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        static Helper()
        #pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        {
            string kepServerName = "KEPware.KEPServerEx.V6";
            opcServo.ServerName = kepServerName;
            opcServo.Prefix = "SMART.PLC.";
            opcDI.ServerName = kepServerName;
            opcDI.Prefix = "SMART.PLC.";
        }

        public static void Init()
        {
            servoGrp = new();
            servoGrp.Init();
            opcDIGroup = new();
            opcDIGroup.Init();
        }

        /// <summary>
        /// OPC打开
        /// </summary>
        public static void Connect()
        {
            opcServo.Connect();
            opcDI.Connect();
        }

        /// <summary>
        /// OPC关闭
        /// </summary>
        public static void Close()
        {
            opcServo.Close();
            opcDI.Close();
        }


        public static void BindComboBox<T>(UIComboBox comboBox, string displayMember, string valueMember, IEnumerable<T>? dataSource)
        {
            comboBox.DataSource = new BindingSource(dataSource, null);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
    }
}
