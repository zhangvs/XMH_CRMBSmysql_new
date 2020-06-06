using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XHD.DBUtility;

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:fms_refund_log
    /// </summary>
    public partial class fms_refund_log
    {
        public fms_refund_log()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from fms_refund_log");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,20)			};
            parameters[0].Value = id;

            return FMS_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.fms_refund_log model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fms_refund_log(");
            strSql.Append("id,refund_id,refund_sn,emp_id,emp_code,emp_name,log_info,log_time)");
            strSql.Append(" values (");
            strSql.Append("@id,@refund_id,@refund_sn,@emp_id,@emp_code,@emp_name,@log_info,@log_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,20),
					new MySqlParameter("@refund_id", MySqlDbType.Int32,11),
					new MySqlParameter("@refund_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@log_info", MySqlDbType.VarChar,500),
					new MySqlParameter("@log_time", MySqlDbType.DateTime)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.refund_id;
            parameters[2].Value = model.refund_sn;
            parameters[3].Value = model.emp_id;
            parameters[4].Value = model.emp_code;
            parameters[5].Value = model.emp_name;
            parameters[6].Value = model.log_info;
            parameters[7].Value = model.log_time;

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
        public bool Update(FMS_Model.fms_refund_log model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_refund_log set ");
            strSql.Append("refund_id=@refund_id,");
            strSql.Append("refund_sn=@refund_sn,");
            strSql.Append("emp_id=@emp_id,");
            strSql.Append("emp_code=@emp_code,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("log_info=@log_info,");
            strSql.Append("log_time=@log_time");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@refund_id", MySqlDbType.Int32,11),
					new MySqlParameter("@refund_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@log_info", MySqlDbType.VarChar,500),
					new MySqlParameter("@log_time", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,20)};
            parameters[0].Value = model.refund_id;
            parameters[1].Value = model.refund_sn;
            parameters[2].Value = model.emp_id;
            parameters[3].Value = model.emp_code;
            parameters[4].Value = model.emp_name;
            parameters[5].Value = model.log_info;
            parameters[6].Value = model.log_time;
            parameters[7].Value = model.id;

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
        public bool Delete(long id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from fms_refund_log ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,20)			};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from fms_refund_log ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public FMS_Model.fms_refund_log GetModel(long id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,refund_id,refund_sn,emp_id,emp_code,emp_name,log_info,log_time from fms_refund_log ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,20)			};
            parameters[0].Value = id;

            FMS_Model.fms_refund_log model = new FMS_Model.fms_refund_log();
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
        public FMS_Model.fms_refund_log DataRowToModel(DataRow row)
        {
            FMS_Model.fms_refund_log model = new FMS_Model.fms_refund_log();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = long.Parse(row["id"].ToString());
                }
                if (row["refund_id"] != null && row["refund_id"].ToString() != "")
                {
                    model.refund_id = int.Parse(row["refund_id"].ToString());
                }
                if (row["refund_sn"] != null)
                {
                    model.refund_sn = row["refund_sn"].ToString();
                }
                if (row["emp_id"] != null && row["emp_id"].ToString() != "")
                {
                    model.emp_id = int.Parse(row["emp_id"].ToString());
                }
                if (row["emp_code"] != null)
                {
                    model.emp_code = row["emp_code"].ToString();
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["log_info"] != null)
                {
                    model.log_info = row["log_info"].ToString();
                }
                if (row["log_time"] != null && row["log_time"].ToString() != "")
                {
                    model.log_time = DateTime.Parse(row["log_time"].ToString());
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
            strSql.Append("select id,refund_id,refund_sn,emp_id,emp_code,emp_name,log_info,log_time ");
            strSql.Append(" FROM fms_refund_log ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

