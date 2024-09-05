using System;
using System.Windows.Forms;
using System.IO;
using MainUI.Model;
using MainUI.BLL;
using RW.Log;
using MainUI.CurrencyHelper;

namespace MainUI
{
    public partial class frmReport : Form
    {
        public TestViewModel viewMole { get; set; }
        public string saveFilepath { get; set; }
        public string Filename { get; set; }  //报表的文件地址
        int rowIndex = 0;

        public frmReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// 关闭
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 上翻
        /// </summary>
        private void btnPageUp_Click(object sender, EventArgs e)
        {
            int value = (int)this.numericUpDown1.Value;
            rowIndex -= value;
            if (rowIndex < 1)
                rowIndex = 1;
        }
        /// <summary>
        /// 下翻
        /// </summary>
        private void btnPageDown_Click(object sender, EventArgs e)
        {
            int value = (int)this.numericUpDown1.Value;
            rowIndex += value;
            if (rowIndex > 100)
                rowIndex = 100;
            
        }
        /// <summary>
        /// 打印
        /// </summary>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TestRecordBLL recordbll = new(VarHelper.Database, VarHelper.ConnectionString, "Record");
                int ret = recordbll.SaveData(viewMole.ModelTypeID.ToString(), viewMole.ModelName, "", viewMole.TestNO, RWUser.User.Username, DateTime.Now.ToString(), saveFilepath);
                if (Directory.Exists(VarHelper.rootRptSave) == false)
                    Directory.CreateDirectory(VarHelper.rootRptSave);
                //rwReport1.SaveAS(saveFilepath);
                
                MessageBox.Show(this, "本地报表保存成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                LogHelper.Append("保存报表失败：" + err);
                MessageBox.Show(err, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 读取key中的值，使用第一个worksheet
        /// </summary>
        /// <returns></returns>
        public object Read(string key)
        {
            //return rwReport1.Read(1, key);
            return "";
        }
        /// <summary>
        /// 将value写入到key中，使用第一个worksheet
        /// </summary>
        public void Write(string key, object value)
        {
            Write(1, key, value);
        }
        /// <summary>
        /// 将value写入到key中，使用指定的worksheet
        /// </summary>
        public void Write(int sheetIndex, string key, object value)
        {
            
        }

        /// <summary>
        /// 插入图片
        /// </summary>
        public void InsertPicture(string key, string PicturePath)
        {
          
        }
    }
}
