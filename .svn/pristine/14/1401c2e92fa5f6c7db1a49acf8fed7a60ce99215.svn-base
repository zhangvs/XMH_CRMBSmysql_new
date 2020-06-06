using System;

namespace FMS_Model
{
    /// <summary>
	/// fms_costitem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class fms_costitem
	{
		public fms_costitem()
		{}

		#region Model
		private int _id;
		private string _factory_id;
		private string _code;
		private string _title;
		private string _creater;
		private DateTime? _createtime;
        public string parent_code { get; set; }
        public int item_order { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 所属经营者
		/// </summary>
		public string Factory_Id
		{
			set{ _factory_id=value;}
			get{return _factory_id;}
		}
		/// <summary>
		/// 编码
        ///规则：6位 101000 前3位代表父后3位代表子
        ///如101000  101001  101002  101003
        ///102000  102001  102002
        ///插父项目时  截取前3位加1，子项同上
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 工号
		/// </summary>
		public string creater
		{
			set{ _creater=value;}
			get{return _creater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

