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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView1 = new Sunny.UI.UIDataGridView();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            coltrdpno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colETHPassage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIsRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDataSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colVerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            contextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            设置为默认版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1 = new Sunny.UI.UIGroupBox();
            button2 = new Sunny.UI.UIButton();
            cbotrdpno = new Sunny.UI.UIComboBox();
            label9 = new Sunny.UI.UILabel();
            button1 = new Sunny.UI.UIButton();
            cboETHNo = new Sunny.UI.UIComboBox();
            label10 = new Sunny.UI.UILabel();
            btnAddVerno = new Sunny.UI.UIButton();
            txtVerno = new Sunny.UI.UIComboBox();
            label8 = new Sunny.UI.UILabel();
            cboModelName = new Sunny.UI.UIComboBox();
            label5 = new Sunny.UI.UILabel();
            btnDelPort = new Sunny.UI.UIButton();
            btnAddPort = new Sunny.UI.UIButton();
            btnModify = new Sunny.UI.UIButton();
            nudDataSize = new Sunny.UI.UIIntegerUpDown();
            nudRate = new Sunny.UI.UIIntegerUpDown();
            radHost = new Sunny.UI.UIRadioButton();
            radSource = new Sunny.UI.UIRadioButton();
            label7 = new Sunny.UI.UILabel();
            label4 = new Sunny.UI.UILabel();
            txtPort = new Sunny.UI.UITextBox();
            label6 = new Sunny.UI.UILabel();
            label3 = new Sunny.UI.UILabel();
            txtPortName = new Sunny.UI.UITextBox();
            label2 = new Sunny.UI.UILabel();
            txtID = new Sunny.UI.UITextBox();
            label1 = new Sunny.UI.UILabel();
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
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colID, colPortName, coltrdpno, colETHPassage, colPort, colRate, colIsRead, colDataSize, colVerNo });
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
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
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(1044, 364);
            dataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(235, 243, 255);
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
            // coltrdpno
            // 
            coltrdpno.DataPropertyName = "TRDPNo";
            coltrdpno.HeaderText = "网关编号";
            coltrdpno.Name = "coltrdpno";
            coltrdpno.ReadOnly = true;
            // 
            // colETHPassage
            // 
            colETHPassage.DataPropertyName = "ETHPassage";
            colETHPassage.HeaderText = "ETH通道";
            colETHPassage.Name = "colETHPassage";
            colETHPassage.ReadOnly = true;
            // 
            // colPort
            // 
            colPort.DataPropertyName = "Port";
            colPort.HeaderText = "ComID";
            colPort.Name = "colPort";
            colPort.ReadOnly = true;
            // 
            // colRate
            // 
            colRate.DataPropertyName = "Rate";
            colRate.FillWeight = 80F;
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
            // colVerNo
            // 
            colVerNo.DataPropertyName = "VerNo";
            colVerNo.FillWeight = 70F;
            colVerNo.HeaderText = "协议版本";
            colVerNo.Name = "colVerNo";
            colVerNo.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            contextMenuStrip1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 设置为默认版本ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(187, 26);
            // 
            // 设置为默认版本ToolStripMenuItem
            // 
            设置为默认版本ToolStripMenuItem.Image = Properties.Resources.Green;
            设置为默认版本ToolStripMenuItem.Name = "设置为默认版本ToolStripMenuItem";
            设置为默认版本ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
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
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(0, 394);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            groupBox1.Size = new System.Drawing.Size(1044, 147);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "编辑栏";
            groupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(339, 106);
            button2.MinimumSize = new System.Drawing.Size(1, 1);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 27);
            button2.TabIndex = 40;
            button2.Text = "Excel导入";
            button2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Click += button2_Click;
            // 
            // cbotrdpno
            // 
            cbotrdpno.DataSource = null;
            cbotrdpno.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbotrdpno.FillColor = System.Drawing.Color.White;
            cbotrdpno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbotrdpno.FormattingEnabled = true;
            cbotrdpno.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cbotrdpno.Items.AddRange(new object[] { "1", "2" });
            cbotrdpno.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            cbotrdpno.Location = new System.Drawing.Point(583, 110);
            cbotrdpno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbotrdpno.MinimumSize = new System.Drawing.Size(63, 0);
            cbotrdpno.Name = "cbotrdpno";
            cbotrdpno.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cbotrdpno.Size = new System.Drawing.Size(121, 24);
            cbotrdpno.SymbolSize = 24;
            cbotrdpno.TabIndex = 39;
            cbotrdpno.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            cbotrdpno.Watermark = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label9.Location = new System.Drawing.Point(500, 114);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 16);
            label9.TabIndex = 38;
            label9.Text = "网关编号：";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(176, 106);
            button1.MinimumSize = new System.Drawing.Size(1, 1);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(138, 27);
            button1.TabIndex = 37;
            button1.Text = "以太网参数编辑";
            button1.Click += button1_Click;
            // 
            // cboETHNo
            // 
            cboETHNo.DataSource = null;
            cboETHNo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboETHNo.FillColor = System.Drawing.Color.White;
            cboETHNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboETHNo.FormattingEnabled = true;
            cboETHNo.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cboETHNo.Items.AddRange(new object[] { "1", "2" });
            cboETHNo.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            cboETHNo.Location = new System.Drawing.Point(811, 110);
            cboETHNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cboETHNo.MinimumSize = new System.Drawing.Size(63, 0);
            cboETHNo.Name = "cboETHNo";
            cboETHNo.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cboETHNo.Size = new System.Drawing.Size(124, 24);
            cboETHNo.SymbolSize = 24;
            cboETHNo.TabIndex = 36;
            cboETHNo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            cboETHNo.Watermark = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label10.Location = new System.Drawing.Point(741, 114);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(79, 16);
            label10.TabIndex = 35;
            label10.Text = "ETH通道：";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddVerno
            // 
            btnAddVerno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddVerno.Location = new System.Drawing.Point(14, 106);
            btnAddVerno.MinimumSize = new System.Drawing.Size(1, 1);
            btnAddVerno.Name = "btnAddVerno";
            btnAddVerno.Size = new System.Drawing.Size(137, 27);
            btnAddVerno.TabIndex = 34;
            btnAddVerno.Text = "协议版本编辑";
            btnAddVerno.Click += btnAddVerno_Click;
            // 
            // txtVerno
            // 
            txtVerno.DataSource = null;
            txtVerno.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            txtVerno.FillColor = System.Drawing.Color.White;
            txtVerno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtVerno.FormattingEnabled = true;
            txtVerno.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            txtVerno.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            txtVerno.Location = new System.Drawing.Point(354, 36);
            txtVerno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtVerno.MinimumSize = new System.Drawing.Size(63, 0);
            txtVerno.Name = "txtVerno";
            txtVerno.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            txtVerno.Size = new System.Drawing.Size(162, 24);
            txtVerno.SymbolSize = 24;
            txtVerno.TabIndex = 33;
            txtVerno.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtVerno.Watermark = "";
            txtVerno.SelectedIndexChanged += txtVerno_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label8.Location = new System.Drawing.Point(275, 41);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(87, 16);
            label8.TabIndex = 29;
            label8.Text = "协议版本：";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboModelName
            // 
            cboModelName.DataSource = null;
            cboModelName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboModelName.FillColor = System.Drawing.Color.White;
            cboModelName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboModelName.FormattingEnabled = true;
            cboModelName.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cboModelName.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            cboModelName.Location = new System.Drawing.Point(93, 35);
            cboModelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cboModelName.MinimumSize = new System.Drawing.Size(63, 0);
            cboModelName.Name = "cboModelName";
            cboModelName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cboModelName.Size = new System.Drawing.Size(162, 24);
            cboModelName.SymbolSize = 24;
            cboModelName.TabIndex = 28;
            cboModelName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            cboModelName.Watermark = "";
            cboModelName.SelectedIndexChanged += cboModelName_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label5.Location = new System.Drawing.Point(6, 40);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 16);
            label5.TabIndex = 27;
            label5.Text = "型号名称：";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelPort
            // 
            btnDelPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelPort.Location = new System.Drawing.Point(949, 108);
            btnDelPort.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelPort.Name = "btnDelPort";
            btnDelPort.Size = new System.Drawing.Size(80, 27);
            btnDelPort.TabIndex = 26;
            btnDelPort.Text = "删除";
            btnDelPort.Click += btnDelPort_Click;
            // 
            // btnAddPort
            // 
            btnAddPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddPort.Location = new System.Drawing.Point(949, 35);
            btnAddPort.MinimumSize = new System.Drawing.Size(1, 1);
            btnAddPort.Name = "btnAddPort";
            btnAddPort.Size = new System.Drawing.Size(80, 27);
            btnAddPort.TabIndex = 25;
            btnAddPort.Text = "增加";
            btnAddPort.Click += btnAddPort_Click;
            // 
            // btnModify
            // 
            btnModify.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnModify.Location = new System.Drawing.Point(949, 71);
            btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            btnModify.Name = "btnModify";
            btnModify.Size = new System.Drawing.Size(80, 27);
            btnModify.TabIndex = 24;
            btnModify.Text = "修改";
            btnModify.Click += btnModify_Click;
            // 
            // nudDataSize
            // 
            nudDataSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nudDataSize.Location = new System.Drawing.Point(354, 70);
            nudDataSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            nudDataSize.MinimumSize = new System.Drawing.Size(100, 0);
            nudDataSize.Name = "nudDataSize";
            nudDataSize.ShowText = false;
            nudDataSize.Size = new System.Drawing.Size(110, 26);
            nudDataSize.TabIndex = 22;
            nudDataSize.Text = null;
            nudDataSize.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudRate
            // 
            nudRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nudRate.Location = new System.Drawing.Point(583, 70);
            nudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            nudRate.MinimumSize = new System.Drawing.Size(100, 0);
            nudRate.Name = "nudRate";
            nudRate.ShowText = false;
            nudRate.Size = new System.Drawing.Size(116, 26);
            nudRate.TabIndex = 23;
            nudRate.Text = null;
            nudRate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radHost
            // 
            radHost.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radHost.Location = new System.Drawing.Point(178, 72);
            radHost.MinimumSize = new System.Drawing.Size(1, 1);
            radHost.Name = "radHost";
            radHost.Size = new System.Drawing.Size(74, 18);
            radHost.TabIndex = 20;
            radHost.Text = "宿端口";
            // 
            // radSource
            // 
            radSource.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radSource.Location = new System.Drawing.Point(90, 73);
            radSource.MinimumSize = new System.Drawing.Size(1, 1);
            radSource.Name = "radSource";
            radSource.Size = new System.Drawing.Size(74, 18);
            radSource.TabIndex = 21;
            radSource.Text = "源端口";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label7.Location = new System.Drawing.Point(273, 75);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 16);
            label7.TabIndex = 11;
            label7.Text = "数据大小：";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label4.Location = new System.Drawing.Point(500, 75);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 16);
            label4.TabIndex = 12;
            label4.Text = "端口周期：";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPort
            // 
            txtPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPort.Location = new System.Drawing.Point(811, 72);
            txtPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPort.MinimumSize = new System.Drawing.Size(1, 16);
            txtPort.Name = "txtPort";
            txtPort.Padding = new System.Windows.Forms.Padding(5);
            txtPort.ShowText = false;
            txtPort.Size = new System.Drawing.Size(124, 26);
            txtPort.TabIndex = 17;
            txtPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtPort.Watermark = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label6.Location = new System.Drawing.Point(6, 75);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 16);
            label6.TabIndex = 13;
            label6.Text = "源宿类型：";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label3.Location = new System.Drawing.Point(757, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 16);
            label3.TabIndex = 14;
            label3.Text = "ComID：";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPortName
            // 
            txtPortName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPortName.Location = new System.Drawing.Point(811, 36);
            txtPortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPortName.MinimumSize = new System.Drawing.Size(1, 16);
            txtPortName.Name = "txtPortName";
            txtPortName.Padding = new System.Windows.Forms.Padding(5);
            txtPortName.ShowText = false;
            txtPortName.Size = new System.Drawing.Size(124, 26);
            txtPortName.TabIndex = 18;
            txtPortName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtPortName.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label2.Location = new System.Drawing.Point(733, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 16);
            label2.TabIndex = 15;
            label2.Text = "端口名称：";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.FillDisableColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtID.FillReadOnlyColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtID.Location = new System.Drawing.Point(583, 36);
            txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtID.MinimumSize = new System.Drawing.Size(1, 16);
            txtID.Name = "txtID";
            txtID.Padding = new System.Windows.Forms.Padding(5);
            txtID.ReadOnly = true;
            txtID.RectDisableColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtID.RectReadOnlyColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtID.ShowText = false;
            txtID.Size = new System.Drawing.Size(116, 26);
            txtID.TabIndex = 19;
            txtID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtID.Watermark = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label1.Location = new System.Drawing.Point(548, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 16);
            label1.TabIndex = 16;
            label1.Text = "ID：";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPortManager
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1044, 541);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPortManager";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            ShowIcon = false;
            Text = "TRDP协议编辑";
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 921, 510);
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
        private Sunny.UI.UILabel label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrdpno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colETHPassage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerNo;
        private Sunny.UI.UIButton button2;
    }
}