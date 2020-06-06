var syear;
var brandGoods = new Array();//画图brandGood数组
var brandMonths = new Array();
var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height

var admin_user_name;
var user_id;
var user_name;
var u_company;

var datetime;
var salemoney;
var backmoney;
var realmoney;

var brand_id;
var brand_name;
var goods_id;
var goods_name;

var datetimes = new Array();
var brand_ids = new Array();//品牌id数组
var brand_names = new Array();//品牌名数组
var goods_ids = new Array();//单品id数组
var goods_names = new Array();//单品名数组

//一个月内一个品牌下所有单品的数据
var salemoneys = new Array(); //销售数据
var backmoneys = new Array(); //退货数据
var realmoneys = new Array(); //合计数据

//客户所有品牌每个月的合计
var salemoneyMonthSums = new Array();
var backmoneyMonthSums = new Array();
var realmoneyMonthSums = new Array();

//一个品牌不同月份的合计对比
var brandMonths = new Array();//一个月不同品牌，二维
var salemoneybrandMonthSums = new Array();
var backmoneybrandMonthSums = new Array();
var realmoneybrandMonthSums = new Array();


//所有品牌所有单品的合计
var salemoneyBrandSums = new Array();
var backmoneyBrandSums = new Array(); 
var realmoneyBrandSums = new Array(); 

var all_salemoneySum = 0;
var all_backmoneySum = 0;
var all_realmoneySum = 0;


var goods_number;
var goods_numbers = new Array();
var goods_numberBrandSums = new Array();
var goods_numberbrandMonthSums = new Array();
var goods_numberYearSum = 0;

var orderdate;
var month_orderdates = new Array();
var month_counts = new Array();
var month_frequencys = new Array();

