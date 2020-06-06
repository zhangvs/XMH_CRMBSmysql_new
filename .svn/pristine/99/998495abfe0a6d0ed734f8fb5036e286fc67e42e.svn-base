using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_supply_user
    /// </summary>
    public partial class scm_supply_user
    {
        public scm_supply_user()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_supply_user");
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
        public bool Add(XHD.Model.scm_supply_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_supply_user(");
            strSql.Append("factory_Id,supply_Id,supply_Name,user_uid,user_name,user_pwd,email,sex,tel,remarks,canlogin,Create_id,Create_date,Create_name,suppliers_erp_code)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@supply_Id,@supply_Name,@user_uid,@user_name,@user_pwd,@email,@sex,@tel,@remarks,@canlogin,@Create_id,@Create_date,@Create_name,@suppliers_erp_code)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@supply_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@supply_Name", MySqlDbType.VarChar,100),
					new MySqlParameter("@user_uid", MySqlDbType.VarChar,50),
                    new MySqlParameter("@user_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@user_pwd", MySqlDbType.VarChar,50),
					new MySqlParameter("@email", MySqlDbType.VarChar,50),
					new MySqlParameter("@sex", MySqlDbType.VarChar,50),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@remarks", MySqlDbType.VarChar,255),
					new MySqlParameter("@canlogin", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@Create_name", MySqlDbType.VarChar,60),
                    new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,30)                   };
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.supply_Id;
            parameters[2].Value = model.supply_Name;
            parameters[3].Value = model.user_uid;
            parameters[4].Value = model.user_name;
            parameters[5].Value = model.user_pwd;
            parameters[6].Value = model.email;
            parameters[7].Value = model.sex;
            parameters[8].Value = model.tel;
            parameters[9].Value = model.remarks;
            parameters[10].Value = model.canlogin;
            parameters[11].Value = model.Create_id;
            parameters[12].Value = model.Create_date;
            parameters[13].Value = model.Create_name;
            parameters[14].Value = model.suppliers_erp_code;

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
        public bool Update(XHD.Model.scm_supply_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_supply_user set ");
            strSql.Append("tel=@tel,");
            strSql.Append("user_uid=@user_uid");
            strSql.Append(" where supply_Id=@supply_Id");
            strSql.Append(" and factory_Id=@factory_Id");
            strSql.Append(" and canlogin=2");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@supply_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@user_uid", MySqlDbType.VarChar,50),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
		                                                            };
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.supply_Id;
            parameters[2].Value = model.user_uid;
            parameters[3].Value = model.tel;

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
            strSql.Append("delete from scm_supply_user ");
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
            strSql.Append("delete from scm_supply_user ");
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
        public XHD.Model.scm_supply_user GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,supply_Id,suppliers_erp_code,supply_Name,user_uid,user_pwd,email,sex,tel,remarks,canlogin,Create_id,Create_date,Create_name from scm_supply_user ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.scm_supply_user model = new XHD.Model.scm_supply_user();
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
        public XHD.Model.scm_supply_user DataRowToModel(DataRow row)
        {
            XHD.Model.scm_supply_user model = new XHD.Model.scm_supply_user();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factory_Id"] != null && row["factory_Id"].ToString() != "")
                {
                    model.factory_Id = int.Parse(row["factory_Id"].ToString());
                }
                if (row["supply_Id"] != null && row["supply_Id"].ToString() != "")
                {
                    model.supply_Id = int.Parse(row["supply_Id"].ToString());
                }
                if (row["supply_Name"] != null)
                {
                    model.supply_Name = row["supply_Name"].ToString();
                }
                if (row["user_uid"] != null)
                {
                    model.user_uid = row["user_uid"].ToString();
                }
                if (row["user_pwd"] != null)
                {
                    model.user_pwd = row["user_pwd"].ToString();
                }
                if (row["email"] != null)
                {
                    model.email = row["email"].ToString();
                }
                if (row["sex"] != null)
                {
                    model.sex = row["sex"].ToString();
                }
                if (row["tel"] != null)
                {
                    model.tel = row["tel"].ToString();
                }
                if (row["remarks"] != null)
                {
                    model.remarks = row["remarks"].ToString();
                }
                if (row["canlogin"] != null && row["canlogin"].ToString() != "")
                {
                    model.canlogin = int.Parse(row["canlogin"].ToString());
                }
                if (row["Create_id"] != null && row["Create_id"].ToString() != "")
                {
                    model.Create_id = int.Parse(row["Create_id"].ToString());
                }
                if (row["Create_date"] != null && row["Create_date"].ToString() != "")
                {
                    model.Create_date = DateTime.Parse(row["Create_date"].ToString());
                }
                if (row["Create_name"] != null)
                {
                    model.Create_name = row["Create_name"].ToString();
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
            strSql.Append("select Id,factory_Id,supply_Id,suppliers_erp_code,supply_Name,user_uid,user_pwd,email,sex,tel,remarks,canlogin,Create_id,Create_date,Create_name ");
            strSql.Append(" FROM scm_supply_user ");
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
            strSql.Append("select count(1) FROM scm_supply_user ");
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
            strSql.Append(")AS Row, T.*  from scm_supply_user T ");
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
            parameters[0].Value = "scm_supply_user";
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

