using RW.Components.Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.BLL.TirdTest
{
    class TirdTestProcessBLL : BaseBLL
    {
        public TirdTestProcessBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "TirdProcess") { }

        public List<TirdTestProcess> GetAll()
        {
            string sql = "select * from TirdProcess order by sort ";
            DataTable dt = this.GetDataTable(sql);
            List<TirdTestProcess> lst = new List<TirdTestProcess>();
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(GetModel(row));
            }
            return lst;
        }

        public List<TirdTestProcess> GetAll(int ID)
        {
            //string sql = $"select * from TirdProcess where ModelID={ID}";
            string sql = $"select * from TirdProcess";
            DataTable dt = this.GetDataTable(sql);
            List<TirdTestProcess> lst = new List<TirdTestProcess>();
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(GetModel(row));
            }
            return lst;
        }

        public static TirdTestProcess GetModel(DataRow row)
        {
            TirdTestProcess p = new TirdTestProcess();
            p.ID = Convert.ToInt32(row["ID"]);
            p.ProcessKey = row["ProcessKey"].ToString();
            p.ProcessName = row["ProcessName"].ToString();
            p.DSLName = row["DSLName"].ToString();
            p.ReportRow = row["FlipToTheLine"].ToString();
            p.ModelID = row["ModelID"].ToInt();
            return p;
        }

        /// <summary>
        /// 根据型号找到ID
        /// </summary>
        /// <param name="ModelName"></param>
        /// <returns></returns>
        public int GetModelID(string ModelName)
        {
            string sql = $"select * from Model where Name='{ModelName}'";
            DataTable dt = this.GetDataTable(sql);
            int id = dt.Rows[0]["ID"].ToInt();
            return id;
        }


        public int GetSort(string name)
        {
            string sql = $"select Sort from TirdProcess where ModelID={24} and ProcessName='{name}'";
            DataTable dt = this.GetDataTable(sql);
            int sort = dt.Rows[0]["Sort"].ToInt();
            return sort;
        }

        public int GetSort()
        {
            string sql = $"select Max(Sort) as Sort from TirdProcess where ModelID={24}";
            DataTable dt = this.GetDataTable(sql);
            int sort = dt.Rows[0]["Sort"].ToInt();
            return sort;
        }


        /// <summary>
        /// 根据ID删除行
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int DelDataID(int ID)
        {
            string sql = $"Delete from TirdProcess where ID={ID}";
            return this.ExecuteNonQuery(sql);
        }


        public DataTable GetDataAll(int ID)
        {
            string sql = $"select * from TirdProcess where ModelID={24} order by Sort";
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        public bool UpData(string ProcessName, string FlipToTheLine, int id)
        {
            string sql = $"Update TirdProcess set ProcessName='{ProcessName}',FlipToTheLine='{FlipToTheLine}' where ID={id}";
            return this.ExecuteNonQuery(sql) > 0;
        }


        public bool AddData(string ProcessKey, string ProcessName, int Sort, string FlipToTheLine, int ModelID)
        {
            string sql = $"insert into TirdProcess(ProcessKey,ProcessName,IsVisible,Sort,FlipToTheLine,ModelID) values('{ProcessKey}','{ProcessName}','{1}',{Sort},'{FlipToTheLine}',{24})";
            return this.ExecuteNonQuery(sql) > 0;
        }
    }
}
