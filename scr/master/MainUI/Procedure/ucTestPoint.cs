using MainUI.BLL.TirdTest;
using System.Data;

namespace MainUI.Procedure
{
    public partial class ucTestPoint : ucBaseManagerUI
    {
        public ucTestPoint()
        {
            InitializeComponent();

            ModelNmaeData();
            TestTypeData();
            ModelID = cbxModelName.SelectedValue.ToInt();
            LoadData();
        }

        public int ModelID { get; set; }

        TestProcessBLL Process = new TestProcessBLL();
        TirdTestProcessBLL tirdProcess = new TirdTestProcessBLL();

        private void ModelNmaeData()
        {
            ModelBLL bll = new ModelBLL();
            DataTable dt = bll.GetAllKind();
            cbxModelName.Items.Clear();

            cbxModelName.DataSource = dt;
            cbxModelName.DisplayMember = "Name";
            cbxModelName.ValueMember = "ID";
        }

        private void TestTypeData()
        {
            cbxTestType.Items.Add("例行试验");
            cbxTestType.Items.Add("疲劳试验");
            cbxTestType.SelectedIndex = 0;
        }


        private void LoadData()
        {
            if (cbxTestType.SelectedIndex > 0)
                LoadTirdData();
            else
                LoadRoutineData();
        }

        /// <summary>
        /// 例行试验查询
        /// </summary>
        private void LoadRoutineData()
        {
            DataTable dt = Process.GetDataAll(ModelID);
            dataGridView1.DataSource = dt.DefaultView;
        }

        /// <summary>
        /// 疲劳试验查询
        /// </summary>
        private void LoadTirdData()
        {
            DataTable dt = tirdProcess.GetDataAll(ModelID);
            dataGridView1.DataSource = dt.DefaultView;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectID();
                if (id > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    string ColProcessName = row.Cells["ColProcessName"].Value.ToString();
                    string ColFlipToTheLine = row.Cells["ColFlipToTheLine"].Value.ToString();

                    if (cbxTestType.SelectedIndex > 0)
                        tirdProcess.UpData(ColProcessName, ColFlipToTheLine, id);
                    else
                        Process.UpData(ColProcessName, ColFlipToTheLine, id);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                MessageBox.Show(this, $"修改失败：" + err);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectID();
                if (id != -1)
                {
                    int sort = 0;
                    string ProcessKey = "";
                    string ProcessName = dataGridView1.SelectedRows[0].Cells["ColProcessName"].Value.ToString();
                    string FlipToTheLine = dataGridView1.SelectedRows[0].Cells["ColFlipToTheLine"].Value.ToString();

                    if (cbxTestType.SelectedIndex > 0)
                    {
                        sort = tirdProcess.GetSort();
                        ProcessKey = $"TestValueKey{sort.ToString().PadLeft(2, '0')}";
                        tirdProcess.AddData(ProcessKey, ProcessName, sort, FlipToTheLine, ModelID);
                    }
                    else
                    {
                        sort = Process.GetSort(ModelID);
                        sort += 1;
                        ProcessKey = $"TestValueKey{sort.ToString().PadLeft(2, '0')}";
                        Process.AddData(ProcessKey, ProcessName, sort, FlipToTheLine, ModelID);
                    }

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                MessageBox.Show(this, $"新增失败：" + err);
            }
        }


        public int GetID(DataGridViewRow row)
        {
            int id = row.Cells["ColID"].Value.ToInt();
            return id;
        }

        private int GetSelectID()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "请先选择一条记录。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            return GetID(row);
        }

        private void BtnDele_Click(object sender, EventArgs e)
        {
            int id = GetSelectID();
            if (id == 0)
            {
                MessageBox.Show("没有可以删除的数据！");
                return;
            }

            if (MessageBox.Show("删除后无法恢复，确定要删除该条记录吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (cbxTestType.SelectedIndex > 0)
                    tirdProcess.DelDataID(id);
                else
                    Process.DelDataID(id);

                LoadData();
            }
        }

        private void cbxModelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelID = cbxModelName.SelectedValue.ToInt();
            LoadData();
        }

        private void cbxTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
