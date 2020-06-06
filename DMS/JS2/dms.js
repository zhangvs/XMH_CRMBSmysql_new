var mains = new Array();//画图main数组
var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height:812

var subtext = '';//副标题
var axisDatas = new Array(); //x轴
var baseColor = '#00ff00';
var planColor = '#ff1493';
var taskColor = '#3300ff';
var groupColors = ['#ffb6c1', '#20b2aa', '#ffa07a', '#87cefa'];//节点颜色
var yearCycles = ['年', '第一季度', '第二季度', '第三季度', '第四季度']//年周期
var monthCycles = ['月', '第一节点', '第二节点', '第三节点', '第四节点']//月周期
var cycleColors = ['#7ccd7c', '#ffb6c1', '#20b2aa', '#ffa07a', '#87cefa'];

var monthUnits = ['日', '节点', '月'];
var monthLegendDatas = ['日销售额', '日退货额', '日实际销售额', '日差额', '日完成率', '节点销售额', '节点差额', '节点完成率', '月销售额', '月差额', '月完成率'];
var monthLegendBools = { '日销售额': false, '日退货额': false, '日实际销售额': false, '日差额': false, '日完成率': false, '节点销售额': true, '节点差额': false, '节点完成率': false, '月销售额': false, '月差额': false, '月完成率': false };

var yearUnits = ['月', '季', '年'];
var yearLegendDatas = ['月销售额', '月退货额', '月实际销售额', '月差额', '月完成率', '季销售额', '季差额', '季完成率', '年销售额', '年差额', '年完成率'];
var yearLegendBools = { '月销售额': false, '月退货额': false, '月实际销售额': false, '月差额': false, '月完成率': false, '季销售额': true, '季差额': false, '季完成率': false, '年销售额': false, '年差额': false, '年完成率': false };

var group_nodes = new Array();
var group_quarters = [3, 6, 9, 12];//季度默认节点

var singlecount = 0; //月份天数
var group_one1 = 1; //第一节点起
var group_two1, group_three1, group_four1; //第二节点起

var single_base = 0; //日基数
var group_base = 0; //节点基数
var whole_base = 0; //月基数

var single_plan = 0; //日计划
var group_plan = 0; //节点计划
var whole_plan = 0; //月计划

var single_task = 0; //日任务
var group_task = 0; //节点任务
var whole_task = 0;//月任务

var single_bases = new Array(); //日基数
var group_bases = new Array(); //节点基数
var whole_bases = new Array(); //月基数

var single_plans = new Array(); //日计划
var group_plans = new Array(); //节点计划
var whole_plans = new Array(); //月计划

var single_tasks = new Array(); //日任务
var group_tasks = new Array(); //节点任务
var whole_tasks = new Array(); //月任务

var single_lines = new Array(); //日基数线
var group_lines = new Array(); //节点计划线
var group_Points = new Array(); //节点奖
var whole_lines = new Array(); //月计划线



var singleSales = new Array(); //日销售数据
var singleBacks = new Array(); //日退货数据
var singleReals = new Array(); //日实际数据
var singleWcls = new Array();
var singleChas = new Array();

var singleSalesSum = 0; //日销售累加
var singleBacksSum = 0;//日退货累加
var singleRealsSum = 0;//日实际累加

var singleSalesSums = new Array(); //日销售数据和
var singleBacksSums = new Array(); //日退货数据和
var singleRealsSums = new Array(); //日实际数据和

var groupAdds = new Array(); //节点销售额
var groupChas = new Array(); //节点差额
var groupWcls = new Array(); //节点完成率
var groupZzbs = new Array(); //节点总占比

var wholeAdds = new Array();//月累计数组
var wholeChas = new Array();
var wholeWcls = new Array();
var wholeZzbs = new Array();



var cycleCompareAdds = new Array();//周期内累加和对比
var cycleCompareChas = new Array();//周期内差对比
var cycleCompareWcls = new Array();//周期内完成率对比
var cycleCompareZzbs = new Array();//周期内完成率对比

var cycleSalesSums = new Array();//周期内销售累加和对比
var cycleBacksSums = new Array();//周期内退货累加和对比
var cycleRealsSums = new Array();//周期内实际累加和对比

