using MainUI.BLL;
using MainUI.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MainUI.MVB
{
    public partial class FrmSignal : Form
    {
        public FrmSignal(string portName)
        {
            InitializeComponent();
            this.PortName = portName;
            this.dgvSignal.AutoGenerateColumns = false;
        }
        public FrmSignal()
        {
            InitializeComponent();
            this.dgvSignal.AutoGenerateColumns = false;
        }

        public string PortName { get; set; }

        private void FrmSignal_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvSignal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
        }

        void LoadData()
        {
            
            
                //TagsBLL tags = new TagsBLL();
                //var lst = tags.GetAllTagsByPort(PortName);
                //this.dgvSignal.DataSource = lst;

                //if (lst.Count() == 0)
                //    this.txtPort.Text = PortName;
             
           
        }

        private void dgvSignal_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvSignal.SelectedRows.Count > 0)
            {
                var obj = this.dgvSignal.SelectedRows[0];
                this.txtID.Text = obj.Cells["colID"].Value.ToString();
                this.txtPortName.Text = obj.Cells["colSignalName"].Value.ToString();
                this.cmbDataType.Text = obj.Cells["colDataType"].Value.ToString();
                this.txtPort.Text = obj.Cells["colPortNo"].Value.ToString();
                this.txtByte.Text = obj.Cells["colByteExcursion"].Value.ToString();
                this.txtBit.Text = obj.Cells["colBitExcursion"].Value.ToString();
                this.txtUnit.Text = obj.Cells["colUnit"].Value == null ? "" : obj.Cells["colUnit"].Value.ToString();
                if (Convert.ToBoolean(obj.Cells["colIsLifeSignal"].Value))
                    this.rbtIsTure.Checked = true;
                else
                    this.rbtIsFalse.Checked = true;
                if (Convert.ToBoolean(obj.Cells["ColBigOrLimmit"].Value))
                    this.radBigEndian.Checked = true;
                else
                    this.radLittleEndian.Checked = true;
                this.txtRemark.Text = obj.Cells["colRemark"].Value.ToString();
            }
        }

        private void dgvSignal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.dgvSignal.Columns[e.ColumnIndex].Name == "colIsLifeSignal")
            {
                RW.Components.ControlHelper.Invoke(this.dgvSignal, delegate
                {
                    e.Value = Convert.ToBoolean(e.Value) ? "是" : "否";
                });
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Signal signal = new Signal();
            signal.ID = int.Parse(this.txtID.Text);
            signal.DataLabel = this.txtPortName.Text;
            signal.DataType = this.cmbDataType.Text;
            signal.MVBPort = this.txtPort.Text;
            signal.MVBOffset = int.Parse(this.txtByte.Text);
            signal.MVBBit = int.Parse(this.txtBit.Text);
            signal.Identity = this.rbtIsTure.Checked;
            signal.Description = this.txtRemark.Text;
            signal.DataUnit = this.txtUnit.Text;
            //signal.DataRange = this.radBigEndian.Checked;
            
                TagsBLL tags = new TagsBLL();
                tags.EditTags(signal);
                MessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signal signal = new Signal();
            signal.DataLabel = this.txtPortName.Text;
            signal.DataType = this.cmbDataType.Text;
            signal.MVBPort = this.txtPort.Text;
            signal.MVBOffset = int.Parse(this.txtByte.Text);
            signal.MVBBit = int.Parse(this.txtBit.Text);
            signal.Identity = this.rbtIsTure.Checked;
            signal.Description = this.txtRemark.Text;
            signal.DataUnit = this.txtUnit.Text;
            //signal.DataRange = this.radBigEndian.Checked;
           
                TagsBLL tags = new TagsBLL();
                tags.AddTags(signal);
                MessageBox.Show("增加成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
              
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selcount = this.dgvSignal.SelectedRows.Count;
            if (selcount == 0)
            {
                MessageBox.Show("请先选择一条数据在删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var r = MessageBox.Show("确定要删除吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                int id = int.Parse(this.dgvSignal.SelectedRows[0].Cells["colID"].Value.ToString());
                if (radETH.Checked)
                {
                    ETHTagsBLL tags = new ETHTagsBLL();
                    tags.DelTags(id);
                }  
                else
                {
                    TagsBLL tags = new TagsBLL();
                    tags.DelTags(id);
                }
                MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void radETH_CheckedChanged(object sender, EventArgs e)
        {
            if (radETH.Checked)
            {
                label3.Text = "ComID：";
                groupBox3.Visible = true;
            }

            else
            {
                label3.Text = "端口地址：";
                groupBox3.Visible = false;
            }
               
        }
    }
}
