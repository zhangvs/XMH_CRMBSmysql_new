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
    /// 数据访问类:crm_task_delegate
    /// </summary>
    public partial class crm_task_delegate
    {
        public crm_task_delegate()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "crm_task_delegate");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_task_delegate");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_task_delegate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_task_delegate(");
            strSql.Append("id,factory_id,task_id,task_type,apply_content,reply_content,apply_empid,apply_empname,reply_empid,reply_empname)");
            strSql.Append(" values (");
            strSql.Append("@id,@factory_id,@task_id,@task_type,@apply_content,@reply_content,@apply_empid,@apply_empname,@reply_empid,@reply_empname)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@task_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_type", MySqlDbType.VarChar,1),
					new MySqlParameter("@apply_content", MySqlDbType.Text),
					new MySqlParameter("@reply_content", MySqlDbType.Text),
					new MySqlParameter("@apply_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_empname", MySqlDbType.VarChar,30),
					new MySqlParameter("@reply_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@reply_empname", MySqlDbType.VarChar,30)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.factory_id;
            parameters[2].Value = model.task_id;
            parameters[3].Value = model.task_type;
            parameters[4].Value = model.apply_content;
            parameters[5].Value = model.reply_content;
            parameters[6].Value = model.apply_empid;
            parameters[7].Value = model.apply_empname;
            parameters[8].Value = model.reply_empid;
            parameters[9].Value = model.reply_empname;

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
        public bool Update(XHD.Model.crm_task_delegate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_task_delegate set ");
            strSql.Append("factory_id=@factory_id,");
            strSql.Append("task_id=@task_id,");
            strSql.Append("task_type=@task_type,");
            strSql.Append("apply_content=@apply_content,");
            strSql.Append("reply_content=@reply_content,");
            strSql.Append("apply_empid=@apply_empid,");
            strSql.Append("apply_empname=@apply_empname,");
            strSql.Append("reply_empid=@reply_empid,");
            strSql.Append("reply_empname=@reply_empname");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@task_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_type", MySqlDbType.VarChar,1),
					new MySqlParameter("@apply_content", MySqlDbType.Text),
					new MySqlParameter("@reply_content", MySqlDbType.Text),
					new MySqlParameter("@apply_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_empname", MySqlDbType.VarChar,30),
					new MySqlParameter("@reply_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@reply_empname", MySqlDbType.VarChar,30),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.task_id;
            parameters[2].Value = model.task_type;
            parameters[3].Value = model.apply_content;
            parameters[4].Value = model.reply_content;
            parameters[5].Value = model.apply_empid;
            parameters[6].Value = model.apply_empname;
            parameters[7].Value = model.reply_empid;
            parameters[8].Value = model.reply_empname;
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
        /// 根据多个条件去更新记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Alter(XHD.Model.crm_task_delegate model)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Format(@" update crm_task_delegate set reply_content='{0}' where task_id='{1}' and apply_empid='{2}' and reply_empid='{3}'",
                                          model.reply_content, model.task_id, model.apply_empid, model.reply_empid);

            strSqlList.Add(strSql);

            strSql = string.Format(@" update crm_task_okrs set ischeck='{0}' where id='{1}'", 2, model.task_id);
            strSqlList.Add(strSql);

            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
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
            strSql.Append("delete from crm_task_delegate ");
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
            strSql.Append("delete from crm_task_delegate ");
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
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.crm_task_delegate GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,factory_id,task_id,task_type,apply_content,reply_content,apply_empid,apply_empname,reply_empid,reply_empname from crm_task_delegate ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.crm_task_delegate model = new XHD.Model.crm_task_delegate();
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
        public XHD.Model.crm_task_delegate DataRowToModel(DataRow row)
        {
            XHD.Model.crm_task_delegate model = new XHD.Model.crm_task_delegate();
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
                if (row["apply_content"] != null)
                {
                    model.apply_content = row["apply_content"].ToString();
                }
                if (row["reply_content"] != null)
                {
                    model.reply_content = row["reply_content"].ToString();
                }
                if (row["apply_empid"] != null && row["apply_empid"].ToString() != "")
                {
                    model.apply_empid = int.Parse(row["apply_empid"].ToString());
                }
                if (row["apply_empname"] != null)
                {
                    model.apply_empname = row["apply_empname"].ToString();
                }
                if (row["reply_empid"] != null && row["reply_empid"].ToString() != "")
                {
                    model.reply_empid = int.Parse(row["reply_empid"].ToString());
                }
                if (row["reply_empname"] != null)
                {
                    model.reply_empname = row["reply_empname"].ToString();
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
            strSql.Append("select id,factory_id,task_id,task_type,apply_content,reply_content,apply_empid,apply_empname,reply_empid,reply_empname ");
            strSql.Append(" FROM crm_task_delegate ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM crm_task_delegate ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from crm_task_delegate T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

