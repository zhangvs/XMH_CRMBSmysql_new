/**  版本信息模板在安装目录下，可自行修改。
* shop_payment_attr.cs
*
* 功 能： N/A
* 类 名： shop_payment_attr
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/20 14:04:47   N/A    初版
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
	/// 数据访问类:shop_payment_attr
	/// </summary>
	public partial class shop_payment_attr
	{
		public shop_payment_attr()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return Shop_DbHelperMySQL.GetMaxID("attr_id", "shop_payment_attr"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int attr_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from shop_payment_attr");
			strSql.Append(" where attr_id=@attr_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@attr_id", MySqlDbType.Int32,11)			};
			parameters[0].Value = attr_id;

			return Shop_DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.shop_payment_attr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shop_payment_attr(");
			strSql.Append("attr_id,pay_id,attr_key,attr_values,input_type)");
			strSql.Append(" values (");
			strSql.Append("@attr_id,@pay_id,@attr_key,@attr_values,@input_type)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@attr_id", MySqlDbType.Int32,11),
					new MySqlParameter("@pay_id", MySqlDbType.Int32,11),
					new MySqlParameter("@attr_key", MySqlDbType.VarChar,30),
					new MySqlParameter("@attr_values", MySqlDbType.VarChar,100),
					new MySqlParameter("@input_type", MySqlDbType.VarChar,30)};
			parameters[0].Value = model.attr_id;
			parameters[1].Value = model.pay_id;
			parameters[2].Value = model.attr_key;
			parameters[3].Value = model.attr_values;
			parameters[4].Value = model.input_type;

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
		public bool Update(XHD.Model.shop_payment_attr model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shop_payment_attr set ");
			strSql.Append("pay_id=@pay_id,");
			strSql.Append("attr_key=@attr_key,");
			strSql.Append("attr_values=@attr_values,");
			strSql.Append("input_type=@input_type");
			strSql.Append(" where attr_id=@attr_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@pay_id", MySqlDbType.Int32,11),
					new MySqlParameter("@attr_key", MySqlDbType.VarChar,30),
					new MySqlParameter("@attr_values", MySqlDbType.VarChar,100),
					new MySqlParameter("@input_type", MySqlDbType.VarChar,30),
					new MySqlParameter("@attr_id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.pay_id;
			parameters[1].Value = model.attr_key;
			parameters[2].Value = model.attr_values;
			parameters[3].Value = model.input_type;
			parameters[4].Value = model.attr_id;

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
		public bool Delete(int attr_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shop_payment_attr ");
			strSql.Append(" where attr_id=@attr_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@attr_id", MySqlDbType.Int32,11)			};
			parameters[0].Value = attr_id;

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
		public bool DeleteList(string attr_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shop_payment_attr ");
			strSql.Append(" where attr_id in ("+attr_idlist + ")  ");
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
		public XHD.Model.shop_payment_attr GetModel(int attr_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select attr_id,pay_id,attr_key,attr_values,input_type from shop_payment_attr ");
			strSql.Append(" where attr_id=@attr_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@attr_id", MySqlDbType.Int32,11)			};
			parameters[0].Value = attr_id;

			XHD.Model.shop_payment_attr model=new XHD.Model.shop_payment_attr();
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
		public XHD.Model.shop_payment_attr DataRowToModel(DataRow row)
		{
			XHD.Model.shop_payment_attr model=new XHD.Model.shop_payment_attr();
			if (row != null)
			{
				if(row["attr_id"]!=null && row["attr_id"].ToString()!="")
				{
					model.attr_id=int.Parse(row["attr_id"].ToString());
				}
				if(row["pay_id"]!=null && row["pay_id"].ToString()!="")
				{
					model.pay_id=int.Parse(row["pay_id"].ToString());
				}
				if(row["attr_key"]!=null)
				{
					model.attr_key=row["attr_key"].ToString();
				}
				if(row["attr_values"]!=null)
				{
					model.attr_values=row["attr_values"].ToString();
				}
				if(row["input_type"]!=null)
				{
					model.input_type=row["input_type"].ToString();
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
			strSql.Append("select attr_id,pay_id,attr_key,attr_values,input_type ");
			strSql.Append(" FROM shop_payment_attr ");
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
			strSql.Append("select count(1) FROM shop_payment_attr ");
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
				strSql.Append("order by T.attr_id desc");
			}
			strSql.Append(")AS Row, T.*  from shop_payment_attr T ");
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
			parameters[0].Value = "shop_payment_attr";
			parameters[1].Value = "attr_id";
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

