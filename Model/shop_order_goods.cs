/**  版本信息模板在安装目录下，可自行修改。
* shop_order_goods.cs
*
* 功 能： N/A
* 类 名： shop_order_goods
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/18 15:14:08   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace XHD.Model
{
    /// <summary>
    /// shop_order_goods:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class shop_order_goods
    {
        public shop_order_goods()
        { }
        #region Model
        private int _ordergood_id;
        private int _cart_id;
        private int _order_id;
        private string _order_sn;
        private int _goods_id;
        private string _goods_name;
        private string _goods_sn;
        private int _goods_number = 1;
        private int _invoice_number = 0;
        private decimal _market_price = 0.0000M;
        private decimal _goods_price = 0.0000M;
        private decimal? _shipping_fee_price = 0.0000M;
        private int? _brand_id;
        private int? _cat_id;
        private int _user_id = 0;
        private int _admin_id = 0;
        private int _purchase_goods_status = 0;
        private int _is_submit_purchase = 0;
        private int _stock_warn = 0;
        private int? _is_invoice = 1;
        private int? _is_add_order = 0;
        private decimal? _doc_id;
        private int? _wms_setbook_id;
        private string _wms_position;
        private int? _wms_record;
        public string goods_attr { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public int ordergood_id
        {
            set { _ordergood_id = value; }
            get { return _ordergood_id; }
        }
        /// <summary>
        /// 加入购物车的顺序
        /// </summary>
        public int cart_id
        {
            set { _cart_id = value; }
            get { return _cart_id; }
        }
        /// <summary>
        /// 订单id
        /// </summary>
        public int order_id
        {
            set { _order_id = value; }
            get { return _order_id; }
        }
        /// <summary>
        /// 订单号
        /// </summary>
        public string order_sn
        {
            set { _order_sn = value; }
            get { return _order_sn; }
        }
        /// <summary>
        /// 商品id
        /// </summary>
        public int goods_id
        {
            set { _goods_id = value; }
            get { return _goods_id; }
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
        /// 订货号
        /// </summary>
        public string goods_sn
        {
            set { _goods_sn = value; }
            get { return _goods_sn; }
        }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int goods_number
        {
            set { _goods_number = value; }
            get { return _goods_number; }
        }

        public int invoice_number
        {
            set { _invoice_number = value; }
            get { return _invoice_number; }
        }
        /// <summary>
        /// 市场价
        /// </summary>
        public decimal market_price
        {
            set { _market_price = value; }
            get { return _market_price; }
        }
        /// <summary>
        /// 商品价
        /// </summary>
        public decimal goods_price
        {
            set { _goods_price = value; }
            get { return _goods_price; }
        }
        /// <summary>
        /// 配送费
        /// </summary>
        public decimal? shipping_fee_price
        {
            set { _shipping_fee_price = value; }
            get { return _shipping_fee_price; }
        }
        /// <summary>
        /// 品牌id
        /// </summary>
        public int? brand_id
        {
            set { _brand_id = value; }
            get { return _brand_id; }
        }
        /// <summary>
        /// 分类id
        /// </summary>
        public int? cat_id
        {
            set { _cat_id = value; }
            get { return _cat_id; }
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
        /// 管理员id
        /// </summary>
        public int admin_id
        {
            set { _admin_id = value; }
            get { return _admin_id; }
        }
        /// <summary>
        /// 购买商品状态
        /// </summary>
        public int purchase_goods_status
        {
            set { _purchase_goods_status = value; }
            get { return _purchase_goods_status; }
        }
        /// <summary>
        /// 是否提交采购
        /// </summary>
        public int is_submit_purchase
        {
            set { _is_submit_purchase = value; }
            get { return _is_submit_purchase; }
        }
        /// <summary>
        /// 库存预警
        /// </summary>
        public int stock_warn
        {
            set { _stock_warn = value; }
            get { return _stock_warn; }
        }
        /// <summary>
        /// 是否要发票
        /// </summary>
        public int? is_invoice
        {
            set { _is_invoice = value; }
            get { return _is_invoice; }
        }
        /// <summary>
        /// 是否占货
        /// </summary>
        public int? is_add_order
        {
            set { _is_add_order = value; }
            get { return _is_add_order; }
        }
        /// <summary>
        /// 单号 对应ecs_order_info.DJHM
        /// </summary>
        public decimal? doc_id
        {
            set { _doc_id = value; }
            get { return _doc_id; }
        }
        /// <summary>
        /// 帐套ID号 通常为3-ZTIDH
        /// </summary>
        public int? wms_setbook_id
        {
            set { _wms_setbook_id = value; }
            get { return _wms_setbook_id; }
        }
        /// <summary>
        /// wms 货位-HW
        /// </summary>
        public string wms_position
        {
            set { _wms_position = value; }
            get { return _wms_position; }
        }
        /// <summary>
        /// wms 记录-JL
        /// </summary>
        public int? wms_record
        {
            set { _wms_record = value; }
            get { return _wms_record; }
        }
        #endregion Model

    }
}

