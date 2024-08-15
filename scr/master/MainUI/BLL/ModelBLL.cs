﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RW.Data;
using System.Data;
using MainUI.Model;
using RW.Components.Core.BLL;
using NPOI.SS.Formula.Functions;

namespace MainUI.BLL
{
    public class ModelBLL : BaseBLL
    {
        public ModelBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "Model") { }

        public DataTable GetAllKind()
        {
            string sql = "select a.ID, Name,a.typeid,b.modeltype,a.mark from Model a,ModelType b where a.typeID = b.ID order by a.id";
            return this.GetDataTable(sql);
        }

        public DataTable GetAllKindByCon(string condition)
        {
            string sql = "select a.ID, Name,a.typeid,b.modeltype,a.mark from Model a,ModelType b where a.typeID = b.ID " + condition + " order by a.id";

            return this.GetDataTable(sql);
        }

        /// <summary>
        /// true 表示存在；false 不存在。
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        public bool IsExist(string modelName)
        {
            string sql = string.Format("select name from Model where name='{0}'", modelName);
            DataTable dt = null;
            dt = GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool Add(string modelName, int typeid, string mark)
        {
            string sql = string.Format("insert into  [Model]([name],typeid,mark,CreateTime) values('{0}',{1},'{2}','{3}')", modelName, typeid, mark, System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return base.Database.ExecuteNonQuery(sql, null) >= 1 ? true : false;
        }

        public bool Delete(string modelID)
        {
            string sql = string.Format("delete from [Model] where ID={0}", modelID);
            return base.Database.ExecuteNonQuery(sql, null) >= 1 ? true : false;
        }

        public bool Update(string modelID, string name, int typeid, string mark)
        {
            string sql = string.Format("update [Model] set [name]='{1}',typeid={2},mark='{3}',UpdateTime='{4}'  where ID={0}", modelID, name, typeid, mark, System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return base.Database.ExecuteNonQuery(sql, null) >= 1 ? true : false;
        }
        public TestViewModel GetModel(System.Data.DataRow row)
        {
            TestViewModel mTestViewModel = new TestViewModel();
            if (row == null)
                return mTestViewModel;

            mTestViewModel.ModelID = int.Parse(row["ID"].ToString());
            mTestViewModel.ModelName = row["Name"].ToString();
            mTestViewModel.ModelType = row["modeltype"].ToString();
            mTestViewModel.Mark = row["mark"].ToString();
            return mTestViewModel;
        }
    }
}
