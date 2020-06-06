using System;
namespace FMS_Model
{
    /// <summary>
    /// wms_payment_bill:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class wms_payment_bill
    {
		public wms_payment_bill()
		{}
		#region Model
		private long _pay_id;
		private string _pay_sn;
		private string _emp_no;
		private string _emp_name;
		private string _emp_audit;
		private DateTime? _add_time;
		private DateTime? _v_time;
		private DateTime? _review_time;
		private DateTime? _pay_time;
		private int _pay_status=0;
		private int? _review_status=0;
		private int? _red_rush=0;
		private string _pa_no;
		private string _payment_account;
		private string _suppliers_erp_code;
		private string _suppliers_name;
		private string _ra_no;
		private string _receive_account;
		private string _pay_disc;
		private string _remark;
		private int? _is_del=0;
		private string _emp_pay;
		private decimal _pay_money=0.00M;
		/// <summary>
		/// 
		/// </summary>
		public long pay_id
		{
			set{ _pay_id=value;}
			get{return _pay_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_sn
		{
			set{ _pay_sn=value;}
			get{return _pay_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string emp_no
		{
			set{ _emp_no=value;}
			get{return _emp_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string emp_name
		{
			set{ _emp_name=value;}
			get{return _emp_name;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string emp_audit
		{
			set{ _emp_audit=value;}
			get{return _emp_audit;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 付款结算凭证时间
		/// </summary>
		public DateTime? v_time
		{
			set{ _v_time=value;}
			get{return _v_time;}
		}
		/// <summary>
		/// 复审时间
		/// </summary>
		public DateTime? review_time
		{
			set{ _review_time=value;}
			get{return _review_time;}
		}
		/// <summary>
		/// 付款时间
		/// </summary>
		public DateTime? pay_time
		{
			set{ _pay_time=value;}
			get{return _pay_time;}
		}
		/// <summary>
		/// 付款状态：0.待审核，1.已审核，2.已结算（支付）
		/// </summary>
		public int pay_status
		{
			set{ _pay_status=value;}
			get{return _pay_status;}
		}
		/// <summary>
		/// 复审状态：0.未复审，1.已复审
		/// </summary>
		public int? review_status
		{
			set{ _review_status=value;}
			get{return _review_status;}
		}
		/// <summary>
		/// 冲红标志：0.正常，1.已冲红
		/// </summary>
		public int? red_rush
		{
			set{ _red_rush=value;}
			get{return _red_rush;}
		}
		/// <summary>
		/// 付款账号编号
		/// </summary>
		public string pa_no
		{
			set{ _pa_no=value;}
			get{return _pa_no;}
		}
		/// <summary>
		/// 付款账号
		/// </summary>
		public string payment_account
		{
			set{ _payment_account=value;}
			get{return _payment_account;}
		}
		/// <summary>
		/// 供应商编码
		/// </summary>
		public string suppliers_erp_code
		{
			set{ _suppliers_erp_code=value;}
			get{return _suppliers_erp_code;}
		}
		/// <summary>
		/// 供应商名称
		/// </summary>
		public string suppliers_name
		{
			set{ _suppliers_name=value;}
			get{return _suppliers_name;}
		}
		/// <summary>
		/// 收款账号编号
		/// </summary>
		public string ra_no
		{
			set{ _ra_no=value;}
			get{return _ra_no;}
		}
		/// <summary>
		/// 收款账号
		/// </summary>
		public string receive_account
		{
			set{ _receive_account=value;}
			get{return _receive_account;}
		}
		/// <summary>
		/// 支付描述
		/// </summary>
		public string pay_disc
		{
			set{ _pay_disc=value;}
			get{return _pay_disc;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 删除标志
		/// </summary>
		public int? is_del
		{
			set{ _is_del=value;}
			get{return _is_del;}
		}
		/// <summary>
		/// 付款人
		/// </summary>
		public string emp_pay
		{
			set{ _emp_pay=value;}
			get{return _emp_pay;}
		}
		/// <summary>
		/// 付款金额
		/// </summary>
		public decimal pay_money
		{
			set{ _pay_money=value;}
			get{return _pay_money;}
		}
		#endregion Model





    }
}

