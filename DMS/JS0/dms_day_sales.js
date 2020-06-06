
        //初始化数据
        var app = {};                                                   //用于计时
var data = [];                                                  //用于报表数据
var nowFeat = 0.00;                                             //存储总金额
var now = new Date();
var nowtime = Math.floor(now.getTime() / 1000);                 //获取当前时间戳
//nowtime = 1462433400;

var pretime = Math.floor(nowtime - 3600);                       //获取前一个小时时间戳
var day = new Date(now.format("yyyy-MM-dd"));
var daytime = Math.floor((day.getTime() / 1000) - 28800);       //获取零点时间戳
//daytime = 1462377600;
//pretime = 1462406400;

$(function () {
    var select = $("#hours");
    var miniTime = Math.floor(day.getTime() / 1000);
    //var miniTime = 1462406400;
    for (var sTime = nowtime - 3600; sTime >= miniTime ; sTime = sTime - 3600) {
        var newdate = new Date(sTime * 1000);
        select.append("<option value='" + sTime + "'>" + newdate.getHours() + "</option>");  //添加一项option
    }

    setUpHours();
});

//设置时间间隔
function setUpHours() {
    app = {};
    data = [];
    nowFeat = 0.00;                                             //存储总金额
    now = new Date();
    nowtime = Math.floor(now.getTime() / 1000);                 //获取当前时间戳
    pretime = Math.floor(nowtime - 3600);                       //获取前一个小时时间戳
    day = new Date(now.format("yyyy-MM-dd"));
    daytime = Math.floor((day.getTime() / 1000) - 28800);       //获取零点时间戳

    //获取选中值
    pretime = Number($("#hours").val());
    getCurData();
}

//设置报表数据
function test() {
    option = {
        title: {
            text: now.format("yyyy-MM-dd") + '业绩走势图'
        },
        toolbox: {
            show: true,
            feature: {
                mark: { show: true },
                saveAsImage: { show: true }
            }
        },
        tooltip: {
            trigger: 'axis',
            formatter: function (params) {
                params = params[0];
                var date = new Date(params.name);
                return date.getHours() + ':' + (date.getMinutes()) + ':' + date.getSeconds() + ' ￥ ' + toMoney(params.value[1]);
            },
            axisPointer: {
                animation: false
            }
        },
        xAxis: {
            type: 'time',
            splitNumber: 12,
            splitLine: {
                show: false
            }
        },
        yAxis: {
            type: 'value',
            boundaryGap: [0, '100%'],
            splitLine: {
                show: false
            }
        },
        series: [{
            name: '模拟数据',
            type: 'line',
            showSymbol: false,
            hoverAnimation: false,
            areaStyle: {
                normal: {}
            },
            markLine: {
                data: [
                    { type: 'max', name: '最大值', symbol: 'emptyCircle', itemStyle: { normal: { color: '#dc143c' } } },
                    { type: 'min', name: '最小值', symbol: 'emptyCircle', itemStyle: { normal: { color: '#1e90ff' } } },
                ]
            },
            data: data
        }]
    };

    //设置刷新频率
    app.timeTicket = setInterval(function () {

        $.ajax({
            type: "POST",
            url: "../../DMS/DMS_TimeAxis.ashx",
            data: { Action: "getWillData", nowtime: nowtime },
            dataType: 'json',
            success: function (responseText) {

                //每次刷新走几个区间1：一个
                for (var i = 0; i < 1; i++) {
                    data.shift();
                    //向报表填充数据
                    data.push({
                        name: (nowtime += 10) * 1000,
                        value: [
                            nowtime * 1000,
                            nowFeat += responseText.feat
                        ]
                    });
                }

                myChart.setOption({
                    series: [{
                        data: data
                    }]
                });
            },
            error: function () {

            }
        })
    }, 10000); //10秒刷新一次

    var myChart = echarts.init(document.getElementById('graph1'), 'macarons');
    myChart.setOption(option);
}

//获取初始化数据
function getCurData() {
    $.ajax({
        type: "POST",
        url: "../../DMS/DMS_TimeAxis.ashx",
        data: { Action: "getCurData", nowtime: nowtime, pretime: pretime, daytime: daytime },
        dataType: 'json',
        success: function (responseText) {
            var result = eval(responseText);
            //获取之前总金额
            $(result).each(function (i, val) {
                if (val.Rows[i].type == '1') {
                    nowFeat = val.Rows[i].feat;
                }
            });

            //设置时间间隔，填充初始化数据
            for (var time = pretime; time <= nowtime; time += 10) {
                //遍历时间段，把符合要求的时间叠加
                for (j = 0; j < result.Rows.length; j++) {
                    if (result.Rows[j].type == '2' && result.Rows[j].erp_time <= time && result.Rows[j].erp_time > (time - 10)) {
                        nowFeat += result.Rows[j].feat;
                    }
                }

                //向报表填充数据
                data.push({
                    name: time * 1000,
                    value: [
                        time * 1000,
                        nowFeat
                    ]
                });
            }
            test();

        },
        error: function () {

        }
    })
}