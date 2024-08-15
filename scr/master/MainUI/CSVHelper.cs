using MainUI.Procedure;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace MainUI
{
    public class CSVHelper
    {
        /// <summary>
        /// 创建文件。目录不存在则创建目录。
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string CreateFile(string fileName)
        {
            FileStream fs = null;
            try
            {
                //目录文件夹不存在，则创建文件夹
                string root = System.IO.Path.GetDirectoryName(fileName);
                if (!Directory.Exists(root))
                    Directory.CreateDirectory(root);
                if (!File.Exists(fileName))
                    fs = File.Create(fileName);
            }
            catch (Exception ex)
            { Debug.WriteLine(ex.Message); }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }
            return fileName;
        }

        /// <summary>
        ///  保存数据到csv文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool Save(string path, object[] data)
        {
            bool ok = true;
            StreamWriter sw = null;
            try
            {
                //此处的true代表续写，false代表覆盖
                sw = new StreamWriter(path, true, Encoding.Default);
                if (!File.Exists(path) || new FileInfo(path).Length == 0)
                    sw.WriteLine(string.Join(',', DataGatherHelper.strings));

                sw.WriteLine(string.Join(", ", data).TrimEnd(','));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                //如果写文件时，文件被打开则无法正常写入数据。
                ok = false;
            }
            finally
            {
                if (sw != null)
                    sw.Dispose();
            }
            return ok;
        }

        public static bool Save<T>(string path, ConcurrentDictionary<string, T> pairs)
        {
            bool ok = true;
            StreamWriter sw = null;
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                var keys = pairs.OrderBy(k => k.Key).ToDictionary(k => k.Key, v => v.Value);
                //此处的true代表续写，false代表覆盖
                sw = new StreamWriter(path, true, Encoding.GetEncoding("GB2312"));
                if (!File.Exists(path) || new FileInfo(path).Length == 0)
                    sw.WriteLine(string.Join(',', DataGatherHelper.strings));

                string data = "";
                foreach (var p in keys)
                {
                    var json = JsonConvert.SerializeObject(p.Value).Replace(',', ';');
                    data += json + ",";
                }
                sw.WriteLine(data.TrimEnd(','));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                //如果写文件时，文件被打开则无法正常写入数据。
                ok = false;
            }
            finally
            {
                if (sw != null)
                    sw.Dispose();
            }
            return ok;
        }

        public static List<string> ReadAsList(string path)
        {
            if (!File.Exists(path))
                return new List<string>();
            List<string> lstObj = new List<string>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path, Encoding.UTF8);
                string str = string.Empty;
                while ((str = sr.ReadLine()) != null)
                {
                    lstObj.Add(str);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return lstObj;
            }
            finally
            {
                if (sr != null)
                    sr.Dispose();
            }
            return lstObj;
        }

        /// <summary>
        /// 读取CSV文件转换成表单
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataTable ReadAsDatatable(string path)
        {
            //Encoding.RegisterProvider 方法来注册自定义编码提供程序
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            DataTable dt = new();
            if (!File.Exists(path))
                return null;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path, Encoding.GetEncoding("GB2312"));
                string firstRow = sr.ReadLine();
                string[] colAry = firstRow.Split(',');
                for (int i = 0; i < colAry.Length; i++)
                    dt.Columns.Add(new DataColumn(colAry[i]));

                string str = string.Empty;
                while ((str = sr.ReadLine()) != null)
                {
                    DataRow row = dt.NewRow();
                    string[] contentAry = str.Split(',');
                    for (int i = 0; i < contentAry.Length; i++)
                    {
                        row[i] = contentAry[i].Replace(';', ',');
                    }
                    dt.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                throw new Exception(err);
            }
            finally
            {
                if (sr != null)
                    sr.Dispose();
            }

            return dt;
        }

        //  dicFault = MiniExcelLibs.MiniExcel.Query<FaultView>("故障解析表.xlsx").ToDictionary(x => x.FaultCode);
    }



}
