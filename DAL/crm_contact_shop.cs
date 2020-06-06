﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_contact_shop
    /// </summary>
    public partial class crm_contact_shop
    {
        public crm_contact_shop()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "crm_contact");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_contact");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsLink(int customerid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CRM_Contact");
            strSql.Append(" where C_customerid=@customerid and IsDefaultContact=1 and isDelete=0 ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@customerid", MySqlDbType.Int32,4)};
            parameters[0].Value = customerid;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.crm_contact_shop model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_contact(");
            strSql.Append("id,Factory_Id,user_name,password,auth_key,last_login,last_ip,user_avatar,bind_email,safe_question,safe_answer,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_extentel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid,C_customername,C_createId,C_createDate,isDelete,Delete_time,IsDefaultContact,ec_is_bill_list,ec_is_bill_list_show_price,ec_is_send_sms_when_delivery,ec_is_daifa,ec_daifa_user_name,ec_daifa_phone,ec_daifa_company,ec_daifa_address,invoice_type,invoice_content,is_invoice_change,tax_company_name,tax_company_add_tel,tax_tax_code,tax_bank_name,tax_bank_num,bill_bank_code1,bill_bank_code2,bill_bank_code3,bill_bank_code4,bill_bank_code5,bill_bank_code6,bill_alipay_code,bill_wei_code,credit_day,credit_date,credit_total,erp_user_code,is_erp_archives,aite_user_name,is_send_account,last_send_account,send_account_time,user_from,user_group,user_grade,legal_representative,is_account_lock,account_lock_note)");
            strSql.Append(" values (");
            strSql.Append("@id,@Factory_Id,@user_name,@password,@auth_key,@last_login,@last_ip,@user_avatar,@bind_email,@safe_question,@safe_answer,@C_name,@C_sex,@C_department,@C_position,@C_birthday,@C_tel,@C_extentel,@C_fax,@C_email,@C_mobone,@C_mobtwo,@C_QQ,@C_add,@C_hobby,@C_remarks,@C_customerid,@C_customername,@C_createId,@C_createDate,@isDelete,@Delete_time,@IsDefaultContact,@ec_is_bill_list,@ec_is_bill_list_show_price,@ec_is_send_sms_when_delivery,@ec_is_daifa,@ec_daifa_user_name,@ec_daifa_phone,@ec_daifa_company,@ec_daifa_address,@invoice_type,@invoice_content,@is_invoice_change,@tax_company_name,@tax_company_add_tel,@tax_tax_code,@tax_bank_name,@tax_bank_num,@bill_bank_code1,@bill_bank_code2,@bill_bank_code3,@bill_bank_code4,@bill_bank_code5,@bill_bank_code6,@bill_alipay_code,@bill_wei_code,@credit_day,@credit_date,@credit_total,@erp_user_code,@is_erp_archives,@aite_user_name,@is_send_account,@last_send_account,@send_account_time,@user_from,@user_group,@user_grade,@legal_representative,@is_account_lock,@account_lock_note)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@password", MySqlDbType.VarChar,32),
					new MySqlParameter("@auth_key", MySqlDbType.VarChar,32),
					new MySqlParameter("@last_login", MySqlDbType.DateTime),
					new MySqlParameter("@last_ip", MySqlDbType.VarChar,15),
					new MySqlParameter("@user_avatar", MySqlDbType.VarChar,200),
					new MySqlParameter("@bind_email", MySqlDbType.Int32,2),
					new MySqlParameter("@safe_question", MySqlDbType.VarChar,200),
					new MySqlParameter("@safe_answer", MySqlDbType.VarChar,200),
					new MySqlParameter("@C_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_sex", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_department", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_position", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_birthday", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_tel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_extentel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_fax", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_email", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobone", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobtwo", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_QQ", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_add", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_hobby", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_remarks", MySqlDbType.LongText),
					new MySqlParameter("@C_customerid", MySqlDbType.Int32,11),
					new MySqlParameter("@C_customername", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,11),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime),
					new MySqlParameter("@IsDefaultContact", MySqlDbType.Int32,11),
					new MySqlParameter("@ec_is_bill_list", MySqlDbType.Int32,2),
					new MySqlParameter("@ec_is_bill_list_show_price", MySqlDbType.Int32,2),
					new MySqlParameter("@ec_is_send_sms_when_delivery", MySqlDbType.Int32,2),
					new MySqlParameter("@ec_is_daifa", MySqlDbType.Int32,2),
					new MySqlParameter("@ec_daifa_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@ec_daifa_phone", MySqlDbType.VarChar,16),
					new MySqlParameter("@ec_daifa_company", MySqlDbType.VarChar,60),
					new MySqlParameter("@ec_daifa_address", MySqlDbType.VarChar,120),
					new MySqlParameter("@invoice_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@invoice_content", MySqlDbType.VarChar,60),
					new MySqlParameter("@is_invoice_change", MySqlDbType.Int32,2),
					new MySqlParameter("@tax_company_name", MySqlDbType.VarChar,40),
					new MySqlParameter("@tax_company_add_tel", MySqlDbType.VarChar,120),
					new MySqlParameter("@tax_tax_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax_bank_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax_bank_num", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code1", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code2", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code3", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code4", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code5", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code6", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_alipay_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_wei_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@credit_day", MySqlDbType.Int32,4),
					new MySqlParameter("@credit_date", MySqlDbType.Int32,11),
					new MySqlParameter("@credit_total", MySqlDbType.Decimal,11),
					new MySqlParameter("@erp_user_code", MySqlDbType.VarChar,30),
					new MySqlParameter("@is_erp_archives", MySqlDbType.Int32,2),
					new MySqlParameter("@aite_user_name", MySqlDbType.VarChar,13),
					new MySqlParameter("@is_send_account", MySqlDbType.Int32,2),
					new MySqlParameter("@last_send_account", MySqlDbType.Int32,11),
					new MySqlParameter("@send_account_time", MySqlDbType.Int32,11),
					new MySqlParameter("@user_from", MySqlDbType.VarChar,30),
					new MySqlParameter("@user_group", MySqlDbType.Int32,3),
					new MySqlParameter("@user_grade", MySqlDbType.Int32,3),
        	        new MySqlParameter("@legal_representative", MySqlDbType.VarChar,20),
                    new MySqlParameter("@is_account_lock", MySqlDbType.Int32,2), 
                    new MySqlParameter("@account_lock_note", MySqlDbType.VarChar,225)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.Factory_Id;
            parameters[2].Value = model.user_name;
            parameters[3].Value = model.password;
            parameters[4].Value = model.auth_key;
            parameters[5].Value = model.last_login;
            parameters[6].Value = model.last_ip;
            parameters[7].Value = model.user_avatar;
            parameters[8].Value = model.bind_email;
            parameters[9].Value = model.safe_question;
            parameters[10].Value = model.safe_answer;
            parameters[11].Value = model.C_name;
            parameters[12].Value = model.C_sex;
            parameters[13].Value = model.C_department;
            parameters[14].Value = model.C_position;
            parameters[15].Value = model.C_birthday;
            parameters[16].Value = model.C_tel;
            parameters[17].Value = model.C_extentel;
            parameters[18].Value = model.C_fax;
            parameters[19].Value = model.C_email;
            parameters[20].Value = model.C_mobone;
            parameters[21].Value = model.C_mobtwo;
            parameters[22].Value = model.C_QQ;
            parameters[23].Value = model.C_add;
            parameters[24].Value = model.C_hobby;
            parameters[25].Value = model.C_remarks;
            parameters[26].Value = model.C_customerid;
            parameters[27].Value = model.C_customername;
            parameters[28].Value = model.C_createId;
            parameters[29].Value = model.C_createDate;
            parameters[30].Value = model.isDelete;
            parameters[31].Value = model.Delete_time;
            parameters[32].Value = model.IsDefaultContact;
            parameters[33].Value = model.ec_is_bill_list;
            parameters[34].Value = model.ec_is_bill_list_show_price;
            parameters[35].Value = model.ec_is_send_sms_when_delivery;
            parameters[36].Value = model.ec_is_daifa;
            parameters[37].Value = model.ec_daifa_user_name;
            parameters[38].Value = model.ec_daifa_phone;
            parameters[39].Value = model.ec_daifa_company;
            parameters[40].Value = model.ec_daifa_address;
            parameters[41].Value = model.invoice_type;
            parameters[42].Value = model.invoice_content;
            parameters[43].Value = model.is_invoice_change;
            parameters[44].Value = model.tax_company_name;
            parameters[45].Value = model.tax_company_add_tel;
            parameters[46].Value = model.tax_tax_code;
            parameters[47].Value = model.tax_bank_name;
            parameters[48].Value = model.tax_bank_num;
            parameters[49].Value = model.bill_bank_code1;
            parameters[50].Value = model.bill_bank_code2;
            parameters[51].Value = model.bill_bank_code3;
            parameters[52].Value = model.bill_bank_code4;
            parameters[53].Value = model.bill_bank_code5;
            parameters[54].Value = model.bill_bank_code6;
            parameters[55].Value = model.bill_alipay_code;
            parameters[56].Value = model.bill_wei_code;
            parameters[57].Value = model.credit_day;
            parameters[58].Value = model.credit_date;
            parameters[59].Value = model.credit_total;
            parameters[60].Value = model.erp_user_code;
            parameters[61].Value = model.is_erp_archives;
            parameters[62].Value = model.aite_user_name;
            parameters[63].Value = model.is_send_account;
            parameters[64].Value = model.last_send_account;
            parameters[65].Value = model.send_account_time;
            parameters[66].Value = model.user_from;
            parameters[67].Value = model.user_group;
            parameters[68].Value = model.user_grade;
            parameters[69].Value = model.legal_representative;
            parameters[70].Value = model.is_account_lock;
            parameters[71].Value = model.account_lock_note;

            object obj = DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(XHD.Model.crm_contact_shop model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_contact set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("user_name=@user_name,");
            strSql.Append("password=@password,");
            strSql.Append("auth_key=@auth_key,");
            strSql.Append("last_login=@last_login,");
            strSql.Append("last_ip=@last_ip,");
            strSql.Append("user_avatar=@user_avatar,");
            strSql.Append("bind_email=@bind_email,");
            strSql.Append("safe_question=@safe_question,");
            strSql.Append("safe_answer=@safe_answer,");
            strSql.Append("C_name=@C_name,");
            strSql.Append("C_sex=@C_sex,");
            strSql.Append("C_department=@C_department,");
            strSql.Append("C_position=@C_position,");
            strSql.Append("C_birthday=@C_birthday,");
            strSql.Append("C_tel=@C_tel,");
            strSql.Append("C_extentel=@C_extentel,");
            strSql.Append("C_fax=@C_fax,");
            strSql.Append("C_email=@C_email,");
            strSql.Append("C_mobone=@C_mobone,");
            strSql.Append("C_mobtwo=@C_mobtwo,");
            strSql.Append("C_QQ=@C_QQ,");
            strSql.Append("C_add=@C_add,");
            strSql.Append("C_hobby=@C_hobby,");
            strSql.Append("C_remarks=@C_remarks,");
            strSql.Append("C_customerid=@C_customerid,");
            strSql.Append("C_customername=@C_customername,");
            strSql.Append("C_createId=@C_createId,");
            strSql.Append("C_createDate=@C_createDate,");
            strSql.Append("isDelete=@isDelete,");
            strSql.Append("Delete_time=@Delete_time,");
            strSql.Append("IsDefaultContact=@IsDefaultContact,");
            strSql.Append("ec_is_bill_list=@ec_is_bill_list,");
            strSql.Append("ec_is_bill_list_show_price=@ec_is_bill_list_show_price,");
            strSql.Append("ec_is_send_sms_when_delivery=@ec_is_send_sms_when_delivery,");
            strSql.Append("ec_is_daifa=@ec_is_daifa,");
            strSql.Append("ec_daifa_user_name=@ec_daifa_user_name,");
            strSql.Append("ec_daifa_phone=@ec_daifa_phone,");
            strSql.Append("ec_daifa_company=@ec_daifa_company,");
            strSql.Append("ec_daifa_address=@ec_daifa_address,");
            strSql.Append("invoice_type=@invoice_type,");
            strSql.Append("invoice_content=@invoice_content,");
            strSql.Append("is_invoice_change=@is_invoice_change,");
            strSql.Append("tax_company_name=@tax_company_name,");
            strSql.Append("tax_company_add_tel=@tax_company_add_tel,");
            strSql.Append("tax_tax_code=@tax_tax_code,");
            strSql.Append("tax_bank_name=@tax_bank_name,");
            strSql.Append("tax_bank_num=@tax_bank_num,");
            strSql.Append("bill_bank_code1=@bill_bank_code1,");
            strSql.Append("bill_bank_code2=@bill_bank_code2,");
            strSql.Append("bill_bank_code3=@bill_bank_code3,");
            strSql.Append("bill_bank_code4=@bill_bank_code4,");
            strSql.Append("bill_bank_code5=@bill_bank_code5,");
            strSql.Append("bill_bank_code6=@bill_bank_code6,");
            strSql.Append("bill_alipay_code=@bill_alipay_code,");
            strSql.Append("bill_wei_code=@bill_wei_code,");
            strSql.Append("credit_day=@credit_day,");
            strSql.Append("credit_date=@credit_date,");
            strSql.Append("credit_total=@credit_total,");
            strSql.Append("erp_user_code=@erp_user_code,");
            strSql.Append("is_erp_archives=@is_erp_archives,");
            strSql.Append("aite_user_name=@aite_user_name,");
            strSql.Append("is_send_account=@is_send_account,");
            strSql.Append("last_send_account=@last_send_account,");
            strSql.Append("send_account_time=@send_account_time,");
            strSql.Append("user_from=@user_from,");
            strSql.Append("user_group=@user_group,");
            strSql.Append("user_grade=@user_grade,");
            strSql.Append("legal_representative=@legal_representative");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@password", MySqlDbType.VarChar,32),
					new MySqlParameter("@auth_key", MySqlDbType.VarChar,32),
					new MySqlParameter("@last_login", MySqlDbType.DateTime),
					new MySqlParameter("@last_ip", MySqlDbType.VarChar,15),
					new MySqlParameter("@user_avatar", MySqlDbType.VarChar,200),
					new MySqlParameter("@bind_email", MySqlDbType.Int32,1),
					new MySqlParameter("@safe_question", MySqlDbType.VarChar,200),
					new MySqlParameter("@safe_answer", MySqlDbType.VarChar,200),
					new MySqlParameter("@C_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_sex", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_department", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_position", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_birthday", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_tel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_extentel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_fax", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_email", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobone", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobtwo", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_QQ", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_add", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_hobby", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_remarks", MySqlDbType.LongText),
					new MySqlParameter("@C_customerid", MySqlDbType.Int32,11),
					new MySqlParameter("@C_customername", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,11),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime),
					new MySqlParameter("@IsDefaultContact", MySqlDbType.Int32,11),
					new MySqlParameter("@ec_is_bill_list", MySqlDbType.Int32,2),
					new MySqlParameter("@ec_is_bill_list_show_price", MySqlDbType.Int32,2),
					new MySqlParameter("@ec_is_send_sms_when_delivery", MySqlDbType.Int32,2),
					new MySqlParameter("@ec_is_daifa", MySqlDbType.Int32,2),
					new MySqlParameter("@ec_daifa_user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@ec_daifa_phone", MySqlDbType.VarChar,16),
					new MySqlParameter("@ec_daifa_company", MySqlDbType.VarChar,60),
					new MySqlParameter("@ec_daifa_address", MySqlDbType.VarChar,120),
					new MySqlParameter("@invoice_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@invoice_content", MySqlDbType.VarChar,60),
					new MySqlParameter("@is_invoice_change", MySqlDbType.Int32,2),
					new MySqlParameter("@tax_company_name", MySqlDbType.VarChar,40),
					new MySqlParameter("@tax_company_add_tel", MySqlDbType.VarChar,120),
					new MySqlParameter("@tax_tax_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax_bank_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax_bank_num", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code1", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code2", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code3", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code4", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code5", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_bank_code6", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_alipay_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@bill_wei_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@credit_day", MySqlDbType.Int32,4),
					new MySqlParameter("@credit_date", MySqlDbType.Int32,11),
					new MySqlParameter("@credit_total", MySqlDbType.Decimal,11),
					new MySqlParameter("@erp_user_code", MySqlDbType.VarChar,30),
					new MySqlParameter("@is_erp_archives", MySqlDbType.Int32,2),
					new MySqlParameter("@aite_user_name", MySqlDbType.VarChar,13),
					new MySqlParameter("@is_send_account", MySqlDbType.Int32,2),
					new MySqlParameter("@last_send_account", MySqlDbType.Int32,11),
					new MySqlParameter("@send_account_time", MySqlDbType.Int32,11),
					new MySqlParameter("@user_from", MySqlDbType.VarChar,30),
					new MySqlParameter("@user_group", MySqlDbType.Int32,3),
					new MySqlParameter("@user_grade", MySqlDbType.Int32,3),
                    new MySqlParameter("@legal_representative", MySqlDbType.VarChar,20),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.user_name;
            parameters[2].Value = model.password;
            parameters[3].Value = model.auth_key;
            parameters[4].Value = model.last_login;
            parameters[5].Value = model.last_ip;
            parameters[6].Value = model.user_avatar;
            parameters[7].Value = model.bind_email;
            parameters[8].Value = model.safe_question;
            parameters[9].Value = model.safe_answer;
            parameters[10].Value = model.C_name;
            parameters[11].Value = model.C_sex;
            parameters[12].Value = model.C_department;
            parameters[13].Value = model.C_position;
            parameters[14].Value = model.C_birthday;
            parameters[15].Value = model.C_tel;
            parameters[16].Value = model.C_extentel;
            parameters[17].Value = model.C_fax;
            parameters[18].Value = model.C_email;
            parameters[19].Value = model.C_mobone;
            parameters[20].Value = model.C_mobtwo;
            parameters[21].Value = model.C_QQ;
            parameters[22].Value = model.C_add;
            parameters[23].Value = model.C_hobby;
            parameters[24].Value = model.C_remarks;
            parameters[25].Value = model.C_customerid;
            parameters[26].Value = model.C_customername;
            parameters[27].Value = model.C_createId;
            parameters[28].Value = model.C_createDate;
            parameters[29].Value = model.isDelete;
            parameters[30].Value = model.Delete_time;
            parameters[31].Value = model.IsDefaultContact;
            parameters[32].Value = model.ec_is_bill_list;
            parameters[33].Value = model.ec_is_bill_list_show_price;
            parameters[34].Value = model.ec_is_send_sms_when_delivery;
            parameters[35].Value = model.ec_is_daifa;
            parameters[36].Value = model.ec_daifa_user_name;
            parameters[37].Value = model.ec_daifa_phone;
            parameters[38].Value = model.ec_daifa_company;
            parameters[39].Value = model.ec_daifa_address;
            parameters[40].Value = model.invoice_type;
            parameters[41].Value = model.invoice_content;
            parameters[42].Value = model.is_invoice_change;
            parameters[43].Value = model.tax_company_name;
            parameters[44].Value = model.tax_company_add_tel;
            parameters[45].Value = model.tax_tax_code;
            parameters[46].Value = model.tax_bank_name;
            parameters[47].Value = model.tax_bank_num;
            parameters[48].Value = model.bill_bank_code1;
            parameters[49].Value = model.bill_bank_code2;
            parameters[50].Value = model.bill_bank_code3;
            parameters[51].Value = model.bill_bank_code4;
            parameters[52].Value = model.bill_bank_code5;
            parameters[53].Value = model.bill_bank_code6;
            parameters[54].Value = model.bill_alipay_code;
            parameters[55].Value = model.bill_wei_code;
            parameters[56].Value = model.credit_day;
            parameters[57].Value = model.credit_date;
            parameters[58].Value = model.credit_total;
            parameters[59].Value = model.erp_user_code;
            parameters[60].Value = model.is_erp_archives;
            parameters[61].Value = model.aite_user_name;
            parameters[62].Value = model.is_send_account;
            parameters[63].Value = model.last_send_account;
            parameters[64].Value = model.send_account_time;
            parameters[65].Value = model.user_from;
            parameters[66].Value = model.user_group;
            parameters[67].Value = model.user_grade;
            parameters[68].Value = model.legal_representative;
            parameters[69].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_contact ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_contact ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public XHD.Model.crm_contact_shop GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,user_name,password,auth_key,last_login,last_ip,user_avatar,bind_email,safe_question,safe_answer,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_extentel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid,C_customername,C_createId,C_createDate,isDelete,Delete_time,IsDefaultContact,ec_is_bill_list,ec_is_bill_list_show_price,ec_is_send_sms_when_delivery,ec_is_daifa,ec_daifa_user_name,ec_daifa_phone,ec_daifa_company,ec_daifa_address,invoice_type,invoice_content,is_invoice_change,tax_company_name,tax_company_add_tel,tax_tax_code,tax_bank_name,tax_bank_num,bill_bank_code1,bill_bank_code2,bill_bank_code3,bill_bank_code4,bill_bank_code5,bill_bank_code6,bill_alipay_code,bill_wei_code,credit_day,credit_date,credit_total,erp_user_code,is_erp_archives,aite_user_name,is_send_account,last_send_account,send_account_time,user_from,user_group,user_grade,legal_representative,is_account_lock from crm_contact ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.crm_contact_shop model = new XHD.Model.crm_contact_shop();
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
        public XHD.Model.crm_contact_shop DataRowToModel(DataRow row)
        {
            XHD.Model.crm_contact_shop model = new XHD.Model.crm_contact_shop();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["user_name"] != null)
                {
                    model.user_name = row["user_name"].ToString();
                }
                if (row["password"] != null)
                {
                    model.password = row["password"].ToString();
                }
                if (row["auth_key"] != null)
                {
                    model.auth_key = row["auth_key"].ToString();
                }
                if (row["last_login"] != null && row["last_login"].ToString() != "")
                {
                    model.last_login = DateTime.Parse(row["last_login"].ToString());
                }
                if (row["last_ip"] != null)
                {
                    model.last_ip = row["last_ip"].ToString();
                }
                if (row["user_avatar"] != null)
                {
                    model.user_avatar = row["user_avatar"].ToString();
                }
                if (row["bind_email"] != null && row["bind_email"].ToString() != "")
                {
                    model.bind_email = int.Parse(row["bind_email"].ToString());
                }
                if (row["safe_question"] != null)
                {
                    model.safe_question = row["safe_question"].ToString();
                }
                if (row["safe_answer"] != null)
                {
                    model.safe_answer = row["safe_answer"].ToString();
                }
                if (row["C_name"] != null)
                {
                    model.C_name = row["C_name"].ToString();
                }
                if (row["C_sex"] != null)
                {
                    model.C_sex = row["C_sex"].ToString();
                }
                if (row["C_department"] != null)
                {
                    model.C_department = row["C_department"].ToString();
                }
                if (row["C_position"] != null)
                {
                    model.C_position = row["C_position"].ToString();
                }
                if (row["C_birthday"] != null)
                {
                    model.C_birthday = row["C_birthday"].ToString();
                }
                if (row["C_tel"] != null)
                {
                    model.C_tel = row["C_tel"].ToString();
                }
                if (row["C_extentel"] != null)
                {
                    model.C_extentel = row["C_extentel"].ToString();
                }
                if (row["C_fax"] != null)
                {
                    model.C_fax = row["C_fax"].ToString();
                }
                if (row["C_email"] != null)
                {
                    model.C_email = row["C_email"].ToString();
                }
                if (row["C_mobone"] != null)
                {
                    model.C_mobone = row["C_mobone"].ToString();
                }
                if (row["C_mobtwo"] != null)
                {
                    model.C_mobtwo = row["C_mobtwo"].ToString();
                }
                if (row["C_QQ"] != null)
                {
                    model.C_QQ = row["C_QQ"].ToString();
                }
                if (row["C_add"] != null)
                {
                    model.C_add = row["C_add"].ToString();
                }
                if (row["C_hobby"] != null)
                {
                    model.C_hobby = row["C_hobby"].ToString();
                }
                if (row["C_remarks"] != null)
                {
                    model.C_remarks = row["C_remarks"].ToString();
                }
                if (row["C_customerid"] != null && row["C_customerid"].ToString() != "")
                {
                    model.C_customerid = int.Parse(row["C_customerid"].ToString());
                }
                if (row["C_customername"] != null)
                {
                    model.C_customername = row["C_customername"].ToString();
                }
                if (row["C_createId"] != null && row["C_createId"].ToString() != "")
                {
                    model.C_createId = int.Parse(row["C_createId"].ToString());
                }
                if (row["C_createDate"] != null && row["C_createDate"].ToString() != "")
                {
                    model.C_createDate = DateTime.Parse(row["C_createDate"].ToString());
                }
                if (row["isDelete"] != null && row["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(row["isDelete"].ToString());
                }
                if (row["Delete_time"] != null && row["Delete_time"].ToString() != "")
                {
                    model.Delete_time = DateTime.Parse(row["Delete_time"].ToString());
                }
                if (row["IsDefaultContact"] != null && row["IsDefaultContact"].ToString() != "")
                {
                    model.IsDefaultContact = int.Parse(row["IsDefaultContact"].ToString());
                }
                if (row["ec_is_bill_list"] != null && row["ec_is_bill_list"].ToString() != "")
                {
                    model.ec_is_bill_list = int.Parse(row["ec_is_bill_list"].ToString());
                }
                if (row["ec_is_bill_list_show_price"] != null && row["ec_is_bill_list_show_price"].ToString() != "")
                {
                    model.ec_is_bill_list_show_price = int.Parse(row["ec_is_bill_list_show_price"].ToString());
                }
                if (row["ec_is_send_sms_when_delivery"] != null && row["ec_is_send_sms_when_delivery"].ToString() != "")
                {
                    model.ec_is_send_sms_when_delivery = int.Parse(row["ec_is_send_sms_when_delivery"].ToString());
                }
                if (row["ec_is_daifa"] != null && row["ec_is_daifa"].ToString() != "")
                {
                    model.ec_is_daifa = int.Parse(row["ec_is_daifa"].ToString());
                }
                if (row["ec_daifa_user_name"] != null)
                {
                    model.ec_daifa_user_name = row["ec_daifa_user_name"].ToString();
                }
                if (row["ec_daifa_phone"] != null)
                {
                    model.ec_daifa_phone = row["ec_daifa_phone"].ToString();
                }
                if (row["ec_daifa_company"] != null)
                {
                    model.ec_daifa_company = row["ec_daifa_company"].ToString();
                }
                if (row["ec_daifa_address"] != null)
                {
                    model.ec_daifa_address = row["ec_daifa_address"].ToString();
                }
                if (row["invoice_type"] != null)
                {
                    model.invoice_type = row["invoice_type"].ToString();
                }
                if (row["invoice_content"] != null)
                {
                    model.invoice_content = row["invoice_content"].ToString();
                }
                if (row["is_invoice_change"] != null && row["is_invoice_change"].ToString() != "")
                {
                    model.is_invoice_change = int.Parse(row["is_invoice_change"].ToString());
                }
                if (row["tax_company_name"] != null)
                {
                    model.tax_company_name = row["tax_company_name"].ToString();
                }
                if (row["tax_company_add_tel"] != null)
                {
                    model.tax_company_add_tel = row["tax_company_add_tel"].ToString();
                }
                if (row["tax_tax_code"] != null)
                {
                    model.tax_tax_code = row["tax_tax_code"].ToString();
                }
                if (row["tax_bank_name"] != null)
                {
                    model.tax_bank_name = row["tax_bank_name"].ToString();
                }
                if (row["tax_bank_num"] != null)
                {
                    model.tax_bank_num = row["tax_bank_num"].ToString();
                }
                if (row["bill_bank_code1"] != null)
                {
                    model.bill_bank_code1 = row["bill_bank_code1"].ToString();
                }
                if (row["bill_bank_code2"] != null)
                {
                    model.bill_bank_code2 = row["bill_bank_code2"].ToString();
                }
                if (row["bill_bank_code3"] != null)
                {
                    model.bill_bank_code3 = row["bill_bank_code3"].ToString();
                }
                if (row["bill_bank_code4"] != null)
                {
                    model.bill_bank_code4 = row["bill_bank_code4"].ToString();
                }
                if (row["bill_bank_code5"] != null)
                {
                    model.bill_bank_code5 = row["bill_bank_code5"].ToString();
                }
                if (row["bill_bank_code6"] != null)
                {
                    model.bill_bank_code6 = row["bill_bank_code6"].ToString();
                }
                if (row["bill_alipay_code"] != null)
                {
                    model.bill_alipay_code = row["bill_alipay_code"].ToString();
                }
                if (row["bill_wei_code"] != null)
                {
                    model.bill_wei_code = row["bill_wei_code"].ToString();
                }
                if (row["credit_day"] != null && row["credit_day"].ToString() != "")
                {
                    model.credit_day = int.Parse(row["credit_day"].ToString());
                }
                if (row["credit_date"] != null && row["credit_date"].ToString() != "")
                {
                    model.credit_date = int.Parse(row["credit_date"].ToString());
                }
                if (row["credit_total"] != null && row["credit_total"].ToString() != "")
                {
                    model.credit_total = decimal.Parse(row["credit_total"].ToString());
                }
                if (row["erp_user_code"] != null)
                {
                    model.erp_user_code = row["erp_user_code"].ToString();
                }
                if (row["is_erp_archives"] != null && row["is_erp_archives"].ToString() != "")
                {
                    model.is_erp_archives = int.Parse(row["is_erp_archives"].ToString());
                }
                if (row["aite_user_name"] != null)
                {
                    model.aite_user_name = row["aite_user_name"].ToString();
                }
                if (row["is_send_account"] != null && row["is_send_account"].ToString() != "")
                {
                    model.is_send_account = int.Parse(row["is_send_account"].ToString());
                }
                if (row["last_send_account"] != null && row["last_send_account"].ToString() != "")
                {
                    model.last_send_account = int.Parse(row["last_send_account"].ToString());
                }
                if (row["send_account_time"] != null && row["send_account_time"].ToString() != "")
                {
                    model.send_account_time = int.Parse(row["send_account_time"].ToString());
                }
                if (row["user_from"] != null)
                {
                    model.user_from = row["user_from"].ToString();
                }
                if (row["user_group"] != null && row["user_group"].ToString() != "")
                {
                    model.user_group = int.Parse(row["user_group"].ToString());
                }
                if (row["user_grade"] != null && row["user_grade"].ToString() != "")
                {
                    model.user_grade = int.Parse(row["user_grade"].ToString());
                }
                if (row["legal_representative"] != null)
                {
                    model.legal_representative = row["legal_representative"].ToString();
                }
                if (row["is_account_lock"] != null && row["is_account_lock"].ToString() != "")
                {
                    model.is_account_lock = int.Parse(row["is_account_lock"].ToString());
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
            strSql.Append("select u.id as customerid, u.Serialnumber,u.Customer,u.BeSeats,u.BeSeats_id,u.BeSeats_uid,e.emp_code,d.dept_code_kingdee,c.* ");
            strSql.Append(" FROM crm_contact c inner join crm_customer u on c.C_customerid =u.id ");
            strSql.Append(" left join hr_employee as e on u.BeSeats_uid=e.uid ");
            strSql.Append(" left join hr_department as d on d.id=e.d_id ");
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
            strSql.Append("select count(1) FROM crm_contact ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from crm_contact T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
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
            parameters[0].Value = "crm_contact";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

