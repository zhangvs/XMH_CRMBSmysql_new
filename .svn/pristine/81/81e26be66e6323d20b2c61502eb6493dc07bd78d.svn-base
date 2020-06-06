/**  版本信息模板在安装目录下，可自行修改。
* Sys_Task.cs
*
* 功 能： N/A
* 类 名： Sys_Task
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/10/3 17:32:35   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
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
    /// 数据访问类:Sys_Task
    /// </summary>
    public partial class Sys_Task
    {
        public Sys_Task()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "Sys_Task");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Sys_Task");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.Sys_Task model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_Task(");
            strSql.Append("Factory_Id,ItemName,CreateDate,CreatePersonName,CreatePersonId,CreatePDtypeId,IsCheck,CheckPId,apply_userId,apply_userName,ItemContent,taskItme_Id,taskItme_Name,task_classify)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@ItemName,@CreateDate,@CreatePersonName,@CreatePersonId,@CreatePDtypeId,@IsCheck,@CheckPId,@apply_userId,@apply_userName,@ItemContent,@taskItme_Id,@taskItme_Name,@task_classify)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@ItemName", MySqlDbType.VarChar,50),
					new MySqlParameter("@CreateDate", MySqlDbType.Date),
					new MySqlParameter("@CreatePersonName", MySqlDbType.VarChar,50),
					new MySqlParameter("@CreatePersonId", MySqlDbType.Int32,11),
					new MySqlParameter("@CreatePDtypeId", MySqlDbType.Int32,11),
					new MySqlParameter("@IsCheck", MySqlDbType.TinyText,4),
					new MySqlParameter("@CheckPId", MySqlDbType.Int32,11),
                    new MySqlParameter("@apply_userId", MySqlDbType.VarChar,500),
                    new MySqlParameter("@apply_userName", MySqlDbType.VarChar,500),
					new MySqlParameter("@ItemContent", MySqlDbType.Text),
                    new MySqlParameter("@taskItme_Id", MySqlDbType.Int32,11),
                    new MySqlParameter("@taskItme_Name", MySqlDbType.VarChar,100),
                    new MySqlParameter("@task_classify",MySqlDbType.VarChar,1)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.ItemName;
            parameters[2].Value = model.CreateDate;
            parameters[3].Value = model.CreatePersonName;
            parameters[4].Value = model.CreatePersonId;
            parameters[5].Value = model.CreatePDtypeId;
            parameters[6].Value = model.IsCheck;
            parameters[7].Value = model.CheckPId;
            parameters[8].Value = model.apply_userId;
            parameters[9].Value = model.apply_userName;
            parameters[10].Value = model.ItemContent;
            parameters[11].Value = model.taskItme_Id;
            parameters[12].Value = model.taskItme_Name;
            parameters[13].Value = model.task_classify;

            //int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
            //if (rows > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

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
        public bool Update(XHD.Model.Sys_Task model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_Task set ");
            strSql.Append("ItemName=@ItemName,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("CreatePersonName=@CreatePersonName,");
            strSql.Append("CreatePersonId=@CreatePersonId,");
            strSql.Append("CreatePDtypeId=@CreatePDtypeId,");
            strSql.Append("IsCheck=@IsCheck,");
            strSql.Append("CheckPId=@CheckPId,");
            strSql.Append("apply_userId=@apply_userId,");
            strSql.Append("apply_userName=@apply_userName,");
            strSql.Append("ItemContent=@ItemContent,");
            strSql.Append("taskItme_Id=@taskItme_Id,");
            strSql.Append("taskItme_Name=@taskItme_Name");
            //strSql.Append("task_classify=@task_classify ");
            strSql.Append(" where Id=@Id ");

            MySqlParameter[] parameters = {
					new MySqlParameter("@ItemName", MySqlDbType.VarChar,50),
					new MySqlParameter("@CreateDate", MySqlDbType.Date),
					new MySqlParameter("@CreatePersonName", MySqlDbType.VarChar,50),
					new MySqlParameter("@CreatePersonId", MySqlDbType.Int32,11),
					new MySqlParameter("@CreatePDtypeId", MySqlDbType.Int32,11),
					new MySqlParameter("@IsCheck", MySqlDbType.TinyText,4),
					new MySqlParameter("@CheckPId", MySqlDbType.Int32,11),
                    new MySqlParameter("@apply_userId", MySqlDbType.VarChar,500),
                    new MySqlParameter("@apply_userName",MySqlDbType.VarChar,500),
					new MySqlParameter("@ItemContent", MySqlDbType.Text),
                    new MySqlParameter("@taskItme_Id", MySqlDbType.Int32,11),
                    new MySqlParameter("@taskItme_Name", MySqlDbType.VarChar,100),
                    //new MySqlParameter("@task_classify",MySqlDbType.VarChar,1),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.ItemName;
            parameters[1].Value = model.CreateDate;
            parameters[2].Value = model.CreatePersonName;
            parameters[3].Value = model.CreatePersonId;
            parameters[4].Value = model.CreatePDtypeId;
            parameters[5].Value = model.IsCheck;
            parameters[6].Value = model.CheckPId;
            parameters[7].Value = model.apply_userId;
            parameters[8].Value = model.apply_userName;
            parameters[9].Value = model.ItemContent;
            parameters[10].Value = model.taskItme_Id;
            parameters[11].Value = model.taskItme_Name;
            //parameters[12].Value = model.task_classify;
            parameters[12].Value = model.Id;

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
            strSql.Append("delete from Sys_Task ");
            strSql.Append(" where Id=@Id ");
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
            strSql.Append("delete from Sys_Task ");
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
        public XHD.Model.Sys_Task GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,ItemName,CreateDate,CreatePersonName,CreatePersonId,CreatePDtypeId,IsCheck,CheckPId,apply_userId,apply_userName,ItemContent,taskItme_Id,taskItme_Name,task_classify from Sys_Task ");
            strSql.Append(" where Id=@Id  limit 1");                                                                                                            
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            XHD.Model.Sys_Task model = new XHD.Model.Sys_Task();
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
        public XHD.Model.Sys_Task DataRowToModel(DataRow row)
        {
            XHD.Model.Sys_Task model = new XHD.Model.Sys_Task();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["ItemName"] != null)
                {
                    model.ItemName = row["ItemName"].ToString();
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
                if (row["CreatePersonName"] != null)
                {
                    model.CreatePersonName = row["CreatePersonName"].ToString();
                }
                if (row["CreatePersonId"] != null && row["CreatePersonId"].ToString() != "")
                {
                    model.CreatePersonId = int.Parse(row["CreatePersonId"].ToString());
                }
                if (row["CreatePDtypeId"] != null && row["CreatePDtypeId"].ToString() != "")
                {
                    model.CreatePDtypeId = int.Parse(row["CreatePDtypeId"].ToString());
                }
                if (row["IsCheck"] != null && row["IsCheck"].ToString() != "")
                {
                    if ((row["IsCheck"].ToString() == "1") || (row["IsCheck"].ToString().ToLower() == "true"))
                    {
                        model.IsCheck = true;
                    }
                    else
                    {
                        model.IsCheck = false;
                    }
                }
                if (row["CheckPId"] != null && row["CheckPId"].ToString() != "")
                {
                    model.CheckPId = int.Parse(row["CheckPId"].ToString());
                }
                if (row["ItemContent"] != null)
                {
                    model.ItemContent = row["ItemContent"].ToString();
                }
            }
            return model;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet getTaskContent(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ItemContent ");
            strSql.Append(" FROM Sys_Task where id=" + id + " ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,ItemName,CreateDate,CreatePersonName,CreatePersonId,CreatePDtypeId,IsCheck,CheckPId,apply_userId,apply_userName,ItemContent,taskItme_Id,taskItme_Name,task_classify ");
            strSql.Append(" FROM Sys_Task ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" Id,ItemName,CreateDate,CreatePersonName,CreatePersonId,CreatePDtypeId,IsCheck,CheckPId,apply_userId,apply_userName,ItemContent,taskItme_Id,taskItme_Name,task_classify ");
            strSql.Append(" FROM Sys_Task ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Sys_Task ");
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
        public DataSet GetListJoinDtype(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  h.d_name,s.id,s.itemname,s.createdate,s.createpersonid,s.createpersonname,s.ischeck,s.checkpid,s.apply_userId,s.apply_userName,s.ItemContent,s.taskItme_Id,s.taskItme_Name,s.task_classify FROM Sys_Task s left join hr_department h on s.CreatePDtypeId=h.id");
            //strSql.Append(" WHERE s.id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Sys_Task ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM Sys_Task s");
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
        /// 获取部门的任务项
        /// </summary>
        public DataSet GetListDep(int PageSize, int PageIndex, string strWhere, string depId, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select h.d_name,s.id,s.itemname,s.createdate,s.createpersonid,s.createpersonname,s.ischeck,s.checkpid,s.apply_userId,s.apply_userName,s.itemcontent,s.taskItme_Id,s.taskItme_Name,s.task_classify from ( ");
            strSql.Append("select * from Sys_Task where CreatePDtypeId='-1' and ( apply_userId='-1' or apply_userId is null) and " + strWhere + "");
            strSql.Append("union all ");
            strSql.Append("select * from Sys_Task where CreatePDtypeId ='" + depId + "'  and " + strWhere + "");
            strSql.Append(" ) as s  left join hr_department h on s.CreatePDtypeId=h.id ");

            strSql1.Append("select count(s.id) from ( ");
            strSql1.Append("select * from Sys_Task where CreatePDtypeId='-1' and ( apply_userId='-1' or apply_userId is null) and " + strWhere + "");
            strSql1.Append("union all ");
            strSql1.Append("select * from Sys_Task where CreatePDtypeId ='" + depId + "'  and " + strWhere + "");
            strSql1.Append(" ) as s ");

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet NewGetListJoinDtype(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("select  h.d_name,s.id,s.itemname,s.createdate,s.createpersonid,s.createpersonname,s.ischeck,s.checkpid,s.apply_userId,s.apply_userName,s.ItemContent,s.taskItme_Id,s.taskItme_Name,s.task_classify FROM Sys_Task s join hr_department h on s.CreatePDtypeId=h.id");
            //strSql.Append(" WHERE s.id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Sys_Task ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM Sys_Task s");
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" id,itemname,createdate,createpersonid,createpersonname,ischeck,checkpid,apply_userId,apply_userName,itemcontent,taskItme_Id,taskItme_Name,task_classify FROM Sys_Task ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Sys_Task ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM Sys_Task");
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListTaskByEmpId(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" s.id,s.itemname,s.createdate,s.createpersonid,s.createpersonname,s.ischeck,s.checkpid,s.apply_userId,s.apply_userName,s.itemcontent,s.taskItme_Id,s.taskItme_Name,s.task_classify FROM Sys_Task s left join hr_employee e on s.CreatePDtypeId =e.d_Id or s.CreatePDtypeId= -1");
            strSql1.Append(" select count(s.id) FROM Sys_Task s left join hr_employee e on s.CreatePDtypeId =e.d_Id or s.CreatePDtypeId= -1 ");
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
        /// 分页获取数据列表----根据部门及员工ID查询该员工所具有的任务项
        /// </summary>
        public DataSet GetTaskByDEID(int PageSize, int PageIndex, string strWhere, string empId, string depId, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            //strSql.Append("select  distinct  s.id,s.itemname,s.createdate,s.createpersonid,s.createpersonname,s.ischeck,s.checkpid,s.apply_userId,s.apply_userName,s.itemcontent,s.taskItme_Id,s.taskItme_Name,s.task_classify from ( ");
            //strSql.Append("select * from Sys_Task where CreatePDtypeId='-1' and ( apply_userId='-1' or apply_userId is null) and " + strWhere + "");
            //strSql.Append("union all ");
            //strSql.Append("select * from Sys_Task where CreatePDtypeId in(" + depId + ") and  FIND_IN_SET('" + empId + "',apply_userId) and " + strWhere + "");
            //strSql.Append("union all ");
            //strSql.Append("select * from Sys_Task where CreatePDtypeId ='-1' and   FIND_IN_SET('" + empId + "',apply_userId) and " + strWhere + "");
            //strSql.Append("union all ");
            //strSql.Append("select * from Sys_Task where CreatePDtypeId in(" + depId + ") and   ( apply_userId='-1' or apply_userId is null) and " + strWhere + "");
            //strSql.Append(" ) as s ");

            //strSql1.Append("select count(distinct s.id) from ( ");
            //strSql1.Append("select * from Sys_Task where CreatePDtypeId='-1' and ( apply_userId='-1' or apply_userId is null) and " + strWhere + "");
            //strSql1.Append("union all ");
            //strSql1.Append("select * from Sys_Task where CreatePDtypeId in(" + depId + ") and  FIND_IN_SET('" + empId + "',apply_userId) and " + strWhere + "");
            //strSql1.Append("union all ");
            //strSql1.Append("select * from Sys_Task where CreatePDtypeId ='-1' and   FIND_IN_SET('" + empId + "',apply_userId) and " + strWhere + "");
            //strSql1.Append("union all ");
            //strSql1.Append("select * from Sys_Task where CreatePDtypeId in(" + depId + ") and   ( apply_userId='-1' or apply_userId is null) and " + strWhere + "");
            //strSql1.Append(" ) as s ");


            strSql.Append("select  distinct  s.id,s.itemname,s.createdate,s.createpersonid,s.createpersonname,s.ischeck,s.checkpid,s.apply_userId,s.apply_userName,s.itemcontent,s.taskItme_Id,s.taskItme_Name,s.task_classify from ( ");
            strSql.Append("select * from Sys_Task where CreatePDtypeId='-1' and  ( ( apply_userId='-1' or apply_userId is null)  or  FIND_IN_SET('" + empId + "',apply_userId)  )   and  " + strWhere + "");
            strSql.Append("union all ");
            strSql.Append("select * from Sys_Task where CreatePDtypeId in(" + depId + ") and  ( FIND_IN_SET('" + empId + "',apply_userId)  or ( apply_userId='-1' or apply_userId is null)  ) and  " + strWhere + "");
            strSql.Append(" ) as s ");

            strSql1.Append("select count(distinct s.id) from ( ");
            strSql1.Append("select * from Sys_Task where CreatePDtypeId='-1' and  ( ( apply_userId='-1' or apply_userId is null)  or  FIND_IN_SET('" + empId + "',apply_userId)  )   and  " + strWhere + "");
            strSql1.Append("union all ");
            strSql1.Append("select * from Sys_Task where CreatePDtypeId in(" + depId + ") and  ( FIND_IN_SET('" + empId + "',apply_userId)  or ( apply_userId='-1' or apply_userId is null)  ) and  " + strWhere + "");
            strSql1.Append(" ) as s ");


            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表  指定字段
        /// </summary>
        public DataSet GetOptionListById(int id, string factory_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,ItemName,CreateDate,ItemContent ");
            strSql.Append(" FROM Sys_Task ");
            strSql.Append(" where CreatePDtypeId=@CreatePDtypeId");
            strSql.Append(" and Factory_Id=@Factory_Id");
            strSql.Append(" or CreatePDtypeId= -1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@CreatePDtypeId", MySqlDbType.Int32,11),
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60)	                      
            };
            parameters[0].Value = id;
            parameters[1].Value = factory_Id;
            return DbHelperMySQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 获得数据列表  指定字段
        /// </summary>
        public DataSet GetOptionList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,itemName ");
            strSql.Append(" FROM Sys_Task ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from Sys_Task T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("PageSize", SqlDbType.Int),
                    new SqlParameter("PageIndex", SqlDbType.Int),
                    new SqlParameter("IsReCount", SqlDbType.Bit),
                    new SqlParameter("OrderType", SqlDbType.Bit),
                    new SqlParameter("strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Sys_Task";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
