using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using DotNet.Utilities;

namespace SSN.DataSSN
{
    /// <summary>
    /// SSN_Question 的摘要说明
    /// </summary>
    public class SSN_Question : IHttpHandler
    {
        public static string PostUrl = ConfigurationManager.AppSettings["WebReference.Service.PostUrl"];//短信接口地址
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";


            HttpRequest request = context.Request;
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            XHD.Model.hr_employee empModel = new GetEmpInfo().GetEmpModel(request);

            string json = null;
            string Action = request["Action"];
            switch (Action)
            {
                case "action":
                    bool success = false;
                    string filesVal = request["filesVal"];
                    string txtQuestionTitle = request["txtQuestionTitle"];
                    if (string.IsNullOrEmpty(txtQuestionTitle))
                    {
                        var result = new { success = success, text = "问题标题不能为空!" };
                        json = javaScriptSerializer.Serialize(result);
                        context.Response.Write(json);

                    }
                    string selQestionType = request["selQestionType"];
                    if (selQestionType == "-1")
                    {
                        var result = new { success = success, text = "请选择问题类型!" };
                        json = javaScriptSerializer.Serialize(result);
                        context.Response.Write(json);

                    }
                    string txtQestionContent = request["txtQestionContent"];
                    string telPhone = request["telPhone"];
                    string radTime = request["radTime"];
                    string txtEmail = request["txtEmail"];
                    string sp_uid = request["sp_uid"];

                    XHD.Model.ssn_question question = new XHD.Model.ssn_question();
                    question.att_file = filesVal;
                    question.content = txtQestionContent;
                    question.e_mail = txtEmail;
                    question.type = Convert.ToInt32(selQestionType);
                    question.title = txtQuestionTitle;
                    question.tel = telPhone;
                    question.q_time = DateTime.Now;
                    question.q_uid = empModel.ID;
                    question.q_name = empModel.name;
                    question.sp_uid = sp_uid;
                    success = new XHD.BLL.ssn_question().Add(question);
                    if (success)
                    {
                        #region 发送短信
                        //string account = "cf_denny";
                        //string password = "LY@xmh201612";//密码可以使用明文密码或使用32位MD5加密
                        //string mobile = telPhone;
                        //Random rad = new Random();
                        ////int mobile_code = rad.Next(1000, 10000);
                        ////string content = "您的验证码是：" + mobile_code + " 。请不要把验证码泄露给其他人。";
                        //int int1 = 1;
                        //string strcontent = "你最近吃饭了吗?";
                        //string content = "你好，" + int1 + "需采购以下产品，" + strcontent + "。 ";
                        ////Session["mobile"] = mobile;
                        ////Session["mobile_code"] = mobile_code;

                        //string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

                        //UTF8Encoding encoding = new UTF8Encoding();
                        //byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

                        //HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(PostUrl);
                        //myRequest.Method = "POST";
                        //myRequest.ContentType = "application/x-www-form-urlencoded";
                        //myRequest.ContentLength = postData.Length;

                        //Stream newStream = myRequest.GetRequestStream();
                        //// Send the data.
                        //newStream.Write(postData, 0, postData.Length);
                        //newStream.Flush();
                        //newStream.Close();

                        //HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                        #region 提示是否发送成功，暂时只管发送不验证成功与否
                        //if (myResponse.StatusCode == HttpStatusCode.OK)
                        //{
                        //    StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

                        //    //Response.Write(reader.ReadToEnd());

                        //    string res = reader.ReadToEnd();
                        //    int len1 = res.IndexOf("</code>");
                        //    int len2 = res.IndexOf("<code>");
                        //    string code = res.Substring((len2 + 6), (len1 - len2 - 6));
                        //    //Response.Write(code);

                        //    int len3 = res.IndexOf("</msg>");
                        //    int len4 = res.IndexOf("<msg>");
                        //    string msg = res.Substring((len4 + 5), (len3 - len4 - 5));
                        //    context.Response.Write(msg);

                        //    //Response.End();

                        //}
                        //else
                        //{
                        //    //访问失败
                        //}
                        #endregion
                        #endregion
                        var dataResult = new { success = success, text = "提交成功!" };
                        json = javaScriptSerializer.Serialize(dataResult);
                    }
                    else
                    {
                        var dataResult = new { success = success, text = "提交失败!" };
                        json = javaScriptSerializer.Serialize(dataResult);
                    }
                    context.Response.Write(json);
                    break;
                case "deleteFile":
                    string path = string.Empty;
                    string fileName = request["fileName"];
                    string targetDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "File/question");
                    path = System.IO.Path.Combine(targetDir, fileName);
                    File.Delete(path);
                    context.Response.Write("删除成功！");
                    break;
                case "getAboutQuestionList":
                    //获得相关问题列表
                    string strWhere = "1=1";
                    string strWhereArt = "1=1";
                    XHD.BLL.ssn_question questionBll = new XHD.BLL.ssn_question();
                    XHD.BLL.ssn_art artBll = new XHD.BLL.ssn_art();
                    string txtQuestionTitleEx = request["txtQuestionTitle"];
                    if (!string.IsNullOrEmpty(txtQuestionTitleEx))
                    {

                        List<string> strList = new List<string>();
                        char[] charList = txtQuestionTitleEx.ToArray();
                        for (int i = 0; i < charList.Length; i++)
                        {
                            if (i == 0)
                            {
                                strWhere += " and title like '%" + charList[i] + "%'";
                                strWhereArt += " and Art_title like '%" + charList[i] + "%'";
                            }
                            else
                            {
                                strWhere += " or title like '%" + charList[i] + "%'";
                                strWhereArt += " or Art_title like '%" + charList[i] + "%'";
                            }
                            if (!strList.Contains(charList[i].ToString()))
                            {
                                strList.Add(charList[i].ToString());
                            }
                        }
                        Segment seg = new Segment();
                        seg.InitWordDics();
                        seg.EnablePrefix = true;
                        seg.Separator = " ";
                        string Seg_Title = seg.SegmentText(txtQuestionTitleEx, false).Trim();

                        string[] titleArray = Seg_Title.Split(' ');
                        for (int i = 0; i < titleArray.Length; i++)
                        {
                            strWhere += " or title like '%" + titleArray[i] + "%'";
                            strWhereArt += " or Art_title like '%" + titleArray[i] + "%'";
                        }
                        List<XHD.Model.ssn_question> questionList = new List<XHD.Model.ssn_question>();
                        questionList = questionBll.GetModelList(strWhere);

                        List<XHD.Model.ssn_art> artList = new List<XHD.Model.ssn_art>();
                        artList = artBll.GetModelList(strWhereArt);

                        List<XHD.Model.question> modelList = new List<XHD.Model.question>();
                        foreach (XHD.Model.ssn_question item in questionList)
                        {
                            XHD.Model.question model = new XHD.Model.question();
                            model.id = item.id;
                            model.title = item.title;
                            model.q_time = item.q_time;
                            model.status = 1;
                            modelList.Add(model);
                        }
                        foreach (XHD.Model.ssn_art item in artList)
                        {
                            XHD.Model.question model = new XHD.Model.question();
                            model.id = item.Id;
                            model.title = item.Art_title;
                            model.q_time = item.Create_Date;
                            model.status = 2;
                            modelList.Add(model);
                        }
                        for (int i = 0; i < modelList.Count; i++)
                        {
                            string temStr = modelList[i].title.ToString();
                            for (int j = 0; j < strList.Count; j++)
                            {
                                if (temStr.Contains(strList[j]))
                                {
                                    modelList[i].title = modelList[i].title.ToString().Replace(strList[j], "<span style='color:red' >" + strList[j] + "</span>");
                                }
                            }
                        }
                        var data = new { rows = modelList };
                        json = javaScriptSerializer.Serialize(data);
                        context.Response.Write(json);
                    }
                    break;
                case "getQuestionType":
                    XHD.BLL.ssn_art_menu questionTypeBll = new XHD.BLL.ssn_art_menu();
                    List<XHD.Model.ssn_art_menu> questionTyleList = new List<XHD.Model.ssn_art_menu>();
                    string strQuestionTypeWhere = "1=1";
                    strQuestionTypeWhere += " and App_id=1 and parentid<>0";
                    questionTyleList = questionTypeBll.GetModelList(strQuestionTypeWhere);
                    var questionTypeData = new { rows = questionTyleList };
                    json = javaScriptSerializer.Serialize(questionTypeData);
                    context.Response.Write(json);
                    break;
                default:
                    string pathFile = string.Empty;
                    try
                    {
                        //获取客户端上传的文件集合
                        HttpFileCollection files = System.Web.HttpContext.Current.Request.Files;
                        //判断是否存在文件
                        if (files.Count > 0)
                        {
                            //获取文件集合中的第一个文件(每次只上传一个文件)
                            HttpPostedFile file = files[0];
                            //定义文件存放的目标路径
                            string targetDirFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "File/question");
                            if (!Directory.Exists(targetDirFile))
                            { Directory.CreateDirectory(targetDirFile); }
                            //组合成文件的完整路径
                            pathFile = System.IO.Path.Combine(targetDirFile, System.IO.Path.GetFileName(file.FileName));
                            //保存上传的文件到指定路径中
                            file.SaveAs(pathFile);
                            context.Response.Write(file.FileName);
                        }
                    }
                    catch
                    {

                    }
                    break;
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