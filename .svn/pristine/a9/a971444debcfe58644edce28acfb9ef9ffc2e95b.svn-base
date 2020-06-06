<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>【部门】团队薪资</title>
    <meta http-equiv="X-UA-Compatible" content="IE=8" />
    <link href="../../CSS/core.css" rel="stylesheet" type="text/css" />
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/Toolbar.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/input.css" rel="stylesheet" />

    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../libNew/ligerUI/js/core/base.js"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerLayout.js" type="text/javascript"></script>
    <script src="../../libNew/ligerUI/js/plugins/ligerGrid.js"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerForm.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerCheckBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerComboBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDateEditor.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerRadio.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTextBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerSpinner.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTree.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDrag.js" type="text/javascript"></script>
    <script src="../../libNew/ligerUI/js/plugins/ligerResizable.js"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerToolBar.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTip.js" type="text/javascript"></script>
    <script src="../../lib/jquery.form.js" type="text/javascript"></script>
    <script src="../../JS/add.js"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerMenu.js" type="text/javascript"></script>

    <script src="../../lib/echarts/echarts.min.js" type="text/javascript"></script>
    <script src="../../lib/echarts/theme/macarons.js" type="text/javascript"></script>
    <script src="../../JS/dmsSalary.js" type="text/javascript"></script>
     <style type="text/css">
        table.dataView {
            border-collapse: collapse;
            }

            table.dataView th, table.dataView td {
                border: 1px solid #000;
                padding: 0;
            }


            table.gridtable {
	font-family: verdana,arial,sans-serif;
	font-size:11px;
	color:#333333;
	border-width: 1px;
	border-color: #666666;
	border-collapse: collapse;
}
table.gridtable th {
	border-width: 1px;
	padding: 8px;
	border-style: solid;
	border-color: #666666;
	background-color: #ffd700;
    color: #ff6347;font-size: 12px;font-weight:bold
}
table.gridtable td {
	border-width: 1px;
	padding: 8px;
	border-style: solid;
	border-color: #666666;
	background-color: #f0e68c;
}
    </style>

    <script type="text/javascript">
        $(function () {
            var grbHigh = $("table.gridtable").height();
            var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height:812
            $("#form1").css("height", h - 30 - grbHigh).css("overflow-y", "scroll");//style=" height:800px;overflow-y: scroll;"30:工具栏160：光荣榜
            initLayout();
            $(window).resize(function () {
                initLayout();
            });
            $(document).keydown(function (event) {
                if (event.keyCode == 13) { //绑定回车
                    doserch();
                }
            });

            $("#toolbar").ligerToolBar({
                items: [
                    { type: 'textbox', id: 'tree1', text: '姓名：' },
                    { type: 'textbox', id: "syear", text: "年度：" },
                    { type: 'textbox', id: "smonth", text: "月份：" },
                    { type: 'button', text: '统计', icon: '../../images/search.gif', disable: true, click: function () { doserch(); } },
                    { type: 'button', text: '团队奖分配', icon: '../../images/Icon/41.png', disable: true, click: function () { carveTeamBonus(); } }
                ]
                //激活哪个
            });

            $("#toolbar2").ligerToolBar();

            initSelect();

            doserch();
        });

        function getHeight() {
            var grbHigh = $("table.gridtable").height();
            var h = window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight; //height:812
            $("#form1").css("height", h - 30 - grbHigh).css("overflow-y", "scroll");//style=" height:800px;overflow-y: scroll;"30:工具栏160：光荣榜
        }

        function initSelect() {
            var d = new Date();
            var syearData = [], smonthDate = [];
            var nowYear;
            var nowMonth=d.getMonth();
            
            var lastMonth;
            var lastYear;

            
            nowMonth = d.getMonth();
            nowYear = +d.getFullYear();


            if (nowMonth == 0) {
                lastMonth = 12;
                lastYear = +d.getFullYear() - 1;
            }
            else {
                lastMonth = nowMonth;
                lastYear = +d.getFullYear();
            }
            for (var i = 1; i <= 12; i++) {
                smonthDate.push({ 'text': i, 'id': i });
            }
            $("#smonth").ligerComboBox({
                width: 60, selectBoxHeight: 300, data: smonthDate, initValue: lastMonth
            });

            for (var i = nowYear; i >= nowYear - 10; i--) {
                syearData.push({ 'text': i, 'id': i });
            }
            $("#syear").ligerComboBox({
                width: 100, selectBoxHeight: 300,
                data: syearData,
                initValue: lastYear

            })


            $('#tree1').ligerComboBox({
                width: 250,
                selectBoxWidth: 250,
                selectBoxHeight: 400,
                valueField: 'id',
                textField: 'text',
                treeLeafOnly: true,
                //checkbox: true,
                tree: {
                    url: '../Reports_DMS.ashx?Action=getDeptPerson&rnd=' + Math.random(),
                    idFieldName: 'id',
                    //parentIDFieldName: 'pid',
                    checkbox: true
                }
                //onSelected:function (note)
                //{
                //    alert('onSelect:' + note);
                //}

            });

            //团队薪资表
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getEmpCode",  rnd: Math.random() },
                success: function (responseText) {
                    if (responseText != "1010" && responseText != "5001" && responseText != "5007") {
                        $("#toolbar2").hide();
                    }
                    else {
                        $("#toolbar2").show();
                    }
                }
            });
        }

        function doserch() {
            $.ligerDialog.waitting('数据加载中,请稍候...');
            var tree1 = $("#tree1_val").val();
            var syear = $("#syear").val();
            var smonth = $("#smonth").val();
            clearData();
            //品牌提成
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "getBrandPercentageData_Manager", idlist: tree1, syear: syear, smonth: smonth, rnd: Math.random() },
                dataType: 'json',
                success: function (responseText) {
                    if (typeof (responseText) != "undefined") {
                        if (responseText.Total == "0") {
                            $.ligerDialog.error('无品牌考核提成');
                        }
                        else {
                            initBrandPercentageData(responseText);//数据

                            //个人薪资表
                            $.ajax({
                                type: "POST",
                                async: false,
                                url: "../Reports_DMS.ashx",
                                data: { Action: "getSalaryData_Manager", idlist: tree1, syear: syear, smonth: smonth, rnd: Math.random() },
                                dataType: 'json',
                                success: function (responseText) {
                                    if (typeof (responseText) != "undefined") {
                                        initSalaryData(responseText);//数据
                                    }
                                }
                            });

                            //团队薪资表
                            $.ajax({
                                type: "POST",
                                async: false,
                                url: "../Reports_DMS.ashx",
                                data: { Action: "getTeamData_Manager", syear: syear, smonth: smonth, rnd: Math.random() },
                                dataType: 'json',
                                success: function (responseText) {
                                    if (typeof (responseText) != "undefined") {
                                        initTeamData(responseText);//数据
                                    }
                                }
                            });

                            //遍历每一个人的提成和薪资
                            drawForEach();
                            table_html();
                            getHeight();
                        }
                    }
                }
            });
            $.ligerDialog.closeWaitting();
        }

        //分配团队奖
        function carveTeamBonus() {
            var syear = $("#syear").val();
            var smonth = $("#smonth").val();

            var myDate = new Date();
            var nowDate = myDate.getDate(); //获取当前日(1-31)
            //if (nowDate<=18) {
            //    $.ligerDialog.error('请在20号之后再分配团队奖，以免上个月数据发生变动！');
            //}
            //else {

            //}
            //团队薪资表
            $.ajax({
                type: "POST",
                async: false,
                url: "../Reports_DMS.ashx",
                data: { Action: "team_carvebonus", syear: syear, smonth: smonth, rnd: Math.random() },
                dataType: 'json',
                success: function (responseText) {
                    if (responseText != "") {
                        if (responseText.state == "1") {
                            $.ligerDialog.warn('已导入考勤，不允许再分配团队奖！');
                        }
                        else if (responseText.Total == "0") {
                            $.ligerDialog.warn('无团队奖！');
                        }
                        else {
                            f_openWindow('/DMS/ReportForm/dms_team_carvebonus.aspx?team_bonus=' + responseText.team_bonus + '&yfp_team_bonus=' + responseText.yfp_team_bonus + '&syear=' + syear + '&smonth=' + smonth + '&rnd=' + Math.random(), "团队奖分配", 850, 450);

                        }
                    }
                    else {

                    }
                }
            });
        }

        var activeDialog = null;
        function f_openWindow(url, title, width, height) {
            var dialogOptions = {
                width: width, height: height, title: title, url: url, buttons: [
                        {
                            text: '保存', onclick: function (item, dialog) {
                                f_save(item, dialog);
                            }
                        },
                        {
                            text: '关闭', onclick: function (item, dialog) {
                                dialog.close();
                            }
                        }
                ], isResize: true, showToggle: true, timeParmName: 'a'
            };
            activeDialog = $.ligerDialog.open(dialogOptions);
        }

        function f_openWindow1(url, title, width, height) {
            var dialogOptions = {
                width: width, height: height, title: title, url: url, buttons: [
                        {
                            text: '关闭', onclick: function (item, dialog) {
                                dialog.close();
                            }
                        }
                ], isResize: true, showToggle: true, timeParmName: 'a'
            };
            activeDialog = $.ligerDialog.open(dialogOptions);
        }
        //保存
        function f_save(item, dialog) {
            var issave = dialog.frame.f_save();
            if (issave) {
                dialog.close();
                $.ajax({
                    url: "../Reports_DMS.ashx", type: "POST",
                    data: issave,
                    beforesend: function () {
                        $.ligerDialog.waitting('数据保存中,请稍候...');
                    },
                    success: function (responseText) {
                        if (responseText == "update:success") {
                            $.ligerDialog.success('更新成功！');
                        }
                        else if (responseText.indexOf("update:failure") >= 0) {
                            $.ligerDialog.warn(responseText.substring(15, responseText.length));
                        }
                    },
                    error: function () {
                        $.ligerDialog.error('操作失败！');
                    },
                    complete: function () {
                        $.ligerDialog.closeWaitting();
                    }
                });

            }
        }


        function checkpath() {
            var path = $("#upload").val();
            //var filename = path.substr(path.lastIndexOf("\\")).toLowerCase();
            var filename = path.substr(path.lastIndexOf(".")).toLowerCase();//获得文件后缀名
            if (filename == ".xls" || filename == ".xlsx") {
                $("#btn_up").attr("disabled", "");
            }
            else {
                $("#btn_up").attr("disabled", "disabled");
                alert("您选择的文件似乎是错误的，请认真检查。文件格式：.xls或.xlsx");
            }


        }

        function update() {
            //$.ligerDialog.confirm("部门经理是否已分配完团队奖？", function (yes) {
            //    if (yes) {

                    var filename = $("#upload").val();
                    var syear = $("#syear").val();
                    var smonth = $("#smonth").val();

                    $.ligerDialog.waitting('数据上传中,请稍候...');
                    $("#serchform").ajaxSubmit({
                        type: "post",
                        url: "../Reports_DMS.ashx", /* 注意后面的名字对应CS的方法名称 */
                        data: { Action: 'excel_upload', filename: filename, rnd: Math.random() }, /* 注意参数的格式和名称 */
                        contentType: "application/json; charset=utf-8",
                        dataType: "text",
                        success: function (filepath) {
                            if (filepath == "Unauthorized") {
                                $.ligerDialog.warn('您无权限导入考勤和工龄数据！');
                                $.ligerDialog.closeWaitting();
                            }
                            else if (filepath.indexOf("团队奖未分配") >= 0) {
                                $.ligerDialog.warn(filepath);
                                $.ligerDialog.closeWaitting();
                            }
                            else if (filepath == "false") {
                                $.ligerDialog.error('上传文件出现错误！');
                                $.ligerDialog.closeWaitting();
                            }
                            else {
                                $.ajax({
                                    url: "../Reports_DMS.ashx", type: "POST",
                                    data: { Action: "input_AbsenceDays_SeniorityBonus", filename: filename, file: filepath, syear: syear, smonth: smonth, rnd: Math.random() },
                                    success: function (responseText) {
                                        if (responseText == "true") {
                                            $.ligerDialog.closeWaitting();
                                            $.ligerDialog.success('导入成功！');
                                        }
                                        else if (responseText == "0") {
                                            $.ligerDialog.closeWaitting();
                                            $.ligerDialog.error('导入文件记录为0！');
                                        }
                                        else {
                                            $.ligerDialog.closeWaitting();
                                            $.ligerDialog.error('导入失败！');
                                        }
                                    },
                                    error: function () {
                                        $.ligerDialog.closeWaitting();
                                        $.ligerDialog.error('操作失败！');
                                    }
                                });
                            }
                        },
                        error: function () {
                            $.ligerDialog.closeWaitting();
                            $.ligerDialog.error('操作失败！');
                        }
                    });

            //    }
            //});
            
        }

        function export_Salary() {
            var syear = $("#syear").val();
            var smonth = $("#smonth").val();
            window.open("/DMS/Reports_DMS.ashx?Action=export_Salary&syear=" + syear + "&smonth=" + smonth + "&rnd=" + Math.random());
            closePort();
        }

        function cc() {
            var syear = $("#syear").val();
            var smonth = $("#smonth").val();
            $.ligerDialog.confirm("当历史存档薪资数据发生改单或删单时可以清理，重新查询便可写入最新数据。可假如已分配团队奖和导入考勤数据，则需要再手工操作一遍团队奖和考勤动作，确定继续吗？", function (yes) {
                if (yes) {
                    $.ajax({
                        type: "post",
                        url: "../Reports_DMS.ashx", /* 注意后面的名字对应CS的方法名称 */
                        data: { Action: "clear_Salary", syear: syear, smonth: smonth, rnd: Math.random() },
                        dataType: "json",
                        success: function (data) {
                            if (data == "Unauthorized") {
                                $.ligerDialog.warn('您无权限清理存档薪资数据！');
                                $.ligerDialog.closeWaitting();
                            }
                            else if (data == 1) {
                                $.ligerDialog.success('清理完成，等待重新写入！');
                                location.reload();
                            }
                        }
                    });
                }
            });
        }

        function checkpath2() {
            var path = $("#upload2").val();
            var filename = path.substr(path.lastIndexOf(".")).toLowerCase();//获得文件后缀名
            if (filename == ".xls" || filename == ".xlsx") {
                $("#btn_up2").attr("disabled", "");
            }
            else {
                $("#btn_up2").attr("disabled", "disabled");
                alert("您选择的文件似乎是错误的，请认真检查。文件格式：.xls或.xlsx");
            }


        }

        function updateCarvebonus() {
            var filename = $("#upload2").val();
            var syear = $("#syear").val();
            var smonth = $("#smonth").val();

            $.ligerDialog.waitting('数据上传中,请稍候...');
            $("#serchform").ajaxSubmit({
                type: "post",
                url: "../Reports_DMS.ashx", /* 注意后面的名字对应CS的方法名称 */
                data: { Action: 'excel_upload2', filename: filename, rnd: Math.random() }, /* 注意参数的格式和名称 */
                contentType: "application/json; charset=utf-8",
                dataType: "text",
                success: function (filepath) {
                    if (filepath == "Unauthorized") {
                        $.ligerDialog.warn('您无权限导入已分配团队奖数据！');
                        $.ligerDialog.closeWaitting();
                    }
                    else if (filepath == "false") {
                        $.ligerDialog.error('上传文件出现错误！');
                        $.ligerDialog.closeWaitting();
                    }
                    else {
                        $.ajax({
                            url: "../Reports_DMS.ashx", type: "POST",
                            data: { Action: "input_Team_Carvebonus", filename: filename, file: filepath, syear: syear, smonth: smonth, rnd: Math.random() },
                            success: function (responseText) {
                                if (responseText == "true") {
                                    $.ligerDialog.closeWaitting();
                                    $.ligerDialog.success('导入成功！');
                                }
                                else if (responseText == "0") {
                                    $.ligerDialog.closeWaitting();
                                    $.ligerDialog.error('导入文件记录为0！');
                                }
                                else {
                                    $.ligerDialog.closeWaitting();
                                    $.ligerDialog.error('导入失败！');
                                }
                            },
                            error: function () {
                                $.ligerDialog.closeWaitting();
                                $.ligerDialog.error('操作失败！');
                            }
                        });
                    }
                },
                error: function () {
                    $.ligerDialog.closeWaitting();
                    $.ligerDialog.error('操作失败！');
                }
            });
        }

        
        
    </script>

