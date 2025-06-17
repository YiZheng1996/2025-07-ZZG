using MainUI.BLL;
using MainUI.Config;
using MainUI.CurrencyHelper;
using MainUI.Procedure.Curve.DataModel;
using MainUI.Reflex;
using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MainUI.Procedure.Curve
{
    public partial class frmDataPlayback : UIForm
    {
        /// <summary>
        /// 数据集合
        /// </summary>
        Datas_Model dataModels;

        public delegate void BarEventHandler(int i);
        public event BarEventHandler BarHandler;

        public frmDataPlayback()
        {
            InitializeComponent();
            InitChart();
            uiTimeStart.Value = DateTime.Now.Date + new TimeSpan(0, 0, 0);
            uiContextMenuStrip.ItemClicked += UiContextMenuStrip_ItemClicked;
            InitModel();
        }
        private void UiContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Ctask?.Status == TaskStatus.Running) return;
            if (FormEx.ShowAskDialog(this, "是否取消当前曲线设置？"))
            {
                valuename[index] = null;
                uibutton[index].Text = "未选择";
                ValueNameOperation.DataSave(valuename, false);
            }
        }

        /// <summary>
        /// 每个曲线空间 曲线总数据
        /// </summary>
        static int LCcount = 21;
        //界面可显示曲线总数
        static int count = 21;
        /// <summary>
        /// 选择信号数组
        /// </summary>
        ValueName[] valuename = new ValueName[count];
        /// <summary>
        /// 名称 控件数组
        /// </summary>
        UIButton[] uibutton = new UIButton[count];
        /// <summary>
        /// 隐藏控件数组
        /// </summary>
        UICheckBox[] uiCheck = new UICheckBox[count];
        /// <summary>
        /// 数值显示控件数组
        /// </summary>
        UITextBox[] uitxt = new UITextBox[count];
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

        string folderPath = Application.StartupPath + "Autosave\\";
        UILineOption option0 = new();
        /// <summary>
        /// 曲线控件初始化
        /// </summary>
        public void InitChart()
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

        /// <summary>
        /// 型号选择
        /// </summary>
        private void InitModel()
        {
            ModelBLL bModel = new();
            DataTable dt2 = bModel.GetAllKindByCon(" and 1=1");
            uiComBoxModel.ValueMember = "ID";
            uiComBoxModel.DisplayMember = "Name";
            uiComBoxModel.DataSource = dt2;
        }

        /// <summary>
        /// 带毫秒的字符转换成时间（DateTime）格式
        /// 可处理格式：[2024-10-10 10:10:10,666 或 2024-10-10 10:10:10 666 或 2024-10-10 10:10:10.666]
        /// </summary>
        public DateTime GetDateTime(string dateTime)
        {
            string[] strArr = dateTime.Split(['-', ' ', ':', ',', '.']);
            DateTime dt = new(int.Parse(strArr[0]),
                int.Parse(strArr[1]),
                int.Parse(strArr[2]),
                int.Parse(strArr[3]),
                int.Parse(strArr[4]),
                int.Parse(strArr[5]),
                int.Parse(strArr[6]));
            return dt;
        }

        /// <summary>
        /// 扫描全部CSV文件
        /// </summary>
        /// <param name="folderPath">文件存放路径</param>
        /// <returns></returns>
        public static FileInfo[] SearchFilesByDate(string folderPath)
        {
            DirectoryInfo dirInfo = new(folderPath);
            return dirInfo.GetFiles();
        }

        /// <summary>
        /// 获取CSV数据构建临时表单
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        //public DataTable GetDataTable(DateTime startTime)
        //{
        //    DataTable dt = new();
        //    string path = folderPath + uiComBoxModel.Text + "\\" + startTime.ToString("yyyy-MM-dd");
        //    FileInfo[] files = SearchFilesByDate(path);
        //    foreach (FileInfo file in files)
        //    {
        //        DateTime startSpan = startTime.Date + new TimeSpan(0, 0, 0);
        //        //var timeNow = DateTime.Parse(file.Name.Replace('_', '-').Replace(".csv", ""));
        //        return CSVHelper.ReadAsDatatable(file.ToString());
        //    }
        //    return dt;
        //}

        /// <summary>
        /// 获取CSV数据构建临时表单
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public Dictionary<string, DataTable> GetDataTable(DateTime startTime)
        {
            Dictionary<string, DataTable> dts = [];
            string path = folderPath + uiComBoxModel.Text + "\\" + startTime.ToString("yyyy-MM-dd");
            if (!Path.Exists(path)) return dts;

            FileInfo[] files = SearchFilesByDate(path);
            foreach (FileInfo file in files)
            {
                //var timeNow = DateTime.Parse(file.Name.Replace('_', '-').Replace(".csv", ""));
                dts.Add(file.ToString(), CSVHelper.ReadAsDatatable(file.ToString()));
            }
            return dts;
        }

        /// <summary>
        /// 解析后数据集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="CloName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<T> GetLines<T>(string CloName, DataTable data)
        {
            List<T> list = new();
            DataColumn column = data.Columns[CloName]; // 获取列对象
            object[] columnValues = new object[data.Rows.Count];// 创建一个数组来存储列的所有值
            // 遍历DataTable的每一行，获取列的值
            for (int i = 0; i < data.Rows.Count; i++)
            {
                columnValues[i] = data.Rows[i][column];
                var model = JsonConvert.DeserializeObject<T>(columnValues[i].ToString());
                list.Add(model);
            }
            return list;
        }

        /// <summary>
        /// 反序列
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="JsonStr"></param>
        /// <returns></returns>
        public T Deserialize<T>(string JsonStr)
        {
            return JsonConvert.DeserializeObject<T>(JsonStr);
        }

        /// <summary>
        /// 加载处理后数据
        /// </summary>
        private void LoadCsvData()
        {
            try
            {
                Debug.WriteLine("数据处理开始时间：" + DateTime.Now);
                dataModels = new();
                var timeStart = uiTimeStart.Value;
                dataModels.DataModels = [];
                var datas = GetDataTable(timeStart);
                if (datas.Count == 0) return;
                frmCurveDatas frmCurveData = new(datas, uiComBoxModel.Text);
                frmCurveData.ShowDialog();
                if (frmCurveData.DialogResult != DialogResult.OK)
                    return;
                var data = datas[frmCurveData.Dickey];
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataLine_Model model = new()
                    {
                        Time_Model = Deserialize<Time_Model>(data.Rows[i]["时间"].ToString()),
                        Test_Model = Deserialize<Test_Model>(data.Rows[i]["试验台传感器"].ToString())
                    };
                    dataModels.DataModels.Add(model);
                    //Debug.WriteLine("添加时间：" + model.Time_Model.TimeNow.ToString());
                    //else
                    //Debug.WriteLine("---------未添加时间：" + model.Time_Model.TimeNow.ToString());
                }
                Debug.WriteLine("数据处理结束时间：" + DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "加载数据失败！" + ex.Message);
            }
        }

        //int Time__ = -20;
        DateTime dt = DateTime.Now;
        CancellationTokenSource CTS = new();
        Task Ctask;
        /// <summary>
        /// 启动曲线控件
        /// </summary>
        /// <returns></returns>
        private async void TaskStart()
        {
            CTS = new();
            var Token = CTS.Token;
            bool isTesting = Token.IsCancellationRequested;
            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集
            uiProcessBar1.Visible = true;

            Ctask = Task.Run(() =>
             {
                 try
                 {
                     for (int i = 0; i < dataModels.DataModels.Count & !isTesting; i++)
                     {
                         uiProcessBar1.Value = Normalize(i, dataModels.DataModels.Count);
                         isTesting = Token.IsCancellationRequested;
                         for (int j = 0; j < dbValue.Length & !isTesting; j++)
                         {
                             if (valuename[j] is null) continue;
                             string FatherNodeName = valuename[j].FatherNodeName;
                             string NodeName = valuename[j].NodeName;
                             DataLine_Model LM = dataModels.DataModels[i];
                             //"类的完全限定名(即包括命名空间)"创建类的实例，返回为 objectd 类型，需要强制类型转换
                             object obj = assembly.CreateInstance("MainUI.Model." + FatherNodeName);
                             foreach (var item in LM.GetType().GetProperties())
                             {
                                 if (item.Name == FatherNodeName)
                                 {
                                     obj = LM.Test_Model;
                                     break;
                                 }
                             }
                             dbValue[j] = obj.GetType().GetProperty(NodeName).GetValue(obj).ToDouble();
                             var timeNow = LM?.Time_Model.TimeNow; //时间
                             DateTime dt = GetDateTime(timeNow);
                             uiLineChart1.Option.AddData(valuename[j]?.NodeText, dt, dbValue[j]);
                         }
                         uiLineChart1.Refresh();
                         Task.Delay(uiUpDownRate.Value).Wait();
                     }
                     uiProcessBar1.Visible = false;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(this, ex.Message, "系统提示");
                 }
             }, Token);

            await Ctask;
            if (dataModels.DataModels.Count < 1) { uiProcessBar1.Visible = false; MessageBox.Show(this, "未找到数据，请确认时间是否选择正确！", "系统提示"); }
            else
                MessageBox.Show(this, "曲线回放完成！", "系统提示");
            CTS.Cancel();
            //曲线刷新,不缩放曲线，X轴根据最大值移动
            //DateTime dts = dt.AddSeconds(Time__); 
            //option0.XAxis.SetRange(dts, dt.AddSeconds(5));
        }

        private int Normalize(double value, double total)
        {
            return Convert.ToInt32(((double)value / total * 100));
        }

        /// <summary>
        /// 加载动态值
        /// </summary>
        private void InitTrendsData()
        {
            ValueNameOperation.DataSave(valuename, false);
            for (int i = 0; i < uibutton.Length; i++)
            {
                uiCheck[i].Checked = false;
                if (valuename[i] != null)
                {
                    string FatherNodeName = valuename[i].FatherNodeName;
                    string NodeName = valuename[i].NodeName;
                    //property[i] = dicType[FatherNodeName].GetProperty(NodeName);
                    Color c = Pcolour[i].BackColor;
                    if (i >= 0 && i < LCcount)
                        option0.AddSeries(new UILineSeries(valuename[i].NodeText, c));
                }
            }
            uiLineChart1.SetOption(option0);

            ValueName[] va = ValueNameOperation.DataLoading(false);
            for (int i = 0; i < va?.Length; i++)
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
        }
        //开始
        private void BigStartOperation()
        {
            InitChart();
            LoadCsvData();
            InitTrendsData();
            TaskStart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool allNull = Array.TrueForAll(valuename, m => m is null);
            if (allNull) { UIMessageBox.Show("请先设置曲线显示！", UILocalize.InfoTitle, Style); return; }
            if (Ctask?.Status == TaskStatus.Running) return;
            if (FormEx.ShowAskDialog(this, "请确认时间范围选择正确？"))
            {
                //开始操作
                BigStartOperation();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CTS?.Cancel();
            Close();
            Dispose(false);
        }
        private void UiLineChart1_PointValue(object sender, UILineSelectPoint[] points)
        {
            foreach (var (point, time, text) in from point in points
                                                let Index = point.Index
                                                let time = DateTime.FromOADate(point.X).AddHours(8)
                                                let TimeText = $"{time.Hour}:{time.Minute}:{time.Second}"
                                                let text = string.Format("名称：{0}，X轴：{1}，Y轴：{2}", point.Series.Name, TimeText, point.Y.ToString("f2"))
                                                select (point, time, text))
                uiToolTip1.SetToolTip(uiLineChart1, text);
        }

        private void uiUpDownRate_ValueChanged(object sender, int value)
        {

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

        private void frmDataPlayback_Load(object sender, EventArgs e)
        {
            dicType.Add("CAN_Data", typeof(CAN_Data.AI));
            dicType.Add("MVB_Data", typeof(MVB_Data.AI));
            dicType.Add("TRDP_Data", typeof(TRDP_Data.AI));
            dicType.Add("Test_Model", typeof(Test_Model));

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
            uibutton[20] = uibt_name20;

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
            uitxt[20] = uibt_value20;

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
            Pcolour[20] = ui_colour20;

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
            uiCheck[20] = ckHide20;
            #endregion

            #region XML配置文件加载
            XmlDocument doc = new();
            doc.Load("TreeXml\\PlaybackTreeXml.xml");
            RecursionTreeControl(doc.DocumentElement, TvProject.Nodes);//将加载完成的XML文件显示在TreeView控件中
            //TvProject.ExpandAll();//展开TreeView控件中的所有项
            TvProject.CollapseAll();//折叠TreeView控件中的所有项
            #endregion

            TvProject.Visible = false;
            ValueName[] va = ValueNameOperation.DataLoading(false);
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

        int index;
        private void uibt_name0_Click(object sender, EventArgs e)
        {
            if (Ctask?.Status == TaskStatus.Running)
                return;

            UIButton uibt = (UIButton)sender;
            index = uibt.TabIndex.ToInt();
            Debug.WriteLine("左键获取index：" + index);
            TvProject.Visible = true;
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
                        MessageBox.Show("已经添加相同项，无法选择！", "系统提示：");
                        TvProject.Visible = false;
                    }

                    //string parentName = parentNode. parentNode.Header.ToString();
                    // 在这里你可以使用parentName进行相应的操作
                }
            }
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

        private void ckHide0_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var check = sender as UICheckBox;
                var key = valuename[check.Tag.ToInt()];
                if (key != null)
                    if (uiLineChart1.Option.Series.TryGetValue(key.NodeName, out UILineSeries value))
                    {
                        value.Visible = !check.Checked;
                        uiLineChart1.Refresh();
                    }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
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

        private void uiBtnEmpty_Click(object sender, EventArgs e)
        {
            if (Ctask?.Status == TaskStatus.Running) { return; }
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
            if (uiLineChart1.FillColor == Color.FromArgb(243, 249, 255))
                uiLineChart1.FillColor = Color.Gray;
            else
                uiLineChart1.FillColor = Color.FromArgb(243, 249, 255);
        }
    }
}
