/**  版本信息模板在安装目录下，可自行修改。
* shop_member_level.cs
*
* 功 能： N/A
* 类 名： shop_member_level
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/20 11:00:38   N/A    初版
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
	/// 数据访问类:shop_member_level
	/// </summary>
	public partial class shop_member_level
	{
		public shop_member_level()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return Shop_DbHelperMySQL.GetMaxID("level_id", "shop_member_level"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int level_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from shop_member_level");
			strSql.Append(" where level_id=@level_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@level_id", MySqlDbType.Int32,11)			};
			parameters[0].Value = level_id;

			return Shop_DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.shop_member_level model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shop_member_level(");
			strSql.Append("level_id,level_name,level_external,level_proportion,priority_lag,level_type)");
			strSql.Append(" values (");
			strSql.Append("@level_id,@level_name,@level_external,@level_proportion,@priority_lag,@level_type)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@level_id", MySqlDbType.Int32,11),
					new MySqlParameter("@level_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@level_external", MySqlDbType.Int32,4),
					new MySqlParameter("@level_proportion", MySqlDbType.Decimal,5),
					new MySqlParameter("@priority_lag", MySqlDbType.Int32,4),
					new MySqlParameter("@level_type", MySqlDbType.Int32,1)};
			parameters[0].Value = model.level_id;
			parameters[1].Value = model.level_name;
			parameters[2].Value = model.level_external;
			parameters[3].Value = model.level_proportion;
			parameters[4].Value = model.priority_lag;
			parameters[5].Value = model.level_type;

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
		public bool Update(XHD.Model.shop_member_level model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shop_member_level set ");
			strSql.Append("level_name=@level_name,");
			strSql.Append("level_external=@level_external,");
			strSql.Append("level_proportion=@level_proportion,");
			strSql.Append("priority_lag=@priority_lag,");
			strSql.Append("level_type=@level_type");
			strSql.Append(" where level_id=@level_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@level_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@level_external", MySqlDbType.Int32,4),
					new MySqlParameter("@level_proportion", MySqlDbType.Decimal,5),
					new MySqlParameter("@priority_lag", MySqlDbType.Int32,4),
					new MySqlParameter("@level_type", MySqlDbType.Int32,1),
					new MySqlParameter("@level_id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.level_name;
			parameters[1].Value = model.level_external;
			parameters[2].Value = model.level_proportion;
			parameters[3].Value = model.priority_lag;
			parameters[4].Value = model.level_type;
			parameters[5].Value = model.level_id;

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
		public bool Delete(int level_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shop_member_level ");
			strSql.Append(" where level_id=@level_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@level_id", MySqlDbType.Int32,11)			};
			parameters[0].Value = level_id;

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
		public bool DeleteList(string level_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shop_member_level ");
			strSql.Append(" where level_id in ("+level_idlist + ")  ");
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
		public XHD.Model.shop_member_level GetModel(int level_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select level_id,level_name,level_external,level_proportion,priority_lag,level_type from shop_member_level ");
			strSql.Append(" where level_id=@level_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@level_id", MySqlDbType.Int32,11)			};
			parameters[0].Value = level_id;

			XHD.Model.shop_member_level model=new XHD.Model.shop_member_level();
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
		public XHD.Model.shop_member_level DataRowToModel(DataRow row)
		{
			XHD.Model.shop_member_level model=new XHD.Model.shop_member_level();
			if (row != null)
			{
				if(row["level_id"]!=null && row["level_id"].ToString()!="")
				{
					model.level_id=int.Parse(row["level_id"].ToString());
				}
				if(row["level_name"]!=null)
				{
					model.level_name=row["level_name"].ToString();
				}
				if(row["level_external"]!=null && row["level_external"].ToString()!="")
				{
					model.level_external=int.Parse(row["level_external"].ToString());
				}
				if(row["level_proportion"]!=null && row["level_proportion"].ToString()!="")
				{
					model.level_proportion=decimal.Parse(row["level_proportion"].ToString());
				}
				if(row["priority_lag"]!=null && row["priority_lag"].ToString()!="")
				{
					model.priority_lag=int.Parse(row["priority_lag"].ToString());
				}
				if(row["level_type"]!=null && row["level_type"].ToString()!="")
				{
					model.level_type=int.Parse(row["level_type"].ToString());
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
			strSql.Append("select level_id,level_name,level_external,level_proportion,priority_lag,level_type ");
			strSql.Append(" FROM shop_member_level ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return Shop_DbHelperMySQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select level_id,level_name,level_external,level_proportion,priority_lag,level_type ");
            strSql.Append(" FROM shop_member_level ");
            strSql1.Append(" select count(1) FROM shop_member_level ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = Shop_DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM shop_member_level ");
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
				strSql.Append("order by T.level_id desc");
			}
			strSql.Append(")AS Row, T.*  from shop_member_level T ");
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
			parameters[0].Value = "shop_member_level";
			parameters[1].Value = "level_id";
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

