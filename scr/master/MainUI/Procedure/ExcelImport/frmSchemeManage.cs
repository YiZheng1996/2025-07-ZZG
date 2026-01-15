using System.IO;
using RW.Log;

namespace MainUI.Procedure.ExcelImport;

/// <summary>
///     配方管理窗口
///     基于原有ucLine界面修改，用于管理一键切换配方
/// </summary>
public partial class frmSchemeManage : UIForm
{
    private readonly DODIConfigBLL bll = new();
    private readonly ImportExcel imp = new();
    private int currentSchemeId;

    public frmSchemeManage()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterParent;
    }

    private void frmSchemeManage_Load(object sender, EventArgs e)
    {
        LoadSchemes();
        lblImpTips.Text = "选择数据";
        dataGridView1.RowTemplate.Height = 35;
    }

    #region 配方管理

    /// <summary>
    ///     加载所有配方
    /// </summary>
    private void LoadSchemes()
    {
        try
        {
            var dt = bll.GetAllSchemes();
            cboScheme.DisplayMember = "SchemeName";
            cboScheme.ValueMember = "ID";
            cboScheme.DataSource = dt;

            if (cboScheme.Items.Count <= 0) return;
            // 优先选中默认配方
            var defaultScheme = bll.GetDefaultScheme();
            if (defaultScheme != null)
                cboScheme.SelectedValue = defaultScheme["ID"];
            else
                cboScheme.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show("加载配方列表失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// 配方选择改变
    /// </summary>
    private void cboScheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboScheme.SelectedValue == null) return;

        currentSchemeId = Convert.ToInt32(cboScheme.SelectedValue);
        LoadSchemeConfig(currentSchemeId);
        UpdateSchemeInfo();
    }

    /// <summary>
    /// 更新配方信息显示
    /// </summary>
    private void UpdateSchemeInfo()
    {
        if (currentSchemeId == 0) return;

        try
        {
            var scheme = bll.GetSchemeById(currentSchemeId);
            if (scheme != null)
            {
                txtSchemeDesc.Text = scheme["SchemeDesc"]?.ToString() ?? "";
                chkIsDefault.Checked = Convert.ToBoolean(scheme["IsDefault"]);
            }
        }
        catch (Exception ex)
        {
            LogHelper.WriteLine("更新配方信息失败：" + ex.Message);
        }
    }

    /// <summary>
    /// 加载配方配置数据
    /// </summary>
    private void LoadSchemeConfig(int schemeId)
    {
        try
        {
            var dt = bll.GetAllConfigBySchemeID(schemeId);
            dataGridView1.DataSource = dt;
            grpData.Text = $"配置明细（{dt.Rows.Count}条）";
        }
        catch (Exception ex)
        {
            MessageBox.Show("加载配置数据失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// 新增配方
    /// </summary>
    private void btnAddScheme_Click(object sender, EventArgs e)
    {
        var schemeName = "";
        if (ShowInputDialog("新增配方", "请输入配方名称：", ref schemeName) == DialogResult.OK)
        {
            if (string.IsNullOrWhiteSpace(schemeName))
            {
                MessageBox.Show("配方名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newId = bll.AddScheme(schemeName, "");
                LoadSchemes();
                cboScheme.SelectedValue = newId;
                MessageBox.Show("配方创建成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建配方失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    /// <summary>
    /// 删除配方
    /// </summary>
    private void btnDeleteScheme_Click(object sender, EventArgs e)
    {
        if (currentSchemeId == 0)
        {
            MessageBox.Show("请先选择一个配方！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (MessageBox.Show($"确定要删除配方【{cboScheme.Text}】吗？\n删除后将无法恢复！", "确认删除",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            try
            {
                bll.DeleteScheme(currentSchemeId);
                LoadSchemes();
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除配方失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

    /// <summary>
    ///     设为默认配方
    /// </summary>
    private void btnSetDefault_Click(object sender, EventArgs e)
    {
        if (currentSchemeId == 0)
        {
            MessageBox.Show("请先选择一个配方！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            bll.SetDefaultScheme(currentSchemeId);
            chkIsDefault.Checked = true;
            MessageBox.Show($"已将【{cboScheme.Text}】设为默认配方！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("设置默认配方失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    ///     保存配方描述
    /// </summary>
    private void btnSaveDesc_Click(object sender, EventArgs e)
    {
        if (currentSchemeId == 0)
        {
            MessageBox.Show("请先选择一个配方！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            bll.UpdateScheme(currentSchemeId, cboScheme.Text, txtSchemeDesc.Text);
            MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("保存失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion

    #region Excel导入导出

    /// <summary>
    ///     从Excel导入配置
    /// </summary>
    private void btnExcelImport_Click(object sender, EventArgs e)
    {
        if (currentSchemeId == 0)
        {
            MessageBox.Show("请先选择或创建一个配方！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var openExcel = new OpenFileDialog
        {
            CheckFileExists = true,
            Filter = "Excel文件|*.xls;*.xlsx",
            InitialDirectory = @"D:\",
            RestoreDirectory = true
        };
        var fileType = ".xls,.xlsx";

        if (openExcel.ShowDialog() == DialogResult.OK)
        {
            lblImpTips.Text = "正在导入...";
            var fileExcelPath = openExcel.FileName;
            var fileEx = Path.GetExtension(fileExcelPath);
            txtPath.Text = fileExcelPath;

            if (fileType.Contains(fileEx))
                try
                {
                    // 读取Excel数据
                    var excelTable = ExcelHelper.GetExcelDataTable(fileExcelPath);

                    // 处理列名
                    var dt = imp.ModifyColumNmae(excelTable);

                    // 验证数据
                    string validateResult = imp.ValidateExcelData(dt);
                    if (!string.IsNullOrEmpty(validateResult))
                    {
                        MessageBox.Show(validateResult, "数据验证失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblImpTips.Text = "导入失败";
                        return;
                    }

                    // 导入到配方
                    imp.InsertExcelDataToScheme(dt, currentSchemeId);

                    // 刷新显示
                    LoadSchemeConfig(currentSchemeId);
                    lblImpTips.Text = "导入成功";
                    MessageBox.Show($"导入成功，共{dt.Rows.Count}条记录！", "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    var err = ex.Message;
                    LogHelper.WriteLine("导入失败：" + err);
                    lblImpTips.Text = "导入失败";
                    MessageBox.Show("导入数据错误：" + err, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
                MessageBox.Show("文件类型不正确，请选择Excel文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    /// <summary>
    ///     导出到Excel
    /// </summary>
    private void btnExportExcel_Click(object sender, EventArgs e)
    {
        if (dataGridView1.Rows.Count < 1)
        {
            MessageBox.Show("没有数据可导出！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var fileName = cboScheme.Text + "_配置表.xlsx";
            ExcelHelper.ExportExcel(fileName, dataGridView1);
            MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("导出失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    ///     从现有型号复制配置
    /// </summary>
    private void btnCopyFromModel_Click(object sender, EventArgs e)
    {
        if (currentSchemeId == 0)
        {
            MessageBox.Show("请先选择或创建一个配方！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 弹出型号选择窗口
        using (frmModelSelect modelSelect = new frmModelSelect())
        {
            if (modelSelect.ShowDialog() == DialogResult.OK)
            {
                int modelId = modelSelect.SelectedModelId;
                string modelName = modelSelect.SelectedModelName;

                if (MessageBox.Show($"确定要从型号【{modelName}】复制配置到当前配方吗？\n当前配方的配置将被覆盖！",
                        "确认复制", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    try
                    {
                        bll.CopyFromModelToScheme(currentSchemeId, modelId);
                        LoadSchemeConfig(currentSchemeId);
                        MessageBox.Show("复制成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("复制失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
    }

    #endregion

    #region 辅助方法

    /// <summary>
    ///     简单的输入对话框
    /// </summary>
    private DialogResult ShowInputDialog(string title, string prompt, ref string value)
    {
        var inputForm = new Form
        {
            Width = 400,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = title,
            StartPosition = FormStartPosition.CenterParent,
            MaximizeBox = false,
            MinimizeBox = false
        };

        var label = new Label { Left = 20, Top = 20, Text = prompt, Width = 340 };
        var textBox = new TextBox { Left = 20, Top = 45, Width = 340 };
        var buttonOk = new Button { Text = "确定", Left = 200, Width = 75, Top = 80, DialogResult = DialogResult.OK };
        var buttonCancel = new Button
            { Text = "取消", Left = 285, Width = 75, Top = 80, DialogResult = DialogResult.Cancel };

        buttonOk.Click += (s, e) => { inputForm.Close(); };
        buttonCancel.Click += (s, e) => { inputForm.Close(); };

        inputForm.Controls.Add(label);
        inputForm.Controls.Add(textBox);
        inputForm.Controls.Add(buttonOk);
        inputForm.Controls.Add(buttonCancel);
        inputForm.AcceptButton = buttonOk;
        inputForm.CancelButton = buttonCancel;

        var result = inputForm.ShowDialog();
        value = textBox.Text;
        return result;
    }

    /// <summary>
    ///     关闭按钮
    /// </summary>
    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion
}