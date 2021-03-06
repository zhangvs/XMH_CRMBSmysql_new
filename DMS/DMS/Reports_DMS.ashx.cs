﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using XHD.Common;
using System.Web.Security;
using System.Text;
using XHD.Model;
using XHD.BLL;
using XHD.Model;
using System.Web.Script.Serialization;
using System.Data.OleDb;
using System.IO;
using XHD.Common;
using NPOI.SS.UserModel;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;


namespace XHD.DMS.DMS
{
    /// <summary>
    /// Reports_DMS 的摘要说明
    /// </summary>
    public class Reports_DMS : IHttpHandler
    {
        
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            var cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];
            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            string CoockiesID = ticket.UserData;

            BLL.hr_employee emp = new BLL.hr_employee();
            BLL.ecs_brand brand = new BLL.ecs_brand();
            BLL.hr_department dep = new BLL.hr_department();

            dmsService dmsService = new dmsService();

            //月基数
            ecs_month_baseService ecs_month_baseService = new ecs_month_baseService();
            ecs_month_base ecs_month_base = new ecs_month_base();
            //月计划
            ecs_per_planService ecs_per_planService = new ecs_per_planService();
            ecs_per_plan ecs_per_plan = new ecs_per_plan();
            
            //品牌基数计划
            ecs_brand_checkService ecs_brand_checkService = new ecs_brand_checkService();
            ecs_brand_check ecs_brand_check = new ecs_brand_check();

            //品牌提成考核品牌
            ecs_brand_percentageService ecs_brand_percentageService = new ecs_brand_percentageService();
            ecs_brand_percentage ecs_brand_percentage = new ecs_brand_percentage();

            //品牌奖金
            ecs_set_bonusService ecs_set_bonusService = new ecs_set_bonusService();
            ecs_set_bonus ecs_set_bonus = new ecs_set_bonus();

            //工资等级
            ecs_sale_parametersService ecs_sale_parametersService = new ecs_sale_parametersService();
            ecs_sale_parameters ecs_sale_parameters = new ecs_sale_parameters();

            //dms团队奖金
            dms_team_bonusService dms_team_bonusService = new dms_team_bonusService();
            dms_team_bonus dms_team_bonus = new dms_team_bonus();

            //dms个人品牌提成明细表
            dms_brand_percentageService dms_brand_percentageService = new dms_brand_percentageService();
            dms_brand_percentage dms_brand_percentage = new dms_brand_percentage();

            //dms个人月，节点销售情况，完成率
            dms_monthnode_saleService dms_monthnode_saleService = new dms_monthnode_saleService();
            dms_monthnode_sale dms_monthnode_sale = new dms_monthnode_sale();

            //dms个人薪资汇总
            dms_salaryService dms_salaryService = new dms_salaryService();
            dms_salary dms_salary = new dms_salary();

            //个人销售客户数
            dms_customer_saleService dms_customer_saleService = new dms_customer_saleService();
            dms_customer_sale dms_customer_sale = new dms_customer_sale();

            BLL.ecs_brand ecs_brandService = new BLL.ecs_brand();

            int emp_id = int.Parse(CoockiesID);
            DataSet dsemp = emp.GetList("id=" + emp_id);
            string factory_Id = string.Empty;
            string id = string.Empty;
            string uid = string.Empty;
            string emp_code = string.Empty;
            string name = string.Empty;
            string d_id = string.Empty;
            string roletype = string.Empty;
            if (dsemp != null && dsemp.Tables[0].Rows.Count > 0)
            {
                factory_Id = dsemp.Tables[0].Rows[0]["Factory_Id"].ToString();
                id = dsemp.Tables[0].Rows[0]["id"].ToString();
                uid = dsemp.Tables[0].Rows[0]["uid"].ToString();
                emp_code = dsemp.Tables[0].Rows[0]["emp_code"].ToString();
                name = dsemp.Tables[0].Rows[0]["name"].ToString();
                d_id = dsemp.Tables[0].Rows[0]["d_id"].ToString();
                roletype = dsemp.Tables[0].Rows[0]["roletype"].ToString();
            }


            #region 日报
            string sdate = "";
            string startTime = "";
            string endTime = "";

            string strSqlFactory = " and emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
            string returnAuth = DataAuth(emp_id.ToString(), factory_Id);
            if (returnAuth == "")
            {
                context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                return;
            }
            else
            {
                returnAuth += strSqlFactory;
            }

            #region 异常单
            if (request["Action"] == "getDateAbnormal_count")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateAbnormal_count(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "getDateAbnormal_status")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateAbnormal_status(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "getDateAbnormal_reason")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateAbnormal_reason(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "getDateAbnormal")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateAbnormal(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }
            #endregion

            #region 日订单
            if (request["Action"] == "getDateOrder_count")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateOrder_count(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }
            if (request["Action"] == "getDateOrder")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateOrder(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "getDateOrder_city")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateOrder_city(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "getDateOrder_emp")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateOrder_emp(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "getDateOrder_status")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateOrder_status(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }

            if (request["Action"] == "getDateOrder_referer")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateOrder_referer(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }
            if (request["Action"] == "getDateOrder_shipping")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet ds = dmsService.GetDateOrder_shipping(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }
            if (request["Action"] == "getDateOrder_hours")
            {
                sdate = context.Request["sdate"];
                getDateToTimeParser(sdate, out startTime, out endTime);
                DataSet dsHours = dmsService.GetDateOrder_hours(startTime, endTime, returnAuth);
                string dt = Common.GetGridJSON.DataTableToJSON(dsHours.Tables[0]);
                context.Response.Write(dt);
            }
            #endregion

            #endregion

            #region 三图
            #region 获取当天各城市订单量
            if (request["Action"] == "getTodayCityAmt")
            {
                string date = context.Request["date"];//g根据月份判断取第几列，数据库第三列为1月
                if (date == "")
                {
                    date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                }
                DataSet ds = dmsService.GetTodayCityAmt(date);
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }
            #endregion

            #region 获取各城市订单总量
            else if (request["Action"] == "getCityAmt")
            {
                DataSet ds = dmsService.GetCityAmt();
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                context.Response.Write(dt);
            }
            #endregion

