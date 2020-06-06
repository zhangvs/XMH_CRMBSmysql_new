using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
using System.Text;
namespace XHD.BLL
{
    /// <summary>
    /// Sys_Menu
    /// </summary>
    public partial class Sys_Menu
    {
        private readonly XHD.DAL.Sys_Menu dal = new XHD.DAL.Sys_Menu();
        public Sys_Menu()
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
        public bool Exists(int Menu_id)
        {
            return dal.Exists(Menu_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.Sys_Menu model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.Sys_Menu model)
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
        public bool Delete(int Menu_id)
        {

            return dal.Delete(Menu_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Menu_idlist)
        {
            return dal.DeleteList(Menu_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.Sys_Menu GetModel(int Menu_id)
        {

            return dal.GetModel(Menu_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.Sys_Menu GetModelByCache(int Menu_id)
        {

            string CacheKey = "Sys_MenuModel-" + Menu_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Menu_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.Sys_Menu)objModel;
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
        public DataSet GetLists(int Top, string strWhere, string filedOrder)
        {
            return dal.GetLists(Top, strWhere, filedOrder);
        }

        #region 访问权限
        private string GetRoleidByUID(string uid)
        {
            if (string.IsNullOrEmpty(uid))
            {
                return "(0)";
            }
            else
            {
                BLL.Sys_role_emp rm = new BLL.Sys_role_emp();
                DataSet ds = rm.GetList("empID=" + int.Parse(uid));
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string RoleIDs = "(";
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        RoleIDs += ds.Tables[0].Rows[i]["RoleID"].ToString() + ",";
                    }
                    RoleIDs = RoleIDs.Substring(0, RoleIDs.Length - 1);
                    RoleIDs += ")";
                    return RoleIDs;
                }
                else
                {
                    return "(0)";
                }
            }
        }

        public string GetDataAuthByid(string optionid, string option, string empid, string factory_Id)
        {
            string RoleIDs = GetRoleidByUID(empid);
            BLL.Sys_data_authority sda = new BLL.Sys_data_authority();
            DataSet ds = sda.GetList(" option_id=" + optionid + " and Factory_Id='" + factory_Id + "' and Role_id in " + RoleIDs);

            int temp = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (int.Parse(ds.Tables[0].Rows[i][option].ToString()) > temp)
                        temp = int.Parse(ds.Tables[0].Rows[i][option].ToString());
                }
                //return temp.ToString();
            }

            BLL.hr_employee emp = new BLL.hr_employee();
            DataSet ds1 = emp.GetList("Factory_Id='" + factory_Id + "' and id=" + empid);

            //if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
            //{

            if (ds1.Tables[0].Rows[0]["uid"].ToString() == "admin")
                return "all";
            switch (temp)
            {
                case 0: return "none";
                case 1: return "my:" + empid;
                case 2: return "dep:" + ds1.Tables[0].Rows[0]["d_id"].ToString();
                case 3: return "depall:" + ds1.Tables[0].Rows[0]["d_id"].ToString();
                case 4: return "all";
            }
            return "";
            //}
            //else
            //{
            //    return "";
            //}
        }

        private string DataAuth(string uid, string factory_Id)
        {
            //权限
            BLL.hr_employee emp = new BLL.hr_employee();
            DataSet dsemp = emp.GetList("Factory_Id='" + factory_Id + "' and ID=" + int.Parse(uid));

            string returntxt = " and 1=1";
            if (dsemp.Tables[0].Rows.Count > 0)
            {
                if (dsemp.Tables[0].Rows[0]["uid"].ToString() != "admin")
                {
                    string txt = GetDataAuthByid("1", "Sys_view", uid, factory_Id);

                    string[] arr = txt.Split(':');

                    switch (arr[0])
                    {
                        case "none": returntxt = " and 1=2 ";
                            break;
                        case "my":
                            returntxt = " and ( privatecustomer='公客' or BeSeats_id=" + int.Parse(arr[1]) + ")";
                            break;
                        case "dep":
                            if (string.IsNullOrEmpty(arr[1]))
                                returntxt = " and ( privatecustomer='公客' or BeSeats_id=" + int.Parse(uid) + ")";
                            else
                                returntxt = " and ( privatecustomer='公客' or BeSeats_depid=" + int.Parse(arr[1]) + ")";
                            break;
                        case "depall":
                            BLL.hr_department dep = new BLL.hr_department();
                            string serchtxt = null;
                            serchtxt += "Factory_Id='" + factory_Id + "'";
                            DataSet ds = dep.GetAllList(serchtxt);
                            string deptask = GetDepTask(int.Parse(arr[1]), ds.Tables[0]);
                            string intext = arr[1] + "," + deptask;
                            returntxt = " and ( privatecustomer='公客' or BeSeats_depid in (" + intext.TrimEnd(',') + "))";
                            break;
                    }
                }
            }
            return returntxt;
        }

        private string GetDepTask(int Id, DataTable table)
        {
            DataRow[] rows = table.Select("parentid=" + Id.ToString());

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                str.Append(row["id"] + ",");
                if (GetDepTask((int)row["id"], table).Length > 0)
                    str.Append(GetDepTask((int)row["id"], table));
            }
            return str.ToString();
        }
        #endregion
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetListCRM(int Top, string strWhere, string filedOrder, string strEmp_id, string strFactoryId)
        {
            DataSet ds = dal.GetListCRM(Top, strWhere, filedOrder, strEmp_id, strFactoryId);
            BLL.CRM_Customer customer = new BLL.CRM_Customer();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //全部客户(权限内)
                string strTemp = customer.GetCount("dataAllCus", " Factory_Id='" + strFactoryId + "'" + " and privatecustomer='私客'" + " and isDelete=0 " + DataAuth(strEmp_id.ToString(), strFactoryId)).ToString();//
                //本月未联系(权限内)
                string sqlMonth = " lastfollow<DATE_ADD(curdate(),interval -day(curdate())+1 day)" + DataAuth(strEmp_id.ToString(), strFactoryId)
                                    + " and Factory_Id='" + strFactoryId + "' and privatecustomer='私客' and isDelete=0";
                string strTemp1 = customer.GetCount("dataAllCus", sqlMonth).ToString();//

                //当天联系(权限内)
                string sqlDay = " date_format(lastfollow,'%Y-%m-%d')=curdate()" + DataAuth(strEmp_id.ToString(), strFactoryId) +
                                    " and Factory_Id='" + strFactoryId + "' and privatecustomer='私客' and isDelete=0";
                string strTemp2 = customer.GetCount("dataAllCus", sqlDay).ToString();

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    switch (item["Menu_name"].ToString())
                    {
                        case "全部客户(权限内)":
                            item["count1"] = strTemp;
                            break;
                        case "本月未联系(权限内)":
                            item["count1"] = strTemp1;
                            break;
                        case "当天联系(权限内)":
                            item["count1"] = strTemp2;
                            break;
                        default:
                            break;
                    }
                }
            }
            return ds;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.Sys_Menu> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.Sys_Menu> DataTableToList(DataTable dt)
        {
            List<XHD.Model.Sys_Menu> modelList = new List<XHD.Model.Sys_Menu>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.Sys_Menu model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new XHD.Model.Sys_Menu();
                    if (dt.Rows[n]["Menu_id"] != null && dt.Rows[n]["Menu_id"].ToString() != "")
                    {
                        model.Menu_id = int.Parse(dt.Rows[n]["Menu_id"].ToString());
                    }
                    if (dt.Rows[n]["Menu_name"] != null && dt.Rows[n]["Menu_name"].ToString() != "")
                    {
                        model.Menu_name = dt.Rows[n]["Menu_name"].ToString();
                    }
                    if (dt.Rows[n]["parentid"] != null && dt.Rows[n]["parentid"].ToString() != "")
                    {
                        model.parentid = int.Parse(dt.Rows[n]["parentid"].ToString());
                    }
                    if (dt.Rows[n]["parentname"] != null && dt.Rows[n]["parentname"].ToString() != "")
                    {
                        model.parentname = dt.Rows[n]["parentname"].ToString();
                    }
                    if (dt.Rows[n]["App_id"] != null && dt.Rows[n]["App_id"].ToString() != "")
                    {
                        model.App_id = int.Parse(dt.Rows[n]["App_id"].ToString());
                    }
                    if (dt.Rows[n]["Menu_url"] != null && dt.Rows[n]["Menu_url"].ToString() != "")
                    {
                        model.Menu_url = dt.Rows[n]["Menu_url"].ToString();
                    }
                    if (dt.Rows[n]["Menu_icon"] != null && dt.Rows[n]["Menu_icon"].ToString() != "")
                    {
                        model.Menu_icon = dt.Rows[n]["Menu_icon"].ToString();
                    }
                    if (dt.Rows[n]["Menu_handler"] != null && dt.Rows[n]["Menu_handler"].ToString() != "")
                    {
                        model.Menu_handler = dt.Rows[n]["Menu_handler"].ToString();
                    }
                    if (dt.Rows[n]["Menu_order"] != null && dt.Rows[n]["Menu_order"].ToString() != "")
                    {
                        model.Menu_order = int.Parse(dt.Rows[n]["Menu_order"].ToString());
                    }
                    if (dt.Rows[n]["Menu_type"] != null && dt.Rows[n]["Menu_type"].ToString() != "")
                    {
                        model.Menu_type = dt.Rows[n]["Menu_type"].ToString();
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

