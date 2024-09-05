using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MainUI.Model;
using MainUI.CurrencyHelper;

namespace MainUI.BLL
{
    public class PortsBLL : RW.Components.Core.BLL.BaseBLL
    {
        public PortsBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "Ports")
        {
        }

        public PortsBLL(string tableName) : base(VarHelper.Database, VarHelper.ConnectionString, tableName)
        {
        }


        public List<Ports> GetPortsByType(bool? readOnly)
        {
            string where = "";
            if (readOnly != null)
                where += " and isRead=" + readOnly.Value;
            DataTable dt = GetList();
            List<Ports> ps = [];
            foreach (DataRow row in dt.Rows)
            {
                ps.Add(new Ports(row));
            }
            return ps;
        }

        public List<Ports> GetAllPorts()
        {
            List<Ports> ports = new();
            DataTable dt = GetList();
            foreach (DataRow row in dt.Rows)
                ports.Add(new Ports(row));
            return [.. ports.OrderBy(p => p.ID)];
        }

        public List<Ports> GetAllPorts(int modelID)
        {
            List<Ports> ports = new();
            DataTable dt = GetList(string.Format(" ModelNameID={0}", modelID));
            foreach (DataRow row in dt.Rows)
                ports.Add(new Ports(row));
            return [.. ports.OrderBy(p => p.ID)];
        }

        public void Modify(Ports port)
        {
            string sql = string.Format(
                "update {8} set portName='{1}',port='{2}',rate={3},dataSize={4},isRead={5},SMIValue={6},PortPattern={7},ModelNameID={9} where id={0}",
                port.ID, port.PortName, port.Port, port.Rate, port.DataSize, port.IsRead, port.SMIValue, port.PortPattern, TableName, port.ModelNameID);
            Database.ExecuteNonQuery(sql);
        }

        public int AddPort(Ports port)
        {
            string sql = string.Format("select count(1) from {2} where Port='{0}' and ModelNameID={1}", port.Port, port.ModelNameID, TableName);
            int count = Convert.ToInt32(Database.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = string.Format(
                         "insert into {7}(portName,port,rate,dataSize,isRead,SMIValue,PortPattern,ModelNameID) values('{0}','{1}',{2},{3},{4},{5},{6},{8})",
                          port.PortName, port.Port, port.Rate, port.DataSize, port.IsRead, 0, true, TableName, port.ModelNameID);
                Database.ExecuteNonQuery(sql1);
                return 0;
            }
        }

        public int DelPort(int id, string port)
        {
            string sql = "select count(1) from FullTags where MVBPort='" + port + "'";
            int count = Convert.ToInt32(Database.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = string.Format("delete from Ports where id={0}", id);
                Database.ExecuteNonQuery(sql1);
                return 0;
            }
        }

        /// <summary>
        /// 删除主表数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="port"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public int DelPortHost(int id, string TableName)
        {
            string sql = string.Format("delete from {0} where id={1}", TableName, id);
            return Database.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除子表数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="port"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public int DelPortFullTags(int ModelNameID, string port, string TableName)
        {
            string sql = string.Format("delete from {0} where ModelNameID={1} and MVBPort='{2}'", TableName, ModelNameID, port);
            return Database.ExecuteNonQuery(sql);
        }
    }
}
