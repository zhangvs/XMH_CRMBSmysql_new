using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_BLL
{
    /// <summary>
    /// shop_return_goods
    /// </summary>
    public partial class shop_return_goods
    {
        private readonly FMS_DAL.shop_return_goods dal = new FMS_DAL.shop_return_goods();
        public shop_return_goods()
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
        public bool Exists(int sid)
        {
            return dal.Exists(sid);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.shop_return_goods model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.shop_return_goods model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int sid)
        {

            return dal.Delete(sid);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string sidlist)
        {
            return dal.DeleteList(sidlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FMS_Model.shop_return_goods GetModel(int sid)
        {

            return dal.GetModel(sid);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.shop_return_goods GetModelByCache(int sid)
        {

            string CacheKey = "shop_return_goodsModel-" + sid;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(sid);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (FMS_Model.shop_return_goods)objModel;
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
        /// 获得退货总金额
        /// </summary>
        public DataSet GetReturnTotal(string strWhere)
        {
            return dal.GetReturnTotal(strWhere);
        }

        /// 获得退货总金额
        public string GetReturnAmoun(string strWhere)
        {
            return dal.GetReturnAmoun(strWhere);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.shop_return_goods> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.shop_return_goods> DataTableToList(DataTable dt)
        {
            List<FMS_Model.shop_return_goods> modelList = new List<FMS_Model.shop_return_goods>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.shop_return_goods model;
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
        /// 获得客户的所有未抵扣的退货商品
        /// </summary>
        public DataSet GetReByUserId(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetReByUserId(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        //单个更改状态
        public bool UpdateInvoice(string sid, string is_invoice) 
        {
            return dal.UpdateInvoice(sid, is_invoice);
        }

        
        /// <summary>
        /// 获得客户的退货主表信息
        /// </summary>
        public DataSet GetReturnOrder(int PageSize, int PageIndex,int mark, string strWhere,DataTable dt, string filedOrder, out string Total)
        {
            return dal.GetReturnOrder(PageSize, PageIndex,mark, strWhere,dt, filedOrder, out Total);
        }

        /// <summary>
        /// 获得客户的退货商品详情
        /// </summary>
        public DataSet GetReturnDetail(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetReturnDetail(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

