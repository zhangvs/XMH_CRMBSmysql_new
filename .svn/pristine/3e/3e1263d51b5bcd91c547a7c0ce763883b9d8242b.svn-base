using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;//Please add references

namespace XHD.DAL.ims
{
    /// <summary>
    /// 数据访问类:ims_check_rule
    /// </summary>
    public partial class ims_check_rule
    {
        public ims_check_rule()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "ims_check_rule");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ims_check_rule");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.ims.ims_check_rule model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ims_check_rule(");
            strSql.Append("id,Factory_Id,rule_name,rule_categoryId,rule_category,rule_classify,check_cycle,check_empId,check_empName,check_emp_depId,apply_depId,apply_userId,apply_userName,creat_empId,create_empName,create_date,rule_object)");
            strSql.Append(" values (");
            strSql.Append("@id,@Factory_Id,@rule_name,@rule_categoryId,@rule_category,@rule_classify,@check_cycle,@check_empId,@check_empName,@check_emp_depId,@apply_depId,@apply_userId,@apply_userName,@creat_empId,@create_empName,@create_date,@rule_object)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@rule_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@rule_categoryId", MySqlDbType.Int32,11),
					new MySqlParameter("@rule_category", MySqlDbType.VarChar,100),
					new MySqlParameter("@rule_classify", MySqlDbType.VarChar,1),
					new MySqlParameter("@check_cycle", MySqlDbType.VarChar,60),
					new MySqlParameter("@check_empId", MySqlDbType.Text),
					new MySqlParameter("@check_empName", MySqlDbType.Text),
					new MySqlParameter("@check_emp_depId", MySqlDbType.Text),
					new MySqlParameter("@apply_depId", MySqlDbType.Text),
					new MySqlParameter("@apply_userId", MySqlDbType.Text),
					new MySqlParameter("@apply_userName", MySqlDbType.Text),
					new MySqlParameter("@creat_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@create_empName", MySqlDbType.VarChar,50),
				    new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@rule_object", MySqlDbType.VarChar,1)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.Factory_Id;
            parameters[2].Value = model.rule_name;
            parameters[3].Value = model.rule_categoryId;
            parameters[4].Value = model.rule_category;
            parameters[5].Value = model.rule_classify;
            parameters[6].Value = model.check_cycle;
            parameters[7].Value = model.check_empId;
            parameters[8].Value = model.check_empName;
            parameters[9].Value = model.check_emp_depId;
            parameters[10].Value = model.apply_depId;
            parameters[11].Value = model.apply_userId;
            parameters[12].Value = model.apply_userName;
            parameters[13].Value = model.creat_empId;
            parameters[14].Value = model.create_empName;
            parameters[15].Value = model.create_date;
            parameters[16].Value = model.rule_object;

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
        public bool Update(XHD.Model.ims.ims_check_rule model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ims_check_rule set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("rule_name=@rule_name,");
            strSql.Append("rule_categoryId=@rule_categoryId,");
            strSql.Append("rule_category=@rule_category,");
            strSql.Append("rule_classify=@rule_classify,");
            strSql.Append("check_cycle=@check_cycle,");
            strSql.Append("check_empId=@check_empId,");
            strSql.Append("check_empName=@check_empName,");
            strSql.Append("check_emp_depId=@check_emp_depId,");
            strSql.Append("apply_depId=@apply_depId,");
            strSql.Append("apply_userId=@apply_userId,");
            strSql.Append("apply_userName=@apply_userName,");
            strSql.Append("creat_empId=@creat_empId,");
            strSql.Append("create_empName=@create_empName,");
            strSql.Append("create_date=@create_date");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@rule_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@rule_categoryId", MySqlDbType.Int32,11),
					new MySqlParameter("@rule_category", MySqlDbType.VarChar,100),
					new MySqlParameter("@rule_classify", MySqlDbType.VarChar,1),
					new MySqlParameter("@check_cycle", MySqlDbType.VarChar,60),
					new MySqlParameter("@check_empId", MySqlDbType.Text),
					new MySqlParameter("@check_empName", MySqlDbType.Text),
					new MySqlParameter("@check_emp_depId", MySqlDbType.Text),
					new MySqlParameter("@apply_depId", MySqlDbType.Text),
					new MySqlParameter("@apply_userId", MySqlDbType.Text),
					new MySqlParameter("@apply_userName", MySqlDbType.Text),
					new MySqlParameter("@creat_empId", MySqlDbType.Int32,11),
					new MySqlParameter("@create_empName", MySqlDbType.VarChar,50),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.rule_name;
            parameters[2].Value = model.rule_categoryId;
            parameters[3].Value = model.rule_category;
            parameters[4].Value = model.rule_classify;
            parameters[5].Value = model.check_cycle;
            parameters[6].Value = model.check_empId;
            parameters[7].Value = model.check_empName;
            parameters[8].Value = model.check_emp_depId;
            parameters[9].Value = model.apply_depId;
            parameters[10].Value = model.apply_userId;
            parameters[11].Value = model.apply_userName;
            parameters[12].Value = model.creat_empId;
            parameters[13].Value = model.create_empName;
            parameters[14].Value = model.create_date;
            parameters[15].Value = model.id;

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
            strSql.Append("delete from ims_check_rule ");
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
            strSql.Append("delete from ims_check_rule ");
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
        public XHD.Model.ims.ims_check_rule GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,rule_name,rule_categoryId,rule_category,rule_classify,check_cycle,check_empId,check_empName,check_emp_depId,apply_depId,apply_userId,apply_userName,creat_empId,create_empName,create_date,rule_object from ims_check_rule ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.ims.ims_check_rule model = new XHD.Model.ims.ims_check_rule();
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
        public XHD.Model.ims.ims_check_rule DataRowToModel(DataRow row)
        {
            XHD.Model.ims.ims_check_rule model = new XHD.Model.ims.ims_check_rule();
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
                if (row["rule_name"] != null)
                {
                    model.rule_name = row["rule_name"].ToString();
                }
                if (row["rule_categoryId"] != null && row["rule_categoryId"].ToString() != "")
                {
                    model.rule_categoryId = int.Parse(row["rule_categoryId"].ToString());
                }
                if (row["rule_category"] != null)
                {
                    model.rule_category = row["rule_category"].ToString();
                }
                if (row["rule_classify"] != null)
                {
                    model.rule_classify = row["rule_classify"].ToString();
                }
                if (row["rule_object"] != null)
                {
                    model.rule_object = row["rule_object"].ToString();
                }
                if (row["check_cycle"] != null)
                {
                    model.check_cycle = row["check_cycle"].ToString();
                }
                if (row["check_empId"] != null)
                {
                    model.check_empId = row["check_empId"].ToString();
                }
                if (row["check_empName"] != null)
                {
                    model.check_empName = row["check_empName"].ToString();
                }
                if (row["check_emp_depId"] != null)
                {
                    model.check_emp_depId = row["check_emp_depId"].ToString();
                }
                if (row["apply_depId"] != null)
                {
                    model.apply_depId = row["apply_depId"].ToString();
                }
                if (row["apply_userId"] != null)
                {
                    model.apply_userId = row["apply_userId"].ToString();
                }
                if (row["apply_userName"] != null)
                {
                    model.apply_userName = row["apply_userName"].ToString();
                }
                if (row["creat_empId"] != null && row["creat_empId"].ToString() != "")
                {
                    model.creat_empId = int.Parse(row["creat_empId"].ToString());
                }
                if (row["create_empName"] != null)
                {
                    model.create_empName = row["create_empName"].ToString();
                }
                if (row["create_date"] != null && row["create_date"].ToString() != "")
                {
                    model.create_date = DateTime.Parse(row["create_date"].ToString());
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
            strSql.Append("select id,Factory_Id,rule_name,rule_categoryId,rule_category,rule_classify,check_cycle,check_empId,check_empName,check_emp_depId,apply_depId,apply_userId,apply_userName,creat_empId,create_empName,create_date,rule_object ");
            strSql.Append(" FROM ims_check_rule ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet getCheckUser(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT group_concat(apply_userId ) apply_userId FROM ims_check_rule ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetLists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select r.* ,h.d_name ");
            strSql.Append(" FROM ims_check_rule r left join hr_department h on r.apply_depId =h.id ");
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
            strSql.Append(" select h.d_name,r.id,r.Factory_Id,r.rule_name,r.rule_categoryId,r.rule_category,r.rule_classify,r.check_cycle,r.check_empId,r.check_empName,r.check_emp_depId,r.apply_depId,r.apply_userId,r.apply_userName,r.creat_empId,r.create_empName,r.create_date,r.rule_object ");
            strSql.Append(" from ims_check_rule  r left join hr_department h on r.apply_depId=h.id ");
            strSql1.Append(" select count(r.id) FROM ims_check_rule r ");
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
        /// 分页获取数据列表----根据部门及员工ID查询该员工所具有的考核规则
        /// </summary>
        public DataSet GetRuleByDEID(int PageSize, int PageIndex, string strWhere, int emp_id, string empId, string depId, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select  distinct r.id,r.Factory_Id,r.rule_name,r.rule_categoryId,r.rule_category,r.rule_classify,r.check_cycle,r.check_empId,r.check_empName,r.check_emp_depId,r.apply_depId,r.apply_userId,r.apply_userName,r.creat_empId,r.create_empName,r.create_date,r.rule_object from ( ");

            strSql.Append("select * from ims_check_rule where apply_depId='-1' and  ( ( apply_userId='-1' or apply_userId is null)  or  FIND_IN_SET('" + empId + "',apply_userId)  )   and  " + strWhere + "");
            strSql.Append("union all ");
            strSql.Append("select * from ims_check_rule where apply_depId in(" + depId + ") and  ( FIND_IN_SET('" + empId + "',apply_userId)  or ( apply_userId='-1' or apply_userId is null)  ) and  " + strWhere + "");
            strSql.Append(" ) as r ");

            strSql1.Append("select count(distinct r.id) from ( ");
            strSql1.Append("select * from ims_check_rule where apply_depId='-1' and  ( ( apply_userId='-1' or apply_userId is null)  or  FIND_IN_SET('" + empId + "',apply_userId)  )   and  " + strWhere + "");
            strSql1.Append("union all ");
            strSql1.Append("select * from ims_check_rule where apply_depId in(" + depId + ") and  ( FIND_IN_SET('" + empId + "',apply_userId)  or ( apply_userId='-1' or apply_userId is null)  ) and  " + strWhere + "");
            strSql1.Append(" ) as r ");

            if (emp_id != -1)
            {
                strSql.Append(" where r.check_empId='" + emp_id + "' ");
                strSql1.Append(" where r.check_empId='" + emp_id + "'  ");
            }

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表----查询部门负责人的考核规则
        /// </summary>
        public DataSet GetRuleLead(int PageSize, int PageIndex, string strWhere, int emp_id, string empId, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select * from ims_check_rule where  ( FIND_IN_SET('" + empId + "',apply_userId)  or ( apply_userId='-1' or apply_userId is null)  ) and  " + strWhere + "");
            strSql1.Append(" select count(*) from ims_check_rule where  ( FIND_IN_SET('" + empId + "',apply_userId)  or ( apply_userId='-1' or apply_userId is null)  ) and  " + strWhere + "");
            if (emp_id != -1)
            {
                strSql.Append(" and FIND_IN_SET('" + emp_id + "',check_empId )");
                strSql1.Append(" and FIND_IN_SET('" + emp_id + "',check_empId )");
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 删除考核规则、项目、标准
        /// </summary>
        public bool DeleteRSS(string id)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            strSql = string.Format(@" delete from ims_check_rule where id in (" + id + ")");
            strSqlList.Add(strSql);

            strSql = string.Format(@" delete from ims_check_task where rule_id in (" + id + ")");
            strSqlList.Add(strSql);

            strSql = string.Format(@" delete from ims_check_task_standard where rule_id in (" + id + ")");
            strSqlList.Add(strSql);

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

