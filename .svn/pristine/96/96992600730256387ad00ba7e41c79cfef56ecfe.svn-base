/**  版本信息模板在安装目录下，可自行修改。
* crm_contact_bill_check.cs
*
* 功 能： N/A
* 类 名： crm_contact_bill_check
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/1/19 16:28:24   N/A    初版
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
	/// 数据访问类:crm_contact_bill_check
	/// </summary>
	public partial class crm_contact_bill_check
	{
		public crm_contact_bill_check()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "crm_contact_bill_check"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from crm_contact_bill_check");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.crm_contact_bill_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into crm_contact_bill_check(");
			strSql.Append("id,tax_code,new_tax_code,id_list,check_id,check_code,check_name,check_date,sub_id,sub_code,sub_name,sub_date,status)");
			strSql.Append(" values (");
			strSql.Append("@id,@tax_code,@new_tax_code,@id_list,@check_id,@check_code,@check_name,@check_date,@sub_id,@sub_code,@sub_name,@sub_date,@status)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@tax_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@new_tax_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@id_list", MySqlDbType.VarChar,255),
					new MySqlParameter("@check_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@check_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@check_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@check_date", MySqlDbType.DateTime),
					new MySqlParameter("@sub_id", MySqlDbType.Int32,11),
					new MySqlParameter("@sub_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@sub_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@sub_date", MySqlDbType.DateTime),
					new MySqlParameter("@status", MySqlDbType.Int32,2)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.tax_code;
			parameters[2].Value = model.new_tax_code;
			parameters[3].Value = model.id_list;
			parameters[4].Value = model.check_id;
			parameters[5].Value = model.check_code;
			parameters[6].Value = model.check_name;
			parameters[7].Value = model.check_date;
			parameters[8].Value = model.sub_id;
			parameters[9].Value = model.sub_code;
			parameters[10].Value = model.sub_name;
			parameters[11].Value = model.sub_date;
			parameters[12].Value = model.status;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(XHD.Model.crm_contact_bill_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update crm_contact_bill_check set ");
			strSql.Append("tax_code=@tax_code,");
			strSql.Append("new_tax_code=@new_tax_code,");
			strSql.Append("id_list=@id_list,");
			strSql.Append("check_id=@check_id,");
			strSql.Append("check_code=@check_code,");
			strSql.Append("check_name=@check_name,");
			strSql.Append("check_date=@check_date,");
			strSql.Append("sub_id=@sub_id,");
			strSql.Append("sub_code=@sub_code,");
			strSql.Append("sub_name=@sub_name,");
			strSql.Append("sub_date=@sub_date,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@tax_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@new_tax_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@id_list", MySqlDbType.VarChar,255),
					new MySqlParameter("@check_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@check_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@check_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@check_date", MySqlDbType.DateTime),
					new MySqlParameter("@sub_id", MySqlDbType.Int32,11),
					new MySqlParameter("@sub_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@sub_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@sub_date", MySqlDbType.DateTime),
					new MySqlParameter("@status", MySqlDbType.Int32,2),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.tax_code;
			parameters[1].Value = model.new_tax_code;
			parameters[2].Value = model.id_list;
			parameters[3].Value = model.check_id;
			parameters[4].Value = model.check_code;
			parameters[5].Value = model.check_name;
			parameters[6].Value = model.check_date;
			parameters[7].Value = model.sub_id;
			parameters[8].Value = model.sub_code;
			parameters[9].Value = model.sub_name;
			parameters[10].Value = model.sub_date;
			parameters[11].Value = model.status;
			parameters[12].Value = model.id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
			strSql.Append("delete from crm_contact_bill_check ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
			strSql.Append("delete from crm_contact_bill_check ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public XHD.Model.crm_contact_bill_check GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,tax_code,new_tax_code,id_list,check_id,check_code,check_name,check_date,sub_id,sub_code,sub_name,sub_date,status from crm_contact_bill_check ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			XHD.Model.crm_contact_bill_check model=new XHD.Model.crm_contact_bill_check();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
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
		public XHD.Model.crm_contact_bill_check DataRowToModel(DataRow row)
		{
			XHD.Model.crm_contact_bill_check model=new XHD.Model.crm_contact_bill_check();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["tax_code"]!=null)
				{
					model.tax_code=row["tax_code"].ToString();
				}
				if(row["new_tax_code"]!=null)
				{
					model.new_tax_code=row["new_tax_code"].ToString();
				}
				if(row["id_list"]!=null)
				{
					model.id_list=row["id_list"].ToString();
				}
				if(row["check_id"]!=null)
				{
					model.check_id=row["check_id"].ToString();
				}
				if(row["check_code"]!=null)
				{
					model.check_code=row["check_code"].ToString();
				}
				if(row["check_name"]!=null)
				{
					model.check_name=row["check_name"].ToString();
				}
				if(row["check_date"]!=null && row["check_date"].ToString()!="")
				{
					model.check_date=DateTime.Parse(row["check_date"].ToString());
				}
				if(row["sub_id"]!=null && row["sub_id"].ToString()!="")
				{
					model.sub_id=int.Parse(row["sub_id"].ToString());
				}
				if(row["sub_code"]!=null)
				{
					model.sub_code=row["sub_code"].ToString();
				}
				if(row["sub_name"]!=null)
				{
					model.sub_name=row["sub_name"].ToString();
				}
				if(row["sub_date"]!=null && row["sub_date"].ToString()!="")
				{
					model.sub_date=DateTime.Parse(row["sub_date"].ToString());
				}
				if(row["status"]!=null && row["status"].ToString()!="")
				{
					model.status=int.Parse(row["status"].ToString());
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
			strSql.Append("select id,tax_code,new_tax_code,id_list,check_id,check_code,check_name,check_date,sub_id,sub_code,sub_name,sub_date,status ");
			strSql.Append(" FROM crm_contact_bill_check ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select id,tax_code,new_tax_code,id_list,check_id,check_code,check_name,check_date,sub_id,sub_code,sub_name,sub_date,status ");
            strSql.Append(" FROM crm_contact_bill_check ");
            strSql1.Append(" select count(id) FROM crm_contact_bill_check ");
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
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM crm_contact_bill_check ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = DbHelperMySQL.GetSingle(strSql.ToString());
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
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from crm_contact_bill_check T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "crm_contact_bill_check";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

