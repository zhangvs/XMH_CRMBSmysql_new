using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace XHD.DAL.ims
{
    /// <summary>
    /// 数据访问类:ims_lead_score_average
    /// </summary>
    public partial class ims_lead_score_average
    {
        public ims_lead_score_average()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "ims_lead_score_average");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ims_lead_score_average");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ims.ims_lead_score_average model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ims_lead_score_average(");
            strSql.Append("id,Factory_Id,year,month,rule_id,emp_id,emp_name,d_id,d_name,d_emp_total,real_check_num,score_total,score_average,check_date)");
            strSql.Append(" values (");
            strSql.Append("@id,@Factory_Id,@year,@month,@rule_id,@emp_id,@emp_name,@d_id,@d_name,@d_emp_total,@real_check_num,@score_total,@score_average,@check_date)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@year", MySqlDbType.Int32,4),
					new MySqlParameter("@month", MySqlDbType.Int32,2),
					new MySqlParameter("@rule_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@d_id", MySqlDbType.Int32,11),
					new MySqlParameter("@d_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@d_emp_total", MySqlDbType.Int32,11),
					new MySqlParameter("@real_check_num", MySqlDbType.Int32,11),
					new MySqlParameter("@score_total", MySqlDbType.Decimal,10),
					new MySqlParameter("@score_average", MySqlDbType.Decimal,10),
					new MySqlParameter("@check_date", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.Factory_Id;
            parameters[2].Value = model.year;
            parameters[3].Value = model.month;
            parameters[4].Value = model.rule_id;
            parameters[5].Value = model.emp_id;
            parameters[6].Value = model.emp_name;
            parameters[7].Value = model.d_id;
            parameters[8].Value = model.d_name;
            parameters[9].Value = model.d_emp_total;
            parameters[10].Value = model.real_check_num;
            parameters[11].Value = model.score_total;
            parameters[12].Value = model.score_average;
            parameters[13].Value = model.check_date;

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
        public bool Update(XHD.Model.ims.ims_lead_score_average model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ims_lead_score_average set ");
            //strSql.Append("year=@year,");
            //strSql.Append("month=@month,");
            strSql.Append("rule_id=@rule_id,");
            strSql.Append("emp_id=@emp_id,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("d_id=@d_id,");
            strSql.Append("d_name=@d_name,");
            strSql.Append("d_emp_total=@d_emp_total,");
            strSql.Append("real_check_num=@real_check_num,");
            strSql.Append("score_total=@score_total,");
            strSql.Append("score_average=@score_average");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
                    //new MySqlParameter("@year", MySqlDbType.Int32,4),
                    //new MySqlParameter("@month", MySqlDbType.Int32,2),
					new MySqlParameter("@rule_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@d_id", MySqlDbType.Int32,11),
					new MySqlParameter("@d_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@d_emp_total", MySqlDbType.Int32,11),
					new MySqlParameter("@real_check_num", MySqlDbType.Int32,11),
					new MySqlParameter("@score_total", MySqlDbType.Decimal,10),
					new MySqlParameter("@score_average", MySqlDbType.Decimal,10),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            //parameters[0].Value = model.year;
            //parameters[1].Value = model.month;
            parameters[0].Value = model.rule_id;
            parameters[1].Value = model.emp_id;
            parameters[2].Value = model.emp_name;
            parameters[3].Value = model.d_id;
            parameters[4].Value = model.d_name;
            parameters[5].Value = model.d_emp_total;
            parameters[6].Value = model.real_check_num;
            parameters[7].Value = model.score_total;
            parameters[8].Value = model.score_average;
            parameters[9].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ims_lead_score_average ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ims_lead_score_average ");
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
        public XHD.Model.ims.ims_lead_score_average GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,year,month,rule_id,emp_id,emp_name,d_id,d_name,d_emp_total,real_check_num,score_total,score_average,check_date from ims_lead_score_average ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.ims.ims_lead_score_average model = new XHD.Model.ims.ims_lead_score_average();
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
        public XHD.Model.ims.ims_lead_score_average DataRowToModel(DataRow row)
        {
            XHD.Model.ims.ims_lead_score_average model = new XHD.Model.ims.ims_lead_score_average();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["year"] != null && row["year"].ToString() != "")
                {
                    model.year = int.Parse(row["year"].ToString());
                }
                if (row["month"] != null && row["month"].ToString() != "")
                {
                    model.month = int.Parse(row["month"].ToString());
                }
                if (row["rule_id"] != null && row["rule_id"].ToString() != "")
                {
                    model.rule_id = int.Parse(row["rule_id"].ToString());
                }
                if (row["emp_id"] != null && row["emp_id"].ToString() != "")
                {
                    model.emp_id = int.Parse(row["emp_id"].ToString());
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["d_id"] != null && row["d_id"].ToString() != "")
                {
                    model.d_id = int.Parse(row["d_id"].ToString());
                }
                if (row["d_name"] != null)
                {
                    model.d_name = row["d_name"].ToString();
                }
                if (row["d_emp_total"] != null && row["d_emp_total"].ToString() != "")
                {
                    model.d_emp_total = int.Parse(row["d_emp_total"].ToString());
                }
                if (row["real_check_num"] != null && row["real_check_num"].ToString() != "")
                {
                    model.real_check_num = int.Parse(row["real_check_num"].ToString());
                }
                if (row["score_total"] != null && row["score_total"].ToString() != "")
                {
                    model.score_total = decimal.Parse(row["score_total"].ToString());
                }
                if (row["score_average"] != null && row["score_average"].ToString() != "")
                {
                    model.score_average = decimal.Parse(row["score_average"].ToString());
                }
                if (row["check_date"] != null)
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
            strSql.Append("select id,Factory_Id,year,month,rule_id,emp_id,emp_name,d_id,d_name,d_emp_total,real_check_num,score_total,score_average,check_date ");
            strSql.Append(" FROM ims_lead_score_average ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

