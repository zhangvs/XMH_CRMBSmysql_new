﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XHD.DBUtility;

namespace FMS_DAL
{
   /// <summary>
	/// 数据访问类:fms_bank_list_excel
	/// </summary>
	public partial class fms_bank_list_excel
	{
		public fms_bank_list_excel()
		{}

		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return FMS_DbHelperMySQL.GetMaxID("id", "fms_bank_list_excel"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from fms_bank_list_excel");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			return FMS_DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FMS_Model.fms_bank_list_excel model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fms_bank_list_excel(");
            strSql.Append("id,collection_bank_id,collection_bank_code,collection_bank_name,collection_account,dk_time,dk_time_only,dk_money,dk_account,dk_username,dk_bank_name,dk_channel,dk_message_remarks,start_line,excel_exist_collection_account,sort,excel_type,is_use,is_show_full,acc_type,is_collect,is_send_out)");
            strSql.Append(" values (");
            strSql.Append("@id,@collection_bank_id,@collection_bank_code,@collection_bank_name,@collection_account,@dk_time,@dk_time_only,@dk_money,@dk_account,@dk_username,@dk_bank_name,@dk_channel,@dk_message_remarks,@start_line,@excel_exist_collection_account,@sort,@excel_type,@is_use,@is_show_full,@acc_type,@is_collect,@is_send_out)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@collection_bank_id", MySqlDbType.Int16,5),
					new MySqlParameter("@collection_bank_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@collection_bank_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@collection_account", MySqlDbType.VarChar,255),
					new MySqlParameter("@dk_time", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_time_only", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_money", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_account", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_username", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_bank_name", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_channel", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_message_remarks", MySqlDbType.VarChar,6),
					new MySqlParameter("@start_line", MySqlDbType.Int16,5),
					new MySqlParameter("@excel_exist_collection_account", MySqlDbType.Int16,2),
					new MySqlParameter("@sort", MySqlDbType.Int32,3),
					new MySqlParameter("@excel_type", MySqlDbType.VarChar,10),
					new MySqlParameter("@is_use", MySqlDbType.Int16,2),
					new MySqlParameter("@is_show_full", MySqlDbType.Int16,2),
					new MySqlParameter("@acc_type", MySqlDbType.Int16,2),
					new MySqlParameter("@is_collect", MySqlDbType.Int16,2),
                    new MySqlParameter("@is_send_out", MySqlDbType.Int16,2) };
          
            parameters[0].Value = model.id;
            parameters[1].Value = model.collection_bank_id;
            parameters[2].Value = model.collection_bank_code;
            parameters[3].Value = model.collection_bank_name;
            parameters[4].Value = model.collection_account;
            parameters[5].Value = model.dk_time;
            parameters[6].Value = model.dk_time_only;
            parameters[7].Value = model.dk_money;
            parameters[8].Value = model.dk_account;
            parameters[9].Value = model.dk_username;
            parameters[10].Value = model.dk_bank_name;
            parameters[11].Value = model.dk_channel;
            parameters[12].Value = model.dk_message_remarks;
            parameters[13].Value = model.start_line;
            parameters[14].Value = model.excel_exist_collection_account;
            parameters[15].Value = model.sort;
            parameters[16].Value = model.excel_type;
            parameters[17].Value = model.is_use;
            parameters[18].Value = model.is_show_full;
            parameters[19].Value = model.acc_type;
            parameters[20].Value = model.is_collect;
            parameters[21].Value = model.is_send_out;


