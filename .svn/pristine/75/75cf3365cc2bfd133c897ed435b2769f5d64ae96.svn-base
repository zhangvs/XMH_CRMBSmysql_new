using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_admin_user
    /// </summary>
    public partial class ecs_admin_user
    {
        public ecs_admin_user()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int user_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_admin_user");
            strSql.Append(" where user_id=@user_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32)
			};
            parameters[0].Value = user_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_admin_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_admin_user(");
            strSql.Append("user_name,real_name,email,password,ec_salt,add_time,last_login,last_ip,points,action_list,nav_list,lang_type,agency_id,suppliers_id,todolist,role_id,admin_market_area,user_tel,user_qq,nickname,status,is_lockable,higher,unix_timestamp)");
            strSql.Append(" values (");
            strSql.Append("@user_name,@real_name,@email,@password,@ec_salt,@add_time,@last_login,@last_ip,@points,@action_list,@nav_list,@lang_type,@agency_id,@suppliers_id,@todolist,@role_id,@admin_market_area,@user_tel,@user_qq,@nickname,@status,@is_lockable,@higher,@unix_timestamp)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@real_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@password", MySqlDbType.VarChar,32),
					new MySqlParameter("@ec_salt", MySqlDbType.VarChar,10),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@last_login", MySqlDbType.Int32,11),
					new MySqlParameter("@last_ip", MySqlDbType.VarChar,15),
					new MySqlParameter("@points", MySqlDbType.Int32,11),
					new MySqlParameter("@action_list", MySqlDbType.Text),
					new MySqlParameter("@nav_list", MySqlDbType.Text),
					new MySqlParameter("@lang_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@agency_id", MySqlDbType.Int32,5),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,5),
					new MySqlParameter("@todolist", MySqlDbType.LongText),
					new MySqlParameter("@role_id", MySqlDbType.Int32,5),
					new MySqlParameter("@admin_market_area", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_tel", MySqlDbType.VarChar,30),
					new MySqlParameter("@user_qq", MySqlDbType.VarChar,20),
					new MySqlParameter("@nickname", MySqlDbType.VarChar,30),
					new MySqlParameter("@status", MySqlDbType.Int32,1),
					new MySqlParameter("@is_lockable", MySqlDbType.Int32,1),
					new MySqlParameter("@higher", MySqlDbType.VarChar,10),
					new MySqlParameter("@unix_timestamp", MySqlDbType.Int32,11)};
            parameters[0].Value = model.user_name;
            parameters[1].Value = model.real_name;
            parameters[2].Value = model.email;
            parameters[3].Value = model.password;
            parameters[4].Value = model.ec_salt;
            parameters[5].Value = model.add_time;
            parameters[6].Value = model.last_login;
            parameters[7].Value = model.last_ip;
            parameters[8].Value = model.points;
            parameters[9].Value = model.action_list;
            parameters[10].Value = model.nav_list;
            parameters[11].Value = model.lang_type;
            parameters[12].Value = model.agency_id;
            parameters[13].Value = model.suppliers_id;
            parameters[14].Value = model.todolist;
            parameters[15].Value = model.role_id;
            parameters[16].Value = model.admin_market_area;
            parameters[17].Value = model.user_tel;
            parameters[18].Value = model.user_qq;
            parameters[19].Value = model.nickname;
            parameters[20].Value = model.status;
            parameters[21].Value = model.is_lockable;
            parameters[22].Value = model.higher;
            parameters[23].Value = model.unix_timestamp;

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
        public bool Update(XHD.Model.ecs_admin_user model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_admin_user set ");
            strSql.Append("user_name=@user_name,");
            strSql.Append("real_name=@real_name,");
            strSql.Append("email=@email,");
            strSql.Append("password=@password,");
            strSql.Append("ec_salt=@ec_salt,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("last_login=@last_login,");
            strSql.Append("last_ip=@last_ip,");
            strSql.Append("points=@points,");
            strSql.Append("action_list=@action_list,");
            strSql.Append("nav_list=@nav_list,");
            strSql.Append("lang_type=@lang_type,");
            strSql.Append("agency_id=@agency_id,");
            strSql.Append("suppliers_id=@suppliers_id,");
            strSql.Append("todolist=@todolist,");
            strSql.Append("role_id=@role_id,");
            strSql.Append("admin_market_area=@admin_market_area,");
            strSql.Append("user_tel=@user_tel,");
            strSql.Append("user_qq=@user_qq,");
            strSql.Append("nickname=@nickname,");
            strSql.Append("status=@status,");
            strSql.Append("is_lockable=@is_lockable,");
            strSql.Append("higher=@higher,");
            strSql.Append("unix_timestamp=@unix_timestamp");
            strSql.Append(" where user_id=@user_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@real_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@password", MySqlDbType.VarChar,32),
					new MySqlParameter("@ec_salt", MySqlDbType.VarChar,10),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@last_login", MySqlDbType.Int32,11),
					new MySqlParameter("@last_ip", MySqlDbType.VarChar,15),
					new MySqlParameter("@points", MySqlDbType.Int32,11),
					new MySqlParameter("@action_list", MySqlDbType.Text),
					new MySqlParameter("@nav_list", MySqlDbType.Text),
					new MySqlParameter("@lang_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@agency_id", MySqlDbType.Int32,5),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,5),
					new MySqlParameter("@todolist", MySqlDbType.LongText),
					new MySqlParameter("@role_id", MySqlDbType.Int32,5),
					new MySqlParameter("@admin_market_area", MySqlDbType.VarChar,60),
					new MySqlParameter("@user_tel", MySqlDbType.VarChar,30),
					new MySqlParameter("@user_qq", MySqlDbType.VarChar,20),
					new MySqlParameter("@nickname", MySqlDbType.VarChar,30),
					new MySqlParameter("@status", MySqlDbType.Int32,1),
					new MySqlParameter("@is_lockable", MySqlDbType.Int32,1),
					new MySqlParameter("@higher", MySqlDbType.VarChar,10),
					new MySqlParameter("@unix_timestamp", MySqlDbType.Int32,11),
					new MySqlParameter("@user_id", MySqlDbType.Int32,5)};
            parameters[0].Value = model.user_name;
            parameters[1].Value = model.real_name;
            parameters[2].Value = model.email;
            parameters[3].Value = model.password;
            parameters[4].Value = model.ec_salt;
            parameters[5].Value = model.add_time;
            parameters[6].Value = model.last_login;
            parameters[7].Value = model.last_ip;
            parameters[8].Value = model.points;
            parameters[9].Value = model.action_list;
            parameters[10].Value = model.nav_list;
            parameters[11].Value = model.lang_type;
            parameters[12].Value = model.agency_id;
            parameters[13].Value = model.suppliers_id;
            parameters[14].Value = model.todolist;
            parameters[15].Value = model.role_id;
            parameters[16].Value = model.admin_market_area;
            parameters[17].Value = model.user_tel;
            parameters[18].Value = model.user_qq;
            parameters[19].Value = model.nickname;
            parameters[20].Value = model.status;
            parameters[21].Value = model.is_lockable;
            parameters[22].Value = model.higher;
            parameters[23].Value = model.unix_timestamp;
            parameters[24].Value = model.user_id;

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
        public bool Delete(int user_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_admin_user ");
            strSql.Append(" where user_id=@user_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32)
			};
            parameters[0].Value = user_id;

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
        public bool DeleteList(string user_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_admin_user ");
            strSql.Append(" where user_id in (" + user_idlist + ")  ");
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
        public XHD.Model.ecs_admin_user GetModel(int user_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select user_id,user_name,real_name,email,password,ec_salt,add_time,last_login,last_ip,points,action_list,nav_list,lang_type,agency_id,suppliers_id,todolist,role_id,admin_market_area,user_tel,user_qq,nickname,status,is_lockable,higher,unix_timestamp from ecs_admin_user ");
            strSql.Append(" where user_id=@user_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32)
			};
            parameters[0].Value = user_id;

            XHD.Model.ecs_admin_user model = new XHD.Model.ecs_admin_user();
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
        public XHD.Model.ecs_admin_user DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_admin_user model = new XHD.Model.ecs_admin_user();
            if (row != null)
            {
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["user_name"] != null)
                {
                    model.user_name = row["user_name"].ToString();
                }
                if (row["real_name"] != null)
                {
                    model.real_name = row["real_name"].ToString();
                }
                if (row["email"] != null)
                {
                    model.email = row["email"].ToString();
                }
                if (row["password"] != null)
                {
                    model.password = row["password"].ToString();
                }
                if (row["ec_salt"] != null)
                {
                    model.ec_salt = row["ec_salt"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = int.Parse(row["add_time"].ToString());
                }
                if (row["last_login"] != null && row["last_login"].ToString() != "")
                {
                    model.last_login = int.Parse(row["last_login"].ToString());
                }
                if (row["last_ip"] != null)
                {
                    model.last_ip = row["last_ip"].ToString();
                }
                if (row["points"] != null && row["points"].ToString() != "")
                {
                    model.points = int.Parse(row["points"].ToString());
                }
                if (row["action_list"] != null)
                {
                    model.action_list = row["action_list"].ToString();
                }
                if (row["nav_list"] != null)
                {
                    model.nav_list = row["nav_list"].ToString();
                }
                if (row["lang_type"] != null)
                {
                    model.lang_type = row["lang_type"].ToString();
                }
                if (row["agency_id"] != null && row["agency_id"].ToString() != "")
                {
                    model.agency_id = int.Parse(row["agency_id"].ToString());
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                if (row["todolist"] != null)
                {
                    model.todolist = row["todolist"].ToString();
                }
                if (row["role_id"] != null && row["role_id"].ToString() != "")
                {
                    model.role_id = int.Parse(row["role_id"].ToString());
                }
                if (row["admin_market_area"] != null)
                {
                    model.admin_market_area = row["admin_market_area"].ToString();
                }
                if (row["user_tel"] != null)
                {
                    model.user_tel = row["user_tel"].ToString();
                }
                if (row["user_qq"] != null)
                {
                    model.user_qq = row["user_qq"].ToString();
                }
                if (row["nickname"] != null)
                {
                    model.nickname = row["nickname"].ToString();
                }
                if (row["status"] != null && row["status"].ToString() != "")
                {
                    model.status = int.Parse(row["status"].ToString());
                }
                if (row["is_lockable"] != null && row["is_lockable"].ToString() != "")
                {
                    model.is_lockable = int.Parse(row["is_lockable"].ToString());
                }
                if (row["higher"] != null)
                {
                    model.higher = row["higher"].ToString();
                }
                if (row["unix_timestamp"] != null && row["unix_timestamp"].ToString() != "")
                {
                    model.unix_timestamp = int.Parse(row["unix_timestamp"].ToString());
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
            strSql.Append("select user_id,user_name,real_name,email,password,ec_salt,add_time,last_login,last_ip,points,action_list,nav_list,lang_type,agency_id,suppliers_id,todolist,role_id,admin_market_area,user_tel,user_qq,nickname,status,is_lockable,higher,unix_timestamp ");
            strSql.Append(" FROM ecs_admin_user ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetShopUserArea(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from ecs_market ");
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
            strSql.Append("select count(1) FROM ecs_admin_user ");
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
                strSql.Append("order by T.user_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_admin_user T ");
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
            parameters[0].Value = "ecs_admin_user";
            parameters[1].Value = "user_id";
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

