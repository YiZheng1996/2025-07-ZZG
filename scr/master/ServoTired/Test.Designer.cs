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
            divider3 = new AntdUI.Divider();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
            RichTextSmall = new Sunny.UI.UIRichTextBox();
            divider1 = new AntdUI.Divider();
            labSmallTitle = new Label();
            btnZeroClearingSamll = new AntdUI.Button();
            btnSmallGate = new AntdUI.Button();
            panel5 = new AntdUI.Panel();
            stepsBig = new AntdUI.Steps();
            panel4 = new AntdUI.Panel();
            stepsSmall = new AntdUI.Steps();
            windowBar.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
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
            RichTextBig.Location = new Point(0, 82);
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
            RichTextBig.Size = new Size(449, 449);
            RichTextBig.TabIndex = 4;
            RichTextBig.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // divider2
            // 
            divider2.Dock = DockStyle.Top;
            divider2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            divider2.Location = new Point(0, 52);
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
            btnBigGate.BackColor = Color.AliceBlue;
            btnBigGate.BorderWidth = 2F;
            btnBigGate.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnBigGate.Ghost = true;
            btnBigGate.Location = new Point(237, 581);
            btnBigGate.Name = "btnBigGate";
            btnBigGate.Size = new Size(126, 44);
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
            panel2.Location = new Point(0, 628);
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
            btnZeroClearingBig.Ghost = true;
            btnZeroClearingBig.Location = new Point(410, 582);
            btnZeroClearingBig.Name = "btnZeroClearingBig";
            btnZeroClearingBig.Size = new Size(126, 44);
            btnZeroClearingBig.TabIndex = 15;
            btnZeroClearingBig.Text = "次 数 清 零";
            btnZeroClearingBig.Click += btnZeroClearingBig_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(177, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(459, 539);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(RichTextBig);
            panel1.Controls.Add(divider2);
            panel1.Controls.Add(labBigTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft YaHei UI", 12F);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 531);
            panel1.TabIndex = 1;
            // 
            // divider3
            // 
            divider3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            divider3.Location = new Point(637, 36);
            divider3.Name = "divider3";
            divider3.Size = new Size(37, 591);
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
            flowLayoutPanel2.Size = new Size(459, 539);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Controls.Add(RichTextSmall);
            panel3.Controls.Add(divider1);
            panel3.Controls.Add(labSmallTitle);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Microsoft YaHei UI", 12F);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 531);
            panel3.TabIndex = 1;
            // 
            // RichTextSmall
            // 
            RichTextSmall.Dock = DockStyle.Bottom;
            RichTextSmall.FillColor = Color.White;
            RichTextSmall.FillDisableColor = Color.FromArgb(243, 249, 255);
            RichTextSmall.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RichTextSmall.Location = new Point(0, 82);
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
            RichTextSmall.Size = new Size(449, 449);
            RichTextSmall.TabIndex = 4;
            RichTextSmall.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // divider1
            // 
            divider1.Dock = DockStyle.Top;
            divider1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            divider1.Location = new Point(0, 52);
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
            btnZeroClearingSamll.Ghost = true;
            btnZeroClearingSamll.Location = new Point(954, 582);
            btnZeroClearingSamll.Name = "btnZeroClearingSamll";
            btnZeroClearingSamll.Size = new Size(126, 44);
            btnZeroClearingSamll.TabIndex = 20;
            btnZeroClearingSamll.Text = "次 数 清 零";
            btnZeroClearingSamll.Click += btnZeroClearingSamll_Click;
            // 
            // btnSmallGate
            // 
            btnSmallGate.BorderWidth = 2F;
            btnSmallGate.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnSmallGate.Ghost = true;
            btnSmallGate.Location = new Point(746, 582);
            btnSmallGate.Name = "btnSmallGate";
            btnSmallGate.Size = new Size(126, 44);
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
            panel5.Size = new Size(174, 593);
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
            stepsBig.Size = new Size(166, 585);
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
            panel4.Size = new Size(146, 593);
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
            stepsSmall.Size = new Size(140, 587);
            stepsSmall.TabIndex = 2;
            stepsSmall.Text = "steps2";
            stepsSmall.Vertical = true;
            // 
            // Test
            // 
            BackColor = Color.FromArgb(243, 249, 255);
            ClientSize = new Size(1282, 695);
            ControlBox = false;
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
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
    }
}