using RW;
using ServoTired.BLL;
using ServoTired.Model;
using Sunny.UI;
using System.Windows.Forms;

namespace ServoTired
{
    public partial class frmParaSet : UIForm
    {
        private ServoTiredBLL ServoBLL = new();
        private PointBLL pointBLL = new();
        public frmParaSet() => InitializeComponent();

        private void InitTable() => uiDataGridView1.DataSource = ServoBLL.GetServoTiredTable(cobGearType.SelectedIndex);

        private void cobGearType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindComboBox(cobGearType.SelectedIndex);
            InitTable();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (UpStep.Value == 0 || UpGearPpositionTime.Value == 0) { UIMessageBox.Show("值不能为空！"); return; }
            if (cobStartPosition.SelectedIndex == cobStopPosition.SelectedIndex) { UIMessageBox.Show("开始位置，结束位置一致！"); return; }

            ServoTiredModel model = new()
            {
                Speed = UpSpeed.Value,
                StepNumber = UpStep.Value,
                SGearType = cobGearType.SelectedIndex,
                ResidenceTime = UpGearPpositionTime.Value,
                StartPositionID = cobStartPosition.SelectedValue.ToInt32(),
                StopPositionID = cobStopPosition.SelectedValue.ToInt32(),
            };

            if (ServoBLL.ModifyOrAddTable(model))
            {
                InitTable();
                UIMessageBox.Show("保存成功！");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmParaSet_Load(object sender, EventArgs e)
        {
            cobGearType.SelectedIndex = 0;
            uiDataGridView1.ClearSelection();
        }

        private void BindComboBox(int type)
        {
            Helper.BindComboBox(cobStartPosition, "GearPposition", "ID", dataSource: pointBLL.GetPoints(type));
            Helper.BindComboBox(cobStopPosition, "GearPposition", "ID", dataSource: pointBLL.GetPoints(type));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (ServoBLL.DelTable(UpStep.Value))
            {
                InitTable();
                UIMessageBox.Show("删除成功！");
            }
        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count > 0)// 确保有行被选中
            {
                var selectedRow = uiDataGridView1.SelectedRows[0];
                cobGearType.SelectedIndex = selectedRow.Cells["colGearType"].Value.ToInt32();
                UpStep.Value = selectedRow.Cells["colStepNumber"].Value.ToInt32();
                UpGearPpositionTime.Value = selectedRow.Cells["colResidenceTime"].Value.ToInt32();
                UpSpeed.Value = selectedRow.Cells["colSpeed"].Value.ToInt32();
                cobStartPosition.SelectedValue = selectedRow.Cells["colStartPositionID"].Value.ToInt32();
                cobStopPosition.SelectedValue = selectedRow.Cells["colStopPositionID"].Value.ToInt32();
            }
        }
    }
}
