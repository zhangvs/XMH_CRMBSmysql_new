using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_customer_grade
    /// </summary>
    public partial class crm_customer_grade
    {
        public crm_customer_grade()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("grade_id", "crm_customer_grade");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int grade_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_customer_grade");
            strSql.Append(" where grade_id=@grade_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@grade_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = grade_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_customer_grade model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_customer_grade(");
            strSql.Append("grade_id,factory_id,group_id,grade_code,grade_name,grade_order,create_id,create_name)");
            strSql.Append(" values (");
            strSql.Append("@grade_id,@factory_id,@group_id,@grade_code,@grade_name,@grade_order,@create_id,@create_name)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@grade_id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@group_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@grade_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@grade_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@grade_order", MySqlDbType.Int32,11),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.grade_id;
            parameters[1].Value = model.factory_id;
            parameters[2].Value = model.group_id;
            parameters[3].Value = model.grade_code;
            parameters[4].Value = model.grade_name;
            parameters[5].Value = model.grade_order;
            parameters[6].Value = model.create_id;
            parameters[7].Value = model.create_name;

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
        public bool Update(XHD.Model.crm_customer_grade model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_grade set ");
            strSql.Append("factory_id=@factory_id,");
            strSql.Append("group_id=@group_id,");
            strSql.Append("grade_code=@grade_code,");
            strSql.Append("grade_name=@grade_name,");
            strSql.Append("grade_order=@grade_order,");
            strSql.Append("create_id=@create_id,");
            strSql.Append("create_name=@create_name");
            strSql.Append(" where grade_id=@grade_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@group_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@grade_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@grade_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@grade_order", MySqlDbType.Int32,11),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@grade_id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.group_id;
            parameters[2].Value = model.grade_code;
            parameters[3].Value = model.grade_name;
            parameters[4].Value = model.grade_order;
            parameters[5].Value = model.create_id;
            parameters[6].Value = model.create_name;
            parameters[7].Value = model.grade_id;

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
        public bool Delete(int grade_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_grade ");
            strSql.Append(" where grade_id=@grade_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@grade_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = grade_id;

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
        public bool DeleteList(string grade_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_grade ");
            strSql.Append(" where grade_id in (" + grade_idlist + ")  ");
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
        public XHD.Model.crm_customer_grade GetModel(int grade_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select grade_id,factory_id,group_id,grade_code,grade_name,grade_order,create_id,create_name from crm_customer_grade ");
            strSql.Append(" where grade_id=@grade_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@grade_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = grade_id;

            XHD.Model.crm_customer_grade model = new XHD.Model.crm_customer_grade();
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
        public XHD.Model.crm_customer_grade DataRowToModel(DataRow row)
        {
            XHD.Model.crm_customer_grade model = new XHD.Model.crm_customer_grade();
            if (row != null)
            {
                if (row["grade_id"] != null && row["grade_id"].ToString() != "")
                {
                    model.grade_id = int.Parse(row["grade_id"].ToString());
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
                }
                if (row["group_id"] != null)
                {
                    model.group_id = row["group_id"].ToString();
                }
                if (row["grade_code"] != null)
                {
                    model.grade_code = row["grade_code"].ToString();
                }
                if (row["grade_name"] != null)
                {
                    model.grade_name = row["grade_name"].ToString();
                }
                if (row["grade_order"] != null && row["grade_order"].ToString() != "")
                {
                    model.grade_order = int.Parse(row["grade_order"].ToString());
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
            strSql.Append("select grade_id,factory_id,group_id,grade_code,grade_name,grade_order,create_id,create_name ");
            strSql.Append(" FROM crm_customer_grade ");
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
            strSql.Append("select grade_id,factory_id,group_id,grade_code,grade_name,grade_order,create_id,create_name ");
            strSql.Append(" FROM crm_customer_grade ");
            strSql1.Append(" select count(1) FROM crm_customer_grade ");
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
            strSql.Append("select count(1) FROM crm_customer_grade ");
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
                strSql.Append("order by T.grade_id desc");
            }
            strSql.Append(")AS Row, T.*  from crm_customer_grade T ");
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
            parameters[0].Value = "crm_customer_grade";
            parameters[1].Value = "grade_id";
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

