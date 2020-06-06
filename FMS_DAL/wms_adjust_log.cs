using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;

namespace FMS_DAL
{
	/// <summary>
	/// 数据访问类:wms_adjust_log
	/// </summary>
	public partial class wms_adjust_log
	{
		public wms_adjust_log()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from wms_adjust_log");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64,20)			};
			parameters[0].Value = id;

			return Wms_DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FMS_Model.wms_adjust_log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into wms_adjust_log(");
			strSql.Append("id,adjust_id,adjust_sn,emp_code,emp_name,log_info,log_time)");
			strSql.Append(" values (");
			strSql.Append("@id,@adjust_id,@adjust_sn,@emp_code,@emp_name,@log_info,@log_time)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64,20),
					new MySqlParameter("@adjust_id", MySqlDbType.Int64,20),
					new MySqlParameter("@adjust_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@log_info", MySqlDbType.VarChar,500),
					new MySqlParameter("@log_time", MySqlDbType.DateTime)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.adjust_id;
			parameters[2].Value = model.adjust_sn;
			parameters[3].Value = model.emp_code;
			parameters[4].Value = model.emp_name;
			parameters[5].Value = model.log_info;
			parameters[6].Value = model.log_time;

			int rows=Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(FMS_Model.wms_adjust_log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update wms_adjust_log set ");
			strSql.Append("adjust_id=@adjust_id,");
			strSql.Append("adjust_sn=@adjust_sn,");
			strSql.Append("emp_code=@emp_code,");
			strSql.Append("emp_name=@emp_name,");
			strSql.Append("log_info=@log_info,");
			strSql.Append("log_time=@log_time");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@adjust_id", MySqlDbType.Int64,20),
					new MySqlParameter("@adjust_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@log_info", MySqlDbType.VarChar,500),
					new MySqlParameter("@log_time", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.adjust_id;
			parameters[1].Value = model.adjust_sn;
			parameters[2].Value = model.emp_code;
			parameters[3].Value = model.emp_name;
			parameters[4].Value = model.log_info;
			parameters[5].Value = model.log_time;
			parameters[6].Value = model.id;

			int rows=Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
			strSql.Append("delete from wms_adjust_log ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64,20)			};
			parameters[0].Value = id;

			int rows=Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
			strSql.Append("delete from wms_adjust_log ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=Wms_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public FMS_Model.wms_adjust_log GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,adjust_id,adjust_sn,emp_code,emp_name,log_info,log_time from wms_adjust_log ");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64,20)			};
			parameters[0].Value = id;

			FMS_Model.wms_adjust_log model=new FMS_Model.wms_adjust_log();
			DataSet ds=Wms_DbHelperMySQL.Query(strSql.ToString(),parameters);
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
		public FMS_Model.wms_adjust_log DataRowToModel(DataRow row)
		{
			FMS_Model.wms_adjust_log model=new FMS_Model.wms_adjust_log();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["adjust_id"]!=null && row["adjust_id"].ToString()!="")
				{
					model.adjust_id=long.Parse(row["adjust_id"].ToString());
				}
				if(row["adjust_sn"]!=null)
				{
					model.adjust_sn=row["adjust_sn"].ToString();
				}
				if(row["emp_code"]!=null)
				{
					model.emp_code=row["emp_code"].ToString();
				}
				if(row["emp_name"]!=null)
				{
					model.emp_name=row["emp_name"].ToString();
				}
				if(row["log_info"]!=null)
				{
					model.log_info=row["log_info"].ToString();
				}
				if(row["log_time"]!=null && row["log_time"].ToString()!="")
				{
					model.log_time=DateTime.Parse(row["log_time"].ToString());
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
			strSql.Append("select id,adjust_id,adjust_sn,emp_code,emp_name,log_info,log_time ");
			strSql.Append(" FROM wms_adjust_log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return Wms_DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM wms_adjust_log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = Wms_DbHelperMySQL.GetSingle(strSql.ToString());
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
			strSql.Append(")AS Row, T.*  from wms_adjust_log T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return Wms_DbHelperMySQL.Query(strSql.ToString());
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
			parameters[0].Value = "wms_adjust_log";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return Wms_DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

