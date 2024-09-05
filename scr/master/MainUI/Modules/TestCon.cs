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
    public partial class TestCon : BaseModule
    {
        public TestCon()
        {
            Driver = VarHelper.opcTestCon;
            InitializeComponent();
        }

        public TestCon(IContainer container)
              : base(container)
        {
            Driver = VarHelper.opcTestCon;
            InitializeComponent();
        }
        private const int cnt = 0;
        private readonly object[] TestConList = [];
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
                Write("TestCon.P" + tag, value);
            }
        }
        public event ValueGroupHandler<object> TestConGroupChanged;
        public void Fresh()
        {
            for (int i = 0; i < TestConList.Length; i++)
            {
                TestConGroupChanged?.Invoke(this, i, TestConList[i]);
            }
        }
        /// <summary>
        /// 手/自动切换（0手动 1自动）
        /// </summary>
        public long HandAuto
        {
            get { return TestConList[0].ToInt(); }
            set { Write("TestCon.P00", value); }
        }

      
        public override void Init()
        {
            for (int i = 0; i < cnt; i++)
            {
                int idx = i; // 循环中的i需要用临时变量存储。
                string opcTag = "TestCon.P" + i.ToString().PadLeft(2, '0');
                Register(opcTag, delegate (object value)
                {
                    TestConList[idx] = value;
                    TestConGroupChanged?.Invoke(this, idx, value);
                });
            }
            base.Init();
        }
    }
}
