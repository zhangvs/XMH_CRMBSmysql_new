﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace XHD.BLL
{
    /// <summary>
    /// ecs_order_info
    /// </summary>
    public partial class ecs_order_info
    {
        private readonly XHD.DAL.ecs_order_info dal = new XHD.DAL.ecs_order_info();
        public ecs_order_info()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int order_id)
        {
            return dal.Exists(order_id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_order_info model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ecs_order_info model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int order_id)
        {

            return dal.Delete(order_id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string order_idlist)
        {
            return dal.DeleteList(order_idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.ecs_order_info GetModel(int order_id)
        {

            return dal.GetModel(order_id);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public XHD.Model.ecs_order_info GetModelByCache(int order_id)
        {

            string CacheKey = "ecs_order_infoModel-" + order_id;
            object objModel = XHD.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(order_id);
                    if (objModel != null)
                    {
                        int ModelCache = XHD.Common.ConfigHelper.GetConfigInt("ModelCache");
                        XHD.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (XHD.Model.ecs_order_info)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ecs_order_info> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XHD.Model.ecs_order_info> DataTableToList(DataTable dt)
        {
            List<XHD.Model.ecs_order_info> modelList = new List<XHD.Model.ecs_order_info>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                XHD.Model.ecs_order_info model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList2(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList2(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList1(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            return dal.GetList1(PageSize, PageIndex, strWhere, filedOrder, out Total);
        }

        /// <summary>
        /// 根据id获取地区名称
        /// </summary>
        public DataSet addressName(int id)
        {
            return dal.addressName(id);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        /// <summary>
        /// 获取当前业绩走势
        /// </summary>
        public DataSet getCurData(int daytime, int pretime, int curtime)
        {
            return dal.getCurData(daytime, pretime, curtime);
        }

        /// <summary>
        /// 获取10后的业绩
        /// </summary>
        public DataSet getWillData(int curtime)
        {
            return dal.getWillData(curtime);
        }

        /// <summary>
        /// 获取10后的业绩
        /// </summary>
        public DataSet getMonthData(int starttime, int endtime)
        {
            return dal.getMonthData(starttime, endtime);
        }
        public DataSet getMonthDms(string yearMonth)
        {
            return dal.getMonthDms(yearMonth);
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        //--------------------------------地图---------------------------------------------------------------
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

        #region 省份城市月报

        /// <summary>
        /// 获得月份城市订单
        /// </summary>
        public DataSet GetMonthGoodTxt(string keyWord, string yearMonth,string qtBrand)
        {
            return dal.GetMonthGoodTxt(keyWord, yearMonth, qtBrand);
        }

        /// <summary>
        /// 获得月份城市订单
        /// </summary>
        public DataSet GetMonthCityAmt(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string qtBrand)
        {
            return dal.GetMonthCityAmt(strSqlOne, yearMonth, returnDateTime, returnTimeStamp, qtBrand);
        }

        /// <summary>
        /// 获得月份省份订单
        /// </summary>
        public DataSet GetMonthProvinceAmt(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string qtBrand)
        {
            return dal.GetMonthProvinceAmt(strSqlOne, yearMonth, returnDateTime, returnTimeStamp, qtBrand);
        }


        /// <summary>
        /// 获得月份省份内品牌排行
        /// </summary>
        public DataSet GetProvinceYear_Months(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetProvinceYear_Months(strSqlOne, yearMonth, provinceId, qtBrand, returnDateTime, returnTimeStamp);
        }
        /// <summary>
        /// 获得月份省份内品牌排行
        /// </summary>
        public DataSet GetProvinceMonth_Brand(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetProvinceMonth_Brand(strSqlOne, yearMonth, provinceId, qtBrand, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得月份省份内城市排行
        /// </summary>
        public DataSet GetProvinceMonth_City(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetProvinceMonth_City(strSqlOne, yearMonth, provinceId, qtBrand, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetProvinceMonth_Good(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetProvinceMonth_Good(strSqlOne, yearMonth, provinceId, qtBrand, returnDateTime, returnTimeStamp);
        }
        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetProvinceMonth_Emp(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetProvinceMonth_Emp(strSqlOne, yearMonth, provinceId, qtBrand, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得月份省份内客户排行
        /// </summary>
        public DataSet GetProvinceMonth_Customer(string strSqlOne, string yearMonth, string provinceId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetProvinceMonth_Customer(strSqlOne, yearMonth, provinceId, qtBrand, returnDateTime, returnTimeStamp);
        }


        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetCityYear_Months(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCityYear_Months(strSqlOne, yearMonth, cityId, qtBrand, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetCityMonth_Brand(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCityMonth_Brand(strSqlOne, yearMonth, cityId, qtBrand, returnDateTime, returnTimeStamp);
        }
        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetCityMonth_Good(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCityMonth_Good(strSqlOne, yearMonth, cityId, qtBrand, returnDateTime, returnTimeStamp);
        }
        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetCityMonth_Emp(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCityMonth_Emp(strSqlOne, yearMonth, cityId, qtBrand, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得月份省份内客户排行
        /// </summary>
        public DataSet GetCityMonth_Customer(string strSqlOne, string yearMonth, string cityId, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCityMonth_Customer(strSqlOne, yearMonth, cityId,qtBrand, returnDateTime, returnTimeStamp);
        }

        #endregion




        //-----------------------时间段数据-------------------------------------------------------------

        
        /// <summary>
        /// 选择权限内的个人月销售数据 
        /// </summary>
        public DataSet GetMonthSaleBackData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string monthColumns)
        {
            return dal.GetMonthSaleBackData(strSqlOne, yearMonth, returnDateTime, returnTimeStamp, monthColumns);
        }

        /// <summary>
        /// 获得时间段月份明细_一个部门的销售数据，部门经理
        /// </summary>
        public DataSet GetManagerMonthDepData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string monthColumns)
        {
            return dal.GetManagerMonthDepData(strSqlOne, yearMonth, returnDateTime, returnTimeStamp, monthColumns);
        }

        /// <summary>
        /// 获得时间段月份明细_全部数据和各个部门，31天，中心
        /// </summary>
        public DataSet GetMonthAllDepData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string monthColumns)
        {
            return dal.GetMonthAllDepData(strSqlOne, yearMonth, returnDateTime, returnTimeStamp, monthColumns);
        }



        /// <summary>
        /// 获得时间段月份明细，个人或选择的客服的员工号：销售数据，（年报）
        /// </summary>
        public DataSet GetYearSaleBackData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetYearSaleBackData(strSqlOne, year, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得时间段月份明细_一个部门的销售数据，部门经理，年报
        /// </summary>
        public DataSet GetYearDepData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetYearDepData(strSqlOne, year, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得时间段12月份明细_全部数据和各个部门(年报)，12个月，中心
        /// </summary>
        public DataSet GetYearAllDepData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetYearAllDepData(strSqlOne, year, returnDateTime, returnTimeStamp);
        }






        //---------------------------品牌----------------------------------------------------------

        /// <summary>
        /// 获得品牌月份明细
        /// </summary>
        public DataSet GetBrandSaleBackData(string strSqlOne,  string yearMonth, DateTime returnDateTime, string returnTimeStamp,  string qtBrand)
        {
            return dal.GetBrandSaleBackData(strSqlOne,  yearMonth, returnDateTime, returnTimeStamp,  qtBrand);
        }

        /// <summary>
        /// 获得品牌月份明细
        /// </summary>
        public DataSet GetYearBrandSaleBackData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp,  string qtBrand)
        {
            return dal.GetYearBrandSaleBackData(strSqlOne, yearMonth, returnDateTime, returnTimeStamp, qtBrand);
        }


        /// <summary>
        /// 获得品牌月份明细
        /// </summary>
        public DataSet GetBrandManagerData(string strSqlOne, string yearMonth,string monthColumms, DateTime returnDateTime, string returnTimeStamp, string qtBrand)
        {
            return dal.GetBrandManagerData(strSqlOne, yearMonth, monthColumms, returnDateTime, returnTimeStamp, qtBrand);
        }
        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetBrandManagerData_Emp(string strSqlOne, string yearMonth, string month, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetBrandManagerData_Emp(strSqlOne, yearMonth,month, qtBrand, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得品牌年明细
        /// </summary>
        public DataSet GetBrandManagerData_Year(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp, string qtBrand)
        {
            return dal.GetBrandManagerData_Year(strSqlOne, year, returnDateTime, returnTimeStamp, qtBrand);
        }

        /// <summary>
        /// 获得月份省份内客服排行
        /// </summary>
        public DataSet GetBrandManagerData_Emp_Year(string strSqlOne, string year, string qtBrand, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetBrandManagerData_Emp_Year(strSqlOne, year, qtBrand, returnDateTime, returnTimeStamp);
        }
        //---------------------------薪资数据----------------------------------------------------------
        /// <summary>
        /// 获得个人薪资考核品牌提成
        /// </summary>
        public DataSet GetBrandPercentageData(string a_, string b_, string strSqlOne, string emp_code, string yearMonth, DateTime returnDateTime, string returnTimeStamp, string filedOrder)
        {
           return dal.GetBrandPercentageData(a_, b_, strSqlOne, emp_code, yearMonth, returnDateTime, returnTimeStamp, filedOrder);
        }


        /// <summary>
        /// 获得个人月冠军
        /// </summary>
        public DataSet GetPersonalMonthRankData(string monthColumns, string isNodes, string strSqlOne, string d_ids, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetPersonalMonthRankData(monthColumns, isNodes, strSqlOne, d_ids, yearMonth, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得个人节点冠军
        /// </summary>
        public DataSet GetPersonalNodeRankData(string monthColumns, string isNodes, string strSqlOne, string d_ids, string nodeA,string nodeB, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetPersonalNodeRankData(monthColumns, isNodes, strSqlOne, d_ids, nodeA, nodeB, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得团队月冠军
        /// </summary>
        public DataSet GetTeamMonthRankData(string monthColumns, string isNodes, string strSqlOne, string d_ids, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetTeamMonthRankData(monthColumns, isNodes, strSqlOne, d_ids, yearMonth, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得团队周
        /// </summary>
        public DataSet GetTeamNodeRankData(string monthColumns, string isNodes, string strSqlOne, string d_ids, string nodeA, string nodeB, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetTeamNodeRankData(monthColumns, isNodes, strSqlOne, d_ids, nodeA, nodeB, returnDateTime, returnTimeStamp);
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
        public DataSet GetMonthCustomerSaleData(string strSqlOne, string d_id, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetMonthCustomerSaleData(strSqlOne, d_id, yearMonth, returnDateTime, returnTimeStamp);
        }



        //---------------客户销售数据----------------------------------------------------------------




        /// <summary>
        /// 客户树
        /// </summary>
        public DataSet GetCustomerTree(string yearMonth, string emp_code)
        {
            return dal.GetCustomerTree(yearMonth, emp_code);
        }

        /// <summary>
        /// 获得个人客户销售年报
        /// </summary>
        public DataSet GetCustomerYearSaleBackData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCustomerYearSaleBackData(strSqlOne, year, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 获得个人客户销售月报
        /// </summary>
        public DataSet GetCustomerMonthSaleBackData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCustomerMonthSaleBackData(strSqlOne, yearMonth, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 部门客户销售数据，中心：部门和个人的客户销售数据，部门：部门下每个客服的客户销售数据
        /// </summary>
        public DataSet GetCustomerYearManagerDepData(string strSqlOne, string year, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCustomerYearManagerDepData(strSqlOne, year, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 部门客户销售数据，中心：部门和个人的客户销售数据，部门：部门下每个客服的客户销售数据
        /// </summary>
        public DataSet GetCustomerMonthManagerDepData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCustomerMonthManagerDepData(strSqlOne, yearMonth, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 客户下，品牌下，单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerMonthBrandGoodsData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCustomerMonthBrandGoodsData(strSqlOne, yearMonth, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 客户下，品牌下，单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerYearBrandGoodsData(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCustomerYearBrandGoodsData(strSqlOne, yearMonth, returnDateTime, returnTimeStamp);
        }

        /// <summary>
        /// 客户下，品牌下，单品月内销售情况，具体到每一天
        /// </summary>
        public DataSet GetCustomerYearGood(string strSqlOne, string yearMonth, DateTime returnDateTime, string returnTimeStamp)
        {
            return dal.GetCustomerYearGood(strSqlOne, yearMonth, returnDateTime, returnTimeStamp);
        }

        #endregion  ExtensionMethod
    }
}

