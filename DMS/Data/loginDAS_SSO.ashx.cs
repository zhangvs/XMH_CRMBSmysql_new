using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

namespace XHD.DMS.Data
{
    /// <summary>
    /// loginDAS_SSO 的摘要说明
    /// </summary>
    public class loginDAS_SSO : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";
            HttpRequest request = context.Request;

            //string param = PostInput(HttpContext.Current);
            //string[] paramstr = param.Split('&');
            string uid = request["uid"];
            string pwd = request["pwd"];
            //foreach (string item in paramstr)
            //{
            //    if (item.IndexOf("uid") != -1)
            //    {
            //        uid = item.Split('=')[1];
            //    }
            //    else if (item.IndexOf("pwd") != -1)
            //    {
            //        pwd = item.Split('=')[1];
            //    }
            //}

            BLL.hr_employee emp = new BLL.hr_employee();
            BLL.Sys_FactoryInfo fty = new BLL.Sys_FactoryInfo();
            BLL.ecs_admin_user ecsadmin = new BLL.ecs_admin_user();

            if (!string.IsNullOrEmpty(pwd) && !string.IsNullOrEmpty(uid))  //判断pwd与uid不为空
            {
                DataSet ds = emp.GetList(" uid = '" + uid + "'");

                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["pwd"].ToString() == pwd)   //判断可以找到该用户
                {
                    string factory_Id = ds.Tables[0].Rows[0]["Factory_Id"].ToString();


                    #region 创建HttpCookie

                    if (ds.Tables[0].Rows[0]["uid"].ToString() == "admin")
                    {
                        string userid = ds.Tables[0].Rows[0]["ID"].ToString();
                        string username = ds.Tables[0].Rows[0]["uid"].ToString();
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                            1,
                            username,
                            DateTime.Now,
                            DateTime.Now.AddMinutes(20),
                            true,
                            userid,
                            "/"
                            );
                        var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                        cookie.HttpOnly = true;
                        context.Response.Cookies.Add(cookie);

                        //FormsAuthentication.SetAuthCookie(userid, true);

                        //日志
                        //BLL.Sys_log log = new BLL.Sys_log();
                        //Model.Sys_log modellog = new Model.Sys_log();
                        //modellog.EventType = "系统登录";

                        //modellog.EventDate = DateTime.Now;
                        //modellog.UserID = int.Parse(userid);
                        //modellog.UserName = ds.Tables[0].Rows[0]["name"].ToString();
                        //modellog.IPStreet = request.UserHostAddress;
                        //modellog.Factory_Id = factory_Id;

                        //log.Add(modellog);

                        //online
                        BLL.Sys_online sol = new BLL.Sys_online();
                        Model.Sys_online model = new Model.Sys_online();

                        model.UserName = ds.Tables[0].Rows[0]["name"].ToString();
                        model.UserID = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                        model.LastLogTime = DateTime.Now;

                        DataSet ds1 = sol.GetList(" UserID=" + ds.Tables[0].Rows[0]["id"].ToString());

                        //添加当前用户信息
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            sol.Update(model, " UserID=" + ds.Tables[0].Rows[0]["id"].ToString());
                        }
                        else
                        {
                            sol.Add(model);
                        }
                        //删除超时用户
                        //2分钟用户失效，删除 --Robert 2015-11-24
                        sol.Delete(" LastLogTime<date_sub(now(), interval 5 minute)");

                        //验证完毕，允许登录
                        string returnJson = @"{result: 'true',uid: '" + username + "'}";
                        context.Response.Write(returnJson);
                    }
                    else
                    {

                        DataSet dsfty = fty.GetList("Factory_Id='" + factory_Id + "'");
                        string username = ds.Tables[0].Rows[0]["uid"].ToString();
                        string isDelete = dsfty.Tables[0].Rows[0]["IsDelete"].ToString();
                        if (int.Parse(isDelete) == 0)
                        {
                            if (ds.Tables[0].Rows[0]["canlogin"].ToString() == "1")
                            {
                                string userid = ds.Tables[0].Rows[0]["ID"].ToString();
                                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                                    1,
                                    username,
                                    DateTime.Now,
                                    DateTime.Now.AddMinutes(20),
                                    true,
                                    userid,
                                    "/"
                                    );
                                var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                                cookie.HttpOnly = true;
                                context.Response.Cookies.Add(cookie);

                                //FormsAuthentication.SetAuthCookie(userid, true);

                                //日志
                                //BLL.Sys_log log = new BLL.Sys_log();
                                //Model.Sys_log modellog = new Model.Sys_log();
                                //modellog.EventType = "系统登录";

                                //modellog.EventDate = DateTime.Now;
                                //modellog.UserID = int.Parse(userid);
                                //modellog.UserName = ds.Tables[0].Rows[0]["name"].ToString();
                                //modellog.IPStreet = request.UserHostAddress;
                                //modellog.Factory_Id = factory_Id;

                                //log.Add(modellog);

                                //online
                                BLL.Sys_online sol = new BLL.Sys_online();
                                Model.Sys_online model = new Model.Sys_online();

                                model.UserName = ds.Tables[0].Rows[0]["name"].ToString();
                                model.UserID = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                                model.LastLogTime = DateTime.Now;

                                DataSet ds1 = sol.GetList(" UserID=" + ds.Tables[0].Rows[0]["id"].ToString());

                                //添加当前用户信息
                                if (ds1.Tables[0].Rows.Count > 0)
                                {
                                    sol.Update(model, " UserID=" + ds.Tables[0].Rows[0]["id"].ToString());
                                }
                                else
                                {
                                    sol.Add(model);
                                }
                                //删除超时用户
                                //2分钟用户失效，删除 --Robert 2015-11-24
                                sol.Delete(" LastLogTime<date_sub(now(), interval 5 minute)");

                                //验证完毕，允许登录
                                string returnJson = @"{result: 'true',uid: '" + username + "'}";
                                context.Response.Write(returnJson);
                            }
                            else
                            {
                                string returnJson = @"{result: 'false',uid: '11111',msg;'不允许登录'}";
                                context.Response.Write(returnJson);//不允许登录
                            }
                        }
                        else
                        {
                            string returnJson = @"{result: 'false',uid: '11111',msg;'不允许登录'}";
                            context.Response.Write(returnJson);//不允许登录
                        }
                    }
                    #endregion
                }
                else
                {
                    string returnJson = @"{result: 'false',uid: '11111',msg;'用户名或密码错误'}";
                    context.Response.Write(returnJson);//用户名或密码错误
                }
            }
            else
            {
                string returnJson = @"{result: 999,uid: '11111',msg;'系统数据错误'}";
                context.Response.Write(returnJson);//系统数据错误
            }
        }

        private string PostInput(HttpContext context)
        {
            try
            {
                System.IO.Stream s = context.Request.InputStream;
                int count = 0;
                byte[] buffer = new byte[1024];
                StringBuilder builder = new StringBuilder();
                while ((count = s.Read(buffer, 0, 1024)) > 0)
                {
                    builder.Append(Encoding.GetEncoding("GB2312").GetString(buffer, 0, count));
                }
                s.Flush();
                s.Close();
                s.Dispose();
                return builder.ToString();
            }
            catch (Exception ex)
            { throw ex; }
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