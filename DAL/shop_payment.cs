using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:shop_payment
    /// </summary>
    public partial class shop_payment
    {
        public shop_payment()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("pay_id", "shop_payment");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int pay_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_payment");
            strSql.Append(" where pay_id=@pay_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = pay_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop_payment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_payment(");
            strSql.Append("pay_id,pay_name,pay_code,pay_notes,pay_fee,pay_sort,is_enabled,is_cod,is_online,is_user_show)");
            strSql.Append(" values (");
            strSql.Append("@pay_id,@pay_name,@pay_code,@pay_notes,@pay_fee,@pay_sort,@is_enabled,@is_cod,@is_online,@is_user_show)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_id", MySqlDbType.Int32,11),
					new MySqlParameter("@pay_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@pay_code", MySqlDbType.VarChar,10),
					new MySqlParameter("@pay_notes", MySqlDbType.VarChar,500),
					new MySqlParameter("@pay_fee", MySqlDbType.Decimal,8),
					new MySqlParameter("@pay_sort", MySqlDbType.Int32,11),
					new MySqlParameter("@is_enabled", MySqlDbType.Int32,2),
					new MySqlParameter("@is_cod", MySqlDbType.Int32,2),
					new MySqlParameter("@is_online", MySqlDbType.Int32,2),
					new MySqlParameter("@is_user_show", MySqlDbType.Int32,2)};
            parameters[0].Value = model.pay_id;
            parameters[1].Value = model.pay_name;
            parameters[2].Value = model.pay_code;
            parameters[3].Value = model.pay_notes;
            parameters[4].Value = model.pay_fee;
            parameters[5].Value = model.pay_sort;
            parameters[6].Value = model.is_enabled;
            parameters[7].Value = model.is_cod;
            parameters[8].Value = model.is_online;
            parameters[9].Value = model.is_user_show;

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
        public bool Update(XHD.Model.shop_payment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_payment set ");
            strSql.Append("pay_name=@pay_name,");
            strSql.Append("pay_code=@pay_code,");
            strSql.Append("pay_notes=@pay_notes,");
            strSql.Append("pay_fee=@pay_fee,");
            strSql.Append("pay_sort=@pay_sort,");
            strSql.Append("is_enabled=@is_enabled,");
            strSql.Append("is_cod=@is_cod,");
            strSql.Append("is_online=@is_online,");
            strSql.Append("is_user_show=@is_user_show");
            strSql.Append(" where pay_id=@pay_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@pay_code", MySqlDbType.VarChar,10),
					new MySqlParameter("@pay_notes", MySqlDbType.VarChar,500),
					new MySqlParameter("@pay_fee", MySqlDbType.Decimal,8),
					new MySqlParameter("@pay_sort", MySqlDbType.Int32,11),
					new MySqlParameter("@is_enabled", MySqlDbType.Int32,2),
					new MySqlParameter("@is_cod", MySqlDbType.Int32,2),
					new MySqlParameter("@is_online", MySqlDbType.Int32,2),
					new MySqlParameter("@is_user_show", MySqlDbType.Int32,2),
					new MySqlParameter("@pay_id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.pay_name;
            parameters[1].Value = model.pay_code;
            parameters[2].Value = model.pay_notes;
            parameters[3].Value = model.pay_fee;
            parameters[4].Value = model.pay_sort;
            parameters[5].Value = model.is_enabled;
            parameters[6].Value = model.is_cod;
            parameters[7].Value = model.is_online;
            parameters[8].Value = model.is_user_show;
            parameters[9].Value = model.pay_id;

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
        public bool Delete(int pay_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_payment ");
            strSql.Append(" where pay_id=@pay_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = pay_id;

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
        public bool DeleteList(string pay_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_payment ");
            strSql.Append(" where pay_id in (" + pay_idlist + ")  ");
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
        public XHD.Model.shop_payment GetModel(int pay_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select pay_id,pay_name,pay_code,pay_notes,pay_fee,pay_sort,is_enabled,is_cod,is_online,is_user_show from shop_payment ");
            strSql.Append(" where pay_id=@pay_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = pay_id;

            XHD.Model.shop_payment model = new XHD.Model.shop_payment();
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
        public XHD.Model.shop_payment DataRowToModel(DataRow row)
        {
            XHD.Model.shop_payment model = new XHD.Model.shop_payment();
            if (row != null)
            {
                if (row["pay_id"] != null && row["pay_id"].ToString() != "")
                {
                    model.pay_id = int.Parse(row["pay_id"].ToString());
                }
                if (row["pay_name"] != null)
                {
                    model.pay_name = row["pay_name"].ToString();
                }
                if (row["pay_code"] != null)
                {
                    model.pay_code = row["pay_code"].ToString();
                }
                if (row["pay_notes"] != null)
                {
                    model.pay_notes = row["pay_notes"].ToString();
                }
                if (row["pay_fee"] != null && row["pay_fee"].ToString() != "")
                {
                    model.pay_fee = decimal.Parse(row["pay_fee"].ToString());
                }
                if (row["pay_sort"] != null && row["pay_sort"].ToString() != "")
                {
                    model.pay_sort = int.Parse(row["pay_sort"].ToString());
                }
                if (row["is_enabled"] != null && row["is_enabled"].ToString() != "")
                {
                    model.is_enabled = int.Parse(row["is_enabled"].ToString());
                }
                if (row["is_cod"] != null && row["is_cod"].ToString() != "")
                {
                    model.is_cod = int.Parse(row["is_cod"].ToString());
                }
                if (row["is_online"] != null && row["is_online"].ToString() != "")
                {
                    model.is_online = int.Parse(row["is_online"].ToString());
                }
                if (row["is_user_show"] != null && row["is_user_show"].ToString() != "")
                {
                    model.is_user_show = int.Parse(row["is_user_show"].ToString());
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
            strSql.Append("select pay_id,pay_name,pay_code,pay_notes,pay_fee,pay_sort,is_enabled,is_cod,is_online,is_user_show ");
            strSql.Append(" FROM shop_payment ");
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
            strSql.Append("select count(1) FROM shop_payment ");
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
                strSql.Append("order by T.pay_id desc");
            }
            strSql.Append(")AS Row, T.*  from shop_payment T ");
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
            parameters[0].Value = "shop_payment";
            parameters[1].Value = "pay_id";
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

