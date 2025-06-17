using MainUI.ViewModel;
using RW;
using RW.DSL;
using RW.DSL.Modules;
using RW.DSL.Procedures;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MainUI;
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
    Report.Report report = new();
    WorkOrderConfig Workconfig = null;
    Dictionary<int, UILedBulb> dicDI = [];
    Dictionary<int, UISwitch> dicDO = [];
    Dictionary<int, UIValve> dicDCF = [];
    Dictionary<int, UIDigitalLabel> dicAI = [];
    List<UICheckBox> listChk = [];
    BaseTest baseTest = new();
    frmMainMenu frm = new();
    string path2 = Application.StartupPath + @"reports\report.xls";
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
        Invoke(() => { lblTiming.Text = h.ToString().PadLeft(2, '0') + ":" + m.ToString().PadLeft(2, '0') + ":" + s.ToString().PadLeft(2, '0'); });
    }
    void BaseTest_WaitStepTick(int tick, string stepName)
    {
        TimeSpan ts = new(0, 0, 0, 0, tick);
        Invoke(() => { lblTiming.Text = stepName + "：" + ts.Minutes.ToString().PadLeft(2, '0') + ":" + ts.Seconds.ToString().PadLeft(2, '0'); });
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
    public void FindControlInTabPage<T>(Control tabPage, Dictionary<int, T> controlDictionary) where T : Control
    {
        foreach (FormControl.Control control in tabPage.Controls)
        {
            if (control.Tag.ToInt() > 900)
                continue;
            if (control is T t)
                controlDictionary.Add(control.Tag.ToInt(), t);
            if (control is UIGroupBox box)
                FindControlIn(box, controlDictionary);
            if (control is UITitlePanel panel)
                FindControlIn(panel, controlDictionary);
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
            if (control is T t)
            {
                Debug.WriteLine(string.Format("控件：{0}，Tag:{1}，Name：{2}", t, control.Tag.ToInt(), control.Name));
                controlDictionary.Add(control.Tag.ToInt(), t);
            }
            //递归查找
            if (control is UIGroupBox box1)
                FindControlIn(box1, controlDictionary);
            if (control is UIPanel panel)
                FindControlIn(panel, controlDictionary);
            if (control is UIDigitalLabel label)
                FindControlIn(label, controlDictionary);
        }
    }

    /// <summary>
    /// 加载DO模块
    /// </summary>
    private void LoaddicDO()
    {
        FindControlInTabPage(tabDoOut, dicDO);
        FindControlInTabPage(tabDoOut2, dicDO);
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
            BaseTest.paraconfig = paraconfig;
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

    #region DSL初始化  
    private readonly Dictionary<string, DSLProcedure> DicProcedureModules = [];
    readonly Dictionary<string, DSLModule> modules = DSLModuleHelper.GetModulesWithFile(Environment.CurrentDirectory + @"\Modules\MyModules.ini");
    //Timer_ModelPiece doumelpiece = null;
    //Timer_ModelPiece doumelpieceRoseBow = null;
    //RWrpt rpt = null;
    /// <summary>
    /// 根据型号加载DSL自动试验rw1文件
    /// </summary>
    /// <param name="ModelName"></param>
    public void ModelLoadDSL(string ModelID)
    {
        DicProcedureModules.Clear();
        TestDSLNameBLL DSLNameBLL = new();
        DataTable dt = DSLNameBLL.GetDSLName(ModelID);
        //if (modules.Count < 1) MessageBox.Show(this, "DSL点位模块加载失败！");
        Dictionary<string, object> modules2 = [];
        //modules2["报表"] = rpt = new RWrpt(this, rwReport1);
        //modules2["参数"] = paraconfig;
        DSLModuleHelper.InitModules(modules);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string ProcessKey = dt.Rows[i]["ProcessKey"].ToString();
            string ProcessName = dt.Rows[i]["ProcessName"].ToString();
            string Sort = dt.Rows[i]["Sort"].ToString();
            string xuhao = Sort.PadLeft(2, '0');
            string DSLName = xuhao + ProcessName + ".rw1";
            string ModelName = VarHelper.ModelName;
            string DSLNamePath = $"{Application.StartupPath}Procedure\\{ModelName}\\{DSLName}";
            Creation(ModelName, DSLName);
            if (File.Exists(DSLNamePath))
            {
                var proc = DSLFactory.CreateProcedure(DSLNamePath);
                proc.AddModules(modules);
                proc.AddModules(modules2);
                DicProcedureModules.Add(ProcessKey, proc);
                DicProcedureModules[ProcessKey].DomainEventInvoked += new DomainHandler<object>(Visitor_DomainEventInvoked);
            }
            else
            {
                MessageBox.Show($"试验项点：{ProcessName},找不到自动试验文件！");
                return;
            }
        }
    }

    private void Visitor_DomainEventInvoked(object sender, string name, List<object> output)
    {
        Debug.WriteLine($"监听事件：{name}  值数量：{output.Count}");
    }

    /// <summary>
    /// 根据数据库配置自动生成 项点rw1文件
    /// </summary>
    /// <param name="ModelName">型号</param>
    /// <param name="DSLName">试验项点名称</param>
    private void Creation(string ModelName, string DSLName)
    {
        try
        {
            string ModelNamePath = $"{Application.StartupPath}Procedure\\{ModelName}";
            string DSLNamePath = $"{ModelNamePath}\\{DSLName}";
            if (!Directory.Exists(ModelNamePath))
                Directory.CreateDirectory(ModelNamePath);
            if (!File.Exists(DSLNamePath))
            {
                File.Create(DSLNamePath).Dispose();
                using (new StreamWriter(DSLNamePath, true, System.Text.Encoding.GetEncoding("UTF-8"))) { }
            }
        }
        catch (Exception ex)
        {
            string err = ex.Message;
            MessageBox.Show($"自动创建试验项点失败：{err}");
        }
    }
    #endregion

    //产品选择
    private void BtnProductSelection_Click(object sender, EventArgs e)
    {
        frmSpec fs = new();
        VarHelper.ShowDialogWithOverlay(frm, fs);
        if (fs.DialogResult == DialogResult.OK)
        {
            SRefresh();
            isSwitch = true;  //TODO:暂时为true
            FormManager.FormsClosing();
            LoadTestItems();
            ModelLoadDSL(VarHelper.ModelID.ToString());
            LoadRep(paraconfig.RptFile);
        }
    }

    private void LoadRep(string Path)
    {
        try
        {
            if (!string.IsNullOrEmpty(Path))
            {
                string filePath = Application.StartupPath + "reports\\" + Path;
                report.Dock = DockStyle.Fill;
                if (report.Filename != filePath)
                {
                    SystemHelper.KillProcess("EXCEL");
                    Thread.Sleep(200);
                    File.Copy(filePath, path2, true);
                    report.Filename = path2;
                    report.Init();  //办公室暂时注释
                    if (!tabPageReport.Controls.Contains(report))
                        tabPageReport.Controls.Add(report);
                }
            }
        }
        catch (Exception ex)
        {
            NlogHelper.Default.Error("报表加载错误：", ex);
        }
    }

    //刷新型号
    public void SRefresh()
    {
        if (string.IsNullOrEmpty(Common.mTestViewModel.ModelName))
            return;
        InitParaConfig();
        txtModel.Text = Common.mTestViewModel.ModelName;
        Common.mResultAll = new ResultAll();
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
        try
        {
            if (VarHelper.ModelID is 0) { MessageHelper.UIMessageOK("型号未选择！"); return; }
            Color startColor = Color.FromArgb(80, 160, 255);
            Color endColor = Color.FromArgb(255, 128, 128);
            if (!isOperationStarted)//开始
            {
                Invoke(() =>
                {
                    if (Auto?.Status == TaskStatus.Running) return;
                    DataGatherHelper.ClearData();
                    Auto = DataGatherHelper.DataGather();
                    timer1.Start(); time = 0;
                    //uiPresentation.AppendText("开始时间:" + DateTime.Now.ToString("HH:mm:ss fff") + "\n");
                    btnStart.FillColor = btnStart.RectColor = endColor;
                    btnStart.Text = "停止记录数据";
                });
                isOperationStarted = true;
            }
            else //结束
            {
                Invoke(() =>
                {
                    timer1.Stop();
                    //uiPresentation.AppendText("停止时间:" + DateTime.Now.ToString("HH:mm:ss fff") + "\n");
                    btnStart.FillColor = btnStart.RectColor = startColor;
                    btnStart.Text = "开始记录数据";
                });
                DataGatherHelper.DataCts.Cancel();
                isOperationStarted = false;
                MovePathName(DataGatherHelper.filePath);
            }
        }
        catch (Exception ex)
        {
            NlogHelper.Default.Error("试验记录开启、停止错误：", ex);
            MessageHelper.UIMessageOK("试验记录开启、停止错误：" + ex.Message);
        }
    }

    // 更改文件名
    private void MovePathName(string path)
    {
        try
        {
            if (!Directory.Exists(path))
            {
                string filePath = Path.GetDirectoryName(path);
                string name = Path.GetFileNameWithoutExtension(path);
                name += "--" + DateTime.Now.ToString("HH：mm：ss");
                var newPath = filePath + "\\" + name + ".csv";
                Directory.Move(path, newPath);
            }
        }
        catch (Exception ex)
        {
            NlogHelper.Default.Error("更改文件名错误：", ex);
            MessageHelper.UIMessageOK("更改文件名错误：" + ex.Message);
        }
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
    #endregion

    private void BtnIOBox_Click(object sender, EventArgs e)
    {
        if (!isSwitch)
        {
            MessageHelper.UIMessageOK("请先设置IO箱，一键切换！");
            return;
        }
        FormManager.ShowForm<frmIOBox>();
    }

    private void UibtnCurve_Click(object sender, EventArgs e)
    {
        frmCurve frmcurve = new();
        VarHelper.ShowDialogWithOverlay(frm, frmcurve);
    }

    private void UibtnSSIDataMonitor_Click(object sender, EventArgs e)
    {
        frmSSI frmSSI = new();
        VarHelper.ShowDialogWithOverlay(frm, frmSSI);
    }

    int time = 0;
    readonly Random Random = new();
    private void Timer1_Tick(object sender, EventArgs e)
    {
        time++;
        BaseTest_TimingChanged(null, time);

        //测试用
        foreach (var item in dicAI)
        {
            //dicAI[item.Key].Value = Random.NextDouble() * 1000;
            dicTestAI?.AddOrUpdate(dicAI[item.Key].Text, dicAI[item.Key].Value.ToString("f1"), (key, oldValue) => dicAI[item.Key].Value.ToString("f1"));
            DataGatherHelper.AddData("BTestAI", dicTestAI);
        }
        //foreach (var pipe in grpAirPath.GetControls<UIPipe>())
        //{
        //    pipe.Invalidate();
        //}
    }

    //TODO:暂时为true
    private bool isSwitch = true; //检测是否一键切换标志位
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
                //切换前关闭制动柜电源
                DOgrp[63] = false;
                ModbusOnekeyChange.ChangeDODI(VarHelper.ModelID);
                ModbusOnekeyChange.AllSuspendInMidair();

                //TODO:======================暂时注释 20200724
                //if (MessageBox.Show("确定要设定初始值吗", "设定初始值提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                //    return;
                //ModbusOnekeyChange.OutputInitvalue(vmodel.ModelID);
                //======================暂时注释

                btnStart.Enabled = true;
                FormManager.openForms.Remove(typeof(frmIOBox));
                Invoke(new MethodInvoker(delegate { MessageHelper.UIMessageOK("切换输入输出，设定初始值完成。"); }));
                Fun.Close();
                Fun.Dispose();
                isSwitch = true;
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
        frmPowerDown powerdown = new();
        VarHelper.ShowDialogWithOverlay(frm, powerdown);
    }

    private void btnDataAnalysis_Click(object sender, EventArgs e)
    {
        frmAnalysis analy = new();
        VarHelper.ShowDialogWithOverlay(frm, analy);

    }

    private void btnResponseTest_Click(object sender, EventArgs e)
    {
        frmOpenCircuit frmOpen = new();
        VarHelper.ShowDialogWithOverlay(frm, frmOpen);
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
        //uiPresentation.ScrollToCaret();
    }

    bool isExhausting = false;
    private void BtnExhaust_Click(object sender, EventArgs e)
    {
        if (isExhausting)
        {
            UIMessageBox.Show("正在排气中···");
            return;
        }

        Color startColor = Color.FromArgb(80, 160, 255);
        Color endColor = Color.FromArgb(255, 128, 128);
        BtnExhaust.FillColor = BtnExhaust.RectColor  = endColor;
        BtnExhaust.Text = "排气中···";
        //uiPresentation.AppendText("一键排气启动:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n");
        Task.Run(() =>
        {
            isExhausting = true;
            DOgrp[74] = false;
            DOgrp[80] = false;
            DOgrp[83] = false;
            DOgrp[91] = false;
            DOgrp[87] = false;
            DOgrp[86] = false;
            DOgrp[80] = false;
            DOgrp[75] = true;
            DOgrp[77] = true;
            DOgrp[84] = true;
            DOgrp[76] = true;
            DOgrp[78] = true;
            DOgrp[79] = true;
            DOgrp[90] = true;
            DOgrp[82] = true;
            DOgrp[91] = true;
            DOgrp[85] = true;
            DOgrp[92] = true;
            DOgrp[82] = true;
            DOgrp[81] = true;
            DOgrp[93] = true;
            DOgrp[94] = true;
            DOgrp[95] = true;
            DOgrp[96] = true;
            DOgrp[97] = true;
            DOgrp[98] = true;
            DOgrp[99] = true;
            DOgrp[100] = true;
            Task.Delay(10000).Wait();
            for (int i = 74; i <= 100; i++) DOgrp[i] = false;
            isExhausting = false;
            BtnExhaust.Text = "开始排气";
            BtnExhaust.FillColor = BtnExhaust.RectColor = startColor;
            //uiPresentation.AppendText("一键排气完成:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n");
        });

    }

    private void LoadTestItems()
    {
        TestStepBLL bll = new();
        List<TestStep> stepList = bll.GetStepByModelID(VarHelper.ModelName);
        lvTestItem.Items.Clear();
        if (stepList.Count < 1) return;
        lvTestItem.Columns[0].Width = 400;
        lvTestItem.Columns[1].Width = 1;
        lvTestItem.Columns[2].Width = 1;
        lvTestItem.Columns[3].Width = 1;
        lvTestItem.Columns[4].Width = 1;

        for (int i = 0; i < stepList.Count; i++)
        {
            TestStep step = stepList[i];
            //界面的column 属性建立的3列。stepName，stepKey，stepSort
            string disName = $"{step.Sort.ToString().PadLeft(2, '0')}.{step.ProcessName}";
            ListViewItem item = new(disName);
            item.SubItems.Add(step.ProcessKey);
            item.SubItems.Add(step.Sort.ToString());
            item.SubItems.Add(step.DSLName.ToString());
            item.SubItems.Add(step.ReportRow.ToString());
            item.ImageKey = step.ProcessKey;
            lvTestItem.Items.Add(item);
            lvTestItem.Items[i].Checked = true;
        }
        chkAllNone.Checked = true;
    }

    private List<TestItems> GetSelectTestItems()
    {
        List<TestItems> listSelectTestItems = [];
        for (int i = 0; i < lvTestItem.Items.Count; i++)
        {
            TestItems tmptestItems = new()
            {
                Model = VarHelper.ModelName,
                ProcessKey = lvTestItem.Items[i].ImageKey,
                ProcessName = lvTestItem.Items[i].Text,
                IsSelected = lvTestItem.Items[i].Checked,
                DSLName = lvTestItem.Items[i].Text,
                ReportRow = lvTestItem.Items[i].Text,
                RowIndex = i
            };
            listSelectTestItems.Add(tmptestItems);
        }
        return listSelectTestItems;
    }

    private string curProcessKey;
    private void ThreadStartTest()
    {
        List<TestItems> testItemsList = GetSelectTestItems();
        for (int i = 0; i < testItemsList.Count; i++)
            lvTestItem.Invoke(() => { lvTestItem.Items[i].BackColor = Color.White; });
        for (int i = 0; i < testItemsList.Count && isOperationTestStarted; i++)
        {
            if (!testItemsList[i].IsSelected) continue;
            curProcessKey = testItemsList[i].ProcessKey;
            string curProcessName = testItemsList[i].ProcessName;
            string curProcessDSLName = testItemsList[i].DSLName;
            int rowIndex = testItemsList[i].RowIndex;

            if (DicProcedureModules.TryGetValue(curProcessKey, out DSLProcedure DslPro))
            {
                lvTestItem.Invoke(() => { lvTestItem.Items[rowIndex].BackColor = Color.LightYellow; });
                try
                {
                    DslPro.Execute();
                }
                catch (Exception ex)
                {
                    lvTestItem.Invoke(() => { lvTestItem.Items[rowIndex].BackColor = Color.Green; });
                    MessageHelper.UIMessageOK(ex.Message);
                }
                lvTestItem.Invoke(() => { lvTestItem.Items[rowIndex].BackColor = Color.LightGreen; });
            }
            else
            {
                MessageHelper.UIMessageOK("未找到自动试验文件，例行试验开始失败！");
                return;
            }
        }
        TestBtnStatus(false);
    }

    bool isOperationTestStarted = false;
    private void btnStartTest_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(VarHelper.ModelName)) { MessageHelper.UIMessageOK("型号未选择！"); return; }
        if (lvTestItem.Items.Count < 1) { MessageHelper.UIMessageOK("无试验项点，请进入[参数设置]-->[试验项点管理]界面中设置自动试验项点！"); return; }
        if (Common.AIgrp[18] < 750) { MessageHelper.UIMessageOK("总风压力不足750kPa，请检查风源是否开启！"); return; }
        if (Common.AIgrp[19] < 750) { MessageHelper.UIMessageOK("总风管压力不足750kPa，请检查风源是否开启！"); return; }
        try
        {
            if (!isOperationTestStarted)//开始
            {
                TestBtnStatus(true);
                Task.Factory.StartNew(() => { ThreadStartTest(); });
            }
            else
            {
                if (DicProcedureModules.TryGetValue(key: curProcessKey, value: out DSLProcedure value))
                {
                    value.StopExecute();
                }
                TestBtnStatus(false);
            }
        }
        catch (Exception ex)
        {
            NlogHelper.Default.Error("自动试验开启、停止错误：", ex);
            MessageHelper.UIMessageOK("自动试验开启、停止错误：" + ex.Message);
        }
    }

    private void TestBtnStatus(bool Status)
    {
        Color startColor = Color.FromArgb(80, 160, 255);
        Color endColor = Color.FromArgb(255, 128, 128);
        if (Status)
        {
            isOperationTestStarted = true;
            btnStartTest.FillColor = btnStartTest.FillColor2 = endColor;
            btnStartTest.RectColor = btnStartTest.RectDisableColor = endColor;
            btnStartTest.Text = "停止自动试验";
        }
        else
        {
            isOperationTestStarted = false;
            btnStartTest.FillColor = btnStartTest.FillColor2 = startColor;
            btnStartTest.RectColor = btnStartTest.RectDisableColor = startColor;
            btnStartTest.Text = "开始自动试验";
        }
    }

    private void btnStopTest_Click(object sender, EventArgs e)
    {

    }

    private void chkAllNone_CheckedChanged(object sender, EventArgs e)
    {
        var isCheck = sender as UICheckBox;
        for (int i = 0; i < lvTestItem.Items.Count; i++)
        {
            lvTestItem.Items[i].Checked = isCheck.Checked;
        }
    }
}
