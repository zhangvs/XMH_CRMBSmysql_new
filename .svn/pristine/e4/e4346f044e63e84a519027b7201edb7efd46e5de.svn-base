<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuickQuestion.aspx.cs" Inherits="SSN.SSN.QuickQuestion" %>

<!DOCTYPE html>

<html lang="zh-cn">

<head>
    <title>SSN</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <meta name="renderer" content="webkit">
    <script src="../pintuer/jquery.js"></script>
    <script src="../pintuer/pintuer.js"></script>
    <link href="../pintuer/pintuer.css" rel="stylesheet" />
    <link href="../pintuer/admin.css" rel="stylesheet" />
    <link href="../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/Toolbar.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/core.css" rel="stylesheet" type="text/css" />
    <script src="../e/js/jquery.min.js"></script>
    <script src="../JS/jquery.min.js"></script>
    <script src="../Scripts/jquery.validate.min.js"></script>
    <script src="../JS/upload.js"></script>
    <script src="../JS/jquery.form.js"></script>
    <script src="../JS/XHD.js"></script>
    <script src="../lib/ligerUI/js/plugins/ligerDialog.js"></script>

    <style type="text/css">
        .tab .tab-body {
            border-top: solid 1px #ddd;
            margin-top: -1px;
            padding-top: 0px;
        }

        .button {
            padding: 4px 15px;
        }

        .input {
            height: 30px;
            border: solid 1px #989393;
        }

        .active {
            background-color: #DAD7D7;
        }

        .linkButton li {
            list-style-type: none;
        }

            .linkButton li a {
                padding: 8px 20px 12px;
                border: solid 1px #ddd;
                float: left;
            }

        .input-help {
            color: red;
        }

        .label {
            font-weight: bold;
        }

        .titleList {
            margin:3px 3px 3px 3px;
             }
    </style>
    <script type="text/javascript">
    </script>
</head>

