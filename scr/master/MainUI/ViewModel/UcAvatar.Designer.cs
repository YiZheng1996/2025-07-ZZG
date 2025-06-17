namespace MainUI.ViewModel
{
    partial class UcAvatar
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            uiDataGridView1 = new UIDataGridView();
            colID = new DataGridViewTextBoxColumn();
            TypeName = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            uiButton3 = new UIButton();
            uiButton2 = new UIButton();
            uiButton1 = new UIButton();
            btnGet = new UIButton();
            uiLabel2 = new UILabel();
            cboModel = new UIComboBox();
            uiLabel1 = new UILabel();
            cboType = new UIComboBox();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToDeleteRows = false;
            uiDataGridView1.AllowUserToResizeColumns = false;
            uiDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            uiDataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle12.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, TypeName, colUsername, colPassword });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(12, 63);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle14.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            uiDataGridView1.RowTemplate.Height = 30;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.Size = new Size(775, 562);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 401;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            // 
            // TypeName
            // 
            TypeName.DataPropertyName = "modeltype";
            TypeName.HeaderText = "产品类型";
            TypeName.Name = "TypeName";
            TypeName.ReadOnly = true;
            TypeName.Width = 250;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Name";
            colUsername.HeaderText = "产品型号";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 250;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "mark";
            colPassword.HeaderText = "备注";
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            colPassword.Width = 200;
            // 
            // uiButton3
            // 
            uiButton3.Cursor = Cursors.Hand;
            uiButton3.Font = new Font("微软雅黑", 11F);
            uiButton3.Location = new Point(657, 630);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(120, 40);
            uiButton3.TabIndex = 400;
            uiButton3.Text = "选择实行";
            uiButton3.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.TipsText = "1";
            // 
            // uiButton2
            // 
            uiButton2.Cursor = Cursors.Hand;
            uiButton2.Font = new Font("微软雅黑", 11F);
            uiButton2.Location = new Point(116, 632);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(86, 38);
            uiButton2.TabIndex = 399;
            uiButton2.Text = "▼";
            uiButton2.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.TipsText = "1";
            // 
            // uiButton1
            // 
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.Font = new Font("微软雅黑", 11F);
            uiButton1.Location = new Point(24, 632);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(86, 38);
            uiButton1.TabIndex = 398;
            uiButton1.Text = "▲";
            uiButton1.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.TipsText = "1";
            // 
            // btnGet
            // 
            btnGet.Cursor = Cursors.Hand;
            btnGet.Font = new Font("微软雅黑", 11F);
            btnGet.Location = new Point(657, 16);
            btnGet.MinimumSize = new Size(1, 1);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(120, 40);
            btnGet.TabIndex = 397;
            btnGet.Text = "搜索";
            btnGet.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnGet.TipsText = "1";
            btnGet.Click += btnGet_Click;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(307, 24);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(75, 23);
            uiLabel2.TabIndex = 396;
            uiLabel2.Text = "产品型号";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboModel
            // 
            cboModel.DataSource = null;
            cboModel.FillColor = Color.White;
            cboModel.FilterMaxCount = 50;
            cboModel.Font = new Font("微软雅黑", 12F);
            cboModel.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboModel.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "11", "12", "13", "14", "15", "16" });
            cboModel.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboModel.Location = new Point(389, 21);
            cboModel.Margin = new Padding(4, 5, 4, 5);
            cboModel.MinimumSize = new Size(63, 0);
            cboModel.Name = "cboModel";
            cboModel.Padding = new Padding(0, 0, 30, 2);
            cboModel.RadiusSides = UICornerRadiusSides.None;
            cboModel.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            cboModel.ShowFilter = true;
            cboModel.Size = new Size(165, 29);
            cboModel.SymbolSize = 24;
            cboModel.TabIndex = 395;
            cboModel.TextAlignment = ContentAlignment.MiddleLeft;
            cboModel.Watermark = "请选择";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(34, 25);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(75, 23);
            uiLabel1.TabIndex = 394;
            uiLabel1.Text = "产品类型";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboType
            // 
            cboType.DataSource = null;
            cboType.FillColor = Color.White;
            cboType.FilterMaxCount = 50;
            cboType.Font = new Font("微软雅黑", 12F);
            cboType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboType.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "11", "12", "13", "14", "15", "16" });
            cboType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboType.Location = new Point(116, 22);
            cboType.Margin = new Padding(4, 5, 4, 5);
            cboType.MinimumSize = new Size(63, 0);
            cboType.Name = "cboType";
            cboType.Padding = new Padding(0, 0, 30, 2);
            cboType.RadiusSides = UICornerRadiusSides.None;
            cboType.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            cboType.ShowFilter = true;
            cboType.Size = new Size(165, 29);
            cboType.SymbolSize = 24;
            cboType.TabIndex = 393;
            cboType.TextAlignment = ContentAlignment.MiddleLeft;
            cboType.Watermark = "请选择";
            // 
            // UcAvatar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 249, 255);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiButton3);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Controls.Add(btnGet);
            Controls.Add(uiLabel2);
            Controls.Add(cboModel);
            Controls.Add(uiLabel1);
            Controls.Add(cboType);
            Name = "UcAvatar";
            Size = new Size(797, 681);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UIDataGridView uiDataGridView1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TypeName;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colPassword;
        private UIButton uiButton3;
        private UIButton uiButton2;
        private UIButton uiButton1;
        private UIButton btnGet;
        private UILabel uiLabel2;
        private UIComboBox cboModel;
        private UILabel uiLabel1;
        private UIComboBox cboType;
    }
}
