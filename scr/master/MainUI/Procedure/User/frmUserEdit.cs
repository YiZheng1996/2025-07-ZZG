using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RW.UI.Model;
using RW.UI.BLL;

namespace MainUI.Procedure.User
{
    public partial class frmUserEdit : Form
    {
        public frmUserEdit()
        {
            InitializeComponent();
            InitRadioButton();
        }

        private Model.UserInfo User;
        public frmUserEdit(Model.UserInfo user)
        {
            InitializeComponent();
            InitRadioButton();
            User = user;
            txtUserName.Text = user.Username;
            txtPassword.Text = user.Password;

            string level = user.Permission;
            if (level != null)
                comboBox1.SelectedValue = level;
        }

        void InitRadioButton()
        {
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = RW.Components.User.RWUser.Permissions;
        }

        BLL.UserBLL userBll = new BLL.UserBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (User == null)
                {
                    User = new Model.UserInfo();
                }
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("请选择权限", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                User.Username = this.txtUserName.Text;
                User.Password = this.txtPassword.Text;
                User.Permission = this.comboBox1.Text;

                int count = userBll.Save(User);

                if (count > 0)
                {
                    MessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("保存失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}