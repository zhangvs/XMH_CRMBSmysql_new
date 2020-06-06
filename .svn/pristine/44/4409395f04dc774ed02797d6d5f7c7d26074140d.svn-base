var date = new Date;
var nowMonth = date.getMonth() + 1;
var nowDate = date.getDate();
var workDays;
var nowDays;
var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
var syear;


var mains = new Array();//画图main数组
var datetime;
var datetimes = new Array();
var axisData = new Array(); //x轴

var name;
var admin_user_name;
var user_count = 0;//分配客户数
var cj_count = new Array();//个月成交客户数
var Cjbs = new Array();//成交比,一个人一年中12个月的

var saleData = new Array(); //销售数据
var backData = new Array(); //退货数据
var saleBackData = new Array(); //实际销售数据

var saleDataSums = new Array(); //每个客户的销售数据和
var backDataSums = new Array(); //每个客户的退货数据和
var saleBackDataSums = new Array(); //每个客户的实际数据和

var user_id;
var u_company;
var user_name;
var monthCount;
var salemoneyUser;
var backmoneyUser;
var realmoneyUser;
//用于年客户排序，图二，中间转换变量
var user_id2;
var u_company2;
var user_name2;
var monthCount2;
var salemoneyUser2;
var backmoneyUser2;
var realmoneyUser2;

var user_ids = new Array();//每个月客户名数组，二维
var u_companys = new Array();//每个月客户名数组
var user_names = new Array();//每个月手机号数组

var userIds = new Array();//一年中所有客户名数组，一维
var uCompanys = new Array();//一年中客户名数组
var userNames = new Array();//一年中手机号数组

var salemoneyUsers = new Array();//一年中客户销售合计
var backmoneyUsers = new Array();//一年中客户销售合计
var realmoneyUsers = new Array();//一年中客户销售合计

var month_counts = new Array();//月内客户拿货次数
var month_frequencys = new Array();//月内客户拿货频率，单位天

var month_countsSum = new Array();//月内客户拿货合计，12个月
var month_frequencysSum = new Array();//月内客户拿货合计频率,客服成交频率，。单位小时


var yearSaleDataSum = 0;//所有客户的销售和
var yearBackDataSum = 0;//所有客户的退货和
var yearSaleBackDataSum = 0;//所有客户的实际销售和

var year_counts = new Array();//对应客户的年拿货次数
var year_frequencys = new Array();//对应客户的年拿货频率
var year_countsSum = 0;//对应客户的年拿货次数合计


function clearData() {
    $("#form1").html("");
    mains = [];
    datetimes = [];
    axisData = [];
    //清空
    saleData = [];//销售额：不同客户数据，分月的数据，的二维数组
    backData = [];//退货额：不同客户数据，分月的数据，的二维数组
    saleBackData = [];//实际销售额：不同客户数据，分月的数据，的二维数组
    //清空各个客户的合计
    saleBackDataSums = [];
    saleDataSums = [];
    backDataSums = [];

    user_ids = [];
    u_companys = [];//客户名数组
    user_names = [];//客户名数组

    userIds = [];
    uCompanys = [];
    userNames = [];

    salemoneyUsers = [];
    backmoneyUsers = [];
    realmoneyUsers = [];
    //赋值
    month_counts = [];
    month_frequencys = [];
    month_countsSum = [];
    month_frequencysSum = [];

    yearSaleDataSum = 0;
    yearBackDataSum = 0;
    yearSaleBackDataSum = 0;

    year_counts = [];
    year_frequencys = [];
    year_countsSum = 0;

    Cjbs = [];
    cj_count = [];
}


