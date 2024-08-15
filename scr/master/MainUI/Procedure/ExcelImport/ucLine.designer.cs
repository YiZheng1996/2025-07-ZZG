using Sunny.UI;

namespace MainUI.Procedure.ExcelImport
{
    partial class ucLine
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new UILabel();
            txtPath = new UITextBox();
            label2 = new UILabel();
            lblImpTips = new UILabel();
            btnExcelImport = new UIButton();
            groupBox1 = new UIGroupBox();
            btnExportEexcel = new UIButton();
            cboModelName = new UIComboBox();
            label30 = new UILabel();
            grpData = new UIGroupBox();
            dataGridView1 = new UIDataGridView();
            colmodelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPlugFoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLineDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLinetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colInitvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCardFoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label1.Location = new System.Drawing.Point(10, 140);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 15);
            label1.TabIndex = 10;
            label1.Text = "文件路径：";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPath
            // 
            txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPath.FillDisableColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtPath.FillReadOnlyColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtPath.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPath.Location = new System.Drawing.Point(91, 137);
            txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPath.MinimumSize = new System.Drawing.Size(1, 16);
            txtPath.Name = "txtPath";
            txtPath.Padding = new System.Windows.Forms.Padding(5);
            txtPath.ReadOnly = true;
            txtPath.RectDisableColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtPath.RectReadOnlyColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtPath.ShowText = false;
            txtPath.Size = new System.Drawing.Size(1107, 24);
            txtPath.Style = UIStyle.Custom;
            txtPath.TabIndex = 11;
            txtPath.Text = "选择数据表格";
            txtPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtPath.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label2.Location = new System.Drawing.Point(267, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(406, 14);
            label2.TabIndex = 16;
            label2.Text = "导入步骤：先选择型号。点击数据导入按钮，选择正确Excel文件";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImpTips
            // 
            lblImpTips.AutoSize = true;
            lblImpTips.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblImpTips.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            lblImpTips.Location = new System.Drawing.Point(203, 100);
            lblImpTips.Name = "lblImpTips";
            lblImpTips.Size = new System.Drawing.Size(74, 21);
            lblImpTips.TabIndex = 17;
            lblImpTips.Text = "导入提示";
            lblImpTips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExcelImport
            // 
            btnExcelImport.BackColor = System.Drawing.Color.CornflowerBlue;
            btnExcelImport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExcelImport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExcelImport.Location = new System.Drawing.Point(91, 84);
            btnExcelImport.MinimumSize = new System.Drawing.Size(1, 1);
            btnExcelImport.Name = "btnExcelImport";
            btnExcelImport.Size = new System.Drawing.Size(106, 40);
            btnExcelImport.TabIndex = 19;
            btnExcelImport.Text = "数据导入";
            btnExcelImport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExcelImport.Click += btnExcelImport_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExportEexcel);
            groupBox1.Controls.Add(cboModelName);
            groupBox1.Controls.Add(label30);
            groupBox1.Controls.Add(btnExcelImport);
            groupBox1.Controls.Add(lblImpTips);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPath);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            groupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            groupBox1.Size = new System.Drawing.Size(1473, 265);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = null;
            groupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExportEexcel
            // 
            btnExportEexcel.BackColor = System.Drawing.Color.CornflowerBlue;
            btnExportEexcel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExportEexcel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExportEexcel.Location = new System.Drawing.Point(629, 84);
            btnExportEexcel.MinimumSize = new System.Drawing.Size(1, 1);
            btnExportEexcel.Name = "btnExportEexcel";
            btnExportEexcel.Size = new System.Drawing.Size(106, 40);
            btnExportEexcel.TabIndex = 22;
            btnExportEexcel.Text = "导出到Excel";
            btnExportEexcel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExportEexcel.Click += btnExportEexcel_Click;
            // 
            // cboModelName
            // 
            cboModelName.DataSource = null;
            cboModelName.DropDownStyle = UIDropDownStyle.DropDownList;
            cboModelName.FillColor = System.Drawing.Color.White;
            cboModelName.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboModelName.FormattingEnabled = true;
            cboModelName.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cboModelName.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            cboModelName.Location = new System.Drawing.Point(91, 47);
            cboModelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cboModelName.MinimumSize = new System.Drawing.Size(63, 0);
            cboModelName.Name = "cboModelName";
            cboModelName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cboModelName.Size = new System.Drawing.Size(141, 23);
            cboModelName.SymbolSize = 24;
            cboModelName.TabIndex = 21;
            cboModelName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            cboModelName.Watermark = "";
            cboModelName.SelectedIndexChanged += cboModelName_SelectedIndexChanged;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label30.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label30.Location = new System.Drawing.Point(51, 52);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(35, 14);
            label30.TabIndex = 20;
            label30.Text = "型号";
            label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpData
            // 
            grpData.Controls.Add(dataGridView1);
            grpData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            grpData.Location = new System.Drawing.Point(0, 275);
            grpData.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            grpData.MinimumSize = new System.Drawing.Size(1, 1);
            grpData.Name = "grpData";
            grpData.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            grpData.Size = new System.Drawing.Size(1473, 650);
            grpData.TabIndex = 21;
            grpData.TabStop = false;
            grpData.Text = "航插定义记录";
            grpData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(243, 249, 255);
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colmodelName, colPlug, colPlugFoot, colLine, colLineDesc, colLinetype, colInitvalue, colCard, colCardFoot });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(104, 173, 255);
            dataGridView1.Location = new System.Drawing.Point(0, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(1473, 605);
            dataGridView1.TabIndex = 0;
            // 
            // colmodelName
            // 
            colmodelName.DataPropertyName = "modelName";
            colmodelName.HeaderText = "车型";
            colmodelName.Name = "colmodelName";
            colmodelName.ReadOnly = true;
            // 
            // colPlug
            // 
            colPlug.DataPropertyName = "Plug";
            colPlug.HeaderText = "航插";
            colPlug.Name = "colPlug";
            colPlug.ReadOnly = true;
            // 
            // colPlugFoot
            // 
            colPlugFoot.DataPropertyName = "PlugFoot";
            colPlugFoot.HeaderText = "航插引脚";
            colPlugFoot.Name = "colPlugFoot";
            colPlugFoot.ReadOnly = true;
            // 
            // colLine
            // 
            colLine.DataPropertyName = "LineNo";
            colLine.HeaderText = "线号";
            colLine.Name = "colLine";
            colLine.ReadOnly = true;
            // 
            // colLineDesc
            // 
            colLineDesc.DataPropertyName = "LineDesc";
            colLineDesc.HeaderText = "线号定义说明";
            colLineDesc.Name = "colLineDesc";
            colLineDesc.ReadOnly = true;
            // 
            // colLinetype
            // 
            colLinetype.DataPropertyName = "Linetype";
            colLinetype.HeaderText = "线号类型";
            colLinetype.Name = "colLinetype";
            colLinetype.ReadOnly = true;
            // 
            // colInitvalue
            // 
            colInitvalue.DataPropertyName = "Initvalue";
            colInitvalue.HeaderText = "初始状态";
            colInitvalue.Name = "colInitvalue";
            colInitvalue.ReadOnly = true;
            // 
            // colCard
            // 
            colCard.DataPropertyName = "CardNo";
            colCard.HeaderText = "板卡号";
            colCard.Name = "colCard";
            colCard.ReadOnly = true;
            // 
            // colCardFoot
            // 
            colCardFoot.DataPropertyName = "CardFoot";
            colCardFoot.HeaderText = "板卡点位号";
            colCardFoot.Name = "colCardFoot";
            colCardFoot.ReadOnly = true;
            // 
            // ucLine
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            Controls.Add(grpData);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ucLine";
            Size = new System.Drawing.Size(1478, 930);
            Load += ucLine_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private UILabel label1;
        private UITextBox txtPath;
        private UILabel label2;
        private UILabel lblImpTips;
        private UIButton btnExcelImport;
        private UIGroupBox groupBox1;
        private UIGroupBox grpData;
        private UIDataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmodelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlugFoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInitvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardFoot;
        private Sunny.UI.UIComboBox cboModelName;
        private Sunny.UI.UILabel label30;
        private Sunny.UI.UIButton btnExportEexcel;
    }
}
