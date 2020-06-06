using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:public_notice
    /// </summary>
    public partial class public_notice
    {
        public public_notice()
        { }
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "public_notice");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from public_notice");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.public_notice model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into public_notice(");
            strSql.Append("Factory_Id,notice_title,notice_content,create_id,create_name,dep_id,dep_name,notice_time,receive_id,receive_name)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@notice_title,@notice_content,@create_id,@create_name,@dep_id,@dep_name,@notice_time,@receive_id,@receive_name)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
                    new MySqlParameter("Factory_Id",MySqlDbType.VarChar,60),
					new MySqlParameter("@notice_title", MySqlDbType.VarChar,200),
					new MySqlParameter("@notice_content", MySqlDbType.VarChar,-1),
					new MySqlParameter("@create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@dep_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@notice_time", MySqlDbType.DateTime),
                    new MySqlParameter("@receive_id", MySqlDbType.VarChar,-1),
                    new MySqlParameter("@receive_name", MySqlDbType.VarChar,-1)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.notice_title;
            parameters[2].Value = model.notice_content;
            parameters[3].Value = model.create_id;
            parameters[4].Value = model.create_name;
            parameters[5].Value = model.dep_id;
            parameters[6].Value = model.dep_name;
            parameters[7].Value = model.notice_time;
            parameters[8].Value = model.receive_id;
            parameters[9].Value = model.receive_name;

            object obj = DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.public_notice model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update public_notice set ");
            strSql.Append("notice_title=@notice_title,");
            strSql.Append("notice_content=@notice_content,");
            strSql.Append("create_id=@create_id,");
            strSql.Append("create_name=@create_name,");
            strSql.Append("dep_id=@dep_id,");
            strSql.Append("dep_name=@dep_name,");
            strSql.Append("notice_time=@notice_time,");
            strSql.Append("receive_id=@receive_id,");
            strSql.Append("receive_name=@receive_name");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@notice_title", MySqlDbType.VarChar,200),
					new MySqlParameter("@notice_content", MySqlDbType.VarChar),
					new MySqlParameter("@create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@dep_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@notice_time", MySqlDbType.DateTime),
                    new MySqlParameter("@receive_id", MySqlDbType.VarChar,-1),
                    new MySqlParameter("@receive_name", MySqlDbType.VarChar,-1),
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = model.notice_title;
            parameters[1].Value = model.notice_content;
            parameters[2].Value = model.create_id;
            parameters[3].Value = model.create_name;
            parameters[4].Value = model.dep_id;
            parameters[5].Value = model.dep_name;
            parameters[6].Value = model.notice_time;
            parameters[7].Value = model.receive_id;
            parameters[8].Value = model.receive_name;
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
        /// 预删除
        /// </summary>
        public bool AdvanceDelete(int id, int isDelete, string time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update public_notice set ");
            strSql.Append("isDelete=" + isDelete);
            strSql.Append(",Delete_time='" + time + "'");
            strSql.Append(" where id=" + id);
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
            strSql.Append("delete from public_notice ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)
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
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from public_notice ");
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
        public XHD.Model.public_notice GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,notice_title,notice_content,create_id,create_name,dep_id,dep_name,notice_time from public_notice,receive_id,receive_name ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)
};
            parameters[0].Value = id;

            XHD.Model.public_notice model = new XHD.Model.public_notice();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["notice_title"] != null && ds.Tables[0].Rows[0]["notice_title"].ToString() != "")
                {
                    model.notice_title = ds.Tables[0].Rows[0]["notice_title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["notice_content"] != null && ds.Tables[0].Rows[0]["notice_content"].ToString() != "")
                {
                    model.notice_content = ds.Tables[0].Rows[0]["notice_content"].ToString();
                }
                if (ds.Tables[0].Rows[0]["create_id"] != null && ds.Tables[0].Rows[0]["create_id"].ToString() != "")
                {
                    model.create_id = int.Parse(ds.Tables[0].Rows[0]["create_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["create_name"] != null && ds.Tables[0].Rows[0]["create_name"].ToString() != "")
                {
                    model.create_name = ds.Tables[0].Rows[0]["create_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dep_id"] != null && ds.Tables[0].Rows[0]["dep_id"].ToString() != "")
                {
                    model.dep_id = int.Parse(ds.Tables[0].Rows[0]["dep_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dep_name"] != null && ds.Tables[0].Rows[0]["dep_name"].ToString() != "")
                {
                    model.dep_name = ds.Tables[0].Rows[0]["dep_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["notice_time"] != null && ds.Tables[0].Rows[0]["notice_time"].ToString() != "")
                {
                    model.notice_time = DateTime.Parse(ds.Tables[0].Rows[0]["notice_time"].ToString());
                }
                if (ds.Tables[0].Rows[0]["receive_id"] != null && ds.Tables[0].Rows[0]["receive_id"].ToString() != "")
                {
                    model.receive_id = ds.Tables[0].Rows[0]["receive_id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["receive_name"] != null && ds.Tables[0].Rows[0]["receive_name"].ToString() != "")
                {
                    model.receive_name = ds.Tables[0].Rows[0]["receive_name"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,notice_title,notice_content,create_id,create_name,dep_id,dep_name,notice_time,receive_id,receive_name ");
            strSql.Append(" FROM public_notice ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");

            strSql.Append(" id,notice_title,notice_content,create_id,create_name,dep_id,dep_name,notice_time,receive_id,receive_name ");
            strSql.Append(" FROM public_notice ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
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
            strSql.Append("select ");
            strSql.Append("  * FROM public_notice ");
            //strSql.Append(" WHERE id not in ( SELECT id FROM public_notice limit " + (PageIndex - 1) * PageSize + " ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM public_notice ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

