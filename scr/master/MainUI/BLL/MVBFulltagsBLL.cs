using RW.Components.Core.BLL;
using RW.Data;
using System.Data;
using System.Linq;

namespace MainUI.BLL
{
    public class MVBFulltagsBLL() : BaseBLL(VarHelper.Database, VarHelper.ConnectionString, "FullTags")
    {
        protected override void Init()
        {
            this.TableName = "FullTags";
            base.Init();
        }

        public List<FullTags> GetAllTags()
        {
            string where = "";
            where = "MVBPOrt<>'0'";
            DataTable dt = this.GetList(where);

            List<FullTags> tags = new List<FullTags>();
            foreach (DataRow row in dt.Rows)
            {
                FullTags tag = new FullTags(row);
                tags.Add(tag);
            }
            //return tags;
            return tags.OrderBy(x => x.COMMData.Bit).OrderBy(x => x.COMMData.Offset).OrderBy(x => x.COMMData.Port).ToList();
        }

        public List<FullTags> GetfulltagsByIDS(string portIDs)
        {
            string sql = $"select * from FullTags where PortID in({portIDs})";
            DataTable dt = this.GetDataTable(sql);

            List<FullTags> tags = new List<FullTags>();

            foreach (DataRow row in dt.Rows)
            {
                FullTags tag = new FullTags(row);
                tags.Add(tag);
            }
            return tags;
        }

        public List<FullTags> GetMVBTags(string port)
        {
            string where = "mvbPort='" + port + "' order by mvbPort, mvbOffset ,mvbBit";

            DataTable dt = this.GetList(where);

            List<FullTags> tags = new List<FullTags>();

            foreach (DataRow row in dt.Rows)
            {
                FullTags tag = new FullTags(row);
                tags.Add(tag);
            }

            return tags;
        }

        internal void DelTags(int id)
        {
            string sql = "delete from " + this.TableName + " where FullTags.id=" + id;
            this.Database.ExecuteNonQuery(sql);
        }

    }
}
