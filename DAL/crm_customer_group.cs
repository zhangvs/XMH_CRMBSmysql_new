using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_customer_group
    /// </summary>
    public partial class crm_customer_group
    {
        public crm_customer_group()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("group_id", "crm_customer_group");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int group_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_customer_group");
            strSql.Append(" where group_id=@group_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@group_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = group_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_customer_group model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_customer_group(");
            strSql.Append("group_id,factory_id,group_code,group_name,group_order,create_id,create_name)");
            strSql.Append(" values (");
            strSql.Append("@group_id,@factory_id,@group_code,@group_name,@group_order,@create_id,@create_name)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@group_id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@group_code", MySqlDbType.VarChar,0),
					new MySqlParameter("@group_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@group_order", MySqlDbType.Int32,11),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.group_id;
            parameters[1].Value = model.factory_id;
            parameters[2].Value = model.group_code;
            parameters[3].Value = model.group_name;
            parameters[4].Value = model.group_order;
            parameters[5].Value = model.create_id;
            parameters[6].Value = model.create_name;

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
        public bool Update(XHD.Model.crm_customer_group model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_group set ");
            strSql.Append("factory_id=@factory_id,");
            strSql.Append("group_code=@group_code,");
            strSql.Append("group_name=@group_name,");
            strSql.Append("group_order=@group_order,");
            strSql.Append("create_id=@create_id,");
            strSql.Append("create_name=@create_name");
            strSql.Append(" where group_id=@group_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,50),
					new MySqlParameter("@group_code", MySqlDbType.VarChar,0),
					new MySqlParameter("@group_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@group_order", MySqlDbType.Int32,11),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@group_id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.group_code;
            parameters[2].Value = model.group_name;
            parameters[3].Value = model.group_order;
            parameters[4].Value = model.create_id;
            parameters[5].Value = model.create_name;
            parameters[6].Value = model.group_id;

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
        public bool Delete(int group_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_group ");
            strSql.Append(" where group_id=@group_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@group_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = group_id;

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
        public bool DeleteList(string group_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_group ");
            strSql.Append(" where group_id in (" + group_idlist + ")  ");
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
        public XHD.Model.crm_customer_group GetModel(int group_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select group_id,factory_id,group_code,group_name,group_order,create_id,create_name from crm_customer_group ");
            strSql.Append(" where group_id=@group_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@group_id", MySqlDbType.Int32,11)			};
            parameters[0].Value = group_id;

            XHD.Model.crm_customer_group model = new XHD.Model.crm_customer_group();
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
        public XHD.Model.crm_customer_group DataRowToModel(DataRow row)
        {
            XHD.Model.crm_customer_group model = new XHD.Model.crm_customer_group();
            if (row != null)
            {
                if (row["group_id"] != null && row["group_id"].ToString() != "")
                {
                    model.group_id = int.Parse(row["group_id"].ToString());
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
                }
                if (row["group_code"] != null)
                {
                    model.group_code = row["group_code"].ToString();
                }
                if (row["group_name"] != null)
                {
                    model.group_name = row["group_name"].ToString();
                }
                if (row["group_order"] != null && row["group_order"].ToString() != "")
                {
                    model.group_order = int.Parse(row["group_order"].ToString());
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
            strSql.Append("select group_id,factory_id,group_code,group_name,group_order,create_id,create_name ");
            strSql.Append(" FROM crm_customer_group ");
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
            strSql.Append("select group_id,factory_id,group_code,group_name,group_order,create_id,create_name ");
            strSql.Append(" FROM crm_customer_group ");
            strSql1.Append(" select count(1) FROM crm_customer_group ");
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
            strSql.Append("select count(1) FROM crm_customer_group ");
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
                strSql.Append("order by T.group_id desc");
            }
            strSql.Append(")AS Row, T.*  from crm_customer_group T ");
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
            parameters[0].Value = "crm_customer_group";
            parameters[1].Value = "group_id";
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

