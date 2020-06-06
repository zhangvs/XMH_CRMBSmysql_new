using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace QA.DAL
{
	/// <summary>
	/// 数据访问类:qa_setinfo
	/// </summary>
	public partial class qa_setinfo
	{
		public qa_setinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "qa_setinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from qa_setinfo");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(QA.Model.qa_setinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into qa_setinfo(");
			strSql.Append("factory_id,emp_id,emp_name,tel,email,receiving_time)");
			strSql.Append(" values (");
			strSql.Append("@factory_id,@emp_id,@emp_name,@tel,@email,@receiving_time)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@email", MySqlDbType.VarChar,50),
					new MySqlParameter("@receiving_time", MySqlDbType.Int32,2)};
			parameters[0].Value = model.factory_id;
			parameters[1].Value = model.emp_id;
			parameters[2].Value = model.emp_name;
			parameters[3].Value = model.tel;
			parameters[4].Value = model.email;
			parameters[5].Value = model.receiving_time;

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
		public bool Update(QA.Model.qa_setinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update qa_setinfo set ");
			strSql.Append("factory_id=@factory_id,");
			strSql.Append("emp_id=@emp_id,");
			strSql.Append("emp_name=@emp_name,");
			strSql.Append("tel=@tel,");
			strSql.Append("email=@email,");
			strSql.Append("receiving_time=@receiving_time");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@email", MySqlDbType.VarChar,50),
					new MySqlParameter("@receiving_time", MySqlDbType.Int32,2),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.factory_id;
			parameters[1].Value = model.emp_id;
			parameters[2].Value = model.emp_name;
			parameters[3].Value = model.tel;
			parameters[4].Value = model.email;
			parameters[5].Value = model.receiving_time;
			parameters[6].Value = model.id;

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
			strSql.Append("delete from qa_setinfo ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from qa_setinfo ");
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
		public QA.Model.qa_setinfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,factory_id,emp_id,emp_name,tel,email,receiving_time from qa_setinfo ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			QA.Model.qa_setinfo model=new QA.Model.qa_setinfo();
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
		public QA.Model.qa_setinfo DataRowToModel(DataRow row)
		{
			QA.Model.qa_setinfo model=new QA.Model.qa_setinfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["factory_id"]!=null)
				{
					model.factory_id=row["factory_id"].ToString();
				}
				if(row["emp_id"]!=null && row["emp_id"].ToString()!="")
				{
					model.emp_id=int.Parse(row["emp_id"].ToString());
				}
				if(row["emp_name"]!=null)
				{
					model.emp_name=row["emp_name"].ToString();
				}
				if(row["tel"]!=null)
				{
					model.tel=row["tel"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["receiving_time"]!=null && row["receiving_time"].ToString()!="")
				{
					model.receiving_time=int.Parse(row["receiving_time"].ToString());
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
			strSql.Append("select id,factory_id,emp_id,emp_name,tel,email,receiving_time ");
			strSql.Append(" FROM qa_setinfo ");
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
			strSql.Append("select count(1) FROM qa_setinfo ");
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
			strSql.Append(")AS Row, T.*  from qa_setinfo T ");
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
			parameters[0].Value = "qa_setinfo";
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

