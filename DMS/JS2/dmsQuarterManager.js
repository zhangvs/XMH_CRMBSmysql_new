var monthcount = 12; //月份天数
var axisData = new Array(); //x轴

//var month_base = 0; //日基数
//var month_plan = 0; //日计划
var lines = new Array(); //日基数线

//var quarter_base = 0; //季度基数
//var quarter_plan = 0; //季度计划
var lines2 = new Array(); //季度计划线
var quarterPoint = new Array(); //季度奖

//var year_base = 0; //月基数
//var year_plan = 0; //月计划
var lines3 = new Array(); //月计划线


var saleData = new Array(); //销售数据
//var saleDataSum = 0;

var backData = new Array(); //退货数据
//var backDataSum = 0;

var saleBackData = new Array(); //合计数据
//var saleBackDataSum = 0;

var quarterDataColor = new Array();//各季度累计数据和，颜色，二维数组
var quarterData = new Array(); //季度销售额
var quarterChaData = new Array(); //季度差额
var quarterWcl = new Array(); //季度完成率

var quarter_two1=3; //第二季度起
var quarter_three1=6; //第三季度起
var quarter_four1=9; //第四季度起

var yearData = new Array();//月累计数组

var quarterColors = ['#ffb6c1', '#20b2aa', '#ffa07a', '#87cefa'];

var d_pids = new Array();//部门ids数组
var d_pnames = new Array();//部门ids数组
var d_No = 0;
var subtext = '';//副标题
var mains = new Array();//画图main数组

var month_base = new Array();
var quarter_base = new Array();
var year_base = new Array();

var month_plan = new Array();
var quarter_plan = new Array();
var year_plan = new Array();

var saleDataSum = new Array();
var backDataSum = new Array();
var saleBackDataSum = new Array();
var syear;

var yearSaleBackDatas = new Array();
var yearSaleBackChaDatas = new Array();
var yearWcl = new Array();
var MonthBasePlanData;

var quarterDepWcl = new Array();
var quarterDepWcl_j1 = new Array();
var quarterDepWcl_j2 = new Array();
var quarterDepWcl_j3 = new Array();
var quarterDepWcl_j4 = new Array();



//把基数计划参数赋值给一个集合
function getMonthBasePlanData(monthBasePlan) {
    MonthBasePlanData = monthBasePlan;
}

function getAxisData(date,color,array) {
    var val = {
        value: date,
        textStyle: {
            color: color
        }
    };
    array.push(val);

}
//x轴
function showAxisData() {
    axisData = [];
    for (var j = 0; j < quarter_two1; j++) {
        getAxisData(j + 1 + "月", quarterColors[0], axisData);
    }
    for (var j = quarter_two1; j < quarter_three1; j++) {
        getAxisData(j + 1 + "月", quarterColors[1], axisData);
    }
    for (var j = quarter_three1; j < quarter_four1; j++) {
        getAxisData(j + 1 + "月", quarterColors[2], axisData);
    }
    for (var j = quarter_four1; j < monthcount; j++) {
        getAxisData(j + 1 + "月", quarterColors[3], axisData);
    }
}

function clearLines() {
    syear = $("#syear").val();
    mains = [];
    $("#form1").html("");

    lines = []; //清空日基数线
    lines2 = []; //清空季度计划线
    lines3 = []; //清空月计划线

    month_base = [];
    quarter_base = [];
    year_base = [];

    month_plan = [];
    quarter_plan = [];
    year_plan = [];

    quarterChaData = [];
    quarterDataColor = [];
    quarterWcl = [];
    quarterPoint = [];
}

//画线
function getLines(lineName, lineValue, lineColor, lineNumber) {
    var qd = {
        name: lineName,
        value: lineValue,
        xAxis: -1,
        yAxis: lineValue,
        itemStyle: {
            normal: {
                color: lineColor,
                label: {
                    formatter: function (params, ticket, callback) {
                        return '                 ' + params.name
                    }
                }
            }
        }
    };
    var zd = {
        xAxis: monthcount + '月',
        yAxis: lineValue
    };
    lineNumber.push(qd);
    lineNumber.push(zd);
}