function clearData() {
    mains = [];
    $("#form1").html("");
    //基数
    single_base = 0;
    group_base = 0;
    whole_base = 0;
    //计划
    single_plan = 0;
    group_plan = 0;
    whole_plan = 0;
    //任务
    single_task = 0;
    group_task = 0;
    whole_task = 0;

    //基数
    single_bases = [];
    group_bases = [];
    whole_bases = [];
    //计划
    single_plans = [];
    group_plans = [];
    whole_plans = [];

    //任务
    single_tasks = [];
    group_tasks = [];
    whole_tasks = [];

    //线,点
    single_lines = [];
    group_lines = [];
    group_Points = [];
    whole_lines = [];

    //日
    singleSales = [];
    singleBacks = [];
    singleReals = [];
    singleWcls = [];
    singleChas = [];
    //日和
    singleSalesSum = 0;
    singleBacksSum = 0;
    singleRealsSum = 0;
    //节点
    groupAdds = [];
    groupChas = [];
    groupWcls = [];
    groupZzbs = [];
    //月
    wholeAdds = [];
    wholeChas = [];
    wholeWcls = [];
    wholeZzbs = [];

}
var syear, smonth;
//日期天数
function getDateCount(syear, smonth) {
    //月
    if (smonth.length == 1) {
        smonth = '0' + smonth;
    }
    //天数
    var day = new Date(syear, smonth, 0);//构造一个日期对象
    return day.getDate();//获取天数
}


function getGroupNode(data) {
    group_nodes = data;
}

//x轴
function showAxis() {
    if (group_nodes.length == 0) {
        group_nodes = group_quarters;
        singlecount = 12;
    }
    axisDatas = [];

    for (var j = 0; j < group_nodes[0]; j++) {
        getAxisDatas(j + 1, groupColors[0], axisDatas);
    }
    for (var j = group_nodes[0]; j < group_nodes[1]; j++) {
        getAxisDatas(j + 1, groupColors[1], axisDatas);
    }
    for (var j = group_nodes[1]; j < group_nodes[2]; j++) {
        getAxisDatas(j + 1, groupColors[2], axisDatas);
    }
    for (var j = group_nodes[2]; j < group_nodes[3]; j++) {
        getAxisDatas(j + 1, groupColors[3], axisDatas);
    }
}


//渲染数据区间颜色
function getAxisDatas(single, color, array) {
    var val = {
        value: single,
        textStyle: {
            color: color
        }
    };
    array.push(val);

}

//画线
function getLines(lineName, lineValue, lineColor, xAxisEnd, lineArray) {
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
        xAxis: xAxisEnd,
        yAxis: lineValue
    };
    lineArray.push(qd);
    lineArray.push(zd);
}

