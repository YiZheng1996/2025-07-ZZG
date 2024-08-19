using MainUI.BCU;
using MainUI.BLL;
using MainUI.CAN;
using MainUI.Config;
using MainUI.Model;
using MainUI.Modules;
using MainUI.Procedure;
using MainUI.Procedure.Autogeneration;
using MainUI.Procedure.Curve;
using MainUI.Procedure.SSI;
using MainUI.Procedure.Test;
using NLog.Targets;
using Sunny.UI;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormControl = System.Windows.Forms;

namespace MainUI
{
    [SupportedOSPlatform("windows")]
    public partial class ucHMI : UserControl
    {

        public delegate void RunStatusHandler(bool obj);
        public event RunStatusHandler EmergencyStatusChanged;
        public AIGrp AIgrp = null;
        public AOGrp AOgrp = null;
        public DIGrp DIgrp = null;
        public DOGrp DOgrp = null;
        public TestCon testcon = null;
        public TestPara testpara = null;
        ParaConfig paraconfig = null;
        WorkOrderConfig Workconfig = null;
        Dictionary<int, UILedBulb> dicDI = [];
        Dictionary<int, UISwitch> dicDO = [];
        Dictionary<int, UIValve> dicDCF = [];
        Dictionary<int, UIDigitalLabel> dicAI = [];
        List<UICheckBox> listChk = [];
        Dictionary<string, BaseTest> dicBase = [];
        BaseTest baseTest = new();
        string RptFilePath = "";  //报表地址
        string saveRptFile = "";  //报表保存地址
        string rn = Environment.NewLine;
        private delegate void Del();
        public ucHMI()
        {
            InitializeComponent();
        }

        //初始化
        public void Init()
        {
            try
            {
                LoaddicDI();
                LoaddicDO();
                LoaddicAI();
                Common.Init();
                AIgrp = Common.AIgrp;
                AOgrp = Common.AOgrp;
                DIgrp = Common.DIgrp;
                DOgrp = Common.DOgrp;
                testcon = Common.testcon;
                AOgrp.AOvalueGrpChaned += AOgrp_AOGroupChanged;
                AOgrp.Fresh();
                AIgrp.AIvalueGrpChanged += AIgrp_AIvalueGrpChanged;
                AIgrp.Fresh();
                DIgrp.DIGroupChanged += DIgrp_DIGroupChanged;
                DIgrp.Fresh();
                DOgrp.DOgrpChanged += DOgrp_DOgrpChanged;
                DOgrp.Fresh();
                BaseTest.TipsChanged += UcBase_TipsChanged;
                BaseTest.TimingChanged += BaseTest_TimingChanged;
                BaseTest.TestStateChanged += BaseTest_TestStateChanged;
                BaseTest.WaitStepTick += new BaseTest.WaitStepTicked(BaseTest_WaitStepTick);
            }
            catch (Exception ex)
            {
                MessageHelper.UIMessageOK("初始化错误：" + ex.Message);
            }
        }
        #region 事件
        //DO模块事件
        private void DOgrp_DOgrpChanged(object sender, int index, bool value)
        {
            if (dicDO.ContainsKey(index))
            {
                dicDO[index].Active = value;
            }
            if (dicDCF.ContainsKey(index))
            {
                dicDCF[index].Active = value;
                if (dicDCF[index].Active)
                    dicDCF[index].ValveColor = Color.FromArgb(110, 190, 40);
                else
                    dicDCF[index].ValveColor = Color.Silver;
            }
        }
        //电磁阀保持信号
        private void DCF_ActiveChanged(object sender, EventArgs e)
        {
            UIValve val = sender as UIValve;
            DOgrp[val.Tag.ToInt()] = val.Active;
        }

        //DO保持信号
        private void DO_Click(object sender, EventArgs e)
        {
            var pic = (UISwitch)sender;
            pic.Active = !pic.Active;
            DOgrp[pic.Tag.ToInt()] = !pic.Active;
        }

