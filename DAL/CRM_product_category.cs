using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// 数据访问类:CRM_product_category
	/// </summary>
	public partial class CRM_product_category
	{
		public CRM_product_category()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "CRM_product_category"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CRM_product_category");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(XHD.Model.CRM_product_category model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CRM_product_category(");
			strSql.Append("product_category,parentid,product_icon,isDelete,Delete_id,Delete_time)");
			strSql.Append(" values (");
			strSql.Append("@product_category,@parentid,@product_icon,@isDelete,@Delete_id,@Delete_time)");
			strSql.Append(";select @@IDENTITY");
			MySqlParameter[] parameters = {
					new MySqlParameter("@product_category", MySqlDbType.VarChar,250),
					new MySqlParameter("@parentid", MySqlDbType.Int32,4),
					new MySqlParameter("@product_icon", MySqlDbType.VarChar,250),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,4),
					new MySqlParameter("@Delete_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime)};
			parameters[0].Value = model.product_category;
			parameters[1].Value = model.parentid;
			parameters[2].Value = model.product_icon;
			parameters[3].Value = model.isDelete;
			parameters[4].Value = model.Delete_id;
			parameters[5].Value = model.Delete_time;

			object obj = DbHelperMySQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(XHD.Model.CRM_product_category model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CRM_product_category set ");
			strSql.Append("product_category=@product_category,");
			strSql.Append("parentid=@parentid,");
			strSql.Append("product_icon=@product_icon"); 

			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@product_category", MySqlDbType.VarChar,250),
					new MySqlParameter("@parentid", MySqlDbType.Int32,4),
					new MySqlParameter("@product_icon", MySqlDbType.VarChar,250),  
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
			parameters[0].Value = model.product_category;
			parameters[1].Value = model.parentid;
			parameters[2].Value = model.product_icon;
			parameters[3].Value = model.id;

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
		/// 预删除
		/// </summary>
		public bool AdvanceDelete(int id, int isDelete, string time)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("update CRM_product_category set ");
			strSql.Append("isDelete=" + isDelete);
			strSql.Append(",Delete_time='" + time + "'");
			strSql.Append(" where id=" + id);
			int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
			strSql.Append("delete from CRM_product_category ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)
};
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
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CRM_product_category ");
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
		public XHD.Model.CRM_product_category GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  id,product_category,parentid,product_icon,isDelete,Delete_id,Delete_time from CRM_product_category ");
			strSql.Append(" where id=@id  limit 1");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)
};
			parameters[0].Value = id;

			XHD.Model.CRM_product_category model=new XHD.Model.CRM_product_category();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["product_category"]!=null && ds.Tables[0].Rows[0]["product_category"].ToString()!="")
				{
					model.product_category=ds.Tables[0].Rows[0]["product_category"].ToString();
				}
				if(ds.Tables[0].Rows[0]["parentid"]!=null && ds.Tables[0].Rows[0]["parentid"].ToString()!="")
				{
					model.parentid=int.Parse(ds.Tables[0].Rows[0]["parentid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["product_icon"]!=null && ds.Tables[0].Rows[0]["product_icon"].ToString()!="")
				{
					model.product_icon=ds.Tables[0].Rows[0]["product_icon"].ToString();
				}
				if(ds.Tables[0].Rows[0]["isDelete"]!=null && ds.Tables[0].Rows[0]["isDelete"].ToString()!="")
				{
					model.isDelete=int.Parse(ds.Tables[0].Rows[0]["isDelete"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Delete_id"]!=null && ds.Tables[0].Rows[0]["Delete_id"].ToString()!="")
				{
					model.Delete_id=int.Parse(ds.Tables[0].Rows[0]["Delete_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Delete_time"]!=null && ds.Tables[0].Rows[0]["Delete_time"].ToString()!="")
				{
					model.Delete_time=DateTime.Parse(ds.Tables[0].Rows[0]["Delete_time"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,product_category,parentid,product_icon,isDelete,Delete_id,Delete_time ");
			strSql.Append(" FROM CRM_product_category ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			
			strSql.Append(" id,product_category,parentid,product_icon,isDelete,Delete_id,Delete_time ");
			strSql.Append(" FROM CRM_product_category ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
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
			strSql.Append("select ");
			strSql.Append(" * FROM CRM_product_category ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_product_category ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
			strSql1.Append(" select count(id) FROM CRM_product_category ");
			if (strWhere.Trim() != "")
			{
			    strSql.Append(" where " + strWhere);
			    strSql1.Append(" where " + strWhere);
			}
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
			Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
			return DbHelperMySQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

