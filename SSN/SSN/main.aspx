<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="SSN.SSN.main" %>

<!DOCTYPE html>

<html>
<head>
    <title>新明辉标准流程咨询</title>
    <meta name="Author" content="PageAdmin CMS" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />

    <link href="/e/templates/default/style.css" type="text/css" rel="stylesheet" />
    <%--<link href="../CSS/lrtk.css" rel="stylesheet" />--%>
    <link href="../CSS/jPages.css" rel="stylesheet" />
    <link href="../e/css/style.css" rel="stylesheet" />
    <link href="../e/css/searchart.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="/e/css/dropmenu.css" />

    <script src="/e/js/jquery.min.js" type="text/javascript"></script>
    <script src="../e/js/function.js"></script>
    <script src="../JS/jPages.js"></script>
    <script src="/e/js/comm.js" type="text/javascript"></script>
    <script src="/e/js/zh-cn/lang.js" type="text/javascript"></script>
    <script type="text/javascript">var submenu_style = 1;</script>
    <script src="/e/js/script.js" type="text/javascript"></script>
    <script src="/e/js/QQ.js" type="text/javascript"></script>
    <script src="../JS/jquery.md5.js"></script>
    <script src="../JS/XHD.js"></script>

    <style type="text/css">
        .topnav {
            float: right;
            margin-top: 40px;
        }

            .topnav div {
                float: left;
            }

                .topnav div a {
                    color: #666;
                    margin-top: 2px;
                    display: inline-block;
                }

                .topnav div.log a {
                    padding: 0 8px;
                    cursor: pointer;
                }

            .topnav .search {
                height: 21px;
                padding-left: 9px;
                position: relative;
            }

                .topnav .search input {
                    vertical-align: top;
                    height: 21px;
                }

                    .topnav .search input.text {
                        float: left;
                        padding: 0px 3px 0px 0px;
                    }

                .topnav .search img {
                    padding-left: 2px;
                    cursor: pointer;
                }

        .title_current {
            font-weight: bold;
            background: #E7E7E7;
            color: white;
        }

        .topdivart {
            width: 100%;
            height: 30px;
            line-height: 30px;
            background: #F1F1F1;
            border-bottom: 1px solid #e5e5e5;
        }

        .liart {
            float: left;
            line-height: 32px;
            color: #999;
            font-family: "Microsoft YaHei",tahoma,arial,'Hiragino Sans GB','\5b8b\4f53',sans-serif;
        }

            .liart a:hover, .liart a:active {
                color: #c40000;
            }

        .liartRights {
            float: right;
            line-height: 32px;
            margin-right: 30px;
            color: #999;
            font-family: "Microsoft YaHei",tahoma,arial,'Hiragino Sans GB','\5b8b\4f53',sans-serif;
        }
    </style>

    <script type="text/javascript">
        var temp = false;
        var memoryMid = 0;
        var memoryName = "";
        var title = "";
        $(function () {
            load();

            $("#searchTxt").keydown(function (event) {
                if (event.keyCode == 13) { //绑定回车
                    searchArt();
                }
            });

        })

        function load() {
            var menu = $("#Menu");
            $.getJSON("../DataSSN/SSN_NewPage.ashx?Action=GetSysMenu1&appid=1&rnd=" + Math.random(), function (menus) {
                if (menus.Total == '0') {
                    $("#gray").show();
                    $("#popup").show();//查找ID为popup的DIV show()显示#gray
                    tc_center();
                    //$(".tc").show();
                    //$("#out").hide();
                } else {
                    $(".tc").hide();
                    $("#ulart").append('<li class="liart">' + getCookie("xhdcrm_uid") + '</li>');
                    $("#ulart").append('<li class="liart">&nbsp;&nbsp;&nbsp;</li>');
                    $("#ulart").append('<li class="liart"><a href="javascript:void(0)" id="out" style="display: none" onclick="loginOut()">退出</a></li>');
                    $("#ulart").append('<li class="liartRights"><a href="javascript:void(0)" onclick="toMyQA()">我的问答</a></li>');
                    $("#out").show();
                    temp = true;
                    menu.html('');
                    var html = " <ul>";
                    html += "<li class='menu_style_homepage' id='m-1' name='m-1'><a href='javascript:void(0)'  onclick=viewArt('-1','首页') class='menu'>首页</a></li>";
                    $(menus.Rows).each(function (i, item) {
                        html += "<li class='menu_style_homepage' id='m" + item.Menu_id + "' name='m" + item.Menu_id + "'><a href='javascript:void(0)'  onclick=viewMenu(" + item.Menu_id + ") class='menu'>" + item.Menu_name + "</a></li>";
                    });
                    html += " </ul>";
                    menu.html(html);
                    $("#m-1").addClass("menu_current");
                }

                $("li.menu_style_homepage").click(function () {
                    $("li.menu_style_homepage").removeClass("menu_current");
                    var jitem = $(this);
                    jitem.addClass("menu_current");
                    var nav_menu = $("#nav_menu");
                    nav_menu.html('');

                })

                if (temp)
                    viewArt('-1', "首页");

            });
        }

        function viewMenu(mid) {
            var firstid = 0;
            var firstname = "";
            $.getJSON("../DataSSN/SSN_NewPage.ashx?Action=GetSysMenu2&appid=1&pid=" + mid + "&rnd=" + Math.random(), function (menus) {
                var nav_menu = $("#nav_menu");
                nav_menu.html('');
                var html = "<ul class='navContent' style='display: block'>";
                $(menus.Rows).each(function (i, item) {
                    firstid = menus.Rows[0].Menu_id;
                    firstname = menus.Rows[0].Menu_name;
                    html += "<li class='' id='m" + item.Menu_id + "' name='m" + item.Menu_id + "'><a href='javascript:void(0)'  onclick=viewArt(" + item.Menu_id + ",'" + item.Menu_name + "',this) class='menu'>" + item.Menu_name + "</a></li>";
                });
                html += " </ul>";
                nav_menu.html(html);

                if (firstid != 0) {
                    viewArt(firstid, firstname);
                    $('.nav_menu a.menu').eq(0).addClass('action');
                }
            });
        }

        function viewArt(mid, mname, e) {
            $('.nav_menu a.menu.action').removeClass('action');

            $(e).addClass('action');
            memoryMid = mid;
            memoryName = mname;

            $("#menuTitle").html('');
            $("#menuTitle").html(mname);

            $.ajax({
                type: "GET",
                url: "../DataSSN/SSN_NewPage.ashx", /* 注意后面的名字对应CS的方法名称 */
                data: { Action: 'grid', menuid: mid, title: title, rnd: Math.random() }, /* 注意参数的格式和名称 */
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    var itemContainer = $("#centreview");
                    itemContainer.html('');

                    var html = "<div class='holder sublanmu_content sublanmu_content_article'></div>";
                    html += "<ul id='itemContainer' class='article'>";
                    var obj = eval(result);
                    $(obj.Rows).each(function (i, item) {
                        html += " <li class='titleList'><span class='title'>"
                                //+ "<a href='javascript:void(0)' target='_blank' title='" + item.Art_title + "' style='' onclick='showArt(" + item.Id + ",'" + item.Art_title + "')'>" + item.Art_title + "</a></span>"
                                + "<a href='art_view.aspx?flag=" + item.Id + "' target='_blank' >" + item.Art_title + "</a></span>"
                                + "<span class='date'>" + formatTimebytype(item.Create_Date, 'yyyy-MM-dd') + "</span>"
                           + " </li>";
                    })
                    html += "</ul>";

                    itemContainer.html(html);
                    $("div.holder").jPages({
                        containerID: "itemContainer"
                    });

                    //给文章设置选中时给当前行加样式
                    $("li.titleList").mouseover(function () {
                        var jitem = $(this);
                        jitem.addClass("title_current");

                    });
                    $("li.titleList").mouseout(function () {
                        var jitem = $(this);
                        jitem.removeClass("title_current");

                    });
                }
            });
        }

        function searchArt() {
            $("#m-1").click();
            //if (memoryMid) {
            title = $("#searchTxt").val();
            viewArt("-1", "首页")
            title = "";
            //}
        }

        function loginSSN() {
            var uid = $("#name").val();
            var pwd = $("#pass").val();
            var validate = $("#T_validate").val();

            $.ajax({
                type: 'post', dataType: 'json',
                url: '../DataSSN/SSN_Login.ashx',
                async: true,
                data: [
                { name: 'Action', value: 'login' },
                { name: 'username', value: uid },
                { name: 'password', value: $.md5(pwd) },
                { name: 'validate', value: validate },
                { name: 'rnd', value: Math.random() }
                ],
                success: function (result) {
                    if (typeof (result) == "number") {
                        switch (result) {
                            case 0:
                                alert("验证码错误！");
                                $("#validate").click();
                                $("#T_validate").val("");
                                $("#T_validate").focus();
                                break;
                            case 1:
                                alert("用户名或密码错误！");
                                $("#T_pwd").focus();
                                break;
                            case 2:
                                SetCookie("xhdcrm_uid", uid, 30);
                                $("#gray").hide();
                                $("#popup").hide();//查找ID为popup的DIV hide()隐藏
                                load();
                                $(".tc").hide();
                                $("#out").show();
                                break;
                            case 3:
                                alert("账户异常，请联系管理员！");
                                break;
                            case 4:
                                alert("账户已限制登录！");
                                break;
                            case 5:
                                alert("此帐号所在单位已被停用！");
                                break;
                            case 6:
                                alert("IP受限！");
                                break;
                        }
                    }
                    else {
                        alert('登陆失败,账号或密码有误!');
                        $("#password").focus();
                        return;
                    }
                },
                error: function () {
                    $("#validate").click();
                    alert('发生系统错误,请与系统管理员联系!');
                },
                //beforeSend: function () {
                //    $.ligerDialog.waitting("正在登陆中,请稍后...");
                //    $("#lgoin").attr("disabled", true);
                //},
                //complete: function () {
                //    $.ligerDialog.closeWaitting();
                //    $("#login").attr("disabled", false);
                //}
            });
        }

        function loginOut() {
            //$.ligerDialog.confirm('您确认要退出系统？', function (yes) {
            //    if (yes) {
            $.ajax({
                type: 'post', dataType: 'json',
                url: '../DataSSN/SSN_Login.ashx',
                data: [{ name: 'Action', value: 'logout' }],
                success: function (result) {
                    javascript: location.replace("login.aspx");
                    location.reload([false]);
                }
            });
            //}
            //});
        }

        function toMyQA() {

            window.open("../ssn/Question.aspx");
        }

        function showArt(id, title) {

        }

    </script>
