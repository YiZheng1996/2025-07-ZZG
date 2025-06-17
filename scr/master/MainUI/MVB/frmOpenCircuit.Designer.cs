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
            btnClose = new UIButton();
            btnStart = new UIButton();
            ResponseText = new UIPanel();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("宋体", 12F);
            btnClose.Location = new Point(327, 272);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.Style = UIStyle.Custom;
            btnClose.TabIndex = 5;
            btnClose.Text = "退 出";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += btnClose_Click;
            // 
            // btnStart
            // 
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("宋体", 12F);
            btnStart.Location = new Point(137, 272);
            btnStart.MinimumSize = new Size(1, 1);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 35);
            btnStart.Style = UIStyle.Custom;
            btnStart.TabIndex = 4;
            btnStart.Text = "开 始";
            btnStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnStart.Click += btnStart_Click;
            // 
            // ResponseText
            // 
            ResponseText.Font = new Font("宋体", 12F);
            ResponseText.Location = new Point(4, 35);
            ResponseText.Margin = new Padding(4, 5, 4, 5);
            ResponseText.MinimumSize = new Size(1, 1);
            ResponseText.Name = "ResponseText";
            ResponseText.Size = new Size(580, 216);
            ResponseText.Style = UIStyle.Custom;
            ResponseText.TabIndex = 3;
            ResponseText.Text = null;
            ResponseText.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // frmOpenCircuit
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(589, 328);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnStart);
            Controls.Add(ResponseText);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOpenCircuit";
            Padding = new Padding(0, 29, 0, 0);
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowRect = false;
            Style = UIStyle.Custom;
            Text = "输入响应测试";
            TextAlignment = StringAlignment.Center;
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 943, 494);
            FormClosing += frmOpenCircuit_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIButton btnStart;
        private Sunny.UI.UIPanel ResponseText;
    }
}