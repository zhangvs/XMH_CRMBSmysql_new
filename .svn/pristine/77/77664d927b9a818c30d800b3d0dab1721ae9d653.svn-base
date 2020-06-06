using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Script.Serialization;
using XHD.Common;

namespace SSN.DataSSN
{
    /// <summary>
    /// SSN_Answer 的摘要说明
    /// </summary>
    public class SSN_Answer : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            XHD.BLL.ssn_answer answer = new XHD.BLL.ssn_answer();
            XHD.BLL.ssn_question question = new XHD.BLL.ssn_question();
            XHD.BLL.ssn_question_add q_add = new XHD.BLL.ssn_question_add();
            XHD.Model.ssn_answer model = new XHD.Model.ssn_answer();
            XHD.Model.ssn_question questionmodel = new XHD.Model.ssn_question();
            XHD.Model.ssn_question_add modelAdd = new XHD.Model.ssn_question_add();
            XHD.Model.hr_employee empModel = new GetEmpInfo().GetEmpModel(request);

            #region 问题回复
            if (request["Action"] == "q_reply")
            {
                string q_id = request["q_id"];
                string reply_str = HttpUtility.UrlDecode(HttpUtility.UrlDecode(request["reply_str"]));
                if (!string.IsNullOrEmpty(q_id) && !string.IsNullOrEmpty(reply_str))
                {
                    model.answer_time = DateTime.Now;
                    model.answer_content = reply_str;
                    model.answer_name = empModel.name;
                    model.answer_uid = empModel.ID;
                    model.qid = Convert.ToInt64(q_id);
                    if (answer.Add(model))
                    {
                        //获取model对象
                        XHD.Model.ssn_question modelQ = question.GetModel(Convert.ToInt64(q_id));
                        //更改问题状态
                        modelQ.status = 1;
                        //更新到数据库
                        question.Update(modelQ);

                        string re_str = "{success:true,msg:\"回复完成\"}";
                        context.Response.Write(re_str);
                    }
                    else
                    {
                        string re_str = "{success:false,msg:\"回复失败，数据库操作异常！\"}";
                        context.Response.Write(re_str);
                    }
                }
                else
                {
                    string re_str = "{success:false,msg:\"回复失败，数据库操作异常！\"}";
                    context.Response.Write(re_str);
                }
            }
            #endregion

