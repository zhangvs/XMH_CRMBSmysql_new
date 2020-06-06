using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_customer_protect
    /// </summary>
    public partial class crm_customer_protect
    {
        public crm_customer_protect()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_customer_protect");
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
        public bool Add(XHD.Model.crm_customer_protect model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_customer_protect(");
            strSql.Append("Factory_Id,Customer_id,Customer_name,apply_empid,apply_did,apply_dname,apply_empname,apply_stime,apply_etime,apply_content,reply_empid,reply_empname,reply_did,reply_dname,reply_time,reply_content,isInvalid,isSucceed,feat_protect)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@Customer_id,@Customer_name,@apply_empid,@apply_did,@apply_dname,@apply_empname,@apply_stime,@apply_etime,@apply_content,@reply_empid,@reply_empname,@reply_did,@reply_dname,@reply_time,@reply_content,@isInvalid,@isSucceed,@feat_protect)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Customer_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@apply_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_did", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_dname", MySqlDbType.VarChar,30),
					new MySqlParameter("@apply_empname", MySqlDbType.VarChar,30),
					new MySqlParameter("@apply_stime", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_etime", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_content", MySqlDbType.Text),
					new MySqlParameter("@reply_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@reply_empname", MySqlDbType.VarChar,30),
					new MySqlParameter("@reply_did", MySqlDbType.Int32,11),
					new MySqlParameter("@reply_dname", MySqlDbType.VarChar,30),
					new MySqlParameter("@reply_time", MySqlDbType.Int32,11),
					new MySqlParameter("@reply_content", MySqlDbType.Text),
					new MySqlParameter("@isInvalid", MySqlDbType.Int32,11),
					new MySqlParameter("@isSucceed", MySqlDbType.Int32,11),
					new MySqlParameter("@feat_protect", MySqlDbType.Float,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Customer_id;
            parameters[2].Value = model.Customer_name;
            parameters[3].Value = model.apply_empid;
            parameters[4].Value = model.apply_did;
            parameters[5].Value = model.apply_dname;
            parameters[6].Value = model.apply_empname;
            parameters[7].Value = model.apply_stime;
            parameters[8].Value = model.apply_etime;
            parameters[9].Value = model.apply_content;
            parameters[10].Value = model.reply_empid;
            parameters[11].Value = model.reply_empname;
            parameters[12].Value = model.reply_did;
            parameters[13].Value = model.reply_dname;
            parameters[14].Value = model.reply_time;
            parameters[15].Value = model.reply_content;
            parameters[16].Value = model.isInvalid;
            parameters[17].Value = model.isSucceed;
            parameters[18].Value = model.feat_protect;

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
        public bool Update(XHD.Model.crm_customer_protect model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_protect set ");
            strSql.Append("reply_empid=@reply_empid,");
            strSql.Append("reply_empname=@reply_empname,");
            strSql.Append("reply_did=@reply_did,");
            strSql.Append("reply_dname=@reply_dname,");
            strSql.Append("reply_time=@reply_time,");
            strSql.Append("reply_content=@reply_content,");
            strSql.Append("isSucceed=@isSucceed,");
            strSql.Append("feat_protect=@feat_protect");
            strSql.Append(" where id=@id");
            strSql.Append(" and factory_id=@factory_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@reply_empid", MySqlDbType.Int32,11),
					new MySqlParameter("@reply_empname", MySqlDbType.VarChar,30),
					new MySqlParameter("@reply_did", MySqlDbType.Int32,11),
					new MySqlParameter("@reply_dname", MySqlDbType.VarChar,30),
					new MySqlParameter("@reply_time", MySqlDbType.Int32,11),
					new MySqlParameter("@reply_content", MySqlDbType.Text),
					new MySqlParameter("@isInvalid", MySqlDbType.Int32,11),
					new MySqlParameter("@isSucceed", MySqlDbType.Int32,11),
                    new MySqlParameter("@feat_protect", MySqlDbType.Float,11),
					new MySqlParameter("@id", MySqlDbType.Int32,11),
                    new MySqlParameter("@factory_id", MySqlDbType.VarChar,60)};
            parameters[0].Value = model.reply_empid;
            parameters[1].Value = model.reply_empname;
            parameters[2].Value = model.reply_did;
            parameters[3].Value = model.reply_dname;
            parameters[4].Value = model.reply_time;
            parameters[5].Value = model.reply_content;
            parameters[6].Value = model.isInvalid;
            parameters[7].Value = model.isSucceed;
            parameters[8].Value = model.feat_protect;
            parameters[9].Value = model.id;
            parameters[10].Value = model.Factory_Id;

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
        //批量通过
        public bool UpdateisSucceedTrue(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_protect set ");
            strSql.Append("isSucceed=1");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

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
        //批量拒绝
        public bool UpdateisSucceedFalse(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_protect set ");
            strSql.Append("isSucceed=2");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

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
        /// 更新一条数据
        /// </summary>
        public bool UpdateInvalid(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_protect set ");
            strSql.Append("isInvalid=1");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_protect ");
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
            strSql.Append("delete from crm_customer_protect ");
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
        public XHD.Model.crm_customer_protect GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,Customer_id,Customer_name,apply_empid,apply_did,apply_dname,apply_empname,apply_stime,apply_etime,apply_content,reply_empid,reply_empname,reply_did,reply_dname,reply_time,reply_content,isInvalid,isSucceed,feat_protect from crm_customer_protect ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.crm_customer_protect model = new XHD.Model.crm_customer_protect();
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
        public XHD.Model.crm_customer_protect DataRowToModel(DataRow row)
        {
            XHD.Model.crm_customer_protect model = new XHD.Model.crm_customer_protect();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["Customer_id"] != null && row["Customer_id"].ToString() != "")
                {
                    model.Customer_id = int.Parse(row["Customer_id"].ToString());
                }
                if (row["Customer_name"] != null)
                {
                    model.Customer_name = row["Customer_name"].ToString();
                }
                if (row["apply_empid"] != null && row["apply_empid"].ToString() != "")
                {
                    model.apply_empid = int.Parse(row["apply_empid"].ToString());
                }
                if (row["apply_did"] != null && row["apply_did"].ToString() != "")
                {
                    model.apply_did = int.Parse(row["apply_did"].ToString());
                }
                if (row["apply_dname"] != null)
                {
                    model.apply_dname = row["apply_dname"].ToString();
                }
                if (row["apply_empname"] != null)
                {
                    model.apply_empname = row["apply_empname"].ToString();
                }
                if (row["apply_stime"] != null && row["apply_stime"].ToString() != "")
                {
                    model.apply_stime = int.Parse(row["apply_stime"].ToString());
                }
                if (row["apply_etime"] != null && row["apply_etime"].ToString() != "")
                {
                    model.apply_etime = int.Parse(row["apply_etime"].ToString());
                }
                if (row["apply_content"] != null)
                {
                    model.apply_content = row["apply_content"].ToString();
                }
                if (row["reply_empid"] != null && row["reply_empid"].ToString() != "")
                {
                    model.reply_empid = int.Parse(row["reply_empid"].ToString());
                }
                if (row["reply_empname"] != null)
                {
                    model.reply_empname = row["reply_empname"].ToString();
                }
                if (row["reply_did"] != null && row["reply_did"].ToString() != "")
                {
                    model.reply_did = int.Parse(row["reply_did"].ToString());
                }
                if (row["reply_dname"] != null)
                {
                    model.reply_dname = row["reply_dname"].ToString();
                }
                if (row["reply_time"] != null && row["reply_time"].ToString() != "")
                {
                    model.reply_time = int.Parse(row["reply_time"].ToString());
                }
                if (row["reply_content"] != null)
                {
                    model.reply_content = row["reply_content"].ToString();
                }
                if (row["isInvalid"] != null && row["isInvalid"].ToString() != "")
                {
                    model.isInvalid = int.Parse(row["isInvalid"].ToString());
                }
                if (row["isSucceed"] != null && row["isSucceed"].ToString() != "")
                {
                    model.isSucceed = int.Parse(row["isSucceed"].ToString());
                }
                if (row["feat_protect"] != null && row["feat_protect"].ToString() != "")
                {
                    model.feat_protect = decimal.Parse(row["feat_protect"].ToString());
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
            strSql.Append("select id,Factory_Id,Customer_id,Customer_name,apply_empid,apply_did,apply_dname,apply_empname,apply_stime,apply_etime,apply_content,reply_empid,reply_empname,reply_did,reply_dname,reply_time,reply_content,isInvalid,isSucceed,feat_protect ");
            strSql.Append(" FROM crm_customer_protect ");
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
            strSql.Append("select id,Factory_Id,Customer_id,Customer_name,apply_empid,apply_did,apply_dname,apply_empname,apply_stime,apply_etime,apply_content,reply_empid,reply_empname,reply_did,reply_dname,reply_time,reply_content,isInvalid,isSucceed,feat_protect FROM crm_customer_protect ");
            strSql1.Append(" select count(Id) FROM crm_customer_protect ");
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
            strSql.Append("select count(1) FROM crm_customer_protect ");
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
            strSql.Append(")AS Row, T.*  from crm_customer_protect T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        ///<summary>
        ///撤销客户的保护状态
        ///<summary>
        public bool cancelProtect(string id)
        {
            string strSql = string.Empty;
            strSql = string.Format("update crm_customer_protect set isInvalid=1 where id in ({0})", id);

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

        ///<summary>
        ///转为公客后，取消保护状态
        ///<summary>
        public bool cancelProtect(string id, string factory_id)
        {
            string strSql = string.Empty;
            strSql = string.Format("update crm_customer_protect set isInvalid=1 where factory_id = '{0}' and Customer_id in ({1})", factory_id, id);

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
            parameters[0].Value = "crm_customer_protect";
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

