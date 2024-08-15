using MainUI.CAN;
using MainUI.MVB;
using MainUI.Procedure;
using MainUI.Procedure.User;
using MainUI.TRDP;
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

namespace MainUI
{
    public partial class frmParameterSettings : UIForm
    {
        public frmParameterSettings()
        {
            InitializeComponent();
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            FrmSettingMain main = new();
            main.AddNodes("用户管理", new ucUserManager());
            main.AddNodes("型号管理", new ucModelManage());
            main.AddNodes("参数管理", new ucTestParams());
            main.AddNodes("IP管理", new ucGateway());
            main.ShowDialog();
        }

        private void btnCommunicateMVB_Click(object sender, EventArgs e)
        {
            MVB.frmPortManager port = new();
            port.ShowDialog();
            port.Dispose();
        }

        private void btnCommunicateTRDP_Click(object sender, EventArgs e)
        {
            TRDP.frmPortManager port = new();
            port.ShowDialog();
        }

        private void btnCommunicateCAN_Click(object sender, EventArgs e)
        {
            frmCANPortManager port = new();
            port.ShowDialog();
        }
    }
}