        ConcurrentDictionary<string, string> dicTestAI = new();
        //AI模块事件
        private void AIgrp_AIvalueGrpChanged(object sender, int index, double value)
        {
            if (dicAI.ContainsKey(index))
            {
                dicAI[index].Value = value;
                dicTestAI?.AddOrUpdate(dicAI[index].Text, dicAI[index].Value.ToString("f1"), (key, oldValue) => dicAI[index].Value.ToString("f1"));
                DataGatherHelper.AddData("BTestAI", dicTestAI);
            }
        }
        //DI模块事件
        private void DIgrp_DIGroupChanged(object sender, int index, bool value)
        {
            try
            {
                if (dicDI.ContainsKey(index))
                {
                    dicDI[index].On = value;
                }
                if (index == 0)
                {
                    EmergencyStatusChanged?.Invoke(value);
                    //if (!value)
                    //    btnStop_Click(this, null);
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("DI模块事件报错");
            }
        }
        /// <summary>
        /// AO模块事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void AOgrp_AOGroupChanged(object sender, int index, double value)
        {
            try
            {
                switch (index)
                {
                    case 0:
                        PanelVoltageInput.Value = value;
                        break;
                    case 1:
                        PanelCurrentInput.Value = value;
                        break;
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("DI模块事件报错");
            }
        }
        //写试验信息提示
        private void UcBase_TipsChanged(object sender, object info)
        {
            //this.Invoke(new Del(delegate { lblStatus.Text = info.ToString(); }));
        }
        //写试验时间
        private void BaseTest_TimingChanged(object sender, int ns)
        {
            long h, m, s;
            h = ns / 3600;
            ns %= 3600;
            m = ns / 60;
            ns %= 60;
            s = ns / 1;
            ns %= 1;
            Invoke(new Del(delegate { lblTiming.Text = h.ToString().PadLeft(2, '0') + ":" + m.ToString().PadLeft(2, '0') + ":" + s.ToString().PadLeft(2, '0'); }));
        }
        void BaseTest_WaitStepTick(int tick, string stepName)
        {
            TimeSpan ts = new(0, 0, 0, 0, tick);
            Invoke(new Del(delegate { lblTiming.Text = stepName + "：" + ts.Minutes.ToString().PadLeft(2, '0') + ":" + ts.Seconds.ToString().PadLeft(2, '0'); }));
        }

        /// <summary>
        /// 试验状态发生改变时
        /// </summary>
        private void BaseTest_TestStateChanged(bool isTesting)
        {
            btnProductSelection.Enabled = !isTesting;
            btnStart.Enabled = !isTesting;
            //btnStop.Enabled = isTesting;
            foreach (var item in listChk)
                item.Enabled = !isTesting;
        }
        #endregion

        #region 初始化
        /// <summary>
        /// 加载试验项点复选框
        /// </summary>
        private void LoadChk()
        {
            //listChk.Add(chkQiMiXing);
        }

        /// <summary>
        /// 加载DI模块
        /// </summary>
        private void LoaddicDI()
        {
            FindControlInTabPage(tabDIinput, dicDI);
        }

        /// <summary>
        /// TabPage递归添加控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tabPage"></param>
        /// <param name="controlDictionary"></param>
        public void FindControlInTabPage<T>(TabPage tabPage, Dictionary<int, T> controlDictionary) where T : FormControl.Control
        {
            foreach (FormControl.Control control in tabPage.Controls)
            {
                if (control.Tag.ToInt() > 900)
                    continue;
                if (control is T)
                    controlDictionary.Add(control.Tag.ToInt(), (T)control);
                if (control is UIGroupBox)
                    FindControlIn((UIGroupBox)control, controlDictionary);
            }
        }

        /// <summary>
        /// 递归需要用到此方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cons"></param>
        /// <param name="controlDictionary"></param>
        public void FindControlIn<T>(FormControl.Control cons, Dictionary<int, T> controlDictionary) where T : FormControl.Control
        {
            foreach (FormControl.Control control in cons.Controls)
            {
                if (control is T)
                {
                    Debug.WriteLine(string.Format("控件：{0}，Tag:{1}，Name：{2}", (T)control, control.Tag.ToInt(), control.Name));
                    controlDictionary.Add(control.Tag.ToInt(), (T)control);
                }
                //递归查找
                if (control is UIGroupBox)
                    FindControlIn((UIGroupBox)control, controlDictionary);
                if (control is UIPanel)
                    FindControlIn((UIPanel)control, controlDictionary);
                if (control is UIDigitalLabel)
                    FindControlIn((UIDigitalLabel)control, controlDictionary);
            }
        }

        /// <summary>
        /// 加载DO模块
        /// </summary>
        private void LoaddicDO()
        {
            FindControlInTabPage(tabDoOut, dicDO);
            FindControlIn(grpAirPath, dicDCF);
        }
        //加载AI模块
        private void LoaddicAI()
        {
            FindControlIn(tabAIinput, dicAI);
            FindControlIn(grpAirPath, dicAI);
        }
        #endregion

        #region 参数
        /// <summary>
        /// 读取配置文件，配置参数
        /// </summary>
        private void InitParaConfig()
        {
            try
            {
                if (Common.mTestViewModel == null)
                    return;
                paraconfig = new ParaConfig();
                paraconfig.SetSectionName(Common.mTestViewModel.ModelName);
                paraconfig.Load();
                Workconfig = new WorkOrderConfig();
                Workconfig.SetSectionName(VarHelper.PortName);
                Workconfig.Load();
                BaseTest.para = paraconfig;
            }
            catch (Exception ex)
            {
                MessageHelper.UIMessageOK("读取参数配置错误：" + ex.Message);
            }
        }
        #endregion

        #region 报表
        void ShowReport()
        {
            try
            {
         
            }
            catch (Exception ex)
            {
                MessageHelper.UIMessageOK("报表打开错误：" + ex.Message);
            }

        }
        /// <summary>
        /// 试验报表
        /// </summary>
        private void BtnReport_Click(object sender, EventArgs e)
        {
            ShowReport();
        }

        /// <summary>
        /// 加载报表
        /// </summary>
        private void Report_Opened(object sender, EventArgs e)
        {
            try
            {
            
            }
            catch (Exception ex)
            {
                MessageHelper.UIMessageOK("加载报表错误" + ex.Message);
            }
        }
        #endregion

        //产品选择
        private void BtnProductSelection_Click(object sender, EventArgs e)
        {
            frmSpec fs = new();
            fs.ShowDialog();
            SRefresh();
        }

        //刷新型号
        public void SRefresh()
        {
            if (string.IsNullOrEmpty(Common.mTestViewModel.ModelName))
                return;

            txtType.Text = Common.mTestViewModel.ModelType;
            txtModel.Text = Common.mTestViewModel.ModelName;
            InitParaConfig();
            Common.mResultAll = new ResultAll();
            dicBase.Clear();
            dicBase.Add("NoiseTestKey", new NoiseTest());
            dicBase.Add("LeakCheckKey", new LeakCheckTest());
            dicBase.Add("AirTestKey", new AirTest());
            dicBase.Add("AroundTestKey", new AroundTest());
        }

        //全选
        private void ChkAll_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (UICheckBox item in listChk)
            //    item.Checked = chkAll.Checked;
        }

        #region 实时数据记录
        private Task Auto;
        bool isOperationStarted = false;
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (VarHelper.ModelID is 0) { MessageHelper.UIMessageOK("型号未选择！"); return; }
            Color startColor = Color.FromArgb(110, 190, 40);
            Color endColor = Color.FromArgb(255, 128, 128);
            if (!isOperationStarted)//开始
            {
                Invoke(() =>
                {
                    timer1.Start();
                    uiPresentation.AppendText("数据记录开始时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n");
                    btnStart.FillColor = btnStart.RectColor = endColor;
                    btnStart.Text = "暂停记录数据";
                });
                DataGatherHelper.manual.Set();
                isOperationStarted = true;
            }
            else //结束
            {
                Invoke(() =>
                {
                    timer1.Stop();
                    uiPresentation.AppendText("数据记录暂停时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n");
                    btnStart.FillColor = btnStart.RectColor = startColor;
                    btnStart.Text = "开始记录数据";
                });
                DataGatherHelper.manual.Reset();
                isOperationStarted = false;
            }
            if (Auto?.Status == TaskStatus.Running) return;
            Auto = DataGatherHelper.DataGather();
        }

