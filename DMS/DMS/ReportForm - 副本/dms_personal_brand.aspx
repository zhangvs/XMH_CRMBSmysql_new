<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>【员工】考核品牌月报</title>
    <meta http-equiv="X-UA-Compatible" content="IE=8" />
    <link href="../../CSS/core.css" rel="stylesheet" type="text/css" />
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/Toolbar.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/input.css" rel="stylesheet" />

    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../libNew/ligerUI/js/core/base.js"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerLayout.js" type="text/javascript"></script>
    <script src="../../libNew/ligerUI/js/plugins/ligerGrid.js"></script>
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
    <script src="../../libNew/ligerUI/js/plugins/ligerResizable.js"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerToolBar.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTip.js" type="text/javascript"></script>
    <script src="../../lib/jquery.form.js" type="text/javascript"></script>
    <script src="../../JS/add.js"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerMenu.js" type="text/javascript"></script>

    <script src="../../lib/echarts/echarts.min.js" type="text/javascript"></script>
    <script src="../../lib/echarts/theme/macarons.js" type="text/javascript"></script>
    <script src="../../JS/dmsBrand.js" type="text/javascript"></script>
     <style type="text/css">
        table.dataView {
            border-collapse: collapse;
            }

            table.dataView th, table.dataView td {
                border: 1px solid #000;
                padding: 0;
            }
    </style>
    <script type="text/javascript">
        $(function () {
            var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height:812
            $("#form1").css("height", h-30).css("overflow-y", "scroll");//style=" height:800px;overflow-y: scroll;"
            initLayout();
            $(window).resize(function () {
                initLayout();
            });
            $(document).keydown(function (event) {
                if (event.keyCode == 13) { //绑定回车
                    doserch();
                }
            });

            $("#toolbar").ligerToolBar({
                items: [
                    { type: 'textbox', id: 'tree1', text: '品牌：' },
                    { type: 'textbox', id: "syear", text: "年度：" },
                    { type: 'textbox', id: "smonth", text: "月份：" },
                    { type: 'button', text: '统计', icon: '../../images/search.gif', disable: true, click: function () { doserch(); } }
                ]
                //激活哪个
            });
            initSelect();

            doserch();

        });

        function initSelect() {
            var d = new Date();
            var nowYear = +d.getFullYear();
            var syearData = [], smonthDate = [];
            for (var i = nowYear; i >= nowYear - 10; i--) {
                syearData.push({ 'text': i, 'id': i });
            }
            $("#syear").ligerComboBox({
                width: 100, selectBoxHeight: 300,
                data: syearData,
                initValue: nowYear

            })
            var nowMonth = d.getMonth();
            for (var i = 1; i <= 12; i++) {
                smonthDate.push({ 'text': i, 'id': i });
            }
            $("#smonth").ligerComboBox({
                width: 60, selectBoxHeight: 300, data: smonthDate, initValue: nowMonth
            });

            $('#tree1').ligerComboBox({
                width: 250,
                selectBoxWidth: 250,
                selectBoxHeight: 400,
                valueField: 'id',
                textField: 'text',
                treeLeafOnly: true,
                //checkbox: true,
                tree: {
                    url: '../Reports_DMS.ashx?Action=getCheckBrandTree&rnd=' + Math.random(),
                    idFieldName: 'id',
                    //parentIDFieldName: 'pid',
                    checkbox: true
                }
                //onSelected:function (note)
                //{
                //    alert('onSelect:' + note);
                //}

            });
        }

        function doserch() {
            $.ligerDialog.waitting('数据加载中,请稍候...');
            var tree1 = $("#tree1_val").val();
            var syear = $("#syear").val();
            var smonth = $("#smonth").val();
            //日期天数
            getDateCount(syear, smonth);
            //x轴
            showAxisData();
            //清空线
            clearLines();

            //销售额退货额合计
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getBrandCheck", brandIdList: tree1, smonth: smonth, rnd: Math.random() },
                dataType: 'json',
                success: function (responseText) {
                    getBrandCheck(responseText);
                },
                error: function () {
                    $.ligerDialog.error('不存在你的考核品牌的计划和基数！');
                }
            });

            //销售额退货额合计
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getBrandSaleBackData", brandIdList: tree1, syear: syear, smonth: smonth, rnd: Math.random() },
                dataType: 'json',
                success: function (responseText) {
                    if (responseText.empCodes == "empCodes:0") {
                        $.ligerDialog.error('empCodes:0');
                    }
                    else {
                        if (typeof (responseText) != "undefined") {
                            getMonthSaleBackData(responseText, smonth);//数据
                        }

                    }
                },
                error: function () {
                    $.ligerDialog.error('查询失败或无数据，请检查查询项。');
                }
            });

            DrawEChartBrand();
            $.ligerDialog.closeWaitting();
        }
        

    </script>
</head>
<body >
    <div style="position: relative; z-index: 9999">
        <form id="serchform">
            <div id="toolbar" style="width:100%"></div>
        </form>
    </div>

    <form id="form1" onsubmit="return false">
    </form>


</body>
</html>
