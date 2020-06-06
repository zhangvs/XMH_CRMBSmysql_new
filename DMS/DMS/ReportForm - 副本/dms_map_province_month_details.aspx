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

    <script type="text/javascript">
        var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height//部门颜色变量
        var w = window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth; //height//部门颜色变量

        var myChartBrand;
        var myChartCity;
        var syear;
        var smonth;
        var provinceId;
        var provinceName;
        var provinceValue;
        var brandIdList;
        var brandText;
        var goodTextBox;
        var subtext;

        var brandNames = [];
        var brandValues = [];

        var goodNames = [];
        var goodValues = [];

        var cityNames = [];
        var cityValues = [];

        var empNames = [];
        var empValues = [];

        var customerValues = [];
        var customerNames = [];

        $(function () {
            $("#form1").css("height", h).css("overflow-y", "scroll");//style=" height:800px;overflow-y: scroll;"
            $("#main1").css("height", h / 1.5).css("width", w / 2).css("float", 'left');
            $("#main2").css("height", h / 1.5).css("width", w / 2-30).css("float", 'left');
            $("#main3").css("height", h / 2).css("width", w-30).css("float", 'left');
            $("#main4").css("height", h / 2).css("width", w - 30).css("float", 'left');
            $("#main5").css("height", h / 2).css("width", w - 30).css("float", 'left');

            syear = decodeURI(getparastr("syear"));
            smonth = decodeURI(getparastr("smonth"));
            provinceId = decodeURI(getparastr("provinceId"));
            provinceName = decodeURI(getparastr("provinceName"));
            provinceValue = decodeURI(getparastr("provinceValue"));
            brandIdList = decodeURI(getparastr("brandIdList"));
            brandText = decodeURI(getparastr("brandText"));
            goodTextBox = decodeURI(getparastr("goodTextBox"));

            subtext = '';
            if (provinceValue != '') {

                subtext += '销售额：' + provinceValue;
            }
            if (brandText != '') {

                subtext += '\n品牌：' + brandText;
            }
            if (goodTextBox != '') {
                subtext += '\n单品关键词：\n' + goodTextBox;
            }

            DrawEChart();
            doserch();
        });



        function doserch() {
            $.ligerDialog.waitting('数据加载中,请稍候...');
            smonth = smonth.length < 2 ? "0" + smonth : smonth;
            yearMonth = syear + "-" + smonth;

            //品牌占比
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getProvinceMonth_Brand", provinceId: provinceId, yearMonth: yearMonth, brandIdList: brandIdList,goodTextBox:goodTextBox, rnd: Math.random() },
                dataType: 'json',
                success: function (data) {
                    if (data) {
                        var options = myChartBrand.getOption();
                        brandValues = [];
                        brandNames = [];
                        for (var j = 0; j < data.Rows.length; j++) {
                            var no = j + 1;
                            brandValues.push({
                                name: no + '.' + data.Rows[j].brand_name,
                                value: (data.Rows[j].brand_value).toFixed()
                            });
                            brandNames.push(no + '.' + data.Rows[j].brand_name);
                        }

                        options.series[0].data = brandValues;
                        options.legend[0].data = brandNames;
                        options.title[0].subtext = subtext;
                        myChartBrand.hideLoading();
                        myChartBrand.setOption(options);
                    }
                    $.ligerDialog.closeWaitting();
                },
                error: function () {
                    $.ligerDialog.error('查询失败或无数据，请检查查询项。');
                }
            });

            //城市占比
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getProvinceMonth_City", provinceId: provinceId, yearMonth: yearMonth, brandIdList: brandIdList, goodTextBox: goodTextBox, rnd: Math.random() },
                dataType: 'json',
                success: function (data) {
                    if (data) {
                        var options = myChartCity.getOption();
                        cityValues = [];
                        cityNames = [];
                        for (var j = 0; j < data.Rows.length; j++) {
                            var no = j + 1;
                            cityValues.push({
                                name: no + '.' + data.Rows[j].city_name,
                                value: (data.Rows[j].city_value).toFixed()
                            });
                            cityNames.push(no + '.' + data.Rows[j].city_name);
                        }

                        options.series[0].data = cityValues;
                        options.legend[0].data = cityNames;
                        options.title[0].subtext =  subtext;
                        myChartCity.hideLoading();
                        myChartCity.setOption(options);
                    }
                    $.ligerDialog.closeWaitting();
                },
                error: function () {
                    $.ligerDialog.error('查询失败或无数据，请检查查询项。');
                }
            });

            //单品占比
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getProvinceMonth_Good", provinceId: provinceId, yearMonth: yearMonth, brandIdList: brandIdList, goodTextBox: goodTextBox, rnd: Math.random() },
                dataType: 'json',
                success: function (data) {
                    if (data) {
                        var options = myChartGood.getOption();
                        goodValues = [];
                        goodNames = [];
                        for (var j = 0; j < data.Rows.length; j++) {
                            var no = j + 1;
                            goodNames.push(no + '.' + data.Rows[j].goods_name);
                            goodValues.push((data.Rows[j].goods_value).toFixed());
                        }
                        options.series[0].data = goodValues.slice(0, 100);
                        options.xAxis[0].data = goodNames.slice(0, 100);
                        options.title[0].subtext = '\n单品数：' + goodNames.length +'\n'+ subtext;
                        myChartGood.hideLoading();
                        myChartGood.setOption(options);
                    }
                    $.ligerDialog.closeWaitting();
                },
                error: function () {
                    $.ligerDialog.error('查询失败或无数据，请检查查询项。');
                }
            });

            //客服占比
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getProvinceMonth_Emp", provinceId: provinceId, yearMonth: yearMonth, brandIdList: brandIdList, goodTextBox: goodTextBox, rnd: Math.random() },
                dataType: 'json',
                success: function (data) {
                    if (data) {
                        var options = myChartEmp.getOption();
                        empValues = [];
                        empNames = [];
                        for (var j = 0; j < data.Rows.length; j++) {
                            var no = j + 1;
                            empNames.push(no + '.' + data.Rows[j].emp_name);
                            empValues.push((data.Rows[j].emp_value).toFixed());
                        }
                        options.series[0].data = empValues;
                        options.xAxis[0].data = empNames;
                        options.title[0].subtext = '\n客服数：' + empNames.length + '\n' + subtext;
                        myChartEmp.hideLoading();
                        myChartEmp.setOption(options);
                    }
                    $.ligerDialog.closeWaitting();
                },
                error: function () {
                    $.ligerDialog.error('查询失败或无数据，请检查查询项。');
                }
            });

            //客户占比
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getProvinceMonth_Customer", provinceId: provinceId, yearMonth: yearMonth, brandIdList: brandIdList, goodTextBox: goodTextBox, rnd: Math.random() },
                dataType: 'json',
                success: function (data) {
                    if (data) {
                        var options = myChartCustomer.getOption();
                        customerValues = [];
                        customerNames = [];
                        for (var j = 0; j < data.Rows.length; j++) {
                            var no = j + 1;
                            customerNames.push(no + '.' + data.Rows[j].customer_name);
                            customerValues.push((data.Rows[j].customer_value).toFixed());
                        }
                        options.series[0].data = customerValues.slice(0, 100);
                        options.xAxis[0].data = customerNames.slice(0, 100);
                        options.title[0].subtext = '\n客户数：' + customerNames.length + '\n' + subtext;
                        myChartCustomer.hideLoading();
                        myChartCustomer.setOption(options);
                    }
                    $.ligerDialog.closeWaitting();
                },
                error: function () {
                    $.ligerDialog.error('查询失败或无数据，请检查查询项。');
                }
            });

        }


        //创建ECharts图表方法  
        function DrawEChart() {
            //1.品牌扇形
            myChartBrand = echarts.init(document.getElementById('main1')); 
            myChartBrand.showLoading({
                text: "图表数据正在努力加载..."
            });
            options = {
                title: {
                    text: provinceName + '省'+smonth+'月份品牌销售',
                    subtext: '销售总额：' + provinceValue,
                    x: 'center'
                },
                tooltip: {
                    trigger: 'item',
                    formatter: "{a} <br/>{b} : {c} ({d}%)"
                },
                toolbox: {
                    show: true,
                    orient: 'horizontal',
                    feature: {
                        mark: {
                            show: true
                        },
                        dataView: {
                            show: true,
                            readOnly: false,
                            optionToContent: function (opt) {
                                var series = opt.series;
                                var axisData = opt.legend[0].data;

                                var hh = (axisData.length + 2) * 21 + 80;
                                if (hh < h / 2) {
                                    $("#main1").css("height", h / 2);
                                }
                                else {
                                    $("#main1").css("height", hh);
                                }

                                var table = '<table><tbody><tr>' + '<td>品牌</td>';
                                for (var i = 0, l = series.length; i < l; i++) {
                                    table += '<td>' + series[i].name + '</td>'
                                };

                                table += '</tr>';
                                for (var m = 0, g = axisData.length; m < g; m++) {
                                    table += '<tr><td>' + axisData[m] + '</td>';
                                    for (var n = 0, l = series.length; n < l; n++) {
                                        var val = series[n].data[m].value;
                                        table += '<td>' + val + '</td>'
                                    }
                                    table += '</tr>';
                                };
                                table += '</tbody></table>';
                                return table;
                            }
                        },
                        restore: {
                            show: true
                        },
                        saveAsImage: {
                            show: true
                        }
                    }
                },
                legend: {
                    orient: 'vertical',
                    x: 10,
                    top:50,
                    data: []
                },
                series: [
                    {
                        name: '销售额',
                        type: 'pie',
                        radius: '60%',
                        center: ['65%', '50%'],
                        data: [
                        ],
                        itemStyle: {
                            emphasis: {
                                shadowBlur: 10,
                                shadowOffsetX: 0,
                                shadowColor: 'rgba(0, 0, 0, 0.5)'
                            }
                        }
                    }
                ]
            };

            myChartBrand.hideLoading();
            myChartBrand.setOption(options);

            //2.城市扇形
            myChartCity = echarts.init(document.getElementById('main2'));
            myChartCity.showLoading({
                text: "图表数据正在努力加载..."
            });
                options = {
                    title: {
                        text: provinceName + '省'+smonth+'月份城市销售',
                        subtext: '销售总额：'+provinceValue,
                        x: 'center'
                    },
                    tooltip: {
                        trigger: 'item',
                        formatter: "{a} <br/>{b} : {c} ({d}%)"
                    },
                    toolbox: {
                        show: true,
                        orient: 'horizontal',
                        feature: {
                            mark: {
                                show: true
                            },
                            dataView: {
                                show: true,
                                readOnly: false,
                                optionToContent: function (opt) {
                                    var series = opt.series;
                                    var axisData = opt.legend[0].data;

                                    var hh = (axisData.length + 2) * 21 + 80;
                                    if (hh < h / 2) {
                                        $("#main2").css("height", h / 2);
                                    }
                                    else {
                                        $("#main2").css("height", hh);
                                    }

                                    var table = '<table><tbody><tr>' + '<td>城市</td>';
                                    for (var i = 0, l = series.length; i < l; i++) {
                                        table += '<td>' + series[i].name + '</td>'
                                    };

                                    table += '</tr>';
                                    for (var m = 0, g = axisData.length; m < g; m++) {
                                        table += '<tr><td>' + axisData[m] + '</td>';
                                        for (var n = 0, l = series.length; n < l; n++) {
                                            var val = series[n].data[m].value;
                                            table += '<td>' + val + '</td>'
                                        }
                                        table += '</tr>';
                                    };
                                    table += '</tbody></table>';
                                    return table;
                                }
                            },
                            restore: {
                                show: true
                            },
                            saveAsImage: {
                                show: true
                            }
                        }
                    },
                    legend: {
                        orient: 'vertical',
                        x: 'right',
                        top: 50,
                        data: []
                    },
                    calculable: true,
                    series: [
                        {
                            name: '城市',
                            type: 'pie',
                            radius: '60%',
                            center: ['50%', '50%'],
                            roseType: 'area',
                            data: []
                        }
                    ]
                };

            myChartCity.hideLoading();
            myChartCity.setOption(options);

            //3.客服柱体
            myChartGood = echarts.init(document.getElementById('main3'));
            myChartGood.showLoading({
                text: "图表数据正在努力加载..."
            });
            var options = {
                title: {
                    text: provinceName + '省'+smonth+'月份热门单品 (Top100)'
                },
                grid: {
                    x: 180,//靠左200像素
                    x2: 180,//靠右200像素
                    y2: 300

                },
                visualMap: {
                    top: 20,
                    right: 40,
                    min: 0,
                    max: 100000,
                    pieces: [
                    { min: 100000 }, // 不指定 max，表示 max 为无限大（Infinity）。
                    { min: 50000, max: 100000 },
                    { min: 10000, max: 50000 },
                    { min: 1000, max: 10000, },
                    //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
                    { max: 1000 }     // 不指定 min，表示 min 为无限大（-Infinity）。
                    ],
                    color: ['#d94e5d', '#eac736', '#50a3ba'],
                },
                tooltip: {
                    trigger: 'axis',
                    showDelay: 0,
                    formatter: function (params, ticket, callback) {
                        var res = params[0].name;
                        for (var i = 0, l = params.length; i < l; i++) {
                            res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                        }
                        return res
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
                                var axisData = opt.xAxis[0].data;

                                var hh = (axisData.length + 2) * 21 + 80;
                                if (hh < h / 2) {
                                    $("#main3").css("height", h / 2);
                                }
                                else {
                                    $("#main3").css("height", hh);
                                }

                                var table = '<table><tbody><tr>' + '<td>单品</td>';
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
                calculable: true,
                xAxis: [{
                    type: 'category',
                    axisLabel: {
                        interval: 0,
                        rotate: 45,//倾斜度 -90 至 90 默认为0  
                        //margin: 2,
                        textStyle: {
                            fontWeight: "bolder",
                            color: "#000000"
                        }
                    },
                    data: []
                }],
                yAxis: [{
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
                }],
                series: [{
                    name: '销售额',
                    type: 'bar',
                    itemStyle: {
                        normal: {
                            label: {
                                show: true,
                                position: 'top'
                            }
                        }
                    },
                    data: []
                }]
            };

            myChartGood.hideLoading();
            myChartGood.setOption(options);


            //4.客服柱体
            myChartEmp = echarts.init(document.getElementById('main4'));
            myChartEmp.showLoading({
                text: "图表数据正在努力加载..."
            });
            var options = {
                title: {
                    text: provinceName + '省'+smonth+'月份客服销售'
                },
                grid: {
                    x: 180,//靠左200像素
                    x2: 180,//靠右200像素
                    y2: 100

                },
                visualMap: {
                    top: 20,
                    right: 40,
                    min: 0,
                    max: 100000,
                    pieces: [
                    { min: 100000 }, // 不指定 max，表示 max 为无限大（Infinity）。
                    { min: 50000, max: 100000 },
                    { min: 10000, max: 50000 },
                    { min: 1000, max: 10000, },
                    //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
                    { max: 1000 }     // 不指定 min，表示 min 为无限大（-Infinity）。
                    ],
                    color: ['#d94e5d', '#eac736', '#50a3ba'],
                },
                tooltip: {
                    trigger: 'axis',
                    showDelay: 0,
                    formatter:function (params,ticket,callback) {
                        var res =  params[0].name ;
                        for (var i = 0, l = params.length; i < l; i++) {
                            res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                        }
                        return res
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
                                var axisData = opt.xAxis[0].data;

                                var hh = (axisData.length + 2) * 21 + 80;
                                if (hh < h / 2) {
                                    $("#main4").css("height", h / 2);
                                }
                                else {
                                    $("#main4").css("height", hh);
                                }

                                var table = '<table><tbody><tr>' + '<td>客服</td>';
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
                calculable: true,
                xAxis: [{
                    type: 'category',
                    axisLabel: {
                        interval: 0,
                        rotate: 45,//倾斜度 -90 至 90 默认为0  
                        //margin: 2,
                        textStyle: {
                            fontWeight: "bolder",
                            color: "#000000"
                        }
                    },
                    data: []
                }],
                yAxis: [{
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
                }],
                series: [ {
                    name: '销售额',
                    type: 'bar',
                    itemStyle: {
                        normal: {
                            label: {
                                show: true,
                                position: 'top'
                            }
                        }
                    },
                    data: []
                }]
            };

            myChartEmp.hideLoading();
            myChartEmp.setOption(options);


            //5.客户柱体
            myChartCustomer = echarts.init(document.getElementById('main5'));
            myChartCustomer.showLoading({
                text: "图表数据正在努力加载..."
            });
            var options = {
                title: {
                    text: provinceName + '省'+smonth+'月份客户 (Top100)'
                },
                grid: {
                    x: 180,//靠左200像素
                    x2: 180,//靠右200像素
                    y2: 200

                },
                visualMap: {
                top: 20,
                right: 40,
                min: 0,
                max: 100000,
                pieces: [
                {min: 100000}, // 不指定 max，表示 max 为无限大（Infinity）。
                {min: 50000, max: 100000},
                {min: 10000, max: 50000},
                {min: 1000, max: 10000,},
                //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
                {max: 1000}     // 不指定 min，表示 min 为无限大（-Infinity）。
                ],
                color: ['#d94e5d', '#eac736', '#50a3ba'],
                },
                tooltip: {
                    trigger: 'axis',
                    showDelay: 0,
                    formatter: function (params, ticket, callback) {
                        var res = params[0].name;
                        for (var i = 0, l = params.length; i < l; i++) {
                            res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                        }
                        return res
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
                                var axisData = opt.xAxis[0].data;

                                var hh = (axisData.length + 2) * 21 + 80;
                                if (hh < h / 2) {
                                    $("#main5").css("height", h / 2);
                                }
                                else {
                                    $("#main5").css("height", hh);
                                }

                                var table = '<table><tbody><tr>' + '<td>客户</td>';
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
                calculable: true,
                xAxis: [{
                    type: 'category',
                    axisLabel: {
                        interval: 0,
                        rotate: 45,//倾斜度 -90 至 90 默认为0  
                        //margin: 2,
                        textStyle: {
                            fontWeight: "bolder",
                            color: "#000000"
                        }
                    },
                    data: []
                }],
                yAxis: [{
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
                }],
                series: [{
                    name: '销售额',
                    type: 'bar',
                    itemStyle: {
                        normal: {
                            label: {
                                show: true,
                                position: 'top'
                            }
                        }
                    },
                    data: []
                }]
            };

            myChartCustomer.hideLoading();
            myChartCustomer.setOption(options);
        }
    </script>
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
