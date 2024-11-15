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

        public bool On
        {
            //get { return _on; }
            set
            {
                if (value)
                {
                    uiButton.FillColor = Color.FromArgb(110, 190, 40);
                    uiButton.RectColor = Color.FromArgb(110, 190, 40);
                }
                else
                {
                    uiButton.FillColor = Color.FromArgb(230, 80, 80);
                    uiButton.RectColor = Color.FromArgb(230, 80, 80);
                }
            }
        }

        public void AddToolTop(UIToolTip tip, string Headtext, string text)
        {
            foreach (Control con in Controls)
                tip.SetToolTip(con, Headtext, text);
        }

    }
}