//个人每日实际销售量
function getMonthSaleBackData(GridData) {
    clearData();

    admin_user_name = GridData.Rows[0].admin_user_name;//客服编号
    name = GridData.Rows[0].name;//客服姓名
    user_count = GridData.Rows[0].user_count;//客服分配员工个数

    var x = 0;
    var seriess_id = 0;//月份个数
    if (GridData.Rows.length>0) {
        datetime = GridData.Rows[0].datetime;
        nowDays = (nowMonth - parseInt(datetime)+1) * 30;
        workDays = (nowMonth - parseInt(datetime)+1) * 25;

        for (var j = 0; j < GridData.Rows.length; j++) {
            datetime = GridData.Rows[j].datetime;

            if ($.inArray(datetime, datetimes) < 0) {

                seriess_id = datetimes.push(datetime) - 1;
                $("#form1").append("<a id='a_main" + seriess_id + "' href='#main" + seriess_id + "'> </a><div id='main" + seriess_id + "' ></div></div><hr style='height:10px;border:none;border-top:10px groove skyblue;' />");
                user_ids[seriess_id] = new Array();//前客户的实际销售额二维数组
                u_companys[seriess_id] = new Array();//前客户的销售额二维数组
                user_names[seriess_id] = new Array();//前客户的实际销售额二维数组
                month_counts[seriess_id] = new Array();//月内客户次数
                month_frequencys[seriess_id] = new Array();//月内客户频率
                month_countsSum[seriess_id] = 0;//初始化月内拿货次数合计
                month_frequencysSum[seriess_id] = 0;//月内合计拿货频率

                saleBackData[seriess_id] = new Array();//前客户的实际销售额二维数组
                saleData[seriess_id] = new Array();//前客户的销售额二维数组
                backData[seriess_id] = new Array();//前客户的退货额二维数组
                saleBackDataSums[seriess_id] = parseFloat(GridData.Rows[j].realmoneyMonth.toFixed());
                saleDataSums[seriess_id] = parseFloat(GridData.Rows[j].salemoneyMonth.toFixed());
                backDataSums[seriess_id] = parseFloat(GridData.Rows[j].backmoneyMonth.toFixed());

                yearSaleBackDataSum += saleBackDataSums[seriess_id];
                yearSaleDataSum += saleDataSums[seriess_id];
                yearBackDataSum += backDataSums[seriess_id];

                x = j;

            }

            //第二图客户年合计
            user_id = GridData.Rows[j].user_id;
            u_company = GridData.Rows[j].u_company;
            user_name = GridData.Rows[j].user_name;
            monthCount = GridData.Rows[j].monthCount;
            if (monthCount == null) {
                monthCount = 0;
            }

            salemoneyUser = parseFloat(GridData.Rows[j].salemoneyUser.toFixed());
            backmoneyUser = parseFloat(GridData.Rows[j].backmoneyUser.toFixed());
            realmoneyUser = parseFloat(GridData.Rows[j].realmoneyUser.toFixed());

            var ii = $.inArray(user_id, userIds);
            if (ii < 0) {
                userIds.push(user_id);
                uCompanys.push(u_company);
                userNames.push(user_name);
                salemoneyUsers.push(salemoneyUser);
                backmoneyUsers.push(backmoneyUser);
                realmoneyUsers.push(realmoneyUser);

                if (monthCount == 0) {
                    year_counts.push(0);
                    year_frequencys.push(0);//客户第一次出现，拿货频率为该年频率
                }
                else {
                    year_counts.push(monthCount);
                    year_frequencys.push(parseFloat(nowDays / monthCount).toFixed());//客户第一次出现，拿货频率为该年频率
                }
            }
            else {
                //客户已存在，拿货频率累加，拿货次数累加；
                year_counts[ii] += monthCount;
                if (year_counts[ii] == 0) {
                    year_frequencys[ii] = 0;
                }
                else {
                    year_frequencys[ii] = parseFloat((nowDays / year_counts[ii]).toFixed());
                }

            }

            user_ids[seriess_id][j - x] = user_id;//客户name
            u_companys[seriess_id][j - x] = u_company;//前客户的销售额二维数组
            user_names[seriess_id][j - x] = user_name;//前客户的实际销售额二维数组

            if (monthCount == 0) {
                month_counts[seriess_id][j - x] = 0;
                month_frequencys[seriess_id][j - x] = 0;//客户月拿货频率数组,单位天
            }
            else {
                month_counts[seriess_id][j - x] = monthCount;
                month_frequencys[seriess_id][j - x] = parseFloat((30 / monthCount).toFixed());//客户月拿货频率数组,单位天
                month_countsSum[seriess_id] += monthCount;
                month_frequencysSum[seriess_id] = parseFloat((25 / month_countsSum[seriess_id] * 8).toFixed(1));//客户月合计频率，单位小时，客服25天工作日
            }

            saleBackData[seriess_id][j - x] = parseFloat(GridData.Rows[j].realmoney.toFixed());//前客户的实际销售额二维数组
            saleData[seriess_id][j - x] = parseFloat(GridData.Rows[j].salemoney.toFixed());//前客户的销售额二维数组
            backData[seriess_id][j - x] = parseFloat(GridData.Rows[j].backmoney.toFixed());//前客户的退货额二维数组

            year_countsSum += monthCount;
        }
    }

    //客户年销量排序
    for (var i = 0; i < realmoneyUsers.length; i++) {
        for (var j = i+1; j < realmoneyUsers.length; j++) {
            if (realmoneyUsers[i] < realmoneyUsers[j]) {
                user_id2 = userIds[i];
                u_company2 = uCompanys[i];
                user_name2 = userNames[i];
                monthCount2 = year_counts[i];
                frequency2 = year_frequencys[i];
                salemoneyUser2 = salemoneyUsers[i];
                backmoneyUser2 = backmoneyUsers[i];
                realmoneyUser2 = realmoneyUsers[i];

                userIds[i] = userIds[j];
                uCompanys[i] = uCompanys[j];
                userNames[i] = userNames[j];
                year_counts[i] = year_counts[j];
                year_frequencys[i] = year_frequencys[j];
                salemoneyUsers[i] = salemoneyUsers[j];
                backmoneyUsers[i] = backmoneyUsers[j];
                realmoneyUsers[i] = realmoneyUsers[j];

                userIds[j] = user_id2;
                uCompanys[j] = u_company2;
                userNames[j] = user_name2;
                year_counts[j] = monthCount2;
                year_frequencys[j] = frequency2;
                salemoneyUsers[j] = salemoneyUser2;
                backmoneyUsers[j] = backmoneyUser2;
                realmoneyUsers[j] = realmoneyUser2;
            }
        }
    }


    for (var i = 0; i < datetimes.length; i++) {
        cj_count[i] = saleBackData[i].length;
        if (user_count == 0) {
            Cjbs[i] = 0;
        }
        else {
            Cjbs[i] = parseFloat((cj_count[i] / user_count * 100).toFixed());
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
    datetimes.forEach(function DrawEChart(v, e) {
        $("#main" + e).css("height", 500);
        var option = {
            title: {
                text: admin_user_name + '_' + name + '_' + v + '月份客户销售明细(点击可查看员工销售客户详情)',
                link: '/DMS/ReportForm/dms_personal_customer.aspx?admin_user_name=' + admin_user_name + '&syear=' + $("#syear").val() + '&smonth=' + v + '&rnd=' + Math.random(),
                subtext: '\n\n客服' +
                        '\n月销售和：' + saleDataSums[e] +
                        '\n月退货和：' + backDataSums[e] +
                        '\n月实际销售和：' + saleBackDataSums[e] +

                        '\n\n月成交客户数：' + cj_count[e] +
                        '\n分配客户数：' + user_count +
                        '\n月成交率：' + parseFloat((cj_count[e] / user_count * 100).toFixed()) + '%' +

                        '\n\n月成交次数：' + month_countsSum[e] +
                        '\n月成交频率：' + month_frequencysSum[e] + '小时/次'
            },
            visualMap: {
                top: 20,
                right: 40,
                min: 0,
                max: 20000,
                pieces: [
                    { min: 20000 }, // 不指定 max，表示 max 为无限大（Infinity）。
                    { min: 10000, max: 20000 },
                    { min: 5000, max: 10000 },
                    { min: 1000, max: 5000, },
                    //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
                    { max: 1000 }     // 不指定 min，表示 min 为无限大（-Infinity）。
                ],
                color: ['#d94e5d', '#eac736', '#50a3ba'],
            },
            grid: {
                x: 180,//靠左200像素
                y2: 200
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter: function (params, ticket, callback) {
                    var res = '可点击查看客户销售月报<br/>' + params[0].name;
                    for (var i = 0, l = params.length; i < l; i++) {
                        res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                    }
                    return res
                }
            },
            legend: {
                data: ['月拿货次数', '月拿货频率(天/次)', '月销售额', '月退货额', '月实际销售额'],
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
                            var hh = (u_companys[e].length + 1) * 19 + 80;
                            if (hh < 500) {
                                hh = 500;
                            }
                            $("#main" + e).css("height", hh);
                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr><td>序号</td><td>客户</td><td>电话</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = u_companys[e].length; m < g; m++) {
                                var no = m + 1;
                                table += '<tr><td>' + no + '</td><td>' + u_companys[e][m] + '</td><td>' + user_names[e][m] + '</td>';
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
                data: u_companys[e]
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
                    type: 'bar',
                    itemStyle: {
                        normal: {
                            label: {
                                show: true,
                                position: 'top'
                            }
                        }
                    },
                    data: saleData[e],
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                }, {
                    name: '月退货额',
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
                    data: backData[e],
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                }, {
                    name: '月实际销售额',
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
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                }, {
                    name: '月拿货次数',
                    type: 'bar',
                    itemStyle: {
                        normal: {
                            label: {
                                show: true,
                                position: 'top'
                            }
                        }
                    },
                    data: month_counts[e],
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                }, {
                    name: '月拿货频率(天/次)',
                    type: 'bar',
                    itemStyle: {
                        normal: {
                            label: {
                                show: true,
                                position: 'top'
                            }
                        }
                    },
                    data: month_frequencys[e],
                    markLine: {
                        data: [
                            { type: 'average', name: '平均值' }
                        ]
                    }
                }]
        };

        var myChart = echarts.init(document.getElementById('main' + e), 'macarons');
        myChart.setOption(option);
        mains.push(myChart);

        myChart.on('click', function (params) {
            window.open('/DMS/ReportForm/dms_customer_brand.aspx?admin_user_name=' + admin_user_name + '&user_id=' + user_ids[e][params.dataIndex] + '&syear=' + $("#syear").val() + '&smonth=' + v +'&month_count=' + month_counts[e][params.dataIndex] + '&month_frequency=' + month_frequencys[e][params.dataIndex]+ '&rnd=' + Math.random());
        });
    });

    //echarts.connect(mains);
}
//随屏幕的大小改变自适应
$(window).resize(function () {
    mains.forEach(function echartsHight(v, e) {
        v.resize();

    })
});
//一年的客户总和
function DrawEChartYearUser() {
    $("#main0").before("<div id='mainUser' ></div>");
    $("#mainUser").css("height", 500);
    var option = {
        title: {
            text: admin_user_name + '_' + name + '_' + $("#syear").val() + '年度客户销售合计汇总',
            subtext: '\n\n客户' +
                    '\n年拿货次数：' + year_countsSum +
                    '\n年销售天数：' + nowDays +
                    '\n年拿货频率数：' + parseFloat((nowDays / year_countsSum * 8).toFixed(1)) + '小时/次'
        },
        grid: {
            x: 180,//靠左200像素
            y2: 200
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            formatter: function (params, ticket, callback) {
                var res = '可点击查看【客户】年报品牌销售情况<br/>' + params[0].name;
                for (var i = 0, l = params.length; i < l; i++) {
                    res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                }
                return res
            }
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['年拿货次数', '年拿货频率(天/次)', '年销售额', '年退货额', '年实际销售额'],
            selected: {
                '年拿货次数': false,
                '年拿货频率(天/次)': false,
                '年销售额': false,
                '年退货额': false,
                '年实际销售额': true,
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
                        var hh = (uCompanys.length + 1) * 19 + 80;
                        if (hh < 500) {
                            hh = 500;
                        }
                        $("#mainUser").css("height", hh);

                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr><td>序号</td><td>客户</td><td>电话</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = uCompanys.length; m < g; m++) {
                            var no = m + 1;
                            table += '<tr><td>' + no + '</td><td>' + uCompanys[m] + '</td><td>' + userNames[m] + '</td>';
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
            data: uCompanys
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
            name: '年拿货次数',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: year_counts,
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }, {
            name: '年拿货频率(天/次)',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: year_frequencys,
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        },
        {
            name: '年销售额',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: salemoneyUsers,
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }, {
            name: '年退货额',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'bottom'
                    }
                }
            },
            data: backmoneyUsers,
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }, {
            name: '年实际销售额',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: realmoneyUsers,
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }]
    };

    var myChartUser = echarts.init(document.getElementById('mainUser'), 'chalk');
    myChartUser.setOption(option);
    window.onresize = myChartUser.resize;//随屏幕的大小改变自适应

    myChartUser.on('click', function (params) {
        window.open('/DMS/ReportForm/dms_customer_year_brand.aspx?admin_user_name=' + admin_user_name + '&user_id=' + userIds[params.dataIndex] + '&syear=' + $("#syear").val() + '&year_count=' + year_counts[params.dataIndex] + '&year_frequency=' + year_frequencys[params.dataIndex] + '&rnd=' + Math.random());
    });
}

