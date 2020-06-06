using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XHD.DBUtility;

namespace XMH.crmService.Data
{
    public class Data_Integral
    {
        /// <summary>
        /// 统计积分列表
        /// </summary>
        public DataSet GetStatistics(string strWhere, string strWhereOne, string strWhereTwo, string strWhereThree, string strWhereFoure, string strWhereFive)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" select  h.ID,h.name,h.d_id,h.dname,h.Factory_Id,ifnull(sumAvg,0) as sumAvg,ifnull(oldSum,0) as oldSum,ifnull(summ,0) as summ,sum(ifNUll(oldSum,0)+ifNUll(summ,0)+ifNUll(sumAvg,0)) as num,ifnull(attendSum,0) as attendSum,ifnull(qSum,0) as qSum,sum(ifNUll(oldSum,0)+ifNUll(summ,0) + ifNUll(attendSum,0)+ ifNUll(qSum,0)+ifNUll(sumAvg,0) ) as countNum from ( ");
            strSql.Append(" ( select  ID,name,d_id,dname,Factory_Id  from hr_employee ) as h  ");
            strSql.Append(" left join ( select DtypeName,DtypeId,sum(score)as oldSum, UserName,UserId,CreateDate  from personal_score where  " + strWhereFoure + "  group by  UserId ) as p on h.ID=p.UserId  ");
            strSql.Append(" left join ( select d_name,d_id,sum(score)as summ, emp_name,emp_id,check_date  from ims_emp_score where  " + strWhereOne + "  group by  emp_id ) as s on h.ID=s.emp_id  ");
            strSql.Append(" left join ( select d_id,sum(score_average)as sumAvg, emp_name,emp_id from ims_lead_score_average  where   " + strWhereFive + "  group by  emp_id ) as av on h.ID=av.emp_id ");
            strSql.Append(" left join (select  emp_id,sum(attend_alldays) as attendSum  from oa_attend  where   " + strWhereTwo + "   group by emp_id )  a  on  h.ID=a.emp_id  ");
            strSql.Append(" left join (select  answer_id,sum(score) as qSum,answer_time from ssn_qa_answer  where  " + strWhereThree + " group by answer_id) as q on h.ID=q.answer_id ");
            strSql.Append(" )  ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" group by h.ID ");
            //strSql.Append(" order by h.ID ");

            return DbHelperMySQL.Query(strSql.ToString());
        }


        //记录每位员工的积分
        public bool RecordStatistics(DataTable dt, int year, int month, string beforeMouthLastDay)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    decimal score_from_oa = 0.00m;

                    int empId = Convert.ToInt32(dt.Rows[i]["ID"]);
                    DataSet ds = GetList("emp_id='" + empId + "'");
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        decimal score_total = 0.00m;
                        decimal score_from_ims = 0.00m;
                        decimal score_from_ssn = 0.00m;

                        score_total = Convert.ToDecimal(ds.Tables[0].Rows[0]["score_total"].ToString()) + Convert.ToDecimal(dt.Rows[i]["countNum"]);
                        score_from_ims = Convert.ToDecimal(ds.Tables[0].Rows[0]["score_from_ims"].ToString()) + Convert.ToDecimal(dt.Rows[i]["num"]);

                        score_from_oa = Convert.ToDecimal(ds.Tables[0].Rows[0]["score_from_oa"].ToString()) + Convert.ToDecimal(dt.Rows[i]["attendSum"]);

                        score_from_ssn = Convert.ToDecimal(ds.Tables[0].Rows[0]["score_from_ssn"].ToString()) + Convert.ToDecimal(dt.Rows[i]["qSum"]);

                        strSql = string.Format(@"update  ims_emp_score_total   set score_total='{0}',score_from_ims='{1}',score_from_oa='{2}',
                                                 score_from_ssn='{3}' where emp_id='{4}'",
                                                 score_total, score_from_ims, score_from_oa, score_from_ssn, Convert.ToInt32(dt.Rows[i]["ID"]));

                        strSqlList.Add(strSql);
                    }
                    else
                    {

                        strSql = string.Format(@"insert into ims_emp_score_total(Factory_Id,d_id,d_name,emp_id,emp_name,score_total,score_from_ims,score_from_oa,score_from_ssn) 
                                            values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                                           dt.Rows[i]["Factory_id"].ToString(), Convert.ToInt32(dt.Rows[i]["d_id"]), dt.Rows[i]["dname"].ToString(), Convert.ToInt32(dt.Rows[i]["ID"]),
                                           dt.Rows[i]["name"].ToString(), Convert.ToDecimal(dt.Rows[i]["countNum"]), Convert.ToDecimal(dt.Rows[i]["num"]),
                                           Convert.ToDecimal(dt.Rows[i]["attendSum"]), Convert.ToDecimal(dt.Rows[i]["qSum"]));

                        strSqlList.Add(strSql);
                    }

                    //personal_score
                    if (!string.IsNullOrEmpty(dt.Rows[i]["oldSum"].ToString()))
                    {
                        strSql = string.Format(@"update  personal_score  set is_scoring='{0}' where UserId='{1}' and CreateDate<='{2}' and is_scoring ='0' ",
                                                1, Convert.ToInt32(dt.Rows[i]["ID"]), beforeMouthLastDay);

                        strSqlList.Add(strSql);
                    }

                    //ims_emp_score
                    if (!string.IsNullOrEmpty(dt.Rows[i]["summ"].ToString()))
                    {
                        strSql = string.Format(@"update  ims_emp_score  set is_scoring='{0}' where emp_id='{1}' and check_date<='{2}'  and is_scoring ='0' ",
                                                1, Convert.ToInt32(dt.Rows[i]["ID"]), beforeMouthLastDay);

                        strSqlList.Add(strSql);
                    }

                    //ssn_qa_answer
                    if (!string.IsNullOrEmpty(dt.Rows[i]["qSum"].ToString()))
                    {
                        strSql = string.Format(@"update  ssn_qa_answer  set is_scoring='{0}' where answer_id='{1}' and answer_time<='{2}'  and is_scoring ='0' ",
                                                1, Convert.ToInt32(dt.Rows[i]["ID"]), beforeMouthLastDay);

                        strSqlList.Add(strSql);
                    }
                    
                    //ims_lead_score_average
                    if (!string.IsNullOrEmpty(dt.Rows[i]["sumAvg"].ToString()))
                    {
                        strSql = string.Format(@"update  ims_lead_score_average   set is_scoring='{0}' where emp_id='{1}' and year<='{2}' and month<='{3}' and is_scoring ='0' ",
                                                    1, Convert.ToInt32(dt.Rows[i]["ID"]), year, month);

                        strSqlList.Add(strSql);
                    }

                    //oa
                    if (!string.IsNullOrEmpty(dt.Rows[i]["attendSum"].ToString()))
                    {
                        strSql = string.Format(@"update  oa_attend   set is_scoring='{0}' where emp_id='{1}' and attend_year<='{2}' and attend_month<='{3}' and is_scoring ='0' ",
                                                1, Convert.ToInt32(dt.Rows[i]["ID"]), year, month);

                        strSqlList.Add(strSql);
                    }
                }
            }

            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 查询每一员工的积分
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from ims_emp_score_total ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

    }
}
