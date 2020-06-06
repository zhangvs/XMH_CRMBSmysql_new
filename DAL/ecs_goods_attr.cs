using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_goods_attr
    /// </summary>
    public partial class ecs_goods_attr
    {
        public ecs_goods_attr()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int goods_attr_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_goods_attr");
            strSql.Append(" where goods_attr_id=@goods_attr_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_attr_id", MySqlDbType.Int32)
			};
            parameters[0].Value = goods_attr_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_goods_attr model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_goods_attr(");
            strSql.Append("goods_id,attr_id,attr_value,attr_price)");
            strSql.Append(" values (");
            strSql.Append("@goods_id,@attr_id,@attr_value,@attr_price)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8),
					new MySqlParameter("@attr_id", MySqlDbType.Int16,5),
					new MySqlParameter("@attr_value", MySqlDbType.Text),
					new MySqlParameter("@attr_price", MySqlDbType.VarChar,255)};
            parameters[0].Value = model.goods_id;
            parameters[1].Value = model.attr_id;
            parameters[2].Value = model.attr_value;
            parameters[3].Value = model.attr_price;

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
        public bool Update(XHD.Model.ecs_goods_attr model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_goods_attr set ");
            strSql.Append("goods_id=@goods_id,");
            strSql.Append("attr_id=@attr_id,");
            strSql.Append("attr_value=@attr_value,");
            strSql.Append("attr_price=@attr_price");
            strSql.Append(" where goods_attr_id=@goods_attr_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8),
					new MySqlParameter("@attr_id", MySqlDbType.Int16,5),
					new MySqlParameter("@attr_value", MySqlDbType.Text),
					new MySqlParameter("@attr_price", MySqlDbType.VarChar,255),
					new MySqlParameter("@goods_attr_id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.goods_id;
            parameters[1].Value = model.attr_id;
            parameters[2].Value = model.attr_value;
            parameters[3].Value = model.attr_price;
            parameters[4].Value = model.goods_attr_id;

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
        public bool Delete(int goods_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_goods_attr ");
            strSql.Append(" where goods_id=@goods_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int32)
			};
            parameters[0].Value = goods_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows >= 0)
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
        public bool DeleteList(string goods_attr_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_goods_attr ");
            strSql.Append(" where goods_attr_id in (" + goods_attr_idlist + ")  ");
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
        public XHD.Model.ecs_goods_attr GetModel(int goods_attr_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select goods_attr_id,goods_id,attr_id,attr_value,attr_price from ecs_goods_attr ");
            strSql.Append(" where goods_attr_id=@goods_attr_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_attr_id", MySqlDbType.Int32)
			};
            parameters[0].Value = goods_attr_id;

            XHD.Model.ecs_goods_attr model = new XHD.Model.ecs_goods_attr();
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
        public XHD.Model.ecs_goods_attr DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_goods_attr model = new XHD.Model.ecs_goods_attr();
            if (row != null)
            {
                if (row["goods_attr_id"] != null && row["goods_attr_id"].ToString() != "")
                {
                    model.goods_attr_id = int.Parse(row["goods_attr_id"].ToString());
                }
                //model.goods_id=row["goods_id"].ToString();
                if (row["attr_id"] != null && row["attr_id"].ToString() != "")
                {
                    model.attr_id = int.Parse(row["attr_id"].ToString());
                }
                if (row["attr_value"] != null)
                {
                    model.attr_value = row["attr_value"].ToString();
                }
                if (row["attr_price"] != null)
                {
                    model.attr_price = row["attr_price"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * FROM ecs_goods_attr ");
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select goods_attr_id,goods_id,attr_id,attr_value,attr_price ");
            strSql.Append(" FROM ecs_goods_attr ");
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
            strSql.Append("select count(1) FROM ecs_goods_attr ");
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
                strSql.Append("order by T.goods_attr_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_goods_attr T ");
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
            strSql.Append("select * FROM ecs_goods_attr");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_Contact ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(goods_attr_id) FROM ecs_goods_attr ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetListCopy(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select goods_attr_id,goods_id,attr_id,attr_value,attr_price ");
            strSql.Append(" FROM scm_goods_attr ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool AddCopy(XHD.Model.ecs_goods_attr model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_goods_attr(");
            strSql.Append("goods_id,attr_id,attr_value,attr_price)");
            strSql.Append(" values (");
            strSql.Append("@goods_id,@attr_id,@attr_value,@attr_price)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8),
					new MySqlParameter("@attr_id", MySqlDbType.Int16,5),
					new MySqlParameter("@attr_value", MySqlDbType.Text),
					new MySqlParameter("@attr_price", MySqlDbType.VarChar,255)};
            parameters[0].Value = model.goods_id;
            parameters[1].Value = model.attr_id;
            parameters[2].Value = model.attr_value;
            parameters[3].Value = model.attr_price;

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
        public bool Update1(XHD.Model.ecs_goods_attr model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_goods_attr set ");
            strSql.Append("attr_value=@attr_value");
            strSql.Append(" where goods_id=@goods_id");
            strSql.Append(" and attr_id=@attr_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@attr_value", MySqlDbType.Text),
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8),
					new MySqlParameter("@attr_id", MySqlDbType.Int16,5)};

            parameters[0].Value = model.attr_value;
            parameters[1].Value = model.goods_id;
            parameters[2].Value = model.attr_id;

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
        public bool Update1Copy(XHD.Model.ecs_goods_attr model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_goods_attr set ");
            strSql.Append("attr_value=@attr_value");
            strSql.Append(" where goods_id=@goods_id");
            strSql.Append(" and attr_id=@attr_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@attr_value", MySqlDbType.Text),
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8),
					new MySqlParameter("@attr_id", MySqlDbType.Int16,5)};

            parameters[0].Value = model.attr_value;
            parameters[1].Value = model.goods_id;
            parameters[2].Value = model.attr_id;

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
        ///附表同步商城
        /// </summary>
        public bool CopyToShop(int goods_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_goods_attr(goods_attr_id,goods_id,attr_id,attr_value,attr_price) ");
            strSql.Append("select goods_attr_id,goods_id,attr_id,attr_value,attr_price ");
            strSql.Append(" from scm_goods_attr where goods_id=@goods_id  ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = goods_id;

            int row = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            parameters[0].Value = "ecs_goods_attr";
            parameters[1].Value = "goods_attr_id";
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

