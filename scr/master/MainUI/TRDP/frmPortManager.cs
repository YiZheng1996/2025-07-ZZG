using MainUI.BLL;
using MainUI.Model;
using MainUI.UI.BLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainUI.TRDP
{
    public partial class frmPortManager : UIForm
    {
        public frmPortManager()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }
        ModelBLL bll = new();
        private void frmPortManager_Load(object sender, EventArgs e)
        {
            LoadTypeName();
        }

        void LoadTypeName()
        {
            DataTable dt = bll.GetAllKind();
            cboModelName.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string txt = dt.Rows[i]["Name"].ToString();
                cboModelName.Items.Add(txt);
            }

            if (cboModelName.Items.Count > 0)
            {
                cboModelName.SelectedIndex = 0;
            }
        }

        void LoadData()
        {
            ETHPortsBLL ports = new();
            var lst = ports.GetAllPorts(cboModelName.Text.Trim(), txtVerno.Text);
            //if (lst.Count()==0)
            //{ return; }
            dataGridView1.DataSource = lst;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colIsRead")
            {
                bool isRead = Convert.ToBoolean(e.Value);
                e.Value = isRead ? "宿端口" : "源端口";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Ports port = dataGridView1.SelectedRows[0].DataBoundItem as Ports;
                txtID.Text = port.ID.ToString();
                txtPortName.Text = port.PortName;
                txtPort.Text = port.Port;
                nudRate.Value = port.Rate;
                nudDataSize.Value = port.DataSize;
                radSource.Checked = !port.IsRead;
                radHost.Checked = port.IsRead;
                txtVerno.Text = port.VerNo;
                cboETHNo.Text = port.ETHPassage.ToString();
                cbotrdpno.Text = port.TRDPNo.ToString();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtID.Text);
            string portName = txtPortName.Text;
            string port = txtPort.Text;
            int rate = (int)nudRate.Value;
            int dataSize = (int)nudDataSize.Value;
            bool isRead = radHost.Checked;

            Ports p = new Ports()
            {
                ID = id,
                PortName = portName,
                Port = port,
                IsRead = isRead,
                DataSize = dataSize,
                Rate = rate,
                TypeName = cboModelName.Text,
                VerNo = txtVerno.Text,
                ETHPassage = Convert.ToInt32(cboETHNo.Text),
                TRDPNo = Convert.ToInt32(cbotrdpno.Text)
            };

            ETHPortsBLL bll = new ETHPortsBLL();
            bll.Modify(p);
            LoadData();
            MessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddPort_Click(object sender, EventArgs e)
        {
            string portName = txtPortName.Text;
            string port = txtPort.Text;
            int rate = (int)nudRate.Value;
            int dataSize = (int)nudDataSize.Value;
            bool isRead = radHost.Checked;

            Ports p = new()
            {
                PortName = portName,
                Port = port,
                IsRead = isRead,
                DataSize = dataSize,
                Rate = rate,
                TypeName = cboModelName.Text,
                VerNo = txtVerno.Text,
                ETHPassage = Convert.ToInt32(cboETHNo.Text),
                TRDPNo = Convert.ToInt32(cbotrdpno.Text)
            };

            ETHPortsBLL bll = new();
            if (bll.AddPort(p, txtVerno.Text) > 0)
            {
                MessageBox.Show("数据存在冲突,请修改后再重新添加！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoadData();
            MessageBox.Show("增加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelPort_Click(object sender, EventArgs e)
        {

            int selcount = dataGridView1.SelectedRows.Count;
            if (selcount == 0)
            {
                MessageBox.Show("请先选择一条数据在删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var r = MessageBox.Show("确定要删除吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells["colID"].Value.ToString());
                string port = txtPort.Text;
                ETHPortsBLL bll = new();
                if (bll.DelPort(id, port, cboModelName.Text, txtVerno.Text, Convert.ToInt32(cboETHNo.Text)) > 0)
                {
                    DialogResult dr = MessageBox.Show("当前端口存在数据，是否确定删除！", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        ETHTagsBLL tags = new();
                        tags.DelTags(cboModelName.Text, port, txtVerno.Text);
                        bll.DelPort(id, port, cboModelName.Text, txtVerno.Text, Convert.ToInt32(cboETHNo.Text));
                    }
                    else
                        return;
                }

                LoadData();
                MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
 
        private void cboModelName_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadVersion();
        }

        void loadVersion()
        {
            VersionBLL ver = new();
            var lst = ver.GetAllPorts(cboModelName.Text);
            txtVerno.Items.Clear();


            for (int i = 0; i < lst.Rows.Count; i++)
            {
                string txt = lst.Rows[i]["VersionName"].ToString();
                int idx = txtVerno.Items.Add(txt);
            }

            if (txtVerno.Items.Count > 0)
            {
                txtVerno.SelectedIndex = 0;
            }
        }
        public static object CopyDataTags = null;
        public static object CopyDataPorts = null;
        List<ETHSignal> GetSelectedTag()
        {
            ETHTagsBLL tags = new();
            List<ETHSignal> model = new();
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                model = tags.GetAllTagsByPort(item.Cells["colPort"].Value.ToString(), item.Cells["colVerNo"].Value.ToString(), cboModelName.Text);
            }
            return model.OrderBy(x => x.ID).ToList();
        }
        List<Ports> GetSelectedPorts()
        {
            ETHPortsBLL ports = new();
            List<Ports> model = new();
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                model = ports.GetAllTagsByPort(item.Cells["colPort"].Value.ToString(), item.Cells["colVerNo"].Value.ToString(), cboModelName.Text, cboETHNo.Text);
            }
            return model.OrderBy(x => x.ID).ToList();
        }
         
        private void 设置为默认版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ETHPortsBLL bll = new();
            List<Ports> model = new();
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                model.Add(item.DataBoundItem as Ports);
            bll.UpDate(model);
            ETHTagsBLL tag = new();
            tag.UpDate(model);
        }

        private void txtVerno_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            cboETHNo.SelectedIndex = 0;
        }

        private void btnAddVerno_Click(object sender, EventArgs e)
        {
            FrmVersion version = new(cboModelName.Text);
            version.ShowDialog();
            loadVersion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTRDPName trdp = new(cboModelName.Text);
            trdp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmETHImpExcel ethie = new()
            {
                TypeNmae = cboModelName.Text
            };
            ethie.ShowDialog();
        }
    }
}
