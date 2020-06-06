using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model
{
    /// <summary>
    /// crm_order_feat:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class crm_order_feat
    {
        public crm_order_feat()
        { }
        #region Model
        private int _id;
        private string _factory_id;
        private string _emp_code;
        private decimal? _order_feat;
        private int? _customer_id;
        private string _customer_name;
        private int? _customer_id_shop;
        private string _customer_name_shop;
        private DateTime? _create_date;
        private int? _create_id;

        public decimal sales_return { get; set; }

        /// <summary>
        /// auto_increment
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string factory_Id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string emp_code
        {
            set { _emp_code = value; }
            get { return _emp_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? order_feat
        {
            set { _order_feat = value; }
            get { return _order_feat; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? customer_Id
        {
            set { _customer_id = value; }
            get { return _customer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string customer_name
        {
            set { _customer_name = value; }
            get { return _customer_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? customer_Id_shop
        {
            set { _customer_id_shop = value; }
            get { return _customer_id_shop; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string customer_name_shop
        {
            set { _customer_name_shop = value; }
            get { return _customer_name_shop; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? create_date
        {
            set { _create_date = value; }
            get { return _create_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? create_id
        {
            set { _create_id = value; }
            get { return _create_id; }
        }
        #endregion Model

    }
}

