﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using FMS_Model;

namespace FMS_BLL
{
    /// <summary>
    /// fms_refund_bill
    /// </summary>
    public partial class fms_refund_bill
    {
        private readonly FMS_DAL.fms_refund_bill dal = new FMS_DAL.fms_refund_bill();
        public fms_refund_bill()
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
        public bool Exists(int refund_id)
        {
            return dal.Exists(refund_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.fms_refund_bill model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.fms_refund_bill model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 审核
        /// </summary>
        public bool updateStatus(FMS_Model.fms_refund_bill model,string idList)
        {
            return dal.updateStatus(model, idList);
        }

        /// <summary>
        /// 付款
        /// </summary>
        public bool pay_kuan(FMS_Model.fms_refund_bill model, string idList)
        {
            return dal.pay_kuan(model, idList);
        }

           /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Updates(FMS_Model.fms_refund_bill model)
        {
            return dal.Updates(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int refund_id)
        {

            return dal.Delete(refund_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string refund_idlist)
        {
            return dal.DeleteList(refund_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FMS_Model.fms_refund_bill GetModel(int refund_id)
        {

            return dal.GetModel(refund_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.fms_refund_bill GetModelByCache(int refund_id)
        {

            string CacheKey = "fms_refund_billModel-" + refund_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(refund_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (FMS_Model.fms_refund_bill)objModel;
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
        public List<FMS_Model.fms_refund_bill> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }


        /// <summary>
        /// model_list获取数据集
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<FMS_Model.fms_refund_bill> NewGetList(string strWhere)
        {
            return dal.NewGetList(strWhere);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.fms_refund_bill> DataTableToList(DataTable dt)
        {
            List<FMS_Model.fms_refund_bill> modelList = new List<FMS_Model.fms_refund_bill>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.fms_refund_bill model;
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
        /// 加载所有退款单
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

