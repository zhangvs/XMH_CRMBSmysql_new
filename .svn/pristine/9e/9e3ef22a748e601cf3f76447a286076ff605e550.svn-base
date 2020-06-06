using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace XHD.Common
{
    public class HttpPost
    {
        /// <summary>
        /// 提交数据请求  方法一
        /// </summary>
        /// <param name="POSTURL">请求提交的地址 如：http://xxx.xxx.xxx/interface/TestPostRequest</param>
        /// <param name="PostData">提交的数据(字符串)</param>
        /// <returns></returns>
        public static string RequestData(string POSTURL, string PostData)
        {
            //发送请求的数据
            WebRequest myHttpWebRequest = WebRequest.Create(POSTURL);
            myHttpWebRequest.Method = "POST";
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] byte1 = encoding.GetBytes(PostData);
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = byte1.Length;
            Stream newStream = myHttpWebRequest.GetRequestStream();
            newStream.Write(byte1, 0, byte1.Length);
            newStream.Close();

            //发送成功后接收返回的XML信息
            HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
            string lcHtml = string.Empty;
            Encoding enc = Encoding.GetEncoding("UTF-8");
            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream, enc);
            lcHtml = streamReader.ReadToEnd();
            return lcHtml;
        }

        /// <summary>
        /// json数据格式请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dataStr"></param>
        /// <returns></returns>
        public static string HttpPostRequest(string url, string dataStr)
        {
            HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(url);
            wReq.Method = "Post";
            wReq.ContentType = "application/json";
            wReq.ContentType = "application/x-www-form-urlencoded";
            byte[] data = Encoding.Default.GetBytes(HttpUtility.UrlEncode(dataStr));
            //byte[] data = Encoding.Default.GetBytes(jsondata);
            wReq.ContentLength = data.Length;
            Stream reqStream = wReq.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            reqStream.Close();
            string result = "";
            using (StreamReader sr = new StreamReader(wReq.GetResponse().GetResponseStream()))
            {
                result = sr.ReadToEnd();
            }

            return result;
        }

        public static string HttpGet(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        public static string HttpPost1(string Url, string postDataStr)
        {
            string temp = ConfigurationManager.AppSettings["isWriteLog"];

            if (temp == "true")
            {
                //写入日志
                SysLog.WriteLog("【请求信息】" + Url + postDataStr, "接口访问记录");
            }

            string result = string.Empty;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            #region 添加Post 参数
            byte[] data = Encoding.UTF8.GetBytes(postDataStr);
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容  
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }

            if (temp == "true")
            {
                //写入日志
                SysLog.WriteLog("【返回信息】" + result, "接口访问记录");
            }
            return result;
        }
    }
}
