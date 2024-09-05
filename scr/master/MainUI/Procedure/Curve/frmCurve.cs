using DevComponents.DotNetBar;
using MainUI.Config;
using MainUI.CurrencyHelper;
using MainUI.Reflex;
using Newtonsoft.Json.Linq;
using NPOI.SS.Formula.Functions;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace MainUI.Procedure.Curve
{
    [SupportedOSPlatform("windows")]
    public partial class frmCurve : UIForm
    {
        public frmCurve()
        {
            InitializeComponent();
            InitCurve();
            uiContextMenuStrip.ItemClicked += UiContextMenuStrip_ItemClicked; ;
        }

        private void UiContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //var Item = sender as UIContextMenuStrip;
            //Debug.WriteLine(Item?.Items[0]);
            if (CurveTask?.Status == TaskStatus.Running)
                return;

            //var Item = e.ClickedItem;
            if (FormEx.ShowAskDialog(this, "是否取消当前曲线设置？"))
            {
                valuename[index] = null;
                uibutton[index].Text = "未选择";
                ValueNameOperation.DataSave(valuename);
            }
        }
        /// <summary>
        /// 每个曲线空间 曲线总数据
        /// </summary>
        static int LCcount = 20;
        //界面可显示曲线总数
        static int count = 20;
        /// <summary>
        /// 选择信号数组
        /// </summary>
        ValueName[] valuename = new ValueName[count];
        /// <summary>
        /// 名称 控件数组
        /// </summary>
        UIButton[] uibutton = new UIButton[count];
        /// <summary>
        /// 数值显示控件数组
        /// </summary>
        UITextBox[] uitxt = new UITextBox[count];
        /// <summary>
        /// 隐藏控件数组
        /// </summary>
        UICheckBox[] uiCheck = new UICheckBox[count];
        /// <summary>
        /// Type集合
        /// </summary>
        Dictionary<string, Type> dicType = new();
        /// <summary>
        /// 颜色 控件数组
        /// </summary>
        Panel[] Pcolour = new Panel[count];
        /// <summary>
        /// 需显示曲线值数组
        /// </summary>
        PropertyInfo[] property = new PropertyInfo[count];
        /// <summary>
        /// 已选数据的值  的数组
        /// </summary>
        double[] dbValue = new double[count];

        int index;
        UILineOption option0 = new();
        public void InitCurve()
        {
            #region 曲线控件
            uiLineChart1.Option.Clear();
            option0.ShowZeroLine = true;
            option0.ShowZeroValue = true;
            option0.XAxis.ShowGridLine = true;//横轴网格线
            option0.YAxis.ShowGridLine = true;//纵轴网格线
            option0.ToolTip.Visible = false;
            option0.Title = new()
            {
                Text = "数据曲线",
                SubText = "  "
            };
            option0.AddSeries(new UILineSeries("Line1"));
            option0.YAxis.SetMaxValue(1000.0);
            option0.YAxis.SetMinValue(0);
            option0.XAxis.Name = "时间";
            option0.YAxis.Name = "压力值";
            option0.XAxisType = UIAxisType.DateTime;
            option0.XAxis.AxisLabel.DateTimeFormat = "HH:mm:ss";
            uiLineChart1.SetOption(option0);
            #endregion
        }

        DateTime dt = DateTime.Now;
        int Time__ = -20;
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (FormEx.ShowAskDialog(this, "确定退出吗？"))
            {
                //Interlocked.Exchange(ref isThreadStarted, 1);
                timeEndPeriod(1);
                CurveCts?.Cancel();
                cts?.Cancel();
                Close();
                Dispose();
            }
        }

        #region  定时器对象 定义

        [DllImport("winmm")]
        static extern uint timeGetTime();

        [DllImport("winmm")]
        static extern void timeBeginPeriod(int t);

        [DllImport("winmm")]
        static extern uint timeEndPeriod(int t);

        Thread timerthread_100;
        #endregion
        /// <summary>
        /// 是否进行数据保存
        /// </summary>
        private CancellationTokenSource cts = new();
        private void Timer_100()
        {
            isThreadStarted = 2;
            CancellationToken token = cts.Token;
            while (!token.IsCancellationRequested)
            {
                //需要循环的操作
                //Debug.WriteLine("开始时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"));
                dt = DateTime.Now;
                try
                {
                    for (int i = 0; i < uibutton.Length; i++)
                    {
                        if (valuename[i] != null)
                        {
                            string FatherNodeName = valuename[i].FatherNodeName;
                            string NodeName = valuename[i].NodeName;
                            dbValue[i] = (double)FRTypeCollection.Instance()[dicType[FatherNodeName]].FRPropertyCollection[NodeName].Getter(NodeName);
                        }
                        else
                            dbValue[i] = 0;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("设备监控界面数据刷新异常：" + ex.ToString());
                }
                //Debug.WriteLine("获数据时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff") + "耗时：" + (timeGetTime() - timerstart));
            }
        }

        /// <summary>
        /// 多线程启动标志位
        /// </summary>
        private int isThreadStarted = 1;
        private void BigStartOperation() //开始
        {
            ResetEvent?.Set();//暂停   
            ValueNameOperation.DataSave(valuename);
            for (int i = 0; i < uibutton.Length; i++)
            {
                uiCheck[i].Checked = false;
                if (valuename[i] != null)
                {
                    string FatherNodeName = valuename[i].FatherNodeName;
                    string NodeName = valuename[i].NodeName;
                    property[i] = dicType[FatherNodeName].GetProperty(NodeName);
                    Color c = Pcolour[i].BackColor;
                    if (i >= 0 && i < LCcount)
                        option0.AddSeries(new UILineSeries(valuename[i].NodeText, c));
                }
            }
            uiLineChart1.SetOption(option0);

            ValueName[] va = ValueNameOperation.DataLoading();
            if (va != null)
                for (int i = 0; i < va.Length; i++)
                {
                    if (va[i] != null)
                    {
                        //uibutton[i].Text = va[i].NodeName;
                        valuename[i] = va[i];
                        uibutton[i].Text = valuename[i].FatherNodeText + "_" + valuename[i].NodeText;
                    }
                }
            //设置各曲线样式
            foreach (var series in uiLineChart1.Option.Series)
            {
                series.Value.Symbol = UILinePointSymbol.Circle;
                series.Value.SymbolSize = 2;
            }

            CurveStart();
            CheckForIllegalCrossThreadCalls = false;
            timerthread_100 = new Thread(Timer_100);
            // 尝试启动线程
            if (Interlocked.Exchange(ref isThreadStarted, 2) == 1)
            {
                timeBeginPeriod(1);
                timerthread_100.Start();
            }
        }

        //结束
        private void BigEndOperation()
        {
            ResetEvent.Reset();
        }

        bool isOperationStarted = false;
        /// <summary>
        /// 开始绘画曲线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            bool allNull = Array.TrueForAll(valuename, m => m is null);
            if (allNull) { UIMessageBox.Show("请先设置曲线显示！", UILocalize.InfoTitle, Style); return; }

            if (!isOperationStarted)
            {
                //开始操作
                BigStartOperation();
                isOperationStarted = true;
                btnStart.Text = "暂 停";
                btnStart.FillColor = Color.FromArgb(255, 128, 128);
                btnStart.RectColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                //结束操作
                BigEndOperation();
                isOperationStarted = false;
                btnStart.Text = "开 始";
                btnStart.FillColor = Color.FromArgb(110, 190, 40);
                btnStart.RectColor = Color.FromArgb(110, 190, 40);
            }
        }

        /// <summary>
        /// RecursionTreeControl:表示将XML文件的内容显示在TreeView控件中
        /// </summary>
        /// <param name="xmlNode">将要加载的XML文件中的节点元素</param>
        /// <param name="nodes">将要加载的XML文件中的节点集合</param>
        private void RecursionTreeControl(XmlNode xmlNode, TreeNodeCollection nodes)
        {
            foreach (XmlNode node in xmlNode.ChildNodes)//循环遍历当前元素的子元素集合
            {
                TreeNode new_child = new()
                {
                    Name = node.Attributes["name"].Value,
                    Text = node.Attributes["text"].Value
                };//定义一个TreeNode节点对象
                nodes.Add(new_child);//向当前TreeNodeCollection集合中添加当前节点
                RecursionTreeControl(node, new_child.Nodes);//调用本方法进行递归
            }
        }

        XmlDocument doc = new();
        private void frmCurve_Load(object sender, EventArgs e)
        {
            dicType.Add("CAN_Data", typeof(CAN_Data.AI));
            dicType.Add("MVB_Data", typeof(MVB_Data.AI));
            dicType.Add("TRDP_Data", typeof(TRDP_Data.AI));
            dicType.Add("TestBed_Data", typeof(TestBed_Data.AI));

            #region 控件数组初始化
            uibutton[0] = uibt_name0;
            uibutton[1] = uibt_name1;
            uibutton[2] = uibt_name2;
            uibutton[3] = uibt_name3;
            uibutton[4] = uibt_name4;
            uibutton[5] = uibt_name5;
            uibutton[6] = uibt_name6;
            uibutton[7] = uibt_name7;
            uibutton[8] = uibt_name8;
            uibutton[9] = uibt_name9;
            uibutton[10] = uibt_name10;
            uibutton[11] = uibt_name11;
            uibutton[12] = uibt_name12;
            uibutton[13] = uibt_name13;
            uibutton[14] = uibt_name14;
            uibutton[15] = uibt_name15;
            uibutton[16] = uibt_name16;
            uibutton[17] = uibt_name17;
            uibutton[18] = uibt_name18;
            uibutton[19] = uibt_name19;
            //uibutton[20] = uibt_name20;

            uitxt[0] = uibt_value0;
            uitxt[1] = uibt_value1;
            uitxt[2] = uibt_value2;
            uitxt[3] = uibt_value3;
            uitxt[4] = uibt_value4;
            uitxt[5] = uibt_value5;
            uitxt[6] = uibt_value6;
            uitxt[7] = uibt_value7;
            uitxt[8] = uibt_value8;
            uitxt[9] = uibt_value9;
            uitxt[10] = uibt_value10;
            uitxt[11] = uibt_value11;
            uitxt[12] = uibt_value12;
            uitxt[13] = uibt_value13;
            uitxt[14] = uibt_value14;
            uitxt[15] = uibt_value15;
            uitxt[16] = uibt_value16;
            uitxt[17] = uibt_value17;
            uitxt[18] = uibt_value18;
            uitxt[19] = uibt_value19;
            //uitxt[20] = uibt_value20;

            Pcolour[0] = ui_colour0;
            Pcolour[1] = ui_colour1;
            Pcolour[2] = ui_colour2;
            Pcolour[3] = ui_colour3;
            Pcolour[4] = ui_colour4;
            Pcolour[5] = ui_colour5;
            Pcolour[6] = ui_colour6;
            Pcolour[7] = ui_colour7;
            Pcolour[8] = ui_colour8;
            Pcolour[9] = ui_colour9;
            Pcolour[10] = ui_colour10;
            Pcolour[11] = ui_colour11;
            Pcolour[12] = ui_colour12;
            Pcolour[13] = ui_colour13;
            Pcolour[14] = ui_colour14;
            Pcolour[15] = ui_colour15;
            Pcolour[16] = ui_colour16;
            Pcolour[17] = ui_colour17;
            Pcolour[18] = ui_colour18;
            Pcolour[19] = ui_colour19;
            //Pcolour[20] = ui_colour20;

            uiCheck[0] = ckHide0;
            uiCheck[1] = ckHide1;
            uiCheck[2] = ckHide2;
            uiCheck[3] = ckHide3;
            uiCheck[4] = ckHide4;
            uiCheck[5] = ckHide5;
            uiCheck[6] = ckHide6;
            uiCheck[7] = ckHide7;
            uiCheck[8] = ckHide8;
            uiCheck[9] = ckHide9;
            uiCheck[10] = ckHide10;
            uiCheck[11] = ckHide11;
            uiCheck[12] = ckHide12;
            uiCheck[13] = ckHide13;
            uiCheck[14] = ckHide14;
            uiCheck[15] = ckHide15;
            uiCheck[16] = ckHide16;
            uiCheck[17] = ckHide17;
            uiCheck[18] = ckHide18;
            uiCheck[19] = ckHide19;
            //uiCheck[20] = ckHide20;
            #endregion

            #region XML配置文件加载
            doc.Load("TreeXml\\TreeXml.xml");
            RecursionTreeControl(doc.DocumentElement, TvProject.Nodes);//将加载完成的XML文件显示在TreeView控件中
            //TvProject.ExpandAll();//展开TreeView控件中的所有项
            TvProject.CollapseAll();//折叠TreeView控件中的所有项
            #endregion

            TvProject.Visible = false;
            ValueName[] va = ValueNameOperation.DataLoading();
            if (va != null)
                for (int i = 0; i < va.Length; i++)
                {
                    if (va[i] != null)
                    {
                        //uibutton[i].Text = va[i].NodeName;
                        valuename[i] = va[i];
                        uibutton[i].Text = valuename[i].FatherNodeText + "_" + valuename[i].NodeText;// valuename[index].NodeText; //
                    }
                }
        }

        private void TvProject_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode != null)
            {
                TreeNode parentNode = selectedNode.Parent;
                if (parentNode != null)
                {
                    string parentName = parentNode.Name;
                    string parentText = parentNode.Text;
                    string name = selectedNode.Name;
                    string text = selectedNode.Text;
                    //判断是否已选择改项目， 
                    bool bl = false;
                    for (int i = 0; i < valuename.Length; i++)
                    {
                        if (valuename[i] != null)
                        {
                            if (valuename[i].FatherNodeName == parentName)
                            {
                                if (valuename[i].NodeName == name)
                                    bl = true;
                            }
                        }
                    }
                    if (!bl)
                    {
                        ValueName v = new()
                        {
                            FatherNodeName = parentName,
                            FatherNodeText = parentText,
                            NodeName = name,
                            NodeText = text
                        };
                        if (index < valuename.Length)
                            valuename[index] = v;
                        TvProject.Visible = false;
                        uibutton[index].Text = valuename[index].FatherNodeText + "_" + valuename[index].NodeText;
                    }
                    else
                    {
                        MessageHelper.UIMessageOK("已经添加相同项，无法选择！");
                        TvProject.Visible = false;
                    }

                    //string parentName = parentNode. parentNode.Header.ToString();
                    // 在这里你可以使用parentName进行相应的操作
                }

            }
        }

        #region Check保留
        /// <summary>
        /// 选中父节点所有子节点被选中
        /// </summary>
        /// <param name="n">当前选中节点</param>
        /// <param name="check">是否被选中</param>
        private void cycleChild(TreeNode n, bool check)
        {
            if (n.Nodes.Count != 0)
            {
                foreach (TreeNode child in n.Nodes)
                {
                    child.Checked = check;
                    if (child.Nodes.Count != 0)
                        cycleChild(child, check);
                }
            }
        }
        /// <summary>
        /// 遍历父节点如果子节点选中则全部选中，子节点没有选中则父节点不选中
        /// </summary>
        /// <param name="n"></param>
        /// <param name="check"></param>
        private void cycleParent(TreeNode n, bool check)
        {
            if (n.Parent != null)
            {
                if (nextCheck(n))
                    n.Parent.Checked = true;
                else
                    n.Parent.Checked = false;
                cycleParent(n.Parent, check);
            }
        }
        /// <summary>
        /// 判断通级节点是否全选
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private bool nextCheck(TreeNode n)
        {
            foreach (TreeNode node in n.Parent.Nodes)
            {
                if (node.Checked == false)
                    return false;
            }
            return true;
        }

        private void TvProject_AfterCheck(object sender, TreeViewEventArgs e)
        {
            ////需要加上e.action!=treeviewaction.unknown在加载窗体的时候不触发该事件
            //if (e.Action != TreeViewAction.Unknown)
            //{
            //    //如果对应的父节点被选中，对应的子节点全部被选中
            //    if (e.Node.Checked == true)
            //    {
            //        cycleChild(e.Node, true);

            //        if (e.Node.Parent != null)
            //        {
            //            //如果对应的父节点的其中一个子节点没有被选中父节点不选中，如果对应的子节点全部选中父节点选中      
            //            if (nextCheck(e.Node))
            //                cycleParent(e.Node, true);
            //            else
            //                cycleParent(e.Node, false);
            //        }
            //    }
            //    //如果对应的父节点没被选中，对应的子节点与父节点全部不选中
            //    if (e.Node.Checked == false)
            //    {
            //        cycleParent(e.Node, false);
            //        cycleChild(e.Node, false);
            //    }
            //}
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // 遍历所有的树节点
            foreach (TreeNode node in TvProject.Nodes)
            {
                // 检查节点是否被选中
                if (node.IsSelected)
                {
                    // 获取选中节点的Text属性值
                    string selectedNodeValue = node.Text;
                    // 根据需要，可以继续获取其他属性值，例如 node.Tag 等

                    // 处理选中节点的值
                    // ...
                }

                // 递归检查子节点
                GetSelectedNodeValue(node.Nodes);
            }
        }

        private void GetSelectedNodeValue(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.IsSelected)
                {
                    //string selectedNodeValue = node.Text;
                    // 处理选中节点的值
                    // ...
                }

                GetSelectedNodeValue(node.Nodes); // 递归调用
            }
        }
        #endregion

        private void uibt_name0_Click(object sender, EventArgs e)
        {
            if (CurveTask?.Status == TaskStatus.Running)
                return;

            UIButton uibt = (UIButton)sender;
            index = uibt.TabIndex.ToInt();
            Debug.WriteLine("左键获取index：" + index);
            TvProject.Visible = true;
        }

        private void uibt_name0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                UIButton uibt = (UIButton)sender;
                index = uibt.TabIndex.ToInt();
                Debug.WriteLine("右击获取index：" + index);
            }
        }

        private void uiLineChart1_PointValue(object sender, UILineSelectPoint[] points)
        {
            foreach (var (point, time, text) in from point in points
                                                let time = DateTime.FromOADate(point.X).AddHours(8)
                                                let TimeText = $"{time.Hour}:{time.Minute}:{time.Second}"
                                                let text = string.Format("名称：{0}，X轴：{1}，Y轴：{2}，Index：{3}", point.Series.Name, TimeText, point.Y.ToString("f2"), point.Index)
                                                select (point, time, text))
            {
                Debug.WriteLine(string.Format("名称：{0}，X轴：{1}，Y轴：{2}，Index：{3}", point.Series.Name, time, point.Y.ToString("f2"), point.Index));
                uiToolTip1.SetToolTip(uiLineChart1, text);
            }

        }

        private void uiBtnEmpty_Click(object sender, EventArgs e)
        {
            if (CurveTask?.Status == TaskStatus.Running)
            {
                return;
            }
            if (FormEx.ShowAskDialog(this, "确认是否清空所选曲线设置？"))
            {
                Array.Clear(valuename, 0, valuename.Length);
                ValueNameOperation.DataSave(valuename);
                foreach (var btn in uibutton)
                    btn.Text = "未选择";
            }
        }

        private void ImageBackground_Click(object sender, EventArgs e)
        {
            bool isWhether = uiLineChart1.FillColor == Color.FromArgb(238, 251, 250);
            if (isWhether)
                uiLineChart1.FillColor = Color.Gray;
            else
                uiLineChart1.FillColor = Color.FromArgb(238, 251, 250);
        }

        Task CurveTask;
        private readonly ManualResetEvent ResetEvent = new(true);
        private CancellationTokenSource CurveCts = new();
        /// <summary>
        /// 启动曲线绘画Task
        /// </summary>
        public void CurveStart()
        {
            if (CurveTask?.Status == TaskStatus.Running) return;
            CancellationToken token = CurveCts.Token;
            CurveTask = Task.Factory.StartNew(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    //曲线数据更新
                    for (int i = 0; i < dbValue.Length; i++)
                    {
                        uitxt[i].Text = dbValue[i].ToString("f2");
                        if (valuename[i] != null)
                        {
                            if (i >= 0 && i < LCcount)
                                uiLineChart1.Option.AddData(valuename[i].NodeText, dt, dbValue[i]);
                        }
                    }
                    //曲线刷新
                    DateTime dts = dt.AddSeconds(Time__);
                    option0.XAxis.SetRange(dts, dt.AddSeconds(10));
                    uiLineChart1.Refresh();
                    Task.Delay(1000).Wait();
                    ResetEvent.WaitOne();
                }
            }, token);
        }

        private void uiCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            var check = sender as UICheckBox;
            //迭代过程中会抛出[Collection was modified]异常，暂时用此方法进行优化，未解决
            for (int i = uiCheck.Length - 1; i >= 0; i--)
            {
                if (valuename[i] != null)
                {
                    if (uiLineChart1.Option.Series.ContainsKey(valuename[i].NodeName))
                        uiCheck[i].Checked = check.Checked;
                }
            }
        }

        private void ckHide0_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var check = sender as UICheckBox;
                var key = valuename[check.Tag.ToInt()];
                if (key != null)
                    if (uiLineChart1.Option.Series.ContainsKey(key.NodeName))
                    {
                        uiLineChart1.Option.Series[key.NodeName].Visible = !check.Checked;
                        uiLineChart1.Refresh();
                    }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }

}
