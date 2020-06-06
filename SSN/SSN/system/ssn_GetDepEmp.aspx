<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ssn_GetDepEmp.aspx.cs" Inherits="SSN.SSN.system.ssn_GetDepEmp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/input.css" rel="stylesheet" type="text/css" />

    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTree.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerLayout.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDrag.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerComboBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTextBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerToolBar.js" type="text/javascript"></script>
    <script src="../../lib/jquery.form.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>

    <script type="text/javascript">

        var manager = "";
        var treemanager;
        var dataID = "";
        $(function () {
            $("#layout1").ligerLayout({ leftWidth: 160, allowLeftResize: false, allowLeftCollapse: true, space: 2 });
            $("#tree1").ligerTree({
                url: '../../datassn/ssn_base.ashx?Action=tree&rnd=' + Math.random(),
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
                    //{ display: 'ID', name: 'ID', type: 'int', width: 50 },
                    { display: '序号', width: 50, render: function (rowData, rowindex, value, column, rowid, page, pagesize) { return (page - 1) * pagesize + rowindex + 1; } },
                    { display: '名字', name: 'name' },
                    { display: '性别', name: 'sex', width: 50 },
                    { display: '部门', name: 'dname' },
                    { display: '职务', name: 'zhiwu' }
                ],
                checkbox: true,
                dataAction: 'server',
                pageSize: 30,
                pageSizeOptions: [20, 30, 50, 100],
                url: "../../DataSSN/SSN_Role_Emp.ashx?Action=emplist&role_id=" + getparastr("role_id"),
                width: '100%',
                height: '100%',
                //title: "员工列表",
                heightDiff: 0
            });
            toolbar();
            $(document).keydown(function (event) {
                if (event.keyCode == 13) { //绑定回车
                    doserch();
                }
            });
        });
        function toolbar() {
            var items = [];
            items.push({ type: 'button', text: '全部展开', icon: '../../images/folder-open.gif', disable: true, click: function () { treegridexpand(1); } })
            items.push({ type: 'button', text: '全部折叠', icon: '../../images/folder-closed.gif', disable: true, click: function () { treegridexpand(0); } })
            items.push({ type: 'textbox', id: 'stext', text: '姓名：' });
            items.push({ type: 'button', text: '搜索', icon: '../images/search.gif', disable: true, click: function () { doserch() } });


            $("#toolbar").ligerToolBar({
                items: items

            });

            $("#Serchtext").ligerTextBox({ width: 100 });
            $("#maingrid4").ligerGetGridManager().onResize();
        }

        function treegridexpand(status) {
            var manager = $("#tree1").ligerGetTreeManager();
            if (status == "0") {
                manager.collapseAll();
            } else {
                manager.expandAll();
            }

        }
        //运用递归找出所有子节点
        function selectNote(dateC) {
            var dateCId = "";
            var rows = dateC.children;
            if (!rows) return;
            $(rows).each(function (i) {
                dateCId = dateCId + "," + rows[i].id;
                if (rows[i].children != null) {
                    dateCId = dateCId + selectNote(rows[i]);
                }
            });
            return dateCId;
        }
        function f_select() {
            var manager = $("#maingrid4").ligerGetGridManager();
            var rows = manager.getCheckedRows();
            return rows;
        }
        function onSelect(note) {
            var dateC = note.data;
            dataID = dateC.id;
            if (dateC.children != null) {
                dataID = dataID + selectNote(dateC);
            }
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.showData({ Rows: [], Total: 0 });
            var url = "../../DataSSN/SSN_Role_Emp.ashx?Action=emplistDep&role_id=" + getparastr("role_id") + "&depid=" + dataID;
            manager.GetDataByURL(url);
        }

        //查询
        function doserch() {
            var sendtxt = "&Action=emplist&role_id=" + getparastr("role_id") + "&rnd=" + Math.random();
            var serchtxt = $("#form1 :input").fieldSerialize() + sendtxt;
            //alert(serchtxt);           
            var manager = $("#maingrid4").ligerGetGridManager();

            manager.setURL("../../DataSSN/SSN_Role_Emp.ashx?" + serchtxt);
            manager.loadData(true);
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
            <div position="left" title="组织架构">
                <div id="treediv" style="width: 200px; height: 100%; margin: -1px; float: left; border: 1px solid #ccc; overflow: auto;">
                    <ul id="tree1"></ul>
                </div>
            </div>
            <div position="center">
                <div style="position: absolute; z-index: 1000; width: 100%">
                    <div id="toolbar" style=" width:1800px"></div>
                </div>
                <div style="position: fixed; width: 100%; margin-top: 30px">
                    <div id="maingrid4" style="margin: -1px;"></div>
                </div>
            </div>
        </div>


        <!--<a class="l-button" onclick="getChecked()" style="float:left;margin-right:10px;">获取选择(复选框)</a> -->
        <div style="display: none">
            <!--  数据统计代码 -->
        </div>
    </form>
</body>
</html>
