using RW;
using RW.Modules;
using RW.UI;
using System.ComponentModel;
using System.Linq;

namespace MainUI.MVB
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

        private string groupoffset;
        [DefaultValue(" ")]
        public string GroupOffset
        {
            get { return groupoffset; }
            set { groupoffset = value; }
        }

        private int bit;
        /// <summary>
        /// 字偏移量
        /// </summary>
        [DefaultValue(0)]
        public int Bit
        {
            get { return bit; }
            set { bit = value; SetText(); }
        }


        /// <summary>
        /// 写值比率
        /// </summary>
        [DefaultValue(0)]
        public double WriteRate { get; set; }


        /// <summary>
        /// 显示比率
        /// </summary>
        [DefaultValue(0)]
        public double ReadRate { get; set; }


        /// <summary>
        /// 端口号，此处是10进制，注意16进制值的转换
        /// </summary>
        [DefaultValue(0)]
        public int Port { get; set; }

        [DefaultValue(false)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// true 取反 小端模式，false 取正 大端模式
        /// </summary>
        [DefaultValue(null)]
        public bool PortPattern { get; set; }

        private VariableTypeEnums variableType;
        /// <summary>
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
                    this.textBox1.Text = (value * ReadRate).ToString();
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

        public bool Identity { get; set; }

        /// <summary>
        /// 是否换算传感器量程
        /// </summary>
        public bool IsSensorRange { get; set; }

        public event ValueHandler<double> Submits;
        protected virtual void OnSubmit(double value)
        {
            Submits?.Invoke(this, (value / WriteRate));
        }

        public void Submit()
        {
            OnSubmit(this.Value);
        }

        /// <summary>
        /// 验证文本输入是否合法，一般是失去焦点或者在文本框按回车触发
        /// </summary>
        bool ValidText()
        {

            string txt = this.textBox1.Text;
            if (string.IsNullOrEmpty(txt)) return false;

            if (!double.TryParse(txt, out double value))
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
                    this.comboBox1.Items.Add(new RW.Components.ListBox.ListBoxItem(item.Value, item.Key.ToString()));
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
            RW.Components.ListBox.ListBoxItem item = val as RW.Components.ListBox.ListBoxItem;
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
            Font f = new("宋体", 9, FontStyle.Bold);
            SizeF s = g.MeasureString(this.TitleText, f).ToSize();
            g.DrawString(this.TitleText, f, new SolidBrush(Color.Black), (this.Width - s.Width) / 2, 2);
        }
    }


}
