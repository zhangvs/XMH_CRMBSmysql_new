using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// ecs_brand
    /// </summary>
    public partial class ecs_brand
    {
        private readonly XHD.DAL.ecs_brand dal = new XHD.DAL.ecs_brand();
        public ecs_brand()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int brand_id)
        {
            return dal.Exists(brand_id);
        }

        public bool New_Exists(string where_str)
        {
            return dal.New_Exists(where_str);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 获得品牌数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ecs_brand> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ecs_brand> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ecs_brand> modelList = new List<XHD.Model.ecs_brand>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ecs_brand model;
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
        /// 获得商品分类数据列表
        /// </summary>
        public DataSet GetListCategory(string strWhere)
        {
            return dal.GetListCategory(strWhere);
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 关联
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool RelatedBrand(string brandId, string supplyId)
        {
            return dal.RelatedBrand(brandId, supplyId);
        }

        /// <summary>
        /// 解除
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool UnRelatedBrand(string brandId, string supplyId)
        {
            return dal.UnRelatedBrand(brandId, supplyId);
        }

        public DataSet GetSale(int PageSize, int PageIndex, string strWhere, string ordertime, string djtime, string brand_id, string filedOrder, out string Total)
        {
            return dal.GetSale(PageSize, PageIndex, strWhere, ordertime, djtime, brand_id, filedOrder, out  Total);
        }

        public DataSet getSumSales(string strWhere, string ordertime, string djtime, string brand_id)
        {
            return dal.getSumSales(strWhere, ordertime, djtime, brand_id);
        }

        public DataSet GetSaleAll(int PageSize, int PageIndex, string sqlWhere, string strWhere, string ordertime, string djtime, string brand_id, string filedOrder, out string Total)
        {
            return dal.GetSaleAll(PageSize, PageIndex, sqlWhere, strWhere, ordertime, djtime, brand_id, filedOrder, out  Total);
        }

        public DataSet GetDetail(string strWhere, string strWhere1, string ordertime, string djtime, string brand_id, string filedOrder)
        {
            return dal.GetDetail(strWhere,strWhere1, ordertime, djtime, brand_id, filedOrder);
        }
        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

