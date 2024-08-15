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
            this.uiButton = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiButton
            // 
            this.uiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiButton.Font = new System.Drawing.Font("宋体", 11F);
            this.uiButton.Location = new System.Drawing.Point(3, 16);
            this.uiButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton.Name = "uiButton";
            this.uiButton.Radius = 35;
            this.uiButton.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiButton.Size = new System.Drawing.Size(100, 35);
            this.uiButton.TabIndex = 0;
            this.uiButton.Text = "Value";
            this.uiButton.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // ucUIDO
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.uiButton);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.Name = "ucUIDO";
            this.Size = new System.Drawing.Size(113, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton;
    }
}
