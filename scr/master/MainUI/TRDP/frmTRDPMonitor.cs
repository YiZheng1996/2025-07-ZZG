using MainUI.TRDP.Model;
using MainUI.UI.BLL;
using RW;
using RW.Log;
using System.Data;
using System.Linq;
using System.Reflection;

namespace MainUI.TRDP
{
    public partial class frmTRDPMonitor : UIForm
    {
        PageModelNew page;
        bool loaded = false;
        List<Ports> ports = [];  //端口集合
        List<FullTagsETH> tags = [];//所有设置数据集合
        Dictionary<COMMData, FullTagsETH> dicItems = []; //数据模型集合
        public static Dictionary<int, byte[]> ReceiveData = [];//存储了所有接收数据的ComID
        Dictionary<string, FlowLayoutPanel> fullControls = [];  //所有的 ControlCollection
        public static Dictionary<int, byte[]> fullData = [];//所有待发送的数据，通过端口号进行存储
        private readonly Dictionary<int, ucByte> fullIdentity = [];//存储了所有的标识列，用于刷新时，自增

        public bool? ReadOnly { get; set; }//true为宿端口，false为源端口，null为通用，

        struct PageModelNew
        {
            public int Offset { get; set; }
            public int Length { get; set; }
            public int TotalSize { get; set; }
        }

        public frmTRDPMonitor() => InitializeComponent();

        /// <summary>
        /// 加载端口页面数据
        /// 层级结构为：TagControl->TabPage->FlowLayoutPanel->ucBit/ucByte
        /// 每个TabPage对应一个计时器，当TabPage显示在UI时，启动定时器，否则停止。 读定时器随时打开
        /// </summary>
        /// <param name="commType">0为以太网，1为MVB</param>
        /// <param name="readOnly">true为宿端口，false为源端口，null为通用</param>
        private void LoadData(bool? readOnly)
        {
            fullControls.Clear();
            GC.Collect();
            ETHPortsBLL bllPorts = new();
            ports = [.. bllPorts.GetPortsByType(ReadOnly, VarHelper.ModelName)];
            ETHTagsBLL bllTags = new();
            tags = [.. bllTags.GetAllTags(VarHelper.ModelName).OrderByDescending(x => x.COMMData.Bit)];
            List<int> lifes = [];
            ReceiveData.Clear();
            foreach (var item in ports)
            {
                fullData[item.PortNum] = new byte[item.DataSize];
                if (!item.IsRead)
                    lifes.Add(item.DataSize);
                else
                    ReceiveData.Add(item.Port.ToInt(), new byte[item.DataSize]);
            }
            //ReceiveData = ReceiveData.OrderBy(x => x).ToDictionary(k => k.Key, v => v.Value);
            foreach (var item in tags)
                dicItems[item.COMMData] = item;
        }

        void LoadTabs()
        {
            page.Offset = 0;
            page.Length = 1300;
            UIPanel ctrls = PanelContent;
            ctrls.Controls.Clear();
            GC.Collect();
            Stopwatch watch = new();
            watch.Start();
            LoadPage(page.Offset, page.Length);
            Debug.WriteLine("add cost:" + watch.ElapsedMilliseconds);
        }

        TreeView tr;
        /// <summary>
        /// 加载树状图
        /// </summary>
        /// <param name="SerchKey"></param>
        private void LoadLeftTree(string SerchKey)
        {
            tr = new();
            PanelTree.Controls.Clear();
            tr.ImageList = imageList1;
            tr.NodeMouseClick += Tr_NodeMouseClick;
            tr.Dock = DockStyle.Fill;
            foreach (var item in ports)
            {
                TreeNode node = new();
                node.ImageIndex = item.IsRead ? node.ImageIndex = 0 : node.ImageIndex = 1;
                node.Text = item.PortName + "(" + item.Port /*+ "/" + "ETH" + item.ETHPassage*/ + ")";
                if (!node.Text.Contains(SerchKey))
                    continue;
                if (ReadOnly != null && ReadOnly != item.IsRead)
                    continue;
                node.Tag = item;
                tr.Nodes.Add(node);
            }
            if (PanelContent.Tag == null)
            {
                if (ports.Count > 0)
                {
                    PanelContent.Tag = tr.Nodes[0].Tag;
                    tr.Nodes[0].Checked = true;
                }
                else
                    return;
            }
            PanelTree.Controls.Add(tr);
            LoadTabs();
        }

