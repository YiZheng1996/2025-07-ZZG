using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RW.Security;

using System.Data;
//using RW.UI.BLL;
using RW.Data;
using RW.UI.Model;
using RW.Components.Core.BLL;
using MainUI.CurrencyHelper;

namespace MainUI.BLL
{
    public class UserBLL : BaseBLL
    {
        public UserBLL() : base(VarHelper.sQLiteDB, VarHelper.sQLiteConnectionString, "Users")
        {
            ConnectionString = VarHelper.sQLiteConnectionString;
        }

        public DataSet GetSortedList()
        {
            string s = "select [ID],[Username],[Password],[Permission],[Sort],[JobNumber] from [Users] order by [Sort]";
            DataSet ds = Database.GetDataSet(s);
            return ds;
        }

        public bool IsExist(string username)
        {
            DataTable dt = new();
            string s = "select [ID],[Username],[Password],[Permission],[Sort] from [Users] where username='" + username + "'";
            dt = this.GetDataTable(s);
            if (dt != null && dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public int Save(Model.UserInfo User)
        {
            string sql = string.Format("select * from Users where Username='{0}'", User.Username);
            DataSet ds = Database.GetDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0 && Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]) != User.ID)
            {
                throw new Exception("用户名已存在，请重新输入！");
            }
            if (User.ID != 0)
            {
                sql = string.Format("update Users set [Username]='{0}',[Password]='{1}',[Permission]='{2}' where [ID]={3}",
                    User.Username, User.Password, User.Permission, User.ID);
            }
            else
            {
                //获取最大的Sort字段填充
                string sql2 = "select max([Sort]) from Users";
                ds = this.Database.GetDataSet(sql2);
                int paixu = 0;
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int.TryParse(ds.Tables[0].Rows[0][0].ToString(), out paixu);
                    paixu++;
                }

                sql = string.Format("insert into Users([Username],[Password],[Permission],[Sort],[JobNumber]) values('{0}','{1}','{2}',{3},'{4}')",
                    User.Username, User.Password, User.Permission, paixu, User.JobNumber);
            }
            int count = this.Database.ExecuteNonQuery(sql);
            return count;
            //return 0;
        }

        public int RemoveByUsername(string username)
        {
            string sql = string.Format("delete from Users where [Username]='{0}'", username);
            return this.Database.ExecuteNonQuery(sql);
        }

        public int ChangePwd(string JobNumber, string password)
        {
            string sql = string.Format("Update [Users] set [password]='{1}' where [Username]='{0}'", JobNumber, password);
            return this.Database.ExecuteNonQuery(sql);
        }

        public int GetPermissionLevel(string permission)
        {
            int plevel = 0;
            switch (permission)
            {
                case "1":
                case "Adminsitrator":
                case "系统管理员":
                case "管理员": plevel = 0; break;
                case "2":
                case "系统测试人员":
                case "工艺员":
                case "工程师": plevel = 1; break;
                case "3":
                case "操作人员":
                case "操作员":
                default: plevel = 2; break;
            }
            return plevel;
        }





    }
}
