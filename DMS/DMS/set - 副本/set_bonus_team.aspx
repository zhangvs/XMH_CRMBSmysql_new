<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>团队达标奖励设置</title>
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
        var manager1;
        $(function () {
            initLayout();
            $(window).resize(function () {
                initLayout();
            });
            $(document).keydown(function (event) {
                if (event.keyCode == 13) { //绑定回车
                    doserch();
                }
            });

            window['g'] =
            //创建项目列表
            $("#maingrid4").ligerGrid({
                columns: [
                    { display: '序号', width: 50, render: function (rowData, rowindex, value, column, rowid, page, pagesize) { return (page - 1) * pagesize + rowindex + 1; } },
                    { display: '部门', name: 'd_name', width: 100, align: 'center' },
                    { display: '达标100%', name: 'db_100', width: 100, align: 'right' },
                    { display: '达标90%', name: 'db_90', width: 100, align: 'right' },
                ],

                dataAction: 'server',
                pageSize: 31, pageSizeOptions: [ 31, 62, 93],
                url: "../DMS_Set.ashx?Action=getSetBonusTeam&rnd=" + Math.random(),
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
                    { type: 'textbox', id: 'tree0', text: '部门：' },
                    { type: 'button', text: '新增', icon: '../../Images/Icon/11.png', disable: true, click: function () { add(); } },
                    { type: 'button', text: '修改', icon: '../../Images/Icon/33.png', disable: true, click: function () { edit(); } },
                    { type: 'button', text: '删除', icon: '../../Images/Icon/12.png', disable: true, click: function () { del(); } }

                ]
                //激活哪个
            });
            initSelect();
        });
        function initSelect() {
            $('#tree0').ligerComboBox({
                width: 200,
                selectBoxWidth: 200,
                selectBoxHeight: 350,
                valueField: 'id',
                textField: 'text',
                treeLeafOnly: true,
                tree: {
                    url: '../Reports_DMS.ashx?Action=getDep&rnd=' + Math.random(),
                    idFieldName: 'id',
                    checkbox: true
                }

            });
        }

        function clearTxt() {
            $("#id").val('');
            $("input[name='db_100']").val('');
            $("input[name='db_90']").val('');
        }
        //新增
        function add() {
            clearTxt();
            var tree0v = $("#tree0").ligerComboBox().selectedValue;
            if (tree0v==undefined) {
                $.ligerDialog.error('没选择部门！');
                return;
            }
            if (tree0v.indexOf(';') > 0) {
                $.ligerDialog.error('选择了多个部门！');
                return;
            }
            var tree0 = $("#tree0").ligerComboBox().selectedText;

            $("#d_id").val(tree0v);
            $("#d_name").val(tree0);

            $("#d_name_span").html(tree0);

            show();
        }

        //编辑
        function edit() {
            clearTxt();
            var manager = $("#maingrid4").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (row) {
                $("#id").val(row.id);
                $("#d_id").val(row.d_id);
                $("#d_name").val(row.d_name);

                $("#d_name_span").html(row.d_name);
                $("input[name='db_100']").val(row.db_100);
                $("input[name='db_90']").val(row.db_90);
                show();
            }
            else {
                $.ligerDialog.warn('请选择行！');
            }

        }


        //保存
        function Confirm() {
            var id = $("#id").val();
            var sendtxt = '';
            if (id != '') {
                sendtxt = "&Action=updateBonusTeam";
            }
            else {
                sendtxt = "&Action=addBonusTeam";
            }

            sendtxt=sendtxt+'&'+$("form :input").fieldSerialize() ;
            $.ajax({
                url: "../DMS_Set.ashx?" + sendtxt,
                type: "POST",
                beforesend: function () {
                    $.ligerDialog.waitting('数据保存中,请稍候...');
                },
                success: function (responseText) {
                    if (responseText == 1) {
                        $.ligerDialog.success('添加成功！');
                        f_reload();
                        closeDivs();
                    }
                    else if (responseText == 0) {
                        $.ligerDialog.error('已存在此计划！');
                        f_reload();
                        closeDivs();
                    }
                    else if (responseText == 2) {
                        $.ligerDialog.success('修改成功！');
                        f_reload();
                        closeDivs();
                    }
                    else if (responseText == 6) {
                        $.ligerDialog.success('部门无id！');
                        f_reload();
                        closeDivs();
                    }
                },
                error: function () {
                    $.ligerDialog.error('操作失败！');
                },
                complete: function () {
                    $.ligerDialog.closeWaitting();
                }
            });
        }

        //删除
        function del() {
            var manager = $("#maingrid4").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (row) {
                $.ligerDialog.confirm("确定要删除吗？", function (yes) {
                    if (yes) {
                        $.ajax({
                            url: "../DMS_Set.ashx", type: "POST",
                            data: { Action: "deleteBonusTeam", id: row.id, rnd: Math.random() },
                            success: function (responseText) {
                                if (responseText == "4") {
                                    $.ligerDialog.success('删除成功！');
                                    f_reload();
                                }
                            },
                            error: function () {
                                $.ligerDialog.error('删除失败！');
                            }
                        });
                    }
                });
            }
            else {
                $.ligerDialog.warn("请选择记录");
            }
        }

        function f_reload() {
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.loadData(true);
        };

        //取消
        function cancelAll() {
            closeDivs();
        }


    </script>
</head>
<body>
    <form id="form1" onsubmit="return false">
        <div id="toolbar"></div>
        <div id="grid">
            <div id="maingrid4" style="margin: -1px; min-width: 800px;"></div>
        </div>

        <!--新增-->
        <div class="dialog open" id="prodown" style="display: none; position: fixed; width:400px; z-index: 9999; background: #fff;">
            <div class="dialog-head" id="dhead1"><span class="close rotate-hover" style="cursor: pointer" onclick="closeDivs();">X</span><strong id="titlsAll">团队达标奖励设置</strong></div>
            <div class="dialog-body line">
                <input type="text" id="id" name="id" style="display:none" />
                <input type="text" id="d_id" name="d_id" style="display:none" />
                <input type="text" id="d_name" name="d_name" style="display:none" />
                部门：<span style="font-size: 12px; font-weight: bold; color: green" id="d_name_span"> </span>
                
                <table>
                    <tr>
                        <td style="width: 80px">达标100%奖励：</td>
                        <td style="width: 80px">达标90%奖励：</td>
                    </tr>
                     <tr>
                        <td style="width: 80px; " >
                            <input type="text" style="text-align:right;" name="db_100" value=" " /></td>
                        <td style="width: 80px; " >
                            <input type="text" style="text-align:right;" name="db_90" value=" " /></td>
                    </tr>
                </table>
                <div class="dialog-foot">
                    <input type="button" value="保存" class="button bg-load" style="border: 1px solid #ddd; border-color: #2c7;" onclick="Confirm()" />
                    <input type="button" value="关闭" class="button bg-close " style="border: 1px solid #ddd;" onclick="cancelAll()" />
                </div>
            </div>
        </div>
    </form>
    <form id='toexcel'></form>
</body>
</html>
