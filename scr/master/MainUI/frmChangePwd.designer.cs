namespace MainUI
{
    partial class frmChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePwd));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.txtUsername = new Sunny.UI.UITextBox();
            this.txtNewPwd1 = new Sunny.UI.UITextBox();
            this.txtNewPwd2 = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.btnCancel = new Sunny.UI.UIButton();
            this.btnSubmit = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.uiLabel1, "uiLabel1");
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Name = "uiLabel1";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShowText = false;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "请输入";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.txtUsername.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtUsername.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.txtUsername.ShowText = false;
            this.txtUsername.Style = Sunny.UI.UIStyle.Custom;
            this.txtUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUsername.Watermark = "请选择";
            // 
            // txtNewPwd1
            // 
            this.txtNewPwd1.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtNewPwd1, "txtNewPwd1");
            this.txtNewPwd1.Name = "txtNewPwd1";
            this.txtNewPwd1.ShowText = false;
            this.txtNewPwd1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNewPwd1.Watermark = "请输入";
            // 
            // txtNewPwd2
            // 
            this.txtNewPwd2.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtNewPwd2, "txtNewPwd2");
            this.txtNewPwd2.Name = "txtNewPwd2";
            this.txtNewPwd2.ShowText = false;
            this.txtNewPwd2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNewPwd2.Watermark = "请输入";
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.uiLabel2, "uiLabel2");
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Name = "uiLabel2";
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.uiLabel3, "uiLabel3");
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Name = "uiLabel3";
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.uiLabel4, "uiLabel4");
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Name = "uiLabel4";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.TipsText = "1";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.TipsText = "1";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmChangePwd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.txtNewPwd2);
            this.Controls.Add(this.txtNewPwd1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePwd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmChangePwd_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtNewPwd1;
        private Sunny.UI.UITextBox txtNewPwd2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnSubmit;
    }
}