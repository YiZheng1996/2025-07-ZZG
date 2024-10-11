namespace ServoTired
{
    partial class FrmWeary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeary));
            btnZeroClearingBig = new Sunny.UI.UIButton();
            btnBigGate = new Sunny.UI.UIButton();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            RichTextBig = new Sunny.UI.UIRichTextBox();
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            RichTextSmall = new Sunny.UI.UIRichTextBox();
            btnSmallGate = new Sunny.UI.UIButton();
            btnZeroClearingSamll = new Sunny.UI.UIButton();
            btnParaSet = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            btnCalibration = new Sunny.UI.UIButton();
            uiTitlePanel3.SuspendLayout();
            uiTitlePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnZeroClearingBig
            // 
            btnZeroClearingBig.Cursor = Cursors.Hand;
            btnZeroClearingBig.FillColor = Color.FromArgb(128, 128, 255);
            btnZeroClearingBig.Font = new Font("宋体", 12F);
            btnZeroClearingBig.Location = new Point(220, 598);
            btnZeroClearingBig.MinimumSize = new Size(1, 1);
            btnZeroClearingBig.Name = "btnZeroClearingBig";
            btnZeroClearingBig.RectColor = Color.FromArgb(128, 128, 255);
            btnZeroClearingBig.Size = new Size(120, 35);
            btnZeroClearingBig.TabIndex = 11;
            btnZeroClearingBig.Text = "次数清零";
            btnZeroClearingBig.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnZeroClearingBig.Click += BtnZeroClearingBig_Click;
            // 
            // btnBigGate
            // 
            btnBigGate.Cursor = Cursors.Hand;
            btnBigGate.FillColor = Color.FromArgb(110, 190, 40);
            btnBigGate.Font = new Font("宋体", 12F);
            btnBigGate.Location = new Point(59, 598);
            btnBigGate.MinimumSize = new Size(1, 1);
            btnBigGate.Name = "btnBigGate";
            btnBigGate.RectColor = Color.FromArgb(110, 190, 40);
            btnBigGate.Size = new Size(120, 35);
            btnBigGate.TabIndex = 10;
            btnBigGate.Text = "开 始";
            btnBigGate.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBigGate.Click += btnGate_Click;
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(RichTextBig);
            uiTitlePanel3.Controls.Add(btnBigGate);
            uiTitlePanel3.Controls.Add(btnZeroClearingBig);
            uiTitlePanel3.Font = new Font("宋体", 12F);
            uiTitlePanel3.Location = new Point(7, 35);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(420, 645);
            uiTitlePanel3.Style = Sunny.UI.UIStyle.Custom;
            uiTitlePanel3.TabIndex = 9;
            uiTitlePanel3.Text = "大闸手柄疲劳试验";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel3.TitleHeight = 20;
            // 
            // RichTextBig
            // 
            RichTextBig.FillColor = Color.White;
            RichTextBig.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RichTextBig.Location = new Point(2, 108);
            RichTextBig.Margin = new Padding(4, 5, 4, 5);
            RichTextBig.MinimumSize = new Size(1, 1);
            RichTextBig.Name = "RichTextBig";
            RichTextBig.Padding = new Padding(2);
            RichTextBig.ReadOnly = true;
            RichTextBig.ScrollBarStyleInherited = false;
            RichTextBig.ShowText = false;
            RichTextBig.Size = new Size(416, 478);
            RichTextBig.TabIndex = 17;
            RichTextBig.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(RichTextSmall);
            uiTitlePanel1.Controls.Add(btnSmallGate);
            uiTitlePanel1.Controls.Add(btnZeroClearingSamll);
            uiTitlePanel1.Font = new Font("宋体", 12F);
            uiTitlePanel1.Location = new Point(447, 35);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(420, 645);
            uiTitlePanel1.Style = Sunny.UI.UIStyle.Custom;
            uiTitlePanel1.TabIndex = 10;
            uiTitlePanel1.Text = "小闸手柄疲劳试验";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel1.TitleHeight = 20;
            // 
            // RichTextSmall
            // 
            RichTextSmall.FillColor = Color.White;
            RichTextSmall.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RichTextSmall.Location = new Point(2, 108);
            RichTextSmall.Margin = new Padding(4, 5, 4, 5);
            RichTextSmall.MinimumSize = new Size(1, 1);
            RichTextSmall.Name = "RichTextSmall";
            RichTextSmall.Padding = new Padding(2);
            RichTextSmall.ReadOnly = true;
            RichTextSmall.ScrollBarStyleInherited = false;
            RichTextSmall.ShowText = false;
            RichTextSmall.Size = new Size(416, 478);
            RichTextSmall.TabIndex = 17;
            RichTextSmall.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSmallGate
            // 
            btnSmallGate.Cursor = Cursors.Hand;
            btnSmallGate.FillColor = Color.FromArgb(110, 190, 40);
            btnSmallGate.Font = new Font("宋体", 12F);
            btnSmallGate.Location = new Point(59, 598);
            btnSmallGate.MinimumSize = new Size(1, 1);
            btnSmallGate.Name = "btnSmallGate";
            btnSmallGate.RectColor = Color.FromArgb(110, 190, 40);
            btnSmallGate.Size = new Size(120, 35);
            btnSmallGate.TabIndex = 10;
            btnSmallGate.Text = "开 始";
            btnSmallGate.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSmallGate.Click += btnSmallGate_Click;
            // 
            // btnZeroClearingSamll
            // 
            btnZeroClearingSamll.Cursor = Cursors.Hand;
            btnZeroClearingSamll.FillColor = Color.FromArgb(128, 128, 255);
            btnZeroClearingSamll.Font = new Font("宋体", 12F);
            btnZeroClearingSamll.Location = new Point(220, 598);
            btnZeroClearingSamll.MinimumSize = new Size(1, 1);
            btnZeroClearingSamll.Name = "btnZeroClearingSamll";
            btnZeroClearingSamll.RectColor = Color.FromArgb(128, 128, 255);
            btnZeroClearingSamll.Size = new Size(120, 35);
            btnZeroClearingSamll.TabIndex = 11;
            btnZeroClearingSamll.Text = "次数清零";
            btnZeroClearingSamll.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnZeroClearingSamll.Click += btnZeroClearingSamll_Click;
            // 
            // btnParaSet
            // 
            btnParaSet.Cursor = Cursors.Hand;
            btnParaSet.Font = new Font("宋体", 12F);
            btnParaSet.Location = new Point(328, 696);
            btnParaSet.MinimumSize = new Size(1, 1);
            btnParaSet.Name = "btnParaSet";
            btnParaSet.Size = new Size(144, 35);
            btnParaSet.TabIndex = 8;
            btnParaSet.Text = "参数设置";
            btnParaSet.TipsColor = Color.FromArgb(110, 190, 40);
            btnParaSet.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnParaSet.Click += btnParaSet_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("宋体", 12F);
            btnClose.Location = new Point(564, 696);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 35);
            btnClose.TabIndex = 7;
            btnClose.Text = "退 出";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += btnClose_Click;
            // 
            // btnCalibration
            // 
            btnCalibration.Cursor = Cursors.Hand;
            btnCalibration.Font = new Font("宋体", 12F);
            btnCalibration.Location = new Point(104, 696);
            btnCalibration.MinimumSize = new Size(1, 1);
            btnCalibration.Name = "btnCalibration";
            btnCalibration.Size = new Size(144, 35);
            btnCalibration.TabIndex = 11;
            btnCalibration.Text = "位置校准";
            btnCalibration.TipsColor = Color.FromArgb(110, 190, 40);
            btnCalibration.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnCalibration.Click += btnCalibration_Click;
            // 
            // FrmWeary
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(873, 752);
            ControlBox = false;
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel1);
            Controls.Add(btnCalibration);
            Controls.Add(btnClose);
            Controls.Add(btnParaSet);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmWeary";
            Padding = new Padding(0, 29, 0, 0);
            StartPosition = FormStartPosition.CenterParent;
            Text = "制动控制器手柄疲劳试验";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 1476, 750);
            Load += FrmWeary_Load;
            uiTitlePanel3.ResumeLayout(false);
            uiTitlePanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIButton btnZeroClearingBig;
        private Sunny.UI.UIButton btnBigGate;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UIRichTextBox RichTextBig;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIRichTextBox RichTextSmall;
        private Sunny.UI.UIButton btnSmallGate;
        private Sunny.UI.UIButton btnZeroClearingSamll;
        private Sunny.UI.UIButton btnParaSet;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIButton btnCalibration;
        private AntdUI.Steps stepsBig;
    }
}