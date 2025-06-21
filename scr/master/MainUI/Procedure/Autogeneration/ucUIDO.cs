using Sunny.UI;
using System.ComponentModel;

namespace MainUI.Procedure.Autogeneration
{
    public partial class ucUIDO : UserControl
    {
        /// <summary>
        /// 向父窗体订阅事件
        /// </summary>
        public event EventHandler ButtonClicked;
        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        public ucUIDO()
        {
            InitializeComponent();
            uiButton.Click += UiButton_Click;
        }
        private void UiButton_Click(object sender, EventArgs e)
        {
            OnButtonClicked(e);
        }

        /// <summary>
        /// 板卡号
        /// </summary>
        [DefaultValue(0)]
        public int PortIndex { get; set; }
        public int Index { get; set; }
        public string Plug { get; set; }
        public string Plugfoot { get; set; }

        public int Sort { get; set; }

        public override string Text
        {
            get { return uiButton.Text; }
            set { uiButton.Text = value; }
        }


        public Color trueCOlor = Color.LimeGreen;
        public Color FalseColor = Color.SkyBlue;
        private void BtnColor(bool value)
        {
            if (value)
            {
                uiButton.FillColor = trueCOlor;
                uiButton.RectColor = trueCOlor;
                uiButton.FillDisableColor = trueCOlor;
                uiButton.RectDisableColor = trueCOlor;
                uiButton.FillHoverColor = trueCOlor;
                uiButton.FillPressColor = trueCOlor;
                uiButton.FillSelectedColor = trueCOlor;

            }
            else
            {
                uiButton.FillColor = FalseColor;
                uiButton.RectColor = FalseColor;
                uiButton.FillDisableColor = FalseColor;
                uiButton.RectDisableColor = FalseColor;
                uiButton.FillHoverColor = FalseColor;
                uiButton.FillPressColor = FalseColor;
                uiButton.FillSelectedColor = FalseColor;
            }
        }

        public bool On
        {
            //get { return _on; }
            set
            {
                BtnColor(value);
            }
        }

        public void AddToolTop(UIToolTip tip, string Headtext, string text)
        {
            foreach (Control con in Controls)
                tip.SetToolTip(con, Headtext, text);
        }

    }
}