﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_purchase_list
    /// </summary>
    public partial class scm_purchase_list
    {
        public scm_purchase_list()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_purchase_list");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_purchase_list model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_purchase_list(");
            strSql.Append("factory_Id,suppliers_id,goods_id,goods_sn2,goods_name,purchase_Total,dhxlk_DJHM,suppliers_erp_code,purchase_Data,purchase_order)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@suppliers_id,@goods_id,@goods_sn2,@goods_name,@purchase_Total,@dhxlk_DJHM,@suppliers_erp_code,@purchase_Data,@purchase_order)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
					new MySqlParameter("@goods_sn2", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@purchase_Total", MySqlDbType.Int32,11),
					new MySqlParameter("@dhxlk_DJHM", MySqlDbType.VarChar,1000),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,1000),
					new MySqlParameter("@purchase_Data", MySqlDbType.DateTime),
                    new MySqlParameter("@purchase_order",MySqlDbType.VarChar,100)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.goods_id;
            parameters[3].Value = model.goods_sn2;
            parameters[4].Value = model.goods_name;
            parameters[5].Value = model.purchase_Total;
            parameters[6].Value = model.dhxlk_DJHM;
            parameters[7].Value = model.suppliers_erp_code;
            parameters[8].Value = model.purchase_Data;
            parameters[9].Value = model.purchase_order;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.scm_purchase_list model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_purchase_list set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("suppliers_id=@suppliers_id,");
            strSql.Append("goods_id=@goods_id,");
            strSql.Append("goods_sn2=@goods_sn2,");
            strSql.Append("goods_name=@goods_name,");
            strSql.Append("purchase_Total=@purchase_Total,");
            strSql.Append("dhxlk_DJHM=@dhxlk_DJHM,");
            strSql.Append("suppliers_erp_code=@suppliers_erp_code,");
            strSql.Append("purchase_Data=@purchase_Data");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@goods_id", MySqlDbType.Int16,8),
					new MySqlParameter("@goods_sn2", MySqlDbType.VarChar,60),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,120),
					new MySqlParameter("@purchase_Total", MySqlDbType.Int32,11),
					new MySqlParameter("@dhxlk_DJHM", MySqlDbType.VarChar,1000),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,1000),
					new MySqlParameter("@purchase_Data", MySqlDbType.DateTime),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.goods_id;
            parameters[3].Value = model.goods_sn2;
            parameters[4].Value = model.goods_name;
            parameters[5].Value = model.purchase_Total;
            parameters[6].Value = model.dhxlk_DJHM;
            parameters[7].Value = model.suppliers_erp_code;
            parameters[8].Value = model.purchase_Data;
            parameters[9].Value = model.Id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Alter(XHD.Model.scm_purchase_list model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_purchase_list set ");
            strSql.Append("purchase_Total=@purchase_Total,");
            strSql.Append("dhxlk_DJHM=@dhxlk_DJHM,");
            strSql.Append("suppliers_erp_code=@suppliers_erp_code");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@purchase_Total", MySqlDbType.Int32,11),
					new MySqlParameter("@dhxlk_DJHM", MySqlDbType.VarChar,1000),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,1000),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
           
            parameters[0].Value = model.purchase_Total;
            parameters[1].Value = model.dhxlk_DJHM;
            parameters[2].Value = model.suppliers_erp_code;
            parameters[3].Value = model.Id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_purchase_list ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_purchase_list ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.scm_purchase_list GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,suppliers_id,goods_id,goods_sn2,goods_name,purchase_Total,dhxlk_DJHM,suppliers_erp_code,purchase_Data,purchase_order from scm_purchase_list ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.scm_purchase_list model = new XHD.Model.scm_purchase_list();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.scm_purchase_list DataRowToModel(DataRow row)
        {
            XHD.Model.scm_purchase_list model = new XHD.Model.scm_purchase_list();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                //model.goods_id=row["goods_id"].ToString();
                if (row["goods_sn2"] != null)
                {
                    model.goods_sn2 = row["goods_sn2"].ToString();
                }
                if (row["goods_name"] != null)
                {
                    model.goods_name = row["goods_name"].ToString();
                }
                if (row["purchase_Total"] != null && row["purchase_Total"].ToString() != "")
                {
                    model.purchase_Total = int.Parse(row["purchase_Total"].ToString());
                }
                if (row["dhxlk_DJHM"] != null)
                {
                    model.dhxlk_DJHM = row["dhxlk_DJHM"].ToString();
                }
                if (row["suppliers_erp_code"] != null)
                {
                    model.suppliers_erp_code = row["suppliers_erp_code"].ToString();
                }
                if (row["purchase_Data"] != null && row["purchase_Data"].ToString() != "")
                {
                    model.purchase_Data = DateTime.Parse(row["purchase_Data"].ToString());
                }
                if (row["purchase_order"] != null)
                {
                    model.suppliers_erp_code = row["purchase_order"].ToString();
                }
            }

            
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,suppliers_id,goods_id,goods_sn2,goods_name,purchase_Total,dhxlk_DJHM,suppliers_erp_code,purchase_Data,purchase_order ");
            strSql.Append(" FROM scm_purchase_list ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsRecord(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_purchase_list");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Exists(strSql.ToString());
        }


        //获取数据--采购详情
        public DataSet GetList(int PageSize, int PageIndex, string strWhere,string sqlOne, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@"select  group_concat(suppliers_id separator ';') as suppliers_id, purchase_order,group_concat(goods_name  separator ';') as name,
                            group_concat(dhxlk_DJHM  separator ';') as djhm,group_concat(suppliers_erp_code  separator ';') as suppliers_erp_code, sum(purchase_Total)  as total, 
                            purchase_Data from scm_purchase_list");

            strSql1.Append("select count(1) from (select  *  from scm_purchase_list  " + sqlOne + "  group by purchase_order) as p ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
               // strSql1.Append(" where " + strWhere);
            }

            strSql.Append(" group by purchase_order ");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //获取数据--采购详情主订单号查询产品、供应商信息
        public DataSet GetSupplyInfoList(int PageSize, int PageIndex, string strWhere,string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@"select Id,factory_Id,suppliers_id,goods_id,goods_sn2,goods_name,purchase_Total,dhxlk_DJHM,suppliers_erp_code,purchase_Data,purchase_order  from scm_purchase_list ");
            strSql1.Append("select count(1) from scm_purchase_list ");
            
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        
        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

