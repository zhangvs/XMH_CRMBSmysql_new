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
    /// 数据访问类:fms_costitem_dep
    /// </summary>
    public partial class fms_costitem_dep
    {
        public fms_costitem_dep()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return FMS_DbHelperMySQL.GetMaxID("id", "fms_costitem_dep");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from fms_costitem_dep");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return FMS_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.fms_costitem_dep model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fms_costitem_dep(");
            strSql.Append("id,dep_id,code_str,creater,create_time)");
            strSql.Append(" values (");
            strSql.Append("@id,@dep_id,@code_str,@creater,@create_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@dep_id", MySqlDbType.Int32,11),
					new MySqlParameter("@code_str", MySqlDbType.VarChar,2000),
					new MySqlParameter("@creater", MySqlDbType.VarChar,255),
					new MySqlParameter("@create_time", MySqlDbType.DateTime)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.dep_id;
            parameters[2].Value = model.code_str;
            parameters[3].Value = model.creater;
            parameters[4].Value = model.create_time;

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
        public bool Update(FMS_Model.fms_costitem_dep model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_costitem_dep set ");
            strSql.Append("dep_id=@dep_id,");
            strSql.Append("code_str=@code_str,");
            strSql.Append("creater=@creater,");
            strSql.Append("create_time=@create_time");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@dep_id", MySqlDbType.Int32,11),
					new MySqlParameter("@code_str", MySqlDbType.VarChar,2000),
					new MySqlParameter("@creater", MySqlDbType.VarChar,255),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.dep_id;
            parameters[1].Value = model.code_str;
            parameters[2].Value = model.creater;
            parameters[3].Value = model.create_time;
            parameters[4].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from fms_costitem_dep ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
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
            strSql.Append("delete from fms_costitem_dep ");
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
        public FMS_Model.fms_costitem_dep GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,dep_id,code_str,creater,create_time from fms_costitem_dep ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            FMS_Model.fms_costitem_dep model = new FMS_Model.fms_costitem_dep();
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
        public FMS_Model.fms_costitem_dep DataRowToModel(DataRow row)
        {
            FMS_Model.fms_costitem_dep model = new FMS_Model.fms_costitem_dep();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["dep_id"] != null && row["dep_id"].ToString() != "")
                {
                    model.dep_id = int.Parse(row["dep_id"].ToString());
                }
                if (row["code_str"] != null)
                {
                    model.code_str = row["code_str"].ToString();
                }
                if (row["creater"] != null)
                {
                    model.creater = row["creater"].ToString();
                }
                if (row["create_time"] != null && row["create_time"].ToString() != "")
                {
                    model.create_time = DateTime.Parse(row["create_time"].ToString());
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
            strSql.Append("select id,dep_id,code_str,creater,create_time ");
            strSql.Append(" FROM fms_costitem_dep ");
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

