using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RW;
using MainUI.TRDP;

namespace MainUI.MVB
{
    public partial class ucBit : UserControl, ISwitch
    {
        public ucBit()
        {
            InitializeComponent();
            EnableTitle = true;
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
                return button1.Text;
            }
            set
            {
                button1.Text = value;
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
            TitleText = string.Format("{0}.{1}", Offset, Bit);
        }

        [DefaultValue(null)]
        public DataRange Range { get; set; }
        [DefaultValue(null)]
        public bool DataRange { get; set; }
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
        //public event SwtichingHandler Switching;

        protected virtual void OnSwitchChanged(bool value)
        {
            button1.BackColor = value ? Color.SpringGreen : SystemColors.Control;
            SwitchChanged?.Invoke(this, value);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReadOnly) return;
                Switch = !Switch;
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
            Font f = new("宋体", 9, FontStyle.Bold);
            SizeF s = g.MeasureString(TitleText, f).ToSize();
            g.DrawString(TitleText, f, new SolidBrush(Color.Black), (Width - s.Width) / 2, 2);
        }

        private void ucBit_Load(object sender, EventArgs e)
        {
            //this.button1.Enabled = !ReadOnly;
        }
    }
}
