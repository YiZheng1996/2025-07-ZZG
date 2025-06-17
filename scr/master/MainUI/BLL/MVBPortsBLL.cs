using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MainUI.Model;
using MainUI.CurrencyHelper;
using RW.Components.Core.BLL;


namespace MainUI.BLL
{
    public class MVBPortsBLL : BaseBLL
    {
        public MVBPortsBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "Ports")
        {
        }

        public MVBPortsBLL(string tableName) : base(VarHelper.Database, VarHelper.ConnectionString, tableName)
        {
        }
        public DataTable GetList(string where = null)
        {
            return BaseBLLExtender.GetList(this, where);
        }

        public List<Ports> GetPortsByType(bool? readOnly, string TypeName)
        {
            string _ = " where 1=1 ";
            if (readOnly != null)
                _ = " and isRead=" + readOnly.Value + " and TypeName='" + TypeName + "'";
            else
                _ = " TypeName='" + TypeName + "'";
            DataTable dt = this.GetList(_);
            List<Ports> ps = [];
            foreach (DataRow row in dt.Rows)
            {
                ps.Add(new Ports(row));
            }
            return ps;
        }

        public List<Ports> GetAllPorts()
        {
            List<Ports> ports = [];
            DataTable dt = GetList();
            foreach (DataRow row in dt.Rows)
                ports.Add(new Ports(row));
            return [.. ports.OrderBy(p => p.ID)];
        }

        public List<Ports> GetAllPorts(int modelID)
        {
            List<Ports> ports = [];
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
            this.ExecuteNonQuery(sql);
        }

        public int AddPort(Ports port)
        {
            string sql = string.Format("select count(1) from {2} where Port='{0}' and ModelNameID={1}", port.Port, port.ModelNameID, TableName);
            int count = Convert.ToInt32(this.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = string.Format(
                         "insert into {7}(portName,port,rate,dataSize,isRead,SMIValue,PortPattern,ModelNameID,TypeName) values('{0}','{1}',{2},{3},{4},{5},{6},{8},'{9}')",
                          port.PortName, port.Port, port.Rate, port.DataSize, port.IsRead, 0, true, TableName, port.ModelNameID, port.TypeName);
                this.ExecuteNonQuery(sql1);
                return 0;
            }
        }

        public int DelPort(int id, string port)
        {
            string sql = "select count(1) from FullTags where MVBPort='" + port + "'";
            int count = Convert.ToInt32(this.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = string.Format("delete from Ports where id={0}", id);
                this.ExecuteNonQuery(sql1);
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
            return this.ExecuteNonQuery(sql);
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
            return this.ExecuteNonQuery(sql);
        }
    }
}
