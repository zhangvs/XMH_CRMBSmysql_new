<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssn_image.aspx.cs" Inherits="SSN.SSN.article.ssn_image" %>

<!DOCTYPE html>

<html>

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <meta name="renderer" content="webkit">
    <title></title>

    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../lib/jquery.form.js" type="text/javascript"></script>

    <script src="../../lib/jquery-validation/jquery.validate.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/jquery.metadata.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>

    <script src="../../lib/ligerUI/js/plugins/ligerForm.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>

    <script type="text/javascript" charset="utf-8" src="../../ueditor1_2_5_1-utf8-net/editor_config.js"></script>
    <script src="../../ueditor1_2_5_1-utf8-net/editor_all.js" type="text/javascript"></script>
    <script src="../../ueditor1_2_5_1-utf8-net/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
    <link href="../../ueditor1_2_5_1-utf8-net/themes/default/css/ueditor.css" rel="stylesheet" />
    <style type="text/css">
        .input {
            border: 1px solid #6a706b;
            border-radius: 4px;
            box-shadow: 0 5px 1px rgba(0, 0, 0, 0.075) inset;
            display: block;
            font-size: 14px;
            height: 34px;
            line-height: 20px;
            padding: 6px;
            transition: all 1s cubic-bezier(0.175, 0.885, 0.32, 1) 0s;
            width: 100%;
        }

        .attac2 {
            list-style: none;
            margin: 0px;
            padding: 0px;
            margin-top: 10px; /*width:720px;margin-left:180px;*/
            float: left;
        }

            .attac2 li {
                padding: 0px;
                margin: 0px;
                margin-bottom: 3px;
                margin-right: 5px;
                float: left;
            }

        .photo {
            height: 65px;
            width: 90px;
        }
    </style>
    <script type="text/javascript">
        $(function () {
            $.metadata.setType("attr", "validate");
            XHD.validate($(form1));
            if (getparastr("image_lst")) {
                load(getparastr("image_lst"));
            }
        });

        //加载数据
        function loadForm(id) {
            $.ajax({
                type: "GET",
                url: "../../DataSSN/SSN_Article.ashx", /* 注意后面的名字对应CS的方法名称 */
                data: { Action: 'formGallery', goods_id: id, type: getparastr("type"), rnd: Math.random() }, /* 注意参数的格式和名称 */
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (result) {
                    var obj = eval(result);
                    for (var n = 0; n < obj.Rows.length; n++) {
                        //$("#attr_value" + obj.Rows[n].attr_id).val(obj.Rows[n].attr_value);
                        $("#CompanyOrganization").append("<li><img class='photo'  src='" + obj.Rows[n].file_ip + obj.Rows[n].img_original + "'></img><input class='hidden1' hidden='hidden' value='" + obj.Rows[n].img_original + "' /><a onclick='OnRemove(this)' style='float:right; padding-top:-350px'>X</a></li>")
                    }
                    //alert(obj.constructor); //String 构造函数
                },
                error: function () {
                    alert('未知错误，操作失败！');
                }
            });
        }

        function load(data) {
            var arr = data.split(",");
            for (i = 0; i < arr.length; i++) {
                if (arr[i] == "")
                    continue;
                $("#CompanyOrganization").append("<li><img class='photo'  src='../../" + arr[i] + "'></img><input class='hidden1' hidden='hidden' value='" + arr[i] + "' /><a onclick='OnRemove(this)' style='float:right; padding-top:-350px'>X</a></li>")
            }
        }

        function updata(data, op, did) {
            var cc = 0;
            if ($("#" + did + " li").length == 5) {
                return true;
            }
            $("#" + did).show();
            $("#" + did).append("<li><img class='photo'  src='../../" + data + "'></img><input class='hidden1' hidden='hidden' value='" + data + "' /><a onclick='OnRemove(this)' style='float:right; padding-top:-350px'>X</a></li>");
        }
        function save() {
            var strgallery = "";
            $(".hidden1").each(function (item, data) {
                strgallery += data.value + ",";
            });
            return strgallery;
        }

        function OnRemove(item) {
            $(item).parent("li").remove();
            $.ajax({
                type: "POST",
                url: "../../DataSSN/SSN_Article.ashx",
                data: { Action: 'remove', srcvalue: $(item).parent("li").children("input").attr("value") },
                success: function (e) {
                    if (e.success == true) {
                        $(item).parent("li").remove();
                    }
                }
            });
        }
    </script>

</head>

<body>

    <div class="admin-panel">
        <form method="post" id="form1" runat="server" enctype="multipart/form-data">
            <table>
                <%-- <tr>
                    <td>
                        <div class="panel-group"><strong style="float: left">添加照片</strong></div>
                    </td>
                </tr>--%>
                <%--<tr>
                    <td>
                        <div class="panel">
                            <div class="field" style="text-align: left">
                                <input type="text" class="input" style="width: 250px; float: left; margin-right: 5px" disabled="disabled" id="photourl" name="photourl" />
                                <a class="button input-file" href="javascript:void(0);" id="photoid" style="border-color: #388BFF;">添加
                                <input data-validate="regexp#.+.(jpg|jpeg|png|gif)$:只能上传jpg|gif|png格式文件" type="file" id="photo" name="photo" onchange="updata(this.value, 'gggg', 'CompanyOrganization');" />
                                </a>
                            </div>
                        </div>
                    </td>
                </tr>--%>
                <tr>
                    <td>
                        <div class="panel">
                            <ul id="CompanyOrganization" class="attac2">
                            </ul>
                        </div>
                    </td>
                </tr>
            </table>
            <%--<a onclick="save()">aaaaaaa</a>--%>
        </form>

    </div>
</body>

</html>
