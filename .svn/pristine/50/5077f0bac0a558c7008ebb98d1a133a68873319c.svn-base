<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>奖金设置</title>
    <meta http-equiv="X-UA-Compatible" content="IE=7" />
    <link href="../../CSS/core.css" rel="stylesheet" type="text/css" />
    <link href="../../lib/ligerUI/skins/ext/css/ligerui-all.css" rel="stylesheet" type="text/css" />
    <link href="../../CSS/input.css" rel="stylesheet" />

    <script src="../../lib/jquery/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerLayout.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerGrid.js" type="text/javascript"></script>
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
    <script src="../../lib/ligerUI/js/plugins/ligerResizable.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerTip.js" type="text/javascript"></script>

    <script src="../../lib/jquery-validation/jquery.validate.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/jquery.metadata.js" type="text/javascript"></script>
    <script src="../../lib/jquery-validation/messages_cn.js" type="text/javascript"></script>

    <script src="../../lib/jquery.form.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerToolBar.js" type="text/javascript"></script>
    <script src="../../JS/XHD.js" type="text/javascript"></script>
    <script src="../../JS/add.js" type="text/javascript"></script>
    <script src="../../lib/ligerUI/js/plugins/ligerMenu.js" type="text/javascript"></script>

    <style type="text/css">
        .dialog {
            font-size: 12px;
        }


        .dialog-height {
            height: 400px;
            overflow-y: auto;
            overflow-x: hidden;
        }

        .dialog-height2 {
            height: 300px;
            overflow-y: auto;
        }

        .dialog-height3 {
            height: 200px;
            overflow-y: scroll;
        }

        .dialog .dialog-body {
            padding: 15px 0px;
        }

        .dialog-body p {
            margin-top: 20px;
        }

        .dialog-body table th, .dialog-body table td {
            border: 1px solid #dcdcdc;
            height: 28px;
            line-height: 28px;
            text-align: center;
            font-weight: normal;
        }

        .dialog-ul {
            width: 100%;
            list-style: none;
            float: left;
            padding-left: 0px;
            margin-top: 13px;
        }

            .dialog-ul li {
                width: 50%;
                float: left;
                margin-top: 10px;
                position: relative;
            }

                .dialog-ul li span {
                    width: 105px;
                    padding-right: 5px;
                    text-align: right;
                    display: inline-block;
                    vertical-align: middle;
                }

                .dialog-ul li input {
                    height: 28px;
                    font-size: 12px;
                    vertical-align: middle;
                    position: relative;
                    line-height: 28px;
                    padding: 0px 3px;
                }

        .dialog-xz-ul li input[type="search"] {
            height: 26px;
            line-height: 26px;
            padding: 0px 3px;
        }

        .dialog-ul li select {
            height: 28px;
            width: 58%;
            font-size: 12px;
            border: solid 1px #ddd;
            border-radius: 4px;
        }

        .select_style {
            font-family: 'Microsoft YaHei';
            font-size: 14px;
            width: 50px;
            height: 30px;
            overflow: hidden;
            border: 1px solid #ccc;
            -moz-border-radius: 5px; /* Gecko browsers */
            -webkit-border-radius: 5px; /* Webkit browsers */
            border-radius: 5px;
        }

            .select_style select {
                padding: 5px;
                background: transparent;
                width: 48px;
                font-size: 16px;
                border: none;
                height: 30px;
                -webkit-appearance: none; /*for Webkit browsers*/
            }
            th{
                
                font-size: 14px;
                font-weight:bolder;
            }
    </style>

    <script type="text/javascript">
        var manager;
        var manager1;
        $(function () {
            initLayout();
            $(window).resize(function () {
                initLayout();
            });
            $(document).keydown(function (event) {
                if (event.keyCode == 13) { //绑定回车
                    doserch();
                }
            });

            window['g'] =
            //创建项目列表
            $("#maingrid4").ligerGrid({
                columns: [
                    {
                        display: '节点达标奖', columns:
                    [
                        { display: '第一节点', name: 'one_bonus', width: 80 },
                        { display: '第二节点', name: 'two_bonus', width: 80 },
                        { display: '第三节点', name: 'three_bonus', width: 80 },
                        { display: '第四节点', name: 'four_bonus', width: 80 },
                    ]
                    },
                    {
                        display: '个人周冠军', columns:
                    [
                        { display: '第一节点', name: 'week_one_bonus', width: 80 },
                        { display: '第二节点', name: 'week_two_bonus', width: 80 },
                        { display: '第三节点', name: 'week_three_bonus', width: 80 },
                        { display: '第四节点', name: 'week_four_bonus', width: 80 },
                    ]
                    },
                    { display: '个人月冠军', columns: [{ display: '个人月冠军', name: 'month_bonus', width: 80 }] },

                    {
                        display: '团队周冠军', columns:
                    [
                        { display: '第一节点', name: 'team_one_bonus', width: 80 },
                        { display: '第二节点', name: 'team_two_bonus', width: 80 },
                        { display: '第三节点', name: 'team_three_bonus', width: 80 },
                        { display: '第四节点', name: 'team_four_bonus', width: 80 },
                    ]
                    },
                    { display: '团队月冠军', columns: [{ display: '团队月冠军', name: 'team_month_bonus', width: 80 }] },


                    //{
                    //    display: '团队达标奖金 达到100%', columns:
                    //[
                    //    { display: '客服一部', name: 'p18_100', width: 80 },
                    //    { display: '客服二部', name: 'p20_100', width: 80 },
                    //    { display: '客服三部', name: 'p64_100', width: 80 },
                    //    { display: '客服四部', name: 'p82_100', width: 80 },
                    //    { display: '客服五部', name: 'p96_100', width: 80 },
                    //    { display: '客服六部', name: 'p114_100', width: 80 },
                    //    { display: '客服七部', name: 'p115_100', width: 80 }
                    //]
                    //},
                    //{
                    //    display: '团队达标奖金 达到90%', columns:
                    //[
                    //    { display: '客服一部', name: 'p18_90', width: 80 },
                    //    { display: '客服二部', name: 'p20_90', width: 80 },
                    //    { display: '客服三部', name: 'p64_90', width: 80 },
                    //    { display: '客服四部', name: 'p82_90', width: 80 },
                    //    { display: '客服五部', name: 'p96_90', width: 80 },
                    //    { display: '客服六部', name: 'p114_90', width: 80 },
                    //    { display: '客服七部', name: 'p115_90', width: 80 }
                    //]
                    //}

                ],

                dataAction: 'server',
                pageSize: 31, pageSizeOptions: [31, 62, 93],
                url: "../DMS_Set.ashx?Action=getBonus&rnd=" + Math.random(),
                width: '100%', height: '100%',
                heightDiff: -1,
                onRClickToSelect: true,
                onContextmenu: function (parm, e) {
                    actionCustomerID = parm.data.id;
                    menu.show({ top: e.pageY, left: e.pageX });
                    return false;
                }
            });

            $("#grid").height(document.documentElement.clientHeight - $(".toolbar").height());
            $('form').ligerForm();

            $("#toolbar").ligerToolBar({
                items: [
                    { type: 'button', text: '修改', icon: '../../Images/Icon/33.png', disable: true, click: function () { edit(); } }

                ]
                //激活哪个
            });
        });


        //新增
        function add() {
            show();
        }

        //编辑
        function edit() {
            var manager = $("#maingrid4").ligerGetGridManager();
            var row = manager.getSelectedRow();
            if (row) {
                $("#id").val(row.id);
                $("input[name='one_bonus']").val(row.one_bonus);
                $("input[name='two_bonus']").val(row.two_bonus);
                $("input[name='three_bonus']").val(row.three_bonus);
                $("input[name='four_bonus']").val(row.four_bonus);
                $("input[name='week_one_bonus']").val(row.week_one_bonus);
                $("input[name='week_two_bonus']").val(row.week_two_bonus);
                $("input[name='week_three_bonus']").val(row.week_three_bonus);
                $("input[name='week_four_bonus']").val(row.week_four_bonus);
                $("input[name='month_bonus']").val(row.month_bonus);
                $("input[name='team_one_bonus']").val(row.team_one_bonus);
                $("input[name='team_two_bonus']").val(row.team_two_bonus);
                $("input[name='team_three_bonus']").val(row.team_three_bonus);
                $("input[name='team_four_bonus']").val(row.team_four_bonus);
                $("input[name='team_month_bonus']").val(row.team_month_bonus);

                //$("input[name='p18_100']").val(row.p18_100);
                //$("input[name='p20_100']").val(row.p20_100);
                //$("input[name='p64_100']").val(row.p64_100);
                //$("input[name='p82_100']").val(row.p82_100);
                //$("input[name='p96_100']").val(row.p96_100);
                //$("input[name='p114_100']").val(row.p114_100);
                //$("input[name='p115_100']").val(row.p115_100);
                
                //$("input[name='p18_90']").val(row.p18_90);
                //$("input[name='p20_90']").val(row.p20_90);
                //$("input[name='p64_90']").val(row.p64_90);
                //$("input[name='p82_90']").val(row.p82_90);
                //$("input[name='p96_90']").val(row.p96_90);
                //$("input[name='p114_90']").val(row.p114_90);
                //$("input[name='p115_90']").val(row.p115_90);
                show();
            }
            else {
                $.ligerDialog.warn('请选择行！');
            }

        }


        //保存
        function Confirm() {
            var id = $("#id").val();
            var sendtxt = '&Action=updateBonus';

            sendtxt = sendtxt + '&' + $("form :input").fieldSerialize();
            $.ajax({
                url: "../DMS_Set.ashx?" + sendtxt,
                type: "POST",
                beforesend: function () {
                    $.ligerDialog.waitting('数据保存中,请稍候...');
                },
                success: function (responseText) {
                    if (responseText == 1) {
                        $.ligerDialog.success('添加成功！');
                        f_reload();
                        closeDivs();
                    }
                    else if (responseText == 0) {
                        $.ligerDialog.error('已存在此计划！');
                        f_reload();
                        closeDivs();
                    }
                    else if (responseText == 2) {
                        $.ligerDialog.success('修改成功！');
                        f_reload();
                        closeDivs();
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


        function f_reload() {
            var manager = $("#maingrid4").ligerGetGridManager();
            manager.loadData(true);
        };

        //取消
        function cancelAll() {
            closeDivs();
        }


    </script>
</head>
<body>
    <form id="form1" onsubmit="return false">
        <div id="toolbar"></div>
        <div id="grid">
            <div id="maingrid4" style="margin: -1px; min-width: 800px;"></div>
        </div>

        <!--新增-->
        <div class="dialog open" id="prodown" style="display: none; position: fixed; width:1300px; z-index: 9999; background: #fff;">
            <div class="dialog-head" id="dhead1"><span class="close rotate-hover" style="cursor: pointer" onclick="closeDivs();">X</span><strong id="titlsAll">奖金设置</strong></div>
            <div class="dialog-body line">
                <input type="text" id="id" name="id" style="display:none" />
                <table>
                    <tr>
                        <th>节点达标奖金：</th>
                        <td>第一节点奖金</td>
                        <td>第二节点奖金</td>
                        <td>第三节点奖金</td>
                        <td>第四节点奖金</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="one_bonus" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="two_bonus" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="three_bonus" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="four_bonus" value=" " /></td>
                    </tr>
                    <tr>
                        <th>个人周冠军奖金：</th>
                        <td>第一节点奖金</td>
                        <td>第二节点奖金</td>
                        <td>第三节点奖金</td>
                        <td>第四节点奖金</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="week_one_bonus" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="week_two_bonus" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="week_three_bonus" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="week_four_bonus" value=" " /></td>
                    </tr>
                    <tr>
                        <th>个人月冠军奖金：</th>
                        <td>个人月冠军奖金</td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="month_bonus" value=" " /></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <th>团队周冠军奖金：</th>
                        <td>第一节点奖金</td>
                        <td>第二节点奖金</td>
                        <td>第三节点奖金</td>
                        <td>第四节点奖金</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="team_one_bonus" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="team_two_bonus" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="team_three_bonus" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="team_four_bonus" value=" " /></td>
                    </tr>
                    <tr>
                        <th>团队月冠军奖金：</th>
                        <td>团队月冠军奖金</td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="team_month_bonus" value=" " /></td>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
<%--                    <tr>
                        <th>100%团队达标奖金</th>
                        <td>客服一部</td>
                        <td>客服二部</td>
                        <td>客服三部</td>
                        <td>客服四部</td>
                        <td>客服五部</td>
                        <td>客服六部</td>
                        <td>客服七部</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="p18_100" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p20_100" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p64_100" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p82_100" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p96_100" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p114_100" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p115_100" value=" " /></td>
                    </tr>
                    <tr>
                        <th>90%团队达标奖金</th>
                        <td>客服一部</td>
                        <td>客服二部</td>
                        <td>客服三部</td>
                        <td>客服四部</td>
                        <td>客服五部</td>
                        <td>客服六部</td>
                        <td>客服七部</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="p18_90" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p20_90" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p64_90" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p82_90" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p96_90" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p114_90" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="p115_90" value=" " /></td>
                    </tr>--%>
                </table>
                <div class="dialog-foot">
                    <input type="button" value="保存" class="button bg-load" style="border: 1px solid #ddd; border-color: #2c7;" onclick="Confirm()" />
                    <input type="button" value="关闭" class="button bg-close " style="border: 1px solid #ddd;" onclick="cancelAll()" />
                </div>
            </div>
        </div>
    </form>
    <form id='toexcel'></form>
</body>
</html>
