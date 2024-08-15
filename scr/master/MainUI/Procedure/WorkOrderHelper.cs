using MainUI.Config;
using MainUI.Model.Workinterface;
using MainUI.Workinterface;
using Newtonsoft.Json;
using RW.EventLog;
using RW.Log;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Procedure
{
    public class WorkOrderHelper
    {
        /// <summary>
        /// 获取地址参数
        /// </summary>
        /// <returns></returns>
        private WorkOrderConfig CaaCongig()
        {
            WorkOrderConfig congig = new WorkOrderConfig();
            congig.SetSectionName(VarHelper.PortName);
            congig.Load();
            return congig;
        }


        private string DataIP(string Loadurl)
        {
            string url = $"http://{CaaCongig().IPaddress}:{CaaCongig().Prot}" + Loadurl;
            return url;
        }

        /// <summary>
        /// 异步POST获取Token
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="args">数据集</param>
        /// <returns></returns>
        public async Task<string> LoadToken(string url, Dictionary<string, string> args)
        {
            var token = "失败";
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(5);
                    var content = new FormUrlEncodedContent(args);
                    var response = await client.PostAsync(DataIP(url), content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    if (responseString != string.Empty)
                    {
                        JobTokenModels datas = JsonConvert.DeserializeObject<JobTokenModels>(responseString);
                        //Var.Token = token = datas.data.accessToken;
                    }
                    return token;
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                token = err;
                LogHelper.Append("Token获取失败：" + err);
            }
            return token;
        }

        /// <summary>
        /// POST请求数据
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="token">token</param>
        /// <param name="args">数据集</param>
        /// <returns></returns>
        public async Task<string> UploadData(string url, string token, Dictionary<string, string> args)
        {
            var responseString = "请求错误";
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(5);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); // 将token添加到HTTP头中
                    var content = new FormUrlEncodedContent(args); // 创建FormUrlEncodedContent
                    var response = await client.PostAsync(DataIP(url), content); // 发送POST请求
                    responseString = await response.Content.ReadAsStringAsync(); //读取响应内容
                    return responseString;
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                responseString = err;
                LogHelper.Append("POST请求失败：" + err);
            }
            return responseString;
        }

        /// <summary>
        /// 作业工单上传
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="filePath">pdf地址</param>
        /// <param name="formData">作业数据</param>
        /// <returns></returns>
        public async Task<string> UploadFileAsync(string url, string filePath, Dictionary<string, string> formData)
        {
            var responseString = "请求失败";
            try
            {
                // 创建 MultipartFormDataContent
                var content = new MultipartFormDataContent();
                HttpClient client = new HttpClient();
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Var.Token); // 将token添加到HTTP头中

                var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read); // 添加文件
                var fileContent = new StreamContent(fileStream);
                fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "spdf", // 服务器端接收文件时的参数名
                    FileName = Path.GetFileName(filePath)
                };
                content.Add(fileContent, "spdf", Path.GetFileName(filePath));

                // 添加其他表单数据
                foreach (var keyValuePair in formData)
                    content.Add(new StringContent(keyValuePair.Value ?? ""), keyValuePair.Key); //Nullable<string>

                client.Timeout = TimeSpan.FromSeconds(5);

                // 上传文件
                var response = await client.PostAsync(DataIP(url), content);
                responseString = await response.Content.ReadAsStringAsync(); //读取响应内容
                return responseString;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                responseString = err;
                LogHelper.Append("请求失败：" + err);
            }
            return responseString;
        }

        /// <summary>
        /// 是否为JSON数据
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public bool IsValidJson(string strInput)
        {
            if (string.IsNullOrWhiteSpace(strInput)) { return false; }
            strInput = strInput.Trim();
            try
            {
                var obj = JsonConvert.DeserializeObject(strInput);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
