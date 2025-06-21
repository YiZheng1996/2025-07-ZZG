namespace MainUI.Procedure.Autogeneration
{
    partial class ucUIDO
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            uiButton = new UIButton();
            SuspendLayout();
            // 
            // uiButton
            // 
            uiButton.Cursor = Cursors.Hand;
            uiButton.FillColor = Color.SkyBlue;
            uiButton.FillPressColor = Color.FromArgb(115, 179, 255);
            uiButton.FillSelectedColor = Color.FromArgb(115, 179, 255);
            uiButton.Font = new Font("宋体", 11F);
            uiButton.ForeColor = Color.Black;
            uiButton.ForeHoverColor = Color.Black;
            uiButton.ForePressColor = Color.Black;
            uiButton.ForeSelectedColor = Color.Black;
            uiButton.Location = new Point(3, 16);
            uiButton.MinimumSize = new Size(1, 1);
            uiButton.Name = "uiButton";
            uiButton.Radius = 35;
            uiButton.RectColor = Color.FromArgb(255, 192, 192);
            uiButton.RectPressColor = Color.FromArgb(115, 179, 255);
            uiButton.RectSelectedColor = Color.FromArgb(115, 179, 255);
            uiButton.Size = new Size(100, 35);
            uiButton.TabIndex = 0;
            uiButton.Text = "Value";
            uiButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // ucUIDO
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.FromArgb(243, 249, 255);
            Controls.Add(uiButton);
            Font = new Font("宋体", 11F);
            Name = "ucUIDO";
            Size = new Size(113, 70);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton uiButton;
    }
}
