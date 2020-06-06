using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using XHD.Common;

namespace SSN
{
    public partial class main_ssn : System.Web.UI.Page
    {
        XHD.BLL.ssn_art _art = new XHD.BLL.ssn_art();
        XHD.BLL.ssn_art_menu menu = new XHD.BLL.ssn_art_menu();
        XHD.BLL.ssn_visit _visit = new XHD.BLL.ssn_visit();

        string empname = string.Empty;
        string uid = string.Empty;
        string depid = string.Empty;
        string roletype = string.Empty;
        string factory_Id = string.Empty;
        string empId = string.Empty;

        //初始化
        protected void Page_Init(object sender, EventArgs e)
        {
            var cookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            if (cookie != null)
            {
                var ticket = FormsAuthentication.Decrypt(cookie.Value);
                string CoockiesID = ticket.UserData;
                XHD.BLL.hr_employee emp = new XHD.BLL.hr_employee();
                int emp_id = int.Parse(CoockiesID);
                empId = CoockiesID;
                XHD.Model.hr_employee employeeModel = emp.GetModel(emp_id); //当前员工

                if (employeeModel != null)
                {
                    empname = employeeModel.name;                 //员工姓名
                    uid = employeeModel.uid;                      //员工Uid
                    depid = employeeModel.d_id.ToString();        //员工所在部门
                    factory_Id = employeeModel.factory_Id;        //员工所属工厂
                    roletype = employeeModel.roletype.ToString();
                }
            }
            else
            {
                Response.Write("<script>window.location='../login_ssn.aspx'</script>");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.bindArticle("");
                //if (!string.IsNullOrEmpty(Request.QueryString["Id"].ToString()))
                //{
                //    this.bindArticle("");
                //}
                //else
                //{
                //    Response.Write("<script>alert('不存在该页面！');document.location='main_scm.aspx';</script>");
                //    return;
                //}
            }
        }

        //绑定数据
        public void bindArticle(string title)
        {
            string strWhere = string.Empty;
            string atr_id = "";
            //bool num = false;
            //if (!string.IsNullOrEmpty(Request.QueryString["Id"].ToString()))
            //{
            //string menuId = Request.QueryString["Id"].ToString();
            //strWhere = "factory_Id='" + factory_Id + "' and Art_Menu_Id='" + menuId + "' and is_del=0";
            strWhere = "factory_Id='" + factory_Id + "' and is_del=0";
            DataSet dk = _visit.GetListAtrId("r.empID='" + empId + "' ");

            if (uid != "admin")
            {
                foreach (DataRow row in dk.Tables[0].Rows)
                {
                    //获取能访问的文章的id
                    atr_id += PageValidate.InputText(row["Art_id"].ToString(), int.MaxValue).Replace("a", "");
                }

                //准备查询条件
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

            if (!string.IsNullOrEmpty(title))
            {
                strWhere += " and Art_title like '%" + title + "%'";
            }
            this.repArticle.DataSource = _art.GetList(strWhere);
            this.repArticle.DataBind();
            //}
        }

        //搜索
        protected void Button1_Click(object sender, EventArgs e)
        {
            string title = this.title.Value.Replace(" ", "");
            bindArticle(title);
        }
    }
}