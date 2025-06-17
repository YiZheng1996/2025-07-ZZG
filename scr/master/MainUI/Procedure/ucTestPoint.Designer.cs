namespace MainUI.Procedure
{
    partial class ucTestPoint
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new UIDataGridView();
            cbxModelName = new UIComboBox();
            label1 = new Label();
            label2 = new Label();
            cbxTestType = new UIComboBox();
            groupBox1 = new UIGroupBox();
            groupBox2 = new UIGroupBox();
            BtnDele = new UIButton();
            btnAdd = new UIButton();
            btnUpdate = new UIButton();
            ColID = new DataGridViewTextBoxColumn();
            ColProcessKey = new DataGridViewTextBoxColumn();
            ColProcessName = new DataGridViewTextBoxColumn();
            ColSort = new DataGridViewTextBoxColumn();
            ColIsVisible = new DataGridViewTextBoxColumn();
            ColDSLName = new DataGridViewTextBoxColumn();
            ColFlipToTheLine = new DataGridViewTextBoxColumn();
            ColModelID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColID, ColProcessKey, ColProcessName, ColSort, ColIsVisible, ColDSLName, ColFlipToTheLine, ColModelID });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(0, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(485, 537);
            dataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            dataGridView1.TabIndex = 0;
            // 
            // cbxModelName
            // 
            cbxModelName.DataSource = null;
            cbxModelName.DropDownStyle = UIDropDownStyle.DropDownList;
            cbxModelName.FillColor = Color.White;
            cbxModelName.Font = new Font("宋体", 12F);
            cbxModelName.FormattingEnabled = true;
            cbxModelName.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbxModelName.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbxModelName.Location = new Point(114, 26);
            cbxModelName.Margin = new Padding(4, 5, 4, 5);
            cbxModelName.MinimumSize = new Size(63, 0);
            cbxModelName.Name = "cbxModelName";
            cbxModelName.Padding = new Padding(0, 0, 30, 2);
            cbxModelName.Size = new Size(190, 24);
            cbxModelName.SymbolSize = 24;
            cbxModelName.TabIndex = 1;
            cbxModelName.TextAlignment = ContentAlignment.MiddleLeft;
            cbxModelName.Watermark = "";
            cbxModelName.SelectedIndexChanged += cbxModelName_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("宋体", 12F);
            label1.Location = new Point(55, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 16);
            label1.TabIndex = 2;
            label1.Text = "型号：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("宋体", 12F);
            label2.Location = new Point(432, 30);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 4;
            label2.Text = "类型：";
            label2.Visible = false;
            // 
            // cbxTestType
            // 
            cbxTestType.DataSource = null;
            cbxTestType.DropDownStyle = UIDropDownStyle.DropDownList;
            cbxTestType.FillColor = Color.White;
            cbxTestType.Font = new Font("宋体", 12F);
            cbxTestType.FormattingEnabled = true;
            cbxTestType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbxTestType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbxTestType.Location = new Point(494, 26);
            cbxTestType.Margin = new Padding(4, 5, 4, 5);
            cbxTestType.MinimumSize = new Size(63, 0);
            cbxTestType.Name = "cbxTestType";
            cbxTestType.Padding = new Padding(0, 0, 30, 2);
            cbxTestType.Size = new Size(133, 24);
            cbxTestType.SymbolSize = 24;
            cbxTestType.TabIndex = 3;
            cbxTestType.TextAlignment = ContentAlignment.MiddleLeft;
            cbxTestType.Visible = false;
            cbxTestType.Watermark = "";
            cbxTestType.SelectedIndexChanged += cbxTestType_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(18, 63);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0, 32, 0, 0);
            groupBox1.Size = new Size(485, 569);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "试验项点";
            groupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDele);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(cbxModelName);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbxTestType);
            groupBox2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.MinimumSize = new Size(1, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0, 32, 0, 0);
            groupBox2.Size = new Size(650, 650);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = null;
            groupBox2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // BtnDele
            // 
            BtnDele.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnDele.Location = new Point(516, 408);
            BtnDele.MinimumSize = new Size(1, 1);
            BtnDele.Name = "BtnDele";
            BtnDele.Size = new Size(111, 40);
            BtnDele.TabIndex = 8;
            BtnDele.Text = "删 除";
            BtnDele.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnDele.Click += BtnDele_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAdd.Location = new Point(516, 332);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "新 增";
            btnAdd.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnUpdate.Location = new Point(516, 256);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "修 改";
            btnUpdate.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ColID
            // 
            ColID.DataPropertyName = "ID";
            ColID.HeaderText = "ID";
            ColID.Name = "ColID";
            ColID.Visible = false;
            ColID.Width = 97;
            // 
            // ColProcessKey
            // 
            ColProcessKey.DataPropertyName = "ProcessKey";
            ColProcessKey.HeaderText = "Key";
            ColProcessKey.Name = "ColProcessKey";
            ColProcessKey.Visible = false;
            ColProcessKey.Width = 96;
            // 
            // ColProcessName
            // 
            ColProcessName.DataPropertyName = "ProcessName";
            ColProcessName.FillWeight = 98.47716F;
            ColProcessName.HeaderText = "项点名称";
            ColProcessName.Name = "ColProcessName";
            ColProcessName.Width = 330;
            // 
            // ColSort
            // 
            ColSort.DataPropertyName = "Sort";
            ColSort.HeaderText = "项点顺序";
            ColSort.Name = "ColSort";
            ColSort.Visible = false;
            ColSort.Width = 96;
            // 
            // ColIsVisible
            // 
            ColIsVisible.DataPropertyName = "IsVisible";
            ColIsVisible.HeaderText = "是否显示";
            ColIsVisible.Name = "ColIsVisible";
            ColIsVisible.Visible = false;
            // 
            // ColDSLName
            // 
            ColDSLName.DataPropertyName = "DSLName";
            ColDSLName.HeaderText = "DSL名称";
            ColDSLName.Name = "ColDSLName";
            ColDSLName.Visible = false;
            // 
            // ColFlipToTheLine
            // 
            ColFlipToTheLine.DataPropertyName = "FlipToTheLine";
            ColFlipToTheLine.FillWeight = 101.5228F;
            ColFlipToTheLine.HeaderText = "报表自动跳转行数";
            ColFlipToTheLine.Name = "ColFlipToTheLine";
            ColFlipToTheLine.Width = 150;
            // 
            // ColModelID
            // 
            ColModelID.DataPropertyName = "ModelID";
            ColModelID.HeaderText = "型号ID与Model表关联";
            ColModelID.Name = "ColModelID";
            ColModelID.Visible = false;
            ColModelID.Width = 96;
            // 
            // ucTestPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Name = "ucTestPoint";
            Size = new Size(650, 650);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView dataGridView1;
        private Sunny.UI.UIComboBox cbxModelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIComboBox cbxTestType;
        private Sunny.UI.UIGroupBox groupBox1;
        private Sunny.UI.UIGroupBox groupBox2;
        private Sunny.UI.UIButton BtnDele;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnUpdate;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColProcessKey;
        private DataGridViewTextBoxColumn ColProcessName;
        private DataGridViewTextBoxColumn ColSort;
        private DataGridViewTextBoxColumn ColIsVisible;
        private DataGridViewTextBoxColumn ColDSLName;
        private DataGridViewTextBoxColumn ColFlipToTheLine;
        private DataGridViewTextBoxColumn ColModelID;
    }
}
