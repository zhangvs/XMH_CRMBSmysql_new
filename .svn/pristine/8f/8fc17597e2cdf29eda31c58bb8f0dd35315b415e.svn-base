using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;
using System.Collections.Generic;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_emp_brand_relate
    /// </summary>
    public partial class scm_emp_brand_relate
    {
        public scm_emp_brand_relate()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string factory_Id, int empId, string brandId, int create_id, string create_name, DateTime create_date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_emp_brand_relate");
            strSql.Append(" where factory_Id=@factory_Id and empId=@empId and brandId=@brandId and create_id=@create_id and create_name=@create_name and create_date=@create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@empId", MySqlDbType.Int32,11),
					new MySqlParameter("@brandId", MySqlDbType.VarChar,1000),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = factory_Id;
            parameters[1].Value = empId;
            parameters[2].Value = brandId;
            parameters[3].Value = create_id;
            parameters[4].Value = create_name;
            parameters[5].Value = create_date;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_emp_brand_relate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_emp_brand_relate(");
            strSql.Append("factory_Id,empId,brandId,create_id,create_name,create_date)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@empId,@brandId,@create_id,@create_name,@create_date)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@empId", MySqlDbType.Int32,11),
					new MySqlParameter("@brandId", MySqlDbType.VarChar,1000),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.empId;
            parameters[2].Value = model.brandId;
            parameters[3].Value = model.create_id;
            parameters[4].Value = model.create_name;
            parameters[5].Value = model.create_date;

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
        public bool Update(XHD.Model.scm_emp_brand_relate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_emp_brand_relate set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("empId=@empId,");
            strSql.Append("brandId=@brandId,");
            strSql.Append("create_id=@create_id,");
            strSql.Append("create_name=@create_name,");
            strSql.Append("create_date=@create_date");
            strSql.Append(" where factory_Id=@factory_Id and empId=@empId and brandId=@brandId and create_id=@create_id and create_name=@create_name and create_date=@create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@empId", MySqlDbType.Int32,11),
					new MySqlParameter("@brandId", MySqlDbType.VarChar,1000),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.empId;
            parameters[2].Value = model.brandId;
            parameters[3].Value = model.create_id;
            parameters[4].Value = model.create_name;
            parameters[5].Value = model.create_date;

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
        public bool Updates(XHD.Model.scm_emp_brand_relate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_emp_brand_relate set ");
            strSql.Append("brandId=@brandId");
            strSql.Append(" where factory_Id=@factory_Id  and empId=@empId");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@brandId", MySqlDbType.VarChar,1000),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@empId", MySqlDbType.Int32,11)
					};
            parameters[0].Value = model.brandId;
            parameters[1].Value = model.factory_Id;
            parameters[2].Value = model.empId;

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
        public bool Delete(string factory_Id, int empId, string brandId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_emp_brand_relate ");
            strSql.Append(" where factory_Id=@factory_Id and empId=@empId and brandId=@brandId ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@empId", MySqlDbType.Int32,11),
					new MySqlParameter("@brandId", MySqlDbType.VarChar,1000)		};

            parameters[0].Value = factory_Id;
            parameters[1].Value = empId;
            parameters[2].Value = brandId;

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
        public XHD.Model.scm_emp_brand_relate GetModel(string factory_Id, int empId, string brandId, int create_id, string create_name, DateTime create_date)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select factory_Id,empId,brandId,create_id,create_name,create_date from scm_emp_brand_relate ");
            strSql.Append(" where factory_Id=@factory_Id and empId=@empId and brandId=@brandId and create_id=@create_id and create_name=@create_name and create_date=@create_date ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@empId", MySqlDbType.Int32,11),
					new MySqlParameter("@brandId", MySqlDbType.VarChar,1000),
					new MySqlParameter("@create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@create_date", MySqlDbType.DateTime)			};
            parameters[0].Value = factory_Id;
            parameters[1].Value = empId;
            parameters[2].Value = brandId;
            parameters[3].Value = create_id;
            parameters[4].Value = create_name;
            parameters[5].Value = create_date;

            XHD.Model.scm_emp_brand_relate model = new XHD.Model.scm_emp_brand_relate();
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
        public XHD.Model.scm_emp_brand_relate DataRowToModel(DataRow row)
        {
            XHD.Model.scm_emp_brand_relate model = new XHD.Model.scm_emp_brand_relate();
            if (row != null)
            {
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["empId"] != null && row["empId"].ToString() != "")
                {
                    model.empId = int.Parse(row["empId"].ToString());
                }
                if (row["brandId"] != null)
                {
                    model.brandId = row["brandId"].ToString();
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
            strSql.Append("select factory_Id,empId,brandId,create_id,create_name,create_date ");
            strSql.Append(" FROM scm_emp_brand_relate ");
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
            strSql.Append("select factory_Id,empId,brandId,create_id,create_name,create_date  FROM scm_emp_brand_relate");
            strSql1.Append(" select count(1) FROM scm_emp_brand_relate ");
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
            strSql.Append("select count(1) FROM scm_emp_brand_relate ");
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
            strSql.Append(")AS Row, T.*  from scm_emp_brand_relate T ");
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
            parameters[0].Value = "scm_emp_brand_relate";
            parameters[1].Value = "create_date";
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

