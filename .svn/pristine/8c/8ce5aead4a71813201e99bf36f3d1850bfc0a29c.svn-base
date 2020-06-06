<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta content="ie=8" http-equiv="X-UA-Compatible">
    <meta http-equiv="content-type" content="text/html; charset=gb2312">
    <title>新明辉DMS系统</title>
    <link href="lib/ligerUI/skins/ext/css/ligerui-dialog.css" rel="stylesheet" />
    <script src="lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="JS/jquery.md5.js" type="text/javascript"></script>
    <script src="JS/XHD.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            delCookie("xhdcrm_show_wellcome")
            if (getCookie("xhdcrm_uid") && getCookie("xhdcrm_uid") != null)
                $("#T_uid").val(getCookie("xhdcrm_uid"))

            var FromUrl = getQueryStringByName("FromUrl");
            if (!FromUrl) {
                FromUrl = encodeURIComponent("main.aspx");
            }
            $(document).keydown(function (e) {
                if (e.keyCode == 13) {
                    dologin();
                }
            });
            $("#login").click(function () {
                dologin();
            });
            $("#reset").click(function () {
                $(":input", "#form1").not(":button,:submit:reset:hidden").val("");
            });
            function dologin() {
                var uid = $("#T_uid").val();
                var pwd = $("#T_pwd").val();
                var validate = $("#T_validate").val();
                if (validate == "") {
                    alert("验证码不能为空！");
                    $("#T_validate").focus();
                    return;
                }
                else if (validate.length != 4) {
                    alert("验证码错误！");
                    $("#T_validate").focus();
                    return;
                }

                if (uid == "") {
                    alert("账号不能为空！");
                    $("#T_uid").focus();
                    return;
                }
                if (pwd == "") {
                    alert("密码不能为空！");
                    $("#T_pwd").focus();
                    return;
                }


                $.ajax({
                    type: 'post', dataType: 'json',
                    url: 'Data/login.ashx',
                    async: false,
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
                                    SetCookie("xhdscm_uid", uid, 30);
                                    SetCookie("xhd_crm_show_wellcome", "1");
                                    if (pwd == "123456") {
                                        showdiv();
                                    } else {
                                        location.href = decodeURIComponent(FromUrl);
                                    }
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
                                    alert("此帐号无登录权限！");
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
                    beforeSend: function () {
                        // $.ligerDialog.waitting("正在登陆中,请稍后...");
                        $("#lgoin").attr("disabled", true);
                    },
                    complete: function () {
                        // $.ligerDialog.closeWaitting();
                        $("#login").attr("disabled", false);
                    }
                });
            }
        })
        function showdiv() {
            document.getElementById("bg").style.display = "block";
            document.getElementById("show").style.display = "block";
        }
        function hidediv() {
            document.getElementById("bg").style.display = 'none';
            document.getElementById("show").style.display = 'none';
        }
        function f_save() {

            var pwd1 = $("#T_newpwd").val();
            var pwd2 = $("#T_confime").val();
            if (pwd1 == "" || pwd2 == "") {
                alert("新密码不能为空！");
                return;
            }
            if (pwd1.length < 6) {
                alert("新密码不能少于6位！");
                return;
            }
            if (pwd1 != pwd2) {
                alert("两次输入不一致！");
                return;
            }
            if (pwd1 == "123456") {
                alert("新密码不能为初始密码！");
                return;
            }
            var FromUrl = getQueryStringByName("FromUrl");
            if (!FromUrl) {
                FromUrl = encodeURIComponent("main.aspx");
            }
            $.ajax({
                url: "../data/scm_employee.ashx", type: "POST",
                data: { Action: "changepwd", T_oldpwd: '123456', T_newpwd: pwd1, rnd: Math.random() },
                success: function (responseText) {
                    if (responseText == "true") {
                        location.href = decodeURIComponent(FromUrl);
                    }
                    else {
                        alert('未知错误');
                    }
                },
                error: function () {

                }
            });
        }
    </script>
    <style type="text/css">
        img {
            border: none;
        }

        .text {
            border: #d2e2f2 1px solid;
            height: 19px;
        }

        /*body {
            BACKGROUND: url(images/login/DAM.png) repeat-x;
        }*/

        #bg {
            display: none;
            position: absolute;
            top: 0%;
            left: 0%;
            width: 100%;
            height: 100%;
            background-color: black;
            z-index: 1001;
            -moz-opacity: 0.7;
            opacity: .70;
            filter: alpha(opacity=70);
        }

        #show {
            display: none;
            position: absolute;
            top: 30%;
            left: 30%;
            width: 430px;
            height: 230px;
            padding: 8px;
            border: 8px solid #E8E9F7;
            background-color: white;
            z-index: 1002;
            overflow: auto;
            font-family: 宋体;
            font-size: 12px;
            letter-spacing: 1.5px;
        }
    </style>
    <script type="text/javascript">
        if (top.location != self.location) top.location = self.location;
    </script>
