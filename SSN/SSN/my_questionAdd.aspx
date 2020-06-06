<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="my_questionAdd.aspx.cs" Inherits="SSN.SSN.my_questionAdd" %>

<!DOCTYPE html>

<html lang="zh-cn">

<head>
    <title>SSN问答中心</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <meta name="renderer" content="webkit">
    <script src="../JS/jquery.min.js"></script>
    <script src="../Scripts/jquery.validate.min.js"></script>
    <script src="../pintuer/pintuer.js"></script>
    <script src="../JS/upload.js"></script>
    <script src="../JS/jquery.form.js"></script>
    <script src="../JS/XHD.js"></script>
    <link href="../pintuer/pintuer.css" rel="stylesheet" />
    <link href="../pintuer/admin.css" rel="stylesheet" />

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
        }
    </style>
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

    </script>

</head>

<body>
    <!--顶部-->
    <div class="layout bg-main bg-inverse fixed" style="z-index: 9;">
        <div class="container-layout">
            <div class="navbar">
                <!--
                    	描述：LOGO及系统名称
                    -->
                <div class="navbar-head">
                    <button class="button icon-navicon" data-target="#navbar1">
                    </button>
                    <a href="#">
                        <strong class="text-big">SSN问答中心</strong></a>
                </div>
                <!--
                    	描述：导航
                    -->

                <div class="navbar-body nav-navicon" id="navbar1">
                    <ul class="nav nav-inline nav-menu">
                        <li><a class="icon-cog" href="#">设置<span class="arrow"></span></a>
                            <ul class="drop-menu">
                                <li><a href="javascript:;">皮肤设置<span class="arrow"></span></a>
                                    <ul>
                                        <li><a href="#">墨绿</a></li>
                                        <li><a href="#">天蓝</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <li><a class="icon-home" href="index.html">导航<span class="arrow"></span></a>
                            <ul class="drop-menu">
                                <li><a class="icon-th-list" href="#">我的提问</a></li>
                                <li><a class="icon-file-text" href="content.html">我的回答<span class="arrow"></span></a>
                                    <%--<ul>
                                        <li><a href="content.html">新闻</a></li>
                                        <li><a href="#">留言</a></li>
                                        <li><a href="#">反馈</a></li>
                                    </ul>--%>
                                </li>
                                <li><a class="icon-user" href="#">快速提问</a></li>
                            </ul>
                        </li>
                    </ul>
                    <!--
                        	描述：右侧用户资料
                        -->
                    <ul class="nav nav-inline nav-menu navbar-right">
                        <li>
                            <a class="bg-main" href="javascript:;">
                                <spn><img src="http://www.pintuer.com/demo/pintuer2/images/face.jpg" width="28" class="radius-circle"></spn>
                                管理员
								
                                <span class="downward"></span>
                            </a>
                            <ul class="drop-menu">
                                <li><a class="icon-user" target="_blank" href="javascript:;">修改资料</a></li>
                                <li><a class="icon-key" target="_blank" href="javascript:;">修改密码</a></li>
                            </ul>
                        </li>
                        <!--<li><a class="bg-green" href="javascript:;"><span class="icon-envelope"></span>&nbsp;<span class="badge bg-blue">5+</span><span class="downward"></span></a>
								<ul class="drop-menu">
									<li><a class="text-yellow-light" target="_blank" href="javascript:;"><span class="icon-envelope"></span>您有16封邮件</a></li>
									<li><a class="bg-gray" target="_blank" href="javascript:;"><span class="icon-envelope"></span>查阅更多...</a></li>
								</ul>
							</li>-->
                        <li><a class="bg-blue" href="javascript:;"><span class="icon-bell-o"></span>&nbsp;<span class="badge bg-green">39</span><span class="downward"></span></a>
                            <ul class="drop-menu">
                                <li><a class="text-yellow-light active" target="_blank" href="javascript:;"><span class="icon-comment"></span>您有26条未读消息</a></li>
                                <li><a class="text-yellow-light active" target="_blank" href="javascript:;"><span class="icon-comments"></span>您有13条回复消息</a></li>
                            </ul>
                        </li>
                        <li><a class="bg-yellow" target="_blank" href="login.html"><span class="icon-sign-out"></span>注销</a></li>
                    </ul>
                    <!--
                        	描述：左侧搜索
                        -->
                    <div class="navbar-form navbar-left">
                        <form>
                            <input type="text" class="input input-auto" name="keywords" size="15" placeholder="功能名称">
                            <input type="submit" name="search" value="搜索" class="button bg">
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--内容-->
    <div class="layout">
        <ul class="bread bg">
            <li><a href="#" class="icon-home">首页</a> </li>
            <li><a href="#">系统中心</a></li>
        </ul>
        <div class="admin">
            <div class="xm3">
                <div class="panel border-back">
                    <div class="panel-body text-center">
                        <img src="../images/face.jpg" width="120" class="radius-circle" />
                        <br>
                        admin
						
                    </div>
                    <div class="panel-foot bg-back border-back">您好，admin，这是您第100次登录，上次登录为2014-10-1。</div>
                </div>
                <br>
                <div class="panel">
                    <div class="panel-head"><strong>站点统计</strong></div>
                    <ul class="list-group">
                        <li><span class="float-right badge bg-red">23</span><span class="icon-user"></span> 积分</li>
                        <li><span class="float-right badge bg-red">88</span><span class="icon-user"></span> 提问数</li>
                        <li><span class="float-right badge bg-main">180</span><span class="icon-file"></span> 回答数</li>
                        <li><span class="float-right badge bg-main">36.36%</span><span class="icon-shopping-cart"></span> 回答采纳率</li>
                        <li><span class="float-right badge bg-main">80</span><span class="icon-file-text"></span> 回答评优数</li>
                    </ul>
                </div>
                <br>
            </div>
            <div class="xm9">
                <div style="float: left; margin-left: 180px;">
                    <table>
                        <tr>
                            <td><span style="font-size: 20px; font-family: 'Microsoft YaHei'!important">问题标题:</span></td>
                            <td>
                                <input type="text" id="txtQuestionTitle" name="txtQuestionTitle" style="width: 200px" onblur="txtQuestionTitle_onblur()" /><label id="txtQuestionTitleError" style="color:red"></label></td>
                        </tr>
                        <tr>
                            <td><span style="font-size: 20px; font-family: 'Microsoft YaHei'!important">问题类型:</span></td>
                            <td>
                                <select id="selQestionType" name="selQestionType" style="width: 200px" onchange="selQestionType_onselect()">
                                    <option value="-1">--请选择--</option>
                                </select><label id="selQestionTypeError" style="color:red"></label></td>
                        </tr>
                        <tr>
                            <td><span style="font-size: 20px; font-family: 'Microsoft YaHei'!important">问题描述:</span></td>
                            <td>
                                <textarea id="txtQestionContent" name="txtQestionContent" style="width: 200px; height: 200px"></textarea></td>
                        </tr>
                        <tr>
                            <td><span style="font-size: 20px; font-family: 'Microsoft YaHei'!important">联系手机:</span></td>
                            <td>
                                <input type="tel" id="telPhone" name="telPhone" style="width: 200px" /></td>
                        </tr>
                        <tr>
                            <td><span style="font-size: 20px; font-family: 'Microsoft YaHei'!important">接收短信提醒:</span></td>
                            <td>
                                <div>
                                    <div>
                                        <input type="radio" id="radWorkDay" name="radTime" />
                                        <label for="radWorkDay">每日9:00-18:00 </label>
                                    </div>
                                    <div>

                                        <input type="radio" id="radAnyTime" name="radTime" />
                                        <label for="radAnyTime">任何时间 </label>
                                    </div>
                                    <div>

                                        <input type="radio" id="radNeverReceive" name="radTime" />
                                        <label for="radNeverReceive">从不接收 </label>
                                    </div>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td><span style="font-size: 20px; font-family: 'Microsoft YaHei'!important">联系邮箱: </span></td>
                            <td>
                                <input type="email" id="txtEmail" name="txtEmail" style="width: 200px" /></td>
                        </tr>
                        <tr>
                            <td><span style="font-size: 20px; font-family: 'Microsoft YaHei'!important">上传附件:</span></td>
                            <td>
                                <form id="importForm" enctype="multipart/form-data">
                                    <div class="upload_choose">
                                        <input id="fileImage" type="file" size="30" name="fileselect[]" multiple />

                                    </div>
                                    <div id="preview" class="upload_preview"></div>
                                </form>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <input type="button" value="提交" id="btnCommit" onclick="btnCommit_click()" /></td>
                        </tr>

                    </table>
                </div>
                <div style="float: left">
                    <div>
                        <input hidden="hidden" id="fileNames" />
                    </div>

                    <div hidden="hidden" id="QuestionListDiv">
                    </div>

                </div>
            </div>
        </div>
    </div>
    <br>

    <!--底部-->
    <div class="layout fixed-bottom bg-white">
        <div class="border-bottom padding-bottom">
            <div class="text-center height-big text-small">
                <strong>版权所有 © <a href="http://www.pintuer.com">Pintuer.com</a> All Rights Reserved，图ICP备：<a href="http://www.pintuer.com">380959609</a></strong>
            </div>
        </div>
    </div>
    <hr>
