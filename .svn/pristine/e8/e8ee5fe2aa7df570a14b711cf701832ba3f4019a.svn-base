<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="my_qa.aspx.cs" Inherits="SSN.SSN.my_qa" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html>

<html lang="zh-cn">

<head>
    <title>SSN问答中心</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <meta name="renderer" content="webkit">
    <script src="../pintuer/jquery.js"></script>
    <script src="../pintuer/pintuer.js"></script>
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
                <div class="alert alert-yellow"><span class="close"></span><strong>注意：</strong>您有26条未读信息，<a href="#">点击查看</a>。</div>
                <div class="alert alert-yellow"><span class="close"></span><strong>注意：</strong>您有13条回复信息，<a href="#">点击查看</a>。</div>
                <div class="panel">
                    <div class="tab">
                        <form method="post" runat="server">
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <div class="tab-head">
                                        <ul class="tab-nav">
                                            <asp:LinkButton ID="lbtnAll" runat="server" OnCommand="lbtnAll_Command" CommandName="All">全部提问(<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>)</asp:LinkButton>
                                            <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="lbtnAll_Command" CommandName="waiting-processed">待处理</asp:LinkButton>
                                            <asp:LinkButton ID="LinkButton2" runat="server" OnCommand="lbtnAll_Command" CommandName="processing">处理中</asp:LinkButton>
                                            <asp:LinkButton ID="LinkButton3" runat="server" OnCommand="lbtnAll_Command" CommandName="waiting-confirmed">待确认</asp:LinkButton>
                                            <asp:LinkButton ID="LinkButton4" runat="server" OnCommand="lbtnAll_Command" CommandName="waiting-evaluated">待评价</asp:LinkButton>
                                            <asp:LinkButton ID="LinkButton5" runat="server" OnCommand="lbtnAll_Command" CommandName="completed">已完成</asp:LinkButton>
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
                                                        <asp:Button ID="btnSearch" class="icon-search" Style="float: right;" runat="server" Text="搜索" OnClick="btnSearch_Click" />&nbsp;
                                                        <asp:TextBox ID="txtSearch" placeholder="文本框" runat="server" Style="width: 200px; float: right; margin-right: 10px"></asp:TextBox>
                                                    </div>

                                                    <div style="overflow: auto; width: 100%">
                                                        <table class="table" style="font-size: smaller; height: 286px;">
                                                            <tr>
                                                                <th>
                                                                    <div style="width: 20px"></div>
                                                                </th>
                                                                <th>
                                                                    <div style="width: 50px">编号                     </div>
                                                                </th>
                                                                <th>
                                                                    <div style="width: 200px">标题                </div>
                                                                </th>
                                                                <th>
                                                                    <div style="width: 40px">提问人                     </div>
                                                                </th>
                                                                <th>
                                                                    <div style="width: 40px">提问时间                    </div>
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
                                                                        <td><%# DataBinder.Eval(Container.DataItem,"q_time") %></td>

                                                                        <td>
                                                                            <asp:LinkButton ID="delete" CommandName="delete" runat="server" class="button border-yellow button-little" CommandArgument='<%#Eval("id") %>'
                                                                                OnClientClick="javascript:return confirm('确认删除此信息吗？')" Text="删除"></asp:LinkButton>

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
                        </form>
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

