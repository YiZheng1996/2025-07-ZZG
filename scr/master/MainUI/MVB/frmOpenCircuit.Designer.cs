namespace MainUI.BCU
{
    partial class frmOpenCircuit
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
            btnClose = new Sunny.UI.UIButton();
            btnStart = new Sunny.UI.UIButton();
            ResponseText = new Sunny.UI.UIPanel();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.FillColor = System.Drawing.Color.FromArgb(230, 80, 80);
            btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(327, 272);
            btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = System.Drawing.Color.FromArgb(230, 80, 80);
            btnClose.Size = new System.Drawing.Size(100, 35);
            btnClose.TabIndex = 5;
            btnClose.Text = "退 出";
            btnClose.Click += btnClose_Click;
            // 
            // btnStart
            // 
            btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStart.FillColor = System.Drawing.Color.FromArgb(110, 190, 40);
            btnStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStart.Location = new System.Drawing.Point(137, 272);
            btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            btnStart.Name = "btnStart";
            btnStart.RectColor = System.Drawing.Color.FromArgb(110, 190, 40);
            btnStart.Size = new System.Drawing.Size(100, 35);
            btnStart.TabIndex = 4;
            btnStart.Text = "开 始";
            btnStart.Click += btnStart_Click;
            // 
            // ResponseText
            // 
            ResponseText.FillColor = System.Drawing.Color.FromArgb(238, 251, 250);
            ResponseText.FillColor2 = System.Drawing.Color.FromArgb(238, 251, 250);
            ResponseText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ResponseText.Location = new System.Drawing.Point(4, 35);
            ResponseText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            ResponseText.MinimumSize = new System.Drawing.Size(1, 1);
            ResponseText.Name = "ResponseText";
            ResponseText.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            ResponseText.Size = new System.Drawing.Size(580, 216);
            ResponseText.Style = Sunny.UI.UIStyle.Custom;
            ResponseText.TabIndex = 3;
            ResponseText.Text = null;
            ResponseText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOpenCircuit
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(238, 251, 250);
            ClientSize = new System.Drawing.Size(589, 328);
            ControlBox = false;
            ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            Controls.Add(btnClose);
            Controls.Add(btnStart);
            Controls.Add(ResponseText);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOpenCircuit";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowRect = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "输入响应测试";
            TextAlignment = System.Drawing.StringAlignment.Center;
            TitleColor = System.Drawing.Color.FromArgb(0, 190, 172);
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 943, 494);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIButton btnStart;
        private Sunny.UI.UIPanel ResponseText;
    }
}