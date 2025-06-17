using RW.Components.Core.BLL;
using System.Data;
using System.Linq;

namespace MainUI.BLL
{
    public class CANTagsBLL : BaseBLL
    {
        public CANTagsBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "CANFullTags")
        {

        }

        public CANTagsBLL(string TableName) : base(VarHelper.Database, VarHelper.ConnectionString, TableName)
        {

        }

        public DataTable GetList(string where = null)
        {
            return BaseBLLExtender.GetList(this, where);
        }

        public List<CANFullTags> GetAllTags(int ModelID)
        {
            string where = "";
            where = "CANID<>'0' and ModelNameID=" + ModelID + "";
            DataTable dt = GetList(where);
            List<CANFullTags> tags = [];
            foreach (DataRow row in dt.Rows)
            {
                CANFullTags tag = new(row);
                tags.Add(tag);
            }
            return tags.OrderBy(x => x.COMMData.Bit).OrderBy(x => x.COMMData.Offset).OrderBy(x => x.COMMData.Port).ToList();
        }

        public List<CANFullTags> GetMVBTags(string port)
        {
            string where = "mvbPort='" + port + "' order by mvbPort, mvbOffset ,mvbBit";
            DataTable dt = GetList(where);
            List<CANFullTags> tags = [];
            foreach (DataRow row in dt.Rows)
            {
                CANFullTags tag = new(row);
                tags.Add(tag);
            }
            return tags;
        }

        public List<CANSignal> GetAllTagsByPort(int ModelNameID)
        {
            string where = "1=1";
            where = "ModelNameID=" + ModelNameID + "";
            DataTable dt = GetList(where);
            List<CANSignal> si = [];
            foreach (DataRow row in dt.Rows)
                si.Add(new CANSignal(row));

            var values = from u in si
                         orderby u.CANOffset ascending, u.CANBit ascending
                         select u;
            si = [.. values];
            return si;
        }

        public void EditTags(Signal signal)
        {
            string sql = string.Format("UPDATE {9} SET FullTags.DataLabel = '{0}', FullTags.DataType = '{1}', FullTags.Description = '{2}', FullTags.MVBPort = '{3}', FullTags.MVBOffset = {4}, FullTags.MVBBit = {5}, FullTags.[Identity] = {6},DataUnit='{7}' WHERE(((FullTags.[ID]) = {8}));", signal.DataLabel, signal.DataType, signal.Description, signal.MVBPort, signal.MVBOffset, signal.MVBBit, signal.Identity, signal.DataUnit, signal.ID, TableName);
            this.ExecuteNonQuery(sql);
        }

        public void AddTags(Signal signal)
        {
            string sql = string.Format("insert into {8}(DataLabel,DataType,Description,MVBPort,MVBOffset,MVBBit,[Identity],DataUnit) values('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}')", signal.DataLabel, signal.DataType, signal.Description, signal.MVBPort, signal.MVBOffset, signal.MVBBit, signal.Identity, signal.DataUnit, this.TableName);
            this.ExecuteNonQuery(sql);

        }

        internal void DelTags(int id)
        {
            string sql = "delete from " + this.TableName + " where FullTags.id=" + id;
            this.ExecuteNonQuery(sql);
        }
    }
}
