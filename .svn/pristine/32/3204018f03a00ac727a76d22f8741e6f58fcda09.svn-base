using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// 数据访问类:Param_City
	/// </summary>
	public partial class Param_City
	{
		public Param_City()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "Param_City"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Param_City");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(XHD.Model.Param_City model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Param_City(");
            strSql.Append("parentid,City,City_order,Create_id,Create_date,Update_id,Update_date)");
			strSql.Append(" values (");
            strSql.Append("@parentid,@City,@City_order,@Create_id,@Create_date,@Update_id,@Update_date)");
			strSql.Append(";select @@IDENTITY");
			MySqlParameter[] parameters = {
					new MySqlParameter("@parentid", MySqlDbType.Int32,4),
					new MySqlParameter("@City", MySqlDbType.VarChar,250),
                    new MySqlParameter("@City_order",MySqlDbType.Int32,4),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@Update_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Update_date", MySqlDbType.DateTime)};
			parameters[0].Value = model.parentid;
			parameters[1].Value = model.City;
            parameters[2].Value = model.City_order;
			parameters[3].Value = model.Create_id;
			parameters[4].Value = model.Create_date;
			parameters[5].Value = model.Update_id;
			parameters[6].Value = model.Update_date;

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
		public bool Update(XHD.Model.Param_City model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Param_City set ");
			strSql.Append("parentid=@parentid,");
			strSql.Append("City=@City,");
            strSql.Append("City_order=@City_order,");
			strSql.Append("Create_id=@Create_id,");
			strSql.Append("Create_date=@Create_date,");
			strSql.Append("Update_id=@Update_id,");
			strSql.Append("Update_date=@Update_date");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@parentid", MySqlDbType.Int32,4),
					new MySqlParameter("@City", MySqlDbType.VarChar,250),
                    new MySqlParameter("@City_order",MySqlDbType.Int32,4),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@Update_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Update_date", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
			parameters[0].Value = model.parentid;
			parameters[1].Value = model.City;
            parameters[2].Value = model.City_order;
			parameters[3].Value = model.Create_id;
			parameters[4].Value = model.Create_date;
			parameters[5].Value = model.Update_id;
			parameters[6].Value = model.Update_date;
			parameters[7].Value = model.id;

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
			strSql.Append("delete from Param_City ");
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
			strSql.Append("delete from Param_City ");
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
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,parentid,City,City_order ");
			strSql.Append(" FROM Param_City ");
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
			
			strSql.Append(" id,parentid,City,City_order ");
			strSql.Append(" FROM Param_City ");

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
            strSql.Append("  id,parentid,City,City_order FROM Param_City ");
            //strSql.Append(" WHERE id not in ( SELECT id FROM Param_City  limit " + (PageIndex - 1) * PageSize + " ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
			strSql1.Append(" select count(id) FROM Param_City ");
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

