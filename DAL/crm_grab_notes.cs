using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_grab_notes
    /// </summary>
    public partial class crm_grab_notes
    {
        public crm_grab_notes()
        { }
        #region  BasicMethod
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "crm_grab_notes");
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_grab_notes");
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
        public bool Add(XHD.Model.crm_grab_notes model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_grab_notes(");
            strSql.Append("factory_Id,customer_id,customer_name,emp_id,emp_uid,emp_name,start_time,end_time,cycle_feat,isdel)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@customer_id,@customer_name,@emp_id,@emp_uid,@emp_name,@start_time,@end_time,@cycle_feat,@isdel)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_name", MySqlDbType.VarChar,200),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_uid", MySqlDbType.VarChar,50),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@start_time", MySqlDbType.DateTime),
					new MySqlParameter("@end_time", MySqlDbType.DateTime),
					new MySqlParameter("@cycle_feat", MySqlDbType.Decimal,9),
					new MySqlParameter("@isdel", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.customer_id;
            parameters[2].Value = model.customer_name;
            parameters[3].Value = model.emp_id;
            parameters[4].Value = model.emp_uid;
            parameters[5].Value = model.emp_name;
            parameters[6].Value = model.start_time;
            parameters[7].Value = model.end_time;
            parameters[8].Value = model.cycle_feat;
            parameters[9].Value = model.isdel;

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
        public bool Update(XHD.Model.crm_grab_notes model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_grab_notes set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("customer_id=@customer_id,");
            strSql.Append("customer_name=@customer_name,");
            strSql.Append("emp_id=@emp_id,");
            strSql.Append("emp_uid=@emp_uid,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("start_time=@start_time,");
            strSql.Append("end_time=@end_time,");
            strSql.Append("cycle_feat=@cycle_feat,");
            strSql.Append("isdel=@isdel");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@customer_name", MySqlDbType.VarChar,200),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_uid", MySqlDbType.VarChar,50),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@start_time", MySqlDbType.DateTime),
					new MySqlParameter("@end_time", MySqlDbType.DateTime),
					new MySqlParameter("@cycle_feat", MySqlDbType.Decimal,9),
					new MySqlParameter("@isdel", MySqlDbType.Int32,11),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.customer_id;
            parameters[2].Value = model.customer_name;
            parameters[3].Value = model.emp_id;
            parameters[4].Value = model.emp_uid;
            parameters[5].Value = model.emp_name;
            parameters[6].Value = model.start_time;
            parameters[7].Value = model.end_time;
            parameters[8].Value = model.cycle_feat;
            parameters[9].Value = model.isdel;
            parameters[10].Value = model.id;

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
            strSql.Append("delete from crm_grab_notes ");
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
            strSql.Append("delete from crm_grab_notes ");
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
        public XHD.Model.crm_grab_notes GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,factory_Id,customer_id,customer_name,emp_id,emp_uid,emp_name,start_time,end_time,cycle_feat,isdel from crm_grab_notes ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.crm_grab_notes model = new XHD.Model.crm_grab_notes();
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
        public XHD.Model.crm_grab_notes DataRowToModel(DataRow row)
        {
            XHD.Model.crm_grab_notes model = new XHD.Model.crm_grab_notes();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["customer_id"] != null && row["customer_id"].ToString() != "")
                {
                    model.customer_id = int.Parse(row["customer_id"].ToString());
                }
                if (row["customer_name"] != null)
                {
                    model.customer_name = row["customer_name"].ToString();
                }
                if (row["emp_id"] != null && row["emp_id"].ToString() != "")
                {
                    model.emp_id = int.Parse(row["emp_id"].ToString());
                }
                if (row["emp_uid"] != null)
                {
                    model.emp_uid = row["emp_uid"].ToString();
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["start_time"] != null && row["start_time"].ToString() != "")
                {
                    model.start_time = DateTime.Parse(row["start_time"].ToString());
                }
                if (row["end_time"] != null && row["end_time"].ToString() != "")
                {
                    model.end_time = DateTime.Parse(row["end_time"].ToString());
                }
                if (row["cycle_feat"] != null && row["cycle_feat"].ToString() != "")
                {
                    model.cycle_feat = decimal.Parse(row["cycle_feat"].ToString());
                }
                if (row["isdel"] != null && row["isdel"].ToString() != "")
                {
                    model.isdel = int.Parse(row["isdel"].ToString());
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
            strSql.Append("select id,factory_Id,customer_id,customer_name,emp_id,emp_uid,emp_name,start_time,end_time,cycle_feat,isdel ");
            strSql.Append(" FROM crm_grab_notes ");
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
            strSql.Append("select count(1) FROM crm_grab_notes ");
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
            strSql.Append(")AS Row, T.*  from crm_grab_notes T ");
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
            parameters[0].Value = "crm_grab_notes";
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

