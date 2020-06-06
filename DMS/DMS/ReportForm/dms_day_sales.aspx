<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>当日业绩实时趋势图</title>
    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../lib/echarts/echarts.min.js" type="text/javascript"></script>
    <script src="../../lib/echarts/theme/macarons.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js"></script>
    <script src="../../JS/dms_day_sales.js"></script>
    <style type="text/css">
        .className {
            line-height: 30px;
            height: 30px;
            width: 80px;
            color: #777777;
            background-color: #ededed;
            font-size: 16px;
            font-weight: normal;
            font-family: Arial;
            filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ededed', endColorstr='#f5f5f5',GradientType=0);
            border: 1px solid #dcdcdc;
            border-top-left-radius: 6px;
            border-top-right-radius: 6px;
            border-bottom-left-radius: 6px;
            border-bottom-right-radius: 6px;
            box-shadow: inset 0px 0px 0px 0px #ffffff;
            text-align: center;
            display: inline-block;
            text-decoration: none;
        }


        .select_style {
            width: 50px;
            height: 30px;
            overflow: hidden;
            border: 1px solid #ccc;
            -moz-border-radius: 5px; /* Gecko browsers */
            -webkit-border-radius: 5px; /* Webkit browsers */
            border-radius: 5px;
        }

            .select_style select {
                padding: 5px;
                background: transparent;
                width: 48px;
                font-size: 16px;
                border: none;
                height: 30px;
                -webkit-appearance: none; /*for Webkit browsers*/
            }
    </style>
    
</head>
<body>
    <div style="position: relative; z-index: 9999">
        <form id="serchform">
            <%--<div id="toolbar" style="width: 1800px"></div>--%>
            <div style="float: left">
                <p style="font-family: 'Microsoft YaHei'; font-size: 16px; font-weight: normal; height: 30px; margin-top: 5px; margin-left: 10px">
                    开始时间：
                </p>

            </div>
            <div style="float: left">
                <select id="hours" runat="server" class="select_style">
                </select>
                <a href='javascript:void(0)' class='className' onclick="setUpHours()">设置</a>
                <%--<input type="button" id="setUp" value="设置" onclick="setUpHours()" style="" />--%>
            </div>
        </form>
    </div>

    <form id="form1" onsubmit="return false">
        <div id="griddiv">
            <div id="graph1" style="height: 280px; margin: 5px;"></div>
        </div>
    </form>
</body>
</html>
