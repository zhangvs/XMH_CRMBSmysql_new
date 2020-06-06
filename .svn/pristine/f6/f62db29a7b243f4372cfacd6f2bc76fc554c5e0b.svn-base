var mains = new Array();//画图main数组
var subtext = '';//副标题
var axisDatas = new Array(); //x轴
var nodeColors = ['#ffb6c1', '#20b2aa', '#ffa07a', '#87cefa'];//节点颜色
var monthColor = '#7CCD7C';
var d_pidColor = '#006699';
var baseColor = '#00ff00';
var planColor = '#ff1493'
var cycles = ['月', '第一节点', '第二节点', '第三节点', '第四节点']//周期，根据周期循环展示各部门对比的图像

var d_pids = new Array();//部门ids数组
var d_pnames = new Array();//部门名ids数组
var d_No = 0;

var year;
var smonth;
var daycount = 0; //月份天数

var node_one ; //第一节点起
var node_two; //第二节点起
var node_three; //第三节点起
var node_four; //第四节点起

//基数
var date_base = new Array();
var node_base = new Array();
var month_base = new Array();
//计划
var date_plan = new Array();
var node_plan = new Array();
var month_plan = new Array();
//线
var date_lines = new Array(); //日基数线
var node_lines = new Array(); //节点计划线
var node_Point = new Array(); //节点奖
var month_lines = new Array(); //月计划线


var saleData = new Array(); //日销售数据
var backData = new Array(); //日退货数据
var saleBackData = new Array(); //日实际数据
var dayWcl = new Array();
var dayCha = new Array();

var saleDataSum = new Array();//日销售累加
var backDataSum = new Array();//日退货累加
var saleBackDataSum = new Array();//日实际累加

var nodeDataColor = new Array();//节点累计数据和，颜色，二维数组
var nodeData = new Array(); //节点销售额
var nodeChaData = new Array(); //节点差额
var nodeWclData = new Array(); //节点完成率

var monthSum = 0;
var monthDatas = new Array();//月累计数组
var monthChaDatas = new Array();
var monthWcls = new Array();

var monthDepDatas = new Array();
var monthDepChaDatas = new Array();
var monthDepWcls = new Array();
var monthDepWclLines = new Array();

function clearData() {
    getDateCount();

    mains = [];
    $("#form1").html("");
    d_pids = [];
    d_pnames = [];

    //基数
    date_base = [];
    node_base = [];
    month_base = [];
    //计划
    date_plan = [];
    node_plan = [];
    month_plan = [];
    //线
    date_lines = []; 
    node_lines = []; 
    month_lines = []; 

    //日
    saleData = [];
    backData = [];
    saleBackData = [];
    dayCha = [];
    dayWcl = [];
    //日和
    saleBackDataSum = [];
    saleDataSum = [];
    backDataSum = [];
    //节点
    nodeData = [];
    nodeDataColor = [];
    nodeChaData = [];
    nodeWclData = [];
    node_Point = [];
    //月
    monthDatas = [];
    monthChaDatas = [];
    monthWcls = [];

    //月，节点分部门展示
    monthDepDatas = [];
    monthDepChaDatas = [];
    monthDepWcls = [];
    monthDepWclLines = [];
}



