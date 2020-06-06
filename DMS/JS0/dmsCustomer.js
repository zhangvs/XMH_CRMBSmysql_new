var mains = new Array();//画图main数组
var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
var daycount = 0; //月份天数
var axisData = new Array(); //x轴

var saleData = new Array(); //销售数据
var backData = new Array(); //退货数据
var saleBackData = new Array(); //实际销售数据

var saleDataSums = new Array(); //每个客户的销售数据和
var backDataSums = new Array(); //每个客户的退货数据和
var saleBackDataSums = new Array(); //每个客户的实际数据和

var monthSaleDataSum = 0;//所有客户的销售和
var monthBackDataSum = 0;//所有客户的退货和
var monthSaleBackDataSum = 0;//所有客户的实际销售和

var user_id;
var u_company;
var user_name;

var user_ids = new Array();//客户名数组
var u_companys = new Array();//客户名数组
var user_names = new Array();//手机号数组

var monthCount;//月内次数
var month_counts = new Array();
var month_frequencys = new Array();
var month_countsSum=0;
var month_frequencysSum = 0;

var user_count=0;//分配客户数
var name;
var admin_user_name;




//日期天数
function getDateCount(syear, smonth) {
    daycount = 0;
    //构造一个日期对象：
    var day = new Date(syear, smonth, 0);
    //获取天数：
    daycount = day.getDate();

}

//x轴
function showAxisData() {
    axisData = [];
    for (var j = 0; j < daycount; j++) {
            axisData[j] = j + 1 + "日";
        }
}



