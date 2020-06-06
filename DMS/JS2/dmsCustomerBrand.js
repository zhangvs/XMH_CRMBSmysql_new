var mains = new Array();//画图main数组
var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
var smonth;
var admin_user_name;
var user_id;
var user_name;
var u_company;

var saleData = new Array(); //销售数据
var backData = new Array(); //退货数据
var saleBackData = new Array(); //合计数据

var saleDataSums = new Array(); //销售数据和，分客户，一维数组，一个客户一个和
var backDataSums = new Array(); //退货数据和，分客户，一维数组，一个客户一个和
var saleBackDataSums = new Array(); //实际数据和，分客户，一维数组，一个客户一个和

var all_saleDataSum = 0;
var all_backDataSum = 0;
var all_saleBackDataSum = 0;

var brand_id;
var brand_name;
var brand_ids = new Array();//品牌id数组
var brand_names = new Array();//品牌名数组

var goods_id;
var goods_name;
var goods_ids = new Array();//单品id数组
var goods_names = new Array();//单品名数组




//个人每日实际销售量
function getMonthSaleBackData(GridData, smonth) {
    smonth = smonth;
    //清空各个客户的合计
    saleBackDataSums = [];
    saleDataSums = [];
    backDataSums = [];
    monthData = [];
    //清空
    saleData = [];//销售额：不同客户数据，分月的数据，的二维数组
    backData = [];//退货额：不同客户数据，分月的数据，的二维数组
    saleBackData = [];//实际销售额：不同客户数据，分月的数据，的二维数组

    brand_names = [];
    brand_ids = [];
    goods_names = [];
    goods_ids = [];
    mains = [];
    $("#form1").html("");

    all_saleBackDataSum = 0;
    all_saleDataSum = 0;
    all_backDataSum = 0;
    var i = 0;
    //赋值
    if (GridData.Rows.length > 0) {
        user_id = GridData.Rows[0].user_id;//客户手机号
        user_name = GridData.Rows[0].user_name;//客户手机号
        u_company = GridData.Rows[0].u_company;//客户名称
        admin_user_name = GridData.Rows[0].admin_user_name;//员工id

        for (var j = 0; j < GridData.Rows.length; j++) {
            brand_id = GridData.Rows[j].brand_id;//客户name
            brand_name = GridData.Rows[j].brand_name;//客户name

            if ($.inArray(brand_id, brand_ids) < 0) {
                var seriess_id = brand_ids.push(brand_id) - 1;//如果第一次出现，添加到数组中,返回前放入元素的id,返回值-1为数组角标
                brand_names.push(brand_name);
                $("#form1").append("<a id='a_main" + seriess_id + "' href='#main" + seriess_id + "'> </a><div id='main" + seriess_id + "' ></div>");
                saleBackData[seriess_id] = new Array();//前客户的实际销售额二维数组
                saleData[seriess_id] = new Array();//前客户的销售额二维数组
                backData[seriess_id] = new Array();//前客户的退货额二维数组

                goods_ids[seriess_id] = new Array();//品牌下的单品id
                goods_names[seriess_id] = new Array();//品牌下的单品名称

                saleBackDataSums[seriess_id] = 0;
                saleDataSums[seriess_id] = 0;
                backDataSums[seriess_id] = 0;
                i = 0;
            }
            saleBackData[seriess_id][i] = parseFloat(GridData.Rows[j].realmoney.toFixed());//把数据赋值给对应的日期角标
            saleBackDataSums[seriess_id] += parseFloat(GridData.Rows[j].realmoney.toFixed());
            all_saleBackDataSum += parseFloat(GridData.Rows[j].realmoney.toFixed());

            saleData[seriess_id][i] = parseFloat(GridData.Rows[j].salemoney.toFixed());
            saleDataSums[seriess_id] += parseFloat(GridData.Rows[j].salemoney.toFixed());
            all_saleDataSum += parseFloat(GridData.Rows[j].salemoney.toFixed());

            backData[seriess_id][i] = parseFloat(GridData.Rows[j].backmoney.toFixed());
            backDataSums[seriess_id] += parseFloat(GridData.Rows[j].backmoney.toFixed());
            all_backDataSum += parseFloat(GridData.Rows[j].backmoney.toFixed());

            goods_ids[seriess_id][i] = GridData.Rows[j].goods_id;
            goods_names[seriess_id][i] = GridData.Rows[j].goods_name;
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
    saleBackData.forEach(function DrawEChart(v, e) {
        $("#main" + e).css("height", 600);
        var option = {
            title: {
                text: brand_names[e] + '_' + smonth + '月品牌销售情况(可点击查看品牌下单品销售清单)',
                link: '/DMS/ReportForm/dms_customer_brand_goods.aspx?admin_user_name=' + admin_user_name + '&user_id=' + user_id + '&brand_id=' + brand_ids[e] + '&syear=' + syear + '&smonth=' + smonth + '&rnd=' + Math.random(),

                subtext: '\n\n单品数：' + goods_names[e].length +
                    '\n\n月销量：' + saleDataSums[e] + '\n月退货：' + backDataSums[e] + '\n月实际：' + saleBackDataSums[e] 
                    
            },
            grid: {
                x: 180,//靠左200像素
                y2: 300
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter:function (params,ticket,callback) {
                    var res = brand_names[e] + params[0].name ;
                    for (var i = 0, l = params.length; i < l; i++) {
                        res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                    }
                    return res
                }
            },
            legend: {
                data: ['单品销售额', '单品退货额', '单品实际销售额'],
                selected: {
                    '单品销售额': false,
                    '单品退货额': false,
                    '单品实际销售额': true
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
                            var hh = (goods_names[e].length + 1) * 22;
                            if (hh < 600) {
                                hh = 600;
                            }
                            $("#main" + e).css("height", hh);
                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>单品</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = goods_names[e].length; m < g; m++) {
                                table += '<tr><td>' + goods_names[e][m] + '</td>';
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
                data: saleData[e]
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
                data: backData[e]
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
    $("#main").css("height", 500);
    var option = {
        title: {
            text: u_company+'_'+smonth + '月份品牌销售汇总',
            subtext: '\n\n电话：' + user_name +
                    '\n\n销售品牌数：' + brand_names.length +
                    '\n\n月销量：' + all_saleDataSum + '\n月退货：' + all_backDataSum + '\n月实际：' + all_saleBackDataSum+
                    '\n\n月拿货次数：' + month_count + '\n月拿货频率：' + month_frequency + '（次/天）'
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
            data: ['品牌销售额', '品牌退货额', '品牌实际销售额'],
            selected: {
                '品牌销售额': false,
                '品牌退货额': false,
                '品牌实际销售额': true
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
                        var hh = (brand_names.length + 1) * 22;
                        if (hh < 500) {
                            hh = 500;
                        }
                        $("#main").css("height", hh);
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
                data: saleDataSums
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
                data: saleBackDataSums
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
                data: backDataSums
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