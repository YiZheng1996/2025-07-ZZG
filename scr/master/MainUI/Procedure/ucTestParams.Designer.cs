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
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            uiTabControl1 = new Sunny.UI.UITabControl();
            tabPage2 = new System.Windows.Forms.TabPage();
            txtsmallTestNumber = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            txtbigTestNumber = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            btnEdit = new Sunny.UI.UIButton();
            btnDelete = new Sunny.UI.UIButton();
            btnGet = new Sunny.UI.UIButton();
            txtType = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            txtModel = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiTabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            uiTabControl1.Location = new System.Drawing.Point(12, 81);
            uiTabControl1.MainPage = "";
            uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControl1.Name = "uiTabControl1";
            uiTabControl1.SelectedIndex = 0;
            uiTabControl1.Size = new System.Drawing.Size(623, 487);
            uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            uiTabControl1.TabIndex = 70;
            uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            uiTabControl1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            tabPage2.Controls.Add(txtsmallTestNumber);
            tabPage2.Controls.Add(uiLabel4);
            tabPage2.Controls.Add(txtbigTestNumber);
            tabPage2.Controls.Add(uiLabel3);
            tabPage2.Location = new System.Drawing.Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new System.Drawing.Size(623, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "试验参数";
            // 
            // txtsmallTestNumber
            // 
            txtsmallTestNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtsmallTestNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtsmallTestNumber.Location = new System.Drawing.Point(282, 204);
            txtsmallTestNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtsmallTestNumber.MinimumSize = new System.Drawing.Size(1, 16);
            txtsmallTestNumber.Name = "txtsmallTestNumber";
            txtsmallTestNumber.Padding = new System.Windows.Forms.Padding(5);
            txtsmallTestNumber.ShowText = false;
            txtsmallTestNumber.Size = new System.Drawing.Size(150, 29);
            txtsmallTestNumber.TabIndex = 4;
            txtsmallTestNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtsmallTestNumber.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new System.Drawing.Point(141, 207);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(134, 23);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "小闸试验次数";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbigTestNumber
            // 
            txtbigTestNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtbigTestNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtbigTestNumber.Location = new System.Drawing.Point(282, 150);
            txtbigTestNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtbigTestNumber.MinimumSize = new System.Drawing.Size(1, 16);
            txtbigTestNumber.Name = "txtbigTestNumber";
            txtbigTestNumber.Padding = new System.Windows.Forms.Padding(5);
            txtbigTestNumber.ShowText = false;
            txtbigTestNumber.Size = new System.Drawing.Size(150, 29);
            txtbigTestNumber.TabIndex = 2;
            txtbigTestNumber.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtbigTestNumber.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel3.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new System.Drawing.Point(141, 153);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new System.Drawing.Size(134, 23);
            uiLabel3.TabIndex = 0;
            uiLabel3.Text = "大闸试验次数";
            uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new System.Drawing.Size(650, 650);
            uiGroupBox1.TabIndex = 400;
            uiGroupBox1.Text = "型号列表";
            uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEdit.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.Location = new System.Drawing.Point(511, 586);
            btnEdit.MinimumSize = new System.Drawing.Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(120, 40);
            btnEdit.TabIndex = 397;
            btnEdit.Text = "重置";
            btnEdit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.TipsText = "1";
            btnEdit.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(375, 586);
            btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(120, 40);
            btnDelete.TabIndex = 396;
            btnDelete.Text = "确定";
            btnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.TipsText = "1";
            btnDelete.Click += btnOK_Click;
            // 
            // btnGet
            // 
            btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGet.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGet.Location = new System.Drawing.Point(530, 35);
            btnGet.MinimumSize = new System.Drawing.Size(1, 1);
            btnGet.Name = "btnGet";
            btnGet.Size = new System.Drawing.Size(105, 40);
            btnGet.TabIndex = 389;
            btnGet.Text = "产品选择";
            btnGet.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGet.TipsText = "1";
            btnGet.Click += btnProductSelection_Click;
            // 
            // txtType
            // 
            txtType.Enabled = false;
            txtType.FillDisableColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtType.FillReadOnlyColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtType.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtType.Location = new System.Drawing.Point(90, 40);
            txtType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtType.MinimumSize = new System.Drawing.Size(1, 16);
            txtType.Name = "txtType";
            txtType.Padding = new System.Windows.Forms.Padding(5);
            txtType.ReadOnly = true;
            txtType.RectDisableColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtType.RectReadOnlyColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtType.ShowText = false;
            txtType.Size = new System.Drawing.Size(169, 29);
            txtType.TabIndex = 391;
            txtType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtType.Watermark = "请选择";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel2.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new System.Drawing.Point(271, 40);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new System.Drawing.Size(75, 23);
            uiLabel2.TabIndex = 82;
            uiLabel2.Text = "产品型号";
            uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModel
            // 
            txtModel.Enabled = false;
            txtModel.FillDisableColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtModel.FillReadOnlyColor = System.Drawing.Color.FromArgb(243, 249, 255);
            txtModel.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtModel.Location = new System.Drawing.Point(354, 40);
            txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtModel.MinimumSize = new System.Drawing.Size(1, 16);
            txtModel.Name = "txtModel";
            txtModel.Padding = new System.Windows.Forms.Padding(5);
            txtModel.ReadOnly = true;
            txtModel.RectDisableColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtModel.RectReadOnlyColor = System.Drawing.Color.FromArgb(80, 160, 255);
            txtModel.ShowText = false;
            txtModel.Size = new System.Drawing.Size(169, 29);
            txtModel.TabIndex = 390;
            txtModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            txtModel.Watermark = "请选择";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            uiLabel1.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new System.Drawing.Point(8, 40);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(75, 23);
            uiLabel1.TabIndex = 80;
            uiLabel1.Text = "产品类型";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTestParams
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(uiGroupBox1);
            Name = "ucTestParams";
            Size = new System.Drawing.Size(650, 650);
            Load += ucTestParams_Load;
            uiTabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
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
    }
}
