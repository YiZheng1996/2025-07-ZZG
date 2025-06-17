namespace MainUI.CAN
{
    partial class frmPowerDown
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
            PowerDownText = new UIPanel();
            btnStart = new UIButton();
            btnClose = new UIButton();
            SuspendLayout();
            // 
            // PowerDownText
            // 
            PowerDownText.Font = new Font("宋体", 16F);
            PowerDownText.Location = new Point(4, 35);
            PowerDownText.Margin = new Padding(4, 5, 4, 5);
            PowerDownText.MinimumSize = new Size(1, 1);
            PowerDownText.Name = "PowerDownText";
            PowerDownText.Size = new Size(580, 216);
            PowerDownText.Style = UIStyle.Custom;
            PowerDownText.TabIndex = 0;
            PowerDownText.Text = null;
            PowerDownText.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Cursor = Cursors.Hand;
            btnStart.Font = new Font("宋体", 12F);
            btnStart.Location = new Point(162, 274);
            btnStart.MinimumSize = new Size(1, 1);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 35);
            btnStart.Style = UIStyle.Custom;
            btnStart.TabIndex = 1;
            btnStart.Text = "开 始";
            btnStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnStart.Click += btnStart_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("宋体", 12F);
            btnClose.Location = new Point(352, 274);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.Style = UIStyle.Custom;
            btnClose.TabIndex = 2;
            btnClose.Text = "退 出";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += btnClose_Click;
            // 
            // frmPowerDown
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(589, 328);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnStart);
            Controls.Add(PowerDownText);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPowerDown";
            Padding = new Padding(0, 29, 0, 0);
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowRect = false;
            Style = UIStyle.Custom;
            Text = "CAN掉电保护机制测试";
            TextAlignment = StringAlignment.Center;
            TitleFont = new Font("宋体", 12F, FontStyle.Bold);
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 800, 480);
            FormClosing += frmPowerDown_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel PowerDownText;
        private Sunny.UI.UIButton btnStart;
        private Sunny.UI.UIButton btnClose;
    }
}