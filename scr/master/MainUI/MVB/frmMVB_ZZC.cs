using Newtonsoft.Json;
using RW.Driver;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace MainUI.MVB
{
    /// <summary>
    /// ZZC MVB自动生成界面
    /// </summary>
    public partial class frmMVB_ZZC : Form//: RWFormBase
    {
        public frmMVB_ZZC()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        System.Windows.Forms.Timer tmrRead = new System.Windows.Forms.Timer();

        IDriver driver = null;
        SystemConfig sys = new SystemConfig();
        // MVBDriver_ZZC mvb = new MVBDriver_ZZC();

        bool closed = false;

        public bool? ReadOnly { get; set; }//true为宿端口，false为源端口，null为通用，

        bool loaded = false;
        bool init = false;

        public void Init()
        {
            page.Offset = 0;
            page.Length = 32;

            if (ReadOnly == null)
            {
                radNone.Checked = ReadOnly == null;
            }
            else
            {
                radSource.Checked = !ReadOnly.Value;
                radHost.Checked = ReadOnly.Value;
            }

            loaded = true;

            try
            {
                LoadData(ReadOnly);
                LoadLeftTree("");

                //driver = mvb;
                //mvb.Connected += new EventHandler(driver_Connected);
                //mvb.Ports = ports;
                //mvb.Connect();
                //mvb.PortValueChanged += new PortValueHandler(mvb_PortValueChanged);
                ///生命信号
                var pt = ports.GroupBy(p => p.Rate);
                if (ports == null) return;
                RegisterLife(pt);

                MVBDriverZZC_Zhu.MVB.ports = ports;

                MVBDriverZZC_Zhu.MVB.fullData = fullData;

                MVBDriverZZC_Zhu.MVB.SendMVBchanged += MVB_SendMVBchanged;
            }
            catch (Exception ex)
            {
                init = false;
                MessageBox.Show("初始化错误：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            init = true;
        }

        public delegate void Del();
        private void MVB_SendMVBchanged(ushort obj)
        {
            try
            {
                Invoke(new Del(delegate
                   {
                       lblSendHeartbeat.Text = "发送数据心跳：" + obj.ToString();
                   }));
            }
            catch (Exception ex)
            {
                string err = "刷新发送状态有误；原因：" + ex.Message;
                Debug.WriteLine(err);
            }

        }

        void driver_Connected(object sender, EventArgs e)
        {
            this.swiLedMVBComm.Switch = true;
            //throw new NotImplementedException();
        }

        System.Windows.Forms.Timer timeMVBstatus = new System.Windows.Forms.Timer();

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Init();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("MVB通讯失败：" + ex.Message);
            //}


            tmrRead.Interval = sys.MvbDataReadInterval;
            tmrRead.Tick += new EventHandler(tmrRead_Tick);
            tmrRead.Start();

            timeMVBstatus.Interval = 1000;
            timeMVBstatus.Tick += TimeMVBstatus_Tick;
            timeMVBstatus.Enabled = true;
            timeMVBstatus.Start();
        }

        private void TimeMVBstatus_Tick(object sender, EventArgs e)
        {
            try
            {
                swiLedMVBComm.Switch = MVBDriverZZC_Zhu.MVB.MVBConfigure;
                lblMVBCardStatusStr.Text = MVBDriverZZC_Zhu.MVB.MVBConfigure ? "通讯成功" : "通讯失败";

            }
            catch (Exception)
            {

            }
        }

        void mvb_PortValueChanged(int port, byte[] data)
        {
            fullData[port] = data;
            //todo:可以使用数据改变的事件模式 增加
        }

        public void GetMvbData()
        {
            try
            {
                Ports p = PanelContent.Tag as Ports;
                int leg = fullData[p.PortNum].Length;
                byte[] data = new byte[leg];
                int portIndex = MvbDllCall.GetPortIndex(p.PortNum);
                int leg1 = MvbDllCall.GetPortSize(p.PortNum);
                for (int i = 0; i < leg; i++)
                {
                    if (p.IsRead)
                        data[i] = MvbDllCall.readbyte[portIndex, i];
                    else
                        data[i] = MvbDllCall.sendbyte[portIndex, i];
                }
                fullData[p.PortNum] = data;
            }
            catch (Exception)
            {

            }
        }

        void tmrRead_Tick(object sender, EventArgs e)
        {
            try
            {
                if (closed) tmrRead.Stop();

                GetMvbData();

                Stopwatch timeWatch = new Stopwatch();
                timeWatch.Start();

                Ports p = PanelContent.Tag as Ports;
                byte[] data;

                data = fullData[p.PortNum];

                Stopwatch watch = new Stopwatch();
                watch.Start();
                //Debug.WriteLine("start:" + watch.Elapsed.ToString());
                if (PanelContent.Controls.Count == 0)
                    return;


                foreach (var item in this.PanelContent.Controls[0].Controls)//变量到所有的控件
                {
                    if (item is ucBit)
                    {
                        ucBit bit = item as ucBit;
                        int offset = bit.Offset;//ConvertBit(bit.Offset, bit.Bit)[0];
                        int bits = ConvertBit(bit.Offset, bit.Bit)[1];

                        int bitValue = 1 << bits;

                        bool b = (data[offset] & bitValue) == bitValue;
                        if (b == bit.Switch) continue;

                        bit.Switch = b;

                    }
                    else if (item is ucByte)
                    {
                        ucByte ub = item as ucByte;
                        //ub.Offset = ub.Offset * 2 + ub.Bit / 8;
                        // ub.Bit = ub.Bit % 8;
                        decimal value = 0M;
                        byte[] temp = null;
                        //int bits = ub.Offset;
                        //int offset = ConvertBit(ub.Offset, ub.Bit)[0];
                        int bits = ConvertBit(ub.Offset, ub.Bit)[1];
                        int offset = ub.Offset;
                        switch (ub.VariableType)
                        {
                            case VariableTypeEnums.U3:
                                value = data[offset] >> bits & 7;
                                break;
                            case VariableTypeEnums.U2:
                                value = data[offset] >> bits & 3;
                                break;
                            case VariableTypeEnums.U4:
                                value = data[offset] >> bits & 15;
                                break;
                            case VariableTypeEnums.U5:
                                value = data[offset] >> bits & 0x1F;
                                break;
                            case VariableTypeEnums.U6:
                                value = data[offset] >> bits & 0x3F;
                                break;
                            case VariableTypeEnums.U8:
                                offset += ub.Bit;
                                value = data[offset];
                                break;
                            case VariableTypeEnums.I8:
                                value = (sbyte)data[offset];//TODO：请注意，此处负数的处理
                                break;
                            case VariableTypeEnums.U16:
                                temp = new byte[2];
                                Array.Copy(data, offset, temp, bits, temp.Length);
                                value = BitConverter.ToUInt16(temp.Reverse().ToArray(), 0);
                                break;
                            case VariableTypeEnums.I16:
                                temp = new byte[2];
                                Array.Copy(data, offset, temp, bits, temp.Length);
                                value = BitConverter.ToInt16(temp.Reverse().ToArray(), 0);
                                break;
                            case VariableTypeEnums.U32:
                                temp = new byte[4];
                                Array.Copy(data, offset, temp, bits, temp.Length);
                                value = BitConverter.ToUInt32(temp.Reverse().ToArray(), 0);
                                break;
                            case VariableTypeEnums.I32:
                                temp = new byte[4];
                                Array.Copy(data, offset, temp, bits, temp.Length);
                                value = BitConverter.ToInt32(temp.Reverse().ToArray(), 0);
                                break;
                            case VariableTypeEnums.U64:
                                temp = new byte[8];
                                Array.Copy(data, offset, temp, bits, temp.Length);
                                value = BitConverter.ToUInt64(temp.Reverse().ToArray(), 0);
                                break;
                            case VariableTypeEnums.I64:
                                temp = new byte[8];
                                Array.Copy(data, offset, temp, bits, temp.Length);
                                value = BitConverter.ToInt64(temp.Reverse().ToArray(), 0);
                                break;
                            default:
                                break;
                        }
                        // bool val = ub.Value == value;
                        if ((decimal)ub.Value != value && ub.IsSensorRange)
                            ub.Value = Math.Round(sys.SensorRange * (double)value, 1);
                        else if ((decimal)ub.Value != value && !ub.IsSensorRange)
                            ub.Value = (double)value;

                        //ub.Value = 
                    }

                }

                watch.Stop();


                timeWatch.Stop();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error at frmTagsNew ,tmrRead_Tick" + ex.Message);
            }
        }

        /// <summary>
        /// 将字偏移装换为字节偏移
        /// </summary>
        /// <param name="offset">字偏移</param>
        /// <param name="bit">位偏移</param>
        /// <returns></returns>
        public List<int> ConvertBit(int offset, int bit)
        {
            return new List<int>() { offset * 2 + bit / 8, bit % 8 };
        }




        void RegisterLife(IEnumerable<IGrouping<int, Ports>> group)
        {
            foreach (var item in group)
            {
                List<Ports> list = item.ToList();
                int rata = item.Key;
                List<FullTags> tempLifeTag = new List<FullTags>();
                List<FullTags> tempNOLifeTag = new List<FullTags>();
                foreach (var pt in list)
                {

                    FullTags mode = tags.Where(p => p.COMMData.Port == pt.PortNum && !pt.IsRead && p.Identity).FirstOrDefault();
                    if (mode != null)
                    {
                        tempLifeTag.Add(mode);//有生命信号端口
                    }
                    else
                    {
                        FullTags modeNOLife = tags.Where(p => p.COMMData.Port == pt.PortNum && !pt.IsRead && !p.Identity).FirstOrDefault();
                        if (modeNOLife != null)
                        {
                            tempNOLifeTag.Add(modeNOLife);
                        }
                    }
                }

                Thread t = new Thread(new ThreadStart(delegate
                {
                    double value = 0;
                    while (!this.IsDisposed && !closed)
                    {
                        try
                        {
                            foreach (var tg in tempLifeTag)
                            {
                                try
                                {
                                    Ports mode = ports.Where(p => p.PortNum == tg.COMMData.Port).FirstOrDefault();
                                    int sinkSize = mode.DataSize;
                                    ushort life = (ushort)Convert.ToDouble(Comsum(tg.DataType, ref value));
                                    // MvbDllCall.sendbyte[portIndex, tg.COMMData.Offset] = life;
                                    MVBDriverZZC_Zhu.MVB.DataWrite(tg.COMMData.Port, tg.COMMData.Offset, tg.COMMData.Bit, tg.DataType, life);
                                    byte sendValue = (byte)value;

                                    //这里刷到到界面上的控件，生命信号
                                    fullData[tg.COMMData.Port][tg.COMMData.Offset] = sendValue;
                                }
                                catch (Exception ex)
                                {
                                    Debug.WriteLine("======================");
                                    Debug.WriteLine(ex.ToString());
                                    Debug.WriteLine("======================");
                                }

                            }

                            //foreach (var NOtg in tempNOLifeTag)
                            //{
                            //    Ports mode = ports.Where(p => p.PortNum == NOtg.COMMData.Port).FirstOrDefault();
                            //    if (mode == null) continue;
                            //    int portIndex = MvbDllCall.GetPortIndex(NOtg.COMMData.Port);
                            //    int sinkSize = mode.DataSize;
                            //    if (mode.SMIValue > 0 && sinkSize > 5)
                            //    {

                            //        if (dic.ContainsKey(mode.PortNum))
                            //        {
                            //            dic[mode.PortNum]++;
                            //        }
                            //        else
                            //        {
                            //            dic.Add(mode.PortNum, Convert.ToByte(1)); ;
                            //        }
                            //        MvbDllCall.sendbyte[portIndex, sinkSize - 5] = dic[mode.PortNum];
                            //    }
                            //}

                        }
                        catch (Exception ex)
                        {

                            Debug.WriteLine("生命信号写入错误：" + ex.Message);
                        }
                        finally
                        {
                            value++;
                            // MvbDllCall.SetCollection();
                            System.Threading.Thread.Sleep(rata);
                        }
                    }
                }));
                t.IsBackground = true;
                t.Start();
                //System.Threading.ThreadPool.QueueUserWorkItem();

            }
        }

        /// <summary>
        /// 累加
        /// </summary>
        object Comsum(string dataType, ref double value)
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

        /// <summary>
        /// 数据写入通用方法，自动判断当前是
        /// </summary>
        /// <param name="commType">通讯类型，0为以太网，1为MVB</param>
        /// <param name="port">通讯的端口号</param>
        /// <param name="Offset">字节偏移量</param>
        /// <param name="bit">位偏移量</param>
        /// <param name="value">写入的值，</param>
        /// <param name="value">是否生命信号，</param>
        void DataWrite(int port, int OffsetSrc, int bitSrc, object value, bool Sign = false)
        {

            int Offset = OffsetSrc;// ConvertBit(OffsetSrc, bitSrc)[0];
            int bit = ConvertBit(OffsetSrc, bitSrc)[1];

            byte[] bts = null;
            switch (value.GetType().Name)
            {
                case "Boolean":
                    if (value.Equals(true))
                        fullData[port][Offset] = (byte)(fullData[port][Offset] | (1 << bit));
                    else
                        fullData[port][Offset] = (byte)(fullData[port][Offset] & ~(1 << bit));
                    break;
                case "Byte":
                    bts = new byte[] { Convert.ToByte(value) };
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
                byte[] w = bts.Reverse().ToArray();
                for (int i = 0; i < w.Length; i++)
                {
                    txt += Convert.ToString(w[i], 16).PadLeft(2, '0') + " ";
                }
                Array.Copy(w, 0, fullData[port], Offset, w.Length);
            }
            else
            {
                Debug.WriteLine(string.Format("{4} write bit,port={0},offset={1},bit={2},value={3}", port, Offset, bit, value, DateTime.Now.ToString("HH:mm:ss.ffffff")));
            }


            switch (value.GetType().Name)
            {
                case "Boolean":
                    //MvbDllCall.SetValue(port, Offset, bit, Convert.ToBoolean(value)); break;
                    MVBDriverZZC_Zhu.MVB.DataWrite(port, Offset, bit, "B1", value); break;
                case "Byte": MVBDriverZZC_Zhu.MVB.DataWrite(port, Offset, bit, "U8", value); break;
                case "Int16": MVBDriverZZC_Zhu.MVB.DataWrite(port, Offset, bit, "I16", value); break;
                case "UInt16": MVBDriverZZC_Zhu.MVB.DataWrite(port, Offset, bit, "U16", value); break;
                case "Int32": MVBDriverZZC_Zhu.MVB.DataWrite(port, Offset, bit, "I32", value); break;
                case "UInt32": MVBDriverZZC_Zhu.MVB.DataWrite(port, Offset, bit, "U32", value); break;
                case "Int64": MVBDriverZZC_Zhu.MVB.DataWrite(port, Offset, bit, "I64", value); break;
                case "UInt64": MVBDriverZZC_Zhu.MVB.DataWrite(port, Offset, bit, "U64", value); break;
                case "Single":
                case "Double":
                    //MvbDllCall.SetValue(port, Offset, Convert.ToByte(value)); break;
                    MVBDriverZZC_Zhu.MVB.DataWrite(port, Offset, bit, "U64", value); break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 当前的端口号
        /// </summary>
        string currentPort = "";


        /// <summary>
        /// 启动定时器刷新，停止所有其他的定时器（写）
        /// </summary>
        /// <param name="port"></param>


        //存储了所有的timer控件
        System.Windows.Forms.Timer WriteTimer = new System.Windows.Forms.Timer();
        //存储了本类型的所有读事件
        //Dictionary<int, Timer> fullReadTimer = new Dictionary<int, Timer>();
        //存储了所有的待发送数据
        public static Dictionary<int, byte[]> fullData = new Dictionary<int, byte[]>();//所有待发送的数据，通过端口号进行存储
        //存储了所有的标识自增控件
        Dictionary<int, ucByte> fullIdentity = new Dictionary<int, ucByte>();//存储了所有的标识列，用于刷新时，自增
        //所有的 ControlCollection
        Dictionary<string, FlowLayoutPanel> fullControls = new Dictionary<string, FlowLayoutPanel>();

        public List<Ports> ports = new List<Ports>();
        List<FullTags> tags = new List<FullTags>();

        //Dictionary<int, object[][]> dicValues = new Dictionary<int, object[][]>();

        Dictionary<COMMData, FullTags> dicItems = new Dictionary<COMMData, FullTags>();


        public void GetPortInfo()
        {
            PortsBLL bllPorts = new();
            ports = [.. bllPorts.GetPortsByType(ReadOnly)];
            MVBFulltagsBLL bllTags = new();
            tags = bllTags.GetAllTags().OrderBy(x => x.COMMData.Offset).OrderBy(x => x.COMMData.Bit).ToList();
            List<int> lifes = [];
            //先组合待发送的数据
            foreach (var item in ports)
            {
                fullData[item.PortNum] = new byte[item.DataSize];
                if (!item.IsRead) lifes.Add(item.PortNum);
            }

            foreach (var item in tags)
            {
                dicItems[item.COMMData] = item;
            }
        }

        /// <summary>
        /// 加载端口页面数据
        /// 层级结构为：TagControl->TabPage->FlowLayoutPanel->ucBit/ucByte
        /// 每个TabPage对应一个计时器，当TabPage显示在UI时，启动定时器，否则停止。 读定时器随时打开
        /// </summary>
        /// <param name="commType">0为以太网，1为MVB</param>
        /// <param name="readOnly">true为宿端口，false为源端口，null为通用</param>
        void LoadData(bool? readOnly)
        {

            Stopwatch watchClear = new Stopwatch();
            watchClear.Start();
            fullControls.Clear();
            GC.Collect();
            watchClear.Stop();
            GC.Collect();
            PortsBLL bllPorts = new();
            ports = [.. bllPorts.GetPortsByType(ReadOnly)];
            MVBFulltagsBLL bllTags = new();
            tags = bllTags.GetAllTags().OrderBy(x => x.COMMData.Offset).OrderBy(x => x.COMMData.Bit).ToList();
            List<int> lifes = new List<int>();

            //先组合待发送的数据
            foreach (var item in ports)
            {
                fullData[item.PortNum] = new byte[item.DataSize];
                if (!item.IsRead)
                    lifes.Add(item.PortNum);
            }

            foreach (var item in tags)
            {
                dicItems[item.COMMData] = item;
            }
        }

        void LoadTabs()
        {
            page.Offset = 0;
            page.Length = 64;

            Panel ctrls = this.PanelContent;
            ctrls.Controls.Clear();
            GC.Collect();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            LoadPage(page.Offset, page.Length);
            Debug.WriteLine("add cost:" + watch.ElapsedMilliseconds);
        }
        private TreeView tr;
        /// <summary>
        /// 加载左侧的树形结构
        /// </summary>
        void LoadLeftTree(string SerchKey)
        {
            tr = new TreeView();

            this.PanelTree.Controls.Clear();
            tr.ImageList = this.imageList1;
            tr.NodeMouseClick += Tr_NodeMouseClick;
            tr.Dock = DockStyle.Fill;
            foreach (Ports item in ports.OrderBy(p => p.IsRead))
            {
                TreeNode node = new();
                if (item.IsRead)
                {
                    node.ImageIndex = 0;
                }
                else
                {
                    node.ImageIndex = 1;
                }
                node.Text = item.PortName + "(" + item.Port + ")";
                if (!node.Text.Contains(SerchKey))
                    continue;
                if (ReadOnly != null ? ReadOnly != item.IsRead : false)
                    continue;
                node.Tag = item;
                tr.Nodes.Add(node);
            }
            if (PanelContent.Tag == null)
            {
                PanelContent.Tag = tr.Nodes[0].Tag;
                tr.Nodes[0].Checked = true;
            }
            this.PanelTree.Controls.Add(tr);
            LoadTabs();
        }
        /// <summary>
        /// 树形结构 节点检索，将非检索结果去除 同时默认显示第一个节点信号内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeach_Click(object sender, EventArgs e)
        {
            LoadLeftTree(this.txtPortName.Text.Trim());
        }
        private void Tr_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            PanelContent.Tag = node.Tag;
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
            Color backColor = Color.FromName(ConfigManager.Layout.ItemColor);
            Ports item = PanelContent.Tag as Ports;
            this.labPresentPort.Text = string.Format("{0}({1})，端口周期：{2}ms", item.PortName, item.Port, item.Rate);
            this.currentPort = item.Port;
            string port = item.Port;
            int portNum = item.PortNum;

            //先找到容器
            FlowLayoutPanel flow = null;
            if (PanelContent.Controls.Count == 0 || true)
            {
                flow = new FlowLayoutPanel();
                flow.Padding = new Padding(5);
                flow.Size = PanelContent.Size;
                flow.Dock = DockStyle.Fill;
                flow.AutoScroll = true;
                // if (ConfigManager.Layout.RightToLeft)
                flow.FlowDirection = FlowDirection.RightToLeft;
                //else
                //    flow.FlowDirection = FlowDirection.LeftToRight;
                //PanelContent.Controls.Add(flow);
            }
            else
            {
                flow = PanelContent.Controls[0] as FlowLayoutPanel;
            }

            string controlsKey = item.Port;
            if (fullControls.ContainsKey(controlsKey))
            {
                PanelContent.Controls.Clear();
                PanelContent.Controls.Add(fullControls[controlsKey]);
            }
            else
            {
                var items = tags.Where(x => x.COMMData.Port == portNum && x.COMMData.Offset >= offset * length && x.COMMData.Offset < (offset + 1) * length).OrderBy(x => x.COMMData.Offset).OrderBy(x => x.COMMData.Bit).ToList();

                int lastType = 0;//标识上一次是什么类型（连续状态），bit位或非bit类型，主要用于判断是否需要截断 0标识无，1表示非bit，2表示bit

                int minOffset = items.Count == 0 ? 0 : items.Min(x => x.COMMData.Offset);
                int maxOffset = items.Count == 0 ? 0 : items.Max(x => x.COMMData.Offset);

                Padding p = new Padding(1, ConfigManager.Layout.LineSpace, 1, ConfigManager.Layout.LineSpace);

                Stopwatch watch = new Stopwatch();
                watch.Start();

                for (int i = minOffset; i <= maxOffset; i++)
                {
                    COMMData d = new();
                    FullTags tag = new();
                    int bitCount = items.Where(x => x.COMMData.Offset == i).Count();
                    List<int> bits = items.Where(x => x.COMMData.Offset == i).Select(x => x.COMMData.Bit).ToList();
                    //bool isContinue = false;
                    List<FullTags> isCt = [];
                    for (int k = 0; k < bitCount; k++)
                    {
                        d.Port = portNum;
                        d.Offset = i;
                        d.Bit = bits[k];

                        //TODO:如果比特位没有从0开始，可能会有小问题
                        if (!dicItems.ContainsKey(d))
                        {
                            if (ConfigManager.Layout.NumHold) //模拟量占位
                            {
                                UserControl ub = new UserControl();
                                ub.BorderStyle = BorderStyle.FixedSingle;
                                ub.BackColor = SystemColors.Control;
                                ub.Size = new Size(238, 60);
                                ub.Margin = p;
                                //自动截断
                                if (lastType != 1 && lastType != 0 && ConfigManager.Layout.Cut)
                                    flow.SetFlowBreak(flow.Controls[flow.Controls.Count - 1], true);
                                lastType = 1;
                                flow.Controls.Add(ub);
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
                        if (tag.DataType != "B1")//非数字量，
                        {
                            if (tag.DataType == "I16") i++;

                            ucByte ub = new()
                            {
                                Size = new Size(264, 60),
                                Margin = p,
                                Text = tag.DataLabel,
                                Port = tag.COMMData.Port,
                                ReadOnly = item.IsRead
                            };
                            if (ub.ReadOnly == false)
                                ub.Cursor = Cursors.Hand;
                            ub.Offset = tag.COMMData.Offset;
                            ub.Bit = tag.COMMData.Bit;
                            ub.Unit = tag.DataUnit;
                            ub.IsSensorRange = tag.IsSensorRange;
                            ub.Range = new DataRange(tag.DataRange);
                            ub.VariableType = (VariableTypeEnums)Enum.Parse(typeof(VariableTypeEnums), tag.DataType);
                            ub.BackColor = backColor;
                            ub.Submits += new RW.Modules.ValueHandler<double>(ub_Submits);
                            ub.WriteRate = tag.WriteRate;
                            ub.ReadRate = tag.ReadRate;

                            ////自动截断
                            if (lastType != 1 && lastType != 0 && ConfigManager.Layout.Cut)
                                flow.SetFlowBreak(flow.Controls[flow.Controls.Count - 1], true);

                            lastType = 1;

                            //如果是自增列，填充到自增的缓存中
                            if (tag.Identity)
                            {
                                ub.Enabled = false;
                                fullIdentity[portNum] = ub;
                            }
                            flow.Controls.Add(ub);
                            isCt.Add(tag);
                        }
                        else
                        {
                            d.Bit = tag.COMMData.Bit;
                            Size s = new(78, 80);
                            if (ConfigManager.Layout.BitCount == 8)//每行显示8位还是16位
                                s = new Size(130, 65);
                            Control c = null;
                            tag = dicItems[d];
                            ucBit bit = new ucBit();
                            bit.BackColor = backColor;
                            bit.Size = s;
                            bit.Margin = p;
                            bit.Text = tag.DataLabel;
                            bit.Port = tag.COMMData.Port;
                            bit.Offset = tag.COMMData.Offset;
                            bit.Bit = tag.COMMData.Bit;
                            bit.ReadOnly = item.IsRead;
                            if (bit.ReadOnly == false)
                                bit.Cursor = Cursors.Hand;
                            bit.Range = new DataRange(tag.DataRange);
                            bit.Click += new EventHandler(bit_Click);
                            c = bit;

                            if (lastType != 2 && lastType != 0 && ConfigManager.Layout.Cut)
                                flow.SetFlowBreak(flow.Controls[flow.Controls.Count - 1], true);

                            lastType = 2;
                            flow.Controls.Add(c);
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

        void bit_Click(object sender, EventArgs e)
        {
            ucBit bit = sender as ucBit;
            //TODO:写数据
            Debug.WriteLine("bit write:" + bit.Text + "," + bit.Offset + "." + bit.Bit + ":" + bit.Switch);
            try
            {
                DataWrite(bit.Port, bit.Offset, bit.Bit, bit.Switch);
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据写入失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ub_Submits(object sender, double value)
        {
            ucByte ub = sender as ucByte;
            //TODO:写数据
            Debug.WriteLine("byte write:" + ub.Text + "," + ub.Offset + ":" + ub.Value + " - " + ub.VariableType);

            object writeValue;

            switch (ub.VariableType)
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
            DataWrite(ub.Port, ub.Offset, ub.Bit, writeValue);
        }



        PageModelNew page;

        private void frmTags_FormClosed(object sender, FormClosedEventArgs e)
        {

            closed = true;
            if (driver != null)
            {
                driver.Close();
                driver.Close();
            }


        }

        private void radNone_CheckedChanged(object sender, EventArgs e)
        {
            if (!loaded) return;
            this.ReadOnly = null;
            PanelContent.Tag = null;
            LoadLeftTree("");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            //this.Visible = Common.MVBVisible = false;
            //this.Close();
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            SelectPanlControl(key);

        }

        void clearSelect()
        {
            foreach (var item in selected)
            {
                item.BackColor = Color.FromName(ConfigManager.Layout.ItemColor);
            }
            selected.Clear();
        }

        List<Control> selected = new List<Control>();

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

        public object obj = new object();

        private Dictionary<int, byte> dic = new Dictionary<int, byte>();


        struct PageModelNew
        {
            public int Offset { get; set; }
            public int Length { get; set; }
            public int TotalSize { get; set; }
            //public int TotalPage { get; set; }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            SaveConfigData();
            MessageBox.Show("保存成功！");
        }

        string pathFilename = Application.StartupPath + "\\config\\LastData.txt";

        private void timer1_Tick(object sender, EventArgs e)
        {
            SaveConfigData();
        }

        public void SaveConfigData()
        {
            string text = JsonConvert.SerializeObject(fullData);
            try
            {
                File.WriteAllText(pathFilename, text, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("自动保存数据失败，错误消息：" + ex.Message, "系统提示");
                this.timer1.Enabled = false;
            }
        }

        private void btnRestoreConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(pathFilename))
                {
                    string pathes = File.ReadAllText(pathFilename, Encoding.UTF8);
                    var data = JsonConvert.DeserializeObject(pathes, fullData.GetType());
                    fullData = (Dictionary<int, byte[]>)data;
                }
                else
                {
                    MessageBox.Show("未配置数据保存目录，请手动配置好监控目录后。再次启动程序。（config\\LastData.txt）");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("回复上次数据失败，错误消息：" + ex.Message, "系统提示");
            }
        }


    }


}
