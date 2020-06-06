using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
	/// <summary>
	/// crm_oa_boardroom
	/// </summary>
	public partial class crm_oa_boardroom
	{
        private readonly XHD.DAL.crm_oa_boardroom dal = new XHD.DAL.crm_oa_boardroom();
		public crm_oa_boardroom()
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

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(XHD.Model.crm_oa_boardroom model)
		{
			int i= dal.Add(model);
            return i;
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(XHD.Model.crm_oa_boardroom model)
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
        public XHD.Model.crm_oa_boardroom GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        public XHD.Model.crm_oa_boardroom GetModelByCache(int Id)
		{
			
			string CacheKey = "crm_oa_boardroomModel-" + Id;
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
            return (XHD.Model.crm_oa_boardroom)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total) {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder,out Total);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public List<XHD.Model.crm_oa_boardroom> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public List<XHD.Model.crm_oa_boardroom> DataTableToList(DataTable dt)
		{
            List<XHD.Model.crm_oa_boardroom> modelList = new List<XHD.Model.crm_oa_boardroom>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
                XHD.Model.crm_oa_boardroom model;
				for (int n = 0; n < rowsCount; n++)
				{
                    model = new XHD.Model.crm_oa_boardroom();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["factory_Id"]!=null && dt.Rows[n]["factory_Id"].ToString()!="")
					{
					model.factory_Id=dt.Rows[n]["factory_Id"].ToString();
					}
					if(dt.Rows[n]["room_name"]!=null && dt.Rows[n]["room_name"].ToString()!="")
					{
					model.room_name=dt.Rows[n]["room_name"].ToString();
					}
					if(dt.Rows[n]["N_room_seat"]!=null && dt.Rows[n]["N_room_seat"].ToString()!="")
					{
						model.N_room_seat=int.Parse(dt.Rows[n]["N_room_seat"].ToString());
					}
					if(dt.Rows[n]["N_projector"]!=null && dt.Rows[n]["N_projector"].ToString()!="")
					{
						model.N_projector=int.Parse(dt.Rows[n]["N_projector"].ToString());
					}
					if(dt.Rows[n]["N_whiteboard"]!=null && dt.Rows[n]["N_whiteboard"].ToString()!="")
					{
						model.N_whiteboard=int.Parse(dt.Rows[n]["N_whiteboard"].ToString());
					}
					if(dt.Rows[n]["C_room_manageId"]!=null && dt.Rows[n]["C_room_manageId"].ToString()!="")
					{
						model.C_room_manageId=int.Parse(dt.Rows[n]["C_room_manageId"].ToString());
					}
					if(dt.Rows[n]["C_room_manageName"]!=null && dt.Rows[n]["C_room_manageName"].ToString()!="")
					{
					model.C_room_manageName=dt.Rows[n]["C_room_manageName"].ToString();
					}
					if(dt.Rows[n]["C_createId"]!=null && dt.Rows[n]["C_createId"].ToString()!="")
					{
						model.C_createId=int.Parse(dt.Rows[n]["C_createId"].ToString());
					}
					if(dt.Rows[n]["C_createName"]!=null && dt.Rows[n]["C_createName"].ToString()!="")
					{
					model.C_createName=dt.Rows[n]["C_createName"].ToString();
					}
					if(dt.Rows[n]["C_createDate"]!=null && dt.Rows[n]["C_createDate"].ToString()!="")
					{
						model.C_createDate=DateTime.Parse(dt.Rows[n]["C_createDate"].ToString());
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

