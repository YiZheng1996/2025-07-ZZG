using AntdUI;
using MainUI.Config;
using OPCAutomation;
using RW;
using ServoTired.BLL;
using Sunny.UI;

namespace ServoTired
{
    public partial class Test : AntdUI.Window
    {
        private ParaConfig para = new("Para");
        private TaskManager taskManager = new();

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
                                if (step >= count / 2 + 1)
                                {
                                    Smallvalue += 2;
                                    stepsSmall.Current = step - Smallvalue;
                                }
                                else
                                {
                                    Smallvalue = 0;
                                    stepsSmall.Current = step;
                                }
                            });

        int Bigvalue = 0;
        private void TaskManager_BigStepChanged(int step, int count) =>
                    stepsBig.Invoke(() =>
                            {
                                if (step >= count / 2 + 1)
                                {
                                    Bigvalue += 2;
                                    stepsBig.Current = step - Bigvalue;
                                }
                                else
                                {
                                    Bigvalue = 0;
                                    stepsBig.Current = step;
                                }
                            });

        private void InitStep()
        {
            ServoTiredBLL bLL = new();
            for (int j = 0; j < 2; j++)
            {
                var data = bLL.GetServoTiredTable(j);
                for (int i = 0; i < data.Count / 2 + 1; i++)
                {
                    StepsItem item = new()
                    {
                        Title = data[i].StartPosition,
                        Description = $"步骤{data[i].StepNumber}"
                    };
                    if (j == 0) stepsBig.Items.Add(item); else stepsSmall.Items.Add(item);
                }
            }
        }

        private void OpcDIGroup_DIGroupChanged(object sender, int index, bool value)
        {

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
                    btnServoEnableBig.Type = value.ToBool() ? TTypeMini.Success : TTypeMini.Default;
                    break;
                case 16:
                    if (value.ToBool())
                    {
                        btnBigGate.Invoke(() =>
                        {
                            isOperationBigStarted = true;
                            IsBigTestStart();
                        });
                    }
                    swBigServoERR.Switch = value.ToBool();
                    break;
                case 19:
                    if (value.ToString() != "28647")
                        TaskManager_BigTextChanged($"大闸伺服故障，故障代码为：{value}\n");
                    //MessageHelper.MessageOK(this, $"大闸伺服故障，故障代码为：{value}");
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
                    btnServoEnableSmall.Type = value.ToBool() ? TTypeMini.Success : TTypeMini.Default;
                    break;
                case 29:
                    if (value.ToBool())
                    {
                        btnBigGate.Invoke(() =>
                        {
                            isOperationSmallStarted = true;
                            IsSmallTestStart();
                        });
                    }
                    swSmallServoERR.Switch = value.ToBool();
                    break;
                case 32:
                    if (value.ToString() != "28647")
                        TaskManager_SmallTextChanged($"小闸伺服故障，故障代码为：{value}\n");
                    //MessageHelper.MessageOK(this, $"小闸伺服故障，故障代码为：{value}");
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
            IsBigTestStart();
        }

        private async void IsBigTestStart()
        {
            if (!isOperationBigStarted)
            {
                //开始操作
                taskManager.StartTask("大闸疲劳");
                isOperationBigStarted = true;
                btnBigGate.Text = "结 束 试 验";
                //labBigTitle.Text = $"大闸疲劳试验\n需要完成{para.TestNumber}次疲劳试验！";
            }
            else
            {
                await taskManager.StopTaskAsync("大闸疲劳");
                isOperationBigStarted = false;
                btnBigGate.Text = "开 始 试 验";
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
            para.bigNowTest = 0;
            para.Save();
            MessageBox.Show(this, "清零成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region 小闸
        bool isOperationSmallStarted = false;
        private void btnSmallGate_Click(object sender, EventArgs e)
        {
            IsSmallTestStart();
        }

        private async void IsSmallTestStart()
        {
            var startColor = Color.FromArgb(255, 128, 128);
            var stopColor = Color.FromArgb(110, 190, 40);
            if (!isOperationSmallStarted)
            {
                //开始操作
                taskManager.StartTask("小闸疲劳");
                isOperationSmallStarted = true;
                btnSmallGate.Text = "结 束 试 验";
                //labSmallTitle.Text = $"小闸疲劳试验\n需要完成{para.TestNumber}次疲劳试验！";
            }
            else
            {
                await taskManager.StopTaskAsync("小闸疲劳");
                isOperationSmallStarted = false;
                btnSmallGate.Text = "开 始 试 验";
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
            para.smallGigNowTest = 0;
            para.Save();
            MessageBox.Show(this, "清零成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        private bool Dialog(string text)
        {
            return MessageHelper.MessageYes(this, text) == DialogResult.OK;
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            if (taskManager.IsTaskRunning("大闸疲劳") || taskManager.IsTaskRunning("小闸疲劳"))
            {
                MessageHelper.MessageOK(this, "大小闸手柄疲劳试验正在试验，无法进行校准！");
                return;
            }

            if (!Dialog("是否进行位置校准？")) return;
            PointBLL pointBLL = new();
            ServoTiredBLL TiredBLL = new();
            var bigListData = TiredBLL.GetServoTiredTable(0);
            for (int i = 0; i < bigListData?.Count; i++)
            {
                var startInfo = pointBLL.GetPointInfo(bigListData[i].StartPositionID);
                if (Dialog($"大闸校准\n请将大闸档位手动推至[{startInfo.GearPposition}]后，点击[确认]按钮！"))
                    Helper.servoGrp[startInfo.Point] = Helper.servoGrp[13];
            }

            var smallListData = TiredBLL.GetServoTiredTable(1);
            for (int i = 0; i < smallListData?.Count; i++)
            {
                var startInfo = pointBLL.GetPointInfo(smallListData[i].StartPositionID);
                if (Dialog($"小闸校准\n请将小闸档位手动推至[{startInfo.GearPposition}]后，点击[确认]按钮！"))
                    Helper.servoGrp[startInfo.Point] = Helper.servoGrp[26];
            }
        }

        private void btnParaSet_Click(object sender, EventArgs e)
        {
            frmParaSet frmParaSet = new();
            frmParaSet.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Helper.Close();
            Close();
            Dispose();
            isOperationBigStarted = false;
            isOperationSmallStarted = false;
        }

        private void btnServoEnableBig_Click(object sender, EventArgs e)
        {
            var ServoEnable = Helper.servoGrp[14].ToBool();
            Helper.servoGrp[14] = !ServoEnable;
        }

        private async void btnBigFaultReset_Click(object sender, EventArgs e)
        {
            await DoSomethingAsync((AntdUI.Button)sender, 12);
        }

        private async Task DoSomethingAsync(AntdUI.Button btn, int point)
        {
            btn.Type = TTypeMini.Success;
            //btn.Enabled = false;
            Helper.servoGrp[point] = true;
            await Task.Delay(1000);
            Helper.servoGrp[point] = false;
            btn.Type = TTypeMini.Default;
            //btn.Enabled = true;
        }

        private void btnServoEnableSmall_Click(object sender, EventArgs e)
        {
            var ServoEnable = Helper.servoGrp[27].ToBool();
            Helper.servoGrp[27] = !ServoEnable;
        }

        private async void btnSmallFaultReset_Click(object sender, EventArgs e)
        {
            await DoSomethingAsync((AntdUI.Button)sender, 25);

        }
    }
}
