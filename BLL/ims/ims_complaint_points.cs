using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model.ims;

namespace XHD.BLL.ims
{
    /// <summary>
    /// ims_complaint_points
    /// </summary>
    public partial class ims_complaint_points
    {
        private readonly XHD.DAL.ims.ims_complaint_points dal = new XHD.DAL.ims.ims_complaint_points();
        public ims_complaint_points()
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
        public bool Add(XHD.Model.ims.ims_complaint_points model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ims.ims_complaint_points model)
        {
            return dal.Update(model);
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
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        //受理
        public bool UpdateState(int id)
        {
            return dal.UpdateState(id);
        }

        
        //受理完成
        public bool finish(int id, string remark, DataSet ds, Model.ims.ims_emp_score modelScore, string scoreApply, string score)
        {
            return dal.finish(id, remark, ds, modelScore, scoreApply,score);
        }
        

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ims.ims_complaint_points GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.ims.ims_complaint_points GetModelByCache(int id)
        {

            string CacheKey = "ims_complaint_pointsModel-" + id;
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
            return (XHD.Model.ims.ims_complaint_points)objModel;
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
        public DataSet GetLists(string strWhere)
        {
            return dal.GetLists(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ims.ims_complaint_points> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ims.ims_complaint_points> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ims.ims_complaint_points> modelList = new List<XHD.Model.ims.ims_complaint_points>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ims.ims_complaint_points model;
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
        /// 分页获取我的申请投诉及被投诉数据列表
        /// </summary>
        public DataSet GetListApply(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListApply(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 分页获取投诉数据列表
        /// </summary>
        public DataSet GetListApprove(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListApprove(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
