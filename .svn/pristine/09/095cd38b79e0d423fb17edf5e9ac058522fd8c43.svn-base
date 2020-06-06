using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_msmsend
    /// </summary>
    public partial class scm_msmsend
    {
        public scm_msmsend()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_msmsend");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_msmsend model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_msmsend(");
            strSql.Append("factory_id,suppliers_id,bustype,tels,sendMSM,sendDate,sendPersonid,sendPerson,msgresults)");
            strSql.Append(" values (");
            strSql.Append("@factory_id,@suppliers_id,@bustype,@tels,@sendMSM,@sendDate,@sendPersonid,@sendPerson,@msgresults)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@bustype", MySqlDbType.VarChar,20),
					new MySqlParameter("@tels", MySqlDbType.VarChar,200),
					new MySqlParameter("@sendMSM", MySqlDbType.VarChar,200),
					new MySqlParameter("@sendDate", MySqlDbType.VarChar,30),
					new MySqlParameter("@sendPersonid", MySqlDbType.Int32,11),
					new MySqlParameter("@sendPerson", MySqlDbType.VarChar,60),
					new MySqlParameter("@msgresults", MySqlDbType.VarChar,300)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.bustype;
            parameters[3].Value = model.tels;
            parameters[4].Value = model.sendMSM;
            parameters[5].Value = model.sendDate;
            parameters[6].Value = model.sendPersonid;
            parameters[7].Value = model.sendPerson;
            parameters[8].Value = model.msgresults;

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
        public bool Update(XHD.Model.scm_msmsend model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_msmsend set ");
            strSql.Append("factory_id=@factory_id,");
            strSql.Append("suppliers_id=@suppliers_id,");
            strSql.Append("bustype=@bustype,");
            strSql.Append("tels=@tels,");
            strSql.Append("sendMSM=@sendMSM,");
            strSql.Append("sendDate=@sendDate,");
            strSql.Append("sendPersonid=@sendPersonid,");
            strSql.Append("sendPerson=@sendPerson,");
            strSql.Append("msgresults=@msgresults");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@bustype", MySqlDbType.VarChar,20),
					new MySqlParameter("@tels", MySqlDbType.VarChar,200),
					new MySqlParameter("@sendMSM", MySqlDbType.VarChar,200),
					new MySqlParameter("@sendDate", MySqlDbType.VarChar,30),
					new MySqlParameter("@sendPersonid", MySqlDbType.Int32,11),
					new MySqlParameter("@sendPerson", MySqlDbType.VarChar,60),
					new MySqlParameter("@msgresults", MySqlDbType.VarChar,300),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.bustype;
            parameters[3].Value = model.tels;
            parameters[4].Value = model.sendMSM;
            parameters[5].Value = model.sendDate;
            parameters[6].Value = model.sendPersonid;
            parameters[7].Value = model.sendPerson;
            parameters[8].Value = model.msgresults;
            parameters[9].Value = model.Id;

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
            strSql.Append("delete from scm_msmsend ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
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
            strSql.Append("delete from scm_msmsend ");
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
        public XHD.Model.scm_msmsend GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_id,suppliers_id,bustype,tels,sendMSM,sendDate,sendPersonid,sendPerson,msgresults from scm_msmsend ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.scm_msmsend model = new XHD.Model.scm_msmsend();
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
        public XHD.Model.scm_msmsend DataRowToModel(DataRow row)
        {
            XHD.Model.scm_msmsend model = new XHD.Model.scm_msmsend();
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
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                if (row["bustype"] != null)
                {
                    model.bustype = row["bustype"].ToString();
                }
                if (row["tels"] != null)
                {
                    model.tels = row["tels"].ToString();
                }
                if (row["sendMSM"] != null)
                {
                    model.sendMSM = row["sendMSM"].ToString();
                }
                if (row["sendDate"] != null)
                {
                    model.sendDate = row["sendDate"].ToString();
                }
                if (row["sendPersonid"] != null && row["sendPersonid"].ToString() != "")
                {
                    model.sendPersonid = int.Parse(row["sendPersonid"].ToString());
                }
                if (row["sendPerson"] != null)
                {
                    model.sendPerson = row["sendPerson"].ToString();
                }
                if (row["msgresults"] != null)
                {
                    model.msgresults = row["msgresults"].ToString();
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
            strSql.Append("select Id,factory_id,suppliers_id,bustype,tels,sendMSM,sendDate,sendPersonid,sendPerson,msgresults ");
            strSql.Append(" FROM scm_msmsend ");
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
            strSql.Append(" select m.Id,m.factory_id,m.suppliers_id,s.suppliers_name,m.bustype,m.tels,m.sendMSM,m.sendDate,m.sendPersonid,m.sendPerson,m.msgresults FROM scm_msmsend as m ");
            strSql.Append(" left join ecs_suppliers s on m.factory_id=s.scm_factoryId and m.suppliers_id=s.suppliers_id");
            strSql1.Append(" select count(m.Id) FROM scm_msmsend as m left join ecs_suppliers s on m.factory_id=s.scm_factoryId and m.suppliers_id=s.suppliers_id");
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
            strSql.Append("select count(1) FROM scm_msmsend ");
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
            strSql.Append(")AS Row, T.*  from scm_msmsend T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }
        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
