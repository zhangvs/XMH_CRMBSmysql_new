using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using FMS_Model;

namespace FMS_BLL
{
    /// <summary>
    /// shop_invoices2
    /// </summary>
    public partial class shop_invoices2
    {
        private readonly FMS_DAL.shop_invoices2 dal = new FMS_DAL.shop_invoices2();
        public shop_invoices2()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int invoice_id)
        {
            return dal.Exists(invoice_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FMS_Model.shop_invoices2 model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.shop_invoices2 model)
        {
            return dal.Update(model);
        }

            /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateRe(FMS_Model.shop_invoices2 model)
        {
            return dal.UpdateRe(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int invoice_id)
        {

            return dal.Delete(invoice_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string invoice_idlist)
        {
            return dal.DeleteList(invoice_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FMS_Model.shop_invoices2 GetModel(int invoice_id)
        {

            return dal.GetModel(invoice_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.shop_invoices2 GetModelByCache(int invoice_id)
        {

            string CacheKey = "shop_invoices2Model-" + invoice_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(invoice_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (FMS_Model.shop_invoices2)objModel;
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
        public List<FMS_Model.shop_invoices2> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.shop_invoices2> DataTableToList(DataTable dt)
        {
            List<FMS_Model.shop_invoices2> modelList = new List<FMS_Model.shop_invoices2>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.shop_invoices2 model;
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
        /// 加载已开发票信息信息 
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

