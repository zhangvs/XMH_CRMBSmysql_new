using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;
using XHD.Common;

namespace SSN.DataSSN
{
    /// <summary>
    /// SSN_Role 的摘要说明
    /// </summary>
    public class SSN_Role : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            XHD.BLL.ssn_role role = new XHD.BLL.ssn_role();
            XHD.BLL.ssn_art_menu menu = new XHD.BLL.ssn_art_menu();
            XHD.Model.ssn_role model = new XHD.Model.ssn_role();
            XHD.BLL.ssn_visit visit = new XHD.BLL.ssn_visit();
            XHD.BLL.ssn_art art = new XHD.BLL.ssn_art();
            var cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];
            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            string CoockiesID = ticket.UserData;

            XHD.BLL.hr_employee emp = new XHD.BLL.hr_employee();
            int emp_id = int.Parse(CoockiesID);
            DataSet dsemp = emp.GetList("id=" + emp_id);
            string empname = string.Empty;
            string uid = string.Empty;
            string factory_Id = string.Empty;
            if (dsemp != null && dsemp.Tables[0].Rows.Count > 0)
            {
                empname = dsemp.Tables[0].Rows[0]["name"].ToString();
                uid = dsemp.Tables[0].Rows[0]["uid"].ToString();
                factory_Id = dsemp.Tables[0].Rows[0]["Factory_Id"].ToString();
            }

            //角色保存
            if (request["Action"] == "SysSave")
            {
                model.RoleName = PageValidate.InputText(request["T_role"], 250);
                model.RoleSort = int.Parse(request["T_RoleOrder"]);
                model.RoleDscript = PageValidate.InputText(request["T_Descript"], 255);
                model.Factory_Id = factory_Id;

                string id = PageValidate.InputText(request["id"], 50);

                if (!string.IsNullOrEmpty(id) && id != "null")
                {
                    DataSet ds = role.GetList("RoleID=" + int.Parse(id));
                    DataRow dr = ds.Tables[0].Rows[0];
                    model.RoleID = int.Parse(id);
                    model.UpdateDate = DateTime.Now;
                    model.UpdateID = emp_id;
                    role.Update(model);
                }
                else
                {
                    model.CreateID = emp_id;
                    model.CreateDate = DateTime.Now;
                    int rid = role.Add(model);

                }
            }

            //验证是否唯一
            else if (request["Action"] == "Exist")
            {
                DataSet ds1 = role.GetList(" RoleName='" + XHD.Common.PageValidate.InputText(request["T_role"], 250) + "'" + " and factory_Id='" + factory_Id + "'");
                context.Response.Write(ds1.Tables[0].Rows.Count > 0 ? "false" : "true");
            }

            //获取角色表格json
            else if (request["Action"] == "grid")
            {
                DataSet ds = role.GetList(0, "factory_Id='" + factory_Id + "'", " RoleSort");

                string dt = XHD.Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);

                context.Response.Write(dt);
            }

            //获取角色信息
            else if (request["Action"] == "form")
            {

                DataSet ds = role.GetList(" RoleID=" + int.Parse(request["id"]));

                string dt = XHD.Common.DataToJson.DataToJSON(ds);

                context.Response.Write(dt);
            }
            //删除角色
            else if (request["Action"] == "del")
            {
                string rid = request["id"];
                bool isdel = role.Delete(int.Parse(rid));
                if (isdel)
                    context.Response.Write("true");
                else
                    context.Response.Write("false");

                //角色下员工删除
                XHD.BLL.ssn_role_emp rm = new XHD.BLL.ssn_role_emp();
                rm.Delete("RoleID=" + int.Parse(rid));

                //角色下数据权限删除
                XHD.BLL.ssn_visit data_auth = new XHD.BLL.ssn_visit();
                data_auth.DeleteByRole(int.Parse(rid));

                //角色下功能权限删除
                XHD.BLL.ssn_authority auth = new XHD.BLL.ssn_authority();
                auth.DeleteWhere("Role_id=" + int.Parse(rid));
            }

            #region 权限设置
            //auth
            else if (request["Action"] == "treegrid")
            {
                string appidstr = request["appid"];
                int appid = int.Parse(appidstr);

                //获取单位
                string ftyid = PageValidate.InputText(request["factory_id"], 60);
                //设置查询条件
                string wheretext = "App_id=" + appid;//限制menu
                string wheretext2 = "";//限制button

                DataTable dt = menu.GetList(wheretext).Tables[0];
                dt.Columns.Add(new DataColumn("Sysroler", typeof(string)));

                XHD.BLL.ssn_button btn = new XHD.BLL.ssn_button();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataSet ds = btn.GetList(0, "Menu_id=" + dt.Rows[i]["Menu_id"].ToString() + wheretext2, "Btn_order");
                    string roler = "";
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                        {
                            roler += ds.Tables[0].Rows[j]["Btn_id"].ToString() + "|" + ds.Tables[0].Rows[j]["Btn_name"].ToString();
                            roler += ",";
                        }
                    }
                    dt.Rows[i][dt.Columns.Count - 1] = roler;
                }
                string dt1 = "{Rows:[" + GetTasksString(0, dt) + "]}";
                context.Response.Write(dt1);
                context.Response.End();
            }
            //get auth
            else if (request["Action"] == "getauth")
            {
                string postdata = Convert.ToString(HttpContext.Current.Request.QueryString["postdata"]);
                JavaScriptSerializer json = new JavaScriptSerializer();
                save sa = json.Deserialize<save>(postdata);
                XHD.Model.ssn_authority modelauth = new XHD.Model.ssn_authority();
                modelauth.Role_id = int.Parse(sa.role_id);
                modelauth.App_ids = sa.app;
                modelauth.Menu_ids = sa.menu;
                modelauth.Button_ids = sa.btn;

                XHD.BLL.ssn_authority sysau = new XHD.BLL.ssn_authority();

                string roledata = "0|0";
                DataSet ds = sysau.GetList("Role_id=" + modelauth.Role_id + " and App_ids='" + modelauth.App_ids + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    roledata = dr["Menu_ids"] + "|" + dr["Button_ids"];
                }
                context.Response.Write(roledata);
            }
            // save auth
            else if (request["Action"] == "saveauth")
            {
                string postdata = Convert.ToString(HttpContext.Current.Request.QueryString["postdata"]);
                JavaScriptSerializer json = new JavaScriptSerializer();
                save sa = json.Deserialize<save>(postdata);
                XHD.Model.ssn_authority modelauth = new XHD.Model.ssn_authority();
                modelauth.Role_id = int.Parse(sa.role_id);
                modelauth.App_ids = PageValidate.InputText(sa.app, 50);
                modelauth.Menu_ids = PageValidate.InputText(sa.menu, int.MaxValue);
                modelauth.Button_ids = PageValidate.InputText(sa.btn, int.MaxValue);
                modelauth.Factory_Id = factory_Id;

                XHD.BLL.ssn_authority sysau = new XHD.BLL.ssn_authority();
                //List<string> relstbtn = new List<string>();

                if (!string.IsNullOrEmpty(postdata))
                {
                    //给角色分配权限
                    sysau.DeleteWhere("Role_id=" + modelauth.Role_id + " and App_ids='" + modelauth.App_ids + "'");
                    if (modelauth.Menu_ids != "" || modelauth.Button_ids != ",,")
                    {
                        sysau.Add(modelauth);
                    }
                    context.Response.Write("{sucess:sucess}");

                }
            }
            #endregion

            #region 查看权限设置
            //菜单显示
            else if (request["Action"] == "menuList")
            {
                string appid = request["appid"];
                string authtxt = PageValidate.InputText(request["auth"], 50);

                if (!string.IsNullOrEmpty(appid))
                {
                    string serchtxt = " App_id=" + int.Parse(appid);
                    //-context.Response.Write(authtxt);
                    DataSet ds = menu.GetList(0, serchtxt, " Menu_order");
                    StringBuilder str = new StringBuilder();
                    str.Append("[");
                    str.Append(GetTreeString(0, ds.Tables[0], authtxt));
                    str.Replace(",", "", str.Length - 1, 1);
                    str.Append("]");
                    context.Response.Write(str);
                }
            }

            //显示菜单下的文章
            else if (request["Action"] == "viewgrid")
            {
                //通过菜单id获取旗下的文章
                string menuid = request["menuid"];

                if (!string.IsNullOrEmpty(menuid))
                {

                    string serchtxt = " Factory_Id='" + factory_Id + "' and Art_Menu_Id=" + int.Parse(menuid) + " and is_del=0 ";
                    DataSet ds = art.GetList(serchtxt);

                    string dt = XHD.Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    context.Response.Write(dt);
                }
            }

            //保存查看权限
            else if (request["Action"] == "saveview")
            {
                string postdata = Convert.ToString(HttpContext.Current.Request.QueryString["postdata"]);
                JavaScriptSerializer json = new JavaScriptSerializer();
                view sa = json.Deserialize<view>(postdata);
                XHD.Model.ssn_visit modelview = new XHD.Model.ssn_visit();
                modelview.Role_id = int.Parse(sa.role_id);
                modelview.App_ids = PageValidate.InputText(sa.app, 50);
                modelview.Menu_ids = PageValidate.InputText(sa.menu, int.MaxValue);
                modelview.Art_id = PageValidate.InputText(sa.art, int.MaxValue);
                modelview.Factory_Id = factory_Id;
                modelview.Create_id = emp_id;
                modelview.Create_date = DateTime.Now;

                if (!string.IsNullOrEmpty(postdata))
                {
                    //给角色分配权限
                    visit.DeleteWhere("Role_id=" + modelview.Role_id + " and Menu_ids='" + modelview.Menu_ids + "'");
                    if (modelview.Art_id != "")
                    {
                        visit.Add(modelview);
                    }
                    context.Response.Write("{sucess:sucess}");

                }
            }
            //获取当前角色的权限
            else if (request["Action"] == "getview")
            {
                string postdata = Convert.ToString(HttpContext.Current.Request.QueryString["postdata"]);
                JavaScriptSerializer json = new JavaScriptSerializer();
                view sa = json.Deserialize<view>(postdata);
                XHD.Model.ssn_visit modelview = new XHD.Model.ssn_visit();
                modelview.Role_id = int.Parse(sa.role_id);
                modelview.App_ids = sa.app;
                modelview.Menu_ids = sa.menu;
                modelview.Art_id = sa.art;

                string roledata = "";
                DataSet ds = visit.GetList("Role_id=" + modelview.Role_id + " and Menu_ids='" + modelview.Menu_ids + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    roledata = dr["Art_id"].ToString();
                }
                context.Response.Write(roledata);
            }

            #endregion

        }

        private class save
        {
            public string role_id;
            public string factory_id;
            public string app;
            public string menu;
            public string btn;
        }

        private class view
        {
            public string role_id;
            public string app;
            public string menu;
            public string art;
        }

        private static string GetTasksString(int Id, DataTable table)
        {
            DataRow[] rows = table.Select("parentid=" + Id.ToString());

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                str.Append("{");
                for (int i = 0; i < row.Table.Columns.Count; i++)
                {
                    if (i != 0) str.Append(",");
                    str.Append(row.Table.Columns[i].ColumnName);
                    str.Append(":'");
                    str.Append(row[i].ToString());
                    str.Append("'");
                }
                if (GetTasksString((int)row["Menu_id"], table).Length > 0)
                {
                    str.Append(",children:[");
                    str.Append(GetTasksString((int)row["Menu_id"], table));
                    str.Append("]},");
                }
                else
                {
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
                string d_icon = "../../" + (string)row["Menu_icon"];

                if (!string.IsNullOrEmpty(authtxt) && authtxt.IndexOf(row["id"].ToString()) == -1 && authtxt != "0")
                    d_icon = "../../images/icon/50.png";

                str.Append("{Menu_id:" + (int)row["Menu_id"] + ",text:'" + row["Menu_name"].ToString() + "',d_icon:'" + d_icon + "'");

                if (GetTreeString((int)row["Menu_id"], table, authtxt).Length > 0)
                {
                    str.Append(",children:[");
                    str.Append(GetTreeString((int)row["Menu_id"], table, authtxt));
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