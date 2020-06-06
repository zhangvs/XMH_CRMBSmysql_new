﻿using System;

namespace FMS_Model
{
    /// <summary>
    /// fms_dkmassage:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class fms_dkmassage
    {
        public fms_dkmassage()
        { }

        #region Model
        private int _id;
        private DateTime _datetime;
        private decimal _price=0.00M;
        private string _account;
        private int _user_id;
        private string _user_name;
        private string _channel;
        private string _deal;
        private string _stats;
        private string _notes;
        private int? _is_delete = 0;
        private string _erp_dakuanhao;
        private DateTime? _add_time;
        private string _erp_bank_id;
        private int? _confirm_admin_id;
        private DateTime? _confirm_time;
        private DateTime? _erp_time;
        private int? _erp_type;
        private int? _acc_type = 0;

        public int from_type { get; set; }
        public int operate_userId { get; set; }
        public DateTime operate_time { get; set; }
        public string kingdee_current_account { get; set; }   //金蝶中的往来科目
        public string kingdee_out_code { get; set; }
        public int is_send_out { get; set; }
        public int is_inner_Journal { get; set; }
        public int is_out_Journal { get; set; }
        public int send_out_reason { get; set; }
        public int is_bill_handle { get; set; }
       
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
        public DateTime datetime
        {
            set { _datetime = value; }
            get { return _datetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string account
        {
            set { _account = value; }
            get { return _account; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string user_name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string channel
        {
            set { _channel = value; }
            get { return _channel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string deal
        {
            set { _deal = value; }
            get { return _deal; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string stats
        {
            set { _stats = value; }
            get { return _stats; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string notes
        {
            set { _notes = value; }
            get { return _notes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_delete
        {
            set { _is_delete = value; }
            get { return _is_delete; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string erp_dakuanhao
        {
            set { _erp_dakuanhao = value; }
            get { return _erp_dakuanhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string erp_bank_id
        {
            set { _erp_bank_id = value; }
            get { return _erp_bank_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? confirm_admin_id
        {
            set { _confirm_admin_id = value; }
            get { return _confirm_admin_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? confirm_time
        {
            set { _confirm_time = value; }
            get { return _confirm_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? erp_time
        {
            set { _erp_time = value; }
            get { return _erp_time; }
        }
        /// <summary>
        /// 1自动发送erp 2 手动3
        /// </summary>
        public int? erp_type
        {
            set { _erp_type = value; }
            get { return _erp_type; }
        }
        /// <summary>
        /// 开户类型；0-个人帐户 默认，1-公司账户
        /// </summary>
        public int? acc_type
        {
            set { _acc_type = value; }
            get { return _acc_type; }
        }
        #endregion Model

    }
}