//个人每日销售退货量
function getMonthSaleBackData(GridData) {
    //清空
    saleData = [];
    backData = [];
    saleBackData = [];
    saleBackDataSum = [];
    saleDataSum = [];
    backDataSum = [];

    d_pids = [];
    d_pnames = [];
    //初始化
    for (var r = 0; r < GridData.Rows.length; r++) {
        var d_pid = GridData.Rows[r].d_pid;
        //分别初始话部门月份天数据
        if ($.inArray(d_pid, d_pids) < 0) {
            d_No = d_pids.push(GridData.Rows[r].d_pid)-1;//把部门id分别加入到数组内
            d_pnames.push(GridData.Rows[r].d_pname);
            saleBackData[d_No] = new Array();
            saleBackDataSum[d_No] = new Array();
            saleData[d_No] = new Array();
            saleDataSum[d_No] = new Array();
            backData[d_No] = new Array();
            backDataSum[d_No] = new Array();

            saleDataSum[d_No] = 0;
            backDataSum[d_No] = 0;
            saleBackDataSum[d_No] = 0;

            for (var i = 0; i < monthcount; i++) {
                saleData[d_No][i] = 0;
                backData[d_No][i] = 0;
                saleBackData[d_No][i] = 0;
            }
        }
        $("#form1").append("<div id='main" + d_No + "' ></div>");

        var datetime = parseInt(GridData.Rows[r].datetime) - 1; //从1日开始，-1到角标0

        saleBackData[d_No][datetime] = parseFloat(GridData.Rows[r].realmoney.toFixed());
        saleBackDataSum[d_No] += saleBackData[d_No][datetime];

        saleData[d_No][datetime] = parseFloat(GridData.Rows[r].salemoney.toFixed());
        saleDataSum[d_No] += saleData[d_No][datetime];

        backData[d_No][datetime] = parseFloat(GridData.Rows[r].backmoney.toFixed());
        backDataSum[d_No] += backData[d_No][datetime];

    }

}


//初始化季度数据，颜色
function initQuarterData() {
    for (var i = 0; i < d_pids.length; i++) {
        var quarterSum1 = 0; //季度sum1
        var quarterSum2 = 0; //季度sum2
        var quarterSum3 = 0; //季度sum3
        var quarterSum4 = 0; //季度sum4
        quarterDataColor[i] = new Array();
        for (var j = 0; j < quarter_two1; j++) {
            quarterSum1 += parseFloat(saleBackData[i][j]);
            quarterDataColor[i][j] = new Array();
            quarterDataColor[i][j][0] = quarterSum1;
            quarterDataColor[i][j][1] = quarterColors[0];
        }
        for (var j = quarter_two1; j < quarter_three1; j++) {
            quarterSum2 += parseFloat(saleBackData[i][j]);
            quarterDataColor[i][j] = new Array();
            quarterDataColor[i][j][0] = quarterSum2;
            quarterDataColor[i][j][1] = quarterColors[1];
        }
        for (var j = quarter_three1; j < quarter_four1; j++) {
            quarterSum3 += parseFloat(saleBackData[i][j]);
            quarterDataColor[i][j] = new Array();
            quarterDataColor[i][j][0] = quarterSum3;
            quarterDataColor[i][j][1] = quarterColors[2];
        }
        for (var j = quarter_four1; j < monthcount; j++) {
            quarterSum4 += parseFloat(saleBackData[i][j]);
            quarterDataColor[i][j] = new Array();
            quarterDataColor[i][j][0] = quarterSum4;
            quarterDataColor[i][j][1] = quarterColors[3];
        }
    }
    showMonthQuarterData();
}
//渲染季度,哪个季度数组，地标，数据，颜色
function getQuarterDataVal(array, value, color) {
    var val = {
        value: value,
        itemStyle: {
            normal: {
                color: color
            }
        }
    };
    array.push(val);
}

