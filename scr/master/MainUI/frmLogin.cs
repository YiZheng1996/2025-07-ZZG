using RW.EventLog;
using System.Data;

namespace MainUI
{
    [SupportedOSPlatform("windows")]
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        UserBLL bllUser = null;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                lblSoftName.Text = VarHelper.SoftName;
                bllUser = new BLL.UserBLL();
                txtPassword.Focus();
                DataSet ds = bllUser.GetSortedList();
                cboUsername.DataSource = ds.Tables[0];
                cboUsername.DisplayMember = "Username";
                cboUsername.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                lblMessage.Text = "获取用户信息失败" + ex.Message;
                lblMessage.Visible = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string username = cboUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username))
            {
                lblMessage.Text = "请选择要登录的用户!";
                lblMessage.Visible = true;
                cboUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {

                lblMessage.Text = "密码不能为空，请重新输入!";
                lblMessage.Visible = true;
                txtPassword.Focus();
                return;
            }

            int id = Convert.ToInt32(cboUsername.SelectedValue);
            DataTable dsUser = bllUser.Get(id);
            if (dsUser.Rows.Count > 0)
            {
                if (dsUser.Rows[0]["password"].ToString() != password)
                {
                    lblMessage.Text = "密码错误，请重新输入!";
                    lblMessage.Visible = true;
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    CurrencyHelper.RWUser.User.InitUser(dsUser.Rows[0]);
                    EventLogHelper.Log(EventLogType.Normal, "用户" + CurrencyHelper.RWUser.User.Username + "登录。");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                lblMessage.Text = "未找到该用户!";
                lblMessage.Visible = true;
                return;
            }
        }
    }
}