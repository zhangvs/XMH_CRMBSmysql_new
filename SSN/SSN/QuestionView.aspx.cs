using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SSN.DataSSN;

namespace SSN.SSN
{
    public partial class QuestionView : System.Web.UI.Page
    {
        XHD.BLL.ssn_question question = new XHD.BLL.ssn_question();
        XHD.BLL.ssn_answer answer = new XHD.BLL.ssn_answer();
        XHD.Model.ssn_answer answerModel = new XHD.Model.ssn_answer();
        XHD.BLL.ssn_question_add q_add = new XHD.BLL.ssn_question_add();

        string from = string.Empty;
        string qid = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            from = Request["from"];

            if (!IsPostBack)
            {
                Session.Remove("h_qid");
                //设置当行栏
                if (string.IsNullOrEmpty(from))
                {
                    Response.Redirect("main.aspx");
                }
                else if (from == "question")
                {
                    this.LinkButton1.Text = "我的提问";
                }
                else if (from == "answer")
                {
                    this.LinkButton1.Text = "我的回答";
                }

                //如何问题id为空返回提问界面
                if (!string.IsNullOrEmpty(Request["question_id"]))
                {
                    bindData();
                }
                else
                {
                    Response.Redirect("Question.aspx");
                }
            }
        }

        //点击导航返回时
        protected void back_Click(object sender, EventArgs e)
        {
            if (from == "question")
            {
                Response.Redirect("Question.aspx");
            }
            else if (from == "answer")
            {
                Response.Redirect("Answer.aspx");
            }
        }

        //页面显示问题信息
        public void bindData()
        {
            XHD.Model.hr_employee empModel = new GetEmpInfo().GetEmpModel(Request);
            Session["empID"] = empModel.ID;
            qid = Request["question_id"] == null ? Session["h_qid"].ToString() : Request["question_id"];
            DataSet q_ds = question.GetQuestion("q.id=" + qid + " and isdeleted=0");
            if (q_ds != null && q_ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = q_ds.Tables[0].Rows[0];

                string q_pid = dr["q_uid"].ToString();
                string q_pname = dr["q_name"].ToString();
                string q_title = dr["title"].ToString();
                string q_content = dr["content"].ToString();
                string q_time = dr["q_time"] != null ? Convert.ToDateTime(dr["q_time"]).ToString("yyyy-MM-dd HH:mm:ss") : "";
                string q_imgepath = dr["headImg"].ToString();
                Session["h_qid"] = qid;
                Session["q_pid"] = q_pid;
                m_img.Src = q_imgepath == "" ? "../file/user/unset.jpg" : "http://172.178.1.211:8087/images/upload/portrait/" + q_imgepath;
                dq_name.InnerHtml = "<h5 class=\"text-gray\">" + q_pname + "</h5>";
                dq_title.InnerHtml = "<strong style=\"font-size: 18px\">" + q_title + "</strong>"
                                    + q_content;
                dq_time.InnerHtml = "<span>发表时间：" + q_time + "</span>";

                //获取附件值，分组
                if (!string.IsNullOrEmpty(dr["att_file"].ToString()))
                {
                    string urlList = dr["att_file"].ToString().Remove(dr["att_file"].ToString().Length - 1, 1);

                    List<string> lstImg = urlList.Split(',').ToList();
                    List<MyImage> lstMyImage = new List<MyImage>();
                    foreach (string item in lstImg)
                    {
                        lstMyImage.Add(new MyImage { ImgUrl = item });
                    }
                    this.repImage.DataSource = lstMyImage;
                    //创建dataset
                    //DataSet ds = new DataSet();
                    //System.Data.DataTable dt = new System.Data.DataTable();
                    //DataColumn dcSj = new DataColumn("ImgUrl", typeof(string));
                    //dt.Columns.Add(dcSj);
                    //for (int i = 0; i < img.Length; i++)
                    //{
                    //    DataRow drs = dt.NewRow();
                    //    drs[0] = img[i];
                    //    dt.Rows.Add(drs);
                    //}
                    //ds.Tables.Add(dt);

                    //this.repImage.DataSource = ds;
                    this.repImage.DataBind();
                }
                this.bind();
            }
            else
            {
                Session["h_qid"] = qid;
                m_img.Src = "../images/system.jpg";
                dq_name.InnerHtml = "<h5 class=\"text-gray\">系统提示</h5>";
                dq_title.InnerHtml = "<strong style=\"font-size: 18px\">此问题已被发布者删除！</strong>";
            }
        }

        //显示回复信息
        public void bind()
        {
            if (string.IsNullOrEmpty(qid))
            {
                qid = Session["h_qid"].ToString();
            }
            string Total = string.Empty;
            string filedOrder = " answer_time,is_best desc ";   //this.AspNetPager1.StartRecordIndex,
            string strWhere = "a.qid=" + qid;

            DataSet ds = answer.GetList(this.AspNetPager1.PageSize, this.AspNetPager1.CurrentPageIndex, strWhere, filedOrder, out Total);
            this.repCustomer.DataSource = ds;
            this.repCustomer.DataBind();
            this.AspNetPager1.RecordCount = Convert.ToInt32(Total);
            this.AspNetPager1.CustomInfoHTML = "<span style=\"float:left;padding-left:14px;\">回复总数：<font color=\"Red\"><b>" + AspNetPager1.RecordCount.ToString() + "</b></font>";
            AspNetPager1.CustomInfoHTML += " 总页数：<font color=\"Red\"><b>" + AspNetPager1.PageCount.ToString() + "</b></font></span>";

        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            this.bind();
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {

            this.bind();
        }

        //点击回复按钮时
        protected void repCustomer_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "publish")
            {
                Repeater rep = e.Item.FindControl("addQuestion") as Repeater;//找到里层的repeater对象
                int id = Convert.ToInt32(e.CommandArgument);
                rep.DataSource = q_add.GetList(" answer_id=" + id + " order by operatortime");
                rep.DataBind();
            }
            //else if (e.CommandName == "makeBestAnswer")
            //{
            //    bool success = false;
            //    answerModel = answer.GetModel(Convert.ToInt64(e.CommandArgument));
            //    if (answerModel != null)
            //    {
            //        answerModel.is_best = 1;
            //        success = answer.Update(answerModel);
            //        if (success)
            //        {
            //            this.bind();
            //        }
            //    }
            //}
        }

        protected void rptypelist_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            //判断里层repeater处于外层repeater的哪个位置（ AlternatingItemTemplate，FooterTemplate，

            //HeaderTemplate，，ItemTemplate，SeparatorTemplate）
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater rep = e.Item.FindControl("addQuestion") as Repeater;//找到里层的repeater对象
                DataRowView rowv = (DataRowView)e.Item.DataItem;//找到分类Repeater关联的数据项 
                int id = Convert.ToInt32(rowv["id"]); //获取填充子类的id 
                rep.DataSource = q_add.GetList(" answer_id=" + id + " order by operatortime");
                rep.DataBind();
            }
        }
    }

    public class MyImage
    {
        public string ImgUrl { get; set; }
    }
}