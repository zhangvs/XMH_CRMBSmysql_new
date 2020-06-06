/**  版本信息模板在安装目录下，可自行修改。
* hr_group_info.cs
*
* 功 能： N/A
* 类 名： hr_group_info
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/30 16:11:12   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace XHD.Model
{
	/// <summary>
	/// hr_group_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hr_group_info
	{
		public hr_group_info()
		{}
		#region Model
		private int _id;
		private string _group_code;
		private string _group_name;
		private DateTime? _group_creatdate;
		private string _group_userid;
		private string _gropu_address;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 编号
		/// </summary>
		public string Group_Code
		{
			set{ _group_code=value;}
			get{return _group_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Group_Name
		{
			set{ _group_name=value;}
			get{return _group_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Group_CreatDate
		{
			set{ _group_creatdate=value;}
			get{return _group_creatdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Group_UserId
		{
			set{ _group_userid=value;}
			get{return _group_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Gropu_Address
		{
			set{ _gropu_address=value;}
			get{return _gropu_address;}
		}
		#endregion Model

	}
}

