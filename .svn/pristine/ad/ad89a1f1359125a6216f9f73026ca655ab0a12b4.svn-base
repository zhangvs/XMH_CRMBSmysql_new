using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;

namespace XHD.BLL
{
    /// <summary>
    /// shop_invoices_among_goods
    /// </summary>
    public partial class shop_invoices_among_goods
    {

        private readonly DAL.shop_invoices_among_goods dal = new DAL.shop_invoices_among_goods();
        public shop_invoices_among_goods()
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
        public bool Add(Model.shop_invoices_among_goods model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.shop_invoices_among_goods model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Updates(Model.shop_invoices_among_goods model)
        {
            return dal.Updates(model);
        }


        /// <summary>
        /// 抵扣退货更新
        /// </summary>
        public bool updateBill(Model.shop_invoices_among_goods model)
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
        public Model.shop_invoices_among_goods GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public Model.shop_invoices_among_goods GetModelByCache(int id)
        {

            string CacheKey = "shop_invoices_among_goodsModel-" + id;
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
            return (Model.shop_invoices_among_goods)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }


        /// <summary>
        /// 获得删除某一发票上的商品后，该发票剩余的商品数量及总价
        /// </summary>
        public DataSet GetRemain(string strWhere)
        {
            return dal.GetRemain(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListOrder(string strWhere)
        {
            return dal.GetListOrder(strWhere);
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
        public List<Model.shop_invoices_among_goods2> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.shop_invoices_among_goods2> DataTableToList(DataTable dt)
        {
            List<Model.shop_invoices_among_goods2> modelList = new List<Model.shop_invoices_among_goods2>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.shop_invoices_among_goods2 model;
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

