using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using XHD.DBUtility;

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_dept_copyauth
    /// </summary>
    public partial class crm_dept_copyauth
    {
        public crm_dept_copyauth()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_dept_copyauth");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_dept_copyauth model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_dept_copyauth(");
            strSql.Append("factory_Id,emp_Id,emp_name,dept_Id,dept_name,C_valid_Date,C_createId,C_createName,C_createDate)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@emp_Id,@emp_name,@dept_Id,@dept_name,@C_valid_Date,@C_createId,@C_createName,@C_createDate)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@dept_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@dept_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_valid_Date", MySqlDbType.VarChar,20),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.emp_Id;
            parameters[2].Value = model.emp_name;
            parameters[3].Value = model.dept_Id;
            parameters[4].Value = model.dept_name;
            parameters[5].Value = model.C_valid_Date;
            parameters[6].Value = model.C_createId;
            parameters[7].Value = model.C_createName;
            parameters[8].Value = model.C_createDate;

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
        public bool Update(XHD.Model.crm_dept_copyauth model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_dept_copyauth set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("emp_Id=@emp_Id,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("dept_Id=@dept_Id,");
            strSql.Append("dept_name=@dept_name,");
            strSql.Append("C_valid_Date=@C_valid_Date,");
            strSql.Append("C_createId=@C_createId,");
            strSql.Append("C_createName=@C_createName,");
            strSql.Append("C_createDate=@C_createDate");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@dept_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@dept_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_valid_Date", MySqlDbType.VarChar,20),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.emp_Id;
            parameters[2].Value = model.emp_name;
            parameters[3].Value = model.dept_Id;
            parameters[4].Value = model.dept_name;
            parameters[5].Value = model.C_valid_Date;
            parameters[6].Value = model.C_createId;
            parameters[7].Value = model.C_createName;
            parameters[8].Value = model.C_createDate;
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
            strSql.Append("delete from crm_dept_copyauth ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
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
            strSql.Append("delete from crm_dept_copyauth ");
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
        /// 删除多条数据根据empid
        /// </summary>
        public bool DeleteByEmpid(string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_dept_copyauth ");
            strSql.Append(" where " + strwhere );
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
        public XHD.Model.crm_dept_copyauth GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,factory_Id,emp_Id,emp_name,dept_Id,dept_name,C_valid_Date,C_createId,C_createName,C_createDate from crm_dept_copyauth ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.crm_dept_copyauth model = new XHD.Model.crm_dept_copyauth();
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
        public XHD.Model.crm_dept_copyauth DataRowToModel(DataRow row)
        {
            XHD.Model.crm_dept_copyauth model = new XHD.Model.crm_dept_copyauth();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["emp_Id"] != null && row["emp_Id"].ToString() != "")
                {
                    model.emp_Id = int.Parse(row["emp_Id"].ToString());
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["dept_Id"] != null && row["dept_Id"].ToString() != "")
                {
                    model.dept_Id = int.Parse(row["dept_Id"].ToString());
                }
                if (row["dept_name"] != null)
                {
                    model.dept_name = row["dept_name"].ToString();
                }
                if (row["C_valid_Date"] != null)
                {
                    model.C_valid_Date = row["C_valid_Date"].ToString();
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
            strSql.Append("select id,factory_Id,emp_Id,emp_name,dept_Id,dept_name,C_valid_Date,C_createId,C_createName,C_createDate ");
            strSql.Append(" FROM crm_dept_copyauth ");
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
            strSql.Append("select count(1) FROM crm_dept_copyauth ");
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
            strSql.Append(")AS Row, T.*  from crm_dept_copyauth T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListPage(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            if (strWhere.Equals("") || strWhere == null)
                strWhere = "1=1";
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" id,factory_Id,emp_Id,emp_name,dept_Id,dept_name,C_valid_Date,C_createId,C_createName,C_createDate FROM crm_dept_copyauth ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Sys_FactoryInfo ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM crm_dept_copyauth ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            DataSet ds= DbHelperMySQL.Query(strSql.ToString());
            DataTable dt = ds.Tables[0];
            return ds;
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListPerson(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            if (strWhere.Equals("") || strWhere == null)
                strWhere = "1=1";
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select distinct ");
            strSql.Append(" e.* FROM hr_employee as e ");
            strSql.Append(" inner join crm_dept_copyauth as c on e.id=c.emp_id ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Sys_FactoryInfo ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(distinct c.emp_id) FROM crm_dept_copyauth as c ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString());
            DataTable dt = ds.Tables[0];
            return ds;
        }
        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            MySqlParameter[] parameters = {
                    new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@PageSize", MySqlDbType.Int32),
                    new MySqlParameter("@PageIndex", MySqlDbType.Int32),
                    new MySqlParameter("@IsReCount", MySqlDbType.Bit),
                    new MySqlParameter("@OrderType", MySqlDbType.Bit),
                    new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "crm_dept_copyauth";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

