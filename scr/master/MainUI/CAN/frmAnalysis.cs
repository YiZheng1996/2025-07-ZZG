using MainUI.Procedure.ExcelImport;
using System.Data;
using System.Linq;

namespace MainUI.CAN
{
    public partial class frmAnalysis : UIForm
    {
        public frmAnalysis()
        {
            InitializeComponent();
        }

        DataTable ExcelTable;
        private double average;

        private void uiSymbolButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 设置对话框的属性
            //openFileDialog.InitialDirectory = "D:\\"; // 设置初始目录
            openFileDialog.Filter = "所有文件 (*.*)|*.*|Excel (*.xls;*.xlsx;*.xlsm)|*.xls;*.xlsx;*.xlsm";// 设置筛选器以选择Excel文件
            openFileDialog.FilterIndex = 2; // 设置默认的文件过滤器索引
            openFileDialog.RestoreDirectory = false; // 设置在关闭对话框前还原目录
            if (openFileDialog.ShowDialog() == DialogResult.OK) // 显示对话框
            {
                string filePath = openFileDialog.FileName; //获取选中的文件路径
                ExcelTable = LoadExcelTable(filePath);
                uiDataGridView.DataSource = ExcelTable;
            }
        }

        /// <summary>
        /// 加载全部数据，临时表单
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public DataTable LoadExcelTable(string filePath)
        {
            DataTable ExcelTable = ExcelHelper.GetExcelDataTable(filePath, true);
            DataColumn newColumn = new DataColumn("differTime", typeof(int)); // 添加一个新的列
            ExcelTable.Columns.Add(newColumn);
            string previousLine = ""; // 初始上一行数据为0
            string currentLine = ""; // 初始当前行数据为0
            double result; average = 0;// 计算结果，平均值
            foreach (DataRow row in ExcelTable.Rows)
            {
                row["ID"] = row["ID"].ToString().Replace(" ", "").TrimStart('0'); //去除0及空格
                previousLine = currentLine; // 更新上一行数据
                currentLine = row["Time"].ToString(); // 更新当前行数据
                if (previousLine.IsNullOrEmpty())
                    continue;
                string[] currentLines = currentLine.Split(':');
                string[] previousLines = previousLine.Split(':');
                TimeSpan span = new(0, currentLines[0].ToInt(), currentLines[1].ToInt(), currentLines[2].ToInt(), currentLines[3].ToInt());
                TimeSpan span2 = new(0, previousLines[0].ToInt(), previousLines[1].ToInt(), previousLines[2].ToInt(), previousLines[3].ToInt());
                TimeSpan spanResult = span - span2; // 当前行和上一行的差值
                result = spanResult.TotalMilliseconds;
                average += result;
                row["differTime"] = result;  //为新列添加数据
            }

            uiGroupBox.Text = HeadText(ExcelTable);
            return ExcelTable;
        }

        /// <summary>
        /// 筛选后临时表单
        /// </summary>
        /// <param name="Exceltable"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        private DataTable ScreenDataTable(DataTable Exceltable, string ID)
        {
            try
            {
                DataTable table = new();
                string filter = string.Format("ID = '{0}'", ID);
                DataRow[] selectedRows = Exceltable.Select(filter);
                List<DataRow> rows = [.. selectedRows];

                // 确保DataTable有与List中的DataRow相同的列结构
                foreach (DataRow row in rows)
                {
                    if (table.Columns.Count == 0)
                        foreach (DataColumn column in row.Table.Columns)
                            table.Columns.Add(column.ColumnName, column.DataType);
                }

                average = 0;
                // 将DataRow的数据添加到DataTable中
                foreach (DataRow dr in rows)
                {
                    DataRow newRow = table.NewRow();
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        newRow[table.Columns[i]] = dr[i];
                    }
                    average += dr[9].ToDouble();
                    table.Rows.Add(newRow);
                }
                uiGroupBox.Text = HeadText(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "导入Excel提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new DataTable();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnSeek_Click(object sender, EventArgs e)
        {
            if (ExcelTable == null || ExcelTable.Rows.Count < 1)
                return;

            uiDataGridView.DataSource = ScreenDataTable(ExcelTable, txtCANID.Text.Trim());
            TranslateHead();
        }

        /// <summary>
        /// 重新绑定数据源，初始化
        /// </summary>
        private void TranslateHead()
        {
            foreach (DataGridViewColumn column in uiDataGridView.Columns)
            {
                // 根据需要将英文列头翻译成中文
                switch (column.HeaderText)
                {
                    case "Seq":
                        column.HeaderText = "序号";
                        column.Width = 50;
                        column.DisplayIndex = 0;
                        break;
                    case "Time":
                        column.HeaderText = "时间";
                        column.Width = 120;
                        column.DisplayIndex = 1;
                        break;
                    case "differTime":
                        column.HeaderText = "时间差";
                        column.Width = 120;
                        column.DisplayIndex = 2;
                        break;
                    case "CANInd":
                        column.HeaderText = "通道";
                        column.Width = 70;
                        column.DisplayIndex = 3;
                        break;
                    case "Orentation":
                        column.HeaderText = "方向";
                        column.Width = 100;
                        column.DisplayIndex = 4;
                        break;
                    case "ID":
                        column.HeaderText = "ID号";
                        column.Width = 70;
                        column.DisplayIndex = 5;
                        break;
                    case "Frame":
                        column.HeaderText = "数据帧";
                        column.Width = 100;
                        column.DisplayIndex = 6;
                        break;
                    case "Type":
                        column.HeaderText = "帧类型";
                        column.Width = 100;
                        column.DisplayIndex = 7;
                        break;
                    case "DLC":
                        column.HeaderText = "数据长度";
                        column.Width = 70;
                        column.DisplayIndex = 8;
                        break;
                    case "DATA":
                        column.HeaderText = "数据";
                        column.Width = 258;
                        column.DisplayIndex = 9;
                        break;

                    default:
                        // 保持原样或者设置为自定义的中文名称
                        break;
                }
            }
        }

        /// <summary>
        /// 时间戳差值集合
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        private double get_Average(DataTable table)
        {
            double average = 0.0;
            foreach (var value in table.AsEnumerable().Select(row => row.Field<int?>("differTime")))
            {
                if (!value.HasValue)
                    continue;
                average += value.ToDouble();
                Console.Write(average);
            }
            return average;
        }

        public string HeadText(DataTable table)
        {
            double average = get_Average(table);
            return Text = string.Format("数据总数：{0} 条，平均时间差：{1} ms", table.Rows.Count, Math.Round((average / (table.Rows.Count)), 2));
        }

        private void btnAllDisplay_Click(object sender, EventArgs e)
        {
            if (ExcelTable is null) return;
            uiDataGridView.DataSource = ExcelTable;
            get_Average(ExcelTable);
            uiGroupBox.Text = HeadText(ExcelTable);
            txtCANID.Text = string.Empty;
            TranslateHead();
        }
    }
}
