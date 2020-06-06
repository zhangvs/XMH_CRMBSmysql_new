﻿<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="JS/jquery.min.js"></script>
    <title>新明辉DMS系统</title>
    <style type="text/css">
        .menu_head {
            width: 212px;
            height: 47px;
            line-height: 47px;
            padding-left: 38px;
            font-size: 14px;
            color: #525252;
            cursor: pointer;
            border: 1px solid #e1e1e1;
            position: relative;
            margin: 0px;
            font-weight: bold;
            background: #f1f1f1 url(../images/pro_left.png) center right no-repeat;
        }

        .menu_list .current {
            background: #f1f1f1 url(../images/pro_down.png) center right no-repeat;
        }

        .menu_body {
            width: 250px;
            height: auto;
            overflow: hidden;
            line-height: 38px;
            border-left: 1px solid #e1e1e1;
            backguound: #fff;
            border-right: 1px solid #e1e1e1;
        }

            .menu_body a {
                display: block;
                width: 250px;
                height: 38px;
                font-family: 'Microsoft YaHei';
                font-size: 20px;
                line-height: 38px;
                padding-left: 38px;
                color: #777777;
                background: #fff;
                text-decoration: none;
                border-bottom: 1px solid #e1e1e1;
            }

                .menu_body a:hover {
                    text-decoration: none;
                }
    </style>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#firstpane .menu_body:eq(0)").show();
            $("#firstpane p.menu_head").click(function () {
                $(this).addClass("current").next("div.menu_body").slideToggle(300).siblings("div.menu_body").slideUp("slow");
                $(this).siblings().removeClass("current");
            });
            $("#secondpane .menu_body:eq(0)").show();
            $("#secondpane p.menu_head").mouseover(function () {
                $(this).addClass("current").next("div.menu_body").slideDown(500).siblings("div.menu_body").slideUp("slow");
                $(this).siblings().removeClass("current");
            });

        });

        function showView(value) {
            window.open("/DMS/ReportForm/" + value);
        }
        function showSet(value) {
            window.open("/DMS/set/" + value);
        }
        function logout() {
            if (confirm('您确认要退出系统？')) {
                $.ajax({
                    type: 'post', dataType: 'json',
                    url: 'Data/login.ashx',
                    data: [{ name: 'Action', value: 'logout' }],
                    success: function (result) {
                        javascript: location.replace("login.aspx");
                    }
                });
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="firstpane" class="menu_list">
            <div style="margin-top: 10px;"><a href="javascript:void(0)" style="padding-left: 40px; font-family: 'Microsoft YaHei'; font-size: 20px;" onclick="logout()">退出系统</a></div>
            <p class="menu_head current">数据分析</p>
            <div style="display: block" class="menu_body">
                <a href="javascript:void(0)" onclick="showView('provinceMap_sales.aspx')">订单省份分布</a>
<%--                <a href="javascript:void(0)" onclick="showView('ajaxMap.aspx')">实时订单跟踪</a>--%>
                <a href="javascript:void(0)" onclick="showView('mapLines.aspx')">客户订单分布</a>
                <%--<a href="javascript:void(0)" onclick="showView('dms_day_sales.aspx')">业绩实时趋势</a>--%>
                <a href="javascript:void(0)" onclick="showView('month_sales.aspx')">月销售数据</a>
            </div>
            <p class="menu_head current">日报</p>
            <div style="display: block" class="menu_body">
                <a href="javascript:void(0)" onclick="showView('dms_date.aspx')">今日订单</a>
            </div>
            <p class="menu_head current">统计</p>
            <div style="display: block" class="menu_body">
                <a href="javascript:void(0)" onclick="showView('dms_personal_year.aspx')">【员工】统计年报</a>
                <a href="javascript:void(0)" onclick="showView('dms_personal_month.aspx')">【员工】统计月报</a>
                <a href="javascript:void(0)" onclick="showView('dms_manager_year.aspx')">【部门】统计年报</a>
                <a href="javascript:void(0)" onclick="showView('dms_manager_month.aspx')">【部门】统计月报</a>
            </div>
<%--            <p class="menu_head current">品牌</p>
            <div style="display: block" class="menu_body">
                <a href="javascript:void(0)" onclick="showView('dms_personal_brand_year.aspx')">【员工】品牌年报</a>
                <a href="javascript:void(0)" onclick="showView('dms_personal_brand_quarter.aspx')">【员工】品牌季报</a>
                <a href="javascript:void(0)" onclick="showView('dms_personal_brand.aspx')">【员工】品牌月报</a>
                <a href="javascript:void(0)" onclick="showView('dms_manager_brand_year.aspx')">【部门】品牌年报</a>
                <a href="javascript:void(0)" onclick="showView('dms_manager_brand_quarter.aspx')">【部门】品牌季报</a>
                <a href="javascript:void(0)" onclick="showView('dms_manager_brand.aspx')">【部门】品牌月报</a>
            </div>--%>
            <p class="menu_head current">品牌</p>
            <div style="display: block" class="menu_body">
                <a href="javascript:void(0)" onclick="showView('dms_brand_manager_year.aspx')">【品牌】统计年报</a>
                <a href="javascript:void(0)" onclick="showView('dms_brand_manager.aspx')">【品牌】统计月报</a>
            </div>
            <p class="menu_head current">客户</p>
            <div style="display: block" class="menu_body">
                <a href="javascript:void(0)" onclick="showView('dms_personal_customer_year.aspx')">【员工】客户年报</a>
                <a href="javascript:void(0)" onclick="showView('dms_manager_customer_year.aspx')">【部门】客户年报</a>
                <a href="javascript:void(0)" onclick="showView('dms_personal_customer.aspx')">【员工】客户月报</a>
                <a href="javascript:void(0)" onclick="showView('dms_manager_customer.aspx')">【部门】客户月报</a>
            </div>
            <p class="menu_head current">区域</p>
            <div style="display: block" class="menu_body">
                <a href="javascript:void(0)" onclick="showView('dms_map_city_month.aspx')">【城市】月报</a>
                <a href="javascript:void(0)" onclick="showView('dms_map_province_month.aspx')">【省份】月报</a>
                <a href="javascript:void(0)" onclick="showView('dms_map_city_year.aspx')">【城市】年报</a>
                <a href="javascript:void(0)" onclick="showView('dms_map_province_year.aspx')">【省份】年报</a>
            </div>
            <p class="menu_head current">薪资</p>
            <div style="display: block" class="menu_body">
                <a href="javascript:void(0)" onclick="showView('dms_personal_salary.aspx')">【员工】个人薪资</a>
                <a href="javascript:void(0)" onclick="showView('dms_manager_salary.aspx')">【部门】团队薪资</a>
            </div> 
            <p class="menu_head current">参数设置</p>
            <div style="display: block" class="menu_body">
                <a href="javascript:void(0)" onclick="showSet('set_exclude.aspx')">排除评比设置 </a>
                <a href="javascript:void(0)" onclick="showSet('set_rating.aspx')">评比资格设置 </a>
                <a href="javascript:void(0)" onclick="showSet('brand_manager.aspx')">品牌经理设置</a>
                <a href="javascript:void(0)" onclick="showSet('brand_check.aspx')">考核品牌基数计划</a>
                <a href="javascript:void(0)" onclick="showSet('brand_percentage.aspx')">品牌提成设置</a>
                <a href="javascript:void(0)" onclick="showSet('set_node.aspx')">节点设置</a>
                <a href="javascript:void(0)" onclick="showSet('set_bonus.aspx')">奖金设置</a>
                <a href="javascript:void(0)" onclick="showSet('set_bonus_team.aspx')">团队达标奖金设置</a>
                <a href="javascript:void(0)" onclick="showSet('sale_parameters.aspx')">薪资级别设置</a>
                <a href="javascript:void(0)" onclick="showSet('total_plan.aspx')">总任务计划设置</a>
                <a href="javascript:void(0)" onclick="showSet('month_base.aspx')">年基数设置</a>
                <a href="javascript:void(0)" onclick="showSet('per_plan.aspx')">年计划设置 </a>
            </div>
        </div>

    </form>
</body>
</html>
