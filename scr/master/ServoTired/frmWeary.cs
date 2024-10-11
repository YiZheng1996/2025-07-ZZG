using MainUI.Config;
using RW;
using ServoTired.BLL;
using Sunny.UI;
using System;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace ServoTired;

[SupportedOSPlatform("windows")]
public partial class FrmWeary : UIForm
{
    private ParaConfig para = new("Para");
    private TaskManager taskManager = new();
    public FrmWeary() => InitializeComponent();
    private void FrmWeary_Load(object sender, EventArgs e)
    {
        Helper.Init();
        taskManager.BigTextChanged += TaskManager_BigTextChanged;
        taskManager.SmallTextChanged += TaskManager_SmallTextChanged;
        Helper.opcDIGroup.DIGroupChanged += OpcDIGroup_DIGroupChanged;
        Helper.servoGrp.TestConGroupChanged += ServoGrp_TestConGroupChanged;

    }

    private void OpcDIGroup_DIGroupChanged(object sender, int index, bool value)
    {

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Helper.Close();
        Close();
        Dispose();
        isOperationBigStarted = false;
        isOperationSmallStarted = false;
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
            case 17:
                if (value.ToBool())
                {
                    btnBigGate.Invoke(() =>
                    {
                        btnGate_Click(null, null);
                    });
                }
                break;
            case 19:
                if (value.ToString() != "28647")
                    UIMessageBox.Show(text: $"大闸伺服故障，故障代码为：{value}");
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
            case 29:
                if (value.ToBool())
                {
                    btnBigGate.Invoke(() =>
                    {
                        btnSmallGate_Click(null, null);
                    });
                }
                break;
            case 32:
                if (value.ToString() != "28647")
                    UIMessageBox.Show(text: $"小闸伺服故障，故障代码为：{value}");
                break;
            default:
                break;
        }
    }
    #endregion

    #region 小闸疲劳试验
    bool isOperationSmallStarted = false;
    /// <summary>
    /// 小闸开始试验
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void btnSmallGate_Click(object? sender, EventArgs? e)
    {
        var startColor = Color.FromArgb(255, 128, 128);
        var stopColor = Color.FromArgb(110, 190, 40);
        if (!isOperationSmallStarted)
        {
            //开始操作
            taskManager.StartTask("小闸疲劳");
            isOperationSmallStarted = true;
            btnSmallGate.Text = "结 束";
            btnSmallGate.FillColor = startColor;
            btnSmallGate.RectColor = startColor;
        }
        else
        {
            await taskManager.StopTaskAsync("小闸疲劳");
            isOperationSmallStarted = false;
            btnSmallGate.Text = "开 始";
            btnSmallGate.FillColor = stopColor;
            btnSmallGate.RectColor = stopColor;
        }
    }

    private void btnZeroClearingSamll_Click(object sender, EventArgs e)
    {
        if (taskManager.IsTaskRunning("小闸疲劳"))
        {
            UIMessageBox.Show("小闸手柄疲劳试验正在试验，无法清零次数！");
            return;
        }

        if (!Dialog("当前操作将会删除记录的疲劳次数，请谨慎操作，请确认是否将小闸试验次数清零？")) return;
        para.smallGigNowTest = 0;
        para.Save();
        MessageBox.Show(this, "清零成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    #endregion

    #region 大闸疲劳试验
    bool isOperationBigStarted = false;
    /// <summary>
    /// 大闸开始试验
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void btnGate_Click(object? sender, EventArgs? e)
    {
        var startColor = Color.FromArgb(255, 128, 128);
        var stopColor = Color.FromArgb(110, 190, 40);
        if (!isOperationBigStarted)
        {
            //开始操作
            taskManager.StartTask("大闸疲劳");
            isOperationBigStarted = true;
            btnBigGate.Text = "结 束";
            btnBigGate.FillColor = startColor;
            btnBigGate.RectColor = startColor;
        }
        else
        {
            await taskManager.StopTaskAsync("大闸疲劳");
            isOperationBigStarted = false;
            btnBigGate.Text = "开 始";
            btnBigGate.FillColor = stopColor;
            btnBigGate.RectColor = stopColor;
        }
    }

    /// <summary>
    /// 大闸清零
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnZeroClearingBig_Click(object sender, EventArgs e)
    {
        if (taskManager.IsTaskRunning("大闸疲劳"))
        {
            UIMessageBox.Show("大闸手柄疲劳试验正在试验，无法清零次数！");
            return;
        }

        if (!Dialog("当前操作将会删除记录的疲劳次数，请谨慎操作，请确认是否将大闸试验次数清零？")) return;
        para.bigNowTest = 0;
        para.Save();
        MessageBox.Show(this, "清零成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    #endregion

    private void btnParaSet_Click(object sender, EventArgs e)
    {
        frmParaSet frmParaSet = new();
        frmParaSet.ShowDialog();
    }

    private void btnCalibration_Click(object sender, EventArgs e)
    {
        if (taskManager.IsTaskRunning("大闸疲劳") || taskManager.IsTaskRunning("小闸疲劳"))
        {
            UIMessageBox.Show("大小闸手柄疲劳试验正在试验，无法进行校准！");
            return;
        }

        if (!Dialog("是否进行位置校准？")) return;
        PointBLL pointBLL = new();
        ServoTiredBLL TiredBLL = new();
        var bigPosition = Helper.servoGrp[13]; //大闸实时位置
        var bigListData = TiredBLL.GetServoTiredTable(0);
        for (int i = 0; i < bigListData?.Count; i++)
        {
            var startInfo = pointBLL.GetPointInfo(bigListData[i].StartPositionID);
            if (Dialog($"大闸校准\n请将大闸档位手动推至[{startInfo.GearPposition}]后，点击[确认]按钮！"))
                Helper.servoGrp[startInfo.Point] = bigPosition;
        }

        var smallPosition = Helper.servoGrp[26]; //小闸实时位置
        var smallListData = TiredBLL.GetServoTiredTable(1);
        for (int i = 0; i < smallListData?.Count; i++)
        {
            var startInfo = pointBLL.GetPointInfo(smallListData[i].StartPositionID);
            if (Dialog($"小闸校准\n请将小闸档位手动推至[{startInfo.GearPposition}]后，点击[确认]按钮！"))
                Helper.servoGrp[startInfo.Point] = bigPosition;
        }

    }

    private bool Dialog(string text)
    {
        return FormEx.ShowAskDialog(this, text);
    }
}
