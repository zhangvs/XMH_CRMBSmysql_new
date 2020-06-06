<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>考核品牌基数计划</title>
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

            window['g'] =
            //创建项目列表
            $("#maingrid4").ligerGrid({
                columns: [
                    { display: '序号', width: 50, render: function (rowData, rowindex, value, column, rowid, page, pagesize) { return (page - 1) * pagesize + rowindex + 1; } },
                    { display: '姓名', name: 'bc_real_name', width: 80, align: 'center' },
                    {
                        display: '品牌名称', name: 'bc_brand_name', width: 130, align: 'center', render: function (item) {
                            return item.bc_brand_name == '' ? '其他品牌' : item.bc_brand_name;
                        }
                    },
                    { display: '年份', name: 'bc_year', width: 80, align: 'right' },
                    { display: '基数', name: 'bc_base', width: 80, align: 'right' },
                    { display: '一月', name: 'a_1', width: 80, align: 'right' },
                    { display: '二月', name: 'a_2', width: 80, align: 'right' },
                    { display: '三月', name: 'a_3', width: 80, align: 'right' },
                    { display: '四月', name: 'a_4', width: 80, align: 'right' },
                    { display: '五月', name: 'a_5', width: 80, align: 'right' },
                    { display: '六月', name: 'a_6', width: 80, align: 'right' },
                    { display: '七月', name: 'a_7', width: 80, align: 'right' },
                    { display: '八月', name: 'a_8', width: 80, align: 'right' },
                    { display: '九月', name: 'a_9', width: 80, align: 'right' },
                    { display: '十月', name: 'a_10', width: 80, align: 'right' },
                    { display: '十一月', name: 'a_11', width: 80, align: 'right' },
                    { display: '十二月', name: 'a_12', width: 80, align: 'right' },
                    { display: '计划', name: 'bc_task', width: 80, align: 'right' },
                    { display: '一月', name: 'b_1', width: 80, align: 'right' },
                    { display: '二月', name: 'b_2', width: 80, align: 'right' },
                    { display: '三月', name: 'b_3', width: 80, align: 'right' },
                    { display: '四月', name: 'b_4', width: 80, align: 'right' },
                    { display: '五月', name: 'b_5', width: 80, align: 'right' },
                    { display: '六月', name: 'b_6', width: 80, align: 'right' },
                    { display: '七月', name: 'b_7', width: 80, align: 'right' },
                    { display: '八月', name: 'b_8', width: 80, align: 'right' },
                    { display: '九月', name: 'b_9', width: 80, align: 'right' },
                    { display: '十月', name: 'b_10', width: 80, align: 'right' },
                    { display: '十一月', name: 'b_11', width: 80, align: 'right' },
                    { display: '十二月', name: 'b_12', width: 80, align: 'right' },
                ],

                rowtype: "dept_Qty",
                dataAction: 'server',
                pageSize: 31, pageSizeOptions: [ 31, 62, 93],
                url: "../DMS_Set.ashx?Action=getBrandCheck&rnd=" + Math.random(),
                width: '100%', height: '100%',
                heightDiff: -1,
                onRClickToSelect: true,
                onContextmenu: function (parm, e) {
                    actionCustomerID = parm.data.id;
                    menu.show({ top: e.pageY, left: e.pageX });
                    return false;
                }
            });

            $("#grid").height(document.documentElement.clientHeight - $(".toolbar").height()-30);
            $('form').ligerForm();

            $("#toolbar").ligerToolBar({
                items: [
                    { type: 'textbox', id: 'syear', text: '年份：' },
                    { type: 'textbox', id: 'tree0', text: '姓名：' },
                    { type: 'textbox', id: 'tree1', text: '品牌：' },
                    { type: 'button', text: '统计', icon: '../../images/search.gif', disable: true, click: function () { doserch(); } },
                    { type: 'button', text: '新增', icon: '../../Images/Icon/11.png', disable: true, click: function () { add(); } },
                    { type: 'button', text: '修改', icon: '../../Images/Icon/33.png', disable: true, click: function () { edit(); } },
                    { type: 'button', text: '删除', icon: '../../Images/Icon/12.png', disable: true, click: function () { del(); } }

                ]
                //激活哪个
            });
            initSelect();

            $("#Radio1").click(function () {
                var base = $("input[name='bc_base']").val();
                var base12 = (base / 12).toFixed(2);
                $("input[name='a_1']").val(base12);
                $("input[name='a_2']").val(base12);
                $("input[name='a_3']").val(base12);
                $("input[name='a_4']").val(base12);
                $("input[name='a_5']").val(base12);
                $("input[name='a_6']").val(base12);
                $("input[name='a_7']").val(base12);
                $("input[name='a_8']").val(base12);
                $("input[name='a_9']").val(base12);
                $("input[name='a_10']").val(base12);
                $("input[name='a_11']").val(base12);
                $("input[name='a_12']").val(base12);
            });
            $("#Radio2").click(function () {
                var plan = $("input[name='bc_task']").val();
                var plan12 = (plan / 12).toFixed(2);
                $("input[name='b_1']").val(plan12);
                $("input[name='b_2']").val(plan12);
                $("input[name='b_3']").val(plan12);
                $("input[name='b_4']").val(plan12);
                $("input[name='b_5']").val(plan12);
                $("input[name='b_6']").val(plan12);
                $("input[name='b_7']").val(plan12);
                $("input[name='b_8']").val(plan12);
                $("input[name='b_9']").val(plan12);
                $("input[name='b_10']").val(plan12);
                $("input[name='b_11']").val(plan12);
                $("input[name='b_12']").val(plan12);
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

            $('#tree1').ligerComboBox({
                width: 250,
                selectBoxWidth: 250,
                selectBoxHeight: 400,
                valueField: 'id',
                textField: 'text',
                treeLeafOnly: true,
                tree: {
                    url: '../Reports_DMS.ashx?Action=getCheckBrandTree&rnd=' + Math.random(),
                    idFieldName: 'id',
                    checkbox: true
                }

            });
        }

        function doserch() {
            syear = $("#syear").val();
            var tree0 = $("#tree0_val").val();
            var tree1 = $("#tree1_val").val();

            var sendtxt = "&Action=getBrandCheck&idlist=" + tree0 + "&brandIdList=" + tree1 + "&syear=" + syear + "&rnd=" + Math.random();
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.GetDataByURL("../DMS_Set.ashx?" + sendtxt);

        }

        function clearTxt() {
            $("#bc_id").val('');
            $("#bc_real_name_span").html('');
            $("#bc_brand_name_span").html('');
            $("input[name='bc_base']").val('');
            $("input[name='bc_task']").val('');
            $("input[name='a_1']").val('');
            $("input[name='a_2']").val('');
            $("input[name='a_3']").val('');
            $("input[name='a_4']").val('');
            $("input[name='a_5']").val('');
            $("input[name='a_6']").val('');
            $("input[name='a_7']").val('');
            $("input[name='a_8']").val('');
            $("input[name='a_9']").val('');
            $("input[name='a_10']").val('');
            $("input[name='a_11']").val('');
            $("input[name='a_12']").val('');
            $("input[name='b_1']").val('');
            $("input[name='b_2']").val('');
            $("input[name='b_3']").val('');
            $("input[name='b_4']").val('');
            $("input[name='b_5']").val('');
            $("input[name='b_6']").val('');
            $("input[name='b_7']").val('');
            $("input[name='b_8']").val('');
            $("input[name='b_9']").val('');
            $("input[name='b_10']").val('');
            $("input[name='b_11']").val('');
            $("input[name='b_12']").val('');
        }
        //新增
        function add() {
            clearTxt();
            syear = $("#syear").val();
            var tree0v = $("#tree0").ligerComboBox().selectedValue;
            if (tree0v.indexOf(';') > 0) {
                $.ligerDialog.error('选择了多个客服！');
                return;
            }
            var tree1v = $("#tree1").ligerComboBox().selectedValue;
            if (tree1v.indexOf(';') > 0) {
                $.ligerDialog.error('选择了多个品牌！');
                return;
            }
            var tree0 = $("#tree0").ligerComboBox().selectedText;
            var tree1 = $("#tree1").ligerComboBox().selectedText;

            $("#bc_user_name").val(tree0v);
            $("#bc_real_name").val(tree0);
            $("#bc_brand_id").val(tree1v);
            $("#bc_brand_name").val(tree1);

            $("#bc_year_span").html(syear);
            $("#bc_real_name_span").html(tree0);
            $("#bc_brand_name_span").html(tree1);

            show();
        }

        //编辑
        function edit() {
            clearTxt();
            var manager = $("#maingrid4").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (row) {
                $("#bc_id").val(row.bc_id);
                $("#bc_brand_id").val(row.bc_user_id);
                $("#bc_user_name").val(row.bc_user_name);
                $("#bc_real_name").val(row.bc_real_name);
                $("#bc_brand_name").val(row.bc_brand_name);
                
                $("input[name='bc_base']").val(row.bc_base);
                $("input[name='bc_task']").val(row.bc_task);
                $("input[name='a_1']").val(row.a_1);
                $("input[name='a_2']").val(row.a_2);
                $("input[name='a_3']").val(row.a_3);
                $("input[name='a_4']").val(row.a_4);
                $("input[name='a_5']").val(row.a_5);
                $("input[name='a_6']").val(row.a_6);
                $("input[name='a_7']").val(row.a_7);
                $("input[name='a_8']").val(row.a_8);
                $("input[name='a_9']").val(row.a_9);
                $("input[name='a_10']").val(row.a_10);
                $("input[name='a_11']").val(row.a_11);
                $("input[name='a_12']").val(row.a_12);
                $("input[name='b_1']").val(row.b_1);
                $("input[name='b_2']").val(row.b_2);
                $("input[name='b_3']").val(row.b_3);
                $("input[name='b_4']").val(row.b_4);
                $("input[name='b_5']").val(row.b_5);
                $("input[name='b_6']").val(row.b_6);
                $("input[name='b_7']").val(row.b_7);
                $("input[name='b_8']").val(row.b_8);
                $("input[name='b_9']").val(row.b_9);
                $("input[name='b_10']").val(row.b_10);
                $("input[name='b_11']").val(row.b_11);
                $("input[name='b_12']").val(row.b_12);

                $("#bc_year_span").html(row.bc_year);
                $("#bc_real_name_span").html(row.bc_real_name);
                $("#bc_brand_name_span").html(row.bc_brand_name);

                show();
            }
            else {
                $.ligerDialog.warn('请选择行！');
            }

        }


        //保存
        function Confirm() {
            var bc_id = $("#bc_id").val();
            var sendtxt = '';
            if (bc_id!='') {
                sendtxt = "&Action=updateBrandCheck";
            }
            else {
                sendtxt = "&Action=addBrandCheck";
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
                            data: { Action: "deleteBrandCheck", bc_id: row.bc_id, rnd: Math.random() },
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
        <div class="dialog open" id="prodown" style="display: none; position: fixed; width:600px; z-index: 9999; background: #fff;">
            <div class="dialog-head" id="dhead1"><span class="close rotate-hover" style="cursor: pointer" onclick="closeDivs();">X</span><strong id="titlsAll">考核品牌基数计划</strong></div>
            <div class="dialog-body line">
                <input type="text" id="bc_id" name="bc_id" style="display:none" />
                <input type="text" id="bc_brand_id" name="bc_brand_id" style="display:none" />
                <input type="text" id="bc_brand_name" name="bc_brand_name" style="display:none" />
                <input type="text" id="bc_user_name" name="bc_user_name" style="display:none" />
                <input type="text" id="bc_real_name" name="bc_real_name" style="display:none" />
                年份：<span style="font-size: 12px; font-weight: bold; color: green" id="bc_year_span"> </span>
                客服：<span style="font-size: 12px; font-weight: bold; color: green" id="bc_real_name_span"> </span>
                品牌：<span id="bc_brand_name_span" style="font-size: 12px; font-weight: bold; color: blue"></span>
                
                <table>
                    <tr>
                        <td style="width: 80px">基数：</td>
                        <td style="width: 80px; " >
                            <input type="text" style="text-align:right;" name="bc_base" value=" " /></td><td style="width: 80px"><input id="Radio1" type="button" value="均分" />
                        </td>
                        <td style="width: 80px">计划：</td>
                        <td style="width: 80px">
                            <input type="text" style="text-align:right;" name="bc_task" value=" " /></td><td style="width: 80px"><input id="Radio2" type="button" value="均分" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 80px" >1月</td>
                        <td style="width: 80px;text-align:left; " colspan="2">
                            <input type="text" style="text-align:right;" name="a_1" value=" " /></td>
                        <td style="width: 80px">1月</td>
                        <td style="width: 80px; text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_1" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">2月</td>
                        <td style="width: 80px;text-align:left; " colspan="2">
                            <input type="text" style="text-align:right;" name="a_2" value=" " /></td>
                        <td style="width: 80px">2月</td>
                        <td style="width: 80px;text-align:left; " colspan="2">
                            <input type="text" style="text-align:right;" name="b_2" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">3月</td>
                        <td style="width: 80px;text-align:left; " colspan="2">
                            <input type="text" style="text-align:right;" name="a_3" value=" " /></td>
                        <td style="width: 80px">3月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_3" value=" " /></td>
                    </tr>
                    
                    <tr>
                        <td style="width: 80px">4月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="a_4" value=" " /></td>
                        <td style="width: 80px">4月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_4" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">5月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="a_5" value=" " /></td>
                        <td style="width: 80px">5月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_5" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">6月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="a_6" value=" " /></td>
                        <td style="width: 80px">6月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_6" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">7月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="a_7" value=" " /></td>
                        <td style="width: 80px">7月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_7" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">8月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="a_8" value=" " /></td>
                        <td style="width: 80px">8月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_8" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">9月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="a_9" value=" " /></td>
                        <td style="width: 80px">9月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_9" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">10月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="a_10" value=" " /></td>
                        <td style="width: 80px">10月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_10" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">11月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="a_11" value=" " /></td>
                        <td style="width: 80px">11月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_11" value=" " /></td>
                    </tr>
                    <tr>
                        <td style="width: 80px">12月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="a_12" value=" " /></td>
                        <td style="width: 80px">12月</td>
                        <td style="width: 80px;text-align:left;" colspan="2">
                            <input type="text" style="text-align:right;" name="b_12" value=" " /></td>
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
