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

        #region 原来的方法不变

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

        #endregion


        #region ========== 【新增】配方管理相关方法 ==========

        /// <summary>
        /// 获取所有配方列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllSchemes()
        {
            string sql = "SELECT ID, SchemeName, SchemeDesc, IsDefault, CreateTime FROM OnekeyScheme ORDER BY ID";
            return this.GetDataTable(sql);
        }

        /// <summary>
        /// 获取默认配方
        /// </summary>
        /// <returns>默认配方的DataRow，如果没有则返回null</returns>
        public DataRow GetDefaultScheme()
        {
            string sql = "SELECT TOP 1 ID, SchemeName, SchemeDesc, IsDefault FROM OnekeyScheme WHERE IsDefault = 1";
            DataTable dt = this.GetDataTable(sql);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        /// <summary>
        /// 根据ID获取配方信息
        /// </summary>
        /// <param name="schemeId">配方ID</param>
        /// <returns></returns>
        public DataRow GetSchemeById(int schemeId)
        {
            string sql = $"SELECT ID, SchemeName, SchemeDesc, IsDefault FROM OnekeyScheme WHERE ID = {schemeId}";
            DataTable dt = this.GetDataTable(sql);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        /// <summary>
        /// 新增配方
        /// </summary>
        /// <param name="name">配方名称</param>
        /// <param name="desc">配方描述</param>
        /// <param name="isDefault">是否设为默认</param>
        /// <returns>新增配方的ID</returns>
        public int AddScheme(string name, string desc, bool isDefault = false)
        {
            // 如果设置为默认，先取消其他默认
            if (isDefault)
            {
                this.ExecuteNonQuery("UPDATE OnekeyScheme SET IsDefault = 0");
            }

            string sql = $@"INSERT INTO OnekeyScheme (SchemeName, SchemeDesc, IsDefault, CreateTime) 
                           VALUES ('{name}', '{desc}', {(isDefault ? 1 : 0)}, Now())";
            //SELECT @@IDENTITY;";
            object result = this.ExecuteScalar(sql);
            return Convert.ToInt32(result);
        }

        /// <summary>
        /// 更新配方信息
        /// </summary>
        /// <param name="schemeId">配方ID</param>
        /// <param name="name">配方名称</param>
        /// <param name="desc">配方描述</param>
        /// <returns></returns>
        public int UpdateScheme(int schemeId, string name, string desc)
        {
            string sql = $@"UPDATE OnekeyScheme 
                           SET SchemeName = '{name}', SchemeDesc = '{desc}' 
                           WHERE ID = {schemeId}";
            return this.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除配方（同时删除关联的配置明细）
        /// </summary>
        /// <param name="schemeId">配方ID</param>
        public void DeleteScheme(int schemeId)
        {
            // 先删除配置明细
            this.ExecuteNonQuery($"DELETE FROM DIDOConfig WHERE ModelID = {schemeId}");
            // 再删除配方主表
            this.ExecuteNonQuery($"DELETE FROM OnekeyScheme WHERE ID = {schemeId}");
        }

        /// <summary>
        /// 设置默认配方
        /// </summary>
        /// <param name="schemeId">要设为默认的配方ID</param>
        public void SetDefaultScheme(int schemeId)
        {
            // 先取消所有默认
            this.ExecuteNonQuery("UPDATE OnekeyScheme SET IsDefault = 0");
            // 设置指定配方为默认
            this.ExecuteNonQuery($"UPDATE OnekeyScheme SET IsDefault = 1 WHERE ID = {schemeId}");
        }

        /// <summary>
        /// 根据配方ID获取配置列表（用于一键切换）
        /// 注意：此方法直接查询DIDOConfig表，ModelID字段存储的是配方ID
        /// </summary>
        /// <param name="schemeId">配方ID</param>
        /// <returns>配置列表</returns>
        public List<DODIConfigView> GetConfigBySchemeID(int schemeId)
        {
            string sql = $@"SELECT D.ModelID, S.SchemeName as ModelName, D.Plug, D.PlugFoot, 
                                  D.LineNO, D.LineDesc, D.LineType, D.InitValue, D.CardNo, D.CardFoot 
                           FROM DIDOConfig D 
                           LEFT JOIN OnekeyScheme S ON D.ModelID = S.ID 
                           WHERE D.ModelID = {schemeId} 
                           ORDER BY D.CardNo, D.CardFoot";
            DataTable dt = this.GetDataTable(sql);

            List<DODIConfigView> lst = new List<DODIConfigView>();
            foreach (DataRow row in dt.Rows)
            {
                DODIConfigView v = new DODIConfigView
                {
                    ModelID = Convert.ToInt32(row["ModelID"]),
                    ModelName = row["ModelName"]?.ToString() ?? "",
                    Plug = row["Plug"]?.ToString() ?? "",
                    PlugFoot = row["PlugFoot"]?.ToString() ?? "",
                    LineNO = row["LineNO"]?.ToString() ?? "",
                    LineDesc = row["LineDesc"]?.ToString() ?? "",
                    LineType = Convert.ToInt32(row["LineType"]),
                    InitValue = Convert.ToInt32(row["InitValue"]),
                    CardNo = Convert.ToInt32(row["CardNo"]),
                    CardFoot = Convert.ToInt32(row["CardFoot"])
                };
                lst.Add(v);
            }
            return lst;
        }

        /// <summary>
        /// 根据配方ID获取配置（返回DataTable，供ucIOBox使用）
        /// </summary>
        /// <param name="schemeId">配方ID</param>
        /// <returns>DataTable格式的配置数据</returns>
        public DataTable GetDIDOBySchemeID(int schemeId)
        {
            string sql = $@"SELECT D.*, S.SchemeName as Name 
                    FROM DIDOConfig D 
                    LEFT JOIN OnekeyScheme S ON D.ModelID = S.ID 
                    WHERE D.ModelID = {schemeId}";
            return this.GetDataTable(sql);
        }

        /// <summary>
        /// 获取配方的所有配置明细（用于界面显示）
        /// </summary>
        /// <param name="schemeId">配方ID</param>
        /// <returns></returns>
        public DataTable GetAllConfigBySchemeID(int schemeId)
        {
            string sql = $@"SELECT S.SchemeName as 配方名称, D.Plug as 航插, D.PlugFoot as 航插引脚, 
                                  D.LineNO as 线号, D.LineDesc as 线号说明, D.LineType as 线号类型, 
                                  D.InitValue as 初始值, D.CardNo as 板卡号, D.CardFoot as 板卡脚位 
                           FROM DIDOConfig D 
                           LEFT JOIN OnekeyScheme S ON D.ModelID = S.ID 
                           WHERE D.ModelID = {schemeId} 
                           ORDER BY D.CardNo, D.CardFoot";
            return this.GetDataTable(sql);
        }

        /// <summary>
        /// 从现有型号配置复制到配方
        /// </summary>
        /// <param name="schemeId">目标配方ID</param>
        /// <param name="modelId">源型号ID</param>
        public void CopyFromModelToScheme(int schemeId, int modelId)
        {
            // 先删除目标配方的旧数据
            this.ExecuteNonQuery($"DELETE FROM DIDOConfig WHERE ModelID = {schemeId}");

            // 从源型号复制数据到目标配方
            string sql = $@"INSERT INTO DIDOConfig (ModelID, Plug, PlugFoot, LineNO, LineDesc, LineType, InitValue, CardNo, CardFoot)
                           SELECT {schemeId}, Plug, PlugFoot, LineNO, LineDesc, LineType, InitValue, CardNo, CardFoot
                           FROM DIDOConfig WHERE ModelID = {modelId}";
            this.ExecuteNonQuery(sql);
        }

        #endregion

    }
}
