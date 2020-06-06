<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>分配团队奖</title>
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/input.css" rel="stylesheet" />
    <meta http-equiv="X-UA-Compatible" content="ie=8 chrome=1" />
    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerForm.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerComboBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerRadio.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerSpinner.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTextBox.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDateEditor.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerCheckBox.js" type="text/javascript"></script>

    <script src="../../lib/ligerUI/js/plugins/ligerTree.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerDialog.js" type="text/javascript"></script>

    <script src="../../lib/jquery-validation/jquery.validate.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/jquery.metadata.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/messages_cn.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/common.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTip.js" type="text/javascript"></script>
    <script src="../../lib/jquery.form.js" type="text/javascript"></script>
    <script src="../../JS/Toolbar.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>
    <script src="../../lib/json2.js"></script>
<%--    <style>
        .l-grid-row {vertical-align:top;}
        .l-grid-row-cell-inner {vertical-align:top;}
        .l-grid-row-cell-inner-fixedheight{height:60px; line-height:60px;}

    </style>--%>
    <script type="text/javascript">
        var TeamBonus;
        var yfpTeamBonus;
        var syear;
        var smonth;
        $(function () {
            TeamBonus = decodeURI(getparastr("team_bonus"));
            yfpTeamBonus = decodeURI(getparastr("yfp_team_bonus"));
            $("#sum").html(toMoney(TeamBonus));
            $("#sum1").html(toMoney(yfpTeamBonus));
            $("#sum2").html(toMoney(TeamBonus - yfpTeamBonus));
            syear = decodeURI(getparastr("syear"));
            smonth = decodeURI(getparastr("smonth"));

            $("#maingrid").ligerGrid({
                columns: [
                   { display: '序号', width: 50, render: function (rowData, rowindex, value, column, rowid, page, pagesize) { return (page - 1) * pagesize + rowindex + 1; } },
                   { name: 'name', display: '客服姓名', width: 164, align: 'center' },
                   {
                       name: 'id', display: '分配奖励', width: 150, align: 'left', render: function (item) {
                           var html = "";
                           if (item.id)
                           {
                               var team_carve_bonus = "";
                               if (item.team_carve_bonus != null) {
                                   team_carve_bonus = item.team_carve_bonus;
                               }
                               html = "<input type=\'text\' style=\"width:120px;text-align:right;\" id=\'T_team_carve_bonus_" + item.id + "\'' value=\'" + team_carve_bonus + "\'' name=\'T_team_carve_bonus\' ltype=\"text\" ligerui=\"{number: true}\" onchange=\"sumFeat(this)\" validate=\"{required:true}\" />";
                           }
                               return html
                       }
                   },
                   {
                       name: 'id', display: '单品奖励', width: 150, align: 'left', render: function (item) {
                           var html = "";
                           if (item.id)
                           {
                               var good_bonus = "";
                               if (item.good_bonus!=null) {
                                   good_bonus = item.good_bonus;
                               }
                               html = "<input type=\'text\' style=\"width:120px;text-align:right;\" id=\'T_good_bonus_" + item.id + "\'' value=\'" + good_bonus + "\'' name=\'T_good_bonus\' ltype=\"text\" ligerui=\"{number: true}\" onchange=\"set_tomoney(this)\" validate=\"{required:true}\" />";
                           }
                           return html
                       }
                   },
                   {
                       name: 'id', display: '电话量奖励', width: 150, align: 'left', render: function (item) {
                           var html = "";
                           if (item.id)
                           {
                               var phone_bonus = "";
                               if (item.phone_bonus != null) {
                                   phone_bonus = item.phone_bonus;
                               }
                               html = "<input type=\'text\' style=\"width:120px;text-align:right;\" id=\'T_phone_bonus_" + item.id + "\'' value=\'" + phone_bonus + "\'' name=\'T_phone_bonus\' ltype=\"text\" ligerui=\"{number: true}\" onchange=\"set_tomoney(this)\" validate=\"{required:true}\" />";

                           }
                           return html
                       }
                   },
                   {
                       name: 'id', display: '积分奖励', width: 150, align: 'left', render: function (item) {
                           var html = "";
                           if (item.id)
                           {
                               var point_bonus = "";
                               if (item.point_bonus != null) {
                                   point_bonus = item.point_bonus;
                               }
                               html = "<input type=\'text\' style=\"width:120px;text-align:right;\" id=\'T_point_bonus_" + item.id + "\'' value=\'" + point_bonus + "\'' name=\'T_point_bonus\' ltype=\"text\" ligerui=\"{number: true}\" onchange=\"set_tomoney(this)\" validate=\"{required:true}\" />";
                           }
                           return html
                       }
                   }
                ],
                pageSize: 30,
                pageSizeOptions: [30,50],
                dataAction: 'server',
                url: "../../DMS/Reports_DMS.ashx?Action=team_emps&syear=" + syear + "&smonth=" + smonth + "&rnd=" + Math.random(),
                width: '100%',
                height: '100%',
                heightDiff: -1,


            });
 

        })

        function f_save() {
            if ( checkText()) {
                var sendtxt = "&Action=updateSalary&syear=" + syear + "&smonth=" + smonth;
                return $("form :input").fieldSerialize() + sendtxt;
            }
            else
            {
                $.ligerDialog.warn(bolStr);
            }
            
        }

        function checkText() {
            var bol = true;
            bolStr = "";
            //分配奖励.00
            $("input[name$='T_team_carve_bonus']").each(function (index, domEle) {
                var feat = domEle.value.replace(/(^\s*)|(\s*$)/g, '');//替换输入的空格，js无trim（）
                if (feat == "") {
                    domEle.value = 0;
                }
            });
            //单品奖励
            $("input[name$='T_good_bonus']").each(function (index, domEle) {
                var feat = domEle.value.replace(/(^\s*)|(\s*$)/g, '');//替换输入的空格，js无trim（）
                if (feat == "") {
                    domEle.value = 0;
                }
            });
            //电话量奖励
            $("input[name$='T_phone_bonus']").each(function (index, domEle) {
                var feat = domEle.value.replace(/(^\s*)|(\s*$)/g, '');//替换输入的空格，js无trim（）
                if (feat == "") {
                    domEle.value = 0;
                }
            });
            //积分奖励
            $("input[name$='T_point_bonus']").each(function (index, domEle) {
                var feat = domEle.value.replace(/(^\s*)|(\s*$)/g, '');//替换输入的空格，js无trim（）
                if (feat == "") {
                    domEle.value = 0;
                }
            });
            var sheng = $("#sum2").html();
            if (sheng!="0.00") {
                bolStr = "剩余奖金不为0.00！";
                bol = false;
            }
            return bol;
        }

        function set_tomoney(e) {
            $(e).val(toMoney(e.value));
        }

        function sumFeat(e) {
            $(e).val(toMoney(e.value));
            var sum = 0;
            $("input[name$='T_team_carve_bonus']").each(function (index, domEle) {
                var feat = domEle.value;
                if (feat != "" && feat != "0.00") {
                    feat = feat.replace(/\,/g, '');//替换字符串所有，
                    sum += parseFloat(feat);
                }
            });

            $("#sum1").html(toMoney(sum));

            $("#sum2").html(toMoney(TeamBonus - sum));

        }

    </script>
</head>
<body>
    <form id="form1" onsubmit="return false">
        
        <table>
            <tr>
                
                <td><span style="font-size: 12px;font-weight:bold"> 团队奖合计:</span>
                    <span id="sum" style="color: green">0</span></td>
                <td><span style="font-size: 12px;font-weight:bold"> -已分配:</span>
                    <span id="sum1" style="color: green">0</span></td>
                <td><span style="font-size: 12px;font-weight:bold"> =剩余:</span>
                    <span id="sum2" style="color: red">0</span>&nbsp;&nbsp;&nbsp;&nbsp;(剩余金额必须为0.00)</td>
            </tr>
        </table>
        <div id="maingrid" style="height: 900px;"></div>
        
    </form>
</body>
</html>

