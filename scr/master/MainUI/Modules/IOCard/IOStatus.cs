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
    public partial class IOStatus : BaseModule
    {
        //public delegate void Dcf_Del(int index, bool state);   
        //public event Dcf_Del Dcf_event;
        //在RW.Modules类中定义了该委托
        public event ValueGroupHandler<bool> Dcf_event;    //定义一个事件委托

        public IOStatus(int Cradindex)
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
        public void SetCardStatus(int index, bool value)       //写值操作
        {
            this.Write($"Card{Card_Index}.S" + index.ToString().PadLeft(2, '0'), value);
        }


        /// <summary>
        /// 获取状态
        /// </summary>
        bool[] Array_CardStatus = new bool[25];
        public bool[] ArrayStatus
        {
            get { return Array_CardStatus; }
            //set { Write("DCFDO.R" + (index), value); }
        }

        /// <summary>
        /// 对象索引器，查找模式数组
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool this[int index]
        {
            get
            { return Array_CardStatus[index - 1]; }        //返回模式当前状态
            set
            {
                Write($"Card{Card_Index}.S" + index.ToString().PadLeft(2, '0'), value);
                // Write($"Card{Card_Index}.S" + (index + 24).ToString().PadLeft(2, '0'), value);
            }  //设置当前模式状态
        }

        //BaseModule
        public override void Init()
        {
            for (int i = 0; i < 24; i++)
            {
                int temp = i;
                Register($"Card{Card_Index}.S" + (temp + 1).ToString().PadLeft(2, '0'), delegate (bool Dcf_value)
                {
                    Array_CardStatus[temp] = Dcf_value;
                    Dcf_event?.Invoke(this, temp, Dcf_value);
                });
            }
            base.Init();
        }

    }
}
