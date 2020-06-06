using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace QA.DAL
{
	/// <summary>
	/// 数据访问类:qa_answer
	/// </summary>
	public partial class qa_answer
	{
		public qa_answer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "qa_answer"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from qa_answer");
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
		public bool Add(QA.Model.qa_answer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into qa_answer(");
			strSql.Append("question_id,content,limit_time,read_status,handle_status,evaluate,answer_id,answer_name,top_grade_id,top_grade_name,cc_grade)");
			strSql.Append(" values (");
			strSql.Append("@question_id,@content,@limit_time,@read_status,@handle_status,@evaluate,@answer_id,@answer_name,@top_grade_id,@top_grade_name,@cc_grade)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@question_id", MySqlDbType.Int32,11),
					new MySqlParameter("@content", MySqlDbType.Text),
					new MySqlParameter("@limit_time", MySqlDbType.DateTime),
					new MySqlParameter("@read_status", MySqlDbType.Int32,2),
					new MySqlParameter("@handle_status", MySqlDbType.Int32,2),
					new MySqlParameter("@evaluate", MySqlDbType.Int32,2),
					new MySqlParameter("@answer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@answer_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@top_grade_id", MySqlDbType.Int32,11),
					new MySqlParameter("@top_grade_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@cc_grade", MySqlDbType.Int32,2)};
			parameters[0].Value = model.question_id;
			parameters[1].Value = model.content;
			parameters[2].Value = model.limit_time;
			parameters[3].Value = model.read_status;
			parameters[4].Value = model.handle_status;
			parameters[5].Value = model.evaluate;
			parameters[6].Value = model.answer_id;
			parameters[7].Value = model.answer_name;
			parameters[8].Value = model.top_grade_id;
			parameters[9].Value = model.top_grade_name;
			parameters[10].Value = model.cc_grade;

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
		public bool Update(QA.Model.qa_answer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update qa_answer set ");
			strSql.Append("question_id=@question_id,");
			strSql.Append("content=@content,");
			strSql.Append("limit_time=@limit_time,");
			strSql.Append("read_status=@read_status,");
			strSql.Append("handle_status=@handle_status,");
			strSql.Append("evaluate=@evaluate,");
			strSql.Append("answer_id=@answer_id,");
			strSql.Append("answer_name=@answer_name,");
			strSql.Append("top_grade_id=@top_grade_id,");
			strSql.Append("top_grade_name=@top_grade_name,");
			strSql.Append("cc_grade=@cc_grade");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@question_id", MySqlDbType.Int32,11),
					new MySqlParameter("@content", MySqlDbType.Text),
					new MySqlParameter("@limit_time", MySqlDbType.DateTime),
					new MySqlParameter("@read_status", MySqlDbType.Int32,2),
					new MySqlParameter("@handle_status", MySqlDbType.Int32,2),
					new MySqlParameter("@evaluate", MySqlDbType.Int32,2),
					new MySqlParameter("@answer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@answer_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@top_grade_id", MySqlDbType.Int32,11),
					new MySqlParameter("@top_grade_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@cc_grade", MySqlDbType.Int32,2),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.question_id;
			parameters[1].Value = model.content;
			parameters[2].Value = model.limit_time;
			parameters[3].Value = model.read_status;
			parameters[4].Value = model.handle_status;
			parameters[5].Value = model.evaluate;
			parameters[6].Value = model.answer_id;
			parameters[7].Value = model.answer_name;
			parameters[8].Value = model.top_grade_id;
			parameters[9].Value = model.top_grade_name;
			parameters[10].Value = model.cc_grade;
			parameters[11].Value = model.id;

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
			strSql.Append("delete from qa_answer ");
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
			strSql.Append("delete from qa_answer ");
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
		public QA.Model.qa_answer GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,question_id,content,limit_time,read_status,handle_status,evaluate,answer_id,answer_name,top_grade_id,top_grade_name,cc_grade from qa_answer ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			QA.Model.qa_answer model=new QA.Model.qa_answer();
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
		public QA.Model.qa_answer DataRowToModel(DataRow row)
		{
			QA.Model.qa_answer model=new QA.Model.qa_answer();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["question_id"]!=null && row["question_id"].ToString()!="")
				{
					model.question_id=int.Parse(row["question_id"].ToString());
				}
				if(row["content"]!=null)
				{
					model.content=row["content"].ToString();
				}
				if(row["limit_time"]!=null && row["limit_time"].ToString()!="")
				{
					model.limit_time=DateTime.Parse(row["limit_time"].ToString());
				}
				if(row["read_status"]!=null && row["read_status"].ToString()!="")
				{
					model.read_status=int.Parse(row["read_status"].ToString());
				}
				if(row["handle_status"]!=null && row["handle_status"].ToString()!="")
				{
					model.handle_status=int.Parse(row["handle_status"].ToString());
				}
				if(row["evaluate"]!=null && row["evaluate"].ToString()!="")
				{
					model.evaluate=int.Parse(row["evaluate"].ToString());
				}
				if(row["answer_id"]!=null && row["answer_id"].ToString()!="")
				{
					model.answer_id=int.Parse(row["answer_id"].ToString());
				}
				if(row["answer_name"]!=null)
				{
					model.answer_name=row["answer_name"].ToString();
				}
				if(row["top_grade_id"]!=null && row["top_grade_id"].ToString()!="")
				{
					model.top_grade_id=int.Parse(row["top_grade_id"].ToString());
				}
				if(row["top_grade_name"]!=null)
				{
					model.top_grade_name=row["top_grade_name"].ToString();
				}
				if(row["cc_grade"]!=null && row["cc_grade"].ToString()!="")
				{
					model.cc_grade=int.Parse(row["cc_grade"].ToString());
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
			strSql.Append("select id,question_id,content,limit_time,read_status,handle_status,evaluate,answer_id,answer_name,top_grade_id,top_grade_name,cc_grade ");
			strSql.Append(" FROM qa_answer ");
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
			strSql.Append("select count(1) FROM qa_answer ");
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
			strSql.Append(")AS Row, T.*  from qa_answer T ");
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
			parameters[0].Value = "qa_answer";
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

