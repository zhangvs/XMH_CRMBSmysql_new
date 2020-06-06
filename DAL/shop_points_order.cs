﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:shop_points_order
    /// </summary>
    public partial class shop_points_order
    {
        public shop_points_order()
        { }

        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int order_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_points_order");
            strSql.Append(" where order_id=@order_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = order_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop_points_order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_points_order(");
            strSql.Append("order_id,order_sn,wms_order_sn,erp_order_sn,cwerp_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,postscript,order_note,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,to_buyer,pay_note,agency_id,inv_type,tax,discount,shipname,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,det_stats,dealer_id,is_show_price,operator_user_id,invoice_weight,order_confirm_info,invoice_id,wms_setbook_id,wms_doc_id,wms_account_flag,wms_receive_note,wms_flow_no,wms_finish_amout,wms_unfinish_amout,wms_invoice_type,wms_account_type,wms_voucher,wms_amount,wms_storage,supply_user_id,is_invoice_advance,goods_integral_amount,time_id,order_type)");
            strSql.Append(" values (");
            strSql.Append("@order_id,@order_sn,@wms_order_sn,@erp_order_sn,@cwerp_order_sn,@user_id,@order_status,@shipping_status,@pay_status,@consignee,@country,@province,@city,@district,@address,@role_id,@user_market_area,@zipcode,@tel,@mobile,@email,@postscript,@order_note,@shipping_id,@shipping_name,@is_no_shipping_fee,@pay_id,@pay_name,@trans_bank_id,@trans_bank_name,@inv_payee,@inv_content,@goods_amount,@shipping_fee,@insure_fee,@pay_fee,@pack_fee,@money_paid,@surplus,@integral,@integral_money,@bonus,@order_amount,@from_ad,@referer,@add_time,@confirm_time,@pay_time,@shipping_time,@pack_id,@card_id,@bonus_id,@invoice_no,@to_buyer,@pay_note,@agency_id,@inv_type,@tax,@discount,@shipname,@need_inv,@is_send2_erp,@is_send2_cwerp,@is_wuliu_img,@get_pay_type,@is_daifa,@is_no_qingdan,@admin_user_id,@admin_user_name,@admin_user_real_name,@send_user_name,@send_user_tel,@send_user_company,@send_user_address,@cangku_id,@payinfo_pic,@is_confirm_remind,@is_print_remind,@order_ip,@cwerp_time,@erp_time,@is_need_review,@review_info,@det_stats,@dealer_id,@is_show_price,@operator_user_id,@invoice_weight,@order_confirm_info,@invoice_id,@wms_setbook_id,@wms_doc_id,@wms_account_flag,@wms_receive_note,@wms_flow_no,@wms_finish_amout,@wms_unfinish_amout,@wms_invoice_type,@wms_account_type,@wms_voucher,@wms_amount,@wms_storage,@supply_user_id,@is_invoice_advance,@goods_integral_amount,@time_id,@order_type)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int16,8),
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@wms_order_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@erp_order_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@cwerp_order_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@user_id", MySqlDbType.Int16,8),
					new MySqlParameter("@order_status", MySqlDbType.Int16,2),
					new MySqlParameter("@shipping_status", MySqlDbType.Int16,1),
					new MySqlParameter("@pay_status", MySqlDbType.Int16,1),
					new MySqlParameter("@consignee", MySqlDbType.VarChar,60),
					new MySqlParameter("@country", MySqlDbType.Int16,5),
					new MySqlParameter("@province", MySqlDbType.Int16,5),
					new MySqlParameter("@city", MySqlDbType.Int16,5),
					new MySqlParameter("@district", MySqlDbType.Int16,5),
					new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@role_id", MySqlDbType.Int16,5),
					new MySqlParameter("@user_market_area", MySqlDbType.Int16,5),
					new MySqlParameter("@zipcode", MySqlDbType.VarChar,60),
					new MySqlParameter("@tel", MySqlDbType.VarChar,60),
					new MySqlParameter("@mobile", MySqlDbType.VarChar,60),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@postscript", MySqlDbType.VarChar,255),
					new MySqlParameter("@order_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@shipping_id", MySqlDbType.Int16,3),
					new MySqlParameter("@shipping_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@is_no_shipping_fee", MySqlDbType.Int16,2),
					new MySqlParameter("@pay_id", MySqlDbType.Int16,3),
					new MySqlParameter("@pay_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@trans_bank_id", MySqlDbType.Int16,3),
					new MySqlParameter("@trans_bank_name", MySqlDbType.VarChar,128),
					new MySqlParameter("@inv_payee", MySqlDbType.VarChar,120),
					new MySqlParameter("@inv_content", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@insure_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@pay_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@pack_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@money_paid", MySqlDbType.Decimal,10),
					new MySqlParameter("@surplus", MySqlDbType.Decimal,10),
					new MySqlParameter("@integral", MySqlDbType.Int32,10),
					new MySqlParameter("@integral_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@bonus", MySqlDbType.Decimal,10),
					new MySqlParameter("@order_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@from_ad", MySqlDbType.Int16,5),
					new MySqlParameter("@referer", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@confirm_time", MySqlDbType.Int32,11),
					new MySqlParameter("@pay_time", MySqlDbType.Int32,11),
					new MySqlParameter("@shipping_time", MySqlDbType.Int32,11),
					new MySqlParameter("@pack_id", MySqlDbType.Int16,3),
					new MySqlParameter("@card_id", MySqlDbType.Int16,3),
					new MySqlParameter("@bonus_id", MySqlDbType.Int16,8),
					new MySqlParameter("@invoice_no", MySqlDbType.VarChar,600),
					new MySqlParameter("@to_buyer", MySqlDbType.VarChar,255),
					new MySqlParameter("@pay_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@agency_id", MySqlDbType.Int16,5),
					new MySqlParameter("@inv_type", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax", MySqlDbType.Decimal,10),
					new MySqlParameter("@discount", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipname", MySqlDbType.VarChar,255),
					new MySqlParameter("@need_inv", MySqlDbType.Int16,1),
					new MySqlParameter("@is_send2_erp", MySqlDbType.Int16,1),
					new MySqlParameter("@is_send2_cwerp", MySqlDbType.Int16,1),
					new MySqlParameter("@is_wuliu_img", MySqlDbType.Text),
					new MySqlParameter("@get_pay_type", MySqlDbType.VarChar,60),
					new MySqlParameter("@is_daifa", MySqlDbType.Int16,2),
					new MySqlParameter("@is_no_qingdan", MySqlDbType.Int16,2),
					new MySqlParameter("@admin_user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@admin_user_real_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_tel", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_company", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_address", MySqlDbType.VarChar,30),
					new MySqlParameter("@cangku_id", MySqlDbType.VarChar,30),
					new MySqlParameter("@payinfo_pic", MySqlDbType.Text),
					new MySqlParameter("@is_confirm_remind", MySqlDbType.Int16,4),
					new MySqlParameter("@is_print_remind", MySqlDbType.Int16,4),
					new MySqlParameter("@order_ip", MySqlDbType.VarChar,15),
					new MySqlParameter("@cwerp_time", MySqlDbType.VarChar,32),
					new MySqlParameter("@erp_time", MySqlDbType.VarChar,32),
					new MySqlParameter("@is_need_review", MySqlDbType.Int16,2),
					new MySqlParameter("@review_info", MySqlDbType.VarChar,100),
					new MySqlParameter("@det_stats", MySqlDbType.VarChar,2),
					new MySqlParameter("@dealer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@is_show_price", MySqlDbType.Int16,1),
					new MySqlParameter("@operator_user_id", MySqlDbType.Int16,8),
					new MySqlParameter("@invoice_weight", MySqlDbType.VarChar,255),
					new MySqlParameter("@order_confirm_info", MySqlDbType.VarChar,1000),
					new MySqlParameter("@invoice_id", MySqlDbType.Int16,6),
					new MySqlParameter("@wms_setbook_id", MySqlDbType.Int16,3),
					new MySqlParameter("@wms_doc_id", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_account_flag", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_receive_note", MySqlDbType.VarChar,60),
					new MySqlParameter("@wms_flow_no", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_finish_amout", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_unfinish_amout", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_invoice_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_account_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_voucher", MySqlDbType.Int32,11),
					new MySqlParameter("@wms_amount", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_storage", MySqlDbType.VarChar,10),
					new MySqlParameter("@supply_user_id", MySqlDbType.VarChar,32),
					new MySqlParameter("@is_invoice_advance", MySqlDbType.Int16,1),
					new MySqlParameter("@goods_integral_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@time_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_type", MySqlDbType.Int16,1)};
            parameters[0].Value = model.order_id;
            parameters[1].Value = model.order_sn;
            parameters[2].Value = model.wms_order_sn;
            parameters[3].Value = model.erp_order_sn;
            parameters[4].Value = model.cwerp_order_sn;
            parameters[5].Value = model.user_id;
            parameters[6].Value = model.order_status;
            parameters[7].Value = model.shipping_status;
            parameters[8].Value = model.pay_status;
            parameters[9].Value = model.consignee;
            parameters[10].Value = model.country;
            parameters[11].Value = model.province;
            parameters[12].Value = model.city;
            parameters[13].Value = model.district;
            parameters[14].Value = model.address;
            parameters[15].Value = model.role_id;
            parameters[16].Value = model.user_market_area;
            parameters[17].Value = model.zipcode;
            parameters[18].Value = model.tel;
            parameters[19].Value = model.mobile;
            parameters[20].Value = model.email;
            parameters[21].Value = model.postscript;
            parameters[22].Value = model.order_note;
            parameters[23].Value = model.shipping_id;
            parameters[24].Value = model.shipping_name;
            parameters[25].Value = model.is_no_shipping_fee;
            parameters[26].Value = model.pay_id;
            parameters[27].Value = model.pay_name;
            parameters[28].Value = model.trans_bank_id;
            parameters[29].Value = model.trans_bank_name;
            parameters[30].Value = model.inv_payee;
            parameters[31].Value = model.inv_content;
            parameters[32].Value = model.goods_amount;
            parameters[33].Value = model.shipping_fee;
            parameters[34].Value = model.insure_fee;
            parameters[35].Value = model.pay_fee;
            parameters[36].Value = model.pack_fee;
            parameters[37].Value = model.money_paid;
            parameters[38].Value = model.surplus;
            parameters[39].Value = model.integral;
            parameters[40].Value = model.integral_money;
            parameters[41].Value = model.bonus;
            parameters[42].Value = model.order_amount;
            parameters[43].Value = model.from_ad;
            parameters[44].Value = model.referer;
            parameters[45].Value = model.add_time;
            parameters[46].Value = model.confirm_time;
            parameters[47].Value = model.pay_time;
            parameters[48].Value = model.shipping_time;
            parameters[49].Value = model.pack_id;
            parameters[50].Value = model.card_id;
            parameters[51].Value = model.bonus_id;
            parameters[52].Value = model.invoice_no;
            parameters[53].Value = model.to_buyer;
            parameters[54].Value = model.pay_note;
            parameters[55].Value = model.agency_id;
            parameters[56].Value = model.inv_type;
            parameters[57].Value = model.tax;
            parameters[58].Value = model.discount;
            parameters[59].Value = model.shipname;
            parameters[60].Value = model.need_inv;
            parameters[61].Value = model.is_send2_erp;
            parameters[62].Value = model.is_send2_cwerp;
            parameters[63].Value = model.is_wuliu_img;
            parameters[64].Value = model.get_pay_type;
            parameters[65].Value = model.is_daifa;
            parameters[66].Value = model.is_no_qingdan;
            parameters[67].Value = model.admin_user_id;
            parameters[68].Value = model.admin_user_name;
            parameters[69].Value = model.admin_user_real_name;
            parameters[70].Value = model.send_user_name;
            parameters[71].Value = model.send_user_tel;
            parameters[72].Value = model.send_user_company;
            parameters[73].Value = model.send_user_address;
            parameters[74].Value = model.cangku_id;
            parameters[75].Value = model.payinfo_pic;
            parameters[76].Value = model.is_confirm_remind;
            parameters[77].Value = model.is_print_remind;
            parameters[78].Value = model.order_ip;
            parameters[79].Value = model.cwerp_time;
            parameters[80].Value = model.erp_time;
            parameters[81].Value = model.is_need_review;
            parameters[82].Value = model.review_info;
            parameters[83].Value = model.det_stats;
            parameters[84].Value = model.dealer_id;
            parameters[85].Value = model.is_show_price;
            parameters[86].Value = model.operator_user_id;
            parameters[87].Value = model.invoice_weight;
            parameters[88].Value = model.order_confirm_info;
            parameters[89].Value = model.invoice_id;
            parameters[90].Value = model.wms_setbook_id;
            parameters[91].Value = model.wms_doc_id;
            parameters[92].Value = model.wms_account_flag;
            parameters[93].Value = model.wms_receive_note;
            parameters[94].Value = model.wms_flow_no;
            parameters[95].Value = model.wms_finish_amout;
            parameters[96].Value = model.wms_unfinish_amout;
            parameters[97].Value = model.wms_invoice_type;
            parameters[98].Value = model.wms_account_type;
            parameters[99].Value = model.wms_voucher;
            parameters[100].Value = model.wms_amount;
            parameters[101].Value = model.wms_storage;
            parameters[102].Value = model.supply_user_id;
            parameters[103].Value = model.is_invoice_advance;
            parameters[104].Value = model.goods_integral_amount;
            parameters[105].Value = model.time_id;
            parameters[106].Value = model.order_type;

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
        public bool Update(XHD.Model.shop_points_order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_points_order set ");
            strSql.Append("order_sn=@order_sn,");
            strSql.Append("wms_order_sn=@wms_order_sn,");
            strSql.Append("erp_order_sn=@erp_order_sn,");
            strSql.Append("cwerp_order_sn=@cwerp_order_sn,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("order_status=@order_status,");
            strSql.Append("shipping_status=@shipping_status,");
            strSql.Append("pay_status=@pay_status,");
            strSql.Append("consignee=@consignee,");
            strSql.Append("country=@country,");
            strSql.Append("province=@province,");
            strSql.Append("city=@city,");
            strSql.Append("district=@district,");
            strSql.Append("address=@address,");
            strSql.Append("role_id=@role_id,");
            strSql.Append("user_market_area=@user_market_area,");
            strSql.Append("zipcode=@zipcode,");
            strSql.Append("tel=@tel,");
            strSql.Append("mobile=@mobile,");
            strSql.Append("email=@email,");
            strSql.Append("postscript=@postscript,");
            strSql.Append("order_note=@order_note,");
            strSql.Append("shipping_id=@shipping_id,");
            strSql.Append("shipping_name=@shipping_name,");
            strSql.Append("is_no_shipping_fee=@is_no_shipping_fee,");
            strSql.Append("pay_id=@pay_id,");
            strSql.Append("pay_name=@pay_name,");
            strSql.Append("trans_bank_id=@trans_bank_id,");
            strSql.Append("trans_bank_name=@trans_bank_name,");
            strSql.Append("inv_payee=@inv_payee,");
            strSql.Append("inv_content=@inv_content,");
            strSql.Append("goods_amount=@goods_amount,");
            strSql.Append("shipping_fee=@shipping_fee,");
            strSql.Append("insure_fee=@insure_fee,");
            strSql.Append("pay_fee=@pay_fee,");
            strSql.Append("pack_fee=@pack_fee,");
            strSql.Append("money_paid=@money_paid,");
            strSql.Append("surplus=@surplus,");
            strSql.Append("integral=@integral,");
            strSql.Append("integral_money=@integral_money,");
            strSql.Append("bonus=@bonus,");
            strSql.Append("order_amount=@order_amount,");
            strSql.Append("from_ad=@from_ad,");
            strSql.Append("referer=@referer,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("confirm_time=@confirm_time,");
            strSql.Append("pay_time=@pay_time,");
            strSql.Append("shipping_time=@shipping_time,");
            strSql.Append("pack_id=@pack_id,");
            strSql.Append("card_id=@card_id,");
            strSql.Append("bonus_id=@bonus_id,");
            strSql.Append("invoice_no=@invoice_no,");
            strSql.Append("to_buyer=@to_buyer,");
            strSql.Append("pay_note=@pay_note,");
            strSql.Append("agency_id=@agency_id,");
            strSql.Append("inv_type=@inv_type,");
            strSql.Append("tax=@tax,");
            strSql.Append("discount=@discount,");
            strSql.Append("shipname=@shipname,");
            strSql.Append("need_inv=@need_inv,");
            strSql.Append("is_send2_erp=@is_send2_erp,");
            strSql.Append("is_send2_cwerp=@is_send2_cwerp,");
            strSql.Append("is_wuliu_img=@is_wuliu_img,");
            strSql.Append("get_pay_type=@get_pay_type,");
            strSql.Append("is_daifa=@is_daifa,");
            strSql.Append("is_no_qingdan=@is_no_qingdan,");
            strSql.Append("admin_user_id=@admin_user_id,");
            strSql.Append("admin_user_name=@admin_user_name,");
            strSql.Append("admin_user_real_name=@admin_user_real_name,");
            strSql.Append("send_user_name=@send_user_name,");
            strSql.Append("send_user_tel=@send_user_tel,");
            strSql.Append("send_user_company=@send_user_company,");
            strSql.Append("send_user_address=@send_user_address,");
            strSql.Append("cangku_id=@cangku_id,");
            strSql.Append("payinfo_pic=@payinfo_pic,");
            strSql.Append("is_confirm_remind=@is_confirm_remind,");
            strSql.Append("is_print_remind=@is_print_remind,");
            strSql.Append("order_ip=@order_ip,");
            strSql.Append("cwerp_time=@cwerp_time,");
            strSql.Append("erp_time=@erp_time,");
            strSql.Append("is_need_review=@is_need_review,");
            strSql.Append("review_info=@review_info,");
            strSql.Append("det_stats=@det_stats,");
            strSql.Append("dealer_id=@dealer_id,");
            strSql.Append("is_show_price=@is_show_price,");
            strSql.Append("operator_user_id=@operator_user_id,");
            strSql.Append("invoice_weight=@invoice_weight,");
            strSql.Append("order_confirm_info=@order_confirm_info,");
            strSql.Append("invoice_id=@invoice_id,");
            strSql.Append("wms_setbook_id=@wms_setbook_id,");
            strSql.Append("wms_doc_id=@wms_doc_id,");
            strSql.Append("wms_account_flag=@wms_account_flag,");
            strSql.Append("wms_receive_note=@wms_receive_note,");
            strSql.Append("wms_flow_no=@wms_flow_no,");
            strSql.Append("wms_finish_amout=@wms_finish_amout,");
            strSql.Append("wms_unfinish_amout=@wms_unfinish_amout,");
            strSql.Append("wms_invoice_type=@wms_invoice_type,");
            strSql.Append("wms_account_type=@wms_account_type,");
            strSql.Append("wms_voucher=@wms_voucher,");
            strSql.Append("wms_amount=@wms_amount,");
            strSql.Append("wms_storage=@wms_storage,");
            strSql.Append("supply_user_id=@supply_user_id,");
            strSql.Append("is_invoice_advance=@is_invoice_advance,");
            strSql.Append("goods_integral_amount=@goods_integral_amount,");
            strSql.Append("time_id=@time_id,");
            strSql.Append("order_type=@order_type");
            strSql.Append(" where order_id=@order_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@wms_order_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@erp_order_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@cwerp_order_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@user_id", MySqlDbType.Int16,8),
					new MySqlParameter("@order_status", MySqlDbType.Int16,2),
					new MySqlParameter("@shipping_status", MySqlDbType.Int16,1),
					new MySqlParameter("@pay_status", MySqlDbType.Int16,1),
					new MySqlParameter("@consignee", MySqlDbType.VarChar,60),
					new MySqlParameter("@country", MySqlDbType.Int16,5),
					new MySqlParameter("@province", MySqlDbType.Int16,5),
					new MySqlParameter("@city", MySqlDbType.Int16,5),
					new MySqlParameter("@district", MySqlDbType.Int16,5),
					new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@role_id", MySqlDbType.Int16,5),
					new MySqlParameter("@user_market_area", MySqlDbType.Int16,5),
					new MySqlParameter("@zipcode", MySqlDbType.VarChar,60),
					new MySqlParameter("@tel", MySqlDbType.VarChar,60),
					new MySqlParameter("@mobile", MySqlDbType.VarChar,60),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@postscript", MySqlDbType.VarChar,255),
					new MySqlParameter("@order_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@shipping_id", MySqlDbType.Int16,3),
					new MySqlParameter("@shipping_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@is_no_shipping_fee", MySqlDbType.Int16,2),
					new MySqlParameter("@pay_id", MySqlDbType.Int16,3),
					new MySqlParameter("@pay_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@trans_bank_id", MySqlDbType.Int16,3),
					new MySqlParameter("@trans_bank_name", MySqlDbType.VarChar,128),
					new MySqlParameter("@inv_payee", MySqlDbType.VarChar,120),
					new MySqlParameter("@inv_content", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@insure_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@pay_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@pack_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@money_paid", MySqlDbType.Decimal,10),
					new MySqlParameter("@surplus", MySqlDbType.Decimal,10),
					new MySqlParameter("@integral", MySqlDbType.Int32,10),
					new MySqlParameter("@integral_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@bonus", MySqlDbType.Decimal,10),
					new MySqlParameter("@order_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@from_ad", MySqlDbType.Int16,5),
					new MySqlParameter("@referer", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@confirm_time", MySqlDbType.Int32,11),
					new MySqlParameter("@pay_time", MySqlDbType.Int32,11),
					new MySqlParameter("@shipping_time", MySqlDbType.Int32,11),
					new MySqlParameter("@pack_id", MySqlDbType.Int16,3),
					new MySqlParameter("@card_id", MySqlDbType.Int16,3),
					new MySqlParameter("@bonus_id", MySqlDbType.Int16,8),
					new MySqlParameter("@invoice_no", MySqlDbType.VarChar,600),
					new MySqlParameter("@to_buyer", MySqlDbType.VarChar,255),
					new MySqlParameter("@pay_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@agency_id", MySqlDbType.Int16,5),
					new MySqlParameter("@inv_type", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax", MySqlDbType.Decimal,10),
					new MySqlParameter("@discount", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipname", MySqlDbType.VarChar,255),
					new MySqlParameter("@need_inv", MySqlDbType.Int16,1),
					new MySqlParameter("@is_send2_erp", MySqlDbType.Int16,1),
					new MySqlParameter("@is_send2_cwerp", MySqlDbType.Int16,1),
					new MySqlParameter("@is_wuliu_img", MySqlDbType.Text),
					new MySqlParameter("@get_pay_type", MySqlDbType.VarChar,60),
					new MySqlParameter("@is_daifa", MySqlDbType.Int16,2),
					new MySqlParameter("@is_no_qingdan", MySqlDbType.Int16,2),
					new MySqlParameter("@admin_user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@admin_user_real_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_tel", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_company", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_address", MySqlDbType.VarChar,30),
					new MySqlParameter("@cangku_id", MySqlDbType.VarChar,30),
					new MySqlParameter("@payinfo_pic", MySqlDbType.Text),
					new MySqlParameter("@is_confirm_remind", MySqlDbType.Int16,4),
					new MySqlParameter("@is_print_remind", MySqlDbType.Int16,4),
					new MySqlParameter("@order_ip", MySqlDbType.VarChar,15),
					new MySqlParameter("@cwerp_time", MySqlDbType.VarChar,32),
					new MySqlParameter("@erp_time", MySqlDbType.VarChar,32),
					new MySqlParameter("@is_need_review", MySqlDbType.Int16,2),
					new MySqlParameter("@review_info", MySqlDbType.VarChar,100),
					new MySqlParameter("@det_stats", MySqlDbType.VarChar,2),
					new MySqlParameter("@dealer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@is_show_price", MySqlDbType.Int16,1),
					new MySqlParameter("@operator_user_id", MySqlDbType.Int16,8),
					new MySqlParameter("@invoice_weight", MySqlDbType.VarChar,255),
					new MySqlParameter("@order_confirm_info", MySqlDbType.VarChar,1000),
					new MySqlParameter("@invoice_id", MySqlDbType.Int16,6),
					new MySqlParameter("@wms_setbook_id", MySqlDbType.Int16,3),
					new MySqlParameter("@wms_doc_id", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_account_flag", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_receive_note", MySqlDbType.VarChar,60),
					new MySqlParameter("@wms_flow_no", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_finish_amout", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_unfinish_amout", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_invoice_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_account_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@wms_voucher", MySqlDbType.Int32,11),
					new MySqlParameter("@wms_amount", MySqlDbType.Decimal,18),
					new MySqlParameter("@wms_storage", MySqlDbType.VarChar,10),
					new MySqlParameter("@supply_user_id", MySqlDbType.VarChar,32),
					new MySqlParameter("@is_invoice_advance", MySqlDbType.Int16,1),
					new MySqlParameter("@goods_integral_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@time_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_type", MySqlDbType.Int16,1),
					new MySqlParameter("@order_id", MySqlDbType.Int16,8)};
            parameters[0].Value = model.order_sn;
            parameters[1].Value = model.wms_order_sn;
            parameters[2].Value = model.erp_order_sn;
            parameters[3].Value = model.cwerp_order_sn;
            parameters[4].Value = model.user_id;
            parameters[5].Value = model.order_status;
            parameters[6].Value = model.shipping_status;
            parameters[7].Value = model.pay_status;
            parameters[8].Value = model.consignee;
            parameters[9].Value = model.country;
            parameters[10].Value = model.province;
            parameters[11].Value = model.city;
            parameters[12].Value = model.district;
            parameters[13].Value = model.address;
            parameters[14].Value = model.role_id;
            parameters[15].Value = model.user_market_area;
            parameters[16].Value = model.zipcode;
            parameters[17].Value = model.tel;
            parameters[18].Value = model.mobile;
            parameters[19].Value = model.email;
            parameters[20].Value = model.postscript;
            parameters[21].Value = model.order_note;
            parameters[22].Value = model.shipping_id;
            parameters[23].Value = model.shipping_name;
            parameters[24].Value = model.is_no_shipping_fee;
            parameters[25].Value = model.pay_id;
            parameters[26].Value = model.pay_name;
            parameters[27].Value = model.trans_bank_id;
            parameters[28].Value = model.trans_bank_name;
            parameters[29].Value = model.inv_payee;
            parameters[30].Value = model.inv_content;
            parameters[31].Value = model.goods_amount;
            parameters[32].Value = model.shipping_fee;
            parameters[33].Value = model.insure_fee;
            parameters[34].Value = model.pay_fee;
            parameters[35].Value = model.pack_fee;
            parameters[36].Value = model.money_paid;
            parameters[37].Value = model.surplus;
            parameters[38].Value = model.integral;
            parameters[39].Value = model.integral_money;
            parameters[40].Value = model.bonus;
            parameters[41].Value = model.order_amount;
            parameters[42].Value = model.from_ad;
            parameters[43].Value = model.referer;
            parameters[44].Value = model.add_time;
            parameters[45].Value = model.confirm_time;
            parameters[46].Value = model.pay_time;
            parameters[47].Value = model.shipping_time;
            parameters[48].Value = model.pack_id;
            parameters[49].Value = model.card_id;
            parameters[50].Value = model.bonus_id;
            parameters[51].Value = model.invoice_no;
            parameters[52].Value = model.to_buyer;
            parameters[53].Value = model.pay_note;
            parameters[54].Value = model.agency_id;
            parameters[55].Value = model.inv_type;
            parameters[56].Value = model.tax;
            parameters[57].Value = model.discount;
            parameters[58].Value = model.shipname;
            parameters[59].Value = model.need_inv;
            parameters[60].Value = model.is_send2_erp;
            parameters[61].Value = model.is_send2_cwerp;
            parameters[62].Value = model.is_wuliu_img;
            parameters[63].Value = model.get_pay_type;
            parameters[64].Value = model.is_daifa;
            parameters[65].Value = model.is_no_qingdan;
            parameters[66].Value = model.admin_user_id;
            parameters[67].Value = model.admin_user_name;
            parameters[68].Value = model.admin_user_real_name;
            parameters[69].Value = model.send_user_name;
            parameters[70].Value = model.send_user_tel;
            parameters[71].Value = model.send_user_company;
            parameters[72].Value = model.send_user_address;
            parameters[73].Value = model.cangku_id;
            parameters[74].Value = model.payinfo_pic;
            parameters[75].Value = model.is_confirm_remind;
            parameters[76].Value = model.is_print_remind;
            parameters[77].Value = model.order_ip;
            parameters[78].Value = model.cwerp_time;
            parameters[79].Value = model.erp_time;
            parameters[80].Value = model.is_need_review;
            parameters[81].Value = model.review_info;
            parameters[82].Value = model.det_stats;
            parameters[83].Value = model.dealer_id;
            parameters[84].Value = model.is_show_price;
            parameters[85].Value = model.operator_user_id;
            parameters[86].Value = model.invoice_weight;
            parameters[87].Value = model.order_confirm_info;
            parameters[88].Value = model.invoice_id;
            parameters[89].Value = model.wms_setbook_id;
            parameters[90].Value = model.wms_doc_id;
            parameters[91].Value = model.wms_account_flag;
            parameters[92].Value = model.wms_receive_note;
            parameters[93].Value = model.wms_flow_no;
            parameters[94].Value = model.wms_finish_amout;
            parameters[95].Value = model.wms_unfinish_amout;
            parameters[96].Value = model.wms_invoice_type;
            parameters[97].Value = model.wms_account_type;
            parameters[98].Value = model.wms_voucher;
            parameters[99].Value = model.wms_amount;
            parameters[100].Value = model.wms_storage;
            parameters[101].Value = model.supply_user_id;
            parameters[102].Value = model.is_invoice_advance;
            parameters[103].Value = model.goods_integral_amount;
            parameters[104].Value = model.time_id;
            parameters[105].Value = model.order_type;
            parameters[106].Value = model.order_id;

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
        public bool Delete(int order_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_points_order ");
            strSql.Append(" where order_id=@order_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = order_id;

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
        public bool DeleteList(string order_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_points_order ");
            strSql.Append(" where order_id in (" + order_idlist + ")  ");
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
        public XHD.Model.shop_points_order GetModel(int order_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select order_id,order_sn,wms_order_sn,erp_order_sn,cwerp_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,postscript,order_note,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,to_buyer,pay_note,agency_id,inv_type,tax,discount,shipname,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,det_stats,dealer_id,is_show_price,operator_user_id,invoice_weight,order_confirm_info,invoice_id,wms_setbook_id,wms_doc_id,wms_account_flag,wms_receive_note,wms_flow_no,wms_finish_amout,wms_unfinish_amout,wms_invoice_type,wms_account_type,wms_voucher,wms_amount,wms_storage,supply_user_id,is_invoice_advance,goods_integral_amount,time_id,order_type from shop_points_order ");
            strSql.Append(" where order_id=@order_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = order_id;

            XHD.Model.shop_points_order model = new XHD.Model.shop_points_order();
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
        public XHD.Model.shop_points_order DataRowToModel(DataRow row)
        {
            XHD.Model.shop_points_order model = new XHD.Model.shop_points_order();
            if (row != null)
            {
                //model.order_id=row["order_id"].ToString();
                if (row["order_sn"] != null)
                {
                    model.order_sn = row["order_sn"].ToString();
                }
                if (row["wms_order_sn"] != null)
                {
                    model.wms_order_sn = row["wms_order_sn"].ToString();
                }
                if (row["erp_order_sn"] != null)
                {
                    model.erp_order_sn = row["erp_order_sn"].ToString();
                }
                if (row["cwerp_order_sn"] != null)
                {
                    model.cwerp_order_sn = row["cwerp_order_sn"].ToString();
                }
                //model.user_id=row["user_id"].ToString();
                if (row["order_status"] != null && row["order_status"].ToString() != "")
                {
                    model.order_status = int.Parse(row["order_status"].ToString());
                }
                if (row["shipping_status"] != null && row["shipping_status"].ToString() != "")
                {
                    model.shipping_status = int.Parse(row["shipping_status"].ToString());
                }
                if (row["pay_status"] != null && row["pay_status"].ToString() != "")
                {
                    model.pay_status = int.Parse(row["pay_status"].ToString());
                }
                if (row["consignee"] != null)
                {
                    model.consignee = row["consignee"].ToString();
                }
                if (row["country"] != null && row["country"].ToString() != "")
                {
                    model.country = int.Parse(row["country"].ToString());
                }
                if (row["province"] != null && row["province"].ToString() != "")
                {
                    model.province = int.Parse(row["province"].ToString());
                }
                if (row["city"] != null && row["city"].ToString() != "")
                {
                    model.city = int.Parse(row["city"].ToString());
                }
                if (row["district"] != null && row["district"].ToString() != "")
                {
                    model.district = int.Parse(row["district"].ToString());
                }
                if (row["address"] != null)
                {
                    model.address = row["address"].ToString();
                }
                if (row["role_id"] != null && row["role_id"].ToString() != "")
                {
                    model.role_id = int.Parse(row["role_id"].ToString());
                }
                //model.user_market_area=row["user_market_area"].ToString();
                if (row["zipcode"] != null)
                {
                    model.zipcode = row["zipcode"].ToString();
                }
                if (row["tel"] != null)
                {
                    model.tel = row["tel"].ToString();
                }
                if (row["mobile"] != null)
                {
                    model.mobile = row["mobile"].ToString();
                }
                if (row["email"] != null)
                {
                    model.email = row["email"].ToString();
                }
                if (row["postscript"] != null)
                {
                    model.postscript = row["postscript"].ToString();
                }
                if (row["order_note"] != null)
                {
                    model.order_note = row["order_note"].ToString();
                }
                if (row["shipping_id"] != null && row["shipping_id"].ToString() != "")
                {
                    model.shipping_id = int.Parse(row["shipping_id"].ToString());
                }
                if (row["shipping_name"] != null)
                {
                    model.shipping_name = row["shipping_name"].ToString();
                }
                if (row["is_no_shipping_fee"] != null && row["is_no_shipping_fee"].ToString() != "")
                {
                    model.is_no_shipping_fee = int.Parse(row["is_no_shipping_fee"].ToString());
                }
                if (row["pay_id"] != null && row["pay_id"].ToString() != "")
                {
                    model.pay_id = int.Parse(row["pay_id"].ToString());
                }
                if (row["pay_name"] != null)
                {
                    model.pay_name = row["pay_name"].ToString();
                }
                if (row["trans_bank_id"] != null && row["trans_bank_id"].ToString() != "")
                {
                    model.trans_bank_id = int.Parse(row["trans_bank_id"].ToString());
                }
                if (row["trans_bank_name"] != null)
                {
                    model.trans_bank_name = row["trans_bank_name"].ToString();
                }
                if (row["inv_payee"] != null)
                {
                    model.inv_payee = row["inv_payee"].ToString();
                }
                if (row["inv_content"] != null)
                {
                    model.inv_content = row["inv_content"].ToString();
                }
                if (row["goods_amount"] != null && row["goods_amount"].ToString() != "")
                {
                    model.goods_amount = decimal.Parse(row["goods_amount"].ToString());
                }
                if (row["shipping_fee"] != null && row["shipping_fee"].ToString() != "")
                {
                    model.shipping_fee = decimal.Parse(row["shipping_fee"].ToString());
                }
                if (row["insure_fee"] != null && row["insure_fee"].ToString() != "")
                {
                    model.insure_fee = decimal.Parse(row["insure_fee"].ToString());
                }
                if (row["pay_fee"] != null && row["pay_fee"].ToString() != "")
                {
                    model.pay_fee = decimal.Parse(row["pay_fee"].ToString());
                }
                if (row["pack_fee"] != null && row["pack_fee"].ToString() != "")
                {
                    model.pack_fee = decimal.Parse(row["pack_fee"].ToString());
                }
                if (row["money_paid"] != null && row["money_paid"].ToString() != "")
                {
                    model.money_paid = decimal.Parse(row["money_paid"].ToString());
                }
                if (row["surplus"] != null && row["surplus"].ToString() != "")
                {
                    model.surplus = decimal.Parse(row["surplus"].ToString());
                }
                if (row["integral"] != null && row["integral"].ToString() != "")
                {
                    model.integral = int.Parse(row["integral"].ToString());
                }
                if (row["integral_money"] != null && row["integral_money"].ToString() != "")
                {
                    model.integral_money = decimal.Parse(row["integral_money"].ToString());
                }
                if (row["bonus"] != null && row["bonus"].ToString() != "")
                {
                    model.bonus = decimal.Parse(row["bonus"].ToString());
                }
                if (row["order_amount"] != null && row["order_amount"].ToString() != "")
                {
                    model.order_amount = decimal.Parse(row["order_amount"].ToString());
                }
                if (row["from_ad"] != null && row["from_ad"].ToString() != "")
                {
                    model.from_ad = int.Parse(row["from_ad"].ToString());
                }
                if (row["referer"] != null)
                {
                    model.referer = row["referer"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = int.Parse(row["add_time"].ToString());
                }
                if (row["confirm_time"] != null && row["confirm_time"].ToString() != "")
                {
                    model.confirm_time = int.Parse(row["confirm_time"].ToString());
                }
                if (row["pay_time"] != null && row["pay_time"].ToString() != "")
                {
                    model.pay_time = int.Parse(row["pay_time"].ToString());
                }
                if (row["shipping_time"] != null && row["shipping_time"].ToString() != "")
                {
                    model.shipping_time = int.Parse(row["shipping_time"].ToString());
                }
                if (row["pack_id"] != null && row["pack_id"].ToString() != "")
                {
                    model.pack_id = int.Parse(row["pack_id"].ToString());
                }
                if (row["card_id"] != null && row["card_id"].ToString() != "")
                {
                    model.card_id = int.Parse(row["card_id"].ToString());
                }
                //model.bonus_id=row["bonus_id"].ToString();
                if (row["invoice_no"] != null)
                {
                    model.invoice_no = row["invoice_no"].ToString();
                }
                if (row["to_buyer"] != null)
                {
                    model.to_buyer = row["to_buyer"].ToString();
                }
                if (row["pay_note"] != null)
                {
                    model.pay_note = row["pay_note"].ToString();
                }
                if (row["agency_id"] != null && row["agency_id"].ToString() != "")
                {
                    model.agency_id = int.Parse(row["agency_id"].ToString());
                }
                if (row["inv_type"] != null)
                {
                    model.inv_type = row["inv_type"].ToString();
                }
                if (row["tax"] != null && row["tax"].ToString() != "")
                {
                    model.tax = decimal.Parse(row["tax"].ToString());
                }
                if (row["discount"] != null && row["discount"].ToString() != "")
                {
                    model.discount = decimal.Parse(row["discount"].ToString());
                }
                if (row["shipname"] != null)
                {
                    model.shipname = row["shipname"].ToString();
                }
                if (row["need_inv"] != null && row["need_inv"].ToString() != "")
                {
                    model.need_inv = int.Parse(row["need_inv"].ToString());
                }
                if (row["is_send2_erp"] != null && row["is_send2_erp"].ToString() != "")
                {
                    model.is_send2_erp = int.Parse(row["is_send2_erp"].ToString());
                }
                if (row["is_send2_cwerp"] != null && row["is_send2_cwerp"].ToString() != "")
                {
                    model.is_send2_cwerp = int.Parse(row["is_send2_cwerp"].ToString());
                }
                if (row["is_wuliu_img"] != null)
                {
                    model.is_wuliu_img = row["is_wuliu_img"].ToString();
                }
                if (row["get_pay_type"] != null)
                {
                    model.get_pay_type = row["get_pay_type"].ToString();
                }
                if (row["is_daifa"] != null && row["is_daifa"].ToString() != "")
                {
                    model.is_daifa = int.Parse(row["is_daifa"].ToString());
                }
                if (row["is_no_qingdan"] != null && row["is_no_qingdan"].ToString() != "")
                {
                    model.is_no_qingdan = int.Parse(row["is_no_qingdan"].ToString());
                }
                if (row["admin_user_id"] != null && row["admin_user_id"].ToString() != "")
                {
                    model.admin_user_id = int.Parse(row["admin_user_id"].ToString());
                }
                if (row["admin_user_name"] != null)
                {
                    model.admin_user_name = row["admin_user_name"].ToString();
                }
                if (row["admin_user_real_name"] != null)
                {
                    model.admin_user_real_name = row["admin_user_real_name"].ToString();
                }
                if (row["send_user_name"] != null)
                {
                    model.send_user_name = row["send_user_name"].ToString();
                }
                if (row["send_user_tel"] != null)
                {
                    model.send_user_tel = row["send_user_tel"].ToString();
                }
                if (row["send_user_company"] != null)
                {
                    model.send_user_company = row["send_user_company"].ToString();
                }
                if (row["send_user_address"] != null)
                {
                    model.send_user_address = row["send_user_address"].ToString();
                }
                if (row["cangku_id"] != null)
                {
                    model.cangku_id = row["cangku_id"].ToString();
                }
                if (row["payinfo_pic"] != null)
                {
                    model.payinfo_pic = row["payinfo_pic"].ToString();
                }
                if (row["is_confirm_remind"] != null && row["is_confirm_remind"].ToString() != "")
                {
                    model.is_confirm_remind = int.Parse(row["is_confirm_remind"].ToString());
                }
                if (row["is_print_remind"] != null && row["is_print_remind"].ToString() != "")
                {
                    model.is_print_remind = int.Parse(row["is_print_remind"].ToString());
                }
                if (row["order_ip"] != null)
                {
                    model.order_ip = row["order_ip"].ToString();
                }
                if (row["cwerp_time"] != null)
                {
                    model.cwerp_time = row["cwerp_time"].ToString();
                }
                if (row["erp_time"] != null)
                {
                    model.erp_time = row["erp_time"].ToString();
                }
                if (row["is_need_review"] != null && row["is_need_review"].ToString() != "")
                {
                    model.is_need_review = int.Parse(row["is_need_review"].ToString());
                }
                if (row["review_info"] != null)
                {
                    model.review_info = row["review_info"].ToString();
                }
                if (row["det_stats"] != null)
                {
                    model.det_stats = row["det_stats"].ToString();
                }
                if (row["dealer_id"] != null && row["dealer_id"].ToString() != "")
                {
                    model.dealer_id = int.Parse(row["dealer_id"].ToString());
                }
                if (row["is_show_price"] != null && row["is_show_price"].ToString() != "")
                {
                    model.is_show_price = int.Parse(row["is_show_price"].ToString());
                }
                //model.operator_user_id=row["operator_user_id"].ToString();
                if (row["invoice_weight"] != null)
                {
                    model.invoice_weight = row["invoice_weight"].ToString();
                }
                if (row["order_confirm_info"] != null)
                {
                    model.order_confirm_info = row["order_confirm_info"].ToString();
                }
                //model.invoice_id=row["invoice_id"].ToString();
                if (row["wms_setbook_id"] != null && row["wms_setbook_id"].ToString() != "")
                {
                    model.wms_setbook_id = int.Parse(row["wms_setbook_id"].ToString());
                }
                if (row["wms_doc_id"] != null && row["wms_doc_id"].ToString() != "")
                {
                    model.wms_doc_id = decimal.Parse(row["wms_doc_id"].ToString());
                }
                if (row["wms_account_flag"] != null)
                {
                    model.wms_account_flag = row["wms_account_flag"].ToString();
                }
                if (row["wms_receive_note"] != null)
                {
                    model.wms_receive_note = row["wms_receive_note"].ToString();
                }
                if (row["wms_flow_no"] != null && row["wms_flow_no"].ToString() != "")
                {
                    model.wms_flow_no = decimal.Parse(row["wms_flow_no"].ToString());
                }
                if (row["wms_finish_amout"] != null && row["wms_finish_amout"].ToString() != "")
                {
                    model.wms_finish_amout = decimal.Parse(row["wms_finish_amout"].ToString());
                }
                if (row["wms_unfinish_amout"] != null && row["wms_unfinish_amout"].ToString() != "")
                {
                    model.wms_unfinish_amout = decimal.Parse(row["wms_unfinish_amout"].ToString());
                }
                if (row["wms_invoice_type"] != null)
                {
                    model.wms_invoice_type = row["wms_invoice_type"].ToString();
                }
                if (row["wms_account_type"] != null)
                {
                    model.wms_account_type = row["wms_account_type"].ToString();
                }
                if (row["wms_voucher"] != null && row["wms_voucher"].ToString() != "")
                {
                    model.wms_voucher = int.Parse(row["wms_voucher"].ToString());
                }
                if (row["wms_amount"] != null && row["wms_amount"].ToString() != "")
                {
                    model.wms_amount = decimal.Parse(row["wms_amount"].ToString());
                }
                if (row["wms_storage"] != null)
                {
                    model.wms_storage = row["wms_storage"].ToString();
                }
                if (row["supply_user_id"] != null)
                {
                    model.supply_user_id = row["supply_user_id"].ToString();
                }
                if (row["is_invoice_advance"] != null && row["is_invoice_advance"].ToString() != "")
                {
                    model.is_invoice_advance = int.Parse(row["is_invoice_advance"].ToString());
                }
                if (row["goods_integral_amount"] != null && row["goods_integral_amount"].ToString() != "")
                {
                    model.goods_integral_amount = decimal.Parse(row["goods_integral_amount"].ToString());
                }
                if (row["time_id"] != null && row["time_id"].ToString() != "")
                {
                    model.time_id = int.Parse(row["time_id"].ToString());
                }
                if (row["order_type"] != null && row["order_type"].ToString() != "")
                {
                    model.order_type = int.Parse(row["order_type"].ToString());
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
            strSql.Append("select order_id,order_sn,wms_order_sn,erp_order_sn,cwerp_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,postscript,order_note,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,to_buyer,pay_note,agency_id,inv_type,tax,discount,shipname,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,det_stats,dealer_id,is_show_price,operator_user_id,invoice_weight,order_confirm_info,invoice_id,wms_setbook_id,wms_doc_id,wms_account_flag,wms_receive_note,wms_flow_no,wms_finish_amout,wms_unfinish_amout,wms_invoice_type,wms_account_type,wms_voucher,wms_amount,wms_storage,supply_user_id,is_invoice_advance,goods_integral_amount,time_id,order_type ");
            strSql.Append(" FROM shop_points_order ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

