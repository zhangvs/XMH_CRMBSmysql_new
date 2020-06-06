using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using XHD.DBUtility;

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_order_info
    /// </summary>
    public partial class ecs_order_info
    {
        public ecs_order_info()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int order_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_order_info");
            strSql.Append(" where order_id=@order_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int32,8)
			};
            parameters[0].Value = order_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_order_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_order_info(");
            strSql.Append("order_sn,erp_order_sn,cwerp_order_sn,wms_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,best_time,sign_building,postscript,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,how_oos,how_surplus,pack_name,card_name,card_message,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,card_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,extension_code,extension_id,to_buyer,pay_note,agency_id,inv_type,inv_no,tax,is_separate,parent_id,discount,shipname,affirm_time,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,operator,det_stats,dealer_id,is_show_price,operator_user_id,file_url,invoice_weight,order_confirm_info,is_invoce,jz,SKSM,ztidh,djhm,lsh,hxje,whxje,fplx,hslx,pzhm,je,shenji)");
            strSql.Append(" values (");
            strSql.Append("@order_sn,@erp_order_sn,@cwerp_order_sn,@wms_order_sn,@user_id,@order_status,@shipping_status,@pay_status,@consignee,@country,@province,@city,@district,@address,@role_id,@user_market_area,@zipcode,@tel,@mobile,@email,@best_time,@sign_building,@postscript,@shipping_id,@shipping_name,@is_no_shipping_fee,@pay_id,@pay_name,@trans_bank_id,@trans_bank_name,@how_oos,@how_surplus,@pack_name,@card_name,@card_message,@inv_payee,@inv_content,@goods_amount,@shipping_fee,@insure_fee,@pay_fee,@pack_fee,@card_fee,@money_paid,@surplus,@integral,@integral_money,@bonus,@order_amount,@from_ad,@referer,@add_time,@confirm_time,@pay_time,@shipping_time,@pack_id,@card_id,@bonus_id,@invoice_no,@extension_code,@extension_id,@to_buyer,@pay_note,@agency_id,@inv_type,@inv_no,@tax,@is_separate,@parent_id,@discount,@shipname,@affirm_time,@need_inv,@is_send2_erp,@is_send2_cwerp,@is_wuliu_img,@get_pay_type,@is_daifa,@is_no_qingdan,@admin_user_id,@admin_user_name,@admin_user_real_name,@send_user_name,@send_user_tel,@send_user_company,@send_user_address,@cangku_id,@payinfo_pic,@is_confirm_remind,@is_print_remind,@order_ip,@cwerp_time,@erp_time,@is_need_review,@review_info,@operator,@det_stats,@dealer_id,@is_show_price,@operator_user_id,@file_url,@invoice_weight,@order_confirm_info,@is_invoce,@jz,@SKSM,@ztidh,@djhm,@lsh,@hxje,@whxje,@fplx,@hslx,@pzhm,@je,@shenji)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@erp_order_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@cwerp_order_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@wms_order_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_id", MySqlDbType.Int32,8),
					new MySqlParameter("@order_status", MySqlDbType.Int32,2),
					new MySqlParameter("@shipping_status", MySqlDbType.Int32,1),
					new MySqlParameter("@pay_status", MySqlDbType.Int32,1),
					new MySqlParameter("@consignee", MySqlDbType.VarChar,60),
					new MySqlParameter("@country", MySqlDbType.Int32,5),
					new MySqlParameter("@province", MySqlDbType.Int32,5),
					new MySqlParameter("@city", MySqlDbType.Int32,5),
					new MySqlParameter("@district", MySqlDbType.Int32,5),
					new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@role_id", MySqlDbType.Int32,5),
					new MySqlParameter("@user_market_area", MySqlDbType.Int32,5),
					new MySqlParameter("@zipcode", MySqlDbType.VarChar,60),
					new MySqlParameter("@tel", MySqlDbType.VarChar,60),
					new MySqlParameter("@mobile", MySqlDbType.VarChar,60),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@best_time", MySqlDbType.VarChar,120),
					new MySqlParameter("@sign_building", MySqlDbType.VarChar,120),
					new MySqlParameter("@postscript", MySqlDbType.VarChar,255),
					new MySqlParameter("@shipping_id", MySqlDbType.Int32,3),
					new MySqlParameter("@shipping_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@is_no_shipping_fee", MySqlDbType.Int32,2),
					new MySqlParameter("@pay_id", MySqlDbType.Int32,3),
					new MySqlParameter("@pay_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@trans_bank_id", MySqlDbType.Int32,3),
					new MySqlParameter("@trans_bank_name", MySqlDbType.VarChar,128),
					new MySqlParameter("@how_oos", MySqlDbType.VarChar,120),
					new MySqlParameter("@how_surplus", MySqlDbType.VarChar,120),
					new MySqlParameter("@pack_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@card_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@card_message", MySqlDbType.VarChar,255),
					new MySqlParameter("@inv_payee", MySqlDbType.VarChar,120),
					new MySqlParameter("@inv_content", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@insure_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@pay_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@pack_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@card_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@money_paid", MySqlDbType.Decimal,10),
					new MySqlParameter("@surplus", MySqlDbType.Decimal,10),
					new MySqlParameter("@integral", MySqlDbType.Int32,10),
					new MySqlParameter("@integral_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@bonus", MySqlDbType.Decimal,10),
					new MySqlParameter("@order_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@from_ad", MySqlDbType.Int32,5),
					new MySqlParameter("@referer", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.Int32,10),
					new MySqlParameter("@confirm_time", MySqlDbType.Int32,10),
					new MySqlParameter("@pay_time", MySqlDbType.Int32,10),
					new MySqlParameter("@shipping_time", MySqlDbType.Int32,10),
					new MySqlParameter("@pack_id", MySqlDbType.Int32,3),
					new MySqlParameter("@card_id", MySqlDbType.Int32,3),
					new MySqlParameter("@bonus_id", MySqlDbType.Int32,8),
					new MySqlParameter("@invoice_no", MySqlDbType.VarChar,600),
					new MySqlParameter("@extension_code", MySqlDbType.VarChar,30),
					new MySqlParameter("@extension_id", MySqlDbType.Int32,8),
					new MySqlParameter("@to_buyer", MySqlDbType.VarChar,255),
					new MySqlParameter("@pay_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@agency_id", MySqlDbType.Int32,5),
					new MySqlParameter("@inv_type", MySqlDbType.VarChar,60),
					new MySqlParameter("@inv_no", MySqlDbType.VarChar,32),
					new MySqlParameter("@tax", MySqlDbType.Decimal,10),
					new MySqlParameter("@is_separate", MySqlDbType.Int32,1),
					new MySqlParameter("@parent_id", MySqlDbType.Int32,8),
					new MySqlParameter("@discount", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipname", MySqlDbType.VarChar,255),
					new MySqlParameter("@affirm_time", MySqlDbType.Int32,10),
					new MySqlParameter("@need_inv", MySqlDbType.Int32,1),
					new MySqlParameter("@is_send2_erp", MySqlDbType.Int32,1),
					new MySqlParameter("@is_send2_cwerp", MySqlDbType.Int32,1),
					new MySqlParameter("@is_wuliu_img", MySqlDbType.Text),
					new MySqlParameter("@get_pay_type", MySqlDbType.VarChar,60),
					new MySqlParameter("@is_daifa", MySqlDbType.Int32,2),
					new MySqlParameter("@is_no_qingdan", MySqlDbType.Int32,2),
					new MySqlParameter("@admin_user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@admin_user_real_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_tel", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_company", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_address", MySqlDbType.VarChar,30),
					new MySqlParameter("@cangku_id", MySqlDbType.VarChar,30),
					new MySqlParameter("@payinfo_pic", MySqlDbType.Text),
					new MySqlParameter("@is_confirm_remind", MySqlDbType.Int32,4),
					new MySqlParameter("@is_print_remind", MySqlDbType.Int32,4),
					new MySqlParameter("@order_ip", MySqlDbType.VarChar,30),
					new MySqlParameter("@cwerp_time", MySqlDbType.VarChar,32),
					new MySqlParameter("@erp_time", MySqlDbType.VarChar,32),
					new MySqlParameter("@is_need_review", MySqlDbType.Int32,2),
					new MySqlParameter("@review_info", MySqlDbType.VarChar,100),
					new MySqlParameter("@operator", MySqlDbType.VarChar,6),
					new MySqlParameter("@det_stats", MySqlDbType.VarChar,2),
					new MySqlParameter("@dealer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@is_show_price", MySqlDbType.Int32,1),
					new MySqlParameter("@operator_user_id", MySqlDbType.Int32,8),
					new MySqlParameter("@file_url", MySqlDbType.VarChar,100),
					new MySqlParameter("@invoice_weight", MySqlDbType.VarChar,255),
					new MySqlParameter("@order_confirm_info", MySqlDbType.VarChar,1000),
					new MySqlParameter("@is_invoce", MySqlDbType.Int32,1),
					new MySqlParameter("@jz", MySqlDbType.VarChar,255),
					new MySqlParameter("@SKSM", MySqlDbType.VarChar,100),
					new MySqlParameter("@ztidh", MySqlDbType.Int32,3),
					new MySqlParameter("@djhm", MySqlDbType.Decimal,18),
					new MySqlParameter("@lsh", MySqlDbType.Decimal,18),
					new MySqlParameter("@hxje", MySqlDbType.Decimal,18),
					new MySqlParameter("@whxje", MySqlDbType.Decimal,18),
					new MySqlParameter("@fplx", MySqlDbType.VarChar,50),
					new MySqlParameter("@hslx", MySqlDbType.VarChar,50),
					new MySqlParameter("@pzhm", MySqlDbType.Int32,11),
					new MySqlParameter("@je", MySqlDbType.Decimal,18),
					new MySqlParameter("@shenji", MySqlDbType.VarChar,20)};
            parameters[0].Value = model.order_sn;
            parameters[1].Value = model.erp_order_sn;
            parameters[2].Value = model.cwerp_order_sn;
            parameters[3].Value = model.wms_order_sn;
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
            parameters[20].Value = model.best_time;
            parameters[21].Value = model.sign_building;
            parameters[22].Value = model.postscript;
            parameters[23].Value = model.shipping_id;
            parameters[24].Value = model.shipping_name;
            parameters[25].Value = model.is_no_shipping_fee;
            parameters[26].Value = model.pay_id;
            parameters[27].Value = model.pay_name;
            parameters[28].Value = model.trans_bank_id;
            parameters[29].Value = model.trans_bank_name;
            parameters[30].Value = model.how_oos;
            parameters[31].Value = model.how_surplus;
            parameters[32].Value = model.pack_name;
            parameters[33].Value = model.card_name;
            parameters[34].Value = model.card_message;
            parameters[35].Value = model.inv_payee;
            parameters[36].Value = model.inv_content;
            parameters[37].Value = model.goods_amount;
            parameters[38].Value = model.shipping_fee;
            parameters[39].Value = model.insure_fee;
            parameters[40].Value = model.pay_fee;
            parameters[41].Value = model.pack_fee;
            parameters[42].Value = model.card_fee;
            parameters[43].Value = model.money_paid;
            parameters[44].Value = model.surplus;
            parameters[45].Value = model.integral;
            parameters[46].Value = model.integral_money;
            parameters[47].Value = model.bonus;
            parameters[48].Value = model.order_amount;
            parameters[49].Value = model.from_ad;
            parameters[50].Value = model.referer;
            parameters[51].Value = model.add_time;
            parameters[52].Value = model.confirm_time;
            parameters[53].Value = model.pay_time;
            parameters[54].Value = model.shipping_time;
            parameters[55].Value = model.pack_id;
            parameters[56].Value = model.card_id;
            parameters[57].Value = model.bonus_id;
            parameters[58].Value = model.invoice_no;
            parameters[59].Value = model.extension_code;
            parameters[60].Value = model.extension_id;
            parameters[61].Value = model.to_buyer;
            parameters[62].Value = model.pay_note;
            parameters[63].Value = model.agency_id;
            parameters[64].Value = model.inv_type;
            parameters[65].Value = model.inv_no;
            parameters[66].Value = model.tax;
            parameters[67].Value = model.is_separate;
            parameters[68].Value = model.parent_id;
            parameters[69].Value = model.discount;
            parameters[70].Value = model.shipname;
            parameters[71].Value = model.affirm_time;
            parameters[72].Value = model.need_inv;
            parameters[73].Value = model.is_send2_erp;
            parameters[74].Value = model.is_send2_cwerp;
            parameters[75].Value = model.is_wuliu_img;
            parameters[76].Value = model.get_pay_type;
            parameters[77].Value = model.is_daifa;
            parameters[78].Value = model.is_no_qingdan;
            parameters[79].Value = model.admin_user_id;
            parameters[80].Value = model.admin_user_name;
            parameters[81].Value = model.admin_user_real_name;
            parameters[82].Value = model.send_user_name;
            parameters[83].Value = model.send_user_tel;
            parameters[84].Value = model.send_user_company;
            parameters[85].Value = model.send_user_address;
            parameters[86].Value = model.cangku_id;
            parameters[87].Value = model.payinfo_pic;
            parameters[88].Value = model.is_confirm_remind;
            parameters[89].Value = model.is_print_remind;
            parameters[90].Value = model.order_ip;
            parameters[91].Value = model.cwerp_time;
            parameters[92].Value = model.erp_time;
            parameters[93].Value = model.is_need_review;
            parameters[94].Value = model.review_info;
            parameters[95].Value = model.Operator;
            parameters[96].Value = model.det_stats;
            parameters[97].Value = model.dealer_id;
            parameters[98].Value = model.is_show_price;
            parameters[99].Value = model.operator_user_id;
            parameters[100].Value = model.file_url;
            parameters[101].Value = model.invoice_weight;
            parameters[102].Value = model.order_confirm_info;
            parameters[103].Value = model.is_invoce;
            parameters[104].Value = model.jz;
            parameters[105].Value = model.SKSM;
            parameters[106].Value = model.ztidh;
            parameters[107].Value = model.djhm;
            parameters[108].Value = model.lsh;
            parameters[109].Value = model.hxje;
            parameters[110].Value = model.whxje;
            parameters[111].Value = model.fplx;
            parameters[112].Value = model.hslx;
            parameters[113].Value = model.pzhm;
            parameters[114].Value = model.je;
            parameters[115].Value = model.shenji;

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
        public bool Update(XHD.Model.ecs_order_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_order_info set ");
            strSql.Append("order_sn=@order_sn,");
            strSql.Append("erp_order_sn=@erp_order_sn,");
            strSql.Append("cwerp_order_sn=@cwerp_order_sn,");
            strSql.Append("wms_order_sn=@wms_order_sn,");
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
            strSql.Append("best_time=@best_time,");
            strSql.Append("sign_building=@sign_building,");
            strSql.Append("postscript=@postscript,");
            strSql.Append("shipping_id=@shipping_id,");
            strSql.Append("shipping_name=@shipping_name,");
            strSql.Append("is_no_shipping_fee=@is_no_shipping_fee,");
            strSql.Append("pay_id=@pay_id,");
            strSql.Append("pay_name=@pay_name,");
            strSql.Append("trans_bank_id=@trans_bank_id,");
            strSql.Append("trans_bank_name=@trans_bank_name,");
            strSql.Append("how_oos=@how_oos,");
            strSql.Append("how_surplus=@how_surplus,");
            strSql.Append("pack_name=@pack_name,");
            strSql.Append("card_name=@card_name,");
            strSql.Append("card_message=@card_message,");
            strSql.Append("inv_payee=@inv_payee,");
            strSql.Append("inv_content=@inv_content,");
            strSql.Append("goods_amount=@goods_amount,");
            strSql.Append("shipping_fee=@shipping_fee,");
            strSql.Append("insure_fee=@insure_fee,");
            strSql.Append("pay_fee=@pay_fee,");
            strSql.Append("pack_fee=@pack_fee,");
            strSql.Append("card_fee=@card_fee,");
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
            strSql.Append("extension_code=@extension_code,");
            strSql.Append("extension_id=@extension_id,");
            strSql.Append("to_buyer=@to_buyer,");
            strSql.Append("pay_note=@pay_note,");
            strSql.Append("agency_id=@agency_id,");
            strSql.Append("inv_type=@inv_type,");
            strSql.Append("inv_no=@inv_no,");
            strSql.Append("tax=@tax,");
            strSql.Append("is_separate=@is_separate,");
            strSql.Append("parent_id=@parent_id,");
            strSql.Append("discount=@discount,");
            strSql.Append("shipname=@shipname,");
            strSql.Append("affirm_time=@affirm_time,");
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
            strSql.Append("operator=@operator,");
            strSql.Append("det_stats=@det_stats,");
            strSql.Append("dealer_id=@dealer_id,");
            strSql.Append("is_show_price=@is_show_price,");
            strSql.Append("operator_user_id=@operator_user_id,");
            strSql.Append("file_url=@file_url,");
            strSql.Append("invoice_weight=@invoice_weight,");
            strSql.Append("order_confirm_info=@order_confirm_info,");
            strSql.Append("is_invoce=@is_invoce,");
            strSql.Append("jz=@jz,");
            strSql.Append("SKSM=@SKSM,");
            strSql.Append("ztidh=@ztidh,");
            strSql.Append("djhm=@djhm,");
            strSql.Append("lsh=@lsh,");
            strSql.Append("hxje=@hxje,");
            strSql.Append("whxje=@whxje,");
            strSql.Append("fplx=@fplx,");
            strSql.Append("hslx=@hslx,");
            strSql.Append("pzhm=@pzhm,");
            strSql.Append("je=@je,");
            strSql.Append("shenji=@shenji");
            strSql.Append(" where order_id=@order_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@erp_order_sn", MySqlDbType.VarChar,30),
					new MySqlParameter("@cwerp_order_sn", MySqlDbType.VarChar,32),
					new MySqlParameter("@wms_order_sn", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_id", MySqlDbType.Int32,8),
					new MySqlParameter("@order_status", MySqlDbType.Int32,2),
					new MySqlParameter("@shipping_status", MySqlDbType.Int32,1),
					new MySqlParameter("@pay_status", MySqlDbType.Int32,1),
					new MySqlParameter("@consignee", MySqlDbType.VarChar,60),
					new MySqlParameter("@country", MySqlDbType.Int32,5),
					new MySqlParameter("@province", MySqlDbType.Int32,5),
					new MySqlParameter("@city", MySqlDbType.Int32,5),
					new MySqlParameter("@district", MySqlDbType.Int32,5),
					new MySqlParameter("@address", MySqlDbType.VarChar,255),
					new MySqlParameter("@role_id", MySqlDbType.Int32,5),
					new MySqlParameter("@user_market_area", MySqlDbType.Int32,5),
					new MySqlParameter("@zipcode", MySqlDbType.VarChar,60),
					new MySqlParameter("@tel", MySqlDbType.VarChar,60),
					new MySqlParameter("@mobile", MySqlDbType.VarChar,60),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@best_time", MySqlDbType.VarChar,120),
					new MySqlParameter("@sign_building", MySqlDbType.VarChar,120),
					new MySqlParameter("@postscript", MySqlDbType.VarChar,255),
					new MySqlParameter("@shipping_id", MySqlDbType.Int32,3),
					new MySqlParameter("@shipping_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@is_no_shipping_fee", MySqlDbType.Int32,2),
					new MySqlParameter("@pay_id", MySqlDbType.Int32,3),
					new MySqlParameter("@pay_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@trans_bank_id", MySqlDbType.Int32,3),
					new MySqlParameter("@trans_bank_name", MySqlDbType.VarChar,128),
					new MySqlParameter("@how_oos", MySqlDbType.VarChar,120),
					new MySqlParameter("@how_surplus", MySqlDbType.VarChar,120),
					new MySqlParameter("@pack_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@card_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@card_message", MySqlDbType.VarChar,255),
					new MySqlParameter("@inv_payee", MySqlDbType.VarChar,120),
					new MySqlParameter("@inv_content", MySqlDbType.VarChar,120),
					new MySqlParameter("@goods_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipping_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@insure_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@pay_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@pack_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@card_fee", MySqlDbType.Decimal,10),
					new MySqlParameter("@money_paid", MySqlDbType.Decimal,10),
					new MySqlParameter("@surplus", MySqlDbType.Decimal,10),
					new MySqlParameter("@integral", MySqlDbType.Int32,10),
					new MySqlParameter("@integral_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@bonus", MySqlDbType.Decimal,10),
					new MySqlParameter("@order_amount", MySqlDbType.Decimal,10),
					new MySqlParameter("@from_ad", MySqlDbType.Int32,5),
					new MySqlParameter("@referer", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.Int32,10),
					new MySqlParameter("@confirm_time", MySqlDbType.Int32,10),
					new MySqlParameter("@pay_time", MySqlDbType.Int32,10),
					new MySqlParameter("@shipping_time", MySqlDbType.Int32,10),
					new MySqlParameter("@pack_id", MySqlDbType.Int32,3),
					new MySqlParameter("@card_id", MySqlDbType.Int32,3),
					new MySqlParameter("@bonus_id", MySqlDbType.Int32,8),
					new MySqlParameter("@invoice_no", MySqlDbType.VarChar,600),
					new MySqlParameter("@extension_code", MySqlDbType.VarChar,30),
					new MySqlParameter("@extension_id", MySqlDbType.Int32,8),
					new MySqlParameter("@to_buyer", MySqlDbType.VarChar,255),
					new MySqlParameter("@pay_note", MySqlDbType.VarChar,255),
					new MySqlParameter("@agency_id", MySqlDbType.Int32,5),
					new MySqlParameter("@inv_type", MySqlDbType.VarChar,60),
					new MySqlParameter("@inv_no", MySqlDbType.VarChar,32),
					new MySqlParameter("@tax", MySqlDbType.Decimal,10),
					new MySqlParameter("@is_separate", MySqlDbType.Int32,1),
					new MySqlParameter("@parent_id", MySqlDbType.Int32,8),
					new MySqlParameter("@discount", MySqlDbType.Decimal,10),
					new MySqlParameter("@shipname", MySqlDbType.VarChar,255),
					new MySqlParameter("@affirm_time", MySqlDbType.Int32,10),
					new MySqlParameter("@need_inv", MySqlDbType.Int32,1),
					new MySqlParameter("@is_send2_erp", MySqlDbType.Int32,1),
					new MySqlParameter("@is_send2_cwerp", MySqlDbType.Int32,1),
					new MySqlParameter("@is_wuliu_img", MySqlDbType.Text),
					new MySqlParameter("@get_pay_type", MySqlDbType.VarChar,60),
					new MySqlParameter("@is_daifa", MySqlDbType.Int32,2),
					new MySqlParameter("@is_no_qingdan", MySqlDbType.Int32,2),
					new MySqlParameter("@admin_user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@admin_user_real_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_tel", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_company", MySqlDbType.VarChar,30),
					new MySqlParameter("@send_user_address", MySqlDbType.VarChar,30),
					new MySqlParameter("@cangku_id", MySqlDbType.VarChar,30),
					new MySqlParameter("@payinfo_pic", MySqlDbType.Text),
					new MySqlParameter("@is_confirm_remind", MySqlDbType.Int32,4),
					new MySqlParameter("@is_print_remind", MySqlDbType.Int32,4),
					new MySqlParameter("@order_ip", MySqlDbType.VarChar,30),
					new MySqlParameter("@cwerp_time", MySqlDbType.VarChar,32),
					new MySqlParameter("@erp_time", MySqlDbType.VarChar,32),
					new MySqlParameter("@is_need_review", MySqlDbType.Int32,2),
					new MySqlParameter("@review_info", MySqlDbType.VarChar,100),
					new MySqlParameter("@operator", MySqlDbType.VarChar,6),
					new MySqlParameter("@det_stats", MySqlDbType.VarChar,2),
					new MySqlParameter("@dealer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@is_show_price", MySqlDbType.Int32,1),
					new MySqlParameter("@operator_user_id", MySqlDbType.Int32,8),
					new MySqlParameter("@file_url", MySqlDbType.VarChar,100),
					new MySqlParameter("@invoice_weight", MySqlDbType.VarChar,255),
					new MySqlParameter("@order_confirm_info", MySqlDbType.VarChar,1000),
					new MySqlParameter("@is_invoce", MySqlDbType.Int32,1),
					new MySqlParameter("@jz", MySqlDbType.VarChar,255),
					new MySqlParameter("@SKSM", MySqlDbType.VarChar,100),
					new MySqlParameter("@ztidh", MySqlDbType.Int32,3),
					new MySqlParameter("@djhm", MySqlDbType.Decimal,18),
					new MySqlParameter("@lsh", MySqlDbType.Decimal,18),
					new MySqlParameter("@hxje", MySqlDbType.Decimal,18),
					new MySqlParameter("@whxje", MySqlDbType.Decimal,18),
					new MySqlParameter("@fplx", MySqlDbType.VarChar,50),
					new MySqlParameter("@hslx", MySqlDbType.VarChar,50),
					new MySqlParameter("@pzhm", MySqlDbType.Int32,11),
					new MySqlParameter("@je", MySqlDbType.Decimal,18),
					new MySqlParameter("@shenji", MySqlDbType.VarChar,20),
					new MySqlParameter("@order_id", MySqlDbType.Int32,8)};
            parameters[0].Value = model.order_sn;
            parameters[1].Value = model.erp_order_sn;
            parameters[2].Value = model.cwerp_order_sn;
            parameters[3].Value = model.wms_order_sn;
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
            parameters[20].Value = model.best_time;
            parameters[21].Value = model.sign_building;
            parameters[22].Value = model.postscript;
            parameters[23].Value = model.shipping_id;
            parameters[24].Value = model.shipping_name;
            parameters[25].Value = model.is_no_shipping_fee;
            parameters[26].Value = model.pay_id;
            parameters[27].Value = model.pay_name;
            parameters[28].Value = model.trans_bank_id;
            parameters[29].Value = model.trans_bank_name;
            parameters[30].Value = model.how_oos;
            parameters[31].Value = model.how_surplus;
            parameters[32].Value = model.pack_name;
            parameters[33].Value = model.card_name;
            parameters[34].Value = model.card_message;
            parameters[35].Value = model.inv_payee;
            parameters[36].Value = model.inv_content;
            parameters[37].Value = model.goods_amount;
            parameters[38].Value = model.shipping_fee;
            parameters[39].Value = model.insure_fee;
            parameters[40].Value = model.pay_fee;
            parameters[41].Value = model.pack_fee;
            parameters[42].Value = model.card_fee;
            parameters[43].Value = model.money_paid;
            parameters[44].Value = model.surplus;
            parameters[45].Value = model.integral;
            parameters[46].Value = model.integral_money;
            parameters[47].Value = model.bonus;
            parameters[48].Value = model.order_amount;
            parameters[49].Value = model.from_ad;
            parameters[50].Value = model.referer;
            parameters[51].Value = model.add_time;
            parameters[52].Value = model.confirm_time;
            parameters[53].Value = model.pay_time;
            parameters[54].Value = model.shipping_time;
            parameters[55].Value = model.pack_id;
            parameters[56].Value = model.card_id;
            parameters[57].Value = model.bonus_id;
            parameters[58].Value = model.invoice_no;
            parameters[59].Value = model.extension_code;
            parameters[60].Value = model.extension_id;
            parameters[61].Value = model.to_buyer;
            parameters[62].Value = model.pay_note;
            parameters[63].Value = model.agency_id;
            parameters[64].Value = model.inv_type;
            parameters[65].Value = model.inv_no;
            parameters[66].Value = model.tax;
            parameters[67].Value = model.is_separate;
            parameters[68].Value = model.parent_id;
            parameters[69].Value = model.discount;
            parameters[70].Value = model.shipname;
            parameters[71].Value = model.affirm_time;
            parameters[72].Value = model.need_inv;
            parameters[73].Value = model.is_send2_erp;
            parameters[74].Value = model.is_send2_cwerp;
            parameters[75].Value = model.is_wuliu_img;
            parameters[76].Value = model.get_pay_type;
            parameters[77].Value = model.is_daifa;
            parameters[78].Value = model.is_no_qingdan;
            parameters[79].Value = model.admin_user_id;
            parameters[80].Value = model.admin_user_name;
            parameters[81].Value = model.admin_user_real_name;
            parameters[82].Value = model.send_user_name;
            parameters[83].Value = model.send_user_tel;
            parameters[84].Value = model.send_user_company;
            parameters[85].Value = model.send_user_address;
            parameters[86].Value = model.cangku_id;
            parameters[87].Value = model.payinfo_pic;
            parameters[88].Value = model.is_confirm_remind;
            parameters[89].Value = model.is_print_remind;
            parameters[90].Value = model.order_ip;
            parameters[91].Value = model.cwerp_time;
            parameters[92].Value = model.erp_time;
            parameters[93].Value = model.is_need_review;
            parameters[94].Value = model.review_info;
            parameters[95].Value = model.Operator;
            parameters[96].Value = model.det_stats;
            parameters[97].Value = model.dealer_id;
            parameters[98].Value = model.is_show_price;
            parameters[99].Value = model.operator_user_id;
            parameters[100].Value = model.file_url;
            parameters[101].Value = model.invoice_weight;
            parameters[102].Value = model.order_confirm_info;
            parameters[103].Value = model.is_invoce;
            parameters[104].Value = model.jz;
            parameters[105].Value = model.SKSM;
            parameters[106].Value = model.ztidh;
            parameters[107].Value = model.djhm;
            parameters[108].Value = model.lsh;
            parameters[109].Value = model.hxje;
            parameters[110].Value = model.whxje;
            parameters[111].Value = model.fplx;
            parameters[112].Value = model.hslx;
            parameters[113].Value = model.pzhm;
            parameters[114].Value = model.je;
            parameters[115].Value = model.shenji;
            parameters[116].Value = model.order_id;

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
        public bool Delete(int order_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_order_info ");
            strSql.Append(" where order_id=@order_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int32,8)
			};
            parameters[0].Value = order_id;

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
        public bool DeleteList(string order_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_order_info ");
            strSql.Append(" where order_id in (" + order_idlist + ")  ");
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
        public XHD.Model.ecs_order_info GetModel(int order_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select order_id,order_sn,erp_order_sn,cwerp_order_sn,wms_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,best_time,sign_building,postscript,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,how_oos,how_surplus,pack_name,card_name,card_message,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,card_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,extension_code,extension_id,to_buyer,pay_note,agency_id,inv_type,inv_no,tax,is_separate,parent_id,discount,shipname,affirm_time,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,operator,det_stats,dealer_id,is_show_price,operator_user_id,file_url,invoice_weight,order_confirm_info,is_invoce,jz,SKSM,ztidh,djhm,lsh,hxje,whxje,fplx,hslx,pzhm,je,shenji from ecs_order_info ");
            strSql.Append(" where order_id=@order_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int32,8)
			};
            parameters[0].Value = order_id;

            XHD.Model.ecs_order_info model = new XHD.Model.ecs_order_info();
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
        public XHD.Model.ecs_order_info DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_order_info model = new XHD.Model.ecs_order_info();
            if (row != null)
            {
                //model.order_id=row["order_id"].ToString();
                if (row["order_sn"] != null)
                {
                    model.order_sn = row["order_sn"].ToString();
                }
                if (row["erp_order_sn"] != null)
                {
                    model.erp_order_sn = row["erp_order_sn"].ToString();
                }
                if (row["cwerp_order_sn"] != null)
                {
                    model.cwerp_order_sn = row["cwerp_order_sn"].ToString();
                }
                if (row["wms_order_sn"] != null)
                {
                    model.wms_order_sn = row["wms_order_sn"].ToString();
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
                if (row["user_market_area"] != null && row["user_market_area"].ToString() != "")
                {
                    model.user_market_area = int.Parse(row["user_market_area"].ToString());
                }
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
                if (row["best_time"] != null)
                {
                    model.best_time = row["best_time"].ToString();
                }
                if (row["sign_building"] != null)
                {
                    model.sign_building = row["sign_building"].ToString();
                }
                if (row["postscript"] != null)
                {
                    model.postscript = row["postscript"].ToString();
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
                if (row["how_oos"] != null)
                {
                    model.how_oos = row["how_oos"].ToString();
                }
                if (row["how_surplus"] != null)
                {
                    model.how_surplus = row["how_surplus"].ToString();
                }
                if (row["pack_name"] != null)
                {
                    model.pack_name = row["pack_name"].ToString();
                }
                if (row["card_name"] != null)
                {
                    model.card_name = row["card_name"].ToString();
                }
                if (row["card_message"] != null)
                {
                    model.card_message = row["card_message"].ToString();
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
                if (row["card_fee"] != null && row["card_fee"].ToString() != "")
                {
                    model.card_fee = decimal.Parse(row["card_fee"].ToString());
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
                if (row["extension_code"] != null)
                {
                    model.extension_code = row["extension_code"].ToString();
                }
                //model.extension_id=row["extension_id"].ToString();
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
                if (row["inv_no"] != null)
                {
                    model.inv_no = row["inv_no"].ToString();
                }
                if (row["tax"] != null && row["tax"].ToString() != "")
                {
                    model.tax = decimal.Parse(row["tax"].ToString());
                }
                if (row["is_separate"] != null && row["is_separate"].ToString() != "")
                {
                    model.is_separate = int.Parse(row["is_separate"].ToString());
                }
                //model.parent_id=row["parent_id"].ToString();
                if (row["discount"] != null && row["discount"].ToString() != "")
                {
                    model.discount = decimal.Parse(row["discount"].ToString());
                }
                if (row["shipname"] != null)
                {
                    model.shipname = row["shipname"].ToString();
                }
                if (row["affirm_time"] != null && row["affirm_time"].ToString() != "")
                {
                    model.affirm_time = int.Parse(row["affirm_time"].ToString());
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
                if (row["operator"] != null)
                {
                    model.Operator = row["operator"].ToString();
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
                if (row["file_url"] != null)
                {
                    model.file_url = row["file_url"].ToString();
                }
                if (row["invoice_weight"] != null)
                {
                    model.invoice_weight = row["invoice_weight"].ToString();
                }
                if (row["order_confirm_info"] != null)
                {
                    model.order_confirm_info = row["order_confirm_info"].ToString();
                }
                if (row["is_invoce"] != null && row["is_invoce"].ToString() != "")
                {
                    model.is_invoce = int.Parse(row["is_invoce"].ToString());
                }
                if (row["jz"] != null)
                {
                    model.jz = row["jz"].ToString();
                }
                if (row["SKSM"] != null)
                {
                    model.SKSM = row["SKSM"].ToString();
                }
                if (row["ztidh"] != null && row["ztidh"].ToString() != "")
                {
                    model.ztidh = int.Parse(row["ztidh"].ToString());
                }
                if (row["djhm"] != null && row["djhm"].ToString() != "")
                {
                    model.djhm = decimal.Parse(row["djhm"].ToString());
                }
                if (row["lsh"] != null && row["lsh"].ToString() != "")
                {
                    model.lsh = decimal.Parse(row["lsh"].ToString());
                }
                if (row["hxje"] != null && row["hxje"].ToString() != "")
                {
                    model.hxje = decimal.Parse(row["hxje"].ToString());
                }
                if (row["whxje"] != null && row["whxje"].ToString() != "")
                {
                    model.whxje = decimal.Parse(row["whxje"].ToString());
                }
                if (row["fplx"] != null)
                {
                    model.fplx = row["fplx"].ToString();
                }
                if (row["hslx"] != null)
                {
                    model.hslx = row["hslx"].ToString();
                }
                if (row["pzhm"] != null && row["pzhm"].ToString() != "")
                {
                    model.pzhm = int.Parse(row["pzhm"].ToString());
                }
                if (row["je"] != null && row["je"].ToString() != "")
                {
                    model.je = decimal.Parse(row["je"].ToString());
                }
                if (row["shenji"] != null)
                {
                    model.shenji = row["shenji"].ToString();
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
            strSql.Append("select order_id,order_sn,erp_order_sn,cwerp_order_sn,wms_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,best_time,sign_building,postscript,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,how_oos,how_surplus,pack_name,card_name,card_message,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,card_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,extension_code,extension_id,to_buyer,pay_note,agency_id,inv_type,inv_no,tax,is_separate,parent_id,discount,shipname,affirm_time,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,operator,det_stats,dealer_id,is_show_price,operator_user_id,file_url,invoice_weight,order_confirm_info,is_invoce,jz,SKSM,ztidh,djhm,lsh,hxje,whxje,fplx,hslx,pzhm,je,shenji ");
            strSql.Append(" FROM ecs_order_info ");
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
            strSql.Append("select count(1) FROM ecs_order_info ");
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
                strSql.Append("order by T.order_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_order_info T ");
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
            strSql.Append("select order_id,order_sn,erp_order_sn,cwerp_order_sn,wms_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,best_time,sign_building,postscript,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,how_oos,how_surplus,pack_name,card_name,card_message,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,card_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,extension_code,extension_id,to_buyer,pay_note,agency_id,inv_type,inv_no,tax,is_separate,parent_id,discount,shipname,affirm_time,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,operator,det_stats,dealer_id,is_show_price,operator_user_id,file_url,invoice_weight,order_confirm_info,is_invoce,jz,SKSM,ztidh,djhm,lsh,hxje,whxje,fplx,hslx,pzhm,je,shenji FROM ecs_order_info ");
            strSql1.Append(" select count(1) FROM ecs_order_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //根据crm_customer.id查询
        public DataSet GetList2(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select o.order_id,o.order_sn,o.user_id,o.order_status,o.shipping_status,o.pay_status,o.add_time,o.consignee,o.tel,o.province,o.city,o.district,o.address,o.goods_amount,o.order_amount,u.user_name,u.u_company,u.u_real_name FROM ecs_order_info as o");
            strSql.Append(" inner join ecs_users as u on o.user_id = u.user_id");
            strSql1.Append(" select count(1) FROM ecs_order_info as o inner join ecs_users as u on o.user_id = u.user_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("  inner join crm_contact as c on u.user_name=c.C_tel and c.C_customerid=" + strWhere);
                strSql1.Append(" inner join crm_contact as c on u.user_name=c.C_tel and c.C_customerid=" + strWhere);
                //strSql1.Append(" where u.user_name in");
                //strSql.Append(" where u.user_name in");
                //strSql.Append("(select C_tel ");
                //strSql.Append("from crm_contact");
                //strSql.Append(" where " + strWhere + ")");
                //strSql1.Append(" where u.user_name in");
                //strSql1.Append("(select C_tel ");
                //strSql1.Append("from crm_contact");
                //strSql1.Append(" where " + strWhere + ")");
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList1(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select o.order_id,o.order_sn,o.user_id,o.order_status,o.shipping_status,o.pay_status,o.add_time,o.consignee,o.tel,o.province,o.city,o.district,o.address,o.goods_amount,o.order_amount,u.user_name,u.u_company,u.u_real_name FROM ecs_order_info as o");
            strSql.Append(" inner join ecs_users as u on o.user_id = u.user_id");
            strSql1.Append(" select count(1) FROM ecs_order_info as o inner join ecs_users as u on o.user_id = u.user_id ");
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
        /// 根据id获取地区名称
        /// </summary>
        public DataSet addressName(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select region_id,parent_id,region_name,region_type,agency_id ");
            strSql.Append(" FROM ecs_region ");
            strSql.Append(" where region_id=" + id);
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取当前业绩走势
        /// </summary>
        public DataSet getCurData(int daytime, int pretime, int curtime)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" SELECT ");
            strSql.Append(" 		IFNULL(sum(goods_amount),0) as feat,FROM_UNIXTIME(erp_time) as datetime,erp_time,1 as type ");
            strSql.Append(" FROM ");
            strSql.Append(" 	ecs_order_info ");
            strSql.Append(" WHERE ");
            strSql.Append(" 	erp_time < " + pretime);
            strSql.Append(" AND erp_time>=" + daytime);
            strSql.Append(" AND order_status != 9 ");
            strSql.Append(" UNION ALL ");
            strSql.Append(" SELECT ");
            strSql.Append(" 	sum(goods_amount),FROM_UNIXTIME(erp_time) as datetime,erp_time,2 as type ");
            strSql.Append(" FROM ");
            strSql.Append(" 	ecs_order_info ");
            strSql.Append(" WHERE ");
            strSql.Append(" 	erp_time BETWEEN " + pretime);
            strSql.Append(" AND " + curtime);
            strSql.Append(" AND order_status != 9 ");
            strSql.Append(" GROUP BY FROM_UNIXTIME(erp_time) ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取当前业绩走势
        /// </summary>
        public DataSet getMonthData(int starttime, int endtime)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("  SELECT ");
            strSql.Append(" 	IFNULL(sum(goods_amount), 0) AS feat, ");
            strSql.Append(" 	count(order_id) orderNum, ");
            strSql.Append(" 	FROM_UNIXTIME(erp_time, '%y-%m-%d') AS date, ");
            strSql.Append(" 	FROM_UNIXTIME(erp_time, '%d') AS daytime ");
            strSql.Append(" FROM ");
            strSql.Append(" 	xmh_shop.shop_order_info ");
            strSql.Append(" WHERE ");
            strSql.Append(" 	erp_time BETWEEN  " + starttime);
            strSql.Append(" AND " + endtime);
            strSql.Append(" AND order_status != 9 ");
            strSql.Append(" GROUP BY ");
            strSql.Append(" 	FROM_UNIXTIME(erp_time, '%y-%m-%d') ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet getMonthDms(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("  SELECT ");
            strSql.Append(" 	IFNULL(sum(salemoney), 0) AS feat, ");
            strSql.Append(" 	count(id) orderNum, ");
            strSql.Append(" 	datetime AS date, ");
            strSql.Append(" 	orderdate AS daytime ");
            strSql.Append(" FROM ");
            strSql.Append(" 	dms_order ");
            strSql.Append(" WHERE ");
            strSql.Append(" 	datetime like  '" + yearMonth+"%'");
            strSql.Append(" GROUP BY orderdate");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取10后的业绩
        /// </summary>
        public DataSet getWillData(int curtime)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" SELECT ");
            strSql.Append(" 	ifnull(sum(goods_amount),0) as feat");
            strSql.Append(" FROM ");
            strSql.Append(" 	ecs_order_info ");
            strSql.Append(" WHERE ");
            strSql.Append(" 	erp_time > " + curtime);
            strSql.Append(" AND erp_time <= " + (curtime + 10));
            strSql.Append(" AND order_status != 9 ");

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
            parameters[0].Value = "ecs_order_info";
            parameters[1].Value = "order_id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod

        #region  ExtensionMethod

        #region  das图3
        //--------------------------------地图3---------------------------------------------------------------

        /// <summary>
        /// 获得当日城市订单curdate()
        /// </summary>
        public DataSet GetTodayCityAmt(string date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.region_name as name,sum(o.goods_amount) as value from ecs_order_info as o LEFT JOIN param_area as a on o.city=a.region_id ");
            strSql.Append("where erp_time<>0 and order_status <>9 and from_unixtime(erp_time, '%Y-%m-%d') = '" + date + "' GROUP BY region_name ORDER BY value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得当日城市订单curdate()
        /// </summary>
        public DataSet GetCityAmt()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.region_name as name,sum(o.goods_amount) as value from ecs_order_info as o LEFT JOIN param_area as a on o.city=a.region_id ");
            strSql.Append("where erp_order_sn<>'' and order_status <>9 and region_name is not null GROUP BY name ORDER BY value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得当日省份订单curdate()
        /// </summary>
        public DataSet GetTodayProvinceAmt(string date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.region_name as name,sum(o.goods_amount) as value from ecs_order_info as o LEFT JOIN param_area as a on o.province=a.region_id ");
            strSql.Append("where erp_order_sn<>'' and order_status <>9 and from_unixtime(erp_time, '%Y-%m-%d') = '" + date + "' GROUP BY name ORDER BY value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion


        #region 省份城市年报

        #endregion

        #region 省份城市月报
        /// <summary>
        /// 获得当月城市订单，模糊查询单品文本框下拉列表
        /// </summary>
        public DataSet GetMonthGoodTxt(string keyWord, string yearMonth, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" SELECT * from ");
            strSql.Append(" ( ");
            strSql.Append(" SELECT g.brand_id,bd.brand_name, ");
            strSql.Append(" case when bp_brand_id is null or bp_brand_id='' then 0 else bp_brand_id end bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" sum(og.goods_number) goods_number,g.goods_id,g.goods_name ");
            strSql.Append(" FROM ecs_order_goods AS og ");
            strSql.Append(" left join ecs_goods AS g ON g.goods_id=og.goods_id ");
            strSql.Append(" left join ecs_order_info AS oi ON oi.order_id=og.order_id ");
            strSql.Append(" left join ecs_brand as bd on g.brand_id=bd.brand_id ");
            strSql.Append(" LEFT JOIN  ecs_brand_percentage as bp ON g.brand_id=bp.bp_brand_id ");
            strSql.Append(" where oi.order_status !=9 AND erp_order_sn LIKE '%" + yearMonth + "%' ");
            strSql.Append(" AND erp_time<>0 and g.goods_id is not null and g.goods_name like '%" + keyWord + "%' ");
            strSql.Append(" group by goods_id ");
            strSql.Append(" ) tt  ");
            strSql.Append(" " + qtBrand + " ");
            strSql.Append(" order by goods_number desc  limit 50 ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得当月城市订单
        /// </summary>
        public DataSet GetMonthCityAmt(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth,"");
            strSql.Append("SELECT a.region_id id,a.region_name as name,sum(salemoney) as value  ");
            strSql.Append(" from hr_employee as emp ");

            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + ") AS abc ON emp.emp_code=abc.admin_user_name");

            strSql.Append(" LEFT JOIN param_area as a on abc.city=a.region_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY region_name ORDER BY value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得当月省份订单
        /// </summary>
        public DataSet GetMonthProvinceAmt(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, "");


            if (qtBrand != " where 1=1 ")
            {
                strSql.Append("SELECT aabb.*, brandValue/allValue*100 zb FROM(  ");
                strSql.Append(" SELECT allId,allName,allValue,case when brandValue is null then 0 else brandValue end brandValue from ( ");

                strSql.Append("SELECT a.region_id allId,a.region_name as allName,sum(salemoney) as allValue  ");
                strSql.Append(" from hr_employee as emp ");
                strSql.Append(" left join (" + mapMonthBrandSql + ") AS abc ON emp.emp_code=abc.admin_user_name");
                strSql.Append(" LEFT JOIN param_area as a on abc.province=a.region_id ");
                strSql.Append(" where " + strSqlOne + " and datetime is not null");
                strSql.Append(" GROUP BY region_name ORDER BY allValue desc) aa");

                strSql.Append(" LEFT JOIN ( ");

                strSql.Append("SELECT a.region_name as brandName,sum(salemoney) as brandValue  ");
                strSql.Append(" from hr_employee as emp ");
                strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + ") AS abc ON emp.emp_code=abc.admin_user_name");

                strSql.Append(" LEFT JOIN param_area as a on abc.province=a.region_id ");
                strSql.Append(" where " + strSqlOne + " and datetime is not null");
                strSql.Append(" GROUP BY region_name)bb ");
                strSql.Append("  on aa.allName=bb.brandName) aabb");

            }
            else
            {
                strSql.Append("SELECT a.region_id allId,a.region_name as allName,sum(salemoney) as allValue  ");
                strSql.Append(" from hr_employee as emp ");
                strSql.Append(" left join (" + mapMonthBrandSql + ") AS abc ON emp.emp_code=abc.admin_user_name");
                strSql.Append(" LEFT JOIN param_area as a on abc.province=a.region_id ");
                strSql.Append(" where " + strSqlOne + " and datetime is not null");
                strSql.Append(" GROUP BY region_name ORDER BY allValue desc");
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }



        #region 省份月报

        /// <summary>
        /// 获得省份下月份对比
        /// </summary>
        public DataSet GetProvinceYear_Months(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapYearMonths(yearMonth, " and province=" + provinceId);

            strSql.Append(" SELECT sum(salemoney) AS month_value,datetime  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY datetime ORDER BY month_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得省份下品牌比
        /// </summary>
        public DataSet GetProvinceMonth_Brand(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append(" SELECT brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY brand_name ORDER BY brand_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得省份下城市比
        /// </summary>
        public DataSet GetProvinceMonth_City(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append(" SELECT city city_id,a.region_name city_name,sum(salemoney) AS city_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" LEFT JOIN param_area as a on abc.city=a.region_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY city_id ORDER BY city_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得省份下品牌比
        /// </summary>
        public DataSet GetProvinceMonth_Good(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append(" SELECT goods_id,goods_name,sum(salemoney) AS goods_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY goods_name ORDER BY goods_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得省份下员工排名
        /// </summary>
        public DataSet GetProvinceMonth_Emp(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append(" SELECT name emp_name,sum(salemoney) AS emp_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY admin_user_name ORDER BY emp_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得省份下客户排名
        /// </summary>
        public DataSet GetProvinceMonth_Customer(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append("SELECT customer_id,customer_name,customer_value from (  ");
            strSql.Append(" SELECT abc.user_id customer_id,u_company customer_name,sum(salemoney) AS customer_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" LEFT JOIN ecs_users AS u ON abc.user_id=u.user_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY customer_id ORDER BY customer_value desc) abcd");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion



        #region 城市月报
        /// <summary>
        /// 获得城市下员工排名
        /// </summary>
        public DataSet GetCityYear_Months(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapYearMonths(yearMonth, " and city=" + cityId);

            strSql.Append(" SELECT sum(salemoney) AS month_value,datetime	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY datetime ORDER BY month_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得城市下员工排名
        /// </summary>
        public DataSet GetCityMonth_Brand(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, " and city=" + cityId);

            strSql.Append(" SELECT brand_id,brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY brand_name ORDER BY brand_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得城市下员工排名
        /// </summary>
        public DataSet GetCityMonth_Good(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, " and city=" + cityId);

            strSql.Append(" SELECT goods_id,goods_name,sum(salemoney) AS goods_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY goods_name ORDER BY goods_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得城市下员工排名
        /// </summary>
        public DataSet GetCityMonth_Emp(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, " and city=" + cityId);

            strSql.Append(" SELECT name emp_name,sum(salemoney) AS emp_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY admin_user_name ORDER BY emp_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得城市下客户排名
        /// </summary>
        public DataSet GetCityMonth_Customer(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string mapMonthBrandSql = GetMapMonthBrandSql(yearMonth, " and city=" + cityId);

            strSql.Append("SELECT customer_id,customer_name,customer_value from (  ");
            strSql.Append(" SELECT abc.user_id customer_id,u_company customer_name,sum(salemoney) AS customer_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + mapMonthBrandSql + qtBrand + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" LEFT JOIN ecs_users AS u ON abc.user_id=u.user_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" GROUP BY customer_id ORDER BY customer_value desc) abcd");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion



        #endregion



        #region  时间段销售数据
        //-------------------------时间段销售数据----------------------------------------------------------------------------------

        
        /// <summary>
        /// 1.个人月销售数据 
        /// </summary>
        public DataSet GetMonthSaleBackData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string monthColumns)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth, returnDateTime, returnTimeStamp);
            strSql.Append(" select * from (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,lpad(day(abc.datetime), 2, 0) as orderdate,admin_user_name,name");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne+ " and datetime is not null");
            strSql.Append(" group by orderdate");
            strSql.Append(" order by orderdate )ddd");

            strSql.Append(" left join (SELECT emp_code, CASE WHEN base." + monthColumns + " IS NULL THEN 0 ELSE base." + monthColumns + " END month_base,CASE WHEN plan." + monthColumns + " IS NULL THEN 0 ELSE plan." + monthColumns + " END month_plan");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" LEFT JOIN ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname");
            strSql.Append(" LEFT JOIN ecs_month_base AS base ON emp.emp_code=base.kf_uname");
            strSql.Append(" where " + strSqlOne );
            strSql.Append(" ) pb on pb.emp_code=ddd.admin_user_name");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 部门以及下面所有员工的1.销售数据，2.销售数据合计（分组），3.销售基数计划（注释部分为每个员工月内的总和，由于前台展示需要一个月份每一天的累加，所以放在前台js求值）,,,(二).选择权限内的个人月销售数据 
        /// </summary>
        public DataSet GetManagerMonthDepData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string monthColumns)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append("     select * from( ");
            strSql.Append("       select lpad(day(abc.datetime), 2, 0) as orderdate,'0' d_pid,'员工合计' d_pname, sum(salemoney) as salemoney, sum(backmoney) as backmoney, sum(salemoney+backmoney) as realmoney ");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append("       group by orderdate");
            strSql.Append(" union all");
            strSql.Append(" select lpad(day(abc.datetime), 2, 0) as orderdate, admin_user_name d_pid, name d_pname, ");
            strSql.Append(" 	sum(salemoney) as salemoney, sum(backmoney) as backmoney, sum(salemoney+backmoney) as realmoney");
            strSql.Append(" 	from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name, orderdate");
            strSql.Append(" 	order by convert(d_pid,signed), orderdate asc) ddd");

            strSql.Append(" left join (");
            strSql.Append(" select '0' d_pid1,'员工合计' d_pname1,sum(salemoney) as salemoney1, sum(backmoney) as backmoney1, sum(salemoney+backmoney) as realmoney1 ");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" union all");
            strSql.Append(" select  admin_user_name d_pid1, name d_pname1, ");
            strSql.Append(" 	sum(salemoney) as salemoney1, sum(backmoney) as backmoney1, sum(salemoney+backmoney) as realmoney1");
            strSql.Append(" 	from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name");
            strSql.Append(" 	order by convert(d_pid1,signed)");
            strSql.Append(" ) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" left join( ");
            strSql.Append(" select * from");
            strSql.Append("   (select '0' d_pid2, '员工合计' d_pname2,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from");
            strSql.Append("         (select case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("          from hr_employee as emp");
            strSql.Append("          left join ecs_per_plan as plan on emp.emp_code=plan.kf_uname");
            strSql.Append("          left join ecs_month_base as base on emp.emp_code=base.kf_uname");
            strSql.Append("          where " + strSqlOne + ") a )aa");
            strSql.Append(" union all");
            strSql.Append(" select emp_code d_pid2,name d_pname2,dep_month_base,dep_month_plan");
            strSql.Append(" from");
            strSql.Append("   (select emp_code,name,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan");
            strSql.Append("    from");
            strSql.Append("      (select emp_code,name, case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join ecs_per_plan as plan on emp.emp_code=plan.kf_uname");
            strSql.Append("       left join ecs_month_base as base on emp.emp_code=base.kf_uname");
            strSql.Append("       where " + strSqlOne + ") a");
            strSql.Append("    group by emp_code");
            strSql.Append("    order by emp_code) b");
            strSql.Append("  )pb on ddd.d_pid=pb.d_pid2");
            strSql.Append(" ) tt order by convert(d_pid,signed)");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 中心以及下面所有部门的1.销售数据，2.销售数据合计（分组），3.销售基数计划
        /// </summary>
        public DataSet GetMonthAllDepData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string monthColumns)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth, returnDateTime, returnTimeStamp);
            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append(" SELECT * from (");
            strSql.Append(" SELECT lpad(day(abc.datetime), 2, 0) AS orderdate,'0' d_pid,'全体部门' d_pname,sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" GROUP BY orderdate");
            strSql.Append(" union all ");
            strSql.Append(" SELECT orderdate, d_pid, d_pname,sum(salemoney) AS salemoney,sum(backmoney) AS backmoney,sum(salemoney+backmoney) AS realmoney from (");
            strSql.Append(" SELECT orderdate,salemoney,backmoney,realmoney,d_pid, d_name d_pname FROM");
            strSql.Append(" (SELECT salemoney, backmoney, salemoney+backmoney AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,lpad(day(abc.datetime), 2, 0) AS orderdate");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid, orderdate");
            strSql.Append(" ) ddd");

            strSql.Append(" LEFT JOIN (SELECT '0' d_pid1,'全体部门' d_pname1,sum(salemoney) AS salemoney1, sum(backmoney) AS backmoney1, sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" union all ");
            strSql.Append(" SELECT d_pid d_pid1, d_pname d_pname1,sum(salemoney) AS salemoney1,sum(backmoney) AS backmoney1,sum(salemoney+backmoney) AS realmoney1 from (");
            strSql.Append(" SELECT orderdate,salemoney,backmoney,realmoney,d_pid, d_name d_pname FROM");
            strSql.Append(" (SELECT sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,lpad(day(abc.datetime), 2, 0) AS orderdate");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" GROUP BY orderdate,admin_user_name");
            strSql.Append(" ORDER BY orderdate ASC");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" ORDER BY d_pid,admin_user_name,orderdate");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid1) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" left join (");
            strSql.Append("   select 0 as d_pid2,'全体部门' d_pname2,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan");
            strSql.Append("    from");
            strSql.Append("      (select case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join ecs_per_plan as plan on emp.emp_code=plan.kf_uname");
            strSql.Append("       left join ecs_month_base as base on emp.emp_code=base.kf_uname");
            strSql.Append("       WHERE " + strSqlOne + ") a");
            strSql.Append(" union all");
            strSql.Append(" select * from");
            strSql.Append("   (select d_pid d_pid2,d_name d_pname2,dep_month_base,dep_month_plan");
            strSql.Append("    from");
            strSql.Append("      (select d_pid,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan");
            strSql.Append("       from");
            strSql.Append("         (select case when parentid=1 then dep.id else parentid end d_pid, case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("          from hr_employee as emp");
            strSql.Append("          left join hr_department as dep on emp.d_id=dep.id");
            strSql.Append("          left join ecs_per_plan as plan on emp.emp_code=plan.kf_uname");
            strSql.Append("          left join ecs_month_base as base on emp.emp_code=base.kf_uname");
            strSql.Append("       WHERE " + strSqlOne + ") a");
            strSql.Append("       group by d_pid) b");
            strSql.Append("    left join hr_department as dep on b.d_pid=dep.id)aa");
            strSql.Append("    )pb on ddd.d_pid=pb.d_pid2 ");
            strSql.Append(" ) tt order by convert(d_pid,signed)");

            return DbHelperMySQL.Query(strSql.ToString());
        }



        //---------------------------------------------年报----

        /// <summary>
        /// 个人年报
        /// </summary>
        public DataSet GetYearSaleBackData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();

            string saleData = GetYearSaleDataSql(year, returnDateTime, returnTimeStamp);
            strSql.Append("select * from (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,datetime,admin_user_name,name");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime");
            strSql.Append(" order by datetime ASC) ddd");

            strSql.Append(" left join (SELECT emp_code, CASE WHEN base.plan_task IS NULL THEN 0 ELSE base.plan_task END year_base,CASE WHEN plan.plan_task IS NULL THEN 0 ELSE plan.plan_task END year_plan");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" LEFT JOIN ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname");
            strSql.Append(" LEFT JOIN ecs_month_base AS base ON emp.emp_code=base.kf_uname");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" ) pb on pb.emp_code=ddd.admin_user_name");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 部门以及下面所有个人的年报
        /// </summary>
        public DataSet GetYearDepData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetYearSaleDataSql(year, returnDateTime, returnTimeStamp);
            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append(" select* from ( ");
            strSql.Append(" SELECT datetime,0 d_pid,'员工合计' d_pname, sum(salemoney) as salemoney, sum(backmoney) as backmoney, sum(salemoney+backmoney) as realmoney ");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" GROUP BY datetime ");
            strSql.Append(" UNION ALL");
            strSql.Append(" select datetime,admin_user_name d_pid,name d_pname, sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney ");
            strSql.Append(" from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name, datetime");
            strSql.Append(" )ddd");

            strSql.Append(" LEFT JOIN (SELECT '0' d_pid1,'员工合计' d_pname1,sum(salemoney) AS salemoney1,sum(backmoney) AS backmoney1,sum(salemoney+backmoney) AS realmoney1  ");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" UNION ALL");
            strSql.Append(" select admin_user_name d_pid1,name d_pname1, sum(salemoney) as salemoney1,sum(backmoney) as backmoney1,sum(salemoney+backmoney) as realmoney1 ");
            strSql.Append(" from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name");
            strSql.Append(" ) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" LEFT JOIN (");
            strSql.Append(" SELECT * from (SELECT '0' d_pid2, '员工合计' d_pname2,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from ");
            strSql.Append(" (SELECT case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan ");
            strSql.Append(" FROM hr_employee AS emp ");
            strSql.Append(" LEFT JOIN ecs_per_plan as plan on emp.emp_code=plan.kf_uname");
            strSql.Append(" LEFT JOIN ecs_month_base as base on emp.emp_code=base.kf_uname");
            strSql.Append("  WHERE " + strSqlOne + " ) a )aa");
            strSql.Append(" UNION ALL");
            strSql.Append(" SELECT emp_code d_pid2,name d_pname2,dep_month_base,dep_month_plan from ");
            strSql.Append(" (SELECT emp_code,name,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from (");
            strSql.Append(" SELECT emp_code,name,case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan ");
            strSql.Append("  FROM hr_employee AS emp ");
            strSql.Append(" LEFT JOIN ecs_per_plan as plan on emp.emp_code=plan.kf_uname");
            strSql.Append(" LEFT JOIN ecs_month_base as base on emp.emp_code=base.kf_uname");
            strSql.Append("  WHERE " + strSqlOne + " ) a");
            strSql.Append(" group by emp_code ) b");
            strSql.Append(" )pb ON ddd.d_pid=pb.d_pid2");
            strSql.Append(" ) tt order by convert(d_pid,signed)");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 中心以及下面所有部门的年报
        /// </summary>
        public DataSet GetYearAllDepData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetYearSaleDataSql(year, returnDateTime, returnTimeStamp);

            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append(" select* from ( SELECT datetime,'0' d_pid,'全体部门' d_pname,sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" GROUP BY datetime");
            strSql.Append(" union all ");
            strSql.Append(" SELECT datetime, d_pid, d_pname,sum(salemoney) AS salemoney,sum(backmoney) AS backmoney,sum(salemoney+backmoney) AS realmoney from (");
            strSql.Append(" SELECT datetime,salemoney,backmoney,realmoney,d_pid, d_name d_pname FROM");
            strSql.Append(" (SELECT sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,datetime ");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" GROUP BY datetime,admin_user_name");
            strSql.Append(" ORDER BY datetime ASC");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" ORDER BY d_pid,admin_user_name,datetime");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid,datetime ORDER BY CONVERT(d_pid,SIGNED),datetime )ddd");

            strSql.Append(" LEFT JOIN ( SELECT '0' d_pid1,'全体部门' d_pname1,sum(salemoney) AS salemoney1, sum(backmoney) AS backmoney1, sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" union all ");
            strSql.Append(" SELECT  d_pid d_pid1, d_pname d_pname1,sum(salemoney) AS salemoney1,sum(backmoney) AS backmoney1,sum(salemoney+backmoney) AS realmoney1 from (");
            strSql.Append(" SELECT salemoney,backmoney,realmoney,d_pid, d_name d_pname FROM");
            strSql.Append(" (SELECT sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,datetime ");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " and datetime is not null ");
            strSql.Append(" GROUP BY datetime,admin_user_name");
            strSql.Append(" ORDER BY datetime ASC");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" ORDER BY d_pid,admin_user_name,datetime");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid1 ) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" LEFT JOIN (SELECT 0 as d_pid2, '全体部门' d_pname2, sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from (");
            strSql.Append(" SELECT case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan FROM hr_employee AS emp ");
            strSql.Append(" LEFT JOIN ecs_per_plan as plan on emp.emp_code=plan.kf_uname");
            strSql.Append(" LEFT JOIN ecs_month_base as base on emp.emp_code=base.kf_uname");
            strSql.Append("  WHERE " + strSqlOne + " ) a");
            strSql.Append(" union all");
            strSql.Append(" SELECT * from (");
            strSql.Append(" SELECT d_pid d_pid2,d_name d_pname2,dep_month_base,dep_month_plan from ");
            strSql.Append(" (SELECT d_pid,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from (");
            strSql.Append(" SELECT CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid, ");
            strSql.Append(" case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan FROM hr_employee AS emp ");
            strSql.Append(" LEFT JOIN hr_department as dep on emp.d_id=dep.id");
            strSql.Append(" LEFT JOIN ecs_per_plan as plan on emp.emp_code=plan.kf_uname");
            strSql.Append(" LEFT JOIN ecs_month_base as base on emp.emp_code=base.kf_uname");
            strSql.Append("  WHERE " + strSqlOne + " ) a");
            strSql.Append(" group by d_pid) b");
            strSql.Append(" LEFT JOIN hr_department AS dep ON b.d_pid=dep.id)aa");
            strSql.Append(" )pb ON ddd.d_pid=pb.d_pid2");
            strSql.Append(" ) tt order by convert(d_pid,signed)");
            
            return DbHelperMySQL.Query(strSql.ToString());
        }

#endregion


        #region 品管

        /// <summary>
        /// 获取个人品牌销售情况月报   
        /// </summary>
        public DataSet GetBrandManagerData_Year(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetYearBrandSaleDataSql(year, returnDateTime, returnTimeStamp);

            strSql.Append(" select salemoney,backmoney,realmoney,datetime,bp_id,bp_brand_id,base,plan, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when bp_percentage is null or bp_brand_name='' then '0.8' else bp_percentage end bp_percentage ");
            strSql.Append(" from ecs_brand_percentage brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(bc_base) base,sum( bc_task) plan,bc_brand_id,bc_brand_name");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join ecs_brand_check eck on emp.emp_code=eck.bc_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" group by bc_brand_id ");
            strSql.Append(" ) bc ON bc.bc_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,brand_id,datetime");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by datetime,brand_id ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.bp_brand_id " + qtBrand);
            strSql.Append(" order by bp_id,datetime ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 品牌下员工排名
        /// </summary>
        public DataSet GetBrandManagerData_Emp_Year(string strSqlOne, string year, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetYearBrandSaleDataSql(year, returnDateTime, returnTimeStamp);

            strSql.Append(" select  salemoney,backmoney,realmoney,code,name,bp_id,bp_brand_id,bp_brand_name,base,plan ,  case when realmoney/plan*100 is null then 0 else realmoney/plan*100 end wcl from ( ");
            strSql.Append(" select salemoney,backmoney,realmoney,emp_code code,name,bp_id,bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name,bc_base base ,bc_task plan");
            strSql.Append(" from ecs_brand_percentage brand left join");
            strSql.Append(" (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,emp_code,name,brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by brand_id,emp_code  ) as dds ");
            strSql.Append(" ON dds.brand_id=brand.bp_brand_id ");
            strSql.Append(" left join ecs_brand_check eck on eck.bc_user_name=dds.emp_code and eck.bc_brand_id=dds.brand_id " + qtBrand);
            strSql.Append(" order by bp_id,realmoney desc )tt ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取个人品牌销售情况月报   
        /// case when a_" + month + " is null then bc_base else a_" + month + " end(历史原因，老数据中只有一个年基数字段（每个月相同，已除以12），没有12个月的分别基数)
        /// </summary>
        public DataSet GetBrandManagerData(string strSqlOne, string yearMonth, string month, DateTime returnDateTime, string returnTimeStamp, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthBrandSaleDataSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append(" select salemoney,backmoney,realmoney,datetime,bp_id,bp_brand_id,base,plan, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when bp_percentage is null or bp_brand_name='' then '0.8' else bp_percentage end bp_percentage ");
            strSql.Append(" from ecs_brand_percentage brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(a_" + month + ") base,sum( b_" + month + ") plan,bc_brand_id,bc_brand_name"); 
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join ecs_brand_check eck on emp.emp_code=eck.bc_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" group by bc_brand_id ");
            strSql.Append(" ) bc ON bc.bc_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,brand_id,lpad(day(abc.datetime), 2, 0) as datetime");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by datetime,brand_id ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.bp_brand_id " + qtBrand);
            strSql.Append(" order by bp_id,datetime ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 品牌下员工排名
        /// </summary>
        public DataSet GetBrandManagerData_Emp(string strSqlOne, string yearMonth, string month, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthBrandSaleDataSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append(" select salemoney,backmoney,realmoney,code,name,bp_id,bp_brand_id,bp_brand_name,base,plan , case when realmoney/plan*100 is null then 0 else realmoney/plan*100 end wcl from ( ");
            strSql.Append(" select salemoney,backmoney,realmoney,emp_code code,name,bp_id,bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when  b_" + month + "  is null then 0 else b_" + month + " end base,case when  a_" + month + "  is null then 0 else a_" + month + " end plan ");
            strSql.Append(" from ecs_brand_percentage brand left join");
            strSql.Append(" (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,emp_code,name,brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by brand_id,emp_code  ) as dds ");
            strSql.Append(" ON dds.brand_id=brand.bp_brand_id " );
            strSql.Append(" left join ecs_brand_check eck on eck.bc_user_name=dds.emp_code and eck.bc_brand_id=dds.brand_id " + qtBrand);
            strSql.Append(" order by bp_id,realmoney desc )tt ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 考核品牌数据
        //—————————————————————考核品牌数据—————————————————————————————————————————————




        /// <summary>
        /// 获取个人品牌销售情况月报
        /// </summary>
        public DataSet GetBrandSaleBackData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp,  string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthBrandSaleDataSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append(" select salemoney,backmoney,realmoney,orderdate,bp_id,bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when bp_percentage is null or bp_brand_name='' then '0.8' else bp_percentage end bp_percentage FROM ");
            strSql.Append(" ecs_brand_percentage brand left join ");
            strSql.Append(" (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,brand_id,lpad(day(abc.datetime), 2, 0) as orderdate");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by orderdate,brand_id  ) as dds ");
            strSql.Append(" ON dds.brand_id=brand.bp_brand_id " + qtBrand );
            strSql.Append(" order by bp_id,orderdate ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取个人考核品牌年报
        /// </summary>
        public DataSet GetYearBrandSaleBackData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetYearBrandSaleDataSql(year, returnDateTime, returnTimeStamp);

            strSql.Append(" SELECT salemoney,backmoney,realmoney,datetime,bp_id,bp_brand_id,  ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when bp_percentage is null or bp_brand_name='' then '0.8' else bp_percentage end bp_percentage FROM ");
            strSql.Append(" ecs_brand_percentage brand left join ");
            strSql.Append(" (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,brand_id,datetime");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by datetime,brand_id ) as dds ");
            strSql.Append("  ON dds.brand_id=brand.bp_brand_id " + qtBrand);
            strSql.Append(" order by bp_id,datetime ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion


        #region 薪资部分
        //------------------------------------薪资部分----------------------------------------------------------------------------------------------------------------






        /// <summary>
        /// 获取个人薪资部分，品牌月提成
        /// 根据emp_code区分是部门还是个人，还是全部cast(bp_percentage as decimal(18,2)),其他品牌默认为0.8
        /// </summary>
        public DataSet GetBrandPercentageData(string a_, string b_, string strSqlOne, string emp_code, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthBrandSaleDataSql(yearMonth, returnDateTime, returnTimeStamp);
            strSql.Append(" select * ,realmoney_brand-plan_brand cha_brand,case when realmoney_brand/plan_brand*100 is null then 0 else realmoney_brand/plan_brand*100 end wcl_brand,(realmoney_brand-base_brand)*bp_percentage*0.01 percentage_brand from ( ");
            strSql.Append(" select bc_user_name,bc_real_name,bc_brand_id, ");
            strSql.Append(" CASE WHEN bc_brand_name IS NULL OR bc_brand_name='' THEN '其它'  ELSE bc_brand_name END bc_brand_name, ");
            strSql.Append(" CASE WHEN " + a_ + " IS NULL THEN bc_base ELSE " + a_ + " END base_brand," + b_ + " plan_brand,bp_percentage, ");
            strSql.Append(" case when salemoney is null then 0 else salemoney end salemoney_brand, ");
            strSql.Append(" case when backmoney is null then 0 else backmoney end backmoney_brand, ");
            strSql.Append(" case when realmoney is null then 0 else realmoney end realmoney_brand ");
            strSql.Append("  FROM ecs_brand_check  AS ck ");
            strSql.Append(" left join hr_employee emp ON emp.emp_code=ck.bc_user_name ");
            strSql.Append(" left join ecs_brand_percentage brand ON ck.bc_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join ( ");
            strSql.Append("     SELECT sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,admin_user_name,brand_id2 from ( ");
            strSql.Append("         SELECT salemoney,backmoney,admin_user_name,brand_id,datetime ,case when brand_id in(SELECT bp_brand_id from ecs_brand_percentage) then brand_id else 0 end brand_id2 ");
            strSql.Append("              from (" + saleData + ")a ");
            strSql.Append("              )b group by admin_user_name,brand_id2 ");
            strSql.Append(" )AS abc ON emp.emp_code=abc.admin_user_name AND ck.bc_brand_id=abc.brand_id2 " + strSqlOne + "AND emp.emp_code IN(" + emp_code + ")");
            strSql.Append(" ) al  ");
            strSql.Append(" order by " + filedOrder);

            //strSql.Append(" select * ,realmoney_brand-plan_brand cha_brand,case when realmoney_brand/plan_brand*100 is null then 0 else realmoney_brand/plan_brand*100 end wcl_brand,(realmoney_brand-base_brand)*bp_percentage*0.01 percentage_brand from ( ");
            //strSql.Append(" select bc_user_name,bc_real_name,bc_brand_id,bc_brand_name, ");
            //strSql.Append(" base_brand,plan_brand,bp_percentage, ");
            //strSql.Append(" case when salemoney is null then 0 else salemoney end salemoney_brand, ");
            //strSql.Append(" case when backmoney is null then 0 else backmoney end backmoney_brand, ");
            //strSql.Append(" case when realmoney is null then 0 else realmoney end realmoney_brand ");
            //strSql.Append("  from (select bc_user_name,bc_real_name,bc_brand_id,case when bc_brand_name is null ");
            //strSql.Append("          or bc_brand_name='' then '其它' else bc_brand_name end bc_brand_name, ");
            //strSql.Append("          bc_base bc_base,case when " + b_ + "=0 then (bc_task/12) else " + b_ + " end plan_brand, case when " + a_ + " is null then bc_base else " + a_ + " end base_brand ");
            //strSql.Append("          from ecs_brand_check  ");
            //strSql.Append("          where bc_user_name in(" + emp_code + ") ");
            //strSql.Append("          group by bc_brand_id,bc_user_name) ck ");
            //strSql.Append("  left join ecs_brand_percentage brand on ck.bc_brand_id=brand.bp_brand_id ");
            //strSql.Append("  left join (select sum(salemoney) as salemoney, ");
            //strSql.Append("                 sum(backmoney) as backmoney, ");
            //strSql.Append("                 sum(salemoney+backmoney) as realmoney, ");
            //strSql.Append("                 admin_user_name,name, brand_id ");
            //strSql.Append("             from hr_employee as emp ");
            //strSql.Append("             left join ");
            //strSql.Append("             (select sum(og.goods_price*og.goods_number) as salemoney, ");
            //strSql.Append("                   0 as backmoney,oi.admin_user_name, ");
            //strSql.Append("                   case when brand_id in (select bc_brand_id from ecs_brand_check where bc_user_name in(" + emp_code + ") and bc_brand_id<>0) then brand_id else 0 end brand_id ");
            //strSql.Append("              from ecs_order_goods as og ");
            //strSql.Append("              left join ecs_goods as g on g.goods_id=og.goods_id ");
            //strSql.Append("              left join ecs_order_info as oi on oi.order_id=og.order_id ");
            //strSql.Append("                   where oi.order_status !=9 ");
            //strSql.Append("                   and erp_order_sn like '%" + yearMonth + "%'  and erp_time<>0 ");
            //strSql.Append("                   and oi.admin_user_name in(" + emp_code + ") ");
            //strSql.Append("                   group by oi.admin_user_name,g.brand_id ");
            //strSql.Append("              union all  ");
            //strSql.Append(" 			 select 0 as salemoney,sum(d.je) as backmoney,x.xm as admin_user_name, ");
            //strSql.Append("                   case when brand_id in (select bc_brand_id from ecs_brand_check where bc_user_name in(" + emp_code + ") and bc_brand_id<>0) then brand_id else 0 end brand_id ");
            //strSql.Append("              from djkck as d ");
            //strSql.Append("              left join ecs_goods as g on d.bm=g.goods_id ");
            //strSql.Append("              inner join xlkck as x on x.djhm=d.djhm and x.xm in(" + emp_code + ") ");
            //strSql.Append("                 where d.rq like '%" + yearMonth + "%' and d.je<0 and date(d.RQ)<'" + returnDateTime + "'");
            //strSql.Append("                 group by x.xm,g.brand_id ");

            //strSql.Append("             union all  ");
            //strSql.Append("             select 0 as salemoney,sum(cast(-rg.goods_price*rg.goods_number as decimal(18,2))) as backmoney,admin_user_name, ");
            //strSql.Append("                   case when brand_id in (select bc_brand_id from ecs_brand_check where bc_user_name in(" + emp_code + ") and bc_brand_id<>0) then brand_id else 0 end brand_id ");
            //strSql.Append("             from ecs_return_order as e ");
            //strSql.Append("             left join ecs_return_goods rg on e.return_id=rg.return_id ");
            //strSql.Append("             left join ecs_goods as g on rg.goods_id=g.goods_id ");
            //strSql.Append("             where from_unixtime(e.erp_time, '%Y-%m') like '%" + yearMonth + "%' and e.ret_money_total<0 and admin_user_name in(" + emp_code + ") and e.erp_time>=" + returnTimeStamp);
            //strSql.Append("             group by admin_user_name,g.brand_id  ");

            //strSql.Append(" 			 ) as abc on emp.emp_code=abc.admin_user_name " + strSqlOne);
            ////strSql.Append("              left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name " + strSqlOne);
            //strSql.Append("                group by brand_id,admin_user_name ");
            //strSql.Append(" 			) as dds ");
            //strSql.Append("     on dds.admin_user_name=ck.bc_user_name and bc_brand_id=brand_id  ");
            //strSql.Append(" ) al  ");
            //strSql.Append(" order by " + filedOrder);

            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 传入时间段，所有部门人，d_id
        /// 个人月/节点排名，取冠军,根据完成率排名
        /// </summary>
        public DataSet GetPersonalMonthRankData(string monthColumns, string isNodes, string strSqlOne, string d_ids, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append(" select * from( ");
            strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid,d_name d_pname,plan_personal,base_personal, ");
            strSql.Append(" case when realmoney_personal-plan_personal is null then 0 else realmoney_personal-plan_personal end cha_personal, ");
            strSql.Append(" case when realmoney_personal/plan_personal*100 is null then 0 else realmoney_personal/plan_personal*100 end wcl_personal  ");
            strSql.Append(" from ( ");
            strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid, ");
            strSql.Append(" case when plan is null then 0 else plan end plan_personal, ");
            strSql.Append(" case when base is null then 0 else base end base_personal ");
            strSql.Append(" from  ");
            strSql.Append(" (select case when sum(salemoney) is null then 0 else sum(salemoney) end  AS salemoney_personal,case when sum(backmoney) is null then 0 else sum(backmoney) end  AS backmoney_personal, case when sum(salemoney+backmoney) is null then 0 else sum(salemoney+backmoney) end  AS realmoney_personal,emp_code as admin_user_name,name, ");
            strSql.Append(" d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");

            //strSql.Append(" left join ");
            //strSql.Append("   (select sum(goods_amount) as salemoney , 0 as backmoney,oi.admin_user_name ");
            //strSql.Append("    from ecs_order_info as oi ");
            //strSql.Append("    where oi.order_status !=9 and erp_order_sn like '%" + yearMonth + "%'  and erp_time<>0 ");
            //strSql.Append("    group by admin_user_name ");

            //strSql.Append("    union all select 0 as salemoney,sum(d.je) as backmoney,x.xm as admin_user_name ");
            //strSql.Append("    from djkck as d ");
            //strSql.Append("    inner join xlkck as x on x.djhm=d.djhm ");
            //strSql.Append("    where d.rq like '%" + yearMonth + "%' and d.je<0 and date(d.RQ)<'" + returnDateTime + "'");
            //strSql.Append("    group by admin_user_name");

            //strSql.Append("  union all select 0 as salemoney, sum(cast(ret_money_total as decimal(18,2))) as backmoney, admin_user_name");
            //strSql.Append("  FROM ecs_return_order AS e ");
            //strSql.Append("   where from_unixtime(e.erp_time, '%Y-%m') like '%" + yearMonth + "%' and e.ret_money_total<0  and e.erp_time>=" + returnTimeStamp);
            //strSql.Append("  group by admin_user_name");

            //strSql.Append("    ) as abc on emp.emp_code=abc.admin_user_name " + strSqlOne + d_ids);

            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name" + strSqlOne + d_ids);
            strSql.Append(" group by emp_code ");
            strSql.Append(" order by realmoney_personal desc) dds ");
            strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2))/" + isNodes + " as plan,kf_uname from ecs_per_plan) pl on dds.admin_user_name=pl.kf_uname  ");
            strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2))/" + isNodes + " as base,kf_uname from ecs_month_base) bs on dds.admin_user_name=bs.kf_uname )al LEFT JOIN hr_department AS dep ON al.d_pid=dep.id )ak order by wcl_personal desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 传入时间段，所有部门人，d_id
        /// 个人月/节点排名，取冠军,根据完成率排名
        /// </summary>
        public DataSet GetPersonalNodeRankData(string monthColumns, string isNodes, string strSqlOne, string d_ids, string node_oneA, string node_oneB, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetNodeSaleDataSql(node_oneA, node_oneB, returnDateTime, returnTimeStamp);

            strSql.Append(" select * from( ");
            strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid,d_name d_pname,plan_personal,base_personal, ");
            strSql.Append(" case when realmoney_personal-plan_personal is null then 0 else realmoney_personal-plan_personal end cha_personal, ");
            strSql.Append(" case when realmoney_personal/plan_personal*100 is null then 0 else realmoney_personal/plan_personal*100 end wcl_personal  ");
            strSql.Append(" from ( ");
            strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid, ");
            strSql.Append(" case when plan is null then 0 else plan end plan_personal, ");
            strSql.Append(" case when base is null then 0 else base end base_personal ");
            strSql.Append(" from  ");
            strSql.Append(" (select case when sum(salemoney) is null then 0 else sum(salemoney) end  AS salemoney_personal,case when sum(backmoney) is null then 0 else sum(backmoney) end  AS backmoney_personal, case when sum(salemoney+backmoney) is null then 0 else sum(salemoney+backmoney) end  AS realmoney_personal,emp_code as admin_user_name,name, ");
            strSql.Append(" d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            //strSql.Append(" left join ");
            //strSql.Append("   (select sum(goods_amount) as salemoney , 0 as backmoney,oi.admin_user_name ");
            //strSql.Append("    from ecs_order_info as oi ");
            //strSql.Append("    where oi.order_status !=9 and oi.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneA)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59)));
            //strSql.Append("    group by admin_user_name ");

            //strSql.Append("    union all select 0 as salemoney,sum(d.je) as backmoney,x.xm as admin_user_name ");
            //strSql.Append("    from djkck as d ");
            //strSql.Append("    inner join xlkck as x on x.djhm=d.djhm ");
            //strSql.Append("    where date(d.RQ) >='" + DateTime.Parse(node_oneA) + "' and date(d.RQ)<='" + DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59) + "' and d.je<0 and date(d.RQ)<'" + returnDateTime + "'");
            //strSql.Append("    group by admin_user_name");

            //strSql.Append("  union all select 0 as salemoney, sum(cast(ret_money_total as decimal(18,2))) as backmoney, admin_user_name");
            //strSql.Append("  FROM ecs_return_order AS e ");
            //strSql.Append("   where  e.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneA)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59)) + " and e.ret_money_total<0  and e.erp_time>=" + returnTimeStamp);
            //strSql.Append("  group by admin_user_name");

            //strSql.Append("    ) as abc on emp.emp_code=abc.admin_user_name " + strSqlOne + d_ids);

            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name" + strSqlOne + d_ids);
            strSql.Append(" group by emp_code ");
            strSql.Append(" order by realmoney_personal desc) dds ");
            strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2))/" + isNodes + " as plan,kf_uname from ecs_per_plan) pl on dds.admin_user_name=pl.kf_uname  ");
            strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2))/" + isNodes + " as base,kf_uname from ecs_month_base) bs on dds.admin_user_name=bs.kf_uname )al LEFT JOIN hr_department AS dep ON al.d_pid=dep.id )ak order by wcl_personal desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 传入时间段
        /// 团队月/节点总排名，团队冠军奖,团队节点排名，团队节点冠军
        /// </summary>
        public DataSet GetTeamMonthRankData(string monthColumns, string isNodes, string strSqlOne, string d_ids, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth, returnDateTime, returnTimeStamp);
            strSql.Append(" select * from (select *, ");
            strSql.Append("  case when realmoney_team-plan_team is null then 0 else realmoney_team-plan_team end cha_team, case when realmoney_team/plan_team*100 is null then 0 else realmoney_team/plan_team*100 end wcl_team from ");
            strSql.Append("   (select sum(salemoney) as salemoney_team,sum(backmoney) as backmoney_team, sum(salemoney+backmoney) as realmoney_team,d_pid,d_name d_pname,sum(plan) as plan_team,sum(base) as base_team ");
            strSql.Append("    from (select salemoney,backmoney,realmoney,d_pid, case when plan is null then 0 else plan end plan, case when base is null then 0 else base end base ");
            strSql.Append("       from (select case when sum(salemoney) is null then 0 else sum(salemoney) end  AS salemoney,case when sum(backmoney) is null then 0 else sum(backmoney) end  AS backmoney, case when sum(salemoney+backmoney) is null then 0 else sum(salemoney+backmoney) end  AS realmoney, emp_code as admin_user_name,name,d_id,dname, ");
            strSql.Append(" 		 case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append("          from hr_employee as emp ");
            strSql.Append("          left join hr_department as dep on emp.d_id=dep.id ");
            //strSql.Append("          left join ");
            //strSql.Append("            (select sum(goods_amount) as salemoney , 0 as backmoney,oi.admin_user_name ");
            //strSql.Append("             from ecs_order_info as oi ");
            //strSql.Append("             where oi.order_status !=9  and erp_order_sn like '%" + yearMonth + "%'  and erp_time<>0 ");
            //strSql.Append("             group by admin_user_name ");

            //strSql.Append("             union all select 0 as salemoney,sum(d.je) as backmoney,x.xm as admin_user_name ");
            //strSql.Append("             from djkck as d ");
            //strSql.Append("             inner join xlkck as x on x.djhm=d.djhm ");
            //strSql.Append("             where d.rq like '%" + yearMonth + "%' and d.je<0 and date(d.RQ)<'" + returnDateTime + "'");
            //strSql.Append("             group by admin_user_name");

            //strSql.Append("             union all select 0 as salemoney, sum(cast(ret_money_total as decimal(18,2))) as backmoney, admin_user_name");
            //strSql.Append("             FROM ecs_return_order AS e ");
            //strSql.Append("              where from_unixtime(e.erp_time, '%Y-%m') like '%" + yearMonth + "%' and e.ret_money_total<0  and e.erp_time>=" + returnTimeStamp);
            //strSql.Append("             group by admin_user_name");

            //strSql.Append("             ) as abc on emp.emp_code=abc.admin_user_name " + strSqlOne + d_ids);

            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name" + strSqlOne + d_ids);
            strSql.Append("          group by emp_code ");
            strSql.Append("          order by realmoney desc) dds ");
            strSql.Append("       left join ");
            strSql.Append("         (select cast(" + monthColumns + " as decimal(18,2))/" + isNodes + " as plan,kf_uname from ecs_per_plan) pl on dds.admin_user_name=pl.kf_uname ");
            strSql.Append("       left join ");
            strSql.Append("         (select cast(" + monthColumns + " as decimal(18,2))/" + isNodes + " as base,kf_uname from ecs_month_base) bs on dds.admin_user_name=bs.kf_uname ");
            strSql.Append(" 		)al LEFT JOIN hr_department AS dep ON al.d_pid=dep.id ");
            strSql.Append(" 	group by d_pid)ak  ");
            strSql.Append(" 	)t ");
            strSql.Append(" where wcl_team>0 order by wcl_team desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 传入时间段
        /// 团队月/节点总排名，团队冠军奖,团队节点排名，团队节点冠军
        /// </summary>
        public DataSet GetTeamNodeRankData(string monthColumns, string isNodes, string strSqlOne, string d_ids, string node_oneA, string node_oneB, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetNodeSaleDataSql(node_oneA, node_oneB, returnDateTime, returnTimeStamp);
            strSql.Append(" select * from (select *, ");
            strSql.Append("  case when realmoney_team-plan_team is null then 0 else realmoney_team-plan_team end cha_team, case when realmoney_team/plan_team*100 is null then 0 else realmoney_team/plan_team*100 end wcl_team from ");
            strSql.Append("   (select sum(salemoney) as salemoney_team,sum(backmoney) as backmoney_team, sum(salemoney+backmoney) as realmoney_team,d_pid,d_name d_pname,sum(plan) as plan_team,sum(base) as base_team ");
            strSql.Append("    from (select salemoney,backmoney,realmoney,d_pid, case when plan is null then 0 else plan end plan, case when base is null then 0 else base end base ");
            strSql.Append("       from (select case when sum(salemoney) is null then 0 else sum(salemoney) end  AS salemoney,case when sum(backmoney) is null then 0 else sum(backmoney) end  AS backmoney, case when sum(salemoney+backmoney) is null then 0 else sum(salemoney+backmoney) end  AS realmoney, emp_code as admin_user_name,name,d_id,dname, ");
            strSql.Append(" 		 case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append("          from hr_employee as emp ");
            strSql.Append("          left join hr_department as dep on emp.d_id=dep.id ");
            //strSql.Append("          left join ");
            //strSql.Append("            (select sum(goods_amount) as salemoney , 0 as backmoney,oi.admin_user_name ");
            //strSql.Append("             from ecs_order_info as oi ");
            //strSql.Append("             where oi.order_status !=9  and oi.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneA)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59)));
            //strSql.Append("             group by admin_user_name ");

            //strSql.Append("             union all select 0 as salemoney,sum(d.je) as backmoney,x.xm as admin_user_name ");
            //strSql.Append("             from djkck as d ");
            //strSql.Append("             inner join xlkck as x on x.djhm=d.djhm ");
            //strSql.Append("             where date(d.RQ) >='" + DateTime.Parse(node_oneA) + "' and date(d.RQ)<='" + DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59) + "' and d.je<0 and date(d.RQ)<'" + returnDateTime + "'");
            //strSql.Append("             group by admin_user_name");

            //strSql.Append("             union all select 0 as salemoney, sum(cast(ret_money_total as decimal(18,2))) as backmoney, admin_user_name");
            //strSql.Append("             FROM ecs_return_order AS e ");
            //strSql.Append("              where e.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneA)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59)) + " and e.ret_money_total<0  and e.erp_time>=" + returnTimeStamp);
            //strSql.Append("             group by admin_user_name");

            //strSql.Append("             ) as abc on emp.emp_code=abc.admin_user_name " + strSqlOne + d_ids);

            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name" + strSqlOne + d_ids);
            strSql.Append("          group by emp_code ");
            strSql.Append("          order by realmoney desc) dds ");
            strSql.Append("       left join ");
            strSql.Append("         (select cast(" + monthColumns + " as decimal(18,2))/" + isNodes + " as plan,kf_uname from ecs_per_plan) pl on dds.admin_user_name=pl.kf_uname ");
            strSql.Append("       left join ");
            strSql.Append("         (select cast(" + monthColumns + " as decimal(18,2))/" + isNodes + " as base,kf_uname from ecs_month_base) bs on dds.admin_user_name=bs.kf_uname ");
            strSql.Append(" 		)al LEFT JOIN hr_department AS dep ON al.d_pid=dep.id ");
            strSql.Append(" 	group by d_pid)ak  ");
            strSql.Append(" 	)t ");
            strSql.Append(" where wcl_team>0 order by wcl_team desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 传入时间段
        /// 基本薪资=根据月客户数，月客户销售额，判断等级
        /// </summary>
        public DataSet GetMonthCustomerSaleData(string strSqlOne, string d_id, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerMonthSaleSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append(" select abc.*,d_name d_pname,u.user_name,u.u_company from  ");
            strSql.Append(" (select sum(salemoney) as salemoney_customer,sum(backmoney) as backmoney_customer,sum(salemoney+backmoney) as realmoney_customer, ");
            strSql.Append("  admin_user_name,name, user_id,d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append("          from hr_employee as emp ");
            strSql.Append("          left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append("         left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 		" + strSqlOne + d_id + " and admin_user_name is not null");
            strSql.Append("          group by user_id,admin_user_name ");
            strSql.Append("          order by admin_user_name,realmoney_customer desc )as abc ");
            strSql.Append(" left join hr_department AS dep ON abc.d_pid=dep.id ");
            strSql.Append(" left join ecs_users as u on abc.user_id=u.user_id ");
            return DbHelperMySQL.Query(strSql.ToString());

        }

        /// <summary>
        /// 传入年，月
        /// 获得个人薪资月冠军，节点冠军，节点达标奖励
        /// </summary>
        public DataSet GetPersonalMonthSalaryData(string year, string month)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select year,monthnode month,admin_user_name,name,d_pid,d_pname, ");
            strSql.Append(" case when xy_1000 is null then 0 else xy_1000 end xy_1000,case when dy_1000 is null then 0 else dy_1000 end dy_1000, ");
            strSql.Append(" case when dy_5000 is null then 0 else dy_5000 end dy_5000,case when dy_10000 is null then 0 else dy_10000 end dy_10000, ");
            strSql.Append(" case when dy_20000 is null then 0 else dy_20000 end dy_20000,personal_champion, ");
            strSql.Append(" case when personal_champion1 is null then 0 else personal_champion1 end personal_champion1,case when personal_bonus1 is null then 0 else personal_bonus1 end personal_bonus1, ");
            strSql.Append(" case when personal_champion2 is null then 0 else personal_champion2 end personal_champion2,case when personal_bonus2 is null then 0 else personal_bonus2 end personal_bonus2, ");
            strSql.Append(" case when personal_champion3 is null then 0 else personal_champion3 end personal_champion3,case when personal_bonus3 is null then 0 else personal_bonus3 end personal_bonus3, ");
            strSql.Append(" case when personal_champion4 is null then 0 else personal_champion4 end personal_champion4,case when personal_bonus4 is null then 0 else personal_bonus4 end personal_bonus4, ");
            strSql.Append(" case when percentage_sum is null then 0 else percentage_sum end percentage_sum ");
            strSql.Append(" from dms_monthnode_sale as sm ");
            //基本工资
            strSql.Append(" LEFT JOIN(SELECT count(*) as xy_1000,admin_user_name admin_user_name5 from dms_customer_sale where realmoney_customer<1000 and year=" + year + " and month=" + month + " group by admin_user_name) xy1000   ");
            strSql.Append(" on xy1000.admin_user_name5=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN(SELECT count(*) as dy_1000,admin_user_name admin_user_name6 from dms_customer_sale where realmoney_customer>=1000 and year=" + year + " and month=" + month + " group by admin_user_name) dy1000 ");
            strSql.Append(" on dy1000.admin_user_name6=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN(SELECT count(*) as dy_5000,admin_user_name admin_user_name7 from dms_customer_sale where realmoney_customer>=5000 and year=" + year + " and month=" + month + " group by admin_user_name) dy5000 ");
            strSql.Append(" on dy5000.admin_user_name7=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN(SELECT count(*) as dy_10000,admin_user_name admin_user_name8 from dms_customer_sale where realmoney_customer>=10000 and year=" + year + " and month=" + month + " group by admin_user_name) dy10000 ");
            strSql.Append(" on dy10000.admin_user_name8=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN(SELECT count(*) as dy_20000,admin_user_name admin_user_name9 from dms_customer_sale where realmoney_customer>=20000 and year=" + year + " and month=" + month + " group by admin_user_name) dy20000 ");
            strSql.Append(" on dy20000.admin_user_name9=sm.admin_user_name ");
            //个人节点冠军，节点达标奖励，月冠军
            strSql.Append(" LEFT JOIN (select admin_user_name admin_user_name1,personal_champion personal_champion1,personal_bonus personal_bonus1 from dms_monthnode_sale where year=" + year + " and monthnode=" + month + "01) n1  ");
            strSql.Append(" on n1.admin_user_name1=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN (select admin_user_name admin_user_name2,personal_champion personal_champion2,personal_bonus personal_bonus2 from dms_monthnode_sale where year=" + year + " and monthnode=" + month + "02) n2 ");
            strSql.Append(" on n2.admin_user_name2=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN (select admin_user_name admin_user_name3,personal_champion personal_champion3,personal_bonus personal_bonus3 from dms_monthnode_sale where year=" + year + " and monthnode=" + month + "03) n3 ");
            strSql.Append(" on n3.admin_user_name3=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN (select admin_user_name admin_user_name4,personal_champion personal_champion4,personal_bonus personal_bonus4 from dms_monthnode_sale where year=" + year + " and monthnode=" + month + "04) n4 ");
            strSql.Append(" on n4.admin_user_name4=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN (SELECT sum(percentage_brand) percentage_sum,bc_user_name FROM dms_brand_percentage where year=" + year + " and month=" + month + "  group by bc_user_name) tc ");
            strSql.Append(" ON sm.admin_user_name=tc.bc_user_name ");

            strSql.Append(" where year=" + year + " and monthnode=" + month + " ");

            return DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion




        #region 客户数据

        //----------------------客户数据-----------------------------------------------------------------------------------------------------

        /// <summary>
        /// 客户树
        /// </summary>
        public DataSet GetCustomerTree(string yearMonth, string emp_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("  SELECT user_id,u_company from( ");
            strSql.Append(" SELECT u.user_id,u.u_company,oi.admin_user_name from ecs_order_info oi  ");
            strSql.Append("  left join ecs_users as u on oi.user_id=u.user_id ");
            strSql.Append("  where oi.order_status !=9  ");
            strSql.Append("  AND erp_order_sn LIKE '%" + yearMonth + "%' ");
            strSql.Append("  AND erp_time<>0  and u_company is not null ");
            strSql.Append("  group by u.user_id,u.u_company  ");
            strSql.Append(" ) AS abc ");
            strSql.Append(" left join hr_employee AS emp ");
            strSql.Append("  ON emp.emp_code=abc.admin_user_name ");
            strSql.Append(" WHERE emp.factory_id='1000' AND emp.isdelete=0 " + emp_code);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得个人客户的销售详情(年报)
        /// </summary>
        public DataSet GetCustomerYearSaleBackData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerYearSaleSql(year, returnDateTime, returnTimeStamp);

            strSql.Append(" SELECT * from (select abcd.*,d_name d_pname,u.user_name,u.u_company from (");
            strSql.Append(" SELECT user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name,name,datetime,");
            strSql.Append(" d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            strSql.Append(" GROUP BY user_id,datetime ORDER BY convert(user_id,signed), datetime ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join hr_department AS dep ON abcd.d_pid=dep.id ");
            strSql.Append(" left join ecs_users as u on abcd.user_id=u.user_id ) ddd ");
            //每个月份的合计
            strSql.Append(" left join (SELECT datetime datetimeMonth,sum(salemoney) salemoneyMonth,sum(backmoney) backmoneyMonth,sum(salemoney+backmoney) AS realmoneyMonth");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            strSql.Append(" GROUP BY datetime) sumMonth on sumMonth.datetimeMonth=ddd.datetime ");
            //每个客户的年合计
            strSql.Append(" left join (SELECT user_id userIdSum,sum(salemoney) salemoneyUser,sum(backmoney) backmoneyUser,sum(salemoney+backmoney) AS realmoneyUser");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            strSql.Append(" GROUP BY user_id) sumUser on sumUser.userIdSum=ddd.user_id ");
            //每个客户的分配
            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id");
            //strSql.Append(" where " + strSqlOne);//user_id不存在
            strSql.Append(" group by emp_code) cc on cc.emp_code=ddd.admin_user_name");
            //每个客户的拿货频率
            strSql.Append(" left join (SELECT count(1) monthCount,user_id user_id2,datetime2 from(");
            strSql.Append(" SELECT abc.* FROM hr_employee AS emp");
            strSql.Append(" left join (SELECT user_id ,oi.admin_user_name,from_unixtime(oi.erp_time, '%m') AS datetime2,from_unixtime(oi.erp_time, '%y-%m-%d') AS orderdate2");
            strSql.Append(" FROM ecs_order_info AS oi ");
            strSql.Append(" WHERE oi.order_status !=9 AND erp_order_sn LIKE '%" + year + "%' AND erp_time<>0");
            strSql.Append(" ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime2 IS NOT NULL ");
            strSql.Append(" GROUP BY user_id,orderdate2 ");
            strSql.Append(" ) ttt group by datetime2,user_id ) ff on ff.user_id2=ddd.user_id and ddd.datetime=ff.datetime2");

            strSql.Append(" order by datetime,realmoney desc ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得个人客户的销售详情(月报)
        /// </summary>
        public DataSet GetCustomerMonthSaleBackData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerMonthSaleSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append(" SELECT * from (select abcd.*,d_name d_pname,u.user_name,u.u_company from (");
            strSql.Append(" SELECT user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name,name,lpad(day(abc.datetime), 2, 0) AS orderdate,");
            strSql.Append(" d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            strSql.Append(" GROUP BY user_id,datetime ORDER BY convert(user_id,signed), datetime ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join hr_department AS dep ON abcd.d_pid=dep.id ");
            strSql.Append(" left join ecs_users as u on abcd.user_id=u.user_id ) ddd ");
            //数据段内每个月客户合计realmoney1
            strSql.Append(" left join (SELECT user_id,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            strSql.Append(" GROUP BY user_id) sumAll on sumAll.user_id=ddd.user_id ");
            //分配客户数user_count
            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id");
            //strSql.Append(" where " + strSqlOne);//user_id不存在
            strSql.Append(" group by emp_code) cc on cc.emp_code=ddd.admin_user_name");
            //拿货频率，一个月内拿了几次货 ，不以订单个数，按照天数，一天内的所有订单算一次 monthCount
            strSql.Append(" left join (SELECT count(1) monthCount,user_id user_id2,datetime2 from(");
            strSql.Append(" SELECT abc.* FROM hr_employee AS emp");
            strSql.Append(" left join (SELECT user_id,oi.admin_user_name,from_unixtime(oi.erp_time, '%m') AS datetime2,from_unixtime(oi.erp_time, '%y-%m-%d') AS orderdate2");
            strSql.Append(" FROM ecs_order_info AS oi ");
            strSql.Append(" WHERE oi.order_status !=9 AND erp_order_sn LIKE '%" + yearMonth + "%' AND erp_time<>0");
            strSql.Append(" ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime2 IS NOT NULL ");
            strSql.Append(" GROUP BY user_id,orderdate2 ");
            strSql.Append(" ) ttt group by datetime2,user_id2 ) ff on ff.user_id2=ddd.user_id");// and ddd.datetime=ff.datetime2 都是一个月内不再匹配月份


            strSql.Append(" order by realmoney1 desc,orderdate ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 部门客户销售数据，中心：部门和个人的客户销售数据，部门：部门下每个客服的客户销售数据
        /// </summary>
        public DataSet GetCustomerYearManagerDepData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerYearSaleSql(year, returnDateTime, returnTimeStamp);
            //销售groupby月内销售
            strSql.Append(" select datetime,admin_user_name emp_code,name,d_pid,d_pname,salemoney,backmoney,realmoney,user_count,");
            strSql.Append(" CASE WHEN deal_count IS NULL THEN 0 ELSE deal_count END deal_count,CASE WHEN deal_number IS NULL THEN 0 ELSE deal_number END deal_number,"); 
            strSql.Append(" case when deal_count/user_count*100 is null then 0 else deal_count/user_count*100 end deal_rate,case when 25 / deal_number*8 is null then 0 else 25 / deal_number*8 end deal_frequency from( ");
            strSql.Append(" SELECT * from (select abcd.*,d_name d_pname from (");
            strSql.Append(" SELECT admin_user_name,name,datetime,d_id,dname, case when parentid=1 then dep.id else parentid end d_pid,");
            strSql.Append(" sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney ");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            strSql.Append(" GROUP BY admin_user_name,datetime ORDER BY admin_user_name, datetime ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join hr_department AS dep ON abcd.d_pid=dep.id ) ddd ");
            ////每个月份的合计
            //strSql.Append(" left join (SELECT datetime datetimeMonth,sum(salemoney) salemoneyMonth,sum(backmoney) backmoneyMonth,sum(salemoney+backmoney) AS realmoneyMonth");
            //strSql.Append(" FROM hr_employee AS emp");
            //strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            //strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            //strSql.Append(" GROUP BY datetime) sm on sm.datetimeMonth=ddd.datetime ");
            ////每个部门的年合计
            //strSql.Append(" left join (SELECT sum(salemoney) salemoneyDep,sum(backmoney) backmoneyDep,sum(salemoney+backmoney) AS realmoneyDep,CASE WHEN parentid=1 THEN dep.id ELSE parentid END sumDep");
            //strSql.Append(" FROM hr_employee AS emp");
            //strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            //strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            //strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            //strSql.Append(" GROUP BY sumDep) sd on sd.sumDep=ddd.d_pid ");
            ////每个客服的年合计
            //strSql.Append(" left join (SELECT admin_user_name sumEmp,sum(salemoney) salemoneyEmp,sum(backmoney) backmoneyEmp,sum(salemoney+backmoney) AS realmoneyEmp");
            //strSql.Append(" FROM hr_employee AS emp");
            //strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            //strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            //strSql.Append(" GROUP BY admin_user_name) su on su.sumEmp=ddd.admin_user_name ");
            //每个客服的分配
            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id");
            //strSql.Append(" where " + strSqlOne);//user_id不存在
            strSql.Append(" group by emp_code) cp on cp.emp_code=ddd.admin_user_name");
            //每个月的成交客户数
            //strSql.Append(" left join (SELECT admin_user_name admin_user_name2,datetime2,count(1) deal_count ");
            //strSql.Append(" FROM hr_employee AS emp");
            //strSql.Append(" left join (SELECT user_id ,oi.admin_user_name,from_unixtime(oi.erp_time, '%m') AS datetime2 ");
            //strSql.Append(" FROM ecs_order_info AS oi ");
            //strSql.Append(" WHERE oi.order_status !=9 AND erp_order_sn LIKE '%" + year + "%' AND erp_time<>0");
            //strSql.Append(" ) AS abc ON emp.emp_code=abc.admin_user_name");
            //strSql.Append(" WHERE " + strSqlOne + " AND datetime2 IS NOT NULL ");
            //strSql.Append(" GROUP BY admin_user_name,datetime2 ");
            //strSql.Append(" ) cjc on cjc.admin_user_name2=ddd.admin_user_name and ddd.datetime=cjc.datetime2");
            ////每个客户的拿货次数
            //strSql.Append(" left join (SELECT count(1) deal_number,admin_user_name admin_user_name3,datetime3 from(");
            //strSql.Append(" SELECT abc.* FROM hr_employee AS emp");
            //strSql.Append(" left join (SELECT user_id ,oi.admin_user_name,from_unixtime(oi.erp_time, '%m') AS datetime3,from_unixtime(oi.erp_time, '%y-%m-%d') AS orderdate2");
            //strSql.Append(" FROM ecs_order_info AS oi ");
            //strSql.Append(" WHERE oi.order_status !=9 AND erp_order_sn LIKE '%" + year + "%' AND erp_time<>0");
            //strSql.Append(" ) AS abc ON emp.emp_code=abc.admin_user_name");
            //strSql.Append(" WHERE " + strSqlOne + " AND datetime3 IS NOT NULL ");
            //strSql.Append(" GROUP BY user_id,orderdate2 ");
            //strSql.Append(" ) ttt group by datetime3,admin_user_name ) pp on pp.admin_user_name3=ddd.admin_user_name and ddd.datetime=pp.datetime3");


            //每个客户的拿货次数
            strSql.Append(" left join (select admin_user_name admin_user_name3,datetime3,sum(user_deal_number) deal_number,count(1) deal_count from (");
            strSql.Append(" select admin_user_name,user_id,datetime3,count(1) user_deal_number from (");
            strSql.Append(" SELECT abc.* FROM hr_employee AS emp");
            strSql.Append(" left join (select user_id ,oi.admin_user_name,from_unixtime(oi.erp_time, '%m') AS datetime3,from_unixtime(oi.erp_time, '%y-%m-%d') AS orderdate2");
            strSql.Append(" FROM ecs_order_info AS oi ");
            strSql.Append(" WHERE oi.order_status !=9 AND erp_order_sn LIKE '%" + year + "%' AND erp_time<>0");
            strSql.Append(" ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime3 IS NOT NULL ");
            strSql.Append("group by admin_user_name,user_id,orderdate2 ");
            strSql.Append(" ) abcd group by user_id,datetime3 ");
            strSql.Append(" )abcde group by admin_user_name,datetime3 ) pp on pp.admin_user_name3=ddd.admin_user_name and ddd.datetime=pp.datetime3");


            strSql.Append(" order by datetime,d_pid,realmoney desc ) zzz ");


            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 部门客户销售数据，中心：部门和个人的客户销售数据，部门：部门下每个客服的客户销售数据
        /// </summary>
        public DataSet GetCustomerMonthManagerDepData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerMonthSaleSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append("   SELECT * from (SELECT abcd.*,d_name d_pname,u.user_name,u.u_company FROM");
            strSql.Append("   (SELECT user_id,sum(salemoney) salemoney,sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name,name,d_id,dname,CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid");
            strSql.Append("    FROM hr_employee AS emp");
            strSql.Append("    LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append("    left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append("         WHERE " + strSqlOne + " and admin_user_name is not null");
            strSql.Append("    GROUP BY user_id,admin_user_name");
            strSql.Append("    ORDER BY convert(user_id,signed)");
            strSql.Append("     )AS abcd");
            strSql.Append(" LEFT JOIN hr_department AS dep ON abcd.d_pid=dep.id");
            strSql.Append(" LEFT JOIN ecs_users AS u ON abcd.user_id=u.user_id ) ddd");

            strSql.Append(" left join (SELECT admin_user_name admin_user_name1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append("    left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne );
            strSql.Append(" GROUP BY admin_user_name) sumAll on sumAll.admin_user_name1=ddd.admin_user_name");

            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by emp_code) cc on cc.emp_code=ddd.admin_user_name");

            //拿货频率，一个月内拿了几次货 ，不以订单个数，按照天数，一天内的所有订单算一次 monthCount
            strSql.Append(" left join (SELECT count(1) monthCount,user_id2,datetime2 from(");
            strSql.Append(" SELECT abc.* FROM hr_employee AS emp");
            strSql.Append(" left join (SELECT user_id user_id2,oi.admin_user_name,from_unixtime(oi.erp_time, '%m') AS datetime2,from_unixtime(oi.erp_time, '%y-%m-%d') AS orderdate2");
            strSql.Append(" FROM ecs_order_info AS oi ");
            strSql.Append(" WHERE oi.order_status !=9 AND erp_order_sn LIKE '%" + yearMonth + "%' AND erp_time<>0");
            strSql.Append(" ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime2 IS NOT NULL ");
            strSql.Append(" GROUP BY user_id2,orderdate2 ");
            strSql.Append(" ) ttt group by datetime2,user_id2 ) ff on ff.user_id2=ddd.user_id");// and ddd.datetime=ff.datetime2 都是一个月内不再匹配月份

            strSql.Append(" ORDER BY convert(d_pid,signed),realmoney1 DESC,realmoney DESC ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 1.客户下，品牌下，销售单品汇总2.客户下，品牌下单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerMonthBrandGoodsData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerMonthBrandGoodsSaleSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append(" select * from (select abcd.*,d_name d_pname,u.user_name,u.u_company from (");
            strSql.Append(" SELECT user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name,name, ");
            strSql.Append(" convert(goods_number,signed) goods_number,datetime,lpad(day(abc.orderdate), 2, 0) AS orderdate,");
            strSql.Append(" brand_id,brand_name,goods_id,goods_name,d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append("    left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            strSql.Append(" GROUP BY goods_id ORDER BY brand_id asc,realmoney desc ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join hr_department AS dep ON abcd.d_pid=dep.id ");
            strSql.Append(" left join ecs_users as u on abcd.user_id=u.user_id )ddd");

            strSql.Append(" left join (SELECT brand_id brand_id1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append("    left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne);
            strSql.Append(" GROUP BY brand_id) sumAll on sumAll.brand_id1=ddd.brand_id");

            strSql.Append(" ORDER BY datetime,realmoney1 desc,realmoney desc ");//先按和排序，再按单个排序

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 1.客户下，品牌下，销售单品汇总2.客户下，品牌下单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerYearBrandGoodsData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerYearBrandGoodsSaleSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append(" select * from (select abcd.*,d_name d_pname,u.user_name,u.u_company from (");
            strSql.Append(" SELECT user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name,name, ");
            strSql.Append(" convert(goods_number,signed) goods_number,datetime,lpad(day(abc.orderdate), 2, 0) AS orderdate,");
            strSql.Append(" brand_id,brand_name,goods_id,goods_name,d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append("    left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne + " AND datetime IS NOT NULL ");
            strSql.Append(" GROUP BY datetime,orderdate,goods_id ORDER BY brand_id asc,realmoney desc ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join hr_department AS dep ON abcd.d_pid=dep.id ");
            strSql.Append(" left join ecs_users as u on abcd.user_id=u.user_id )ddd");

            strSql.Append(" left join (SELECT brand_id brand_id1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" FROM hr_employee AS emp");
            strSql.Append("    left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" WHERE " + strSqlOne);
            strSql.Append(" GROUP BY brand_id) sumAll on sumAll.brand_id1=ddd.brand_id");

            strSql.Append(" ORDER BY realmoney1 desc,datetime,realmoney desc ");//先按和排序，再按单个排序

            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 1.客户下，品牌下，销售单品汇总2.客户下，品牌下单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerYearGood(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerYearBrandGoodsSaleSql(yearMonth, returnDateTime, returnTimeStamp);

            strSql.Append(" select sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) as realmoney,");
            strSql.Append(" convert(goods_number,signed) goods_number,datetime,lpad(day(abc.orderdate), 2, 0) as orderdate,goods_id,goods_name ");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by orderdate  ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion




        #region 拼接sql语句
        #region 区域
        /// <summary>
        /// 拼接月份数据字符串，含省市
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <param name="provinceOrCity">省市</param>
        /// <returns></returns>
        public string GetMapMonthBrandSql(string yearMonth, string provinceOrCity)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("   select province,city,user_id,admin_user_name,salemoney,brand_id,bp_brand_id,brand_name,goods_id,goods_name,datetime from ( ");
            strSql.Append("   select province,city,oi.user_id,oi.admin_user_name,og.goods_price*og.goods_number AS salemoney,g.brand_id, ");
            strSql.Append("   case when bp_brand_id is null or bp_brand_id='' then 0 else bp_brand_id end bp_brand_id, ");
            strSql.Append("   case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end brand_name,g.goods_id,g.goods_name,from_unixtime(oi.erp_time, '%y-%m-%d') as datetime ");
            strSql.Append("    FROM ecs_order_goods AS og ");
            strSql.Append("    left join ecs_goods AS g ON g.goods_id=og.goods_id ");
            strSql.Append("    left join ecs_order_info AS oi ON oi.order_id=og.order_id ");
            strSql.Append("    left join ecs_brand_percentage AS bp ON g.brand_id=bp.bp_brand_id ");
            strSql.Append("    where oi.order_status !=9 and erp_order_sn like '%" + yearMonth + "%'  and erp_time<>0 " + provinceOrCity + ")aa  ");

            return strSql.ToString();
        }

        /// <summary>
        /// 拼接月份数据字符串，含省市
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <param name="provinceOrCity">省市</param>
        /// <returns></returns>
        public string GetMapYearMonths(string year, string provinceOrCity)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("   select province,city,user_id,admin_user_name,salemoney,brand_id,bp_brand_id,brand_name,goods_id,goods_name,datetime from ( ");
            strSql.Append("   select province,city,oi.user_id,oi.admin_user_name,og.goods_price*og.goods_number AS salemoney,g.brand_id, ");
            strSql.Append("   case when bp_brand_id is null or bp_brand_id='' then 0 else bp_brand_id end bp_brand_id, ");
            strSql.Append("   case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end brand_name,g.goods_id,g.goods_name,from_unixtime(oi.erp_time, '%m') as datetime ");
            strSql.Append("    FROM ecs_order_goods AS og ");
            strSql.Append("    left join ecs_goods AS g ON g.goods_id=og.goods_id ");
            strSql.Append("    left join ecs_order_info AS oi ON oi.order_id=og.order_id ");
            strSql.Append("    left join ecs_brand_percentage AS bp ON g.brand_id=bp.bp_brand_id ");
            strSql.Append("    where oi.order_status !=9 and erp_order_sn like '%" + year + "%'  and erp_time<>0 " + provinceOrCity + ")aa  ");

            return strSql.ToString();
        }
        #endregion


        #region 统计
        /// <summary>
        /// 拼接月份数据字符串
        /// sql sum(cast(ret_money_total as decimal(18,2))),数据库为float类型，转为decimal，防止相加出现.999999999
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <param name="returnDateTime">退货日期</param>
        /// <param name="returnTimeStamp">退货timestamp</param>
        /// <returns></returns>
        public string GetMonthSaleDataSql(string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select goods_amount as salemoney ,0 as backmoney,oi.admin_user_name,from_unixtime(oi.erp_time, '%y-%m-%d') as datetime");
            strSql.Append("	from ecs_order_info as oi");
            strSql.Append("	where oi.order_status !=9 and erp_order_sn like '%" + yearMonth + "%' and erp_time<>0");
            strSql.Append(" union all ");
            strSql.Append(" select 0 as salemoney, d.je as backmoney, x.xm as admin_user_name,date(d.rq) as datetime");
            strSql.Append("	from djkck as d");
            strSql.Append("	inner join xlkck as x on x.djhm=d.djhm");
            strSql.Append("	where d.rq like '%" + yearMonth + "%' and d.je<0 and date(d.rq)<'" + returnDateTime + "'");
            strSql.Append(" union all ");
            strSql.Append(" select 0 as salemoney,cast(ret_money_total as decimal(18,2)) as backmoney,user_admin_name,from_unixtime(e.erp_time, '%y-%m-%d') as datetime");
            strSql.Append("	from ecs_return_order as e");
            strSql.Append("	where from_unixtime(e.erp_time, '%Y-%m') like '%" + yearMonth + "%' and e.ret_money_total<0 and e.erp_time>=" + returnTimeStamp);
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接月份数据字符串
        /// sql sum(cast(ret_money_total as decimal(18,2))),数据库为float类型，转为decimal，防止相加出现.999999999
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <param name="returnDateTime">退货日期</param>
        /// <param name="returnTimeStamp">退货timestamp</param>
        /// <returns></returns>
        public string GetNodeSaleDataSql(string node_oneA, string node_oneB, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select goods_amount as salemoney , 0 as backmoney,oi.admin_user_name,from_unixtime(oi.erp_time, '%y-%m-%d') as datetime ");
            strSql.Append(" from ecs_order_info as oi ");
            strSql.Append(" where oi.order_status !=9 and oi.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneA)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59)));
            strSql.Append(" union all ");
            strSql.Append(" select 0 as salemoney,d.je as backmoney,x.xm as admin_user_name,date(d.rq) as datetime ");
            strSql.Append(" from djkck as d ");
            strSql.Append(" inner join xlkck as x on x.djhm=d.djhm ");
            strSql.Append(" where date(d.RQ) >='" + DateTime.Parse(node_oneA) + "' and date(d.RQ)<='" + DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59) + "' and d.je<0 and date(d.RQ)<'" + returnDateTime + "'");
            strSql.Append(" union all ");
            strSql.Append(" select 0 as salemoney, cast(ret_money_total as decimal(18,2)) as backmoney, user_admin_name,from_unixtime(e.erp_time, '%y-%m-%d') as datetime");
            strSql.Append(" FROM ecs_return_order AS e ");
            strSql.Append(" where  e.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneA)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59)) + " and e.ret_money_total<0  and e.erp_time>=" + returnTimeStamp);
            
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接年数据字符串sql
        /// </summary>
        /// <param name="yearMonth">年</param>
        /// <param name="returnDateTime">退货日期</param>
        /// <param name="returnTimeStamp">退货timestamp</param>
        /// <returns></returns>
        public string GetYearSaleDataSql(string year, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select goods_amount as salemoney, 0 as backmoney, oi.admin_user_name, from_unixtime(oi.erp_time, '%m') as datetime");
            strSql.Append(" from ecs_order_info as oi");
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like '%" + year + "%' and erp_time<>0");
            strSql.Append(" union all ");
            strSql.Append(" select 0 as salemoney, d.je as backmoney, x.xm as admin_user_name, lpad(month(d.rq), 2, 0) as datetime");
            strSql.Append(" from djkck as d");
            strSql.Append(" inner join xlkck as x on x.djhm=d.djhm");
            strSql.Append(" where d.rq like '%" + year + "%' and d.je<0 and date(d.rq)<'" + returnDateTime + "'");
            strSql.Append(" union all ");
            strSql.Append(" select 0 as salemoney, cast(ret_money_total as decimal(18,2)) as backmoney, user_admin_name, from_unixtime(e.erp_time, '%m') as datetime");
            strSql.Append(" from ecs_return_order as e");
            strSql.Append(" where from_unixtime(e.erp_time, '%Y') like '%" + year + "%' and e.ret_money_total<0 and e.erp_time>=" + returnTimeStamp);
            return strSql.ToString();
        }

        #endregion

        #region 品牌
        /// <summary>
        /// 拼接月份含品牌数据字符串
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <param name="returnDateTime">退货日期</param>
        /// <param name="returnTimeStamp">退货timestamp</param>
        /// <returns></returns>
        public string GetMonthBrandSaleDataSql(string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("   select og.goods_price*og.goods_number AS salemoney, 0 as backmoney,oi.admin_user_name,");
            strSql.Append("   case when brand_id in(select bp_brand_id from ecs_brand_percentage) then brand_id else 0 end brand_id,from_unixtime(oi.erp_time, '%y-%m-%d') as datetime ");
            strSql.Append("    FROM ecs_order_goods AS og ");
            strSql.Append("    left JOIN ecs_goods AS g ON g.goods_id=og.goods_id ");
            strSql.Append("    left JOIN ecs_order_info AS oi ON oi.order_id=og.order_id ");
            strSql.Append("    where oi.order_status !=9 and erp_order_sn like '%" + yearMonth + "%'  and erp_time<>0  ");
            strSql.Append("    union all  ");
            strSql.Append("    select 0 as salemoney, d.je as backmoney,x.xm as admin_user_name,g.brand_id,date(d.rq) as datetime ");
            strSql.Append("    from djkck as d ");
            strSql.Append("    left JOIN ecs_goods AS g ON d.bm=g.goods_id ");
            strSql.Append("    inner join xlkck as x on x.djhm=d.djhm ");
            strSql.Append("    where d.rq like '%" + yearMonth + "%' and d.je<0 and date(d.RQ)<'" + returnDateTime + "'");
            strSql.Append("    union all  ");
            strSql.Append("    select 0 as salemoney,cast(-rg.goods_price*rg.goods_number as decimal(18,2)) as backmoney,user_admin_name,g.brand_id,from_unixtime(e.erp_time, '%y-%m-%d') as datetime ");
            strSql.Append("    from ecs_return_order as e ");
            strSql.Append("    left join ecs_return_goods rg on e.return_id=rg.return_id ");
            strSql.Append("    left join ecs_goods as g on rg.goods_id=g.goods_id ");
            strSql.Append("    where from_unixtime(e.erp_time, '%Y-%m') like '%" + yearMonth + "%' and e.ret_money_total<0  and e.erp_time>=" + returnTimeStamp);
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接月份数据字符串，含品牌
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <param name="returnDateTime">退货日期</param>
        /// <param name="returnTimeStamp">退货timestamp</param>
        /// <returns></returns>
        public string GetYearBrandSaleDataSql(string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("   SELECT og.goods_price*og.goods_number AS salemoney, 0 as backmoney,oi.admin_user_name, ");
            strSql.Append("   case when brand_id in(select bp_brand_id from ecs_brand_percentage) then brand_id else 0 end brand_id,from_unixtime(oi.erp_time, '%m') as datetime ");
            strSql.Append("    FROM ecs_order_goods AS og ");
            strSql.Append("    left JOIN ecs_goods AS g ON g.goods_id=og.goods_id ");
            strSql.Append("    left JOIN ecs_order_info AS oi ON oi.order_id=og.order_id ");
            strSql.Append("    where oi.order_status !=9  and erp_order_sn like '%" + yearMonth + "%'  and erp_time<>0  ");
            strSql.Append("    union all  ");
            strSql.Append("    select 0 as salemoney, d.je as backmoney,x.xm as admin_user_name,g.brand_id,lpad(month(d.rq), 2, 0) as datetime ");
            strSql.Append("    from djkck as d ");
            strSql.Append("    left JOIN ecs_goods AS g ON d.bm=g.goods_id ");
            strSql.Append("    inner join xlkck as x on x.djhm=d.djhm ");
            strSql.Append("    where d.rq like '%" + yearMonth + "%' and d.je<0 and date(d.RQ)<'" + returnDateTime + "'");
            strSql.Append("    union all  ");
            strSql.Append("    select 0 as salemoney,cast(-rg.goods_price*rg.goods_number as decimal(18,2)) as backmoney,user_admin_name,g.brand_id,from_unixtime(e.erp_time, '%m') as datetime ");
            strSql.Append("    from ecs_return_order as e ");
            strSql.Append("    left join ecs_return_goods rg on e.return_id=rg.return_id ");
            strSql.Append("    left join ecs_goods as g on rg.goods_id=g.goods_id ");
            strSql.Append("    where from_unixtime(e.erp_time, '%Y') like '%" + yearMonth + "%' and e.ret_money_total<0 and e.erp_time>=" + returnTimeStamp);
            return strSql.ToString();
        }
        #endregion

        #region 客户
        /// <summary>
        /// 拼接月份数据字符串，含客户
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <param name="returnDateTime">退货日期</param>
        /// <param name="returnTimeStamp">退货timestamp</param>
        /// <returns></returns>
        public string GetCustomerMonthSaleSql(string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select user_id,goods_amount as salemoney ,0 as backmoney,oi.admin_user_name,from_unixtime(oi.erp_time, '%y-%m-%d') as datetime");
            strSql.Append("	from ecs_order_info as oi");
            strSql.Append("	where oi.order_status !=9 and erp_order_sn like '%" + yearMonth + "%' and erp_time<>0");
            strSql.Append(" union all ");
            strSql.Append(" select dwmc AS user_id,0 as salemoney, d.je as backmoney, x.xm as admin_user_name,date(d.rq) as datetime");
            strSql.Append("	from djkck as d");
            strSql.Append("	inner join xlkck as x on x.djhm=d.djhm");
            strSql.Append("	where d.rq like '%" + yearMonth + "%' and d.je<0 and date(d.rq)<'" + returnDateTime + "'");
            strSql.Append(" union all ");
            strSql.Append(" select user_id,0 as salemoney,cast(ret_money_total as decimal(18,2)) as backmoney,user_admin_name,from_unixtime(e.erp_time, '%y-%m-%d') as datetime");
            strSql.Append("	from ecs_return_order as e");
            strSql.Append("	where from_unixtime(e.erp_time, '%Y-%m') like '%" + yearMonth + "%' and e.ret_money_total<0 and e.erp_time>=" + returnTimeStamp);
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接年数据字符串sql，含客户
        /// </summary>
        /// <param name="yearMonth">年</param>
        /// <param name="returnDateTime">退货日期</param>
        /// <param name="returnTimeStamp">退货timestamp</param>
        /// <returns></returns>
        public string GetCustomerYearSaleSql(string year, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select user_id,goods_amount as salemoney, 0 as backmoney, oi.admin_user_name, from_unixtime(oi.erp_time, '%m') as datetime");
            strSql.Append(" from ecs_order_info as oi");
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like '%" + year + "%' and erp_time<>0");
            strSql.Append(" union all ");
            strSql.Append(" select dwmc AS user_id,0 as salemoney, d.je as backmoney, x.xm as admin_user_name, lpad(month(d.rq), 2, 0) as datetime");
            strSql.Append(" from djkck as d");
            strSql.Append(" inner join xlkck as x on x.djhm=d.djhm");
            strSql.Append(" where d.rq like '%" + year + "%' and d.je<0 and date(d.rq)<'" + returnDateTime + "'");
            strSql.Append(" union all ");
            strSql.Append(" select user_id,0 as salemoney, cast(ret_money_total as decimal(18,2)) as backmoney, user_admin_name, from_unixtime(e.erp_time, '%m') as datetime");
            strSql.Append(" from ecs_return_order as e");
            strSql.Append(" where from_unixtime(e.erp_time, '%Y') like '%" + year + "%' and e.ret_money_total<0 and e.erp_time>=" + returnTimeStamp);
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接月份数据字符串，含品牌单品
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <param name="returnDateTime">退货日期</param>
        /// <param name="returnTimeStamp">退货timestamp</param>
        /// <returns></returns>
        public string GetCustomerMonthBrandGoodsSaleSql(string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("         SELECT oi.user_id,(og.goods_price*og.goods_number) AS salemoney,0 AS backmoney,og.goods_number,");
            strSql.Append("                 oi.admin_user_name,");
            strSql.Append("                 g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            strSql.Append("                 from_unixtime(oi.erp_time, '%m') AS datetime,");
            strSql.Append("                 from_unixtime(oi.erp_time, '%y-%m-%d') AS orderdate");
            strSql.Append("          FROM ecs_order_goods AS og");
            strSql.Append("          left join ecs_goods AS g ON g.goods_id=og.goods_id");
            strSql.Append("          left join ecs_order_info AS oi ON oi.order_id=og.order_id");
            strSql.Append(" 		 left join ecs_brand as bd on g.brand_id=bd.brand_id");
            strSql.Append("          where oi.order_status !=9");
            strSql.Append("          AND erp_order_sn LIKE '%" + yearMonth + "%'");
            strSql.Append("          AND erp_time<>0");
            strSql.Append(" union all");
            strSql.Append(" SELECT x.DWMC user_id,0 AS salemoney,d.je AS backmoney,d.sl as goods_number, ");
            strSql.Append("                           x.xm AS admin_user_name,");
            strSql.Append("                           g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            strSql.Append("                           lpad(month(d.rq), 2, 0) as datetime, ");
            strSql.Append("                           date(d.rq) AS orderdate");
            strSql.Append("          FROM djkck AS d");
            strSql.Append("          left join ecs_goods AS g ON d.bm=g.goods_id");
            strSql.Append("          inner join xlkck AS x ON x.djhm=d.djhm");
            strSql.Append(" 		 left join ecs_brand as bd on g.brand_id=bd.brand_id");
            strSql.Append("          WHERE d.rq LIKE '%" + yearMonth + "%'");
            strSql.Append("            AND d.je<0");
            strSql.Append("            AND date(d.RQ)<'" + returnDateTime + "' ");
            strSql.Append(" union all");
            strSql.Append(" SELECT user_id,0 AS salemoney,cast(ret_money_total AS decimal(18,2)) AS backmoney,rg.goods_number,");
            strSql.Append("                           e.user_admin_name,");
            strSql.Append("                           g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            strSql.Append("                           from_unixtime(e.erp_time, '%m') AS datetime,");
            strSql.Append("                           from_unixtime(e.erp_time, '%y-%m-%d') AS orderdate");
            strSql.Append("          FROM ecs_return_order AS e");
            strSql.Append("          LEFT JOIN ecs_return_goods rg ON e.return_id=rg.return_id");
            strSql.Append("          LEFT JOIN ecs_goods AS g ON rg.goods_id=g.goods_id");
            strSql.Append(" 		 left join ecs_brand as bd on g.brand_id=bd.brand_id");
            strSql.Append("          WHERE from_unixtime(e.erp_time, '%Y-%m') LIKE '%" + yearMonth + "%'");
            strSql.Append("            AND e.ret_money_total<0");
            strSql.Append("            AND e.erp_time>=" + returnTimeStamp);
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接年数据字符串sql，含品牌单品
        /// </summary>
        /// <param name="yearMonth">年</param>
        /// <param name="returnDateTime">退货日期</param>
        /// <param name="returnTimeStamp">退货timestamp</param>
        /// <returns></returns>
        public string GetCustomerYearBrandGoodsSaleSql(string year, DateTime returnDateTime, string returnTimeStamp)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT oi.user_id,(og.goods_price*og.goods_number) AS salemoney,0 AS backmoney,og.goods_number,");
            strSql.Append("                 oi.admin_user_name,");
            strSql.Append("                 g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            strSql.Append("                 from_unixtime(oi.erp_time, '%m') AS datetime,");
            strSql.Append("                 from_unixtime(oi.erp_time, '%y-%m-%d') AS orderdate");
            strSql.Append("          FROM ecs_order_goods AS og");
            strSql.Append("          left join ecs_goods AS g ON g.goods_id=og.goods_id");
            strSql.Append("          left join ecs_order_info AS oi ON oi.order_id=og.order_id");
            strSql.Append(" 		 left join ecs_brand as bd on g.brand_id=bd.brand_id");
            strSql.Append("          where oi.order_status !=9");
            strSql.Append("          AND erp_order_sn LIKE '%" + year + "%'");
            strSql.Append("          AND erp_time<>0");
            strSql.Append(" union all");
            strSql.Append(" SELECT x.DWMC user_id,0 AS salemoney,d.je AS backmoney,d.sl as goods_number,");
            strSql.Append("                           x.xm AS admin_user_name,");
            strSql.Append("                           g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            strSql.Append("                           lpad(month(d.rq), 2, 0) as datetime, ");
            strSql.Append("                           date(d.rq) AS orderdate");
            strSql.Append("          FROM djkck AS d");
            strSql.Append("          left join ecs_goods AS g ON d.bm=g.goods_id");
            strSql.Append("          INNER JOIN xlkck AS x ON x.djhm=d.djhm");
            strSql.Append(" 		 left join ecs_brand as bd on g.brand_id=bd.brand_id");
            strSql.Append("          WHERE d.rq LIKE '%" + year + "%'");
            strSql.Append("            AND d.je<0");
            strSql.Append("            AND date(d.RQ)<'" + returnDateTime + "' ");
            strSql.Append(" union all");
            strSql.Append(" SELECT user_id,0 AS salemoney,cast(ret_money_total AS decimal(18,2)) AS backmoney,rg.goods_number,");
            strSql.Append("                           e.user_admin_name,");
            strSql.Append("                           g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            strSql.Append("                           from_unixtime(e.erp_time, '%m') AS datetime,");
            strSql.Append("                           from_unixtime(e.erp_time, '%y-%m-%d') AS orderdate");
            strSql.Append("          FROM ecs_return_order AS e");
            strSql.Append("          LEFT JOIN ecs_return_goods rg ON e.return_id=rg.return_id");
            strSql.Append("          LEFT JOIN ecs_goods AS g ON rg.goods_id=g.goods_id");
            strSql.Append(" 		 left join ecs_brand as bd on g.brand_id=bd.brand_id");
            strSql.Append("          WHERE from_unixtime(e.erp_time, '%Y') LIKE '%" + year + "%'");
            strSql.Append("            AND e.ret_money_total<0");
            strSql.Append("            AND e.erp_time>=" + returnTimeStamp);
            return strSql.ToString();
        }

        #endregion








        #endregion

        #endregion  ExtensionMethod
    }
}
