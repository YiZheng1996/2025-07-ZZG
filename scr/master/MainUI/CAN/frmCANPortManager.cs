using System.Data;

namespace MainUI.CAN
{
    public partial class frmCANPortManager : UIForm
    {
        CANPortsBLL ports = new("CANPorts");
        public frmCANPortManager()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmPortManager_Load(object sender, EventArgs e)
        {
            ModelBLL bll = new();
            DataTable dt = bll.GetAllKind();
            cboModelName.DisplayMember = "Name";
            cboModelName.ValueMember = "ID";
            cboModelName.DataSource = dt;
            LoadData();
        }

        void LoadData()
        {
            var lst = ports.GetAllPorts(cboModelName.SelectedValue.ToInt());
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
                CANPorts port = dataGridView1.SelectedRows[0].DataBoundItem as CANPorts;
                txtID.Text = port.ID.ToString();
                txtPortName.Text = port.PortName;
                txtPort.Text = port.CANID;
                nudRate.Value = port.Rate;
                radSource.Checked = !port.IsRead;
                radHost.Checked = port.IsRead;
                cboBaudRate.Text = port.BaudRate;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string portName = txtPortName.Text;
            string port = txtPort.Text;
            int rate = nudRate.Value;
            bool isRead = radHost.Checked;
            string baudRate = cboBaudRate.Text;
            CANPorts p = new()
            {
                ID = id,
                PortName = portName,
                CANID = port,
                IsRead = isRead,
                Rate = rate,
                ModelNameID = cboModelName.SelectedValue.ToInt(),
                BaudRate = baudRate,
            };
            ports.Modify(p);
            LoadData();
            MessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddPort_Click(object sender, EventArgs e)
        {
            string portName = txtPortName.Text;
            string port = txtPort.Text;
            int rate = nudRate.Value;
            bool isRead = radHost.Checked;
            string baudRate = cboBaudRate.Text;
            int ModelID = cboModelName.SelectedValue.ToInt();
            CANPorts p = new()
            {
                PortName = portName,
                CANID = port,
                IsRead = isRead,
                Rate = rate,
                ModelNameID = ModelID,
                BaudRate = baudRate,
            };

            if (ports.AddPort(p) > 0)
            {
                MessageBox.Show(string.Format("当前型号，[{0}]CANID已存在,请修改CANID后再重新添加！", p.CANID), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoadData();
            MessageBox.Show("增加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelPort_Click(object sender, EventArgs e)
        {
            int selcount = dataGridView1.SelectedRows.Count;
            int ModelID = cboModelName.SelectedValue.ToInt();
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
                ports.DelPortHost(id, "CANPorts");
                ports.DelPortFullTags(ModelID, port, "CANFullTags");
                LoadData();
                MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            CAN.frmExcelImport frmExcelImport = new(cboModelName.SelectedValue.ToInt());
            frmExcelImport.ShowDialog();
        }

        private void cboModelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var modelID = cboModelName.SelectedValue.ToInt();
            var lst = ports.GetAllPorts(modelID);
            dataGridView1.DataSource = lst;
        }
    }
}
