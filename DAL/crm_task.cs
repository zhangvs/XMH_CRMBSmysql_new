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
    /// 数据访问类:crm_task
    /// </summary>
    public partial class crm_task
    {
        public crm_task()
        { }

        XHD.DAL.crm_task_okrs _okrs = new crm_task_okrs();
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_task");
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
        public bool Add(XHD.Model.crm_task model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_task(");
            strSql.Append("factory_id,task_title,task_content,task_type_id,task_type_name,customer_id,customer_name,executive_id,executive_name,executive_time,task_status_id,task_status_name,priority,remind_time,ischeck,create_id,create_time,create_name,update_id,update_name,update_time,pre_time,real_time,delay_time)");
            strSql.Append(" values (");
            strSql.Append("@factory_id,@task_title,@task_content,@task_type_id,@task_type_name,@customer_id,@customer_name,@executive_id,@executive_name,@executive_time,@task_status_id,@task_status_name,@priority,@remind_time,@ischeck,@create_id,@create_time,@create_name,@update_id,@update_name,@update_time,@pre_time,@real_time,@delay_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@task_title", MySqlDbType.VarChar,200),
					new MySqlParameter("@task_content", MySqlDbType.Text),
					new MySqlParameter("@task_type_id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_type_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@executive_id", MySqlDbType.Int32,11),
					new MySqlParameter("@executive_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@executive_time", MySqlDbType.Int32,11),
					new MySqlParameter("@task_status_id", MySqlDbType.Int32,10),
					new MySqlParameter("@task_status_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@priority", MySqlDbType.VarChar,10),
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
            parameters[1].Value = model.task_title;
            parameters[2].Value = model.task_content;
            parameters[3].Value = model.task_type_id;
            parameters[4].Value = model.task_type_name;
            parameters[5].Value = model.customer_id;
            parameters[6].Value = model.customer_name;
            parameters[7].Value = model.executive_id;
            parameters[8].Value = model.executive_name;
            parameters[9].Value = model.executive_time;
            parameters[10].Value = model.task_status_id;
            parameters[11].Value = model.task_status_name;
            parameters[12].Value = model.priority;
            parameters[13].Value = model.remind_time;
            parameters[14].Value = model.ischeck;
            parameters[15].Value = model.create_id;
            parameters[16].Value = model.create_time;
            parameters[17].Value = model.create_name;
            parameters[18].Value = model.update_id;
            parameters[19].Value = model.update_name;
            parameters[20].Value = model.update_time;
            parameters[21].Value = model.pre_time;
            parameters[22].Value = model.real_time;
            parameters[23].Value = model.delay_time;

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
        public bool Update(XHD.Model.crm_task model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_task set ");
            strSql.Append("factory_id=@factory_id,");
            strSql.Append("task_title=@task_title,");
            strSql.Append("task_content=@task_content,");
            strSql.Append("task_type_id=@task_type_id,");
            strSql.Append("task_type_name=@task_type_name,");
            strSql.Append("customer_id=@customer_id,");
            strSql.Append("customer_name=@customer_name,");
            strSql.Append("executive_id=@executive_id,");
            strSql.Append("executive_name=@executive_name,");
            strSql.Append("executive_time=@executive_time,");
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
					new MySqlParameter("@customer_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@executive_id", MySqlDbType.Int32,11),
					new MySqlParameter("@executive_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@executive_time", MySqlDbType.Int32,11),
					new MySqlParameter("@task_status_id", MySqlDbType.Int32,10),
					new MySqlParameter("@task_status_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@priority", MySqlDbType.VarChar,10),
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
            parameters[6].Value = model.customer_name;
            parameters[7].Value = model.executive_id;
            parameters[8].Value = model.executive_name;
            parameters[9].Value = model.executive_time;
            parameters[10].Value = model.task_status_id;
            parameters[11].Value = model.task_status_name;
            parameters[12].Value = model.priority;
            parameters[13].Value = model.remind_time;
            parameters[14].Value = model.ischeck;
            parameters[15].Value = model.update_id;
            parameters[16].Value = model.update_name;
            parameters[17].Value = model.update_time;
            parameters[18].Value = model.pre_time;
            parameters[19].Value = model.real_time;
            parameters[20].Value = model.delay_time;
            parameters[21].Value = model.Id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_task ");
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
        public bool DeleteList(string Id)
        {
            List<string> strSqlList = new List<string>();

            string okrsId = string.Empty;

            //循环查询子级
            DataSet dt = _okrs.GetList("task_Id=" + Id);
            if (dt != null && dt.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    if (i == dt.Tables[0].Rows.Count - 1)
                        okrsId += dt.Tables[0].Rows[i]["Id"].ToString();
                    else
                        okrsId += dt.Tables[0].Rows[i]["Id"].ToString() + ",";
                }
            }

            DataSet ds = _okrs.GetList("");
            string idList = okrsId;
            if (getOkrIDList(okrsId, ds.Tables[0]) != "")
                idList += "," + getOkrIDList(okrsId, ds.Tables[0]);

            //删除主表中的信息
            string strSql = string.Format(@"delete from crm_task where Id in ({0})", Id);
            strSqlList.Add(strSql);

            if (!string.IsNullOrEmpty(idList))
            {
                //删除子表中的信息
                strSql = string.Format(@"delete from crm_task_okrs where Id in ({0})", idList);
                strSqlList.Add(strSql);
            }

            //删除主表的跟进表中的信息
            strSql = string.Format(@"delete from crm_task_follow where task_id in ({0}) and task_type=1", Id);
            strSqlList.Add(strSql);

            if (!string.IsNullOrEmpty(okrsId))
            {
                //删除子表的跟进表中的信息
                strSql = string.Format(@"delete from crm_task_follow where task_id in ({0}) and task_type=2", idList);
                strSqlList.Add(strSql);
            }

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
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.crm_task GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_id,task_title,task_content,task_type_id,task_type_name,customer_id,customer_name,executive_id,executive_name,executive_time,task_status_id,task_status_name,priority,remind_time,ischeck,create_id,create_time,create_name,update_id,update_name,update_time,pre_time,real_time,delay_time from crm_task ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.crm_task model = new XHD.Model.crm_task();
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
        public XHD.Model.crm_task DataRowToModel(DataRow row)
        {
            XHD.Model.crm_task model = new XHD.Model.crm_task();
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
                if (row["customer_name"] != null)
                {
                    model.customer_name = row["customer_name"].ToString();
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
            strSql.Append("select Id,factory_id,task_title,task_content,task_type_id,task_type_name,customer_id,customer_name,executive_id,executive_name,executive_time,task_status_id,task_status_name,priority,remind_time,ischeck,create_id,create_time,create_name,update_id,update_name,update_time,pre_time,real_time,delay_time ");
            strSql.Append(" FROM crm_task ");
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
            strSql.Append(" select Id,factory_id,task_title,task_content,task_type_id,task_type_name,customer_id,customer_name,executive_id,executive_name,executive_time,task_status_id,task_status_name,priority,remind_time,ischeck,create_id,create_time,create_name,update_id,update_name,update_time,pre_time,real_time,delay_time FROM crm_task ");
            strSql1.Append(" select count(Id) FROM crm_task ");
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
        /// 跟进项目ID查询项目的状态
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public string GetStatus(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select task_status_name from crm_task");
            strSql.Append(" where " + strWhere);

            return DbHelperMySQL.GetSingles(strSql.ToString()).ToString();
        }

        /// <summary>
        ///更改项目的状态为已完成
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public bool UpdateStatus(XHD.Model.crm_task model)
        {

            List<string> strSqlList = new List<string>();
            string okrsId = string.Empty;

            //循环查询子级
            DataSet dt = _okrs.GetList("task_Id=" + model.Id);
            if (dt != null && dt.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    if (i == dt.Tables[0].Rows.Count - 1)
                        okrsId += dt.Tables[0].Rows[i]["Id"].ToString();
                    else
                        okrsId += dt.Tables[0].Rows[i]["Id"].ToString() + ",";
                }
            }
            DataSet ds = _okrs.GetList("factory_Id='" + model.factory_id + "'");
            string idList = okrsId;
            if (getOkrIDList(okrsId, ds.Tables[0]) != "")
                idList += "," + getOkrIDList(okrsId, ds.Tables[0]);

            int task_status_id = (int)DbHelperMySQL.GetSingles("select id from Param_SysParam where params_name='" + model.task_status_name + "' and parentid=16 and Factory_Id=" + model.factory_id + " limit 1");

            //修改主表中的状态
            string strSql = string.Format(@"Update crm_task set task_status_name='{0}',task_status_id='{1}',update_id='{2}',update_name='{3}',update_time='{4}',real_time='{5}',delay_time='{6}' where Id='{7}'",
                             model.task_status_name, task_status_id, model.update_id, model.update_name, model.update_time, model.update_time, model.update_time - model.pre_time, model.Id);
            strSqlList.Add(strSql);

            if (!string.IsNullOrEmpty(okrsId))
            {
                //修改子表中的状态

                DataSet dtokrs = _okrs.GetList(" Id in (" + idList + ")");
                if (dt != null && dtokrs.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dtokrs.Tables[0].Rows.Count; i++)
                    {
                        if (dtokrs.Tables[0].Rows[i]["task_status_name"].ToString() != "已完成" || dtokrs.Tables[0].Rows[i]["real_time"].ToString() == "0")
                        {
                            //strSql = string.Format(@"Update crm_task_okrs set task_status_name='{0}',task_status_id='{1}',update_id='{2}',update_name='{3}',update_time='{4}',real_time='{5}' where Id in ({6})",
                            //     model.task_status_name, task_status_id, model.update_id, model.update_name, model.update_time, model.update_time, idList);

                            strSql = string.Format(@"Update crm_task_okrs set task_status_name='{0}',task_status_id='{1}',update_id='{2}',update_name='{3}',update_time='{4}',real_time='{5}' where Id ='{6}'",
                                 model.task_status_name, task_status_id, model.update_id, model.update_name, model.update_time, model.update_time, dtokrs.Tables[0].Rows[i]["Id"].ToString());
                            strSqlList.Add(strSql);
                        }
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

        public static string getOkrIDList(string Id, DataTable table)
        {
            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(Id))
            {
                DataRow[] rows = table.Select("task_parent_Id in (" + Id + ")");

                if (rows.Length == 0) return string.Empty; ;


                foreach (DataRow row in rows)
                {
                    str.Append(row["id"]);
                    if (GetTasksString((int)row["id"], table).Length > 0)
                    {
                        str.Append(",");
                        str.Append(getOkrIDList(row["id"].ToString(), table));
                        str.Append(",");
                    }
                    else
                    {
                        str.Append(",");
                    }
                }
                return str[str.Length - 1] == ',' ? str.ToString(0, str.Length - 1) : str.ToString();
            }
            else
            {
                return str.ToString();
            }
        }

        //拼接字符串
        private static string GetTasksString(int Id, DataTable table)
        {
            DataRow[] rows = table.Select("task_parent_Id=" + Id.ToString());

            if (rows.Length == 0) return string.Empty; ;
            StringBuilder str = new StringBuilder();

            foreach (DataRow row in rows)
            {
                str.Append("{");
                for (int i = 0; i < row.Table.Columns.Count; i++)
                {
                    if (i != 0) str.Append(",");
                    str.Append(row.Table.Columns[i].ColumnName);
                    str.Append(":'");
                    str.Append(row[i].ToString());
                    str.Append("'");
                }
                if (GetTasksString((int)row["id"], table).Length > 0)
                {
                    str.Append(",children:[");
                    str.Append(GetTasksString((int)row["id"], table));
                    str.Append("]},");
                }
                else
                {
                    str.Append("},");
                }
            }
            return str[str.Length - 1] == ',' ? str.ToString(0, str.Length - 1) : str.ToString();
        }


        #endregion  BasicMethod

    }
}
