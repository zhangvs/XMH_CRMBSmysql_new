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
    /// SSN_Role_Emp 的摘要说明
    /// </summary>
    public class SSN_Role_Emp : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            XHD.BLL.ssn_role_emp rm = new XHD.BLL.ssn_role_emp();
            XHD.Model.ssn_role_emp model = new XHD.Model.ssn_role_emp();

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
            if (request["Action"] == "add")
            {
                string rid = PageValidate.InputText(request["role_id"], 50);
                string empids = XHD.Common.PageValidate.InputText(request["empids"], int.MaxValue);
                //rm.Delete(string.Format("RoleID={0} and empID in ({1})", int.Parse(rid), empids));
                string[] emplist = empids.Split(',');
                model.RoleID = int.Parse(rid);
                for (int i = 0; i < emplist.Length; i++)
                {
                    model.empID = int.Parse(emplist[i].ToString());
                    rm.Add(model);
                }

                XHD.BLL.Sys_log log = new XHD.BLL.Sys_log();
                XHD.Model.Sys_log modellog = new XHD.Model.Sys_log();

                modellog.EventDate = DateTime.Now;
                modellog.UserID = emp_id;
                modellog.UserName = PageValidate.InputText(empname, 255);
                modellog.IPStreet = context.Request.UserHostAddress;

                modellog.EventType = "权限人员调整";
                modellog.EventID = rid.ToString();
                log.Add(modellog);
            }
            else if (request["Action"] == "remove")
            {
                string rid = PageValidate.InputText(request["role_id"], 50);
                string empids = XHD.Common.PageValidate.InputText(request["empids"], int.MaxValue);
                rm.Delete(string.Format("RoleID={0} and empID in ({1})", int.Parse(rid), empids));

                XHD.BLL.Sys_log log = new XHD.BLL.Sys_log();
                XHD.Model.Sys_log modellog = new XHD.Model.Sys_log();

                modellog.EventDate = DateTime.Now;
                modellog.UserID = emp_id;
                modellog.UserName = PageValidate.InputText(empname, 255);
                modellog.IPStreet = context.Request.UserHostAddress;

                modellog.EventType = "权限人员调整";
                modellog.EventID = rid.ToString();
                log.Add(modellog);
            }
            else if (request["Action"] == "emplist")
            {
                string rid = PageValidate.InputText(request["role_id"], 50);

                string sql = (string.Format("ID not in (select empID from ssn_role_emp where RoleID={0}) and uid !='admin' ", rid));
                sql += " and factory_Id='" + factory_Id + "'";
                if (!string.IsNullOrEmpty(request["stext"]))
                {
                    sql += " and name like '%" + PageValidate.InputText(request["stext"], 255) + "%'";
                }

                int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                string sortname = request["sortname"];
                string sortorder = request["sortorder"];

                if (string.IsNullOrEmpty(sortname))
                    sortname = " ID";
                if (string.IsNullOrEmpty(sortorder))
                    sortorder = " desc";

                string sorttext = " " + sortname + " " + sortorder;

                string Total;

                dsemp = emp.GetList(PageSize, PageIndex, sql, sorttext, out Total);

                string dt = XHD.Common.GetGridJSON.DataTableToJSON1(dsemp.Tables[0], Total);
                context.Response.Write(dt);
            }
            else if (request["Action"] == "emplistDep")
            {
                string rid = PageValidate.InputText(request["role_id"], 50);
                string depid = PageValidate.InputText(request["depid"], 50);
                string sql = (string.Format("ID not in (select empID from ssn_role_emp where RoleID={0}) and uid !='admin' ", rid));
                sql += " and factory_Id='" + factory_Id + "' and d_id in ( " + depid + ")";

                int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                string sortname = request["sortname"];
                string sortorder = request["sortorder"];

                if (string.IsNullOrEmpty(sortname))
                    sortname = " ID";
                if (string.IsNullOrEmpty(sortorder))
                    sortorder = " desc";

                string sorttext = " " + sortname + " " + sortorder;

                string Total;

                dsemp = emp.GetList(PageSize, PageIndex, sql, sorttext, out Total);

                string dt = XHD.Common.GetGridJSON.DataTableToJSON1(dsemp.Tables[0], Total);
                context.Response.Write(dt);
            }
            else if (request["Action"] == "get")
            {
                string rid = PageValidate.InputText(request["role_id"], 50);
                if (!string.IsNullOrEmpty(rid))
                {
                    string sql = (string.Format("ID in (select empID from ssn_role_emp where RoleID={0})", int.Parse(rid)));
                    sql += " and factory_Id=" + factory_Id;
                    if (!string.IsNullOrEmpty(request["stext"]))
                    {
                        sql += " and name like '%" + PageValidate.InputText(request["stext"], 255) + "%'";
                    }
                    int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                    int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                    string sortname = request["sortname"];
                    string sortorder = request["sortorder"];

                    if (string.IsNullOrEmpty(sortname))
                        sortname = " ID";
                    if (string.IsNullOrEmpty(sortorder))
                        sortorder = " desc";

                    string sorttext = " " + sortname + " " + sortorder;

                    string Total;

                    dsemp = emp.GetList(PageSize, PageIndex, sql, sorttext, out Total);

                    string dt = XHD.Common.GetGridJSON.DataTableToJSON1(dsemp.Tables[0], Total);
                    context.Response.Write(dt);

                }
                else
                {
                    context.Response.Write("test" + rid);
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