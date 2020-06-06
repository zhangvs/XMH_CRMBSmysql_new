var mains = new Array();//画图main数组
var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height//部门颜色变量
var colorList = [
  '#D7504B', '#C6E579', '#F4E001', '#F0805A', '#26C0C0',
  '#ff7f50', '#87cefa', '#da70d6', '#32cd32', '#6495ed',
  '#ff69b4', '#ba55d3', '#cd5c5c', '#ffa500', '#40e0d0',
  '#C1232B', '#B5C334', '#FCCE10', '#E87C25', '#27727B',
  '#FE8463', '#9BCA63', '#FAD860', '#F3A43B', '#60C0DD'
];
//部门
var d_pnames = new Array();//部门名数组
var d_pnames_1 = new Array();//部门名数组去重复
//客服
var name;
var admin_user_names = new Array();//员工id
var names = new Array();//员工名数组
//客户
var user_ids = new Array();//客户id数组
var user_names = new Array();//手机号数组
var u_companys = new Array();//客户名数组

//客服下每个客户的月销售数据
var saleData = new Array(); //销售数据
var backData = new Array(); //退货数据
var saleBackData = new Array(); //合计数据
//客服月销售数据
var saleDataSums = new Array(); //销售数据和，分客户，一维数组，一个客户一个和
var backDataSums = new Array(); //退货数据和，分客户，一维数组，一个客户一个和
var saleBackDataSums = new Array(); //实际数据和，分客户，一维数组，一个客户一个和

//月成交比
var user_count;
var user_counts = new Array();//客户数数组
var cj_counts = new Array();//成交客户数数组
var Cjbs = new Array();//成交比数组

//客户月拿货次数，30天
var monthCount = 0;
var month_counts = new Array();//客户拿货次数
var month_frequencys = new Array();//客户拿货频率
//客服月成交次数，频率，（25个工昨日比/所有客户的成交次数累加，单位小时）
var month_countsSum = new Array();//员工成交次数
var month_frequencysSum = new Array();//员工成交频率

//部门合计
var Dep_saleBackDataSums = new Array();
var Dep_saleDataSums = new Array();
var Dep_backDataSums = new Array();
var Dep_user_counts = new Array();
var Dep_cj_counts = new Array();
var Dep_Cjbs = new Array();
var Dep_countsSums = new Array();
var Dep_frequencysSums = new Array();
//分部门不同颜色展示部门数据
var Dep_saleBackDataSums_Color = new Array();
var Dep_saleDataSums_Color = new Array();
var Dep_backDataSums_Color = new Array();
var Dep_user_count_Color = new Array();
var Dep_cj_counts_Color = new Array();
var Dep_Cjbs_Color = new Array();
var Dep_countsSum_Color = new Array();
var Dep_frequencysSum_Color = new Array();

//分部门不同颜色展示个人数据
var saleBackDataSums_Color = new Array();
var saleDataSums_Color = new Array();
var backDataSums_Color = new Array();
var user_count_Color = new Array();
var cj_counts_Color = new Array();
var Cjbs_Color = new Array();
var countsSum_Color = new Array();
var frequencysSum_Color = new Array();

//全公司总合计
var All_month_countsSum = 0;
var All_cj_counts_sum = 0;
var All_user_count_sum = 0;
var All_saleBackDataSums = 0;
var All_saleDataSums = 0;
var All_backDataSums = 0;


