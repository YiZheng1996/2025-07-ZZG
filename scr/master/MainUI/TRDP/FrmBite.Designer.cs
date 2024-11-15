namespace MainUI.TRDP
{
    partial class FrmBite
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
            btnOK = new Button();
            labDescription = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            uiPanel1 = new UIPanel();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(202, 260);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(117, 34);
            btnOK.TabIndex = 0;
            btnOK.Text = "确定";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += button1_Click;
            // 
            // labDescription
            // 
            labDescription.BorderStyle = BorderStyle.FixedSingle;
            labDescription.Location = new Point(64, 54);
            labDescription.Name = "labDescription";
            labDescription.Size = new Size(392, 90);
            labDescription.TabIndex = 5;
            labDescription.Text = "label3";
            labDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(390, 98);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(flowLayoutPanel1);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(63, 149);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Padding = new Padding(2);
            uiPanel1.Size = new Size(394, 102);
            uiPanel1.TabIndex = 7;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FrmBite
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(521, 308);
            ControlBox = false;
            Controls.Add(uiPanel1);
            Controls.Add(labDescription);
            Controls.Add(btnOK);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBite";
            Padding = new Padding(0, 30, 0, 0);
            Text = "组合按钮";
            TitleHeight = 30;
            ZoomScaleRect = new Rectangle(15, 15, 521, 308);
            Load += FrmBite_Load;
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labDescription;
        private FlowLayoutPanel flowLayoutPanel1;
        private UIPanel uiPanel1;
    }
}