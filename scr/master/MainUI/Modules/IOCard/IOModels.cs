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
    public partial class IOModels : BaseModule
    {
        //public delegate void Dcf_Del(int index, bool state);   
        //public event Dcf_Del Dcf_event;
        //在RW.Modules类中定义了该委托
        public event ValueGroupHandler<bool> Dcf_event;    //定义一个事件委托

        public IOModels(int IOindex)
        {
            InitializeComponent();
            this.Driver = VarHelper.opcIO;
            this.Card_Index = IOindex;
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
        /// <param name="IOIndex"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetCardModel(int index, bool value)       //写值操作
        {
            Write($"Card{Card_Index}.M" + index.ToString().PadLeft(2, '0'), value);
        }


        /// <summary>
        /// 获取状态
        /// </summary>
        bool[] Array_CardModel = new bool[24];
        public bool[] ArrayIOModel
        {
            get { return Array_CardModel; }
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
            { return Array_CardModel[index - 1]; }        //返回模式当前状态
            set
            { this.Write($"Card{Card_Index}.M" + index.ToString().PadLeft(2, '0'), value); }  //设置当前模式状态
        }

        //BaseModule
        public override void Init()
        {
            for (int i = 0; i < 24; i++)
            {
                int temp = i;
                Register<bool>($"Card{Card_Index}.M" + (temp + 1).ToString().PadLeft(2, '0'), delegate (bool Dcf_value)
                {
                    Array_CardModel[temp] = Dcf_value;
                    if (Dcf_event != null)
                        Dcf_event(this, temp, Dcf_value);
                });
            }
            base.Init();
        }

    }
}
