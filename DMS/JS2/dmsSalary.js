var persons = new Array();//人
var personIds = new Array();//人id
var saleDatas=new Array();//销售额
var backDatas=new Array();//退货额
var realDatas=new Array();//实际额
var brandNames=new Array();//品牌数组
var bp_percentages=new Array();//提成比
var chas=new Array();//差额
var wcls=new Array();//完成率
var percentages=new Array();//提成
var plans=new Array();//计划
var bases=new Array();//基数

var saleDataSums = new Array();
var backDataSums = new Array();
var realDataSums = new Array();
var baseSums=new Array();
var planSums=new Array();
var percentageSums = new Array();

var saleSum = 0;
var backSum = 0;
var realSum = 0;
var baseSum = 0;
var planSum = 0;
var percentageSum = 0;

var seriess_id=0;
var mains = new Array();//画图main数组
var rewardsText;
var rewardsTeamText;

var salaryData;//个人薪资对象

var html_personal_champion1;
var html_personal_champion2;
var html_personal_champion3;
var html_personal_champion4;
var html_personal_champion;

var html_personal_bonus1;
var html_personal_bonus2;
var html_personal_bonus3;
var html_personal_bonus4;

var html_team_champion1;
var html_team_champion2;
var html_team_champion3;
var html_team_champion4;
var html_team_champion;

var html_team_bonus1;
var html_team_bonus2;
var html_team_bonus3;
var html_team_bonus4;

var smonth ;





function clearData() {
    smonth = $("#smonth").val();
    if (smonth.length == 1) {
        smonth = '0' + smonth;

    }
    persons = [];
    html_personal_champion1 = '';
    html_personal_champion2 = '';
    html_personal_champion3 = '';
    html_personal_champion4 = '';
    html_personal_champion = '';
    html_personal_bonus1 = '';
    html_personal_bonus2 = '';
    html_personal_bonus3 = '';
    html_personal_bonus4 = '';

    html_team_champion1 = '';
    html_team_champion2 = '';
    html_team_champion3 = '';
    html_team_champion4 = '';
    html_team_champion = '';
    html_team_bonus1 = '';
    html_team_bonus2 = '';
    html_team_bonus3 = '';
    html_team_bonus4 = '';
    salaryData = [];
}
//初始化个人薪资数据
function initSalaryData(GridData) {
    salaryData = new Object();
    salaryData = GridData.Rows;
}

//初始化个人薪资数据
function initTeamData(GridData) {
    var team_champion = 0;
    var team_champion1 = 0;
    var team_bonus1 = 0;
    var team_champion2 = 0;
    var team_bonus2 = 0;
    var team_champion3 = 0;
    var team_bonus3 = 0;
    var team_champion4 = 0;
    var team_bonus4 = 0;

    var teamData = GridData.Rows;
    //团队奖
    for (var j = 0; j < teamData.length; j++) {
        if (smonth == teamData[j].monthnode) {
            team_champion = parseFloat(teamData[j].team_champion.toFixed());
            if (team_champion != 0) {
                html_team_champion = teamData[j].d_pname;
            }
        }
        
        if (smonth+'01' == teamData[j].monthnode) {
            team_champion1 = parseFloat(teamData[j].team_champion.toFixed());
            if (team_champion1 != 0) {
                html_team_champion1 = teamData[j].d_pname;
            }
            team_bonus1 = parseFloat(teamData[j].team_bonus.toFixed());
            if (team_bonus1 != 0) {
                html_team_bonus1 += teamData[j].d_pname + ':' + team_bonus1 + '</br>';
            }
        }


        if (smonth + '02' == teamData[j].monthnode) {
            team_champion2 = parseFloat(teamData[j].team_champion.toFixed());
            if (team_champion2 != 0) {
                html_team_champion2 = teamData[j].d_pname;
            }
            team_bonus2 = parseFloat(teamData[j].team_bonus.toFixed());
            if (team_bonus2 != 0) {
                html_team_bonus2 += teamData[j].d_pname + ':' + team_bonus2 + '</br>';
            }
        }

        if (smonth + '03' == teamData[j].monthnode) {
            team_champion3 = parseFloat(teamData[j].team_champion.toFixed());
            if (team_champion3 != 0) {
                html_team_champion3 = teamData[j].d_pname;
            }
            team_bonus3 = parseFloat(teamData[j].team_bonus.toFixed());
            if (team_bonus3 != 0) {
                html_team_bonus3 += teamData[j].d_pname + ':' + team_bonus3 + '</br>';
            }
        }

        if (smonth + '04' == teamData[j].monthnode) {
            team_champion4 = parseFloat(teamData[j].team_champion.toFixed());
            if (team_champion4 != 0) {
                html_team_champion4 = teamData[j].d_pname;
            }
            team_bonus4 = parseFloat(teamData[j].team_bonus.toFixed());
            if (team_bonus4 != 0) {
                html_team_bonus4 += teamData[j].d_pname + ':' + team_bonus4 + '</br>';
            }
        }
    }
}

