using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:dms_set_excludeDAO
    /// </summary>
    public partial class dms_set_excludeDAO
    {
        public dms_set_excludeDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dms_set_exclude");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.dms_set_exclude model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dms_set_exclude(");
            strSql.Append("exclude_did,exclude_dname,exclude_emp_code,exclude_emp_name,create_time,create_name,factory_id)");
            strSql.Append(" values (");
            strSql.Append("@exclude_did,@exclude_dname,@exclude_emp_code,@exclude_emp_name,@create_time,@create_name,@factory_id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@exclude_did", MySqlDbType.VarChar,50),
					new MySqlParameter("@exclude_dname", MySqlDbType.VarChar,50),
					new MySqlParameter("@exclude_emp_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@exclude_emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,20)};
            parameters[0].Value = model.exclude_did;
            parameters[1].Value = model.exclude_dname;
            parameters[2].Value = model.exclude_emp_code;
            parameters[3].Value = model.exclude_emp_name;
            parameters[4].Value = model.create_time;
            parameters[5].Value = model.create_name;
            parameters[6].Value = model.factory_id;

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
        public bool Update(XHD.Model.dms_set_exclude model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_set_exclude set ");
            strSql.Append("exclude_did=@exclude_did,");
            strSql.Append("exclude_dname=@exclude_dname,");
            strSql.Append("exclude_emp_code=@exclude_emp_code,");
            strSql.Append("exclude_emp_name=@exclude_emp_name,");
            strSql.Append("create_time=@create_time,");
            strSql.Append("create_name=@create_name,");
            strSql.Append("factory_id=@factory_id");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@exclude_did", MySqlDbType.VarChar,50),
					new MySqlParameter("@exclude_dname", MySqlDbType.VarChar,50),
					new MySqlParameter("@exclude_emp_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@exclude_emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.exclude_did;
            parameters[1].Value = model.exclude_dname;
            parameters[2].Value = model.exclude_emp_code;
            parameters[3].Value = model.exclude_emp_name;
            parameters[4].Value = model.create_time;
            parameters[5].Value = model.create_name;
            parameters[6].Value = model.factory_id;
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dms_set_exclude ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
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
            strSql.Append("delete from dms_set_exclude ");
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
        public XHD.Model.dms_set_exclude GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,exclude_did,exclude_dname,exclude_emp_code,exclude_emp_name,create_time,create_name,factory_id from dms_set_exclude ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.dms_set_exclude model = new XHD.Model.dms_set_exclude();
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
        public XHD.Model.dms_set_exclude DataRowToModel(DataRow row)
        {
            XHD.Model.dms_set_exclude model = new XHD.Model.dms_set_exclude();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["exclude_did"] != null)
                {
                    model.exclude_did = row["exclude_did"].ToString();
                }
                if (row["exclude_dname"] != null)
                {
                    model.exclude_dname = row["exclude_dname"].ToString();
                }
                if (row["exclude_emp_code"] != null)
                {
                    model.exclude_emp_code = row["exclude_emp_code"].ToString();
                }
                if (row["exclude_emp_name"] != null)
                {
                    model.exclude_emp_name = row["exclude_emp_name"].ToString();
                }
                if (row["create_time"] != null && row["create_time"].ToString() != "")
                {
                    model.create_time = DateTime.Parse(row["create_time"].ToString());
                }
                if (row["create_name"] != null)
                {
                    model.create_name = row["create_name"].ToString();
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
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
            strSql.Append("select id,exclude_did,exclude_dname,exclude_emp_code,exclude_emp_name,create_time,create_name,factory_id ");
            strSql.Append(" FROM dms_set_exclude ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM dms_set_exclude ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from dms_set_exclude T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            MySqlParameter[] parameters = {
                    new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@PageSize", MySqlDbType.Int32),
                    new MySqlParameter("@PageIndex", MySqlDbType.Int32),
                    new MySqlParameter("@IsReCount", MySqlDbType.Bit),
                    new MySqlParameter("@OrderType", MySqlDbType.Bit),
                    new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "dms_set_exclude";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select * FROM dms_set_exclude ");
            strSql1.Append(" select count(*) FROM dms_set_exclude ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  ExtensionMethod
    }
}

