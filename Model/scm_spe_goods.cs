/**  版本信息模板在安装目录下，可自行修改。
* scm_spe_goods.cs
*
* 功 能： N/A
* 类 名： scm_spe_goods
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/26 10:17:47   N/A    初版
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
	/// scm_spe_goods:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class scm_spe_goods
	{
		public scm_spe_goods()
		{}
		#region Model
		private int _id;
		private int? _spe_order_id;
		private int? _order_goodsid;
		private string _order_goodssn;
		private int? _goods_num;
		private decimal? _goods_price;
		private int? _split_num;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// scm_soe_order的主键
		/// </summary>
		public int? spe_order_id
		{
			set{ _spe_order_id=value;}
			get{return _spe_order_id;}
		}
		/// <summary>
		/// 产品id
		/// </summary>
		public int? order_goodsid
		{
			set{ _order_goodsid=value;}
			get{return _order_goodsid;}
		}
		/// <summary>
		/// 产品sn
		/// </summary>
		public string order_goodssn
		{
			set{ _order_goodssn=value;}
			get{return _order_goodssn;}
		}
		/// <summary>
		/// 商品数量
		/// </summary>
        public int? goods_num
		{
			set{ _goods_num=value;}
			get{return _goods_num;}
		}
		/// <summary>
		/// 商品单价
		/// </summary>
        public decimal? goods_price
		{
			set{ _goods_price=value;}
			get{return _goods_price;}
		}
		/// <summary>
		/// 产品已分配数量
		/// </summary>
		public int? split_num
		{
			set{ _split_num=value;}
			get{return _split_num;}
		}
		#endregion Model

	}
}

