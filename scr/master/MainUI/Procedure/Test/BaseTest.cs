using MainUI.Config;
using System.Threading;

namespace MainUI.Procedure
{
    public class BaseTest
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern uint GetTickCount();
        public static ParaConfig para = new();

        public delegate void TestStateHandler(bool isTesting);
        public static event TestStateHandler TestStateChanged;

        public delegate void TipsHandler(object sender, object info);
        public static event TipsHandler TipsChanged;

        public delegate void TipsTiming(object sender, int s);
        public static event TipsTiming TimingChanged;

        public delegate bool WaitCallback();

        public delegate void WaitTicked(int tick);
        public event WaitTicked WaitTick;

        public static event WaitStepTicked WaitStepTick;
        public delegate void WaitStepTicked(int tick, string stepName);

        public delegate void Del();

        public bool IsTesting { get; set; }

        public void Delay(double seconds)
        {
            Delay(seconds, 100, delegate { return true; });
        }
        public bool Delay(double sj, int interval, WaitCallback wait)
        {
            int t = 0;
            double timeout = sj * 1000;
            while (t <= timeout && IsTesting && wait())
            {
                t += interval;
                Thread.Sleep(interval);
                WaitTick?.Invoke(t);
            }
            return t > timeout;
        }
        public void Delay(int seconds, string waitName)
        {
            Delay(seconds, 100, delegate { return true; }, waitName);
        }
        public bool Delay(int sj, int interval, WaitCallback wait, string waitName)
        {
            int t = 0;
            int timeout = sj * 1000;
            while (t <= timeout && wait() && IsTesting)
            {
                t += interval;
                Thread.Sleep(interval);
                WaitStepTick?.Invoke(t, waitName);
            }
            return t > timeout;
        }
        /// <summary>
        /// 显示已执行的时间
        /// </summary>
        public void lblTime(int time, string waitName)
        {
            WaitStepTick?.Invoke(time, waitName);
        }
        /// <summary>
        /// 提示信息
        /// </summary>
        public void TxtTips(object str)
        {
            TipsChanged?.Invoke(this, str);
        }
        public void TxtTiming(int s)
        {
            TimingChanged?.Invoke(this, s);
        }
        /// <summary>
        /// 试验状态
        /// </summary>
        public void TestStatus(bool isTest)
        {
            IsTesting = isTest;
            TestStateChanged?.Invoke(isTest);
        }

        /// <summary>
        /// 在子类中执行试验过程
        /// </summary>
        public virtual bool Execute() { return false; }

        /// <summary>
        /// 试验项点初始化
        /// </summary>
        public virtual void BeginTestItem() { }
        /// <summary>
        /// 试验项点结束
        /// </summary>
        public virtual void EndTestItem() { }

    }
}