//个人每日实际销售量
function getSaleBackData(GridData, syear) {
    syear = syear;
    brandGoods = []; brandMonths = [];
    $("#form1").html("");

    brand_names = [];
    brand_ids = [];
    goods_names = [];
    goods_ids = [];

    salemoneys = [];//销售额
    backmoneys = [];//退货额
    realmoneys = [];//实际销售额

    salemoneyMonthSums = [];
    backmoneyMonthSums = [];
    realmoneyMonthSums = [];

    salemoneybrandMonthSums = [];
    backmoneybrandMonthSums = [];
    realmoneybrandMonthSums = [];

    realmoneyBrandSums = [];
    salemoneyBrandSums = [];
    backmoneyBrandSums = [];

    all_realmoneySum = 0;
    all_salemoneySum = 0;
    all_backmoneySum = 0;

    goods_numbers = [];
    goods_numberBrandSums = [];
    goods_numberbrandMonthSums = [];
    goods_numberYearSum = 0;

    month_orderdates = [];
    month_counts = [];
    month_frequencys = [];
    for (var t = 0; t < 12; t++) {
        datetimes[t] = t + 1;
        salemoneyMonthSums[t] = 0;
        backmoneyMonthSums[t] = 0;
        realmoneyMonthSums[t] = 0;

        month_orderdates[t] = new Array();
        month_counts[t] = 0;
        month_frequencys[t] = 0;
    }

    var i = 0;
    var m = 0;
    var b = 0;
    var d = 0;
    //赋值
    if (GridData.Rows.length > 0) {
        user_id = GridData.Rows[0].user_id;//客户手机号
        user_name = GridData.Rows[0].user_name;//客户手机号
        u_company = GridData.Rows[0].u_company;//客户名称
        admin_user_name = GridData.Rows[0].admin_user_name;//员工id

        for (var j = 0; j < GridData.Rows.length; j++) {
            datetime = parseInt(GridData.Rows[j].datetime);
            brand_id = GridData.Rows[j].brand_id;
            brand_name = GridData.Rows[j].brand_name;
            goods_id = GridData.Rows[j].goods_id;
            goods_name = GridData.Rows[j].goods_name;
            salemoney = parseFloat(GridData.Rows[j].salemoney.toFixed());
            backmoney = parseFloat(GridData.Rows[j].backmoney.toFixed());
            realmoney = parseFloat(GridData.Rows[j].realmoney.toFixed());
            goods_number = parseFloat(GridData.Rows[j].goods_number.toFixed());

            orderdate = GridData.Rows[j].orderdate;



            //用来计算品牌合计,并列出单品
            if ($.inArray(brand_id, brand_ids) < 0) {
                _id = brand_ids.push(brand_id) - 1;//如果第一次出现，添加到数组中,返回前放入元素的id,返回值-1为数组角标
                brand_names.push(brand_name);
                $("#form1").append("<a id='a_brandMonth" + _id + "' href='#brandMonth" + _id + "'> </a><div id='brandMonth" + _id + "' ></div>");
                $("#form1").append("<a id='a_brandGood" + _id + "' href='#brandGood" + _id + "'> </a><div id='brandGood" + _id + "' ></div><hr style='height:10px;border:none;border-top:10px groove skyblue;' />");

                goods_ids[_id] = new Array();//品牌下的单品id
                goods_names[_id] = new Array();//品牌下的单品名称

                salemoneys[_id] = new Array();//前客户的销售额二维数组
                backmoneys[_id] = new Array();//前客户的退货额二维数组
                realmoneys[_id] = new Array();//前客户的实际销售额二维数组
                goods_numbers[_id] = new Array();
                
                goods_numberBrandSums[_id] = 0;
                realmoneyBrandSums[_id] = 0;
                salemoneyBrandSums[_id] = 0;
                backmoneyBrandSums[_id] = 0;
                i = 0;

                brandMonths[_id] = new Array();
                salemoneybrandMonthSums[_id] = new Array();
                backmoneybrandMonthSums[_id] = new Array();
                realmoneybrandMonthSums[_id] = new Array();
                goods_numberbrandMonthSums[_id] = new Array();

                for (var s = 0; s < 12; s++) {
                    brandMonths[_id][s] = s + 1;
                    salemoneybrandMonthSums[_id][s] = 0;
                    backmoneybrandMonthSums[_id][s] = 0;
                    realmoneybrandMonthSums[_id][s] = 0;
                    goods_numberbrandMonthSums[_id][s] = 0;
                }
            }

            //一个月份下品牌的合计
            if ($.inArray(datetime, brandMonths[_id]) > 0) {
                salemoneybrandMonthSums[_id][datetime-1] += salemoney;
                backmoneybrandMonthSums[_id][datetime-1] += backmoney;
                realmoneybrandMonthSums[_id][datetime - 1] += realmoney;
                goods_numberbrandMonthSums[_id][datetime - 1] += goods_number;
            }

            //用来计算月份合计
            if ($.inArray(datetime, datetimes)> 0) {
                salemoneyMonthSums[datetime-1] += salemoney;
                backmoneyMonthSums[datetime-1] += backmoney;
                realmoneyMonthSums[datetime - 1] += realmoney;

                if ($.inArray(orderdate, month_orderdates[datetime - 1]) < 0) {
                    month_orderdates[datetime - 1].push(orderdate);
                    month_counts[datetime - 1] += 1;
                    month_frequencys[datetime - 1] = parseFloat((30 / month_counts[datetime - 1]).toFixed());
                }

            }
            

            goods_ids[_id][i] = goods_id;
            goods_names[_id][i] = goods_name;

            salemoneys[_id][i] = salemoney;
            backmoneys[_id][i] = backmoney;
            realmoneys[_id][i] = realmoney;
            goods_numbers[_id][i] = goods_number;

            salemoneyBrandSums[_id] += salemoney;
            backmoneyBrandSums[_id] += backmoney;
            realmoneyBrandSums[_id] += realmoney;
            goods_numberBrandSums[_id] += goods_number;

            all_salemoneySum += salemoney;
            all_backmoneySum += backmoney;
            all_realmoneySum += realmoney;
            goods_numberYearSum += goods_number;


            i++;
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
    brand_ids.forEach(function DrawEChart(v, e) {
        $("#brandMonth" + e).css("height", 450);
        var option = {
            title: {
                text: brand_names[e] + '_品牌年内各月份销售对比',
                subtext: 
                    '\n\n年销量：' + salemoneyBrandSums[e] + '\n年退货：' + backmoneyBrandSums[e] + '\n年实际：' + realmoneyBrandSums[e] +
                    '\n\n品牌销量数量：' + goods_numberBrandSums[e]

            },
            grid: {
                x: 180,//靠左200像素
                y2: 50
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter: function (params, ticket, callback) {
                    var res = '可点击查看【客戶】品牌月份销售详情<br/>' + params[0].name;
                    for (var i = 0, l = params.length; i < l; i++) {
                        res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                    }
                    return res
                }
            },
            legend: {
                data: ['月销售额', '月退货额', '月实际销售额', '月销售数量'],
                selected: {
                    '月销售额': false,
                    '月退货额': false,
                    '月实际销售额': true,
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
                            var hh = (brandMonths[e].length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                            if (hh < 450) {
                                hh = 450;
                            }
                            $("#brandGood" + e).css("height", hh);
                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>月份</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = brandMonths[e].length; m < g; m++) {
                                table += '<tr><td>' + brandMonths[e][m] + '</td>';
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
                    formatter: function (value) {
                        return value + '月';
                    }
                },
                data: brandMonths[e]
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
                name: '月实际销售额',
                stack: '月',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: realmoneybrandMonthSums[e],
            },{
                name: '月销售额',
                stack: '月',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: salemoneybrandMonthSums[e]
            }, {
                name: '月退货额',
                stack: '月',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: backmoneybrandMonthSums[e]
            }, {
                name: '月销售数量',
                stack: '月',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: goods_numberbrandMonthSums[e]
            }]
        };

        var myChartBrandMonth = echarts.init(document.getElementById('brandMonth' + e), 'shine');
        myChartBrandMonth.setOption(option);
        brandMonths.push(myChartBrandMonth);

        myChartBrandMonth.on('click', function (params) {
            window.open('/DMS/ReportForm/dms_customer_brand_goods.aspx?admin_user_name=' + admin_user_name + '&user_id=' + user_id + '&syear=' + syear + '&smonth=' + datetimes[params.dataIndex] + '&brand_id=' + brand_ids[e] + '&rnd=' + Math.random());
        });

        $("#brandGood" + e).css("height", 500);
        var option = {
            title: {
                text: brand_names[e] + '_年度品牌销售情况',
                subtext: '\n\n单品数：' + goods_names[e].length +
                    '\n\n年销量：' + salemoneyBrandSums[e] + '\n年退货：' + backmoneyBrandSums[e] + '\n年实际：' + realmoneyBrandSums[e]+
                    '\n\n品牌销量数量：' + goods_numberBrandSums[e]
            },
            grid: {
                x: 180,//靠左200像素
                y2: 300
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter: function (params, ticket, callback) {
                    var res = '可点击查看【客戶】单品年度销售详情<br/>' + params[0].name;
                    for (var i = 0, l = params.length; i < l; i++) {
                        res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                    }
                    return res
                }
            },
            legend: {
                data: ['单品销售额', '单品退货额', '单品实际销售额', '单品销售数量'],
                selected: {
                    '单品销售额': false,
                    '单品退货额': false,
                    '单品实际销售额': true,
                    '单品销售数量': false
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
                            var hh = (goods_names[e].length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                            if (hh < 500) {
                                hh = 500;
                            }
                            $("#brandGood" + e).css("height", hh);
                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr><td>序号</td><td>单品</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = goods_names[e].length; m < g; m++) {
                                var no = m + 1;
                                table += '<tr><td>' + no + '</td><td>' + goods_names[e][m] + '</td>';
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
                data: goods_names[e]
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
                name: '单品销售额',
                stack: '单品',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: salemoneys[e]
            }, {
                name: '单品退货额',
                stack: '单品',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: backmoneys[e]
            }, {
                name: '单品实际销售额',
                stack: '单品',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: realmoneys[e],
            }, {
                name: '单品销售数量',
                stack: '单品',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: goods_numbers[e],
            }]
        };

        var myChartBrandGood = echarts.init(document.getElementById('brandGood' + e), 'macarons');
        myChartBrandGood.setOption(option);
        brandGoods.push(myChartBrandGood);

        myChartBrandGood.on('click', function (params) {
            window.open('/DMS/ReportForm/dms_customer_year_brand_goods.aspx?admin_user_name=' + admin_user_name + '&user_id=' + user_id + '&u_company=' + u_company + '&syear=' + syear + '&goods_id=' + goods_ids[e][params.dataIndex] + '&rnd=' + Math.random());
        });
    });

    //echarts.connect(brandGoods);
}
//随屏幕的大小改变自适应
$(window).resize(function () {
    brandGoods.forEach(function echartsHight(v, e) {
        v.resize();
    });
    brandMonths.forEach(function echartsHight(v, e) {
        v.resize();
    });
});

//一年中所有品牌的汇总
function DrawEChartBrands() {
    $("#brandMonth0").before("<div id='brandGoods' ></div>");
    $("#brandGoods").css("height", 500);
    var option = {
        title: {
            text: u_company + '_年度销售品牌汇总',
            subtext: '\n\n电话：' + user_name +
                    '\n\n销售品牌数：' + brand_names.length +
                    '\n\n年销量：' + all_salemoneySum + '\n年退货：' + all_backmoneySum + '\n年实际：' + all_realmoneySum +
                    '\n\n年销售数量：' + goods_numberYearSum
        },
        grid: {
            x: 180,//靠左200像素
            y2: 200
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            formatter: function (params, ticket, callback) {
                //console.log(params)
                var res = '可点击定位品牌<br/>' + params[0].name;
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
        },
        legend: {
            data: ['品牌销售额', '品牌退货额', '品牌实际销售额', '品牌销售数量'],
            selected: {
                '品牌销售额': false,
                '品牌退货额': false,
                '品牌实际销售额': true,
                '品牌销售数量': false
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
                        var hh = (brand_names.length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                        if (hh < 500) {
                            hh = 500;
                        }
                        $("#brandGoods").css("height", hh);
                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>品牌</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = brand_names.length; m < g; m++) {
                            table += '<tr><td>' + brand_names[m] + '</td>';
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
                interval: 0,
                rotate: 45,//倾斜度 -90 至 90 默认为0  
                //margin: 2,
                textStyle: {
                    fontWeight: "bolder",
                    color: "#000000"
                }
            },
            data: brand_names
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
                name: '品牌销售额',
                stack: '品牌',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: salemoneyBrandSums
            }, {
                name: '品牌实际销售额',
                stack: '品牌',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: realmoneyBrandSums
            }, {
                name: '品牌退货额',
                stack: '品牌',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: backmoneyBrandSums
            }, {
                name: '品牌销售数量',
                stack: '品牌',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: goods_numberBrandSums
            }]
    };

    var myChartBrandGoods = echarts.init(document.getElementById('brandGoods'), 'chalk');
    myChartBrandGoods.setOption(option);
    window.onresize = myChartBrandGoods.resize;//随屏幕的大小改变自适应

    myChartBrandGoods.on('click', function (params) {
        document.getElementById("a_brandMonth" + params.dataIndex).click();
    });
}

//一年中月份对比
function DrawEChartMonths() {
    $("#brandMonth0").before("<div id='brandMonths' ></div>");
    $("#brandMonths").css("height", 500);
    var option = {
        title: {
            text: u_company + '_年度品牌销售月份对比',
            subtext: '\n\n电话：' + user_name +
                    '\n\n年销量：' + all_salemoneySum + '\n年退货：' + all_backmoneySum + '\n年实际：' + all_realmoneySum +
                    '\n\n年拿货次数：' + year_count + '\n年拿货频率：' + year_frequency + ' 天/次' +
                    '\n\n年销售数量：' + goods_numberYearSum
        },
        grid: {
            x: 180,//靠左200像素
            y2: 200
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            formatter: function (params, ticket, callback) {
                var res = '可点击查看客户月份销售详情<br/>' + params[0].name;
                for (var i = 0, l = params.length; i < l; i++) {
                    res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                }
                return res
            }
        },
        legend: {
            data: ['月拿货次数', '月拿货频率(天/次)','月销售额', '月退货额', '月实际销售额'],
            selected: {
                '月销售额': false,
                '月退货额': false,
                '月实际销售额': true,
                '月拿货次数': false,
                '月拿货频率(天/次)': false
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
                        var hh = (datetimes.length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                        if (hh < 500) {
                            hh = 500;
                        }
                        $("#brandMonths").css("height", hh);
                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>月份</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = datetimes.length; m < g; m++) {
                            table += '<tr><td>' + datetimes[m] + '</td>';
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
            data: datetimes
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
                name: '月拿货次数',
                stack: '月',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: month_counts
            }, {
                name: '月拿货频率(天/次)',
                stack: '月',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: month_frequencys
            },{
                name: '月销售额',
                stack: '月',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: salemoneyMonthSums
            }, {
                name: '月退货额',
                stack: '月',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: backmoneyMonthSums
            }, {
                name: '月实际销售额',
                stack: '月',
                type: 'line',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: realmoneyMonthSums
            }]
    };

    var myChartMonths = echarts.init(document.getElementById('brandMonths'), 'purple-passion');
    myChartMonths.setOption(option);
    window.onresize = myChartMonths.resize;//随屏幕的大小改变自适应

    myChartMonths.on('click', function (params) {
        window.open('/DMS/ReportForm/dms_customer_brand.aspx?admin_user_name=' + admin_user_name + '&user_id=' + user_id + '&syear=' + syear + '&smonth=' + datetimes[params.dataIndex] + '&month_count=' + month_counts[params.dataIndex] + '&month_frequency=' + month_frequencys[params.dataIndex] + '&rnd=' + Math.random());
    });
}
