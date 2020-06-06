using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
namespace XHD.BLL
{
    /// <summary>
    /// ecs_goods
    /// </summary>
    public partial class ecs_goods
    {
        private readonly XHD.DAL.ecs_goods dal = new XHD.DAL.ecs_goods();
        public ecs_goods()
        { }

        #region  BasicMethod
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int goods_id)
        {
            return dal.Exists(goods_id);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Add(XHD.Model.ecs_goods model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Update(XHD.Model.scm_supply_goods model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public bool Delete(int goods_id)
        {

            return dal.Delete(goods_id);
        }
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public bool DeleteList(string goods_idlist)
        {
            return dal.DeleteList(goods_idlist);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public XHD.Model.ecs_goods GetModel(int goods_id)
        {

            return dal.GetModel(goods_id);
        }

        public XHD.Model.stockMolde GetModelToStock(int goods_id)
        {

            return dal.GetModelToStock(goods_id);
        }

        /// <summary>
        /// �õ�һ������ʵ�壬�ӻ�����
        /// </summary>
        public XHD.Model.ecs_goods GetModelByCache(int goods_id)
        {

            string CacheKey = "ecs_goodsModel-" + goods_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(goods_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.ecs_goods)objModel;
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<XHD.Model.ecs_goods> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<XHD.Model.ecs_goods> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ecs_goods> modelList = new List<XHD.Model.ecs_goods>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ecs_goods model;
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
        /// ��������б�
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        /// <summary>
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }


        /// <summary>
        /// ����
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool RelatedGoods(string goodsId, string supplyId)
        {
            return dal.RelatedGoods(goodsId, supplyId);
        }

        /// <summary>
        /// ���
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="supplyId"></param>
        /// <returns></returns>
        public bool UnRelatedGoods(string goodsId, string supplyId)
        {
            return dal.UnRelatedGoods(goodsId, supplyId);
        }

        /// <summary>
        /// ���ݹ�Ӧ�̻�ȡ��Ʒ��Ϣ
        /// </summary>
        public DataSet GetListBySupply(int PageSize, int PageIndex, string strWhere, string strWhere1, string children, string filedOrder, out string Total)
        {
            return dal.GetListBySupply(PageSize, PageIndex, strWhere, strWhere1, children, filedOrder, out Total);
        }

        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        public int GetProductCount(string strWhere, string strWhere1, string children, string children1, string type)
        {
            return dal.GetProductCount(strWhere, strWhere1, children, children1, type);
        }
        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

