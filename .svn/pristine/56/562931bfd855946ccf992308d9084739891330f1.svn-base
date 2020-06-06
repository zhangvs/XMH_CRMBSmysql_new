<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssn_menu_manage.aspx.cs" Inherits="SSN.SSN.system.ssn_menu_manage" %>

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
    <script src="../../lib/ligerUI/js/plugins/ligerToolBar.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerMenu.js" type="text/javascript"></script>

    <script type="text/javascript">

        var manager = "";
        var treemanager;
        $(function () {
            $("#layout1").ligerLayout({ leftWidth: 150, allowLeftResize: false, allowLeftCollapse: true, space: 2 });

            initLayout();
            $(window).resize(function () {
                initLayout();
            });

            toolbar();

            $("#maingrid").ligerGrid({
                columns: [
                    { display: 'ID', name: 'Menu_id', type: 'int', width: 50 },
                    { display: '菜单名', name: 'Menu_name', align: 'left', width: 300 },
                    { display: '链接地址', name: 'Menu_url', align: 'left', width: 300 },
                    {
                        display: '图标', name: 'Menu_icon', width: 50, render: function (item) {
                            return "<img style='width:16px;height:16px;margin-top:4px;' src='../../" + item.Menu_icon + "'/>"
                        }
                    },
                    //{ display: '响应事件', name: 'Menu_handler' },
                    { display: '排序', name: 'Menu_order', width: 50 }

                ],
                dataAction: 'server',
                pageSize: 30,
                pageSizeOptions: [20, 30, 50, 100],
                usePager: false,
                tree: { columnName: 'Menu_name' },
                url: "../../DataSSN/SSN_Menu.ashx?Action=GetMenu&appid=1",
                onContextmenu: function (parm, e) {
                    actionCustomerID = parm.data.id;
                    menu.show({ top: e.pageY, left: e.pageX });
                    return false;
                },
                width: '100%',
                height: '98%',
                heightDiff: 1,
                onRClickToSelect: true,
                onContextmenu: function (parm, e) {
                    actionCustomerID = parm.data.id;
                    menu.show({ top: e.pageY, left: e.pageX });
                    return false;
                }
            });

        });
        function toolbar() {
            $.getJSON("../../DataSSN/SSN_Toolbar.ashx?Action=GetSys&mid=10&rnd=" + Math.random(), function (data, textStatus) {
                var items = [];
                var arr = data.Items;
                for (var i = 0; i < 3; i++) {
                    arr[i].icon = "../../" + arr[i].icon;
                    items.push(arr[i]);
                }

                $("#toolbar").ligerToolBar({
                    items: items

                });
                menu = $.ligerMenu({
                    width: 120, items: getMenuItems(data)
                });

                $("#maingrid").ligerGetGridManager().onResize();
            });
        }

        var activeDialog = null;
        function f_openWindow(url, title, width, height) {
            var dialogOptions = {
                width: width, height: height, title: title, url: url, buttons: [
                        {
                            text: '保存', onclick: function (item, dialog) {
                                f_save(item, dialog);
                            }
                        },
                        {
                            text: '关闭', onclick: function (item, dialog) {
                                dialog.close();
                            }
                        }
                ], isResize: true, timeParmName: 'a'
            };
            activeDialog = parent.jQuery.ligerDialog.open(dialogOptions);
        }


        function edit() {
            var row = $("#maingrid").ligerGetGridManager().getSelectedRow();
            if (row != null && row != 'undefine') {
                f_openWindow('../../SSN/System/ssn_Menu_add.aspx?menuid=' + row.Menu_id + '&appid=1&parentid=' + row.parentid, "修改目录", 450, 300);
            }
            else {
                $.ligerDialog.warn('请选择目录！');
            }
        }

        function add() {
            f_openWindow('../../SSN/System/ssn_Menu_add.aspx?appid=1', "新增目录", 450, 300);
        }

        function del() {
            var manager = $("#maingrid").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (row) {
                $.ligerDialog.confirm("删除后不能恢复，\n您确定要删除？", function (yes) {
                    if (yes) {
                        $.ajax({
                            type: "POST",
                            url: "../../DataSSN/SSN_Menu.ashx",
                            data: { Action: 'del', type: "bef", menuid: row.Menu_id },
                            success: function (result) {
                                if (result == '1') {
                                    $.ligerDialog.warn("此目录下存在文章，不允许删除！");
                                } else if (result == '2') {
                                    $.ligerDialog.success("操作成功！");
                                }
                                treereload();
                            }
                        });
                    }
                })
            } else {
                $.ligerDialog.warn("请选择行");
            }
        }

        function f_save(item, dialog) {
            var issave = dialog.frame.f_save();
            if (issave) {
                dialog.close();
                top.$.ligerDialog.waitting('数据保存中,请稍候...');
                $.ajax({
                    url: "../../DataSSN/SSN_Menu.ashx", type: "POST",
                    data: issave,
                    success: function (responseText) {
                        top.$.ligerDialog.closeWaitting();
                        treereload();

                    },
                    error: function () {
                        top.$.ligerDialog.closeWaitting();
                        top.$.ligerDialog.error('操作失败！');
                    }
                });

            }
        }

        function treereload() {
            var manager = $("#maingrid").ligerGetGridManager();
            manager.loadData(true);
            var manager1 = $("#maingrid1").ligerGetGridManager();
            manager1.loadData(true);
        }
    </script>
</head>
<body style="padding: 0px">
    <form id="form1" onsubmit="return false">

        <div id="layout1" style="margin-top: -1px; margin-left: -1px">
            <div position="center" title="">
                <div id="toolbar" style="width: 1800px"></div>
                <div id="maingrid" style="margin-top: -1px; margin-left: -1px"></div>
            </div>
        </div>
    </form>
</body>
</html>
