﻿
var myChart;
var eCharts;
var series_data = [];
DrawEChart();
//创建ECharts图表方法  

function DrawEChart(ec) {
    var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main").css("height", h - 10);
    eCharts = ec;
    myChart = echarts.init(document.getElementById('main'));
    myChart.showLoading({
        text: "图表数据正在努力加载..."
    });

    var options = {
        //backgroundColor: '#404a59',
        title: {
            text: '新明辉订单省份分布',
            subtext: 'data from order',
            left: 'center',
        },
        tooltip: {
            trigger: 'item'
        },
        legend: {
            orient: 'vertical',
            left: 'left'
        },
        visualMap: {
            min: 0,
            max: 200000,
            left: 'left',
            top: 'bottom',
            text: ['高', '低'],           // 文本，默认为数值文本
            calculable: true,
            inRange: {
                color: ['lightskyblue', 'yellow', 'orangered']
            }
        },
        toolbox: {
            show: true,
            orient: 'vertical',
            left: 'right',
            top: 'center',
            feature: {
                dataView: { readOnly: false },
                restore: {},
                saveAsImage: {}
            }
        },
        series: [
            {
                name: '金额',
                type: 'map',
                mapType: 'china',
                roam: false,
                label: {
                    normal: {
                        show: true
                    },
                    emphasis: {
                        show: true
                    }
                },
                data: [],
            }
        ]
    };
    myChart.setOption(options); //先把可选项注入myChart中  
    myChart.hideLoading();
}

var k = -1;

function getajaxdata(data) {
    //获得图表的options对象  
    var options = myChart.getOption();
    series_data = [];
    for (var j = 0; j < data.Rows.length; j++) {
        series_data.push({
            name: data.Rows[j].name,
            //value: data.Rows[j].value
            value: (Number(data.Rows[j].value) * 3).toFixed(2)
        });
    }

    //alert(k);
    //if (k == -1) k = 5;
    options.series[0].data = series_data;
    //options.series[1].data = series_data.slice(k, 6);
    myChart.hideLoading();
    myChart.setOption(options);
    //k--;

}


function getChartData() {
    //通过Ajax获取数据  
    $.ajax({
        type: "post",
        url: "../Reports_DMS.ashx",
        data: "&Action=GetTodayProvinceAmt&date=" + $("#T_Date").val() + "&rnd=" + Math.random(),
        dataType: "json", //返回数据形式为json  
        success: function (data) {
            if (data) {
                getajaxdata(data);
            }
        },
        error: function (errorMsg) {
            alert("图表请求数据失败啦!");
            myChart.hideLoading();
        }
    });
}

window.setInterval("getChartData()", "5000");

//series_data.push({
//    name: '拉萨',
//    value: [91.111891,29.662557,100000]
//});