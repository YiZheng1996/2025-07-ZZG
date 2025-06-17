using System.Text;

namespace MainUI.BCU
{
    public partial class frmOpenCircuit : UIForm
    {
        private CancellationTokenSource _cancellationTokenSource = new();
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern uint GetTickCount();
        private uint T1;
        public frmOpenCircuit()
        {
            InitializeComponent();
        }

        private void BackgroundWorker(CancellationToken token)
        {
            ResponseText.Text = "试验测试中，请等待···";
            StringBuilder sb = new();
            T1 = GetTickCount();
            //关闭两个制动控制器信号
            Common.DOgrp[64] = false;
            Common.DOgrp[65] = false;
            DateTime startTime = DateTime.Now;
            sb.AppendLine($"开始时间：{startTime}\n");
            while (VarHelper.CANData > 1
                && !token.IsCancellationRequested
                && Convert.ToInt32(GetTickCount() - T1) < 15000) ;
            DateTime endTime = DateTime.Now;
            TimeSpan difference = endTime - startTime;
            sb.AppendLine($"结束时间：{endTime}\n");
            double millisecond = difference.TotalMilliseconds;
            sb.AppendLine($"试验周期：{millisecond}毫秒");
            ResponseText.Text = sb.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Task.Run(() => BackgroundWorker(_cancellationTokenSource.Token),
              _cancellationTokenSource.Token);
        }

        private void frmOpenCircuit_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }
    }
}
