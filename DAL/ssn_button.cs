using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ssn_button
    /// </summary>
    public partial class ssn_button
    {
        public ssn_button()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Btn_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ssn_button");
            strSql.Append(" where Btn_id=@Btn_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Btn_id", MySqlDbType.Int32)
			};
            parameters[0].Value = Btn_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ssn_button model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ssn_button(");
            strSql.Append("Btn_name,Btn_icon,Btn_handler,Menu_id,Menu_name,Btn_order,Btn_type)");
            strSql.Append(" values (");
            strSql.Append("@Btn_name,@Btn_icon,@Btn_handler,@Menu_id,@Menu_name,@Btn_order,@Btn_type)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Btn_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@Btn_icon", MySqlDbType.VarChar,100),
					new MySqlParameter("@Btn_handler", MySqlDbType.VarChar,255),
					new MySqlParameter("@Menu_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Menu_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@Btn_order", MySqlDbType.Int32,11),
					new MySqlParameter("@Btn_type", MySqlDbType.VarChar,1)};
            parameters[0].Value = model.Btn_name;
            parameters[1].Value = model.Btn_icon;
            parameters[2].Value = model.Btn_handler;
            parameters[3].Value = model.Menu_id;
            parameters[4].Value = model.Menu_name;
            parameters[5].Value = model.Btn_order;
            parameters[6].Value = model.Btn_type;

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
        public bool Update(XHD.Model.ssn_button model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_button set ");
            strSql.Append("Btn_name=@Btn_name,");
            strSql.Append("Btn_icon=@Btn_icon,");
            strSql.Append("Btn_handler=@Btn_handler,");
            strSql.Append("Menu_id=@Menu_id,");
            strSql.Append("Menu_name=@Menu_name,");
            strSql.Append("Btn_order=@Btn_order,");
            strSql.Append("Btn_type=@Btn_type");
            strSql.Append(" where Btn_id=@Btn_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Btn_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@Btn_icon", MySqlDbType.VarChar,100),
					new MySqlParameter("@Btn_handler", MySqlDbType.VarChar,255),
					new MySqlParameter("@Menu_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Menu_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@Btn_order", MySqlDbType.Int32,11),
					new MySqlParameter("@Btn_type", MySqlDbType.VarChar,1),
					new MySqlParameter("@Btn_id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Btn_name;
            parameters[1].Value = model.Btn_icon;
            parameters[2].Value = model.Btn_handler;
            parameters[3].Value = model.Menu_id;
            parameters[4].Value = model.Menu_name;
            parameters[5].Value = model.Btn_order;
            parameters[6].Value = model.Btn_type;
            parameters[7].Value = model.Btn_id;

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
        public bool Delete(int Btn_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_button ");
            strSql.Append(" where Btn_id=@Btn_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Btn_id", MySqlDbType.Int32)
			};
            parameters[0].Value = Btn_id;

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
        public bool DeleteList(string Btn_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_button ");
            strSql.Append(" where Btn_id in (" + Btn_idlist + ")  ");
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
        public XHD.Model.ssn_button GetModel(int Btn_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Btn_id,Btn_name,Btn_icon,Btn_handler,Menu_id,Menu_name,Btn_order,Btn_type from ssn_button ");
            strSql.Append(" where Btn_id=@Btn_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Btn_id", MySqlDbType.Int32)
			};
            parameters[0].Value = Btn_id;

            XHD.Model.ssn_button model = new XHD.Model.ssn_button();
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
        public XHD.Model.ssn_button DataRowToModel(DataRow row)
        {
            XHD.Model.ssn_button model = new XHD.Model.ssn_button();
            if (row != null)
            {
                if (row["Btn_id"] != null && row["Btn_id"].ToString() != "")
                {
                    model.Btn_id = int.Parse(row["Btn_id"].ToString());
                }
                if (row["Btn_name"] != null)
                {
                    model.Btn_name = row["Btn_name"].ToString();
                }
                if (row["Btn_icon"] != null)
                {
                    model.Btn_icon = row["Btn_icon"].ToString();
                }
                if (row["Btn_handler"] != null)
                {
                    model.Btn_handler = row["Btn_handler"].ToString();
                }
                if (row["Menu_id"] != null && row["Menu_id"].ToString() != "")
                {
                    model.Menu_id = int.Parse(row["Menu_id"].ToString());
                }
                if (row["Menu_name"] != null)
                {
                    model.Menu_name = row["Menu_name"].ToString();
                }
                if (row["Btn_order"] != null && row["Btn_order"].ToString() != "")
                {
                    model.Btn_order = int.Parse(row["Btn_order"].ToString());
                }
                if (row["Btn_type"] != null)
                {
                    model.Btn_type = row["Btn_type"].ToString();
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
            strSql.Append("select Btn_id,Btn_name,Btn_icon,Btn_handler,Menu_id,Menu_name,Btn_order,Btn_type ");
            strSql.Append(" FROM ssn_button ");
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
            strSql.Append("select count(1) FROM ssn_button ");
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
                strSql.Append("order by T.Btn_id desc");
            }
            strSql.Append(")AS Row, T.*  from ssn_button T ");
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

            strSql.Append(" Btn_id,Btn_name,Btn_icon,Btn_handler,Menu_id,Menu_name,Btn_order ");
            strSql.Append(" FROM ssn_button ");
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
            parameters[0].Value = "ssn_button";
            parameters[1].Value = "Btn_id";
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

