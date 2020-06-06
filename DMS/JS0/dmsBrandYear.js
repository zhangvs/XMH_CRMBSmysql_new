var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
var mains = new Array();//画图main数组
var monthcount = 12; //月份数
var axisData = new Array(); //x轴

var month_base = 0; //月基数
var month_plan = 0; //月基数
var monthLine = new Array();//分品牌二维数组日线，包括月基数和月基数线

var year_base = 0; //年基数
var year_plan = 0; //年计划
var yearLine = new Array();//分品牌二维数组计划线，包括月基线和年计划线

var saleData = new Array(); //销售数据
var backData = new Array(); //退货数据
var saleBackData = new Array(); //合计数据

var saleDataSum = 0;
var backDataSum = 0;
var saleBackDataSum = 0;

var saleDataSums = new Array(); //销售数据和，分品牌，一维数组，一个品牌一个和
var backDataSums = new Array(); //退货数据和，分品牌，一维数组，一个品牌一个和
var saleBackDataSums = new Array(); //实际数据和，分品牌，一维数组，一个品牌一个和

var brand_id;
var bp_brand_name;
var bp_percentage;//品牌提成数组(销售额-退货-基数)*比例==提成

var bp_brand_names = new Array();//品牌名数组
var bp_percentages = new Array();//品牌提成数组
var brand_check;//品牌基数计划数据


var yearData = new Array();//月累计数组
var yearSaleBackDatas = new Array();
var yearSaleBackChaDatas = new Array();
var yearWcl = new Array();

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
    monthLine = []; //清空月基数线
    yearLine = []; //清空年计划线
}


function getLineData(bp_brand_name, monthLine, yearLine) {
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
                        month_base = parseFloat((year_base / monthcount).toFixed());

                        getLines('月基数', month_base, '#00ff00', monthLine);
                        getLines('年基线', year_base, '#00ff00', yearLine);
                        
                    }
                    else if (p.indexOf("task") >= 0) {
                        year_plan = brand_check[i].bc_task;
                        month_plan = parseFloat((year_plan / monthcount).toFixed());
                        getLines('月基数线', month_plan, '#ff1493', monthLine);
                        getLines('年计划线', year_plan, '#ff1493', yearLine);
                    }
                }

            }
            else {
                    
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
    bp_percentages = [];//考核品牌提成数组
    mains = [];
    $("#form1").html("");
    //赋值
    for (var j = 0; j < GridData.Rows.length; j++) {
        bp_brand_name = GridData.Rows[j].bp_brand_name;//品牌name
        bp_percentage = GridData.Rows[j].bp_percentage;//品牌提成
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
            yearLine[seriess_id] = new Array();//当前品牌的计划线二维数组

            getLineData(bp_brand_name, monthLine[seriess_id], yearLine[seriess_id]);//传递品牌，和要赋值的线
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
                    '\n\n年完成率：' + parseFloat((saleBackDataSums[e] / yearLine[e][2].value * 100).toFixed()) + '%' +
                    '\n提成比：' + bp_percentages[e] +
                    '\n提成：' + parseFloat(((saleBackDataSums[e] - yearLine[e][0].value) * bp_percentages[e] * 0.01).toFixed())
                   
            },
            grid: {
                x: 230,//靠左200像素
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
                data: ['月销售额', '月退货额', '月实际销售额', '月差额', '月完成率', '年销售额', '年差额', '年完成率'],
                selected: {
                    '月销售额': false,
                    '月退货额': false,
                    '月实际销售额': false,
                    '月差额': false,
                    '月完成率': false,
                    '年销售额': false,
                    '年差额': false,
                    '年完成率': true
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
            },
            {
                name: '年销售额',
                stack: '年份',
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
                    yearSaleBackDatas[e] = new Array();
                    var yearSaleBackData = 0;
                    for (var i = 0; i < monthcount; i++) {
                        yearSaleBackData += parseFloat(saleBackData[e][i]);
                        yearSaleBackDatas[e][i] = parseFloat((yearSaleBackData).toFixed());
                    }
                    return yearSaleBackDatas[e];
                })(),
                markLine: {
                    data: yearLine[e]
                }
            }, {
                name: '年差额',
                stack: '年份',
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
                    yearSaleBackChaDatas[e] = new Array();
                    var yearSaleBackChaData = 0;
                    for (var i = 0; i < monthcount; i++) {
                        yearSaleBackChaData += parseFloat(saleBackData[e][i]);
                        yearCha = yearSaleBackChaData - yearLine[e][2].value;
                        yearSaleBackChaDatas[e][i] = parseFloat((yearCha).toFixed());
                    }
                    return yearSaleBackChaDatas[e];
                })()
            }, {
                name: '年完成率',
                stack: '年份',
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
                    yearWcl[e] = new Array();
                    var wclSum = 0;
                    for (var i = 0; i < monthcount; i++) {
                        wclSum = parseFloat((yearData[e][i] / yearLine[e][2].value * 100).toFixed()); //月完成率累计
                        yearWcl[e][i] = wclSum;
                    }
                    return yearWcl[e];
                })()
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


