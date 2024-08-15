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
    /// <summary>
    /// 借用NPOI 控件导入Excel。
    /// </summary>
    public partial class frmETHImpExcel : UIForm
    {
        public frmETHImpExcel()
        {
            InitializeComponent();
        }
        public frmETHImpExcel( string typename)
        {
            InitializeComponent();
            TypeNmae = typename;
        }

        public string TypeNmae { get; set; }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmETHImpExcel_Load(object sender, EventArgs e)
        {
            uceth1.cboModelName.Text = TypeNmae;
        }
    }
}