</head>
<body>
    <div id="gray"></div>

    <div class="popup" id="popup">

        <div class="top_nav" id='top_nav'>
            <div align="center">
                <i></i>
                <span>登录账号</span>
                <a class="guanbi"></a>
            </div>
        </div>

        <div class="min">

            <div class="tc_login">
                <div class="right">
                    <form method="POST" name="form_login" target="_top" onsubmit="return false">
                        <div align="center">
                            <%--<a href="">短信快捷登录</a>--%>
                            <br />
                            <i class="icon-mobile-phone"></i>
                            <input type="text" name="name" id="name" required="required" placeholder="用户名" autocomplete="off" class="input_yh">
                            <input type="password" name="pass" id="pass" required="required" placeholder="密码" autocomplete="off" class="input_mm">
                        </div>
                        <dd>
                            <%--<div align="center"><a href="">遇到登录问题</a></div>--%>
                        </dd>
                        <div align="center">
                            <input type="submit" class="button" title="Sign In" value="登录" onclick="loginSSN()">
                        </div>
                    </form>
                    <hr align="center" />
                </div>

            </div>

        </div>
    </div>

    <form onsubmit="return false">
        <div class="topdivart">
            <ul id="ulart" style="margin-left: 50px;">
                <li class="liart">您好,<a class="tc" href="javascript:void(0)" onclick="">请登录</a></li>
            </ul>
        </div>
        <div class="page_style sublanmupage page_l63_sl654">
            <div class="top_box">
                <div class="top_box_inner">
                    <div class="topcontent"></div>
                    <div class="clear"></div>
                    <div class="logo">
                        <a href="main.aspx">
                            <img width="397" height="80" src="/e/images/website_logo.jpg" border="0"></a>
                        <div class="form-wrapper cf">
                            <input type="text" id="searchTxt" placeholder="Search here...">
                            <button type="submit" onclick="searchArt()">搜索</button>

                        </div>
                        <div class="topnav">
                        </div>
                    </div>

                    <div class="menu_box" id="Menu">
                        <ul>
                        </ul>
                    </div>
                </div>
            </div>
            <script type="text/javascript">var IsPageHome = ""; var Lanmu_Id = "63"; var Sublanmu_Id = "654"; ShowSubMenu(Lanmu_Id);</script>
            <div class="banner">
                <script src="/e/d/slide_16.js" type="text/javascript"></script>
                <div class="fdwz-box">
                    <span class="xszw-ys">你所做的事情，也许暂时看不到成功</span> <span class="xszw-ys" style="line-height: 40px;">但是不要灰心</span> <span class="dszw-ys">你不是没有成长，而是在扎根</span> <span class="xsyw-ys" style="line-height: 20px;">WHAT YOU DO MAY TEMPORARILY CAN’T SEE THE SUCCESS,BUT DON’T LOSE HEART&nbsp;</span> <span class="xsyw-ys">YOU NOT NO GROWTH, BUT THE ROOT!</span>
                </div>
            </div>

            <div class="main_box main_box_style2">
                <div class="main_box_inner" style="margin-top: 10px;">

                    <div class="main_box_inner_right">

                        <div class="nav_menu" id="nav_menu">
                        </div>
                    </div>
                    <div class="main_box_inner_left">
                        <div class="current_location current_location_654">
                            <ul>
                                <li class="current_location_2" id="menuTitle"></li>
                            </ul>
                        </div>
                        <div class="sublanmu_box sublanmu_box_654" id="centreview">
                        </div>
                    </div>
                </div>
                <div class="clear main_box_inner_bottom"></div>
            </div>
            <br />
            <br />
            <br />
            <div class="bottom_box">
                <div class="bottom_info">
                    Copyright&nbsp; @&nbsp;  2013-2020&nbsp;  All&nbsp;  Rights&nbsp;  Reserved&nbsp; &nbsp;    版权所有:临沂新明辉安全科技有限公司&nbsp; &nbsp;    技术支持:山东易安捷科技股份有限公司
                </div>
                <script type="text/javascript">
                    var pc_siteurl = "http://demo.pageadmin.net/";//改为你pc网站首页地址
                    var wap_siteurl = "http://demo.pageadmin.net/wap"; //改为你手机网站首页地址
                    if (location.href.indexOf("fromwap") > 0) {
                        SetCookie("viewpc", "1");
                    }
                    if (!IsPC() && GetCookie("viewpc") != "1" && location.href == pc_siteurl) {
                        location.href = wap_siteurl;
                    }
                </script>
            </div>
            <%--<div align="center" style='padding: 5px'>Powered by <a href='http://www.xinminghui.com'><b>PageAdmin XMH</b></a></div>--%>
        </div>
    </form>
