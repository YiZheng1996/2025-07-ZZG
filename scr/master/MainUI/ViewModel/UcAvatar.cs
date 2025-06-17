using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.ViewModel
{
    public partial class UcAvatar : UserControl
    {
        Form form;
        public UcAvatar(Form _form)
        {
            form = _form;
            InitializeComponent();
        }

        public UcAvatar()
        {
            InitializeComponent();
        }
        Dictionary<string, int> dicType = [];
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
    }
}
