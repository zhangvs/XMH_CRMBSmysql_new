using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_article
    /// </summary>
    public partial class scm_article
    {
        public scm_article()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int article_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_article");
            strSql.Append(" where article_id=@article_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@article_id", MySqlDbType.Int16)
			};
            parameters[0].Value = article_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(SCM.Model.scm_article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_article(");
            strSql.Append("factory_Id,suppliers_id,cat_id,title,content,author,author_email,keywords,article_type,is_open,is_index,add_time,file_url,open_type,link,description,view_rank,content_add,user_id,industry,worker_num,status,isAuditing,faceObject,audit_userId,audit_time)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@suppliers_id,@cat_id,@title,@content,@author,@author_email,@keywords,@article_type,@is_open,@is_index,@add_time,@file_url,@open_type,@link,@description,@view_rank,@content_add,@user_id,@industry,@worker_num,@status,@isAuditing,@faceObject,@audit_userId,@audit_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@cat_id", MySqlDbType.Int16,5),
					new MySqlParameter("@title", MySqlDbType.VarChar,150),
					new MySqlParameter("@content", MySqlDbType.LongText),
					new MySqlParameter("@author", MySqlDbType.VarChar,30),
					new MySqlParameter("@author_email", MySqlDbType.VarChar,60),
					new MySqlParameter("@keywords", MySqlDbType.VarChar,255),
					new MySqlParameter("@article_type", MySqlDbType.Int16,1),
					new MySqlParameter("@is_open", MySqlDbType.Int16,1),
					new MySqlParameter("@is_index", MySqlDbType.Int16,1),
					new MySqlParameter("@add_time", MySqlDbType.Int32,10),
					new MySqlParameter("@file_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@open_type", MySqlDbType.Int16,1),
					new MySqlParameter("@link", MySqlDbType.VarChar,255),
					new MySqlParameter("@description", MySqlDbType.VarChar,255),
					new MySqlParameter("@view_rank", MySqlDbType.VarChar,255),
					new MySqlParameter("@content_add", MySqlDbType.VarChar,255),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@industry", MySqlDbType.VarChar,255),
					new MySqlParameter("@worker_num", MySqlDbType.Int32,11),
					new MySqlParameter("@status", MySqlDbType.Int16,2),
					new MySqlParameter("@isAuditing", MySqlDbType.Int32,1),
					new MySqlParameter("@faceObject", MySqlDbType.Int32,1),
					new MySqlParameter("@audit_userId", MySqlDbType.Int32,11),
					new MySqlParameter("@audit_time", MySqlDbType.Int32,10)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.cat_id;
            parameters[3].Value = model.title;
            parameters[4].Value = model.content;
            parameters[5].Value = model.author;
            parameters[6].Value = model.author_email;
            parameters[7].Value = model.keywords;
            parameters[8].Value = model.article_type;
            parameters[9].Value = model.is_open;
            parameters[10].Value = model.is_index;
            parameters[11].Value = model.add_time;
            parameters[12].Value = model.file_url;
            parameters[13].Value = model.open_type;
            parameters[14].Value = model.link;
            parameters[15].Value = model.description;
            parameters[16].Value = model.view_rank;
            parameters[17].Value = model.content_add;
            parameters[18].Value = model.user_id;
            parameters[19].Value = model.industry;
            parameters[20].Value = model.worker_num;
            parameters[21].Value = model.status;
            parameters[22].Value = model.isAuditing;
            parameters[23].Value = model.faceObject;
            parameters[24].Value = model.audit_userId;
            parameters[25].Value = model.audit_time;

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
        public bool Update(SCM.Model.scm_article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_article set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("suppliers_id=@suppliers_id,");
            strSql.Append("cat_id=@cat_id,");
            strSql.Append("title=@title,");
            strSql.Append("content=@content,");
            strSql.Append("author=@author,");
            strSql.Append("author_email=@author_email,");
            strSql.Append("keywords=@keywords,");
            strSql.Append("article_type=@article_type,");
            strSql.Append("is_open=@is_open,");
            strSql.Append("is_index=@is_index,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("file_url=@file_url,");
            strSql.Append("open_type=@open_type,");
            strSql.Append("link=@link,");
            strSql.Append("description=@description,");
            strSql.Append("view_rank=@view_rank,");
            strSql.Append("content_add=@content_add,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("industry=@industry,");
            strSql.Append("worker_num=@worker_num,");
            strSql.Append("status=@status,");
            strSql.Append("isAuditing=@isAuditing,");
            strSql.Append("faceObject=@faceObject,");
            strSql.Append("audit_userId=@audit_userId,");
            strSql.Append("audit_time=@audit_time");
            strSql.Append(" where article_id=@article_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int16,5),
					new MySqlParameter("@cat_id", MySqlDbType.Int16,5),
					new MySqlParameter("@title", MySqlDbType.VarChar,150),
					new MySqlParameter("@content", MySqlDbType.LongText),
					new MySqlParameter("@author", MySqlDbType.VarChar,30),
					new MySqlParameter("@author_email", MySqlDbType.VarChar,60),
					new MySqlParameter("@keywords", MySqlDbType.VarChar,255),
					new MySqlParameter("@article_type", MySqlDbType.Int16,1),
					new MySqlParameter("@is_open", MySqlDbType.Int16,1),
					new MySqlParameter("@is_index", MySqlDbType.Int16,1),
					new MySqlParameter("@add_time", MySqlDbType.Int32,10),
					new MySqlParameter("@file_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@open_type", MySqlDbType.Int16,1),
					new MySqlParameter("@link", MySqlDbType.VarChar,255),
					new MySqlParameter("@description", MySqlDbType.VarChar,255),
					new MySqlParameter("@view_rank", MySqlDbType.VarChar,255),
					new MySqlParameter("@content_add", MySqlDbType.VarChar,255),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@industry", MySqlDbType.VarChar,255),
					new MySqlParameter("@worker_num", MySqlDbType.Int32,11),
					new MySqlParameter("@status", MySqlDbType.Int16,2),
					new MySqlParameter("@isAuditing", MySqlDbType.Int32,1),
					new MySqlParameter("@faceObject", MySqlDbType.Int32,1),
					new MySqlParameter("@audit_userId", MySqlDbType.Int32,11),
					new MySqlParameter("@audit_time", MySqlDbType.Int32,10),
					new MySqlParameter("@article_id", MySqlDbType.Int16,8)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.cat_id;
            parameters[3].Value = model.title;
            parameters[4].Value = model.content;
            parameters[5].Value = model.author;
            parameters[6].Value = model.author_email;
            parameters[7].Value = model.keywords;
            parameters[8].Value = model.article_type;
            parameters[9].Value = model.is_open;
            parameters[10].Value = model.is_index;
            parameters[11].Value = model.add_time;
            parameters[12].Value = model.file_url;
            parameters[13].Value = model.open_type;
            parameters[14].Value = model.link;
            parameters[15].Value = model.description;
            parameters[16].Value = model.view_rank;
            parameters[17].Value = model.content_add;
            parameters[18].Value = model.user_id;
            parameters[19].Value = model.industry;
            parameters[20].Value = model.worker_num;
            parameters[21].Value = model.status;
            parameters[22].Value = model.isAuditing;
            parameters[23].Value = model.faceObject;
            parameters[24].Value = model.audit_userId;
            parameters[25].Value = model.audit_time;
            parameters[26].Value = model.article_id;

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
        public bool Delete(int article_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_article ");
            strSql.Append(" where article_id=@article_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@article_id", MySqlDbType.Int16)
			};
            parameters[0].Value = article_id;

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
        public bool DeleteList(string article_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_article ");
            strSql.Append(" where article_id in (" + article_idlist + ")  ");
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
        public SCM.Model.scm_article GetModel(int article_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select article_id,factory_Id,suppliers_id,cat_id,title,content,author,author_email,keywords,article_type,is_open,is_index,add_time,file_url,open_type,link,description,view_rank,content_add,user_id,industry,worker_num,status,isAuditing,faceObject,audit_userId,audit_time from ecs_article ");
            strSql.Append(" where article_id=@article_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@article_id", MySqlDbType.Int16)
			};
            parameters[0].Value = article_id;

            SCM.Model.scm_article model = new SCM.Model.scm_article();
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
        public SCM.Model.scm_article DataRowToModel(DataRow row)
        {
            SCM.Model.scm_article model = new SCM.Model.scm_article();
            if (row != null)
            {
                //model.article_id=row["article_id"].ToString();
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                if (row["cat_id"] != null && row["cat_id"].ToString() != "")
                {
                    model.cat_id = int.Parse(row["cat_id"].ToString());
                }
                if (row["title"] != null)
                {
                    model.title = row["title"].ToString();
                }
                if (row["content"] != null)
                {
                    model.content = row["content"].ToString();
                }
                if (row["author"] != null)
                {
                    model.author = row["author"].ToString();
                }
                if (row["author_email"] != null)
                {
                    model.author_email = row["author_email"].ToString();
                }
                if (row["keywords"] != null)
                {
                    model.keywords = row["keywords"].ToString();
                }
                if (row["article_type"] != null && row["article_type"].ToString() != "")
                {
                    model.article_type = int.Parse(row["article_type"].ToString());
                }
                if (row["is_open"] != null && row["is_open"].ToString() != "")
                {
                    model.is_open = int.Parse(row["is_open"].ToString());
                }
                if (row["is_index"] != null && row["is_index"].ToString() != "")
                {
                    model.is_index = int.Parse(row["is_index"].ToString());
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = int.Parse(row["add_time"].ToString());
                }
                if (row["file_url"] != null)
                {
                    model.file_url = row["file_url"].ToString();
                }
                if (row["open_type"] != null && row["open_type"].ToString() != "")
                {
                    model.open_type = int.Parse(row["open_type"].ToString());
                }
                if (row["link"] != null)
                {
                    model.link = row["link"].ToString();
                }
                if (row["description"] != null)
                {
                    model.description = row["description"].ToString();
                }
                if (row["view_rank"] != null)
                {
                    model.view_rank = row["view_rank"].ToString();
                }
                if (row["content_add"] != null)
                {
                    model.content_add = row["content_add"].ToString();
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["industry"] != null)
                {
                    model.industry = row["industry"].ToString();
                }
                if (row["worker_num"] != null && row["worker_num"].ToString() != "")
                {
                    model.worker_num = int.Parse(row["worker_num"].ToString());
                }
                if (row["status"] != null && row["status"].ToString() != "")
                {
                    model.status = int.Parse(row["status"].ToString());
                }
                if (row["isAuditing"] != null && row["isAuditing"].ToString() != "")
                {
                    model.isAuditing = int.Parse(row["isAuditing"].ToString());
                }
                if (row["faceObject"] != null && row["faceObject"].ToString() != "")
                {
                    model.faceObject = int.Parse(row["faceObject"].ToString());
                }
                if (row["audit_userId"] != null && row["audit_userId"].ToString() != "")
                {
                    model.audit_userId = int.Parse(row["audit_userId"].ToString());
                }
                if (row["audit_time"] != null && row["audit_time"].ToString() != "")
                {
                    model.audit_time = int.Parse(row["audit_time"].ToString());
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
            strSql.Append("select article_id,factory_Id,suppliers_id,cat_id,title,content,author,author_email,keywords,article_type,is_open,is_index,add_time,file_url,open_type,link,description,view_rank,content_add,user_id,industry,worker_num,status,isAuditing,faceObject,audit_userId,audit_time ");
            strSql.Append(" FROM ecs_article ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }



        //最新信息审核页面加载 
        public DataSet GetList(int PageSize, int startIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select distinct a.article_id,a.factory_Id,a.suppliers_id,a.cat_id,a.title,c.cat_name,a.content,author,a.keywords,a.article_type,a.is_open,a.is_index,a.add_time,a.open_type,a.description,a.view_rank,a.content_add,a.user_id,a.industry,a.worker_num,a.status,a.isAuditing,a.faceObject,s.suppliers_name from ecs_article a ");
            strSql.Append(" left join ecs_article_cat as c on a.cat_id=c.cat_id ");
            strSql.Append(" left join ecs_suppliers s on s.suppliers_id=a.suppliers_id");

            strSql1.Append(" select count(distinct a.article_id) from ecs_article as a left join  ecs_article_cat as c on a.cat_id=c.cat_id ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (startIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 批量审核
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool Audit(string id, int empId, int time)
        {
            string strSql = string.Format(@"update ecs_article set isAuditing='{0}',audit_userId='{1}',audit_time='{2}',cat_id='{3}' where article_id in ({4})", 1, empId, time, 23, id);
            int rows = DbHelperMySQL.ExecuteSql(strSql);
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
        /// 单条审核
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool AuditOne(int id, int empId, int time)
        {
            string strSql = string.Format(@"update ecs_article set isAuditing='{0}',audit_userId='{1}',audit_time='{2}',cat_id='{3}' where article_id = '{4}'", 1, empId, time, 23, id);
            int rows = DbHelperMySQL.ExecuteSql(strSql);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

