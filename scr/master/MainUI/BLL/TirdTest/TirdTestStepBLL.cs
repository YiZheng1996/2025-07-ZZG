using MainUI.ViewModel;
using RW.Components.Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.BLL.TirdTest
{
    public class TirdTestStepBLL : BaseBLL
    {
        public TirdTestStepBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "TirdTestStep") { }


        public DataTable GetStep(string model, int step)
        {
            return this.GetList(string.Format(" index={0} and model='{1}'", step, model));
        }

        public bool Add(string model, int index, int fromSpeed, int toSpeed, bool direction, double time)
        {
            string sql = string.Format("insert into {0} (model,[index],fromSpeed,toSpeed,direction,[time]) values('{6}',{1},{2},{3},{4},{5})", this.TableName, index, fromSpeed, toSpeed, direction, time, model);
            return this.ExecuteNonQuery(sql) > 0;
        }

        public bool Update(string model, int index, int fromSpeed, int toSpeed, bool direction, double time)
        {
            string sql = string.Format("update {0} set fromSpeed={2},toSpeed={3},direction={4},[time]={5} where [index]={1} and model='{6}'", this.TableName, index, fromSpeed, toSpeed, direction, time, model);
            return this.ExecuteNonQuery(sql) > 0;
        }

        public bool RemoveByIndex(string model, int index)
        {
            string sql = string.Format("delete from {0} where [index]={1} and model='{2}'", this.TableName, index, model);
            int r1 = this.ExecuteNonQuery(sql);
            string sql2 = string.Format("update {0} set [index]=[index]-1 where [index]>{1} and model='{2}'", this.TableName, index, model);
            int r2 = this.ExecuteNonQuery(sql2);
            return r1 > 0;
        }

        public int GetMaxIndex(string model)
        {
            string sql = string.Format("select max([index]) from TirdTestStep where model='{0}';", model);
            object data = this.ExecuteScalar(sql);

            int id;
            int.TryParse(data + "", out id);
            return id;
        }

        public bool Move(string model, int fromIndex, int toIndex)
        {
            string where = "model='" + model + "'";
            int s1 = this.Move("Index", "Index", fromIndex, fromIndex, 99, 99, where);
            int s2 = this.Move("Index", "Index", toIndex, toIndex, fromIndex, fromIndex, where);
            int s3 = this.Move("Index", "Index", 99, 99, toIndex, toIndex);

            return s1 > 0 && s2 > 0 && s3 > 0;
        }

        //------------------------------------->



        public List<TirdTestStep> GetStep(string model)
        {
            //string sql = string.Format("select a.* from TirdTestStep a left join TirdTestProcess b on a.ProcessKey=b.ProcessKey where a.Model='{0}' ", model);

            string sql = string.Format("select a.* from TirdTestStep a  where a.Model='{0}'", model);//and a.IsVisible='1'
            DataTable dt = this.GetDataTable(sql);

            TirdTestProcessBLL bll = new TirdTestProcessBLL();
            List<TirdTestProcess> processes = bll.GetAll();

            List<TirdTestStep> lst = new List<TirdTestStep>();
            foreach (DataRow row in dt.Rows)
            {
                TirdTestStep step = GetModel(row);
                lst.Add(step);
            }
            return lst;
        }


        public void ClearStepsByModelID(string modelID)
        {
            string sql2 = "delete from TirdTestStep where model='" + modelID + "'";
            this.ExecuteNonQuery(sql2);
        }

        private void ClearSteps(string model, string repairing, string testType)
        {
            if (repairing == "默认") repairing = "";
            if (testType == "默认") testType = "";
            string sql2 = "delete from TirdTestStep where Model='" + model + "' ";
            if (!string.IsNullOrEmpty(repairing))
            {
                sql2 += "and repairing='" + repairing + "' ";
            }
            if (!string.IsNullOrEmpty(testType))
            {
                sql2 += "and testType='" + testType + "' ";
            }

            this.ExecuteNonQuery(sql2);
        }

        public void ClearSteps(string model)
        {
            ClearSteps(model, null, null);
        }

        public void SaveSteps(List<TirdTestStep> step, string model)
        {
            this.ClearSteps(model);

            for (int i = 0; i < step.Count; i++)
            {
                TirdTestStep s = step[i];
                string sql = $"insert into TirdTestStep(model,sort,step,ProcessName,ProcessKey,LineNumber,IsVisible,DSLName,FlipToTheLine,ModelID) values('{model}',{s.Sort},{s.Step},'{s.ProcessName}','{s.ProcessKey}',{s.LineNumber},'{s.IsVisible}','{s.DSLName}','{s.ReportRow}',{s.ModelID})";
                this.ExecuteNonQuery(sql);
            }
        }
        public static TirdTestStep GetModel(DataRow row)
        {
            TirdTestStep p = new TirdTestStep();
            p.ID = Convert.ToInt32(row["ID"]);
            p.LineNumber = Convert.ToInt32(row["LineNumber"].ToString());
            p.Model = row["Model"].ToString();
            p.ProcessKey = row["ProcessKey"].ToString();
            p.ProcessName = row["ProcessName"].ToString();
            p.Sort = Convert.ToInt32(row["Sort"].ToString());
            p.Step = Convert.ToInt32(row["Step"].ToString());
            p.DSLName = row["DSLName"].ToString();
            p.ReportRow = row["FlipToTheLine"].ToString();
            p.ModelID = row["ModelID"].ToInt();
            return p;
        }

        public List<TirdTestStep> GetStepByModelID(string modelID)
        {
            //string sql = string.Format("select a.* from TirdTestStep a left join TirdTestProcess b on a.ProcessKey=b.ProcessKey where a.Model='{0}' ", model);
            string sql = string.Format("select * from TirdTestStep where Model='{0}' order by sort", modelID); //and a.IsVisible='1'
            DataTable dt = this.GetDataTable(sql);

            TirdTestProcessBLL bll = new TirdTestProcessBLL();
            List<TirdTestProcess> processes = bll.GetAll();

            List<TirdTestStep> lst = new List<TirdTestStep>();
            foreach (DataRow row in dt.Rows)
            {
                TirdTestStep step = GetModel(row);
                lst.Add(step);
            }
            return lst;
        }







    }
}
