namespace MainUI.Procedure.ViewModel
{
    /// <summary>
    /// 一键切换功能，航插点位配置信息
    /// </summary>
    public class DODIConfigView
    {
        /// <summary>
        /// 型号ID
        /// </summary>
        public int ModelID { get; set; }

        /// <summary>
        /// 型号：HXD1（铁八）,HXD1（神八）……
        /// </summary>
        public string ModelName { get; set; }

        /// <summary>
        /// 航插X1,X2,X3 或者CN1,CN2,CH3
        /// </summary>
        public string Plug { get; set; }

        /// <summary>
        /// 航插脚位 A1,A2…… F8
        /// </summary>
        public string PlugFoot { get; set; }

        /// <summary>
        /// 线号。例如：896
        /// </summary>
        public string LineNO { get; set; }

        /// <summary>
        /// 线号定义说明。例如：896代表总风压力开关电源 DC 110V
        /// </summary>
        public string LineDesc { get; set; }
        /// <summary>
        /// 0：代表输入。xls配置表写In，检测点DI。 1：代表输出，xls配置表写Out ，控制点DO。
        /// </summary>
        public int LineType { get; set; }

        /// <summary>
        /// 初始值：0：悬空，1：110V信号，2：负信号，3：可操控负信号（悬空(1,0)<==>负信号(0,0)）
        /// </summary>
        public int InitValue { get; set; }

        /// <summary>
        /// 板卡号 1-7
        /// </summary>
        public int CardNo { get; set; }

        /// <summary>
        /// 板卡脚位1-24
        /// </summary>
        public int CardFoot { get; set; }
    }
}
