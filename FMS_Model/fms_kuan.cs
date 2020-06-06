﻿using System;

namespace FMS_Model
{
    /// <summary>
    /// fms_kuan:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class fms_kuan
    {
        public fms_kuan()
        { }

        #region Model
        private int _id;
        private string _jzdate;
        private string _jytime;
        private string _jiefang;
        private decimal _daifang;
        private string _name;
        private string _number;
        private string _user_qq;
        private string _admin_name;
        private string _admin_id;
        private string _erp_dakuanhao;
        private int? _status = 0;
        private int? _file_time;
        private int? _confirm_time;
        private int? _dkmassage_id;
        private int? _user_id;
        private int? _acc_type = 0;

        public string kingdee_out_code { get; set; }

        /// <summary>
        /// 自增ID
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string jzdate
        {
            set { _jzdate = value; }
            get { return _jzdate; }
        }
        /// <summary>
        /// 交易时间
        /// </summary>
        public string jytime
        {
            set { _jytime = value; }
            get { return _jytime; }
        }
        /// <summary>
        /// 对方电话
        /// </summary>
        public string jiefang
        {
            set { _jiefang = value; }
            get { return _jiefang; }
        }
        /// <summary>
        /// 打款金额
        /// </summary>
        public decimal daifang
        {
            set { _daifang = value; }
            get { return _daifang; }
        }
        /// <summary>
        /// 对方户名
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 对方账户
        /// </summary>
        public string number
        {
            set { _number = value; }
            get { return _number; }
        }
        /// <summary>
        /// 对应客服
        /// </summary>
        public string user_qq
        {
            set { _user_qq = value; }
            get { return _user_qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string admin_name
        {
            set { _admin_name = value; }
            get { return _admin_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string admin_id
        {
            set { _admin_id = value; }
            get { return _admin_id; }
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
        public int? status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 上传时间
        /// </summary>
        public int? file_time
        {
            set { _file_time = value; }
            get { return _file_time; }
        }
        /// <summary>
        /// 认时间
        /// </summary>
        public int? confirm_time
        {
            set { _confirm_time = value; }
            get { return _confirm_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? dkmassage_id
        {
            set { _dkmassage_id = value; }
            get { return _dkmassage_id; }
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
        /// 开户类型；0-个人z帐户 默认，1-公司账户
        /// </summary>
        public int? acc_type
        {
            set { _acc_type = value; }
            get { return _acc_type; }
        }
        #endregion Model

    }
}
