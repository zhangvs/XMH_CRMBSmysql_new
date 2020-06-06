
var point = new Array();//{name:'临沂',value:1765110.03},
var line = new Array();//[{ name: '临沂' }, { name: '临沂', value: 1765110.03 }],
var lines = new Array();//[{ name: '临沂' }, { name: '临沂', value: 1765110.03 }],[{"name":"临沂"},{"name":"上海"}]
$(function () {
    var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height
    $("#main").css("height", h - 10);
    doserch();
});

require.config({
    paths: {
        echarts: '../../lib/echarts'
    }
});


function test(GridData) {
    for (var j = 0; j < GridData.Rows.length; j++) {
        line[j] = new Array();
        var qd =
        {
            name: '临沂'
        };
        var zd =
        {
            name: GridData.Rows[j].name,
            //value: GridData.Rows[j].value
            value: (Number(GridData.Rows[j].value) * 2).toFixed(2)
        };
        point.push(zd);
        line[j][0] = qd;
        line[j][1] = zd;
        lines.push(line[j]);

    }
    //console.log(JSON.stringify(lines));
    //alert(JSON.stringify(lines));



    require(
    [
        'echarts',
        'echarts/chart/bar',
        'echarts/chart/line',
        'echarts/chart/map'
    ],
    function (ec) {
        //--- 折柱 ---
        var myChart = ec.init(document.getElementById('main'));
        option = {
            backgroundColor: '#404a59',
            color: ['gold', 'aqua', 'lime'],
            title: {
                text: '新明辉全国客户订单总量分布',
                subtext: 'data from order',
                x: 'center',
                textStyle: {
                    color: '#fff'
                }
            },
            tooltip: {
                trigger: 'item',
                formatter: function (params, ticket, callback) {//格式化展现（标签+值）
                    var pp = "北京市，天津市，重庆市，上海市，河北省，山西省，辽宁省，吉林省，黑龙江省，江苏省，浙江省，安徽省，福建省，江西省，山东省，河南省，湖北省，湖南省，广东省，海南省，四川省，贵州省，云南省，陕西省，甘肃省，青海省，台湾省，内蒙古自治区，广西壮族自治区，西藏自治区，宁夏回族自治区，新疆维吾尔自治区，香港特别行政区，澳门特别行政区";
                    if (pp.indexOf(params.name) < 0) {
                        return params.name + ":" + params.value;
                    }
                    else {
                        return params.name;
                    }
                }

            },
            legend: {
                orient: 'vertical',
                x: 'left',
                data: ['订单总量'],
                selectedMode: 'single',
                textStyle: {
                    color: '#fff'
                }
            },
            toolbox: {
                show: true,
                orient: 'vertical',
                x: 'right',
                y: 'center',
                feature: {
                    mark: { show: true },
                    restore: { show: true },
                    saveAsImage: { show: true }
                }
            },
            dataRange: {
                min: 0,
                max: 5000000,
                calculable: true,
                color: ['#ff3333', 'orange', 'yellow', 'lime', 'aqua'],
                textStyle: {
                    color: '#fff'
                },
                itemHeight: 20
            },
            series: [
                {
                    name: '订单总量',
                    type: 'map',
                    mapType: 'china',
                    itemStyle: {
                        normal: {
                            borderColor: 'rgba(100,149,237,1)',
                            borderWidth: 0.5,
                            areaStyle: {
                                color: '#323c48'
                            }
                        },
                        emphasis: {
                            areaStyle: {
                                color: 'rgba(0,0,0,0)'//背景透明
                            }
                        }
                    },
                    data: [],
                    markLine: {
                        smooth: true,
                        effect: {
                            show: true,
                            scaleSize: 1,
                            period: 30,
                            color: '#fff',
                            shadowBlur: 10
                        },
                        itemStyle: {
                            normal: {
                                borderWidth: 1,
                                lineStyle: {
                                    type: 'solid',
                                    shadowBlur: 10
                                },
                                label: {
                                    show: false
                                }
                            }
                        },
                        data: lines
                    },
                    markPoint: {
                        symbol: 'emptyCircle',
                        symbolSize: function (v) {
                            return 0
                        },
                        itemStyle: {
                            normal: {
                                label: {
                                    show: true,
                                    formatter: function (params, ticket, callback) {//格式化展现（标签+值）
                                        return params.name;
                                    }

                                }
                            }
                        },
                        data: point
                    },
                    geoCoord: geoCoordMap
                }
            ]
        };



        myChart.setOption(option);

    }
);

}
//window.setInterval("doserch()", "5000");
function doserch() {
    $.ajax({
        type: "POST",
        url: "../Reports_DMS.ashx",
        data: "&Action=getCityAmt&rnd=" + Math.random(),
        dataType: 'json',
        success: function (responseText) {
            test(responseText);
        },
        error: function () {
            top.$.ligerDialog.closeWaitting();
            top.$.ligerDialog.error('查询失败！请检查查询项。');
        }
    });
}