function table_html() {
    $("#html_personal_champion").html(html_personal_champion);
    $("#html_personal_champion1").html(html_personal_champion1);
    $("#html_personal_champion2").html(html_personal_champion2);
    $("#html_personal_champion3").html(html_personal_champion3);
    $("#html_personal_champion4").html(html_personal_champion4);

    $("#html_personal_bonus1").html(html_personal_bonus1);
    $("#html_personal_bonus2").html(html_personal_bonus2);
    $("#html_personal_bonus3").html(html_personal_bonus3);
    $("#html_personal_bonus4").html(html_personal_bonus4);

    $("#html_team_champion").html(html_team_champion);
    $("#html_team_champion1").html(html_team_champion1);
    $("#html_team_champion2").html(html_team_champion2);
    $("#html_team_champion3").html(html_team_champion3);
    $("#html_team_champion4").html(html_team_champion4);

    $("#html_team_bonus1").html(html_team_bonus1);
    $("#html_team_bonus2").html(html_team_bonus2);
    $("#html_team_bonus3").html(html_team_bonus3);
    $("#html_team_bonus4").html(html_team_bonus4);
}

//根据客服id取个人薪资描述
function getSalaryText(uid,e,v) {
    var salaryText = '';
    if (salaryData.length==0) {
        salaryText = '\n\n总销量：' + saleDataSums[e] + '\n总退货：' + backDataSums[e] + '\n总实际：' + realDataSums[e] +
        '\n\n总完成率：' + parseFloat((realDataSums[e] / planSums[e] * 100).toFixed()) + '%\n提成合计：' + percentageSums[e];
    } else {
        var basic = 0;
        var grade = '';
        var personal_champion = 0;
        var personal_champion1 = 0;
        var personal_bonus1 = 0;
        var personal_champion2 = 0;
        var personal_bonus2 = 0;
        var personal_champion3 = 0;
        var personal_bonus3 = 0;
        var personal_champion4 = 0;
        var personal_bonus4 = 0;
        var team_carve_bonus = 0;
        var good_bonus = 0;
        var phone_bonus = 0;
        var point_bonus = 0;
        var percentage_sum = 0;
        var salary_sum = 0;
        var leave_days = 0;
        var absence_days = 0;
        var basic2 = 0;
        var percentage_sum2 = 0;
        var bonus_sum2 = 0;
        var seniority_bonus = 0;
        var meals_deductions = 0;
        var social_deductions = 0;
        var other_deductions = 0;
        var deductions_sum = 0;

        for (var j = 0; j < salaryData.length; j++) {

            if (uid == salaryData[j].admin_user_name) {

                //缺勤天数
                if (salaryData[j].absence_days == null) {
                    salaryText += '\n缺勤天数：未导入';
                }
                else {
                    absence_days = salaryData[j].absence_days;
                    if (absence_days != 0) {
                        salaryText += '\n缺勤天数：' + absence_days;
                    }
                }
                //工作日请假天数
                if (salaryData[j].leave_days == null) {
                    salaryText += '\n工作日请假天数：未导入';
                }
                else {
                    leave_days = salaryData[j].leave_days;
                    if (leave_days != 0) {
                        salaryText += '\n工作日请假天数：' + leave_days;
                    }
                }

                //基本工资
                if (salaryData[j].basic == null) {
                    salaryText += '\n\n基本工资：尚未统计';
                }
                else {
                    grade = salaryData[j].grade;
                    if (salaryData[j].basic2 != null) {
                        basic = parseFloat(salaryData[j].basic.toFixed());
                        basic2 = parseFloat(salaryData[j].basic2.toFixed());
                        salaryText += '\n\n基本工资' + grade + '：' + basic2 + '=' + basic + '-(' + Math.abs(basic) + '/30*' + absence_days + ")";
                    }
                    else {
                        basic = parseFloat(salaryData[j].basic.toFixed());
                        salaryText += '\n\n基本工资' + grade + '：' + basic;
                    }
                }
                salaryText += '\n客户数<1千：' + salaryData[j].xy_1000;
                salaryText += '\n客户数>=1千：' + salaryData[j].dy_1000;
                salaryText += '\n客户数>=5千：' + salaryData[j].dy_5000;
                salaryText += '\n客户数>=1万：' + salaryData[j].dy_10000;
                salaryText += '\n客户数>=2万：' + salaryData[j].dy_20000;

                //提成
                if (salaryData[j].percentage_sum == null) {
                    salaryText += '\n\n提成合计：尚未统计';
                }
                else {
                    if (salaryData[j].percentage_sum2 != null) {
                        percentage_sum = parseFloat(salaryData[j].percentage_sum.toFixed());
                        percentage_sum2 = parseFloat(salaryData[j].percentage_sum2.toFixed());
                        salaryText += '\n\n提成合计：' + percentage_sum2 + '='+ percentage_sum + '-('+ Math.abs(percentage_sum) + '/30*' + leave_days+")";
                    }
                    else {
                        percentage_sum = parseFloat(salaryData[j].percentage_sum.toFixed());
                        salaryText += '\n\n提成合计：' + percentage_sum;
                    }
                }

                //奖励
                if (salaryData[j].bonus_sum == null) {
                    salaryText += '\n\n奖励合计：尚未统计' ;
                }
                else {
                    if (salaryData[j].bonus_sum2 != null) {
                        bonus_sum = parseFloat(salaryData[j].bonus_sum.toFixed());
                        bonus_sum2 = parseFloat(salaryData[j].bonus_sum2.toFixed());
                        salaryText += '\n\n奖励合计：' + bonus_sum2 + '=' + bonus_sum + '-(' + Math.abs(bonus_sum) + '/30*' + leave_days+")" ;
                    }
                    else {
                        bonus_sum = parseFloat(salaryData[j].bonus_sum.toFixed());
                        salaryText += '\n\n奖励合计：' + bonus_sum ;
                    }
                }
                salaryText += '\n';
                //奖
                personal_champion = parseFloat(salaryData[j].personal_champion.toFixed());
                if (personal_champion != 0) {
                    salaryText += '\n月冠军奖：' + personal_champion;
                    html_personal_champion = v;
                }

                personal_champion1 = parseFloat(salaryData[j].personal_champion1.toFixed());
                if (personal_champion1 != 0) {
                    salaryText += '\n节点1冠军奖：' + personal_champion1;
                    html_personal_champion1 = v;
                }
                personal_bonus1 = parseFloat(salaryData[j].personal_bonus1.toFixed());
                if (personal_bonus1 != 0) {
                    salaryText += '\n节点1达标奖：' + personal_bonus1;
                    html_personal_bonus1 += v + ',';
                }

                personal_champion2 = parseFloat(salaryData[j].personal_champion2.toFixed());
                if (personal_champion2 != 0) {
                    salaryText += '\n节点2冠军奖：' + personal_champion2;
                    html_personal_champion2 = v;
                }
                personal_bonus2 = parseFloat(salaryData[j].personal_bonus2.toFixed());
                if (personal_bonus2 != 0) {
                    salaryText += '\n节点2达标奖：' + personal_bonus2;
                    html_personal_bonus2 += v + ',';
                }

                personal_champion3 = parseFloat(salaryData[j].personal_champion3.toFixed());
                if (personal_champion3 != 0) {
                    html_personal_champion3 = v;
                    salaryText += '\n节点3冠军奖：' + personal_champion3;
                }
                personal_bonus3 = parseFloat(salaryData[j].personal_bonus3.toFixed());
                if (personal_bonus3 != 0) {
                    salaryText += '\n节点3达标奖：' + personal_bonus3;
                    html_personal_bonus3 += v + ',';
                }

                personal_champion4 = parseFloat(salaryData[j].personal_champion4.toFixed());
                if (personal_champion4 != 0) {
                    html_personal_champion4 = v;
                    salaryText += '\n节点4冠军奖：' + personal_champion4;
                }
                personal_bonus4 = parseFloat(salaryData[j].personal_bonus4.toFixed());
                if (personal_bonus4 != 0) {
                    salaryText += '\n节点4达标奖：' + personal_bonus4;
                    html_personal_bonus4 += v + ',';
                }

                //团队奖分配
                if (salaryData[j].team_carve_bonus != null) {
                    team_carve_bonus = parseFloat(salaryData[j].team_carve_bonus.toFixed());
                    if (team_carve_bonus != 0) {
                        salaryText += '\n\n团队奖分配：' + team_carve_bonus;
                    }
                }

                //其他奖励
                if (salaryData[j].good_bonus != null) {
                    good_bonus = parseFloat(salaryData[j].good_bonus.toFixed());
                    if (good_bonus != 0) {
                        salaryText += '\n\n单品奖：' + good_bonus;
                    }
                }
                if (salaryData[j].phone_bonus != null) {
                    phone_bonus = parseFloat(salaryData[j].phone_bonus.toFixed());
                    if (phone_bonus != 0) {
                        salaryText += '\n电话量奖：' + phone_bonus;
                    }
                }
                if (salaryData[j].point_bonus != null) {
                    point_bonus = parseFloat(salaryData[j].point_bonus.toFixed());
                    if (point_bonus != 0) {
                        salaryText += '\n积分奖：' + point_bonus;
                    }
                }

                //工龄工资
                if (salaryData[j].seniority_bonus != null) {
                    seniority_bonus = parseFloat(salaryData[j].seniority_bonus.toFixed());
                    if (seniority_bonus != 0) {
                        salaryText += '\n\n工龄工资：' + seniority_bonus;
                    }
                }

                //扣款合计
                if (salaryData[j].deductions_sum != null) {
                    deductions_sum = parseFloat(salaryData[j].deductions_sum);
                    if (deductions_sum != 0) {
                        salaryText += '\n\n扣款合计：' + deductions_sum;
                    }
                }//餐费扣款
                if (salaryData[j].meals_deductions != null) {
                    meals_deductions = parseFloat(salaryData[j].meals_deductions);
                    if (meals_deductions != 0) {
                        salaryText += '\n餐费扣款：' + meals_deductions;
                    }
                }//社保扣款
                if (salaryData[j].social_deductions != null) {
                    social_deductions = parseFloat(salaryData[j].social_deductions);
                    if (social_deductions != 0) {
                        salaryText += '\n社保扣款：' + social_deductions;
                    }
                }//迟到扣款
                if (salaryData[j].late_deductions != null) {
                    late_deductions = parseFloat(salaryData[j].late_deductions);
                    if (late_deductions != 0) {
                        salaryText += '\n迟到扣款：' + late_deductions;
                    }
                }//退货运费扣款
                if (salaryData[j].shipping_deductions != null) {
                    shipping_deductions = parseFloat(salaryData[j].shipping_deductions);
                    if (shipping_deductions != 0) {
                        salaryText += '\n退货运费扣款：' + shipping_deductions;
                    }
                }//其他扣款
                if (salaryData[j].other_deductions != null) {
                    other_deductions = parseFloat(salaryData[j].other_deductions);
                    if (other_deductions != 0) {
                        salaryText += '\n其他扣款：' + other_deductions;
                    }
                }

                //工资合计
                if (salaryData[j].salary_sum == null) {
                    salaryText += '\n\n工资合计：尚未计算';
                }
                else {
                    salary_sum = parseFloat(salaryData[j].salary_sum.toFixed());
                    if (salary_sum != 0) {
                        salaryText += '\n\n工资合计：' + salary_sum;
                    }
                }

            }

        }
    }
    

    return salaryText;
}

