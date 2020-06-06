<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>新明辉实时订单跟踪</title>

    <script src="../../JS/jquery-1.12.1.js"></script>
    <script src="../../lib/echarts/echarts.min.js" type="text/javascript"></script>

    <script src="../../lib/echarts/map/china.js"></script>
    <script src="../../lib/echarts/map/geoCoordMap.js"></script>
    <script src="../../JS/My97DatePicker/WdatePicker.js"></script>
</head>
<body>
    <!-- 为ECharts准备一个具备大小（宽高）的Dom -->
    <div id="main" style="height: 900px"></div>
    <input type='text' id='T_Date' name='T_Date' class="Wdate" onclick="WdatePicker({ dateFmt: 'yyyy-MM-dd', skin: 'ext' });" />


    <script type="text/javascript">
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
            //定义图表options  
            var options = {
                backgroundColor: '#404a59',
                title: {
                    text: '新明辉实时订单跟踪',
                    subtext: 'data from order',
                    left: 'center',
                    textStyle: {
                        color: '#fff'
                    }
                },
                tooltip: {
                    trigger: 'item'
                },
                tooltip: {
                    show: true,
                    trigger: 'item',  // 坐标轴触发 也可以item数据点触发
                    formatter: function (params) { // tip的样式
                        var res = params.name + ' : ' + params.value[2];
                        return res;
                    }
                },
                legend: {
                    orient: 'vertical',
                    y: 'top',
                    x: 'left',
                    data: ['日订单量'],
                    textStyle: {
                        color: '#fff'
                    }
                },
                visualMap: {
                    min: 0,
                    max: 100000,
                    calculable: true,
                    inRange: {
                        color: ['#50a3ba', '#eac736', '#d94e5d']
                    },
                    textStyle: {
                        color: '#fff'
                    },
                    itemHeight: 200
                },
                geo: {
                    map: 'china',
                    label: {
                        emphasis: {
                            show: false
                        }
                    },
                    roam: true,
                    itemStyle: {
                        normal: {
                            areaColor: '#323c48',
                            borderColor: '#111'
                        },
                        emphasis: {
                            areaColor: '#2a333d'
                        }
                    }
                },
                series: [
                    {
                        name: '日订单量',
                        type: 'scatter',
                        coordinateSystem: 'geo',
                        data: [],
                        symbolSize: function (val) {
                            //var sca = val[2] > 100000 ? val[2] / 5000 : val[2] / 1000;
                            return val[2] / 1000;
                        },
                        label: {
                            normal: {
                                formatter: '{b}',
                                position: 'right',
                                show: false
                            },
                            emphasis: {
                                show: true
                            }
                        },
                        itemStyle: {
                            normal: {
                                color: '#ddb926'
                            }
                        }
                    },
                {
                    name: 'Top 5',
                    type: 'effectScatter',
                    coordinateSystem: 'geo',
                    data: [],
                    symbolSize: function (val) {
                        //var sca = val[2] > 100000 ? val[2] / 10000 : val[2] / 1000;
                        return val[2] / 1000;
                    },
                    showEffectOn: 'render',
                    rippleEffect: {
                        brushType: 'stroke'
                    },
                    hoverAnimation: true,
                    label: {
                        normal: {
                            formatter: '{b}',
                            position: 'right',
                            show: true
                        }
                    },
                    itemStyle: {
                        normal: {
                            color: '#f4e925',
                            shadowBlur: 10,
                            shadowColor: '#333',
                            opacity: "0.00001"
                        }
                    },
                    zlevel: 1
                }
                ]
            };
            myChart.setOption(options); //先把可选项注入myChart中  
            myChart.hideLoading();
            //getChartData();//aja后台交互   
        }


    </script>


    <script type="text/javascript">

        var k = -1;

        function getajaxdata(data) {
            //获得图表的options对象  
            var options = myChart.getOption();
            if (series_data.length != data.Rows.length) {
                series_data = [];
                for (var j = 0; j < data.Rows.length; j++) {
                    var geoCoord = geoCoordMap[data.Rows[j].name];
                    if (geoCoord) {
                        series_data.push({
                            name: data.Rows[j].name,
                            //value: geoCoord.concat(data.Rows[j].value)

                            value: geoCoord.concat((Number(data.Rows[j].value) * 2).toFixed(2))
                        });
                    }
                }
            }

            //alert(k);
            if (k == -1) k = 5;
            options.series[0].data = series_data.slice(k, series_data.length - 1);
            options.series[1].data = series_data.slice(k, 6);
            myChart.hideLoading();
            myChart.setOption(options);
            k--;

        }


        function getChartData() {
            //通过Ajax获取数据  
            $.ajax({
                type: "post",
                url: "../Reports_DMS.ashx",
                data: "&Action=getTodayCityAmt&date=" + $("#T_Date").val() + "&rnd=" + Math.random(),
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

    </script>
</body>
</html>
