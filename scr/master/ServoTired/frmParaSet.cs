using MainUI.Config;
using RW;
using ServoTired.BLL;
using ServoTired.Model;
using Sunny.UI;

namespace ServoTired
{
    public partial class frmParaSet : UIForm
    {
        private int SelecteIndex;
        private ServoTiredBLL ServoBLL = new();
        private PointBLL pointBLL = new();
        private ParaConfig para = new("Para");
        public frmParaSet() => InitializeComponent();

        private void InitTable()
        {
            uiDataGridView1.DataSource = ServoBLL.GetServoTiredTable(cobGearType.SelectedIndex);
            uiDataGridView1.SelectedIndex = SelecteIndex;
        }

        private void cobGearType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindComboBox(cobGearType.SelectedIndex);
            InitTable();
            InitCycleTime(cobGearType.SelectedIndex);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (UpStep.Value == 0)
            {
                UIMessageBox.Show("值不能为空！");
                return;
            }
            int GearType = cobGearType.SelectedIndex;
            int ID = uiDataGridView1.Rows.Count == 0 ? 0 : uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["ID"].Value.ToInt32();

            ServoTiredModel model = new()
            {
                ID = ID,
                Speed = UpSpeed.Value,
                StepNumber = UpStep.Value,
                SGearType = GearType,
                ResidenceTime = UpGearPpositionTime.Value,
                StartPositionID = cobStartPosition.SelectedValue.ToInt32(),
            };
            if (ServoBLL.ModifyOrAddTable(model))
            {
                if (GearType == 0)
                {
                    para.BigCycleTime = UpCycleTime.Value;
                }
                else if (GearType == 1)
                {
                    para.SmallCycleTime = UpCycleTime.Value;
                }

                para.TestNumber = UpTestNumber.Value;
                para.Save();
                InitTable();
                InitCycleTime(GearType);
            }
            // 根据总循环时间修改所有停留时间
            List<ServoTiredModelDto> data = ServoBLL.GetServoTiredTable(GearType);
            int CycleTime = GearType != 0 ? para.SmallCycleTime : para.BigCycleTime;
            double average = Math.Round(CycleTime.ToDouble() / data.Count.ToDouble(), 1);
            ServoBLL.UpdateResidenceTime(new ServoTiredModel
            {
                SGearType = GearType,
                ResidenceTime = average,
            });

            InitTable();
            UIMessageBox.Show("保存成功！");
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
            InitCycleTime(cobGearType.SelectedIndex);
        }

        private void InitCycleTime(int type)
        {
            switch (type)
            {
                case 0:
                    UpCycleTime.Value = para.BigCycleTime;
                    break;
                case 1:
                    UpCycleTime.Value = para.SmallCycleTime;
                    break;
                default:
                    break;
            }
        }

        private void BindComboBox(int type)
        {
            Helper.BindComboBox(cobStartPosition, "GearPposition", "ID", dataSource: pointBLL.GetPoints(type));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!FormEx.ShowAskDialog(this, "是否删除？")) return;
            int ID = uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["ID"].Value.ToInt32();
            if (ServoBLL.DelTable(ID))
            {
                InitTable();
                UIMessageBox.Show("删除成功！");
            }
        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (uiDataGridView1.SelectedRows.Count > 0)//确保有行被选中
                {
                    SelecteIndex = uiDataGridView1.SelectedIndex;
                    var selectedRow = uiDataGridView1.SelectedRows[0];
                    cobGearType.SelectedIndex = selectedRow.Cells["colGearType"].Value.ToInt32();
                    UpStep.Value = selectedRow.Cells["colStepNumber"].Value.ToInt32();
                    UpGearPpositionTime.Value = selectedRow.Cells["colResidenceTime"].Value.ToDouble();
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
