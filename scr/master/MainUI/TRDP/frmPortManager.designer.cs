namespace MainUI.TRDP
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
            contextMenuStrip1 = new UIContextMenuStrip();
            设置为默认版本ToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new UIGroupBox();
            button2 = new UIButton();
            cbotrdpno = new UIComboBox();
            label9 = new UILabel();
            button1 = new UIButton();
            cboETHNo = new UIComboBox();
            label10 = new UILabel();
            btnAddVerno = new UIButton();
            txtVerno = new UIComboBox();
            label8 = new UILabel();
            cboModelName = new UIComboBox();
            label5 = new UILabel();
            btnDelPort = new UIButton();
            btnAddPort = new UIButton();
            btnModify = new UIButton();
            nudDataSize = new UIIntegerUpDown();
            nudRate = new UIIntegerUpDown();
            radHost = new UIRadioButton();
            radSource = new UIRadioButton();
            label7 = new UILabel();
            label4 = new UILabel();
            txtPort = new UITextBox();
            label6 = new UILabel();
            label3 = new UILabel();
            txtPortName = new UITextBox();
            label2 = new UILabel();
            txtID = new UITextBox();
            colID = new DataGridViewTextBoxColumn();
            colPortName = new DataGridViewTextBoxColumn();
            colPort = new DataGridViewTextBoxColumn();
            coltrdpno = new DataGridViewTextBoxColumn();
            colETHPassage = new DataGridViewTextBoxColumn();
            colRate = new DataGridViewTextBoxColumn();
            colIsRead = new DataGridViewTextBoxColumn();
            colDataSize = new DataGridViewTextBoxColumn();
            colVerNo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colPortName, colPort, coltrdpno, colETHPassage, colRate, colIsRead, colDataSize, colVerNo });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            dataGridView1.Size = new Size(1044, 364);
            dataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(243, 249, 255);
            contextMenuStrip1.Font = new Font("宋体", 12F);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 设置为默认版本ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(187, 26);
            // 
            // 设置为默认版本ToolStripMenuItem
            // 
            设置为默认版本ToolStripMenuItem.Image = Properties.Resources.Green;
            设置为默认版本ToolStripMenuItem.Name = "设置为默认版本ToolStripMenuItem";
            设置为默认版本ToolStripMenuItem.Size = new Size(186, 22);
            设置为默认版本ToolStripMenuItem.Text = "设置为默认版本";
            设置为默认版本ToolStripMenuItem.Click += 设置为默认版本ToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(cbotrdpno);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cboETHNo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnAddVerno);
            groupBox1.Controls.Add(txtVerno);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboModelName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnDelPort);
            groupBox1.Controls.Add(btnAddPort);
            groupBox1.Controls.Add(btnModify);
            groupBox1.Controls.Add(nudDataSize);
            groupBox1.Controls.Add(nudRate);
            groupBox1.Controls.Add(radHost);
            groupBox1.Controls.Add(radSource);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPortName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtID);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("宋体", 12F);
            groupBox1.Location = new Point(0, 393);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0, 32, 0, 0);
            groupBox1.Size = new Size(1044, 160);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "编辑栏";
            groupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.Font = new Font("宋体", 12F);
            button2.Location = new Point(339, 119);
            button2.MinimumSize = new Size(1, 1);
            button2.Name = "button2";
            button2.Size = new Size(135, 27);
            button2.TabIndex = 40;
            button2.Text = "Excel导入";
            button2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Click += button2_Click;
            // 
            // cbotrdpno
            // 
            cbotrdpno.DataSource = null;
            cbotrdpno.DropDownStyle = UIDropDownStyle.DropDownList;
            cbotrdpno.FillColor = Color.White;
            cbotrdpno.Font = new Font("宋体", 12F);
            cbotrdpno.FormattingEnabled = true;
            cbotrdpno.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cbotrdpno.Items.AddRange(new object[] { "1", "2" });
            cbotrdpno.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cbotrdpno.Location = new Point(583, 120);
            cbotrdpno.Margin = new Padding(4, 5, 4, 5);
            cbotrdpno.MinimumSize = new Size(63, 0);
            cbotrdpno.Name = "cbotrdpno";
            cbotrdpno.Padding = new Padding(0, 0, 30, 2);
            cbotrdpno.Size = new Size(121, 24);
            cbotrdpno.SymbolSize = 24;
            cbotrdpno.TabIndex = 39;
            cbotrdpno.TextAlignment = ContentAlignment.MiddleLeft;
            cbotrdpno.Watermark = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("宋体", 12F);
            label9.ForeColor = Color.FromArgb(48, 48, 48);
            label9.Location = new Point(500, 124);
            label9.Name = "label9";
            label9.Size = new Size(87, 16);
            label9.TabIndex = 38;
            label9.Text = "网关编号：";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Font = new Font("宋体", 12F);
            button1.Location = new Point(176, 119);
            button1.MinimumSize = new Size(1, 1);
            button1.Name = "button1";
            button1.Size = new Size(138, 27);
            button1.TabIndex = 37;
            button1.Text = "以太网参数编辑";
            button1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Click += button1_Click;
            // 
            // cboETHNo
            // 
            cboETHNo.DataSource = null;
            cboETHNo.DropDownStyle = UIDropDownStyle.DropDownList;
            cboETHNo.FillColor = Color.White;
            cboETHNo.Font = new Font("宋体", 12F);
            cboETHNo.FormattingEnabled = true;
            cboETHNo.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboETHNo.Items.AddRange(new object[] { "1", "2" });
            cboETHNo.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboETHNo.Location = new Point(811, 120);
            cboETHNo.Margin = new Padding(4, 5, 4, 5);
            cboETHNo.MinimumSize = new Size(63, 0);
            cboETHNo.Name = "cboETHNo";
            cboETHNo.Padding = new Padding(0, 0, 30, 2);
            cboETHNo.Size = new Size(124, 24);
            cboETHNo.SymbolSize = 24;
            cboETHNo.TabIndex = 36;
            cboETHNo.TextAlignment = ContentAlignment.MiddleLeft;
            cboETHNo.Watermark = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("宋体", 12F);
            label10.ForeColor = Color.FromArgb(48, 48, 48);
            label10.Location = new Point(741, 124);
            label10.Name = "label10";
            label10.Size = new Size(79, 16);
            label10.TabIndex = 35;
            label10.Text = "ETH通道：";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddVerno
            // 
            btnAddVerno.Font = new Font("宋体", 12F);
            btnAddVerno.Location = new Point(14, 119);
            btnAddVerno.MinimumSize = new Size(1, 1);
            btnAddVerno.Name = "btnAddVerno";
            btnAddVerno.Size = new Size(137, 27);
            btnAddVerno.TabIndex = 34;
            btnAddVerno.Text = "协议版本编辑";
            btnAddVerno.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAddVerno.Click += btnAddVerno_Click;
            // 
            // txtVerno
            // 
            txtVerno.DataSource = null;
            txtVerno.DropDownStyle = UIDropDownStyle.DropDownList;
            txtVerno.FillColor = Color.White;
            txtVerno.Font = new Font("宋体", 12F);
            txtVerno.FormattingEnabled = true;
            txtVerno.ItemHoverColor = Color.FromArgb(155, 200, 255);
            txtVerno.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            txtVerno.Location = new Point(811, 35);
            txtVerno.Margin = new Padding(4, 5, 4, 5);
            txtVerno.MinimumSize = new Size(63, 0);
            txtVerno.Name = "txtVerno";
            txtVerno.Padding = new Padding(0, 0, 30, 2);
            txtVerno.Size = new Size(124, 26);
            txtVerno.SymbolSize = 24;
            txtVerno.TabIndex = 33;
            txtVerno.TextAlignment = ContentAlignment.MiddleLeft;
            txtVerno.Watermark = "";
            txtVerno.SelectedIndexChanged += txtVerno_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("宋体", 12F);
            label8.ForeColor = Color.FromArgb(48, 48, 48);
            label8.Location = new Point(733, 40);
            label8.Name = "label8";
            label8.Size = new Size(87, 16);
            label8.TabIndex = 29;
            label8.Text = "协议版本：";
            label8.TextAlign = ContentAlignment.MiddleLeft;
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
            cboModelName.Location = new Point(93, 35);
            cboModelName.Margin = new Padding(4, 5, 4, 5);
            cboModelName.MinimumSize = new Size(63, 0);
            cboModelName.Name = "cboModelName";
            cboModelName.Padding = new Padding(0, 0, 30, 2);
            cboModelName.Size = new Size(162, 24);
            cboModelName.SymbolSize = 24;
            cboModelName.TabIndex = 28;
            cboModelName.TextAlignment = ContentAlignment.MiddleLeft;
            cboModelName.Watermark = "";
            cboModelName.SelectedIndexChanged += cboModelName_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("宋体", 12F);
            label5.ForeColor = Color.FromArgb(48, 48, 48);
            label5.Location = new Point(6, 40);
            label5.Name = "label5";
            label5.Size = new Size(87, 16);
            label5.TabIndex = 27;
            label5.Text = "型号名称：";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelPort
            // 
            btnDelPort.Font = new Font("宋体", 12F);
            btnDelPort.Location = new Point(949, 118);
            btnDelPort.MinimumSize = new Size(1, 1);
            btnDelPort.Name = "btnDelPort";
            btnDelPort.Size = new Size(80, 27);
            btnDelPort.TabIndex = 26;
            btnDelPort.Text = "删除";
            btnDelPort.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDelPort.Click += btnDelPort_Click;
            // 
            // btnAddPort
            // 
            btnAddPort.Font = new Font("宋体", 12F);
            btnAddPort.Location = new Point(949, 35);
            btnAddPort.MinimumSize = new Size(1, 1);
            btnAddPort.Name = "btnAddPort";
            btnAddPort.Size = new Size(80, 27);
            btnAddPort.TabIndex = 25;
            btnAddPort.Text = "增加";
            btnAddPort.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAddPort.Click += btnAddPort_Click;
            // 
            // btnModify
            // 
            btnModify.Font = new Font("宋体", 12F);
            btnModify.Location = new Point(949, 77);
            btnModify.MinimumSize = new Size(1, 1);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(80, 27);
            btnModify.TabIndex = 24;
            btnModify.Text = "修改";
            btnModify.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnModify.Click += btnModify_Click;
            // 
            // nudDataSize
            // 
            nudDataSize.Font = new Font("宋体", 12F);
            nudDataSize.Location = new Point(354, 78);
            nudDataSize.Margin = new Padding(4, 5, 4, 5);
            nudDataSize.MinimumSize = new Size(100, 0);
            nudDataSize.Name = "nudDataSize";
            nudDataSize.ShowText = false;
            nudDataSize.Size = new Size(120, 26);
            nudDataSize.TabIndex = 22;
            nudDataSize.Text = null;
            nudDataSize.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // nudRate
            // 
            nudRate.Font = new Font("宋体", 12F);
            nudRate.Location = new Point(583, 78);
            nudRate.Margin = new Padding(4, 5, 4, 5);
            nudRate.MinimumSize = new Size(100, 0);
            nudRate.Name = "nudRate";
            nudRate.ShowText = false;
            nudRate.Size = new Size(121, 26);
            nudRate.TabIndex = 23;
            nudRate.Text = null;
            nudRate.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // radHost
            // 
            radHost.Font = new Font("宋体", 12F);
            radHost.Location = new Point(178, 83);
            radHost.MinimumSize = new Size(1, 1);
            radHost.Name = "radHost";
            radHost.Size = new Size(74, 18);
            radHost.TabIndex = 20;
            radHost.Text = "宿端口";
            // 
            // radSource
            // 
            radSource.Font = new Font("宋体", 12F);
            radSource.Location = new Point(90, 83);
            radSource.MinimumSize = new Size(1, 1);
            radSource.Name = "radSource";
            radSource.Size = new Size(74, 18);
            radSource.TabIndex = 21;
            radSource.Text = "源端口";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("宋体", 12F);
            label7.ForeColor = Color.FromArgb(48, 48, 48);
            label7.Location = new Point(273, 83);
            label7.Name = "label7";
            label7.Size = new Size(87, 16);
            label7.TabIndex = 11;
            label7.Text = "数据大小：";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("宋体", 12F);
            label4.ForeColor = Color.FromArgb(48, 48, 48);
            label4.Location = new Point(500, 83);
            label4.Name = "label4";
            label4.Size = new Size(87, 16);
            label4.TabIndex = 12;
            label4.Text = "端口周期：";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPort
            // 
            txtPort.Font = new Font("宋体", 12F);
            txtPort.Location = new Point(811, 78);
            txtPort.Margin = new Padding(4, 5, 4, 5);
            txtPort.MinimumSize = new Size(1, 16);
            txtPort.Name = "txtPort";
            txtPort.Padding = new Padding(5);
            txtPort.ShowText = false;
            txtPort.Size = new Size(124, 26);
            txtPort.TabIndex = 17;
            txtPort.TextAlignment = ContentAlignment.MiddleLeft;
            txtPort.Watermark = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("宋体", 12F);
            label6.ForeColor = Color.FromArgb(48, 48, 48);
            label6.Location = new Point(6, 83);
            label6.Name = "label6";
            label6.Size = new Size(87, 16);
            label6.TabIndex = 13;
            label6.Text = "源宿类型：";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("宋体", 12F);
            label3.ForeColor = Color.FromArgb(48, 48, 48);
            label3.Location = new Point(757, 83);
            label3.Name = "label3";
            label3.Size = new Size(63, 16);
            label3.TabIndex = 14;
            label3.Text = "ComID：";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPortName
            // 
            txtPortName.Font = new Font("宋体", 12F);
            txtPortName.Location = new Point(351, 35);
            txtPortName.Margin = new Padding(4, 5, 4, 5);
            txtPortName.MinimumSize = new Size(1, 16);
            txtPortName.Name = "txtPortName";
            txtPortName.Padding = new Padding(5);
            txtPortName.ShowText = false;
            txtPortName.Size = new Size(353, 26);
            txtPortName.TabIndex = 18;
            txtPortName.TextAlignment = ContentAlignment.MiddleLeft;
            txtPortName.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 12F);
            label2.ForeColor = Color.FromArgb(48, 48, 48);
            label2.Location = new Point(273, 40);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 15;
            label2.Text = "端口名称：";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.FillDisableColor = Color.FromArgb(243, 249, 255);
            txtID.FillReadOnlyColor = Color.FromArgb(243, 249, 255);
            txtID.Font = new Font("宋体", 12F);
            txtID.Location = new Point(712, 118);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.MinimumSize = new Size(1, 16);
            txtID.Name = "txtID";
            txtID.Padding = new Padding(5);
            txtID.ReadOnly = true;
            txtID.RectDisableColor = Color.FromArgb(80, 160, 255);
            txtID.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtID.ShowText = false;
            txtID.Size = new Size(16, 26);
            txtID.TabIndex = 19;
            txtID.TextAlignment = ContentAlignment.MiddleLeft;
            txtID.Visible = false;
            txtID.Watermark = "";
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 30F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 106;
            // 
            // colPortName
            // 
            colPortName.DataPropertyName = "PortName";
            colPortName.FillWeight = 101.827408F;
            colPortName.HeaderText = "端口名称";
            colPortName.Name = "colPortName";
            colPortName.ReadOnly = true;
            colPortName.Width = 124;
            // 
            // colPort
            // 
            colPort.DataPropertyName = "Port";
            colPort.FillWeight = 101.827408F;
            colPort.HeaderText = "ComID";
            colPort.Name = "colPort";
            colPort.ReadOnly = true;
            colPort.Width = 125;
            // 
            // coltrdpno
            // 
            coltrdpno.DataPropertyName = "TRDPNo";
            coltrdpno.FillWeight = 101.827408F;
            coltrdpno.HeaderText = "网关编号";
            coltrdpno.Name = "coltrdpno";
            coltrdpno.ReadOnly = true;
            coltrdpno.Width = 125;
            // 
            // colETHPassage
            // 
            colETHPassage.DataPropertyName = "ETHPassage";
            colETHPassage.FillWeight = 101.827408F;
            colETHPassage.HeaderText = "ETH通道";
            colETHPassage.Name = "colETHPassage";
            colETHPassage.ReadOnly = true;
            colETHPassage.Width = 125;
            // 
            // colRate
            // 
            colRate.DataPropertyName = "Rate";
            colRate.FillWeight = 81.46193F;
            colRate.HeaderText = "端口周期";
            colRate.Name = "colRate";
            colRate.ReadOnly = true;
            colRate.Width = 99;
            // 
            // colIsRead
            // 
            colIsRead.DataPropertyName = "IsRead";
            colIsRead.FillWeight = 101.827408F;
            colIsRead.HeaderText = "源宿类型";
            colIsRead.Name = "colIsRead";
            colIsRead.ReadOnly = true;
            colIsRead.Width = 125;
            // 
            // colDataSize
            // 
            colDataSize.DataPropertyName = "DataSize";
            colDataSize.FillWeight = 101.827408F;
            colDataSize.HeaderText = "数据大小";
            colDataSize.Name = "colDataSize";
            colDataSize.ReadOnly = true;
            colDataSize.Width = 125;
            // 
            // colVerNo
            // 
            colVerNo.DataPropertyName = "VerNo";
            colVerNo.FillWeight = 71.27919F;
            colVerNo.HeaderText = "协议版本";
            colVerNo.Name = "colVerNo";
            colVerNo.ReadOnly = true;
            colVerNo.Width = 87;
            // 
            // frmPortManager
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1044, 553);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPortManager";
            Padding = new Padding(0, 29, 0, 0);
            ShowIcon = false;
            Text = "TRDP协议编辑";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 921, 510);
            Load += frmPortManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView dataGridView1;
        private Sunny.UI.UIGroupBox groupBox1;
        private Sunny.UI.UIContextMenuStrip contextMenuStrip1;
        private Sunny.UI.UILabel label5;
        private Sunny.UI.UIButton btnDelPort;
        private Sunny.UI.UIButton btnAddPort;
        private Sunny.UI.UIButton btnModify;
        private Sunny.UI.UIIntegerUpDown nudDataSize;
        private Sunny.UI.UIIntegerUpDown nudRate;
        private Sunny.UI.UIRadioButton radHost;
        private Sunny.UI.UIRadioButton radSource;
        private Sunny.UI.UILabel label7;
        private Sunny.UI.UILabel label4;
        private Sunny.UI.UITextBox txtPort;
        private Sunny.UI.UILabel label6;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UITextBox txtPortName;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UITextBox txtID;
        private Sunny.UI.UIComboBox cboModelName;
        private Sunny.UI.UILabel label8;
        private System.Windows.Forms.ToolStripMenuItem 设置为默认版本ToolStripMenuItem;
        private Sunny.UI.UIComboBox txtVerno;
        private Sunny.UI.UIButton btnAddVerno;
        private Sunny.UI.UIComboBox cboETHNo;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UIButton button1;
        private Sunny.UI.UIComboBox cbotrdpno;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UIButton button2;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colPortName;
        private DataGridViewTextBoxColumn colPort;
        private DataGridViewTextBoxColumn coltrdpno;
        private DataGridViewTextBoxColumn colETHPassage;
        private DataGridViewTextBoxColumn colRate;
        private DataGridViewTextBoxColumn colIsRead;
        private DataGridViewTextBoxColumn colDataSize;
        private DataGridViewTextBoxColumn colVerNo;
    }
}