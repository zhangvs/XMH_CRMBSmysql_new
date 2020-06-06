using SSN.DataSSN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSN.SSN
{
    public partial class QA : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XHD.Model.hr_employee empModel = new GetEmpInfo().GetEmpModel(Request);
            XHD.BLL.ssn_question question = new XHD.BLL.ssn_question();

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
                DataSet ds = question.GetQAInfo(empModel.ID);
                int qNum = Convert.ToInt32(ds.Tables[0].Rows[0]["qNum"].ToString());
                int aNum = Convert.ToInt32(ds.Tables[0].Rows[0]["aNum"].ToString());
                int bNum = Convert.ToInt32(ds.Tables[0].Rows[0]["bNum"].ToString());
                int gNum = Convert.ToInt32(ds.Tables[0].Rows[0]["gNum"].ToString());

                this.lblScore.Text = "0";
                this.lblQuestion.Text = qNum.ToString();
                this.lblAnswer.Text = aNum.ToString();

                if (aNum == 0 || bNum == 0)
                {
                    this.lblRate.Text = "0";
                }
                else
                {
                    double rate = bNum * 100.0 / aNum;
                    this.lblRate.Text = Math.Round(rate, 2).ToString() + "%";
                }

                if (gNum == 0 || bNum == 0)
                {
                    this.lblGood.Text = "0";
                }
                else
                {
                    double rate = gNum * 100.0 / bNum;
                    this.lblGood.Text = Math.Round(rate, 2).ToString() + "%";
                }

            }
        }
    }
}