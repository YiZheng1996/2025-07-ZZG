using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.CAN
{
    public partial class frmPowerDown : UIForm
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern uint GetTickCount();
        private uint T1;

        public frmPowerDown()
        {
            InitializeComponent();
        }

        private void StartTest()
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                T1 = GetTickCount();
                //TODO:给出DO信号开始计时，记录开始时间，直至接收不到CAN数据后停止计时，计算开始结束时间差值
                DateTime startTime = DateTime.Now;
                DateTime eedTime = DateTime.Now;

                //Common.DOgrp[0] = true;
                //while (Common.AIgrp.AIList[1] < paraconfig.TestHeight && Convert.ToInt32(GetTickCount() - T1) < 60000);

                TimeSpan difference = startTime - eedTime;
                var hours = difference.TotalHours;
                var minutes = difference.TotalMinutes;
                var seconds = difference.TotalSeconds;
                var millisecond = difference.TotalMilliseconds;
            });
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTest();
        }
    }
}
