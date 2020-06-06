using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// scm_purchase_list
    /// </summary>
    public partial class scm_purchase_list
    {
        private readonly XHD.DAL.scm_purchase_list dal = new XHD.DAL.scm_purchase_list();
        public scm_purchase_list()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            return dal.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_purchase_list model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.scm_purchase_list model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Alter(XHD.Model.scm_purchase_list model)
        {
            return dal.Alter(model);
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
        public XHD.Model.scm_purchase_list GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.scm_purchase_list GetModelByCache(int Id)
        {

            string CacheKey = "scm_purchase_listModel-" + Id;
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
            return (XHD.Model.scm_purchase_list)objModel;
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
        public List<XHD.Model.scm_purchase_list> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_purchase_list> DataTableToList(DataTable dt)
        {
            List<XHD.Model.scm_purchase_list> modelList = new List<XHD.Model.scm_purchase_list>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.scm_purchase_list model;
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
        /// 是否存在该记录
        /// </summary>
        public bool ExistsRecord(string strWhere)
        {
            return dal.ExistsRecord(strWhere);
        }

        //获取数据--采购详情
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string sqlOne, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, sqlOne,filedOrder, out Total);
        }

        //获取数据--采购详情主订单号查询产品、供应商信息
        public DataSet GetSupplyInfoList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetSupplyInfoList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }
        


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

