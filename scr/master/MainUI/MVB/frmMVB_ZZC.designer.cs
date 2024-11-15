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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMVB_ZZC));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSeach = new System.Windows.Forms.Button();
            this.PanelTree = new System.Windows.Forms.Panel();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radNone = new System.Windows.Forms.RadioButton();
            this.labPresentPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radHost = new System.Windows.Forms.RadioButton();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.radSource = new System.Windows.Forms.RadioButton();
            this.btnGoto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.swiLedMVBComm = new RW.UI.Controls.SwitchLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMVBCardStatusStr = new System.Windows.Forms.Label();
            this.lblSendHeartbeat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swiLedMVBComm)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Map_Marker_Ball_Azure_16px_1061214_easyicon.net.png");
            this.imageList1.Images.SetKeyName(1, "Map_Marker_Ball_Chartreuse_16px_1061215_easyicon.net.png");
            // 
            // btnSeach
            // 
            this.btnSeach.Font = new System.Drawing.Font("宋体", 13F);
            this.btnSeach.Location = new System.Drawing.Point(139, 53);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(75, 26);
            this.btnSeach.TabIndex = 6;
            this.btnSeach.Text = "检索";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Visible = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // PanelTree
            // 
            this.PanelTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTree.Location = new System.Drawing.Point(0, 96);
            this.PanelTree.Name = "PanelTree";
            this.PanelTree.Size = new System.Drawing.Size(214, 444);
            this.PanelTree.TabIndex = 5;
            // 
            // txtPortName
            // 
            this.txtPortName.Font = new System.Drawing.Font("宋体", 13F);
            this.txtPortName.Location = new System.Drawing.Point(2, 53);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(133, 27);
            this.txtPortName.TabIndex = 5;
            this.txtPortName.Visible = false;
            // 
            // PanelContent
            // 
            this.PanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContent.Location = new System.Drawing.Point(217, 42);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelContent.Size = new System.Drawing.Size(1102, 645);
            this.PanelContent.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 43);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radNone);
            this.panel3.Controls.Add(this.labPresentPort);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.radHost);
            this.panel3.Controls.Add(this.txtKey);
            this.panel3.Controls.Add(this.radSource);
            this.panel3.Controls.Add(this.btnGoto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("宋体", 13F);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1324, 43);
            this.panel3.TabIndex = 7;
            // 
            // radNone
            // 
            this.radNone.AutoSize = true;
            this.radNone.Checked = true;
            this.radNone.Location = new System.Drawing.Point(96, 13);
            this.radNone.Name = "radNone";
            this.radNone.Size = new System.Drawing.Size(62, 22);
            this.radNone.TabIndex = 5;
            this.radNone.TabStop = true;
            this.radNone.Text = "不限";
            this.radNone.UseVisualStyleBackColor = true;
            this.radNone.CheckedChanged += new System.EventHandler(this.radNone_CheckedChanged);
            // 
            // labPresentPort
            // 
            this.labPresentPort.AutoSize = true;
            this.labPresentPort.BackColor = System.Drawing.SystemColors.Control;
            this.labPresentPort.Font = new System.Drawing.Font("宋体", 13F);
            this.labPresentPort.Location = new System.Drawing.Point(415, 13);
            this.labPresentPort.Name = "labPresentPort";
            this.labPresentPort.Size = new System.Drawing.Size(116, 18);
            this.labPresentPort.TabIndex = 8;
            this.labPresentPort.Text = "---TCMS->VCU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(322, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "当前端口：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(986, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "查找信号名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "源宿端口:";
            // 
            // radHost
            // 
            this.radHost.AutoSize = true;
            this.radHost.Location = new System.Drawing.Point(237, 13);
            this.radHost.Name = "radHost";
            this.radHost.Size = new System.Drawing.Size(80, 22);
            this.radHost.TabIndex = 5;
            this.radHost.Text = "宿端口";
            this.radHost.UseVisualStyleBackColor = true;
            this.radHost.CheckedChanged += new System.EventHandler(this.radHost_CheckedChanged);
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Location = new System.Drawing.Point(1116, 9);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 27);
            this.txtKey.TabIndex = 3;
            // 
            // radSource
            // 
            this.radSource.AutoSize = true;
            this.radSource.Location = new System.Drawing.Point(158, 13);
            this.radSource.Name = "radSource";
            this.radSource.Size = new System.Drawing.Size(80, 22);
            this.radSource.TabIndex = 5;
            this.radSource.Text = "源端口";
            this.radSource.UseVisualStyleBackColor = true;
            this.radSource.CheckedChanged += new System.EventHandler(this.radSource_CheckedChanged);
            // 
            // btnGoto
            // 
            this.btnGoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoto.Location = new System.Drawing.Point(1222, 8);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(75, 30);
            this.btnGoto.TabIndex = 4;
            this.btnGoto.Text = "检索";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 707);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1324, 40);
            this.panel2.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 13F);
            this.btnExit.Location = new System.Drawing.Point(895, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // swiLedMVBComm
            // 
            this.swiLedMVBComm.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swiLedMVBComm.InputDriverName = null;
            this.swiLedMVBComm.InputTagName = null;
            this.swiLedMVBComm.Location = new System.Drawing.Point(22, 557);
            this.swiLedMVBComm.Margin = new System.Windows.Forms.Padding(0);
            this.swiLedMVBComm.Name = "swiLedMVBComm";
            this.swiLedMVBComm.Size = new System.Drawing.Size(158, 24);
            this.swiLedMVBComm.TabIndex = 7;
            this.swiLedMVBComm.Text = "MVB通讯状态";
            this.swiLedMVBComm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMVBCardStatusStr
            // 
            this.lblMVBCardStatusStr.AutoSize = true;
            this.lblMVBCardStatusStr.Font = new System.Drawing.Font("宋体", 13F);
            this.lblMVBCardStatusStr.Location = new System.Drawing.Point(31, 583);
            this.lblMVBCardStatusStr.Name = "lblMVBCardStatusStr";
            this.lblMVBCardStatusStr.Size = new System.Drawing.Size(125, 18);
            this.lblMVBCardStatusStr.TabIndex = 0;
            this.lblMVBCardStatusStr.Text = "MVB卡状态描述";
            // 
            // lblSendHeartbeat
            // 
            this.lblSendHeartbeat.AutoSize = true;
            this.lblSendHeartbeat.Font = new System.Drawing.Font("宋体", 13F);
            this.lblSendHeartbeat.Location = new System.Drawing.Point(24, 633);
            this.lblSendHeartbeat.Name = "lblSendHeartbeat";
            this.lblSendHeartbeat.Size = new System.Drawing.Size(143, 18);
            this.lblSendHeartbeat.TabIndex = 0;
            this.lblSendHeartbeat.Text = "发送数据心跳：0";
            // 
            // frmMVB_ZZC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 747);
            this.Controls.Add(this.swiLedMVBComm);
            this.Controls.Add(this.lblSendHeartbeat);
            this.Controls.Add(this.lblMVBCardStatusStr);
            this.Controls.Add(this.btnSeach);
            this.Controls.Add(this.PanelTree);
            this.Controls.Add(this.txtPortName);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMVB_ZZC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVB数据通讯";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.swiLedMVBComm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radHost;
        private System.Windows.Forms.RadioButton radSource;
        private System.Windows.Forms.RadioButton radNone;
        private RW.UI.Controls.SwitchLabel swiLedMVBComm;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Panel PanelTree;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPresentPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMVBCardStatusStr;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSendHeartbeat;
    }
}

