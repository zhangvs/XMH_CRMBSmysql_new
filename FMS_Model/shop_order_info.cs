using System;

namespace FMS_Model
{
	/// <summary>
	/// shop_order_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shop_order_info
	{
		public shop_order_info()
		{}
		#region Model
		private int _order_id;
		private string _order_sn;
		private string _wms_order_sn;
		private string _erp_order_sn;
		private string _cwerp_order_sn;
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
		private int _user_market_area;
		private string _zipcode;
		private string _tel;
		private string _mobile;
		private string _email;
		private string _postscript;
		private string _order_note;
		private int _shipping_id=0;
		private string _shipping_name;
		private int? _is_no_shipping_fee=0;
		private int _pay_id=0;
		private string _pay_name;
		private int? _trans_bank_id=0;
		private string _trans_bank_name;
		private string _inv_payee;
		private string _inv_content;
		private decimal _goods_amount;
		private decimal _shipping_fee=0.00M;
		private decimal _insure_fee=0.00M;
		private decimal _pay_fee=0.00M;
		private decimal _pack_fee=0.00M;
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
		private string _to_buyer;
		private string _pay_note;
		private int _agency_id;
		private string _inv_type;
		private decimal _tax;
		private decimal _discount;
		private int? _wuliu_id;
		private string _wuliu_name;
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
		private string _invoice_weight;
		private string _order_confirm_info;
		private int _invoice_id;
		private int? _wms_setbook_id;
		private decimal? _wms_doc_id;
		private string _wms_account_flag= "-";
		private string _wms_receive_note;
		private decimal? _wms_flow_no=0M;
		private decimal? _wms_finish_amout=0.00M;
		private decimal? _wms_unfinish_amout=0.00M;
		private string _wms_invoice_type;
		private string _wms_account_type= "销售单出库";
		private int? _wms_voucher=0;
		private decimal _wms_amount=0.00M;
		private string _wms_storage= "K1";
		private string _supply_user_id;
		private int? _is_invoice_advance=0;
		/// <summary>
		/// 订单id
		/// </summary>
		public int order_id
		{
			set{ _order_id=value;}
			get{return _order_id;}
		}
		/// <summary>
		/// 订单号
		/// </summary>
		public string order_sn
		{
			set{ _order_sn=value;}
			get{return _order_sn;}
		}
		/// <summary>
		/// wms单号
		/// </summary>
		public string wms_order_sn
		{
			set{ _wms_order_sn=value;}
			get{return _wms_order_sn;}
		}
		/// <summary>
		/// erp订单号
		/// </summary>
		public string erp_order_sn
		{
			set{ _erp_order_sn=value;}
			get{return _erp_order_sn;}
		}
		/// <summary>
		/// 财务erp订单号
		/// </summary>
		public string cwerp_order_sn
		{
			set{ _cwerp_order_sn=value;}
			get{return _cwerp_order_sn;}
		}
		/// <summary>
		/// 客户ID
		/// </summary>
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 订单状态
		/// </summary>
		public int order_status
		{
			set{ _order_status=value;}
			get{return _order_status;}
		}
		/// <summary>
		/// 配送状态
		/// </summary>
		public int shipping_status
		{
			set{ _shipping_status=value;}
			get{return _shipping_status;}
		}
		/// <summary>
		/// 支付状态
		/// </summary>
		public int pay_status
		{
			set{ _pay_status=value;}
			get{return _pay_status;}
		}
		/// <summary>
		/// 收货人
		/// </summary>
		public string consignee
		{
			set{ _consignee=value;}
			get{return _consignee;}
		}
		/// <summary>
		/// 国家
		/// </summary>
		public int country
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 省
		/// </summary>
		public int province
		{
			set{ _province=value;}
			get{return _province;}
		}
		/// <summary>
		/// 市
		/// </summary>
		public int city
		{
			set{ _city=value;}
			get{return _city;}
		}
		/// <summary>
		/// 区
		/// </summary>
		public int district
		{
			set{ _district=value;}
			get{return _district;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 角色id
		/// </summary>
		public int? role_id
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		/// <summary>
		/// 所属市场大区
		/// </summary>
		public int user_market_area
		{
			set{ _user_market_area=value;}
			get{return _user_market_area;}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string zipcode
		{
			set{ _zipcode=value;}
			get{return _zipcode;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 邮箱
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 用户的备注
		/// </summary>
		public string postscript
		{
			set{ _postscript=value;}
			get{return _postscript;}
		}
		/// <summary>
		/// 订单备注，原how_oos字段并
		/// </summary>
		public string order_note
		{
			set{ _order_note=value;}
			get{return _order_note;}
		}
		/// <summary>
		/// 快递公司id
		/// </summary>
		public int shipping_id
		{
			set{ _shipping_id=value;}
			get{return _shipping_id;}
		}
		/// <summary>
		/// 快递公司名
		/// </summary>
		public string shipping_name
		{
			set{ _shipping_name=value;}
			get{return _shipping_name;}
		}
		/// <summary>
		/// 是否免运费
		/// </summary>
		public int? is_no_shipping_fee
		{
			set{ _is_no_shipping_fee=value;}
			get{return _is_no_shipping_fee;}
		}
		/// <summary>
		/// 支付方式id
		/// </summary>
		public int pay_id
		{
			set{ _pay_id=value;}
			get{return _pay_id;}
		}
		/// <summary>
		/// 支付方式名
		/// </summary>
		public string pay_name
		{
			set{ _pay_name=value;}
			get{return _pay_name;}
		}
		/// <summary>
		/// 银行转账-银行id
		/// </summary>
		public int? trans_bank_id
		{
			set{ _trans_bank_id=value;}
			get{return _trans_bank_id;}
		}
		/// <summary>
		/// 银行转账-银行名称
		/// </summary>
		public string trans_bank_name
		{
			set{ _trans_bank_name=value;}
			get{return _trans_bank_name;}
		}
		/// <summary>
		/// 发票类型
		/// </summary>
		public string inv_payee
		{
			set{ _inv_payee=value;}
			get{return _inv_payee;}
		}
		/// <summary>
		/// 发票内容
		/// </summary>
		public string inv_content
		{
			set{ _inv_content=value;}
			get{return _inv_content;}
		}
		/// <summary>
		/// 商品总金额
		/// </summary>
		public decimal goods_amount
		{
			set{ _goods_amount=value;}
			get{return _goods_amount;}
		}
		/// <summary>
		/// 运费
		/// </summary>
		public decimal shipping_fee
		{
			set{ _shipping_fee=value;}
			get{return _shipping_fee;}
		}
		/// <summary>
		/// 保价费
		/// </summary>
		public decimal insure_fee
		{
			set{ _insure_fee=value;}
			get{return _insure_fee;}
		}
		/// <summary>
		/// 手续费
		/// </summary>
		public decimal pay_fee
		{
			set{ _pay_fee=value;}
			get{return _pay_fee;}
		}
		/// <summary>
		/// 包装费
		/// </summary>
		public decimal pack_fee
		{
			set{ _pack_fee=value;}
			get{return _pack_fee;}
		}
		/// <summary>
		/// 支付金额
		/// </summary>
		public decimal money_paid
		{
			set{ _money_paid=value;}
			get{return _money_paid;}
		}
		/// <summary>
		/// 余额
		/// </summary>
		public decimal surplus
		{
			set{ _surplus=value;}
			get{return _surplus;}
		}
		/// <summary>
		/// 积分
		/// </summary>
		public int integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 积分减免金额
		/// </summary>
		public decimal integral_money
		{
			set{ _integral_money=value;}
			get{return _integral_money;}
		}
		/// <summary>
		/// 红包金额
		/// </summary>
		public decimal bonus
		{
			set{ _bonus=value;}
			get{return _bonus;}
		}
		/// <summary>
		/// 订单总金额
		/// </summary>
		public decimal order_amount
		{
			set{ _order_amount=value;}
			get{return _order_amount;}
		}
		/// <summary>
		/// 来源广告位
		/// </summary>
		public int from_ad
		{
			set{ _from_ad=value;}
			get{return _from_ad;}
		}
		/// <summary>
		/// 订单来源
		/// </summary>
		public string referer
		{
			set{ _referer=value;}
			get{return _referer;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public int add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 确认时间
		/// </summary>
		public int confirm_time
		{
			set{ _confirm_time=value;}
			get{return _confirm_time;}
		}
		/// <summary>
		/// 支付时间
		/// </summary>
		public int pay_time
		{
			set{ _pay_time=value;}
			get{return _pay_time;}
		}
		/// <summary>
		/// 发货时间
		/// </summary>
		public int shipping_time
		{
			set{ _shipping_time=value;}
			get{return _shipping_time;}
		}
		/// <summary>
		/// 包装id
		/// </summary>
		public int pack_id
		{
			set{ _pack_id=value;}
			get{return _pack_id;}
		}
		/// <summary>
		/// 贺卡id
		/// </summary>
		public int card_id
		{
			set{ _card_id=value;}
			get{return _card_id;}
		}
		/// <summary>
		/// 红包id
		/// </summary>
		public int bonus_id
		{
			set{ _bonus_id=value;}
			get{return _bonus_id;}
		}
		/// <summary>
		/// 发货单号
		/// </summary>
		public string invoice_no
		{
			set{ _invoice_no=value;}
			get{return _invoice_no;}
		}
		/// <summary>
		/// 对客户的说明
		/// </summary>
		public string to_buyer
		{
			set{ _to_buyer=value;}
			get{return _to_buyer;}
		}
		/// <summary>
		/// 支付备注
		/// </summary>
		public string pay_note
		{
			set{ _pay_note=value;}
			get{return _pay_note;}
		}
		/// <summary>
		/// 办事处id
		/// </summary>
		public int agency_id
		{
			set{ _agency_id=value;}
			get{return _agency_id;}
		}
		/// <summary>
		/// 发票类型，普通/增值税/税票
		/// </summary>
		public string inv_type
		{
			set{ _inv_type=value;}
			get{return _inv_type;}
		}
		/// <summary>
		/// 税费
		/// </summary>
		public decimal tax
		{
			set{ _tax=value;}
			get{return _tax;}
		}
		/// <summary>
		/// 折扣
		/// </summary>
		public decimal discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 物流公司id
		/// </summary>
		public int? wuliu_id
		{
			set{ _wuliu_id=value;}
			get{return _wuliu_id;}
		}
		/// <summary>
		/// 物流公司名
		/// </summary>
		public string wuliu_name
		{
			set{ _wuliu_name=value;}
			get{return _wuliu_name;}
		}
		/// <summary>
		/// 是否需要发票
		/// </summary>
		public int? need_inv
		{
			set{ _need_inv=value;}
			get{return _need_inv;}
		}
		/// <summary>
		/// 是否发送erp
		/// </summary>
		public int? is_send2_erp
		{
			set{ _is_send2_erp=value;}
			get{return _is_send2_erp;}
		}
		/// <summary>
		/// 是否发送财务erp
		/// </summary>
		public int? is_send2_cwerp
		{
			set{ _is_send2_cwerp=value;}
			get{return _is_send2_cwerp;}
		}
		/// <summary>
		/// 物流发货单照片
		/// </summary>
		public string is_wuliu_img
		{
			set{ _is_wuliu_img=value;}
			get{return _is_wuliu_img;}
		}
		/// <summary>
		/// 收款方式
		/// </summary>
		public string get_pay_type
		{
			set{ _get_pay_type=value;}
			get{return _get_pay_type;}
		}
		/// <summary>
		/// 是否代发
		/// </summary>
		public int? is_daifa
		{
			set{ _is_daifa=value;}
			get{return _is_daifa;}
		}
		/// <summary>
		/// 是否不放清单
		/// </summary>
		public int? is_no_qingdan
		{
			set{ _is_no_qingdan=value;}
			get{return _is_no_qingdan;}
		}
		/// <summary>
		/// 管理员id
		/// </summary>
		public int admin_user_id
		{
			set{ _admin_user_id=value;}
			get{return _admin_user_id;}
		}
		/// <summary>
		/// 所属客服
		/// </summary>
		public string admin_user_name
		{
			set{ _admin_user_name=value;}
			get{return _admin_user_name;}
		}
		/// <summary>
		/// 管理员真名
		/// </summary>
		public string admin_user_real_name
		{
			set{ _admin_user_real_name=value;}
			get{return _admin_user_real_name;}
		}
		/// <summary>
		/// 代发货人姓名
		/// </summary>
		public string send_user_name
		{
			set{ _send_user_name=value;}
			get{return _send_user_name;}
		}
		/// <summary>
		/// 代发货人电话
		/// </summary>
		public string send_user_tel
		{
			set{ _send_user_tel=value;}
			get{return _send_user_tel;}
		}
		/// <summary>
		/// 代发货人公司
		/// </summary>
		public string send_user_company
		{
			set{ _send_user_company=value;}
			get{return _send_user_company;}
		}
		/// <summary>
		/// 代发货人地址
		/// </summary>
		public string send_user_address
		{
			set{ _send_user_address=value;}
			get{return _send_user_address;}
		}
		/// <summary>
		/// 由wms_storage转换来的$ktypeid
		/// </summary>
		public string cangku_id
		{
			set{ _cangku_id=value;}
			get{return _cangku_id;}
		}
		/// <summary>
		/// 付款信息图片截图（确认时用）
		/// </summary>
		public string payinfo_pic
		{
			set{ _payinfo_pic=value;}
			get{return _payinfo_pic;}
		}
		/// <summary>
		/// 调单提醒是否已发送：0未发送，1已发送
		/// </summary>
		public int is_confirm_remind
		{
			set{ _is_confirm_remind=value;}
			get{return _is_confirm_remind;}
		}
		/// <summary>
		/// 订单打印提醒是否已发送：0未发送，1已发送
		/// </summary>
		public int is_print_remind
		{
			set{ _is_print_remind=value;}
			get{return _is_print_remind;}
		}
		/// <summary>
		/// 下单ip
		/// </summary>
		public string order_ip
		{
			set{ _order_ip=value;}
			get{return _order_ip;}
		}
		/// <summary>
		/// 发送财务erp时间
		/// </summary>
		public string cwerp_time
		{
			set{ _cwerp_time=value;}
			get{return _cwerp_time;}
		}
		/// <summary>
		/// 发送ERP时间(调单时间)
		/// </summary>
		public string erp_time
		{
			set{ _erp_time=value;}
			get{return _erp_time;}
		}
		/// <summary>
		/// 是否需要审核
		/// </summary>
		public int is_need_review
		{
			set{ _is_need_review=value;}
			get{return _is_need_review;}
		}
		/// <summary>
		/// 审核原因
		/// </summary>
		public string review_info
		{
			set{ _review_info=value;}
			get{return _review_info;}
		}

		/// <summary>
		/// 经手人
		/// </summary>
		public string operators
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 代尔塔订单状态
		/// </summary>
		public string det_stats
		{
			set{ _det_stats=value;}
			get{return _det_stats;}
		}
		/// <summary>
		/// 经销商id
		/// </summary>
		public int dealer_id
		{
			set{ _dealer_id=value;}
			get{return _dealer_id;}
		}
		/// <summary>
		/// 发货单是否显示价格
		/// </summary>
		public int? is_show_price
		{
			set{ _is_show_price=value;}
			get{return _is_show_price;}
		}
		/// <summary>
		/// 操作者id
		/// </summary>
		public int operator_user_id
		{
			set{ _operator_user_id=value;}
			get{return _operator_user_id;}
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
		/// 单据备注(打印显示,自动保存)
		/// </summary>
		public string order_confirm_info
		{
			set{ _order_confirm_info=value;}
			get{return _order_confirm_info;}
		}
		/// <summary>
		/// 发票id
		/// </summary>
		public int invoice_id
		{
			set{ _invoice_id=value;}
			get{return _invoice_id;}
		}
		/// <summary>
		/// WMS 帐套ID号 通常为3
		/// </summary>
		public int? wms_setbook_id
		{
			set{ _wms_setbook_id=value;}
			get{return _wms_setbook_id;}
		}
		/// <summary>
		/// WMS 单号 对应ecs_order_goods.DJHM
		/// </summary>
		public decimal? wms_doc_id
		{
			set{ _wms_doc_id=value;}
			get{return _wms_doc_id;}
		}
		/// <summary>
		/// WMS 记账标志 - 表示未记账 √ 表示已记账-jz
		/// </summary>
		public string wms_account_flag
		{
			set{ _wms_account_flag=value;}
			get{return _wms_account_flag;}
		}
		/// <summary>
		/// WMS 收款说明 sksm
		/// </summary>
		public string wms_receive_note
		{
			set{ _wms_receive_note=value;}
			get{return _wms_receive_note;}
		}
		/// <summary>
		/// WMS 流水号 lsh
		/// </summary>
		public decimal? wms_flow_no
		{
			set{ _wms_flow_no=value;}
			get{return _wms_flow_no;}
		}
		/// <summary>
		/// WMS 核销金额 hxje
		/// </summary>
		public decimal? wms_finish_amout
		{
			set{ _wms_finish_amout=value;}
			get{return _wms_finish_amout;}
		}
		/// <summary>
		/// WMS 未核销金额 whxje
		/// </summary>
		public decimal? wms_unfinish_amout
		{
			set{ _wms_unfinish_amout=value;}
			get{return _wms_unfinish_amout;}
		}
		/// <summary>
		/// WMS 发票类型 fplx
		/// </summary>
		public string wms_invoice_type
		{
			set{ _wms_invoice_type=value;}
			get{return _wms_invoice_type;}
		}
		/// <summary>
		/// WMS 核算类型 hslx
		/// </summary>
		public string wms_account_type
		{
			set{ _wms_account_type=value;}
			get{return _wms_account_type;}
		}
		/// <summary>
		/// WMS 凭证号码 pzhm
		/// </summary>
		public int? wms_voucher
		{
			set{ _wms_voucher=value;}
			get{return _wms_voucher;}
		}
		/// <summary>
		/// WMS 本单金额 数据来源ecs_order_goods.goods_number乘ecs_order_goods.goods_price
		/// </summary>
		public decimal wms_amount
		{
			set{ _wms_amount=value;}
			get{return _wms_amount;}
		}
		/// <summary>
		/// WMS类型 K1 K2 K3
		/// </summary>
		public string wms_storage
		{
			set{ _wms_storage=value;}
			get{return _wms_storage;}
		}
		/// <summary>
		/// 供应商经手客服
		/// </summary>
		public string supply_user_id
		{
			set{ _supply_user_id=value;}
			get{return _supply_user_id;}
		}
		/// <summary>
		/// 1:是否未发货先开票2:没有货先开票
		/// </summary>
		public int? is_invoice_advance
		{
			set{ _is_invoice_advance=value;}
			get{return _is_invoice_advance;}
		}
		#endregion Model

	}
}

