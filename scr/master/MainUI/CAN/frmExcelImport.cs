namespace MainUI.CAN
{
    public partial class frmExcelImport : UIForm
    {
        public frmExcelImport(int modelID)
        {
            InitializeComponent();
            ucExcelImport ucExcel = new(modelID);
            Controls.Add(ucExcel);
            Text = "[CAN]Excel数据导入";
        }

        private void uibtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
