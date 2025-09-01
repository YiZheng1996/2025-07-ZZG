namespace MainUI.TRDP
{
    partial class ucETH
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            txtPath = new TextBox();
            label2 = new Label();
            lblImpTips = new Label();
            btnExcelImport = new Button();
            groupBox1 = new GroupBox();
            btnExportEexcel = new Button();
            cboModelName = new ComboBox();
            label30 = new Label();
            grpData = new GroupBox();
            dataGridView1 = new UIDataGridView();
            colmodelName = new DataGridViewTextBoxColumn();
            colSignalName = new DataGridViewTextBoxColumn();
            colDataType = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colPortNo = new DataGridViewTextBoxColumn();
            colByteExcursion = new DataGridViewTextBoxColumn();
            colBitExcursion = new DataGridViewTextBoxColumn();
            colGroupETHBit = new DataGridViewTextBoxColumn();
            colBitValue = new DataGridViewTextBoxColumn();
            ColBigOrLimmit = new DataGridViewTextBoxColumn();
            colIsLifeSignal = new DataGridViewTextBoxColumn();
            ColTrdpNo = new DataGridViewTextBoxColumn();
            colVerno = new DataGridViewTextBoxColumn();
            colDefaultVersion = new DataGridViewTextBoxColumn();
            colIsRead = new DataGridViewTextBoxColumn();
            colIsCRC = new DataGridViewTextBoxColumn();
            colRemark = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 11F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 198);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 10;
            label1.Text = "文件路径：";
            // 
            // txtPath
            // 
            txtPath.BackColor = Color.FromArgb(243, 249, 255);
            txtPath.Font = new Font("宋体", 11F);
            txtPath.Location = new Point(106, 194);
            txtPath.Margin = new Padding(4);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(1291, 24);
            txtPath.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 10F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(312, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(406, 14);
            label2.TabIndex = 16;
            label2.Text = "导入步骤：先选择型号。点击数据导入按钮，选择正确Excel文件";
            label2.Visible = false;
            // 
            // lblImpTips
            // 
            lblImpTips.AutoSize = true;
            lblImpTips.ForeColor = Color.Red;
            lblImpTips.Location = new Point(237, 142);
            lblImpTips.Margin = new Padding(4, 0, 4, 0);
            lblImpTips.Name = "lblImpTips";
            lblImpTips.Size = new Size(56, 17);
            lblImpTips.TabIndex = 17;
            lblImpTips.Text = "导入提示";
            // 
            // btnExcelImport
            // 
            btnExcelImport.BackColor = Color.CornflowerBlue;
            btnExcelImport.FlatAppearance.BorderSize = 0;
            btnExcelImport.FlatStyle = FlatStyle.Flat;
            btnExcelImport.Font = new Font("宋体", 12F);
            btnExcelImport.ForeColor = Color.White;
            btnExcelImport.Location = new Point(106, 119);
            btnExcelImport.Margin = new Padding(4);
            btnExcelImport.Name = "btnExcelImport";
            btnExcelImport.Size = new Size(124, 57);
            btnExcelImport.TabIndex = 19;
            btnExcelImport.Text = "数据导入";
            btnExcelImport.UseVisualStyleBackColor = false;
            btnExcelImport.Click += btnExcelImport_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExportEexcel);
            groupBox1.Controls.Add(cboModelName);
            groupBox1.Controls.Add(label30);
            groupBox1.Controls.Add(btnExcelImport);
            groupBox1.Controls.Add(lblImpTips);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPath);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1455, 265);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnExportEexcel
            // 
            btnExportEexcel.BackColor = Color.CornflowerBlue;
            btnExportEexcel.FlatAppearance.BorderSize = 0;
            btnExportEexcel.FlatStyle = FlatStyle.Flat;
            btnExportEexcel.Font = new Font("宋体", 12F);
            btnExportEexcel.ForeColor = Color.White;
            btnExportEexcel.Location = new Point(734, 119);
            btnExportEexcel.Margin = new Padding(4);
            btnExportEexcel.Name = "btnExportEexcel";
            btnExportEexcel.Size = new Size(124, 57);
            btnExportEexcel.TabIndex = 22;
            btnExportEexcel.Text = "导出到Excel";
            btnExportEexcel.UseVisualStyleBackColor = false;
            btnExportEexcel.Click += btnExportEexcel_Click;
            // 
            // cboModelName
            // 
            cboModelName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModelName.Enabled = false;
            cboModelName.Font = new Font("宋体", 11F);
            cboModelName.FormattingEnabled = true;
            cboModelName.Location = new Point(106, 67);
            cboModelName.Margin = new Padding(4);
            cboModelName.Name = "cboModelName";
            cboModelName.Size = new Size(164, 23);
            cboModelName.TabIndex = 21;
            cboModelName.SelectedIndexChanged += cboModelName_SelectedIndexChanged;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("宋体", 10F);
            label30.ImeMode = ImeMode.NoControl;
            label30.Location = new Point(59, 74);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(35, 14);
            label30.TabIndex = 20;
            label30.Text = "型号";
            // 
            // grpData
            // 
            grpData.Controls.Add(dataGridView1);
            grpData.Dock = DockStyle.Fill;
            grpData.Location = new Point(0, 265);
            grpData.Margin = new Padding(4);
            grpData.Name = "grpData";
            grpData.Padding = new Padding(4);
            grpData.Size = new Size(1455, 858);
            grpData.TabIndex = 21;
            grpData.TabStop = false;
            grpData.Text = "航插定义记录";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new Font("宋体", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colmodelName, colSignalName, colDataType, colUnit, colPortNo, colByteExcursion, colBitExcursion, colGroupETHBit, colBitValue, ColBigOrLimmit, colIsLifeSignal, ColTrdpNo, colVerno, colDefaultVersion, colIsRead, colIsCRC, colRemark, Column1 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("宋体", 12F);
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(4, 20);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("宋体", 12F);
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1447, 834);
            dataGridView1.StripeEvenColor = Color.Empty;
            dataGridView1.StripeOddColor = SystemColors.GradientActiveCaption;
            dataGridView1.TabIndex = 0;
            // 
            // colmodelName
            // 
            colmodelName.DataPropertyName = "TypeName";
            colmodelName.HeaderText = "车型";
            colmodelName.Name = "colmodelName";
            colmodelName.ReadOnly = true;
            // 
            // colSignalName
            // 
            colSignalName.DataPropertyName = "DataLabel";
            colSignalName.HeaderText = "信号名称";
            colSignalName.Name = "colSignalName";
            colSignalName.ReadOnly = true;
            // 
            // colDataType
            // 
            colDataType.DataPropertyName = "DataType";
            colDataType.HeaderText = "数据类型";
            colDataType.Name = "colDataType";
            colDataType.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.DataPropertyName = "DataUnit";
            colUnit.HeaderText = "单位";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colPortNo
            // 
            colPortNo.DataPropertyName = "Port";
            colPortNo.HeaderText = "ComID";
            colPortNo.Name = "colPortNo";
            colPortNo.ReadOnly = true;
            // 
            // colByteExcursion
            // 
            colByteExcursion.DataPropertyName = "Offset";
            colByteExcursion.HeaderText = "字节偏移";
            colByteExcursion.Name = "colByteExcursion";
            colByteExcursion.ReadOnly = true;
            // 
            // colBitExcursion
            // 
            colBitExcursion.DataPropertyName = "ETHBit";
            colBitExcursion.HeaderText = "位偏移";
            colBitExcursion.Name = "colBitExcursion";
            colBitExcursion.ReadOnly = true;
            // 
            // colGroupETHBit
            // 
            colGroupETHBit.DataPropertyName = "GroupETHBit";
            colGroupETHBit.HeaderText = "组合位偏移";
            colGroupETHBit.Name = "colGroupETHBit";
            colGroupETHBit.Visible = false;
            // 
            // colBitValue
            // 
            colBitValue.DataPropertyName = "BitValue";
            colBitValue.HeaderText = "倍率值";
            colBitValue.Name = "colBitValue";
            colBitValue.ReadOnly = true;
            // 
            // ColBigOrLimmit
            // 
            ColBigOrLimmit.DataPropertyName = "PortPattern";
            ColBigOrLimmit.HeaderText = "大小端模式";
            ColBigOrLimmit.Name = "ColBigOrLimmit";
            ColBigOrLimmit.ReadOnly = true;
            // 
            // colIsLifeSignal
            // 
            colIsLifeSignal.DataPropertyName = "Identity";
            colIsLifeSignal.HeaderText = "是否生命信号";
            colIsLifeSignal.Name = "colIsLifeSignal";
            // 
            // ColTrdpNo
            // 
            ColTrdpNo.DataPropertyName = "TRDPNo";
            ColTrdpNo.HeaderText = "网关编号";
            ColTrdpNo.Name = "ColTrdpNo";
            // 
            // colVerno
            // 
            colVerno.DataPropertyName = "VerNo";
            colVerno.HeaderText = "协议版本";
            colVerno.Name = "colVerno";
            // 
            // colDefaultVersion
            // 
            colDefaultVersion.DataPropertyName = "DefaultVersion";
            colDefaultVersion.HeaderText = "是否默认版本";
            colDefaultVersion.Name = "colDefaultVersion";
            // 
            // colIsRead
            // 
            colIsRead.DataPropertyName = "IsRead";
            colIsRead.HeaderText = "源宿类型";
            colIsRead.Name = "colIsRead";
            // 
            // colIsCRC
            // 
            colIsCRC.DataPropertyName = "IsCRC";
            colIsCRC.HeaderText = "是否CRC校验";
            colIsCRC.Name = "colIsCRC";
            // 
            // colRemark
            // 
            colRemark.DataPropertyName = "Description";
            colRemark.HeaderText = "备注";
            colRemark.Name = "colRemark";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ETHPassage";
            Column1.HeaderText = "通道";
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // ucETH
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(243, 249, 255);
            Controls.Add(grpData);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "ucETH";
            Size = new Size(1455, 1123);
            Load += ucLine_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImpTips;
        private System.Windows.Forms.Button btnExcelImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnExportEexcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colETHPassage;
        public System.Windows.Forms.ComboBox cboModelName;
        private Sunny.UI.UIDataGridView dataGridView1;
        private DataGridViewTextBoxColumn colmodelName;
        private DataGridViewTextBoxColumn colSignalName;
        private DataGridViewTextBoxColumn colDataType;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colPortNo;
        private DataGridViewTextBoxColumn colByteExcursion;
        private DataGridViewTextBoxColumn colBitExcursion;
        private DataGridViewTextBoxColumn colGroupETHBit;
        private DataGridViewTextBoxColumn colBitValue;
        private DataGridViewTextBoxColumn ColBigOrLimmit;
        private DataGridViewTextBoxColumn colIsLifeSignal;
        private DataGridViewTextBoxColumn ColTrdpNo;
        private DataGridViewTextBoxColumn colVerno;
        private DataGridViewTextBoxColumn colDefaultVersion;
        private DataGridViewTextBoxColumn colIsRead;
        private DataGridViewTextBoxColumn colIsCRC;
        private DataGridViewTextBoxColumn colRemark;
        private DataGridViewTextBoxColumn Column1;
    }
}
