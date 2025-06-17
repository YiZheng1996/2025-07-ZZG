namespace MainUI.CAN
{
    partial class frmAnalysis
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
            uiDataGridView = new UIDataGridView();
            ColSeq = new DataGridViewTextBoxColumn();
            ColTime = new DataGridViewTextBoxColumn();
            ColdifferTime = new DataGridViewTextBoxColumn();
            ColCANInd = new DataGridViewTextBoxColumn();
            ColOrentation = new DataGridViewTextBoxColumn();
            ColID = new DataGridViewTextBoxColumn();
            ColFrame = new DataGridViewTextBoxColumn();
            ColType = new DataGridViewTextBoxColumn();
            ColDLC = new DataGridViewTextBoxColumn();
            ColDATA = new DataGridViewTextBoxColumn();
            label1 = new Label();
            uiSymbolButton = new UISymbolButton();
            btnSeek = new UIButton();
            btnClose = new UIButton();
            uiGroupBox = new UIGroupBox();
            btnAllDisplay = new UIButton();
            txtCANID = new UITextBox();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView).BeginInit();
            uiGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // uiDataGridView
            // 
            uiDataGridView.AllowUserToAddRows = false;
            uiDataGridView.AllowUserToDeleteRows = false;
            uiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(243, 249, 255);
            uiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("宋体", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView.ColumnHeadersHeight = 32;
            uiDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColSeq, ColTime, ColdifferTime, ColCANInd, ColOrentation, ColID, ColFrame, ColType, ColDLC, ColDATA });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("宋体", 12F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView.Dock = DockStyle.Fill;
            uiDataGridView.EnableHeadersVisualStyles = false;
            uiDataGridView.Font = new Font("宋体", 12F);
            uiDataGridView.GridColor = Color.FromArgb(104, 173, 255);
            uiDataGridView.Location = new Point(0, 32);
            uiDataGridView.Name = "uiDataGridView";
            uiDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle9.Font = new Font("宋体", 12F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            uiDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("宋体", 12F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(48, 48, 48);
            uiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView.RowTemplate.Height = 27;
            uiDataGridView.ScrollBarBackColor = Color.FromArgb(238, 251, 250);
            uiDataGridView.ScrollBarColor = Color.FromArgb(104, 173, 255);
            uiDataGridView.ScrollBarRectColor = Color.FromArgb(104, 173, 255);
            uiDataGridView.ScrollBarStyleInherited = false;
            uiDataGridView.SelectedIndex = -1;
            uiDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView.Size = new Size(1067, 520);
            uiDataGridView.Style = UIStyle.Custom;
            uiDataGridView.TabIndex = 0;
            // 
            // ColSeq
            // 
            ColSeq.DataPropertyName = "Seq";
            ColSeq.HeaderText = "序号";
            ColSeq.Name = "ColSeq";
            ColSeq.ReadOnly = true;
            ColSeq.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColSeq.Width = 50;
            // 
            // ColTime
            // 
            ColTime.DataPropertyName = "Time";
            ColTime.HeaderText = "时间";
            ColTime.Name = "ColTime";
            ColTime.ReadOnly = true;
            ColTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColTime.Width = 120;
            // 
            // ColdifferTime
            // 
            ColdifferTime.DataPropertyName = "differTime";
            ColdifferTime.HeaderText = "时间差";
            ColdifferTime.Name = "ColdifferTime";
            ColdifferTime.ReadOnly = true;
            ColdifferTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColdifferTime.Width = 120;
            // 
            // ColCANInd
            // 
            ColCANInd.DataPropertyName = "CANInd";
            ColCANInd.HeaderText = "通道";
            ColCANInd.Name = "ColCANInd";
            ColCANInd.ReadOnly = true;
            ColCANInd.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColCANInd.Width = 70;
            // 
            // ColOrentation
            // 
            ColOrentation.DataPropertyName = "Orentation";
            ColOrentation.HeaderText = "方向";
            ColOrentation.Name = "ColOrentation";
            ColOrentation.ReadOnly = true;
            ColOrentation.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColID
            // 
            ColID.DataPropertyName = "ID";
            ColID.HeaderText = "ID号";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColID.Width = 70;
            // 
            // ColFrame
            // 
            ColFrame.DataPropertyName = "Frame";
            ColFrame.HeaderText = "帧类型";
            ColFrame.Name = "ColFrame";
            ColFrame.ReadOnly = true;
            ColFrame.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColType
            // 
            ColType.DataPropertyName = "Type";
            ColType.HeaderText = "帧格式";
            ColType.Name = "ColType";
            ColType.ReadOnly = true;
            ColType.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDLC
            // 
            ColDLC.DataPropertyName = "DLC";
            ColDLC.HeaderText = "长度";
            ColDLC.Name = "ColDLC";
            ColDLC.ReadOnly = true;
            ColDLC.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColDLC.Width = 70;
            // 
            // ColDATA
            // 
            ColDATA.DataPropertyName = "DATA";
            ColDATA.HeaderText = "数据";
            ColDATA.Name = "ColDATA";
            ColDATA.ReadOnly = true;
            ColDATA.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColDATA.Width = 258;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 2;
            label1.Text = "ID号：";
            // 
            // uiSymbolButton
            // 
            uiSymbolButton.Cursor = Cursors.Hand;
            uiSymbolButton.Font = new Font("宋体", 12F);
            uiSymbolButton.Location = new Point(807, 40);
            uiSymbolButton.MinimumSize = new Size(1, 1);
            uiSymbolButton.Name = "uiSymbolButton";
            uiSymbolButton.Size = new Size(221, 35);
            uiSymbolButton.Style = UIStyle.Custom;
            uiSymbolButton.Symbol = 61717;
            uiSymbolButton.TabIndex = 4;
            uiSymbolButton.Text = "选择文件夹";
            uiSymbolButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSymbolButton.Click += uiSymbolButton_Click;
            // 
            // btnSeek
            // 
            btnSeek.Cursor = Cursors.Hand;
            btnSeek.Font = new Font("宋体", 12F);
            btnSeek.Location = new Point(461, 40);
            btnSeek.MinimumSize = new Size(1, 1);
            btnSeek.Name = "btnSeek";
            btnSeek.Size = new Size(107, 35);
            btnSeek.Style = UIStyle.Custom;
            btnSeek.TabIndex = 5;
            btnSeek.Text = "查 询";
            btnSeek.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSeek.Click += btnSeek_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FillColor = Color.FromArgb(230, 80, 80);
            btnClose.Font = new Font("宋体", 12F);
            btnClose.Location = new Point(460, 642);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = Color.FromArgb(230, 80, 80);
            btnClose.Size = new Size(154, 35);
            btnClose.TabIndex = 6;
            btnClose.Text = "退 出";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += btnClose_Click;
            // 
            // uiGroupBox
            // 
            uiGroupBox.Controls.Add(uiDataGridView);
            uiGroupBox.Font = new Font("宋体", 12F);
            uiGroupBox.Location = new Point(4, 82);
            uiGroupBox.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox.MinimumSize = new Size(1, 1);
            uiGroupBox.Name = "uiGroupBox";
            uiGroupBox.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox.Size = new Size(1067, 552);
            uiGroupBox.Style = UIStyle.Custom;
            uiGroupBox.TabIndex = 7;
            uiGroupBox.Text = null;
            uiGroupBox.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // btnAllDisplay
            // 
            btnAllDisplay.Cursor = Cursors.Hand;
            btnAllDisplay.Font = new Font("宋体", 12F);
            btnAllDisplay.Location = new Point(610, 39);
            btnAllDisplay.MinimumSize = new Size(1, 1);
            btnAllDisplay.Name = "btnAllDisplay";
            btnAllDisplay.Size = new Size(107, 35);
            btnAllDisplay.Style = UIStyle.Custom;
            btnAllDisplay.TabIndex = 8;
            btnAllDisplay.Text = "显示全部";
            btnAllDisplay.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAllDisplay.Click += btnAllDisplay_Click;
            // 
            // txtCANID
            // 
            txtCANID.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCANID.Location = new Point(292, 43);
            txtCANID.Margin = new Padding(4, 5, 4, 5);
            txtCANID.MinimumSize = new Size(1, 16);
            txtCANID.Name = "txtCANID";
            txtCANID.Padding = new Padding(5);
            txtCANID.ShowText = false;
            txtCANID.Size = new Size(150, 29);
            txtCANID.TabIndex = 9;
            txtCANID.TextAlignment = ContentAlignment.MiddleLeft;
            txtCANID.Watermark = "请输入ID号";
            // 
            // frmAnalysis
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1075, 689);
            ControlBox = false;
            Controls.Add(txtCANID);
            Controls.Add(btnAllDisplay);
            Controls.Add(uiGroupBox);
            Controls.Add(btnClose);
            Controls.Add(btnSeek);
            Controls.Add(uiSymbolButton);
            Controls.Add(label1);
            EscClose = true;
            Font = new Font("宋体", 12F, FontStyle.Bold);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAnalysis";
            Padding = new Padding(0, 29, 0, 0);
            ShowIcon = false;
            ShowInTaskbar = false;
            Style = UIStyle.Custom;
            Text = "CAN数据分析";
            TextAlignment = StringAlignment.Center;
            TitleFont = new Font("宋体", 12F, FontStyle.Bold);
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 800, 480);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView).EndInit();
            uiGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UISymbolButton uiSymbolButton;
        private Sunny.UI.UIButton btnSeek;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIGroupBox uiGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColdifferTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCANInd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFrame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDLC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDATA;
        private Sunny.UI.UIButton btnAllDisplay;
        private UITextBox txtCANID;
    }
}