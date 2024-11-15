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
            btnColse = new UIButton();
            uiPanel1 = new UIPanel();
            SuspendLayout();
            // 
            // btnColse
            // 
            btnColse.Cursor = Cursors.Hand;
            btnColse.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnColse.Location = new Point(585, 763);
            btnColse.MinimumSize = new Size(1, 1);
            btnColse.Name = "btnColse";
            btnColse.Size = new Size(206, 40);
            btnColse.TabIndex = 0;
            btnColse.Text = "退 出";
            btnColse.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnColse.Click += btnColse_Click;
            // 
            // uiPanel1
            // 
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(0, 35);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 0;
            uiPanel1.Size = new Size(1381, 720);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // frmIOBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(1383, 820);
            ControlBox = false;
            Controls.Add(uiPanel1);
            Controls.Add(btnColse);
            Font = new Font("宋体", 11F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmIOBox";
            Padding = new Padding(0, 30, 0, 0);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "I/O";
            TitleHeight = 30;
            ZoomScaleRect = new Rectangle(15, 15, 1323, 730);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton btnColse;
        private Sunny.UI.UIPanel uiPanel1;
    }
}