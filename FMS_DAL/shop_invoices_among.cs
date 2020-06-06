﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;//Please add references

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:shop_invoices_among
    /// </summary>
    public partial class shop_invoices_among
    {
        public shop_invoices_among()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("invoice_id", "shop_invoices_among");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int invoice_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_invoices_among");
            strSql.Append(" where invoice_id=@invoice_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@invoice_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = invoice_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FMS_Model.shop_invoices_among model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_invoices_among(");
            strSql.Append("invoice_id,invoice_sn,invoice2_id,invoice_type,tax_rate,currency,exchange_rate,down_count,admin_id,user_id,address,bank_number,bank,shuihao,company_name,tel,total_count,total_money,note,invoices_note,pay_note,add_time,update_time,invoice_status,pre_status,invoice_time,erp_order_sn,invoice_num,invoice_date,refund_money,refund_djhm_str,sold_total_money,shipping_num,shipping_time,shipping_type,shipping_id,print_num,invoice_sn_temp,invoice_num_temp,last_update_admin,init_refund_money,print_hide)");
            strSql.Append(" values (");
            strSql.Append("@invoice_id,@invoice_sn,@invoice2_id,@invoice_type,@tax_rate,@currency,@exchange_rate,@down_count,@admin_id,@user_id,@address,@bank_number,@bank,@shuihao,@company_name,@tel,@total_count,@total_money,@note,@invoices_note,@pay_note,@add_time,@update_time,@invoice_status,@pre_status,@invoice_time,@erp_order_sn,@invoice_num,@invoice_date,@refund_money,@refund_djhm_str,@sold_total_money,@shipping_num,@shipping_time,@shipping_type,@shipping_id,@print_num,@invoice_sn_temp,@invoice_num_temp,@last_update_admin,@init_refund_money,@print_hide)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@invoice_id", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@invoice2_id", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_type", MySqlDbType.Int16,2),
					new MySqlParameter("@tax_rate", MySqlDbType.Int16,2),
					new MySqlParameter("@currency", MySqlDbType.VarChar,50),
					new MySqlParameter("@exchange_rate", MySqlDbType.Decimal,10),
					new MySqlParameter("@down_count", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@bank_number", MySqlDbType.VarChar,30),
					new MySqlParameter("@bank", MySqlDbType.VarChar,100),
					new MySqlParameter("@shuihao", MySqlDbType.VarChar,50),
					new MySqlParameter("@company_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@total_count", MySqlDbType.Int32,11),
					new MySqlParameter("@total_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@note", MySqlDbType.Text),
					new MySqlParameter("@invoices_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@pay_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@update_time", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_status", MySqlDbType.Int16,3),
					new MySqlParameter("@pre_status", MySqlDbType.Int16,3),
					new MySqlParameter("@invoice_time", MySqlDbType.Int32,11),
					new MySqlParameter("@erp_order_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@invoice_num", MySqlDbType.VarChar,32),
					new MySqlParameter("@invoice_date", MySqlDbType.VarChar,32),
					new MySqlParameter("@refund_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@refund_djhm_str", MySqlDbType.Text),
					new MySqlParameter("@sold_total_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_num", MySqlDbType.VarChar,32),
					new MySqlParameter("@shipping_time", MySqlDbType.Int32,11),
					new MySqlParameter("@shipping_type", MySqlDbType.Int16,2),
					new MySqlParameter("@shipping_id", MySqlDbType.Int16,3),
					new MySqlParameter("@print_num", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_sn_temp", MySqlDbType.VarChar,32),
					new MySqlParameter("@invoice_num_temp", MySqlDbType.Int32,11),
					new MySqlParameter("@last_update_admin", MySqlDbType.VarChar,255),
					new MySqlParameter("@init_refund_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@print_hide", MySqlDbType.Int16,1)};
            parameters[0].Value = model.invoice_id;
            parameters[1].Value = model.invoice_sn;
            parameters[2].Value = model.invoice2_id;
            parameters[3].Value = model.invoice_type;
            parameters[4].Value = model.tax_rate;
            parameters[5].Value = model.currency;
            parameters[6].Value = model.exchange_rate;
            parameters[7].Value = model.down_count;
            parameters[8].Value = model.admin_id;
            parameters[9].Value = model.user_id;
            parameters[10].Value = model.address;
            parameters[11].Value = model.bank_number;
            parameters[12].Value = model.bank;
            parameters[13].Value = model.shuihao;
            parameters[14].Value = model.company_name;
            parameters[15].Value = model.tel;
            parameters[16].Value = model.total_count;
            parameters[17].Value = model.total_money;
            parameters[18].Value = model.note;
            parameters[19].Value = model.invoices_note;
            parameters[20].Value = model.pay_note;
            parameters[21].Value = model.add_time;
            parameters[22].Value = model.update_time;
            parameters[23].Value = model.invoice_status;
            parameters[24].Value = model.pre_status;
            parameters[25].Value = model.invoice_time;
            parameters[26].Value = model.erp_order_sn;
            parameters[27].Value = model.invoice_num;
            parameters[28].Value = model.invoice_date;
            parameters[29].Value = model.refund_money;
            parameters[30].Value = model.refund_djhm_str;
            parameters[31].Value = model.sold_total_money;
            parameters[32].Value = model.shipping_num;
            parameters[33].Value = model.shipping_time;
            parameters[34].Value = model.shipping_type;
            parameters[35].Value = model.shipping_id;
            parameters[36].Value = model.print_num;
            parameters[37].Value = model.invoice_sn_temp;
            parameters[38].Value = model.invoice_num_temp;
            parameters[39].Value = model.last_update_admin;
            parameters[40].Value = model.init_refund_money;
            parameters[41].Value = model.print_hide;

            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.shop_invoices_among model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_invoices_among set ");
            strSql.Append("invoice_sn=@invoice_sn,");
            strSql.Append("invoice2_id=@invoice2_id,");
            strSql.Append("invoice_type=@invoice_type,");
            strSql.Append("tax_rate=@tax_rate,");
            strSql.Append("currency=@currency,");
            strSql.Append("exchange_rate=@exchange_rate,");
            strSql.Append("down_count=@down_count,");
            strSql.Append("admin_id=@admin_id,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("address=@address,");
            strSql.Append("bank_number=@bank_number,");
            strSql.Append("bank=@bank,");
            strSql.Append("shuihao=@shuihao,");
            strSql.Append("company_name=@company_name,");
            strSql.Append("tel=@tel,");
            strSql.Append("total_count=@total_count,");
            strSql.Append("total_money=@total_money,");
            strSql.Append("note=@note,");
            strSql.Append("invoices_note=@invoices_note,");
            strSql.Append("pay_note=@pay_note,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("update_time=@update_time,");
            strSql.Append("invoice_status=@invoice_status,");
            strSql.Append("pre_status=@pre_status,");
            strSql.Append("invoice_time=@invoice_time,");
            strSql.Append("erp_order_sn=@erp_order_sn,");
            strSql.Append("invoice_num=@invoice_num,");
            strSql.Append("invoice_date=@invoice_date,");
            strSql.Append("refund_money=@refund_money,");
            strSql.Append("refund_djhm_str=@refund_djhm_str,");
            strSql.Append("sold_total_money=@sold_total_money,");
            strSql.Append("shipping_num=@shipping_num,");
            strSql.Append("shipping_time=@shipping_time,");
            strSql.Append("shipping_type=@shipping_type,");
            strSql.Append("shipping_id=@shipping_id,");
            strSql.Append("print_num=@print_num,");
            strSql.Append("invoice_sn_temp=@invoice_sn_temp,");
            strSql.Append("invoice_num_temp=@invoice_num_temp,");
            strSql.Append("last_update_admin=@last_update_admin,");
            strSql.Append("init_refund_money=@init_refund_money,");
            strSql.Append("print_hide=@print_hide");
            strSql.Append(" where invoice_id=@invoice_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@invoice_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@invoice2_id", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_type", MySqlDbType.Int16,2),
					new MySqlParameter("@tax_rate", MySqlDbType.Int16,2),
					new MySqlParameter("@currency", MySqlDbType.VarChar,50),
					new MySqlParameter("@exchange_rate", MySqlDbType.Decimal,10),
					new MySqlParameter("@down_count", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@bank_number", MySqlDbType.VarChar,30),
					new MySqlParameter("@bank", MySqlDbType.VarChar,100),
					new MySqlParameter("@shuihao", MySqlDbType.VarChar,50),
					new MySqlParameter("@company_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@total_count", MySqlDbType.Int32,11),
					new MySqlParameter("@total_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@note", MySqlDbType.Text),
					new MySqlParameter("@invoices_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@pay_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@update_time", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_status", MySqlDbType.Int16,3),
					new MySqlParameter("@pre_status", MySqlDbType.Int16,3),
					new MySqlParameter("@invoice_time", MySqlDbType.Int32,11),
					new MySqlParameter("@erp_order_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@invoice_num", MySqlDbType.VarChar,32),
					new MySqlParameter("@invoice_date", MySqlDbType.VarChar,32),
					new MySqlParameter("@refund_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@refund_djhm_str", MySqlDbType.Text),
					new MySqlParameter("@sold_total_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_num", MySqlDbType.VarChar,32),
					new MySqlParameter("@shipping_time", MySqlDbType.Int32,11),
					new MySqlParameter("@shipping_type", MySqlDbType.Int16,2),
					new MySqlParameter("@shipping_id", MySqlDbType.Int16,3),
					new MySqlParameter("@print_num", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_sn_temp", MySqlDbType.VarChar,32),
					new MySqlParameter("@invoice_num_temp", MySqlDbType.Int32,11),
					new MySqlParameter("@last_update_admin", MySqlDbType.VarChar,255),
					new MySqlParameter("@init_refund_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@print_hide", MySqlDbType.Int16,1),
					new MySqlParameter("@invoice_id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.invoice_sn;
            parameters[1].Value = model.invoice2_id;
            parameters[2].Value = model.invoice_type;
            parameters[3].Value = model.tax_rate;
            parameters[4].Value = model.currency;
            parameters[5].Value = model.exchange_rate;
            parameters[6].Value = model.down_count;
            parameters[7].Value = model.admin_id;
            parameters[8].Value = model.user_id;
            parameters[9].Value = model.address;
            parameters[10].Value = model.bank_number;
            parameters[11].Value = model.bank;
            parameters[12].Value = model.shuihao;
            parameters[13].Value = model.company_name;
            parameters[14].Value = model.tel;
            parameters[15].Value = model.total_count;
            parameters[16].Value = model.total_money;
            parameters[17].Value = model.note;
            parameters[18].Value = model.invoices_note;
            parameters[19].Value = model.pay_note;
            parameters[20].Value = model.add_time;
            parameters[21].Value = model.update_time;
            parameters[22].Value = model.invoice_status;
            parameters[23].Value = model.pre_status;
            parameters[24].Value = model.invoice_time;
            parameters[25].Value = model.erp_order_sn;
            parameters[26].Value = model.invoice_num;
            parameters[27].Value = model.invoice_date;
            parameters[28].Value = model.refund_money;
            parameters[29].Value = model.refund_djhm_str;
            parameters[30].Value = model.sold_total_money;
            parameters[31].Value = model.shipping_num;
            parameters[32].Value = model.shipping_time;
            parameters[33].Value = model.shipping_type;
            parameters[34].Value = model.shipping_id;
            parameters[35].Value = model.print_num;
            parameters[36].Value = model.invoice_sn_temp;
            parameters[37].Value = model.invoice_num_temp;
            parameters[38].Value = model.last_update_admin;
            parameters[39].Value = model.init_refund_money;
            parameters[40].Value = model.print_hide;
            parameters[41].Value = model.invoice_id;

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
        public bool Updates(FMS_Model.shop_invoices_among model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_invoices_among set ");
            strSql.Append("invoice_type=@invoice_type,");
            strSql.Append("address=@address,");
            strSql.Append("bank_number=@bank_number,");
            strSql.Append("bank=@bank,");
            strSql.Append("shuihao=@shuihao,");
            strSql.Append("company_name=@company_name,");
            strSql.Append("tax_rate=@tax_rate,");
            strSql.Append("pay_note=@pay_note,");
            strSql.Append("update_time=@update_time,");
            strSql.Append("invoice_status=@invoice_status,");
            strSql.Append("shipping_type=@shipping_type,");
            strSql.Append("shipping_id=@shipping_id,");
            strSql.Append("note=@note");
            strSql.Append(" where invoice_id=@invoice_id ");

            MySqlParameter[] parameters = {
					new MySqlParameter("@invoice_type", MySqlDbType.Int16,2),
                    new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@bank_number", MySqlDbType.VarChar,30),
					new MySqlParameter("@bank", MySqlDbType.VarChar,100),
					new MySqlParameter("@shuihao", MySqlDbType.VarChar,50),
					new MySqlParameter("@company_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@tax_rate", MySqlDbType.Int16,2),					
					new MySqlParameter("@pay_note", MySqlDbType.VarChar,255),					
					new MySqlParameter("@update_time", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_status", MySqlDbType.Int16,3),					
					new MySqlParameter("@shipping_type", MySqlDbType.Int16,2),
					new MySqlParameter("@shipping_id", MySqlDbType.Int16,3),	
				    new MySqlParameter("@note", MySqlDbType.Text),
					new MySqlParameter("@invoice_id", MySqlDbType.Int32,11)};

            parameters[0].Value = model.invoice_type;
            parameters[1].Value = model.address;
            parameters[2].Value = model.bank_number;
            parameters[3].Value = model.bank;
            parameters[4].Value = model.shuihao;
            parameters[5].Value = model.company_name;
            parameters[6].Value = model.tax_rate;
            parameters[7].Value = model.pay_note;
            parameters[8].Value = model.update_time;
            parameters[9].Value = model.invoice_status;
            parameters[10].Value = model.shipping_type;
            parameters[11].Value = model.shipping_id;
            parameters[12].Value = model.note;
            parameters[13].Value = model.invoice_id;

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
        public bool UpdateInfo(FMS_Model.shop_invoices_among model)
        {
           // string strSql = " update shop_invoices_among set invoice_type='" + model.invoice_type + "',address='" + model.address + "',bank_number='" + model.bank_number + "' where invoice_id='" + model.invoice_id + "'";


            string strSql = string.Format(@" update shop_invoices_among set invoice_type='{0}',address='{1}',bank_number='{2}',bank='{3}',shuihao='{4}',company_name='{5}',tax_rate='{6}', 
                                             pay_note='{7}',update_time='{8}',invoice_status='{9}',shipping_type='{10}',shipping_id='{11}',note='{12}' ,total_count='{13}',sold_total_money='{14}',
                                             is_tax_for_billing='{15}'  where invoice_id='{16}' ",

                                           model.invoice_type, model.address, model.bank_number, model.bank, model.shuihao, model.company_name, model.tax_rate, model.pay_note,
                                           model.update_time, model.invoice_status, model.shipping_type, model.shipping_id, model.note, model.total_count, model.sold_total_money,
                                           model.is_tax_for_billing,model.invoice_id);
            
            
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
        /// 更新总数量及总价
        /// </summary>
        public bool updateNumMoney(FMS_Model.shop_invoices_among model)
        {
            string strSql = " update shop_invoices_among set total_count='" + model.total_count + "',total_money='" + model.total_money + "' where invoice_id='" + model.invoice_id + "'";
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
        /// 更新开票信息中的退货商品信息
        /// </summary>
        public bool updateReturn(FMS_Model.shop_invoices_among model)
        {
            string strSql = " update shop_invoices_among set refund_djhm_str='" + model.refund_djhm_str + "',refund_money='" + model.refund_money + "',init_refund_money='" + model.init_refund_money + "' where invoice_id='" + model.invoice_id + "'";
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
        /// 更新发票状态
        /// </summary>
        public bool updateStatus(string invoice_id)
        {
            string strSql = " update shop_invoices_among set invoice_status='0',address=null,bank_number=null,bank=null,shuihao=null,company_name=null where invoice_id in (" + invoice_id + ") ";
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
        /// 更新运费
        /// </summary>
        public bool updateS(string invoice_id)
        {
            string strSql = string.Format(@" update shop_order_info set deduction_shipping_fee='{0}' where order_id  in ({1})  ", 0, invoice_id);

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
        /// 抵扣退货更新
        /// </summary>
        public bool updateBill(FMS_Model.shop_invoices_among model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_invoices_among set ");
            strSql.Append("total_count=@total_count,");
            strSql.Append("total_money=@total_money,");
            strSql.Append("refund_money=@refund_money ");
            strSql.Append(" where invoice_id=@invoice_id ");

            MySqlParameter[] parameters = {
					new MySqlParameter("@total_count", MySqlDbType.Int32,11),
					new MySqlParameter("@total_money", MySqlDbType.Decimal,10),				
					new MySqlParameter("@refund_money", MySqlDbType.Decimal,10),									
					new MySqlParameter("@invoice_id", MySqlDbType.Int32,11)};

            parameters[0].Value = model.total_count;
            parameters[1].Value = model.total_money;
            parameters[2].Value = model.refund_money;
            parameters[3].Value = model.invoice_id;

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
        public bool Delete(int invoice_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_invoices_among ");
            strSql.Append(" where invoice_id=@invoice_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@invoice_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = invoice_id;

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
        public bool DeleteBill(int invoice_id)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;
            shop_invoices_among_goods _ingoods = new shop_invoices_among_goods();   //发票明细表
            shop_order_info _order = new shop_order_info();                         //订单主表

            //发票中间主表信息
            DataSet ds = GetList(" invoice_id=" + invoice_id);

            //发票中间副表中的信息
            DataSet de = _ingoods.GetListOrder(" i.target_id='" + invoice_id + "'");

            //运费
            DataSet dF = _ingoods.GetInfo(" i.target_id='" + invoice_id + "' and i.type='1'");

            string orderId = string.Empty;
            if (dF != null && dF.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dF.Tables[0].Rows.Count; i++)
                {
                    if (i == dF.Tables[0].Rows.Count - 1)
                        orderId += "'" + dF.Tables[0].Rows[i]["order_id"].ToString() + "'";
                    else
                        orderId += "'" + dF.Tables[0].Rows[i]["order_id"].ToString() + "',";
                }
            }

            string[] oldIdList = orderId.Split(',');
            string newList = string.Empty;

            List<string> list = new List<string>();

            //去重
            foreach (var items in oldIdList)
            {
                if (!list.Contains(items))
                {
                    list.Add(items);
                    newList += items + ',';
                }
            }

            if (!string.IsNullOrEmpty(newList))
            {
                newList = newList.TrimEnd(',');
            }

            DataSet dsOrder=null;
            if(!string.IsNullOrEmpty(newList))
            {
                dsOrder = _order.orderCount(newList);
            }

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string refund_djhm_str = ds.Tables[0].Rows[0]["refund_djhm_str"].ToString();

                //1.删除发票主表信息
                strSql = string.Format(@"delete from shop_invoices_among where invoice_id='{0}'", invoice_id);
                strSqlList.Add(strSql);

                //2.删除发票详情表信息
                strSql = string.Format(@"delete from shop_invoices_among_goods where target_id='{0}'", invoice_id);
                strSqlList.Add(strSql);

                //3.更新订单详情表中商品已开票数量
                if (de != null && de.Tables[0].Rows.Count > 0)
                {
                    int num = 0;
                    int rec_d = 0;
                    for (int i = 0; i < de.Tables[0].Rows.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(de.Tables[0].Rows[i]["invoice_number"].ToString()))
                        {

                            if (Convert.ToInt32(de.Tables[0].Rows[i]["invoice_number"].ToString()) - Convert.ToInt32(de.Tables[0].Rows[i]["goods_old_num"].ToString()) > 0)
                                num = num - (Convert.ToInt32(de.Tables[0].Rows[i]["invoice_number"].ToString()) - Convert.ToInt32(de.Tables[0].Rows[i]["goods_old_num"].ToString()));

                            rec_d = Convert.ToInt32(de.Tables[0].Rows[i]["rec_id"].ToString());
                        }

                        if (num < 0)
                            num = 0;
                        strSql = string.Format(" update shop_order_goods set invoice_number='{0}' where ordergood_id='{1}'", num, rec_d);
                        strSqlList.Add(strSql);
                    }
                }

                //4.更新抵扣退货的状态
                if (!string.IsNullOrEmpty(refund_djhm_str) && refund_djhm_str != "")
                {
                    strSql = string.Format(@" update shop_return_goods set is_invoice='{0}' where sid  in ({1})  ", 0, refund_djhm_str);
                    strSqlList.Add(strSql);
                }

                //5.更新运费
                if (dsOrder != null && dsOrder.Tables[0].Rows.Count > 0)
                {
                    strSql = string.Format(@" update shop_order_info set deduction_shipping_fee='{0}' where order_id  in ({1})  ", 0, newList);
                    strSqlList.Add(strSql);
                }

            }


            int rows = Shop_DbHelperMySQL.ExecuteSqlTran(strSqlList);
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
        public bool DeleteList(string invoice_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_invoices_among ");
            strSql.Append(" where invoice_id in (" + invoice_idlist + ")  ");
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
        public FMS_Model.shop_invoices_among GetModel(int invoice_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select invoice_id,invoice_sn,invoice2_id,invoice_type,tax_rate,currency,exchange_rate,down_count,admin_id,user_id,address,bank_number,bank,shuihao,company_name,tel,total_count,total_money,note,invoices_note,pay_note,add_time,update_time,invoice_status,pre_status,invoice_time,erp_order_sn,invoice_num,invoice_date,refund_money,refund_djhm_str,sold_total_money,shipping_num,shipping_time,shipping_type,shipping_id,print_num,invoice_sn_temp,invoice_num_temp,last_update_admin,init_refund_money,print_hide,is_tax_for_billing from shop_invoices_among ");
            strSql.Append(" where invoice_id=@invoice_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@invoice_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = invoice_id;

            FMS_Model.shop_invoices_among model = new FMS_Model.shop_invoices_among();
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
        public FMS_Model.shop_invoices_among DataRowToModel(DataRow row)
        {
            FMS_Model.shop_invoices_among model = new FMS_Model.shop_invoices_among();
            if (row != null)
            {
                if (row["invoice_id"] != null && row["invoice_id"].ToString() != "")
                {
                    model.invoice_id = int.Parse(row["invoice_id"].ToString());
                }
                if (row["invoice_sn"] != null)
                {
                    model.invoice_sn = row["invoice_sn"].ToString();
                }
                if (row["invoice2_id"] != null && row["invoice2_id"].ToString() != "")
                {
                    model.invoice2_id = int.Parse(row["invoice2_id"].ToString());
                }
                if (row["invoice_type"] != null && row["invoice_type"].ToString() != "")
                {
                    model.invoice_type = int.Parse(row["invoice_type"].ToString());
                }
                if (row["tax_rate"] != null && row["tax_rate"].ToString() != "")
                {
                    model.tax_rate = int.Parse(row["tax_rate"].ToString());
                }
                if (row["currency"] != null)
                {
                    model.currency = row["currency"].ToString();
                }
                if (row["exchange_rate"] != null && row["exchange_rate"].ToString() != "")
                {
                    model.exchange_rate = decimal.Parse(row["exchange_rate"].ToString());
                }
                if (row["down_count"] != null && row["down_count"].ToString() != "")
                {
                    model.down_count = int.Parse(row["down_count"].ToString());
                }
                if (row["admin_id"] != null && row["admin_id"].ToString() != "")
                {
                    model.admin_id = int.Parse(row["admin_id"].ToString());
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["address"] != null)
                {
                    model.address = row["address"].ToString();
                }
                if (row["bank_number"] != null)
                {
                    model.bank_number = row["bank_number"].ToString();
                }
                if (row["bank"] != null)
                {
                    model.bank = row["bank"].ToString();
                }
                if (row["shuihao"] != null)
                {
                    model.shuihao = row["shuihao"].ToString();
                }
                if (row["company_name"] != null)
                {
                    model.company_name = row["company_name"].ToString();
                }
                if (row["tel"] != null)
                {
                    model.tel = row["tel"].ToString();
                }
                if (row["total_count"] != null && row["total_count"].ToString() != "")
                {
                    model.total_count = int.Parse(row["total_count"].ToString());
                }
                if (row["total_money"] != null && row["total_money"].ToString() != "")
                {
                    model.total_money = decimal.Parse(row["total_money"].ToString());
                }
                if (row["note"] != null)
                {
                    model.note = row["note"].ToString();
                }
                if (row["invoices_note"] != null)
                {
                    model.invoices_note = row["invoices_note"].ToString();
                }
                if (row["pay_note"] != null)
                {
                    model.pay_note = row["pay_note"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = int.Parse(row["add_time"].ToString());
                }
                if (row["update_time"] != null && row["update_time"].ToString() != "")
                {
                    model.update_time = int.Parse(row["update_time"].ToString());
                }
                if (row["invoice_status"] != null && row["invoice_status"].ToString() != "")
                {
                    model.invoice_status = int.Parse(row["invoice_status"].ToString());
                }
                if (row["pre_status"] != null && row["pre_status"].ToString() != "")
                {
                    model.pre_status = int.Parse(row["pre_status"].ToString());
                }
                if (row["invoice_time"] != null && row["invoice_time"].ToString() != "")
                {
                    model.invoice_time = int.Parse(row["invoice_time"].ToString());
                }
                if (row["erp_order_sn"] != null)
                {
                    model.erp_order_sn = row["erp_order_sn"].ToString();
                }
                if (row["invoice_num"] != null)
                {
                    model.invoice_num = row["invoice_num"].ToString();
                }
                if (row["invoice_date"] != null)
                {
                    model.invoice_date = row["invoice_date"].ToString();
                }
                if (row["refund_money"] != null && row["refund_money"].ToString() != "")
                {
                    model.refund_money = decimal.Parse(row["refund_money"].ToString());
                }
                if (row["refund_djhm_str"] != null)
                {
                    model.refund_djhm_str = row["refund_djhm_str"].ToString();
                }
                if (row["sold_total_money"] != null && row["sold_total_money"].ToString() != "")
                {
                    model.sold_total_money = decimal.Parse(row["sold_total_money"].ToString());
                }
                if (row["shipping_num"] != null)
                {
                    model.shipping_num = row["shipping_num"].ToString();
                }
                if (row["shipping_time"] != null && row["shipping_time"].ToString() != "")
                {
                    model.shipping_time = int.Parse(row["shipping_time"].ToString());
                }
                if (row["shipping_type"] != null && row["shipping_type"].ToString() != "")
                {
                    model.shipping_type = int.Parse(row["shipping_type"].ToString());
                }
                //model.shipping_id=row["shipping_id"].ToString();
                if (row["shipping_id"] != null && row["shipping_id"].ToString() != "")
                {
                    model.shipping_id = int.Parse(row["shipping_id"].ToString());
                }
                if (row["print_num"] != null && row["print_num"].ToString() != "")
                {
                    model.print_num = int.Parse(row["print_num"].ToString());
                }
                if (row["invoice_sn_temp"] != null)
                {
                    model.invoice_sn_temp = row["invoice_sn_temp"].ToString();
                }
                if (row["invoice_num_temp"] != null && row["invoice_num_temp"].ToString() != "")
                {
                    model.invoice_num_temp = int.Parse(row["invoice_num_temp"].ToString());
                }
                if (row["last_update_admin"] != null)
                {
                    model.last_update_admin = row["last_update_admin"].ToString();
                }
                if (row["init_refund_money"] != null && row["init_refund_money"].ToString() != "")
                {
                    model.init_refund_money = decimal.Parse(row["init_refund_money"].ToString());
                }
                if (row["print_hide"] != null && row["print_hide"].ToString() != "")
                {
                    model.print_hide = int.Parse(row["print_hide"].ToString());
                }
                if (row["is_tax_for_billing"] != null && row["is_tax_for_billing"].ToString() != "")
                {
                    model.is_tax_for_billing = int.Parse(row["is_tax_for_billing"].ToString());
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
            strSql.Append("select invoice_id,invoice_sn,invoice2_id,invoice_type,tax_rate,currency,exchange_rate,down_count,admin_id,user_id,address,bank_number,bank,shuihao,company_name,tel,total_count,total_money,note,invoices_note,pay_note,add_time,update_time,invoice_status,pre_status,invoice_time,erp_order_sn,invoice_num,invoice_date,refund_money,refund_djhm_str,sold_total_money,shipping_num,shipping_time,shipping_type,shipping_id,print_num,invoice_sn_temp,invoice_num_temp,last_update_admin,init_refund_money,print_hide ");
            strSql.Append(" FROM shop_invoices_among ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取所有开票请求
        /// </summary>
        public DataSet GetRequestBill(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select i.* ,e.name,CONCAT(c.C_name,',',c. C_tel,',',s.Customer) as customer,s.privatecustomer,s.BeSeats_id  FROM  xmh_shop.shop_invoices_among  i ");
            strSql.Append(" left join hr_employee e  on i.admin_id=e.ID ");
            strSql.Append(" left join crm_contact c on c.id=i.user_id ");
            strSql.Append(" left join crm_customer s on s.id=c.C_customerid ");

            strSql1.Append(" select count(i.invoice_id)  FROM  xmh_shop.shop_invoices_among   i ");
            strSql1.Append(" left join hr_employee e  on i.admin_id=e.ID ");
            strSql1.Append(" left join crm_contact c on c.id=i.user_id ");
            strSql1.Append(" left join crm_customer s on s.id=c.C_customerid ");


            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取开票用户信息
        /// </summary>
        public DataSet GetUserBillInfo(string strWhere, string strWhereOne)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select i.*,c.tax_company_name,c.tax_company_add_tel,c.tax_tax_code,c.tax_bank_name,c.tax_bank_num,cou.country_name,pro.province_name,ct.city_name,dis.district_name,");
            strSql.Append(" re.address_id,re.address_name,re.user_id,re.consignee,re.email as billemail,re.country,re.province,re.city,re.district, ");
            strSql.Append(" re.address as billaddress,re.zipcode,re.tel as re_tel,re.mobile,re.is_invoice,e.name,c.C_name,c.C_tel,s.Customer,s.privatecustomer,s.BeSeats_id   FROM  xmh_shop.shop_invoices_among   i ");
            strSql.Append(" left join hr_employee e  on i.admin_id=e.ID ");
            strSql.Append(" left join crm_contact c on c.id=i.user_id ");
            strSql.Append(" left join crm_customer s on s.id=c.C_customerid ");
            //strSql.Append(" left join xmh_shop.shop_user_address d on d.user_id=c.id ");
            strSql.Append(" left join (select * from xmh_shop.shop_user_address  ad   where ad.user_id=( select user_id from xmh_shop.shop_invoices_among where  invoice_id=" + strWhereOne + " ) and ad.is_invoice='1') as re  on re.user_id=c.id ");
            strSql.Append(" left join (select region_name  as country_name,region_id from xmh_shop.shop_region r left join xmh_shop.shop_user_address  a on a.country=r.region_id where a.user_id=( select user_id from xmh_shop.shop_invoices_among where invoice_id=" + strWhereOne + " )  and a.is_invoice='1') as cou   on cou.region_id=re.country ");
            strSql.Append(" left join (select region_name as province_name,region_id from xmh_shop.shop_region r left join xmh_shop.shop_user_address  a on a.province=r.region_id  where a.user_id=( select user_id from xmh_shop.shop_invoices_among where invoice_id=" + strWhereOne + " ) and a.is_invoice='1') as pro  on pro.region_id=re.province");
            strSql.Append(" left join (select region_name  as city_name,region_id from xmh_shop.shop_region r left join xmh_shop.shop_user_address  a on a.city=r.region_id where a.user_id=( select user_id from xmh_shop.shop_invoices_among where invoice_id=" + strWhereOne + " )   and a.is_invoice='1') as ct on ct.region_id =re.city ");
            strSql.Append(" left join (select region_name  as district_name,region_id from xmh_shop.shop_region r left join xmh_shop.shop_user_address  a on a.district=r.region_id where a.user_id=( select user_id from xmh_shop.shop_invoices_among where invoice_id=" + strWhereOne + " )   and a.is_invoice='1') as dis  on dis.region_id=re.district ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);

            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取开票五项
        /// </summary>
        public DataSet GetListBillInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select i.*,b.* ");
            strSql.Append(" FROM  xmh_shop.shop_invoices_among   i ");
            strSql.Append(" left join crm_contact_bill b  on i.user_id=b.user_id ");
          
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);

            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //获得客户的已开发票金额
        public string GetInvoiceAmoun(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(g.goods_num*g.goods_price ) as invoice_amoun  from shop_invoices_among_goods g inner join  shop_invoices_among i on g.target_id= i.invoice_id  ");
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

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


