namespace MainUI.TRDP
{
    partial class ucCombinationBit
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
            labName = new Label();
            checkName = new CheckBox();
            SuspendLayout();
            // 
            // labName
            // 
            labName.AutoSize = true;
            labName.Font = new Font("宋体", 11.5F);
            labName.Location = new Point(14, 14);
            labName.Name = "labName";
            labName.Size = new Size(87, 16);
            labName.TabIndex = 0;
            labName.Text = "字节10 位7";
            // 
            // checkName
            // 
            checkName.AutoSize = true;
            checkName.Font = new Font("宋体", 13F);
            checkName.Location = new Point(98, 12);
            checkName.Name = "checkName";
            checkName.Size = new Size(72, 22);
            checkName.TabIndex = 1;
            checkName.Text = "false";
            checkName.UseVisualStyleBackColor = true;
            checkName.CheckedChanged += checkName_CheckedChanged;
            // 
            // ucCombinationBit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 249, 255);
            Controls.Add(checkName);
            Controls.Add(labName);
            Name = "ucCombinationBit";
            Size = new Size(174, 36);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labName;
        private CheckBox checkName;
    }
}
