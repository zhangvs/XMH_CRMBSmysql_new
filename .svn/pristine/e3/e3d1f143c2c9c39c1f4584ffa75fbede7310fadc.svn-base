using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;//Please add references

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:fms_kuan_adjust
    /// </summary>
    public partial class fms_kuan_adjust
    {
        public fms_kuan_adjust()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return FMS_DbHelperMySQL.GetMaxID("id", "fms_kuan_adjust");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from fms_kuan_adjust");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return FMS_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FMS_Model.fms_kuan_adjust model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fms_kuan_adjust(");
            strSql.Append("id,date_time,customer_id,user_id,change_total,change_type,change_desc,admin_id,erp_dakuanhao,erp_time,debit_account_code,credit_account_code,status,approvalPrimary_empId,approvalPrimary_empcode,approvalPrimary_empname,approvalPrimary_Opinion,approvalPrimary_date,approvalOne_empId,approvalOne_empcode,approvalOne_empname,approvalOne_Opinion,approvalOne_date,approvalTwo_empId,approvalTwo_empcode,approvalTwo_date,approvalTwo_status,adjust_sn)");
            strSql.Append(" values (");
            strSql.Append("@id,@date_time,@customer_id,@user_id,@change_total,@change_type,@change_desc,@admin_id,@erp_dakuanhao,@erp_time,@debit_account_code,@credit_account_code,@status,@approvalPrimary_empId,@approvalPrimary_empcode,@approvalPrimary_empname,@approvalPrimary_Opinion,@approvalPrimary_date,@approvalOne_empId,@approvalOne_empcode,@approvalOne_empname,@approvalOne_Opinion,@approvalOne_date,@approvalTwo_empId,@approvalTwo_empcode,@approvalTwo_date,@approvalTwo_status,@adjust_sn)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@date_time", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@change_total", MySqlDbType.Decimal,10),
					new MySqlParameter("@change_type", MySqlDbType.Int16,2),
					new MySqlParameter("@change_desc", MySqlDbType.VarChar,255),
					new MySqlParameter("@admin_id", MySqlDbType.VarChar,10),
					new MySqlParameter("@erp_dakuanhao", MySqlDbType.VarChar,32),
					new MySqlParameter("@erp_time", MySqlDbType.Int32,11),
					new MySqlParameter("@debit_account_code", MySqlDbType.VarChar,100),
					new MySqlParameter("@credit_account_code", MySqlDbType.VarChar,100),
					new MySqlParameter("@status", MySqlDbType.Int16,2),
					new MySqlParameter("@approvalPrimary_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@approvalPrimary_empcode", MySqlDbType.VarChar,60),
					new MySqlParameter("@approvalPrimary_empname", MySqlDbType.VarChar,60),
					new MySqlParameter("@approvalPrimary_Opinion", MySqlDbType.VarChar,200),
					new MySqlParameter("@approvalPrimary_date", MySqlDbType.DateTime),
					new MySqlParameter("@approvalOne_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@approvalOne_empcode", MySqlDbType.VarChar,60),
					new MySqlParameter("@approvalOne_empname", MySqlDbType.VarChar,60),
					new MySqlParameter("@approvalOne_Opinion", MySqlDbType.VarChar,200),
					new MySqlParameter("@approvalOne_date", MySqlDbType.DateTime),
					new MySqlParameter("@approvalTwo_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@approvalTwo_empcode", MySqlDbType.VarChar,60),
					new MySqlParameter("@approvalTwo_date", MySqlDbType.DateTime),
					new MySqlParameter("@approvalTwo_status", MySqlDbType.Int16,2),
                    new MySqlParameter("@adjust_sn",MySqlDbType.VarChar,20)};

            parameters[0].Value = model.id;
            parameters[1].Value = model.date_time;
            parameters[2].Value = model.customer_id;
            parameters[3].Value = model.user_id;
            parameters[4].Value = model.change_total;
            parameters[5].Value = model.change_type;
            parameters[6].Value = model.change_desc;
            parameters[7].Value = model.admin_id;
            parameters[8].Value = model.erp_dakuanhao;
            parameters[9].Value = model.erp_time;
            parameters[10].Value = model.debit_account_code;
            parameters[11].Value = model.credit_account_code;
            parameters[12].Value = model.status;
            parameters[13].Value = model.approvalPrimary_empId;
            parameters[14].Value = model.approvalPrimary_empcode;
            parameters[15].Value = model.approvalPrimary_empname;
            parameters[16].Value = model.approvalPrimary_Opinion;
            parameters[17].Value = model.approvalPrimary_date;
            parameters[18].Value = model.approvalOne_empId;
            parameters[19].Value = model.approvalOne_empcode;
            parameters[20].Value = model.approvalOne_empname;
            parameters[21].Value = model.approvalOne_Opinion;
            parameters[22].Value = model.approvalOne_date;
            parameters[23].Value = model.approvalTwo_empId;
            parameters[24].Value = model.approvalTwo_empcode;
            parameters[25].Value = model.approvalTwo_date;
            parameters[26].Value = model.approvalTwo_status;
            parameters[27].Value = model.adjust_sn;

            object obj = FMS_DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FMS_Model.fms_kuan_adjust model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_kuan_adjust set ");
            strSql.Append("date_time=@date_time,");
            strSql.Append("customer_id=@customer_id,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("change_total=@change_total,");
            strSql.Append("change_type=@change_type,");
            strSql.Append("change_desc=@change_desc,");
            strSql.Append("admin_id=@admin_id,");
            strSql.Append("erp_dakuanhao=@erp_dakuanhao,");
            strSql.Append("erp_time=@erp_time,");
            strSql.Append("status=@status");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@date_time", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@change_total", MySqlDbType.Decimal,10),
					new MySqlParameter("@change_type", MySqlDbType.Int16,2),
					new MySqlParameter("@change_desc", MySqlDbType.VarChar,255),
					new MySqlParameter("@admin_id", MySqlDbType.VarChar,10),
					new MySqlParameter("@erp_dakuanhao", MySqlDbType.VarChar,32),
					new MySqlParameter("@erp_time", MySqlDbType.Int32,11),
					new MySqlParameter("@status", MySqlDbType.Int16,2),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.date_time;
            parameters[1].Value = model.customer_id;
            parameters[2].Value = model.user_id;
            parameters[3].Value = model.change_total;
            parameters[4].Value = model.change_type;
            parameters[5].Value = model.change_desc;
            parameters[6].Value = model.admin_id;
            parameters[7].Value = model.erp_dakuanhao;
            parameters[8].Value = model.erp_time;
            parameters[9].Value = model.status;
            parameters[10].Value = model.id;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 更新erp号
        /// </summary>
        public bool Updates(string id, string erpCode, int time, string debit_account_code, string credit_account_code)
        {
            string strSql = string.Empty;

            if (!string.IsNullOrEmpty(erpCode))
            {
                strSql = string.Format(@"update fms_kuan_adjust set erp_dakuanhao='{0}',status='{1}',erp_time='{2}',debit_account_code='{3}',credit_account_code='{4}' where id='{5}'", erpCode, 1, time, debit_account_code, credit_account_code,id);
            }
            else
            {
                strSql = string.Format(@"update fms_kuan_adjust set status='{0}' where id='{1}'", 2, id);
            }

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public bool updateHao(string hao, int id)
        {
            string strSql = string.Empty;
            strSql = string.Format(@"update fms_kuan_adjust set erp_dakuanhao='{0}' where id='{1}'", hao, id);

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        /// 审核
        /// </summary>
        public bool updateStatus(string status, string idList, string remark)
        {
            string strSql = string.Empty;

            //3:一级审批通过;4：一级审批未通过;5:初级审批通过;6：初级审批未通过;
            switch (status)
            {
                case "3": //一级审批通过
                    strSql = string.Format(@"update fms_kuan_adjust set status='{0}',approvalOne_date='{1}' where id in ({2})", status, DateTime.Now, idList);
                    break;
                case "4": //一级审批未通过;
                    strSql = string.Format(@"update fms_kuan_adjust set status='{0}',approvalOne_date='{1}',approvalOne_Opinion='{2}' where id in ({3})", status, DateTime.Now,remark, idList);
                    break;
                case "5"://初级审批通过
                    strSql = string.Format(@"update fms_kuan_adjust set status='{0}',approvalPrimary_date='{1}' where id in ({2})", status, DateTime.Now, idList);;
                    break;
                case "6"://初级审批未通过
                    strSql = string.Format(@"update fms_kuan_adjust set status='{0}',approvalPrimary_date='{1}',approvalPrimary_Opinion='{2}' where id in ({3})", status, DateTime.Now,remark, idList);;
                    break;
                default:
                    strSql = string.Format(@"update fms_kuan_adjust set approvalTwo_status='{0}',approvalTwo_date='{1}' where id in ({2})", 1, DateTime.Now, idList);
                    break;
            }

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        /// 只更改商城数据
        /// </summary>
        public bool adopt(string idList,int empId,int time)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            DataSet ds = GetListInfo(" k.id in (" + idList + ")");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    strSql = string.Format(@"update fms_kuan_adjust set status='{0}',operate_empId='{1}',operate_date='{2}' where id ='{3}'",
                                             7, empId, DateTime.Now, Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString()));
                    strSqlList.Add(strSql);

                    strSql = string.Format(@"update xmh_shop.shop_progress_payments set type='{0}',add_time='{1}',money='{2}',user_id='{3}',employee_id='{4}',emp_code='{5}',msg='{6}',
                                             status='{7}',start_valid_time='{8}',order_sn='{9}' where id ='{10}'", 
                                             4, time,  Convert.ToDecimal(ds.Tables[0].Rows[i]["change_total"].ToString()),Convert.ToInt32(ds.Tables[0].Rows[i]["user_id"].ToString()),
                                             Convert.ToInt32(ds.Tables[0].Rows[i]["BeSeats_id"].ToString()),ds.Tables[0].Rows[i]["emp_code"].ToString(),"款项来源于调账流程",1,time,
                                             ds.Tables[0].Rows[i]["id"].ToString(),Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString()));
                    strSqlList.Add(strSql);
                }
            }

            int rows = FMS_DbHelperMySQL.ExecuteSqlTran(strSqlList);
            if (rows >= 0)
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
            strSql.Append("delete from fms_kuan_adjust ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
            strSql.Append("delete from fms_kuan_adjust ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public FMS_Model.fms_kuan_adjust GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,date_time,customer_id,user_id,change_total,change_type,change_desc,admin_id,erp_dakuanhao,erp_time,status,adjust_sn from fms_kuan_adjust ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            FMS_Model.fms_kuan_adjust model = new FMS_Model.fms_kuan_adjust();
            DataSet ds = FMS_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public FMS_Model.fms_kuan_adjust DataRowToModel(DataRow row)
        {
            FMS_Model.fms_kuan_adjust model = new FMS_Model.fms_kuan_adjust();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["date_time"] != null && row["date_time"].ToString() != "")
                {
                    model.date_time = int.Parse(row["date_time"].ToString());
                }
                if (row["customer_id"] != null && row["customer_id"].ToString() != "")
                {
                    model.customer_id = int.Parse(row["customer_id"].ToString());
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["change_total"] != null && row["change_total"].ToString() != "")
                {
                    model.change_total = decimal.Parse(row["change_total"].ToString());
                }
                if (row["change_type"] != null && row["change_type"].ToString() != "")
                {
                    model.change_type = int.Parse(row["change_type"].ToString());
                }
                if (row["change_desc"] != null)
                {
                    model.change_desc = row["change_desc"].ToString();
                }
                if (row["admin_id"] != null)
                {
                    model.admin_id = row["admin_id"].ToString();
                }
                if (row["erp_dakuanhao"] != null)
                {
                    model.erp_dakuanhao = row["erp_dakuanhao"].ToString();
                }
                if (row["erp_time"] != null && row["erp_time"].ToString() != "")
                {
                    model.erp_time = int.Parse(row["erp_time"].ToString());
                }
                if (row["status"] != null && row["status"].ToString() != "")
                {
                    model.status = int.Parse(row["status"].ToString());
                }
                if (row["adjust_sn"] != null)
                {
                    model.adjust_sn = row["adjust_sn"].ToString();
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
            strSql.Append("select id,date_time,customer_id,user_id,change_total,change_type,change_desc,admin_id,erp_dakuanhao,erp_time,status,debit_account_code,credit_account_code,adjust_sn ");
            strSql.Append(" FROM fms_kuan_adjust ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select k.*,u.id as customer_id,u.Serialnumber,u.Customer,u.BeSeats,u.BeSeats_id,u.BeSeats_uid,e.emp_code,d.dept_code_kingdee ");
            strSql.Append(" FROM xmh_fms.fms_kuan_adjust k inner join crm_customer u on u.id =k.customer_id ");
            strSql.Append(" left join hr_employee as e on u.BeSeats_id=e.ID ");
            strSql.Append(" left join hr_department as d on d.id=e.d_id ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        //获得客户的调账金额
        public string GetTransferAmoun(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  sum(change_total) as transfer_amount from fms_kuan_adjust ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            object obj = FMS_DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }

            else
            {
                return obj.ToString();
            }
        }


        /// <summary>
        /// 加载客户的调账信息
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, int mark, string strWhere, DataTable dt, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            if (mark == 1)
            {
                strSql.Append(" select distinct * from ( ");
                strSql1.Append(" select count(distinct id) from ( ");

                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            strSql.Append(" select id,date_time,customer_id,user_id,change_total,change_type,change_desc,admin_id,erp_dakuanhao,erp_time,status,debit_account_code,credit_account_code,adjust_sn  FROM fms_kuan_adjust  ");
                            strSql.Append(" where  user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and date_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                            strSql1.Append(" select id FROM fms_kuan_adjust ");
                            strSql1.Append(" where user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and date_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        }
                        else
                        {
                            strSql.Append(" union all  select id,date_time,customer_id,user_id,change_total,change_type,change_desc,admin_id,erp_dakuanhao,erp_time,status,debit_account_code,credit_account_code,adjust_sn  FROM fms_kuan_adjust  ");
                            strSql.Append(" where  user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and date_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                            strSql1.Append(" union all  select id  FROM  fms_kuan_adjust ");
                            strSql1.Append(" where user_id  ='" + dt.Rows[i]["userId"].ToString() + "' and date_time>='" + dt.Rows[i]["datetime"].ToString() + "' ");
                        }
                    }
                }

                strSql.Append(" ) as g ");
                strSql1.Append(" ) as g ");

            }
            else if (mark == 2)
            {
                strSql.Append("select id,date_time,customer_id,user_id,change_total,change_type,change_desc,admin_id,erp_dakuanhao,erp_time,status,debit_account_code,credit_account_code,adjust_sn  ");
                strSql.Append(" FROM fms_kuan_adjust ");

                strSql1.Append(" select count(id) FROM fms_kuan_adjust ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" where " + strWhere);
                    strSql1.Append(" where " + strWhere);
                }
            }

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = FMS_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 加载调账信息信息 
        /// </summary>
        public DataSet GetLists(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select k.id,k.date_time as date_time,k.user_id,k.change_total,k.change_type,k.change_desc,k.admin_id,k.erp_dakuanhao,k.debit_account_code,k.credit_account_code,");
            strSql.Append(" k.approvalTwo_status,k.approvalPrimary_Opinion,k.approvalOne_Opinion,k.adjust_sn,");
            strSql.Append(" k.erp_time as erp_time,k.status,c.C_name,c.C_tel,u.Customer, u.id as customer_id, u.Serialnumber,u.BeSeats_id,u.BeSeats_uid,u.BeSeats,concat(c.C_name,',',c.C_tel,',',u.Customer) as cus,");
            strSql.Append(" e.emp_code,e.name,concat(e.emp_code,' ',e.name) as code_name,d.dept_code_kingdee from xmh_fms.fms_kuan_adjust k ");
            strSql.Append(" inner join  crm_contact c on k.user_id=c.id  ");
            strSql.Append(" inner join  crm_customer u on k.customer_id=u.id  ");
            strSql.Append(" left join  hr_employee e on e.ID=u.BeSeats_id  ");
            strSql.Append(" left join  hr_department d on d.id=e.d_id  ");

            strSql1.Append(" select count(k.id) from xmh_fms.fms_kuan_adjust k");
            strSql1.Append(" inner join  crm_contact c on k.user_id=c.id  ");
            strSql1.Append(" inner join  crm_customer u on k.customer_id=u.id  ");

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

