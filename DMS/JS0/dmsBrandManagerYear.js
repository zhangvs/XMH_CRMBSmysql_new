
var bp_brand_name; //品牌名
var bp_brand_names = new Array();//品牌名数组
var bp_percentages = new Array();//品牌提成数组(销售额-退货-基数)*比例==提成


//个人每日实际销售量
function getBrandManagerData(GridData) {

    clearMonthData();
    

    bp_brand_names = [];//考核品牌名数组
    bp_percentages = [];//考核品牌提成数组
    var _id = 0;

    for (var j = 0; j < GridData.Rows.length; j++) {
        //取列字段赋值
        bp_brand_name = GridData.Rows[j].bp_brand_name;//品牌name
        //判断品牌名称数组中是否存在当前品牌名，如果不存在初始化一个新数组
        if ($.inArray(bp_brand_name, bp_brand_names) < 0) {
            _id = bp_brand_names.push(bp_brand_name) - 1;//如果第一次出现，添加到数组中,返回前放入元素的id,返回值-1为数组角标
            bp_percentages.push(GridData.Rows[j].bp_percentage);//品牌提成
            $("#form1").append("<div id='main" + _id + "' style='height:300px' ></div>");
            $("#form1").append("<div id='mainEmp" + _id + "' style='height:300px' ></div><hr style='height:10px;border:none;border-top:10px groove skyblue;' />");
            initDateData(_id);
            //当前品牌的基数，计划，画线
            month_base = parseFloat(GridData.Rows[j].month_base.toFixed());
            month_plan = parseFloat(GridData.Rows[j].month_plan.toFixed());
            getBasePlanLine(_id, month_base, month_plan);
        }
        //循环赋值
        getDateDataValue(_id, GridData.Rows[j]);
    }
    initNodeData(bp_brand_names);
    ie_forEach();

    //画图
    bp_brand_names.forEach(function DrawEChart(v, e) {
        var option = {
            title: {
                text: bp_brand_names[e] + '_' + smonth + '月',
                subtext:
                    '月完成率：' + parseFloat((dateRealsSums[e] / month_plans[e] * 100).toFixed()) + '%' +
                    '\n月差额：' + parseFloat((dateRealsSums[e] - month_plans[e]).toFixed()) +
                    '\n提成：' + parseFloat(((dateRealsSums[e] - month_plans[e]) * bp_percentages[e] * 0.01).toFixed()) +
                    '\n\n月销量：' + dateSalesSums[e] + '\n月退货：' + dateBacksSums[e] + '\n月实际：' + dateRealsSums[e] +
                    '\n\n月基数：' + month_bases[e] + '\n月计划：' + month_plans[e] +
                    '\n节点基数：' + node_bases[e] + '\n节点计划：' + node_plans[e] +
                    '\n日基数：' + date_bases[e] + '\n日计划：' + date_plans[e]

            },
            grid: {
                x: 230,//靠左200像素
            },
            tooltip: {
                trigger: 'axis',
                showDelay: 0,
                formatter: function (params, ticket, callback) {
                    //console.log(params)
                    var res = bp_brand_names[e] + params[0].name;
                    for (var i = 0, l = params.length; i < l; i++) {
                        res += '<br/>' + params[i].seriesName + ' : ' + params[i].value;
                    }
                    return res
                }
            },
            legend: {
                data: ['日销售额', '日退货额', '日实际销售额', '日差额', '日完成率', '节点销售额', '节点差额', '节点完成率'],
                selected: {
                    '日销售额': false,
                    '日退货额': false,
                    '日实际销售额': false,
                    '日差额': false,
                    '日完成率': false,
                    '节点销售额': true,
                    '节点差额': false,
                    '节点完成率': false
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
                data: dateSales[e]
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
                data: dateBacks[e]
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
                data: dateReals[e],
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
                data: dateChas[e]
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
                data: dateWcls[e]
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
                data: nodeAdds[e],
                markLine: {
                    data: node_lines[e]
                },
                markPoint: {
                    data: node_Points[e]
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
                data: nodeChas[e]
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
                data: nodeWcls[e]
            }]
        };

        var myChart = echarts.init(document.getElementById('main' + e), 'macarons');
        myChart.setOption(option);
        mains.push(myChart);
    }

    );

}


//个人每日实际销售量
function getBrandManagerData_Emp(GridData) {
    clearBrandEmpData();
    var nb;//当前品牌id
    var d = 0;//当前品牌下姓名下标
    for (var i = 0; i < GridData.Rows.length; i++) {
        bp_brand_name = GridData.Rows[i].bp_brand_name;
        var _id = $.inArray(bp_brand_name, bp_brand_names);
        if (_id != nb) {
            nb = _id;
            d = i;
            initBrandEmpData(_id);
        }
        getBrandEmpDataValue(_id, i - d, GridData.Rows[i]);
    }
    ie_forEach();

    //画图
    bp_brand_names.forEach(function DrawEChart(v, e) {
        var optionEmp = {
            title: {
                text: v + '_' + smonth + '月客服销售情况',
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
                                $("#mainEmp" + e).css("height", h / 2);
                            }
                            else {
                                $("#mainEmp" + e).css("height", hh);
                            }

                            var table = '<table><tbody><tr>' + '<td>客服</td>';
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
                data: brandEmpnames[e]
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
                data: ['月销售额', '月退货额', '月实际销售额', '月基数', '月计划', '月完成率'],
                selected: {
                    '月销售额': false,
                    '月退货额': false,
                    '月实际销售额': true,
                    '月基数': false,
                    '月计划': false,
                    '月完成率': false
                }
            },
            series: [{
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
                data: brandEmpSales[e]
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
                data: brandEmpBacks[e]
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
                data: brandEmpReals[e]
            }, {
                name: '月基数',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: brandEmpBases[e]
            }, {
                name: '月计划',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: brandEmpPlans[e]
            }, {
                name: '月完成率',
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
                data: brandEmpWcls[e]
            }]
        };

        var myChartEmp = echarts.init(document.getElementById('mainEmp' + e), 'macarons');
        myChartEmp.setOption(optionEmp);
        mains.push(myChartEmp);

    }

    );

}
//随屏幕的大小改变自适应
$(window).resize(function () {
    mains.forEach(function echartsHight(v, e) {
        v.resize();

    })
});


