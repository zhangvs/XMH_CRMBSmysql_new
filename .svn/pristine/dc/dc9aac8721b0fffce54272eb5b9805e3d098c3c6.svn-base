using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:shop_invoices_advance_billing
    /// </summary>
    public partial class shop_invoices_advance_billing
    {
        public shop_invoices_advance_billing()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("id", "shop_invoices_advance_billing");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_invoices_advance_billing");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop_invoices_advance_billing model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_invoices_advance_billing(");
            strSql.Append("id,order_id,order_sn,add_time,one_review,two_review,one_emp_code,two_emp_code,one_review_time,two_review_time,submit_emp_id,submit_emp_name)");
            strSql.Append(" values (");
            strSql.Append("@id,@order_id,@order_sn,@add_time,@one_review,@two_review,@one_emp_code,@two_emp_code,@one_review_time,@two_review_time,@submit_emp_id,@submit_emp_name)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@add_time", MySqlDbType.DateTime),
					new MySqlParameter("@one_review", MySqlDbType.Int32,2),
					new MySqlParameter("@two_review", MySqlDbType.Int32,2),
					new MySqlParameter("@one_emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@two_emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@one_review_time", MySqlDbType.DateTime),
					new MySqlParameter("@two_review_time", MySqlDbType.DateTime),
					new MySqlParameter("@submit_emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@submit_emp_name", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.order_id;
            parameters[2].Value = model.order_sn;
            parameters[3].Value = model.add_time;
            parameters[4].Value = model.one_review;
            parameters[5].Value = model.two_review;
            parameters[6].Value = model.one_emp_code;
            parameters[7].Value = model.two_emp_code;
            parameters[8].Value = model.one_review_time;
            parameters[9].Value = model.two_review_time;
            parameters[10].Value = model.submit_emp_id;
            parameters[11].Value = model.submit_emp_name;

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
        public bool Update(XHD.Model.shop_invoices_advance_billing model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_invoices_advance_billing set ");
            strSql.Append("order_id=@order_id,");
            strSql.Append("order_sn=@order_sn,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("one_review=@one_review,");
            strSql.Append("two_review=@two_review,");
            strSql.Append("one_emp_code=@one_emp_code,");
            strSql.Append("two_emp_code=@two_emp_code,");
            strSql.Append("one_review_time=@one_review_time,");
            strSql.Append("two_review_time=@two_review_time,");
            strSql.Append("submit_emp_id=@submit_emp_id,");
            strSql.Append("submit_emp_name=@submit_emp_name");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@add_time", MySqlDbType.DateTime),
					new MySqlParameter("@one_review", MySqlDbType.Int32,2),
					new MySqlParameter("@two_review", MySqlDbType.Int32,2),
					new MySqlParameter("@one_emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@two_emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@one_review_time", MySqlDbType.DateTime),
					new MySqlParameter("@two_review_time", MySqlDbType.DateTime),
					new MySqlParameter("@submit_emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@submit_emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.order_id;
            parameters[1].Value = model.order_sn;
            parameters[2].Value = model.add_time;
            parameters[3].Value = model.one_review;
            parameters[4].Value = model.two_review;
            parameters[5].Value = model.one_emp_code;
            parameters[6].Value = model.two_emp_code;
            parameters[7].Value = model.one_review_time;
            parameters[8].Value = model.two_review_time;
            parameters[9].Value = model.submit_emp_id;
            parameters[10].Value = model.submit_emp_name;
            parameters[11].Value = model.id;

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
        public bool Delete(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_invoices_advance_billing ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_invoices_advance_billing ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public XHD.Model.shop_invoices_advance_billing GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,order_id,order_sn,add_time,one_review,two_review,one_emp_code,two_emp_code,one_review_time,two_review_time,submit_emp_id,submit_emp_name from shop_invoices_advance_billing ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.shop_invoices_advance_billing model = new XHD.Model.shop_invoices_advance_billing();
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
        public XHD.Model.shop_invoices_advance_billing DataRowToModel(DataRow row)
        {
            XHD.Model.shop_invoices_advance_billing model = new XHD.Model.shop_invoices_advance_billing();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["order_id"] != null && row["order_id"].ToString() != "")
                {
                    model.order_id = int.Parse(row["order_id"].ToString());
                }
                if (row["order_sn"] != null)
                {
                    model.order_sn = row["order_sn"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = DateTime.Parse(row["add_time"].ToString());
                }
                if (row["one_review"] != null && row["one_review"].ToString() != "")
                {
                    model.one_review = int.Parse(row["one_review"].ToString());
                }
                if (row["two_review"] != null && row["two_review"].ToString() != "")
                {
                    model.two_review = int.Parse(row["two_review"].ToString());
                }
                if (row["one_emp_code"] != null)
                {
                    model.one_emp_code = row["one_emp_code"].ToString();
                }
                if (row["two_emp_code"] != null)
                {
                    model.two_emp_code = row["two_emp_code"].ToString();
                }
                if (row["one_review_time"] != null && row["one_review_time"].ToString() != "")
                {
                    model.one_review_time = DateTime.Parse(row["one_review_time"].ToString());
                }
                if (row["two_review_time"] != null && row["two_review_time"].ToString() != "")
                {
                    model.two_review_time = DateTime.Parse(row["two_review_time"].ToString());
                }
                if (row["submit_emp_id"] != null && row["submit_emp_id"].ToString() != "")
                {
                    model.submit_emp_id = int.Parse(row["submit_emp_id"].ToString());
                }
                if (row["submit_emp_name"] != null)
                {
                    model.submit_emp_name = row["submit_emp_name"].ToString();
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
            strSql.Append("select id,order_id,order_sn,add_time,one_review,two_review,one_emp_code,two_emp_code,one_review_time,two_review_time,submit_emp_id,submit_emp_name ");
            strSql.Append(" FROM shop_invoices_advance_billing ");
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
            strSql.Append("select count(1) FROM shop_invoices_advance_billing ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from shop_invoices_advance_billing T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetList2(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select o.order_id,o.order_sn,o.user_id,o.order_status,o.shipping_status,o.pay_status,o.add_time,o.consignee,o.tel,o.province, r1.region_name province_name,o.city,r2.region_name city_name,o.district,r3.region_name district_name,o.address,o.goods_amount,o.order_amount, ");
            strSql.Append(" ct.C_tel,ct.C_name,cr.BeSeats,cr.Customer ,ct.id tid,");
            strSql.Append(" ab.add_time ab_add_time,ab.*");
            strSql.Append(" FROM xmh_shop.shop_order_info as o");
            strSql.Append(" inner join crm_contact as ct on o.user_id = ct.id");
            strSql.Append(" INNER JOIN crm_customer cr ON ct.C_customerid = cr.id ");
            strSql.Append(" inner join xmh_shop.shop_invoices_advance_billing as ab on ab.order_id = o.order_id");
            strSql.Append(" left join xmh_shop.shop_region as r1 on o.province = r1.region_id");
            strSql.Append(" left join xmh_shop.shop_region as r2 on o.city = r2.region_id");
            strSql.Append(" left join xmh_shop.shop_region as r3 on o.district = r3.region_id");
            strSql1.Append(" select count(1) FROM xmh_shop.shop_order_info as o inner join crm_contact as ct on o.user_id = ct.id ");
            strSql1.Append(" INNER JOIN crm_customer cr ON ct.C_customerid = cr.id ");
            strSql1.Append(" inner join xmh_shop.shop_invoices_advance_billing as ab on ab.order_id = o.order_id");
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
            parameters[0].Value = "shop_invoices_advance_billing";
            parameters[1].Value = "id";
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

