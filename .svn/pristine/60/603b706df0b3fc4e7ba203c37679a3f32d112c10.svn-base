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
    /// 数据访问类:crm_follow_end
    /// </summary>
    public partial class crm_follow_end
    {
        public crm_follow_end()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_follow_end");
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
        public bool Add(XHD.Model.crm_follow_end model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_follow_end(");
            strSql.Append("Factory_Id,Customer_id_end,Customer_name_end,Follow,Follow_date,Follow_Type_id,Follow_Type,department_id,department_name,employee_id,employee_name,isDelete,Delete_time)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@Customer_id_end,@Customer_name_end,@Follow,@Follow_date,@Follow_Type_id,@Follow_Type,@department_id,@department_name,@employee_id,@employee_name,@isDelete,@Delete_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Customer_id_end", MySqlDbType.Int32,11),
					new MySqlParameter("@Customer_name_end", MySqlDbType.VarChar,250),
					new MySqlParameter("@Follow", MySqlDbType.LongText),
					new MySqlParameter("@Follow_date", MySqlDbType.DateTime),
					new MySqlParameter("@Follow_Type_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Follow_Type", MySqlDbType.VarChar,250),
					new MySqlParameter("@department_id", MySqlDbType.Int32,11),
					new MySqlParameter("@department_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@employee_id", MySqlDbType.Int32,11),
					new MySqlParameter("@employee_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,11),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Customer_id_end;
            parameters[2].Value = model.Customer_name_end;
            parameters[3].Value = model.Follow;
            parameters[4].Value = model.Follow_date;
            parameters[5].Value = model.Follow_Type_id;
            parameters[6].Value = model.Follow_Type;
            parameters[7].Value = model.department_id;
            parameters[8].Value = model.department_name;
            parameters[9].Value = model.employee_id;
            parameters[10].Value = model.employee_name;
            parameters[11].Value = model.isDelete;
            parameters[12].Value = model.Delete_time;

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
        public bool Update(XHD.Model.crm_follow_end model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_follow_end set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("Customer_id_end=@Customer_id_end,");
            strSql.Append("Customer_name_end=@Customer_name_end,");
            strSql.Append("Follow=@Follow,");
            strSql.Append("Follow_date=@Follow_date,");
            strSql.Append("Follow_Type_id=@Follow_Type_id,");
            strSql.Append("Follow_Type=@Follow_Type,");
            strSql.Append("department_id=@department_id,");
            strSql.Append("department_name=@department_name,");
            strSql.Append("employee_id=@employee_id,");
            strSql.Append("employee_name=@employee_name,");
            strSql.Append("isDelete=@isDelete,");
            strSql.Append("Delete_time=@Delete_time");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Customer_id_end", MySqlDbType.Int32,11),
					new MySqlParameter("@Customer_name_end", MySqlDbType.VarChar,250),
					new MySqlParameter("@Follow", MySqlDbType.LongText),
					new MySqlParameter("@Follow_date", MySqlDbType.DateTime),
					new MySqlParameter("@Follow_Type_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Follow_Type", MySqlDbType.VarChar,250),
					new MySqlParameter("@department_id", MySqlDbType.Int32,11),
					new MySqlParameter("@department_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@employee_id", MySqlDbType.Int32,11),
					new MySqlParameter("@employee_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,11),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Customer_id_end;
            parameters[2].Value = model.Customer_name_end;
            parameters[3].Value = model.Follow;
            parameters[4].Value = model.Follow_date;
            parameters[5].Value = model.Follow_Type_id;
            parameters[6].Value = model.Follow_Type;
            parameters[7].Value = model.department_id;
            parameters[8].Value = model.department_name;
            parameters[9].Value = model.employee_id;
            parameters[10].Value = model.employee_name;
            parameters[11].Value = model.isDelete;
            parameters[12].Value = model.Delete_time;
            parameters[13].Value = model.id;

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
            strSql.Append("delete from crm_follow_end ");
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
            strSql.Append("delete from crm_follow_end ");
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
        public XHD.Model.crm_follow_end GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,Customer_id_end,Customer_name_end,Follow,Follow_date,Follow_Type_id,Follow_Type,department_id,department_name,employee_id,employee_name,isDelete,Delete_time from crm_follow_end ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.crm_follow_end model = new XHD.Model.crm_follow_end();
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
        public XHD.Model.crm_follow_end DataRowToModel(DataRow row)
        {
            XHD.Model.crm_follow_end model = new XHD.Model.crm_follow_end();
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
                if (row["Customer_id_end"] != null && row["Customer_id_end"].ToString() != "")
                {
                    model.Customer_id_end = int.Parse(row["Customer_id_end"].ToString());
                }
                if (row["Customer_name_end"] != null)
                {
                    model.Customer_name_end = row["Customer_name_end"].ToString();
                }
                if (row["Follow"] != null)
                {
                    model.Follow = row["Follow"].ToString();
                }
                if (row["Follow_date"] != null && row["Follow_date"].ToString() != "")
                {
                    model.Follow_date = DateTime.Parse(row["Follow_date"].ToString());
                }
                if (row["Follow_Type_id"] != null && row["Follow_Type_id"].ToString() != "")
                {
                    model.Follow_Type_id = int.Parse(row["Follow_Type_id"].ToString());
                }
                if (row["Follow_Type"] != null)
                {
                    model.Follow_Type = row["Follow_Type"].ToString();
                }
                if (row["department_id"] != null && row["department_id"].ToString() != "")
                {
                    model.department_id = int.Parse(row["department_id"].ToString());
                }
                if (row["department_name"] != null)
                {
                    model.department_name = row["department_name"].ToString();
                }
                if (row["employee_id"] != null && row["employee_id"].ToString() != "")
                {
                    model.employee_id = int.Parse(row["employee_id"].ToString());
                }
                if (row["employee_name"] != null)
                {
                    model.employee_name = row["employee_name"].ToString();
                }
                if (row["isDelete"] != null && row["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(row["isDelete"].ToString());
                }
                if (row["Delete_time"] != null && row["Delete_time"].ToString() != "")
                {
                    model.Delete_time = DateTime.Parse(row["Delete_time"].ToString());
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
            strSql.Append("select id,Factory_Id,Customer_id_end,Customer_name_end,Follow,Follow_date,Follow_Type_id,Follow_Type,department_id,department_name,employee_id,employee_name,isDelete,Delete_time ");
            strSql.Append(" FROM crm_follow_end ");
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
            strSql.Append("select ");
            strSql.Append(" * FROM crm_follow_end ");
            strSql1.Append(" select count(id) FROM crm_follow_end ");
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM crm_follow_end ");
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
            strSql.Append(")AS Row, T.*  from crm_follow_end T ");
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
            MySqlParameter[] parameters = {
                    new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
                    new MySqlParameter("@PageSize", MySqlDbType.Int32),
                    new MySqlParameter("@PageIndex", MySqlDbType.Int32),
                    new MySqlParameter("@IsReCount", MySqlDbType.Bit),
                    new MySqlParameter("@OrderType", MySqlDbType.Bit),
                    new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "crm_follow_end";
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

