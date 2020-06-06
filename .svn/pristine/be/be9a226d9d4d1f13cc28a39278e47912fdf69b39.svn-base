using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:shop_ship_unload
    /// </summary>
    public partial class shop_ship_unload
    {
        public shop_ship_unload()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("unload_id", "shop_ship_unload");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int unload_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_ship_unload");
            strSql.Append(" where unload_id=@unload_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@unload_id", MySqlDbType.Int32,10)			};
            parameters[0].Value = unload_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop_ship_unload model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_ship_unload(");
            strSql.Append("unload_id,unload_name,comp_id,province_id,city_id,distinct_id,unload_tel,unload_address)");
            strSql.Append(" values (");
            strSql.Append("@unload_id,@unload_name,@comp_id,@province_id,@city_id,@distinct_id,@unload_tel,@unload_address)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@unload_id", MySqlDbType.Int32,10),
					new MySqlParameter("@unload_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@comp_id", MySqlDbType.Int32,5),
					new MySqlParameter("@province_id", MySqlDbType.Int32,5),
					new MySqlParameter("@city_id", MySqlDbType.Int32,10),
					new MySqlParameter("@distinct_id", MySqlDbType.Int32,11),
					new MySqlParameter("@unload_tel", MySqlDbType.VarChar,255),
					new MySqlParameter("@unload_address", MySqlDbType.VarChar,255)};
            parameters[0].Value = model.unload_id;
            parameters[1].Value = model.unload_name;
            parameters[2].Value = model.comp_id;
            parameters[3].Value = model.province_id;
            parameters[4].Value = model.city_id;
            parameters[5].Value = model.distinct_id;
            parameters[6].Value = model.unload_tel;
            parameters[7].Value = model.unload_address;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(XHD.Model.shop_ship_unload model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_ship_unload set ");
            strSql.Append("unload_name=@unload_name,");
            strSql.Append("comp_id=@comp_id,");
            strSql.Append("province_id=@province_id,");
            strSql.Append("city_id=@city_id,");
            strSql.Append("distinct_id=@distinct_id,");
            strSql.Append("unload_tel=@unload_tel,");
            strSql.Append("unload_address=@unload_address");
            strSql.Append(" where unload_id=@unload_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@unload_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@comp_id", MySqlDbType.Int32,5),
					new MySqlParameter("@province_id", MySqlDbType.Int32,5),
					new MySqlParameter("@city_id", MySqlDbType.Int32,10),
					new MySqlParameter("@distinct_id", MySqlDbType.Int32,11),
					new MySqlParameter("@unload_tel", MySqlDbType.VarChar,255),
					new MySqlParameter("@unload_address", MySqlDbType.VarChar,255),
					new MySqlParameter("@unload_id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.unload_name;
            parameters[1].Value = model.comp_id;
            parameters[2].Value = model.province_id;
            parameters[3].Value = model.city_id;
            parameters[4].Value = model.distinct_id;
            parameters[5].Value = model.unload_tel;
            parameters[6].Value = model.unload_address;
            parameters[7].Value = model.unload_id;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int unload_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_ship_unload ");
            strSql.Append(" where unload_id=@unload_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@unload_id", MySqlDbType.Int32,10)			};
            parameters[0].Value = unload_id;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string unload_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_ship_unload ");
            strSql.Append(" where unload_id in (" + unload_idlist + ")  ");
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public XHD.Model.shop_ship_unload GetModel(int unload_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select unload_id,unload_name,comp_id,province_id,city_id,distinct_id,unload_tel,unload_address from shop_ship_unload ");
            strSql.Append(" where unload_id=@unload_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@unload_id", MySqlDbType.Int32,10)			};
            parameters[0].Value = unload_id;

            XHD.Model.shop_ship_unload model = new XHD.Model.shop_ship_unload();
            DataSet ds = Shop_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public XHD.Model.shop_ship_unload DataRowToModel(DataRow row)
        {
            XHD.Model.shop_ship_unload model = new XHD.Model.shop_ship_unload();
            if (row != null)
            {
                if (row["unload_id"] != null && row["unload_id"].ToString() != "")
                {
                    model.unload_id = int.Parse(row["unload_id"].ToString());
                }
                if (row["unload_name"] != null)
                {
                    model.unload_name = row["unload_name"].ToString();
                }
                if (row["comp_id"] != null && row["comp_id"].ToString() != "")
                {
                    model.comp_id = int.Parse(row["comp_id"].ToString());
                }
                if (row["province_id"] != null && row["province_id"].ToString() != "")
                {
                    model.province_id = int.Parse(row["province_id"].ToString());
                }
                if (row["city_id"] != null && row["city_id"].ToString() != "")
                {
                    model.city_id = int.Parse(row["city_id"].ToString());
                }
                if (row["distinct_id"] != null && row["distinct_id"].ToString() != "")
                {
                    model.distinct_id = int.Parse(row["distinct_id"].ToString());
                }
                if (row["unload_tel"] != null)
                {
                    model.unload_tel = row["unload_tel"].ToString();
                }
                if (row["unload_address"] != null)
                {
                    model.unload_address = row["unload_address"].ToString();
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
            strSql.Append("select unload_id,unload_name,comp_id,province_id,city_id,distinct_id,unload_tel,unload_address ");
            strSql.Append(" FROM shop_ship_unload ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM shop_ship_unload ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
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
                strSql.Append("order by T.unload_id desc");
            }
            strSql.Append(")AS Row, T.*  from shop_ship_unload T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return Shop_DbHelperMySQL.Query(strSql.ToString());
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
            parameters[0].Value = "shop_ship_unload";
            parameters[1].Value = "unload_id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return Shop_DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