//根据初始化出来的季度数据，去渲染每一个季度数据，四个季度的和
function showMonthQuarterData() {
    quarterData = [];
    for (var i = 0; i < d_pids.length; i++) {
        quarterData[i] = new Array();
        for (var j = 0; j < monthcount; j++) {
            getQuarterDataVal(quarterData[i], quarterDataColor[i][j][0], quarterDataColor[i][j][1]);
        }
    }

}

//渲染季度奖点
function getQuarterPoint(i, index, xAxis, value) {
    var dian = {
        name: index+'季度奖',
        value: value,
        xAxis: xAxis + '月',
        yAxis: value,
        itemStyle: {
            normal: {
                color: '#FFFF00',
                label: {
                    show: true,
                    formatter: function (params, ticket, callback) {
                        return params.name
                    },
                    textStyle: {
                        color: '#FF1493',
                        fontFamily: 'Verdana, sans-serif',
                        fontSize: 10,
                        fontStyle: 'italic',
                        fontWeight: 'bold'
                    },
                }
            }
        }
    };
    quarterPoint[i].push(dian);
}


//初始化月份累加数据
function initYearData() {
    var monthSum = new Array(); //季度sum1
    yearData = [];
    for (var i = 0; i < d_pids.length; i++) {
        yearData[i] = new Array(); //季度sum1
        monthSum[i] = 0;
        for (var j = 0; j < monthcount; j++) {
            monthSum[i] += parseFloat(saleBackData[i][j].toFixed());
            yearData[i][j] = monthSum[i];
        }
    }

}

//副标题
function getSubText(e, d_pid) {
    for (var i = 0; i < MonthBasePlanData.length; i++) {
        if (d_pid == MonthBasePlanData[i]["d_pid"]) {
            //画线
            lines[e] = new Array();
            lines2[e] = new Array();
            lines3[e] = new Array();

            year_base[e] = parseFloat(MonthBasePlanData[e]["dep_month_base"].toFixed());
            quarter_base[e] = parseFloat((year_base[e] / 4).toFixed()); //季度线
            month_base[e] = parseFloat((year_base[e] / monthcount).toFixed());//年线
            getLines('月基线', month_base[e], '#00ff00', lines[e]);
            getLines('季度基线', quarter_base[e], '#00ff00', lines2[e]);
            getLines('年基线', year_base[e], '#00ff00', lines3[e]);


            year_plan[e] = parseFloat(MonthBasePlanData[i]["dep_month_plan"].toFixed());
            quarter_plan[e] = parseFloat((year_plan[e] / 4).toFixed()); //取前月份的计划除以4
            month_plan[e] = parseFloat((year_plan[e] / monthcount).toFixed());
            getLines('月计划线', month_plan[e], '#ff1493', lines[e]);
            getLines('季度划线', quarter_plan[e], '#ff1493', lines2[e]);
            getLines('年计划线', year_plan[e], '#ff1493', lines3[e]);


            //根据上面的季度计划，计算月内的季度差
            quarterChaData[e] = new Array();
            for (var j = 0; j < monthcount; j++) {
                getQuarterDataVal(quarterChaData[e], quarterDataColor[e][j][0] - quarter_plan[e], quarterDataColor[e][j][1]);
            }

            //季度完成率
            quarterWcl[e] = new Array();
            for (var j = 0; j < monthcount; j++) {
                getQuarterDataVal(quarterWcl[e], parseFloat((quarterDataColor[e][j][0] / quarter_plan[e] * 100).toFixed()), quarterDataColor[e][j][1]);
            }

            // 画点
            quarterPoint[e] = new Array();
            if (quarterChaData[e][quarter_two1 - 1].value > 0) {
                getQuarterPoint(e, '1', quarter_two1, quarterDataColor[e][quarter_two1 - 1][0]);
            }
            if (quarterChaData[e][quarter_three1 - 1].value > 0) {
                getQuarterPoint(e, '2', quarter_three1, quarterDataColor[e][quarter_three1 - 1][0]);
            }
            if (quarterChaData[e][quarter_four1 - 1].value > 0) {
                getQuarterPoint(e, '3', quarter_four1, quarterDataColor[e][quarter_four1 - 1][0]);
            }
            if (quarterChaData[e][monthcount - 1].value > 0) {
                getQuarterPoint(e, '4', monthcount, quarterDataColor[e][monthcount - 1][0]);
            }
        }
    }

    if (lines[e].length > 0 && lines2[e].length > 0 && lines3[e].length > 0 && quarter_plan[e] != 0 && quarter_base[e] != 0) {
        subtext='月基数：' + lines[e][0].value + '\n月计划：' + lines[e][2].value +
        '\n\n季度基数：' + lines2[e][0].value + '\n季度计划：' + lines2[e][2].value 
    }
    return subtext;
}