        /// <summary>
        /// 试验开始前需做的操作
        /// </summary>
        private void BeginTest()
        {
            AOgrp.CAO00 = 0;
            for (int i = 0; i < DOgrp.DOlist.Length; i++)
            {
                if (i == 5)
                    continue;
                DOgrp[i] = false;
            }
        }
        /// <summary>
        /// 试验开始后需做的操作
        /// </summary>
        private void EndTest()
        {
            AOgrp.CAO00 = 0;
            for (int i = 0; i < DOgrp.DOlist.Length; i++)
            {
                if (i == 5)
                    continue;
                DOgrp[i] = false;
            }
        }

        /// <summary>
        /// 试验线程
        /// </summary>
        public void TestStart()
        {
            try
            {
                string tip = "";
                tip += "请先确保如下事项：                  " + rn;
                tip += "1、请确认产品安装是否正确。           " + rn;
                tip += "点击【是】开始试验，点击【否】返回。" + rn;
                DialogResult dr = MessageBox.Show(this, tip, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.No) return;
                BeginTest();
                foreach (var item in listChk)
                {
                    if (item.Checked)
                    {
                        item.BackColor = Color.Yellow;
                        dicBase[item.Tag.ToString()].BeginTestItem();
                        bool isOk = dicBase[item.Tag.ToString()].Execute();
                        if (isOk)
                            item.BackColor = Color.LightGreen;
                        else
                            item.BackColor = Color.Salmon;
                        dicBase[item.Tag.ToString()].EndTestItem();
                    }
                }
                baseTest.TestStatus(false);
                EndTest();
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("试验中断");
            }
        }
        #endregion

