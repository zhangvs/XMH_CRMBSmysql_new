using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ssn_art_app
    /// </summary>
    public partial class ssn_art_app
    {
        public ssn_art_app()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ssn_art_app");
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
        public bool Add(XHD.Model.ssn_art_app model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ssn_art_app(");
            strSql.Append("App_name,App_order,App_url,App_handler,App_type,App_icon)");
            strSql.Append(" values (");
            strSql.Append("@App_name,@App_order,@App_url,@App_handler,@App_type,@App_icon)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@App_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@App_order", MySqlDbType.Int32,11),
					new MySqlParameter("@App_url", MySqlDbType.VarChar,250),
					new MySqlParameter("@App_handler", MySqlDbType.VarChar,250),
					new MySqlParameter("@App_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@App_icon", MySqlDbType.VarChar,250)};
            parameters[0].Value = model.App_name;
            parameters[1].Value = model.App_order;
            parameters[2].Value = model.App_url;
            parameters[3].Value = model.App_handler;
            parameters[4].Value = model.App_type;
            parameters[5].Value = model.App_icon;

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
        public bool Update(XHD.Model.ssn_art_app model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_art_app set ");
            strSql.Append("App_name=@App_name,");
            strSql.Append("App_order=@App_order,");
            strSql.Append("App_url=@App_url,");
            strSql.Append("App_handler=@App_handler,");
            strSql.Append("App_type=@App_type,");
            strSql.Append("App_icon=@App_icon");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@App_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@App_order", MySqlDbType.Int32,11),
					new MySqlParameter("@App_url", MySqlDbType.VarChar,250),
					new MySqlParameter("@App_handler", MySqlDbType.VarChar,250),
					new MySqlParameter("@App_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@App_icon", MySqlDbType.VarChar,250),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.App_name;
            parameters[1].Value = model.App_order;
            parameters[2].Value = model.App_url;
            parameters[3].Value = model.App_handler;
            parameters[4].Value = model.App_type;
            parameters[5].Value = model.App_icon;
            parameters[6].Value = model.id;

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
            strSql.Append("delete from ssn_art_app ");
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
            strSql.Append("delete from ssn_art_app ");
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
        public XHD.Model.ssn_art_app GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,App_name,App_order,App_url,App_handler,App_type,App_icon from ssn_art_app ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.ssn_art_app model = new XHD.Model.ssn_art_app();
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
        public XHD.Model.ssn_art_app DataRowToModel(DataRow row)
        {
            XHD.Model.ssn_art_app model = new XHD.Model.ssn_art_app();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["App_name"] != null)
                {
                    model.App_name = row["App_name"].ToString();
                }
                if (row["App_order"] != null && row["App_order"].ToString() != "")
                {
                    model.App_order = int.Parse(row["App_order"].ToString());
                }
                if (row["App_url"] != null)
                {
                    model.App_url = row["App_url"].ToString();
                }
                if (row["App_handler"] != null)
                {
                    model.App_handler = row["App_handler"].ToString();
                }
                if (row["App_type"] != null)
                {
                    model.App_type = row["App_type"].ToString();
                }
                if (row["App_icon"] != null)
                {
                    model.App_icon = row["App_icon"].ToString();
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
            strSql.Append("select id,App_name,App_order,App_url,App_handler,App_type,App_icon ");
            strSql.Append(" FROM ssn_art_app ");
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
            strSql.Append("select count(1) FROM ssn_art_app ");
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
            strSql.Append(")AS Row, T.*  from ssn_art_app T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");

            strSql.Append(" id,App_name,App_order,App_url,App_handler,App_type,App_icon ");
            strSql.Append(" FROM ssn_art_app ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
            }
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
            parameters[0].Value = "ssn_art_app";
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

        #endregion  ExtensionMethod
    }
}

