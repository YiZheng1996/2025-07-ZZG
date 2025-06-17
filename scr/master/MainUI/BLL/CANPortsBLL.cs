using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MainUI.Model;
using MainUI.CurrencyHelper;
using RW.Components.Core.BLL;


namespace MainUI.BLL
{
    public class CANPortsBLL : BaseBLL
    {
        public CANPortsBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "CANPorts")
        {
        }

        public CANPortsBLL(string tableName) : base(VarHelper.Database, VarHelper.ConnectionString, tableName)
        {
        }
        public DataTable GetList(string where = null)
        {
            return BaseBLLExtender.GetList(this, where);
        }

        public List<CANPorts> GetPortsByType(bool? readOnly)
        {
            string where = "";
            if (readOnly != null)
                where += " and isRead=" + readOnly.Value;
            DataTable dt = this.GetList();
            List<CANPorts> ps = [];
            foreach (DataRow row in dt.Rows)
            {
                ps.Add(new CANPorts(row));
            }
            return ps;
        }

        public List<CANPorts> GetAllPorts()
        {
            List<CANPorts> ports = [];
            DataTable dt = GetList();
            foreach (DataRow row in dt.Rows)
                ports.Add(new CANPorts(row));
            return [.. ports.OrderBy(p => p.ID)];
        }

        public List<CANPorts> GetAllPorts(int modelID)
        {
            List<CANPorts> ports = [];
            DataTable dt = GetList(string.Format(" ModelNameID={0}", modelID));
            foreach (DataRow row in dt.Rows)
                ports.Add(new CANPorts(row));
            return [.. ports.OrderBy(p => p.ID)];
        }

        public void Modify(CANPorts port)
        {
            string sql = string.Format(
                "update {6} set portName='{1}',CANID='{2}',rate={3},isRead={4},PortPattern={5},ModelNameID={7},BaudRate={8} where id={0}",
                port.ID, port.PortName, port.CANID, port.Rate, port.IsRead,  port.PortPattern, TableName, port.ModelNameID,port.BaudRate);
            this.ExecuteNonQuery(sql);
        }

        public int AddPort(CANPorts port)
        {
            string sql = string.Format("select count(1) from {2} where CANID='{0}' and ModelNameID={1}", port.CANID, port.ModelNameID, TableName);
            int count = Convert.ToInt32(this.ExecuteScalar(sql));
            if (count > 0)
                return count;
            else
            {
                string sql1 = string.Format(
                         "insert into {5}(portName,CANID,rate,isRead,PortPattern,ModelNameID,BaudRate) values('{0}','{1}',{2},{3},{4},{6},{7})",
                          port.PortName, port.CANID, port.Rate, port.IsRead, true, TableName, port.ModelNameID,port.BaudRate);
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
