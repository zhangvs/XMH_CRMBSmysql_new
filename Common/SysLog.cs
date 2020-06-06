/******************************************************************************
 * * 文件用途： 系统日志处理类  
 * * 完成日期： 2016-11-03
 * * 文件名称： SysLog.cs
 * * 作    者： sean
 * * 版本:1.0
 * * 备    注：生成的日志文件在系统根目录
 * *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;

namespace XHD.Common
{
    public class SysLog
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SysLog()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        #region 写日志
        public static void WriteLog(string strMsg)
        {
            if (strMsg != "")
            {
                StreamWriter sw = null;
                try
                {
                    string strDir = HttpContext.Current.Server.MapPath(@"~/App_Code/Log/");//SysLog.GetMapPath("Log");
                    if (!Directory.Exists(strDir))
                    {
                        Directory.CreateDirectory(strDir);
                    }
                    string strFileName = strDir + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
                    sw = new StreamWriter(strFileName, true);
                    strMsg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":" + strMsg;
                    sw.WriteLine(strMsg);
                    sw.WriteLine("====================================================");
                }
                catch
                {

                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                        sw = null;
                    }
                }
            }
        }
        /// <summary>
        /// 写日志信息
        /// </summary>         
        public static void WriteLog(string strMsg, string logName = "")
        {
            if (strMsg != "")
            {
                StreamWriter sw = null;
                try
                {
                    string strDir = SysLog.GetMapPath("");
                    if (!Directory.Exists(strDir))
                    {
                        Directory.CreateDirectory(strDir);
                    }
                    string strFileName = strDir + "\\" + DateTime.Now.ToString("yyyyMMdd") + logName + ".log";
                    sw = new StreamWriter(strFileName, true);
                    strMsg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":" + strMsg;
                    sw.WriteLine(strMsg);
                    sw.WriteLine("================================================");
                }
                catch
                {

                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                        sw = null;
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// 获得当前绝对路径,含web和winform应用程序方法       
        /// </summary>
        /// <param name="strPath">指定的路径</param>
        /// <returns>绝对路径</returns>
        public static string GetMapPath(string strPath)
        {
            if (HttpContext.Current != null)
            {
                //如果是web
                return HttpContext.Current.Server.MapPath(@"~/file/AppLog/" + strPath); //context.Server.MapPath(@"~/file/customer/" + filename);
            }
            else //非web程序引用
            {
                if (strPath.StartsWith("~/"))
                    strPath = strPath.Substring(2);
                else if (strPath.StartsWith("/"))
                    strPath = strPath.Substring(1);
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, strPath);
            }
        }
    }
}