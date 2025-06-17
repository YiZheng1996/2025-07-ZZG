using RW.Components.Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.BLL
{
    class TestProcessBLL :BaseBLL
    {
        public TestProcessBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "TestProcess") { } 

        public List<TestProcess> GetAll()
        {
            string sql = "select * from TestProcess order by sort ";
            DataTable dt = this.GetDataTable(sql);
            List<TestProcess> lst = new List<TestProcess>();
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(GetModel(row));
            }
            return lst;
        }

        public List<TestProcess> GetAll(int ID)
        {
            string sql = $"select * from TestProcess where ModelID={ID}";
            DataTable dt = this.GetDataTable(sql);
            List<TestProcess> lst = new List<TestProcess>();
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(GetModel(row));
            }
            return lst;
        }

        public DataTable GetDataAll(int ID)
        {
            string sql = $"select * from TestProcess where ModelID={ID} order by Sort";
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }


        public static TestProcess GetModel(DataRow row)
        {
            TestProcess p = new TestProcess();
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


        public int GetSort(int ID, string name)
        {
            string sql = $"select Sort from TestProcess where ModelID={ID} and ProcessName='{name}'";
            DataTable dt = this.GetDataTable(sql);
            int sort = dt.Rows[0]["Sort"].ToInt();
            return sort;
        }

        public int GetSort(int ModelID)
        {
            string sql = $"select Max(Sort) as Sort from TestProcess where ModelID={ModelID}";
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
            string sql = $"Delete from TestProcess where ID={ID}";
            return this.ExecuteNonQuery(sql);
        }


        public bool UpData(string ProcessName, string FlipToTheLine, int id)
        {
            string sql = $"Update TestProcess set ProcessName='{ProcessName}',FlipToTheLine='{FlipToTheLine}' where ID={id}";
            return this.ExecuteNonQuery(sql) > 0;
        }


        public bool AddData(string ProcessKey, string ProcessName, int Sort, string FlipToTheLine, int ModelID)
        {
            string sql = $"insert into TestProcess(ProcessKey,ProcessName,IsVisible,Sort,FlipToTheLine,ModelID) values('{ProcessKey}','{ProcessName}','{1}',{Sort},'{FlipToTheLine}',{ModelID})";
            return this.ExecuteNonQuery(sql) > 0;
        }

    }
}
