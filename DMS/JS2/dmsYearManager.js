var mains = new Array();//画图main数组
var axisData = new Array(); //x轴
var subtext = '';//副标题
var baseColor = '#00ff00';
var planColor = '#ff1493';
var quarterColors = ['#ffb6c1', '#20b2aa', '#ffa07a', '#87cefa'];
var yearColor = '#7CCD7C';
var d_pidColor = '#006699';
var cycles = ['年', '第一季度', '第二季度', '第三季度', '第四季度']//周期，根据周期循环展示各部门对比的图像

var d_pids = new Array();//部门ids数组
var d_pnames = new Array();//部门ids数组
var d_No = 0;

var syear;
var monthcount = 12; //月份天数
var quarter_two1 = 3; //第二季度起
var quarter_three1 = 6; //第三季度起
var quarter_four1 = 9; //第四季度起
//基数
var month_base = new Array();
var quarter_base = new Array();
var year_base = new Array();
//计划
var month_plan = new Array();
var quarter_plan = new Array();
var year_plan = new Array();

var lines = new Array(); //日基数线
var lines2 = new Array(); //季度计划线
var quarterPoint = new Array(); //季度奖
var lines3 = new Array(); //月计划线


var saleData = new Array(); //销售数据
var backData = new Array(); //退货数据
var saleBackData = new Array(); //合计数据
var monthChas = new Array();
var monthWcls = new Array();

var saleDataSum = new Array();
var backDataSum = new Array();
var saleBackDataSum = new Array();

var quarterDataColor = new Array();//各季度累计数据和，颜色，二维数组
var quarterData = new Array(); //季度销售额
var quarterChaData = new Array(); //季度差额
var quarterWcl = new Array(); //季度完成率


var yearSum = 0;
var yearDatas = new Array();//月累计数组
var yearChaDatas = new Array();
var yearWcls = new Array();

var yearDepDatas = new Array();
var yearDepChaDatas = new Array();
var yearDepWcls = new Array();
var yearDepWclLines = new Array();

function clearData() {
    syear = $("#syear").val();
    mains = [];
    $("#form1").html("");

    d_pids = [];
    d_pnames = [];

    lines = []; //清空日基数线
    lines2 = []; //清空季度计划线
    lines3 = []; //清空月计划线

    month_base = [];
    quarter_base = [];
    year_base = [];

    month_plan = [];
    quarter_plan = [];
    year_plan = [];

    //清空
    saleData = [];
    backData = [];
    saleBackData = [];
    saleBackDataSum = [];
    saleDataSum = [];
    backDataSum = [];

    quarterDataColor = [];
    quarterData = [];
    quarterChaData = [];
    quarterWcl = [];
    quarterPoint = [];

    yearSum = 0;
}



