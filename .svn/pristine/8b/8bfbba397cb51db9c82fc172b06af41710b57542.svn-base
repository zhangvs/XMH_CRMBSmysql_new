using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace XHD.DAL.ims
{
    /// <summary>
    /// 数据访问类:ims_check_task
    /// </summary>
    public partial class ims_check_task
    {
        public ims_check_task()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "ims_check_task");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ims_check_task");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.ims.ims_check_task model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ims_check_task(");
            strSql.Append("id,Factory_Id,rule_id,task_name,task_remark)");
            strSql.Append(" values (");
            strSql.Append("@id,@Factory_Id,@rule_id,@task_name,@task_remark)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@rule_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_name", MySqlDbType.VarChar,300),
					new MySqlParameter("@task_remark", MySqlDbType.VarChar,500)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.Factory_Id;
            parameters[2].Value = model.rule_id;
            parameters[3].Value = model.task_name;
            parameters[4].Value = model.task_remark;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.ims.ims_check_task model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ims_check_task set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("rule_id=@rule_id,");
            strSql.Append("task_name=@task_name,");
            strSql.Append("task_remark=@task_remark");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@rule_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_name", MySqlDbType.VarChar,300),
					new MySqlParameter("@task_remark", MySqlDbType.VarChar,500),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.rule_id;
            parameters[2].Value = model.task_name;
            parameters[3].Value = model.task_remark;
            parameters[4].Value = model.id;

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
            strSql.Append("delete from ims_check_task ");
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
            strSql.Append("delete from ims_check_task ");
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
        public XHD.Model.ims.ims_check_task GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,rule_id,task_name,task_remark from ims_check_task ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.ims.ims_check_task model = new XHD.Model.ims.ims_check_task();
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
        public XHD.Model.ims.ims_check_task DataRowToModel(DataRow row)
        {
            XHD.Model.ims.ims_check_task model = new XHD.Model.ims.ims_check_task();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["rule_id"] != null && row["rule_id"].ToString() != "")
                {
                    model.rule_id = int.Parse(row["rule_id"].ToString());
                }
                if (row["task_name"] != null)
                {
                    model.task_name = row["task_name"].ToString();
                }
                if (row["task_remark"] != null)
                {
                    model.task_remark = row["task_remark"].ToString();
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
            strSql.Append("select id,Factory_Id,rule_id,task_name,task_remark ");
            strSql.Append(" FROM ims_check_task ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListTS(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  s.*,t.task_name ,t.rule_id,ts.num from ims_check_task_standard  s  left join  ims_check_task t on  s.task_id =t.id  left join (select count(id) as num ,task_id from ims_check_task_standard  group by task_id )  as ts on ts.task_id =s.task_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListNum(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.*,s.num,r.rule_classify from ims_check_task t  inner join ims_check_rule r on r.id=t.rule_id  left join (  select count(id) as num ,task_id from ims_check_task_standard  group by task_id  ) as s  on  t.id=s.task_id ");
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
            strSql.Append(" select id,Factory_Id,rule_id,task_name,task_remark ");
            strSql.Append(" FROM ims_check_task ");
            strSql1.Append(" select count(id) FROM ims_check_task ");
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