namespace MainUI.Procedure.SSI
{
    partial class frmSSI
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
            uiPanel1 = new Sunny.UI.UIPanel();
            btnClose = new Sunny.UI.UIButton();
            dataGridView1 = new Sunny.UI.UIDataGridView();
            ColTimeNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(btnClose);
            uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiPanel1.Location = new System.Drawing.Point(0, 541);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(1088, 54);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.FillColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(486, 9);
            btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = System.Drawing.Color.FromArgb(255, 128, 128);
            btnClose.Size = new System.Drawing.Size(161, 35);
            btnClose.TabIndex = 0;
            btnClose.Text = "退  出";
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(243, 249, 255);
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColTimeNow, ColData });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.GridColor = System.Drawing.Color.Black;
            dataGridView1.Location = new System.Drawing.Point(0, 29);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4);
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
            dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(1088, 512);
            dataGridView1.StripeEvenColor = System.Drawing.Color.Empty;
            dataGridView1.StripeOddColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridView1.TabIndex = 2;
            // 
            // ColTimeNow
            // 
            ColTimeNow.FillWeight = 270F;
            ColTimeNow.HeaderText = "时间";
            ColTimeNow.Name = "ColTimeNow";
            ColTimeNow.ReadOnly = true;
            ColTimeNow.Width = 63;
            // 
            // ColData
            // 
            ColData.FillWeight = 745F;
            ColData.HeaderText = "数据";
            ColData.Name = "ColData";
            ColData.ReadOnly = true;
            ColData.Width = 63;
            // 
            // frmSSI
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1088, 595);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSSI";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            ShowIcon = false;
            Text = "SSI数据监控";
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            Load += frmSSI_Load;
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIDataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColData;
    }
}