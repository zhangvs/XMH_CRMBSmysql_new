var date = new Date;
var nowMonth = date.getMonth() + 1;
var nowDate = date.getDate();
var workDays;

var monthEmps = new Array();//每个月每个人
var monthDeps = new Array();//每个月每个人
var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height//部门颜色变量
var colorList = [
  '#D7504B', '#C6E579', '#F4E001', '#F0805A', '#26C0C0',
  '#ff7f50', '#87cefa', '#da70d6', '#32cd32', '#6495ed',
  '#ff69b4', '#ba55d3', '#cd5c5c', '#ffa500', '#40e0d0',
  '#C1232B', '#B5C334', '#FCCE10', '#E87C25', '#27727B',
  '#FE8463', '#9BCA63', '#FAD860', '#F3A43B', '#60C0DD'
];

//一个人一个月
var datetime;
var emp_code;
var name;
var d_pid;
var d_pname;

var salemoney;
var backmoney;
var realmoney;
var user_count;
var deal_count;
var deal_rate;
var deal_number;
var deal_frequency;
//一个人一年和
var salemoneyEmp;
var backmoneyEmp;
var realmoneyEmp;
//一个部门一年和
var salemoneyDep;
var backmoneyDep;
var realmoneyDep;

var datetimes = new Array();
var emp_codes = new Array();
var names = new Array();
var d_pids = new Array();
var d_pnames = new Array();
var salemoneys = new Array();
var backmoneys = new Array();
var realmoneys = new Array();
var user_counts = new Array();
var deal_counts = new Array();
var deal_rates = new Array();
var deal_numbers = new Array();
var deal_frequencys = new Array();

//每个人每个月和
var salemoneyMonthSum = new Array();
var backmoneyMonthSum = new Array();
var realmoneyMonthSum = new Array();
var user_countMonthSum = new Array();//当月“做业务”的所有客服，所分配的客户数，没有业务的客服即使分配了客户数，也不统计在内
var deal_countMonthSum = new Array();
var deal_ratesMonthSum = new Array();
var deal_numberMonthSum = new Array();
var deal_frequencyMonthSum = new Array();

//每个人一年所有月份的和，循环第一次放入，第二次累加
var emp_codes_EmpYearSum = new Array();
var names_EmpYearSum = new Array();
var salemoneyEmpYearSum = new Array();
var backmoneyEmpYearSum = new Array();
var realmoneyEmpYearSum = new Array();
var user_countEmpYearSum = new Array();//每个人分配的客户数不再累计，每个月都是固定的
var deal_countEmpYearSum = new Array();
var deal_ratesEmpYearSum = new Array();
var deal_numberEmpYearSum = new Array();
var deal_frequencyEmpYearSum = new Array();//parseFloat((300 / year_countsSum * 8).toFixed()),300天工作日/年拿货次数，单位分钟

//年合计
var salemoneyYearSum = 0;
var backmoneyYearSum = 0;
var realmoneyYearSum = 0;
var user_countYearSum = 0;
var deal_countYearSum = 0;
var deal_ratesYearSum = 0;
var deal_numberYearSum = 0;
var deal_frequencyYearSum = 0;

//每部门一年和
var salemoneyDepYearSum = new Array();
var backmoneyDepYearSum = new Array();
var realmoneyDepYearSum = new Array();
var user_countDepYearSum = new Array();
var deal_countDepYearSum = new Array();
var deal_ratesDepYearSum = new Array();
var deal_numberDepYearSum = new Array();
var deal_frequencyDepYearSum = new Array();

//每部门每个月
var d_pnamesDepMonth = new Array();
var salemoneyDepMonthSum = new Array();
var backmoneyDepMonthSum = new Array();
var realmoneyDepMonthSum = new Array();
var user_countDepMonthSum = new Array();
var deal_countDepMonthSum = new Array();
var deal_ratesDepMonthSum = new Array();
var deal_numberDepMonthSum = new Array();
var deal_frequencyDepMonthSum = new Array();

