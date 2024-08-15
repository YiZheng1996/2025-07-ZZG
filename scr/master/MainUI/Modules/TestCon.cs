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
    public partial class TestCon : BaseModule
    {
        public TestCon()
        {
            this.Driver = VarHelper.opcTestCon;
            InitializeComponent();
        }

        public TestCon(IContainer container)
              : base(container)
        {
            this.Driver = VarHelper.opcTestCon;
            InitializeComponent();
        }
        private const int cnt = 0;
        private object[] TestConList = new object[cnt];
        /// <summary>
        /// 对象索引器，电磁阀数组
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get
            {
                return TestConList[index];
            }
            set
            {
                string tag = index.ToString().PadLeft(2, '0');
                this.Write("TestCon.P" + tag, value);
            }
        }
        public event ValueGroupHandler<object> TestConGroupChanged;
        public void Fresh()
        {
            for (int i = 0; i < TestConList.Length; i++)
            {
                if (TestConGroupChanged != null)
                {
                    TestConGroupChanged(this, i, TestConList[i]);
                }
            }
        }
        /// <summary>
        /// 手/自动切换（0手动 1自动）
        /// </summary>
        public long HandAuto
        {
            get { return TestConList[0].ToInt(); }
            set { this.Write("TestCon.P00", value); }
        }


        /// <summary>
        /// 上极限位
        /// </summary>
        public float TopXW
        {
            get { return float.Parse(TestConList[1].ToString()); }
            set { this.Write("TestCon.P01", value); }
        }
        /// <summary>
        /// 下极限位
        /// </summary>
        public float DownXW
        {
            get { return float.Parse(TestConList[2].ToString()); }
            set { this.Write("TestCon.P02", value); }
        }
      
        public override void Init()
        {
            for (int i = 0; i < cnt; i++)
            {
                int idx = i; // 循环中的i需要用临时变量存储。
                string opcTag = "TestCon.P" + i.ToString().PadLeft(2, '0');
                this.Register<object>(opcTag, delegate (object value)
                {
                    TestConList[idx] = value;
                    if (TestConGroupChanged != null)
                    {
                        TestConGroupChanged(this, idx, value);
                    }
                });
            }
            base.Init();
        }
    }
}
