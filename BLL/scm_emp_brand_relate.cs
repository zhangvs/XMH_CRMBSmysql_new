﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// scm_emp_brand_relate
    /// </summary>
    public partial class scm_emp_brand_relate
    {
        private readonly XHD.DAL.scm_emp_brand_relate dal = new XHD.DAL.scm_emp_brand_relate();
        public scm_emp_brand_relate()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string factory_Id, int empId, string brandId, int create_id, string create_name, DateTime create_date)
        {
            return dal.Exists(factory_Id, empId, brandId, create_id, create_name, create_date);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_emp_brand_relate model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.scm_emp_brand_relate model)
        {
            return dal.Update(model);
        }

           /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Updates(XHD.Model.scm_emp_brand_relate model)
        {
            return dal.Updates(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string factory_Id, int empId, string brandId)
        {

            return dal.Delete(factory_Id, empId, brandId);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.scm_emp_brand_relate GetModel(string factory_Id, int empId, string brandId, int create_id, string create_name, DateTime create_date)
        {

            return dal.GetModel(factory_Id, empId, brandId, create_id, create_name, create_date);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.scm_emp_brand_relate GetModelByCache(string factory_Id, int empId, string brandId, int create_id, string create_name, DateTime create_date)
        {

            string CacheKey = "scm_emp_brand_relateModel-" + factory_Id + empId + brandId + create_id + create_name + create_date;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(factory_Id, empId, brandId, create_id, create_name, create_date);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.scm_emp_brand_relate)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize,PageIndex,strWhere,filedOrder,out Total);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_emp_brand_relate> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_emp_brand_relate> DataTableToList(DataTable dt)
        {
            List<XHD.Model.scm_emp_brand_relate> modelList = new List<XHD.Model.scm_emp_brand_relate>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.scm_emp_brand_relate model;
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

