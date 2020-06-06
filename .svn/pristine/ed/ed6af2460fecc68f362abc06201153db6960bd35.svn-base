<%@ Page Language="C#" AutoEventWireup="true" %>

<!--Èë¿ÚÒ³Ãæ->
<%
    //Ë¢ÐÂ¾²Ì¬·½·¨»º´æ
    XHD.DMS.Data.install inss = new XHD.DMS.Data.install();
    string filename = Server.MapPath("/conn.config");
    inss.CheckConfig(filename);
    string filename1 = Server.MapPath("/Web.config");
    inss.CheckConfig(filename1);

    //ÅÐ¶ÏÊÇ·ñÒÑÅäÖÃ
    XHD.DMS.Data.install ins = new XHD.DMS.Data.install();
    int configed = ins.configed();

    //ÅÐ¶ÏÊÇ·ñµÇÂ½
    HttpCookie cookie = Request.Cookies[FormsAuthentication.FormsCookieName];
    if (Request.IsAuthenticated && null != cookie)
        Response.Redirect("main.aspx");
    else
        Response.Redirect("login.aspx"); 
 %>