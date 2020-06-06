using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_goods_type
    /// </summary>
    public partial class ecs_goods_type
    {
        public ecs_goods_type()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int cat_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_goods_type");
            strSql.Append(" where cat_id=@cat_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cat_id", MySqlDbType.Int16)
			};
            parameters[0].Value = cat_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_goods_type model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_goods_type(");
            strSql.Append("cat_name,enabled,attr_group)");
            strSql.Append(" values (");
            strSql.Append("@cat_name,@enabled,@attr_group)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cat_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@enabled", MySqlDbType.Byte,1),
					new MySqlParameter("@attr_group", MySqlDbType.VarChar,255)};
            parameters[0].Value = model.cat_name;
            parameters[1].Value = model.enabled;
            parameters[2].Value = model.attr_group;

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
        public bool Update(XHD.Model.ecs_goods_type model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_goods_type set ");
            strSql.Append("cat_name=@cat_name,");
            strSql.Append("enabled=@enabled,");
            strSql.Append("attr_group=@attr_group");
            strSql.Append(" where cat_id=@cat_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cat_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@enabled", MySqlDbType.Byte,1),
					new MySqlParameter("@attr_group", MySqlDbType.VarChar,255),
					new MySqlParameter("@cat_id", MySqlDbType.Int16,5)};
            parameters[0].Value = model.cat_name;
            parameters[1].Value = model.enabled;
            parameters[2].Value = model.attr_group;
            parameters[3].Value = model.cat_id;

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
        public bool Delete(int cat_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_goods_type ");
            strSql.Append(" where cat_id=@cat_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cat_id", MySqlDbType.Int16)
			};
            parameters[0].Value = cat_id;

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
        public bool DeleteList(string cat_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_goods_type ");
            strSql.Append(" where cat_id in (" + cat_idlist + ")  ");
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
        public XHD.Model.ecs_goods_type GetModel(int cat_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select cat_id,cat_name,enabled,attr_group from ecs_goods_type ");
            strSql.Append(" where cat_id=@cat_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cat_id", MySqlDbType.Int16)
			};
            parameters[0].Value = cat_id;

            XHD.Model.ecs_goods_type model = new XHD.Model.ecs_goods_type();
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
        public XHD.Model.ecs_goods_type DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_goods_type model = new XHD.Model.ecs_goods_type();
            if (row != null)
            {
                if (row["cat_id"] != null && row["cat_id"].ToString() != "")
                {
                    model.cat_id = int.Parse(row["cat_id"].ToString());
                }
                if (row["cat_name"] != null)
                {
                    model.cat_name = row["cat_name"].ToString();
                }
                if (row["enabled"] != null && row["enabled"].ToString() != "")
                {
                    model.enabled = int.Parse(row["enabled"].ToString());
                }
                if (row["attr_group"] != null)
                {
                    model.attr_group = row["attr_group"].ToString();
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
            strSql.Append("select cat_id,cat_name,enabled,attr_group ");
            strSql.Append(" FROM ecs_goods_type ");
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
            strSql.Append("select count(1) FROM ecs_goods_type ");
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
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * FROM ecs_goods_type ");
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
                strSql.Append("order by T.cat_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_goods_type T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select * FROM ecs_goods_type");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_Contact ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(cat_id) FROM ecs_goods_type ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
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
            parameters[0].Value = "ecs_goods_type";
            parameters[1].Value = "cat_id";
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

