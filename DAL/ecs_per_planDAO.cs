using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// 数据访问类:ecs_per_planDAO
	/// </summary>
	public partial class ecs_per_planDAO
	{
		public ecs_per_planDAO()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int plan_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ecs_per_plan");
			strSql.Append(" where plan_id=@plan_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@plan_id", MySqlDbType.Int32)
			};
			parameters[0].Value = plan_id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(XHD.Model.ecs_per_plan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ecs_per_plan(");
			strSql.Append("plan_year,plan_task,plan_jan,plan_feb,plan_mar,plan_apr,plan_may,plan_jun,plan_jul,plan_aug,plan_sep,plan_oct,plan_nov,plan_dec,kf_rname,kf_uname)");
			strSql.Append(" values (");
			strSql.Append("@plan_year,@plan_task,@plan_jan,@plan_feb,@plan_mar,@plan_apr,@plan_may,@plan_jun,@plan_jul,@plan_aug,@plan_sep,@plan_oct,@plan_nov,@plan_dec,@kf_rname,@kf_uname)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@plan_year", MySqlDbType.VarChar,4),
					new MySqlParameter("@plan_task", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_jan", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_feb", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_mar", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_apr", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_may", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_jun", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_jul", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_aug", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_sep", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_oct", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_nov", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_dec", MySqlDbType.VarChar,100),
					new MySqlParameter("@kf_rname", MySqlDbType.VarChar,100),
					new MySqlParameter("@kf_uname", MySqlDbType.VarChar,100)};
			parameters[0].Value = model.plan_year;
			parameters[1].Value = model.plan_task;
			parameters[2].Value = model.plan_jan;
			parameters[3].Value = model.plan_feb;
			parameters[4].Value = model.plan_mar;
			parameters[5].Value = model.plan_apr;
			parameters[6].Value = model.plan_may;
			parameters[7].Value = model.plan_jun;
			parameters[8].Value = model.plan_jul;
			parameters[9].Value = model.plan_aug;
			parameters[10].Value = model.plan_sep;
			parameters[11].Value = model.plan_oct;
			parameters[12].Value = model.plan_nov;
			parameters[13].Value = model.plan_dec;
			parameters[14].Value = model.kf_rname;
			parameters[15].Value = model.kf_uname;

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
		public bool Update(XHD.Model.ecs_per_plan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ecs_per_plan set ");
			strSql.Append("plan_year=@plan_year,");
			strSql.Append("plan_task=@plan_task,");
			strSql.Append("plan_jan=@plan_jan,");
			strSql.Append("plan_feb=@plan_feb,");
			strSql.Append("plan_mar=@plan_mar,");
			strSql.Append("plan_apr=@plan_apr,");
			strSql.Append("plan_may=@plan_may,");
			strSql.Append("plan_jun=@plan_jun,");
			strSql.Append("plan_jul=@plan_jul,");
			strSql.Append("plan_aug=@plan_aug,");
			strSql.Append("plan_sep=@plan_sep,");
			strSql.Append("plan_oct=@plan_oct,");
			strSql.Append("plan_nov=@plan_nov,");
			strSql.Append("plan_dec=@plan_dec,");
			strSql.Append("kf_rname=@kf_rname,");
			strSql.Append("kf_uname=@kf_uname");
			strSql.Append(" where plan_id=@plan_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@plan_year", MySqlDbType.VarChar,4),
					new MySqlParameter("@plan_task", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_jan", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_feb", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_mar", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_apr", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_may", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_jun", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_jul", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_aug", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_sep", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_oct", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_nov", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_dec", MySqlDbType.VarChar,100),
					new MySqlParameter("@kf_rname", MySqlDbType.VarChar,100),
					new MySqlParameter("@kf_uname", MySqlDbType.VarChar,100),
					new MySqlParameter("@plan_id", MySqlDbType.Int32,10)};
			parameters[0].Value = model.plan_year;
			parameters[1].Value = model.plan_task;
			parameters[2].Value = model.plan_jan;
			parameters[3].Value = model.plan_feb;
			parameters[4].Value = model.plan_mar;
			parameters[5].Value = model.plan_apr;
			parameters[6].Value = model.plan_may;
			parameters[7].Value = model.plan_jun;
			parameters[8].Value = model.plan_jul;
			parameters[9].Value = model.plan_aug;
			parameters[10].Value = model.plan_sep;
			parameters[11].Value = model.plan_oct;
			parameters[12].Value = model.plan_nov;
			parameters[13].Value = model.plan_dec;
			parameters[14].Value = model.kf_rname;
			parameters[15].Value = model.kf_uname;
			parameters[16].Value = model.plan_id;

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
		public bool Delete(int plan_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ecs_per_plan ");
			strSql.Append(" where plan_id=@plan_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@plan_id", MySqlDbType.Int32)
			};
			parameters[0].Value = plan_id;

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
		public bool DeleteList(string plan_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ecs_per_plan ");
			strSql.Append(" where plan_id in ("+plan_idlist + ")  ");
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
		public XHD.Model.ecs_per_plan GetModel(int plan_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select plan_id,plan_year,plan_task,plan_jan,plan_feb,plan_mar,plan_apr,plan_may,plan_jun,plan_jul,plan_aug,plan_sep,plan_oct,plan_nov,plan_dec,kf_rname,kf_uname from ecs_per_plan ");
			strSql.Append(" where plan_id=@plan_id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@plan_id", MySqlDbType.Int32)
			};
			parameters[0].Value = plan_id;

			XHD.Model.ecs_per_plan model=new XHD.Model.ecs_per_plan();
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
		public XHD.Model.ecs_per_plan DataRowToModel(DataRow row)
		{
			XHD.Model.ecs_per_plan model=new XHD.Model.ecs_per_plan();
			if (row != null)
			{
				if(row["plan_id"]!=null && row["plan_id"].ToString()!="")
				{
					model.plan_id=int.Parse(row["plan_id"].ToString());
				}
				if(row["plan_year"]!=null)
				{
					model.plan_year=row["plan_year"].ToString();
				}
				if(row["plan_task"]!=null)
				{
					model.plan_task=row["plan_task"].ToString();
				}
				if(row["plan_jan"]!=null)
				{
					model.plan_jan=row["plan_jan"].ToString();
				}
				if(row["plan_feb"]!=null)
				{
					model.plan_feb=row["plan_feb"].ToString();
				}
				if(row["plan_mar"]!=null)
				{
					model.plan_mar=row["plan_mar"].ToString();
				}
				if(row["plan_apr"]!=null)
				{
					model.plan_apr=row["plan_apr"].ToString();
				}
				if(row["plan_may"]!=null)
				{
					model.plan_may=row["plan_may"].ToString();
				}
				if(row["plan_jun"]!=null)
				{
					model.plan_jun=row["plan_jun"].ToString();
				}
				if(row["plan_jul"]!=null)
				{
					model.plan_jul=row["plan_jul"].ToString();
				}
				if(row["plan_aug"]!=null)
				{
					model.plan_aug=row["plan_aug"].ToString();
				}
				if(row["plan_sep"]!=null)
				{
					model.plan_sep=row["plan_sep"].ToString();
				}
				if(row["plan_oct"]!=null)
				{
					model.plan_oct=row["plan_oct"].ToString();
				}
				if(row["plan_nov"]!=null)
				{
					model.plan_nov=row["plan_nov"].ToString();
				}
				if(row["plan_dec"]!=null)
				{
					model.plan_dec=row["plan_dec"].ToString();
				}
				if(row["kf_rname"]!=null)
				{
					model.kf_rname=row["kf_rname"].ToString();
				}
				if(row["kf_uname"]!=null)
				{
					model.kf_uname=row["kf_uname"].ToString();
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
			strSql.Append("select plan_id,plan_year,plan_task,plan_jan,plan_feb,plan_mar,plan_apr,plan_may,plan_jun,plan_jul,plan_aug,plan_sep,plan_oct,plan_nov,plan_dec,kf_rname,kf_uname ");
			strSql.Append(" FROM ecs_per_plan ");
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
			strSql.Append("select count(1) FROM ecs_per_plan ");
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
				strSql.Append("order by T.plan_id desc");
			}
			strSql.Append(")AS Row, T.*  from ecs_per_plan T ");
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
			parameters[0].Value = "ecs_per_plan";
			parameters[1].Value = "plan_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod

		#region  ExtensionMethod
        
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select * FROM ecs_per_plan ");
            strSql1.Append(" select count(*) FROM ecs_per_plan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

		#endregion  ExtensionMethod
	}
}

