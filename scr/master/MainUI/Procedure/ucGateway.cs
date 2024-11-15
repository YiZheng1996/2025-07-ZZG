namespace MainUI.Procedure
{
    public partial class ucGateway : ucBaseManagerUI
    {
        ZZCTRDPConfig gtw = null;
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
                gtw = new ZZCTRDPConfig();
                gtw.Load();
                txtTRDPIP.Text = gtw.DesIP1;
                txtTrdpPort.Text = gtw.Desport1;
                txtLocalIP.Text = gtw.LocalIP1;
                txtLocalPort.Text = gtw.LocalPort1;
                txtTRDPIP2.Text = gtw.DesIP2;
                txtTrdpPort2.Text = gtw.Desport2;
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
                gtw.DesIP1 = txtTRDPIP.Text;
                gtw.Desport1 = txtTrdpPort.Text;
                gtw.LocalIP1 = txtLocalIP.Text;
                gtw.LocalPort1 = txtLocalPort.Text;
                gtw.DesIP2 = txtTRDPIP2.Text;
                gtw.Desport2 = txtTrdpPort2.Text;
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
