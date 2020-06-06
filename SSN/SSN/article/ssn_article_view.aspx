<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssn_article_view.aspx.cs" Inherits="SSN.SSN.article.ssn_article_view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="../../JS/jquery-1.12.1.js"></script>
    <style type="text/css">
        .title { margin: 10px;text-align: center;font-size: 28px;font-weight: bold;border-bottom: #ddd 1px solid;padding: 20px;font-family: 'Microsoft YaHei';}
        .content {text-align: left;font-size: 12px;padding-top: 20px;padding-bottom: 20px;padding-left: 10px;letter-spacing: 1px;text-indent: 25px;line-height: 26px; font-family: 'Microsoft YaHei';}
        #testDiv img {border: none; width: 110px; height: 110px;border: 3px solid #f4f4f4;}
        #enlarge_images {position: absolute;display: none; z-index: 2;border: 5px solid #f4f4f4;}
    </style>

    <script type="text/javascript">
        //var xx = 0;
        //var yy = 0;
        //$(function () {
        //    $('#testDiv').mousemove(function (e) {
        //        xx = e.originalEvent.x || e.originalEvent.layerX || 0;
        //        yy = e.originalEvent.y || e.originalEvent.layerY || 0;
        //    });
        //})

        //显示图片
        function over(imgid) {
            //显示
            $("#divImage").show();
            //$("#divImage").attr("style", "left: " + (xx-50) + "px; top: " + (yy-50) + "px; position: absolute")
            $("#imgbig").attr("src", '../../' + imgid);
        }

        //隐藏图片
        function out() {
            $("#divImage").hide();
        }

    </script>
</head>
<body style="margin: auto; width: 1100px;">
    <form id="form1">
        <div style="width: 1100px;">
            <div class="title"><asp:Literal ID="ltrTitle" runat="server"></asp:Literal></div>
            <div class="content"><asp:Literal ID="ltrContent" runat="server"></asp:Literal></div>
            <div  id="testDiv" style="overflow: hidden; padding: 10px;">
                <asp:Repeater ID="repImage" runat="server">
                    <ItemTemplate>
                       <%--<img onmouseover="over('<%#Eval("ImgUrl") %>')" onmouseout="out()" style="width: 200px;" alt="" src="../../<%#Eval("ImgUrl") %>" />--%>
                       <img style="width: 200px;" alt="" src="../../<%#Eval("ImgUrl") %>" />
                    </ItemTemplate>
                </asp:Repeater>
            </div>

            <%--显示大图标的区域--%>
            <%--<div id="divImage" style="display: none; right: 120px; top: 50px; position: absolute">
                <img id="imgbig" src="http://www.jb51.net/images/logo.gif" alt="预览" />
            </div>--%>

            <div id="enlarge_images"></div>
        </div>
    </form>
</body>
</html>

<script>
    var demo = document.getElementById("testDiv");
    var gg = demo.getElementsByTagName("img");
    var ei = document.getElementById("enlarge_images");
    for (i = 0; i < gg.length; i++) {
        var ts = gg[i];
        ts.onmousemove = function (event) {
            event = event || window.event;
            ei.style.display = "block";
            ei.innerHTML = '<img src="' + this.src + '" />';
            ei.style.top = document.body.scrollTop + event.clientY + 10 + "px";
            ei.style.left = document.body.scrollLeft + event.clientX + 10 + "px";
        }
        ts.onmouseout = function () {
            ei.innerHTML = "";
            ei.style.display = "none";
        }
        ts.onclick = function () {
            window.open(this.src);
        }
    }
</script>
