using System;
namespace XHD.Model
{
	/// <summary>
	/// crm_oa_boardrecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class crm_oa_boardrecord
	{
		public crm_oa_boardrecord()
		{}
		#region Model
		private int _id;
		private string _factory_id;
		private int? _boardroom_id;
		private string _boardroom_name;
		private DateTime? _start_time;
		private DateTime? _end_time;
		private string _status;
		private string _theme;
		private int? _create_id;
		private string _create_name;
		private DateTime? _create_date;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string factory_Id
		{
			set{ _factory_id=value;}
			get{return _factory_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? boardroom_id
		{
			set{ _boardroom_id=value;}
			get{return _boardroom_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string boardroom_name
		{
			set{ _boardroom_name=value;}
			get{return _boardroom_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? start_time
		{
			set{ _start_time=value;}
			get{return _start_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? end_time
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string theme
		{
			set{ _theme=value;}
			get{return _theme;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? create_id
		{
			set{ _create_id=value;}
			get{return _create_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string create_name
		{
			set{ _create_name=value;}
			get{return _create_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? create_date
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		#endregion Model

	}
}

