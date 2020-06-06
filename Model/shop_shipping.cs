using System;
namespace XHD.Model
{
    /// <summary>
    /// shop_shipping:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_shipping
    {
        public shop_shipping()
        { }
        #region Model
        private int _shipping_id;
        private string _shipping_code;
        private string _shipping_name;
        private string _shipping_tel;
        private string _shipping_address;
        private string _shipping_desc;
        private int? _is_available;
        private int? _send_pay;
        /// <summary>
        /// 
        /// </summary>
        public int shipping_id
        {
            set { _shipping_id = value; }
            get { return _shipping_id; }
        }
        /// <summary>
        /// 快递代码
        /// </summary>
        public string shipping_code
        {
            set { _shipping_code = value; }
            get { return _shipping_code; }
        }
        /// <summary>
        /// 快递名称
        /// </summary>
        public string shipping_name
        {
            set { _shipping_name = value; }
            get { return _shipping_name; }
        }
        /// <summary>
        /// 快递公司电话
        /// </summary>
        public string shipping_tel
        {
            set { _shipping_tel = value; }
            get { return _shipping_tel; }
        }
        /// <summary>
        /// 快递公司地址
        /// </summary>
        public string shipping_address
        {
            set { _shipping_address = value; }
            get { return _shipping_address; }
        }
        /// <summary>
        /// 快递公司描述
        /// </summary>
        public string shipping_desc
        {
            set { _shipping_desc = value; }
            get { return _shipping_desc; }
        }
        /// <summary>
        /// 是否可用
        /// </summary>
        public int? is_available
        {
            set { _is_available = value; }
            get { return _is_available; }
        }
        /// <summary>
        /// 是否支持到付
        /// </summary>
        public int? send_pay
        {
            set { _send_pay = value; }
            get { return _send_pay; }
        }
        #endregion Model

    }
}

