using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using FMS_Model;

namespace FMS_BLL
{
    /// <summary>
    /// shop_invoices_goods
    /// </summary>
    public partial class shop_invoices_goods
    {
        private readonly FMS_DAL.shop_invoices_goods dal = new FMS_DAL.shop_invoices_goods();
        public shop_invoices_goods()
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
        public int Add(FMS_Model.shop_invoices_goods model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.shop_invoices_goods model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Updates(FMS_Model.shop_invoices_goods model)
        {
            return dal.Updates(model);
        }


        /// <summary>
        /// 抵扣退货更新
        /// </summary>
        public bool updateBill(FMS_Model.shop_invoices_goods model)
        {
            return dal.updateBill(model);
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

        //删除开票下产品信息
        public bool DeleteGood(string strWhere)
        {
            return dal.DeleteGood(strWhere);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FMS_Model.shop_invoices_goods GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.shop_invoices_goods GetModelByCache(int id)
        {

            string CacheKey = "shop_invoices_goodsModel-" + id;
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
            return (FMS_Model.shop_invoices_goods)objModel;
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
        public DataSet GetInfo(string strWhere)
        {
            return dal.GetInfo(strWhere);
        }

        /// <summary>
        /// 获得开票总金额
        /// </summary>
        public DataSet GetTotlaMoney(string strWhere)
        {
            return dal.GetTotlaMoney(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.shop_invoices_goods> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.shop_invoices_goods> DataTableToList(DataTable dt)
        {
            List<FMS_Model.shop_invoices_goods> modelList = new List<FMS_Model.shop_invoices_goods>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.shop_invoices_goods model;
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

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