function drawForEach() {
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
d_pnames.forEach(function DrawEChart(v, e) {
    $("#main" + e).css("height", 400);
    var option = {
        title: {
            text: v + '_' + syear + '年度销售年报',
            subtext: getSubText(e, d_pids[e]),

        },
        grid: {
            x: 200,//靠左200像素
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['月销售额', '月退货额', '月实际销售额', '月差额', '月完成率', '季度销售额', '季度差额', '季度完成率'],
            selected: {
                '月销售额': false,
                '月退货额': false,
                '月实际销售额': false,
                '月差额': false,
                '月完成率': false,
                '季度销售额': false,
                '季度差额': false,
                '季度完成率': true
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
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>月份</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = axisData.length; m < g; m++) {
                            table += '<tr><td>' + axisData[m].value + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = 0;
                                if (n == 5 || n == 6 || n == 7) {
                                    val = series[n].data[m].value;
                                } else {
                                    val = series[n].data[m];
                                }
                                if (n == 4 || n == 7 || n == 10) val += '%';
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
            data: axisData
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
            name: '月销售额',
            stack: '月份',
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
            name: '月退货额',
            stack: '月份',
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
            name: '月实际销售额',
            stack: '月份',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: saleBackData[e],
            markLine: {
                data: lines[e]
            }
        }, {
            name: '月差额',
            stack: '月份',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'bottom'
                    }
                }
            },
            data: (function () {
                var dayCha = [];
                for (var i = 0; i < monthcount; i++) {
                    //if (typeof(saleBackData[i]) == "undefined" ) {
                    //    saleBackData[i] = 0;
                    //}
                    //alert(saleBackData[i]);
                    //alert(month_base);
                    dayCha[i] = parseFloat((saleBackData[e][i] - month_plan[e]).toFixed());
                    //alert(dayCha[i]);
                }
                return dayCha;
            })()
        }, {
            name: '月完成率',
            stack: '月份',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                        formatter: function (params, ticket, callback) {
                            return params.data + '%'
                        },
                    }
                }
            },
            data: (function () {
                var dayWcl = [];
                for (var i = 0; i < monthcount; i++) {
                    dayWcl[i] = parseFloat((saleBackData[e][i] / month_plan[e] * 100).toFixed());
                }
                return dayWcl;
            })()
        }, {
            name: '季度销售额',
            stack: '季度',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: quarterData[e],
            markLine: {
                data: lines2[e]
            },
            markPoint: {
                data: quarterPoint[e]
            }
        }, {
            name: '季度差额',
            stack: '季度',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'bottom'
                    }
                }
            },
            data: quarterChaData[e]
        }, {
            name: '季度完成率',
            stack: '季度',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                        formatter: function (params, ticket, callback) {
                            return params.data.value + '%'
                        },
                    }
                }
            },
            data: quarterWcl[e]
        }]
    };

    var myChart = echarts.init(document.getElementById('main' + e), 'macarons');
    myChart.setOption(option);
    mains.push(myChart);
});

}

$(window).resize(function () {
    mains.forEach(function echartsHight(v, e) {
        v.resize();

    })
});




