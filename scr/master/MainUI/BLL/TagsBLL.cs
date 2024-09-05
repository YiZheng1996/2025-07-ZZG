using System.Collections.Generic;
using System.Linq;
using System.Data;
using RW.Components.Core.BLL;
using MainUI.Model;
using MainUI.CurrencyHelper;

namespace MainUI.BLL
{
    public class TagsBLL : BaseBLL
    {
        public TagsBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "FullTags")
        {

        }

        public TagsBLL(string TableName) : base(VarHelper.Database, VarHelper.ConnectionString, TableName)
        {

        }

        public List<FullTags> GetAllTags(int ModelID)
        {
            string where = "";
            where = "MVBPOrt<>'0' and ModelNameID=" + ModelID + "";
            DataTable dt = GetList(where);
            List<FullTags> tags = new();
            foreach (DataRow row in dt.Rows)
            {
                FullTags tag = new(row);
                tags.Add(tag);
            }
            return tags.OrderBy(x => x.COMMData.Bit).OrderBy(x => x.COMMData.Offset).OrderBy(x => x.COMMData.Port).ToList();
        }

        public List<FullTags> GetMVBTags(string port)
        {
            string where = "mvbPort='" + port + "' order by mvbPort, mvbOffset ,mvbBit";

            DataTable dt = this.GetList(where);

            List<FullTags> tags = new();

            foreach (DataRow row in dt.Rows)
            {
                FullTags tag = new(row);
                tags.Add(tag);
            }

            return tags;
        }

        public List<Signal> GetAllTagsByPort(int ModelNameID)
        {
            string where = "1=1";
            where = "ModelNameID=" + ModelNameID + "";
            DataTable dt = GetList(where);
            List<Signal> si = new();
            foreach (DataRow row in dt.Rows)
                si.Add(new Signal(row));

            var values = from u in si
                         orderby u.MVBOffset ascending, u.MVBBit ascending
                         select u;
            si = values.ToList();
            return si;
        }

        public void EditTags(Signal signal)
        {
            string sql = string.Format("UPDATE {9} SET FullTags.DataLabel = '{0}', FullTags.DataType = '{1}', FullTags.Description = '{2}', FullTags.MVBPort = '{3}', FullTags.MVBOffset = {4}, FullTags.MVBBit = {5}, FullTags.[Identity] = {6},DataUnit='{7}' WHERE(((FullTags.[ID]) = {8}));", signal.DataLabel, signal.DataType, signal.Description, signal.MVBPort, signal.MVBOffset, signal.MVBBit, signal.Identity, signal.DataUnit, signal.ID, this.TableName);
            Database.ExecuteNonQuery(sql);
        }

        public void AddTags(Signal signal)
        {
            string sql = string.Format("insert into {8}(DataLabel,DataType,Description,MVBPort,MVBOffset,MVBBit,[Identity],DataUnit) values('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}')", signal.DataLabel, signal.DataType, signal.Description, signal.MVBPort, signal.MVBOffset, signal.MVBBit, signal.Identity, signal.DataUnit, this.TableName);
            Database.ExecuteNonQuery(sql);

        }

        internal void DelTags(int id)
        {
            string sql = "delete from " + this.TableName + " where FullTags.id=" + id;
            Database.ExecuteNonQuery(sql);
        }
    }
}