<body>
    <!--顶部-->
    <div class="layout bg-main bg-inverse fixed" style="z-index: 9;">
        <div class="container-layout">
            <div class="navbar">
                <form method="post" id="form1">
                    <div class="navbar-head">
                        <button class="button icon-navicon" data-target="#navbar1">
                        </button>
                        <a href="javascript:void(0)">
                            <strong class="text-big">SSN问答中心</strong></a>
                    </div>

                    <div class="navbar-body nav-navicon" id="navbar1">
                        <ul class="nav nav-inline nav-menu">
                            <%--    <li><a class="icon-cog" href="javascript:void(0)">设置<span class="arrow"></span></a>
                                <ul class="drop-menu">
                                    <li><a href="javascript:void(0)">皮肤设置<span class="arrow"></span></a>
                                        <ul>
                                            <li><a href="javascript:void(0)" onclick="changeColor('#525655')">墨绿</a></li>
                                            <li><a href="javascript:void(0)" onclick="changeColor('#46C1DC')">天蓝</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>--%>
                            <li><a class="icon-home" href="javascript:void(0)">导航<span class="arrow"></span></a>
                                <ul class="drop-menu">
                                    <li><a class="icon-question-circle" href="Question.aspx">我的提问</a></li>
                                    <li><a class="icon-key" href="Answer.aspx">我的回答</a></li>
                                    <%--<li><a class="icon-file-text" href="content.html">我的回答<span class="arrow"></span></a>
                                   <ul>
                                        <li><a href="content.html">新闻</a></li>
                                        <li><a href="javascript:void(0)">留言</a></li>
                                        <li><a href="javascript:void(0)">反馈</a></li>
                                    </ul>
                                </li>--%>
                                    <li><a class="icon-flash (alias)" href="QuickQuestion.aspx">快速提问</a></li>
                                </ul>
                            </li>
                        </ul>
                        <!--
                        	描述：右侧用户资料
                        -->
                        <ul class="nav nav-inline nav-menu navbar-right">
                            <li>
                                <a class="bg-main" href="javascript:;">
                                    <%--<span><img src="http://www.pintuer.com/demo/pintuer2/images/face.jpg" width="28" class="radius-circle"></span>
                                    管理员--%>
                                    <span>
                                        <asp:Image ID="Image1" runat="server" Width="28" class="radius-circle" /></span>
                                    <asp:Label ID="lblNmae" runat="server" Text="Label"></asp:Label>
                                    <%--<span class="downward"></span>--%>
                                </a>
                                <%--   <ul class="drop-menu">
                                    <li><a class="icon-user" target="_blank" href="javascript:;">修改资料</a></li>
                                    <li><a class="icon-key" target="_blank" href="javascript:;">修改密码</a></li>
                                </ul>--%>
                            </li>
                            <!--<li><a class="bg-green" href="javascript:;"><span class="icon-envelope"></span>&nbsp;<span class="badge bg-blue">5+</span><span class="downward"></span></a>
								<ul class="drop-menu">
									<li><a class="text-yellow-light" target="_blank" href="javascript:;"><span class="icon-envelope"></span>您有16封邮件</a></li>
									<li><a class="bg-gray" target="_blank" href="javascript:;"><span class="icon-envelope"></span>查阅更多...</a></li>
								</ul>
							</li>-->
                            <%--        <li><a class="bg-blue" href="javascript:;"><span class="icon-bell-o"></span>&nbsp;<span class="badge bg-green"><asp:Label ID="lblSum" runat="server" Text="Label"></asp:Label></span><span class="downward"></span></a>
                                <ul class="drop-menu">
                                    <li><a class="text-yellow-light active" target="_blank" href="javascript:;"><span class="icon-comment"></span>
                                        <asp:Label ID="lblUnread" runat="server" Text="Label"></asp:Label></a></li>
                                    <li><a class="text-yellow-light active" target="_blank" href="javascript:;"><span class="icon-comments"></span>
                                        <asp:Label ID="lblReply" runat="server" Text="Label"></asp:Label></a></li>
                                </ul>
                            </li>--%>
                            <li><a class="bg-yellow" target="_blank" href="javascript:void(0)" onclick="loginOut()"><span class="icon-sign-out"></span>注销</a></li>
                        </ul>
                        <!--
                        	描述：左侧搜索
                        -->
                        <%-- <div class="navbar-form navbar-left">
                            <input type="text" class="input input-auto" name="keywords" size="15" placeholder="功能名称">
                            <input type="submit" name="search" value="搜索" class="button bg">
                        </div>--%>
                    </div>
                </form>
            </div>
        </div>
    </div>
    <!--内容-->
    <div class="layout" style="overflow: auto" id="divBody">
        <ul class="bread bg">
            <li><a href="Question.aspx" class="icon-home">首页</a> </li>
            <li><a href="javascript:void(0)">快速提问</a></li>
        </ul>
        <div class="admin">
            <div class="xm3">
                <div class="panel border-back">
                    <div class="panel-body text-center">
                        <%-- <img src="../images/face.jpg" width="120" class="radius-circle" />
                        <br>
                        admin--%>
                        <span>
                            <asp:Image ID="Image2" runat="server" Width="120" class="radius-circle" /></span>
                        <asp:Label ID="lblName1" runat="server" Text="Label"></asp:Label>

                    </div>
                    <div class="panel-foot bg-back border-back">
                        <asp:Label ID="lblWelcome" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
                <br>
                <div class="panel">
                    <div class="panel-head"><strong>站点统计</strong></div>
                    <ul class="list-group">
                        <li><span class="float-right badge bg-red">
                            <asp:Label ID="lblScore" runat="server" Text="Label"></asp:Label></span><span class="icon-user"></span> 积分</li>
                        <li><span class="float-right badge bg-red">
                            <asp:Label ID="lblQuestion" runat="server" Text="Label"></asp:Label></span><span class="icon-question"></span> 提问数</li>
                        <li><span class="float-right badge bg-main">
                            <asp:Label ID="lblAnswer" runat="server" Text="Label"></asp:Label></span><span class="icon-file"></span> 回答数</li>
                        <li><span class="float-right badge bg-main">
                            <asp:Label ID="lblRate" runat="server" Text="Label"></asp:Label></span><span class="icon-thumbs-o-up"></span> 回答采纳率</li>
                        <li><span class="float-right badge bg-main">
                            <asp:Label ID="lblGood" runat="server" Text="Label"></asp:Label></span><span class="icon-thumbs-up"></span> 回答评优数</li>
                    </ul>
                </div>
                <br>
            </div>
            <div class="xm9">
                <div style="float: left; margin-left: 80px;">
                    <div class="label">问题标题:</div>
                    <div class="field">
                        <input type="text" class="input" id="txtQuestionTitle" name="txtQuestionTitle" style="width: 400px" onblur="txtQuestionTitle_onblur()" /><label id="txtQuestionTitleError" style="color: red"></label>
                    </div>
                    <div class="label">问题类型:</div>
                    <div class="field">
                        <select id="selQestionType" name="selQestionType" style="width: 400px; height: 30px; border-radius: 4px;" onchange="selQestionType_onselect()">
                            <option value="-1">--请选择--</option>
                        </select><label id="selQestionTypeError" style="color: red"></label>
                    </div>
                    <div class="label">问题描述:</div>
                    <div class="field">
                        <textarea id="txtQestionContent" name="txtQestionContent" class="input" style="width: 400px; height: 100px"></textarea>
                    </div>
                    <div class="label">联系手机:</div>
                    <div class="field">
                        <input type="tel" class="input" id="telPhone" name="telPhone" data-validate="mobile:请输入正确手机号" style="width: 400px" />
                    </div>
                    <div class="label">接收短信提醒:</div>
                    <div class="field">
                        <div>
                            <div style="float: left">
                                <input type="radio" id="radWorkDay" name="radTime" />
                                <label for="radWorkDay">每日9:00-18:00 </label>
                            </div>
                            <div style="float: left; margin-left: 10px; margin-right: 10px">

                                <input type="radio" id="radAnyTime" name="radTime" />
                                <label for="radAnyTime">任何时间 </label>
                            </div>
                            <div>

                                <input type="radio" id="radNeverReceive" name="radTime" />
                                <label for="radNeverReceive">从不接收 </label>
                            </div>
                        </div>
                    </div>
                    <div class="label">联系邮箱:</div>
                    <div class="field">
                        <input type="email" class="input" id="txtEmail" name="txtEmail" data-validate="email:请输入正确邮箱格式" style="width: 400px" />
                    </div>
                    <div class="label">指定回答人：</div>
                    <div>
                        <input type="radio" id="allPerson" name="Appoint" value="all" checked="checked" />
                        <label for="allPerson">全部人员 </label>
                        <input type="radio" id="person" name="Appoint" value="one" onclick="add_emp()" />
                        <label for="person" id="lblemp">单独指定 </label>

                    </div>
                    <br />
                    <div class="label">上传附件:</div>
                    <div class="field">
                        <form id="importForm" action="return false" enctype="multipart/form-data">
                            <div class="upload_choose">
                                <input id="fileImage" type="file" size="30" name="fileselect[]" multiple />

                            </div>
                            <div id="preview" class="upload_preview"></div>
                        </form>
                    </div>
                    <div style="float: left">
                        <div>
                            <input hidden="hidden" id="fileNames" />
                        </div>
                    </div>
                    <br />
                    <div class="form-button">
                        <input type="button" class="button border-green" value="提交" id="btnCommit" onclick="btnCommit_click()" />

                    </div>
                </div>

                <div style="float: left; margin-top: 20px; margin-left: 50px" hidden="hidden" id="QuestionListDiv">
                </div>

            </div>
        </div>
    </div>
    <br>

    <!--底部-->
    <div class="layout fixed-bottom bg-white">
        <div class="border-bottom padding-bottom">
            <div class="text-center height-big text-small">
                Copyright&nbsp; @&nbsp;  2013-2020&nbsp;  All&nbsp;  Rights&nbsp;  Reserved&nbsp; &nbsp;    版权所有:临沂新明辉安全科技有限公司&nbsp; &nbsp;    技术支持:山东易安捷科技股份有限公司
            </div>
        </div>
    </div>
    <hr>
