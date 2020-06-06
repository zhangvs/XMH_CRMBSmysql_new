<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3c.org/TR/1999/REC-html401-19991224/loose.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta content="ie=8" http-equiv="X-UA-Compatible">
    <meta http-equiv="content-type" content="text/html; charset=gb2312">
    <title>������SSN-��¼</title>
    <link href="lib/ligerUI/skins/ext/css/ligerui-dialog.css" rel="stylesheet" />
    <script src="lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="JS/jquery.md5.js" type="text/javascript"></script>
    <script src="JS/XHD.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            //location.href = "login2016.aspx";//location.hrefʵ����ҳ����ת

            delCookie("xhdcrm_show_wellcome")
            if (getCookie("xhdcrm_uid") && getCookie("xhdcrm_uid") != null)
                $("#T_uid").val(getCookie("xhdcrm_uid"))

            var FromUrl = getQueryStringByName("FromUrl");
            if (!FromUrl) {
                FromUrl = encodeURIComponent("main_ssn.aspx");
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
                    alert("��֤�벻��Ϊ�գ�");
                    $("#T_validate").focus();
                    return;
                }
                else if (validate.length != 4) {
                    alert("��֤�����");
                    $("#T_validate").focus();
                    return;
                }

                if (uid == "") {
                    alert("�˺Ų���Ϊ�գ�");
                    $("#T_uid").focus();
                    return;
                }
                if (pwd == "") {
                    alert("���벻��Ϊ�գ�");
                    $("#T_pwd").focus();
                    return;
                }


                $.ajax({
                    type: 'post', dataType: 'json',
                    url: 'DataSSN/SSN_Login.ashx',
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
                                    alert("��֤�����");
                                    $("#validate").click();
                                    $("#T_validate").val("");
                                    $("#T_validate").focus();
                                    break;
                                case 1:
                                    alert("�û������������");
                                    $("#T_pwd").focus();
                                    break;
                                case 2:
                                    SetCookie("xhdcrm_uid", uid, 30);
                                    SetCookie("xhd_crm_show_wellcome", "1");
                                    if (pwd == "123456") {
                                        showdiv();
                                    } else {
                                        location.href = decodeURIComponent(FromUrl);
                                    }
                                    break;
                                case 3:
                                    alert("�˻��쳣������ϵ����Ա��");
                                    break;
                                case 4:
                                    alert("�˻������Ƶ�¼��");
                                    break;
                                case 5:
                                    alert("���ʺ����ڵ�λ�ѱ�ͣ�ã�");
                                    break;
                                case 6:
                                    alert("��¼IP��ַ���ޣ�");
                                    break;
                            }
                        }
                        else {
                            alert('��½ʧ��,�˺Ż���������!');
                            $("#password").focus();
                            return;
                        }
                    },
                    error: function () {
                        $("#validate").click();
                        alert('����ϵͳ����,����ϵͳ����Ա��ϵ!');
                    },
                    beforeSend: function () {
                        $.ligerDialog.waitting("���ڵ�½��,���Ժ�...");
                        $("#lgoin").attr("disabled", true);
                    },
                    complete: function () {
                        $.ligerDialog.closeWaitting();
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
                alert("�����벻��Ϊ�գ�");
                return;
            }
            if (pwd1.length < 6) {
                alert("�����벻������6λ��");
                return;
            }
            if (pwd1 != pwd2) {
                alert("�������벻һ�£�");
                return;
            }
            if (pwd1 == "123456") {
                alert("�����벻��Ϊ��ʼ���룡");
                return;
            }
            var FromUrl = getQueryStringByName("FromUrl");
            if (!FromUrl) {
                FromUrl = encodeURIComponent("main_ssn.aspx");
            }
            $.ajax({
                url: "../data/hr_employee.ashx", type: "POST",
                data: { Action: "changepwd", T_oldpwd: '123456', T_newpwd: pwd1, rnd: Math.random() },
                success: function (responseText) {
                    if (responseText == "true") {
                        location.href = decodeURIComponent(FromUrl);
                    }
                    else {
                        $.ligerDialog.error('δ֪����');
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

        body {
            BACKGROUND: url(images/login/loginbackground1.jpg) repeat-x;
        }

        .auto-style1 {
            font-size: small;
        }

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
            font-family: ����;
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
            <legend style="font-weight: bold; font-size: 14px; letter-spacing: 2px;">�����޸�</legend>
            <form id="form2" name="form2">
                <table style="height: 150px; text-align: center; padding-left: 30px;">
                    <tr style="line-height: 32px;">
                        <td colspan="2">��������Ϊ��ʼ���룬���޸ĺ��ٲ�����</td>
                    </tr>
                    <tr>
                        <td height="23" width="100px">
                            <div align="right" style="width: 100px">
                                �����룺
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
                            <div align="right" style="width: 100px">ȷ�����룺</div>

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
                <input id="btnclose" type="button" value="ȷ��" onclick="f_save()" style="margin-left: 10px; width: 80px; height: 30px;" />
                <input id="btnsave" type="button" style="margin-right: 10px; width: 80px; height: 30px;" value="ȡ��" onclick="hidediv()" />
            </form>
        </fieldset>
    </div>
    <form id="form1" name="form1">
        <div style="width: 731px; margin-left: 50px; margin-top: 200px;">
            <table id="__01" width="732" height="388" border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td rowspan="6">
                        <a href="">
                            <img src="images/xhd.png" alt="crm" /></a></td>
                    <td rowspan="14" style="background: url(' images/login/login_02.gif') no-repeat; width: 200px; height: 279px;"></td>
                    <td colspan="7" width="187" height="54"></td>
                    <td rowspan="6" background="images/login/login_04.gif" width="110" height="134"></td>
                    <td width="1" height="54"></td>
                </tr>
                <tr>
                    <td rowspan="9" width="6" height="180"></td>
                    <td colspan="5" width="163" height="9"></td>
                    <td rowspan="9" width="18" height="180"></td>
                    <td width="1" height="9"></td>
                </tr>
                <tr>
                    <td colspan="5" width="163" height="22">
                        <input id="T_uid" name="T_uid" type="text" style="width: 160px;" class="text" />
                    </td>
                    <td width="1" height="22"></td>
                </tr>
                <tr>
                    <td colspan="5" background="images/login_09.jpg" width="163" height="13"></td>
                    <td width="1" height="13"></td>
                </tr>
                <tr>
                    <td colspan="5" width="163" height="23">
                        <input id="T_pwd" name="T_pwd" type="password" style="width: 160px" class="text" /></td>
                    <td width="1" height="23"></td>
                </tr>
                <tr>
                    <td colspan="5" rowspan="2" width="163" height="14"></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td rowspan="8" width="234" height="145"></td>
                    <td rowspan="8" width="110" height="145"></td>
                    <td width="1" height="1"></td>
                </tr>
                <tr>
                    <td colspan="3" width="87" height="23">
                        <input id="T_validate" name="T_validte" type="text" style="width: 80px" class="text" /></td>
                    <td colspan="2" background="images/login_15.gif" width="76" height="23">
                        <img id="validate" onclick="this.src=this.src+'?'" src="ValidateCode.aspx" style="cursor: pointer; border: 1px solid #ddd" alt="�����������һ��" title="�����������һ��" />
                    </td>
                    <td width="1" height="23"></td>
                </tr>
                <tr>
                    <td colspan="5" width="163" height="47"></td>
                    <td width="1" height="47"></td>
                </tr>
                <tr>
                    <td colspan="5" width="163" height="29" class="auto-style1">v2.0</td>
                    <td width="1" height="29"></td>
                </tr>
                <tr>
                    <td colspan="5" background="images/login_18.gif" width="97" rowspan="3">
                        <input id="login" type="button" value="��¼" style="width: 80px; height: 28px;" /></td>
                    <td colspan="2" rowspan="3" background="images/login_19.gif" width="90" style="height: 60px">
                        <input id="reset" type="button" value="����" style="width: 80px; height: 28px;" /></td>
                    <td width="1" height="3"></td>
                </tr>
                <tr>
                    <td width="1" height="22"></td>
                </tr>
                <tr>
                    <td width="1" height="5"></td>
                </tr>
                <tr>
                    <td colspan="7" width="187" height="15"></td>
                    <td width="1" height="15"></td>
                </tr>
                <tr>
                    <td colspan="10" background="images/login_25.gif" width="731" height="108"></td>
                    <td width="1" height="108"></td>
                </tr>
                <tr>
                    <td width="234" height="1"></td>
                    <td width="200" height="1"></td>
                    <td width="6" height="1"></td>
                    <td width="4" height="1"></td>
                    <td width="51" height="1"></td>
                    <td width="32" height="1"></td>
                    <td width="4" height="1"></td>
                    <td width="72" height="1"></td>
                    <td width="18" height="1"></td>
                    <td width="110" height="1"></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>

</body>

</html>
