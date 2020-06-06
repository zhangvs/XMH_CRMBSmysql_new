<%@ Page Title="" Language="C#" MasterPageFile="~/SSN/QA.Master" AutoEventWireup="true" CodeBehind="QuestionView.aspx.cs" Inherits="SSN.SSN.QuestionView" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="../ueditor1_2_5_1-utf8-net/themes/default/css/ueditor.css" rel="stylesheet" />
    <script type="text/javascript" charset="utf-8" src="../../ueditor1_2_5_1-utf8-net/editor_config.js"></script>
    <script src="../ueditor1_2_5_1-utf8-net/editor_all.js"></script>
    <script src="../ueditor1_2_5_1-utf8-net/lang/zh-cn/zh-cn.js"></script>
    <%--<form id="form3"  runat="server">--%>
    <ul class="bread bg">
        <li><a href="javascript:void(0)" class="icon-home">首页</a> </li>
        <li>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="back_Click"></asp:LinkButton></li>
        <li>问题详情</li>
    </ul>
    <%--</form>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<a href="Question.aspx" class="addReply button text-red">返回</a>--%>
    <div class="xm9">

        <div class="panel">
            <%--<form id="form1" runat="server">--%>
            <%--         <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>--%>

            <div>

                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="media media-x padding-big margin-top bg-yellow-light ">
                            <div class="float-left" style="width: 100px; text-align: center">
                                <img id="m_img" runat="server" src="" style="height: 64px; width: 64px" class="radius" alt="..." />

                                <div id="dq_name" runat="server"></div>
                            </div>
                            <div class="padding-left padding-right padding-bottom">
                                <div id="dq_title" runat="server" class="media-body media-body text-default text-blue ">
                                </div>
                            </div>

                            <div class="button-group button-group-little " style="width: 100%">
                                <div style="margin-left: 100px">
                                    <asp:Repeater ID="repImage" runat="server">
                                        <ItemTemplate>
                                            <img style="width: 200px;" alt="" src="../file/question/<%#Eval("ImgUrl") %>" />
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                                <div id="dq_time" runat="server" class="text-gray icon-clock-o float-right ">
                                </div>
                            </div>

                            <hr />
                        </div>

                        <%--                        <input id="h_pid" runat="server" value="<%=qid %>" />--%>

                        <div class="detial padding-big " style="overflow-y: auto; overflow-x: hidden; width: 100%;">
                            <ul class="list-media">
                                <asp:Repeater ID="repCustomer" runat="server" OnItemDataBound="rptypelist_ItemDataBound" OnItemCommand="repCustomer_ItemCommand">
                                    <HeaderTemplate>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <li>
                                            <div class="media media-x padding-big-left padding-big-right">
                                                <div class="float-left" style="width: 100px; text-align: center">
                                                    <img src="<%# (Eval("headImg")).ToString() ==""?"../file/user/unset.jpg":"http://172.178.1.211:8087/images/upload/portrait/"+Eval("headImg").ToString()%>" style="height: 64px; width: 64px" class="radius" alt="..." />
                                                    <h5 class="text-gray"><%# Eval("answer_name") %></h5>
                                                </div>
                                                <div class="padding-left padding-right padding-bottom">
                                                    <div class="media-body media-body text-default ">
                                                        <strong style="font-size: 18px">回复时间：<%# Eval("answer_time") %></strong><%# DataBinder.Eval(Container.DataItem,"answer_content") %>
                                                    </div>
                                                </div>
                                                <button type="button" onclick="showReply('reply<%# Eval("id") %>',this,'<%# Eval("id") %>','<%# Eval("answer_name") %>','<%# Eval("answer_uid") %>')" class="button icon-reply text-blue">回复</button>

                                                <button type="button" name="IsBestAnswer" onclick='MakeBestAnswer(<%# Eval("id") %>)' class="button icon-reply text-green" style="border: solid 0px #ddd; display: none">评为最佳答案</button>
                                                <label style="color: red; margin-left: 10px" hidden="hidden" id="<%# Eval("id") %>">最佳答案</label>
                                                <label style="color: blue; margin-left: 10px" hidden="hidden" id="evaluat_<%# Eval("id") %>"></label>
                                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                    <ContentTemplate>
                                                        <div class="padding-left padding-right padding-bottom" id="reply<%# Eval("id") %>" style="display: none; margin-left: 100px; margin-top: 20px">
                                                            <asp:Repeater ID="addQuestion" runat="server">
                                                                <ItemTemplate>
                                                                    <div>
                                                                        <strong style="font-size: 12px; font-family: 'Microsoft YaHei'"><%# Eval("answer_name") %>&nbsp;&nbsp;回复&nbsp;&nbsp;<%# Eval("question_name") %>(<%# Eval("operatortime") %>):</strong><%# DataBinder.Eval(Container.DataItem,"content") %>
                                                                        <button type="button" onclick="addReply('<%# Eval("id") %>','<%# Eval("answer_name") %>','<%# Eval("answer_uid") %>')" class="button icon-reply text-green" style="border: solid 0px #ddd;">回复</button>
                                                                    </div>
                                                                </ItemTemplate>
                                                            </asp:Repeater>
                                                            <div style="margin-top: 10px; height: 25px;">
                                                                <input type="text" class="input" id="addReply<%# Eval("id") %>" style="width: 350px; float: left" />
                                                                <%--<button type="button" onclick="publish()" class="addReply button text-red" style="margin-left: 5px">发表</button>--%>
                                                                <asp:Button ID="publish" runat="server" class="addReply button text-red" Text="发表" CommandName="publish" OnClientClick="publish()" CommandArgument='<%#Eval("id") %>' />
                                                            </div>
                                                        </div>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                                <hr />
                                            </div>
                                        </li>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                    </FooterTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>

                        <div class=" panel-foot text-center " style="padding: 10px">
                            <%-- <span class="fanye" style="margin-top: 10px;">--%>
                            <webdiyer:AspNetPager ID="AspNetPager1" runat="server"
                                FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" ShowCustomInfoSection="Left" SubmitButtonText="转至" AlwaysShow="True" PageSize="5" CssClass="pages" CurrentPageButtonClass="cpb" CustomInfoSectionWidth="30%" NumericButtonCount="5" OnPageChanged="AspNetPager1_PageChanged">
                            </webdiyer:AspNetPager>
                            <%--</span>--%>
                            <div class="clear"></div>
                        </div>

                        <div id="reply_h">
                            <div class="panel-head margin-top" style="height: 35px">
                                <h4><strong>回复内容: </strong></h4>
                            </div>
                            <asp:Button ID="InnerBtn" class="button button-small bg-blue" Style="margin-top: 5px; margin-left: 20px; width: 100px" runat="server" Text="回复" OnClientClick="Reply()" OnClick="Button1_Click" />
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="panel-body padding-small" id="reply_b" style="margin-left: 15px">

                    <script id="container" name="content" type="text/plain" style="width: 650px;"></script>

                </div>

            </div>
            <%--</form>--%>
        </div>
    </div>
    <script type="text/javascript">
        var curID = 0;
        var curUid = 0;
        var curName = "";
        var qid = 0;
        var ue = UE.getEditor('container', {
            initialFrameWidth: 650,
            initialFrameHeight: 200,
            toolbars: [
           ['undo', 'redo', '|',
               'bold', 'italic', 'underline', 'strikethrough', 'superscript', 'subscript', '|', 'cleardoc', '|',
               'insertimage', 'emotion', '|',
           ]
            ],
        });


        $(function () {
            var q_id = '<%=Session["h_qid"] %>';
            var q_pid = '<%= Session["q_pid"]%>';
            var empID = '<%=Session["empID"]%>';
            var currentBtn = document.getElementsByName("IsBestAnswer");
            if (q_pid == empID) {   //如果问题的提问者不是当前登录者，则不显示"评为最佳答案"按钮
                for (var i = 0; i < currentBtn.length; i++) {
                    currentBtn[i].style.display = 'block';
                }
            }

            $.ajax({
                type: "POST",
                dateType: "json",
                url: "../datassn/ssn_answer.ashx?",
                data: { Action: "permission_reply", q_id: q_id },
                success: function (e) {
                    var objson = eval("(" + e + ")");
                    if (objson.success) {
                        document.getElementById("reply_h").style.display = "none";
                        document.getElementById("reply_b").style.display = "none";
                    }
                    if (objson.flag) {
                        var currentBtn = document.getElementsByName("IsBestAnswer");
                        for (var i = 0; i < currentBtn.length; i++) {
                            currentBtn[i].style.display = 'none';
                        }
                        $("#" + objson.id).show();
                        var evaluatelevelVal = objson.evaluatelevel;
                        if (evaluatelevelVal == "0") {
                            evaluatelevelVal = "未评分";
                        } else if (evaluatelevelVal == "1") {
                            evaluatelevelVal = "优";
                        } else if (evaluatelevelVal == "2") {
                            evaluatelevelVal = "良"
                        } else if (evaluatelevelVal == "3") {
                            evaluatelevelVal = "差";
                        }
                        $("#evaluat_" + objson.id).html("评分:" + evaluatelevelVal);
                        $("#evaluat_" + objson.id).show();
                    }
                }
            });
        });

        function Reply() {
            var q_id = '<%=Session["h_qid"] %>';
            var reply_str = ue.getContent();
            var arr = [];
            arr.push(ue.getContent());

            if (reply_str != "") {
                $.ajax({
                    type: "POST",
                    dateType: "json",
                    async: false,
                    url: "../datassn/ssn_answer.ashx?",
                    data: { Action: "q_reply", q_id: q_id, reply_str: encodeURI(escape(arr)) },
                    success: function (e) {
                        var objson = eval("(" + e + ")");
                        if (objson.success) {
                            ue.execCommand("clearDoc");
                        }
                        else {
                            alert(objson.msg);
                        }
                    }
                });
            } else {
                alert("您回复的内容为空！");
            }
        }

        function showReply(divID, e, id, name, uid) {
            if ($('#' + divID).css("display") == 'none') {
                curID = id;
                curUid = uid;
                qid = id;
                curName = name;
                document.getElementById(divID).style.display = 'block';
                $(e).html("收起回复");
                $("#addReply" + curID).val("回复 " + name + ": ");

            } else if ($('#' + divID).css("display") === 'block') {
                document.getElementById(divID).style.display = 'none';
                $(e).html("回复");
                $("#addReply" + curID).val("");
                curID = 0;
                curUid = 0;
                qid = 0;
                curName = "";
            }
        }

        function addReply(add_id, uid_name, uid) {
            $("#addReply" + curID).val("回复 " + uid_name + ": ");
            curUid = uid;
            curName = uid_name;
        }

        //发表回复
        function publish() {
            var q_id = '<%=Session["h_qid"] %>';
            if (curID != 0 && curUid != 0 && q_id != "") {
                var content = $("#addReply" + curID).val();
                var num = content.indexOf(':');
                content = content.substring(num + 1, content.length);
                $.ajax({
                    type: "POST",
                    dateType: "json",
                    async: false,
                    url: "../datassn/ssn_answer.ashx?",
                    data: { Action: "add_reply", q_id: q_id, curID: curID, curUid: curUid, curName: curName, content: content },
                    success: function (e) {
                        var objson = eval("(" + e + ")");
                        if (objson.success) {
                        }
                        else {
                            alert(objson.msg);
                        }
                    }
                });
            }
        }

        function MakeBestAnswer(id) {
            $.ajax({
                type: "POST",
                dateType: "json",
                async: false,
                url: "../datassn/ssn_answer.ashx?",
                data: { Action: "makeBestAnswer", id: id },
                success: function (result) {
                    var objson = eval("(" + result + ")");
                    if (objson.succ) {
                        alert("设置成功");
                        var currentBtn = document.getElementsByName("IsBestAnswer");
                        for (var i = 0; i < currentBtn.length; i++) {
                            currentBtn[i].style.display = 'none';
                        }
                        $("#" + id).show();

                        var evaluatelevelVal = objson.evaluatelevel;
                        if (evaluatelevelVal == "0") {
                            evaluatelevelVal = "未评分";
                        } else if (evaluatelevelVal == "1") {
                            evaluatelevelVal = "优";
                        } else if (evaluatelevelVal == "2") {
                            evaluatelevelVal = "良"
                        } else if (evaluatelevelVal == "3") {
                            evaluatelevelVal = "差";
                        }
                        $("#evaluat_" + id).html("评分:" + evaluatelevelVal);
                        $("#evaluat_" + id).show();
                    } else {
                        alert("设置失败");
                    }
                }
            });
        }
    </script>

</asp:Content>
