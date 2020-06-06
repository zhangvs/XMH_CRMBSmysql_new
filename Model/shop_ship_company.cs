/**  版本信息模板在安装目录下，可自行修改。
* shop_ship_company.cs
*
* 功 能： N/A
* 类 名： shop_ship_company
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/20 12:03:43   N/A    初版
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
	/// shop_ship_company:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shop_ship_company
	{
		public shop_ship_company()
		{}
		#region Model
		private int _comp_id;
		private string _comp_name;
		private int? _comp_type;
		private string _comp_code;
		private string _comp_tel;
		private string _comp_address;
		private string _comp_desc;
		private int? _is_available;
		private int? _send_pay;
		/// <summary>
		/// 物流公司自增 ID
		/// </summary>
		public int comp_id
		{
			set{ _comp_id=value;}
			get{return _comp_id;}
		}
		/// <summary>
		/// 物流公司名称
		/// </summary>
		public string comp_name
		{
			set{ _comp_name=value;}
			get{return _comp_name;}
		}
		/// <summary>
		/// 物流公司类型
		/// </summary>
		public int? comp_type
		{
			set{ _comp_type=value;}
			get{return _comp_type;}
		}
		/// <summary>
		/// 物流公司代码
		/// </summary>
		public string comp_code
		{
			set{ _comp_code=value;}
			get{return _comp_code;}
		}
		/// <summary>
		/// 物流公司电话
		/// </summary>
		public string comp_tel
		{
			set{ _comp_tel=value;}
			get{return _comp_tel;}
		}
		/// <summary>
		/// 物流公司地址
		/// </summary>
		public string comp_address
		{
			set{ _comp_address=value;}
			get{return _comp_address;}
		}
		/// <summary>
		/// 物流公司描述
		/// </summary>
		public string comp_desc
		{
			set{ _comp_desc=value;}
			get{return _comp_desc;}
		}
		/// <summary>
		/// 是否可用
		/// </summary>
		public int? is_available
		{
			set{ _is_available=value;}
			get{return _is_available;}
		}
		/// <summary>
		/// 是否支持到付
		/// </summary>
		public int? send_pay
		{
			set{ _send_pay=value;}
			get{return _send_pay;}
		}
		#endregion Model

	}
}

