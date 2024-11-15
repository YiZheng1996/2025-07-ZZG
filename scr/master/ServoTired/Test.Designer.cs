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
            windowBar = new AntdUI.WindowBar();
            divider4 = new AntdUI.Divider();
            RichTextBig = new Sunny.UI.UIRichTextBox();
            divider2 = new AntdUI.Divider();
            labBigTitle = new Label();
            btnBigGate = new AntdUI.Button();
            panel2 = new Sunny.UI.UIPanel();
            btnClose = new AntdUI.Button();
            btnCalibration = new AntdUI.Button();
            btnParaSet = new AntdUI.Button();
            btnZeroClearingBig = new AntdUI.Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            swBigServoERR = new SwitchPictureBox();
            uiPanel1 = new Sunny.UI.UIPanel();
            LabBigPosition = new Sunny.UI.UIDigitalLabel();
            ucBig = new Sunny.UI.UIPanel();
            divider3 = new AntdUI.Divider();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
            swSmallServoERR = new SwitchPictureBox();
            uiPanel2 = new Sunny.UI.UIPanel();
            LabSmallPosition = new Sunny.UI.UIDigitalLabel();
            uiPanel3 = new Sunny.UI.UIPanel();
            RichTextSmall = new Sunny.UI.UIRichTextBox();
            divider1 = new AntdUI.Divider();
            labSmallTitle = new Label();
            btnZeroClearingSamll = new AntdUI.Button();
            btnSmallGate = new AntdUI.Button();
            panel5 = new AntdUI.Panel();
            stepsBig = new AntdUI.Steps();
            panel4 = new AntdUI.Panel();
            stepsSmall = new AntdUI.Steps();
            btnServoEnableBig = new AntdUI.Button();
            btnBigFaultReset = new AntdUI.Button();
            btnSmallFaultReset = new AntdUI.Button();
            btnServoEnableSmall = new AntdUI.Button();
            windowBar.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)swBigServoERR).BeginInit();
            uiPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)swSmallServoERR).BeginInit();
            uiPanel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // windowBar
            // 
            windowBar.BackColor = Color.FromArgb(243, 249, 255);
            windowBar.CancelButton = true;
            windowBar.CloseSize = 58;
            windowBar.Controls.Add(divider4);
            windowBar.DividerMargin = 2;
            windowBar.DividerShow = true;
            windowBar.DividerThickness = 2F;
            windowBar.Dock = DockStyle.Top;
            windowBar.Font = new Font("Microsoft YaHei UI", 12F);
            windowBar.Icon = (Image)resources.GetObject("windowBar.Icon");
            windowBar.IsMax = false;
            windowBar.Location = new Point(0, 0);
            windowBar.MaximizeBox = false;
            windowBar.Name = "windowBar";
            windowBar.Size = new Size(1282, 35);
            windowBar.SubText = "";
            windowBar.TabIndex = 0;
            windowBar.Text = "制动控制器手柄疲劳试验";
            // 
            // divider4
            // 
            divider4.Location = new Point(807, 35);
            divider4.Name = "divider4";
            divider4.Size = new Size(29, 585);
            divider4.TabIndex = 4;
            divider4.Text = "分割线";
            divider4.Thickness = 2F;
            divider4.Vertical = true;
            // 
            // RichTextBig
            // 
            RichTextBig.Dock = DockStyle.Bottom;
            RichTextBig.FillColor = Color.White;
            RichTextBig.FillDisableColor = Color.FromArgb(243, 249, 255);
            RichTextBig.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RichTextBig.Location = new Point(0, 105);
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
            RichTextBig.Size = new Size(449, 486);
            RichTextBig.TabIndex = 4;
            RichTextBig.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // divider2
            // 
            divider2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            divider2.Location = new Point(0, 72);
            divider2.Name = "divider2";
            divider2.Size = new Size(449, 22);
            divider2.TabIndex = 3;
            divider2.Text = "自动试验信息提示";
            divider2.Thickness = 2F;
            // 
            // labBigTitle
            // 
            labBigTitle.Dock = DockStyle.Top;
            labBigTitle.Location = new Point(0, 0);
            labBigTitle.Name = "labBigTitle";
            labBigTitle.Size = new Size(449, 52);
            labBigTitle.TabIndex = 1;
            // 
            // btnBigGate
            // 
            btnBigGate.BorderWidth = 2F;
            btnBigGate.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnBigGate.Location = new Point(180, 642);
            btnBigGate.Name = "btnBigGate";
            btnBigGate.Size = new Size(108, 44);
            btnBigGate.TabIndex = 14;
            btnBigGate.Text = "开 始 试 验";
            btnBigGate.Click += btnBigGate_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnCalibration);
            panel2.Controls.Add(btnParaSet);
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            panel2.Location = new Point(0, 682);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.MinimumSize = new Size(1, 1);
            panel2.Name = "panel2";
            panel2.RectColor = SystemColors.ActiveBorder;
            panel2.RectDisableColor = SystemColors.ActiveBorder;
            panel2.Size = new Size(1282, 67);
            panel2.TabIndex = 10;
            panel2.Text = null;
            panel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.BorderWidth = 2F;
            btnClose.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnClose.Ghost = true;
            btnClose.Location = new Point(859, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 44);
            btnClose.TabIndex = 18;
            btnClose.Text = "界 面 退 出 ";
            btnClose.Click += btnClose_Click;
            // 
            // btnCalibration
            // 
            btnCalibration.BackColor = Color.White;
            btnCalibration.BorderWidth = 2F;
            btnCalibration.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCalibration.Ghost = true;
            btnCalibration.Location = new Point(290, 14);
            btnCalibration.Name = "btnCalibration";
            btnCalibration.Size = new Size(126, 44);
            btnCalibration.TabIndex = 16;
            btnCalibration.Text = "位 置 校 准";
            btnCalibration.Click += btnCalibration_Click;
            // 
            // btnParaSet
            // 
            btnParaSet.BorderWidth = 2F;
            btnParaSet.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnParaSet.Ghost = true;
            btnParaSet.Location = new Point(571, 14);
            btnParaSet.Name = "btnParaSet";
            btnParaSet.Size = new Size(126, 44);
            btnParaSet.TabIndex = 17;
            btnParaSet.Text = "参 数 设 置";
            btnParaSet.Click += btnParaSet_Click;
            // 
            // btnZeroClearingBig
            // 
            btnZeroClearingBig.BorderWidth = 2F;
            btnZeroClearingBig.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnZeroClearingBig.Location = new Point(297, 642);
            btnZeroClearingBig.Name = "btnZeroClearingBig";
            btnZeroClearingBig.Size = new Size(108, 44);
            btnZeroClearingBig.TabIndex = 15;
            btnZeroClearingBig.Text = "次 数 清 零";
            btnZeroClearingBig.Click += btnZeroClearingBig_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(177, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(459, 599);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(swBigServoERR);
            panel1.Controls.Add(uiPanel1);
            panel1.Controls.Add(ucBig);
            panel1.Controls.Add(RichTextBig);
            panel1.Controls.Add(divider2);
            panel1.Controls.Add(labBigTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft YaHei UI", 12F);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 591);
            panel1.TabIndex = 1;
            // 
            // swBigServoERR
            // 
            swBigServoERR.CanClick = false;
            swBigServoERR.FalseImage = (Image)resources.GetObject("swBigServoERR.FalseImage");
            swBigServoERR.Image = (Image)resources.GetObject("swBigServoERR.Image");
            swBigServoERR.Location = new Point(344, 3);
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
            uiPanel1.Location = new Point(122, 7);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Padding = new Padding(2);
            uiPanel1.Radius = 0;
            uiPanel1.RectColor = Color.Black;
            uiPanel1.RectSize = 2;
            uiPanel1.Size = new Size(162, 45);
            uiPanel1.TabIndex = 493;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // LabBigPosition
            // 
            LabBigPosition.BackColor = Color.FromArgb(243, 249, 255);
            LabBigPosition.DecimalPlaces = 0;
            LabBigPosition.DigitalSize = 18;
            LabBigPosition.Dock = DockStyle.Fill;
            LabBigPosition.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LabBigPosition.ForeColor = Color.Black;
            LabBigPosition.Location = new Point(2, 2);
            LabBigPosition.MinimumSize = new Size(1, 1);
            LabBigPosition.Name = "LabBigPosition";
            LabBigPosition.RectSize = 2;
            LabBigPosition.Size = new Size(158, 41);
            LabBigPosition.TabIndex = 467;
            LabBigPosition.Tag = "0";
            LabBigPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // ucBig
            // 
            ucBig.FillDisableColor = Color.FromArgb(42, 47, 55);
            ucBig.Font = new Font("思源黑体 CN Bold", 14F, FontStyle.Bold);
            ucBig.ForeColor = Color.Black;
            ucBig.Location = new Point(9, 20);
            ucBig.Margin = new Padding(4, 5, 4, 5);
            ucBig.MinimumSize = new Size(1, 1);
            ucBig.Name = "ucBig";
            ucBig.Radius = 0;
            ucBig.RectColor = Color.FromArgb(243, 249, 255);
            ucBig.RectDisableColor = Color.FromArgb(243, 249, 255);
            ucBig.Size = new Size(126, 26);
            ucBig.Style = Sunny.UI.UIStyle.Custom;
            ucBig.TabIndex = 492;
            ucBig.Tag = "3";
            ucBig.Text = "当前位置：";
            ucBig.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // divider3
            // 
            divider3.Font = new Font("Microsoft YaHei UI", 11F);
            divider3.Location = new Point(637, 36);
            divider3.Name = "divider3";
            divider3.Size = new Size(37, 638);
            divider3.TabIndex = 17;
            divider3.Text = "分割线";
            divider3.Thickness = 2F;
            divider3.Vertical = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Location = new Point(677, 39);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(459, 599);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(swSmallServoERR);
            panel3.Controls.Add(uiPanel2);
            panel3.Controls.Add(uiPanel3);
            panel3.Controls.Add(RichTextSmall);
            panel3.Controls.Add(divider1);
            panel3.Controls.Add(labSmallTitle);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Microsoft YaHei UI", 12F);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 591);
            panel3.TabIndex = 1;
            // 
            // swSmallServoERR
            // 
            swSmallServoERR.CanClick = false;
            swSmallServoERR.FalseImage = (Image)resources.GetObject("swSmallServoERR.FalseImage");
            swSmallServoERR.Image = (Image)resources.GetObject("swSmallServoERR.Image");
            swSmallServoERR.Location = new Point(365, 3);
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
            uiPanel2.Location = new Point(143, 7);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Padding = new Padding(2);
            uiPanel2.Radius = 0;
            uiPanel2.RectColor = Color.Black;
            uiPanel2.RectSize = 2;
            uiPanel2.Size = new Size(162, 45);
            uiPanel2.TabIndex = 496;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // LabSmallPosition
            // 
            LabSmallPosition.BackColor = Color.FromArgb(243, 249, 255);
            LabSmallPosition.DecimalPlaces = 0;
            LabSmallPosition.DigitalSize = 18;
            LabSmallPosition.Dock = DockStyle.Fill;
            LabSmallPosition.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            LabSmallPosition.ForeColor = Color.Black;
            LabSmallPosition.Location = new Point(2, 2);
            LabSmallPosition.MinimumSize = new Size(1, 1);
            LabSmallPosition.Name = "LabSmallPosition";
            LabSmallPosition.RectSize = 2;
            LabSmallPosition.Size = new Size(158, 41);
            LabSmallPosition.TabIndex = 467;
            LabSmallPosition.Tag = "0";
            LabSmallPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // uiPanel3
            // 
            uiPanel3.FillDisableColor = Color.FromArgb(42, 47, 55);
            uiPanel3.Font = new Font("思源黑体 CN Bold", 14F, FontStyle.Bold);
            uiPanel3.ForeColor = Color.Black;
            uiPanel3.Location = new Point(30, 20);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 0;
            uiPanel3.RectColor = Color.FromArgb(243, 249, 255);
            uiPanel3.RectDisableColor = Color.FromArgb(243, 249, 255);
            uiPanel3.Size = new Size(126, 26);
            uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            uiPanel3.TabIndex = 495;
            uiPanel3.Tag = "3";
            uiPanel3.Text = "当前位置：";
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // RichTextSmall
            // 
            RichTextSmall.Dock = DockStyle.Bottom;
            RichTextSmall.FillColor = Color.White;
            RichTextSmall.FillDisableColor = Color.FromArgb(243, 249, 255);
            RichTextSmall.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RichTextSmall.Location = new Point(0, 105);
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
            RichTextSmall.Size = new Size(449, 486);
            RichTextSmall.TabIndex = 4;
            RichTextSmall.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // divider1
            // 
            divider1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            divider1.Location = new Point(0, 72);
            divider1.Name = "divider1";
            divider1.Size = new Size(449, 22);
            divider1.TabIndex = 3;
            divider1.Text = "自动试验信息提示";
            divider1.Thickness = 2F;
            // 
            // labSmallTitle
            // 
            labSmallTitle.Dock = DockStyle.Top;
            labSmallTitle.Location = new Point(0, 0);
            labSmallTitle.Name = "labSmallTitle";
            labSmallTitle.Size = new Size(449, 52);
            labSmallTitle.TabIndex = 1;
            // 
            // btnZeroClearingSamll
            // 
            btnZeroClearingSamll.BorderWidth = 2F;
            btnZeroClearingSamll.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnZeroClearingSamll.Location = new Point(795, 642);
            btnZeroClearingSamll.Name = "btnZeroClearingSamll";
            btnZeroClearingSamll.Size = new Size(108, 44);
            btnZeroClearingSamll.TabIndex = 20;
            btnZeroClearingSamll.Text = "次 数 清 零";
            btnZeroClearingSamll.Click += btnZeroClearingSamll_Click;
            // 
            // btnSmallGate
            // 
            btnSmallGate.BorderWidth = 2F;
            btnSmallGate.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSmallGate.Location = new Point(680, 642);
            btnSmallGate.Name = "btnSmallGate";
            btnSmallGate.Size = new Size(108, 44);
            btnSmallGate.TabIndex = 19;
            btnSmallGate.Text = "开 始 试 验";
            btnSmallGate.Click += btnSmallGate_Click;
            // 
            // panel5
            // 
            panel5.BorderColor = SystemColors.ActiveBorder;
            panel5.BorderWidth = 1F;
            panel5.Controls.Add(stepsBig);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 35);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(3);
            panel5.Size = new Size(174, 647);
            panel5.TabIndex = 21;
            panel5.Text = "panel5";
            // 
            // stepsBig
            // 
            stepsBig.Dock = DockStyle.Fill;
            stepsBig.Font = new Font("Microsoft YaHei UI", 12F);
            stepsBig.ForeColor = Color.DeepPink;
            stepsBig.Location = new Point(4, 4);
            stepsBig.Name = "stepsBig";
            stepsBig.Size = new Size(166, 639);
            stepsBig.TabIndex = 1;
            stepsBig.Text = "steps1";
            stepsBig.Vertical = true;
            // 
            // panel4
            // 
            panel4.BorderColor = SystemColors.ActiveBorder;
            panel4.BorderWidth = 1F;
            panel4.Controls.Add(stepsSmall);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1136, 35);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(2);
            panel4.Size = new Size(146, 647);
            panel4.TabIndex = 22;
            panel4.Text = "panel4";
            // 
            // stepsSmall
            // 
            stepsSmall.Dock = DockStyle.Fill;
            stepsSmall.Font = new Font("Microsoft YaHei UI", 12F);
            stepsSmall.ForeColor = Color.DeepPink;
            stepsSmall.Location = new Point(3, 3);
            stepsSmall.Name = "stepsSmall";
            stepsSmall.Size = new Size(140, 641);
            stepsSmall.TabIndex = 2;
            stepsSmall.Text = "steps2";
            stepsSmall.Vertical = true;
            // 
            // btnServoEnableBig
            // 
            btnServoEnableBig.BorderWidth = 2F;
            btnServoEnableBig.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnServoEnableBig.Location = new Point(414, 642);
            btnServoEnableBig.Name = "btnServoEnableBig";
            btnServoEnableBig.Size = new Size(108, 44);
            btnServoEnableBig.TabIndex = 23;
            btnServoEnableBig.Text = "伺 服 使 能";
            btnServoEnableBig.Click += btnServoEnableBig_Click;
            // 
            // btnBigFaultReset
            // 
            btnBigFaultReset.BorderWidth = 2F;
            btnBigFaultReset.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnBigFaultReset.Location = new Point(531, 642);
            btnBigFaultReset.Name = "btnBigFaultReset";
            btnBigFaultReset.Size = new Size(108, 44);
            btnBigFaultReset.TabIndex = 24;
            btnBigFaultReset.Text = "故 障 复 位";
            btnBigFaultReset.Click += btnBigFaultReset_Click;
            // 
            // btnSmallFaultReset
            // 
            btnSmallFaultReset.BorderWidth = 2F;
            btnSmallFaultReset.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSmallFaultReset.Location = new Point(1025, 642);
            btnSmallFaultReset.Name = "btnSmallFaultReset";
            btnSmallFaultReset.Size = new Size(108, 44);
            btnSmallFaultReset.TabIndex = 26;
            btnSmallFaultReset.Text = "故 障 复 位";
            btnSmallFaultReset.Click += btnSmallFaultReset_Click;
            // 
            // btnServoEnableSmall
            // 
            btnServoEnableSmall.BorderWidth = 2F;
            btnServoEnableSmall.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnServoEnableSmall.Location = new Point(910, 642);
            btnServoEnableSmall.Name = "btnServoEnableSmall";
            btnServoEnableSmall.Size = new Size(108, 44);
            btnServoEnableSmall.TabIndex = 25;
            btnServoEnableSmall.Text = "伺 服 使 能";
            btnServoEnableSmall.Click += btnServoEnableSmall_Click;
            // 
            // Test
            // 
            BackColor = Color.FromArgb(243, 249, 255);
            ClientSize = new Size(1282, 749);
            ControlBox = false;
            Controls.Add(btnSmallFaultReset);
            Controls.Add(btnServoEnableSmall);
            Controls.Add(btnBigFaultReset);
            Controls.Add(btnServoEnableBig);
            Controls.Add(panel4);
            Controls.Add(btnBigGate);
            Controls.Add(btnZeroClearingBig);
            Controls.Add(panel5);
            Controls.Add(btnZeroClearingSamll);
            Controls.Add(btnSmallGate);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel2);
            Controls.Add(divider3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(windowBar);
            Dark = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Mode = AntdUI.TAMode.Dark;
            Name = "Test";
            StartPosition = FormStartPosition.CenterParent;
            Load += Test_Load;
            windowBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)swBigServoERR).EndInit();
            uiPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)swSmallServoERR).EndInit();
            uiPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.WindowBar windowBar;
        private AntdUI.Divider divider2;
        private Label labBigTitle;
        private AntdUI.Divider divider4;
        private Sunny.UI.UIPanel panel2;
        private Sunny.UI.UIRichTextBox RichTextBig;
        private AntdUI.Button btnBigGate;
        private AntdUI.Button btnZeroClearingBig;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private AntdUI.Divider divider3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel3;
        private Sunny.UI.UIRichTextBox RichTextSmall;
        private AntdUI.Divider divider1;
        private Label labSmallTitle;
        private AntdUI.Button btnZeroClearingSamll;
        private AntdUI.Button btnSmallGate;
        private AntdUI.Panel panel5;
        private AntdUI.Steps stepsBig;
        private AntdUI.Panel panel4;
        private AntdUI.Steps stepsSmall;
        private AntdUI.Button btnCalibration;
        private AntdUI.Button btnParaSet;
        private AntdUI.Button btnClose;
        private SwitchPictureBox swBigServoERR;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDigitalLabel LabBigPosition;
        private Sunny.UI.UIPanel ucBig;
        private AntdUI.Button btnServoEnableBig;
        private AntdUI.Button btnBigFaultReset;
        private SwitchPictureBox swSmallServoERR;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIDigitalLabel LabSmallPosition;
        private Sunny.UI.UIPanel uiPanel3;
        private AntdUI.Button btnSmallFaultReset;
        private AntdUI.Button btnServoEnableSmall;
    }
}