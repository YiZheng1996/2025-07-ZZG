using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RW.Modules;

namespace ServoTired
{
    public partial class DIGrp : BaseModule
    {
        public DIGrp()
        {
            Driver = Helper.opcDI;
            InitializeComponent();
        }

        public DIGrp(IContainer container)
                        : base(container)
        {
            this.Driver = Helper.opcDI;
        }
        private const int DIcnt = 45;
        private bool[] _diList = new bool[DIcnt];
        public bool[] DIList
        {
            get { return _diList; }
        }
        public void Fresh()
        {
            for (int i = 0; i < _diList.Length; i++)
            {
                DIGroupChanged?.Invoke(this, i, _diList[i]);
            }
        }
        public event ValueGroupHandler<bool> DIGroupChanged;
        public override void Init()
        {
            for (int i = 0; i < DIcnt; i++)
            {
                int idx = i; // 循环中的i需要用临时变量存储。
                string opcTag = "DI.MDI" + i.ToString().PadLeft(3, '0');
                AddListening(opcTag, delegate (bool value)
                {
                    //数组赋值
                    _diList[idx] = value;
                    DIGroupChanged?.Invoke(this, idx, value);
                });
            }
            base.Init();
        }
    }
}
