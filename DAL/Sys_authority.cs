using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:Sys_authority
    /// </summary>
    public partial class Sys_authority
    {
        public Sys_authority()
        { }
        #region  Method



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(XHD.Model.Sys_authority model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sys_authority(");
            strSql.Append("Role_id,Factory_Id,App_ids,Menu_ids,Button_ids,Create_id,Create_date,Type)");
            strSql.Append(" values (");
            strSql.Append("@Role_id,@Factory_Id,@App_ids,@Menu_ids,@Button_ids,@Create_id,@Create_date,@Type)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Role_id", MySqlDbType.Int32,4),
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@App_ids", MySqlDbType.VarChar,250),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,10000),
					new MySqlParameter("@Button_ids", MySqlDbType.VarChar,10000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
                    new MySqlParameter("@Type", MySqlDbType.Int32,4)};
            parameters[0].Value = model.Role_id;
            parameters[1].Value = model.Factory_Id;
            parameters[2].Value = model.App_ids;
            parameters[3].Value = model.Menu_ids;
            parameters[4].Value = model.Button_ids;
            parameters[5].Value = model.Create_id;
            parameters[6].Value = model.Create_date;
            parameters[7].Value = model.Type;

            DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.Sys_authority model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sys_authority set ");
            strSql.Append("Menu_ids=@Menu_ids,");
            strSql.Append("Button_ids=@Button_ids,");
            strSql.Append("Create_id=@Create_id,");
            strSql.Append("Create_date=@Create_date");
            strSql.Append(" where ");
            strSql.Append(" Role_id=@Role_id");
            strSql.Append(" and Factory_Id=@Factory_Id");
            strSql.Append(" and App_ids=@App_ids");
            strSql.Append(" and Type=@Type");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,10000),
					new MySqlParameter("@Button_ids", MySqlDbType.VarChar,10000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@Role_id", MySqlDbType.Int32,4),
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@App_ids", MySqlDbType.VarChar,250),
                    new MySqlParameter("@Type", MySqlDbType.Int32,4)};

            parameters[0].Value = model.Menu_ids;
            parameters[1].Value = model.Button_ids;
            parameters[2].Value = model.Create_id;
            parameters[3].Value = model.Create_date;
            parameters[4].Value = model.Role_id;
            parameters[5].Value = model.Factory_Id;
            parameters[6].Value = model.App_ids;
            parameters[7].Value = model.Type;

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
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_authority ");
            strSql.Append(" where ");
            MySqlParameter[] parameters = {
};

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
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.Sys_authority GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  Role_id,Factory_Id,App_ids,Menu_ids,Button_ids,Create_id,Create_date from Sys_authority ");
            strSql.Append(" where  limit 1 ");
            MySqlParameter[] parameters = { };

            XHD.Model.Sys_authority model = new XHD.Model.Sys_authority();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Role_id"] != null && ds.Tables[0].Rows[0]["Role_id"].ToString() != "")
                {
                    model.Role_id = int.Parse(ds.Tables[0].Rows[0]["Role_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["App_ids"] != null && ds.Tables[0].Rows[0]["App_ids"].ToString() != "")
                {
                    model.App_ids = ds.Tables[0].Rows[0]["App_ids"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Menu_ids"] != null && ds.Tables[0].Rows[0]["Menu_ids"].ToString() != "")
                {
                    model.Menu_ids = ds.Tables[0].Rows[0]["Menu_ids"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Button_ids"] != null && ds.Tables[0].Rows[0]["Button_ids"].ToString() != "")
                {
                    model.Button_ids = ds.Tables[0].Rows[0]["Button_ids"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Create_id"] != null && ds.Tables[0].Rows[0]["Create_id"].ToString() != "")
                {
                    model.Create_id = int.Parse(ds.Tables[0].Rows[0]["Create_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Create_date"] != null && ds.Tables[0].Rows[0]["Create_date"].ToString() != "")
                {
                    model.Create_date = DateTime.Parse(ds.Tables[0].Rows[0]["Create_date"].ToString());
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
            strSql.Append("select Type,Role_id,Factory_Id,App_ids,Menu_ids,Button_ids,Create_id,Create_date ");
            strSql.Append(" FROM Sys_authority ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 通过facotyId获取公司权限
        /// </summary>
        public DataSet GetSysByFID(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select distinct app_type from sys_app where id in(select  replace((replace( app_ids,'a','')),',','') from sys_authority_factory ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(") ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 通过facotyId获取公司权限
        /// </summary>
        public DataSet GetAppByFID(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select  replace((replace( app_ids,'a','')),',','') as app_id from sys_authority_factory ");
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

            strSql.Append(" Role_id,Factory_Id,App_ids,Menu_ids,Button_ids,Create_id,Create_date ");
            strSql.Append(" FROM Sys_authority ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
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
            strSql.Append("  * FROM Sys_authority ");
            //strSql.Append(" WHERE id not in ( SELECT id FROM Sys_authority limit " + (PageIndex - 1) * PageSize + " ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM Sys_authority ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteWhere(string wherestr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sys_authority ");
            strSql.Append(" where " + wherestr + "  ");
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
        /// 获取某个factoyr的全部角色的权限
        /// </summary>
        public DataSet GetRoleAuth(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.Role_id,a.Type,a.Factory_Id,a.App_ids,a.Menu_ids,a.Button_ids,a.Create_id,a.Create_date ");
            strSql.Append("  FROM Sys_authority as a");
            //strSql.Append("  FROM Sys_authority as a inner join  Sys_role as r on a.factory_id=r.factory_id and a.role_id=r.roleid");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取某个factoyr的全部角色的权限
        /// </summary>
        public DataSet GetAuthEmp(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct a.Role_id,a.Type,e.name");
            strSql.Append("  FROM Sys_authority as a inner join  hr_employee as e on a.factory_id=e.factory_id and a.role_id=e.id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