</body>

</html>
<script type="text/javascript">
    var num = 0;
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
                            num += 1;
                            if (num>=3) {
                                alert("最多允许上传三张图片!");
                            } else {
                                arrFiles.push(file);
                            }
                           
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
                            $("#fileNames").val(result += fileNames + ",");
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
    function btnCommit_click() {
        var filesVal = $("#fileNames").val();
        var txtQuestionTitle = $("#txtQuestionTitle").val();
        if (txtQuestionTitle == "" || txtQuestionTitle==null) {
            alert("问题标题不能为空!");
            return;
        }
        var selQestionType = $("#selQestionType option:selected").val();
        if (selQestionType==-1) {
            alert("请选择问题类型！");
            return;
        }
        var txtQestionContent = $("#txtQestionContent").val();
        var telPhone = $("#telPhone").val();
        var radTime = $('input:radio[name="radTime"]:checked').val();
        var txtEmail = $("#txtEmail").val();

        $.ajax({
            type: "post",
            url: "../DataSSN/SSN_Question.ashx",
            data: { Action: "action", filesVal: filesVal, txtQuestionTitle: txtQuestionTitle, selQestionType: selQestionType, txtQestionContent: txtQestionContent, telPhone: telPhone, radTime: radTime, txtEmail: txtEmail },
            dataType: "json",
            success: function (result) {
                    alert(result.text);
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

                        var html = "<div class='holder sublanmu_content sublanmu_content_article'></div>";
                        html += "<ul id='itemContainer' class='article'>";
                        var obj = eval(result);
                        $(obj.rows).each(function (i, item) {
                            html += " <li class='titleList'><span class='title'>"
                                    + "<a href='javascript:void(0);' target='_blank' onclick='btnSearchQuestionDetail(" + item.status + "," + item.id + ")'  >" + item.title + "</a></span>"
                                    + "<span class='date'>" + formatTimebytype(item.q_time, 'yyyy-MM-dd hh:mm:ss') + "</span>"
                               + " </li>";
                        })
                        html += "</ul>";
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
            window.open("QuestionView.aspx?question_id=" + id + "&from=questionAdd");
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
  
  

</script>
