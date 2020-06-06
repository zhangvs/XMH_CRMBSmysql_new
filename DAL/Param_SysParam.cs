using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// ���ݷ�����:Param_SysParam
    /// </summary>
    public partial class Param_SysParam
    {
        public Param_SysParam()
        { }
        #region  Method

        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "Param_SysParam");
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Param_SysParam");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(XHD.Model.Param_SysParam model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Param_SysParam(");
            strSql.Append("Factory_Id,parentid,params_name,params_order,Create_id,Create_date,Update_id,Update_date)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@parentid,@params_name,@params_order,@Create_id,@Create_date,@Update_id,@Update_date)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@parentid", MySqlDbType.Int32,4),
					new MySqlParameter("@params_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@params_order", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@Update_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Update_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.parentid;
            parameters[2].Value = model.params_name;
            parameters[3].Value = model.params_order;
            parameters[4].Value = model.Create_id;
            parameters[5].Value = model.Create_date;
            parameters[6].Value = model.Update_id;
            parameters[7].Value = model.Update_date;

            object obj = DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        /// ����һ������
        /// </summary>
        public bool Update(XHD.Model.Param_SysParam model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Param_SysParam set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("parentid=@parentid,");
            strSql.Append("params_name=@params_name,");
            strSql.Append("params_order=@params_order,");
            strSql.Append("Create_id=@Create_id,");
            strSql.Append("Create_date=@Create_date,");
            strSql.Append("Update_id=@Update_id,");
            strSql.Append("Update_date=@Update_date");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@parentid", MySqlDbType.Int32,4),
					new MySqlParameter("@params_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@params_order", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@Update_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Update_date", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.parentid;
            parameters[2].Value = model.params_name;
            parameters[3].Value = model.params_order;
            parameters[4].Value = model.Create_id;
            parameters[5].Value = model.Create_date;
            parameters[6].Value = model.Update_id;
            parameters[7].Value = model.Update_date;
            parameters[8].Value = model.id;

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
        /// Ԥɾ��
        /// </summary>
        public bool AdvanceDelete(int id, int isDelete, string time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Param_SysParam set ");
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
        /// ɾ��һ������
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Param_SysParam ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = id;

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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Param_SysParam ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        /// �õ�һ������ʵ��
        /// </summary>
        public XHD.Model.Param_SysParam GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,parentid,params_name,params_order,Create_id,Create_date,Update_id,Update_date from Param_SysParam ");
            strSql.Append(" where id=@id limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = id;

            XHD.Model.Param_SysParam model = new XHD.Model.Param_SysParam();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["parentid"] != null && ds.Tables[0].Rows[0]["parentid"].ToString() != "")
                {
                    model.parentid = int.Parse(ds.Tables[0].Rows[0]["parentid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["params_name"] != null && ds.Tables[0].Rows[0]["params_name"].ToString() != "")
                {
                    model.params_name = ds.Tables[0].Rows[0]["params_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["params_order"] != null && ds.Tables[0].Rows[0]["params_order"].ToString() != "")
                {
                    model.params_order = int.Parse(ds.Tables[0].Rows[0]["params_order"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Create_id"] != null && ds.Tables[0].Rows[0]["Create_id"].ToString() != "")
                {
                    model.Create_id = int.Parse(ds.Tables[0].Rows[0]["Create_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Create_date"] != null && ds.Tables[0].Rows[0]["Create_date"].ToString() != "")
                {
                    model.Create_date = DateTime.Parse(ds.Tables[0].Rows[0]["Create_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Update_id"] != null && ds.Tables[0].Rows[0]["Update_id"].ToString() != "")
                {
                    model.Update_id = int.Parse(ds.Tables[0].Rows[0]["Update_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Update_date"] != null && ds.Tables[0].Rows[0]["Update_date"].ToString() != "")
                {
                    model.Update_date = DateTime.Parse(ds.Tables[0].Rows[0]["Update_date"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,parentid,params_name,params_order,Create_id,Create_date,Update_id,Update_date ");
            strSql.Append(" FROM Param_SysParam ");
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
            strSql.Append(" id,Factory_Id,parentid,params_name,params_order,Create_id,Create_date,Update_id,Update_date ");
            strSql.Append(" FROM Param_SysParam ");
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
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  * FROM Param_SysParam ");
            //strSql.Append(" WHERE id not in ( SELECT id FROM Param_SysParam  limit " + (PageIndex - 1) * PageSize + " ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM Param_SysParam ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// �ɲ����������ID
        /// </summary>
        /// <param name="params_name"></param>
        /// <param name="factory_Id"></param>
        /// <returns></returns>
        public int GetIdByName(string params_name, string factory_Id)
        {
            string sql = "select id from param_sysparam where params_name=@params_name and Factory_Id=@Factory_Id";
            MySqlParameter[] param = { 
                                     new MySqlParameter("@params_name",params_name),
                                     new MySqlParameter("@Factory_Id",factory_Id)
                                  };
            if (DbHelperMySQL.GetSingle(sql, param) != null)
            {
                return (int)DbHelperMySQL.GetSingle(sql, param);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// �ɲ����������ID
        /// </summary>
        /// <param name="params_name"></param>
        /// <returns></returns>
        public int GetIdByName(string params_name)
        {
            string sql = "select id from param_sysparam where params_name='" + params_name + "'";

            if (DbHelperMySQL.GetSingle(sql) != null)
            {
                return (int)DbHelperMySQL.GetSingle(sql);
            }
            else
            {
                return 0;
            }
        }

        #endregion  Method
    }
}