//画图
function DrawEChartDep_j1() {
    $("#main0").before("<div id='main_j1' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main_j1").css("height", 300);
    var option = {
        title: {
            text: '第一季度部门销售汇总',

        },
        grid: {
            x: 180,//靠左200像素
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['第一季完成率','第一季销售额', '第一季差额'],
            selected: {
                '第一季完成率': true,
                '第一季销售额': false,
                '第一季差额': false
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
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>部门</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = d_pids.length; m < g; m++) {
                            table += '<tr><td>' + d_pnames[m] + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m];
                                if (n == 0) val += '%';
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
                interval: 0,
                rotate: 45,//倾斜度 -90 至 90 默认为0  
                //margin: 2,
                textStyle: {
                    fontWeight: "bolder",
                    color: "#000000"
                }
            },
            data: d_pnames
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
            name: '第一季完成率',
            stack: '第一季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                        formatter: function (params, ticket, callback) {
                            return params.data + '%'
                        },
                    }
                }
            },
            data: (function () {
                quarterDepWcl = [];
                for (var i = 0; i < d_pids.length; i++) {
                    if (isFinite(quarterWcl[i][quarter_two1 - 1].value)) {
                        quarterDepWcl[i] = parseFloat((quarterWcl[i][quarter_two1 - 1].value).toFixed()); //月完成率
                    }
                    else {
                        quarterDepWcl[i] = 0;
                    }

                }
                return quarterDepWcl;
            })(),
            markLine: {
                data: (function myfunction() {
                    var quarterDepWclLine = [];
                    var qd = {
                        name: '均线',
                        value: quarterDepWcl[0],
                        xAxis: -1,
                        yAxis: quarterDepWcl[0],
                        itemStyle: {
                            normal: {
                                color: '#C1232B',
                                label: {
                                    formatter: function (params, ticket, callback) {
                                        return '            ' + params.name
                                    }
                                }
                            }
                        }
                    };
                    var zd = {
                        xAxis: d_pnames[d_pnames.length-1],
                        yAxis: quarterDepWcl[0]
                    };
                    quarterDepWclLine.push(qd);
                    quarterDepWclLine.push(zd);
                    return quarterDepWclLine;
                })()
            }
        },{
            name: '第一季销售额',
            stack: '第一季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: (function () {
                var quarterDepDatas = [];
                for (var i = 0; i < d_pids.length ; i++) {
                    quarterDepDatas[i] = parseFloat((quarterData[i][quarter_two1 - 1].value).toFixed());
                }
                return quarterDepDatas;
            })()
        }, {
            name: '第一季差额',
            stack: '第一季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: (function () {
                var quarterDepChaDatas = [];
                for (var i = 0; i < d_pids.length; i++) {
                    quarterDepChaDatas[i] = parseFloat((quarterChaData[i][quarter_two1 - 1].value).toFixed());
                }
                return quarterDepChaDatas;
            })()
        }]
    };

    var myChartDep_j1 = echarts.init(document.getElementById('main_j1'), 'macarons');
    myChartDep_j1.setOption(option);
    window.onresize = myChartDep_j1.resize;//随屏幕的大小改变自适应

}


