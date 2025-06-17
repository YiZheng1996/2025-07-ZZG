using MainUI.CurrencyHelper;
using RW.Components.Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.UI.BLL
{
    public class ETHConfigBLL : BaseBLL
    {
        public ETHConfigBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "ETHConfig"){ }

        public Dictionary<string, string> GetDate(string typename)
        {
            string where = "";
            if (typename != null)
                where = "TypeName='" + typename + "'";
            DataTable dt = this.GetList(where);
            Dictionary<string, string> ps = new();
            foreach (DataRow row in dt.Rows)
            {
                ps.Add(row["TRDPNo"].ToString(), row["ConfigFileName"].ToString());
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

        public void Modify(int id, string version, string trdpno)
        {
            string sql = string.Format(
                "update ETHConfig set ConfigFileName='{1}',TRDPNo='{2}' where id={0}", id, version, trdpno);

            this.ExecuteNonQuery(sql);
        }

        public int Add(string typename, string version, string trdpno)
        {
            string sql = "select count(1) from ETHConfig where TypeName='" + typename + "' and ConfigFileName='" + version + "'";
            int count = Convert.ToInt32(this.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = string.Format(
                         "insert into ETHConfig(TypeName,ConfigFileName,TRDPNo) values('{0}','{1}','{2}')",
                          typename, version, trdpno);
                this.ExecuteNonQuery(sql1);
                return 0;
            }
        }
        public int GetDate(string typename, string version)
        {
            string sql = "select count(1) from ETHPorts where TypeName='" + typename + "' and VerNo='" + version + "'";
            int count = Convert.ToInt32(this.ExecuteScalar(sql));
            return count;
        }
        public int DelDate(int id)
        {
            string sql1 = "delete from ETHConfig  where ID=" + id;
            this.ExecuteNonQuery(sql1);
            return 0;


        }
    }
}
