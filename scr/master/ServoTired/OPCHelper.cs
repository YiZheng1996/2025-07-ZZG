using RW.Driver;
using System.Net.NetworkInformation;

namespace ServoTired
{
    internal class OPCHelper
    {
        public static OPCDriver opcServo = new();
        public static ServoGrp servoGrp;

        static OPCHelper()
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
    }
}
