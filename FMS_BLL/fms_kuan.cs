﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using FMS_Model;

namespace FMS_BLL
{
    /// <summary>
    /// fms_kuan
    /// </summary>
    public partial class fms_kuan
    {
        private readonly FMS_DAL.fms_kuan dal = new FMS_DAL.fms_kuan();
        public fms_kuan()
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FMS_Model.fms_kuan model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.fms_kuan model)
        {
            return dal.Update(model);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Adds(FMS_Model.fms_kuan model, FMS_Model.fms_dkmassage Mmodel, FMS_Model.shop_progress_payments pmodel,DataSet ds)
        {
            return dal.Adds(model, Mmodel, pmodel,ds);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Updates(FMS_Model.fms_kuan model, FMS_Model.fms_dkmassage Mmodel)
        {
            return dal.Updates(model, Mmodel);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateJ(FMS_Model.fms_dkmassage Mmodel,int flag)
        {
            return dal.UpdateJ(Mmodel, flag);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateCode(FMS_Model.fms_kuan model, FMS_Model.fms_dkmassage Mmodel)
        {
            return dal.UpdateCode(model, Mmodel);
        }

        //删除数据
        public bool DelAll(int dk_id)
        {
            return dal.DelAll(dk_id);
        }


        //删除数据
        public bool DelAlls(int dk_id)
        {
            return dal.DelAlls(dk_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool AddKuan(FMS_Model.fms_kuan model,FMS_Model.shop_progress_payments pmodel)
        {
            return dal.AddKuan(model, pmodel);
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
        public FMS_Model.fms_kuan GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.fms_kuan GetModelByCache(int id)
        {

            string CacheKey = "fms_kuanModel-" + id;
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
            return (FMS_Model.fms_kuan)objModel;
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
        public List<FMS_Model.fms_kuan> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.fms_kuan> DataTableToList(DataTable dt)
        {
            List<FMS_Model.fms_kuan> modelList = new List<FMS_Model.fms_kuan>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.fms_kuan model;
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

        //获得客户的应收款
        public string GetCollectedAmoun(string strWhere)
        {
            return dal.GetCollectedAmoun(strWhere);
        }

        /// <summary>
        /// 加载公司户认款信息
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}