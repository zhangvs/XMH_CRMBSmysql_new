/**  版本信息模板在安装目录下，可自行修改。
* Personal_Score.cs
*
* 功 能： N/A
* 类 名： Personal_Score
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/10/2 11:01:16   N/A    初版
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
    /// Personal_Score
    /// </summary>
    public partial class Personal_Score
    {
        private readonly XHD.DAL.Personal_Score dal = new XHD.DAL.Personal_Score();
        public Personal_Score()
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
        /// 是否存在该记录
        /// </summary>
        public bool ExistsDate(string strWhere)
        {
            return dal.ExistsDate(strWhere);
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
        /// 查询内容
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public string GetContent(string strWhere)
        {
            return dal.GetContent(strWhere);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.Personal_Score model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加积分
        /// </summary>
        public bool AddScore(XHD.Model.Personal_Score model,DataTable dt)
        {
            return dal.AddScore(model,dt);
        }


        /// <summary>
        /// 修改积分
        /// </summary>
        public bool AlertScore(XHD.Model.Personal_Score model, List<Model.Personal_Score> lstScore, DataTable dt)
        {
            return dal.AlertScore(model, lstScore, dt);
        }
        

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.Personal_Score model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 修改积分
        /// </summary>
        /// <param name="id"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public bool Alert(int id, string score, string content)
        {
            return dal.Alert(id, score, content);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int top)
        {
            return dal.GetList(top);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListPersonalScoreImg(string strWhere)
        {
            return dal.GetListPersonalScoreImg(strWhere);
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
        public XHD.Model.Personal_Score GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.Personal_Score GetModelByCache(int Id)
        {

            string CacheKey = "Personal_ScoreModel-" + Id;
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
            return (XHD.Model.Personal_Score)objModel;
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
        public string getSumScore(string strWhere)
        {
            return dal.getSumScore(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.Personal_Score> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.Personal_Score> DataTableToList(DataTable dt)
        {
            List<XHD.Model.Personal_Score> modelList = new List<XHD.Model.Personal_Score>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.Personal_Score model;
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
        /// 获得打分人信息
        /// </summary>
        public DataSet GetOperationInfo(string wherestr)
        {
            return dal.GetOperationInfo(wherestr);
        }
        /// <summary>
        /// 按打分人获取人员
        /// </summary>
        public DataSet GetUserInfo(string strWhere, string groupstr)
        {
            return dal.GetUserInfo(strWhere, groupstr);
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
        public DataSet GetSearch2(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetSearch2(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

      
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
        public DataSet GetListByPageForPhone(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListByPageForPhone(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }



        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetSearch(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetSearch(PageSize, PageIndex, strWhere, filedOrder, out Total);
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