var depIndex = 0;
var depColorList = new Array();




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
    $("#form1").html("");
    mains = [];

    admin_user_names = [];//客户ID数组
    names = [];//客户名数组
    d_pnames = [];
    d_pnames_1 = [];

    user_ids = [];
    user_names = [];
    u_companys = [];

    user_counts = [];
    cj_counts = [];
    Cjbs = [];
    //清空
    saleData = [];//销售额：不同客户数据，分月的数据，的二维数组
    backData = [];//退货额：不同客户数据，分月的数据，的二维数组
    saleBackData = [];//实际销售额：不同客户数据，分月的数据，的二维数组
    //清空各个客户的合计
    saleBackDataSums = [];
    saleDataSums = [];
    backDataSums = [];

    month_counts = [];
    month_frequencys = [];
    month_countsSum = [];
    month_frequencysSum = [];

    All_saleBackDataSums = 0;
    All_saleDataSums = 0;
    All_backDataSums = 0;
    All_cj_counts_sum = 0;
    All_user_count_sum = 0;
    All_month_countsSum = 0;
    All_frequencysSum = 0;

    Cjbs_Color = [];
    user_count_Color = [];
    cj_counts_Color = [];
    saleBackDataSums_Color = [];
    saleDataSums_Color = [];
    backDataSums_Color = [];
    countsSum_Color = [];
    frequencysSum_Color = [];

    Dep_saleBackDataSums = [];
    Dep_saleDataSums = [];
    Dep_backDataSums = [];
    Dep_user_count = [];
    Dep_cj_counts = [];
    Dep_Cjbs = [];
    Dep_countsSums = [];
    Dep_frequencysSums = [];

    Dep_saleBackDataSums_Color = [];
    Dep_saleDataSums_Color = [];
    Dep_backDataSums_Color = [];
    Dep_user_count_Color = [];
    Dep_cj_counts_Color = [];
    Dep_Cjbs_Color = [];
    Dep_countsSum_Color = [];
    Dep_frequencysSum_Color = [];

    depIndex = 0;//部门个数
    depColorList = [];
    var x = 0;
    var seriess_id = 0;
    //赋值
    for (var j = 0; j < GridData.Rows.length; j++) {
        admin_user_name = GridData.Rows[j].admin_user_name;//客户name
        d_pname = GridData.Rows[j].d_pname;//客户name
        user_count = GridData.Rows[j].user_count;//客户name
        name = admin_user_name + "_" + GridData.Rows[j].name;//客户name
        
        if ($.inArray(admin_user_name, admin_user_names) < 0) {
            seriess_id = admin_user_names.push(admin_user_name) - 1;//如果第一次出现，添加到数组中,返回前放入元素的id,返回值-1为数组角标
            names.push(name);
            d_pnames.push(d_pname);
            user_counts.push(user_count);
            $("#form1").append("<a id='a_main" + seriess_id + "' href='#main" + seriess_id + "'> </a><div id='main" + seriess_id + "' ></div>");
            saleBackData[seriess_id] = new Array();//前客户的实际销售额二维数组
            saleData[seriess_id] = new Array();//前客户的销售额二维数组
            backData[seriess_id] = new Array();//前客户的退货额二维数组
            user_names[seriess_id] = new Array();//公司手机号
            u_companys[seriess_id] = new Array();//公司名称
            user_ids[seriess_id] = new Array();//公司id
            month_counts[seriess_id] = new Array();//客户拿货次数
            month_frequencys[seriess_id] = new Array();//客户拿货频率
            month_countsSum[seriess_id] = 0;
            month_frequencysSum[seriess_id] = 0;

            saleBackDataSums[seriess_id] = parseFloat(GridData.Rows[j].realmoney1.toFixed());
            saleDataSums[seriess_id] = parseFloat(GridData.Rows[j].salemoney1.toFixed());
            backDataSums[seriess_id] = parseFloat(GridData.Rows[j].backmoney1.toFixed());
            x = j;
        }

        saleBackData[seriess_id][j - x] = parseFloat(GridData.Rows[j].realmoney.toFixed());//把数据赋值给对应的月份角标
        saleData[seriess_id][j - x] = parseFloat(GridData.Rows[j].salemoney.toFixed());
        backData[seriess_id][j - x] = parseFloat(GridData.Rows[j].backmoney.toFixed());

        user_names[seriess_id][j - x] = GridData.Rows[j].user_name;
        u_companys[seriess_id][j - x] = GridData.Rows[j].u_company;
        user_ids[seriess_id][j - x] = GridData.Rows[j].user_id;

        monthCount = GridData.Rows[j].monthCount;
        if (monthCount == null) {
            month_counts[seriess_id][j - x] = 0;
            month_frequencys[seriess_id][j - x] = 0;
        }
        else {
            month_counts[seriess_id][j - x] = monthCount;
            month_frequencys[seriess_id][j - x] = parseFloat((30 / monthCount).toFixed());//客户拿货频率

            month_countsSum[seriess_id] += monthCount;
            month_frequencysSum[seriess_id] = parseFloat((25 / month_countsSum[seriess_id] * 8).toFixed(1));//客服客户成交频率 30/  单位为天， *8  单位为小时,客服成交频率
        }

    }



    for (var i = 0; i < admin_user_names.length ; i++) {
        cj_counts[i] = u_companys[i].length;

        //分部门统计,如果遇到不同部门，开启一个新数组，在此之前先把上一个数组总结一下
        if ($.inArray(d_pnames[i], d_pnames_1) < 0) {
            if (d_pnames_1.length != 0) {
                //部门成交比
                if (Dep_user_counts[depIndex] == 0) {
                    Dep_Cjbs[depIndex] = 0;
                }
                else {
                    Dep_Cjbs[depIndex] = parseFloat((Dep_cj_counts[depIndex] / Dep_user_counts[depIndex] * 100).toFixed());
                }
                getNodeDataVal(Dep_Cjbs_Color, Dep_Cjbs[depIndex], colorList[depIndex]);
                getNodeDataVal(Dep_user_count_Color, Dep_user_counts[depIndex], colorList[depIndex]);
                getNodeDataVal(Dep_cj_counts_Color, Dep_cj_counts[depIndex], colorList[depIndex]);
                getNodeDataVal(Dep_saleBackDataSums_Color, Dep_saleBackDataSums[depIndex], colorList[depIndex]);
                getNodeDataVal(Dep_saleDataSums_Color, Dep_saleDataSums[depIndex], colorList[depIndex]);
                getNodeDataVal(Dep_backDataSums_Color, Dep_backDataSums[depIndex], colorList[depIndex]);

                getNodeDataVal(Dep_countsSum_Color, Dep_countsSums[depIndex], colorList[depIndex]);
                //部门销售频率
                if (Dep_countsSums[depIndex] == 0) {
                    Dep_frequencysSums[depIndex] = 0;
                }
                else {
                    Dep_frequencysSums[depIndex] = parseFloat((25 / Dep_countsSums[depIndex] * 8 * 60).toFixed());//部门频率单位为分钟
                }
                getNodeDataVal(Dep_frequencysSum_Color, Dep_frequencysSums[depIndex], colorList[depIndex]);
            }


            depIndex = d_pnames_1.push(d_pnames[i]) - 1;//
            Dep_saleBackDataSums[depIndex] = 0;
            Dep_saleDataSums[depIndex] = 0;
            Dep_backDataSums[depIndex] = 0;
            Dep_user_counts[depIndex] = 0;
            Dep_cj_counts[depIndex] = 0;
            Dep_countsSums[depIndex] = 0;
            Dep_frequencysSums[depIndex] = 0;
        }
        //循环体，部门合计
        depColorList[i] = colorList[depIndex];
        Dep_saleBackDataSums[depIndex] += saleBackDataSums[i];
        Dep_saleDataSums[depIndex] += saleDataSums[i];
        Dep_backDataSums[depIndex] += backDataSums[i];
        Dep_user_counts[depIndex] += user_counts[i];
        Dep_cj_counts[depIndex] += cj_counts[i];
        Dep_countsSums[depIndex] += month_countsSum[i];

        //全体合计
        All_cj_counts_sum += cj_counts[i];
        All_user_count_sum += user_counts[i];
        All_saleBackDataSums += saleBackDataSums[i];
        All_saleDataSums += saleDataSums[i];
        All_backDataSums += backDataSums[i];
        All_month_countsSum += month_countsSum[i];
        if (All_month_countsSum == 0) {
            All_frequencysSum = 0;
        }
        else {
            All_frequencysSum = parseFloat((25 / All_month_countsSum * 8 * 60).toFixed(1));
        }
        //个人渲染颜色
        if (user_counts[i] == 0) {
            Cjbs[i] = 0;
        }
        else {
            Cjbs[i] = parseFloat((cj_counts[i] / user_counts[i] * 100).toFixed());
        }
        getNodeDataVal(Cjbs_Color, Cjbs[i], depColorList[i]);
        getNodeDataVal(user_count_Color, user_counts[i], depColorList[i]);
        getNodeDataVal(cj_counts_Color, cj_counts[i], depColorList[i]);
        getNodeDataVal(saleBackDataSums_Color, saleBackDataSums[i], depColorList[i]);
        getNodeDataVal(saleDataSums_Color, saleDataSums[i], depColorList[i]);
        getNodeDataVal(backDataSums_Color, backDataSums[i], depColorList[i]);
        getNodeDataVal(countsSum_Color, month_countsSum[i], depColorList[i]);
        getNodeDataVal(frequencysSum_Color, month_frequencysSum[i], depColorList[i]);
    }
    //最后一个部门赋值
    if (Dep_user_counts[depIndex] == 0) {
        Dep_Cjbs[depIndex] = 0;
    }
    else {
        Dep_Cjbs[depIndex] = parseFloat((Dep_cj_counts[depIndex] / Dep_user_counts[depIndex] * 100).toFixed());
    }


    getNodeDataVal(Dep_Cjbs_Color, Dep_Cjbs[depIndex], colorList[depIndex]);
    getNodeDataVal(Dep_user_count_Color, Dep_user_counts[depIndex], colorList[depIndex]);
    getNodeDataVal(Dep_cj_counts_Color, Dep_cj_counts[depIndex], colorList[depIndex]);
    getNodeDataVal(Dep_saleBackDataSums_Color, Dep_saleBackDataSums[depIndex], colorList[depIndex]);
    getNodeDataVal(Dep_saleDataSums_Color, Dep_saleDataSums[depIndex], colorList[depIndex]);
    getNodeDataVal(Dep_backDataSums_Color, Dep_backDataSums[depIndex], colorList[depIndex]);

    getNodeDataVal(Dep_countsSum_Color, Dep_countsSums[depIndex], colorList[depIndex]);
    //部门销售频率
    if (Dep_countsSums[depIndex] == 0) {
        Dep_frequencysSums[depIndex] = 0;
    }
    else {
        Dep_frequencysSums[depIndex] = parseFloat((25 / Dep_countsSums[depIndex] * 8 * 60).toFixed());//部门频率单位为分钟
    }
    getNodeDataVal(Dep_frequencysSum_Color, Dep_frequencysSums[depIndex], colorList[depIndex]);

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
    admin_user_names.forEach(function DrawEChart(v, e) {
        $("#main" + e).css("height", 500);
        var option = {
            title: {
                text: names[e] + '_' + $("#smonth").val() + '月(点击可查看员工销售客户详情)',
                //主标题文本超链接  
                link: '/DMS/ReportForm/dms_personal_customer.aspx?admin_user_name=' + admin_user_names[e] + '&syear=' + $("#syear").val() + '&smonth=' + $("#smonth").val() + '&rnd=' + Math.random(),
                subtext: '\n\n客服' +
                    '\n\n月销量：' + saleDataSums[e] +
                    '\n月退货：' + backDataSums[e] +
                    '\n月实际：' + saleBackDataSums[e] +

                    '\n\n月成交客户数：' + cj_counts[e] +
                    '\n月分配客户数：' + user_counts[e] +
                    '\n月成交比：' + Cjbs[e] + '%' +

                    '\n\n月成交次数：' + month_countsSum[e] + ' 次' +
                    '\n月成交频率：' + month_frequencysSum[e] + ' 小时/次'
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
                    var res = '可点击定位客户<br/>'+names[e]+'_' + params[0].name;
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
            }, visualMap: {
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
                            var hh = (u_companys[e].length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
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
                data: month_counts[e]
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
                data: month_frequencys[e]
            }]
        };

        var myChart = echarts.init(document.getElementById('main' + e), 'macarons');
        myChart.setOption(option);
        mains.push(myChart);

        myChart.on('click', function (params) {
            window.open('/DMS/ReportForm/dms_customer_brand.aspx?admin_user_name=' + admin_user_names[e] + '&user_id=' + user_ids[e][params.dataIndex] + '&syear=' + $("#syear").val() + '&smonth=' + $("#smonth").val() + '&month_count=' + month_counts[e][params.dataIndex] + '&month_frequency=' + month_frequencys[e][params.dataIndex] + '&rnd=' + Math.random());
        });
    });

    //echarts.connect(mains);

    if (depIndex > 0) {
        DrawEChartDep();
    }
    DrawEChartPersonal();
}
//随屏幕的大小改变自适应
$(window).resize(function () {
    mains.forEach(function echartsHight(v, e) {
        v.resize();

    })
});
//画图
function DrawEChartDep() {
    $("#main0").before("<div id='main' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main").css("height", 500);
    var option = {
        title: {
            text: $("#smonth").val() + '月份部门客户销售汇总',
            subtext: '\n\n部门个数：' + d_pnames_1.length +
                    '\n\n月销量：' + All_saleDataSums + '\n月退货：' + All_backDataSums + '\n月实际：' + All_saleBackDataSums +
                    '\n\n成交客户总数：' + All_cj_counts_sum +
                    '\n分配客户总数：' + All_user_count_sum +
                    '\n总成交比：' + parseFloat((All_cj_counts_sum / All_user_count_sum * 100).toFixed()) + '%' +
                    '\n\n月成交次数：' + All_month_countsSum + '次' +
                    '\n月成交频率：' + All_frequencysSum + '分钟/次'
        },
        grid: {
            x: 180,//靠左200像素
            y2: 150
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            // 显示延迟，添加显示延迟可以避免频繁切换，单位ms
        },
        legend: {
            data: ['月成交客户数', '月分配客户数', '月成交比', '月成交次数', '月成交频率(分钟/次)', '月销售额', '月退货额', '月实际销售额'],
            selected: {
                '月成交客户数': true,
                '月分配客户数': true,
                '月成交比': false,
                '月成交次数': false,
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
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>部门</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = d_pnames_1.length; m < g; m++) {
                            table += '<tr><td>' + d_pnames_1[m] + '</td>';
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
            data: d_pnames_1
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
            data: Dep_cj_counts_Color,
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
            data: Dep_user_count_Color,
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
                            return params.data.value + '%'
                        },
                    }
                }
            },
            data: Dep_Cjbs_Color,
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
            data: Dep_saleDataSums_Color,
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
            data: Dep_backDataSums_Color,
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
            data: Dep_saleBackDataSums_Color,
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
            data: Dep_countsSum_Color,
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
            data: Dep_frequencysSum_Color,
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

    var myChartDep = echarts.init(document.getElementById('main'), 'macarons');
    myChartDep.setOption(option);
    window.onresize = myChartDep.resize;//随屏幕的大小改变自适应

}

