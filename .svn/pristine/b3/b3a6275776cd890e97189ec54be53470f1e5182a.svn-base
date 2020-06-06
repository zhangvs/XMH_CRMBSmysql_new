using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// Sys_App
    /// </summary>
    public partial class scm_supply_app
    {
        private readonly XHD.DAL.scm_supply_app dal = new XHD.DAL.scm_supply_app();
        public scm_supply_app()
        { }
        #region  Method

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
        public int Add(XHD.Model.scm_supply_app model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.scm_supply_app model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 预删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool AdvanceDelete(int id, int isDelete, string time)
        {
            return dal.AdvanceDelete(id, isDelete, time);
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
        public XHD.Model.scm_supply_app GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.scm_supply_app GetModelByCache(int id)
        {

            string CacheKey = "Sys_AppModel-" + id;
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
            return (XHD.Model.scm_supply_app)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetListDt(string strWhere)
        {
            return dal.GetListDt(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_supply_app> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.scm_supply_app> DataTableToList(DataTable dt)
        {
            List<XHD.Model.scm_supply_app> modelList = new List<XHD.Model.scm_supply_app>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.scm_supply_app model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new XHD.Model.scm_supply_app();
                    if (dt.Rows[n]["id"] != null && dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["App_name"] != null && dt.Rows[n]["App_name"].ToString() != "")
                    {
                        model.App_name = dt.Rows[n]["App_name"].ToString();
                    }
                    if (dt.Rows[n]["App_order"] != null && dt.Rows[n]["App_order"].ToString() != "")
                    {
                        model.App_order = int.Parse(dt.Rows[n]["App_order"].ToString());
                    }
                    if (dt.Rows[n]["App_url"] != null && dt.Rows[n]["App_url"].ToString() != "")
                    {
                        model.App_url = dt.Rows[n]["App_url"].ToString();
                    }
                    if (dt.Rows[n]["App_handler"] != null && dt.Rows[n]["App_handler"].ToString() != "")
                    {
                        model.App_handler = dt.Rows[n]["App_handler"].ToString();
                    }
                    if (dt.Rows[n]["App_type"] != null && dt.Rows[n]["App_type"].ToString() != "")
                    {
                        model.App_type = dt.Rows[n]["App_type"].ToString();
                    }
                    if (dt.Rows[n]["App_icon"] != null && dt.Rows[n]["App_icon"].ToString() != "")
                    {
                        model.App_icon = dt.Rows[n]["App_icon"].ToString();
                    }
                    modelList.Add(model);
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

        #endregion  Method
    }
}
