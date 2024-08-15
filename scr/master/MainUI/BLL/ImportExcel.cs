using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RW.Data;
using RW.Components.Core.BLL;

namespace MainUI.BLL
{
    /// <summary>
    /// 开关量信号配置表，Excel导入到数据库；数据库导出到Excel；
    /// </summary>
    class ImportExcel : BaseBLL
    {
        public ImportExcel() : base(VarHelper.Database, VarHelper.ConnectionString, "Record") { }

        protected override void Init()
        {
            //TableName = "Record";
            ////this.Database = new OleDB();
            //ConnectionString = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb;jet oledb:database password=ok";
            //ConnectionString = this.ConnectionString;
            base.Init();
        }

        public int ModelID { get; set; }

        public int GetExcelTable(string strExcelFileName, string strSheetName, int modelid)
        {
            ModelID = modelid;
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
                    InsertExcelData(dt);

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
            dt.Columns[1].ColumnName = "航插";
            dt.Columns[2].ColumnName = "航插引脚";
            dt.Columns[3].ColumnName = "线号";
            dt.Columns[4].ColumnName = "线号定义说明";
            dt.Columns[5].ColumnName = "线号类型";
            dt.Columns[6].ColumnName = "初始状态";
            dt.Columns[7].ColumnName = "板卡号";
            dt.Columns[8].ColumnName = "板卡点位号";

            return dt;
        }


        public void InsertExcelData(DataTable dt)
        {
            Init();

            string sqlDel = $"delete from DIDOConfig where modelID={ModelID}";
            int delcnt = Database.ExecuteNonQuery(sqlDel);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0)
                    continue; // 第0行，列标题不读取。

                DataRow row = dt.Rows[i];
                int modelID = 22;//客户选择型号ID
                string plug = row["航插"].ToString();
                string PlugFoot = row["航插引脚"].ToString();
                string LineNO = row["线号"].ToString();
                string LineDesc = row["线号定义说明"].ToString();

                int LineType = 1;
                // 0：代表输入。xls配置表写In，检测点DI。 1：代表输出，xls配置表写Out ，控制点DO。
                string typeStr = row["线号类型"].ToString().ToUpper();
                LineType = (typeStr == "OUT" || typeStr == "输出") ? 1 : 0;

                int InitValue = row["初始状态"].ToString().ToInt();

                int CardNo = row["板卡号"].ToString().ToInt();

                int CardFoot = row["板卡点位号"].ToString().ToInt();

                string sql = $"insert into DIDOConfig(ModelID,Plug,PlugFoot,LineNO,LineDesc,LineType,InitValue,CardNo,CardFoot) values({modelID},'{plug}','{PlugFoot}','{LineNO}','{LineDesc}',{LineType},{InitValue},{CardNo},{CardFoot})";
                Database.ExecuteNonQuery(sql);
            }


        }



        public void InsertExcelDataNew(DataTable dt, int ModelID)
        {
            Init();

            string sqlDel = $"delete from DIDOConfig where modelID={ModelID}";
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


        public DataTable ModifyDataColumNmae(DataTable dt)
        {
            dt.Columns[0].ColumnName = "colDataLabel";
            dt.Columns[1].ColumnName = "colDataType";
            dt.Columns[2].ColumnName = "colDataUnit";
            dt.Columns[3].ColumnName = "colMVBPort";
            dt.Columns[4].ColumnName = "colMVBOffset";
            dt.Columns[5].ColumnName = "colMVBBit";
            dt.Columns[6].ColumnName = "colBitValue";
            dt.Columns[7].ColumnName = "colPortPattern";
            dt.Columns[8].ColumnName = "colIdentity";
            dt.Columns[9].ColumnName = "colIsRead";
            dt.Columns[10].ColumnName = "colDescription";
            return dt;
        }

        public void InsertExcelDataNew(DataTable dt, int ModelID, string TableName)
        {
            Init();
            string sqlDel = string.Format("delete from {0} where ModelNameID={1}", TableName, ModelID);
            Database.ExecuteNonQuery(sqlDel);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                string DataLabel = row["colDataLabel"].ToString();
                string DataType = row["colDataType"].ToString();
                string DataUnit = row["colDataUnit"].ToString();
                string MVBOffset = row["colMVBOffset"].ToString();
                string MVBPort = row["colMVBPort"].ToString();
                bool Identity = row["colIdentity"].ToString().ToBool();
                int MVBBit = row["colMVBBit"].ToString().ToInt();
                string Description = row["colDescription"].ToString();
                bool IsRead = row["colIsRead"].ToString().ToBool();
                bool PortPattern = row["colPortPattern"].ToString().ToBool();
                double BitValue = row["colBitValue"].ToString().ToDouble();

                string sql = $"insert into {TableName}(DataLabel,DataType,DataUnit,MVBOffset,MVBPort,[Identity],MVBBit,Description,ModelNameID,[IsRead],[PortPattern],BitValue) values('{DataLabel}','{DataType}','{DataUnit}','{MVBOffset}','{MVBPort}',{Identity},'{MVBBit}','{Description}','{ModelID}',{IsRead},{PortPattern},{BitValue})";
                Database.ExecuteNonQuery(sql);
            }
        }

    }
}
