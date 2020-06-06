using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace FMS_Model
{
	/// <summary>
	/// wms_payment_log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class wms_payment_log
	{
		public wms_payment_log()
		{}
		#region Model
		private long _id;
		private long _pay_id;
		private string _pay_sn;
		private string _emp_code;
		private string _emp_name;
		private string _log_info;
		private DateTime? _log_time;
		/// <summary>
		/// 主键自增
		/// </summary>
		public long id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 付款单id
		/// </summary>
		public long pay_id
		{
			set{ _pay_id=value;}
			get{return _pay_id;}
		}
		/// <summary>
		/// 付款单编号
		/// </summary>
		public string pay_sn
		{
			set{ _pay_sn=value;}
			get{return _pay_sn;}
		}
		/// <summary>
		/// 操作人工号
		/// </summary>
		public string emp_code
		{
			set{ _emp_code=value;}
			get{return _emp_code;}
		}
		/// <summary>
		/// 操作人姓名
		/// </summary>
		public string emp_name
		{
			set{ _emp_name=value;}
			get{return _emp_name;}
		}
		/// <summary>
		/// 日志信息
		/// </summary>
		public string log_info
		{
			set{ _log_info=value;}
			get{return _log_info;}
		}
		/// <summary>
		/// 日志时间
		/// </summary>
		public DateTime? log_time
		{
			set{ _log_time=value;}
			get{return _log_time;}
		}
		#endregion Model

	}
}

