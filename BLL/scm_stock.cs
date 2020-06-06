using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// scm_stock
    /// </summary>
    public partial class scm_stock
    {
        private readonly XHD.DAL.scm_stock dal = new XHD.DAL.scm_stock();
        public scm_stock()
        { }

        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            return dal.Exists(Id);
        }

        public bool Exists1(int Id, int suppliers_id)
        {
            return dal.Exists1(Id, suppliers_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_stock model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.scm_stock model)
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
        public XHD.Model.scm_stock GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.scm_stock GetModelByCache(int Id)
        {

            string CacheKey = "scm_stockModel-" + Id;
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
            return (XHD.Model.scm_stock)objModel;
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
        public List<XHD.Model.scm_stock> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_stock> DataTableToList(DataTable dt)
        {
            List<XHD.Model.scm_stock> modelList = new List<XHD.Model.scm_stock>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.scm_stock model;
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
        /// 由产品ID查该产品由哪些供应商提供
        /// </summary>
        public DataSet GetSupplyList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetSupplyList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }


        /// <summary>
        /// 由产品ID查该产品由哪些供应商提供
        /// </summary>
        public DataSet GetSupplys(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetSupplys(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// 更新已经存在合并的产品的子产品
        public bool updateChikdren(int cid, int newid, string newname)
        {
            return dal.updateChikdren(cid, newid, newname);
        }

        /// 获取被合并的产品
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out  Total);
        }


        //供应商库存统计及商城库存统计
        public DataSet GetListCheckStock(string strWhereOne,string strWhereTwo)
        {
            return dal.GetListCheckStock(strWhereOne,strWhereTwo);
        }

            //供应商商城销售数量及销售订单数量统计
        public DataSet GetSaleSL(string strWhereOne)
        {
            return dal.GetSaleSL(strWhereOne);
        }

        //查某一供应商的库存、商城库存、销售数量及订单数量
        public DataSet GetStockSaleSL(int PageSize, int startIndex, string strWhere, string strSqlOne, string strSqlTwo, string strSqlThree, string filedOrder, out string Total)
        {
            return dal.GetStockSaleSL(PageSize, startIndex, strWhere, strSqlOne, strSqlTwo, strSqlThree, filedOrder, out Total);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