</head>
<body >
    <div style="position: relative; z-index: 9999">
        <form id="serchform"  runat="server">
            <div id="toolbar" style=" width:100%"></div>
            <div id="toolbar2" style=" width:100%">

                <input name="upload" style="margin-left:20px" type="file" id="upload" onchange="checkpath()" runat="server" />
                <input type="button" id="btn_up" value="导入缺勤和工龄" disabled="disabled" onclick="update()" /> 
                <input id="clear_Salary" style="margin-left:20px" type="button" value="清理缓存薪资数据"  onclick="cc()"/>  
                <input name="upload2" style="margin-left:20px" type="file" id="upload2" onchange="checkpath2()" runat="server" />
                <input type="button" id="btn_up2" value="导入已分配团队奖" disabled="disabled" onclick="updateCarvebonus()" /> 
                <input id="exported_Salary" style="margin-left:20px" type="button" value="导出薪资"  onclick="export_Salary()"/>  
            </div>
        </form>
    </div>
    <div id="maingrid"></div>
    <!-- CSS goes in the document HEAD or added to your external stylesheet -->

<!-- Table goes in the document BODY -->
<table class="gridtable" >
<tr>
	<th>个人周1冠军</th><th>个人周2冠军</th><th>个人周3冠军</th><th>个人周4冠军</th><th>个人月冠军</th>
    <th>个人节点1达标</th><th>个人节点2达标</th><th>个人节点3达标</th><th>个人节点4达标</th>
