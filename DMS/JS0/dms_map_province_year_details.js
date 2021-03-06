﻿
var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height//部门颜色变量
var w = window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth; //height//部门颜色变量

var myChartBrand;
var myChartCity;
var syear;
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

var monthNames = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
var monthValues = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

$(function () {
    $("#form1").css("height", h).css("overflow-y", "scroll");//style=" height:800px;overflow-y: scroll;"
    $("#main0").css("height", h / 2).css("width", w - 30).css("float", 'left');
    $("#main1").css("height", h / 1.5).css("width", w / 2).css("float", 'left');
    $("#main2").css("height", h / 1.5).css("width", w / 2 - 30).css("float", 'left');
    $("#main3").css("height", h / 2).css("width", w - 30).css("float", 'left');
    $("#main4").css("height", h / 2).css("width", w - 30).css("float", 'left');
    $("#main5").css("height", h / 2).css("width", w - 30).css("float", 'left');

    syear = decodeURI(getparastr("syear"));
    provinceId = decodeURI(getparastr("provinceId"));
    provinceName = decodeURI(getparastr("provinceName"));
    provinceValue = decodeURI(getparastr("provinceValue"));
    brandIdList = decodeURI(getparastr("brandIdList"));
    brandText = decodeURI(getparastr("brandText"));
    goodId = decodeURI(getparastr("goodId"));
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
    //月份对比
    $.ajax({
        type: "POST",
        async: false,
        url: "../Reports_DMS.ashx",
        data: { Action: "getProvinceYear_Months", provinceId: provinceId, syear: syear, brandIdList: brandIdList, goodId: goodId, goodTextBox: goodTextBox, rnd: Math.random() },
        dataType: 'json',
        success: function (data) {
            if (data) {
                var options = myChartMonth.getOption();
                monthValues = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
                for (var j = 0; j < data.Rows.length; j++) {
                    var dd = parseFloat(data.Rows[j].datetime) - 1;
                    monthValues[dd] = parseFloat((data.Rows[j].month_value).toFixed());
                }
                options.series[0].data = monthValues;
                options.xAxis[0].data = monthNames;
                options.title[0].subtext = subtext;
                myChartMonth.hideLoading();
                myChartMonth.setOption(options);
            }
            $.ligerDialog.closeWaitting();
        },
        error: function () {
            $.ligerDialog.error('查询失败或无数据，请检查查询项。');
        }
    });

    //品牌占比
    $.ajax({
        type: "POST",
        async: false,
        url: "../Reports_DMS.ashx",
        data: { Action: "getProvinceMonth_Brand", provinceId: provinceId, syear: syear, brandIdList: brandIdList, goodId: goodId, goodTextBox: goodTextBox, rnd: Math.random() },
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
        data: { Action: "getProvinceMonth_City", provinceId: provinceId, syear: syear, brandIdList: brandIdList, goodId: goodId, goodTextBox: goodTextBox, rnd: Math.random() },
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
                options.title[0].subtext = subtext;
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
        data: { Action: "getProvinceMonth_Good", provinceId: provinceId, syear: syear, brandIdList: brandIdList, goodId: goodId, goodTextBox: goodTextBox, rnd: Math.random() },
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
                options.title[0].subtext = '\n单品数：' + goodNames.length + '\n' + subtext;
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
        data: { Action: "getProvinceMonth_Emp", provinceId: provinceId, syear: syear, brandIdList: brandIdList, goodId: goodId, goodTextBox: goodTextBox, rnd: Math.random() },
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
        data: { Action: "getProvinceMonth_Customer", provinceId: provinceId, syear: syear, brandIdList: brandIdList, goodId: goodId, goodTextBox: goodTextBox, rnd: Math.random() },
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
    //0.月份柱体
    myChartMonth = echarts.init(document.getElementById('main0'), 'purple-passion');
    myChartMonth.showLoading({
        text: "图表数据正在努力加载..."
    });
    var options = {
        title: {
            text: provinceName + '省' + syear + '年度各月份对比',
        },
        grid: {
            x: 200,//靠左200像素
            x2: 200,//靠右200像素
            y2: 50

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
                            $("#main0").css("height", h / 2);
                        }
                        else {
                            $("#main0").css("height", hh);
                        }

                        var table = '<table><tbody><tr>' + '<td>月份</td>';
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
        xAxis: [{
            type: 'category',
            axisLabel: {
                formatter: function (value) {
                    return value + '月';
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
            type: 'line',
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

    myChartMonth.hideLoading();
    myChartMonth.setOption(options);

    //1.品牌扇形
    myChartBrand = echarts.init(document.getElementById('main1'));
    myChartBrand.showLoading({
        text: "图表数据正在努力加载..."
    });
    options = {
        title: {
            text: provinceName + '省' + syear + '年度品牌销售',
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
            top: 50,
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
            text: provinceName + '省' + syear + '年度城市销售',
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
                name: '销售额',
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
            text: provinceName + '省' + syear + '年度热门单品 (Top100)'
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
            max: 1000000,
            pieces: [
            { min: 1000000 }, // 不指定 max，表示 max 为无限大（Infinity）。
            { min: 500000, max: 1000000 },
            { min: 100000, max: 500000 },
            { min: 10000, max: 100000, },
            //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
            { max: 10000 }     // 不指定 min，表示 min 为无限大（-Infinity）。
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
            text: provinceName + '省' + syear + '年度客服销售'
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
            max: 1000000,
            pieces: [
            { min: 1000000 }, // 不指定 max，表示 max 为无限大（Infinity）。
            { min: 500000, max: 1000000 },
            { min: 100000, max: 500000 },
            { min: 10000, max: 100000, },
            //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
            { max: 10000 }     // 不指定 min，表示 min 为无限大（-Infinity）。
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

    myChartEmp.hideLoading();
    myChartEmp.setOption(options);


    //5.客户柱体
    myChartCustomer = echarts.init(document.getElementById('main5'));
    myChartCustomer.showLoading({
        text: "图表数据正在努力加载..."
    });
    var options = {
        title: {
            text: provinceName + '省' + syear + '年度客户 (Top100)'
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
            max: 1000000,
            pieces: [
            { min: 1000000 }, // 不指定 max，表示 max 为无限大（Infinity）。
            { min: 500000, max: 1000000 },
            { min: 100000, max: 500000 },
            { min: 10000, max: 100000, },
            //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
            { max: 10000 }     // 不指定 min，表示 min 为无限大（-Infinity）。
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