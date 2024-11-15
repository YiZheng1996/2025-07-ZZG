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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new UIDataGridView();
            btnUpdate = new UIButton();
            btnEdit = new UIButton();
            btnAdd = new UIButton();
            txtConfigFile = new UITextBox();
            label3 = new Label();
            cboTrdpno = new UIComboBox();
            label10 = new Label();
            colID = new DataGridViewTextBoxColumn();
            colTypeName = new DataGridViewTextBoxColumn();
            colTRDPNo = new DataGridViewTextBoxColumn();
            colConfigName = new DataGridViewTextBoxColumn();
            coltrdpip = new DataGridViewTextBoxColumn();
            coltrdpport = new DataGridViewTextBoxColumn();
            collocalip = new DataGridViewTextBoxColumn();
            collocalport = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("宋体", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colTypeName, colTRDPNo, colConfigName, coltrdpip, coltrdpport, collocalip, collocalport });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("宋体", 12F);
            dataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            dataGridView1.Location = new Point(0, 29);
            dataGridView1.MultiSelect = false;
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
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(914, 247);
            dataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            dataGridView1.TabIndex = 24;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("宋体", 12F);
            btnUpdate.Location = new Point(775, 362);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 34);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "删除";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("宋体", 12F);
            btnEdit.Location = new Point(658, 362);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 34);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "修改";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("宋体", 12F);
            btnAdd.Location = new Point(541, 362);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 34);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "增加";
            btnAdd.Click += btnAdd_Click;
            // 
            // txtConfigFile
            // 
            txtConfigFile.Font = new Font("宋体", 12F);
            txtConfigFile.Location = new Point(421, 301);
            txtConfigFile.Margin = new Padding(4, 5, 4, 5);
            txtConfigFile.MinimumSize = new Size(1, 16);
            txtConfigFile.Name = "txtConfigFile";
            txtConfigFile.Padding = new Padding(5);
            txtConfigFile.ShowText = false;
            txtConfigFile.Size = new Size(169, 26);
            txtConfigFile.TabIndex = 26;
            txtConfigFile.TextAlignment = ContentAlignment.MiddleLeft;
            txtConfigFile.Watermark = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 305);
            label3.Name = "label3";
            label3.Size = new Size(119, 16);
            label3.TabIndex = 25;
            label3.Text = "配置文件名称：";
            // 
            // cboTrdpno
            // 
            cboTrdpno.DataSource = null;
            cboTrdpno.DropDownStyle = UIDropDownStyle.DropDownList;
            cboTrdpno.FillColor = Color.White;
            cboTrdpno.Font = new Font("宋体", 12F);
            cboTrdpno.FormattingEnabled = true;
            cboTrdpno.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboTrdpno.Items.AddRange(new object[] { "1", "2" });
            cboTrdpno.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboTrdpno.Location = new Point(122, 301);
            cboTrdpno.Margin = new Padding(4, 5, 4, 5);
            cboTrdpno.MinimumSize = new Size(63, 0);
            cboTrdpno.Name = "cboTrdpno";
            cboTrdpno.Padding = new Padding(0, 0, 30, 2);
            cboTrdpno.Size = new Size(143, 24);
            cboTrdpno.SymbolSize = 24;
            cboTrdpno.TabIndex = 33;
            cboTrdpno.TextAlignment = ContentAlignment.MiddleLeft;
            cboTrdpno.Watermark = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 305);
            label10.Name = "label10";
            label10.Size = new Size(87, 16);
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
            coltrdpip.Visible = false;
            // 
            // coltrdpport
            // 
            coltrdpport.DataPropertyName = "TRDPPort";
            coltrdpport.FillWeight = 85.27919F;
            coltrdpport.HeaderText = "网关端口";
            coltrdpport.Name = "coltrdpport";
            coltrdpport.ReadOnly = true;
            coltrdpport.Visible = false;
            // 
            // collocalip
            // 
            collocalip.DataPropertyName = "LocalIP";
            collocalip.FillWeight = 85.27919F;
            collocalip.HeaderText = "本地IP地址";
            collocalip.Name = "collocalip";
            collocalip.ReadOnly = true;
            collocalip.Visible = false;
            // 
            // collocalport
            // 
            collocalport.DataPropertyName = "LocalPort";
            collocalport.FillWeight = 85.27919F;
            collocalport.HeaderText = "本地端口";
            collocalport.Name = "collocalport";
            collocalport.ReadOnly = true;
            collocalport.Visible = false;
            // 
            // FrmTRDPName
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(914, 419);
            Controls.Add(cboTrdpno);
            Controls.Add(label10);
            Controls.Add(btnUpdate);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtConfigFile);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "FrmTRDPName";
            Padding = new Padding(0, 29, 0, 0);
            ShowIcon = false;
            Text = "TRDP参数设置";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 750, 436);
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