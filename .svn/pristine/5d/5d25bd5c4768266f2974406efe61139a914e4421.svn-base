<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>省份月报详情</title>
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
    <script src="../../JS/dms_map_province_month_details.js" type="text/javascript"></script>
    
</head>
<body >

    <form id="form1" onsubmit="return false">
        <div id="main1" ></div>
        <div id="main2" ></div>
        <div id="main3" ></div>
        <div id="main4" ></div>
        <div id="main5" ></div>
    </form>


</body>
</html>


            <%--//定义图表options  
            //var options = {
            //    backgroundColor: '#2c343c',

            //    title: {
            //        text: '省内品牌销售详情',
            //        left: 'center',
            //        top: 20,
            //        textStyle: {
            //            color: '#ccc'
            //        }
            //    },

            //    tooltip: {
            //        trigger: 'item',
            //        formatter: "{a} <br/>{b} : {c} ({d}%)"
            //    },

            //    visualMap: {
            //        show: false,
            //        min: 0,
            //        max: 500000,
            //        inRange: {
            //            colorLightness: [0, 1]
            //        }
            //    },
            //    series: [
            //        {
            //            name: '访问来源',
            //            type: 'pie',
            //            radius: '55%',
            //            center: ['50%', '50%'],
            //            data: [
            //            ].sort(function (a, b) { return a.value - b.value }),
            //            roseType: 'angle',
            //            label: {
            //                normal: {
            //                    textStyle: {
            //                        color: 'rgba(255, 255, 255, 0.3)'
            //                    }
            //                }
            //            },
            //            labelLine: {
            //                normal: {
            //                    lineStyle: {
            //                        color: 'rgba(255, 255, 255, 0.3)'
            //                    },
            //                    smooth: 0.2,
            //                    length: 10,
            //                    length2: 20
            //                }
            //            },
            //            itemStyle: {
            //                normal: {
            //                    color: '#c23531',
            //                    shadowBlur: 200,
            //                    shadowColor: 'rgba(0, 0, 0, 0.5)'
            //                }
            //            }
            //        }
            //    ]
            //};

            //options = {
            //    title: {
            //        text: provinceName+'省内品牌销售详情',
            //        subtext: '销售总额：'+provinceValue,
            //        x: 'center'
            //    },
            //    tooltip: {
            //        trigger: 'item',
            //        formatter: "{a} <br/>{b} : {c} ({d}%)"
            //    },
            //    legend: {
            //        x: 'center',
            //        y: 'bottom',
            //        data: []
            //    },
            //    toolbox: {
            //        show: true,
            //        feature: {
            //            mark: { show: true },
            //            dataView: { show: true, readOnly: false },
            //            magicType: {
            //                show: true,
            //                type: ['pie', 'funnel']
            //            },
            //            restore: { show: true },
            //            saveAsImage: { show: true }
            //        }
            //    },
            //    calculable: true,
            //    series: [
            //        //{
            //        //    name: '半径模式',
            //        //    type: 'pie',
            //        //    radius: [20, 110],
            //        //    center: ['25%', '50%'],
            //        //    roseType: 'radius',
            //        //    label: {
            //        //        normal: {
            //        //            show: false
            //        //        },
            //        //        emphasis: {
            //        //            show: true
            //        //        }
            //        //    },
            //        //    lableLine: {
            //        //        normal: {
            //        //            show: false
            //        //        },
            //        //        emphasis: {
            //        //            show: true
            //        //        }
            //        //    },
            //        //    data: [
            //        //        { value: 10, name: 'rose1' },
            //        //        { value: 5, name: 'rose2' },
            //        //        { value: 15, name: 'rose3' },
            //        //        { value: 25, name: 'rose4' },
            //        //        { value: 20, name: 'rose5' },
            //        //        { value: 35, name: 'rose6' },
            //        //        { value: 30, name: 'rose7' },
            //        //        { value: 40, name: 'rose8' }
            //        //    ]
            //        //},
            //        {
            //            name: '面积模式',
            //            type: 'pie',
            //            radius: '55%',
            //            center: ['50%', '50%'],
            //            roseType: 'area',
            //            data: [
            //            ]
            //        }
            //    ]
            //};--%>
