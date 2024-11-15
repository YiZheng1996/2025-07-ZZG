namespace MainUI.Procedure.Autogeneration
{
    public partial class frmIOBox : UIForm
    {
        public frmIOBox()
        {
            InitializeComponent();
            uiPanel1.Controls.Add(new ucIOBox());
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
