<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>品牌经理设置</title>
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
                    { display: '品牌', name: 'bc_brand_name', width: 80 },
                    { display: '经理', name: 'name', width: 80 },

                ],

                dataAction: 'server',
                pageSize: 31, pageSizeOptions: [31, 62, 93],
                url: "../DMS_Set.ashx?Action=getBrandManager&rnd=" + Math.random(),
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
                    { type: 'button', text: '新增', icon: '../../Images/Icon/11.png', disable: true, click: function () { add(); } },
                    { type: 'button', text: '修改', icon: '../../Images/Icon/33.png', disable: true, click: function () { edit(); } },
                    { type: 'button', text: '删除', icon: '../../Images/Icon/12.png', disable: true, click: function () { del(); } }

                ]
                //激活哪个
            });
        });


        //新增
        function add() {
            clearTxt();
            show();
        }

        //编辑
        function edit() {
            clearTxt();
            var manager = $("#maingrid4").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (row) {
                $("#id").val(row.id);
                $("input[name='bc_brand_id']").val(row.bc_brand_id);
                $("input[name='bc_brand_name']").val(row.bc_brand_name);
                $("input[name='emp_code']").val(row.emp_code);
                $("input[name='name']").val(row.name);
                show();
            }
            else {
                $.ligerDialog.warn('请选择行！');
            }

        }
        
        function clearTxt() {
            $("#id").val('');
            $("input[name='bc_brand_id']").val('');
            $("input[name='bc_brand_name']").val('');
            $("input[name='emp_code']").val('');
            $("input[name='name']").val('');

        }

        //保存
        function Confirm() {
            var id = $("#id").val();
            var sendtxt = '';
            if (id != '') {
                sendtxt = "&Action=updateBrandManager";
            }
            else {
                sendtxt = "&Action=addBrandManager";
            }

            sendtxt = sendtxt + '&' + $("form :input").fieldSerialize();
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
                        $.ligerDialog.error('已存在该品牌经理！');
                        f_reload();
                        closeDivs();
                    }
                    else if (responseText == 2) {
                        $.ligerDialog.success('修改成功！');
                        f_reload();
                        closeDivs();
                    }
                    else if (responseText == 3) {
                        $.ligerDialog.success('找不到该品牌名对应的id，请填写正确的品牌名称！');
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
                            data: { Action: "deleteBrandManager", id: row.id, rnd: Math.random() },
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
        <div class="dialog open" id="prodown" style="display: none; position: fixed; width:250px; z-index: 9999; background: #fff;">
            <div class="dialog-head" id="dhead1"><span class="close rotate-hover" style="cursor: pointer" onclick="closeDivs();">X</span><strong id="titlsAll">品牌经理设置</strong></div>
            <div class="dialog-body line">
                <input type="text" id="id" name="id" style="display:none" />
                <input type="text" id="bc_brand_id" name="bc_brand_id" style="display:none" />
                <input type="text" id="emp_code" name="emp_code" style="display:none" />
                <table>
                    <tr>
                        <td>经理：</td>
                        <td>
                            <input type="text" style="text-align:right;" name="name" value=" " /></td>
                    </tr>
                    <tr>
                        <td>品牌：</td>
                        <td>
                            <input type="text" style="text-align:right;" name="bc_brand_name" value=" " /></td>
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
