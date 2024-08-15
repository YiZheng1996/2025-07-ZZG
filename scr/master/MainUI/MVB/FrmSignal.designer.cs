namespace MainUI.MVB
{
    partial class FrmSignal
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
            this.dgvSignal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBit = new System.Windows.Forms.TextBox();
            this.txtByte = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtIsFalse = new System.Windows.Forms.RadioButton();
            this.rbtIsTure = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDataType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radMVB = new System.Windows.Forms.RadioButton();
            this.radETH = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radLittleEndian = new System.Windows.Forms.RadioButton();
            this.radBigEndian = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsLifeSignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBigOrLimmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBitExcursion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colByteExcursion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPortNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSignalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSignal
            // 
            this.dgvSignal.AllowUserToAddRows = false;
            this.dgvSignal.AllowUserToDeleteRows = false;
            this.dgvSignal.AllowUserToResizeRows = false;
            this.dgvSignal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSignal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSignal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colSignalName,
            this.colDataType,
            this.colUnit,
            this.colPortNo,
            this.colByteExcursion,
            this.colBitExcursion,
            this.ColBigOrLimmit,
            this.colIsLifeSignal,
            this.colRemark});
            this.dgvSignal.Location = new System.Drawing.Point(12, 12);
            this.dgvSignal.MultiSelect = false;
            this.dgvSignal.Name = "dgvSignal";
            this.dgvSignal.ReadOnly = true;
            this.dgvSignal.RowHeadersVisible = false;
            this.dgvSignal.RowTemplate.Height = 23;
            this.dgvSignal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSignal.Size = new System.Drawing.Size(945, 340);
            this.dgvSignal.TabIndex = 1;
            this.dgvSignal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSignal_CellFormatting);
            this.dgvSignal.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSignal_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBit);
            this.groupBox1.Controls.Add(this.txtByte);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbtIsFalse);
            this.groupBox1.Controls.Add(this.rbtIsTure);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbDataType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPortName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑栏";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(858, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(208, 93);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(79, 21);
            this.txtUnit.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "单位：";
            // 
            // txtBit
            // 
            this.txtBit.Location = new System.Drawing.Point(372, 56);
            this.txtBit.Name = "txtBit";
            this.txtBit.Size = new System.Drawing.Size(100, 21);
            this.txtBit.TabIndex = 18;
            // 
            // txtByte
            // 
            this.txtByte.Location = new System.Drawing.Point(208, 54);
            this.txtByte.Name = "txtByte";
            this.txtByte.Size = new System.Drawing.Size(79, 21);
            this.txtByte.TabIndex = 17;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(746, 52);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(187, 21);
            this.txtRemark.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(699, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "备注：";
            // 
            // rbtIsFalse
            // 
            this.rbtIsFalse.AutoSize = true;
            this.rbtIsFalse.Location = new System.Drawing.Point(629, 57);
            this.rbtIsFalse.Name = "rbtIsFalse";
            this.rbtIsFalse.Size = new System.Drawing.Size(35, 16);
            this.rbtIsFalse.TabIndex = 14;
            this.rbtIsFalse.TabStop = true;
            this.rbtIsFalse.Text = "否";
            this.rbtIsFalse.UseVisualStyleBackColor = true;
            // 
            // rbtIsTure
            // 
            this.rbtIsTure.AutoSize = true;
            this.rbtIsTure.Location = new System.Drawing.Point(588, 56);
            this.rbtIsTure.Name = "rbtIsTure";
            this.rbtIsTure.Size = new System.Drawing.Size(35, 16);
            this.rbtIsTure.TabIndex = 13;
            this.rbtIsTure.TabStop = true;
            this.rbtIsTure.Text = "是";
            this.rbtIsTure.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "是否是生命信号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "位 偏 移：";
            // 
            // cmbDataType
            // 
            this.cmbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataType.FormattingEnabled = true;
            this.cmbDataType.Items.AddRange(new object[] {
            "B1",
            "U2",
            "U4",
            "U5",
            "U6",
            "U8",
            "I8",
            "U16",
            "I16",
            "U32",
            "I32",
            "U64",
            "I64"});
            this.cmbDataType.Location = new System.Drawing.Point(543, 14);
            this.cmbDataType.Name = "cmbDataType";
            this.cmbDataType.Size = new System.Drawing.Size(121, 20);
            this.cmbDataType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据类型：";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(777, 88);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(746, 14);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(187, 21);
            this.txtPort.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(687, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "端口号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "字节偏移：";
            // 
            // txtPortName
            // 
            this.txtPortName.Location = new System.Drawing.Point(372, 14);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(100, 21);
            this.txtPortName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "信号名称：";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(187, 14);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID：";
            // 
            // radMVB
            // 
            this.radMVB.AutoSize = true;
            this.radMVB.Checked = true;
            this.radMVB.Location = new System.Drawing.Point(11, 64);
            this.radMVB.Name = "radMVB";
            this.radMVB.Size = new System.Drawing.Size(41, 16);
            this.radMVB.TabIndex = 24;
            this.radMVB.TabStop = true;
            this.radMVB.Text = "MVB";
            this.radMVB.UseVisualStyleBackColor = true;
            // 
            // radETH
            // 
            this.radETH.AutoSize = true;
            this.radETH.Location = new System.Drawing.Point(11, 12);
            this.radETH.Name = "radETH";
            this.radETH.Size = new System.Drawing.Size(59, 16);
            this.radETH.TabIndex = 23;
            this.radETH.Text = "以太网";
            this.radETH.UseVisualStyleBackColor = true;
            this.radETH.CheckedChanged += new System.EventHandler(this.radETH_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMVB);
            this.groupBox2.Controls.Add(this.radETH);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 94);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // radLittleEndian
            // 
            this.radLittleEndian.AutoSize = true;
            this.radLittleEndian.Location = new System.Drawing.Point(97, 15);
            this.radLittleEndian.Name = "radLittleEndian";
            this.radLittleEndian.Size = new System.Drawing.Size(71, 16);
            this.radLittleEndian.TabIndex = 28;
            this.radLittleEndian.TabStop = true;
            this.radLittleEndian.Text = "小端模式";
            this.radLittleEndian.UseVisualStyleBackColor = true;
            // 
            // radBigEndian
            // 
            this.radBigEndian.AutoSize = true;
            this.radBigEndian.Location = new System.Drawing.Point(23, 14);
            this.radBigEndian.Name = "radBigEndian";
            this.radBigEndian.Size = new System.Drawing.Size(71, 16);
            this.radBigEndian.TabIndex = 27;
            this.radBigEndian.TabStop = true;
            this.radBigEndian.Text = "大端模式";
            this.radBigEndian.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radLittleEndian);
            this.groupBox3.Controls.Add(this.radBigEndian);
            this.groupBox3.Location = new System.Drawing.Point(349, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 40);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Description";
            this.colRemark.FillWeight = 33.12183F;
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // colIsLifeSignal
            // 
            this.colIsLifeSignal.DataPropertyName = "Identity";
            this.colIsLifeSignal.FillWeight = 33.12183F;
            this.colIsLifeSignal.HeaderText = "是否生命信号";
            this.colIsLifeSignal.Name = "colIsLifeSignal";
            this.colIsLifeSignal.ReadOnly = true;
            // 
            // ColBigOrLimmit
            // 
            this.ColBigOrLimmit.DataPropertyName = "DataRange";
            this.ColBigOrLimmit.HeaderText = "大小端模式";
            this.ColBigOrLimmit.Name = "ColBigOrLimmit";
            this.ColBigOrLimmit.ReadOnly = true;
            // 
            // colBitExcursion
            // 
            this.colBitExcursion.DataPropertyName = "MVBBit";
            this.colBitExcursion.FillWeight = 33.12183F;
            this.colBitExcursion.HeaderText = "位偏移";
            this.colBitExcursion.Name = "colBitExcursion";
            this.colBitExcursion.ReadOnly = true;
            // 
            // colByteExcursion
            // 
            this.colByteExcursion.DataPropertyName = "MVBOffset";
            this.colByteExcursion.FillWeight = 33.12183F;
            this.colByteExcursion.HeaderText = "字节偏移";
            this.colByteExcursion.Name = "colByteExcursion";
            this.colByteExcursion.ReadOnly = true;
            // 
            // colPortNo
            // 
            this.colPortNo.DataPropertyName = "MVBPort";
            this.colPortNo.FillWeight = 33.12183F;
            this.colPortNo.HeaderText = "端口号";
            this.colPortNo.Name = "colPortNo";
            this.colPortNo.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "DataUnit";
            this.colUnit.FillWeight = 635.0254F;
            this.colUnit.HeaderText = "单位";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colDataType
            // 
            this.colDataType.DataPropertyName = "DataType";
            this.colDataType.FillWeight = 33.12183F;
            this.colDataType.HeaderText = "数据类型";
            this.colDataType.Name = "colDataType";
            this.colDataType.ReadOnly = true;
            // 
            // colSignalName
            // 
            this.colSignalName.DataPropertyName = "DataLabel";
            this.colSignalName.FillWeight = 33.12183F;
            this.colSignalName.HeaderText = "信号名称";
            this.colSignalName.Name = "colSignalName";
            this.colSignalName.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.FillWeight = 33.12183F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // FrmSignal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSignal);
            this.Name = "FrmSignal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSignal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSignal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDataType;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtIsFalse;
        private System.Windows.Forms.RadioButton rbtIsTure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBit;
        private System.Windows.Forms.TextBox txtByte;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radMVB;
        private System.Windows.Forms.RadioButton radETH;
        private System.Windows.Forms.RadioButton radLittleEndian;
        private System.Windows.Forms.RadioButton radBigEndian;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPortNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colByteExcursion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBitExcursion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBigOrLimmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsLifeSignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
    }
}