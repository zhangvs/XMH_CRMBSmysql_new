using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// ecs_brand_checkService
    /// </summary>
    public partial class ecs_brand_checkService
    {
        private readonly XHD.DAL.ecs_brand_checkDAO dal = new XHD.DAL.ecs_brand_checkDAO();
        public ecs_brand_checkService()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bc_id)
        {
            return dal.Exists(bc_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_brand_check model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ecs_brand_check model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int bc_id)
        {

            return dal.Delete(bc_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string bc_idlist)
        {
            return dal.DeleteList(bc_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ecs_brand_check GetModel(int bc_id)
        {

            return dal.GetModel(bc_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.ecs_brand_check GetModelByCache(int bc_id)
        {

            string CacheKey = "ecs_brand_checkModel-" + bc_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(bc_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.ecs_brand_check)objModel;
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
        public List<XHD.Model.ecs_brand_check> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ecs_brand_check> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ecs_brand_check> modelList = new List<XHD.Model.ecs_brand_check>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ecs_brand_check model;
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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
        /// <summary>
        /// 获得数据列表根据指定的字段哪个月份
        /// </summary>
        public DataSet GetPlanBaseList(string monthColumms, string strWhere)
        {
            return dal.GetPlanBaseList(monthColumms, strWhere);
        }

        /// <summary>
        /// 获得数据列表根据指定的字段哪个月份
        /// </summary>
        public DataSet GetYearPlanBaseList(string strWhere)
        {
            return dal.GetYearPlanBaseList(strWhere);
        }

        /// <summary>
        /// 获得数据列表根据指定的字段哪个月份,部门
        /// </summary>
        public DataSet GetPlanBaseList_Manager(string monthColumms, string strWhere)
        {
            return dal.GetPlanBaseList_Manager(monthColumms, strWhere);
        }

        /// <summary>
        /// 获得数据列表根据指定的字段哪个月份,部门
        /// </summary>
        public DataSet GetYearPlanBaseList_Manager(string strWhere)
        {
            return dal.GetYearPlanBaseList_Manager(strWhere);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update2(XHD.Model.ecs_brand_check model)
        {
            return dal.Update2(model);
        }
        #endregion  ExtensionMethod
    }
}

