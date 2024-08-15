using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RW.UI.Manager;
using MainUI.Model;
using MainUI.BLL;
using MainUI.Config;
using MainUI.Properties;
using NPOI.SS.Formula.Functions;

namespace MainUI.Procedure
{
    public partial class ucGateway : ucBaseManagerUI
    {
        GatewayConfig gtw = null;
        public ucGateway()
        {
            InitializeComponent();
        }
        private void ucTestParams_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }
        /// <summary>
        /// 数据初始化
        /// </summary>
        private void LoadConfig()
        {
            try
            {
                gtw = new GatewayConfig();
                gtw.Load();
                txtTRDPIP.Text = gtw.TRDPIP1;
                txtTrdpPort.Text = gtw.TRDPPort1;
                txtLocalIP.Text = gtw.LocalIP1;
                txtLocalPort.Text = gtw.LocalPort1;
                txtTRDPIP2.Text = gtw.TRDPIP2;
                txtTrdpPort2.Text = gtw.TRDPPort2;
                txtLocalIP2.Text = gtw.LocalIP2;
                txtLocalPort2.Text = gtw.LocalPort2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                gtw.TRDPIP1 = txtTRDPIP.Text;
                gtw.TRDPPort1 = txtTrdpPort.Text;
                gtw.LocalIP1 = txtLocalIP.Text;
                gtw.LocalPort1 = txtLocalPort.Text;
                gtw.TRDPIP2 = txtTRDPIP2.Text;
                gtw.TRDPPort2 = txtTrdpPort2.Text;
                gtw.LocalIP2 = txtLocalIP2.Text;
                gtw.LocalPort2 = txtLocalPort2.Text;
                gtw.Save();
                MessageBox.Show("保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败。" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Application.StartupPath + "\\reports\\";
            openFile.Filter = "Excel2003|*.xls|Excel2007+|*.xlsx";
            openFile.ShowDialog();
            if (string.IsNullOrEmpty(openFile.FileName) == false)
            {
                string path = openFile.FileName;
                string[] str = path.Split('\\');
                //txtRpt.Text = str[str.Length - 1];
            }
        }



    }
}