//画图
function DrawEChartMonths() {
    $("#main0").before("<div id='main' ></div>");
    $("#main").css("height", 500);
    var option = {
        title: {
            text: admin_user_name + '_' + name + '_'+$("#syear").val() + '年度客服各月份客户销售对比',
            subtext: '\n\n客服'+
                    '\n年销量：' + yearSaleDataSum +
                    '\n年退货：' + yearBackDataSum +
                    '\n年实际：' + yearSaleBackDataSum +

                    '\n\n年成交客户数：' + userIds.length +
                    '\n分配客户数：' + user_count +
                    '\n年成交比：' + parseFloat((userIds.length / user_count * 100).toFixed()) + '%' +
                    
                    '\n\n年成交次数：' + year_countsSum +
                    '\n年工作日天数：' + workDays +
                    '\n年成交频率数：' + parseFloat((workDays / year_countsSum * 8).toFixed(1)) + '小时/次'
        },
        grid: {
            x: 180,//靠左200像素
            y2: 200
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
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['月成交客户数', '月成交比', '月成交次数', '月成交频率(小时/次)', '月销售额', '月退货额', '月实际销售额'],
            selected: {
                '月成交客户数': true,
                '月成交比': false,
                '月成交次数': true,
                '月成交频率(小时/次)': false,
                '月销售额': false,
                '月退货额': false,
                '月实际销售额': false,
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
                        for (var m = 0, g = datetimes.length; m < g; m++) {
                            table += '<tr><td>' + datetimes[m] + '月</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m];
                                if (n == 1) val += '%';
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
            axisLabel : {
                formatter: function(value)
                {
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
        series: [{
            name: '月成交客户数',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: cj_count,
            markPoint: {
                data: [
                    { type: 'max', name: '最大值' },
                    { type: 'min', name: '最小值' }
                ]
            },
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }, {
            name: '月成交比',
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
            data: Cjbs,
            markPoint: {
                data: [
                    { type: 'max', name: '最大值' },
                    { type: 'min', name: '最小值' }
                ]
            },
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }, {
            name: '月成交次数',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: month_countsSum,
            markPoint: {
                data: [
                    { type: 'max', name: '最大值' },
                    { type: 'min', name: '最小值' }
                ]
            },
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }, {
            name: '月成交频率(小时/次)',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: month_frequencysSum,
            markPoint: {
                data: [
                    { type: 'max', name: '最大值' },
                    { type: 'min', name: '最小值' }
                ]
            },
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        },
        {
            name: '月销售额',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: saleDataSums,
            markPoint: {
                data: [
                    { type: 'max', name: '最大值' },
                    { type: 'min', name: '最小值' }
                ]
            },
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }, {
            name: '月退货额',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'bottom'
                    }
                }
            },
            data: backDataSums,
            markPoint: {
                data: [
                    { type: 'max', name: '最大值' },
                    { type: 'min', name: '最小值' }
                ]
            },
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }, {
            name: '月实际销售额',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: saleBackDataSums,
            markPoint: {
                data: [
                    { type: 'max', name: '最大值' },
                    { type: 'min', name: '最小值' }
                ]
            },
            markLine: {
                data: [
                    { type: 'average', name: '平均值' }
                ]
            }
        }]
    };

    var myChartYear = echarts.init(document.getElementById('main'), 'purple-passion');
    myChartYear.setOption(option);
    window.onresize = myChartYear.resize;//随屏幕的大小改变自适应

    myChartYear.on('click', function (params) {
        document.getElementById("a_main" + params.dataIndex).click();
    });
}


