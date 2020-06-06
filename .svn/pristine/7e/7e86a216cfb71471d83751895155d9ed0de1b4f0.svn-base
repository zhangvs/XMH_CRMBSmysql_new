using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace XHD.Common
{
    public static class CommonData
    {
        static string[] strArr;

        /// <summary>
        /// 过滤SQL注入攻击语句
        /// </summary>
        /// <param name="strOj"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool getSQLPercolation(string strOj, string path)
        {
            string[] strLine = File.ReadAllLines(path, Encoding.Default);
            if (strLine != null && strLine.Length > 0)
            {
                //int number = 1;
                int flag = -1;
                foreach (string item in strLine)
                {
                    strArr = item.Split('|');
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        flag = strOj.IndexOf(strArr[i].ToString());
                        if (flag >= 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
       
        
        /// <summary>
        /// 特殊字符过滤函数
        /// </summary>
        /// <param name="strOj">要过滤字符串</param>
        /// <returns></returns>
        public static string getSpecialLetter(string strOj, string path)
        {
            //string path = new Page().Server.MapPath(@"../../Files/SpecialLette.txt");//特殊字符路径
            string[] strLine = File.ReadAllLines(path, Encoding.Default);
            if (strLine != null && strLine.Length > 0)
            {

                foreach (string item in strLine)
                {
                    strArr = item.Split('|');
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        if (strOj.Contains(strArr[i].ToString()))
                        {
                            strOj = strOj.Replace(strArr[i].ToString(), "");
                        }
                    }
                }
            }
            return strOj;
        }


        //获得IP
        public static string GetClientIPv4Address()
        {
            string ipv4 = String.Empty;

            foreach (IPAddress ip in Dns.GetHostAddresses(GetClientIP()))
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipv4 = ip.ToString();
                    break;
                }
            }

            if (ipv4 != String.Empty)
            {
                return ipv4;
            }
            // 利用 Dns.GetHostEntry 方法，由获取的 IPv6 位址反查 DNS 纪录，
            // 再逐一判断何者为 IPv4 协议，即可转为 IPv4 位址。
            foreach (IPAddress ip in Dns.GetHostEntry(GetClientIP()).AddressList)
            //foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipv4 = ip.ToString();
                    break;
                }
            }

            return ipv4;
        }
        public static string GetClientIP()
        {
            if (null == HttpContext.Current.Request.ServerVariables["HTTP_VIA"])
            {
                return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            else
            {
                return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            }
        }
    }
}
