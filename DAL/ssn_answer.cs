using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// 数据访问类:ssn_answer
	/// </summary>
	public partial class ssn_answer
	{
		public ssn_answer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ssn_answer");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.ssn_answer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ssn_answer(");
            strSql.Append("qid,answer_uid,answer_name,answer_content,is_best,evaluatelevel,answer_time,isdeleted)");
			strSql.Append(" values (");
            strSql.Append("@qid,@answer_uid,@answer_name,@answer_content,@is_best,@evaluatelevel,@answer_time,@isdeleted)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@qid", MySqlDbType.Int64,20),
					new MySqlParameter("@answer_uid", MySqlDbType.Int32,11),
					new MySqlParameter("@answer_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@answer_content", MySqlDbType.Text),
					new MySqlParameter("@is_best", MySqlDbType.Int32,2),
					new MySqlParameter("@evaluatelevel", MySqlDbType.Int32,4),
					new MySqlParameter("@answer_time", MySqlDbType.DateTime),
                    new MySqlParameter("@isdeleted", MySqlDbType.Int32,2)};
			parameters[0].Value = model.qid;
			parameters[1].Value = model.answer_uid;
			parameters[2].Value = model.answer_name;
			parameters[3].Value = model.answer_content;
			parameters[4].Value = model.is_best;
            parameters[5].Value = model.evaluatelevel;
			parameters[6].Value = model.answer_time;
            parameters[7].Value = model.isdeleted;
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
		public bool Update(XHD.Model.ssn_answer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ssn_answer set ");
			strSql.Append("qid=@qid,");
			strSql.Append("answer_uid=@answer_uid,");
			strSql.Append("answer_name=@answer_name,");
			strSql.Append("answer_content=@answer_content,");
			strSql.Append("is_best=@is_best,");
            strSql.Append("evaluatelevel=@evaluatelevel,");
			strSql.Append("answer_time=@answer_time,");
            strSql.Append("isdeleted=@isdeleted");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@qid", MySqlDbType.Int64,20),
					new MySqlParameter("@answer_uid", MySqlDbType.Int32,11),
					new MySqlParameter("@answer_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@answer_content", MySqlDbType.Text),
					new MySqlParameter("@is_best", MySqlDbType.Int32,2),
					new MySqlParameter("@evaluatelevel", MySqlDbType.Int32,4),
					new MySqlParameter("@answer_time", MySqlDbType.DateTime),
                    new MySqlParameter("@isdeleted", MySqlDbType.Int32,2),
					new MySqlParameter("@id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.qid;
			parameters[1].Value = model.answer_uid;
			parameters[2].Value = model.answer_name;
			parameters[3].Value = model.answer_content;
			parameters[4].Value = model.is_best;
            parameters[5].Value = model.evaluatelevel;
			parameters[6].Value = model.answer_time;
            parameters[7].Value = model.isdeleted;
			parameters[8].Value = model.id;

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
		public bool Delete(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ssn_answer ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
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
			strSql.Append("delete from ssn_answer ");
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
		public XHD.Model.ssn_answer GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,qid,answer_uid,answer_name,answer_content,is_best,evaluatelevel,answer_time,isdeleted from ssn_answer ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
			parameters[0].Value = id;

			XHD.Model.ssn_answer model=new XHD.Model.ssn_answer();
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
		public XHD.Model.ssn_answer DataRowToModel(DataRow row)
		{
			XHD.Model.ssn_answer model=new XHD.Model.ssn_answer();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["qid"]!=null && row["qid"].ToString()!="")
				{
					model.qid=long.Parse(row["qid"].ToString());
				}
				if(row["answer_uid"]!=null && row["answer_uid"].ToString()!="")
				{
					model.answer_uid=int.Parse(row["answer_uid"].ToString());
				}
				if(row["answer_name"]!=null)
				{
					model.answer_name=row["answer_name"].ToString();
				}
				if(row["answer_content"]!=null)
				{
					model.answer_content=row["answer_content"].ToString();
				}
				if(row["is_best"]!=null && row["is_best"].ToString()!="")
				{
					model.is_best=int.Parse(row["is_best"].ToString());
				}
                if (row["evaluatelevel"] != null && row["evaluatelevel"].ToString() != "")
				{
                    model.evaluatelevel = int.Parse(row["evaluatelevel"].ToString());
				}
				if(row["answer_time"]!=null && row["answer_time"].ToString()!="")
				{
					model.answer_time=DateTime.Parse(row["answer_time"].ToString());
				}
                if (row["isdeleted"] != null && row["isdeleted"].ToString() != "")
                {
                    model.isdeleted = int.Parse(row["isdeleted"].ToString());
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
            strSql.Append("select id,qid,answer_uid,answer_name,answer_content,is_best,evaluatelevel,answer_time,isdeleted ");
			strSql.Append(" FROM ssn_answer ");
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
			strSql.Append("select count(1) FROM ssn_answer ");
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
			strSql.Append(")AS Row, T.*  from ssn_answer T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 根据问题地
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select a.id,a.qid,a.answer_uid,a.answer_name,a.answer_content,a.is_best,a.evaluatelevel,a.answer_time,a.isdeleted,e.title as headImg ");
            strSql.Append(" FROM ssn_answer as a left join hr_employee as e on a.answer_uid=e.ID");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql1.Append(" select count(1) FROM ssn_answer as a ");
            if (strWhere.Trim() != "")
            {
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
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
			parameters[0].Value = "ssn_answer";
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

