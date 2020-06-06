using System;
namespace XHD.Model
{
    /// <summary>
    /// shop_user_address:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_user_address
    {
        public shop_user_address()
        { }
        
        #region Model
        private int _address_id;
        private string _address_name;
        private int _user_id;
        private string _consignee;
        private string _email;
        private int _country = 0;
        private int _province = 0;
        private int _city = 0;
        private int _district = 0;
        private string _address;
        private string _zipcode;
        private string _tel;
        private string _mobile;
        private string _sign_building;
        private string _best_time;
        private int? _is_default = 0;
        private int? _is_invoice = 0;
        /// <summary>
        /// 
        /// </summary>
        public int address_id
        {
            set { _address_id = value; }
            get { return _address_id; }
        }
        /// <summary>
        /// 地址名称
        /// </summary>
        public string address_name
        {
            set { _address_name = value; }
            get { return _address_name; }
        }
        /// <summary>
        /// 用户id
        /// </summary>
        public int user_id
        {
            set { _user_id = value; }
            get { return _user_id; }
        }
        /// <summary>
        /// 收货人
        /// </summary>
        public string consignee
        {
            set { _consignee = value; }
            get { return _consignee; }
        }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 国家
        /// </summary>
        public int country
        {
            set { _country = value; }
            get { return _country; }
        }
        /// <summary>
        /// 省
        /// </summary>
        public int province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 市
        /// </summary>
        public int city
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 地区
        /// </summary>
        public int district
        {
            set { _district = value; }
            get { return _district; }
        }
        /// <summary>
        /// 地址
        /// </summary>
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 邮编
        /// </summary>
        public string zipcode
        {
            set { _zipcode = value; }
            get { return _zipcode; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 手机
        /// </summary>
        public string mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 标志建筑
        /// </summary>
        public string sign_building
        {
            set { _sign_building = value; }
            get { return _sign_building; }
        }
        /// <summary>
        /// 最佳配送时间
        /// </summary>
        public string best_time
        {
            set { _best_time = value; }
            get { return _best_time; }
        }
        /// <summary>
        /// 默认地址
        /// </summary>
        public int? is_default
        {
            set { _is_default = value; }
            get { return _is_default; }
        }
        /// <summary>
        /// 发票默认地址
        /// </summary>
        public int? is_invoice
        {
            set { _is_invoice = value; }
            get { return _is_invoice; }
        }
        #endregion Model

    }
}

