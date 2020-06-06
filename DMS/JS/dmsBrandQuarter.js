var monthcount = 12; //月份数
var axisData = new Array(); //x轴

var month_base = 0; //月基数
var month_plan = 0; //月基数


var year_base = 0; //年基数
var year_plan = 0; //年计划


var saleData = new Array(); //销售数据
var saleDataSum = 0;
var saleDataSums = new Array(); //销售数据和，分品牌，一维数组，一个品牌一个和

var backData = new Array(); //退货数据
var backDataSum = 0;
var backDataSums = new Array(); //退货数据和，分品牌，一维数组，一个品牌一个和

var saleBackData = new Array(); //合计数据
var saleBackDataSum = 0;
var saleBackDataSums = new Array(); //实际数据和，分品牌，一维数组，一个品牌一个和


var brand_id;
var bp_brand_name;
var bp_brand_names = new Array();//品牌名数组
var bp_percentages = new Array();//品牌提成数组
var brand_check;//品牌基数计划数据

var monthLine = new Array();//分品牌二维数组日线，包括月基数和月基数线
var yearLine = new Array();//分品牌二维数组计划线，包括月基线和年计划线

var bp_percentage = new Array();//品牌提成数组(销售额-退货-基数)*比例==提成
var mains = new Array();//画图main数组

var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
var yearData = new Array();//月累计数组

var yearSaleBackDatas = new Array();
var yearSaleBackChaDatas = new Array();
var yearWcl = new Array();

var quarterLine = new Array(); //季度计划线
var quarterPoint = new Array(); //季度奖
var quarterDataColor = new Array();//各季度累计数据和，颜色，二维数组
var quarterData = new Array(); //季度销售额
var quarterChaData = new Array(); //季度差额
var quarterWcl = new Array(); //季度完成率

var quarter_two1 = 3; //第二季度起
var quarter_three1 = 6; //第三季度起
var quarter_four1 = 9; //第四季度起

var quarter_base = new Array();
var quarter_plan = new Array();

var quarterColors = ['#ffb6c1', '#20b2aa', '#ffa07a', '#87cefa'];


function getAxisData(date, color, array) {
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


//品牌基数计划数据
function getBrandCheck(GridData) {
    if (typeof (GridData.Rows) != "undefined") {
        brand_check = new Object();
        brand_check = GridData.Rows;//所有品牌的基数计划数据
    }
}

//x轴
function showAxisData() {
    axisData = [];
    for (var j = 0; j < monthcount; j++) {
            axisData[j] = j + 1 + "月";
        }
}

//画线
function getLines(lineName,lineValue,lineColor,lineNumber) {
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
        xAxis: monthcount + '日',
        yAxis: lineValue
    };
    lineNumber.push(qd);
    lineNumber.push(zd);
}

function clearLines() {
    monthLine = []; //清空月线
    quarterLine = []; //清空季线
    yearLine = []; //清空年线
}


function getLineData(bp_brand_name, monthLine,quarterLine, yearLine) {
    if (typeof (brand_check) != "undefined") {
        //其它品牌，考核提成表内用的是0，品牌表里是94
        //if ($.inArray(brand_id, brand_check) <0 )
        //{
        //    brand_id = 0;
        //}
        if (bp_brand_name == '其它品牌') {
            bp_brand_name = '';
        }
        for (var i = 0; i < brand_check.length; i++) {
            //循环考核品牌，如果等于当前品牌，取出基数和计划数据，画线
            if (brand_check[i].bc_brand_name == bp_brand_name) {
                // 开始遍历 
                for (var p in brand_check[i]) { // 方法 
                    if (p.indexOf("base") >= 0) {
                        year_base = brand_check[i].bc_base; //bc_base为int类型
                        quarter_base = parseFloat((year_base / 4).toFixed()); //季度线
                        month_base = parseFloat((year_base / monthcount).toFixed());

                        getLines('月基线', month_base, '#00ff00', monthLine);
                        getLines('季度基线', quarter_base, '#00ff00', quarterLine);
                        getLines('年度基线', year_base, '#00ff00', yearLine);
                        
                    }
                    else if (p.indexOf("task") >= 0) {
                        year_plan = brand_check[i].bc_task;
                        quarter_plan = parseFloat((year_plan / 4).toFixed()); //季度线
                        month_plan = parseFloat((year_plan / monthcount).toFixed());
                        getLines('月计划线', month_plan, '#ff1493', monthLine);
                        getLines('季度计划线', quarter_plan, '#ff1493', quarterLine);
                        getLines('年度计划线', year_plan, '#ff1493', yearLine);
                    }
                }

            }
            else {
                    
            }

        }
    }
}


