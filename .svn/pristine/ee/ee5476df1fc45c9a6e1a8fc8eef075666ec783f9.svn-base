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
    /// 数据访问类:crm_task_okrs
    /// </summary>
    public partial class crm_task_okrs
    {
        public crm_task_okrs()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_task_okrs");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_task_okrs model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_task_okrs(");
            strSql.Append("factory_id,task_Id,task_parent_Id,task_title,task_content,task_type_id,task_type_name,customer_id,customer_name,executive_id,executive_name,executive_time,delegate_id,delegate_name,task_status_id,task_status_name,priority,remind_time,ischeck,create_id,create_time,create_name,update_id,update_name,update_time,pre_time,real_time,delay_time)");
            strSql.Append(" values (");
            strSql.Append("@factory_id,@task_Id,@task_parent_Id,@task_title,@task_content,@task_type_id,@task_type_name,@customer_id,@customer_name,@executive_id,@executive_name,@executive_time,@delegate_id,@delegate_name,@task_status_id,@task_status_name,@priority,@remind_time,@ischeck,@create_id,@create_time,@create_name,@update_id,@update_name,@update_time,@pre_time,@real_time,@delay_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@task_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_parent_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_title", MySqlDbType.VarChar,200),
					new MySqlParameter("@task_content", MySqlDbType.Text),
					new MySqlParameter("@task_type_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_type_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
                    new MySqlParameter("@customer_name",MySqlDbType.VarChar,50),
					new MySqlParameter("@executive_id", MySqlDbType.Int32,11),
					new MySqlParameter("@executive_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@executive_time", MySqlDbType.Int32,11),
                    new MySqlParameter("@delegate_id",MySqlDbType.Int32,11),
                    new MySqlParameter("@delegate_name",MySqlDbType.VarChar,60),
					new MySqlParameter("@task_status_id", MySqlDbType.Int32,10),
					new MySqlParameter("@task_status_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@priority", MySqlDbType.VarChar,1),
					new MySqlParameter("@remind_time", MySqlDbType.Int32,11),
					new MySqlParameter("@ischeck", MySqlDbType.Int32,10),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_time", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@update_id", MySqlDbType.Int32,11),
					new MySqlParameter("@update_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@update_time", MySqlDbType.Int32,11),
					new MySqlParameter("@pre_time", MySqlDbType.Int32,11),
					new MySqlParameter("@real_time", MySqlDbType.Int32,11),
					new MySqlParameter("@delay_time", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.task_Id;
            parameters[2].Value = model.task_parent_Id;
            parameters[3].Value = model.task_title;
            parameters[4].Value = model.task_content;
            parameters[5].Value = model.task_type_id;
            parameters[6].Value = model.task_type_name;
            parameters[7].Value = model.customer_id;
            parameters[8].Value = model.customer_name;
            parameters[9].Value = model.executive_id;
            parameters[10].Value = model.executive_name;
            parameters[11].Value = model.executive_time;
            parameters[12].Value = model.delegate_id;
            parameters[13].Value = model.delegate_name;
            parameters[14].Value = model.task_status_id;
            parameters[15].Value = model.task_status_name;
            parameters[16].Value = model.priority;
            parameters[17].Value = model.remind_time;
            parameters[18].Value = model.ischeck;
            parameters[19].Value = model.create_id;
            parameters[20].Value = model.create_time;
            parameters[21].Value = model.create_name;
            parameters[22].Value = model.update_id;
            parameters[23].Value = model.update_name;
            parameters[24].Value = model.update_time;
            parameters[25].Value = model.pre_time;
            parameters[26].Value = model.real_time;
            parameters[27].Value = model.delay_time;

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
        public bool Update(XHD.Model.crm_task_okrs model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_task_okrs set ");
            strSql.Append("factory_id=@factory_id,");
            strSql.Append("task_title=@task_title,");
            strSql.Append("task_content=@task_content,");
            strSql.Append("task_type_id=@task_type_id,");
            strSql.Append("task_type_name=@task_type_name,");
            strSql.Append("customer_id=@customer_id,");
            strSql.Append("executive_id=@executive_id,");
            strSql.Append("executive_name=@executive_name,");
            strSql.Append("executive_time=@executive_time,");
            strSql.Append("delegate_id=@delegate_id,");
            strSql.Append("delegate_name=@delegate_name,");
            strSql.Append("task_status_id=@task_status_id,");
            strSql.Append("task_status_name=@task_status_name,");
            strSql.Append("priority=@priority,");
            strSql.Append("remind_time=@remind_time,");
            strSql.Append("ischeck=@ischeck,");
            strSql.Append("update_id=@update_id,");
            strSql.Append("update_name=@update_name,");
            strSql.Append("update_time=@update_time,");
            strSql.Append("pre_time=@pre_time,");
            strSql.Append("real_time=@real_time,");
            strSql.Append("delay_time=@delay_time");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@task_title", MySqlDbType.VarChar,200),
					new MySqlParameter("@task_content", MySqlDbType.Text),
					new MySqlParameter("@task_type_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_type_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@executive_id", MySqlDbType.Int32,11),
					new MySqlParameter("@executive_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@executive_time", MySqlDbType.Int32,11),
                    new MySqlParameter("@delegate_id", MySqlDbType.Int32,11),
					new MySqlParameter("@delegate_name", MySqlDbType.VarChar,60),                   
					new MySqlParameter("@task_status_id", MySqlDbType.Int32,10),
					new MySqlParameter("@task_status_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@priority", MySqlDbType.VarChar,1),
					new MySqlParameter("@remind_time", MySqlDbType.Int32,11),
					new MySqlParameter("@ischeck", MySqlDbType.Int32,10),
					new MySqlParameter("@update_id", MySqlDbType.Int32,11),
					new MySqlParameter("@update_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@update_time", MySqlDbType.Int32,11),
					new MySqlParameter("@pre_time", MySqlDbType.Int32,11),
					new MySqlParameter("@real_time", MySqlDbType.Int32,11),
					new MySqlParameter("@delay_time", MySqlDbType.Int32,11),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.task_title;
            parameters[2].Value = model.task_content;
            parameters[3].Value = model.task_type_id;
            parameters[4].Value = model.task_type_name;
            parameters[5].Value = model.customer_id;
            parameters[6].Value = model.executive_id;
            parameters[7].Value = model.executive_name;
            parameters[8].Value = model.executive_time;
            parameters[9].Value = model.delegate_id;
            parameters[10].Value = model.delegate_name;
            parameters[11].Value = model.task_status_id;
            parameters[12].Value = model.task_status_name;
            parameters[13].Value = model.priority;
            parameters[14].Value = model.remind_time;
            parameters[15].Value = model.ischeck;
            parameters[16].Value = model.update_id;
            parameters[17].Value = model.update_name;
            parameters[18].Value = model.update_time;
            parameters[19].Value = model.pre_time;
            parameters[20].Value = model.real_time;
            parameters[21].Value = model.delay_time;
            parameters[22].Value = model.Id;

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
        /// 根据ID更新isCheck
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UpdateById(int id, int check)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_task_okrs set ischeck=" + check + " where id  =" + id);
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_task_okrs ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_task_okrs ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        public XHD.Model.crm_task_okrs GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_id,task_Id,task_parent_Id,task_title,task_content,task_type_id,task_type_name,customer_id,executive_id,executive_name,executive_time,delegate_id,delegate_name,task_status_id,task_status_name,priority,remind_time,ischeck,create_id,create_time,create_name,update_id,update_name,update_time,pre_time,real_time,delay_time from crm_task_okrs ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.crm_task_okrs model = new XHD.Model.crm_task_okrs();
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
        public XHD.Model.crm_task_okrs DataRowToModel(DataRow row)
        {
            XHD.Model.crm_task_okrs model = new XHD.Model.crm_task_okrs();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
                }
                if (row["task_Id"] != null && row["task_Id"].ToString() != "")
                {
                    model.task_Id = int.Parse(row["task_Id"].ToString());
                }
                if (row["task_parent_Id"] != null && row["task_parent_Id"].ToString() != "")
                {
                    model.task_parent_Id = int.Parse(row["task_parent_Id"].ToString());
                }
                if (row["task_title"] != null)
                {
                    model.task_title = row["task_title"].ToString();
                }
                if (row["task_content"] != null)
                {
                    model.task_content = row["task_content"].ToString();
                }
                if (row["task_type_id"] != null && row["task_type_id"].ToString() != "")
                {
                    model.task_type_id = int.Parse(row["task_type_id"].ToString());
                }
                if (row["task_type_name"] != null)
                {
                    model.task_type_name = row["task_type_name"].ToString();
                }
                if (row["customer_id"] != null && row["customer_id"].ToString() != "")
                {
                    model.customer_id = int.Parse(row["customer_id"].ToString());
                }
                if (row["executive_id"] != null && row["executive_id"].ToString() != "")
                {
                    model.executive_id = int.Parse(row["executive_id"].ToString());
                }
                if (row["executive_name"] != null)
                {
                    model.executive_name = row["executive_name"].ToString();
                }
                if (row["executive_time"] != null && row["executive_time"].ToString() != "")
                {
                    model.executive_time = int.Parse(row["executive_time"].ToString());
                }
                if (row["delegate_id"] != null && row["delegate_id"].ToString() != "")
                {
                    model.delegate_id = int.Parse(row["delegate_id"].ToString());
                }
                if (row["delegate_name"] != null)
                {
                    model.delegate_name = row["delegate_name"].ToString();
                }
                if (row["task_status_id"] != null && row["task_status_id"].ToString() != "")
                {
                    model.task_status_id = int.Parse(row["task_status_id"].ToString());
                }
                if (row["task_status_name"] != null)
                {
                    model.task_status_name = row["task_status_name"].ToString();
                }
                if (row["priority"] != null)
                {
                    model.priority = row["priority"].ToString();
                }
                if (row["remind_time"] != null && row["remind_time"].ToString() != "")
                {
                    model.remind_time = int.Parse(row["remind_time"].ToString());
                }
                if (row["ischeck"] != null && row["ischeck"].ToString() != "")
                {
                    model.ischeck = int.Parse(row["ischeck"].ToString());
                }
                if (row["create_id"] != null && row["create_id"].ToString() != "")
                {
                    model.create_id = int.Parse(row["create_id"].ToString());
                }
                if (row["create_time"] != null && row["create_time"].ToString() != "")
                {
                    model.create_time = int.Parse(row["create_time"].ToString());
                }
                if (row["create_name"] != null)
                {
                    model.create_name = row["create_name"].ToString();
                }
                if (row["update_id"] != null && row["update_id"].ToString() != "")
                {
                    model.update_id = int.Parse(row["update_id"].ToString());
                }
                if (row["update_name"] != null)
                {
                    model.update_name = row["update_name"].ToString();
                }
                if (row["update_time"] != null && row["update_time"].ToString() != "")
                {
                    model.update_time = int.Parse(row["update_time"].ToString());
                }
                if (row["pre_time"] != null && row["pre_time"].ToString() != "")
                {
                    model.pre_time = int.Parse(row["pre_time"].ToString());
                }
                if (row["real_time"] != null && row["real_time"].ToString() != "")
                {
                    model.real_time = int.Parse(row["real_time"].ToString());
                }
                if (row["delay_time"] != null && row["delay_time"].ToString() != "")
                {
                    model.delay_time = int.Parse(row["delay_time"].ToString());
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
            strSql.Append("select Id,factory_id,task_Id,task_parent_Id,task_title,task_content,task_type_id,task_type_name,customer_id,executive_id,executive_name,executive_time,delegate_id,delegate_name,task_status_id,task_status_name,priority,remind_time,ischeck,create_id,create_time,create_name,update_id,update_name,update_time,pre_time,real_time,delay_time ");
            strSql.Append(" FROM crm_task_okrs ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append(" order by executive_time desc");
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select Id,factory_id,task_Id,task_parent_Id,task_title,task_content,task_type_id,task_type_name,customer_id,customer_name,executive_id,executive_name,executive_time,delegate_id,delegate_name,task_status_id,task_status_name,priority,remind_time,ischeck,create_id,create_time,create_name,update_id,update_name,update_time,pre_time,real_time,delay_time FROM crm_task_okrs ");
            strSql1.Append(" select count(Id) FROM crm_task_okrs ");
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
        ///  更新一组数据完成状态
        /// </summary>
        public bool UpdateStatus(XHD.Model.crm_task_okrs model, string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_task_okrs set ");
            strSql.Append("task_status_id=@task_status_id,");
            strSql.Append("task_status_name=@task_status_name,");
            strSql.Append("update_time=@update_time,");
            strSql.Append("update_id=@update_id,");
            strSql.Append("update_name=@update_name,");
            strSql.Append("real_time=@real_time");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            strSql.Append(" and factory_Id=@factory_Id  ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@task_status_id",  MySqlDbType.Int32,11),
					new MySqlParameter("@task_status_name", MySqlDbType.VarChar,60),
                    new MySqlParameter("@update_time",  MySqlDbType.Int32,11),
                    new MySqlParameter("@update_id", MySqlDbType.Int32,11),
					new MySqlParameter("@update_name", MySqlDbType.VarChar,30),
                    new MySqlParameter("@real_time",  MySqlDbType.Int32,11),
                    new MySqlParameter("@factory_Id",  MySqlDbType.VarChar,60)};

            parameters[0].Value = model.task_status_id;
            parameters[1].Value = model.task_status_name;
            parameters[2].Value = model.update_time;
            parameters[3].Value = model.update_id;
            parameters[4].Value = model.update_name;
            parameters[5].Value = model.real_time;
            parameters[6].Value = model.factory_id;
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
        /// 更新一组数据完成状态
        /// </summary>
        public bool UpdateOKRSStatus(XHD.Model.crm_task_okrs model, string Idlist)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;
            DataSet dtokrs = GetList(" Id in (" + Idlist + ")");
            if (dtokrs != null && dtokrs.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dtokrs.Tables[0].Rows.Count; i++)
                {
                    if (dtokrs.Tables[0].Rows[i]["task_status_name"].ToString() != "已完成" || dtokrs.Tables[0].Rows[i]["real_time"].ToString() == "0")
                    {
                        strSql = string.Format(@"Update crm_task_okrs set task_status_name='{0}',task_status_id='{1}',update_id='{2}',update_name='{3}',update_time='{4}',real_time='{5}' where Id ='{6}'",
                             model.task_status_name, model.task_status_id, model.update_id, model.update_name, model.update_time, model.update_time, dtokrs.Tables[0].Rows[i]["Id"].ToString());
                        strSqlList.Add(strSql);
                    }
                }
            }
            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


