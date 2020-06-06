﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using XHD.BLL;
using XHD.Common;
using XHD.Model;

namespace XHD.DMS.DMS
{
    /// <summary>
    /// DMS_Set 的摘要说明
    /// </summary>
    public class DMS_Set : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpRequest request = context.Request;

            ecs_brand_check ecs_brand_check = new ecs_brand_check();
            ecs_brand_checkService ecs_brand_checkService = new ecs_brand_checkService();

            ecs_set_node ecs_set_node=new Model.ecs_set_node ();
            ecs_set_nodeService ecs_set_nodeService = new BLL.ecs_set_nodeService();

            ecs_set_bonus ecs_set_bonus = new Model.ecs_set_bonus();
            ecs_set_bonusService ecs_set_bonusService = new BLL.ecs_set_bonusService();

            ecs_sale_parameters ecs_sale_parameters = new Model.ecs_sale_parameters();
            ecs_sale_parametersService ecs_sale_parametersService = new BLL.ecs_sale_parametersService();

            ecs_brand_percentage ecs_brand_percentage = new Model.ecs_brand_percentage();
            ecs_brand_percentageService ecs_brand_percentageService = new BLL.ecs_brand_percentageService();

            ecs_total_planService ecs_total_planService = new BLL.ecs_total_planService();
            ecs_total_plan ecs_total_plan = new Model.ecs_total_plan();

            ecs_month_base ecs_month_base = new Model.ecs_month_base();
            ecs_month_baseService ecs_month_baseService = new BLL.ecs_month_baseService();

            ecs_per_plan ecs_per_plan = new Model.ecs_per_plan();
            ecs_per_planService ecs_per_planService = new BLL.ecs_per_planService();

            dms_set_bonus_team dms_set_bonus_team = new Model.dms_set_bonus_team();
            dms_set_bonus_teamService dms_set_bonus_teamService = new BLL.dms_set_bonus_teamService();

            Model.dms_brand_manager dms_brand_manager = new Model.dms_brand_manager();
            BLL.dms_brand_managerService dms_brand_managerService = new BLL.dms_brand_managerService();

            Model.hr_employee hr_employee = new Model.hr_employee();
            BLL.hr_employee hr_employeeService = new BLL.hr_employee();

            Model.ecs_brand ecs_brand = new Model.ecs_brand();
            BLL.ecs_brand ecs_brandService = new BLL.ecs_brand();

            dms_set_rating dms_set_rating = new Model.dms_set_rating();
            dms_set_ratingService dms_set_ratingService = new BLL.dms_set_ratingService();

            dms_set_exclude dms_set_exclude = new Model.dms_set_exclude();
            dms_set_excludeService dms_set_excludeService = new BLL.dms_set_excludeService();

            var cookie = context.Request.Cookies[FormsAuthentication.FormsCookieName];
            var ticket = FormsAuthentication.Decrypt(cookie.Value);
            string CoockiesID = ticket.UserData;

            BLL.hr_employee emp = new BLL.hr_employee();
            BLL.ecs_brand brand = new BLL.ecs_brand();
            BLL.hr_department dep = new BLL.hr_department();

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

            DateTime dtNow = DateTime.Now;
            
            #region 考核品牌计划基数
            if (request["Action"] == "getBrandCheck")
            {
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);
                string brandIdList = PageValidate.InputText(request["brandIdList"], int.MaxValue);//品牌
                string year = PageValidate.InputText(request["syear"], int.MaxValue);

                int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                string sortname = request["sortname"];
                string sortorder = request["sortorder"];

                if (string.IsNullOrEmpty(sortname))
                    sortname = " bc_real_name,bc_base";
                if (string.IsNullOrEmpty(sortorder))
                    sortorder = " desc";
                string sorttext = " " + sortname + " " + sortorder;
                string Total;

