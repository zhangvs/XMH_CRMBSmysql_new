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
    /// 数据访问类:crm_set_pubpri_detail
    /// </summary>
    public partial class crm_set_pubpri_detail
    {
        public crm_set_pubpri_detail()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "crm_set_pubpri_detail");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_set_pubpri_detail");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_set_pubpri_detail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_set_pubpri_detail(");
            strSql.Append("Id,pubpri_id,factory_Id,date_start,date_end,emp_Id,emp_name,emp_Qty,emp_Qty_used,C_createId,C_createName,C_createDate)");
            strSql.Append(" values (");
            strSql.Append("@Id,@pubpri_id,@factory_Id,@date_start,@date_end,@emp_Id,@emp_name,@emp_Qty,@emp_Qty_used,@C_createId,@C_createName,@C_createDate)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@pubpri_id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@date_start", MySqlDbType.Int32,11),
					new MySqlParameter("@date_end", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_Qty", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_Qty_used", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.pubpri_id;
            parameters[2].Value = model.factory_Id;
            parameters[3].Value = model.date_start;
            parameters[4].Value = model.date_end;
            parameters[5].Value = model.emp_Id;
            parameters[6].Value = model.emp_name;
            parameters[7].Value = model.emp_Qty;
            parameters[8].Value = model.emp_Qty_used;
            parameters[9].Value = model.C_createId;
            parameters[10].Value = model.C_createName;
            parameters[11].Value = model.C_createDate;

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
        public bool Update(XHD.Model.crm_set_pubpri_detail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_set_pubpri_detail set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("emp_Qty=@emp_Qty");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_Qty", MySqlDbType.Int32,11),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.emp_Qty;
            parameters[2].Value = model.Id;

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
        public bool Update1(XHD.Model.crm_set_pubpri_detail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_set_pubpri set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("dept_Qty=@dept_Qty");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@dept_Qty", MySqlDbType.Int32,11),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.emp_Qty;
            parameters[2].Value = model.Id;

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
        public bool updateQtyUser(int detailid, int emp_Qty_used)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_set_pubpri_detail set "); ;
            strSql.Append("emp_Qty_used=@emp_Qty_used ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@emp_Qty_used", MySqlDbType.Int32,11),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = emp_Qty_used;
            parameters[1].Value = detailid;

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
            strSql.Append("delete from crm_set_pubpri_detail ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
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
            strSql.Append("delete from crm_set_pubpri_detail ");
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
        public bool DeleteList1(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_set_pubpri_detail ");
            strSql.Append(" where pubpri_id in (" + Idlist + ")  ");
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
        public XHD.Model.crm_set_pubpri_detail GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,pubpri_id,factory_Id,date_start,date_end,emp_Id,emp_name,emp_Qty,emp_Qty_used,C_createId,C_createName,C_createDate from crm_set_pubpri_detail ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            XHD.Model.crm_set_pubpri_detail model = new XHD.Model.crm_set_pubpri_detail();
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
        public XHD.Model.crm_set_pubpri_detail DataRowToModel(DataRow row)
        {
            XHD.Model.crm_set_pubpri_detail model = new XHD.Model.crm_set_pubpri_detail();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["pubpri_id"] != null && row["pubpri_id"].ToString() != "")
                {
                    model.pubpri_id = int.Parse(row["pubpri_id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["date_start"] != null && row["date_start"].ToString() != "")
                {
                    model.date_start = int.Parse(row["date_start"].ToString());
                }
                if (row["date_end"] != null && row["date_end"].ToString() != "")
                {
                    model.date_end = int.Parse(row["date_end"].ToString());
                }
                if (row["emp_Id"] != null && row["emp_Id"].ToString() != "")
                {
                    model.emp_Id = int.Parse(row["emp_Id"].ToString());
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["emp_Qty"] != null && row["emp_Qty"].ToString() != "")
                {
                    model.emp_Qty = int.Parse(row["emp_Qty"].ToString());
                }
                if (row["emp_Qty_used"] != null && row["emp_Qty_used"].ToString() != "")
                {
                    model.emp_Qty_used = int.Parse(row["emp_Qty_used"].ToString());
                }
                if (row["C_createId"] != null && row["C_createId"].ToString() != "")
                {
                    model.C_createId = int.Parse(row["C_createId"].ToString());
                }
                if (row["C_createName"] != null)
                {
                    model.C_createName = row["C_createName"].ToString();
                }
                if (row["C_createDate"] != null && row["C_createDate"].ToString() != "")
                {
                    model.C_createDate = DateTime.Parse(row["C_createDate"].ToString());
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
            strSql.Append("select Id,pubpri_id,factory_Id,date_start,date_end,emp_Id,emp_name,emp_Qty,emp_Qty_used,C_createId,C_createName,C_createDate ");
            strSql.Append(" FROM crm_set_pubpri_detail ");
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
            strSql.Append(" select Id,pubpri_id,factory_Id,date_start,date_end,emp_Id,emp_name,emp_Qty,emp_Qty_used,C_createId,C_createName,C_createDate FROM crm_set_pubpri_detail ");
            strSql1.Append(" select count(id) FROM crm_set_pubpri_detail ");
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
        /// 分页获取数据列表，包括部门和人员
        /// </summary>
        public DataSet GetListAndDept(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select * from (  ");
            strSql.Append(" select Id,pubpri_id,factory_Id,date_start,date_end,emp_Id,emp_name,emp_Qty,emp_Qty_used,C_createId,C_createName,C_createDate,1 as type FROM crm_set_pubpri_detail ");
            strSql1.Append(" select sum(num) from( ");
            strSql1.Append(" select count(id) as num FROM crm_set_pubpri_detail ");

            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
                strSql1.Append(" where " + strWhere1);
            }
            strSql.Append(" union all  ");
            strSql1.Append(" union all  ");
            strSql.Append(" select  p.Id,p.parent_id as pubpri_id,p.factory_Id,p.date_start,p.date_end,p.dept_Id as emp_Id,p.dept_name as emp_name,p.dept_Qty as emp_Qty,'' as emp_Qty_used,p.C_createId,p.C_createName,p.C_createDate,2 as type ");
            strSql.Append(" FROM crm_set_pubpri as p ");
            strSql1.Append(" select count(id) as num FROM crm_set_pubpri as p ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
                strSql1.Append(" where " + strWhere2);
            }
            strSql1.Append(" ) as aa ");
            strSql.Append(") as abc ");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取某个时间段已经抓取的客户数量
        /// </summary>
        public DataSet GetSumUse(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(emp_Qty_used) sumUse ");
            strSql.Append(" FROM crm_set_pubpri_detail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取某个时间段已经被分配的数量，不包括备操作人员
        /// </summary>
        public DataSet GetSum(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(emp_Qty) sum ");
            strSql.Append(" FROM crm_set_pubpri_detail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据外键删除数据
        /// </summary>
        public bool DeleteByFK(int Id, string factory_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_set_pubpri_detail ");
            strSql.Append(" where pubpri_id=@pubpri_id ");
            strSql.Append(" and factory_id=@factory_id  ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pubpri_id", MySqlDbType.Int32,11),
                    new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60)                   };
            parameters[0].Value = Id;
            parameters[1].Value = factory_id;
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

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