//初始化各个数组
function initBrandPercentageData(GridData) {
    persons = [];
    personIds = [];
    saleDatas=[];
    backDatas=[];
    realDatas=[];
    brandNames=[];
    bp_percentages=[];
    chas=[];
    wcls=[];
    percentage=[];
    plans=[];
    bases=[];

    saleDataSums=[];
    backDataSums=[];
    realDataSums=[];
    baseSums=[];
    planSums=[];
    percentageSums = [];

    mains = [];
    $("#form1").html("");
    //赋值
    for (var j = 0; j < GridData.Rows.length; j++) {
        
        var person = GridData.Rows[j].bc_user_name;//姓名id
        if ($.inArray(person, personIds) < 0) {
            persons.push(GridData.Rows[j].bc_real_name)//姓名name
            seriess_id = personIds.push(person) - 1;//每个人新建一维数组
            if (seriess_id>0) {
                saleDataSums[seriess_id - 1] = saleSum.toFixed();//给前一个数组赋值
                backDataSums[seriess_id - 1] = backSum.toFixed();
                realDataSums[seriess_id - 1] = realSum.toFixed();
                percentageSums[seriess_id - 1] = percentageSum.toFixed();
                planSums[seriess_id - 1] = planSum.toFixed();
                baseSums[seriess_id - 1] = baseSum.toFixed();
            }
            
            $("#form1").append("<div id='main" + seriess_id + "' ></div>");
            saleDatas[seriess_id]=new Array();
            backDatas[seriess_id]=new Array();
            realDatas[seriess_id]=new Array();
            brandNames[seriess_id]=new Array();
            bp_percentages[seriess_id]=new Array();
            chas[seriess_id]=new Array();
            wcls[seriess_id]=new Array();
            percentages[seriess_id]=new Array();
            plans[seriess_id]=new Array();
            bases[seriess_id] = new Array();
            saleSum = 0;
            backSum = 0;
            realSum = 0;
            baseSum = 0;
            planSum = 0;
            percentageSum = 0;
        }
        saleDatas[seriess_id].push(parseFloat(GridData.Rows[j].salemoney_brand.toFixed()));
        backDatas[seriess_id].push(parseFloat(GridData.Rows[j].backmoney_brand.toFixed()));
        realDatas[seriess_id].push(parseFloat(GridData.Rows[j].realmoney_brand.toFixed()));
        brandNames[seriess_id].push(GridData.Rows[j].bc_brand_name);//品牌名，不转parseFloat
        bp_percentages[seriess_id].push(parseFloat(GridData.Rows[j].bp_percentage));//提成比不去小数位
        chas[seriess_id].push(parseFloat(GridData.Rows[j].cha_brand.toFixed()));
        wcls[seriess_id].push(parseFloat(GridData.Rows[j].wcl_brand.toFixed()));
        percentages[seriess_id].push(parseFloat(GridData.Rows[j].percentage_brand.toFixed()));
        plans[seriess_id].push(parseFloat(GridData.Rows[j].plan_brand.toFixed()));
        bases[seriess_id].push(parseFloat(GridData.Rows[j].base_brand.toFixed()));
        
        saleSum += parseFloat(GridData.Rows[j].salemoney_brand);
        backSum += parseFloat(GridData.Rows[j].backmoney_brand);
        realSum += parseFloat(GridData.Rows[j].realmoney_brand);
        percentageSum += parseFloat(GridData.Rows[j].percentage_brand);
        planSum += parseFloat(GridData.Rows[j].plan_brand);
        baseSum += parseFloat(GridData.Rows[j].base_brand);
        
    }
    saleDataSums[seriess_id] = saleSum.toFixed();//给最后一个数组赋值
    backDataSums[seriess_id] = backSum.toFixed();
    realDataSums[seriess_id] = realSum.toFixed();
    percentageSums[seriess_id] = percentageSum.toFixed();
    planSums[seriess_id] = planSum.toFixed();
    baseSums[seriess_id] = baseSum.toFixed();

}

