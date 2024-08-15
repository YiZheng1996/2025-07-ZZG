using MainUI.BLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.TRDP
{
    public partial class FrmVersion : UIForm
    {
        public FrmVersion()
        {
            InitializeComponent();
        }
        public FrmVersion(string typename)
        {
            InitializeComponent();
            this.TypeName = typename;
        }
        public string TypeName { get; set; }
        VersionBLL vs = new();

        private void FrmVersion_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            var lst = vs.GetAllPorts(TypeName);
            this.dataGridView1.DataSource = lst;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVersion.Text))
            {
                MessageBox.Show("请输入协议版本号");
                return;
            }
            if (vs.Add(TypeName, txtVersion.Text) > 0)
            {
                MessageBox.Show("当前协议版本号已存在，请重新输入");
                return;
            }
            LoadData();
            MessageBox.Show("增加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selcount = this.dataGridView1.SelectedRows.Count;
            if (selcount == 0)
            {
                MessageBox.Show("请先选择一条数据在删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int id = int.Parse(this.dataGridView1.SelectedRows[0].Cells["colid"].Value.ToString());
            string verno = this.dataGridView1.SelectedRows[0].Cells["colVerName"].Value.ToString().ToString();
            if (vs.GetDate(TypeName, verno) > 0)
            {
                DialogResult dr = MessageBox.Show("当前协议版本存在数据，是否确定删除！", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    vs.DelDate(id, TypeName, verno);
                    LoadData();
                    MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.dataGridView1.SelectedRows[0].Cells["colid"].Value.ToString());
            string verno = this.dataGridView1.SelectedRows[0].Cells["colVerName"].Value.ToString().ToString();
            if (vs.GetDate(TypeName, verno) > 0)
            {
                DialogResult dr = MessageBox.Show("是否更改版本！", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    vs.Modify(id, TypeName, verno, txtVersion.Text);
                    LoadData();
                    MessageBox.Show("更改版本成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
              
            }
        }
    }
}
