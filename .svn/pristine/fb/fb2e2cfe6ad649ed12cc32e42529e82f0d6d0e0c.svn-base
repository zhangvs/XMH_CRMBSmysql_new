using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// scm_authority_dtcolumn
    /// </summary>
    public partial class scm_authority_dtcolumn
    {
        private readonly XHD.DAL.scm_authority_dtcolumn dal = new XHD.DAL.scm_authority_dtcolumn();
        public scm_authority_dtcolumn()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string factory_Id, int suppliers_id, string Menu_ids, string column_ids, int Create_id, DateTime Create_date)
        {
            return dal.Exists(factory_Id, suppliers_id, Menu_ids, column_ids, Create_id, Create_date);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_authority_dtcolumn model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Adds(XHD.Model.scm_authority_dtcolumn model)
        {
            return dal.Adds(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.scm_authority_dtcolumn model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string factory_Id, int suppliers_id, string Menu_ids, string column_ids, int Create_id, DateTime Create_date)
        {

            return dal.Delete(factory_Id, suppliers_id, Menu_ids, column_ids, Create_id, Create_date);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.scm_authority_dtcolumn GetModel(string factory_Id, int suppliers_id, string Menu_ids, string column_ids, int Create_id, DateTime Create_date)
        {

            return dal.GetModel(factory_Id, suppliers_id, Menu_ids, column_ids, Create_id, Create_date);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.scm_authority_dtcolumn GetModelByCache(string factory_Id, int suppliers_id, string Menu_ids, string column_ids, int Create_id, DateTime Create_date)
        {

            string CacheKey = "scm_authority_dtcolumnModel-" + factory_Id + suppliers_id + Menu_ids + column_ids + Create_id + Create_date;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(factory_Id, suppliers_id, Menu_ids, column_ids, Create_id, Create_date);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.scm_authority_dtcolumn)objModel;
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
        public DataSet GetListColumn(string supply_id, string factory_id, string app)
        {

            return dal.GetListColumn(supply_id, factory_id, app);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_authority_dtcolumn> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_authority_dtcolumn> DataTableToList(DataTable dt)
        {
            List<XHD.Model.scm_authority_dtcolumn> modelList = new List<XHD.Model.scm_authority_dtcolumn>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.scm_authority_dtcolumn model;
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteWhere(string suppliers_id, string menu_ids)
        {
            return dal.DeleteWhere(suppliers_id, menu_ids);
        }

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

