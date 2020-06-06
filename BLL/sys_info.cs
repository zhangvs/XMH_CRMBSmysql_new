using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
using XHD.DAL;

namespace XHD.BLL
{
    /// <summary>
    /// sys_info
    /// </summary>
    public partial class sys_info
    {
        private readonly XHD.DAL.sys_info dal = new XHD.DAL.sys_info();
        public sys_info()
        { }
        #region  Method

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.sys_info model)
        {
            return dal.Update(model);
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
        public DataSet GetAllList()
        {
            return GetList("");
        }
        /// <summary>
        /// 获取单号信息
        /// </summary>
        /// <returns></returns>
        public string GetBill(string strObj)
        {
            return dal.GetBill(strObj);
        }
        #endregion  Method
    }
}