</tr>
<tr>
	<td width="5%"><span id="html_personal_champion1" ></span></td>
    <td width="5%"><span id="html_personal_champion2" ></span></td>
	<td width="5%"><span id="html_personal_champion3" ></span></td>
	<td width="5%"><span id="html_personal_champion4" ></span></td>
	<td width="5%"><span id="html_personal_champion" ></span></td>
    <td width="16%"><span id="html_personal_bonus1" ></span></td>
	<td width="16%"><span id="html_personal_bonus2" ></span></td>
	<td width="16%"><span id="html_personal_bonus3" ></span></td>
	<td width="16%"><span id="html_personal_bonus4" ></span></td>
</tr>

<tr>
    <th>团队周1冠军</th><th>团队周2冠军</th><th>团队周3冠军</th><th>团队周4冠军</th><th>团队月冠军</th>
    <th>团队节点1达标</th><th>团队节点2达标</th><th>团队节点3达标</th><th>团队节点4达标</th>
</tr>
<tr>

	<td><span id="html_team_champion1" ></span></td>
	<td><span id="html_team_champion2" ></span></td>
	<td><span id="html_team_champion3" ></span></td>
	<td><span id="html_team_champion4" ></span></td>
	<td><span id="html_team_champion" ></span></td>
	<td><span id="html_team_bonus1" ></span></td>
	<td><span id="html_team_bonus2" ></span></td>
	<td><span id="html_team_bonus3" ></span></td>
	<td><span id="html_team_bonus4" ></span></td>
</tr>
</table>

    <form id="form1" onsubmit="return false">
    </form>


</body>
</html>
