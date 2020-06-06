using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
	/// <summary>
	/// Sys_data_authority
	/// </summary>
	public partial class Sys_data_authority
	{
		private readonly XHD.DAL.Sys_data_authority dal=new XHD.DAL.Sys_data_authority();
		public Sys_data_authority()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(XHD.Model.Sys_data_authority model)
		{
			dal.Add(model);
		}

	

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string where)
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete(where);
		}

        /// <summary> 
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet authList(string strWhere)
        {
            return dal.authList(strWhere);
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
	

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		

		#endregion  Method
	}
}

