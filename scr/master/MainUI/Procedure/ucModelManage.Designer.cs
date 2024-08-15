namespace MainUI.Procedure
{
    partial class ucModelManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            groupBox1 = new Sunny.UI.UIGroupBox();
            txtChexing = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            txtModelName = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            txtID = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            cboModelType = new Sunny.UI.UIComboBox();
            dataGridView1 = new Sunny.UI.UIDataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ModelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnEdit = new Sunny.UI.UIButton();
            btnDelete = new Sunny.UI.UIButton();
            btnAdd = new Sunny.UI.UIButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChexing);
            groupBox1.Controls.Add(uiLabel4);
            groupBox1.Controls.Add(txtModelName);
            groupBox1.Controls.Add(uiLabel3);
            groupBox1.Controls.Add(uiLabel2);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(uiLabel1);
            groupBox1.Controls.Add(cboModelType);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Font = new System.Drawing.Font("微软雅黑", 11F);
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            groupBox1.Size = new System.Drawing.Size(650, 650);
            groupBox1.TabIndex = 399;
            groupBox1.Text = "型号列表";
            groupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChexing
            // 
            txtChexing.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtChexing.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtChexing.Location = new System.Drawing.Point(495, 386);
            txtChexing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtChexing.MaxLength = 50;
            txtChexing.MinimumSize = new System.Drawing.Size(1, 16);
            txtChexing.Name = "txtChexing";
            txtChexing.Padding = new System.Windows.Forms.Padding(5);
            txtChexing.ShowText = false;
            txtChexing.Size = new System.Drawing.Size(148, 29);
            txtChexing.TabIndex = 406;
            txtChexing.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtChexing.Watermark = "请输入";
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = System.Drawing.Color.Transparent;
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new System.Drawing.Point(497, 359);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(75, 23);
            uiLabel4.TabIndex = 405;
            uiLabel4.Text = "备注";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModelName
            // 
            txtModelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtModelName.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtModelName.Location = new System.Drawing.Point(495, 314);
            txtModelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtModelName.MinimumSize = new System.Drawing.Size(1, 16);
            txtModelName.Name = "txtModelName";
            txtModelName.Padding = new System.Windows.Forms.Padding(5);
            txtModelName.ShowText = false;
            txtModelName.Size = new System.Drawing.Size(145, 29);
            txtModelName.TabIndex = 404;
            txtModelName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtModelName.Watermark = "请输入";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = System.Drawing.Color.Transparent;
            uiLabel3.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel3.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new System.Drawing.Point(494, 286);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(75, 23);
            uiLabel3.TabIndex = 403;
            uiLabel3.Text = "产品型号";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = System.Drawing.Color.Transparent;
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 11F);
            uiLabel2.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new System.Drawing.Point(494, 142);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(75, 23);
            uiLabel2.TabIndex = 401;
            uiLabel2.Text = "型号ID";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.FillDisableColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtID.FillReadOnlyColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtID.Font = new System.Drawing.Font("微软雅黑", 11F);
            txtID.Location = new System.Drawing.Point(495, 170);
            txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtID.MinimumSize = new System.Drawing.Size(1, 16);
            txtID.Name = "txtID";
            txtID.Padding = new System.Windows.Forms.Padding(5);
            txtID.ReadOnly = true;
            txtID.RectDisableColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtID.RectReadOnlyColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtID.ShowText = false;
            txtID.Size = new System.Drawing.Size(145, 29);
            txtID.TabIndex = 402;
            txtID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtID.Watermark = "请选择";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new System.Drawing.Point(494, 213);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(75, 23);
            uiLabel1.TabIndex = 400;
            uiLabel1.Text = "产品类型";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboModelType
            // 
            cboModelType.DataSource = null;
            cboModelType.FillColor = System.Drawing.Color.White;
            cboModelType.FilterMaxCount = 50;
            cboModelType.Font = new System.Drawing.Font("微软雅黑", 12F);
            cboModelType.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cboModelType.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "11", "12", "13", "14", "15", "16" });
            cboModelType.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            cboModelType.Location = new System.Drawing.Point(495, 242);
            cboModelType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cboModelType.MinimumSize = new System.Drawing.Size(63, 0);
            cboModelType.Name = "cboModelType";
            cboModelType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cboModelType.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            cboModelType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            cboModelType.Size = new System.Drawing.Size(145, 29);
            cboModelType.SymbolSize = 24;
            cboModelType.TabIndex = 399;
            cboModelType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            cboModelType.Watermark = "请选择";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(243, 249, 255);
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, name, TypeID, ModelType, mark });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(104, 173, 255);
            dataGridView1.Location = new System.Drawing.Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(488, 567);
            dataGridView1.TabIndex = 398;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "型号ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "型号";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 170;
            // 
            // TypeID
            // 
            TypeID.DataPropertyName = "TypeID";
            TypeID.HeaderText = "类型编号";
            TypeID.Name = "TypeID";
            TypeID.ReadOnly = true;
            TypeID.Visible = false;
            TypeID.Width = 180;
            // 
            // ModelType
            // 
            ModelType.DataPropertyName = "ModelType";
            ModelType.HeaderText = "类型";
            ModelType.Name = "ModelType";
            ModelType.ReadOnly = true;
            ModelType.Width = 170;
            // 
            // mark
            // 
            mark.DataPropertyName = "mark";
            mark.HeaderText = "备注";
            mark.Name = "mark";
            mark.ReadOnly = true;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEdit.Font = new System.Drawing.Font("微软雅黑", 11F);
            btnEdit.Location = new System.Drawing.Point(289, 598);
            btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(120, 40);
            btnEdit.TabIndex = 395;
            btnEdit.Text = "更改";
            btnEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnEdit.TipsText = "1";
            btnEdit.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.Font = new System.Drawing.Font("微软雅黑", 11F);
            btnDelete.Location = new System.Drawing.Point(153, 598);
            btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(120, 40);
            btnDelete.TabIndex = 394;
            btnDelete.Text = "删除";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnDelete.TipsText = "1";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.Font = new System.Drawing.Font("微软雅黑", 11F);
            btnAdd.Location = new System.Drawing.Point(13, 598);
            btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(120, 40);
            btnAdd.TabIndex = 393;
            btnAdd.Text = "添加";
            btnAdd.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnAdd.TipsText = "1";
            btnAdd.Click += btnAdd_Click;
            // 
            // ucModelManage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            Controls.Add(groupBox1);
            Name = "ucModelManage";
            Size = new System.Drawing.Size(650, 650);
            Load += ucModelManage_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox groupBox1;
        private Sunny.UI.UIDataGridView dataGridView1;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cboModelType;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtID;
        private Sunny.UI.UITextBox txtModelName;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtChexing;
        private Sunny.UI.UILabel uiLabel4;
    }
}
