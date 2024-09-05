using MainUI.CurrencyHelper;
using MainUI.Procedure.ViewModel;
using RW.Components.Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;

namespace MainUI.BLL
{
    public class DODIConfigBLL : BaseBLL
    {
        public DODIConfigBLL() : base(VarHelper.Database, VarHelper.ConnectionString, "DIDOConfig") { }

        public DataTable GetDIDOConfig(string lineNo, int LineType)
        {
            string sql = $"select * from {TableName} D , Model M where modelID = {VarHelper.ModelID} and lineNO='{lineNo}' and LineType={LineType} and D.ModelID=M.ID";
            return this.GetDataTable(sql);
        }

        /// <summary>
        /// 自动生成DI、DO点，0：代表输出。1：代表输入
        /// </summary>
        /// <param name="ModelID">型号ID</param>
        /// <param name="LineType">0：代表输出。xls配置表写Out ，控制点DO。 1：代表输入，xls配置表写In，检测点DI。</param>
        /// <returns></returns>
        public DataTable GetDIDO(int ModelID)
        {
            string sql = $"select * from {TableName} D , Model M where modelID = {VarHelper.ModelID} and D.ModelID=M.ID";
            return this.GetDataTable(sql);
        }

        public DataTable GetAllConfigBymodelID(int modelid)
        {
            //sql 语句中字段名与界面datagridview的dataproperty 属性名称一致。才能正确显示。
            string sql = $"select M.name as modelName,D.Plug as Plug,d.plugfoot as plugfoot,d.lineno as lineno,d.linedesc as linedesc,d.linetype as linetype,d.initvalue as initvalue,d.cardno as cardno,d.cardfoot as cardfoot from {TableName} D , Model M where M.ID = {modelid} and D.ModelID=M.ID";
            return this.GetDataTable(sql);
        }

        public List<DODIConfigView> GetConfigBymodelID(int modelid)
        {
            string sql = $"select  M.ID as ModelID,M.name as ModelName,D.Plug as Plug,d.plugfoot as plugfoot,d.lineno as lineno,d.linedesc as linedesc,d.linetype as linetype,d.initvalue as initvalue,d.cardno as cardno,d.cardfoot as cardfoot from {TableName} D , Model M where M.ID = {modelid} and D.ModelID=M.ID order by D.cardno,D.cardfoot";
            DataTable dt = this.GetDataTable(sql);

            List<DODIConfigView> lst = new List<DODIConfigView>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DODIConfigView v = new DODIConfigView();
                DataRow row = dt.Rows[i];
                v.ModelID = Convert.ToInt32(row["ModelID"]);
                v.ModelName = row["ModelName"].ToString();
                v.Plug = row["Plug"].ToString();
                v.PlugFoot = row["plugfoot"].ToString();
                v.LineNO = row["lineno"].ToString();
                v.LineDesc = row["linedesc"].ToString();
                v.LineType = Convert.ToInt32(row["linetype"].ToString());
                v.InitValue = Convert.ToInt32(row["initvalue"].ToString());
                v.CardNo = Convert.ToInt32(row["cardno"].ToString());
                v.CardFoot = Convert.ToInt32(row["cardfoot"].ToString());

                lst.Add(v);
            }
            return lst;
        }


        public DODIConfigView GetConfigBymodelID(int modelid, string LineNo)
        {

            string sql = $"select  M.ID as ModelID,M.name as ModelName,D.Plug as Plug,d.plugfoot as plugfoot,d.lineno as lineno,d.linedesc as linedesc,d.linetype as linetype,d.initvalue as initvalue,d.cardno as cardno,d.cardfoot as cardfoot from {TableName} D , Model M where M.ID = {modelid} and D.ModelID=M.ID and LineNo='{LineNo}' order by D.cardno,D.cardfoot";
            DataTable dt = this.GetDataTable(sql);

            DODIConfigView v = new DODIConfigView();
            DataRow row = dt.Rows[0];
            v.ModelID = Convert.ToInt32(row["ModelID"]);
            v.ModelName = row["ModelName"].ToString();
            v.Plug = row["Plug"].ToString();
            v.PlugFoot = row["plugfoot"].ToString();
            v.LineNO = row["lineno"].ToString();
            v.LineDesc = row["linedesc"].ToString();
            v.LineType = Convert.ToInt32(row["linetype"].ToString());
            v.InitValue = Convert.ToInt32(row["initvalue"].ToString());

            //点位输出用到
            v.CardNo = row["cardno"].ToString().ToInt();
            v.CardFoot = row["cardfoot"].ToInt();

            return v;
        }

    }
}
