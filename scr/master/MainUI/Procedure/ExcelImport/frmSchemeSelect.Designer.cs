namespace MainUI.Procedure.ExcelImport
{
    partial class frmSchemeSelect
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
            cboScheme = new UIComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            btnManage = new Button();
            lblDesc = new Label();
            lblIsDefault = new Label();
            lblConfigCount = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F);
            label1.Location = new Point(25, 56);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "选择配方：";
            // 
            // cboScheme
            // 
            cboScheme.DataSource = null;
            cboScheme.DropDownStyle = UIDropDownStyle.DropDownList;
            cboScheme.FillColor = Color.White;
            cboScheme.Font = new Font("微软雅黑", 12F);
            cboScheme.FormattingEnabled = true;
            cboScheme.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboScheme.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboScheme.Location = new Point(113, 53);
            cboScheme.Margin = new Padding(4, 5, 4, 5);
            cboScheme.MinimumSize = new Size(63, 0);
            cboScheme.Name = "cboScheme";
            cboScheme.Padding = new Padding(0, 0, 30, 2);
            cboScheme.Size = new Size(220, 30);
            cboScheme.SymbolSize = 24;
            cboScheme.TabIndex = 1;
            cboScheme.TextAlignment = ContentAlignment.MiddleLeft;
            cboScheme.Watermark = "";
            cboScheme.SelectedIndexChanged += cboScheme_SelectedIndexChanged;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.CornflowerBlue;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(113, 214);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 40);
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
            btnCancel.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(238, 214);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "取  消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.SeaGreen;
            btnManage.FlatAppearance.BorderSize = 0;
            btnManage.FlatStyle = FlatStyle.Flat;
            btnManage.Font = new Font("微软雅黑", 12F);
            btnManage.ForeColor = Color.White;
            btnManage.Location = new Point(345, 50);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(91, 34);
            btnManage.TabIndex = 4;
            btnManage.Text = "配方管理";
            btnManage.UseVisualStyleBackColor = false;
            btnManage.Click += btnManage_Click;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblDesc.ForeColor = Color.Gray;
            lblDesc.Location = new Point(15, 25);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(0, 21);
            lblDesc.TabIndex = 5;
            // 
            // lblIsDefault
            // 
            lblIsDefault.AutoSize = true;
            lblIsDefault.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblIsDefault.ForeColor = Color.Green;
            lblIsDefault.Location = new Point(15, 50);
            lblIsDefault.Name = "lblIsDefault";
            lblIsDefault.Size = new Size(0, 21);
            lblIsDefault.TabIndex = 6;
            // 
            // lblConfigCount
            // 
            lblConfigCount.AutoSize = true;
            lblConfigCount.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblConfigCount.Location = new Point(15, 74);
            lblConfigCount.Name = "lblConfigCount";
            lblConfigCount.Size = new Size(115, 21);
            lblConfigCount.TabIndex = 7;
            lblConfigCount.Text = "配置点位数：0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDesc);
            groupBox1.Controls.Add(lblIsDefault);
            groupBox1.Controls.Add(lblConfigCount);
            groupBox1.Font = new Font("微软雅黑", 12F);
            groupBox1.Location = new Point(25, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 105);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "配方信息";
            // 
            // frmSchemeSelect
            // 
            AcceptButton = btnOK;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(460, 260);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(btnManage);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cboScheme);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSchemeSelect";
            ShowIcon = false;
            Text = "选择配方";
            TitleFont = new Font("微软雅黑", 14F, FontStyle.Bold);
            ZoomScaleRect = new Rectangle(15, 15, 460, 260);
            Load += frmSchemeSelect_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox cboScheme;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblIsDefault;
        private System.Windows.Forms.Label lblConfigCount;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}