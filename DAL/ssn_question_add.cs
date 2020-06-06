using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ssn_question_add
    /// </summary>
    public partial class ssn_question_add
    {
        public ssn_question_add()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ssn_question_add");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ssn_question_add model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ssn_question_add(");
            strSql.Append("answer_id,content,type,answer_uid,answer_name,question_id,question_uid,question_name,answer_other_uid,answer_other_name,operatortime,isdeleted)");
            strSql.Append(" values (");
            strSql.Append("@answer_id,@content,@type,@answer_uid,@answer_name,@question_id,@question_uid,@question_name,@answer_other_uid,@answer_other_name,@operatortime,@isdeleted)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@answer_id", MySqlDbType.Int64,20),
					new MySqlParameter("@content", MySqlDbType.Text),
					new MySqlParameter("@type", MySqlDbType.Int32,4),
					new MySqlParameter("@answer_uid", MySqlDbType.Int64,20),
					new MySqlParameter("@answer_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@question_id", MySqlDbType.Int64,20),
					new MySqlParameter("@question_uid", MySqlDbType.Int64,20),
					new MySqlParameter("@question_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@answer_other_uid", MySqlDbType.Int64,20),
					new MySqlParameter("@answer_other_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@operatortime", MySqlDbType.DateTime),
                    new MySqlParameter("@isdeleted", MySqlDbType.Int32,2)};
            parameters[0].Value = model.answer_id;
            parameters[1].Value = model.content;
            parameters[2].Value = model.type;
            parameters[3].Value = model.answer_uid;
            parameters[4].Value = model.answer_name;
            parameters[5].Value = model.question_id;
            parameters[6].Value = model.question_uid;
            parameters[7].Value = model.question_name;
            parameters[8].Value = model.answer_other_uid;
            parameters[9].Value = model.answer_other_name;
            parameters[10].Value = model.operatortime;
            parameters[11].Value = model.isdeleted;
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
        public bool Update(XHD.Model.ssn_question_add model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_question_add set ");
            strSql.Append("answer_id=@answer_id,");
            strSql.Append("content=@content,");
            strSql.Append("type=@type,");
            strSql.Append("answer_uid=@answer_uid,");
            strSql.Append("answer_name=@answer_name,");
            strSql.Append("question_id=@question_id,");
            strSql.Append("question_uid=@question_uid,");
            strSql.Append("question_name=@question_name,");
            strSql.Append("answer_other_uid=@answer_other_uid,");
            strSql.Append("answer_other_name=@answer_other_name,");
            strSql.Append("operatortime=@operatortime,");
            strSql.Append("isdeleted=@isdeleted");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@answer_id", MySqlDbType.Int64,20),
					new MySqlParameter("@content", MySqlDbType.Text),
					new MySqlParameter("@type", MySqlDbType.Int32,4),
					new MySqlParameter("@answer_uid", MySqlDbType.Int64,20),
					new MySqlParameter("@answer_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@question_id", MySqlDbType.Int64,20),
					new MySqlParameter("@question_uid", MySqlDbType.Int64,20),
					new MySqlParameter("@question_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@answer_other_uid", MySqlDbType.Int64,20),
					new MySqlParameter("@answer_other_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@operatortime", MySqlDbType.DateTime),
                    new MySqlParameter("@isdeleted", MySqlDbType.Int32,2),
					new MySqlParameter("@id", MySqlDbType.Int64,20)};
            parameters[0].Value = model.answer_id;
            parameters[1].Value = model.content;
            parameters[2].Value = model.type;
            parameters[3].Value = model.answer_uid;
            parameters[4].Value = model.answer_name;
            parameters[5].Value = model.question_id;
            parameters[6].Value = model.question_uid;
            parameters[7].Value = model.question_name;
            parameters[8].Value = model.answer_other_uid;
            parameters[9].Value = model.answer_other_name;
            parameters[10].Value = model.operatortime;
            parameters[11].Value = model.isdeleted;
            parameters[12].Value = model.id;

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
        public bool Delete(long id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ssn_question_add ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
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
            strSql.Append("delete from ssn_question_add ");
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
        public XHD.Model.ssn_question_add GetModel(long id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,answer_id,content,type,answer_uid,answer_name,question_id,question_uid,question_name,answer_other_uid,answer_other_name,operatortime,isdeleted from ssn_question_add ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
            parameters[0].Value = id;

            XHD.Model.ssn_question_add model = new XHD.Model.ssn_question_add();
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
        public XHD.Model.ssn_question_add DataRowToModel(DataRow row)
        {
            XHD.Model.ssn_question_add model = new XHD.Model.ssn_question_add();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = long.Parse(row["id"].ToString());
                }
                if (row["answer_id"] != null && row["answer_id"].ToString() != "")
                {
                    model.answer_id = long.Parse(row["answer_id"].ToString());
                }
                if (row["content"] != null)
                {
                    model.content = row["content"].ToString();
                }
                if (row["type"] != null && row["type"].ToString() != "")
                {
                    model.type = int.Parse(row["type"].ToString());
                }
                if (row["answer_uid"] != null && row["answer_uid"].ToString() != "")
                {
                    model.answer_uid = long.Parse(row["answer_uid"].ToString());
                }
                if (row["answer_name"] != null)
                {
                    model.answer_name = row["answer_name"].ToString();
                }
                if (row["question_id"] != null && row["question_id"].ToString() != "")
                {
                    model.question_id = long.Parse(row["question_id"].ToString());
                }
                if (row["question_uid"] != null && row["question_uid"].ToString() != "")
                {
                    model.question_uid = long.Parse(row["question_uid"].ToString());
                }
                if (row["question_name"] != null)
                {
                    model.question_name = row["question_name"].ToString();
                }
                if (row["answer_other_uid"] != null && row["answer_other_uid"].ToString() != "")
                {
                    model.answer_other_uid = long.Parse(row["answer_other_uid"].ToString());
                }
                if (row["answer_other_name"] != null)
                {
                    model.answer_other_name = row["answer_other_name"].ToString();
                }
                if (row["operatortime"] != null && row["operatortime"].ToString() != "")
                {
                    model.operatortime = DateTime.Parse(row["operatortime"].ToString());
                }
                if (row["isdeleted"] != null && row["isdeleted"].ToString() != "")
                {
                    model.type = int.Parse(row["isdeleted"].ToString());
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
            strSql.Append("select id,answer_id,content,type,answer_uid,answer_name,question_id,question_uid,question_name,answer_other_uid,answer_other_name,operatortime,isdeleted ");
            strSql.Append(" FROM ssn_question_add ");
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
            strSql.Append("select count(1) FROM ssn_question_add ");
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
            strSql.Append(")AS Row, T.*  from ssn_question_add T ");
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
            parameters[0].Value = "ssn_question_add";
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

