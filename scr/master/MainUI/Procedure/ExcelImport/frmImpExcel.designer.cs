namespace MainUI.Procedure.ExcelImport
{
    partial class frmImpExcel
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnClose = new Sunny.UI.UIButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox1.Location = new System.Drawing.Point(0, 917);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4);
            groupBox1.Size = new System.Drawing.Size(1469, 64);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(684, 17);
            btnClose.Margin = new System.Windows.Forms.Padding(4);
            btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(138, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "关闭";
            btnClose.Click += btnClose_Click;
            // 
            // frmImpExcel
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            ClientSize = new System.Drawing.Size(1469, 981);
            ControlBox = false;
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmImpExcel";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "导入导出功能";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIButton btnClose;
      
    }
}