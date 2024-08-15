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
            panel1 = new System.Windows.Forms.Panel();
            lblDateTime = new System.Windows.Forms.Label();
            picRunStatus = new System.Windows.Forms.PictureBox();
            Logo = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerPLC = new System.Windows.Forms.Timer(components);
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            tslblUser = new System.Windows.Forms.ToolStripStatusLabel();
            toolToken = new System.Windows.Forms.ToolStripStatusLabel();
            tslblPLC = new System.Windows.Forms.ToolStripStatusLabel();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            panel1.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            panel1.Controls.Add(lblDateTime);
            panel1.Controls.Add(picRunStatus);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1920, 44);
            panel1.TabIndex = 0;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            lblDateTime.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDateTime.ForeColor = System.Drawing.Color.White;
            lblDateTime.Location = new System.Drawing.Point(1697, 14);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new System.Drawing.Size(159, 20);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = "2016-09-13 00:00:00";
            // 
            // picRunStatus
            // 
            picRunStatus.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            picRunStatus.Image = (System.Drawing.Image)resources.GetObject("picRunStatus.Image");
            picRunStatus.Location = new System.Drawing.Point(1865, 0);
            picRunStatus.Name = "picRunStatus";
            picRunStatus.Size = new System.Drawing.Size(43, 50);
            picRunStatus.TabIndex = 1;
            picRunStatus.TabStop = false;
            // 
            // Logo
            // 
            Logo.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            Logo.Image = Properties.Resources.logo;
            Logo.Location = new System.Drawing.Point(-1, -1);
            Logo.Name = "Logo";
            Logo.Size = new System.Drawing.Size(134, 45);
            Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblTitle.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            lblTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(362, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(1266, 44);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "试验台名称";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            statusStrip1.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslblUser, toolToken, tslblPLC });
            statusStrip1.Location = new System.Drawing.Point(0, 1010);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new System.Drawing.Size(1920, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslblUser
            // 
            tslblUser.Name = "tslblUser";
            tslblUser.Size = new System.Drawing.Size(56, 17);
            tslblUser.Text = "用户名称";
            // 
            // toolToken
            // 
            toolToken.ForeColor = System.Drawing.SystemColors.ControlText;
            toolToken.Name = "toolToken";
            toolToken.Size = new System.Drawing.Size(53, 17);
            toolToken.Text = "PLC状态";
            // 
            // tslblPLC
            // 
            tslblPLC.ForeColor = System.Drawing.SystemColors.ControlText;
            tslblPLC.Name = "tslblPLC";
            tslblPLC.Size = new System.Drawing.Size(53, 17);
            tslblPLC.Text = "PLC状态";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new System.Drawing.Point(0, 44);
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
            splitContainer1.Panel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            splitContainer1.Size = new System.Drawing.Size(1920, 966);
            splitContainer1.SplitterDistance = 109;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 5;
            // 
            // btnCAN
            // 
            btnCAN.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCAN.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCAN.Image = (System.Drawing.Image)resources.GetObject("btnCAN.Image");
            btnCAN.ImageHover = (System.Drawing.Image)resources.GetObject("btnCAN.ImageHover");
            btnCAN.ImageOffset = new System.Drawing.Point(12, 5);
            btnCAN.ImagePress = (System.Drawing.Image)resources.GetObject("btnCAN.ImagePress");
            btnCAN.Location = new System.Drawing.Point(5, 609);
            btnCAN.Name = "btnCAN";
            btnCAN.Size = new System.Drawing.Size(99, 99);
            btnCAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnCAN.TabIndex = 120;
            btnCAN.TabStop = false;
            btnCAN.Text = "CAN监控";
            btnCAN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCAN.Click += btnCAN_Click;
            // 
            // btnMVB
            // 
            btnMVB.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMVB.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMVB.Image = (System.Drawing.Image)resources.GetObject("btnMVB.Image");
            btnMVB.ImageHover = (System.Drawing.Image)resources.GetObject("btnMVB.ImageHover");
            btnMVB.ImageOffset = new System.Drawing.Point(12, 5);
            btnMVB.ImagePress = (System.Drawing.Image)resources.GetObject("btnMVB.ImagePress");
            btnMVB.Location = new System.Drawing.Point(5, 508);
            btnMVB.Name = "btnMVB";
            btnMVB.Size = new System.Drawing.Size(99, 99);
            btnMVB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnMVB.TabIndex = 119;
            btnMVB.TabStop = false;
            btnMVB.Text = "MVB监控";
            btnMVB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnMVB.Click += btnMVB_Click;
            // 
            // btnTRDP
            // 
            btnTRDP.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTRDP.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTRDP.Image = (System.Drawing.Image)resources.GetObject("btnTRDP.Image");
            btnTRDP.ImageHover = (System.Drawing.Image)resources.GetObject("btnTRDP.ImageHover");
            btnTRDP.ImageOffset = new System.Drawing.Point(12, 5);
            btnTRDP.ImagePress = (System.Drawing.Image)resources.GetObject("btnTRDP.ImagePress");
            btnTRDP.Location = new System.Drawing.Point(5, 407);
            btnTRDP.Name = "btnTRDP";
            btnTRDP.Size = new System.Drawing.Size(99, 99);
            btnTRDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnTRDP.TabIndex = 118;
            btnTRDP.TabStop = false;
            btnTRDP.Text = "TRDP监控";
            btnTRDP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTRDP.Click += BtnTRDP_Click;
            // 
            // btnDataImport
            // 
            btnDataImport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDataImport.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDataImport.Image = (System.Drawing.Image)resources.GetObject("btnDataImport.Image");
            btnDataImport.ImageHover = (System.Drawing.Image)resources.GetObject("btnDataImport.ImageHover");
            btnDataImport.ImageOffset = new System.Drawing.Point(12, 5);
            btnDataImport.ImagePress = (System.Drawing.Image)resources.GetObject("btnDataImport.ImagePress");
            btnDataImport.Location = new System.Drawing.Point(5, 205);
            btnDataImport.Name = "btnDataImport";
            btnDataImport.Size = new System.Drawing.Size(99, 99);
            btnDataImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnDataImport.TabIndex = 117;
            btnDataImport.TabStop = false;
            btnDataImport.Text = "点位配置";
            btnDataImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDataImport.Click += btnDataImport_Click;
            // 
            // btnChangePwd
            // 
            btnChangePwd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnChangePwd.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnChangePwd.Image = (System.Drawing.Image)resources.GetObject("btnChangePwd.Image");
            btnChangePwd.ImageHover = (System.Drawing.Image)resources.GetObject("btnChangePwd.ImageHover");
            btnChangePwd.ImageOffset = new System.Drawing.Point(12, 5);
            btnChangePwd.ImagePress = (System.Drawing.Image)resources.GetObject("btnChangePwd.ImagePress");
            btnChangePwd.Location = new System.Drawing.Point(5, 765);
            btnChangePwd.Name = "btnChangePwd";
            btnChangePwd.Size = new System.Drawing.Size(99, 99);
            btnChangePwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnChangePwd.TabIndex = 116;
            btnChangePwd.TabStop = false;
            btnChangePwd.Text = "修改密码";
            btnChangePwd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnChangePwd.Click += btnChangePwd_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExit.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExit.Image = (System.Drawing.Image)resources.GetObject("btnExit.Image");
            btnExit.ImageHover = (System.Drawing.Image)resources.GetObject("btnExit.ImageHover");
            btnExit.ImageOffset = new System.Drawing.Point(12, 5);
            btnExit.ImagePress = (System.Drawing.Image)resources.GetObject("btnExit.ImagePress");
            btnExit.Location = new System.Drawing.Point(5, 863);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(99, 99);
            btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnExit.TabIndex = 115;
            btnExit.TabStop = false;
            btnExit.Text = "退出";
            btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnExit.Click += btnExit_Click;
            // 
            // btnMainData
            // 
            btnMainData.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMainData.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMainData.Image = (System.Drawing.Image)resources.GetObject("btnMainData.Image");
            btnMainData.ImageHover = (System.Drawing.Image)resources.GetObject("btnMainData.ImageHover");
            btnMainData.ImageOffset = new System.Drawing.Point(12, 5);
            btnMainData.ImagePress = (System.Drawing.Image)resources.GetObject("btnMainData.ImagePress");
            btnMainData.Location = new System.Drawing.Point(5, 3);
            btnMainData.Name = "btnMainData";
            btnMainData.Size = new System.Drawing.Size(99, 99);
            btnMainData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnMainData.TabIndex = 114;
            btnMainData.TabStop = false;
            btnMainData.Text = "参数管理";
            btnMainData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnMainData.Click += btnMainData_Click;
            // 
            // btnHardwareTest
            // 
            btnHardwareTest.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHardwareTest.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnHardwareTest.Image = (System.Drawing.Image)resources.GetObject("btnHardwareTest.Image");
            btnHardwareTest.ImageHover = (System.Drawing.Image)resources.GetObject("btnHardwareTest.ImageHover");
            btnHardwareTest.ImageOffset = new System.Drawing.Point(12, 5);
            btnHardwareTest.ImagePress = (System.Drawing.Image)resources.GetObject("btnHardwareTest.ImagePress");
            btnHardwareTest.Location = new System.Drawing.Point(5, 104);
            btnHardwareTest.Name = "btnHardwareTest";
            btnHardwareTest.Size = new System.Drawing.Size(99, 99);
            btnHardwareTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnHardwareTest.TabIndex = 113;
            btnHardwareTest.TabStop = false;
            btnHardwareTest.Text = "硬件校准";
            btnHardwareTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnHardwareTest.Click += btnHardwareTest_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            btnReports.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReports.Image = (System.Drawing.Image)resources.GetObject("btnReports.Image");
            btnReports.ImageHover = (System.Drawing.Image)resources.GetObject("btnReports.ImageHover");
            btnReports.ImageOffset = new System.Drawing.Point(12, 5);
            btnReports.ImagePress = (System.Drawing.Image)resources.GetObject("btnReports.ImagePress");
            btnReports.Location = new System.Drawing.Point(5, 306);
            btnReports.Name = "btnReports";
            btnReports.Size = new System.Drawing.Size(99, 99);
            btnReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnReports.TabIndex = 112;
            btnReports.TabStop = false;
            btnReports.Text = "数据回放";
            btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnReports.Click += btnDataPlayback_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            ClientSize = new System.Drawing.Size(1920, 1032);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMainMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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