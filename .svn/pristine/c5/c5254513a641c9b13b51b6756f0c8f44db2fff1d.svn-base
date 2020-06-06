<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>排除评比设置</title>
    <meta http-equiv="X-UA-Compatible" content="IE=7" />
    <link href="../../CSS/core.css" rel="stylesheet" type="text/css" />
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/input.css" rel="stylesheet" />

    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerLayout.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerForm.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerCheckBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerComboBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDateEditor.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerRadio.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTextBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerSpinner.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTree.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDrag.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerResizable.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTip.js" type="text/javascript"></script>

    <script src="../../lib/jquery-validation/jquery.validate.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/jquery.metadata.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/messages_cn.js" type="text/javascript"></script>

    <script src="../../lib/jquery.form.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerToolBar.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>
    <script src="../../JS/add.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerMenu.js" type="text/javascript"></script>

    <style type="text/css">
        .dialog {
            font-size: 12px;
        }


        .dialog-height {
            height: 400px;
            overflow-y: auto;
            overflow-x: hidden;
        }

        .dialog-height2 {
            height: 300px;
            overflow-y: auto;
        }

        .dialog-height3 {
            height: 200px;
            overflow-y: scroll;
        }

        .dialog .dialog-body {
            padding: 15px 0px;
        }

        .dialog-body p {
            margin-top: 20px;
        }

        .dialog-body table th, .dialog-body table td {
            border: 1px solid #dcdcdc;
            height: 28px;
            line-height: 28px;
            text-align: center;
            font-weight: normal;
        }

        .dialog-ul {
            width: 100%;
            list-style: none;
            float: left;
            padding-left: 0px;
            margin-top: 13px;
        }

            .dialog-ul li {
                width: 50%;
                float: left;
                margin-top: 10px;
                position: relative;
            }

                .dialog-ul li span {
                    width: 105px;
                    padding-right: 5px;
                    text-align: right;
                    display: inline-block;
                    vertical-align: middle;
                }

                .dialog-ul li input {
                    height: 28px;
                    font-size: 12px;
                    vertical-align: middle;
                    position: relative;
                    line-height: 28px;
                    padding: 0px 3px;
                }

        .dialog-xz-ul li input[type="search"] {
            height: 26px;
            line-height: 26px;
            padding: 0px 3px;
        }

        .dialog-ul li select {
            height: 28px;
            width: 58%;
            font-size: 12px;
            border: solid 1px #ddd;
            border-radius: 4px;
        }

        .select_style {
            font-family: 'Microsoft YaHei';
            font-size: 14px;
            width: 50px;
            height: 30px;
            overflow: hidden;
            border: 1px solid #ccc;
            -moz-border-radius: 5px; /* Gecko browsers */
            -webkit-border-radius: 5px; /* Webkit browsers */
            border-radius: 5px;
        }

            .select_style select {
                padding: 5px;
                background: transparent;
                width: 48px;
                font-size: 16px;
                border: none;
                height: 30px;
                -webkit-appearance: none; /*for Webkit browsers*/
            }
    </style>

    <script type="text/javascript">
        var manager;

        $(function () {

            window['g'] =
            //创建项目列表
            $("#maingrid4").ligerGrid({
                checkbox: true,
                columns: [
                    { display: '序号', width: 50, render: function (rowData, rowindex, value, column, rowid, page, pagesize) { return (page - 1) * pagesize + rowindex + 1; } },
                    { display: '部门编号', name: 'exclude_did', width: 100, align: 'center' },
                    { display: '部门名称', name: 'exclude_dname', width: 100, align: 'center' },
                    { display: '员工编号', name: 'exclude_emp_code', width: 100, align: 'center' },
                    { display: '员工姓名', name: 'exclude_emp_name', width: 100, align: 'center' }
                ],

                dataAction: 'server',
                pageSize: 50, pageSizeOptions: [ 50, 100, 150],
                url: "../DMS_Set.ashx?Action=getSetExclude&rnd=" + Math.random(),
                width: '100%', height: '100%',
                heightDiff: -1,
                onRClickToSelect: true,
                onContextmenu: function (parm, e) {
                    actionCustomerID = parm.data.id;
                    menu.show({ top: e.pageY, left: e.pageX });
                    return false;
                }
            });

            $("#grid").height(document.documentElement.clientHeight - $(".toolbar").height());
            $('form').ligerForm();

            $("#toolbar").ligerToolBar({
                items: [
                    { type: 'textbox', id: 'tree0', text: '姓名：' },
                    { type: 'button', text: '排除评比', icon: '../../Images/Icon/92.png', disable: true, click: function () { edit(); } },
                    { type: 'button', text: '取消排除', icon: '../../Images/Icon/12.png', disable: true, click: function () { del(); } }

                ]
                //激活哪个
            });
            initSelect();

        });
        function initSelect() {
            $('#tree0').ligerComboBox({
                width: 250,
                selectBoxWidth: 250,
                selectBoxHeight: 600,
                valueField: 'id',
                textField: 'text',
                treeLeafOnly: true,
                tree: {
                    url: '../Reports_DMS.ashx?Action=getDeptPerson&rnd=' + Math.random(),
                    idFieldName: 'id',
                    checkbox: true
                }

            });
        }

        //新增
        function edit() {
            var tree0 = $("#tree0_val").val();
            if (tree0!='') {
                $.ajax({
                    url: "../DMS_Set.ashx?Action=addSetExclude&idlist=" + tree0 + "&rnd=" + Math.random(),
                    type: "POST",
                    success: function (responseText) {
                        if (responseText == 1) {
                            $.ligerDialog.success('排除评比成功！');
                            f_reload();
                        }
                        else {
                            $.ligerDialog.error('排除人员存在重复人员！');
                        }
                    },
                    error: function () {
                        $.ligerDialog.error('操作失败！');
                    }
                });
            }
            else {
                $.ligerDialog.error('请先选择人员！');
            }
        }


        //删除
        function del() {
            var manager = $("#maingrid4").ligerGetGridManager();
            var row = manager.getCheckedRows();
            var ids = idFormart(row);
            if (row.length > 0) {
                if (row) {
                    $.ligerDialog.confirm("确定要删除吗？", function (yes) {
                        if (yes) {
                            $.ajax({
                                url: "../DMS_Set.ashx", type: "POST",
                                data: { Action: "deleteSetExclude", id: ids, rnd: Math.random() },
                                success: function (responseText) {
                                    if (responseText == 4) {
                                        $.ligerDialog.success('取消排除成功！');
                                        f_reload();
                                    }
                                },
                                error: function () {
                                    $.ligerDialog.error('取消排除失败！');
                                }
                            });
                        }
                    });
                }
                else {
                    $.ligerDialog.warn("请选择记录");
                }
            }
            else {
                alert("请先选中数据!");
            }
        }

        function idFormart(data) {
            var idstr = "";
            $(data).each(function (i, val) {
                idstr += val.id;
                if (i == data.length - 1)
                    return;
                idstr += ",";
            });
            return idstr;
        }

        function f_reload() {
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.loadData(true);
        };


    </script>
</head>
<body>
    <form id="form1" onsubmit="return false">
        <div id="toolbar"></div>
        <div id="grid">
            <div id="maingrid4" style="margin: -1px; min-width: 800px;"></div>
        </div>
    </form>
</body>
</html>
