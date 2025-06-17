namespace MainUI.Procedure
{
    partial class ucTestParams
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            uiTabControl1 = new UITabControl();
            tabPage2 = new TabPage();
            txtsmallTestNumber = new UITextBox();
            uiLabel4 = new UILabel();
            txtbigTestNumber = new UITextBox();
            uiLabel3 = new UILabel();
            tabPage1 = new TabPage();
            btnBrowse = new UIButton();
            txtRpt = new UITextBox();
            uiLabel5 = new UILabel();
            uiGroupBox1 = new UIGroupBox();
            btnEdit = new UIButton();
            btnDelete = new UIButton();
            btnGet = new UIButton();
            txtType = new UITextBox();
            uiLabel2 = new UILabel();
            txtModel = new UITextBox();
            uiLabel1 = new UILabel();
            uiTabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // uiTabControl1
            // 
            uiTabControl1.Controls.Add(tabPage2);
            uiTabControl1.Controls.Add(tabPage1);
            uiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControl1.Font = new Font("微软雅黑", 12F);
            uiTabControl1.ItemSize = new Size(150, 40);
            uiTabControl1.Location = new Point(12, 81);
            uiTabControl1.MainPage = "";
            uiTabControl1.MenuStyle = UIMenuStyle.Custom;
            uiTabControl1.Name = "uiTabControl1";
            uiTabControl1.SelectedIndex = 0;
            uiTabControl1.Size = new Size(623, 487);
            uiTabControl1.SizeMode = TabSizeMode.Fixed;
            uiTabControl1.TabIndex = 70;
            uiTabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            uiTabControl1.TipsFont = new Font("微软雅黑", 9F);
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(243, 249, 255);
            tabPage2.Controls.Add(txtsmallTestNumber);
            tabPage2.Controls.Add(uiLabel4);
            tabPage2.Controls.Add(txtbigTestNumber);
            tabPage2.Controls.Add(uiLabel3);
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(623, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "试验参数";
            // 
            // txtsmallTestNumber
            // 
            txtsmallTestNumber.Cursor = Cursors.IBeam;
            txtsmallTestNumber.Font = new Font("宋体", 12F);
            txtsmallTestNumber.Location = new Point(282, 204);
            txtsmallTestNumber.Margin = new Padding(4, 5, 4, 5);
            txtsmallTestNumber.MinimumSize = new Size(1, 16);
            txtsmallTestNumber.Name = "txtsmallTestNumber";
            txtsmallTestNumber.Padding = new Padding(5);
            txtsmallTestNumber.ShowText = false;
            txtsmallTestNumber.Size = new Size(150, 29);
            txtsmallTestNumber.TabIndex = 4;
            txtsmallTestNumber.TextAlignment = ContentAlignment.MiddleLeft;
            txtsmallTestNumber.Visible = false;
            txtsmallTestNumber.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 12F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(141, 207);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(134, 23);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "小闸试验次数";
            uiLabel4.TextAlign = ContentAlignment.MiddleRight;
            uiLabel4.Visible = false;
            // 
            // txtbigTestNumber
            // 
            txtbigTestNumber.Cursor = Cursors.IBeam;
            txtbigTestNumber.Font = new Font("宋体", 12F);
            txtbigTestNumber.Location = new Point(282, 150);
            txtbigTestNumber.Margin = new Padding(4, 5, 4, 5);
            txtbigTestNumber.MinimumSize = new Size(1, 16);
            txtbigTestNumber.Name = "txtbigTestNumber";
            txtbigTestNumber.Padding = new Padding(5);
            txtbigTestNumber.ShowText = false;
            txtbigTestNumber.Size = new Size(150, 29);
            txtbigTestNumber.TabIndex = 2;
            txtbigTestNumber.TextAlignment = ContentAlignment.MiddleLeft;
            txtbigTestNumber.Visible = false;
            txtbigTestNumber.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 12F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(141, 153);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(134, 23);
            uiLabel3.TabIndex = 0;
            uiLabel3.Text = "大闸试验次数";
            uiLabel3.TextAlign = ContentAlignment.MiddleRight;
            uiLabel3.Visible = false;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(243, 249, 255);
            tabPage1.Controls.Add(btnBrowse);
            tabPage1.Controls.Add(txtRpt);
            tabPage1.Controls.Add(uiLabel5);
            tabPage1.Location = new Point(0, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(623, 447);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "报表模板";
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBrowse.Location = new Point(494, 234);
            btnBrowse.MinimumSize = new Size(1, 1);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 35);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "浏览";
            btnBrowse.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtRpt
            // 
            txtRpt.Cursor = Cursors.IBeam;
            txtRpt.FillDisableColor = Color.FromArgb(243, 249, 255);
            txtRpt.FillReadOnlyColor = Color.FromArgb(243, 249, 255);
            txtRpt.Font = new Font("宋体", 12F);
            txtRpt.Location = new Point(22, 180);
            txtRpt.Margin = new Padding(4, 5, 4, 5);
            txtRpt.MinimumSize = new Size(1, 16);
            txtRpt.Name = "txtRpt";
            txtRpt.Padding = new Padding(5);
            txtRpt.ReadOnly = true;
            txtRpt.RectDisableColor = Color.FromArgb(80, 160, 255);
            txtRpt.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtRpt.ShowText = false;
            txtRpt.Size = new Size(572, 29);
            txtRpt.TabIndex = 4;
            txtRpt.TextAlignment = ContentAlignment.MiddleLeft;
            txtRpt.Watermark = "";
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("宋体", 12F);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(8, 150);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(103, 23);
            uiLabel5.TabIndex = 3;
            uiLabel5.Text = "报表路径：";
            uiLabel5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(btnEdit);
            uiGroupBox1.Controls.Add(btnDelete);
            uiGroupBox1.Controls.Add(uiTabControl1);
            uiGroupBox1.Controls.Add(btnGet);
            uiGroupBox1.Controls.Add(txtType);
            uiGroupBox1.Controls.Add(uiLabel2);
            uiGroupBox1.Controls.Add(txtModel);
            uiGroupBox1.Controls.Add(uiLabel1);
            uiGroupBox1.Dock = DockStyle.Fill;
            uiGroupBox1.Font = new Font("微软雅黑", 11F);
            uiGroupBox1.Location = new Point(0, 0);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(650, 650);
            uiGroupBox1.TabIndex = 400;
            uiGroupBox1.Text = "型号列表";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("微软雅黑", 11F);
            btnEdit.Location = new Point(511, 586);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 40);
            btnEdit.TabIndex = 397;
            btnEdit.Text = "重置";
            btnEdit.TipsFont = new Font("微软雅黑", 9F);
            btnEdit.TipsText = "1";
            btnEdit.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("微软雅黑", 11F);
            btnDelete.Location = new Point(375, 586);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 396;
            btnDelete.Text = "确定";
            btnDelete.TipsFont = new Font("微软雅黑", 9F);
            btnDelete.TipsText = "1";
            btnDelete.Click += btnOK_Click;
            // 
            // btnGet
            // 
            btnGet.Cursor = Cursors.Hand;
            btnGet.Font = new Font("微软雅黑", 11F);
            btnGet.Location = new Point(530, 35);
            btnGet.MinimumSize = new Size(1, 1);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(105, 40);
            btnGet.TabIndex = 389;
            btnGet.Text = "产品选择";
            btnGet.TipsFont = new Font("微软雅黑", 9F);
            btnGet.TipsText = "1";
            btnGet.Click += btnProductSelection_Click;
            // 
            // txtType
            // 
            txtType.Enabled = false;
            txtType.FillDisableColor = Color.FromArgb(243, 249, 255);
            txtType.FillReadOnlyColor = Color.FromArgb(243, 249, 255);
            txtType.Font = new Font("微软雅黑", 11F);
            txtType.Location = new Point(90, 40);
            txtType.Margin = new Padding(4, 5, 4, 5);
            txtType.MinimumSize = new Size(1, 16);
            txtType.Name = "txtType";
            txtType.Padding = new Padding(5);
            txtType.ReadOnly = true;
            txtType.RectDisableColor = Color.FromArgb(80, 160, 255);
            txtType.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtType.ShowText = false;
            txtType.Size = new Size(169, 29);
            txtType.TabIndex = 391;
            txtType.TextAlignment = ContentAlignment.MiddleLeft;
            txtType.Watermark = "请选择";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.FromArgb(243, 249, 255);
            uiLabel2.Font = new Font("微软雅黑", 12F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(271, 40);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(75, 23);
            uiLabel2.TabIndex = 82;
            uiLabel2.Text = "产品型号";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtModel
            // 
            txtModel.Enabled = false;
            txtModel.FillDisableColor = Color.FromArgb(243, 249, 255);
            txtModel.FillReadOnlyColor = Color.FromArgb(243, 249, 255);
            txtModel.Font = new Font("微软雅黑", 11F);
            txtModel.Location = new Point(354, 40);
            txtModel.Margin = new Padding(4, 5, 4, 5);
            txtModel.MinimumSize = new Size(1, 16);
            txtModel.Name = "txtModel";
            txtModel.Padding = new Padding(5);
            txtModel.ReadOnly = true;
            txtModel.RectDisableColor = Color.FromArgb(80, 160, 255);
            txtModel.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtModel.ShowText = false;
            txtModel.Size = new Size(169, 29);
            txtModel.TabIndex = 390;
            txtModel.TextAlignment = ContentAlignment.MiddleLeft;
            txtModel.Watermark = "请选择";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.FromArgb(243, 249, 255);
            uiLabel1.Font = new Font("微软雅黑", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(8, 40);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(75, 23);
            uiLabel1.TabIndex = 80;
            uiLabel1.Text = "产品类型";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ucTestParams
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(uiGroupBox1);
            Name = "ucTestParams";
            Size = new Size(650, 650);
            Load += ucTestParams_Load;
            uiTabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnGet;
        private Sunny.UI.UITextBox txtType;
        private Sunny.UI.UITextBox txtModel;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UITextBox txtsmallTestNumber;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtbigTestNumber;
        private Sunny.UI.UILabel uiLabel3;
        private TabPage tabPage1;
        private UITextBox txtRpt;
        private UILabel uiLabel5;
        private UIButton btnBrowse;
    }
}
