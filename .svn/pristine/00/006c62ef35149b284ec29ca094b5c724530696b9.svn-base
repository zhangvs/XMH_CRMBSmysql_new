using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace XHD.DAL.ims
{
    /// <summary>
    /// 数据访问类:ims_emp_score_details
    /// </summary>
    public partial class ims_emp_score_details
    {
        public ims_emp_score_details()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "ims_emp_score_details");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ims_emp_score_details");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ims.ims_emp_score_details model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ims_emp_score_details(");
            strSql.Append("id,score_id,rule_id,task_id,standard_id,isPlus,score,check_date)");
            strSql.Append(" values (");
            strSql.Append("@id,@score_id,@rule_id,@task_id,@standard_id,@isPlus,@score,@check_date)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@score_id", MySqlDbType.Int32,11),
					new MySqlParameter("@rule_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_id", MySqlDbType.Int32,11),
					new MySqlParameter("@standard_id", MySqlDbType.Int32,11),
					new MySqlParameter("@isPlus", MySqlDbType.VarChar,1),
					new MySqlParameter("@score", MySqlDbType.Decimal,16),
					new MySqlParameter("@check_date", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.score_id;
            parameters[2].Value = model.rule_id;
            parameters[3].Value = model.task_id;
            parameters[4].Value = model.standard_id;
            parameters[5].Value = model.isPlus;
            parameters[6].Value = model.score;
            parameters[7].Value = model.check_date;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ims.ims_emp_score_details model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ims_emp_score_details set ");
            strSql.Append("score_id=@score_id,");
            strSql.Append("rule_id=@rule_id,");
            strSql.Append("task_id=@task_id,");
            strSql.Append("standard_id=@standard_id,");
            strSql.Append("isPlus=@isPlus,");
            strSql.Append("score=@score,");
            strSql.Append("check_date=@check_date");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@score_id", MySqlDbType.Int32,11),
					new MySqlParameter("@rule_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_id", MySqlDbType.Int32,11),
					new MySqlParameter("@standard_id", MySqlDbType.Int32,11),
					new MySqlParameter("@isPlus", MySqlDbType.VarChar,1),
					new MySqlParameter("@score", MySqlDbType.Decimal,16),
					new MySqlParameter("@check_date", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.score_id;
            parameters[1].Value = model.rule_id;
            parameters[2].Value = model.task_id;
            parameters[3].Value = model.standard_id;
            parameters[4].Value = model.isPlus;
            parameters[5].Value = model.score;
            parameters[6].Value = model.check_date;
            parameters[7].Value = model.id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateScore(XHD.Model.ims.ims_emp_score_details model)
        {
            string strSql = string.Empty;

            strSql = string.Format(@" update ims_emp_score_details set isPlus='{0}',score='{1}' where score_id='{2}' and rule_id='{3}' and task_id='{4}' and standard_id='{5}' and check_date='{6}'",
                                       model.isPlus, model.score, model.score_id, model.rule_id, model.task_id, model.standard_id, model.check_date);

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ims_emp_score_details ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Deletes(int score_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ims_emp_score_details ");
            strSql.Append(" where score_id=@score_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@score_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = score_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ims_emp_score_details ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ims.ims_emp_score_details GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,score_id,rule_id,task_id,standard_id,isPlus,score,check_date from ims_emp_score_details ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.ims.ims_emp_score_details model = new XHD.Model.ims.ims_emp_score_details();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ims.ims_emp_score_details DataRowToModel(DataRow row)
        {
            XHD.Model.ims.ims_emp_score_details model = new XHD.Model.ims.ims_emp_score_details();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["score_id"] != null && row["score_id"].ToString() != "")
                {
                    model.score_id = int.Parse(row["score_id"].ToString());
                }
                if (row["rule_id"] != null && row["rule_id"].ToString() != "")
                {
                    model.rule_id = int.Parse(row["rule_id"].ToString());
                }
                if (row["task_id"] != null && row["task_id"].ToString() != "")
                {
                    model.task_id = int.Parse(row["task_id"].ToString());
                }
                if (row["standard_id"] != null && row["standard_id"].ToString() != "")
                {
                    model.standard_id = int.Parse(row["standard_id"].ToString());
                }
                if (row["isPlus"] != null)
                {
                    model.isPlus = row["isPlus"].ToString();
                }
                if (row["score"] != null && row["score"].ToString() != "")
                {
                    model.score = decimal.Parse(row["score"].ToString());
                }
                if (row["check_date"] != null && row["check_date"].ToString() != "")
                {
                    model.check_date = row["check_date"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,score_id,rule_id,task_id,standard_id,isPlus,score,check_date ");
            strSql.Append(" FROM ims_emp_score_details ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取积分详情
        /// </summary>
        public DataSet GetScoreDetails(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select d.id,d.score_id,s.id,s.rule_name, d.task_id,t.task_name, d.standard_id,st.standard_name,d.score,d.check_date  from ims_emp_score_details  d ");
            strSql.Append(" left join  ims_emp_score s on d.score_id=s.id ");
            strSql.Append(" left join ims_check_task t on t.id=d.task_id ");
            strSql.Append(" left join ims_check_task_standard st on  st.id=d.standard_id ");

            strSql1.Append(" select count(d.id) from ims_emp_score_details  d ");
            strSql1.Append(" left join  ims_emp_score s on d.score_id=s.id ");
            strSql1.Append(" left join ims_check_task t on t.id=d.task_id ");
            strSql1.Append(" left join ims_check_task_standard st on  st.id=d.standard_id ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListTS(string strWhereOne, string strWhereTwo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select  s.*,t.task_name ,t.rule_id,ts.num,dd.*  from ims_check_task_standard  s ");
            strSql.Append(" left join  ims_check_task t on  s.task_id =t.id ");
            strSql.Append(" left join (select count(id) as num ,task_id from ims_check_task_standard  group by task_id )  as ts on ts.task_id =s.task_id ");
            strSql.Append(" left  join( ");
            strSql.Append(" select s.id as scoreId, s.emp_id,s.rule_name,s.check_date,d.standard_id ,d.isPlus ,d.score,d.task_id from ims_emp_score s ");
            strSql.Append(" left  join ims_emp_score_details d on d.score_id=s.id ");
            strSql.Append(" where " + strWhereTwo + "");
            strSql.Append(" ) as dd  on  dd.task_id=s.task_id");

            if (strWhereOne.Trim() != "")
            {
                strSql.Append(" where " + strWhereOne);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListT(string strWhereOne, string strWhereTwo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select t.*,ts.num,dd.*  from ims_check_task t ");
            strSql.Append(" left join (select count(id) as num ,task_id from ims_check_task_standard  group by task_id )  as ts on ts.task_id =t.id ");
            strSql.Append(" left  join( ");
            strSql.Append(" select s.id as scoreId, s.emp_id,s.rule_name,s.check_date,d.standard_id ,d.isPlus ,d.score,d.task_id from ims_emp_score s ");
            strSql.Append(" left  join ims_emp_score_details d on d.score_id=s.id ");
            strSql.Append(" where " + strWhereTwo + "");
            strSql.Append(" ) as dd  on  dd.task_id=t.id ");

            if (strWhereOne.Trim() != "")
            {
                strSql.Append(" where " + strWhereOne);
            }
            return DbHelperMySQL.Query(strSql.ToString());

        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

