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
            btnSave = new Sunny.UI.UISymbolButton();
            btnClose = new Sunny.UI.UISymbolButton();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            UpStep = new Sunny.UI.UIIntegerUpDown();
            uiLine1 = new Sunny.UI.UILine();
            uiLabel5 = new Sunny.UI.UILabel();
            cobGearType = new Sunny.UI.UIComboBox();
            uiLabel6 = new Sunny.UI.UILabel();
            UpSpeed = new Sunny.UI.UIIntegerUpDown();
            btnDel = new Sunny.UI.UISymbolButton();
            uiLine2 = new Sunny.UI.UILine();
            uiLabel2 = new Sunny.UI.UILabel();
            UpTestNumber = new Sunny.UI.UIIntegerUpDown();
            uiLine3 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
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
            cobStartPosition.Location = new Point(661, 233);
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
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(554, 236);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(100, 23);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "闸位档位:";
            uiLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpGearPpositionTime
            // 
            UpGearPpositionTime.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpGearPpositionTime.Location = new Point(661, 147);
            UpGearPpositionTime.Margin = new Padding(4, 5, 4, 5);
            UpGearPpositionTime.MinimumSize = new Size(100, 0);
            UpGearPpositionTime.Name = "UpGearPpositionTime";
            UpGearPpositionTime.ShowText = false;
            UpGearPpositionTime.Size = new Size(150, 29);
            UpGearPpositionTime.TabIndex = 4;
            UpGearPpositionTime.Text = "uiIntegerUpDown1";
            UpGearPpositionTime.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToDeleteRows = false;
            uiDataGridView1.AllowUserToResizeColumns = false;
            uiDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.BackgroundColor = Color.FromArgb(243, 249, 255);
            uiDataGridView1.BorderStyle = BorderStyle.Fixed3D;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, colStepNumber, colResidenceTime, colSpeed, colStartPositionID, colStartPosition, colStopPosition, colStopPositionID, colGearType, colGearTypeText });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(1, 35);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersWidth = 20;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.RowTemplate.Height = 35;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.Size = new Size(548, 412);
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
            colResidenceTime.HeaderText = "停留时间(ms)";
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
            // btnSave
            // 
            btnSave.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSave.Location = new Point(570, 406);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 35);
            btnSave.Symbol = 361788;
            btnSave.TabIndex = 9;
            btnSave.Text = "保存";
            btnSave.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSave.Click += BtnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Location = new Point(700, 406);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 35);
            btnClose.Symbol = 61530;
            btnClose.TabIndex = 10;
            btnClose.Text = "退 出";
            btnClose.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.Click += BtnClose_Click;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(554, 148);
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
            uiLabel4.Location = new Point(554, 108);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(100, 23);
            uiLabel4.TabIndex = 13;
            uiLabel4.Text = "试验步骤:";
            uiLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpStep
            // 
            UpStep.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpStep.Location = new Point(661, 104);
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
            uiLine1.Location = new Point(555, 35);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(269, 29);
            uiLine1.TabIndex = 14;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(554, 65);
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
            cobGearType.Location = new Point(661, 61);
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
            uiLabel6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(554, 190);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(100, 23);
            uiLabel6.TabIndex = 18;
            uiLabel6.Text = "电机转速:";
            uiLabel6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpSpeed
            // 
            UpSpeed.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpSpeed.Location = new Point(661, 190);
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
            // btnDel
            // 
            btnDel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDel.Location = new Point(639, 365);
            btnDel.MinimumSize = new Size(1, 1);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(112, 35);
            btnDel.Symbol = 362189;
            btnDel.TabIndex = 19;
            btnDel.Text = "删除";
            btnDel.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDel.Click += btnDel_Click;
            // 
            // uiLine2
            // 
            uiLine2.BackColor = Color.Transparent;
            uiLine2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine2.Location = new Point(555, 271);
            uiLine2.MinimumSize = new Size(1, 1);
            uiLine2.Name = "uiLine2";
            uiLine2.Size = new Size(269, 29);
            uiLine2.TabIndex = 20;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(554, 313);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(100, 23);
            uiLabel2.TabIndex = 22;
            uiLabel2.Text = "疲劳次数:";
            uiLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UpTestNumber
            // 
            UpTestNumber.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            UpTestNumber.Location = new Point(661, 310);
            UpTestNumber.Margin = new Padding(4, 5, 4, 5);
            UpTestNumber.MinimumSize = new Size(100, 0);
            UpTestNumber.Name = "UpTestNumber";
            UpTestNumber.ShowText = false;
            UpTestNumber.Size = new Size(151, 29);
            UpTestNumber.TabIndex = 21;
            UpTestNumber.Text = "1";
            UpTestNumber.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLine3
            // 
            uiLine3.BackColor = Color.Transparent;
            uiLine3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLine3.Location = new Point(554, 342);
            uiLine3.MinimumSize = new Size(1, 1);
            uiLine3.Name = "uiLine3";
            uiLine3.Size = new Size(269, 29);
            uiLine3.TabIndex = 23;
            // 
            // frmParaSet
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(834, 450);
            ControlBox = false;
            Controls.Add(btnDel);
            Controls.Add(uiLine3);
            Controls.Add(uiLabel2);
            Controls.Add(UpTestNumber);
            Controls.Add(uiLine2);
            Controls.Add(uiLabel6);
            Controls.Add(UpSpeed);
            Controls.Add(uiLabel5);
            Controls.Add(cobGearType);
            Controls.Add(uiLine1);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiLabel4);
            Controls.Add(UpStep);
            Controls.Add(uiLabel3);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(UpGearPpositionTime);
            Controls.Add(uiLabel1);
            Controls.Add(cobStartPosition);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmParaSet";
            Padding = new Padding(0, 29, 0, 0);
            ShowIcon = false;
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
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UISymbolButton btnClose;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIIntegerUpDown UpStep;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cobGearType;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIIntegerUpDown UpSpeed;
        private Sunny.UI.UISymbolButton btnDel;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIIntegerUpDown UpTestNumber;
        private Sunny.UI.UILine uiLine3;
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
    }
}