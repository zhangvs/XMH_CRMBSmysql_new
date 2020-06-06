using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.JScript;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Text.RegularExpressions;

namespace XHD.Common
{
    public class GetGridJSON
    {
        public GetGridJSON() 
        {
        
        }

        #region
        public static string DataTableToJSON(DataTable dt)
        {
            try
            {
                string rowsjson = JsonConvert.SerializeObject(dt, new DataTableConverter());
                string json = @"{""Rows"":" + rowsjson + @",""Total"":""" + dt.Rows.Count.ToString() + @"""}";
                return json;
            }
            catch (Exception )
            {
                return "{Rows:[],Total:0}";
            }
        }

        public static string DataTableToJSON1(DataTable dt,string Total)
        {
            try
            {
                string rowsjson = JsonConvert.SerializeObject(dt, new DataTableConverter());
                string json = @"{""Rows"":" + rowsjson + @",""Total"":""" + Total + @"""}";
                return json;
            }
            catch (Exception )
            {
                return "{Rows:[],Total:0}";
            }
        }
        /// <summary>
        /// 普通数组json
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTableToJSON2(DataTable dt)
        {
            try
            {
                string rowsjson = JsonConvert.SerializeObject(dt, new DataTableConverter());               
                return rowsjson;
            }
            catch (Exception )
            {
                return "[]";
            }
        }



        //Json转DataTable方法
        public static DataTable JsonToDataTable(string strJson)
        {
            //转换json格式
            strJson = strJson.Replace(",\"", "*\"").Replace("\":", "\"#").ToString();
            //取出表名   
            var rg = new Regex(@"(?<={)[^:]+(?=:\[)", RegexOptions.IgnoreCase);
            string strName = rg.Match(strJson).Value;
            DataTable tb = null;
            //去除表名   
            strJson = strJson.Substring(strJson.IndexOf("[") + 1);
            strJson = strJson.Substring(0, strJson.IndexOf("]"));

            //获取数据   
            rg = new Regex(@"(?<={)[^}]+(?=})");
            MatchCollection mc = rg.Matches(strJson);
            for (int i = 0; i < mc.Count; i++)
            {
                string strRow = mc[i].Value;
                string[] strRows = strRow.Split('*');

                //创建表   
                if (tb == null)
                {
                    tb = new DataTable();
                    tb.TableName = strName;
                    foreach (string str in strRows)
                    {
                        var dc = new DataColumn();
                        string[] strCell = str.Split('#');

                        if (strCell[0].Substring(0, 1) == "\"")
                        {
                            int a = strCell[0].Length;
                            dc.ColumnName = strCell[0].Substring(1, a - 2);
                        }
                        else
                        {
                            dc.ColumnName = strCell[0];
                        }
                        tb.Columns.Add(dc);
                    }
                    tb.AcceptChanges();
                }

                //增加内容   
                DataRow dr = tb.NewRow();
                for (int r = 0; r < strRows.Length; r++)
                {
                    dr[r] = strRows[r].Split('#')[1].Trim().Replace("，", ",").Replace("：", ":").Replace("\"", "");
                }
                tb.Rows.Add(dr);
                tb.AcceptChanges();
            }

            return tb;
        }



        #endregion
    }
}