</body>

</html>

<script type="text/javascript">
    var winWidth = 0;
    var winHeight = 0;
    function findDimensions() { //函数：获取尺寸
        //获取窗口宽度
        if (window.innerWidth) {
            winWidth = window.innerWidth;
        }
        else if ((document.body) && (document.body.clientWidth)) {
            winWidth = document.body.clientWidth;
        }
        //获取窗口高度
        if (window.innerHeight) {
            winHeight = window.innerHeight;
        }
        else if ((document.body) && (document.body.clientHeight)) {
            winHeight = document.body.clientHeight;
        }
        //通过深入Document内部对body进行检测，获取窗口大小
        if (document.documentElement && document.documentElement.clientHeight && document.documentElement.clientWidth) {
            winHeight = document.documentElement.clientHeight - 100;
            winWidth = document.documentElement.clientWidth;
        }
        //设置div的具体宽度=窗口的宽度的%
        if (document.getElementById("divBody")) {
            document.getElementById("divBody").style.height = winHeight + "px";
        }
    }
    findDimensions();
    window.onresize = findDimensions;
</script>
<script>
    var params = {
        fileInput: $("#fileImage").get(0),
        dragDrop: null,
        upButton: null,
        url: "",
        filter: function (files) {
            var arrFiles = [];
            for (var i = 0, file; file = files[i]; i++) {
                if (file.type.indexOf("image") == 0) {
                    if (file.size >= 512000) {
                        alert('您这张"' + file.name + '"图片大小过大，应小于500k');
                    } else {
                        arrFiles.push(file);
                    }
                } else {
                    alert('文件"' + file.name + '"不是图片。');
                }
                $("#importForm").ajaxSubmit({
                    type: "post",
                    url: "../DataSSN/SSN_Question.ashx",
                    dataType: "text",
                    success: function (result) {
                        var fileName = $("#fileNames").val();
                        $("#fileNames").val(result += "," + fileName);
                    }
                });

            }
            return arrFiles;
        },
        onSelect: function (files) {
            var html = '', i = 0;
            $("#preview").html('<div class="upload_loading"></div>');
            var funAppendImage = function () {
                file = files[i];
                if (file) {
                    var reader = new FileReader()
                    reader.onload = function (e) {
                        html = html + '<div id="uploadList_' + i + '" style="float:left;" class="upload_append_list"><p><strong>' + file.name + '</strong>' +
                            '<a href="javascript:" class="upload_delete" title="删除" data-index="' + i + '">删除</a><br />' +
                            '<img id="uploadImage_' + i + '" style="width:180px;height:80px;"  src="' + e.target.result + '" class="upload_image" /></p>' +
                            '<span id="uploadProgress_' + i + '" class="upload_progress"></span>' +
                        '</div>';

                        i++;
                        funAppendImage();
                    }
                    reader.readAsDataURL(file);
                } else {
                    $("#preview").html(html);
                    if (html) {
                        //删除方法
                        $(".upload_delete").click(function () {
                            ZXXFILE.funDeleteFile(files[parseInt($(this).attr("data-index"))]);
                            return false;
                        });
                        //提交按钮显示
                        //$("#fileSubmit").show();
                    } else {
                        //提交按钮隐藏
                        //$("#fileSubmit").hide();
                    }
                }
            };
            funAppendImage();
        },
        onDelete: function (file) {
            $("#uploadList_" + file.index).fadeOut();
            $.ajax({
                type: "post",
                url: "../DataSSN/SSN_Question.ashx",
                data: { Action: "deleteFile", fileName: file.name },
                dataType: "text",
                success: function (result) {
                }
            });
        }

    };
    ZXXFILE = $.extend(ZXXFILE, params);
    ZXXFILE.init();
