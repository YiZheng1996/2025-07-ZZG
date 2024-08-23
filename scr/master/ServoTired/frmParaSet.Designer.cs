namespace ServoTired
{
    partial class frmParaSet
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
            cobStartPosition = new Sunny.UI.UIComboBox();
            uiLabel1 = new Sunny.UI.UILabel();
            UpGearPpositionTime = new Sunny.UI.UIIntegerUpDown();
            uiLabel2 = new Sunny.UI.UILabel();
            cobStopPosition = new Sunny.UI.UIComboBox();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            btnSave = new Sunny.UI.UISymbolButton();
            btnClose = new Sunny.UI.UISymbolButton();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            UpStep = new Sunny.UI.UIIntegerUpDown();
            uiLine1 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cobStartPosition
            // 
            cobStartPosition.DataSource = null;
            cobStartPosition.FillColor = Color.White;
            cobStartPosition.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cobStartPosition.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cobStartPosition.Items.AddRange(new object[] { "运转位", "初制动", "制动区", "全制动", "抑制位", "重联位", "紧急位" });
            cobStartPosition.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cobStartPosition.Location = new Point(634, 188);
            cobStartPosition.Margin = new Padding(4, 5, 4, 5);
            cobStartPosition.MinimumSize = new Size(63, 0);
            cobStartPosition.Name = "cobStartPosition";
            cobStartPosition.Padding = new Padding(0, 0, 30, 2);
            cobStartPosition.Size = new Size(150, 29);
            cobStartPosition.SymbolSize = 24;
            cobStartPosition.TabIndex = 0;
            cobStartPosition.TextAlignment = ContentAlignment.MiddleLeft;
            cobStartPosition.Watermark = "";
            cobStartPosition.SelectedIndexChanged += CobStartPosition_SelectedIndexChanged;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(527, 191);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(100, 23);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "开始位置:";
            uiLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpGearPpositionTime
            // 
            UpGearPpositionTime.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpGearPpositionTime.Location = new Point(634, 142);
            UpGearPpositionTime.Margin = new Padding(4, 5, 4, 5);
            UpGearPpositionTime.MinimumSize = new Size(100, 0);
            UpGearPpositionTime.Name = "UpGearPpositionTime";
            UpGearPpositionTime.ShowText = false;
            UpGearPpositionTime.Size = new Size(150, 29);
            UpGearPpositionTime.TabIndex = 4;
            UpGearPpositionTime.Text = "uiIntegerUpDown1";
            UpGearPpositionTime.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(527, 237);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(100, 23);
            uiLabel2.TabIndex = 6;
            uiLabel2.Text = "结束位置:";
            uiLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cobStopPosition
            // 
            cobStopPosition.DataSource = null;
            cobStopPosition.FillColor = Color.White;
            cobStopPosition.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cobStopPosition.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cobStopPosition.Items.AddRange(new object[] { "运转位", "初制动", "制动区", "全制动", "抑制位", "重联位", "紧急位" });
            cobStopPosition.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cobStopPosition.Location = new Point(634, 234);
            cobStopPosition.Margin = new Padding(4, 5, 4, 5);
            cobStopPosition.MinimumSize = new Size(63, 0);
            cobStopPosition.Name = "cobStopPosition";
            cobStopPosition.Padding = new Padding(0, 0, 30, 2);
            cobStopPosition.Size = new Size(150, 29);
            cobStopPosition.SymbolSize = 24;
            cobStopPosition.TabIndex = 5;
            cobStopPosition.TextAlignment = ContentAlignment.MiddleLeft;
            cobStopPosition.Watermark = "";
            cobStopPosition.SelectedIndexChanged += CobStopPosition_SelectedIndexChanged;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.Dock = DockStyle.Left;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(0, 29);
            uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(531, 421);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSave.Location = new Point(551, 400);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "保存";
            btnSave.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSave.Click += BtnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Location = new Point(681, 400);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 35);
            btnClose.Symbol = 361438;
            btnClose.TabIndex = 10;
            btnClose.Text = "退 出";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += BtnClose_Click;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(527, 145);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(100, 23);
            uiLabel3.TabIndex = 11;
            uiLabel3.Text = "停留时间:";
            uiLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(527, 100);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(100, 23);
            uiLabel4.TabIndex = 13;
            uiLabel4.Text = "步骤:";
            uiLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpStep
            // 
            UpStep.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpStep.Location = new Point(634, 96);
            UpStep.Margin = new Padding(4, 5, 4, 5);
            UpStep.MinimumSize = new Size(100, 0);
            UpStep.Name = "UpStep";
            UpStep.ShowText = false;
            UpStep.Size = new Size(150, 29);
            UpStep.TabIndex = 12;
            UpStep.Text = "1";
            UpStep.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLine1
            // 
            uiLine1.BackColor = Color.Transparent;
            uiLine1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine1.Location = new Point(535, 36);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(269, 29);
            uiLine1.TabIndex = 14;
            uiLine1.Text = "参数";
            // 
            // frmParaSet
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(809, 450);
            Controls.Add(uiLine1);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiLabel4);
            Controls.Add(UpStep);
            Controls.Add(uiLabel3);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(uiLabel2);
            Controls.Add(cobStopPosition);
            Controls.Add(UpGearPpositionTime);
            Controls.Add(uiLabel1);
            Controls.Add(cobStartPosition);
            Name = "frmParaSet";
            Padding = new Padding(0, 29, 0, 0);
            Text = "参数设置";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmParaSet_Load;
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIComboBox cobStartPosition;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIIntegerUpDown UpGearPpositionTime;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cobStopPosition;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UISymbolButton btnClose;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIIntegerUpDown UpStep;
        private Sunny.UI.UILine uiLine1;
    }
}