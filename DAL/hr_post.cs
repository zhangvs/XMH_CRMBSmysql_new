using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// ���ݷ�����:hr_post
    /// </summary>
    public partial class hr_post
    {
        public hr_post()
        { }
        #region  Method

        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("post_id", "hr_post");
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int post_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from hr_post");
            strSql.Append(" where post_id=@post_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@post_id", MySqlDbType.Int32,4)};
            parameters[0].Value = post_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(XHD.Model.hr_post model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into hr_post(");
            strSql.Append("factory_Id,post_name,position_id,position_name,position_order,dep_id,depname,emp_id,emp_name,default_post,note,post_descript,isDelete,Delete_time)");
            strSql.Append(" values (");
            strSql.Append("@factory_Id,@post_name,@position_id,@position_name,@position_order,@dep_id,@depname,@emp_id,@emp_name,@default_post,@note,@post_descript,@isDelete,@Delete_time)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@post_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@position_id", MySqlDbType.Int32,4),
					new MySqlParameter("@position_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@position_order", MySqlDbType.Int32,4),
					new MySqlParameter("@dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@depname", MySqlDbType.VarChar,255),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@default_post", MySqlDbType.Int32,4),
					new MySqlParameter("@note", MySqlDbType.VarChar),
					new MySqlParameter("@post_descript", MySqlDbType.VarChar),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,4),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.post_name;
            parameters[2].Value = model.position_id;
            parameters[3].Value = model.position_name;
            parameters[4].Value = model.position_order;
            parameters[5].Value = model.dep_id;
            parameters[6].Value = model.depname;
            parameters[7].Value = model.emp_id;
            parameters[8].Value = model.emp_name;
            parameters[9].Value = model.default_post;
            parameters[10].Value = model.note;
            parameters[11].Value = model.post_descript;
            parameters[12].Value = model.isDelete;
            parameters[13].Value = model.Delete_time;

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
        /// ����һ������
        /// </summary>
        public bool Update(XHD.Model.hr_post model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_post set ");
            strSql.Append("factory_Id=@factory_Id,");
            strSql.Append("post_name=@post_name,");
            strSql.Append("position_id=@position_id,");
            strSql.Append("position_name=@position_name,");
            strSql.Append("position_order=@position_order,");
            strSql.Append("dep_id=@dep_id,");
            strSql.Append("depname=@depname,");
            strSql.Append("emp_id=@emp_id,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("default_post=@default_post,");
            strSql.Append("note=@note,");
            strSql.Append("post_descript=@post_descript");
            strSql.Append(" where post_id=@post_id");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@post_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@position_id", MySqlDbType.Int32,4),
					new MySqlParameter("@position_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@position_order", MySqlDbType.Int32,4),
					new MySqlParameter("@dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@depname", MySqlDbType.VarChar,255),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@default_post", MySqlDbType.Int32,4),
					new MySqlParameter("@note", MySqlDbType.VarChar),
					new MySqlParameter("@post_descript", MySqlDbType.VarChar),
					new MySqlParameter("@post_id", MySqlDbType.Int32,4)};
            parameters[0].Value = model.factory_Id;
            parameters[1].Value = model.post_name;
            parameters[2].Value = model.position_id;
            parameters[3].Value = model.position_name;
            parameters[4].Value = model.position_order;
            parameters[5].Value = model.dep_id;
            parameters[6].Value = model.depname;
            parameters[7].Value = model.emp_id;
            parameters[8].Value = model.emp_name;
            parameters[9].Value = model.default_post;
            parameters[10].Value = model.note;
            parameters[11].Value = model.post_descript;
            parameters[12].Value = model.post_id;

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
        /// Ԥɾ��
        /// </summary>
        public bool AdvanceDelete(int id, int isDelete, string time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_post set ");
            strSql.Append("isDelete=" + isDelete);
            strSql.Append(",Delete_time='" + time + "'");
            strSql.Append(" where post_id=" + id);
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
        /// ɾ��һ������
        /// </summary>
        public bool Delete(int post_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from hr_post ");
            strSql.Append(" where post_id=@post_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@post_id", MySqlDbType.Int32,4)
};
            parameters[0].Value = post_id;

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
        /// ɾ��һ������
        /// </summary>
        public bool DeleteList(string post_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from hr_post ");
            strSql.Append(" where post_id in (" + post_idlist + ")  ");
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
        /// �õ�һ������ʵ��
        /// </summary>
        public XHD.Model.hr_post GetModel(int post_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  post_id,post_name,position_id,position_name,position_order,dep_id,depname,emp_id,emp_name,default_post,note,post_descript,isDelete,Delete_time from hr_post ");
            strSql.Append(" where post_id=@post_id limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@post_id", MySqlDbType.Int32,4)
};
            parameters[0].Value = post_id;

            XHD.Model.hr_post model = new XHD.Model.hr_post();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["post_id"] != null && ds.Tables[0].Rows[0]["post_id"].ToString() != "")
                {
                    model.post_id = int.Parse(ds.Tables[0].Rows[0]["post_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["post_name"] != null && ds.Tables[0].Rows[0]["post_name"].ToString() != "")
                {
                    model.post_name = ds.Tables[0].Rows[0]["post_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["position_id"] != null && ds.Tables[0].Rows[0]["position_id"].ToString() != "")
                {
                    model.position_id = int.Parse(ds.Tables[0].Rows[0]["position_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["position_name"] != null && ds.Tables[0].Rows[0]["position_name"].ToString() != "")
                {
                    model.position_name = ds.Tables[0].Rows[0]["position_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["position_order"] != null && ds.Tables[0].Rows[0]["position_order"].ToString() != "")
                {
                    model.position_order = int.Parse(ds.Tables[0].Rows[0]["position_order"].ToString());
                }
                if (ds.Tables[0].Rows[0]["dep_id"] != null && ds.Tables[0].Rows[0]["dep_id"].ToString() != "")
                {
                    model.dep_id = int.Parse(ds.Tables[0].Rows[0]["dep_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["depname"] != null && ds.Tables[0].Rows[0]["depname"].ToString() != "")
                {
                    model.depname = ds.Tables[0].Rows[0]["depname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["emp_id"] != null && ds.Tables[0].Rows[0]["emp_id"].ToString() != "")
                {
                    model.emp_id = int.Parse(ds.Tables[0].Rows[0]["emp_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["emp_name"] != null && ds.Tables[0].Rows[0]["emp_name"].ToString() != "")
                {
                    model.emp_name = ds.Tables[0].Rows[0]["emp_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["default_post"] != null && ds.Tables[0].Rows[0]["default_post"].ToString() != "")
                {
                    model.default_post = int.Parse(ds.Tables[0].Rows[0]["default_post"].ToString());
                }
                if (ds.Tables[0].Rows[0]["note"] != null && ds.Tables[0].Rows[0]["note"].ToString() != "")
                {
                    model.note = ds.Tables[0].Rows[0]["note"].ToString();
                }
                if (ds.Tables[0].Rows[0]["post_descript"] != null && ds.Tables[0].Rows[0]["post_descript"].ToString() != "")
                {
                    model.post_descript = ds.Tables[0].Rows[0]["post_descript"].ToString();
                }
                if (ds.Tables[0].Rows[0]["isDelete"] != null && ds.Tables[0].Rows[0]["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(ds.Tables[0].Rows[0]["isDelete"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Delete_time"] != null && ds.Tables[0].Rows[0]["Delete_time"].ToString() != "")
                {
                    model.Delete_time = DateTime.Parse(ds.Tables[0].Rows[0]["Delete_time"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select post_id,Factory_Id,post_name,position_id,position_name,position_order,dep_id,depname,emp_id,emp_name,default_post,note,post_descript,isDelete,Delete_time ");
            strSql.Append(" FROM hr_post ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" post_id,post_name,position_id,position_name,position_order,dep_id,depname,emp_id,emp_name,default_post,note,post_descript,isDelete,Delete_time ");
            strSql.Append(" FROM hr_post ");
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
        /// ���ǰ��������
        /// </summary>
        public DataSet GetListAndDept(string strWhere1, string strWhere2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  emp_id,concat(emp_name,'���ˡ�') as emp_name,1 as type ");
            strSql.Append(" FROM hr_post ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }
            strSql.Append(" union all ");
            strSql.Append(" select id as emp_id,concat(d_name,'������') as emp_name,2 as type ");
            strSql.Append(" from hr_department ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }
            strSql.Append(" order by type");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  * FROM hr_post ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM hr_post ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM hr_post ");
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
        /// ���¸�λ��Ա
        /// </summary>
        public bool UpdatePostEmp(XHD.Model.hr_post model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_post set ");

            strSql.Append("emp_id=@emp_id,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("default_post=@default_post");
            strSql.Append(" where post_id=@post_id");
            MySqlParameter[] parameters = {					
					new MySqlParameter("@emp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@default_post", MySqlDbType.Int32,4),
					new MySqlParameter("@post_id", MySqlDbType.Int32,4)};

            parameters[0].Value = model.emp_id;
            parameters[1].Value = model.emp_name;
            parameters[2].Value = model.default_post;
            parameters[3].Value = model.post_id;

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
        /// ��ո��¸�λ��Ա
        /// </summary>
        public bool UpdatePostEmpbyEid(int empid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_post set ");

            strSql.Append("emp_id=-1,");
            strSql.Append("emp_name='',");
            strSql.Append("default_post=0");
            strSql.Append(" where emp_id=@emp_id");
            MySqlParameter[] parameters = {					
					new MySqlParameter("@emp_id", MySqlDbType.Int32,4)
                                        };

            parameters[0].Value = empid;

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
        /// ��������б�
        /// </summary>
        public DataSet GetEmpCode(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT emp_code from hr_post p LEFT JOIN hr_employee emp on p.emp_id=emp.ID ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}

