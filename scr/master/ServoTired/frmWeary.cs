using MainUI.Config;
using Sunny.UI;
using System.Diagnostics;
using System.Runtime.Versioning;

namespace ServoTired
{
    [SupportedOSPlatform("windows")]
    public partial class FrmWeary : UIForm
    {
        ParaConfig para = new("Para");
        public FrmWeary() => InitializeComponent();
        private void FrmWeary_Load(object sender, EventArgs e)
        {
            OPCHelper.Init();
            OPCHelper.servoGrp.TestConGroupChanged += ServoGrp_TestConGroupChanged;
        }

        private void ServoGrp_TestConGroupChanged(object sender, int index, object value)
        {
            Debug.Write(string.Format("下标：{0}，值：{1}\n", index, value));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            BigToken?.Cancel();
            isOperationStarted = false;
            OPCHelper.Close();
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

        }
        #endregion

        #region 大闸疲劳试验
        bool isOperationStarted = false;
        /// <summary>
        /// 大闸开始试验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGate_Click(object sender, EventArgs e)
        {
            if (!isOperationStarted)
            {
                //开始操作
                BigStartOperation();
                isOperationStarted = true;
                btnGate.Text = "暂 停";
                btnGate.FillColor = Color.FromArgb(255, 128, 128);
                btnGate.RectColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                //结束操作
                BigEndOperation();
                isOperationStarted = false;
                btnGate.Text = "开 始";
                btnGate.FillColor = Color.FromArgb(110, 190, 40);
                btnGate.RectColor = Color.FromArgb(110, 190, 40);
            }
        }

        /// <summary>
        /// 大闸清零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZeroClearingBig_Click(object sender, EventArgs e)
        {
            if (BigTask?.Status == TaskStatus.Running)
            {
                MessageBox.Show("大闸手柄疲劳试验正在试验，无法清零次数！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            para.bigNowTest = 0;
            para.Save();
            MessageBox.Show(this, "清零成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        Task BigTask;
        CancellationTokenSource BigToken;
        ManualResetEvent resetEvent;
        private void BigStartOperation() //开始
        {
            resetEvent?.Set();//暂停   
            if (BigTask?.Status == TaskStatus.Running) return;
            var bigTestNumber = para.bigTestNumber;
            var bigNowTest = para.bigNowTest;
            BigToken = new CancellationTokenSource();
            resetEvent = new ManualResetEvent(true);
            BigTask = Task.Factory.StartNew(() =>
            {
                //TODO：等待电气给出信号点进行试验逻辑编写
                while (true)  //bigNowTest > bigTestNumber || isOperationStarted
                {
                    bigNowTest++;
                    Task.Delay(2000).Wait();
                    Debug.Write(bigNowTest + " ");
                    resetEvent.WaitOne();
                }
            }, BigToken.Token);
        }

        //结束
        private void BigEndOperation()
        {
            resetEvent?.Reset(); //继续
        }

        #endregion


        private void btnParaSet_Click(object sender, EventArgs e)
        {

        }
    }
}