function clearData() {
    $("#form1").html("");
    monthEmps = [];
    monthDeps = [];
    datetimes = [];
    emp_codes = [];
    names = [];
    d_pids = [];
    d_pnames = [];
    salemoneys = [];
    backmoneys = [];
    realmoneys = [];
    user_counts = [];
    deal_counts = [];
    deal_rates = [];
    deal_numbers = [];
    deal_frequencys = [];

    salemoneyMonthSum = [];
    backmoneyMonthSum = [];
    realmoneyMonthSum = [];
    user_countMonthSum = [];
    deal_countMonthSum = [];
    deal_ratesMonthSum = [];
    deal_numberMonthSum = [];
    deal_frequencyMonthSum = [];

    emp_codes_EmpYearSum = [];
    names_EmpYearSum = [];
    salemoneyEmpYearSum = [];
    backmoneyEmpYearSum = [];
    realmoneyEmpYearSum = [];
    user_countEmpYearSum = [];
    deal_countEmpYearSum = [];
    deal_ratesEmpYearSum = [];
    deal_numberEmpYearSum = [];
    deal_frequencyEmpYearSum = [];

    salemoneyYearSum = 0;
    backmoneyYearSum = 0;
    realmoneyYearSum = 0;
    user_countYearSum = 0;
    deal_countYearSum = 0;
    deal_ratesYearSum = 0;
    deal_numberYearSum = 0;
    deal_frequencyYearSum = 0;

    salemoneyDepYearSum = [];
    backmoneyDepYearSum = [];
    realmoneyDepYearSum = [];
    user_countDepYearSum = [];
    deal_countDepYearSum = [];
    deal_ratesDepYearSum = [];
    deal_numberDepYearSum = [];
    deal_frequencyDepYearSum = [];

    d_pnamesDepMonth = [];
    salemoneyDepMonthSum = [];
    backmoneyDepMonthSum = [];
    realmoneyDepMonthSum = [];
    user_countDepMonthSum = [];
    deal_countDepMonthSum = [];
    deal_ratesDepMonthSum = [];
    deal_numberDepMonthSum = [];
    deal_frequencyDepMonthSum = [];
}


