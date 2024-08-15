using MainUI.Config;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Procedure
{
    [SupportedOSPlatform("windows")]
    public partial class frmWeary : UIForm
    {
        ParaConfig para;
        public frmWeary(ParaConfig para)
        {
            InitializeComponent();
            this.para = para;
            Common.AIgrp.AIvalueGrpChanged += AIgrp_AIvalueGrpChanged;
            Common.DIgrp.DigitalValueChanged += DIgrp_DigitalValueChanged;
        }

        private void DIgrp_DigitalValueChanged(object sender, int index, bool value)
        {
            Console.Write(string.Format("DI---下标：{0}，值：{1}\n", index, value));
        }

        private void AIgrp_AIvalueGrpChanged(object sender, int index, double value)
        {
            Console.Write(string.Format("DI---下标：{0}，值：{1}\n", index, value));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            BigToken?.Cancel();
            isOperationStarted = false;
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
            MessageBox.Show("清零成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Console.Write(bigNowTest + " ");
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

    }
}
