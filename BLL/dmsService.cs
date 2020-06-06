using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace XHD.BLL
{
    /// <summary>
    /// dmsService
    /// </summary>
    public partial class dmsService
    {
        private readonly XHD.DAL.dmsDAO dal = new XHD.DAL.dmsDAO();
        //--------------------------------地图---------------------------------------------------------------
        #region 日异常单
        public DataSet GetDateAbnormal_count(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateAbnormal_count(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateAbnormal_status(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateAbnormal_status(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateAbnormal_type(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateAbnormal_type(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateAbnormal_reason(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateAbnormal_reason(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateAbnormal(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateAbnormal(startTime, endTime, returnSqlTxt);
        }


        #endregion



        #region 日订单
        public DataSet GetDateOrder_count(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateOrder_count(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateOrder(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateOrder(startTime, endTime, returnSqlTxt);
        }
        
        public DataSet GetDateOrder_city(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateOrder_city(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateOrder_emp(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateOrder_emp(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateOrder_status(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateOrder_status(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateOrder_shipping(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateOrder_shipping(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateOrder_referer(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateOrder_referer(startTime, endTime, returnSqlTxt);
        }
        public DataSet GetDateOrder_hours(string startTime, string endTime, string returnSqlTxt)
        {
            return dal.GetDateOrder_hours(startTime, endTime, returnSqlTxt);
        }
        #endregion

        #region 迁徙3图
        /// <summary>
        /// 获得当日城市订单
        /// </summary>
        public DataSet GetTodayCityAmt(string date)
        {
            return dal.GetTodayCityAmt(date);
        }

        /// <summary>
        /// 获得当日城市订单
        /// </summary>
        public DataSet GetCityAmt()
        {
            return dal.GetCityAmt();
        }

        /// <summary>
        /// 获得当日省份订单
        /// </summary>
        public DataSet GetTodayProvinceAmt(string date)
        {
            return dal.GetTodayProvinceAmt(date);
        }
        public DataSet GetTodayProvinceDms(string date)
        {
            return dal.GetTodayProvinceDms(date);
        }

        public DataSet getMonthOrderCountData(string yearMonth)
        {
            return dal.getMonthOrderCountData(yearMonth);
        }
        public DataSet getMonthOrderCountDms(string yearMonth)
        {
            return dal.getMonthOrderCountDms(yearMonth);
        }
        public bool deleteMonthOrderCountDms(string yearMonth)
        {
            return dal.deleteMonthOrderCountDms(yearMonth);
        }
        public bool insertMonthOrderCountDms(string yearMonth)
        {
            return dal.insertMonthOrderCountDms(yearMonth);
        }
        #endregion

        #region 区域

        /// <summary>
        /// 商品关键字模糊自动补全
        /// </summary>
        public DataSet GetMonthGoodTxt(string keyWord, string yearMonth, string areaSqlWhere)
        {
            return dal.GetMonthGoodTxt(keyWord, yearMonth, areaSqlWhere);
        }

        #region 省份主页
        /// <summary>
        /// 获得省份主页
        /// </summary>
        public DataSet GetProvinceAmt(string strSqlOne, string yearMonth, string brandManagerSqlWhere, string areaSqlWhere)
        {
            return dal.GetProvinceAmt(strSqlOne, yearMonth, brandManagerSqlWhere, areaSqlWhere);
        }
        public DataSet GetProvinceAmtDms(string strSqlOne,string year,string month2, string brandManagerSqlWhere, string areaSqlWhere)
        {
            return dal.GetProvinceAmtDms(strSqlOne,year,month2, brandManagerSqlWhere, areaSqlWhere);
        }
        #endregion

        #region 城市主页
        /// <summary>
        /// 获得城市主页
        /// </summary>
        public DataSet GetCityAmt(string strSqlOne, string yearMonth, string areaSqlWhere)
        {
            return dal.GetCityAmt(strSqlOne, yearMonth, areaSqlWhere);
        }
        public DataSet GetCityAmtDms(string strSqlOne, string year, string month2, string areaSqlWhere)
        {
            return dal.GetCityAmtDms(strSqlOne,  year,month2, areaSqlWhere);
        }
        #endregion

        #region 省份详情
        /// <summary>
        /// 获得月份省份内品牌排行
        /// </summary>
        public DataSet GetProvinceYear_MonthsDms(string strSqlOne, string year, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceYear_MonthsDms(strSqlOne, year,  provinceId, areaSqlWhere);
        }
        /// <summary>
        /// 获得月份省份内品牌排行
        /// </summary>
        public DataSet GetProvinceMonth_Brand(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_Brand(strSqlOne, yearMonth, provinceId, areaSqlWhere);
        }
        public DataSet GetProvinceMonth_AllBrand(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_AllBrand(strSqlOne, yearMonth, provinceId, areaSqlWhere);
        }
        public DataSet GetProvinceMonth_BrandDms(string strSqlOne, string year,string month2, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_BrandDms(strSqlOne, year,month2, provinceId, areaSqlWhere);
        }
        public DataSet GetProvinceMonth_AllBrandDms(string strSqlOne, string year, string month2, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_AllBrandDms(strSqlOne,  year,month2, provinceId, areaSqlWhere);
        }
        /// <summary>
        /// 获得月份省份内城市排行
        /// </summary>
        public DataSet GetProvinceMonth_City(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_City(strSqlOne, yearMonth, provinceId, areaSqlWhere);
        }
        public DataSet GetProvinceMonth_CityDms(string strSqlOne, string year,string month2, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_CityDms(strSqlOne, year, month2, provinceId, areaSqlWhere);
        }
        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetProvinceMonth_Good(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_Good(strSqlOne, yearMonth, provinceId, areaSqlWhere);
        }
        public DataSet GetProvinceMonth_GoodDms(string strSqlOne, string year,string month2,string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_GoodDms(strSqlOne, year, month2, provinceId, areaSqlWhere);
        }

        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetProvinceMonth_Emp(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_Emp(strSqlOne, yearMonth, provinceId, areaSqlWhere);
        }
        public DataSet GetProvinceMonth_EmpDms(string strSqlOne, string year,string month2, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_EmpDms(strSqlOne, year, month2, provinceId, areaSqlWhere);
        }
        /// <summary>
        /// 获得月份省份内客户排行
        /// </summary>
        public DataSet GetProvinceMonth_Customer(string strSqlOne, string yearMonth, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_Customer(strSqlOne, yearMonth, provinceId, areaSqlWhere);
        }
        public DataSet GetProvinceMonth_CustomerDms(string strSqlOne, string year, string month2, string provinceId, string areaSqlWhere)
        {
            return dal.GetProvinceMonth_CustomerDms(strSqlOne, year, month2, provinceId, areaSqlWhere);
        }
        #endregion

        #region 城市详情
        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetCityYear_MonthsDms(string strSqlOne, string year, string cityId, string areaSqlWhere)
        {
            return dal.GetCityYear_MonthsDms(strSqlOne, year, cityId, areaSqlWhere);
        }
        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetCityMonth_Brand(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_Brand(strSqlOne, yearMonth, cityId, areaSqlWhere);
        }
        public DataSet GetCityMonth_AllBrand(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_AllBrand(strSqlOne, yearMonth, cityId, areaSqlWhere);
        }
        public DataSet GetCityMonth_BrandDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_BrandDms(strSqlOne, year, month2, cityId, areaSqlWhere);
        }
        public DataSet GetCityMonth_AllBrandDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_AllBrandDms(strSqlOne, year, month2, cityId, areaSqlWhere);
        }
        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetCityMonth_Good(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_Good(strSqlOne, yearMonth, cityId, areaSqlWhere);
        }
        public DataSet GetCityMonth_GoodDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_GoodDms(strSqlOne, year, month2, cityId, areaSqlWhere);
        }
        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetCityMonth_Emp(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_Emp(strSqlOne, yearMonth, cityId, areaSqlWhere);
        }
        public DataSet GetCityMonth_EmpDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_EmpDms(strSqlOne, year, month2, cityId, areaSqlWhere);
        }
        /// <summary>
        /// 获得月份省份内客户排行
        /// </summary>
        public DataSet GetCityMonth_Customer(string strSqlOne, string yearMonth, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_Customer(strSqlOne, yearMonth, cityId, areaSqlWhere);
        }
        public DataSet GetCityMonth_CustomerDms(string strSqlOne, string year, string month2, string cityId, string areaSqlWhere)
        {
            return dal.GetCityMonth_CustomerDms(strSqlOne, year, month2, cityId, areaSqlWhere);
        }
        #endregion

        #region dms增删操作
        public bool insertOrderDms(string yearMonth, string create_name, string factory_id)
        {
            return dal.insertOrderDms(yearMonth, create_name, factory_id);
        }
        public bool deleteOrderDms(string year, string month2)
        {
            return dal.deleteOrderDms( year,month2);
        }
        #endregion

        #endregion

        #region 统计

        #region 月份
        /// <summary>
        /// 选择权限内的个人月销售数据 
        /// </summary>
        public DataSet GetMonthSaleBackData(string strSqlOne, string yearMonth, string monthColumns)
        {
            return dal.GetMonthSaleBackData(strSqlOne, yearMonth,  monthColumns);
        }
        public DataSet GetMonthSaleBackDmsData(string strSqlOne, string yearMonth, string monthColumns)
        {
            return dal.GetMonthSaleBackDmsData(strSqlOne, yearMonth, monthColumns);
        }

        /// <summary>
        /// 获得时间段月份明细_一个部门的销售数据，部门经理
        /// </summary>
        public DataSet GetManagerMonthDepData(string strSqlOne, string yearMonth, string monthColumns)
        {
            return dal.GetManagerMonthDepData(strSqlOne, yearMonth,  monthColumns);
        }

        public DataSet GetManagerMonthDepDmsData(string strSqlOne, string yearMonth, string monthColumns)
        {
            return dal.GetManagerMonthDepDmsData(strSqlOne, yearMonth, monthColumns);
        }

        /// <summary>
        /// 获得时间段月份明细_全部数据和各个部门，31天，中心
        /// </summary>
        public DataSet GetMonthAllDepData(string strSqlOne, string yearMonth, string monthColumns)
        {
            return dal.GetMonthAllDepData(strSqlOne, yearMonth,  monthColumns);
        }

        public DataSet GetMonthAllDepDmsData(string strSqlOne, string yearMonth, string monthColumns)
        {
            return dal.GetMonthAllDepDmsData(strSqlOne, yearMonth, monthColumns);
        }
        #endregion

        #region 年份
        /// <summary>
        /// 获得时间段月份明细，个人或选择的客服的员工号：销售数据，（年报）
        /// </summary>
        public DataSet GetYearSaleBackData(string strSqlOne, string year)
        {
            return dal.GetYearSaleBackData(strSqlOne, year);
        }
        public DataSet GetYearSaleBackDmsData(string strSqlOne, string year)
        {
            return dal.GetYearSaleBackDmsData(strSqlOne, year);
        }
        
        /// <summary>
        /// 获得时间段月份明细_一个部门的销售数据，部门经理，年报
        /// </summary>
        public DataSet GetYearDepData(string strSqlOne, string year)
        {
            return dal.GetYearDepData(strSqlOne, year);
        }
        public DataSet GetYearDepDmsData(string strSqlOne, string year)
        {
            return dal.GetYearDepDmsData(strSqlOne, year);
        }
        /// <summary>
        /// 获得时间段12月份明细_全部数据和各个部门(年报)，12个月，中心
        /// </summary>
        public DataSet GetYearAllDepData(string strSqlOne, string year)
        {
            return dal.GetYearAllDepData(strSqlOne, year);
        }
        public DataSet GetYearAllDepDmsData(string strSqlOne, string year)
        {
            return dal.GetYearAllDepDmsData(strSqlOne, year);
        }
        #endregion

        #region dms增删操作
        public bool insertMonthDms(string yearMonth, string create_name, string factory_id)
        {
            return dal.insertMonthDms(yearMonth,  create_name, factory_id);
        }
        public bool deleteMonthDms(string yearMonth)
        {
            return dal.deleteMonthDms(yearMonth);
        }
        public bool insertYearDms(string year,string yearMonth, string create_name, string factory_id)
        {
            return dal.insertYearDms(year,yearMonth, create_name, factory_id);
        }
        public bool deleteYearDms(string sqlWhere)
        {
            return dal.deleteYearDms(sqlWhere);
        }
        #endregion

        #endregion

        #region 品牌

        #region 年份
        /// <summary>
        /// 获得品牌年明细
        /// </summary>
        public DataSet GetBrandManagerDms_Year(string strSqlOne, string year, string qtBrand)
        {
            return dal.GetBrandManagerDms_Year(strSqlOne, year, qtBrand);
        }
        public DataSet GetAllBrandManagerDms_Year(string strSqlOne, string year, string qtBrand)
        {
            return dal.GetAllBrandManagerDms_Year(strSqlOne, year, qtBrand);
        }
        public DataSet GetBrandManagerDms_Emp_Year(string strSqlOne, string year, string qtBrand)
        {
            return dal.GetBrandManagerDms_Emp_Year(strSqlOne, year, qtBrand);
        }
        public DataSet GetAllBrandManagerDms_Emp_Year(string strSqlOne, string year, string qtBrand)
        {
            return dal.GetAllBrandManagerDms_Emp_Year(strSqlOne, year, qtBrand);
        }
        public DataSet GetAllBrandManagerDms_Good_Year(string strSqlOne, string year, string qtBrand)
        {
            return dal.GetAllBrandManagerDms_Good_Year(strSqlOne, year, qtBrand);
        }
        public DataSet GetBrandManagerDms_Good_Year(string strSqlOne, string year, string qtBrand)
        {
            return dal.GetBrandManagerDms_Good_Year(strSqlOne, year, qtBrand);
        }

        #endregion

        #region 月份
        /// <summary>
        /// 获得品牌月份明细
        /// </summary>
        public DataSet GetBrandManagerData(string strSqlOne, string yearMonth, string year, string month, string qtBrand)
        {
            return dal.GetBrandManagerData(strSqlOne, yearMonth, year, month, qtBrand);
        }
        public DataSet GetAllBrandManagerData(string strSqlOne, string yearMonth,string year, string month, string qtBrand)
        {
            return dal.GetAllBrandManagerData(strSqlOne, yearMonth, year, month, qtBrand);
        }
        public DataSet GetBrandManagerDms(string strSqlOne, string year, string month, string month2, string qtBrand)
        {
            return dal.GetBrandManagerDms(strSqlOne, year, month, month2, qtBrand);
        }
        public DataSet GetAllBrandManagerDms(string strSqlOne, string year, string month2, string qtBrand)
        {
            return dal.GetAllBrandManagerDms(strSqlOne, year, month2, qtBrand);
        }
        /// <summary>
        /// 获得月份客服排行
        /// </summary>
        public DataSet GetBrandManagerData_Emp(string strSqlOne, string yearMonth, string year, string month, string qtBrand)
        {
            return dal.GetBrandManagerData_Emp(strSqlOne, yearMonth, year, month, qtBrand);
        }
        public DataSet GetAllBrandManagerData_Emp(string strSqlOne, string yearMonth, string year, string qtBrand)
        {
            return dal.GetAllBrandManagerData_Emp(strSqlOne, yearMonth, year, qtBrand);
        }
        public DataSet GetBrandManagerDms_Emp(string strSqlOne, string year,string month, string month2, string qtBrand)
        {
            return dal.GetBrandManagerDms_Emp(strSqlOne, year, month, month2, qtBrand);
        }
        public DataSet GetAllBrandManagerDms_Emp(string strSqlOne, string year, string month2, string qtBrand)
        {
            return dal.GetAllBrandManagerDms_Emp(strSqlOne, year, month2, qtBrand);
        }

        /// <summary>
        /// 获得月份商品排行
        /// </summary>
        public DataSet GetBrandManagerData_Good(string strSqlOne, string yearMonth,string year, string qtBrand)
        {
            return dal.GetBrandManagerData_Good(strSqlOne, yearMonth, year, qtBrand);
        }
        public DataSet GetAllBrandManagerData_Good(string strSqlOne, string yearMonth, string year, string qtBrand)
        {
            return dal.GetAllBrandManagerData_Good(strSqlOne, yearMonth, year, qtBrand);
        }


        public DataSet GetBrandManagerDms_Good(string strSqlOne, string year, string month2, string qtBrand)
        {
            return dal.GetBrandManagerDms_Good(strSqlOne, year, month2, qtBrand);
        }
        public DataSet GetAllBrandManagerDms_Good(string strSqlOne, string year, string month2, string qtBrand)
        {
            return dal.GetAllBrandManagerDms_Good(strSqlOne, year, month2, qtBrand);
        }
        #endregion

        #region dms增删操作
        public bool insertBrandDms(string yearMonth,string year, string create_name, string factory_id)
        {
            return dal.insertBrandDms(yearMonth,year, create_name, factory_id);
        }
        public bool deleteBrandDms(string nowYear,string nowMonth)
        {
            return dal.deleteBrandDms(nowYear, nowMonth);
        }
        #endregion

        #endregion            

        #region 薪资
        /// <summary>
        /// 获得个人薪资考核品牌提成
        /// </summary>
        public DataSet GetBrandPercentageData(string a_, string b_, string strSqlOne, string emp_code, string year, string month, string yearMonth, string filedOrder)
        {
            return dal.GetBrandPercentageData(a_, b_, strSqlOne, emp_code, year, month, yearMonth, filedOrder);
        }
        public DataSet GetBrandPercentageDms(string a_, string b_, string strSqlOne, string emp_code, string year, string month, string yearMonth, string filedOrder)
        {
            return dal.GetBrandPercentageDms(a_, b_, strSqlOne, emp_code, year, month, yearMonth, filedOrder);
        }

        /// <summary>
        /// 获得个人月冠军
        /// </summary>
        public DataSet GetPersonalMonthRankData(string monthColumns, string strSqlOne, string d_ids, string year, string month, string yearMonth, decimal champion, decimal bonus)
        {
            return dal.GetPersonalMonthRankData(monthColumns, strSqlOne, d_ids, year, month, yearMonth, champion, bonus);
        }

        /// <summary>
        /// 获得个人节点冠军
        /// </summary>
        public DataSet GetPersonalNodeRankData(string monthColumns, string strSqlOne, string d_ids, string nodeA, string nodeB, string year, string month, decimal champion, decimal bonus)
        {
            return dal.GetPersonalNodeRankData(monthColumns, strSqlOne, d_ids, nodeA, nodeB, year, month, champion, bonus);
        }

        /// <summary>
        /// 获得团队月冠军
        /// </summary>
        public DataSet GetTeamMonthRankData(string monthColumns, string strSqlOne, string d_ids, string yearMonth, string year, string month, decimal champion, string name)
        {
            return dal.GetTeamMonthRankData(monthColumns, strSqlOne, d_ids, yearMonth, year, month, champion, name);
        }

        /// <summary>
        /// 获得团队周
        /// </summary>
        public DataSet GetTeamNodeRankData(string monthColumns, string strSqlOne, string d_ids, string nodeA, string nodeB, string year, string month, decimal champion, string name)
        {
            return dal.GetTeamNodeRankData(monthColumns, strSqlOne, d_ids, nodeA, nodeB, year, month, champion, name);
        }

        /// <summary>
        /// 获得个人薪资月冠军，节点冠军，节点达标奖励
        /// </summary>
        public DataSet GetPersonalMonthSalaryData(string year, string month)
        {
            return dal.GetPersonalMonthSalaryData(year, month);
        }

        /// <summary>
        /// 基本工资
        /// </summary>
        public DataSet GetMonthCustomerSaleData(string strSqlOne, string d_id, string year, string month, string yearMonth)
        {
            return dal.GetMonthCustomerSaleData(strSqlOne, d_id, year, month, yearMonth);
        }
        #endregion
        
        #region 客户
        ///// <summary>
        ///// 客户树
        ///// </summary>
        //public DataSet GetCustomerTree(string yearMonth, string emp_code)
        //{
        //    return dal.GetCustomerTree(yearMonth, emp_code);
        //}
        #region 客户年报
        /// <summary>
        /// 获得个人客户销售年报
        /// </summary>
        public DataSet GetCustomerYearSaleBackData(string strSqlOne, string year)
        {
            return dal.GetCustomerYearSaleBackData(strSqlOne, year);
        }
        public DataSet GetCustomerYearSaleBackDms(string admin_user_name, string year)
        {
            return dal.GetCustomerYearSaleBackDms(admin_user_name, year);
        }

        public DataSet GetCustomerYearDms(string admin_user_name, string year, string yearDays)
        {
            return dal.GetCustomerYearDms(admin_user_name, year, yearDays);
        }

        /// <summary>
        /// 部门客户销售数据，中心：部门和个人的客户销售数据，部门：部门下每个客服的客户销售数据
        /// </summary>
        public DataSet GetCustomerYearManagerDepData(string strSqlOne, string year)
        {
            return dal.GetCustomerYearManagerDepData(strSqlOne, year);
        }
        public DataSet GetCustomerYearManagerDepDms(string empCodes, string year)
        {
            return dal.GetCustomerYearManagerDepDms(empCodes, year);
        }
        #endregion

        #region 客户月报
        /// <summary>
        /// 获得个人客户销售月报
        /// </summary>
        public DataSet GetCustomerMonthSaleBackData(string strSqlOne, string yearMonth)
        {
            return dal.GetCustomerMonthSaleBackData(strSqlOne, yearMonth);
        }
        public DataSet GetCustomerMonthSaleBackDms(string admin_user_name, string year,string month2)
        {
            return dal.GetCustomerMonthSaleBackDms(admin_user_name, year, month2);
        }
        /// <summary>
        /// 部门客户销售数据，中心：部门和个人的客户销售数据，部门：部门下每个客服的客户销售数据
        /// </summary>
        public DataSet GetCustomerMonthManagerDepData(string strSqlOne, string yearMonth)
        {
            return dal.GetCustomerMonthManagerDepData(strSqlOne, yearMonth);
        }
        public DataSet GetCustomerMonthManagerDepDms(string strSqlOne, string year, string month2)
        {
            return dal.GetCustomerMonthManagerDepDms(strSqlOne, year, month2);
        }
        #endregion



        #region 客户详情页
        /// <summary>
        /// 客户下，品牌下，单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerMonthBrandData(string strSqlOne, string yearMonth)
        {
            return dal.GetCustomerMonthBrandData(strSqlOne, yearMonth);
        }
        public DataSet GetCustomerMonthBrandDms(string strSqlOne, string year, string month2)
        {
            return dal.GetCustomerMonthBrandDms(strSqlOne, year,month2);
        }

        public DataSet GetCustomerMonthBrandGoodsData(string strSqlOne, string yearMonth)
        {
            return dal.GetCustomerMonthBrandGoodsData(strSqlOne, yearMonth);
        }
        public DataSet GetCustomerMonthBrandGoodsDms(string strSqlOne, string year, string month2)
        {
            return dal.GetCustomerMonthBrandGoodsDms(strSqlOne, year, month2);
        }
        /// <summary>
        /// 客户下，品牌下，单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerYearBrandGoodsData(string strSqlOne, string yearMonth)
        {
            return dal.GetCustomerYearBrandGoodsData(strSqlOne, yearMonth);
        }
        public DataSet GetCustomerYearBrandGoodsDms(string strSqlOne, string yearMonth)
        {
            return dal.GetCustomerYearBrandGoodsDms(strSqlOne, yearMonth);
        }

        /// <summary>
        /// 客户下，品牌下，单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerYearGood(string strSqlOne, string yearMonth)
        {
            return dal.GetCustomerYearGood(strSqlOne, yearMonth);
        }
        public DataSet GetCustomerYearGoodDms(string strSqlOne, string yearMonth)
        {
            return dal.GetCustomerYearGoodDms(strSqlOne, yearMonth);
        }
        #endregion


        #region dms增删操作
        public bool insertCustomerDms(string yearMonth,string strSqlOne ,string create_name, string factory_id)
        {
            return dal.insertCustomerDms(yearMonth,strSqlOne, create_name, factory_id);
        }
        public bool deleteCustomerDms(string year, string month2)
        {
            return dal.deleteCustomerDms(year, month2);
        }


        #region 客户拿货次数
        public bool insertCustomerMonthCountDms(string yearMonth, string create_name, string factory_id)
        {
            return dal.insertCustomerMonthCountDms(yearMonth, create_name, factory_id);
        }
        public bool deleteCustomerMonthCountDms(string year,string month2)
        {
            return dal.deleteCustomerMonthCountDms(year,month2);
        } 
        #endregion

        #region 员工成交次数
        public bool insertEmpMonthCountDms(string yearMonth, string create_name, string factory_id)
        {
            return dal.insertEmpMonthCountDms(yearMonth, create_name, factory_id);
        }
        public bool deleteEmpMonthCountDms(string year, string month2)
        {
            return dal.deleteEmpMonthCountDms(year, month2);
        }
        #endregion

        #endregion

        #endregion

        
        
    }
}

