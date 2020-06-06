

//初始化数据
var app = {};                                                   //用于计时
var dataDay = [];
var dataSales = [];
var dataOrder = [];
var now = new Date();

$(function () {
    var select = $("#month");
    for (var sTime = 1; sTime <= 12 ; sTime++) {
        select.append("<option value='" + sTime + "'>" + sTime.toString() + "</option>");  //添加一项option
    }
    select.val(now.getMonth() + 1);

    var select = $("#year");
    for (var y = Number(now.getFullYear()) ; y >= 2014 ; y--) {
        select.append("<option value='" + y + "'>" + y.toString() + "</option>");  //添加一项option
    }
    setUpMonth();
});

//设置时间间隔
function setUpMonth() {
    dataDay = [];
    dataSales = [];
    dataOrder = [];
    //获取选中值
    var year = $("#year").val();
    var month = $("#month").val();
    getMonthData(year, month);
}

//设置报表数据
function test() {
    app.title = '金额/订单量';

    option = {
        tooltip: {
            trigger: 'axis'
        },
        title: {
            text: '月销售数据',
            //subtext: 'data from order',
            x: 'center',
            textStyle: {
            },
            //padding: -10
        },
        toolbox: {
            feature: {
                dataView: { show: true, readOnly: false },
                magicType: { show: true, type: ['line', 'bar'] },
                restore: { show: true },
                saveAsImage: { show: true }
            }
        },
        legend: {
            data: ['销售金额', '销售单量'],
            //x: 'right',
            //padding:80
            right: '20%'
        },
        xAxis: [
            {
                type: 'category',
                data: dataDay
            }
        ],
        yAxis: [
            {
                type: 'value',
                name: '金额',
                //min: 10000,
                //max: 10000000,
                //interval: 10000,
                axisLabel: {
                    formatter: '{value} ￥'
                }
            },
            {
                type: 'value',
                name: '单数',
                min: 0,
                //max: 1000,
                //interval: 100,
                axisLabel: {
                    formatter: '{value} 单'
                }
            }
        ],
        series: [
            {
                name: '销售金额',
                type: 'bar',
                data: dataSales,
                markPoint: {
                    data: [
                        { type: 'max', name: '最大值' },
                        { type: 'min', name: '最小值' }
                    ]
                }
            },
            {
                name: '销售单量',
                type: 'bar',
                data: dataOrder,
                yAxisIndex: 1,
                markPoint: {
                    data: [
                        { type: 'max', name: '最大值' },
                        { type: 'min', name: '最小值' }
                    ]
                },
            }
        ]
    };


    var myChart = echarts.init(document.getElementById('graph1'), 'macarons');
    myChart.setOption(option);
}

//获取初始化数据
function getMonthData(year, month) {
    $.ajax({
        type: "POST",
        url: "../../DMS/Reports_DMS.ashx",
        data: { Action: "getMonthData", syear: year, smonth: month },
        dataType: 'json',
        success: function (responseText) {
            var result = eval(responseText);

            for (i = 0; i < result.Rows.length; i++) {
                dataDay.push(result.Rows[i].daytime + "日");
                //dataSales.push(result.Rows[i].feat);
                //dataOrder.push(result.Rows[i].orderNum);

                dataSales.push((Number(result.Rows[i].feat) * 2).toFixed(2));
                dataOrder.push(Number(result.Rows[i].orderNum) * 2);
            }
            test();
        },
        error: function () {

        }
    })
}