//渲染节点,哪个节点数组，地标，数据，颜色
function getColorAndValue(array, value, color) {
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

//渲染季度奖点
function getPoint(array, name, xAxis, value) {
    var dian = {
        name: name,
        value: value,
        xAxis: xAxis,
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
    array.push(dian);
}


function ie_forEach() {
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
}

//-------------------------------------------------------------------------处理月内的日，节点数据

//基数，计划，线
function getBasePlanLine(_id, whole_base, whole_plan, whole_task) {
    //初始化时间段内的基数计划
    whole_bases[_id] = new Array();//当前品牌的月基数
    group_bases[_id] = new Array();//当前品牌的节点计划
    single_bases[_id] = new Array();//当前品牌的日基数

    whole_plans[_id] = new Array();//当前品牌的月计划
    group_plans[_id] = new Array();//当前品牌的节点计划
    single_plans[_id] = new Array();//当前品牌的日计划

    whole_tasks[_id] = new Array();//当前品牌的月计划
    group_tasks[_id] = new Array();//当前品牌的节点计划
    single_tasks[_id] = new Array();//当前品牌的日计划
    //初始化线
    single_lines[_id] = new Array(); //当前品牌的基线二维数组
    group_lines[_id] = new Array(); //当前品牌的基线二维数组
    whole_lines[_id] = new Array();//当前品牌的计划线二维数组

    //计算节点，日
    group_base = parseFloat((whole_base / 4).toFixed()); //取前月份的计划除以4
    single_base = parseFloat((whole_base / singlecount).toFixed());

    group_plan = parseFloat((whole_plan / 4).toFixed()); //取前月份的计划除以4
    single_plan = parseFloat((whole_plan / singlecount).toFixed());

    group_task = parseFloat((whole_task / 4).toFixed()); //取前月份的计划除以4
    single_task = parseFloat((whole_task / singlecount).toFixed());
    //赋值
    whole_bases[_id] = whole_base;
    group_bases[_id] = group_base;
    single_bases[_id] = single_base;

    whole_plans[_id] = whole_plan;
    group_plans[_id] = group_plan;
    single_plans[_id] = single_plan;

    whole_tasks[_id] = whole_task;
    group_tasks[_id] = group_task;
    single_tasks[_id] = single_task;

    //给当前品牌画线
    getLines('基线', single_base, baseColor, singlecount - 1, single_lines[_id]);
    getLines('基线', group_base, baseColor, singlecount - 1, group_lines[_id]);
    getLines('基线', whole_base, baseColor, singlecount - 1, whole_lines[_id]);

    getLines('计划线', single_plan, planColor, singlecount - 1, single_lines[_id]);
    getLines('计划线', group_plan, planColor, singlecount - 1, group_lines[_id]);
    getLines('计划线', whole_plan, planColor, singlecount - 1, whole_lines[_id]);

    getLines('任务线', single_task, taskColor, singlecount - 1, single_lines[_id]);
    getLines('任务线', group_task, taskColor, singlecount - 1, group_lines[_id]);
    getLines('任务线', whole_task, taskColor, singlecount - 1, whole_lines[_id]);
}


function initSingleData(_id) {
    singleReals[_id] = new Array();//当前品牌的实际销售额二维数组
    singleSales[_id] = new Array();//当前品牌的销售额二维数组
    singleBacks[_id] = new Array();//当前品牌的退货额二维数组
    singleChas[_id] = new Array();//当前品牌的任务差额
    singleWcls[_id] = new Array();//当前品牌的完成率

    //初始化当前坐标轴内每一天的数据为0
    for (var i = 0; i < singlecount; i++) {
        singleSales[_id][i] = 0;
        singleBacks[_id][i] = 0;
        singleReals[_id][i] = 0;
        singleChas[_id][i] = 0;
        singleWcls[_id][i] = 0;
    }
    //合计
    singleRealsSums[_id] = 0;
    singleSalesSums[_id] = 0;
    singleBacksSums[_id] = 0;
}
function getSingleDataValue(_id, rowData) {
    var d = parseInt(rowData.datetime) - 1; //获取日期字段，从1日开始，-1到角标0
    singleSales[_id][d] = parseFloat(rowData.salemoney.toFixed());//日销售额
    singleBacks[_id][d] = parseFloat(rowData.backmoney.toFixed());//日退货额
    singleReals[_id][d] = parseFloat(rowData.realmoney.toFixed());//日实际销售额
    singleChas[_id][d] = parseFloat((singleReals[_id][d] - single_plans[_id]).toFixed());//日差额
    singleWcls[_id][d] = parseFloat((singleReals[_id][d] / single_plans[_id] * 100).toFixed());//日完成率
    //日合计
    singleSalesSums[_id] += parseFloat(rowData.salemoney.toFixed());
    singleBacksSums[_id] += parseFloat(rowData.backmoney.toFixed());
    singleRealsSums[_id] += parseFloat(rowData.realmoney.toFixed());
}

//初始化节点数据，颜色
function initGroupData(array) {
    for (var _id = 0; _id < array.length; _id++) {
        groupAdds[_id] = new Array();
        groupChas[_id] = new Array();
        groupWcls[_id] = new Array();
        groupZzbs[_id] = new Array();
        group_Points[_id] = new Array();
        getGroupData(_id, 0, group_nodes[0], groupColors[0]);
        getGroupData(_id, group_nodes[0], group_nodes[1], groupColors[1]);
        getGroupData(_id, group_nodes[1], group_nodes[2], groupColors[2]);
        getGroupData(_id, group_nodes[2], group_nodes[3], groupColors[3]);
    }
}


function getGroupData(_id, begin, end, color) {
    var groupAdd = 0;
    var groupCha = 0;
    var groupWcl = 0;
    var groupZzb = 0;

    for (var j = begin; j < end; j++) {
        groupAdd += parseFloat(singleReals[_id][j]);
        groupCha = groupAdd - group_plans[_id];
        groupWcl = parseFloat((groupAdd / group_plans[_id] * 100).toFixed());
        groupZzb = parseFloat((groupAdd / group_tasks[_id] * 100).toFixed());

        getColorAndValue(groupAdds[_id], groupAdd, color);
        getColorAndValue(groupChas[_id], groupCha, color);
        getColorAndValue(groupWcls[_id], groupWcl, color);
        getColorAndValue(groupZzbs[_id], groupZzb, color);

    }
    if (groupCha > 0) {
        getPoint(group_Points[_id], '达标奖', end - 1, groupAdd);
    }
}


//初始化节点数据，颜色
function initWholeData(array) {
    var wholeSum = 0;
    for (var _id = 0; _id < array.length; _id++) {
        wholeSum = 0;
        wholeAdds[_id] = new Array();
        wholeChas[_id] = new Array();
        wholeWcls[_id] = new Array();
        wholeZzbs[_id] = new Array();
        for (var j = 0; j < singlecount; j++) {
            wholeSum += parseFloat(singleReals[_id][j]);
            wholeAdds[_id][j] = wholeSum;
            wholeChas[_id][j] = wholeSum - whole_plans[_id];
            wholeWcls[_id][j] = parseFloat((wholeSum / whole_plans[_id] * 100).toFixed());
            wholeZzbs[_id][j] = parseFloat((wholeSum / whole_tasks[_id] * 100).toFixed());
        }
    }
}


//画图
function dataDraw(codes, names, units, legendDatas, legendBools) {
    ie_forEach();
    names.forEach(function DrawEChart(v, e) {
        $("#form1").append("<a id='a_main" + e + "' href='#main" + e + "'> </a><div id='main" + e + "' style='height:400px' ></div>");
        var option = {
            title: {
                text: v + '(可点击查看详情)',
                link: '/DMS/ReportForm/dms_brand_details.aspx?syear=' + syear + '&smonth=' + smonth + '&codeId=' + codes[e] + '&rnd=' + Math.random(),
                subtext:
                    '' + units[2] + '总占比：' + parseFloat((singleRealsSums[e] / whole_tasks[e] * 100).toFixed()) + '%' +
                    '\n' + units[2] + '内部完成率：' + parseFloat((singleRealsSums[e] / whole_plans[e] * 100).toFixed()) + '%' +
                    '\n' + units[2] + '差额：' + parseFloat((singleRealsSums[e] - whole_plans[e]).toFixed()) +
                    '\n' + units[2] + '提成：' + parseFloat(((singleRealsSums[e] - whole_plans[e]) * bp_percentages[e] * 0.01).toFixed()) +
                    '\n\n' + units[2] + '销量：' + singleSalesSums[e] + '\n' + units[2] + '退货：' + singleBacksSums[e] + '\n' + units[2] + '实际：' + singleRealsSums[e] +
                    '\n\n\n' + units[2] + '总任务：' + whole_tasks[e] + '\n' + units[2] + '内部计划：' + whole_plans[e] + '\n' + units[2] + '内部基数：' + whole_bases[e] +
                    '\n\n' + units[1] + '总任务：' + group_tasks[e] + '\n' + units[1] + '内部计划：' + group_plans[e] + '\n' + units[1] + '内部基数：' + group_bases[e] +
                    '\n\n' + units[0] + '总任务：' + single_tasks[e] + '\n' + units[0] + '内部计划：' + single_plans[e] + '\n' + units[0] + '内部基数：' + single_bases[e]
            },
            grid: {
                x: 230,//靠左200像素
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter: function (params, ticket, callback) {
                    var res = v + params[0].name + units[0];
                    for (var i = 0, l = params.length; i < l; i++) {
                        res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                    }
                    return res
                }
            },
            legend: {
                data: legendDatas,
                selected: legendBools
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
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>' + units[0] + '</td>';
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
                data: axisDatas,
                axisLabel: {
                    formatter: function (v) {
                        return v + units[0]
                    }
                },
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
                name: legendDatas[0],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: singleSales[e]
            }, {
                name: legendDatas[1],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: singleBacks[e]
            }, {
                name: legendDatas[2],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: singleReals[e],
                markLine: {
                    data: single_lines[e]
                }
            }, {
                name: legendDatas[3],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: singleChas[e]
            }, {
                name: legendDatas[4],
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
                data: singleWcls[e]
            }, {
                name: legendDatas[5],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: groupAdds[e],
                markLine: {
                    data: group_lines[e]
                }
                //},
                //markPoint: {
                //    data: group_Points[e]
                //}
            }, {
                name: legendDatas[6],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: groupChas[e]
            }, {
                name: legendDatas[7],
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
                data: groupWcls[e]
            }, {
                name: legendDatas[8],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: wholeAdds[e],
                markLine: {
                    data: whole_lines[e]
                }
            }, {
                name: legendDatas[9],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: wholeChas[e]
            }, {
                name: legendDatas[10],
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
                data: wholeWcls[e]
            }]
        };

        var myChart = echarts.init(document.getElementById('main' + e), 'macarons');
        myChart.setOption(option);
        mains.push(myChart);
    }

);

}



function initCycleCompare(cycles, obj) {
    for (var c = 0; c < cycles.length; c++) {
        $("#main0").before("<a id='a_cycles" + c + "' href='#cycles" + c + "'> </a><div id='cycles" + c + "' ></div>");
        $("#cycles" + c).css("height", 400);
        cycleCompareAdds[c] = new Array();
        cycleCompareChas[c] = new Array();
        cycleCompareWcls[c] = new Array();
        cycleCompareZzbs[c] = new Array();
        cycleSalesSums[c] = 0;
        cycleBacksSums[c] = 0;
        cycleRealsSums[c] = 0;
        if (c == 0) {
            for (var i = 0; i < obj.length; i++) {
                var e = singlecount - 1;
                getCompareData(c, parseFloat(wholeAdds[i][e].toFixed()), parseFloat(wholeChas[i][e].toFixed()), parseFloat(wholeWcls[i][e].toFixed()), parseFloat(wholeZzbs[i][e].toFixed()));//整
                cycleSalesSums[c] += singleSalesSums[i];
                cycleBacksSums[c] += singleBacksSums[i];
                cycleRealsSums[c] += singleRealsSums[i];
            }
        }
        else {
            for (var i = 0; i < obj.length; i++) {
                var d = group_nodes[c - 1] - 1;
                getCompareData(c, parseFloat(groupAdds[i][d].value.toFixed()), parseFloat(groupChas[i][d].value.toFixed()), parseFloat(groupWcls[i][d].value.toFixed()), parseFloat(groupZzbs[i][d].value.toFixed()));//组
                cycleRealsSums[c] += parseFloat(groupAdds[i][d].value.toFixed());
            }
        }
    }
    cycleCompareDraw(cycles, obj);
}
//月，节点，分部门综合展示
function getCompareData(c, sale, cha, wcl, zzb) {
    if (!isFinite(wcl)) {
        wcl = 0;
    }
    if (!isFinite(zzb)) {
        zzb = 0;
    }
    cycleCompareAdds[c].push({ value: sale, itemStyle: { normal: { color: cycleColors[c] } } });
    cycleCompareChas[c].push({ value: cha, itemStyle: { normal: { color: cycleColors[c] } } });
    cycleCompareWcls[c].push({ value: wcl, itemStyle: { normal: { color: cycleColors[c] } } });
    cycleCompareZzbs[c].push({ value: zzb, itemStyle: { normal: { color: cycleColors[c] } } });
}

function cycleCompareDraw(cycles, obj) {
    ie_forEach();
    cycles.forEach(function DrawEChart(v, e) {
        var option = {
            title: {
                text: v + '销售汇总',
                subtext:
                    '\n期间实际合计：' + cycleRealsSums[e]
            },
            grid: {
                x: 180,//靠左200像素
                y2: 100
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter: function (params, ticket, callback) {
                    var res = '可点击定位<br/>' + params[0].name;
                    for (var i = 0, l = params.length; i < l; i++) {
                        res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                    }
                    return res
                }
            },
            legend: {
                data: ['销售额', '差额', '内部完成率', '总占比'],
                selected: {
                    '销售额': false,
                    '差额': false,
                    '内部完成率': true,
                    '总占比': false
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
                            var hh = (obj.length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                            if (hh < 300) {
                                hh = 300;
                            }
                            $('#cycles' + e).css("height", hh);

                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td></td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = obj.length; m < g; m++) {
                                table += '<tr><td>' + obj[m] + '</td>';
                                for (var n = 0, l = series.length; n < l; n++) {
                                    var val = series[n].data[m].value;
                                    if (n == 2 || n == 3) val += '%';
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
                data: obj
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
                data: cycleCompareAdds[e]
            }, {
                name: '差额',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: cycleCompareChas[e]
            }, {
                name: '内部完成率',
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
                data: cycleCompareWcls[e],
            }, {
                name: '总占比',
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
                data: cycleCompareZzbs[e],
            }]
        };

        var myChartCompare = echarts.init(document.getElementById('cycles' + e), 'macarons');
        myChartCompare.setOption(option);
        mains.push(myChartCompare);

        myChartCompare.on('click', function (params) {
            document.getElementById("a_main" + params.dataIndex).click();
        });
    });
}

//-------------------------------------------------------------------------处理品牌下的客服数据
var sideParamMonthLegendDatas = ['月销售额', '月退货额', '月实际销售额', '月基数', '月计划', '月完成率'];
var sideParamMonthLegendBools = { '月销售额': false, '月退货额': false, '月实际销售额': true, '月基数': false, '月计划': false, '月完成率': false };

var sideParamYearLegendDatas = ['年销售额', '年退货额', '年实际销售额', '年基数', '年计划', '年完成率'];
var sideParamYearLegendBools = { '年销售额': false, '年退货额': false, '年实际销售额': true, '年基数': false, '年计划': false, '年完成率': false };
var sideEmp = '客服';

//客服（包括基数，计划，完成率）
var sideParamCodes = new Array();//当前品牌当前客服
var sideParamNames = new Array();//当前品牌当前客服name
var sideParamReals = new Array();//当前品牌当前客服的实际销售额二维数组
var sideParamSales = new Array();//当前品牌当前客服的销售额二维数组
var sideParamBacks = new Array();//当前品牌当前客服的退货额二维数组
var sideParamBases = new Array();//当前品牌当前客服的计划
var sideParamPlans = new Array();//当前品牌当前客服的基数
var sideParamWcls = new Array();//当前品牌当前客服的完成率
//当前品牌所有客服合计
var sideParamRealsSums = new Array();
var sideParamSalesSums = new Array();
var sideParamBacksSums = new Array();

function clearSideParamData() {
    //客服销售
    sideParamCodes = [];
    sideParamNames = [];
    sideParamReals = [];
    sideParamSales = [];
    sideParamBacks = [];
    sideParamBases = [];
    sideParamPlans = [];
    sideParamWcls = [];
    //客服销售合计
    sideParamRealsSums = 0;
    sideParamSalesSums = 0;
    sideParamBacksSums = 0;
}

function initSideParamData(_id) {
    sideParamCodes[_id] = new Array();//当前品牌当前客服
    sideParamNames[_id] = new Array();//当前品牌当前客服
    sideParamReals[_id] = new Array();//当前品牌当前客服的实际销售额二维数组
    sideParamSales[_id] = new Array();//当前品牌当前客服的销售额二维数组
    sideParamBacks[_id] = new Array();//当前品牌当前客服的退货额二维数组
    sideParamBases[_id] = new Array();//客服品牌基数
    sideParamPlans[_id] = new Array();//客服品牌计划
    sideParamWcls[_id] = new Array();//客服品牌完成率
    //当前品牌所有客服合计
    sideParamRealsSums[_id] = 0;
    sideParamSalesSums[_id] = 0;
    sideParamBacksSums[_id] = 0;
}

function getSideParamDataValue(_id, rowData) {
    sideParamCodes[_id].push(rowData.code);//客服编号
    sideParamNames[_id].push(rowData.name);//客服名称
    sideParamSales[_id].push(parseFloat(rowData.salemoney).toFixed());//日销售额
    sideParamBacks[_id].push(parseFloat(rowData.backmoney).toFixed());//日退货额
    sideParamReals[_id].push(parseFloat(rowData.realmoney).toFixed());//日实际销售额
    sideParamBases[_id].push(parseFloat(rowData.base).toFixed());//日销售额
    sideParamPlans[_id].push(parseFloat(rowData.plan).toFixed());//日退货额
    sideParamWcls[_id].push(parseFloat(rowData.wcl).toFixed());//日实际销售额
    //当前品牌所有客服合计
    sideParamSalesSums[_id] += parseFloat(rowData.salemoney).toFixed();
    sideParamBacksSums[_id] += parseFloat(rowData.backmoney).toFixed();
    sideParamRealsSums[_id] += parseFloat(rowData.realmoney).toFixed();
}

//function getSideParamDataValue(_id, d, rowData) {
//    sideParamCodes[_id][d] = rowData.code;//客服编号
//    sideParamNames[_id][d] = rowData.name;//客服名称
//    sideParamSales[_id][d] = parseFloat(rowData.salemoney).toFixed();//日销售额
//    sideParamBacks[_id][d] = parseFloat(rowData.backmoney).toFixed();//日退货额
//    sideParamReals[_id][d] = parseFloat(rowData.realmoney).toFixed();//日实际销售额
//    sideParamBases[_id][d] = parseFloat(rowData.base).toFixed();//日销售额
//    sideParamPlans[_id][d] = parseFloat(rowData.plan).toFixed();//日退货额
//    sideParamWcls[_id][d] = parseFloat(rowData.wcl).toFixed();//日实际销售额
//    //当前品牌所有客服合计
//    sideParamSalesSums[_id] += parseFloat(rowData.salemoney).toFixed();
//    sideParamBacksSums[_id] += parseFloat(rowData.backmoney).toFixed();
//    sideParamRealsSums[_id] += parseFloat(rowData.realmoney).toFixed();
//}


function sideParamDraw(names, sideParamName, legendDatas, legendBools) {
    ie_forEach();
    //画图
    names.forEach(function DrawEChart(v, e) {
        $("#form1").append("<div id='mainSideParam" + e + "' style='height:450px' ></div>");
        var optionSideParam = {
            title: {
                text: v + sideParamName + '销售情况',
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
                                $("#mainSideParam" + e).css("height", h / 2);
                            }
                            else {
                                $("#mainSideParam" + e).css("height", hh);
                            }

                            var table = '<table><tbody><tr><td>' + sideParamName + '</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = axisData.length; m < g; m++) {
                                table += '<tr><td>' + axisData[m] + '</td>';
                                for (var n = 0, l = series.length; n < l; n++) {
                                    var val = series[n].data[m];
                                    if (n == 5) val += '%';
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
                data: sideParamNames[e]
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
            legend: {
                data: legendDatas,
                selected: legendBools
            },
            series: [{
                name: legendDatas[0],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: sideParamSales[e]
            }, {
                name: legendDatas[1],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: sideParamBacks[e]
            }, {
                name: legendDatas[2],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: sideParamReals[e]
            }, {
                name: legendDatas[3],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: sideParamBases[e]
            }, {
                name: legendDatas[4],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: sideParamPlans[e]
            }, {
                name: legendDatas[5],
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
                data: sideParamWcls[e]
            }]
        };

        var myChartSideParam = echarts.init(document.getElementById('mainSideParam' + e), 'macarons');
        myChartSideParam.setOption(optionSideParam);
        mains.push(myChartSideParam);

    }

    );
}


var sideMonthLegendDatas = ['月销售额', '月退货额', '月实际销售额'];
var sideMonthLegendBools = { '月销售额': false, '月退货额': false, '月实际销售额': true };

var sideYearLegendDatas = ['年销售额', '年退货额', '年实际销售额'];
var sideYearLegendBools = { '年销售额': false, '年退货额': false, '年实际销售额': true };
var sideGood = '单品';

//客服（包括基数，计划，完成率）
var sideCodes = new Array();//当前品牌当前客服
var sideNames = new Array();//当前品牌当前客服name
var sideReals = new Array();//当前品牌当前客服的实际销售额二维数组
var sideSales = new Array();//当前品牌当前客服的销售额二维数组
var sideBacks = new Array();//当前品牌当前客服的退货额二维数组
//当前品牌所有客服合计
var sideRealsSums = new Array();
var sideSalesSums = new Array();
var sideBacksSums = new Array();

function clearSideData() {
    //客服销售
    sideCodes = [];
    sideNames = [];
    sideReals = [];
    sideSales = [];
    sideBacks = [];
    //客服销售合计
    sideRealsSums = 0;
    sideSalesSums = 0;
    sideBacksSums = 0;
}

function initSideData(_id) {
    sideCodes[_id] = new Array();//当前品牌当前客服
    sideNames[_id] = new Array();//当前品牌当前客服
    sideReals[_id] = new Array();//当前品牌当前客服的实际销售额二维数组
    sideSales[_id] = new Array();//当前品牌当前客服的销售额二维数组
    sideBacks[_id] = new Array();//当前品牌当前客服的退货额二维数组
    //当前品牌所有客服合计
    sideRealsSums[_id] = 0;
    sideSalesSums[_id] = 0;
    sideBacksSums[_id] = 0;
}

function getSideDataValue(_id, rowData) {
    sideCodes[_id].push(rowData.code);//客服编号
    sideNames[_id].push(rowData.name);//客服名称
    sideSales[_id].push(parseFloat(rowData.salemoney).toFixed());//日销售额
    sideBacks[_id].push(parseFloat(rowData.backmoney).toFixed());//日退货额
    sideReals[_id].push(parseFloat(rowData.realmoney).toFixed());//日实际销售额
    //当前品牌所有客服合计
    sideSalesSums[_id] += parseFloat(rowData.salemoney).toFixed();
    sideBacksSums[_id] += parseFloat(rowData.backmoney).toFixed();
    sideRealsSums[_id] += parseFloat(rowData.realmoney).toFixed();
}

//function getSideDataValue(_id, d, rowData) {
//    sideCodes[_id][d] = rowData.code;//客服编号
//    sideNames[_id][d] = rowData.name;//客服名称
//    sideSales[_id][d] = parseFloat(rowData.salemoney).toFixed();//日销售额
//    sideBacks[_id][d] = parseFloat(rowData.backmoney).toFixed();//日退货额
//    sideReals[_id][d] = parseFloat(rowData.realmoney).toFixed();//日实际销售额
//    //当前品牌所有客服合计
//    sideSalesSums[_id] += parseFloat(rowData.salemoney).toFixed();
//    sideBacksSums[_id] += parseFloat(rowData.backmoney).toFixed();
//    sideRealsSums[_id] += parseFloat(rowData.realmoney).toFixed();
//}


function sideDraw(names, sideName, legendDatas, legendBools) {
    ie_forEach();
    //画图
    names.forEach(function DrawEChart(v, e) {
        $("#form1").append("<div id='mainSide" + e + "' style='height:600px' ></div>");
        var optionSide = {
            title: {
                text: v + sideName + '销售情况',
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
                                $("#mainSide" + e).css("height", h / 2);
                            }
                            else {
                                $("#mainSide" + e).css("height", hh);
                            }

                            var table = '<table><tbody><tr>' + '<td>' + sideName + '</td>';
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
                data: sideNames[e]
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
            legend: {
                data: legendDatas,
                selected: legendBools
            },
            series: [{
                name: legendDatas[0],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: sideSales[e]
            }, {
                name: legendDatas[1],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: sideBacks[e]
            }, {
                name: legendDatas[2],
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: sideReals[e]
            }]
        };

        var myChartSide = echarts.init(document.getElementById('mainSide' + e), 'macarons');
        myChartSide.setOption(optionSide);
        mains.push(myChartSide);

    }

    );
}



//随屏幕的大小改变自适应
$(window).resize(function () {
    mains.forEach(function echartsHight(v, e) {
        v.resize();

    })
});