using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:shop_reg_extend_info
    /// </summary>
    public partial class shop_reg_extend_info
    {
        public shop_reg_extend_info()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("Id", "shop_reg_extend_info");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_reg_extend_info");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,10)			};
            parameters[0].Value = Id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.shop_reg_extend_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_reg_extend_info(");
            strSql.Append("Id,user_id,reg_field_id,content,user_name)");
            strSql.Append(" values (");
            strSql.Append("@Id,@user_id,@reg_field_id,@content,@user_name)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,10),
					new MySqlParameter("@user_id", MySqlDbType.Int16,8),
					new MySqlParameter("@reg_field_id", MySqlDbType.Int32,10),
					new MySqlParameter("@content", MySqlDbType.Text),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,30)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.reg_field_id;
            parameters[3].Value = model.content;
            parameters[4].Value = model.user_name;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(FMS_Model.shop_reg_extend_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_reg_extend_info set ");
            strSql.Append("user_id=@user_id,");
            strSql.Append("reg_field_id=@reg_field_id,");
            strSql.Append("content=@content,");
            strSql.Append("user_name=@user_name");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int16,8),
					new MySqlParameter("@reg_field_id", MySqlDbType.Int32,10),
					new MySqlParameter("@content", MySqlDbType.Text),
					new MySqlParameter("@user_name", MySqlDbType.VarChar,30),
					new MySqlParameter("@Id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.reg_field_id;
            parameters[2].Value = model.content;
            parameters[3].Value = model.user_name;
            parameters[4].Value = model.Id;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
            strSql.Append("delete from shop_reg_extend_info ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,10)			};
            parameters[0].Value = Id;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
            strSql.Append("delete from shop_reg_extend_info ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public FMS_Model.shop_reg_extend_info GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,user_id,reg_field_id,content,user_name from shop_reg_extend_info ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,10)			};
            parameters[0].Value = Id;

            FMS_Model.shop_reg_extend_info model = new FMS_Model.shop_reg_extend_info();
            DataSet ds = Shop_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public FMS_Model.shop_reg_extend_info DataRowToModel(DataRow row)
        {
            FMS_Model.shop_reg_extend_info model = new FMS_Model.shop_reg_extend_info();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                //model.user_id=row["user_id"].ToString();
                if (row["reg_field_id"] != null && row["reg_field_id"].ToString() != "")
                {
                    model.reg_field_id = int.Parse(row["reg_field_id"].ToString());
                }
                if (row["content"] != null)
                {
                    model.content = row["content"].ToString();
                }
                if (row["user_name"] != null)
                {
                    model.user_name = row["user_name"].ToString();
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
            strSql.Append("select Id,user_id,reg_field_id,content,user_name,crm_userId ");
            strSql.Append(" FROM shop_reg_extend_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM shop_reg_extend_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}