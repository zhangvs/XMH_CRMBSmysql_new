/**  版本信息模板在安装目录下，可自行修改。
* crm_shop_askprice.cs
*
* 功 能： N/A
* 类 名： crm_shop_askprice
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 15:54:01   N/A    初版
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
	/// 数据访问类:crm_shop_askprice
	/// </summary>
	public partial class crm_shop_askprice
	{
		public crm_shop_askprice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "crm_shop_askprice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from crm_shop_askprice");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.crm_shop_askprice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into crm_shop_askprice(");
			strSql.Append("Id,askprice_content,user_id,user_uid,user_name,user_askprice_date,BeSeats_id,BeSeats_empcode,BeSeats,ishandle,handle_remark,handle_person_id,handle_person_name,handle_date)");
			strSql.Append(" values (");
			strSql.Append("@Id,@askprice_content,@user_id,@user_uid,@user_name,@user_askprice_date,@BeSeats_id,@BeSeats_empcode,@BeSeats,@ishandle,@handle_remark,@handle_person_id,@handle_person_name,@handle_date)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@askprice_content", MySqlDbType.Text),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_uid", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_askprice_date", MySqlDbType.DateTime),
					new MySqlParameter("@BeSeats_id", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_empcode", MySqlDbType.VarChar,100),
					new MySqlParameter("@BeSeats", MySqlDbType.VarChar,250),
					new MySqlParameter("@ishandle", MySqlDbType.Int16,2),
					new MySqlParameter("@handle_remark", MySqlDbType.VarChar,255),
					new MySqlParameter("@handle_person_id", MySqlDbType.Int32,11),
					new MySqlParameter("@handle_person_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@handle_date", MySqlDbType.DateTime)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.askprice_content;
			parameters[2].Value = model.user_id;
			parameters[3].Value = model.user_uid;
			parameters[4].Value = model.user_name;
			parameters[5].Value = model.user_askprice_date;
			parameters[6].Value = model.BeSeats_id;
			parameters[7].Value = model.BeSeats_empcode;
			parameters[8].Value = model.BeSeats;
			parameters[9].Value = model.ishandle;
			parameters[10].Value = model.handle_remark;
			parameters[11].Value = model.handle_person_id;
			parameters[12].Value = model.handle_person_name;
			parameters[13].Value = model.handle_date;

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
		public bool Update(XHD.Model.crm_shop_askprice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update crm_shop_askprice set ");
			strSql.Append("askprice_content=@askprice_content,");
			strSql.Append("user_id=@user_id,");
			strSql.Append("user_uid=@user_uid,");
			strSql.Append("user_name=@user_name,");
			strSql.Append("user_askprice_date=@user_askprice_date,");
			strSql.Append("BeSeats_id=@BeSeats_id,");
			strSql.Append("BeSeats_empcode=@BeSeats_empcode,");
			strSql.Append("BeSeats=@BeSeats,");
			strSql.Append("ishandle=@ishandle,");
			strSql.Append("handle_remark=@handle_remark,");
			strSql.Append("handle_person_id=@handle_person_id,");
			strSql.Append("handle_person_name=@handle_person_name,");
			strSql.Append("handle_date=@handle_date");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@askprice_content", MySqlDbType.Text),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_uid", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_askprice_date", MySqlDbType.DateTime),
					new MySqlParameter("@BeSeats_id", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_empcode", MySqlDbType.VarChar,100),
					new MySqlParameter("@BeSeats", MySqlDbType.VarChar,250),
					new MySqlParameter("@ishandle", MySqlDbType.Int16,2),
					new MySqlParameter("@handle_remark", MySqlDbType.VarChar,255),
					new MySqlParameter("@handle_person_id", MySqlDbType.Int32,11),
					new MySqlParameter("@handle_person_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@handle_date", MySqlDbType.DateTime),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.askprice_content;
			parameters[1].Value = model.user_id;
			parameters[2].Value = model.user_uid;
			parameters[3].Value = model.user_name;
			parameters[4].Value = model.user_askprice_date;
			parameters[5].Value = model.BeSeats_id;
			parameters[6].Value = model.BeSeats_empcode;
			parameters[7].Value = model.BeSeats;
			parameters[8].Value = model.ishandle;
			parameters[9].Value = model.handle_remark;
			parameters[10].Value = model.handle_person_id;
			parameters[11].Value = model.handle_person_name;
			parameters[12].Value = model.handle_date;
			parameters[13].Value = model.Id;

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
			strSql.Append("delete from crm_shop_askprice ");
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
			strSql.Append("delete from crm_shop_askprice ");
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
		public XHD.Model.crm_shop_askprice GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,askprice_content,user_id,user_uid,user_name,user_askprice_date,BeSeats_id,BeSeats_empcode,BeSeats,ishandle,handle_remark,handle_person_id,handle_person_name,handle_date from crm_shop_askprice ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

			XHD.Model.crm_shop_askprice model=new XHD.Model.crm_shop_askprice();
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
		public XHD.Model.crm_shop_askprice DataRowToModel(DataRow row)
		{
			XHD.Model.crm_shop_askprice model=new XHD.Model.crm_shop_askprice();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["askprice_content"]!=null)
				{
					model.askprice_content=row["askprice_content"].ToString();
				}
				if(row["user_id"]!=null && row["user_id"].ToString()!="")
				{
					model.user_id=int.Parse(row["user_id"].ToString());
				}
				if(row["user_uid"]!=null)
				{
					model.user_uid=row["user_uid"].ToString();
				}
				if(row["user_name"]!=null)
				{
					model.user_name=row["user_name"].ToString();
				}
				if(row["user_askprice_date"]!=null && row["user_askprice_date"].ToString()!="")
				{
					model.user_askprice_date=DateTime.Parse(row["user_askprice_date"].ToString());
				}
				if(row["BeSeats_id"]!=null && row["BeSeats_id"].ToString()!="")
				{
					model.BeSeats_id=int.Parse(row["BeSeats_id"].ToString());
				}
				if(row["BeSeats_empcode"]!=null)
				{
					model.BeSeats_empcode=row["BeSeats_empcode"].ToString();
				}
				if(row["BeSeats"]!=null)
				{
					model.BeSeats=row["BeSeats"].ToString();
				}
				if(row["ishandle"]!=null && row["ishandle"].ToString()!="")
				{
					model.ishandle=int.Parse(row["ishandle"].ToString());
				}
				if(row["handle_remark"]!=null)
				{
					model.handle_remark=row["handle_remark"].ToString();
				}
				if(row["handle_person_id"]!=null && row["handle_person_id"].ToString()!="")
				{
					model.handle_person_id=int.Parse(row["handle_person_id"].ToString());
				}
				if(row["handle_person_name"]!=null)
				{
					model.handle_person_name=row["handle_person_name"].ToString();
				}
				if(row["handle_date"]!=null && row["handle_date"].ToString()!="")
				{
					model.handle_date=DateTime.Parse(row["handle_date"].ToString());
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
			strSql.Append("select Id,askprice_content,user_id,user_uid,user_name,user_askprice_date,BeSeats_id,BeSeats_empcode,BeSeats,ishandle,handle_remark,handle_person_id,handle_person_name,handle_date ");
			strSql.Append(" FROM crm_shop_askprice ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select Id,askprice_content,user_id,user_uid,user_name,user_askprice_date,BeSeats_id,BeSeats_empcode,BeSeats,ishandle,handle_remark,handle_person_id,handle_person_name,handle_date ");
            strSql.Append(" FROM crm_shop_askprice ");
            strSql1.Append(" select count(id) FROM crm_shop_askprice ");
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
			strSql.Append("select count(1) FROM crm_shop_askprice ");
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
			strSql.Append(")AS Row, T.*  from crm_shop_askprice T ");
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
			parameters[0].Value = "crm_shop_askprice";
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

