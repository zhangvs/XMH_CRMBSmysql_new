var mains = new Array();//画图main数组
var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
var syear;
var months = new Array();
var u_company;
var daycount;
var daycounts = new Array(); //月份天数
var axisDatas = new Array(); //x轴

var goods_id;
var goods_name;

var saleData = new Array(); //销售数据
var backData = new Array(); //退货数据
var saleBackData = new Array(); //合计数据

var saleDataMonthSums = new Array(); 
var backDataMonthSums = new Array(); 
var salebackDataMonthSums = new Array(); 

var saleDataYearSum = 0;
var backDataYearSum = 0;
var salebackDataYearSum = 0;

var goods_number;
var goods_numbers = new Array();
var goods_numberMonthSums = new Array();
var goods_numberYearSum = 0;

//日期天数
function getDateCount(syear, u_company) {
    mains = [];
    $("#form1").html("");
    syear = syear;
    u_company = u_company;

    daycount = 0;
    axisData = [];

    saleData = [];
    backData = [];
    saleBackData = [];

    saleDataMonthSums = [];
    backDataMonthSums = [];
    salebackDataMonthSums = [];

    goods_numbers = [];
    goods_numberMonthSums = [];

    for (var i = 0; i < 12; i++) {
        $("#form1").append("<a id='a_main" + i + "' href='#main" + i + "'> </a><div id='main" + i + "' ></div>");

        months[i] = i+1;
        var day = new Date(syear, i, 0);//构造一个日期对象        
        daycount = day.getDate();//获取天数
        axisData[i] = new Array();
        saleData[i]=new Array();
        backData[i]=new Array();
        saleBackData[i] = new Array();
        goods_numbers[i] = new Array();

        for (var j = 0; j < daycount; j++) {
            axisData[i][j] = j + 1 + "日";
            saleData[i][j] = 0; 
            backData[i][j] = 0; 
            saleBackData[i][j] = 0;
            goods_numbers[i][j] = 0;

            saleDataMonthSums[i] = 0;
            backDataMonthSums[i] = 0;
            salebackDataMonthSums[i] = 0;
            goods_numberMonthSums[i] = 0;

            saleDataYearSum = 0;
            backDataYearSum = 0;
            salebackDataYearSum = 0;
            goods_numberYearSum = 0;
        }
    }
}


