using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// scm_article
    /// </summary>
    public partial class scm_article
    {
        private readonly XHD.DAL.scm_article dal = new XHD.DAL.scm_article();
        public scm_article()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int article_id)
        {
            return dal.Exists(article_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(SCM.Model.scm_article model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(SCM.Model.scm_article model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int article_id)
        {

            return dal.Delete(article_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string article_idlist)
        {
            return dal.DeleteList(article_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public SCM.Model.scm_article GetModel(int article_id)
        {

            return dal.GetModel(article_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public SCM.Model.scm_article GetModelByCache(int article_id)
        {

            string CacheKey = "scm_articleModel-" + article_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(article_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (SCM.Model.scm_article)objModel;
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
        public List<SCM.Model.scm_article> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<SCM.Model.scm_article> DataTableToList(DataTable dt)
        {
            List<SCM.Model.scm_article> modelList = new List<SCM.Model.scm_article>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                SCM.Model.scm_article model;
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

        //最新信息审核页面加载
        public DataSet GetList(int PageSize, int startIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, startIndex, strWhere, filedOrder, out Total);
        }


        /// <summary>
        /// 批量审核
        /// </summary>
        /// <param name="id"></param>
        /// <param name="empId"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool Audit(string id, int empId, int time)
        {
            return dal.Audit(id, empId, time);
        }

        
        /// <summary>
        /// 单条审核
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool AuditOne(int id, int empId, int time)
        {
            return dal.AuditOne(id, empId, time);
        }
        

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

