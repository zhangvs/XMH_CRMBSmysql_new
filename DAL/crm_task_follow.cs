using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;
using System.Collections.Generic;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_task_follow
    /// </summary>
    public partial class crm_task_follow
    {
        public crm_task_follow()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "crm_task_follow");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_task_follow");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_task_follow model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_task_follow(");
            strSql.Append("id,factory_id,task_id,task_type,follow_time,follow_content,follow_status,follow_status_name,follow_empid,follow_empname)");
            strSql.Append(" values (");
            strSql.Append("@id,@factory_id,@task_id,@task_type,@follow_time,@follow_content,@follow_status,@follow_status_name,@follow_empid,@follow_empname)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@task_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_type", MySqlDbType.VarChar,1),
					new MySqlParameter("@follow_time", MySqlDbType.Int32,11),
					new MySqlParameter("@follow_content", MySqlDbType.Text),
					new MySqlParameter("@follow_status", MySqlDbType.Int32,11),
					new MySqlParameter("@follow_status_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@follow_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@follow_empname", MySqlDbType.VarChar,30)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.factory_id;
            parameters[2].Value = model.task_id;
            parameters[3].Value = model.task_type;
            parameters[4].Value = model.follow_time;
            parameters[5].Value = model.follow_content;
            parameters[6].Value = model.follow_status;
            parameters[7].Value = model.follow_status_name;
            parameters[8].Value = model.follow_empid;
            parameters[9].Value = model.follow_empname;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_task_follow model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_task_follow set ");
            strSql.Append("factory_id=@factory_id,");
            strSql.Append("task_id=@task_id,");
            strSql.Append("task_type=@task_type,");
            strSql.Append("follow_time=@follow_time,");
            strSql.Append("follow_content=@follow_content,");
            strSql.Append("follow_status=@follow_status,");
            strSql.Append("follow_status_name=@follow_status_name,");
            strSql.Append("follow_empid=@follow_empid,");
            strSql.Append("follow_empname=@follow_empname");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@task_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_type", MySqlDbType.VarChar,1),
					new MySqlParameter("@follow_time", MySqlDbType.Int32,11),
					new MySqlParameter("@follow_content", MySqlDbType.Text),
					new MySqlParameter("@follow_status", MySqlDbType.Int32,11),
					new MySqlParameter("@follow_status_name", MySqlDbType.VarChar,10),
					new MySqlParameter("@follow_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@follow_empname", MySqlDbType.VarChar,30),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.task_id;
            parameters[2].Value = model.task_type;
            parameters[3].Value = model.follow_time;
            parameters[4].Value = model.follow_content;
            parameters[5].Value = model.follow_status;
            parameters[6].Value = model.follow_status_name;
            parameters[7].Value = model.follow_empid;
            parameters[8].Value = model.follow_empname;
            parameters[9].Value = model.id;

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_task_follow ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_task_follow ");
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
        /// 批量删除数据
        /// </summary>
        public bool Delete(string idlist, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_task_follow ");
            strSql.Append(" where task_id in (" + idlist + ")  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(strWhere);
            }
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
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.crm_task_follow GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,factory_id,task_id,task_type,follow_time,follow_content,follow_status,follow_status_name,follow_empid,follow_empname from crm_task_follow ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.crm_task_follow model = new XHD.Model.crm_task_follow();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public XHD.Model.crm_task_follow DataRowToModel(DataRow row)
        {
            XHD.Model.crm_task_follow model = new XHD.Model.crm_task_follow();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
                }
                if (row["task_id"] != null && row["task_id"].ToString() != "")
                {
                    model.task_id = int.Parse(row["task_id"].ToString());
                }
                if (row["task_type"] != null)
                {
                    model.task_type = row["task_type"].ToString();
                }
                if (row["follow_time"] != null && row["follow_time"].ToString() != "")
                {
                    model.follow_time = int.Parse(row["follow_time"].ToString());
                }
                if (row["follow_content"] != null)
                {
                    model.follow_content = row["follow_content"].ToString();
                }
                if (row["follow_status"] != null && row["follow_status"].ToString() != "")
                {
                    model.follow_status = int.Parse(row["follow_status"].ToString());
                }
                if (row["follow_status_name"] != null)
                {
                    model.follow_status_name = row["follow_status_name"].ToString();
                }
                if (row["follow_empid"] != null && row["follow_empid"].ToString() != "")
                {
                    model.follow_empid = int.Parse(row["follow_empid"].ToString());
                }
                if (row["follow_empname"] != null)
                {
                    model.follow_empname = row["follow_empname"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,factory_id,task_id,task_type,follow_time,follow_content,follow_status,follow_status_name,follow_empid,follow_empname ");
            strSql.Append(" FROM crm_task_follow ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            strSql.Append(" select id,factory_id,task_id,task_type,follow_time,follow_content,follow_status,follow_status_name,follow_empid,follow_empname FROM crm_task_follow ");
            strSql1.Append(" select count(Id) FROM crm_task_follow ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
