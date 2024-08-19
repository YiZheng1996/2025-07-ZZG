using MainUI.Model;
using RW.Components.Core.BLL;
using RW.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.BLL
{
    /// <summary>
    /// 开关量信号配置表，Excel导入到数据库；数据库导出到Excel；
    /// </summary>
    class ETHImportExcel : BaseBLL
    {
        public ETHImportExcel() : base(VarHelper.Database, VarHelper.ConnectionString, "ETHFullTags") { }

        public string ModelID { get; set; }

        public int GetExcelTable(string strExcelFileName, string strSheetName, int modelid)
        {

            DataTable dt = new DataTable();
            try
            {
                this.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + strExcelFileName;

                this.ConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=NO;IMEX=1;'", strExcelFileName);

                base.Init();


                //string sql = string.Format("select * from [{0}$]", strSheetName);


                //请注意：该配置表格必须固定，列名顺序不能改动。
                //请注意：该配置表格必须固定，列名顺序不能改动。
                //请注意：该配置表格必须固定，列名顺序不能改动。
                string sql = string.Format("select F1 as 车型,F2 as 航插,F3 as 航插引脚,F4 as 线号,F5 as 线号定义说明,F6 as 线号类型,F7 as 初始状态,F8 as 板卡号,F9 as 板卡点位号 from [{0}$]", strSheetName);

                DataSet ds = new DataSet();

                dt = this.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                { }
                //InsertExcelData(dt);

            }
            catch (Exception ex)
            {
                string err = ex.Message;
                System.Windows.Forms.MessageBox.Show(err);

            }
            int rowCnt = dt.Rows.Count - 1; //减去1行列标题行。
            return rowCnt;
        }

        public DataTable ModifyColumNmae(DataTable dt)
        {
            //dt.Columns[0].ColumnName = "车型";
            //dt.Columns[1].ColumnName = "信号名称";
            //dt.Columns[2].ColumnName = "数据类型";
            //dt.Columns[3].ColumnName = "单位";
            //dt.Columns[4].ColumnName = "ComID";
            //dt.Columns[5].ColumnName = "字节偏移";
            //dt.Columns[6].ColumnName = "位移偏移";
            //dt.Columns[7].ColumnName = "倍率值";
            //dt.Columns[8].ColumnName = "大小端模式";
            //dt.Columns[9].ColumnName = "是否生命信号";
            //dt.Columns[10].ColumnName = "网关编号";
            //dt.Columns[11].ColumnName = "ETH通道";
            //dt.Columns[12].ColumnName = "协议版本";
            //dt.Columns[13].ColumnName = "是否默认版本";
            //dt.Columns[14].ColumnName = "原溯端口";
            //dt.Columns[15].ColumnName = "备注";
            dt.Columns[0].ColumnName = "TypeName";
            dt.Columns[1].ColumnName = "DataLabel";
            dt.Columns[2].ColumnName = "DataType";
            dt.Columns[3].ColumnName = "DataUnit";
            dt.Columns[4].ColumnName = "Port";
            dt.Columns[5].ColumnName = "Offset";
            dt.Columns[6].ColumnName = "ETHBit";
            dt.Columns[7].ColumnName = "BitValue";
            dt.Columns[8].ColumnName = "PortPattern"; //大小端口
            dt.Columns[9].ColumnName = "Identity";  //生命信号
            dt.Columns[10].ColumnName = "TRDPNo";   //网关编号
            dt.Columns[11].ColumnName = "ETHPassage"; //通道
            dt.Columns[12].ColumnName = "VerNo";  //协议版本 V1.0.0
            dt.Columns[13].ColumnName = "DefaultVersion"; //默认版本
            dt.Columns[14].ColumnName = "IsRead"; //原溯
            dt.Columns[15].ColumnName = "Description"; // 备注
            return dt;
        }


        public void InsertExcelData(DataTable dt, string name)
        {
            Init();
            string sqlDel = $"delete from ETHFullTags where TypeName='{name}' and  VerNo='" + dt.Rows[0]["VerNo"] + "'";
            int delcnt = Database.ExecuteNonQuery(sqlDel);
            List<ETHSignal> signal = [];
            foreach (DataRow row in dt.Rows)
            {
                signal.Add(new ETHSignal(row));
            }
            for (int i = 0; i < signal.Count; i++)
            {
                string sql = string.Format("insert into {10}(DataLabel,DataType,Description,Port,Offset,ETHBit,[Identity],DataUnit,[PortPattern],TypeName,TRDPNo,VerNo,[IsRead],ETHPassage,BitValue,DefaultVersion) values('{0}','{1}','{2}','{3}',{4},{5},'{6}','{7}','{8}','{9}',{11},'{12}','{13}',{14},{15},'{16}')", signal[i].DataLabel, signal[i].DataType, signal[i].Description, signal[i].Port, signal[i].Offset, signal[i].ETHBit, signal[i].Identity, signal[i].DataUnit, signal[i].PortPattern, name, this.TableName, signal[i].TRDPNo, signal[i].VerNo, signal[i].IsRead, signal[i].ETHPassage, signal[i].BitValue, signal[i].DefaultVersion);
                Database.ExecuteNonQuery(sql);
            }
        }


        public void InsertExcelDataNew(DataTable dt, int ModelID)
        {
            Init();

            string sqlDel = $"delete from ETHFullTags where modelID={ModelID}";
            int delcnt = Database.ExecuteNonQuery(sqlDel);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //if (i == 0)
                //    continue; // 第0行，列标题不读取。

                DataRow row = dt.Rows[i];
                int modelID = ModelID;//客户选择型号ID
                string plug = row["航插"].ToString();
                string PlugFoot = row["航插引脚"].ToString();
                string LineNO = row["线号"].ToString();
                string LineDesc = row["线号定义说明"].ToString();

                int LineType = 1;
                // 0：代表输入。xls配置表写In，检测点DI。 1：代表输出，xls配置表写Out ，控制点DO。
                string typeStr = row["线号类型"].ToString().ToUpper();

                if (typeStr == "" || typeStr == null)
                    LineType = 2;
                else
                    LineType = (typeStr == "OUT" || typeStr == "输出") ? 1 : 0;


                int InitValue = row["初始状态"].ToString().ToInt();

                int CardNo = row["板卡号"].ToString().ToInt();

                int CardFoot = row["板卡点位号"].ToString().ToInt();

                string sql = $"insert into DIDOConfig(ModelID,Plug,PlugFoot,LineNO,LineDesc,LineType,InitValue,CardNo,CardFoot) values({modelID},'{plug}','{PlugFoot}','{LineNO}','{LineDesc}',{LineType},{InitValue},{CardNo},{CardFoot})";
                Database.ExecuteNonQuery(sql);
            }


        }

    }
}
