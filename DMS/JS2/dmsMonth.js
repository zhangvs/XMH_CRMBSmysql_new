﻿//日期天数
function getDateCount() {
    //年月
    syear = $("#syear").val();
    smonth = $("#smonth").val();
    if (smonth.length == 1) {
        smonth = '0' + smonth;
    }

    //天数
    daycount = 0;
    var day = new Date(syear, smonth, 0);//构造一个日期对象
    daycount = day.getDate();//获取天数

}
//一个月的节点日期
function showMonthNode(data) {
    node_one = data[0]; //第二节点起
    node_two = data[1]; //第二节点起
    node_three = data[2]; //第三节点起
    node_four = data[3]; //第四节点起
}

//x轴
function showAxisData() {    

    axisData = [];
    for (var j = 0; j < node_one; j++) {
        getAxisDatas(j + 1, nodeColors[0], axisDatas);
    }
    for (var j = node_one; j < node_two; j++) {
        getAxisDatas(j + 1, nodeColors[1], axisDatas);
    }
    for (var j = node_two; j < node_three; j++) {
        getAxisDatas(j + 1, nodeColors[2], axisDatas);
    }
    for (var j = node_three; j < node_four; j++) {
        getAxisDatas(j + 1, nodeColors[3], axisDatas);
    }
}
function getAxisDatas(date, color, array) {
    var val = {
        value: date,
        textStyle: {
            color: color
        }
    };
    array.push(val);

}

//画线
function getLines(lineName, lineValue, lineColor,xAxisEnd, lineNumber) {
    var qd = {
        name: lineName,
        value: lineValue,
        xAxis: -1,
        yAxis: lineValue,
        itemStyle: {
            normal: {
                color: lineColor,
                label: {
                    formatter: function (params, ticket, callback) {
                        return '                 ' + params.name
                    }
                }
            }
        }
    };
    var zd = {
        xAxis: xAxisEnd,
        yAxis: lineValue
    };
    lineNumber.push(qd);
    lineNumber.push(zd);
}

//渲染节点,哪个节点数组，地标，数据，颜色
function getColorAndValue(array, value, color) {
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

//渲染季度奖点
function getPoint(array, name, xAxis, value) {
    var dian = {
        name: name,
        value: value,
        xAxis: xAxis,
        yAxis: value,
        itemStyle: {
            normal: {
                color: '#FFFF00',
                label: {
                    show: true,
                    formatter: function (params, ticket, callback) {
                        return params.name
                    },
                    textStyle: {
                        color: '#FF1493',
                        fontFamily: 'Verdana, sans-serif',
                        fontSize: 10,
                        fontStyle: 'italic',
                        fontWeight: 'bold'
                    },
                }
            }
        }
    };
    array.push(dian);
}

function ie_forEach() {
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
}
