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
    /// 数据访问类:crm_set_pubpri
    /// </summary>
    public partial class crm_set_pubpri
    {
        public crm_set_pubpri()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "crm_set_pubpri");
        }

        /// <summary>
        /// 得到公共客户的数量
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int getPublicNum(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            int count = 0;
            strSql.Append("select count(id) from CRM_Customer ");
            if (strWhere.Trim() != "")
                strSql.Append(" where " + strWhere);

            count = Convert.ToInt32(DbHelperMySQL.GetSingles(strSql.ToString()));
            return count;
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_set_pubpri");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_set_pubpri model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_set_pubpri(");
            strSql.Append("Id,parent_Id,factory_Id,date_start,date_end,dept_Id,dept_name,dept_Qty,C_createId,C_createName,C_createDate)");
            strSql.Append(" values (");
            strSql.Append("@Id,@parent_Id,@factory_Id,@date_start,@date_end,@dept_Id,@dept_name,@dept_Qty,@C_createId,@C_createName,@C_createDate)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
                    new MySqlParameter("@parent_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@date_start", MySqlDbType.Int32,11),
					new MySqlParameter("@date_end", MySqlDbType.Int32,11),
					new MySqlParameter("@dept_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@dept_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@dept_Qty", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.parent_Id;
            parameters[2].Value = model.factory_Id;
            parameters[3].Value = model.date_start;
            parameters[4].Value = model.date_end;
            parameters[5].Value = model.dept_Id;
            parameters[6].Value = model.dept_name;
            parameters[7].Value = model.dept_Qty;
            parameters[8].Value = model.C_createId;
            parameters[9].Value = model.C_createName;
            parameters[10].Value = model.C_createDate;

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
        public bool Update(XHD.Model.crm_set_pubpri model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_set_pubpri set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("date_start=@date_start,");
            strSql.Append("date_end=@date_end,");
            strSql.Append("dept_Qty=@dept_Qty");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@date_start", MySqlDbType.Int32,11),
					new MySqlParameter("@date_end", MySqlDbType.Int32,11),
					new MySqlParameter("@dept_Qty", MySqlDbType.Int32,11),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.date_start;
            parameters[2].Value = model.date_end;
            parameters[3].Value = model.dept_Qty;
            parameters[4].Value = model.Id;

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
            strSql.Append("delete from crm_set_pubpri ");
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
            strSql.Append("delete from crm_set_pubpri ");
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
        public XHD.Model.crm_set_pubpri GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,parent_Id,factory_Id,date_start,date_end,dept_Id,dept_name,dept_Qty,C_createId,C_createName,C_createDate from crm_set_pubpri ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            XHD.Model.crm_set_pubpri model = new XHD.Model.crm_set_pubpri();
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
        public XHD.Model.crm_set_pubpri DataRowToModel(DataRow row)
        {
            XHD.Model.crm_set_pubpri model = new XHD.Model.crm_set_pubpri();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["parent_Id"] != null && row["parent_Id"].ToString() != "")
                {
                    model.parent_Id = int.Parse(row["parent_Id"].ToString());
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
                if (row["dept_Id"] != null && row["dept_Id"].ToString() != "")
                {
                    model.dept_Id = int.Parse(row["dept_Id"].ToString());
                }
                if (row["dept_name"] != null)
                {
                    model.dept_name = row["dept_name"].ToString();
                }
                if (row["dept_Qty"] != null && row["dept_Qty"].ToString() != "")
                {
                    model.dept_Qty = int.Parse(row["dept_Qty"].ToString());
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
            strSql.Append("select Id,parent_Id,factory_Id,date_start,date_end,dept_Id,dept_name,dept_Qty,C_createId,C_createName,C_createDate ");
            strSql.Append(" FROM crm_set_pubpri ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListDept(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,parent_Id as pubpri_id,factory_Id,date_start,date_end,dept_Id as emp_Id,dept_name as emp_name,dept_Qty as emp_Qty,C_createId,C_createName,C_createDate ");
            strSql.Append(" FROM crm_set_pubpri ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取某个时间段已经被分配的数量,下级部门分配的数量
        /// </summary>
        public DataSet GetSum(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(dept_Qty) sum ");
            strSql.Append(" FROM crm_set_pubpri ");
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
            strSql.Append(" select Id,parent_Id,factory_Id,date_start,date_end,dept_Id,dept_name,dept_Qty,C_createId,C_createName,C_createDate FROM crm_set_pubpri ");
            strSql1.Append(" select count(id) FROM crm_set_pubpri ");
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
        public DataSet GetList1(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select p.Id,p.parent_Id,p.factory_Id,p.date_start,p.date_end,p.dept_Id,p.dept_name,p.dept_Qty,p.C_createId,p.C_createName,p.C_createDate,'' as dept_use FROM crm_set_pubpri as p ");
            //strSql.Append(" left join crm_set_pubpri_detail as d on p.Id=d.pubpri_id ");
            strSql1.Append(" select count(id) FROM crm_set_pubpri as p ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" group by p.id ");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


