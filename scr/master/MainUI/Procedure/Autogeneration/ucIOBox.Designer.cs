namespace MainUI.Procedure.Autogeneration
{
    partial class ucIOBox
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
            components = new System.ComponentModel.Container();
            uiToolTip1 = new UIToolTip(components);
            uiTitlePanel1 = new UITitlePanel();
            uiPanelDI = new FlowLayoutPanel();
            uiTitlePanel2 = new UITitlePanel();
            uiPanelDO = new FlowLayoutPanel();
            timer = new FormControl.Timer(components);
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiToolTip1
            // 
            uiToolTip1.BackColor = Color.FromArgb(54, 54, 54);
            uiToolTip1.ForeColor = Color.FromArgb(239, 239, 239);
            uiToolTip1.OwnerDraw = true;
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(uiPanelDI);
            uiTitlePanel1.Dock = DockStyle.Left;
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel1.Location = new Point(0, 0);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(690, 720);
            uiTitlePanel1.Style = UIStyle.Custom;
            uiTitlePanel1.TabIndex = 4;
            uiTitlePanel1.Text = "制动柜输出信号检测";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel1.TitleHeight = 28;
            // 
            // uiPanelDI
            // 
            uiPanelDI.AutoScroll = true;
            uiPanelDI.Location = new Point(1, 29);
            uiPanelDI.Name = "uiPanelDI";
            uiPanelDI.Size = new Size(688, 688);
            uiPanelDI.TabIndex = 1;
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(uiPanelDO);
            uiTitlePanel2.Dock = DockStyle.Right;
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTitlePanel2.Location = new Point(691, 0);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(690, 720);
            uiTitlePanel2.Style = UIStyle.Custom;
            uiTitlePanel2.TabIndex = 5;
            uiTitlePanel2.Text = "制动柜输入信号检测";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel2.TitleHeight = 28;
            // 
            // uiPanelDO
            // 
            uiPanelDO.AutoScroll = true;
            uiPanelDO.Location = new Point(1, 29);
            uiPanelDO.Name = "uiPanelDO";
            uiPanelDO.Size = new Size(688, 688);
            uiPanelDO.TabIndex = 0;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 200;
            timer.Tick += timer_Tick;
            // 
            // ucIOBox
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 249, 255);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Font = new Font("宋体", 11F);
            Name = "ucIOBox";
            Size = new Size(1381, 720);
            Load += ucIOBox_Load;
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private System.Windows.Forms.Timer timer;
        private FlowLayoutPanel uiPanelDO;
        private FlowLayoutPanel uiPanelDI;
    }
}
