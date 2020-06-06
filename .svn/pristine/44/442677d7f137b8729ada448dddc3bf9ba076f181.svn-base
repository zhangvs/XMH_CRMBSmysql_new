using SSN.DataSSN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSN.SSN
{
    public partial class QuickQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XHD.Model.hr_employee empModel = new GetEmpInfo().GetEmpModel(Request);

            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(empModel.title))
                {
                    this.Image1.ImageUrl = "http://172.178.1.211:8087/images/upload/portrait/" + empModel.title;
                    this.Image2.ImageUrl = "http://172.178.1.211:8087/images/upload/portrait/" + empModel.title;
                }
                else
                {
                    this.Image1.ImageUrl = "../file/user/unset.jpg";
                    this.Image2.ImageUrl = "../file/user/unset.jpg";
                }
                this.lblNmae.Text = empModel.name;
                this.lblName1.Text = empModel.name;
                //this.lblSum.Text = "39";
                //this.lblUnread.Text = "您有26条未读消息";
                //this.lblReply.Text = "您有13条回复消息";
                this.lblWelcome.Text = "您好，" + empModel.name + "，欢迎使用SSN问答中心。";
                this.lblScore.Text = "88";
                this.lblQuestion.Text = "156";
                this.lblAnswer.Text = "250";
                this.lblRate.Text = "39.95%";
                this.lblGood.Text = "56";

            }
        }
    }
}