        frmIOBox box;
        private void BtnIOBox_Click(object sender, EventArgs e)
        {
            if (box == null)
            {
                box = new frmIOBox();
                box.Show();
            }
            else
                box.Show();
        }

        private void UibtnCurve_Click(object sender, EventArgs e)
        {
            frmCurve frmcurve = new();
            frmcurve.ShowDialog();
        }

        private void UibtnSSIDataMonitor_Click(object sender, EventArgs e)
        {
            frmSSI frmSSI = new();
            frmSSI.ShowDialog();
        }

        int sj = 0;
        readonly Random Random = new();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            sj++;
            BaseTest_TimingChanged(null, sj);

            //测试用
            foreach (var item in dicAI)
            {
                dicAI[item.Key].Value = Random.NextDouble() * 1000;
                dicTestAI?.AddOrUpdate(dicAI[item.Key].Text, dicAI[item.Key].Value.ToString("f1"), (key, oldValue) => dicAI[item.Key].Value.ToString("f1"));
                DataGatherHelper.AddData("BTestAI", dicTestAI);
            }
            //foreach (var pipe in grpAirPath.GetControls<UIPipe>())
            //{
            //    pipe.Invalidate();
            //}
        }

        /// <summary>
        /// 刷新DIDO界面
        /// </summary>
        private void InitDODI()
        {

        }

        private void UibtnOnekeyChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (VarHelper.ModelID == 0 || txtModel.Text == null) { MessageHelper.UIMessageOK("没有选择型号，不能一键切换。"); return; }

                if (!MessageHelper.UIMessageYes(null, "请确认型号[" + txtModel.Text + "]是否选择正确？"))
                    return;
                frmRocess Fun = new();
                new Thread(new ThreadStart(() => { Invoke(new MethodInvoker(delegate { Fun.ShowDialog(); BringToFront(); })); })).Start();
                ThreadPool.QueueUserWorkItem(delegate
                {
                    //TODO:切换前关闭制动柜电源
                    ModbusOnekeyChange.ChangeDODI(VarHelper.ModelID);
                    ModbusOnekeyChange.AllSuspendInMidair();

                    //TODO:======================暂时注释 20200724
                    //if (MessageBox.Show("确定要设定初始值吗", "设定初始值提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    //    return;
                    //ModbusOnekeyChange.OutputInitvalue(vmodel.ModelID);
                    //======================暂时注释

                    InitDODI();
                    btnStart.Enabled = true;
                    Invoke(new MethodInvoker(delegate { MessageHelper.UIMessageOK("切换输入输出，设定初始值完成。"); }));
                    Fun.Close();
                    Fun.Dispose();
                });
            }
            catch (Exception ex)
            {
                string err = "一键切换失败，请检查设备是否正确连接。具体原因：" + ex.Message;
                MessageHelper.UIMessageOK("一键切换提示" + err);
            }
        }

        private void btnCANPowerDown_Click(object sender, EventArgs e)
        {
            NlogHelper.Default.Debug("打开CAN掉电试验界面");
            NlogHelper.Default.Error("打开CAN掉电试验界面");
            NlogHelper.Default.Trace("打开CAN掉电试验界面");
            NlogHelper.Default.Info("打开CAN掉电试验界面");
            NlogHelper.Default.Warn("打开CAN掉电试验界面");
            NlogHelper.Default.Fatal("打开CAN掉电试验界面");
            frmPowerDown powerdown = new();
            powerdown.ShowDialog();
        }

        private void btnDataAnalysis_Click(object sender, EventArgs e)
        {
            frmAnalysis analy = new();
            analy.ShowDialog();
        }

        private void btnResponseTest_Click(object sender, EventArgs e)
        {
            frmOpenCircuit frmOpen = new();
            frmOpen.ShowDialog();
        }

        private void btnVoltageInput_Click(object sender, EventArgs e)
        {
            double value = 0;
            if (UIInputDialog.ShowInputDoubleDialog(ref value, UIStyle.Inherited, 1, true, "请输入0-150V电压值"))
            {
                if (value > 150.0)
                    value = 150.0;
                AOgrp.CAO00 = value;
            }
        }

        private void btnCurrentInput_Click(object sender, EventArgs e)
        {
            double value = 0;
            if (UIInputDialog.ShowInputDoubleDialog(ref value, UIStyle.Inherited, 1, true, "请输入0-60A电流值"))
            {
                if (value > 60)
                    value = 60.0;
                AOgrp.CAO01 = value;
            }
        }

        private void uiPresentation_TextChanged(object sender, EventArgs e)
        {
            uiPresentation.ScrollToCaret();
        }


        private void panelEx10_Click(object sender, EventArgs e)
        {
           
        

        }

    }
}