//个人每日销售退货量
function getMonthSaleBackData(GridData) {

    //初始化
    for (var r = 0; r < GridData.Rows.length; r++) {
        var d_pid = GridData.Rows[r].d_pid;
        //分别初始话部门月份天数据
        if ($.inArray(d_pid, d_pids) < 0) {
            d_No = d_pids.push(GridData.Rows[r].d_pid) - 1;//把部门id分别加入到数组内
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

            for (var i = 0; i < daycount; i++) {
                saleData[d_No][i] = 0;
                backData[d_No][i] = 0;
                saleBackData[d_No][i] = 0;
            }

            date_lines[d_No] = new Array();
            node_lines[d_No] = new Array();
            month_lines[d_No] = new Array();

            month_base[d_No] = parseFloat(GridData.Rows[r].dep_month_base.toFixed());
            node_base[d_No] = parseFloat((GridData.Rows[r].dep_month_base.toFixed() / 4).toFixed()); //取前月份的计划除以4
            date_base[d_No] = parseFloat((GridData.Rows[r].dep_month_base.toFixed() / daycount).toFixed());

            getLines('日基线', date_base[d_No], baseColor, axisDatas[length - 1], date_lines[d_No]);
            getLines('节点基线', node_base[d_No], baseColor, axisDatas[length - 1], node_lines[d_No]);
            getLines('月基线', month_base[d_No], baseColor, axisDatas[length - 1], month_lines[d_No]);

            month_plan[d_No] = parseFloat(GridData.Rows[r].dep_month_plan.toFixed());
            node_plan[d_No] = parseFloat((GridData.Rows[r].dep_month_plan / 4).toFixed()); //取前月份的计划除以4
            date_plan[d_No] = parseFloat((GridData.Rows[r].dep_month_plan / daycount).toFixed());

            getLines('日计划线', date_plan[d_No], planColor, axisDatas[length - 1], date_lines[d_No]);
            getLines('节点计划线', node_plan[d_No], planColor, axisDatas[length - 1], node_lines[d_No]);
            getLines('月计划线', month_plan[d_No], planColor, axisDatas[length - 1], month_lines[d_No]);

        }
        $("#form1").append("<div id='main" + d_No + "' ></div>");

        var orderDate = parseInt(GridData.Rows[r].orderdate) - 1; //从1日开始，-1到角标0

        saleBackData[d_No][orderDate] = parseFloat(GridData.Rows[r].realmoney.toFixed());
        saleBackDataSum[d_No] += saleBackData[d_No][orderDate];

        saleData[d_No][orderDate] = parseFloat(GridData.Rows[r].salemoney.toFixed());
        saleDataSum[d_No] += saleData[d_No][orderDate];

        backData[d_No][orderDate] = parseFloat(GridData.Rows[r].backmoney.toFixed());
        backDataSum[d_No] += backData[d_No][orderDate];
    }
}




//初始化节点数据，颜色
function initNodeData() {
    for (var i = 0; i < d_pids.length; i++) {
        var nodeSum1 = 0; //节点sum1
        var nodeSum2 = 0; //节点sum2
        var nodeSum3 = 0; //节点sum3
        var nodeSum4 = 0; //节点sum4
        nodeDataColor[i] = new Array();
        for (var j = 0; j < node_one; j++) {
            nodeSum1 += parseFloat(saleBackData[i][j]);
            nodeDataColor[i][j] = new Array();
            nodeDataColor[i][j][0] = nodeSum1;
            nodeDataColor[i][j][1] = nodeColors[0];
        }
        for (var j = node_one; j < node_two; j++) {
            nodeSum2 += parseFloat(saleBackData[i][j]);
            nodeDataColor[i][j] = new Array();
            nodeDataColor[i][j][0] = nodeSum2;
            nodeDataColor[i][j][1] = nodeColors[1];
        }
        for (var j = node_two; j < node_three; j++) {
            nodeSum3 += parseFloat(saleBackData[i][j]);
            nodeDataColor[i][j] = new Array();
            nodeDataColor[i][j][0] = nodeSum3;
            nodeDataColor[i][j][1] = nodeColors[2];
        }
        for (var j = node_three; j < node_four; j++) {
            nodeSum4 += parseFloat(saleBackData[i][j]);
            nodeDataColor[i][j] = new Array();
            nodeDataColor[i][j][0] = nodeSum4;
            nodeDataColor[i][j][1] = nodeColors[3];
        }
    }
    showMonthNodeData();
}


