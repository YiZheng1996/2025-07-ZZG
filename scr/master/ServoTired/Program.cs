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
            #region ����ģʽ
            string softname = Application.ProductName;
            var mutex = new Mutex(true, softname, out bool flag);
            //��һ������:true--�������̸߳��軥����ĳ�ʼ����Ȩ  
            //��һ������:�����������  
            //����������:����ֵ,��������߳��ѱ����軥����ĳ�ʼ����Ȩ,�򷵻�true  
            if (!flag)
            {
                MessageBox.Show("ֻ������һ������", "��ȷ��", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("OPC��ʼ��ʧ�ܣ�" + ex.Message, "ϵͳ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}