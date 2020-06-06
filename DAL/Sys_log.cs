using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// ���ݷ�����:Sys_log
	/// </summary>
	public partial class Sys_log
	{
		public Sys_log()
		{}
		#region  Method

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "Sys_log"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sys_log");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(XHD.Model.Sys_log model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_log(");
            strSql.Append("EventType,EventID,EventTitle,Original_txt,Current_txt,UserID,UserName,IPStreet,EventDate,Factory_Id)");
			strSql.Append(" values (");
            strSql.Append("@EventType,@EventID,@EventTitle,@Original_txt,@Current_txt,@UserID,@UserName,@IPStreet,@EventDate,@Factory_Id)");
			strSql.Append(";select @@IDENTITY");
			MySqlParameter[] parameters = {
					new MySqlParameter("@EventType", MySqlDbType.VarChar,250),
					new MySqlParameter("@EventID", MySqlDbType.VarChar,50),
					new MySqlParameter("@EventTitle", MySqlDbType.VarChar,250),
					new MySqlParameter("@Original_txt", MySqlDbType.VarChar,4000),
					new MySqlParameter("@Current_txt", MySqlDbType.VarChar,4000),
					new MySqlParameter("@UserID", MySqlDbType.Int32,4),
					new MySqlParameter("@UserName", MySqlDbType.VarChar,50),
					new MySqlParameter("@IPStreet", MySqlDbType.VarChar,50),
					new MySqlParameter("@EventDate", MySqlDbType.DateTime),
                    new MySqlParameter("@Factory_Id",MySqlDbType.VarChar,60)};
			parameters[0].Value = model.EventType;
			parameters[1].Value = model.EventID;
			parameters[2].Value = model.EventTitle;
			parameters[3].Value = model.Original_txt;
			parameters[4].Value = model.Current_txt;
			parameters[5].Value = model.UserID;
			parameters[6].Value = model.UserName;
			parameters[7].Value = model.IPStreet;
			parameters[8].Value = model.EventDate;
            parameters[9].Value = model.Factory_Id;
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
        /// ��������б�
        /// </summary>
        public DataSet GetLogtype()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct EventType FROM Sys_log order by EventType");

            return DbHelperMySQL.Query(strSql.ToString());
        }


		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,Factory_Id,EventType,EventID,EventTitle,Original_txt,Current_txt,UserID,UserName,IPStreet,EventDate ");
			strSql.Append(" FROM Sys_log ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			
            strSql.Append(" id,Factory_Id,EventType,EventID,EventTitle,Original_txt,Current_txt,UserID,UserName,IPStreet,EventDate ");
			strSql.Append(" FROM Sys_log ");
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
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
		{
			StringBuilder strSql = new StringBuilder();
			StringBuilder strSql1 = new StringBuilder();
			strSql.Append("select ");
			strSql.Append(" * FROM Sys_log ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Sys_log ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
			strSql1.Append(" select count(id) FROM Sys_log ");
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

