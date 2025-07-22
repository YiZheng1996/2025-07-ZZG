using MainUI.TRDP.Model;
using MainUI.UI.BLL;
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

        TRDPDriver TRDP_CCU; //网关或设备盒子
        TRDPDriver TRDP_CCU2;
        TRDPMainSend config_CCU;
        TRDPMainSend config_CCU2;
        ToTCMSSend CCU_Send = new(); //盒子或通道
        ToTCMSSend CCU_Send2 = new();
        ToTCMSSend CCU_Send3 = new();
        ToTCMSSend CCU_Send4 = new();
        ETHConfigBLL TRDPName = new();
        Dictionary<string, string> ps = [];
        List<TRDPConfig> trdpconfig = [];
        public void TRDPstart()
        {
            #region  以太网初始化
            try
            {
                ps.Clear();
                ZZCTRDPConfig trdpconfig = new();
                ps = TRDPName.GetDate(VarHelper.ModelName);
                DataTable dt = TRDPName.GetAllPorts(VarHelper.ModelName);
                DataTable dataTable = dt;
                this.trdpconfig = DataTableToList<TRDPConfig>(dataTable);
                string Config0 = ps.FirstOrDefault().Value + 0;
                string Config1 = ps.FirstOrDefault().Value + 1;
                CCU_Send = new(Config0);
                CCU_Send2 = new(Config1);
                if (TRDP_CCU == null)
                {
                    TRDP_CCU = new TRDPDriver();
                    TRDP_CCU.Init(trdpconfig.DesIP1, trdpconfig.Desport1.ToInt(), trdpconfig.LocalIP1, trdpconfig.LocalPort1.ToInt());
                }

                //TODO:由于没有交换机，暂时注释
                if (TRDP_CCU2 == null)
                {
                    TRDP_CCU2 = new TRDPDriver();
                    TRDP_CCU2.Init(trdpconfig.DesIP2, trdpconfig.Desport2.ToInt(), trdpconfig.LocalIP2, trdpconfig.LocalPort2.ToInt());
                }

                var dataSize = ports.First(x => x.TRDPNo == 1 && !x.IsRead).DataSize;
                VarHelperETH.byteSend = new byte[dataSize];
                VarHelperETH.byteSend2 = new byte[dataSize];
                var dataSizeTwo = ports?.FirstOrDefault(x => x.TRDPNo == 2 && !x.IsRead);
                if (dataSizeTwo != null)
                {
                    VarHelperETH.byteSend3 = new byte[dataSizeTwo.DataSize];
                    VarHelperETH.byteSend4 = new byte[dataSizeTwo.DataSize];
                }

                config_CCU = new TRDPMainSend(Config0);
                config_CCU2 = new TRDPMainSend(Config1);

                //配置SMI 数据  该项目无需配置
                //TRDP_CCU.SetSMIting(config_CCU);
                //Thread.Sleep(50);

                //配置主帧数据发送
                TRDP_CCU.SetSetting(config_CCU);
                TRDP_CCU2.SetSetting(config_CCU2);
                Thread.Sleep(50);
                //监听数据返回
                TRDP_CCU.Connect();
                TRDP_CCU.Recieved += new RecievedHandler(trdp_Recieved);
                //生命信号
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
                                VarHelperETH.byteSend[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
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
                                VarHelperETH.byteSend2[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend2[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
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
                                VarHelperETH.byteSend3[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend3[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
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
                                VarHelperETH.byteSend4[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend4[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
                            }
                            else
                            {
                                VarHelperETH.byteSend4[bl] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[0];
                                VarHelperETH.byteSend4[bh] = VarHelperETH.ConvertInt16ToByte(bitnum, Byte.VariableType.ToString())[1];
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
                            if (Byte.PortPattern)
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
                            if (Byte.PortPattern)
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
                            if (Byte.PortPattern)
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
                            if (Byte.PortPattern)
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

        void SendValue(int port, string trdpno, string passage)
        {
            try
            {
                switch (trdpno)
                {
                    case "1":
                        if (passage == "1")
                        {
                            CCU_Send.SequenceCounter++;
                            CCU_Send.DatasetData = VarHelperETH.byteSend;// TRDP_NJCJ.CCU_ALL;
                            CCU_Send.DatasetLength = VarHelperETH.byteSend.Length;// TRDP_NJCJ.CCU_ALL.Length;
                            CCU_Send.DataLength = CCU_Send.DatasetLength + 20;//
                            CCU_Send.ComId = port;
                            TRDP_CCU.SetToTCMS_old(CCU_Send, trdpno, passage);
                        }
                        else
                        {
                            CCU_Send2.SequenceCounter++;
                            CCU_Send2.DatasetData = VarHelperETH.byteSend2;// TRDP_NJCJ.CCU_ALL;
                            CCU_Send2.DatasetLength = VarHelperETH.byteSend2.Length;// TRDP_NJCJ.CCU_ALL.Length;
                            CCU_Send2.DataLength = CCU_Send2.DatasetLength + 20;//
                            CCU_Send2.ComId = port;
                            TRDP_CCU.SetToTCMS_old(CCU_Send2, trdpno, passage);
                        }
                        break;
                    case "2":
                        if (passage == "1")
                        {
                            CCU_Send3.SequenceCounter++;
                            CCU_Send3.DatasetData = VarHelperETH.byteSend3;// TRDP_NJCJ.CCU_ALL;
                            CCU_Send3.DatasetLength = VarHelperETH.byteSend3.Length;// TRDP_NJCJ.CCU_ALL.Length;
                            CCU_Send3.DataLength = CCU_Send3.DatasetLength + 20;//
                            CCU_Send3.ComId = port;
                            TRDP_CCU2.SetToTCMS_old(CCU_Send3, trdpno, passage);
                        }
                        else
                        {
                            CCU_Send4.SequenceCounter++;
                            CCU_Send4.DatasetData = VarHelperETH.byteSend4;// TRDP_NJCJ.CCU_ALL;
                            CCU_Send4.DatasetLength = VarHelperETH.byteSend4.Length;// TRDP_NJCJ.CCU_ALL.Length;
                            CCU_Send4.DataLength = CCU_Send4.DatasetLength + 20;//
                            CCU_Send4.ComId = port;
                            TRDP_CCU2.SetToTCMS_old(CCU_Send4, trdpno, passage);
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
                if (bit.TRDPNo == 1)
                {
                    if (bit.ETHPassage == 1)
                    {
                        DataWrite(ref VarHelperETH.byteSend, bit.Offset, bit.Bit, bit.Switch);
                    }
                    else
                    {
                        DataWrite(ref VarHelperETH.byteSend2, bit.Offset, bit.Bit, bit.Switch);
                    }
                }
                else
                {
                    if (bit.ETHPassage == 1)
                    {
                        DataWrite(ref VarHelperETH.byteSend3, bit.Offset, bit.Bit, bit.Switch);
                    }
                    else
                    {
                        DataWrite(ref VarHelperETH.byteSend4, bit.Offset, bit.Bit, bit.Switch);
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

        readonly List<FullTagsETH> tempLifeTag = [];
        readonly bool closed = false;
        bool IsStarat = false;
        void RegisterLife(IEnumerable<IGrouping<int, Ports>> group)
        {
            tempLifeTag.Clear();
            foreach (var item in group)
            {
                List<Ports> list = [.. item];
                int rata = item.Key;
                List<FullTagsETH> tempNOLifeTag = [];
                foreach (var pt in list)
                {
                    FullTagsETH mode = tags.FirstOrDefault(p => p.COMMData.Port == pt.ETHPortNum && !pt.IsRead && p.Identity);
                    if (mode != null)
                    {
                        mode.TRDPNo = pt.TRDPNo;
                        mode.ETHPassage = pt.ETHPassage;
                        tempLifeTag.Add(mode);//有生命信号端口
                    }
                }

                if (tempLifeTag.Where(x => x.TRDPNo == 1).Any() && !IsStarat)
                {
                    Thread t = new(new ThreadStart(delegate
                    {
                        double value = 0;
                        while (!IsDisposed && !closed)
                        {
                            try
                            {
                                foreach (var tg in tempLifeTag)
                                {
                                    int portIndex = tg.COMMData.Offset;
                                    byte life = (byte)Convert.ToDouble(Comsum(tg.DataType, ref value));
                                    if (tg.ETHPassage == 1)
                                    {
                                        if (!ckbCCU_life.Checked)
                                        {
                                            VarHelperETH.byteSend[portIndex] = life;
                                            SendValue(Convert.ToInt32(tg.Port), tg.TRDPNo.ToString(),
                                                tg.ETHPassage.ToString());
                                        }
                                    }
                                    else
                                    {
                                        if (!ckbCCU_life2.Checked)
                                        {
                                            //byte life = (byte)Convert.ToDouble(Comsum(tg.DataType, ref value));
                                            VarHelperETH.byteSend2[portIndex] = life;
                                            SendValue(Convert.ToInt32(tg.Port), tg.TRDPNo.ToString(),
                                                tg.ETHPassage.ToString());
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine("生命信号写入错误：" + ex.Message);
                                NlogHelper.Default.Error("生命信号写入错误：", ex);
                            }
                            finally
                            {
                                value++;
                                if (value > 255)
                                    value = 0;
                                Thread.Sleep(rata);
                            }
                        }
                    }))
                    {
                        IsBackground = true
                    };
                    t.Start();
                    IsStarat = true;
                }

                if (tempLifeTag.Where(x => x.TRDPNo == 2).Any())
                {
                    Thread t2 = new(new ThreadStart(delegate
                    {
                        double value = 0;
                        while (!IsDisposed && !closed)
                        {
                            try
                            {
                                foreach (var tg in tempLifeTag)
                                {
                                    int portIndex = tg.COMMData.Offset;
                                    byte life = (byte)Convert.ToDouble(Comsum(tg.DataType, ref value));
                                    if (tg.ETHPassage == 1)
                                    {
                                        if (!ckbCCU_life3.Checked)
                                        {
                                            VarHelperETH.byteSend3[portIndex] = life;
                                            SendValue(Convert.ToInt32(tg.Port), tg.TRDPNo.ToString(),
                                               tg.ETHPassage.ToString());
                                        }
                                    }
                                    else
                                    {
                                        if (!ckbCCU_life4.Checked)
                                        {
                                            VarHelperETH.byteSend4[portIndex] = life;
                                            SendValue(Convert.ToInt32(tg.Port), tg.TRDPNo.ToString(),
                                                tg.ETHPassage.ToString());
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine("生命信号写入错误：" + ex.Message);
                            }
                            finally
                            {
                                Thread.Sleep(rata);
                            }
                        }
                    }))
                    {
                        IsBackground = true
                    };
                    t2.Start();
                }
            }
        }
        /// <summary>
        /// 累加
        /// </summary>
        object Comsum(string dataType, ref double value)
        {
            var types = (VariableTypeEnums)Enum.Parse(typeof(VariableTypeEnums), dataType);
            object writeValue = types switch
            {
                VariableTypeEnums.U8 => (byte)value,
                VariableTypeEnums.I8 => (byte)value,
                VariableTypeEnums.U16 => (ushort)value,
                VariableTypeEnums.I16 => (short)value,
                VariableTypeEnums.U32 => (uint)value,
                VariableTypeEnums.I32 => (int)value,
                VariableTypeEnums.U64 => (ulong)value,
                VariableTypeEnums.I64 => (long)value,
                _ => throw new NotImplementedException("系统不支持的数据类型。"),
            };
            return writeValue;
        }
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
                                    ub.Value = VarHelperETH.byteSend[offset];
                                }
                                else if (!ckbCCU_life2.Checked && ub.ETHPassage == 2)
                                {
                                    ub.Value = VarHelperETH.byteSend2[offset];
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
                                    ub.Value = VarHelperETH.byteSend3[offset];
                                }
                                else if (!ckbCCU_life4.Checked && ub.ETHPassage == 2)
                                {
                                    ub.Value = VarHelperETH.byteSend4[offset];
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
