using MainUI.Procedure.ExcelImport;
using RW.Log;
using System.Data;
using System.IO;


namespace MainUI.Procedure
{
    public partial class ucExcelImport : UserControl
    {
        private void ucLine_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            InitModelInfo();
        }
        private int modelID { get; set; }
        public ucExcelImport()
        {
            InitializeComponent();
            lblImpTips.Text = "选择数据";
            dataGridView1.RowTemplate.Height = 35;
        }
        public ucExcelImport(int modelID, bool isMVB)
        {
            InitializeComponent();
            this.isMVB = isMVB;
            this.modelID = modelID;
            lblImpTips.Text = "选择数据";
            dataGridView1.RowTemplate.Height = 35;
        }

        /// <summary>
        /// Excel路径
        /// </summary>
        public string ExcelPath { get; set; }

        public bool isMVB { get; set; }

        /// <summary>
        /// 当前选择型号的ID
        /// </summary>
        public int ModelID { get; set; }
        ModelBLL bll = new();
        public void InitModelInfo()
        {
            DataTable dt = bll.GetList();
            cboModelName.ValueMember = "ID";
            cboModelName.DisplayMember = "Name";
            cboModelName.DataSource = dt;
            cboModelName.SelectedValue = modelID;
        }

        private void btnExcelImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenExcel = new()
            {
                CheckFileExists = true,
                Filter = "Excel文件|*.xls;*.xlsx",
                InitialDirectory = @"D:\",
                RestoreDirectory = true
            };
            string fileType = ".xls,.xlsx";
            if (OpenExcel.ShowDialog() == DialogResult.OK)
            {
                lblImpTips.Text = "正在导入···";
                string FileExcelPath = OpenExcel.FileName;              //获取文件路径
                string FileExcelName = Path.GetFileName(FileExcelPath); //获取文件扩展名和文件名
                string FileEx = Path.GetExtension(FileExcelName);       //获取文件的扩展名
                txtPath.Text = ExcelPath = FileExcelPath;
                ImportExcel imp = new();
                if (fileType.Contains(FileEx))
                {
                    try
                    {
                        DataTable ExcelTable = ExcelHelper.GetExcelDataTable(ExcelPath);
                        DataTable dt = imp.ModifyDataColumNmae(ExcelTable);
                        string tableName = isMVB ? tableName = "FullTags" : tableName = "CANFullTags";
                        imp.InsertExcelDataNew(ExcelTable, modelID, tableName, cboModelName.Text);
                        int cnt = ExcelTable.Rows.Count;
                        GetConfigInfo();
                        lblImpTips.Text = "导入成功";
                        MessageBox.Show($"导入成功。记录数：{cnt}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        string err = ex.Message;
                        LogHelper.WriteLine(err);
                        lblImpTips.Text = "导入失败";
                        MessageBox.Show("导入数据错误：" + err);
                    }
                }
                else
                    MessageBox.Show("文件类型不对", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboModelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModelName.Items.Count < 1)
                return;

            GetConfigInfo();
        }

        private void GetConfigInfo()
        {
            try
            {
                if (modelID <= 0) { MessageBox.Show(this, "请先添加型号后进行参数配置！", "系统提示"); return; }
                string tableName = isMVB ? tableName = "FullTags" : tableName = "CANFullTags";
                MVBTagsBLL tags = new(tableName);
                var dt = tags.GetAllTagsByPort(modelID);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                string err = "查询数据有误，具体原因：" + ex.Message;
                LogHelper.WriteLine(err);
                MessageBox.Show(err, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExportEexcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("记录为空，不能导出。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string fileName = cboModelName.Text + "信号定义表.xlsx";
                ExcelHelper.ExportExcel(fileName, dataGridView1);
            }
            catch (Exception ex)
            {
                string err = "导出到Excel错误，具体原因：" + ex.Message;
                LogHelper.WriteLine(err);
                MessageBox.Show(err, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
