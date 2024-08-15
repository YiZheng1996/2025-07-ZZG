namespace MainUI.Procedure.Autogeneration
{
    partial class ucUIDI
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
            this.uiLedBulb = new Sunny.UI.UILedBulb();
            this.uiLabel = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLedBulb
            // 
            this.uiLedBulb.Location = new System.Drawing.Point(33, 4);
            this.uiLedBulb.Name = "uiLedBulb";
            this.uiLedBulb.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb.TabIndex = 0;
            this.uiLedBulb.Text = "uiLedBulb1";
            // 
            // uiLabel
            // 
            this.uiLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel.Location = new System.Drawing.Point(1, 38);
            this.uiLabel.Name = "uiLabel";
            this.uiLabel.Size = new System.Drawing.Size(100, 23);
            this.uiLabel.TabIndex = 1;
            this.uiLabel.Text = "value";
            this.uiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucUIDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.uiLabel);
            this.Controls.Add(this.uiLedBulb);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "ucUIDI";
            this.Size = new System.Drawing.Size(104, 65);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILedBulb uiLedBulb;
        private Sunny.UI.UILabel uiLabel;
    }
}
