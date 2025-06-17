namespace MainUI.CAN
{
    partial class frmExcelImport
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
            uiPanel1 = new Sunny.UI.UIPanel();
            uibtnExit = new Sunny.UI.UIButton();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uibtnExit);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiPanel1.Location = new System.Drawing.Point(0, 937);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(1466, 48);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uibtnExit
            // 
            uibtnExit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uibtnExit.Location = new System.Drawing.Point(662, 7);
            uibtnExit.MinimumSize = new System.Drawing.Size(1, 1);
            uibtnExit.Name = "uibtnExit";
            uibtnExit.Size = new System.Drawing.Size(180, 35);
            uibtnExit.TabIndex = 0;
            uibtnExit.Text = "退 出";
            uibtnExit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uibtnExit.Click += uibtnExit_Click;
            // 
            // frmExcelImport
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1466, 985);
            ControlBox = false;
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1920, 1440);
            MinimizeBox = false;
            Name = "frmExcelImport";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            ShowIcon = false;
            Text = "Excel数据导入";
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton uibtnExit;
    }
}