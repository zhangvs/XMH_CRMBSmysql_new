using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references


namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:shop_points_order_goods
    /// </summary>
    public partial class shop_points_order_goods
    {
        public shop_points_order_goods()
        { }

        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ordergood_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_points_order_goods");
            strSql.Append(" where ordergood_id=@ordergood_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ordergood_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = ordergood_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop_points_order_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_points_order_goods(");
            strSql.Append("ordergood_id,cart_id,order_id,goods_id,goods_name,goods_sn,goods_number,market_price,goods_price,shipping_fee_price,user_id,admin_id,purchase_goods_status,is_submit_purchase,stock_warn,is_invoce,is_add_order,doc_id,wms_setbook_id,wms_position,wms_record,goods_integral_price)");
            strSql.Append(" values (");
            strSql.Append("@ordergood_id,@cart_id,@order_id,@goods_id,@goods_name,@goods_sn,@goods_number,@market_price,@goods_price,@shipping_fee_price,@user_id,@admin_id,@purchase_goods_status,@is_submit_purchase,@stock_warn,@is_invoce,@is_add_order,@doc_id,@wms_setbook_id,@wms_position,@wms_record,@goods_integral_price)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ordergood_id", MySqlDbType.Int16,8),
					new MySqlParameter("@cart_id", MySqlDbType.Int16,8),
					new MySqlParameter("@order_id", MySqlDbType.Int16,8),
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_number", MySqlDbType.Int32,10),
					new MySqlParameter("@market_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@goods_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_fee_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@user_id", MySqlDbType.Int32,10),
					new MySqlParameter("@admin_id", MySqlDbType.Int32,10),
					new MySqlParameter("@purchase_goods_status", MySqlDbType.Int16,2),
					new MySqlParameter("@is_submit_purchase", MySqlDbType.Int16,2),
					new MySqlParameter("@stock_warn", MySqlDbType.Int16,1),
					new MySqlParameter("@is_invoce", MySqlDbType.Int16,3),
					new MySqlParameter("@is_add_order", MySqlDbType.Int16,2),
					new MySqlParameter("@doc_id", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_setbook_id", MySqlDbType.Int16,3),
					new MySqlParameter("@wms_position", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_record", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_integral_price", MySqlDbType.Decimal,10)};
            parameters[0].Value = model.ordergood_id;
            parameters[1].Value = model.cart_id;
            parameters[2].Value = model.order_id;
            parameters[3].Value = model.goods_id;
            parameters[4].Value = model.goods_name;
            parameters[5].Value = model.goods_sn;
            parameters[6].Value = model.goods_number;
            parameters[7].Value = model.market_price;
            parameters[8].Value = model.goods_price;
            parameters[9].Value = model.shipping_fee_price;
            parameters[10].Value = model.user_id;
            parameters[11].Value = model.admin_id;
            parameters[12].Value = model.purchase_goods_status;
            parameters[13].Value = model.is_submit_purchase;
            parameters[14].Value = model.stock_warn;
            parameters[15].Value = model.is_invoce;
            parameters[16].Value = model.is_add_order;
            parameters[17].Value = model.doc_id;
            parameters[18].Value = model.wms_setbook_id;
            parameters[19].Value = model.wms_position;
            parameters[20].Value = model.wms_record;
            parameters[21].Value = model.goods_integral_price;

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
        public bool Update(XHD.Model.shop_points_order_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_points_order_goods set ");
            strSql.Append("cart_id=@cart_id,");
            strSql.Append("order_id=@order_id,");
            strSql.Append("goods_id=@goods_id,");
            strSql.Append("goods_name=@goods_name,");
            strSql.Append("goods_sn=@goods_sn,");
            strSql.Append("goods_number=@goods_number,");
            strSql.Append("market_price=@market_price,");
            strSql.Append("goods_price=@goods_price,");
            strSql.Append("shipping_fee_price=@shipping_fee_price,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("admin_id=@admin_id,");
            strSql.Append("purchase_goods_status=@purchase_goods_status,");
            strSql.Append("is_submit_purchase=@is_submit_purchase,");
            strSql.Append("stock_warn=@stock_warn,");
            strSql.Append("is_invoce=@is_invoce,");
            strSql.Append("is_add_order=@is_add_order,");
            strSql.Append("doc_id=@doc_id,");
            strSql.Append("wms_setbook_id=@wms_setbook_id,");
            strSql.Append("wms_position=@wms_position,");
            strSql.Append("wms_record=@wms_record,");
            strSql.Append("goods_integral_price=@goods_integral_price");
            strSql.Append(" where ordergood_id=@ordergood_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cart_id", MySqlDbType.Int16,8),
					new MySqlParameter("@order_id", MySqlDbType.Int16,8),
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_number", MySqlDbType.Int32,10),
					new MySqlParameter("@market_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@goods_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_fee_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@user_id", MySqlDbType.Int32,10),
					new MySqlParameter("@admin_id", MySqlDbType.Int32,10),
					new MySqlParameter("@purchase_goods_status", MySqlDbType.Int16,2),
					new MySqlParameter("@is_submit_purchase", MySqlDbType.Int16,2),
					new MySqlParameter("@stock_warn", MySqlDbType.Int16,1),
					new MySqlParameter("@is_invoce", MySqlDbType.Int16,3),
					new MySqlParameter("@is_add_order", MySqlDbType.Int16,2),
					new MySqlParameter("@doc_id", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_setbook_id", MySqlDbType.Int16,3),
					new MySqlParameter("@wms_position", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_record", MySqlDbType.Int32,10),
					new MySqlParameter("@goods_integral_price", MySqlDbType.Decimal,10),
					new MySqlParameter("@ordergood_id", MySqlDbType.Int16,8)};
            parameters[0].Value = model.cart_id;
            parameters[1].Value = model.order_id;
            parameters[2].Value = model.goods_id;
            parameters[3].Value = model.goods_name;
            parameters[4].Value = model.goods_sn;
            parameters[5].Value = model.goods_number;
            parameters[6].Value = model.market_price;
            parameters[7].Value = model.goods_price;
            parameters[8].Value = model.shipping_fee_price;
            parameters[9].Value = model.user_id;
            parameters[10].Value = model.admin_id;
            parameters[11].Value = model.purchase_goods_status;
            parameters[12].Value = model.is_submit_purchase;
            parameters[13].Value = model.stock_warn;
            parameters[14].Value = model.is_invoce;
            parameters[15].Value = model.is_add_order;
            parameters[16].Value = model.doc_id;
            parameters[17].Value = model.wms_setbook_id;
            parameters[18].Value = model.wms_position;
            parameters[19].Value = model.wms_record;
            parameters[20].Value = model.goods_integral_price;
            parameters[21].Value = model.ordergood_id;

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
        public bool Delete(int ordergood_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_points_order_goods ");
            strSql.Append(" where ordergood_id=@ordergood_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ordergood_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = ordergood_id;

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
        public bool DeleteList(string ordergood_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_points_order_goods ");
            strSql.Append(" where ordergood_id in (" + ordergood_idlist + ")  ");
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
        public XHD.Model.shop_points_order_goods GetModel(int ordergood_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ordergood_id,cart_id,order_id,goods_id,goods_name,goods_sn,goods_number,market_price,goods_price,shipping_fee_price,user_id,admin_id,purchase_goods_status,is_submit_purchase,stock_warn,is_invoce,is_add_order,doc_id,wms_setbook_id,wms_position,wms_record,goods_integral_price from shop_points_order_goods ");
            strSql.Append(" where ordergood_id=@ordergood_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ordergood_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = ordergood_id;

            XHD.Model.shop_points_order_goods model = new XHD.Model.shop_points_order_goods();
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
        public XHD.Model.shop_points_order_goods DataRowToModel(DataRow row)
        {
            XHD.Model.shop_points_order_goods model = new XHD.Model.shop_points_order_goods();
            if (row != null)
            {
                //model.ordergood_id=row["ordergood_id"].ToString();
                //model.cart_id=row["cart_id"].ToString();
                //model.order_id=row["order_id"].ToString();
                //model.goods_id=row["goods_id"].ToString();
                if (row["goods_name"] != null)
                {
                    model.goods_name = row["goods_name"].ToString();
                }
                if (row["goods_sn"] != null)
                {
                    model.goods_sn = row["goods_sn"].ToString();
                }
                if (row["goods_number"] != null && row["goods_number"].ToString() != "")
                {
                    model.goods_number = int.Parse(row["goods_number"].ToString());
                }
                if (row["market_price"] != null && row["market_price"].ToString() != "")
                {
                    model.market_price = decimal.Parse(row["market_price"].ToString());
                }
                if (row["goods_price"] != null && row["goods_price"].ToString() != "")
                {
                    model.goods_price = decimal.Parse(row["goods_price"].ToString());
                }
                if (row["shipping_fee_price"] != null && row["shipping_fee_price"].ToString() != "")
                {
                    model.shipping_fee_price = decimal.Parse(row["shipping_fee_price"].ToString());
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["admin_id"] != null && row["admin_id"].ToString() != "")
                {
                    model.admin_id = int.Parse(row["admin_id"].ToString());
                }
                if (row["purchase_goods_status"] != null && row["purchase_goods_status"].ToString() != "")
                {
                    model.purchase_goods_status = int.Parse(row["purchase_goods_status"].ToString());
                }
                if (row["is_submit_purchase"] != null && row["is_submit_purchase"].ToString() != "")
                {
                    model.is_submit_purchase = int.Parse(row["is_submit_purchase"].ToString());
                }
                if (row["stock_warn"] != null && row["stock_warn"].ToString() != "")
                {
                    model.stock_warn = int.Parse(row["stock_warn"].ToString());
                }
                if (row["is_invoce"] != null && row["is_invoce"].ToString() != "")
                {
                    model.is_invoce = int.Parse(row["is_invoce"].ToString());
                }
                if (row["is_add_order"] != null && row["is_add_order"].ToString() != "")
                {
                    model.is_add_order = int.Parse(row["is_add_order"].ToString());
                }
                if (row["doc_id"] != null && row["doc_id"].ToString() != "")
                {
                    model.doc_id = decimal.Parse(row["doc_id"].ToString());
                }
                if (row["wms_setbook_id"] != null && row["wms_setbook_id"].ToString() != "")
                {
                    model.wms_setbook_id = int.Parse(row["wms_setbook_id"].ToString());
                }
                if (row["wms_position"] != null)
                {
                    model.wms_position = row["wms_position"].ToString();
                }
                if (row["wms_record"] != null && row["wms_record"].ToString() != "")
                {
                    model.wms_record = int.Parse(row["wms_record"].ToString());
                }
                if (row["goods_integral_price"] != null && row["goods_integral_price"].ToString() != "")
                {
                    model.goods_integral_price = decimal.Parse(row["goods_integral_price"].ToString());
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
            strSql.Append("select ordergood_id,cart_id,order_id,goods_id,goods_name,goods_sn,goods_number,market_price,goods_price,shipping_fee_price,user_id,admin_id,purchase_goods_status,is_submit_purchase,stock_warn,is_invoce,is_add_order,doc_id,wms_setbook_id,wms_position,wms_record,goods_integral_price ");
            strSql.Append(" FROM shop_points_order_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        //获取我的订单信息
        public DataSet GetList(int PageSize, int PageIndex, string strWhere,  string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select g.*,o.order_status,o.shipping_status,o.pay_status,o.add_time from shop_points_order_goods g  left join shop_points_order o on g.order_id=o.order_id ");
            strSql1.Append("select count(g.ordergood_id)  from shop_points_order_goods g  ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);

            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

