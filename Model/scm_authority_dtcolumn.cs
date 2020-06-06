using System;


namespace XHD.Model
{
	/// <summary>
	/// scm_authority_dtcolumn:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class scm_authority_dtcolumn
	{
		public scm_authority_dtcolumn()
		{}
		#region Model
		private string _factory_id;
		private int? _suppliers_id;
		private string _menu_ids;
		private string _column_ids;
		private int? _create_id;
		private DateTime? _create_date;
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
		public int? suppliers_id
		{
			set{ _suppliers_id=value;}
			get{return _suppliers_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Menu_ids
		{
			set{ _menu_ids=value;}
			get{return _menu_ids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string column_ids
		{
			set{ _column_ids=value;}
			get{return _column_ids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Create_id
		{
			set{ _create_id=value;}
			get{return _create_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Create_date
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		#endregion Model

	}
}



