using MainUI.Procedure.User;

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
            main.AddNodes("网关IP管理", new ucGateway());
            main.AddNodes("试验项点管理", new ucTestPoint());
            main.AddNodes("例行试验项点管理", new ucTestStep());
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
