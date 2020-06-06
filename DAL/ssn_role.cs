using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ssn_role
    /// </summary>
    public partial class ssn_role
    {
        public ssn_role()
        { }
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("RoleID", "ssn_role");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int RoleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ssn_role");
            strSql.Append(" where RoleID=@RoleID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@RoleID", MySqlDbType.Int32,4)};
            parameters[0].Value = RoleID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.ssn_role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ssn_role(");
            strSql.Append("Factory_Id,RoleName,RoleDscript,RoleSort,CreateID,CreateDate,UpdateID,UpdateDate)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@RoleName,@RoleDscript,@RoleSort,@CreateID,@CreateDate,@UpdateID,@UpdateDate)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@RoleName", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleDscript", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleSort", MySqlDbType.Int32,4),
					new MySqlParameter("@CreateID", MySqlDbType.Int32,4),
					new MySqlParameter("@CreateDate", MySqlDbType.DateTime),
					new MySqlParameter("@UpdateID", MySqlDbType.Int32,4),
					new MySqlParameter("@UpdateDate", MySqlDbType.DateTime)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.RoleName;
            parameters[2].Value = model.RoleDscript;
            parameters[3].Value = model.RoleSort;
            parameters[4].Value = model.CreateID;
            parameters[5].Value = model.CreateDate;
            parameters[6].Value = model.UpdateID;
            parameters[7].Value = model.UpdateDate;

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
        public bool Update(XHD.Model.ssn_role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_role set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("RoleName=@RoleName,");
            strSql.Append("RoleDscript=@RoleDscript,");
            strSql.Append("RoleSort=@RoleSort,");
            strSql.Append("UpdateID=@UpdateID,");
            strSql.Append("UpdateDate=@UpdateDate");
            strSql.Append(" where RoleID=@RoleID");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@RoleName", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleDscript", MySqlDbType.VarChar,255),
					new MySqlParameter("@RoleSort", MySqlDbType.Int32,4),					
					new MySqlParameter("@UpdateID", MySqlDbType.Int32,4),
					new MySqlParameter("@UpdateDate", MySqlDbType.DateTime),
					new MySqlParameter("@RoleID", MySqlDbType.Int32,4)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.RoleName;
            parameters[2].Value = model.RoleDscript;
            parameters[3].Value = model.RoleSort;
            parameters[4].Value = model.UpdateID;
            parameters[5].Value = model.UpdateDate;
            parameters[6].Value = model.RoleID;

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
        /// 预删除
        /// </summary>
        public bool AdvanceDelete(int id, int isDelete, string time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_role set ");
            strSql.Append("isDelete=" + isDelete);
            strSql.Append(",Delete_time='" + time + "'");
            strSql.Append(" where id=" + id);
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
        public bool Delete(int RoleID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_role ");
            strSql.Append(" where RoleID=@RoleID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@RoleID", MySqlDbType.Int32,4)
};
            parameters[0].Value = RoleID;

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
        public bool DeleteList(string RoleIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_role ");
            strSql.Append(" where RoleID in (" + RoleIDlist + ")  ");
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
        public XHD.Model.ssn_role GetModel(int RoleID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  RoleID,Factory_Id,RoleName,RoleDscript,RoleSort,CreateID,CreateDate,UpdateID,UpdateDate from ssn_role ");
            strSql.Append(" where RoleID=@RoleID limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@RoleID", MySqlDbType.Int32,4)
};
            parameters[0].Value = RoleID;

            XHD.Model.ssn_role model = new XHD.Model.ssn_role();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["RoleID"] != null && ds.Tables[0].Rows[0]["RoleID"].ToString() != "")
                {
                    model.RoleID = int.Parse(ds.Tables[0].Rows[0]["RoleID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RoleName"] != null && ds.Tables[0].Rows[0]["RoleName"].ToString() != "")
                {
                    model.RoleName = ds.Tables[0].Rows[0]["RoleName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["RoleDscript"] != null && ds.Tables[0].Rows[0]["RoleDscript"].ToString() != "")
                {
                    model.RoleDscript = ds.Tables[0].Rows[0]["RoleDscript"].ToString();
                }
                if (ds.Tables[0].Rows[0]["RoleSort"] != null && ds.Tables[0].Rows[0]["RoleSort"].ToString() != "")
                {
                    model.RoleSort = int.Parse(ds.Tables[0].Rows[0]["RoleSort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreateID"] != null && ds.Tables[0].Rows[0]["CreateID"].ToString() != "")
                {
                    model.CreateID = int.Parse(ds.Tables[0].Rows[0]["CreateID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreateDate"] != null && ds.Tables[0].Rows[0]["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(ds.Tables[0].Rows[0]["CreateDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpdateID"] != null && ds.Tables[0].Rows[0]["UpdateID"].ToString() != "")
                {
                    model.UpdateID = int.Parse(ds.Tables[0].Rows[0]["UpdateID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpdateDate"] != null && ds.Tables[0].Rows[0]["UpdateDate"].ToString() != "")
                {
                    model.UpdateDate = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateDate"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select RoleID,Factory_Id,RoleName,RoleDscript,RoleSort,CreateID,CreateDate,UpdateID,UpdateDate ");
            strSql.Append(" FROM ssn_role ");
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

            strSql.Append(" RoleID,Factory_Id,RoleName,RoleDscript,RoleSort,CreateID,CreateDate,UpdateID,UpdateDate ");
            strSql.Append(" FROM ssn_role ");
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  * FROM ssn_role ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM ssn_role ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM ssn_role ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

