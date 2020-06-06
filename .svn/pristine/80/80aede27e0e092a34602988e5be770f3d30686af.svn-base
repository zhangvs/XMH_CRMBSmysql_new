using DotNet.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using XHD.Common;

namespace SSN.DataSSN
{
    /// <summary>
    /// SSN_NewPage 的摘要说明
    /// </summary>
    public class SSN_NewPage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;
            var cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];

            XHD.BLL.ssn_art_menu menu = new XHD.BLL.ssn_art_menu();
            XHD.BLL.ssn_visit _visit = new XHD.BLL.ssn_visit();
            XHD.BLL.ssn_art _art = new XHD.BLL.ssn_art();
            //判断是否登录
            if (cookie == null)
            {
                DataSet ds = new DataSet();
                ds = menu.GetList("1=2");
                string strRe = XHD.Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(strRe);
                return;
            }

            var ticket = FormsAuthentication.Decrypt(cookie.Value);

            string CoockiesID = ticket.UserData;

            XHD.BLL.hr_employee emp = new XHD.BLL.hr_employee();
            int emp_id = int.Parse(CoockiesID);

            DataSet dsemp = emp.GetList("id=" + emp_id);

            XHD.Model.hr_employee employeeModel = emp.GetModel(emp_id); //当前员工

            string empname = string.Empty;
            string uid = string.Empty;
            string depid = string.Empty;
            string roletype = string.Empty;
            string factory_Id = string.Empty;
            if (employeeModel != null)
            {
                empname = employeeModel.name;            //员工姓名
                uid = employeeModel.uid;                 //员工Uid
                depid = employeeModel.d_id.ToString();   //员工所在部门
                factory_Id = employeeModel.factory_Id;   //员工所属工厂
                roletype = employeeModel.roletype.ToString();
            }
            //获取一级菜单
            if (request["Action"] == "GetSysMenu1")
            {
                #region
                DataSet ds = new DataSet();

                int appid = int.Parse(request["appid"]);

                if (dsemp.Tables[0].Rows.Count > 0)
                {
                    if (dsemp.Tables[0].Rows[0]["uid"].ToString() == "admin")
                    {
                        ds = menu.GetList(0, "App_id=" + appid + " and parentid=0", "Menu_order");
                    }
                    else
                    {
                        DataSSN.SSN_GetAuthorityByUid getauth = new DataSSN.SSN_GetAuthorityByUid();
                        string menus = getauth.GetAuthority(emp_id.ToString(), "Menus");
                        //ds = menu.GetList(0, "App_id=" + appid + " and Menu_id in " + menus + " and menu_type='aft'", "Menu_order");
                        ds = menu.GetList(0, "App_id=" + appid + " and Id in " + menus + "  and parentid=0", "Menu_order");
                    }
                }

                string strRe = XHD.Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(strRe);
                #endregion
            }

            //获取二级级菜单
            if (request["Action"] == "GetSysMenu2")
            {
                #region
                DataSet ds = new DataSet();

                int appid = int.Parse(request["appid"]);
                int pid = int.Parse(request["pid"]);

                if (dsemp.Tables[0].Rows.Count > 0)
                {
                    if (dsemp.Tables[0].Rows[0]["uid"].ToString() == "admin")
                    {
                        ds = menu.GetList(0, "App_id=" + appid + " and parentid=" + pid, "Menu_order");
                    }
                    else
                    {
                        DataSSN.SSN_GetAuthorityByUid getauth = new DataSSN.SSN_GetAuthorityByUid();
                        string menus = getauth.GetAuthority(emp_id.ToString(), "Menus");
                        //ds = menu.GetList(0, "App_id=" + appid + " and Menu_id in " + menus + " and menu_type='aft'", "Menu_order");
                        ds = menu.GetList(0, "App_id=" + appid + " and Id in " + menus + "  and parentid=" + pid, "Menu_order");
                    }
                }

                string strRe = XHD.Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(strRe);
                #endregion
            }

            //获取某个菜单下的值
            else if (request["Action"] == "grid")
            {
                DataSet dk = new DataSet();
                string title = request["title"];
                string strWhere = string.Empty;
                bool num = true;
                string atr_id = "";

                if (!string.IsNullOrEmpty(request["menuid"]))
                {
                    string menuId = request["menuid"];
                    if (menuId == "-1")
                    {
                        strWhere = "factory_Id='" + factory_Id + "' and is_del=0";
                        dk = _visit.GetListAtrId("r.empID='" + emp_id + "' ");
                    }
                    else
                    {
                        strWhere = "factory_Id='" + factory_Id + "' and Art_Menu_Id='" + menuId + "' and is_del=0";
                        dk = _visit.GetListAtrId("r.empID='" + emp_id + "'and v.Menu_ids='" + menuId + "' ");
                    }

                    if (uid != "admin")
                    {
                        foreach (DataRow row in dk.Tables[0].Rows)
                        {
                            //获取能访问的文章的id
                            atr_id += PageValidate.InputText(row["Art_id"].ToString(), int.MaxValue).Replace("a", "");

                            //string Menu_ids = row["Menu_ids"].ToString();
                            //if (!string.IsNullOrEmpty(Menu_ids))
                            //{
                            //    string[] listMenu = Menu_ids.Split(',');
                            //    foreach (var item in listMenu)
                            //    {
                            //        if (menuId == item)
                            //        {
                            //            num = true;
                            //            break;
                            //        }
                            //    }
                            //}
                        }

                        //准备查询条件
                        if (num == true)
                        {
                            if (atr_id != "")
                            {
                                atr_id = atr_id.Substring(0, atr_id.Length - 1);
                                strWhere += " and Id in(" + atr_id + ")";
                            }
                            else
                            {
                                strWhere += " and 1=2";
                            }

                        }
                        else
                            strWhere += " and Id='-1'";
                    }


                    if (!string.IsNullOrEmpty(title))
                    {
                       
                        List<string> strList = new List<string>();
                        char[] charList = title.ToArray();
                        for (int i = 0; i < charList.Length; i++)
                        {
                            if (i == 0)
                            {
                                strWhere += " and Art_title like '%" + charList[i] + "%'";
                            }
                            else
                            {
                                strWhere += " or Art_title like '%" + charList[i] + "%'";
                            }
                            if (!strList.Contains(charList[i].ToString()))
                            {
                                strList.Add(charList[i].ToString());
                            }
                        }
                        Segment seg = new Segment();
                        seg.InitWordDics();
                        seg.EnablePrefix = true;
                        seg.Separator = " ";
                        string Seg_Title = seg.SegmentText(title, false).Trim();

                        string[] titleArray = Seg_Title.Split(' ');
                        for (int i = 0; i < titleArray.Length; i++)
                        {
                            strWhere += " or Art_title like '%" + titleArray[i] + "%'";
                            //if (!strList.Contains(titleArray[i]))
                            //{
                            //    strList.Add(titleArray[i]);
                            //}
                        }
                        //strWhere += " and Art_title like '%" + title + "%'";
                        DataSet ds = _art.GetList(strWhere);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            string temStr = ds.Tables[0].Rows[i]["Art_Title"].ToString();
                            for (int j = 0; j < strList.Count; j++)
                            {
                                if (temStr.Contains(strList[j]))
                                {
                                    ds.Tables[0].Rows[i]["Art_Title"] = ds.Tables[0].Rows[i]["Art_Title"].ToString().Replace(strList[j], "<span style='color:red' >" + strList[j] + "</span>");
                                }

                            }
                        }
                        string strRe = XHD.Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        context.Response.Write(strRe);
                    }
                    else
                    {
                        DataSet ds = _art.GetList(strWhere);
                        string strRe = XHD.Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        context.Response.Write(strRe);
                    }
                }
            }

            //获取文章内容
            if (request["Action"] == "form")
            {
                string urlList = string.Empty;

                if (!string.IsNullOrEmpty(request["flag"]))
                {
                    DataSet ds = _art.GetList("factory_Id='" + factory_Id + "' and Id=" + int.Parse(request["flag"]));
                    string dt = XHD.Common.DataToJson.DataToJSON(ds);
                    context.Response.Write(dt);
                }
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}