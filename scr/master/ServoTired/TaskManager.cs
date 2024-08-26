using System.Collections.Generic;
using System.Diagnostics;

namespace ServoTired
{
    internal class TaskManager
    {
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
                cancellationTokenSource.Cancel();
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
                value.CancellationTokenSource.Dispose();
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

        public async Task StopTaskAsync(string taskId)
        {
            if (tasks.TryGetValue(taskId, out TaskInfo? value))
            {
                CancellationTokenSource cancellationTokenSource = value.CancellationTokenSource;
                cancellationTokenSource.Cancel();

                try
                {
                    await value.Task; // 等待任务完成
                }
                catch (TaskCanceledException)
                {
                    //任务已取消
                }
                finally
                {
                    cancellationTokenSource.Dispose(); // 释放 CancellationTokenSource 资源
                    tasks.Remove(taskId); // 从任务列表中移除任务信息
                    Console.WriteLine($"Task {taskId} 停止并释放资源");
                }
            }
            else
            {
                Console.WriteLine($"Task {taskId} 未运行");
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
            while (!cancellationToken.IsCancellationRequested)
            {
                Debug.WriteLine($"Task 大闸疲劳 正在运行...");
                Thread.Sleep(1000);
            }
            Debug.WriteLine($"Task 大闸疲劳 已暂停或取消");
        }

        /// <summary>
        /// 小闸
        /// </summary>
        /// <param name="cancellationToken"></param>
        private void TaskLogicSmall(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Debug.WriteLine($"Task 小闸疲劳 正在运行...");
                Thread.Sleep(1000);
            }
            Debug.WriteLine($"Task 小闸疲劳 已暂停或取消");

        }


        private class TaskInfo
        {
            public Task Task { get; set; }
            public CancellationTokenSource CancellationTokenSource { get; set; }
        }

    }
}
