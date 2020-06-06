using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_spe_supply_set
    /// </summary>
    public partial class scm_spe_supply_set
    {
        public scm_spe_supply_set()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "scm_spe_supply_set");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_spe_supply_set");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_spe_supply_set model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_spe_supply_set(");
            strSql.Append("id,suppliers_id,suppliers_name,limit_money,limit_date,operation_id,operation_name,factory_id)");
            strSql.Append(" values (");
            strSql.Append("@id,@suppliers_id,@suppliers_name,@limit_money,@limit_date,@operation_id,@operation_name,@factory_id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@limit_money", MySqlDbType.Decimal,18),
					new MySqlParameter("@limit_date", MySqlDbType.Int32,11),
					new MySqlParameter("@operation_id", MySqlDbType.Int32,11),
					new MySqlParameter("@operation_name", MySqlDbType.VarChar,50),
                    new MySqlParameter("@factory_id", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.suppliers_name;
            parameters[3].Value = model.limit_money;
            parameters[4].Value = model.limit_date;
            parameters[5].Value = model.operation_id;
            parameters[6].Value = model.operation_name;
            parameters[7].Value = model.factory_id;

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
        public bool Update(XHD.Model.scm_spe_supply_set model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_spe_supply_set set ");
            strSql.Append("suppliers_id=@suppliers_id,");
            strSql.Append("suppliers_name=@suppliers_name,");
            strSql.Append("limit_money=@limit_money,");
            strSql.Append("limit_date=@limit_date,");
            strSql.Append("operation_id=@operation_id,");
            strSql.Append("operation_name=@operation_name,");
            strSql.Append("factory_id=@factory_id");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@limit_money", MySqlDbType.Decimal,18),
					new MySqlParameter("@limit_date", MySqlDbType.Int32,11),
					new MySqlParameter("@operation_id", MySqlDbType.Int32,11),
					new MySqlParameter("@operation_name", MySqlDbType.VarChar,50),
                    new MySqlParameter("@factory_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.suppliers_id;
            parameters[1].Value = model.suppliers_name;
            parameters[2].Value = model.limit_money;
            parameters[3].Value = model.limit_date;
            parameters[4].Value = model.operation_id;
            parameters[5].Value = model.operation_name;
            parameters[6].Value = model.factory_id;
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_spe_supply_set ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_spe_supply_set ");
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
        public XHD.Model.scm_spe_supply_set GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,suppliers_id,suppliers_name,limit_money,limit_date,operation_id,operation_name,factory_id from scm_spe_supply_set ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.scm_spe_supply_set model = new XHD.Model.scm_spe_supply_set();
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
        public XHD.Model.scm_spe_supply_set DataRowToModel(DataRow row)
        {
            XHD.Model.scm_spe_supply_set model = new XHD.Model.scm_spe_supply_set();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                if (row["suppliers_name"] != null)
                {
                    model.suppliers_name = row["suppliers_name"].ToString();
                }
                if (row["limit_money"] != null && row["limit_money"].ToString() != "")
                {
                    model.limit_money = decimal.Parse(row["limit_money"].ToString());
                }
                if (row["limit_date"] != null && row["limit_date"].ToString() != "")
                {
                    model.limit_date = int.Parse(row["limit_date"].ToString());
                }
                if (row["operation_id"] != null && row["operation_id"].ToString() != "")
                {
                    model.operation_id = int.Parse(row["operation_id"].ToString());
                }
                if (row["operation_name"] != null)
                {
                    model.operation_name = row["operation_name"].ToString();
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
            strSql.Append("select id,suppliers_id,suppliers_name,limit_money,limit_date,operation_id,operation_name,factory_id ");
            strSql.Append(" FROM scm_spe_supply_set ");
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
            strSql.Append("select id,suppliers_id,suppliers_name,limit_money,limit_date,operation_id,operation_name,factory_id ");
            strSql.Append(" FROM scm_spe_supply_set ");
            strSql1.Append(" select count(1) FROM scm_spe_supply_set ");
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
            strSql.Append("select count(1) FROM scm_spe_supply_set ");
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
            strSql.Append(")AS Row, T.*  from scm_spe_supply_set T ");
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
            parameters[0].Value = "scm_spe_supply_set";
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

