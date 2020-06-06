using System;
namespace XHD.Model
{
    /// <summary>
    /// scm_spe_order:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class scm_spe_order
    {
        public scm_spe_order()
        { }
        #region Model
        private int _id;
        private int? _order_id_old;
        private string _order_sn_old;
        private int? _oerder_old_date;
        private int? _create_date;
        private int? _create_userid;
        private string _create_username;
        private decimal? _order_money_old;
        private string _order_suppliersid;
        private int? _province_id;
        private int? _city_id;
        private int? _district_id;
        public int? issplit { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 商城原订单编号Id
        /// </summary>
        public int? order_id_old
        {
            set { _order_id_old = value; }
            get { return _order_id_old; }
        }
        /// <summary>
        /// 商城原订单编号sn
        /// </summary>
        public string order_sn_old
        {
            set { _order_sn_old = value; }
            get { return _order_sn_old; }
        }
        /// <summary>
        /// 商城原订单时间
        /// </summary>
        public int? oerder_old_date
        {
            set { _oerder_old_date = value; }
            get { return _oerder_old_date; }
        }
        /// <summary>
        /// 当前同步时间
        /// </summary>
        public int? create_date
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        /// <summary>
        /// 当前同步数据员工编号ID
        /// </summary>
        public int? create_userid
        {
            set { _create_userid = value; }
            get { return _create_userid; }
        }
        /// <summary>
        /// 当前同步数据员工姓名
        /// </summary>
        public string create_username
        {
            set { _create_username = value; }
            get { return _create_username; }
        }
        /// <summary>
        /// 该订单总金额
        /// </summary>
        public decimal? order_money_old
        {
            set { _order_money_old = value; }
            get { return _order_money_old; }
        }
        /// <summary>
        /// 订单所属品牌(所属供应商)
        /// </summary>
        public string order_suppliersid
        {
            set { _order_suppliersid = value; }
            get { return _order_suppliersid; }
        }
        /// <summary>
        /// 省份id
        /// </summary>
        public int? province_id
        {
            set { _province_id = value; }
            get { return _province_id; }
        }
        /// <summary>
        /// 市id
        /// </summary>
        public int? city_id
        {
            set { _city_id = value; }
            get { return _city_id; }
        }
        /// <summary>
        /// 县区id
        /// </summary>
        public int? district_id
        {
            set { _district_id = value; }
            get { return _district_id; }
        }
        #endregion Model

    }

    public partial class scm_spe_order1 : scm_spe_order
    {
        public int cur_num { set; get; }
    }
}

