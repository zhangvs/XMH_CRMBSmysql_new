<%@ Page Language="C#" AutoEventWireup="true" %>

<!--���ҳ��->
<%
    //ˢ�¾�̬��������
    XHD.DMS.Data.install inss = new XHD.DMS.Data.install();
    string filename = Server.MapPath("/conn.config");
    inss.CheckConfig(filename);
    string filename1 = Server.MapPath("/Web.config");
    inss.CheckConfig(filename1);

    //�ж��Ƿ�������
    XHD.DMS.Data.install ins = new XHD.DMS.Data.install();
    int configed = ins.configed();

    //�ж��Ƿ��½
    HttpCookie cookie = Request.Cookies[FormsAuthentication.FormsCookieName];
    if (Request.IsAuthenticated && null != cookie)
        Response.Redirect("main.aspx");
    else
        Response.Redirect("login.aspx"); 
 %>