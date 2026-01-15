using MainUI.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace MainUI.Procedure.ExcelImport
{
    /// <summary>
    /// 型号选择窗口
    /// 用于从现有型号复制配置到配方
    /// </summary>
    public partial class frmModelSelect : UIForm
    {
        /// <summary>
        /// 选中的型号ID
        /// </summary>
        public int SelectedModelId { get; private set; }

        /// <summary>
        /// 选中的型号名称
        /// </summary>
        public string SelectedModelName { get; private set; }

        private readonly ModelBLL bll = new ModelBLL();

        public frmModelSelect()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frmModelSelect_Load(object sender, EventArgs e)
        {
            LoadModels();
        }

        /// <summary>
        /// 加载所有型号
        /// </summary>
        private void LoadModels()
        {
            try
            {
                DataTable dt = bll.GetList();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("没有可用的型号。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cboModel.DataSource = dt;
                cboModel.DisplayMember = "Name";
                cboModel.ValueMember = "ID";

                UpdateModelInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载型号列表失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 型号选择变化时更新信息
        /// </summary>
        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateModelInfo();
        }

        /// <summary>
        /// 更新型号信息显示
        /// </summary>
        private void UpdateModelInfo()
        {
            if (cboModel.SelectedValue == null) return;

            try
            {
                int modelId = Convert.ToInt32(cboModel.SelectedValue);
                DODIConfigBLL configBll = new DODIConfigBLL();
                var configs = configBll.GetConfigBymodelID(modelId);
                lblConfigCount.Text = $"该型号配置点位数：{configs.Count}";
            }
            catch (Exception ex)
            {
                lblConfigCount.Text = "加载失败：" + ex.Message;
            }
        }

        /// <summary>
        /// 确定按钮
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboModel.SelectedValue == null)
            {
                MessageBox.Show("请选择一个型号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int modelId = Convert.ToInt32(cboModel.SelectedValue);
            DODIConfigBLL configBll = new DODIConfigBLL();
            var configs = configBll.GetConfigBymodelID(modelId);

            if (configs.Count == 0)
            {
                MessageBox.Show("所选型号没有配置数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedModelId = modelId;
            SelectedModelName = cboModel.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}