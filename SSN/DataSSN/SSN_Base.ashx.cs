using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using XHD.Common;

namespace SSN.DataSSN
{
    /// <summary>
    /// SSN_Base 的摘要说明
    /// </summary>
    public class SSN_Base : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            XHD.BLL.ssn_art_menu menu = new XHD.BLL.ssn_art_menu();

            XHD.BLL.sys_info info = new XHD.BLL.sys_info();

            var cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];
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

            #region GetSysApp
            if (request["Action"] == "GetSysApp")
            {
                DataSet ds = null;

                int appid = int.Parse(request["appid"]);

                if (dsemp.Tables[0].Rows.Count > 0)
                {
                    if (dsemp.Tables[0].Rows[0]["uid"].ToString() == "admin")
                    {
                        ds = menu.GetList(0, "App_id=" + appid, "Menu_order");
                    }
                    else
                    {
                        DataSSN.SSN_GetAuthorityByUid getauth = new DataSSN.SSN_GetAuthorityByUid();
                        string menus = getauth.GetAuthority(emp_id.ToString(), "Menus");
                        //ds = menu.GetList(0, "App_id=" + appid + " and Menu_id in " + menus + " and menu_type='aft'", "Menu_order");
                        ds = menu.GetList(0, "App_id=" + appid + " and Id in " + menus + " ", "Menu_order");
                    }
                }

                string strRe = string.Empty;

                //==============整理返回==============================================
                strRe = "[" + GetTasksString(emp_id.ToString(), empname, factory_Id, 0, ds.Tables[0]) + "]";


                context.Response.Write(strRe);
            }
            #endregion

            #region getUserTree
            else if (request["Action"] == "getUserTree")
            {
                XHD.BLL.Sys_online sol = new XHD.BLL.Sys_online();
                XHD.Model.Sys_online model = new XHD.Model.Sys_online();

                model.UserName = PageValidate.InputText(empname, 250);
                model.UserID = emp_id;
                model.LastLogTime = DateTime.Now;

                DataSet ds1 = sol.GetList(" UserID=" + emp_id);

                //添加当前用户信息
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    sol.Update(model, " UserID=" + emp_id);
                }
                else
                {
                    sol.Add(model);
                }

                //删除超时用户
                //2分钟用户失效，删除 --Robert 2015-11-24
                sol.Delete(" LastLogTime<date_sub(now(), interval 2 minute)");

                XHD.BLL.hr_department dep = new XHD.BLL.hr_department();
                XHD.BLL.hr_post hp = new XHD.BLL.hr_post();

                DataSet ds = dep.GetList(0, "factory_Id='" + factory_Id + "'", "d_order");
                StringBuilder str = new StringBuilder();
                str.Append("[");
                str.Append(GetTreeString(0, ds.Tables[0], 1, "1=1"));
                str.Replace(",", "", str.Length - 1, 1);
                str.Append("]");
                context.Response.Write(str);

            }
            #endregion

            #region GetUserInfo
            else if (request["Action"] == "GetUserInfo")
            {
                string dt = XHD.Common.DataToJson.DataToJSON(dsemp);

                context.Response.Write(dt);
            }
            #endregion

            #region GetOnline
            else if (request["Action"] == "GetOnline")
            {
                XHD.BLL.Sys_online sol = new XHD.BLL.Sys_online();
                XHD.Model.Sys_online model = new XHD.Model.Sys_online();

                model.UserName = empname;
                model.UserID = emp_id;
                model.LastLogTime = DateTime.Now;

                DataSet ds1 = sol.GetList(" UserID=" + emp_id);

                //添加当前用户信息
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    sol.Update(model, " UserID=" + emp_id);
                }
                else
                {
                    sol.Add(model);
                }
                //}

                //删除超时用户
                //2分钟用户失效，删除 --Robert 2015-11-24
                sol.Delete(" LastLogTime<date_sub(now(), interval 2 minute)");

                context.Response.Write(XHD.Common.GetGridJSON.DataTableToJSON(sol.GetAllList().Tables[0]));
            }
            #endregion

            #region getinfo
            else if (request["Action"] == "getinfo")
            {
                DataSet ds = info.GetList(" id=2 or id=3");
                context.Response.Write(XHD.Common.GetGridJSON.DataTableToJSON(ds.Tables[0]));
            }
            #endregion

            #region changepwd
            else if (request["Action"] == "changepwd")
            {

                DataSet ds = emp.GetPWD(emp_id);
                XHD.Model.hr_employee model = new XHD.Model.hr_employee();
                string oldpwd = FormsAuthentication.HashPasswordForStoringInConfigFile(request["T_oldpwd"], "MD5");
                string newpwd = FormsAuthentication.HashPasswordForStoringInConfigFile(request["T_newpwd"], "MD5");

                if (ds.Tables[0].Rows[0]["pwd"].ToString() == oldpwd)
                {
                    model.pwd = newpwd;
                    model.ID = (emp_id);
                    emp.changepwd(model);
                    context.Response.Write("true");
                }
                else
                {
                    context.Response.Write("false");
                }
            }
            #endregion

            #region form
            else if (request["Action"] == "form")
            {
                string eid = PageValidate.InputText(request["id"], 50);

                if (eid == "epu")
                    eid = emp_id.ToString();

                DataSet ds = emp.GetList("id=" + int.Parse(eid));

                string dt = XHD.Common.DataToJson.DataToJSON(ds);

                context.Response.Write(dt);

            }
            #endregion

            #region PersonalUpdate保存修改信息
            else if (request["Action"] == "PersonalUpdate")
            {
                XHD.Model.hr_employee model = new XHD.Model.hr_employee();
                model.email = PageValidate.InputText(request["T_email"], 255);
                model.name = PageValidate.InputText(request["T_name"], 255);
                model.birthday = PageValidate.InputText(request["T_birthday"], 255);
                model.sex = PageValidate.InputText(request["T_sex"], 255);
                model.idcard = PageValidate.InputText(request["T_idcard"], 255);
                model.tel = PageValidate.InputText(request["T_tel"], 255);


                model.address = PageValidate.InputText(request["T_Adress"], 255);
                model.schools = PageValidate.InputText(request["T_school"], 255);
                model.education = PageValidate.InputText(request["T_edu"], 255);
                model.professional = PageValidate.InputText(request["T_professional"], 255);
                model.remarks = PageValidate.InputText(request["T_remarks"], 255);
                model.title = PageValidate.InputText(request["headurl"], 255);

                DataRow dr = dsemp.Tables[0].Rows[0];
                model.ID = emp_id;

                bool isup = emp.PersonalUpdate(model);

                if (isup)
                    context.Response.Write("true");
                else
                    context.Response.Write("false");

                C_Sys_log log = new C_Sys_log();

                int UserID = emp_id;
                string UserName = empname;
                string IPStreet = request.UserHostAddress;
                string EventTitle = model.name;
                string EventType = "个人信息修改";
                int EventID = emp_id;

                if (dr["email"].ToString() != request["T_email"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "邮箱", dr["email"].ToString(), request["T_email"], factory_Id);

                if (dr["name"].ToString() != request["T_name"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "员工姓名", dr["name"].ToString(), request["T_name"], factory_Id);

                if (dr["birthday"].ToString() != request["T_birthday"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "员工生日", dr["birthday"].ToString(), request["T_birthday"], factory_Id);

                if (dr["sex"].ToString() != request["T_sex"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "员工性别", dr["sex"].ToString(), request["T_sex"], factory_Id);

                if (dr["idcard"].ToString() != request["T_idcard"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "身份证", dr["idcard"].ToString(), request["T_idcard"], factory_Id);

                if (dr["tel"].ToString() != request["T_tel"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "手机", dr["tel"].ToString(), request["T_tel"], factory_Id);

                if (dr["address"].ToString() != request["T_Adress"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "地址", dr["address"].ToString(), request["T_Adress"], factory_Id);

                if (dr["schools"].ToString() != request["T_school"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "毕业学校", dr["schools"].ToString(), request["T_school"], factory_Id);

                if (dr["education"].ToString() != request["T_edu"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "学历", dr["education"].ToString(), request["T_edu"], factory_Id);

                if (dr["professional"].ToString() != request["T_professional"])
                    log.Add_log(UserID, UserName, IPStreet, EventTitle, EventType, EventID, "专业", dr["professional"].ToString(), request["T_professional"], factory_Id);


            }
            #endregion

            #region tree
            else if (request["Action"] == "tree")
            {
                string serchtxt = " 1=1 and factory_Id = '" + factory_Id + "'";

                //string authtxt = PageValidate.InputText(request["auth"], 50);
                //if (!string.IsNullOrEmpty(authtxt))
                //{
                //    Data.GetDataAuth dataauth = new Data.GetDataAuth();
                //    string txt = dataauth.GetDataAuthByid(authtxt, "Sys_add", emp_id.ToString(), factory_Id);
                //    string[] arr = txt.Split(':');
                //    switch (arr[0])
                //    {
                //        case "my":
                //        case "dep":
                //            string did = dsemp.Tables[0].Rows[0]["d_id"].ToString();
                //            if (string.IsNullOrEmpty(did))
                //                did = "0";
                //            authtxt = did;
                //            break;
                //        case "all":
                //            authtxt = "0";
                //            break;
                //        case "depall":
                //            DataSet dsdep = dep.GetList("factory_Id='" + factory_Id + "'");
                //            string deptask = GetDepTask(int.Parse(arr[1]), dsdep.Tables[0]);
                //            string intext = arr[1] + "," + deptask;
                //            authtxt = intext.TrimEnd(',');
                //            break;
                //    }
                //}
                //context.Response.Write(authtxt);
                XHD.BLL.hr_department dep = new XHD.BLL.hr_department();
                DataSet ds = dep.GetList(0, serchtxt, " d_order");
                StringBuilder str = new StringBuilder();
                str.Append("[");
                str.Append(GetTreeString(0, ds.Tables[0], "0"));
                str.Replace(",", "", str.Length - 1, 1);
                str.Append("]");
                context.Response.Write(str);
            }
            #endregion
        }

        private static string GetTasksString(string strEmp_id, string strEmpName, string factory_Id, int Id, DataTable table)
        {
            DataRow[] rows = table.Select("parentid=" + Id.ToString());

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                //ds.Tables[0].Rows[i]["menu_name"] 

                str.Append("{");
                for (int i = 0; i < row.Table.Columns.Count; i++)
                {
                    if (i != 0) str.Append(",");
                    str.Append("\"");
                    str.Append(row.Table.Columns[i].ColumnName);
                    str.Append("\":\"");
                    str.Append(row[i].ToString());
                    str.Append("\"");
                }
                if (GetTasksString(strEmp_id, strEmpName, factory_Id, (int)row["Menu_id"], table).Length > 0)
                {
                    str.Append(",\"children\":[");
                    str.Append(GetTasksString(strEmp_id, strEmpName, factory_Id, (int)row["Menu_id"], table));
                    str.Append("]},");
                }
                else
                {
                    str.Append("},");
                }
            }
            return str[str.Length - 1] == ',' ? str.ToString(0, str.Length - 1) : str.ToString();
        }

        private static string GetTreeString(int Id, DataTable table, int todo, string returntxt)
        {
            XHD.BLL.hr_post hp = new XHD.BLL.hr_post();
            XHD.BLL.Sys_online sol = new XHD.BLL.Sys_online();
            DataRow[] rows = table.Select(string.Format("parentid={0}", Id));

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                str.Append("{id:" + (int)row["id"] + ",text:'" + (string)row["d_name"] + "',d_icon:'../" + (string)row["d_icon"] + "'");

                if (GetTreeString((int)row["id"], table, 0, returntxt).Length > 0)
                {
                    str.Append(",children:[");
                    if (todo == 1)
                    {
                        DataSet dsp = hp.GetList("dep_id=" + (int)row["id"]);
                        if (dsp != null && dsp.Tables[0].Rows.Count > 0)
                        {
                            for (int j = 0; j < dsp.Tables[0].Rows.Count; j++)
                            {
                                if (!string.IsNullOrEmpty(dsp.Tables[0].Rows[j]["emp_name"].ToString()))
                                {
                                    DataSet dso = sol.GetList("UserID=" + dsp.Tables[0].Rows[j]["emp_id"]);
                                    string posticon = "images/icon/93.png";
                                    if (dso.Tables[0].Rows.Count > 0)
                                        posticon = "images/icon/38.png";//95

                                    str.Append("{id:'p" + dsp.Tables[0].Rows[j]["post_id"].ToString() + "',text:'" + dsp.Tables[0].Rows[j]["emp_name"] + "',d_icon:'" + posticon + "'}");
                                    str.Append(",");
                                }
                            }
                        }
                    }
                    str.Append(GetTreeString((int)row["id"], table, 1, returntxt));
                    str.Append("]},");
                }
                else
                {
                    if (todo == 1)
                    {
                        DataSet dsp = hp.GetList("dep_id=" + (int)row["id"] + " and " + returntxt);
                        if (dsp.Tables[0].Rows.Count > 0)
                        {
                            str.Append(",children:[");
                            for (int j = 0; j < dsp.Tables[0].Rows.Count; j++)
                            {
                                if (!string.IsNullOrEmpty(dsp.Tables[0].Rows[j]["emp_name"].ToString()))
                                {
                                    DataSet dso = sol.GetList("UserID=" + dsp.Tables[0].Rows[j]["emp_id"]);
                                    string posticon = "images/icon/93.png";
                                    if (dso.Tables[0].Rows.Count > 0)
                                        posticon = "images/icon/38.png";//95

                                    str.Append("{id:'p" + dsp.Tables[0].Rows[j]["post_id"].ToString() + "',text:'" + dsp.Tables[0].Rows[j]["emp_name"] + "',d_icon:'" + posticon + "'},");
                                    //if (j < dsp.Tables[0].Rows.Count - 1)
                                    //    str.Append(",");
                                }
                            }
                            if (str[str.Length - 1] == ',')
                                str.Remove(str.Length - 1, 1);
                            str.Append("]");
                        }
                    }
                    str.Append("},");
                }
            }
            return str[str.Length - 1] == ',' ? str.ToString(0, str.Length - 1) : str.ToString();
        }

        private static string GetTreeString(int Id, DataTable table, string authtxt)
        {
            DataRow[] rows = table.Select(string.Format("parentid={0}", Id));

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                string d_icon = "../../" + (string)row["d_icon"];

                if (!string.IsNullOrEmpty(authtxt) && authtxt.IndexOf(row["id"].ToString()) == -1 && authtxt != "0")
                    d_icon = "../../images/icon/50.png";

                str.Append("{id:" + (int)row["id"] + ",text:'" + row["d_name"].ToString() + "',d_icon:'" + d_icon + "'");

                if (GetTreeString((int)row["id"], table, authtxt).Length > 0)
                {
                    str.Append(",children:[");
                    str.Append(GetTreeString((int)row["id"], table, authtxt));
                    str.Append("]},");
                }
                else
                {
                    str.Append("},");
                }
            }
            return str[str.Length - 1] == ',' ? str.ToString(0, str.Length - 1) : str.ToString();
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