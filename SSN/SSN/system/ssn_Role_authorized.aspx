﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssn_Role_authorized.aspx.cs" Inherits="SSN.SSN.system.ssn_Role_authorized" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/input.css" rel="stylesheet" type="text/css" />

    <script src="../../lib/ligerUI/js/plugins/ligerTree.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerLayout.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDrag.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>

    <script type="text/javascript">
        var manager = "";
        var treemanager;
        var manager1 = "";
        var note1 = null;
        var savetext1 = "";
        $(function () {
            $("#layout1").ligerLayout({ leftWidth: 150, allowLeftResize: false, allowLeftCollapse: true, space: 2 });
            $("#tree1").ligerTree({
                //url: '../data/Sys_Menu.ashx?Action=GetSysApp&rnd=' + Math.random(),
                url: '../../DataSSN/SSN_App.ashx?Action=GetAppList&rnd=' + Math.random(),
                onSelect: onSelect,
                idFieldName: 'id',
                usericon: 'App_icon',
                checkbox: false,
                itemopen: false,
                onSuccess: function () {
                    $(".l-first").click();
                }
            });

            treemanager = $("#tree1").ligerGetTreeManager();

            initLayout();
            $(window).resize(function () {
                initLayout();
            });

            $("#maingrid4").ligerGrid({
                columns: [
                    { display: '序号', width: 50, render: function (rowData, rowindex, value, column, rowid, page, pagesize) { return rowid + 1; } },
                    { display: '菜单名称', name: 'Menu_name', align: 'left', width: 250 },
                    {
                        display: '按钮权限', name: 'Menu_icon', align: 'left', width: 700, render: function (item) {
                            //var html = "<div style='vertical-align:middle;color: #FF0000;background:yellow'>";
                            var html = "<div style='vertical-align:middle;'>";
                            var returntxt = item.Sysroler;

                            var arrstr = new Array();
                            var arrstr1 = new Array();
                            var arrid = new Array();
                            var arrname = new Array();
                            arrstr = returntxt.split(",");

                            for (var j = 0; j < arrstr.length - 1; j++) {
                                arrstr1 = arrstr[j].split("|");
                                arrid = arrstr1[0];
                                arrname = arrstr1[1];
                                html += "<input type='checkbox' ";
                                html += "value='" + arrid + "' ";
                                html += " id='b" + arrid + "'";
                                html += ">";
                                html += arrname;
                                html += "&nbsp;&nbsp;";
                            }
                            html += "</div>";
                            return html;
                        }
                    }
                ],
                rowid: "Menu_id",
                onLoaded: f_setbtn,
                onCheckRow: f_onCheckRow,
                onCheckAllRow: f_onCheckAllRow,
                dataAction: 'server',
                pageSize: 30,
                pageSizeOptions: [20, 30, 50, 100],
                enabledEdit: true,
                checkbox: true,
                url: "1",
                width: '100%', height: '100%',
                usePager: false,
                tree: { columnName: 'Menu_name' },
                heightDiff: -3
            });

            manager = $("#maingrid4").ligerGetGridManager();
            manager.onResize();
            $("tbody> :checkbox").attr("checked", false);


        });

        function onSelect(note) {
            if (note1 != null && note1 != undefined) {
                var app = note1.data.id;

                manager1 = $("#maingrid4").ligerGetGridManager();
                var rows = manager1.getCheckedRows();
                var menu = "";
                $(rows).each(function () {
                    menu += "m" + this.Menu_id + ",";
                });

                var btn = "";
                $("input[type='checkbox']").each(function (i) {
                    if ($(this).attr("checked")) {
                        btn += $(this).attr("id") + ",";
                    }
                })


                var roleid = getparastr("Role_id");
                var factory_id = getparastr("Factory_Id");
                savetext1 = "{role_id:'" + roleid + "',";
                savetext1 += "factory_id:'" + factory_id + "',";
                savetext1 += "app:'" + app + "',";
                savetext1 += "menu:'" + menu + "',";
                savetext1 += "btn:'" + btn + "'}";
                saveUp(savetext1);
            }
            //加载数据
            manager = $("#maingrid4").ligerGetGridManager();
            manager.showData({ Rows: [], Total: 0 });
            var factory_id = getparastr("Factory_Id");
            var url = "../../DataSSN/SSN_Role.ashx?Action=treegrid&appid=" + note.data.id + '&factory_id=' + factory_id + '&rdm=' + Math.random();
            manager.GetDataByURL(url);
            //执行操作
            note1 = treemanager.getSelected();

        }
        function saveUp(savetext) {
            $.ajax({
                type: 'post',
                url: "../../DataSSN/SSN_Role.ashx?Action=saveauth&postdata=" + savetext + '&rdm=' + Math.random(),
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
            savetext += "app:'" + note.data.id + "'}";

            $.ajax({
                type: 'post',
                url: "../../DataSSN/SSN_Role.ashx?Action=getauth&postdata=" + savetext + '&rdm=' + Math.random(),
                success: function (data) {
                    //alert(data);   
                    var arrstr = new Array();
                    var arrmenu = new Array();
                    var arrbtn = new Array();
                    arrstr = data.split("|");

                    arrmenu = arrstr[0].split(",");
                    for (var i = 0; i < arrmenu.length; i++) {
                        if (arrmenu[i].length > 0) {
                            manager.setCheck(arrmenu[i].replace("m", ""));
                        }
                    }

                    if (arrstr[1])
                        arrbtn = arrstr[1].split(",");
                    for (var j = 0; j < arrbtn.length; j++) {
                        if (arrbtn[j].length > 0) {
                            $("#" + arrbtn[j]).attr("checked", true);
                        }
                    }
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    //f_error("角色还未授权！");
                }
            });
        }

        function f_save() {
            var notes = treemanager.getSelected();
            if (notes != null && notes != undefined) {
                var app = notes.data.id;

                var manager = $("#maingrid4").ligerGetGridManager();
                var rows = manager.getCheckedRows();
                var menu = "";
                $(rows).each(function () {
                    menu += "m" + this.Menu_id + ",";
                });

                var btn = "";
                $("input[type='checkbox']").each(function (i) {
                    if ($(this).attr("checked")) {
                        btn += $(this).attr("id") + ",";
                    }
                })


                var roleid = getparastr("Role_id");
                var factory_id = getparastr("Factory_Id");
                var savetext = "{role_id:'" + roleid + "',";
                savetext += "factory_id:'" + factory_id + "',";
                savetext += "app:'" + app + "',";
                savetext += "menu:'" + menu + "',";
                savetext += "btn:'" + btn + "'}";

                //alert(savetext);

                f_saving();
                $.ajax({
                    type: 'post',
                    url: "../../DataSSN/SSN_Role.ashx?Action=saveauth&postdata=" + savetext + '&rdm=' + Math.random(),
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
        function EditMenu() {
            $(":checkbox").attr("checked", true);
        }
        function DeleteMenu() {
            $(":checkbox").attr("checked", false);
            $("#_38").attr("checked", true);
        }
        function gridreload(Appid) {
            manager = $("#maingrid4").ligerGetGridManager();
            manager.showData({ Rows: [], Total: 0 });
            //alert('onSelect:' + note.data.id);
            var url = "../data/Sys_Menu_data.aspx?action=treegrid&appid=" + Appid;
            manager.GetDataByURL(url);
        };

        function f_onCheckRow(checked, data) {
            var returntxt = data.Sysroler;
            var arrstr = new Array();
            var arrstr1 = new Array();
            var arrid = new Array();
            var arrname = new Array();
            arrstr = returntxt.split(",");

            if (checked) {
                for (var j = 0; j < arrstr.length; j++) {
                    arrstr1 = arrstr[j].split("|");
                    arrid = arrstr1[0];
                    $("#b" + arrid).attr("checked", true);
                }
                //parent
                var manager = $("#maingrid4").ligerGetGridManager();

                if (manager.isLeaf(data) && !manager.hasChildren(data)) {
                    var row = manager.getParent(data);
                    if (row) manager.setCheck(row.Menu_id);
                }
                    //将isLeaf改为hasChildren
                    //else if (!manager.hasChildren(data)) {
                    //var row = manager.getParent(data);
                    //if (row) manager.setCheck(row.Menu_id);
                    // }
                else {
                    var rows = data.children;
                    if (!rows) return;
                    $(rows).each(function (i, item) {
                        manager.setCheck(rows[i].Menu_id);
                        var returntxt = item.Sysroler;
                        var arrstr = new Array();
                        var arrstr1 = new Array();
                        var arrid = new Array();
                        var arrname = new Array();
                        arrstr = returntxt.split(",");


                        for (var j = 0; j < arrstr.length; j++) {
                            arrstr1 = arrstr[j].split("|");
                            arrid = arrstr1[0];
                            if (checked) {
                                $("#b" + arrid).attr("checked", true);
                            }
                            else {
                                $("#b" + arrid).attr("checked", false);
                            }
                        }
                    })
                }
            }
            else {
                for (var j = 0; j < arrstr.length; j++) {
                    arrstr1 = arrstr[j].split("|");
                    arrid = arrstr1[0];
                    $("#b" + arrid).attr("checked", false);
                }
                //children
                var manager = $("#maingrid4").ligerGetGridManager();
                //将isLeaf改为hasChildren
                if (manager.hasChildren(data) || !manager.isLeaf(data)) {
                    var rows = data.children;
                    //$(rows).each(function (i) {
                    //    manager.setUnCheck(rows[i].Menu_id);
                    //})
                    //改为以下代码
                    $(rows).each(function (i, item) {
                        manager.setUnCheck(rows[i].Menu_id);
                        var returntxt = item.Sysroler;
                        var arrstr = new Array();
                        var arrstr1 = new Array();
                        var arrid = new Array();
                        var arrname = new Array();
                        arrstr = returntxt.split(",");


                        for (var j = 0; j < arrstr.length; j++) {
                            arrstr1 = arrstr[j].split("|");
                            arrid = arrstr1[0];
                            if (checked) {
                                $("#b" + arrid).attr("checked", true);
                            }
                            else {
                                $("#b" + arrid).attr("checked", false);
                            }
                        }
                    })
                }
            }


        }
        function f_onCheckAllRow(checked, grid) {
            var manager = $("#maingrid4").ligerGetGridManager();
            var rows = manager.getAllRows();
            if (rows.length > 0) {
                $(rows).each(function (i, item) {
                    //alert(i+";"+item.Sysroler)
                    var returntxt = item.Sysroler;
                    var arrstr = new Array();
                    var arrstr1 = new Array();
                    var arrid = new Array();
                    var arrname = new Array();
                    arrstr = returntxt.split(",");


                    for (var j = 0; j < arrstr.length; j++) {
                        arrstr1 = arrstr[j].split("|");
                        arrid = arrstr1[0];
                        if (checked) {
                            $("#b" + arrid).attr("checked", true);
                        }
                        else {
                            $("#b" + arrid).attr("checked", false);
                        }
                    }

                })
            }
        }
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
        function f_error(message) {
            $(document).ready(function () {
                $.ligerDialog.error(message);
                $.ligerDialog.closeWaitting();
            });
        }
        function f_saving() {
            $.ligerDialog.waitting("正在保存中...");
        }

    </script>

</head>
<body style="padding: 0px; overflow: hidden;">
    <div id="layout1" style="margin: -1px;">
        <div position="left" title="系统目录">
            <div id="treediv1" style="width: 250px; height: 100%; margin: -1px; float: left; border: 1px solid #ccc; overflow: auto;">
                <ul id="tree1"></ul>
            </div>
        </div>
        <div position="center">
            <div class="title">按键</div>

            <div id="maingrid4" style="margin: -1px;"></div>
        </div>
    </div>
</body>
</html>
