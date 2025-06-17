using AntdUI;
using MainUI.Config;
using RW;
using ServoTired.BLL;
using Sunny.UI;

namespace ServoTired
{
    public partial class Test : UIForm
    {
        private readonly ParaConfig para = new("Para");
        private readonly TaskManager taskManager = new();

        public Test() => InitializeComponent();

        private void Test_Load(object sender, EventArgs e)
        {
            InitStep();
            Helper.Init();
            Helper.servoGrp.Fresh();
            Helper.opcDIGroup.Fresh();
            taskManager.BigTextChanged += TaskManager_BigTextChanged;
            taskManager.SmallTextChanged += TaskManager_SmallTextChanged;
            taskManager.BigStepChanged += TaskManager_BigStepChanged;
            taskManager.StepSamllChanged += TaskManager_StepSamllChanged;
            Helper.opcDIGroup.DIGroupChanged += OpcDIGroup_DIGroupChanged;
            Helper.servoGrp.TestConGroupChanged += ServoGrp_TestConGroupChanged;
        }

        int Smallvalue = 0;
        private void TaskManager_StepSamllChanged(int step, int count) =>
            stepsSmall.Invoke(() =>
                            {
                                stepsSmall.Current = step;
                            });

        int Bigvalue = 0;
        private void TaskManager_BigStepChanged(int step, int count) =>
                    stepsBig.Invoke(() =>
                            {
                                stepsBig.Current = step;
                            });

        private void InitStep()
        {
            stepsBig.Items.Clear();
            stepsSmall.Items.Clear();
            ServoTiredBLL bLL = new();
            for (int gearType = 0; gearType < 2; gearType++)
            {
                var data = bLL.GetServoTiredTable(gearType);
                if (data is null || data.Count == 0) continue;

                foreach (var model in data)
                {
                    StepsItem item = new()
                    {
                        Title = model.StartPosition,
                        Description = $"步骤{model.StepNumber}"
                    };

                    if (gearType == 0)
                        stepsBig.Items.Add(item);
                    else
                        stepsSmall.Items.Add(item);
                }
            }
        }

        private void OpcDIGroup_DIGroupChanged(object sender, int index, bool value)
        {
            if (index == 0)
            {
                if (!value)
                {
                    btnBigGate.Invoke(() =>
                    {
                        isOperationBigStarted = true;
                        IsBigTestStart();
                        TaskManager_SmallTextChanged($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}：急停已按下，试验停止！\n");
                    });
                    btnSmallGate.Invoke(() =>
                    {
                        isOperationSmallStarted = true;
                        IsSmallTestStart();
                        TaskManager_BigTextChanged($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}：急停以按下，试验停止！\n");
                    });
                }
            }
        }

        /// <summary>
        /// 消息通知
        /// </summary>
        /// <param name="text">消息</param>
        /// <param name="isBig">true:清空文本</param>
        private void TaskManager_SmallTextChanged(string text, bool isBig = false) => RichTextSmall.Invoke(() =>
        {
            if (isBig) RichTextSmall.Clear();
            RichTextSmall.AppendText(text);
            RichTextSmall.ScrollToCaret();
        });

        /// <summary>
        /// 消息通知
        /// </summary>
        /// <param name="text">消息</param>
        /// <param name="isBig">true:清空文本</param>
        private void TaskManager_BigTextChanged(string text, bool isBig = false) => Invoke(() =>
        {
            if (isBig) RichTextBig.Clear();
            RichTextBig.AppendText(text);
            RichTextBig.ScrollToCaret();
        });

        private void ServoGrp_TestConGroupChanged(object sender, int index, object value)
        {
            BigErr(index, value);
            SmallErr(index, value);
            BtnColor(btnBigGate, isOperationBigStarted);
            BtnColor(btnSmallGate, isOperationSmallStarted);
        }

