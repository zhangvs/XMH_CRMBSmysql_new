﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// ecs_total_planService
    /// </summary>
    public partial class ecs_total_planService
    {
        private readonly XHD.DAL.ecs_total_planDAO dal = new XHD.DAL.ecs_total_planDAO();
        public ecs_total_planService()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int plan_id)
        {
            return dal.Exists(plan_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_total_plan model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ecs_total_plan model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int plan_id)
        {

            return dal.Delete(plan_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string plan_idlist)
        {
            return dal.DeleteList(plan_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ecs_total_plan GetModel(int plan_id)
        {

            return dal.GetModel(plan_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.ecs_total_plan GetModelByCache(int plan_id)
        {

            string CacheKey = "ecs_total_planModel-" + plan_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(plan_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.ecs_total_plan)objModel;
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
        public List<XHD.Model.ecs_total_plan> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ecs_total_plan> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ecs_total_plan> modelList = new List<XHD.Model.ecs_total_plan>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ecs_total_plan model;
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

        #endregion  ExtensionMethod
    }
}

