namespace MainUI.Procedure
{
    partial class Progressbar
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
            uiProcessBar1 = new Sunny.UI.UIProcessBar();
            SuspendLayout();
            // 
            // uiProcessBar1
            // 
            uiProcessBar1.FillColor = System.Drawing.Color.FromArgb(235, 243, 255);
            uiProcessBar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiProcessBar1.Location = new System.Drawing.Point(3, 34);
            uiProcessBar1.MinimumSize = new System.Drawing.Size(70, 3);
            uiProcessBar1.Name = "uiProcessBar1";
            uiProcessBar1.Size = new System.Drawing.Size(385, 42);
            uiProcessBar1.TabIndex = 0;
            uiProcessBar1.Text = "uiProcessBar1";
            // 
            // Progressbar
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(391, 80);
            ControlBox = false;
            Controls.Add(uiProcessBar1);
            ExtendSymbolSize = 0;
            MaximizeBox = false;
            MinimizeBox = false;
            Movable = false;
            Name = "Progressbar";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowRect = false;
            Text = "数据导入中";
            TextAlignment = System.Drawing.StringAlignment.Center;
            TitleColor = System.Drawing.Color.Gray;
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 480);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIProcessBar uiProcessBar1;
    }
}