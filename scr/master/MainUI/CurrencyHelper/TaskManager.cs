using MainUI.Config;
using RW;
using Sunny.UI;
using Sunny.UI.Win32;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MainUI.CurrencyHelper
{
    internal class TaskManager
    {
        private readonly ParaConfig para = new("Para");

        public delegate void BigTextHandler(string text, bool isBig = false);
        public event BigTextHandler BigTextChanged;
        public delegate void SmallTextHandler(string text, bool isBig = false);
        public event SmallTextHandler SmallTextChanged;
        private readonly System.Collections.Generic.Dictionary<string, TaskInfo> tasks = [];

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
            if (tasks.TryGetValue(taskId, out TaskInfo value))
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
            if (tasks.TryGetValue(taskId, out TaskInfo value))
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
            if (tasks.TryGetValue(taskId, out TaskInfo value))
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
            if (tasks.TryGetValue(taskId, out TaskInfo value))
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
                case "1":
                    TaskLogicBig(cancellationToken);
                    break;
                case "2":
                    TaskLogicSmall(cancellationToken);
                    break;
                default:
                    Debug.WriteLine($"Task {taskId} 没有定义的逻辑");
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        private void TaskLogicBig(CancellationToken cancellationToken)
        {

            Debug.WriteLine($"Task 1 已暂停或取消");
        }

        /// <summary>
        /// 小闸
        /// </summary>
        /// <param name="cancellationToken"></param>
        private void TaskLogicSmall(CancellationToken cancellationToken)
        {

            Debug.WriteLine($"Task 2 已暂停或取消");
        }


        /// <summary>
        /// 超时操作
        /// </summary>
        /// <param name="timeout">超时时间</param>
        /// <param name="breakTime">刷新频率</param>
        /// <param name="cancellationToken">绑定的ToKen</param>
        /// <param name="conditions">条件可多个，为true退出</param>
        private static void Delay(int timeout, int breakTime, CancellationToken cancellationToken, params System.Func<bool>[] conditions)
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
            }
            sw.Reset();
        }

        private class TaskInfo
        {
            public Task Task { get; set; }
            public CancellationTokenSource CancellationTokenSource { get; set; }
        }

    }
}
