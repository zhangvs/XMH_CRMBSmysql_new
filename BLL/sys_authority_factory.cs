using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// sys_authority_factory
    /// </summary>
    public partial class sys_authority_factory
    {
        private readonly XHD.DAL.sys_authority_factory dal = new XHD.DAL.sys_authority_factory();
        public sys_authority_factory()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Factory_Id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {
            return dal.Exists(Factory_Id, App_ids, Menu_ids, Button_ids, Create_id, Create_date);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.sys_authority_factory model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.sys_authority_factory model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteWhere(string wherestr)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.DeleteWhere(wherestr);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Factory_Id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {

            return dal.Delete(Factory_Id, App_ids, Menu_ids, Button_ids, Create_id, Create_date);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.sys_authority_factory GetModel(string Factory_Id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {

            return dal.GetModel(Factory_Id, App_ids, Menu_ids, Button_ids, Create_id, Create_date);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.sys_authority_factory GetModelByCache(string Factory_Id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {

            string CacheKey = "sys_authority_factoryModel-" + Factory_Id + App_ids + Menu_ids + Button_ids + Create_id + Create_date;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Factory_Id, App_ids, Menu_ids, Button_ids, Create_id, Create_date);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.sys_authority_factory)objModel;
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
        public List<XHD.Model.sys_authority_factory> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.sys_authority_factory> DataTableToList(DataTable dt)
        {
            List<XHD.Model.sys_authority_factory> modelList = new List<XHD.Model.sys_authority_factory>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.sys_authority_factory model;
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
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

