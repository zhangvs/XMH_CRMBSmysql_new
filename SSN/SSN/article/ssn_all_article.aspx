<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssn_all_article.aspx.cs" Inherits="SSN.SSN.article.ssn_all_article" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>查看</title>
    <link href="../../CSS/core.css" rel="stylesheet" type="text/css" />
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />

    <link href="../../CSS/input.css" rel="stylesheet" />
    <link href="../../CSS/style.css" rel="stylesheet" />
    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="../../JS/XHD.js" type="text/javascript"></script>
    <script type="text/javascript">
        function set_null() {
            $("#title").val("");
        }
    </script>
    <style type="text/css">
        .l-toolbar {
            width: 1800px;
            height: 32px;
        }

        .l-toolbar-item {
            margin-top: 4px;
        }

        .l-panel-label {
            margin-left: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
            <ContentTemplate>
                <div id="toolbar" class="l-toolbar">
                    <div class="l-toolbar-item  l-panel-label">标题：</div>
                    <div class="l-toolbar-item">
                        <div class="l-text" style="width: 200px;">
                            <input type="text" id="title" name="stext" runat="server" onfocus="set_null()" style="width: 196px;" class="l-text-field-null l-text-field" />
                            <div class="l-text-l"></div>
                            <div class="l-text-r"></div>
                        </div>
                    </div>
                    <div class="l-toolbar-item l-panel-btn l-toolbar-item-hasicon">
                        <span>
                            <asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" /></span>
                        <div class="l-panel-btn-l"></div>
                        <div class="l-panel-btn-r"></div>
                        <div class="l-icon" style="width: 18px; height: 18px; background: url(../../images/search.gif) 1px 1px no-repeat;"></div>
                    </div>
                </div>

                <div id="grid" style="margin-top: 30px;">
                    <ul class="tags">
                        <asp:Repeater ID="repArticle" runat="server">
                            <ItemTemplate>
                                <li><a href='ssn_article_view.aspx?flag=<%#Eval("Id") %>' target="_blank"><%# Eval("Art_title")%></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>

