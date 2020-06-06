﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using XHD.DBUtility;

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:dmsDAO
    /// </summary>
    public partial class dmsDAO
    {
        #region 日异常单
        //用于更新页面
        public DataSet GetDateAbnormal_count(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) abnormal_count ,sum(ab.status) sum_status,sum(goods_amount) order_sum from ( ");
            strSql.Append(" select substring_index(substring_index(admin_user_name, '(', -1), ')', 1) admin_user_name,status from xmh_shop.shop_order_abnormal ");
            strSql.Append(" where pause_time BETWEEN 1482808320 AND 1484703365 ");//pause_time between " + startTime + " and " + endTime
            strSql.Append(" ) ab  ");
            strSql.Append(" left join hr_employee emp on emp.emp_code=ab.admin_user_name ");
            strSql.Append(" left join xmh_shop.shop_order_info oi on ab.order_sn=oi.order_sn  ");
            strSql.Append(" where " + returnSqlTxt);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //是否处理完成 1完成 0未处理
        public DataSet GetDateAbnormal_status(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select count(1) status_count,status_name from (  ");
            strSql.Append(" select substring_index(substring_index(admin_user_name, '(', -1), ')', 1) admin_user_name,case status when 1 then '完成' else '未完成' end status_name ");
            strSql.Append("  from xmh_shop.shop_order_abnormal  ");
            strSql.Append("  where pause_time BETWEEN 1483808320 AND 1484703365   ");
            strSql.Append(" ) ab  ");
            strSql.Append(" left join hr_employee emp on emp.emp_code=ab.admin_user_name ");
            strSql.Append(" where " + returnSqlTxt);
            strSql.Append(" group by ab.status ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //暂停类型
        public DataSet GetDateAbnormal_type(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("  select status_count,order_sum,pause_type from (   ");
            strSql.Append("  select  count(1) status_count,sum(goods_amount) order_sum,pause_type from (  ");
            strSql.Append("  select order_sn,substring_index(substring_index(admin_user_name, '(', -1), ')', 1) admin_user_name,pause_type from xmh_shop.shop_order_abnormal   ");
            strSql.Append("  where pause_time BETWEEN 1483808320 AND 1484703365   ");
            strSql.Append(" ) ab  ");
            strSql.Append(" left join hr_employee emp on emp.emp_code=ab.admin_user_name ");
            strSql.Append(" left join xmh_shop.shop_order_info oi on ab.order_sn=oi.order_sn  ");
            strSql.Append(" where " + returnSqlTxt);
            strSql.Append(" group by pause_type,pause_reason )p ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //暂停原因
        public DataSet GetDateAbnormal_reason(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("  select status_count,order_sum,pause_type,pause_reason,code_name from (  ");
            strSql.Append("  select  count(1) status_count,sum(goods_amount) order_sum,pause_type,pause_reason from (  ");
            strSql.Append("  select order_sn,substring_index(substring_index(admin_user_name, '(', -1), ')', 1) admin_user_name,pause_type,pause_reason from xmh_shop.shop_order_abnormal  ");
            strSql.Append("  where pause_time BETWEEN 1483808320 AND 1484703365  ");
            strSql.Append(" ) ab  ");
            strSql.Append(" left join hr_employee emp on emp.emp_code=ab.admin_user_name ");
            strSql.Append(" left join xmh_shop.shop_order_info oi on ab.order_sn=oi.order_sn  ");
            strSql.Append(" where " + returnSqlTxt);
            strSql.Append(" group by pause_type,pause_reason )p ");
            strSql.Append(" left join xmh_shop.shop_base_code bc ");
            strSql.Append(" on bc.code_id=p.pause_reason and bc.type_no=p.pause_type ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //异常单数据
        public DataSet GetDateAbnormal(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select ab.*,goods_amount from( ");
            strSql.Append(" select order_sn,substring_index(substring_index(admin_user_name, '(', -1), ')', 1) admin_user_name, ");
            strSql.Append(" pause_user,pause_time,submit_user,submit_time,handle_user,handle_time, ");
            strSql.Append(" is_number_change,status,optype,pause_type,pause_reason from xmh_shop.shop_order_abnormal  ");
            strSql.Append(" where pause_time BETWEEN 1482808320 AND 1484703365 ");
            strSql.Append(" ) ab  ");
            strSql.Append(" left join hr_employee emp on emp.emp_code=ab.admin_user_name ");
            strSql.Append(" left join xmh_shop.shop_order_info oi on ab.order_sn=oi.order_sn ");
            strSql.Append(" where "+ returnSqlTxt);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion



        #region 日订单展示
        public DataSet GetDateOrder_count(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(status_count) order_count,sum(status_count*status_id) sum_status,sum(goods_amount) order_sum from (  ");
            strSql.Append(" select count(1) status_count,shipping_status status_id,sum(goods_amount) goods_amount ");
            strSql.Append(" from xmh_shop.shop_order_info oi ");
            strSql.Append(" left join hr_employee as emp on emp.emp_code=oi.admin_user_name ");
            strSql.Append(" where oi.order_status !=9 and erp_time between " + startTime + " and " + endTime + returnSqlTxt);
            strSql.Append(" group by shipping_status ");
            strSql.Append(" )aa ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //当日客户销售数据
        public DataSet GetDateOrder(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select order_sn,goods_amount,region_name,CONCAT(SUBSTR(C_name ,1,1),'**') C_name, C_tel,operator,referer, ");
            strSql.Append(" case shipping_status when 0 then '未发货' when 1 then '已发货' when 2 then '已收货' when 3 then '配货中' when 5 then '发货中' when 7 then '已配货' when 8 then '已验货' end shipping_status");
            strSql.Append(" ,case shipping_id when -1 then wuliu_name else shipping_name end sendway ");
            strSql.Append(" ,from_unixtime(oi.erp_time, '%H:%i:%S') as datetime  ");
            strSql.Append("  from xmh_shop.shop_order_info  oi ");
            strSql.Append(" left join crm_contact as u on oi.user_id=u.id ");
            strSql.Append(" left join param_area as a on oi.city=a.region_id ");
            strSql.Append(" left join hr_employee as emp on emp.emp_code=oi.admin_user_name ");
            strSql.Append(" where oi.order_status !=9 and erp_time between " + startTime + " and " + endTime + returnSqlTxt);
            strSql.Append(" order by order_sn ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //获取当日城市柱图
        public DataSet GetDateOrder_city(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select region_name city_name,sum(goods_amount) city_amount,count(1) city_count from xmh_shop.shop_order_info  oi ");
            strSql.Append(" left join param_area as a on oi.city=a.region_id");
            strSql.Append(" left join hr_employee as emp on emp.emp_code=oi.admin_user_name ");
            strSql.Append(" where oi.order_status !=9 and erp_time between " + startTime + " and " + endTime + returnSqlTxt);
            strSql.Append(" group by region_id ");
            strSql.Append(" order by city_amount desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //获取当日员工柱图
        public DataSet GetDateOrder_emp(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select name,sum(goods_amount) emp_amount,count(1) emp_count from xmh_shop.shop_order_info  oi  ");
            strSql.Append(" left join hr_employee as emp on emp.emp_code=oi.admin_user_name ");
            strSql.Append(" where oi.order_status !=9 and erp_time between " + startTime + " and " + endTime + returnSqlTxt);
            strSql.Append(" group by admin_user_name ");
            strSql.Append(" order by emp_amount desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //当日订单发货状态
        public DataSet GetDateOrder_status(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) status_count, ");
            strSql.Append(" case shipping_status when 0 then '未发货' when 1 then '已发货' when 2 then '已收货' when 3 then '配货中' when 5 then '发货中' when 7 then '已配货' when 8 then '已验货' end status_name");
            strSql.Append(" from xmh_shop.shop_order_info  oi ");
            strSql.Append(" left join hr_employee as emp on emp.emp_code=oi.admin_user_name ");
            strSql.Append(" where oi.order_status !=9 and erp_time between " + startTime + " and " + endTime + returnSqlTxt);
            strSql.Append(" group by shipping_status ");
            strSql.Append(" order by status_count ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //获取当日快递类别
        public DataSet GetDateOrder_shipping(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select shipping_id,shipping_name,count(1) shipping_count ");
            strSql.Append("  from xmh_shop.shop_order_info  oi");
            strSql.Append(" left join hr_employee as emp on emp.emp_code=oi.admin_user_name ");
            strSql.Append(" where oi.order_status !=9 and erp_time between " + startTime + " and " + endTime + returnSqlTxt);
            strSql.Append(" group by shipping_id  ");
            strSql.Append(" order by shipping_count desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //获取当日下单来源
        public DataSet GetDateOrder_referer(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) referer_count,referer from xmh_shop.shop_order_info  oi ");
            strSql.Append(" left join hr_employee as emp on emp.emp_code=oi.admin_user_name ");
            strSql.Append(" where oi.order_status !=9 and erp_time between " + startTime + " and " + endTime + returnSqlTxt);
            strSql.Append(" group by referer ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //获取当日小时汇总
        public DataSet GetDateOrder_hours(string startTime, string endTime, string returnSqlTxt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select hours,count(1) hours_count from( ");
            strSql.Append(" select CASE WHEN from_unixtime(oi.erp_time, '%H')>17 THEN 18 ELSE from_unixtime(oi.erp_time, '%H')END hours ");
            strSql.Append(" from xmh_shop.shop_order_info  oi ");
            strSql.Append(" left join hr_employee as emp on emp.emp_code=oi.admin_user_name ");
            strSql.Append(" where oi.order_status !=9 and erp_time between " + startTime + " and " + endTime + returnSqlTxt);
            strSql.Append(" ) tt group by hours ");
            strSql.Append(" order by hours desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion


        #region  迁徙3图
        //--------------------------------地图3---------------------------------------------------------------

        /// <summary>
        /// 获得当日城市订单curdate()
        /// </summary>
        public DataSet GetTodayCityAmt(string date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.region_name as name,sum(o.salemoney) as value from dms_order as o LEFT JOIN param_area as a on o.city=a.region_id ");
            strSql.Append("where datetime = '" + date + "' group by region_name order by value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得当日城市订单curdate()
        /// </summary>
        public DataSet GetCityAmt()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.region_name as name,sum(o.salemoney) as value from dms_order as o LEFT JOIN param_area as a on o.city=a.region_id ");
            strSql.Append("where region_name is not null group by name order by value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得当日省份订单curdate()
        /// </summary>
        public DataSet GetTodayProvinceAmt(string date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.region_name as name,sum(o.goods_amount) as value from xmh_shop.shop_order_info as o LEFT JOIN param_area as a on o.province=a.region_id ");
            strSql.Append(" WHERE order_status !=9 and erp_order_sn like 'XK-" + date.Replace("-","") + "%'  and erp_time<>0");
            strSql.Append(" group by name order by value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetTodayProvinceDms(string date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.region_name as name,sum(o.salemoney) as value from dms_order as o LEFT JOIN param_area as a on o.province=a.region_id ");
            strSql.Append("where datetime = '" + date + "' group by name order by value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet getMonthOrderCountData(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("  SELECT ");
            strSql.Append(" 	IFNULL(sum(goods_amount), 0) AS feat, ");
            strSql.Append(" 	count(order_id) orderNum, ");
            strSql.Append(" 	FROM_UNIXTIME(erp_time, '%y-%m-%d') AS date, ");
            strSql.Append(" 	FROM_UNIXTIME(erp_time, '%d') AS daytime ");
            strSql.Append(" FROM ");
            strSql.Append(" 	xmh_shop.shop_order_info ");
            strSql.Append(" WHERE order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%'  and erp_time<>0");
            //strSql.Append(" 	erp_time BETWEEN  " + starttime);
            //strSql.Append(" AND " + endtime);
            strSql.Append(" GROUP BY  FROM_UNIXTIME(erp_time, '%y-%m-%d') ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet getMonthOrderCountDms(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" select feat,orderNum,date,daytime,yearmonth ");
            strSql.Append(" from ");
            strSql.Append(" dms_order_count ");
            strSql.Append(" where yearmonth like '" + yearMonth + "%'");
            strSql.Append(" order by daytime ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 拼接sql语句
        #region 区域
        /// <summary>
        /// 拼接月份数据字符串，含省市
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <param name="provinceOrCity">省市</param>
        /// <returns></returns>
        public string GetAreaBrandSql(string yearMonth, string provinceOrCity)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("   select * from ( ");
            strSql.Append("   select province,city,oi.user_id,oi.admin_user_name,og.goods_price*og.goods_number AS salemoney,g.brand_id, ");
            strSql.Append("   case when bp_brand_id is null or bp_brand_id='' then 0 else bp_brand_id end bp_brand_id,g.goods_id,g.goods_name, ");
            strSql.Append("   from_unixtime(oi.erp_time, '%Y') AS orderyear,from_unixtime(oi.erp_time, '%m') AS ordermonth,from_unixtime(oi.erp_time, '%d') AS orderdate,from_unixtime(oi.erp_time, '%Y-%m-%d') as datetime ");
            strSql.Append("    from xmh_shop.shop_order_goods AS og ");
            strSql.Append("    left join xmh_shop.shop_goods AS g ON g.goods_id=og.goods_id ");
            strSql.Append("    left join xmh_shop.shop_order_info AS oi ON oi.order_id=og.order_id ");
            strSql.Append("    left join ecs_brand_percentage AS bp ON g.brand_id=bp.bp_brand_id and bp_year=" + yearMonth.Substring(0,4));
            strSql.Append("    where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%'  and erp_time<>0 " + provinceOrCity + ") aa where salemoney>0 ");

            return strSql.ToString();
        }
        #endregion

        #region 统计
        /// <summary>
        /// 拼接月份数据字符串
        /// sql sum(cast(ret_money_total as decimal(18,2))),数据库为float类型，转为decimal，防止相加出现.999999999
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <returns></returns>
        public string GetMonthSaleDataSql(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select goods_amount as salemoney ,0 as backmoney,oi.admin_user_name,from_unixtime(oi.erp_time, '%Y-%m-%d') as datetime");
            strSql.Append("	from xmh_shop.shop_order_info as oi");
            strSql.Append("	where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%' and erp_time<>0");
            strSql.Append(" union all ");
            strSql.Append(" select 0 AS salemoney,-total_amount as backmoney, emp_code admin_user_name, check_date datetime");
            strSql.Append("	from xmh_wms.wms_return_order AS e");
            strSql.Append("	left join hr_employee emp on customer_ser_id=emp.id");
            strSql.Append("	where date_format(check_date, '%Y%m') LIKE '" + yearMonth + "%' and return_type = 0 ");

            //strSql.Append(" select 0 as salemoney,-ret_money_total as backmoney,substring_index(substring_index(user_admin_name, '(', -1), ')', 1) admin_user_name,from_unixtime(e.erp_time, '%Y-%m-%d') as datetime");
            //strSql.Append("	from xmh_shop.shop_return_order as e");
            //strSql.Append("	where from_unixtime(e.erp_time, '%Y%m') like '" + yearMonth + "%' ");
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接月份数据字符串
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <returns></returns>
        public string GetNodeSaleDataSql(string node_oneA, string node_oneB)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select goods_amount as salemoney , 0 as backmoney,oi.admin_user_name,from_unixtime(oi.erp_time, '%Y-%m-%d') as datetime ");
            strSql.Append(" from xmh_shop.shop_order_info as oi ");
            strSql.Append(" where oi.order_status !=9 and oi.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneA)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59)));
            strSql.Append(" union all ");
            strSql.Append(" select 0 AS salemoney,-total_amount as backmoney, emp_code admin_user_name, check_date datetime");
            strSql.Append("	from xmh_wms.wms_return_order AS e");
            strSql.Append("	left join hr_employee emp on customer_ser_id=emp.id");
            strSql.Append("	where unix_timestamp(check_date) between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneA)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59))+" and return_type = 0 ");

            //strSql.Append(" select 0 as salemoney, -ret_money_total as backmoney, substring_index(substring_index(user_admin_name, '(', -1), ')', 1) admin_user_name,from_unixtime(e.erp_time, '%Y-%m-%d') as datetime");
            //strSql.Append(" from xmh_shop.shop_return_order AS e ");
            //strSql.Append(" where  e.erp_time  between  " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneA)) + " and " + Common.TimeParser.GenerateTimeStamp(DateTime.Parse(node_oneB).AddHours(23).AddMinutes(59).AddSeconds(59)));

            return strSql.ToString();
        }

        /// <summary>
        /// 拼接年数据字符串sql
        /// </summary>
        /// <param name="yearMonth">年</param>
        /// <returns></returns>
        public string GetYearSaleDataSql(string year)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select goods_amount as salemoney, 0 as backmoney, oi.admin_user_name, from_unixtime(oi.erp_time, '%m') as datetime");
            strSql.Append(" from xmh_shop.shop_order_info as oi");
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like 'XK-" + year + "%' and erp_time<>0");
            strSql.Append(" union all ");
            strSql.Append(" select 0 AS salemoney,-total_amount as backmoney, emp_code admin_user_name, check_date datetime");
            strSql.Append("	from xmh_wms.wms_return_order AS e");
            strSql.Append("	left join hr_employee emp on customer_ser_id=emp.id");
            strSql.Append("	where date_format(check_date, '%Y') LIKE '" + year + "%' and return_type = 0 ");

            //strSql.Append(" select 0 as salemoney, cast(-ret_money_total as decimal(18,2)) as backmoney, substring_index(substring_index(user_admin_name, '(', -1), ')', 1) admin_user_name, from_unixtime(e.erp_time, '%m') as datetime");
            //strSql.Append(" from xmh_shop.shop_return_order as e");
            //strSql.Append(" where from_unixtime(e.erp_time, '%Y') =" + year );
            return strSql.ToString();
        }

        #endregion

        #region 品牌
        /// <summary>
        /// 拼接月份含品牌数据字符串
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <returns></returns>
        public string GetBrandSaleDataSql(string year,string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("   select salemoney,backmoney,admin_user_name,user_id,null user_id2,CASE WHEN bp_brand_id is null THEN 0 ELSE brand_id END bp_brand_id ");
            strSql.Append("   ,brand_id,brand_name,goods_id,goods_name,goods_price,goods_number,orderyear,ordermonth,orderdate,datetime from (");
            strSql.Append("   select og.goods_price*og.goods_number AS salemoney, 0 as backmoney,oi.admin_user_name,");
            strSql.Append("   g.brand_id,brand_name,g.goods_id,g.goods_name,og.goods_price,og.goods_number, ");
            strSql.Append("    from_unixtime(oi.erp_time, '%Y') AS orderyear,from_unixtime(oi.erp_time, '%m') AS ordermonth,from_unixtime(oi.erp_time, '%d') AS orderdate,from_unixtime(oi.erp_time, '%Y-%m-%d') as datetime,oi.user_id user_id ");
            strSql.Append("    from xmh_shop.shop_order_goods AS og ");
            strSql.Append("    left join xmh_shop.shop_goods AS g ON g.goods_id=og.goods_id ");
            strSql.Append("    left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id ");
            strSql.Append("    left join xmh_shop.shop_order_info AS oi ON oi.order_id=og.order_id ");
            strSql.Append("    where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%'  and erp_time<>0  ");
            strSql.Append("    union all  ");

            strSql.Append("    select 0 as salemoney,-return_amount as backmoney,emp_code admin_user_name, ");
            strSql.Append("    g.brand_id,brand_name,g.goods_id,g.goods_name,-rg.return_price,rg.return_number,");
            strSql.Append("    date_format(check_date, '%Y') AS orderyear,date_format(check_date, '%m') AS ordermonth,date_format(check_date, '%d') AS orderdate, ");
            strSql.Append("    check_date as datetime,e.customer_id user_id  ");
            strSql.Append("    from xmh_wms.wms_return_order as e ");
            strSql.Append("    left join hr_employee emp on customer_ser_id=emp.id ");
            strSql.Append("    left join xmh_wms.wms_return_product rg on e.return_code=rg.return_code ");
            strSql.Append("    left join xmh_shop.shop_goods as g on rg.goods_sn=g.goods_sn ");
            strSql.Append("    left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id ");
            strSql.Append("    where date_format(check_date, '%Y%m') like '" + yearMonth + "%' and return_type = 0 ");

            //strSql.Append("    select 0 as salemoney,cast(-rg.goods_price*rg.goods_number as decimal(18,2)) as backmoney,substring_index(substring_index(user_admin_name, '(', -1), ')', 1) admin_user_name, ");
            //strSql.Append("    g.brand_id,brand_name,g.goods_id,g.goods_name,-rg.goods_price,rg.goods_number,");
            //strSql.Append("    from_unixtime(e.erp_time, '%Y') AS orderyear,from_unixtime(e.erp_time, '%m') AS ordermonth,from_unixtime(e.erp_time, '%d') AS orderdate,from_unixtime(e.erp_time, '%Y-%m-%d') as datetime,e.user_id user_id ");
            //strSql.Append("    from xmh_shop.shop_return_order as e ");
            //strSql.Append("    left join xmh_shop.shop_return_goods rg on e.return_id=rg.return_id ");
            //strSql.Append("    left join xmh_shop.shop_goods as g on rg.goods_id=g.goods_id ");
            //strSql.Append("    left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id ");
            //strSql.Append("    where from_unixtime(e.erp_time, '%Y%m') like '" + yearMonth + "%' ");
            strSql.Append("    )abc ");
            strSql.Append("    left join ecs_brand_percentage bp on abc.brand_id=bp.bp_brand_id and bp_year="+year);
            strSql.Append("    order by ordermonth,convert(admin_user_name,signed),convert(user_id,signed), convert(bp_brand_id,signed),convert(brand_id,signed),convert(goods_id,signed) ");
            return strSql.ToString();
        }


        #endregion

        #region 客户
        public string GetCustomerMonthCountSql(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select count(1) monthcount,orderyear,ordermonth,yearmonth,user_id,null user_id2 from( ");
            strSql.Append(" select from_unixtime(oi.erp_time, '%Y') AS orderyear,from_unixtime(oi.erp_time, '%m') AS ordermonth,from_unixtime(oi.erp_time, '%Y-%m') AS yearmonth,from_unixtime(oi.erp_time, '%Y-%m-%d') AS datetime,user_id");
            strSql.Append(" FROM xmh_shop.shop_order_info AS oi ");
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%' and erp_time<>0");
            strSql.Append(" group by user_id,datetime ) oo  ");
            strSql.Append(" group by ordermonth,user_id order by ordermonth,user_id ");
            return strSql.ToString();
        }

        public string GetEmpMonthCountSql(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select admin_user_name,sum(user_deal_number) deal_number,count(1) deal_count,orderyear,ordermonth,yearmonth from ");
            strSql.Append(" (select admin_user_name,user_id,count(1) user_deal_number,orderyear,ordermonth,yearmonth from ");
            strSql.Append(" (select user_id,oi.admin_user_name,");
            strSql.Append("   from_unixtime(oi.erp_time, '%Y') AS orderyear,from_unixtime(oi.erp_time, '%m') AS ordermonth,from_unixtime(oi.erp_time, '%Y-%m') AS yearmonth,from_unixtime(oi.erp_time, '%Y-%m-%d') AS datetime");
            strSql.Append(" from xmh_shop.shop_order_info AS oi ");
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%' and erp_time<>0 ");
            strSql.Append(" group by admin_user_name,user_id,datetime) abcd  ");
            strSql.Append(" group by user_id,ordermonth)abcde  ");
            strSql.Append(" group by ordermonth,admin_user_name ");
            return strSql.ToString();
        }

        public string GetCustomerSaleSql(string yearMonth, string strSqlOne)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select user_id,null user_id2,C_tel user_name,C_customername u_company,salemoney,backmoney,realmoney,admin_user_name,name,");
            strSql.Append(" d_id,dname,d_pid,d_name d_pname,orderyear,ordermonth,orderdate,datetime from ");
            strSql.Append(" (select user_id,sum(salemoney) salemoney,sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney, ");
            strSql.Append(" admin_user_name,name,d_id,dname,CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid, ");
            strSql.Append(" orderyear,ordermonth,orderdate,datetime ");
            strSql.Append(" from hr_employee AS emp ");
            strSql.Append(" left join hr_department AS dep ON emp.d_id=dep.id ");
            strSql.Append(" left join (select goods_amount as salemoney ,0 as backmoney,oi.admin_user_name,");
            strSql.Append(" from_unixtime(oi.erp_time, '%Y') AS orderyear,from_unixtime(oi.erp_time, '%m') AS ordermonth,from_unixtime(oi.erp_time, '%d') AS orderdate,from_unixtime(oi.erp_time, '%Y-%m-%d') as datetime,user_id ");
            strSql.Append("	from xmh_shop.shop_order_info as oi");
            strSql.Append("	where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%' and erp_time<>0");
            strSql.Append(" union all ");
            strSql.Append(" select 0 AS salemoney,-total_amount as backmoney,emp_code admin_user_name,");
            strSql.Append(" date_format(check_date, '%Y') AS orderyear,date_format(check_date, '%m') AS ordermonth,date_format(check_date, '%d') AS orderdate, check_date datetime,e.customer_id user_id ");
            strSql.Append("	from xmh_wms.wms_return_order AS e");
            strSql.Append("	left join hr_employee emp on customer_ser_id=emp.id");
            strSql.Append(" where date_format(check_date, '%Y%m') like '" + yearMonth + "%' and return_type = 0 ");
            //strSql.Append(" select 0 as salemoney,-ret_money_total as backmoney,substring_index(substring_index(user_admin_name, '(', -1), ')', 1) admin_user_name, ");
            //strSql.Append(" from_unixtime(e.erp_time, '%Y') AS orderyear,from_unixtime(e.erp_time, '%m') AS ordermonth,from_unixtime(e.erp_time, '%d') AS orderdate,from_unixtime(e.erp_time, '%Y-%m-%d') as datetime,user_id ");
            //strSql.Append("	from xmh_shop.shop_return_order as e");
            //strSql.Append("	where from_unixtime(e.erp_time, '%Y%m') like '" + yearMonth + "%' ");
            strSql.Append("	)as abc ON emp.emp_code=abc.admin_user_name ");
            strSql.Append("	where " + strSqlOne + "  AND datetime IS NOT NULL  ");
            strSql.Append("	group by datetime,user_id ");
            strSql.Append("	) abcd ");
            strSql.Append("	left join hr_department AS dep ON abcd.d_pid=dep.id ");
            strSql.Append("	left join crm_contact AS u ON abcd.user_id=u.id ");
            strSql.Append("	order by ordermonth,convert(d_pid,signed),convert(d_id,signed),convert(admin_user_name,signed),convert(user_id,signed),datetime ");
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接月份数据字符串，含客户
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <returns></returns>
        public string GetCustomerMonthSaleSql(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select user_id,goods_amount as salemoney ,0 as backmoney,oi.admin_user_name,from_unixtime(oi.erp_time, '%Y-%m-%d') as datetime");
            strSql.Append("	from xmh_shop.shop_order_info as oi");
            strSql.Append("	where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%' and erp_time<>0");
            strSql.Append(" union all ");
            strSql.Append(" select e.customer_id user_id,0 AS salemoney,-total_amount as backmoney,emp_code admin_user_name,check_date datetime");
            strSql.Append("	from xmh_wms.wms_return_order AS e");
            strSql.Append("	left join hr_employee emp on customer_ser_id=emp.id");
            strSql.Append(" where date_format(check_date, '%Y%m') like '" + yearMonth + "%' and return_type = 0 ");

            //strSql.Append(" select user_id,0 as salemoney,-ret_money_total as backmoney,substring_index(substring_index(user_admin_name, '(', -1), ')', 1) admin_user_name,from_unixtime(e.erp_time, '%Y-%m-%d') as datetime");
            //strSql.Append("	from xmh_shop.shop_return_order as e");
            //strSql.Append("	where from_unixtime(e.erp_time, '%Y%m') like '" + yearMonth + "%' ");
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接年数据字符串sql，含客户
        /// </summary>
        /// <param name="yearMonth">年</param>
        /// <returns></returns>
        public string GetCustomerYearSaleSql(string year)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select user_id,goods_amount as salemoney, 0 as backmoney, oi.admin_user_name, from_unixtime(oi.erp_time, '%m') as datetime");
            strSql.Append(" from xmh_shop.shop_order_info as oi");
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like 'XK-" + year + "%' and erp_time<>0");
            strSql.Append(" union all ");
            strSql.Append(" select e.customer_id user_id,0 AS salemoney,-total_amount as backmoney,emp_code admin_user_name,check_date datetime");
            strSql.Append("	from xmh_wms.wms_return_order AS e");
            strSql.Append("	left join hr_employee emp on customer_ser_id=emp.id");
            strSql.Append(" where date_format(check_date, '%Y') like '" + year + "%' and return_type = 0 ");
            //strSql.Append(" select user_id,0 as salemoney, -ret_money_total as backmoney, substring_index(substring_index(user_admin_name, '(', -1), ')', 1) admin_user_name, from_unixtime(e.erp_time, '%m') as datetime");
            //strSql.Append(" from xmh_shop.shop_return_order as e");
            //strSql.Append(" where from_unixtime(e.erp_time, '%Y') =" + year);
            return strSql.ToString();
        }


        /// <summary>
        /// 拼接月份数据字符串，含品牌单品
        /// </summary>
        /// <param name="yearMonth">年月</param>
        /// <returns></returns>
        public string GetCustomerMonthBrandGoodsSaleSql(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("  select oi.user_id,(og.goods_price*og.goods_number) AS salemoney,0 AS backmoney,og.goods_number,og.goods_price,oi.admin_user_name,");
            strSql.Append("   g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            strSql.Append("   from_unixtime(oi.erp_time, '%m') AS datetime,");
            strSql.Append("   from_unixtime(oi.erp_time, '%Y-%m-%d') AS orderdate");
            strSql.Append("   from xmh_shop.shop_order_goods AS og");
            strSql.Append("   left join xmh_shop.shop_goods AS g ON g.goods_id=og.goods_id");
            strSql.Append("   left join xmh_shop.shop_order_info AS oi ON oi.order_id=og.order_id");
            strSql.Append("   left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id");
            strSql.Append("   where oi.order_status !=9");
            strSql.Append("   and erp_order_sn like 'XK-" + yearMonth + "%'");
            strSql.Append("   and erp_time<>0");
            strSql.Append(" union all");
            strSql.Append("   select e.customer_id user_id,0 as salemoney,-return_amount as backmoney,,rg.goods_number,rg.goods_price,emp_code admin_user_name, ");
            strSql.Append("    g.brand_id,brand_name,g.goods_id,g.goods_name,");
            strSql.Append("    date_format(check_date, '%m') AS datetime,check_date orderdate, ");
            strSql.Append("    from xmh_wms.wms_return_order as e ");
            strSql.Append("    left join hr_employee emp on customer_ser_id=emp.id ");
            strSql.Append("    left join xmh_wms.wms_return_product rg on e.return_code=rg.return_code ");
            strSql.Append("    left join xmh_shop.shop_goods as g on rg.goods_sn=g.goods_sn ");
            strSql.Append("    left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id ");
            strSql.Append("    where date_format(check_date, '%Y%m') like '" + yearMonth + "%' and return_type = 0 ");

            //strSql.Append(" select user_id,0 AS salemoney,-ret_money_total AS backmoney,rg.goods_number,rg.goods_price,");
            //strSql.Append("          substring_index(substring_index(user_admin_name, '(', -1), ')', 1) admin_user_name,");
            //strSql.Append("          g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            //strSql.Append("          from_unixtime(e.erp_time, '%m') AS datetime,");
            //strSql.Append("          from_unixtime(e.erp_time, '%Y-%m-%d') AS orderdate");
            //strSql.Append("          from xmh_shop.shop_return_order AS e");
            //strSql.Append("          left join xmh_shop.shop_return_goods rg ON e.return_id=rg.return_id");
            //strSql.Append("          left join xmh_shop.shop_goods AS g ON rg.goods_id=g.goods_id");
            //strSql.Append(" 		 left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id");
            //strSql.Append("          where from_unixtime(e.erp_time, '%Y%m') like '" + yearMonth + "%'");
            return strSql.ToString();
        }

        /// <summary>
        /// 拼接年数据字符串sql，含品牌单品
        /// </summary>
        /// <param name="yearMonth">年</param>
        /// <returns></returns>
        public string GetCustomerYearBrandGoodsSaleSql(string year)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select oi.user_id,(og.goods_price*og.goods_number) AS salemoney,0 AS backmoney,og.goods_number,oi.admin_user_name,");
            strSql.Append("          g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            strSql.Append("          from_unixtime(oi.erp_time, '%m') AS datetime,");
            strSql.Append("          from_unixtime(oi.erp_time, '%Y-%m-%d') AS orderdate");
            strSql.Append("          from xmh_shop.shop_order_goods AS og");
            strSql.Append("          left join xmh_shop.shop_goods AS g ON g.goods_id=og.goods_id");
            strSql.Append("          left join xmh_shop.shop_order_info AS oi ON oi.order_id=og.order_id");
            strSql.Append(" 		 left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id");
            strSql.Append("          where oi.order_status !=9");
            strSql.Append("          and erp_order_sn like 'XK-" + year + "%'");
            strSql.Append("          and erp_time<>0");
            strSql.Append(" union all");

            strSql.Append("   select e.customer_id user_id,0 as salemoney,-return_amount as backmoney,rg.goods_number,emp_code admin_user_name, ");
            strSql.Append("    g.brand_id,brand_name,g.goods_id,g.goods_name,");
            strSql.Append("    date_format(check_date, '%m') AS datetime,check_date orderdate, ");
            strSql.Append("    from xmh_wms.wms_return_order as e ");
            strSql.Append("    left join hr_employee emp on customer_ser_id=emp.id ");
            strSql.Append("    left join xmh_wms.wms_return_product rg on e.return_code=rg.return_code ");
            strSql.Append("    left join xmh_shop.shop_goods as g on rg.goods_sn=g.goods_sn ");
            strSql.Append("    left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id ");
            strSql.Append("    where date_format(check_date, '%Y') like '" + year + "%' and return_type = 0 ");
            //strSql.Append(" select user_id,0 AS salemoney,-ret_money_total AS backmoney,rg.goods_number,");
            //strSql.Append("          substring_index(substring_index(user_admin_name, '(', -1), ')', 1) admin_user_name,");
            //strSql.Append("          g.brand_id,bd.brand_name,g.goods_id,g.goods_name,");
            //strSql.Append("          from_unixtime(e.erp_time, '%m') AS datetime,");
            //strSql.Append("          from_unixtime(e.erp_time, '%Y-%m-%d') AS orderdate");
            //strSql.Append("          from xmh_shop.shop_return_order AS e");
            //strSql.Append("          left join xmh_shop.shop_return_goods rg ON e.return_id=rg.return_id");
            //strSql.Append("          left join xmh_shop.shop_goods AS g ON rg.goods_id=g.goods_id");
            //strSql.Append(" 		 left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id");
            //strSql.Append("          where from_unixtime(e.erp_time, '%Y') =" + year );
            return strSql.ToString();
        }

        #endregion

        #endregion                

        #region 区域

        #region 单品关键字模糊
        /// <summary>
        /// 获得当月城市订单，模糊查询单品文本框下拉列表
        /// </summary>
        public DataSet GetMonthGoodTxt(string keyWord, string yearMonth, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" select * from ");
            strSql.Append(" ( ");
            strSql.Append(" select g.brand_id,bd.brand_name, ");
            strSql.Append(" case when bp_brand_id is null or bp_brand_id='' then 0 else bp_brand_id end bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" sum(og.goods_number) goods_number,g.goods_id,g.goods_name ");
            strSql.Append(" from xmh_shop.shop_order_goods AS og ");
            strSql.Append(" left join xmh_shop.shop_goods AS g ON g.goods_id=og.goods_id ");
            strSql.Append(" left join xmh_shop.shop_order_info AS oi ON oi.order_id=og.order_id ");
            strSql.Append(" left join xmh_shop.shop_brand as bd on g.brand_id=bd.brand_id ");
            strSql.Append(" LEFT JOIN  ecs_brand_percentage as bp ON g.brand_id=bp.bp_brand_id and bp_year=" + yearMonth.Substring(0, 4));
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%' ");
            strSql.Append(" and erp_time<>0 and g.goods_id is not null and g.goods_name like '%" + keyWord + "%' ");
            strSql.Append(" group by goods_id ");
            strSql.Append(" ) tt  ");
            strSql.Append(" " + areaSqlWhere + " ");
            strSql.Append(" order by goods_number desc  limit 50 ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 省份主页
        /// <summary>
        /// 获得当月省份订单
        /// </summary>
        public DataSet GetProvinceAmt(string strSqlOne, string yearMonth, string brandManagerSqlWhere, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, "");

            if (areaSqlWhere != "")
            {
                strSql.Append("select aabb.*, brandValue/allValue*100 zb from(  ");
                strSql.Append(" select allId,allName,allValue,case when brandValue is null then 0 else brandValue end brandValue from ( ");

                strSql.Append("select a.region_id allId,a.region_name as allName,sum(salemoney) as allValue  ");
                strSql.Append(" from hr_employee as emp ");
                strSql.Append(" left join (" + areaBrandSql + brandManagerSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
                strSql.Append(" LEFT JOIN param_area as a on abc.province=a.region_id ");
                strSql.Append(" where " + strSqlOne + " and datetime is not null and salemoney>0 ");
                strSql.Append(" group by region_name order by allValue desc) aa");

                strSql.Append(" LEFT JOIN ( ");

                strSql.Append("select a.region_name as brandName,sum(salemoney) as brandValue  ");
                strSql.Append(" from hr_employee as emp ");
                strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");

                strSql.Append(" LEFT JOIN param_area as a on abc.province=a.region_id ");
                strSql.Append(" where " + strSqlOne + " and datetime is not null and salemoney>0 ");
                strSql.Append(" group by region_name)bb ");
                strSql.Append("  on aa.allName=bb.brandName) aabb");

            }
            else
            {
                strSql.Append("select a.region_id allId,a.region_name as allName,sum(salemoney) as allValue  ");
                strSql.Append(" from hr_employee as emp ");
                strSql.Append(" left join (" + areaBrandSql + ") AS abc ON emp.emp_code=abc.admin_user_name");
                strSql.Append(" LEFT JOIN param_area as a on abc.province=a.region_id ");
                strSql.Append(" where " + strSqlOne + " and datetime is not null");
                strSql.Append(" group by region_name order by allValue desc");
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetProvinceAmtDms(string strSqlOne,string year,string month2, string brandManagerSqlWhere, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2=="")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year );                
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2);
            }
            if (areaSqlWhere != "")
            {
                strSql.Append("select aabb.*, brandValue/allValue*100 zb from(  ");
                strSql.Append(" select allId,allName,allValue,case when brandValue is null then 0 else brandValue end brandValue from ( ");

                strSql.Append("select a.region_id allId,a.region_name as allName,sum(salemoney) as allValue  ");
                strSql.Append(" from hr_employee as emp ");
                strSql.Append(" left join (" + areaBrandSql + brandManagerSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
                strSql.Append(" LEFT JOIN param_area as a on abc.province=a.region_id ");
                strSql.Append(" where " + strSqlOne + " and datetime is not null and salemoney>0 ");
                strSql.Append(" group by region_name order by allValue desc) aa");

                strSql.Append(" LEFT JOIN ( ");

                strSql.Append("select a.region_name as brandName,sum(salemoney) as brandValue  ");
                strSql.Append(" from hr_employee as emp ");
                strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");

                strSql.Append(" LEFT JOIN param_area as a on abc.province=a.region_id ");
                strSql.Append(" where " + strSqlOne + " and datetime is not null and salemoney>0 ");
                strSql.Append(" group by region_name)bb ");
                strSql.Append("  on aa.allName=bb.brandName) aabb");

            }
            else
            {
                strSql.Append("select a.region_id allId,a.region_name as allName,sum(salemoney) as allValue  ");
                strSql.Append(" from hr_employee as emp ");
                strSql.Append(" left join (" + areaBrandSql + ") AS abc ON emp.emp_code=abc.admin_user_name");
                strSql.Append(" LEFT JOIN param_area as a on abc.province=a.region_id ");
                strSql.Append(" where " + strSqlOne + " and datetime is not null");
                strSql.Append(" group by region_name order by allValue desc");
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 省份年月报详情

        public DataSet GetProvinceYear_MonthsDms(string strSqlOne, string year, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and province=" + provinceId);

            strSql.Append(" select sum(salemoney) AS month_value,ordermonth datetime ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by ordermonth order by ordermonth ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得省份下品牌比
        /// </summary>
        public DataSet GetProvinceMonth_Brand(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append(" select bp_brand_name brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" left join ecs_brand_percentage brand on abc.bp_brand_id=brand.bp_brand_id and bp_year=" + yearMonth.Substring(0, 4));
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by brand.bp_brand_id order by brand_value desc ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetProvinceMonth_BrandDms(string strSqlOne, string year,string month2, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and province=" + provinceId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and province=" + provinceId);
            }

            strSql.Append(" select bp_brand_name brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" left join ecs_brand_percentage brand on abc.bp_brand_id=brand.bp_brand_id and bp_year=" + year);
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by brand.bp_brand_id order by brand_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        //areaSqlWhere不为空，取全部品牌
        public DataSet GetProvinceMonth_AllBrand(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append(" select brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" left join ecs_brand brand on abc.brand_id=brand.brand_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by brand.brand_id order by brand_value desc ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetProvinceMonth_AllBrandDms(string strSqlOne, string year,string month2, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and province=" + provinceId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and province=" + provinceId);
            }

            strSql.Append(" select brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" left join ecs_brand brand on abc.brand_id=brand.brand_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by brand.brand_id order by brand_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得省份下城市比
        /// </summary>
        public DataSet GetProvinceMonth_City(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append(" select city city_id,a.region_name city_name,sum(salemoney) AS city_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" LEFT JOIN param_area as a on abc.city=a.region_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by city_id order by city_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetProvinceMonth_CityDms(string strSqlOne, string year, string month2, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and province=" + provinceId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and province=" + provinceId);
            }
            strSql.Append(" select city city_id,a.region_name city_name,sum(salemoney) AS city_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" LEFT JOIN param_area as a on abc.city=a.region_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by city_id order by city_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得省份下品牌比
        /// </summary>
        public DataSet GetProvinceMonth_Good(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append(" select goods_id,goods_name,sum(salemoney) AS goods_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by goods_name order by goods_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetProvinceMonth_GoodDms(string strSqlOne, string year, string month2, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and province=" + provinceId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and province=" + provinceId);
            }
            strSql.Append(" select goods_id,goods_name,sum(salemoney) AS goods_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by goods_name order by goods_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得省份下员工排名
        /// </summary>
        public DataSet GetProvinceMonth_Emp(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append(" select name emp_name,sum(salemoney) AS emp_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by admin_user_name order by emp_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetProvinceMonth_EmpDms(string strSqlOne, string year, string month2, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and province=" + provinceId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and province=" + provinceId);
            }
            strSql.Append(" select name emp_name,sum(salemoney) AS emp_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by admin_user_name order by emp_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得省份下客户排名
        /// </summary>
        public DataSet GetProvinceMonth_Customer(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and province=" + provinceId);

            strSql.Append("select customer_id,customer_name,customer_value from (  ");
            strSql.Append(" select abc.user_id customer_id,C_customername customer_name,sum(salemoney) AS customer_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" LEFT JOIN crm_contact AS u ON abc.user_id=u.id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by customer_id order by customer_value desc) abcd");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetProvinceMonth_CustomerDms(string strSqlOne, string year, string month2, string provinceId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and province=" + provinceId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and province=" + provinceId);
            }
            strSql.Append("select customer_id,customer_name,customer_value from (  ");
            strSql.Append(" select abc.user_id customer_id,C_customername customer_name,sum(salemoney) AS customer_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" LEFT JOIN crm_contact AS u ON abc.user_id=u.id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by customer_id order by customer_value desc) abcd");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 城市主页
        /// <summary>
        /// 获得当月城市订单
        /// </summary>
        public DataSet GetCityAmt(string strSqlOne, string yearMonth, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, "");
            strSql.Append("select a.region_id id,a.region_name as name,sum(salemoney) as value  ");
            strSql.Append(" from hr_employee as emp ");

            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");

            strSql.Append(" LEFT JOIN param_area as a on abc.city=a.region_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by region_name order by value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCityAmtDms(string strSqlOne, string year, string month2, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2);
            }
            strSql.Append("select a.region_id id,a.region_name as name,sum(salemoney) as value  ");
            strSql.Append(" from hr_employee as emp ");

            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + ") AS abc ON emp.emp_code=abc.admin_user_name");

            strSql.Append(" LEFT JOIN param_area as a on abc.city=a.region_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by region_name order by value desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 城市年月报详情
        /// <summary>
        /// 获得城市下月份走势图
        /// </summary>
        public DataSet GetCityYear_MonthsDms(string strSqlOne, string year,  string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetOrderDmsSql("orderyear=" + year + "  and city=" + cityId);

            strSql.Append(" select sum(salemoney) AS month_value,ordermonth	datetime  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by ordermonth order by ordermonth");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得城市下员工排名
        /// </summary>
        public DataSet GetCityMonth_Brand(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and city=" + cityId);

            strSql.Append(" select bp_brand_name brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" left join ecs_brand_percentage brand on abc.bp_brand_id=brand.bp_brand_id and bp_year=" + yearMonth.Substring(0, 4));
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by brand.bp_brand_id order by brand_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCityMonth_BrandDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and city=" + cityId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and city=" + cityId);
            }

            strSql.Append(" select bp_brand_name brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" left join ecs_brand_percentage brand on abc.bp_brand_id=brand.bp_brand_id and bp_year=" + year);
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by brand.bp_brand_id order by brand_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetCityMonth_AllBrand(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and city=" + cityId);

            strSql.Append(" select brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" left join ecs_brand brand on abc.brand_id=brand.brand_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by brand.brand_id order by brand_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCityMonth_AllBrandDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and city=" + cityId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and city=" + cityId);
            }

            strSql.Append(" select brand_name,sum(salemoney) AS brand_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" left join ecs_brand brand on abc.brand_id=brand.brand_id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by brand.brand_id order by brand_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得城市下员工排名
        /// </summary>
        public DataSet GetCityMonth_Good(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and city=" + cityId);

            strSql.Append(" select goods_id,goods_name,sum(salemoney) AS goods_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by goods_name order by goods_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCityMonth_GoodDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and city=" + cityId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and city=" + cityId);
            }

            strSql.Append(" select goods_id,goods_name,sum(salemoney) AS goods_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by goods_name order by goods_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得城市下员工排名
        /// </summary>
        public DataSet GetCityMonth_Emp(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and city=" + cityId);

            strSql.Append(" select name emp_name,sum(salemoney) AS emp_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by admin_user_name order by emp_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCityMonth_EmpDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and city=" + cityId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and city=" + cityId);
            }

            strSql.Append(" select name emp_name,sum(salemoney) AS emp_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by admin_user_name order by emp_value desc");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得城市下客户排名
        /// </summary>
        public DataSet GetCityMonth_Customer(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = GetAreaBrandSql(yearMonth, " and city=" + cityId);

            strSql.Append("select customer_id,customer_name,customer_value from (  ");
            strSql.Append(" select abc.user_id customer_id,C_customername customer_name,sum(salemoney) AS customer_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" LEFT JOIN crm_contact AS u ON abc.user_id=u.id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by customer_id order by customer_value desc) abcd");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCityMonth_CustomerDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string areaBrandSql = "";
            if (month2 == "")
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and city=" + cityId);
            }
            else
            {
                areaBrandSql = GetOrderDmsSql("orderyear=" + year + " and ordermonth=" + month2 + " and city=" + cityId);
            }

            strSql.Append("select customer_id,customer_name,customer_value from (  ");
            strSql.Append(" select abc.user_id customer_id,C_customername customer_name,sum(salemoney) AS customer_value	  ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + areaBrandSql + areaSqlWhere + " ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" LEFT JOIN crm_contact AS u ON abc.user_id=u.id ");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by customer_id order by customer_value desc) abcd");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #endregion

        #region  统计
        /// <summary>
        /// 1.个人月销售数据 
        /// </summary>
        public DataSet GetMonthSaleBackData(string strSqlOne, string yearMonth, string monthColumns)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth);
            strSql.Append(" select * from (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,lpad(day(abc.datetime), 2, 0) as orderdate,admin_user_name,name");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by orderdate");
            strSql.Append(" order by orderdate )ddd");

            strSql.Append(" left join (select emp_code, CASE WHEN base." + monthColumns + " IS NULL THEN 0 ELSE base." + monthColumns + " END month_base,");
            strSql.Append(" CASE WHEN plan." + monthColumns + " IS NULL THEN 0 ELSE plan." + monthColumns + " END month_plan,");
            strSql.Append(" CASE WHEN rat." + monthColumns + " IS NULL THEN 0 ELSE rat." + monthColumns + " END month_rat");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" LEFT JOIN dms_set_rating AS rat ON emp.emp_code=rat.kf_uname and rat.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append(" LEFT JOIN ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and plan.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append(" LEFT JOIN ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" ) pb on pb.emp_code=ddd.admin_user_name");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetMonthSaleBackDmsData(string strSqlOne, string yearMonth, string monthColumns)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthDmsDataSql(yearMonth);
            strSql.Append(" select * from (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,lpad(day(abc.datetime), 2, 0) as orderdate,admin_user_name,name");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null");
            strSql.Append(" group by orderdate");
            strSql.Append(" order by orderdate )ddd");

            strSql.Append(" left join (select emp_code, CASE WHEN base." + monthColumns + " IS NULL THEN 0 ELSE base." + monthColumns + " END month_base,");
            strSql.Append(" CASE WHEN plan." + monthColumns + " IS NULL THEN 0 ELSE plan." + monthColumns + " END month_plan,");
            strSql.Append(" CASE WHEN rat." + monthColumns + " IS NULL THEN 0 ELSE rat." + monthColumns + " END month_rat"); 
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" LEFT JOIN dms_set_rating AS rat ON emp.emp_code=rat.kf_uname and rat.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append(" LEFT JOIN ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and plan.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append(" LEFT JOIN ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" ) pb on pb.emp_code=ddd.admin_user_name");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 部门以及下面所有员工的1.销售数据，2.销售数据合计（分组），3.销售基数计划（注释部分为每个员工月内的总和，由于前台展示需要一个月份每一天的累加，所以放在前台js求值）,,,(二).选择权限内的个人月销售数据 
        /// </summary>
        public DataSet GetManagerMonthDepData(string strSqlOne, string yearMonth, string monthColumns)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth);

            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append("     select * from( ");
            strSql.Append("       select lpad(day(abc.datetime), 2, 0) as orderdate,'0' d_pid,'员工合计' d_pname, sum(salemoney) as salemoney, sum(backmoney) as backmoney, sum(salemoney+backmoney) as realmoney ");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append("       group by orderdate");
            strSql.Append(" union all");
            strSql.Append(" select lpad(day(abc.datetime), 2, 0) as orderdate, admin_user_name d_pid, name d_pname, ");
            strSql.Append(" 	sum(salemoney) as salemoney, sum(backmoney) as backmoney, sum(salemoney+backmoney) as realmoney");
            strSql.Append(" 	from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name, orderdate");
            strSql.Append(" 	order by convert(d_pid,signed), orderdate asc) ddd");

            strSql.Append(" left join (");
            strSql.Append(" select '0' d_pid1,'员工合计' d_pname1,sum(salemoney) as salemoney1, sum(backmoney) as backmoney1, sum(salemoney+backmoney) as realmoney1 ");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" union all");
            strSql.Append(" select  admin_user_name d_pid1, name d_pname1, ");
            strSql.Append(" 	sum(salemoney) as salemoney1, sum(backmoney) as backmoney1, sum(salemoney+backmoney) as realmoney1");
            strSql.Append(" 	from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name");
            strSql.Append(" 	order by convert(d_pid1,signed)");
            strSql.Append(" ) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" left join( ");
            strSql.Append(" select * from");
            strSql.Append("   (select '0' d_pid2, '员工合计' d_pname2,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from");
            strSql.Append("         (select case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("          from hr_employee as emp");
            strSql.Append("          left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("          left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("          where " + strSqlOne + ") a )aa");
            strSql.Append(" union all");
            strSql.Append(" select emp_code d_pid2,name d_pname2,dep_month_base,dep_month_plan");
            strSql.Append(" from");
            strSql.Append("   (select emp_code,name,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan");
            strSql.Append("    from");
            strSql.Append("      (select emp_code,name, case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       where " + strSqlOne + ") a");
            strSql.Append("    group by emp_code");
            strSql.Append("    order by emp_code) b");
            strSql.Append("  )pb on ddd.d_pid=pb.d_pid2");
            strSql.Append(" ) tt order by convert(d_pid,signed)");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetManagerMonthDepDmsData(string strSqlOne, string yearMonth, string monthColumns)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthDmsDataSql(yearMonth);

            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append("     select * from( ");
            strSql.Append("       select lpad(day(abc.datetime), 2, 0) as orderdate,'0' d_pid,'员工合计' d_pname, sum(salemoney) as salemoney, sum(backmoney) as backmoney, sum(salemoney+backmoney) as realmoney ");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append("       group by orderdate");
            strSql.Append(" union all");
            strSql.Append(" select lpad(day(abc.datetime), 2, 0) as orderdate, admin_user_name d_pid, name d_pname, ");
            strSql.Append(" 	sum(salemoney) as salemoney, sum(backmoney) as backmoney, sum(salemoney+backmoney) as realmoney");
            strSql.Append(" 	from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name, orderdate");
            strSql.Append(" 	order by convert(d_pid,signed), orderdate asc) ddd");

            strSql.Append(" left join (");
            strSql.Append(" select '0' d_pid1,'员工合计' d_pname1,sum(salemoney) as salemoney1, sum(backmoney) as backmoney1, sum(salemoney+backmoney) as realmoney1 ");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" union all");
            strSql.Append(" select  admin_user_name d_pid1, name d_pname1, ");
            strSql.Append(" 	sum(salemoney) as salemoney1, sum(backmoney) as backmoney1, sum(salemoney+backmoney) as realmoney1");
            strSql.Append(" 	from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name");
            strSql.Append(" 	order by convert(d_pid1,signed)");
            strSql.Append(" ) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" left join( ");
            strSql.Append(" select * from");
            strSql.Append("   (select '0' d_pid2, '员工合计' d_pname2,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from");
            strSql.Append("      (select case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,");
            strSql.Append("       case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and plan.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       where " + strSqlOne + ") a )aa");
            strSql.Append(" union all");
            strSql.Append(" select emp_code d_pid2,name d_pname2,dep_month_base,dep_month_plan");
            strSql.Append(" from");
            strSql.Append("   (select emp_code,name,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from");
            strSql.Append("      (select emp_code,name,case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,");
            strSql.Append("       case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and plan.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       where " + strSqlOne + ") a");
            strSql.Append("    group by emp_code");
            strSql.Append("    order by emp_code) b");
            strSql.Append("  )pb on ddd.d_pid=pb.d_pid2");
            strSql.Append(" ) tt order by convert(d_pid,signed)");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 中心以及下面所有部门的1.销售数据，2.销售数据合计（分组），3.销售基数计划
        /// </summary>
        public DataSet GetMonthAllDepData(string strSqlOne, string yearMonth, string monthColumns)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth);
            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append(" select * from (");
            strSql.Append(" select lpad(day(abc.datetime), 2, 0) AS orderdate,'0' d_pid,'全体部门' d_pname,sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by orderdate");
            strSql.Append(" union all ");
            strSql.Append(" select orderdate, d_pid, d_pname,sum(salemoney) AS salemoney,sum(backmoney) AS backmoney,sum(salemoney+backmoney) AS realmoney from (");
            strSql.Append(" select orderdate,salemoney,backmoney,realmoney,d_pid, d_name d_pname from");
            strSql.Append(" (select salemoney, backmoney, salemoney+backmoney AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,lpad(day(abc.datetime), 2, 0) AS orderdate");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid, orderdate");
            strSql.Append(" ) ddd");

            strSql.Append(" LEFT JOIN (select '0' d_pid1,'全体部门' d_pname1,sum(salemoney) AS salemoney1, sum(backmoney) AS backmoney1, sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" union all ");
            strSql.Append(" select d_pid d_pid1, d_pname d_pname1,sum(salemoney) AS salemoney1,sum(backmoney) AS backmoney1,sum(salemoney+backmoney) AS realmoney1 from (");
            strSql.Append(" select orderdate,salemoney,backmoney,realmoney,d_pid, d_name d_pname from");
            strSql.Append(" (select sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,lpad(day(abc.datetime), 2, 0) AS orderdate");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by orderdate,admin_user_name");
            strSql.Append(" order by orderdate ASC");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" order by d_pid,admin_user_name,orderdate");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid1) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" left join (");
            strSql.Append("   select 0 as d_pid2,'全体部门' d_pname2,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan");
            strSql.Append("    from");
            strSql.Append("      (select case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       where " + strSqlOne + ") a");
            strSql.Append(" union all");
            strSql.Append(" select * from");
            strSql.Append("   (select d_pid d_pid2,d_name d_pname2,dep_month_base,dep_month_plan");
            strSql.Append("    from");
            strSql.Append("      (select d_pid,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan");
            strSql.Append("       from");
            strSql.Append("         (select case when parentid=1 then dep.id else parentid end d_pid, case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("          from hr_employee as emp");
            strSql.Append("          left join hr_department as dep on emp.d_id=dep.id");
            strSql.Append("          left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("          left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       where " + strSqlOne + ") a");
            strSql.Append("       group by d_pid) b");
            strSql.Append("    left join hr_department as dep on b.d_pid=dep.id)aa");
            strSql.Append("    )pb on ddd.d_pid=pb.d_pid2 ");
            strSql.Append(" ) tt order by convert(d_pid,signed)");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetMonthAllDepDmsData(string strSqlOne, string yearMonth, string monthColumns)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthDmsDataSql(yearMonth);

            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append(" select * from (");
            strSql.Append(" select lpad(day(abc.datetime), 2, 0) AS orderdate,'0' d_pid,'全体部门' d_pname,sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by orderdate");
            strSql.Append(" union all ");
            strSql.Append(" select orderdate, d_pid, d_pname,sum(salemoney) AS salemoney,sum(backmoney) AS backmoney,sum(salemoney+backmoney) AS realmoney from (");
            strSql.Append(" select orderdate,salemoney,backmoney,realmoney,d_pid, d_name d_pname from");
            strSql.Append(" (select salemoney, backmoney, salemoney+backmoney AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,lpad(day(abc.datetime), 2, 0) AS orderdate");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid, orderdate");
            strSql.Append(" ) ddd");

            strSql.Append(" LEFT JOIN (select '0' d_pid1,'全体部门' d_pname1,sum(salemoney) AS salemoney1, sum(backmoney) AS backmoney1, sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" union all ");
            strSql.Append(" select d_pid d_pid1, d_pname d_pname1,sum(salemoney) AS salemoney1,sum(backmoney) AS backmoney1,sum(salemoney+backmoney) AS realmoney1 from (");
            strSql.Append(" select orderdate,salemoney,backmoney,realmoney,d_pid, d_name d_pname from");
            strSql.Append(" (select sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,lpad(day(abc.datetime), 2, 0) AS orderdate");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" LEFT JOIN (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by orderdate,admin_user_name");
            strSql.Append(" order by orderdate ASC");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" order by d_pid,admin_user_name,orderdate");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid1) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" left join (");
            strSql.Append("   select 0 as d_pid2,'全体部门' d_pname2,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan");
            strSql.Append("    from");
            strSql.Append("      (select case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("       from hr_employee as emp");
            strSql.Append("       left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       where " + strSqlOne + ") a");
            strSql.Append(" union all");
            strSql.Append(" select * from");
            strSql.Append("   (select d_pid d_pid2,d_name d_pname2,dep_month_base,dep_month_plan");
            strSql.Append("    from");
            strSql.Append("      (select d_pid,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan");
            strSql.Append("       from");
            strSql.Append("         (select case when parentid=1 then dep.id else parentid end d_pid, case when base." + monthColumns + " is null then 0 else base." + monthColumns + " end month_base,case when plan." + monthColumns + " is null then 0 else plan." + monthColumns + " end month_plan");
            strSql.Append("          from hr_employee as emp");
            strSql.Append("          left join hr_department as dep on emp.d_id=dep.id");
            strSql.Append("          left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("          left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + yearMonth.Substring(0, 4));
            strSql.Append("       where " + strSqlOne + ") a");
            strSql.Append("       group by d_pid) b");
            strSql.Append("    left join hr_department as dep on b.d_pid=dep.id)aa");
            strSql.Append("    )pb on ddd.d_pid=pb.d_pid2 ");
            strSql.Append(" ) tt order by convert(d_pid,signed)");

            return DbHelperMySQL.Query(strSql.ToString());
        }


        //---------------------------------------------年报----

        /// <summary>
        /// 个人年报
        /// </summary>
        public DataSet GetYearSaleBackData(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();

            string saleData = GetYearSaleDataSql(year);
            strSql.Append("select * from (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,datetime,admin_user_name,name");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime");
            strSql.Append(" order by datetime ASC) ddd");

            strSql.Append(" left join (select emp_code, CASE WHEN base.plan_task IS NULL THEN 0 ELSE base.plan_task END year_base,CASE WHEN plan.plan_task IS NULL THEN 0 ELSE plan.plan_task END year_plan");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" ) pb on pb.emp_code=ddd.admin_user_name");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetYearSaleBackDmsData(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();

            string saleData = GetYearDmsDataSql(year);
            strSql.Append("select * from (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,datetime,admin_user_name,name");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime");
            strSql.Append(" order by datetime ASC) ddd");

            strSql.Append(" left join (select emp_code, CASE WHEN base.plan_task IS NULL THEN 0 ELSE base.plan_task END year_base,CASE WHEN plan.plan_task IS NULL THEN 0 ELSE plan.plan_task END year_plan");
            strSql.Append(" from hr_employee as emp");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" ) pb on pb.emp_code=ddd.admin_user_name");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 部门以及下面所有个人的年报
        /// </summary>
        public DataSet GetYearDepData(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetYearSaleDataSql(year);
            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append(" select* from ( ");
            strSql.Append(" select datetime,0 d_pid,'员工合计' d_pname, sum(salemoney) as salemoney, sum(backmoney) as backmoney, sum(salemoney+backmoney) as realmoney ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime ");
            strSql.Append(" UNION ALL");
            strSql.Append(" select datetime,admin_user_name d_pid,name d_pname, sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney ");
            strSql.Append(" from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name, datetime");
            strSql.Append(" )ddd");

            strSql.Append(" LEFT JOIN (select '0' d_pid1,'员工合计' d_pname1,sum(salemoney) AS salemoney1,sum(backmoney) AS backmoney1,sum(salemoney+backmoney) AS realmoney1  ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" UNION ALL");
            strSql.Append(" select admin_user_name d_pid1,name d_pname1, sum(salemoney) as salemoney1,sum(backmoney) as backmoney1,sum(salemoney+backmoney) as realmoney1 ");
            strSql.Append(" from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name");
            strSql.Append(" ) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" LEFT JOIN (");
            strSql.Append(" select * from (select '0' d_pid2, '员工合计' d_pname2,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from ");
            strSql.Append(" (select case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan ");
            strSql.Append(" from hr_employee AS emp ");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append("  where " + strSqlOne + " ) a )aa");
            strSql.Append(" UNION ALL");
            strSql.Append(" select emp_code d_pid2,name d_pname2,dep_month_base,dep_month_plan from ");
            strSql.Append(" (select emp_code,name,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from (");
            strSql.Append(" select emp_code,name,case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan ");
            strSql.Append("  from hr_employee AS emp ");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append("  where " + strSqlOne + " ) a");
            strSql.Append(" group by emp_code ) b");
            strSql.Append(" )pb ON ddd.d_pid=pb.d_pid2");
            strSql.Append(" ) tt order by convert(d_pid,signed)");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetYearDepDmsData(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetYearDmsDataSql(year);

            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append(" select* from ( ");
            strSql.Append(" select datetime,0 d_pid,'员工合计' d_pname, sum(salemoney) as salemoney, sum(backmoney) as backmoney, sum(salemoney+backmoney) as realmoney ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime ");
            strSql.Append(" UNION ALL");
            strSql.Append(" select datetime,admin_user_name d_pid,name d_pname, sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney ");
            strSql.Append(" from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name, datetime");
            strSql.Append(" )ddd");

            strSql.Append(" LEFT JOIN (select '0' d_pid1,'员工合计' d_pname1,sum(salemoney) AS salemoney1,sum(backmoney) AS backmoney1,sum(salemoney+backmoney) AS realmoney1  ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" UNION ALL");
            strSql.Append(" select admin_user_name d_pid1,name d_pname1, sum(salemoney) as salemoney1,sum(backmoney) as backmoney1,sum(salemoney+backmoney) as realmoney1 ");
            strSql.Append(" from hr_employee as emp");
            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 	where " + strSqlOne + " and datetime is not null");
            strSql.Append(" 	group by admin_user_name");
            strSql.Append(" ) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" LEFT JOIN (");
            strSql.Append(" select * from (select '0' d_pid2, '员工合计' d_pname2,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from ");
            strSql.Append(" (select case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan ");
            strSql.Append(" from hr_employee AS emp ");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append("  where " + strSqlOne + " ) a )aa");
            strSql.Append(" UNION ALL");
            strSql.Append(" select emp_code d_pid2,name d_pname2,dep_month_base,dep_month_plan from ");
            strSql.Append(" (select emp_code,name,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from (");
            strSql.Append(" select emp_code,name,case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan ");
            strSql.Append("  from hr_employee AS emp ");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append("  where " + strSqlOne + " ) a");
            strSql.Append(" group by emp_code ) b");
            strSql.Append(" )pb ON ddd.d_pid=pb.d_pid2");
            strSql.Append(" ) tt order by convert(d_pid,signed)");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 中心以及下面所有部门的年报
        /// </summary>
        public DataSet GetYearAllDepData(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetYearSaleDataSql(year);

            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append(" select* from ( select datetime,'0' d_pid,'全体部门' d_pname,sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime");
            strSql.Append(" union all ");
            strSql.Append(" select datetime, d_pid, d_pname,sum(salemoney) AS salemoney,sum(backmoney) AS backmoney,sum(salemoney+backmoney) AS realmoney from (");
            strSql.Append(" select datetime,salemoney,backmoney,realmoney,d_pid, d_name d_pname from");
            strSql.Append(" (select sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,datetime ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime,admin_user_name");
            strSql.Append(" order by datetime ASC");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" order by d_pid,admin_user_name,datetime");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid,datetime order by CONVERT(d_pid,SIGNED),datetime )ddd");

            strSql.Append(" LEFT JOIN ( select '0' d_pid1,'全体部门' d_pname1,sum(salemoney) AS salemoney1, sum(backmoney) AS backmoney1, sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" union all ");
            strSql.Append(" select  d_pid d_pid1, d_pname d_pname1,sum(salemoney) AS salemoney1,sum(backmoney) AS backmoney1,sum(salemoney+backmoney) AS realmoney1 from (");
            strSql.Append(" select salemoney,backmoney,realmoney,d_pid, d_name d_pname from");
            strSql.Append(" (select sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,datetime ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime,admin_user_name");
            strSql.Append(" order by datetime ASC");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" order by d_pid,admin_user_name,datetime");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid1 ) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" LEFT JOIN (select 0 as d_pid2, '全体部门' d_pname2, sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from (");
            strSql.Append(" select case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan from hr_employee AS emp ");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append("  where " + strSqlOne + " ) a");
            strSql.Append(" union all");
            strSql.Append(" select * from (");
            strSql.Append(" select d_pid d_pid2,d_name d_pname2,dep_month_base,dep_month_plan from ");
            strSql.Append(" (select d_pid,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from (");
            strSql.Append(" select CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid, ");
            strSql.Append(" case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan from hr_employee AS emp ");
            strSql.Append(" LEFT JOIN hr_department as dep on emp.d_id=dep.id");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append("  where " + strSqlOne + " ) a");
            strSql.Append(" group by d_pid) b");
            strSql.Append(" LEFT JOIN hr_department AS dep ON b.d_pid=dep.id)aa");
            strSql.Append(" )pb ON ddd.d_pid=pb.d_pid2");
            strSql.Append(" ) tt order by convert(d_pid,signed)");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetYearAllDepDmsData(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetYearDmsDataSql(year);

            strSql.Append("     select *,realmoney1-dep_month_plan cha,case when realmoney1/dep_month_plan*100 is null then 0 else realmoney1/dep_month_plan*100 end wcl from( ");
            strSql.Append(" select* from ( select datetime,'0' d_pid,'全体部门' d_pname,sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime");
            strSql.Append(" union all ");
            strSql.Append(" select datetime, d_pid, d_pname,sum(salemoney) AS salemoney,sum(backmoney) AS backmoney,sum(salemoney+backmoney) AS realmoney from (");
            strSql.Append(" select datetime,salemoney,backmoney,realmoney,d_pid, d_name d_pname from");
            strSql.Append(" (select sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,datetime ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime,admin_user_name");
            strSql.Append(" order by datetime ASC");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" order by d_pid,admin_user_name,datetime");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid,datetime order by CONVERT(d_pid,SIGNED),datetime )ddd");

            strSql.Append(" LEFT JOIN ( select '0' d_pid1,'全体部门' d_pname1,sum(salemoney) AS salemoney1, sum(backmoney) AS backmoney1, sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" union all ");
            strSql.Append(" select  d_pid d_pid1, d_pname d_pname1,sum(salemoney) AS salemoney1,sum(backmoney) AS backmoney1,sum(salemoney+backmoney) AS realmoney1 from (");
            strSql.Append(" select salemoney,backmoney,realmoney,d_pid, d_name d_pname from");
            strSql.Append(" (select sum(salemoney) AS salemoney, sum(backmoney) AS backmoney, sum(salemoney+backmoney) AS realmoney,emp_code AS admin_user_name,name, d_id,dname, CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid,datetime ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime is not null ");
            strSql.Append(" group by datetime,admin_user_name");
            strSql.Append(" order by datetime ASC");
            strSql.Append(" ) dds");
            strSql.Append(" LEFT JOIN hr_department AS dep ON dds.d_pid=dep.id ");
            strSql.Append(" order by d_pid,admin_user_name,datetime");
            strSql.Append(" ) pp");
            strSql.Append(" group by d_pid1 ) ss on ddd.d_pid=ss.d_pid1");

            strSql.Append(" LEFT JOIN (select 0 as d_pid2, '全体部门' d_pname2, sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from (");
            strSql.Append(" select case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan from hr_employee AS emp ");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append("  where " + strSqlOne + " ) a");
            strSql.Append(" union all");
            strSql.Append(" select * from (");
            strSql.Append(" select d_pid d_pid2,d_name d_pname2,dep_month_base,dep_month_plan from ");
            strSql.Append(" (select d_pid,sum(cast(month_base as decimal(18,2))) dep_month_base,sum(cast(month_plan as decimal(18,2))) dep_month_plan from (");
            strSql.Append(" select CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid, ");
            strSql.Append(" case when base.plan_task is null then 0 else base.plan_task end month_base,case when plan.plan_task is null then 0 else plan.plan_task end month_plan from hr_employee AS emp ");
            strSql.Append(" LEFT JOIN hr_department as dep on emp.d_id=dep.id");
            strSql.Append(" left join ecs_per_plan AS plan ON emp.emp_code=plan.kf_uname and PLAN.plan_year=" + year);
            strSql.Append(" left join ecs_month_base AS base ON emp.emp_code=base.kf_uname and base.plan_year=" + year);
            strSql.Append("  where " + strSqlOne + " ) a");
            strSql.Append(" group by d_pid) b");
            strSql.Append(" LEFT JOIN hr_department AS dep ON b.d_pid=dep.id)aa");
            strSql.Append(" )pb ON ddd.d_pid=pb.d_pid2");
            strSql.Append(" ) tt order by convert(d_pid,signed)");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 品牌
        #region 品牌年度
        /// <summary>
        /// 品牌年度主页 
        /// </summary>
        public DataSet GetBrandManagerDms_Year(string strSqlOne, string year, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year);
            strSql.Append(" select salemoney,backmoney,realmoney,datetime,bp_id,bp_brand_id,base,plan,bp_brand_name,bp_percentage from (");
            strSql.Append(" select case when salemoney is null then 0 else salemoney end salemoney, ");
            strSql.Append(" case when backmoney is null then 0 else backmoney end backmoney, ");
            strSql.Append(" case when realmoney is null then 0 else realmoney end realmoney, ");
            strSql.Append(" case when datetime is null then 1 else datetime end datetime,bp_id,brand.bp_brand_id,  ");
            strSql.Append(" base,plan,");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when bp_percentage is null or bp_brand_name='' then '0.8' else bp_percentage end bp_percentage ");
            strSql.Append(" from ecs_brand_percentage brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,bp_brand_id,ordermonth datetime");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by ordermonth,bp_brand_id ");
            strSql.Append(" ) as dds ON dds.bp_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(bc_base) base,sum( bc_task) plan,bc_brand_id,bc_brand_name");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join ecs_brand_check eck on emp.emp_code=eck.bc_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne + " and eck.bc_year=" + year);
            }
            strSql.Append(" group by bc_brand_id ");
            strSql.Append(" ) bc ON bc.bc_brand_id=brand.bp_brand_id ");
            strSql.Append(qtBrand + " and brand.bp_year=" + year);
            strSql.Append(" )al");
            strSql.Append(" order by bp_id,datetime ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetAllBrandManagerDms_Year(string strSqlOne, string year, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year);
            strSql.Append(" select salemoney,backmoney,realmoney,datetime,brand.brand_id bp_brand_id,brand_base*12 base,brand_plan*12 plan,brand_name bp_brand_name,0 bp_percentage ");
            strSql.Append(" FROM dms_brand_manager brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,brand_id,ordermonth as datetime");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by ordermonth,brand_id ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.brand_id ");
            strSql.Append(qtBrand);
            strSql.Append(" order by bp_brand_id,datetime ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #region 详情页
        public DataSet GetBrandManagerDms_Emp_Year(string strSqlOne, string year, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year);

            strSql.Append(" select  salemoney,backmoney,realmoney,code,name,bp_id,bp_brand_id,bp_brand_name,base,plan,case when realmoney/plan*100 is null then 0 else realmoney/plan*100 end wcl from ( ");
            strSql.Append(" select salemoney,backmoney,realmoney,emp_code code,name,bp_id,brand.bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name,bc_base base ,bc_task plan");
            strSql.Append(" from ecs_brand_percentage brand ");
            strSql.Append(" left join (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,emp_code,name,bp_brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by bp_brand_id,emp_code  ) as dds ");
            strSql.Append(" ON dds.bp_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join ecs_brand_check eck on eck.bc_user_name=dds.emp_code and eck.bc_brand_id=dds.bp_brand_id ");
            strSql.Append(qtBrand + " and eck.bc_year=" + year + " and brand.bp_year=" + year);
            strSql.Append(" order by bp_id,realmoney desc )tt ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetAllBrandManagerDms_Emp_Year(string strSqlOne, string year, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year);

            strSql.Append(" select salemoney,backmoney,realmoney,dds.emp_code code,dds.name,brand.brand_id bp_brand_id,brand_name bp_brand_name,0 base,0 plan, 0 wcl ");
            strSql.Append(" FROM dms_brand_manager brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,emp_code,name,brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by brand_id,emp_code ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.brand_id ");
            strSql.Append(qtBrand);
            strSql.Append(" order by bp_brand_id,realmoney desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetBrandManagerDms_Good_Year(string strSqlOne, string year, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year);

            strSql.Append(" select salemoney,backmoney,realmoney,code,name,bp_id,bp_brand_id,bp_brand_name from ( ");
            strSql.Append(" select salemoney,backmoney,realmoney,goods_id code,goods_name name,bp_id,brand.bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name ");
            strSql.Append(" from ecs_brand_percentage brand ");
            strSql.Append(" left join(select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,goods_id,goods_name,bp_brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by bp_brand_id,goods_id  ) as dds ");
            strSql.Append(" ON dds.bp_brand_id=brand.bp_brand_id ");
            strSql.Append(qtBrand + " and brand.bp_year=" + year);
            strSql.Append(" order by bp_id,realmoney desc )tt limit 100 ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetAllBrandManagerDms_Good_Year(string strSqlOne, string year, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year);

            strSql.Append(" select salemoney,backmoney,realmoney,goods_id code,goods_name name,brand.brand_id bp_brand_id,brand_name bp_brand_name ");
            strSql.Append(" FROM dms_brand_manager brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,goods_id,goods_name,brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by brand_id,goods_id ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.brand_id ");
            strSql.Append(qtBrand);
            strSql.Append(" order by bp_brand_id,realmoney desc limit 100 ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion
        

        #endregion

        #region 品牌月度主页
        public DataSet GetBrandManagerData(string strSqlOne, string yearMonth, string year,string month, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandSaleDataSql(year, yearMonth);
            strSql.Append(" select salemoney,backmoney,realmoney,datetime,bp_id,bp_brand_id,base,plan,bp_brand_name,bp_percentage from (");
            strSql.Append(" select case when salemoney is null then 0 else salemoney end salemoney, ");
            strSql.Append(" case when backmoney is null then 0 else backmoney end backmoney, ");
            strSql.Append(" case when realmoney is null then 0 else realmoney end realmoney, ");
            strSql.Append(" case when datetime is null then 1 else datetime end datetime,bp_id,brand.bp_brand_id,  ");
            strSql.Append(" base,plan, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when bp_percentage is null or bp_brand_name='' then '0.8' else bp_percentage end bp_percentage ");
            strSql.Append(" from ecs_brand_percentage brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(a_" + month + ") base,sum( b_" + month + ") plan,bc_brand_id,bc_brand_name");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join ecs_brand_check eck on emp.emp_code=eck.bc_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne + " and eck.bc_year=" + year);
            }
            strSql.Append(" group by bc_brand_id ");
            strSql.Append(" ) bc ON bc.bc_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,bp_brand_id,orderdate as datetime");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by orderdate,bp_brand_id ");
            strSql.Append(" ) as dds ON dds.bp_brand_id=brand.bp_brand_id ");
            strSql.Append(qtBrand + " and brand.bp_year=" + year);
            strSql.Append(" )al");
            strSql.Append(" order by bp_id,datetime ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetAllBrandManagerData(string strSqlOne, string yearMonth, string year, string month, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandSaleDataSql(year, yearMonth);
            strSql.Append(" select salemoney,backmoney,realmoney,datetime,brand.brand_id bp_brand_id,brand_base base,brand_plan plan,brand_name bp_brand_name,0 bp_percentage ");
            strSql.Append(" FROM dms_brand_manager brand ");//品牌经理下的品牌，不限于考核品牌
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,brand_id,orderdate as datetime");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by orderdate,brand_id ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.brand_id ");
            strSql.Append(qtBrand);
            strSql.Append(" order by bp_brand_id,datetime ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetBrandManagerDms(string strSqlOne, string year, string month,string month2, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year + " and ordermonth=" + month2);
            strSql.Append(" select salemoney,backmoney,realmoney,datetime,bp_id,bp_brand_id,base,plan,bp_brand_name,bp_percentage from (");
            strSql.Append(" select case when salemoney is null then 0 else salemoney end salemoney, ");
            strSql.Append(" case when backmoney is null then 0 else backmoney end backmoney, ");
            strSql.Append(" case when realmoney is null then 0 else realmoney end realmoney, ");
            strSql.Append(" case when datetime is null then 1 else datetime end datetime,bp_id,brand.bp_brand_id,  ");
            strSql.Append(" base,plan, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when bp_percentage is null or bp_brand_name='' then '0.8' else bp_percentage end bp_percentage ");
            strSql.Append(" from ecs_brand_percentage brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(a_" + month + ") base,sum( b_" + month + ") plan,bc_brand_id,bc_brand_name");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join ecs_brand_check eck on emp.emp_code=eck.bc_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne + " and eck.bc_year=" + year);
            }
            strSql.Append(" group by bc_brand_id ");
            strSql.Append(" ) bc ON bc.bc_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,bp_brand_id,orderdate as datetime");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by datetime,bp_brand_id ");
            strSql.Append(" ) as dds ON dds.bp_brand_id=brand.bp_brand_id ");
            strSql.Append(qtBrand + " and brand.bp_year=" + year);
            strSql.Append(" )al");
            strSql.Append(" order by bp_id,datetime ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetAllBrandManagerDms(string strSqlOne, string year, string month2, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year + " and ordermonth=" + month2);
            strSql.Append(" select salemoney,backmoney,realmoney,datetime,brand.brand_id bp_brand_id,brand_base base,brand_plan plan,brand_name bp_brand_name,0 bp_percentage ");
            strSql.Append(" FROM dms_brand_manager brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,brand_id,orderdate as datetime");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and orderdate is not null ");
            strSql.Append(" group by datetime,brand_id ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.brand_id ");
            strSql.Append(qtBrand);
            strSql.Append(" order by bp_brand_id,datetime ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 品牌月度详情页
        #region 品牌月度下员工排名
        public DataSet GetBrandManagerData_Emp(string strSqlOne, string yearMonth,string year, string month, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandSaleDataSql(year, yearMonth);

            strSql.Append(" select salemoney,backmoney,realmoney,code,name,bp_id,bp_brand_id,bp_brand_name,base,plan , case when realmoney/plan*100 is null then 0 else realmoney/plan*100 end wcl from ( ");
            strSql.Append(" select salemoney,backmoney,realmoney,emp_code code,name,bp_id,brand.bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when  b_" + month + "  is null then 0 else b_" + month + " end base,case when  a_" + month + "  is null then 0 else a_" + month + " end plan ");
            strSql.Append(" from ecs_brand_percentage brand ");
            strSql.Append(" left join(select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,emp_code,name,bp_brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by bp_brand_id,emp_code  ) as dds ");
            strSql.Append(" ON dds.bp_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join ecs_brand_check eck on eck.bc_user_name=dds.emp_code and eck.bc_brand_id=dds.bp_brand_id ");
            strSql.Append(qtBrand + " and eck.bc_year=" + year + " and brand.bp_year=" + year);
            strSql.Append(" order by bp_id,realmoney desc )tt ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetAllBrandManagerData_Emp(string strSqlOne, string yearMonth, string year,string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandSaleDataSql(year,yearMonth);
            strSql.Append(" select salemoney,backmoney,realmoney,dds.emp_code code,dds.name,brand.brand_id bp_brand_id,brand_name bp_brand_name,0 base,0 plan, 0 wcl ");
            strSql.Append(" FROM dms_brand_manager brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,emp_code,name,brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by brand_id,emp_code ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.brand_id ");
            strSql.Append(qtBrand);
            strSql.Append(" order by bp_brand_id,realmoney desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetBrandManagerDms_Emp(string strSqlOne, string year, string month, string month2, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year + " and ordermonth=" + month2);

            strSql.Append(" select salemoney,backmoney,realmoney,code,name,bp_id,bp_brand_id,bp_brand_name,base,plan , case when realmoney/plan*100 is null then 0 else realmoney/plan*100 end wcl from ( ");
            strSql.Append(" select salemoney,backmoney,realmoney,emp_code code,name,bp_id,brand.bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name, ");
            strSql.Append(" case when  b_" + month + "  is null then 0 else b_" + month + " end base,case when  a_" + month + "  is null then 0 else a_" + month + " end plan ");
            strSql.Append(" from ecs_brand_percentage brand ");
            strSql.Append(" left join(select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,emp_code,name,bp_brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by bp_brand_id,emp_code  ) as dds ");
            strSql.Append(" ON dds.bp_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join ecs_brand_check eck on eck.bc_user_name=dds.emp_code and eck.bc_brand_id=dds.bp_brand_id ");
            strSql.Append( qtBrand + " and eck.bc_year=" + year + " and brand.bp_year=" + year);
            strSql.Append(" order by bp_id,realmoney desc )tt ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetAllBrandManagerDms_Emp(string strSqlOne, string year, string month2, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year + " and ordermonth=" + month2);
            strSql.Append(" select salemoney,backmoney,realmoney,dds.emp_code code,dds.name,brand.brand_id bp_brand_id,brand_name bp_brand_name,0 base,0 plan, 0 wcl ");
            strSql.Append(" FROM dms_brand_manager brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,emp_code,name,brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by brand_id,emp_code ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.brand_id ");
            strSql.Append(qtBrand);
            strSql.Append(" order by bp_brand_id,realmoney desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        } 
        #endregion

        #region 品牌月度下商品排名
        public DataSet GetBrandManagerData_Good(string strSqlOne, string yearMonth, string year, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandSaleDataSql(year, yearMonth);

            strSql.Append(" select salemoney,backmoney,realmoney,code,name,bp_id,bp_brand_id,bp_brand_name from ( ");
            strSql.Append(" select salemoney,backmoney,realmoney,goods_id code,goods_name name,bp_id,brand.bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name ");
            strSql.Append(" from ecs_brand_percentage brand left join");
            strSql.Append(" (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,goods_id,goods_name,bp_brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by bp_brand_id,goods_id  ) as dds ");
            strSql.Append(" ON dds.bp_brand_id=brand.bp_brand_id ");
            strSql.Append(  qtBrand +" and brand.bp_year=" + year);
            strSql.Append(" order by bp_id,realmoney desc )tt limit 100 ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetAllBrandManagerData_Good(string strSqlOne, string yearMonth, string year, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandSaleDataSql(year, yearMonth);

            strSql.Append(" select salemoney,backmoney,realmoney,goods_id code,goods_name name,brand.brand_id bp_brand_id,brand_name bp_brand_name ");
            strSql.Append(" FROM dms_brand_manager brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,goods_id,goods_name,brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by brand_id,goods_id ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.brand_id ");
            strSql.Append(  qtBrand);
            strSql.Append(" order by bp_brand_id,realmoney desc limit 100 ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetBrandManagerDms_Good(string strSqlOne, string year, string month2, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year + " and ordermonth=" + month2);

            strSql.Append(" select salemoney,backmoney,realmoney,code,name,bp_id,bp_brand_id,bp_brand_name from ( ");
            strSql.Append(" select salemoney,backmoney,realmoney,goods_id code,goods_name name,bp_id,brand.bp_brand_id, ");
            strSql.Append(" case when bp_brand_name is null or bp_brand_name='' then '其它品牌' else bp_brand_name end bp_brand_name ");
            strSql.Append(" from ecs_brand_percentage brand left join");
            strSql.Append(" (select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,goods_id,goods_name,bp_brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by bp_brand_id,goods_id  ) as dds ");
            strSql.Append(" ON dds.bp_brand_id=brand.bp_brand_id ");
            strSql.Append( qtBrand + " and brand.bp_year=" + year);
            strSql.Append(" order by bp_id,realmoney desc )tt limit 100 ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetAllBrandManagerDms_Good(string strSqlOne, string year, string month2, string qtBrand)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year + " and ordermonth=" + month2);

            strSql.Append(" select salemoney,backmoney,realmoney,goods_id code,goods_name name,brand.brand_id bp_brand_id,brand_name bp_brand_name ");
            strSql.Append(" FROM dms_brand_manager brand ");
            strSql.Append(" left join (");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,goods_id,goods_name,brand_id");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }
            strSql.Append(" and datetime is not null ");
            strSql.Append(" group by brand_id,goods_id ");
            strSql.Append(" ) as dds ON dds.brand_id=brand.brand_id ");
            strSql.Append(qtBrand);
            strSql.Append(" order by bp_brand_id,realmoney desc limit 100 ");
            return DbHelperMySQL.Query(strSql.ToString());
        } 
        #endregion

        #endregion

        #endregion
        
        #region 薪资
        /// <summary>
        /// 获取个人薪资部分，品牌月提成
        /// 根据emp_code区分是部门还是个人，还是全部cast(bp_percentage as decimal(18,2)),其他品牌默认为0.8
        /// </summary>
        public DataSet GetBrandPercentageData(string a_, string b_, string strSqlOne, string emp_code, string year, string month2, string yearMonth, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandSaleDataSql(year, yearMonth);
            strSql.Append(" insert into dms_brand_percentage ");
            strSql.Append(" select null," + year + ",'" + month2 + "',al.* ,realmoney_brand-plan_brand cha_brand,case when realmoney_brand/plan_brand*100 is null then 0 else realmoney_brand/plan_brand*100 end wcl_brand,(realmoney_brand-base_brand)*bp_percentage*0.01 percentage_brand,sysdate() create_time from ( ");
            strSql.Append(" select bc_user_name,bc_real_name,bc_brand_id, ");
            strSql.Append(" CASE WHEN bc_brand_name IS NULL OR bc_brand_name='' THEN '其它'  ELSE bc_brand_name END bc_brand_name, ");
            strSql.Append(" CASE WHEN " + a_ + " IS NULL THEN bc_base ELSE " + a_ + " END base_brand," + b_ + " plan_brand,bp_percentage, ");
            strSql.Append(" case when salemoney is null then 0 else salemoney end salemoney_brand, ");
            strSql.Append(" case when backmoney is null then 0 else backmoney end backmoney_brand, ");
            strSql.Append(" case when realmoney is null then 0 else realmoney end realmoney_brand ");
            strSql.Append("  from ecs_brand_check  AS ck ");
            strSql.Append(" left join hr_employee emp ON emp.emp_code=ck.bc_user_name ");
            strSql.Append(" left join ecs_brand_percentage brand ON ck.bc_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join ( ");
            strSql.Append("     select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,admin_user_name,bp_brand_id from ( ");
            strSql.Append("              " + saleData + ")b group by admin_user_name,bp_brand_id ");
            strSql.Append(" )AS abc ON emp.emp_code=abc.admin_user_name and ck.bc_brand_id=abc.bp_brand_id ");
            strSql.Append(  strSqlOne + " and emp.emp_code IN(" + emp_code + ") and ck.bc_year=" + year + " and brand.bp_year=" + year);
            strSql.Append(" ) al  ");
            strSql.Append(" order by " + filedOrder);

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetBrandPercentageDms(string a_, string b_, string strSqlOne, string emp_code, string year, string month2, string yearMonth, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year + " and ordermonth=" + month2);
            strSql.Append(" insert into dms_brand_percentage ");
            strSql.Append(" select null," + year + ",'" + month2 + "',al.* ,realmoney_brand-plan_brand cha_brand,case when realmoney_brand/plan_brand*100 is null then 0 else realmoney_brand/plan_brand*100 end wcl_brand,(realmoney_brand-base_brand)*bp_percentage*0.01 percentage_brand,sysdate() create_time from ( ");
            strSql.Append(" select bc_user_name,bc_real_name,bc_brand_id, ");
            strSql.Append(" CASE WHEN bc_brand_name IS NULL OR bc_brand_name='' THEN '其它'  ELSE bc_brand_name END bc_brand_name, ");
            strSql.Append(" CASE WHEN " + a_ + " IS NULL THEN bc_base ELSE " + a_ + " END base_brand," + b_ + " plan_brand,bp_percentage, ");
            strSql.Append(" case when salemoney is null then 0 else salemoney end salemoney_brand, ");
            strSql.Append(" case when backmoney is null then 0 else backmoney end backmoney_brand, ");
            strSql.Append(" case when realmoney is null then 0 else realmoney end realmoney_brand ");
            strSql.Append("  from ecs_brand_check  AS ck ");
            strSql.Append(" left join hr_employee emp ON emp.emp_code=ck.bc_user_name ");
            strSql.Append(" left join ecs_brand_percentage brand ON ck.bc_brand_id=brand.bp_brand_id ");
            strSql.Append(" left join ( ");
            strSql.Append("     select sum(salemoney) as salemoney,sum(backmoney) as backmoney,sum(salemoney+backmoney) as realmoney,admin_user_name,bp_brand_id from ( ");
            strSql.Append("              " + saleData + ")b group by admin_user_name,bp_brand_id ");
            strSql.Append(" )AS abc ON emp.emp_code=abc.admin_user_name and ck.bc_brand_id=abc.bp_brand_id ");
            strSql.Append(  strSqlOne + " and emp.emp_code IN(" + emp_code + ") and ck.bc_year=" + year + " and brand.bp_year=" + year);
            strSql.Append(" ) al  ");
            strSql.Append(" order by " + filedOrder);

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 传入时间段，所有部门人，d_id
        /// 个人月/节点排名，取冠军,根据完成率排名
        /// </summary>
        //public DataSet GetPersonalMonthRankData(string monthColumns, string strSqlOne, string d_ids, string year, string month, string yearMonth, decimal champion, decimal bonus)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    string saleData = GetMonthSaleDataSql(yearMonth);
        //    strSql.Append(" insert into dms_monthnode_sale  ");
        //    strSql.Append(" select NULL," + year + ",'" + month + "', admin_user_name,name,d_pid,d_pname,salemoney_personal,backmoney_personal,realmoney_personal,base_personal,plan_personal,cha_personal,wcl_personal, ");
        //    strSql.Append("   CASE WHEN wcl_personal>100 THEN " + bonus + " ELSE 0 END personal_bonus,CASE WHEN rownum=1 then " + champion + " ELSE 0 END personal_champion,sysdate() create_time from( ");

        //    strSql.Append(" select @rownum:=@rownum+1 AS rownum,admin_user_name,name,d_pid,d_pname,salemoney_personal,backmoney_personal,realmoney_personal,base_personal,plan_personal,cha_personal,wcl_personal from (SELECT @rownum:=0) r,( ");
        //    strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid,d_name d_pname,plan_personal,base_personal, ");
        //    strSql.Append(" case when realmoney_personal-plan_personal is null then 0 else realmoney_personal-plan_personal end cha_personal, ");
        //    //strSql.Append(" case when realmoney_personal/plan_personal*100 is null then 0 else realmoney_personal/plan_personal*100 end wcl_personal ");
        //    strSql.Append(" case when exclude_emp_code is null then case when realmoney_personal/plan_personal*100 IS null then 0 ELSE realmoney_personal/plan_personal*100 end else 0 end wcl_personal ");
            
        //    strSql.Append(" from ( ");
        //    strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid, ");
        //    strSql.Append(" case when plan is null then 0 else plan end plan_personal, ");
        //    strSql.Append(" case when base is null then 0 else base end base_personal,exclude_emp_code ");
        //    strSql.Append(" from  ");
        //    strSql.Append(" (select case when sum(salemoney) is null then 0 else sum(salemoney) end  AS salemoney_personal,case when sum(backmoney) is null then 0 else sum(backmoney) end  AS backmoney_personal, case when sum(salemoney+backmoney) is null then 0 else sum(salemoney+backmoney) end  AS realmoney_personal,emp_code as admin_user_name,name, ");
        //    strSql.Append(" d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
        //    strSql.Append(" from hr_employee as emp ");
        //    strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");

        //    strSql.Append(" left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name" + strSqlOne + d_ids);
        //    strSql.Append(" group by emp_code ");
        //    strSql.Append(" order by realmoney_personal desc) dds ");
        //    strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2)) as plan,kf_uname from dms_set_rating where plan_year=" + year + ") pl on dds.admin_user_name=pl.kf_uname  ");
        //    strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2)) as base,kf_uname from ecs_month_base where plan_year=" + year + ") bs on dds.admin_user_name=bs.kf_uname  ");
        //    strSql.Append(" left join (select exclude_emp_code from dms_set_exclude ) pc on dds.admin_user_name=pc.exclude_emp_code )al ");
        //    strSql.Append(" left join hr_department AS dep ON al.d_pid=dep.id )ak ");
        //    strSql.Append(" order by wcl_personal desc ) aa");
        //    return DbHelperMySQL.Query(strSql.ToString());
        //}
        public DataSet GetPersonalMonthRankData(string monthColumns, string strSqlOne, string d_ids, string year, string month, string yearMonth, decimal champion, decimal bonus)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth);
            strSql.Append(" insert into dms_monthnode_sale  ");
            strSql.Append(" select NULL," + year + ",'" + month + "', admin_user_name,name,d_pid,d_pname,salemoney_personal,backmoney_personal,realmoney_personal,rating_personal,plan_personal,wcl_champion,wcl_personal, ");
            strSql.Append("   CASE WHEN wcl_personal>100 THEN " + bonus + " ELSE 0 END personal_bonus,CASE WHEN rownum=1 then " + champion + " ELSE 0 END personal_champion,sysdate() create_time from( ");

            strSql.Append(" select @rownum:=@rownum+1 AS rownum,admin_user_name,name,d_pid,d_pname,salemoney_personal,backmoney_personal,realmoney_personal,rating_personal,plan_personal,wcl_champion,wcl_personal from (SELECT @rownum:=0) r,( ");
            strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid,d_name d_pname,rating_personal,plan_personal, ");
            strSql.Append(" case when exclude_emp_code is null then case when realmoney_personal/rating_personal*100 IS null then 0 ELSE realmoney_personal/rating_personal*100 end else 0 end wcl_champion, ");
            strSql.Append(" case when exclude_emp_code is null then case when realmoney_personal/plan_personal*100 IS null then 0 ELSE realmoney_personal/plan_personal*100 end else 0 end wcl_personal ");

            strSql.Append(" from ( ");
            strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid, ");
            strSql.Append(" case when rating is null then 0 else rating end rating_personal, ");
            strSql.Append(" case when plan is null then 0 else plan end plan_personal,exclude_emp_code ");
            strSql.Append(" from  ");
            strSql.Append(" (select case when sum(salemoney) is null then 0 else sum(salemoney) end  AS salemoney_personal,case when sum(backmoney) is null then 0 else sum(backmoney) end  AS backmoney_personal, case when sum(salemoney+backmoney) is null then 0 else sum(salemoney+backmoney) end  AS realmoney_personal,emp_code as admin_user_name,name, ");
            strSql.Append(" d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");

            strSql.Append(" left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name" + strSqlOne + d_ids);
            strSql.Append(" group by emp_code ");
            strSql.Append(" order by realmoney_personal desc) dds ");
            strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2)) as rating,kf_uname from dms_set_rating where plan_year=" + year + ") rat on dds.admin_user_name=rat.kf_uname  ");
            strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2)) as plan,kf_uname from ecs_per_plan where plan_year=" + year + ") pl on dds.admin_user_name=pl.kf_uname  ");
            strSql.Append(" left join (select exclude_emp_code from dms_set_exclude ) pc on dds.admin_user_name=pc.exclude_emp_code )al ");
            strSql.Append(" left join hr_department AS dep ON al.d_pid=dep.id )ak ");
            strSql.Append(" order by wcl_champion desc ) aa");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 传入时间段，所有部门人，d_id
        /// 个人月/节点排名，取冠军,根据完成率排名
        /// </summary>
        public DataSet GetPersonalNodeRankData(string monthColumns, string strSqlOne, string d_ids, string node_oneA, string node_oneB, string year, string month, decimal champion, decimal bonus)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetNodeSaleDataSql(node_oneA, node_oneB);

            strSql.Append(" insert into dms_monthnode_sale  ");
            strSql.Append(" select NULL," + year + ",'" + month + "', admin_user_name,name,d_pid,d_pname,salemoney_personal,backmoney_personal,realmoney_personal,rating_personal,plan_personal,wcl_champion,wcl_personal, ");
            strSql.Append("   CASE WHEN wcl_personal>100 THEN " + bonus + " ELSE 0 END personal_bonus,CASE WHEN rownum=1 then " + champion + " ELSE 0 END personal_champion,sysdate() create_time from( ");

            strSql.Append(" select @rownum:=@rownum+1 AS rownum,admin_user_name,name,d_pid,d_pname,salemoney_personal,backmoney_personal,realmoney_personal,rating_personal,plan_personal,wcl_champion,wcl_personal from (SELECT @rownum:=0) r,( ");
            strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid,d_name d_pname,rating_personal,plan_personal, ");
            strSql.Append(" case when exclude_emp_code is null then case when realmoney_personal/rating_personal*100 IS null then 0 ELSE realmoney_personal/rating_personal*100 end else 0 end wcl_champion, ");
            strSql.Append(" case when exclude_emp_code is null then case when realmoney_personal/plan_personal*100 IS null then 0 ELSE realmoney_personal/plan_personal*100 end else 0 end wcl_personal ");
            strSql.Append(" from ( ");
            strSql.Append(" select salemoney_personal,backmoney_personal,realmoney_personal,admin_user_name,name,d_pid, ");
            strSql.Append(" case when rating is null then 0 else rating end rating_personal, ");
            strSql.Append(" case when plan is null then 0 else plan end plan_personal,exclude_emp_code ");
            strSql.Append(" from  ");
            strSql.Append(" (select case when sum(salemoney) is null then 0 else sum(salemoney) end  AS salemoney_personal,case when sum(backmoney) is null then 0 else sum(backmoney) end  AS backmoney_personal, case when sum(salemoney+backmoney) is null then 0 else sum(salemoney+backmoney) end  AS realmoney_personal,emp_code as admin_user_name,name, ");
            strSql.Append(" d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" from hr_employee as emp ");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");

            strSql.Append(" left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name" + strSqlOne + d_ids);
            strSql.Append(" group by emp_code ");
            strSql.Append(" order by realmoney_personal desc) dds ");
            strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2))/4 as rating,kf_uname from dms_set_rating where plan_year=" + year + ") rat on dds.admin_user_name=rat.kf_uname  ");
            strSql.Append(" left join (select cast(" + monthColumns + " as decimal(18,2))/4 as plan,kf_uname from ecs_per_plan where plan_year=" + year + ") pl on dds.admin_user_name=pl.kf_uname  ");
            strSql.Append(" left join (select exclude_emp_code from dms_set_exclude ) pc on dds.admin_user_name=pc.exclude_emp_code )al ");
            strSql.Append(" left join hr_department AS dep ON al.d_pid=dep.id )ak ");
            strSql.Append(" order by wcl_champion desc ) aa");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 传入时间段
        /// 团队月/节点总排名，团队冠军奖,团队节点排名，团队节点冠军
        /// </summary>
        public DataSet GetTeamMonthRankData(string monthColumns, string strSqlOne, string d_ids, string yearMonth, string year, string month, decimal champion,string name)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetMonthSaleDataSql(yearMonth);

            strSql.Append(" insert into dms_team_bonus  ");
            strSql.Append(" select NULL," + year + ",'" + month + "', d_pid,d_pname,salemoney_team,backmoney_team,realmoney_team,plan_team,base_team,cha_team,wcl_team, ");
            strSql.Append(" 0 team_bonus,CASE WHEN rownum=1 THEN " + champion + " ELSE 0 END team_champion,sysdate() create_time,'" + name + "' create_name from ( ");

            strSql.Append(" select @rownum:=@rownum+1 AS rownum,d_pid,d_pname,salemoney_team,backmoney_team,realmoney_team,plan_team,base_team,cha_team,wcl_team,db_100,db_90  ");
            strSql.Append(" from (SELECT @rownum:=0) r,(SELECT d_pid,d_pname,salemoney_team,backmoney_team,realmoney_team,plan_team,base_team, ");
            strSql.Append("  case when realmoney_team-plan_team is null then 0 else realmoney_team-plan_team end cha_team, case when realmoney_team/plan_team*100 is null then 0 else realmoney_team/plan_team*100 end wcl_team,db_100,db_90 from ");
            strSql.Append("   (select sum(salemoney) as salemoney_team,sum(backmoney) as backmoney_team, sum(salemoney+backmoney) as realmoney_team,d_pid,d_name d_pname,sum(plan) as plan_team,sum(base) as base_team ");
            strSql.Append("    from (select salemoney,backmoney,realmoney,d_pid, case when plan is null then 0 else plan end plan, case when base is null then 0 else base end base ");
            strSql.Append("       from (select case when sum(salemoney) is null then 0 else sum(salemoney) end  AS salemoney,case when sum(backmoney) is null then 0 else sum(backmoney) end  AS backmoney, case when sum(salemoney+backmoney) is null then 0 else sum(salemoney+backmoney) end  AS realmoney, emp_code as admin_user_name,name,d_id,dname, ");
            strSql.Append(" 		 case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append("          from hr_employee as emp ");
            strSql.Append("          left join hr_department as dep on emp.d_id=dep.id ");

            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name" + strSqlOne + d_ids);
            strSql.Append("          group by emp_code ");
            strSql.Append("          order by realmoney desc) dds ");
            strSql.Append("       left join ");
            strSql.Append("         (select cast(" + monthColumns + " as decimal(18,2)) as plan,kf_uname from ecs_per_plan where plan_year=" + year + ") pl on dds.admin_user_name=pl.kf_uname ");
            strSql.Append("       left join ");
            strSql.Append("         (select cast(" + monthColumns + " as decimal(18,2)) as base,kf_uname from ecs_month_base where plan_year=" + year + ") bs on dds.admin_user_name=bs.kf_uname ");
            strSql.Append("       left join (select exclude_emp_code from dms_set_exclude ) pc on dds.admin_user_name=pc.exclude_emp_code ");
            strSql.Append(" 		)al left join hr_department AS dep ON al.d_pid=dep.id ");
            strSql.Append(" 	group by d_pid)ak  ");
            strSql.Append(" 	LEFT JOIN dms_set_bonus_team b on b.d_id=ak.d_pid)t ");
            strSql.Append(" where wcl_team>0 order by wcl_team desc ) aaa ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 传入时间段
        /// 团队月/节点总排名，团队冠军奖,团队节点排名，团队节点冠军
        /// </summary>
        public DataSet GetTeamNodeRankData(string monthColumns, string strSqlOne, string d_ids, string node_oneA, string node_oneB, string year, string month, decimal champion, string name)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetNodeSaleDataSql(node_oneA, node_oneB);

            strSql.Append(" insert into dms_team_bonus  ");
            strSql.Append(" select NULL," + year + ",'" + month + "', d_pid,d_pname,salemoney_team,backmoney_team,realmoney_team,plan_team,base_team,cha_team,wcl_team, ");
            strSql.Append(" CASE WHEN wcl_team>100 THEN db_100 WHEN wcl_team>90 THEN db_90 ELSE 0 END team_bonus,CASE WHEN rownum=1 THEN " + champion + " ELSE 0 END team_champion,sysdate() create_time,'" + name + "' create_name from ( ");

            strSql.Append(" select @rownum:=@rownum+1 AS rownum,d_pid,d_pname,salemoney_team,backmoney_team,realmoney_team,plan_team,base_team,cha_team,wcl_team,db_100,db_90  ");
            strSql.Append(" from (SELECT @rownum:=0) r,(SELECT d_pid,d_pname,salemoney_team,backmoney_team,realmoney_team,plan_team,base_team, ");
            strSql.Append("  case when realmoney_team-plan_team is null then 0 else realmoney_team-plan_team end cha_team, case when realmoney_team/plan_team*100 is null then 0 else realmoney_team/plan_team*100 end wcl_team,db_100,db_90 from ");
            strSql.Append("   (select sum(salemoney) as salemoney_team,sum(backmoney) as backmoney_team, sum(salemoney+backmoney) as realmoney_team,d_pid,d_name d_pname,sum(plan) as plan_team,sum(base) as base_team ");
            strSql.Append("    from (select salemoney,backmoney,realmoney,d_pid, case when plan is null then 0 else plan end plan, case when base is null then 0 else base end base ");
            strSql.Append("       from (select case when sum(salemoney) is null then 0 else sum(salemoney) end  AS salemoney,case when sum(backmoney) is null then 0 else sum(backmoney) end  AS backmoney, case when sum(salemoney+backmoney) is null then 0 else sum(salemoney+backmoney) end  AS realmoney, emp_code as admin_user_name,name,d_id,dname, ");
            strSql.Append(" 		 case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append("          from hr_employee as emp ");
            strSql.Append("          left join hr_department as dep on emp.d_id=dep.id ");

            strSql.Append("       left join  (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name" + strSqlOne + d_ids);
            strSql.Append("          group by emp_code ");
            strSql.Append("          order by realmoney desc) dds ");
            strSql.Append("       left join ");
            strSql.Append("         (select cast(" + monthColumns + " as decimal(18,2))/4 as plan,kf_uname from ecs_per_plan where plan_year=" + year + ") pl on dds.admin_user_name=pl.kf_uname ");
            strSql.Append("       left join ");
            strSql.Append("         (select cast(" + monthColumns + " as decimal(18,2))/4 as base,kf_uname from ecs_month_base where plan_year=" + year + ") bs on dds.admin_user_name=bs.kf_uname ");
            strSql.Append(" 		)al LEFT JOIN hr_department AS dep ON al.d_pid=dep.id ");
            strSql.Append(" 	group by d_pid)ak  ");
            strSql.Append(" 	LEFT JOIN dms_set_bonus_team b on b.d_id=ak.d_pid)t ");
            strSql.Append(" where wcl_team>0 order by wcl_team desc ) aaa ");
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 传入时间段
        /// 基本薪资=根据月客户数，月客户销售额，判断等级
        /// </summary>
        public DataSet GetMonthCustomerSaleData(string strSqlOne, string d_id, string year, string month, string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerMonthSaleSql(yearMonth);

            strSql.Append(" insert into dms_customer_sale ");
            strSql.Append(" select null," + year + ",'" + month + "',admin_user_name,name,d_pid,d_name d_pname,user_id,C_tel user_name,C_customername u_company,salemoney_customer,backmoney_customer,realmoney_customer,sysdate() create_time from  ");
            strSql.Append(" (select sum(salemoney) as salemoney_customer,sum(backmoney) as backmoney_customer,sum(salemoney+backmoney) as realmoney_customer, ");
            strSql.Append("  admin_user_name,name, user_id,d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append("          from hr_employee as emp ");
            strSql.Append("          left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append("         left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" 		" + strSqlOne + d_id + " and admin_user_name is not null");
            strSql.Append("          group by user_id,admin_user_name ");
            strSql.Append("          order by admin_user_name,realmoney_customer desc )as abcd ");
            strSql.Append(" left join hr_department AS dep ON abcd.d_pid=dep.id ");
            strSql.Append(" left join crm_contact as u on abcd.user_id=u.id ");
            return DbHelperMySQL.Query(strSql.ToString());

        }

        /// <summary>
        /// 传入年，月
        /// 获得个人薪资月冠军，节点冠军，节点达标奖励
        /// </summary>
        public DataSet GetPersonalMonthSalaryData(string year, string month)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select year,monthnode month,admin_user_name,name,d_pid,d_pname, ");
            strSql.Append(" case when xy_1000 is null then 0 else xy_1000 end xy_1000,case when dy_1000 is null then 0 else dy_1000 end dy_1000, ");
            strSql.Append(" case when dy_5000 is null then 0 else dy_5000 end dy_5000,case when dy_10000 is null then 0 else dy_10000 end dy_10000, ");
            strSql.Append(" case when dy_20000 is null then 0 else dy_20000 end dy_20000,personal_champion, ");
            strSql.Append(" case when personal_champion1 is null then 0 else personal_champion1 end personal_champion1,case when personal_bonus1 is null then 0 else personal_bonus1 end personal_bonus1, ");
            strSql.Append(" case when personal_champion2 is null then 0 else personal_champion2 end personal_champion2,case when personal_bonus2 is null then 0 else personal_bonus2 end personal_bonus2, ");
            strSql.Append(" case when personal_champion3 is null then 0 else personal_champion3 end personal_champion3,case when personal_bonus3 is null then 0 else personal_bonus3 end personal_bonus3, ");
            strSql.Append(" case when personal_champion4 is null then 0 else personal_champion4 end personal_champion4,case when personal_bonus4 is null then 0 else personal_bonus4 end personal_bonus4, ");
            strSql.Append(" case when percentage_sum is null then 0 else percentage_sum end percentage_sum ");
            strSql.Append(" from dms_monthnode_sale as sm ");
            //基本工资
            strSql.Append(" LEFT JOIN(select count(*) as xy_1000,admin_user_name admin_user_name5 from dms_customer_sale where realmoney_customer<1000 and year=" + year + " and month=" + month + " group by admin_user_name) xy1000   ");
            strSql.Append(" on xy1000.admin_user_name5=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN(select count(*) as dy_1000,admin_user_name admin_user_name6 from dms_customer_sale where realmoney_customer>=1000 and year=" + year + " and month=" + month + " group by admin_user_name) dy1000 ");
            strSql.Append(" on dy1000.admin_user_name6=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN(select count(*) as dy_5000,admin_user_name admin_user_name7 from dms_customer_sale where realmoney_customer>=5000 and year=" + year + " and month=" + month + " group by admin_user_name) dy5000 ");
            strSql.Append(" on dy5000.admin_user_name7=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN(select count(*) as dy_10000,admin_user_name admin_user_name8 from dms_customer_sale where realmoney_customer>=10000 and year=" + year + " and month=" + month + " group by admin_user_name) dy10000 ");
            strSql.Append(" on dy10000.admin_user_name8=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN(select count(*) as dy_20000,admin_user_name admin_user_name9 from dms_customer_sale where realmoney_customer>=20000 and year=" + year + " and month=" + month + " group by admin_user_name) dy20000 ");
            strSql.Append(" on dy20000.admin_user_name9=sm.admin_user_name ");
            //个人节点冠军，节点达标奖励，月冠军
            strSql.Append(" LEFT JOIN (select admin_user_name admin_user_name1,personal_champion personal_champion1,personal_bonus personal_bonus1 from dms_monthnode_sale where year=" + year + " and monthnode=" + month + "01) n1  ");
            strSql.Append(" on n1.admin_user_name1=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN (select admin_user_name admin_user_name2,personal_champion personal_champion2,personal_bonus personal_bonus2 from dms_monthnode_sale where year=" + year + " and monthnode=" + month + "02) n2 ");
            strSql.Append(" on n2.admin_user_name2=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN (select admin_user_name admin_user_name3,personal_champion personal_champion3,personal_bonus personal_bonus3 from dms_monthnode_sale where year=" + year + " and monthnode=" + month + "03) n3 ");
            strSql.Append(" on n3.admin_user_name3=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN (select admin_user_name admin_user_name4,personal_champion personal_champion4,personal_bonus personal_bonus4 from dms_monthnode_sale where year=" + year + " and monthnode=" + month + "04) n4 ");
            strSql.Append(" on n4.admin_user_name4=sm.admin_user_name ");
            strSql.Append(" LEFT JOIN (select sum(percentage_brand) percentage_sum,bc_user_name from dms_brand_percentage where year=" + year + " and month=" + month + "  group by bc_user_name) tc ");
            strSql.Append(" ON sm.admin_user_name=tc.bc_user_name ");

            strSql.Append(" where year=" + year + " and monthnode=" + month + " ");

            return DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion

        #region 客户
        #region 客户主页
                
        #region 个人客户年报
        public DataSet GetCustomerYearSaleBackData(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerYearSaleSql(year);
            string monthCountSql = GetCustomerMonthCountSql(year);

            strSql.Append(" select * from (select abcd.*,d_name d_pname,C_tel user_name,C_customername u_company from (");
            strSql.Append(" select user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name,name,datetime,");
            strSql.Append(" d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime IS NOT NULL ");
            strSql.Append(" group by user_id,datetime order by convert(user_id,signed), datetime ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join hr_department AS dep ON abcd.d_pid=dep.id ");
            strSql.Append(" left join crm_contact as u on abcd.user_id=u.id ) ddd ");
            //每个月份的合计
            strSql.Append(" left join (select datetime datetimeMonth,sum(salemoney) salemoneyMonth,sum(backmoney) backmoneyMonth,sum(salemoney+backmoney) AS realmoneyMonth");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime IS NOT NULL ");
            strSql.Append(" group by datetime) sumMonth on sumMonth.datetimeMonth=ddd.datetime ");
            //每个客户的年合计
            strSql.Append(" left join (select user_id userIdSum,sum(salemoney) salemoneyUser,sum(backmoney) backmoneyUser,sum(salemoney+backmoney) AS realmoneyUser");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime IS NOT NULL ");
            strSql.Append(" group by user_id) sumUser on sumUser.userIdSum=ddd.user_id ");
            //每个客户的分配
            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id");
            //strSql.Append(" where " + strSqlOne);//user_id不存在
            strSql.Append(" group by emp_code) cc on cc.emp_code=ddd.admin_user_name");
            //每个客户的拿货频率
            strSql.Append(" left join (" + monthCountSql + ") ff on ff.user_id=ddd.user_id and ddd.datetime=ff.ordermonth");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCustomerYearSaleBackDms(string admin_user_name, string year)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" select * from (");
            strSql.Append(" select user_id,user_name,u_company,sum(salemoney) salemoney,sum(backmoney) backmoney,sum(realmoney) realmoney,admin_user_name,name,orderyear,ordermonth datetime from dms_customer ");
            strSql.Append(" where admin_user_name=" + admin_user_name + " and orderyear =" + year + " and user_id IS NOT NULL ");
            strSql.Append(" group by ordermonth,user_id order by ordermonth,user_id ) ddd");
            //每个月份的合计
            strSql.Append(" left join (select ordermonth datetimeMonth,sum(salemoney) salemoneyMonth,sum(backmoney) backmoneyMonth,sum(salemoney+backmoney) AS realmoneyMonth");
            strSql.Append("  from dms_customer where admin_user_name=" + admin_user_name + " and orderyear =" + year);
            strSql.Append(" group by ordermonth) sumMonth on sumMonth.datetimeMonth=ddd.datetime ");
            //每个客户的年合计
            strSql.Append(" left join (select user_id userIdSum,sum(salemoney) salemoneyUser,sum(backmoney) backmoneyUser,sum(salemoney+backmoney) AS realmoneyUser");
            strSql.Append("   from dms_customer where admin_user_name=" + admin_user_name + " and orderyear =" + year);
            strSql.Append(" group by user_id) sumUser on sumUser.userIdSum=ddd.user_id ");
            //每个客户的分配
            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id where emp_code=" + admin_user_name);
            strSql.Append(" group by emp_code) cc on cc.emp_code=ddd.admin_user_name");
            //每个客户的拿货频率
            strSql.Append(" left join (select user_id,orderyear,ordermonth,monthCount ");
            strSql.Append("  from dms_customer_monthcount where orderyear = " + year + ") ");
            strSql.Append("  ff on ff.user_id=ddd.user_id and ddd.datetime=ff.ordermonth");
            //每个客户的拿货频率
            strSql.Append("  left join (select user_id,orderyear, sum(monthCount)  year_count ");
            strSql.Append("  from dms_customer_monthcount where orderyear = " + year);
            strSql.Append("  group by user_id,orderyear) ");
            strSql.Append("  yy on yy.user_id=ddd.user_id ");
            strSql.Append(" order by datetime,realmoney desc ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        //用于生成excel
        public DataSet GetCustomerYearDms(string admin_user_name, string year, string yearDays)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select ddd.user_id,user_name,u_company,year_count, convert(" + yearDays + "/year_count,signed) year_frequency,salemoney,backmoney,realmoney, admin_user_name, name from ( ");
            strSql.Append(" select user_id,user_name,u_company,sum(salemoney) salemoney, sum(backmoney) backmoney, sum(realmoney) realmoney, admin_user_name, name, orderyear from dms_customer  ");
            strSql.Append("  where admin_user_name = " + admin_user_name + " and orderyear = " + year + " and user_id IS NOT NULL group by user_name ");
            strSql.Append("  ) ddd ");
            strSql.Append("  left join (select user_id,orderyear, sum(monthCount)  year_count ");
            strSql.Append("  from dms_customer_monthcount where orderyear = " + year );
            strSql.Append(" group by user_id,orderyear)  ");
            strSql.Append("  ff on ff.user_id=ddd.user_id  ");
            strSql.Append("  order by realmoney desc ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 个人客户月报
        public DataSet GetCustomerMonthSaleBackData(string strSqlOne, string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerMonthSaleSql(yearMonth);

            strSql.Append(" select * from (select abcd.*,d_name d_pname,C_tel user_name,C_customername u_company from (");
            strSql.Append(" select user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name,name,lpad(day(abc.datetime), 2, 0) AS orderdate,");
            strSql.Append(" d_id,dname, case when parentid=1 then dep.id else parentid end d_pid ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime IS NOT NULL ");
            strSql.Append(" group by user_id,datetime order by convert(user_id,signed), datetime ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join hr_department AS dep ON abcd.d_pid=dep.id ");
            strSql.Append(" left join crm_contact as u on abcd.user_id=u.id ) ddd ");
            //数据段内每个月客户合计realmoney1
            strSql.Append(" left join (select user_id,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime IS NOT NULL ");
            strSql.Append(" group by user_id) sumAll on sumAll.user_id=ddd.user_id ");
            //分配客户数user_count
            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id");
            //strSql.Append(" where " + strSqlOne);//user_id不存在
            strSql.Append(" group by emp_code) cc on cc.emp_code=ddd.admin_user_name");
            //拿货频率，一个月内拿了几次货 ，不以订单个数，按照天数，一天内的所有订单算一次 monthCount
            strSql.Append(" left join (select count(1) monthCount,user_id user_id2,datetime2 from(");
            strSql.Append(" select abc.* from hr_employee AS emp");
            strSql.Append(" left join (select user_id,oi.admin_user_name,from_unixtime(oi.erp_time, '%m') AS datetime2,from_unixtime(oi.erp_time, '%Y-%m-%d') AS orderdate2");
            strSql.Append(" from xmh_shop.shop_order_info AS oi ");
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%' and erp_time<>0");
            strSql.Append(" ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime2 IS NOT NULL ");
            strSql.Append(" group by user_id,orderdate2 ");
            strSql.Append(" ) ttt group by datetime2,user_id2 ) ff on ff.user_id2=ddd.user_id");// and ddd.datetime=ff.datetime2 都是一个月内不再匹配月份

            strSql.Append(" order by realmoney1 desc,orderdate ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCustomerMonthSaleBackDms(string admin_user_name, string year,string month2)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" select * from (");
            strSql.Append(" select user_id,user_name,u_company,sum(salemoney) salemoney,sum(backmoney) backmoney,sum(realmoney) realmoney,admin_user_name,name,orderdate ");
            strSql.Append(" from dms_customer where admin_user_name=" + admin_user_name + " and orderyear=" + year + " and ordermonth=" + month2 + " and user_id IS NOT NULL ");
            strSql.Append(" group by user_id,orderdate order by user_id,orderdate ) ddd");
            //每个客户的年合计
            strSql.Append(" left join (select user_id userIdSum,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append("   from dms_customer where admin_user_name=" + admin_user_name + " and orderyear=" + year + " and ordermonth=" + month2 );
            strSql.Append(" group by user_id) sumUser on sumUser.userIdSum=ddd.user_id ");
            //每个客户的分配
            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id where emp_code=" + admin_user_name);
            strSql.Append(" group by emp_code) cc on cc.emp_code=ddd.admin_user_name");
            //每个客户的拿货频率
            strSql.Append(" left join (select user_id,monthCount ");
            strSql.Append("  from dms_customer_monthcount where orderyear=" + year + " and ordermonth=" + month2+") ");
            strSql.Append("  ff on ff.user_id=ddd.user_id ");
            strSql.Append(" order by realmoney1 desc,orderdate ");

            return DbHelperMySQL.Query(strSql.ToString());
        } 
        #endregion 

        #region 部门客户年报
        public DataSet GetCustomerYearManagerDepData(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerYearSaleSql(year);
            //销售groupby月内销售
            strSql.Append(" select datetime,admin_user_name emp_code,name,d_pid,d_pname,salemoney,backmoney,realmoney,user_count,");
            strSql.Append(" CASE WHEN deal_count IS NULL THEN 0 ELSE deal_count END deal_count,CASE WHEN deal_number IS NULL THEN 0 ELSE deal_number END deal_number,");
            strSql.Append(" case when deal_count/user_count*100 is null then 0 else deal_count/user_count*100 end deal_rate,case when 25 / deal_number*8 is null then 0 else 25 / deal_number*8 end deal_frequency from( ");
            strSql.Append(" select * from (select abcd.*,d_name d_pname from (");
            strSql.Append(" select admin_user_name,name,datetime,d_id,dname, case when parentid=1 then dep.id else parentid end d_pid,");
            strSql.Append(" sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney ");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append(" left join hr_department as dep on emp.d_id=dep.id ");
            strSql.Append(" left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime IS NOT NULL ");
            strSql.Append(" group by admin_user_name,datetime order by admin_user_name, datetime ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join hr_department AS dep ON abcd.d_pid=dep.id ) ddd ");
            //每个客服的分配
            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id");
            //strSql.Append(" where " + strSqlOne);//user_id不存在
            strSql.Append(" group by emp_code) cp on cp.emp_code=ddd.admin_user_name");


            //每个客户的拿货次数
            strSql.Append(" left join (select admin_user_name admin_user_name3,datetime3,sum(user_deal_number) deal_number,count(1) deal_count from (");
            strSql.Append(" select admin_user_name,user_id,datetime3,count(1) user_deal_number from (");
            strSql.Append(" select abc.* from hr_employee AS emp");
            strSql.Append(" left join (select user_id ,oi.admin_user_name,from_unixtime(oi.erp_time, '%m') AS datetime3,from_unixtime(oi.erp_time, '%Y-%m-%d') AS orderdate2");
            strSql.Append(" from xmh_shop.shop_order_info AS oi ");
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like 'XK-" + year + "%' and erp_time<>0");
            strSql.Append(" ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime3 IS NOT NULL ");
            strSql.Append("group by admin_user_name,user_id,orderdate2 ");
            strSql.Append(" ) abcd group by user_id,datetime3 ");
            strSql.Append(" )abcde group by admin_user_name,datetime3 ) pp on pp.admin_user_name3=ddd.admin_user_name and ddd.datetime=pp.datetime3");


            strSql.Append(" order by datetime,d_pid,realmoney desc ) zzz ");


            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCustomerYearManagerDepDms(string empCodes, string year)
        {
            StringBuilder strSql = new StringBuilder();
            //销售groupby月内销售
            strSql.Append(" select datetime,ddd.admin_user_name emp_code,name,d_pid,d_pname,salemoney,backmoney,realmoney,user_count,");
            strSql.Append(" CASE WHEN deal_count IS NULL THEN 0 ELSE deal_count END deal_count,CASE WHEN deal_number IS NULL THEN 0 ELSE deal_number END deal_number,");
            strSql.Append(" case when deal_count/user_count*100 is null then 0 else deal_count/user_count*100 end deal_rate,case when 25 / deal_number*8 is null then 0 else 25 / deal_number*8 end deal_frequency from( ");
            strSql.Append(" select admin_user_name,name,d_id,dname,d_pid,d_pname,orderyear,ordermonth datetime,");
            strSql.Append(" sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney ");
            strSql.Append(" from dms_customer where admin_user_name in(" + empCodes + ") and orderyear =" + year);
            strSql.Append(" group by admin_user_name,ordermonth order by admin_user_name, ordermonth  ) ddd");
            //每个客服的分配
            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id where emp_code in(" + empCodes + ")");
            strSql.Append(" group by emp_code) cp on cp.emp_code=ddd.admin_user_name");

            strSql.Append(" left join (select admin_user_name,ordermonth,deal_number,deal_count ");
            strSql.Append("  from dms_emp_monthcount where orderyear = " + year + ") ");
            strSql.Append("  ff on ff.admin_user_name=ddd.admin_user_name and ddd.datetime=ff.ordermonth");

            strSql.Append(" order by datetime,d_pid,realmoney desc ");

            return DbHelperMySQL.Query(strSql.ToString());
        } 
        #endregion

        #region 部门客户月报
        public DataSet GetCustomerMonthManagerDepData(string strSqlOne, string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerMonthSaleSql(yearMonth);

            strSql.Append("   select * from (select abcd.*,d_name d_pname,C_tel user_name,C_customername u_company from");
            strSql.Append("   (select user_id,sum(salemoney) salemoney,sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name,name,d_id,dname,CASE WHEN parentid=1 THEN dep.id ELSE parentid END d_pid");
            strSql.Append("    from hr_employee AS emp");
            strSql.Append("    LEFT JOIN hr_department AS dep ON emp.d_id=dep.id");
            strSql.Append("    left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append("         where " + strSqlOne + " and admin_user_name is not null");
            strSql.Append("    group by user_id,admin_user_name");
            strSql.Append("    order by convert(user_id,signed)");
            strSql.Append("     )AS abcd");
            strSql.Append(" LEFT JOIN hr_department AS dep ON abcd.d_pid=dep.id");
            strSql.Append(" LEFT JOIN crm_contact AS u ON abcd.user_id=u.id ) ddd");

            strSql.Append(" left join (select admin_user_name admin_user_name1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from hr_employee AS emp");
            strSql.Append("    left join (" + saleData + ") AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by admin_user_name) sumAll on sumAll.admin_user_name1=ddd.admin_user_name");

            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by emp_code) cc on cc.emp_code=ddd.admin_user_name");

            //拿货频率，一个月内拿了几次货 ，不以订单个数，按照天数，一天内的所有订单算一次 monthCount
            strSql.Append(" left join (select count(1) monthCount,user_id2,datetime2 from(");
            strSql.Append(" select abc.* from hr_employee AS emp");
            strSql.Append(" left join (select user_id user_id2,oi.admin_user_name,from_unixtime(oi.erp_time, '%m') AS datetime2,from_unixtime(oi.erp_time, '%Y-%m-%d') AS orderdate2");
            strSql.Append(" from xmh_shop.shop_order_info AS oi ");
            strSql.Append(" where oi.order_status !=9 and erp_order_sn like 'XK-" + yearMonth + "%' and erp_time<>0");
            strSql.Append(" ) AS abc ON emp.emp_code=abc.admin_user_name");
            strSql.Append(" where " + strSqlOne + " and datetime2 IS NOT NULL ");
            strSql.Append(" group by user_id2,orderdate2 ");
            strSql.Append(" ) ttt group by datetime2,user_id2 ) ff on ff.user_id2=ddd.user_id");// and ddd.datetime=ff.datetime2 都是一个月内不再匹配月份

            strSql.Append(" order by convert(d_pid,signed),realmoney1 DESC,realmoney DESC ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetCustomerMonthManagerDepDms(string empCodes, string year, string month2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from (");
            strSql.Append(" select user_id,user_name,u_company,admin_user_name,name,d_id,dname,d_pid,d_pname,");
            strSql.Append(" sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney ");
            strSql.Append(" from dms_customer where admin_user_name in(" + empCodes + ") and orderyear=" + year + " and ordermonth=" + month2 );
            strSql.Append(" group by user_id,admin_user_name) ddd");

            strSql.Append(" left join (select admin_user_name admin_user_name1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append("   from dms_customer where admin_user_name in(" + empCodes + ") and orderyear=" + year + " and ordermonth=" + month2 );
            strSql.Append(" group by admin_user_name) sumAll on sumAll.admin_user_name1=ddd.admin_user_name ");

            strSql.Append(" left join (select case when beseats_id is null then 0 else count(1) end user_count,emp_code");
            strSql.Append(" from hr_employee emp");
            strSql.Append(" left join crm_customer c on c.beseats_id=emp.id where emp_code in(" + empCodes + ")");
            strSql.Append(" group by emp_code) cc on cc.emp_code=ddd.admin_user_name");

            strSql.Append(" left join (select user_id,monthCount ");
            strSql.Append("  from dms_customer_monthcount where orderyear=" + year + " and ordermonth=" + month2+") ");
            strSql.Append("  ff on ff.user_id=ddd.user_id ");
            strSql.Append(" order by convert(d_pid,signed),realmoney1 DESC,realmoney DESC ");

            return DbHelperMySQL.Query(strSql.ToString());
        } 
        #endregion

        #endregion

        #region 客户详情页

        #region 客户品牌月报
        /// <summary>
        /// 1.客户下，品牌下，月内单品汇总ordermonth datetime
        /// 2.客户下，品牌下单品月内销售情况，具体到每一天，datetime
        /// </summary>
        public DataSet GetCustomerMonthBrandData(string strSqlOne, string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerMonthBrandGoodsSaleSql(yearMonth);

            strSql.Append(" select * from (select abcd.*,C_tel user_name,C_customername u_company from (");
            strSql.Append(" select user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name, ");
            strSql.Append(" sum(goods_number) goods_number,goods_price,datetime,");
            strSql.Append(" brand_id,brand_name,goods_id,goods_name ");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by goods_id order by brand_id asc,realmoney desc ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join crm_contact as u on abcd.user_id=u.id )ddd");

            strSql.Append(" left join (select brand_id brand_id1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by brand_id) sumAll on sumAll.brand_id1=ddd.brand_id");

            strSql.Append(" order by datetime,realmoney1 desc,realmoney desc ");//先按和排序，再按单个排序

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 客户单品月报
        public DataSet GetCustomerMonthBrandGoodsData(string strSqlOne, string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerMonthBrandGoodsSaleSql(yearMonth);

            strSql.Append(" select * from (select abcd.*,C_tel user_name,C_customername u_company from (");
            strSql.Append(" select user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name, ");
            strSql.Append(" sum(goods_number) goods_number,goods_price,datetime,lpad(day(abc.orderdate), 2, 0) AS orderdate,");
            strSql.Append(" brand_id,brand_name,goods_id,goods_name ");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by goods_id,orderdate order by brand_id asc,realmoney desc ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join crm_contact as u on abcd.user_id=u.id )ddd");

            strSql.Append(" left join (select goods_id goods_id1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by goods_id) sumAll on sumAll.goods_id1=ddd.goods_id");

            strSql.Append(" order by datetime,realmoney1 desc,realmoney desc ");//先按和排序，再按单个排序

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion
        
        #region dms客户品牌月报
        public DataSet GetCustomerMonthBrandDms(string strSqlOne, string year, string month2)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year + " and ordermonth=" + month2);

            strSql.Append(" select * from (select abcd.*,C_tel user_name,C_customername u_company from (");
            strSql.Append(" select user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name, ");
            strSql.Append(" sum(goods_number) goods_number,goods_price,ordermonth datetime,");//sum(convert(goods_number,signed)) goods_number
            strSql.Append(" brand_id,brand_name,goods_id,goods_name ");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by goods_id order by brand_id asc,realmoney desc ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join crm_contact as u on abcd.user_id=u.id )ddd");

            strSql.Append(" left join (select brand_id brand_id1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by brand_id) sumAll on sumAll.brand_id1=ddd.brand_id");

            strSql.Append(" order by datetime,realmoney1 desc,realmoney desc ");//先按和排序，再按单个排序

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region dms客户品牌下商品月报
        public DataSet GetCustomerMonthBrandGoodsDms(string strSqlOne, string year, string month2)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year + " and ordermonth=" + month2);

            strSql.Append(" select * from (select abcd.*,C_tel user_name,C_customername u_company from (");
            strSql.Append(" select user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name, ");
            strSql.Append(" sum(goods_number) goods_number,goods_price,ordermonth datetime,orderdate,");
            strSql.Append(" brand_id,brand_name,goods_id,goods_name ");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by goods_id,orderdate order by brand_id asc,realmoney desc ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join crm_contact as u on abcd.user_id=u.id )ddd");

            strSql.Append(" left join (select goods_id goods_id1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by goods_id) sumAll on sumAll.goods_id1=ddd.goods_id");

            strSql.Append(" order by datetime,realmoney1 desc,realmoney desc ");//先按和排序，再按单个排序

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #region 年下面品牌各月份走势

        public DataSet GetCustomerYearBrandGoodsData(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerYearBrandGoodsSaleSql(year);

            strSql.Append(" select * from (select abcd.*,C_tel user_name,C_customername u_company from (");
            strSql.Append(" select user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name, ");
            strSql.Append(" convert(goods_number,signed) goods_number,datetime,");
            strSql.Append(" brand_id,brand_name,goods_id,goods_name ");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by datetime,goods_id order by brand_id asc,realmoney desc ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join crm_contact as u on abcd.user_id=u.id )ddd");

            strSql.Append(" left join (select brand_id brand_id1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by brand_id) sumAll on sumAll.brand_id1=ddd.brand_id");

            strSql.Append(" order by realmoney1 desc,datetime,realmoney desc ");//先按和排序，再按单个排序

            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetCustomerYearBrandGoodsDms(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year);

            strSql.Append(" select * from (select abcd.*,C_tel user_name,C_customername u_company from (");
            strSql.Append(" select user_id,sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) AS realmoney,admin_user_name, ");
            strSql.Append(" convert(goods_number,signed) goods_number,ordermonth datetime,");
            strSql.Append(" brand_id,brand_name,goods_id,goods_name ");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by datetime,goods_id order by brand_id asc,realmoney desc ");
            strSql.Append(" )as abcd");
            strSql.Append(" left join crm_contact as u on abcd.user_id=u.id )ddd");

            strSql.Append(" left join (select brand_id brand_id1,sum(salemoney) salemoney1,sum(backmoney) backmoney1,sum(salemoney+backmoney) AS realmoney1");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by brand_id) sumAll on sumAll.brand_id1=ddd.brand_id");

            strSql.Append(" order by realmoney1 desc,datetime,realmoney desc ");//先按和排序，再按单个排序

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion
        


        /// <summary>
        /// 1.客户下，品牌下，销售单品汇总
        /// 2.客户下，品牌下单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerYearGood(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetCustomerYearBrandGoodsSaleSql(year);

            strSql.Append(" select sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) as realmoney,");
            strSql.Append(" convert(goods_number,signed) goods_number,datetime,lpad(day(abc.orderdate), 2, 0) as orderdate,goods_id,goods_name ");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by orderdate  ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetCustomerYearGoodDms(string strSqlOne, string year)
        {
            StringBuilder strSql = new StringBuilder();
            string saleData = GetBrandDmsSql(" orderyear=" + year);

            strSql.Append(" select sum(salemoney) salemoney, sum(backmoney) backmoney,sum(salemoney+backmoney) as realmoney,");
            strSql.Append(" convert(goods_number,signed) goods_number,ordermonth datetime,orderdate,goods_id,goods_name ");
            strSql.Append(" from (" + saleData + ") AS abc ");
            strSql.Append(" where " + strSqlOne);
            strSql.Append(" group by orderdate  ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion

        #endregion
                
        #region 中间层数据操作
        #region 统计
        #region 月报
        public string GetMonthDmsDataSql(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select salemoney ,backmoney,admin_user_name,datetime");
            strSql.Append("	from dms_month_data ");
            strSql.Append("	where yearmonth ='" + yearMonth + "'");
            return strSql.ToString();
        }


        //删除销售月报
        public bool deleteMonthDms(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from dms_month_data ");
            strSql.Append("	where yearmonth ='" + yearMonth + "'");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //插入销售月报
        public bool insertMonthDms(string yearMonth, string create_name, string factory_id)
        {
            string saleData = GetMonthSaleDataSql(yearMonth);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into dms_month_data");
            strSql.Append(" select NULL,'" + yearMonth + "',md.*,sysdate() create_time," + create_name + " create_name," + factory_id + " factory_id from( ");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,admin_user_name,datetime from (");
            strSql.Append(saleData);
            strSql.Append("	) sd group by datetime,admin_user_name");
            strSql.Append("	order by datetime,admin_user_name) md");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region 年报
        public string GetYearDmsDataSql(string year)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select salemoney,backmoney,admin_user_name,datetime");
            strSql.Append("	from dms_year_data ");
            strSql.Append("	where year =" + year);
            return strSql.ToString();
        }
        //删除销售年报
        public bool deleteYearDms(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            if (sqlWhere != "")
            {
                strSql.Append(" delete from dms_year_data ");
                strSql.Append("	where " + sqlWhere);
                int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //插入销售年报
        public bool insertYearDms(string year,string yearMonth, string create_name, string factory_id)
        {

            string saleData = GetYearSaleDataSql(yearMonth);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into dms_year_data");
            strSql.Append(" select NULL," + year + ",md.*,sysdate() create_time," + create_name + " create_name," + factory_id + " factory_id from( ");
            strSql.Append(" select sum(salemoney) as salemoney,sum(backmoney) as backmoney,admin_user_name,datetime from (");
            strSql.Append(saleData);
            strSql.Append("	) sd group by datetime,admin_user_name");
            strSql.Append("	order by datetime,admin_user_name) md");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #endregion

        #region 品牌

        public string GetBrandDmsSql(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from dms_brand ");
            if (sqlWhere.Trim() != "")
            {
                strSql.Append(" where " + sqlWhere);
            }
            return strSql.ToString();
        }

        //删除销售月报
        public bool deleteBrandDms(string nowYear,string nowMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from dms_brand ");
            strSql.Append("	where orderyear=" + nowYear + " and ordermonth=" + nowMonth + " and  datetime>'2016-11-30'");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //插入销售月报
        public bool insertBrandDms(string yearMonth,string year, string create_name, string factory_id)
        {
            string saleData = GetBrandSaleDataSql(year, yearMonth);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into dms_brand ");
            strSql.Append(" select NULL,md.*,sysdate() create_time," + create_name + " create_name," + factory_id + " factory_id from( ");
            strSql.Append(saleData);
            strSql.Append("	) md");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        
        #region 区域
        public string GetOrderDmsSql(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from dms_order ");
            if (sqlWhere.Trim() != "")
            {
                strSql.Append(" where " + sqlWhere);
            }
            return strSql.ToString();
        }

        //删除销售月报
        public bool deleteOrderDms(string year, string month2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from dms_order ");
            strSql.Append("	where orderyear=" + year + " and ordermonth=" + month2 +" and  datetime>'2016-11-30'");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //插入销售月报
        public bool insertOrderDms(string yearMonth, string create_name, string factory_id)
        {
            string saleData = GetAreaBrandSql(yearMonth, "");
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into dms_order ");
            strSql.Append(" select NULL,md.*,NULL,sysdate() create_time," + create_name + " create_name," + factory_id + " factory_id from( ");
            strSql.Append(saleData);
            strSql.Append("	order by datetime,admin_user_name) md");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 客户
        public string GetCustomerDmsSql(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from dms_customer ");
            if (sqlWhere.Trim() != "")
            {
                strSql.Append(" where " + sqlWhere);
            }
            return strSql.ToString();
        }

        //删除销售月报
        public bool deleteCustomerDms(string year, string month2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from dms_customer ");
            strSql.Append("	where orderyear=" + year + " and ordermonth=" + month2 + " and  datetime>'2016-11-30'");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //插入销售月报
        public bool insertCustomerDms(string yearMonth, string strSqlOne, string create_name, string factory_id)
        {
            string saleData = GetCustomerSaleSql(yearMonth, strSqlOne);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into dms_customer ");
            strSql.Append(" select NULL,md.*,sysdate() create_time," + create_name + " create_name," + factory_id + " factory_id from( ");
            strSql.Append(saleData);
            strSql.Append(" ) md");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 客户成交次数dms_customer_monthcount
        public string GetCustomerMonthCountDmsSql(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from dms_customer_monthcount ");
            if (sqlWhere.Trim() != "")
            {
                strSql.Append(" where " + sqlWhere);
            }
            return strSql.ToString();
        }

        //删除销售月报
        public bool deleteCustomerMonthCountDms(string year, string month2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from dms_customer_monthcount ");
            strSql.Append("	where orderyear=" + year + " and ordermonth=" + month2 + " and  yearmonth>'2016-11-30'");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //插入销售月报
        public bool insertCustomerMonthCountDms(string yearMonth, string create_name, string factory_id)
        {
            string saleData = GetCustomerMonthCountSql(yearMonth);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into dms_customer_monthcount ");
            strSql.Append(" select NULL,md.*,sysdate() create_time," + create_name + " create_name," + factory_id + " factory_id from( ");
            strSql.Append(saleData);
            strSql.Append("	) md");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 员工成交次数dms_emp_monthcount

        //删除销售月报
        public bool deleteEmpMonthCountDms(string year, string month2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from dms_emp_monthcount ");
            strSql.Append("	where orderyear=" + year + " and ordermonth=" + month2 + " and  yearmonth>'2016-11-30'");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //插入销售月报
        public bool insertEmpMonthCountDms(string yearMonth, string create_name, string factory_id)
        {
            string saleData = GetEmpMonthCountSql(yearMonth);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into dms_emp_monthcount ");
            strSql.Append(" select NULL,md.*,sysdate() create_time," + create_name + " create_name," + factory_id + " factory_id from( ");
            strSql.Append(saleData);
            strSql.Append("	) md");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 第三图订单个数
        
        #endregion
        public bool deleteMonthOrderCountDms(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from dms_order_count ");
            strSql.Append("	where date like '" + yearMonth + "%' and  date>'2016-11-30'");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //插入销售月报
        public bool insertMonthOrderCountDms(string yearMonth)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" insert into dms_order_count ");
            strSql.Append(" SELECT NULL, IFNULL(sum(goods_amount), 0) AS feat,count(order_id) orderNum,FROM_UNIXTIME(erp_time, '%Y-%m-%d') AS date,FROM_UNIXTIME(erp_time, '%d') AS daytime,FROM_UNIXTIME(erp_time, '%Y%m') AS date  ");
            strSql.Append(" FROM xmh_shop.shop_order_info ");
            strSql.Append("	WHERE order_status !=9 and erp_order_sn like CONCAT('XK-'," + yearMonth + ",'%')  and erp_time<>0 ");
            strSql.Append("	GROUP BY  FROM_UNIXTIME(erp_time, '%Y-%m-%d'); ");
            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