//画图
function DrawEChartPersonal() {
    $("#main0").before("<div id='main00' ></div>");
    //var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main00").css("height", 500);
    var option = {
        title: {
            text: $("#smonth").val() + '月份个人客户销售汇总',
            subtext:
                    '\n员工个数：' + admin_user_names.length +
                    '\n\n月销量：' + All_saleDataSums +
                    '\n月退货：' + All_backDataSums +
                    '\n月实际：' + All_saleBackDataSums +

                    '\n\n月成交客户总数：' + All_cj_counts_sum +
                    '\n分配客户总数：' + All_user_count_sum +
                    '\n月总成交比：' + parseFloat((All_cj_counts_sum / All_user_count_sum * 100).toFixed()) + '%' +

                    '\n\n月成交次数：' + All_month_countsSum + '次' +
                    '\n月成交频率：' + All_frequencysSum + '分钟/次'
        },
        grid: {
            x: 180,//靠左200像素
            y2: 150
        },
        tooltip: {
            trigger: 'axis',
            showDelay: 0,
            formatter: function (params, ticket, callback) {
                //console.log(params)
                var res = '可点击定位员工<br/>' + params[0].name;
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
                        var hh = (admin_user_names.length + 1) * 19 + 80;//上标题和下按钮各占40=80，每行占19，加列标题行1
                        if (hh < 500) {
                            hh = 500;
                        }
                        $("#main00").css("height", hh);
                        var series = opt.series;
                        var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>序号</td>' + '<td>员工</td>';
                        for (var i = 0, l = series.length; i < l; i++) {
                            table += '<td>' + series[i].name + '</td>'
                        };

                        table += '</tr>';
                        for (var m = 0, g = admin_user_names.length; m < g; m++) {
                            var no = m + 1;
                            table += '<tr><td>' + no + '</td><td>' + names[m] + '</td>';
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
            data: names
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
            data: cj_counts_Color,
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
            data: user_count_Color,
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
                            return params.data.value + '%'
                        },
                    }
                }
            },
            data: Cjbs_Color,
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
            data: saleDataSums_Color,
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
            data: backDataSums_Color,
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
            data: saleBackDataSums_Color,
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
            data: countsSum_Color,
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
            data: frequencysSum_Color,
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

    var myChartDep_00 = echarts.init(document.getElementById('main00'), 'macarons');
    myChartDep_00.setOption(option);
    window.onresize = myChartDep_00.resize;//随屏幕的大小改变自适应

    myChartDep_00.on('click', function (params) {
        //alert(params.name + params.value + params.dataIndex);
        //$('html,body').animate({ scrollTop: '0px' }, 800);
        document.getElementById("a_main" + params.dataIndex).click();
    });
}