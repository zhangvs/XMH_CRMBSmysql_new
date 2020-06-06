using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// crm_customer_handnum
    /// </summary>
    public partial class crm_customer_handnum
    {
        private readonly XHD.DAL.crm_customer_handnum dal = new XHD.DAL.crm_customer_handnum();
        public crm_customer_handnum()
        { }
        #region  BasicMethod
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
        public bool Add(XHD.Model.crm_customer_handnum model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Insert(XHD.Model.crm_customer_handnum modelhandnum, XHD.Model.CRM_Customer model)
        {
            return dal.Insert(modelhandnum, model);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Adds(XHD.Model.crm_customer_handnum modelhandnum, XHD.Model.CRM_Customer model, XHD.Model.ecs_admin_user adminModel, string c_tel)       
        {
            return dal.Adds(modelhandnum, model,adminModel,c_tel);
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_customer_handnum model)
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
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.crm_customer_handnum GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.crm_customer_handnum GetModelByCache(int id)
        {

            string CacheKey = "crm_customer_handnumModel-" + id;
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
                catch { }
            }
            return (XHD.Model.crm_customer_handnum)objModel;
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
        public DataSet GetLists(string strWhere)
        {
            return dal.GetLists(strWhere);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.crm_customer_handnum> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.crm_customer_handnum> DataTableToList(DataTable dt)
        {
            List<XHD.Model.crm_customer_handnum> modelList = new List<XHD.Model.crm_customer_handnum>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.crm_customer_handnum model;
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
        public DataSet GetListByCusId(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListByCusId(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