function getNodeDataVal(array, value, color) {
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

//个人每月实际销售量
function getMonthSaleBackData(GridData, smonth) {
    clearData();
    var _id = 0;
    var x = 0;
    //赋值
    if (GridData.Rows.length > 0) {
        datetime = GridData.Rows[0].datetime;
        workDays = (nowMonth - parseInt(datetime) + 1) * 25;

        for (var j = 0; j < GridData.Rows.length; j++) {
            //一个人一个月的数据,读取数据并赋值
            datetime = GridData.Rows[j].datetime;
            d_pid = GridData.Rows[j].d_pid;
            d_pname = GridData.Rows[j].d_pname;//部门name
            emp_code = GridData.Rows[j].emp_code;//客服name
            name =emp_code + "_" + GridData.Rows[j].name;//客服name

            user_count = parseFloat(GridData.Rows[j].user_count.toFixed());//客服分配客户数
            deal_count = parseFloat(GridData.Rows[j].deal_count.toFixed());//客服成交客户数
            deal_rate = parseFloat(GridData.Rows[j].deal_rate.toFixed());//客服成交客户数

            deal_number = parseFloat(GridData.Rows[j].deal_number.toFixed());//客服月成交次数
            deal_frequency = parseFloat(GridData.Rows[j].deal_frequency.toFixed(1));//客服月成交次数

            salemoney = parseFloat(GridData.Rows[j].salemoney.toFixed());
            backmoney = parseFloat(GridData.Rows[j].backmoney.toFixed());
            realmoney = parseFloat(GridData.Rows[j].realmoney.toFixed());

            if ($.inArray(datetime, datetimes) < 0) {
                _id = datetimes.push(datetime) - 1;//如果第一次出现，添加到数组中,返回前放入元素的id,返回值-1为数组角标
                $("#form1").append("<a id='a_monthDep" + _id + "' href='#monthDep" + _id + "'> </a><div id='monthDep" + _id + "' ></div>");
                $("#form1").append("<a id='a_monthEmp" + _id + "' href='#monthEmp" + _id + "'> </a><div id='monthEmp" + _id + "' ></div><hr style='height:10px;border:none;border-top:10px groove skyblue;' />");
                //一个月的数据初始二维数组
                emp_codes[_id] = new Array();
                names[_id] = new Array();
                realmoneys[_id] = new Array();
                salemoneys[_id] = new Array();
                backmoneys[_id] = new Array();
                user_counts[_id] = new Array();
                deal_counts[_id] = new Array();
                deal_rates[_id] = new Array();
                deal_numbers[_id] = new Array();
                deal_frequencys[_id] = new Array();

                salemoneyMonthSum[_id] = 0;
                backmoneyMonthSum[_id] = 0;
                realmoneyMonthSum[_id] = 0;
                user_countMonthSum[_id] = 0;
                deal_countMonthSum[_id] = 0;
                deal_ratesMonthSum[_id] = 0;
                deal_numberMonthSum[_id] = 0;
                deal_frequencyMonthSum[_id] = 0;

                d_pnamesDepMonth[_id] = new Array();
                salemoneyDepMonthSum[_id] = new Array();
                backmoneyDepMonthSum[_id] = new Array();
                realmoneyDepMonthSum[_id] = new Array();
                user_countDepMonthSum[_id] = new Array();
                deal_countDepMonthSum[_id] = new Array();
                deal_ratesDepMonthSum[_id] = new Array();
                deal_numberDepMonthSum[_id] = new Array();
                deal_frequencyDepMonthSum[_id] = new Array();

                x = j;
            }

            emp_codes[_id][j - x] = emp_code;//把数据赋值给对应的月份角标
            names[_id][j - x] = name;
            salemoneys[_id][j - x] = salemoney;
            backmoneys[_id][j - x] = backmoney;
            realmoneys[_id][j - x] = realmoney;
            user_counts[_id][j - x] = user_count;
            deal_counts[_id][j - x] = deal_count;
            deal_rates[_id][j - x] = deal_rate;
            deal_numbers[_id][j - x] = deal_number;
            deal_frequencys[_id][j - x] = deal_frequency;

            //每个人每个月合计
            salemoneyMonthSum[_id] += salemoney;
            backmoneyMonthSum[_id] += backmoney;
            realmoneyMonthSum[_id] += realmoney;
            user_countMonthSum[_id] += user_count;
            deal_countMonthSum[_id] += deal_count;
            deal_ratesMonthSum[_id] = parseFloat((deal_countMonthSum[_id] / user_countMonthSum[_id] * 100).toFixed(1));
            deal_numberMonthSum[_id] += deal_number;
            deal_frequencyMonthSum[_id] = parseFloat((25 / deal_numberMonthSum[_id] * 8 * 60).toFixed(1));


            //每个月部门合计
            var depMonth_index = $.inArray(d_pname, d_pnamesDepMonth[_id]);
            if (depMonth_index < 0) {
                //不存在开启新数组下标
                var d = d_pnamesDepMonth[_id].push(d_pname) - 1;
                salemoneyDepMonthSum[_id][d] = salemoney;
                backmoneyDepMonthSum[_id][d] = backmoney;
                realmoneyDepMonthSum[_id][d] = realmoney;
                user_countDepMonthSum[_id][d] = user_count;
                deal_countDepMonthSum[_id][d] = deal_count;
                deal_ratesDepMonthSum[_id][d] = deal_rate;
                deal_numberDepMonthSum[_id][d] = deal_number;
                deal_frequencyDepMonthSum[_id][d] = deal_frequency;
            }
            else {
                //存在,累加
                salemoneyDepMonthSum[_id][depMonth_index] += salemoney;
                backmoneyDepMonthSum[_id][depMonth_index] += backmoney;
                realmoneyDepMonthSum[_id][depMonth_index] += realmoney;
                user_countDepMonthSum[_id][depMonth_index] += user_count;
                deal_countDepMonthSum[_id][depMonth_index] += deal_count;//成交累加
                if (user_countDepMonthSum[_id][depMonth_index] == 0) {
                    deal_ratesDepMonthSum[_id][depMonth_index] = 0;
                }
                else {
                    deal_ratesDepMonthSum[_id][depMonth_index] = parseFloat((deal_countDepMonthSum[_id][depMonth_index] / user_countDepMonthSum[_id][depMonth_index] * 100).toFixed(1));
                }

                deal_numberDepMonthSum[_id][depMonth_index] += deal_number;//成交次数累加
                deal_frequencyDepMonthSum[_id][depMonth_index] = parseFloat((workDays / deal_numberDepMonthSum[_id][depMonth_index] * 8*60).toFixed(1));//频率
            }






            //每个人年合计，便利每个人
            var emp_index = $.inArray(emp_code,emp_codes_EmpYearSum);
            if (emp_index < 0) {
                //不存在开启新数组下标
                var a = emp_codes_EmpYearSum.push(emp_code)-1;
                names_EmpYearSum.push(name);
                salemoneyEmpYearSum[a] = salemoney;
                backmoneyEmpYearSum[a] = backmoney;
                realmoneyEmpYearSum[a] = realmoney;
                user_countEmpYearSum[a] = user_count;
                deal_countEmpYearSum[a] = deal_count;
                deal_ratesEmpYearSum[a] = deal_rate;
                deal_numberEmpYearSum[a] = deal_number;
                deal_frequencyEmpYearSum[a] = deal_frequency;

            }
            else {
                //存在,累加
                salemoneyEmpYearSum[emp_index] += salemoney;
                backmoneyEmpYearSum[emp_index] += backmoney;
                realmoneyEmpYearSum[emp_index] += realmoney;
                deal_countEmpYearSum[emp_index] += deal_count;//成交累加
                if (user_countEmpYearSum[emp_index] == 0) {
                    deal_ratesEmpYearSum[emp_index] = 0;
                }
                else {
                    deal_ratesEmpYearSum[emp_index] = parseFloat((deal_countEmpYearSum[emp_index] / user_countEmpYearSum[emp_index] * 100).toFixed());
                }

                deal_numberEmpYearSum[emp_index] += deal_number;//成交次数累加
                deal_frequencyEmpYearSum[emp_index] = parseFloat((workDays / deal_numberEmpYearSum[emp_index] * 8).toFixed(1));//频率
            }

            //一个月内的各个部门数据
            var dep_index = $.inArray(d_pname, d_pnames);
            if (dep_index < 0) {
                //不存在开启新数组下标
                var b = d_pnames.push(d_pname) - 1;
                salemoneyDepYearSum[b] = salemoney;
                backmoneyDepYearSum[b] = backmoney;
                realmoneyDepYearSum[b] = realmoney;
                user_countDepYearSum[b] = user_count;
                deal_countDepYearSum[b] = deal_count;
                deal_ratesDepYearSum[b] = deal_rate;
                deal_numberDepYearSum[b] = deal_number;
                deal_frequencyDepYearSum[b] = deal_frequency;
            }
            else {
                //存在,累加
                salemoneyDepYearSum[dep_index] += salemoney;
                backmoneyDepYearSum[dep_index] += backmoney;
                realmoneyDepYearSum[dep_index] += realmoney;
                user_countDepYearSum[dep_index] += user_count;
                deal_countDepYearSum[dep_index] += deal_count;//成交累加
                if (user_countDepYearSum[dep_index] == 0) {
                    deal_ratesDepYearSum[dep_index] = 0;
                }
                else {
                    deal_ratesDepYearSum[dep_index] = parseFloat((deal_countDepYearSum[dep_index] / user_countDepYearSum[dep_index] * 100).toFixed());
                }

                deal_numberDepYearSum[dep_index] += deal_number;//成交次数累加
                deal_frequencyDepYearSum[dep_index] = parseFloat((workDays / deal_numberDepYearSum[dep_index] * 8).toFixed(1));//频率
            }

            //年合计
            salemoneyYearSum += salemoney;
            backmoneyYearSum += backmoney;
            realmoneyYearSum += realmoney;
            user_countYearSum += user_count;
            deal_countYearSum += deal_count;
            deal_numberYearSum += deal_number;
            
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
        $("#monthDep" + e).css("height", 500);
        var option = {
            title: {
                text: v + '月份部门客户销售汇总',
                subtext:'\n部门个数：' + d_pnamesDepMonth[e].length +
                    '\n\n月销量：' + salemoneyMonthSum[e] +
                    '\n月退货：' + backmoneyMonthSum[e] +
                    '\n月实际：' + realmoneyMonthSum[e] +

                    '\n\n月成交客户总数：' + user_countMonthSum[e] +
                    '\n分配客户总数：' + deal_countMonthSum[e] +
                    '\n月总成交比：' + deal_ratesMonthSum[e] + '%' +

                    '\n\n月成交次数：' + deal_numberMonthSum[e] + '次' +
                    '\n月成交频率：' + deal_frequencyMonthSum[e] + '分钟/次'
            },
            grid: {
                x: 180,//靠左200像素
                y2: 150
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0
            },
            legend: {
                data: ['月成交客户数', '月分配客户数', '月成交比', '月成交次数', '月成交频率(分钟/次)', '月销售额', '月退货额', '月实际销售额'],
                selected: {
                    '月成交客户数': true,
                    '月分配客户数': false,
                    '月成交次数': true,
                    '月成交频率(分钟/次)': false,
                    '月成交比': false,
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
                            var hh = (d_pnamesDepMonth[e].length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                            if (hh < 500) {
                                hh = 500;
                            }
                            $("#monthDep" + e).css("height", hh);
                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>序号</td>' + '<td>部门</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = d_pnamesDepMonth[e].length; m < g; m++) {
                                var no = m + 1;
                                table += '<tr><td>' + no + '</td><td>' + d_pnamesDepMonth[e][m] + '</td>';
                                for (var n = 0, l = series.length; n < l; n++) {
                                    var val = series[n].data[m];
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
                data: d_pnamesDepMonth[e],
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: deal_countDepMonthSum[e],
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
                name: '月分配客户数',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: user_countDepMonthSum[e],
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
                data: deal_ratesDepMonthSum[e],
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: salemoneyDepMonthSum[e],
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: backmoneyDepMonthSum[e],
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: realmoneyDepMonthSum[e],
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: deal_numberDepMonthSum[e],
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
                name: '月成交频率(分钟/次)',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: deal_frequencyDepMonthSum[e],
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

        var myChartMonthDep = echarts.init(document.getElementById('monthDep' + e), 'shine');
        myChartMonthDep.setOption(option);
        monthDeps.push(myChartMonthDep);


        $("#monthEmp" + e).css("height", 500);
        var option = {
            title: {
                text: v + '月份个人客户销售汇总',
                subtext:'\n员工个数：' + emp_codes[e].length +
                    '\n\n月销量：' + salemoneyMonthSum[e] +
                    '\n月退货：' + backmoneyMonthSum[e] +
                    '\n月实际：' + realmoneyMonthSum[e] +

                    '\n\n月成交客户总数：' + user_countMonthSum[e] +
                    '\n分配客户总数：' + deal_countMonthSum[e] +
                    '\n月总成交比：' + deal_ratesMonthSum[e] + '%' +

                    '\n\n月成交次数：' + deal_numberMonthSum[e] + '次' +
                    '\n月成交频率：' + deal_frequencyMonthSum[e] + '分钟/次'
            },
            grid: {
                x: 180,//靠左200像素
                y2: 150
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter: function (params, ticket, callback) {
                    var res = '可点击查看员工客户销售月报详情<br/>' + params[0].name;
                    for (var i = 0, l = params.length; i < l; i++) {
                        res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                    }
                    return res
                }
            },
            legend: {
                data: ['月成交客户数', '月分配客户数', '月成交比', '月成交次数', '月成交频率(小时/次)', '月销售额', '月退货额', '月实际销售额'],
                selected: {
                    '月成交客户数': true,
                    '月分配客户数': false,
                    '月成交次数': false,
                    '月成交频率(小时/次)': false,
                    '月成交比': false,
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
                            var hh = (emp_codes[e].length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                            if (hh < 500) {
                                hh = 500;
                            }
                            $("#monthEmp" + e).css("height", hh);
                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>序号</td>' + '<td>员工</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = emp_codes[e].length; m < g; m++) {
                                var no = m + 1;
                                table += '<tr><td>' + no + '</td><td>' + names[e][m] + '</td>';
                                for (var n = 0, l = series.length; n < l; n++) {
                                    var val = series[n].data[m];
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
                data: names[e]
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: deal_counts[e],
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
                name: '月分配客户数',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: user_counts[e],
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
                data: deal_rates[e],
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: salemoneys[e],
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: backmoneys[e],
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: deal_numbers[e],
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
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: deal_frequencys[e],
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

        var myChartMonthEmp = echarts.init(document.getElementById('monthEmp' + e), 'macarons');
        myChartMonthEmp.setOption(option);
        monthEmps.push(myChartMonthEmp);

        myChartMonthEmp.on('click', function (params) {
            window.open('/DMS/ReportForm/dms_personal_customer.aspx?admin_user_name=' + emp_codes[e][params.dataIndex] + '&syear=' + $("#syear").val() + '&smonth=' + v + '&rnd=' + Math.random());
        });
    });

}
//随屏幕的大小改变自适应
$(window).resize(function () {
    monthDeps.forEach(function echartsHight(v, e) {
        v.resize();
    })
});

$(window).resize(function () {
    monthEmps.forEach(function echartsHight(v, e) {
        v.resize();
    })
});

function DrawEChartYearDep() {
    $("#monthDep0").before("<div id='yearDep' ></div>");
    $("#yearDep").css("height", 500);
    var option = {
        title: {
            text: $("#syear").val() + '年度部门客户销售汇总',
            subtext: '\n年销量：' + salemoneyYearSum +
                    '\n年退货：' + backmoneyYearSum +
                    '\n年实际：' + realmoneyYearSum +

                    '\n\n年成交客户数：' + deal_countYearSum +
                    '\n分配客户数：' + user_countYearSum +
                    '\n年成交比：' + parseFloat((deal_countYearSum / user_countYearSum * 100).toFixed(1)) + '%' +

                    '\n\n年成交次数：' + deal_numberYearSum +
                    '\n年工作日天数：' + workDays +
                    '\n年成交频率数：' + parseFloat((workDays / deal_numberYearSum * 8 * 60).toFixed(1)) + '分钟/次'
        },
        grid: {
            x: 180,//靠左200像素
            y2: 200
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['年成交客户数', '年分配客户数', '年成交比', '年成交次数', '年成交频率(分钟/次)', '年销售额', '年退货额', '年实际销售额'],
            selected: {
                '年成交客户数': true,
                '年分配客户数': false,
                '年成交比': false,
                '年成交次数': true,
                '年成交频率(分钟/次)': false,
                '年销售额': false,
                '年退货额': false,
                '年实际销售额': false,
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
                        if (hh < 500) {
                            hh = 500;
                        }
                        $("#yearDep").css("height", hh);
                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>序号</td>' + '<td>部门</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = d_pnames.length; m < g; m++) {
                            var no = m + 1;
                            table += '<tr><td>' + no + '</td><td>' + d_pnames[m] + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m];
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
            splitArea: {
                show: true
            }
        }],
        series: [{
            name: '年成交客户数',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: deal_countDepYearSum,
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
            name: '年分配客户数',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: user_countDepYearSum,
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
            name: '年成交比',
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
            data: deal_ratesDepYearSum,
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
            name: '年成交次数',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: deal_numberDepYearSum,
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
            name: '年成交频率(分钟/次)',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: deal_frequencyDepYearSum,
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
            data: salemoneyDepYearSum,
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
            data: backmoneyDepYearSum,
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
            data: realmoneyDepYearSum,
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

    var myChartYearDep = echarts.init(document.getElementById('yearDep'), 'chalk');
    myChartYearDep.setOption(option);
    window.onresize = myChartYearDep.resize;//随屏幕的大小改变自适应

}

function DrawEChartYearEmp() {
    $("#monthDep0").before("<div id='yearEmp' ></div>");
    $("#yearEmp").css("height", 500);
    var option = {
        title: {
            text: $("#syear").val() + '年度客服客户销售汇总',
            subtext:'\n年销量：' + salemoneyYearSum +
                    '\n年退货：' + backmoneyYearSum +
                    '\n年实际：' + realmoneyYearSum +

                    '\n\n年成交客户数：' + deal_countYearSum +
                    '\n分配客户数：' + user_countYearSum +
                    '\n年成交比：' + parseFloat((deal_countYearSum / user_countYearSum * 100).toFixed(1)) + '%' +

                    '\n\n年成交次数：' + deal_numberYearSum +
                    '\n年工作日天数：' + workDays +
                    '\n年成交频率数：' + parseFloat((workDays / deal_numberYearSum * 8*60).toFixed(1)) + '分钟/次'
        },
        grid: {
            x: 180,//靠左200像素
            y2: 200
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            formatter: function (params, ticket, callback) {
                var res = '可点击查看员工客户销售年报详情<br/>' + params[0].name;
                for (var i = 0, l = params.length; i < l; i++) {
                    res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                }
                return res
            }
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['年成交客户数', '年分配客户数', '年成交比', '年成交次数', '年成交频率(小时/次)', '年销售额', '年退货额', '年实际销售额'],
            selected: {
                '年成交客户数': true,
                '年分配客户数': false,
                '年成交比': false,
                '年成交次数': false,
                '年成交频率(小时/次)': false,
                '年销售额': false,
                '年退货额': false,
                '年实际销售额': false,
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
                        var hh = (emp_codes_EmpYearSum.length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                        if (hh < 500) {
                            hh = 500;
                        }
                        $("#yearEmp").css("height", hh);
                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>序号</td>' + '<td>员工</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = emp_codes_EmpYearSum.length; m < g; m++) {
                            var no = m + 1;
                            table += '<tr><td>' + no + '</td><td>' + names_EmpYearSum[m] + '</td>';
                            for (var n = 0, l = series.length; n < l; n++) {
                                var val = series[n].data[m];
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
            data: names_EmpYearSum
        }],
        yAxis: [{
            type: 'value',
            scale: true,
            splitArea: {
                show: true
            }
        }],
        series: [{
            name: '年成交客户数',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: deal_countEmpYearSum,
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
            name: '年分配客户数',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: user_countEmpYearSum,
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
            name: '年成交比',
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
            data: deal_ratesEmpYearSum,
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
            name: '年成交次数',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: deal_numberEmpYearSum,
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
            name: '年成交频率(小时/次)',
            type: 'bar',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: deal_frequencyEmpYearSum,
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
            data: salemoneyEmpYearSum,
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
            data: backmoneyEmpYearSum,
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
            data: realmoneyEmpYearSum,
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

    var myChartYearEmp = echarts.init(document.getElementById('yearEmp'), 'chalk');
    myChartYearEmp.setOption(option);
    window.onresize = myChartYearEmp.resize;//随屏幕的大小改变自适应

    myChartYearEmp.on('click', function (params) {
        window.open('/DMS/ReportForm/dms_personal_customer_year.aspx?admin_user_name=' + emp_codes_EmpYearSum[params.dataIndex] + '&syear=' + $("#syear").val() + '&rnd=' + Math.random());
    });
}



//画图
function DrawEChartYearMonths() {
    $("#monthDep0").before("<div id='yearMonths' ></div>");
    $("#yearMonths").css("height", 500);
    var option = {
        title: {
            text:  $("#syear").val() + '年度各月份客户销售对比',
            subtext: 
                    '\n年销量：' + salemoneyYearSum +
                    '\n年退货：' + backmoneyYearSum +
                    '\n年实际：' + realmoneyYearSum +

                    '\n\n年成交客户数：' + deal_countYearSum +
                    '\n分配客户数：' + user_countYearSum +
                    '\n年成交比：' + parseFloat((deal_countYearSum / user_countYearSum * 100).toFixed(1)) + '%' +

                    '\n\n年成交次数：' + deal_numberYearSum +
                    '\n年工作日天数：' + workDays +
                    '\n年成交频率数：' + parseFloat((workDays / deal_numberYearSum * 8*60).toFixed(1)) + '分钟/次'
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
            data: ['月成交客户数', '月成交比', '月成交次数', '月成交频率(分钟/次)', '月销售额', '月退货额', '月实际销售额'],
            selected: {
                '月成交客户数': true,
                '月成交比': false,
                '月成交次数': true,
                '月成交频率(分钟/次)': false,
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
            data: deal_countMonthSum,
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
            data: deal_ratesMonthSum,
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
            data: deal_numberMonthSum,
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
            name: '月成交频率(分钟/次)',
            type: 'line',
            itemStyle: {
                normal: {
                    label: {
                        show: true,
                        position: 'top'
                    }
                }
            },
            data: deal_frequencyMonthSum,
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
            data: salemoneyMonthSum,
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
            data: backmoneyMonthSum,
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
            data: realmoneyMonthSum,
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

    var myChartYearMonths = echarts.init(document.getElementById('yearMonths'), 'purple-passion');
    myChartYearMonths.setOption(option);
    window.onresize = myChartYearMonths.resize;//随屏幕的大小改变自适应

    myChartYearMonths.on('click', function (params) {
        document.getElementById("a_monthDep" + params.dataIndex).click();
    });
}