        #region 异常
        /// <summary>
        /// 大闸异常
        /// 16#7002: 没错误，功能块正在执行
        /// 16#8401: 驱动错误
        /// 16#8402: 驱动禁止启动
        /// 16#8403: 运行中回零不能开始
        /// 16#8600: DPRD_DAT错误
        /// 16#8601: DPWR_DAT 错误
        /// 16#8202: 不正确的运行模式选择
        /// 16#8203: 不正确的设定值参数
        /// 16#8204: 选择了不正确的程序段号
        /// </summary>
        private void BigErr(int index, object value)
        {
            switch (index)
            {
                case 13:
                    LabBigPosition.Value = value.ToDouble();
                    break;
                case 14:
                    BtnColor(btnServoEnableBig, value.ToBool());
                    break;
                case 16:
                    if (Convert.ToBoolean(value))
                    {
                        btnBigGate.Invoke(() =>
                        {
                            isOperationBigStarted = true;
                            IsBigTestStart();
                            TaskManager_BigTextChanged($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}：伺服存在错误，试验停止！\n");
                        });
                    }
                    swBigServoERR.Switch = Convert.ToBoolean(value);
                    break;
                case 19:
                    if (value.ToString() == "28647" || value.ToString() == "0") return;
                    TaskManager_BigTextChanged(Helper.ServoErr(errValue: value.ToString()));
                    break;
                case 33:
                    BtnColor(btnDCFBig, value.ToBool());
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 小闸异常
        /// 16#7002: 没错误，功能块正在执行
        /// 16#8401: 驱动错误，16#8402: 驱动禁止启动
        /// 16#8403: 运行中回零不能开始
        /// 16#8600: DPRD_DAT错误
        /// 16#8601: DPWR_DAT 错误
        /// 16#8202: 不正确的运行模式选择
        /// 16#8203: 不正确的设定值参数
        /// 16#8204: 选择了不正确的程序段号
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void SmallErr(int index, object value)
        {
            switch (index)
            {
                case 26:
                    LabSmallPosition.Value = value.ToDouble();
                    break;
                case 27:
                    BtnColor(btnServoEnableSmall, value.ToBool());
                    break;
                case 29:
                    if (Convert.ToBoolean(value))
                    {
                        btnBigGate.Invoke(() =>
                        {
                            isOperationSmallStarted = true;
                            IsSmallTestStart();
                            TaskManager_SmallTextChanged($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}：伺服存在错误，试验停止！\n");
                        });
                    }
                    swSmallServoERR.Switch = Convert.ToBoolean(value);
                    break;
                case 32:
                    if (value.ToString() == "28647") return;
                    TaskManager_SmallTextChanged(Helper.ServoErr(errValue: value.ToString()));
                    break;
                case 34:
                    BtnColor(btnDCFSmall, value.ToBool());
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 大闸
        bool isOperationBigStarted = false;
        private void btnBigGate_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Helper.servoGrp[16]))
            {
                MessageHelper.MessageOK(this, "伺服存在异常，请点击[故障复位按钮]！"); return;
            }
            if (!Helper.opcDIGroup[0])
            {
                MessageHelper.MessageOK(this, "急停按钮已按下，无法开始试验！"); return;
            }
            IsBigTestStart();
        }

        private async void IsBigTestStart()
        {
            if (!isOperationBigStarted)
            {
                //开始操作
                taskManager.StartTask("大闸疲劳");
                isOperationBigStarted = true;
                btnBigGate.Text = "结束试验";
                TaskManager_BigTextChanged($"疲劳试验\n需要完成{para.TestNumber}次疲劳试验！\n", true);
            }
            else
            {
                await taskManager.StopTaskAsync("大闸疲劳");
                isOperationBigStarted = false;
                btnBigGate.Text = "开始试验";
                Helper.servoGrp[14] = false;
            }
        }

        private void btnZeroClearingBig_Click(object sender, EventArgs e)
        {
            if (taskManager.IsTaskRunning("大闸疲劳"))
            {
                MessageHelper.MessageOK(this, "大闸手柄疲劳试验正在试验，无法清零次数！");
                return;
            }

            if (!Dialog("当前操作将会删除记录的疲劳次数，请谨慎操作，请确认是否将大闸试验次数清零？")) return;
            para.bigNowTest = 1;
            para.Save();
            MessageBox.Show(this, "清零成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region 小闸
        bool isOperationSmallStarted = false;
        private void btnSmallGate_Click(object sender, EventArgs e)
        {
            if (Helper.servoGrp[29].ToBool())
            {
                MessageHelper.MessageOK(this, "伺服存在异常，请点击[故障复位按钮]！"); return;
            }
            if (!Helper.opcDIGroup[0])
            {
                MessageHelper.MessageOK(this, "急停按钮已按下，无法开始试验！"); return;
            }
            IsSmallTestStart();
        }

        private async void IsSmallTestStart()
        {
            if (!isOperationSmallStarted)
            {
                //开始操作
                taskManager.StartTask("小闸疲劳");
                isOperationSmallStarted = true;
                btnSmallGate.Text = "结束试验";
                TaskManager_SmallTextChanged($"疲劳试验\n需要完成{para.TestNumber}次疲劳试验！\n", true);
            }
            else
            {
                await taskManager.StopTaskAsync("小闸疲劳");
                isOperationSmallStarted = false;
                btnSmallGate.Text = "开始试验";
                Helper.servoGrp[27] = false; //伺服启停
            }
        }

        private void btnZeroClearingSamll_Click(object sender, EventArgs e)
        {
            if (taskManager.IsTaskRunning("小闸疲劳"))
            {
                MessageHelper.MessageOK(this, "小闸手柄疲劳试验正在试验，无法清零次数！");
                return;
            }

            if (!Dialog("当前操作将会删除记录的疲劳次数，请谨慎操作，请确认是否将小闸试验次数清零？")) return;
            para.smallGigNowTest = 1;
            para.Save();
            MessageHelper.MessageOK(this, "清零成功！");
        }

        #endregion

        private bool Dialog(string text)
        {
            return MessageHelper.MessageYes(this, text) == DialogResult.OK;
        }

        private void btnParaSet_Click(object sender, EventArgs e)
        {
            if (taskManager.IsTaskRunning("大闸疲劳")|| taskManager.IsTaskRunning("小闸疲劳"))
            {
                MessageHelper.MessageOK(this, "手柄疲劳试验正在试验，无法进行校准！");
                return;
            }

            frmParaSet frmParaSet = new();
            frmParaSet.ShowDialog();
            InitStep();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Helper.Close();
            Close();
            Dispose();
        }

        private void btnServoEnableBig_Click(object sender, EventArgs e)
        {
            if (isOperationBigStarted)
            {
                MessageHelper.MessageOK(this, "大闸疲劳试验正在运行！");
                return;
            }
            var ServoEnable = Helper.servoGrp[14].ToBool();
            Helper.servoGrp[14] = !ServoEnable;
        }

        private async void btnBigFaultReset_Click(object sender, EventArgs e)
        {
            await DoSomethingAsync((UIButton)sender, 12);
        }

        private async Task DoSomethingAsync(UIButton btn, int point)
        {
            btn.Enabled = false;
            BtnColor(btn, Color.FromArgb(82, 196, 26));
            Helper.servoGrp[point] = true;
            await Task.Delay(1000);
            Helper.servoGrp[point] = false;
            BtnColor(btn, Color.FromArgb(80, 160, 255));
            btn.Enabled = true;
        }

        private void BtnColor(Control con, Color color)
        {
            if (con is UIButton btn)
            {
                btn.FillColor = btn.FillColor2 = btn.RectColor = btn.RectDisableColor = btn.FillDisableColor = btn.FillHoverColor = btn.FillPressColor = color;
            }
        }

        private void BtnColor(Control con, bool value)
        {
            Color trueColor = Color.FromArgb(82, 196, 26);
            Color falseColor = Color.FromArgb(80, 160, 255);
            if (con is UIButton btn)
            {
                btn.FillColor = btn.FillColor2 = btn.RectColor = btn.RectDisableColor = btn.FillDisableColor = btn.FillHoverColor = btn.FillPressColor = value ? trueColor : falseColor;
            }
        }

        private void btnServoEnableSmall_Click(object sender, EventArgs e)
        {
            if (isOperationSmallStarted)
            {
                MessageHelper.MessageOK(this, "小闸疲劳试验正在运行！");
                return;
            }
            var ServoEnable = Helper.servoGrp[27].ToBool();
            Helper.servoGrp[27] = !ServoEnable;
        }

        private async void btnSmallFaultReset_Click(object sender, EventArgs e)
        {
            await DoSomethingAsync((UIButton)sender, 25);
        }

        private void btnCalibrationSmall_Click(object sender, EventArgs e)
        {
            if (taskManager.IsTaskRunning("小闸疲劳"))
            {
                MessageHelper.MessageOK(this, "小闸手柄疲劳试验正在试验，无法进行校准！");
                return;
            }

            if (!Dialog("是否进行位置校准？")) return;
            PointBLL pointBLL = new();
            ServoTiredBLL TiredBLL = new();
            var smallListData = TiredBLL.GetServoTiredTable(1);
            for (int i = 0; i < smallListData?.Count; i++)
            {
                var startInfo = pointBLL.GetPointInfo(smallListData[i].StartPositionID);
                if (Dialog($"小闸校准\n请将小闸档位手动推至[{startInfo.GearPposition}]后，点击[确认]按钮！"))
                    Helper.servoGrp[startInfo.Point] = Helper.servoGrp[26];
            }
        }

        private void btnCalibrationBig_Click(object sender, EventArgs e)
        {
            if (taskManager.IsTaskRunning("大闸疲劳"))
            {
                MessageHelper.MessageOK(this, "大闸手柄疲劳试验正在试验，无法进行校准！");
                return;
            }

            if (!Dialog("是否进行位置校准？")) return;
            PointBLL pointBLL = new();
            ServoTiredBLL TiredBLL = new();
            var bigListData = TiredBLL.GetServoTiredTable(0);
            for (int i = 0; i < bigListData?.Count; i++)
            {
                int step = i;
                if (step <= bigListData?.Count)
                {
                    var startInfo = pointBLL.GetPointInfo(bigListData[i].StartPositionID);
                    if (Dialog($"大闸校准\n请将大闸档位手动推至[{startInfo.GearPposition}]后，点击[确认]按钮！"))
                        Helper.servoGrp[startInfo.Point] = Helper.servoGrp[13];
                }
            }
        }

        private void btnDCFBig_Click(object sender, EventArgs e)
        {
            if (isOperationBigStarted)
            {
                MessageHelper.MessageOK(this, "大闸疲劳试验正在运行！");
                return;
            }
            var ServoEnable = Helper.servoGrp[33].ToBool();
            Helper.servoGrp[33] = !ServoEnable;
        }

        private void btnDCFSmall_Click(object sender, EventArgs e)
        {
            if (isOperationSmallStarted)
            {
                MessageHelper.MessageOK(this, "小闸疲劳试验正在运行！");
                return;
            }
            var ServoEnable = Helper.servoGrp[34].ToBool();
            Helper.servoGrp[34] = !ServoEnable;
        }
    }
}
