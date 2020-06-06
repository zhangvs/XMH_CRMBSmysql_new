/**  版本信息模板在安装目录下，可自行修改。
* shop_purchase_log.cs
*
* 功 能： N/A
* 类 名： shop_purchase_log
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/2 14:55:00   N/A    初版
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
	/// 数据访问类:shop_purchase_log
	/// </summary>
	public partial class shop_purchase_log
	{
		public shop_purchase_log()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return Shop_DbHelperMySQL.GetMaxID("aid", "shop_purchase_log"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int aid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from shop_purchase_log");
			strSql.Append(" where aid=@aid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@aid", MySqlDbType.Int32,11)			};
			parameters[0].Value = aid;

			return Shop_DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.shop_purchase_log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shop_purchase_log(");
			strSql.Append("aid,oid,gid,p_status,username,action_info,action_time)");
			strSql.Append(" values (");
			strSql.Append("@aid,@oid,@gid,@p_status,@username,@action_info,@action_time)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@aid", MySqlDbType.Int32,11),
					new MySqlParameter("@oid", MySqlDbType.Int32,11),
					new MySqlParameter("@gid", MySqlDbType.Int32,11),
					new MySqlParameter("@p_status", MySqlDbType.Int32,2),
					new MySqlParameter("@username", MySqlDbType.VarChar,10),
					new MySqlParameter("@action_info", MySqlDbType.Text),
					new MySqlParameter("@action_time", MySqlDbType.Int32,11)};
			parameters[0].Value = model.aid;
			parameters[1].Value = model.oid;
			parameters[2].Value = model.gid;
			parameters[3].Value = model.p_status;
			parameters[4].Value = model.username;
			parameters[5].Value = model.action_info;
			parameters[6].Value = model.action_time;

			int rows=Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(XHD.Model.shop_purchase_log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shop_purchase_log set ");
			strSql.Append("oid=@oid,");
			strSql.Append("gid=@gid,");
			strSql.Append("p_status=@p_status,");
			strSql.Append("username=@username,");
			strSql.Append("action_info=@action_info,");
			strSql.Append("action_time=@action_time");
			strSql.Append(" where aid=@aid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@oid", MySqlDbType.Int32,11),
					new MySqlParameter("@gid", MySqlDbType.Int32,11),
					new MySqlParameter("@p_status", MySqlDbType.Int32,2),
					new MySqlParameter("@username", MySqlDbType.VarChar,10),
					new MySqlParameter("@action_info", MySqlDbType.Text),
					new MySqlParameter("@action_time", MySqlDbType.Int32,11),
					new MySqlParameter("@aid", MySqlDbType.Int32,11)};
			parameters[0].Value = model.oid;
			parameters[1].Value = model.gid;
			parameters[2].Value = model.p_status;
			parameters[3].Value = model.username;
			parameters[4].Value = model.action_info;
			parameters[5].Value = model.action_time;
			parameters[6].Value = model.aid;

			int rows=Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int aid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shop_purchase_log ");
			strSql.Append(" where aid=@aid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@aid", MySqlDbType.Int32,11)			};
			parameters[0].Value = aid;

			int rows=Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string aidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shop_purchase_log ");
			strSql.Append(" where aid in ("+aidlist + ")  ");
			int rows=Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public XHD.Model.shop_purchase_log GetModel(int aid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select aid,oid,gid,p_status,username,action_info,action_time from shop_purchase_log ");
			strSql.Append(" where aid=@aid ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@aid", MySqlDbType.Int32,11)			};
			parameters[0].Value = aid;

			XHD.Model.shop_purchase_log model=new XHD.Model.shop_purchase_log();
			DataSet ds=Shop_DbHelperMySQL.Query(strSql.ToString(),parameters);
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
		public XHD.Model.shop_purchase_log DataRowToModel(DataRow row)
		{
			XHD.Model.shop_purchase_log model=new XHD.Model.shop_purchase_log();
			if (row != null)
			{
				if(row["aid"]!=null && row["aid"].ToString()!="")
				{
					model.aid=int.Parse(row["aid"].ToString());
				}
				if(row["oid"]!=null && row["oid"].ToString()!="")
				{
					model.oid=int.Parse(row["oid"].ToString());
				}
				if(row["gid"]!=null && row["gid"].ToString()!="")
				{
					model.gid=int.Parse(row["gid"].ToString());
				}
				if(row["p_status"]!=null && row["p_status"].ToString()!="")
				{
					model.p_status=int.Parse(row["p_status"].ToString());
				}
				if(row["username"]!=null)
				{
					model.username=row["username"].ToString();
				}
				if(row["action_info"]!=null)
				{
					model.action_info=row["action_info"].ToString();
				}
				if(row["action_time"]!=null && row["action_time"].ToString()!="")
				{
					model.action_time=int.Parse(row["action_time"].ToString());
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
			strSql.Append("select aid,oid,gid,p_status,username,action_info,action_time ");
			strSql.Append(" FROM shop_purchase_log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return Shop_DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM shop_purchase_log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.aid desc");
			}
			strSql.Append(")AS Row, T.*  from shop_purchase_log T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return Shop_DbHelperMySQL.Query(strSql.ToString());
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
			parameters[0].Value = "shop_purchase_log";
			parameters[1].Value = "aid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return Shop_DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

