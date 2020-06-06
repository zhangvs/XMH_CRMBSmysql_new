using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHD.Model
{
	/// <summary>
	/// ecs_order_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public  class ecs_order_info
	{
		public ecs_order_info()
		{}
		#region Model
		private int _order_id;
		private string _order_sn;
		private string _erp_order_sn;
		private string _cwerp_order_sn;
		private string _wms_order_sn;
		private int _user_id;
		private int _order_status=0;
		private int _shipping_status=0;
		private int _pay_status=0;
		private string _consignee;
		private int _country=0;
		private int _province=0;
		private int _city=0;
		private int _district=0;
		private string _address;
		private int? _role_id;
		private int? _user_market_area;
		private string _zipcode;
		private string _tel;
		private string _mobile;
		private string _email;
		private string _best_time;
		private string _sign_building;
		private string _postscript;
		private int _shipping_id=0;
		private string _shipping_name;
		private int? _is_no_shipping_fee=0;
		private int _pay_id=0;
		private string _pay_name;
		private int? _trans_bank_id=0;
		private string _trans_bank_name;
		private string _how_oos;
		private string _how_surplus;
		private string _pack_name;
		private string _card_name;
		private string _card_message;
		private string _inv_payee;
		private string _inv_content;
		private decimal _goods_amount=0.00M;
		private decimal _shipping_fee=0.00M;
		private decimal _insure_fee=0.00M;
		private decimal _pay_fee=0.00M;
		private decimal _pack_fee=0.00M;
		private decimal _card_fee=0.00M;
		private decimal _money_paid=0.00M;
		private decimal _surplus=0.00M;
		private int _integral=0;
		private decimal _integral_money=0.00M;
		private decimal _bonus=0.00M;
		private decimal _order_amount=0.00M;
		private int _from_ad=0;
		private string _referer;
		private int _add_time=0;
		private int _confirm_time=0;
		private int _pay_time=0;
		private int _shipping_time=0;
		private int _pack_id=0;
		private int _card_id=0;
		private int _bonus_id;
		private string _invoice_no;
		private string _extension_code;
		private int _extension_id;
		private string _to_buyer;
		private string _pay_note;
		private int _agency_id;
		private string _inv_type;
		private string _inv_no= "0";
		private decimal _tax;
		private int _is_separate=0;
		private int _parent_id;
		private decimal _discount;
		private string _shipname;
		private int? _affirm_time;
		private int? _need_inv;
		private int? _is_send2_erp=0;
		private int? _is_send2_cwerp;
		private string _is_wuliu_img;
		private string _get_pay_type;
		private int? _is_daifa=0;
		private int? _is_no_qingdan;
		private int _admin_user_id;
		private string _admin_user_name;
		private string _admin_user_real_name;
		private string _send_user_name;
		private string _send_user_tel;
		private string _send_user_company;
		private string _send_user_address;
		private string _cangku_id;
		private string _payinfo_pic;
		private int _is_confirm_remind=0;
		private int _is_print_remind=0;
		private string _order_ip= "0";
		private string _cwerp_time;
		private string _erp_time;
		private int _is_need_review=0;
		private string _review_info;
		private string _operator= "0";
		private string _det_stats= "0";
		private int _dealer_id=0;
		private int? _is_show_price=0;
		private int _operator_user_id;
		private string _file_url;
		private string _invoice_weight;
		private string _order_confirm_info;
		private int _is_invoce=0;
		private string _jz= "-";
		private string _sksm;
		private int? _ztidh;
		private decimal? _djhm;
		private decimal? _lsh=0M;
		private decimal? _hxje=0.00M;
		private decimal? _whxje=0.00M;
		private string _fplx;
		private string _hslx= "销售单出库";
		private int? _pzhm=0;
		private decimal? _je=0.00M;
		private string _shenji;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int order_id
		{
			set{ _order_id=value;}
			get{return _order_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string order_sn
		{
			set{ _order_sn=value;}
			get{return _order_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string erp_order_sn
		{
			set{ _erp_order_sn=value;}
			get{return _erp_order_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cwerp_order_sn
		{
			set{ _cwerp_order_sn=value;}
			get{return _cwerp_order_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wms_order_sn
		{
			set{ _wms_order_sn=value;}
			get{return _wms_order_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int order_status
		{
			set{ _order_status=value;}
			get{return _order_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int shipping_status
		{
			set{ _shipping_status=value;}
			get{return _shipping_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pay_status
		{
			set{ _pay_status=value;}
			get{return _pay_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string consignee
		{
			set{ _consignee=value;}
			get{return _consignee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int country
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int city
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int district
		{
			set{ _district=value;}
			get{return _district;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? role_id
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? user_market_area
		{
			set{ _user_market_area=value;}
			get{return _user_market_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zipcode
		{
			set{ _zipcode=value;}
			get{return _zipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string best_time
		{
			set{ _best_time=value;}
			get{return _best_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sign_building
		{
			set{ _sign_building=value;}
			get{return _sign_building;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string postscript
		{
			set{ _postscript=value;}
			get{return _postscript;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int shipping_id
		{
			set{ _shipping_id=value;}
			get{return _shipping_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shipping_name
		{
			set{ _shipping_name=value;}
			get{return _shipping_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_no_shipping_fee
		{
			set{ _is_no_shipping_fee=value;}
			get{return _is_no_shipping_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pay_id
		{
			set{ _pay_id=value;}
			get{return _pay_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_name
		{
			set{ _pay_name=value;}
			get{return _pay_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? trans_bank_id
		{
			set{ _trans_bank_id=value;}
			get{return _trans_bank_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trans_bank_name
		{
			set{ _trans_bank_name=value;}
			get{return _trans_bank_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string how_oos
		{
			set{ _how_oos=value;}
			get{return _how_oos;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string how_surplus
		{
			set{ _how_surplus=value;}
			get{return _how_surplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pack_name
		{
			set{ _pack_name=value;}
			get{return _pack_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string card_name
		{
			set{ _card_name=value;}
			get{return _card_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string card_message
		{
			set{ _card_message=value;}
			get{return _card_message;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string inv_payee
		{
			set{ _inv_payee=value;}
			get{return _inv_payee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string inv_content
		{
			set{ _inv_content=value;}
			get{return _inv_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal goods_amount
		{
			set{ _goods_amount=value;}
			get{return _goods_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal shipping_fee
		{
			set{ _shipping_fee=value;}
			get{return _shipping_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal insure_fee
		{
			set{ _insure_fee=value;}
			get{return _insure_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal pay_fee
		{
			set{ _pay_fee=value;}
			get{return _pay_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal pack_fee
		{
			set{ _pack_fee=value;}
			get{return _pack_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal card_fee
		{
			set{ _card_fee=value;}
			get{return _card_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal money_paid
		{
			set{ _money_paid=value;}
			get{return _money_paid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal surplus
		{
			set{ _surplus=value;}
			get{return _surplus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal integral_money
		{
			set{ _integral_money=value;}
			get{return _integral_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal bonus
		{
			set{ _bonus=value;}
			get{return _bonus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal order_amount
		{
			set{ _order_amount=value;}
			get{return _order_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int from_ad
		{
			set{ _from_ad=value;}
			get{return _from_ad;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string referer
		{
			set{ _referer=value;}
			get{return _referer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int confirm_time
		{
			set{ _confirm_time=value;}
			get{return _confirm_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pay_time
		{
			set{ _pay_time=value;}
			get{return _pay_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int shipping_time
		{
			set{ _shipping_time=value;}
			get{return _shipping_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pack_id
		{
			set{ _pack_id=value;}
			get{return _pack_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int card_id
		{
			set{ _card_id=value;}
			get{return _card_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int bonus_id
		{
			set{ _bonus_id=value;}
			get{return _bonus_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string invoice_no
		{
			set{ _invoice_no=value;}
			get{return _invoice_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string extension_code
		{
			set{ _extension_code=value;}
			get{return _extension_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int extension_id
		{
			set{ _extension_id=value;}
			get{return _extension_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string to_buyer
		{
			set{ _to_buyer=value;}
			get{return _to_buyer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_note
		{
			set{ _pay_note=value;}
			get{return _pay_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int agency_id
		{
			set{ _agency_id=value;}
			get{return _agency_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string inv_type
		{
			set{ _inv_type=value;}
			get{return _inv_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string inv_no
		{
			set{ _inv_no=value;}
			get{return _inv_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal tax
		{
			set{ _tax=value;}
			get{return _tax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_separate
		{
			set{ _is_separate=value;}
			get{return _is_separate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int parent_id
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shipname
		{
			set{ _shipname=value;}
			get{return _shipname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? affirm_time
		{
			set{ _affirm_time=value;}
			get{return _affirm_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? need_inv
		{
			set{ _need_inv=value;}
			get{return _need_inv;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_send2_erp
		{
			set{ _is_send2_erp=value;}
			get{return _is_send2_erp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_send2_cwerp
		{
			set{ _is_send2_cwerp=value;}
			get{return _is_send2_cwerp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_wuliu_img
		{
			set{ _is_wuliu_img=value;}
			get{return _is_wuliu_img;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string get_pay_type
		{
			set{ _get_pay_type=value;}
			get{return _get_pay_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_daifa
		{
			set{ _is_daifa=value;}
			get{return _is_daifa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_no_qingdan
		{
			set{ _is_no_qingdan=value;}
			get{return _is_no_qingdan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int admin_user_id
		{
			set{ _admin_user_id=value;}
			get{return _admin_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string admin_user_name
		{
			set{ _admin_user_name=value;}
			get{return _admin_user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string admin_user_real_name
		{
			set{ _admin_user_real_name=value;}
			get{return _admin_user_real_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string send_user_name
		{
			set{ _send_user_name=value;}
			get{return _send_user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string send_user_tel
		{
			set{ _send_user_tel=value;}
			get{return _send_user_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string send_user_company
		{
			set{ _send_user_company=value;}
			get{return _send_user_company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string send_user_address
		{
			set{ _send_user_address=value;}
			get{return _send_user_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cangku_id
		{
			set{ _cangku_id=value;}
			get{return _cangku_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string payinfo_pic
		{
			set{ _payinfo_pic=value;}
			get{return _payinfo_pic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_confirm_remind
		{
			set{ _is_confirm_remind=value;}
			get{return _is_confirm_remind;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_print_remind
		{
			set{ _is_print_remind=value;}
			get{return _is_print_remind;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string order_ip
		{
			set{ _order_ip=value;}
			get{return _order_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cwerp_time
		{
			set{ _cwerp_time=value;}
			get{return _cwerp_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string erp_time
		{
			set{ _erp_time=value;}
			get{return _erp_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_need_review
		{
			set{ _is_need_review=value;}
			get{return _is_need_review;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string review_info
		{
			set{ _review_info=value;}
			get{return _review_info;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string det_stats
		{
			set{ _det_stats=value;}
			get{return _det_stats;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int dealer_id
		{
			set{ _dealer_id=value;}
			get{return _dealer_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_show_price
		{
			set{ _is_show_price=value;}
			get{return _is_show_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int operator_user_id
		{
			set{ _operator_user_id=value;}
			get{return _operator_user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_url
		{
			set{ _file_url=value;}
			get{return _file_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string invoice_weight
		{
			set{ _invoice_weight=value;}
			get{return _invoice_weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string order_confirm_info
		{
			set{ _order_confirm_info=value;}
			get{return _order_confirm_info;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_invoce
		{
			set{ _is_invoce=value;}
			get{return _is_invoce;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jz
		{
			set{ _jz=value;}
			get{return _jz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SKSM
		{
			set{ _sksm=value;}
			get{return _sksm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ztidh
		{
			set{ _ztidh=value;}
			get{return _ztidh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? djhm
		{
			set{ _djhm=value;}
			get{return _djhm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? lsh
		{
			set{ _lsh=value;}
			get{return _lsh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? hxje
		{
			set{ _hxje=value;}
			get{return _hxje;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? whxje
		{
			set{ _whxje=value;}
			get{return _whxje;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fplx
		{
			set{ _fplx=value;}
			get{return _fplx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hslx
		{
			set{ _hslx=value;}
			get{return _hslx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pzhm
		{
			set{ _pzhm=value;}
			get{return _pzhm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? je
		{
			set{ _je=value;}
			get{return _je;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shenji
		{
			set{ _shenji=value;}
			get{return _shenji;}
		}
		#endregion Model

	}
}

