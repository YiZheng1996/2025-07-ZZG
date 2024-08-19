namespace ServoTired
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmWeary frmWeary = new();
            #region 单例模式
            string softname = Application.ProductName;
            var mutex = new Mutex(true, softname, out bool flag);
            //第一个参数:true--给调用线程赋予互斥体的初始所属权  
            //第一个参数:互斥体的名称  
            //第三个参数:返回值,如果调用线程已被授予互斥体的初始所属权,则返回true  
            if (!flag)
            {
                MessageBox.Show("只能运行一个程序！", "请确定", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
            #endregion


            try
            {
                OPCHelper.Connect();
                Application.Run(frmWeary);
            }
            catch (Exception ex)
            {
                MessageBox.Show("OPC初始化失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}