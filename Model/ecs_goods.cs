using System;
namespace XHD.Model
{
    /// <summary>
    /// ecs_goods:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ecs_goods
    {
        public ecs_goods()
        { }
        #region Model
        private int _goods_id;
        private string _factory_id;
        private int? _suppliers_id;
        private string _goods_sn;
        private string _goods_name;
        private string _goods_name_style = "+";
        private string _goods_invoce_name;
        private int _click_count = 0;
        private int _brand_id = 0;
        private string _provider_name;
        private decimal _goods_number = 0.00M;
        private decimal _goods_weight = 0.0000M;
        private int _box_num;
        private decimal _box_weight;
        private decimal _box_length;
        private decimal _box_width;
        private decimal _box_height;
        private string _goods_snc;
        private string _goods_snb;
        private string _goods_sna;
        private string _goods_u2tou1;
        private string _goods_u3tou1;
        private string _goods_unit;
        private string _goods_unit2;
        private string _goods_unit3;
        private string _goods_packing = "0";
        private decimal _market_price = 0.000M;
        private decimal _wholesale_price = 0.000M;
        private decimal _shop_price = 0.000M;
        private int _goods_num_limit = -1;
        private int _goods_num_limit2 = -1;
        private decimal _promote_price = 0.000M;
        private int _promote_start_date = 0;
        private int _promote_end_date = 0;
        private int _warn_number = 1;
        private string _keywords;
        private string _goods_brief;
        private string _goods_desc;
        private string _goods_thumb;
        private string _goods_img;
        private string _original_img;
        private int _is_real = 1;
        private string _extension_code;
        private int _is_on_sale = 1;
        private int _is_alone_sale = 1;
        private int _is_shipping = 0;
        private int _integral = 0;
        private int _add_time = 0;
        private int _sort_order = 100;
        private int _is_delete = 0;
        private int _is_best = 0;
        private int _is_new = 0;
        private int _is_hot = 0;
        private int _is_standing_stock = 0;
        private int _is_promote = 0;
        private int _bonus_type_id = 0;
        private int _last_update = 0;
        private int _goods_type = 0;
        private string _seller_note;
        private int _give_integral = -1;
        private int _rank_integral = -1;
        private int? _is_check;
        private int _cat_id = 0;
        private int _is_catindex;
        private int? _is_main_show;
        private string _goods_sn2;
        private decimal _goods_volume;
        private int _charge_by_volume = 0;
        private decimal? _mian_price = 0.000M;
        private int _goods_stock = 0;
        private string _sx = "库存商品";
        private int _dealer_id;
        private int? _is_share = 1;
        private int? _goods_source = 0;
        private string _file_ip;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int goods_id
        {
            set { _goods_id = value; }
            get { return _goods_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string factory_id
        {
            set { _factory_id = value; }
            get { return _factory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? suppliers_id
        {
            set { _suppliers_id = value; }
            get { return _suppliers_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_sn
        {
            set { _goods_sn = value; }
            get { return _goods_sn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_name
        {
            set { _goods_name = value; }
            get { return _goods_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_name_style
        {
            set { _goods_name_style = value; }
            get { return _goods_name_style; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_invoce_name
        {
            set { _goods_invoce_name = value; }
            get { return _goods_invoce_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int click_count
        {
            set { _click_count = value; }
            get { return _click_count; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int brand_id
        {
            set { _brand_id = value; }
            get { return _brand_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string provider_name
        {
            set { _provider_name = value; }
            get { return _provider_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal goods_number
        {
            set { _goods_number = value; }
            get { return _goods_number; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal goods_weight
        {
            set { _goods_weight = value; }
            get { return _goods_weight; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int box_num
        {
            set { _box_num = value; }
            get { return _box_num; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal box_weight
        {
            set { _box_weight = value; }
            get { return _box_weight; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal box_length
        {
            set { _box_length = value; }
            get { return _box_length; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal box_width
        {
            set { _box_width = value; }
            get { return _box_width; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal box_height
        {
            set { _box_height = value; }
            get { return _box_height; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_snc
        {
            set { _goods_snc = value; }
            get { return _goods_snc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_snb
        {
            set { _goods_snb = value; }
            get { return _goods_snb; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_sna
        {
            set { _goods_sna = value; }
            get { return _goods_sna; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_u2tou1
        {
            set { _goods_u2tou1 = value; }
            get { return _goods_u2tou1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_u3tou1
        {
            set { _goods_u3tou1 = value; }
            get { return _goods_u3tou1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_unit
        {
            set { _goods_unit = value; }
            get { return _goods_unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_unit2
        {
            set { _goods_unit2 = value; }
            get { return _goods_unit2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_unit3
        {
            set { _goods_unit3 = value; }
            get { return _goods_unit3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_packing
        {
            set { _goods_packing = value; }
            get { return _goods_packing; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal market_price
        {
            set { _market_price = value; }
            get { return _market_price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal wholesale_price
        {
            set { _wholesale_price = value; }
            get { return _wholesale_price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal shop_price
        {
            set { _shop_price = value; }
            get { return _shop_price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int goods_num_limit
        {
            set { _goods_num_limit = value; }
            get { return _goods_num_limit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int goods_num_limit2
        {
            set { _goods_num_limit2 = value; }
            get { return _goods_num_limit2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal promote_price
        {
            set { _promote_price = value; }
            get { return _promote_price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int promote_start_date
        {
            set { _promote_start_date = value; }
            get { return _promote_start_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int promote_end_date
        {
            set { _promote_end_date = value; }
            get { return _promote_end_date; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int warn_number
        {
            set { _warn_number = value; }
            get { return _warn_number; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string keywords
        {
            set { _keywords = value; }
            get { return _keywords; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_brief
        {
            set { _goods_brief = value; }
            get { return _goods_brief; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_desc
        {
            set { _goods_desc = value; }
            get { return _goods_desc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_thumb
        {
            set { _goods_thumb = value; }
            get { return _goods_thumb; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_img
        {
            set { _goods_img = value; }
            get { return _goods_img; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string original_img
        {
            set { _original_img = value; }
            get { return _original_img; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_real
        {
            set { _is_real = value; }
            get { return _is_real; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string extension_code
        {
            set { _extension_code = value; }
            get { return _extension_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_on_sale
        {
            set { _is_on_sale = value; }
            get { return _is_on_sale; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_alone_sale
        {
            set { _is_alone_sale = value; }
            get { return _is_alone_sale; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_shipping
        {
            set { _is_shipping = value; }
            get { return _is_shipping; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int integral
        {
            set { _integral = value; }
            get { return _integral; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sort_order
        {
            set { _sort_order = value; }
            get { return _sort_order; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_delete
        {
            set { _is_delete = value; }
            get { return _is_delete; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_best
        {
            set { _is_best = value; }
            get { return _is_best; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_new
        {
            set { _is_new = value; }
            get { return _is_new; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_hot
        {
            set { _is_hot = value; }
            get { return _is_hot; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_standing_stock
        {
            set { _is_standing_stock = value; }
            get { return _is_standing_stock; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_promote
        {
            set { _is_promote = value; }
            get { return _is_promote; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int bonus_type_id
        {
            set { _bonus_type_id = value; }
            get { return _bonus_type_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int last_update
        {
            set { _last_update = value; }
            get { return _last_update; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int goods_type
        {
            set { _goods_type = value; }
            get { return _goods_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string seller_note
        {
            set { _seller_note = value; }
            get { return _seller_note; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int give_integral
        {
            set { _give_integral = value; }
            get { return _give_integral; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int rank_integral
        {
            set { _rank_integral = value; }
            get { return _rank_integral; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_check
        {
            set { _is_check = value; }
            get { return _is_check; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int cat_id
        {
            set { _cat_id = value; }
            get { return _cat_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int is_catindex
        {
            set { _is_catindex = value; }
            get { return _is_catindex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_main_show
        {
            set { _is_main_show = value; }
            get { return _is_main_show; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string goods_sn2
        {
            set { _goods_sn2 = value; }
            get { return _goods_sn2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal goods_volume
        {
            set { _goods_volume = value; }
            get { return _goods_volume; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int charge_by_volume
        {
            set { _charge_by_volume = value; }
            get { return _charge_by_volume; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? mian_price
        {
            set { _mian_price = value; }
            get { return _mian_price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int goods_stock
        {
            set { _goods_stock = value; }
            get { return _goods_stock; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sx
        {
            set { _sx = value; }
            get { return _sx; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int dealer_id
        {
            set { _dealer_id = value; }
            get { return _dealer_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? is_share
        {
            set { _is_share = value; }
            get { return _is_share; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? goods_source
        {
            set { _goods_source = value; }
            get { return _goods_source; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string file_ip
        {
            set { _file_ip = value; }
            get { return _file_ip; }
        }
        #endregion Model

    }
}

