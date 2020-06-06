using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:dms_set_bonus_teamDAO
    /// </summary>
    public partial class dms_set_bonus_teamDAO
    {
        public dms_set_bonus_teamDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dms_set_bonus_team");
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
        public bool Add(XHD.Model.dms_set_bonus_team model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dms_set_bonus_team(");
            strSql.Append("d_id,d_name,db_100,db_90)");
            strSql.Append(" values (");
            strSql.Append("@d_id,@d_name,@db_100,@db_90)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@d_id", MySqlDbType.Int32,11),
					new MySqlParameter("@d_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@db_100", MySqlDbType.Int32,10),
					new MySqlParameter("@db_90", MySqlDbType.Int32,10)};
            parameters[0].Value = model.d_id;
            parameters[1].Value = model.d_name;
            parameters[2].Value = model.db_100;
            parameters[3].Value = model.db_90;

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
        public bool Update(XHD.Model.dms_set_bonus_team model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_set_bonus_team set ");
            strSql.Append("d_id=@d_id,");
            strSql.Append("d_name=@d_name,");
            strSql.Append("db_100=@db_100,");
            strSql.Append("db_90=@db_90");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@d_id", MySqlDbType.Int32,11),
					new MySqlParameter("@d_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@db_100", MySqlDbType.Int32,10),
					new MySqlParameter("@db_90", MySqlDbType.Int32,10),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.d_id;
            parameters[1].Value = model.d_name;
            parameters[2].Value = model.db_100;
            parameters[3].Value = model.db_90;
            parameters[4].Value = model.id;

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
            strSql.Append("delete from dms_set_bonus_team ");
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
            strSql.Append("delete from dms_set_bonus_team ");
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
        public XHD.Model.dms_set_bonus_team GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,d_id,d_name,db_100,db_90 from dms_set_bonus_team ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.dms_set_bonus_team model = new XHD.Model.dms_set_bonus_team();
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
        public XHD.Model.dms_set_bonus_team DataRowToModel(DataRow row)
        {
            XHD.Model.dms_set_bonus_team model = new XHD.Model.dms_set_bonus_team();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["d_id"] != null && row["d_id"].ToString() != "")
                {
                    model.d_id = int.Parse(row["d_id"].ToString());
                }
                if (row["d_name"] != null)
                {
                    model.d_name = row["d_name"].ToString();
                }
                if (row["db_100"] != null && row["db_100"].ToString() != "")
                {
                    model.db_100 = int.Parse(row["db_100"].ToString());
                }
                if (row["db_90"] != null && row["db_90"].ToString() != "")
                {
                    model.db_90 = int.Parse(row["db_90"].ToString());
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
            strSql.Append("select id,d_id,d_name,db_100,db_90 ");
            strSql.Append(" FROM dms_set_bonus_team ");
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
            strSql.Append("select count(1) FROM dms_set_bonus_team ");
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
            strSql.Append(")AS Row, T.*  from dms_set_bonus_team T ");
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
            parameters[0].Value = "dms_set_bonus_team";
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

