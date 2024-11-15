using MainUI.Config;
using Sunny.UI;
using System;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainUI.Procedure.SSI
{
    public partial class frmSSI : UIForm
    {
        private readonly SerialPort port = new();
        private readonly SSIConfig sSIConfig = new();
        public frmSSI()
        {
            InitializeComponent();
        }

        public void COMInit()
        {
            try
            {
                InitCOM();
                if (!port.IsOpen)
                    port.Open();
                port.DataReceived += SSIserialPort_DataReceived;
            }
            catch (Exception ex)
            {
                MessageHelper.UIMessageYes(this, "初始化错误：" + ex.Message);
            }
        }

        public void InitCOM()
        {
            if (port.IsOpen) return;
            port.PortName = sSIConfig.COMPort; // 设置串口名称
            port.BaudRate = sSIConfig.BaudRate;   // 设置波特率
            port.ReadTimeout = sSIConfig.ReadTimeout; // 读取数据超时 
            port.Parity = (Parity)sSIConfig.CheckBit; // 设置奇偶校验
            port.DataBits = sSIConfig.DataBits;      // 设置数据位数
            port.StopBits = (StopBits)sSIConfig.StopBits; // 设置停止位
            port.DtrEnable = sSIConfig.Dtr;  //默认false，通讯不上可以尝试
        }

        private void frmSSI_Load(object sender, EventArgs e)
        {
            COMInit();
        }

        private void SSIserialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort sp = (SerialPort)sender;
            //string indata = sp.ReadExisting();
            string text = "";
            int len = port.BytesToRead;
            byte[] buff = new byte[len];
            port.Read(buff, 0, len);
            foreach (var value in buff)
                text += " " + value;
            if (InvokeRequired)
            {
                Invoke(delegate
                {
                    dataGridView1.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"), text);
                    dataGridView1.CurrentCell = dataGridView1.Rows[^1].Cells[0];
                });
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            port.Close();
        }


        private void SaveDataGridViewToCsv(DataGridView dataGridView, string filePath)
        {
            StringBuilder csvContent = new();
            // 添加列标题
            var columnHeaders = dataGridView.Columns.Cast<DataGridViewColumn>();
            csvContent.AppendLine(string.Join(",", columnHeaders.Select(column => $"\"{column.HeaderText}\"")));

            // 添加行数据
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow) // 排除新增行
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    csvContent.AppendLine(string.Join(",", cells.Select(cell => $"\"{cell.Value?.ToString().Replace("\"", "\"\"") ?? string.Empty}\"")));
                }
            }

            // 写入文件
            File.WriteAllText(filePath, csvContent.ToString());
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Save CSV File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveDataGridViewToCsv(dataGridView1, filePath);
                MessageHelper.UIMessageOK("文件保存成功!");
            }
        }
    }
}