            #region 获取当天各城市订单量
            else if (request["Action"] == "GetTodayProvinceAmt")
            {
                string year = "";
                string month = "";

                string date = context.Request["date"];//g根据月份判断取第几列，数据库第三列为1月
                
                if (date == "")
                {
                    date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                    

                }
                year = date.Substring(0, 4);
                month = date.Substring(5, 2);
                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                DataSet ds;
                string dt = "";
                if (dtNow > nextMonth)
                {
                    ds = dmsService.GetTodayProvinceDms(date);
                }
                else
                {
                    ds = dmsService.GetTodayProvinceAmt(date);
                }
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                }
                context.Response.Write(dt);
            }
            #endregion

            #region 月销量订单
            else if (request["Action"] == "getMonthData")
            {
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);
                DataSet ds;
                string dt = "";
                if (dtNow > nextMonth)//当前月份大于查询月份的下个月份，当前为12月5日，如果查询是11月，那么11月的下一个月份就是12月1日，所以，当前时间12月5号大于12月1日，所以就从归档表中直接取出11月的数据
                {
                    ds = dmsService.getMonthOrderCountDms(yearMonth);
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    }
                    else
                    {
                        dmsService.deleteMonthOrderCountDms(yearMonth);
                        dmsService.insertMonthOrderCountDms(yearMonth);
                        ds = dmsService.getMonthOrderCountDms(yearMonth);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                }
                else
                {
                    ds = dmsService.getMonthOrderCountData(yearMonth);
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    }

                }
                context.Response.Write(dt);
            }
            #endregion
            #endregion

            #region 下拉列表

            #region 部门下拉列表
            else if (request["Action"] == "getDep")
            {
                DataSet ecs_brand_percentageDs = dep.GetList("factory_Id='1000' and parentid=1 order by d_order");
                string dt = Common.GetGridJSON.DataTableToJSON(ecs_brand_percentageDs.Tables[0]);
                //8={"Rows":   22=,"Total":"10"}---8固定，22只能是考核品牌Total为两位数字时
                dt = "[{id:'all',text:'全部部门',d_icon:'../images/icon/61.png',children:" + dt.Substring(8, dt.Length - 22).Replace("d_name", "text") + "}]";
                context.Response.Write(dt);
            }
            #endregion

            #region 姓名下拉列表
            else if (request["Action"] == "getDeptPerson")
            {
                BLL.crm_dept_copyauth copy = new BLL.crm_dept_copyauth();
                string serchtxt = "factory_Id='" + factory_Id + "'";
                DataSet dsAll = dep.GetList(0, serchtxt, "d_order");
                if (roletype != "1")
                {
                    serchtxt += " and id=" + int.Parse(d_id);
                }
                DataSet ds = dep.GetList(0, serchtxt, "d_order");
                DataSet dscopy = copy.GetList("factory_Id='" + factory_Id + "'and emp_id=" + emp_id + " and (date(C_valid_Date)>=curdate() or C_valid_Date='1')");
                string parentid = "0";                                         //当登陆者为管理员时可以查看所有部门，parentid=0
                if (roletype != "1")
                {
                    parentid = ds.Tables[0].Rows[0]["parentid"].ToString();   //当登陆者不为管理员时查看自己部门，parentid=当前登陆者
                }

                string returntxt = string.Empty;
                //获取当前登陆者权限
                Data.GetDataAuth dataauth = new Data.GetDataAuth();
                string txt = dataauth.GetDataAuthByid("1", "Sys_view", emp_id.ToString(), factory_Id);
                string[] arr = txt.Split(':');

                if (txt != "all" && txt != "none")
                {
                    switch (arr[0])
                    {
                        case "none": returntxt = " and 1=2 ";
                            break;
                        case "my":
                            returntxt = "emp_id =" + arr[1];
                            break;
                        case "dep":
                            returntxt = "1=1";
                            break;
                        case "depall":
                            returntxt = "1=1";
                            break;
                        case "all":
                            returntxt = "1=1";
                            break;
                    }
                }
                else
                {
                    returntxt = "1=1";
                }

                StringBuilder str = new StringBuilder();
                str.Append("[");
                str.Append(GetTreeStringX(int.Parse(parentid), dsAll.Tables[0], 1, int.Parse(d_id), returntxt));
                string dept_Id = string.Empty;
                string dept_parentid = string.Empty;
                for (int i = 0; i < dscopy.Tables[0].Rows.Count; i++)
                {
                    str.Append(",");
                    dept_Id = dscopy.Tables[0].Rows[i]["dept_Id"].ToString();
                    ds = dep.GetList(0, "factory_Id='" + factory_Id + "'  and id=" + int.Parse(dept_Id), "d_order");
                    dept_parentid = ds.Tables[0].Rows[0]["parentid"].ToString();
                    str.Append(GetTreeStringX(int.Parse(dept_parentid), dsAll.Tables[0], 1, int.Parse(dept_Id), returntxt));

                }
                str.Replace(",", "", str.Length - 1, 1);
                str.Append("]");
                //string str1 = "[{id:34,text:'网络项目技术部',d_icon:'../images/icon/61.png',children:[{id:'p1106',text:'傅建军',d_icon:'images/icon/93.png'},{id:'p1107',text:'王立全',d_icon:'images/icon/93.png'},{id:'p1109',text:'王佃坤',d_icon:'images/icon/93.png'},{id:'p1110',text:'李东升',d_icon:'images/icon/93.png'},{id:'p1111',text:'陈伟',d_icon:'images/icon/38.png'},{id:'p1112',text:'邢荣',d_icon:'images/icon/93.png'},{id:'p1307',text:'唐宏勋',d_icon:'images/icon/93.png'},{id:'p1309',text:'刘伟琳',d_icon:'images/icon/93.png'},{id:'p1310',text:'曹轩',d_icon:'images/icon/93.png'}]},{id:143,text:'财务内勤',d_icon:'../images/icon/88.png'}]";
                context.Response.Write(str);

            }
            #endregion

            #region 考核品牌下拉列表
            else if (request["Action"] == "getCheckBrandTree")
            {
                string brandIdList = getManagerBrandIds(emp_code);//品牌
                string whereSql = "";
                DataSet ds;
                string dt = "";
                string childrenStr = "";
                if (brandIdList != "")
                {
                    whereSql = " brand_id in (" + brandIdList + ")";
                    ds = ecs_brandService.GetList(whereSql);
                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    int you = dt.IndexOf(']');
                    childrenStr = dt.Substring(8, you - 8 + 1).Replace("brand_name", "text").Replace("brand_id", "id");
                }
                else
                {
                    ds = ecs_brand_percentageService.GetDistinctList("");
                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    int you = dt.IndexOf(']');
                    childrenStr = dt.Substring(8, you - 8 + 1).Replace("bp_brand_name", "text").Replace("bp_brand_id", "id");
                }
                //8={"Rows":---8固定
                dt = "[{id:'all',text:'全部品牌',d_icon:'../images/icon/61.png',children:" + childrenStr + "}]";
                context.Response.Write(dt);
            }
            #endregion


            #endregion

            #region 统计

            #region 获取单个人的月业绩明细
            else if (request["Action"] == "getMonthSaleBackData")
            {
                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];

                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                DataSet ds;
                string dt = "";
                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    strSqlOne += " and emp.emp_code =" + emp_code;

                    if (dtNow > nextMonth)//上上个月再从归档表取数
                    {
                        ds = dmsService.GetMonthSaleBackDmsData(strSqlOne, yearMonth, monthColumns);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        ds = dmsService.GetMonthSaleBackData(strSqlOne, yearMonth, monthColumns);

                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }

                    //追加节点字符串
                    string nodeList = getNodeList(year, month);
                    if (nodeList != "")
                    {
                        dt = dt.TrimEnd('}') + nodeList;
                    }

                    context.Response.Write(dt);

                }

            }
            #endregion

            #region 获取单个人的年业绩明细
            else if (request["Action"] == "getYearSaleBackData")
            {
                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                int intYear, nowYear;
                string nowMonth, nowYearMonth;
                getYearCompare(year, out intYear, out nowYear, out nowMonth, out nowYearMonth);

                string dt = "";
                DataSet ds;
                if (!string.IsNullOrEmpty(year))
                {
                    strSqlOne += " and emp.emp_code =" + emp_code;

                    if (nowYear > intYear)//今年之前
                    {
                        ds = dmsService.GetYearSaleBackDmsData(strSqlOne, year);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        //今年，1,先判断今年是否已经写入，没写入执行实时查询，写入
                        //2，如果写入，先删除当前月份，再写入当前月份（11月份之前的不再删除，只重新更新12月份的，此方法只是因为2016年特殊处理）
                        //只删除当前月份
                        dmsService.deleteYearDms("year = " + year + " and datetime =" + nowMonth);
                        //再插入当前月份
                        dmsService.insertYearDms(year, nowYearMonth, emp_code, factory_Id);
                        //再重新查询更新当前月份后的结果
                        ds = dmsService.GetYearSaleBackDmsData(strSqlOne, year);
                        dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    }
                    context.Response.Write(dt);

                }

            }
            #endregion


            #region 获取部门的业绩明细(月报)（分开展示，中心：所有部门ALL，部门经理：部门合计+部门所有人的明细，选择个人：求选择的人的明细）
            else if (request["Action"] == "getMonthSaleBackData_Manager")
            {
                string dt = "";
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);

                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0";

                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);


                string empCodes = "";
                DataSet empCodeDS;
                DataSet ds;
                //姓名栏位为空，取全部门d_pids
                if (idlist == "")
                {
                    string role;
                    string returntxt;
                    DataAuth(emp_id.ToString(), factory_Id, out role, out returntxt);
                    strSqlOne += returntxt;
                    if (role == "all")
                    {
                        if (dtNow > nextMonth)//上上个月再从归档表取数
                        {
                            ds = dmsService.GetMonthAllDepDmsData(strSqlOne, yearMonth, monthColumns);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                            else
                            {
                                dmsService.deleteMonthDms(yearMonth);
                                dmsService.insertMonthDms(yearMonth, emp_code, factory_Id);

                                ds = dmsService.GetMonthAllDepDmsData(strSqlOne, yearMonth, monthColumns);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                        }
                        else
                        {
                            ds = dmsService.GetMonthAllDepData(strSqlOne, yearMonth, monthColumns);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        if (dtNow > nextMonth)//上上个月再从归档表取数
                        {
                            ds = dmsService.GetManagerMonthDepDmsData(strSqlOne, yearMonth, monthColumns);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                            else
                            {
                                dmsService.deleteMonthDms(yearMonth);
                                dmsService.insertMonthDms(yearMonth, emp_code, factory_Id);

                                ds = dmsService.GetManagerMonthDepDmsData(strSqlOne, yearMonth, monthColumns);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                        }
                        else
                        {
                            ds = dmsService.GetManagerMonthDepData(strSqlOne, yearMonth, monthColumns);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }

                    }

                }
                //姓名栏位为个人p1277,选择的客服
                else if (idlist.IndexOf('p') >= 0)
                {
                    BLL.hr_post post = new BLL.hr_post();
                    empCodeDS = post.GetEmpCode("post_id in (" + idlist.Replace(";", ",").Replace("-", "").Replace("p", "") + ")");
                    if (empCodeDS != null && empCodeDS.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < empCodeDS.Tables[0].Rows.Count; i++)
                        {
                            empCodes += "'" + empCodeDS.Tables[0].Rows[i]["emp_code"].ToString() + "',";//取得部门下的所有员工号
                        }
                        empCodes = empCodes.Trim(',');//去掉最后一个逗号
                        if (empCodes == "")
                        {
                            context.Response.Write("{\"Total\":\"0\"}");
                            return;
                        }
                        strSqlOne += " and emp.emp_code in(" + empCodes + ")";

                        if (dtNow > nextMonth)//上上个月再从归档表取数
                        {
                            ds = dmsService.GetManagerMonthDepDmsData(strSqlOne, yearMonth, monthColumns);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                            else
                            {
                                dmsService.deleteMonthDms(yearMonth);
                                dmsService.insertMonthDms(yearMonth, emp_code, factory_Id);

                                ds = dmsService.GetManagerMonthDepDmsData(strSqlOne, yearMonth, monthColumns);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                        }
                        else
                        {
                            ds = dmsService.GetManagerMonthDepData(strSqlOne, yearMonth, monthColumns);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                }
                //追加节点字符串
                string nodeList = getNodeList(year, month);
                if (nodeList != "")
                {
                    dt = dt.TrimEnd('}') + nodeList;
                }

                context.Response.Write(dt);

            }
            #endregion

            #region 获取部门的业绩明细(12个月年报)
            else if (request["Action"] == "getYearSaleBackData_Manager")
            {
                string dt = "";
                string empCodes = "";
                DataSet empCodeDS;
                DataSet ds;

                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);
                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];

                int intYear, nowYear;
                string nowMonth, nowYearMonth;
                getYearCompare(year, out intYear, out nowYear, out nowMonth, out nowYearMonth);
                //姓名栏位为空，取全部门d_pids
                if (idlist == "")
                {
                    //权限
                    string role;
                    string returntxt;
                    DataAuth(emp_id.ToString(), factory_Id, out role, out returntxt);
                    strSqlOne += returntxt;
                    if (role == "all")
                    {
                        if (nowYear > intYear)//今年之前
                        {
                            ds = dmsService.GetYearAllDepDmsData(strSqlOne, year);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            //今年，1,先判断今年是否已经写入，没写入执行实时查询，写入
                            //2，如果写入，先删除当前月份，再写入当前月份（11月份之前的不再删除，只重新更新12月份的，此方法只是因为2016年特殊处理）
                            //只删除当前月份
                            dmsService.deleteYearDms("year = " + year + " and datetime =" + nowMonth);
                            //再插入当前月份
                            dmsService.insertYearDms(year, nowYearMonth, emp_code, factory_Id);
                            //再重新查询更新当前月份后的结果
                            ds = dmsService.GetYearAllDepDmsData(strSqlOne, year);
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        if (nowYear > intYear)//今年之前
                        {
                            ds = dmsService.GetYearDepDmsData(strSqlOne, year);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            //今年，1,先判断今年是否已经写入，没写入执行实时查询，写入
                            //2，如果写入，先删除当前月份，再写入当前月份（11月份之前的不再删除，只重新更新12月份的，此方法只是因为2016年特殊处理）
                            //只删除当前月份
                            dmsService.deleteYearDms("year = " + year + " and datetime =" + nowMonth);
                            //再插入当前月份
                            dmsService.insertYearDms(year, nowYearMonth, emp_code, factory_Id);
                            //再重新查询更新当前月份后的结果
                            ds = dmsService.GetYearDepDmsData(strSqlOne, year);
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }

                    }
                }
                //姓名栏位为个人p1277,选择的客服
                else if (idlist.IndexOf('p') >= 0)
                {
                    BLL.hr_post post = new BLL.hr_post();
                    empCodeDS = post.GetEmpCode("post_id in (" + idlist.Replace(";", ",").Replace("-", "").Replace("p", "") + ")");
                    if (empCodeDS != null && empCodeDS.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < empCodeDS.Tables[0].Rows.Count; i++)
                        {
                            empCodes += "'" + empCodeDS.Tables[0].Rows[i]["emp_code"].ToString() + "',";//取得部门下的所有员工号
                        }
                        empCodes = empCodes.Trim(',');//去掉最后一个逗号
                        if (empCodes == "")
                        {
                            context.Response.Write("{\"Total\":\"0\"}");
                            return;
                        }
                        strSqlOne += " and emp.emp_code in(" + empCodes + ")";

                        if (nowYear > intYear)//今年之前
                        {
                            ds = dmsService.GetYearDepDmsData(strSqlOne, year);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                           ds = dmsService.GetYearDepDmsData(strSqlOne, year);
                           dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                }

                context.Response.Write(dt);

            }
            #endregion

            #endregion

            #region 品管
            #region 负责品牌的统计销售情况（年报）
            else if (request["Action"] == "getBrandManagerData_Year")
            {
                string qtBrand = " where 1=1 ";
                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                int intYear, nowYear;
                string nowMonth, nowYearMonth;
                getYearCompare(year, out intYear, out nowYear, out nowMonth, out nowYearMonth);

                if (!string.IsNullOrEmpty(year))
                {
                    string brandIdList = getManagerBrandIds(emp_code);
                    string returnSqlTxt = "";
                    if (brandIdList == "")
                    {
                        returnSqlTxt = DataAuth(emp_id.ToString(), factory_Id);
                        if (returnSqlTxt == "")
                        {
                            context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                            return;
                        }
                        strSqlOne += returnSqlTxt;
                    }
                    else
                    {
                        returnSqlTxt = DataAuth("7", factory_Id);
                        strSqlOne += returnSqlTxt;
                        qtBrand = " where brand.brand_id in (" + brandIdList + ") ";
                    }
                    DataSet ds;
                    string dt = "";

                    if (nowYear > intYear)//今年之前
                    {
                        if (brandIdList != "")
                        {
                            ds = dmsService.GetAllBrandManagerDms_Year(strSqlOne, year, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetBrandManagerDms_Year(strSqlOne, year, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }

                    }
                    else
                    {
                        if (brandIdList != "")
                        {
                            //今年，1,先判断今年是否已经写入，没写入执行实时查询，写入
                            //2，如果写入，先删除当前月份，再写入当前月份（11月份之前的不再删除，只重新更新12月份的，此方法只是因为2016年特殊处理）
                            ds = dmsService.GetAllBrandManagerDms_Year(strSqlOne, year, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                //只删除当前月份
                                dmsService.deleteBrandDms(intYear.ToString(), nowMonth);
                                //再插入当前月份
                                dmsService.insertBrandDms(nowYearMonth, year, emp_code, factory_Id);
                                //再重新查询更新当前月份后的结果
                                ds = dmsService.GetAllBrandManagerDms_Year(strSqlOne, year, qtBrand);
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            //今年，1,先判断今年是否已经写入，没写入执行实时查询，写入
                            //2，如果写入，先删除当前月份，再写入当前月份（11月份之前的不再删除，只重新更新12月份的，此方法只是因为2016年特殊处理）
                            ds = dmsService.GetBrandManagerDms_Year(strSqlOne, year, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                //只删除当前月份
                                dmsService.deleteBrandDms(intYear.ToString(), nowMonth);
                                //再插入当前月份
                                dmsService.insertBrandDms(nowYearMonth, year, emp_code, factory_Id);
                                //再重新查询更新当前月份后的结果
                                ds = dmsService.GetBrandManagerDms_Year(strSqlOne, year, qtBrand);
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }

                    }

                    context.Response.Write(dt);
                }
                else
                {
                    context.Response.Write("0");
                }


            }
            #endregion

            #region 负责品牌的统计销售情况（月报）
            else if (request["Action"] == "getBrandManagerData")
            {
                string qtBrand = " where 1=1 ";
                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                DataSet ds;
                string dt = "";

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    //品牌销量
                    string brandIdList = getManagerBrandIds(emp_code);
                    string returnSqlTxt = "";
                    if (brandIdList == "")
                    {
                        returnSqlTxt = DataAuth(emp_id.ToString(), factory_Id);
                        if (returnSqlTxt == "")
                        {
                            context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                            return;
                        }
                        strSqlOne += returnSqlTxt;
                    }
                    else
                    {
                        returnSqlTxt = DataAuth("7", factory_Id);
                        strSqlOne += returnSqlTxt;
                        qtBrand = " where brand.brand_id in (" + brandIdList + ") ";
                    }


                    if (dtNow > nextMonth)//上上个月再从归档表取数
                    {
                        if (brandIdList != "")
                        {
                            //month2,用来where语句ordermonth=" + month
                            ds = dmsService.GetAllBrandManagerDms(strSqlOne, year, month2, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetBrandManagerDms(strSqlOne, year, month, month2, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }

                    }
                    else
                    {
                        if (brandIdList != "")
                        {
                            ds = dmsService.GetAllBrandManagerData(strSqlOne, yearMonth, year, month, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetBrandManagerData(strSqlOne, yearMonth, year, month, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }

                    }

                    //追加节点字符串
                    string nodeList = getNodeList(year, month);
                    if (nodeList != "")
                    {
                        dt = dt.TrimEnd('}') + nodeList;
                    }
                    context.Response.Write(dt);
                }
                else
                {
                    context.Response.Write("0");
                }
            }
            #endregion

            #region 负责品牌的客服销售情况
            else if (request["Action"] == "getBrandManagerData_Emp")
            {
                string qtBrand = "";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string brandIdList = context.Request["codeId"];
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                if (!string.IsNullOrEmpty(year))
                {
                    string returnSqlTxt = "";
                    string brandIds = "";
                    getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                    if (returnSqlTxt == "")
                    {
                        context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                        return;
                    }
                    else
                    {
                        strSqlOne += returnSqlTxt;

                    }
                    //品牌经理选择的品牌是否是考核品牌，所有考核的品牌项下是否包含该选择的品牌,考核品牌包括员工的两个参数，基数，计划
                    //int ischeck = brandIds.IndexOf(brandIdList);

                    bool ischeck = false;
                    if (brandIds != "")
                    {
                        //品牌经理选择的品牌是否是考核品牌，所有考核的品牌项下是否包含该选择的品牌,考核品牌包括员工的两个参数，基数，计划
                        DataSet dscheck = ecs_brand_percentageService.GetList("bp_brand_id=" + brandIdList);
                        if (dscheck != null && dscheck.Tables[0].Rows.Count > 0)
                        {
                            ischeck = true;
                            qtBrand = " where brand.bp_brand_id =" + brandIdList;
                        }
                        else
                        {
                            qtBrand = " where brand.brand_id =" + brandIdList;
                        }

                    }
                    else
                    {
                        ischeck = true;
                        qtBrand = " where brand.bp_brand_id =" + brandIdList;
                    }
                    string dt = "";
                    DataSet ds;
                    if (month != "undefined")
                    {
                        DateTime dtNow, nextMonth;
                        string month2, monthColumns, yearMonth;
                        getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)
                        {
                            //上个月再从归档表取数
                            if (!ischeck)
                            {
                                ds = dmsService.GetAllBrandManagerDms_Emp(strSqlOne, year, month2, qtBrand);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                            else
                            {
                                ds = dmsService.GetBrandManagerDms_Emp(strSqlOne, year, month, month2, qtBrand);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                        }
                        else
                        {
                            //本月实时查询
                            if (!ischeck)
                            {
                                ds = dmsService.GetAllBrandManagerData_Emp(strSqlOne, yearMonth, year, qtBrand);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                            else
                            {
                                ds = dmsService.GetBrandManagerData_Emp(strSqlOne, yearMonth, year, month, qtBrand);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }

                        }
                    }
                    else
                    {
                        //详情页年报，直接从归档表里面取值，因为点开年报主页的时候，已经更新过表数据
                        if (!ischeck)
                        {
                            ds = dmsService.GetAllBrandManagerDms_Emp_Year(strSqlOne, year, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetBrandManagerDms_Emp_Year(strSqlOne, year, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }

                    }
                    context.Response.Write(dt);
                }
                else
                {
                    context.Response.Write("0");
                }
            }
            #endregion

            #region 负责品牌的单品销售情况
            else if (request["Action"] == "getBrandManagerData_Good")
            {
                string qtBrand = "";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string brandIdList = context.Request["codeId"];
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                if (!string.IsNullOrEmpty(year))
                {

                    string returnSqlTxt = "";
                    string brandIds = "";
                    getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                    if (returnSqlTxt == "")
                    {
                        context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                        return;
                    }
                    else
                    {
                        strSqlOne += returnSqlTxt;

                    }
                    if (brandIds != "")
                    {
                        qtBrand = " where brand.brand_id =" + brandIdList;
                    }
                    else
                    {
                        qtBrand = " where brand.bp_brand_id =" + brandIdList;
                    }
                    string dt = "";
                    DataSet ds;
                    if (month != "undefined")
                    {
                        DateTime dtNow, nextMonth;
                        string month2, monthColumns, yearMonth;
                        getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)//上个月再从归档表取数
                        {
                            //上月
                            if (brandIds != "")
                            {
                                ds = dmsService.GetAllBrandManagerDms_Good(strSqlOne, year, month2, qtBrand);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                            else
                            {
                                ds = dmsService.GetBrandManagerDms_Good(strSqlOne, year, month2, qtBrand);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }

                        }
                        else
                        {
                            //当前月份实时查询
                            if (brandIds != "")
                            {
                                ds = dmsService.GetAllBrandManagerData_Good(strSqlOne, yearMonth, year, qtBrand);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                            else
                            {
                                ds = dmsService.GetBrandManagerData_Good(strSqlOne, yearMonth,year, qtBrand);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }

                        }
                    }
                    else
                    {
                        //年报
                        if (brandIds != "")
                        {
                            ds = dmsService.GetAllBrandManagerDms_Good_Year(strSqlOne, year, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetBrandManagerDms_Good_Year(strSqlOne, year, qtBrand);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }

                    }
                    context.Response.Write(dt);
                }
                else
                {
                    context.Response.Write("0");
                }
            }
            #endregion

            #endregion

            #region 区域

            #region 关键字查询

            #region 关键字年查询
            else if (request["Action"] == "getYearGoodTxt")
            {
                string year = context.Request["syear"];
                string qtBrand = "";
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                if (brandIdList == "")
                {
                    brandIdList = getManagerBrandIds(emp_code);
                }
                string keyWord = context.Request["keyWord"];

                if (!string.IsNullOrEmpty(year))
                {
                    if (brandIdList != "")
                    {
                        qtBrand = " where bp_brand_id not IN (select bp_brand_id from ecs_brand_percentage where bp_brand_id not in (" + brandIdList.Replace(";", ",") + ") )";
                    }
                    DataSet ds = dmsService.GetMonthGoodTxt(keyWord, year, qtBrand);
                    string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 关键字月查询
            else if (request["Action"] == "getMonthGoodTxt")
            {
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                month = month.Length < 2 ? "0" + month : month;
                string qtBrand = "";
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌

                if (brandIdList == "")
                {
                    brandIdList = getManagerBrandIds(emp_code);
                }
                string keyWord = context.Request["keyWord"];

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    string yearMonth = year + "-" + month;
                    if (brandIdList != "")
                    {
                        qtBrand = " where bp_brand_id not IN (select bp_brand_id from ecs_brand_percentage where bp_brand_id not in (" + brandIdList.Replace(";", ",") + ") )";
                    }
                    DataSet ds = dmsService.GetMonthGoodTxt(keyWord, yearMonth, qtBrand);
                    string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    context.Response.Write(dt);
                }
            }
            #endregion

            #endregion
            
            #region 城市主页

            #region 城市年报主页
            else if (request["Action"] == "getYearCityAmt")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                int intYear, nowYear;
                string nowMonth, nowYearMonth;
                getYearCompare(year, out intYear, out nowYear, out nowMonth, out nowYearMonth);

                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");

                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole( factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);

                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }

                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {
                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);

                    DataSet ds;
                    string dt="";

                    if (nowYear > intYear)//今年之前
                    {
                        ds = dmsService.GetCityAmtDms(strSqlOne, year,"", areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        //今年，1,先判断今年是否已经写入，没写入执行实时查询，写入
                        //2，如果写入，先删除当前月份，再写入当前月份（11月份之前的不再删除，只重新更新12月份的，此方法只是因为2016年特殊处理）
                        ds = dmsService.GetCityAmtDms(strSqlOne, year, "", areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            //只删除当前月份
                            dmsService.deleteOrderDms(nowYear.ToString(),nowMonth);
                            //再插入当前月份
                            dmsService.insertOrderDms(nowYearMonth, emp_code, factory_Id);
                            //再重新查询更新当前月份后的结果
                            ds = dmsService.GetCityAmtDms(strSqlOne, year, "", areaSqlWhere);
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 城市月报主页
            else if (request["Action"] == "getMonthCityAmt")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month,out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }


                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {

                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);

                    DataSet ds;
                    string dt = "";
                    if (dtNow > nextMonth)//当前月份大于查询月份的下个月份，当前为12月5日，如果查询是11月，那么11月的下一个月份就是12月1日，所以，当前时间12月5号大于12月1日，所以就从归档表中直接取出11月的数据
                    {
                        ds = dmsService.GetCityAmtDms(strSqlOne, year,month2, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                        else
                        {
                            dmsService.deleteOrderDms(year, month2);
                            dmsService.insertOrderDms(yearMonth, emp_code, factory_Id);
                            ds = dmsService.GetCityAmtDms(strSqlOne, year,month2, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        ds = dmsService.GetCityAmt(strSqlOne, yearMonth, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }
            }
            #endregion
            

            #endregion

            #region 城市详情
            #region 获取市内年度各月份对比
            else if (request["Action"] == "getCityYear_Months")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string syear = context.Request["syear"];
                string cityId = context.Request["cityId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }

                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(syear))
                {

                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);
                    DataSet ds = dmsService.GetCityYear_MonthsDms(strSqlOne, syear, cityId, areaSqlWhere);
                    string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 获取市内品牌销售占比
            else if (request["Action"] == "getCityMonth_Brand")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];

                string cityId = context.Request["cityId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌

                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }

                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);
                string dt = "";
                DataSet ds;
                if (!string.IsNullOrEmpty(month))
                {
                    //月度
                    DateTime dtNow, nextMonth;
                    string month2, monthColumns, yearMonth;
                    getMonthCompare(year, month,out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                    if (dtNow > nextMonth)//从归档表取数
                    {
                        if (areaSqlWhere != "")
                        {
                            ds = dmsService.GetCityMonth_AllBrandDms(strSqlOne, year, month2, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }

                        }
                        else
                        {
                            ds = dmsService.GetCityMonth_BrandDms(strSqlOne, year,month2, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        //实时查询，当月，不带dms
                        if (areaSqlWhere != "")
                        {
                            ds = dmsService.GetCityMonth_AllBrand(strSqlOne, yearMonth, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetCityMonth_Brand(strSqlOne, yearMonth, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                }
                else
                {
                    //年度，不再判断当前月份，直接从历史表中取值，因为打开主页的时候已经进行清除当前月份，再写入，已经更新过了，所以详情页面不再啰嗦，直接从归档表中取值即可
                    //只判断当前查询条件是否为空，不为空查询所有品牌，为空只查询考核品牌
                    if (areaSqlWhere != "")
                    {
                        ds = dmsService.GetCityMonth_AllBrandDms(strSqlOne, year,"", cityId, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        ds = dmsService.GetCityMonth_BrandDms(strSqlOne, year,"", cityId, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }

                }
                context.Response.Write(dt);
            }
            #endregion

            #region 获取市内单品销售占比
            else if (request["Action"] == "getCityMonth_Good")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string cityId = context.Request["cityId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {

                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);
                    string dt = "";
                    DataSet ds;
                    if (!string.IsNullOrEmpty(month))
                    {
                        DateTime dtNow, nextMonth;
                        string month2, monthColumns, yearMonth;
                        getMonthCompare(year, month,out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)//从归档表取数
                        {
                            ds = dmsService.GetCityMonth_GoodDms(strSqlOne, year, month2, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetCityMonth_Good(strSqlOne, yearMonth, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        ds = dmsService.GetCityMonth_GoodDms(strSqlOne, year,"", cityId, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }


            }
            #endregion

            #region 获取市内客服销售占比
            else if (request["Action"] == "getCityMonth_Emp")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string cityId = context.Request["cityId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {

                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);

                    string dt = "";
                    DataSet ds;
                    if (!string.IsNullOrEmpty(month))
                    {
                        DateTime dtNow, nextMonth;
                        string month2, monthColumns, yearMonth;
                        getMonthCompare(year, month,out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)//从归档表取数
                        {
                            ds = dmsService.GetCityMonth_EmpDms(strSqlOne, year,month2, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetCityMonth_Emp(strSqlOne, yearMonth, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        ds = dmsService.GetCityMonth_EmpDms(strSqlOne, year,"", cityId, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 获取市内客户销售占比
            else if (request["Action"] == "getCityMonth_Customer")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string cityId = context.Request["cityId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {

                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);
                    string dt = "";
                    DataSet ds;
                    if (!string.IsNullOrEmpty(month))
                    {
                        DateTime dtNow, nextMonth;
                        string month2,monthColumns, yearMonth;
                        getMonthCompare(year, month,out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)//从归档表取数
                        {
                            ds = dmsService.GetCityMonth_CustomerDms(strSqlOne, year, month2, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetCityMonth_Customer(strSqlOne, yearMonth, cityId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        ds = dmsService.GetCityMonth_CustomerDms(strSqlOne, year,"", cityId, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }
            }
            #endregion

            #endregion
            

            #region 省份主页
            
            #region 省份年报主页
            else if (request["Action"] == "getYearProvinceAmt")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                int intYear, nowYear;
                string nowMonth, nowYearMonth;
                getYearCompare(year, out intYear, out nowYear, out nowMonth, out nowYearMonth);

                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string brandManagerSqlWhere="";
                if (brandIds!="")
                {
                    brandManagerSqlWhere = " AND brand_id IN (" + brandIds + ")";
                }


                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];


                if (!string.IsNullOrEmpty(year))
                {

                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);

                    DataSet ds;
                    string dt = "";

                    if (nowYear > intYear)//今年之前
                    {
                        ds = dmsService.GetProvinceAmtDms(strSqlOne,year,"", brandManagerSqlWhere, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        //今年，1,先判断今年是否已经写入，没写入执行实时查询，写入
                        //2，如果写入，先删除当前月份，再写入当前月份（11月份之前的不再删除，只重新更新12月份的，此方法只是因为2016年特殊处理）
                        //只删除当前月份
                        dmsService.deleteOrderDms(nowYear.ToString(),nowMonth);
                        //再插入当前月份
                        dmsService.insertOrderDms(nowYearMonth, emp_code, factory_Id);
                        //再重新查询更新当前月份后的结果
                        ds = dmsService.GetProvinceAmtDms(strSqlOne, year, "", brandManagerSqlWhere, areaSqlWhere);
                        dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    }
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 省份月报主页
            else if (request["Action"] == "getMonthProvinceAmt")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                DateTime dtNow, nextMonth;
                string month2,monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌 
                brandIdList = brandIdList.Replace(";", ",");

                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string brandManagerSqlWhere = "";
                if (brandIds != "")
                {
                    brandManagerSqlWhere = " AND brand_id IN (" + brandIds + ")";
                }
                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];


                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {

                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);

                    DataSet ds;
                    string dt = "";
                    if (dtNow > nextMonth)//当前月份大于查询月份的下个月份，当前为12月5日，如果查询是11月，那么11月的下一个月份就是12月1日，所以，当前时间12月5号大于12月1日，所以就从归档表中直接取出11月的数据
                    {
                        ds = dmsService.GetProvinceAmtDms(strSqlOne, year, month2, brandManagerSqlWhere, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                        else
                        {
                            dmsService.deleteOrderDms(year, month2);
                            dmsService.insertOrderDms(yearMonth, emp_code, factory_Id);
                            ds = dmsService.GetProvinceAmtDms(strSqlOne, year, month2, brandManagerSqlWhere, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        ds = dmsService.GetProvinceAmt(strSqlOne, yearMonth, brandManagerSqlWhere, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }

                    }
                    context.Response.Write(dt);
                }
            }
            #endregion
            #endregion
            
            #region 省份详情
            #region 省内年度各月份销售占比
            else if (request["Action"] == "getProvinceYear_Months")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];

                string provinceId = context.Request["provinceId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {

                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);

                    DataSet ds = dmsService.GetProvinceYear_MonthsDms(strSqlOne, year, provinceId, areaSqlWhere);
                    string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 省内月度品牌销售占比
            else if (request["Action"] == "getProvinceMonth_Brand")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string provinceId = context.Request["provinceId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {
                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);

                    string dt = "";
                    DataSet ds;
                    if (!string.IsNullOrEmpty(month))
                    {
                        DateTime dtNow, nextMonth;
                        string month2, monthColumns, yearMonth;
                        getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)//从归档表取数
                        {
                            
                            if (areaSqlWhere != "")
                            {
                                ds = dmsService.GetProvinceMonth_AllBrandDms(strSqlOne,  year,month2, provinceId, areaSqlWhere);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                            else
                            {
                                ds = dmsService.GetProvinceMonth_BrandDms(strSqlOne, year,month2, provinceId, areaSqlWhere);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                        }
                        else
                        {

                            if (areaSqlWhere != "")
                            {
                                ds = dmsService.GetProvinceMonth_AllBrand(strSqlOne, yearMonth, provinceId, areaSqlWhere);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                            else
                            {
                                ds = dmsService.GetProvinceMonth_Brand(strSqlOne, yearMonth, provinceId, areaSqlWhere);
                                if (ds != null && ds.Tables[0].Rows.Count > 0)
                                {
                                    dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (areaSqlWhere != "")
                        {
                            ds = dmsService.GetProvinceMonth_AllBrandDms(strSqlOne, year, "", provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetProvinceMonth_BrandDms(strSqlOne, year,"", provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }

                    }
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 省内月度单品销售占比
            else if (request["Action"] == "getProvinceMonth_Good")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string provinceId = context.Request["provinceId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {
                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);
                    string dt = "";
                    DataSet ds;
                    if (!string.IsNullOrEmpty(month))
                    {
                        DateTime dtNow, nextMonth;
                        string month2, monthColumns, yearMonth;
                        getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)//从归档表取数
                        {
                            ds = dmsService.GetProvinceMonth_GoodDms(strSqlOne, year, month2, provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetProvinceMonth_Good(strSqlOne, yearMonth, provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        ds = dmsService.GetProvinceMonth_GoodDms(strSqlOne, year,"", provinceId, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 省内月度城市销售占比
            else if (request["Action"] == "getProvinceMonth_City")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string provinceId = context.Request["provinceId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {
                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);
                    string dt = "";
                    DataSet ds;
                    if (!string.IsNullOrEmpty(month))
                    {
                        DateTime dtNow, nextMonth;
                        string month2, monthColumns, yearMonth;
                        getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)//从归档表取数
                        {
                            ds = dmsService.GetProvinceMonth_CityDms(strSqlOne, year, month2, provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetProvinceMonth_City(strSqlOne, yearMonth, provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        ds = dmsService.GetProvinceMonth_CityDms(strSqlOne, year,"", provinceId, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 省内月度客服销售占比
            else if (request["Action"] == "getProvinceMonth_Emp")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string provinceId = context.Request["provinceId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }

                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {
                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);
                    string dt = "";
                    DataSet ds;
                    if (!string.IsNullOrEmpty(month))
                    {
                        DateTime dtNow, nextMonth;
                        string month2, monthColumns, yearMonth;
                        getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)//从归档表取数
                        {
                            ds = dmsService.GetProvinceMonth_EmpDms(strSqlOne, year, month2, provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetProvinceMonth_Emp(strSqlOne, yearMonth, provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        ds = dmsService.GetProvinceMonth_EmpDms(strSqlOne, year,"", provinceId, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }
            }
            #endregion

            #region 省内月度客户销售占比
            else if (request["Action"] == "getProvinceMonth_Customer")
            {
                string strSqlOne = " emp.factory_id='" + factory_Id + "' and emp.isdelete=0";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string provinceId = context.Request["provinceId"];
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                brandIdList = brandIdList.Replace(";", ",");
                string returnSqlTxt = "";
                string brandIds = "";
                getBrandManagerRole(factory_Id, emp_code, emp_id, out returnSqlTxt, out brandIds);
                if (returnSqlTxt == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                else
                {
                    strSqlOne += returnSqlTxt;
                }
                string goodId = context.Request["goodId"];
                string goodTextBox = context.Request["goodTextBox"];

                if (!string.IsNullOrEmpty(year))
                {
                    string areaSqlWhere = getAreaSqlWhere(brandIdList, brandIds, goodId, goodTextBox);

                    string dt = "";
                    DataSet ds;
                    if (!string.IsNullOrEmpty(month))
                    {
                        DateTime dtNow, nextMonth;
                        string month2, monthColumns, yearMonth;
                        getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                        if (dtNow > nextMonth)//从归档表取数
                        {
                            ds = dmsService.GetProvinceMonth_CustomerDms(strSqlOne, year, month2, provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                        else
                        {
                            ds = dmsService.GetProvinceMonth_Customer(strSqlOne, yearMonth, provinceId, areaSqlWhere);
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                            }
                        }
                    }
                    else
                    {
                        ds = dmsService.GetProvinceMonth_CustomerDms(strSqlOne, year,"", provinceId, areaSqlWhere);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }
            }
            #endregion
            #endregion 

            
            #endregion

            #region 客户
            #region 客户主页
            

            #region 个人客户年报
            else if (request["Action"] == "getCustomerYearSaleBackData")
            {

                string year = context.Request["syear"];
                int intYear, nowYear;
                string nowMonth, nowYearMonth;
                getYearCompare(year, out intYear, out nowYear, out nowMonth, out nowYearMonth);

                string admin_user_name = context.Request["admin_user_name"];
                if (admin_user_name == "null")
                {
                    admin_user_name= emp_code;
                }
                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0 ";
                if (!string.IsNullOrEmpty(year))
                {
                    DataSet ds;
                    string dt = "";

                    if (nowYear > intYear)//今年之前
                    {
                        ds = dmsService.GetCustomerYearSaleBackDms(admin_user_name, year);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        //员工客户每天销售额,删除当前月份
                        dmsService.deleteCustomerDms(nowYear.ToString(),nowMonth);
                        dmsService.insertCustomerDms(nowYearMonth,strSqlOne, emp_code, factory_Id);
                        ////客户每个月拿货次数,删除当前月份
                        dmsService.deleteCustomerMonthCountDms(nowYear.ToString(), nowMonth);
                        dmsService.insertCustomerMonthCountDms(nowYearMonth, emp_code, factory_Id);

                        ds = dmsService.GetCustomerYearSaleBackDms(admin_user_name, year);
                        dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);

                    }

                    context.Response.Write(dt);
                }

            }
            #endregion

            #region 个人客户月报
            else if (request["Action"] == "getCustomerMonthSaleBackData")
            {
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                string admin_user_name = context.Request["admin_user_name"];
                if (admin_user_name == "null")
                {
                    admin_user_name = emp_code;
                }
                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0  and emp.emp_code =" + admin_user_name;

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    DataSet ds;
                    string dt = "";
                    if (dtNow > nextMonth)//当前月份大于查询月份的下个月份，当前为12月5日，如果查询是11月，那么11月的下一个月份就是12月1日，所以，当前时间12月5号大于12月1日，所以就从归档表中直接取出11月的数据
                    {
                        ds = dmsService.GetCustomerMonthSaleBackDms(admin_user_name, year, month2);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        //客户销量
                        ds = dmsService.GetCustomerMonthSaleBackData(strSqlOne, yearMonth);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }
                

            }
            #endregion

            #region 部门客户年报
            else if (request["Action"] == "getCustomerYearSaleBackData_Manager")
            {
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);
                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0";

                string year = context.Request["syear"];
                int intYear, nowYear;
                string nowMonth, nowYearMonth;
                getYearCompare(year, out intYear, out nowYear, out nowMonth, out nowYearMonth);

                //姓名栏位为空，取全部门d_pids
                string empCodes = getEmpCodes(idlist, emp_id, factory_Id);
                if (empCodes == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                DataSet ds;
                string dt = "";
                if (!string.IsNullOrEmpty(year))
                {

                    if (nowYear > intYear)//今年之前
                    {
                        ds = dmsService.GetCustomerYearManagerDepDms(empCodes, year);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);

                        }
                    }
                    else
                    {
                        //员工客户每天销售额,删除当前月份
                        dmsService.deleteCustomerDms(nowYear.ToString(),nowMonth);
                        dmsService.insertCustomerDms(nowYearMonth, strSqlOne, emp_code, factory_Id);
                        ////客户每个月拿货次数,删除当前月份
                        dmsService.deleteEmpMonthCountDms(nowYear.ToString(),nowMonth);
                        dmsService.insertEmpMonthCountDms(nowYearMonth, emp_code, factory_Id);

                        ds = dmsService.GetCustomerYearManagerDepDms(empCodes, year);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);

                        }
                    }
                }

                context.Response.Write(dt);

            }
            #endregion

            #region 部门客户月报
            else if (request["Action"] == "getCustomerMonthSaleBackData_Manager")
            {
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);

                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0";

                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                string empCodes = getEmpCodes(idlist, emp_id, factory_Id);
                if (empCodes == "")
                {
                    context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                    return;
                }
                strSqlOne += " and emp.emp_code in(" + empCodes + ")";

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    DataSet ds;
                    string dt = "";
                    if (dtNow > nextMonth)//当前月份大于查询月份的下个月份，当前为12月5日，如果查询是11月，那么11月的下一个月份就是12月1日，所以，当前时间12月5号大于12月1日，所以就从归档表中直接取出11月的数据
                    {
                        ds = dmsService.GetCustomerMonthManagerDepDms(empCodes, year, month2);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        ds = dmsService.GetCustomerMonthManagerDepData(strSqlOne, yearMonth);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }


                

            }
            #endregion


            #endregion
            #region 客户详情页
            
            #endregion

            #region 客户品牌月报
            else if (request["Action"] == "getCustomerMonthBrandSaleBackData")
            {
                string strSqlOne = "1=1";
                string userId = context.Request["user_id"];//客户id
                if (userId != "")
                {
                    strSqlOne += " and user_id =" + userId;
                }
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    DataSet ds;
                    string dt = "";
                    if (dtNow > nextMonth)//当前月份大于查询月份的下个月份，当前为12月5日，如果查询是11月，那么11月的下一个月份就是12月1日，所以，当前时间12月5号大于12月1日，所以就从归档表中直接取出11月的数据
                    {
                        ds = dmsService.GetCustomerMonthBrandDms(strSqlOne, year, month2);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    else
                    {
                        ds = dmsService.GetCustomerMonthBrandData(strSqlOne, yearMonth);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                        }
                    }
                    context.Response.Write(dt);
                }


            }
            #endregion

            #region 客户品牌下单品月报
            else if (request["Action"] == "getCustomerMonthBrandGoodsSaleBackData")
            {
                string strSqlOne = "1=1";
                string userId = context.Request["user_id"];//客户id
                if (userId != "")
                {
                    strSqlOne += " and user_id =" + userId;
                }
                string brand_id = context.Request["brand_id"];//品牌id
                if (brand_id != "")
                {
                    strSqlOne += " and brand_id =" + brand_id;
                }

                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                DateTime dtNow, nextMonth;
                string month2, monthColumns, yearMonth;
                getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    DataSet ds;
                    string dt = "";
                    if (dtNow > nextMonth)
                    {
                        //客户品牌销量
                        ds = dmsService.GetCustomerMonthBrandGoodsDms(strSqlOne, year, month2);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);

                        }
                    }
                    else
                    {
                        //客户品牌销量
                        ds = dmsService.GetCustomerMonthBrandGoodsData(strSqlOne, yearMonth);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);

                        }
                    }

                    context.Response.Write(dt);
                }

            }
            #endregion


            #region 客户品牌年报
            else if (request["Action"] == "getCustomerYearBrandSaleBackData")
            {
                string strSqlOne = " 1=1  ";
                string userId = context.Request["user_id"];//客户id
                if (userId != "")
                {
                    strSqlOne += " and user_id =" + userId;
                }
                string year = context.Request["syear"];
                int intYear, nowYear;
                string nowMonth, nowYearMonth;
                getYearCompare(year, out intYear, out nowYear, out nowMonth, out nowYearMonth);
                DataSet ds;
                string dt = "";
                if (!string.IsNullOrEmpty(year))
                {
                    if (nowYear > intYear)
                    {
                        //客户品牌销量
                        ds = dmsService.GetCustomerYearBrandGoodsDms(strSqlOne, year);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);

                        }
                    }
                    else
                    {
                        //只删除当前月份
                        dmsService.deleteBrandDms(intYear.ToString(), nowMonth);
                        //再插入当前月份
                        dmsService.insertBrandDms(nowYearMonth,year, emp_code, factory_Id);
                        //客户品牌销量
                        ds = dmsService.GetCustomerYearBrandGoodsDms(strSqlOne, year);
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);

                        }
                    }

                    context.Response.Write(dt);
                }

            }
            #endregion

            #region 客户品牌下单品各月报（分天）
            else if (request["Action"] == "getCustomerYearGood")
            {
                string strSqlOne = " 1=1 ";
                string userId = context.Request["user_id"];//客户id
                if (userId != "")
                {
                    strSqlOne += " and user_id =" + userId;
                }
                string goods_id = context.Request["goods_id"];//客户id
                if (goods_id != "")
                {
                    strSqlOne += " and goods_id =" + goods_id;
                }

                string year = context.Request["syear"];

                if (!string.IsNullOrEmpty(year))
                {
                    //客户品牌销量
                    DataSet ds = dmsService.GetCustomerYearGoodDms(strSqlOne, year);
                    string dt = "";
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                    }
                    context.Response.Write(dt);
                }

            }
            #endregion




            #endregion

            #region 薪资
            #region 获取个人薪资，品牌提成部分
            else if (request["Action"] == "getBrandPercentageData")
            {
                string dt = "";
                string sorttext = " bc_user_name,percentage_brand desc ";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    string a_ = "a_" + month;
                    string b_ = "b_" + month;

                    DateTime dtNow, nextMonth;
                    string month2, monthColumns, yearMonth;
                    getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                    string empCodesAll = getDeps(factory_Id);
                    string strSqlOne = " where emp.factory_id='" + factory_Id + "' and emp.isdelete=0  ";

                    if (dtNow > nextMonth || month == "1")
                    {
                        //先取dms表内数据，如果没有再去执行复杂sql
                        DataSet ds_dms_brand_percentage = dms_brand_percentageService.GetList(" year=" + year + " and month=" + month2 + " and bc_user_name =" + emp_code);
                        //有一个人的提成也算有，结果真一个人的话，就不对了
                        if (ds_dms_brand_percentage != null && ds_dms_brand_percentage.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds_dms_brand_percentage.Tables[0]);
                        }
                        else
                        {
                            dt = "{\"Total\":\"0\"}";
                        }
                    }
                    else
                    {
                        //当前月份和上个月份，先删除掉，再重新插入
                        dms_brand_percentageService.DeleteBySql(" year=" + year + " and month=" + month2 + " and bc_user_name in(" + emp_code + ")");

                        //如果大于当前月份,因为当下月份数字在不断变化，数据不固定,只能实时查询，执行复杂sql
                        DataSet ds_brandPercentage = dmsService.GetBrandPercentageData(a_, b_, strSqlOne, emp_code, year, month2, yearMonth, sorttext);

                        //AddBrandPercentage(ds_brandPercentage, year, month);
                        DataSet ds_dms_brand_percentage = dms_brand_percentageService.GetListOrderByPercentage(" year=" + year + " and month=" + month2 + " and bc_user_name in(" + emp_code + ")");

                        if (ds_dms_brand_percentage != null && ds_dms_brand_percentage.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds_dms_brand_percentage.Tables[0]);
                        }

                    }
                }

                context.Response.Write(dt);

            }


            #endregion

            #region 获取部门薪资，品牌提成部分
            else if (request["Action"] == "getBrandPercentageData_Manager")
            {
                string dt = "";
                DataSet ds_dms_brand_percentage;//提成明细表

                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);
                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    string empCodes = getEmpCodes(idlist, emp_id, factory_Id);
                    if (empCodes == "")
                    {
                        context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                        return;
                    }

                    string empCodesAll = getDeps(factory_Id);
                    string sorttext = " bc_user_name desc,percentage_brand desc ";
                    string strSqlOne = " where emp.factory_id='" + factory_Id + "' and emp.isdelete=0  ";
                    string a_ = "a_" + month;
                    string b_ = "b_" + month;

                    DateTime dtNow, nextMonth;
                    string month2, monthColumns, yearMonth;
                    getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                    if (dtNow > nextMonth || month == "1")//上上个月再从归档表取数
                    {
                        //先取dms表内数据，如果没有再去执行复杂sql，本部门数据
                        ds_dms_brand_percentage = dms_brand_percentageService.GetListOrderByPercentage(" year=" + year + " and month=" + month2 + " and bc_user_name in(" + empCodes + ")");
                        if (ds_dms_brand_percentage != null && ds_dms_brand_percentage.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds_dms_brand_percentage.Tables[0]);
                        }
                        else
                        {
                            //清理之后，没有提成数据，重新写入
                            //1.清理提成表当前月份所有数据
                            dms_brand_percentageService.DeleteBySql(" year=" + year + " and month=" + month2);
                            //2.清理品牌dms表当前月份所有数据
                            dmsService.deleteBrandDms(year, month2);
                            //3.重新插入品牌dms表数据
                            dmsService.insertBrandDms(yearMonth, year, emp_code, factory_Id);
                            //4.关联品牌dms表，重新写入到提成表
                            DataSet ds_brandPercentage = dmsService.GetBrandPercentageDms(a_, b_, strSqlOne, empCodesAll, year, month2, yearMonth, sorttext);
                            //AddBrandPercentage(ds_brandPercentage, year, month);
                            ds_dms_brand_percentage = dms_brand_percentageService.GetListOrderByPercentage(" year=" + year + " and month=" + month2 + " and bc_user_name in(" + empCodes + ")");
                            if (ds_dms_brand_percentage != null && ds_dms_brand_percentage.Tables[0].Rows.Count > 0)
                            {
                                dt = Common.GetGridJSON.DataTableToJSON(ds_dms_brand_percentage.Tables[0]);
                            }
                            else
                            {
                                dt = "{\"Total\":\"0\"}";
                            }
                        }
                    }
                    else
                    {
                        //当前月份和上个月份，先删除掉，再重新插入
                        dms_brand_percentageService.DeleteBySql(" year=" + year + " and month=" + month2);

                        //如果大于当前月份,因为当下月份数字在不断变化，数据不固定,只能实时查询，执行复杂sql
                        DataSet ds_brandPercentage = dmsService.GetBrandPercentageData(a_, b_, strSqlOne, empCodesAll, year, month2, yearMonth, sorttext);
                        //AddBrandPercentage(ds_brandPercentage, year, month);

                        ds_dms_brand_percentage = dms_brand_percentageService.GetListOrderByPercentage(" year=" + year + " and month=" + month2 + " and bc_user_name in(" + empCodes + ")");
                        if (ds_dms_brand_percentage != null && ds_dms_brand_percentage.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds_dms_brand_percentage.Tables[0]);
                        }
                        else
                        {
                            dt = "{\"Total\":\"0\"}";
                        }
                    }
                    context.Response.Write(dt);

                }

            }

            #endregion


            #region 获取个人薪资统计
            else if (request["Action"] == "getSalaryData")
            {
                string dt = "";
                string year = context.Request["syear"];
                string month = context.Request["smonth"];

                string a_ = "a_" + month;
                string b_ = "b_" + month;
                string strSqlOne = " where emp.factory_id='" + factory_Id + "' and emp.isdelete=0  ";

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {

                    DateTime dtNow, nextMonth;
                    string month2, monthColumns, yearMonth;
                    getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);
                    #region 上上月数据
                    if (dtNow > nextMonth || month == "1")
                    {
                        DataSet ds_dms_salary = dms_salaryService.GetList(" year=" + year + " and month=" + month2 + " and admin_user_name =" + emp_code);
                        if (ds_dms_salary != null && ds_dms_salary.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds_dms_salary.Tables[0]);//历史汇总表
                        }
                        else
                        {
                            dt = "{\"Total\":\"0\"}";
                        }
                    }
                    #endregion

                    #region 本月或者上月数据
                    else
                    {

                        dt = salaryLiu(factory_Id, year,month, month2,yearMonth, name, emp_code);
                    }
                    #endregion
                }
                context.Response.Write(dt);
            }
            #endregion

            #region 获取部门薪资统计
            else if (request["Action"] == "getSalaryData_Manager")
            {
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    DateTime dtNow, nextMonth;
                    string month2, monthColumns, yearMonth;
                    getMonthCompare(year, month, out month2, out dtNow, out nextMonth, out monthColumns, out yearMonth);

                    string empCodes = getEmpCodes(idlist, emp_id, factory_Id);
                    if (empCodes == "")
                    {
                        context.Response.Write("{\"empCodes\":\"empCodes:0\"}");
                        return;
                    }
                    string dt = "";


                    //上上个月再从归档表里面取数据
                    if (dtNow > nextMonth || month=="1")
                    {
                        //直接从历史汇总表内取值
                        DataSet ds_dms_salary = dms_salaryService.GetList(" year=" + year + " and month=" + month2 + " and admin_user_name in(" + empCodes + ")");
                        if (ds_dms_salary != null && ds_dms_salary.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds_dms_salary.Tables[0]);//历史汇总表
                        }
                        else
                        {
                            dt = salaryLiu(factory_Id, year,month, month2,yearMonth, name, empCodes);
                        }
                    }
                    else
                    {
                        dt = salaryLiu(factory_Id, year, month, month2, yearMonth, name, empCodes);

                    }
                    context.Response.Write(dt);

                }

            }

            #endregion


            #region 获取部门奖励表数据，用于展示光荣榜
            else if (request["Action"] == "getTeamData_Manager")
            {
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string monthnode = month + ',' + month + "01," + month + "02," + month + "03," + month + "04";
                string dt = "";
                string d_ids = DataAuth(emp_id.ToString(), factory_Id);
                d_ids = d_ids.Replace("emp.d_id", "d_pid");

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    DataSet ds_dms_team_bonus;//团队薪资
                    //直接从历史汇总表内取值and d_pid=" + d_id
                    ds_dms_team_bonus = dms_team_bonusService.GetList(" year=" + year + " and monthnode in (" + monthnode + ")  and (team_bonus <>0 or team_champion <>0) " + d_ids);

                    if (ds_dms_team_bonus != null && ds_dms_team_bonus.Tables[0].Rows.Count > 0)
                    {
                        dt = Common.GetGridJSON.DataTableToJSON(ds_dms_team_bonus.Tables[0]);//历史汇总表
                    }
                }
                context.Response.Write(dt);
            }
            #endregion

            #region 获取部门奖励合计
            else if (request["Action"] == "team_carvebonus")
            {
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                month = month.Length < 2 ? "0" + month : month;
                string monthnode = month + ',' + month + "01," + month + "02," + month + "03," + month + "04";
                string dt = "";

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    //考勤数据导入之后不允许再分配团队奖
                    DataSet dsImport = dms_salaryService.GetListImportAttendance(year, month);
                    if (dsImport != null && dsImport.Tables[0].Rows.Count > 0)
                    {
                        dt = "{\"state\":\"1\"}";
                    }
                    else
                    {
                        //DateTime dtNow = DateTime.Now;
                        //if (int.Parse(month) <= dtNow.Month)
                        //{
                            //合计团队奖励
                            DataSet ds_dms_team_bonus = dms_team_bonusService.Sum_Champion_Bonus(" year=" + year + " and monthnode in (" + monthnode + ")  and (team_bonus <>0 or team_champion <>0) and d_pid=" + d_id);
                            if (ds_dms_team_bonus.Tables[0].Rows[0][0].ToString() != "")
                            {
                                dt = "{\"team_bonus\":" + ds_dms_team_bonus.Tables[0].Rows[0][0].ToString() + "}";
                                //已分配团队奖
                                DataSet ds_AssignedTeamBonus = dms_salaryService.GetListAssignedTeamBonus(year, month, d_id);
                                if (ds_AssignedTeamBonus.Tables[0].Rows[0][0].ToString() != "")
                                {
                                    dt = dt.TrimEnd('}') + ",\"yfp_team_bonus\":" + ds_AssignedTeamBonus.Tables[0].Rows[0][0].ToString() + "}";
                                }
                                else
                                {
                                    dt = dt.TrimEnd('}') + ",\"yfp_team_bonus\":0}";
                                }
                            }
                            else
                            {
                                dt = "{\"Total\":\"0\"}";
                            }

                        //}
                    }

                }
                context.Response.Write(dt);
            }
            #endregion

            #region 获取部门人员，分配团队奖的内部人员
            else if (request["Action"] == "team_emps")
            {
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                month = month.Length < 2 ? "0" + month : month;
                string dt = "";
                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    DataSet ds_dms_salary;//个人薪资
                    //获取当前时间的月份，如果小于当前月份，直接从历史汇总表内取值。如果大于当前月份，不操作
                    //DateTime dtNow = DateTime.Now;
                    //if (int.Parse(month) <= dtNow.Month)
                    //{
                        //直接从历史汇总表内取值
                        ds_dms_salary = dms_salaryService.GetList(" year=" + year + " and month=" + month + " and d_pid =" + d_id);
                        if (ds_dms_salary != null && ds_dms_salary.Tables[0].Rows.Count > 0)
                        {
                            dt = Common.GetGridJSON.DataTableToJSON(ds_dms_salary.Tables[0]);//历史汇总表
                        }
                        else
                        {

                        }
                    //}
                }
                context.Response.Write(dt);
            }
            #endregion


            #region 分配团队奖
            else if (request["Action"] == "updateSalary")
            {
                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                month = month.Length < 2 ? "0" + month : month;

                string[] team_carve_bonuss = request.Params.GetValues("T_team_carve_bonus");//团队分配奖励
                string[] good_bonuss = request.Params.GetValues("T_good_bonus");//单品奖励
                string[] phone_bonuss = request.Params.GetValues("T_phone_bonus");//电话量奖励
                string[] point_bonuss = request.Params.GetValues("T_point_bonus");//积分奖励

                if (!string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(month))
                {
                    DataSet ds_dms_salary;//个人薪资
                    //获取当前时间的月份，如果小于当前月份，直接从历史汇总表内取值。如果大于当前月份，不操作
                    //DateTime dtNow = DateTime.Now;
                    //if (int.Parse(month) <= dtNow.Month)
                    //{
                        //直接从历史汇总表内取值
                        ds_dms_salary = dms_salaryService.GetList(" year=" + year + " and month=" + month + " and d_pid =" + d_id);
                        if (ds_dms_salary != null && ds_dms_salary.Tables[0].Rows.Count > 0)
                        {
                            for (int i = 0; i < ds_dms_salary.Tables[0].Rows.Count; i++)
                            {
                                decimal team_carve_bonus = Convert.ToDecimal(team_carve_bonuss[i]);
                                decimal good_bonus = Convert.ToDecimal(good_bonuss[i]);
                                decimal phone_bonus = Convert.ToDecimal(phone_bonuss[i]);
                                decimal point_bonus = Convert.ToDecimal(point_bonuss[i]);
                                int sid = Convert.ToInt32(ds_dms_salary.Tables[0].Rows[i]["id"]);
                                bool updateTeamBonusOrNot = dms_salaryService.UpdateTeamBonus(team_carve_bonus, good_bonus, phone_bonus, point_bonus, name, sid);
                                if (!updateTeamBonusOrNot)
                                {
                                    context.Response.Write("update:failure,更新团队奖励失败！" + ds_dms_salary.Tables[0].Rows[i]["name"]);
                                    return;
                                }
                                //bool updateSumOrNot = dms_salaryService.Update_Salary_Sum(sid);
                                //if (!updateSumOrNot)
                                //{
                                //    context.Response.Write("update:failure,更新工资合计失败！" + ds_dms_salary.Tables[0].Rows[i]["name"]);
                                //    return;
                                //}

                            }
                        }
                        else
                        {

                        }
                    //}
                }
                context.Response.Write("update:success");


            }
            #endregion

            #region 保存文件 出勤和工龄数据.xlsx
            else if (request["Action"] == "excel_upload")
            {
                if (emp_code != "1010" && emp_code != "5001" && emp_code != "5007" )
                {
                    context.Response.Write("Unauthorized");
                }
                else
                {
                    string year = context.Request["syear"];
                    string month = context.Request["smonth"];
                    DataSet dsUndistributed = dms_salaryService.GetListTeamBonusUndistributed(year, month);
                    if (dsUndistributed != null && dsUndistributed.Tables[0].Rows.Count > 0)
                    {
                        string d_pnames = "";
                        for (int i = 0; i < dsUndistributed.Tables[0].Rows.Count; i++)
                        {
                            d_pnames += dsUndistributed.Tables[0].Rows[i][0].ToString() + ",";
                        }
                        d_pnames = d_pnames.TrimEnd(',');
                        context.Response.Write("还有团队奖未分配:</br>" + d_pnames);
                    }
                    else
                    {
                        string fileName = request["filename"];    //文件路径
                        //360浏览器，ie ，chrome存在C:\\fakepath\\7月份出勤和工龄数据.xlsx
                        if (fileName.LastIndexOf("\\") > 0)
                        {
                            int xx = fileName.LastIndexOf("\\") + 1;
                            fileName = fileName.Substring(xx, fileName.Length - xx);
                        }
                        if (request.Files.Count > 0)
                        {
                            HttpPostedFile uploadFile = request.Files[0];
                            string filepath = @"~/file/" + fileName.Replace("=", "");
                            uploadFile.SaveAs(context.Server.MapPath(filepath));
                            FileInfo file = new FileInfo(context.Server.MapPath(filepath));
                            if (!file.Exists)
                            {
                                context.Response.Write("false");
                            }
                            else
                            {
                                context.Response.Write(context.Server.MapPath(filepath));
                            }
                        }
                    }
                }

            }
            #endregion

            #region 导入考勤工龄
            else if (request["Action"] == "input_AbsenceDays_SeniorityBonus")
            {
                string empCode;
                decimal absence_days;
                decimal leave_days;
                decimal seniority_bonus;
                decimal meals_deductions;
                decimal social_deductions;
                decimal late_deductions;
                decimal shipping_deductions;
                decimal other_deductions;

                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string filepath = request["file"];
                if (!string.IsNullOrEmpty(filepath))
                {
                    DataTable dtb = ExcelToDataTable(filepath);
                    if (dtb != null && dtb.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtb.Rows.Count; i++)
                        {
                            empCode = dtb.Rows[i][0].ToString();
                            absence_days = dtb.Rows[i][2].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][2].ToString());//缺勤天数
                            leave_days = dtb.Rows[i][3].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][3].ToString());//工作日请假天数
                            seniority_bonus = dtb.Rows[i][4].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][4].ToString());//工龄工资
                            meals_deductions = dtb.Rows[i][5].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][5].ToString());//餐费扣款
                            social_deductions = dtb.Rows[i][6].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][6].ToString());//社保扣款
                            late_deductions = dtb.Rows[i][7].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][7].ToString());//迟到扣款
                            shipping_deductions = dtb.Rows[i][8].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][8].ToString());//退货运费扣款
                            other_deductions = dtb.Rows[i][9].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][9].ToString());//其他扣款
                            dms_salaryService.Update_Attendance_SeniorityBonus(absence_days, leave_days, seniority_bonus, meals_deductions, social_deductions, late_deductions, shipping_deductions, other_deductions, empCode, year, month);
                        }
                        context.Response.Write("true");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }

                }


            }
            #endregion
            #region 
            else if (request["Action"] == "getYearCustomer")
            {
                string year = context.Request["syear"];
                int intYear, nowYear;
                string nowMonth, nowYearMonth;
                getYearCompare(year, out intYear, out nowYear, out nowMonth, out nowYearMonth);

                string admin_user_name = context.Request["admin_user_name"];
                if (admin_user_name == "null")
                {
                    admin_user_name = emp_code;
                }
                string strSqlOne = "emp.factory_id='" + factory_Id + "' and emp.isdelete=0 ";
                if (!string.IsNullOrEmpty(year))
                {
                    DataSet ds;
                    string yearDays = "";
                    if (nowYear > intYear)
                    {
                        yearDays = "360";
                    }
                    else
                    {
                        yearDays = "MONTH(now())*30";
                    }
                    ds = dmsService.GetCustomerYearDms(admin_user_name, year, yearDays);

                    DataTable dt0 = ds.Tables[0];
                    HttpResponse respon = context.Response;
                    respon.Charset = "utf-8";
                    respon.Clear();
                    string filename = "客户年报" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                    respon.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(filename) + ".xls");
                    respon.ContentEncoding = Encoding.UTF8;
                    respon.ContentType = "application/octet-stream";

                    string style = "<meta http-equiv=\"content-type\" content=\"application/ms-excel; charset=utf-8\"/>"
                        + "<style> .table{ font: 9pt Tahoma, Verdana; color: #000000;   }"
                        + ".table td{text-align:center;border:1px solid #000;}"
                        + ".table th{ font: 9pt Tahoma, Verdana; color: #000000; font-weight: bold; background-color: #8ECBEA;  text-align:center; padding-left:10px;}</style>";

                    respon.Write(style);

                    ColumnNameEnum cne = new ColumnNameEnum();
                    string tb_header = "<table class='table'><tr>";
                    for (int i = 0; i < dt0.Columns.Count; i++)
                    {
                        tb_header += "<th>" + cne.getColumnName(dt0.Columns[i].ColumnName) + "</th>";
                    }
                    tb_header += "</tr>";
                    respon.Write(tb_header);


                    DataTable dt = new DataTable();
                    dt.TableName = "dms_customer";

                    for (int i = 0; i < dt0.Columns.Count; i++)
                    {
                        dt.Columns.Add(cne.getColumnName(dt0.Columns[i].ColumnName));
                    }

                    DataRow dr0 = null, dr1 = null;

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dr1 = ds.Tables[0].Rows[i];
                        dr0 = dt.NewRow();
                        for (int j = 0; j < dt0.Columns.Count; j++)
                        {
                            dr0[j] = dr1[j];
                        }
                        dt.Rows.Add(dr0);
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        respon.Write("<tr>");
                        for (int i = 0; i < dt.Columns.Count; i++)
                            respon.Write("<td>" + row[i] + "</td>");
                        respon.Write("</tr>");
                    }
                    respon.Write("</table>");

                    respon.Flush();
                    respon.End();

                }

            }
            #endregion
            #region 导出薪资表
            else if (request["Action"] == "export_Salary")
            {
                if (emp_code != "1010" && emp_code != "5001" && emp_code != "5007" )
                {
                    context.Response.Write("你的权限不足！无法导出薪资数据");
                }
                else
                {

                    string year = context.Request["syear"];
                    string month = context.Request["smonth"];

                    string d_ids = DataAuth(emp_id.ToString(), factory_Id);
                    d_ids = d_ids.Replace("emp.d_id", "d_pid");

                    DataSet ds = dms_salaryService.GetList("year=" + year + " and month=" + month + d_ids + " ORDER BY CONVERT(d_pid,SIGNED) ");
                    DataTable dt0 = ds.Tables[0];
                    HttpResponse respon = context.Response;
                    respon.Charset = "utf-8";
                    respon.Clear();
                    string filename = month + "月份薪资表" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                    respon.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(filename) + ".xls");
                    respon.ContentEncoding = Encoding.UTF8;
                    respon.ContentType = "application/octet-stream";

                    string style = "<meta http-equiv=\"content-type\" content=\"application/ms-excel; charset=utf-8\"/>"
                        + "<style> .table{ font: 9pt Tahoma, Verdana; color: #000000;   }"
                        + ".table td{text-align:center;border:1px solid #000;}"
                        + ".table th{ font: 9pt Tahoma, Verdana; color: #000000; font-weight: bold; background-color: #8ECBEA;  text-align:center; padding-left:10px;}</style>";

                    respon.Write(style);

                    ColumnNameEnum cne = new ColumnNameEnum();
                    string tb_header = "<table class='table'><tr>";
                    for (int i = 0; i < dt0.Columns.Count; i++)
                    {
                        tb_header += "<th>" + cne.getColumnName(dt0.Columns[i].ColumnName) + "</th>";
                    }
                    tb_header += "</tr>";
                    respon.Write(tb_header);


                    DataTable dt = new DataTable();
                    dt.TableName = "dmsSalary";

                    for (int i = 0; i < dt0.Columns.Count; i++)
                    {
                        dt.Columns.Add(cne.getColumnName(dt0.Columns[i].ColumnName));
                    }

                    DataRow dr0 = null, dr1 = null;

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dr1 = ds.Tables[0].Rows[i];
                        dr0 = dt.NewRow();
                        for (int j = 0; j < dt0.Columns.Count; j++)
                        {
                            dr0[j] = dr1[j];
                        }
                        dt.Rows.Add(dr0);
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        respon.Write("<tr>");
                        for (int i = 0; i < dt.Columns.Count; i++)
                            respon.Write("<td>" + row[i] + "</td>");
                        respon.Write("</tr>");
                    }
                    respon.Write("</table>");

                    respon.Flush();
                    respon.End();
                }

                //DataToExcel dte=new Common.DataToExcel ();
                ////string Desktop=Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                ////dte.OutputExcel(ds.Tables[0],month+"月份薪资表",Desktop+"/");
                //WriteExcel(ds.Tables[0], month + "月份薪资表", "d:/" + month + "月份薪资表" + DateTime.Now.ToString("yyyyMMddHHmmssff") + ".xls");

                //context.Response.Write("true");
            }
            #endregion

            #region 清理薪资缓存数据
            else if (request["Action"] == "clear_Salary")
            {
                if (emp_code != "1010" && emp_code != "5001" && emp_code != "5007" )
                {
                    context.Response.Write("Unauthorized");
                }
                else
                {
                    string year = context.Request["syear"];
                    string month = context.Request["smonth"];
                    month = month.Length < 2 ? "0" + month : month;
                    string monthnode = month + ',' + month + "01," + month + "02," + month + "03," + month + "04";

                    //1.清理考核品牌提成表
                    dms_brand_percentageService.DeleteBySql("year=" + year + " and month=" + month);
                    //2.清理销售客户数销售金额表
                    dms_customer_saleService.DeleteBySql("year=" + year + " and month=" + month);
                    //3.清理个人月节点排行表
                    dms_monthnode_saleService.DeleteBySql("year=" + year + " and monthnode in (" + monthnode + ")");
                    //4.清理团队月节点排名表
                    dms_team_bonusService.DeleteBySql("year=" + year + " and monthnode in (" + monthnode + ")");
                    //5.清理薪资总结表
                    dms_salaryService.DeleteBySql("year=" + year + " and month=" + month);

                    context.Response.Write("1");
                }
            }
            #endregion


            #region 保存文件 分配团队奖数据.xlsx
            else if (request["Action"] == "excel_upload2")
            {
                if (emp_code != "1010" && emp_code != "5001" && emp_code != "5007" )
                {
                    context.Response.Write("Unauthorized");
                }
                else
                {
                    string fileName = request["filename"];    //文件路径
                    //360浏览器，ie ，chrome存在C:\\fakepath\\7月份出勤和工龄数据.xlsx
                    if (fileName.LastIndexOf("\\") > 0)
                    {
                        int xx = fileName.LastIndexOf("\\") + 1;
                        fileName = fileName.Substring(xx, fileName.Length - xx);
                    }
                    if (request.Files.Count > 0)
                    {
                        HttpPostedFile uploadFile = request.Files[0];
                        string filepath = @"~/file/" + fileName.Replace("=", "");
                        uploadFile.SaveAs(context.Server.MapPath(filepath));
                        FileInfo file = new FileInfo(context.Server.MapPath(filepath));
                        if (!file.Exists)
                        {
                            context.Response.Write("false");
                        }
                        else
                        {
                            context.Response.Write(context.Server.MapPath(filepath));
                        }
                    }
                }

            }
            #endregion

            #region 导入已分配团队奖
            else if (request["Action"] == "input_Team_Carvebonus")
            {
                string empCode;
                decimal team_carve_bonus;
                decimal good_bonus;
                decimal phone_bonus;
                decimal point_bonus;

                string year = context.Request["syear"];
                string month = context.Request["smonth"];
                string filepath = request["file"];
                if (!string.IsNullOrEmpty(filepath))
                {
                    DataTable dtb = ExcelToDataTable(filepath);
                    if (dtb != null && dtb.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtb.Rows.Count; i++)
                        {
                            empCode = dtb.Rows[i][0].ToString();
                            team_carve_bonus = dtb.Rows[i][2].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][2].ToString());
                            good_bonus = dtb.Rows[i][3].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][3].ToString());
                            phone_bonus = dtb.Rows[i][4].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][4].ToString());
                            point_bonus = dtb.Rows[i][5].ToString() == "" ? 0 : Convert.ToDecimal(dtb.Rows[i][5].ToString());
                            dms_salaryService.Update_Team_Carvebonus_FromExcel(team_carve_bonus, good_bonus, phone_bonus, point_bonus, empCode, year, month);
                        }
                        context.Response.Write("true");
                    }
                    else
                    {
                        context.Response.Write("0");
                    }

                }


            }
            #endregion

            #region 获取当前登录empcode
            else if (request["Action"] == "getEmpCode")
            {
                context.Response.Write(emp_code);
            }
            #endregion


            #endregion

        }


        #region 查询全部部门的所有人客服编号

        public string getDeps(string factory_Id)
        {

            BLL.hr_employee emp = new BLL.hr_employee();
            BLL.hr_department dep = new BLL.hr_department();

            DataSet depds = dep.GetAllList("Factory_Id='" + factory_Id + "'");
            string deptaskAll = GetDepTask(1, depds.Tables[0]);
            string d_ids = " and ( emp.d_id in(" + deptaskAll.TrimEnd(',') + "))";
            DataSet empCodeAllDS = emp.GetList(" d_id in(" + deptaskAll.TrimEnd(',') + ")");
            string empCodesAll = "";
            if (empCodeAllDS != null && empCodeAllDS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < empCodeAllDS.Tables[0].Rows.Count; i++)
                {
                    empCodesAll += "'" + empCodeAllDS.Tables[0].Rows[i]["emp_code"].ToString() + "',";//取得部门下的所有员工号
                }
                empCodesAll = empCodesAll.Trim(',');//去掉最后一个逗号
            }
            return empCodesAll;
        }
        #endregion

        #region 根据登录者权限查看可查看客服编号
        public string getEmpCodes(string idlist, int emp_id, string factory_Id)
        {
            string empCodes = "";
            BLL.hr_employee emp = new BLL.hr_employee();
            DataSet empCodeDS;
            //姓名栏位为空，取全部门人员的数据64,1343
            if (idlist == "")
            {
                string emp_codes = DataAuth(emp_id.ToString(), factory_Id);
                empCodeDS = emp.GetList(" 1=1 " + emp_codes.Replace("emp.", ""));
            }
            //姓名栏位为个人p1277
            else if (idlist.IndexOf('p') >= 0)
            {
                BLL.hr_post post = new BLL.hr_post();
                empCodeDS = post.GetEmpCode("post_id in (" + idlist.Replace(";", ",").Replace("-", "").Replace("p", "") + ")");

            }
            //姓名栏位为小组，取部门id为小组id的所有小组人员1343
            else
            {
                empCodeDS = emp.GetList("d_id=" + idlist);
            }

            if (empCodeDS != null && empCodeDS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < empCodeDS.Tables[0].Rows.Count; i++)
                {
                    empCodes += "'" + empCodeDS.Tables[0].Rows[i]["emp_code"].ToString() + "',";//取得部门下的所有员工号
                }
                empCodes = empCodes.Trim(',');//去掉最后一个逗号
            }
            return empCodes;
        }
        #endregion

        #region 获得节点
        public string getNodeList(string year, string month)
        {
            //节点
            ecs_set_nodeService ecs_set_nodeService = new ecs_set_nodeService();
            ecs_set_node ecs_set_node = new ecs_set_node();
            string nodeList = "";
            //品牌主管  
            string whereStr = "node_year=" + year + " and node_month =" + month;//int 06=6 mysql
            DataSet ds_node = ecs_set_nodeService.GetList(whereStr);
            if (ds_node != null && ds_node.Tables[0].Rows.Count > 0)
            {
                //string node_two1 = ds_node.Tables[0].Rows[0]["node_two1"].ToString();
                //string node_three1 = ds_node.Tables[0].Rows[0]["node_three1"].ToString();
                //string node_four1 = ds_node.Tables[0].Rows[0]["node_four1"].ToString();
                //nodeList = ",\"nodes\":[" + node_two1 + "," + node_three1 + "," + node_four1 + "]}";

                string node_one2 = ds_node.Tables[0].Rows[0]["node_one2"].ToString();
                string node_two2 = ds_node.Tables[0].Rows[0]["node_two2"].ToString();
                string node_three2 = ds_node.Tables[0].Rows[0]["node_three2"].ToString();
                string node_four2 = ds_node.Tables[0].Rows[0]["node_four2"].ToString();
                nodeList = ",\"nodes\":[" + node_one2 + "," + node_two2 + "," + node_three2 + "," + node_four2 + "]}";
            }
            return nodeList;
        }

        #endregion

        #region 品牌经理
        #region 获得品牌经理
        public string getManagerBrandIds(string emp_code)
        {
            string brandIdList = "";
            //品牌主管  
            dms_brand_managerService dms_brand_managerService = new dms_brand_managerService();
            dms_brand_manager dms_brand_manager = new dms_brand_manager();
            DataSet dbm = dms_brand_managerService.GetList("emp_code=" + emp_code);
            if (dbm != null && dbm.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dbm.Tables[0].Rows.Count; i++)
                {
                    brandIdList += dbm.Tables[0].Rows[i]["brand_id"].ToString() + ',';
                }
                brandIdList = brandIdList.Substring(0, brandIdList.Length - 1);
            }
            return brandIdList;
        }
        #endregion

        #region 品牌经理，返回权限，是该品牌的品牌经理，返回所有人，不是则返回权限内的人
        public void getBrandManagerRole(string factory_Id, string emp_code, int emp_id, out string returnSqlTxt, out string brandIds)
        {
            brandIds = getManagerBrandIds(emp_code);//品牌
            returnSqlTxt = "";
            if (brandIds != "")
            {
                returnSqlTxt = DataAuth("7", factory_Id);//全体成员
            }
            else
            {
                returnSqlTxt = DataAuth(emp_id.ToString(), factory_Id);
            }
        }

        public string getAreaSqlWhere(string brandIdList,string brandIds,string goodId,string goodTextBox)
        {
            string areaSqlWhere="";
            if (brandIdList != "")
            {
                if (brandIds != "")
                {
                    areaSqlWhere += " and brand_id in (" + brandIdList + ")";
                }
                else
                {
                    areaSqlWhere += " and bp_brand_id in (" + brandIdList + ")";
                }
            }
            else
            {
                if (brandIds != "")
                {
                    //qtBrand += " and bp_brand_id not IN (select bp_brand_id from ecs_brand_percentage where bp_brand_id not in (" + brandIdList.Replace(";", ",") + ") )";
                    areaSqlWhere += " and brand_id in (" + brandIds + ")";
                }
            }

            if (goodId != "")
            {
                areaSqlWhere += " and goods_id =" + goodId;
            }
            else if (goodTextBox != "")
            {
                areaSqlWhere += " and goods_name like '%" + goodTextBox + "%'";
            }
            return areaSqlWhere;
        }
        #endregion
        #endregion

        #region 薪资方法
        #region 添加薪资流 1.月销售额和客户数量dms_customer_sale 2.节点，冠军奖励 3.基本工资dms_salary，合计
        public string salaryLiu(string factory_Id, string year, string month,string month2,string yearMonth, string name, string empCode)
        {
            dmsService dmsService = new dmsService();
            BLL.hr_department dep = new BLL.hr_department();
            ecs_set_bonusService ecs_set_bonusService = new BLL.ecs_set_bonusService();
            ecs_set_nodeService ecs_set_nodeService = new BLL.ecs_set_nodeService();
            dms_salaryService dms_salaryService = new BLL.dms_salaryService();
            dms_monthnode_saleService dms_monthnode_saleService = new dms_monthnode_saleService();
            dms_team_bonusService dms_team_bonusService = new dms_team_bonusService();

            dms_customer_saleService dms_customer_saleService = new dms_customer_saleService();
            dms_customer_sale dms_customer_sale = new dms_customer_sale();

            dms_set_excludeService dms_set_excludeService = new dms_set_excludeService();

            string dt = "";
            string monthColumns = MonthService.getMonthColumn(month);
            string a_ = "a_" + month;
            string b_ = "b_" + month;

            //--------------------------奖励规则参数-------------------------------------//
            DataSet ds_bonus = ecs_set_bonusService.GetList("");
            //string wcl90 = ds_bonus.Tables[0].Rows[0]["team_dabiao2"].ToString();//a:7:{i:18;s:4:"1750";i:20;s:4:"2125";i:64;s:4:"1750";i:82;s:4:"1750";i:96;s:4:"1500";i:114;s:4:"2000";i:115;s:4:"1125";}
            //string wcl100 = ds_bonus.Tables[0].Rows[0]["team_dabiao"].ToString();//a:7:{i:18;s:4:"1000";i:20;s:4:"1000";i:64;s:4:"1000";i:82;s:4:"1000";i:96;s:4:"1000";i:114;s:4:"1000";i:115;s:3:"750";}
            decimal team_month_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["team_month_bonus"]);//团队月冠军1000

            decimal team_one_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["team_one_bonus"]);//团队节点1冠军500
            decimal team_two_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["team_two_bonus"]);//团队节点2冠军
            decimal team_three_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["team_three_bonus"]);//团队节点3冠军
            decimal team_four_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["team_four_bonus"]);//团队节点4冠军

            decimal month_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["month_bonus"]);//个人月冠军500
            decimal week_one_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["week_one_bonus"]);//个人节点1冠军200
            decimal week_two_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["week_two_bonus"]);//个人节点2冠军
            decimal week_three_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["week_three_bonus"]);//个人节点3冠军
            decimal week_four_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["week_four_bonus"]);//个人节点4冠军

            decimal one_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["one_bonus"]);//个人节点1达标150
            decimal two_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["two_bonus"]);//个人节点2达标
            decimal three_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["three_bonus"]);//个人节点3达标
            decimal four_bonus = Convert.ToDecimal(ds_bonus.Tables[0].Rows[0]["four_bonus"]);//个人节点4达标

            //所有部门所有人的数据
            DataSet depds = dep.GetAllList("Factory_Id='" + factory_Id + "'");
            string deptaskAll = GetDepTask(1, depds.Tables[0]);
            string d_ids = " and  emp.d_id in(" + deptaskAll.TrimEnd(',') + ")";

            //排除评比
            DataSet dsEx = dms_set_excludeService.GetList("");
            string exclude_emp_code = "";
            if (dsEx != null && dsEx.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsEx.Tables[0].Rows.Count; i++)
                {                    
                    exclude_emp_code += dsEx.Tables[0].Rows[i]["exclude_emp_code"].ToString() + ",";
                }
            }
            string notInEmp = "";
            if (exclude_emp_code!="")
            {
                notInEmp = " and emp_code not in (" + exclude_emp_code.TrimEnd(',') + ")";
            }
            

            DateTime dtnow = DateTime.Now;
            //月
            //string ordertime = "and erp_order_sn like '%" + year + "-" + month + "%'";//订单时间段
            //string djtime = " d.rq like '%" + year + "-" + month + "%'";//出库单据时间段


            string whereStr = "";
            whereStr = "node_year=" + year + " and node_month =" + month2;//int 06=6 mysql
            DataSet ds_node = ecs_set_nodeService.GetList(whereStr);
            //节点1
            string month01 = month2 + "01";//节点1
            string node_one1 = year + "-" + month2 + "-01";//第一节起点
            string node_one2 = ds_node.Tables[0].Rows[0]["node_one2"].ToString();//第一节终点
            node_one2 = node_one2.Length < 2 ? "0" + node_one2 : node_one2;
            node_one2 = year + "-" + month2 + "-" + node_one2;
            DateTime dt_node_one2 = Convert.ToDateTime(node_one2);
            //string ordertime1 = "and oi.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_one1)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_one2).AddHours(23).AddMinutes(59).AddSeconds(59));
            //string djtime1 = "date(d.RQ) >='" + DateTime.Parse(node_one1) + "' and date(d.RQ)<='" + DateTime.Parse(node_one2).AddHours(23).AddMinutes(59).AddSeconds(59) + "'";
            //节点2
            string month02 = month2 + "02";//节点2
            string node_two1 = ds_node.Tables[0].Rows[0]["node_two1"].ToString();//第二节起点
            node_two1 = node_two1.Length < 2 ? "0" + node_two1 : node_two1;
            node_two1 = year + "-" + month2 + "-" + node_two1;
            string node_two2 = ds_node.Tables[0].Rows[0]["node_two2"].ToString();//第二节终点
            node_two2 = node_two2.Length < 2 ? "0" + node_two2 : node_two2;
            node_two2 = year + "-" + month2 + "-" + node_two2;
            DateTime dt_node_two2 = Convert.ToDateTime(node_two2);
            //string ordertime2 = "and oi.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_two1)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_two2).AddHours(23).AddMinutes(59).AddSeconds(59));
            //string djtime2 = "date(d.RQ) >='" + DateTime.Parse(node_two1) + "' and date(d.RQ)<='" + DateTime.Parse(node_two2).AddHours(23).AddMinutes(59).AddSeconds(59) + "'";
            //节点3
            string month03 = month2 + "03";//节点3
            string node_three1 = ds_node.Tables[0].Rows[0]["node_three1"].ToString();//第三节点起点
            node_three1 = node_three1.Length < 2 ? "0" + node_three1 : node_three1;
            node_three1 = year + "-" + month2 + "-" + node_three1;
            string node_three2 = ds_node.Tables[0].Rows[0]["node_three2"].ToString();//第三节点终点
            node_three2 = node_three2.Length < 2 ? "0" + node_three2 : node_three2;
            node_three2 = year + "-" + month2 + "-" + node_three2;
            DateTime dt_node_three2 = Convert.ToDateTime(node_three2);
            //string ordertime3 = "and oi.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_three1)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_three2).AddHours(23).AddMinutes(59).AddSeconds(59));
            //string djtime3 = "date(d.RQ) >='" + DateTime.Parse(node_three1) + "' and date(d.RQ)<='" + DateTime.Parse(node_three2).AddHours(23).AddMinutes(59).AddSeconds(59) + "'";
            //节点4
            string month04 = month2 + "04";//节点4
            string node_four1 = ds_node.Tables[0].Rows[0]["node_four1"].ToString();//第四节点
            node_four1 = node_four1.Length < 2 ? "0" + node_four1 : node_four1;
            node_four1 = year + "-" + month2 + "-" + node_four1;
            string node_four2 = ds_node.Tables[0].Rows[0]["node_four2"].ToString();//第四节点
            node_four2 = node_four2.Length < 2 ? "0" + node_four2 : node_four2;
            node_four2 = year + "-" + month2 + "-" + node_four2;
            //string ordertime4 = "and oi.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_four1)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_four2).AddHours(23).AddMinutes(59).AddSeconds(59));
            //string djtime4 = "date(d.RQ) >='" + DateTime.Parse(node_four1) + "' and date(d.RQ)<='" + DateTime.Parse(node_four2).AddHours(23).AddMinutes(59).AddSeconds(59) + "'";


            //对应本月与上月的数据，因为在下个月底才发工资，所以会存在删单，改单的情况，所有会有变化
            string strSqlTwo = " where emp.factory_id='" + factory_Id + "' and emp.isdelete=0  and user_id is not null ";
            //月销售额和客户数量dms_customer_sale
            dms_customer_saleService.DeleteBySql(" year=" + year + " and month=" + month2);
            DataSet ds_dms_customer_sale = dmsService.GetMonthCustomerSaleData(strSqlTwo, d_ids,year,month2, yearMonth);
            //AddCustomerSale(ds_dms_customer_sale, year, month);

            //如果为空，说明还没插入上月数据，进行首次插入全部数据

            //先删除老数据,个人和团队的销售数据
            //dms_monthnode_saleService.DeleteBySql(" year=" + year + " and monthnode like '%" + month + "%'");
            //dms_team_bonusService.DeleteBySql(" year=" + year + " and monthnode like '%" + month + "%'");

            string strSqlOne = " where emp.factory_id='" + factory_Id + "' and emp.isdelete=0 ";
            //----------------------1.插入月数据---------------------------------//

            //----------------------1.1个人月冠军---------------------------------//
            dms_monthnode_saleService.DeleteBySql(" year=" + year + " and monthnode=" + month2);
            DataSet ds_month_no1 = dmsService.GetPersonalMonthRankData(monthColumns,  strSqlOne, d_ids, year, month2, yearMonth, month_bonus, 0);
            //AddMonthNodeSale(ds_month_no1, year, month, month_bonus, 0);
            //----------------------1.2团队月冠军---------------------------------//
            dms_team_bonusService.DeleteBySql(" year=" + year + " and monthnode=" + month2);
            DataSet ds_monthTeam_no1 = dmsService.GetTeamMonthRankData(monthColumns, strSqlOne, d_ids + notInEmp, yearMonth, year, month2, team_month_bonus, name);//团队月
            //AddMonthNodeTeamBonus(ds_monthTeam_no1, year, month, team_month_bonus, name);


            //----------------------2.插入节点1数据---------------------------------//
            //----------------------2.1个人节点1冠军奖,达标奖---------------------------------//
            //排名必须查部门所有人的did，不能以当选择的empcodes查询，一次性查询所有人的,4个
            dms_monthnode_saleService.DeleteBySql(" year=" + year + " and monthnode=" + month01);
            DataSet ds_node1_no1 = dmsService.GetPersonalNodeRankData(monthColumns, strSqlOne, d_ids, node_one1, node_one2,year, month01, week_one_bonus, one_bonus);
            //AddMonthNodeSale(ds_node1_no1, year, month01, week_one_bonus, one_bonus);
            //----------------------2.2团队节点1冠军奖，达标奖---------------------------------//
            dms_team_bonusService.DeleteBySql(" year=" + year + " and monthnode=" + month01);
            DataSet ds_node1Team_no1 = dmsService.GetTeamNodeRankData(monthColumns, strSqlOne, d_ids + notInEmp, node_one1, node_one2, year, month01, team_one_bonus, name);//月除以4，等于节点计划基数
            //AddMonthNodeTeamBonus(ds_node1Team_no1, year, month01, team_one_bonus, name);

            //----------------------3.插入节点2数据---------------------------------//
            //如果当前时间大于第一节点结束点，就可以查询第二节点数据，避免查询都是0，浪费时间
            if (dtnow > dt_node_one2)
            {
                //----------------------3.1个人节点2冠军奖,达标奖---------------------------------//
                dms_monthnode_saleService.DeleteBySql(" year=" + year + " and monthnode=" + month02);
                DataSet ds_node2_no1 = dmsService.GetPersonalNodeRankData(monthColumns, strSqlOne, d_ids, node_two1, node_two2, year, month02, week_two_bonus, one_bonus);
                //AddMonthNodeSale(ds_node2_no1, year, month02, week_one_bonus, one_bonus);

                //----------------------3.2团队节点2冠军奖，达标奖---------------------------------//
                dms_team_bonusService.DeleteBySql(" year=" + year + " and monthnode=" + month02);
                DataSet ds_node2Team_no1 = dmsService.GetTeamNodeRankData(monthColumns, strSqlOne, d_ids + notInEmp, node_two1, node_two2, year, month02, team_two_bonus, name);//月除以4，等于节点计划基数
                //AddMonthNodeTeamBonus(ds_node2Team_no1, year, month02, team_one_bonus, name);
            }

            //----------------------4.插入节点3数据---------------------------------//
            if (dtnow > dt_node_two2)
            {
                //----------------------4.1 个人节点3冠军奖,达标奖---------------------------------//
                dms_monthnode_saleService.DeleteBySql(" year=" + year + " and monthnode=" + month03);
                DataSet ds_node3_no1 = dmsService.GetPersonalNodeRankData(monthColumns, strSqlOne, d_ids, node_three1, node_three2, year, month03, week_three_bonus, one_bonus);
                //AddMonthNodeSale(ds_node3_no1, year, month03, week_one_bonus, one_bonus);
                //----------------------4.2 团队节点3冠军和节点达标奖---------------------------------//
                dms_team_bonusService.DeleteBySql(" year=" + year + " and monthnode=" + month03);
                DataSet ds_node3Team_no1 = dmsService.GetTeamNodeRankData(monthColumns, strSqlOne, d_ids + notInEmp, node_three1, node_three2, year, month03, team_three_bonus, name);//月除以4，等于节点计划基数
                //AddMonthNodeTeamBonus(ds_node3Team_no1, year, month03, team_one_bonus, name);
            }

            //----------------------5.插入节点4数据---------------------------------//
            if (dtnow > dt_node_three2)
            {
                //----------------------5.1 个人节点4冠军奖,达标奖---------------------------------//
                dms_monthnode_saleService.DeleteBySql(" year=" + year + " and monthnode=" + month04);
                DataSet ds_node4_no1 = dmsService.GetPersonalNodeRankData(monthColumns, strSqlOne, d_ids, node_four1, node_four2, year, month04, week_four_bonus, one_bonus);
                //AddMonthNodeSale(ds_node4_no1, year, month04, week_one_bonus, one_bonus);
                //----------------------5.2 团队节点4冠军和节点达标奖---------------------------------//
                dms_team_bonusService.DeleteBySql(" year=" + year + " and monthnode=" + month04);
                DataSet ds_node4Team_no1 = dmsService.GetTeamNodeRankData(monthColumns, strSqlOne, d_ids + notInEmp, node_four1, node_four2, year, month04, team_four_bonus, name);//月除以4，等于节点计划基数
                //AddMonthNodeTeamBonus(ds_node4Team_no1, year, month04, team_one_bonus, name);
            }

            //6.通过客户数销售额计算基本工资
            DataSet ds_dms_salary_New = dmsService.GetPersonalMonthSalaryData(year, month2);
            AddSaraly(ds_dms_salary_New, year, month2, name, factory_Id);

            //7.通过以上插入的表数据，查询汇总出个人薪资表数据
            ds_dms_salary_New = dms_salaryService.GetList(" year=" + year + " and month=" + month2 + " and admin_user_name in(" + empCode + ")");
            if (ds_dms_salary_New != null && ds_dms_salary_New.Tables[0].Rows.Count > 0)
            {
                dt = Common.GetGridJSON.DataTableToJSON(ds_dms_salary_New.Tables[0]);//历史汇总表
            }
            return dt;
        }
        #endregion

        //#region 添加提成
        //public void AddBrandPercentage(DataSet ds_brandPercentage, string year, string month)
        //{
        //    dms_brand_percentage dms_brand_percentage = new Model.dms_brand_percentage();
        //    dms_brand_percentageService dms_brand_percentageService = new dms_brand_percentageService();
        //    if (ds_brandPercentage != null && ds_brandPercentage.Tables[0].Rows.Count > 0)
        //    {
        //        //第一次奖查询结果插入个人品牌提成明细表，以便此后提高查询效率
        //        //id,year,month,bc_user_name,bc_real_name,bc_brand_id,bc_brand_name,basepersonal,planpersonal,bp_percentage,salemoney,backmoney,realmoney,cha,wcl,percentage
        //        for (int i = 0; i < ds_brandPercentage.Tables[0].Rows.Count; i++)
        //        {
        //            dms_brand_percentage.year = year;
        //            dms_brand_percentage.month = month;
        //            dms_brand_percentage.bc_user_name = ds_brandPercentage.Tables[0].Rows[i]["bc_user_name"].ToString();
        //            dms_brand_percentage.bc_real_name = ds_brandPercentage.Tables[0].Rows[i]["bc_real_name"].ToString();
        //            dms_brand_percentage.bc_brand_id = ds_brandPercentage.Tables[0].Rows[i]["bc_brand_id"].ToString();
        //            dms_brand_percentage.bc_brand_name = ds_brandPercentage.Tables[0].Rows[i]["bc_brand_name"].ToString();
        //            dms_brand_percentage.base_brand = Convert.ToDecimal(ds_brandPercentage.Tables[0].Rows[i]["base_brand"]);
        //            dms_brand_percentage.plan_brand = Convert.ToDecimal(ds_brandPercentage.Tables[0].Rows[i]["plan_brand"]);
        //            dms_brand_percentage.bp_percentage = Convert.ToDecimal(ds_brandPercentage.Tables[0].Rows[i]["bp_percentage"]);
        //            dms_brand_percentage.salemoney_brand = Convert.ToDecimal(ds_brandPercentage.Tables[0].Rows[i]["salemoney_brand"]);
        //            dms_brand_percentage.backmoney_brand = Convert.ToDecimal(ds_brandPercentage.Tables[0].Rows[i]["backmoney_brand"]);
        //            dms_brand_percentage.realmoney_brand = Convert.ToDecimal(ds_brandPercentage.Tables[0].Rows[i]["realmoney_brand"]);
        //            dms_brand_percentage.cha_brand = Convert.ToDecimal(ds_brandPercentage.Tables[0].Rows[i]["cha_brand"]);
        //            dms_brand_percentage.wcl_brand = Convert.ToDecimal(ds_brandPercentage.Tables[0].Rows[i]["wcl_brand"]);
        //            dms_brand_percentage.percentage_brand = Convert.ToDecimal(ds_brandPercentage.Tables[0].Rows[i]["percentage_brand"]);
        //            dms_brand_percentage.create_time = DateTime.Now;

        //            dms_brand_percentageService.Add(dms_brand_percentage);//存入品牌提成明细表
        //        }

        //    }
        //}
        //#endregion

        //#region 插入个人月节点销售数据
        ///// <summary>
        ///// 插入月，节点销售数据
        ///// </summary>
        ///// <param name="ds_node"></param>
        ///// <param name="year"></param>
        ///// <param name="node"></param>
        ///// <param name="week_bonus"></param>
        ///// <param name="bonus"></param>
        //public void AddMonthNodeSale(DataSet ds_dms_monthnode_sale, string year, string nodeOrMonth, decimal champion, decimal bonus)
        //{
        //    dms_monthnode_sale dms_monthnode_sale = new dms_monthnode_sale();
        //    dms_monthnode_saleService dms_monthnode_saleService = new dms_monthnode_saleService();

        //    if (ds_dms_monthnode_sale != null && ds_dms_monthnode_sale.Tables[0].Rows.Count > 0)
        //    {
        //        //先删除老数据
        //        dms_monthnode_saleService.DeleteBySql(" year=" + year + " and monthnode=" + nodeOrMonth);

        //        for (int i = 0; i < ds_dms_monthnode_sale.Tables[0].Rows.Count; i++)
        //        {
        //            dms_monthnode_sale.year = year;
        //            dms_monthnode_sale.monthnode = nodeOrMonth;
        //            dms_monthnode_sale.admin_user_name = ds_dms_monthnode_sale.Tables[0].Rows[i]["admin_user_name"].ToString();
        //            dms_monthnode_sale.name = ds_dms_monthnode_sale.Tables[0].Rows[i]["name"].ToString();
        //            dms_monthnode_sale.d_pid = ds_dms_monthnode_sale.Tables[0].Rows[i]["d_pid"].ToString();
        //            dms_monthnode_sale.d_pname = ds_dms_monthnode_sale.Tables[0].Rows[i]["d_pname"].ToString();
        //            dms_monthnode_sale.salemoney_personal = Convert.ToDecimal(ds_dms_monthnode_sale.Tables[0].Rows[i]["salemoney_personal"]);
        //            dms_monthnode_sale.backmoney_personal = Convert.ToDecimal(ds_dms_monthnode_sale.Tables[0].Rows[i]["backmoney_personal"]);
        //            dms_monthnode_sale.realmoney_personal = Convert.ToDecimal(ds_dms_monthnode_sale.Tables[0].Rows[i]["realmoney_personal"]);
        //            dms_monthnode_sale.plan_personal = Convert.ToDecimal(ds_dms_monthnode_sale.Tables[0].Rows[i]["plan_personal"]);
        //            dms_monthnode_sale.base_personal = Convert.ToDecimal(ds_dms_monthnode_sale.Tables[0].Rows[i]["base_personal"]);
        //            dms_monthnode_sale.cha_personal = Convert.ToDecimal(ds_dms_monthnode_sale.Tables[0].Rows[i]["cha_personal"]);
        //            dms_monthnode_sale.wcl_personal = Convert.ToDecimal(ds_dms_monthnode_sale.Tables[0].Rows[i]["wcl_personal"]);
        //            if (nodeOrMonth.Length > 2)//节点1001，月10
        //            {
        //                //个人节点冠军
        //                if (i == 0)
        //                {
        //                    dms_monthnode_sale.personal_champion = champion;//冠军奖金200
        //                }
        //                else
        //                {
        //                    dms_monthnode_sale.personal_champion = 0;
        //                }

        //                if (dms_monthnode_sale.wcl_personal >= 100)
        //                {
        //                    dms_monthnode_sale.personal_bonus = bonus;
        //                }
        //                else
        //                {
        //                    dms_monthnode_sale.personal_bonus = 0;
        //                }
        //            }
        //            else
        //            {
        //                if (i == 0)//个人月冠军
        //                {
        //                    dms_monthnode_sale.personal_champion = champion;//个人月冠军奖金500
        //                }
        //                else
        //                {
        //                    dms_monthnode_sale.personal_champion = 0;
        //                }

        //                dms_monthnode_sale.personal_bonus = 0;
        //            }

        //            dms_monthnode_sale.create_time = DateTime.Now;
        //            dms_monthnode_saleService.Add(dms_monthnode_sale);//个人节点情况存入个人薪资表
        //        }
        //    }
        //}
        //#endregion

        //#region 插入团队月节点销售数据
        ///// <summary>
        ///// 插入团队奖部分
        ///// </summary>
        ///// <param name="ds_NodeTeam"></param>
        ///// <param name="year"></param>
        ///// <param name="node"></param>
        ///// <param name="champion"></param>
        //public void AddMonthNodeTeamBonus(DataSet ds_NodeTeam, string year, string nodeOrMonth, decimal champion, string name)
        //{
        //    dms_team_bonus dms_team_bonus = new Model.dms_team_bonus();
        //    dms_team_bonusService dms_team_bonusService = new dms_team_bonusService();

        //    //团队达标奖励表
        //    dms_set_bonus_team dms_set_bonus_team = new Model.dms_set_bonus_team();
        //    dms_set_bonus_teamService dms_set_bonus_teamService = new BLL.dms_set_bonus_teamService();

        //    if (ds_NodeTeam != null && ds_NodeTeam.Tables[0].Rows.Count > 0)
        //    {
        //        //先删除老数据
        //        dms_team_bonusService.DeleteBySql(" year=" + year + " and monthnode=" + nodeOrMonth);

        //        for (int i = 0; i < ds_NodeTeam.Tables[0].Rows.Count; i++)
        //        {
        //            dms_team_bonus.year = year;
        //            dms_team_bonus.monthnode = nodeOrMonth;
        //            dms_team_bonus.d_pid = ds_NodeTeam.Tables[0].Rows[i]["d_pid"].ToString();
        //            dms_team_bonus.d_pname = ds_NodeTeam.Tables[0].Rows[i]["d_pname"].ToString();
        //            dms_team_bonus.salemoney_team = Convert.ToDecimal(ds_NodeTeam.Tables[0].Rows[i]["salemoney_team"]);
        //            dms_team_bonus.backmoney_team = Convert.ToDecimal(ds_NodeTeam.Tables[0].Rows[i]["backmoney_team"]);
        //            dms_team_bonus.realmoney_team = Convert.ToDecimal(ds_NodeTeam.Tables[0].Rows[i]["realmoney_team"]);
        //            dms_team_bonus.plan_team = Convert.ToDecimal(ds_NodeTeam.Tables[0].Rows[i]["plan_team"]);
        //            dms_team_bonus.base_team = Convert.ToDecimal(ds_NodeTeam.Tables[0].Rows[i]["base_team"]);
        //            dms_team_bonus.cha_team = Convert.ToDecimal(ds_NodeTeam.Tables[0].Rows[i]["cha_team"]);
        //            dms_team_bonus.wcl_team = Convert.ToDecimal(ds_NodeTeam.Tables[0].Rows[i]["wcl_team"]);

        //            //0501比如长度为4位时就是节点
        //            if (nodeOrMonth.Length > 2)
        //            {
        //                //团队节点1冠军奖金1000
        //                if (i == 0)
        //                {
        //                    dms_team_bonus.team_champion = champion;
        //                }
        //                else
        //                {
        //                    dms_team_bonus.team_champion = 0;
        //                }
        //                //团队节点1完成率达标奖励
        //                DataSet ds = dms_set_bonus_teamService.GetList("d_id=" + dms_team_bonus.d_pid);
        //                decimal db_100 = Convert.ToDecimal(ds.Tables[0].Rows[0]["db_100"]);
        //                decimal db_90 = Convert.ToDecimal(ds.Tables[0].Rows[0]["db_90"]);

        //                if (dms_team_bonus.wcl_team >= 100)//完成率>=100
        //                {
        //                    dms_team_bonus.team_bonus = db_100;

        //                    //int w = wcl100.IndexOf(dms_team_bonus.d_pid);
        //                    //if (w > 0)
        //                    //{
        //                    //    dms_team_bonus.team_bonus = Convert.ToDecimal(wcl100.Substring(w + dms_team_bonus.d_pid.Length + 6, 4).TrimEnd('"'));//节点1达标奖励,null=0
        //                    //}
        //                }
        //                else if (dms_team_bonus.wcl_team >= 90)//完成率>=90
        //                {
        //                    dms_team_bonus.team_bonus = db_90;
        //                    //int w = wcl90.IndexOf(dms_team_bonus.d_pid);
        //                    //if (w > 0)
        //                    //{
        //                    //    dms_team_bonus.team_bonus = Convert.ToDecimal(wcl90.Substring(w + dms_team_bonus.d_pid.Length + 6, 4).TrimEnd('"'));//节点1达标奖励,null=0
        //                    //}
        //                }
        //                else
        //                {
        //                    dms_team_bonus.team_bonus = 0;//节点1达标奖励
        //                }
        //            }//月份
        //            else
        //            {
        //                //月达完成率标奖励不考核，只考核节点的完成率
        //                dms_team_bonus.team_bonus = 0;
        //                if (i == 0)
        //                {
        //                    dms_team_bonus.team_champion = champion;//团队月冠军奖金1000
        //                }
        //                else
        //                {
        //                    dms_team_bonus.team_champion = 0;
        //                }
        //            }

        //            dms_team_bonus.create_time = DateTime.Now;
        //            dms_team_bonus.create_name = name;
        //            dms_team_bonusService.Add(dms_team_bonus);
        //        }
        //    }
        //}
        //#endregion

        //#region 存入月订单客户数和销售额，用于计算基本工资
        ///// <summary>
        ///// 存入月订单客户数和销售额，用于计算基本工资
        ///// </summary>
        ///// <param name="ds_dms_customer_sale"></param>
        ///// <param name="year"></param>
        ///// <param name="month"></param>
        //public void AddCustomerSale(DataSet ds_dms_customer_sale, string year, string month)
        //{
        //    dms_customer_sale dms_customer_sale = new Model.dms_customer_sale();
        //    dms_customer_saleService dms_customer_saleService = new dms_customer_saleService();

        //    if (ds_dms_customer_sale != null && ds_dms_customer_sale.Tables[0].Rows.Count > 0)
        //    {
        //        //先删除当前查询的月份
        //        dms_customer_saleService.DeleteBySql(" year=" + year + " and month=" + month);
        //        for (int i = 0; i < ds_dms_customer_sale.Tables[0].Rows.Count; i++)
        //        {
        //            dms_customer_sale.year = year;
        //            dms_customer_sale.month = month;
        //            dms_customer_sale.admin_user_name = ds_dms_customer_sale.Tables[0].Rows[i]["admin_user_name"].ToString();
        //            dms_customer_sale.name = ds_dms_customer_sale.Tables[0].Rows[i]["name"].ToString();
        //            dms_customer_sale.d_pid = ds_dms_customer_sale.Tables[0].Rows[i]["d_pid"].ToString();
        //            dms_customer_sale.d_pname = ds_dms_customer_sale.Tables[0].Rows[i]["d_pname"].ToString();
        //            dms_customer_sale.user_id = ds_dms_customer_sale.Tables[0].Rows[i]["user_id"].ToString();
        //            dms_customer_sale.user_name = ds_dms_customer_sale.Tables[0].Rows[i]["user_name"].ToString();
        //            dms_customer_sale.u_company = ds_dms_customer_sale.Tables[0].Rows[i]["u_company"].ToString();
        //            dms_customer_sale.salemoney_customer = Convert.ToDecimal(ds_dms_customer_sale.Tables[0].Rows[i]["salemoney_customer"]);
        //            dms_customer_sale.backmoney_customer = Convert.ToDecimal(ds_dms_customer_sale.Tables[0].Rows[i]["backmoney_customer"]);
        //            dms_customer_sale.realmoney_customer = Convert.ToDecimal(ds_dms_customer_sale.Tables[0].Rows[i]["realmoney_customer"]);
        //            dms_customer_sale.create_time = DateTime.Now;

        //            dms_customer_saleService.Add(dms_customer_sale);
        //        }
        //    }
        //}
        //#endregion

        #region 插入薪资数据
        public void AddSaraly(DataSet ds_dms_salary, string year, string month, string name, string factory_Id)
        {
            ecs_sale_parametersService ecs_sale_parametersService = new ecs_sale_parametersService();

            dms_salary dms_salary = new dms_salary();
            dms_salaryService dms_salaryService = new dms_salaryService();

            if (ds_dms_salary != null && ds_dms_salary.Tables[0].Rows.Count > 0)
            {

                DataSet ds_sale_parameters = ecs_sale_parametersService.GetList("");//基本工资参数表

                int c1 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["c1"]);//1800
                int cus_numc1 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_numc1"]);//
                int sale_numc1 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_numc1"]);//

                int c2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["c2"]);//2000
                int cus_numc2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_numc2"]);//
                int sale_numc2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_numc2"]);//

                int szone = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["szone"]);//2200
                int cus_num0 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num0"]);//
                int sale_num0 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num0"]);//
                int cus_num0_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num0_2"]);//
                int sale_num0_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num0_2"]);//

                int sone = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sone"]);//2500
                int cus_num1 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num1"]);//
                int sale_num1 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num1"]);//
                int cus_num1_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num1_2"]);//
                int sale_num1_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num1_2"]);//

                int stwo = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["stwo"]);//3500
                int cus_num2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num2"]);//
                int sale_num2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num2"]);//
                int cus_num2_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num2_2"]);//
                int sale_num2_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num2_2"]);//

                int sthree = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sthree"]);//3700
                int cus_num3 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num3"]);//
                int sale_num3 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num3"]);//
                int cus_num3_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num3_2"]);//
                int sale_num3_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num3_2"]);//	

                int sfour = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sfour"]);//3900
                int cus_num4 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num4"]);//
                int sale_num4 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num4"]);//
                int cus_num4_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num4_2"]);//
                int sale_num4_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num4_2"]);//

                int sfive = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sfive"]);//4100
                int cus_num5 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num5"]);//
                int sale_num5 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num5"]);//
                int cus_num5_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num5_2"]);//
                int sale_num5_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num5_2"]);//

                int ssix = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["ssix"]);//4300
                int sale_num6 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num6"]);//
                int cus_num6 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num6"]);//
                int sale_num6_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num6_2"]);//
                int cus_num6_2 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num6_2"]);//

                int zdy = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["zdy"]);//0
                int cus_num7 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["cus_num7"]);//
                int sale_num7 = Convert.ToInt32(ds_sale_parameters.Tables[0].Rows[0]["sale_num7"]);//	

                //先删除老数据
                dms_salaryService.DeleteBySql(" year=" + year + " and month=" + month);

                for (int i = 0; i < ds_dms_salary.Tables[0].Rows.Count; i++)
                {
                    dms_salary.year = ds_dms_salary.Tables[0].Rows[i]["year"].ToString(); ;
                    dms_salary.month = ds_dms_salary.Tables[0].Rows[i]["month"].ToString(); ;
                    dms_salary.admin_user_name = ds_dms_salary.Tables[0].Rows[i]["admin_user_name"].ToString();
                    dms_salary.name = ds_dms_salary.Tables[0].Rows[i]["name"].ToString();
                    dms_salary.d_pid = ds_dms_salary.Tables[0].Rows[i]["d_pid"].ToString();
                    dms_salary.d_pname = ds_dms_salary.Tables[0].Rows[i]["d_pname"].ToString();

                    dms_salary.xy_1000 = Convert.ToInt32(ds_dms_salary.Tables[0].Rows[i]["xy_1000"]);
                    dms_salary.dy_1000 = Convert.ToInt32(ds_dms_salary.Tables[0].Rows[i]["dy_1000"]);
                    dms_salary.dy_5000 = Convert.ToInt32(ds_dms_salary.Tables[0].Rows[i]["dy_5000"]);
                    dms_salary.dy_10000 = Convert.ToInt32(ds_dms_salary.Tables[0].Rows[i]["dy_10000"]);
                    dms_salary.dy_20000 = Convert.ToInt32(ds_dms_salary.Tables[0].Rows[i]["dy_20000"]);
                    //判断工资等级从高到低
                    //如果超过2万的客户数>40 或者超过1万的客户数>80
                    if (dms_salary.dy_20000 >= cus_num6 || dms_salary.dy_10000 >= cus_num6_2)
                    {
                        dms_salary.basic = ssix;
                        dms_salary.grade = "S6";
                    }
                    else if (dms_salary.dy_20000 >= cus_num5 || dms_salary.dy_10000 >= cus_num5_2)
                    {
                        dms_salary.basic = sfive;
                        dms_salary.grade = "S5";
                    }
                    else if (dms_salary.dy_20000 >= cus_num4 || dms_salary.dy_10000 >= cus_num4_2)
                    {
                        dms_salary.basic = sfour;
                        dms_salary.grade = "S4";
                    }
                    else if (dms_salary.dy_20000 >= cus_num3 || dms_salary.dy_10000 >= cus_num3_2)
                    {
                        dms_salary.basic = sthree;
                        dms_salary.grade = "S3";
                    }
                    else if (dms_salary.dy_20000 >= cus_num2 || dms_salary.dy_10000 >= cus_num2_2)
                    {
                        dms_salary.basic = stwo;
                        dms_salary.grade = "S2";
                    }
                    else if (dms_salary.dy_10000 >= cus_num1 || dms_salary.dy_5000 >= cus_num1_2)
                    {
                        dms_salary.basic = sone;
                        dms_salary.grade = "S1";
                    }
                    else if (dms_salary.dy_10000 >= cus_num0 || dms_salary.dy_5000 >= cus_num0_2)
                    {
                        dms_salary.basic = szone;
                        dms_salary.grade = "S";
                    }
                    else if (dms_salary.dy_1000 >= cus_numc2)
                    {
                        dms_salary.basic = c2;
                        dms_salary.grade = "C2";
                    }
                    else if (dms_salary.dy_1000 >= cus_numc1)
                    {
                        dms_salary.basic = c1;
                        dms_salary.grade = "C1";
                    }
                    else
                    {
                        dms_salary.basic = 0;
                        dms_salary.grade = "0";
                    }

                    dms_salary.personal_champion = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["personal_champion"]);//月冠军
                    dms_salary.personal_champion1 = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["personal_champion1"]);//节点1冠军
                    dms_salary.personal_bonus1 = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["personal_bonus1"]);
                    dms_salary.personal_champion2 = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["personal_champion2"]);
                    dms_salary.personal_bonus2 = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["personal_bonus2"]);
                    dms_salary.personal_champion3 = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["personal_champion3"]);
                    dms_salary.personal_bonus3 = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["personal_bonus3"]);
                    dms_salary.personal_champion4 = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["personal_champion4"]);
                    dms_salary.personal_bonus4 = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["personal_bonus4"]);
                    dms_salary.percentage_sum = Convert.ToDecimal(ds_dms_salary.Tables[0].Rows[i]["percentage_sum"]);

                    //奖励合计=月冠军，节点奖励，节点达标
                    dms_salary.bonus_sum = dms_salary.personal_champion + dms_salary.personal_champion1 + dms_salary.personal_bonus1 + dms_salary.personal_champion2 + dms_salary.personal_bonus2 +
                        dms_salary.personal_champion3 + dms_salary.personal_bonus3 + dms_salary.personal_champion4 + dms_salary.personal_bonus4;
                    //未分配团队奖之前的工资，分配团队奖之后再更新，防止无团队奖的情况，无法插入工资合计的情况
                    //基本工资+奖励+提成
                    dms_salary.salary_sum = dms_salary.basic + dms_salary.bonus_sum + dms_salary.percentage_sum;

                    dms_salary.create_time = DateTime.Now;
                    dms_salary.create_name = name;
                    dms_salary.factory_id = factory_Id;
                    dms_salaryService.Add(dms_salary);//个人节点情况存入个人薪资表
                }
                //context.Response.Write(dt);
            }
        }

        #endregion
        #endregion

        #region 把数据从Excel装载到DataTable
        /// <summary>    
        /// 把数据从Excel装载到DataTable    
        /// </summary>    
        /// <param name="pathName">带路径的Excel文件名</param>    
        /// <param name="sheetName">工作表名</param>
        /// <param name="tbContainer">将数据存入的DataTable</param>
        /// <returns></returns> 
        public DataTable ExcelToDataTable(string pathName)
        {
            DataTable tbContainer = new DataTable();
            string strConn = string.Empty;
            FileInfo file = new FileInfo(pathName);
            if (!file.Exists)
            {
                throw new Exception("文件不存在");
            }
            string extension = file.Extension;
            switch (extension)
            {
                case ".xls":
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    break;
                case ".xlsx":
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                    break;
                default:
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    break;
            }
            //链接Excel
            OleDbConnection cnnxls = new OleDbConnection(strConn);
            //cnnxls.Open();
            //DataTable dt = cnnxls.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            //string tableName = dt.Rows[0][2].ToString().Trim();
            //读取Excel里面有 表Sheet1
            OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", "Sheet1"), cnnxls);
            DataSet ds = new DataSet();
            //将Excel里面有表内容装载到内存表中！
            oda.Fill(tbContainer);//未在本地计算机上注册“Microsoft.ACE.OLEDB.12.0”提供程序    解决办法：去http://download.microsoft.com/download/7/0/3/703ffbcb-dc0c-4e19-b0da-1463960fdcdb/AccessDatabaseEngine.exe下载。
            return tbContainer;
        }
        #endregion

        #region 返回年对比
        public void getYearCompare(string year, out int intYear, out int nowYear, out string nowMonth, out string nowYearMonth)
        {
            intYear = int.Parse(year.ToString());
            nowYear = DateTime.Now.Year;
            nowMonth = DateTime.Now.Month.ToString();
            nowMonth = nowMonth.Length < 2 ? "0" + nowMonth : nowMonth;
            nowYearMonth = nowYear + nowMonth;
        }
        #endregion

        #region 返回月对比
        public void getMonthCompare(string year, string month,out string month2, out DateTime dtNow, out DateTime nextMonth, out string monthColumns, out string yearMonth)
        {
            dtNow = DateTime.Now;
            int intNextMonth = int.Parse(month) + 1;//12月+1=13月，错误
            if (intNextMonth == 13)
            {
                int intNextYear = int.Parse(year) + 1;//年份加1，月份为1，下一年1月份
                intNextMonth = 1;
                nextMonth = Convert.ToDateTime(intNextYear.ToString() + "-" + intNextMonth.ToString() + "-" + "01");
            }
            else
            {
                nextMonth = Convert.ToDateTime(year + "-" + intNextMonth.ToString() + "-" + "01");
            }
            monthColumns = MonthService.getMonthColumn(month);
            month2 = month.Length < 2 ? "0" + month : month;
            yearMonth = year + month2;
            
        }
        #endregion

        #region 返回月对比
        public void getDateToTimeParser(string date, out string startTime, out string endTime)
        {
            if (date == "")
            {
                date = DateTime.Now.Date.ToString("yyyy-MM-dd");
            }

            startTime = Common.TimeParser.GenerateTimeStamp(DateTime.Parse(date));
            endTime = Common.TimeParser.GenerateTimeStamp(DateTime.Parse(date).AddHours(23).AddMinutes(59).AddSeconds(59));

        }
        #endregion

        #region common方法
        private static string GetTreeStringX(int Id, DataTable table, int todo, int curId, string returntxt)
        {
            BLL.hr_post hp = new BLL.hr_post();
            BLL.Sys_online sol = new BLL.Sys_online();
            DataRow[] rows = table.Select(string.Format("parentid={0}", Id));

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                if ((int)row["id"] != curId)
                    continue;
                str.Append("{id:" + (int)row["id"] + ",text:'" + (string)row["d_name"] + "',d_icon:'../" + (string)row["d_icon"] + "'");
                if (GetTreeString((int)row["id"], table, 0, returntxt).Length > 0)
                {
                    str.Append(",children:[");
                    if (todo == 1)
                    {
                        DataSet dsp = hp.GetList("dep_id=" + (int)row["id"] + " and " + returntxt);
                        if (dsp != null && dsp.Tables[0].Rows.Count > 0)
                        {
                            for (int j = 0; j < dsp.Tables[0].Rows.Count; j++)
                            {
                                if (!string.IsNullOrEmpty(dsp.Tables[0].Rows[j]["emp_name"].ToString()))
                                {
                                    DataSet dso = sol.GetList("UserID=" + dsp.Tables[0].Rows[j]["emp_id"]);
                                    string posticon = "images/icon/93.png";
                                    if (dso.Tables[0].Rows.Count > 0)
                                        posticon = "images/icon/38.png";//95

                                    str.Append("{id:'p" + dsp.Tables[0].Rows[j]["post_id"].ToString() + "',text:'" + dsp.Tables[0].Rows[j]["emp_name"] + "',d_icon:'" + posticon + "'}");
                                    str.Append(",");
                                }
                            }
                        }
                    }
                    if (returntxt == "1=1")
                    {
                        str.Append(GetTreeString((int)row["id"], table, 1, returntxt));
                    }
                    str.Append("]},");
                }
                else
                {
                    if (todo == 1)
                    {
                        DataSet dsp = hp.GetList("dep_id=" + (int)row["id"] + " and " + returntxt);
                        if (dsp.Tables[0].Rows.Count > 0)
                        {
                            str.Append(",children:[");
                            for (int j = 0; j < dsp.Tables[0].Rows.Count; j++)
                            {
                                if (!string.IsNullOrEmpty(dsp.Tables[0].Rows[j]["emp_name"].ToString()))
                                {
                                    DataSet dso = sol.GetList("UserID=" + dsp.Tables[0].Rows[j]["emp_id"]);
                                    string posticon = "images/icon/93.png";
                                    if (dso.Tables[0].Rows.Count > 0)
                                        posticon = "images/icon/38.png";//95

                                    str.Append("{id:'p" + dsp.Tables[0].Rows[j]["post_id"].ToString() + "',text:'" + dsp.Tables[0].Rows[j]["emp_name"] + "',d_icon:'" + posticon + "'},");
                                    //if (j < dsp.Tables[0].Rows.Count - 1)
                                    //    str.Append(",");
                                }
                            }
                            if (str[str.Length - 1] == ',')
                                str.Remove(str.Length - 1, 1);
                            str.Append("]");
                        }
                    }
                    str.Append("},");
                }
            }
            return str[str.Length - 1] == ',' ? str.ToString(0, str.Length - 1) : str.ToString();
        }
        private static string GetTreeString(int Id, DataTable table, int todo, string returntxt)
        {
            BLL.hr_post hp = new BLL.hr_post();
            BLL.Sys_online sol = new BLL.Sys_online();
            DataRow[] rows = table.Select(string.Format("parentid={0}", Id));

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                str.Append("{id:" + (int)row["id"] + ",text:'" + (string)row["d_name"] + "',d_icon:'../" + (string)row["d_icon"] + "'");

                if (GetTreeString((int)row["id"], table, 0, returntxt).Length > 0)
                {
                    str.Append(",children:[");
                    if (todo == 1)
                    {
                        DataSet dsp = hp.GetList("dep_id=" + (int)row["id"]);
                        if (dsp != null && dsp.Tables[0].Rows.Count > 0)
                        {
                            for (int j = 0; j < dsp.Tables[0].Rows.Count; j++)
                            {
                                if (!string.IsNullOrEmpty(dsp.Tables[0].Rows[j]["emp_name"].ToString()))
                                {
                                    DataSet dso = sol.GetList("UserID=" + dsp.Tables[0].Rows[j]["emp_id"]);
                                    string posticon = "images/icon/93.png";
                                    if (dso.Tables[0].Rows.Count > 0)
                                        posticon = "images/icon/38.png";//95

                                    str.Append("{id:'p" + dsp.Tables[0].Rows[j]["post_id"].ToString() + "',text:'" + dsp.Tables[0].Rows[j]["emp_name"] + "',d_icon:'" + posticon + "'}");
                                    str.Append(",");
                                }
                            }
                        }
                    }
                    str.Append(GetTreeString((int)row["id"], table, 1, returntxt));
                    str.Append("]},");
                }
                else
                {
                    if (todo == 1)
                    {
                        DataSet dsp = hp.GetList("dep_id=" + (int)row["id"] + " and " + returntxt);
                        if (dsp.Tables[0].Rows.Count > 0)
                        {
                            str.Append(",children:[");
                            for (int j = 0; j < dsp.Tables[0].Rows.Count; j++)
                            {
                                if (!string.IsNullOrEmpty(dsp.Tables[0].Rows[j]["emp_name"].ToString()))
                                {
                                    DataSet dso = sol.GetList("UserID=" + dsp.Tables[0].Rows[j]["emp_id"]);
                                    string posticon = "images/icon/93.png";
                                    if (dso.Tables[0].Rows.Count > 0)
                                        posticon = "images/icon/38.png";//95

                                    str.Append("{id:'p" + dsp.Tables[0].Rows[j]["post_id"].ToString() + "',text:'" + dsp.Tables[0].Rows[j]["emp_name"] + "',d_icon:'" + posticon + "'},");
                                    //if (j < dsp.Tables[0].Rows.Count - 1)
                                    //    str.Append(",");
                                }
                            }
                            if (str[str.Length - 1] == ',')
                                str.Remove(str.Length - 1, 1);
                            str.Append("]");
                        }
                    }
                    str.Append("},");
                }
            }
            return str[str.Length - 1] == ',' ? str.ToString(0, str.Length - 1) : str.ToString();
        }
        private string DataAuth(string uid, string factory_Id)
        {
            //权限
            BLL.hr_employee emp = new BLL.hr_employee();
            DataSet dsemp = emp.GetList(" Factory_Id='" + factory_Id + "' and ID=" + int.Parse(uid));

            string returntxt = " and 1=1";
            if (dsemp.Tables[0].Rows.Count > 0)
            {
                if (dsemp.Tables[0].Rows[0]["uid"].ToString() != "admin")
                {
                    XHD.DMS.Data.GetDataAuth dataauth = new XHD.DMS.Data.GetDataAuth();
                    string txt = dataauth.GetDataAuthByid("1", "Sys_view", uid, factory_Id);
                    BLL.hr_department dep = new BLL.hr_department();
                    DataSet ds = dep.GetAllList("Factory_Id='" + factory_Id + "'");

                    string[] arr = txt.Split(':');

                    switch (arr[0])
                    {
                        case "none": returntxt = " and 1=2 ";
                            break;
                        case "my":
                            returntxt = " and (emp.id=" + int.Parse(arr[1]) + ")";
                            break;
                        case "dep":
                            if (string.IsNullOrEmpty(arr[1]))
                            {
                                returntxt = " and (emp.d_id=" + int.Parse(uid) + ")";
                            }
                            else
                            {
                                returntxt = " and (1=2)";
                            }
                            break;
                        case "depall":
                            string deptask = GetDepTask(int.Parse(arr[1]), ds.Tables[0]);
                            string intext = arr[1] + "," + deptask;
                            returntxt = " and ( emp.d_id in (" + intext.TrimEnd(',') + "))";
                            break;
                        case "all":
                            string deptaskAll = GetDepTask(1, ds.Tables[0]);
                            string intextAll = deptaskAll;
                            returntxt = " and ( emp.d_id in (" + intextAll.TrimEnd(',') + "))";
                            break;
                    }
                }
            }
            return returntxt;
        }

        private void DataAuth(string uid, string factory_Id, out string role, out string returntxt)
        {
            //权限
            BLL.hr_employee emp = new BLL.hr_employee();
            DataSet dsemp = emp.GetList(" Factory_Id='" + factory_Id + "' and ID=" + int.Parse(uid));

            returntxt = " and 1=1";
            role = "";
            if (dsemp.Tables[0].Rows.Count > 0)
            {
                if (dsemp.Tables[0].Rows[0]["uid"].ToString() != "admin")
                {
                    XHD.DMS.Data.GetDataAuth dataauth = new XHD.DMS.Data.GetDataAuth();
                    string txt = dataauth.GetDataAuthByid("1", "Sys_view", uid, factory_Id);
                    BLL.hr_department dep = new BLL.hr_department();
                    DataSet ds = dep.GetAllList("Factory_Id='" + factory_Id + "'");

                    string[] arr = txt.Split(':');
                    role = arr[0];
                    switch (role)
                    {
                        case "none": returntxt = " and 1=2 ";
                            break;
                        case "my":
                            returntxt = " and (emp.id=" + int.Parse(arr[1]) + ")";
                            break;
                        case "dep":
                            if (string.IsNullOrEmpty(arr[1]))
                            {
                                returntxt = " and (emp.d_id=" + int.Parse(uid) + ")";
                            }
                            else
                            {
                                returntxt = " and (1=2)";
                            }
                            break;
                        case "depall":
                            string deptask = GetDepTask(int.Parse(arr[1]), ds.Tables[0]);
                            string intext = arr[1] + "," + deptask;
                            returntxt = " and ( emp.d_id in (" + intext.TrimEnd(',') + "))";
                            break;
                        case "all":
                            string deptaskAll = GetDepTask(1, ds.Tables[0]);
                            string intextAll = deptaskAll;
                            returntxt = " and ( emp.d_id in (" + intextAll.TrimEnd(',') + "))";
                            break;
                    }
                }
            }
        }
        private static string GetDepTask(int Id, DataTable table)
        {
            DataRow[] rows = table.Select("parentid=" + Id.ToString());

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                str.Append(row["id"] + ",");
                if (GetDepTask((int)row["id"], table).Length > 0)
                    str.Append(GetDepTask((int)row["id"], table));
            }
            return str.ToString();
        }
        #endregion


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}