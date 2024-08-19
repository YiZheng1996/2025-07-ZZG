using System;
using System.Windows.Forms;

namespace MainUI
{
    public partial class frmDispReport : Form
    {
        private string filename;
        public frmDispReport(string file)
        {
            InitializeComponent();
            filename = file;
        }
        private void frmDispReport_Load(object sender, EventArgs e)
        {

        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
