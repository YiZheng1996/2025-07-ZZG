using MainUI.ViewModel;
using System.Data;

namespace MainUI.Procedure
{
    public partial class ucTestStep : ucBaseManagerUI
    {
        public ucTestStep()
        {
            InitializeComponent();
        }

        private void ucTestStep_Load(object sender, EventArgs e)
        {
            LoadModel();
            LoadProcess();
            //this.ModelID = testBLL.GetModelID(this.Model);
        }

        public override void Reload()
        {
            LoadModel();
            LoadProcess();
            LoadConfiguaredProcess();
        }


        private void LoadModel()
        {
            try
            {
                ModelBLL modelBll = new();
                DataTable dt = modelBll.GetList();
                this.lstModel.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    //this.lstModel.Items.Add(row["Sort"].ToString().PadLeft(0, '2') + row["Name"]);
                    this.lstModel.Items.Add(row["Name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载型号有误。" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        List<TestProcess> FullProcessList = new List<TestProcess>();
        private void LoadProcess()
        {
            TestProcessBLL bll = new TestProcessBLL();
            List<TestProcess> lst = bll.GetAll(this.ModelID);
            FullProcessList = lst;
            this.lstAllPoint.Items.Clear();
            foreach (TestProcess item in lst)
            {
                this.lstAllPoint.Items.Add(item.ProcessName);
            }
        }

        List<TestStep> steps = new List<TestStep>();
        TestProcessBLL testBLL = new TestProcessBLL();
        public string Model { get; set; }
        public int ModelID { get; set; }
        public int ModelSort { get; set; } //下标


        void LoadConfiguaredProcess()
        {
            TestStepBLL bll = new();
            //object item = this.lstMotor.SelectedItem;
            string model = lstModel.Text?.ToString();
            //if (item == null) return;
            steps = bll.GetStep(model);
            this.lstTestPoint.Items.Clear();
            foreach (TestStep step in steps)
            {
                foreach (TestProcess p in FullProcessList)
                {
                    if (p.ProcessKey == step.ProcessKey)
                    {
                        this.lstTestPoint.Items.Add(p.ProcessName);
                        this.lstAllPoint.Items.Remove(p.ProcessName);
                        break;
                    }
                }
            }
        }


        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            int from = this.lstTestPoint.SelectedIndex;
            if (from == -1)
            {
                MessageBox.Show("没有选中任何数据，无法移动。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (from == 0)
            {
                MessageBox.Show("已经是第一条数据，无法上移。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChangePosition(from, from - 1);
        }

        private void ChangePosition(int fromIndex, int toIndex)
        {
            object from = this.lstTestPoint.Items[fromIndex];
            object to = this.lstTestPoint.Items[toIndex];
            this.lstTestPoint.Items.Insert(fromIndex, to);
            this.lstTestPoint.Items.RemoveAt(fromIndex + 1);
            this.lstTestPoint.Items.Insert(toIndex, from);
            this.lstTestPoint.Items.RemoveAt(toIndex + 1);
            this.lstTestPoint.SelectedIndex = toIndex;
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            int from = this.lstTestPoint.SelectedIndex;
            if (from == -1)
            {
                MessageBox.Show("没有选中任何数据，无法移动。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (from == this.lstTestPoint.Items.Count - 1)
            {
                MessageBox.Show("已经是最后一条数据，无法下移。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChangePosition(from, from + 1);
        }



        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveTo(lstAllPoint, lstTestPoint);
        }


        //将一个(from)listbox的item移动到另一个(to)listbox中。
        private void MoveTo(UIListBox from, UIListBox to)
        {
            for (int i = 0; i < from.SelectedItems.Count; i++)
            {
                to.Items.Add(from.SelectedItems[i]);
            }
            to.ClearSelected();
            to.SelectedIndex = to.Items.Count - 1;
            int beforeIndex = -1;
            while (from.SelectedItems.Count > 0)
            {
                beforeIndex = from.SelectedIndex;
                from.Items.Remove(from.SelectedItems[0]);
            }

            if (from.Items.Count == beforeIndex)
                from.SelectedIndex = beforeIndex - 1;
            else
                from.SelectedIndex = beforeIndex;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveTo(lstTestPoint, lstAllPoint);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string model = lstModel.Text;
            DialogResult dr = MessageBox.Show(string.Format("确定要清空的[{0}]所有试验项点吗？", model), "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                TestStepBLL bll = new();
                bll.ClearSteps(model);
                this.LoadConfiguaredProcess();
                this.LoadProcess();
                MessageBox.Show("清空成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Model))
            {
                MessageBox.Show("请先选择型号！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string model = this.lstModel.Text.ToString();

            List<TestStep> steps = new List<TestStep>();
            for (int i = 0; i < lstTestPoint.Items.Count; i++)
            {
                TestStep step = new TestStep();
                step.Step = i;
                step.Sort = i;
                for (int j = 0; j < FullProcessList.Count; j++)
                {
                    if (FullProcessList[j].ProcessName == lstTestPoint.Items[i].ToString())
                    {
                        step.ProcessKey = FullProcessList[j].ProcessKey;
                        step.ProcessName = FullProcessList[j].ProcessName;
                        step.DSLName = FullProcessList[j].DSLName;
                        step.ReportRow = FullProcessList[j].ReportRow;
                        step.ModelID = FullProcessList[j].ModelID;
                        break;
                    }
                }
                //step.ProcessName = lstTestPoint.Items[i].ToString();
                step.Model = model;
                steps.Add(step);
            }
            TestStepBLL bll = new TestStepBLL();
            // bll.SaveSteps(steps, model, repairing, testType);
            bll.SaveSteps(steps, model);

            MessageBox.Show("保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstModel.SelectedIndex >= 0)
            {
                this.Model = this.lstModel.SelectedItem.ToString();
                this.ModelID = testBLL.GetModelID(this.Model);
                LoadProcess();
                LoadConfiguaredProcess();
            }
        }

        private void lstTestPoint_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EnditTest(sender as ListBox);
        }

        private void lstAllPoint_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EnditTest(sender as ListBox);
        }


        /// <summary>
        /// 修改对应项点自动试验逻辑
        /// </summary>
        /// <param name="lstbox"></param>
        private void EnditTest(ListBox lstbox)
        {
            //try
            //{
            //    if (lstModel.Items.Count > 0 & lstbox.Items.Count > 0)
            //    {
            //        TestProcessBLL bll = new TestProcessBLL();
            //        string LstName = lstbox.SelectedItem.ToString();
            //        string LstIndex = lstbox.SelectedIndex.ToString();
            //        string ModelName = lstModel.SelectedItem.ToString();
            //        ModelSort = bll.GetSort(this.ModelID, LstName);
            //        string xuhao = ModelSort.ToString().PadLeft(2, '0');
            //        string TestPath = $"{Application.StartupPath}\\Procedure\\{ModelName}\\{xuhao}{LstName}.rw1";
            //        Debug.WriteLine($"选择型号：{ModelName},选择下标：{LstIndex},选择项点：{LstName}，路径：{TestPath}");
            //        FrmStepEdit stopedit = new FrmStepEdit(TestPath, ModelName, LstName);
            //        stopedit.ShowDialog();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    string err = ex.Message;
            //    MessageBox.Show(this, $"获取自动试验逻辑失败：{err}");
            //}


        }

    }
}
