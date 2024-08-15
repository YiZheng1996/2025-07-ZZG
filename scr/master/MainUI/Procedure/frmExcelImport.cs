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

namespace MainUI.Procedure
{
    public partial class frmExcelImport : UIForm
    {
        public frmExcelImport()
        {
            InitializeComponent();
        }
        private int modelNameID { get; set; }
        public frmExcelImport(int modelNameID, bool isMVB)
        {
            InitializeComponent();
            this.modelNameID = modelNameID;
            ucExcelImport ucExcel = new(modelNameID, isMVB);
            Controls.Add(ucExcel);
            Text = isMVB ? "[MVB]Excel数据导入" : "[CAN]Excel数据导入";
        }

        private void uibtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
