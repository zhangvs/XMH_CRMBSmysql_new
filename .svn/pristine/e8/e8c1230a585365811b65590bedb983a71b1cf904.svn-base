<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssn_article_add.aspx.cs" Inherits="SSN.SSN.article.ssn_article_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>资料添加</title>
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />

    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerForm.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerComboBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerRadio.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerSpinner.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTextBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDateEditor.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerCheckBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>

    <script src="../../lib/jquery-validation/jquery.validate.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/jquery.metadata.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/messages_cn.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/common.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTip.js" type="text/javascript"></script>
    <script src="../../lib/jquery.form.js" type="text/javascript"></script>

    <script src="../../JS/XHD.js" type="text/javascript"></script>

    <script type="text/javascript" charset="utf-8" src="../../ueditor1_2_5_1-utf8-net/editor_config.js"></script>
    <script src="../../ueditor1_2_5_1-utf8-net/editor_all.js" type="text/javascript"></script>
    <script src="../../ueditor1_2_5_1-utf8-net/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
    <link href="../../ueditor1_2_5_1-utf8-net/themes/default/css/ueditor.css" rel="stylesheet" />

    <script type="text/javascript">
        $(function () {
            $.metadata.setType("attr", "validate");
            XHD.validate($(form1));

            $("form").ligerForm();


            //UE.getEditor('editor', {
            //    initialFrameWidth: 600,
            //    insertunorderedlist: {
            //        'dot': ' 。 小圆圈'
            //    },
            //    //这里可以选择自己需要的工具按钮名称,此处仅选择如下五个
            //    toolbars: [['undo', 'redo', 'cleardoc', 'insertunorderedlist']],
            //    //focus时自动清空初始化时的内容
            //    autoClearinitialContent: true,
            //    //关闭elementPath
            //    elementPathEnabled: false
            //});



            //UE.getEditor('editor', {
            //    initialFrameWidth: 600,
            //    toolbars: [
            //      ['undo', 'redo', 'insertunorderedlist', 'cleardoc']
            //    ],
            //    autoHeightEnabled: false
            //});

            $("#T_title").attr("validate", "{ required: true, remote: remote, messages: { required: '请输入标题', remote: '该分类下该标题已存在!' } }");

            if (getparastr("nid")) {
                loadForm(getparastr("nid"));
                loadRole();
            }
            else {
                loadRole();
            }

            document.getElementById("iframegallery").src = '../../SSN/article/ssn_image.aspx';

        })

        function f_save() {
            var check = document.getElementsByName("rbtnl"), len = check.length, roleId = "";
            //判断存不存该条数据
            for (var i = 0; i < len; i++) {
                if (check[i].checked) {
                    roleId += check[i].value.toString() + ",";
                }
            }

            if ($(form1).valid()) {
                //var arr = [];
                //arr.push(UE.getEditor('editor').getContent());
                //var sendtxt = "&Action=save&nid=" + getparastr("nid") + "&art_Menu_Id=" + getparastr("Art_Menu_Id") + "&role_Id=" + roleId + "&T_content=" + escape(arr);
                var sendtxt = "&Action=save&nid=" + getparastr("nid") + "&art_Menu_Id=" + getparastr("Art_Menu_Id") + "&role_Id=" + roleId + "&T_content=" + $("#editor").val();
                sendtxt += "&images=" + gallery();
                return $("form :input").fieldSerialize() + sendtxt;
            }
        }

        function loadRole() {
            //查看所有角色
            $.ajax({
                type: "GET",
                url: "../../DataSSN/SSN_Article.ashx", /* 注意后面的名字对应CS的方法名称 */
                data: { Action: 'GetRole', rnd: Math.random() }, /* 注意参数的格式和名称 */
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    var obj = eval(result);
                    if (obj.Rows[0].id == -9999) {
                        return true;
                    }
                    var list = "";
                    for (var n = 0; n < obj.Rows.length; n++) {
                        if (obj[n] == "null" || obj[n] == null)
                            obj[n] = "";
                        var s = n + 1;
                        list += "<input id=\"rbtnl_" + s + "'\" type=\"checkbox\" name=\"rbtnl\" value=\"" + obj.Rows[n].RoleID + "\"/><label for=\"rbtnl_" + s + "\">" + obj.Rows[n].RoleName + "</label>&nbsp;";
                    }
                    $("#userRole").html(list);
                }
            });
        }

        function loadRoles() {
            //查看所有角色
            $.ajax({
                type: "GET",
                url: "../../DataSSN/SSN_Article.ashx", /* 注意后面的名字对应CS的方法名称 */
                data: { Action: 'GetRole', rnd: Math.random() }, /* 注意参数的格式和名称 */
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    var obj = eval(result);
                    if (obj.Rows[0].id == -9999) {
                        return true;
                    }
                    var list = "";
                    for (var n = 0; n < obj.Rows.length; n++) {
                        if (obj[n] == "null" || obj[n] == null)
                            obj[n] = "";
                        var s = n + 1;
                        list += "<input id=\"rbtnl_" + s + "'\" type=\"checkbox\" name=\"rbtnl\" value=\"" + obj.Rows[n].RoleID + "\" onclick=\"return false\"  /><label for=\"rbtnl_" + s + "\">" + obj.Rows[n].RoleName + "</label>&nbsp;";
                    }
                    $("#userRole").html(list);
                }
            });
        }

        function loadForm(oaid) {
            $.ajax({
                type: "GET",
                url: "../../DataSSN/SSN_Article.ashx", /* 注意后面的名字对应CS的方法名称 */
                data: { Action: 'form', nid: oaid, rnd: Math.random() }, /* 注意参数的格式和名称 */
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    var obj = eval(result);
                    for (var n in obj) {

                    }
                    $("#T_title").val(obj.Art_title);
                    $("#T_Order").val(obj.Art_order);
                    document.getElementById("iframegallery").src = '../../SSN/article/ssn_image.aspx?image_lst=' + obj.image_lst;

                    $.ajax({
                        type: "GET",
                        url: "../../DataSSN/SSN_Article.ashx", /* 注意后面的名字对应CS的方法名称 */
                        data: { Action: 'getRoleLiit', nid: oaid, rnd: Math.random() }, /* 注意参数的格式和名称 */
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (result) {
                            var obj = eval(result);
                            if (obj.Rows[0].id == -9999) {
                                return true;
                            }

                            var check = document.getElementsByName("rbtnl"), len = check.length;

                            for (var n = 0; n < obj.Rows.length; n++) {

                                for (var i = 0; i < len; i++) {
                                    if (check[i].value.toString() == obj.Rows[n].Role_id) {
                                        check[i].checked = true;
                                    }
                                }
                            }
                        }
                    });
                    $("#editor").val(removeHtml(obj.Art_Content));

                    //if ($.browser.msie) { //IE浏览器
                    //    UE.getEditor('editor').setContent(myHTMLDeCode(obj.Art_Content));
                    //}
                    //else if ($.browser.chrome) { //谷歌相关浏览器
                    //    UE.getEditor('editor').setContent(myHTMLDeCode(obj.Art_Content));
                    //}
                    //else {
                    //    UE.getEditor('editor').addListener("ready", function () {
                    //        UE.getEditor('editor').setContent(myHTMLDeCode(obj.Art_Content));
                    //    })
                    //}
                    //var isChrome = navigator.userAgent.toLowerCase().match(/chrome/) != null;
                    //if (isChrome) {
                    //    UE.getEditor('editor').setContent(myHTMLDeCode(obj.Art_Content));
                    //}
                }
            });
        }

        function upload(value) {
            //alert("不支持编辑图片");
            if (value == "") {
                return false
            }
            //保存前先上传图片//检测上传图片是否合法
            if (value) {
                var path = value;
                var filename = path.substr(path.lastIndexOf(".")).toLowerCase();//获得文件后缀名
                if (filename != ".jpg" && filename != ".jpeg" && filename != ".png" && filename != ".gif" && filename != ".bmp" && filename != ".pic") {
                    $.ligerDialog.warn("您选择的产品图片似乎有误，请认真检查是否是图片！");
                    return false;
                }
            }
            var photo = value;
            //$("#photourl").val(photo);

            $("#form1").ajaxSubmit({
                type: "post",
                url: "../../DataSSN/SSN_Article.ashx", /* 注意后面的名字对应CS的方法名称 */
                data: { Action: 'album', photo: photo, rnd: Math.random() }, /* 注意参数的格式和名称 */
                contentType: "application/json; charset=utf-8",
                async: false,
                dataType: "text",
                success: function (data) {
                    if (data) {
                        var frames = window.document.getElementById("iframegallery");
                        if (frames.contentWindow.updata(data, 'gggg', 'CompanyOrganization'))
                            $.ligerDialog.error("最多只能上传五张主图！");
                    }

                },
                error: function () {
                    $.ligerDialog.error("上传过程中出现错误！");
                }
            });

        }

        function gallery() {
            var frames = document.getElementById("iframegallery");
            return frames.contentWindow.save();
        }

        function remote() {
            var url = "../../DataSSN/SSN_Article.ashx?Action=validate&T_cid=" + getparastr("nid") + "&art_Menu_Id=" + getparastr("Art_Menu_Id") + "&rnd=" + Math.random();
            return url;
        }

        function removeHtml(Str) {
            if (Str == null || Str == "")
                return "";
            var i, j;
            Str = Str.replace("&nbsp;", " ");
            while (Str.indexOf("<") != -1 && Str.indexOf(">") != -1) {
                i = Str.indexOf("<");
                j = Str.indexOf(">") + 1;
                Str = Str.replace(Str.substring(i, j), "");
            }
            return Str;
        }
    </script>

