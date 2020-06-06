using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;

namespace XHD.BLL
{
    public partial class HJ_Phone_RecordsManager
    {
        private readonly XHD.DAL.HJ_Phone_RecordsService dal = new XHD.DAL.HJ_Phone_RecordsService();

        public HJ_Phone_RecordsManager()
        { }

        #region  Method
        /// <summary>
        /// 新增一条记录
        /// </summary>
        public bool Add(XHD.Model.HJ_Phone_RecordsInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.HJ_Phone_RecordsInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 批量转客源
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update_batch(XHD.Model.CRM_Customer model, string strWhere)
        {
            return dal.Update_batch(model, strWhere);
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
        public DataSet GetOneList(string strWhere)
        {
            return dal.GetOneList(strWhere);
        }

        public DataTable GetAll(string strWhere)
        {
            return dal.GetAll(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.CRM_Customer> DataTableToList(DataTable dt)
        {
            List<XHD.Model.CRM_Customer> modelList = new List<XHD.Model.CRM_Customer>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.CRM_Customer model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new XHD.Model.CRM_Customer();
                    if (dt.Rows[n]["id"] != null && dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["Serialnumber"] != null && dt.Rows[n]["Serialnumber"].ToString() != "")
                    {
                        model.Serialnumber = dt.Rows[n]["Serialnumber"].ToString();
                    }
                    if (dt.Rows[n]["Customer"] != null && dt.Rows[n]["Customer"].ToString() != "")
                    {
                        model.Customer = dt.Rows[n]["Customer"].ToString();
                    }
                    if (dt.Rows[n]["address"] != null && dt.Rows[n]["address"].ToString() != "")
                    {
                        model.address = dt.Rows[n]["address"].ToString();
                    }
                    if (dt.Rows[n]["tel"] != null && dt.Rows[n]["tel"].ToString() != "")
                    {
                        model.tel = dt.Rows[n]["tel"].ToString();
                    }
                    if (dt.Rows[n]["fax"] != null && dt.Rows[n]["fax"].ToString() != "")
                    {
                        model.fax = dt.Rows[n]["fax"].ToString();
                    }
                    if (dt.Rows[n]["site"] != null && dt.Rows[n]["site"].ToString() != "")
                    {
                        model.site = dt.Rows[n]["site"].ToString();
                    }
                    if (dt.Rows[n]["industry"] != null && dt.Rows[n]["industry"].ToString() != "")
                    {
                        model.industry = dt.Rows[n]["industry"].ToString();
                    }
                    if (dt.Rows[n]["Provinces_id"] != null && dt.Rows[n]["Provinces_id"].ToString() != "")
                    {
                        model.Provinces_id = int.Parse(dt.Rows[n]["Provinces_id"].ToString());
                    }
                    if (dt.Rows[n]["Provinces"] != null && dt.Rows[n]["Provinces"].ToString() != "")
                    {
                        model.Provinces = dt.Rows[n]["Provinces"].ToString();
                    }
                    if (dt.Rows[n]["City_id"] != null && dt.Rows[n]["City_id"].ToString() != "")
                    {
                        model.City_id = int.Parse(dt.Rows[n]["City_id"].ToString());
                    }
                    if (dt.Rows[n]["City"] != null && dt.Rows[n]["City"].ToString() != "")
                    {
                        model.City = dt.Rows[n]["City"].ToString();
                    }
                    if (dt.Rows[n]["CustomerType_id"] != null && dt.Rows[n]["CustomerType_id"].ToString() != "")
                    {
                        model.CustomerType_id = int.Parse(dt.Rows[n]["CustomerType_id"].ToString());
                    }
                    if (dt.Rows[n]["CustomerType"] != null && dt.Rows[n]["CustomerType"].ToString() != "")
                    {
                        model.CustomerType = dt.Rows[n]["CustomerType"].ToString();
                    }
                    if (dt.Rows[n]["CustomerLevel_id"] != null && dt.Rows[n]["CustomerLevel_id"].ToString() != "")
                    {
                        model.CustomerLevel_id = int.Parse(dt.Rows[n]["CustomerLevel_id"].ToString());
                    }
                    if (dt.Rows[n]["CustomerLevel"] != null && dt.Rows[n]["CustomerLevel"].ToString() != "")
                    {
                        model.CustomerLevel = dt.Rows[n]["CustomerLevel"].ToString();
                    }
                    if (dt.Rows[n]["CustomerSource_id"] != null && dt.Rows[n]["CustomerSource_id"].ToString() != "")
                    {
                        model.CustomerSource_id = int.Parse(dt.Rows[n]["CustomerSource_id"].ToString());
                    }
                    if (dt.Rows[n]["CustomerSource"] != null && dt.Rows[n]["CustomerSource"].ToString() != "")
                    {
                        model.CustomerSource = dt.Rows[n]["CustomerSource"].ToString();
                    }
                    if (dt.Rows[n]["DesCripe"] != null && dt.Rows[n]["DesCripe"].ToString() != "")
                    {
                        model.DesCripe = dt.Rows[n]["DesCripe"].ToString();
                    }
                    if (dt.Rows[n]["Remarks"] != null && dt.Rows[n]["Remarks"].ToString() != "")
                    {
                        model.Remarks = dt.Rows[n]["Remarks"].ToString();
                    }
                    if (dt.Rows[n]["Department_id"] != null && dt.Rows[n]["Department_id"].ToString() != "")
                    {
                        model.Department_id = int.Parse(dt.Rows[n]["Department_id"].ToString());
                    }
                    if (dt.Rows[n]["Department"] != null && dt.Rows[n]["Department"].ToString() != "")
                    {
                        model.Department = dt.Rows[n]["Department"].ToString();
                    }
                    if (dt.Rows[n]["Employee_id"] != null && dt.Rows[n]["Employee_id"].ToString() != "")
                    {
                        model.Employee_id = int.Parse(dt.Rows[n]["Employee_id"].ToString());
                    }
                    if (dt.Rows[n]["Employee"] != null && dt.Rows[n]["Employee"].ToString() != "")
                    {
                        model.Employee = dt.Rows[n]["Employee"].ToString();
                    }
                    if (dt.Rows[n]["privatecustomer"] != null && dt.Rows[n]["privatecustomer"].ToString() != "")
                    {
                        model.privatecustomer = dt.Rows[n]["privatecustomer"].ToString();
                    }
                    if (dt.Rows[n]["lastfollow"] != null && dt.Rows[n]["lastfollow"].ToString() != "")
                    {
                        model.lastfollow = DateTime.Parse(dt.Rows[n]["lastfollow"].ToString());
                    }
                    if (dt.Rows[n]["Create_id"] != null && dt.Rows[n]["Create_id"].ToString() != "")
                    {
                        model.Create_id = int.Parse(dt.Rows[n]["Create_id"].ToString());
                    }
                    if (dt.Rows[n]["Create_name"] != null && dt.Rows[n]["Create_name"].ToString() != "")
                    {
                        model.Create_name = dt.Rows[n]["Create_name"].ToString();
                    }
                    if (dt.Rows[n]["Create_date"] != null && dt.Rows[n]["Create_date"].ToString() != "")
                    {
                        model.Create_date = DateTime.Parse(dt.Rows[n]["Create_date"].ToString());
                    }
                    if (dt.Rows[n]["isDelete"] != null && dt.Rows[n]["isDelete"].ToString() != "")
                    {
                        model.isDelete = int.Parse(dt.Rows[n]["isDelete"].ToString());
                    }
                    if (dt.Rows[n]["Delete_time"] != null && dt.Rows[n]["Delete_time"].ToString() != "")
                    {
                        model.Delete_time = DateTime.Parse(dt.Rows[n]["Delete_time"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
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
        public DataSet GetListOnePage(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListOnePage(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetListProc(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetListProc(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        //批量处理所有数据
        public bool UpdateProcess(string strWhere)
        {
            return dal.UpdateProcess(strWhere);
        }

        /// <summary>
        /// 导出当前页
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <param name="Total"></param>
        /// <returns></returns>
        public DataSet ToExcelOnePage(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.ToExcelOnePage(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// ToExcel
        /// </summary>
        public DataSet ToExcel(string strWhere)
        {
            return dal.ToExcel(strWhere);
        }
        //年度电话统计
        public DataSet Phone_year(string items, int year, string where)
        {
            return dal.Phone_year(items, year, where);
        }

        public DataSet Phone_year(string items, int year, string where, bool temp)
        {
            return dal.Phone_year(items, year, where, temp);
        }

        //年度电话统计
        public DataSet Phone_month(string items, int year, int month, string where)
        {
            return dal.Phone_month(items, year, month, where);
        }

        public DataSet Phone_month(string items, int year, int month, string where, bool temp)
        {
            return dal.Phone_month(items, year, month, where, temp);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListPhone(string strWhere)
        {
            return dal.GetListPhone(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.HJ_Phone_RecordsInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetListPhone(strWhere);
            return DataTableToListPhone(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.HJ_Phone_RecordsInfo> DataTableToListPhone(DataTable dt)
        {
            List<XHD.Model.HJ_Phone_RecordsInfo> modelList = new List<XHD.Model.HJ_Phone_RecordsInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.HJ_Phone_RecordsInfo model;
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
        #endregion  Method
    }
}
