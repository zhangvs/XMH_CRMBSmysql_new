using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// 数据访问类:Sys_data_authority
	/// </summary>
	public partial class Sys_data_authority
	{
		public Sys_data_authority()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(XHD.Model.Sys_data_authority model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sys_data_authority(");
            strSql.Append("Role_id,option_id,Sys_option,Sys_view,Sys_add,Sys_edit,Sys_del,Create_id,Create_date,Factory_Id,Type)");
			strSql.Append(" values (");
            strSql.Append("@Role_id,@option_id,@Sys_option,@Sys_view,@Sys_add,@Sys_edit,@Sys_del,@Create_id,@Create_date,@Factory_Id,@Type)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Role_id", MySqlDbType.Int32,4),
					new MySqlParameter("@option_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Sys_option", MySqlDbType.VarChar,250),
					new MySqlParameter("@Sys_view", MySqlDbType.Int32,4),
					new MySqlParameter("@Sys_add", MySqlDbType.Int32,4),
					new MySqlParameter("@Sys_edit", MySqlDbType.Int32,4),
					new MySqlParameter("@Sys_del", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
                    new MySqlParameter("@Type", MySqlDbType.Int32,4)                    };
			parameters[0].Value = model.Role_id;
			parameters[1].Value = model.option_id;
			parameters[2].Value = model.Sys_option;
			parameters[3].Value = model.Sys_view;
			parameters[4].Value = model.Sys_add;
			parameters[5].Value = model.Sys_edit;
			parameters[6].Value = model.Sys_del;
			parameters[7].Value = model.Create_id;
			parameters[8].Value = model.Create_date;
            parameters[9].Value = model.Factory_id;
            parameters[10].Value = model.Type;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

        /// <summary> 
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet authList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  max(Sys_view),max(Sys_add),max(Sys_edit),max(Sys_del)  ");
            strSql.Append(" FROM Sys_data_authority ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string where)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sys_data_authority ");
			strSql.Append(" where "+where);
			MySqlParameter[] parameters = {};

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
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select Factory_Id,Type, Role_id,option_id,Sys_option,Sys_view,Sys_add,Sys_edit,Sys_del,Create_id,Create_date,Factory_Id ");
			strSql.Append(" FROM Sys_data_authority ");
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

            strSql.Append(" Role_id,option_id,Sys_option,Sys_view,Sys_add,Sys_edit,Sys_del,Create_id,Create_date,Factory_Id ");
			strSql.Append(" FROM Sys_data_authority ");
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

		#endregion  Method
	}
}

