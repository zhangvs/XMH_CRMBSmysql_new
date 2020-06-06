using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using XHD.DBUtility;


namespace XHD.DMS.DMS
{
    /// <summary>
    /// DMS_TimeAxis 的摘要说明
    /// </summary>
    public class DMS_TimeAxis : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            BLL.ecs_order_info order = new BLL.ecs_order_info();

            if (request["Action"] == "getCurData")
            {
                ////获取当前时间并转为时间戳
                //DateTime now = DateTime.Now;
                //int nowtime = int.Parse(Common.TimeParser.GenerateTimeStamp(now));
                ////获取当前时间的前5分钟、
                //int pretime = nowtime - 300;
                ////获取当天凌晨时间戳
                //int daytime = int.Parse(Common.TimeParser.GenerateTimeStamp(DateTime.Parse(now.ToShortDateString())));

                int nowtime = int.Parse(request["nowtime"]);
                int pretime = int.Parse(request["pretime"]);
                int daytime = int.Parse(request["daytime"]);

                DataSet ds = order.getCurData(daytime, pretime, nowtime);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);

            }
            else if (request["Action"] == "getWillData")
            {
                int nowtime = int.Parse(request["nowtime"]);

                //获取10秒后的业绩
                DataSet ds = order.getWillData(nowtime);
                string dt = Common.DataToJson.DataToJSON(ds);
                context.Response.Write(dt);
            }

            #region 获取某月数据
            else if (request["Action"] == "getMonthData")
            {
                int starttime = 0;
                int endtime = 0;

                //获取前台设置时间
                DateTime date = DateTime.Parse(request["date"]);
                //获取系统当前时间
                DateTime now = DateTime.Now;

                //比较时间月份是否是本月
                if (date.Month == now.Month)
                {
                    starttime = int.Parse(Common.TimeParser.GenerateTimeStamp(date));
                    endtime = int.Parse(Common.TimeParser.GenerateTimeStamp(now));
                }
                else
                {
                    starttime = int.Parse(Common.TimeParser.GenerateTimeStamp(date));
                    //获取当月最后一天
                    DateTime lastDay = date.AddDays(1 - date.Day).AddMonths(1).AddDays(-1);
                    endtime = int.Parse(Common.TimeParser.GenerateTimeStamp(lastDay.AddHours(23).AddMinutes(59).AddSeconds(59)));
                }

                DataSet ds = order.getMonthData(starttime, endtime);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }
            #endregion

        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}