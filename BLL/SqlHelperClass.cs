using System;
using System.Data;
using System.Collections.Generic;
using XHD.Common;
using XHD.Model;
using XHD.Model.wms;
namespace XHD.BLL
{

    public partial class SqlHelperClass
    {
        private readonly XHD.DAL.SqlHelperClass dal = new XHD.DAL.SqlHelperClass();

        public SqlHelperClass() { }
        //获取分页数据
        public DataSet GetPageData(int pageSize, int pageIndex, string filedlist, string strWhere, string tableName, string filedOrder, out string Total)
        {
            return dal.GetPageData(pageSize, pageIndex, filedlist, strWhere, tableName, filedOrder, out Total);
        }

        /// <summary>
        /// 获取fms基本设置
        /// </summary>
        /// <returns></returns>
        public FmsSetting_Response GetFmsSetting()
        {
            return dal.GetFmsSetting();
        }

        /// <summary>
        /// 获取wms单据号码的方法
        /// </summary>
        /// <param name="hearder"></param>
        /// <returns></returns>
        public string GetSN(string hearder)
        {
            return dal.GetSN(hearder);
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

        /// <summary>
        /// 获取金蝶token
        /// </summary>
        /// <returns></returns>
        public string GetToken()
        {
            return dal.GetToken();
        }

        /// <summary>
        /// 获取金蝶部门编号
        /// </summary>
        /// <param name="emp_code"></param>
        /// <returns></returns>
        public string GetKingDee_depcode(string emp_code)
        {
            return dal.GetKingDee_depcode(emp_code);
        }

        /// <summary>
        /// 获取供应商编号11位
        /// </summary>
        /// <returns></returns>
        public string CreateSupplierNum()
        {
            return dal.GetPNO_DAL(3);
        }

        /// <summary>
        /// 获取发票编码
        /// </summary>
        /// <param name="type">类型1：中间表编码 2：发票编码</param>
        /// <returns></returns>
        public string CreateInvoiceSN(int type)
        {
            return dal.GetInvoiceSN_DAL(type);
        }

    }
}
