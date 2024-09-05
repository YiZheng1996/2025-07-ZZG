using MainUI.CurrencyHelper;
using RW.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Modules
{
    public partial class TestPara : BaseModule
    {
        public TestPara()
        {
           // this.Driver = Var.opcTestPara;
            InitializeComponent();
        }

        public TestPara(IContainer container)
              : base(container)
        {
        //    this.Driver = Var.opcTestPara;
            InitializeComponent();
        }
        private const int cnt = 16;
        private object[] TestParaList = new object[cnt];
        /// <summary>
        /// 对象索引器，电磁阀数组
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get
            {
                return TestParaList[index];
            }
            set
            {
                string tag = index.ToString().PadLeft(2, '0');
                this.Write("TestPara.P" + tag, value);
            }
        }
        public event ValueGroupHandler<object> TestParaGroupChanged;
        public void Fresh()
        {
            for (int i = 0; i < TestParaList.Length; i++)
            {
                if (TestParaGroupChanged != null)
                {
                    TestParaGroupChanged(this, i, TestParaList[i]);
                }
            }
        }
        /// <summary>
        /// 方向设置
        /// </summary>
        public bool Direction
        {
            get { return TestParaList[5].ToBool(); }
            set { this.Write("TestPara.P05", value); }
        }
        /// <summary>
        /// 速度设置
        /// </summary>
        public string Speed
        {
            get { return TestParaList[6].ToString(); }
            set { this.Write("TestPara.P06", value); }
        }
        /// <summary>
        /// 伸出位移保护值
        /// </summary>
        public string Disp_SC
        {
            get { return TestParaList[8].ToString(); }
            set { this.Write("TestPara.P08", value); }
        }
        /// <summary>
        /// 缩回位移保护值
        /// </summary>
        public string Disp_SH
        {
            get { return TestParaList[09].ToString(); }
            set { this.Write("TestPara.P09", value); }
        }
        /// <summary>
        /// 步骤号
        /// </summary>
        public string TestStepNo
        {
            get { return TestParaList[13].ToString(); }
            set { this.Write("TestPara.P13", value); }
        }

        public override void Init()
        {
            for (int i = 0; i < cnt; i++)
            {
                int idx = i; // 循环中的i需要用临时变量存储。
                string opcTag = "TestPara.P" + i.ToString().PadLeft(2, '0');
                this.Register<object>(opcTag, delegate (object value)
                {
                    TestParaList[idx] = value;
                    if (TestParaGroupChanged != null)
                    {
                        TestParaGroupChanged(this, idx, value);
                    }
                });
            }
            base.Init();
        }
    }
}
