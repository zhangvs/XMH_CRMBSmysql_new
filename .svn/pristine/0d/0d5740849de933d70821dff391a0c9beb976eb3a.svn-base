<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>年基数设置</title>
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
        var syear;

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
                    { display: '年份', name: 'plan_year', width: 100, align: 'center' },
                    { display: '姓名', name: 'kf_rname', width: 100, align: 'center' },
                    { display: '基数', name: 'plan_task', width: 100, align: 'right' },
                    { display: '一月', name: 'plan_jan', width: 100, align: 'right' },
                    { display: '二月', name: 'plan_feb', width: 100, align: 'right' },
                    { display: '三月', name: 'plan_mar', width: 100, align: 'right' },
                    { display: '四月', name: 'plan_apr', width: 100, align: 'right' },
                    { display: '五月', name: 'plan_may', width: 100, align: 'right' },
                    { display: '六月', name: 'plan_jun', width: 100, align: 'right' },
                    { display: '七月', name: 'plan_jul', width: 100, align: 'right' },
                    { display: '八月', name: 'plan_aug', width: 100, align: 'right' },
                    { display: '九月', name: 'plan_sep', width: 100, align: 'right' },
                    { display: '十月', name: 'plan_oct', width: 100, align: 'right' },
                    { display: '十一月', name: 'plan_nov', width: 100, align: 'right' },
                    { display: '十二月', name: 'plan_dec', width: 100, align: 'right' },
                ],

                dataAction: 'server',
                pageSize: 50, pageSizeOptions: [ 50, 100, 150],
                url: "../DMS_Set.ashx?Action=getMonthBase&rnd=" + Math.random(),
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
                    { type: 'textbox', id: 'syear', text: '年份：' },
                    { type: 'textbox', id: 'tree0', text: '姓名：' },
                    { type: 'button', text: '统计', icon: '../../images/search.gif', disable: true, click: function () { doserch(); } },
                    { type: 'button', text: '新增', icon: '../../Images/Icon/11.png', disable: true, click: function () { add(); } },
                    { type: 'button', text: '修改', icon: '../../Images/Icon/33.png', disable: true, click: function () { edit(); } },
                    { type: 'button', text: '删除', icon: '../../Images/Icon/12.png', disable: true, click: function () { del(); } }

                ]
                //激活哪个
            });
            initSelect();

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
        function initSelect() {
            var d = new Date();
            var nowYear = +d.getFullYear();
            var syearData = [];

            for (var i = nowYear; i >= nowYear - 10; i--) {
                syearData.push({ 'text': i, 'id': i });
            }
            $("#syear").ligerComboBox({
                width: 100, selectBoxHeight: 300,
                data: syearData,
                initValue: nowYear,
                onSelected: function (id, name) {//id为空值，name为选择的值  ,选择不同年份，查询不同年份的考核品牌

                }
            });
            $('#tree0').ligerComboBox({
                width: 250,
                selectBoxWidth: 250,
                selectBoxHeight: 400,
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

        function doserch() {
            syear = $("#syear").val();
            var tree0 = $("#tree0_val").val();
            var sendtxt = "&Action=getMonthBase&idlist=" + tree0 + "&syear=" + syear + "&rnd=" + Math.random();
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.GetDataByURL("../DMS_Set.ashx?" + sendtxt);

        }

        function clearTxt() {
            $("#plan_id").val('');
            $("input[name='plan_task']").val('');
            $("input[name='plan_jan']").val('');
            $("input[name='plan_feb']").val('');
            $("input[name='plan_mar']").val('');
            $("input[name='plan_apr']").val('');
            $("input[name='plan_may']").val('');
            $("input[name='plan_jun']").val('');
            $("input[name='plan_jul']").val('');
            $("input[name='plan_aug']").val('');
            $("input[name='plan_sep']").val('');
            $("input[name='plan_oct']").val('');
            $("input[name='plan_nov']").val('');
            $("input[name='plan_dec']").val('');
            $("input[name='kf_rname']").val('');
            $("input[name='plan_year']").val('');
        }
        //新增
        function add() {
            clearTxt();
            syear = $("#syear").val();
            var tree0v = $("#tree0").ligerComboBox().selectedValue;
            if (tree0v==undefined) {
                $.ligerDialog.error('没选择客服！');
                return;
            }
            if (tree0v.indexOf(';') > 0) {
                $.ligerDialog.error('选择了多个客服！');
                return;
            }
            var tree0 = $("#tree0").ligerComboBox().selectedText;

            $("#kf_uname").val(tree0v);
            $("#kf_rname").val(tree0);
            $("#plan_year").val(tree0);

            $("#kf_rname_span").html(tree0);
            $("#plan_year_span").html(syear);

            show();
        }

        //编辑
        function edit() {
            clearTxt();
            var manager = $("#maingrid4").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (row) {
                $("#plan_id").val(row.plan_id);
                $("#kf_uname").val(row.kf_uname);
                $("#kf_rname").val(row.kf_rname);
                $("#plan_year").val(row.plan_year);

                $("input[name='plan_task']").val(row.plan_task);
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
                
                $("#plan_year_span").html(row.plan_year);
                $("#kf_rname_span").html(row.kf_rname);
                show();
            }
            else {
                $.ligerDialog.warn('请选择行！');
            }

        }


        //保存
        function Confirm() {
            var plan_id = $("#plan_id").val();
            var sendtxt = '';
            if (plan_id != '') {
                sendtxt = "&Action=updateMonthBase";
            }
            else {
                sendtxt = "&Action=addMonthBase";
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
                        $.ligerDialog.success('客服无工号！');
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
                            data: { Action: "deleteMonthBase", plan_id: row.plan_id, rnd: Math.random() },
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
            <div class="dialog-head" id="dhead1"><span class="close rotate-hover" style="cursor: pointer" onclick="closeDivs();">X</span><strong id="titlsAll">年基数设置</strong></div>
            <div class="dialog-body line">
                <input type="text" id="plan_id" name="plan_id" style="display:none" />
                <input type="text" id="kf_uname" name="kf_uname" style="display:none" />
                <input type="text" id="kf_rname" name="kf_rname" style="display:none" />
                <input type="text" id="plan_year" name="plan_year" style="display:none" />
                年份：<span style="font-size: 12px; font-weight: bold; color: green" id="plan_year_span"> </span>
                客服：<span style="font-size: 12px; font-weight: bold; color: green" id="kf_rname_span"> </span>
                
                <table>
                    <tr>
                        <td style="width: 80px">基数：</td>
                        <td style="width: 80px; " >
                            <input type="text" style="text-align:right;" name="plan_task" value=" " /></td><td style="width: 80px"><input id="Radio1" type="button" value="均分" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 80px" >1月</td>
                        <td style="width: 80px;text-align:left; " colspan="2">
                            <input type="text" style="text-align:right;" name="plan_jan" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">2月</td>
                        <td style="width: 80px;text-align:left; " colspan="2">
                            <input type="text" style="text-align:right;" name="plan_feb" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">3月</td>
                        <td style="width: 80px;text-align:left; " colspan="2">
                            <input type="text" style="text-align:right;" name="plan_mar" value=" " /></td>
                    </tr>
                    
                    <tr>
                        <td style="width: 80px">4月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="plan_apr" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">5月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="plan_may" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">6月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="plan_jun" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">7月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="plan_jul" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">8月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="plan_aug" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">9月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="plan_sep" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">10月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="plan_oct" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">11月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="plan_nov" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">12月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="plan_dec" value=" " /></td>
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
