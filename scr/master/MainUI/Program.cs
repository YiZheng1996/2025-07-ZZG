using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RW.UI;
using RW.UI.Manager.User;
using System.IO;
using System.Runtime.Versioning;

namespace MainUI
{
    [SupportedOSPlatform("windows")]
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new();
            #region 单例模式
            string softname = Application.ProductName;
            bool flag = false;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, softname, out flag);
            //第一个参数:true--给调用线程赋予互斥体的初始所属权  
            //第一个参数:互斥体的名称  
            //第三个参数:返回值,如果调用线程已被授予互斥体的初始所属权,则返回true  
            if (!flag)
            {
                MessageBox.Show("只能运行一个程序！", "请确定", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
            #endregion

            DialogResult dr = login.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    VarHelper.Connect();
                    frmMainMenu main = new();
                    Application.Run(main);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("OPC初始化失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
