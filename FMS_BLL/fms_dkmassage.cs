using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using FMS_Model;

namespace FMS_BLL
{
    /// <summary>
    /// fms_dkmassage
    /// </summary>
    public partial class fms_dkmassage
    {
        private readonly FMS_DAL.fms_dkmassage dal = new FMS_DAL.fms_dkmassage();
        public fms_dkmassage()
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
        public int Add(FMS_Model.fms_dkmassage model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.fms_dkmassage model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Updatee(FMS_Model.fms_dkmassage model)
        {
            return dal.Updatee(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Updates(FMS_Model.fms_dkmassage model)
        {
            return dal.Updates(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Hand(FMS_Model.fms_dkmassage model)
        {
            return dal.Hand(model);
        }
        

        /// <summary>
        /// 认款
        /// </summary>
        public bool KnowKuan(int flag,FMS_Model.fms_dkmassage model)
        {
            return dal.KnowKuan(flag,model);
        }


        /// <summary>
        ///删除
        /// </summary>
        public bool DelKuan(FMS_Model.fms_dkmassage  mModel, FMS_Model.shop_progress_payments progress)
        {
            return dal.DelKuan(mModel, progress);
        }

        //批量删除
        public bool DelAllKuan(string idList, FMS_Model.fms_dkmassage mModel)
        {
            return dal.DelAllKuan(idList, mModel);
        }

        /// <summary>
        /// 重新认款
        /// </summary>
        public bool KnowKuans(FMS_Model.fms_dkmassage model, FMS_Model.shop_progress_payments progress)
        {
            return dal.KnowKuans(model, progress);
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
        public bool Del(FMS_Model.fms_dkmassage mModel)
        {
            return dal.Del(mModel);
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
        public FMS_Model.fms_dkmassage GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.fms_dkmassage GetModelByCache(int id)
        {

            string CacheKey = "fms_dkmassageModel-" + id;
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
            return (FMS_Model.fms_dkmassage)objModel;
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
        public DataSet GetListBank(string strWhere)
        {
            return dal.GetListBank(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListC(string strWhere)
        {
            return dal.GetListC(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.fms_dkmassage> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.fms_dkmassage> DataTableToList(DataTable dt)
        {
            List<FMS_Model.fms_dkmassage> modelList = new List<FMS_Model.fms_dkmassage>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.fms_dkmassage model;
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
        /// 加载公司户/个人户待认款信息
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


