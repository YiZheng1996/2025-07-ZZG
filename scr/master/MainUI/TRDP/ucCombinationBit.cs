namespace MainUI.TRDP
{
    public partial class ucCombinationBit : UserControl
    {
        public ucCombinationBit()
        {
            InitializeComponent();
        }

        public event EventHandler CheckClicked;
        private void checkName_CheckedChanged(object sender, EventArgs e)
        {
            CheckClicked?.Invoke(this, e);
        }

        public string labText
        {
            get { return labName.Text; }
            set { labName.Text = value; }
        }

        public string ckText
        {
            get { return checkName.Text; }
            set { checkName.Text = value; }
        }

        public bool ckChecked
        {
            get { return checkName.Checked; }
            set { checkName.Checked = value; }
        }

        public Color ckColor
        {
            get { return checkName.BackColor; }
            set { checkName.BackColor = value; }
        }

        private int ucindex;
        public int ucIndex
        {
            get { return ucindex; }
            set { ucindex = value; }
        }
    }
}
