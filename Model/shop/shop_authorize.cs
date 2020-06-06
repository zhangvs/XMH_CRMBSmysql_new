using System;
namespace XHD.Model
{
    /// <summary>
    /// shop_authorize:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_authorize
    {
        public shop_authorize()
        { }
        #region Model
        private int _id;
        private int? _user_id;
        private int? _apply_admin_id;
        private int? _cat;
        private int? _show_seal = 1;
        private string _company_name;
        private int? _brand_id;
        private string _brand;
        private int? _country;
        private int? _province;
        private int? _city;
        private string _district;
        private string _comment;
        private string _add_time;
        private int? _auditor;
        private int? _audit_status = 0;
        private string _audit_time;
        private string _audit_notes;
        private int? _is_available = 1;

        public string rname2 { get; set; }
        public string rname1 { get; set; }
        public string code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 申请用户
        /// </summary>
        public int? user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 后台客服发起人id
        /// </summary>
        public int? apply_admin_id
        {
            set { _apply_admin_id = value; }
            get { return _apply_admin_id; }
        }
        /// <summary>
        /// 申请类别
        /// </summary>
        public int? cat
        {
            set { _cat = value; }
            get { return _cat; }
        }
        /// <summary>
        /// 是否显示印章 1有印章，2无印章，3全部
        /// </summary>
        public int? show_seal
        {
            set { _show_seal = value; }
            get { return _show_seal; }
        }
        /// <summary>
        /// 申请公司名称
        /// </summary>
        public string company_name
        {
            set { _company_name = value; }
            get { return _company_name; }
        }
        /// <summary>
        /// 申请品牌
        /// </summary>
        public int? brand_id
        {
            set { _brand_id = value; }
            get { return _brand_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string brand
        {
            set { _brand = value; }
            get { return _brand; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? country
        {
            set { _country = value; }
            get { return _country; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? city
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string district
        {
            set { _district = value; }
            get { return _district; }
        }
        /// <summary>
        /// 申请备注
        /// </summary>
        public string comment
        {
            set { _comment = value; }
            get { return _comment; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 审核人
        /// </summary>
        public int? auditor
        {
            set { _auditor = value; }
            get { return _auditor; }
        }
        /// <summary>
        /// 0 待审核 1 通过 2 拒绝
        /// </summary>
        public int? audit_status
        {
            set { _audit_status = value; }
            get { return _audit_status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string audit_time
        {
            set { _audit_time = value; }
            get { return _audit_time; }
        }
        /// <summary>
        /// 审核备注
        /// </summary>
        public string audit_notes
        {
            set { _audit_notes = value; }
            get { return _audit_notes; }
        }
        /// <summary>
        /// 1 允许 0 禁用
        /// </summary>
        public int? is_available
        {
            set { _is_available = value; }
            get { return _is_available; }
        }
        #endregion Model

    }
}

