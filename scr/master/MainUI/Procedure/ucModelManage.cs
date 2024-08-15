using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainUI.BLL;
using RW.UI.Manager;
using System.Runtime.Versioning;

namespace MainUI.Procedure
{
    [SupportedOSPlatform("windows")]
    public partial class ucModelManage : ucBaseManagerUI
    {
        ModelBLL bll = new();
        string grpTxt = "";

        public ucModelManage()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void ucModelManage_Load(object sender, EventArgs e)
        {
            grpTxt = groupBox1.Text;
            LoadModelType();
            LoadModel();
        }
        private void LoadModelType()
        {
            ModelTypeBLL BLLmodelType = new ModelTypeBLL(VarHelper.Database, VarHelper.ConnectionString, "ModelType");
            DataTable dt = BLLmodelType.GetAllModelType();
            if (dt == null)
                return;
            cboModelType.DataSource = dt;
            cboModelType.DisplayMember = "ModelType";
            cboModelType.ValueMember = "ID";

        }
        private void LoadModel()
        {
            DataTable dt = bll.GetAllKind();


            dataGridView1.DataSource = dt;
            if (dt == null)
                return;
            int cnt = dt.Rows.Count;
            groupBox1.Text = grpTxt + "(" + cnt + ")";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string curModel = txtModelName.Text.Trim();
                if (string.IsNullOrEmpty(curModel))
                    return;
                int typeid = Convert.ToInt32(cboModelType.SelectedValue.ToString());
                string mark = txtChexing.Text;
                if (bll.IsExist(curModel))
                {
                    MessageBox.Show("型号【" + curModel + "】已存在", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (bll.Add(curModel, typeid, mark))
                {
                    MessageBox.Show("新增成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadModel();
                }
                else
                {
                    MessageBox.Show("新增失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("发生错误，新增失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string curModel = txtModelName.Text.Trim();
            string modelID = txtID.Text;
            if (string.IsNullOrEmpty(curModel))
                return;

            if (bll.Delete(modelID))
            {
                MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


                LoadModel();
            }
            else
            {
                MessageBox.Show("删除失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                string curModel = txtModelName.Text.Trim();
                if (string.IsNullOrEmpty(curModel))
                    return;
                int typeid = Convert.ToInt32(cboModelType.SelectedValue.ToString());
                string mark = txtChexing.Text;

                string curID = txtID.Text;
                if (bll.Update(curID, curModel, typeid, mark))
                {

                    MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadModel();
                }
                else
                {
                    MessageBox.Show("修改失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("发生错误，新增失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowCurRecord();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ShowCurRecord();
        }
        private void ShowCurRecord()
        {
            if (dataGridView1.DataSource == null)
                return;
            if (dataGridView1.Rows.Count < 1)
                return;
            string id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id"].Value.ToString();
            //string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["name"].Value.ToString();
            string typeid = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["typeid"].Value.ToString();
            string modeltype = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["modeltype"].Value.ToString();
            string mark = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["mark"].Value.ToString();
            txtID.Text = id;
            txtModelName.Text = name;
            cboModelType.Text = modeltype;
            txtChexing.Text = mark;
        }
    }
}
