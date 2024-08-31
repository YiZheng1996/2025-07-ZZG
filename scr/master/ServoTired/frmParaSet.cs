using MainUI.Config;
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
        private ParaConfig para = new("Para");
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

            ServoTiredModel model = new()
            {
                Speed = UpSpeed.Value,
                StepNumber = UpStep.Value,
                SGearType = cobGearType.SelectedIndex,
                ResidenceTime = UpGearPpositionTime.Value,
                StartPositionID = cobStartPosition.SelectedValue.ToInt32(),
                //StopPositionID = cobStopPosition.SelectedValue.ToInt32(),
            };

            if (ServoBLL.ModifyOrAddTable(model))
            {
                para.TestNumber = UpTestNumber.Value;
                para.Save();
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
            UpTestNumber.Value = para.TestNumber;
            cobGearType.SelectedIndex = 0;
            uiDataGridView1.ClearSelection();
        }

        private void BindComboBox(int type)
        {
            Helper.BindComboBox(cobStartPosition, "GearPposition", "ID", dataSource: pointBLL.GetPoints(type));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!FormEx.ShowAskDialog(this, "是否删除？")) return;
            if (ServoBLL.DelTable(UpStep.Value))
            {
                InitTable();
                UIMessageBox.Show("删除成功！");
            }
        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (uiDataGridView1.SelectedRows.Count > 0)// 确保有行被选中
                {
                    var selectedRow = uiDataGridView1.SelectedRows[0];
                    cobGearType.SelectedIndex = selectedRow.Cells["colGearType"].Value.ToInt32();
                    UpStep.Value = selectedRow.Cells["colStepNumber"].Value.ToInt32();
                    UpGearPpositionTime.Value = selectedRow.Cells["colResidenceTime"].Value.ToInt32();
                    UpSpeed.Value = selectedRow.Cells["colSpeed"].Value.ToInt32();
                    cobStartPosition.SelectedValue = selectedRow.Cells["colStartPositionID"].Value.ToInt32();
                    //cobStopPosition.SelectedValue = selectedRow.Cells["colStopPositionID"].Value.ToInt32();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.Show("选择数据错误！" + ex.Message);
            }

        }
    }
}
