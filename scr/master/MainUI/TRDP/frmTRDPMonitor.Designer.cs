namespace MainUI.TRDP
{
    partial class frmTRDPMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTRDPMonitor));
            panel1 = new Panel();
            btnGoto = new UIButton();
            txtKey = new UITextBox();
            uiLabel4 = new UILabel();
            labPresentPort = new UILabel();
            uiLabel2 = new UILabel();
            radHost = new UIRadioButton();
            radSource = new UIRadioButton();
            radNone = new UIRadioButton();
            uiLabel1 = new UILabel();
            PanelTree = new UIPanel();
            uiPanel2 = new UIPanel();
            ckbCCU_life4 = new UICheckBox();
            ckbCCU_life3 = new UICheckBox();
            ckbCCU_life2 = new UICheckBox();
            ckbCCU_life = new UICheckBox();
            btnClose = new UIButton();
            PanelContent = new UIPanel();
            txtPortName = new UITextBox();
            btnSeach = new UIButton();
            imageList1 = new ImageList(components);
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGoto);
            panel1.Controls.Add(txtKey);
            panel1.Controls.Add(uiLabel4);
            panel1.Controls.Add(labPresentPort);
            panel1.Controls.Add(uiLabel2);
            panel1.Controls.Add(radHost);
            panel1.Controls.Add(radSource);
            panel1.Controls.Add(radNone);
            panel1.Controls.Add(uiLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 54);
            panel1.TabIndex = 0;
            // 
            // btnGoto
            // 
            btnGoto.Font = new Font("宋体", 12F);
            btnGoto.Location = new Point(1156, 13);
            btnGoto.MinimumSize = new Size(1, 1);
            btnGoto.Name = "btnGoto";
            btnGoto.Size = new Size(90, 29);
            btnGoto.Style = UIStyle.Custom;
            btnGoto.TabIndex = 8;
            btnGoto.Text = "检 索";
            btnGoto.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnGoto.Click += btnGoto_Click;
            // 
            // txtKey
            // 
            txtKey.ButtonFillColor = Color.FromArgb(0, 190, 172);
            txtKey.ButtonFillHoverColor = Color.FromArgb(51, 203, 189);
            txtKey.ButtonFillPressColor = Color.FromArgb(0, 152, 138);
            txtKey.ButtonRectColor = Color.FromArgb(0, 190, 172);
            txtKey.ButtonRectHoverColor = Color.FromArgb(51, 203, 189);
            txtKey.ButtonRectPressColor = Color.FromArgb(0, 152, 138);
            txtKey.ButtonStyleInherited = false;
            txtKey.Font = new Font("宋体", 12F);
            txtKey.Location = new Point(996, 13);
            txtKey.Margin = new Padding(4, 5, 4, 5);
            txtKey.MinimumSize = new Size(1, 16);
            txtKey.Name = "txtKey";
            txtKey.Padding = new Padding(5);
            txtKey.ScrollBarColor = Color.FromArgb(0, 190, 172);
            txtKey.ScrollBarStyleInherited = false;
            txtKey.ShowText = false;
            txtKey.Size = new Size(150, 29);
            txtKey.Style = UIStyle.Custom;
            txtKey.TabIndex = 7;
            txtKey.TextAlignment = ContentAlignment.MiddleLeft;
            txtKey.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 12F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(882, 17);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(129, 23);
            uiLabel4.TabIndex = 6;
            uiLabel4.Text = "查找信号名称：";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labPresentPort
            // 
            labPresentPort.AutoSize = true;
            labPresentPort.Font = new Font("宋体", 12F);
            labPresentPort.ForeColor = Color.FromArgb(48, 48, 48);
            labPresentPort.Location = new Point(498, 20);
            labPresentPort.Name = "labPresentPort";
            labPresentPort.Size = new Size(23, 16);
            labPresentPort.TabIndex = 5;
            labPresentPort.Text = "--";
            labPresentPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(423, 17);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(100, 23);
            uiLabel2.TabIndex = 4;
            uiLabel2.Text = "端口信息：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radHost
            // 
            radHost.Font = new Font("宋体", 12F);
            radHost.Location = new Point(282, 11);
            radHost.MinimumSize = new Size(1, 1);
            radHost.Name = "radHost";
            radHost.Size = new Size(79, 29);
            radHost.TabIndex = 3;
            radHost.Text = "宿端口";
            radHost.CheckedChanged += radHost_CheckedChanged;
            // 
            // radSource
            // 
            radSource.Font = new Font("宋体", 12F);
            radSource.Location = new Point(188, 11);
            radSource.MinimumSize = new Size(1, 1);
            radSource.Name = "radSource";
            radSource.Size = new Size(88, 29);
            radSource.TabIndex = 2;
            radSource.Text = "源端口";
            radSource.CheckedChanged += radSource_CheckedChanged;
            // 
            // radNone
            // 
            radNone.Checked = true;
            radNone.Font = new Font("宋体", 12F);
            radNone.Location = new Point(113, 11);
            radNone.MinimumSize = new Size(1, 1);
            radNone.Name = "radNone";
            radNone.Size = new Size(69, 29);
            radNone.TabIndex = 1;
            radNone.Text = "不限";
            radNone.CheckedChanged += radNone_CheckedChanged;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(26, 14);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(100, 23);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "源宿端口：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PanelTree
            // 
            PanelTree.Font = new Font("宋体", 12F);
            PanelTree.Location = new Point(4, 128);
            PanelTree.Margin = new Padding(4, 5, 4, 5);
            PanelTree.MinimumSize = new Size(1, 1);
            PanelTree.Name = "PanelTree";
            PanelTree.Size = new Size(276, 783);
            PanelTree.Style = UIStyle.Custom;
            PanelTree.TabIndex = 1;
            PanelTree.Text = null;
            PanelTree.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(ckbCCU_life4);
            uiPanel2.Controls.Add(ckbCCU_life3);
            uiPanel2.Controls.Add(ckbCCU_life2);
            uiPanel2.Controls.Add(ckbCCU_life);
            uiPanel2.Controls.Add(btnClose);
            uiPanel2.Dock = DockStyle.Bottom;
            uiPanel2.Font = new Font("宋体", 12F);
            uiPanel2.Location = new Point(0, 912);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(1262, 48);
            uiPanel2.Style = UIStyle.Custom;
            uiPanel2.TabIndex = 2;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ckbCCU_life4
            // 
            ckbCCU_life4.Font = new Font("宋体", 12F);
            ckbCCU_life4.ForeColor = Color.FromArgb(48, 48, 48);
            ckbCCU_life4.Location = new Point(813, 12);
            ckbCCU_life4.MinimumSize = new Size(1, 1);
            ckbCCU_life4.Name = "ckbCCU_life4";
            ckbCCU_life4.Size = new Size(192, 29);
            ckbCCU_life4.Style = UIStyle.Custom;
            ckbCCU_life4.TabIndex = 12;
            ckbCCU_life4.Text = "网关2,通道2生命信号";
            // 
            // ckbCCU_life3
            // 
            ckbCCU_life3.Font = new Font("宋体", 12F);
            ckbCCU_life3.ForeColor = Color.FromArgb(48, 48, 48);
            ckbCCU_life3.Location = new Point(617, 12);
            ckbCCU_life3.MinimumSize = new Size(1, 1);
            ckbCCU_life3.Name = "ckbCCU_life3";
            ckbCCU_life3.Size = new Size(192, 29);
            ckbCCU_life3.Style = UIStyle.Custom;
            ckbCCU_life3.TabIndex = 11;
            ckbCCU_life3.Text = "网关2,通道1生命信号";
            // 
            // ckbCCU_life2
            // 
            ckbCCU_life2.Font = new Font("宋体", 12F);
            ckbCCU_life2.ForeColor = Color.FromArgb(48, 48, 48);
            ckbCCU_life2.Location = new Point(342, 12);
            ckbCCU_life2.MinimumSize = new Size(1, 1);
            ckbCCU_life2.Name = "ckbCCU_life2";
            ckbCCU_life2.Size = new Size(192, 29);
            ckbCCU_life2.Style = UIStyle.Custom;
            ckbCCU_life2.TabIndex = 10;
            ckbCCU_life2.Text = "网关1,通道2生命信号";
            // 
            // ckbCCU_life
            // 
            ckbCCU_life.Font = new Font("宋体", 12F);
            ckbCCU_life.ForeColor = Color.FromArgb(48, 48, 48);
            ckbCCU_life.Location = new Point(144, 12);
            ckbCCU_life.MinimumSize = new Size(1, 1);
            ckbCCU_life.Name = "ckbCCU_life";
            ckbCCU_life.Size = new Size(192, 29);
            ckbCCU_life.Style = UIStyle.Custom;
            ckbCCU_life.TabIndex = 9;
            ckbCCU_life.Text = "网关1,通道1生命信号";
            // 
            // btnClose
            // 
            btnClose.FillColor = Color.LightCoral;
            btnClose.Font = new Font("宋体", 12F);
            btnClose.Location = new Point(1074, 8);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = Color.LightCoral;
            btnClose.Size = new Size(129, 33);
            btnClose.TabIndex = 9;
            btnClose.Text = "退 出";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += btnClose_Click;
            // 
            // PanelContent
            // 
            PanelContent.Dock = DockStyle.Right;
            PanelContent.Font = new Font("宋体", 12F);
            PanelContent.Location = new Point(283, 83);
            PanelContent.Margin = new Padding(4, 5, 4, 5);
            PanelContent.MinimumSize = new Size(1, 1);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(979, 829);
            PanelContent.Style = UIStyle.Custom;
            PanelContent.TabIndex = 3;
            PanelContent.Text = null;
            PanelContent.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtPortName
            // 
            txtPortName.ButtonFillColor = Color.FromArgb(0, 190, 172);
            txtPortName.ButtonFillHoverColor = Color.FromArgb(51, 203, 189);
            txtPortName.ButtonFillPressColor = Color.FromArgb(0, 152, 138);
            txtPortName.ButtonRectColor = Color.FromArgb(0, 190, 172);
            txtPortName.ButtonRectHoverColor = Color.FromArgb(51, 203, 189);
            txtPortName.ButtonRectPressColor = Color.FromArgb(0, 152, 138);
            txtPortName.ButtonStyleInherited = false;
            txtPortName.Font = new Font("宋体", 12F);
            txtPortName.Location = new Point(4, 91);
            txtPortName.Margin = new Padding(4, 5, 4, 5);
            txtPortName.MinimumSize = new Size(1, 16);
            txtPortName.Name = "txtPortName";
            txtPortName.Padding = new Padding(5);
            txtPortName.ScrollBarColor = Color.FromArgb(0, 190, 172);
            txtPortName.ScrollBarStyleInherited = false;
            txtPortName.ShowText = false;
            txtPortName.Size = new Size(189, 29);
            txtPortName.Style = UIStyle.Custom;
            txtPortName.TabIndex = 8;
            txtPortName.TextAlignment = ContentAlignment.MiddleLeft;
            txtPortName.Watermark = "";
            // 
            // btnSeach
            // 
            btnSeach.Font = new Font("宋体", 12F);
            btnSeach.Location = new Point(200, 91);
            btnSeach.MinimumSize = new Size(1, 1);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new Size(76, 29);
            btnSeach.Style = UIStyle.Custom;
            btnSeach.TabIndex = 9;
            btnSeach.Text = "检 索";
            btnSeach.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSeach.Click += btnSeach_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Map_Marker_Ball_Azure_16px_1061214_easyicon.net.png");
            imageList1.Images.SetKeyName(1, "Map_Marker_Ball_Chartreuse_16px_1061215_easyicon.net.png");
            // 
            // frmTRDPMonitor
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1262, 960);
            ControlBox = false;
            Controls.Add(PanelContent);
            Controls.Add(btnSeach);
            Controls.Add(txtPortName);
            Controls.Add(uiPanel2);
            Controls.Add(PanelTree);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTRDPMonitor";
            Padding = new Padding(0, 29, 0, 0);
            ShowIcon = false;
            Style = UIStyle.Custom;
            Text = "TRDP监控";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += frmTRDPMonitor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            uiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel labPresentPort;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIRadioButton radHost;
        private Sunny.UI.UIRadioButton radSource;
        private Sunny.UI.UIRadioButton radNone;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnGoto;
        private Sunny.UI.UITextBox txtKey;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIPanel PanelTree;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIPanel PanelContent;
        private Sunny.UI.UITextBox txtPortName;
        private Sunny.UI.UIButton btnSeach;
        private System.Windows.Forms.ImageList imageList1;
        private Sunny.UI.UICheckBox ckbCCU_life;
        private Sunny.UI.UICheckBox ckbCCU_life2;
        private ToolTip toolTip1;
        private UICheckBox ckbCCU_life4;
        private UICheckBox ckbCCU_life3;
    }
}