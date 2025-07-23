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
        #region 字段和属性定义
        // 页面分页模型
        private struct PageModelNew
        {
            public int Offset { get; set; }
            public int Length { get; set; }
            public int TotalSize { get; set; }
        }

        private PageModelNew page;
        private bool loaded = false;
        private List<Ports> ports = [];  // 端口集合
        private List<FullTagsETH> tags = []; // 所有设置数据集合
        private Dictionary<COMMData, FullTagsETH> dicItems = []; // 数据模型集合
        private Dictionary<string, FlowLayoutPanel> fullControls = []; // 所有的控制面板缓存
        private readonly Dictionary<int, ucByte> fullIdentity = []; // 存储生命信号标识列
        private readonly List<FullTagsETH> tempLifeTag = []; // 生命信号标签集合
        private TreeView tr;
        private readonly bool closed = false;
        private bool IsStarat = false;

        // 静态数据存储
        public static Dictionary<int, byte[]> ReceiveData = []; // 存储接收数据的ComID
        public static Dictionary<int, byte[]> fullData = []; // 所有待发送的数据

        // 筛选条件
        public bool? ReadOnly { get; set; } // true为宿端口，false为源端口，null为通用

        // TRDP驱动相关
        private TRDPDriver TRDP_CCU; // 网关1
        private TRDPDriver TRDP_CCU2; // 网关2
        private TRDPMainSend config_CCU; // 网关1配置
        private TRDPMainSend config_CCU2; // 网关2配置
        private ToTCMSSend CCU_Send = new(); // 通道1发送对象
        private ToTCMSSend CCU_Send2 = new(); // 通道2发送对象
        private ToTCMSSend CCU_Send3 = new(); // 通道3发送对象
        private ToTCMSSend CCU_Send4 = new(); // 通道4发送对象
        private readonly ETHConfigBLL TRDPName = new();
        private Dictionary<string, string> ps = [];
        private List<TRDPConfig> trdpconfig = [];

        // UI控制相关
        private readonly List<Control> selected = [];
        private readonly List<ucTwoBit> bite2 = [];
        private readonly Dictionary<string, bool> Data = [];
        #endregion

        #region 初始化方法
        public frmTRDPMonitor() => InitializeComponent();

        private void frmTRDPMonitor_Load(object sender, EventArgs e)
        {
            try
            {
                // 初始化界面和数据
                Init();
                // 启动TRDP通讯
                TRDPstart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TRDP通讯失败：" + ex.Message);
            }

            // 启动数据读取定时器
            SystemConfig sys = new();
            System.Windows.Forms.Timer tmrRead = new()
            {
                Interval = sys.MvbDataReadInterval
            };
            tmrRead.Tick += tmrRead_Tick;
            tmrRead.Start();
        }

        /// <summary>
        /// 初始化界面和数据
        /// </summary>
        private new void Init()
        {
            loaded = true;

            // 设置筛选条件UI状态
            if (ReadOnly is null)
                radNone.Checked = true;
            else
            {
                radSource.Checked = !ReadOnly.Value;
                radHost.Checked = ReadOnly.Value;
            }

            // 加载数据并构建界面
            LoadData(ReadOnly);
            LoadLeftTree("");
        }
        #endregion

        #region 数据加载方法
        /// <summary>
        /// 加载端口和标签数据
        /// </summary>
        private void LoadData(bool? readOnly)
        {
            // 清理缓存
            fullControls.Clear();
            GC.Collect();

            // 加载端口数据
            ETHPortsBLL bllPorts = new();
            ports = [.. bllPorts.GetPortsByType(ReadOnly, VarHelper.ModelName)];

            // 加载标签数据
            ETHTagsBLL bllTags = new();
            tags = [.. bllTags.GetAllTags(VarHelper.ModelName).OrderByDescending(x => x.COMMData.Bit)];

            // 初始化数据字典
            ReceiveData.Clear();
            foreach (var item in ports)
            {
                fullData[item.PortNum] = new byte[item.DataSize];
                if (!item.IsRead) // 源端口
                {
                    // 初始化发送数据缓冲区
                }
                else // 宿端口
                {
                    ReceiveData.Add(item.Port.ToInt(), new byte[item.DataSize]);
                }
            }

            // 构建数据项字典
            foreach (var item in tags)
                dicItems[item.COMMData] = item;
        }

        /// <summary>
        /// 加载左侧树状图
        /// </summary>
        private void LoadLeftTree(string searchKey)
        {
            tr = new TreeView();
            PanelTree.Controls.Clear();
            tr.ImageList = imageList1;
            tr.NodeMouseClick += Tr_NodeMouseClick;
            tr.Dock = DockStyle.Fill;

            // 构建端口树节点
            foreach (var item in ports)
            {
                TreeNode node = new()
                {
                    ImageIndex = item.IsRead ? 0 : 1, // 0为宿端口图标，1为源端口图标
                    Text = $"{item.PortName}({item.Port})",
                    Tag = item
                };

                // 应用搜索过滤
                if (!string.IsNullOrEmpty(searchKey) && !node.Text.Contains(searchKey))
                    continue;

                // 应用读写类型过滤
                if (ReadOnly != null && ReadOnly != item.IsRead)
                    continue;

                tr.Nodes.Add(node);
            }

            // 设置默认选中项
            if (PanelContent.Tag == null && ports.Count > 0)
            {
                PanelContent.Tag = tr.Nodes[0].Tag;
                tr.Nodes[0].Checked = true;
            }

            PanelTree.Controls.Add(tr);
            LoadTabs(); // 加载右侧内容
        }

        /// <summary>
        /// 加载右侧标签页内容
        /// </summary>
        private void LoadTabs()
        {
            page.Offset = 0;
            page.Length = 1300;
            UIPanel ctrls = PanelContent;
            ctrls.Controls.Clear();
            GC.Collect();

            LoadPage(page.Offset, page.Length);
        }

        /// <summary>
        /// 加载页面内容（核心方法）
        /// </summary>
        private void LoadPage(int offset, int length)
        {
            try
            {
                // 获取当前选中的端口
                if (!(PanelContent.Tag is Ports item))
                    return;

                // 更新端口信息显示
                Color backColor = Color.FromName(ConfigManager.Layout.ItemColor);
                labPresentPort.Text = $"{item.PortName}({item.Port})，端口周期：{item.Rate}ms";
                string port = item.Port;
                int portNum = item.ETHPortNum;

                // 创建或获取流式布局面板
                FlowLayoutPanel flow = GetOrCreateFlowPanel(item.Port);

                // 获取指定偏移范围内的标签项
                var items = tags.Where(x => x.COMMData.Port == portNum &&
                                           x.COMMData.Offset >= offset * length &&
                                           x.COMMData.Offset < (offset + 1) * length)
                               .OrderBy(x => x.COMMData.Offset)
                               .OrderBy(x => x.COMMData.Bit)
                               .ToList();

                if (items.Count == 0) return;

                int minOffset = items.Min(x => x.COMMData.Offset);
                int maxOffset = items.Max(x => x.COMMData.Offset);
                Padding p = new(1, ConfigManager.Layout.LineSpace, 1, ConfigManager.Layout.LineSpace);
                int lastType = 0; // 用于控制布局截断

                // 遍历字节偏移量构建控件
                for (int i = minOffset; i <= maxOffset; i++)
                {
                    var byteItems = items.Where(x => x.COMMData.Offset == i).ToList();

                    foreach (var tag in byteItems)
                    {
                        Control control = CreateControlForTag(tag, item, p, backColor);
                        if (control != null)
                        {
                            // 处理布局截断
                            if (ShouldBreakLayout(lastType, tag.DataType))
                            {
                                flow.SetFlowBreak(flow.Controls[flow.Controls.Count - 1], true);
                            }

                            flow.Controls.Add(control);
                            lastType = GetControlType(tag.DataType);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("加载右侧内容：" + ex.Message);
                MessageHelper.UIMessageOK("加载右侧内容：" + ex.Message);
            }
        }

        /// <summary>
        /// 获取或创建流式布局面板
        /// </summary>
        private FlowLayoutPanel GetOrCreateFlowPanel(string controlsKey)
        {
            if (fullControls.TryGetValue(controlsKey, out FlowLayoutPanel existingFlow))
            {
                PanelContent.Controls.Clear();
                PanelContent.Controls.Add(existingFlow);
                return existingFlow;
            }

            // 创建新的流式布局面板
            FlowLayoutPanel flow = new()
            {
                Padding = new Padding(5),
                Size = PanelContent.Size,
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = ConfigManager.Layout.RightToLeft ?
                    FlowDirection.RightToLeft : FlowDirection.LeftToRight
            };

            PanelContent.Controls.Add(flow);
            fullControls[controlsKey] = flow;
            return flow;
        }

        /// <summary>
        /// 为标签创建对应的控件
        /// </summary>
        private Control CreateControlForTag(FullTagsETH tag, Ports port, Padding padding, Color backColor)
        {
            if (tag.DataType.Contains('B')) // 位控制
            {
                return CreateBitControl(tag, port, padding, backColor);
            }
            else // 字节控制
            {
                return CreateByteControl(tag, port, padding, backColor);
            }
        }

        /// <summary>
        /// 创建位控制控件
        /// </summary>
        private Control CreateBitControl(FullTagsETH tag, Ports port, Padding padding, Color backColor)
        {
            Size s = ConfigManager.Layout.BitCount == 8 ? new(138, 65) : new(100, 60);

            if (tag.DataType == "B1")
            {
                ucBit bit = new()
                {
                    BackColor = backColor,
                    Size = s,
                    Margin = padding,
                    Text = tag.DataLabel,
                    Port = tag.COMMData.Port,
                    Offset = tag.COMMData.Offset,
                    Bit = tag.COMMData.Bit,
                    TRDPNo = port.TRDPNo,
                    ETHPassage = port.ETHPassage,
                    ReadOnly = port.IsRead,
                    DataRange = tag.PortPattern
                };
                bit.Click += bit_Click;
                return bit;
            }
            else // 组合位控制
            {
                ucTwoBit bit = new()
                {
                    BackColor = backColor,
                    Size = s,
                    Margin = padding,
                    Text = tag.DataLabel,
                    Port = tag.COMMData.Port,
                    Offset = tag.COMMData.Offset,
                    Bit = tag.COMMData.GroupETHBit,
                    TRDPNo = port.TRDPNo,
                    ETHPassage = port.ETHPassage,
                    Description = tag.Description,
                    ReadOnly = port.IsRead,
                    DataRange = tag.PortPattern
                };
                bit.Click += bit2_Click;
                bit.AddToolTop(toolTip1, bit.Description);
                return bit;
            }
        }

        /// <summary>
        /// 创建字节控制控件
        /// </summary>
        private Control CreateByteControl(FullTagsETH tag, Ports port, Padding padding, Color backColor)
        {
            ucByte ub = new()
            {
                Size = new Size(238, 60),
                Margin = padding,
                Text = tag.DataLabel,
                Port = tag.COMMData.Port,
                ReadOnly = port.IsRead,
                Offset = tag.COMMData.Offset,
                Bit = tag.COMMData.Bit,
                TRDPNo = port.TRDPNo,
                ETHPassage = port.ETHPassage,
                Unit = tag.DataUnit,
                IsSensorRange = tag.IsSensorRange,
                PortPattern = tag.PortPattern,
                BitValue = tag.BitValue,
                VariableType = (VariableTypeEnums)Enum.Parse(typeof(VariableTypeEnums), tag.DataType),
                BackColor = backColor
            };
            ub.Submits += ub_Submits;

            // 如果是生命信号，禁用编辑
            if (tag.Identity)
            {
                ub.Enabled = false;
                fullIdentity[port.ETHPortNum] = ub;
            }

            return ub;
        }

        /// <summary>
        /// 判断是否需要布局截断
        /// </summary>
        private static bool ShouldBreakLayout(int lastType, string dataType)
        {
            if (!ConfigManager.Layout.Cut || lastType == 0) return false;

            int currentType = GetControlType(dataType);
            return lastType != currentType;
        }

        /// <summary>
        /// 获取控件类型（用于布局）
        /// </summary>
        private static int GetControlType(string dataType)
        {
            return dataType.Contains('B') ? 2 : 1; // 2为位控制，1为字节控制
        }
        #endregion

        #region 事件处理方法
        /// <summary>
        /// 树节点点击事件
        /// </summary>
        private void Tr_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            PanelContent.Tag = node.Tag;
            LoadTabs();
        }

        /// <summary>
        /// 位控制点击事件
        /// </summary>
        private void bit_Click(object sender, EventArgs e)
        {
            if (!(sender is ucBit bit)) return;

            Debug.WriteLine($"位写入: {bit.Text}, {bit.Offset}.{bit.Bit}: {bit.Switch}");

            try
            {
                // 根据网关和通道选择对应的数据缓冲区
                if (bit.TRDPNo == 1)
                {
                    if (bit.ETHPassage == 1)
                        DataWrite(ref VarHelperETH.byteSend, bit.Offset, bit.Bit, bit.Switch);
                    else
                        DataWrite(ref VarHelperETH.byteSend2, bit.Offset, bit.Bit, bit.Switch);
                }
                else
                {
                    if (bit.ETHPassage == 1)
                        DataWrite(ref VarHelperETH.byteSend3, bit.Offset, bit.Bit, bit.Switch);
                    else
                        DataWrite(ref VarHelperETH.byteSend4, bit.Offset, bit.Bit, bit.Switch);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据写入失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 组合位控制点击事件
        /// </summary>
        private void bit2_Click(object sender, EventArgs e)
        {
            if (!(sender is ucTwoBit bit)) return;

            bite2.Clear();
            FrmBite bi = new(bit);

            // 设置位状态
            bitStatus(bit.Bit, bi, false);
            bi.ShowDialog();
            bitStatus(bit.Bit, bi, true);

            bite2.Add(bit);
            bit.Switch = bi.checkValue.Where(x => x).Any();

            try
            {
                var keys = VarHelper.GetValue(bit.Bit);

                // 根据网关选择对应的数据缓冲区
                if (bit.TRDPNo == 1)
                {
                    DataWriteTwoBite(ref VarHelperETH.byteSend, bit.Offset, bi.checkValue, keys);
                }
                else
                {
                    DataWriteTwoBite(ref VarHelperETH.byteSend2, bit.Offset, bi.checkValue, keys);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据写入失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 字节控制提交事件
        /// </summary>
        private void ub_Submits(object sender, double value)
        {
            if (!(sender is ucByte byteControl)) return;

            try
            {
                double fvalue = byteControl.Value;
                int bitnum = (int)(fvalue / byteControl.BitValue);

                // 根据数据类型和网关通道写入对应的数据
                WriteByteValue(byteControl, bitnum);
                SendValue(byteControl.Port, byteControl.TRDPNo.ToString(), byteControl.ETHPassage.ToString());
            }
            catch (Exception ex)
            {
                LogHelper.WriteLine(ex.Message);
                MessageBox.Show("输入数值格式不正确！" + ex.Message);
            }
        }

        /// <summary>
        /// 筛选条件改变事件
        /// </summary>
        private void radSource_CheckedChanged(object sender, EventArgs e)
        {
            if (!loaded) return;
            ReadOnly = false;
            PanelContent.Tag = null;
            LoadLeftTree("");
        }

        private void radHost_CheckedChanged(object sender, EventArgs e)
        {
            if (!loaded) return;
            ReadOnly = true;
            PanelContent.Tag = null;
            LoadLeftTree("");
        }

        private void radNone_CheckedChanged(object sender, EventArgs e)
        {
            if (!loaded) return;
            ReadOnly = null;
            PanelContent.Tag = null;
            LoadLeftTree("");
        }

        /// <summary>
        /// 数据读取定时器事件
        /// </summary>
        private void tmrRead_Tick(object sender, EventArgs e)
        {
            if (closed || PanelContent.Controls.Count == 0) return;

            // 遍历控件更新数据显示
            foreach (Control item in PanelContent.Controls[0].Controls)
            {
                if (item is ucBit bit && bit.ReadOnly)
                {
                    UpdateBitValue(bit);
                }
                else if (item is ucByte byteCtrl && byteCtrl.ReadOnly)
                {
                    UpdateByteValue(byteCtrl);
                }
            }
        }

        /// <summary>
        /// 关闭按钮事件
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// 搜索功能
        /// </summary>
        private void btnGoto_Click(object sender, EventArgs e)
        {
            SelectPanlControl(txtKey.Text);
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            LoadLeftTree(txtPortName.Text.Trim());
        }
        #endregion

        #region 数据操作辅助方法
        /// <summary>
        /// 写入字节数据
        /// </summary>
        private void WriteByteValue(ucByte byteControl, int bitnum)
        {
            byte[] targetBuffer = GetTargetBuffer(byteControl.TRDPNo, byteControl.ETHPassage);

            switch (byteControl.VariableType.ToString())
            {
                case "U8":
                    byte value = byteControl.PortPattern ?
                        SwapByteBits(VarHelperETH.ConvertInt8ToByte(bitnum)) :
                        VarHelperETH.ConvertInt8ToByte(bitnum);
                    targetBuffer[byteControl.Offset] = value;
                    break;

                case "U16":
                    WriteU16Value(targetBuffer, byteControl, bitnum);
                    break;

                case "U32":
                    WriteU32Value(targetBuffer, byteControl, bitnum);
                    break;
            }
        }

        /// <summary>
        /// 获取目标数据缓冲区
        /// </summary>
        private static byte[] GetTargetBuffer(int trdpNo, int ethPassage)
        {
            return trdpNo == 1 ?
                (ethPassage == 1 ? VarHelperETH.byteSend : VarHelperETH.byteSend2) :
                (ethPassage == 1 ? VarHelperETH.byteSend3 : VarHelperETH.byteSend4);
        }

        /// <summary>
        /// 写入16位数据
        /// </summary>
        private static void WriteU16Value(byte[] buffer, ucByte byteControl, int bitnum)
        {
            byte bh = (byte)byteControl.Offset;
            byte bl = (byte)(byteControl.Offset + 1);
            byte[] data = VarHelperETH.ConvertInt16ToByte(bitnum, byteControl.VariableType.ToString());

            if (byteControl.PortPattern)
            {
                buffer[bh] = data[0];
                buffer[bl] = data[1];
            }
            else
            {
                buffer[bl] = data[0];
                buffer[bh] = data[1];
            }
        }

        /// <summary>
        /// 写入32位数据
        /// </summary>
        private static void WriteU32Value(byte[] buffer, ucByte byteControl, int bitnum)
        {
            byte[] data = VarHelperETH.ConvertInt32ToByte(bitnum, byteControl.VariableType.ToString());
            byte hh = (byte)byteControl.Offset;
            byte bh = (byte)(byteControl.Offset + 1);
            byte ll = (byte)(byteControl.Offset + 2);
            byte bl = (byte)(byteControl.Offset + 3);

            if (byteControl.PortPattern)
            {
                buffer[hh] = data[0];
                buffer[bh] = data[1];
                buffer[ll] = data[2];
                buffer[bl] = data[3];
            }
            else
            {
                buffer[hh] = data[3];
                buffer[bh] = data[2];
                buffer[ll] = data[1];
                buffer[bl] = data[0];
            }
        }

        /// <summary>
        /// 更新位控制值
        /// </summary>
        private static void UpdateBitValue(ucBit bit)
        {
            int Port = bit.Port;
            int offset = bit.Offset;
            int bits = bit.Bit;

            if (!ReceiveData.ContainsKey(Port)) return;

            int bitValue = 1 << bits;
            bool b = (ReceiveData[Port][offset] & bitValue) == bitValue;
            if (b != bit.Switch)
                bit.Switch = b;
        }

        /// <summary>
        /// 更新字节控制值
        /// </summary>
        private void UpdateByteValue(ucByte ub)
        {
            int Port = ub.Port;
            int offset = ub.Offset;

            // 检查是否为生命信号
            foreach (var tg in tempLifeTag)
            {
                if (offset == tg.COMMData.Offset && IsLifeSignalControl(ub, tg))
                {
                    UpdateLifeSignalValue(ub, tg);
                    return;
                }
            }

            if (!ub.ReadOnly || !ReceiveData.ContainsKey(Port)) return;

            // 计算并更新数值
            decimal value = CalculateValueFromBytes(ub, ReceiveData[Port]);
            if ((decimal)ub.Value != value)
                ub.Value = (double)value * ub.BitValue;
        }

        /// <summary>
        /// 从字节数组计算数值
        /// </summary>
        private static decimal CalculateValueFromBytes(ucByte ub, byte[] data)
        {
            int offset = ub.Offset;
            int bits = ub.Bit;

            return ub.VariableType switch
            {
                VariableTypeEnums.U3 => data[offset] >> bits & 7,
                VariableTypeEnums.U5 => data[offset] >> bits & 0x1F,
                VariableTypeEnums.U8 => data[offset + ub.Bit] >> bits,
                VariableTypeEnums.I8 => data[offset] >> bits,
                VariableTypeEnums.U16 or VariableTypeEnums.I16 =>
                    CalculateU16Value(data, offset, bits, ub.PortPattern),
                VariableTypeEnums.U32 or VariableTypeEnums.I32 =>
                    CalculateU32Value(data, offset, bits, ub.PortPattern),
                VariableTypeEnums.U64 or VariableTypeEnums.I64 =>
                    CalculateU64Value(data, offset, bits, ub.PortPattern),
                _ => 0
            };
        }

        /// <summary>
        /// 发送数据到TRDP
        /// </summary>
        private void SendValue(int port, string trdpno, string passage)
        {
            try
            {
                switch (trdpno)
                {
                    case "1":
                        SendToTRDP1(port, passage);
                        break;
                    case "2":
                        SendToTRDP2(port, passage);
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                NlogHelper.Default.Error("SendValue错误：", ex);
            }
        }
        #endregion

        #region TRDP通讯相关方法
        /// <summary>
        /// 启动TRDP通讯
        /// </summary>
        public void TRDPstart()
        {
            try
            {
                // 清理配置
                ps.Clear();
                ZZCTRDPConfig trdpconfig = new();
                ps = TRDPName.GetDate(VarHelper.ModelName);
                DataTable dt = TRDPName.GetAllPorts(VarHelper.ModelName);
                this.trdpconfig = DataTableToList<TRDPConfig>(dt);

                // 创建发送对象
                string Config0 = ps.FirstOrDefault().Value + 0;
                string Config1 = ps.FirstOrDefault().Value + 1;
                CCU_Send = new(Config0);
                CCU_Send2 = new(Config1);

                // 初始化TRDP驱动
                InitializeTRDPDrivers();

                // 初始化数据缓冲区
                InitializeDataBuffers();

                // 配置并连接TRDP
                ConfigureAndConnectTRDP();

                // 注册生命信号
                RegisterLifeSignals();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("TRDP初始化失败：" + ex.Message);
                NlogHelper.Default.Error("TRDP初始化失败：", ex);
            }
        }

        /// <summary>
        /// 初始化TRDP驱动
        /// </summary>
        private void InitializeTRDPDrivers()
        {
            if (TRDP_CCU == null)
            {
                TRDP_CCU = new TRDPDriver();
                TRDP_CCU.Init(trdpconfig.DesIP1, trdpconfig.Desport1.ToInt(),
                             trdpconfig.LocalIP1, trdpconfig.LocalPort1.ToInt());
            }

            if (TRDP_CCU2 == null)
            {
                TRDP_CCU2 = new TRDPDriver();
                TRDP_CCU2.Init(trdpconfig.DesIP2, trdpconfig.Desport2.ToInt(),
                              trdpconfig.LocalIP2, trdpconfig.LocalPort2.ToInt());
            }
        }

        /// <summary>
        /// 初始化数据缓冲区
        /// </summary>
        private void InitializeDataBuffers()
        {
            // 初始化网关1的数据缓冲区
            var dataSize = ports.First(x => x.TRDPNo == 1 && !x.IsRead).DataSize;
            VarHelperETH.byteSend = new byte[dataSize];
            VarHelperETH.byteSend2 = new byte[dataSize];

            // 初始化网关2的数据缓冲区（如果存在）
            var dataSizeTwo = ports?.FirstOrDefault(x => x.TRDPNo == 2 && !x.IsRead);
            if (dataSizeTwo != null)
            {
                VarHelperETH.byteSend3 = new byte[dataSizeTwo.DataSize];
                VarHelperETH.byteSend4 = new byte[dataSizeTwo.DataSize];
            }
        }

        /// <summary>
        /// 配置并连接TRDP
        /// </summary>
        private void ConfigureAndConnectTRDP()
        {
            string Config0 = ps.FirstOrDefault().Value + 0;
            string Config1 = ps.FirstOrDefault().Value + 1;

            // 创建配置对象
            config_CCU = new TRDPMainSend(Config0);
            config_CCU2 = new TRDPMainSend(Config1);

            // 发送配置到TRDP模块
            TRDP_CCU.SetSetting(config_CCU);
            TRDP_CCU2.SetSetting(config_CCU2);
            Thread.Sleep(50);

            // 建立连接并注册接收事件
            TRDP_CCU.Connect();
            TRDP_CCU.Recieved += trdp_Recieved;
        }

        /// <summary>
        /// TRDP数据接收处理
        /// </summary>
        private void trdp_Recieved(object sender, TRDPCommandTypes commandType, BaseRecieveModel recieved)
        {
            // 只处理从TCMS接收的数据
            if (commandType == TRDPCommandTypes.RecieveTCMS0 || commandType == TRDPCommandTypes.RecieveTCMS1)
            {
                FromTCMSRecieve tcms = recieved as FromTCMSRecieve;
                if (ReceiveData.ContainsKey(tcms.ComId))
                    ReceiveData[tcms.ComId] = tcms.DatasetData;
            }
        }

        /// <summary>
        /// 注册生命信号
        /// </summary>
        private void RegisterLifeSignals()
        {
            var pt = ports.GroupBy(p => p.Rate);
            if (ports == null) return;

            tempLifeTag.Clear();

            // 查找所有生命信号标签
            foreach (var item in pt)
            {
                List<Ports> list = [.. item];
                foreach (var pt_item in list)
                {
                    FullTagsETH mode = tags.FirstOrDefault(p => p.COMMData.Port == pt_item.ETHPortNum &&
                                                              !pt_item.IsRead && p.Identity);
                    if (mode != null)
                    {
                        mode.TRDPNo = pt_item.TRDPNo;
                        mode.ETHPassage = pt_item.ETHPassage;
                        tempLifeTag.Add(mode);
                    }
                }

                // 启动生命信号线程
                StartLifeSignalThreads(item.Key);
            }
        }

        /// <summary>
        /// 启动生命信号线程
        /// </summary>
        private void StartLifeSignalThreads(int rate)
        {
            // 网关1生命信号线程
            if (tempLifeTag.Where(x => x.TRDPNo == 1).Any() && !IsStarat)
            {
                StartLifeSignalThread(1, rate);
                IsStarat = true;
            }

            // 网关2生命信号线程
            if (tempLifeTag.Where(x => x.TRDPNo == 2).Any())
            {
                StartLifeSignalThread(2, rate);
            }
        }

        /// <summary>
        /// 启动指定网关的生命信号线程
        /// </summary>
        private void StartLifeSignalThread(int trdpNo, int rate)
        {
            Thread t = new(new ThreadStart(delegate
            {
                double value = 0;
                while (!IsDisposed && !closed)
                {
                    try
                    {
                        foreach (var tg in tempLifeTag.Where(x => x.TRDPNo == trdpNo))
                        {
                            int portIndex = tg.COMMData.Offset;
                            byte life = (byte)Convert.ToDouble(Comsum(tg.DataType, ref value));

                            // 根据通道和复选框状态发送生命信号
                            if (ShouldSendLifeSignal(trdpNo, tg.ETHPassage))
                            {
                                byte[] targetBuffer = GetLifeSignalBuffer(trdpNo, tg.ETHPassage);
                                targetBuffer[portIndex] = life;
                                SendValue(Convert.ToInt32(tg.Port), tg.TRDPNo.ToString(),
                                         tg.ETHPassage.ToString());
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
                        if (value > 255) value = 0;
                        Thread.Sleep(rate);
                    }
                }
            }))
            {
                IsBackground = true
            };
            t.Start();
        }

        /// <summary>
        /// 判断是否应该发送生命信号
        /// </summary>
        private bool ShouldSendLifeSignal(int trdpNo, int ethPassage)
        {
            return trdpNo switch
            {
                1 => ethPassage == 1 ? !ckbCCU_life.Checked : !ckbCCU_life2.Checked,
                2 => ethPassage == 1 ? !ckbCCU_life3.Checked : !ckbCCU_life4.Checked,
                _ => false
            };
        }

        /// <summary>
        /// 获取生命信号缓冲区
        /// </summary>
        private static byte[] GetLifeSignalBuffer(int trdpNo, int ethPassage)
        {
            return trdpNo == 1 ?
                (ethPassage == 1 ? VarHelperETH.byteSend : VarHelperETH.byteSend2) :
                (ethPassage == 1 ? VarHelperETH.byteSend3 : VarHelperETH.byteSend4);
        }

        /// <summary>
        /// 发送数据到网关1
        /// </summary>
        private void SendToTRDP1(int port, string passage)
        {
            if (passage == "1")
            {
                CCU_Send.SequenceCounter++;
                CCU_Send.DatasetData = VarHelperETH.byteSend;
                CCU_Send.DatasetLength = VarHelperETH.byteSend.Length;
                CCU_Send.DataLength = CCU_Send.DatasetLength + 20;
                CCU_Send.ComId = port;
                TRDP_CCU.SetToTCMS_old(CCU_Send, "1", passage);
            }
            else
            {
                CCU_Send2.SequenceCounter++;
                CCU_Send2.DatasetData = VarHelperETH.byteSend2;
                CCU_Send2.DatasetLength = VarHelperETH.byteSend2.Length;
                CCU_Send2.DataLength = CCU_Send2.DatasetLength + 20;
                CCU_Send2.ComId = port;
                TRDP_CCU.SetToTCMS_old(CCU_Send2, "1", passage);
            }
        }

        /// <summary>
        /// 发送数据到网关2
        /// </summary>
        private void SendToTRDP2(int port, string passage)
        {
            if (passage == "1")
            {
                CCU_Send3.SequenceCounter++;
                CCU_Send3.DatasetData = VarHelperETH.byteSend3;
                CCU_Send3.DatasetLength = VarHelperETH.byteSend3.Length;
                CCU_Send3.DataLength = CCU_Send3.DatasetLength + 20;
                CCU_Send3.ComId = port;
                TRDP_CCU2.SetToTCMS_old(CCU_Send3, "2", passage);
            }
            else
            {
                CCU_Send4.SequenceCounter++;
                CCU_Send4.DatasetData = VarHelperETH.byteSend4;
                CCU_Send4.DatasetLength = VarHelperETH.byteSend4.Length;
                CCU_Send4.DataLength = CCU_Send4.DatasetLength + 20;
                CCU_Send4.ComId = port;
                TRDP_CCU2.SetToTCMS_old(CCU_Send4, "2", passage);
            }
        }
        #endregion

        #region 数据处理辅助方法
        /// <summary>
        /// 累加计算（用于生命信号）
        /// </summary>
        private static object Comsum(string dataType, ref double value)
        {
            var types = (VariableTypeEnums)Enum.Parse(typeof(VariableTypeEnums), dataType);
            return types switch
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
        }

        /// <summary>
        /// 字节前4位与高4位互换
        /// </summary>
        private static byte SwapByteBits(byte b)
        {
            return (byte)(((b >> 4) & 0x0F) | ((b << 4) & 0xF0));
        }

        /// <summary>
        /// 数据写入通用方法
        /// </summary>
        private static void DataWrite(ref byte[] by, int Offset, int bitSrc, object value)
        {
            switch (value.GetType().Name)
            {
                case "Boolean":
                    ConvertBoolToByte(ref by, Offset, bitSrc, (bool)value);
                    break;

                default:
                    byte[] bts = ConvertValueToBytes(value);
                    if (bts != null)
                    {
                        byte[] w = bts.Reverse().ToArray();
                        Array.Copy(w, 0, by, Offset, w.Length);
                    }
                    break;
            }
        }

        /// <summary>
        /// 将值转换为字节数组
        /// </summary>
        private static byte[] ConvertValueToBytes(object value)
        {
            return value.GetType().Name switch
            {
                "Byte" => [Convert.ToByte(value)],
                "Int16" => BitConverter.GetBytes(Convert.ToInt16(value)),
                "UInt16" => BitConverter.GetBytes(Convert.ToUInt16(value)),
                "Int32" => BitConverter.GetBytes(Convert.ToInt32(value)),
                "UInt32" => BitConverter.GetBytes(Convert.ToUInt32(value)),
                "Int64" => BitConverter.GetBytes(Convert.ToInt64(value)),
                "UInt64" => BitConverter.GetBytes(Convert.ToUInt64(value)),
                "Single" => BitConverter.GetBytes(Convert.ToSingle(value)),
                "Double" => BitConverter.GetBytes(Convert.ToDouble(value)),
                _ => null
            };
        }

        /// <summary>
        /// 布尔值转字节
        /// </summary>
        private static void ConvertBoolToByte(ref byte[] sendbyte, int byteIndex, int bitIndex, bool value)
        {
            byte bytevalue = sendbyte[byteIndex];
            bool[] barr = DataConversionClass.conversion2(bytevalue);
            barr[bitIndex] = value;
            bytevalue = (byte)DataConversionClass.conversion10(barr[0], barr[1], barr[2], barr[3],
                                                               barr[4], barr[5], barr[6], barr[7]);
            sendbyte[byteIndex] = bytevalue;
        }

        /// <summary>
        /// 组合位数据写入
        /// </summary>
        private static void DataWriteTwoBite(ref byte[] by, int Offset, bool[] value, params string[] funcs)
        {
            ConvertBoolToTwoByte(ref by, Offset, value, funcs);
        }

        /// <summary>
        /// 组合位布尔值转字节
        /// </summary>
        private static void ConvertBoolToTwoByte(ref byte[] sendbyte, int byteIndex, bool[] value, params string[] funcs)
        {
            byte bytevalue = sendbyte[byteIndex];
            for (int i = 0; i < funcs.Length; i++)
            {
                int index = funcs[i].ToInt();
                bool[] barr = DataConversionClass.conversion2(bytevalue);
                barr[index] = value[index];
                bytevalue = (byte)DataConversionClass.conversion10(barr[0], barr[1], barr[2], barr[3],
                                                                   barr[4], barr[5], barr[6], barr[7]);
            }
            sendbyte[byteIndex] = bytevalue;
        }

        /// <summary>
        /// 位状态处理
        /// </summary>
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

        /// <summary>
        /// 计算16位数值
        /// </summary>
        private static decimal CalculateU16Value(byte[] data, int offset, int bits, bool portPattern)
        {
            byte[] temp = new byte[2];
            Array.Copy(data, offset, temp, bits, temp.Length);
            return portPattern ?
                BitConverter.ToUInt16(temp.Reverse().ToArray(), 0) :
                BitConverter.ToUInt16(temp, 0);
        }

        /// <summary>
        /// 计算32位数值
        /// </summary>
        private static decimal CalculateU32Value(byte[] data, int offset, int bits, bool portPattern)
        {
            byte[] temp = new byte[4];
            Array.Copy(data, offset, temp, bits, temp.Length);
            return portPattern ?
                BitConverter.ToUInt32(temp.Reverse().ToArray(), 0) :
                BitConverter.ToUInt32(temp, 0);
        }

        /// <summary>
        /// 计算64位数值
        /// </summary>
        private static decimal CalculateU64Value(byte[] data, int offset, int bits, bool portPattern)
        {
            byte[] temp = new byte[8];
            Array.Copy(data, offset, temp, bits, temp.Length);
            return portPattern ?
                BitConverter.ToUInt64(temp.Reverse().ToArray(), 0) :
                BitConverter.ToUInt64(temp, 0);
        }

        /// <summary>
        /// 判断是否为生命信号控件
        /// </summary>
        private static bool IsLifeSignalControl(ucByte ub, FullTagsETH tg)
        {
            return (ub.TRDPNo == tg.TRDPNo && ub.ETHPassage == tg.ETHPassage);
        }

        /// <summary>
        /// 更新生命信号值
        /// </summary>
        private void UpdateLifeSignalValue(ucByte ub, FullTagsETH tg)
        {
            byte[] sourceBuffer = GetLifeSignalBuffer(tg.TRDPNo, tg.ETHPassage);
            bool shouldUpdate = ShouldSendLifeSignal(tg.TRDPNo, tg.ETHPassage);

            if (shouldUpdate)
                ub.Value = sourceBuffer[ub.Offset];
        }

        /// <summary>
        /// DataTable转List
        /// </summary>
        private static List<T> DataTableToList<T>(DataTable dt) where T : new()
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
        #endregion

        #region UI辅助方法
        /// <summary>
        /// 清除选择
        /// </summary>
        private void clearSelect()
        {
            foreach (var item in selected)
            {
                item.BackColor = Color.FromName(ConfigManager.Layout.ItemColor);
            }
            selected.Clear();
        }

        /// <summary>
        /// 选择面板控件
        /// </summary>
        private void SelectPanlControl(string text)
        {
            clearSelect();
            if (string.IsNullOrEmpty(text)) return;

            bool exists = false;

            // 搜索匹配的控件
            foreach (Control label in PanelContent.Controls[0].Controls)
            {
                string controlText = "";
                if (label is ucByte ub)
                    controlText = ub.Text;
                else if (label is ucBit bit)
                    controlText = bit.Text;
                else if (label is ucTwoBit twoBit)
                    controlText = twoBit.Text;

                if (controlText.Contains(text))
                {
                    selected.Add(label);
                    label.BackColor = Color.Yellow;
                    exists = true;
                }
            }

            if (!exists)
                MessageBox.Show("没有检索到任何值。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}