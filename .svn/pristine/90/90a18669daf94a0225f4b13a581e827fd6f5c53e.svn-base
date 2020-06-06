using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_market
    /// </summary>
    public partial class ecs_market
    {
        public ecs_market()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int market_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_market");
            strSql.Append(" where market_id=@market_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@market_id", MySqlDbType.Int32)
			};
            parameters[0].Value = market_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_market model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_market(");
            strSql.Append("market_name,market_role_id,is_branch_company,default_phone,default_job_number,company_name,company_tel,company_address)");
            strSql.Append(" values (");
            strSql.Append("@market_name,@market_role_id,@is_branch_company,@default_phone,@default_job_number,@company_name,@company_tel,@company_address)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@market_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@market_role_id", MySqlDbType.Int32,5),
					new MySqlParameter("@is_branch_company", MySqlDbType.Int32,2),
					new MySqlParameter("@default_phone", MySqlDbType.VarChar,13),
					new MySqlParameter("@default_job_number", MySqlDbType.Int32,8),
					new MySqlParameter("@company_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@company_tel", MySqlDbType.VarChar,13),
					new MySqlParameter("@company_address", MySqlDbType.VarChar,60)};
            parameters[0].Value = model.market_name;
            parameters[1].Value = model.market_role_id;
            parameters[2].Value = model.is_branch_company;
            parameters[3].Value = model.default_phone;
            parameters[4].Value = model.default_job_number;
            parameters[5].Value = model.company_name;
            parameters[6].Value = model.company_tel;
            parameters[7].Value = model.company_address;

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
        public bool Update(XHD.Model.ecs_market model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_market set ");
            strSql.Append("market_name=@market_name,");
            strSql.Append("market_role_id=@market_role_id,");
            strSql.Append("is_branch_company=@is_branch_company,");
            strSql.Append("default_phone=@default_phone,");
            strSql.Append("default_job_number=@default_job_number,");
            strSql.Append("company_name=@company_name,");
            strSql.Append("company_tel=@company_tel,");
            strSql.Append("company_address=@company_address");
            strSql.Append(" where market_id=@market_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@market_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@market_role_id", MySqlDbType.Int32,5),
					new MySqlParameter("@is_branch_company", MySqlDbType.Int32,2),
					new MySqlParameter("@default_phone", MySqlDbType.VarChar,13),
					new MySqlParameter("@default_job_number", MySqlDbType.Int32,8),
					new MySqlParameter("@company_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@company_tel", MySqlDbType.VarChar,13),
					new MySqlParameter("@company_address", MySqlDbType.VarChar,60),
					new MySqlParameter("@market_id", MySqlDbType.Int32,5)};
            parameters[0].Value = model.market_name;
            parameters[1].Value = model.market_role_id;
            parameters[2].Value = model.is_branch_company;
            parameters[3].Value = model.default_phone;
            parameters[4].Value = model.default_job_number;
            parameters[5].Value = model.company_name;
            parameters[6].Value = model.company_tel;
            parameters[7].Value = model.company_address;
            parameters[8].Value = model.market_id;

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
        public bool Delete(int market_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_market ");
            strSql.Append(" where market_id=@market_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@market_id", MySqlDbType.Int32)
			};
            parameters[0].Value = market_id;

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
        public bool DeleteList(string market_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_market ");
            strSql.Append(" where market_id in (" + market_idlist + ")  ");
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
        public XHD.Model.ecs_market GetModel(int market_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select market_id,market_name,market_role_id,is_branch_company,default_phone,default_job_number,company_name,company_tel,company_address from ecs_market ");
            strSql.Append(" where market_id=@market_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@market_id", MySqlDbType.Int32)
			};
            parameters[0].Value = market_id;

            XHD.Model.ecs_market model = new XHD.Model.ecs_market();
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
        public XHD.Model.ecs_market DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_market model = new XHD.Model.ecs_market();
            if (row != null)
            {
                if (row["market_id"] != null && row["market_id"].ToString() != "")
                {
                    model.market_id = int.Parse(row["market_id"].ToString());
                }
                if (row["market_name"] != null)
                {
                    model.market_name = row["market_name"].ToString();
                }
                if (row["market_role_id"] != null && row["market_role_id"].ToString() != "")
                {
                    model.market_role_id = int.Parse(row["market_role_id"].ToString());
                }
                if (row["is_branch_company"] != null && row["is_branch_company"].ToString() != "")
                {
                    model.is_branch_company = int.Parse(row["is_branch_company"].ToString());
                }
                if (row["default_phone"] != null)
                {
                    model.default_phone = row["default_phone"].ToString();
                }
                if (row["default_job_number"] != null && row["default_job_number"].ToString() != "")
                {
                    model.default_job_number = int.Parse(row["default_job_number"].ToString());
                }
                if (row["company_name"] != null)
                {
                    model.company_name = row["company_name"].ToString();
                }
                if (row["company_tel"] != null)
                {
                    model.company_tel = row["company_tel"].ToString();
                }
                if (row["company_address"] != null)
                {
                    model.company_address = row["company_address"].ToString();
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
            strSql.Append("select market_id,market_name,market_role_id,is_branch_company,default_phone,default_job_number,company_name,company_tel,company_address ");
            strSql.Append(" FROM ecs_market ");
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
            strSql.Append("select count(1) FROM ecs_market ");
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
                strSql.Append("order by T.market_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_market T ");
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
            parameters[0].Value = "ecs_market";
            parameters[1].Value = "market_id";
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

