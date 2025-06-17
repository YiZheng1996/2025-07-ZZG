using RW.Components.Core.BLL;
using RW.Data;
using System.Data;
using System.Linq;

namespace MainUI.BLL
{
    public class CANFulltagsBLL() : BaseBLL(VarHelper.Database, VarHelper.ConnectionString, "CANFullTags")
    {
        protected override void Init()
        {
            this.TableName = "CANFullTags";
            base.Init();
        }

        public List<CANFullTags> GetAllTags()
        {
            string where = "";
            where = "MVBPOrt<>'0'";
            DataTable dt = this.GetList(where);

            List<CANFullTags> tags = [];
            foreach (DataRow row in dt.Rows)
            {
                CANFullTags tag = new(row);
                tags.Add(tag);
            }
            //return tags;
            return tags.OrderBy(x => x.COMMData.Bit).OrderBy(x => x.COMMData.Offset).OrderBy(x => x.COMMData.Port).ToList();
        }

        public List<CANFullTags> GetfulltagsByIDS(string portIDs)
        {
            string sql = $"select * from CANFullTags where PortID in({portIDs})";
            DataTable dt = this.GetDataTable(sql);

            List<CANFullTags> tags = [];

            foreach (DataRow row in dt.Rows)
            {
                CANFullTags tag = new(row);
                tags.Add(tag);
            }
            return tags;
        }

        public List<CANFullTags> GetMVBTags(string port)
        {
            string where = "mvbPort='" + port + "' order by mvbPort, mvbOffset ,mvbBit";

            DataTable dt = this.GetList(where);

            List<CANFullTags> tags = [];

            foreach (DataRow row in dt.Rows)
            {
                CANFullTags tag = new(row);
                tags.Add(tag);
            }
            return tags;
        }

        internal void DelTags(int id)
        {
            string sql = "delete from " + TableName + " where FullTags.id=" + id;
            this.ExecuteNonQuery(sql);
        }

    }
}
