using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ssn_art_menu
    /// </summary>
    public partial class ssn_art_menu
    {
        public ssn_art_menu()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ssn_art_menu");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        //校验此菜单id下以及子菜单id下是否存在文章、
        public bool ExistsArt(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ssn_art");
            strSql.Append(" where Art_Menu_Id in (select id from ssn_art_menu where id =" + Id + " or parentid=" + Id + ")");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ssn_art_menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ssn_art_menu(");
            strSql.Append("factory_Id,Art_Menu,Art_Menu_en,parentid,parentname,level,App_id,Menu_url,Menu_icon,Menu_handler,Menu_order,Menu_type)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@Art_Menu,@Art_Menu_en,@parentid,@parentname,@level,@App_id,@Menu_url,@Menu_icon,@Menu_handler,@Menu_order,@Menu_type)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Art_Menu", MySqlDbType.VarChar,60),
					new MySqlParameter("@Art_Menu_en", MySqlDbType.VarChar,60),
					new MySqlParameter("@parentid", MySqlDbType.Int32,11),
					new MySqlParameter("@parentname", MySqlDbType.VarChar,200),
					new MySqlParameter("@level", MySqlDbType.Int32,4),
					new MySqlParameter("@App_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Menu_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@Menu_icon", MySqlDbType.VarChar,50),
					new MySqlParameter("@Menu_handler", MySqlDbType.VarChar,50),
					new MySqlParameter("@Menu_order", MySqlDbType.Int32,11),
					new MySqlParameter("@Menu_type", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.Art_Menu;
            parameters[2].Value = model.Art_Menu_en;
            parameters[3].Value = model.parentid;
            parameters[4].Value = model.parentname;
            parameters[5].Value = model.level;
            parameters[6].Value = model.App_id;
            parameters[7].Value = model.Menu_url;
            parameters[8].Value = model.Menu_icon;
            parameters[9].Value = model.Menu_handler;
            parameters[10].Value = model.Menu_order;
            parameters[11].Value = model.Menu_type;

            object obj = DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return false;
            }
            else
            {
                int rows = DbHelperMySQL.ExecuteSql("update ssn_art_menu set Menu_url='SSN/article/ssn_article.aspx?Id=" + Convert.ToInt32(obj) + "' where id=" + Convert.ToInt32(obj));
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ssn_art_menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_art_menu set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("Art_Menu=@Art_Menu,");
            strSql.Append("Art_Menu_en=@Art_Menu_en,");
            strSql.Append("parentid=@parentid,");
            strSql.Append("parentname=@parentname,");
            strSql.Append("level=@level,");
            strSql.Append("App_id=@App_id,");
            //strSql.Append("Menu_url=@Menu_url,");
            strSql.Append("Menu_icon=@Menu_icon,");
            strSql.Append("Menu_handler=@Menu_handler,");
            strSql.Append("Menu_order=@Menu_order,");
            strSql.Append("Menu_type=@Menu_type");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Art_Menu", MySqlDbType.VarChar,60),
					new MySqlParameter("@Art_Menu_en", MySqlDbType.VarChar,60),
					new MySqlParameter("@parentid", MySqlDbType.Int32,11),
					new MySqlParameter("@parentname", MySqlDbType.VarChar,200),
					new MySqlParameter("@level", MySqlDbType.Int32,4),
					new MySqlParameter("@App_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Menu_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@Menu_icon", MySqlDbType.VarChar,50),
					new MySqlParameter("@Menu_handler", MySqlDbType.VarChar,50),
					new MySqlParameter("@Menu_order", MySqlDbType.Int32,11),
					new MySqlParameter("@Menu_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.Art_Menu;
            parameters[2].Value = model.Art_Menu_en;
            parameters[3].Value = model.parentid;
            parameters[4].Value = model.parentname;
            parameters[5].Value = model.level;
            parameters[6].Value = model.App_id;
            parameters[7].Value = model.Menu_url;
            parameters[8].Value = model.Menu_icon;
            parameters[9].Value = model.Menu_handler;
            parameters[10].Value = model.Menu_order;
            parameters[11].Value = model.Menu_type;
            parameters[12].Value = model.Id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_art_menu ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

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
        /// 删除其和其子
        /// </summary>
        public bool DeleteAndChildren(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_art_menu ");
            strSql.Append(" where Id=" + Id + " or parentid=" + Id);

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_art_menu ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        public XHD.Model.ssn_art_menu GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,Art_Menu,Art_Menu_en,parentid,parentname,level,App_id,Menu_url,Menu_icon,Menu_handler,Menu_order,Menu_type from ssn_art_menu ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.ssn_art_menu model = new XHD.Model.ssn_art_menu();
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
        public XHD.Model.ssn_art_menu DataRowToModel(DataRow row)
        {
            XHD.Model.ssn_art_menu model = new XHD.Model.ssn_art_menu();
            if (row != null)
            {
                if (row["Menu_id"] != null && row["Menu_id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Menu_id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["Menu_name"] != null)
                {
                    model.Art_Menu = row["Menu_name"].ToString();
                }
                if (row["Art_Menu_en"] != null)
                {
                    model.Art_Menu_en = row["Art_Menu_en"].ToString();
                }
                if (row["parentid"] != null && row["parentid"].ToString() != "")
                {
                    model.parentid = int.Parse(row["parentid"].ToString());
                }
                if (row["parentname"] != null)
                {
                    model.parentname = row["parentname"].ToString();
                }
                if (row["level"] != null && row["level"].ToString() != "")
                {
                    model.level = int.Parse(row["level"].ToString());
                }
                if (row["App_id"] != null && row["App_id"].ToString() != "")
                {
                    model.App_id = int.Parse(row["App_id"].ToString());
                }
                if (row["Menu_url"] != null)
                {
                    model.Menu_url = row["Menu_url"].ToString();
                }
                if (row["Menu_icon"] != null)
                {
                    model.Menu_icon = row["Menu_icon"].ToString();
                }
                if (row["Menu_handler"] != null)
                {
                    model.Menu_handler = row["Menu_handler"].ToString();
                }
                if (row["Menu_order"] != null && row["Menu_order"].ToString() != "")
                {
                    model.Menu_order = int.Parse(row["Menu_order"].ToString());
                }
                if (row["Menu_type"] != null)
                {
                    model.Menu_type = row["Menu_type"].ToString();
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
            strSql.Append("select Id as Menu_id,factory_Id,Art_Menu as Menu_name,Art_Menu_en,parentid,parentname,level,App_id,Menu_url,Menu_icon,Menu_handler,Menu_order,Menu_type ");
            strSql.Append(" FROM ssn_art_menu ");
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
            strSql.Append("select count(1) FROM ssn_art_menu ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from ssn_art_menu T ");
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

            strSql.Append("Id as Menu_id,Art_Menu as Menu_name,parentid,parentname,App_id,Menu_url,Menu_icon,Menu_handler,Menu_order,Menu_type ");
            strSql.Append(" FROM ssn_art_menu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
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
            parameters[0].Value = "ssn_art_menu";
            parameters[1].Value = "Id";
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

