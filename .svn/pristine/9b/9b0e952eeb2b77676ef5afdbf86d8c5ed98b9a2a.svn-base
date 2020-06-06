<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>客户品牌单品销售情况</title>
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
    <script src="../../JS/dmsCustomerBrandGoods.js" type="text/javascript"></script>
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
        var syear;
        var smonth;
        var user_id;
        var admin_user_name;
        $(function () {
            admin_user_name = decodeURI(getparastr("admin_user_name"));
            user_id = decodeURI(getparastr("user_id"));
            brand_id = decodeURI(getparastr("brand_id"));
            syear = decodeURI(getparastr("syear"));
            smonth = decodeURI(getparastr("smonth"));

            var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height:812
            $("#form1").css("height", h).css("overflow-y", "scroll");//style=" height:800px;overflow-y: scroll;"

            doserch();

        });



        function doserch() {
            $.ligerDialog.waitting('数据加载中,请稍候...');
            //日期天数
            getDateCount(syear, smonth);
            //x轴
            showAxisData();
            //销售额退货额合计
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getCustomerMonthBrandGoodsSaleBackData", admin_user_name: admin_user_name, user_id: user_id, brand_id: brand_id, syear: syear, smonth: smonth, rnd: Math.random() },
                dataType: 'json',
                success: function (responseText) {
                    if (typeof (responseText) != "undefined") {
                        getMonthSaleBackData(responseText);//数据
                    }
                },
                error: function () {
                    $.ligerDialog.error('查询失败或无数据，请检查查询项。');
                }
            });

            DrawEChartCustomer();
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
