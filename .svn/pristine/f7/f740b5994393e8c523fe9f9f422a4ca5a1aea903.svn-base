using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:shop_shipping
    /// </summary>
    public partial class shop_shipping
    {
        public shop_shipping()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("shipping_id", "shop_shipping");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int shipping_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_shipping");
            strSql.Append(" where shipping_id=@shipping_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@shipping_id", MySqlDbType.Int32,3)			};
            parameters[0].Value = shipping_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop_shipping model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_shipping(");
            strSql.Append("shipping_id,shipping_code,shipping_name,shipping_tel,shipping_address,shipping_desc,is_available,send_pay)");
            strSql.Append(" values (");
            strSql.Append("@shipping_id,@shipping_code,@shipping_name,@shipping_tel,@shipping_address,@shipping_desc,@is_available,@send_pay)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@shipping_id", MySqlDbType.Int32,3),
					new MySqlParameter("@shipping_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@shipping_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@shipping_tel", MySqlDbType.VarChar,20),
					new MySqlParameter("@shipping_address", MySqlDbType.VarChar,255),
					new MySqlParameter("@shipping_desc", MySqlDbType.Text),
					new MySqlParameter("@is_available", MySqlDbType.Int32,1),
					new MySqlParameter("@send_pay", MySqlDbType.Int32,1)};
            parameters[0].Value = model.shipping_id;
            parameters[1].Value = model.shipping_code;
            parameters[2].Value = model.shipping_name;
            parameters[3].Value = model.shipping_tel;
            parameters[4].Value = model.shipping_address;
            parameters[5].Value = model.shipping_desc;
            parameters[6].Value = model.is_available;
            parameters[7].Value = model.send_pay;

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
        public bool Update(XHD.Model.shop_shipping model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_shipping set ");
            strSql.Append("shipping_code=@shipping_code,");
            strSql.Append("shipping_name=@shipping_name,");
            strSql.Append("shipping_tel=@shipping_tel,");
            strSql.Append("shipping_address=@shipping_address,");
            strSql.Append("shipping_desc=@shipping_desc,");
            strSql.Append("is_available=@is_available,");
            strSql.Append("send_pay=@send_pay");
            strSql.Append(" where shipping_id=@shipping_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@shipping_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@shipping_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@shipping_tel", MySqlDbType.VarChar,20),
					new MySqlParameter("@shipping_address", MySqlDbType.VarChar,255),
					new MySqlParameter("@shipping_desc", MySqlDbType.Text),
					new MySqlParameter("@is_available", MySqlDbType.Int32,1),
					new MySqlParameter("@send_pay", MySqlDbType.Int32,1),
					new MySqlParameter("@shipping_id", MySqlDbType.Int32,3)};
            parameters[0].Value = model.shipping_code;
            parameters[1].Value = model.shipping_name;
            parameters[2].Value = model.shipping_tel;
            parameters[3].Value = model.shipping_address;
            parameters[4].Value = model.shipping_desc;
            parameters[5].Value = model.is_available;
            parameters[6].Value = model.send_pay;
            parameters[7].Value = model.shipping_id;

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
        public bool Delete(int shipping_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_shipping ");
            strSql.Append(" where shipping_id=@shipping_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@shipping_id", MySqlDbType.Int32,3)			};
            parameters[0].Value = shipping_id;

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
        public bool DeleteList(string shipping_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_shipping ");
            strSql.Append(" where shipping_id in (" + shipping_idlist + ")  ");
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
        public XHD.Model.shop_shipping GetModel(int shipping_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select shipping_id,shipping_code,shipping_name,shipping_tel,shipping_address,shipping_desc,is_available,send_pay from shop_shipping ");
            strSql.Append(" where shipping_id=@shipping_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@shipping_id", MySqlDbType.Int32,3)			};
            parameters[0].Value = shipping_id;

            XHD.Model.shop_shipping model = new XHD.Model.shop_shipping();
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
        public XHD.Model.shop_shipping DataRowToModel(DataRow row)
        {
            XHD.Model.shop_shipping model = new XHD.Model.shop_shipping();
            if (row != null)
            {
                if (row["shipping_id"] != null && row["shipping_id"].ToString() != "")
                {
                    model.shipping_id = int.Parse(row["shipping_id"].ToString());
                }
                if (row["shipping_code"] != null)
                {
                    model.shipping_code = row["shipping_code"].ToString();
                }
                if (row["shipping_name"] != null)
                {
                    model.shipping_name = row["shipping_name"].ToString();
                }
                if (row["shipping_tel"] != null)
                {
                    model.shipping_tel = row["shipping_tel"].ToString();
                }
                if (row["shipping_address"] != null)
                {
                    model.shipping_address = row["shipping_address"].ToString();
                }
                if (row["shipping_desc"] != null)
                {
                    model.shipping_desc = row["shipping_desc"].ToString();
                }
                if (row["is_available"] != null && row["is_available"].ToString() != "")
                {
                    model.is_available = int.Parse(row["is_available"].ToString());
                }
                if (row["send_pay"] != null && row["send_pay"].ToString() != "")
                {
                    model.send_pay = int.Parse(row["send_pay"].ToString());
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
            strSql.Append("select shipping_id,shipping_code,shipping_name,shipping_tel,shipping_address,shipping_desc,is_available,send_pay ");
            strSql.Append(" FROM shop_shipping ");
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
            strSql.Append("select count(1) FROM shop_shipping ");
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
                strSql.Append("order by T.shipping_id desc");
            }
            strSql.Append(")AS Row, T.*  from shop_shipping T ");
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
            parameters[0].Value = "shop_shipping";
            parameters[1].Value = "shipping_id";
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

