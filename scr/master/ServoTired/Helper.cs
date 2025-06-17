using RW;
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

        // 数据绑定
        public static void BindComboBox<T>(UIComboBox comboBox, string displayMember, string valueMember, IEnumerable<T>? dataSource)
        {
            comboBox.DataSource = new BindingSource(dataSource, null);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        public static string ServoErr(string? errValue)
        {
            string TimeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            switch (errValue)
            {
                case "33793":
                    return ($"{TimeNow}：伺服故障，故障代码为[{errValue}，驱动错误]。\n");
                case "33794":
                    return ($"{TimeNow}:伺服故障，故障代码为[{errValue}，驱动禁止启动]。\n");
                case "33795":
                    return ($"{TimeNow}:伺服故障，故障代码为[{errValue}，运行中回零不能开始]。\n");
                case "34304":
                    return ($"{TimeNow}:伺服故障，故障代码为[{errValue}，DPRD_DAT错误]。\n");
                case "34305":
                    return ($"{TimeNow}:伺服故障，故障代码为：{errValue}， DPWR_DAT 错误]。\n");
                case "33282":
                    return ($"{TimeNow}:伺服故障，故障代码为[{errValue}，不正确的运行模式选择]。\n");
                case "33283":
                    return ($"{TimeNow}:伺服故障，故障代码为[{errValue}，不正确的设定值参数]。\n");
                case "33284":
                    return ($"{TimeNow}:伺服故障，故障代码为[{errValue}，选择了不正确的程序段号]。\n");
                default:
                    break;
            }
            return ($"{TimeNow}:伺服故障，故障代码为[{errValue}]。\n");
        }

    }
}
