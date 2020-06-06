using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_BLL
{
	/// <summary>
	/// wms_voucher
	/// </summary>
	public partial class wms_voucher
	{
		private readonly FMS_DAL.wms_voucher dal=new FMS_DAL.wms_voucher();
		public wms_voucher()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long voucher_id)
		{
			return dal.Exists(voucher_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FMS_Model.wms_voucher model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(FMS_Model.wms_voucher model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long voucher_id)
		{
			
			return dal.Delete(voucher_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string voucher_idlist )
		{
			return dal.DeleteList(voucher_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public FMS_Model.wms_voucher GetModel(long voucher_id)
		{
			
			return dal.GetModel(voucher_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public FMS_Model.wms_voucher GetModelByCache(long voucher_id)
		{
			
			string CacheKey = "wms_voucherModel-" + voucher_id;
			object objModel = XHD.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(voucher_id);
					if (objModel != null)
					{
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (FMS_Model.wms_voucher)objModel;
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
		public List<FMS_Model.wms_voucher> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<FMS_Model.wms_voucher> DataTableToList(DataTable dt)
		{
			List<FMS_Model.wms_voucher> modelList = new List<FMS_Model.wms_voucher>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				FMS_Model.wms_voucher model;
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
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
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