//画图
function DrawEChartDep_j2() {
    $("#main0").before("<div id='main_j2' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main_j2").css("height", 300);
    var option = {
        title: {
            text: '第二季度部门销售汇总',

        },
        grid: {
            x: 180,//靠左200像素
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['第二季完成率','第二季销售额', '第二季差额'],
            selected: {
                '第二季完成率': true,
                '第二季销售额': false,
                '第二季差额': false
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
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>部门</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = d_pids.length; m < g; m++) {
                            table += '<tr><td>' + d_pnames[m] + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m];
                                if (n == 0) val += '%';
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
                interval: 0,
                rotate: 45,//倾斜度 -90 至 90 默认为0  
                //margin: 2,
                textStyle: {
                    fontWeight: "bolder",
                    color: "#000000"
                }
            },
            data: d_pnames
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
            name: '第二季完成率',
            stack: '第二季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                        formatter: function (params, ticket, callback) {
                            return params.data + '%'
                        },
                    }
                }
            },
            data: (function () {
                quarterDepWcl_j2 = [];
                for (var i = 0; i < d_pids.length; i++) {
                    if (isFinite(quarterWcl[i][quarter_three1 - 1].value)) {
                        quarterDepWcl_j2[i] = parseFloat((quarterWcl[i][quarter_three1 - 1].value).toFixed()); //月完成率
                    }
                    else {
                        quarterDepWcl_j2[i] = 0;
                    }

                }
                return quarterDepWcl_j2;
            })(),
            markLine: {
                data: (function myfunction() {
                    var monthDepWclLine_j2 = [];
                    var qd = {
                        name: '均线',
                        value: quarterDepWcl_j2[0],
                        xAxis: -1,
                        yAxis: quarterDepWcl_j2[0],
                        itemStyle: {
                            normal: {
                                color: '#C1232B',
                                label: {
                                    formatter: function (params, ticket, callback) {
                                        return '            ' + params.name
                                    }
                                }
                            }
                        }
                    };
                    var zd = {
                        xAxis: d_pnames[d_pnames.length - 1],
                        yAxis: quarterDepWcl_j2[0]
                    };
                    monthDepWclLine_j2.push(qd);
                    monthDepWclLine_j2.push(zd);
                    return monthDepWclLine_j2;
                })()
            }
        },{
            name: '第二季销售额',
            stack: '第二季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: (function () {
                var quarterDepDatas = [];
                for (var i = 0; i < d_pids.length ; i++) {
                    quarterDepDatas[i] = parseFloat((quarterData[i][quarter_three1 - 1].value).toFixed());
                }
                return quarterDepDatas;
            })()
        }, {
            name: '第二季差额',
            stack: '第二季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: (function () {
                var quarterDepChaDatas = [];
                for (var i = 0; i < d_pids.length; i++) {
                    quarterDepChaDatas[i] = parseFloat((quarterChaData[i][quarter_three1 - 1].value).toFixed());
                }
                return quarterDepChaDatas;
            })()
        }]
    };

    var myChartDep_j2 = echarts.init(document.getElementById('main_j2'), 'macarons');
    myChartDep_j2.setOption(option);
    window.onresize = myChartDep_j2.resize;//随屏幕的大小改变自适应

}


//画图
function DrawEChartDep_j3() {
    $("#main0").before("<div id='main_j3' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main_j3").css("height", 300);
    var option = {
        title: {
            text: '第三季度部门销售汇总',

        },
        grid: {
            x: 180,//靠左200像素
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['第三季完成率','第三季销售额', '第三季差额'],
            selected: {
                '第三季完成率': true,
                '第三季销售额': false,
                '第三季差额': false
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
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>部门</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = d_pids.length; m < g; m++) {
                            table += '<tr><td>' + d_pnames[m] + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m];
                                if (n == 0) val += '%';
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
                interval: 0,
                rotate: 45,//倾斜度 -90 至 90 默认为0  
                //margin: 2,
                textStyle: {
                    fontWeight: "bolder",
                    color: "#000000"
                }
            },
            data: d_pnames
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
            name: '第三季完成率',
            stack: '第三季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                        formatter: function (params, ticket, callback) {
                            return params.data + '%'
                        },
                    }
                }
            },
            data: (function () {
                quarterDepWcl_j3 = [];
                for (var i = 0; i < d_pids.length; i++) {
                    if (isFinite(quarterWcl[i][quarter_four1 - 1].value)) {
                        quarterDepWcl_j3[i] = parseFloat((quarterWcl[i][quarter_four1 - 1].value).toFixed()); //月完成率
                    }
                    else {
                        quarterDepWcl_j3[i] = 0;
                    }

                }
                return quarterDepWcl_j3;
            })(),
            markLine: {
                data: (function myfunction() {
                    var monthDepWclLine_j3 = [];
                    var qd = {
                        name: '均线',
                        value: quarterDepWcl_j3[0],
                        xAxis: -1,
                        yAxis: quarterDepWcl_j3[0],
                        itemStyle: {
                            normal: {
                                color: '#C1232B',
                                label: {
                                    formatter: function (params, ticket, callback) {
                                        return '            ' + params.name
                                    }
                                }
                            }
                        }
                    };
                    var zd = {
                        xAxis: d_pnames[d_pnames.length - 1],
                        yAxis: quarterDepWcl_j3[0]
                    };
                    monthDepWclLine_j3.push(qd);
                    monthDepWclLine_j3.push(zd);
                    return monthDepWclLine_j3;
                })()
            }
        },{
            name: '第三季销售额',
            stack: '第三季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: (function () {
                var quarterDepDatas = [];
                for (var i = 0; i < d_pids.length ; i++) {
                    quarterDepDatas[i] = parseFloat((quarterData[i][quarter_four1 - 1].value).toFixed());
                }
                return quarterDepDatas;
            })()
        }, {
            name: '第三季差额',
            stack: '第三季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: (function () {
                var quarterDepChaDatas = [];
                for (var i = 0; i < d_pids.length; i++) {
                    quarterDepChaDatas[i] = parseFloat((quarterChaData[i][quarter_four1 - 1].value).toFixed());
                }
                return quarterDepChaDatas;
            })()
        }]
    };

    var myChartDep_j3 = echarts.init(document.getElementById('main_j3'), 'macarons');
    myChartDep_j3.setOption(option);
    window.onresize = myChartDep_j3.resize;//随屏幕的大小改变自适应

}