        /// <summary>
        /// 加载右侧内容
        /// </summary>
        /// <param name="plChild"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param> 
        void LoadPage(int offset, int length)
        {
            try
            {
                Color backColor = Color.FromName(ConfigManager.Layout.ItemColor);
                Ports item = PanelContent.Tag as Ports;
                labPresentPort.Text = string.Format("{0}({1})，端口周期：{2}ms", item.PortName, item.Port, item.Rate);
                string port = item.Port;
                int portNum = item.ETHPortNum;

                //先找到容器
                FlowLayoutPanel flow = null;
                if (PanelContent.Controls.Count == 0 || true)
                {
                    flow = new()
                    {
                        Padding = new Padding(5),
                        Size = PanelContent.Size,
                        Dock = DockStyle.Fill,
                        AutoScroll = true
                    };

                    if (ConfigManager.Layout.RightToLeft)
                        flow.FlowDirection = FlowDirection.RightToLeft;
                    else
                        flow.FlowDirection = FlowDirection.LeftToRight;
                }
                else
                {
                    flow = PanelContent.Controls[0] as FlowLayoutPanel;
                }

                string controlsKey = item.Port;
                if (fullControls.TryGetValue(controlsKey, out FlowLayoutPanel value))
                {
                    PanelContent.Controls.Clear();
                    PanelContent.Controls.Add(value);
                }
                else
                {
                    var items = tags.Where(x => x.COMMData.Port == portNum && x.COMMData.Offset >= offset * length && x.COMMData.Offset < (offset + 1) * length).OrderBy(x => x.COMMData.Offset).OrderBy(x => x.COMMData.Bit).ToList();
                    int lastType = 0;//标识上一次是什么类型（连续状态），bit位或非bit类型，主要用于判断是否需要截断 0标识无，1表示非bit，2表示bit
                    int minOffset = items.Count == 0 ? 0 : items.Min(x => x.COMMData.Offset);
                    int maxOffset = items.Count == 0 ? 0 : items.Max(x => x.COMMData.Offset);
                    Padding p = new(1, ConfigManager.Layout.LineSpace, 1, ConfigManager.Layout.LineSpace);
                    Stopwatch watch = new();
                    watch.Start();
                    for (int i = minOffset; i <= maxOffset; i++)
                    {
                        COMMData d = new();
                        FullTagsETH tag = new();
                        int bitCount = items.Where(x => x.COMMData.Offset == i).Count();
                        List<int> bits = items.Where(x => x.COMMData.Offset == i).Select(x => x.COMMData.Bit).ToList();
                        var GroupETHBit = items.Where(x => x.COMMData.Offset == i).Select(x => x.COMMData.GroupETHBit).ToList();
                        for (int k = 0; k < bitCount; k++)
                        {
                            d.Port = portNum;
                            d.Offset = i;
                            d.Bit = bits[k];
                            d.GroupETHBit = GroupETHBit[k];

                            //TODO:如果比特位没有从0开始，可能会有小问题
                            if (!dicItems.ContainsKey(d))
                            {
                                Debug.WriteLine($"COMID：{d.Port}，字节偏移：{d.Offset}，位偏移：{d.Bit}");
                                if (ConfigManager.Layout.NumHold) //模拟量占位
                                {
                                    UserControl ub = new()
                                    {
                                        BorderStyle = BorderStyle.FixedSingle,
                                        BackColor = SystemColors.Control,
                                        Size = new Size(238, 60),
                                        Margin = p
                                    };
                                    //自动截断
                                    if (lastType != 1 && lastType != 0 && ConfigManager.Layout.Cut)
                                    {
                                        flow.SetFlowBreak(flow.Controls[flow.Controls.Count - 1], true);
                                    }
                                    flow.Controls.Add(ub);
                                    lastType = 1;
                                    continue;
                                }
                                //bit位不从0开始，重新找16次，直到找到位置；否则说明该字节内，不存在数据
                                int j = 1;
                                for (; j < 16; j++)
                                {
                                    d.Bit = j;
                                    if (dicItems.ContainsKey(d))
                                    {
                                        //key = d.ToString();
                                        break;
                                    }
                                }
                                //找到最后也没有
                                if (j == 16) continue;
                            }

                            tag = dicItems[d];
                            if (!tag.DataType.Contains('B'))//非数字量，
                            {
                                if (tag.DataType == "I16") i++;
                                ucByte ub = new()
                                {
                                    Size = new Size(238, 60),
                                    Margin = p,
                                    Text = tag.DataLabel,
                                    Port = tag.COMMData.Port,
                                    ReadOnly = item.IsRead,
                                    Offset = tag.COMMData.Offset,
                                    Bit = tag.COMMData.Bit,
                                    TRDPNo = item.TRDPNo,
                                    ETHPassage = item.ETHPassage,
                                    Unit = tag.DataUnit,
                                    IsSensorRange = tag.IsSensorRange,
                                    PortPattern = tag.PortPattern,
                                    BitValue = tag.BitValue,
                                    VariableType = (VariableTypeEnums)Enum.Parse(typeof(VariableTypeEnums), tag.DataType),
                                    BackColor = backColor
                                };
                                ub.Submits += new RW.Modules.ValueHandler<double>(ub_Submits);
                                //自动截断
                                if (lastType != 1 && lastType != 0 && ConfigManager.Layout.Cut)
                                {
                                    flow.SetFlowBreak(flow.Controls[flow.Controls.Count - 1], true);
                                }

                                //如果是自增列，填充到自增的缓存中
                                if (tag.Identity)
                                {
                                    ub.Enabled = false;
                                    fullIdentity[portNum] = ub;
                                }
                                flow.Controls.Add(ub);
                                lastType = 1;
                            }
                            else
                            {
                                if (tag.DataType == "B1")
                                {
                                    d.Bit = tag.COMMData.Bit;
                                    Size s = new(100, 60);
                                    if (ConfigManager.Layout.BitCount == 8)//每行显示8位还是16位
                                        s = new(138, 65);
                                    Control c = null;
                                    tag = dicItems[d];
                                    ucBit bit = new()
                                    {
                                        BackColor = backColor,
                                        Size = s,
                                        Margin = p,
                                        Text = tag.DataLabel,
                                        Port = tag.COMMData.Port,
                                        Offset = tag.COMMData.Offset,
                                        Bit = tag.COMMData.Bit,
                                        TRDPNo = item.TRDPNo,
                                        ETHPassage = item.ETHPassage,
                                        ReadOnly = item.IsRead,
                                        DataRange = tag.PortPattern
                                    };
                                    bit.Click += new EventHandler(bit_Click);
                                    c = bit;

                                    if (lastType != 2 && lastType != 0 && ConfigManager.Layout.Cut)
                                    {
                                        flow.SetFlowBreak(flow.Controls[flow.Controls.Count - 1], true);
                                    }
                                    lastType = 2;
                                    flow.Controls.Add(c);
                                    Debug.WriteLine("添加2Bit：" + c.Text);
                                }
                                else
                                {
                                    d.Bit = tag.COMMData.Bit;
                                    Size s = new(100, 60);
                                    if (ConfigManager.Layout.BitCount == 8)//每行显示8位还是16位
                                        s = new Size(138, 65);
                                    Control c = null;
                                    tag = dicItems[d];
                                    ucTwoBit bit = new()
                                    {
                                        BackColor = backColor,
                                        Size = s,
                                        Margin = p,
                                        Text = tag.DataLabel,
                                        Port = tag.COMMData.Port,
                                        Offset = tag.COMMData.Offset,
                                        Bit = tag.COMMData.GroupETHBit,
                                        TRDPNo = item.TRDPNo,
                                        ETHPassage = item.ETHPassage,
                                        Description = tag.Description,
                                        ReadOnly = item.IsRead,
                                        DataRange = tag.PortPattern
                                    };
                                    bit.Click += new EventHandler(bit2_Click);
                                    c = bit;
                                    bit.AddToolTop(toolTip1, bit.Description);
                                    if (lastType != 2 && lastType != 0 && ConfigManager.Layout.Cut)
                                        flow.SetFlowBreak(flow.Controls[flow.Controls.Count - 1], true);

                                    lastType = 2;
                                    flow.Controls.Add(c);
                                }
                            }
                        }
                    }
                    if (PanelContent.Controls.Count > 0)
                    {
                        Control c = PanelContent.Controls[0];
                        PanelContent.Controls.Remove(c);
                        PanelContent.Controls.Clear();
                        GC.Collect();
                    }
                    PanelContent.Controls.Add(flow);
                    fullControls[controlsKey] = flow;
                    Debug.WriteLine(string.Format("load port:{0} cost:{1}", port, watch.ElapsedMilliseconds));
                    watch.Stop();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("加载右侧内容：" + ex.Message);
                MessageHelper.UIMessageOK("加载右侧内容：" + ex.Message);
            }
        }

        // check状态
        private void bitStatus(string bitName, FrmBite bi, bool status)
        {
            var Keys = VarHelper.GetValue(bitName);
            for (int i = 0; i < Keys.Length; i++)
            {
                var index = Keys[i];
                if (Data.TryGetValue(index, out bool value))
                {
                    if (!status)
                        bi.checkValue[index.ToInt()] = value;
                    else
                        Data[index] = bi.checkValue[index.ToInt()];
                }
                else
                {
                    Data.Add(index, bi.checkValue[index.ToInt()]);
                }
            }
        }

        List<ucTwoBit> bite2 = [];
        Dictionary<string, bool> Data = [];
        void bit2_Click(object sender, EventArgs e)
        {
            bite2.Clear();
            ucTwoBit bit = sender as ucTwoBit;
            FrmBite bi = new(bit);
            bitStatus(bit.Bit, bi, false);
            bi.ShowDialog();
            var Keys = VarHelper.GetValue(bit.Bit);
            bitStatus(bit.Bit, bi, true);
            bite2.Add(bit);
            bit.Switch = bi.checkValue.Where(x => x).Any();
            try
            {
                if (bit.TRDPNo == 1)
                {
                    DataWriteTwoBite(ref VarHelperETH.byteSend, bit.Offset, bi.checkValue, Keys);
                }
                else
                {
                    DataWriteTwoBite(ref VarHelperETH.byteSend2, bit.Offset, bi.checkValue, Keys);
                }
                if (bit.TRDPNo == 2)
                {
                    DataWriteTwoBite(ref VarHelperETH.byteSend3, bit.Offset, bi.checkValue, Keys);
                }
                else
                {
                    DataWriteTwoBite(ref VarHelperETH.byteSend4, bit.Offset, bi.checkValue, Keys);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据写入失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void DataWriteTwoBite(ref byte[] by, int Offset, bool[] value, params string[] funcs)
        {
            ConvertBoolToTwoByte(ref by, Offset, value, funcs);
        }

        public static void ConvertBoolToTwoByte(ref byte[] sendbyte, int byteIndex, bool[] value, params string[] funcs)
        {
            byte bytevalue = sendbyte[byteIndex];
            for (int i = 0; i < funcs.Length; i++)
            {
                int index = funcs[i].ToInt();
                bool[] barr = DataConversionClass.conversion2(bytevalue);
                barr[index] = value[index];
                bytevalue = (byte)DataConversionClass.conversion10(barr[0], barr[1], barr[2], barr[3], barr[4], barr[5], barr[6], barr[7]);
            }
            sendbyte[byteIndex] = bytevalue;
        }

        public static void ConvertBoolToTwoByte(ref byte[] sendbyte, int byteIndex, bool[] value, int bitIndex, int bit2Index)
        {
            byte bytevalue = sendbyte[byteIndex];

            bool[] barr = DataConversionClass.conversion2(bytevalue);
            barr[bitIndex] = value[0];
            bytevalue = (byte)DataConversionClass.conversion10(barr[0], barr[1], barr[2], barr[3], barr[4], barr[5], barr[6], barr[7]);
            bool[] barr2 = DataConversionClass.conversion2(bytevalue);
            barr2[bit2Index] = value[1];

            bytevalue = (byte)DataConversionClass.conversion10(barr2[0], barr2[1], barr2[2], barr2[3], barr2[4], barr2[5], barr2[6], barr2[7]);
            sendbyte[byteIndex] = bytevalue;
        }

        //转实体类
        public static List<T> DataTableToList<T>(DataTable dt) where T : new()
        {
            Type type = typeof(T);
            var properties = type.GetProperties().ToList();
            List<T> list = [];
            foreach (DataRow row in dt.Rows)
            {
                T obj = new();
                foreach (var prop in properties)
                {
                    if (dt.Columns.Contains(prop.Name))
                    {
                        PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        if (propertyInfo != null && row[prop.Name].GetType() != typeof(DBNull))
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }

        TRDPDriver TRDP_CCU;  //网关(设备盒子)01
        TRDPDriver TRDP_CCU2; //网关(设备盒子)02
        // ========== 【新增】网关3 和 网关4 驱动器 ==========
        TRDPDriver TRDP_CCU3; //网关(设备盒子)03
        TRDPDriver TRDP_CCU4; //网关(设备盒子)04

        TRDPMainSend config_CCU;  //模拟CCU - 网关1通道1
        TRDPMainSend config_CCU2; //网关1通道2
        TRDPMainSend config_CCU3; //网关2通道1
        TRDPMainSend config_CCU4; //网关2通道2
        // ========== 【新增】网关3 和 网关4 配置 ==========
        TRDPMainSend config_CCU5; //网关3通道1
        TRDPMainSend config_CCU6; //网关3通道2
        TRDPMainSend config_CCU7; //网关4通道1
        TRDPMainSend config_CCU8; //网关4通道2

        ToTCMSSend CCU_Send = null;  //通道1 - 网关1通道1
        ToTCMSSend CCU_Send2 = null; //通道2 - 网关1通道2
        ToTCMSSend CCU_Send3 = null; //通道3 - 网关2通道1
        ToTCMSSend CCU_Send4 = null; //通道4 - 网关2通道2
        // ========== 【新增】网关3 和 网关4 发送通道 ==========
        ToTCMSSend CCU_Send5 = null; //通道5 - 网关3通道1
        ToTCMSSend CCU_Send6 = null; //通道6 - 网关3通道2
        ToTCMSSend CCU_Send7 = null; //通道7 - 网关4通道1
        ToTCMSSend CCU_Send8 = null; //通道8 - 网关4通道2

        public void TRDPstart()
        {
            #region 以太网初始化
            try
            {
                ZZCTRDPConfig trdpconfig = new();

                // ============ 网关1 初始化 ============
                if (TRDP_CCU == null)
                {
                    TRDP_CCU = new TRDPDriver();
                    TRDP_CCU.Init(trdpconfig.DesIP1, trdpconfig.Desport1.ToInt(), trdpconfig.LocalIP1, trdpconfig.LocalPort1.ToInt());
                }

                // 使用配置对象创建发送配置
                string Config0 = $"{VarHelper.ModelName}_trdp_eth0";
                string Config1 = $"{VarHelper.ModelName}_trdp_eth1";
                string Config2 = $"{VarHelper.ModelName}_trdp_eth2";
                string Config3 = $"{VarHelper.ModelName}_trdp_eth3";
                // ========== 【新增】网关3和网关4的配置文件名 ==========
                string Config4 = $"{VarHelper.ModelName}_trdp_eth4";
                string Config5 = $"{VarHelper.ModelName}_trdp_eth5";
                string Config6 = $"{VarHelper.ModelName}_trdp_eth6";
                string Config7 = $"{VarHelper.ModelName}_trdp_eth7";

                CCU_Send = new(Config0);
                CCU_Send2 = new(Config1);
                CCU_Send3 = new(Config2);
                CCU_Send4 = new(Config3);
                // ========== 【新增】网关3和网关4的发送通道初始化 ==========
                CCU_Send5 = new(Config4);
                CCU_Send6 = new(Config5);
                CCU_Send7 = new(Config6);
                CCU_Send8 = new(Config7);

                config_CCU = new TRDPMainSend(Config0);
                config_CCU2 = new TRDPMainSend(Config1);
                config_CCU3 = new TRDPMainSend(Config2);
                config_CCU4 = new TRDPMainSend(Config3);
                // ========== 【新增】网关3和网关4的配置对象初始化 ==========
                config_CCU5 = new TRDPMainSend(Config4);
                config_CCU6 = new TRDPMainSend(Config5);
                config_CCU7 = new TRDPMainSend(Config6);
                config_CCU8 = new TRDPMainSend(Config7);

                // 配置主帧数据发送 - 网关1
                TRDP_CCU.SetSetting(config_CCU);
                Thread.Sleep(50);
                TRDP_CCU.SetSetting(config_CCU2);
                Thread.Sleep(50);
                // 监听数据返回
                TRDP_CCU.Connect();
                TRDP_CCU.Recieved += trdp_Recieved;

                // ============ 网关2 初始化 ============
                if (TRDP_CCU2 == null)
                {
                    TRDP_CCU2 = new TRDPDriver();
                    TRDP_CCU2.Init(trdpconfig.DesIP2, trdpconfig.Desport2.ToInt(), trdpconfig.LocalIP2, trdpconfig.LocalPort2.ToInt());
                }
                // 配置主帧数据发送 - 网关2
                TRDP_CCU2.SetSetting(config_CCU3);
                Thread.Sleep(50);
                TRDP_CCU2.SetSetting(config_CCU4);
                Thread.Sleep(50);
                // 监听数据返回
                TRDP_CCU2.Connect();
                TRDP_CCU2.Recieved += (trdp_Recieved);

                // ========== 【新增】网关3 初始化 ==========
                if (!string.IsNullOrEmpty(trdpconfig.DesIP3) && !string.IsNullOrEmpty(trdpconfig.LocalIP3))
                {
                    if (TRDP_CCU3 == null)
                    {
                        TRDP_CCU3 = new TRDPDriver();
                        TRDP_CCU3.Init(trdpconfig.DesIP3, trdpconfig.Desport3.ToInt(), trdpconfig.LocalIP3, trdpconfig.LocalPort3.ToInt());
                    }
                    // 配置主帧数据发送 - 网关3
                    TRDP_CCU3.SetSetting(config_CCU5);
                    Thread.Sleep(50);
                    TRDP_CCU3.SetSetting(config_CCU6);
                    Thread.Sleep(50);
                    // 监听数据返回
                    TRDP_CCU3.Connect();
                    TRDP_CCU3.Recieved += (trdp_Recieved);
                }

                // ========== 【新增】网关4 初始化 ==========
                if (!string.IsNullOrEmpty(trdpconfig.DesIP4) && !string.IsNullOrEmpty(trdpconfig.LocalIP4))
                {
                    if (TRDP_CCU4 == null)
                    {
                        TRDP_CCU4 = new TRDPDriver();
                        TRDP_CCU4.Init(trdpconfig.DesIP4, trdpconfig.Desport4.ToInt(), trdpconfig.LocalIP4, trdpconfig.LocalPort4.ToInt());
                    }
                    // 配置主帧数据发送 - 网关4
                    TRDP_CCU4.SetSetting(config_CCU7);
                    Thread.Sleep(50);
                    TRDP_CCU4.SetSetting(config_CCU8);
                    Thread.Sleep(50);
                    // 监听数据返回
                    TRDP_CCU4.Connect();
                    TRDP_CCU4.Recieved += (trdp_Recieved);
                }

                // 初始化发送数据数组 - 网关1
                var dataSize = ports.First(x => x.TRDPNo == 1 && !x.IsRead).DataSize;
                VarHelperETH.byteSend = new byte[dataSize];
                VarHelperETH.byteSend2 = new byte[dataSize];

                // 初始化发送数据数组 - 网关2
                var dataSizeTwo = ports?.FirstOrDefault(x => x.TRDPNo == 2 && !x.IsRead);
                if (dataSizeTwo != null)
                {
                    VarHelperETH.byteSend3 = new byte[dataSizeTwo.DataSize];
                    VarHelperETH.byteSend4 = new byte[dataSizeTwo.DataSize];
                }

                // ========== 【新增】初始化发送数据数组 - 网关3 ==========
                var dataSizeThree = ports?.FirstOrDefault(x => x.TRDPNo == 3 && !x.IsRead);
                if (dataSizeThree != null)
                {
                    VarHelperETH.byteSend5 = new byte[dataSizeThree.DataSize];
                    VarHelperETH.byteSend6 = new byte[dataSizeThree.DataSize];
                }

                // ========== 【新增】初始化发送数据数组 - 网关4 ==========
                var dataSizeFour = ports?.FirstOrDefault(x => x.TRDPNo == 4 && !x.IsRead);
                if (dataSizeFour != null)
                {
                    VarHelperETH.byteSend7 = new byte[dataSizeFour.DataSize];
                    VarHelperETH.byteSend8 = new byte[dataSizeFour.DataSize];
                }

                // 生命信号
                var pt = ports.GroupBy(p => p.Rate);
                if (ports == null) return;
                RegisterLife(pt);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("TRDP初始化失败：" + ex.Message);
                NlogHelper.Default.Error("TRDP初始化失败：", ex);
            }
            #endregion
        }

        private void trdp_Recieved(object sender, TRDPCommandTypes commandType, BaseRecieveModel recieved)
        {
            // 只有从TCMS接收的数据才能
            if (commandType == TRDPCommandTypes.RecieveTCMS0 || commandType == TRDPCommandTypes.RecieveTCMS1)
            {
                FromTCMSRecieve tcms = recieved as FromTCMSRecieve;
                if (ReceiveData.ContainsKey(tcms.ComId))
                    ReceiveData[tcms.ComId] = tcms.DatasetData;
            }
        }
        void ub_Submits(object sender, double value)
        {
            ucByte Byte = sender as ucByte;
            byte hh;
            byte bh;
            byte ll;
            byte bl;
            //if (e.KeyChar.ToString() == "\r")
            //{
            double fvalue = 0;
            try
            {
                fvalue = Byte.Value;
                int bitnum = (int)(fvalue / Byte.BitValue);
                if (Byte.VariableType.ToString() == "U8")
                {
                    if (Byte.TRDPNo == 1)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend[Byte.Offset] = SwapByteBits(VarHelperETH.ConvertInt8ToByte(bitnum));
                            }
                            else
                            {
                                VarHelperETH.byteSend[Byte.Offset] = VarHelperETH.ConvertInt8ToByte(bitnum);
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend2[Byte.Offset] = SwapByteBits(VarHelperETH.ConvertInt8ToByte(bitnum));
                            }
                            else
                            {
                                VarHelperETH.byteSend2[Byte.Offset] = VarHelperETH.ConvertInt8ToByte(bitnum);
                            }
                        }
                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                    if (Byte.TRDPNo == 2)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend3[Byte.Offset] = SwapByteBits(VarHelperETH.ConvertInt8ToByte(bitnum));
                            }
                            else
                            {
                                VarHelperETH.byteSend3[Byte.Offset] = VarHelperETH.ConvertInt8ToByte(bitnum);
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend4[Byte.Offset] = SwapByteBits(VarHelperETH.ConvertInt8ToByte(bitnum));
                            }
                            else
                            {
                                VarHelperETH.byteSend4[Byte.Offset] = VarHelperETH.ConvertInt8ToByte(bitnum);
                            }
                        }
                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                    if (Byte.TRDPNo == 3)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend5[Byte.Offset] = SwapByteBits(VarHelperETH.ConvertInt8ToByte(bitnum));
                            }
                            else
                            {
                                VarHelperETH.byteSend5[Byte.Offset] = VarHelperETH.ConvertInt8ToByte(bitnum);
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend6[Byte.Offset] = SwapByteBits(VarHelperETH.ConvertInt8ToByte(bitnum));
                            }
                            else
                            {
                                VarHelperETH.byteSend6[Byte.Offset] = VarHelperETH.ConvertInt8ToByte(bitnum);
                            }
                        }
                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                    if (Byte.TRDPNo == 4)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend7[Byte.Offset] = SwapByteBits(VarHelperETH.ConvertInt8ToByte(bitnum));
                            }
                            else
                            {
                                VarHelperETH.byteSend7[Byte.Offset] = VarHelperETH.ConvertInt8ToByte(bitnum);
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend8[Byte.Offset] = SwapByteBits(VarHelperETH.ConvertInt8ToByte(bitnum));
                            }
                            else
                            {
                                VarHelperETH.byteSend8[Byte.Offset] = VarHelperETH.ConvertInt8ToByte(bitnum);
                            }
                        }
                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                }

                if (Byte.VariableType.ToString() == "U16")
                {
                    bh = (byte)Byte.Offset;
                    bl = (byte)(Byte.Offset + 1);
                    if (Byte.TRDPNo == 1)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                            else
                            {
                                VarHelperETH.byteSend[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend2[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend2[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                            else
                            {
                                VarHelperETH.byteSend2[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend2[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                            }
                        }
                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                    if (Byte.TRDPNo == 2)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend3[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend3[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                            else
                            {
                                VarHelperETH.byteSend3[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend3[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend4[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend4[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                            else
                            {
                                VarHelperETH.byteSend4[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend4[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                            }
                        }

                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                    if (Byte.TRDPNo == 3)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend5[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend5[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                            else
                            {
                                VarHelperETH.byteSend5[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend5[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend6[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend6[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                            else
                            {
                                VarHelperETH.byteSend6[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend6[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                            }
                        }

                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                    if (Byte.TRDPNo == 4)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend7[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend7[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                            else
                            {
                                VarHelperETH.byteSend7[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend7[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (Byte.PortPattern)
                            {
                                VarHelperETH.byteSend8[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend8[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                            else
                            {
                                VarHelperETH.byteSend8[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend8[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                            }
                        }

                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                }

                if (Byte.VariableType.ToString() == "U32")
                {
                    hh = (byte)Byte.Offset;
                    bh = (byte)(Byte.Offset + 1);
                    ll = (byte)(Byte.Offset + 2);
                    bl = (byte)(Byte.Offset + 3);
                    if (Byte.TRDPNo == 1)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (!Byte.PortPattern)
                            {
                                VarHelperETH.byteSend[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                            }
                            else
                            {
                                VarHelperETH.byteSend[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                                VarHelperETH.byteSend[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (!Byte.PortPattern)
                            {
                                VarHelperETH.byteSend2[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend2[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend2[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend2[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                            }
                            else
                            {
                                VarHelperETH.byteSend2[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                                VarHelperETH.byteSend2[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend2[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend2[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                        }
                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                    if (Byte.TRDPNo == 2)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (!Byte.PortPattern)
                            {
                                VarHelperETH.byteSend3[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend3[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend3[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend3[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                            }
                            else
                            {
                                VarHelperETH.byteSend3[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                                VarHelperETH.byteSend3[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend3[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend3[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (!Byte.PortPattern)
                            {
                                VarHelperETH.byteSend4[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend4[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend4[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend4[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                            }
                            else
                            {
                                VarHelperETH.byteSend4[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                                VarHelperETH.byteSend4[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend4[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend4[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                        }
                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                    if (Byte.TRDPNo == 3)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (!Byte.PortPattern)
                            {
                                VarHelperETH.byteSend5[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend5[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend5[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend5[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                            }
                            else
                            {
                                VarHelperETH.byteSend5[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                                VarHelperETH.byteSend5[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend5[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend5[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (!Byte.PortPattern)
                            {
                                VarHelperETH.byteSend6[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend6[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend6[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend6[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                            }
                            else
                            {
                                VarHelperETH.byteSend6[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                                VarHelperETH.byteSend6[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend6[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend6[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                        }
                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                    if (Byte.TRDPNo == 4)
                    {
                        if (Byte.ETHPassage == 1)
                        {
                            if (!Byte.PortPattern)
                            {
                                VarHelperETH.byteSend7[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend7[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend7[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend7[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                            }
                            else
                            {
                                VarHelperETH.byteSend7[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                                VarHelperETH.byteSend7[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend7[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend7[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                        }
                        if (Byte.ETHPassage == 2)
                        {
                            if (!Byte.PortPattern)
                            {
                                VarHelperETH.byteSend8[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend8[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend8[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend8[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                            }
                            else
                            {
                                VarHelperETH.byteSend8[hh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[3];
                                VarHelperETH.byteSend8[bh] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[2];
                                VarHelperETH.byteSend8[ll] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[1];
                                VarHelperETH.byteSend8[bl] = VarHelperETH.ConvertInt32ToByte(bitnum, Byte.VariableType.ToString())[0];
                            }
                        }
                        SendValue(Byte.Port, Byte.TRDPNo.ToString(), Byte.ETHPassage.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLine(ex.Message);
                MessageBox.Show("输入数值格式不正确！" + ex.Message);
            }
        }

        /// <summary>
        /// 字节前4位与高4位互换
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        byte SwapByteBits(byte b)
        {
            // 将字节 b 的前四位与后四位交换
            return (byte)(((b >> 4) & 0x0F) | ((b << 4) & 0xF0));
        }

        void SetCRCAndSend(ToTCMSSend send, byte[] data, int port)
        {
            // 获取当前端口的CRC配置
            var crcConfig = tempCRCTag.FirstOrDefault(x =>
                x.Port == port.ToString());

            if (crcConfig != null && crcConfig.IsCRC)
            {
                // 计算CRC校验值
                byte[] crc = CRC16_FALSEHelper.Instance.CRC16(data, 0, crcConfig.COMMData.Offset);
                data[crcConfig.COMMData.Offset] = crc[1];
                data[crcConfig.COMMData.Offset + 1] = crc[0];
                Debug.WriteLine("CRC校验数据：" + data.ToHexString(" "));
            }

            send.SequenceCounter++;
            send.DatasetData = data;
            send.DatasetLength = data.Length;
            send.DataLength = send.DatasetLength + 20;
            send.ComId = port;
        }

        public void SendValue(int port, string trdpno, string passage)
        {
            try
            {
                switch (trdpno)
                {
                    case "1": // 网关1
                        if (passage == "1")
                        {
                            SetCRCAndSend(CCU_Send, VarHelperETH.byteSend, port);
                            TRDP_CCU.SetToTCMS_old(CCU_Send, trdpno, passage);
                        }
                        else
                        {
                            SetCRCAndSend(CCU_Send2, VarHelperETH.byteSend2, port);
                            TRDP_CCU.SetToTCMS_old(CCU_Send2, trdpno, passage);
                        }
                        break;
                    case "2": // 网关2
                        if (passage == "1")
                        {
                            SetCRCAndSend(CCU_Send3, VarHelperETH.byteSend3, port);
                            TRDP_CCU2?.SetToTCMS_old(CCU_Send3, trdpno, passage);
                        }
                        else
                        {
                            SetCRCAndSend(CCU_Send4, VarHelperETH.byteSend4, port);
                            TRDP_CCU2?.SetToTCMS_old(CCU_Send4, trdpno, passage);
                        }
                        break;
                    // ========== 【新增】网关3 数据发送 ==========
                    case "3": // 网关3
                        if (passage == "1")
                        {
                            SetCRCAndSend(CCU_Send5, VarHelperETH.byteSend5, port);
                            TRDP_CCU3?.SetToTCMS_old(CCU_Send5, trdpno, passage);
                        }
                        else
                        {
                            SetCRCAndSend(CCU_Send6, VarHelperETH.byteSend6, port);
                            TRDP_CCU3?.SetToTCMS_old(CCU_Send6, trdpno, passage);
                        }
                        break;
                    // ========== 【新增】网关4 数据发送 ==========
                    case "4": // 网关4
                        if (passage == "1")
                        {
                            SetCRCAndSend(CCU_Send7, VarHelperETH.byteSend7, port);
                            TRDP_CCU4?.SetToTCMS_old(CCU_Send7, trdpno, passage);
                        }
                        else
                        {
                            SetCRCAndSend(CCU_Send8, VarHelperETH.byteSend8, port);
                            TRDP_CCU4?.SetToTCMS_old(CCU_Send8, trdpno, passage);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                NlogHelper.Default.Error("SendValue错误：", ex);
            }
        }

        void bit_Click(object sender, EventArgs e)
        {
            ucBit bit = sender as ucBit;
            var a = bit.Switch;
            Debug.WriteLine("bit write:" + bit.Text + "," + bit.Offset + "." + bit.Bit + ":" + bit.Switch);
            try
            {
                switch (bit.TRDPNo)
                {
                    case 1:
                    {
                        if (bit.ETHPassage == 1)
                        {
                            DataWrite(ref VarHelperETH.byteSend, bit.Offset, bit.Bit, bit.Switch);
                        }
                        else
                        {
                            DataWrite(ref VarHelperETH.byteSend2, bit.Offset, bit.Bit, bit.Switch);
                        }

                        break;
                    }
                    case 2:
                    {
                        if (bit.ETHPassage == 1)
                        {
                            DataWrite(ref VarHelperETH.byteSend3, bit.Offset, bit.Bit, bit.Switch);
                        }
                        else
                        {
                            DataWrite(ref VarHelperETH.byteSend4, bit.Offset, bit.Bit, bit.Switch);
                        }

                        break;
                    }
                    // ========== 【新增】网关3 位数据写入 ==========
                    case 3:
                    {
                        if (bit.ETHPassage == 1)
                        {
                            DataWrite(ref VarHelperETH.byteSend5, bit.Offset, bit.Bit, bit.Switch);
                        }
                        else
                        {
                            DataWrite(ref VarHelperETH.byteSend6, bit.Offset, bit.Bit, bit.Switch);
                        }

                        break;
                    }
                    // ========== 【新增】网关4 位数据写入 ==========
                    case 4:
                    {
                        if (bit.ETHPassage == 1)
                        {
                            DataWrite(ref VarHelperETH.byteSend7, bit.Offset, bit.Bit, bit.Switch);
                        }
                        else
                        {
                            DataWrite(ref VarHelperETH.byteSend8, bit.Offset, bit.Bit, bit.Switch);
                        }

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据写入失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 数据写入通用方法，自动判断当前是
        /// </summary>
        /// <param name="commType">通讯类型，0为以太网，1为MVB</param>
        /// <param name="port">通讯的端口号</param>
        /// <param name="Offset">字节偏移量</param>
        /// <param name="bit">位偏移量</param>
        /// <param name="value">写入的值，</param>
        /// <param name="value">是否生命信号，</param>
        void DataWrite(ref byte[] by, int Offset, int bitSrc, object value)
        {

            byte[] bts = null;
            switch (value.GetType().Name)
            {
                case "Boolean":
                    if (value.Equals(true))
                    {
                        //ConvertBoolToByte(by, Offset, bitSrc, true);
                        //fullData[port][Offset] =  (byte) by[Offset] | (1 << bit));
                        ConvertBoolToByte(ref by, Offset, bitSrc, true);
                    }
                    else
                    {
                        // fullData[port][Offset] = (byte)(fullData[port][Offset] & ~(1 << bit));
                        ConvertBoolToByte(ref by, Offset, bitSrc, false);
                    }
                    break;
                case "Byte":
                    bts = [Convert.ToByte(value)];
                    Offset += bitSrc;
                    break;
                case "Int16": bts = BitConverter.GetBytes(Convert.ToInt16(value)); break;
                case "UInt16": bts = BitConverter.GetBytes(Convert.ToUInt16(value)); break;
                case "Int32": bts = BitConverter.GetBytes(Convert.ToInt32(value)); break;
                case "UInt32": bts = BitConverter.GetBytes(Convert.ToUInt32(value)); break;
                case "Int64": bts = BitConverter.GetBytes(Convert.ToInt64(value)); break;
                case "UInt64": bts = BitConverter.GetBytes(Convert.ToUInt64(value)); break;
                case "Single": bts = BitConverter.GetBytes(Convert.ToSingle(value)); break;
                case "Double": bts = BitConverter.GetBytes(Convert.ToDouble(value)); break;
                default:
                    break;
            }

            string txt = "";
            if (bts != null)
            {
                byte[] w = (byte[])Enumerable.Reverse(bts);
                for (int i = 0; i < w.Length; i++)
                {
                    txt += Convert.ToString(w[i], 16).PadLeft(2, '0') + " ";
                }
                Debug.WriteLine($"{DateTime.Now:HH:mm:ss.ffffff} write offset={Offset},bit={bitSrc},value={value}[{value.GetType().Name}][{txt}]");
                //fullData[port][Offset] = bts;
                Array.Copy(w, 0, by, Offset, w.Length);
            }
            else
            {
                Debug.WriteLine($"{DateTime.Now:HH:mm:ss.ffffff} write bit,offset={Offset},bit={bitSrc},value={value}");
            }
        }

        public static void ConvertBoolToByte(ref byte[] sendbyte, int byteIndex, int bitIndex, bool value)
        {
            byte bytevalue = sendbyte[byteIndex];

            bool[] barr = DataConversionClass.conversion2(bytevalue);
            barr[bitIndex] = value;

            bytevalue = (byte)DataConversionClass.conversion10(barr[0], barr[1], barr[2], barr[3], barr[4], barr[5], barr[6], barr[7]);
            sendbyte[byteIndex] = bytevalue;

        }

        /// <summary>
        /// 初始化
        /// </summary>
        private new void Init()
        {
            loaded = true;
            if (ReadOnly is null)
                radNone.Checked = ReadOnly == null;
            else
            {
                radSource.Checked = !ReadOnly.Value;
                radHost.Checked = ReadOnly.Value;
            }
            LoadData(ReadOnly);
            LoadLeftTree("");
        }

        #region 生命信号相关
        readonly List<FullTagsETH> tempLifeTag = [];
        readonly List<FullTagsETH> tempCRCTag = [];
        readonly bool closed = false;
        bool IsStarat = false;
        /// <summary>
        /// 注册生命信号处理线程
        /// 功能：为不同速率的端口组创建生命信号处理线程
        /// 修改：将原来的两个独立线程合并为一个统一处理线程，支持多种数据类型
        /// </summary>
        /// <param name="group">按速率分组的端口集合</param>
        void RegisterLife(IEnumerable<IGrouping<int, Ports>> group)
        {
            // 清空临时标签集合，为本次注册做准备
            tempLifeTag.Clear();
            tempCRCTag.Clear();

            // 遍历每个速率组
            foreach (var item in group)
            {
                List<Ports> list = [.. item];
                int rata = item.Key; // 获取当前组的刷新速率（毫秒）

                // 遍历当前速率组中的每个端口
                foreach (var pt in list)
                {
                    // 查找需要CRC校验的端口标签
                    // 条件：端口号匹配 && 启用CRC校验
                    FullTagsETH CRC = tags.FirstOrDefault(p => p.COMMData.Port == pt.ETHPortNum && p.IsCRC);
                    if (CRC != null)
                    {
                        tempCRCTag.Add(CRC); // 添加到CRC处理列表
                    }

                    // 查找生命信号标签
                    // 条件：端口号匹配 && 非只读端口 && 是自增标识（生命信号）
                    FullTagsETH mode = tags.FirstOrDefault(p => p.COMMData.Port == pt.ETHPortNum && !pt.IsRead && p.Identity);
                    if (mode != null)
                    {
                        // 设置TRDP网关编号和以太网通道编号
                        mode.TRDPNo = pt.TRDPNo;       // 网关编号：1或2
                        mode.ETHPassage = pt.ETHPassage; // 以太网通道：1或2
                        tempLifeTag.Add(mode); // 添加到生命信号处理列表
                    }
                }

                // 如果找到生命信号标签且尚未启动处理线程，则创建统一的生命信号处理线程
                // 注意：原来的逻辑是分别为网关1和网关2创建独立线程，现在合并为一个线程处理所有生命信号
                if (tempLifeTag.Count != 0 && !IsStarat)
                {
                    CreateLifeSignalThread(rata); // 创建生命信号处理线程
                    IsStarat = true; // 标记已启动，避免重复创建
                }
            }
        }

        /// <summary>
        /// 创建生命信号处理线程
        /// 功能：创建后台线程，定时更新所有网关的生命信号
        /// 替代：原来的两个独立线程（网关1线程 + 网关2线程）
        /// </summary>
        /// <param name="rata">生命信号更新间隔（毫秒）</param>
        private void CreateLifeSignalThread(int rata)
        {
            // 创建后台线程
            Thread lifeThread = new(new ThreadStart(() =>
            {
                double value = 0; // 生命信号计数器，每次循环自增

                // 线程主循环：直到窗体销毁或手动关闭
                while (!IsDisposed && !closed)
                {
                    try
                    {
                        // 遍历所有生命信号标签，逐个处理
                        // 这里替代了原来的两个独立foreach循环
                        foreach (var tg in tempLifeTag)
                        {
                            // 统一处理生命信号：支持U8/U16/U32等多种数据类型
                            ProcessLifeSignal(tg, value, tg.COMMData.Offset);
                        }
                    }
                    catch (Exception ex)
                    {
                        // 异常处理：记录错误日志，但不中断线程运行
                        Debug.WriteLine("生命信号写入错误：" + ex.Message);
                        NlogHelper.Default.Error("生命信号写入错误：", ex);
                    }
                    finally
                    {
                        // 无论是否发生异常，都要执行的清理工作
                        value++;           // 生命信号值自增
                        Thread.Sleep(rata); // 按指定间隔休眠
                    }
                }
            }))
            {
                IsBackground = true // 设置为后台线程，主线程结束时自动结束
            };

            lifeThread.Start(); // 启动线程
        }

        /// <summary>
        /// 处理单个生命信号
        /// 功能：将生命信号值写入对应的字节数组，并发送数据
        /// 替代：原来在两个线程中的重复处理逻辑
        /// </summary>
        /// <param name="tg">生命信号标签配置</param>
        /// <param name="value">当前生命信号值</param>
        /// <param name="portIndex">在字节数组中的偏移位置</param>
        private void ProcessLifeSignal(FullTagsETH tg, double value, int portIndex)
        {
            try
            {
                // 根据数据类型转换生命信号值
                // 支持：U8(byte), U16(ushort), U32(uint), I8(sbyte), I16(short), I32(int)
                // 这里解决了原来固定转换为byte导致U16/U32值被截断的问题
                object lifeObj = Comsum(tg.DataType, ref value);

                // 根据TRDP网关编号和以太网通道获取目标字节数组和禁用状态
                // 映射关系：
                // - TRDPNo=1, ETHPassage=1 → byteSend + ckbCCU_life
                // - TRDPNo=1, ETHPassage=2 → byteSend2 + ckbCCU_life2  
                // - TRDPNo=2, ETHPassage=1 → byteSend3 + ckbCCU_life3
                // - TRDPNo=2, ETHPassage=2 → byteSend4 + ckbCCU_life4
                var (targetArray, isDisabled) = GetLifeSignalTarget(tg.TRDPNo, tg.ETHPassage);

                // 检查目标数组是否有效且生命信号未被手动禁用
                if (targetArray != null && !isDisabled)
                {
                    // 将生命信号值写入目标字节数组
                    // 根据数据类型确定写入字节数：U8写1字节，U16写2字节，U32写4字节
                    WriteLifeSignalValue(targetArray, lifeObj, tg.DataType, portIndex);

                    // 发送数据到TRDP网关
                    // 参数：端口号，TRDP网关编号，以太网通道编号
                    SendValue(Convert.ToInt32(tg.Port), tg.TRDPNo.ToString(), tg.ETHPassage.ToString());
                }
            }
            catch (Exception ex)
            {
                // 记录详细的错误信息，便于调试
                Debug.WriteLine($"处理生命信号错误 - TRDPNo:{tg.TRDPNo}, ETHPassage:{tg.ETHPassage}, 数据类型:{tg.DataType}, 错误:{ex.Message}");
            }
        }

        /// <summary>
        /// 获取生命信号目标数组和禁用状态
        /// 功能：根据TRDP网关编号和以太网通道编号，返回对应的字节数组和检查框状态
        /// 替代：原来在两个线程中的重复if-else判断逻辑
        /// </summary>
        /// <param name="trdpNo">TRDP网关编号（1、2、3或4）</param>
        /// <param name="ethPassage">以太网通道编号（1或2）</param>
        /// <returns>元组：(目标字节数组, 是否禁用生命信号)</returns>
        private (byte[] array, bool disabled) GetLifeSignalTarget(int trdpNo, int ethPassage)
        {
            return (trdpNo, ethPassage) switch
            {
                // 网关1 通道1：使用byteSend数组，检查ckbCCU_life复选框
                (1, 1) => (VarHelperETH.byteSend, ckbCCU_life.Checked),

                // 网关1 通道2：使用byteSend2数组，检查ckbCCU_life2复选框  
                (1, 2) => (VarHelperETH.byteSend2, ckbCCU_life2.Checked),

                // 网关2 通道1：使用byteSend3数组，检查ckbCCU_life3复选框
                (2, 1) => (VarHelperETH.byteSend3, ckbCCU_life3.Checked),

                // 网关2 通道2：使用byteSend4数组，检查ckbCCU_life4复选框
                (2, 2) => (VarHelperETH.byteSend4, ckbCCU_life4.Checked),

                // ========== 【新增】网关3 通道1：使用byteSend5数组，检查ckbCCU_life5复选框 ==========
                (3, 1) => (VarHelperETH.byteSend5, ckbCCU_life5.Checked),

                // ========== 【新增】网关3 通道2：使用byteSend6数组，检查ckbCCU_life6复选框 ==========
                (3, 2) => (VarHelperETH.byteSend6, ckbCCU_life6.Checked),

                // ========== 【新增】网关4 通道1：使用byteSend7数组，检查ckbCCU_life7复选框 ==========
                (4, 1) => (VarHelperETH.byteSend7, ckbCCU_life7.Checked),

                // ========== 【新增】网关4 通道2：使用byteSend8数组，检查ckbCCU_life8复选框 ==========
                (4, 2) => (VarHelperETH.byteSend8, ckbCCU_life8.Checked),

                // 无效配置：返回空数组和禁用状态
                _ => (null, true)
            };
        }

        /// <summary>
        /// 将生命信号值写入字节数组
        /// 功能：根据数据类型，将生命信号值正确写入目标字节数组
        /// 新增：支持U16和U32数据类型，解决原来值被截断的问题
        /// </summary>
        /// <param name="targetArray">目标字节数组</param>
        /// <param name="value">生命信号值对象</param>
        /// <param name="dataType">数据类型字符串</param>
        /// <param name="portIndex">写入位置的起始索引</param>
        private void WriteLifeSignalValue(byte[] targetArray, object value, string dataType, int portIndex)
        {
            // 将字符串数据类型转换为枚举
            var dataTypeEnum = (VariableTypeEnums)Enum.Parse(typeof(VariableTypeEnums), dataType);

            // 边界检查：确保写入位置不会超出数组范围
            if (portIndex < 0 || portIndex >= targetArray.Length)
            {
                Debug.WriteLine($"生命信号端口索引越界: {portIndex}, 数组长度: {targetArray.Length}");
                return;
            }

            // 根据数据类型执行不同的写入逻辑
            switch (dataTypeEnum)
            {
                // 8位数据类型：直接写入1个字节
                case VariableTypeEnums.U8:  // 无符号8位整数 (0-255)
                case VariableTypeEnums.I8:  // 有符号8位整数 (-128到127)
                    targetArray[portIndex] = (byte)value;
                    break;

                // 16位数据类型：写入2个字节（小端序）
                case VariableTypeEnums.U16: // 无符号16位整数 (0-65535)
                case VariableTypeEnums.I16: // 有符号16位整数 (-32768到32767)
                                            // 检查是否有足够空间写入2个字节
                    if (portIndex + 1 < targetArray.Length)
                    {
                        // 将16位值转换为字节数组（小端序）
                        byte[] bytes16 = BitConverter.GetBytes((ushort)value);
                        targetArray[portIndex] = bytes16[0];     // 低位字节
                        targetArray[portIndex + 1] = bytes16[1]; // 高位字节
                    }
                    else
                    {
                        Debug.WriteLine($"U16生命信号写入越界: 索引{portIndex}, 需要2字节, 数组长度{targetArray.Length}");
                    }
                    break;

                // 32位数据类型：写入4个字节（小端序）
                case VariableTypeEnums.U32: // 无符号32位整数 (0-4294967295)
                case VariableTypeEnums.I32: // 有符号32位整数 (-2147483648到2147483647)
                                            // 检查是否有足够空间写入4个字节
                    if (portIndex + 3 < targetArray.Length)
                    {
                        // 将32位值转换为字节数组（小端序）
                        byte[] bytes32 = BitConverter.GetBytes((uint)value);
                        // 批量复制4个字节
                        Array.Copy(bytes32, 0, targetArray, portIndex, 4);
                    }
                    else
                    {
                        Debug.WriteLine($"U32生命信号写入越界: 索引{portIndex}, 需要4字节, 数组长度{targetArray.Length}");
                    }
                    break;

                // 不支持的数据类型
                default:
                    Debug.WriteLine($"不支持的生命信号数据类型: {dataType}");
                    break;
            }
        }
        /// <summary>
        /// 累加
        /// </summary>
        private static object Comsum(string dataType, ref double value)
        {
            var types = (VariableTypeEnums)Enum.Parse(typeof(VariableTypeEnums), dataType);
            object writeValue;
            switch (types)
            {
                case VariableTypeEnums.U8: writeValue = (byte)value; break;
                case VariableTypeEnums.I8: writeValue = (byte)value; break;
                case VariableTypeEnums.U16: writeValue = (ushort)value; break;
                case VariableTypeEnums.I16: writeValue = (short)value; break;
                case VariableTypeEnums.U32: writeValue = (uint)value; break;
                case VariableTypeEnums.I32: writeValue = (int)value; break;
                case VariableTypeEnums.U64: writeValue = (ulong)value; break;
                case VariableTypeEnums.I64: writeValue = (long)value; break;
                case VariableTypeEnums.Bit:
                case VariableTypeEnums.None:
                default:
                    throw new NotImplementedException("系统不支持的数据类型。");
            }
            return writeValue;
        }
        #endregion


        private void Tr_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            PanelContent.Tag = node.Tag;
            LoadTabs();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        SystemConfig sys = new();
        System.Windows.Forms.Timer tmrRead = new();

        private void frmTRDPMonitor_Load(object sender, EventArgs e)
        {
            try
            {
                Init();
                TRDPstart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TRDP通讯失败：" + ex.Message);
            }

            tmrRead.Interval = sys.MvbDataReadInterval;
            tmrRead.Tick += new EventHandler(tmrRead_Tick);
            tmrRead.Start();
        }

        void tmrRead_Tick(object sender, EventArgs e)
        {
            if (closed) tmrRead.Stop();
            Stopwatch timeWatch = new();
            timeWatch.Start();
            Stopwatch watch = new();
            watch.Start();
            //Debug.WriteLine("start:" + watch.Elapsed.ToString());
            if (PanelContent.Controls.Count == 0)
                return;

            foreach (var item in PanelContent.Controls[0].Controls)
            {
                if (item is ucBit)
                {
                    ucBit bit = item as ucBit;
                    int offset = bit.Offset;
                    int bits = bit.Bit;
                    int Port = bit.Port;
                    if (!bit.ReadOnly)
                        continue;
                    int bitValue = 1 << bits;
                    bool b = (ReceiveData[Port][offset] & bitValue) == bitValue;
                    if (b == bit.Switch) continue;
                    bit.Switch = b;
                }
                else if (item is ucByte)
                {
                    ucByte ub = item as ucByte;
                    int offset = ub.Offset;
                    int Port = ub.Port;
                    string y = ub.Text;
                    foreach (var tg in tempLifeTag)
                    {
                        if (ub.TRDPNo == 1)
                        {
                            if (offset == tg.COMMData.Offset)
                            {
                                if (!ckbCCU_life.Checked && ub.ETHPassage == 1)
                                {
                                    // 原代码：ub.Value = VarHelperETH.byteSend[offset];
                                    // 新代码：根据数据类型正确读取
                                    ub.Value = ReadLifeSignalValueFromArray(VarHelperETH.byteSend, tg.DataType, offset);
                                }
                                else if (!ckbCCU_life2.Checked && ub.ETHPassage == 2)
                                {
                                    // 原代码：ub.Value = VarHelperETH.byteSend2[offset];  
                                    // 新代码：根据数据类型正确读取
                                    ub.Value = ReadLifeSignalValueFromArray(VarHelperETH.byteSend2, tg.DataType, offset);
                                }
                                continue;
                            }
                        }
                        if (ub.TRDPNo == 2)
                        {
                            if (offset == tg.COMMData.Offset)
                            {
                                if (!ckbCCU_life3.Checked && ub.ETHPassage == 1)
                                {
                                    // 原代码：ub.Value = VarHelperETH.byteSend3[offset];
                                    // 新代码：根据数据类型正确读取
                                    ub.Value = ReadLifeSignalValueFromArray(VarHelperETH.byteSend3, tg.DataType, offset);
                                }
                                else if (!ckbCCU_life4.Checked && ub.ETHPassage == 2)
                                {
                                    // 原代码：ub.Value = VarHelperETH.byteSend4[offset];
                                    // 新代码：根据数据类型正确读取
                                    ub.Value = ReadLifeSignalValueFromArray(VarHelperETH.byteSend4, tg.DataType, offset);
                                }
                                continue;
                            }
                        }
                        if (ub.TRDPNo == 3)
                        {
                            if (offset == tg.COMMData.Offset)
                            {
                                if (!ckbCCU_life5.Checked && ub.ETHPassage == 1)
                                {
                                    ub.Value = ReadLifeSignalValueFromArray(VarHelperETH.byteSend5, tg.DataType, offset);
                                }
                                else if (!ckbCCU_life6.Checked && ub.ETHPassage == 2)
                                {
                                    ub.Value = ReadLifeSignalValueFromArray(VarHelperETH.byteSend6, tg.DataType, offset);
                                }
                                continue;
                            }
                        }
                        if (ub.TRDPNo == 4)
                        {
                            if (offset == tg.COMMData.Offset)
                            {
                                if (!ckbCCU_life7.Checked && ub.ETHPassage == 1)
                                {
                                    ub.Value = ReadLifeSignalValueFromArray(VarHelperETH.byteSend7, tg.DataType, offset);
                                }
                                else if (!ckbCCU_life8.Checked && ub.ETHPassage == 2)
                                {
                                    ub.Value = ReadLifeSignalValueFromArray(VarHelperETH.byteSend8, tg.DataType, offset);
                                }
                                continue;
                            }
                        }
                    }
                    if (!ub.ReadOnly)
                        continue;
                    decimal value = 0M;
                    int bits = ub.Bit;
                    byte[] temp;
                    switch (ub.VariableType)
                    {
                        case VariableTypeEnums.U3:
                            value = ReceiveData[Port][offset] >> bits & 7;
                            break;
                        case VariableTypeEnums.U5:
                            value = ReceiveData[Port][offset] >> bits & 0x1F;
                            break;
                        case VariableTypeEnums.U8:
                            offset += ub.Bit;
                            value = ReceiveData[Port][offset] >> bits;
                            break;
                        case VariableTypeEnums.I8:
                            value = ReceiveData[Port][offset] >> bits;//TODO：请注意，此处负数的处理
                            break;
                        case VariableTypeEnums.U16:
                            temp = new byte[2];
                            Array.Copy(ReceiveData[Port], offset, temp, bits, temp.Length);
                            if (!ub.PortPattern)
                                value = BitConverter.ToUInt16([.. temp], 0);
                            else
                                value = BitConverter.ToUInt16(temp.Reverse().ToArray(), 0);
                            break;
                        case VariableTypeEnums.I16:
                            temp = new byte[2];
                            Array.Copy(ReceiveData[Port], offset, temp, bits, temp.Length);
                            if (!ub.PortPattern)
                                value = BitConverter.ToUInt16([.. temp], 0);
                            else
                                value = BitConverter.ToUInt16(temp.Reverse().ToArray(), 0);
                            break;
                        case VariableTypeEnums.U32:
                            temp = new byte[4];
                            Array.Copy(ReceiveData[Port], offset, temp, bits, temp.Length);
                            if (!ub.PortPattern)
                                value = BitConverter.ToUInt32([.. temp], 0);
                            else
                                value = BitConverter.ToUInt32(temp.Reverse().ToArray(), 0);
                            break;
                        case VariableTypeEnums.I32:
                            temp = new byte[4];
                            Array.Copy(ReceiveData[Port], offset, temp, bits, temp.Length);
                            if (!ub.PortPattern)
                                value = BitConverter.ToUInt32([.. temp], 0);
                            else
                                value = BitConverter.ToUInt32(temp.Reverse().ToArray(), 0);
                            break;
                        case VariableTypeEnums.U64:
                            temp = new byte[8];
                            Array.Copy(ReceiveData[Port], offset, temp, bits, temp.Length);
                            if (!ub.PortPattern)
                                value = BitConverter.ToUInt64([.. temp], 0);
                            else
                                value = BitConverter.ToUInt64(temp.Reverse().ToArray(), 0);
                            break;
                        case VariableTypeEnums.I64:
                            temp = new byte[8];
                            Array.Copy(ReceiveData[Port], offset, temp, bits, temp.Length);
                            if (!ub.PortPattern)
                                value = BitConverter.ToUInt64([.. temp], 0);
                            else
                                value = BitConverter.ToUInt64(temp.Reverse().ToArray(), 0);
                            break;
                        default:
                            break;
                    }
                    if ((decimal)ub.Value != value)
                        ub.Value = (double)value * ub.BitValue;
                }
            }
            watch.Stop();
            //this.switchLabel2.Switch = MvbDllCall.gf_result == MvbDllCall.GF_RESULT.GF_OK;
            timeWatch.Stop();
        }

        /// <summary>
        /// 从字节数组中读取生命信号值
        /// 功能：仅用于生命信号控件的值读取，根据数据类型返回正确的数值
        /// </summary>
        /// <param name="sourceArray">源字节数组</param>
        /// <param name="dataType">数据类型字符串</param>
        /// <param name="offset">偏移位置</param>
        /// <returns>生命信号值</returns>
        private double ReadLifeSignalValueFromArray(byte[] sourceArray, string dataType, int offset)
        {
            if (sourceArray == null || offset < 0 || offset >= sourceArray.Length)
                return 0;

            try
            {
                var dataTypeEnum = (VariableTypeEnums)Enum.Parse(typeof(VariableTypeEnums), dataType);

                switch (dataTypeEnum)
                {
                    case VariableTypeEnums.U8:
                    case VariableTypeEnums.I8:
                        // 读取1个字节（保持原有行为）
                        return sourceArray[offset];

                    case VariableTypeEnums.U16:
                        // 读取2个字节
                        if (offset + 1 < sourceArray.Length)
                        {
                            return BitConverter.ToUInt16(sourceArray, offset);
                        }
                        return sourceArray[offset]; // 边界保护

                    case VariableTypeEnums.I16:
                        if (offset + 1 < sourceArray.Length)
                        {
                            return BitConverter.ToInt16(sourceArray, offset);
                        }
                        return sourceArray[offset];

                    case VariableTypeEnums.U32:
                        // 读取4个字节
                        if (offset + 3 < sourceArray.Length)
                        {
                            return BitConverter.ToUInt32(sourceArray, offset);
                        }
                        return sourceArray[offset];

                    case VariableTypeEnums.I32:
                        if (offset + 3 < sourceArray.Length)
                        {
                            return BitConverter.ToInt32(sourceArray, offset);
                        }
                        return sourceArray[offset];

                    default:
                        // 不支持的类型，使用原有行为
                        return sourceArray[offset];
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"读取生命信号值错误: 数据类型={dataType}, 偏移={offset}, 错误={ex.Message}");
                return sourceArray[offset]; // 出错时回退到原有行为
            }
        }

        List<Control> selected = [];
        void clearSelect()
        {
            foreach (var item in selected)
            {
                item.BackColor = Color.FromName(ConfigManager.Layout.ItemColor);
            }
            selected.Clear();
        }
        void SelectPanlControl(string text)
        {
            clearSelect();
            if (string.IsNullOrEmpty(text))
                return;
            bool exists = false;

            Ports p = (PanelContent.Tag as Ports);
            foreach (Control label in PanelContent.Controls[0].Controls)
            {
                if (label is ucByte)
                {
                    ucByte ub = label as ucByte;
                    if (ub.Text.Contains(text))
                    {
                        selected.Add(ub);
                        label.BackColor = Color.Yellow;
                        exists = true;
                    }
                }
                else if (label is ucBit)
                {
                    ucBit bit = label as ucBit;
                    if (bit.Text.Contains(text))
                    {
                        selected.Add(bit);
                        label.BackColor = Color.Yellow;
                        exists = true;
                    }
                }
            }
            if (!exists)
                MessageBox.Show("没有检索到任何值。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            SelectPanlControl(key);
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            LoadLeftTree(txtPortName.Text.Trim());
        }

        private void radSource_CheckedChanged(object sender, EventArgs e)
        {
            if (!loaded) return;
            this.ReadOnly = false;
            PanelContent.Tag = null;
            LoadLeftTree("");
        }

        private void radHost_CheckedChanged(object sender, EventArgs e)
        {
            if (!loaded) return;
            this.ReadOnly = true;
            PanelContent.Tag = null;
            LoadLeftTree("");
        }

        private void radNone_CheckedChanged(object sender, EventArgs e)
        {
            if (!loaded) return;
            this.ReadOnly = null;
            PanelContent.Tag = null;
            LoadLeftTree("");
        }
    }
}