</body>
<script type="text/javascript">    TongJi(1)</script>
<script type="text/javascript">
    //窗口效果
    //点击登录class为tc 显示
    $(".tc").click(function () {
        $("#gray").show();
        $("#popup").show();//查找ID为popup的DIV show()显示#gray
        tc_center();
    });
    //点击关闭按钮
    $("a.guanbi").click(function () {
        $("#gray").hide();
        $("#popup").hide();//查找ID为popup的DIV hide()隐藏
    })

    //窗口水平居中
    $(window).resize(function () {
        tc_center();
    });

    function tc_center() {
        var _top = ($(window).height() - $(".popup").height()) / 2;
        var _left = ($(window).width() - $(".popup").width()) / 2;

        $(".popup").css({ top: _top, left: _left });
    }
</script>

<script type="text/javascript">
    $(document).ready(function () {

        $(".top_nav").mousedown(function (e) {
            $(this).css("cursor", "move");//改变鼠标指针的形状 
            var offset = $(this).offset();//DIV在页面的位置 
            var x = e.pageX - offset.left;//获得鼠标指针离DIV元素左边界的距离 
            var y = e.pageY - offset.top;//获得鼠标指针离DIV元素上边界的距离 
            $(document).bind("mousemove", function (ev) { //绑定鼠标的移动事件，因为光标在DIV元素外面也要有效果，所以要用doucment的事件，而不用DIV元素的事件 

                $(".popup").stop();//加上这个之后 

                var _x = ev.pageX - x;//获得X轴方向移动的值 
                var _y = ev.pageY - y;//获得Y轴方向移动的值 

                $(".popup").animate({ left: _x + "px", top: _y + "px" }, 10);
            });

        });

        $(document).mouseup(function () {
            $(".popup").css("cursor", "default");
            $(this).unbind("mousemove");
        });
    })
</script>
</html>