//画图
function DrawEChartDep_j4() {
    $("#main0").before("<div id='main_j4' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main_j4").css("height", 300);
    var option = {
        title: {
            text: '第四季度部门销售汇总',

        },
        grid: {
            x: 180,//靠左200像素
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: [ '第四季完成率','第四季销售额', '第四季差额'],
            selected: {
                '第四季完成率': true,
                '第四季销售额': false,
                '第四季差额': false
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
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>部门</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = d_pids.length; m < g; m++) {
                            table += '<tr><td>' + d_pnames[m] + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m];
                                if (n == 0) val += '%';
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
                interval: 0,
                rotate: 45,//倾斜度 -90 至 90 默认为0  
                //margin: 2,
                textStyle: {
                    fontWeight: "bolder",
                    color: "#000000"
                }
            },
            data: d_pnames
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
            name: '第四季完成率',
            stack: '第四季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                        formatter: function (params, ticket, callback) {
                            return params.data + '%'
                        },
                    }
                }
            },
            data: (function () {
                quarterDepWcl_j4 = [];
                for (var i = 0; i < d_pids.length; i++) {
                    if (isFinite(quarterWcl[i][monthcount - 1].value)) {
                        quarterDepWcl_j4[i] = parseFloat((quarterWcl[i][monthcount - 1].value).toFixed()); //月完成率
                    }
                    else {
                        quarterDepWcl_j4[i] = 0;
                    }

                }
                return quarterDepWcl_j4;
            })(),
            markLine: {
                data: (function myfunction() {
                    var monthDepWclLine_j4 = [];
                    var qd = {
                        name: '均线',
                        value: quarterDepWcl_j4[0],
                        xAxis: -1,
                        yAxis: quarterDepWcl_j4[0],
                        itemStyle: {
                            normal: {
                                color: '#C1232B',
                                label: {
                                    formatter: function (params, ticket, callback) {
                                        return '            ' + params.name
                                    }
                                }
                            }
                        }
                    };
                    var zd = {
                        xAxis: d_pnames[d_pnames.length - 1],
                        yAxis: quarterDepWcl_j4[0]
                    };
                    monthDepWclLine_j4.push(qd);
                    monthDepWclLine_j4.push(zd);
                    return monthDepWclLine_j4;
                })()
            }
        },{
            name: '第四季销售额',
            stack: '第四季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: (function () {
                var quarterDepDatas = [];
                for (var i = 0; i < d_pids.length ; i++) {
                    quarterDepDatas[i] = parseFloat((quarterData[i][monthcount - 1].value).toFixed());
                }
                return quarterDepDatas;
            })()
        }, {
            name: '第四季差额',
            stack: '第四季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: (function () {
                var quarterDepChaDatas = [];
                for (var i = 0; i < d_pids.length; i++) {
                    quarterDepChaDatas[i] = parseFloat((quarterChaData[i][monthcount - 1].value).toFixed());
                }
                return quarterDepChaDatas;
            })()
        }]
    };

    var myChartDep_j4 = echarts.init(document.getElementById('main_j4'), 'macarons');
    myChartDep_j4.setOption(option);
    window.onresize = myChartDep_j4.resize;//随屏幕的大小改变自适应

}
