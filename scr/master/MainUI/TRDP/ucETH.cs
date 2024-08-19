using MainUI.BLL;
using MainUI.Procedure.ExcelImport;
using RW.Log;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace MainUI.TRDP
{
    public partial class ucETH : UserControl
    {
        private void ucLine_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            InitModelInfo();
        }

        public ucETH()
        {
            InitializeComponent();
            lblImpTips.Text = "选择数据";
            dataGridView1.RowTemplate.Height = 35;
        }

        /// <summary>
        /// 主任务ID
        /// </summary>
        public string holdTaskId { get; set; }

        /// <summary>
        /// 子任务ID
        /// </summary>
        public string holdItemId { get; set; }

        /// <summary>
        /// Excel路径
        /// </summary>
        public string ExcelPath { get; set; }


        int[] ModelIDAry = null;

        /// <summary>
        /// 当前选择型号的ID
        /// </summary>
        public int ModelID { get; set; }
        public void InitModelInfo()
        {
            ModelBLL bll = new();
            DataTable dt = bll.GetList();
            cboModelName.Items.Clear();
            ModelIDAry = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string txt = dt.Rows[i]["Name"].ToString();
                int idx = cboModelName.Items.Add(txt);
                ModelIDAry[idx] = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
            }

            if (cboModelName.Items.Count > 0)
            {
                cboModelName.SelectedIndex = 0;
            }
        }


        private string[] TestVehicleCode(string Code)
        {
            string[] Condes = new string[2];
            try
            {
                int Code1 = 0;
                int Code2 = 0;
                if (Code.Contains('（'))
                {
                    Code1 = Code.IndexOf('（');
                    Code2 = Code.IndexOf('）') - 1;
                }
                else if (Code.Contains('('))
                {
                    Code1 = Code.IndexOf('(');
                    Code2 = Code.IndexOf(')') - 1;
                }
                Condes[0] = Code[..Code.IndexOf('（')];
                Condes[1] = Code.Substring(Code1 + 1, Code2 - Code1);
                return Condes;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                //Var.LogInfo(err);
                MessageBox.Show("导入数据错误：" + err);
                return Condes;
            }
        }


        ETHImportExcel imp = new();
        private void btnExcelImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenExcel = new()
            {
                CheckFileExists = true,
                Filter = "Excel文件|*.xls;*.xlsx",
                InitialDirectory = @"D:\HNRWS19080-2 制动柜试验台\docs\以太网配置表",
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

                if (fileType.Contains(FileEx))
                {
                    try
                    {
                        DataTable ExcelTable = ExcelHelper.GetExcelDataTable(ExcelPath);
                        DataTable dt = imp.ModifyColumNmae(ExcelTable);
                        imp.InsertExcelData(ExcelTable, cboModelName.Text);
                        int cnt = ExcelTable.Rows.Count;
                        GetConfigInfo();
                        lblImpTips.Text = "导入成功";
                        MessageBox.Show($"导入成功。记录数：{cnt}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        string err = ex.Message;
                        LogHelper.Append(err);
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
                ETHTagsBLL tags = new();
                var dt = tags.GetAllTagsByPort(cboModelName.Text);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                string err = "查询数据有误，具体原因：" + ex.Message;
                LogHelper.Append(err);
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
                string fileName = cboModelName.Text + "TRDP定义表.xlsx";
                ExcelHelper.ExportExcel(fileName, dataGridView1);
            }
            catch (Exception ex)
            {
                string err = "导出到Excel错误，具体原因：" + ex.Message;
                LogHelper.Append(err);
                MessageBox.Show(err, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
