var subtext = '';//副标题
var axisData = new Array(); //x轴
var quarterColors = ['#ffb6c1', '#20b2aa', '#ffa07a', '#87cefa'];
var baseColor = '#00ff00';
var planColor = '#ff1493';

var admin_user_name;
var name;

var monthcount = 12; //月份天数
var quarter_two1 = 3; //第二季度起
var quarter_three1 = 6; //第三季度起
var quarter_four1 = 9; //第四季度起

var year_base = 0; //日基数
var quarter_base = 0; //季度基数
var month_base = 0; //月基数

var year_plan = 0; //日计划
var quarter_plan = 0; //季度计划
var month_plan = 0; //月计划

var lines = new Array(); //日基数线
var lines2 = new Array(); //季度计划线
var quarterPoint = new Array(); //季度奖
var lines3 = new Array(); //月计划线

//月
var saleData = new Array(); //销售数据
var backData = new Array(); //退货数据
var saleBackData = new Array(); //月实际数据
var monthChas = new Array();
var monthWcls = new Array();
//月和
var saleDataSum = 0;
var backDataSum = 0;
var saleBackDataSum = 0;
//季度
var quarterDataColor = new Array();//各季度累计数据和，颜色，二维数组
var quarterData = new Array(); //季度销售额
var quarterChaData = new Array(); //季度差额
var quarterWcl = new Array(); //季度完成率
//年
var yearDatas = new Array();
var yearChas = new Array();
var yearWcls = new Array();

function clearData() {
    year_base = 0; //日基数
    quarter_base = 0; //季度基数
    month_base = 0; //月基数

    month_plan = 0; //日计划
    quarter_plan = 0; //季度计划
    month_plan = 0; //月计划

    lines = []; //清空日基数线
    lines2 = []; //清空季度计划线
    quarterPoint = [];
    lines3 = []; //清空月计划线

    //月
    saleData = [];
    backData = [];
    saleBackData = [];
    monthChas = [];
    monthWcls = [];
    //月和
    saleBackDataSum = 0;
    saleDataSum = 0;
    backDataSum = 0;

    quarterDataColor=[];
    quarterData = [];
    quarterChaData = [];
    quarterWcl = [];

    yearDatas = [];
    yearChas = [];
    yearWcls = [];
}

//个人每日销售退货量

function getMonthSaleBackData(GridData) {
    //初始化
    for (var i = 0; i < monthcount; i++) {
        saleData[i] = 0;
        backData[i] = 0;
        saleBackData[i] = 0;
    }
    //赋值
    for (var j = 0; j < GridData.Rows.length; j++) {
        if (j == 0) {
            admin_user_name = GridData.Rows[j].admin_user_name;
            name = GridData.Rows[j].name;
            //基数线
            year_base = parseFloat(parseFloat(GridData.Rows[j].year_base).toFixed());
            quarter_base = parseFloat((year_base / 4).toFixed()); //季度线
            month_base = parseFloat((year_base / monthcount).toFixed());//年线

            getLines('月基线', month_base, baseColor, axisData[length - 1], lines);
            getLines('季度基线', quarter_base, baseColor, axisData[length - 1], lines2);
            getLines('年基线', year_base, baseColor, axisData[length - 1], lines3);
            //计划线
            year_plan = parseFloat(parseFloat(GridData.Rows[j].year_plan).toFixed());
            quarter_plan = parseFloat((year_plan / 4).toFixed()); //季度线
            month_plan = parseFloat((year_plan / monthcount).toFixed());//年线

            getLines('月计划线', month_plan, planColor, axisData[length - 1], lines);
            getLines('季度计划线', quarter_plan, planColor, axisData[length - 1], lines2);
            getLines('年计划线', year_plan, planColor, axisData[length - 1], lines3);

        }
        var orderDate = parseInt(GridData.Rows[j].datetime) - 1; //从1日开始，-1到角标0
        saleBackData[orderDate] = parseFloat(GridData.Rows[j].realmoney.toFixed());
        saleBackDataSum += parseFloat(GridData.Rows[j].realmoney.toFixed());

        saleData[orderDate] = parseFloat(GridData.Rows[j].salemoney.toFixed());
        saleDataSum += parseFloat(GridData.Rows[j].salemoney.toFixed());

        backData[orderDate] = parseFloat(GridData.Rows[j].backmoney.toFixed());
        backDataSum += parseFloat(GridData.Rows[j].backmoney.toFixed());
    }
}


