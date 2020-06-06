<%@ Page Title="" Language="C#" MasterPageFile="~/SSN/QA.Master" AutoEventWireup="true" CodeBehind="Answer.aspx.cs" Inherits="SSN.SSN.Answer" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <link href="../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/Toolbar.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/core.css" rel="stylesheet" type="text/css" />
    <script src="../lib/ligerUI/js/plugins/ligerDialog.js"></script>
    <script src="../JS/XHD.js"></script>

    <ul class="bread bg">
        <li><a href="javascript:void(0)" class="icon-home">首页</a> </li>
        <li><a href="javascript:void(0)">我的回答</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="xm9">
        <%--<div class="alert alert-yellow"><span class="close"></span><strong>注意：</strong>您有26条未读信息，<a href="javascript:void(0)">点击查看</a>。</div>
        <div class="alert alert-yellow"><span class="close"></span><strong>注意：</strong>您有13条回复信息，<a href="javascript:void(0)">点击查看</a>。</div>--%>
        <div class="panel">
            <div class="tab">
                <%--<form method="post" runat="server">--%>
                <%--       <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>--%>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <div class="tab-head">
                            <ul class="linkButton">
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="All" runat="server" OnCommand="lbtnAll_Command" OnClientClick=" menu_id=0;" CommandName="All"></asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="waitingprocessed" runat="server" OnCommand="lbtnAll_Command" OnClientClick=" menu_id=1;" CommandName="waitingprocessed">待处理</asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="processing" runat="server" OnCommand="lbtnAll_Command" OnClientClick=" menu_id=2;" CommandName="processing">处理中</asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="waitingconfirmed" runat="server" OnCommand="lbtnAll_Command" OnClientClick=" menu_id=3;" CommandName="waitingconfirmed">待确认</asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="waitingevaluated" runat="server" OnCommand="lbtnAll_Command" OnClientClick=" menu_id=4;" CommandName="waitingevaluated">待评价</asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="completed" runat="server" OnCommand="lbtnAll_Command" OnClientClick=" menu_id=5;" CommandName="completed">已完成</asp:LinkButton></li>
                            </ul>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="tab-body">
                    <div class="tab-panel active" id="tab-all-question">
                        <!--全部提问 start-->
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="admin-panel">
                                    <div class="panel">
                                        <div class="padding border-bottom">
                                            <asp:Button ID="btnSearch" class="icon-search button" Style="float: right;" runat="server" Text="搜索" OnClick="btnSearch_Click" />&nbsp;
                                                        <asp:TextBox ID="txtSearch" placeholder="文本框" runat="server" class="input" Style="width: 200px; float: right; margin-right: 10px"></asp:TextBox>
                                        </div>

                                        <div style="overflow: auto; width: 100%">
                                            <table class="table" style="font-size: smaller; height: auto;">
                                                <tr>
                                                    <th>
                                                        <div style="width: 20px"></div>
                                                    </th>
                                                    <th>
                                                        <div style="width: 50px">编号                     </div>
                                                    </th>
                                                    <th>
                                                        <div style="width: 150px">标题                </div>
                                                    </th>
                                                    <th>
                                                        <div style="width: 50px">提问人                     </div>
                                                    </th>
                                                    <th>
                                                        <div style="width: 100px">分类                     </div>
                                                    </th>
                                                    <th>
                                                        <div style="width: 50px">类型                     </div>
                                                    </th>
                                                    <th>
                                                        <div style="width: 80px">提问时间                    </div>
                                                    </th>
                                                </tr>

                                                <asp:Repeater ID="repCustomer" runat="server" OnItemCommand="repCustomer_ItemCommand">
                                                    <HeaderTemplate>
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <tr>
                                                            <td></td>
                                                            <td><%# AspNetPager1.PageSize * AspNetPager1.CurrentPageIndex + Container.ItemIndex + 1 - 10 %></td>
                                                            <td><%# DataBinder.Eval(Container.DataItem,"title") %></td>
                                                            <td><%# DataBinder.Eval(Container.DataItem,"q_name") %></td>
                                                            <td><%# DataBinder.Eval(Container.DataItem,"art_menu") %></td>
                                                            <td><%# DataBinder.Eval(Container.DataItem,"stype") %></td>
                                                            <td><%# DataBinder.Eval(Container.DataItem,"q_time") %></td>

                                                            <td>
                                                                <%-- <asp:LinkButton ID="delete" CommandName="delete" runat="server" class="button border-yellow button-little" CommandArgument='<%#Eval("id") %>'
                                                                        OnClientClick="javascript:return confirm('确认删除此信息吗？')" Text="删除"></asp:LinkButton>--%>
                                                                <asp:LinkButton ID="showQuestion" CommandName="showQuestion" runat="server" class="button border-green button-little" CommandArgument='<%#Eval("id") %>'
                                                                    Text="查看"></asp:LinkButton>
                                                                <button class="button border-blue button-little" onclick="transfer('<%#Eval("id") %>')">转移</button>
                                                                <%--<asp:LinkButton ID="transfer" CommandName="transfer" class="button border-blue button-little" OnClientClick="transfer('<%#Eval("id") %>')" CommandArgument='<%#Eval("id") %>' runat="server">转移</asp:LinkButton>--%>
                                                            </td>
                                                        </tr>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                    </FooterTemplate>
                                                </asp:Repeater>

                                            </table>
                                        </div>

                                        <div class="panel-foot text-center">
                                            <span class="fanye" style="margin-top: 20px;">
                                                <webdiyer:AspNetPager ID="AspNetPager1" runat="server"
                                                    FirstPageText="第一页" LastPageText="最后一页"
                                                    NextPageText="下一页" PrevPageText="上一页"
                                                    ShowCustomInfoSection="Left"
                                                    SubmitButtonText="转至" AlwaysShow="True"
                                                    PageSize="10" CssClass="pages"
                                                    CurrentPageButtonClass="cpb" CustomInfoSectionWidth="30%"
                                                    NumericButtonCount="5" OnPageChanged="AspNetPager1_PageChanged">
                                                </webdiyer:AspNetPager>
                                            </span>
                                            <div class="clear"></div>
                                        </div>
                                    </div>
                                </div>
                                <!--全部提问 end-->
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>

                </div>
                <%--</form>--%>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        var menu_id = 0;
        var q_id = '';
        function transfer(qid) {
            q_id = qid;
            if (menu_id == 0 || menu_id == 1 || menu_id == 2) {
                $.ligerDialog.open({
                    title: '选择联系人', width: 700, height: 400, url: '../ssn/system/ssn_getdepempOne.aspx?role_id=' + getparastr("rid"), buttons: [
                        { text: '确定', onclick: f_selectContactOK },
                        { text: '取消', onclick: function (item, dialog) { dialog.close(); } }
                    ], zindex: 9003
                });
            } else {
                alert('此问题已过时!');
            }
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
            $.ajax({
                type: "POST",
                dateType: "text",
                async: false,
                url: "../datassn/ssn_answer.ashx?",
                data: { Action: "transfer", qid: q_id, rid: "," + rid + "," },
                success: function (result) {
                    var data = eval("(" + result + ")");
                    if (data.success) {
                        alert(data.msg);
                    } else {
                        alert(data.msg);
                    }
                }
            });
            dialog.close();
        }
    </script>
</asp:Content>
