﻿
var bp_brand_name; //品牌名
var bp_brand_ids = new Array();//品牌名数组
var bp_brand_names = new Array();//品牌名数组
var bp_percentages = new Array();//品牌提成数组(销售额-退货-基数)*比例==提成


//个人每日实际销售量
function getBrandManagerData(GridData) {
    clearData();
    bp_brand_names = [];//考核品牌名数组
    bp_percentages = [];//考核品牌提成数组
    var _id = 0;
    
    for (var j = 0; j < GridData.Rows.length; j++) {
        //取列字段赋值
        bp_brand_name = GridData.Rows[j].bp_brand_name;//品牌name
        //判断品牌名称数组中是否存在当前品牌名，如果不存在初始化一个新数组
        if ($.inArray(bp_brand_name, bp_brand_names) < 0) {
            _id = bp_brand_names.push(bp_brand_name) - 1;//如果第一次出现，添加到数组中,返回前放入元素的id,返回值-1为数组角标
            bp_brand_ids.push(GridData.Rows[j].bp_brand_id);//品牌提成
            bp_percentages.push(GridData.Rows[j].bp_percentage);//品牌提成
            initSingleData(_id);
            //当前品牌的基数，计划，画线
            getBasePlanLine(_id, parseFloat(GridData.Rows[j].base.toFixed()), parseFloat(GridData.Rows[j].plan.toFixed()));
        }
        //循环赋值
        getSingleDataValue(_id,GridData.Rows[j]);
    }
    initGroupData(bp_brand_names);
    initWholeData(bp_brand_names);

    if (singlecount==12) {
        dataDraw(bp_brand_ids,bp_brand_names, yearUnits, yearLegendDatas, yearLegendBools);
        initCycleCompare(yearCycles, bp_brand_names);
    }
    else {
        dataDraw(bp_brand_ids,bp_brand_names, monthUnits, monthLegendDatas, monthLegendBools);
        initCycleCompare(monthCycles, bp_brand_names);
    }
}




//客服
function getBrandManagerData_Emp(GridData) {
    var empBrandNames = new Array();
    var _id;
    clearSideParamData();
    for (var i = 0; i < GridData.Rows.length; i++) {
            bp_brand_name = GridData.Rows[i].bp_brand_name;
            if ($.inArray(bp_brand_name, empBrandNames) < 0) {
                _id = empBrandNames.push(bp_brand_name) - 1
                    initSideParamData(_id);
            }
            getSideParamDataValue(_id, GridData.Rows[i]);
    }
    if (smonth == 'undefined') {
        sideParamDraw(empBrandNames, sideEmp, sideParamYearLegendDatas, sideParamYearLegendBools);
    }
    else {
        sideParamDraw(empBrandNames, sideEmp, sideParamMonthLegendDatas, sideParamMonthLegendBools);
    }
    
}


//客服
//function getBrandManagerData_Emp(GridData) {
//    clearSideParamData();
//    var nb;//当前品牌id
//    var d = 0;//当前品牌下姓名下标
//    for (var i = 0; i < GridData.Rows.length; i++) {
//        bp_brand_name = GridData.Rows[i].bp_brand_name;
//        var _id = $.inArray(bp_brand_name, bp_brand_names);
//        if (_id != nb) {
//            nb = _id;
//            d = i;
//            initSideParamData(_id);
//        }
//        getSideParamDataValue(_id, i - d, GridData.Rows[i]);
//    }
//    if (singlecount == 12) {
//        sideParamDraw(bp_brand_names, sideEmp, sideParamYearLegendDatas, sideParamYearLegendBools);
//    }
//    else {
//        sideParamDraw(bp_brand_names, sideEmp, sideParamMonthLegendDatas, sideParamMonthLegendBools);
//    }

//}



//单品
function getBrandManagerData_Good(GridData) {
    var goodBrandNames = new Array();
    var _id;
    clearSideData();
    for (var i = 0; i < GridData.Rows.length; i++) {
        bp_brand_name = GridData.Rows[i].bp_brand_name;
        if ($.inArray(bp_brand_name, goodBrandNames) < 0) {
            _id = goodBrandNames.push(bp_brand_name) - 1
            initSideData(_id);
        }
        getSideDataValue(_id, GridData.Rows[i]);
    }
    if (smonth == 'undefined') {
        sideDraw(goodBrandNames, sideGood, sideYearLegendDatas, sideYearLegendBools);
    }
    else {
        sideDraw(goodBrandNames, sideGood, sideMonthLegendDatas, sideMonthLegendBools);
    }

}

//function getBrandManagerData_Good(GridData) {
//    clearSideData();
//    var nb;//当前品牌id
//    var d = 0;//当前品牌下姓名下标
//    for (var i = 0; i < GridData.Rows.length; i++) {
//        bp_brand_name = GridData.Rows[i].bp_brand_name;
//        var _id = $.inArray(bp_brand_name, bp_brand_names);
//        if (_id != nb) {
//            nb = _id;
//            d = i;
//            initSideData(_id);
//        }
//        getSideDataValue(_id, i - d, GridData.Rows[i]);
//    }
//    if (singlecount == 12) {
//        sideDraw(bp_brand_names, sideGood, sideYearLegendDatas, sideYearLegendBools);
//    }
//    else {
//        sideDraw(bp_brand_names, sideGood, sideMonthLegendDatas, sideMonthLegendBools);
//    }

//}

