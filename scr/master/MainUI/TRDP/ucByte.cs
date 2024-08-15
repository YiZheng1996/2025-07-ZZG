using RW;
using RW.Modules;
using RW.UI;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.TRDP
{
    public partial class ucByte : UserControl, IValue
    {
        public ucByte()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        public string TitleText
        {
            get;
            set;
        }

        //[DefaultValue(true)]
        //public bool EnableTitle
        //{
        //    get { return this.label2.Visible; }
        //    set { this.label2.Visible = value; }
        //}

        [DefaultValue(false)]
        public bool EnableTitle { get; set; }

        private int offset;
        /// <summary>
        /// 字偏移量
        /// </summary>
        [DefaultValue(0)]
        public int Offset
        {
            get { return offset; }
            set { offset = value; SetText(); }
        }

        private int bit;
        /// <summary>
        /// 位偏移量
        /// </summary>
        [DefaultValue(0)]
        public int Bit
        {
            get { return bit; }
            set { bit = value; SetText(); }
        }
        [DefaultValue(0)]
        public int TRDPNo { get; set; }
        private double bitValue;
        private Label label3;
        private UITextBox textBox1;
        private Label label1;
        private UIComboBox comboBox1;

        /// <summary>
        /// 比例值   1bit=0.1T
        /// </summary>
        [DefaultValue(1)]
        public double BitValue
        {
            get { return bitValue; }
            set { bitValue = value; }
        }
        [DefaultValue(null)]
        public bool PortPattern { get; set; }
        /// <summary>
        /// 是否换算传感器量程
        /// </summary>
        public bool IsSensorRange { get; set; }
        /// <summary>
        /// 端口号，此处是10进制，注意16进制值的转换
        /// </summary>
        [DefaultValue(0)]
        public int Port { get; set; }

        [DefaultValue(false)]
        public bool ReadOnly { get; set; }

        private VariableTypeEnums variableType;
        /// <summary>b
        /// 变量类型，U8，I8，U6，I16...
        /// </summary>
        [DefaultValue(VariableTypeEnums.None)]
        public VariableTypeEnums VariableType
        {
            get { return variableType; }
            set { variableType = value; SetText(); }
        }

        void SetText()
        {
            this.TitleText = string.Format("{0}.{2}[{1}]", this.Offset, this.VariableType.ToString(), this.bit);
        }

        #region IValue<double> 成员

        private double value;
        public double Value
        {
            get { return value; }
            set
            {
                if (value == this.value) return;
                this.value = value;
                if (!this.textBox1.Focused)//如果有焦点，很可能在输入，以用户输入为准
                    this.textBox1.Text = value.ToString();
            }
        }

        #endregion

        [DefaultValue(null)]
        public DataRange Range { get; set; }

        [DefaultValue(" ")]
        public string Unit
        {
            get { return this.label3.Text; }
            set { this.label3.Text = value; }
        }

        public event ValueHandler<double> Submits;
        protected virtual void OnSubmit(double value)
        {
            Submits?.Invoke(this, value);
        }

        public void Submit()
        {
            OnSubmit(Value);
        }

        /// <summary>
        /// 验证文本输入是否合法，一般是失去焦点或者在文本框按回车触发
        /// </summary>
        bool ValidText()
        {
            string txt = this.textBox1.Text;
            if (string.IsNullOrEmpty(txt)) return false;

            double value;
            if (!double.TryParse(txt, out value))
            {
                MessageBox.Show(this, "请输入正确的数值。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Range != null && Range.Max != Range.Min && Range.Max != 0)
            {
                if (value > Range.Max || value < Range.Min)
                {
                    MessageBox.Show("请输入" + Range.Min + "~" + Range.Max + "的数字。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //TextBox box = sender as TextBox;
                    this.textBox1.Focus();
                    this.textBox1.SelectAll();
                    //box.SelectedText = box.Text;
                    return false;
                }
            }

            if (this.Value == value)
                return false;
            this.Value = value;
            return true;
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (ValidText())
            {
                try
                {
                    OnSubmit(this.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据写入失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ucByte_Load(object sender, EventArgs e)
        {
            if (Range != null && Range.Items.Count > 0)
            {
                this.comboBox1.Visible = true;
                this.textBox1.Visible = false;
                foreach (var item in Range.Items)
                {
                    this.comboBox1.Items.Add(new ListBoxItem(item.Value, item.Key.ToString()));
                }
                this.comboBox1.SelectedIndex = 0;
                //this.comboBox1.Items.Add(new ListBoxItem
            }
            else
            {
                this.comboBox1.Visible = false;
                this.textBox1.Visible = true;
            }

            this.textBox1.Enabled = this.comboBox1.Enabled = !ReadOnly && Enabled;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object val = this.comboBox1.SelectedItem;
            if (val == null || val.ToString() == "无操作") return;
            ListBoxItem item = val as ListBoxItem;
            this.Value = Convert.ToInt32(item.SelectValue);

            OnSubmit(this.Value);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this.textBox1.DeselectAll();
                ValidText();
                OnSubmit(this.Value);
            }
        }

        public new bool Enabled
        {
            get { return this.textBox1.Enabled; }
            set { this.textBox1.Enabled = value; }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                cp.ExStyle |= 0x02000000;

                return cp;

            }
        }

        private void ucByte_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Bold);
            SizeF s = g.MeasureString(this.TitleText, f).ToSize();
            g.DrawString(this.TitleText, f, new SolidBrush(Color.Black), (this.Width - s.Width) / 2, 2);
        }

        private void InitializeComponent()
        {
            label3 = new Label();
            textBox1 = new UITextBox();
            label1 = new Label();
            comboBox1 = new UIComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(186, 32);
            label3.Name = "label3";
            label3.Size = new Size(11, 12);
            label3.TabIndex = 9;
            label3.Text = " ";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(100, 27);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MinimumSize = new Size(1, 16);
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(5);
            textBox1.ShowText = false;
            textBox1.Size = new Size(80, 23);
            textBox1.TabIndex = 7;
            textBox1.TextAlignment = ContentAlignment.TopCenter;
            textBox1.Watermark = "";
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.Leave += textBox1_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Location = new Point(8, 23);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 6;
            label1.Text = "生命信号：";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = null;
            comboBox1.DropDownStyle = UIDropDownStyle.DropDownList;
            comboBox1.FillColor = Color.White;
            comboBox1.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            comboBox1.Items.AddRange(new object[] { "无操作" });
            comboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            comboBox1.Location = new Point(103, 28);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.MinimumSize = new Size(63, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Padding = new Padding(0, 0, 30, 2);
            comboBox1.Size = new Size(80, 21);
            comboBox1.SymbolSize = 24;
            comboBox1.TabIndex = 8;
            comboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            comboBox1.Watermark = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ucByte
            // 
            BackColor = Color.FromArgb(0, 190, 172);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ucByte";
            Size = new Size(210, 61);
            Load += ucByte_Load;
            Paint += ucByte_Paint;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

