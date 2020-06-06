using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_sys_dtcolumn
    /// </summary>
    public partial class scm_sys_dtcolumn
    {
        public scm_sys_dtcolumn()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int column_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_sys_dtcolumn");
            strSql.Append(" where column_id=@column_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@column_id", MySqlDbType.Int32)
			};
            parameters[0].Value = column_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_sys_dtcolumn model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_sys_dtcolumn(");
            strSql.Append("Menu_id,column_name)");
            strSql.Append(" values (");
            strSql.Append("@Menu_id,@column_name)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Menu_id", MySqlDbType.Int32,11),
					new MySqlParameter("@column_name", MySqlDbType.VarChar,200)};
            parameters[0].Value = model.Menu_id;
            parameters[1].Value = model.column_name;

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
        public bool Update(XHD.Model.scm_sys_dtcolumn model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_sys_dtcolumn set ");
            strSql.Append("Menu_id=@Menu_id,");
            strSql.Append("column_name=@column_name");
            strSql.Append(" where column_id=@column_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Menu_id", MySqlDbType.Int32,11),
					new MySqlParameter("@column_name", MySqlDbType.VarChar,200),
					new MySqlParameter("@column_id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Menu_id;
            parameters[1].Value = model.column_name;
            parameters[2].Value = model.column_id;

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
        public bool Delete(int column_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_sys_dtcolumn ");
            strSql.Append(" where column_id=@column_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@column_id", MySqlDbType.Int32)
			};
            parameters[0].Value = column_id;

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
        public bool DeleteList(string column_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_sys_dtcolumn ");
            strSql.Append(" where column_id in (" + column_idlist + ")  ");
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
        public XHD.Model.scm_sys_dtcolumn GetModel(int column_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select column_id,Menu_id,column_name from scm_sys_dtcolumn ");
            strSql.Append(" where column_id=@column_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@column_id", MySqlDbType.Int32)
			};
            parameters[0].Value = column_id;

            XHD.Model.scm_sys_dtcolumn model = new XHD.Model.scm_sys_dtcolumn();
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
        public XHD.Model.scm_sys_dtcolumn DataRowToModel(DataRow row)
        {
            XHD.Model.scm_sys_dtcolumn model = new XHD.Model.scm_sys_dtcolumn();
            if (row != null)
            {
                if (row["column_id"] != null && row["column_id"].ToString() != "")
                {
                    model.column_id = int.Parse(row["column_id"].ToString());
                }
                if (row["Menu_id"] != null && row["Menu_id"].ToString() != "")
                {
                    model.Menu_id = int.Parse(row["Menu_id"].ToString());
                }
                if (row["column_name"] != null)
                {
                    model.column_name = row["column_name"].ToString();
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
            strSql.Append("select column_id,Menu_id,column_name ");
            strSql.Append(" FROM scm_sys_dtcolumn ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select column_id,Menu_id,column_name ");
            strSql.Append(" FROM scm_sys_dtcolumn ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM scm_sys_dtcolumn ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.column_id desc");
            }
            strSql.Append(")AS Row, T.*  from scm_sys_dtcolumn T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

