﻿/**  版本信息模板在安装目录下，可自行修改。
* shop_order_info.cs
*
* 功 能： N/A
* 类 名： shop_order_info
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/9/14 11:31:25   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// shop_order_info
    /// </summary>
    public partial class shop_order_info
    {
        private readonly XHD.DAL.shop_order_info dal = new XHD.DAL.shop_order_info();
        public shop_order_info()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int order_id)
        {
            return dal.Exists(order_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop_order_info model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.shop_order_info model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int order_id)
        {

            return dal.Delete(order_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string order_idlist)
        {
            return dal.DeleteList(order_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.shop_order_info GetModel(int order_id)
        {

            return dal.GetModel(order_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.shop_order_info GetModelByCache(int order_id)
        {

            string CacheKey = "shop_order_infoModel-" + order_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(order_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.shop_order_info)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        public DataSet GetOrderInfo(string strWhere)
        {
            return dal.GetOrderInfo(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.shop_order_info> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.shop_order_info> DataTableToList(DataTable dt)
        {
            List<XHD.Model.shop_order_info> modelList = new List<XHD.Model.shop_order_info>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.shop_order_info model;
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
        //获取我的订单信息
        public DataSet GetMyOrder(int PageSize, int PageIndex, string strWhere, string sqlOne, string sqlTwo, string filedOrder, out string Total)
        {
            return dal.GetMyOrder(PageSize, PageIndex, strWhere, sqlOne, sqlTwo, filedOrder, out  Total);
        }

        //获取Tms订单信息
        public DataSet GetMyOrderTms(int PageSize, int PageIndex, string strWhere, string sqlOne, string sqlTwo, string filedOrder, out string Total)
        {
            return dal.GetMyOrderTms(PageSize, PageIndex, strWhere, sqlOne, sqlTwo, filedOrder, out  Total);
        }

        //获取审核订单信息
        public DataSet GetCheckOrder(int PageSize, int PageIndex, string strWhere, string sqlOne, string filedOrder, out string Total)
        {
            return dal.GetCheckOrder(PageSize, PageIndex, strWhere, sqlOne, filedOrder, out  Total);
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList2(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList2(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

