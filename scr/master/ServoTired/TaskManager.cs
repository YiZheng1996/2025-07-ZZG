using MainUI.Config;
using RW;
using ServoTired.BLL;
using Sunny.UI;
using Sunny.UI.Win32;
using System.Diagnostics;

namespace ServoTired
{
    internal class TaskManager
    {
        private readonly ParaConfig para = new("Para");
        private readonly PointBLL pointBLL = new();
        private readonly ServoTiredBLL TiredBLL = new();
        public delegate void BigTextHandler(string text, bool isBig = false);
        public event BigTextHandler? BigTextChanged;
        public delegate void BigStepHandler(int step, int count);
        public event BigStepHandler? BigStepChanged;
        public delegate void SmallTextHandler(string text, bool isBig = false);
        public event SmallTextHandler? SmallTextChanged;
        public delegate void StepSamllHandler(int step, int count);
        public event StepSamllHandler? StepSamllChanged;
        private readonly Dictionary<string, TaskInfo> tasks = [];

        /// <summary>
        /// 启动
        /// </summary>
        /// <param name="taskId"></param>
        public void StartTask(string taskId)
        {
            if (!tasks.ContainsKey(taskId))
            {
                CancellationTokenSource cancellationTokenSource = new();
                Task task = Task.Run(() => TaskMethod(taskId, cancellationTokenSource.Token), cancellationTokenSource.Token);
                tasks.Add(taskId, new TaskInfo { Task = task, CancellationTokenSource = cancellationTokenSource });
                Debug.WriteLine($"Task {taskId} 启动");
            }
            else
            {
                Debug.WriteLine($"Task {taskId} 正在运行");
            }
        }

        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public async Task PauseTaskAsync(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TaskInfo? value))
            {
                CancellationTokenSource cancellationTokenSource = value.CancellationTokenSource;
                cancellationTokenSource?.Cancel();
                await value.Task;
                Debug.WriteLine($"Task {taskId} 暂停");
            }
            else
            {
                Debug.WriteLine($"Task {taskId} 未运行");
            }
        }

        /// <summary>
        /// 继续
        /// </summary>
        /// <param name="taskId"></param>
        public void ResumeTask(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TaskInfo? value))
            {
                value.CancellationTokenSource?.Dispose();
                value.CancellationTokenSource = new CancellationTokenSource();
                Task task = Task.Run(() => TaskMethod(taskId, value.CancellationTokenSource.Token), value.CancellationTokenSource.Token);
                value.Task = task;
                Debug.WriteLine($"Task {taskId} 重新开始");
            }
            else
            {
                Debug.WriteLine($"Task {taskId} 未运行");
            }
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public async Task StopTaskAsync(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TaskInfo? value))
            {
                CancellationTokenSource cancellationTokenSource = value.CancellationTokenSource;
                cancellationTokenSource?.Cancel();

                try
                {
                    await value.Task; //等待任务完成
                }
                catch (TaskCanceledException)
                {
                    //任务已取消
                }
                finally
                {
                    cancellationTokenSource?.Dispose(); // 释放 CancellationTokenSource 资源
                    tasks.Remove(taskId); // 从任务列表中移除任务信息
                    Debug.WriteLine($"Task {taskId} 停止并释放资源");
                }
            }
            else
            {
                Debug.WriteLine($"Task {taskId} 未运行");
            }
        }

        /// <summary>
        /// 是否在线
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public bool IsTaskRunning(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TaskInfo? value))
            {
                TaskStatus status = value.Task.Status;
                return status == TaskStatus.Running || status == TaskStatus.WaitingToRun || status == TaskStatus.WaitingForActivation;
            }
            return false;
        }

        /// <summary>
        /// 试验过程
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken"></param>
        private void TaskMethod(string taskId, CancellationToken cancellationToken)
        {
            switch (taskId)
            {
                case "大闸疲劳":
                    TaskLogicBig(cancellationToken);
                    break;
                case "小闸疲劳":
                    TaskLogicSmall(cancellationToken);
                    break;
                default:
                    Debug.WriteLine($"Task {taskId} 没有定义的逻辑");
                    break;
            }
        }

        /// <summary>
        /// 大闸
        /// </summary>
        /// <param name="cancellationToken"></param>
        private void TaskLogicBig(CancellationToken cancellationToken)
        {
            Helper.servoGrp[14] = true; //伺服启停
            BigTextChanged?.Invoke("正在初始化···\n", true);
            var listData = TiredBLL.GetServoTiredTable(0);
            BigTextChanged?.Invoke($"初始化完成···\n第{para.bigNowTest}次试验开始···\n");
            while (!cancellationToken.IsCancellationRequested && para.bigNowTest < para.TestNumber)
            {
                for (int i = 0; i < listData?.Count && !cancellationToken.IsCancellationRequested; i++) //疲劳试验一次流程
                {
                    Helper.servoGrp[15] = listData[i].Speed; //转速
                    Helper.servoGrp[10] = listData[i].ResidenceTime * 1000; //停留时间,ms
                    var startInfo = pointBLL.GetPointInfo(listData[i].StartPositionID);
                    Instruct(startInfo.Instruct, 11, 9);
                    BigStepChanged?.Invoke(i, listData.Count);
                    Delay(30, 100, cancellationToken, () => Helper.servoGrp[11].ToBool());
                }
                if (!cancellationToken.IsCancellationRequested)   //异常或手动取消试验不记录次数
                {
                    para.bigNowTest += 1;
                    para.Save();
                    BigTextChanged?.Invoke($"第{para.bigNowTest}次试验开始···\n");
                }
            }
            Debug.WriteLine($"Task 大闸疲劳 已暂停或取消");
        }

        /// <summary>
        /// 小闸
        /// </summary>
        /// <param name="cancellationToken"></param>
        private void TaskLogicSmall(CancellationToken cancellationToken)
        {
            Helper.servoGrp[27] = true; //伺服启停
            SmallTextChanged?.Invoke("正在初始化···\n", true);
            var listData = TiredBLL.GetServoTiredTable(1);
            SmallTextChanged?.Invoke($"初始化完成···\n第{para.smallGigNowTest}次试验开始···\n");
            while (!cancellationToken.IsCancellationRequested && para.smallGigNowTest < para.TestNumber)
            {
                for (int i = 0; i < listData?.Count && !cancellationToken.IsCancellationRequested; i++) //疲劳试验一次流程
                {
                    Helper.servoGrp[28] = listData[i].Speed; //转速
                    Helper.servoGrp[23] = listData[i].ResidenceTime * 1000; //停留时间,ms
                    var startInfo = pointBLL.GetPointInfo(listData[i].StartPositionID);
                    Instruct(startInfo.Instruct, 24, 22);
                    StepSamllChanged?.Invoke(i, listData.Count);
                    Debug.WriteLine("小闸位置到达信号：" + Helper.servoGrp[24].ToBool());
                    Delay(30, 100, cancellationToken, () => Helper.servoGrp[24].ToBool());
                }
                if (!cancellationToken.IsCancellationRequested) //异常或手动取消试验不记录次数
                {
                    para.smallGigNowTest += 1;
                    para.Save();
                    SmallTextChanged?.Invoke($"第{para.smallGigNowTest}次试验开始···\n");
                }
            }
            Debug.WriteLine($"Task 小闸疲劳 已暂停或取消");
        }

        /// <summary>
        /// 每次给定指令必须先复位，位置到达信号
        /// </summary>
        /// <param name="Instruct">位置指令</param>
        /// <param name="Reset">复位信号点位</param>
        /// <param name="InstructPoint">指令发送地址</param>
        private void Instruct(int Instruct, int Reset, int InstructPoint)
        {
            Helper.servoGrp[Reset] = false;
            Task.Delay(1000).Wait();
            Helper.servoGrp[InstructPoint] = Instruct; //位置指令
            Task.Delay(1000).Wait();

        }

        /// <summary>
        /// 超时操作
        /// </summary>
        /// <param name="timeout">超时时间</param>
        /// <param name="breakTime">刷新频率</param>
        /// <param name="cancellationToken">绑定的ToKen</param>
        /// <param name="conditions">条件可多个，为true退出</param>
        private static void Delay(int timeout, int breakTime, CancellationToken cancellationToken, params Func<bool>[]? conditions)
        {
            try
            {
                conditions ??= [];
                bool isTesting = true;
                Stopwatch sw = Stopwatch.StartNew();
                while (sw.Elapsed.TotalSeconds < timeout && isTesting && !cancellationToken.IsCancellationRequested)
                {
                    Task.Delay(breakTime).Wait();
                    foreach (var condition in conditions)
                    {
                        if (condition()) { Debug.WriteLine("参数值：" + condition()); isTesting = false; return; }
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                }
                sw.Reset();
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("延时存在问题：", ex);
            }
        }

        private class TaskInfo
        {
            public Task Task { get; set; }
            public CancellationTokenSource? CancellationTokenSource { get; set; }
        }

    }
}
