using System.Configuration;

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
                //�½�ʵ������
                Helper.fsql = new FreeSql.FreeSqlBuilder()
                    .UseConnectionString(FreeSql.DataType.Sqlite, ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString)
                    .Build();
                if (!Helper.fsql.Ado.ExecuteConnectTest()) throw new Exception("Sqlite���ݿ�����ʧ��");
                Helper.Connect();
                Application.Run(frmWeary);
            }
            catch (Exception ex)
            {
                MessageBox.Show("OPC��ʼ��ʧ�ܣ�" + ex.Message, "ϵͳ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}