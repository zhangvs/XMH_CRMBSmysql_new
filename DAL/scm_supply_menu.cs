using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_supply_menu
    /// </summary>
    public partial class scm_supply_menu
    {
        public scm_supply_menu()
        { }
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Menu_id", "sys_menu");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Menu_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from sys_menu");
            strSql.Append(" where Menu_id=@Menu_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Menu_id", MySqlDbType.Int32,4)};
            parameters[0].Value = Menu_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.scm_supply_menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into sys_menu(");
            strSql.Append("Menu_name,parentid,parentname,App_id,Menu_url,Menu_icon,Menu_handler,Menu_order,Menu_type)");
            strSql.Append(" values (");
            strSql.Append("@Menu_name,@parentid,@parentname,@App_id,@Menu_url,@Menu_icon,@Menu_handler,@Menu_order,@Menu_type)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Menu_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@parentid", MySqlDbType.Int32,4),
					new MySqlParameter("@parentname", MySqlDbType.VarChar,255),
					new MySqlParameter("@App_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Menu_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@Menu_icon", MySqlDbType.VarChar,50),
					new MySqlParameter("@Menu_handler", MySqlDbType.VarChar,50),
					new MySqlParameter("@Menu_order", MySqlDbType.Int32,4),
					new MySqlParameter("@Menu_type", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.Menu_name;
            parameters[1].Value = model.parentid;
            parameters[2].Value = model.parentname;
            parameters[3].Value = model.App_id;
            parameters[4].Value = model.Menu_url;
            parameters[5].Value = model.Menu_icon;
            parameters[6].Value = model.Menu_handler;
            parameters[7].Value = model.Menu_order;
            parameters[8].Value = model.Menu_type;

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
        public bool Update(XHD.Model.scm_supply_menu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update sys_menu set ");
            strSql.Append("Menu_name=@Menu_name,");
            strSql.Append("parentid=@parentid,");
            strSql.Append("parentname=@parentname,");
            strSql.Append("App_id=@App_id,");
            strSql.Append("Menu_url=@Menu_url,");
            strSql.Append("Menu_icon=@Menu_icon,");
            strSql.Append("Menu_handler=@Menu_handler,");
            strSql.Append("Menu_order=@Menu_order,");
            strSql.Append("Menu_type=@Menu_type");
            strSql.Append(" where Menu_id=@Menu_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Menu_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@parentid", MySqlDbType.Int32,4),
					new MySqlParameter("@parentname", MySqlDbType.VarChar,255),
					new MySqlParameter("@App_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Menu_url", MySqlDbType.VarChar,255),
					new MySqlParameter("@Menu_icon", MySqlDbType.VarChar,50),
					new MySqlParameter("@Menu_handler", MySqlDbType.VarChar,50),
					new MySqlParameter("@Menu_order", MySqlDbType.Int32,4),
					new MySqlParameter("@Menu_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@Menu_id", MySqlDbType.Int32,4)};
            parameters[0].Value = model.Menu_name;
            parameters[1].Value = model.parentid;
            parameters[2].Value = model.parentname;
            parameters[3].Value = model.App_id;
            parameters[4].Value = model.Menu_url;
            parameters[5].Value = model.Menu_icon;
            parameters[6].Value = model.Menu_handler;
            parameters[7].Value = model.Menu_order;
            parameters[8].Value = model.Menu_type;
            parameters[9].Value = model.Menu_id;

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
            strSql.Append("update sys_menu set ");
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
        public bool Delete(int Menu_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from sys_menu ");
            strSql.Append(" where Menu_id=@Menu_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Menu_id", MySqlDbType.Int32,4)};
            parameters[0].Value = Menu_id;

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
        public bool DeleteList(string Menu_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from sys_menu ");
            strSql.Append(" where Menu_id in (" + Menu_idlist + ")  ");
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
        public XHD.Model.scm_supply_menu GetModel(int Menu_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select   Menu_id,Menu_name,parentid,parentname,App_id,Menu_url,Menu_icon,Menu_handler,Menu_order,Menu_type from sys_menu ");
            strSql.Append(" where Menu_id=@Menu_id  limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Menu_id", MySqlDbType.Int32,4)};
            parameters[0].Value = Menu_id;

            XHD.Model.scm_supply_menu model = new XHD.Model.scm_supply_menu();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Menu_id"] != null && ds.Tables[0].Rows[0]["Menu_id"].ToString() != "")
                {
                    model.Menu_id = int.Parse(ds.Tables[0].Rows[0]["Menu_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Menu_name"] != null && ds.Tables[0].Rows[0]["Menu_name"].ToString() != "")
                {
                    model.Menu_name = ds.Tables[0].Rows[0]["Menu_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["parentid"] != null && ds.Tables[0].Rows[0]["parentid"].ToString() != "")
                {
                    model.parentid = int.Parse(ds.Tables[0].Rows[0]["parentid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["parentname"] != null && ds.Tables[0].Rows[0]["parentname"].ToString() != "")
                {
                    model.parentname = ds.Tables[0].Rows[0]["parentname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["App_id"] != null && ds.Tables[0].Rows[0]["App_id"].ToString() != "")
                {
                    model.App_id = int.Parse(ds.Tables[0].Rows[0]["App_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Menu_url"] != null && ds.Tables[0].Rows[0]["Menu_url"].ToString() != "")
                {
                    model.Menu_url = ds.Tables[0].Rows[0]["Menu_url"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Menu_icon"] != null && ds.Tables[0].Rows[0]["Menu_icon"].ToString() != "")
                {
                    model.Menu_icon = ds.Tables[0].Rows[0]["Menu_icon"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Menu_handler"] != null && ds.Tables[0].Rows[0]["Menu_handler"].ToString() != "")
                {
                    model.Menu_handler = ds.Tables[0].Rows[0]["Menu_handler"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Menu_order"] != null && ds.Tables[0].Rows[0]["Menu_order"].ToString() != "")
                {
                    model.Menu_order = int.Parse(ds.Tables[0].Rows[0]["Menu_order"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Menu_type"] != null && ds.Tables[0].Rows[0]["Menu_type"].ToString() != "")
                {
                    model.Menu_type = ds.Tables[0].Rows[0]["Menu_type"].ToString();
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
            strSql.Append("select Menu_id,Menu_name,parentid,parentname,App_id,Menu_url,Menu_icon,Menu_handler,Menu_order,Menu_type ");
            strSql.Append(" FROM sys_menu ");
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

            strSql.Append(" Menu_id,Menu_name,parentid,parentname,App_id,Menu_url,Menu_icon,Menu_handler,Menu_order,Menu_type ");
            strSql.Append(" FROM sys_menu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得前几行数据 ==Robert 2015-11-26
        /// </summary>
        public DataSet GetListCRM(int Top, string strWhere, string filedOrder, string strEmp_id, string strFactoryId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Menu_id,Menu_name,parentid,parentname,App_id,Menu_url,Menu_icon,Menu_handler,Menu_order,Menu_type,");
            strSql.Append(@" CASE WHEN Menu_name = '我的客户列表' THEN  (select count(1) from crm_customer where BeSeats_id='" + strEmp_id);

            strSql.Append("' and Factory_Id='" + strFactoryId + "' and privatecustomer='私客' and isDelete=0 ) ");//lastfollow<date_add(now(),interval -1 month))
            strSql.Append(@" WHEN Menu_name = '我的客户' THEN  (select count(1) from crm_customer where BeSeats_id='" + strEmp_id + @"' and Factory_Id='" + strFactoryId + @"' and privatecustomer='私客' and isDelete=0 ) 
                             WHEN Menu_name = '3天未联系' THEN  (select count(1) from crm_customer where BeSeats_id='" + strEmp_id + @"' and Factory_Id='" + strFactoryId + @"' and privatecustomer='私客' and isDelete=0  and lastfollow<date_add(now(),interval -3 day))
                             WHEN Menu_name = '7天未联系' THEN  (select count(1) from crm_customer where BeSeats_id='" + strEmp_id + @"' and Factory_Id='" + strFactoryId + @"' and privatecustomer='私客' and isDelete=0  and lastfollow<date_add(now(),interval -1 week))
                             WHEN Menu_name = '14天未联系' THEN  (select count(1) from crm_customer where BeSeats_id='" + strEmp_id + @"' and Factory_Id='" + strFactoryId + @"' and privatecustomer='私客' and isDelete=0  and lastfollow<date_add(now(),interval -2 week))
                             WHEN Menu_name = '本月未联系' THEN  (select count(1) from crm_customer where BeSeats_id='" + strEmp_id + @"' and Factory_Id='" + strFactoryId + @"' and privatecustomer='私客' and isDelete=0  and lastfollow<DATE_ADD(curdate(),interval -day(curdate())+1 day))
                            End as  count1");

            strSql.Append(" FROM sys_menu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
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
            strSql.Append("  * FROM sys_menu ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM scm_supply_menu ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM sys_menu ");
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

