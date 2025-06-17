namespace MainUI.Procedure
{
    partial class ucTestStep
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            lstModel = new UIListBox();
            lstAllPoint = new UIListBox();
            lstTestPoint = new UIListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRight = new UIButton();
            btnLeft = new UIButton();
            btnReset = new UIButton();
            btnClear = new UIButton();
            btnSave = new UIButton();
            btnMoveDown = new UIButton();
            btnMoveUp = new UIButton();
            SuspendLayout();
            // 
            // lstModel
            // 
            lstModel.Font = new Font("宋体", 12.75F);
            lstModel.FormattingEnabled = true;
            lstModel.HoverColor = Color.FromArgb(155, 200, 255);
            lstModel.ItemHeight = 20;
            lstModel.ItemSelectForeColor = Color.White;
            lstModel.Location = new Point(10, 87);
            lstModel.Margin = new Padding(4, 5, 4, 5);
            lstModel.MinimumSize = new Size(1, 1);
            lstModel.Name = "lstModel";
            lstModel.Padding = new Padding(2);
            lstModel.ShowText = false;
            lstModel.Size = new Size(184, 474);
            lstModel.TabIndex = 12;
            lstModel.Text = null;
            lstModel.SelectedIndexChanged += lstModel_SelectedIndexChanged;
            // 
            // lstAllPoint
            // 
            lstAllPoint.Font = new Font("宋体", 12.75F);
            lstAllPoint.FormattingEnabled = true;
            lstAllPoint.HoverColor = Color.FromArgb(155, 200, 255);
            lstAllPoint.ItemHeight = 20;
            lstAllPoint.ItemSelectForeColor = Color.White;
            lstAllPoint.Location = new Point(443, 87);
            lstAllPoint.Margin = new Padding(4, 5, 4, 5);
            lstAllPoint.MinimumSize = new Size(1, 1);
            lstAllPoint.Name = "lstAllPoint";
            lstAllPoint.Padding = new Padding(2);
            lstAllPoint.SelectionMode = SelectionMode.MultiExtended;
            lstAllPoint.ShowText = false;
            lstAllPoint.Size = new Size(198, 474);
            lstAllPoint.TabIndex = 11;
            lstAllPoint.Text = null;
            lstAllPoint.MouseDoubleClick += lstAllPoint_MouseDoubleClick;
            // 
            // lstTestPoint
            // 
            lstTestPoint.Font = new Font("宋体", 12.75F);
            lstTestPoint.FormattingEnabled = true;
            lstTestPoint.HoverColor = Color.FromArgb(155, 200, 255);
            lstTestPoint.ItemHeight = 20;
            lstTestPoint.ItemSelectForeColor = Color.White;
            lstTestPoint.Location = new Point(199, 87);
            lstTestPoint.Margin = new Padding(4, 5, 4, 5);
            lstTestPoint.MinimumSize = new Size(1, 1);
            lstTestPoint.Name = "lstTestPoint";
            lstTestPoint.Padding = new Padding(2);
            lstTestPoint.SelectionMode = SelectionMode.MultiExtended;
            lstTestPoint.ShowText = false;
            lstTestPoint.Size = new Size(198, 474);
            lstTestPoint.TabIndex = 10;
            lstTestPoint.Text = null;
            lstTestPoint.MouseDoubleClick += lstTestPoint_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 11F);
            label1.Location = new Point(13, 63);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 13;
            label1.Text = "被试品型号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 11F);
            label2.Location = new Point(200, 63);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 13;
            label2.Text = "试验项点";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 11F);
            label3.Location = new Point(443, 63);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 13;
            label3.Text = "可选试验项点";
            // 
            // btnRight
            // 
            btnRight.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnRight.Location = new Point(402, 333);
            btnRight.MinimumSize = new Size(1, 1);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(34, 34);
            btnRight.TabIndex = 15;
            btnRight.Text = "→";
            btnRight.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLeft.Location = new Point(402, 279);
            btnLeft.MinimumSize = new Size(1, 1);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(34, 34);
            btnLeft.TabIndex = 14;
            btnLeft.Text = "←";
            btnLeft.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLeft.Click += btnLeft_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnReset.Location = new Point(521, 596);
            btnReset.MinimumSize = new Size(1, 1);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(87, 33);
            btnReset.TabIndex = 18;
            btnReset.Text = "重置";
            btnReset.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnReset.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClear.Location = new Point(310, 596);
            btnClear.MinimumSize = new Size(1, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 33);
            btnClear.TabIndex = 17;
            btnClear.Text = "清空";
            btnClear.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSave.Location = new Point(199, 596);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 33);
            btnSave.TabIndex = 16;
            btnSave.Text = "保存";
            btnSave.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSave.Click += btnSave_Click;
            // 
            // btnMoveDown
            // 
            btnMoveDown.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnMoveDown.Location = new Point(338, 49);
            btnMoveDown.MinimumSize = new Size(1, 1);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new Size(46, 30);
            btnMoveDown.TabIndex = 20;
            btnMoveDown.Text = "↓";
            btnMoveDown.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnMoveDown.Click += btnMoveDown_Click;
            // 
            // btnMoveUp
            // 
            btnMoveUp.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnMoveUp.Location = new Point(285, 49);
            btnMoveUp.MinimumSize = new Size(1, 1);
            btnMoveUp.Name = "btnMoveUp";
            btnMoveUp.Size = new Size(46, 30);
            btnMoveUp.TabIndex = 19;
            btnMoveUp.Text = "↑";
            btnMoveUp.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnMoveUp.Click += btnMoveUp_Click;
            // 
            // ucTestStep
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 249, 255);
            Controls.Add(btnMoveDown);
            Controls.Add(btnMoveUp);
            Controls.Add(btnReset);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstModel);
            Controls.Add(lstAllPoint);
            Controls.Add(lstTestPoint);
            Name = "ucTestStep";
            Size = new Size(650, 650);
            Load += ucTestStep_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIListBox lstModel;
        private Sunny.UI.UIListBox lstAllPoint;
        private Sunny.UI.UIListBox lstTestPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton btnRight;
        private Sunny.UI.UIButton btnLeft;
        private Sunny.UI.UIButton btnReset;
        private Sunny.UI.UIButton btnClear;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnMoveDown;
        private Sunny.UI.UIButton btnMoveUp;
    }
}
