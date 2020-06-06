using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ssn_question
    /// </summary>
    public partial class ssn_question
    {
        public ssn_question()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ssn_question");
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
        public bool Add(XHD.Model.ssn_question model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ssn_question(");
            strSql.Append("q_time,title,q_uid,q_name,type,content,score,sp_uid,sp_name,att_file,re_uid,re_name,move_time,status,tel,e_mail,receive_type,isdeleted)");
            strSql.Append(" values (");
            strSql.Append("@q_time,@title,@q_uid,@q_name,@type,@content,@score,@sp_uid,@sp_name,@att_file,@re_uid,@re_name,@move_time,@status,@tel,@e_mail,@receive_type,@isdeleted)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@q_time", MySqlDbType.DateTime),
					new MySqlParameter("@title", MySqlDbType.VarChar,200),
					new MySqlParameter("@q_uid", MySqlDbType.Int32,11),
					new MySqlParameter("@q_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@type", MySqlDbType.Int32,11),
					new MySqlParameter("@content", MySqlDbType.Text),
					new MySqlParameter("@score", MySqlDbType.Int32,4),
					new MySqlParameter("@sp_uid", MySqlDbType.VarChar,500),
					new MySqlParameter("@sp_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@att_file", MySqlDbType.VarChar,200),
					new MySqlParameter("@re_uid", MySqlDbType.Int32,11),
					new MySqlParameter("@re_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@move_time", MySqlDbType.DateTime),
					new MySqlParameter("@status", MySqlDbType.Int32,4),
					new MySqlParameter("@tel", MySqlDbType.VarChar,20),
					new MySqlParameter("@e_mail", MySqlDbType.VarChar,60),
					new MySqlParameter("@receive_type", MySqlDbType.Int32,2),
                    new MySqlParameter("@isdeleted", MySqlDbType.Int32,2)};
            parameters[0].Value = model.q_time;
            parameters[1].Value = model.title;
            parameters[2].Value = model.q_uid;
            parameters[3].Value = model.q_name;
            parameters[4].Value = model.type;
            parameters[5].Value = model.content;
            parameters[6].Value = model.score;
            parameters[7].Value = model.sp_uid;
            parameters[8].Value = model.sp_name;
            parameters[9].Value = model.att_file;
            parameters[10].Value = model.re_uid;
            parameters[11].Value = model.re_name;
            parameters[12].Value = model.move_time;
            parameters[13].Value = model.status;
            parameters[14].Value = model.tel;
            parameters[15].Value = model.e_mail;
            parameters[16].Value = model.receive_type;
            parameters[17].Value = model.isdeleted;

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
        public bool Update(XHD.Model.ssn_question model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ssn_question set ");
            strSql.Append("q_time=@q_time,");
            strSql.Append("title=@title,");
            strSql.Append("q_uid=@q_uid,");
            strSql.Append("q_name=@q_name,");
            strSql.Append("type=@type,");
            strSql.Append("content=@content,");
            strSql.Append("score=@score,");
            strSql.Append("sp_uid=@sp_uid,");
            strSql.Append("sp_name=@sp_name,");
            strSql.Append("att_file=@att_file,");
            strSql.Append("re_uid=@re_uid,");
            strSql.Append("re_name=@re_name,");
            strSql.Append("move_time=@move_time,");
            strSql.Append("status=@status,");
            strSql.Append("tel=@tel,");
            strSql.Append("e_mail=@e_mail,");
            strSql.Append("receive_type=@receive_type,");
            strSql.Append("isdeleted=@isdeleted");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@q_time", MySqlDbType.DateTime),
					new MySqlParameter("@title", MySqlDbType.VarChar,200),
					new MySqlParameter("@q_uid", MySqlDbType.Int32,11),
					new MySqlParameter("@q_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@type", MySqlDbType.Int32,11),
					new MySqlParameter("@content", MySqlDbType.Text),
					new MySqlParameter("@score", MySqlDbType.Int32,4),
					new MySqlParameter("@sp_uid", MySqlDbType.VarChar,500),
					new MySqlParameter("@sp_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@att_file", MySqlDbType.VarChar,200),
					new MySqlParameter("@re_uid", MySqlDbType.Int32,11),
					new MySqlParameter("@re_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@move_time", MySqlDbType.DateTime),
					new MySqlParameter("@status", MySqlDbType.Int32,4),
					new MySqlParameter("@tel", MySqlDbType.VarChar,20),
					new MySqlParameter("@e_mail", MySqlDbType.VarChar,60),
					new MySqlParameter("@receive_type", MySqlDbType.Int32,2),
                    new MySqlParameter("@isdeleted", MySqlDbType.Int32,2),
					new MySqlParameter("@id", MySqlDbType.Int64,20)};
            parameters[0].Value = model.q_time;
            parameters[1].Value = model.title;
            parameters[2].Value = model.q_uid;
            parameters[3].Value = model.q_name;
            parameters[4].Value = model.type;
            parameters[5].Value = model.content;
            parameters[6].Value = model.score;
            parameters[7].Value = model.sp_uid;
            parameters[8].Value = model.sp_name;
            parameters[9].Value = model.att_file;
            parameters[10].Value = model.re_uid;
            parameters[11].Value = model.re_name;
            parameters[12].Value = model.move_time;
            parameters[13].Value = model.status;
            parameters[14].Value = model.tel;
            parameters[15].Value = model.e_mail;
            parameters[16].Value = model.receive_type;
            parameters[17].Value = model.isdeleted;
            parameters[18].Value = model.id;

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
            strSql.Append("delete from ssn_question ");
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
            strSql.Append("delete from ssn_question ");
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
        public XHD.Model.ssn_question GetModel(long id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,q_time,title,q_uid,q_name,type,content,score,sp_uid,sp_name,att_file,re_uid,re_name,move_time,status,tel,e_mail,receive_type,isdeleted from ssn_question ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int64)
			};
            parameters[0].Value = id;

            XHD.Model.ssn_question model = new XHD.Model.ssn_question();
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
        public XHD.Model.ssn_question DataRowToModel(DataRow row)
        {
            XHD.Model.ssn_question model = new XHD.Model.ssn_question();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = long.Parse(row["id"].ToString());
                }
                if (row["q_time"] != null && row["q_time"].ToString() != "")
                {
                    model.q_time = DateTime.Parse(row["q_time"].ToString());
                }
                if (row["title"] != null)
                {
                    model.title = row["title"].ToString();
                }
                if (row["q_uid"] != null && row["q_uid"].ToString() != "")
                {
                    model.q_uid = int.Parse(row["q_uid"].ToString());
                }
                if (row["q_name"] != null)
                {
                    model.q_name = row["q_name"].ToString();
                }
                if (row["type"] != null && row["type"].ToString() != "")
                {
                    model.type = int.Parse(row["type"].ToString());
                }
                if (row["content"] != null)
                {
                    model.content = row["content"].ToString();
                }
                if (row["score"] != null && row["score"].ToString() != "")
                {
                    model.score = int.Parse(row["score"].ToString());
                }
                if (row["sp_uid"] != null)
                {
                    model.sp_uid = row["sp_uid"].ToString();
                }
                if (row["sp_name"] != null)
                {
                    model.sp_name = row["sp_name"].ToString();
                }
                if (row["att_file"] != null)
                {
                    model.att_file = row["att_file"].ToString();
                }
                if (row["re_uid"] != null && row["re_uid"].ToString() != "")
                {
                    model.re_uid = int.Parse(row["re_uid"].ToString());
                }
                if (row["re_name"] != null)
                {
                    model.re_name = row["re_name"].ToString();
                }
                if (row["move_time"] != null && row["move_time"].ToString() != "")
                {
                    model.move_time = DateTime.Parse(row["move_time"].ToString());
                }
                if (row["status"] != null && row["status"].ToString() != "")
                {
                    model.status = int.Parse(row["status"].ToString());
                }
                if (row["tel"] != null)
                {
                    model.tel = row["tel"].ToString();
                }
                if (row["e_mail"] != null)
                {
                    model.e_mail = row["e_mail"].ToString();
                }
                if (row["receive_type"] != null && row["receive_type"].ToString() != "")
                {
                    model.receive_type = int.Parse(row["receive_type"].ToString());
                }
                if (row["isdeleted"] != null && row["isdeleted"].ToString() != "")
                {
                    model.receive_type = int.Parse(row["isdeleted"].ToString());
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
            strSql.Append("select id,q_time,title,q_uid,q_name,type,content,score,sp_uid,sp_name,att_file,re_uid,re_name,move_time,status,tel,e_mail,receive_type,isdeleted ");
            strSql.Append(" FROM ssn_question ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select q.id,q_time,title,q_uid,q_name,type,ifnull(m.art_menu,'未定义类型') as art_menu,case sp_uid when ',all,' then '公开问题' else '指定问题' END as stype,content,score,sp_uid,sp_name,att_file,re_uid,re_name,move_time,status,tel,e_mail,receive_type,isdeleted");
            strSql.Append(" FROM ssn_question as q left join ssn_art_menu as m on m.id=q.type");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql1.Append(" select count(1) FROM ssn_question as g ");
            if (strWhere.Trim() != "")
            {
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
            strSql.Append("select count(1) FROM ssn_question ");
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
            strSql.Append(")AS Row, T.*  from ssn_question T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得问题信息
        /// </summary>
        public DataSet GetQuestion(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select q.id,q.q_time,q.title,q.q_uid,q.q_name,q.type,q.content,q.score,q.sp_uid,q.sp_name,q.att_file,q.re_uid,q.re_name,q.move_time,q.status,q.tel,q.e_mail,q.receive_type,q.isdeleted,e.title as headImg ");
            strSql.Append(" FROM ssn_question as q left join hr_employee as e on q.q_uid=e.ID");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得问题信息
        /// </summary>
        public DataSet GetQAInfo(long id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select  q.qNum,a.aNum,b.bNum,g.gNum from");
            strSql.Append(" (select ifnull(count(*),0)  as qNum from ssn_question where q_uid =" + id + ") as q,");
            strSql.Append(" (select ifnull(count(*),0)  as aNum from ssn_answer where answer_uid =" + id + ") as a,");
            strSql.Append(" (select ifnull(count(*),0)  as bNum from ssn_answer where answer_uid =" + id + " and is_best=1) as b,");
            strSql.Append(" (select ifnull(count(*),0) as gNum from ssn_answer where answer_uid =" + id + " and is_best=1 and evaluatelevel=1) as g");
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
            parameters[0].Value = "ssn_question";
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

