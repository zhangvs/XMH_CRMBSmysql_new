<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>今日异常单</title>
    
    <link href="../../CSS/core.css" rel="stylesheet" type="text/css" />
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/Toolbar.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/input.css" rel="stylesheet" />
    
    <link href="../../JS/jquery-ui.css" rel="stylesheet" />
    
    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../JS/jquery-ui.js"  type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerForm.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerCheckBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerComboBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDateEditor.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerRadio.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTextBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerSpinner.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTree.js" type="text/javascript"></script>

    <script src="../../lib/jquery.form.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerToolBar.js" type="text/javascript"></script>
    <script src="../../lib/json.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>

    <script src="../../lib/echarts/echarts.min.js" type="text/javascript"></script>
    
    <script src="../../lib/echarts/theme/chalk.js" type="text/javascript"></script>
    <script src="../../lib/echarts/theme/macarons.js" type="text/javascript"></script>

    <style type="text/css">
        table.dataView {
            border-collapse: collapse;
            }

            table.dataView th, table.dataView td {
                border: 1px solid #000;
                padding: 0;
            }
            .ui-autocomplete {
                max-height: 750px;
                overflow-y: auto;
                /* prevent horizontal scrollbar */
                overflow-x: hidden;
            }
            * html .ui-autocomplete {
                height: 750px;
            }
    </style>
    <script type="text/javascript">
        var myChartBar;
        var myChartPie;

        var echarts;
        var sdate;
        var sdateTitle;
        var sum_status = 0;
        var abnormal_count = 0;
        var order_sum = 0;

        var barHight = 0;
        var radarMax = 0;
        var status_sum = 0;

        var order_sns = [];
        var order_amounts = [];
        var C_names = [];
        var C_tels = [];
        var region_names = [];
        var sendways = [];
        var referers = [];
        var operators = [];
        var shipping_statuss = [];
        var datetimes = [];

        var city_amounts = [];
        var city_names = [];
        var city_counts = [];

        var emp_amounts = [];
        var emp_names = [];
        var emp_counts = [];
        //物流
        var reason_datas = [];
        //小时
        var hours_data = [];
        //状态
        var shipping_hou = []
        var shipping_qian = []
        //来源
        var referer_data = [];



        $(function () {
            var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height:812
            $("#form1").css("height", h - 30).css("overflow-y", "scroll");//style=" height:800px;overflow-y: scroll;"30:工具栏160：光荣榜

            $("#toolbar").ligerToolBar({
                items: [
                    { type: 'textbox', id: "sdate", text: "日期：" },
                    { type: 'button', text: '统计', icon: '../../images/search.gif', disable: true, click: function () { doserch(); } }
                ]
                //激活哪个
            });
            initSelect();
            doserch();
        });

        function initSelect() {
            $('#sdate').ligerDateEditor();
        }
        function clearData() {
            radarMax = 0;
            order_sns = [];
            order_amounts = [];
            C_names = [];
            C_tels = [];
            region_names = [];
            sendways = [];
            referers = [];
            operators = [];
            shipping_statuss = [];
            datetimes = [];

            reason_datas = [];
            hours_data = [];
            shipping_hou = [];
            shipping_qian = [];
            referer_data = [];

            city_amounts = [];
            city_names = [];
            city_counts = [];
            
            emp_amounts = [];
            emp_names = [];
            emp_counts = [];
        }

        function doserch() {
            clearData();
            sdate = $("#sdate").val();
            if (sdate == '') {
                sdateTitle = '今'
            }
            else {
                sdateTitle = sdate;
            }
            //日异常单销售数据
            $.ajax({
                type: "post",
                url: "../Reports_DMS.ashx",
                data: { Action: "getDateAbnormal_count", sdate: sdate, rnd: Math.random() },
                dataType: "json", //返回数据形式为json  
                success: function (data) {
                    if (data) {
                        if (sum_status != data.Rows[0].sum_status) {
                            abnormal_count = data.Rows[0].abnormal_count;
                            order_sum = parseFloat((data.Rows[0].order_sum).toFixed());
                            sum_status = data.Rows[0].sum_status;

                            if (abnormal_count * 30 < 500) {
                                barHight = 500;
                            }
                            else {
                                barHight = abnormal_count * 30;
                            }

                            DrawEChartPie();
                            var optionPie = myChartPie.getOption();


                            optionPie.title[0].text = '新明辉 ' + sdateTitle + ' 日异常单展示';
                            optionPie.title[0].subtext = '异常单金额：' + order_sum + '    异常单数量：' + abnormal_count;

                            //日异常单状态
                            getDateOrder_status(optionPie);
                            //日异常单数据
                            getDateOrder(optionPie);
                        }
                    }
                },
                error: function (errorMsg) {
                    alert("日异常单个数请求数据失败啦!");
                    
                }
            });


        }

        //日异常单状态
        function getDateOrder_status(optionPie) {
            $.ajax({
                type: "post",
                url: "../Reports_DMS.ashx",
                data: { Action: "GetDateAbnormal_status", sdate: sdate, rnd: Math.random() },
                dataType: "json", //返回数据形式为json  
                success: function (data) {
                    if (data) {
                        for (var j = 0; j < data.Rows.length; j++) {
                            var status_name = data.Rows[j].status_name;
                            var status_count = data.Rows[j].status_count;

                            var hou = {
                                value: 20 * (j + 1),
                                name: status_name
                            };
                            shipping_hou.push(hou);

                            var qian = {
                                value: status_count,
                                name: status_name
                            };
                            shipping_qian.push(qian);
                        }
                        optionPie.series[2].data = shipping_hou;
                        optionPie.series[3].data = shipping_qian;

                        myChartPie.setOption(optionPie);
                    }
                },
                error: function (errorMsg) {
                    alert("日异常单状态请求数据失败啦!");
                }
            });
        }

        //异常单类型
        function getDateOrder_reason(optionPie) {
            $.ajax({
                type: "post",
                url: "../Reports_DMS.ashx",
                data: { Action: "GetDateAbnormal_type", sdate: sdate, rnd: Math.random() },
                dataType: "json", //返回数据形式为json  
                success: function (data) {
                    if (data) {
                        for (var j = 0; j < data.Rows.length; j++) {
                            var code_name = data.Rows[j].code_name;
                            var reason_count = data.Rows[j].reason_count;

                            var val = {
                                value: reason_count,
                                name: code_name
                            };
                            reason_datas.push(val);
                        }
                        optionPie.series[0].data = reason_datas;

                        myChartPie.setOption(optionPie);
                    }
                },
                error: function (errorMsg) {
                    alert("日订单状态请求数据失败啦!");

                }
            });
        }

        //异常单原因
        function getDateOrder_reason(optionPie) {
            $.ajax({
                type: "post",
                url: "../Reports_DMS.ashx",
                data: { Action: "GetDateAbnormal_reason", sdate: sdate, rnd: Math.random() },
                dataType: "json", //返回数据形式为json  
                success: function (data) {
                    if (data) {
                        for (var j = 0; j < data.Rows.length; j++) {                            
                            var code_name = data.Rows[j].code_name;
                            var reason_count = data.Rows[j].reason_count;

                            var val = {
                                value: reason_count,
                                name: code_name
                            };
                            reason_datas.push(val);
                        }
                        optionPie.series[0].data = reason_datas;

                        myChartPie.setOption(optionPie);
                    }
                },
                error: function (errorMsg) {
                    alert("日订单状态请求数据失败啦!");

                }
            });
        }

        //日异常单数据
        function getDateOrder(optionPie) {
            $.ajax({
                type: "post",
                url: "../Reports_DMS.ashx",
                data: { Action: "GetDateAbnormal", sdate: sdate, rnd: Math.random() },
                dataType: "json", //返回数据形式为json  
                success: function (data) {
                    if (data) {
                        DrawEChartBar();
                        var options = myChartBar.getOption();

                        for (var j = 0; j < abnormal_count; j++) {
                            var order_amount = parseFloat((data.Rows[j].order_amount).toFixed());
                            var order_sn = j + 1 + '.' + data.Rows[j].order_sn;
                            var C_name = data.Rows[j].C_name;
                            var C_tel = "'" + data.Rows[j].C_tel;
                            var region_name = data.Rows[j].region_name;
                            var sendway = data.Rows[j].sendway;
                            var referer = data.Rows[j].referer;
                            var operator = data.Rows[j].operator;
                            var shipping_status = data.Rows[j].shipping_status;
                            var datetime = data.Rows[j].datetime;

                            order_amounts.push(order_amount);
                            order_sns.push(order_sn);
                            C_names.push(C_name);
                            C_tels.push(C_tel);
                            region_names.push(region_name);
                            sendways.push(sendway);
                            referers.push(referer);
                            operators.push(operator);
                            shipping_statuss.push(shipping_status);
                            datetimes.push(datetime);
                        }

                        options.yAxis[0].data = order_sns;
                        options.series[0].data = order_amounts;
                        options.series[1].data = C_names;
                        options.series[2].data = C_tels;
                        options.series[3].data = region_names;
                        options.series[4].data = sendways;
                        options.series[5].data = referers;
                        options.series[6].data = operators;
                        options.series[7].data = shipping_statuss;
                        options.series[8].data = datetimes;
                        myChartBar.setOption(options);
                        myChartPie.setOption(optionPie);
                    }
                },
                error: function (errorMsg) {
                    alert("日异常单数据请求数据失败啦!");
                    
                }
            });
        }


        //创建ECharts图表方法  
        function DrawEChartPie() {
            $("#mainPie").css("height", 500);
            myChartPie = echarts.init(document.getElementById('mainPie'), 'chalk');

            optionPie = {
                title: {
                    text: '新明辉' + sdate + '日异常单展示',
                    subtext: '',
                    x: '50%',
                    textAlign: 'center'
                },
                tooltip: {},
                grid: [{
                    top: 500
                }],
                radar: [
                    {
                        indicator: (function () {
                            var res = [];
                            res.push({ text: '下班', max: radarMax });
                            for (var i = 17; i >= 8; i--) {
                                res.push({ text: i + '点', max: radarMax });
                            }
                            return res;
                        })(),
                        center: ['15%', 300],
                        radius: 120
                    }
                ],
                series: [
                    //1
                    {
                        type: 'pie',
                        radius: [0, '50%'],
                        center: ['40%', 300],
                        data: []
                    },
                    //2
                    {
                        type: 'radar',
                        itemStyle: { normal: { areaStyle: { type: 'default' } } },
                        data: [{
                            name: '小时',
                            value: [],
                            label: {
                                normal: {
                                    show: true,
                                    formatter: function (params) {
                                        return params.value;
                                    }
                                }
                            }
                        }
                        ]
                    },
                    //3
                    {
                        name: '背景',
                        type: 'funnel',
                        height: 300,
                        width: 300,
                        left: '55%',
                        top: 150,
                        label: {
                            normal: {
                                formatter: '{b}'
                            },
                            emphasis: {
                                position: 'inside',
                                formatter: '{b}: {c}'
                            }
                        },
                        labelLine: {
                            normal: {
                                show: false
                            }
                        },
                        itemStyle: {
                            normal: {
                                opacity: 0.7
                            }
                        },
                        data: []
                    },
                    //4
                    {
                        name: '实际',
                        type: 'funnel',
                        height: 300,
                        width: 300,
                        left: '55%',
                        top: 150,
                        maxSize: '70%',
                        label: {
                            normal: {
                                position: 'inside',
                                formatter: '{c}',
                                textStyle: {
                                    color: '#fff'
                                }
                            },
                            emphasis: {
                                position: 'inside',
                                formatter: '{b}实际: {c}'
                            }
                        },
                        itemStyle: {
                            normal: {
                                opacity: 0.5,
                                borderColor: '#fff',
                                borderWidth: 2
                            }
                        },
                        data: []
                    },

                    //5
                    {
                        type: 'pie',
                        radius: [0, '50%'],
                        center: ['85%', 300],
                        data: []
                    }
                ]
            };
            
            myChartPie.setOption(optionPie);
        }

        //创建ECharts图表方法  
        function DrawEChartCity() {
            $("#mainCity").css("height", 400);
            myChartCity = echarts.init(document.getElementById('mainCity'), 'chalk');

            optionCity = {
                title: {
                    text: '日异常单城市排名',
                },
                legend: {
                    top: 20,
                    data: ['异常单金额', '异常单数量'],
                    selected: {
                        '异常单金额': true,
                        '异常单数量': false
                    }
                },
                tooltip: {
                },
                toolbox: {
                    show: true,
                    orient: 'vertical',
                    feature: {
                        mark: {
                            show: true
                        },
                        dataView: {
                            show: true,
                            readOnly: false,
                            optionToContent: function (opt) {

                                var hh = (opt.xAxis[0].data.length + 1) * 22;
                                if (hh < 400) {
                                    hh = 400;
                                }
                                $("#mainCity").css("height", hh);
                                var series = opt.series;
                                var axisData = opt.xAxis[0].data;
                                var table = '<table><tbody><tr><td>城市</td>';
                                for (var i = 0, l = series.length; i < l; i++) {
                                    table += '<td>' + series[i].name + '</td>'
                                };

                                table += '</tr>';
                                for (var m = 0, g = axisData.length; m < g; m++) {
                                    table += '<tr><td>' + axisData[m] + '</td>';
                                    for (var n = 0, l = series.length; n < l; n++) {
                                        var val = series[n].data[m];
                                        table += '<td>' + val + '</td>'
                                    }
                                    table += '</tr>';
                                };
                                table += '</tbody></table>';
                                return table;
                            }
                        },
                        magicType: {
                            show: true,
                            type: ['line', 'bar']
                        },
                        restore: {
                            show: true
                        },
                        saveAsImage: {
                            show: true
                        }
                    }
                },
                yAxis: {
                    type: 'value',
                    scale: true,
                    axisLabel: {
                        formatter: function (v) {
                            return v
                        }
                    },
                    splitArea: {
                        show: true
                    }

                },
                xAxis: {
                    type: 'category',
                    axisLabel: {
                        interval: 0,
                        rotate: 45,//倾斜度 -90 至 90 默认为0  
                        //margin: 2,
                        textStyle: {
                            color: "#99ff99"
                        }
                    },
                    data: []
                },
                visualMap: {
                    top: 20,
                    right: 40,
                    pieces: [
                    { min: 20000 }, // 不指定 max，表示 max 为无限大（Infinity）。
                    { min: 10000, max: 20000 },
                    { min: 5000, max: 10000 },
                    { min: 1000, max: 5000, },
                    //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
                    { max: 1000 }     // 不指定 min，表示 min 为无限大（-Infinity）。
                    ],
                    textStyle: {
                        color: "#ffffff"
                    },
                    color: ['#d94e5d', '#eac736', '#50a3ba']
                },
                series: [
                    {
                        type: 'bar',
                        name: '异常单金额',
                        data: []
                    },
                    {
                        type: 'bar',
                        name: '异常单数量',
                        itemStyle: {
                            normal: {
                                label: {
                                    show: true,
                                    position: 'top'
                                }
                            }
                        },
                        data: []
                    }
                ]
            };
            myChartCity.setOption(optionCity);
        }

        //创建ECharts图表方法  
        function DrawEChartEmp() {
            $("#mainEmp").css("height", 400);
            myChartEmp = echarts.init(document.getElementById('mainEmp'), 'chalk');

            optionEmp = {
                title: {
                    text: '日异常单员工排名',
                },
                legend: {
                    top: 20,
                    data: ['异常单金额', '异常单数量'],
                    selected: {
                        '异常单金额': true,
                        '异常单数量': false
                    }
                },
                tooltip: {
                },
                toolbox: {
                    show: true,
                    orient: 'vertical',
                    feature: {
                        mark: {
                            show: true
                        },
                        dataView: {
                            show: true,
                            readOnly: false,
                            optionToContent: function (opt) {
                                var hh = (opt.xAxis[0].data.length + 1) * 22;
                                if (hh < 400) {
                                    hh = 400;
                                }
                                $("#mainEmp").css("height", hh);
                                var series = opt.series;
                                var axisData = opt.xAxis[0].data;
                                var table = '<table><tbody><tr><td>员工</td>';
                                for (var i = 0, l = series.length; i < l; i++) {
                                    table += '<td>' + series[i].name + '</td>'
                                };

                                table += '</tr>';
                                for (var m = 0, g = axisData.length; m < g; m++) {
                                    table += '<tr><td>' + axisData[m] + '</td>';
                                    for (var n = 0, l = series.length; n < l; n++) {
                                        var val = series[n].data[m];
                                        table += '<td>' + val + '</td>'
                                    }
                                    table += '</tr>';
                                };
                                table += '</tbody></table>';
                                return table;
                            }
                        },
                        magicType: {
                            show: true,
                            type: ['line', 'bar']
                        },
                        restore: {
                            show: true
                        },
                        saveAsImage: {
                            show: true
                        }
                    }
                },
                yAxis: {
                    type: 'value',
                    scale: true,
                    axisLabel: {
                        formatter: function (v) {
                            return v
                        }
                    },
                    splitArea: {
                        show: true
                    }

                },
                xAxis: {
                    type: 'category',
                    axisLabel: {
                        interval: 0,
                        rotate: 45,//倾斜度 -90 至 90 默认为0  
                        //margin: 2,
                        textStyle: {
                            color: "#99ff99"
                        }
                    },
                    data: []
                },
                visualMap: {
                    top: 20,
                    right: 40,
                    pieces: [
                    { min: 20000 }, // 不指定 max，表示 max 为无限大（Infinity）。
                    { min: 10000, max: 20000 },
                    { min: 5000, max: 10000 },
                    { min: 1000, max: 5000, },
                    //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
                    { max: 1000 }     // 不指定 min，表示 min 为无限大（-Infinity）。
                    ],
                    textStyle: {
                        color: "#ffffff"
                    },
                    color: ['#d94e5d', '#eac736', '#50a3ba']
                },
                series: [
                    {
                        type: 'bar',
                        name: '异常单金额',
                        data: []
                    },
                    {
                        type: 'bar',
                        name: '异常单数量',
                        itemStyle: {
                            normal: {
                                label: {
                                    show: true,
                                    position: 'top'
                                }
                            }
                        },
                        data: []
                    }
                ]
            };
            myChartEmp.setOption(optionEmp);
        }

        //创建ECharts图表方法  
        function DrawEChartBar() {
            $("#mainBar").css("height", barHight);
            myChartBar = echarts.init(document.getElementById('mainBar'), 'chalk');

            options = {
                title: {
                    text: '日异常单详情',
                },
                legend: {
                    top:-20,
                    data: ['金额', '客户', '电话', '城市', '物流', '来源', '操作人', '状态', '时间'],
                    selected: {
                        '金额': true,
                        '客户': true,
                        '电话': true,
                        '城市': true,
                        '物流': true,
                        '来源': true,
                        '操作人': true,
                        '状态': true,
                        '时间': true,
                    }
                },
                tooltip: {
                    trigger: 'axis',
                    showDelay: 0,
                    formatter: function (params, ticket, callback) {
                        var res = '';
                        var vv = '';
                        var nn = '';
                        for (var i = 0, l = params.length; i < l; i++) {                            
                            //if (params[i].seriesType == 'bar') {
                            nn = params[i].seriesName;
                            vv = params[i].value.toString();
                                res += nn + ' : ' + vv.replace("'",'') + '<br/>';
                            //}
                            
                        }
                        return res;
                    }
                },
                toolbox: {
                    show: true,
                    orient: 'vertical',
                    feature: {
                        mark: {
                            show: true
                        },
                        dataView: {
                            show: true,
                            readOnly: false,
                            optionToContent: function (opt) {
                                var series = opt.series;
                                var axisData = opt.yAxis[0].data;
                                var table = '<table><tbody><tr><td>编号</td>';
                                for (var i = 0, l = series.length; i < l; i++) {
                                    table += '<td>' + series[i].name + '</td>'
                                };

                                table += '</tr>';
                                for (var m = 0, g = axisData.length; m < g; m++) {
                                    table += '<tr><td>' + axisData[m] + '</td>';
                                    for (var n = 0, l = series.length; n < l; n++) {
                                        var val = series[n].data[m];
                                        if (val!=null) {
                                            val=val.toString().replace("'", '')
                                        }
                                        table += '<td>' + val + '</td>'
                                    }
                                    table += '</tr>';
                                };
                                table += '</tbody></table>';
                                return table;
                            }
                        },
                        magicType: {
                            show: true,
                            type: ['line', 'bar']
                        },
                        restore: {
                            show: true
                        },
                        saveAsImage: {
                            show: true
                        }
                    }
                },
                xAxis: {
                    type: 'value',
                    scale: true,
                    axisLabel: {
                        formatter: function (v) {
                            return v
                        }
                    },
                    splitArea: {
                        show: true
                    }

                },
                yAxis: {
                    type: 'category',
                    axisLabel: {
                        interval: 0,
                        //margin: 2,
                        textStyle: {
                            color: "#99ff99"
                        }
                    },
                    data: []
                },
                visualMap: {
                    top: 20,
                    right: 40,
                    pieces: [
                    { min: 20000 }, // 不指定 max，表示 max 为无限大（Infinity）。
                    { min: 10000, max: 20000 },
                    { min: 5000, max: 10000 },
                    { min: 1000, max: 5000, },
                    //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
                    { max: 1000 }     // 不指定 min，表示 min 为无限大（-Infinity）。
                    ],
                    textStyle: {
                        color: "#ffffff"
                    },
                    dimension: 0,
                    //color: ['#d94e5d', '#eac736', '#50a3ba'],
                    inRange: {
                        color: ['#4a657a', '#308e92', '#b1cfa5', '#f5d69f', '#f5898b', '#ef5055']
                    }
                },
                series: [
                    //0
                    {
                        type: 'bar',
                        name: '金额',
                        stack: '日报',
                        itemStyle: {
                            normal: {
                                label: {
                                    show: true,
                                    position: 'right'
                                }
                            }
                        },
                        data: []
                    },
                    //6编号,城市,物流,来源,操作人,状态,时间
                    {
                        type: 'bar',
                        name: '客户',
                        stack: '日报',
                        data: []
                    },
                    {
                        type: 'bar',
                        name: '电话',
                        stack: '日报',
                        data: []
                    },
                    {
                        type: 'bar',
                        name: '城市',
                        stack: '日报',
                        data: []
                    },
                    {
                        type: 'bar',
                        name: '物流',
                        stack: '日报',
                        data: []
                    },
                    {
                        type: 'bar',
                        name: '来源',
                        stack: '日报',
                        data: []
                    },
                    {
                        type: 'bar',
                        name: '操作人',
                        stack: '日报',
                        data: []
                    },
                    {
                        type: 'bar',
                        name: '状态',
                        stack: '日报',
                        data: []
                    },
                    {
                        type: 'bar',
                        name: '时间',
                        stack: '日报',
                        data: []
                    },
                ]
            };
            
            myChartBar.setOption(options);
        }

        

        window.setInterval("doserch()", "60000");
        //window.setInterval("getDateOrder_status()", "60000");
    </script>
</head>
<body>
    <div style="position: relative; z-index: 9999">
        <form id="serchform">
            <div id="toolbar" style="width:100%"></div>
        </form>
    </div>

    <form id="form1" onsubmit="return false">
            <div id="mainPie" ></div>
            <div id="mainCity" ></div>
            <div id="mainEmp" ></div>
            <div id="mainBar" ></div>
    </form>
</body>
</html>
