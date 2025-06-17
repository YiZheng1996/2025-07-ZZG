using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RW.UI.Manager;
using MainUI.Model;
using MainUI.BLL;
using MainUI.Config;
using MainUI.Properties;
using MainUI.CurrencyHelper;

namespace MainUI.Procedure
{
    public partial class ucTestParams : ucBaseManagerUI
    {
        ParaConfig paraconfig = new();
        WorkOrderConfig workconfig = new();
        public ucTestParams()
        {
            InitializeComponent();
        }
        private void ucTestParams_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 数据初始化
        /// </summary>
        private void LoadConfig()
        {
            try
            {
                paraconfig = new ParaConfig();
                paraconfig.SetSectionName(txtModel.Text);
                paraconfig.Load();
                txtRpt.Text = paraconfig.RptFile;
                txtbigTestNumber.Text = paraconfig.bigTestNumber.ToString();
                txtsmallTestNumber.Text = paraconfig.smallTestNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 确定
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtModel.Text))
                {
                    MessageBox.Show("请选择产品后保存", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                paraconfig.SetSectionName(txtModel.Text);
                paraconfig.bigTestNumber = txtbigTestNumber.Text.ToInt();
                paraconfig.smallTestNumber = txtsmallTestNumber.Text.ToInt();
                paraconfig.RptFile = txtRpt.Text;
                paraconfig.Save();
                MessageBox.Show("保存成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败。" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtModel.Text))
                LoadConfig();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new()
            {
                InitialDirectory = Application.StartupPath + "reports\\",
                Filter = "Excel2003|*.xls|Excel2007+|*.xlsx"
            };
            openFile.ShowDialog();
            if (!string.IsNullOrEmpty(openFile.FileName))
            {
                string path = openFile.FileName;
                string[] str = path.Split('\\');
                txtRpt.Text = str[^1];
            }
        }

        //产品选择
        private void btnProductSelection_Click(object sender, EventArgs e)
        {
            frmSpec fs = new frmSpec();
            fs.ShowDialog();
            txtType.Text = Common.mTestViewModel.ModelType;
            txtModel.Text = Common.mTestViewModel.ModelName;
            LoadConfig();
        }

       
    }
}
