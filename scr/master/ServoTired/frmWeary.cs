using MainUI.Config;
using Sunny.UI;
using System.Diagnostics;
using System.Runtime.Versioning;
using System;
using System.Collections.Concurrent;
using RW;


namespace ServoTired
{
    [SupportedOSPlatform("windows")]
    public partial class FrmWeary : UIForm
    {
        private ParaConfig para = new("Para");
        TaskManager taskManager = new();
        public FrmWeary() => InitializeComponent();
        private void FrmWeary_Load(object sender, EventArgs e)
        {
            Helper.Init();
            Helper.servoGrp.TestConGroupChanged += ServoGrp_TestConGroupChanged;
        }

        private void ServoGrp_TestConGroupChanged(object sender, int index, object value)
        {
            //Debug.Write(string.Format("下标：{0}，值：{1}\n", index, value));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            isOperationStarted = false;
            Helper.Close();
            Close();
            Dispose();
        }

        #region 小闸疲劳试验
        /// <summary>
        /// 小闸清零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZeroClearingSmall_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 小闸开始试验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSmallGate_Click(object sender, EventArgs e)
        {
            taskManager.StartTask("小闸疲劳");
        }
        #endregion

        #region 大闸疲劳试验
        bool isOperationStarted = false;
        /// <summary>
        /// 大闸开始试验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGate_Click(object sender, EventArgs e)
        {
            var startColor = Color.FromArgb(255, 128, 128);
            var stopColor = Color.FromArgb(110, 190, 40);
            if (!isOperationStarted)
            {
                //开始操作
                BigStartOperation();
                isOperationStarted = true;
                btnBigGate.Text = "结 束";
                btnBigGate.FillColor = startColor;
                btnBigGate.RectColor = startColor;
            }
            else
            {
                await taskManager.StopTaskAsync("大闸疲劳");
                isOperationStarted = false;
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
            if (!taskManager.IsTaskRunning("大闸疲劳"))
            {
                MessageBox.Show("大闸手柄疲劳试验正在试验，无法清零次数！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            para.bigNowTest = 0;
            para.Save();
            MessageBox.Show(this, "清零成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


      
        private void BigStartOperation() //开始
        {
            taskManager.StartTask("大闸疲劳");
        }

        #endregion

        private void btnParaSet_Click(object sender, EventArgs e)
        {
            frmParaSet frmParaSet = new();
            frmParaSet.ShowDialog();
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            if (!Dialog("是否进行位置校准？")) return;

            var bigPosition = Helper.servoGrp[10]; //大闸实时位置
            var smallPosition = Helper.servoGrp[22]; //小闸实时位置
            Adjust(1, 6, bigPosition);
            Adjust(2, 5, bigPosition);
            Adjust(3, 4, bigPosition);
            Adjust(4, 3, bigPosition);
            Adjust(5, 2, bigPosition);
            Adjust(6, 1, bigPosition);
            Adjust(7, 0, bigPosition);
            Adjust(8, 17, smallPosition);
            Adjust(9, 18, smallPosition);
        }

        private void Adjust(int key, int point, object position)
        {
            if (Dialog(Process(key))) Helper.servoGrp[point] = position;
        }

        private bool Dialog(string text)
        {
            return FormEx.ShowAskDialog(this, text);
        }

        private readonly Dictionary<int, Func<string>> processingMap = new() {
                { 1, () => "大闸校准\n请将大闸档位手动推至[运转位]后，点击[确认]按钮！" },
                { 2, () => "大闸校准\n请将大闸档位手动推至[初制动]后，点击[确认]按钮！"  },
                { 3, () => "大闸校准\n请将大闸档位手动推至[制动区]后，点击[确认]按钮！"  },
                { 4, () => "大闸校准\n请将大闸档位手动推至[全制动]后，点击[确认]按钮！"  },
                { 5, () => "大闸校准\n请将大闸档位手动推至[抑制位]后，点击[确认]按钮！"  },
                { 6, () => "大闸校准\n请将大闸档位手动推至[重联位]后，点击[确认]按钮！"  },
                { 7, () => "大闸校准\n请将大闸档位手动推至[紧急位]后，点击[确认]按钮！"  },
                { 8, () => "小闸校准\n请将小闸档位手动推至[运转位]后，点击[确认]按钮！"  },
                { 9, () => "小闸校准\n请将小闸档位手动推至[全制动]后，点击[确认]按钮！"  },
         };

        public string Process(int type)
        {
            if (processingMap.TryGetValue(type, out var func))
            {
                return func();
            }
            return "未知类型";
        }

    }
}
