using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model.ims;

namespace XHD.BLL.ims
{
    /// <summary>
    /// ims_emp_score
    /// </summary>
    public partial class ims_emp_score
    {
        private readonly XHD.DAL.ims.ims_emp_score dal = new XHD.DAL.ims.ims_emp_score();
        public ims_emp_score()
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
        public int Add(XHD.Model.ims.ims_emp_score model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ims.ims_emp_score model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 修改积分
        /// </summary>
        public bool UpdateScore(int id,decimal score)
        {
            return dal.UpdateScore(id,score);
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

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ims.ims_emp_score GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.ims.ims_emp_score GetModelByCache(int id)
        {

            string CacheKey = "ims_emp_scoreModel-" + id;
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
            return (XHD.Model.ims.ims_emp_score)objModel;
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
        public List<XHD.Model.ims.ims_emp_score> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ims.ims_emp_score> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ims.ims_emp_score> modelList = new List<XHD.Model.ims.ims_emp_score>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ims.ims_emp_score model;
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
        /// 查询积分
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public string GetScore(string strWhere)
        {
            return dal.GetScore(strWhere);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListNew(int PageSize, int PageIndex, string strWhere,string strWhereOne,string strWhereTwo, string filedOrder, out string Total)
        {
            return dal.GetListNew(PageSize, PageIndex, strWhere, strWhereOne, strWhereTwo,filedOrder, out Total);
        }

        /// <summary>
        /// 统计积分列表
        /// </summary>
        public DataSet GetStatistics(int PageSize, int PageIndex, string strWhere, string strWhereOne, string strWhereTwo, string strWhereThree,string strWhereFoure, string strWhereFive,string filedOrder, out string Total)
        {
            return dal.GetStatistics(PageSize, PageIndex, strWhere, strWhereOne, strWhereTwo, strWhereThree,strWhereFoure,strWhereFive, filedOrder, out Total);
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetSearch(int PageSize, int PageIndex, string strWhere, string strWhereOne,string strWhereTwo,string filedOrder, out string Total)
        {
            return dal.GetSearch(PageSize, PageIndex, strWhere,strWhereOne,strWhereTwo, filedOrder, out Total);
        }


        /// <summary>
        /// 获取出勤数据列表 GetAttend
        /// </summary>
        public DataSet GetAttend(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetAttend(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }


        /// <summary>
        /// 获取SSN勤数据列表 GetSSN
        /// </summary>
        public DataSet GetSSN(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetSSN(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetSSNDetail(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetSSNDetail(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

         /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet gridCheckInfo(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.gridCheckInfo(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }
        

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}