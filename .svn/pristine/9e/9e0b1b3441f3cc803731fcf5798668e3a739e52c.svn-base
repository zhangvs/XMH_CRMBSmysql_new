using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:dms_brand_managerDAO
    /// </summary>
    public partial class dms_brand_managerDAO
    {
        public dms_brand_managerDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dms_brand_manager");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.dms_brand_manager model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dms_brand_manager(");
            strSql.Append("emp_code,name,brand_id,brand_name,brand_base,brand_plan,create_time,create_name,factory_id)");
            strSql.Append(" values (");
            strSql.Append("@emp_code,@name,@brand_id,@brand_name,@brand_base,@brand_plan,@create_time,@create_name,@factory_id)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@name", MySqlDbType.VarChar,50),
					new MySqlParameter("@brand_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@brand_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@brand_base", MySqlDbType.Decimal,18),
					new MySqlParameter("@brand_plan", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,20)};
            parameters[0].Value = model.emp_code;
            parameters[1].Value = model.name;
            parameters[2].Value = model.brand_id;
            parameters[3].Value = model.brand_name;
            parameters[4].Value = model.brand_base;
            parameters[5].Value = model.brand_plan;
            parameters[6].Value = model.create_time;
            parameters[7].Value = model.create_name;
            parameters[8].Value = model.factory_id;

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
        public bool Update(XHD.Model.dms_brand_manager model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_brand_manager set ");
            strSql.Append("emp_code=@emp_code,");
            strSql.Append("name=@name,");
            strSql.Append("brand_id=@brand_id,");
            strSql.Append("brand_name=@brand_name,");
            strSql.Append("brand_base=@brand_base,");
            strSql.Append("brand_plan=@brand_plan,");
            strSql.Append("create_time=@create_time,");
            strSql.Append("create_name=@create_name,");
            strSql.Append("factory_id=@factory_id");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@name", MySqlDbType.VarChar,50),
					new MySqlParameter("@brand_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@brand_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@brand_base", MySqlDbType.Decimal,18),
					new MySqlParameter("@brand_plan", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.emp_code;
            parameters[1].Value = model.name;
            parameters[2].Value = model.brand_id;
            parameters[3].Value = model.brand_name;
            parameters[4].Value = model.brand_base;
            parameters[5].Value = model.brand_plan;
            parameters[6].Value = model.create_time;
            parameters[7].Value = model.create_name;
            parameters[8].Value = model.factory_id;
            parameters[9].Value = model.id;

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
            strSql.Append("delete from dms_brand_manager ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
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
            strSql.Append("delete from dms_brand_manager ");
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
        public XHD.Model.dms_brand_manager GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,emp_code,name,brand_id,brand_name,brand_base,brand_plan,create_time,create_name,factory_id from dms_brand_manager ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.dms_brand_manager model = new XHD.Model.dms_brand_manager();
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
        public XHD.Model.dms_brand_manager DataRowToModel(DataRow row)
        {
            XHD.Model.dms_brand_manager model = new XHD.Model.dms_brand_manager();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["emp_code"] != null)
                {
                    model.emp_code = row["emp_code"].ToString();
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["brand_id"] != null)
                {
                    model.brand_id = row["brand_id"].ToString();
                }
                if (row["brand_name"] != null)
                {
                    model.brand_name = row["brand_name"].ToString();
                }
                if (row["brand_base"] != null && row["brand_base"].ToString() != "")
                {
                    model.brand_base = decimal.Parse(row["brand_base"].ToString());
                }
                if (row["brand_plan"] != null && row["brand_plan"].ToString() != "")
                {
                    model.brand_plan = decimal.Parse(row["brand_plan"].ToString());
                }
                if (row["create_time"] != null && row["create_time"].ToString() != "")
                {
                    model.create_time = DateTime.Parse(row["create_time"].ToString());
                }
                if (row["create_name"] != null)
                {
                    model.create_name = row["create_name"].ToString();
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
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
            strSql.Append("select id,emp_code,name,brand_id,brand_name,brand_base,brand_plan,create_time,create_name,factory_id ");
            strSql.Append(" FROM dms_brand_manager ");
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
            strSql.Append("select count(1) FROM dms_brand_manager ");
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
            strSql.Append(")AS Row, T.*  from dms_brand_manager T ");
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
            parameters[0].Value = "dms_brand_manager";
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

