using Dongzr.MidiLite;
using System;
using System.Collections.Generic;
using System.Text;
//using TestFunction_Auto.Class_Test;
using System.Threading;

namespace MainUI.MVB
{
    /// <summary>
    /// 标准车MVB处理
    /// </summary>
    public class Mvb_Bzc
    {

        #region 对象定义

        private MmTimer mmtimer = new();

        /// <summary>
        /// 当前网络编组号
        /// </summary>
        public int BZ_NO;

        /// <summary>
        /// 生命信号
        /// </summary>
        private int life = 0;

        //private int _Level_Set;

        /// <summary>
        /// 级位设定值
        /// 得到PLC中级位实际设定值
        /// </summary>
        public int Level_Set
        {

            get
            {
                int temp = 0;
                try
                {
                    //temp = (int)RWOPC.OpcObject.Pub.LevelMvb.Value;
                }
                catch (Exception)
                {
                    temp = 0;
                }
                return temp;
            }
        }

        #endregion

        #region 通用方法

        /// <summary>
        /// 根据4轴的速度返回最大值
        /// </summary>
        /// <param name="V1">1轴速度</param>
        /// <param name="V2">2轴速度</param>
        /// <param name="V3">3轴速度</param>
        /// <param name="V4">4轴速度</param>
        /// <returns></returns>
        public float VMax(float V1, float V2, float V3, float V4)
        {
            float max12 = Math.Max(V1, V2);
            float max34 = Math.Max(V3, V4);
            return Math.Max(max12, max34);
        }

        /// <summary>
        /// 根据4轴的速度返回最小值
        /// </summary>
        /// <param name="V1">1轴速度</param>
        /// <param name="V2">2轴速度</param>
        /// <param name="V3">3轴速度</param>
        /// <param name="V4">4轴速度</param>
        /// <returns></returns>
        public float VMin(float V1, float V2, float V3, float V4)
        {
            float max12 = Math.Min(V1, V2);
            float max34 = Math.Min(V3, V4);
            return Math.Min(max12, max34);
        }

        #endregion

        /// <summary>
        ///  停止MVB网卡
        /// </summary>
        public void MVBStop()
        {
            MvbDllCall.StopMvb();
        }


        /// <summary>
        /// MVB通讯初始化
        /// </summary>
        public void MvbInit()
        {
            if (MvbDllCall.Configfilename == "")
            {
                MvbDllCall.Configfilename = "DK2.bin";
            }
            if (MvbDllCall.Configfilename_port == "")
            {
                MvbDllCall.Configfilename_port = "MvbConfig_DK2.txt";
            }
            MvbDllCall.MvbConfigLoad();
            MvbDllCall.startMvb();

            life = 0;
            mmtimer.Interval = 32;
            mmtimer.Mode = MmTimerMode.Periodic;
            mmtimer.Tick += new EventHandler(mmtimer_Tick);
            mmtimer.Start();
        }

        /// <summary>
        /// MVB通讯初始化
        /// </summary>
        /// <param name="ConfigName">MVB配置文件名称</param>
        public void MvbInit(string ConfigName)
        {
            MvbDllCall.Configfilename = "DK2.bin";
            MvbDllCall.Configfilename_port = "MvbConfig_DK2.txt";

            MvbDllCall.MvbConfigLoad();
            MvbDllCall.startMvb();

            life = 0;
            mmtimer.Interval = 32;
            mmtimer.Mode = Dongzr.MidiLite.MmTimerMode.Periodic;
            mmtimer.Tick += new EventHandler(mmtimer_Tick);
            mmtimer.Start();

        }

        void mmtimer_Tick(object sender, EventArgs e)
        {
            if (life > 255)
            {
                life = 0;
            }
            else
            {
                life++;
            }
            byte bL, bH;
            ConvertClass.ConvertInt16ToByte(life, out bH, out bL);

            //硬件需要配置终端电阻120Ω，MVB的DB9，1-2,4-5各串一个120Ω的电阻，否则硬件在线状态，会有通讯不稳定，断断续续的情况。 生命信号也有可能出现卡顿的情况。

            MvbDllCall.sendbyte[6, 0] = bH;
            MvbDllCall.sendbyte[6, 1] = bL;

            MvbDllCall.SetCollection();
            MvbDllCall.GetCollection();
        }
    }
}
