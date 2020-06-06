using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model
{
    /// <summary>
    /// shop_invoices_goods:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_invoices_among_goods
    {
        public shop_invoices_among_goods()
        { }
        #region Model
        private int _id;
        private int _target_id;
        private int? _instorage_goods_cat_id;
        private int _type;
        private int? _goods_id;
        private string _goods_sn;
        private decimal _goods_old_price;
        private int _goods_old_num;
        private string _goods_name;
        private string _goods_packing;
        private string _goods_unit;
        private int _goods_num;
        private decimal? _goods_sold_price;
        private int? _goods_sold_num;
        private decimal _goods_price;
        private decimal _total_money;
        private int? _tax_rate;
        private string _update_time;
        private string _add_time;
        private int? _rec_id;
        private int? _order_id;
        private decimal? _t_is_shipping_fee = 0.00M;
        private int _is_replace = 0;
        private int _is_hidden = 0;
        /// <summary>
        /// 主键id
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 发票id或商品入库记录id
        /// </summary>
        public int target_id
        {
            set { _target_id = value; }
            get { return _target_id; }
        }
        /// <summary>
        /// 入库商品分类id
        /// </summary>
        public int? instorage_goods_cat_id
        {
            set { _instorage_goods_cat_id = value; }
            get { return _instorage_goods_cat_id; }
        }
        /// <summary>
        /// 类型：1开票商品，2入库商品
        /// </summary>
        public int type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 商品id
        /// </summary>
        public int? goods_id
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 商品订货号
        /// </summary>
        public string goods_sn
        {
            set { _goods_sn = value; }
            get { return _goods_sn; }
        }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string goods_name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string goods_packing
        {
            set { _goods_packing = value; }
            get { return _goods_packing; }
        }
        /// <summary>
        /// 商品基本单位
        /// </summary>
        public string goods_unit
        {
            set { _goods_unit = value; }
            get { return _goods_unit; }
        }
        /// <summary>
        /// 开票原始数量
        /// </summary>
        public int goods_old_num
        {
            set { _goods_old_num = value; }
            get { return _goods_old_num; }
        }
        /// <summary>
        /// 开票原始单价
        /// </summary>
        public decimal goods_old_price
        {
            set { _goods_old_price = value; }
            get { return _goods_old_price; }
        }
        /// <summary>
        /// 开票数量
        /// </summary>
        public int goods_num
        {
            set { _goods_num = value; }
            get { return _goods_num; }
        }
        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal? goods_sold_price
        {
            set { _goods_sold_price = value; }
            get { return _goods_sold_price; }
        }
        /// <summary>
        /// 销售数量
        /// </summary>
        public int? goods_sold_num
        {
            set { _goods_sold_num = value; }
            get { return _goods_sold_num; }
        }
        /// <summary>
        /// 开票单价
        /// </summary>
        public decimal goods_price
        {
            set { _goods_price = value; }
            get { return _goods_price; }
        }
        /// <summary>
        /// 价税合计
        /// </summary>
        public decimal total_money
        {
            set { _total_money = value; }
            get { return _total_money; }
        }
        /// <summary>
        /// 税率
        /// </summary>
        public int? tax_rate
        {
            set { _tax_rate = value; }
            get { return _tax_rate; }
        }
        /// <summary>
        /// 修改时间
        /// </summary>
        public string update_time
        {
            set { _update_time = value; }
            get { return _update_time; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public string add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? rec_id
        {
            set { _rec_id = value; }
            get { return _rec_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? order_id
        {
            set { _order_id = value; }
            get { return _order_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? t_is_shipping_fee
        {
            set { _t_is_shipping_fee = value; }
            get { return _t_is_shipping_fee; }
        }
        /// <summary>
        /// 1 替换
        /// </summary>
        public int is_replace
        {
            set { _is_replace = value; }
            get { return _is_replace; }
        }
        /// <summary>
        /// 1 合并 2合并目标
        /// </summary>
        public int is_hidden
        {
            set { _is_hidden = value; }
            get { return _is_hidden; }
        }
        #endregion Model

    }

    public class shop_invoices_among_goods2 : shop_invoices_among_goods
    {
        public int parent_id { set; get; }
        public int brand_id { set; get; }
        public int is_invoice_merge { set; get; }
        public string goods_invoice_name { set; get; }
    }
}

