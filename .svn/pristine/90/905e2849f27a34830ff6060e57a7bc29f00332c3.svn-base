using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// crm_set_pubpri_detail
    /// </summary>
    public partial class crm_set_pubpri_detail
    {
        private readonly XHD.DAL.crm_set_pubpri_detail dal = new XHD.DAL.crm_set_pubpri_detail();
        public crm_set_pubpri_detail()
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
        public bool Exists(int Id)
        {
            return dal.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_set_pubpri_detail model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_set_pubpri_detail model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update1(XHD.Model.crm_set_pubpri_detail model)
        {
            return dal.Update1(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool updateQtyUser(int detailid, int emp_Qty_used)
        {
            return dal.updateQtyUser(detailid, emp_Qty_used);
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
        public bool DeleteList1(string Idlist)
        {
            return dal.DeleteList1(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.crm_set_pubpri_detail GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.crm_set_pubpri_detail GetModelByCache(int Id)
        {

            string CacheKey = "crm_set_pubpri_detailModel-" + Id;
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
            return (XHD.Model.crm_set_pubpri_detail)objModel;
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
        public List<XHD.Model.crm_set_pubpri_detail> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.crm_set_pubpri_detail> DataTableToList(DataTable dt)
        {
            List<XHD.Model.crm_set_pubpri_detail> modelList = new List<XHD.Model.crm_set_pubpri_detail>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.crm_set_pubpri_detail model;
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
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }
        /// <summary>
        /// 分页获取数据列表，包括部门和人员
        /// </summary>
        public DataSet GetListAndDept(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            return dal.GetListAndDept(PageSize, PageIndex, strWhere1, strWhere2, filedOrder, out Total);
        }
        /// <summary>
        /// 获取某个时间段已经被分配的数量，不包括备操作人员
        /// </summary>
        public DataSet GetSum(string strWhere)
        {
            return dal.GetSum(strWhere);
        }

        /// <summary>
        /// 获取某个时间段已经抓取的客户数量
        /// </summary>
        public DataSet GetSumUse(string strWhere)
        {
            return dal.GetSumUse(strWhere);
        }

        /// <summary>
        /// 根据外键删除数据
        /// </summary>
        public bool DeleteByFK(int Id, string factory_id)
        {

            return dal.DeleteByFK(Id, factory_id);
        }

        #endregion  BasicMethod

    }
}

