﻿var myChart; var eCharts; var series_data = []; var cityIds = []; var cityNames = []; var cityValues = []; var brandId = ''; var brandText = ''; var goodId = ''; var goodTextBox = ''; var cityTotalLength = 0; var cityTopLength = 49; var syear; var sumAllValue; var provinceZb = []; $(function () { $("#toolbar").ligerToolBar({ items: [{ type: 'textbox', id: "syear", text: "年度：" }, { type: 'textbox', id: 'tree1', text: '品牌：' }, { type: 'textbox', id: 'goodTxt', text: ' 单品关键词：' }, { type: 'button', text: '统计', icon: '../../images/search.gif', disable: true, click: function () { doserch() } }] }); initSelect(); DrawEChart(); doserch() }); function initSelect() { var d = new Date(); var nowYear = +d.getFullYear(); var syearData = []; for (var i = nowYear; i >= nowYear - 10; i--) { syearData.push({ 'text': i, 'id': i }) } $("#syear").ligerComboBox({ width: 100, selectBoxHeight: 300, data: syearData, initValue: nowYear, onSelected: function (id, text) { syear = text } }); $('#tree1').ligerComboBox({ width: 250, selectBoxWidth: 250, selectBoxHeight: 710, valueField: 'id', textField: 'text', treeLeafOnly: true, tree: { url: '../Reports_DMS.ashx?Action=getCheckBrandTree&rnd=' + Math.random(), idFieldName: 'id', checkbox: true }, onSelected: function (id, text) { brandId = id; brandText = text } }); $('#goodTxt').ligerTextBox({ width: 250 }); $("#goodTxt").autocomplete({ minLength: 1, source: function (request, response) { $.ajax({ type: "POST", url: "../Reports_DMS.ashx", data: { Action: "getYearGoodTxt", brandIdList: brandId, syear: syear, keyWord: request.term, rnd: Math.random() }, dataType: "json", success: function (data) { response($.map(data.Rows, function (item) { return { id: item.goods_id, value: item.goods_name } })) }, error: function () { alert("ajax请求失败") } }) }, change: function (event, ui) { goodId = '' }, select: function (event, ui) { goodId = ui.item.id } }) } function doserch() { $.ligerDialog.waitting('数据加载中,请稍候...'); syear = $("#syear").val(); goodTextBox = $("#goodTxt").val(); $.ajax({ type: "post", url: "../Reports_DMS.ashx", data: { Action: "getYearCityAmt", brandIdList: brandId, goodId: goodId, goodTextBox: goodTextBox, syear: syear, rnd: Math.random() }, dataType: "json", success: function (data) { if (data) { var options = myChart.getOption(); series_data = []; cityIds = []; cityNames = []; cityValues = []; sumAllValue = 0; provinceZb = []; if (series_data.length != data.Rows.length) { cityTotalLength = data.Rows.length; cityTopLength = data.Rows.length > 50 ? 50 : data.Rows.length; for (var j = 0; j < data.Rows.length; j++) { var id = data.Rows[j].id; var name = data.Rows[j].name; var value = parseFloat((data.Rows[j].value).toFixed()); sumAllValue += value; var geoCoord = geoCoordMap[data.Rows[j].name]; if (geoCoord) { series_data.push({ id: id, name: name, value: geoCoord.concat(value) }) } cityNames.push(j + 1 + '.' + name); cityValues.push(value) } for (var s = 0; s < data.Rows.length; s++) { var value = parseFloat((data.Rows[s].value).toFixed()); provinceZb.push(parseFloat((value / sumAllValue * 100).toFixed(2))) } } options.series[0].data = series_data.slice(0, series_data.length - 1); options.series[1].data = series_data.slice(0, 6); options.series[2].data = (cityValues.reverse()).slice(cityTotalLength - cityTopLength, cityTotalLength); options.series[3].data = (provinceZb.reverse()).slice(cityTotalLength - cityTopLength, cityTotalLength); options.yAxis[0].data = (cityNames.reverse()).slice(cityTotalLength - cityTopLength, cityTotalLength); options.yAxis[0].name = 'TOP ' + cityTopLength + '/ Total ' + cityTotalLength; options.title[0].text = '新明辉' + syear + '年份各城市销售分布'; if (brandId != '' && goodTextBox != '') { options.title[0].subtext = '品牌：' + brandText + '\n单品关键词：' + goodTextBox + '\n销量合计：' + sumAllValue } else if (goodTextBox != '') { options.title[0].subtext = '单品关键词：' + goodTextBox + '\n销量合计：' + sumAllValue } else if (brandId != '') { options.title[0].subtext = '品牌：' + brandText + '\n销量合计：' + sumAllValue } else { options.title[0].subtext = '所有品牌\n销量合计：' + sumAllValue } myChart.hideLoading(); myChart.setOption(options); $.ligerDialog.closeWaitting() } }, error: function (errorMsg) { alert("图表请求数据失败啦!"); myChart.hideLoading() } }) } function DrawEChart(ec) { var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; $("#main").css("height", h - 30); eCharts = ec; myChart = echarts.init(document.getElementById('main')); myChart.showLoading({ text: "图表数据正在努力加载..." }); var options = { backgroundColor: '#404a59', animation: true, animationDuration: 1000, animationEasing: 'cubicInOut', animationDurationUpdate: 1000, animationEasingUpdate: 'cubicInOut', title: { text: '新明辉' + $("#syear").val() + '年份各城市销售分布', left: 'center', textStyle: { color: '#fff' }, }, tooltip: { show: true, trigger: 'item', formatter: function (params) { if (typeof (params.value) == "object") { var res = params.name + ' : ' + params.value[2] } else { var res = params.name + ' : ' + params.value } return res } }, visualMap: { bottom: 20, left: 40, min: 0, max: 10000000, pieces: [{ min: 10000000 }, { min: 5000000, max: 10000000 }, { min: 2000000, max: 5000000 }, { min: 1000000, max: 2000000 }, { min: 500000, max: 1000000 }, { min: 100000, max: 500000, }, { max: 100000 }], color: ['#d94e5d', '#eac736', '#50a3ba'], textStyle: { color: '#fff' } }, geo: { map: 'china', zoom: '0.85', left: '10', right: '35%', label: { emphasis: { show: false } }, roam: true, itemStyle: { normal: { areaColor: '#323c48', borderColor: '#111' }, emphasis: { areaColor: '#2a333d' } } }, grid: { right: 40, top: 100, bottom: 40, width: '30%' }, xAxis: { type: 'value', scale: true, position: 'top', boundaryGap: false, splitLine: { show: false }, axisLine: { show: false }, axisTick: { show: false }, axisLabel: { margin: 2, textStyle: { color: '#aaa' } }, }, yAxis: { type: 'category', nameGap: 16, axisLine: { show: false, lineStyle: { color: '#ddd' } }, axisTick: { show: false, lineStyle: { color: '#ddd' } }, axisLabel: { interval: 0, textStyle: { color: '#ddd' } }, data: [] }, legend: { orient: 'horizontal', y: 20, x2: '5%', data: ['城市销量', '城市全国占比'], selected: { '城市销量': true, '城市全国占比': false }, textStyle: { color: '#fff' } }, series: [{ name: '年销售总量', type: 'scatter', coordinateSystem: 'geo', data: [], label: { normal: { formatter: '{b}', position: 'right', show: false }, emphasis: { show: true } }, itemStyle: { normal: { color: '#ddb926' } } }, { name: 'Top 5', type: 'effectScatter', coordinateSystem: 'geo', data: [], showEffectOn: 'render', rippleEffect: { brushType: 'stroke' }, hoverAnimation: true, label: { normal: { formatter: '{b}', position: 'right', show: true } }, itemStyle: { normal: { color: '#f4e925', shadowBlur: 10, shadowColor: '#333' } }, }, { name: '城市销量', type: 'bar', symbol: 'none', itemStyle: { normal: { color: '#ddb926', label: { show: true, position: 'right' } } }, data: [] }, { name: '城市全国占比', type: 'bar', symbol: 'none', itemStyle: { normal: { color: '#ddb926', label: { show: true, position: 'right', formatter: function (params, ticket, callback) { return params.value + '%' } } } }, data: [] }] }; myChart.hideLoading(); myChart.setOption(options); myChart.on('click', function (params) { window.open('/DMS/ReportForm/dms_map_city_year_details.aspx?syear=' + $("#syear").val() + '&CityId=' + params.data.id + '&CityName=' + params.data.name + '&CityValue=' + params.data.value[2] + '&brandIdList=' + brandId + '&brandText=' + brandText + '&goodId=' + goodId + '&goodTextBox=' + goodTextBox + '&rnd=' + Math.random()) }) }