			int rows=FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(FMS_Model.fms_bank_list_excel model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_bank_list_excel set ");
            strSql.Append("collection_bank_id=@collection_bank_id,");
            strSql.Append("collection_bank_code=@collection_bank_code,");
            strSql.Append("collection_bank_name=@collection_bank_name,");
            strSql.Append("collection_account=@collection_account,");
            strSql.Append("dk_time=@dk_time,");
            strSql.Append("dk_time_only=@dk_time_only,");
            strSql.Append("dk_money=@dk_money,");
            strSql.Append("dk_account=@dk_account,");
            strSql.Append("dk_username=@dk_username,");
            strSql.Append("dk_bank_name=@dk_bank_name,");
            strSql.Append("dk_channel=@dk_channel,");
            strSql.Append("dk_message_remarks=@dk_message_remarks,");
            strSql.Append("start_line=@start_line,");
            strSql.Append("excel_exist_collection_account=@excel_exist_collection_account,");
            strSql.Append("sort=@sort,");
            strSql.Append("excel_type=@excel_type,");
            strSql.Append("is_use=@is_use,");
            strSql.Append("is_show_full=@is_show_full,");
            strSql.Append("acc_type=@acc_type,");
            strSql.Append("is_collect=@is_collect,");
            strSql.Append("is_send_out=@is_send_out");
            strSql.Append(" where id=@id ");
            
            MySqlParameter[] parameters = {
					new MySqlParameter("@collection_bank_id", MySqlDbType.Int16,5),
					new MySqlParameter("@collection_bank_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@collection_bank_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@collection_account", MySqlDbType.VarChar,255),
					new MySqlParameter("@dk_time", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_time_only", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_money", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_account", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_username", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_bank_name", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_channel", MySqlDbType.VarChar,6),
					new MySqlParameter("@dk_message_remarks", MySqlDbType.VarChar,6),
					new MySqlParameter("@start_line", MySqlDbType.Int16,5),
					new MySqlParameter("@excel_exist_collection_account", MySqlDbType.Int16,2),
					new MySqlParameter("@sort", MySqlDbType.Int32,3),
					new MySqlParameter("@excel_type", MySqlDbType.VarChar,10),
					new MySqlParameter("@is_use", MySqlDbType.Int16,2),
					new MySqlParameter("@is_show_full", MySqlDbType.Int16,2),
					new MySqlParameter("@acc_type", MySqlDbType.Int16,2),
					new MySqlParameter("@is_collect", MySqlDbType.Int16,2),
                    new MySqlParameter("@is_send_out", MySqlDbType.Int16,2),                   
					new MySqlParameter("@id", MySqlDbType.Int32,11)};

            parameters[0].Value = model.collection_bank_id;
            parameters[1].Value = model.collection_bank_code;
            parameters[2].Value = model.collection_bank_name;
            parameters[3].Value = model.collection_account;
            parameters[4].Value = model.dk_time;
            parameters[5].Value = model.dk_time_only;
            parameters[6].Value = model.dk_money;
            parameters[7].Value = model.dk_account;
            parameters[8].Value = model.dk_username;
            parameters[9].Value = model.dk_bank_name;
            parameters[10].Value = model.dk_channel;
            parameters[11].Value = model.dk_message_remarks;
            parameters[12].Value = model.start_line;
            parameters[13].Value = model.excel_exist_collection_account;
            parameters[14].Value = model.sort;
            parameters[15].Value = model.excel_type;
            parameters[16].Value = model.is_use;
            parameters[17].Value = model.is_show_full;
            parameters[18].Value = model.acc_type;
            parameters[19].Value = model.is_collect;
            parameters[20].Value = model.is_send_out;
            parameters[21].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from fms_bank_list_excel ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			int rows=FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from fms_bank_list_excel ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=FMS_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public FMS_Model.fms_bank_list_excel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,collection_bank_id,collection_bank_code,collection_bank_name,collection_account,dk_time,dk_time_only,dk_money,dk_account,dk_username,dk_bank_name,dk_channel,dk_message_remarks,start_line,excel_exist_collection_account,sort,excel_type,is_use,is_show_full from fms_bank_list_excel,acc_type,is_collect ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

            FMS_Model.fms_bank_list_excel model = new FMS_Model.fms_bank_list_excel();
			DataSet ds=FMS_DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public FMS_Model.fms_bank_list_excel DataRowToModel(DataRow row)
		{
            FMS_Model.fms_bank_list_excel model = new FMS_Model.fms_bank_list_excel();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                //model.collection_bank_id=row["collection_bank_id"].ToString();
                if (row["collection_bank_code"] != null)
                {
                    model.collection_bank_code = row["collection_bank_code"].ToString();
                }
                if (row["collection_bank_name"] != null)
                {
                    model.collection_bank_name = row["collection_bank_name"].ToString();
                }
                if (row["collection_account"] != null)
                {
                    model.collection_account = row["collection_account"].ToString();
                }
                if (row["dk_time"] != null)
                {
                    model.dk_time = row["dk_time"].ToString();
                }
                if (row["dk_time_only"] != null)
                {
                    model.dk_time_only = row["dk_time_only"].ToString();
                }
                if (row["dk_money"] != null)
                {
                    model.dk_money = row["dk_money"].ToString();
                }
                if (row["dk_account"] != null)
                {
                    model.dk_account = row["dk_account"].ToString();
                }
                if (row["dk_username"] != null)
                {
                    model.dk_username = row["dk_username"].ToString();
                }
                if (row["dk_bank_name"] != null)
                {
                    model.dk_bank_name = row["dk_bank_name"].ToString();
                }
                if (row["dk_channel"] != null)
                {
                    model.dk_channel = row["dk_channel"].ToString();
                }
                if (row["dk_message_remarks"] != null)
                {
                    model.dk_message_remarks = row["dk_message_remarks"].ToString();
                }
                //model.start_line=row["start_line"].ToString();
                if (row["excel_exist_collection_account"] != null && row["excel_exist_collection_account"].ToString() != "")
                {
                    model.excel_exist_collection_account = int.Parse(row["excel_exist_collection_account"].ToString());
                }
                if (row["sort"] != null && row["sort"].ToString() != "")
                {
                    model.sort = int.Parse(row["sort"].ToString());
                }
                if (row["excel_type"] != null)
                {
                    model.excel_type = row["excel_type"].ToString();
                }
                if (row["is_use"] != null && row["is_use"].ToString() != "")
                {
                    model.is_use = int.Parse(row["is_use"].ToString());
                }
                if (row["is_show_full"] != null && row["is_show_full"].ToString() != "")
                {
                    model.is_show_full = int.Parse(row["is_show_full"].ToString());
                }
                if (row["acc_type"] != null && row["acc_type"].ToString() != "")
                {
                    model.acc_type = int.Parse(row["acc_type"].ToString());
                }
                if (row["is_collect"] != null && row["is_collect"].ToString() != "")
                {
                    model.is_collect = int.Parse(row["is_collect"].ToString());
                }
            }
            return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,collection_bank_id,collection_bank_code,collection_bank_name,collection_account,dk_time,dk_time_only,dk_money,dk_account,dk_username,dk_bank_name,dk_channel,dk_message_remarks,start_line,excel_exist_collection_account,sort,excel_type,is_use,is_show_full,acc_type,is_collect,is_send_out,is_cash_bank ");
			strSql.Append(" FROM fms_bank_list_excel ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            strSql.Append(" order by sort ");
			return FMS_DbHelperMySQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 加载打开银行excel格式信息 
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select id,collection_bank_id,collection_bank_code,collection_bank_name,collection_account,dk_time,dk_time_only,dk_money,dk_account,dk_username,dk_bank_name,dk_channel,dk_message_remarks,start_line,excel_exist_collection_account,sort,excel_type,is_use,is_show_full,acc_type,is_collect,is_send_out,is_cash_bank");
            strSql.Append(" FROM fms_bank_list_excel ");
            strSql1.Append(" select count(id) FROM fms_bank_list_excel ");
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
