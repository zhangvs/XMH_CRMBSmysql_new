﻿using XHD.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using XHD.Model.wms;

namespace XHD.DAL
{
    public partial class SqlHelperClass
    {


        public SqlHelperClass()
        { }

        /// <summary>
        /// 获取单据号码
        /// </summary>
        /// <param name="hearder"></param>
        /// <returns></returns>
        public string GetSN(string hearder)
        {

            try
            {
                DataSet ds = DbHelperMySQL.Query("call xmh_wms.GetOrderSN(" + hearder + ");");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string num = ds.Tables[0].Rows[0][0].ToString();

                    if (num.Length < 5)
                    {
                        num = num.PadLeft(5, '0');
                    }
                    string timeStr = DateTime.Now.ToString("yyMMdd");
                    string re_str = hearder + timeStr + num;
                    return re_str;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }

        }



        public FmsSetting_Response GetFmsSetting()
        {
            FmsSetting_Response result = new FmsSetting_Response();
            try
            {
                //查询快递设置信息语句
                string sqlstr = "select param_name,value from xmh_wms.wms_app_setting where app_name='xmh_fms';";
                DataSet ds = DbHelperMySQL.Query(sqlstr);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    //通过linq查询转DataTable为List，以便使用lamda公式
                    DataTable dt = ds.Tables[0];
                    var query = (from t in dt.AsEnumerable()
                                 select new
                                 {
                                     param_name = t.Field<string>("param_name"),
                                     value = t.Field<string>("value")
                                 }).ToList();
                    result.period_start = query.Where(m => m.param_name == "period_start").FirstOrDefault().value;
                    result.lock_start = query.Where(m => m.param_name == "lock_start").FirstOrDefault().value;
                    result.lock_end = query.Where(m => m.param_name == "lock_end").FirstOrDefault().value;
                    result.success = true;

                }
                else
                {
                    result.success = false;
                    result.msg = "快递设置获取失败";
                }
                return result;
            }
            catch (Exception e)
            {
                result.success = false;
                result.msg = e.Message;
                return result;
            }
        }





        //获取分页数据
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
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());

        }

        //简单获取表数据
        public DataSet Sql_DataSet(string sqlstr)
        {
            return DbHelperMySQL.Query(sqlstr);
        }

        //执行存储过程
        public bool ExecuteSqlTran(List<string> sqlLst, out string msg)
        {
            try
            {
                int count = DbHelperMySQL.ExecuteSqlTran(sqlLst);
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

        //获取查询DS结果
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
            return DbHelperMySQL.Query(strSql.ToString());

        }

        //获取单据号码
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

        //执行sq语句返货结果
        public bool RunSql(string sqlstr)
        {

            try
            {
                int rows = DbHelperMySQL.ExecuteSql(sqlstr);
                if (rows > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //获取年月
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

        public string GetToken()
        {
            string sql = "select sys_value from  sys_info where sys_key='sys_kingdee_token'";
            try
            {
                DataSet ds = DbHelperMySQL.Query(sql);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }
        }


        public string GetKingDee_depcode(string emp_code)
        {
            string sql = "select bb.dept_code_kingdee from hr_employee aa inner join hr_department bb on aa.d_id=bb.id and aa.emp_code='" + emp_code + "';";
            try
            {
                DataSet ds = DbHelperMySQL.Query(sql);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// 获取人员编号
        /// </summary>
        /// <param name="p_type">1.员工，2.部门，3.供应商</param>
        /// <returns></returns>
        public string GetPNO_DAL(int p_type)
        {
            try
            {
                //获取年月
                string ym_no = DateTime.Now.ToString("yyyyMM");
                //调用存储过程
                DataSet ds = DbHelperMySQL.Query("call xmh_wms.WMS_GetPNO('" + ym_no + "'," + p_type + ");");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string num = ds.Tables[0].Rows[0][0].ToString();
                    //判断数据位数
                    if (num.Length < 4)
                    {
                        num = num.PadLeft(4, '0');
                    }
                    string re_str = ym_no + p_type + num;
                    return re_str;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// 根据类型获取获取发票编码
        /// </summary>
        /// <param name="p_type"></param>
        /// <returns></returns>
        public string GetInvoiceSN_DAL(int p_type)
        {
            try
            {
                //获取年月
                string ym_no = string.Empty;

                //根据不同类型返回不同编码
                switch (p_type)
                {
                    case 1: ym_no = DateTime.Now.ToString("yyyyMMdd"); break;
                    case 2: ym_no = DateTime.Now.ToString("yyyy-MM-dd-"); break;
                    default: return "";
                }

                //调用存储过程
                DataSet ds = Shop_DbHelperMySQL.Query("call GetInvoicesSN('" + ym_no + "'," + p_type + ");");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string num = ds.Tables[0].Rows[0][0].ToString();
                    //判断数据位数
                    if (num.Length < 4)
                    {
                        num = num.PadLeft(4, '0');
                    }
                    string re_str = ym_no + num;
                    return re_str;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
