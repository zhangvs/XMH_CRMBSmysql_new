/**  版本信息模板在安装目录下，可自行修改。
* crm_shop_askprice.cs
*
* 功 能： N/A
* 类 名： crm_shop_askprice
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 15:54:01   N/A    初版
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
	/// crm_shop_askprice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class crm_shop_askprice
	{
		public crm_shop_askprice()
		{}
		#region Model
		private int _id;
		private string _askprice_content;
		private int? _user_id;
		private string _user_uid;
		private string _user_name;
		private DateTime? _user_askprice_date;
		private int? _beseats_id;
		private string _beseats_empcode;
		private string _beseats;
		private int? _ishandle=0;
		private string _handle_remark;
		private int? _handle_person_id;
		private string _handle_person_name;
		private DateTime? _handle_date;
		/// <summary>
		/// 询价表自增ID
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 客户询价内容
		/// </summary>
		public string askprice_content
		{
			set{ _askprice_content=value;}
			get{return _askprice_content;}
		}
		/// <summary>
		/// 客户自增ID
		/// </summary>
		public int? user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 客户登录帐号
		/// </summary>
		public string user_uid
		{
			set{ _user_uid=value;}
			get{return _user_uid;}
		}
		/// <summary>
		/// 客户姓名
		/// </summary>
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 客户询价提交时间
		/// </summary>
		public DateTime? user_askprice_date
		{
			set{ _user_askprice_date=value;}
			get{return _user_askprice_date;}
		}
		/// <summary>
		/// 客户所属座席工员的自增ID
		/// </summary>
		public int? BeSeats_id
		{
			set{ _beseats_id=value;}
			get{return _beseats_id;}
		}
		/// <summary>
		/// 客户所属座席员工的工号
		/// </summary>
		public string BeSeats_empcode
		{
			set{ _beseats_empcode=value;}
			get{return _beseats_empcode;}
		}
		/// <summary>
		/// 客户所属座席工员的姓名
		/// </summary>
		public string BeSeats
		{
			set{ _beseats=value;}
			get{return _beseats;}
		}
		/// <summary>
		/// 是否处理0未处理，1已处理
		/// </summary>
		public int? ishandle
		{
			set{ _ishandle=value;}
			get{return _ishandle;}
		}
		/// <summary>
		/// 处理备注
		/// </summary>
		public string handle_remark
		{
			set{ _handle_remark=value;}
			get{return _handle_remark;}
		}
		/// <summary>
		/// 处理人id
		/// </summary>
		public int? handle_person_id
		{
			set{ _handle_person_id=value;}
			get{return _handle_person_id;}
		}
		/// <summary>
		/// 处理人姓名
		/// </summary>
		public string handle_person_name
		{
			set{ _handle_person_name=value;}
			get{return _handle_person_name;}
		}
		/// <summary>
		/// 处理时间
		/// </summary>
		public DateTime? handle_date
		{
			set{ _handle_date=value;}
			get{return _handle_date;}
		}
		#endregion Model

	}
}

