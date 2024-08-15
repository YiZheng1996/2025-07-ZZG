using Sunny.UI;
namespace MainUI.CAN
{
    partial class frmCANPortManager
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
            dataGridView1 = new UIDataGridView();
            colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colIsRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDataSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1 = new UIGroupBox();
            btnExcel = new UIButton();
            txtPortName = new UITextBox();
            cboModelName = new UIComboBox();
            label5 = new UILabel();
            btnDelPort = new UIButton();
            txtID = new UITextBox();
            btnAddPort = new UIButton();
            btnModify = new UIButton();
            label2 = new UILabel();
            nudDataSize = new UIIntegerUpDown();
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
            nudDataSize.SuspendLayout();
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
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(243, 249, 255);
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
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colID, colPortName, colPort, colRate, colIsRead, colDataSize });
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
            dataGridView1.Size = new System.Drawing.Size(973, 366);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(txtPortName);
            groupBox1.Controls.Add(cboModelName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnDelPort);
            groupBox1.Controls.Add(btnAddPort);
            groupBox1.Controls.Add(btnModify);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nudDataSize);
            groupBox1.Controls.Add(nudRate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(radHost);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radSource);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(0, 397);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            groupBox1.Size = new System.Drawing.Size(973, 157);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "编辑栏";
            groupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExcel
            // 
            btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExcel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExcel.Location = new System.Drawing.Point(859, 101);
            btnExcel.MinimumSize = new System.Drawing.Size(1, 1);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new System.Drawing.Size(91, 30);
            btnExcel.TabIndex = 32;
            btnExcel.Text = "Excel导入";
            btnExcel.Click += btnExcel_Click;
            // 
            // txtPortName
            // 
            txtPortName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPortName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPortName.Location = new System.Drawing.Point(371, 49);
            txtPortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPortName.MinimumSize = new System.Drawing.Size(1, 16);
            txtPortName.Name = "txtPortName";
            txtPortName.Padding = new System.Windows.Forms.Padding(5);
            txtPortName.ShowText = false;
            txtPortName.Size = new System.Drawing.Size(127, 26);
            txtPortName.TabIndex = 2;
            txtPortName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtPortName.Watermark = "";
            // 
            // cboModelName
            // 
            cboModelName.DataSource = null;
            cboModelName.DropDownStyle = UIDropDownStyle.DropDownList;
            cboModelName.FillColor = System.Drawing.Color.White;
            cboModelName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboModelName.FormattingEnabled = true;
            cboModelName.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cboModelName.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            cboModelName.Location = new System.Drawing.Point(112, 51);
            cboModelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cboModelName.MinimumSize = new System.Drawing.Size(63, 0);
            cboModelName.Name = "cboModelName";
            cboModelName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cboModelName.Size = new System.Drawing.Size(144, 24);
            cboModelName.SymbolSize = 24;
            cboModelName.TabIndex = 30;
            cboModelName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            cboModelName.Watermark = "";
            cboModelName.SelectedIndexChanged += cboModelName_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label5.Location = new System.Drawing.Point(25, 56);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 16);
            label5.TabIndex = 29;
            label5.Text = "型号名称：";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelPort
            // 
            btnDelPort.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelPort.Location = new System.Drawing.Point(750, 101);
            btnDelPort.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelPort.Name = "btnDelPort";
            btnDelPort.Size = new System.Drawing.Size(91, 30);
            btnDelPort.TabIndex = 10;
            btnDelPort.Text = "删除";
            btnDelPort.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelPort.Click += btnDelPort_Click;
            // 
            // txtID
            // 
            txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtID.FillDisableColor = System.Drawing.Color.White;
            txtID.FillReadOnlyColor = System.Drawing.Color.White;
            txtID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtID.Location = new System.Drawing.Point(42, 5);
            txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtID.MinimumSize = new System.Drawing.Size(1, 16);
            txtID.Name = "txtID";
            txtID.Padding = new System.Windows.Forms.Padding(5);
            txtID.Radius = 1;
            txtID.ReadOnly = true;
            txtID.RectDisableColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtID.RectReadOnlyColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtID.ShowText = false;
            txtID.Size = new System.Drawing.Size(1, 16);
            txtID.TabIndex = 2;
            txtID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtID.Visible = false;
            txtID.Watermark = "";
            // 
            // btnAddPort
            // 
            btnAddPort.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddPort.Location = new System.Drawing.Point(750, 51);
            btnAddPort.MinimumSize = new System.Drawing.Size(1, 1);
            btnAddPort.Name = "btnAddPort";
            btnAddPort.Size = new System.Drawing.Size(91, 30);
            btnAddPort.TabIndex = 9;
            btnAddPort.Text = "增加";
            btnAddPort.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddPort.Click += btnAddPort_Click;
            // 
            // btnModify
            // 
            btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModify.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnModify.Location = new System.Drawing.Point(859, 51);
            btnModify.MinimumSize = new System.Drawing.Size(1, 1);
            btnModify.Name = "btnModify";
            btnModify.Size = new System.Drawing.Size(91, 30);
            btnModify.TabIndex = 6;
            btnModify.Text = "修改";
            btnModify.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnModify.Click += btnModify_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label2.Location = new System.Drawing.Point(293, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 16);
            label2.TabIndex = 1;
            label2.Text = "端口名称:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudDataSize
            // 
            nudDataSize.Controls.Add(txtID);
            nudDataSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nudDataSize.Location = new System.Drawing.Point(371, 101);
            nudDataSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            nudDataSize.MinimumSize = new System.Drawing.Size(100, 0);
            nudDataSize.Name = "nudDataSize";
            nudDataSize.ShowText = false;
            nudDataSize.Size = new System.Drawing.Size(127, 26);
            nudDataSize.TabIndex = 5;
            nudDataSize.Text = null;
            nudDataSize.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudRate
            // 
            nudRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nudRate.Location = new System.Drawing.Point(614, 101);
            nudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            nudRate.MinimumSize = new System.Drawing.Size(100, 0);
            nudRate.Name = "nudRate";
            nudRate.ShowText = false;
            nudRate.Size = new System.Drawing.Size(111, 26);
            nudRate.TabIndex = 5;
            nudRate.Text = null;
            nudRate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label3.Location = new System.Drawing.Point(533, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 16);
            label3.TabIndex = 1;
            label3.Text = "端口地址:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radHost
            // 
            radHost.Cursor = System.Windows.Forms.Cursors.Hand;
            radHost.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radHost.Location = new System.Drawing.Point(199, 105);
            radHost.MinimumSize = new System.Drawing.Size(1, 1);
            radHost.Name = "radHost";
            radHost.Size = new System.Drawing.Size(75, 18);
            radHost.TabIndex = 4;
            radHost.Text = "宿端口";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label6.Location = new System.Drawing.Point(29, 105);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(87, 16);
            label6.TabIndex = 1;
            label6.Text = "源宿类型：";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radSource
            // 
            radSource.Cursor = System.Windows.Forms.Cursors.Hand;
            radSource.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radSource.Location = new System.Drawing.Point(116, 104);
            radSource.MinimumSize = new System.Drawing.Size(1, 1);
            radSource.Name = "radSource";
            radSource.Size = new System.Drawing.Size(75, 18);
            radSource.TabIndex = 4;
            radSource.Text = "源端口";
            // 
            // txtPort
            // 
            txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPort.Location = new System.Drawing.Point(614, 49);
            txtPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPort.MinimumSize = new System.Drawing.Size(1, 16);
            txtPort.Name = "txtPort";
            txtPort.Padding = new System.Windows.Forms.Padding(5);
            txtPort.ShowText = false;
            txtPort.Size = new System.Drawing.Size(111, 26);
            txtPort.TabIndex = 2;
            txtPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtPort.Watermark = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label7.Location = new System.Drawing.Point(293, 107);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 16);
            label7.TabIndex = 1;
            label7.Text = "数据大小：";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label4.Location = new System.Drawing.Point(530, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 16);
            label4.TabIndex = 1;
            label4.Text = "端口周期：";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCANPortManager
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(973, 554);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCANPortManager";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "CAN参数设置";
            TextAlignment = System.Drawing.StringAlignment.Center;
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 798, 510);
            Load += frmPortManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            nudDataSize.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UIDataGridView dataGridView1;
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
        private UITextBox txtID;
        private UIButton btnExcel;
    }
}