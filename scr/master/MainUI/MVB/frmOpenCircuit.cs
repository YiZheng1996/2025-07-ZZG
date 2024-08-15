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

namespace MainUI.BCU
{
    public partial class frmOpenCircuit : UIForm
    {
        public frmOpenCircuit()
        {
            InitializeComponent();
 
            // 设置SunnyUI主题
            //UIStyles.InitColorful(ResponseText.FillColor, Color.Green);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
