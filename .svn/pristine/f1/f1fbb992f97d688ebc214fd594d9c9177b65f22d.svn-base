using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
	/// <summary>
	/// crm_oa_boardrecord
	/// </summary>
	public partial class crm_oa_boardrecord
	{
        private readonly XHD.DAL.crm_oa_boardrecord dal = new XHD.DAL.crm_oa_boardrecord();
		public crm_oa_boardrecord()
		{}
		#region  Method

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
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}
        public bool excite(DateTime start, DateTime end,int id) {
            return dal.excite(start, end,id);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(XHD.Model.crm_oa_boardrecord model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(XHD.Model.crm_oa_boardrecord model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
        public bool Delete1(int Id)
        {

            return dal.Delete1(Id);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public XHD.Model.crm_oa_boardrecord GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public XHD.Model.crm_oa_boardrecord GetModelByCache(int Id)
		{
			
			string CacheKey = "crm_oa_boardrecordModel-" + Id;
			object objModel = XHD.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Id);
					if (objModel != null)
					{
						int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
						XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (XHD.Model.crm_oa_boardrecord)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<XHD.Model.crm_oa_boardrecord> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<XHD.Model.crm_oa_boardrecord> DataTableToList(DataTable dt)
		{
			List<XHD.Model.crm_oa_boardrecord> modelList = new List<XHD.Model.crm_oa_boardrecord>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				XHD.Model.crm_oa_boardrecord model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new XHD.Model.crm_oa_boardrecord();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["factory_Id"]!=null && dt.Rows[n]["factory_Id"].ToString()!="")
					{
					model.factory_Id=dt.Rows[n]["factory_Id"].ToString();
					}
					if(dt.Rows[n]["boardroom_id"]!=null && dt.Rows[n]["boardroom_id"].ToString()!="")
					{
						model.boardroom_id=int.Parse(dt.Rows[n]["boardroom_id"].ToString());
					}
					if(dt.Rows[n]["boardroom_name"]!=null && dt.Rows[n]["boardroom_name"].ToString()!="")
					{
					model.boardroom_name=dt.Rows[n]["boardroom_name"].ToString();
					}
					if(dt.Rows[n]["start_time"]!=null && dt.Rows[n]["start_time"].ToString()!="")
					{
						model.start_time=DateTime.Parse(dt.Rows[n]["start_time"].ToString());
					}
					if(dt.Rows[n]["end_time"]!=null && dt.Rows[n]["end_time"].ToString()!="")
					{
						model.end_time=DateTime.Parse(dt.Rows[n]["end_time"].ToString());
					}
					if(dt.Rows[n]["status"]!=null && dt.Rows[n]["status"].ToString()!="")
					{
					model.status=dt.Rows[n]["status"].ToString();
					}
					if(dt.Rows[n]["theme"]!=null && dt.Rows[n]["theme"].ToString()!="")
					{
					model.theme=dt.Rows[n]["theme"].ToString();
					}
					if(dt.Rows[n]["create_id"]!=null && dt.Rows[n]["create_id"].ToString()!="")
					{
						model.create_id=int.Parse(dt.Rows[n]["create_id"].ToString());
					}
					if(dt.Rows[n]["create_name"]!=null && dt.Rows[n]["create_name"].ToString()!="")
					{
					model.create_name=dt.Rows[n]["create_name"].ToString();
					}
					if(dt.Rows[n]["create_date"]!=null && dt.Rows[n]["create_date"].ToString()!="")
					{
						model.create_date=DateTime.Parse(dt.Rows[n]["create_date"].ToString());
					}
					modelList.Add(model);
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
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

