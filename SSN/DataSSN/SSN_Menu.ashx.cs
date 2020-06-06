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
    /// SSN_Menu 的摘要说明
    /// </summary>
    public class SSN_Menu : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            XHD.BLL.ssn_art_menu menu = new XHD.BLL.ssn_art_menu();
            XHD.Model.ssn_art_menu model = new XHD.Model.ssn_art_menu();

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
            if (request["Action"] == "GetMenu")
            {
                int appid = XHD.Common.PageValidate.IsNumber(request["appid"]) ? int.Parse(request["appid"]) : 0;
                string serch = "App_id=" + appid;
                DataSet ds = menu.GetList(0, serch, "Menu_order");
                //string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                string dt = "{Rows:[" + GetTasksString(0, ds.Tables[0]) + "]}";
                context.Response.Write(dt);
            }
            //Form JSON
            else if (request["Action"] == "form")
            {
                DataSet ds = menu.GetList("id=" + int.Parse(request["menuid"]));

                string dt = XHD.Common.DataToJson.DataToJSON(ds);

                context.Response.Write(dt);
            }
            else if (request["Action"] == "SysTree")
            {

                int appid = int.Parse(request["appid"]);

                DataSet ds = menu.GetList(0, "parentid=0 and App_id=" + appid, "Menu_order");

                StringBuilder str = new StringBuilder();
                str.Append("[{id:0,pid:0,text:'无',Menu_icon:''},");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    str.Append("{id:" + ds.Tables[0].Rows[i]["menu_id"].ToString() + ",pid:" + ds.Tables[0].Rows[i]["parentid"].ToString() + ",text:'" + ds.Tables[0].Rows[i]["menu_name"] + "',Menu_icon:'" + ds.Tables[0].Rows[i]["Menu_icon"] + "'},");
                }
                str.Replace(",", "", str.Length - 1, 1);
                str.Append("]");
                context.Response.Write(str);
            }
            //save
            else if (request["Action"] == "save")
            {
                model.Art_Menu = XHD.Common.PageValidate.InputText(request["T_menu_name"], 255);
                model.Menu_url = XHD.Common.PageValidate.InputText(request["T_menu_url"], 255);
                model.Menu_icon = XHD.Common.PageValidate.InputText(request["T_menu_icon"], 255);
                model.Menu_order = int.Parse(request["T_menu_order"]);
                model.Menu_type = XHD.Common.PageValidate.InputText(request["T_menu_type_val"], 255);
                model.parentid = int.Parse(request["T_menu_parent_val"]);
                model.parentname = XHD.Common.PageValidate.InputText(request["T_menu_parent"], 255);
                model.App_id = int.Parse(request["appid"]);
                model.factory_Id = factory_Id;

                string id = request["menuid"];
                if (!string.IsNullOrEmpty(id) && id != "null")
                {
                    model.Id = int.Parse(id);
                    //DataSet ds = menu.GetList("Menu_id=" + model.Menu_id);
                    //DataRow dr = ds.Tables[0].Rows[0];

                    //if (ds.Tables[0].Rows.Count > 0)
                    //{
                    //    model.Menu_type = ds.Tables[0].Rows[0]["Menu_type"].ToString();
                    //}
                    menu.Update(model);
                }
                else
                {
                    bool mid = menu.Add(model);
                }
            }
            else if (request["Action"] == "del")
            {
                string id = request["menuid"];
                if (!string.IsNullOrEmpty(id) && id != "null")
                {
                    //校验此菜单id下以及子菜单id下是否存在文章、
                    if (menu.ExistsArt(int.Parse(id)))
                        context.Response.Write('1');      //存在文章，不允许删除
                    else
                    {
                        menu.DeleteAndChildren(int.Parse(id));
                        context.Response.Write('2');      //不存在文章删除，删除
                    }
                }
            }
        }

        private static string GetTasksString(int Id, DataTable table)
        {
            DataRow[] rows = table.Select("parentid=" + Id.ToString());

            if (rows.Length == 0) return string.Empty;
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
                if (GetTasksString((int)row["menu_id"], table).Length > 0)
                {
                    str.Append(",children:[");
                    str.Append(GetTasksString((int)row["menu_id"], table));
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