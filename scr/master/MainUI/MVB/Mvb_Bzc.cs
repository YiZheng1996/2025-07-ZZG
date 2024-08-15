using Dongzr.MidiLite;
using System;
using System.Collections.Generic;
using System.Text;
//using TestFunction_Auto.Class_Test;
using System.Threading;

namespace MainUI.MVB
{
    /// <summary>
    /// ��׼��MVB����
    /// </summary>
    public class Mvb_Bzc
    {

        #region ������

        private MmTimer mmtimer = new();

        /// <summary>
        /// ��ǰ��������
        /// </summary>
        public int BZ_NO;

        /// <summary>
        /// �����ź�
        /// </summary>
        private int life = 0;

        //private int _Level_Set;

        /// <summary>
        /// ��λ�趨ֵ
        /// �õ�PLC�м�λʵ���趨ֵ
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

        #region ͨ�÷���

        /// <summary>
        /// ����4����ٶȷ������ֵ
        /// </summary>
        /// <param name="V1">1���ٶ�</param>
        /// <param name="V2">2���ٶ�</param>
        /// <param name="V3">3���ٶ�</param>
        /// <param name="V4">4���ٶ�</param>
        /// <returns></returns>
        public float VMax(float V1, float V2, float V3, float V4)
        {
            float max12 = Math.Max(V1, V2);
            float max34 = Math.Max(V3, V4);
            return Math.Max(max12, max34);
        }

        /// <summary>
        /// ����4����ٶȷ�����Сֵ
        /// </summary>
        /// <param name="V1">1���ٶ�</param>
        /// <param name="V2">2���ٶ�</param>
        /// <param name="V3">3���ٶ�</param>
        /// <param name="V4">4���ٶ�</param>
        /// <returns></returns>
        public float VMin(float V1, float V2, float V3, float V4)
        {
            float max12 = Math.Min(V1, V2);
            float max34 = Math.Min(V3, V4);
            return Math.Min(max12, max34);
        }

        #endregion

        /// <summary>
        ///  ֹͣMVB����
        /// </summary>
        public void MVBStop()
        {
            MvbDllCall.StopMvb();
        }


        /// <summary>
        /// MVBͨѶ��ʼ��
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
        /// MVBͨѶ��ʼ��
        /// </summary>
        /// <param name="ConfigName">MVB�����ļ�����</param>
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

            //Ӳ����Ҫ�����ն˵���120����MVB��DB9��1-2,4-5����һ��120���ĵ��裬����Ӳ������״̬������ͨѶ���ȶ����϶������������ �����ź�Ҳ�п��ܳ��ֿ��ٵ������

            MvbDllCall.sendbyte[6, 0] = bH;
            MvbDllCall.sendbyte[6, 1] = bL;

            MvbDllCall.SetCollection();
            MvbDllCall.GetCollection();
        }
    }
}
