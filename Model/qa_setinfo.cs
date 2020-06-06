using System;
namespace QA.Model
{
	/// <summary>
	/// qa_setinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class qa_setinfo
	{
		public qa_setinfo()
		{}
		#region Model
		private int _id;
		private string _factory_id;
		private int? _emp_id;
		private string _emp_name;
		private string _tel;
		private string _email;
		private int? _receiving_time;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string factory_id
		{
			set{ _factory_id=value;}
			get{return _factory_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? emp_id
		{
			set{ _emp_id=value;}
			get{return _emp_id;}
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
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? receiving_time
		{
			set{ _receiving_time=value;}
			get{return _receiving_time;}
		}
		#endregion Model

	}
}

