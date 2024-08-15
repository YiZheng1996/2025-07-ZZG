using System;
using System.Windows.Forms;

namespace MainUI.Procedure.ExcelImport
{
    /// <summary>
    /// 借用NPOI 控件导入Excel。
    /// </summary>
    public partial class frmImpExcel : Form
    {
        public frmImpExcel()
        {
            InitializeComponent();
            Controls.Add(new ucLine());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
