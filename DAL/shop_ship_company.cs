/**  版本信息模板在安装目录下，可自行修改。
* shop_ship_company.cs
*
* 功 能： N/A
* 类 名： shop_ship_company
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/20 12:03:43   N/A    初版
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
	/// 数据访问类:shop_ship_company
	/// </summary>
	public partial class shop_ship_company
	{
		public shop_ship_company()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return Shop_DbHelperMySQL.GetMaxID("comp_id", "shop_ship_company"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int comp_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from shop_ship_company");
			strSql.Append(" where comp_id=@comp_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comp_id", MySqlDbType.Int32,5)			};
			parameters[0].Value = comp_id;

			return Shop_DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.shop_ship_company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shop_ship_company(");
			strSql.Append("comp_id,comp_name,comp_type,comp_code,comp_tel,comp_address,comp_desc,is_available,send_pay)");
			strSql.Append(" values (");
			strSql.Append("@comp_id,@comp_name,@comp_type,@comp_code,@comp_tel,@comp_address,@comp_desc,@is_available,@send_pay)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comp_id", MySqlDbType.Int32,5),
					new MySqlParameter("@comp_name", MySqlDbType.VarChar,200),
					new MySqlParameter("@comp_type", MySqlDbType.Int32,1),
					new MySqlParameter("@comp_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@comp_tel", MySqlDbType.VarChar,20),
					new MySqlParameter("@comp_address", MySqlDbType.VarChar,255),
					new MySqlParameter("@comp_desc", MySqlDbType.Text),
					new MySqlParameter("@is_available", MySqlDbType.Int32,1),
					new MySqlParameter("@send_pay", MySqlDbType.Int32,1)};
			parameters[0].Value = model.comp_id;
			parameters[1].Value = model.comp_name;
			parameters[2].Value = model.comp_type;
			parameters[3].Value = model.comp_code;
			parameters[4].Value = model.comp_tel;
			parameters[5].Value = model.comp_address;
			parameters[6].Value = model.comp_desc;
			parameters[7].Value = model.is_available;
			parameters[8].Value = model.send_pay;

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
		public bool Update(XHD.Model.shop_ship_company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shop_ship_company set ");
			strSql.Append("comp_name=@comp_name,");
			strSql.Append("comp_type=@comp_type,");
			strSql.Append("comp_code=@comp_code,");
			strSql.Append("comp_tel=@comp_tel,");
			strSql.Append("comp_address=@comp_address,");
			strSql.Append("comp_desc=@comp_desc,");
			strSql.Append("is_available=@is_available,");
			strSql.Append("send_pay=@send_pay");
			strSql.Append(" where comp_id=@comp_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comp_name", MySqlDbType.VarChar,200),
					new MySqlParameter("@comp_type", MySqlDbType.Int32,1),
					new MySqlParameter("@comp_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@comp_tel", MySqlDbType.VarChar,20),
					new MySqlParameter("@comp_address", MySqlDbType.VarChar,255),
					new MySqlParameter("@comp_desc", MySqlDbType.Text),
					new MySqlParameter("@is_available", MySqlDbType.Int32,1),
					new MySqlParameter("@send_pay", MySqlDbType.Int32,1),
					new MySqlParameter("@comp_id", MySqlDbType.Int32,5)};
			parameters[0].Value = model.comp_name;
			parameters[1].Value = model.comp_type;
			parameters[2].Value = model.comp_code;
			parameters[3].Value = model.comp_tel;
			parameters[4].Value = model.comp_address;
			parameters[5].Value = model.comp_desc;
			parameters[6].Value = model.is_available;
			parameters[7].Value = model.send_pay;
			parameters[8].Value = model.comp_id;

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
		public bool Delete(int comp_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shop_ship_company ");
			strSql.Append(" where comp_id=@comp_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comp_id", MySqlDbType.Int32,5)			};
			parameters[0].Value = comp_id;

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
		public bool DeleteList(string comp_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shop_ship_company ");
			strSql.Append(" where comp_id in ("+comp_idlist + ")  ");
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
		public XHD.Model.shop_ship_company GetModel(int comp_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select comp_id,comp_name,comp_type,comp_code,comp_tel,comp_address,comp_desc,is_available,send_pay from shop_ship_company ");
			strSql.Append(" where comp_id=@comp_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@comp_id", MySqlDbType.Int32,5)			};
			parameters[0].Value = comp_id;

			XHD.Model.shop_ship_company model=new XHD.Model.shop_ship_company();
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
		public XHD.Model.shop_ship_company DataRowToModel(DataRow row)
		{
			XHD.Model.shop_ship_company model=new XHD.Model.shop_ship_company();
			if (row != null)
			{
				if(row["comp_id"]!=null && row["comp_id"].ToString()!="")
				{
					model.comp_id=int.Parse(row["comp_id"].ToString());
				}
				if(row["comp_name"]!=null)
				{
					model.comp_name=row["comp_name"].ToString();
				}
				if(row["comp_type"]!=null && row["comp_type"].ToString()!="")
				{
					model.comp_type=int.Parse(row["comp_type"].ToString());
				}
				if(row["comp_code"]!=null)
				{
					model.comp_code=row["comp_code"].ToString();
				}
				if(row["comp_tel"]!=null)
				{
					model.comp_tel=row["comp_tel"].ToString();
				}
				if(row["comp_address"]!=null)
				{
					model.comp_address=row["comp_address"].ToString();
				}
				if(row["comp_desc"]!=null)
				{
					model.comp_desc=row["comp_desc"].ToString();
				}
				if(row["is_available"]!=null && row["is_available"].ToString()!="")
				{
					model.is_available=int.Parse(row["is_available"].ToString());
				}
				if(row["send_pay"]!=null && row["send_pay"].ToString()!="")
				{
					model.send_pay=int.Parse(row["send_pay"].ToString());
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
			strSql.Append("select comp_id,comp_name,comp_type,comp_code,comp_tel,comp_address,comp_desc,is_available,send_pay ");
			strSql.Append(" FROM shop_ship_company ");
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
			strSql.Append("select count(1) FROM shop_ship_company ");
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
				strSql.Append("order by T.comp_id desc");
			}
			strSql.Append(")AS Row, T.*  from shop_ship_company T ");
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
			parameters[0].Value = "shop_ship_company";
			parameters[1].Value = "comp_id";
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