//根据初始化出来的节点数据，去渲染每一个节点数据，四个节点的和
function showMonthNodeData() {
    for (var i = 0; i < d_pids.length; i++) {
        nodeData[i] = new Array();//节点实际销售
        nodeChaData[i] = new Array();
        nodeWclData[i] = new Array();
        for (var j = 0; j < daycount; j++) {
            getColorAndValue(nodeData[i], nodeDataColor[i][j][0], nodeDataColor[i][j][1]);
            getColorAndValue(nodeChaData[i], nodeDataColor[i][j][0] - node_plan[i], nodeDataColor[i][j][1]);
            getColorAndValue(nodeWclData[i], parseFloat((nodeDataColor[i][j][0] / node_plan[i] * 100).toFixed()), nodeDataColor[i][j][1]);
        }

        // 画点
        node_Point[i] = new Array();
        if (nodeChaData[i][node_one - 1].value > 0) {
            getPoint(node_Point[i], '1节点奖', node_one, nodeDataColor[i][node_one - 1][0]);
        }
        if (nodeChaData[i][node_two - 1].value > 0) {
            getPoint(node_Point[i], '2节点奖', node_two, nodeDataColor[i][node_two - 1][0]);
        }
        if (nodeChaData[i][node_three - 1].value > 0) {
            getPoint(node_Point[i], '3节点奖', node_three, nodeDataColor[i][node_three - 1][0]);
        }
        if (nodeChaData[i][node_four - 1].value > 0) {
            getPoint(node_Point[i], '4节点奖', node_four, nodeDataColor[i][node_four - 1][0]);
        }
    }

}



//初始化月份累加数据
function initMonthData() {

    for (var i = 0; i < d_pids.length; i++) {
        dayCha[i] = new Array();
        dayWcl[i] = new Array();

        monthSum = 0;
        monthDatas[i] = new Array();
        monthChaDatas[i] = new Array();
        monthWcls[i] = new Array();

        for (var j = 0; j < daycount; j++) {
            dayCha[i][j] = parseFloat((saleBackData[i][j] - date_plan[i]).toFixed());
            dayWcl[i][j] = parseFloat((saleBackData[i][j] / date_plan[i] * 100).toFixed());

            monthSum += parseFloat((saleBackData[i][j]).toFixed());//月销售累计
            monthDatas[i][j] = monthSum;
            monthChaDatas[i][j] = parseFloat((monthDatas[i][j] - month_plan[i]).toFixed());//月差额累计
            monthWcls[i][j] = parseFloat((monthDatas[i][j] / month_plan[i] * 100).toFixed()); //月完成率累计
        }
    }
}

//副标题
function getSubText(e) {
    if (date_lines[e].length > 0 && node_lines[e].length > 0 && month_lines[e].length > 0 && node_plan[e] != 0 && node_base[e] != 0) {
        subtext = '日基数：' + date_lines[e][0].value + '\n日计划：' + date_lines[e][2].value +
        '\n\n节点基数：' + node_lines[e][0].value + '\n节点计划：' + node_lines[e][2].value +
        '\n\n月基数：' + month_lines[e][0].value + '\n月计划：' + month_lines[e][2].value +
        '\n\n月销量：' + saleDataSum[e] + '\n月退货：' + backDataSum[e] + '\n月实际：' + saleBackDataSum[e]+'\n月完成率：' + parseFloat((saleBackDataSum[e] / month_lines[e][2].value * 100).toFixed()) + '%'
    }
    else {
        subtext = '\n\n月销量：' + saleDataSum[e] + '\n月退货：' + backDataSum[e] + '\n月实际：' + saleBackDataSum[e]
    }
    return subtext;
}


//月，节点，分部门综合展示
function getDepData(c, d_pid, sale, cha, wcl) {
    var color_c;
    if (c==0) {
        color_c = monthColor;
    }
    else {
        color_c = nodeColors[c - 1];
    }
    
    if (!isFinite(wcl)) {
        wcl = 0;
    }
    
    //销售数据，差额数据,完成率数据
    if (d_pid == 0) {
        monthDepDatas[c].push({ value: sale, itemStyle: { normal: { color: d_pidColor } } });
        monthDepChaDatas[c].push({ value: cha, itemStyle: { normal: { color: d_pidColor } } });
        monthDepWcls[c].push({ value: wcl, itemStyle: { normal: { color: d_pidColor } } });
        getLines('均线', wcl, d_pidColor, d_pnames[length - 1], monthDepWclLines[c]);
    }
    else {
        monthDepDatas[c].push({ value: sale, itemStyle: { normal: { color: color_c } } });
        monthDepChaDatas[c].push({ value: cha, itemStyle: { normal: { color: color_c } } });
        monthDepWcls[c].push({ value: wcl, itemStyle: { normal: { color: color_c } } });
    }
}

