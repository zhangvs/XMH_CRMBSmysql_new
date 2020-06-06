using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSN.SSN.article
{
    public partial class ssn_article_view : System.Web.UI.Page
    {
        XHD.BLL.ssn_art _art = new XHD.BLL.ssn_art();
        XHD.BLL.ssn_art_menu menu = new XHD.BLL.ssn_art_menu();

        public string Name { get; set; }  //文章名称

        string empname = string.Empty;
        string uid = string.Empty;
        string depid = string.Empty;
        string roletype = string.Empty;
        string factory_Id = string.Empty;

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
                if (!string.IsNullOrEmpty(Request.QueryString["flag"].ToString()))
                {
                    this.bindArticle();
                    Page.Title = Name + "-" + "新明辉SSN";
                }
                else
                {
                    Response.Write("<script>alert('不存在该页面！');document.location='main_scm.aspx';</script>");
                    return;
                }
            }
        }


        //绑定数据
        public void bindArticle()
        {
            string s = Request.QueryString["flag"].ToString();

            string urlList = string.Empty;

            if (!string.IsNullOrEmpty(Request.QueryString["flag"].ToString()))
            {
                DataSet ds = _art.GetList("factory_Id='" + factory_Id + "' and Id='" + Request.QueryString["flag"].ToString() + "'");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    Name = ds.Tables[0].Rows[0]["Art_title"].ToString();
                    this.ltrTitle.Text = ds.Tables[0].Rows[0]["Art_title"].ToString();
                    this.ltrContent.Text = ds.Tables[0].Rows[0]["Art_Content"].ToString().Replace("�", "");
                    urlList = ds.Tables[0].Rows[0]["image_lst"].ToString();
                }

                if (!string.IsNullOrEmpty(urlList))
                {
                    urlList = urlList.Remove(urlList.Length - 1, 1);
                    List<string> lstImg = urlList.Split(',').ToList();
                    List<MyImage> lstMyImage = new List<MyImage>();
                    foreach (string item in lstImg)
                    {
                        lstMyImage.Add(new MyImage { ImgUrl = item });
                    }
                    this.repImage.DataSource = lstMyImage;
                }
                else
                {
                    this.repImage.DataSource = "";
                }

                this.repImage.DataBind();
            }
        }

        public class MyImage
        {
            public string ImgUrl { get; set; }
        }
    }
}