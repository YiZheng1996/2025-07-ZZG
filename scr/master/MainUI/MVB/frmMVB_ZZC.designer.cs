namespace MainUI.MVB
{
    partial class frmMVB_ZZC
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMVB_ZZC));
            imageList1 = new ImageList(components);
            btnSeach = new UIButton();
            PanelTree = new UIPanel();
            lblMVBCardStatusStr = new Label();
            lblSendHeartbeat = new Label();
            txtPortName = new UITextBox();
            PanelContent = new UIPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            radNone = new UIRadioButton();
            labPresentPort = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radHost = new UIRadioButton();
            txtKey = new UITextBox();
            radSource = new UIRadioButton();
            btnGoto = new UIButton();
            panel2 = new Panel();
            btnExit = new UIButton();
            timer1 = new System.Windows.Forms.Timer(components);
            PanelTree.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Map_Marker_Ball_Azure_16px_1061214_easyicon.net.png");
            imageList1.Images.SetKeyName(1, "Map_Marker_Ball_Chartreuse_16px_1061215_easyicon.net.png");
            // 
            // btnSeach
            // 
            btnSeach.Font = new Font("宋体", 13F);
            btnSeach.Location = new Point(202, 75);
            btnSeach.MinimumSize = new Size(1, 1);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new Size(75, 28);
            btnSeach.TabIndex = 6;
            btnSeach.Text = "检索";
            btnSeach.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSeach.Click += btnSeach_Click;
            // 
            // PanelTree
            // 
            PanelTree.Controls.Add(lblSendHeartbeat);
            PanelTree.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            PanelTree.Location = new Point(3, 109);
            PanelTree.Margin = new Padding(4, 5, 4, 5);
            PanelTree.MinimumSize = new Size(1, 1);
            PanelTree.Name = "PanelTree";
            PanelTree.Size = new Size(280, 811);
            PanelTree.TabIndex = 5;
            PanelTree.Text = null;
            PanelTree.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblMVBCardStatusStr
            // 
            lblMVBCardStatusStr.AutoSize = true;
            lblMVBCardStatusStr.Font = new Font("宋体", 13F);
            lblMVBCardStatusStr.Location = new Point(1025, 11);
            lblMVBCardStatusStr.Name = "lblMVBCardStatusStr";
            lblMVBCardStatusStr.Size = new Size(125, 18);
            lblMVBCardStatusStr.TabIndex = 0;
            lblMVBCardStatusStr.Text = "MVB卡状态描述";
            // 
            // lblSendHeartbeat
            // 
            lblSendHeartbeat.AutoSize = true;
            lblSendHeartbeat.Font = new Font("宋体", 13F);
            lblSendHeartbeat.Location = new Point(14, 762);
            lblSendHeartbeat.Name = "lblSendHeartbeat";
            lblSendHeartbeat.Size = new Size(143, 18);
            lblSendHeartbeat.TabIndex = 0;
            lblSendHeartbeat.Text = "发送数据心跳：0";
            // 
            // txtPortName
            // 
            txtPortName.Font = new Font("宋体", 13F);
            txtPortName.Location = new Point(4, 76);
            txtPortName.Margin = new Padding(4, 5, 4, 5);
            txtPortName.MinimumSize = new Size(1, 16);
            txtPortName.Name = "txtPortName";
            txtPortName.Padding = new Padding(5);
            txtPortName.ShowText = false;
            txtPortName.Size = new Size(192, 27);
            txtPortName.TabIndex = 5;
            txtPortName.TextAlignment = ContentAlignment.MiddleLeft;
            txtPortName.Watermark = "";
            // 
            // PanelContent
            // 
            PanelContent.Dock = DockStyle.Right;
            PanelContent.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            PanelContent.Location = new Point(284, 72);
            PanelContent.Margin = new Padding(4, 5, 4, 5);
            PanelContent.MinimumSize = new Size(1, 1);
            PanelContent.Name = "PanelContent";
            PanelContent.RightToLeft = RightToLeft.Yes;
            PanelContent.Size = new Size(978, 848);
            PanelContent.TabIndex = 4;
            PanelContent.Text = null;
            PanelContent.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 43);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(radNone);
            panel3.Controls.Add(labPresentPort);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(radHost);
            panel3.Controls.Add(txtKey);
            panel3.Controls.Add(radSource);
            panel3.Controls.Add(btnGoto);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("宋体", 13F);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1262, 43);
            panel3.TabIndex = 7;
            // 
            // radNone
            // 
            radNone.Checked = true;
            radNone.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            radNone.Location = new Point(96, 13);
            radNone.MinimumSize = new Size(1, 1);
            radNone.Name = "radNone";
            radNone.Size = new Size(58, 18);
            radNone.TabIndex = 5;
            radNone.Text = "不限";
            radNone.CheckedChanged += radNone_CheckedChanged;
            // 
            // labPresentPort
            // 
            labPresentPort.AutoSize = true;
            labPresentPort.BackColor = Color.Transparent;
            labPresentPort.Font = new Font("宋体", 13F);
            labPresentPort.Location = new Point(415, 13);
            labPresentPort.Name = "labPresentPort";
            labPresentPort.Size = new Size(116, 18);
            labPresentPort.TabIndex = 8;
            labPresentPort.Text = "---TCMS->VCU";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(322, 13);
            label1.Name = "label1";
            label1.Size = new Size(98, 18);
            label1.TabIndex = 7;
            label1.Text = "当前端口：";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(924, 14);
            label2.Name = "label2";
            label2.Size = new Size(125, 18);
            label2.TabIndex = 2;
            label2.Text = "查找信号名称:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(9, 13);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 6;
            label3.Text = "源宿端口:";
            // 
            // radHost
            // 
            radHost.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            radHost.Location = new Point(237, 13);
            radHost.MinimumSize = new Size(1, 1);
            radHost.Name = "radHost";
            radHost.Size = new Size(74, 18);
            radHost.TabIndex = 5;
            radHost.Text = "宿端口";
            radHost.CheckedChanged += radHost_CheckedChanged;
            // 
            // txtKey
            // 
            txtKey.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtKey.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtKey.Location = new Point(1054, 9);
            txtKey.Margin = new Padding(4, 5, 4, 5);
            txtKey.MinimumSize = new Size(1, 16);
            txtKey.Name = "txtKey";
            txtKey.Padding = new Padding(5);
            txtKey.ShowText = false;
            txtKey.Size = new Size(114, 27);
            txtKey.TabIndex = 3;
            txtKey.TextAlignment = ContentAlignment.MiddleLeft;
            txtKey.Watermark = "";
            // 
            // radSource
            // 
            radSource.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            radSource.Location = new Point(158, 13);
            radSource.MinimumSize = new Size(1, 1);
            radSource.Name = "radSource";
            radSource.Size = new Size(74, 18);
            radSource.TabIndex = 5;
            radSource.Text = "源端口";
            radSource.CheckedChanged += radSource_CheckedChanged;
            // 
            // btnGoto
            // 
            btnGoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnGoto.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnGoto.Location = new Point(1175, 8);
            btnGoto.MinimumSize = new Size(1, 1);
            btnGoto.Name = "btnGoto";
            btnGoto.Size = new Size(75, 30);
            btnGoto.TabIndex = 4;
            btnGoto.Text = "检索";
            btnGoto.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnGoto.Click += btnGoto_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMVBCardStatusStr);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 920);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 40);
            panel2.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("宋体", 13F);
            btnExit.Location = new Point(548, 4);
            btnExit.MinimumSize = new Size(1, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 33);
            btnExit.TabIndex = 0;
            btnExit.Text = "退出";
            btnExit.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnExit.Click += btnExit_Click;
            // 
            // timer1
            // 
            timer1.Interval = 300000;
            timer1.Tick += timer1_Tick;
            // 
            // frmMVB_ZZC
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1262, 960);
            ControlBox = false;
            Controls.Add(btnSeach);
            Controls.Add(PanelTree);
            Controls.Add(txtPortName);
            Controls.Add(PanelContent);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMVB_ZZC";
            Padding = new Padding(0, 29, 0, 0);
            Text = "MVB数据监控";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 1324, 747);
            Load += Form1_Load;
            PanelTree.ResumeLayout(false);
            PanelTree.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UIButton btnGoto;
        private Sunny.UI.UITextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIRadioButton radHost;
        private Sunny.UI.UIRadioButton radSource;
        private Sunny.UI.UIRadioButton radNone;
        private RW.UI.Controls.SwitchLabel swiLedMVBComm;
        private Sunny.UI.UIPanel PanelContent;
        private Sunny.UI.UIPanel PanelTree;
        private Sunny.UI.UIButton btnSeach;
        private Sunny.UI.UITextBox txtPortName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPresentPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMVBCardStatusStr;
        public Sunny.UI.UIButton btnExit;
        private System.Windows.Forms.Label lblSendHeartbeat;
    }
}

