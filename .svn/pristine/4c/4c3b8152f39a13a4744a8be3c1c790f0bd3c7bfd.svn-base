using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// scm_suppply_authority
    /// </summary>
    public partial class scm_suppply_authority
    {
        private readonly XHD.DAL.scm_suppply_authority dal = new XHD.DAL.scm_suppply_authority();
        public scm_suppply_authority()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Supply_Id, string Factory_Id, int user_id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {
            return dal.Exists(Supply_Id, Factory_Id, user_id, App_ids, Menu_ids, Button_ids, Create_id, Create_date);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_suppply_authority model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.scm_suppply_authority model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string strWhere)
        {

            return dal.Delete(strWhere);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.scm_suppply_authority GetModel(int Supply_Id, string Factory_Id, int user_id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {

            return dal.GetModel(Supply_Id, Factory_Id, user_id, App_ids, Menu_ids, Button_ids, Create_id, Create_date);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.scm_suppply_authority GetModelByCache(int Supply_Id, string Factory_Id, int user_id, string App_ids, string Menu_ids, string Button_ids, int Create_id, DateTime Create_date)
        {

            string CacheKey = "scm_suppply_authorityModel-" + Supply_Id + Factory_Id + user_id + App_ids + Menu_ids + Button_ids + Create_id + Create_date;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Supply_Id, Factory_Id, user_id, App_ids, Menu_ids, Button_ids, Create_id, Create_date);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.scm_suppply_authority)objModel;
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
        public List<XHD.Model.scm_suppply_authority> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_suppply_authority> DataTableToList(DataTable dt)
        {
            List<XHD.Model.scm_suppply_authority> modelList = new List<XHD.Model.scm_suppply_authority>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.scm_suppply_authority model;
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

