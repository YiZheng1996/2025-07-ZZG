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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            cobStartPosition = new Sunny.UI.UIComboBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            ID = new DataGridViewTextBoxColumn();
            colStepNumber = new DataGridViewTextBoxColumn();
            colResidenceTime = new DataGridViewTextBoxColumn();
            colSpeed = new DataGridViewTextBoxColumn();
            colStartPositionID = new DataGridViewTextBoxColumn();
            colStartPosition = new DataGridViewTextBoxColumn();
            colStopPosition = new DataGridViewTextBoxColumn();
            colStopPositionID = new DataGridViewTextBoxColumn();
            colGearType = new DataGridViewTextBoxColumn();
            colGearTypeText = new DataGridViewTextBoxColumn();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            UpStep = new Sunny.UI.UIIntegerUpDown();
            uiLabel5 = new Sunny.UI.UILabel();
            cobGearType = new Sunny.UI.UIComboBox();
            uiLabel6 = new Sunny.UI.UILabel();
            UpSpeed = new Sunny.UI.UIIntegerUpDown();
            UpTestNumber = new Sunny.UI.UIIntegerUpDown();
            uiPanel7 = new Sunny.UI.UIPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiLabel7 = new Sunny.UI.UILabel();
            UpCycleTime = new Sunny.UI.UIIntegerUpDown();
            uiLabel2 = new Sunny.UI.UILabel();
            btnSave = new Sunny.UI.UIButton();
            btnDel = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            UpGearPpositionTime = new Sunny.UI.UIDoubleUpDown();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            uiPanel7.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cobStartPosition
            // 
            cobStartPosition.DataSource = null;
            cobStartPosition.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cobStartPosition.FillColor = Color.White;
            cobStartPosition.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cobStartPosition.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cobStartPosition.Items.AddRange(new object[] { "运转位", "初制动", "制动区", "全制动", "抑制位", "重联位", "紧急位" });
            cobStartPosition.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cobStartPosition.Location = new Point(115, 184);
            cobStartPosition.Margin = new Padding(4, 5, 4, 5);
            cobStartPosition.MinimumSize = new Size(63, 0);
            cobStartPosition.Name = "cobStartPosition";
            cobStartPosition.Padding = new Padding(0, 0, 30, 2);
            cobStartPosition.Size = new Size(150, 29);
            cobStartPosition.SymbolSize = 24;
            cobStartPosition.TabIndex = 0;
            cobStartPosition.TextAlignment = ContentAlignment.MiddleLeft;
            cobStartPosition.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Bold);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(-2, 187);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(100, 23);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "闸位档位:";
            uiLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToDeleteRows = false;
            uiDataGridView1.AllowUserToResizeColumns = false;
            uiDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.BorderStyle = BorderStyle.Fixed3D;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, colStepNumber, colResidenceTime, colSpeed, colStartPositionID, colStartPosition, colStopPosition, colStopPositionID, colGearType, colGearTypeText });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(9, 37);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            uiDataGridView1.RowHeadersWidth = 20;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView1.RowTemplate.Height = 35;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.Size = new Size(548, 373);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 7;
            uiDataGridView1.CellClick += uiDataGridView1_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 50;
            // 
            // colStepNumber
            // 
            colStepNumber.DataPropertyName = "StepNumber";
            colStepNumber.HeaderText = "步骤号";
            colStepNumber.Name = "colStepNumber";
            colStepNumber.ReadOnly = true;
            colStepNumber.Width = 70;
            // 
            // colResidenceTime
            // 
            colResidenceTime.DataPropertyName = "ResidenceTime";
            colResidenceTime.HeaderText = "停留时间(s)";
            colResidenceTime.Name = "colResidenceTime";
            colResidenceTime.ReadOnly = true;
            colResidenceTime.Width = 120;
            // 
            // colSpeed
            // 
            colSpeed.DataPropertyName = "Speed";
            colSpeed.HeaderText = "转速(LU/m)";
            colSpeed.Name = "colSpeed";
            colSpeed.ReadOnly = true;
            colSpeed.Width = 120;
            // 
            // colStartPositionID
            // 
            colStartPositionID.DataPropertyName = "StartPositionID";
            colStartPositionID.HeaderText = "开始位置ID";
            colStartPositionID.Name = "colStartPositionID";
            colStartPositionID.ReadOnly = true;
            colStartPositionID.Visible = false;
            // 
            // colStartPosition
            // 
            colStartPosition.DataPropertyName = "StartPosition";
            colStartPosition.HeaderText = "闸位档位";
            colStartPosition.Name = "colStartPosition";
            colStartPosition.ReadOnly = true;
            // 
            // colStopPosition
            // 
            colStopPosition.DataPropertyName = "StopPosition";
            colStopPosition.HeaderText = "结束位置";
            colStopPosition.Name = "colStopPosition";
            colStopPosition.ReadOnly = true;
            colStopPosition.Visible = false;
            // 
            // colStopPositionID
            // 
            colStopPositionID.DataPropertyName = "StopPositionID";
            colStopPositionID.HeaderText = "结束位置ID";
            colStopPositionID.Name = "colStopPositionID";
            colStopPositionID.ReadOnly = true;
            colStopPositionID.Visible = false;
            // 
            // colGearType
            // 
            colGearType.DataPropertyName = "GearType";
            colGearType.HeaderText = "闸位类型ID";
            colGearType.Name = "colGearType";
            colGearType.ReadOnly = true;
            colGearType.Visible = false;
            // 
            // colGearTypeText
            // 
            colGearTypeText.DataPropertyName = "GearTypeText";
            colGearTypeText.HeaderText = "闸位类型";
            colGearTypeText.Name = "colGearTypeText";
            colGearTypeText.ReadOnly = true;
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Bold);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(-2, 99);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(100, 23);
            uiLabel3.TabIndex = 11;
            uiLabel3.Text = "停留时间:";
            uiLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("宋体", 12F, FontStyle.Bold);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(-2, 59);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(100, 23);
            uiLabel4.TabIndex = 13;
            uiLabel4.Text = "试验步骤:";
            uiLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpStep
            // 
            UpStep.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpStep.Location = new Point(115, 55);
            UpStep.Margin = new Padding(4, 5, 4, 5);
            UpStep.MinimumSize = new Size(100, 0);
            UpStep.Name = "UpStep";
            UpStep.ShowText = false;
            UpStep.Size = new Size(150, 29);
            UpStep.TabIndex = 12;
            UpStep.Text = "1";
            UpStep.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            uiLabel5.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(-2, 19);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(100, 23);
            uiLabel5.TabIndex = 16;
            uiLabel5.Text = "闸位类型:";
            uiLabel5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cobGearType
            // 
            cobGearType.DataSource = null;
            cobGearType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cobGearType.FillColor = Color.White;
            cobGearType.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cobGearType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cobGearType.Items.AddRange(new object[] { "大闸", "小闸" });
            cobGearType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cobGearType.Location = new Point(115, 15);
            cobGearType.Margin = new Padding(4, 5, 4, 5);
            cobGearType.MinimumSize = new Size(63, 0);
            cobGearType.Name = "cobGearType";
            cobGearType.Padding = new Padding(0, 0, 30, 2);
            cobGearType.Size = new Size(150, 29);
            cobGearType.SymbolSize = 24;
            cobGearType.TabIndex = 15;
            cobGearType.TextAlignment = ContentAlignment.MiddleLeft;
            cobGearType.Watermark = "";
            cobGearType.SelectedIndexChanged += cobGearType_SelectedIndexChanged;
            // 
            // uiLabel6
            // 
            uiLabel6.BackColor = Color.Transparent;
            uiLabel6.Font = new Font("宋体", 12F, FontStyle.Bold);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(-2, 141);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(100, 23);
            uiLabel6.TabIndex = 18;
            uiLabel6.Text = "电机转速:";
            uiLabel6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpSpeed
            // 
            UpSpeed.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpSpeed.Location = new Point(115, 141);
            UpSpeed.Margin = new Padding(4, 5, 4, 5);
            UpSpeed.MinimumSize = new Size(100, 0);
            UpSpeed.Name = "UpSpeed";
            UpSpeed.ShowText = false;
            UpSpeed.Size = new Size(150, 29);
            UpSpeed.TabIndex = 17;
            UpSpeed.Text = null;
            UpSpeed.TextAlignment = ContentAlignment.MiddleCenter;
            UpSpeed.Value = 1000;
            // 
            // UpTestNumber
            // 
            UpTestNumber.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpTestNumber.Location = new Point(115, 54);
            UpTestNumber.Margin = new Padding(4, 5, 4, 5);
            UpTestNumber.MinimumSize = new Size(100, 0);
            UpTestNumber.Name = "UpTestNumber";
            UpTestNumber.ShowText = false;
            UpTestNumber.Size = new Size(151, 29);
            UpTestNumber.TabIndex = 21;
            UpTestNumber.Text = "1";
            UpTestNumber.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel7
            // 
            uiPanel7.Controls.Add(UpGearPpositionTime);
            uiPanel7.Controls.Add(uiLabel5);
            uiPanel7.Controls.Add(cobStartPosition);
            uiPanel7.Controls.Add(uiLabel1);
            uiPanel7.Controls.Add(uiLabel6);
            uiPanel7.Controls.Add(uiLabel3);
            uiPanel7.Controls.Add(UpSpeed);
            uiPanel7.Controls.Add(UpStep);
            uiPanel7.Controls.Add(uiLabel4);
            uiPanel7.Controls.Add(cobGearType);
            uiPanel7.FillColor = Color.FromArgb(235, 242, 250);
            uiPanel7.FillColor2 = Color.FromArgb(235, 242, 250);
            uiPanel7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel7.Location = new Point(570, 37);
            uiPanel7.Margin = new Padding(4, 5, 4, 5);
            uiPanel7.MinimumSize = new Size(1, 1);
            uiPanel7.Name = "uiPanel7";
            uiPanel7.RectColor = Color.FromArgb(235, 242, 250);
            uiPanel7.RectDisableColor = Color.FromArgb(235, 242, 250);
            uiPanel7.Size = new Size(286, 227);
            uiPanel7.TabIndex = 498;
            uiPanel7.Text = null;
            uiPanel7.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiLabel7);
            uiPanel1.Controls.Add(UpCycleTime);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(UpTestNumber);
            uiPanel1.FillColor = Color.FromArgb(235, 242, 250);
            uiPanel1.FillColor2 = Color.FromArgb(235, 242, 250);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(570, 269);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = Color.FromArgb(235, 242, 250);
            uiPanel1.RectDisableColor = Color.FromArgb(235, 242, 250);
            uiPanel1.Size = new Size(286, 97);
            uiPanel1.TabIndex = 499;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel7
            // 
            uiLabel7.BackColor = Color.Transparent;
            uiLabel7.Font = new Font("宋体", 12F, FontStyle.Bold);
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.Location = new Point(-2, 16);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(100, 23);
            uiLabel7.TabIndex = 24;
            uiLabel7.Text = "一次循环:";
            uiLabel7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpCycleTime
            // 
            UpCycleTime.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpCycleTime.Location = new Point(115, 12);
            UpCycleTime.Margin = new Padding(4, 5, 4, 5);
            UpCycleTime.MinimumSize = new Size(100, 0);
            UpCycleTime.Name = "UpCycleTime";
            UpCycleTime.ShowText = false;
            UpCycleTime.Size = new Size(151, 29);
            UpCycleTime.TabIndex = 23;
            UpCycleTime.Text = "1";
            UpCycleTime.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Bold);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(-2, 57);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(100, 23);
            uiLabel2.TabIndex = 22;
            uiLabel2.Text = "疲劳试验:";
            uiLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("宋体", 12F);
            btnSave.Location = new Point(568, 375);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 35);
            btnSave.TabIndex = 500;
            btnSave.Text = "保存";
            btnSave.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSave.Click += BtnSave_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("宋体", 12F);
            btnDel.Location = new Point(669, 375);
            btnDel.MinimumSize = new Size(1, 1);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(85, 35);
            btnDel.TabIndex = 501;
            btnDel.Text = "删除";
            btnDel.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDel.Click += btnDel_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("宋体", 12F);
            btnClose.Location = new Point(770, 375);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(85, 35);
            btnClose.TabIndex = 502;
            btnClose.Text = "退出";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += BtnClose_Click;
            // 
            // UpGearPpositionTime
            // 
            UpGearPpositionTime.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpGearPpositionTime.Location = new Point(115, 97);
            UpGearPpositionTime.Margin = new Padding(4, 5, 4, 5);
            UpGearPpositionTime.MinimumSize = new Size(100, 0);
            UpGearPpositionTime.Name = "UpGearPpositionTime";
            UpGearPpositionTime.ShowText = false;
            UpGearPpositionTime.Size = new Size(150, 29);
            UpGearPpositionTime.TabIndex = 503;
            UpGearPpositionTime.Text = "uiDoubleUpDown1";
            UpGearPpositionTime.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // frmParaSet
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(870, 419);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnDel);
            Controls.Add(btnSave);
            Controls.Add(uiPanel1);
            Controls.Add(uiPanel7);
            Controls.Add(uiDataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmParaSet";
            Padding = new Padding(0, 29, 0, 0);
            ShowIcon = false;
            Text = "参数设置";
            TitleFont = new Font("宋体", 14F, FontStyle.Bold);
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FrmParaSet_Load;
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            uiPanel7.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIComboBox cobStartPosition;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIIntegerUpDown UpStep;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cobGearType;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIIntegerUpDown UpSpeed;
        private Sunny.UI.UIIntegerUpDown UpTestNumber;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn colStepNumber;
        private DataGridViewTextBoxColumn colResidenceTime;
        private DataGridViewTextBoxColumn colSpeed;
        private DataGridViewTextBoxColumn colStartPositionID;
        private DataGridViewTextBoxColumn colStartPosition;
        private DataGridViewTextBoxColumn colStopPosition;
        private DataGridViewTextBoxColumn colStopPositionID;
        private DataGridViewTextBoxColumn colGearType;
        private DataGridViewTextBoxColumn colGearTypeText;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIIntegerUpDown UpCycleTime;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnDel;
        private Sunny.UI.UIButton btnClose;
        private Sunny.UI.UIDoubleUpDown UpGearPpositionTime;
    }
}