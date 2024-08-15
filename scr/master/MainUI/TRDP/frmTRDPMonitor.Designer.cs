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
            panel1 = new System.Windows.Forms.Panel();
            btnGoto = new Sunny.UI.UIButton();
            txtKey = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            labPresentPort = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            radHost = new Sunny.UI.UIRadioButton();
            radSource = new Sunny.UI.UIRadioButton();
            radNone = new Sunny.UI.UIRadioButton();
            uiLabel1 = new Sunny.UI.UILabel();
            PanelTree = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            ckbCCU_life2 = new Sunny.UI.UICheckBox();
            ckbCCU_life = new Sunny.UI.UICheckBox();
            btnClose = new Sunny.UI.UIButton();
            PanelContent = new Sunny.UI.UIPanel();
            txtPortName = new Sunny.UI.UITextBox();
            btnSeach = new Sunny.UI.UIButton();
            imageList1 = new System.Windows.Forms.ImageList(components);
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
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1262, 54);
            panel1.TabIndex = 0;
            // 
            // btnGoto
            // 
            btnGoto.FillColor = System.Drawing.Color.FromArgb(0, 190, 172);
            btnGoto.FillColor2 = System.Drawing.Color.FromArgb(0, 190, 172);
            btnGoto.FillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            btnGoto.FillPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnGoto.FillSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnGoto.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGoto.LightColor = System.Drawing.Color.FromArgb(238, 251, 250);
            btnGoto.Location = new System.Drawing.Point(1156, 13);
            btnGoto.MinimumSize = new System.Drawing.Size(1, 1);
            btnGoto.Name = "btnGoto";
            btnGoto.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            btnGoto.RectHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            btnGoto.RectPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnGoto.RectSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnGoto.Size = new System.Drawing.Size(90, 29);
            btnGoto.Style = Sunny.UI.UIStyle.Custom;
            btnGoto.TabIndex = 8;
            btnGoto.Text = "检 索";
            btnGoto.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGoto.Click += btnGoto_Click;
            // 
            // txtKey
            // 
            txtKey.ButtonFillColor = System.Drawing.Color.FromArgb(0, 190, 172);
            txtKey.ButtonFillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            txtKey.ButtonFillPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            txtKey.ButtonRectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            txtKey.ButtonRectHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            txtKey.ButtonRectPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            txtKey.ButtonStyleInherited = false;
            txtKey.FillColor2 = System.Drawing.Color.FromArgb(238, 251, 250);
            txtKey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtKey.Location = new System.Drawing.Point(996, 13);
            txtKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtKey.MinimumSize = new System.Drawing.Size(1, 16);
            txtKey.Name = "txtKey";
            txtKey.Padding = new System.Windows.Forms.Padding(5);
            txtKey.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            txtKey.ScrollBarColor = System.Drawing.Color.FromArgb(0, 190, 172);
            txtKey.ScrollBarStyleInherited = false;
            txtKey.ShowText = false;
            txtKey.Size = new System.Drawing.Size(150, 29);
            txtKey.Style = Sunny.UI.UIStyle.Custom;
            txtKey.TabIndex = 7;
            txtKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtKey.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new System.Drawing.Point(882, 17);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(129, 23);
            uiLabel4.TabIndex = 6;
            uiLabel4.Text = "查找信号名称：";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labPresentPort
            // 
            labPresentPort.AutoSize = true;
            labPresentPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labPresentPort.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            labPresentPort.Location = new System.Drawing.Point(498, 20);
            labPresentPort.Name = "labPresentPort";
            labPresentPort.Size = new System.Drawing.Size(23, 16);
            labPresentPort.TabIndex = 5;
            labPresentPort.Text = "--";
            labPresentPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel2.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new System.Drawing.Point(423, 17);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(100, 23);
            uiLabel2.TabIndex = 4;
            uiLabel2.Text = "端口信息：";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radHost
            // 
            radHost.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radHost.Location = new System.Drawing.Point(282, 11);
            radHost.MinimumSize = new System.Drawing.Size(1, 1);
            radHost.Name = "radHost";
            radHost.Size = new System.Drawing.Size(79, 29);
            radHost.TabIndex = 3;
            radHost.Text = "宿端口";
            radHost.CheckedChanged += radHost_CheckedChanged;
            // 
            // radSource
            // 
            radSource.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radSource.Location = new System.Drawing.Point(188, 11);
            radSource.MinimumSize = new System.Drawing.Size(1, 1);
            radSource.Name = "radSource";
            radSource.Size = new System.Drawing.Size(88, 29);
            radSource.TabIndex = 2;
            radSource.Text = "源端口";
            radSource.CheckedChanged += radSource_CheckedChanged;
            // 
            // radNone
            // 
            radNone.Checked = true;
            radNone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radNone.Location = new System.Drawing.Point(113, 11);
            radNone.MinimumSize = new System.Drawing.Size(1, 1);
            radNone.Name = "radNone";
            radNone.Size = new System.Drawing.Size(69, 29);
            radNone.TabIndex = 1;
            radNone.Text = "不限";
            radNone.CheckedChanged += radNone_CheckedChanged;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel1.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new System.Drawing.Point(26, 14);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(100, 23);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "源宿端口：";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelTree
            // 
            PanelTree.FillColor = System.Drawing.Color.FromArgb(238, 251, 250);
            PanelTree.FillColor2 = System.Drawing.Color.FromArgb(238, 251, 250);
            PanelTree.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PanelTree.Location = new System.Drawing.Point(4, 128);
            PanelTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PanelTree.MinimumSize = new System.Drawing.Size(1, 1);
            PanelTree.Name = "PanelTree";
            PanelTree.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            PanelTree.Size = new System.Drawing.Size(276, 783);
            PanelTree.Style = Sunny.UI.UIStyle.Custom;
            PanelTree.TabIndex = 1;
            PanelTree.Text = null;
            PanelTree.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(ckbCCU_life2);
            uiPanel2.Controls.Add(ckbCCU_life);
            uiPanel2.Controls.Add(btnClose);
            uiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            uiPanel2.FillColor = System.Drawing.Color.FromArgb(238, 251, 250);
            uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(238, 251, 250);
            uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiPanel2.Location = new System.Drawing.Point(0, 912);
            uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            uiPanel2.Size = new System.Drawing.Size(1262, 48);
            uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            uiPanel2.TabIndex = 2;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbCCU_life2
            // 
            ckbCCU_life2.CheckBoxColor = System.Drawing.Color.FromArgb(0, 190, 172);
            ckbCCU_life2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ckbCCU_life2.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            ckbCCU_life2.Location = new System.Drawing.Point(1034, 9);
            ckbCCU_life2.MinimumSize = new System.Drawing.Size(1, 1);
            ckbCCU_life2.Name = "ckbCCU_life2";
            ckbCCU_life2.Size = new System.Drawing.Size(150, 29);
            ckbCCU_life2.Style = Sunny.UI.UIStyle.Custom;
            ckbCCU_life2.TabIndex = 10;
            ckbCCU_life2.Text = "信号2断开";
            // 
            // ckbCCU_life
            // 
            ckbCCU_life.CheckBoxColor = System.Drawing.Color.FromArgb(0, 190, 172);
            ckbCCU_life.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ckbCCU_life.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            ckbCCU_life.Location = new System.Drawing.Point(878, 9);
            ckbCCU_life.MinimumSize = new System.Drawing.Size(1, 1);
            ckbCCU_life.Name = "ckbCCU_life";
            ckbCCU_life.Size = new System.Drawing.Size(150, 29);
            ckbCCU_life.Style = Sunny.UI.UIStyle.Custom;
            ckbCCU_life.TabIndex = 9;
            ckbCCU_life.Text = "信号1断开";
            // 
            // btnClose
            // 
            btnClose.FillColor = System.Drawing.Color.LightCoral;
            btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(584, 8);
            btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = System.Drawing.Color.LightCoral;
            btnClose.Size = new System.Drawing.Size(129, 33);
            btnClose.TabIndex = 9;
            btnClose.Text = "退 出";
            btnClose.Click += btnClose_Click;
            // 
            // PanelContent
            // 
            PanelContent.FillColor = System.Drawing.Color.FromArgb(238, 251, 250);
            PanelContent.FillColor2 = System.Drawing.Color.FromArgb(238, 251, 250);
            PanelContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PanelContent.Location = new System.Drawing.Point(277, 83);
            PanelContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PanelContent.MinimumSize = new System.Drawing.Size(1, 1);
            PanelContent.Name = "PanelContent";
            PanelContent.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            PanelContent.Size = new System.Drawing.Size(981, 829);
            PanelContent.Style = Sunny.UI.UIStyle.Custom;
            PanelContent.TabIndex = 3;
            PanelContent.Text = null;
            PanelContent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPortName
            // 
            txtPortName.ButtonFillColor = System.Drawing.Color.FromArgb(0, 190, 172);
            txtPortName.ButtonFillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            txtPortName.ButtonFillPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            txtPortName.ButtonRectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            txtPortName.ButtonRectHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            txtPortName.ButtonRectPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            txtPortName.ButtonStyleInherited = false;
            txtPortName.FillColor2 = System.Drawing.Color.FromArgb(238, 251, 250);
            txtPortName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPortName.Location = new System.Drawing.Point(4, 91);
            txtPortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPortName.MinimumSize = new System.Drawing.Size(1, 16);
            txtPortName.Name = "txtPortName";
            txtPortName.Padding = new System.Windows.Forms.Padding(5);
            txtPortName.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            txtPortName.ScrollBarColor = System.Drawing.Color.FromArgb(0, 190, 172);
            txtPortName.ScrollBarStyleInherited = false;
            txtPortName.ShowText = false;
            txtPortName.Size = new System.Drawing.Size(189, 29);
            txtPortName.Style = Sunny.UI.UIStyle.Custom;
            txtPortName.TabIndex = 8;
            txtPortName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtPortName.Watermark = "";
            // 
            // btnSeach
            // 
            btnSeach.FillColor = System.Drawing.Color.FromArgb(0, 190, 172);
            btnSeach.FillColor2 = System.Drawing.Color.FromArgb(0, 190, 172);
            btnSeach.FillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            btnSeach.FillPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnSeach.FillSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnSeach.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSeach.LightColor = System.Drawing.Color.FromArgb(238, 251, 250);
            btnSeach.Location = new System.Drawing.Point(200, 91);
            btnSeach.MinimumSize = new System.Drawing.Size(1, 1);
            btnSeach.Name = "btnSeach";
            btnSeach.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            btnSeach.RectHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            btnSeach.RectPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnSeach.RectSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnSeach.Size = new System.Drawing.Size(76, 29);
            btnSeach.Style = Sunny.UI.UIStyle.Custom;
            btnSeach.TabIndex = 9;
            btnSeach.Text = "检 索";
            btnSeach.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSeach.Click += btnSeach_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Map_Marker_Ball_Azure_16px_1061214_easyicon.net.png");
            imageList1.Images.SetKeyName(1, "Map_Marker_Ball_Chartreuse_16px_1061215_easyicon.net.png");
            // 
            // frmTRDPMonitor
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(238, 251, 250);
            ClientSize = new System.Drawing.Size(1262, 960);
            ControlBox = false;
            ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            Controls.Add(btnSeach);
            Controls.Add(txtPortName);
            Controls.Add(PanelContent);
            Controls.Add(uiPanel2);
            Controls.Add(PanelTree);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTRDPMonitor";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            ShowIcon = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "TRDP监控";
            TitleColor = System.Drawing.Color.FromArgb(0, 190, 172);
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
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
    }
}