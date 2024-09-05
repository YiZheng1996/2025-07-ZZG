using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using RW.UI.BLL;
using RW.EventLog;
using MainUI.Config;
using MainUI.Procedure;
using MainUI.CurrencyHelper;

namespace MainUI
{
    public partial class NewfrmLogin : Form
    {
        public NewfrmLogin()
        {
            InitializeComponent();
        }

        RW.Components.User.BLL.UserBLL bllUser = null;
        BLL.UserBLL userbll = null;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        WorkOrderConfig Workconfig = null;
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Parent = pictureBox1;
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                bllUser = new RW.Components.User.BLL.UserBLL();
                userbll = new BLL.UserBLL();
                txtJobNumber.Focus();
                Workconfig = new WorkOrderConfig();
                Workconfig.SetSectionName(VarHelper.PortName);
                Workconfig.Load();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "数据库连接失败" + ex.Message;
                lblMessage.Visible = true;
            }

            try
            {
                DataSet ds = bllUser.GetSortedList();
                this.cboUsername.DataSource = ds.Tables[0];
                this.cboUsername.DisplayMember = "Username";
                this.cboUsername.ValueMember = "ID";
            }
            catch (Exception)
            {
                lblMessage.Text = "获取用户信息失败";
                lblMessage.Visible = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = this.cboUsername.Text;
            string password = this.txtPassword.Text;
            string jobnumber = this.txtJobNumber.Text;
            //if (string.IsNullOrEmpty(username))
            //{
            //    lblMessage.Text = "请选择要登录的用户!";
            //    lblMessage.Visible = true;
            //    this.cboUsername.Focus();
            //    return;
            //}

            if (string.IsNullOrEmpty(jobnumber))
            {
                lblMessage.Text = "作业人员工号不能为空，请重新输入!";
                lblMessage.Visible = true;
                this.txtJobNumber.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "密码不能为空，请重新输入!";
                lblMessage.Visible = true;
                this.txtPassword.Focus();
                return;
            }

            int id = Convert.ToInt32(cboUsername.SelectedValue);
            if (id == 0)
            {
                lblMessage.Text = "当前作业人员工号不存在，请重新输入!";
                lblMessage.Visible = true;
                this.txtJobNumber.Focus();
                return;
            }
            DataTable dsUser = bllUser.Get(id);
            if (dsUser.Rows.Count > 0)
            {
                if (dsUser.Rows[0]["password"].ToString() != password)
                {
                    lblMessage.Text = "密码错误，请重新输入!";
                    lblMessage.Visible = true;
                    this.txtPassword.Focus();
                    return;
                }
                else
                {
                    //RW.UI.RWUser.User.InitUser(dsUser.Rows[0]);
                    RWUser.User.InitUser(dsUser.Rows[0]);
                    EventLogHelper.Log(EventLogType.Normal, "用户" + RWUser.User.Username + "登录。");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                lblMessage.Text = "未找到该用户!";
                lblMessage.Visible = true;
                return;
            }

            WorkOrderHelper wk = new WorkOrderHelper();
            Dictionary<string, string> dictest = new Dictionary<string, string>();
            dictest.Add("UserName", Workconfig.Devid);
            dictest.Add("Password", Workconfig.Authorization);
            await wk.LoadToken(Workconfig.Auth, dictest);
        }
    }
}