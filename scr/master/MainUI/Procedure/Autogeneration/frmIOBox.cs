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
