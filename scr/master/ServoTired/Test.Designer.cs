namespace ServoTired
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            RichTextBig = new Sunny.UI.UIRichTextBox();
            swBigServoERR = new SwitchPictureBox();
            uiPanel1 = new Sunny.UI.UIPanel();
            LabBigPosition = new Sunny.UI.UIDigitalLabel();
            swSmallServoERR = new SwitchPictureBox();
            uiPanel2 = new Sunny.UI.UIPanel();
            LabSmallPosition = new Sunny.UI.UIDigitalLabel();
            RichTextSmall = new Sunny.UI.UIRichTextBox();
            stepsBig = new AntdUI.Steps();
            stepsSmall = new AntdUI.Steps();
            uiPanel4 = new Sunny.UI.UIPanel();
            btnDCFBig = new Sunny.UI.UIButton();
            label2 = new Label();
            btnBigFaultReset = new Sunny.UI.UIButton();
            btnServoEnableBig = new Sunny.UI.UIButton();
            btnZeroClearingBig = new Sunny.UI.UIButton();
            btnBigGate = new Sunny.UI.UIButton();
            label1 = new Label();
            uiPanel5 = new Sunny.UI.UIPanel();
            uiPanel6 = new Sunny.UI.UIPanel();
            uiPanel7 = new Sunny.UI.UIPanel();
            btnDCFSmall = new Sunny.UI.UIButton();
            label4 = new Label();
            label3 = new Label();
            btnSmallFaultReset = new Sunny.UI.UIButton();
            btnServoEnableSmall = new Sunny.UI.UIButton();
            btnZeroClearingSamll = new Sunny.UI.UIButton();
            btnSmallGate = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            btnParaSet = new Sunny.UI.UIButton();
            btnCalibrationBig = new Sunny.UI.UIButton();
            btnCalibrationSmall = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)swBigServoERR).BeginInit();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)swSmallServoERR).BeginInit();
            uiPanel2.SuspendLayout();
            uiPanel4.SuspendLayout();
            uiPanel5.SuspendLayout();
            uiPanel6.SuspendLayout();
            uiPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // RichTextBig
            // 
            RichTextBig.FillColor = Color.White;
            RichTextBig.FillDisableColor = Color.FromArgb(243, 249, 255);
            RichTextBig.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RichTextBig.Location = new Point(8, 132);
            RichTextBig.Margin = new Padding(4, 5, 4, 5);
            RichTextBig.MinimumSize = new Size(1, 1);
            RichTextBig.Name = "RichTextBig";
            RichTextBig.Padding = new Padding(2);
            RichTextBig.Radius = 0;
            RichTextBig.ReadOnly = true;
            RichTextBig.RectColor = SystemColors.ActiveBorder;
            RichTextBig.RectDisableColor = SystemColors.ActiveBorder;
            RichTextBig.ScrollBarStyleInherited = false;
            RichTextBig.ShowText = false;
            RichTextBig.Size = new Size(449, 525);
            RichTextBig.TabIndex = 4;
            RichTextBig.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // swBigServoERR
            // 
            swBigServoERR.BackColor = Color.Transparent;
            swBigServoERR.CanClick = false;
            swBigServoERR.FalseImage = (Image)resources.GetObject("swBigServoERR.FalseImage");
            swBigServoERR.Image = (Image)resources.GetObject("swBigServoERR.Image");
            swBigServoERR.Location = new Point(384, 23);
            swBigServoERR.Name = "swBigServoERR";
            swBigServoERR.Size = new Size(42, 43);
            swBigServoERR.SizeMode = PictureBoxSizeMode.Zoom;
            swBigServoERR.Switch = false;
            swBigServoERR.TabIndex = 5;
            swBigServoERR.TabStop = false;
            swBigServoERR.Text = "伺服故障";
            swBigServoERR.TextBackColor = Color.Transparent;
            swBigServoERR.TextLayout = TextLayout.Bottom;
            swBigServoERR.TrueImage = (Image)resources.GetObject("swBigServoERR.TrueImage");
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(LabBigPosition);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(136, 22);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Padding = new Padding(3);
            uiPanel1.RectDisableColor = Color.FromArgb(80, 160, 255);
            uiPanel1.RectSize = 2;
            uiPanel1.Size = new Size(190, 45);
            uiPanel1.TabIndex = 493;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // LabBigPosition
            // 
            LabBigPosition.BackColor = Color.FromArgb(243, 249, 255);
            LabBigPosition.DecimalPlaces = 0;
            LabBigPosition.DigitalSize = 21;
            LabBigPosition.Dock = DockStyle.Fill;
            LabBigPosition.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LabBigPosition.ForeColor = Color.Black;
            LabBigPosition.Location = new Point(3, 3);
            LabBigPosition.MinimumSize = new Size(1, 1);
            LabBigPosition.Name = "LabBigPosition";
            LabBigPosition.RectSize = 2;
            LabBigPosition.Size = new Size(184, 39);
            LabBigPosition.TabIndex = 467;
            LabBigPosition.Tag = "0";
            LabBigPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // swSmallServoERR
            // 
            swSmallServoERR.BackColor = Color.Transparent;
            swSmallServoERR.CanClick = false;
            swSmallServoERR.FalseImage = (Image)resources.GetObject("swSmallServoERR.FalseImage");
            swSmallServoERR.Image = (Image)resources.GetObject("swSmallServoERR.Image");
            swSmallServoERR.Location = new Point(380, 23);
            swSmallServoERR.Name = "swSmallServoERR";
            swSmallServoERR.Size = new Size(42, 43);
            swSmallServoERR.SizeMode = PictureBoxSizeMode.Zoom;
            swSmallServoERR.Switch = false;
            swSmallServoERR.TabIndex = 494;
            swSmallServoERR.TabStop = false;
            swSmallServoERR.Text = "伺服故障";
            swSmallServoERR.TextBackColor = Color.Transparent;
            swSmallServoERR.TextLayout = TextLayout.Bottom;
            swSmallServoERR.TrueImage = (Image)resources.GetObject("swSmallServoERR.TrueImage");
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(LabSmallPosition);
            uiPanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel2.Location = new Point(132, 22);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Padding = new Padding(3);
            uiPanel2.RectDisableColor = Color.FromArgb(80, 160, 255);
            uiPanel2.RectSize = 2;
            uiPanel2.Size = new Size(190, 45);
            uiPanel2.TabIndex = 496;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // LabSmallPosition
            // 
            LabSmallPosition.BackColor = Color.FromArgb(243, 249, 255);
            LabSmallPosition.DecimalPlaces = 0;
            LabSmallPosition.DigitalSize = 21;
            LabSmallPosition.Dock = DockStyle.Fill;
            LabSmallPosition.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LabSmallPosition.ForeColor = Color.Black;
            LabSmallPosition.Location = new Point(3, 3);
            LabSmallPosition.MinimumSize = new Size(1, 1);
            LabSmallPosition.Name = "LabSmallPosition";
            LabSmallPosition.RectSize = 2;
            LabSmallPosition.Size = new Size(184, 39);
            LabSmallPosition.TabIndex = 467;
            LabSmallPosition.Tag = "0";
            LabSmallPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // RichTextSmall
            // 
            RichTextSmall.FillColor = Color.White;
            RichTextSmall.FillDisableColor = Color.FromArgb(243, 249, 255);
            RichTextSmall.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RichTextSmall.Location = new Point(8, 132);
            RichTextSmall.Margin = new Padding(4, 5, 4, 5);
            RichTextSmall.MinimumSize = new Size(1, 1);
            RichTextSmall.Name = "RichTextSmall";
            RichTextSmall.Padding = new Padding(2);
            RichTextSmall.Radius = 0;
            RichTextSmall.ReadOnly = true;
            RichTextSmall.RectColor = SystemColors.ActiveBorder;
            RichTextSmall.RectDisableColor = SystemColors.ActiveBorder;
            RichTextSmall.ScrollBarBackColor = Color.FromArgb(243, 249, 255);
            RichTextSmall.ScrollBarStyleInherited = false;
            RichTextSmall.ShowText = false;
            RichTextSmall.Size = new Size(449, 525);
            RichTextSmall.TabIndex = 4;
            RichTextSmall.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // stepsBig
            // 
            stepsBig.BackColor = Color.FromArgb(235, 242, 250);
            stepsBig.Dock = DockStyle.Fill;
            stepsBig.Font = new Font("Microsoft YaHei UI", 12F);
            stepsBig.ForeColor = SystemColors.ControlText;
            stepsBig.Location = new Point(3, 3);
            stepsBig.Name = "stepsBig";
            stepsBig.Size = new Size(160, 704);
            stepsBig.TabIndex = 1;
            stepsBig.Text = "steps1";
            stepsBig.Vertical = true;
            // 
            // stepsSmall
            // 
            stepsSmall.BackColor = Color.FromArgb(235, 242, 250);
            stepsSmall.Dock = DockStyle.Fill;
            stepsSmall.Font = new Font("Microsoft YaHei UI", 12F);
            stepsSmall.ForeColor = SystemColors.ControlText;
            stepsSmall.Location = new Point(3, 3);
            stepsSmall.Name = "stepsSmall";
            stepsSmall.Size = new Size(160, 704);
            stepsSmall.TabIndex = 2;
            stepsSmall.Text = "steps2";
            stepsSmall.Vertical = true;
            // 
            // uiPanel4
            // 
            uiPanel4.Controls.Add(swBigServoERR);
            uiPanel4.Controls.Add(btnDCFBig);
            uiPanel4.Controls.Add(label2);
            uiPanel4.Controls.Add(btnBigFaultReset);
            uiPanel4.Controls.Add(btnServoEnableBig);
            uiPanel4.Controls.Add(btnZeroClearingBig);
            uiPanel4.Controls.Add(btnBigGate);
            uiPanel4.Controls.Add(RichTextBig);
            uiPanel4.Controls.Add(uiPanel1);
            uiPanel4.Controls.Add(label1);
            uiPanel4.FillColor = Color.FromArgb(235, 242, 250);
            uiPanel4.FillColor2 = Color.FromArgb(235, 242, 250);
            uiPanel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel4.Location = new Point(193, 46);
            uiPanel4.Margin = new Padding(4, 5, 4, 5);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.RectColor = Color.FromArgb(235, 242, 250);
            uiPanel4.RectDisableColor = Color.FromArgb(235, 242, 250);
            uiPanel4.Size = new Size(464, 710);
            uiPanel4.TabIndex = 494;
            uiPanel4.Text = null;
            uiPanel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnDCFBig
            // 
            btnDCFBig.Font = new Font("宋体", 12F);
            btnDCFBig.Location = new Point(376, 670);
            btnDCFBig.MinimumSize = new Size(1, 1);
            btnDCFBig.Name = "btnDCFBig";
            btnDCFBig.Size = new Size(81, 30);
            btnDCFBig.TabIndex = 501;
            btnDCFBig.Text = "手柄夹紧";
            btnDCFBig.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDCFBig.Click += btnDCFBig_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label2.Location = new Point(131, 101);
            label2.Name = "label2";
            label2.Size = new Size(210, 24);
            label2.TabIndex = 500;
            label2.Text = "大闸自动试验信息提示";
            // 
            // btnBigFaultReset
            // 
            btnBigFaultReset.Font = new Font("宋体", 12F);
            btnBigFaultReset.Location = new Point(284, 670);
            btnBigFaultReset.MinimumSize = new Size(1, 1);
            btnBigFaultReset.Name = "btnBigFaultReset";
            btnBigFaultReset.Size = new Size(81, 30);
            btnBigFaultReset.TabIndex = 498;
            btnBigFaultReset.Text = "故障复位";
            btnBigFaultReset.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBigFaultReset.Click += btnBigFaultReset_Click;
            // 
            // btnServoEnableBig
            // 
            btnServoEnableBig.Font = new Font("宋体", 12F);
            btnServoEnableBig.Location = new Point(192, 670);
            btnServoEnableBig.MinimumSize = new Size(1, 1);
            btnServoEnableBig.Name = "btnServoEnableBig";
            btnServoEnableBig.Size = new Size(81, 30);
            btnServoEnableBig.TabIndex = 497;
            btnServoEnableBig.Text = "伺服使能";
            btnServoEnableBig.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnServoEnableBig.Click += btnServoEnableBig_Click;
            // 
            // btnZeroClearingBig
            // 
            btnZeroClearingBig.Font = new Font("宋体", 12F);
            btnZeroClearingBig.Location = new Point(100, 670);
            btnZeroClearingBig.MinimumSize = new Size(1, 1);
            btnZeroClearingBig.Name = "btnZeroClearingBig";
            btnZeroClearingBig.Size = new Size(81, 30);
            btnZeroClearingBig.TabIndex = 496;
            btnZeroClearingBig.Text = "次数清零";
            btnZeroClearingBig.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnZeroClearingBig.Click += btnZeroClearingBig_Click;
            // 
            // btnBigGate
            // 
            btnBigGate.Font = new Font("宋体", 12F);
            btnBigGate.Location = new Point(8, 670);
            btnBigGate.MinimumSize = new Size(1, 1);
            btnBigGate.Name = "btnBigGate";
            btnBigGate.Size = new Size(81, 30);
            btnBigGate.TabIndex = 495;
            btnBigGate.Text = "开始试验";
            btnBigGate.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBigGate.Click += btnBigGate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 499;
            label1.Text = "当前位置：";
            // 
            // uiPanel5
            // 
            uiPanel5.Controls.Add(stepsBig);
            uiPanel5.FillColor = Color.FromArgb(235, 242, 250);
            uiPanel5.FillColor2 = Color.FromArgb(235, 242, 250);
            uiPanel5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel5.Location = new Point(13, 46);
            uiPanel5.Margin = new Padding(4, 5, 4, 5);
            uiPanel5.MinimumSize = new Size(1, 1);
            uiPanel5.Name = "uiPanel5";
            uiPanel5.Padding = new Padding(3);
            uiPanel5.Radius = 10;
            uiPanel5.RectColor = Color.FromArgb(235, 242, 250);
            uiPanel5.RectDisableColor = Color.FromArgb(235, 242, 250);
            uiPanel5.Size = new Size(166, 710);
            uiPanel5.TabIndex = 495;
            uiPanel5.Text = "uiPanel5";
            uiPanel5.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel6
            // 
            uiPanel6.Controls.Add(stepsSmall);
            uiPanel6.FillColor = Color.FromArgb(235, 242, 250);
            uiPanel6.FillColor2 = Color.FromArgb(235, 242, 250);
            uiPanel6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel6.Location = new Point(1140, 46);
            uiPanel6.Margin = new Padding(4, 5, 4, 5);
            uiPanel6.MinimumSize = new Size(1, 1);
            uiPanel6.Name = "uiPanel6";
            uiPanel6.Padding = new Padding(3);
            uiPanel6.Radius = 10;
            uiPanel6.RectColor = Color.FromArgb(235, 242, 250);
            uiPanel6.RectDisableColor = Color.FromArgb(235, 242, 250);
            uiPanel6.Size = new Size(166, 710);
            uiPanel6.TabIndex = 496;
            uiPanel6.Text = "uiPanel6";
            uiPanel6.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel7
            // 
            uiPanel7.Controls.Add(swSmallServoERR);
            uiPanel7.Controls.Add(btnDCFSmall);
            uiPanel7.Controls.Add(label4);
            uiPanel7.Controls.Add(label3);
            uiPanel7.Controls.Add(RichTextSmall);
            uiPanel7.Controls.Add(btnSmallFaultReset);
            uiPanel7.Controls.Add(btnServoEnableSmall);
            uiPanel7.Controls.Add(btnZeroClearingSamll);
            uiPanel7.Controls.Add(uiPanel2);
            uiPanel7.Controls.Add(btnSmallGate);
            uiPanel7.FillColor = Color.FromArgb(235, 242, 250);
            uiPanel7.FillColor2 = Color.FromArgb(235, 242, 250);
            uiPanel7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel7.Location = new Point(668, 46);
            uiPanel7.Margin = new Padding(4, 5, 4, 5);
            uiPanel7.MinimumSize = new Size(1, 1);
            uiPanel7.Name = "uiPanel7";
            uiPanel7.RectColor = Color.FromArgb(235, 242, 250);
            uiPanel7.RectDisableColor = Color.FromArgb(235, 242, 250);
            uiPanel7.Size = new Size(464, 710);
            uiPanel7.TabIndex = 497;
            uiPanel7.Text = null;
            uiPanel7.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnDCFSmall
            // 
            btnDCFSmall.Font = new Font("宋体", 12F);
            btnDCFSmall.Location = new Point(376, 670);
            btnDCFSmall.MinimumSize = new Size(1, 1);
            btnDCFSmall.Name = "btnDCFSmall";
            btnDCFSmall.Size = new Size(81, 30);
            btnDCFSmall.TabIndex = 504;
            btnDCFSmall.Text = "手柄夹紧";
            btnDCFSmall.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDCFSmall.Click += btnDCFSmall_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label4.Location = new Point(22, 29);
            label4.Name = "label4";
            label4.Size = new Size(110, 24);
            label4.TabIndex = 503;
            label4.Text = "当前位置：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label3.Location = new Point(131, 99);
            label3.Name = "label3";
            label3.Size = new Size(210, 24);
            label3.TabIndex = 501;
            label3.Text = "小闸自动试验信息提示";
            // 
            // btnSmallFaultReset
            // 
            btnSmallFaultReset.Font = new Font("宋体", 12F);
            btnSmallFaultReset.Location = new Point(284, 670);
            btnSmallFaultReset.MinimumSize = new Size(1, 1);
            btnSmallFaultReset.Name = "btnSmallFaultReset";
            btnSmallFaultReset.Size = new Size(81, 30);
            btnSmallFaultReset.TabIndex = 498;
            btnSmallFaultReset.Text = "故障复位";
            btnSmallFaultReset.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSmallFaultReset.Click += btnSmallFaultReset_Click;
            // 
            // btnServoEnableSmall
            // 
            btnServoEnableSmall.Font = new Font("宋体", 12F);
            btnServoEnableSmall.Location = new Point(192, 670);
            btnServoEnableSmall.MinimumSize = new Size(1, 1);
            btnServoEnableSmall.Name = "btnServoEnableSmall";
            btnServoEnableSmall.Size = new Size(81, 30);
            btnServoEnableSmall.TabIndex = 497;
            btnServoEnableSmall.Text = "伺服使能";
            btnServoEnableSmall.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnServoEnableSmall.Click += btnServoEnableSmall_Click;
            // 
            // btnZeroClearingSamll
            // 
            btnZeroClearingSamll.Font = new Font("宋体", 12F);
            btnZeroClearingSamll.Location = new Point(100, 670);
            btnZeroClearingSamll.MinimumSize = new Size(1, 1);
            btnZeroClearingSamll.Name = "btnZeroClearingSamll";
            btnZeroClearingSamll.Size = new Size(81, 30);
            btnZeroClearingSamll.TabIndex = 496;
            btnZeroClearingSamll.Text = "次数清零";
            btnZeroClearingSamll.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnZeroClearingSamll.Click += btnZeroClearingSamll_Click;
            // 
            // btnSmallGate
            // 
            btnSmallGate.Font = new Font("宋体", 12F);
            btnSmallGate.Location = new Point(8, 670);
            btnSmallGate.MinimumSize = new Size(1, 1);
            btnSmallGate.Name = "btnSmallGate";
            btnSmallGate.Size = new Size(81, 30);
            btnSmallGate.TabIndex = 495;
            btnSmallGate.Text = "开始试验";
            btnSmallGate.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSmallGate.Click += btnSmallGate_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("宋体", 11F, FontStyle.Bold);
            btnClose.Location = new Point(1176, 770);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 35);
            btnClose.TabIndex = 499;
            btnClose.Text = "退  出";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += btnClose_Click;
            // 
            // btnParaSet
            // 
            btnParaSet.Font = new Font("宋体", 11F, FontStyle.Bold);
            btnParaSet.Location = new Point(1024, 770);
            btnParaSet.MinimumSize = new Size(1, 1);
            btnParaSet.Name = "btnParaSet";
            btnParaSet.Size = new Size(120, 35);
            btnParaSet.TabIndex = 500;
            btnParaSet.Text = "参数设置";
            btnParaSet.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnParaSet.Click += btnParaSet_Click;
            // 
            // btnCalibrationBig
            // 
            btnCalibrationBig.Font = new Font("宋体", 11F, FontStyle.Bold);
            btnCalibrationBig.Location = new Point(729, 770);
            btnCalibrationBig.MinimumSize = new Size(1, 1);
            btnCalibrationBig.Name = "btnCalibrationBig";
            btnCalibrationBig.Size = new Size(120, 35);
            btnCalibrationBig.TabIndex = 502;
            btnCalibrationBig.Text = "大闸位置校准";
            btnCalibrationBig.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnCalibrationBig.Click += btnCalibrationBig_Click;
            // 
            // btnCalibrationSmall
            // 
            btnCalibrationSmall.Font = new Font("宋体", 11F, FontStyle.Bold);
            btnCalibrationSmall.Location = new Point(881, 770);
            btnCalibrationSmall.MinimumSize = new Size(1, 1);
            btnCalibrationSmall.Name = "btnCalibrationSmall";
            btnCalibrationSmall.Size = new Size(120, 35);
            btnCalibrationSmall.TabIndex = 501;
            btnCalibrationSmall.Text = "小闸位置校准";
            btnCalibrationSmall.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnCalibrationSmall.Click += btnCalibrationSmall_Click;
            // 
            // Test
            // 
            ClientSize = new Size(1317, 817);
            ControlBox = false;
            Controls.Add(btnCalibrationBig);
            Controls.Add(btnCalibrationSmall);
            Controls.Add(btnParaSet);
            Controls.Add(btnClose);
            Controls.Add(uiPanel7);
            Controls.Add(uiPanel6);
            Controls.Add(uiPanel5);
            Controls.Add(uiPanel4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Test";
            StartPosition = FormStartPosition.CenterParent;
            Text = "制动控制器手柄疲劳试验";
            TitleFont = new Font("宋体", 14F, FontStyle.Bold);
            ZoomScaleRect = new Rectangle(15, 15, 1317, 750);
            Load += Test_Load;
            ((System.ComponentModel.ISupportInitialize)swBigServoERR).EndInit();
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)swSmallServoERR).EndInit();
            uiPanel2.ResumeLayout(false);
            uiPanel4.ResumeLayout(false);
            uiPanel4.PerformLayout();
            uiPanel5.ResumeLayout(false);
            uiPanel6.ResumeLayout(false);
            uiPanel7.ResumeLayout(false);
            uiPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIRichTextBox RichTextBig;
        private Sunny.UI.UIRichTextBox RichTextSmall;
        private AntdUI.Steps stepsBig;
        private AntdUI.Steps stepsSmall;
        private SwitchPictureBox swBigServoERR;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDigitalLabel LabBigPosition;
        private SwitchPictureBox swSmallServoERR;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIDigitalLabel LabSmallPosition;
      
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIButton btnBigGate;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIButton btnBigFaultReset;
        private Sunny.UI.UIButton btnServoEnableBig;
        private Sunny.UI.UIButton btnZeroClearingBig;
        private Label label2;
        private Label label1;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UIButton btnSmallFaultReset;
        private Sunny.UI.UIButton btnZeroClearingSamll;
        private Sunny.UI.UIButton btnSmallGate;
        private Sunny.UI.UIButton btnServoEnableSmall;
        private Label label3;
        private Label label4;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIButton btnParaSet;
        private Sunny.UI.UIButton btnCalibrationBig;
        private Sunny.UI.UIButton btnCalibrationSmall;
        private Sunny.UI.UIButton btnDCFBig;
        private Sunny.UI.UIButton btnDCFSmall;
    }
}