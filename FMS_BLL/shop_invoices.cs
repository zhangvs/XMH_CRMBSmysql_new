using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using FMS_Model;

namespace FMS_BLL
{
    /// <summary>
    /// shop_invoices
    /// </summary>
    public partial class shop_invoices
    {
        private readonly FMS_DAL.shop_invoices dal = new FMS_DAL.shop_invoices();
        public shop_invoices()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }
        public bool Update(string sql)
        {
            return dal.Update(sql);
        }

        public DataSet GetParams(string sql)
        {
            return dal.GetParams(sql);
        }

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
        public int Add(FMS_Model.shop_invoices model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.shop_invoices model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Updates(FMS_Model.shop_invoices model)
        {
            return dal.Updates(model);
        }
        
        
        /// <summary>
        /// 更新开票信息中寄送方式
        /// </summary>
        public bool updateShipType(FMS_Model.shop_invoices model)
        {
            return dal.updateShipType(model);
        }


        
        /// <summary>
        /// 关联数据
        /// </summary>
        public bool UpdateRE(FMS_Model.shop_invoices model)
        {
            return dal.UpdateRE(model);
        }

        /// <summary>
        /// 抵扣退货更新
        /// </summary>
        public bool updateBill(FMS_Model.shop_invoices model)
        {
            return dal.updateBill(model);
        }
   
        /// <summary>
        /// 更新开票信息中的退货商品信息
        /// </summary>
        public bool updateReturn(FMS_Model.shop_invoices model)
        {
            return dal.updateReturn(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int invoice_id)
        {
            return dal.Delete(invoice_id);
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string invoice_idlist)
        {
            return dal.DeleteList(invoice_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FMS_Model.shop_invoices GetModel(int invoice_id)
        {

            return dal.GetModel(invoice_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.shop_invoices GetModelByCache(int invoice_id)
        {

            string CacheKey = "shop_invoicesModel-" + invoice_id;
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
            return (FMS_Model.shop_invoices)objModel;
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
        public DataSet GetListInfo(string strWhere)
        {
            return dal.GetListInfo(strWhere);
        }

         /// <summary>
        /// 获得相关发票
        /// </summary>
        public DataSet GetRelateBill(string strWhere)
        {
            return dal.GetRelateBill(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.shop_invoices> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.shop_invoices> DataTableToList(DataTable dt)
        {
            List<FMS_Model.shop_invoices> modelList = new List<FMS_Model.shop_invoices>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.shop_invoices model;
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
        /// 获取所有开票请求
        /// </summary>
        public DataSet GetRequestBill(int PageSize, int PageIndex, string strWhere,string filedOrder, out string Total)
        {
            return dal.GetRequestBill(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 查询已开票信息
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex,int mark, string strWhere,DataTable dt, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex,mark, strWhere,dt, filedOrder, out Total);
        }


        /// <summary>
        /// 获取开票用户信息
        /// </summary>
        public DataSet GetUserBillInfo(string strWhere,string strWhereOne)
        {
            return dal.GetUserBillInfo(strWhere, strWhereOne);
        }

        //获得客户的已开发票金额
        public string GetInvoiceAmoun(string strWhere)
        {
            return dal.GetInvoiceAmoun(strWhere);
        }

          /// <summary>
        /// 更新发票状态
        /// </summary>
        public bool updateStatus(string invoice_id,string erpCode, int status,int time)
        {
            return dal.updateStatus(invoice_id,erpCode, status, time);
        }

          /// <summary>
        /// 更新发票状态
        /// </summary>
        public bool updateStatusList(string invoice_id, int status, int time)
        {
            return dal.updateStatusList(invoice_id, status, time);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

