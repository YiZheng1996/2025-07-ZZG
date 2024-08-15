namespace MainUI.TRDP
{
    partial class FrmTRDPName
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView1 = new Sunny.UI.UIDataGridView();
            btnUpdate = new Sunny.UI.UIButton();
            btnEdit = new Sunny.UI.UIButton();
            btnAdd = new Sunny.UI.UIButton();
            txtConfigFile = new Sunny.UI.UITextBox();
            label3 = new System.Windows.Forms.Label();
            cboTrdpno = new Sunny.UI.UIComboBox();
            label10 = new System.Windows.Forms.Label();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTRDPNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colConfigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            coltrdpip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            coltrdpport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            collocalip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            collocalport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colID, colTypeName, colTRDPNo, colConfigName, coltrdpip, coltrdpport, collocalip, collocalport });
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridView1.Location = new System.Drawing.Point(0, 29);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(914, 247);
            dataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridView1.TabIndex = 24;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(775, 362);
            btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(99, 34);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "删除";
            btnUpdate.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.Location = new System.Drawing.Point(658, 362);
            btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(99, 34);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "修改";
            btnEdit.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(541, 362);
            btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(99, 34);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "增加";
            btnAdd.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Click += btnAdd_Click;
            // 
            // txtConfigFile
            // 
            txtConfigFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtConfigFile.Location = new System.Drawing.Point(421, 301);
            txtConfigFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtConfigFile.MinimumSize = new System.Drawing.Size(1, 16);
            txtConfigFile.Name = "txtConfigFile";
            txtConfigFile.Padding = new System.Windows.Forms.Padding(5);
            txtConfigFile.ShowText = false;
            txtConfigFile.Size = new System.Drawing.Size(169, 26);
            txtConfigFile.TabIndex = 26;
            txtConfigFile.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtConfigFile.Watermark = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(310, 305);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 16);
            label3.TabIndex = 25;
            label3.Text = "配置文件名称：";
            // 
            // cboTrdpno
            // 
            cboTrdpno.DataSource = null;
            cboTrdpno.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboTrdpno.FillColor = System.Drawing.Color.White;
            cboTrdpno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboTrdpno.FormattingEnabled = true;
            cboTrdpno.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cboTrdpno.Items.AddRange(new object[] { "1", "2" });
            cboTrdpno.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            cboTrdpno.Location = new System.Drawing.Point(122, 301);
            cboTrdpno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cboTrdpno.MinimumSize = new System.Drawing.Size(63, 0);
            cboTrdpno.Name = "cboTrdpno";
            cboTrdpno.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cboTrdpno.Size = new System.Drawing.Size(143, 24);
            cboTrdpno.SymbolSize = 24;
            cboTrdpno.TabIndex = 33;
            cboTrdpno.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            cboTrdpno.Watermark = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(40, 305);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(87, 16);
            label10.TabIndex = 32;
            label10.Text = "网关编号：";
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 50F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colTypeName
            // 
            colTypeName.DataPropertyName = "TypeName";
            colTypeName.FillWeight = 85.27919F;
            colTypeName.HeaderText = "型号";
            colTypeName.Name = "colTypeName";
            colTypeName.ReadOnly = true;
            // 
            // colTRDPNo
            // 
            colTRDPNo.DataPropertyName = "TRDPNo";
            colTRDPNo.FillWeight = 85.27919F;
            colTRDPNo.HeaderText = "网关编号";
            colTRDPNo.Name = "colTRDPNo";
            colTRDPNo.ReadOnly = true;
            // 
            // colConfigName
            // 
            colConfigName.DataPropertyName = "ConfigFileName";
            colConfigName.FillWeight = 85.27919F;
            colConfigName.HeaderText = "配置文件名称";
            colConfigName.Name = "colConfigName";
            colConfigName.ReadOnly = true;
            // 
            // coltrdpip
            // 
            coltrdpip.DataPropertyName = "TRDPIP";
            coltrdpip.FillWeight = 85.27919F;
            coltrdpip.HeaderText = "网关IP地址";
            coltrdpip.Name = "coltrdpip";
            coltrdpip.ReadOnly = true;
            // 
            // coltrdpport
            // 
            coltrdpport.DataPropertyName = "TRDPPort";
            coltrdpport.FillWeight = 85.27919F;
            coltrdpport.HeaderText = "网关端口";
            coltrdpport.Name = "coltrdpport";
            coltrdpport.ReadOnly = true;
            // 
            // collocalip
            // 
            collocalip.DataPropertyName = "LocalIP";
            collocalip.FillWeight = 85.27919F;
            collocalip.HeaderText = "本地IP地址";
            collocalip.Name = "collocalip";
            collocalip.ReadOnly = true;
            // 
            // collocalport
            // 
            collocalport.DataPropertyName = "LocalPort";
            collocalport.FillWeight = 85.27919F;
            collocalport.HeaderText = "本地端口";
            collocalport.Name = "collocalport";
            collocalport.ReadOnly = true;
            // 
            // FrmTRDPName
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(914, 419);
            Controls.Add(cboTrdpno);
            Controls.Add(label10);
            Controls.Add(btnUpdate);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtConfigFile);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "FrmTRDPName";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            ShowIcon = false;
            Text = "TRDP参数设置";
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 750, 436);
            Load += FrmTRDPName_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIDataGridView dataGridView1;
        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UITextBox txtConfigFile;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIComboBox cboTrdpno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTRDPNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfigName;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrdpip;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrdpport;
        private System.Windows.Forms.DataGridViewTextBoxColumn collocalip;
        private System.Windows.Forms.DataGridViewTextBoxColumn collocalport;
    }
}