//初始化季度数据，颜色
function initQuarterData() {
    var quarterSum1 = 0; //季度sum1
    var quarterSum2 = 0; //季度sum2
    var quarterSum3 = 0; //季度sum3
    var quarterSum4 = 0; //季度sum4
    for (var j = 0; j < quarter_two1; j++) {
        quarterSum1 += parseFloat(saleBackData[j].toFixed());
        quarterDataColor[j] = new Array();
        quarterDataColor[j][0] = quarterSum1;
        quarterDataColor[j][1] = quarterColors[0];
    }
    for (var j = quarter_two1; j < quarter_three1; j++) {
        quarterSum2 += parseFloat(saleBackData[j].toFixed());
        quarterDataColor[j] = new Array();
        quarterDataColor[j][0] = quarterSum2;
        quarterDataColor[j][1] = quarterColors[1];
    }
    for (var j = quarter_three1; j < quarter_four1; j++) {
        quarterSum3 += parseFloat(saleBackData[j].toFixed());
        quarterDataColor[j] = new Array();
        quarterDataColor[j][0] = quarterSum3;
        quarterDataColor[j][1] = quarterColors[2];
    }
    for (var j = quarter_four1; j < monthcount; j++) {
        quarterSum4 += parseFloat(saleBackData[j].toFixed());
        quarterDataColor[j] = new Array();
        quarterDataColor[j][0] = quarterSum4;
        quarterDataColor[j][1] = quarterColors[3];
    }
    showMonthQuarterData();
}

//根据初始化出来的季度数据，去渲染每一个季度数据，四个季度的和
function showMonthQuarterData() {
    for (var j = 0; j < monthcount; j++) {
        getColorAndValue(quarterData, quarterDataColor[j][0], quarterDataColor[j][1]);
        getColorAndValue(quarterChaData, quarterDataColor[j][0] - quarter_plan, quarterDataColor[j][1]);
        getColorAndValue(quarterWcl, parseFloat((quarterDataColor[j][0] / quarter_plan * 100).toFixed()), quarterDataColor[j][1]);
    }
}

//画点
function showQuarterPoint() {
    if (quarterChaData[quarter_two1 - 1].value > 0) {
        getPoint('1季度奖', quarter_two1 - 1, quarterDataColor[quarter_two1 - 1][0]);
    }
    if (quarterChaData[quarter_three1 - 1].value > 0) {
        getPoint('2季度奖', quarter_three1 - 1, quarterDataColor[quarter_three1 - 1][0]);
    }
    if (quarterChaData[quarter_four1 - 1].value > 0) {
        getPoint('3季度奖', quarter_four1 - 1, quarterDataColor[quarter_four1 - 1][0]);
    }
    if (quarterChaData[monthcount - 1].value > 0) {
        getPoint('4季度奖', monthcount - 1, quarterDataColor[monthcount - 1][0]);
    }

}

//初始化月份数据
function initMonthData() {
    var yearSum = 0; //季度sum1
    for (var j = 0; j < monthcount; j++) {
        monthChas[j] = parseFloat((saleBackData[j] - month_plan).toFixed());
        monthWcls[j] = parseFloat((saleBackData[j] / month_plan * 100).toFixed());

        yearSum += parseFloat(saleBackData[j].toFixed());
        yearDatas[j] = yearSum;
        yearChas[j] = parseFloat((yearDatas[j] - year_plan).toFixed());
        yearWcls[j] = parseFloat((yearDatas[j] / year_plan * 100).toFixed()); //年完成率累计
    }
}

//副标题
function getSubText() {
    if (lines.length > 0 && lines2.length > 0 && lines3.length > 0) {
        subtext = '月基数：' + lines[0].value + '\n月计划：' + lines[2].value +
        '\n\n季度基数：' + lines2[0].value + '\n季度计划：' + lines2[2].value +
        '\n\n年基数：' + lines3[0].value + '\n年计划：' + lines3[2].value +
        '\n\n年销量：' + saleDataSum + '\n年退货：' + backDataSum + '\n年实际：' + saleBackDataSum + '\n年完成率：' + parseFloat((saleBackDataSum / lines3[2].value * 100).toFixed()) + '%'
    }
    else {
        subtext = '\n\n年销量：' + saleDataSum + '\n年退货：' + backDataSum + '\n年实际：' + saleBackDataSum
    }
}

//画图
function DrawEChart() {
    $("#main").css("height", 680);
    var option = {
        title: {
            text: admin_user_name + '_' + name + '_' + $("#syear").val() + '年度销售年报',
            subtext: subtext

        },
        grid: {
            x: 180,//靠左200像素
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
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
            data: saleData
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
            data: backData
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
            data: saleBackData,
            markLine: {
                data: lines
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
            data: monthChas
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
            data: monthWcls
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
            data: quarterData,
            markLine: {
                data: lines2
            },
            markPoint: {
                data: quarterPoint
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
            data: quarterChaData
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
            data: quarterWcl
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
            data: yearDatas,
            markLine: {
                data: lines3
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
            data: yearChas
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
            data: yearWcls
        }]
    };

    var myChart = echarts.init(document.getElementById('main'), 'macarons');
    myChart.setOption(option);
    window.onresize = myChart.resize;//随屏幕的大小改变自适应

}