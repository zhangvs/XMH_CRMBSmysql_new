﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;//Please add references

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:fms_dkmassage
    /// </summary>
    public partial class fms_dkmassage
    {
        public fms_dkmassage()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return FMS_DbHelperMySQL.GetMaxID("id", "fms_dkmassage");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from fms_dkmassage");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return FMS_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>                                                                   
        public int Add(FMS_Model.fms_dkmassage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fms_dkmassage(");
            strSql.Append("id,datetime,price,account,user_id,user_name,channel,deal,stats,notes,is_delete,erp_dakuanhao,add_time,erp_bank_id,confirm_admin_id,confirm_time,erp_time,erp_type,acc_type,kingdee_current_account,is_send_out,kingdee_out_code,from_type,operate_userId,operate_time)");
            strSql.Append(" values (");
            strSql.Append("@id,@datetime,@price,@account,@user_id,@user_name,@channel,@deal,@stats,@notes,@is_delete,@erp_dakuanhao,@add_time,@erp_bank_id,@confirm_admin_id,@confirm_time,@erp_time,@erp_type,@acc_type,@kingdee_current_account,@is_send_out,@kingdee_out_code,@from_type,@operate_userId,@operate_time)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@datetime", MySqlDbType.DateTime),
					new MySqlParameter("@price", MySqlDbType.Decimal,10),
					new MySqlParameter("@account", MySqlDbType.VarChar,100),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@channel", MySqlDbType.VarChar,100),
					new MySqlParameter("@deal", MySqlDbType.VarChar,100),
					new MySqlParameter("@stats", MySqlDbType.VarChar,2),
					new MySqlParameter("@notes", MySqlDbType.VarChar,200),
					new MySqlParameter("@is_delete", MySqlDbType.Int16,1),
					new MySqlParameter("@erp_dakuanhao", MySqlDbType.VarChar,32),
					new MySqlParameter("@add_time", MySqlDbType.DateTime),
					new MySqlParameter("@erp_bank_id", MySqlDbType.VarChar,32),
					new MySqlParameter("@confirm_admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@confirm_time", MySqlDbType.DateTime),
					new MySqlParameter("@erp_time", MySqlDbType.DateTime),
					new MySqlParameter("@erp_type", MySqlDbType.Int16,2),
					new MySqlParameter("@acc_type", MySqlDbType.Int16,2),
                    new MySqlParameter("@kingdee_current_account", MySqlDbType.VarChar,100),
                    new MySqlParameter("@is_send_out", MySqlDbType.Int16,2),
                    new MySqlParameter("@kingdee_out_code", MySqlDbType.VarChar,32),
                    new MySqlParameter("@from_type", MySqlDbType.Int16,2),
                    new MySqlParameter("@operate_userId", MySqlDbType.Int32,11),
					new MySqlParameter("@operate_time", MySqlDbType.DateTime)};

            parameters[0].Value = model.id;
            parameters[1].Value = model.datetime;
            parameters[2].Value = model.price;
            parameters[3].Value = model.account;
            parameters[4].Value = model.user_id;
            parameters[5].Value = model.user_name;
            parameters[6].Value = model.channel;
            parameters[7].Value = model.deal;
            parameters[8].Value = model.stats;
            parameters[9].Value = model.notes;
            parameters[10].Value = model.is_delete;
            parameters[11].Value = model.erp_dakuanhao;
            parameters[12].Value = model.add_time;
            parameters[13].Value = model.erp_bank_id;
            parameters[14].Value = model.confirm_admin_id;
            parameters[15].Value = model.confirm_time;
            parameters[16].Value = model.erp_time;
            parameters[17].Value = model.erp_type;
            parameters[18].Value = model.acc_type;
            parameters[19].Value = model.kingdee_current_account;
            parameters[20].Value = model.is_send_out;
            parameters[21].Value = model.kingdee_out_code;
            parameters[22].Value = model.from_type;
            parameters[23].Value = model.operate_userId;
            parameters[24].Value = model.operate_time;
           
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
        public bool Update(FMS_Model.fms_dkmassage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_dkmassage set ");
            strSql.Append("datetime=@datetime,");
            strSql.Append("price=@price,");
            strSql.Append("account=@account,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("user_name=@user_name,");
            strSql.Append("channel=@channel,");
            strSql.Append("deal=@deal,");
            strSql.Append("stats=@stats,");
            strSql.Append("notes=@notes,");
            strSql.Append("is_delete=@is_delete,");
            strSql.Append("erp_dakuanhao=@erp_dakuanhao,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("erp_bank_id=@erp_bank_id,");
            strSql.Append("confirm_admin_id=@confirm_admin_id,");
            strSql.Append("confirm_time=@confirm_time,");
            strSql.Append("erp_time=@erp_time,");
            strSql.Append("erp_type=@erp_type,");
            strSql.Append("acc_type=@acc_type");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@datetime", MySqlDbType.VarChar,100),
					new MySqlParameter("@price", MySqlDbType.DateTime),
					new MySqlParameter("@account", MySqlDbType.VarChar,100),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@channel", MySqlDbType.VarChar,100),
					new MySqlParameter("@deal", MySqlDbType.VarChar,100),
					new MySqlParameter("@stats", MySqlDbType.VarChar,2),
					new MySqlParameter("@notes", MySqlDbType.VarChar,200),
					new MySqlParameter("@is_delete", MySqlDbType.Int16,1),
					new MySqlParameter("@erp_dakuanhao", MySqlDbType.VarChar,32),
					new MySqlParameter("@add_time", MySqlDbType.DateTime),
					new MySqlParameter("@erp_bank_id", MySqlDbType.VarChar,32),
					new MySqlParameter("@confirm_admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@confirm_time", MySqlDbType.DateTime),
					new MySqlParameter("@erp_time", MySqlDbType.DateTime),
					new MySqlParameter("@erp_type", MySqlDbType.Int16,2),
					new MySqlParameter("@acc_type", MySqlDbType.Int16,2),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.datetime;
            parameters[1].Value = model.price;
            parameters[2].Value = model.account;
            parameters[3].Value = model.user_id;
            parameters[4].Value = model.user_name;
            parameters[5].Value = model.channel;
            parameters[6].Value = model.deal;
            parameters[7].Value = model.stats;
            parameters[8].Value = model.notes;
            parameters[9].Value = model.is_delete;
            parameters[10].Value = model.erp_dakuanhao;
            parameters[11].Value = model.add_time;
            parameters[12].Value = model.erp_bank_id;
            parameters[13].Value = model.confirm_admin_id;
            parameters[14].Value = model.confirm_time;
            parameters[15].Value = model.erp_time;
            parameters[16].Value = model.erp_type;
            parameters[17].Value = model.acc_type;
            parameters[18].Value = model.id;

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
        /// 更新一条数据
        /// </summary>
        public bool Updatee(FMS_Model.fms_dkmassage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_dkmassage set ");
            strSql.Append("user_id=@user_id,");
            strSql.Append("stats=@stats,");
            strSql.Append("erp_dakuanhao=@erp_dakuanhao,");
            strSql.Append("confirm_admin_id=@confirm_admin_id,");
            strSql.Append("confirm_time=@confirm_time,");
            strSql.Append("erp_time=@erp_time");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {		
			        new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@stats", MySqlDbType.VarChar,2),					
					new MySqlParameter("@erp_dakuanhao", MySqlDbType.VarChar,32),					
					new MySqlParameter("@confirm_admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@confirm_time", MySqlDbType.DateTime),
					new MySqlParameter("@erp_time", MySqlDbType.DateTime),					
					new MySqlParameter("@id", MySqlDbType.Int32,11)};

            parameters[0].Value = model.user_id;
            parameters[1].Value = model.stats;
            parameters[2].Value = model.erp_dakuanhao;
            parameters[3].Value = model.confirm_admin_id;
            parameters[4].Value = model.confirm_time;
            parameters[5].Value = model.erp_time;
            parameters[6].Value = model.id;

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
        /// 更新一条数据
        /// </summary>
        public bool Updates(FMS_Model.fms_dkmassage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_dkmassage set ");
            strSql.Append("stats=@stats,");
            strSql.Append("erp_dakuanhao=@erp_dakuanhao,");
            strSql.Append("confirm_admin_id=@confirm_admin_id,");
            strSql.Append("confirm_time=@confirm_time,");
            strSql.Append("erp_time=@erp_time");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {		
					new MySqlParameter("@stats", MySqlDbType.VarChar,2),					
					new MySqlParameter("@erp_dakuanhao", MySqlDbType.VarChar,32),					
					new MySqlParameter("@confirm_admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@confirm_time", MySqlDbType.DateTime),
					new MySqlParameter("@erp_time", MySqlDbType.DateTime),					
					new MySqlParameter("@id", MySqlDbType.Int32,11)};

            parameters[0].Value = model.stats;
            parameters[1].Value = model.erp_dakuanhao;
            parameters[2].Value = model.confirm_admin_id;
            parameters[3].Value = model.confirm_time;
            parameters[4].Value = model.erp_time;
            parameters[5].Value = model.id;

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
        /// 认款
        /// </summary>
        public bool KnowKuan(int flag, FMS_Model.fms_dkmassage model)
        {
            fms_kuan kuan = new fms_kuan();

            List<string> strSqlList = new List<string>();

            string strSql = string.Empty;


            switch (flag)
            {
                case 1:  //认款
                    strSql = string.Format(@" update fms_dkmassage set user_id='{0}',confirm_admin_id='{1}',confirm_time='{2}',stats='{3}' where id='{4}'",
                                           model.user_id, model.confirm_admin_id, model.confirm_time, model.stats, model.id);
                    strSqlList.Add(strSql);
                    break;

                case 2:  //未确认、待确认的重新认款

                    DataSet ds = kuan.GetList(" dkmassage_id='" + model.id + "'");
                    strSql = string.Format(@" update fms_dkmassage set stats='{0}',operate_userId='{1}',operate_time='{2}' where id='{3}'", model.stats,model.operate_userId,model.operate_time, model.id);
                    strSqlList.Add(strSql);

                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        strSql = string.Format(" update fms_kuan  set status ='{0}'where dkmassage_id='{1}'", 1, model.id);
                        strSqlList.Add(strSql);
                    }
                    break;

                default:
                    break;
            }

            int rows = FMS_DbHelperMySQL.ExecuteSqlTran(strSqlList);
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
        public bool Hand(FMS_Model.fms_dkmassage model)
        {
           string strSql = string.Format(@" update fms_dkmassage set kingdee_out_code='{0}',is_bill_handle='{1}' where id='{2}'",
                                           model.kingdee_out_code, model.is_bill_handle, model.id);

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
        /// 重新认款
        /// </summary>
        public bool KnowKuans(FMS_Model.fms_dkmassage model, FMS_Model.shop_progress_payments progress)
        {
            fms_kuan kuan = new fms_kuan();
            shop_progress_payments _proPayments = new shop_progress_payments();

            List<string> strSqlList = new List<string>();

            string strSql = string.Empty;

            DataSet ds = kuan.GetList(" dkmassage_id='" + model.id + "'");


            //已认款、待收款的重新认款

            strSql = string.Format(@" update fms_dkmassage set stats='{0}',operate_userId='{1}',operate_time='{2}' where id='{3}'", model.stats,model.operate_userId,model.operate_time, model.id);
            strSqlList.Add(strSql);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                strSql = string.Format(" Delete from fms_kuan where dkmassage_id='{0}'", model.id);

                //strSql = string.Format(" update fms_kuan  set status ='{0}'where dkmassage_id='{1}'", 1, model.id);

                strSqlList.Add(strSql);
            }

            //3.shop_progress_payments

            DataSet dp = _proPayments.GetLists(" order_sn='" + model.id + "' and type='2' ");
            if (dp != null && dp.Tables[0].Rows.Count > 0)
            {
                strSql = string.Format(" Delete from xmh_shop.shop_progress_payments where order_sn='{0}' and type='{1}' ", model.id,2);
                //strSql = string.Format(" update  xmh_shop.shop_progress_payments  set status='{0}' where order_sn='{2}'",2, model.id);
                strSqlList.Add(strSql);
            }

            //_proPayments.Add(progress);
            //strSqlList.Add(strSql);

            int rows = FMS_DbHelperMySQL.ExecuteSqlTran(strSqlList);
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
        /// 删除
        /// </summary>
        public bool DelKuan(FMS_Model.fms_dkmassage mModel, FMS_Model.shop_progress_payments progress)
        {
            fms_kuan kuan = new fms_kuan();
            shop_progress_payments _proPayments = new shop_progress_payments();

            List<string> strSqlList = new List<string>();

            string strSql = string.Empty;

            DataSet ds = kuan.GetList(" dkmassage_id='" + mModel.id + "'");

            strSql = string.Format(@" update fms_dkmassage set is_delete='{0}',operate_userId='{1}',operate_time='{2}' where id='{3}'", 1, mModel.operate_userId, mModel.operate_time, mModel.id);
            strSqlList.Add(strSql);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                strSql = string.Format(" Delete from fms_kuan where dkmassage_id='{0}'", mModel.id);

                //strSql = string.Format(" update fms_kuan  set status ='{0}'where dkmassage_id='{1}'", 1, mModel.id);
                strSqlList.Add(strSql);

                //3.shop_progress_payments
                //_proPayments.Add(progress);
                //strSqlList.Add(strSql);
            }


            DataSet dp = _proPayments.GetLists(" order_sn='" + mModel.id + "' and type='2' ");
            if (dp != null && dp.Tables[0].Rows.Count > 0)
            {
                strSql = string.Format(" Delete from xmh_shop.shop_progress_payments where order_sn='{0} and type='{1}' ", mModel.id,2);
                strSqlList.Add(strSql);
            }


            int rows = FMS_DbHelperMySQL.ExecuteSqlTran(strSqlList);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //批量删除
        public bool DelAllKuan(string idList, FMS_Model.fms_dkmassage mModel)
        {
            fms_kuan kuan = new fms_kuan();
            shop_progress_payments _proPayments = new shop_progress_payments();

            List<string> strSqlList = new List<string>();

            string strSql = string.Empty;

            DataSet ds = GetList(" id in(" + idList + ")");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //strSql = string.Format(@" delete from fms_dkmassage where id='{0}'", Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString()));

                    strSql = string.Format(@" update fms_dkmassage set is_delete='{0}',operate_userId='{1}',operate_time='{2}' where id='{3}'", 1,mModel.operate_userId,mModel.operate_time, Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString()));
                    strSqlList.Add(strSql);

                    DataSet dk = kuan.GetList(" dkmassage_id='" + ds.Tables[0].Rows[i]["id"].ToString() + "'");
                    if (dk != null && dk.Tables[0].Rows.Count > 0)
                    {
                        strSql = string.Format(" Delete from fms_kuan where dkmassage_id='{0}'", Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString()));
                        //strSql = string.Format(" update fms_kuan  set status ='{0}'where dkmassage_id='{1}'", 1, Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString()));
                        strSqlList.Add(strSql);
                    }


                    DataSet dp = _proPayments.GetLists(" order_sn='" + ds.Tables[0].Rows[i]["id"].ToString() + "'  and type='2' ");
                    if (dp != null && dp.Tables[0].Rows.Count > 0)
                    {
                        strSql = string.Format(" Delete from xmh_shop.shop_progress_payments where order_sn='{0}' and type='{1}'", Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString()),2);
                        strSqlList.Add(strSql);
                    }
                }
            }

            int rows = FMS_DbHelperMySQL.ExecuteSqlTran(strSqlList);
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
            strSql.Append("delete from fms_dkmassage ");
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
        /// 删除一条数据
        /// </summary>
        public bool Del(FMS_Model.fms_dkmassage mModel)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_dkmassage set is_delete='1',operate_userId='" + mModel.operate_userId + "',operate_time='" + mModel.operate_time + "'");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};

            parameters[0].Value = mModel.id;

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
            strSql.Append(" update  fms_dkmassage set is_delete='1' ");
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
        public FMS_Model.fms_dkmassage GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,datetime,price,account,user_id,user_name,channel,deal,stats,notes,is_delete,erp_dakuanhao,add_time,erp_bank_id,confirm_admin_id,confirm_time,erp_time,erp_type,acc_type from fms_dkmassage ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            FMS_Model.fms_dkmassage model = new FMS_Model.fms_dkmassage();
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
        public FMS_Model.fms_dkmassage DataRowToModel(DataRow row)
        {
            FMS_Model.fms_dkmassage model = new FMS_Model.fms_dkmassage();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["datetime"] != null && row["datetime"].ToString() != "")
                {
                    model.datetime = DateTime.Parse(row["datetime"].ToString());
                }
                //if (row["price"] != null)
                //{
                //    model.price = row["price"].ToString();
                //}
                if (row["account"] != null)
                {
                    model.account = row["account"].ToString();
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["user_name"] != null)
                {
                    model.user_name = row["user_name"].ToString();
                }
                if (row["channel"] != null)
                {
                    model.channel = row["channel"].ToString();
                }
                if (row["deal"] != null)
                {
                    model.deal = row["deal"].ToString();
                }
                if (row["stats"] != null)
                {
                    model.stats = row["stats"].ToString();
                }
                if (row["notes"] != null)
                {
                    model.notes = row["notes"].ToString();
                }
                if (row["is_delete"] != null && row["is_delete"].ToString() != "")
                {
                    model.is_delete = int.Parse(row["is_delete"].ToString());
                }
                if (row["erp_dakuanhao"] != null)
                {
                    model.erp_dakuanhao = row["erp_dakuanhao"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = DateTime.Parse(row["add_time"].ToString());
                }
                if (row["erp_bank_id"] != null)
                {
                    model.erp_bank_id = row["erp_bank_id"].ToString();
                }
                if (row["confirm_admin_id"] != null && row["confirm_admin_id"].ToString() != "")
                {
                    model.confirm_admin_id = int.Parse(row["confirm_admin_id"].ToString());
                }
                if (row["confirm_time"] != null && row["confirm_time"].ToString() != "")
                {
                    model.confirm_time = DateTime.Parse(row["confirm_time"].ToString());
                }
                if (row["erp_time"] != null && row["erp_time"].ToString() != "")
                {
                    model.erp_time = DateTime.Parse(row["erp_time"].ToString());
                }
                if (row["erp_type"] != null && row["erp_type"].ToString() != "")
                {
                    model.erp_type = int.Parse(row["erp_type"].ToString());
                }
                if (row["acc_type"] != null && row["acc_type"].ToString() != "")
                {
                    model.acc_type = int.Parse(row["acc_type"].ToString());
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
            strSql.Append("select id, datetime,price,account,user_id,user_name,channel,deal,stats,notes,is_delete,erp_dakuanhao,add_time,erp_bank_id,confirm_admin_id,CAST( confirm_time as char) as confirm_time,CAST( erp_time as char) as erp_time,erp_type,acc_type,is_send_out ");
            strSql.Append(" FROM fms_dkmassage ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListBank(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select e.is_cash_bank,e.collection_bank_code,e.collection_bank_name,e.is_send_out,d.id, d.datetime,d.price,d.account,d.user_id,d.user_name,d.channel,d.deal,stats,d.notes,d.is_delete,d.erp_dakuanhao,d.is_inner_Journal, ");
            strSql.Append(" d.add_time,d.erp_bank_id,d.confirm_admin_id,CAST( d.confirm_time as char) as confirm_time,CAST( d.erp_time as char) as erp_time,d.erp_type,d.acc_type,d.kingdee_current_account ");
            strSql.Append(" FROM fms_dkmassage d  inner join fms_bank_list_excel e on d.erp_bank_id=e.collection_bank_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListC(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select u.Serialnumber,u.Customer,u.BeSeats,u.BeSeats_id,u.BeSeats_uid,c.C_tel,c.bill_bank_code1,c.bill_bank_code2,c.bill_bank_code3, c.bill_bank_code4,c.bill_bank_code5, c.bill_bank_code6,   ");
            strSql.Append(" m.id,CAST( m.datetime as char) as datetime,m.price,m.account,m.user_id,m.user_name,m.channel,m.deal,m.stats,m.notes,m.is_delete,m.erp_dakuanhao,CAST( m.add_time as char) as add_time,m.erp_bank_id,m.confirm_admin_id,CAST( m.confirm_time as char) as confirm_time,CAST( m.erp_time as char) as erp_time,m.erp_type,m.acc_type ");
            strSql.Append(" FROM xmh_fms.fms_dkmassage m left join crm_contact c on c.id =m.user_id ");
            strSql.Append(" inner join crm_customer u on c.C_customerid =u.id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 加载公司户/个人户待认款信息
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select m.id,m.datetime,m.price,m.account,b.collection_bank_name,m.user_id,m.user_name,m.channel,m.deal,m.stats,m.notes,m.is_delete,m.erp_dakuanhao,m.add_time,m.erp_bank_id,m.is_inner_Journal,m.is_bill_handle, ");
            strSql.Append(" m.confirm_admin_id,CAST( m.confirm_time as char) as confirm_time,CAST( m.erp_time as char) as erp_time,m.erp_type,m.acc_type,k.status,m.is_send_out,m.kingdee_out_code,m.from_type ");
            strSql.Append(" FROM fms_dkmassage m inner join fms_bank_list_excel b on m.erp_bank_id=b.collection_bank_id ");
            strSql.Append(" left join (select dkmassage_id,status from fms_kuan where status='0' ) as k on m.id=k.dkmassage_id  ");
            strSql1.Append(" select count(m.id) FROM fms_dkmassage  m inner join fms_bank_list_excel b on m.erp_bank_id=b.collection_bank_id left join fms_kuan k on m.id=k.dkmassage_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = FMS_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

