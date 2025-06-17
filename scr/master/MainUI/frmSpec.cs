using System.Data;
using System.Text;

namespace MainUI
{
    public partial class frmSpec : Form
    {
        public frmSpec()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSpec_Load(object sender, EventArgs e)
        {
            uiDataGridView1.AutoGenerateColumns = false;
            uiDataGridView1.ReadOnly = true;
            BindModels();
            btnGet_Click(this, null);
        }
        ModelTypeBLL pbll = new(VarHelper.Database, VarHelper.ConnectionString, "ModelType");
        Dictionary<string, int> dicType = [];
        /// <summary>
        /// 获取被试品类别列表
        /// </summary>
        private void BindModels()
        {
            DataTable dt = pbll.GetAllModelType();
            cboType.DisplayMember = "ModelType";
            cboType.ValueMember = "ID";
            cboType.DataSource = dt;
            foreach (DataRow item in dt.Rows)
                dicType.Add(item[1].ToString(), Convert.ToInt32(item[0]));
        }
        /// <summary>
        /// 上翻
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.Rows.Count > 0)
            {
                if (this.uiDataGridView1.CurrentRow.Index > 0)
                {
                    int i = uiDataGridView1.Rows.GetPreviousRow(uiDataGridView1.CurrentRow.Index, DataGridViewElementStates.None);//获取原选定上一行索引
                    uiDataGridView1.Rows[i].Selected = true; //选中整行
                    uiDataGridView1.CurrentCell = uiDataGridView1[1, i];//指针上移
                }
            }
        }
        /// <summary>
        /// 下翻
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.Rows.Count > 0)
            {
                if (this.uiDataGridView1.CurrentRow.Index < uiDataGridView1.Rows.Count - 1)
                {
                    int i = uiDataGridView1.Rows.GetNextRow(uiDataGridView1.CurrentRow.Index, DataGridViewElementStates.None);//获取原选定下一行索引
                    uiDataGridView1.Rows[i].Selected = true; //选中整行
                    uiDataGridView1.CurrentCell = uiDataGridView1[1, i];//指针下移
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.Rows.Count == 0)
            {
                return;
            }
            GetModel();
        }

        public void GetModel()
        {
            VarHelper.ModelID = Common.mTestViewModel.ModelID = Convert.ToInt32(uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["colID"].Value);//得到当前选择的型号ID
            Common.mTestViewModel.ModelType = uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["TypeName"].Value.ToString();//得到当前选择的型号类别
            VarHelper.ModelName = Common.mTestViewModel.ModelName = uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["colUsername"].Value.ToString();//得到当前选择的型号名称
            Common.mTestViewModel.Mark = uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["colPassword"].Value.ToString();//得到当前选择的备注
            DialogResult = DialogResult.OK;
            Close();
            Dispose();
        }

        public DataTable GetData(int TypeId, string ModelName)
        {
            ModelBLL modelBll = new();
            StringBuilder sb = new();
            if (TypeId >= 0)
            {
                sb.AppendFormat(" and b.ID ={0}", TypeId);
            }
            if (ModelName != "")
            {
                sb.AppendFormat(" and Name like '%" + ModelName + "%'");
            }
            DataTable dt = modelBll.GetAllKindByCon(sb.ToString());
            return dt;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                int typeid = -1;
                string model = cboModel.Text;
                if (cboType.SelectedValue == null)
                {
                    typeid = -1;
                }
                else
                    typeid = dicType[cboType.Text.ToString()];

                if (cboModel.SelectedValue == null)
                {
                    model = "";
                }

                DataTable dt = GetData(typeid, model);
                uiDataGridView1.DataSource = dt;

                //DataTable dt = GetData(dicType[cboType.SelectedValue.ToString()], cboModel.Text);
                //uiDataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_Spec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetModel();
        }

        private void cboType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ModelBLL bModel = new();
                DataTable dt2 = bModel.GetAllKindByCon(" and b.ID =" + dicType[cboType.Text.ToString()]);
                cboModel.ValueMember = "ID";
                cboModel.DisplayMember = "Name";
                cboModel.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
