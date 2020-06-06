using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

namespace SSN.DataSSN
{
    /// <summary>
    /// SSN_App 的摘要说明
    /// </summary>
    public class SSN_App : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

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

            if (request["Action"] == "GetSysApp")
            {
                XHD.BLL.ssn_art_app app = new XHD.BLL.ssn_art_app();
                DataSSN.SSN_GetAuthorityByUid getappauth = new DataSSN.SSN_GetAuthorityByUid();
                string apps = getappauth.GetAuthority(emp_id.ToString(), "Apps");

                DataSet dsemp1 = emp.GetList("ID=" + emp_id);
                bool BtnAble = false;
                if (dsemp1.Tables[0].Rows.Count > 0)
                {
                    if (dsemp1.Tables[0].Rows[0]["uid"].ToString() == "admin")
                    {
                        BtnAble = true;
                    }
                }

                DataSet ds = app.GetList(0, "", "App_order");
                string toolbarscript = "{Items:[";

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    toolbarscript += "{";
                    toolbarscript += "type: 'button',";
                    toolbarscript += "text: '" + ds.Tables[0].Rows[i]["App_name"].ToString() + "',";
                    toolbarscript += "icon: '" + ds.Tables[0].Rows[i]["App_icon"].ToString() + "',";

                    if (BtnAble)
                    {
                        toolbarscript += "disable: true,";
                    }
                    else
                    {
                        toolbarscript += "disable: " + getappauth.GetAppAuthority(emp_id.ToString(), ds.Tables[0].Rows[i]["id"].ToString()) + ",";
                    }
                    toolbarscript += "click: function () {";
                    toolbarscript += "f_according(" + ds.Tables[0].Rows[i]["id"].ToString() + ")";
                    toolbarscript += "}";
                    toolbarscript += "},";
                }
                toolbarscript = toolbarscript.Substring(0, toolbarscript.Length - 1);
                toolbarscript += "]}";
                context.Response.Write(toolbarscript);
            }
            else if (request["Action"] == "GetAppList")
            {
                XHD.BLL.ssn_art_app app = new XHD.BLL.ssn_art_app();
                DataSet ds = app.GetList(0, " ", "App_order");

                StringBuilder str = new StringBuilder();
                str.Append("[");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    str.Append("{id:" + ds.Tables[0].Rows[i]["id"].ToString() + ",text:'" + ds.Tables[0].Rows[i]["App_name"] + "',App_icon:'../../" + ds.Tables[0].Rows[i]["App_icon"] + "'},");
                }
                str.Replace(",", "", str.Length - 1, 1);
                str.Append("]");
                context.Response.Write(str);
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