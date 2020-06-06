using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;


namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_authority_dtcolumn
    /// </summary>
    public partial class scm_authority_dtcolumn
    {
        public scm_authority_dtcolumn()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string factory_Id, int suppliers_id, string Menu_ids, string column_ids, int Create_id, DateTime Create_date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_authority_dtcolumn");
            strSql.Append(" where factory_Id=@factory_Id and suppliers_id=@suppliers_id and Menu_ids=@Menu_ids and column_ids=@column_ids and Create_id=@Create_id and Create_date=@Create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@column_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = factory_Id;
            parameters[1].Value = suppliers_id;
            parameters[2].Value = Menu_ids;
            parameters[3].Value = column_ids;
            parameters[4].Value = Create_id;
            parameters[5].Value = Create_date;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_authority_dtcolumn model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_authority_dtcolumn(");
            strSql.Append("factory_Id,suppliers_id,Menu_ids,column_ids,Create_id,Create_date)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@suppliers_id,@Menu_ids,@column_ids,@Create_id,@Create_date)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@column_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.Menu_ids;
            parameters[3].Value = model.column_ids;
            parameters[4].Value = model.Create_id;
            parameters[5].Value = model.Create_date;

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
        /// 增加一条数据
        /// </summary>
        public bool Adds(XHD.Model.scm_authority_dtcolumn model)
        {
            List<string> strSqlList = new List<string>();

            string[] menu_ids = model.Menu_ids.Split(',');

            string[] column_ids;
            string strSql = string.Empty;

            string ids = model.column_ids.Replace(",", "");
            if (!string.IsNullOrEmpty(ids))
            {
                foreach (var item in menu_ids)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        //查询该页面下的列
                        DataSet ds = GetListColumn("Menu_id='" + item + "'");
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            string columnIds = model.column_ids.Substring(2, model.column_ids.Length - 3);
 
                            if (columnIds.Length > 2)
                            {
                                string s = string.Empty;
                                column_ids = columnIds.Split(',');
                                foreach (var items in column_ids)
                                {
                                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                    {
                                        int column_id = Convert.ToInt32(ds.Tables[0].Rows[i]["column_id"].ToString());
                                        if (column_id == Convert.ToInt32(items))
                                        {
                                            s += items + ",";
                                            break;
                                        }
                                    }
                                }
                                strSql = string.Format(@"insert into scm_authority_dtcolumn (factory_Id,suppliers_id,Menu_ids,column_ids,Create_id,Create_date)
                                            values('{0}','{1}','{2}','{3}','{4}','{5}')", model.factory_Id, model.suppliers_id, item, s, model.Create_id, model.Create_date);
                                strSqlList.Add(strSql);
                            }
                            else
                            {
                                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                {
                                    int column_id = Convert.ToInt32(ds.Tables[0].Rows[i]["column_id"].ToString());
                                    if (column_id == Convert.ToInt32(columnIds))
                                    {
                                        strSql = string.Format(@"insert into scm_authority_dtcolumn (factory_Id,suppliers_id,Menu_ids,column_ids,Create_id,Create_date)
                                            values('{0}','{1}','{2}','{3}','{4}','{5}')", model.factory_Id, model.suppliers_id, item, columnIds, model.Create_id, model.Create_date);
                                        strSqlList.Add(strSql);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
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
        public bool Update(XHD.Model.scm_authority_dtcolumn model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_authority_dtcolumn set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("suppliers_id=@suppliers_id,");
            strSql.Append("Menu_ids=@Menu_ids,");
            strSql.Append("column_ids=@column_ids,");
            strSql.Append("Create_id=@Create_id,");
            strSql.Append("Create_date=@Create_date");
            strSql.Append(" where factory_Id=@factory_Id and suppliers_id=@suppliers_id and Menu_ids=@Menu_ids and column_ids=@column_ids and Create_id=@Create_id and Create_date=@Create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@column_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.Menu_ids;
            parameters[3].Value = model.column_ids;
            parameters[4].Value = model.Create_id;
            parameters[5].Value = model.Create_date;

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
        public bool Delete(string factory_Id, int suppliers_id, string Menu_ids, string column_ids, int Create_id, DateTime Create_date)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_authority_dtcolumn ");
            strSql.Append(" where factory_Id=@factory_Id and suppliers_id=@suppliers_id and Menu_ids=@Menu_ids and column_ids=@column_ids and Create_id=@Create_id and Create_date=@Create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@column_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = factory_Id;
            parameters[1].Value = suppliers_id;
            parameters[2].Value = Menu_ids;
            parameters[3].Value = column_ids;
            parameters[4].Value = Create_id;
            parameters[5].Value = Create_date;

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
        public XHD.Model.scm_authority_dtcolumn GetModel(string factory_Id, int suppliers_id, string Menu_ids, string column_ids, int Create_id, DateTime Create_date)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select factory_Id,suppliers_id,Menu_ids,column_ids,Create_id,Create_date from scm_authority_dtcolumn ");
            strSql.Append(" where factory_Id=@factory_Id and suppliers_id=@suppliers_id and Menu_ids=@Menu_ids and column_ids=@column_ids and Create_id=@Create_id and Create_date=@Create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@Menu_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@column_ids", MySqlDbType.VarChar,1000),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = factory_Id;
            parameters[1].Value = suppliers_id;
            parameters[2].Value = Menu_ids;
            parameters[3].Value = column_ids;
            parameters[4].Value = Create_id;
            parameters[5].Value = Create_date;

            XHD.Model.scm_authority_dtcolumn model = new XHD.Model.scm_authority_dtcolumn();
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
        public XHD.Model.scm_authority_dtcolumn DataRowToModel(DataRow row)
        {
            XHD.Model.scm_authority_dtcolumn model = new XHD.Model.scm_authority_dtcolumn();
            if (row != null)
            {
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                if (row["Menu_ids"] != null)
                {
                    model.Menu_ids = row["Menu_ids"].ToString();
                }
                if (row["column_ids"] != null)
                {
                    model.column_ids = row["column_ids"].ToString();
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
            strSql.Append("select factory_Id,suppliers_id,Menu_ids,column_ids,Create_id,Create_date ");
            strSql.Append(" FROM scm_authority_dtcolumn ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListColumn(string supply_id, string factory_id, string app)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select d.* from scm_authority_dtcolumn d where  Menu_ids  in (select s.Menu_id  from sys_menu s  where  s. App_id='" + app + "')");
            strSql.Append("  and d.factory_Id='" + factory_id + "' and d.suppliers_id='" + supply_id + "'");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM scm_authority_dtcolumn ");
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
                strSql.Append("order by T.Create_date desc");
            }
            strSql.Append(")AS Row, T.*  from scm_authority_dtcolumn T ");
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
        public bool DeleteWhere(string suppliers_id, string menu_ids)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            string[] menuIds = menu_ids.Split(',');
            foreach (var item in menuIds)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    strSql = string.Format(@"delete from scm_authority_dtcolumn  where suppliers_id='{0}' and Menu_ids='{1}'", suppliers_id, item);
                    strSqlList.Add(strSql);
                }
            }

            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //StringBuilder strSql = new StringBuilder();
            //strSql.Append("delete from scm_authority_dtcolumn ");
            //strSql.Append(" where " + wherestr + "  ");
            //int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
            //if (rows > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListColumn(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select column_id,Menu_id,column_name");
            strSql.Append(" FROM scm_sys_dtcolumn ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

