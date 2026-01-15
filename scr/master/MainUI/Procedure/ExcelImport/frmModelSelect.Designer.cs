namespace MainUI.Procedure.ExcelImport
{
    partial class frmModelSelect
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
            label1 = new Label();
            cboModel = new UIComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            lblConfigCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(35, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "选择型号：";
            // 
            // cboModel
            // 
            cboModel.DataSource = null;
            cboModel.DropDownStyle = UIDropDownStyle.DropDownList;
            cboModel.FillColor = Color.White;
            cboModel.Font = new Font("微软雅黑", 12F);
            cboModel.FormattingEnabled = true;
            cboModel.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboModel.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboModel.Location = new Point(138, 58);
            cboModel.Margin = new Padding(4);
            cboModel.MinimumSize = new Size(63, 0);
            cboModel.Name = "cboModel";
            cboModel.Padding = new Padding(0, 0, 30, 2);
            cboModel.Size = new Size(256, 30);
            cboModel.SymbolSize = 24;
            cboModel.TabIndex = 1;
            cboModel.TextAlignment = ContentAlignment.MiddleLeft;
            cboModel.Watermark = "";
            cboModel.SelectedIndexChanged += cboModel_SelectedIndexChanged;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.CornflowerBlue;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(99, 170);
            btnOK.Margin = new Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(117, 57);
            btnOK.TabIndex = 2;
            btnOK.Text = "确  定";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(245, 170);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 57);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "取  消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblConfigCount
            // 
            lblConfigCount.AutoSize = true;
            lblConfigCount.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            lblConfigCount.ForeColor = Color.Gray;
            lblConfigCount.Location = new Point(35, 120);
            lblConfigCount.Margin = new Padding(4, 0, 4, 0);
            lblConfigCount.Name = "lblConfigCount";
            lblConfigCount.Size = new Size(164, 22);
            lblConfigCount.TabIndex = 4;
            lblConfigCount.Text = "该型号配置点位数：0";
            // 
            // frmModelSelect
            // 
            AcceptButton = btnOK;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(443, 255);
            ControlBox = false;
            Controls.Add(lblConfigCount);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cboModel);
            Controls.Add(label1);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmModelSelect";
            ShowIcon = false;
            Text = "选择型号";
            TitleFont = new Font("微软雅黑", 14F, FontStyle.Bold);
            ZoomScaleRect = new Rectangle(15, 15, 443, 255);
            Load += frmModelSelect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox cboModel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblConfigCount;
    }
}