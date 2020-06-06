using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:fms_ac_period
    /// </summary>
    public partial class fms_ac_period
    {
        public fms_ac_period()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return FMS_DbHelperMySQL.GetMaxID("Id", "fms_ac_period");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from fms_ac_period");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            return FMS_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.fms_ac_period model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fms_ac_period(");
            strSql.Append("Id,Factory_Id,C_customerid,C_customer_code,C_customername,C_userid,C_username,period_year,period_start,period_end,period_start_date,period_end_date,Is_stop,C_type)");
            strSql.Append(" values (");
            strSql.Append("@Id,@Factory_Id,@C_customerid,@C_customer_code,@C_customername,@C_userid,@C_username,@period_year,@period_start,@period_end,@period_start_date,@period_end_date,@Is_stop,@C_type)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_customerid", MySqlDbType.Int32,11),
					new MySqlParameter("@C_customer_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_customername", MySqlDbType.VarChar,200),
					new MySqlParameter("@C_userid", MySqlDbType.Int32,11),
					new MySqlParameter("@C_username", MySqlDbType.VarChar,60),
					new MySqlParameter("@period_year", MySqlDbType.VarChar,4),
					new MySqlParameter("@period_start", MySqlDbType.Decimal,18),
					new MySqlParameter("@period_end", MySqlDbType.Decimal,18),
					new MySqlParameter("@period_start_date", MySqlDbType.DateTime),
					new MySqlParameter("@period_end_date", MySqlDbType.DateTime),
					new MySqlParameter("@Is_stop", MySqlDbType.Int16,1),
					new MySqlParameter("@C_type", MySqlDbType.Int16,1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.Factory_Id;
            parameters[2].Value = model.C_customerid;
            parameters[3].Value = model.C_customer_code;
            parameters[4].Value = model.C_customername;
            parameters[5].Value = model.C_userid;
            parameters[6].Value = model.C_username;
            parameters[7].Value = model.period_year;
            parameters[8].Value = model.period_start;
            parameters[9].Value = model.period_end;
            parameters[10].Value = model.period_start_date;
            parameters[11].Value = model.period_end_date;
            parameters[12].Value = model.Is_stop;
            parameters[13].Value = model.C_type;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(XHD.Model.fms_ac_period model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_ac_period set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("C_customerid=@C_customerid,");
            strSql.Append("C_customer_code=@C_customer_code,");
            strSql.Append("C_customername=@C_customername,");
            strSql.Append("C_userid=@C_userid,");
            strSql.Append("C_username=@C_username,");
            strSql.Append("period_year=@period_year,");
            strSql.Append("period_start=@period_start,");
            strSql.Append("period_end=@period_end,");
            strSql.Append("period_start_date=@period_start_date,");
            strSql.Append("period_end_date=@period_end_date,");
            strSql.Append("Is_stop=@Is_stop,");
            strSql.Append("C_type=@C_type");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_customerid", MySqlDbType.Int32,11),
					new MySqlParameter("@C_customer_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_customername", MySqlDbType.VarChar,200),
					new MySqlParameter("@C_userid", MySqlDbType.Int32,11),
					new MySqlParameter("@C_username", MySqlDbType.VarChar,60),
					new MySqlParameter("@period_year", MySqlDbType.VarChar,4),
					new MySqlParameter("@period_start", MySqlDbType.Decimal,18),
					new MySqlParameter("@period_end", MySqlDbType.Decimal,18),
					new MySqlParameter("@period_start_date", MySqlDbType.DateTime),
					new MySqlParameter("@period_end_date", MySqlDbType.DateTime),
					new MySqlParameter("@Is_stop", MySqlDbType.Int16,1),
					new MySqlParameter("@C_type", MySqlDbType.Int16,1),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.C_customerid;
            parameters[2].Value = model.C_customer_code;
            parameters[3].Value = model.C_customername;
            parameters[4].Value = model.C_userid;
            parameters[5].Value = model.C_username;
            parameters[6].Value = model.period_year;
            parameters[7].Value = model.period_start;
            parameters[8].Value = model.period_end;
            parameters[9].Value = model.period_start_date;
            parameters[10].Value = model.period_end_date;
            parameters[11].Value = model.Is_stop;
            parameters[12].Value = model.C_type;
            parameters[13].Value = model.Id;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from fms_ac_period ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from fms_ac_period ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public XHD.Model.fms_ac_period GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Factory_Id,C_customerid,C_customer_code,C_customername,C_userid,C_username,period_year,period_start,period_end,period_start_date,period_end_date,Is_stop,C_type from fms_ac_period ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            XHD.Model.fms_ac_period model = new XHD.Model.fms_ac_period();
            DataSet ds = FMS_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public XHD.Model.fms_ac_period DataRowToModel(DataRow row)
        {
            XHD.Model.fms_ac_period model = new XHD.Model.fms_ac_period();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["C_customerid"] != null && row["C_customerid"].ToString() != "")
                {
                    model.C_customerid = int.Parse(row["C_customerid"].ToString());
                }
                if (row["C_customer_code"] != null)
                {
                    model.C_customer_code = row["C_customer_code"].ToString();
                }
                if (row["C_customername"] != null)
                {
                    model.C_customername = row["C_customername"].ToString();
                }
                if (row["C_userid"] != null && row["C_userid"].ToString() != "")
                {
                    model.C_userid = int.Parse(row["C_userid"].ToString());
                }
                if (row["C_username"] != null)
                {
                    model.C_username = row["C_username"].ToString();
                }
                if (row["period_year"] != null)
                {
                    model.period_year = row["period_year"].ToString();
                }
                if (row["period_start"] != null && row["period_start"].ToString() != "")
                {
                    model.period_start = decimal.Parse(row["period_start"].ToString());
                }
                if (row["period_end"] != null && row["period_end"].ToString() != "")
                {
                    model.period_end = decimal.Parse(row["period_end"].ToString());
                }
                if (row["period_start_date"] != null && row["period_start_date"].ToString() != "")
                {
                    model.period_start_date = DateTime.Parse(row["period_start_date"].ToString());
                }
                if (row["period_end_date"] != null && row["period_end_date"].ToString() != "")
                {
                    model.period_end_date = DateTime.Parse(row["period_end_date"].ToString());
                }
                //if (row["Is_stop"] != null && row["Is_stop"].ToString() != "")
                //{
                //    model.Is_stop = int.Parse(row["Is_stop"].ToString());
                //}
                //if(row["C_type"]!=null && row["C_type"].ToString()!="")
                //{
                //    model.C_type=int.Parse(row["C_type"].ToString());
                //}
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Factory_Id,C_customerid,C_customer_code,C_customername,C_userid,C_username,period_year,period_start,period_end,period_start_date,period_end_date,Is_stop,C_type ");
            strSql.Append(" FROM fms_ac_period ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }


        //获得客户的某一年的起初应收
        public string GetFirstReceivable(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select   sum(period_start)   as period_startSum  FROM fms_ac_period ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            object obj = FMS_DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


