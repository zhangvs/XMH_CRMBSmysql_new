﻿using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;

namespace XHD.BLL
{

    public partial class FMS_SqlHelperClass
    {
        private readonly FMS_DAL.FMS_SqlHelperClass dal = new FMS_DAL.FMS_SqlHelperClass();

        public FMS_SqlHelperClass() { }
        //获取分页数据
        public DataSet GetPageData(int pageSize, int pageIndex, string filedlist, string strWhere, string tableName, string filedOrder, out string Total)
        {
            return dal.GetPageData(pageSize, pageIndex, filedlist, strWhere, tableName, filedOrder, out Total);
        }

        //执行查询语句获取结果
        public DataSet Sql_DataSet(string sqlstr)
        {
            return dal.Sql_DataSet(sqlstr);
        }

        //执行存储过程
        public bool ExecuteSqlTran(List<string> sqlLst, out string msg)
        {
            return dal.ExecuteSqlTran(sqlLst, out msg);
        }

        //获取查询DS结果
        public DataSet GetAllData(string filedlist, string strWhere, string tableName, string filedOrder, out string Total)
        {
            return dal.GetAllData(filedlist, strWhere, tableName, filedOrder, out Total);
        }

        //执行sq语句返货结果
        public bool RunSql(string sqlstr)
        {
            return dal.RunSql(sqlstr);
        }

        //获取单据号码
        public string GetDJHM()
        {
            return dal.GetDJHM();
        }
        //获取年月
        public void GetYearAndMonth(out string year, out string month)
        {
            dal.GetYearAndMonth(out year, out month);
        }

    }
}
