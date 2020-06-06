<%@ Page Title="" Language="C#" MasterPageFile="~/SSN/QA.Master" AutoEventWireup="true" CodeBehind="Question.aspx.cs" Inherits="SSN.SSN.Question" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style type="text/css">
        #evaluatDiv {
            display: none;
            position: absolute;
            top: 30%;
            left: 45%;
            width: 430px;
            height: 230px;
            padding: 8px;
            border: 3px solid #6A7371;
            background-color: white;
            z-index: 1002;
            overflow: auto;
            font-family: 'Microsoft YaHei';
            font-size: 14px;
            letter-spacing: 1.5px;
        }

        table.gridtable {
            font-family: verdana,arial,sans-serif;
            font-size: 11px;
            color: #333333;
            border-width: 1px;
            border-color: #666666;
            border-collapse: collapse;
        }

            table.gridtable th {
                border-width: 1px;
                padding: 8px;
                border-style: solid;
                border-color: #666666;
                background-color: #dedede;
            }

            table.gridtable td {
                border-width: 1px;
                padding: 8px;
                border-style: solid;
                border-color: #666666;
                background-color: #ffffff;
            }
    </style>
    <ul class="bread bg">
        <li><a href="javascript:void(0)" class="icon-home">首页</a> </li>
        <li><a href="javascript:void(0)">我的提问</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="xm9">
        <%-- <div class="alert alert-yellow"><span class="close"></span><strong>注意：</strong>您有26条未读信息，<a href="#">点击查看</a>。</div>
        <div class="alert alert-yellow"><span class="close"></span><strong>注意：</strong>您有13条回复信息，<a href="#">点击查看</a>。</div>--%>
        <div class="panel">
            <div class="tab">
                <%--<form method="post" runat="server">--%>
                <%--                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>--%>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>

                        <div class="tab-head">
                            <ul class="linkButton">
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="All" runat="server" OnCommand="lbtnAll_Command" CommandName="All"></asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="waitingprocessed" runat="server" OnCommand="lbtnAll_Command" CommandName="waitingprocessed">待处理</asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="processing" runat="server" OnCommand="lbtnAll_Command" CommandName="processing">处理中</asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="waitingconfirmed" runat="server" OnCommand="lbtnAll_Command" CommandName="waitingconfirmed">待确认</asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="waitingevaluated" runat="server" OnCommand="lbtnAll_Command" CommandName="waitingevaluated">待评价</asp:LinkButton></li>
                                <li class="linkButtonli">
                                    <asp:LinkButton ID="completed" runat="server" OnCommand="lbtnAll_Command" CommandName="completed">已完成</asp:LinkButton></li>
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
                                                        <asp:TextBox ID="txtSearch" placeholder="文本框" class="input" runat="server" Style="width: 200px; float: right; margin-right: 10px"></asp:TextBox>
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
                                                        <div style="width: 80px">提问时间                    </div>
                                                    </th>
                                                </tr>
                                                <asp:Repeater ID="repCustomer" runat="server" OnItemCommand="repCustomer_ItemCommand" OnItemDataBound="repCustomer_ItemDataBound">
                                                    <HeaderTemplate>
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <tr>
                                                            <td></td>
                                                            <td><%# AspNetPager1.PageSize * AspNetPager1.CurrentPageIndex + Container.ItemIndex + 1 - 10 %></td>
                                                            <td><%# DataBinder.Eval(Container.DataItem,"title") %></td>
                                                            <td><%# DataBinder.Eval(Container.DataItem,"q_name") %></td>
                                                            <td><%# DataBinder.Eval(Container.DataItem,"art_menu") %></td>
                                                            <td><%# DataBinder.Eval(Container.DataItem,"q_time") %></td>

                                                            <td>

                                                                <asp:LinkButton ID="delete" CommandName="delete" runat="server" class="button border-yellow button-little" CommandArgument='<%#Eval("id") %>'
                                                                    OnClientClick="javascript:return confirm('确认删除此信息吗？')" Text="删除"></asp:LinkButton>
                                                                <asp:LinkButton ID="showQuestion"  CommandName="showQuestion" runat="server" class="button border-green button-little" CommandArgument='<%#Eval("id") %>'
                                                                    Text="查看"></asp:LinkButton>

                                                                <asp:LinkButton ID="evaluatId" Visible="false" CommandName="MakeEvaluat" runat="server" class="button border-green button-little" CommandArgument='<%#Eval("id") %>' OnClientClick="evaluatId_onClick()"
                                                                    Text="评价"></asp:LinkButton>

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
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <!--全部提问 end-->
                    </div>

                </div>
                <%--</form>--%>
            </div>
        </div>
    </div>

    <div id="evaluatDiv" hidden="hidden">
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
                <table style="width: 100%;" class="gridtable">
                    <tr>
                        <td colspan="3">
                            <div style="font-size: 16px; font-weight: bold">最佳答案</div>
                        </td>
                    </tr>
                    <tr>
                        <th>
                            <div style="width: 80px">回答者</div>
                        </th>
                        <th>
                            <div style="width: 100px">回答内容</div>
                        </th>
                        <th>
                            <div style="width: 80px">回答时间</div>
                        </th>
                    </tr>
                    <asp:Repeater ID="evaluat" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# DataBinder.Eval(Container.DataItem,"answer_name") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem,"answer_content") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem,"answer_time") %>
                                    <input type="hidden" id="hidanswerId" value="<%#Eval("id") %>">
                                </td>

                            </tr>

                        </ItemTemplate>

                    </asp:Repeater>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <div style="float: left">
            <input type="radio" id="radVeryGood" value="1" name="radevaluat" />
            <label for="radVeryGood">优 </label>
        </div>
        <div style="float: left; margin-left: 10px; margin-right: 10px">
            <input type="radio" id="radGood" value="2" name="radevaluat" />
            <label for="radGood">良 </label>
        </div>
        <div>
            <input type="radio" id="radPoor" name="radevaluat" value="3" />
            <label for="radPoor">差 </label>
        </div>
        <br />
        <input id="SubmitRadioVal" type="button" class="button border-green" value="提交" onclick="SubmitEvaluatVal_onClick()" />
         <input id="CloseRadioVal" type="button" class="button border-green" value="取消" onclick="CloseEvaluatVal_onClick()" />
    </div>
    <script type="text/javascript">

        //弹出 评分窗口
        function evaluatId_onClick() {
            $("#evaluatDiv").show();
        }
        //提交评分
        function SubmitEvaluatVal_onClick() {
            var answerid = $("#hidanswerId").val();
            var evaluatVal = $('input:radio[name="radevaluat"]:checked').val();
            $.ajax({
                type: "POST",
                dateType: "text",
                url: "../datassn/ssn_answer.ashx?",
                data: { Action: "SubmitEvaluatVal", answerid: answerid, evaluatVal: evaluatVal },
                success: function (result) {
                    alert(result);
                    $("#evaluatDiv").hide();
                    //window.location.reload();
                }
            });
        }
         function CloseEvaluatVal_onClick()
         {
            $("#evaluatDiv").hide();
         }
    </script>
    <%--<script type="text/javascript">
        function waitingevaluated_Show() {
            $(".evaluatIdDiv").show();
        }
    </script>--%>
</asp:Content>