function initMonthDepData() {
    for (var c = 0; c < cycles.length; c++) {
        $("#main0").before("<div id='cycles" + c + "' ></div>");
        $("#cycles" + c).css("height", 300);
        monthDepDatas[c] = new Array();
        monthDepChaDatas[c] = new Array();
        monthDepWcls[c] = new Array();
        monthDepWclLines[c] = new Array();
    }
    for (var i = 0; i < d_pids.length; i++) {
        //月，循环加入每一个部门
        getDepData(0,d_pids[i], parseFloat(monthDatas[i][daycount - 1].toFixed()), parseFloat(monthChaDatas[i][daycount - 1].toFixed()), parseFloat(monthWcls[i][daycount - 1].toFixed()));//月
        getDepData(1, d_pids[i], parseFloat(nodeData[i][node_one - 1].value.toFixed()), parseFloat(nodeChaData[i][node_one - 1].value.toFixed()), parseFloat(nodeWclData[i][node_one - 1].value.toFixed()));//节点1
        getDepData(2, d_pids[i], parseFloat(nodeData[i][node_two - 1].value.toFixed()), parseFloat(nodeChaData[i][node_two - 1].value.toFixed()), parseFloat(nodeWclData[i][node_two - 1].value.toFixed()));//节点2
        getDepData(3, d_pids[i], parseFloat(nodeData[i][node_three - 1].value.toFixed()), parseFloat(nodeChaData[i][node_three - 1].value.toFixed()), parseFloat(nodeWclData[i][node_three - 1].value.toFixed()));//节点3
        getDepData(4, d_pids[i], parseFloat(nodeData[i][node_four - 1].value.toFixed()), parseFloat(nodeChaData[i][node_four - 1].value.toFixed()), parseFloat(nodeWclData[i][node_four - 1].value.toFixed()));//节点4
    }
}

function drawForEach() {
    ie_forEach();
//画图
d_pnames.forEach(function DrawEChart(v, e) {
    $("#main" + e).css("height", 400);
    var option = {
        title: {
            text: v + '_' + smonth + '月份销售月报',
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
            data: ['日销售额', '日退货额', '日实际销售额', '日差额', '日完成率', '节点销售额', '节点差额', '节点完成率', '月销售额', '月差额', '月完成率'],
            selected: {
                '日销售额': false,
                '日退货额': false,
                '日实际销售额': false,
                '日差额': false,
                '日完成率': false,
                '节点销售额': true,
                '节点差额': false,
                '节点完成率': false,
                '月销售额': false,
                '月差额': false,
                '月完成率': false
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
                        for (var m = 0, g = axisDatas.length; m < g; m++) {
                            table += '<tr><td>' + axisDatas[m].value + '</td>';
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
            axisLabel: {
                formatter: function (v) {
                    return v+'日'
                }
            },
            data: axisDatas
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
            data: saleBackData[e],
            markLine: {
                data: date_lines[e]
            }
        }, {
            name: '日差额',
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
            data: dayCha[e]
        }, {
            name: '日完成率',
            stack: '日期',
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
            data: dayWcl[e]
        }, {
            name: '节点销售额',
            stack: '节点',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: nodeData[e],
            markLine: {
                data: node_lines[e]
            },
            markPoint: {
                data: node_Point[e]
            }
        }, {
            name: '节点差额',
            stack: '节点',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'bottom'
                    }
                }
            },
            data: nodeChaData[e]
        }, {
            name: '节点完成率',
            stack: '节点',
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
            data: nodeWclData[e]
        }, {
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
            data: monthDatas[e],
            markLine: {
                data: month_lines[e]
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
            data: monthChaDatas[e]
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
            data: monthWcls[e]
        }]
    };

    var myChart = echarts.init(document.getElementById('main' + e), 'macarons');
    myChart.setOption(option);
    mains.push(myChart);
});


cycles.forEach(function DrawEChart(v, e) {
    var option = {
        title: {
            text: smonth + '月份部门' + v + '销售汇总',
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
                        var hh = (d_pnames.length + 1) * 19+80;//上标题和下按钮各占40=80，每行占19，加列标题行1
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
            data: monthDepDatas[e]
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
            data: monthDepChaDatas[e]
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
            data: monthDepWcls[e],
            markLine: {
                data: monthDepWclLines[e]
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





