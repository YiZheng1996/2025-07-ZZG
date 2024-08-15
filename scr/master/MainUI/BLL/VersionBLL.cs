using MainUI.Model;
using RW.Components.Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.BLL
{
    public class VersionBLL : BaseBLL
    {
        public VersionBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "Version")
        {
        }

        public List<Ports> GetPortsByType(bool? readOnly)
        {
            string where = "";
            if (readOnly != null)
                where += " and isRead=" + readOnly.Value;
            DataTable dt = this.GetList();
            List<Ports> ps = new List<Ports>();
            foreach (DataRow row in dt.Rows)
            {
                ps.Add(new Ports(row));
            }

            return ps;
        }


        public DataTable GetAllPorts(string typename)
        {
            string where = "";
            if (typename != null)
                where = "TypeName='" + typename + "'";
            DataTable dt = this.GetList(where);
            return dt;
        }

        public void Modify(int id, string typename, string version, string newVersion)
        {
            string sql = string.Format(
               "update ETHPorts set VerNo='{0}' where TypeName='{1}' and VerNo='{2}'", newVersion, typename, version);
            Database.ExecuteNonQuery(sql);
            sql = string.Format(
     "update ETHFullTags set VerNo='{0}' where TypeName='{1}' and VerNo='{2}'", newVersion, typename, version);
            Database.ExecuteNonQuery(sql);
            sql = string.Format(
                "update Version set VersionName='{1}' where id={0}", id, newVersion);

            Database.ExecuteNonQuery(sql);
        }

        public int Add(string typename, string version)
        {
            string sql = "select count(1) from Version where TypeName='" + typename + "' and VersionName='" + version + "'";
            int count = Convert.ToInt32(Database.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = string.Format(
                         "insert into Version(TypeName,VersionName) values('{0}','{1}')",
                          typename, version);
                Database.ExecuteNonQuery(sql1);
                return 0;
            }
        }
        public int GetDate(string typename, string version)
        {
            string sql = "select count(1) from ETHPorts where TypeName='" + typename + "' and VerNo='" + version + "'";
            int count = Convert.ToInt32(Database.ExecuteScalar(sql));
            return count;
        }
        public int DelDate(int id, string typename, string version)
        {
            string sql1 = "delete from Version where id=" + id;
            Database.ExecuteNonQuery(sql1);
            sql1 = "delete from ETHPorts  where TypeName='" + typename + "' and VerNo='" + version + "'";
            Database.ExecuteNonQuery(sql1);
            sql1 = "delete from ETHFullTags  where TypeName='" + typename + "' and VerNo='" + version + "'";
            Database.ExecuteNonQuery(sql1);
            return 0;


        }
    }
}
