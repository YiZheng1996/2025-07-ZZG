namespace MainUI
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblSoftName = new Label();
            lblMessage = new Label();
            uiLabel3 = new UILabel();
            uiLabel1 = new UILabel();
            btnSignIn = new UIButton();
            btnExit = new UIButton();
            cboUsername = new UIComboBox();
            txtPassword = new UITextBox();
            Logo = new PictureBox();
            uiLabel2 = new UILabel();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // lblSoftName
            // 
            resources.ApplyResources(lblSoftName, "lblSoftName");
            lblSoftName.Name = "lblSoftName";
            // 
            // lblMessage
            // 
            resources.ApplyResources(lblMessage, "lblMessage");
            lblMessage.ForeColor = Color.Red;
            lblMessage.Name = "lblMessage";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel3, "uiLabel3");
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Name = "uiLabel3";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel1, "uiLabel1");
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Name = "uiLabel1";
            // 
            // btnSignIn
            // 
            resources.ApplyResources(btnSignIn, "btnSignIn");
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.Name = "btnSignIn";
            btnSignIn.TipsFont = new Font("微软雅黑", 9F);
            btnSignIn.Click += BtnSignIn_Click;
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Cursor = Cursors.Hand;
            btnExit.DialogResult = DialogResult.Cancel;
            btnExit.Name = "btnExit";
            btnExit.TipsFont = new Font("微软雅黑", 9F);
            btnExit.Click += btnExit_Click;
            // 
            // cboUsername
            // 
            cboUsername.DataSource = null;
            cboUsername.FillColor = Color.White;
            cboUsername.FilterMaxCount = 50;
            resources.ApplyResources(cboUsername, "cboUsername");
            cboUsername.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboUsername.Items.AddRange(new object[] { resources.GetString("cboUsername.Items"), resources.GetString("cboUsername.Items1"), resources.GetString("cboUsername.Items2"), resources.GetString("cboUsername.Items3"), resources.GetString("cboUsername.Items4"), resources.GetString("cboUsername.Items5"), resources.GetString("cboUsername.Items6"), resources.GetString("cboUsername.Items7"), resources.GetString("cboUsername.Items8"), resources.GetString("cboUsername.Items9"), resources.GetString("cboUsername.Items10"), resources.GetString("cboUsername.Items11") });
            cboUsername.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboUsername.Name = "cboUsername";
            cboUsername.RadiusSides = UICornerRadiusSides.None;
            cboUsername.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            cboUsername.SymbolSize = 24;
            cboUsername.TextAlignment = ContentAlignment.MiddleLeft;
            cboUsername.Watermark = "请选择";
            // 
            // txtPassword
            // 
            txtPassword.ButtonWidth = 100;
            txtPassword.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ShowText = false;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "请输入";
            // 
            // Logo
            // 
            resources.ApplyResources(Logo, "Logo");
            Logo.Name = "Logo";
            Logo.TabStop = false;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel2, "uiLabel2");
            uiLabel2.ForeColor = Color.Gray;
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Style = UIStyle.Custom;
            // 
            // frmLogin
            // 
            AcceptButton = btnSignIn;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 249, 255);
            CancelButton = btnExit;
            Controls.Add(uiLabel2);
            Controls.Add(Logo);
            Controls.Add(lblMessage);
            Controls.Add(lblSoftName);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel1);
            Controls.Add(btnSignIn);
            Controls.Add(btnExit);
            Controls.Add(cboUsername);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Load += frmLogin_Load;
            MouseDown += frmLogin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblSoftName;
        private System.Windows.Forms.Label lblMessage;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnSignIn;
        private Sunny.UI.UIButton btnExit;
        private Sunny.UI.UIComboBox cboUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UILabel uiLabel2;
        public System.Windows.Forms.PictureBox Logo;
    }
}