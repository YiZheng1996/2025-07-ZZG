using System.Data;
using RW.Components.Core.BLL;
using RW.DSL;

namespace MainUI.BLL;

/// <summary>
///     开关量信号配置表，Excel导入到数据库；数据库导出到Excel；
/// </summary>
internal class ImportExcel : BaseBLL
{
    public ImportExcel() : base(VarHelper.Database, VarHelper.ConnectionString, "Record")
    {
    }

    /// <summary>
    ///     型号ID（原有功能使用）
    /// </summary>
    public int ModelID { get; set; }

    // ========== 【新增】配方ID ==========
    /// <summary>
    ///     配方ID（新增配方功能使用）
    /// </summary>
    public int SchemeID { get; set; }

    protected override void Init()
    {
        //TableName = "Record";
        ////this.Database = new OleDB();
        //ConnectionString = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb;jet oledb:database password=ok";
        //ConnectionString = this.ConnectionString;
        base.Init();
    }

    public int GetExcelTable(string strExcelFileName, string strSheetName, int modelid)
    {
        ModelID = modelid;
        var dt = new DataTable();
        try
        {
            ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=" + strExcelFileName;

            ConnectionString =
                string.Format(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=NO;IMEX=1;'",
                    strExcelFileName);

            base.Init();


            //string sql = string.Format("select * from [{0}$]", strSheetName);


            //请注意：该配置表格必须固定，列名顺序不能改动。
            //请注意：该配置表格必须固定，列名顺序不能改动。
            //请注意：该配置表格必须固定，列名顺序不能改动。
            var sql = string.Format(
                "select F1 as 车型,F2 as 航插,F3 as 航插引脚,F4 as 线号,F5 as 线号定义说明,F6 as 线号类型,F7 as 初始状态,F8 as 板卡号,F9 as 板卡点位号 from [{0}$]",
                strSheetName);

            DataSet ds = new();

            dt = this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
                InsertExcelData(dt);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
            MessageBox.Show(err);
        }

        var rowCnt = dt.Rows.Count - 1; //减去1行列标题行。
        return rowCnt;
    }

    public DataTable ModifyColumNmae(DataTable dt)
    {
        dt.Columns[1].ColumnName = "航插";
        dt.Columns[2].ColumnName = "航插引脚";
        dt.Columns[3].ColumnName = "线号";
        dt.Columns[4].ColumnName = "线号定义说明";
        dt.Columns[5].ColumnName = "线号类型";
        dt.Columns[6].ColumnName = "初始状态";
        dt.Columns[7].ColumnName = "板卡号";
        dt.Columns[8].ColumnName = "板卡点位号";

        return dt;
    }


    public void InsertExcelData(DataTable dt)
    {
        Init();

        var sqlDel = $"delete from DIDOConfig where modelID={ModelID}";
        var delcnt = this.ExecuteNonQuery(sqlDel);

        for (var i = 0; i < dt.Rows.Count; i++)
        {
            if (i == 0)
                continue; // 第0行，列标题不读取。

            var row = dt.Rows[i];
            var modelID = 22; //客户选择型号ID
            var plug = row["航插"].ToString();
            var PlugFoot = row["航插引脚"].ToString();
            var LineNO = row["线号"].ToString();
            var LineDesc = row["线号定义说明"].ToString();

            var LineType = 1;
            // 0：代表输入。xls配置表写In，检测点DI。 1：代表输出，xls配置表写Out ，控制点DO。
            var typeStr = row["线号类型"].ToString().ToUpper();
            LineType = typeStr == "OUT" || typeStr == "输出" ? 1 : 0;

            var InitValue = row["初始状态"].ToString().ToInt();

            var CardNo = row["板卡号"].ToString().ToInt();

            var CardFoot = row["板卡点位号"].ToString().ToInt();

            var sql =
                $"insert into DIDOConfig(ModelID,Plug,PlugFoot,LineNO,LineDesc,LineType,InitValue,CardNo,CardFoot) values({modelID},'{plug}','{PlugFoot}','{LineNO}','{LineDesc}',{LineType},{InitValue},{CardNo},{CardFoot})";
            this.ExecuteNonQuery(sql);
        }
    }

