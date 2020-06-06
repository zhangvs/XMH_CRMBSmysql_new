﻿var daycount = 0; var axisData = new Array(); var saleData = new Array(); var saleDataSum = 0; var saleDataSums = new Array(); var backData = new Array(); var backDataSum = 0; var backDataSums = new Array(); var saleBackData = new Array(); var saleBackDataSum = 0; var saleBackDataSums = new Array(); var goods_numbers = new Array(); var goods_prices = new Array(); var goods_id; var goods_ids = new Array(); var goods_name; var goods_names = new Array(); var mains = new Array(); var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; var monthData = new Array(); var monthSaleBackDatas = new Array(); var name; var admin_user_name; var user_name; var u_company; var brand_name; var smonth; var syear; function getDateCount(syear, smonth) { smonth = smonth; syear = syear; daycount = 0; var day = new Date(syear, smonth, 0); daycount = day.getDate() } function showAxisData() { axisData = []; for (var j = 0; j < daycount; j++) { axisData[j] = j + 1 + "日" } } function getMonthSaleBackData(GridData) { saleBackDataSums = []; saleDataSums = []; backDataSums = []; monthData = []; saleData = []; backData = []; saleBackData = []; goods_names = []; goods_ids = []; mains = []; $("#form1").html(""); for (var j = 0; j < GridData.Rows.length; j++) { if (j == 0) { admin_user_name = GridData.Rows[j].admin_user_name; name = GridData.Rows[j].name; user_name = GridData.Rows[j].user_name; u_company = GridData.Rows[j].u_company; brand_name = GridData.Rows[j].brand_name; } goods_id = GridData.Rows[j].goods_id; goods_name = GridData.Rows[j].goods_name; if ($.inArray(goods_id, goods_ids) >= 0) { continue; } else { var seriess_id = goods_ids.push(goods_id) - 1; goods_names.push(goods_name); $("#form1").append("<a id='a_main" + seriess_id + "' href='#main" + seriess_id + "'> </a><div id='main" + seriess_id + "' ></div>"); saleBackData[seriess_id] = new Array(); saleData[seriess_id] = new Array(); backData[seriess_id] = new Array(); goods_numbers[seriess_id] = new Array(); goods_prices[seriess_id] = new Array() } for (var i = 0; i < daycount; i++) { saleData[seriess_id][i] = 0; backData[seriess_id][i] = 0; saleBackData[seriess_id][i] = 0; goods_numbers[seriess_id][i] = 0; goods_prices[seriess_id][i] = 0 } saleBackDataSum = 0; saleDataSum = 0; backDataSum = 0; for (var b = j; b < GridData.Rows.length; b++) { if (goods_id == GridData.Rows[b].goods_id) { var orderDate = parseInt(GridData.Rows[b].orderdate) - 1; saleBackData[seriess_id][orderDate] = parseFloat(GridData.Rows[b].realmoney.toFixed()); saleBackDataSum += parseFloat(GridData.Rows[b].realmoney.toFixed()); saleData[seriess_id][orderDate] = parseFloat(GridData.Rows[b].salemoney.toFixed()); saleDataSum += parseFloat(GridData.Rows[b].salemoney.toFixed()); backData[seriess_id][orderDate] = parseFloat(GridData.Rows[b].backmoney.toFixed()); backDataSum += parseFloat(GridData.Rows[b].backmoney.toFixed()); goods_numbers[seriess_id][orderDate] = GridData.Rows[b].goods_number; goods_prices[seriess_id][orderDate] = GridData.Rows[b].goods_price } } saleBackDataSums[seriess_id] = saleBackDataSum; saleDataSums[seriess_id] = saleDataSum; backDataSums[seriess_id] = backDataSum; monthData[seriess_id] = new Array(); var monthSum = 0; for (var k = 0; k < daycount; k++) { monthSum += parseFloat(saleBackData[seriess_id][k].toFixed()); monthData[seriess_id][k] = monthSum } } if (!Array.prototype.forEach) { Array.prototype.forEach = function forEach(callback, thisArg) { var T, k; if (this == null) { throw new TypeError("this is null or not defined") } var O = Object(this); var len = O.length >>> 0; if (typeof callback !== "function") { throw new TypeError(callback + " is not a function") } if (arguments.length > 1) { T = thisArg } k = 0; while (k < len) { var kValue; if (k in O) { kValue = O[k]; callback.call(T, kValue, k, O) } k++ } } } saleBackData.forEach(function DrawEChart(v, e) { $("#main" + e).css("height", 300); var option = { title: { text: goods_names[e] + '_' + smonth + '月销售情况', subtext: '\n\n月销量：' + saleDataSums[e] + '\n月退货：' + backDataSums[e] + '\n月实际：' + saleBackDataSums[e] }, grid: { x: 180, }, tooltip: { trigger: 'axis', showDelay: 0, formatter: function (params, ticket, callback) { var res = params[0].name; for (var i = 0, l = params.length; i < l; i++) { res += '<br/>' + params[i].seriesName + ' : ' + params[i].value } return res } }, legend: { data: ['日销售额', '日退货额', '日实际销售额', '销售数量', '日销售数量', '日销售单价'], selected: { '日销售额': false, '日退货额': false, '日实际销售额': true, '日销售数量': false, '日销售单价': false } }, toolbox: { show: true, orient: 'vertical', feature: { mark: { show: true }, dataView: { show: true, readOnly: false, optionToContent: function (opt) { $("#main" + e).css("height", 680); var series = opt.series; var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>日期</td>'; for (var i = 0, l = series.length; i < l; i++) { table += '<td>' + series[i].name + '</td>' }; table += '</tr>'; for (var m = 0, g = axisData.length; m < g; m++) { table += '<tr><td>' + axisData[m] + '</td>'; for (var n = 0, l = series.length; n < l; n++) { var val = series[n].data[m]; if (n == 4 || n == 7) val += '%'; table += '<td>' + val + '</td>' } table += '</tr>' }; table += '</tbody></table>'; return table } }, magicType: { show: true, type: ['line', 'bar'] }, restore: { show: true }, saveAsImage: { show: true } } }, calculable: true, xAxis: [{ type: 'category', data: axisData }], yAxis: [{ type: 'value', scale: true, axisLabel: { formatter: function (v) { return v } }, splitArea: { show: true } }], series: [{ name: '日销售额', stack: '日期', type: 'bar', itemStyle: { normal: { label: { show: true, position: 'top' } } }, data: saleData[e] }, { name: '日退货额', stack: '日期', type: 'bar', itemStyle: { normal: { label: { show: true, position: 'bottom' } } }, data: backData[e] }, { name: '日实际销售额', type: 'bar', itemStyle: { normal: { label: { show: true, position: 'top' } } }, data: saleBackData[e], }, { name: '日销售数量', type: 'bar', itemStyle: { normal: { label: { show: true, position: 'top' } } }, data: goods_numbers[e], }, { name: '日销售单价', type: 'bar', itemStyle: { normal: { label: { show: true, position: 'top' } } }, data: goods_prices[e], }] }; var myChart = echarts.init(document.getElementById('main' + e), 'macarons'); myChart.setOption(option); mains.push(myChart) }); } $(window).resize(function () { mains.forEach(function echartsHight(v, e) { v.resize() }) }); var monthCustomerSaleBackDatas = new Array(); var monthCustomerSum = 0; function DrawEChartCustomerData() { monthCustomerSaleBackDatas = []; monthCustomerSum = 0; for (var i = 0; i < goods_ids.length; i++) { monthCustomerSaleBackDatas[i] = parseFloat((monthData[i][daycount - 1]).toFixed()); monthCustomerSum += monthCustomerSaleBackDatas[i] } } function DrawEChartCustomer() { DrawEChartCustomerData(); $("#main0").before("<div id='main' ></div>"); $("#main").css("height", 600); var option = { title: { text: u_company + '_' + brand_name + '_' + smonth + '月份单品销售情况', subtext: '致电：' + user_name + '\n\n所属员工：' + admin_user_name + '\n\n月销售合计：' + monthCustomerSum + '\n\n单品数：' + saleBackData.length }, grid: { x: 180, y2: 300 }, tooltip: { trigger: 'axis', showDelay: 0, formatter: function (params, ticket, callback) { var res = '可点击定位单品<br/>' + params[0].name; for (var i = 0, l = params.length; i < l; i++) { res += '<br/>' + params[i].seriesName + ' : ' + params[i].value } return res } }, legend: { data: ['月销售额'], selected: { '月销售额': true } }, toolbox: { show: true, orient: 'vertical', feature: { mark: { show: true }, dataView: { show: true, readOnly: false, optionToContent: function (opt) { var hh = (goods_names.length + 1) * 22; if (hh < 400) { hh = 400 } $("#main").css("height", hh); var series = opt.series; var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>单品</td>'; for (var i = 0, l = series.length; i < l; i++) { table += '<td>' + series[i].name + '</td>' }; table += '</tr>'; for (var m = 0, g = goods_names.length; m < g; m++) { table += '<tr><td>' + goods_names[m] + '</td>'; for (var n = 0, l = series.length; n < l; n++) { var val = series[n].data[m]; if (n == 2) val += '%'; table += '<td>' + val + '</td>' } table += '</tr>' }; table += '</tbody></table>'; return table }, }, magicType: { show: true, type: ['line', 'bar'] }, restore: { show: true }, saveAsImage: { show: true } } }, calculable: true, xAxis: [{ type: 'category', axisLabel: { interval: 0, rotate: 45, textStyle: { fontWeight: "bolder", color: "#000000" } }, data: goods_names }], yAxis: [{ type: 'value', scale: true, axisLabel: { formatter: function (v) { return v } }, splitArea: { show: true } }], series: [{ name: '月销售额', stack: '月份', type: 'bar', itemStyle: { normal: { label: { show: true, position: 'top' } } }, data: monthCustomerSaleBackDatas }] }; var myChartDep = echarts.init(document.getElementById('main'), 'macarons'); myChartDep.setOption(option); window.onresize = myChartDep.resize; myChartDep.on('click', function (params) { document.getElementById("a_main" + params.dataIndex).click() }) }