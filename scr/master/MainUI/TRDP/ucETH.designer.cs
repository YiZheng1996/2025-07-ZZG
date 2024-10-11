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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new System.Windows.Forms.Label();
            txtPath = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            lblImpTips = new System.Windows.Forms.Label();
            btnExcelImport = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnExportEexcel = new System.Windows.Forms.Button();
            cboModelName = new System.Windows.Forms.ComboBox();
            label30 = new System.Windows.Forms.Label();
            grpData = new System.Windows.Forms.GroupBox();
            dataGridView1 = new Sunny.UI.UIDataGridView();
            colmodelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSignalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPortNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colByteExcursion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBitExcursion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColBigOrLimmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIsLifeSignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColTrdpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColETHPassage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colVerno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDefaultVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIsRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 11F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(12, 198);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 15);
            label1.TabIndex = 10;
            label1.Text = "文件路径：";
            // 
            // txtPath
            // 
            txtPath.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtPath.Font = new System.Drawing.Font("宋体", 11F);
            txtPath.Location = new System.Drawing.Point(106, 194);
            txtPath.Margin = new System.Windows.Forms.Padding(4);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new System.Drawing.Size(1291, 24);
            txtPath.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("宋体", 10F);
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(312, 74);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(406, 14);
            label2.TabIndex = 16;
            label2.Text = "导入步骤：先选择型号。点击数据导入按钮，选择正确Excel文件";
            label2.Visible = false;
            // 
            // lblImpTips
            // 
            lblImpTips.AutoSize = true;
            lblImpTips.ForeColor = System.Drawing.Color.Red;
            lblImpTips.Location = new System.Drawing.Point(237, 142);
            lblImpTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblImpTips.Name = "lblImpTips";
            lblImpTips.Size = new System.Drawing.Size(56, 17);
            lblImpTips.TabIndex = 17;
            lblImpTips.Text = "导入提示";
            // 
            // btnExcelImport
            // 
            btnExcelImport.BackColor = System.Drawing.Color.CornflowerBlue;
            btnExcelImport.FlatAppearance.BorderSize = 0;
            btnExcelImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExcelImport.Font = new System.Drawing.Font("宋体", 12F);
            btnExcelImport.ForeColor = System.Drawing.Color.White;
            btnExcelImport.Location = new System.Drawing.Point(106, 119);
            btnExcelImport.Margin = new System.Windows.Forms.Padding(4);
            btnExcelImport.Name = "btnExcelImport";
            btnExcelImport.Size = new System.Drawing.Size(124, 57);
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
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4);
            groupBox1.Size = new System.Drawing.Size(1455, 265);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // btnExportEexcel
            // 
            btnExportEexcel.BackColor = System.Drawing.Color.CornflowerBlue;
            btnExportEexcel.FlatAppearance.BorderSize = 0;
            btnExportEexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportEexcel.Font = new System.Drawing.Font("宋体", 12F);
            btnExportEexcel.ForeColor = System.Drawing.Color.White;
            btnExportEexcel.Location = new System.Drawing.Point(734, 119);
            btnExportEexcel.Margin = new System.Windows.Forms.Padding(4);
            btnExportEexcel.Name = "btnExportEexcel";
            btnExportEexcel.Size = new System.Drawing.Size(124, 57);
            btnExportEexcel.TabIndex = 22;
            btnExportEexcel.Text = "导出到Excel";
            btnExportEexcel.UseVisualStyleBackColor = false;
            btnExportEexcel.Click += btnExportEexcel_Click;
            // 
            // cboModelName
            // 
            cboModelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboModelName.Enabled = false;
            cboModelName.Font = new System.Drawing.Font("宋体", 11F);
            cboModelName.FormattingEnabled = true;
            cboModelName.Location = new System.Drawing.Point(106, 67);
            cboModelName.Margin = new System.Windows.Forms.Padding(4);
            cboModelName.Name = "cboModelName";
            cboModelName.Size = new System.Drawing.Size(164, 23);
            cboModelName.TabIndex = 21;
            cboModelName.SelectedIndexChanged += cboModelName_SelectedIndexChanged;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new System.Drawing.Font("宋体", 10F);
            label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label30.Location = new System.Drawing.Point(59, 74);
            label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(35, 14);
            label30.TabIndex = 20;
            label30.Text = "型号";
            // 
            // grpData
            // 
            grpData.Controls.Add(dataGridView1);
            grpData.Dock = System.Windows.Forms.DockStyle.Fill;
            grpData.Location = new System.Drawing.Point(0, 265);
            grpData.Margin = new System.Windows.Forms.Padding(4);
            grpData.Name = "grpData";
            grpData.Padding = new System.Windows.Forms.Padding(4);
            grpData.Size = new System.Drawing.Size(1455, 858);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(243, 249, 255);
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colmodelName, colSignalName, colDataType, colUnit, colPortNo, colByteExcursion, colBitExcursion, colBitValue, ColBigOrLimmit, colIsLifeSignal, ColTrdpNo, ColETHPassage, colVerno, colDefaultVersion, colIsRead, colRemark });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridView1.GridColor = System.Drawing.Color.Black;
            dataGridView1.Location = new System.Drawing.Point(4, 20);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F);
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(1447, 834);
            dataGridView1.StripeEvenColor = System.Drawing.Color.Empty;
            dataGridView1.StripeOddColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            // ColETHPassage
            // 
            ColETHPassage.DataPropertyName = "ETHPassage";
            ColETHPassage.HeaderText = "ETH通道";
            ColETHPassage.Name = "ColETHPassage";
            ColETHPassage.Visible = false;
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
            // colRemark
            // 
            colRemark.DataPropertyName = "Description";
            colRemark.HeaderText = "备注";
            colRemark.Name = "colRemark";
            // 
            // ucETH
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            Controls.Add(grpData);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ucETH";
            Size = new System.Drawing.Size(1455, 1123);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colmodelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPortNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colByteExcursion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBitExcursion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBigOrLimmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsLifeSignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrdpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColETHPassage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefaultVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
    }
}
