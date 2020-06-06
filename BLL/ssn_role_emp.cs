﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// ssn_role_emp
    /// </summary>
    public partial class ssn_role_emp
    {
        private readonly XHD.DAL.ssn_role_emp dal = new XHD.DAL.ssn_role_emp();
        public ssn_role_emp()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(XHD.Model.ssn_role_emp model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ssn_role_emp model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string strWhere)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete(strWhere);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ssn_role_emp GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel();
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.ssn_role_emp GetModelByCache()
        {
            //该表无主键信息，请自定义主键/条件字段
            string CacheKey = "ssn_role_empModel-";
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
            return (XHD.Model.ssn_role_emp)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
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
        public List<XHD.Model.ssn_role_emp> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ssn_role_emp> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ssn_role_emp> modelList = new List<XHD.Model.ssn_role_emp>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ssn_role_emp model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new XHD.Model.ssn_role_emp();
                    if (dt.Rows[n]["RoleID"] != null && dt.Rows[n]["RoleID"].ToString() != "")
                    {
                        model.RoleID = int.Parse(dt.Rows[n]["RoleID"].ToString());
                    }
                    if (dt.Rows[n]["empID"] != null && dt.Rows[n]["empID"].ToString() != "")
                    {
                        model.empID = int.Parse(dt.Rows[n]["empID"].ToString());
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

        #endregion  Method
    }
}

