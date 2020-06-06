using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS_BLL
{
    /// <summary>
    /// fkdw
    /// </summary>
    public partial class fkdw
    {
        private readonly FMS_DAL.fkdw dal = new FMS_DAL.fkdw();
        public fkdw()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string SKDW_MC, decimal ZTIDH, decimal ID, string XJ, string VIP)
        {
            return dal.Exists(SKDW_MC, ZTIDH, ID, XJ, VIP);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.fkdw model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.fkdw model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string SKDW_MC, decimal ZTIDH, decimal ID, string XJ, string VIP)
        {

            return dal.Delete(SKDW_MC, ZTIDH, ID, XJ, VIP);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public FMS_Model.fkdw GetModel(string SKDW_MC, decimal ZTIDH, decimal ID, string XJ, string VIP)
        {

            return dal.GetModel(SKDW_MC, ZTIDH, ID, XJ, VIP);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public FMS_Model.fkdw GetModelByCache(string SKDW_MC, decimal ZTIDH, decimal ID, string XJ, string VIP)
        {

            string CacheKey = "fkdwModel-" + SKDW_MC + ZTIDH + ID + XJ + VIP;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(SKDW_MC, ZTIDH, ID, XJ, VIP);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (FMS_Model.fkdw)objModel;
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
        public List<FMS_Model.fkdw> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<FMS_Model.fkdw> DataTableToList(DataTable dt)
        {
            List<FMS_Model.fkdw> modelList = new List<FMS_Model.fkdw>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                FMS_Model.fkdw model;
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

        ///// <summary>
        ///// 分页获取数据列表
        ///// </summary>
        //public int GetRecordCount(string strWhere)
        //{
        //    return dal.GetRecordCount(strWhere);
        //}
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
