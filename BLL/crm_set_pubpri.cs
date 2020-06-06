﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// crm_set_pubpri
    /// </summary>
    public partial class crm_set_pubpri
    {
        private readonly XHD.DAL.crm_set_pubpri dal = new XHD.DAL.crm_set_pubpri();
        public crm_set_pubpri()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 得到公共客户的数量
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int getPublicNum(string strWhere)
        {
            return dal.getPublicNum(strWhere);
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
        public bool Add(XHD.Model.crm_set_pubpri model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_set_pubpri model)
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
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.crm_set_pubpri GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.crm_set_pubpri GetModelByCache(int Id)
        {

            string CacheKey = "crm_set_pubpriModel-" + Id;
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
                catch { }
            }
            return (XHD.Model.crm_set_pubpri)objModel;
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
        public DataSet GetListDept(string strWhere)
        {
            return dal.GetListDept(strWhere);
        }

        /// <summary>
        /// 获取某个时间段已经被分配的数量,下级部门分配的数量
        /// </summary>
        public DataSet GetSum(string strWhere)
        {
            return dal.GetSum(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.crm_set_pubpri> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.crm_set_pubpri> DataTableToList(DataTable dt)
        {
            List<XHD.Model.crm_set_pubpri> modelList = new List<XHD.Model.crm_set_pubpri>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.crm_set_pubpri model;
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
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList1(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList1(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }
        #endregion  BasicMethod

    }
}
