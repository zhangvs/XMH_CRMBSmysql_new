using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.Model;
using XHD.DBUtility;
//using Maticsoft.DBUtility;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// 数据访问类:crm_oa_boardroom
	/// </summary>
	public partial class crm_oa_boardroom
	{
		public crm_oa_boardroom()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "crm_oa_boardroom"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from crm_oa_boardroom");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(XHD.Model.crm_oa_boardroom model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into crm_oa_boardroom(");
            strSql.Append("Id,factory_Id,room_name,N_room_seat,N_projector,N_whiteboard,C_room_manageId,C_room_manageName,C_createId,C_createName,C_createDate,F_room_acreage,room_status,need_score)");
			strSql.Append(" values (");
            strSql.Append("@Id,@factory_Id,@room_name,@N_room_seat,@N_projector,@N_whiteboard,@C_room_manageId,@C_room_manageName,@C_createId,@C_createName,@C_createDate,@F_room_acreage,@room_status,@need_score)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@room_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@N_room_seat", MySqlDbType.Int32,11),
					new MySqlParameter("@N_projector", MySqlDbType.Int32,11),
					new MySqlParameter("@N_whiteboard", MySqlDbType.Int32,11),
					new MySqlParameter("@C_room_manageId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_room_manageName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
                    new MySqlParameter("@F_room_acreage", MySqlDbType.Double,18),
                    new MySqlParameter("@room_status", MySqlDbType.VarChar,1),
                    new MySqlParameter("@need_score", MySqlDbType.Int32,11)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.factory_Id;
			parameters[2].Value = model.room_name;
			parameters[3].Value = model.N_room_seat;
			parameters[4].Value = model.N_projector;
			parameters[5].Value = model.N_whiteboard;
			parameters[6].Value = model.C_room_manageId;
			parameters[7].Value = model.C_room_manageName;
			parameters[8].Value = model.C_createId;
			parameters[9].Value = model.C_createName;
			parameters[10].Value = model.C_createDate;
            parameters[11].Value = model.F_room_acreage;
            parameters[12].Value = model.Room_status;
            parameters[13].Value = model.Need_score;
			int i=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
            return i;
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(XHD.Model.crm_oa_boardroom model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update crm_oa_boardroom set ");
			strSql.Append("factory_Id=@factory_Id,");
			strSql.Append("room_name=@room_name,");
			strSql.Append("N_room_seat=@N_room_seat,");
			strSql.Append("N_projector=@N_projector,");
			strSql.Append("N_whiteboard=@N_whiteboard,");
			strSql.Append("C_room_manageId=@C_room_manageId,");
			strSql.Append("C_room_manageName=@C_room_manageName,");
			strSql.Append("C_createId=@C_createId,");
			strSql.Append("C_createName=@C_createName,");
			strSql.Append("C_createDate=@C_createDate,");
             strSql.Append("F_room_acreage=@F_room_acreage");
             strSql.Append("room_status=@room_status");
             strSql.Append("need_score=@need_score");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@room_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@N_room_seat", MySqlDbType.Int32,11),
					new MySqlParameter("@N_projector", MySqlDbType.Int32,11),
					new MySqlParameter("@N_whiteboard", MySqlDbType.Int32,11),
					new MySqlParameter("@C_room_manageId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_room_manageName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
                     new MySqlParameter("@F_room_acreage", MySqlDbType.Double,18),
                   new MySqlParameter("@room_status", MySqlDbType.VarChar,1),
                    new MySqlParameter("@need_score", MySqlDbType.Int32,11)};
			parameters[0].Value = model.factory_Id;
			parameters[1].Value = model.room_name;
			parameters[2].Value = model.N_room_seat;
			parameters[3].Value = model.N_projector;
			parameters[4].Value = model.N_whiteboard;
			parameters[5].Value = model.C_room_manageId;
			parameters[6].Value = model.C_room_manageName;
			parameters[7].Value = model.C_createId;
			parameters[8].Value = model.C_createName;
			parameters[9].Value = model.C_createDate;
			parameters[10].Value = model.Id;
            parameters[11].Value = model.F_room_acreage;
            parameters[12].Value = model.Room_status;
            parameters[13].Value = model.Need_score;
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
			strSql.Append("delete from crm_oa_boardroom ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
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
			strSql.Append("delete from crm_oa_boardroom ");
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
        public XHD.Model.crm_oa_boardroom GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select Id,F_room_acreage,factory_Id,room_name,N_room_seat,N_projector,N_whiteboard,C_room_manageId,C_room_manageName,C_createId,C_createName,C_createDate,room_status,need_score from crm_oa_boardroom ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = Id;

            XHD.Model.crm_oa_boardroom model = new XHD.Model.crm_oa_boardroom();
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
				if(ds.Tables[0].Rows[0]["room_name"]!=null && ds.Tables[0].Rows[0]["room_name"].ToString()!="")
				{
					model.room_name=ds.Tables[0].Rows[0]["room_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["N_room_seat"]!=null && ds.Tables[0].Rows[0]["N_room_seat"].ToString()!="")
				{
					model.N_room_seat=int.Parse(ds.Tables[0].Rows[0]["N_room_seat"].ToString());
				}
				if(ds.Tables[0].Rows[0]["N_projector"]!=null && ds.Tables[0].Rows[0]["N_projector"].ToString()!="")
				{
					model.N_projector=int.Parse(ds.Tables[0].Rows[0]["N_projector"].ToString());
				}
				if(ds.Tables[0].Rows[0]["N_whiteboard"]!=null && ds.Tables[0].Rows[0]["N_whiteboard"].ToString()!="")
				{
					model.N_whiteboard=int.Parse(ds.Tables[0].Rows[0]["N_whiteboard"].ToString());
				}
				if(ds.Tables[0].Rows[0]["C_room_manageId"]!=null && ds.Tables[0].Rows[0]["C_room_manageId"].ToString()!="")
				{
					model.C_room_manageId=int.Parse(ds.Tables[0].Rows[0]["C_room_manageId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["C_room_manageName"]!=null && ds.Tables[0].Rows[0]["C_room_manageName"].ToString()!="")
				{
					model.C_room_manageName=ds.Tables[0].Rows[0]["C_room_manageName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["C_createId"]!=null && ds.Tables[0].Rows[0]["C_createId"].ToString()!="")
				{
					model.C_createId=int.Parse(ds.Tables[0].Rows[0]["C_createId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["C_createName"]!=null && ds.Tables[0].Rows[0]["C_createName"].ToString()!="")
				{
					model.C_createName=ds.Tables[0].Rows[0]["C_createName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["C_createDate"]!=null && ds.Tables[0].Rows[0]["C_createDate"].ToString()!="")
				{
					model.C_createDate=DateTime.Parse(ds.Tables[0].Rows[0]["C_createDate"].ToString());
				}
                if (ds.Tables[0].Rows[0]["F_room_acreage"] != null && ds.Tables[0].Rows[0]["F_room_acreage"].ToString() != "")
                {
                    model.F_room_acreage = double.Parse(ds.Tables[0].Rows[0]["F_room_acreage"].ToString());
                }
                if (ds.Tables[0].Rows[0]["room_status"] != null && ds.Tables[0].Rows[0]["room_status"].ToString() != "")
                {
                    model.F_room_acreage = double.Parse(ds.Tables[0].Rows[0]["room_status"].ToString());
                }
                if (ds.Tables[0].Rows[0]["need_score"] != null && ds.Tables[0].Rows[0]["need_score"].ToString() != "")
                {
                    model.F_room_acreage = double.Parse(ds.Tables[0].Rows[0]["need_score"].ToString());
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
            strSql.Append("select Id,F_room_acreage,factory_Id,room_name,N_room_seat,N_projector,N_whiteboard,C_room_manageId,C_room_manageName,C_createId,C_createName,C_createDate,room_status,need_score ");
			strSql.Append(" FROM crm_oa_boardroom ");
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
            strSql.Append("select  Id,F_room_acreage,factory_Id,room_name,N_room_seat,N_projector,N_whiteboard,C_room_manageId,C_room_manageName,C_createId,C_createName,C_createDate ,room_status,need_score ");
            strSql.Append("  FROM crm_oa_boardroom ");
        
            strSql1.Append(" select count(id) FROM crm_oa_boardroom ");
			if (strWhere.Trim() != "")
			{
			    strSql.Append(" where " + strWhere);
			    strSql1.Append(" where " + strWhere);
			}
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
			Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
			return DbHelperMySQL.Query(strSql.ToString());
		}
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //    MySqlParameter[] parameters = {
        //            new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
        //            new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
        //            new MySqlParameter("@PageSize", MySqlDbType.Int32),
        //            new MySqlParameter("@PageIndex", MySqlDbType.Int32),
        //            new MySqlParameter("@IsReCount", MySqlDbType.Bit),
        //            new MySqlParameter("@OrderType", MySqlDbType.Bit),
        //            new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
        //            };
        //    parameters[0].Value = "crm_oa_boardroom";
        //    parameters[1].Value = "Id";
        //    parameters[2].Value = PageSize;
        //    parameters[3].Value = PageIndex;
        //    parameters[4].Value = 0;
        //    parameters[5].Value = 0;
        //    parameters[6].Value = strWhere;	
        //    return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        //}

        #endregion  Method
    }
}

