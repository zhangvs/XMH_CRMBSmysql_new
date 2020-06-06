using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;
using System.Collections.Generic;//Please add references

namespace XHD.DAL.ims
{
    /// <summary>
    /// 数据访问类:ims_check_task_standard
    /// </summary>
    public partial class ims_check_task_standard
    {
        public ims_check_task_standard()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "ims_check_task_standard");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ims_check_task_standard");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ims.ims_check_task_standard model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ims_check_task_standard(");
            strSql.Append("id,task_id,standard_name,standard_score,standard_remarks,rule_id)");
            strSql.Append(" values (");
            strSql.Append("@id,@task_id,@standard_name,@standard_score,@standard_remarks,@rule_id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@task_id", MySqlDbType.Int32,11),
					new MySqlParameter("@standard_name", MySqlDbType.VarChar,500),
					new MySqlParameter("@standard_score", MySqlDbType.Decimal,10),
					new MySqlParameter("@standard_remarks", MySqlDbType.VarChar,500),
                    new MySqlParameter("@rule_id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.task_id;
            parameters[2].Value = model.standard_name;
            parameters[3].Value = model.standard_score;
            parameters[4].Value = model.standard_remarks;
            parameters[5].Value = model.rule_id;

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
        public bool Update(XHD.Model.ims.ims_check_task_standard model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ims_check_task_standard set ");
            strSql.Append("task_id=@task_id,");
            strSql.Append("standard_name=@standard_name,");
            strSql.Append("standard_score=@standard_score,");
            strSql.Append("standard_remarks=@standard_remarks");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@task_id", MySqlDbType.Int32,11),
					new MySqlParameter("@standard_name", MySqlDbType.VarChar,500),
					new MySqlParameter("@standard_score", MySqlDbType.Decimal,10),
					new MySqlParameter("@standard_remarks", MySqlDbType.VarChar,500),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.task_id;
            parameters[1].Value = model.standard_name;
            parameters[2].Value = model.standard_score;
            parameters[3].Value = model.standard_remarks;
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
            strSql.Append("delete from ims_check_task_standard ");
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
            strSql.Append("delete from ims_check_task_standard ");
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
        public XHD.Model.ims.ims_check_task_standard GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,task_id,standard_name,standard_score,standard_remarks from ims_check_task_standard,rule_id ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.ims.ims_check_task_standard model = new XHD.Model.ims.ims_check_task_standard();
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
        public XHD.Model.ims.ims_check_task_standard DataRowToModel(DataRow row)
        {
            XHD.Model.ims.ims_check_task_standard model = new XHD.Model.ims.ims_check_task_standard();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["task_id"] != null && row["task_id"].ToString() != "")
                {
                    model.task_id = int.Parse(row["task_id"].ToString());
                }
                if (row["standard_name"] != null)
                {
                    model.standard_name = row["standard_name"].ToString();
                }
                if (row["standard_score"] != null && row["standard_score"].ToString() != "")
                {
                    model.standard_score = decimal.Parse(row["standard_score"].ToString());
                }
                if (row["standard_remarks"] != null)
                {
                    model.standard_remarks = row["standard_remarks"].ToString();
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
            strSql.Append("select id,task_id,standard_name,standard_score,standard_remarks,0 as aa ");
            strSql.Append(" FROM ims_check_task_standard ");
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
            strSql.Append("select count(1) FROM ims_check_task_standard ");
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

        //增加任务及标准
        public bool AddStandard(int task_id, DataTable dt)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    strSql = string.Format(@"insert into ims_check_task_standard(task_id,standard_name,standard_score,standard_remarks) values ('{0}','{1}','{2}','{3}')",

                                             task_id, dt.Rows[i]["standard"].ToString(), Convert.ToDecimal(dt.Rows[i]["standardScore"]), "");

                    strSqlList.Add(strSql);
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

        //修改任务及标准
        public bool UpdateStandard(XHD.Model.Sys_Task model, DataTable dt)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            strSql = string.Format(@" update Sys_Task set ItemName='{0}',CreateDate='{1}',CreatePersonName='{2}',CreatePersonId='{3}',CreatePDtypeId='{4}',IsCheck='{5}',CheckPId='{6}',apply_userId='{7}',
                                      apply_userName='{8}',ItemContent='{9}',taskItme_Id='{10}',taskItme_Name='{11}' where Id='{12}'",
                                      model.ItemName, model.CreateDate, model.CreatePersonName, model.CreatePersonId, model.CreatePDtypeId, model.IsCheck, model.CheckPId, model.apply_userId,
                                      model.apply_userName, model.ItemContent, model.taskItme_Id, model.taskItme_Name, model.Id);
            strSqlList.Add(strSql);


            string oldstandIdList = string.Empty;
            string newstandIdList = string.Empty;
            DataSet df = GetList(" task_id ='" + model.Id + "'");
            if (df != null && df.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < df.Tables[0].Rows.Count; i++)
                {
                    if (i == df.Tables[0].Rows.Count - 1)
                        oldstandIdList += "'" + df.Tables[0].Rows[i]["id"].ToString() + "'";
                    else
                        oldstandIdList += "'" + df.Tables[0].Rows[i]["id"].ToString() + "',";
                }
            }

            string[] oldIdList = oldstandIdList.Split(',');


            List<string> list = new List<string>();

            foreach (var items in oldIdList)
            {
                if (!list.Contains(items))
                    list.Add(items);
            }



            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["id"].ToString() != "undefined")
                    {
                        if (dt.Rows[i]["id"].ToString() != "0")
                        {
                            if (i == dt.Rows.Count)
                                newstandIdList += "'" + dt.Rows[i]["id"].ToString() + "'";
                            else
                                newstandIdList += "'" + dt.Rows[i]["id"].ToString() + "',";

                            strSql = string.Format(@"update ims_check_task_standard  set standard_name='{0}',standard_score='{1}',standard_remarks='{2}' where task_id='{3}' and id='{4}'",
                                         dt.Rows[i]["standard"].ToString(), Convert.ToDecimal(dt.Rows[i]["standardScore"]), "", model.Id, Convert.ToInt32(dt.Rows[i]["id"].ToString()));

                            strSqlList.Add(strSql);

                        }
                        else
                        {
                            strSql = string.Format(@"insert into ims_check_task_standard(task_id,standard_name,standard_score,standard_remarks) values ('{0}','{1}','{2}','{3}')",

                                                   model.Id, dt.Rows[i]["standard"].ToString(), Convert.ToDecimal(dt.Rows[i]["standardScore"]), "");

                            strSqlList.Add(strSql);
                        }
                    }
                }
            }

            string[] newList = newstandIdList.Split(',');
            foreach (var idlsit in newList)
            {
                if (list.Contains(idlsit))
                    list.Remove(idlsit);
            }

            newList = list.ToArray();

            if(newList.Length>0)
            {
                strSql = string.Format(@" delete from ims_check_task_standard where id in ({0})", newList);

                strSqlList.Add(strSql);
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

