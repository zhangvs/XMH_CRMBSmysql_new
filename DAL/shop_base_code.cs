/**  版本信息模板在安装目录下，可自行修改。
* shop_base_code.cs
*
* 功 能： N/A
* 类 名： shop_base_code
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/20 16:12:28   N/A    初版
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
	/// 数据访问类:shop_base_code
	/// </summary>
	public partial class shop_base_code
	{
		public shop_base_code()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string type_no,string code_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from shop_base_code");
			strSql.Append(" where type_no=@type_no and code_id=@code_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_no", MySqlDbType.VarChar,2),
					new MySqlParameter("@code_id", MySqlDbType.VarChar,30)			};
			parameters[0].Value = type_no;
			parameters[1].Value = code_id;

			return Shop_DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.shop_base_code model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shop_base_code(");
			strSql.Append("type_no,code_id,code_name,english_name,is_display,code_type,memo)");
			strSql.Append(" values (");
			strSql.Append("@type_no,@code_id,@code_name,@english_name,@is_display,@code_type,@memo)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_no", MySqlDbType.VarChar,2),
					new MySqlParameter("@code_id", MySqlDbType.VarChar,30),
					new MySqlParameter("@code_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@english_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@is_display", MySqlDbType.Int32,4),
					new MySqlParameter("@code_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@memo", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.type_no;
			parameters[1].Value = model.code_id;
			parameters[2].Value = model.code_name;
			parameters[3].Value = model.english_name;
			parameters[4].Value = model.is_display;
			parameters[5].Value = model.code_type;
			parameters[6].Value = model.memo;

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
		public bool Update(XHD.Model.shop_base_code model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shop_base_code set ");
			strSql.Append("code_name=@code_name,");
			strSql.Append("english_name=@english_name,");
			strSql.Append("is_display=@is_display,");
			strSql.Append("code_type=@code_type,");
			strSql.Append("memo=@memo");
			strSql.Append(" where type_no=@type_no and code_id=@code_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@code_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@english_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@is_display", MySqlDbType.Int32,4),
					new MySqlParameter("@code_type", MySqlDbType.VarChar,20),
					new MySqlParameter("@memo", MySqlDbType.VarChar,255),
					new MySqlParameter("@type_no", MySqlDbType.VarChar,2),
					new MySqlParameter("@code_id", MySqlDbType.VarChar,30)};
			parameters[0].Value = model.code_name;
			parameters[1].Value = model.english_name;
			parameters[2].Value = model.is_display;
			parameters[3].Value = model.code_type;
			parameters[4].Value = model.memo;
			parameters[5].Value = model.type_no;
			parameters[6].Value = model.code_id;

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
		public bool Delete(string type_no,string code_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shop_base_code ");
			strSql.Append(" where type_no=@type_no and code_id=@code_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_no", MySqlDbType.VarChar,2),
					new MySqlParameter("@code_id", MySqlDbType.VarChar,30)			};
			parameters[0].Value = type_no;
			parameters[1].Value = code_id;

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
		/// 得到一个对象实体
		/// </summary>
		public XHD.Model.shop_base_code GetModel(string type_no,string code_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select type_no,code_id,code_name,english_name,is_display,code_type,memo from shop_base_code ");
			strSql.Append(" where type_no=@type_no and code_id=@code_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@type_no", MySqlDbType.VarChar,2),
					new MySqlParameter("@code_id", MySqlDbType.VarChar,30)			};
			parameters[0].Value = type_no;
			parameters[1].Value = code_id;

			XHD.Model.shop_base_code model=new XHD.Model.shop_base_code();
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
		public XHD.Model.shop_base_code DataRowToModel(DataRow row)
		{
			XHD.Model.shop_base_code model=new XHD.Model.shop_base_code();
			if (row != null)
			{
				if(row["type_no"]!=null)
				{
					model.type_no=row["type_no"].ToString();
				}
				if(row["code_id"]!=null)
				{
					model.code_id=row["code_id"].ToString();
				}
				if(row["code_name"]!=null)
				{
					model.code_name=row["code_name"].ToString();
				}
				if(row["english_name"]!=null)
				{
					model.english_name=row["english_name"].ToString();
				}
				if(row["is_display"]!=null && row["is_display"].ToString()!="")
				{
					model.is_display=int.Parse(row["is_display"].ToString());
				}
				if(row["code_type"]!=null)
				{
					model.code_type=row["code_type"].ToString();
				}
				if(row["memo"]!=null)
				{
					model.memo=row["memo"].ToString();
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
			strSql.Append("select type_no,code_id,code_name,english_name,is_display,code_type,memo ");
			strSql.Append(" FROM shop_base_code ");
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
			strSql.Append("select count(1) FROM shop_base_code ");
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
				strSql.Append("order by T.code_id desc");
			}
			strSql.Append(")AS Row, T.*  from shop_base_code T ");
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
			parameters[0].Value = "shop_base_code";
			parameters[1].Value = "code_id";
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

