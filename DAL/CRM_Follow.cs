using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// 数据访问类:CRM_Follow
	/// </summary>
	public partial class CRM_Follow
	{
		public CRM_Follow()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "CRM_Follow"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CRM_Follow");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(XHD.Model.CRM_Follow model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CRM_Follow(");
            strSql.Append("Customer_id,Factory_Id,Customer_name,Follow,Follow_date,Follow_Type_id,Follow_Type,department_id,department_name,employee_id,employee_name,isDelete,Delete_time)");
			strSql.Append(" values (");
            strSql.Append("@Customer_id,@Factory_Id,@Customer_name,@Follow,@Follow_date,@Follow_Type_id,@Follow_Type,@department_id,@department_name,@employee_id,@employee_name,@isDelete,@Delete_time)");
			strSql.Append(";select @@IDENTITY");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Customer_id", MySqlDbType.Int32,4),
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Customer_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@Follow", MySqlDbType.VarChar,4000),
					new MySqlParameter("@Follow_date", MySqlDbType.DateTime),
					new MySqlParameter("@Follow_Type_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Follow_Type", MySqlDbType.VarChar,250),
					new MySqlParameter("@department_id", MySqlDbType.Int32,4),
					new MySqlParameter("@department_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@employee_id", MySqlDbType.Int32,4),
					new MySqlParameter("@employee_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,4),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime)};
			parameters[0].Value = model.Customer_id;
            parameters[1].Value = model.Factory_Id;
			parameters[2].Value = model.Customer_name;
			parameters[3].Value = model.Follow;
			parameters[4].Value = model.Follow_date;
			parameters[5].Value = model.Follow_Type_id;
			parameters[6].Value = model.Follow_Type;
			parameters[7].Value = model.department_id;
			parameters[8].Value = model.department_name;
			parameters[9].Value = model.employee_id;
			parameters[10].Value = model.employee_name;
			parameters[11].Value = model.isDelete;
			parameters[12].Value = model.Delete_time;

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
		public bool Update(XHD.Model.CRM_Follow model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CRM_Follow set ");			
			strSql.Append("Follow=@Follow,");			
			strSql.Append("Follow_Type_id=@Follow_Type_id,");
			strSql.Append("Follow_Type=@Follow_Type");			
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {					
					new MySqlParameter("@Follow", MySqlDbType.VarChar,-1),					
					new MySqlParameter("@Follow_Type_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Follow_Type", MySqlDbType.VarChar,250),	
					new MySqlParameter("@id", MySqlDbType.Int32,4)};

			parameters[0].Value = model.Follow;
			parameters[1].Value = model.Follow_Type_id;
			parameters[2].Value = model.Follow_Type; 
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
			strSql.Append("update CRM_Follow set ");
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
			strSql.Append("delete from CRM_Follow ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
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
			strSql.Append("delete from CRM_Follow ");
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
		public XHD.Model.CRM_Follow GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  id,Customer_id,Customer_name,Follow,Follow_date,Follow_Type_id,Follow_Type,department_id,department_name,employee_id,employee_name,isDelete,Delete_time from CRM_Follow ");
			strSql.Append(" where id=@id limit 1");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)
};
			parameters[0].Value = id;

			XHD.Model.CRM_Follow model=new XHD.Model.CRM_Follow();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Customer_id"]!=null && ds.Tables[0].Rows[0]["Customer_id"].ToString()!="")
				{
					model.Customer_id=int.Parse(ds.Tables[0].Rows[0]["Customer_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Customer_name"]!=null && ds.Tables[0].Rows[0]["Customer_name"].ToString()!="")
				{
					model.Customer_name=ds.Tables[0].Rows[0]["Customer_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Follow"]!=null && ds.Tables[0].Rows[0]["Follow"].ToString()!="")
				{
					model.Follow=ds.Tables[0].Rows[0]["Follow"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Follow_date"]!=null && ds.Tables[0].Rows[0]["Follow_date"].ToString()!="")
				{
					model.Follow_date=DateTime.Parse(ds.Tables[0].Rows[0]["Follow_date"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Follow_Type_id"]!=null && ds.Tables[0].Rows[0]["Follow_Type_id"].ToString()!="")
				{
					model.Follow_Type_id=int.Parse(ds.Tables[0].Rows[0]["Follow_Type_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Follow_Type"]!=null && ds.Tables[0].Rows[0]["Follow_Type"].ToString()!="")
				{
					model.Follow_Type=ds.Tables[0].Rows[0]["Follow_Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["department_id"]!=null && ds.Tables[0].Rows[0]["department_id"].ToString()!="")
				{
					model.department_id=int.Parse(ds.Tables[0].Rows[0]["department_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["department_name"]!=null && ds.Tables[0].Rows[0]["department_name"].ToString()!="")
				{
					model.department_name=ds.Tables[0].Rows[0]["department_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["employee_id"]!=null && ds.Tables[0].Rows[0]["employee_id"].ToString()!="")
				{
					model.employee_id=int.Parse(ds.Tables[0].Rows[0]["employee_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["employee_name"]!=null && ds.Tables[0].Rows[0]["employee_name"].ToString()!="")
				{
					model.employee_name=ds.Tables[0].Rows[0]["employee_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["isDelete"]!=null && ds.Tables[0].Rows[0]["isDelete"].ToString()!="")
				{
					model.isDelete=int.Parse(ds.Tables[0].Rows[0]["isDelete"].ToString());
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
            strSql.Append("select id,Factory_Id,Customer_id,Customer_name,Follow,Follow_date,Follow_Type_id,Follow_Type,department_id,department_name,employee_id,employee_name,isDelete,Delete_time ");
			strSql.Append(" FROM CRM_Follow ");
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
			
			strSql.Append(" id,Customer_id,Customer_name,Follow,Follow_date,Follow_Type_id,Follow_Type,department_id,department_name,employee_id,employee_name,isDelete,Delete_time ");
			strSql.Append(" FROM CRM_Follow ");
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
			strSql.Append(" * FROM CRM_Follow ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_Follow ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
			strSql1.Append(" select count(id) FROM CRM_Follow ");
			if (strWhere.Trim() != "")
			{
			    strSql.Append(" where " + strWhere);
			    strSql1.Append(" where " + strWhere);
			}
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
			Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
			return DbHelperMySQL.Query(strSql.ToString());
		}

        public DataSet Reports_year(string items, int year, string where)
        {
            StringBuilder strSql = new StringBuilder();

            //strSql.Append("if OBJECT_ID('Tempdb..#t') is not null ");
            //strSql.Append("    drop TABLE  #t ");
            ////strSql.Append("go");
            //strSql.Append(" begin ");
            ////strSql.Append("    --预统计表 #t");
            //strSql.Append("    select ");
            //strSql.Append("        " + items + ",'m'+convert(varchar,month(Follow_date)) mm,count(id)tNum into #t ");
            //strSql.Append("    from dbo.CRM_Follow ");
            //strSql.Append("    where timestampdiff(YEAR,[Follow_date],'" + year + "-1-1')=0 ");
            //if (where.Trim() != "")
            //{
            //    strSql.Append(" and " + where);
            //}
            //strSql.Append("    group by " + items + ",'m'+convert(varchar,month(Follow_date)) ");

            ////strSql.Append("    --生成SQL");
            //strSql.Append("    declare @sql varchar(8000) ");
            //strSql.Append("    set @sql='select " + items + " items ' ");
            //strSql.Append("    select @sql = @sql + ',sum(case mm when ' + char(39) +mm+ char(39) + ' then tNum else 0 end) ['+ mm +']' ");
            //strSql.Append("        from (select distinct mm from #t)as data ");
            //strSql.Append("    set @sql = @sql + ' from #t group by " + items + "' ");

            //strSql.Append("    exec(@sql) ");
            //strSql.Append(" end ");
            ////strSql.Append("go");
            strSql.Append("   select " + items + " as items ,");
            strSql.Append(" 	MAX(CASE mm WHEN '1' THEN tNum ELSE 0 END ) 'm1',       ");
            strSql.Append("     MAX(CASE mm WHEN '2' THEN tNum ELSE 0 END ) 'm2',       ");
            strSql.Append("     MAX(CASE mm WHEN '3' THEN tNum ELSE 0 END ) 'm3',       ");
            strSql.Append("     MAX(CASE mm WHEN '4' THEN tNum ELSE 0 END ) 'm4',       ");
            strSql.Append("     MAX(CASE mm WHEN '5' THEN tNum ELSE 0 END ) 'm5',       ");
            strSql.Append("     MAX(CASE mm WHEN '6' THEN tNum ELSE 0 END ) 'm6',       ");
            strSql.Append("     MAX(CASE mm WHEN '7' THEN tNum ELSE 0 END ) 'm7',       ");
            strSql.Append("     MAX(CASE mm WHEN '8' THEN tNum ELSE 0 END ) 'm8',       ");
            strSql.Append("     MAX(CASE mm WHEN '9' THEN tNum ELSE 0 END ) 'm9',       ");
            strSql.Append("     MAX(CASE mm WHEN '10' THEN tNum ELSE 0 END ) 'm10',     ");
            strSql.Append("     MAX(CASE mm WHEN '11' THEN tNum ELSE 0 END ) 'm11',     ");
            strSql.Append("     MAX(CASE mm WHEN '12' THEN tNum ELSE 0 END ) 'm12'      ");
            strSql.Append(" from");
            strSql.Append("    (select ");
            strSql.Append(" (case (ISNULL(" + items + ") || LENGTH(trim(" + items + "))<1) when 1  then '未分类' else " + items + "  end)  as  " + items + ",  ");
            strSql.Append("    month(Follow_date) mm,count(id)tNum ");
            //strSql.Append("        " + items + ",month(Follow_date) mm,count(id)tNum  ");
            strSql.Append("    from CRM_Follow ");
            strSql.Append("    where  year(Follow_date)=" + year);
            if (where.Trim() != "")
            {
                strSql.Append(" and " + where);
            }
            strSql.Append("    group by (case (ISNULL(" + items + ") || LENGTH(trim(" + items + "))<1) when 1  then '未分类' else " + items + "  end),month(Follow_date)) tt ");
            strSql.Append(" group by " + items + "  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }


        public DataSet Reports_month(string items, int year,int month, string where)
        {
            StringBuilder strSql = new StringBuilder();      
            strSql.Append("   select " + items + " as items ,");
            strSql.Append(" 	MAX(CASE dd WHEN '1' THEN tNum ELSE 0 END ) 'd1',       ");
            strSql.Append("     MAX(CASE dd WHEN '2' THEN tNum ELSE 0 END ) 'd2',       ");
            strSql.Append("     MAX(CASE dd WHEN '3' THEN tNum ELSE 0 END ) 'd3',       ");
            strSql.Append("     MAX(CASE dd WHEN '4' THEN tNum ELSE 0 END ) 'd4',       ");
            strSql.Append("     MAX(CASE dd WHEN '5' THEN tNum ELSE 0 END ) 'd5',       ");
            strSql.Append("     MAX(CASE dd WHEN '6' THEN tNum ELSE 0 END ) 'd6',       ");
            strSql.Append("     MAX(CASE dd WHEN '7' THEN tNum ELSE 0 END ) 'd7',       ");
            strSql.Append("     MAX(CASE dd WHEN '8' THEN tNum ELSE 0 END ) 'd8',       ");
            strSql.Append("     MAX(CASE dd WHEN '9' THEN tNum ELSE 0 END ) 'd9',       ");
            strSql.Append("     MAX(CASE dd WHEN '10' THEN tNum ELSE 0 END ) 'd10',     ");
            strSql.Append("     MAX(CASE dd WHEN '11' THEN tNum ELSE 0 END ) 'd11',     ");
            strSql.Append("     MAX(CASE dd WHEN '12' THEN tNum ELSE 0 END ) 'd12',      ");
            strSql.Append("     MAX(CASE dd WHEN '13' THEN tNum ELSE 0 END ) 'd13',      ");
            strSql.Append("     MAX(CASE dd WHEN '14' THEN tNum ELSE 0 END ) 'd14',      ");
            strSql.Append("     MAX(CASE dd WHEN '15' THEN tNum ELSE 0 END ) 'd15',      ");
            strSql.Append("     MAX(CASE dd WHEN '16' THEN tNum ELSE 0 END ) 'd16',      ");
            strSql.Append("     MAX(CASE dd WHEN '17' THEN tNum ELSE 0 END ) 'd17',      ");
            strSql.Append("     MAX(CASE dd WHEN '18' THEN tNum ELSE 0 END ) 'd18',      ");
            strSql.Append("     MAX(CASE dd WHEN '19' THEN tNum ELSE 0 END ) 'd19',      ");
            strSql.Append("     MAX(CASE dd WHEN '20' THEN tNum ELSE 0 END ) 'd20',      ");
            strSql.Append("     MAX(CASE dd WHEN '21' THEN tNum ELSE 0 END ) 'd21',      ");
            strSql.Append("     MAX(CASE dd WHEN '22' THEN tNum ELSE 0 END ) 'd22',      ");
            strSql.Append("     MAX(CASE dd WHEN '23' THEN tNum ELSE 0 END ) 'd23',      ");
            strSql.Append("     MAX(CASE dd WHEN '24' THEN tNum ELSE 0 END ) 'd24',      ");
            strSql.Append("     MAX(CASE dd WHEN '25' THEN tNum ELSE 0 END ) 'd25',      ");
            strSql.Append("     MAX(CASE dd WHEN '26' THEN tNum ELSE 0 END ) 'd26',      ");
            strSql.Append("     MAX(CASE dd WHEN '27' THEN tNum ELSE 0 END ) 'd27',      ");
            strSql.Append("     MAX(CASE dd WHEN '28' THEN tNum ELSE 0 END ) 'd28',      ");
            strSql.Append("     MAX(CASE dd WHEN '29' THEN tNum ELSE 0 END ) 'd29',      ");
            strSql.Append("     MAX(CASE dd WHEN '30' THEN tNum ELSE 0 END ) 'd30',      ");
            strSql.Append("     MAX(CASE dd WHEN '31' THEN tNum ELSE 0 END ) 'd31'      ");
            strSql.Append(" from");
            strSql.Append("    (select ");
            strSql.Append(" (case (ISNULL(" + items + ") || LENGTH(trim(" + items + "))<1) when 1  then '未分类' else " + items + "  end)  as  " + items + ",  ");
            strSql.Append("    DAYOFMONTH(Follow_date) dd,count(id)tNum ");     
            //strSql.Append("        " + items + ",month(Follow_date) mm,count(id)tNum  ");
            strSql.Append("    from CRM_Follow ");
  
            strSql.Append("    where year(Follow_date)='" + year + "' and month(Follow_date)='" + month + "' ");
            if (where.Trim() != "")
            {
                strSql.Append(" and " + where);
            }
            strSql.Append("    group by (case (ISNULL(" + items + ") || LENGTH(trim(" + items + "))<1) when 1  then '未分类' else " + items + "  end),DAYOFMONTH(Follow_date)) tt ");
            strSql.Append(" group by " + items + "  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 客户跟进【同比环比】
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public DataSet Compared_follow(string year1, string month1, string year2, string month2, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select (case (ISNULL(Follow_Type) || LENGTH(trim(Follow_Type))<1) when 1  then '未分类' else Follow_Type end) as yy,");
            strSql.Append(" count(Follow_Type) as xx,");
            strSql.Append(" SUM(case when YEAR( Follow_date)=('" + year1 + "') and MONTH(Follow_date)=('" + month1 + "') then 1 else 0 end) as dt1, ");
            strSql.Append(" SUM(case when YEAR( Follow_date)=('" + year2 + "') and MONTH(Follow_date)=('" + month2 + "') then 1 else 0 end) as dt2 ");
            strSql.Append(" FROM CRM_Follow ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" group by (case (ISNULL(Follow_Type) || LENGTH(trim(Follow_Type))<1) when 1  then '未分类' else Follow_Type end)");
            
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet Compared_empcusfollow(string year1, string month1, string year2, string month2, string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select hr_employee.name as yy,");
            strSql.Append(" SUM(case when YEAR( CRM_Follow.Follow_date)=('" + year1 + "') and MONTH(CRM_Follow.Follow_date)=('" + month1 + "') then 1 else 0 end) as dt1, ");
            strSql.Append(" SUM(case when YEAR( CRM_Follow.Follow_date)=('" + year2 + "') and MONTH(CRM_Follow.Follow_date)=('" + month2 + "') then 1 else 0 end) as dt2 ");
            strSql.Append(" from hr_employee left outer join CRM_Follow ");
            strSql.Append(" on hr_employee.ID=CRM_Follow.employee_id ");
            strSql.Append(" where hr_employee.ID in " + idlist);
            strSql.Append(" group by hr_employee.name,hr_employee.ID ");
            strSql.Append(" order by hr_employee.ID");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 客户跟进统计
        /// </summary>
        /// <param name="year"></param>
        /// <param name="idlist"></param>
        /// <returns></returns>
        public DataSet report_empfollow(int year, string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select id,name,yy,");
            strSql.Append(" MAX(CASE mm WHEN '1' THEN cn ELSE 0 END ) 'm1',      ");
            strSql.Append(" MAX(CASE mm WHEN '2' THEN cn ELSE 0 END ) 'm2',      ");
            strSql.Append(" MAX(CASE mm WHEN '3' THEN cn ELSE 0 END ) 'm3',      ");
            strSql.Append(" MAX(CASE mm WHEN '4' THEN cn ELSE 0 END ) 'm4',      ");
            strSql.Append(" MAX(CASE mm WHEN '5' THEN cn ELSE 0 END ) 'm5',      ");
            strSql.Append(" MAX(CASE mm WHEN '6' THEN cn ELSE 0 END ) 'm6',      ");
            strSql.Append(" MAX(CASE mm WHEN '7' THEN cn ELSE 0 END ) 'm7',      ");
            strSql.Append(" MAX(CASE mm WHEN '8' THEN cn ELSE 0 END ) 'm8',      ");
            strSql.Append(" MAX(CASE mm WHEN '9' THEN cn ELSE 0 END ) 'm9',      ");
            strSql.Append(" MAX(CASE mm WHEN '10' THEN cn ELSE 0 END ) 'm10',    ");
            strSql.Append(" MAX(CASE mm WHEN '11' THEN cn ELSE 0 END ) 'm11',    ");
            strSql.Append(" MAX(CASE mm WHEN '12' THEN cn ELSE 0 END ) 'm12'     ");
            strSql.Append(" from");
            strSql.Append(" (SELECT   hr_employee.ID, hr_employee.name, COUNT(derivedtbl_1.id) AS cn, YEAR(derivedtbl_1.Follow_date) AS yy, ");
            strSql.Append(" MONTH(derivedtbl_1.Follow_date) AS mm");
            strSql.Append(" FROM      hr_employee LEFT OUTER JOIN");
            strSql.Append("  (SELECT   id, employee_id, Follow_date");
            strSql.Append("  FROM      CRM_Follow");
            strSql.Append("  WHERE  ifnull(isdelete,0)=0 and (YEAR(Follow_date) = '" + year + "')) AS derivedtbl_1 ON hr_employee.ID = derivedtbl_1.employee_id");
            strSql.Append(" WHERE hr_employee.ID in " + idlist);
            strSql.Append(" GROUP BY hr_employee.ID, hr_employee.name, YEAR(derivedtbl_1.Follow_date), MONTH(derivedtbl_1.Follow_date)) as tt");
            strSql.Append(" group by id,name,yy ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        //客户跟踪统计
        public DataSet report_empfollow_month(int year,int months, string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select id,name,yy,mm,");
            strSql.Append(" 	MAX(CASE dd WHEN '1' THEN tNum ELSE 0 END ) 'd1',       ");
            strSql.Append("     MAX(CASE dd WHEN '2' THEN tNum ELSE 0 END ) 'd2',       ");
            strSql.Append("     MAX(CASE dd WHEN '3' THEN tNum ELSE 0 END ) 'd3',       ");
            strSql.Append("     MAX(CASE dd WHEN '4' THEN tNum ELSE 0 END ) 'd4',       ");
            strSql.Append("     MAX(CASE dd WHEN '5' THEN tNum ELSE 0 END ) 'd5',       ");
            strSql.Append("     MAX(CASE dd WHEN '6' THEN tNum ELSE 0 END ) 'd6',       ");
            strSql.Append("     MAX(CASE dd WHEN '7' THEN tNum ELSE 0 END ) 'd7',       ");
            strSql.Append("     MAX(CASE dd WHEN '8' THEN tNum ELSE 0 END ) 'd8',       ");
            strSql.Append("     MAX(CASE dd WHEN '9' THEN tNum ELSE 0 END ) 'd9',       ");
            strSql.Append("     MAX(CASE dd WHEN '10' THEN tNum ELSE 0 END ) 'd10',     ");
            strSql.Append("     MAX(CASE dd WHEN '11' THEN tNum ELSE 0 END ) 'd11',     ");
            strSql.Append("     MAX(CASE dd WHEN '12' THEN tNum ELSE 0 END ) 'd12',      ");
            strSql.Append("     MAX(CASE dd WHEN '13' THEN tNum ELSE 0 END ) 'd13',      ");
            strSql.Append("     MAX(CASE dd WHEN '14' THEN tNum ELSE 0 END ) 'd14',      ");
            strSql.Append("     MAX(CASE dd WHEN '15' THEN tNum ELSE 0 END ) 'd15',      ");
            strSql.Append("     MAX(CASE dd WHEN '16' THEN tNum ELSE 0 END ) 'd16',      ");
            strSql.Append("     MAX(CASE dd WHEN '17' THEN tNum ELSE 0 END ) 'd17',      ");
            strSql.Append("     MAX(CASE dd WHEN '18' THEN tNum ELSE 0 END ) 'd18',      ");
            strSql.Append("     MAX(CASE dd WHEN '19' THEN tNum ELSE 0 END ) 'd19',      ");
            strSql.Append("     MAX(CASE dd WHEN '20' THEN tNum ELSE 0 END ) 'd20',      ");
            strSql.Append("     MAX(CASE dd WHEN '21' THEN tNum ELSE 0 END ) 'd21',      ");
            strSql.Append("     MAX(CASE dd WHEN '22' THEN tNum ELSE 0 END ) 'd22',      ");
            strSql.Append("     MAX(CASE dd WHEN '23' THEN tNum ELSE 0 END ) 'd23',      ");
            strSql.Append("     MAX(CASE dd WHEN '24' THEN tNum ELSE 0 END ) 'd24',      ");
            strSql.Append("     MAX(CASE dd WHEN '25' THEN tNum ELSE 0 END ) 'd25',      ");
            strSql.Append("     MAX(CASE dd WHEN '26' THEN tNum ELSE 0 END ) 'd26',      ");
            strSql.Append("     MAX(CASE dd WHEN '27' THEN tNum ELSE 0 END ) 'd27',      ");
            strSql.Append("     MAX(CASE dd WHEN '28' THEN tNum ELSE 0 END ) 'd28',      ");
            strSql.Append("     MAX(CASE dd WHEN '29' THEN tNum ELSE 0 END ) 'd29',      ");
            strSql.Append("     MAX(CASE dd WHEN '30' THEN tNum ELSE 0 END ) 'd30',      ");
            strSql.Append("     MAX(CASE dd WHEN '31' THEN tNum ELSE 0 END ) 'd31'      ");
            strSql.Append(" from");
            strSql.Append(" (SELECT   hr_employee.ID, hr_employee.name, COUNT(derivedtbl_1.id) AS tNum, YEAR(derivedtbl_1.Follow_date) AS yy, ");
            strSql.Append(" MONTH(derivedtbl_1.Follow_date) AS mm,DAYOFMONTH(derivedtbl_1.Follow_date) AS dd");
            strSql.Append(" FROM      hr_employee LEFT OUTER JOIN");
            strSql.Append("  (SELECT   id, employee_id, Follow_date");
            strSql.Append("  FROM      CRM_Follow");
            strSql.Append("  WHERE  ifnull(isdelete,0)=0 and (YEAR(Follow_date) = '" + year + "') and (month(Follow_date)='" + months + "') " + ") AS derivedtbl_1 ON hr_employee.ID = derivedtbl_1.employee_id");
            strSql.Append(" WHERE hr_employee.ID in " + idlist);
            strSql.Append(" GROUP BY hr_employee.ID, hr_employee.name, YEAR(derivedtbl_1.Follow_date), MONTH(derivedtbl_1.Follow_date),DAYOFMONTH(derivedtbl_1.Follow_date)) as tt");
            strSql.Append(" group by id,name,yy,mm ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
		#endregion  Method
	}
}

