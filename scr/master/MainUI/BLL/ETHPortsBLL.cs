using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RW.Data;
using System.Data;
using RW.Components.Core.BLL;
using MainUI.Model;

namespace MainUI.UI.BLL
{
    public class ETHPortsBLL : BaseBLL
    {
        public ETHPortsBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "ETHPorts") { }

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
        public List<Ports> GetPortsByType(bool? readOnly, string TypeName)
        {
            string where = "";
            if (readOnly != null)
                where += " isRead=" + readOnly.Value + "and TypeName='" + TypeName + "' and DefaultVersion =" + true;
            else
                where += "TypeName='" + TypeName + "' and [DefaultVersion] =" + true;
            DataTable dt = this.GetList(where);
            List<Ports> ps = new List<Ports>();
            foreach (DataRow row in dt.Rows)
            {
                ps.Add(new Ports(row));
            }

            return ps;
        }
        public List<Ports> GetAllTagsByPort(string portNo, string verno, string typename, string ETHPassage)
        {
            string where = "";
            where = "Port='" + portNo + "' and TypeName = '" + typename + "'and VerNo='" + verno + "'and ETHPassage=" + ETHPassage;
            DataTable dt = this.GetList(where);
            List<Ports> si = new List<Ports>();
            foreach (DataRow row in dt.Rows)
            {
                si.Add(new Ports(row));
            }

            var values = from u in si
                         orderby u.Port ascending, u.ID ascending
                         select u;
            si = values.ToList();
            return si;
        }
        public List<Ports> GetAllPorts()
        {
            List<Ports> ports = new List<Ports>();

            DataTable dt = this.GetList();
            foreach (DataRow row in dt.Rows)
            {
                ports.Add(new Ports(row));
            }
            return ports.OrderBy(p => p.ID).ToList();
        }
        public List<Ports> GetAllPorts(string typename, string version)
        {
            List<Ports> ports = new List<Ports>();
            string where = "";
            if (typename != null)
                where = "TypeName='" + typename + "' and VerNo='" + version + "'";
            DataTable dt = this.GetList(where);
            foreach (DataRow row in dt.Rows)
            {
                ports.Add(new Ports(row));
            }
            return ports.OrderBy(p => p.ID).ToList();
        }

        public void Modify(Ports port)
        {
            string sql = string.Format(
                "update ETHPorts set portName='{1}',port='{2}',rate={3},dataSize={4},isRead={5},SMIValue={6},PortPattern={7},VerNo='{8}',ETHPassage={9} ,TRDPNo={10} where id={0}",
                port.ID, port.PortName, port.Port, port.Rate, port.DataSize, port.IsRead, port.SMIValue, port.PortPattern, port.VerNo, port.ETHPassage, port.TRDPNo);

            Database.ExecuteNonQuery(sql);
        }

        public int AddPort(Ports port)
        {
            string sql = "select count(1) from ETHPorts where TypeName='" + port.TypeName + "'and PortName='" + port.PortName + "'and VerNo='" + port.VerNo + "'";
            int count = Convert.ToInt32(Database.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = string.Format(
                         "insert into ETHPorts(portName,port,rate,dataSize,isRead,SMIValue,PortPattern,TypeName,VerNo) values('{0}','{1}',{2},{3},{4},{5},{6},'{7}','{8}')",
                          port.PortName, port.Port, port.Rate, port.DataSize, port.IsRead, 0, true, port.TypeName, port.VerNo);
                Database.ExecuteNonQuery(sql1);
                return 0;
            }
        }
        public int AddPort(Ports port, string version)
        {
            string sql = "select count(1) from ETHPorts where TypeName='" + port.TypeName + "'and PortName='" + port.PortName + "'and VerNo='" + version + " and ETHPassage =" + port.ETHPassage + "'and TRDPNo=" + port.TRDPNo;
            int count = Convert.ToInt32(Database.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = string.Format(
                         "insert into ETHPorts(portName,port,rate,dataSize,isRead,SMIValue,PortPattern,TypeName,VerNo,ETHPassage,TRDPNo) values('{0}','{1}',{2},{3},{4},{5},{6},'{7}','{8}',{9},{10})",
                          port.PortName, port.Port, port.Rate, port.DataSize, port.IsRead, 0, port.PortPattern, port.TypeName, version, port.ETHPassage, port.TRDPNo);
                Database.ExecuteNonQuery(sql1);
                return 0;
            }
        }
        public int DelPort(int id, string port, string typename, string verno, int ETHPassage)
        {

            string sql = "select count(1) from ETHFullTags where Port='" + port + "'and TypeName='" + typename + "'and VerNo='" + verno + "' and ETHPassage=" + ETHPassage;
            int count = Convert.ToInt32(Database.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = "delete from ETHPorts where id=" + id;
                Database.ExecuteNonQuery(sql1);
                return 0;
            }
        }
        public int InserBatch(List<Ports> model, string verNo)
        {
            for (int i = 0; i < model.Count(); i++)
            {
                this.AddPortNew(model[i], verNo);
            }
            return 0;
        }
        public int AddPortNew(Ports port, string version)
        {

            string sql1 = string.Format(
                         "insert into ETHPorts(portName,port,rate,dataSize,isRead,SMIValue,PortPattern,TypeName,VerNo,DefaultVersion,ETHPassage) values('{0}','{1}',{2},{3},{4},{5},{6},'{7}','{8}',{9},{10})",
                          port.PortName, port.Port, port.Rate, port.DataSize, port.IsRead, 0, port.PortPattern, port.TypeName, version, port.DefaultVersion, port.ETHPassage);
            Database.ExecuteNonQuery(sql1);
            return 0;
        }

        public int InserBatch(List<Ports> model, string verNo, string ComID, int ETHPassage, int TRDPNo)
        {
            for (int i = 0; i < model.Count(); i++)
            {
                if (model[i].VerNo == verNo)
                    this.AddPortNew(model[i], verNo, ComID, ETHPassage, model[i].DefaultVersion, TRDPNo);
                else
                    this.AddPortNew(model[i], verNo, ComID, ETHPassage, false, TRDPNo);
            }
            return 0;
        }
        public int AddPortNew(Ports port, string version, string ComID, int ETHPassage, bool DefaultVersion, int TRDPNo)
        {

            string sql1 = string.Format(
                         "insert into ETHPorts(portName,port,rate,dataSize,isRead,SMIValue,PortPattern,TypeName,VerNo,DefaultVersion,ETHPassage,TRDPNo) values('{0}','{1}',{2},{3},{4},{5},{6},'{7}','{8}',{9},{10},{11})",
                          port.PortName, ComID, port.Rate, port.DataSize, port.IsRead, 0, port.PortPattern, port.TypeName, version, DefaultVersion, ETHPassage, TRDPNo);
            Database.ExecuteNonQuery(sql1);
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
                "update ETHPorts set [DefaultVersion]={0} where  TypeName='{1}'and VerNo <>'{2}'",
                 false, port.TypeName, port.VerNo);

            Database.ExecuteNonQuery(sql);
        }
        public void update(Ports port)
        {
            string sql = string.Format(
                "update ETHPorts set [DefaultVersion]={1} where id={0}",
                port.ID, true);

            Database.ExecuteNonQuery(sql);
        }
    }
}
