using System;
namespace QA.Model
{
	/// <summary>
	/// qa_question:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class qa_question
	{
		public qa_question()
		{}
		#region Model
		private int _id;
		private DateTime? _question_time;
		private string _content;
		private int? _grade;
		private int? _detail_type=0;
		private int? _read_status=0;
		private int? _handle_status=0;
		private int? _question_id;
		private string _question_name;
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
		public DateTime? question_time
		{
			set{ _question_time=value;}
			get{return _question_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? grade
		{
			set{ _grade=value;}
			get{return _grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? detail_type
		{
			set{ _detail_type=value;}
			get{return _detail_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? read_status
		{
			set{ _read_status=value;}
			get{return _read_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? handle_status
		{
			set{ _handle_status=value;}
			get{return _handle_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? question_id
		{
			set{ _question_id=value;}
			get{return _question_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string question_name
		{
			set{ _question_name=value;}
			get{return _question_name;}
		}
		#endregion Model

	}
}

