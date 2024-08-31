using RW;
using RW.Modules;
using System.ComponentModel;

namespace ServoTired
{
    public partial class ServoGrp : BaseModule
    {
        public ServoGrp()
        {
            InitializeComponent();
            Driver = Helper.opcServo;
        }

        public ServoGrp(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            Driver = Helper.opcServo;
        }

        private const int cnt = 32;
        private readonly object[] TestConList = new object[cnt];
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
                Write("Servo.P0" + tag, value);
            }
        }

        public event ValueGroupHandler<object>? TestConGroupChanged;
        public void Fresh()
        {
            for (int i = 0; i < TestConList.Length; i++)
            {
                TestConGroupChanged?.Invoke(this, i, TestConList[i]);
            }
        }
     

        //public bool HandAuto
        //{
        //    get { return TestConList[0]; }
        //    set { Write("Servo.P0", value); }
        //}


        public override void Init()
        {
            for (int i = 0; i < cnt; i++)
            {
                int idx = i; // 循环中的i需要用临时变量存储。
                string opcTag = "Servo.P0" + i.ToString().PadLeft(2, '0');
                AddListening(opcTag, delegate (object value)
                {
                    TestConList[idx] = value;
                    TestConGroupChanged?.Invoke(this, idx, value);
                });
            }
            base.Init();
        }
    }
}
