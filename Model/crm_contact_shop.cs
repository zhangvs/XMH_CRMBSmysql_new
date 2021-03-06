﻿using System;
namespace XHD.Model
{
    /// <summary>
    /// crm_contact_shop:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_contact_shop
    {
        public crm_contact_shop()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _user_name;
        private string _password;
        private string _auth_key;
        private DateTime? _last_login;
        private string _last_ip;
        private string _user_avatar;
        private int? _bind_email;
        private string _safe_question;
        private string _safe_answer;
        private string _c_name;
        private string _c_sex;
        private string _c_department;
        private string _c_position;
        private string _c_birthday;
        private string _c_tel;
        private string _c_extentel;
        private string _c_fax;
        private string _c_email;
        private string _c_mobone;
        private string _c_mobtwo;
        private string _c_qq;
        private string _c_add;
        private string _c_hobby;
        private string _c_remarks;
        private int? _c_customerid;
        private string _c_customername;
        private int? _c_createid;
        private DateTime? _c_createdate;
        private int? _isdelete;
        private DateTime? _delete_time;
        private int? _isdefaultcontact;
        private int? _ec_is_bill_list = 1;
        private int? _ec_is_bill_list_show_price = 1;
        private int? _ec_is_send_sms_when_delivery = 1;
        private int? _ec_is_daifa = 0;
        private string _ec_daifa_user_name;
        private string _ec_daifa_phone;
        private string _ec_daifa_company;
        private string _ec_daifa_address;
        private string _invoice_type;
        private string _invoice_content;
        private int? _is_invoice_change = 0;
        private string _tax_company_name;
        private string _tax_company_add_tel;
        private string _tax_tax_code;
        private string _tax_bank_name;
        private string _tax_bank_num;
        private string _bill_bank_code1;
        private string _bill_bank_code2;
        private string _bill_bank_code3;
        private string _bill_bank_code4;
        private string _bill_bank_code5;
        private string _bill_bank_code6;
        private string _bill_alipay_code;
        private string _bill_wei_code;
        private int _credit_day;
        private int? _credit_date;
        private decimal? _credit_total = 0.00M;
        private string _erp_user_code;
        private int? _is_erp_archives = 1;
        private string _aite_user_name;
        private int? _is_send_account = 0;
        private int? _last_send_account;
        private int? _send_account_time;
        private string _user_from;
        private int? _user_group = 0;
        private int? _user_grade = 0;
        private int? _is_account_lock = 0;

        public string legal_representative { set; get; }
        public string account_lock_note { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 所属经营者
        /// </summary>
        public string Factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 密码加密随机字符串
        /// </summary>
        public string auth_key
        {
            set { _auth_key = value; }
            get { return _auth_key; }
        }
        /// <summary>
        /// 最后一次登陆时间戳
        /// </summary>
        public DateTime? last_login
        {
            set { _last_login = value; }
            get { return _last_login; }
        }
        /// <summary>
        /// 最后一次登陆ip
        /// </summary>
        public string last_ip
        {
            set { _last_ip = value; }
            get { return _last_ip; }
        }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string user_avatar
        {
            set { _user_avatar = value; }
            get { return _user_avatar; }
        }
        /// <summary>
        /// 绑定邮箱
        /// </summary>
        public int? bind_email
        {
            set { _bind_email = value; }
            get { return _bind_email; }
        }
        /// <summary>
        /// 密保问题
        /// </summary>
        public string safe_question
        {
            set { _safe_question = value; }
            get { return _safe_question; }
        }
        /// <summary>
        /// 密保答案
        /// </summary>
        public string safe_answer
        {
            set { _safe_answer = value; }
            get { return _safe_answer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_name
        {
            set { _c_name = value; }
            get { return _c_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_sex
        {
            set { _c_sex = value; }
            get { return _c_sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_department
        {
            set { _c_department = value; }
            get { return _c_department; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_position
        {
            set { _c_position = value; }
            get { return _c_position; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_birthday
        {
            set { _c_birthday = value; }
            get { return _c_birthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_tel
        {
            set { _c_tel = value; }
            get { return _c_tel; }
        }
        /// <summary>
        /// 分机号
        /// </summary>
        public string C_extentel
        {
            set { _c_extentel = value; }
            get { return _c_extentel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_fax
        {
            set { _c_fax = value; }
            get { return _c_fax; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_email
        {
            set { _c_email = value; }
            get { return _c_email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_mobone
        {
            set { _c_mobone = value; }
            get { return _c_mobone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_mobtwo
        {
            set { _c_mobtwo = value; }
            get { return _c_mobtwo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_QQ
        {
            set { _c_qq = value; }
            get { return _c_qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_add
        {
            set { _c_add = value; }
            get { return _c_add; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_hobby
        {
            set { _c_hobby = value; }
            get { return _c_hobby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_remarks
        {
            set { _c_remarks = value; }
            get { return _c_remarks; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? C_customerid
        {
            set { _c_customerid = value; }
            get { return _c_customerid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string C_customername
        {
            set { _c_customername = value; }
            get { return _c_customername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? C_createId
        {
            set { _c_createid = value; }
            get { return _c_createid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? C_createDate
        {
            set { _c_createdate = value; }
            get { return _c_createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isDelete
        {
            set { _isdelete = value; }
            get { return _isdelete; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Delete_time
        {
            set { _delete_time = value; }
            get { return _delete_time; }
        }
        /// <summary>
        /// 是否是默认联系人，0:不是默认，1：默认
        /// </summary>
        public int? IsDefaultContact
        {
            set { _isdefaultcontact = value; }
            get { return _isdefaultcontact; }
        }
        /// <summary>
        /// 发货是否放清单1放 0 不放
        /// </summary>
        public int? ec_is_bill_list
        {
            set { _ec_is_bill_list = value; }
            get { return _ec_is_bill_list; }
        }
        /// <summary>
        /// 发货清单是否显示价格
        /// </summary>
        public int? ec_is_bill_list_show_price
        {
            set { _ec_is_bill_list_show_price = value; }
            get { return _ec_is_bill_list_show_price; }
        }
        /// <summary>
        /// 发货时是否发送短信通知
        /// </summary>
        public int? ec_is_send_sms_when_delivery
        {
            set { _ec_is_send_sms_when_delivery = value; }
            get { return _ec_is_send_sms_when_delivery; }
        }
        /// <summary>
        /// 是否代发货客户:0不代发1代发
        /// </summary>
        public int? ec_is_daifa
        {
            set { _ec_is_daifa = value; }
            get { return _ec_is_daifa; }
        }
        /// <summary>
        /// 待发货人,代发客户必填
        /// </summary>
        public string ec_daifa_user_name
        {
            set { _ec_daifa_user_name = value; }
            get { return _ec_daifa_user_name; }
        }
        /// <summary>
        /// 待发货人电话,代发客户必填
        /// </summary>
        public string ec_daifa_phone
        {
            set { _ec_daifa_phone = value; }
            get { return _ec_daifa_phone; }
        }
        /// <summary>
        /// 代发货公司
        /// </summary>
        public string ec_daifa_company
        {
            set { _ec_daifa_company = value; }
            get { return _ec_daifa_company; }
        }
        /// <summary>
        /// 代发货地址
        /// </summary>
        public string ec_daifa_address
        {
            set { _ec_daifa_address = value; }
            get { return _ec_daifa_address; }
        }
        /// <summary>
        /// 客户开发票类型,默认增值税发票
        /// </summary>
        public string invoice_type
        {
            set { _invoice_type = value; }
            get { return _invoice_type; }
        }
        /// <summary>
        /// 发票内容
        /// </summary>
        public string invoice_content
        {
            set { _invoice_content = value; }
            get { return _invoice_content; }
        }
        /// <summary>
        /// 发票内容是否需要修改
        /// </summary>
        public int? is_invoice_change
        {
            set { _is_invoice_change = value; }
            get { return _is_invoice_change; }
        }
        /// <summary>
        /// 合同/发票使用的公司名称
        /// </summary>
        public string tax_company_name
        {
            set { _tax_company_name = value; }
            get { return _tax_company_name; }
        }
        /// <summary>
        /// 单位地址电话
        /// </summary>
        public string tax_company_add_tel
        {
            set { _tax_company_add_tel = value; }
            get { return _tax_company_add_tel; }
        }
        /// <summary>
        /// 税号
        /// </summary>
        public string tax_tax_code
        {
            set { _tax_tax_code = value; }
            get { return _tax_tax_code; }
        }
        /// <summary>
        /// 开户银行
        /// </summary>
        public string tax_bank_name
        {
            set { _tax_bank_name = value; }
            get { return _tax_bank_name; }
        }
        /// <summary>
        /// 开发票银行帐号
        /// </summary>
        public string tax_bank_num
        {
            set { _tax_bank_num = value; }
            get { return _tax_bank_num; }
        }
        /// <summary>
        /// 实际打款账号1
        /// </summary>
        public string bill_bank_code1
        {
            set { _bill_bank_code1 = value; }
            get { return _bill_bank_code1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bill_bank_code2
        {
            set { _bill_bank_code2 = value; }
            get { return _bill_bank_code2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bill_bank_code3
        {
            set { _bill_bank_code3 = value; }
            get { return _bill_bank_code3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bill_bank_code4
        {
            set { _bill_bank_code4 = value; }
            get { return _bill_bank_code4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bill_bank_code5
        {
            set { _bill_bank_code5 = value; }
            get { return _bill_bank_code5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bill_bank_code6
        {
            set { _bill_bank_code6 = value; }
            get { return _bill_bank_code6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bill_alipay_code
        {
            set { _bill_alipay_code = value; }
            get { return _bill_alipay_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bill_wei_code
        {
            set { _bill_wei_code = value; }
            get { return _bill_wei_code; }
        }
        /// <summary>
        /// 客户账期,客户最长欠款日期
        /// </summary>
        public int credit_day
        {
            set { _credit_day = value; }
            get { return _credit_day; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? credit_date
        {
            set { _credit_date = value; }
            get { return _credit_date; }
        }
        /// <summary>
        /// 总账额
        /// </summary>
        public decimal? credit_total
        {
            set { _credit_total = value; }
            get { return _credit_total; }
        }
        /// <summary>
        /// 用户在ERP中编号,默认空,
        /// </summary>
        public string erp_user_code
        {
            set { _erp_user_code = value; }
            get { return _erp_user_code; }
        }
        /// <summary>
        /// 是否在ERP中建立了客户档案
        /// </summary>
        public int? is_erp_archives
        {
            set { _is_erp_archives = value; }
            get { return _is_erp_archives; }
        }
        /// <summary>
        /// 客户ERP中总公司手机号
        /// </summary>
        public string aite_user_name
        {
            set { _aite_user_name = value; }
            get { return _aite_user_name; }
        }
        /// <summary>
        /// 是否发送清单
        /// </summary>
        public int? is_send_account
        {
            set { _is_send_account = value; }
            get { return _is_send_account; }
        }
        /// <summary>
        /// 下次记账单发送时间
        /// </summary>
        public int? last_send_account
        {
            set { _last_send_account = value; }
            get { return _last_send_account; }
        }
        /// <summary>
        /// 发送对账单时间
        /// </summary>
        public int? send_account_time
        {
            set { _send_account_time = value; }
            get { return _send_account_time; }
        }
        /// <summary>
        /// 来源(管理员添加admin_add；自助注册index；扫码注册)
        /// </summary>
        public string user_from
        {
            set { _user_from = value; }
            get { return _user_from; }
        }
        /// <summary>
        /// 客户群体
        /// </summary>
        public int? user_group
        {
            set { _user_group = value; }
            get { return _user_group; }
        }
        /// <summary>
        /// 客户等级
        /// </summary>
        public int? user_grade
        {
            set { _user_grade = value; }
            get { return _user_grade; }
        }

        ///<summary>
        ///账户锁
        ///<summary>
        public int? is_account_lock
        {
            set { _is_account_lock = value; }
            get { return _is_account_lock; }
        }
        #endregion Model

    }
}

