/**  版本信息模板在安装目录下，可自行修改。
* crm_contact_bill.cs
*
* 功 能： N/A
* 类 名： crm_contact_bill
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/1/10 15:18:51   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace XHD.Model
{
    /// <summary>
    /// crm_contact_bill:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_contact_bill
    {
        public crm_contact_bill()
        { }
        #region Model
        private int _id;
        private int? _customer_id;
        private int? _user_id;
        private int? _invoice_type = 1;
        private string _tax_company_name;
        private string _tax_company_add_tel;
        private string _tax_tax_code;
        private string _tax_bank_name;
        private string _tax_bank_num;
        public int is_tax_for_billing { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? customer_id
        {
            set { _customer_id = value; }
            get { return _customer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        ///  0: 不开发票 , 1: 增值税专用发票 ,2 : 普通发票, 3 按实际内容开票, 4 : 收据
        /// </summary>
        public int? invoice_type
        {
            set { _invoice_type = value; }
            get { return _invoice_type; }
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
        #endregion Model

    }
}