//个人每日实际销售量
function getCustomerYearGood(GridData) {
    //赋值
    if (GridData.Rows.length > 0) {
        goods_id = GridData.Rows[0].goods_id;//单品id
        goods_name = GridData.Rows[0].goods_name;//单品name

        for (var j = 0; j < GridData.Rows.length; j++) {
            datetime = parseInt(GridData.Rows[j].datetime)-1;
            orderdate = parseInt(GridData.Rows[j].orderdate)-1;
            salemoney = parseFloat(GridData.Rows[j].salemoney.toFixed());
            backmoney = parseFloat(GridData.Rows[j].backmoney.toFixed());
            realmoney = parseFloat(GridData.Rows[j].realmoney.toFixed());
            goods_number = parseFloat(GridData.Rows[j].goods_number.toFixed());

            saleData[datetime][orderdate] = salemoney;
            backData[datetime][orderdate] = backmoney;
            saleBackData[datetime][orderdate] = realmoney;

            saleDataMonthSums[datetime] += salemoney;
            backDataMonthSums[datetime] += backmoney;
            salebackDataMonthSums[datetime] += realmoney;

            saleDataYearSum += salemoney;
            backDataYearSum += backmoney;
            salebackDataYearSum += realmoney;

            goods_numbers[datetime][orderdate]=goods_number;
            goods_numberMonthSums[datetime] += goods_number;
            goods_numberYearSum += goods_number;
        }
    }



    //IE不支持forEach，兼容
    if (!Array.prototype.forEach) {

        Array.prototype.forEach = function forEach(callback, thisArg) {

            var T, k;

            if (this == null) {
                throw new TypeError("this is null or not defined");
            }
            var O = Object(this);
            var len = O.length >>> 0;
            if (typeof callback !== "function") {
                throw new TypeError(callback + " is not a function");
            }
            if (arguments.length > 1) {
                T = thisArg;
            }
            k = 0;

            while (k < len) {

                var kValue;
                if (k in O) {

                    kValue = O[k];
                    callback.call(T, kValue, k, O);
                }
                k++;
            }
        };
    }

    //画图
    saleBackData.forEach(function DrawEChart(v, e) {
        $("#main" + e).css("height", 300);
        var ee = e + 1;
        var option = {
            title: {
                text:  ee + '月销售情况',
                subtext: 
                    '\n\n月销量：' + saleDataMonthSums[e] + '\n月退货：' + backDataMonthSums[e] + '\n月实际：' + salebackDataMonthSums[e] +                    
                    '\n\n月销售数量：' + goods_numberMonthSums[e]
            },
            grid: {
                x: 180,//靠左200像素
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
                // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
            },
            legend: {
                data: ['日销售额', '日退货额', '日实际销售额', '日销售数量'],
                selected: {
                    '日销售额': false,
                    '日退货额': false,
                    '日实际销售额': true,
                    '日销售数量': false
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
                            $("#main" + e).css("height", 680);
                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>日期</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = axisData[e].length; m < g; m++) {
                                table += '<tr><td>' + axisData[e][m] + '</td>';
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
                data: axisData[e]
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
                name: '日销售额',
                stack: '日期',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: saleData[e]
            }, {
                name: '日退货额',
                stack: '日期',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: backData[e]
            }, {
                name: '日实际销售额',
                stack: '日期',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: saleBackData[e]
            }, {
                name: '日销售数量',
                stack: '日期',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: goods_numbers[e]
            }]
        };

        var myChart = echarts.init(document.getElementById('main' + e), 'macarons');
        myChart.setOption(option);
        mains.push(myChart);
    });

    //echarts.connect(mains);
}
//随屏幕的大小改变自适应
$(window).resize(function () {
    mains.forEach(function echartsHight(v, e) {
        v.resize();

    })
});
//画图
function DrawEChartCustomer() {
    $("#main0").before("<div id='main' ></div>");
    $("#main").css("height", 400);
    var option = {
        title: {
            text: u_company + '_' + goods_name + '_年度销售情况',
            subtext: 
                '\n年销售额：' + saleDataYearSum +
                '\n年退货额：' + backDataYearSum +
                '\n年实际额：' + salebackDataYearSum+
                '\n\n年销售数量：' + goods_numberYearSum
        },
        grid: {
            x: 180,//靠左200像素
            y2: 50
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            formatter: function (params, ticket, callback) {
                var res = '可点击定位月份<br/>' + params[0].name;
                for (var i = 0, l = params.length; i < l; i++) {
                    res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                }
                return res
            }
        },
        legend: {
            data: ['月销售额', '月退货额', '月实际额', '月销售数量'],
            selected: {
                '月销售额': false,
                '月退货额': false,
                '月实际额': true,
                '月销售数量': false
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
                        var hh = (months.length + 1) * 22;
                        if (hh < 400) {
                            hh = 400;
                        }
                        $("#main").css("height", hh);
                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>月份</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>'; 
                        for (var m = 0, g = months.length; m < g; m++) {
                            table += '<tr><td>' + months[m] + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m];
                                table += '<td>' + val + '</td>'
                            }
                            table += '</tr>';
                        };
                        table += '</tbody></table>';
                        return table;
                    },
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
                formatter: function (value) {
                    return value + '月';
                }
            },
            data: months
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
        series: [
            {
            name: '月销售额',
            stack: '月份',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: saleDataMonthSums
            }, {
                name: '月退货额',
                stack: '月份',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: backDataMonthSums
            }, {
                name: '月实际额',
                stack: '月份',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: salebackDataMonthSums
            }, {
                name: '月销售数量',
                stack: '月份',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: goods_numberMonthSums
            }]
    };

    var myChartDep = echarts.init(document.getElementById('main'), 'purple-passion');
    myChartDep.setOption(option);
    window.onresize = myChartDep.resize;//随屏幕的大小改变自适应

    myChartDep.on('click', function (params) {
        document.getElementById("a_main" + params.dataIndex).click();
    });
}