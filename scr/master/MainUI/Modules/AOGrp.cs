using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainUI.CurrencyHelper;
using NPOI.SS.Formula.Functions;
using RW.Modules;

namespace MainUI.Modules
{
    public partial class AOGrp : BaseModule
    {
        private const int AOcount = 2;
        private double[] AOList = new double[AOcount];
        public event ValueGroupHandler<double> AOvalueGrpChaned;
        public AOGrp()
        {
            Driver = VarHelper.opcAOGroup;
            InitializeComponent();
        }

        public AOGrp(IContainer container)
            : base(container)
        {
            Driver = VarHelper.opcAOGroup;
        }
        public void Fresh()
        {
            for (int i = 0; i < AOList.Length; i++)
            {
                AOvalueGrpChaned?.Invoke(this, i, AOList[i]);
            }
        }

        private double _cao00 = 0;
        private double _cao01 = 0;
        /// <summary>
        /// EP阀
        /// </summary>
        public double CAO00 { get { return _cao00; } set { _cao00 = value; Write("AO.MAQ000", value); } }
        public double CAO01 { get { return _cao01; } set { _cao01 = value; Write("AO.MAQ001", value); } }


        public override void Init()
        {
            for (int i = 0; i < AOcount; i++)
            {
                int idx = i; // 循环中的i需要用临时变量存储。
                string opcTag = "AO.MAQ" + i.ToString().PadLeft(3, '0');
                AddListening<double>(opcTag, delegate (double value)
                {
                    AOList[idx] = value;
                    AOvalueGrpChaned?.Invoke(this, idx, value);
                });
            }
            base.Init();
        }
    }
}
