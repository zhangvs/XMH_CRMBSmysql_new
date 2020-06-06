<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssn_role_view.aspx.cs" Inherits="SSN.SSN.system.ssn_role_view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-fix.css" rel="stylesheet" />
    <link href="../../CSS/input.css" rel="stylesheet" type="text/css" />
    <script src="../../lib/ligerUI/js/plugins/ligerTree.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerLayout.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDrag.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerComboBox.js"></script>
    <script src="../../JS/Toolbar.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerToolBar.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerMenu.js" type="text/javascript"></script>
    <script type="text/javascript">

        var manager = "";
        var treemanager;
        var note1 = null;
        $(function () {
            $("#layout1").ligerLayout({ leftWidth: 200, allowLeftResize: false, allowLeftCollapse: true, space: 2, heightDiff: -1 });
            $("#tree1").ligerTree({
                url: '../../DataSSN/SSN_Role.ashx?Action=menuList&appid=1&rnd=' + Math.random(),
                onSelect: onSelect,
                idFieldName: 'id',
                usericon: 'd_icon',
                checkbox: false,
                itemopen: false
            });

            treemanager = $("#tree1").ligerGetTreeManager();

            initLayout();
            $(window).resize(function () {
                initLayout();
            });
            treemanager = $("#tree1").ligerGetTreeManager();

            $("#maingrid4").ligerGrid({
                columns: [
                    //{ display: 'ID', name: 'post_id', type: 'int', width: 50 },
                   { display: '序号', width: 50, render: function (rowData, rowindex, value, column, rowid, page, pagesize) { return (page - 1) * pagesize + rowindex + 1; } },
                    { display: '文章标题', name: 'Art_title', width: 200, align: "left" },
                    { display: '发布人', name: 'Creater_Name', width: 120, align: "left" },
                    {
                        display: '发布时间', name: 'Create_Date', width: 150, align: "left", render: function (item) {
                            var Create_Date = formatTimebytype(item.Create_Date, 'yyyy-MM-dd hh:mm:ss');
                            return Create_Date;
                        }
                    }
                ],
                checkbox: true,
                rowid: "Id",
                dataAction: 'server',
                usePager: false,
                pageSize: 30,
                onLoaded: f_setbtn,
                pageSizeOptions: [20, 30, 50, 100],
                onSelectRow: function (row, index, data) {
                    //alert('onSelectRow:' + index + " | " + data.ProductName); 
                },
                url: "../../DataSSN/SSN_Role.ashx?Action=viewgrid",
                width: '100%',
                height: '100%',
                heightDiff: -1
            });
            //toolbar();
        });

        function onSelect(note) {
            if (note1 != null && note1 != undefined) {
                var app = '1';
                var menu = note1.data.Menu_id;

                manager1 = $("#maingrid4").ligerGetGridManager();
                var rows = manager1.getCheckedRows();
                var art = "";
                $(rows).each(function () {
                    art += "a" + this.Id + ",";
                });

                var roleid = getparastr("Role_id");
                var savetext1 = "{role_id:'" + roleid + "',";
                savetext1 += "app:'" + app + "',";
                savetext1 += "menu:'" + menu + "',";
                savetext1 += "art:'" + art + "'}";
                saveUp(savetext1);
            }
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.showData({ Rows: [], Total: 0 });
            var url = "../../DataSSN/SSN_Role.ashx?Action=viewgrid&menuid=" + note.data.Menu_id + "&rnd=" + Math.random();
            manager.GetDataByURL(url);
            //执行操作
            note1 = treemanager.getSelected();
        }
        //切换菜单后保存上一页
        function saveUp(savetext) {
            $.ajax({
                type: 'post',
                async: false,
                url: "../../DataSSN/SSN_Role.ashx?Action=saveview&postdata=" + savetext + '&rdm=' + Math.random(),
                success: function (data) {
                    if (data != "{sucess:sucess}") {
                        alert(data);
                        f_error("授权失败！");
                    } else {
                        setTimeout(function () {
                        }, 10);
                    }

                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    f_error("授权失败！");
                }
            });
        }
        function f_setbtn() {
            manager = $("#maingrid4").ligerGetGridManager();
            manager.gridloading.hide();
            var note = treemanager.getSelected();
            if (!note) return;

            //获取权限
            var roleid = getparastr("Role_id");
            var savetext = "{role_id:'" + roleid + "',";
            savetext += "menu:'" + note.data.Menu_id + "'}";

            $.ajax({
                type: 'post',
                url: "../../DataSSN/SSN_Role.ashx?Action=getview&postdata=" + savetext + '&rdm=' + Math.random(),
                success: function (data) {
                    var arrstr = new Array();
                    arrstr = data.split(",");

                    for (var i = 0; i < arrstr.length; i++) {
                        if (arrstr[i].length > 0) {
                            manager.setCheck(arrstr[i].replace("a", ""));
                        }
                    }
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    //f_error("角色还未授权！");
                }
            });
        }
        //点击保存时
        function f_save() {
            var notes = treemanager.getSelected();
            if (notes != null && notes != undefined) {
                var app = '1';
                var menu = note1.data.Menu_id;

                manager1 = $("#maingrid4").ligerGetGridManager();
                var rows = manager1.getCheckedRows();
                var art = "";
                $(rows).each(function () {
                    art += "a" + this.Id + ",";
                });

                var roleid = getparastr("Role_id");
                var savetext = "{role_id:'" + roleid + "',";
                savetext += "app:'" + app + "',";
                savetext += "menu:'" + menu + "',";
                savetext += "art:'" + art + "'}";

                //alert(savetext);

                f_saving();
                $.ajax({
                    type: 'post',
                    url: "../../DataSSN/SSN_Role.ashx?Action=saveview&postdata=" + savetext + '&rdm=' + Math.random(),
                    success: function (data) {
                        if (data != "{sucess:sucess}") {
                            alert(data);
                            f_error("授权失败！");
                        } else {
                            setTimeout(function () {
                                f_success();
                            }, 10);
                        }

                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        f_error("授权失败！");
                    }
                });
            }
            else {
                f_error("请选择模块！");
            }

        }

        function f_load() {
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.loadData(true);
        }
        //成功后执行
        function f_success() {
            setTimeout(function () {
                $.ligerDialog.confirm("是否继续编辑", "保存成功", function (ok) {
                    $.ligerDialog.closeWaitting();
                    if (!ok) {
                        parent.$.ligerDialog.close();
                    }
                });
            }, 200);
        }
        //失败后执行
        function f_error(message) {
            $(document).ready(function () {
                $.ligerDialog.error(message);
                $.ligerDialog.closeWaitting();
            });
        }
        //显示保存中
        function f_saving() {
            $.ligerDialog.waitting("正在保存中...");
        }

    </script>
</head>
<body style="padding: 0px">
    <form id="form1" onsubmit="return false">
        <div id="layout1" style="margin: -1px">
            <div position="left" title="流程架构">
                <div id="treediv" style="width: 250px; height: 100%; margin: -1px; float: left; border: 1px solid #ccc; overflow: auto;">
                    <ul id="tree1"></ul>
                </div>
            </div>
            <div position="center">
                <div id="toolbar" style="width: 1800px"></div>
                <div id="maingrid4" style="margin: -1px;"></div>

            </div>
        </div>


        <!--<a class="l-button" onclick="getChecked()" style="float:left;margin-right:10px;">获取选择(复选框)</a> -->
        <div style="display: none">
            <!--  数据统计代码 -->
        </div>
    </form>
</body>
</html>