var yearBrandWcl = new Array();
var yearBrandSaleBackChaDatas = new Array();
var ticheng = new Array();
var tichengSum = 0;
var yearBrandSaleSums = 0;
var yearBrandBackSums = 0;
var yearBrandSaleBackSums = 0;
var yearBrandChaSums = 0;



function DrawEChartBrandData() {
    yearBrandWcl = [];
    yearBrandSaleBackChaDatas = [];
    ticheng = [];
    tichengSum = 0;
    yearBrandSaleSums = 0;
    yearBrandBackSums = 0;
    yearBrandSaleBackSums = 0;
    yearBrandChaSums = 0;

    for (var i = 0; i < bp_brand_names.length; i++) {

        if (isFinite(yearWcl[i][monthcount - 1])) {
            yearBrandWcl[i] = parseFloat((yearWcl[i][monthcount - 1]).toFixed()); //年完成率
        }
        else {
            yearBrandWcl[i] = 0;
        }
        yearBrandSaleBackChaDatas[i] = parseFloat((yearSaleBackChaDatas[i][monthcount - 1]).toFixed());
        ticheng[i] = parseFloat(((yearSaleBackDatas[i][monthcount - 1] - yearLine[i][0].value) * bp_percentages[i] * 0.01).toFixed());

        tichengSum += ticheng[i];
        yearBrandSaleSums += saleDataSums[i];
        yearBrandBackSums += backDataSums[i];
        yearBrandSaleBackSums += saleBackDataSums[i];
        yearBrandChaSums += yearBrandSaleBackChaDatas[i];
    }
}


//画图
function DrawEChartBrand() {
    DrawEChartBrandData();
    $("#main0").before("<div id='main' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main").css("height", 450);
    var option = {
        title: {
            text: $("#syear").val() + '年度考核品牌销售汇总',
            subtext: 
                '\n年销售合计：' + yearBrandSaleSums +
                '\n年退货合计：' + yearBrandBackSums +
                '\n年实际销售合计：' + yearBrandSaleBackSums +
                '\n\n年提成合计：' + tichengSum +
                '\n年销售差合计：' + yearBrandChaSums
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
            data: ['年销售额', '年退货额', '年实际销售额', '年差额', '年提成', '年完成率'],
            selected: {
                '年完成率': true,
                '年销售额': false,
                '年退货额': false,
                '年实际销售额': false,
                '年差额': false,
                '年提成': false
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
                        $("#main").css("height", 680);
                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>品牌</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = bp_brand_names.length; m < g; m++) {
                            table += '<tr><td>' + bp_brand_names[m] + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m];
                                if (n == 5) val += '%';
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
        series: [
             {
                name: '年销售额',
                stack: '年份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: saleDataSums
            }, {
                name: '年退货额',
                stack: '年份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: backDataSums
            }, {
                name: '年实际销售额',
                stack: '年份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: saleBackDataSums
            }, {
                name: '年差额',
                stack: '年份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: yearBrandSaleBackChaDatas
            }, {
                name: '年提成',
                stack: '年份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: ticheng
            },{
        name: '年完成率',
        stack: '年份',
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
        data: yearBrandWcl
    }]
    };

    var myChartDep = echarts.init(document.getElementById('main'), 'macarons');
    myChartDep.setOption(option);
    window.onresize = myChartDep.resize;//随屏幕的大小改变自适应

}