using Sunny.UI;
namespace MainUI.MVB
{
    partial class frmPortManager
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
            colID = new DataGridViewTextBoxColumn();
            colPortName = new DataGridViewTextBoxColumn();
            colPort = new DataGridViewTextBoxColumn();
            colRate = new DataGridViewTextBoxColumn();
            colIsRead = new DataGridViewTextBoxColumn();
            colDataSize = new DataGridViewTextBoxColumn();
            txtID = new UITextBox();
            groupBox1 = new UIGroupBox();
            btnExcel = new UIButton();
            cboModelName = new UIComboBox();
            label5 = new UILabel();
            btnDelPort = new UIButton();
            btnAddPort = new UIButton();
            btnModify = new UIButton();
            label2 = new UILabel();
            nudDataSize = new UIIntegerUpDown();
            txtPortName = new UITextBox();
            nudRate = new UIIntegerUpDown();
            label3 = new UILabel();
            radHost = new UIRadioButton();
            label6 = new UILabel();
            radSource = new UIRadioButton();
            txtPort = new UITextBox();
            label7 = new UILabel();
            label4 = new UILabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            dataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colPortName, colPort, colRate, colIsRead, colDataSize });
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
            dataGridView1.Size = new Size(973, 387);
            dataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colPortName
            // 
            colPortName.DataPropertyName = "PortName";
            colPortName.HeaderText = "端口名称";
            colPortName.Name = "colPortName";
            colPortName.ReadOnly = true;
            // 
            // colPort
            // 
            colPort.DataPropertyName = "Port";
            colPort.HeaderText = "端口地址";
            colPort.Name = "colPort";
            colPort.ReadOnly = true;
            // 
            // colRate
            // 
            colRate.DataPropertyName = "Rate";
            colRate.HeaderText = "端口周期";
            colRate.Name = "colRate";
            colRate.ReadOnly = true;
            // 
            // colIsRead
            // 
            colIsRead.DataPropertyName = "IsRead";
            colIsRead.HeaderText = "源宿类型";
            colIsRead.Name = "colIsRead";
            colIsRead.ReadOnly = true;
            // 
            // colDataSize
            // 
            colDataSize.DataPropertyName = "DataSize";
            colDataSize.HeaderText = "数据大小";
            colDataSize.Name = "colDataSize";
            colDataSize.ReadOnly = true;
            // 
            // txtID
            // 
            txtID.Cursor = Cursors.IBeam;
            txtID.FillDisableColor = Color.White;
            txtID.FillReadOnlyColor = Color.White;
            txtID.Font = new Font("宋体", 12F);
            txtID.Location = new Point(292, 110);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.MinimumSize = new Size(1, 16);
            txtID.Name = "txtID";
            txtID.Padding = new Padding(5);
            txtID.Radius = 1;
            txtID.ReadOnly = true;
            txtID.RectDisableColor = Color.FromArgb(80, 160, 255);
            txtID.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtID.ShowText = false;
            txtID.Size = new Size(1, 16);
            txtID.TabIndex = 2;
            txtID.TextAlignment = ContentAlignment.MiddleLeft;
            txtID.Visible = false;
            txtID.Watermark = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(cboModelName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnDelPort);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(btnAddPort);
            groupBox1.Controls.Add(btnModify);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nudDataSize);
            groupBox1.Controls.Add(txtPortName);
            groupBox1.Controls.Add(nudRate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(radHost);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radSource);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("宋体", 12F);
            groupBox1.Location = new Point(0, 424);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0, 32, 0, 0);
            groupBox1.Size = new Size(973, 126);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "编辑栏";
            groupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // btnExcel
            // 
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.Font = new Font("宋体", 12F);
            btnExcel.Location = new Point(865, 81);
            btnExcel.MinimumSize = new Size(1, 1);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(91, 30);
            btnExcel.TabIndex = 31;
            btnExcel.Text = "Excel导入";
            btnExcel.Click += btnExcel_Click;
            // 
            // cboModelName
            // 
            cboModelName.DataSource = null;
            cboModelName.DropDownStyle = UIDropDownStyle.DropDownList;
            cboModelName.FillColor = Color.White;
            cboModelName.Font = new Font("宋体", 12F);
            cboModelName.FormattingEnabled = true;
            cboModelName.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboModelName.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboModelName.Location = new Point(116, 35);
            cboModelName.Margin = new Padding(4, 5, 4, 5);
            cboModelName.MinimumSize = new Size(63, 0);
            cboModelName.Name = "cboModelName";
            cboModelName.Padding = new Padding(0, 0, 30, 2);
            cboModelName.Size = new Size(158, 24);
            cboModelName.SymbolSize = 24;
            cboModelName.TabIndex = 30;
            cboModelName.TextAlignment = ContentAlignment.MiddleLeft;
            cboModelName.Watermark = "";
            cboModelName.SelectedIndexChanged += cboModelName_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("宋体", 12F);
            label5.ForeColor = Color.FromArgb(48, 48, 48);
            label5.Location = new Point(29, 39);
            label5.Name = "label5";
            label5.Size = new Size(87, 16);
            label5.TabIndex = 29;
            label5.Text = "型号名称：";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelPort
            // 
            btnDelPort.Cursor = Cursors.Hand;
            btnDelPort.Font = new Font("宋体", 12F);
            btnDelPort.Location = new Point(865, 35);
            btnDelPort.MinimumSize = new Size(1, 1);
            btnDelPort.Name = "btnDelPort";
            btnDelPort.Size = new Size(91, 30);
            btnDelPort.TabIndex = 10;
            btnDelPort.Text = "删除";
            btnDelPort.Click += btnDelPort_Click;
            // 
            // btnAddPort
            // 
            btnAddPort.Cursor = Cursors.Hand;
            btnAddPort.Font = new Font("宋体", 12F);
            btnAddPort.Location = new Point(753, 35);
            btnAddPort.MinimumSize = new Size(1, 1);
            btnAddPort.Name = "btnAddPort";
            btnAddPort.Size = new Size(91, 30);
            btnAddPort.TabIndex = 9;
            btnAddPort.Text = "增加";
            btnAddPort.Click += btnAddPort_Click;
            // 
            // btnModify
            // 
            btnModify.Cursor = Cursors.Hand;
            btnModify.Font = new Font("宋体", 12F);
            btnModify.Location = new Point(753, 81);
            btnModify.MinimumSize = new Size(1, 1);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(91, 30);
            btnModify.TabIndex = 6;
            btnModify.Text = "修改";
            btnModify.Click += btnModify_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 12F);
            label2.ForeColor = Color.FromArgb(48, 48, 48);
            label2.Location = new Point(292, 39);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 1;
            label2.Text = "端口名称:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudDataSize
            // 
            nudDataSize.Font = new Font("宋体", 12F);
            nudDataSize.Location = new Point(372, 82);
            nudDataSize.Margin = new Padding(4, 5, 4, 5);
            nudDataSize.MinimumSize = new Size(100, 0);
            nudDataSize.Name = "nudDataSize";
            nudDataSize.ShowText = false;
            nudDataSize.Size = new Size(138, 26);
            nudDataSize.TabIndex = 5;
            nudDataSize.Text = null;
            nudDataSize.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtPortName
            // 
            txtPortName.Cursor = Cursors.IBeam;
            txtPortName.Font = new Font("宋体", 12F);
            txtPortName.Location = new Point(372, 35);
            txtPortName.Margin = new Padding(4, 5, 4, 5);
            txtPortName.MinimumSize = new Size(1, 16);
            txtPortName.Name = "txtPortName";
            txtPortName.Padding = new Padding(5);
            txtPortName.ShowText = false;
            txtPortName.Size = new Size(138, 26);
            txtPortName.TabIndex = 2;
            txtPortName.TextAlignment = ContentAlignment.MiddleLeft;
            txtPortName.Watermark = "";
            // 
            // nudRate
            // 
            nudRate.Font = new Font("宋体", 12F);
            nudRate.Location = new Point(614, 82);
            nudRate.Margin = new Padding(4, 5, 4, 5);
            nudRate.MinimumSize = new Size(100, 0);
            nudRate.Name = "nudRate";
            nudRate.ShowText = false;
            nudRate.Size = new Size(111, 26);
            nudRate.TabIndex = 5;
            nudRate.Text = null;
            nudRate.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 12F);
            label3.ForeColor = Color.FromArgb(48, 48, 48);
            label3.Location = new Point(530, 39);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 1;
            label3.Text = "端口地址:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radHost
            // 
            radHost.Cursor = Cursors.Hand;
            radHost.Font = new Font("宋体", 12F);
            radHost.Location = new Point(199, 86);
            radHost.MinimumSize = new Size(1, 1);
            radHost.Name = "radHost";
            radHost.Size = new Size(75, 18);
            radHost.TabIndex = 4;
            radHost.Text = "宿端口";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("宋体", 12F);
            label6.ForeColor = Color.FromArgb(48, 48, 48);
            label6.Location = new Point(29, 86);
            label6.Name = "label6";
            label6.Size = new Size(87, 16);
            label6.TabIndex = 1;
            label6.Text = "源宿类型：";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radSource
            // 
            radSource.Cursor = Cursors.Hand;
            radSource.Font = new Font("宋体", 12F);
            radSource.Location = new Point(116, 85);
            radSource.MinimumSize = new Size(1, 1);
            radSource.Name = "radSource";
            radSource.Size = new Size(75, 18);
            radSource.TabIndex = 4;
            radSource.Text = "源端口";
            // 
            // txtPort
            // 
            txtPort.Cursor = Cursors.IBeam;
            txtPort.Font = new Font("宋体", 12F);
            txtPort.Location = new Point(614, 35);
            txtPort.Margin = new Padding(4, 5, 4, 5);
            txtPort.MinimumSize = new Size(1, 16);
            txtPort.Name = "txtPort";
            txtPort.Padding = new Padding(5);
            txtPort.ShowText = false;
            txtPort.Size = new Size(111, 26);
            txtPort.TabIndex = 2;
            txtPort.TextAlignment = ContentAlignment.MiddleLeft;
            txtPort.Watermark = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("宋体", 12F);
            label7.ForeColor = Color.FromArgb(48, 48, 48);
            label7.Location = new Point(292, 85);
            label7.Name = "label7";
            label7.Size = new Size(87, 16);
            label7.TabIndex = 1;
            label7.Text = "数据大小：";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("宋体", 12F);
            label4.ForeColor = Color.FromArgb(48, 48, 48);
            label4.Location = new Point(530, 86);
            label4.Name = "label4";
            label4.Size = new Size(87, 16);
            label4.TabIndex = 1;
            label4.Text = "端口周期：";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmPortManager
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(973, 550);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPortManager";
            Padding = new Padding(0, 29, 0, 0);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "MVB参数设置";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 798, 510);
            Load += frmPortManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UIDataGridView dataGridView1;
        private UITextBox txtID;
        private UIGroupBox groupBox1;
        private UILabel label4;
        private UITextBox txtPort;
        private UILabel label3;
        private UITextBox txtPortName;
        private UILabel label2;
        private UIIntegerUpDown nudRate;
        private UIRadioButton radHost;
        private UIRadioButton radSource;
        private UILabel label6;
        private UIButton btnModify;
        private UIIntegerUpDown nudDataSize;
        private UILabel label7;
        private UIButton btnAddPort;
        private UIButton btnDelPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataSize;
        private UIComboBox cboModelName;
        private UILabel label5;
        private UIButton btnExcel;
    }
}