namespace MainUI.TRDP
{
    partial class frmETHImpExcel
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
            uceth1 = new ucETH();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox1.Location = new System.Drawing.Point(0, 969);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4);
            groupBox1.Size = new System.Drawing.Size(1607, 63);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.FillColor = System.Drawing.Color.IndianRed;
            btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(743, 20);
            btnClose.Margin = new System.Windows.Forms.Padding(4);
            btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = System.Drawing.Color.IndianRed;
            btnClose.Size = new System.Drawing.Size(138, 35);
            btnClose.TabIndex = 0;
            btnClose.Text = "关 闭";
            btnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Click += btnClose_Click;
            // 
            // uceth1
            // 
            uceth1.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            uceth1.ExcelPath = null;
            uceth1.holdItemId = null;
            uceth1.holdTaskId = null;
            uceth1.Location = new System.Drawing.Point(4, 35);
            uceth1.Margin = new System.Windows.Forms.Padding(4);
            uceth1.ModelID = 0;
            uceth1.Name = "uceth1";
            uceth1.Size = new System.Drawing.Size(1595, 939);
            uceth1.TabIndex = 2;
            // 
            // frmETHImpExcel
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1607, 1032);
            ControlBox = false;
            Controls.Add(uceth1);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmETHImpExcel";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            Text = "导入导出功能";
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1474, 921);
            Load += frmETHImpExcel_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIButton btnClose;
        private ucETH uceth1;
    }
}