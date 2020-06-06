using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:sys_manage
    /// </summary>
    public partial class sys_manage
    {
        public sys_manage()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from sys_manage");
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
        public bool Add(XHD.Model.sys_manage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into sys_manage(");
            strSql.Append("sys_name,sys_shorthand,sys_sdesc,sys_order,sys_url,sys_handler,sys_type,sys_icon)");
            strSql.Append(" values (");
            strSql.Append("@sys_name,@sys_shorthand,@sys_sdesc,@sys_order,@sys_url,@sys_handler,@sys_type,@sys_icon)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sys_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@sys_shorthand", MySqlDbType.VarChar,50),
					new MySqlParameter("@sys_sdesc", MySqlDbType.VarChar,100),
					new MySqlParameter("@sys_order", MySqlDbType.Int32,11),
					new MySqlParameter("@sys_url", MySqlDbType.VarChar,100),
					new MySqlParameter("@sys_handler", MySqlDbType.VarChar,250),
					new MySqlParameter("@sys_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@sys_icon", MySqlDbType.VarChar,250)};
            parameters[0].Value = model.sys_name;
            parameters[1].Value = model.sys_shorthand;
            parameters[2].Value = model.sys_sdesc;
            parameters[3].Value = model.sys_order;
            parameters[4].Value = model.sys_url;
            parameters[5].Value = model.sys_handler;
            parameters[6].Value = model.sys_type;
            parameters[7].Value = model.sys_icon;

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
        public bool Update(XHD.Model.sys_manage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update sys_manage set ");
            strSql.Append("sys_name=@sys_name,");
            strSql.Append("sys_shorthand=@sys_shorthand,");
            strSql.Append("sys_sdesc=@sys_sdesc,");
            strSql.Append("sys_order=@sys_order,");
            strSql.Append("sys_url=@sys_url,");
            strSql.Append("sys_handler=@sys_handler,");
            strSql.Append("sys_type=@sys_type,");
            strSql.Append("sys_icon=@sys_icon");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@sys_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@sys_shorthand", MySqlDbType.VarChar,50),
					new MySqlParameter("@sys_sdesc", MySqlDbType.VarChar,100),
					new MySqlParameter("@sys_order", MySqlDbType.Int32,11),
					new MySqlParameter("@sys_url", MySqlDbType.VarChar,100),
					new MySqlParameter("@sys_handler", MySqlDbType.VarChar,250),
					new MySqlParameter("@sys_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@sys_icon", MySqlDbType.VarChar,250),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.sys_name;
            parameters[1].Value = model.sys_shorthand;
            parameters[2].Value = model.sys_sdesc;
            parameters[3].Value = model.sys_order;
            parameters[4].Value = model.sys_url;
            parameters[5].Value = model.sys_handler;
            parameters[6].Value = model.sys_type;
            parameters[7].Value = model.sys_icon;
            parameters[8].Value = model.id;

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
            strSql.Append("delete from sys_manage ");
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
            strSql.Append("delete from sys_manage ");
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
        public XHD.Model.sys_manage GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,sys_name,sys_shorthand,sys_sdesc,sys_order,sys_url,sys_handler,sys_type,sys_icon from sys_manage ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.sys_manage model = new XHD.Model.sys_manage();
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
        public XHD.Model.sys_manage DataRowToModel(DataRow row)
        {
            XHD.Model.sys_manage model = new XHD.Model.sys_manage();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["sys_name"] != null)
                {
                    model.sys_name = row["sys_name"].ToString();
                }
                if (row["sys_shorthand"] != null)
                {
                    model.sys_shorthand = row["sys_shorthand"].ToString();
                }
                if (row["sys_sdesc"] != null)
                {
                    model.sys_sdesc = row["sys_sdesc"].ToString();
                }
                if (row["sys_order"] != null && row["sys_order"].ToString() != "")
                {
                    model.sys_order = int.Parse(row["sys_order"].ToString());
                }
                if (row["sys_url"] != null)
                {
                    model.sys_url = row["sys_url"].ToString();
                }
                if (row["sys_handler"] != null)
                {
                    model.sys_handler = row["sys_handler"].ToString();
                }
                if (row["sys_type"] != null)
                {
                    model.sys_type = row["sys_type"].ToString();
                }
                if (row["sys_icon"] != null)
                {
                    model.sys_icon = row["sys_icon"].ToString();
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
            strSql.Append("select id,sys_name,sys_shorthand,sys_sdesc,sys_order,sys_url,sys_handler,sys_type,sys_icon ");
            strSql.Append(" FROM sys_manage ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获得数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  id,sys_name,sys_shorthand,sys_sdesc,sys_order,sys_url,sys_handler,sys_type,sys_icon FROM sys_manage ");
            strSql1.Append(" select count(id) FROM sys_manage ");
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM sys_manage ");
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
            strSql.Append(")AS Row, T.*  from sys_manage T ");
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
            parameters[0].Value = "sys_manage";
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

