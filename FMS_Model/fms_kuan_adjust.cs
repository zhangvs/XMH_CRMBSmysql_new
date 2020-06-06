using System;

namespace FMS_Model
{
    /// <summary>
    /// fms_kuan_adjust:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class fms_kuan_adjust
    {
        public fms_kuan_adjust()
        { }
        #region Model
        private int _id;
        private int _date_time;
        private int? _customer_id;
        private int _user_id;
        private decimal _change_total;
        private int _change_type;
        private string _change_desc;
        private string _admin_id;
        private string _erp_dakuanhao;
        private int? _erp_time;
        private string _debit_account_code;
        private string _credit_account_code;
        private int? _status = 0;
        private int? _approvalprimary_empid;
        private string _approvalprimary_empcode;
        private string _approvalprimary_empname;
        private string _approvalprimary_opinion;
        private DateTime? _approvalprimary_date;
        private int? _approvalone_empid;
        private string _approvalone_empcode;
        private string _approvalone_empname;
        private string _approvalone_opinion;
        private DateTime? _approvalone_date;
        private int? _approvaltwo_empid;
        private string _approvaltwo_empcode;
        private DateTime? _approvaltwo_date;
        private int? _approvaltwo_status = 0;

        public int operate_empId { get; set; }
        public DateTime operate_date { get; set; }

        /// <summary>
        /// //调账单号
        /// </summary>
        public string adjust_sn { get; set; }  

        /// <summary>
        /// 增自ID
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 申请时间
        /// </summary>
        public int date_time
        {
            set { _date_time = value; }
            get { return _date_time; }
        }
        /// <summary>
        /// 客户所在公司自增编号Id
        /// </summary>
        public int? customer_id
        {
            set { _customer_id = value; }
            get { return _customer_id; }
        }
        /// <summary>
        /// 联系人id
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal change_total
        {
            set { _change_total = value; }
            get { return _change_total; }
        }
        /// <summary>
        /// 0：正数；1：负数
        /// </summary>
        public int change_type
        {
            set { _change_type = value; }
            get { return _change_type; }
        }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string change_desc
        {
            set { _change_desc = value; }
            get { return _change_desc; }
        }
        /// <summary>
        /// 申请人
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
        public int? erp_time
        {
            set { _erp_time = value; }
            get { return _erp_time; }
        }
        /// <summary>
        /// 金蝶中借方科目代码
        /// </summary>
        public string debit_account_code
        {
            set { _debit_account_code = value; }
            get { return _debit_account_code; }
        }
        /// <summary>
        /// 金蝶中贷方科目代码
        /// </summary>
        public string credit_account_code
        {
            set { _credit_account_code = value; }
            get { return _credit_account_code; }
        }
        /// <summary>
        /// 0：未审核;1:已发送erp; 2:发送erp失败;3:一级审批通过;4：一级审批未通过;5:二级审批通过;6：二级审批未通过;7:初级审批通过;8：初级审批未通过;
        /// </summary>
        public int? status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 初级审批人Id
        /// </summary>
        public int? approvalPrimary_empId
        {
            set { _approvalprimary_empid = value; }
            get { return _approvalprimary_empid; }
        }
        /// <summary>
        /// 初级审批人工号
        /// </summary>
        public string approvalPrimary_empcode
        {
            set { _approvalprimary_empcode = value; }
            get { return _approvalprimary_empcode; }
        }
        /// <summary>
        /// 初级审批人姓名
        /// </summary>
        public string approvalPrimary_empname
        {
            set { _approvalprimary_empname = value; }
            get { return _approvalprimary_empname; }
        }
        /// <summary>
        /// 初级审批人意见
        /// </summary>
        public string approvalPrimary_Opinion
        {
            set { _approvalprimary_opinion = value; }
            get { return _approvalprimary_opinion; }
        }
        /// <summary>
        /// 初级审批时间
        /// </summary>
        public DateTime? approvalPrimary_date
        {
            set { _approvalprimary_date = value; }
            get { return _approvalprimary_date; }
        }
        /// <summary>
        /// 一级审批人Id
        /// </summary>
        public int? approvalOne_empId
        {
            set { _approvalone_empid = value; }
            get { return _approvalone_empid; }
        }
        /// <summary>
        /// 一级审批人工号
        /// </summary>
        public string approvalOne_empcode
        {
            set { _approvalone_empcode = value; }
            get { return _approvalone_empcode; }
        }
        /// <summary>
        /// 一级审批人姓名
        /// </summary>
        public string approvalOne_empname
        {
            set { _approvalone_empname = value; }
            get { return _approvalone_empname; }
        }
        /// <summary>
        /// 一级审批人意见
        /// </summary>
        public string approvalOne_Opinion
        {
            set { _approvalone_opinion = value; }
            get { return _approvalone_opinion; }
        }
        /// <summary>
        /// 一级审批时间
        /// </summary>
        public DateTime? approvalOne_date
        {
            set { _approvalone_date = value; }
            get { return _approvalone_date; }
        }
        /// <summary>
        /// 二级审批人Id
        /// </summary>
        public int? approvalTwo_empId
        {
            set { _approvaltwo_empid = value; }
            get { return _approvaltwo_empid; }
        }
        /// <summary>
        /// 二级审批人工号
        /// </summary>
        public string approvalTwo_empcode
        {
            set { _approvaltwo_empcode = value; }
            get { return _approvaltwo_empcode; }
        }
        /// <summary>
        /// 二级审批时间
        /// </summary>
        public DateTime? approvalTwo_date
        {
            set { _approvaltwo_date = value; }
            get { return _approvaltwo_date; }
        }
        /// <summary>
        /// 二级审核状态：0：未审核；1：审核
        /// </summary>
        public int? approvalTwo_status
        {
            set { _approvaltwo_status = value; }
            get { return _approvaltwo_status; }
        }
        #endregion Model

    }
}

