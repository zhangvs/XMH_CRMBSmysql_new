using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// ���ݷ�����:CRM_contract_attachment
    /// </summary>
    public partial class CRM_contract_attachment
    {
        public CRM_contract_attachment()
        { }
        #region  Method

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(XHD.Model.CRM_contract_attachment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CRM_contract_attachment(");
            strSql.Append("contract_id,page_id,file_id,file_name,real_name,file_size,create_id,create_name,create_date)");
            strSql.Append(" values (");
            strSql.Append("@contract_id,@page_id,@file_id,@file_name,@real_name,@file_size,@create_id,@create_name,@create_date)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@contract_id", MySqlDbType.Int32,4),
					new MySqlParameter("@page_id", MySqlDbType.VarChar,250),
					new MySqlParameter("@file_id", MySqlDbType.VarChar,250),
					new MySqlParameter("@file_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@real_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@file_size", MySqlDbType.Int32,4),
					new MySqlParameter("@create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.contract_id;
            parameters[1].Value = model.page_id;
            parameters[2].Value = model.file_id;
            parameters[3].Value = model.file_name;
            parameters[4].Value = model.real_name;
            parameters[5].Value = model.file_size;
            parameters[6].Value = model.create_id;
            parameters[7].Value = model.create_name;
            parameters[8].Value = model.create_date;

            DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public bool Delete(string wherestr)
        {
            //�ñ���������Ϣ�����Զ�������/�����ֶ�
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CRM_contract_attachment ");
            strSql.Append(" where " + wherestr);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM CRM_contract_attachment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
       
            strSql.Append(" * ");
            strSql.Append(" FROM CRM_contract_attachment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ����ID
        /// </summary>
        public bool UpdateMailid(int contract_id, string page_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_contract_attachment set ");
            strSql.Append("contract_id=" + contract_id);
            strSql.Append(" where ");
            strSql.Append("page_id=" + page_id);

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
        #endregion  Method
    }
}

