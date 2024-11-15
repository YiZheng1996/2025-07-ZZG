namespace MainUI
{
    partial class frmParameterSettings
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
            btnSystem = new UIButton();
            btnCommunicateMVB = new UIButton();
            btnCommunicateTRDP = new UIButton();
            btnCommunicateCAN = new UIButton();
            SuspendLayout();
            // 
            // btnSystem
            // 
            btnSystem.Cursor = Cursors.Hand;
            btnSystem.Font = new Font("宋体", 12F);
            btnSystem.Location = new Point(108, 71);
            btnSystem.MinimumSize = new Size(1, 1);
            btnSystem.Name = "btnSystem";
            btnSystem.Size = new Size(147, 38);
            btnSystem.TabIndex = 0;
            btnSystem.Text = "系统参数设置";
            btnSystem.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSystem.Click += btnSystem_Click;
            // 
            // btnCommunicateMVB
            // 
            btnCommunicateMVB.Cursor = Cursors.Hand;
            btnCommunicateMVB.Font = new Font("宋体", 12F);
            btnCommunicateMVB.Location = new Point(108, 207);
            btnCommunicateMVB.MinimumSize = new Size(1, 1);
            btnCommunicateMVB.Name = "btnCommunicateMVB";
            btnCommunicateMVB.Size = new Size(147, 38);
            btnCommunicateMVB.TabIndex = 1;
            btnCommunicateMVB.Text = "MVB参数设置";
            btnCommunicateMVB.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnCommunicateMVB.Click += btnCommunicateMVB_Click;
            // 
            // btnCommunicateTRDP
            // 
            btnCommunicateTRDP.Cursor = Cursors.Hand;
            btnCommunicateTRDP.Font = new Font("宋体", 12F);
            btnCommunicateTRDP.Location = new Point(108, 139);
            btnCommunicateTRDP.MinimumSize = new Size(1, 1);
            btnCommunicateTRDP.Name = "btnCommunicateTRDP";
            btnCommunicateTRDP.Size = new Size(147, 38);
            btnCommunicateTRDP.TabIndex = 2;
            btnCommunicateTRDP.Text = "TRDP参数设置";
            btnCommunicateTRDP.Click += btnCommunicateTRDP_Click;
            // 
            // btnCommunicateCAN
            // 
            btnCommunicateCAN.Cursor = Cursors.Hand;
            btnCommunicateCAN.Font = new Font("宋体", 12F);
            btnCommunicateCAN.Location = new Point(108, 275);
            btnCommunicateCAN.MinimumSize = new Size(1, 1);
            btnCommunicateCAN.Name = "btnCommunicateCAN";
            btnCommunicateCAN.Size = new Size(147, 38);
            btnCommunicateCAN.TabIndex = 3;
            btnCommunicateCAN.Text = "CAN参数设置";
            btnCommunicateCAN.Click += btnCommunicateCAN_Click;
            // 
            // frmParameterSettings
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(376, 351);
            Controls.Add(btnCommunicateCAN);
            Controls.Add(btnCommunicateTRDP);
            Controls.Add(btnCommunicateMVB);
            Controls.Add(btnSystem);
            EscClose = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmParameterSettings";
            ShowIcon = false;
            ShowInTaskbar = false;
            ShowRect = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "参数设置";
            TextAlignment = StringAlignment.Center;
            ZoomScaleRect = new Rectangle(15, 15, 800, 480);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton btnSystem;
        private Sunny.UI.UIButton btnCommunicateMVB;
        private Sunny.UI.UIButton btnCommunicateTRDP;
        private Sunny.UI.UIButton btnCommunicateCAN;
    }
}