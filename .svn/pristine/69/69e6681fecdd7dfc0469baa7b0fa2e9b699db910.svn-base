/**  版本信息模板在安装目录下，可自行修改。
* hr_group_info.cs
*
* 功 能： N/A
* 类 名： hr_group_info
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/30 16:11:12   N/A    初版
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
	/// 数据访问类:hr_group_info
	/// </summary>
	public partial class hr_group_info
	{
		public hr_group_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "hr_group_info"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hr_group_info");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.hr_group_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hr_group_info(");
			strSql.Append("Id,Group_Code,Group_Name,Group_CreatDate,Group_UserId,Gropu_Address)");
			strSql.Append(" values (");
			strSql.Append("@Id,@Group_Code,@Group_Name,@Group_CreatDate,@Group_UserId,@Gropu_Address)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Group_Code", MySqlDbType.VarChar,10),
					new MySqlParameter("@Group_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@Group_CreatDate", MySqlDbType.DateTime),
					new MySqlParameter("@Group_UserId", MySqlDbType.VarChar,10),
					new MySqlParameter("@Gropu_Address", MySqlDbType.VarChar,100)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Group_Code;
			parameters[2].Value = model.Group_Name;
			parameters[3].Value = model.Group_CreatDate;
			parameters[4].Value = model.Group_UserId;
			parameters[5].Value = model.Gropu_Address;

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
		public bool Update(XHD.Model.hr_group_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hr_group_info set ");
			strSql.Append("Group_Code=@Group_Code,");
			strSql.Append("Group_Name=@Group_Name,");
			strSql.Append("Group_CreatDate=@Group_CreatDate,");
			strSql.Append("Group_UserId=@Group_UserId,");
			strSql.Append("Gropu_Address=@Gropu_Address");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Group_Code", MySqlDbType.VarChar,10),
					new MySqlParameter("@Group_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@Group_CreatDate", MySqlDbType.DateTime),
					new MySqlParameter("@Group_UserId", MySqlDbType.VarChar,10),
					new MySqlParameter("@Gropu_Address", MySqlDbType.VarChar,100),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.Group_Code;
			parameters[1].Value = model.Group_Name;
			parameters[2].Value = model.Group_CreatDate;
			parameters[3].Value = model.Group_UserId;
			parameters[4].Value = model.Gropu_Address;
			parameters[5].Value = model.Id;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hr_group_info ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hr_group_info ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public XHD.Model.hr_group_info GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Group_Code,Group_Name,Group_CreatDate,Group_UserId,Gropu_Address from hr_group_info ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

			XHD.Model.hr_group_info model=new XHD.Model.hr_group_info();
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
		public XHD.Model.hr_group_info DataRowToModel(DataRow row)
		{
			XHD.Model.hr_group_info model=new XHD.Model.hr_group_info();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Group_Code"]!=null)
				{
					model.Group_Code=row["Group_Code"].ToString();
				}
				if(row["Group_Name"]!=null)
				{
					model.Group_Name=row["Group_Name"].ToString();
				}
				if(row["Group_CreatDate"]!=null && row["Group_CreatDate"].ToString()!="")
				{
					model.Group_CreatDate=DateTime.Parse(row["Group_CreatDate"].ToString());
				}
				if(row["Group_UserId"]!=null)
				{
					model.Group_UserId=row["Group_UserId"].ToString();
				}
				if(row["Gropu_Address"]!=null)
				{
					model.Gropu_Address=row["Gropu_Address"].ToString();
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
			strSql.Append("select Id,Group_Code,Group_Name,Group_CreatDate,Group_UserId,Gropu_Address ");
			strSql.Append(" FROM hr_group_info ");
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
			strSql.Append("select count(1) FROM hr_group_info ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from hr_group_info T ");
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
			parameters[0].Value = "hr_group_info";
			parameters[1].Value = "Id";
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

