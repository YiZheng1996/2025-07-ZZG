using Sunny.UI;
using System.Drawing;
using System.Windows.Forms;

namespace MainUI
{
    partial class NewfrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewfrmLogin));
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.btnSignIn = new Sunny.UI.UIButton();
            this.btnExit = new Sunny.UI.UIButton();
            this.cboUsername = new Sunny.UI.UIComboBox();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtJobNumber = new Sunny.UI.UITextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMessage = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.uiLabel3, "uiLabel3");
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSignIn
            // 
            resources.ApplyResources(this.btnSignIn, "btnSignIn");
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(111)))));
            this.btnSignIn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(111)))));
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(106)))), ((int)(((byte)(111)))));
            this.btnSignIn.Style = Sunny.UI.UIStyle.Custom;
            this.btnSignIn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSignIn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Name = "btnExit";
            this.btnExit.Radius = 1;
            this.btnExit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboUsername
            // 
            this.cboUsername.DataSource = null;
            this.cboUsername.FillColor = System.Drawing.Color.White;
            this.cboUsername.FilterMaxCount = 50;
            resources.ApplyResources(this.cboUsername, "cboUsername");
            this.cboUsername.Items.AddRange(new object[] {
            resources.GetString("cboUsername.Items"),
            resources.GetString("cboUsername.Items1"),
            resources.GetString("cboUsername.Items2"),
            resources.GetString("cboUsername.Items3"),
            resources.GetString("cboUsername.Items4"),
            resources.GetString("cboUsername.Items5"),
            resources.GetString("cboUsername.Items6"),
            resources.GetString("cboUsername.Items7"),
            resources.GetString("cboUsername.Items8"),
            resources.GetString("cboUsername.Items9"),
            resources.GetString("cboUsername.Items10"),
            resources.GetString("cboUsername.Items11")});
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.cboUsername.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cboUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboUsername.Watermark = "请选择";
            this.cboUsername.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtPassword
            // 
            this.txtPassword.ButtonWidth = 100;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RectColor = System.Drawing.Color.White;
            this.txtPassword.ScrollBarColor = System.Drawing.Color.White;
            this.txtPassword.ShowText = false;
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "请输入密码";
            this.txtPassword.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.uiLabel2, "uiLabel2");
            this.uiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.ButtonWidth = 100;
            this.txtJobNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtJobNumber, "txtJobNumber");
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.RectColor = System.Drawing.Color.White;
            this.txtJobNumber.ShowText = false;
            this.txtJobNumber.Style = Sunny.UI.UIStyle.Custom;
            this.txtJobNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtJobNumber.Watermark = "请输入作业人员工号";
            this.txtJobNumber.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Style = Sunny.UI.UIStyle.Custom;
            this.lblMessage.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnSignIn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtJobNumber);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.cboUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton btnSignIn;
        private Sunny.UI.UIButton btnExit;
        private UIComboBox cboUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtJobNumber;
        private PictureBox pictureBox1;
        private Sunny.UI.UILabel lblMessage;
    }
}