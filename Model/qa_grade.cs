using System;
namespace QA.Model
{
	/// <summary>
	/// qa_grade:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class qa_grade
	{
		public qa_grade()
		{}
		#region Model
		private int _id;
		private string _name;
		private double? _hours;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? hours
		{
			set{ _hours=value;}
			get{return _hours;}
		}
		#endregion Model

	}
}

