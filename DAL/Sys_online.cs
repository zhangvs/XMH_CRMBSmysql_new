using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// ���ݷ�����:Sys_online
	/// </summary>
	public partial class Sys_online
	{
		public Sys_online()
		{}
		#region  Method



		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(XHD.Model.Sys_online model)
		{
            //StringBuilder strSql=new StringBuilder();
            //strSql.Append("insert into Sys_online(");
            //strSql.Append("UserID,UserName,LastLogTime)");
            //strSql.Append(" values (");
            //strSql.Append("@UserID,@UserName,@LastLogTime)");
            //MySqlParameter[] parameters = {
            //        new MySqlParameter("@UserID", MySqlDbType.Int32,4),
            //        new MySqlParameter("@UserName", MySqlDbType.VarChar,50),
            //        new MySqlParameter("@LastLogTime", MySqlDbType.DateTime)};
            //parameters[0].Value = model.UserID;
            //parameters[1].Value = model.UserName;
            //parameters[2].Value = model.LastLogTime;

			//DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);

            //Robert 2015-11-23

            string strSql = string.Format(@"insert into Sys_online(UserID,UserName,LastLogTime) values ('{0}','{1}','{2}')",
                                            model.UserID, model.UserName, model.LastLogTime);

            DbHelperMySQL.ExecuteSql(strSql.ToString());
		}
        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Update(XHD.Model.Sys_online model, string where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_online set ");
            strSql.Append("UserID=@UserID,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("LastLogTime=@LastLogTime");
            strSql.Append(" where " + where);
            MySqlParameter[] parameters = {
					new MySqlParameter("@UserID", MySqlDbType.Int32,4),
					new MySqlParameter("@UserName", MySqlDbType.VarChar,50),
					new MySqlParameter("@LastLogTime", MySqlDbType.DateTime)
                                        };
            parameters[0].Value = model.UserID;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.LastLogTime;

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
        /// ɾ��һ������
        /// </summary>
        public bool Delete(string wherestr)
        {
            //�ñ���������Ϣ�����Զ�������/�����ֶ�
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_online ");
            strSql.Append(" where " + wherestr + "  ");
            MySqlParameter[] parameters = {
};

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
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select UserID,UserName,LastLogTime ");
			strSql.Append(" FROM Sys_online ");
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
			
			strSql.Append(" UserID,UserName,LastLogTime ");
			strSql.Append(" FROM Sys_online ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
            }
			return DbHelperMySQL.Query(strSql.ToString());
		}

	

		#endregion  Method
	}
}

