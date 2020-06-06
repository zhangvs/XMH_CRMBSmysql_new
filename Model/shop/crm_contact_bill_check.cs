/**  版本信息模板在安装目录下，可自行修改。
* crm_contact_bill_check.cs
*
* 功 能： N/A
* 类 名： crm_contact_bill_check
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/1/19 16:28:24   N/A    初版
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
	/// crm_contact_bill_check:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class crm_contact_bill_check
	{
		public crm_contact_bill_check()
		{}
		#region Model
		private int _id;
		private string _tax_code;
		private string _new_tax_code;
		private string _id_list;
		private string _check_id;
		private string _check_code;
		private string _check_name;
		private DateTime? _check_date;
		private int? _sub_id;
		private string _sub_code;
		private string _sub_name;
		private DateTime? _sub_date;
		private int? _status=0;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 税号
		/// </summary>
		public string tax_code
		{
			set{ _tax_code=value;}
			get{return _tax_code;}
		}
		/// <summary>
		/// 新税号
		/// </summary>
		public string new_tax_code
		{
			set{ _new_tax_code=value;}
			get{return _new_tax_code;}
		}
		/// <summary>
		/// 税号相同的id字符串 以 ，号分隔
		/// </summary>
		public string id_list
		{
			set{ _id_list=value;}
			get{return _id_list;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string check_id
		{
			set{ _check_id=value;}
			get{return _check_id;}
		}
		/// <summary>
		/// 审核人工号
		/// </summary>
		public string check_code
		{
			set{ _check_code=value;}
			get{return _check_code;}
		}
		/// <summary>
		/// 审核者姓名
		/// </summary>
		public string check_name
		{
			set{ _check_name=value;}
			get{return _check_name;}
		}
		/// <summary>
		/// 审核日期
		/// </summary>
		public DateTime? check_date
		{
			set{ _check_date=value;}
			get{return _check_date;}
		}
		/// <summary>
		/// 提交人
		/// </summary>
		public int? sub_id
		{
			set{ _sub_id=value;}
			get{return _sub_id;}
		}
		/// <summary>
		/// 提交者工号
		/// </summary>
		public string sub_code
		{
			set{ _sub_code=value;}
			get{return _sub_code;}
		}
		/// <summary>
		/// 提交者姓名
		/// </summary>
		public string sub_name
		{
			set{ _sub_name=value;}
			get{return _sub_name;}
		}
		/// <summary>
		/// 提交时间
		/// </summary>
		public DateTime? sub_date
		{
			set{ _sub_date=value;}
			get{return _sub_date;}
		}
		/// <summary>
		/// 审批状态，0未审核1通过2不通过
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

