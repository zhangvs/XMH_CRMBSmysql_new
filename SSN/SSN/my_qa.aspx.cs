using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SSN.DataSSN;
using XHD.Common;


namespace SSN.SSN
{
    public partial class my_qa : System.Web.UI.Page
    {
        static string selectVal = "All";
        static string searchVal = string.Empty;
        XHD.BLL.ssn_question question = new XHD.BLL.ssn_question();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                selectVal = "All";
                selectBind(selectVal, searchVal);
            }

        }
        //绑定数据
        public void bind(int questionstatus, string searchVal)
        {
            XHD.Model.hr_employee empModel = new GetEmpInfo().GetEmpModel(Request);
            string Total = string.Empty;
            string filedOrder = " q_time desc";   //this.AspNetPager1.StartRecordIndex,
            string strWhere = string.Empty;
            strWhere = " isdeleted = 0 and q_uid=" + empModel.ID;
            if (questionstatus != -1)
            {
                strWhere += " and status=" + questionstatus;
            }
            if (!string.IsNullOrEmpty(searchVal))
            {
                strWhere += " and title like '%" + searchVal + "%'";
            }
            this.repCustomer.DataSource = question.GetList(this.AspNetPager1.PageSize, this.AspNetPager1.CurrentPageIndex, strWhere, filedOrder, out Total);
            this.repCustomer.DataBind();
            this.AspNetPager1.RecordCount = Convert.ToInt32(Total);
            if (questionstatus == -1)
            {
                this.Label1.Text = Total.ToString();
            }
            this.AspNetPager1.CustomInfoHTML = "<span style=\"float:left;padding-left:14px;\">信息总数：<font color=\"Red\"><b>" + AspNetPager1.RecordCount.ToString() + "</b></font>";
            AspNetPager1.CustomInfoHTML += " 总页数：<font color=\"Red\"><b>" + AspNetPager1.PageCount.ToString() + "</b></font></span>";
        }

        //分页页数改变时候
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            selectBind(selectVal, searchVal);
        }

        protected void repCustomer_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            if (e.CommandName == "delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                XHD.Model.ssn_question question = new XHD.Model.ssn_question();
                question = new XHD.BLL.ssn_question().GetModel(id);
                question.isdeleted = 1;
                bool isdeleted = new XHD.BLL.ssn_question().Update(question);
                if (isdeleted)
                {
                    selectBind(selectVal, searchVal);
                }
            }
        }
        protected void lbtnAll_Command(object sender, CommandEventArgs e)
        {
            string Argument = e.CommandName.ToString();
            selectBind(Argument, searchVal);
        }

        protected void selectBind(string Argument, string searchVal)
        {
            selectVal = Argument;
            switch (Argument)
            {
                case "All":
                    bind(Convert.ToInt32(QuestionStatus.全部), searchVal);
                    break;
                case "waiting-processed":

                    bind(Convert.ToInt32(QuestionStatus.待处理), searchVal);
                    break;
                case "processing":
                    bind(Convert.ToInt32(QuestionStatus.处理中), searchVal);
                    break;
                case "waiting-confirmed":
                    bind(Convert.ToInt32(QuestionStatus.待确认), searchVal);
                    break;
                case "waiting-evaluated":
                    bind(Convert.ToInt32(QuestionStatus.待评价), searchVal);
                    break;
                case "completed":
                    bind(Convert.ToInt32(QuestionStatus.已完成), searchVal);
                    break;
                default:
                    break;
            }
        }
        //搜索按钮
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchVal = this.txtSearch.Text;
            selectBind(selectVal, searchVal);
        }




    }
}