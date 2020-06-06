/**  版本信息模板在安装目录下，可自行修改。
* crm_contact_bill.cs
*
* 功 能： N/A
* 类 名： crm_contact_bill
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/1/10 15:18:51   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_contact_bill
    /// </summary>
    public partial class crm_contact_bill
    {
        public crm_contact_bill()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "crm_contact_bill");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_contact_bill");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_contact_bill model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_contact_bill(");
            strSql.Append("id,customer_id,user_id,invoice_type,tax_company_name,tax_company_add_tel,tax_tax_code,tax_bank_name,tax_bank_num,is_tax_for_billing)");
            strSql.Append(" values (");
            strSql.Append("@id,@customer_id,@user_id,@invoice_type,@tax_company_name,@tax_company_add_tel,@tax_tax_code,@tax_bank_name,@tax_bank_num,@is_tax_for_billing)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_type", MySqlDbType.Int32,2),
					new MySqlParameter("@tax_company_name", MySqlDbType.VarChar,40),
					new MySqlParameter("@tax_company_add_tel", MySqlDbType.VarChar,120),
					new MySqlParameter("@tax_tax_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax_bank_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax_bank_num", MySqlDbType.VarChar,20),
					new MySqlParameter("@is_tax_for_billing", MySqlDbType.Int32,2)};
            
            parameters[0].Value = model.id;
            parameters[1].Value = model.customer_id;
            parameters[2].Value = model.user_id;
            parameters[3].Value = model.invoice_type;
            parameters[4].Value = model.tax_company_name;
            parameters[5].Value = model.tax_company_add_tel;
            parameters[6].Value = model.tax_tax_code;
            parameters[7].Value = model.tax_bank_name;
            parameters[8].Value = model.tax_bank_num;
            parameters[9].Value = model.is_tax_for_billing;

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
        public bool Update(XHD.Model.crm_contact_bill model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_contact_bill set ");
            strSql.Append("customer_id=@customer_id,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("invoice_type=@invoice_type,");
            strSql.Append("tax_company_name=@tax_company_name,");
            strSql.Append("tax_company_add_tel=@tax_company_add_tel,");
            strSql.Append("tax_tax_code=@tax_tax_code,");
            strSql.Append("tax_bank_name=@tax_bank_name,");
            strSql.Append("tax_bank_num=@tax_bank_num,");
            strSql.Append("is_tax_for_billing=@is_tax_for_billing");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@invoice_type", MySqlDbType.Int32,2),
					new MySqlParameter("@tax_company_name", MySqlDbType.VarChar,40),
					new MySqlParameter("@tax_company_add_tel", MySqlDbType.VarChar,120),
					new MySqlParameter("@tax_tax_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax_bank_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@tax_bank_num", MySqlDbType.VarChar,20),
					new MySqlParameter("@is_tax_for_billing", MySqlDbType.Int32,2),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.customer_id;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.invoice_type;
            parameters[3].Value = model.tax_company_name;
            parameters[4].Value = model.tax_company_add_tel;
            parameters[5].Value = model.tax_tax_code;
            parameters[6].Value = model.tax_bank_name;
            parameters[7].Value = model.tax_bank_num;
            parameters[8].Value = model.is_tax_for_billing;
            parameters[9].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_contact_bill ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_contact_bill ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public XHD.Model.crm_contact_bill GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,customer_id,user_id,invoice_type,tax_company_name,tax_company_add_tel,tax_tax_code,tax_bank_name,tax_bank_num,is_tax_for_billing from crm_contact_bill ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.crm_contact_bill model = new XHD.Model.crm_contact_bill();
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
        public XHD.Model.crm_contact_bill DataRowToModel(DataRow row)
        {
            XHD.Model.crm_contact_bill model = new XHD.Model.crm_contact_bill();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["customer_id"] != null && row["customer_id"].ToString() != "")
                {
                    model.customer_id = int.Parse(row["customer_id"].ToString());
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["invoice_type"] != null && row["invoice_type"].ToString() != "")
                {
                    model.invoice_type = int.Parse(row["invoice_type"].ToString());
                }
                if (row["tax_company_name"] != null)
                {
                    model.tax_company_name = row["tax_company_name"].ToString();
                }
                if (row["tax_company_add_tel"] != null)
                {
                    model.tax_company_add_tel = row["tax_company_add_tel"].ToString();
                }
                if (row["tax_tax_code"] != null)
                {
                    model.tax_tax_code = row["tax_tax_code"].ToString();
                }
                if (row["tax_bank_name"] != null)
                {
                    model.tax_bank_name = row["tax_bank_name"].ToString();
                }
                if (row["tax_bank_num"] != null)
                {
                    model.tax_bank_num = row["tax_bank_num"].ToString();
                }
                if (row["is_tax_for_billing"] != null && row["is_tax_for_billing"].ToString() != "")
                {
                    model.is_tax_for_billing = int.Parse(row["is_tax_for_billing"].ToString());
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
            strSql.Append("select id,customer_id,user_id,invoice_type,tax_company_name,tax_company_add_tel,tax_tax_code,tax_bank_name,tax_bank_num,is_tax_for_billing ");
            strSql.Append(" FROM crm_contact_bill ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetOneList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  DISTINCT customer_id,invoice_type,tax_company_name,tax_company_add_tel,tax_tax_code from crm_contact_bill ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 加载客户开票资料不唯一数据
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string strWhereOne, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select d.*,u.Customer,u.BeSeats,u.Factory_Id,u.BeSeats_depname from ( ");
            strSql.Append(" select c.*, count(c.customer_id) as num from (select  DISTINCT customer_id,invoice_type,tax_company_name,tax_tax_code from crm_contact_bill ) as c ");
            strSql.Append(" where c.invoice_type is not null group BY c.customer_id, c.invoice_type ) as d ");
            if (string.IsNullOrEmpty(strWhereOne))
            {
                strSql.Append(" INNER JOIN crm_customer u on  d.customer_id=u.id ");
            }
            else
            {
                strSql.Append(" INNER JOIN (  SELECT  distinct *  from ( ");
                strSql.Append(" select c.id,c.Customer,c.tel,c.BeSeats_id,c.BeSeats_uid,c.BeSeats FROM CRM_Customer c  ");
                strSql.Append(" inner join CRM_Contact as t on  C.id=t.C_customerid where " + strWhereOne + " ");
                strSql.Append(" ) as cu ) u on  d.customer_id=u.id ");
            }

            strSql1.Append(" select count(d.customer_id) from ( ");
            strSql1.Append(" select c.*, count(c.customer_id) as num from (select  DISTINCT customer_id,invoice_type,tax_company_name,tax_tax_code from crm_contact_bill ) as c ");
            strSql1.Append(" where c.invoice_type is not null group BY c.customer_id, c.invoice_type ) as d ");
            if (string.IsNullOrEmpty(strWhereOne))
            {
                strSql1.Append(" INNER JOIN crm_customer u on  d.customer_id=u.id ");
            }
            else
            {
                strSql1.Append(" INNER JOIN (  SELECT  distinct *  from ( ");
                strSql1.Append(" select c.id,c.Customer,c.tel,c.BeSeats_id,c.BeSeats_uid,c.BeSeats FROM CRM_Customer c  ");
                strSql1.Append(" inner join CRM_Contact as t on  C.id=t.C_customerid where " + strWhereOne + " ");
                strSql1.Append(" ) as cu ) u on  d.customer_id=u.id ");
            }

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 由客户id查客户开票信息
        /// </summary>
        public DataSet GetBillList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select b.*,c.C_name,c.C_tel from crm_contact_bill b inner join crm_contact c on b.user_id=c.id  ");
            strSql1.Append(" select b.*,c.C_name,c.C_tel from crm_contact_bill b inner join crm_contact c on b.user_id=c.id  ");

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











