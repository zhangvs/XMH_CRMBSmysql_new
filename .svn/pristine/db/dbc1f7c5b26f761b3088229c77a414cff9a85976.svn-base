using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// crm_customer_dailyplanService
    /// </summary>
    public partial class crm_customer_dailyplanService
    {
        private readonly XHD.DAL.crm_customer_dailyplanDAO dal = new XHD.DAL.crm_customer_dailyplanDAO();
        public crm_customer_dailyplanService()
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
        public bool Add(XHD.Model.crm_customer_dailyplan model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_customer_dailyplan model)
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
        public XHD.Model.crm_customer_dailyplan GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.crm_customer_dailyplan GetModelByCache(int id)
        {

            string CacheKey = "crm_customer_dailyplanModel-" + id;
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
            return (XHD.Model.crm_customer_dailyplan)objModel;
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
        public List<XHD.Model.crm_customer_dailyplan> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.crm_customer_dailyplan> DataTableToList(DataTable dt)
        {
            List<XHD.Model.crm_customer_dailyplan> modelList = new List<XHD.Model.crm_customer_dailyplan>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.crm_customer_dailyplan model;
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




        ////<summary>
        ////分页获取数据列表，计划完成情况
        ////</summary>
        //public DataSet GetListPlanFeat(int PageSize, int PageIndex, Dictionary<string, string> Parameters, string whereStr, string filedOrder, out string Total)
        //{
        //    return dal.GetListPlanFeat(PageSize, PageIndex, Parameters, whereStr, filedOrder, out Total);
        //}



        ///// <summary>
        ///// 分页获取数据列表(包含计划外)
        ///// </summary>
        //public DataSet GetList(int PageSize, int PageIndex, Dictionary<string, string> Parameters, string filedOrder, out string Total)
        //{
        //    return dal.GetList(PageSize, PageIndex, Parameters, filedOrder, out Total);
        //}

        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataSet GetSumPlans(string strWhere)
        //{
        //    return dal.GetSumPlans(strWhere);
        //}

        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataSet GetSumSales(Dictionary<string, string> Parameters)
        //{
        //    return dal.GetSumSales(Parameters);
        //}

        //<summary>
        //分页获取数据列表，计划完成情况(经理)
        //</summary>
        public DataSet GetListPlanFeatManger(int PageSize, int PageIndex, Dictionary<string, string> Parameters, string whereStr, string filedOrder, out string Total)
        {
            return dal.GetListPlanFeatManger(PageSize, PageIndex, Parameters, whereStr, filedOrder, out Total);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetSumPlansManger(string strWhere)
        {
            return dal.GetSumPlansManger(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetSumSalesManger(Dictionary<string, string> Parameters, string whereStr)
        {
            return dal.GetSumSalesManger(Parameters, whereStr);
        }

        /// <summary>
        /// 更新一条数据,通过传参，计划业绩，id
        /// </summary>
        public bool Update(decimal plan_feat, string plan_source, string plan_5w1hs, int id)
        {
            return dal.Update(plan_feat, plan_source, plan_5w1hs, id);
        }

        //<summary>
        //分页获取数据列表，计划完成情况(经理)
        //</summary>
        public DataSet GetListPlanFeatAll(int PageSize, int PageIndex, Dictionary<string, string> Parameters, string filedOrder, out string Total)
        {
            return dal.GetListPlanFeatAll(PageSize, PageIndex, Parameters, filedOrder, out Total);
        }

        /// <summary>
        /// 获取某个客户某天的完成情况
        /// </summary>
        public DataSet GetCompleteStatus(int customer_id, string date, int empid, int unixtimeStart, int unixtimeEnd, string factory_id)
        {
            return dal.GetCompleteStatus(customer_id, date, empid, unixtimeStart, unixtimeEnd, factory_id);
        }


        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

