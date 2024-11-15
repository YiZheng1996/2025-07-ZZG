using RW;
using System.ComponentModel;

namespace MainUI.MVB
{
    public partial class ucBit : UserControl
    {
        public ucBit()
        {
            InitializeComponent();
            this.EnableTitle = true;
        }

        public string TitleText
        {
            get;
            set;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return this.button1.Text;
            }
            set
            {
                this.button1.Text = value;
            }
        }

        //[DefaultValue(true)]
        //public bool EnableTitle
        //{
        //    get { return this.label1.Visible; }
        //    set { this.label1.Visible = value; }
        //}
        [DefaultValue(true)]
        public bool EnableTitle { get; set; }

        [DefaultValue(0)]
        public int Port { get; set; }

        private int offset;
        [DefaultValue(0)]
        public int Offset
        {
            get { return offset; }
            set { offset = value; SetText(); }
        }

        private int bit;
        [DefaultValue(0)]
        public int Bit
        {
            get { return bit; }
            set { bit = value; SetText(); }
        }

        void SetText()
        {
            this.TitleText = string.Format("{0}.{1}", Offset, Bit);
        }

        [DefaultValue(null)]
        public DataRange Range { get; set; }

        [DefaultValue(false)]
        public bool ReadOnly { get; set; }

        #region ISwitch 成员

        private bool _switch;

        public bool Switch
        {
            get { return _switch; }
            set
            {
                if (_switch == value) return;
                _switch = value;
                OnSwitchChanged(value);
            }
        }


        public event SwitchHandler SwitchChanged;

        protected virtual void OnSwitchChanged(bool value)
        {
            this.button1.BackColor = value ? Color.SpringGreen : SystemColors.Control;
            if (SwitchChanged != null) SwitchChanged(this, value);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReadOnly) return;
            this.Switch = !this.Switch;
            OnClick(e);
        }

        protected override void OnClick(EventArgs e)
        {
            if (ReadOnly) return;
            base.OnClick(e);
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

        private void ucBit_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("宋体", 9, FontStyle.Bold);

            SizeF s = g.MeasureString(this.TitleText, f).ToSize();

            g.DrawString(this.TitleText, f, new SolidBrush(Color.Black), (this.Width - s.Width) / 2, 2);
        }

        private void ucBit_Load(object sender, EventArgs e)
        {
            //this.button1.Enabled = !ReadOnly;
        }
    }
}
