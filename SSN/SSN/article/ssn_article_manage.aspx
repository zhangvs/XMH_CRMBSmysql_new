
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssn_article_manage.aspx.cs" Inherits="SSN.SSN.article.ssn_article_manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
        $(function () {
            $("#layout1").ligerLayout({ leftWidth: 200, allowLeftResize: false, allowLeftCollapse: true, space: 2, heightDiff: -1 });
            $("#tree1").ligerTree({
                url: '../../DataSSN/SSN_Article.ashx?Action=tree&companyid=0&rnd=' + Math.random(),
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

            $("#maingrid4").ligerGrid({
                columns: [
                   { display: '序号', width: 50, render: function (rowData, rowindex, value, column, rowid, page, pagesize) { return (page - 1) * pagesize + rowindex + 1; } },
                    { display: '标题', name: 'Art_title', width: 320, align: 'left' },
                    { display: '添加人', name: 'Creater_Name', width: 120 },
                    {
                         display: '创建时间', name: 'Create_Date', width: 120, render: function (item) {
                             var Create_date = formatTimebytype(item.Create_Date, 'yyyy-MM-dd');
                             return Create_date;
                         }
                    }
                ],
                dataAction: 'server',
                pageSize: 30,
                pageSizeOptions: [20, 30, 50, 100],
                onSelectRow: function (row, index, data) {
                    //alert('onSelectRow:' + index + " | " + data.ProductName); 
                },
                url: "../../DataSSN/SSN_Article.ashx?Action=grid&Art_Menu_Id=0",
                width: '100%',
                height: '100%',
                heightDiff: -1,
                onRClickToSelect: true,
                onContextmenu: function (parm, e) {
                    actionCustomerID = parm.data.id;
                    menu.show({ top: e.pageY, left: e.pageX });
                    return false;
                }
            });
            toolbar();
        });

        function toolbar() {
            $.getJSON("../../DataSSN/SSN_Toolbar.ashx?Action=GetSys&mid=9&rnd=" + Math.random(), function (data, textStatus) {
                //alert(data);
                var items = [];
                var arr = data.Items;
                for (var i = 0; i < arr.length; i++) {
                    arr[i].icon = "../../" + arr[i].icon;
                    items.push(arr[i]);
                }

                //items.push({ type: 'button', text: '全部展开', icon: '../images/folder-open.gif', disable: true, click: function () { treegridexpand(1); } })
                //items.push({ type: 'button', text: '全部折叠', icon: '../images/folder-closed.gif', disable: true, click: function () { treegridexpand(0); } })

                $("#toolbar").ligerToolBar({
                    items: items

                });
                menu = $.ligerMenu({
                    width: 120, items: getMenuItems(data)
                });

                $("#maingrid4").ligerGetGridManager().onResize();
            });
        }

        function treegridexpand(status) {
            var manager = $("#tree1").ligerGetTreeManager();
            if (status == "0") {
                manager.collapseAll();
            } else {
                manager.expandAll();
            }

        }

        function onSelect(note) {
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.showData({ Rows: [], Total: 0 });
            var url = "../../DataSSN/SSN_Article.ashx?Action=grid&Art_Menu_Id=" + note.data.id + "&rnd=" + Math.random();
            manager.GetDataByURL(url);
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
                ], isResize: true, showToggle: true, timeParmName: 'a'
            };
            activeDialog = parent.jQuery.ligerDialog.open(dialogOptions);
        }


        function add() {
            var notes = $("#tree1").ligerGetTreeManager().getSelected();           
            if (notes != null && notes != undefined) {           
                $.ajax({
                    type: "GET",
                    url: "../../DataSSN/SSN_Menu.ashx", /* 注意后面的名字对应CS的方法名称 */
                    data: { Action: 'form', menuid: notes.data.id, rnd: Math.random() }, /* 注意参数的格式和名称 */
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (result) {
                        var obj = eval(result);
                        for (var n in obj) {

                        }

                        if (obj.parentid != 0) {
                            f_openWindow('SSN/article/ssn_article_add.aspx?Art_Menu_Id=' + notes.data.id, "新增", 742, 700);
                        }
                        else {
                            $.ligerDialog.warn('一级菜单不能添加！');
                        }
                    }
                });              
            }
            else {
                $.ligerDialog.warn('请选择流程！');
            }
        }

        function edit() {
            var notes = $("#tree1").ligerGetTreeManager().getSelected();
            var manager = $("#maingrid4").ligerGetGridManager();
            var rows = manager.getSelectedRow();
            if (notes != null && notes != undefined) {
                if (rows && rows != undefined) {
                    f_openWindow('SSN/article/ssn_article_add.aspx?Art_Menu_Id=' + notes.data.id + '&nid=' + rows.Id, "修改", 742, 680);
                }
                else {
                    $.ligerDialog.warn('请选择资料！');
                }
            }
            else {
                $.ligerDialog.warn('请选择流程！');
            }
        }

        function del() {
            var manager = $("#maingrid4").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (row) {
                $.ligerDialog.confirm("确定要删除？", function (yes) {
                    if (yes) {
                        $.ajax({
                            url: "../../DataSSN/SSN_Article.ashx", type: "POST",
                            data: { Action: "del", id: row.Id, rnd: Math.random() },
                            success: function (responseText) {
                                top.$.ligerDialog.closeWaitting();
                                if (responseText == "true") {
                                    f_load();
                                    top.$.ligerDialog.success('删除成功!');
                                }
                                else {
                                    top.$.ligerDialog.error('删除失败!未知错误。');
                                }
                            },
                            error: function () {
                                top.$.ligerDialog.closeWaitting();
                                top.$.ligerDialog.error('删除失败！');
                            }
                        });
                    }
                })
            }
            else {
                $.ligerDialog.warn('请选择流程！');
            }
        }

        function f_save(item, dialog) {
            var issave = dialog.frame.f_save();
            if (issave) {
                dialog.close();
                top.$.ligerDialog.waitting('数据保存中,请稍候...');
                $.ajax({
                    url: "../../DataSSN/SSN_Article.ashx", type: "POST",
                    data: issave,
                    success: function (responseText) {
                        switch (responseText) {
                            case "1":
                                top.$.ligerDialog.success('添加成功！');
                                break;
                            case "0":
                                top.$.ligerDialog.success('添加失败！');
                                break;
                            case "2":
                                top.$.ligerDialog.success('修改成功！');
                                break;
                            case "3":
                                top.$.ligerDialog.success('修改失败！');
                                break;
                            default:
                                break;
                        }

                        top.$.ligerDialog.closeWaitting();
                        f_load();

                    },
                    error: function () {
                        top.$.ligerDialog.closeWaitting();
                        top.$.ligerDialog.error('操作失败！');
                    }
                });

            }
        }

        function f_load() {
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.loadData(true);
        }

    </script>
</head>
<body style="padding: 0px">
    <form id="form1" onsubmit="return false">
        <div id="layout1" style="margin: -1px">
            <div position="left" title="标准流程">
                <div id="treediv" style="width: 250px; height: 100%; margin: -1px; float: left; border: 1px solid #ccc; overflow: auto;">
                    <ul id="tree1"></ul>
                </div>
            </div>
            <div position="center">
                <div id="toolbar" style="width: 1800px"></div>
                <div id="maingrid4" style="margin: -1px;"></div>

            </div>
        </div>
    </form>
</body>
</html>
