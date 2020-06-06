﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// ssn_authority
    /// </summary>
    public partial class ssn_authority
    {
        private readonly XHD.DAL.ssn_authority dal = new XHD.DAL.ssn_authority();
        public ssn_authority()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(XHD.Model.ssn_authority model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ssn_authority model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete();
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ssn_authority GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel();
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.ssn_authority GetModelByCache()
        {
            //该表无主键信息，请自定义主键/条件字段
            string CacheKey = "ssn_authorityModel-";
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel();
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.ssn_authority)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        public DataSet GetListAuth(string strWhere)
        {
            return dal.GetListAuth(strWhere);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ssn_authority> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ssn_authority> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ssn_authority> modelList = new List<XHD.Model.ssn_authority>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ssn_authority model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new XHD.Model.ssn_authority();
                    if (dt.Rows[n]["Role_id"] != null && dt.Rows[n]["Role_id"].ToString() != "")
                    {
                        model.Role_id = int.Parse(dt.Rows[n]["Role_id"].ToString());
                    }
                    if (dt.Rows[n]["App_ids"] != null && dt.Rows[n]["App_ids"].ToString() != "")
                    {
                        model.App_ids = dt.Rows[n]["App_ids"].ToString();
                    }
                    if (dt.Rows[n]["Menu_ids"] != null && dt.Rows[n]["Menu_ids"].ToString() != "")
                    {
                        model.Menu_ids = dt.Rows[n]["Menu_ids"].ToString();
                    }
                    if (dt.Rows[n]["Button_ids"] != null && dt.Rows[n]["Button_ids"].ToString() != "")
                    {
                        model.Button_ids = dt.Rows[n]["Button_ids"].ToString();
                    }
                    if (dt.Rows[n]["Create_id"] != null && dt.Rows[n]["Create_id"].ToString() != "")
                    {
                        model.Create_id = int.Parse(dt.Rows[n]["Create_id"].ToString());
                    }
                    if (dt.Rows[n]["Create_date"] != null && dt.Rows[n]["Create_date"].ToString() != "")
                    {
                        model.Create_date = DateTime.Parse(dt.Rows[n]["Create_date"].ToString());
                    }
                    modelList.Add(model);
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
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteWhere(string wherestr)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.DeleteWhere(wherestr);
        }
        #endregion  Method
    }
}

