<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>总计划设置</title>
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
            th{
                
                font-size: 14px;
                font-weight:bolder;
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
                        { display: '总计划', name: 'plan_task', width: 120 },
                        { display: '一月', name: 'plan_jan', width: 120 },
                        { display: '二月', name: 'plan_feb', width: 120 },
                        { display: '三月', name: 'plan_mar', width: 120 },
                        { display: '四月', name: 'plan_apr', width: 120 },
                        { display: '五月', name: 'plan_may', width: 120 },
                        { display: '六月', name: 'plan_jun', width: 120 },
                        { display: '七月', name: 'plan_jul', width: 120 },
                        { display: '八月', name: 'plan_aug', width: 120 },
                        { display: '九月', name: 'plan_sep', width: 120 },
                        { display: '十月', name: 'plan_oct', width: 120 },
                        { display: '十一月', name: 'plan_nov', width: 120 },
                        { display: '十二月', name: 'plan_dec', width: 120 },
                ],

                dataAction: 'server',
                pageSize: 31, pageSizeOptions: [31, 62, 93],
                url: "../DMS_Set.ashx?Action=getTotalPlan&rnd=" + Math.random(),
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
                    { type: 'button', text: '修改', icon: '../../Images/Icon/33.png', disable: true, click: function () { edit(); } }

                ]
                //激活哪个
            });

            $("#Radio1").click(function () {
                var base = $("input[name='plan_task']").val();
                var base12 = (base / 12).toFixed(2);
                $("input[name='plan_jan']").val(base12);
                $("input[name='plan_feb']").val(base12);
                $("input[name='plan_mar']").val(base12);
                $("input[name='plan_apr']").val(base12);
                $("input[name='plan_may']").val(base12);
                $("input[name='plan_jun']").val(base12);
                $("input[name='plan_jul']").val(base12);
                $("input[name='plan_aug']").val(base12);
                $("input[name='plan_sep']").val(base12);
                $("input[name='plan_oct']").val(base12);
                $("input[name='plan_nov']").val(base12);
                $("input[name='plan_dec']").val(base12);
            });
        });


        //新增
        function add() {
            show();
        }

        //编辑
        function edit() {
            var manager = $("#maingrid4").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (row) {
                $("#plan_id").val(row.plan_id);
                $("input[name='plan_task']").val(row.plan_task);
                $("input[name='plan_divide']").val(row.plan_divide);
                $("input[name='plan_jan']").val(row.plan_jan);
                $("input[name='plan_feb']").val(row.plan_feb);
                $("input[name='plan_mar']").val(row.plan_mar);
                $("input[name='plan_apr']").val(row.plan_apr);
                $("input[name='plan_may']").val(row.plan_may);
                $("input[name='plan_jun']").val(row.plan_jun);
                $("input[name='plan_jul']").val(row.plan_jul);
                $("input[name='plan_aug']").val(row.plan_aug);
                $("input[name='plan_sep']").val(row.plan_sep);
                $("input[name='plan_oct']").val(row.plan_oct);
                $("input[name='plan_nov']").val(row.plan_nov);
                $("input[name='plan_dec']").val(row.plan_dec);
                show();
            }
            else {
                $.ligerDialog.warn('请选择行！');
            }

        }


        //保存
        function Confirm() {
            var id = $("#plan_id").val();
            var sendtxt = '&Action=updateTotalPlan';

            sendtxt = sendtxt + '&' + $("form :input").fieldSerialize();
            $.ajax({
                url: "../DMS_Set.ashx?" + sendtxt,
                type: "POST",
                beforesend: function () {
                    $.ligerDialog.waitting('数据保存中,请稍候...');
                },
                success: function (responseText) {
                    if (responseText == 2) {
                        $.ligerDialog.success('修改成功！');
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
        <div class="dialog open" id="prodown" style="display: none; position: fixed; width:300px; z-index: 9999; background: #fff;">
            <div class="dialog-head" id="dhead1"><span class="close rotate-hover" style="cursor: pointer" onclick="closeDivs();">X</span><strong id="titlsAll">总计划设置</strong></div>
            <div class="dialog-body line">
                <input type="text" id="plan_id" name="plan_id" style="display:none" />
                <table>
                    <tr>
                        <th>总计划：</th>
                        <td><input type="text" style="text-align:right;" name="plan_task" value=" " /></td><td><input id="Radio1" type="button" value="均分" /></td>
                    </tr>
                    <tr>
                        <th>一月</th>
                        <td><input type="text" style="text-align:right;" name="plan_jan" value=" " /></td>
                    </tr>
                    <tr>
                        <th>二月</th>
                        <td><input type="text" style="text-align:right;" name="plan_feb" value=" " /></td>
                    </tr>
                    <tr>
                        <th>三月</th>
                        <td><input type="text" style="text-align:right;" name="plan_mar" value=" " /></td>
                    </tr>
                    <tr>
                        <th>四月</th>
                        <td><input type="text" style="text-align:right;" name="plan_apr" value=" " /></td>
                    </tr>
                    <tr>
                        <th>五月</th>
                        <td><input type="text" style="text-align:right;" name="plan_may" value=" " /></td>
                    </tr>
                    <tr>
                        <th>六月</th>
                        <td><input type="text" style="text-align:right;" name="plan_jun" value=" " /></td>
                    </tr>
                    <tr>
                        <th>七月</th>
                        <td><input type="text" style="text-align:right;" name="plan_jul" value=" " /></td>
                    </tr>
                    <tr>
                        <th>八月</th>
                        <td><input type="text" style="text-align:right;" name="plan_aug" value=" " /></td>
                    </tr>
                    <tr>
                        <th>九月</th>
                        <td><input type="text" style="text-align:right;" name="plan_sep" value=" " /></td>
                    </tr>
                    <tr>
                        <th>十月</th>
                        <td><input type="text" style="text-align:right;" name="plan_oct" value=" " /></td>
                    </tr>
                    <tr>
                        <th>十一月</th>
                        <td><input type="text" style="text-align:right;" name="plan_nov" value=" " /></td>
                    </tr>
                    <tr>
                        <th>十二月</th>
                        <td><input type="text" style="text-align:right;" name="plan_dec" value=" " /></td>
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
