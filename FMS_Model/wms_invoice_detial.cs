using System;
namespace FMS_Model
{
	/// <summary>
	/// wms_invoice_detial:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class wms_invoice_detial
	{
		public wms_invoice_detial()
		{}
		#region Model
		private long _id;
		private string _inv_sn;
		private int? _record;
		private DateTime? _inv_time;
		private DateTime? _set_time;
		private long? _goods_id;
		private string _goods_sn;
		private string _goods_name;
		private decimal? _goods_price=0.00M;
		private decimal? _ntax_price=0.00M;
		private int? _goods_num=0;
		private string _goods_unit;
		private decimal? _money=0.00M;
		private string _batch_no;
		private string _go_sn;
		private int? _go_record=0;
		private decimal? _tax_money=0.00M;
		private decimal? _ntax_money=0.00M;
		/// <summary>
		/// 自增主键
		/// </summary>
		public long id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 核销票据流水号
		/// </summary>
		public string inv_sn
		{
			set{ _inv_sn=value;}
			get{return _inv_sn;}
		}
		/// <summary>
		/// 记录
		/// </summary>
		public int? record
		{
			set{ _record=value;}
			get{return _record;}
		}
		/// <summary>
		/// 发票日期
		/// </summary>
		public DateTime? inv_time
		{
			set{ _inv_time=value;}
			get{return _inv_time;}
		}
		/// <summary>
		/// 指定日期
		/// </summary>
		public DateTime? set_time
		{
			set{ _set_time=value;}
			get{return _set_time;}
		}
		/// <summary>
		/// 商品id
		/// </summary>
		public long? goods_id
		{
			set{ _goods_id=value;}
			get{return _goods_id;}
		}
		/// <summary>
		/// 商品编号
		/// </summary>
		public string goods_sn
		{
			set{ _goods_sn=value;}
			get{return _goods_sn;}
		}
		/// <summary>
		/// 商品名称
		/// </summary>
		public string goods_name
		{
			set{ _goods_name=value;}
			get{return _goods_name;}
		}
		/// <summary>
		/// 商品单价
		/// </summary>
		public decimal? goods_price
		{
			set{ _goods_price=value;}
			get{return _goods_price;}
		}
		/// <summary>
		/// 未税单价
		/// </summary>
		public decimal? ntax_price
		{
			set{ _ntax_price=value;}
			get{return _ntax_price;}
		}
		/// <summary>
		/// 商品数量
		/// </summary>
		public int? goods_num
		{
			set{ _goods_num=value;}
			get{return _goods_num;}
		}
		/// <summary>
		/// 商品单位
		/// </summary>
		public string goods_unit
		{
			set{ _goods_unit=value;}
			get{return _goods_unit;}
		}
		/// <summary>
		/// 总金额
		/// </summary>
		public decimal? money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 批次号
		/// </summary>
		public string batch_no
		{
			set{ _batch_no=value;}
			get{return _batch_no;}
		}
		/// <summary>
		/// 入库单号码
		/// </summary>
		public string go_sn
		{
			set{ _go_sn=value;}
			get{return _go_sn;}
		}
		/// <summary>
		/// 入库单记录
		/// </summary>
		public int? go_record
		{
			set{ _go_record=value;}
			get{return _go_record;}
		}
		/// <summary>
		/// 税额
		/// </summary>
		public decimal? tax_money
		{
			set{ _tax_money=value;}
			get{return _tax_money;}
		}
		/// <summary>
		/// 未税金额
		/// </summary>
		public decimal? ntax_money
		{
			set{ _ntax_money=value;}
			get{return _ntax_money;}
		}
		#endregion Model

	}
}

