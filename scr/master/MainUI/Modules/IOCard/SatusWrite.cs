using MainUI.CurrencyHelper;
using RW.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Modules.IOCard
{
    public partial class SatusWrite : BaseModule
    {
        public event ValueGroupHandler<bool?> Dcf_event;    //定义一个事件委托

        public SatusWrite(int Cradindex)
        {
            InitializeComponent();
            this.Driver = VarHelper.opcIO;
            this.Card_Index = Cradindex;
        }

        protected override void InitComponts()
        {
            base.InitComponts();
            this.Driver = VarHelper.opcIO;
        }

        /// <summary>
        /// 对应OPC中卡
        /// </summary>
        private int Card_Index;

        public int CardIndex
        {
            get { return Card_Index; }
            set { Card_Index = value; }
        }


        /// <summary>
        /// IO模式切换
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetCardStatus(int index, object value)       //写值操作
        {
            this.Write($"Card{Card_Index}.S" + (index + 24).ToString().PadLeft(2, '0'), value);
        }


        /// <summary>
        /// 获取状态
        /// </summary>
        bool?[] Array_CardStatus = new bool?[24];
        public bool?[] ArrayStatus
        {
            get { return Array_CardStatus; }
            //set { Write("DCFDO.R" + (index), value); }
        }

        /// <summary>
        /// 对象索引器，查找模式数组
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool? this[int index]
        {
            get
            { return Array_CardStatus[index]; }        //返回模式当前状态
            set
            {
                int Index = 25 + index;
                Write($"Card{Card_Index}.S" + Index.ToString().PadLeft(2, '0'), value);
            }
        }

        //BaseModule
        public override void Init()
        {
            for (int i = 0; i < 24; i++)
            {
                int temp = 25 + i;
                int Index = i;
                Register($"Card{Card_Index}.S" + (temp).ToString().PadLeft(2, '0'), delegate (bool[] Dcf_value)
                {
                    //将两个点位作一个点位，返回bool(可为空)，数组长度24
                    if (Dcf_value[0] && Dcf_value[1])
                        Array_CardStatus[Index] = true;
                    else if (!Dcf_value[0] && !Dcf_value[1])
                        Array_CardStatus[Index] = false;
                    else if (Dcf_value[0] && !Dcf_value[1] || !Dcf_value[0] && Dcf_value[1])
                        Array_CardStatus[Index] = null;

                    Dcf_event?.Invoke(this, temp, Array_CardStatus[Index]);
                });
            }
            base.Init();
        }
    }
}
