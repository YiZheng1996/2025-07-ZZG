using System;
using System.Windows.Forms;
using MainUI.Properties;
using MainUI.Procedure;
using MainUI.Modules;
using RW.EventLog;
using RW.Components.User;
using System.Drawing;
using MainUI.Procedure.User;
using MainUI.Procedure.ExcelImport;
using MainUI.MVB;
using MainUI.Procedure.Curve;
using MainUI.TRDP;
using MainUI.CAN;

namespace MainUI
{
    public partial class frmMainMenu : Form
    {
        public ucHMI hmi = null;
        frmHardWare hard;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        OpcStatusGrp opcStatus;
        public frmMainMenu()
        {
            InitializeComponent();
            lblTitle.Text = VarHelper.SoftName;
            Text = VarHelper.SoftName;
            timer1_Tick(null, null);
        }
        /// <summary>
        /// C#winform实现界面拖动
        /// </summary>
        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                //Common.Init();
                hmi = new ucHMI();
                hmi.EmergencyStatusChanged += new ucHMI.RunStatusHandler(hmi_EnmergencyStatusChanged);
                hmi.Dock = DockStyle.Fill;
                hmi.Init();
                BaseTest.TestStateChanged += BaseTest_TestStateChanged;
                opcStatus = Common.opcStatus;
                hard = new frmHardWare();
                hard.InitZeroGain();
                splitContainer1.Panel2.Controls.Add(hmi);
                timer1_Tick(null, null);
                RW.Components.User.BLL.UserBLL userBll = new();

                //int level = userBll.GetPermissionLevel(RW.UI.RWUser.User.Permission);
                switch (RWUser.User.Permission)
                {
                    case "管理员"://系统管理员
                        break;
                    case "工艺员"://工程师
                        this.btnMainData.Visible = false;
                        break;
                    case "操作员"://操作员
                        this.btnMainData.Visible = false;
                        this.btnHardwareTest.Visible = false;
                        break;
                    default:
                        this.btnMainData.Visible = false;
                        this.btnHardwareTest.Visible = false;
                        break;
                }
                timerPLC.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BaseTest_TestStateChanged(bool isTesting)
        {
            btnHardwareTest.Enabled = !isTesting;
            btnMainData.Enabled = !isTesting;
            //btnReports.Enabled = !isTesting;
            btnChangePwd.Enabled = !isTesting;
            btnExit.Enabled = !isTesting;
        }

        /// <summary>
        /// 显示界面时间
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 急停事件
        /// </summary>
        /// <param name="obj"></param> 
        private void hmi_EnmergencyStatusChanged(bool obj)
        {
            if (!obj)
            {
                this.splitContainer1.Panel2.Enabled = false;
                EventLogHelper.Log(EventLogType.Error, "急停被按下。" + RWUser.User.Username);
                this.picRunStatus.Image = Resources.scram;
                //Common.DOgrp[1] = true;
            }
            else
            {
                this.splitContainer1.Panel2.Enabled = true;
                this.picRunStatus.Image = Resources.normal;
                // Common.DOgrp[1] = false;
            }
        }

        /// <summary>
        /// 硬件校准
        /// </summary>
        private void btnHardwareTest_Click(object sender, EventArgs e)
        {
            frmHardWare hard = new();
            hard.ShowDialog();
        }
        /// <summary>
        /// 数据管理
        /// </summary>
        private void btnMainData_Click(object sender, EventArgs e)
        {
            frmParameterSettings frm = new();
            frm.ShowDialog();
            hmi.SRefresh();
        }
        /// <summary>
        /// 数据回放
        /// </summary>
        private void btnDataPlayback_Click(object sender, EventArgs e)
        {
            frmDataPlayback fdm = new();
            fdm.ShowDialog();
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            frmChangePwd changePwd = new();
            changePwd.ShowDialog();
        }
        /// <summary>
        /// 注销
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        /// <summary>
        /// 退出
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageHelper.UIMessageYes(this, "请确认是否退出？"))
            {
                VarHelper.Close();
                Application.Exit();
                Environment.Exit(0);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void timerPLC_Tick(object sender, EventArgs e)
        {
            try
            {
                tslblUser.Text = "当前登录用户：" + RWUser.User.Username;
                tslblPLC.Text = opcStatus.NoError ? " PLC连接正常 " : " PLC连接失败 ";
                tslblPLC.BackColor = opcStatus.NoError ? Color.FromArgb(110, 190, 40) : Color.Salmon;
                if (opcStatus.Simulated)
                    tslblPLC.Text = tslblPLC.Text + " 仿真模式 ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDataImport_Click(object sender, EventArgs e)
        {
            frmImpExcel excel = new();
            excel.ShowDialog();
        }

        private void BtnTRDP_Click(object sender, EventArgs e)
        {
            if (VarHelper.ModelID == 0) { MessageHelper.UIMessageOK("型号未选择！"); return; }
            frmTRDPMonitor tRDPMonitor = new();
            tRDPMonitor.ShowDialog();
        }

        private void btnMVB_Click(object sender, EventArgs e)
        {
            if (VarHelper.ModelID == 0) { MessageHelper.UIMessageOK("型号未选择！"); return; }
            frmTagsNew frmTagsNew = new();
            frmTagsNew.ShowDialog();
        }

        private void btnCAN_Click(object sender, EventArgs e)
        {
            if (VarHelper.ModelID == 0) { MessageHelper.UIMessageOK("型号未选择！"); return; }
            frmCANTags frmCAN = new();
            frmCAN.ShowDialog();
        }
    }
}
