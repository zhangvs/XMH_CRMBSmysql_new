using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ssn_visit
    /// </summary>
    public partial class ssn_visit
    {
        public ssn_visit()
        { }

        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "ssn_visit");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ssn_visit");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ssn_visit model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ssn_visit(");
            strSql.Append("id,Factory_Id,Role_id,App_ids,Menu_ids,Art_id,Create_id,Create_date)");
            strSql.Append(" values (");
            strSql.Append("@id,@Factory_Id,@Role_id,@App_ids,@Menu_ids,@Art_id,@Create_id,@Create_date)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Role_id", MySqlDbType.Int32,11),
					new MySqlParameter("@App_ids", MySqlDbType.VarChar,250),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@Art_id", MySqlDbType.VarChar,3000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.Factory_Id;
            parameters[2].Value = model.Role_id;
            parameters[3].Value = model.App_ids;
            parameters[4].Value = model.Menu_ids;
            parameters[5].Value = model.Art_id;
            parameters[6].Value = model.Create_id;
            parameters[7].Value = model.Create_date;

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
        public bool Update(XHD.Model.ssn_visit model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_visit set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("Role_id=@Role_id,");
            strSql.Append("App_ids=@App_ids,");
            strSql.Append("Menu_ids=@Menu_ids,");
            strSql.Append("Art_id=@Art_id,");
            strSql.Append("Create_id=@Create_id,");
            strSql.Append("Create_date=@Create_date");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Role_id", MySqlDbType.Int32,11),
					new MySqlParameter("@App_ids", MySqlDbType.VarChar,250),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@Art_id", MySqlDbType.VarChar,3000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Role_id;
            parameters[2].Value = model.App_ids;
            parameters[3].Value = model.Menu_ids;
            parameters[4].Value = model.Art_id;
            parameters[5].Value = model.Create_id;
            parameters[6].Value = model.Create_date;
            parameters[7].Value = model.id;

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
        public bool Updates(int id, string artId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_visit set ");
            strSql.Append("Art_id=@Art_id");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Art_id", MySqlDbType.VarChar,3000),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};

            parameters[0].Value = artId;
            parameters[1].Value = id;

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
            strSql.Append("delete from ssn_visit ");
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
        /// 删除一条数据
        /// </summary>
        public bool DeleteByRole(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_visit ");
            strSql.Append(" where Role_id=" + id);

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_visit ");
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
        public XHD.Model.ssn_visit GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,Role_id,App_ids,Menu_ids,Art_id,Create_id,Create_date from ssn_visit ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.ssn_visit model = new XHD.Model.ssn_visit();
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
        public XHD.Model.ssn_visit DataRowToModel(DataRow row)
        {
            XHD.Model.ssn_visit model = new XHD.Model.ssn_visit();
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
                if (row["Role_id"] != null && row["Role_id"].ToString() != "")
                {
                    model.Role_id = int.Parse(row["Role_id"].ToString());
                }
                if (row["App_ids"] != null)
                {
                    model.App_ids = row["App_ids"].ToString();
                }
                if (row["Menu_ids"] != null)
                {
                    model.Menu_ids = row["Menu_ids"].ToString();
                }
                if (row["Art_id"] != null)
                {
                    model.Art_id = row["Art_id"].ToString();
                }
                if (row["Create_id"] != null && row["Create_id"].ToString() != "")
                {
                    model.Create_id = int.Parse(row["Create_id"].ToString());
                }
                if (row["Create_date"] != null && row["Create_date"].ToString() != "")
                {
                    model.Create_date = DateTime.Parse(row["Create_date"].ToString());
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
            strSql.Append("select id,Factory_Id,Role_id,App_ids,Menu_ids,Art_id,Create_id,Create_date ");
            strSql.Append(" FROM ssn_visit ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //查询该员工可以看到那些文章
        public DataSet GetListAtrId(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select  v.* from ssn_visit  v inner join   ssn_role_emp  r on v.Role_id=r.RoleID ");
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
            strSql.Append("select count(1) FROM ssn_visit ");
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
            strSql.Append(")AS Row, T.*  from ssn_visit T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteWhere(string wherestr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_visit ");
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

        //修改
        public bool UpdateN(string oldRoleId, string newRoleId, string art_id, string factory_Id, int menu_id, int emp_id)  //a7,
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;
            string strSql1 = string.Empty;
            //更新原来的文章与角色对应关系
            //先移除此文章对应的所有角色的权限
            strSql = string.Format(@"UPDATE ssn_visit  SET Art_id = (REPLACE(Art_id, '{0}', ''))  WHERE role_id in ({1}) and Factory_Id='{2}' and menu_ids ={3}", art_id, oldRoleId, factory_Id, menu_id);
            strSqlList.Add(strSql);

            //把前台保留的角色,以‘，’进行分组，循环进行操作
            if (!string.IsNullOrEmpty(newRoleId))
            {
                string[] arr = newRoleId.Split(',');

                foreach (string item in arr)
                {
                    //进行更新或新增，让角色获取此文章权限

                    if (DbHelperMySQL.Exists(" select count(1) from ssn_visit where Factory_Id='" + factory_Id + "' and role_id = " + int.Parse(item) + " and menu_ids = " + menu_id))
                    {
                        strSql1 = string.Format(@" update ssn_visit set Art_id=CONCAT(Art_id,'{0}') where role_id = {1} and Factory_Id='{2}' and menu_ids = {3}", art_id, int.Parse(item), factory_Id, menu_id);
                        strSqlList.Add(strSql1);
                    }
                    else
                    {
                        strSql1 = string.Format(@" insert into  ssn_visit (Factory_Id,Role_id,App_ids,Menu_ids,Art_id,Create_id,Create_date) 
                                                values ('{0}',{1},{2},{3},'{4}',{5},'{6}')", factory_Id, int.Parse(item), 1, menu_id, art_id, emp_id, DateTime.Now);
                        strSqlList.Add(strSql1);
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

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

