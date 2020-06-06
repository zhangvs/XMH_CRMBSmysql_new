using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// scm_supply_goods
    /// </summary>
    public partial class scm_supply_goods
    {
        private readonly XHD.DAL.scm_supply_goods dal = new XHD.DAL.scm_supply_goods();
        public scm_supply_goods()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int goods_id)
        {
            return dal.Exists(goods_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_supply_goods model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.scm_supply_goods model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 更新到主表
        /// </summary>
        public bool UpdateToShop(XHD.Model.scm_supply_goods model)
        {
            return dal.UpdateToShop(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int goods_id, int suppliers_id)
        {

            return dal.Delete(goods_id, suppliers_id);
        }
        /// <summary>
        /// 拒绝申请
        /// </summary>
        public bool refuse(int id, int suppliers_id, string reason, string type)
        {
            return dal.refuse(id, suppliers_id, reason, type);
        }
        /// <summary>
        /// 删除同步商城setOutToShop
        /// </summary>
        public bool setDeleteToShop(int goods_id)
        {
            return dal.setDeleteToShop(goods_id);
        }
        /// <summary>
        /// 下架同步商城
        /// </summary>
        public bool setOutToShop(int goods_id)
        {
            return dal.setOutToShop(goods_id);
        }
        /// <summary>
        /// 退市同步到商城
        /// </summary>
        public bool setDeliToShop(int goods_id)
        {
            return dal.setDeliToShop(goods_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string goods_idlist)
        {
            return dal.DeleteList(goods_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.scm_supply_goods GetModel(int goods_id)
        {

            return dal.GetModel(goods_id);
        }

        /// <summary>
        /// 得到一个对象实体商城用
        /// </summary>
        public XHD.Model.scm_supply_goods GetModelShop(int goods_id, int suppliers_id)
        {

            return dal.GetModelShop(goods_id, suppliers_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.scm_supply_goods GetModelByCache(int goods_id)
        {

            string CacheKey = "scm_supply_goods_copyModel-" + goods_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(goods_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.scm_supply_goods)objModel;
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
        public List<XHD.Model.scm_supply_goods> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_supply_goods> DataTableToList(DataTable dt)
        {
            List<XHD.Model.scm_supply_goods> modelList = new List<XHD.Model.scm_supply_goods>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.scm_supply_goods model;
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
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 向附表增加一条数据
        /// </summary>
        public bool AddCopy(int goods_id)
        {
            return dal.AddCopy(goods_id);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList1(string strWhere)
        {
            return dal.GetList1(strWhere);
        }
        /// <summary>
        /// 产品提交
        /// </summary>
        public bool submitProduct(string goods_idlist)
        {
            return dal.submitProduct(goods_idlist);
        }
        /// <summary>
        /// 删除产品
        /// </summary>
        public bool setDelete(int goods_id, string reason)
        {
            return dal.setDelete(goods_id, reason);
        }
        /// <summary>
        /// 查询类型的最小单位
        /// </summary>
        public DataSet GetUnitById(int id)
        {
            return dal.GetUnitById(id);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod

        //根据商品ID在wms中查库存数量
        public DataSet GetSLByBM(string strWhere)
        {
            return dal.GetSLByBM(strWhere);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet Getgoods(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.Getgoods(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

