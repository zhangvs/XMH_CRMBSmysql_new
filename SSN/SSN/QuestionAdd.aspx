<%@ Page Title="" Language="C#" MasterPageFile="~/SSN/QA.Master" AutoEventWireup="true" CodeBehind="QuestionAdd.aspx.cs" Inherits="SSN.SSN.QuestionAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../JS/jquery.min.js"></script>
    <script src="../Scripts/jquery.validate.min.js"></script>
    <script src="../JS/upload.js"></script>
    <script src="../JS/jquery.form.js"></script>
    <script src="../JS/XHD.js"></script>
    <ul class="bread bg">
        <li><a href="Question.aspx" class="icon-home">首页</a> </li>
        <li><a href="javascript:void(0)">快速提问</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="xm9">
        <div style="float: left; margin-left: 80px;">
            <%--<table>
                <tr>
                    <td>
                        <div class="label"></div><span style="font-size: 20px; font-family: 'Microsoft YaHei'!important">问题标题:</span></td>
                    <td>
                        <input type="text" id="txtQuestionTitle" name="txtQuestionTitle" style="width: 200px" onblur="txtQuestionTitle_onblur()" /><label id="txtQuestionTitleError" style="color: red"></label></td>
                </tr>
                <tr>
                    <td><span style="font-size: 20px; font-family: 'Microsoft YaHei'!important">问题类型:</span></td>
                    <td>
                        <select id="selQestionType" name="selQestionType" style="width: 200px" onchange="selQestionType_onselect()">
                            <option value="-1">--请选择--</option>
                        </select><label id="selQestionTypeError" style="color: red"></label></td>
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

            </table>--%>
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
                    <div>
                        <input type="radio" id="radWorkDay" value="1" name="radTime" />
                        <label for="radWorkDay">每日9:00-18:00 </label>
                    </div>
                    <div>

                        <input type="radio" id="radAnyTime" value="0" name="radTime" />
                        <label for="radAnyTime">任何时间 </label>
                    </div>
                    <div>

                        <input type="radio" id="radNeverReceive" name="radTime" value="2" />
                        <label for="radNeverReceive">从不接收 </label>
                    </div>
                </div>
            </div>
            <div class="label">联系邮箱:</div>
            <div class="field">
                <input type="email" class="input" id="txtEmail" name="txtEmail" data-validate="email:请输入正确邮箱格式" style="width: 400px" />
            </div>
            <div class="label">上传附件:</div>
            <div class="field">
                <%--<form id="importForm" enctype="multipart/form-data">--%>
                <div class="upload_choose">
                    <input id="fileImage" type="file" size="30" name="fileselect[]" multiple />

                </div>
                <div id="preview" class="upload_preview"></div>
                <%--</form>--%>
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

    <script>
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
                            if (num > 3) {
                                alert("最多允许上传三张图片!");
                                return;
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
                                '<a href="javascript:" class="upload_delete" style="color:red;" title="删除" data-index="' + i + '">删除</a><br />' +
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

                            var html = "<div class='holder sublanmu_content sublanmu_content_article' style='border:1px solid #000;'>";
                            html += "<div style='border-bottom:1px solid #000;font-size:18px;padding: 5px 0 5px 5px;'>问题快速引导</div>";
                            html += "<ul id='itemContainer' class='article' style='font-size:14px;font-weight:bold'>";
                            var obj = eval(result);
                            $(obj.rows).each(function (i, item) {
                                html += " <li class='titleList'><span class='title'>"
                                        + "<a href='javascript:void(0);' target='_blank' onclick='btnSearchQuestionDetail(" + item.status + "," + item.id + ")'  >" + item.title + "</a></span>"
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
    </script>
</asp:Content>

