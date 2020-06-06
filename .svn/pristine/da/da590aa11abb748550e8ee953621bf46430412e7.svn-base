/**  版本信息模板在安装目录下，可自行修改。
* shop_member_level.cs
*
* 功 能： N/A
* 类 名： shop_member_level
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/20 11:00:38   N/A    初版
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
	/// shop_member_level:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shop_member_level
	{
		public shop_member_level()
		{}
		#region Model
		private int _level_id;
		private string _level_name;
		private int? _level_external;
		private decimal _level_proportion;
		private int _priority_lag=0;
		private int _level_type=0;
		/// <summary>
		/// 
		/// </summary>
		public int level_id
		{
			set{ _level_id=value;}
			get{return _level_id;}
		}
		/// <summary>
		/// 等级名称
		/// </summary>
		public string level_name
		{
			set{ _level_name=value;}
			get{return _level_name;}
		}
		/// <summary>
		/// 对应的外部会员等级标识
		/// </summary>
		public int? level_external
		{
			set{ _level_external=value;}
			get{return _level_external;}
		}
		/// <summary>
		/// 会员等级价格比例
		/// </summary>
		public decimal level_proportion
		{
			set{ _level_proportion=value;}
			get{return _level_proportion;}
		}
		/// <summary>
		/// 计算优先级（先商品折扣还是先品牌折扣）
		/// </summary>
		public int priority_lag
		{
			set{ _priority_lag=value;}
			get{return _priority_lag;}
		}
		/// <summary>
		/// 会员类型0个人会员、1企业会员
		/// </summary>
		public int level_type
		{
			set{ _level_type=value;}
			get{return _level_type;}
		}
		#endregion Model

	}
}