//个人每日销售退货量
function getMonthSaleBackData(GridData) {
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
            //画线
            lines[d_No] = new Array();
            lines2[d_No] = new Array();
            lines3[d_No] = new Array();

            year_base[d_No] = parseFloat(GridData.Rows[r].dep_month_base.toFixed());
            quarter_base[d_No] = parseFloat((GridData.Rows[r].dep_month_base.toFixed() / 4).toFixed()); //季度线
            month_base[d_No] = parseFloat((GridData.Rows[r].dep_month_base.toFixed() / monthcount).toFixed());//年线
            getLines('月基线', month_base[d_No], baseColor, axisData[length - 1], lines[d_No]);
            getLines('季度基线', quarter_base[d_No], baseColor, axisData[length - 1], lines2[d_No]);
            getLines('年基线', year_base[d_No], baseColor, axisData[length - 1], lines3[d_No]);


            year_plan[d_No] = parseFloat(GridData.Rows[r].dep_month_plan.toFixed());
            quarter_plan[d_No] = parseFloat((GridData.Rows[r].dep_month_plan.toFixed() / 4).toFixed()); //取前月份的计划除以4
            month_plan[d_No] = parseFloat((GridData.Rows[r].dep_month_plan.toFixed() / monthcount).toFixed());
            getLines('月计划线', month_plan[d_No], planColor, axisData[length - 1], lines[d_No]);
            getLines('季度划线', quarter_plan[d_No], planColor, axisData[length - 1], lines2[d_No]);
            getLines('年计划线', year_plan[d_No], planColor, axisData[length - 1], lines3[d_No]);
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

//根据初始化出来的季度数据，去渲染每一个季度数据，四个季度的和
function showMonthQuarterData() {
    for (var i = 0; i < d_pids.length; i++) {
        quarterData[i] = new Array();
        quarterChaData[i] = new Array();//根据上面的季度计划，计算月内的季度差
        quarterWcl[i] = new Array();//季度完成率
        for (var j = 0; j < monthcount; j++) {
            getColorAndValue(quarterData[i], quarterDataColor[i][j][0], quarterDataColor[i][j][1]);
            getColorAndValue(quarterChaData[i], quarterDataColor[i][j][0] - quarter_plan[i], quarterDataColor[i][j][1]);
            getColorAndValue(quarterWcl[i], parseFloat((quarterDataColor[i][j][0] / quarter_plan[i] * 100).toFixed()), quarterDataColor[i][j][1]);
        }
        // 画点
        quarterPoint[i] = new Array();
        if (quarterChaData[i][quarter_two1 - 1].value > 0) {
            getPoint(quarterPoint[i], '1季度奖', axisData[quarter_two1 - 1], quarterDataColor[i][quarter_two1 - 1][0]);
        }
        if (quarterChaData[i][quarter_three1 - 1].value > 0) {
            getPoint(quarterPoint[i], '2季度奖', axisData[quarter_three1 - 1], quarterDataColor[i][quarter_three1 - 1][0]);
        }
        if (quarterChaData[i][quarter_four1 - 1].value > 0) {
            getPoint(quarterPoint[i], '3季度奖', axisData[quarter_four1 - 1], quarterDataColor[i][quarter_four1 - 1][0]);
        }
        if (quarterChaData[i][monthcount - 1].value > 0) {
            getPoint(quarterPoint[i], '4季度奖', axisData[length - 1], quarterDataColor[i][monthcount - 1][0]);
        }
    }
}


//初始化月份累加数据
function initYearData() {
    for (var i = 0; i < d_pids.length; i++) {
        monthChas[i] = new Array();
        monthWcls[i] = new Array();

        yearSum = 0;
        yearDatas[i] = new Array();
        yearChaDatas[i] = new Array();
        yearWcls[i] = new Array();
        for (var j = 0; j < monthcount; j++) {
            monthChas[i][j] = parseFloat((saleBackData[i][j] - month_plan[i]).toFixed());
            monthWcls[i][j] = parseFloat((saleBackData[i][j] / month_plan[i] * 100).toFixed());

            yearSum += parseFloat((saleBackData[i][j]).toFixed());
            yearDatas[i][j] = yearSum;
            yearChaDatas[i][j] = parseFloat((yearDatas[i][j] - year_plan[i]).toFixed());
            yearWcls[i][j] = parseFloat((yearDatas[i][j] / year_plan[i] * 100).toFixed()); 
        }
    }

}

//副标题
function getSubText(e, d_pid) {
    if (lines[e].length > 0 && lines2[e].length > 0 && lines3[e].length > 0 && quarter_plan[e] != 0 && quarter_base[e] != 0) {
        subtext='月基数：' + lines[e][0].value + '\n月计划：' + lines[e][2].value +
        '\n\n季度基数：' + lines2[e][0].value + '\n季度计划：' + lines2[e][2].value +
        '\n\n年基数：' + lines3[e][0].value + '\n年计划：' + lines3[e][2].value +
        '\n\n年销量：' + saleDataSum[e] + '\n年退货：' + backDataSum[e] + '\n年实际：' + saleBackDataSum[e]+'\n年完成率：' + parseFloat((saleBackDataSum[e] / lines3[e][2].value * 100).toFixed()) + '%'
    }
    else {
        subtext = '\n\n年销量：' + saleDataSum[e] + '\n年退货：' + backDataSum[e] + '\n年实际：' + saleBackDataSum[e]
    }
    return subtext;
}


//月，节点，分部门综合展示
function getDepData(c, d_pid, sale, cha, wcl) {
    var color_c;
    if (c == 0) {
        color_c = yearColor;
    }
    else {
        color_c = quarterColors[c - 1];
    }

    if (!isFinite(wcl)) {
        wcl = 0;
    }

    //销售数据，差额数据,完成率数据
    if (d_pid == 0) {
        yearDepDatas[c].push({ value: sale, itemStyle: { normal: { color: d_pidColor } } });
        yearDepChaDatas[c].push({ value: cha, itemStyle: { normal: { color: d_pidColor } } });
        yearDepWcls[c].push({ value: wcl, itemStyle: { normal: { color: d_pidColor } } });
        getLines('均线', wcl, d_pidColor, d_pnames[length - 1], yearDepWclLines[c]);
    }
    else {
        yearDepDatas[c].push({ value: sale, itemStyle: { normal: { color: color_c } } });
        yearDepChaDatas[c].push({ value: cha, itemStyle: { normal: { color: color_c } } });
        yearDepWcls[c].push({ value: wcl, itemStyle: { normal: { color: color_c } } });
    }
}

function initYearDepData() {
    for (var c = 0; c < cycles.length; c++) {
        $("#main0").before("<div id='cycles" + c + "' ></div>");
        $("#cycles" + c).css("height", 300);
        yearDepDatas[c] = new Array();
        yearDepChaDatas[c] = new Array();
        yearDepWcls[c] = new Array();
        yearDepWclLines[c] = new Array();
    }
    for (var i = 0; i < d_pids.length; i++) {
        //月，循环加入每一个部门
        getDepData(0, d_pids[i], parseFloat(yearDatas[i][monthcount - 1].toFixed()), parseFloat(yearChaDatas[i][monthcount - 1].toFixed()), parseFloat(yearWcls[i][monthcount - 1].toFixed()));//月
        getDepData(1, d_pids[i], parseFloat(quarterData[i][quarter_two1 - 1].value.toFixed()), parseFloat(quarterChaData[i][quarter_two1 - 1].value.toFixed()), parseFloat(quarterWcl[i][quarter_two1 - 1].value.toFixed()));//节点1
        getDepData(2, d_pids[i], parseFloat(quarterData[i][quarter_three1 - 1].value.toFixed()), parseFloat(quarterChaData[i][quarter_three1 - 1].value.toFixed()), parseFloat(quarterWcl[i][quarter_three1 - 1].value.toFixed()));//节点2
        getDepData(3, d_pids[i], parseFloat(quarterData[i][quarter_four1 - 1].value.toFixed()), parseFloat(quarterChaData[i][quarter_four1 - 1].value.toFixed()), parseFloat(quarterWcl[i][quarter_four1 - 1].value.toFixed()));//节点3
        getDepData(4, d_pids[i], parseFloat(quarterData[i][monthcount - 1].value.toFixed()), parseFloat(quarterChaData[i][monthcount - 1].value.toFixed()), parseFloat(quarterWcl[i][monthcount - 1].value.toFixed()));//节点4
    }
}



function drawForEach() {
    ie_forEach();

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
            data: ['月销售额', '月退货额', '月实际销售额', '月差额', '月完成率', '季度销售额', '季度差额', '季度完成率', '年销售额', '年差额', '年完成率'],
            selected: {
                '月销售额': false,
                '月退货额': false,
                '月实际销售额': true,
                '月差额': false,
                '月完成率': false,
                '季度销售额': false,
                '季度差额': false,
                '季度完成率': false,
                '年销售额': false,
                '年差额': false,
                '年完成率': false
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
            type: 'line',
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
            type: 'line',
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
            type: 'line',
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
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'bottom'
                    }
                }
            },
            data: monthChas[e]
        }, {
            name: '月完成率',
            stack: '月份',
            type: 'line',
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
            data: monthWcls[e]
        }, {
            name: '季度销售额',
            stack: '季度',
            type: 'line',
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
            type: 'line',
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
            type: 'line',
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
        }, {
            name: '年销售额',
            stack: '年份',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: yearDatas[e],
            markLine: {
                data: lines3[e]
            }
        }, {
            name: '年差额',
            stack: '年份',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'bottom'
                    }
                }
            },
            data: yearChaDatas[e]
        }, {
            name: '年完成率',
            stack: '年份',
            type: 'line',
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
            data: yearWcls[e]
        }]
    };

    var myChart = echarts.init(document.getElementById('main' + e), 'macarons');
    myChart.setOption(option);
    mains.push(myChart);
});