</head>
<body style="overflow: hidden; margin: 0; padding: 0;">
    <form method="post" id="form1" runat="server" enctype="multipart/form-data">
        <div style="position: relative; z-index: 900; height: 680px; overflow-y: auto; margin-top: 8px;">
            <table style="width: 680px;">
                <tr>
                    <td style="width: 85px">
                        <div style="width: 80px; text-align: right;">标题：</div>
                    </td>
                    <td>
                        <input type="text" id="T_title" name="T_title" ltype="text" ligerui="{width:600}" validate="{required:true}" maxlength="80" /></td>
                </tr>
                <tr>
                    <td style="width: 85px">
                        <div style="width: 80px; text-align: right;">内容：</div>
                    </td>
                    <td>
                        <textarea id="editor" style="width: 595px; height: 350px"></textarea></td>
                </tr>
                <tr>
                    <td style="width: 85px">
                        <div style="width: 80px; text-align: right;">排序：</div>
                    </td>
                    <td>
                        <input type="text" id="T_Order" name="T_Order" ltype='spinner' ligerui="{type:'int',width:250}" value="0" /></td>
                </tr>
                <tr>
                    <td style="width: 85px">
                        <div style="width: 80px; text-align: right;">上传图片：</div>
                    </td>
                    <td>
                        <div class="field" style="text-align: left">
                            <input data-validate="regexp#.+.(jpg|jpeg|png|gif)$:只能上传jpg|gif|png格式文件" type="file" id="goods_img" name="file1" runat="server" onchange="upload(this.value)" />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td style="width: 85px">
                        <div style="width: 80px; text-align: right;">图片区：</div>
                    </td>
                    <td>
                        <iframe id="iframegallery" style="height: 100px; width: 100%"></iframe>
                    </td>
                </tr>

                <tr>
                    <td style="width: 85px">
                        <div style="width: 85px; text-align: right;">查看权限<input type="checkbox" id="SelectAll" value="全选" onclick="selectAll();" />
                            ：</div>
                    </td>
                    <td id="userRole" style="height: 90px; overflow-y: auto;"></td>
                </tr>
            </table>
        </div>
    </form>
</body>

</html>
<script type="text/javascript">
    function selectAll() {
        if ($("#SelectAll").attr("checked")) {
            $(":checkbox").attr("checked", true);
        } else {
            $(":checkbox").attr("checked", false);
        }
    }
</script>