//初始化季度数据，颜色
function initQuarterData() {
    for (var i = 0; i < bp_brand_names.length; i++) {
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
    for (var i = 0; i < bp_brand_names.length; i++) {
        quarterData[i] = new Array();
        for (var j = 0; j < monthcount; j++) {
            getQuarterDataVal(quarterData[i], quarterDataColor[i][j][0], quarterDataColor[i][j][1]);
        }
    }

}

//季度差
function showMonthQuarterChaData() {
    quarterChaData = [];
    for (var i = 0; i < bp_brand_names.length; i++) {
        quarterChaData[i] = new Array();
        for (var j = 0; j < monthcount; j++) {
            getQuarterDataVal(quarterChaData[i], quarterDataColor[i][j][0] - quarterLine[i][2].value, quarterDataColor[i][j][1]);
        }
    }
    showMonthQuarterWclData();
}

//季度完成率
function showMonthQuarterWclData() {
    quarterWcl = [];
    for (var i = 0; i < bp_brand_names.length; i++) {
        quarterWcl[i] = new Array();
        for (var j = 0; j < monthcount; j++) {
            getQuarterDataVal(quarterWcl[i], parseFloat((quarterDataColor[i][j][0] / quarterLine[i][2].value * 100).toFixed()), quarterDataColor[i][j][1]);
        }
    }
    //showQuarterPoint();
}

//渲染季度奖点
function getQuarterPoint(i, index, xAxis, value) {
    var dian = {
        name: index + '季度奖',
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

//画点
function showQuarterPoint() {
    quarterPoint = [];
    for (var i = 0; i < bp_brand_names.length; i++) {
        if (quarter_plan[i] != 0 && quarter_base[i] != 0) {
            quarterPoint[i] = new Array();
            if (quarterChaData[i][quarter_two1 - 1].value > 0) {
                getQuarterPoint(i, '1', quarter_two1, quarterDataColor[i][quarter_two1 - 1][0]);
            }
            if (quarterChaData[i][quarter_three1 - 1].value > 0) {
                getQuarterPoint(i, '2', quarter_three1, quarterDataColor[i][quarter_three1 - 1][0]);
            }
            if (quarterChaData[i][quarter_four1 - 1].value > 0) {
                getQuarterPoint(i, '3', quarter_four1, quarterDataColor[i][quarter_four1 - 1][0]);
            }
            if (quarterChaData[i][monthcount - 1].value > 0) {
                getQuarterPoint(i, '4', monthcount, quarterDataColor[i][monthcount - 1][0]);
            }
        }

    }
    
}

//个人每日实际销售量
function getMonthSaleBackData(GridData) {
    //清空各个品牌的合计
    saleBackDataSums = [];
    saleDataSums = [];
    backDataSums = [];
    yearData = [];
    //清空
    saleData = [];//销售额：不同品牌数据，分月的数据，的二维数组
    backData = [];//退货额：不同品牌数据，分月的数据，的二维数组
    saleBackData = [];//实际销售额：不同品牌数据，分月的数据，的二维数组

    bp_brand_names = [];//考核品牌名数组
    bp_percentage = [];//考核品牌提成数组
    mains = [];
    $("#form1").html("");
    //赋值
    for (var j = 0; j < GridData.Rows.length; j++) {
        bp_brand_name = GridData.Rows[j].bp_brand_name;//品牌name
        bp_percentage = GridData.Rows[j].bp_percentage;//品牌提成
        //if (bp_brand_names.indexOf(bp_brand_name) >= 0) {//ie不兼容indexOf
        if ($.inArray(bp_brand_name, bp_brand_names) >= 0) {
            continue;//如果品牌名数组中包含此品牌名，跳出本次循环
        }
        else {
            var seriess_id = bp_brand_names.push(bp_brand_name) - 1;//如果第一次出现，添加到数组中,返回当前放入元素的id,返回值-1为数组角标
            bp_percentages.push(bp_percentage);//如果第一次出现，添加到数组中,返回当前放入元素的id,返回值-1为数组角标
            $("#form1").append("<div id='main" + seriess_id + "' ></div>");
            saleBackData[seriess_id] = new Array();//当前品牌的实际销售额二维数组
            saleData[seriess_id] = new Array();//当前品牌的销售额二维数组
            backData[seriess_id] = new Array();//当前品牌的退货额二维数组

            monthLine[seriess_id] = new Array(); //当前品牌的基线二维数组
            quarterLine[seriess_id] = new Array(); //当前品牌的基线二维数组
            yearLine[seriess_id] = new Array();//当前品牌的计划线二维数组

            getLineData(bp_brand_name, monthLine[seriess_id],quarterLine[seriess_id], yearLine[seriess_id]);//传递品牌，和要赋值的线
        }

        //初始化0
        for (var i = 0; i < monthcount; i++) {
            saleData[seriess_id][i] = 0;
            backData[seriess_id][i] = 0;
            saleBackData[seriess_id][i] = 0;
        }
        saleBackDataSum = 0;
        saleDataSum = 0;
        backDataSum = 0;
        //循环此品牌之后的数据，
        for (var b = j; b < GridData.Rows.length; b++) {
            //如果发现后面的数据有相同品牌则放入此品牌的data数组中，不同的品牌不同的数组，
            if (bp_brand_name == GridData.Rows[b].bp_brand_name) {
                var datetime = parseInt(GridData.Rows[b].datetime) - 1; //从1日开始，-1到角标0

                saleBackData[seriess_id][datetime] = parseFloat(GridData.Rows[b].realmoney.toFixed());//把数据赋值给对应的日期角标
                saleBackDataSum += parseFloat(GridData.Rows[b].realmoney.toFixed());


                saleData[seriess_id][datetime] = parseFloat(GridData.Rows[b].salemoney.toFixed());
                saleDataSum += parseFloat(GridData.Rows[b].salemoney.toFixed());

                backData[seriess_id][datetime] = parseFloat(GridData.Rows[b].backmoney.toFixed());
                backDataSum += parseFloat(GridData.Rows[b].backmoney.toFixed());
            }
        }

        saleBackDataSums[seriess_id] = saleBackDataSum;
        saleDataSums[seriess_id] = saleDataSum;
        backDataSums[seriess_id] = backDataSum;

        //初始化月份数据
        yearData[seriess_id] = new Array();
        var yearSum = 0; //节点sum1
        for (var k = 0; k < monthcount; k++) {
            yearSum += parseFloat(saleBackData[seriess_id][k].toFixed());
            yearData[seriess_id][k] = yearSum;
        }

    }
    initQuarterData();
    showMonthQuarterData();
    showMonthQuarterChaData();

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
        var option = {
            title: {
                text: bp_brand_names[e]+'_'+$("#syear").val() + '年份销售数据',
                subtext: '月基数：' + monthLine[e][0].value + '\n月基数：' + monthLine[e][2].value +
                    '\n\n年基数：' + yearLine[e][0].value + '\n年计划：' + yearLine[e][2].value +
                    '\n\n年销量：' + saleDataSums[e] + '\n年退货：' + backDataSums[e] + '\n年实际：' + saleBackDataSums[e] +
                    '\n\n年完成率：' + parseFloat((saleBackDataSums[e] / yearLine[e][2].value * 100).toFixed()) + '%' + '\n提成比：' + bp_percentages[e] + '\n提成：' + parseFloat(((saleBackDataSums[e] - yearLine[e][0].value) * bp_percentages[e] * 0.01).toFixed())
                   
            },
            grid: {
                x: 230,//靠左200像素
                y2: 100
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter:function (params,ticket,callback) {
                    //console.log(params)
                    var res = bp_brand_names[e] + params[0].name ;
                    for (var i = 0, l = params.length; i < l; i++) {
                        res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                    }
                    //setTimeout(function (){
                    //    // 仅为了模拟异步回调
                    //    callback(ticket, res);
                    //}, 1000)
                    //return 'loading';
                    return res
                }
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
                            $("#main" + e).css("height", 350);
                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>月份</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = axisData.length; m < g; m++) {
                                table += '<tr><td>' + axisData[m] + '</td>';
                                for (var n = 0, l = series.length; n < l; n++) {
                                    var val = series[n].data[m];
                                    if (n == 4 || n == 7) val += '%';
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
                    data: monthLine[e]
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
                        dayCha[i] = parseFloat((saleBackData[e][i] - monthLine[e][2].value).toFixed());
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
                        dayWcl[i] = parseFloat((saleBackData[e][i] / monthLine[e][2].value * 100).toFixed());
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
                    data: quarterLine[e]
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

    //echarts.connect(mains);
}
//随屏幕的大小改变自适应
$(window).resize(function () {
    mains.forEach(function echartsHight(v, e) {
        v.resize();

    })
});


var quarterBrandWcl_j1 = new Array();
var quarterBrandSaleBackDatas_j1 = new Array();
var quarterBrandSaleBackChaDatas_j1 = new Array();
var ticheng_j1 = new Array();
var tichengSum_j1 = 0;

function DrawEChartBrandData_j1() {
    quarterBrandWcl_j1 = [];
    quarterBrandSaleBackDatas_j1 = [];
    quarterBrandSaleBackChaDatas_j1 = [];
    ticheng_j1 = [];
    tichengSum_j1 = 0;

    for (var i = 0; i < bp_brand_names.length; i++) {
        if (isFinite(quarterWcl[i][quarter_two1 - 1].value)) {
            quarterBrandWcl_j1[i] = parseFloat((quarterWcl[i][quarter_two1 - 1].value).toFixed()); //年完成率
        }
        else {
            quarterBrandWcl_j1[i] = 0;
        }
        quarterBrandSaleBackDatas_j1[i] = parseFloat((quarterData[i][quarter_two1 - 1].value).toFixed());
        quarterBrandSaleBackChaDatas_j1[i] = parseFloat((quarterChaData[i][quarter_two1 - 1].value).toFixed());
        ticheng_j1[i] = parseFloat(((quarterData[i][quarter_two1 - 1].value - quarterLine[i][0].value) * bp_percentages[i] * 0.01).toFixed());
        tichengSum_j1 += ticheng_j1[i];

    }
}

var quarterBrandWcl_j2 = new Array();
var quarterBrandSaleBackDatas_j2 = new Array();
var quarterBrandSaleBackChaDatas_j2 = new Array();
var ticheng_j2 = new Array();
var tichengSum_j2 = 0;

function DrawEChartBrandData_j2() {
    quarterBrandWcl_j2 = [];
    quarterBrandSaleBackDatas_j2 = [];
    quarterBrandSaleBackChaDatas_j2 = [];
    ticheng_j2 = [];
    tichengSum_j2 = 0;

    for (var i = 0; i < bp_brand_names.length; i++) {
        if (isFinite(quarterWcl[i][quarter_three1 - 1].value)) {
            quarterBrandWcl_j2[i] = parseFloat((quarterWcl[i][quarter_three1 - 1].value).toFixed()); //年完成率
        }
        else {
            quarterBrandWcl_j2[i] = 0;
        }
        quarterBrandSaleBackDatas_j2[i] = parseFloat((quarterData[i][quarter_three1 - 1].value).toFixed());
        quarterBrandSaleBackChaDatas_j2[i] = parseFloat((quarterChaData[i][quarter_three1 - 1].value).toFixed());
        ticheng_j2[i] = parseFloat(((quarterData[i][quarter_three1 - 1].value - quarterLine[i][0].value) * bp_percentages[i] * 0.01).toFixed());
        tichengSum_j2 += ticheng_j2[i];

    }
}

var quarterBrandWcl_j3 = new Array();
var quarterBrandSaleBackDatas_j3 = new Array();
var quarterBrandSaleBackChaDatas_j3 = new Array();
var ticheng_j3 = new Array();
var tichengSum_j3 = 0;

function DrawEChartBrandData_j3() {
    quarterBrandWcl_j3 = [];
    quarterBrandSaleBackDatas_j3 = [];
    quarterBrandSaleBackChaDatas_j3 = [];
    ticheng_j3 = [];
    tichengSum_j3 = 0;

    for (var i = 0; i < bp_brand_names.length; i++) {
        if (isFinite(quarterWcl[i][quarter_four1 - 1].value)) {
            quarterBrandWcl_j3[i] = parseFloat((quarterWcl[i][quarter_four1 - 1].value).toFixed()); //年完成率
        }
        else {
            quarterBrandWcl_j3[i] = 0;
        }
        quarterBrandSaleBackDatas_j3[i] = parseFloat((quarterData[i][quarter_four1 - 1].value).toFixed());
        quarterBrandSaleBackChaDatas_j3[i] = parseFloat((quarterChaData[i][quarter_four1 - 1].value).toFixed());
        ticheng_j3[i] = parseFloat(((quarterData[i][quarter_four1 - 1].value - quarterLine[i][0].value) * bp_percentages[i] * 0.01).toFixed());
        tichengSum_j3 += ticheng_j3[i];

    }
}

var quarterBrandWcl_j4 = new Array();
var quarterBrandSaleBackDatas_j4 = new Array();
var quarterBrandSaleBackChaDatas_j4 = new Array();
var ticheng_j4 = new Array();
var tichengSum_j4 = 0;

function DrawEChartBrandData_j4() {
    quarterBrandWcl_j4 = [];
    quarterBrandSaleBackDatas_j4 = [];
    quarterBrandSaleBackChaDatas_j4 = [];
    ticheng_j4 = [];
    tichengSum_j4 = 0;

    for (var i = 0; i < bp_brand_names.length; i++) {
        if (isFinite(quarterWcl[i][monthcount - 1].value)) {
            quarterBrandWcl_j4[i] = parseFloat((quarterWcl[i][monthcount - 1].value).toFixed()); //年完成率
        }
        else {
            quarterBrandWcl_j4[i] = 0;
        }
        quarterBrandSaleBackDatas_j4[i] = parseFloat((quarterData[i][monthcount - 1].value).toFixed());
        quarterBrandSaleBackChaDatas_j4[i] = parseFloat((quarterChaData[i][monthcount - 1].value).toFixed());
        ticheng_j4[i] = parseFloat(((quarterData[i][monthcount - 1].value - quarterLine[i][0].value) * bp_percentages[i] * 0.01).toFixed());
        tichengSum_j4 += ticheng_j4[i];

    }
}

//画图
function DrawEChartBrand_j1() {
    DrawEChartBrandData_j1();
    $("#main0").before("<div id='main_j1' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main_j1").css("height", 300);
    var option = {
        title: {
            text: '第一季度部门销售汇总',
            subtext: '第一季提成合计：' + tichengSum_j1
        },
        grid: {
            x: 230,//靠左200像素
            y2: 100
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['第一季完成率','第一季提成', '第一季销售额', '第一季差额'],
            selected: {
                '第一季完成率': true,
                '第一季提成': false,
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
                        for (var m = 0, g = bp_brand_names.length; m < g; m++) {
                            table += '<tr><td>' + bp_brand_names[m] + '</td>';
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
            data: bp_brand_names
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
            data: quarterBrandWcl_j1
        },{
            name: '第一季提成',
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
            data: ticheng_j1
        }, {
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
            data: quarterBrandSaleBackDatas_j1
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
            data: quarterBrandSaleBackChaDatas_j1
        }]
    };

    var myChartBrand_j1 = echarts.init(document.getElementById('main_j1'), 'macarons');
    myChartBrand_j1.setOption(option);
    window.onresize = myChartBrand_j1.resize;//随屏幕的大小改变自适应

}


//画图
function DrawEChartBrand_j2() {
    DrawEChartBrandData_j2();
    $("#main0").before("<div id='main_j2' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main_j2").css("height", 300);
    var option = {
        title: {
            text: '第二季度部门销售汇总',
            subtext: '第二季提成合计：' + tichengSum_j2
        },
        grid: {
            x: 230,//靠左200像素
            y2: 100
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['第二季完成率', '第二季提成', '第二季销售额', '第二季差额'],
            selected: {
                '第二季完成率': true,
                '第二季提成': false,
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
                        for (var m = 0, g = bp_brand_names.length; m < g; m++) {
                            table += '<tr><td>' + bp_brand_names[m] + '</td>';
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
            data: bp_brand_names
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
            data: quarterBrandWcl_j2
        }, {
            name: '第二季提成',
            stack: '第二季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                    }
                }
            },
            data: ticheng_j2
        }, {
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
            data: quarterBrandSaleBackDatas_j2
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
            data: quarterBrandSaleBackChaDatas_j2
        }]
    };

    var myChartBrand_j2 = echarts.init(document.getElementById('main_j2'), 'macarons');
    myChartBrand_j2.setOption(option);
    window.onresize = myChartBrand_j2.resize;//随屏幕的大小改变自适应

}


//画图
function DrawEChartBrand_j3() {
    DrawEChartBrandData_j3();
    $("#main0").before("<div id='main_j3' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main_j3").css("height", 300);
    var option = {
        title: {
            text: '第三季度部门销售汇总',
            subtext: '第三季提成合计：' + tichengSum_j3
        },
        grid: {
            x: 230,//靠左200像素
            y2: 100
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['第三季完成率', '第三季提成', '第三季销售额', '第三季差额'],
            selected: {
                '第三季完成率': true,
                '第三季提成': false,
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
                        for (var m = 0, g = bp_brand_names.length; m < g; m++) {
                            table += '<tr><td>' + bp_brand_names[m] + '</td>';
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
            data: bp_brand_names
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
            data: quarterBrandWcl_j3
        }, {
            name: '第三季提成',
            stack: '第三季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                    }
                }
            },
            data: ticheng_j3
        }, {
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
            data: quarterBrandSaleBackDatas_j3
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
            data: quarterBrandSaleBackChaDatas_j3
        }]
    };

    var myChartBrand_j3 = echarts.init(document.getElementById('main_j3'), 'macarons');
    myChartBrand_j3.setOption(option);
    window.onresize = myChartBrand_j3.resize;//随屏幕的大小改变自适应

}


//画图
function DrawEChartBrand_j4() {
    DrawEChartBrandData_j4();
    $("#main0").before("<div id='main_j4' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main_j4").css("height", 300);
    var option = {
        title: {
            text: '第四季度部门销售汇总',
            subtext: '第四季提成合计：' + tichengSum_j4
        },
        grid: {
            x: 230,//靠左200像素
            y2: 100
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['第四季完成率', '第四季提成', '第四季销售额', '第四季差额'],
            selected: {
                '第四季完成率': true,
                '第四季提成': false,
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
                        for (var m = 0, g = bp_brand_names.length; m < g; m++) {
                            table += '<tr><td>' + bp_brand_names[m] + '</td>';
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
            data: bp_brand_names
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
            data: quarterBrandWcl_j4
        }, {
            name: '第四季提成',
            stack: '第四季',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top',
                    }
                }
            },
            data: ticheng_j4
        }, {
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
            data: quarterBrandSaleBackDatas_j4
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
            data: quarterBrandSaleBackChaDatas_j4
        }]
    };

    var myChartBrand_j4 = echarts.init(document.getElementById('main_j4'), 'macarons');
    myChartBrand_j4.setOption(option);
    window.onresize = myChartBrand_j4.resize;//随屏幕的大小改变自适应

}
