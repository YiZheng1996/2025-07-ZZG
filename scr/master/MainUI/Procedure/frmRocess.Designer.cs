namespace MainUI.Procedure
{
    partial class frmRocess
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
            this.uiWaitingBar1 = new Sunny.UI.UIWaitingBar();
            this.SuspendLayout();
            // 
            // uiWaitingBar1
            // 
            this.uiWaitingBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiWaitingBar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiWaitingBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiWaitingBar1.Location = new System.Drawing.Point(3, 35);
            this.uiWaitingBar1.MinimumSize = new System.Drawing.Size(70, 23);
            this.uiWaitingBar1.Name = "uiWaitingBar1";
            this.uiWaitingBar1.Size = new System.Drawing.Size(385, 42);
            this.uiWaitingBar1.TabIndex = 70;
            this.uiWaitingBar1.Text = "uiWaitingBar1";
            // 
            // frmRocess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(391, 80);
            this.ControlBox = false;
            this.Controls.Add(this.uiWaitingBar1);
            this.ExtendSymbolSize = 0;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmRocess";
            this.Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowRect = false;
            this.Text = "I/O箱点位切换中";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.Gray;
            this.TitleHeight = 29;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 480);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIWaitingBar uiWaitingBar1;
    }
}