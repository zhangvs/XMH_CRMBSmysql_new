using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace XHD.BLL
{
    public partial class CRM_CustomerEnd_End
    {
        private readonly XHD.DAL.CRM_CustomerEnd_End dal = new XHD.DAL.CRM_CustomerEnd_End();
        public CRM_CustomerEnd_End()
        { }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_customer_end model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 大经销商获取终端分页数据列表
        /// </summary>
        public DataSet GetListEnd(int PageSize, int PageIndex, string strWhere, string myfactory_id, string filedOrder, out string Total)
        {
            return dal.GetListEnd(PageSize, PageIndex, strWhere, myfactory_id, filedOrder, out Total);
        }

        /// <summary>
        /// 大经销商获取终端数据列表
        /// </summary>
        public DataSet GetListEnd(string strWhere, string myfactory_id)
        {
            return dal.GetListEnd(strWhere, myfactory_id);
        }

        /// <summary>
        /// 通过联系人姓名获取数据
        /// </summary>
        public DataSet GetListContact(int PageSize, int PageIndex, string strWhere, string myfactory_id, string filedOrder, out string Total)
        {
            return dal.GetListContact(PageSize, PageIndex, strWhere, myfactory_id, filedOrder, out Total);
        }

        /// <summary>
        /// 通过联系人姓名获取数据
        /// </summary>
        public DataSet GetListContact(string strWhere, string myfactory_id)
        {
            return dal.GetListContact(strWhere, myfactory_id);
        }
        ////分配终端客户给客服
        public bool publicAllot(string id, XHD.Model.crm_customer_end model)
        {
            return dal.publicAllot(id, model);
        }
    }
}
