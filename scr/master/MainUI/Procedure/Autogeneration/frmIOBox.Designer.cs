namespace MainUI.Procedure.Autogeneration
{
    partial class frmIOBox
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
            this.btnColse = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.SuspendLayout();
            // 
            // btnColse
            // 
            this.btnColse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnColse.Location = new System.Drawing.Point(550, 767);
            this.btnColse.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(206, 40);
            this.btnColse.TabIndex = 0;
            this.btnColse.Text = "退 出";
            this.btnColse.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 37);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 0;
            this.uiPanel1.Size = new System.Drawing.Size(1323, 720);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIOBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1323, 820);
            this.ControlBox = false;
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.btnColse);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIOBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "I/O";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1323, 730);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btnColse;
        private Sunny.UI.UIPanel uiPanel1;
    }
}