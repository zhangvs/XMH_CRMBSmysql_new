using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model.ims;

namespace XHD.BLL.ims
{
    /// <summary>
    /// ims_emp_score_details
    /// </summary>
    public partial class ims_emp_score_details
    {
        private readonly XHD.DAL.ims.ims_emp_score_details dal = new XHD.DAL.ims.ims_emp_score_details();
        public ims_emp_score_details()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ims.ims_emp_score_details model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ims.ims_emp_score_details model)
        {
            return dal.Update(model);
        }
          /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool UpdateScore(XHD.Model.ims.ims_emp_score_details model)
        {
            return dal.UpdateScore(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            return dal.Delete(id);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Deletes(int score_id)
        {
            return dal.Deletes(score_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ims.ims_emp_score_details GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.ims.ims_emp_score_details GetModelByCache(int id)
        {

            string CacheKey = "ims_emp_score_detailsModel-" + id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.ims.ims_emp_score_details)objModel;
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
        public List<XHD.Model.ims.ims_emp_score_details> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ims.ims_emp_score_details> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ims.ims_emp_score_details> modelList = new List<XHD.Model.ims.ims_emp_score_details>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ims.ims_emp_score_details model;
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
        /// 获取积分详情
        /// </summary>
        public DataSet GetScoreDetails(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetScoreDetails(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListTS(string strWhereOne, string strWhereTwo)
        {
            return dal.GetListTS(strWhereOne, strWhereTwo);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListT(string strWhereOne, string strWhereTwo)
        {
            return dal.GetListT(strWhereOne, strWhereTwo);
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

