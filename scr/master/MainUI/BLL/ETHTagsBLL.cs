using System.Collections.Generic;
using System.Linq;
using System.Data;
using RW.Components.Core.BLL;
using MainUI.Model;
using MainUI.CurrencyHelper;

namespace MainUI.BLL
{
    public class ETHTagsBLL : BaseBLL
    {
        public ETHTagsBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "ETHFullTags") { }


        public DataTable GetList(string where = null)
        {
            return BaseBLLExtender.GetList(this, where);
        }

        public List<FullTagsETH> GetAllTags(string ModelName)
        {
            string where = "";
            where = "POrt<>'0'" + " and TypeName = '" + ModelName + "'" + "and DefaultVersion =" + true;
            DataTable dt = GetList(where);

            List<FullTagsETH> tags = [];
            foreach (DataRow row in dt.Rows)
            {
                FullTagsETH tag = new(row);
                tags.Add(tag);
            }
            return [.. tags.OrderBy(x => x.COMMData.Bit).OrderBy(x => x.COMMData.Offset).OrderBy(x => x.COMMData.Port)];
        }


        public List<ETHSignal> GetAllTagsByPort(string typename)
        {
            string where = "";
            where = " TypeName = '" + typename + "'";
            DataTable dt = GetList(where);
            List<ETHSignal> si = [];
            foreach (DataRow row in dt.Rows)
            {
                si.Add(new ETHSignal(row));
            }

            var values = from u in si
                         orderby u.Offset ascending, u.ETHBit ascending
                         select u;
            si = [.. values];
            return si;
        }
        public List<ETHSignal> GetAllTagsByPort(string portNo, string verno, string typename)
        {
            string where = "";
            where = "Port='" + portNo + "' and TypeName = '" + typename + "'and VerNo='" + verno + "'";
            DataTable dt = this.GetList(where);
            List<ETHSignal> si = new List<ETHSignal>();
            foreach (DataRow row in dt.Rows)
            {
                si.Add(new ETHSignal(row));
            }

            var values = from u in si
                         orderby u.Offset ascending, u.ETHBit ascending
                         select u;
            si = values.ToList();
            return si;
        }

        public void EditTags(ETHSignal signal)
        {
            string sql = string.Format("UPDATE {9} SET ETHFullTags.DataLabel = '{0}',ETHFullTags.[PortPattern] = {10},ETHFullTags.[TRDPNo] = {11}, ETHFullTags.DataType = '{1}', ETHFullTags.Description = '{2}', ETHFullTags.Port = '{3}', ETHFullTags.Offset = {4}, ETHFullTags.ETHBit = {5}, ETHFullTags.[Identity] = {6},ETHFullTags.DataUnit='{7}',BitValue={12} WHERE(((ETHFullTags.[ID]) = {8}));", signal.DataLabel, signal.DataType, signal.Description, signal.Port, signal.Offset, signal.ETHBit, signal.Identity, signal.DataUnit, signal.ID, this.TableName, signal.PortPattern, signal.TRDPNo, signal.BitValue);
            this.ExecuteNonQuery(sql);
        }

        public void AddTags(ETHSignal signal)
        {
            string sql = string.Format("insert into {10}(DataLabel,DataType,Description,Port,Offset,ETHBit,[Identity],DataUnit,[PortPattern],TypeName,TRDPNo,VerNo,[IsRead],ETHPassage,BitValue) values('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}',{8},'{9}',{11},'{12}',{13},{14},{15})", signal.DataLabel, signal.DataType, signal.Description, signal.Port, signal.Offset, signal.ETHBit, signal.Identity, signal.DataUnit, signal.PortPattern, signal.TypeName, this.TableName, signal.TRDPNo, signal.VerNo, signal.IsRead, signal.ETHPassage, signal.BitValue);
            this.ExecuteNonQuery(sql);

        }
        public void AddTags(ETHSignal signal, string verno, string COmID, int ETHPassage)
        {
            string sql = string.Format("insert into {10}(DataLabel,DataType,Description,Port,Offset,ETHBit,[Identity],DataUnit,[PortPattern],TypeName,TRDPNo,VerNo,[IsRead],ETHPassage,DefaultVersion,BitValue) values('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}',{8},'{9}',{11},'{12}',{13},{14},{15},{16})", signal.DataLabel, signal.DataType, signal.Description, COmID, signal.Offset, signal.ETHBit, signal.Identity, signal.DataUnit, signal.PortPattern, signal.TypeName, this.TableName, signal.TRDPNo, verno, signal.IsRead, ETHPassage, signal.DefaultVersion, signal.BitValue);
            this.ExecuteNonQuery(sql);

        }
        public void AddTags1(ETHSignal signal, string verno, string COmID, int ETHPassage)
        {
            string sql = string.Format("insert into {10}(DataLabel,DataType,Description,Port,Offset,ETHBit,[Identity],DataUnit,[PortPattern],TypeName,TRDPNo,VerNo,[IsRead],ETHPassage,DefaultVersion,BitValue) values('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}',{8},'{9}',{11},'{12}',{13},{14},{15},{16})", signal.DataLabel, signal.DataType, signal.Description, COmID, signal.Offset, signal.ETHBit, signal.Identity, signal.DataUnit, signal.PortPattern, signal.TypeName, this.TableName, signal.TRDPNo, verno, signal.IsRead, ETHPassage, false, signal.BitValue);
            this.ExecuteNonQuery(sql);

        }
        internal void DelTags(int id)
        {
            string sql = "delete from " + this.TableName + " where ETHFullTags.id=" + id;
            this.ExecuteNonQuery(sql);
        }
        internal void DelTags(string TypeNmae, string port, string verno)
        {
            string sql = "delete from " + this.TableName + "where TypeName ='" + TypeNmae + "'and Port='" + port + "' and VerNo='" + verno + "'";
            this.ExecuteNonQuery(sql);
        }
        public int InserBatch(List<ETHSignal> model, string verNo, string COmID, int ETHPassage)
        {
            for (int i = 0; i < model.Count(); i++)
            {
                if (model[i].VerNo == verNo)
                    this.AddTags(model[i], verNo, COmID, ETHPassage);
                else
                    this.AddTags1(model[i], verNo, COmID, ETHPassage);
            }
            return 0;
        }

        public void UpDate(List<Ports> port)
        {
            for (int i = 0; i < port.Count(); i++)
            {
                updateVer(port[i]);
                this.update(port[i]);
            }

        }
        /// <summary>
        /// 将同型号同COmID的默认版本属性置为Flase
        /// </summary>
        /// <param name="port"></param>
        public void updateVer(Ports port)
        {
            string sql = string.Format(
                "update ETHFullTags set [DefaultVersion]={0} where TypeName='{1}'and VerNo <>'{2}'",
                false, port.TypeName, port.VerNo);

            this.ExecuteNonQuery(sql);
        }
        public void update(Ports port)
        {
            string sql = string.Format(
                "update ETHFullTags set [DefaultVersion]={1} where  Port='{0}' and TypeName='{2}'and VerNo='{3}'",
                port.Port, true, port.TypeName, port.VerNo);

            this.ExecuteNonQuery(sql);
        }
    }
}
