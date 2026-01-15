using MainUI.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace MainUI.Procedure.ExcelImport
{
    /// <summary>
    /// 配方选择窗口
    /// 用于一键切换时选择要使用的配方
    /// </summary>
    public partial class frmSchemeSelect : UIForm
    {
        /// <summary>
        /// 选中的配方名称
        /// </summary>
        public string SelectedSchemeName { get; private set; }

        private readonly DODIConfigBLL bll = new DODIConfigBLL();

        public frmSchemeSelect()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frmSchemeSelect_Load(object sender, EventArgs e)
        {
            LoadSchemes();
        }

        /// <summary>
        /// 加载所有配方
        /// </summary>
        private void LoadSchemes()
        {
            try
            {
                DataTable dt = bll.GetAllSchemes();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("没有可用的配方，请先在【配方管理】中创建配方。", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cboScheme.DataSource = dt;
                cboScheme.DisplayMember = "SchemeName";
                cboScheme.ValueMember = "ID";

                // 默认选中默认配方
                var defaultScheme = bll.GetDefaultScheme();
                if (defaultScheme != null)
                {
                    cboScheme.SelectedValue = defaultScheme["ID"];
                }

                UpdateSchemeInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载配方列表失败：" + ex.Message, "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 配方选择变化时更新信息
        /// </summary>
        private void cboScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSchemeInfo();
        }

        /// <summary>
        /// 更新配方信息显示
        /// </summary>
        private void UpdateSchemeInfo()
        {
            if (cboScheme.SelectedValue == null) return;

            try
            {
                int schemeId = Convert.ToInt32(cboScheme.SelectedValue);
                var scheme = bll.GetSchemeById(schemeId);

                if (scheme != null)
                {
                    lblDesc.Text = scheme["SchemeDesc"]?.ToString() ?? "";
                    lblIsDefault.Text = Convert.ToBoolean(scheme["IsDefault"]) ? "【默认配方】" : "";

                    // 显示配置数量
                    var configs = bll.GetConfigBySchemeID(schemeId);
                    lblConfigCount.Text = $"配置点位数：{configs.Count}";
                }
            }
            catch (Exception ex)
            {
                lblDesc.Text = "";
                lblConfigCount.Text = "加载失败：" + ex.Message;
            }
        }

        /// <summary>
        /// 确定按钮
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboScheme.SelectedValue == null)
            {
                MessageBox.Show("请选择一个配方！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int schemeId = Convert.ToInt32(cboScheme.SelectedValue);
            var configs = bll.GetConfigBySchemeID(schemeId);

            if (configs.Count == 0)
            {
                MessageBox.Show("所选配方没有配置数据，请先导入配置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VarHelper.SelectedSchemeId = schemeId;
            SelectedSchemeName = cboScheme.Text;
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

        /// <summary>
        /// 管理配方按钮
        /// </summary>
        private void btnManage_Click(object sender, EventArgs e)
        {
            // 打开配方管理窗口
            using (frmSchemeManage manage = new frmSchemeManage())
            {
                manage.ShowDialog();
                LoadSchemes(); // 刷新列表
            }
        }
    }
}