                string strWhere = " bc_user_name in(" + getEmpCodes(idlist, emp_id, factory_Id) + ")";
                if (brandIdList != "")
                {
                    strWhere += " and bc_brand_id in(" + brandIdList.Replace(";", ",") + ")";
                }
                if (!string.IsNullOrEmpty(year))
                {
                    strWhere += " and bc_year = " + year;
                }
                else
                {
                    year = dtNow.Year.ToString();
                    strWhere += " and bc_year = " + dtNow.Year;
                }
                DataSet ds = ecs_brand_checkService.GetList(PageSize, PageIndex, strWhere, sorttext, out Total);
                string reJosn = Common.GetGridJSON.DataTableToJSON1(ds.Tables[0], Total);
                context.Response.Write(reJosn);

            } 
            #endregion

            #region 品牌考核基数计划
            else if (request["Action"] == "addBrandCheck")
            {
                string year = context.Request["syear"];
                string bc_user_name = request["bc_user_name"];
                int bc_brand_id = Convert.ToInt32(request["bc_brand_id"]);
                string whereStr = " bc_user_name=" + getEmpCodes(bc_user_name, emp_id, factory_Id) + " and bc_brand_id=" + bc_brand_id + " and bc_year="+year;
                DataSet ds = ecs_brand_checkService.GetList(whereStr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    context.Response.Write("0");
                }
                else
                {
                    ecs_brand_check.a_1 = Convert.ToDecimal(request["a_1"]);
                    ecs_brand_check.a_2 = Convert.ToDecimal(request["a_2"]);
                    ecs_brand_check.a_3 = Convert.ToDecimal(request["a_3"]);
                    ecs_brand_check.a_4 = Convert.ToDecimal(request["a_4"]);
                    ecs_brand_check.a_5 = Convert.ToDecimal(request["a_5"]);
                    ecs_brand_check.a_6 = Convert.ToDecimal(request["a_6"]);
                    ecs_brand_check.a_7 = Convert.ToDecimal(request["a_7"]);
                    ecs_brand_check.a_8 = Convert.ToDecimal(request["a_8"]);
                    ecs_brand_check.a_9 = Convert.ToDecimal(request["a_9"]);
                    ecs_brand_check.a_10 = Convert.ToDecimal(request["a_10"]);
                    ecs_brand_check.a_11 = Convert.ToDecimal(request["a_11"]);
                    ecs_brand_check.a_12 = Convert.ToDecimal(request["a_12"]);

                    ecs_brand_check.b_1 = Convert.ToDecimal(request["b_1"]);
                    ecs_brand_check.b_2 = Convert.ToDecimal(request["b_2"]);
                    ecs_brand_check.b_3 = Convert.ToDecimal(request["b_3"]);
                    ecs_brand_check.b_4 = Convert.ToDecimal(request["b_4"]);
                    ecs_brand_check.b_5 = Convert.ToDecimal(request["b_5"]);
                    ecs_brand_check.b_6 = Convert.ToDecimal(request["b_6"]);
                    ecs_brand_check.b_7 = Convert.ToDecimal(request["b_7"]);
                    ecs_brand_check.b_8 = Convert.ToDecimal(request["b_8"]);
                    ecs_brand_check.b_9 = Convert.ToDecimal(request["b_9"]);
                    ecs_brand_check.b_10 = Convert.ToDecimal(request["b_10"]);
                    ecs_brand_check.b_11 = Convert.ToDecimal(request["b_11"]);
                    ecs_brand_check.b_12 = Convert.ToDecimal(request["b_12"]);

                    ecs_brand_check.bc_year = year;
                    ecs_brand_check.bc_user_id = Convert.ToInt32(request["bc_user_id"]);
                    ecs_brand_check.bc_user_name = getEmpCodes(bc_user_name, emp_id, factory_Id).Replace("'", "");
                    ecs_brand_check.bc_real_name = request["bc_real_name"];
                    ecs_brand_check.bc_brand_id = Convert.ToInt32(request["bc_brand_id"]);
                    ecs_brand_check.bc_brand_name = request["bc_brand_name"];
                    ecs_brand_check.bc_base = Convert.ToInt32(request["bc_base"]);
                    ecs_brand_check.bc_task = Convert.ToInt32(request["bc_task"]);

                    ecs_brand_check.create_time = dtNow;
                    ecs_brand_check.create_name = emp_code;
                    ecs_brand_check.factory_id = factory_Id;
                    ecs_brand_checkService.Add(ecs_brand_check);
                    context.Response.Write("1");
                }


            }
            else if (request["Action"] == "updateBrandCheck")
            {
                ecs_brand_check.bc_id = Convert.ToInt32(request["bc_id"]);
                ecs_brand_check.a_1 = Convert.ToDecimal(request["a_1"]);
                ecs_brand_check.a_2 = Convert.ToDecimal(request["a_2"]);
                ecs_brand_check.a_3 = Convert.ToDecimal(request["a_3"]);
                ecs_brand_check.a_4 = Convert.ToDecimal(request["a_4"]);
                ecs_brand_check.a_5 = Convert.ToDecimal(request["a_5"]);
                ecs_brand_check.a_6 = Convert.ToDecimal(request["a_6"]);
                ecs_brand_check.a_7 = Convert.ToDecimal(request["a_7"]);
                ecs_brand_check.a_8 = Convert.ToDecimal(request["a_8"]);
                ecs_brand_check.a_9 = Convert.ToDecimal(request["a_9"]);
                ecs_brand_check.a_10 = Convert.ToDecimal(request["a_10"]);
                ecs_brand_check.a_11 = Convert.ToDecimal(request["a_11"]);
                ecs_brand_check.a_12 = Convert.ToDecimal(request["a_12"]);

                ecs_brand_check.b_1 = Convert.ToDecimal(request["b_1"]);
                ecs_brand_check.b_2 = Convert.ToDecimal(request["b_2"]);
                ecs_brand_check.b_3 = Convert.ToDecimal(request["b_3"]);
                ecs_brand_check.b_4 = Convert.ToDecimal(request["b_4"]);
                ecs_brand_check.b_5 = Convert.ToDecimal(request["b_5"]);
                ecs_brand_check.b_6 = Convert.ToDecimal(request["b_6"]);
                ecs_brand_check.b_7 = Convert.ToDecimal(request["b_7"]);
                ecs_brand_check.b_8 = Convert.ToDecimal(request["b_8"]);
                ecs_brand_check.b_9 = Convert.ToDecimal(request["b_9"]);
                ecs_brand_check.b_10 = Convert.ToDecimal(request["b_10"]);
                ecs_brand_check.b_11 = Convert.ToDecimal(request["b_11"]);
                ecs_brand_check.b_12 = Convert.ToDecimal(request["b_12"]);

                ecs_brand_check.bc_base = Convert.ToInt32(request["bc_base"]);
                ecs_brand_check.bc_task = Convert.ToInt32(request["bc_task"]);

                ecs_brand_checkService.Update2(ecs_brand_check);
                context.Response.Write("2");
            }
            else if (request["Action"] == "deleteBrandCheck")
            {
                int bc_id = Convert.ToInt32(request["bc_id"]);

                ecs_brand_checkService.Delete(bc_id);
                context.Response.Write("4");
            } 
            #endregion
            
            #region 节点设置
            else if (request["Action"] == "getNode")
            {
                DataSet ds = ecs_set_nodeService.GetList("");
                context.Response.Write(Common.GetGridJSON.DataTableToJSON(ds.Tables[0]));
            }
            else if (request["Action"] == "addNode")
            {
                int node_year = Convert.ToInt32(request["node_year"]);
                int node_month = Convert.ToInt32(request["node_month"]);
                string whereStr = " node_year=" + node_year + " and node_month=" + node_month;
                DataSet ds = ecs_set_nodeService.GetList(whereStr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    context.Response.Write("0");
                }
                else
                {
                    ecs_set_node.node_year = Convert.ToInt32(request["node_year"]);
                    ecs_set_node.node_month = Convert.ToInt32(request["node_month"]);
                    ecs_set_node.node_one1 = Convert.ToInt32(request["node_one1"]);
                    ecs_set_node.node_one2 = Convert.ToInt32(request["node_one2"]);
                    ecs_set_node.node_two1 = Convert.ToInt32(request["node_two1"]);
                    ecs_set_node.node_two2 = Convert.ToInt32(request["node_two2"]);
                    ecs_set_node.node_three1 = Convert.ToInt32(request["node_three1"]);
                    ecs_set_node.node_three2 = Convert.ToInt32(request["node_three2"]);
                    ecs_set_node.node_four1 = Convert.ToInt32(request["node_four1"]);
                    ecs_set_node.node_four2 = Convert.ToInt32(request["node_four2"]);
                    ecs_set_node.telnum1 = Convert.ToInt32(request["telnum1"]);
                    ecs_set_node.telnum2 = Convert.ToInt32(request["telnum2"]);
                    ecs_set_node.telnum3 = Convert.ToInt32(request["telnum3"]);
                    ecs_set_node.telnum4 = Convert.ToInt32(request["telnum4"]);

                    ecs_set_nodeService.Add(ecs_set_node);
                    context.Response.Write("1");
                }


            }
            else if (request["Action"] == "updateNode")
            {
                ecs_set_node.node_id = Convert.ToInt32(request["node_id"]);
                ecs_set_node.node_year = Convert.ToInt32(request["node_year"]);
                ecs_set_node.node_month = Convert.ToInt32(request["node_month"]);
                ecs_set_node.node_one1 = Convert.ToInt32(request["node_one1"]);
                ecs_set_node.node_one2 = Convert.ToInt32(request["node_one2"]);
                ecs_set_node.node_two1 = Convert.ToInt32(request["node_two1"]);
                ecs_set_node.node_two2 = Convert.ToInt32(request["node_two2"]);
                ecs_set_node.node_three1 = Convert.ToInt32(request["node_three1"]);
                ecs_set_node.node_three2 = Convert.ToInt32(request["node_three2"]);
                ecs_set_node.node_four1 = Convert.ToInt32(request["node_four1"]);
                ecs_set_node.node_four2 = Convert.ToInt32(request["node_four2"]);
                ecs_set_node.telnum1 = Convert.ToInt32(request["telnum1"]);
                ecs_set_node.telnum2 = Convert.ToInt32(request["telnum2"]);
                ecs_set_node.telnum3 = Convert.ToInt32(request["telnum3"]);
                ecs_set_node.telnum4 = Convert.ToInt32(request["telnum4"]);

                ecs_set_nodeService.Update(ecs_set_node);
                context.Response.Write("2");
            }
            else if (request["Action"] == "deleteNode")
            {
                int node_id = Convert.ToInt32(request["node_id"]);

                ecs_set_nodeService.Delete(node_id);
                context.Response.Write("4");
            } 
            #endregion
                                        
            #region 奖金设置
            else if (request["Action"] == "getBonus")
            {
                DataSet ds = ecs_set_bonusService.GetList("");
                //string wcl = ",";
                //if (ds.Tables[0].Rows.Count>0)
                //{
                //    string team_dabiao = ds.Tables[0].Rows[0]["team_dabiao"].ToString();
                //    //char[] fg = "\";".ToCharArray();
                //    //string[] wcl100=team_dabiao.Split(fg);
                //    string[] wcl100 = Regex.Split(team_dabiao, "\";", RegexOptions.IgnoreCase);
                //    for (int i = 0; i < wcl100.Length-1; i++)
                //    {
                //        int ii=wcl100[i].IndexOf("i:");
                //        int ff=wcl100[i].IndexOf(";");
                //        string depid=wcl100[i].Substring(ii+2,ff-ii-2);
                //        string depid100 = "p" + depid + "_100";

                //        int yy=wcl100[i].IndexOf("\"");
                //        string vv=wcl100[i].Substring(yy+1,wcl100[i].Length-yy-1);
                //        string zz = "\"" + depid100 + "\":\"" + vv + "\"";
                //        wcl+=zz+",";
                //    }

                //    string team_dabiao2 = ds.Tables[0].Rows[0]["team_dabiao2"].ToString();
                //    //char[] fg = "\";".ToCharArray();
                //    //string[] wcl100=team_dabiao.Split(fg);
                //    string[] wcl90 = Regex.Split(team_dabiao2, "\";", RegexOptions.IgnoreCase);
                //    for (int i = 0; i < wcl90.Length-1; i++)
                //    {
                //        int ii = wcl90[i].IndexOf("i:");
                //        int ff = wcl90[i].IndexOf(";");
                //        string depid = wcl90[i].Substring(ii + 2, ff - ii - 2);
                //        string depid90 = "p"+depid + "_90";

                //        int yy = wcl90[i].IndexOf("\"");
                //        string vv = wcl90[i].Substring(yy + 1, wcl90[i].Length - yy - 1);
                //        string zz = "\"" + depid90 + "\":\"" + vv + "\"";
                //        wcl += zz + ",";
                //    }

                //}
                string dt = Common.GetGridJSON.DataTableToJSON(ds.Tables[0]);
                //string dt_wcl = dt.Substring(0, dt.Length - 15)+wcl.TrimEnd(',')+dt.Substring(dt.Length-15,15);
                context.Response.Write(dt);
            }
            else if (request["Action"] == "updateBonus")
            {

                ecs_set_bonus.id = Convert.ToInt32(request["id"]);
                ecs_set_bonus.one_bonus = Convert.ToInt32(request["one_bonus"]);
                ecs_set_bonus.two_bonus = Convert.ToInt32(request["two_bonus"]);
                ecs_set_bonus.three_bonus = Convert.ToInt32(request["three_bonus"]);
                ecs_set_bonus.four_bonus = Convert.ToInt32(request["four_bonus"]);
                ecs_set_bonus.week_one_bonus = Convert.ToInt32(request["week_one_bonus"]);
                ecs_set_bonus.week_two_bonus = Convert.ToInt32(request["week_two_bonus"]);
                ecs_set_bonus.week_three_bonus = Convert.ToInt32(request["week_three_bonus"]);
                ecs_set_bonus.week_four_bonus = Convert.ToInt32(request["week_four_bonus"]);
                ecs_set_bonus.month_bonus = Convert.ToInt32(request["month_bonus"]);
                ecs_set_bonus.team_one_bonus = Convert.ToInt32(request["team_one_bonus"]);
                ecs_set_bonus.team_two_bonus = Convert.ToInt32(request["team_two_bonus"]);
                ecs_set_bonus.team_three_bonus = Convert.ToInt32(request["team_three_bonus"]);
                ecs_set_bonus.team_four_bonus = Convert.ToInt32(request["team_four_bonus"]);
                ecs_set_bonus.team_month_bonus = Convert.ToInt32(request["team_month_bonus"]);

                //string p18_100 = request["p18_100"];
                //string p20_100 = request["p20_100"];
                //string p64_100 = request["p64_100"];
                //string p82_100 = request["p82_100"];
                //string p96_100 = request["p96_100"];
                //string p114_100 = request["p114_100"];
                //string p115_100 = request["p115_100"];
                //string wcl100 = "a:7:{i:18;s:4:\"" + p18_100 + "\";i:20;s:4:\"" + p20_100 + "\";i:64;s:4:\"" + p64_100 + "\";i:82;s:4:\"" + p82_100 + "\";i:96;s:4:\"" + p96_100 + "\";i:114;s:4:\"" + p114_100 + "\";i:115;s:4:\"" + p115_100 + "\";}";

                //string p18_90 = request["p18_90"];
                //string p20_90 = request["p20_90"];
                //string p64_90 = request["p64_90"];
                //string p82_90 = request["p82_90"];
                //string p96_90 = request["p96_90"];
                //string p114_90 = request["p114_90"];
                //string p115_90 = request["p115_90"];
                //string wcl90 = "a:7:{i:18;s:4:\"" + p18_90 + "\";i:20;s:4:\"" + p20_90 + "\";i:64;s:4:\"" + p64_90 + "\";i:82;s:4:\"" + p82_90 + "\";i:96;s:4:\"" + p96_90 + "\";i:114;s:4:\"" + p114_90 + "\";i:115;s:4:\"" + p115_90 + "\";}";

                ecs_set_bonus.team_dabiao = "a:7:{i:18;s:4:\"1750\";i:20;s:4:\"2125\";i:64;s:4:\"1750\";i:82;s:4:\"1750\";i:96;s:4:\"1500\";i:114;s:4:\"2000\";i:115;s:4:\"1125\";}";
                ecs_set_bonus.team_dabiao2 = "a:7:{i:18;s:4:\"1000\";i:20;s:4:\"1000\";i:64;s:4:\"1000\";i:82;s:4:\"1000\";i:96;s:4:\"1000\";i:114;s:4:\"1000\";i:115;s:3:\"750\";}";

                ecs_set_bonusService.Update(ecs_set_bonus);
                context.Response.Write("2");
            } 
            #endregion
                            
            #region 薪资等级
            else if (request["Action"] == "getSaleParameters")
            {
                DataSet ds = ecs_sale_parametersService.GetList("");
                context.Response.Write(Common.GetGridJSON.DataTableToJSON(ds.Tables[0]));
            }
            else if (request["Action"] == "updateSaleParameters")
            {

                ecs_sale_parameters.sale_id = Convert.ToInt32(request["sale_id"]);
                ecs_sale_parameters.c1 = Convert.ToInt32(request["c1"]);
                ecs_sale_parameters.cus_numc1 = Convert.ToInt32(request["cus_numc1"]);
                ecs_sale_parameters.sale_numc1 = Convert.ToInt32(request["sale_numc1"]);

                ecs_sale_parameters.c2 = Convert.ToInt32(request["c2"]);
                ecs_sale_parameters.cus_numc2 = Convert.ToInt32(request["cus_numc2"]);
                ecs_sale_parameters.sale_numc2 = Convert.ToInt32(request["sale_numc2"]);

                ecs_sale_parameters.szone = Convert.ToInt32(request["szone"]);
                ecs_sale_parameters.cus_num0 = Convert.ToInt32(request["cus_num0"]);
                ecs_sale_parameters.cus_num0_2 = Convert.ToInt32(request["cus_num0_2"]);
                ecs_sale_parameters.sale_num0 = Convert.ToInt32(request["sale_num0"]);
                ecs_sale_parameters.sale_num0_2 = Convert.ToInt32(request["sale_num0_2"]);

                ecs_sale_parameters.sone = Convert.ToInt32(request["sone"]);
                ecs_sale_parameters.cus_num1 = Convert.ToInt32(request["cus_num1"]);
                ecs_sale_parameters.cus_num1_2 = Convert.ToInt32(request["cus_num1_2"]);
                ecs_sale_parameters.sale_num1 = Convert.ToInt32(request["sale_num1"]);
                ecs_sale_parameters.sale_num1_2 = Convert.ToInt32(request["sale_num1_2"]);

                ecs_sale_parameters.stwo = Convert.ToInt32(request["stwo"]);
                ecs_sale_parameters.cus_num2 = Convert.ToInt32(request["cus_num2"]);
                ecs_sale_parameters.cus_num2_2 = Convert.ToInt32(request["cus_num2_2"]);
                ecs_sale_parameters.sale_num2 = Convert.ToInt32(request["sale_num2"]);
                ecs_sale_parameters.sale_num2_2 = Convert.ToInt32(request["sale_num2_2"]);

                ecs_sale_parameters.sthree = Convert.ToInt32(request["sthree"]);
                ecs_sale_parameters.cus_num3 = Convert.ToInt32(request["cus_num3"]);
                ecs_sale_parameters.cus_num3_2 = Convert.ToInt32(request["cus_num3_2"]);
                ecs_sale_parameters.sale_num3 = Convert.ToInt32(request["sale_num3"]);
                ecs_sale_parameters.sale_num3_2 = Convert.ToInt32(request["sale_num3_2"]);

                ecs_sale_parameters.sfour = Convert.ToInt32(request["sfour"]);
                ecs_sale_parameters.cus_num4 = Convert.ToInt32(request["cus_num4"]);
                ecs_sale_parameters.cus_num4_2 = Convert.ToInt32(request["cus_num4_2"]);
                ecs_sale_parameters.sale_num4 = Convert.ToInt32(request["sale_num4"]);
                ecs_sale_parameters.sale_num4_2 = Convert.ToInt32(request["sale_num4_2"]);

                ecs_sale_parameters.sfive = Convert.ToInt32(request["sfive"]);
                ecs_sale_parameters.cus_num5 = Convert.ToInt32(request["cus_num5"]);
                ecs_sale_parameters.cus_num5_2 = Convert.ToInt32(request["cus_num5_2"]);
                ecs_sale_parameters.sale_num5 = Convert.ToInt32(request["sale_num5"]);
                ecs_sale_parameters.sale_num5_2 = Convert.ToInt32(request["sale_num5_2"]);

                ecs_sale_parameters.ssix = Convert.ToInt32(request["ssix"]);
                ecs_sale_parameters.cus_num6 = Convert.ToInt32(request["cus_num6"]);
                ecs_sale_parameters.cus_num6_2 = Convert.ToInt32(request["cus_num6_2"]);
                ecs_sale_parameters.sale_num6 = Convert.ToInt32(request["sale_num6"]);
                ecs_sale_parameters.sale_num6_2 = Convert.ToInt32(request["sale_num6_2"]);

                ecs_sale_parameters.zdy = Convert.ToInt32(request["zdy"]);
                ecs_sale_parameters.cus_num7 = Convert.ToInt32(request["cus_num7"]);
                ecs_sale_parameters.sale_num7 = Convert.ToInt32(request["sale_num7"]);

                ecs_sale_parametersService.Update(ecs_sale_parameters);
                context.Response.Write("2");
            } 
            #endregion
            
            #region 品牌提成设置
            else if (request["Action"] == "getBrandPercentage")
            {
                string year = PageValidate.InputText(request["syear"], int.MaxValue);
                string strWhere = "";
                if (!string.IsNullOrEmpty(year))
                {
                    strWhere = " bp_year = " + year;
                }
                else
                {
                    year = dtNow.Year.ToString();
                    strWhere = " bp_year = " + dtNow.Year;
                }

                DataSet ds = ecs_brand_percentageService.GetList(strWhere);
                context.Response.Write(Common.GetGridJSON.DataTableToJSON(ds.Tables[0]));
            }
            else if (request["Action"] == "addBrandPercentage")
            {
                string year = PageValidate.InputText(request["syear"], int.MaxValue);
                string bp_brand_name = request["bp_brand_name"];
                DataSet dsbrand = ecs_brandService.GetList("brand_name='" + bp_brand_name + "'");
                if (dsbrand.Tables[0].Rows.Count > 0)
                {
                    int brand_id = Convert.ToInt32(dsbrand.Tables[0].Rows[0]["brand_id"].ToString());

                    string whereStr = " bp_brand_id=" + brand_id + " and bp_year=" + year;
                    DataSet ds = ecs_brand_percentageService.GetList(whereStr);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        context.Response.Write("0");//已存在该品牌提成
                    }
                    else
                    {
                        ecs_brand_percentage.bp_brand_id = brand_id;
                        ecs_brand_percentage.bp_brand_name = request["bp_brand_name"];
                        ecs_brand_percentage.bp_percentage = Convert.ToDecimal(request["bp_percentage"]);
                        ecs_brand_percentage.bp_year = year;
                        ecs_brand_percentageService.Add(ecs_brand_percentage);
                        context.Response.Write("1");//添加成功
                    }
                }
                else
                {
                    context.Response.Write("3");//品牌名不正确
                }
            }
            else if (request["Action"] == "updateBrandPercentage")
            {
                string year = PageValidate.InputText(request["syear"], int.MaxValue);
                ecs_brand_percentage.bp_id = Convert.ToInt32(request["bp_id"]);
                ecs_brand_percentage.bp_brand_id = Convert.ToInt32(request["bp_brand_id"]);
                ecs_brand_percentage.bp_brand_name = request["bp_brand_name"];
                ecs_brand_percentage.bp_percentage = Convert.ToDecimal(request["bp_percentage"]);
                ecs_brand_percentage.bp_year = year;
                ecs_brand_percentageService.Update(ecs_brand_percentage);
                context.Response.Write("2");
            }
            else if (request["Action"] == "deleteBrandPercentage")
            {
                int bp_id = Convert.ToInt32(request["bp_id"]);
                ecs_brand_percentageService.Delete(bp_id);
                context.Response.Write("4");
            } 
            #endregion

            #region 品牌经理设置
            else if (request["Action"] == "getBrandManager")
            {
                DataSet ds = dms_brand_managerService.GetList("");
                context.Response.Write(Common.GetGridJSON.DataTableToJSON(ds.Tables[0]));
            }
            else if (request["Action"] == "addBrandManager")
            {
                string brand_name = request["brand_name"];
                DataSet dsBrand = ecs_brandService.GetList("brand_name='" + brand_name + "'");

                string emp_code_name = request["name"];
                DataSet dsEmp = hr_employeeService.GetList("name='" + emp_code_name + "'");

                if (dsBrand.Tables[0].Rows.Count > 0 && dsEmp.Tables[0].Rows.Count > 0)
                {
                    string brand_id = dsBrand.Tables[0].Rows[0]["brand_id"].ToString();
                    string emp_code_id = dsEmp.Tables[0].Rows[0]["emp_code"].ToString();

                    string whereStr = " brand_id=" + brand_id;
                    DataSet ds = dms_brand_managerService.GetList(whereStr);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        context.Response.Write("0");//已存在该品牌提成
                    }
                    else
                    {
                        dms_brand_manager.emp_code = emp_code_id;
                        dms_brand_manager.name = emp_code_name;
                        dms_brand_manager.brand_id = brand_id;
                        dms_brand_manager.brand_name = brand_name;
                        dms_brand_manager.brand_base = Convert.ToDecimal(request["brand_base"]);
                        dms_brand_manager.brand_plan = Convert.ToDecimal(request["brand_plan"]);
                        dms_brand_manager.create_time = DateTime.Now;
                        dms_brand_manager.create_name = emp_code;
                        dms_brand_manager.factory_id = factory_Id;
                        dms_brand_managerService.Add(dms_brand_manager);
                        context.Response.Write("1");//添加成功
                    }
                }
                else
                {
                    context.Response.Write("3");//品牌名不正确
                }
            }
            else if (request["Action"] == "updateBrandManager")
            {
                dms_brand_manager.id = Convert.ToInt32(request["id"]);
                dms_brand_manager.emp_code = request["emp_code"];
                dms_brand_manager.name = request["name"];
                dms_brand_manager.brand_id = request["brand_id"];
                dms_brand_manager.brand_name = request["brand_name"];
                dms_brand_manager.brand_base = Convert.ToDecimal(request["brand_base"]);
                dms_brand_manager.brand_plan = Convert.ToDecimal(request["brand_plan"]);
                dms_brand_manager.create_time = DateTime.Now;
                dms_brand_manager.create_name = emp_code;
                dms_brand_manager.factory_id = factory_Id;
                dms_brand_managerService.Update(dms_brand_manager);
                context.Response.Write("2");
            }
            else if (request["Action"] == "deleteBrandManager")
            {
                int _id = Convert.ToInt32(request["id"]);
                dms_brand_managerService.Delete(_id);
                context.Response.Write("4");
            } 
            #endregion
            
            #region 总计划设置
            else if (request["Action"] == "getTotalPlan")
            {
                DataSet ds = ecs_total_planService.GetList("");
                context.Response.Write(Common.GetGridJSON.DataTableToJSON(ds.Tables[0]));
            }
            else if (request["Action"] == "updateTotalPlan")
            {

                ecs_total_plan.plan_id = Convert.ToInt32(request["plan_id"]);
                ecs_total_plan.plan_task = request["plan_task"];
                ecs_total_plan.plan_divide = Convert.ToInt32(request["plan_divide"]);
                ecs_total_plan.plan_jan = request["plan_jan"];
                ecs_total_plan.plan_feb = request["plan_feb"];
                ecs_total_plan.plan_mar = request["plan_mar"];
                ecs_total_plan.plan_apr = request["plan_apr"];
                ecs_total_plan.plan_may = request["plan_may"];
                ecs_total_plan.plan_jun = request["plan_jun"];
                ecs_total_plan.plan_jul = request["plan_jul"];
                ecs_total_plan.plan_aug = request["plan_aug"];
                ecs_total_plan.plan_sep = request["plan_sep"];
                ecs_total_plan.plan_oct = request["plan_oct"];
                ecs_total_plan.plan_nov = request["plan_nov"];
                ecs_total_plan.plan_dec = request["plan_dec"];

                ecs_total_planService.Update(ecs_total_plan);
                context.Response.Write("2");
            }
            
            #endregion
            
            #region 年基数
            if (request["Action"] == "getMonthBase")
            {
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);

                string year = request["syear"];
                int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                string sortname = request["sortname"];
                string sortorder = request["sortorder"];

                if (string.IsNullOrEmpty(sortname))
                    sortname = " plan_id";
                if (string.IsNullOrEmpty(sortorder))
                    sortorder = " ";
                string sorttext = " " + sortname + " " + sortorder;
                string Total;

                string strWhere = " kf_uname in(" + getEmpCodes(idlist, emp_id, factory_Id) + ")";
                if (!string.IsNullOrEmpty(year))
                {
                    strWhere += " and plan_year = " + year;
                }
                else
                {
                    year = dtNow.Year.ToString();
                    strWhere += " and plan_year = " + dtNow.Year;
                }

                DataSet ds = ecs_month_baseService.GetList(PageSize, PageIndex, strWhere, sorttext, out Total);
                string reJosn = Common.GetGridJSON.DataTableToJSON1(ds.Tables[0], Total);
                context.Response.Write(reJosn);

            }

            else if (request["Action"] == "addMonthBase")
            {
                string year = request["syear"];
                string kf_uname = request["kf_uname"];
                kf_uname = getEmpCodes(kf_uname, emp_id, factory_Id).Replace("'", "");
                if (kf_uname == "")
                {
                    context.Response.Write("6");
                    return;
                }
                string whereStr = " kf_uname=" + kf_uname + " and plan_year=" + year;
                DataSet ds = ecs_month_baseService.GetList(whereStr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    context.Response.Write("0");
                }
                else
                {
                    ecs_month_base.plan_task = request["plan_task"];
                    ecs_month_base.plan_jan = request["plan_jan"];
                    ecs_month_base.plan_feb = request["plan_feb"];
                    ecs_month_base.plan_mar = request["plan_mar"];
                    ecs_month_base.plan_apr = request["plan_apr"];
                    ecs_month_base.plan_may = request["plan_may"];
                    ecs_month_base.plan_jun = request["plan_jun"];
                    ecs_month_base.plan_jul = request["plan_jul"];
                    ecs_month_base.plan_aug = request["plan_aug"];
                    ecs_month_base.plan_sep = request["plan_sep"];
                    ecs_month_base.plan_oct = request["plan_oct"];
                    ecs_month_base.plan_nov = request["plan_nov"];
                    ecs_month_base.plan_dec = request["plan_dec"];

                    ecs_month_base.kf_rname = request["kf_rname"];
                    ecs_month_base.kf_uname = kf_uname;
                    ecs_month_base.plan_year = year;

                    ecs_month_baseService.Add(ecs_month_base);
                    context.Response.Write("1");
                }


            }
            else if (request["Action"] == "updateMonthBase")
            {
                ecs_month_base.plan_id = Convert.ToInt32(request["plan_id"]);

                ecs_month_base.plan_task = request["plan_task"];
                ecs_month_base.plan_jan = request["plan_jan"];
                ecs_month_base.plan_feb = request["plan_feb"];
                ecs_month_base.plan_mar = request["plan_mar"];
                ecs_month_base.plan_apr = request["plan_apr"];
                ecs_month_base.plan_may = request["plan_may"];
                ecs_month_base.plan_jun = request["plan_jun"];
                ecs_month_base.plan_jul = request["plan_jul"];
                ecs_month_base.plan_aug = request["plan_aug"];
                ecs_month_base.plan_sep = request["plan_sep"];
                ecs_month_base.plan_oct = request["plan_oct"];
                ecs_month_base.plan_nov = request["plan_nov"];
                ecs_month_base.plan_dec = request["plan_dec"];
                ecs_month_base.kf_rname = request["kf_rname"];
                ecs_month_base.kf_uname = request["kf_uname"];
                ecs_month_base.plan_year = request["plan_year"];


                ecs_month_baseService.Update(ecs_month_base);
                context.Response.Write("2");
            }
            else if (request["Action"] == "deleteMonthBase")
            {
                int plan_id = Convert.ToInt32(request["plan_id"]);

                ecs_month_baseService.Delete(plan_id);
                context.Response.Write("4");
            }
            #endregion
            
            #region 年计划
            if (request["Action"] == "getPerPlan")
            {
                string year = request["syear"];
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);

                int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                string sortname = request["sortname"];
                string sortorder = request["sortorder"];

                if (string.IsNullOrEmpty(sortname))
                    sortname = " plan_id";
                if (string.IsNullOrEmpty(sortorder))
                    sortorder = " ";
                string sorttext = " " + sortname + " " + sortorder;
                string Total;

                string strWhere = " kf_uname in(" + getEmpCodes(idlist, emp_id, factory_Id) + ")";
                if (!string.IsNullOrEmpty(year))
                {
                    strWhere += " and plan_year = " + year;
                }
                else
                {
                    year = dtNow.Year.ToString();
                    strWhere += " and plan_year = " + dtNow.Year;
                }

                DataSet ds = ecs_per_planService.GetList(PageSize, PageIndex, strWhere, sorttext, out Total);
                string reJosn = Common.GetGridJSON.DataTableToJSON1(ds.Tables[0], Total);
                context.Response.Write(reJosn);

            }
            else if (request["Action"] == "addPerPlan")
            {
                string year = request["syear"];
                string kf_uname = request["kf_uname"];
                kf_uname = getEmpCodes(kf_uname, emp_id, factory_Id).Replace("'", "");
                if (kf_uname == "")
                {
                    context.Response.Write("6");
                }
                string whereStr = " kf_uname=" + kf_uname + " and plan_year=" + year;
                DataSet ds = ecs_per_planService.GetList(whereStr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    context.Response.Write("0");
                    return;
                }
                else
                {
                    ecs_per_plan.plan_task = request["plan_task"];
                    ecs_per_plan.plan_jan = request["plan_jan"];
                    ecs_per_plan.plan_feb = request["plan_feb"];
                    ecs_per_plan.plan_mar = request["plan_mar"];
                    ecs_per_plan.plan_apr = request["plan_apr"];
                    ecs_per_plan.plan_may = request["plan_may"];
                    ecs_per_plan.plan_jun = request["plan_jun"];
                    ecs_per_plan.plan_jul = request["plan_jul"];
                    ecs_per_plan.plan_aug = request["plan_aug"];
                    ecs_per_plan.plan_sep = request["plan_sep"];
                    ecs_per_plan.plan_oct = request["plan_oct"];
                    ecs_per_plan.plan_nov = request["plan_nov"];
                    ecs_per_plan.plan_dec = request["plan_dec"];

                    ecs_per_plan.kf_rname = request["kf_rname"];
                    ecs_per_plan.kf_uname = kf_uname;
                    ecs_per_plan.plan_year = year;

                    ecs_per_planService.Add(ecs_per_plan);
                    context.Response.Write("1");
                }
            }
            else if (request["Action"] == "updatePerPlan")
            {
                ecs_per_plan.plan_id = Convert.ToInt32(request["plan_id"]);

                ecs_per_plan.plan_task = request["plan_task"];
                ecs_per_plan.plan_jan = request["plan_jan"];
                ecs_per_plan.plan_feb = request["plan_feb"];
                ecs_per_plan.plan_mar = request["plan_mar"];
                ecs_per_plan.plan_apr = request["plan_apr"];
                ecs_per_plan.plan_may = request["plan_may"];
                ecs_per_plan.plan_jun = request["plan_jun"];
                ecs_per_plan.plan_jul = request["plan_jul"];
                ecs_per_plan.plan_aug = request["plan_aug"];
                ecs_per_plan.plan_sep = request["plan_sep"];
                ecs_per_plan.plan_oct = request["plan_oct"];
                ecs_per_plan.plan_nov = request["plan_nov"];
                ecs_per_plan.plan_dec = request["plan_dec"];
                ecs_per_plan.kf_rname = request["kf_rname"];
                ecs_per_plan.kf_uname = request["kf_uname"];
                ecs_per_plan.plan_year = request["plan_year"];


                ecs_per_planService.Update(ecs_per_plan);
                context.Response.Write("2");
            }
            else if (request["Action"] == "deletePerPlan")
            {
                int plan_id = Convert.ToInt32(request["plan_id"]);

                ecs_per_planService.Delete(plan_id);
                context.Response.Write("4");
            }
            #endregion            

            #region 年评比
            if (request["Action"] == "getSetRating")
            {
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);

                string year = request["syear"];
                int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                string sortname = request["sortname"];
                string sortorder = request["sortorder"];

                if (string.IsNullOrEmpty(sortname))
                    sortname = " plan_id";
                if (string.IsNullOrEmpty(sortorder))
                    sortorder = " ";
                string sorttext = " " + sortname + " " + sortorder;
                string Total;

                string strWhere = " kf_uname in(" + getEmpCodes(idlist, emp_id, factory_Id) + ")";
                if (!string.IsNullOrEmpty(year))
                {
                    strWhere += " and plan_year = " + year;
                }
                else
                {
                    year = dtNow.Year.ToString();
                    strWhere += " and plan_year = " + dtNow.Year;
                }

                DataSet ds = dms_set_ratingService.GetList(PageSize, PageIndex, strWhere, sorttext, out Total);
                string reJosn = Common.GetGridJSON.DataTableToJSON1(ds.Tables[0], Total);
                context.Response.Write(reJosn);

            }

            else if (request["Action"] == "addSetRating")
            {
                string year = request["syear"];
                string kf_uname = request["kf_uname"];
                kf_uname = getEmpCodes(kf_uname, emp_id, factory_Id).Replace("'", "");
                if (kf_uname == "")
                {
                    context.Response.Write("6");
                    return;
                }
                string whereStr = " kf_uname=" + kf_uname + " and plan_year=" + year;
                DataSet ds = dms_set_ratingService.GetList(whereStr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    context.Response.Write("0");
                }
                else
                {
                    dms_set_rating.plan_task = request["plan_task"];
                    dms_set_rating.plan_jan = request["plan_jan"];
                    dms_set_rating.plan_feb = request["plan_feb"];
                    dms_set_rating.plan_mar = request["plan_mar"];
                    dms_set_rating.plan_apr = request["plan_apr"];
                    dms_set_rating.plan_may = request["plan_may"];
                    dms_set_rating.plan_jun = request["plan_jun"];
                    dms_set_rating.plan_jul = request["plan_jul"];
                    dms_set_rating.plan_aug = request["plan_aug"];
                    dms_set_rating.plan_sep = request["plan_sep"];
                    dms_set_rating.plan_oct = request["plan_oct"];
                    dms_set_rating.plan_nov = request["plan_nov"];
                    dms_set_rating.plan_dec = request["plan_dec"];

                    dms_set_rating.kf_rname = request["kf_rname"];
                    dms_set_rating.kf_uname = kf_uname;
                    dms_set_rating.plan_year = year;

                    dms_set_ratingService.Add(dms_set_rating);
                    context.Response.Write("1");
                }


            }
            else if (request["Action"] == "updateSetRating")
            {
                dms_set_rating.plan_id = Convert.ToInt32(request["plan_id"]);

                dms_set_rating.plan_task = request["plan_task"];
                dms_set_rating.plan_jan = request["plan_jan"];
                dms_set_rating.plan_feb = request["plan_feb"];
                dms_set_rating.plan_mar = request["plan_mar"];
                dms_set_rating.plan_apr = request["plan_apr"];
                dms_set_rating.plan_may = request["plan_may"];
                dms_set_rating.plan_jun = request["plan_jun"];
                dms_set_rating.plan_jul = request["plan_jul"];
                dms_set_rating.plan_aug = request["plan_aug"];
                dms_set_rating.plan_sep = request["plan_sep"];
                dms_set_rating.plan_oct = request["plan_oct"];
                dms_set_rating.plan_nov = request["plan_nov"];
                dms_set_rating.plan_dec = request["plan_dec"];
                dms_set_rating.kf_rname = request["kf_rname"];
                dms_set_rating.kf_uname = request["kf_uname"];
                dms_set_rating.plan_year = request["plan_year"];


                dms_set_ratingService.Update(dms_set_rating);
                context.Response.Write("2");
            }
            else if (request["Action"] == "deleteSetRating")
            {
                int plan_id = Convert.ToInt32(request["plan_id"]);

                dms_set_ratingService.Delete(plan_id);
                context.Response.Write("4");
            }
            #endregion

            #region 排除评比
            if (request["Action"] == "getSetExclude")
            {

                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);

                string year = request["syear"];
                int PageIndex = int.Parse(request["page"] == null ? "1" : request["page"]);
                int PageSize = int.Parse(request["pagesize"] == null ? "30" : request["pagesize"]);
                string sortname = request["sortname"];
                string sortorder = request["sortorder"];

                if (string.IsNullOrEmpty(sortname))
                    sortname = " convert(exclude_did,signed) ";
                if (string.IsNullOrEmpty(sortorder))
                    sortorder = " ";
                string sorttext = " " + sortname + " " + sortorder;
                string Total;

                string strWhere = " ";

                DataSet ds = dms_set_excludeService.GetList(PageSize, PageIndex, strWhere, sorttext, out Total);
                string reJosn = Common.GetGridJSON.DataTableToJSON1(ds.Tables[0], Total);
                context.Response.Write(reJosn);

            }
            else if (request["Action"] == "addSetExclude")
            {
                string idlist = PageValidate.InputText(request["idlist"], int.MaxValue);
                string exclude_id = getEmpCodes(idlist, emp_id, factory_Id);
                DataSet dspc = dms_set_excludeService.GetList("exclude_emp_code in(" + exclude_id + ")");
                if (dspc==null || dspc.Tables[0].Rows.Count>0)
                {
                    context.Response.Write("0");
                }
                else
                {
                    DataSet ds = hr_employeeService.GetList("emp_code in(" + exclude_id + ")");
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dms_set_exclude.exclude_emp_code = ds.Tables[0].Rows[i]["emp_code"].ToString();
                        dms_set_exclude.exclude_emp_name = ds.Tables[0].Rows[i]["name"].ToString();
                        dms_set_exclude.exclude_did = ds.Tables[0].Rows[i]["d_id"].ToString();
                        dms_set_exclude.exclude_dname = ds.Tables[0].Rows[i]["dname"].ToString();
                        dms_set_exclude.create_time = DateTime.Now;
                        dms_set_exclude.create_name = emp_code;
                        dms_set_exclude.factory_id = factory_Id;
                        dms_set_excludeService.Add(dms_set_exclude);
                    }

                    context.Response.Write("1");
                }

            }
            else if (request["Action"] == "deleteSetExclude")
            {
                string idlist = PageValidate.InputText(request["id"], int.MaxValue);
                dms_set_excludeService.DeleteList(idlist);
                context.Response.Write("4");
            }
            #endregion

            #region 团队奖达标奖励
            if (request["Action"] == "getSetBonusTeam")
            {
                DataSet ds = dms_set_bonus_teamService.GetList("");
                context.Response.Write(Common.GetGridJSON.DataTableToJSON(ds.Tables[0]));

            }
            else if (request["Action"] == "addBonusTeam")
            {
                int bonus_d_id = Convert.ToInt32(request["d_id"]);
                string whereStr = " d_id=" + bonus_d_id;
                DataSet ds = dms_set_bonus_teamService.GetList(whereStr);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    context.Response.Write("0");
                    return;
                }
                else
                {
                    dms_set_bonus_team.db_90 = Convert.ToInt32(request["db_90"]);
                    dms_set_bonus_team.db_100 = Convert.ToInt32(request["db_100"]);

                    dms_set_bonus_team.d_name = request["d_name"];
                    dms_set_bonus_team.d_id = bonus_d_id;

                    dms_set_bonus_teamService.Add(dms_set_bonus_team);
                    context.Response.Write("1");
                }


            }
            else if (request["Action"] == "updateBonusTeam")
            {
                dms_set_bonus_team.db_90 = Convert.ToInt32(request["db_90"]);
                dms_set_bonus_team.db_100 = Convert.ToInt32(request["db_100"]);

                dms_set_bonus_team.d_name = request["d_name"];
                dms_set_bonus_team.d_id = Convert.ToInt32(request["d_id"]);
                dms_set_bonus_team.id = Convert.ToInt32(request["id"]);


                dms_set_bonus_teamService.Update(dms_set_bonus_team);
                context.Response.Write("2");
            }
            else if (request["Action"] == "deleteBonusTeam")
            {
                int bonusTeam_id = Convert.ToInt32(request["id"]);

                dms_set_bonus_teamService.Delete(bonusTeam_id);
                context.Response.Write("4");
            }
            #endregion
            
        }

        #region 获取权限下工号
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

        #region 获取权限下where条件
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