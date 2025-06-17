namespace MainUI.CAN
{
    partial class ucExcelImport
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
            colmodelNameID = new DataGridViewTextBoxColumn();
            colID = new DataGridViewTextBoxColumn();
            colDataLabel = new DataGridViewTextBoxColumn();
            colDataType = new DataGridViewTextBoxColumn();
            colDataUnit = new DataGridViewTextBoxColumn();
            colCANID = new DataGridViewTextBoxColumn();
            colCANOffset = new DataGridViewTextBoxColumn();
            colCANBit = new DataGridViewTextBoxColumn();
            colBitValue = new DataGridViewTextBoxColumn();
            ColPortPattern = new DataGridViewTextBoxColumn();
            colIdentity = new DataGridViewTextBoxColumn();
            colIsRead = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(7, 166);
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
            txtPath.Location = new Point(101, 162);
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
            label2.Location = new Point(307, 42);
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
            lblImpTips.Location = new Point(232, 110);
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
            btnExcelImport.Location = new Point(101, 87);
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
            groupBox1.Size = new Size(1455, 214);
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
            btnExportEexcel.Location = new Point(729, 87);
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
            cboModelName.Location = new Point(101, 35);
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
            label30.Location = new Point(54, 42);
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
            grpData.Location = new Point(0, 214);
            grpData.Margin = new Padding(4);
            grpData.Name = "grpData";
            grpData.Padding = new Padding(4);
            grpData.Size = new Size(1455, 686);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colmodelNameID, colID, colDataLabel, colDataType, colDataUnit, colCANID, colCANOffset, colCANBit, colBitValue, ColPortPattern, colIdentity, colIsRead, colDescription });
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
            dataGridView1.ReadOnly = true;
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
            dataGridView1.Size = new Size(1447, 662);
            dataGridView1.StripeEvenColor = Color.Empty;
            dataGridView1.StripeOddColor = SystemColors.GradientActiveCaption;
            dataGridView1.TabIndex = 0;
            // 
            // colmodelNameID
            // 
            colmodelNameID.DataPropertyName = "ModelNameID";
            colmodelNameID.HeaderText = "车型";
            colmodelNameID.Name = "colmodelNameID";
            colmodelNameID.ReadOnly = true;
            colmodelNameID.Visible = false;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 50F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colDataLabel
            // 
            colDataLabel.DataPropertyName = "DataLabel";
            colDataLabel.FillWeight = 150.402863F;
            colDataLabel.HeaderText = "信号名称";
            colDataLabel.Name = "colDataLabel";
            colDataLabel.ReadOnly = true;
            // 
            // colDataType
            // 
            colDataType.DataPropertyName = "DataType";
            colDataType.FillWeight = 81.40286F;
            colDataType.HeaderText = "数据类型";
            colDataType.Name = "colDataType";
            colDataType.ReadOnly = true;
            // 
            // colDataUnit
            // 
            colDataUnit.DataPropertyName = "DataUnit";
            colDataUnit.FillWeight = 81.40286F;
            colDataUnit.HeaderText = "单位";
            colDataUnit.Name = "colDataUnit";
            colDataUnit.ReadOnly = true;
            // 
            // colCANID
            // 
            colCANID.DataPropertyName = "CANID";
            colCANID.FillWeight = 81.40286F;
            colCANID.HeaderText = "端口号";
            colCANID.Name = "colCANID";
            colCANID.ReadOnly = true;
            // 
            // colCANOffset
            // 
            colCANOffset.DataPropertyName = "CANOffset";
            colCANOffset.FillWeight = 81.40286F;
            colCANOffset.HeaderText = "字节偏移";
            colCANOffset.Name = "colCANOffset";
            colCANOffset.ReadOnly = true;
            // 
            // colCANBit
            // 
            colCANBit.DataPropertyName = "CANBit";
            colCANBit.FillWeight = 81.40286F;
            colCANBit.HeaderText = "位偏移";
            colCANBit.Name = "colCANBit";
            colCANBit.ReadOnly = true;
            // 
            // colBitValue
            // 
            colBitValue.DataPropertyName = "BitValue";
            colBitValue.FillWeight = 81.40286F;
            colBitValue.HeaderText = "倍率值";
            colBitValue.Name = "colBitValue";
            colBitValue.ReadOnly = true;
            // 
            // ColPortPattern
            // 
            ColPortPattern.DataPropertyName = "PortPattern";
            ColPortPattern.FillWeight = 81.40286F;
            ColPortPattern.HeaderText = "大小端模式";
            ColPortPattern.Name = "ColPortPattern";
            ColPortPattern.ReadOnly = true;
            // 
            // colIdentity
            // 
            colIdentity.DataPropertyName = "Identity";
            colIdentity.FillWeight = 81.40286F;
            colIdentity.HeaderText = "是否生命信号";
            colIdentity.Name = "colIdentity";
            colIdentity.ReadOnly = true;
            // 
            // colIsRead
            // 
            colIsRead.DataPropertyName = "IsRead";
            colIsRead.FillWeight = 81.40286F;
            colIsRead.HeaderText = "源宿类型";
            colIsRead.Name = "colIsRead";
            colIsRead.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.DataPropertyName = "Description";
            colDescription.FillWeight = 150.402863F;
            colDescription.HeaderText = "备注";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // ucExcelImport
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.FromArgb(243, 249, 255);
            Controls.Add(grpData);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "ucExcelImport";
            Size = new Size(1455, 900);
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
        public System.Windows.Forms.ComboBox cboModelName;
        private Sunny.UI.UIDataGridView dataGridView1;
        private DataGridViewTextBoxColumn colmodelNameID;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colDataLabel;
        private DataGridViewTextBoxColumn colDataType;
        private DataGridViewTextBoxColumn colDataUnit;
        private DataGridViewTextBoxColumn colCANID;
        private DataGridViewTextBoxColumn colCANOffset;
        private DataGridViewTextBoxColumn colCANBit;
        private DataGridViewTextBoxColumn colBitValue;
        private DataGridViewTextBoxColumn ColPortPattern;
        private DataGridViewTextBoxColumn colIdentity;
        private DataGridViewTextBoxColumn colIsRead;
        private DataGridViewTextBoxColumn colDescription;
    }
}