function drawForEach() {
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

    //画图
    persons.forEach(function DrawEChart(v, e) {
        $("#main" + e).css("height", 500);
        var option = {
            title: {
                text: personIds[e] + '_' + v + '_' + smonth + '月薪资',
                subtext: getSalaryText(personIds[e],e,v),
                subtextStyle:{
                    color: "#708090"
             }
            },
            grid: {
                x: 250,//靠左200像素
                x2:60,
                y2: 100
            },
            tooltip: {
                trigger: 'axis',
                position: function (p) {   //其中p为当前鼠标的位置
                    return [p[0] + 10, p[1] - 10];
                }
            },
            legend: {
                data: ['提成', '月销售额', '月退货额', '月实际销售额', '月差额', '月完成率', '基数', '计划', '提成比'],
                selected: {
                    '提成': true,
                    '月销售额': false,
                    '月退货额': false,
                    '月实际销售额': false,
                    '月差额': false,
                    '月完成率': false,
                    '基数': false,
                    '计划': false,
                    '提成比': false,
                }
            },
            toolbox: {
                show: true,
                orient: 'vertical',
                feature: {
                    mark: {
                        show: true
                    },
                    dataView: {
                        show: true,
                        readOnly: false,
                        optionToContent: function (opt) {
                            $("#main" + e).css("height", 680);
                            var series = opt.series;
                            var table = '<table class="dataView" style="width:100%;text-align:center;border:1px solid"><tbody><tr>' + '<td>日期</td>';
                            for (var i = 0, l = series.length; i < l; i++) {
                                table += '<td>' + series[i].name + '</td>'
                            };

                            table += '</tr>';
                            for (var m = 0, g = brandNames[e].length; m < g; m++) {
                                table += '<tr><td>' + brandNames[e][m] + '</td>';
                                for (var n = 0, l = series.length; n < l; n++) {
                                    var val = series[n].data[m];
                                    if (n == 5 || n == 6) val += '%';
                                    table += '<td>' + val + '</td>'
                                }
                                table += '</tr>';
                            };
                            table += '</tbody></table>';
                            return table;
                        }
                    },
                    magicType: {
                        show: true,
                        type: ['line', 'bar']
                    },
                    restore: {
                        show: true
                    },
                    saveAsImage: {
                        show: true
                    }
                }
            },
            calculable: true,
            xAxis: [{
                type: 'category',//设置字体倾斜  
                axisLabel: {
                    interval: 0,
                    rotate: 45,//倾斜度 -90 至 90 默认为0  
                    //margin: 2,
                    textStyle: {
                        fontWeight: "bolder",
                        color: "#000000"
                    }
                },
                data: brandNames[e]
            }],
            yAxis: [{
                type: 'value',
                scale: true,
                axisLabel: {
                    formatter: function (v) {
                        return v
                    }
                },
                splitArea: {
                    show: true
                }
            }],
            series: [{
                name: '提成',
                stack: '月份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: percentages[e]
            }, {
                name: '月销售额',
                stack: '月份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: saleDatas[e]
            }, {
                name: '月退货额',
                stack: '月份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: backDatas[e]
            }, {
                name: '月实际销售额',
                stack: '月份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: realDatas[e]
            }, {
                name: '月差额',
                stack: '月份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'bottom'
                        }
                    }
                },
                data: chas[e]
            }, {
                name: '月完成率',
                stack: '月份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top',
                            formatter: function (params, ticket, callback) {
                                return params.data + '%'
                            },
                        }
                    }
                },
                data: wcls[e]
            }, {
                name: '提成比',
                stack: '月份',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: bp_percentages[e]
            }, {
                name: '计划',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: plans[e]
            }, {
                name: '基数',
                type: 'bar',
                itemStyle: {
                    normal: {
                        label: {
                            show: true,
                            position: 'top'
                        }
                    }
                },
                data: bases[e]
            }]
        };

        var myChart = echarts.init(document.getElementById('main' + e), 'macarons');
        myChart.setOption(option);
        mains.push(myChart);
    });
}

$(window).resize(function () {
    mains.forEach(function echartsHight(v, e) {
        v.resize();

    })
});