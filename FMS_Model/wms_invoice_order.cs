using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_Model
{
    /// <summary>
	/// wms_invoice_order:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class wms_invoice_order
	{
		public wms_invoice_order()
		{}
		#region Model
		private long _inv_id;
		private string _inv_sn;
		private string _inv_list;
		private DateTime? _inv_time;
		private DateTime? _set_time;
		private DateTime? _audit_time;
		private string _account_no;
		private string _account_name;
		private string _suppliers_erp_code;
		private string _suppliers_name;
		private string _emp_name;
		private string _emp_code;
		private string _audit_name;
		private string _audit_code;
		private decimal? _total_money=0.00M;
		private decimal? _tax_money=0.00M;
		private decimal? _ntax_money=0.00M;
		private string _remark;
		private int? _inv_status=0;
		private int? _push_erp=0;
		private int? _is_del=0;
		private int? _red_rush=0;
		/// <summary>
		/// 发票id号，自增主键
		/// </summary>
		public long inv_id
		{
			set{ _inv_id=value;}
			get{return _inv_id;}
		}
		/// <summary>
		/// 发票流水号
		/// </summary>
		public string inv_sn
		{
			set{ _inv_sn=value;}
			get{return _inv_sn;}
		}
		/// <summary>
		/// 发票号码（用逗号隔开）
		/// </summary>
		public string inv_list
		{
			set{ _inv_list=value;}
			get{return _inv_list;}
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
		/// 核审时间
		/// </summary>
		public DateTime? audit_time
		{
			set{ _audit_time=value;}
			get{return _audit_time;}
		}
		/// <summary>
		/// 账号编码
		/// </summary>
		public string account_no
		{
			set{ _account_no=value;}
			get{return _account_no;}
		}
		/// <summary>
		/// 账号名称
		/// </summary>
		public string account_name
		{
			set{ _account_name=value;}
			get{return _account_name;}
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
		/// 制单人姓名
		/// </summary>
		public string emp_name
		{
			set{ _emp_name=value;}
			get{return _emp_name;}
		}
		/// <summary>
		/// 制单人工号
		/// </summary>
		public string emp_code
		{
			set{ _emp_code=value;}
			get{return _emp_code;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string audit_name
		{
			set{ _audit_name=value;}
			get{return _audit_name;}
		}
		/// <summary>
		/// 审核人工号
		/// </summary>
		public string audit_code
		{
			set{ _audit_code=value;}
			get{return _audit_code;}
		}
		/// <summary>
		/// 发票总金额
		/// </summary>
		public decimal? total_money
		{
			set{ _total_money=value;}
			get{return _total_money;}
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
		/// 税未金额
		/// </summary>
		public decimal? ntax_money
		{
			set{ _ntax_money=value;}
			get{return _ntax_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 发票状态：0.新增发票，1.已审核发票
		/// </summary>
		public int? inv_status
		{
			set{ _inv_status=value;}
			get{return _inv_status;}
		}
		/// <summary>
		/// 推送erp、金蝶标志：0.未推送，1.已推送
		/// </summary>
		public int? push_erp
		{
			set{ _push_erp=value;}
			get{return _push_erp;}
		}
		/// <summary>
		/// 删除标志：1.已删除，0.未删除
		/// </summary>
		public int? is_del
		{
			set{ _is_del=value;}
			get{return _is_del;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? red_rush
		{
			set{ _red_rush=value;}
			get{return _red_rush;}
		}
		#endregion Model

	}
}

