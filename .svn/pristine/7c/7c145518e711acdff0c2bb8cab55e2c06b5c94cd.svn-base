using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_dear_relate
    /// </summary>
    public partial class scm_dear_relate
    {
        public scm_dear_relate()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "scm_dear_relate");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_dear_relate");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_dear_relate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_dear_relate(");
            strSql.Append("Id,factory_id,suppliers_name,suppliers_id,dear_id,dear_name,children_id,children_name,cerate_time,create_id,create_name)");
            strSql.Append(" values (");
            strSql.Append("@Id,@factory_id,@suppliers_name,@suppliers_id,@dear_id,@dear_name,@children_id,@children_name,@cerate_time,@create_id,@create_name)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@dear_id", MySqlDbType.Int32,11),
					new MySqlParameter("@dear_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@children_id", MySqlDbType.Int32,11),
					new MySqlParameter("@children_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@cerate_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,60)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.factory_id;
            parameters[2].Value = model.suppliers_name;
            parameters[3].Value = model.suppliers_id;
            parameters[4].Value = model.dear_id;
            parameters[5].Value = model.dear_name;
            parameters[6].Value = model.children_id;
            parameters[7].Value = model.children_name;
            parameters[8].Value = model.cerate_time;
            parameters[9].Value = model.create_id;
            parameters[10].Value = model.create_name;

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
        public bool Update(XHD.Model.scm_dear_relate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_dear_relate set ");
            strSql.Append("factory_id=@factory_id,");
            strSql.Append("suppliers_name=@suppliers_name,");
            strSql.Append("suppliers_id=@suppliers_id,");
            strSql.Append("dear_id=@dear_id,");
            strSql.Append("dear_name=@dear_name,");
            strSql.Append("children_id=@children_id,");
            strSql.Append("children_name=@children_name,");
            strSql.Append("cerate_time=@cerate_time,");
            strSql.Append("create_id=@create_id,");
            strSql.Append("create_name=@create_name");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@dear_id", MySqlDbType.Int32,11),
					new MySqlParameter("@dear_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@children_id", MySqlDbType.Int32,11),
					new MySqlParameter("@children_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@cerate_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.suppliers_name;
            parameters[2].Value = model.suppliers_id;
            parameters[3].Value = model.dear_id;
            parameters[4].Value = model.dear_name;
            parameters[5].Value = model.children_id;
            parameters[6].Value = model.children_name;
            parameters[7].Value = model.cerate_time;
            parameters[8].Value = model.create_id;
            parameters[9].Value = model.create_name;
            parameters[10].Value = model.Id;

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
            strSql.Append("delete from scm_dear_relate ");
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

        public bool DeleteByDear(string dear_id, string suppliers_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_dear_relate ");
            strSql.Append(" where dear_id=" + dear_id);
            strSql.Append(" and suppliers_id=" + suppliers_id);
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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_dear_relate ");
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
        public XHD.Model.scm_dear_relate GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_id,suppliers_name,suppliers_id,dear_id,dear_name,children_id,children_name,cerate_time,create_id,create_name from scm_dear_relate ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            XHD.Model.scm_dear_relate model = new XHD.Model.scm_dear_relate();
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
        public XHD.Model.scm_dear_relate DataRowToModel(DataRow row)
        {
            XHD.Model.scm_dear_relate model = new XHD.Model.scm_dear_relate();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
                }
                if (row["suppliers_name"] != null)
                {
                    model.suppliers_name = row["suppliers_name"].ToString();
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                if (row["dear_id"] != null && row["dear_id"].ToString() != "")
                {
                    model.dear_id = int.Parse(row["dear_id"].ToString());
                }
                if (row["dear_name"] != null)
                {
                    model.dear_name = row["dear_name"].ToString();
                }
                if (row["children_id"] != null && row["children_id"].ToString() != "")
                {
                    model.children_id = int.Parse(row["children_id"].ToString());
                }
                if (row["children_name"] != null)
                {
                    model.children_name = row["children_name"].ToString();
                }
                if (row["cerate_time"] != null && row["cerate_time"].ToString() != "")
                {
                    model.cerate_time = DateTime.Parse(row["cerate_time"].ToString());
                }
                if (row["create_id"] != null && row["create_id"].ToString() != "")
                {
                    model.create_id = int.Parse(row["create_id"].ToString());
                }
                if (row["create_name"] != null)
                {
                    model.create_name = row["create_name"].ToString();
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
            strSql.Append("select Id,factory_id,suppliers_name,suppliers_id,dear_id,dear_name,children_id,children_name,cerate_time,create_id,create_name ");
            strSql.Append(" FROM scm_dear_relate ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select Id,factory_id,suppliers_name,suppliers_id,dear_id,dear_name,children_id,children_name,cerate_time,create_id,create_name ");
            strSql.Append(" FROM scm_dear_relate ");
            strSql1.Append(" select count(1) from scm_dear_relate ");
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
            strSql.Append("select count(1) FROM scm_dear_relate ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from scm_dear_relate T ");
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
            parameters[0].Value = "scm_dear_relate";
            parameters[1].Value = "Id";
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

