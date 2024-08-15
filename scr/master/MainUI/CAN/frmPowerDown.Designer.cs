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
            PowerDownText = new Sunny.UI.UIPanel();
            btnStart = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // PowerDownText
            // 
            PowerDownText.FillColor = System.Drawing.Color.FromArgb(238, 251, 250);
            PowerDownText.FillColor2 = System.Drawing.Color.FromArgb(238, 251, 250);
            PowerDownText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PowerDownText.Location = new System.Drawing.Point(4, 35);
            PowerDownText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PowerDownText.MinimumSize = new System.Drawing.Size(1, 1);
            PowerDownText.Name = "PowerDownText";
            PowerDownText.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            PowerDownText.Size = new System.Drawing.Size(580, 216);
            PowerDownText.Style = Sunny.UI.UIStyle.Custom;
            PowerDownText.TabIndex = 0;
            PowerDownText.Text = null;
            PowerDownText.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStart.FillColor = System.Drawing.Color.FromArgb(110, 190, 40);
            btnStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStart.Location = new System.Drawing.Point(137, 274);
            btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            btnStart.Name = "btnStart";
            btnStart.RectColor = System.Drawing.Color.FromArgb(110, 190, 40);
            btnStart.Size = new System.Drawing.Size(100, 35);
            btnStart.TabIndex = 1;
            btnStart.Text = "开 始";
            btnStart.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStart.Click += btnStart_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.FillColor = System.Drawing.Color.FromArgb(230, 80, 80);
            btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(327, 274);
            btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = System.Drawing.Color.FromArgb(230, 80, 80);
            btnClose.Size = new System.Drawing.Size(100, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "退 出";
            btnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Click += btnClose_Click;
            // 
            // frmPowerDown
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(238, 251, 250);
            ClientSize = new System.Drawing.Size(589, 328);
            ControlBox = false;
            ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            Controls.Add(btnClose);
            Controls.Add(btnStart);
            Controls.Add(PowerDownText);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPowerDown";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowRect = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "CAN掉电保护机制测试";
            TextAlignment = System.Drawing.StringAlignment.Center;
            TitleColor = System.Drawing.Color.FromArgb(0, 190, 172);
            TitleFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 480);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel PowerDownText;
        private Sunny.UI.UIButton btnStart;
        private Sunny.UI.UIButton btnClose;
    }
}