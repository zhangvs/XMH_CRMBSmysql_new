using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references


namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_supply_visit_emp
    /// </summary>
    public partial class scm_supply_visit_emp
    {
        public scm_supply_visit_emp()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int empID, string factory_Id, int create_id, string create_name, DateTime create_date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_supply_visit_emp");
            strSql.Append(" where empID=@empID and factory_Id=@factory_Id and create_id=@create_id and create_name=@create_name and create_date=@create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@empID", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = empID;
            parameters[1].Value = factory_Id;
            parameters[2].Value = create_id;
            parameters[3].Value = create_name;
            parameters[4].Value = create_date;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_supply_visit_emp model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_supply_visit_emp(");
            strSql.Append("empID,factory_Id,create_id,create_name,create_date)");
            strSql.Append(" values (");
            strSql.Append("@empID,@factory_Id,@create_id,@create_name,@create_date)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@empID", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.empID;
            parameters[1].Value = model.factory_Id;
            parameters[2].Value = model.create_id;
            parameters[3].Value = model.create_name;
            parameters[4].Value = model.create_date;

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
        public bool Update(XHD.Model.scm_supply_visit_emp model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_supply_visit_emp set ");
            strSql.Append("empID=@empID,");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("create_id=@create_id,");
            strSql.Append("create_name=@create_name,");
            strSql.Append("create_date=@create_date");
            strSql.Append(" where empID=@empID and factory_Id=@factory_Id and create_id=@create_id and create_name=@create_name and create_date=@create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@empID", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.empID;
            parameters[1].Value = model.factory_Id;
            parameters[2].Value = model.create_id;
            parameters[3].Value = model.create_name;
            parameters[4].Value = model.create_date;

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
        public bool Delete(int empID, string factory_Id, int create_id, string create_name, DateTime create_date)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_supply_visit_emp ");
            strSql.Append(" where empID=@empID and factory_Id=@factory_Id and create_id=@create_id and create_name=@create_name and create_date=@create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@empID", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = empID;
            parameters[1].Value = factory_Id;
            parameters[2].Value = create_id;
            parameters[3].Value = create_name;
            parameters[4].Value = create_date;

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
        public bool Delete(string strWhere)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_supply_visit_emp ");
            strSql.Append(" where " + strWhere);
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
        public XHD.Model.scm_supply_visit_emp GetModel(int empID, string factory_Id, int create_id, string create_name, DateTime create_date)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select empID,factory_Id,create_id,create_name,create_date from scm_supply_visit_emp ");
            strSql.Append(" where empID=@empID and factory_Id=@factory_Id and create_id=@create_id and create_name=@create_name and create_date=@create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@empID", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = empID;
            parameters[1].Value = factory_Id;
            parameters[2].Value = create_id;
            parameters[3].Value = create_name;
            parameters[4].Value = create_date;

            XHD.Model.scm_supply_visit_emp model = new XHD.Model.scm_supply_visit_emp();
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
        public XHD.Model.scm_supply_visit_emp DataRowToModel(DataRow row)
        {
            XHD.Model.scm_supply_visit_emp model = new XHD.Model.scm_supply_visit_emp();
            if (row != null)
            {
                if (row["empID"] != null && row["empID"].ToString() != "")
                {
                    model.empID = int.Parse(row["empID"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["create_id"] != null && row["create_id"].ToString() != "")
                {
                    model.create_id = int.Parse(row["create_id"].ToString());
                }
                if (row["create_name"] != null)
                {
                    model.create_name = row["create_name"].ToString();
                }
                if (row["create_date"] != null && row["create_date"].ToString() != "")
                {
                    model.create_date = DateTime.Parse(row["create_date"].ToString());
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
            strSql.Append("select empID,factory_Id,create_id,create_name,create_date ");
            strSql.Append(" FROM scm_supply_visit_emp ");
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
            strSql.Append("select count(1) FROM scm_supply_visit_emp ");
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
                strSql.Append("order by T.create_date desc");
            }
            strSql.Append(")AS Row, T.*  from scm_supply_visit_emp T ");
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

