using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_set_grabrule
    /// </summary>
    public partial class crm_set_grabrule
    {
        public crm_set_grabrule()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_set_grabrule");
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
        public bool Add(XHD.Model.crm_set_grabrule model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_set_grabrule(");
            strSql.Append("factory_Id,cycle_day,cycle_feat,update_time,update_empid,update_empuid,update_empname)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@cycle_day,@cycle_feat,@update_time,@update_empid,@update_empuid,@update_empname)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@cycle_day", MySqlDbType.Int32,11),
					new MySqlParameter("@cycle_feat", MySqlDbType.Decimal,9),
					new MySqlParameter("@update_time", MySqlDbType.DateTime),
					new MySqlParameter("@update_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@update_empuid", MySqlDbType.VarChar,50),
					new MySqlParameter("@update_empname", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.cycle_day;
            parameters[2].Value = model.cycle_feat;
            parameters[3].Value = model.update_time;
            parameters[4].Value = model.update_empid;
            parameters[5].Value = model.update_empuid;
            parameters[6].Value = model.update_empname;

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
        public bool Update(XHD.Model.crm_set_grabrule model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_set_grabrule set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("cycle_day=@cycle_day,");
            strSql.Append("cycle_feat=@cycle_feat,");
            strSql.Append("update_time=@update_time,");
            strSql.Append("update_empid=@update_empid,");
            strSql.Append("update_empuid=@update_empuid,");
            strSql.Append("update_empname=@update_empname");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@cycle_day", MySqlDbType.Int32,11),
					new MySqlParameter("@cycle_feat", MySqlDbType.Decimal,9),
					new MySqlParameter("@update_time", MySqlDbType.DateTime),
					new MySqlParameter("@update_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@update_empuid", MySqlDbType.VarChar,50),
					new MySqlParameter("@update_empname", MySqlDbType.VarChar,50),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.cycle_day;
            parameters[2].Value = model.cycle_feat;
            parameters[3].Value = model.update_time;
            parameters[4].Value = model.update_empid;
            parameters[5].Value = model.update_empuid;
            parameters[6].Value = model.update_empname;
            parameters[7].Value = model.Id;

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
            strSql.Append("delete from crm_set_grabrule ");
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
            strSql.Append("delete from crm_set_grabrule ");
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
        public XHD.Model.crm_set_grabrule GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,cycle_day,cycle_feat,update_time,update_empid,update_empuid,update_empname from crm_set_grabrule ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.crm_set_grabrule model = new XHD.Model.crm_set_grabrule();
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
        public XHD.Model.crm_set_grabrule DataRowToModel(DataRow row)
        {
            XHD.Model.crm_set_grabrule model = new XHD.Model.crm_set_grabrule();
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
                if (row["cycle_day"] != null && row["cycle_day"].ToString() != "")
                {
                    model.cycle_day = int.Parse(row["cycle_day"].ToString());
                }
                if (row["cycle_feat"] != null && row["cycle_feat"].ToString() != "")
                {
                    model.cycle_feat = decimal.Parse(row["cycle_feat"].ToString());
                }
                if (row["update_time"] != null && row["update_time"].ToString() != "")
                {
                    model.update_time = DateTime.Parse(row["update_time"].ToString());
                }
                if (row["update_empid"] != null && row["update_empid"].ToString() != "")
                {
                    model.update_empid = int.Parse(row["update_empid"].ToString());
                }
                if (row["update_empuid"] != null)
                {
                    model.update_empuid = row["update_empuid"].ToString();
                }
                if (row["update_empname"] != null)
                {
                    model.update_empname = row["update_empname"].ToString();
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
            strSql.Append("select Id,factory_Id,cycle_day,cycle_feat,update_time,update_empid,update_empuid,update_empname ");
            strSql.Append(" FROM crm_set_grabrule ");
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
            strSql.Append("select count(1) FROM crm_set_grabrule ");
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
            strSql.Append(")AS Row, T.*  from crm_set_grabrule T ");
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
            parameters[0].Value = "crm_set_grabrule";
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

