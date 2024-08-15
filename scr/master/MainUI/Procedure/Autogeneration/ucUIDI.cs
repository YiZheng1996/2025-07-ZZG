using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RW;
using Sunny.UI;

namespace MainUI.Procedure.Autogeneration
{
    public partial class ucUIDI : UserControl
    {
        public ucUIDI()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get { return uiLabel.Text; }
            set { uiLabel.Text = value; }
        }

        public int Index { get; set; }

        public int PortIndex { get; set; }

        public string Plug { get; set; }
        public string Plugfoot { get; set; }

        public bool Switch
        {
            get { return uiLedBulb.On; }
            set { uiLedBulb.On = value; }
        }

        public Size TestSize
        {
            get { return Size = new Size(); }
            set { Size = value; }
        }
        
        public event SwitchHandler SwitchChanged;
        protected virtual void OnSwitchChanged(bool value)
        {
            SwitchChanged?.Invoke(this, value);
        }

        private void switchPictureBox1_SwitchChanged(object sender, bool value)
        {
            OnSwitchChanged(value);
        }
        
        public void AddToolTop(UIToolTip tip, string Headtext, string text)
        {
            foreach (Control con in Controls)
                tip.SetToolTip(con, Headtext, text);
        }

    }
}
