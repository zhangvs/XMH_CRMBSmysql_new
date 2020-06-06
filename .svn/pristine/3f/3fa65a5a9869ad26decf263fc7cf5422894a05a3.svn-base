using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.Model;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{

	/// <summary>
	/// 数据访问类:crm_oa_boardrecord
	/// </summary>
	public partial class crm_oa_boardrecord
	{
		public crm_oa_boardrecord()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "crm_oa_boardrecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from crm_oa_boardrecord");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(XHD.Model.crm_oa_boardrecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into crm_oa_boardrecord(");
			strSql.Append("factory_Id,boardroom_id,boardroom_name,start_time,end_time,status,theme,create_id,create_name,create_date)");
			strSql.Append(" values (");
			strSql.Append("@factory_Id,@boardroom_id,@boardroom_name,@start_time,@end_time,@status,@theme,@create_id,@create_name,@create_date)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@boardroom_id", MySqlDbType.Int32,11),
					new MySqlParameter("@boardroom_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@start_time", MySqlDbType.DateTime),
					new MySqlParameter("@end_time", MySqlDbType.DateTime),
					new MySqlParameter("@status", MySqlDbType.VarChar,1),
					new MySqlParameter("@theme", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)};
			parameters[0].Value = model.factory_Id;
			parameters[1].Value = model.boardroom_id;
			parameters[2].Value = model.boardroom_name;
			parameters[3].Value = model.start_time;
			parameters[4].Value = model.end_time;
			parameters[5].Value = model.status;
			parameters[6].Value = model.theme;
			parameters[7].Value = model.create_id;
			parameters[8].Value = model.create_name;
			parameters[9].Value = model.create_date;

			int i=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
            return i;
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(XHD.Model.crm_oa_boardrecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update crm_oa_boardrecord set ");
			strSql.Append("factory_Id=@factory_Id,");
			strSql.Append("boardroom_id=@boardroom_id,");
			strSql.Append("boardroom_name=@boardroom_name,");
			strSql.Append("start_time=@start_time,");
			strSql.Append("end_time=@end_time,");
			strSql.Append("status=@status,");
			strSql.Append("theme=@theme,");
			strSql.Append("create_id=@create_id,");
			strSql.Append("create_name=@create_name,");
			strSql.Append("create_date=@create_date");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@boardroom_id", MySqlDbType.Int32,11),
					new MySqlParameter("@boardroom_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@start_time", MySqlDbType.DateTime),
					new MySqlParameter("@end_time", MySqlDbType.DateTime),
					new MySqlParameter("@status", MySqlDbType.VarChar,1),
					new MySqlParameter("@theme", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.factory_Id;
			parameters[1].Value = model.boardroom_id;
			parameters[2].Value = model.boardroom_name;
			parameters[3].Value = model.start_time;
			parameters[4].Value = model.end_time;
			parameters[5].Value = model.status;
			parameters[6].Value = model.theme;
			parameters[7].Value = model.create_id;
			parameters[8].Value = model.create_name;
			parameters[9].Value = model.create_date;
			parameters[10].Value = model.Id;

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
        //判断此记录是否存在
        public bool excite(DateTime start,DateTime end,int id) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from crm_oa_boardrecord ");
            strSql.Append(" where (@start between start_time and end_time");
            strSql.Append(" or @end between start_time and end_time)");
            strSql.Append(" and boardroom_id=@room_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@start", MySqlDbType.DateTime),
					new MySqlParameter("@end", MySqlDbType.DateTime),
                  new MySqlParameter("@room_id", MySqlDbType.Int32)
};
            parameters[0].Value = start;
            parameters[1].Value = end;
            parameters[2].Value = id;
            return DbHelperMySQL.Exists(strSql.ToString(), parameters);

        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from crm_oa_boardrecord ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
};
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
        /// 删除一条数据
        /// </summary>
        public bool Delete1(int boardroom_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_oa_boardrecord ");
            strSql.Append(" where boardroom_id=@boardroom_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@boardroom_id", MySqlDbType.Int32)
};
            parameters[0].Value = boardroom_id;

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
			strSql.Append("delete from crm_oa_boardrecord ");
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
		public XHD.Model.crm_oa_boardrecord GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,factory_Id,boardroom_id,boardroom_name,start_time,end_time,status,theme,create_id,create_name,create_date from crm_oa_boardrecord ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
};
			parameters[0].Value = Id;

			XHD.Model.crm_oa_boardrecord model=new XHD.Model.crm_oa_boardrecord();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["factory_Id"]!=null && ds.Tables[0].Rows[0]["factory_Id"].ToString()!="")
				{
					model.factory_Id=ds.Tables[0].Rows[0]["factory_Id"].ToString();
				}
				if(ds.Tables[0].Rows[0]["boardroom_id"]!=null && ds.Tables[0].Rows[0]["boardroom_id"].ToString()!="")
				{
					model.boardroom_id=int.Parse(ds.Tables[0].Rows[0]["boardroom_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["boardroom_name"]!=null && ds.Tables[0].Rows[0]["boardroom_name"].ToString()!="")
				{
					model.boardroom_name=ds.Tables[0].Rows[0]["boardroom_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["start_time"]!=null && ds.Tables[0].Rows[0]["start_time"].ToString()!="")
				{
					model.start_time=DateTime.Parse(ds.Tables[0].Rows[0]["start_time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["end_time"]!=null && ds.Tables[0].Rows[0]["end_time"].ToString()!="")
				{
					model.end_time=DateTime.Parse(ds.Tables[0].Rows[0]["end_time"].ToString());
				}
				if(ds.Tables[0].Rows[0]["status"]!=null && ds.Tables[0].Rows[0]["status"].ToString()!="")
				{
					model.status=ds.Tables[0].Rows[0]["status"].ToString();
				}
				if(ds.Tables[0].Rows[0]["theme"]!=null && ds.Tables[0].Rows[0]["theme"].ToString()!="")
				{
					model.theme=ds.Tables[0].Rows[0]["theme"].ToString();
				}
				if(ds.Tables[0].Rows[0]["create_id"]!=null && ds.Tables[0].Rows[0]["create_id"].ToString()!="")
				{
					model.create_id=int.Parse(ds.Tables[0].Rows[0]["create_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["create_name"]!=null && ds.Tables[0].Rows[0]["create_name"].ToString()!="")
				{
					model.create_name=ds.Tables[0].Rows[0]["create_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["create_date"]!=null && ds.Tables[0].Rows[0]["create_date"].ToString()!="")
				{
					model.create_date=DateTime.Parse(ds.Tables[0].Rows[0]["create_date"].ToString());
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
			strSql.Append("select Id,factory_Id,boardroom_id,boardroom_name,start_time,end_time,status,theme,create_id,create_name,create_date ");
			strSql.Append(" FROM crm_oa_boardrecord ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select Id,factory_Id,boardroom_id,boardroom_name,start_time,end_time,status,theme,create_id,create_name,create_date ");
            strSql.Append("  FROM crm_oa_boardrecord ");

            strSql1.Append(" select count(id) FROM crm_oa_boardrecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
			parameters[0].Value = "crm_oa_boardrecord";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

