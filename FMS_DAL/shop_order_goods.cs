﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:shop_order_goods
    /// </summary>
    public partial class shop_order_goods
    {
        public shop_order_goods()
        { }

        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ordergood_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_order_goods");
            strSql.Append(" where ordergood_id=@ordergood_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ordergood_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = ordergood_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.shop_order_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_order_goods(");
            strSql.Append("ordergood_id,cart_id,order_id,order_sn,goods_id,goods_name,goods_sn,goods_number,market_price,goods_price,shipping_fee_price,user_id,admin_id,purchase_goods_status,is_submit_purchase,stock_warn,is_invoice,is_add_order,doc_id,wms_setbook_id,wms_position,wms_record)");
            strSql.Append(" values (");
            strSql.Append("@ordergood_id,@cart_id,@order_id,@order_sn,@goods_id,@goods_name,@goods_sn,@goods_number,@market_price,@goods_price,@shipping_fee_price,@user_id,@admin_id,@purchase_goods_status,@is_submit_purchase,@stock_warn,@is_invoice,@is_add_order,@doc_id,@wms_setbook_id,@wms_position,@wms_record)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ordergood_id", MySqlDbType.Int16,8),
					new MySqlParameter("@cart_id", MySqlDbType.Int16,8),
					new MySqlParameter("@order_id", MySqlDbType.Int16,8),
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
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
					new MySqlParameter("@is_invoice", MySqlDbType.Int16,3),
					new MySqlParameter("@is_add_order", MySqlDbType.Int16,2),
					new MySqlParameter("@doc_id", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_setbook_id", MySqlDbType.Int16,3),
					new MySqlParameter("@wms_position", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_record", MySqlDbType.Int32,10)};
            parameters[0].Value = model.ordergood_id;
            parameters[1].Value = model.cart_id;
            parameters[2].Value = model.order_id;
            parameters[3].Value = model.order_sn;
            parameters[4].Value = model.goods_id;
            parameters[5].Value = model.goods_name;
            parameters[6].Value = model.goods_sn;
            parameters[7].Value = model.goods_number;
            parameters[8].Value = model.market_price;
            parameters[9].Value = model.goods_price;
            parameters[10].Value = model.shipping_fee_price;
            parameters[11].Value = model.user_id;
            parameters[12].Value = model.admin_id;
            parameters[13].Value = model.purchase_goods_status;
            parameters[14].Value = model.is_submit_purchase;
            parameters[15].Value = model.stock_warn;
            parameters[16].Value = model.is_invoice;
            parameters[17].Value = model.is_add_order;
            parameters[18].Value = model.doc_id;
            parameters[19].Value = model.wms_setbook_id;
            parameters[20].Value = model.wms_position;
            parameters[21].Value = model.wms_record;

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
        public bool Update(FMS_Model.shop_order_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_order_goods set ");
            strSql.Append("cart_id=@cart_id,");
            strSql.Append("order_id=@order_id,");
            strSql.Append("order_sn=@order_sn,");
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
            strSql.Append("is_invoice=@is_invoice,");
            strSql.Append("is_add_order=@is_add_order,");
            strSql.Append("doc_id=@doc_id,");
            strSql.Append("wms_setbook_id=@wms_setbook_id,");
            strSql.Append("wms_position=@wms_position,");
            strSql.Append("wms_record=@wms_record");
            strSql.Append(" where ordergood_id=@ordergood_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@cart_id", MySqlDbType.Int16,8),
					new MySqlParameter("@order_id", MySqlDbType.Int16,8),
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
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
					new MySqlParameter("@is_invoice", MySqlDbType.Int16,3),
					new MySqlParameter("@is_add_order", MySqlDbType.Int16,2),
					new MySqlParameter("@doc_id", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_setbook_id", MySqlDbType.Int16,3),
					new MySqlParameter("@wms_position", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_record", MySqlDbType.Int32,10),
					new MySqlParameter("@ordergood_id", MySqlDbType.Int16,8)};
            parameters[0].Value = model.cart_id;
            parameters[1].Value = model.order_id;
            parameters[2].Value = model.order_sn;
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
            parameters[15].Value = model.is_invoice;
            parameters[16].Value = model.is_add_order;
            parameters[17].Value = model.doc_id;
            parameters[18].Value = model.wms_setbook_id;
            parameters[19].Value = model.wms_position;
            parameters[20].Value = model.wms_record;
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
        /// 更新已开票数量
        /// </summary>
        public bool UpdateNum(FMS_Model.shop_order_goods model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" update  shop_order_goods set invoice_number='" + model.invoice_number + "'");
            strSql.Append(" where ordergood_id='" + model.ordergood_id + "' ");

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ordergood_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_order_goods ");
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
            strSql.Append("delete from shop_order_goods ");
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
        public FMS_Model.shop_order_goods GetModel(int ordergood_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ordergood_id,cart_id,order_id,order_sn,goods_id,goods_name,goods_sn,goods_number,invoice_number,market_price,goods_price,shipping_fee_price,user_id,admin_id,purchase_goods_status,is_submit_purchase,stock_warn,is_invoice,is_add_order,doc_id,wms_setbook_id,wms_position,wms_record from shop_order_goods ");
            strSql.Append(" where ordergood_id=@ordergood_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ordergood_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = ordergood_id;

            FMS_Model.shop_order_goods model = new FMS_Model.shop_order_goods();
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
        public FMS_Model.shop_order_goods DataRowToModel(DataRow row)
        {
            FMS_Model.shop_order_goods model = new FMS_Model.shop_order_goods();
            if (row != null)
            {
                //model.ordergood_id=row["ordergood_id"].ToString();
                //model.cart_id=row["cart_id"].ToString();
                //model.order_id=row["order_id"].ToString();
                if (row["ordergood_id"] != null && row["ordergood_id"].ToString() != "")
                {
                    model.ordergood_id = int.Parse(row["ordergood_id"].ToString());
                }
                if (row["cart_id"] != null && row["cart_id"].ToString() != "")
                {
                    model.cart_id = int.Parse(row["cart_id"].ToString());
                }
                if (row["order_id"] != null && row["order_id"].ToString() != "")
                {
                    model.order_id = int.Parse(row["order_id"].ToString());
                }
                if (row["order_sn"] != null)
                {
                    model.order_sn = row["order_sn"].ToString();
                }
                //model.goods_id=row["goods_id"].ToString();
                if (row["goods_id"] != null && row["goods_id"].ToString() != "")
                {
                    model.goods_id = int.Parse(row["goods_id"].ToString());
                }
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
                if (row["invoice_number"] != null && row["invoice_number"].ToString() != "")
                {
                    model.invoice_number = int.Parse(row["invoice_number"].ToString());
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
                if (row["is_invoice"] != null && row["is_invoice"].ToString() != "")
                {
                    model.is_invoice = int.Parse(row["is_invoice"].ToString());
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ordergood_id,cart_id,order_id,order_sn,goods_id,goods_name,goods_sn,goods_number,market_price,goods_price,shipping_fee_price,user_id,admin_id,purchase_goods_status,is_submit_purchase,stock_warn,is_invoice,is_add_order,doc_id,wms_setbook_id,wms_position,wms_record,invoice_number ");
            strSql.Append(" FROM shop_order_goods ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        //获得客户的发货金额
        public string GetDeliveryAmoun(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(r.goods_number*r.goods_price) as delivery_amoun,sum(shipping_fee) as shipping_fee from shop_order_goods r inner join  shop_order_info i on r.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }


        //获得客户的发货金额
        public DataSet GetDeliveryAmouns(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum(total) delivery_amoun,sum(shipping_fee) as shipping_fee from (   ");
            strSql.Append(" select sum(r.goods_number*r.goods_price) as total,i.shipping_fee from shop_order_goods r inner join shop_order_info i ");
            strSql.Append(" on r.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null  where " + strWhere + " group by i.order_id ");
            strSql.Append(" ) abc ");

            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }
          
        /// <summary>
        /// 获得客户的发货金额、开票金额、未开票金额
        /// </summary>
        public DataSet GetBillAmoun(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum(ifnull(r.invoice_number,0)*r.goods_price) as bill_amoun,i.deduction_shipping_fee as bill_Fee, (i.shipping_fee- i.deduction_shipping_fee) as unbill_Fee,i.shipping_fee as nobill_Fee,");
            strSql.Append(" sum((ifnull(r.goods_number,0)-ifnull(r.invoice_number,0))*r.goods_price) as unbill_amoun, ");
            strSql.Append(" sum(ifnull(r.goods_number,0)*r.goods_price) as nobill_amoun "); //and i.order_status !=9 and i.erp_time is not null
            strSql.Append(" from shop_order_goods r ");
            strSql.Append(" inner join  shop_order_info i on r.order_id= i.order_id and (i.order_status !=9 and i.order_status !=2 ) and i.erp_time is not null "); //and i.order_status !=9 and i.erp_time is not null

            //strSql.Append(" and i.need_inv=1 and (ifnull(r.goods_number,0)-ifnull(r.invoice_number,0))>0 and (i.shipping_status=1 or (i.is_invoice_advance=1 and i.shipping_status=5) or (i.is_invoice_advance=5)) ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得客户运费
        /// </summary>
        public DataSet GetBillFee(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum(i.deduction_shipping_fee) as bill_Fee,sum((i.shipping_fee- i.deduction_shipping_fee)) as unbill_Fee, sum(i.shipping_fee) as nobill_Fee ");
            strSql.Append(" from  shop_order_info i   ");

            //strSql.Append(" and i.need_inv=1 and (ifnull(r.goods_number,0)-ifnull(r.invoice_number,0))>0 and (i.shipping_status=1 or (i.is_invoice_advance=1 and i.shipping_status=5) or (i.is_invoice_advance=5)) ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取发票-往来账
        /// </summary>
        /// <returns></returns>
        public DataSet GetBill(int PageSize, int PageIndex, string strWhere, string filedOrder, string time, string money, out string Total)
        {

            //            string strSql = @"select t.c_name,t.c_tel,r.customer,g.summoney,t.id,t.is_invoice_change
            //	                            from crm_contact as t 
            //	                            inner join crm_customer as r on t.c_customerid =r.id {0}
            //	                            left join ( select oi.user_id,sum((ifnull(og.goods_number,0)-ifnull(og.invoice_number,0))*ifnull(og.goods_price,0)) as summoney from  xmh_shop.shop_order_goods as og 
            //	                            			inner join xmh_shop.shop_order_info as oi on og.order_id=oi.order_id and oi.need_inv=1 
            //                                            and (ifnull(og.goods_number,0)-ifnull(og.invoice_number,0))>0 
            //                                            and (oi.shipping_status=1 or (oi.is_invoice_advance=1 and oi.shipping_status in (5,7,8))) {1}
            //	                            						group by oi.user_id 
            //	                            ) as g on g.user_id=t.id 
            //                              where (t.isdelete is null or t.isdelete=0) {2}
            //                              order by {3} limit {4},{5}";

            //添加结存时间限制
            string strSql = @"select t.c_name,t.c_tel,r.customer,g.summoney,t.id,t.is_invoice_change,r.beseats_id 
	                            from crm_contact as t 
	                            inner join crm_customer as r on t.c_customerid =r.id {0}
	                            left join ( SELECT abc.user_id,(sum(abc.summoney)+sum(shipping_fee)) as summoney,abc.erp_time from 
                                    (select oi.user_id,sum((ifnull(og.goods_number,0)-ifnull(og.invoice_number,0))*ifnull(og.goods_price,0)) as summoney,oi.shipping_fee,oi.erp_time,'2016-12-01' date
                                    from  xmh_shop.shop_order_goods as og 
                                    inner join xmh_shop.shop_order_info as oi on og.order_id=oi.order_id and oi.need_inv=1 
                                    and (ifnull(og.goods_number,0)-ifnull(og.invoice_number,0))>0 
                                    and (oi.shipping_status=1 or (oi.is_invoice_advance=1 and oi.shipping_status in (5,7,8))) and oi.erp_time is not null and oi.order_status!=9 {1}
                                    GROUP BY oi.order_id ) abc
                                    where abc.erp_time>= UNIX_TIMESTAMP(abc.date)
                                    group by abc.user_id 
	                            ) as g on g.user_id=t.id 
                              where (t.isdelete is null or t.isdelete=0) {2}
                              order by {3} limit {4},{5}";
            //   left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid) ap on ap.c_userid=oi.user_id 
            //ifnull(ap.date,'1970-01-01')
            strSql = String.Format(strSql, strWhere, time, money, filedOrder, (PageIndex - 1) * PageSize, PageSize);

            string strSql1 = @"select  COUNT(1)
	                            from crm_contact as t 
	                            inner join crm_customer as r on t.c_customerid =r.id {0} 
                              where (t.isdelete is null or t.isdelete=0) ";
            strSql1 = String.Format(strSql1, strWhere);
            Total = DbHelperMySQL.Query(strSql1.ToString(), 0).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString(), 0);
        }

        /// <summary>
        /// 获取需要开发票的订单详情
        /// </summary>,(og.goods_number-ifnull(og.invoice_number,0)) wait_number
        /// <returns></returns>
        public DataSet GetOrderList(string strWhere, string filedOrder, string user_id)
        {
            string strSql = @"select * from (
                                select og.ordergood_id,oi.order_sn,oi.erp_time,og.goods_sn,og.goods_name,og.goods_number,ifnull(og.invoice_number,0) invoice_number,
                              	og.goods_price,g.goods_unit,og.is_invoice,(og.goods_price*og.goods_number) all_price,i.invoice_status,(ifnull(og.goods_number,0)-ifnull(og.invoice_number,0)) wait_number,
                                oi.add_time,oi.user_id,'2016-12-01' date
                              from xmh_shop.shop_order_goods as og 
                              inner join xmh_shop.shop_order_info as oi on oi.order_id=og.order_id and (ifnull(og.goods_number,0)-ifnull(og.invoice_number,0))>0 
                              	and oi.need_inv=1 and (oi.shipping_status=1 or (oi.is_invoice_advance=1 and oi.shipping_status in (5,7,8)))  and oi.erp_time is not null and oi.order_status!=9 and oi.user_id={0}
                              inner join xmh_shop.shop_goods as g on og.goods_id=g.goods_id
                              inner join crm_contact as t on t.id=oi.user_id
                              inner join crm_customer as r on t.C_customerid=r.id

                              LEFT JOIN xmh_shop.shop_invoices_among_goods AS ig ON og.ordergood_id = ig.rec_id
                              LEFT JOIN xmh_shop.shop_invoices AS i ON i.invoices_among_id = ig.target_id
                              where r.isDelete=0 and (t.isdelete is null or t.isdelete=0)) abc
                              where abc.erp_time>= UNIX_TIMESTAMP(abc.date) {1}
                              order by {2}";

            //ifnull(ap.date,'1970-01-01') date
            // left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period where c_userid={0}) ap on ap.c_userid=oi.user_id 
            strSql = String.Format(strSql, user_id, strWhere, filedOrder);
            return DbHelperMySQL.Query(strSql.ToString(), 0);
        }

        /// <summary>
        /// 获取退货的记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetReturnList(string strWhere, string filedOrder)
        {
            string strSql = @"SELECT
                            	(
                            		IFNULL(rg.allow_sale, 0) + IFNULL(rg.back_factory, 0) + IFNULL(rg.allow_nosale, 0)
                            	) inv_num,
                            	(
                            		IFNULL(rg.allow_sale, 0) + IFNULL(rg.back_factory, 0) + IFNULL(rg.allow_nosale, 0)
                            	) * rg.goods_price inv_price,
                            	rg.*,ro.return_sn return_sns,ro.add_date
                            FROM
                            	( select * from shop_return_order where is_delete=0 {0}) ro
                            INNER JOIN shop_return_goods rg ON ro.return_id = rg.return_id AND rg.is_tax=1 and rg.is_invoice in (0,1) and rg.goods_price >0 and rg.erp_code_as !='' and rg.erp_code_as  is not null 
                            order by {1}";

            strSql = String.Format(strSql, strWhere, filedOrder);
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }



        //获得客户的积分
        public string GetScoreAmoun(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(available_points ) as points  from shop_user_account   ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }


        /// <summary>
        /// 获得订单的商品信息
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select b.brand_name,g.ordergood_id,g.cart_id,g.order_id,g.order_sn,g.goods_id,g.goods_name,g.goods_sn,g.goods_number,g.market_price,g.goods_price,g.shipping_fee_price,g.user_id,g.admin_id,g.purchase_goods_status,g.is_submit_purchase,g.stock_warn,g.is_invoice,g.is_add_order,g.doc_id,g.wms_setbook_id,g.wms_position,g.wms_record,(g.goods_price*g.goods_number) as total ");
            strSql.Append(" FROM shop_order_goods g  left join shop_brand b on g.brand_id = b.brand_id ");
            strSql1.Append(" select count(g.ordergood_id) FROM shop_order_goods g  left join shop_brand b on g.brand_id = b.brand_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得客户往来明细
        /// </summary>
        public DataSet GetContactMX(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select * from shop_progress_payments ");
            strSql1.Append(" select count(1) from shop_progress_payments ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得客户往来明细
        /// </summary>
        public DataSet GetContactNum(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select sum(money) as money from shop_progress_payments ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得客户往来款明细
        /// </summary>
        public DataSet GetContactMXJson(int PageSize, int PageIndex, string strWhere, DataTable dt_data, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select distinct * from ( ");
            strSql1.Append(" select count(distinct order_sn) from ( ");

            if (dt_data != null && dt_data.Rows.Count > 0)
            {
                for (int i = 0; i < dt_data.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        strSql.Append(" select * from ( ");
                        strSql.Append(" select * from shop_progress_payments where user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and add_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' and status='1'");
                        strSql.Append(" ) as aa ");

                        strSql1.Append(" select * from ( ");
                        strSql1.Append(" select * from shop_progress_payments where user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and add_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' and status='1'");
                        strSql1.Append(" ) as aa  ");
                    }
                    else
                    {
                        strSql.Append(" union all select * from ( ");
                        strSql.Append(" select * from shop_progress_payments where user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and add_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' and status='1'");
                        strSql.Append(" ) as bb ");

                        strSql1.Append(" union all select * from ( ");
                        strSql1.Append(" select * from shop_progress_payments where user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and add_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' and status='1'");
                        strSql1.Append(" ) as bb ");
                    }
                }
            }

            strSql.Append(" ) as ab ");
            strSql1.Append(" ) as ab ");

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 获得客户往来详情
        /// </summary>
        public DataSet GetContactDetails(int PageSize, int PageIndex, string strWhere, string strWhereOne,string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            //strSql.Append(" select * from ( ");
            //strSql.Append(" select  from_unixtime(i.erp_time) as erp_time, 1 as type,g.order_sn,g.goods_sn,g.goods_name,g.goods_number,g.goods_price, (g.goods_price*g.goods_number) as total,'' as reduce  from  xmh_shop.shop_order_goods g ");
            //strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null where  " + strWhere + " ");
            //strSql.Append(" union all  ");
            //strSql.Append(" select jytime as erp_time,2 as type, id as order_sn,'','', '','', '',daifang as reduce from xmh_fms.fms_kuan where  " + strWhereOne + " ");
            //strSql.Append(" ) as aa  ");

            //strSql1.Append(" select count(1) from ( ");
            //strSql1.Append(" select  from_unixtime(i.erp_time) as erp_time, 1 as type,g.order_sn,g.goods_sn,g.goods_name,g.goods_number,g.goods_price, (g.goods_price*g.goods_number) as total, '' as reduce  from  xmh_shop.shop_order_goods g ");
            //strSql1.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null where  " + strWhere + "");
            //strSql1.Append(" union all  ");
            //strSql1.Append(" select jytime as erp_time,2 as type, id as order_sn,'','', '','', '',daifang as reduce from xmh_fms.fms_kuan where " + strWhereOne + " ");
            //strSql1.Append(" ) as aa  ");

            strSql.Append(" select distinct * from ( ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(og.goods_price,0)*og.goods_number as money,p.user_yingshou,og.goods_sn,og.goods_name,og.goods_number,ifnull(og.goods_price,0) as price from shop_progress_payments p  left join shop_order_goods og on p.order_sn =og.order_sn where p.type in (1,10) and p.status='1' and  " + strWhereOne + " ");
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, 6 as type,p.order_sn,p.add_time,p.user_id,ifnull(i.shipping_fee,0) as money,p.user_yingshou,'','', '','' from shop_progress_payments p left join shop_order_info i on p.order_sn =i.order_sn where p.type in (1,10) and p.status='1' and i.shipping_fee !=''   and " + strWhereOne + " ");        
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(p.money,0) as money,p.user_yingshou,'','','',k.daifang as price from shop_progress_payments p  left join xmh_fms.fms_kuan k on p.order_sn =k.dkmassage_id where p.type in(2,20) and p.status='1'  and " + strWhereOne + " ");
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,(ifnull(r.allow_sale,0) + ifnull(r.back_factory,0) + ifnull(r.allow_nosale,0)) * r.goods_price as money,p.user_yingshou,r.goods_sn,r.goods_name,(ifnull(r.allow_sale,0) + ifnull(r.back_factory,0) + ifnull(r.allow_nosale,0)) as goods_number,r.goods_price as price from shop_progress_payments p  left join shop_return_goods r on p.order_sn =r.return_sn where p.type in(3,30) and p.status='1'  and " + strWhereOne + " ");
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(p.money,0) as money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(4,40) and p.status='1'  and " + strWhereOne + " ");
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(p.money,0) as money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(5,50) and p.status='1'   and " + strWhereOne + "  ");
            strSql.Append(" ) as ab ");

            strSql1.Append(" select count(1) from ( ");
            strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,og.goods_sn,og.goods_name,og.goods_number,og.goods_price as price from shop_progress_payments p  left join shop_order_goods og on p.order_sn =og.order_sn where p.type in (1,10) and p.status='1' and " + strWhereOne + " ");
            strSql1.Append(" UNION all ");
            strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(i.shipping_fee,0) as money,p.user_yingshou,'','', '','' from shop_progress_payments p left join shop_order_info i on p.order_sn =i.order_sn where p.type in (1,10) and p.status='1' and i.shipping_fee !=''  and " + strWhereOne + " ");      
            strSql1.Append(" UNION all ");
            strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',k.daifang as price from shop_progress_payments p  left join xmh_fms.fms_kuan k on p.order_sn =k.dkmassage_id where p.type in(2,20) and p.status='1'  and " + strWhereOne + "  ");
            strSql1.Append(" UNION all ");
            strSql1.Append("  select p.id, p.type,p.order_sn,p.add_time,p.user_id,(ifnull(r.allow_sale,0) + ifnull(r.back_factory,0) + ifnull(r.allow_nosale,0)) * r.goods_price as money,p.user_yingshou,r.goods_sn,r.goods_name,(ifnull(r.allow_sale,0) + ifnull(r.back_factory,0) + ifnull(r.allow_nosale,0)) as goods_number,r.goods_price as price from shop_progress_payments p  left join shop_return_goods r on p.order_sn =r.return_sn where p.type in(3,30) and p.status='1'  and " + strWhereOne + " ");
            strSql1.Append(" UNION all ");
            strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(4,40) and p.status='1'  and " + strWhereOne + "  ");
            strSql1.Append(" UNION all ");
            strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(5,50) and p.status='1'  and " + strWhereOne + "  ");
            strSql1.Append(" ) as ab  ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得客户往来款详情
        /// </summary>
        public DataSet GetContactDetailsJson(int PageSize, int PageIndex, string strWhere, DataTable dt_data, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select distinct * from ( ");
            strSql1.Append(" select count(distinct id) from ( ");

            if (dt_data != null && dt_data.Rows.Count > 0)
            {
                for (int i = 0; i < dt_data.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        //strSql.Append(" select * from ( ");
                        //strSql.Append(" select  from_unixtime(i.erp_time) as erp_time, 1 as type,g.order_sn,g.goods_sn,g.goods_name,g.goods_number,g.goods_price, (g.goods_price*g.goods_number) as total,'' as reduce  from  xmh_shop.shop_order_goods g ");
                        //strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null where  i.user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' ");
                        //strSql.Append(" union all  ");
                        //strSql.Append(" select jytime as erp_time,2 as type, id as order_sn,'','', '','', '',daifang as reduce from xmh_fms.fms_kuan where user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and jytime>='" + dt_data.Rows[i]["datetime"].ToString() + "'");
                        //strSql.Append(" ) as aa ");

                        //strSql1.Append(" select * from ( ");
                        //strSql1.Append(" select  from_unixtime(i.erp_time) as erp_time, 1 as type,g.order_sn,g.goods_sn,g.goods_name,g.goods_number,g.goods_price, (g.goods_price*g.goods_number) as total, '' as reduce  from  xmh_shop.shop_order_goods g ");
                        //strSql1.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null where  i.user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' ");
                        //strSql1.Append(" union all  ");
                        //strSql1.Append(" select jytime as erp_time,2 as type, id as order_sn,'','', '','', '',daifang as reduce from xmh_fms.fms_kuan where user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and jytime>='" + dt_data.Rows[i]["datetime"].ToString() + "'");
                        //strSql1.Append(" ) as aa  ");

                        strSql.Append(" select distinct * from ( ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(og.goods_price,0)*og.goods_number as money,p.user_yingshou,og.goods_sn,og.goods_name,og.goods_number,ifnull(og.goods_price,0) as price from shop_progress_payments p  left join shop_order_goods og on p.order_sn =og.order_sn where p.type in (1,10) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',k.daifang as price from shop_progress_payments p  left join xmh_fms.fms_kuan k on p.order_sn =k.dkmassage_id where p.type in(2,20) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,r.goods_sn,r.goods_name,(r.allow_sale + r.back_factory + r.allow_nosale) as goods_number,r.goods_price as price from shop_progress_payments p  left join shop_return_goods r on p.order_sn =r.return_sn where p.type in(3,30) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(4,40) and p.status='1'  ");
                        strSql.Append(" ) as d  ");
                        strSql.Append(" where  d.user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and d.add_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' ");

                        strSql1.Append(" select distinct * from ( ");
                        strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,og.goods_sn,og.goods_name,og.goods_number,og.goods_price as price from shop_progress_payments p  left join shop_order_goods og on p.order_sn =og.order_sn where p.type in (1,10) and p.status='1' ");
                        strSql1.Append(" UNION all ");
                        strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',k.daifang as price from shop_progress_payments p  left join xmh_fms.fms_kuan k on p.order_sn =k.dkmassage_id where p.type in(2,20) and p.status='1' ");
                        strSql1.Append(" UNION all ");
                        strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,r.goods_sn,r.goods_name,(r.allow_sale + r.back_factory + r.allow_nosale) as goods_number,r.goods_price as price from shop_progress_payments p  left join shop_return_goods r on p.order_sn =r.return_sn where p.type in(3,30) and p.status='1' ");
                        strSql1.Append(" UNION all ");
                        strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(4,40) and p.status='1'  ");
                        strSql1.Append(" ) as d  ");
                        strSql1.Append(" where  d.user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and d.add_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' ");
                    }
                    else
                    {
                        strSql.Append(" UNION all ");
                        strSql.Append(" select distinct * from ( ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,og.goods_sn,og.goods_name,og.goods_number,og.goods_price as price from shop_progress_payments p  left join shop_order_goods og on p.order_sn =og.order_sn where p.type in (1,10) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',k.daifang as price from shop_progress_payments p  left join xmh_fms.fms_kuan k on p.order_sn =k.dkmassage_id where p.type in(2,20) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,r.goods_sn,r.goods_name,(r.allow_sale + r.back_factory + r.allow_nosale) as goods_number,r.goods_price as price from shop_progress_payments p  left join shop_return_goods r on p.order_sn =r.return_sn where p.type in(3,30) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(4,40) and p.status='1'  ");
                        strSql.Append(" ) as b  ");
                        strSql.Append(" where  b.user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and b.add_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' ");

                        strSql1.Append(" UNION all ");
                        strSql1.Append(" select distinct * from ( ");
                        strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,og.goods_sn,og.goods_name,og.goods_number,og.goods_price as price from shop_progress_payments p  left join shop_order_goods og on p.order_sn =og.order_sn where p.type in (1,10) and p.status='1' ");
                        strSql1.Append(" UNION all ");
                        strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',k.daifang as price from shop_progress_payments p  left join xmh_fms.fms_kuan k on p.order_sn =k.dkmassage_id where p.type in(2,20) and p.status='1' ");
                        strSql1.Append(" UNION all ");
                        strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,r.goods_sn,r.goods_name,(r.allow_sale + r.back_factory + r.allow_nosale) as goods_number,r.goods_price as price from shop_progress_payments p  left join shop_return_goods r on p.order_sn =r.return_sn where p.type in(3,30) and p.status='1' ");
                        strSql1.Append(" UNION all ");
                        strSql1.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(4,40) and p.status='1'  ");
                        strSql1.Append(" ) as b  ");
                        strSql1.Append(" where  b.user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and b.add_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' ");


                        //strSql.Append(" union all select * from ( ");
                        //strSql.Append(" select  from_unixtime(i.erp_time) as erp_time, 1 as type,g.order_sn,g.goods_sn,g.goods_name,g.goods_number,g.goods_price, (g.goods_price*g.goods_number) as total,'' as reduce  from  xmh_shop.shop_order_goods g ");
                        //strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null where  i.user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' ");
                        //strSql.Append(" union all  ");
                        //strSql.Append(" select jytime as erp_time,2 as type, id as order_sn,'','', '','', '',daifang as reduce from xmh_fms.fms_kuan where user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and jytime>='" + dt_data.Rows[i]["datetime"].ToString() + "'");
                        //strSql.Append(" ) as bb ");

                        //strSql1.Append(" union all select * from ( ");
                        //strSql1.Append(" select  from_unixtime(i.erp_time) as erp_time, 1 as type,g.order_sn,g.goods_sn,g.goods_name,g.goods_number,g.goods_price, (g.goods_price*g.goods_number) as total, '' as reduce  from  xmh_shop.shop_order_goods g ");
                        //strSql1.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null where  i.user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt_data.Rows[i]["datetime"].ToString() + "' ");
                        //strSql1.Append(" union all  ");
                        //strSql1.Append(" select jytime as erp_time,2 as type, id as order_sn,'','', '','', '',daifang as reduce from xmh_fms.fms_kuan where user_id ='" + dt_data.Rows[i]["userId"].ToString() + "' and jytime>='" + dt_data.Rows[i]["datetime"].ToString() + "'");
                        //strSql1.Append(" ) as bb ");
                    }
                }
            }

            strSql.Append(" ) as ab ");
            strSql1.Append(" ) as ab ");

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得客户的所有往来款
        /// </summary>
        public DataSet GetContactAll(string strWhere, string strWhereOne)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" select * from ( ");
            //strSql.Append(" select  from_unixtime( i.erp_time) as erp_time, 1 as type,g.order_sn,g.goods_sn,g.goods_name,g.goods_number,g.goods_price, (g.goods_price*g.goods_number) as total,'' as reduce  from  xmh_shop.shop_order_goods g ");
            //strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null where  " + strWhereOne + " ");
            //strSql.Append(" union all  ");
            //strSql.Append(" select jytime as erp_time,2 as type, id as order_sn,'','', '','', '',daifang as reduce from xmh_fms.fms_kuan where  " + strWhereTwo + " ");
            //strSql.Append(" ) as aa order by erp_time  ");

            strSql.Append(" select distinct * from ( ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(og.goods_price,0)*og.goods_number as money,p.user_yingshou,og.goods_sn,og.goods_name,og.goods_number,ifnull(og.goods_price,0) as price from shop_progress_payments p  left join shop_order_goods og on p.order_sn =og.order_sn where p.type in (1,10) and p.status='1' and  " + strWhereOne + " ");
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(i.shipping_fee,0) as money,p.user_yingshou,'','', '','' from shop_progress_payments p left join shop_order_info i on p.order_sn =i.order_sn where p.type in (1,10) and p.status='1'  and i.shipping_fee !=''   and " + strWhereOne + " ");        
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(p.money,0) as money,p.user_yingshou,'','','',k.daifang as price from shop_progress_payments p  left join xmh_fms.fms_kuan k on p.order_sn =k.dkmassage_id where p.type in(2,20) and p.status='1' and " + strWhereOne + " ");
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,(ifnull(r.allow_sale,0) + ifnull(r.back_factory,0) + ifnull(r.allow_nosale,0)) * r.goods_price as money,p.user_yingshou,r.goods_sn,r.goods_name,(ifnull(r.allow_sale,0) + ifnull(r.back_factory,0) + ifnull(r.allow_nosale,0)) as goods_number,r.goods_price as price from shop_progress_payments p  left join shop_return_goods r on p.order_sn =r.return_sn where p.type in(3,30) and p.status='1'  and " + strWhereOne + " ");
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(p.money,0) as money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(4,40) and p.status='1'  and " + strWhereOne + " ");
            strSql.Append(" UNION all ");
            strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(p.money,0) as money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(5,50) and p.status='1'   and " + strWhereOne + "  ");
            strSql.Append(" ) as ab ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append("  order by ab.add_time ");

            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得客户的所有往来款
        /// </summary>
        public DataSet GetContactAllJson(DataTable dt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select distinct * from ( ");

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        //strSql.Append(" select * from ( ");
                        //strSql.Append(" select  from_unixtime( i.erp_time) as erp_time, 1 as type,g.order_sn,g.goods_sn,g.goods_name,g.goods_number,g.goods_price, (g.goods_price*g.goods_number) as total,'' as reduce  from  xmh_shop.shop_order_goods g ");
                        //strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        //strSql.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        //strSql.Append(" union all  ");
                        //strSql.Append(" select jytime as erp_time,2 as type, id as order_sn,'','', '','', '',daifang as reduce from xmh_fms.fms_kuan ");
                        //strSql.Append(" where user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and jytime>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        //strSql.Append(" ) as aa   ");
                        strSql.Append(" select distinct * from ( ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(og.goods_price,0)*og.goods_number as money,p.user_yingshou,og.goods_sn,og.goods_name,og.goods_number,og.goods_price as price from shop_progress_payments p  left join shop_order_goods og on p.order_sn =og.order_sn where p.type in (1,10) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',k.daifang as price from shop_progress_payments p  left join xmh_fms.fms_kuan k on p.order_sn =k.dkmassage_id where p.type in(2,20) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,r.goods_sn,r.goods_name,(r.allow_sale + r.back_factory + r.allow_nosale) as goods_number,r.goods_price as price from shop_progress_payments p  left join shop_return_goods r on p.order_sn =r.return_sn where p.type in(3,30) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(4,40) and p.status='1'  ");
                        strSql.Append(" ) as d  ");
                        strSql.Append(" where  d.user_id ='" + dt.Rows[i]["userId"].ToString() + "' and d.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");

                    }
                    else
                    {
                        strSql.Append(" UNION all ");
                        strSql.Append(" select distinct * from ( ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,ifnull(og.goods_price,0)*og.goods_number as money,p.user_yingshou,og.goods_sn,og.goods_name,og.goods_number,og.goods_price as price from shop_progress_payments p  left join shop_order_goods og on p.order_sn =og.order_sn where p.type in (1,10) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',k.daifang as price from shop_progress_payments p  left join xmh_fms.fms_kuan k on p.order_sn =k.dkmassage_id where p.type in(2,20) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,r.goods_sn,r.goods_name,(r.allow_sale + r.back_factory + r.allow_nosale) as goods_number,r.goods_price as price from shop_progress_payments p  left join shop_return_goods r on p.order_sn =r.return_sn where p.type in(3,30) and p.status='1' ");
                        strSql.Append(" UNION all ");
                        strSql.Append(" select p.id, p.type,p.order_sn,p.add_time,p.user_id,p.money,p.user_yingshou,'','','',a.change_total as price from shop_progress_payments p  left join xmh_fms.fms_kuan_adjust a on p.order_sn =a.id where p.type in(4,40) and p.status='1'  ");
                        strSql.Append(" ) as b  ");
                        strSql.Append(" where  b.user_id ='" + dt.Rows[i]["userId"].ToString() + "' and b.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");

                        //strSql.Append(" union all select * from ( ");
                        //strSql.Append(" select  from_unixtime( i.erp_time) as erp_time, 1 as type,g.order_sn,g.goods_sn,g.goods_name,g.goods_number,g.goods_price, (g.goods_price*g.goods_number) as total,'' as reduce  from  xmh_shop.shop_order_goods g ");
                        //strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        //strSql.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        //strSql.Append(" union all  ");
                        //strSql.Append(" select jytime as erp_time,2 as type, id as order_sn,'','', '','', '',daifang as reduce from xmh_fms.fms_kuan ");
                        //strSql.Append(" where user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and jytime>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        //strSql.Append(" ) as aa ");
                    }
                }
            }

            strSql.Append(" ) as g order by add_time ");

            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得客户的发货明细
        /// </summary>
        public DataSet GetDeliveryDetail(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            //strSql.Append(" select g.*,(g.goods_price*g.goods_number) as total, i.erp_time,i.need_inv,i.user_id as cusId from  xmh_shop.shop_order_goods g inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
            //strSql1.Append(" select count(g.ordergood_id)  from shop_order_goods g inner join  shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");

            strSql.Append(" select p.id,p.type,p.order_sn,p.add_time,p.user_id,p.money,og.goods_sn,og.goods_name,og.goods_number,og.invoice_number,ifnull(og.goods_price,0) as goods_price, ");
            strSql.Append(" IFNULL(og.goods_number,0)*og.goods_price as total,i.erp_time,i.need_inv,og.is_invoice,(ifnull(og.goods_number,0)-ifnull(og.invoice_number,0) ) as unbill ");
            strSql.Append(" from shop_progress_payments p  ");
            strSql.Append(" LEFT JOIN  shop_order_goods og on p.order_sn =og.order_sn ");
            strSql.Append(" left join  shop_order_info i on og.order_id= i.order_id ");

            strSql1.Append(" select count(p.id) from shop_progress_payments p   ");
            strSql1.Append(" LEFT JOIN  shop_order_goods og on p.order_sn =og.order_sn ");
            strSql1.Append(" left join  shop_order_info i on og.order_id= i.order_id ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得客户的发货明细
        /// </summary>
        public DataSet GetDeliveryDetailJson(int PageSize, int PageIndex, DataTable dt, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select distinct * from ( ");
            strSql1.Append(" select count(distinct id) from ( ");

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        //    strSql.Append(" select g.*,(g.goods_price*g.goods_number) as total, i.erp_time,i.need_inv,i.user_id as cusId from  xmh_shop.shop_order_goods g ");
                        //    strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        //    strSql.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        //    strSql1.Append(" select g.*  from xmh_shop.shop_order_goods g inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        //    strSql1.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");

                        strSql.Append(" select p.id,p.type,p.order_sn,p.add_time,p.user_id,p.money,og.goods_sn,og.goods_name,og.goods_number,og.invoice_number,ifnull(og.goods_price,0) as goods_price, ");
                        strSql.Append(" IFNULL(og.goods_number,0)*og.goods_price as total,i.erp_time,i.need_inv,og.is_invoice,(ifnull(og.goods_number,0)-ifnull(og.invoice_number,0) ) as unbill ");
                        strSql.Append(" from shop_progress_payments p  ");
                        strSql.Append(" inner JOIN  shop_order_goods og on p.order_sn =og.order_sn ");
                        strSql.Append(" inner join  shop_order_info i on og.order_id= i.order_id ");
                        strSql.Append(" where p.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and p.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");

                        strSql1.Append(" select p.id,p.type,p.order_sn,p.add_time,p.user_id,p.money,og.goods_sn,og.goods_name,og.goods_number,og.invoice_number,og.goods_price, ");
                        strSql1.Append(" IFNULL(og.goods_number,0)*og.goods_price as total,i.erp_time,i.need_inv,og.is_invoice,(ifnull(og.goods_number,0)-ifnull(og.invoice_number,0) ) as unbill ");
                        strSql1.Append(" from shop_progress_payments p  ");
                        strSql1.Append(" inner JOIN  shop_order_goods og on p.order_sn =og.order_sn ");
                        strSql1.Append(" inner join  shop_order_info i on og.order_id= i.order_id ");
                        strSql1.Append(" where p.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and p.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                    }
                    else
                    {

                        strSql.Append(" union all  select p.id,p.type,p.order_sn,p.add_time,p.user_id,p.money,og.goods_sn,og.goods_name,og.goods_number,og.invoice_number,ifnull(og.goods_price,0) as goods_price, ");
                        strSql.Append(" IFNULL(og.goods_number,0)*og.goods_price as total,i.erp_time,i.need_inv,og.is_invoice,(ifnull(og.goods_number,0)-ifnull(og.invoice_number,0) ) as unbill ");
                        strSql.Append(" from shop_progress_payments p  ");
                        strSql.Append(" inner JOIN  shop_order_goods og on p.order_sn =og.order_sn ");
                        strSql.Append(" inner join  shop_order_info i on og.order_id= i.order_id ");
                        strSql.Append(" where p.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and p.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");

                        strSql1.Append(" union all  select p.id,p.type,p.order_sn,p.add_time,p.user_id,p.money,og.goods_sn,og.goods_name,og.goods_number,og.invoice_number,og.goods_price, ");
                        strSql1.Append(" IFNULL(og.goods_number,0)*og.goods_price as total,i.erp_time,i.need_inv,og.is_invoice,(ifnull(og.goods_number,0)-ifnull(og.invoice_number,0) ) as unbill ");
                        strSql1.Append(" from shop_progress_payments p  ");
                        strSql1.Append(" inner JOIN  shop_order_goods og on p.order_sn =og.order_sn ");
                        strSql1.Append(" inner join  shop_order_info i on og.order_id= i.order_id ");
                        strSql1.Append(" where p.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and p.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");

                        //strSql.Append(" union all  select g.*,(g.goods_price*g.goods_number) as total, i.erp_time,i.need_inv,i.user_id as cusId from  xmh_shop.shop_order_goods g ");
                        //strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        //strSql.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        //strSql1.Append(" union all select g.* from xmh_shop.shop_order_goods g inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        //strSql1.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.erp_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                    }
                }
            }

            strSql.Append(" ) as p");
            strSql1.Append(" ) as p ");

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得客户的未开票明细
        /// </summary>
        public DataSet GetUnBillDetail(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select g.*,(g.goods_number-g.invoice_number) as unBill, (g.goods_price*g.goods_number) as total, i.erp_time,i.need_inv,i.user_id as cusId from  xmh_shop.shop_order_goods g inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and (i.order_status !=9 or i.order_status !=2 ) and i.erp_time is not null ");
            strSql.Append(" where  i.need_inv='1' ");
            strSql1.Append(" select count(g.ordergood_id)  from shop_order_goods g inner join  shop_order_info i on g.order_id= i.order_id and (i.order_status !=9 or i.order_status !=2 ) and i.erp_time is not null "); //and i.order_status !=9 and i.erp_time is not null
            strSql1.Append(" where  i.need_inv='1' ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
                strSql1.Append(" and " + strWhere);
            }


            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得客户的未开票明细
        /// </summary>
        public DataSet GetUnBillJson(int PageSize, int PageIndex, DataTable dt, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select distinct * from ( ");
            strSql1.Append(" select count(distinct id) from ( ");

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        strSql.Append(" select g.*,(g.goods_price*g.goods_number) as total, i.erp_time,i.need_inv,i.user_id as cusId from  xmh_shop.shop_order_goods g ");
                        strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        strSql.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' and  i.need_inv='1' ");

                        strSql1.Append(" select g.*  from xmh_shop.shop_order_goods g inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        strSql1.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' and  i.need_inv='1' ");
                    }
                    else
                    {
                        strSql.Append(" union all  select g.*,(g.goods_price*g.goods_number) as total, i.erp_time,i.need_inv,i.user_id as cusId from  xmh_shop.shop_order_goods g ");
                        strSql.Append(" inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        strSql.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' and  i.need_inv='1' ");

                        strSql1.Append(" union all select g.* from xmh_shop.shop_order_goods g inner join  xmh_shop.shop_order_info i on g.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null ");
                        strSql1.Append(" where i.user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and i.add_time>='" + dt.Rows[i]["datetime"].ToString() + "' and  i.need_inv='1' ");
                    }
                }
            }

            strSql.Append(" ) as p");
            strSql1.Append(" ) as p ");

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

