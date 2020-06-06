using XHD.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FMS_DAL
{
    public partial class FMS_SqlHelperClass
    {


        public FMS_SqlHelperClass()
        { }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="filedlist"></param>
        /// <param name="strWhere"></param>
        /// <param name="tableName"></param>
        /// <param name="filedOrder"></param>
        /// <param name="Total"></param>
        /// <returns></returns>
        public DataSet GetPageData(int pageSize, int pageIndex, string filedlist, string strWhere, string tableName, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("Select " + filedlist + "  From " + tableName);
            strSql1.Append(" select count(*) From " + tableName);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (pageIndex - 1) * pageSize + "," + pageSize);

            Total = FMS_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return FMS_DbHelperMySQL.Query(strSql.ToString());

        }

        /// <summary>
        /// 简单获取表数据
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public DataSet Sql_DataSet(string sqlstr)
        {
            return FMS_DbHelperMySQL.Query(sqlstr);
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="sqlLst"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool ExecuteSqlTran(List<string> sqlLst, out string msg)
        {
            try
            {
                int count = FMS_DbHelperMySQL.ExecuteSqlTran(sqlLst);
                if (count > 0)
                {
                    msg = "执行成功";
                    return true;

                }
                else
                {
                    msg = "执行失败";
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = e.ToString();
                return false;
            }

        }

        /// <summary>
        /// 获取查询DS结果
        /// </summary>
        /// <param name="filedlist"></param>
        /// <param name="strWhere"></param>
        /// <param name="tableName"></param>
        /// <param name="filedOrder"></param>
        /// <param name="Total"></param>
        /// <returns></returns>
        public DataSet GetAllData(string filedlist, string strWhere, string tableName, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            //StringBuilder strSql1 = new StringBuilder();
            strSql.Append("Select " + filedlist + "  From " + tableName);
            //strSql1.Append(" select count(*) From " + tableName);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                //strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  ");
            Total = "0";
            return FMS_DbHelperMySQL.Query(strSql.ToString());

        }

        /// <summary>
        /// 获取单据号码
        /// </summary>
        /// <returns></returns>
        public string GetDJHM()
        {
            String strsql = "Call FHDJHM";

            DataSet ds = DbHelperMySQL.Query(strsql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]["DJHM"].ToString();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 执行sq语句返货结果
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public bool RunSql(string sqlstr)
        {

            try
            {
                int rows = FMS_DbHelperMySQL.ExecuteSql(sqlstr);
                if (rows > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// 获取年月
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public void GetYearAndMonth(out string year, out string month)
        {
            string tempsql = "select YE,QY from zt11 limit 1";
            DataSet ds = DbHelperMySQL.Query(tempsql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                year = row["YE"].ToString();
                month = row["QY"].ToString();
            }
            else
            {
                year = "";
                month = "";
            }
        }



    }
}

