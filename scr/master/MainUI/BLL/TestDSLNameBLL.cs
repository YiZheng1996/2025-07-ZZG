using RW.Components.Core.BLL;
using System.Data;

namespace MainUI.BLL
{
    public class TestDSLNameBLL : BaseBLL
    {
        public TestDSLNameBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "TestProcess") 
        {
        }

        public DataTable GetDSLName(string id)
        {
            string sql = $"select * from {base.TableName} where ModelID={id} ORDER BY Sort";
            return this.GetDataTable(sql);
        }

        public DataTable GetDSLName(string id, string TableName)
        {
            string sql = $"select * from {TableName} ORDER BY Sort";
            return this.GetDataTable(sql);
        }

        /// <summary>
        /// 查询疲劳试验试验项点
        /// </summary>
        /// <returns></returns>
        public DataTable GetTirdDSLName()
        {
            string sql = $"select * from TirdProcess  where ModelID={24} ORDER BY Sort";
            return this.GetDataTable(sql);
        }
    }
}
