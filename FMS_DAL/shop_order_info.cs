using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:shop_order_info
    /// </summary>
    public partial class shop_order_info
    {
        public shop_order_info()
        { }

        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int order_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_order_info");
            strSql.Append(" where order_id=@order_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id",  MySqlDbType.Int16,8)		};
            parameters[0].Value = order_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int order_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_order_info ");
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
            strSql.Append("delete from shop_order_info ");
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
        /// 更新一条数据
        /// </summary>
        public bool updateShipFee(string orderId, decimal shipping_fee)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" update  shop_order_info  set deduction_shipping_fee='" + shipping_fee + "' where order_id='" + orderId + "'");
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
        public FMS_Model.shop_order_info GetModel(int order_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select order_id,order_sn,wms_order_sn,erp_order_sn,cwerp_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,postscript,order_note,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,to_buyer,pay_note,agency_id,inv_type,tax,discount,wuliu_id,wuliu_name,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,operator,det_stats,dealer_id,is_show_price,operator_user_id,invoice_weight,order_confirm_info,invoice_id,wms_setbook_id,wms_doc_id,wms_account_flag,wms_receive_note,wms_flow_no,wms_finish_amout,wms_unfinish_amout,wms_invoice_type,wms_account_type,wms_voucher,wms_amount,wms_storage,supply_user_id,is_invoice_advance from shop_order_info ");
            strSql.Append(" where order_id=@order_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int16,8)			};
            parameters[0].Value = order_id;

            FMS_Model.shop_order_info model = new FMS_Model.shop_order_info();
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
        public FMS_Model.shop_order_info DataRowToModel(DataRow row)
        {
            FMS_Model.shop_order_info model = new FMS_Model.shop_order_info();
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
                if (row["wuliu_id"] != null && row["wuliu_id"].ToString() != "")
                {
                    model.wuliu_id = int.Parse(row["wuliu_id"].ToString());
                }
                if (row["wuliu_name"] != null)
                {
                    model.wuliu_name = row["wuliu_name"].ToString();
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
                //if(row["operator"]!=null)
                //{
                //    model.operator=row["operator"].ToString();
                //}
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
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select order_id,order_sn,wms_order_sn,erp_order_sn,cwerp_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,postscript,order_note,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,to_buyer,pay_note,agency_id,inv_type,tax,discount,wuliu_id,wuliu_name,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,operator,det_stats,dealer_id,is_show_price,operator_user_id,invoice_weight,order_confirm_info,invoice_id,wms_setbook_id,wms_doc_id,wms_account_flag,wms_receive_note,wms_flow_no,wms_finish_amout,wms_unfinish_amout,wms_invoice_type,wms_account_type,wms_voucher,wms_amount,wms_storage,supply_user_id,is_invoice_advance ");
            strSql.Append(" FROM shop_order_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select order_id,order_sn,wms_order_sn,erp_order_sn,cwerp_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,postscript,order_note,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,to_buyer,pay_note,agency_id,inv_type,tax,discount,wuliu_id,wuliu_name,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,operator,det_stats,dealer_id,is_show_price,operator_user_id,invoice_weight,order_confirm_info,invoice_id,wms_setbook_id,wms_doc_id,wms_account_flag,wms_receive_note,wms_flow_no,wms_finish_amout,wms_unfinish_amout,wms_invoice_type,wms_account_type,wms_voucher,wms_amount,wms_storage,supply_user_id,is_invoice_advance ");
            strSql.Append(" FROM shop_order_info ");
            strSql1.Append(" select count(1) FROM shop_order_info");
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListJson(int PageSize, int PageIndex, DataTable dt, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select distinct * from ( ");
            strSql1.Append(" select count(distinct order_id) from ( ");

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        strSql.Append("select order_id,order_sn,wms_order_sn,erp_order_sn,cwerp_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,postscript,order_note,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,to_buyer,pay_note,agency_id,inv_type,tax,discount,wuliu_id,wuliu_name,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,operator,det_stats,dealer_id,is_show_price,operator_user_id,invoice_weight,order_confirm_info,invoice_id,wms_setbook_id,wms_doc_id,wms_account_flag,wms_receive_note,wms_flow_no,wms_finish_amout,wms_unfinish_amout,wms_invoice_type,wms_account_type,wms_voucher,wms_amount,wms_storage,supply_user_id,is_invoice_advance ");
                        strSql.Append(" FROM shop_order_info ");
                        strSql.Append(" where  user_id ='" + dt.Rows[i]["userId"].ToString() + "'and order_status !=9 and add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");

                        strSql1.Append("select * FROM shop_order_info ");
                        strSql1.Append(" where  user_id ='" + dt.Rows[i]["userId"].ToString() + "'and order_status !=9 and add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                    }
                    else
                    {
                        strSql.Append(" union all select order_id,order_sn,wms_order_sn,erp_order_sn,cwerp_order_sn,user_id,order_status,shipping_status,pay_status,consignee,country,province,city,district,address,role_id,user_market_area,zipcode,tel,mobile,email,postscript,order_note,shipping_id,shipping_name,is_no_shipping_fee,pay_id,pay_name,trans_bank_id,trans_bank_name,inv_payee,inv_content,goods_amount,shipping_fee,insure_fee,pay_fee,pack_fee,money_paid,surplus,integral,integral_money,bonus,order_amount,from_ad,referer,add_time,confirm_time,pay_time,shipping_time,pack_id,card_id,bonus_id,invoice_no,to_buyer,pay_note,agency_id,inv_type,tax,discount,wuliu_id,wuliu_name,need_inv,is_send2_erp,is_send2_cwerp,is_wuliu_img,get_pay_type,is_daifa,is_no_qingdan,admin_user_id,admin_user_name,admin_user_real_name,send_user_name,send_user_tel,send_user_company,send_user_address,cangku_id,payinfo_pic,is_confirm_remind,is_print_remind,order_ip,cwerp_time,erp_time,is_need_review,review_info,operator,det_stats,dealer_id,is_show_price,operator_user_id,invoice_weight,order_confirm_info,invoice_id,wms_setbook_id,wms_doc_id,wms_account_flag,wms_receive_note,wms_flow_no,wms_finish_amout,wms_unfinish_amout,wms_invoice_type,wms_account_type,wms_voucher,wms_amount,wms_storage,supply_user_id,is_invoice_advance ");
                        strSql.Append(" FROM shop_order_info ");
                        strSql.Append(" where  user_id ='" + dt.Rows[i]["userId"].ToString() + "'and order_status !=9 and add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");

                        strSql1.Append(" union all select * FROM shop_order_info ");
                        strSql1.Append(" where  user_id ='" + dt.Rows[i]["userId"].ToString() + "'and order_status !=9 and add_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                    }
                }
            }

            strSql.Append(" ) as ab ");
            strSql1.Append(" ) as ab ");

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        //获得某订单下的所有商品、运费等信息
        public DataSet orderCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum(goodsNum) goodsNum,sum(shipMoney) shipMoney,sum(totalMoney) totalMoney,sum(shipping_fee) as shipping_fee from (");
            strSql.Append(" select  sum(g.goods_number) as goodsNum, (o.shipping_fee-o.deduction_shipping_fee) as shipMoney,o.shipping_fee, sum(g.goods_number*g.goods_price)+o.shipping_fee  as totalMoney  ");
            strSql.Append(" from shop_order_goods g inner join shop_order_info o on g.order_id=o.order_id  where g.order_id in(" + strWhere + ")  group by g.order_id");
            strSql.Append(") abc ");
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        //获得客户的其他费用
        public string GetOtherAmoun(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(shipping_fee- discount + tax + insure_fee + pay_fee + pack_fee ) as num from shop_order_info ");
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

