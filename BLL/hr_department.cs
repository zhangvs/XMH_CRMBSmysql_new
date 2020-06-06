using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
	/// <summary>
	/// hr_department
	/// </summary>
	public partial class hr_department
	{
		private readonly XHD.DAL.hr_department dal=new XHD.DAL.hr_department();
		public hr_department()
		{}
		#region  Method

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}
        /// <summary>
        /// ��������б����� 
        /// </summary>
        public DataSet GetOptionList(string sql)
        {
            return dal.GetOptionList(sql);
        }

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(XHD.Model.hr_department model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(XHD.Model.hr_department model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// Ԥɾ��
		/// </summary>
		/// <param name="id"></param>
		/// <param name="isDelete"></param>
		/// <param name="time"></param>
		/// <returns></returns>
		public bool AdvanceDelete(int id, int isDelete, string time)
		{
			return dal.AdvanceDelete(id, isDelete, time);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public XHD.Model.hr_department GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public XHD.Model.hr_department GetModelByCache(int id)
		{
			
			string CacheKey = "hr_departmentModel-" + id;
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
			return (XHD.Model.hr_department)objModel;
		}

        /// <summary>
        /// ��������б�  ָ���ֶ�
        /// </summary>
        public DataSet GetOptionLists(string factory_Id)
        {
            return dal.GetOptionLists(factory_Id);
        }

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetLists(string strWhere)
        {
            return dal.GetLists(strWhere);
        }

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<XHD.Model.hr_department> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<XHD.Model.hr_department> DataTableToList(DataTable dt)
		{
			List<XHD.Model.hr_department> modelList = new List<XHD.Model.hr_department>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				XHD.Model.hr_department model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new XHD.Model.hr_department();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["d_name"]!=null && dt.Rows[n]["d_name"].ToString()!="")
					{
					model.d_name=dt.Rows[n]["d_name"].ToString();
					}
					if(dt.Rows[n]["parentid"]!=null && dt.Rows[n]["parentid"].ToString()!="")
					{
						model.parentid=int.Parse(dt.Rows[n]["parentid"].ToString());
					}
					if(dt.Rows[n]["parentname"]!=null && dt.Rows[n]["parentname"].ToString()!="")
					{
					model.parentname=dt.Rows[n]["parentname"].ToString();
					}
					if(dt.Rows[n]["d_type"]!=null && dt.Rows[n]["d_type"].ToString()!="")
					{
					model.d_type=dt.Rows[n]["d_type"].ToString();
					}
					if(dt.Rows[n]["d_icon"]!=null && dt.Rows[n]["d_icon"].ToString()!="")
					{
					model.d_icon=dt.Rows[n]["d_icon"].ToString();
					}
					if(dt.Rows[n]["d_fuzeren"]!=null && dt.Rows[n]["d_fuzeren"].ToString()!="")
					{
					model.d_fuzeren=dt.Rows[n]["d_fuzeren"].ToString();
					}
                    if (dt.Rows[n]["d_fuzeren_Id"] != null && dt.Rows[n]["d_fuzeren_Id"].ToString() != "")
                    {
                        model.d_fuzeren_Id = int.Parse(dt.Rows[n]["d_fuzeren_Id"].ToString());
                    }
					if(dt.Rows[n]["d_tel"]!=null && dt.Rows[n]["d_tel"].ToString()!="")
					{
					model.d_tel=dt.Rows[n]["d_tel"].ToString();
					}
					if(dt.Rows[n]["d_fax"]!=null && dt.Rows[n]["d_fax"].ToString()!="")
					{
					model.d_fax=dt.Rows[n]["d_fax"].ToString();
					}
					if(dt.Rows[n]["d_add"]!=null && dt.Rows[n]["d_add"].ToString()!="")
					{
					model.d_add=dt.Rows[n]["d_add"].ToString();
					}
					if(dt.Rows[n]["d_email"]!=null && dt.Rows[n]["d_email"].ToString()!="")
					{
					model.d_email=dt.Rows[n]["d_email"].ToString();
					}
					if(dt.Rows[n]["d_miaoshu"]!=null && dt.Rows[n]["d_miaoshu"].ToString()!="")
					{
					model.d_miaoshu=dt.Rows[n]["d_miaoshu"].ToString();
					}
					if(dt.Rows[n]["d_order"]!=null && dt.Rows[n]["d_order"].ToString()!="")
					{
					model.d_order= int.Parse( dt.Rows[n]["d_order"].ToString());
					}
					if(dt.Rows[n]["isDelete"]!=null && dt.Rows[n]["isDelete"].ToString()!="")
					{
						model.isDelete=int.Parse(dt.Rows[n]["isDelete"].ToString());
					}
					if(dt.Rows[n]["Delete_time"]!=null && dt.Rows[n]["Delete_time"].ToString()!="")
					{
						model.Delete_time=DateTime.Parse(dt.Rows[n]["Delete_time"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
        public DataSet GetAllList(string strWhere)
		{
            return GetList(strWhere);
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
		{
			return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
		}

		#endregion  Method
	}
}

