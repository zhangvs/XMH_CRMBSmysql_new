/**  版本信息模板在安装目录下，可自行修改。
* Sys_Task.cs
*
* 功 能： N/A
* 类 名： Sys_Task
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/10/3 17:32:36   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// Sys_Task
    /// </summary>
    public partial class Sys_Task
    {
        private readonly XHD.DAL.Sys_Task dal = new XHD.DAL.Sys_Task();
        public Sys_Task()
        { }
        #region  BasicMethod
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListTaskByEmpId(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListTaskByEmpId(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }


        /// <summary>
        /// 分页获取数据列表----根据部门及员工ID查询该员工所具有的任务项
        /// </summary>
        public DataSet GetTaskByDEID(int PageSize, int PageIndex, string strWhere,string empId,string depId, string filedOrder, out string Total)
        {
            return dal.GetTaskByDEID(PageSize, PageIndex, strWhere,empId,depId, filedOrder, out Total);
        }

        /// <summary>
        /// 获得数据列表  指定字段
        /// </summary>
        public DataSet GetOptionList(string factory_Id)
        {
            return dal.GetOptionList(factory_Id);
        }
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
        public int Add(XHD.Model.Sys_Task model)
        {
            return dal.Add(model);
        } 

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.Sys_Task model)
        {
            return dal.Update(model);
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

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.Sys_Task GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.Sys_Task GetModelByCache(int Id)
        {

            string CacheKey = "Sys_TaskModel-" + Id;
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
            return (XHD.Model.Sys_Task)objModel;
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
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.Sys_Task> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.Sys_Task> DataTableToList(DataTable dt)
        {
            List<XHD.Model.Sys_Task> modelList = new List<XHD.Model.Sys_Task>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.Sys_Task model;
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
        /// 获得数据列表  指定字段
        /// </summary>
        public DataSet GetOptionListById(int id, string factory_Id)
        {
            return dal.GetOptionListById(id, factory_Id);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet getTaskContent(int id)
        {
            return dal.getTaskContent(id);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListJoinDtype(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListJoinDtype(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 获取部门的任务项
        /// </summary>
        public DataSet GetListDep(int PageSize, int PageIndex, string strWhere, string depId, string filedOrder, out string Total)
        {
            return dal.GetListDep(PageSize, PageIndex, strWhere, depId,filedOrder, out Total);
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