cycles.forEach(function DrawEChart(v, e) {
    var option = {
        title: {
            text: syear + '年度部门' + v + '销售汇总',
            subtext: '个数:' + d_pids.length
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
            data: ['销售额', '差额', '完成率'],
            selected: {
                '销售额': false,
                '差额': false,
                '完成率': true
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
                        var hh = (d_pnames.length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                        if (hh < 300) {
                            hh = 300;
                        }
                        $('#cycles' + e).css("height", hh);

                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>部门</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = d_pids.length; m < g; m++) {
                            table += '<tr><td>' + d_pnames[m] + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m].value;
                                if (n == 2) val += '%';
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
            name: '销售额',
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
            data: yearDepDatas[e]
        }, {
            name: '差额',
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
            data: yearDepChaDatas[e]
        }, {
            name: '完成率',
            stack: '月份',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                        formatter: function (params, ticket, callback) {
                            if (params.data.value != undefined) {
                                return params.data.value + '%'
                            }
                            else {
                                return params.data + '%'
                            }
                        },
                    }
                }
            },
            data: yearDepWcls[e],
            markLine: {
                data: yearDepWclLines[e]
            }
        }]
    };

    var myChartDep = echarts.init(document.getElementById('cycles' + e), 'macarons');
    myChartDep.setOption(option);
    mains.push(myChartDep);
});
}

$(window).resize(function () {
    mains.forEach(function echartsHight(v, e) {
        v.resize();

    })
});

