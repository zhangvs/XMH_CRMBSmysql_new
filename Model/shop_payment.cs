using System;
namespace XHD.Model
{
    /// <summary>
    /// shop_payment:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_payment
    {
        public shop_payment()
        { }
        #region Model
        private int _pay_id;
        private string _pay_name;
        private string _pay_code;
        private string _pay_notes;
        private decimal _pay_fee = 0.00M;
        private int _pay_sort = 1;
        private int? _is_enabled = 1;
        private int? _is_cod = 0;
        private int? _is_online = 0;
        private int? _is_user_show = 0;
        /// <summary>
        /// 支付编码
        /// </summary>
        public int pay_id
        {
            set { _pay_id = value; }
            get { return _pay_id; }
        }
        /// <summary>
        /// 支付名称
        /// </summary>
        public string pay_name
        {
            set { _pay_name = value; }
            get { return _pay_name; }
        }
        /// <summary>
        /// 支付代码
        /// </summary>
        public string pay_code
        {
            set { _pay_code = value; }
            get { return _pay_code; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string pay_notes
        {
            set { _pay_notes = value; }
            get { return _pay_notes; }
        }
        /// <summary>
        /// 支付费用
        /// </summary>
        public decimal pay_fee
        {
            set { _pay_fee = value; }
            get { return _pay_fee; }
        }
        /// <summary>
        /// 支付排序
        /// </summary>
        public int pay_sort
        {
            set { _pay_sort = value; }
            get { return _pay_sort; }
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int? is_enabled
        {
            set { _is_enabled = value; }
            get { return _is_enabled; }
        }
        /// <summary>
        /// 是否发货后付款

        /// </summary>
        public int? is_cod
        {
            set { _is_cod = value; }
            get { return _is_cod; }
        }
        /// <summary>
        /// 是否在线支付
        /// </summary>
        public int? is_online
        {
            set { _is_online = value; }
            get { return _is_online; }
        }
        /// <summary>
        /// 客户是否可选
        /// </summary>
        public int? is_user_show
        {
            set { _is_user_show = value; }
            get { return _is_user_show; }
        }
        #endregion Model

    }
}