            #region 设置回复是否可用
            else if (request["Action"] == "permission_reply")
            {
                string q_id = request["q_id"];
                if (!string.IsNullOrEmpty(q_id))
                {
                    string re_str = "{";
                    DataSet ds = question.GetList("id=" + q_id);
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        //当问题为自己提问或已完成时，隐藏回答
                        if (ds.Tables[0].Rows[0]["sp_uid"].ToString() != ",all," && (ds.Tables[0].Rows[0]["sp_uid"].ToString().IndexOf(empModel.ID + ",") < 0) || ds.Tables[0].Rows[0]["status"].ToString() == "4" || ds.Tables[0].Rows[0]["isdeleted"].ToString() == "1" || ds.Tables[0].Rows[0]["status"].ToString() == "3")
                        {
                            re_str += "success:true,msg:\"不能回答！\"";

                        }
                        else if (empModel.ID.ToString() == ds.Tables[0].Rows[0]["q_uid"].ToString())
                        {
                            re_str += "success:true,msg:\"不能回答！\"";
                        }
                        else
                        {
                            re_str += "success:false,msg:\"通过！\"";
                        }
                    }
                    else
                    {
                        re_str += "success:false,msg:\"数据库操作异常！\"";
                    }
                    #region 判断是否含有最佳答案 如果已含有则不在显示“评最佳答案”按钮

                    DataSet dsAnswer = answer.GetList("qid=" + q_id + " and is_best=1");
                    if (dsAnswer.Tables[0].Rows.Count > 0)
                    {
                        re_str += ",flag:true,id:" + dsAnswer.Tables[0].Rows[0]["id"] + ",evaluatelevel:" + dsAnswer.Tables[0].Rows[0]["evaluatelevel"];
                    }
                    else
                    {
                        re_str += ",flag:false";
                    }
                    #endregion
                    re_str += "}";
                    context.Response.Write(re_str);
                }
            }
            #endregion

            #region 追答
            else if (request["Action"] == "add_reply")
            {
                string answer_id = request["curID"];
                string q_id = request["q_id"];
                string curName = request["curName"];
                string curUid = request["curUid"];
                string content = PageValidate.InputText(request["content"], Int32.MaxValue);

                if (!string.IsNullOrEmpty(content))
                {
                    modelAdd.answer_id = Convert.ToInt32(answer_id);
                    modelAdd.answer_name = empModel.name;
                    modelAdd.answer_uid = empModel.ID;
                    modelAdd.content = content;
                    modelAdd.operatortime = DateTime.Now;
                    modelAdd.question_name = curName;
                    modelAdd.question_uid = Convert.ToInt32(curUid);
                    modelAdd.type = 0;
                    modelAdd.question_id = Convert.ToInt32(q_id);

                    if (q_add.Add(modelAdd))
                    {
                        string re_str = "{success:true,msg:\"成功！\"}";
                        context.Response.Write(re_str);
                    }
                    else
                    {
                        string re_str = "{success:flase,msg:\"数据库操作异常！\"}";
                        context.Response.Write(re_str);
                    }

                }
                else
                {
                    string re_str = "{success:flase,msg:\"程序执行异常！\"}";
                    context.Response.Write(re_str);
                }


            }
            else if (request["Action"] == "makeBestAnswer")
            {
                bool success = false;
                bool successquestion = false;
                model = answer.GetModel(Convert.ToInt64(request["id"]));
                if (model != null)
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {
                            model.is_best = 1;
                            success = answer.Update(model);
                            questionmodel = question.GetModel(model.qid.Value);
                            questionmodel.status = Convert.ToInt32(QuestionStatus.待评价);
                            successquestion = question.Update(questionmodel);
                            transaction.Complete();
                        }
                        catch
                        {
                            transaction.Dispose();
                        }

                    }
                }
                var dataResult = new { succ = success, evaluatelevel = model.evaluatelevel };
                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                var json = javaScriptSerializer.Serialize(dataResult);
                context.Response.Write(json);

                //model = answer.GetModel(Convert.ToInt64(request["id"]));
                //if (model!=null)
                //{
                //    model.is_best = 1;
                //    success = answer.Update(model);

                //}
                //context.Response.Write(success);

                //model = answer.GetModel(Convert.ToInt64(request["id"]));
                //if (model != null)
                //{
                //    model.is_best = 1;
                //    success = answer.Update(model);

                //}
                //context.Response.Write(success);

            }
            #endregion


            else if (request["Action"] == "SubmitEvaluatVal")
            {
                bool sucess = false;
                bool successquestion = false;
                string text = string.Empty;
                string answerid = request["answerid"];
                if (answerid == null)
                {
                    text = "没设最佳答案，不能评分，请设置最佳答案后再评分！";
                    context.Response.Write(text);
                    return;
                }
                string evaluatVal = request["evaluatVal"];
                XHD.Model.ssn_answer answermodel = new XHD.Model.ssn_answer();
                XHD.BLL.ssn_answer answerBll = new XHD.BLL.ssn_answer();
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        answermodel = answerBll.GetModel(Convert.ToInt64(answerid));
                        if (answermodel != null)
                        {
                            if (answermodel.evaluatelevel > 0)
                            {
                                text = "已评价，不允许重复评价！";
                                context.Response.Write(text);
                                return;
                            }
                            answermodel.evaluatelevel = Convert.ToInt32(evaluatVal);
                        }
                        sucess = answerBll.Update(answermodel);
                        if (sucess)
                        {
                            questionmodel = question.GetModel(answermodel.qid.Value);
                            questionmodel.status = Convert.ToInt32(QuestionStatus.已完成);
                            successquestion = question.Update(questionmodel);
                            if (successquestion)
                            {
                                text = "提交成功!";
                            }

                        }
                        else
                        {
                            text = "提交失败!";
                        }
                        context.Response.Write(text);
                        transaction.Complete();
                    }
                    catch
                    {
                        transaction.Dispose();
                    }

                }
            }

            #region 问题转移
            else if (request["Action"] == "transfer")
            {
                string qid = request["qid"];
                string rid = request["rid"];
                if (!string.IsNullOrEmpty(qid) && !string.IsNullOrEmpty(rid))
                {
                    XHD.Model.ssn_question modelq = new XHD.Model.ssn_question();
                    modelq = question.GetModel(Convert.ToInt32(qid));
                    if (modelq.sp_uid != ",all,")
                    {
                        modelq.sp_uid = rid;
                        modelq.move_time = DateTime.Now;
                        if (question.Update(modelq))
                        {
                            string re_str = "{success:true,msg:\"转移成功！\"}";
                            context.Response.Write(re_str);
                        }
                        else
                        {
                            string re_str = "{success:false,msg:\"数据库操作异常！\"}";
                            context.Response.Write(re_str);
                        }
                    }
                    else
                    {
                        string re_str = "{success:false,msg:\"公开问题无需转移！\"}";
                        context.Response.Write(re_str);
                    }
                }
            }
            #endregion
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