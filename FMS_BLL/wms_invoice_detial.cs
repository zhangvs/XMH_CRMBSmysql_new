﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_BLL
{
    /// <summary>
	/// wms_invoice_detial
	/// </summary>
	public partial class wms_invoice_detial
	{
		private readonly FMS_DAL.wms_invoice_detial dal=new FMS_DAL.wms_invoice_detial();
		public wms_invoice_detial()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FMS_Model.wms_invoice_detial model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(FMS_Model.wms_invoice_detial model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long id)
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
		public FMS_Model.wms_invoice_detial GetModel(long id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public FMS_Model.wms_invoice_detial GetModelByCache(long id)
		{
			
			string CacheKey = "wms_invoice_detialModel-" + id;
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
			return (FMS_Model.wms_invoice_detial)objModel;
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
		public List<FMS_Model.wms_invoice_detial> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<FMS_Model.wms_invoice_detial> DataTableToList(DataTable dt)
		{
			List<FMS_Model.wms_invoice_detial> modelList = new List<FMS_Model.wms_invoice_detial>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				FMS_Model.wms_invoice_detial model;
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
        /// model_list获取数据集
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<FMS_Model.wms_invoice_detial> NewGetList(string strWhere)
        {
            return dal.NewGetList(strWhere);
        }

        ///// <summary>
        ///// 分页获取数据列表
        ///// </summary>
        //public int GetRecordCount(string strWhere)
        //{
        //    return dal.GetRecordCount(strWhere);
        //}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
