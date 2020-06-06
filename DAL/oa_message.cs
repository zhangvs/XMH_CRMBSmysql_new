/**  版本信息模板在安装目录下，可自行修改。
* oa_message.cs
*
* 功 能： N/A
* 类 名： oa_message
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/26 11:14:46   N/A    初版
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
	/// 数据访问类:oa_message
	/// </summary>
	public partial class oa_message
	{
		public oa_message()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "oa_message"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from oa_message");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.oa_message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into oa_message(");
            strSql.Append("id,receive_id,msg_title,msg_content,msg_status,redirect_url,create_man,create_time,tab_id,sys_shorthand)");
			strSql.Append(" values (");
            strSql.Append("@id,@receive_id,@msg_title,@msg_content,@msg_status,@redirect_url,@create_man,@create_time,@tab_id,@sys_shorthand)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@receive_id", MySqlDbType.Int32,11),
					new MySqlParameter("@msg_title", MySqlDbType.VarChar,50),
					new MySqlParameter("@msg_content", MySqlDbType.VarChar,800),
					new MySqlParameter("@msg_status", MySqlDbType.Int32,11),
					new MySqlParameter("@redirect_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@create_man", MySqlDbType.VarChar,50),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@tab_id", MySqlDbType.VarChar,50),
                    new MySqlParameter("@sys_shorthand", MySqlDbType.VarChar,20)                                          };
			parameters[0].Value = model.id;
			parameters[1].Value = model.receive_id;
			parameters[2].Value = model.msg_title;
			parameters[3].Value = model.msg_content;
			parameters[4].Value = model.msg_status;
			parameters[5].Value = model.redirect_url;
			parameters[6].Value = model.create_man;
			parameters[7].Value = model.create_time;
			parameters[8].Value = model.tab_id;
            parameters[9].Value = model.sys_shorthand;

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
		public bool Update(XHD.Model.oa_message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update oa_message set ");
			strSql.Append("receive_id=@receive_id,");
			strSql.Append("msg_title=@msg_title,");
			strSql.Append("msg_content=@msg_content,");
			strSql.Append("msg_status=@msg_status,");
			strSql.Append("redirect_url=@redirect_url,");
			strSql.Append("create_man=@create_man,");
			strSql.Append("create_time=@create_time,");
			strSql.Append("tab_id=@tab_id");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@receive_id", MySqlDbType.Int32,11),
					new MySqlParameter("@msg_title", MySqlDbType.VarChar,50),
					new MySqlParameter("@msg_content", MySqlDbType.VarChar,800),
					new MySqlParameter("@msg_status", MySqlDbType.Int32,11),
					new MySqlParameter("@redirect_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@create_man", MySqlDbType.VarChar,50),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@tab_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.receive_id;
			parameters[1].Value = model.msg_title;
			parameters[2].Value = model.msg_content;
			parameters[3].Value = model.msg_status;
			parameters[4].Value = model.redirect_url;
			parameters[5].Value = model.create_man;
			parameters[6].Value = model.create_time;
			parameters[7].Value = model.tab_id;
			parameters[8].Value = model.id;

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
			strSql.Append("delete from oa_message ");
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
			strSql.Append("delete from oa_message ");
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
		public XHD.Model.oa_message GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,receive_id,msg_title,msg_content,msg_status,redirect_url,create_man,create_time,tab_id from oa_message ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
			parameters[0].Value = id;

			XHD.Model.oa_message model=new XHD.Model.oa_message();
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
		public XHD.Model.oa_message DataRowToModel(DataRow row)
		{
			XHD.Model.oa_message model=new XHD.Model.oa_message();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["receive_id"]!=null && row["receive_id"].ToString()!="")
				{
					model.receive_id=int.Parse(row["receive_id"].ToString());
				}
				if(row["msg_title"]!=null)
				{
					model.msg_title=row["msg_title"].ToString();
				}
				if(row["msg_content"]!=null)
				{
					model.msg_content=row["msg_content"].ToString();
				}
				if(row["msg_status"]!=null && row["msg_status"].ToString()!="")
				{
					model.msg_status=int.Parse(row["msg_status"].ToString());
				}
				if(row["redirect_url"]!=null)
				{
					model.redirect_url=row["redirect_url"].ToString();
				}
				if(row["create_man"]!=null)
				{
					model.create_man=row["create_man"].ToString();
				}
				if(row["create_time"]!=null && row["create_time"].ToString()!="")
				{
					model.create_time=DateTime.Parse(row["create_time"].ToString());
				}
				if(row["tab_id"]!=null)
				{
					model.tab_id=row["tab_id"].ToString();
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
			strSql.Append("select id,receive_id,msg_title,msg_content,msg_status,redirect_url,create_man,create_time,tab_id ");
			strSql.Append(" FROM oa_message ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM oa_message ");
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
			strSql.Append(")AS Row, T.*  from oa_message T ");
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
			parameters[0].Value = "oa_message";
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

