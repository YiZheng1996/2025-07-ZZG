namespace MainUI.Procedure.ExcelImport
{
    partial class frmSchemeManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtSchemeDesc = new UITextBox();
            btnClose = new Button();
            chkIsDefault = new UICheckBox();
            btnSaveDesc = new Button();
            label3 = new Label();
            btnSetDefault = new Button();
            btnDeleteScheme = new Button();
            btnAddScheme = new Button();
            cboScheme = new UIComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCopyFromModel = new Button();
            btnExportExcel = new Button();
            btnExcelImport = new Button();
            lblImpTips = new Label();
            label2 = new Label();
            txtPath = new UITextBox();
            grpData = new GroupBox();
            dataGridView1 = new UIDataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSchemeDesc);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(chkIsDefault);
            groupBox1.Controls.Add(btnSaveDesc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSetDefault);
            groupBox1.Controls.Add(btnDeleteScheme);
            groupBox1.Controls.Add(btnAddScheme);
            groupBox1.Controls.Add(cboScheme);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(0, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1183, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "配方管理";
            // 
            // txtSchemeDesc
            // 
            txtSchemeDesc.FillColor2 = Color.White;
            txtSchemeDesc.FillDisableColor = Color.White;
            txtSchemeDesc.FillReadOnlyColor = Color.White;
            txtSchemeDesc.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtSchemeDesc.Location = new Point(120, 89);
            txtSchemeDesc.Margin = new Padding(4, 5, 4, 5);
            txtSchemeDesc.MinimumSize = new Size(1, 16);
            txtSchemeDesc.Name = "txtSchemeDesc";
            txtSchemeDesc.Padding = new Padding(5);
            txtSchemeDesc.ReadOnly = true;
            txtSchemeDesc.RectDisableColor = Color.FromArgb(80, 160, 255);
            txtSchemeDesc.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtSchemeDesc.ShowText = false;
            txtSchemeDesc.Size = new Size(740, 29);
            txtSchemeDesc.TabIndex = 9;
            txtSchemeDesc.TextAlignment = ContentAlignment.MiddleLeft;
            txtSchemeDesc.Watermark = "";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Gray;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("微软雅黑", 12F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1045, 48);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 65);
            btnClose.TabIndex = 3;
            btnClose.Text = "关  闭";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // chkIsDefault
            // 
            chkIsDefault.CheckBoxSize = 18;
            chkIsDefault.Enabled = false;
            chkIsDefault.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            chkIsDefault.ForeColor = Color.FromArgb(48, 48, 48);
            chkIsDefault.Location = new Point(758, 39);
            chkIsDefault.MinimumSize = new Size(1, 1);
            chkIsDefault.Name = "chkIsDefault";
            chkIsDefault.Size = new Size(92, 20);
            chkIsDefault.TabIndex = 8;
            chkIsDefault.Text = "默认配方";
            // 
            // btnSaveDesc
            // 
            btnSaveDesc.BackColor = Color.CornflowerBlue;
            btnSaveDesc.FlatAppearance.BorderSize = 0;
            btnSaveDesc.FlatStyle = FlatStyle.Flat;
            btnSaveDesc.ForeColor = Color.White;
            btnSaveDesc.Location = new Point(916, 48);
            btnSaveDesc.Name = "btnSaveDesc";
            btnSaveDesc.Size = new Size(106, 65);
            btnSaveDesc.TabIndex = 7;
            btnSaveDesc.Text = "保存描述";
            btnSaveDesc.UseVisualStyleBackColor = false;
            btnSaveDesc.Click += btnSaveDesc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 92);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 5;
            label3.Text = "配方描述：";
            // 
            // btnSetDefault
            // 
            btnSetDefault.BackColor = Color.Orange;
            btnSetDefault.FlatAppearance.BorderSize = 0;
            btnSetDefault.FlatStyle = FlatStyle.Flat;
            btnSetDefault.ForeColor = Color.White;
            btnSetDefault.Location = new Point(631, 24);
            btnSetDefault.Name = "btnSetDefault";
            btnSetDefault.Size = new Size(100, 50);
            btnSetDefault.TabIndex = 4;
            btnSetDefault.Text = "设为默认";
            btnSetDefault.UseVisualStyleBackColor = false;
            btnSetDefault.Click += btnSetDefault_Click;
            // 
            // btnDeleteScheme
            // 
            btnDeleteScheme.BackColor = Color.IndianRed;
            btnDeleteScheme.FlatAppearance.BorderSize = 0;
            btnDeleteScheme.FlatStyle = FlatStyle.Flat;
            btnDeleteScheme.ForeColor = Color.White;
            btnDeleteScheme.Location = new Point(506, 24);
            btnDeleteScheme.Name = "btnDeleteScheme";
            btnDeleteScheme.Size = new Size(100, 50);
            btnDeleteScheme.TabIndex = 3;
            btnDeleteScheme.Text = "删除配方";
            btnDeleteScheme.UseVisualStyleBackColor = false;
            btnDeleteScheme.Click += btnDeleteScheme_Click;
            // 
            // btnAddScheme
            // 
            btnAddScheme.BackColor = Color.SeaGreen;
            btnAddScheme.FlatAppearance.BorderSize = 0;
            btnAddScheme.FlatStyle = FlatStyle.Flat;
            btnAddScheme.ForeColor = Color.White;
            btnAddScheme.Location = new Point(381, 24);
            btnAddScheme.Name = "btnAddScheme";
            btnAddScheme.Size = new Size(100, 50);
            btnAddScheme.TabIndex = 2;
            btnAddScheme.Text = "新增配方";
            btnAddScheme.UseVisualStyleBackColor = false;
            btnAddScheme.Click += btnAddScheme_Click;
            // 
            // cboScheme
            // 
            cboScheme.DataSource = null;
            cboScheme.DropDownStyle = UIDropDownStyle.DropDownList;
            cboScheme.FillColor = Color.White;
            cboScheme.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboScheme.FormattingEnabled = true;
            cboScheme.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboScheme.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboScheme.Location = new Point(120, 30);
            cboScheme.Margin = new Padding(4, 5, 4, 5);
            cboScheme.MinimumSize = new Size(63, 0);
            cboScheme.Name = "cboScheme";
            cboScheme.Padding = new Padding(0, 0, 30, 2);
            cboScheme.Size = new Size(230, 29);
            cboScheme.SymbolSize = 24;
            cboScheme.TabIndex = 1;
            cboScheme.TextAlignment = ContentAlignment.MiddleLeft;
            cboScheme.Watermark = "";
            cboScheme.SelectedIndexChanged += cboScheme_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "选择配方：";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCopyFromModel);
            groupBox2.Controls.Add(btnExportExcel);
            groupBox2.Controls.Add(btnExcelImport);
            groupBox2.Controls.Add(lblImpTips);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtPath);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("微软雅黑", 12F);
            groupBox2.Location = new Point(0, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1183, 118);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "数据导入导出";
            // 
            // btnCopyFromModel
            // 
            btnCopyFromModel.BackColor = Color.DarkCyan;
            btnCopyFromModel.FlatAppearance.BorderSize = 0;
            btnCopyFromModel.FlatStyle = FlatStyle.Flat;
            btnCopyFromModel.ForeColor = Color.White;
            btnCopyFromModel.Location = new Point(370, 34);
            btnCopyFromModel.Name = "btnCopyFromModel";
            btnCopyFromModel.Size = new Size(100, 50);
            btnCopyFromModel.TabIndex = 5;
            btnCopyFromModel.Text = "从型号复制";
            btnCopyFromModel.UseVisualStyleBackColor = false;
            btnCopyFromModel.Click += btnCopyFromModel_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.CornflowerBlue;
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(250, 34);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(100, 50);
            btnExportExcel.TabIndex = 4;
            btnExportExcel.Text = "导出Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExcelImport
            // 
            btnExcelImport.BackColor = Color.SeaGreen;
            btnExcelImport.FlatAppearance.BorderSize = 0;
            btnExcelImport.FlatStyle = FlatStyle.Flat;
            btnExcelImport.ForeColor = Color.White;
            btnExcelImport.Location = new Point(130, 34);
            btnExcelImport.Name = "btnExcelImport";
            btnExcelImport.Size = new Size(100, 50);
            btnExcelImport.TabIndex = 3;
            btnExcelImport.Text = "导入Excel";
            btnExcelImport.UseVisualStyleBackColor = false;
            btnExcelImport.Click += btnExcelImport_Click;
            // 
            // lblImpTips
            // 
            lblImpTips.AutoSize = true;
            lblImpTips.ForeColor = Color.Green;
            lblImpTips.Location = new Point(30, 44);
            lblImpTips.Name = "lblImpTips";
            lblImpTips.Size = new Size(74, 21);
            lblImpTips.TabIndex = 2;
            lblImpTips.Text = "选择数据";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 49);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 1;
            label2.Text = "文件路径";
            // 
            // txtPath
            // 
            txtPath.FillColor2 = Color.White;
            txtPath.FillDisableColor = Color.White;
            txtPath.FillReadOnlyColor = Color.White;
            txtPath.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtPath.Location = new Point(581, 46);
            txtPath.Margin = new Padding(4, 5, 4, 5);
            txtPath.MinimumSize = new Size(1, 16);
            txtPath.Name = "txtPath";
            txtPath.Padding = new Padding(5);
            txtPath.ReadOnly = true;
            txtPath.RectDisableColor = Color.FromArgb(80, 160, 255);
            txtPath.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtPath.ShowText = false;
            txtPath.Size = new Size(584, 29);
            txtPath.TabIndex = 0;
            txtPath.TextAlignment = ContentAlignment.MiddleLeft;
            txtPath.Watermark = "";
            // 
            // grpData
            // 
            grpData.Controls.Add(dataGridView1);
            grpData.Dock = DockStyle.Fill;
            grpData.Font = new Font("微软雅黑", 12F);
            grpData.Location = new Point(0, 297);
            grpData.Name = "grpData";
            grpData.Size = new Size(1183, 603);
            grpData.TabIndex = 2;
            grpData.TabStop = false;
            grpData.Text = "配置明细";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(243, 249, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridView1.GridColor = Color.FromArgb(104, 173, 255);
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1177, 575);
            dataGridView1.TabIndex = 0;
            // 
            // frmSchemeManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1183, 900);
            ControlBox = false;
            Controls.Add(grpData);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSchemeManage";
            ShowIcon = false;
            Text = "IO箱配方管理";
            TitleFont = new Font("微软雅黑", 14F, FontStyle.Bold);
            ZoomScaleRect = new Rectangle(15, 15, 1000, 600);
            Load += frmSchemeManage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIComboBox cboScheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetDefault;
        private System.Windows.Forms.Button btnDeleteScheme;
        private System.Windows.Forms.Button btnAddScheme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcelImport;
        private System.Windows.Forms.Label lblImpTips;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UITextBox txtPath;
        private System.Windows.Forms.GroupBox grpData;
        private Sunny.UI.UIDataGridView dataGridView1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveDesc;
        private Sunny.UI.UICheckBox chkIsDefault;
        private System.Windows.Forms.Button btnCopyFromModel;
        private System.Windows.Forms.Button btnClose;
        private UITextBox txtSchemeDesc;
    }
}