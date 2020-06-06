﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using FMS_Model;
namespace FMS_BLL
{
    /// <summary>
    /// wms_payment_bill
    /// </summary>
    public partial class wms_payment_bill
    {
        private readonly FMS_DAL.wms_payment_bill dal = new FMS_DAL.wms_payment_bill();
        public wms_payment_bill()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long pay_id)
        {
            return dal.Exists(pay_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.wms_payment_bill model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.wms_payment_bill model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(long pay_id)
        {

            return dal.Delete(pay_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string pay_idlist)
        {
            return dal.DeleteList(pay_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FMS_Model.wms_payment_bill GetModel(long pay_id)
        {

            return dal.GetModel(pay_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.wms_payment_bill GetModelByCache(long pay_id)
        {

            string CacheKey = "wms_payment_billModel-" + pay_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(pay_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (FMS_Model.wms_payment_bill)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }


         /// <summary>
        /// model_list获取数据集
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<FMS_Model.wms_payment_bill> NewGetList(string strWhere)
        {
            return dal.NewGetList(strWhere);
        }


        /// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public List<Maticsoft.Model.wms_payment_bill> GetModelList(string strWhere)
        //{
        //    DataSet ds = dal.GetList(strWhere);
        //    return DataTableToList(ds.Tables[0]);
        //}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.wms_payment_bill> DataTableToList(DataTable dt)
        {
            List<FMS_Model.wms_payment_bill> modelList = new List<FMS_Model.wms_payment_bill>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.wms_payment_bill model;
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

        ///// <summary>
        ///// 分页获取数据列表
        ///// </summary>
        //public int GetRecordCount(string strWhere)
        //{
        //    return dal.GetRecordCount(strWhere);
        //}
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

