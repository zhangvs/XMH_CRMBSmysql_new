/**  版本信息模板在安装目录下，可自行修改。
* crm_contact_bill.cs
*
* 功 能： N/A
* 类 名： crm_contact_bill
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/1/10 15:18:52   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
	/// <summary>
	/// crm_contact_bill
	/// </summary>
	public partial class crm_contact_bill
	{
		private readonly XHD.DAL.crm_contact_bill dal=new XHD.DAL.crm_contact_bill();
		public crm_contact_bill()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.crm_contact_bill model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(XHD.Model.crm_contact_bill model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public XHD.Model.crm_contact_bill GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public XHD.Model.crm_contact_bill GetModelByCache(int id)
		{
			
			string CacheKey = "crm_contact_billModel-" + id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (XHD.Model.crm_contact_bill)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetOneList(string strWhere)
        {
            return dal.GetOneList(strWhere);
        }


		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<XHD.Model.crm_contact_bill> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<XHD.Model.crm_contact_bill> DataTableToList(DataTable dt)
		{
			List<XHD.Model.crm_contact_bill> modelList = new List<XHD.Model.crm_contact_bill>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				XHD.Model.crm_contact_bill model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

        /// <summary>
        /// 加载客户开票资料不唯一数据
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere,string strWhereOne, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, strWhereOne,filedOrder, out Total);
        }


        /// <summary>
        /// 由客户id查客户开票信息
        /// </summary>
        public DataSet GetBillList(int PageSize, int PageIndex, string strWhere,string filedOrder, out string Total)
        {
            return dal.GetBillList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

