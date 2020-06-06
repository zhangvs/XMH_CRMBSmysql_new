using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using XHD.DBUtility;

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_sys_param
    /// </summary>
    public partial class crm_sys_param
    {
        public crm_sys_param()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_sys_param");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录,根据条件查询
        /// </summary>
        public bool Exists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_sys_param");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            return DbHelperMySQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_sys_param model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_sys_param(");
            strSql.Append("factory_Id,key_Code,key_Value,key_Des,key_Sort,key_Type,C_createId,C_createName,C_createDate)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@key_Code,@key_Value,@key_Des,@key_Sort,@key_Type,@C_createId,@C_createName,@C_createDate)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@key_Code", MySqlDbType.VarChar,60),
					new MySqlParameter("@key_Value", MySqlDbType.VarChar,200),
					new MySqlParameter("@key_Des", MySqlDbType.VarChar,100),
					new MySqlParameter("@key_Sort", MySqlDbType.Int32,11),
					new MySqlParameter("@key_Type", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.key_Code;
            parameters[2].Value = model.key_Value;
            parameters[3].Value = model.key_Des;
            parameters[4].Value = model.key_Sort;
            parameters[5].Value = model.key_Type;
            parameters[6].Value = model.C_createId;
            parameters[7].Value = model.C_createName;
            parameters[8].Value = model.C_createDate;

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
        public bool Update(XHD.Model.crm_sys_param model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_sys_param set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("key_Code=@key_Code,");
            strSql.Append("key_Value=@key_Value,");
            strSql.Append("key_Des=@key_Des,");
            strSql.Append("key_Sort=@key_Sort,");
            strSql.Append("key_Type=@key_Type");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@key_Code", MySqlDbType.VarChar,60),
					new MySqlParameter("@key_Value", MySqlDbType.VarChar,200),
					new MySqlParameter("@key_Des", MySqlDbType.VarChar,100),
					new MySqlParameter("@key_Sort", MySqlDbType.Int32,11),
					new MySqlParameter("@key_Type", MySqlDbType.VarChar,60),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.key_Code;
            parameters[2].Value = model.key_Value;
            parameters[3].Value = model.key_Des;
            parameters[4].Value = model.key_Sort;
            parameters[5].Value = model.key_Type;
            parameters[6].Value = model.Id;

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
            strSql.Append("delete from crm_sys_param ");
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
            strSql.Append("delete from crm_sys_param ");
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
        public XHD.Model.crm_sys_param GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,key_Code,key_Value,key_Des,key_Sort,key_Type,C_createId,C_createName,C_createDate from crm_sys_param ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.crm_sys_param model = new XHD.Model.crm_sys_param();
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
        public XHD.Model.crm_sys_param DataRowToModel(DataRow row)
        {
            XHD.Model.crm_sys_param model = new XHD.Model.crm_sys_param();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["key_Code"] != null)
                {
                    model.key_Code = row["key_Code"].ToString();
                }
                if (row["key_Value"] != null)
                {
                    model.key_Value = row["key_Value"].ToString();
                }
                if (row["key_Des"] != null)
                {
                    model.key_Des = row["key_Des"].ToString();
                }
                if (row["key_Sort"] != null && row["key_Sort"].ToString() != "")
                {
                    model.key_Sort = int.Parse(row["key_Sort"].ToString());
                }
                if (row["key_Type"] != null)
                {
                    model.key_Type = row["key_Type"].ToString();
                }
                if (row["C_createId"] != null && row["C_createId"].ToString() != "")
                {
                    model.C_createId = int.Parse(row["C_createId"].ToString());
                }
                if (row["C_createName"] != null)
                {
                    model.C_createName = row["C_createName"].ToString();
                }
                if (row["C_createDate"] != null && row["C_createDate"].ToString() != "")
                {
                    model.C_createDate = DateTime.Parse(row["C_createDate"].ToString());
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
            strSql.Append("select Id,factory_Id,key_Code,key_Value,key_Des,key_Sort,key_Type,C_createId,C_createName,C_createDate ");
            strSql.Append(" FROM crm_sys_param ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得分页数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("  select Id,factory_Id,key_Code,key_Value,key_Des,key_Sort,key_Type,C_createId,C_createName,C_createDate FROM crm_sys_param ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM Sys_FactoryInfo ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM crm_sys_param ");
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
            strSql.Append("select count(1) FROM crm_sys_param ");
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
            strSql.Append(")AS Row, T.*  from crm_sys_param T ");
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
            parameters[0].Value = "crm_sys_param";
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


