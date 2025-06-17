using Sunny.UI;

namespace MainUI
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            panel1 = new Panel();
            lblDateTime = new Label();
            picRunStatus = new PictureBox();
            Logo = new PictureBox();
            lblTitle = new Label();
            timer1 = new FormControl.Timer(components);
            timerPLC = new FormControl.Timer(components);
            statusStrip1 = new StatusStrip();
            tslblUser = new ToolStripStatusLabel();
            toolToken = new ToolStripStatusLabel();
            tslblPLC = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            btnCAN = new UIImageButton();
            btnMVB = new UIImageButton();
            btnTRDP = new UIImageButton();
            btnDataImport = new UIImageButton();
            btnChangePwd = new UIImageButton();
            btnExit = new UIImageButton();
            btnMainData = new UIImageButton();
            btnHardwareTest = new UIImageButton();
            btnReports = new UIImageButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRunStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMVB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTRDP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDataImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnChangePwd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMainData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHardwareTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReports).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 160, 255);
            panel1.Controls.Add(lblDateTime);
            panel1.Controls.Add(picRunStatus);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 44);
            panel1.TabIndex = 0;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.FromArgb(80, 160, 255);
            lblDateTime.Font = new Font("微软雅黑", 11.25F);
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(1697, 14);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(159, 20);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = "2016-09-13 00:00:00";
            // 
            // picRunStatus
            // 
            picRunStatus.BackColor = Color.FromArgb(80, 160, 255);
            picRunStatus.Image = (Image)resources.GetObject("picRunStatus.Image");
            picRunStatus.Location = new Point(1865, 0);
            picRunStatus.Name = "picRunStatus";
            picRunStatus.Size = new Size(43, 50);
            picRunStatus.TabIndex = 1;
            picRunStatus.TabStop = false;
            // 
            // Logo
            // 
            Logo.BackColor = Color.FromArgb(80, 160, 255);
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(-1, -1);
            Logo.Name = "Logo";
            Logo.Size = new Size(134, 45);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = Color.FromArgb(80, 160, 255);
            lblTitle.Font = new Font("微软雅黑", 21.75F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(362, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1266, 44);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "试验台名称";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.MouseDown += lblTitle_MouseDown;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // timerPLC
            // 
            timerPLC.Interval = 1000;
            timerPLC.Tick += timerPLC_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(239, 246, 255);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslblUser, toolToken, tslblPLC });
            statusStrip1.Location = new Point(0, 1010);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(1920, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslblUser
            // 
            tslblUser.Name = "tslblUser";
            tslblUser.Size = new Size(56, 17);
            tslblUser.Text = "用户名称";
            // 
            // toolToken
            // 
            toolToken.ForeColor = SystemColors.ControlText;
            toolToken.Name = "toolToken";
            toolToken.Size = new Size(53, 17);
            toolToken.Text = "PLC状态";
            // 
            // tslblPLC
            // 
            tslblPLC.ForeColor = SystemColors.ControlText;
            tslblPLC.Name = "tslblPLC";
            tslblPLC.Size = new Size(53, 17);
            tslblPLC.Text = "PLC状态";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 44);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCAN);
            splitContainer1.Panel1.Controls.Add(btnMVB);
            splitContainer1.Panel1.Controls.Add(btnTRDP);
            splitContainer1.Panel1.Controls.Add(btnDataImport);
            splitContainer1.Panel1.Controls.Add(btnChangePwd);
            splitContainer1.Panel1.Controls.Add(btnExit);
            splitContainer1.Panel1.Controls.Add(btnMainData);
            splitContainer1.Panel1.Controls.Add(btnHardwareTest);
            splitContainer1.Panel1.Controls.Add(btnReports);
            splitContainer1.Panel1.Font = new Font("宋体", 10.5F);
            splitContainer1.Size = new Size(1920, 966);
            splitContainer1.SplitterDistance = 109;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 5;
            // 
            // btnCAN
            // 
            btnCAN.Cursor = Cursors.Hand;
            btnCAN.Font = new Font("微软雅黑", 11F);
            btnCAN.Image = (Image)resources.GetObject("btnCAN.Image");
            btnCAN.ImageHover = (Image)resources.GetObject("btnCAN.ImageHover");
            btnCAN.ImageOffset = new Point(12, 5);
            btnCAN.ImagePress = (Image)resources.GetObject("btnCAN.ImagePress");
            btnCAN.Location = new Point(5, 609);
            btnCAN.Name = "btnCAN";
            btnCAN.Size = new Size(99, 99);
            btnCAN.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCAN.TabIndex = 120;
            btnCAN.TabStop = false;
            btnCAN.Text = "CAN监控";
            btnCAN.TextAlign = ContentAlignment.BottomCenter;
            btnCAN.Click += btnCAN_Click;
            // 
            // btnMVB
            // 
            btnMVB.Cursor = Cursors.Hand;
            btnMVB.Font = new Font("微软雅黑", 11F);
            btnMVB.Image = (Image)resources.GetObject("btnMVB.Image");
            btnMVB.ImageHover = (Image)resources.GetObject("btnMVB.ImageHover");
            btnMVB.ImageOffset = new Point(12, 5);
            btnMVB.ImagePress = (Image)resources.GetObject("btnMVB.ImagePress");
            btnMVB.Location = new Point(5, 508);
            btnMVB.Name = "btnMVB";
            btnMVB.Size = new Size(99, 99);
            btnMVB.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMVB.TabIndex = 119;
            btnMVB.TabStop = false;
            btnMVB.Text = "MVB监控";
            btnMVB.TextAlign = ContentAlignment.BottomCenter;
            btnMVB.Click += btnMVB_Click;
            // 
            // btnTRDP
            // 
            btnTRDP.Cursor = Cursors.Hand;
            btnTRDP.Font = new Font("微软雅黑", 11F);
            btnTRDP.Image = (Image)resources.GetObject("btnTRDP.Image");
            btnTRDP.ImageHover = (Image)resources.GetObject("btnTRDP.ImageHover");
            btnTRDP.ImageOffset = new Point(12, 5);
            btnTRDP.ImagePress = (Image)resources.GetObject("btnTRDP.ImagePress");
            btnTRDP.Location = new Point(5, 407);
            btnTRDP.Name = "btnTRDP";
            btnTRDP.Size = new Size(99, 99);
            btnTRDP.SizeMode = PictureBoxSizeMode.CenterImage;
            btnTRDP.TabIndex = 118;
            btnTRDP.TabStop = false;
            btnTRDP.Text = "TRDP监控";
            btnTRDP.TextAlign = ContentAlignment.BottomCenter;
            btnTRDP.Click += BtnTRDP_Click;
            // 
            // btnDataImport
            // 
            btnDataImport.Cursor = Cursors.Hand;
            btnDataImport.Font = new Font("微软雅黑", 11F);
            btnDataImport.Image = (Image)resources.GetObject("btnDataImport.Image");
            btnDataImport.ImageHover = (Image)resources.GetObject("btnDataImport.ImageHover");
            btnDataImport.ImageOffset = new Point(12, 5);
            btnDataImport.ImagePress = (Image)resources.GetObject("btnDataImport.ImagePress");
            btnDataImport.Location = new Point(5, 205);
            btnDataImport.Name = "btnDataImport";
            btnDataImport.Size = new Size(99, 99);
            btnDataImport.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDataImport.TabIndex = 117;
            btnDataImport.TabStop = false;
            btnDataImport.Text = "点位配置";
            btnDataImport.TextAlign = ContentAlignment.BottomCenter;
            btnDataImport.Click += btnDataImport_Click;
            // 
            // btnChangePwd
            // 
            btnChangePwd.Cursor = Cursors.Hand;
            btnChangePwd.Font = new Font("微软雅黑", 11F);
            btnChangePwd.Image = (Image)resources.GetObject("btnChangePwd.Image");
            btnChangePwd.ImageHover = (Image)resources.GetObject("btnChangePwd.ImageHover");
            btnChangePwd.ImageOffset = new Point(12, 5);
            btnChangePwd.ImagePress = (Image)resources.GetObject("btnChangePwd.ImagePress");
            btnChangePwd.Location = new Point(5, 765);
            btnChangePwd.Name = "btnChangePwd";
            btnChangePwd.Size = new Size(99, 99);
            btnChangePwd.SizeMode = PictureBoxSizeMode.CenterImage;
            btnChangePwd.TabIndex = 116;
            btnChangePwd.TabStop = false;
            btnChangePwd.Text = "修改密码";
            btnChangePwd.TextAlign = ContentAlignment.BottomCenter;
            btnChangePwd.Click += btnChangePwd_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("微软雅黑", 11F);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageHover = (Image)resources.GetObject("btnExit.ImageHover");
            btnExit.ImageOffset = new Point(12, 5);
            btnExit.ImagePress = (Image)resources.GetObject("btnExit.ImagePress");
            btnExit.Location = new Point(5, 863);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 99);
            btnExit.SizeMode = PictureBoxSizeMode.CenterImage;
            btnExit.TabIndex = 115;
            btnExit.TabStop = false;
            btnExit.Text = "退出";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.Click += btnExit_Click;
            // 
            // btnMainData
            // 
            btnMainData.Cursor = Cursors.Hand;
            btnMainData.Font = new Font("微软雅黑", 11F);
            btnMainData.Image = (Image)resources.GetObject("btnMainData.Image");
            btnMainData.ImageHover = (Image)resources.GetObject("btnMainData.ImageHover");
            btnMainData.ImageOffset = new Point(12, 5);
            btnMainData.ImagePress = (Image)resources.GetObject("btnMainData.ImagePress");
            btnMainData.Location = new Point(5, 3);
            btnMainData.Name = "btnMainData";
            btnMainData.Size = new Size(99, 99);
            btnMainData.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMainData.TabIndex = 114;
            btnMainData.TabStop = false;
            btnMainData.Text = "参数管理";
            btnMainData.TextAlign = ContentAlignment.BottomCenter;
            btnMainData.Click += btnMainData_Click;
            // 
            // btnHardwareTest
            // 
            btnHardwareTest.Cursor = Cursors.Hand;
            btnHardwareTest.Font = new Font("微软雅黑", 11F);
            btnHardwareTest.Image = (Image)resources.GetObject("btnHardwareTest.Image");
            btnHardwareTest.ImageHover = (Image)resources.GetObject("btnHardwareTest.ImageHover");
            btnHardwareTest.ImageOffset = new Point(12, 5);
            btnHardwareTest.ImagePress = (Image)resources.GetObject("btnHardwareTest.ImagePress");
            btnHardwareTest.Location = new Point(5, 104);
            btnHardwareTest.Name = "btnHardwareTest";
            btnHardwareTest.Size = new Size(99, 99);
            btnHardwareTest.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHardwareTest.TabIndex = 113;
            btnHardwareTest.TabStop = false;
            btnHardwareTest.Text = "硬件校准";
            btnHardwareTest.TextAlign = ContentAlignment.BottomCenter;
            btnHardwareTest.Click += btnHardwareTest_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.Font = new Font("微软雅黑", 11F);
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageHover = (Image)resources.GetObject("btnReports.ImageHover");
            btnReports.ImageOffset = new Point(12, 5);
            btnReports.ImagePress = (Image)resources.GetObject("btnReports.ImagePress");
            btnReports.Location = new Point(5, 306);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(99, 99);
            btnReports.SizeMode = PictureBoxSizeMode.CenterImage;
            btnReports.TabIndex = 112;
            btnReports.TabStop = false;
            btnReports.Text = "数据回放";
            btnReports.TextAlign = ContentAlignment.BottomCenter;
            btnReports.Click += btnDataPlayback_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(239, 246, 255);
            ClientSize = new Size(1920, 1032);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRunStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMVB).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTRDP).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDataImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnChangePwd).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMainData).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHardwareTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picRunStatus;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerPLC;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblUser;
        private System.Windows.Forms.ToolStripStatusLabel tslblPLC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Sunny.UI.UIImageButton btnExit;
        private UIImageButton btnMainData;
        private Sunny.UI.UIImageButton btnHardwareTest;
        private Sunny.UI.UIImageButton btnChangePwd;
        public System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ToolStripStatusLabel toolToken;
        private Sunny.UI.UIImageButton btnDataImport;
        private UIImageButton btnReports;
        private UIImageButton btnTRDP;
        private UIImageButton btnMVB;
        private UIImageButton btnCAN;
    }
}