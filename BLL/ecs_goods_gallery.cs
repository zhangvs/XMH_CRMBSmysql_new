using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// ecs_goods_gallery
    /// </summary>
    public partial class ecs_goods_gallery
    {
        private readonly XHD.DAL.ecs_goods_gallery dal = new XHD.DAL.ecs_goods_gallery();
        public ecs_goods_gallery()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int img_id)
        {
            return dal.Exists(img_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_goods_gallery model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool AddCopy(XHD.Model.ecs_goods_gallery model)
        {
            return dal.AddCopy(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ecs_goods_gallery model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int goods_id)
        {

            return dal.Delete(goods_id);
        }
        public bool DeleteByGoodsId(int goods_id)
        {

            return dal.DeleteByGoodsId(goods_id);
        }

        public bool DeleteCopy(int goods_id)
        {

            return dal.DeleteCopy(goods_id);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string img_idlist)
        {
            return dal.DeleteList(img_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ecs_goods_gallery GetModel(int img_id)
        {

            return dal.GetModel(img_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.ecs_goods_gallery GetModelByCache(int img_id)
        {

            string CacheKey = "ecs_goods_galleryModel-" + img_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(img_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.ecs_goods_gallery)objModel;
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
        public DataSet GetListCopy(string strWhere)
        {
            return dal.GetListCopy(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ecs_goods_gallery> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ecs_goods_gallery> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ecs_goods_gallery> modelList = new List<XHD.Model.ecs_goods_gallery>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ecs_goods_gallery model;
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
        /// 向附表增加一条数据
        /// </summary>
        public bool AddCopy(int goods_id)
        {
            return dal.AddCopy(goods_id);
        }
        /// <summary>
        /// 附表同步到商城
        /// </summary>
        public bool CopyToShop(int goods_id)
        {
            return dal.CopyToShop(goods_id);
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