    public void InsertExcelDataNew(DataTable dt, int ModelID)
    {
        Init();

        var sqlDel = $"delete from DIDOConfig where modelID={ModelID}";
        var delcnt = this.ExecuteNonQuery(sqlDel);

        for (var i = 0; i < dt.Rows.Count; i++)
        {
            //if (i == 0)
            //    continue; // 第0行，列标题不读取。

            var row = dt.Rows[i];
            var modelID = ModelID; //客户选择型号ID
            var plug = row["航插"].ToString();
            var PlugFoot = row["航插引脚"].ToString();
            var LineNO = row["线号"].ToString();
            var LineDesc = row["线号定义说明"].ToString();

            var LineType = 1;
            // 0：代表输入。xls配置表写In，检测点DI。 1：代表输出，xls配置表写Out ，控制点DO。
            var typeStr = row["线号类型"].ToString().ToUpper();

            if (typeStr == "" || typeStr == null)
                LineType = 2;
            else
                LineType = typeStr == "OUT" || typeStr == "输出" ? 1 : 0;


            var InitValue = row["初始状态"].ToString().ToInt();

            var CardNo = row["板卡号"].ToString().ToInt();

            var CardFoot = row["板卡点位号"].ToString().ToInt();

            var sql =
                $"insert into DIDOConfig(ModelID,Plug,PlugFoot,LineNO,LineDesc,LineType,InitValue,CardNo,CardFoot) values({modelID},'{plug}','{PlugFoot}','{LineNO}','{LineDesc}',{LineType},{InitValue},{CardNo},{CardFoot})";
            this.ExecuteNonQuery(sql);
        }
    }

    public DataTable ModifyDataColumNmae(DataTable dt)
    {
        dt.Columns[0].ColumnName = "colDataLabel";
        dt.Columns[1].ColumnName = "colDataType";
        dt.Columns[2].ColumnName = "colDataUnit";
        dt.Columns[3].ColumnName = "colMVBPort";
        dt.Columns[4].ColumnName = "colMVBOffset";
        dt.Columns[5].ColumnName = "colMVBBit";
        dt.Columns[6].ColumnName = "colMVBGroupOffset";
        dt.Columns[7].ColumnName = "colBitValue";
        dt.Columns[8].ColumnName = "colPortPattern";
        dt.Columns[9].ColumnName = "colIdentity";
        dt.Columns[10].ColumnName = "colIsRead";
        dt.Columns[11].ColumnName = "colIsCRC";
        dt.Columns[12].ColumnName = "colDescription";
        return dt;
    }

    public DataTable ModifyCANDataColumNmae(DataTable dt)
    {
        dt.Columns[0].ColumnName = "colDataLabel";
        dt.Columns[1].ColumnName = "colDataType";
        dt.Columns[2].ColumnName = "colDataUnit";
        dt.Columns[3].ColumnName = "colCANID";
        dt.Columns[4].ColumnName = "colCANOffset";
        dt.Columns[5].ColumnName = "colCANBit";
        dt.Columns[6].ColumnName = "colBitValue";
        dt.Columns[7].ColumnName = "colPortPattern";
        dt.Columns[8].ColumnName = "colIdentity";
        dt.Columns[9].ColumnName = "colIsRead";
        dt.Columns[10].ColumnName = "colDescription";
        return dt;
    }

    public void InsertExcelDataNew(DataTable dt, int ModelID, string TableName, string ModelName)
    {
        Init();
        var sqlDel = string.Format("delete from {0} where ModelNameID={1}", TableName, ModelID);
        this.ExecuteNonQuery(sqlDel);

        for (var i = 0; i < dt.Rows.Count; i++)
        {
            var row = dt.Rows[i];
            // ========== 新增:跳过空白行 ==========
            var DataLabel = row["colDataLabel"].ToString();
            if (string.IsNullOrWhiteSpace(DataLabel))
                continue; // 如果数据标签为空，跳过此行
            // ==================================== 
            var DataType = row["colDataType"].ToString();
            var DataUnit = row["colDataUnit"].ToString();
            var MVBOffset = row["colMVBOffset"].ToString();
            var MVBPort = row["colMVBPort"].ToString();
            var Identity = row["colIdentity"].ToString().ToBool();
            var MVBBit = row["colMVBBit"].ToString().ToInt();
            var GroupOffset = row["colMVBGroupOffset"].ToString();
            var Description = row["colDescription"].ToString();
            var IsRead = row["colIsRead"].ToString().ToBool();
            var PortPattern = row["colPortPattern"].ToString().ToBool();
            var BitValue = row["colBitValue"].ToString().ToDouble();
            var IsCRC = row["colIsCRC"].ToString().ToBool();
            Debug.WriteLine($"数据类型名称：{DataLabel}，数据行：{row.ItemArray.ToArrayString()}");
            var sql =
                $"insert into {TableName}(DataLabel,DataType,DataUnit,MVBOffset,MVBPort,[Identity],MVBBit,GroupOffset,Description,ModelNameID,[IsRead],[PortPattern],BitValue,TypeName,IsCRC) values('{DataLabel}','{DataType}','{DataUnit}','{MVBOffset}','{MVBPort}',{Identity},'{MVBBit}','{GroupOffset}','{Description}','{ModelID}',{IsRead},{PortPattern},{BitValue},'{ModelName}',{IsCRC})";
            this.ExecuteNonQuery(sql);
        }
    }

