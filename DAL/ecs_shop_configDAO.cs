using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_shop_configDAO
    /// </summary>
    public partial class ecs_shop_configDAO
    {
        public ecs_shop_configDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_shop_config");
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
        public bool Add(XHD.Model.ecs_shop_config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_shop_config(");
            strSql.Append("parent_id,code,type,store_range,store_dir,value,sort_order)");
            strSql.Append(" values (");
            strSql.Append("@parent_id,@code,@type,@store_range,@store_dir,@value,@sort_order)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@parent_id", MySqlDbType.Int32),
					new MySqlParameter("@code", MySqlDbType.VarChar,30),
					new MySqlParameter("@type", MySqlDbType.VarChar,10),
					new MySqlParameter("@store_range", MySqlDbType.VarChar,255),
					new MySqlParameter("@store_dir", MySqlDbType.VarChar,255),
					new MySqlParameter("@value", MySqlDbType.Text),
					new MySqlParameter("@sort_order", MySqlDbType.Int32)};
            parameters[0].Value = model.parent_id;
            parameters[1].Value = model.code;
            parameters[2].Value = model.type;
            parameters[3].Value = model.store_range;
            parameters[4].Value = model.store_dir;
            parameters[5].Value = model.value;
            parameters[6].Value = model.sort_order;

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
        public bool Update(XHD.Model.ecs_shop_config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_shop_config set ");
            strSql.Append("parent_id=@parent_id,");
            strSql.Append("code=@code,");
            strSql.Append("type=@type,");
            strSql.Append("store_range=@store_range,");
            strSql.Append("store_dir=@store_dir,");
            strSql.Append("value=@value,");
            strSql.Append("sort_order=@sort_order");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@parent_id", MySqlDbType.Int32),
					new MySqlParameter("@code", MySqlDbType.VarChar,30),
					new MySqlParameter("@type", MySqlDbType.VarChar,10),
					new MySqlParameter("@store_range", MySqlDbType.VarChar,255),
					new MySqlParameter("@store_dir", MySqlDbType.VarChar,255),
					new MySqlParameter("@value", MySqlDbType.Text),
					new MySqlParameter("@sort_order", MySqlDbType.Int32),
					new MySqlParameter("@id", MySqlDbType.Int32)};
            parameters[0].Value = model.parent_id;
            parameters[1].Value = model.code;
            parameters[2].Value = model.type;
            parameters[3].Value = model.store_range;
            parameters[4].Value = model.store_dir;
            parameters[5].Value = model.value;
            parameters[6].Value = model.sort_order;
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
            strSql.Append("delete from ecs_shop_config ");
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
            strSql.Append("delete from ecs_shop_config ");
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
        public XHD.Model.ecs_shop_config GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,parent_id,code,type,store_range,store_dir,value,sort_order from ecs_shop_config ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.ecs_shop_config model = new XHD.Model.ecs_shop_config();
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
        public XHD.Model.ecs_shop_config DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_shop_config model = new XHD.Model.ecs_shop_config();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["parent_id"] != null && row["parent_id"].ToString() != "")
                {
                    model.parent_id = int.Parse(row["parent_id"].ToString());
                }
                if (row["code"] != null)
                {
                    model.code = row["code"].ToString();
                }
                if (row["type"] != null)
                {
                    model.type = row["type"].ToString();
                }
                if (row["store_range"] != null)
                {
                    model.store_range = row["store_range"].ToString();
                }
                if (row["store_dir"] != null)
                {
                    model.store_dir = row["store_dir"].ToString();
                }
                if (row["value"] != null)
                {
                    model.value = row["value"].ToString();
                }
                if (row["sort_order"] != null && row["sort_order"].ToString() != "")
                {
                    model.sort_order = int.Parse(row["sort_order"].ToString());
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
            strSql.Append("select id,parent_id,code,type,store_range,store_dir,value,sort_order ");
            strSql.Append(" FROM ecs_shop_config ");
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
            strSql.Append("select count(1) FROM ecs_shop_config ");
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
            strSql.Append(")AS Row, T.*  from ecs_shop_config T ");
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
            parameters[0].Value = "ecs_shop_config";
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

