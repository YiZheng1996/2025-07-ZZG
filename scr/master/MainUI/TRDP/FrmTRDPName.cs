using MainUI.UI.BLL;
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
    public partial class FrmTRDPName : UIForm
    {
        public FrmTRDPName()
        {
            InitializeComponent();
        }
        public FrmTRDPName(string typename)
        {
            InitializeComponent();
            this.TypeName = typename;
        }
        public string TypeName { get; set; }

        ETHConfigBLL vs = new();
        private void FrmTRDPName_Load(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txtConfigFile.Text))
            {
                MessageBox.Show("请输入网关配置文件名称");
                return;
            }
            if (vs.Add(TypeName, txtConfigFile.Text,cboTrdpno.Text) > 0)
            {
                MessageBox.Show("当前数据已存在，请重新输入");
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
            vs.DelDate(id);
            LoadData();
            MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.dataGridView1.SelectedRows[0].Cells["colid"].Value.ToString());
            vs.Modify(id, txtConfigFile.Text, cboTrdpno.Text);
            LoadData();
            MessageBox.Show("更改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                this.cboTrdpno.Text= this.dataGridView1.SelectedRows[0].Cells["colTRDPNo"].Value.ToString().ToString();
                this.txtConfigFile.Text= this.dataGridView1.SelectedRows[0].Cells["colConfigName"].Value.ToString().ToString();
            }
        }
    }
}