    public void InsertExcelCANDataNew(DataTable dt, int ModelID, string TableName)
    {
        Init();
        var sqlDel = string.Format("delete from {0} where ModelNameID={1}", TableName, ModelID);
        this.ExecuteNonQuery(sqlDel);

        for (var i = 0; i < dt.Rows.Count; i++)
        {
            var row = dt.Rows[i];
            var DataLabel = row["colDataLabel"].ToString();
            var DataType = row["colDataType"].ToString();
            var DataUnit = row["colDataUnit"].ToString();
            var CANOffset = row["colCANOffset"].ToString();
            var CANID = row["colCANID"].ToString();
            var Identity = row["colIdentity"].ToString().ToBool();
            var CANBit = row["colCANBit"].ToString().ToInt();
            var Description = row["colDescription"].ToString();
            var IsRead = row["colIsRead"].ToString().ToBool();
            var PortPattern = row["colPortPattern"].ToString().ToBool();
            var BitValue = row["colBitValue"].ToString().ToDouble();

            var sql =
                $"insert into {TableName}(DataLabel,DataType,DataUnit,CANOffset,CANID,[Identity],CANBit,Description,ModelNameID,[IsRead],[PortPattern],BitValue) values('{DataLabel}','{DataType}','{DataUnit}','{CANOffset}','{CANID}',{Identity},'{CANBit}','{Description}','{ModelID}',{IsRead},{PortPattern},{BitValue})";
            this.ExecuteNonQuery(sql);
        }
    }


    #region ========== 【新增】配方导入方法 ==========

    /// <summary>
    /// 导入Excel数据到指定配方
    /// 注意：ModelID字段存储的是配方ID（SchemeID）
    /// </summary>
    /// <param name="dt">Excel数据表（需先调用ModifyColumNmae处理列名）</param>
    /// <param name="schemeId">配方ID</param>
    public void InsertExcelDataToScheme(DataTable dt, int schemeId)
    {
        Init();

        // 删除该配方的旧配置数据
        string sqlDel = $"DELETE FROM DIDOConfig WHERE ModelID = {schemeId}";
        this.ExecuteNonQuery(sqlDel);

        // 逐行插入新数据
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            DataRow row = dt.Rows[i];

            string plug = row["航插"]?.ToString() ?? "";
            string plugFoot = row["航插引脚"]?.ToString() ?? "";
            string lineNO = row["线号"]?.ToString() ?? "";
            string lineDesc = row["线号定义说明"]?.ToString() ?? "";

            // 解析线号类型
            // 0：代表输入(DI)，xls配置表写In
            // 1：代表输出(DO)，xls配置表写Out
            // 2：空类型
            int lineType = 2;
            string typeStr = row["线号类型"]?.ToString()?.ToUpper() ?? "";
            if (!string.IsNullOrEmpty(typeStr))
            {
                lineType = (typeStr == "OUT" || typeStr == "输出") ? 1 : 0;
            }

            int initValue = row["初始状态"]?.ToString().ToInt() ?? 0;
            int cardNo = row["板卡号"]?.ToString().ToInt() ?? 0;
            int cardFoot = row["板卡点位号"]?.ToString().ToInt() ?? 0;

            // 跳过空行（线号为空则跳过）
            if (string.IsNullOrWhiteSpace(lineNO))
                continue;

            string sql = $@"INSERT INTO DIDOConfig(ModelID, Plug, PlugFoot, LineNO, LineDesc, LineType, InitValue, CardNo, CardFoot) 
                               VALUES({schemeId}, '{plug}', '{plugFoot}', '{lineNO}', '{lineDesc}', {lineType}, {initValue}, {cardNo}, {cardFoot})";
            this.ExecuteNonQuery(sql);
        }
    }

    /// <summary>
    /// 验证Excel数据格式是否正确
    /// </summary>
    /// <param name="dt">Excel数据表</param>
    /// <returns>验证结果，空字符串表示验证通过</returns>
    public string ValidateExcelData(DataTable dt)
    {
        if (dt == null || dt.Rows.Count == 0)
            return "Excel文件为空或没有数据";

        if (dt.Columns.Count < 8)
            return "Excel列数不足，需要至少8列（航插、航插引脚、线号、线号定义说明、线号类型、初始状态、板卡号、板卡点位号）";

        // 检查是否有有效数据行
        int validRowCount = 0;
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string lineNO = dt.Rows[i]["线号"]?.ToString() ?? "";
            if (!string.IsNullOrWhiteSpace(lineNO))
                validRowCount++;
        }

        if (validRowCount == 0)
            return "Excel中没有有效的数据行（线号列不能全为空）";

        return ""; // 验证通过
    }

    #endregion
}