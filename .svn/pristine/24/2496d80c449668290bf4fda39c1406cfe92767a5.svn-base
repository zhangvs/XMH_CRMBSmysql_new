using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
using XHD.Common;
using System.Net;

namespace XHD.DMS.Data
{
    /// <summary>
    /// login 的摘要说明
    /// </summary>
    public class login : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";
            HttpRequest request = context.Request;

            if (request["Action"] == "login")
            {
                BLL.hr_employee emp = new BLL.hr_employee();
                BLL.Sys_FactoryInfo fty = new BLL.Sys_FactoryInfo();

                string username = PageValidate.InputText(request["username"], 255);
                //string password = FormsAuthentication.HashPasswordForStoringInConfigFile(request["password"], "MD5");
                string password = PageValidate.InputText(request["password"], 255);
                string validate = PageValidate.InputText(request["validate"], 255);

                //SQL注入式攻击过滤===========================================================================================
                string path = context.Server.MapPath(@"../file/SQLFile.txt");
                if (CommonData.getSQLPercolation(username.ToUpper(), path))
                {
                    context.Response.Write("999");//系统错误
                    return;
                }
                //============================================================================================================

                if (!string.IsNullOrEmpty(validate) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    if (validate == context.Session["CheckCode"].ToString() || validate.ToLower() == context.Session["CheckCode"].ToString().ToLower())
                    {
                        //DataSet ds = emp.GetList(" uid='" + username + "' and pwd='" + password + "'");
                        Model.hr_employee empModel = emp.LoginUser(username);
                        //IP 限制====================================================================================================
                        string vrip = GetClientIPv4Address();

                        List<string> lstIp = new List<string>();
                        lstIp.Add("219.146.197.91");    //电信IP地址
                        lstIp.Add("60.213.50.226");     //联通IP地址

                        lstIp.Add("172.178.1.118");     //本地（邢荣）
                        lstIp.Add("172.178.1.211");     //本地（陈伟）
                        lstIp.Add("172.178.1.100");     //本地（陈伟）
                        lstIp.Add("172.178.1.203");     //本地（robert）
                        lstIp.Add("172.178.1.201");     //本地（李明）
                        lstIp.Add("172.178.1.79");      //本地（王德胜）
                        lstIp.Add("172.178.1.117");     //本地（王立全）
                        lstIp.Add("172.178.1.243");     //本地（王虎）
                        //if (!lstIp.Contains(vrip))
                        //{
                        //    //修改：robert, 2016-06-04     过滤特殊人群，当前：王频频wpp6274========
                        //    if (username.Trim() != "wpp6274" && username.Trim() != "gjc1010")
                        //    {
                        //        context.Response.Write("6");//ip受限制
                        //        return;
                        //    }
                        //    //=======================================================================
                        //}
                        //============================================================================================================

                        if (empModel != null && empModel.pwd == password.ToUpper())
                        {
                            //只允许李辉、郭建传，李艳梅，admin登录
                            //if (username.Trim() != "li5001" && username.Trim() != "1010" && username.Trim() != "lym5007" && username.Trim() != "admin" && username.Trim() != "yqy5062" && username.Trim() != "lgh1128" && username.Trim() != "lc1271" && username.Trim() != "zf6346")
                            //{
                            //    context.Response.Write("6");//ip受限制
                            //    return;
                            //}
                            //=======================================================================
                            //存在该 uid的用户，并且 pwd-密码正确；执行以下内容
                            //if (ds.Tables[0].Rows.Count > 0)
                            //{
                            if (empModel.uid.Trim() == "admin")
                            {
                                #region
                                //string userid = empModel.ID.ToString();
                                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                                    1,
                                    empModel.uid,
                                    DateTime.Now,
                                    DateTime.Now.AddMinutes(20),
                                    true,
                                    empModel.ID.ToString(),
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
                                //modellog.UserID = empModel.ID;
                                //modellog.UserName = empModel.name;
                                //modellog.IPStreet = request.UserHostAddress;
                                //modellog.Factory_Id = empModel.factory_Id;

                                //log.Add(modellog);

                                //online
                                BLL.Sys_online sol = new BLL.Sys_online();
                                Model.Sys_online model = new Model.Sys_online();

                                model.UserName = empModel.name;
                                model.UserID = empModel.ID;
                                model.LastLogTime = DateTime.Now;

                                DataSet ds1 = sol.GetList(" UserID=" + empModel.ID);

                                //添加当前用户信息
                                if (ds1.Tables[0].Rows.Count > 0)
                                {
                                    sol.Update(model, " UserID=" + empModel.ID);
                                }
                                else
                                {
                                    sol.Add(model);
                                }
                                //删除超时用户
                                //2分钟用户失效，删除 --Robert 2015-11-24
                                sol.Delete(" LastLogTime<date_sub(now(), interval 5 minute)");

                                //验证完毕，允许登录
                                context.Response.Write("2");
                                #endregion
                            }
                            else
                            {
                                #region
                                DataSet dsfty = fty.GetList("Factory_Id='" + empModel.factory_Id + "'");
                                string isDelete = dsfty.Tables[0].Rows[0]["IsDelete"].ToString();
                                if (int.Parse(isDelete) == 0)
                                {
                                    if (empModel.canlogin.ToString() == "1")
                                    {
                                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                                            1,
                                            username,
                                            DateTime.Now,
                                            DateTime.Now.AddMinutes(20),
                                            true,
                                            empModel.ID.ToString(),
                                            "/"
                                            );
                                        var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                                        cookie.HttpOnly = true;
                                        context.Response.Cookies.Add(cookie);

                                        //FormsAuthentication.SetAuthCookie(userid, true);

                                        //日志
                                        BLL.Sys_log log = new BLL.Sys_log();
                                        Model.Sys_log modellog = new Model.Sys_log();
                                        modellog.EventType = "系统登录";

                                        modellog.EventDate = DateTime.Now;
                                        modellog.UserID = empModel.ID;
                                        modellog.UserName = empModel.name;
                                        modellog.IPStreet = request.UserHostAddress;
                                        modellog.Current_txt = "DAS 用户登录";
                                        modellog.Factory_Id = empModel.factory_Id;

                                        log.Add(modellog);

                                        //online
                                        BLL.Sys_online sol = new BLL.Sys_online();
                                        Model.Sys_online model = new Model.Sys_online();

                                        model.UserName = empModel.name;
                                        model.UserID = empModel.ID;
                                        model.LastLogTime = DateTime.Now;

                                        DataSet ds1 = sol.GetList(" UserID=" + empModel.ID);

                                        //添加当前用户信息
                                        if (ds1.Tables[0].Rows.Count > 0)
                                        {
                                            sol.Update(model, " UserID=" + empModel.ID);
                                        }
                                        else
                                        {
                                            sol.Add(model);
                                        }
                                        //删除超时用户
                                        //2分钟用户失效，删除 --Robert 2015-11-24
                                        sol.Delete(" LastLogTime<date_sub(now(), interval 5 minute)");


                                        //验证完毕，允许登录
                                        context.Response.Write("2");
                                    }
                                    else
                                    {
                                        context.Response.Write("4");//不允许登录
                                    }
                                }
                                else
                                {
                                    context.Response.Write("5");//不允许登录
                                }
                                #endregion
                            }

                            #region 历史2016-04-15前
                            /*
                            string factory_Id = ds.Tables[0].Rows[0]["Factory_Id"].ToString();

                            if (ds.Tables[0].Rows[0]["uid"].ToString() == "admin")
                            {
                                #region
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
                                BLL.Sys_log log = new BLL.Sys_log();
                                Model.Sys_log modellog = new Model.Sys_log();
                                modellog.EventType = "系统登录";

                                modellog.EventDate = DateTime.Now;
                                modellog.UserID = int.Parse(userid);
                                modellog.UserName = ds.Tables[0].Rows[0]["name"].ToString();
                                modellog.IPStreet = request.UserHostAddress;
                                modellog.Factory_Id = factory_Id;

                                log.Add(modellog);

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
                                sol.Delete(" LastLogTime<date_sub(now(), interval 2 minute)");


                                //验证完毕，允许登录
                                context.Response.Write("2");
                                #endregion
                            }
                            else
                            {
                                #region
                                DataSet dsfty = fty.GetList("Factory_Id='" + factory_Id + "'");
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
                                        BLL.Sys_log log = new BLL.Sys_log();
                                        Model.Sys_log modellog = new Model.Sys_log();
                                        modellog.EventType = "系统登录";

                                        modellog.EventDate = DateTime.Now;
                                        modellog.UserID = int.Parse(userid);
                                        modellog.UserName = ds.Tables[0].Rows[0]["name"].ToString();
                                        modellog.IPStreet = request.UserHostAddress;
                                        modellog.Factory_Id = factory_Id;

                                        log.Add(modellog);

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
                                        sol.Delete(" LastLogTime<date_sub(now(), interval 2 minute)");


                                        //验证完毕，允许登录
                                        context.Response.Write("2");
                                    }
                                    else
                                    {
                                        context.Response.Write("4");//不允许登录
                                    }
                                }
                                else
                                {
                                    context.Response.Write("5");//不允许登录
                                }
                                #endregion
                            }
                            */
                            #endregion
                        }
                        else
                        {
                            context.Response.Write("1");//用户名或密码错误
                        }
                    }
                    else
                    {
                        context.Response.Write("0");//验证码错误
                    }
                }
                else
                {
                    context.Response.Write("999");//系统数据错误
                }
            }

            else if (request["Action"] == "logout")
            {
                #region
                var cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];

                if (null != cookie)
                {
                    var ticket = FormsAuthentication.Decrypt(cookie.Value);
                    string CoockiesID = ticket.UserData;

                    FormsAuthentication.SignOut();
                    context.Response.Write("true");

                    //online
                    BLL.Sys_online sol = new BLL.Sys_online();
                    try
                    {
                        if (!string.IsNullOrEmpty(CoockiesID))
                        {
                            sol.Delete(" UserID=" + int.Parse(CoockiesID));
                        }
                    }
                    catch
                    {
                    }
                }
                #endregion
            }
            else if (request["Action"] == "checkpwd")
            {
                #region
                var cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];
                var ticket = FormsAuthentication.Decrypt(cookie.Value);
                string CoockiesID = ticket.UserData;

                BLL.hr_employee emp = new BLL.hr_employee();

                int emp_id = int.Parse(CoockiesID);
                string password = FormsAuthentication.HashPasswordForStoringInConfigFile(request["password"], "MD5");

                DataSet ds = emp.GetList(string.Format("ID={0} and pwd='{1}'", emp_id, password));

                if (ds.Tables[0].Rows.Count > 0)
                {
                    context.Response.Write("{sucess:sucess}");
                }
                else
                {
                    context.Response.Write("{sucess:false}");
                }
                #endregion
            }
        }

        public static string GetClientIPv4Address()
        {
            string ipv4 = String.Empty;

            foreach (IPAddress ip in Dns.GetHostAddresses(GetClientIP()))
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipv4 = ip.ToString();
                    break;
                }
            }

            if (ipv4 != String.Empty)
            {
                return ipv4;
            }
            // 利用 Dns.GetHostEntry 方法，由获取的 IPv6 位址反查 DNS 纪录，
            // 再逐一判断何者为 IPv4 协议，即可转为 IPv4 位址。
            foreach (IPAddress ip in Dns.GetHostEntry(GetClientIP()).AddressList)
            //foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipv4 = ip.ToString();
                    break;
                }
            }

            return ipv4;
        }
        public static string GetClientIP()
        {
            if (null == HttpContext.Current.Request.ServerVariables["HTTP_VIA"])
            {
                return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            else
            {
                return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
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