</script>
<script type="text/javascript">
    $(function () {
        $.ajax({
            type: "POST",
            url: "../DataSSN/SSN_Question.ashx",
            dataType: "json",
            data: { Action: "getQuestionType" },
            success: function (result) {
                var obj = eval(result);
                $(obj.rows).each(function (i, item) {
                    document.getElementById("selQestionType").options.add(new Option(item.Art_Menu, item.Id));
                })

            }
        });

        getAboutQuestionList();
    });

    function btnCommit_click() {
        var filesVal = $("#fileNames").val();
        var txtQuestionTitle = $("#txtQuestionTitle").val();
        if (txtQuestionTitle == "" || txtQuestionTitle == null) {
            alert("问题标题不能为空!");
            return;
        }
        var selQestionType = $("#selQestionType option:selected").val();
        if (selQestionType == -1) {
            alert("请选择问题类型！");
            return;
        }
        var txtQestionContent = $("#txtQestionContent").val();
        var telPhone = $("#telPhone").val();
        var radTime = $('input:radio[name="radTime"]:checked').val();
        var txtEmail = $("#txtEmail").val();

        var sp_uid = ",all,";
        if ($("input:radio[name='Appoint']:checked").val() == "one") {
            if (($("#lblemp").val()) == "") {
                alert("请选择指定人员");
                return;
            } else {
                sp_uid = "," + $("#lblemp").val() + ",";
            }
        }


        $.ajax({
            type: "post",
            url: "../DataSSN/SSN_Question.ashx",
            data: { Action: "action", filesVal: filesVal, txtQuestionTitle: txtQuestionTitle, selQestionType: selQestionType, txtQestionContent: txtQestionContent, telPhone: telPhone, radTime: radTime, txtEmail: txtEmail, sp_uid: sp_uid },
            dataType: "json",
            success: function (result) {
                alert(result.text);
                window.location.href = "Question.aspx"
            }
        });
    }
    function getAboutQuestionList() {
        $('#txtQuestionTitle').keydown(function (e) {
            if (e.keyCode == 13) {
                var txtQuestionTitle = $("#txtQuestionTitle").val();
                $.ajax({
                    type: "post",
                    url: "../DataSSN/SSN_Question.ashx",
                    data: { Action: "getAboutQuestionList", txtQuestionTitle: txtQuestionTitle },
                    dataType: "json",
                    success: function (result) {

                        var itemContainer = $("#QuestionListDiv");

                        itemContainer.html('');

                        var html = "<div class='holder sublanmu_content sublanmu_content_article' style='border:1px solid #000;'>";
                        html += "<div style='border-bottom:1px solid #000;font-size:18px;padding: 5px 100px 5px 5px;'>问题快速引导</div>";
                        html += "<ul id='itemContainer' class='article' style='font-size:14px;font-weight:bold'>";
                        var obj = eval(result);
                        $(obj.rows).each(function (i, item) {
                            html += " <li class='titleList'><span class='title'>"
                                    + "<a href='javascript:void(0);' onclick='btnSearchQuestionDetail(" + item.status + "," + item.id + ")'  >" + item.title + "</a></span>"
                                    //+ "<span class='date'>" + formatTimebytype(item.q_time, 'yyyy-MM-dd hh:mm:ss') + "</span>"
                               + " </li>";
                        })
                        html += "</ul>";
                        html += "</div>";
                        //art_view.aspx?flag=" + item.id + "
                        itemContainer.html(html);
                        //给文章设置选中时给当前行加样式
                        $("li.titleList").mouseover(function () {
                            var jitem = $(this);
                            jitem.addClass("title_current");

                        });
                        $("li.titleList").mouseout(function () {
                            var jitem = $(this);
                            jitem.removeClass("title_current");
                        });
                        itemContainer.show();
                    }
                });
            }
        });

    }
    function btnSearchQuestionDetail(status, id) {
        if (status == 1) {
            window.open("QuestionView.aspx?question_id=" + id + "&from=question");
        } else {
            window.open("art_view.aspx?flag=" + id);
        }
    }
    function txtQuestionTitle_onblur() {
        var txtQuestionTitle = $("#txtQuestionTitle").val();
        if (txtQuestionTitle == "" || txtQuestionTitle == null) {
            $("#txtQuestionTitleError").html("问题标题不能为空!");
            return;
        }
    }
    function selQestionType_onselect() {
        var selQestionType = $("#selQestionType option:selected").val();
        if (selQestionType == -1) {
            $("#selQestionTypeError").html("请选择问题类型!");
            return;
        }
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


    function add_emp() {
        $.ligerDialog.open({
            title: '选择联系人', width: 700, height: 400, url: '../ssn/system/ssn_getdepempOne.aspx?role_id=' + getparastr("rid"), buttons: [
                { text: '确定', onclick: f_selectContactOK },
                { text: '取消', onclick: function (item, dialog) { dialog.close(); } }
            ], zindex: 9003
        });
        return false;
    }

    function f_selectContactOK(item, dialog) {
        var rows = dialog.frame.f_select();
        if (!rows) {
            alert('请选指定人员!');
            return;
        }
        var rid = rows.ID;
        var name = rows.name;
        $("#lblemp").html(name);
        $("#lblemp").val(rid);
        dialog.close();
    }
</script>
