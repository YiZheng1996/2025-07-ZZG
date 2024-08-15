
namespace MainUI.MVB
{
    partial class frmTagsNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTagsNew));
            imageList1 = new System.Windows.Forms.ImageList(components);
            btnSeach = new Sunny.UI.UIButton();
            PanelTree = new Sunny.UI.UIPanel();
            txtPortName = new Sunny.UI.UITextBox();
            PanelContent = new Sunny.UI.UIPanel();
            panel2 = new Sunny.UI.UIPanel();
            switchLabel2 = new RW.UI.Controls.SwitchLabel();
            btnExit = new Sunny.UI.UIButton();
            panel3 = new Sunny.UI.UIPanel();
            txtKey = new Sunny.UI.UITextBox();
            labPresentPort = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            radHost = new Sunny.UI.UIRadioButton();
            radSource = new Sunny.UI.UIRadioButton();
            btnGoto = new Sunny.UI.UIButton();
            radNone = new Sunny.UI.UIRadioButton();
            panel1 = new Sunny.UI.UIPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)switchLabel2).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Map_Marker_Ball_Azure_16px_1061214_easyicon.net.png");
            imageList1.Images.SetKeyName(1, "Map_Marker_Ball_Chartreuse_16px_1061215_easyicon.net.png");
            // 
            // btnSeach
            // 
            btnSeach.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSeach.Location = new System.Drawing.Point(200, 68);
            btnSeach.MinimumSize = new System.Drawing.Size(1, 1);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new System.Drawing.Size(76, 29);
            btnSeach.TabIndex = 6;
            btnSeach.Text = "检索";
            btnSeach.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSeach.Click += BtnSeach_Click;
            // 
            // PanelTree
            // 
            PanelTree.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PanelTree.Location = new System.Drawing.Point(0, 101);
            PanelTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PanelTree.MinimumSize = new System.Drawing.Size(1, 1);
            PanelTree.Name = "PanelTree";
            PanelTree.Size = new System.Drawing.Size(280, 817);
            PanelTree.TabIndex = 5;
            PanelTree.Text = null;
            PanelTree.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPortName
            // 
            txtPortName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPortName.Location = new System.Drawing.Point(3, 70);
            txtPortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPortName.MinimumSize = new System.Drawing.Size(1, 16);
            txtPortName.Name = "txtPortName";
            txtPortName.Padding = new System.Windows.Forms.Padding(5);
            txtPortName.ShowText = false;
            txtPortName.Size = new System.Drawing.Size(188, 26);
            txtPortName.TabIndex = 5;
            txtPortName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtPortName.Watermark = "";
            // 
            // PanelContent
            // 
            PanelContent.Dock = System.Windows.Forms.DockStyle.Right;
            PanelContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PanelContent.Location = new System.Drawing.Point(283, 65);
            PanelContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PanelContent.MinimumSize = new System.Drawing.Size(1, 1);
            PanelContent.Name = "PanelContent";
            PanelContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            PanelContent.Size = new System.Drawing.Size(979, 855);
            PanelContent.TabIndex = 4;
            PanelContent.Text = null;
            PanelContent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(switchLabel2);
            panel2.Controls.Add(btnExit);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel2.Location = new System.Drawing.Point(0, 920);
            panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel2.MinimumSize = new System.Drawing.Size(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1262, 40);
            panel2.TabIndex = 3;
            panel2.Text = null;
            panel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchLabel2
            // 
            switchLabel2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            switchLabel2.InputDriverName = null;
            switchLabel2.InputTagName = null;
            switchLabel2.Location = new System.Drawing.Point(33, 7);
            switchLabel2.Margin = new System.Windows.Forms.Padding(0);
            switchLabel2.Name = "switchLabel2";
            switchLabel2.Size = new System.Drawing.Size(158, 24);
            switchLabel2.TabIndex = 7;
            switchLabel2.Text = "MVB通讯状态";
            switchLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            btnExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExit.Location = new System.Drawing.Point(507, 3);
            btnExit.MinimumSize = new System.Drawing.Size(1, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(181, 33);
            btnExit.TabIndex = 0;
            btnExit.Text = "退出";
            btnExit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExit.Click += btnExit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtKey);
            panel3.Controls.Add(labPresentPort);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(radHost);
            panel3.Controls.Add(radSource);
            panel3.Controls.Add(btnGoto);
            panel3.Controls.Add(radNone);
            panel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel3.MinimumSize = new System.Drawing.Size(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1262, 36);
            panel3.TabIndex = 7;
            panel3.Text = null;
            panel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKey
            // 
            txtKey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            txtKey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtKey.Location = new System.Drawing.Point(1036, 6);
            txtKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtKey.MinimumSize = new System.Drawing.Size(1, 16);
            txtKey.Name = "txtKey";
            txtKey.Padding = new System.Windows.Forms.Padding(5);
            txtKey.ShowText = false;
            txtKey.Size = new System.Drawing.Size(133, 26);
            txtKey.TabIndex = 3;
            txtKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtKey.Watermark = "";
            // 
            // labPresentPort
            // 
            labPresentPort.AutoSize = true;
            labPresentPort.BackColor = System.Drawing.Color.Transparent;
            labPresentPort.Location = new System.Drawing.Point(463, 10);
            labPresentPort.Name = "labPresentPort";
            labPresentPort.Size = new System.Drawing.Size(31, 16);
            labPresentPort.TabIndex = 8;
            labPresentPort.Text = "---";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(380, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 16);
            label1.TabIndex = 7;
            label1.Text = "当前端口：";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(924, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 16);
            label2.TabIndex = 2;
            label2.Text = "查找信号名称：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Location = new System.Drawing.Point(13, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 16);
            label3.TabIndex = 6;
            label3.Text = "源宿端口：";
            // 
            // radHost
            // 
            radHost.BackColor = System.Drawing.Color.Transparent;
            radHost.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radHost.Location = new System.Drawing.Point(248, 10);
            radHost.MinimumSize = new System.Drawing.Size(1, 1);
            radHost.Name = "radHost";
            radHost.Size = new System.Drawing.Size(74, 18);
            radHost.TabIndex = 5;
            radHost.Text = "宿端口";
            radHost.CheckedChanged += radHost_CheckedChanged;
            // 
            // radSource
            // 
            radSource.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radSource.Location = new System.Drawing.Point(169, 10);
            radSource.MinimumSize = new System.Drawing.Size(1, 1);
            radSource.Name = "radSource";
            radSource.Size = new System.Drawing.Size(74, 18);
            radSource.TabIndex = 5;
            radSource.Text = "源端口";
            radSource.CheckedChanged += radSource_CheckedChanged;
            // 
            // btnGoto
            // 
            btnGoto.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnGoto.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGoto.Location = new System.Drawing.Point(1175, 4);
            btnGoto.MinimumSize = new System.Drawing.Size(1, 1);
            btnGoto.Name = "btnGoto";
            btnGoto.Size = new System.Drawing.Size(76, 29);
            btnGoto.TabIndex = 4;
            btnGoto.Text = "检索";
            btnGoto.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGoto.Click += btnGoto_Click;
            // 
            // radNone
            // 
            radNone.Checked = true;
            radNone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radNone.Location = new System.Drawing.Point(106, 10);
            radNone.MinimumSize = new System.Drawing.Size(1, 1);
            radNone.Name = "radNone";
            radNone.Size = new System.Drawing.Size(58, 18);
            radNone.TabIndex = 5;
            radNone.Text = "不限";
            radNone.CheckedChanged += radNone_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel1.Location = new System.Drawing.Point(0, 29);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.MinimumSize = new System.Drawing.Size(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1262, 36);
            panel1.TabIndex = 2;
            panel1.Text = null;
            panel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTagsNew
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1262, 960);
            ControlBox = false;
            Controls.Add(btnSeach);
            Controls.Add(PanelTree);
            Controls.Add(txtPortName);
            Controls.Add(PanelContent);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTagsNew";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            Text = "MVB数据监控";
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 990, 729);
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)switchLabel2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel panel2;
        private Sunny.UI.UIButton btnExit;
        private RW.UI.Controls.SwitchLabel switchLabel2;
        private Sunny.UI.UIPanel PanelContent;
        private Sunny.UI.UIPanel PanelTree;
        private Sunny.UI.UIButton btnSeach;
        private Sunny.UI.UITextBox txtPortName;
        private System.Windows.Forms.ImageList imageList1;
        private Sunny.UI.UIPanel panel3;
        private System.Windows.Forms.Label labPresentPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIRadioButton radHost;
        private Sunny.UI.UITextBox txtKey;
        private Sunny.UI.UIRadioButton radSource;
        private Sunny.UI.UIButton btnGoto;
        private Sunny.UI.UIRadioButton radNone;
        private Sunny.UI.UIPanel panel1;
    }
}

