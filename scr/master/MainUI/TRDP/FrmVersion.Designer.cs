namespace MainUI.TRDP
{
    partial class FrmVersion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            txtVersion = new Sunny.UI.UITextBox();
            label3 = new System.Windows.Forms.Label();
            btnAdd = new Sunny.UI.UIButton();
            btnEdit = new Sunny.UI.UIButton();
            btnUpdate = new Sunny.UI.UIButton();
            dataGridView1 = new Sunny.UI.UIDataGridView();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colVerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtVersion
            // 
            txtVersion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtVersion.Location = new System.Drawing.Point(129, 312);
            txtVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtVersion.MinimumSize = new System.Drawing.Size(1, 16);
            txtVersion.Name = "txtVersion";
            txtVersion.Padding = new System.Windows.Forms.Padding(5);
            txtVersion.ShowText = false;
            txtVersion.Size = new System.Drawing.Size(156, 26);
            txtVersion.TabIndex = 19;
            txtVersion.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtVersion.Watermark = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(67, 316);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 16);
            label3.TabIndex = 18;
            label3.Text = "版本号：";
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(423, 346);
            btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(99, 34);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "增加";
            btnAdd.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.Location = new System.Drawing.Point(535, 346);
            btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(99, 34);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "修改";
            btnEdit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.Click += btnEdit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(647, 346);
            btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(99, 34);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "删除";
            btnUpdate.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colID, colTypeName, colVerName });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridView1.Location = new System.Drawing.Point(0, 29);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 35;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(790, 247);
            dataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridView1.TabIndex = 23;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 53F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colTypeName
            // 
            colTypeName.DataPropertyName = "TypeName";
            colTypeName.FillWeight = 350F;
            colTypeName.HeaderText = "型号";
            colTypeName.Name = "colTypeName";
            colTypeName.ReadOnly = true;
            // 
            // colVerName
            // 
            colVerName.DataPropertyName = "VersionName";
            colVerName.FillWeight = 350F;
            colVerName.HeaderText = "协议版本号";
            colVerName.Name = "colVerName";
            colVerName.ReadOnly = true;
            // 
            // FrmVersion
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(790, 407);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtVersion);
            Controls.Add(label3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVersion";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            ShowIcon = false;
            Text = "协议版本";
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 634, 380);
            Load += FrmVersion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UITextBox txtVersion;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIDataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerName;
    }
}