namespace MainUI.TRDP
{
    public partial class FrmBite : UIForm
    {
        public FrmBite()
        {
            InitializeComponent();
        }
        public FrmBite(ucTwoBit bite)
        {
            InitializeComponent();
            twobite = bite;
        }

        public bool[] checkValue = new bool[8];
        public readonly ucTwoBit twobite = new();
        public readonly ConcurrentDictionary<int, ucCombinationBit> m_ = [];
        private void FrmBite_Load(object sender, EventArgs e)
        {
            try
            {
                labDescription.Text = twobite.Description;
                var getBit = VarHelper.GetBit(twobite.Bit);
                flowLayoutPanel1.SuspendLayout();
                for (int i = 0; i < getBit.Length; i++)
                {
                    var index = getBit[i].ToInt();
                    ucCombinationBit ucBit = new()
                    {
                        ucIndex = index,
                        ckChecked = checkValue[index],
                        labText = string.Format($"字节{twobite.Offset} 位{getBit[i]}"),
                    };
                    m_.TryAdd(index, ucBit);
                    flowLayoutPanel1.Controls.Add(ucBit);
                    ucBit.CheckClicked += Check_CheckedChanged;
                    if (m_.TryGetValue(ucBit.ucIndex, out ucCombinationBit value))
                    {
                        value.ckText = value.ckChecked.ToString();
                        value.ckColor = value.ckChecked ? Color.SpringGreen : Color.Transparent;
                    }
                }
                flowLayoutPanel1.ResumeLayout();
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("加载组合Bit控件错误：" + ex);
            }
        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ucCombinationBit ucbit)
            {
                var index = ucbit.ucIndex;
                if (m_.TryGetValue(index, out ucCombinationBit value))
                {
                    value.ckText = value.ckChecked.ToString();
                    value.ckColor = value.ckChecked ? Color.SpringGreen : Color.Transparent;
                }
                checkValue[index] = ucbit.ckChecked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
