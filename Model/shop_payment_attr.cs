/**  版本信息模板在安装目录下，可自行修改。
* shop_payment_attr.cs
*
* 功 能： N/A
* 类 名： shop_payment_attr
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/20 14:04:47   N/A    初版
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
	/// shop_payment_attr:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shop_payment_attr
	{
		public shop_payment_attr()
		{}
		#region Model
		private int _attr_id;
		private int? _pay_id;
		private string _attr_key;
		private string _attr_values;
		private string _input_type;
		/// <summary>
		/// 主键标识
		/// </summary>
		public int attr_id
		{
			set{ _attr_id=value;}
			get{return _attr_id;}
		}
		/// <summary>
		/// 支付编码
		/// </summary>
		public int? pay_id
		{
			set{ _pay_id=value;}
			get{return _pay_id;}
		}
		/// <summary>
		/// 属性KEY
		/// </summary>
		public string attr_key
		{
			set{ _attr_key=value;}
			get{return _attr_key;}
		}
		/// <summary>
		/// 属性值
		/// </summary>
		public string attr_values
		{
			set{ _attr_values=value;}
			get{return _attr_values;}
		}
		/// <summary>
		/// 值的输入类型，如（text，radio，selection）
		/// </summary>
		public string input_type
		{
			set{ _input_type=value;}
			get{return _input_type;}
		}
		#endregion Model

	}
}

