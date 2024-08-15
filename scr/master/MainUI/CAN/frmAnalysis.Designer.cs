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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            uiDataGridView = new Sunny.UI.UIDataGridView();
            ColSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColdifferTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColCANInd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColOrentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColDLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColDATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            uiIntegerUpDown = new Sunny.UI.UIIntegerUpDown();
            uiSymbolButton = new Sunny.UI.UISymbolButton();
            btnSeek = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            uiGroupBox = new Sunny.UI.UIGroupBox();
            btnAllDisplay = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView).BeginInit();
            uiGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // uiDataGridView
            // 
            uiDataGridView.AllowUserToAddRows = false;
            uiDataGridView.AllowUserToDeleteRows = false;
            uiDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(238, 251, 250);
            uiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(238, 251, 250);
            uiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(0, 190, 172);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(0, 190, 172);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            uiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView.ColumnHeadersHeight = 32;
            uiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColSeq, ColTime, ColdifferTime, ColCANInd, ColOrentation, ColID, ColFrame, ColType, ColDLC, ColDATA });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(204, 242, 238);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            uiDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            uiDataGridView.EnableHeadersVisualStyles = false;
            uiDataGridView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiDataGridView.GridColor = System.Drawing.Color.FromArgb(34, 199, 183);
            uiDataGridView.Location = new System.Drawing.Point(0, 32);
            uiDataGridView.Name = "uiDataGridView";
            uiDataGridView.ReadOnly = true;
            uiDataGridView.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(238, 251, 250);
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(0, 190, 172);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            uiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            uiDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(204, 242, 238);
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView.RowTemplate.Height = 27;
            uiDataGridView.ScrollBarBackColor = System.Drawing.Color.FromArgb(238, 251, 250);
            uiDataGridView.ScrollBarColor = System.Drawing.Color.FromArgb(0, 190, 172);
            uiDataGridView.ScrollBarRectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            uiDataGridView.SelectedIndex = -1;
            uiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView.Size = new System.Drawing.Size(1067, 520);
            uiDataGridView.StripeOddColor = System.Drawing.Color.FromArgb(238, 251, 250);
            uiDataGridView.Style = Sunny.UI.UIStyle.Custom;
            uiDataGridView.TabIndex = 0;
            // 
            // ColSeq
            // 
            ColSeq.DataPropertyName = "Seq";
            ColSeq.HeaderText = "序号";
            ColSeq.Name = "ColSeq";
            ColSeq.ReadOnly = true;
            ColSeq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColSeq.Width = 50;
            // 
            // ColTime
            // 
            ColTime.DataPropertyName = "Time";
            ColTime.HeaderText = "时间";
            ColTime.Name = "ColTime";
            ColTime.ReadOnly = true;
            ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColTime.Width = 120;
            // 
            // ColdifferTime
            // 
            ColdifferTime.DataPropertyName = "differTime";
            ColdifferTime.HeaderText = "时间差";
            ColdifferTime.Name = "ColdifferTime";
            ColdifferTime.ReadOnly = true;
            ColdifferTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColdifferTime.Width = 120;
            // 
            // ColCANInd
            // 
            ColCANInd.DataPropertyName = "CANInd";
            ColCANInd.HeaderText = "通道";
            ColCANInd.Name = "ColCANInd";
            ColCANInd.ReadOnly = true;
            ColCANInd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColCANInd.Width = 70;
            // 
            // ColOrentation
            // 
            ColOrentation.DataPropertyName = "Orentation";
            ColOrentation.HeaderText = "方向";
            ColOrentation.Name = "ColOrentation";
            ColOrentation.ReadOnly = true;
            ColOrentation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColID
            // 
            ColID.DataPropertyName = "ID";
            ColID.HeaderText = "ID号";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColID.Width = 70;
            // 
            // ColFrame
            // 
            ColFrame.DataPropertyName = "Frame";
            ColFrame.HeaderText = "帧类型";
            ColFrame.Name = "ColFrame";
            ColFrame.ReadOnly = true;
            ColFrame.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColType
            // 
            ColType.DataPropertyName = "Type";
            ColType.HeaderText = "帧格式";
            ColType.Name = "ColType";
            ColType.ReadOnly = true;
            ColType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDLC
            // 
            ColDLC.DataPropertyName = "DLC";
            ColDLC.HeaderText = "长度";
            ColDLC.Name = "ColDLC";
            ColDLC.ReadOnly = true;
            ColDLC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColDLC.Width = 70;
            // 
            // ColDATA
            // 
            ColDATA.DataPropertyName = "DATA";
            ColDATA.HeaderText = "数据";
            ColDATA.Name = "ColDATA";
            ColDATA.ReadOnly = true;
            ColDATA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ColDATA.Width = 258;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(236, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 16);
            label1.TabIndex = 2;
            label1.Text = "ID号：";
            // 
            // uiIntegerUpDown
            // 
            uiIntegerUpDown.ButtonFillColor = System.Drawing.Color.FromArgb(0, 190, 172);
            uiIntegerUpDown.ButtonFillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            uiIntegerUpDown.ButtonFillPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            uiIntegerUpDown.ButtonRectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            uiIntegerUpDown.FillColor = System.Drawing.Color.FromArgb(238, 251, 250);
            uiIntegerUpDown.FillColor2 = System.Drawing.Color.FromArgb(238, 251, 250);
            uiIntegerUpDown.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiIntegerUpDown.Location = new System.Drawing.Point(293, 43);
            uiIntegerUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiIntegerUpDown.MinimumSize = new System.Drawing.Size(100, 0);
            uiIntegerUpDown.Name = "uiIntegerUpDown";
            uiIntegerUpDown.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            uiIntegerUpDown.ShowText = false;
            uiIntegerUpDown.Size = new System.Drawing.Size(134, 29);
            uiIntegerUpDown.Style = Sunny.UI.UIStyle.Custom;
            uiIntegerUpDown.TabIndex = 3;
            uiIntegerUpDown.Text = "uiIntegerUpDown1";
            uiIntegerUpDown.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButton
            // 
            uiSymbolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            uiSymbolButton.FillColor = System.Drawing.Color.FromArgb(0, 190, 172);
            uiSymbolButton.FillColor2 = System.Drawing.Color.FromArgb(0, 190, 172);
            uiSymbolButton.FillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            uiSymbolButton.FillPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            uiSymbolButton.FillSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            uiSymbolButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiSymbolButton.LightColor = System.Drawing.Color.FromArgb(238, 251, 250);
            uiSymbolButton.Location = new System.Drawing.Point(807, 40);
            uiSymbolButton.MinimumSize = new System.Drawing.Size(1, 1);
            uiSymbolButton.Name = "uiSymbolButton";
            uiSymbolButton.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            uiSymbolButton.RectHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            uiSymbolButton.RectPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            uiSymbolButton.RectSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            uiSymbolButton.Size = new System.Drawing.Size(221, 35);
            uiSymbolButton.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton.Symbol = 61717;
            uiSymbolButton.TabIndex = 4;
            uiSymbolButton.Text = "选择文件夹";
            uiSymbolButton.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiSymbolButton.Click += uiSymbolButton_Click;
            // 
            // btnSeek
            // 
            btnSeek.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSeek.FillColor = System.Drawing.Color.FromArgb(0, 190, 172);
            btnSeek.FillColor2 = System.Drawing.Color.FromArgb(0, 190, 172);
            btnSeek.FillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            btnSeek.FillPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnSeek.FillSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnSeek.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSeek.LightColor = System.Drawing.Color.FromArgb(238, 251, 250);
            btnSeek.Location = new System.Drawing.Point(461, 40);
            btnSeek.MinimumSize = new System.Drawing.Size(1, 1);
            btnSeek.Name = "btnSeek";
            btnSeek.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            btnSeek.RectHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            btnSeek.RectPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnSeek.RectSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnSeek.Size = new System.Drawing.Size(107, 35);
            btnSeek.Style = Sunny.UI.UIStyle.Custom;
            btnSeek.TabIndex = 5;
            btnSeek.Text = "查 询";
            btnSeek.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSeek.Click += btnSeek_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.FillColor = System.Drawing.Color.FromArgb(230, 80, 80);
            btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(460, 642);
            btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = System.Drawing.Color.FromArgb(230, 80, 80);
            btnClose.Size = new System.Drawing.Size(154, 35);
            btnClose.TabIndex = 6;
            btnClose.Text = "退 出";
            btnClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Click += btnClose_Click;
            // 
            // uiGroupBox
            // 
            uiGroupBox.Controls.Add(uiDataGridView);
            uiGroupBox.FillColor = System.Drawing.Color.FromArgb(238, 251, 250);
            uiGroupBox.FillColor2 = System.Drawing.Color.FromArgb(238, 251, 250);
            uiGroupBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiGroupBox.Location = new System.Drawing.Point(4, 82);
            uiGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiGroupBox.MinimumSize = new System.Drawing.Size(1, 1);
            uiGroupBox.Name = "uiGroupBox";
            uiGroupBox.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            uiGroupBox.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            uiGroupBox.Size = new System.Drawing.Size(1067, 552);
            uiGroupBox.Style = Sunny.UI.UIStyle.Custom;
            uiGroupBox.TabIndex = 7;
            uiGroupBox.Text = null;
            uiGroupBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAllDisplay
            // 
            btnAllDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAllDisplay.FillColor = System.Drawing.Color.FromArgb(0, 190, 172);
            btnAllDisplay.FillColor2 = System.Drawing.Color.FromArgb(0, 190, 172);
            btnAllDisplay.FillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            btnAllDisplay.FillPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnAllDisplay.FillSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnAllDisplay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAllDisplay.LightColor = System.Drawing.Color.FromArgb(238, 251, 250);
            btnAllDisplay.Location = new System.Drawing.Point(610, 39);
            btnAllDisplay.MinimumSize = new System.Drawing.Size(1, 1);
            btnAllDisplay.Name = "btnAllDisplay";
            btnAllDisplay.RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            btnAllDisplay.RectHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            btnAllDisplay.RectPressColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnAllDisplay.RectSelectedColor = System.Drawing.Color.FromArgb(0, 152, 138);
            btnAllDisplay.Size = new System.Drawing.Size(107, 35);
            btnAllDisplay.Style = Sunny.UI.UIStyle.Custom;
            btnAllDisplay.TabIndex = 8;
            btnAllDisplay.Text = "显示全部";
            btnAllDisplay.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAllDisplay.Click += btnAllDisplay_Click;
            // 
            // frmAnalysis
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(238, 251, 250);
            ClientSize = new System.Drawing.Size(1075, 689);
            ControlBox = false;
            ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(51, 203, 189);
            Controls.Add(btnAllDisplay);
            Controls.Add(uiGroupBox);
            Controls.Add(btnClose);
            Controls.Add(btnSeek);
            Controls.Add(uiSymbolButton);
            Controls.Add(uiIntegerUpDown);
            Controls.Add(label1);
            EscClose = true;
            Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAnalysis";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            RectColor = System.Drawing.Color.FromArgb(0, 190, 172);
            ShowIcon = false;
            ShowInTaskbar = false;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "CAN数据分析";
            TextAlignment = System.Drawing.StringAlignment.Center;
            TitleColor = System.Drawing.Color.FromArgb(0, 190, 172);
            TitleFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 480);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView).EndInit();
            uiGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown;
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
    }
}