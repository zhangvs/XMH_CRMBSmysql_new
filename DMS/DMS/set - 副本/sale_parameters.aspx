<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>薪资级别设置</title>
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
                        display: 'C1', columns:
                    [
                        { display: '基本工资', name: 'c1', width: 80 },
                        { display: '客户数', name: 'cus_numc1', width: 80 },
                        { display: '销售额', name: 'sale_numc1', width: 80 },
                    ]
                    },
                    {
                        display: 'C2', columns:
                    [
                        { display: '基本工资', name: 'c2', width: 80 },
                        { display: '客户数', name: 'cus_numc2', width: 80 },
                        { display: '销售额', name: 'sale_numc2', width: 80 },
                    ]
                    },
                    {
                        display: 'S0', columns:
                    [
                        { display: '基本工资', name: 'szone', width: 80 },
                        { display: '客户数', name: 'cus_num0', width: 80 },
                        { display: '销售额', name: 'sale_num0', width: 80 },
                        { display: '客户数2', name: 'cus_num0_2', width: 80 },
                        { display: '销售额2', name: 'sale_num0_2', width: 80 },
                    ]
                    },
                    {
                        display: 'S1', columns:
                    [
                        { display: '基本工资', name: 'sone', width: 80 },
                        { display: '客户数', name: 'cus_num1', width: 80 },
                        { display: '销售额', name: 'sale_num1', width: 80 },
                        { display: '客户数2', name: 'cus_num1_2', width: 80 },
                        { display: '销售额2', name: 'sale_num1_2', width: 80 },
                    ]
                    },
                    {
                        display: 'S2', columns:
                    [
                        { display: '基本工资', name: 'stwo', width: 80 },
                        { display: '客户数', name: 'cus_num2', width: 80 },
                        { display: '销售额', name: 'sale_num2', width: 80 },
                        { display: '客户数2', name: 'cus_num2_2', width: 80 },
                        { display: '销售额2', name: 'sale_num2_2', width: 80 },
                    ]
                    },
                    {
                        display: 'S3', columns:
                    [
                        { display: '基本工资', name: 'sthree', width: 80 },
                        { display: '客户数', name: 'cus_num3', width: 80 },
                        { display: '销售额', name: 'sale_num3', width: 80 },
                        { display: '客户数2', name: 'cus_num3_2', width: 80 },
                        { display: '销售额2', name: 'sale_num3_2', width: 80 },
                    ]
                    },
                    {
                        display: 'S4', columns:
                    [
                        { display: '基本工资', name: 'sfour', width: 80 },
                        { display: '客户数', name: 'cus_num4', width: 80 },
                        { display: '销售额', name: 'sale_num4', width: 80 },
                        { display: '客户数2', name: 'cus_num4_2', width: 80 },
                        { display: '销售额2', name: 'sale_num4_2', width: 80 },
                    ]
                    },
                    {
                        display: 'S5', columns:
                    [
                        { display: '基本工资', name: 'sfive', width: 80 },
                        { display: '客户数', name: 'cus_num5', width: 80 },
                        { display: '销售额', name: 'sale_num5', width: 80 },
                        { display: '客户数2', name: 'cus_num5_2', width: 80 },
                        { display: '销售额2', name: 'sale_num5_2', width: 80 },
                    ]
                    },
                    {
                        display: 'S6', columns:
                    [
                        { display: '基本工资', name: 'ssix', width: 80 },
                        { display: '客户数', name: 'cus_num6', width: 80 },
                        { display: '销售额', name: 'sale_num6', width: 80 },
                        { display: '客户数2', name: 'cus_num6_2', width: 80 },
                        { display: '销售额2', name: 'sale_num6_2', width: 80 },
                    ]
                    },
                    {
                        display: '自定义', columns:
                    [
                        { display: '基本工资', name: 'zdy', width: 80 },
                        { display: '客户数', name: 'cus_num7', width: 80 },
                        { display: '销售额', name: 'sale_num7', width: 80 },
                    ]
                    },

                ],

                dataAction: 'server',
                pageSize: 31, pageSizeOptions: [31, 62, 93],
                url: "../DMS_Set.ashx?Action=getSaleParameters&rnd=" + Math.random(),
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
                $("#sale_id").val(row.sale_id);
                $("input[name='c1']").val(row.c1);
                $("input[name='cus_numc1']").val(row.cus_numc1);
                $("input[name='sale_numc1']").val(row.sale_numc1);

                $("input[name='c2']").val(row.c2);
                $("input[name='cus_numc2']").val(row.cus_numc2);
                $("input[name='sale_numc2']").val(row.sale_numc2);

                $("input[name='szone']").val(row.szone);
                $("input[name='cus_num0']").val(row.cus_num0);
                $("input[name='sale_num0']").val(row.sale_num0);
                $("input[name='cus_num0_2']").val(row.cus_num0_2);
                $("input[name='sale_num0_2']").val(row.sale_num0_2);

                $("input[name='sone']").val(row.sone);
                $("input[name='cus_num1']").val(row.cus_num1);
                $("input[name='sale_num1']").val(row.sale_num1);
                $("input[name='cus_num1_2']").val(row.cus_num1_2);
                $("input[name='sale_num1_2']").val(row.sale_num1_2);

                $("input[name='stwo']").val(row.stwo);
                $("input[name='cus_num2']").val(row.cus_num2);
                $("input[name='sale_num2']").val(row.sale_num2);
                $("input[name='cus_num2_2']").val(row.cus_num2_2);
                $("input[name='sale_num2_2']").val(row.sale_num2_2);

                $("input[name='sthree']").val(row.sthree);
                $("input[name='cus_num3']").val(row.cus_num3);
                $("input[name='sale_num3']").val(row.sale_num3);
                $("input[name='cus_num3_2']").val(row.cus_num3_2);
                $("input[name='sale_num3_2']").val(row.sale_num3_2);

                $("input[name='sfour']").val(row.sfour);
                $("input[name='cus_num4']").val(row.cus_num4);
                $("input[name='sale_num4']").val(row.sale_num4);
                $("input[name='cus_num4_2']").val(row.cus_num4_2);
                $("input[name='sale_num4_2']").val(row.sale_num4_2);

                $("input[name='sfive']").val(row.sfive);
                $("input[name='cus_num5']").val(row.cus_num5);
                $("input[name='sale_num5']").val(row.sale_num5);
                $("input[name='cus_num5_2']").val(row.cus_num5_2);
                $("input[name='sale_num5_2']").val(row.sale_num5_2);

                $("input[name='ssix']").val(row.ssix);
                $("input[name='cus_num6']").val(row.cus_num6);
                $("input[name='sale_num6']").val(row.sale_num6);
                $("input[name='cus_num6_2']").val(row.cus_num6_2);
                $("input[name='sale_num6_2']").val(row.sale_num6_2);

                $("input[name='zdy']").val(row.zdy);
                $("input[name='cus_num7']").val(row.cus_num7);
                $("input[name='sale_num7']").val(row.sale_num7);
                show();
            }
            else {
                $.ligerDialog.warn('请选择行！');
            }

        }


        //保存
        function Confirm() {
            var id = $("#id").val();
            var sendtxt = '&Action=updateSaleParameters';

            sendtxt = sendtxt + '&' + $("form :input").fieldSerialize();
            $.ajax({
                url: "../DMS_Set.ashx?" + sendtxt,
                type: "POST",
                beforesend: function () {
                    $.ligerDialog.waitting('数据保存中,请稍候...');
                },
                success: function (responseText) {
                    if (responseText == 2) {
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
        <div class="dialog open" id="prodown" style="display: none; position: fixed; width:1000px; z-index: 9999; background: #fff;">
            <div class="dialog-head" id="dhead1"><span class="close rotate-hover" style="cursor: pointer" onclick="closeDivs();">X</span><strong id="titlsAll">薪资级别设置</strong></div>
            <div class="dialog-body line">
                <input type="text" id="sale_id" name="sale_id" style="display:none" />
                <table>
                    <tr>
                        <th>C1：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="c1" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_numc1" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_numc1" value=" " /></td>
                    </tr>
                    <tr>
                        <th>C2：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="c2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_numc2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_numc2" value=" " /></td>
                    </tr>
                    <tr>
                        <th>S0：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                        <td>客户数2</td>
                        <td>销售额2</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="szone" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num0" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num0" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num0_2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num0_2" value=" " /></td>
                    </tr>
                    <tr>
                        <th>S1：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                        <td>客户数2</td>
                        <td>销售额2</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="sone" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num1" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num1" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num1_2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num1_2" value=" " /></td>
                    </tr>
                    <tr>
                        <th>S2：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                        <td>客户数2</td>
                        <td>销售额2</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="stwo" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num2_2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num2_2" value=" " /></td>
                    </tr>
                    <tr>
                        <th>S3：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                        <td>客户数2</td>
                        <td>销售额2</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="sthree" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num3" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num3" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num3_2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num3_2" value=" " /></td>
                    </tr>
                    <tr>
                        <th>S4：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                        <td>客户数2</td>
                        <td>销售额2</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="sfour" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num4" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num4" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num4_2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num4_2" value=" " /></td>
                    </tr>
                    <tr>
                        <th>S5：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                        <td>客户数2</td>
                        <td>销售额2</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="sfive" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num5" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num5" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num5_2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num5_2" value=" " /></td>
                    </tr>
                    <tr>
                        <th>S6：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                        <td>客户数2</td>
                        <td>销售额2</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="ssix" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num6" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num6" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num6_2" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num6_2" value=" " /></td>
                    </tr>
                    <tr>
                        <th>自定义：</th>
                        <td>基本工资</td>
                        <td>客户数</td>
                        <td>销售额</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><input type="text" style="text-align:right;" name="zdy" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="cus_num7" value=" " /></td>
                        <td><input type="text" style="text-align:right;" name="sale_num7" value=" " /></td>
                    </tr>
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
