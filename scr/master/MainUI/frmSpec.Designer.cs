using Sunny.UI;

namespace MainUI
{
    partial class frmSpec
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            uiLabel2 = new UILabel();
            cboModel = new UIComboBox();
            uiLabel1 = new UILabel();
            cboType = new UIComboBox();
            btnGet = new UIButton();
            uiButton1 = new UIButton();
            uiButton2 = new UIButton();
            uiButton3 = new UIButton();
            uiDataGridView1 = new UIDataGridView();
            colID = new DataGridViewTextBoxColumn();
            TypeName = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(301, 20);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(75, 23);
            uiLabel2.TabIndex = 78;
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
            cboModel.Location = new Point(383, 17);
            cboModel.Margin = new Padding(4, 5, 4, 5);
            cboModel.MinimumSize = new Size(63, 0);
            cboModel.Name = "cboModel";
            cboModel.Padding = new Padding(0, 0, 30, 2);
            cboModel.RadiusSides = UICornerRadiusSides.None;
            cboModel.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            cboModel.ShowFilter = true;
            cboModel.Size = new Size(165, 29);
            cboModel.SymbolSize = 24;
            cboModel.TabIndex = 77;
            cboModel.TextAlignment = ContentAlignment.MiddleLeft;
            cboModel.Watermark = "请选择";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(28, 21);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(75, 23);
            uiLabel1.TabIndex = 76;
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
            cboType.Location = new Point(110, 18);
            cboType.Margin = new Padding(4, 5, 4, 5);
            cboType.MinimumSize = new Size(63, 0);
            cboType.Name = "cboType";
            cboType.Padding = new Padding(0, 0, 30, 2);
            cboType.RadiusSides = UICornerRadiusSides.None;
            cboType.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            cboType.ShowFilter = true;
            cboType.Size = new Size(165, 29);
            cboType.SymbolSize = 24;
            cboType.TabIndex = 75;
            cboType.TextAlignment = ContentAlignment.MiddleLeft;
            cboType.Watermark = "请选择";
            cboType.SelectedValueChanged += cboType_SelectedValueChanged;
            // 
            // btnGet
            // 
            btnGet.Cursor = Cursors.Hand;
            btnGet.Font = new Font("微软雅黑", 11F);
            btnGet.Location = new Point(651, 12);
            btnGet.MinimumSize = new Size(1, 1);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(120, 40);
            btnGet.TabIndex = 388;
            btnGet.Text = "搜索";
            btnGet.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnGet.TipsText = "1";
            btnGet.Click += btnGet_Click;
            // 
            // uiButton1
            // 
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.Font = new Font("微软雅黑", 11F);
            uiButton1.Location = new Point(18, 628);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(86, 38);
            uiButton1.TabIndex = 389;
            uiButton1.Text = "▲";
            uiButton1.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.TipsText = "1";
            uiButton1.Click += button1_Click;
            // 
            // uiButton2
            // 
            uiButton2.Cursor = Cursors.Hand;
            uiButton2.Font = new Font("微软雅黑", 11F);
            uiButton2.Location = new Point(110, 628);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(86, 38);
            uiButton2.TabIndex = 390;
            uiButton2.Text = "▼";
            uiButton2.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.TipsText = "1";
            uiButton2.Click += button2_Click;
            // 
            // uiButton3
            // 
            uiButton3.Cursor = Cursors.Hand;
            uiButton3.Font = new Font("微软雅黑", 11F);
            uiButton3.Location = new Point(651, 626);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(120, 40);
            uiButton3.TabIndex = 391;
            uiButton3.Text = "选择实行";
            uiButton3.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.TipsText = "1";
            uiButton3.Click += button3_Click;
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToDeleteRows = false;
            uiDataGridView1.AllowUserToResizeColumns = false;
            uiDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, TypeName, colUsername, colPassword });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(6, 59);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView1.RowTemplate.Height = 30;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.Size = new Size(775, 562);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 392;
            uiDataGridView1.CellDoubleClick += dataGridView_Spec_CellDoubleClick;
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
            // frmSpec
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 249, 255);
            ClientSize = new Size(786, 678);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiButton3);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Controls.Add(btnGet);
            Controls.Add(uiLabel2);
            Controls.Add(cboModel);
            Controls.Add(uiLabel1);
            Controls.Add(cboType);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSpec";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "选择规格";
            Load += frmSpec_Load;
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private UILabel uiLabel2;
        private Sunny.UI.UIComboBox cboModel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cboType;
        private Sunny.UI.UIButton btnGet;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
    }
}