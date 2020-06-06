/**  版本信息模板在安装目录下，可自行修改。
* xlkdb.cs
*
* 功 能： N/A
* 类 名： xlkdb
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/1/16 11:50:13   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace XHD.Model.wms
{
	/// <summary>
	/// xlkdb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class xlkdb
	{
		public xlkdb()
		{}
		#region Model
		private DateTime? _rq;
		private string _bmbm;
		private string _xm;
		private decimal? _je;
		private string _djhm;
		private string _zy;
		private string _bz;
		private string _hw;
		private string _yhw;
		private string _zd;
		private string _jz;
		private decimal? _lsh=0M;
		private string _ysdh= "-";
		private string _lockbz;
		private decimal? _dycs=0.00M;
		private int? _jhdh;
		private string _sh= "-";
		private decimal? _nian;
		private decimal? _yf;
		private string _ywsm= "正常调拨";
		private long _id;
		private string _ddbh;
		private decimal? _ddsl=0.00000000M;
		private string _zzpbm;
		private string _shenji;
		private int? _isinsert=0;
		private int? _has_send=0;
		private DateTime? _send_time;
		private string _check_user;
		private DateTime? _check_date;
		private string _emp_name;
		private bool _isdelete= false;
		private int? _driver_id;
		private string _driver_name;
		private int? _syn_sgz;
		private int? _cancel_sgz;
		private int? _has_sync=0;
		private string _binded_shop_order;
		private int? _scan_status=1;
		private string _kingdee_code;
		private int? _syn_cancel_kingdee;
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RQ
		{
			set{ _rq=value;}
			get{return _rq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BMBM
		{
			set{ _bmbm=value;}
			get{return _bmbm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XM
		{
			set{ _xm=value;}
			get{return _xm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? JE
		{
			set{ _je=value;}
			get{return _je;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DJHM
		{
			set{ _djhm=value;}
			get{return _djhm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZY
		{
			set{ _zy=value;}
			get{return _zy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ
		{
			set{ _bz=value;}
			get{return _bz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HW
		{
			set{ _hw=value;}
			get{return _hw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YHW
		{
			set{ _yhw=value;}
			get{return _yhw;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZD
		{
			set{ _zd=value;}
			get{return _zd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JZ
		{
			set{ _jz=value;}
			get{return _jz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LSH
		{
			set{ _lsh=value;}
			get{return _lsh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YSDH
		{
			set{ _ysdh=value;}
			get{return _ysdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LOCKBZ
		{
			set{ _lockbz=value;}
			get{return _lockbz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DYCS
		{
			set{ _dycs=value;}
			get{return _dycs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? JHDH
		{
			set{ _jhdh=value;}
			get{return _jhdh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SH
		{
			set{ _sh=value;}
			get{return _sh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NIAN
		{
			set{ _nian=value;}
			get{return _nian;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? YF
		{
			set{ _yf=value;}
			get{return _yf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YWSM
		{
			set{ _ywsm=value;}
			get{return _ywsm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DDBH
		{
			set{ _ddbh=value;}
			get{return _ddbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DDSL
		{
			set{ _ddsl=value;}
			get{return _ddsl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZZPBM
		{
			set{ _zzpbm=value;}
			get{return _zzpbm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SHENJI
		{
			set{ _shenji=value;}
			get{return _shenji;}
		}
		/// <summary>
		/// 是否与erp对接成功：0：未对接；1：对接成功
		/// </summary>
		public int? IsInsert
		{
			set{ _isinsert=value;}
			get{return _isinsert;}
		}
		/// <summary>
		/// 调拨单发货状态:0.默认未发货，1.已发货
		/// </summary>
		public int? has_send
		{
			set{ _has_send=value;}
			get{return _has_send;}
		}
		/// <summary>
		/// 发货时间
		/// </summary>
		public DateTime? send_time
		{
			set{ _send_time=value;}
			get{return _send_time;}
		}
		/// <summary>
		/// 审核人
		/// </summary>
		public string check_user
		{
			set{ _check_user=value;}
			get{return _check_user;}
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
		/// 制单人姓名
		/// </summary>
		public string emp_name
		{
			set{ _emp_name=value;}
			get{return _emp_name;}
		}
		/// <summary>
		/// 是否删除（true=已删除）
		/// </summary>
		public bool isdelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		/// <summary>
		/// 发货司机id
		/// </summary>
		public int? driver_id
		{
			set{ _driver_id=value;}
			get{return _driver_id;}
		}
		/// <summary>
		/// 发货司机姓名
		/// </summary>
		public string driver_name
		{
			set{ _driver_name=value;}
			get{return _driver_name;}
		}
		/// <summary>
		/// 同步手工帐 1 未同步 2 已同步
		/// </summary>
		public int? syn_sgz
		{
			set{ _syn_sgz=value;}
			get{return _syn_sgz;}
		}
		/// <summary>
		/// 作废手工帐 1 未作废 2 已作废
		/// </summary>
		public int? cancel_sgz
		{
			set{ _cancel_sgz=value;}
			get{return _cancel_sgz;}
		}
		/// <summary>
		/// 同步状态（默认0未同步，1:已同步）
		/// </summary>
		public int? has_sync
		{
			set{ _has_sync=value;}
			get{return _has_sync;}
		}
		/// <summary>
		/// 绑定的商城单号
		/// </summary>
		public string binded_shop_order
		{
			set{ _binded_shop_order=value;}
			get{return _binded_shop_order;}
		}
		/// <summary>
		/// 配货状态 1 未配货 2 已配货
		/// </summary>
		public int? scan_status
		{
			set{ _scan_status=value;}
			get{return _scan_status;}
		}
		/// <summary>
		/// 金蝶编号
		/// </summary>
		public string kingdee_code
		{
			set{ _kingdee_code=value;}
			get{return _kingdee_code;}
		}
		/// <summary>
		/// 同步作废金蝶内帐 1 未作废 2 已作废
		/// </summary>
		public int? syn_cancel_kingdee
		{
			set{ _syn_cancel_kingdee=value;}
			get{return _syn_cancel_kingdee;}
		}
		#endregion Model

	}
}