//个人每日实际销售量
function getMonthSaleBackData(GridData, smonth) {
    $("#form1").html("");
    mains = [];

    user_ids = [];//客户ID数组
    u_companys = [];//客户名数组
    user_names = [];//客户名数组
    //清空
    saleData = [];//销售额：不同客户数据，分月的数据，的二维数组
    backData = [];//退货额：不同客户数据，分月的数据，的二维数组
    saleBackData = [];//实际销售额：不同客户数据，分月的数据，的二维数组
    //清空各个客户的合计
    saleBackDataSums = [];
    saleDataSums = [];
    backDataSums = [];

    monthSaleDataSum = 0;
    monthBackDataSum = 0;
    monthSaleBackDataSum = 0;

    month_counts = [];
    month_frequencys = [];
    month_countsSum = 0;
    month_frequencysSum = 0;
    //赋值
    for (var j = 0; j < GridData.Rows.length; j++) {
        if (j == 0) {
            admin_user_name = GridData.Rows[j].admin_user_name;//客服编号
            name = GridData.Rows[j].name;//客服姓名
            user_count = GridData.Rows[j].user_count;//客服分配客户数
        }
        user_id = GridData.Rows[j].user_id;//客户name
        u_company = GridData.Rows[j].u_company;//客户name
        user_name = GridData.Rows[j].user_name;//客户name
        monthCount = GridData.Rows[j].monthCount;//月内拿货次数



        if ($.inArray(user_id, user_ids) < 0) {
            var seriess_id = user_ids.push(user_id) - 1;//如果第一次出现，添加到数组中,返回前放入元素的id,返回值-1为数组角标
            u_companys.push(u_company);
            user_names.push(user_name);

            if (monthCount == null) {
                month_counts.push(0);//月内次数
                month_frequencys.push(0);//月内频率
            }
            else {
                month_counts.push(monthCount);//月内次数
                month_frequencys.push(parseFloat((30 / monthCount).toFixed()));//月内频率
            }

            $("#form1").append("<a id='a_main" + seriess_id + "' href='#main" + seriess_id + "'> </a><div id='main" + seriess_id + "' ></div>");
            saleBackData[seriess_id] = new Array();//前客户的实际销售额二维数组
            saleData[seriess_id] = new Array();//前客户的销售额二维数组
            backData[seriess_id] = new Array();//前客户的退货额二维数组

            saleBackDataSums[seriess_id] = parseFloat(GridData.Rows[j].realmoney1.toFixed());
            saleDataSums[seriess_id] = parseFloat(GridData.Rows[j].salemoney1.toFixed());
            backDataSums[seriess_id] = parseFloat(GridData.Rows[j].backmoney1.toFixed());

            monthSaleBackDataSum +=  saleBackDataSums[seriess_id];
            monthSaleDataSum += saleDataSums[seriess_id];
            monthBackDataSum += backDataSums[seriess_id];

            month_countsSum += monthCount;
            //初始化0
            for (var i = 0; i < daycount; i++) {
                saleData[seriess_id][i] = 0;
                backData[seriess_id][i] = 0;
                saleBackData[seriess_id][i] = 0;
            }
        }

        var orderDate = parseInt(GridData.Rows[j].orderdate) - 1; //从1日开始，-1到角标0
        saleBackData[seriess_id][orderDate] = parseFloat(GridData.Rows[j].realmoney.toFixed());//把数据赋值给对应的日期角标
        saleData[seriess_id][orderDate] = parseFloat(GridData.Rows[j].salemoney.toFixed());
        backData[seriess_id][orderDate] = parseFloat(GridData.Rows[j].backmoney.toFixed());
    }

    if (month_countsSum==0) {
        month_frequencysSum = 0;
    }
    else {
        month_frequencysSum = parseFloat((25 / month_countsSum * 8).toFixed(1));
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
                text: u_companys[e] + '_' + $("#smonth").val() + '月(可点击查看客户销售品牌详情)',
                //主标题文本超链接  
                link: '/DMS/ReportForm/dms_customer_brand.aspx?admin_user_name=' + admin_user_name + '&user_id=' + user_ids[e] + '&syear=' + $("#syear").val() + '&smonth=' + $("#smonth").val() + '&month_count=' + month_counts[e] + '&month_frequency=' + month_frequencys[e] + '&rnd=' + Math.random(),
                subtext: 
                    '\n\n月销量：' + saleDataSums[e] + '\n月退货：' + backDataSums[e] + '\n月实际：' + saleBackDataSums[e] +
                    '\n\n致电：' + user_names[e]+
                    '\n\n月拿货次数：' + month_counts[e]+' 次'+
                    '\n月拿货频率：' + month_frequencys[e]+' 天/次'
            },
            grid: {
                x: 180,//靠左200像素
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter:function (params,ticket,callback) {
                    //console.log(params)
                    var res =  params[0].name ;
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
                data: ['日销售额', '日退货额', '日实际销售额'],
                selected: {
                    '日销售额': false,
                    '日退货额': false,
                    '日实际销售额': true
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




//画图
function DrawEChartCustomer() {
    $("#main0").before("<div id='main' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main").css("height", 450);
    var option = {
        title: {
            text: admin_user_name+'_'+name+'_'+$("#smonth").val() + '月份客户销售明细',
            subtext: '\n\n客服' +
                    '\n月销售和：' + monthSaleDataSum +
                    '\n月退货和：' + monthBackDataSum +
                    '\n月实际销售和：' + monthSaleBackDataSum +
                    '\n\n月客户数：' + saleBackData.length +
                    '\n分配数：' + user_count +
                    '\n月成交率：' + parseFloat((saleBackData.length / user_count * 100).toFixed()) + '%' +
                    
                    '\n\n月成交次数：' + month_countsSum +' 次'+
                    '\n月成交频率：' + month_frequencysSum + ' 小时/次'//客服工作日25天
        },
        //visualMap: {
        //    type: 'continuous',
        //    min: 0,
        //    max: 20000,
        //    top: 20,
        //    right: 40,
        //    text: ['High', 'Low'],
        //    realtime: false,
        //    calculable: true,
        //    color: ['orangered', 'yellow', 'lightskyblue']
        //},
        visualMap: {
            top: 20,
            right: 40,
            min: 0,
            max: 20000,
            pieces: [
    {min: 20000}, // 不指定 max，表示 max 为无限大（Infinity）。
    {min: 10000, max: 20000},
    {min: 5000, max: 10000},
    {min: 1000, max: 5000,},
    //{value: 123, label: '123（自定义特殊颜色）', color: 'grey'}, // 表示 value 等于 123 的情况。
    {max: 1000}     // 不指定 min，表示 min 为无限大（-Infinity）。
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
                //console.log(params)
                var res = '可点击定位客户<br/>' + params[0].name;
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
                        var hh = (u_companys.length + 1) * 22;
                        if (hh < 400) {
                            hh = 400;
                        }
                        $("#main").css("height", hh);
                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr><td>序号</td><td>客户</td><td>电话</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>'; 
                        for (var m = 0, g = u_companys.length; m < g; m++) {
                            var no = m + 1;
                            table += '<tr><td>' + no + '</td><td>' + u_companys[m] + '</td><td>' + user_names[m] + '</td>';
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
            data: u_companys
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
            data: saleDataSums
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
                data: backDataSums
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
                data: saleBackDataSums
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
                data: month_counts
            },{
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
                data: month_frequencys
            }]
    };

    var myChartDep = echarts.init(document.getElementById('main'), 'macarons');
    myChartDep.setOption(option);
    window.onresize = myChartDep.resize;//随屏幕的大小改变自适应

    myChartDep.on('click', function (params) {
        //alert(params.name + params.value + params.dataIndex);
        //$('html,body').animate({ scrollTop: '0px' }, 800);
        document.getElementById("a_main" + params.dataIndex).click();
    });
}