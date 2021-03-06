﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using FMS_Model;

namespace FMS_BLL
{
    /// <summary>
    /// shop_order_goods
    /// </summary>
    public partial class shop_order_goods
    {
        private readonly FMS_DAL.shop_order_goods dal = new FMS_DAL.shop_order_goods();
        public shop_order_goods()
        { }

        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ordergood_id)
        {
            return dal.Exists(ordergood_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.shop_order_goods model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.shop_order_goods model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新已开票数量
        /// </summary>
        public bool UpdateNum(FMS_Model.shop_order_goods model)
        {
            return dal.UpdateNum(model);
        }
        
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ordergood_id)
        {

            return dal.Delete(ordergood_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string ordergood_idlist)
        {
            return dal.DeleteList(ordergood_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FMS_Model.shop_order_goods GetModel(int ordergood_id)
        {

            return dal.GetModel(ordergood_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.shop_order_goods GetModelByCache(int ordergood_id)
        {

            string CacheKey = "shop_order_goodsModel-" + ordergood_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ordergood_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (FMS_Model.shop_order_goods)objModel;
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
        public List<FMS_Model.shop_order_goods> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.shop_order_goods> DataTableToList(DataTable dt)
        {
            List<FMS_Model.shop_order_goods> modelList = new List<FMS_Model.shop_order_goods>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.shop_order_goods model;
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

        //获得客户的发货金额
        public string GetDeliveryAmoun(string strWhere)
        {
            return dal.GetDeliveryAmoun(strWhere);
        }


        //获得客户的发货金额
        public DataSet GetDeliveryAmouns(string strWhere)
        {
            return dal.GetDeliveryAmouns(strWhere);
        }
       
        /// <summary>
        /// 获得客户的发货金额、开票金额、未开票金额
        /// </summary>
        public DataSet GetBillAmoun(string strWhere)
        {
            return dal.GetBillAmoun(strWhere);
        }



        /// <summary>
        /// 获得客户运费
        /// </summary>
        public DataSet GetBillFee(string strWhere)
        {
            return dal.GetBillFee(strWhere);
        }


        /// <summary>
        /// 获取发票-往来账
        /// </summary>
        /// <returns></returns>
        public DataSet GetBill(int PageSize, int PageIndex, string strWhere, string filedOrder, string time, string money, out string Total)
        {
            return dal.GetBill(PageSize, PageIndex, strWhere, filedOrder, time, money, out Total);
        }

        /// <summary>
        /// 获取需要开发票的订单详情
        /// </summary>
        /// <returns></returns>
        public DataSet GetOrderList(string strWhere, string filedOrder,string user_id)
        {
            return dal.GetOrderList(strWhere, filedOrder, user_id);
        }
         
        /// <summary>
        /// 获取退货的记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetReturnList(string strWhere, string filedOrder)
        {
            return dal.GetReturnList(strWhere, filedOrder);
        }

        //获得客户的积分
        public string GetScoreAmoun(string strWhere)
        {
            return dal.GetScoreAmoun(strWhere);
        }

        /// <summary>
        /// 获得订单的商品信息
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 获得客户往来明细
        /// </summary>
        public DataSet GetContactMX(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetContactMX(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }


        /// <summary>
        /// 获得客户往来明细
        /// </summary>
        public DataSet GetContactNum(string strWhere)
        {
            return dal.GetContactNum(strWhere);
        }


        /// <summary>
        /// 获得客户往来款明细
        /// </summary>
        public DataSet GetContactMXJson(int PageSize, int PageIndex, string strWhere, DataTable dt_data, string filedOrder, out string Total)
        {
            return dal.GetContactMXJson(PageSize, PageIndex, strWhere, dt_data, filedOrder, out Total);
        }

        
        /// <summary>
        /// 获得客户往来款详情
        /// </summary>
        public DataSet GetContactDetails(int PageSize, int PageIndex, string strWhere,string strWhereOne, string filedOrder, out string Total)
        {
            return dal.GetContactDetails(PageSize, PageIndex, strWhere, strWhereOne,filedOrder, out Total);
        }

        /// <summary>
        /// 获得客户往来款详情
        /// </summary>
        public DataSet GetContactDetailsJson(int PageSize, int PageIndex, string strWhere, DataTable dt_data, string filedOrder, out string Total)
        {
            return dal.GetContactDetailsJson(PageSize, PageIndex, strWhere, dt_data, filedOrder, out Total);
        }

        /// <summary>
        /// 获得客户的所有往来款
        /// </summary>
        public DataSet GetContactAll(string strWhere, string strWhereOne)
        {
            return dal.GetContactAll(strWhere, strWhereOne);
        }

        /// <summary>
        /// 获得客户的所有往来款
        /// </summary>
        public DataSet GetContactAllJson(DataTable dt)
        {
            return dal.GetContactAllJson(dt);
        }

        /// <summary>
        /// 获得客户的发货明细
        /// </summary>
        public DataSet GetDeliveryDetail(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetDeliveryDetail(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 获得客户的发货明细
        /// </summary>
        public DataSet GetDeliveryDetailJson(int PageSize, int PageIndex, DataTable dt, string filedOrder, out string Total)
        {
            return dal.GetDeliveryDetailJson(PageSize, PageIndex, dt, filedOrder, out Total);
        }

        /// <summary>
        /// 获得客户的未开票明细
        /// </summary>
        public DataSet GetUnBillDetail(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetUnBillDetail(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 获得客户的未开票明细
        /// </summary>
        public DataSet GetUnBillJson(int PageSize, int PageIndex, DataTable dt, string filedOrder, out string Total)
        {
            return dal.GetUnBillJson(PageSize, PageIndex, dt, filedOrder, out Total);
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