</head>
<body>
    <div id="bg"></div>
    <div id="show" style="text-align: center;">
        <fieldset style="padding: 10px; height: 205px;">
            <legend style="font-weight: bold; font-size: 14px; letter-spacing: 2px;">密码修改</legend>
            <form id="form2" name="form2">
                <table style="height: 150px; text-align: center; padding-left: 30px;">
                    <tr style="line-height: 32px;">
                        <td colspan="2">您的密码为初始密码，请修改后再操作！</td>
                    </tr>
                    <tr>
                        <td height="23" width="100px">
                            <div align="right" style="width: 100px">
                                新密码：
                            </div>
                        </td>
                        <td height="23">
                            <div style="float: left; height: 20px;">
                                <input type="password" id="T_newpwd" name="T_newpwd" />
                            </div>

                        </td>
                    </tr>

                    <tr>
                        <td height="23" width="100px">
                            <div align="right" style="width: 100px">确认密码：</div>

                        </td>
                        <td height="23">
                            <div style="float: left; height: 20px;">
                                <input type="password" id="T_confime" name="T_confime" />
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                </table>
                <input id="btnclose" type="button" value="确认" onclick="f_save()" style="margin-left: 10px; width: 80px; height: 30px;" />
                <input id="btnsave" type="button" style="margin-right: 10px; width: 80px; height: 30px;" value="取消" onclick="hidediv()" />
            </form>
        </fieldset>
    </div>
    <form id="form1" name="form1">
        <div style="margin: 0 auto; width: 1164px;">
            <div style="height: 800px; margin-left: 50px; margin: -10px; padding: 0px; background: url(images/login/DAM.png);">
                <div style="padding-top: 320px; padding-left: 635px; width: 350px;">
                    <table style="width: 350px; padding-left: 90px;">
                        <tr style="line-height: 30px;">
                            <td align="right" style="font-family: 'Microsoft YaHei'">用户名：</td>
                            <td colspan="2">
                                <input id="T_uid" name="T_uid" type="text" style="width: 160px; color: #999999" class="text" /></td>

                        </tr>
                        <tr style="line-height: 30px;">
                            <td align="right" style="font-family: 'Microsoft YaHei'">密&nbsp;&nbsp;&nbsp;码：</td>
                            <td colspan="2">
                                <input id="T_pwd" name="T_pwd" type="password" style="width: 160px" class="text" /></td>
                        </tr>
                        <tr style="line-height: 30px;">
                            <td align="right" style="font-family: 'Microsoft YaHei'">验证码：</td>
                            <td>
                                <input id="T_validate" name="T_validte" type="text" style="width: 80px" class="text" />
                            </td>
                            <td>
                                <img id="validate" onclick="this.src=this.src+'?'" src="ValidateCode.aspx" style="cursor: pointer; border: 1px solid #ddd" alt="看不清楚，换一张" title="看不清楚，换一张" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="height: 15px;"></td>
                        </tr>
                        <tr style="padding-top: 20px;">
                            <td colspan="3" align="center">
                                <input id="login" type="button" value="登录" style="width: 80px; height: 28px; font-family: 'Microsoft YaHei'" />
                                <input id="reset" type="button" value="重置" style="width: 80px; height: 28px; font-family: 'Microsoft YaHei'" /></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
