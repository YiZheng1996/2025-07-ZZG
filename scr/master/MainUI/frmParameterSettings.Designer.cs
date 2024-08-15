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
            btnSystem = new Sunny.UI.UIButton();
            btnCommunicateMVB = new Sunny.UI.UIButton();
            btnCommunicateTRDP = new Sunny.UI.UIButton();
            btnCommunicateCAN = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // btnSystem
            // 
            btnSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSystem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSystem.Location = new System.Drawing.Point(108, 71);
            btnSystem.MinimumSize = new System.Drawing.Size(1, 1);
            btnSystem.Name = "btnSystem";
            btnSystem.Size = new System.Drawing.Size(147, 38);
            btnSystem.TabIndex = 0;
            btnSystem.Text = "系统参数设置";
            btnSystem.Click += btnSystem_Click;
            // 
            // btnCommunicateMVB
            // 
            btnCommunicateMVB.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCommunicateMVB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCommunicateMVB.Location = new System.Drawing.Point(108, 135);
            btnCommunicateMVB.MinimumSize = new System.Drawing.Size(1, 1);
            btnCommunicateMVB.Name = "btnCommunicateMVB";
            btnCommunicateMVB.Size = new System.Drawing.Size(147, 38);
            btnCommunicateMVB.TabIndex = 1;
            btnCommunicateMVB.Text = "MVB参数设置";
            btnCommunicateMVB.Click += btnCommunicateMVB_Click;
            // 
            // btnCommunicateTRDP
            // 
            btnCommunicateTRDP.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCommunicateTRDP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCommunicateTRDP.Location = new System.Drawing.Point(108, 206);
            btnCommunicateTRDP.MinimumSize = new System.Drawing.Size(1, 1);
            btnCommunicateTRDP.Name = "btnCommunicateTRDP";
            btnCommunicateTRDP.Size = new System.Drawing.Size(147, 38);
            btnCommunicateTRDP.TabIndex = 2;
            btnCommunicateTRDP.Text = "TRDP参数设置";
            btnCommunicateTRDP.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCommunicateTRDP.Click += btnCommunicateTRDP_Click;
            // 
            // btnCommunicateCAN
            // 
            btnCommunicateCAN.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCommunicateCAN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCommunicateCAN.Location = new System.Drawing.Point(108, 277);
            btnCommunicateCAN.MinimumSize = new System.Drawing.Size(1, 1);
            btnCommunicateCAN.Name = "btnCommunicateCAN";
            btnCommunicateCAN.Size = new System.Drawing.Size(147, 38);
            btnCommunicateCAN.TabIndex = 3;
            btnCommunicateCAN.Text = "CAN参数设置";
            btnCommunicateCAN.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCommunicateCAN.Click += btnCommunicateCAN_Click;
            // 
            // frmParameterSettings
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(376, 351);
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
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "参数设置";
            TextAlignment = System.Drawing.StringAlignment.Center;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 480);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton btnSystem;
        private Sunny.UI.UIButton btnCommunicateMVB;
        private Sunny.UI.UIButton btnCommunicateTRDP;
        private Sunny.UI.UIButton btnCommunicateCAN;
    }
}