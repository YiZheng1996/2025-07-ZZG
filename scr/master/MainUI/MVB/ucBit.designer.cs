namespace MainUI.MVB
{
    partial class ucBit
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
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.SystemColors.Control;
            button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(0, 24);
            button1.Margin = new System.Windows.Forms.Padding(0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(167, 62);
            button1.TabIndex = 1;
            button1.Text = "MC1车司机激活/空压机/列出控制供电空开断开";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ucBit
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(1);
            Name = "ucBit";
            Size = new System.Drawing.Size(167, 86);
            Load += ucBit_Load;
            Paint += ucBit_Paint;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}
