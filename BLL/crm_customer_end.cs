using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    /// <summary>
    /// crm_customer_end
    /// </summary>
    public partial class crm_customer_end
    {
        private readonly XHD.DAL.crm_customer_end dal = new XHD.DAL.crm_customer_end();
        public crm_customer_end()
        { }
        #region  BasicMethod
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
        public int Add(XHD.Model.crm_customer_end model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_customer_end model)
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
        /// 我的终端客户删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool Deletes(string id, int isDelete, string factory_Id, string time)
        {
            return dal.Deletes(id, isDelete, factory_Id, time);
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            return dal.DeleteList(idlist);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteListAll(string id, string factory_Id)
        {
            return dal.DeleteListAll(id, factory_Id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.crm_customer_end GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.crm_customer_end GetModelByCache(int id)
        {

            string CacheKey = "crm_customer_endModel-" + id;
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
            return (XHD.Model.crm_customer_end)objModel;
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
        public List<XHD.Model.crm_customer_end> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.crm_customer_end> DataTableToList(DataTable dt)
        {
            List<XHD.Model.crm_customer_end> modelList = new List<XHD.Model.crm_customer_end>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.crm_customer_end model;
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
        /// 我的终端客户列表分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListLink(string strWhere)
        {
            return dal.GetListLink(strWhere);
        }

        //客服分配终端客户
        public bool allot(string id, XHD.Model.crm_customer_end model)
        {
            return dal.allot(id, model);
        }

        ////分配终端客户给客服
        public bool publicAllot(string id, XHD.Model.crm_customer_end model)
        {
            return dal.publicAllot(id, model);
        }

        /// <summary>
        ///联系人获得数据列表
        /// </summary>
        public DataSet GetListContact(int PageSize, int PageIndex, string strWhere, string key, string filedOrder, out string Total)
        {
            return dal.GetListContact(PageSize, PageIndex, strWhere, key, filedOrder, out Total);
        }

        /// <summary>
        ///联系人获得数据列表
        /// </summary>
        public DataSet GetAllContact(string strWhere, string key)
        {
            return dal.GetAllContact(strWhere, key);
        }

        /// <summary>
        /// 公司电话联系电话获得数据列表
        /// </summary>
        public DataSet GetListByTel(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            return dal.GetListByTel(PageSize, PageIndex, strWhere1, strWhere2, filedOrder, out Total);
        }

        /// <summary>
        /// 根据综合查询获取客户信息
        /// </summary>
        public DataSet GetListSynthesis(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            return dal.GetListSynthesis(PageSize, PageIndex, strWhere1, strWhere2, filedOrder, out Total);
        }

        public DataSet GetListContactFollow(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListContactFollow(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 根据综合查询获取客户信息
        /// </summary>
        public DataSet GetListSynthesis(string strWhere1, string strWhere2)
        {
            return dal.GetListSynthesis(strWhere1, strWhere2); ;
        }

        /// <summary>
        /// 公司电话联系电话获得数据列表
        /// </summary>
        public DataSet GetAllListByTel(string strWhere1, string strWhere2)
        {
            return dal.GetAllListByTel(strWhere1, strWhere2); 
        }

        /// <summary>
        ///跟进内容获得数据
        /// </summary>
        public DataSet GetAllContactFollow(string strWhere)
        {
            return dal.GetAllContactFollow(strWhere); 
        }
        public DataSet Dealer_customer(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.Dealer_customer( PageSize,  PageIndex, strWhere,  filedOrder, out  Total); 
        }
        public DataSet Dealer_customer_all(int PageSize, int PageIndex, string strWhere,  string filedOrder, out string Total)
        {
            return dal.Dealer_customer_all(PageSize, PageIndex, strWhere, filedOrder, out  Total); 
        }

        /// <summary>
        /// 终端客户列表【权限内】
        /// </summary>
        public DataSet GetListCustomerEndAll(int PageSize, int PageIndex, string strWhere1, string strWhere2,string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListCustomerEndAll(PageSize, PageIndex, strWhere1, strWhere2,strWhere, filedOrder, out Total);
        }


        /// <summary>
        ///联系人获得数据列表
        /// </summary>
        public DataSet GetListContact(int PageSize, int PageIndex, string strWhere1, string strWhere2, string key,string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListContact(PageSize, PageIndex, strWhere1, strWhere2, key,strWhere, filedOrder, out Total);
        }


        //联系方式查询
        public DataSet GetListByTelAll(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            return dal.GetListByTelAll(PageSize, PageIndex, strWhere1, strWhere2, filedOrder, out Total);
        }


        /// <summary>
        /// 更新最后跟进
        /// </summary>
        public bool UpdateLastFollow(string id)
        {
            return dal.UpdateLastFollow(id); ;
        }

         //转为我的客户
        public bool ToMyClients(string factory_Id, string customerendId, int customerId, string idList)
        {
            return dal.ToMyClients(factory_Id,customerendId,customerId,idList);
        }

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
