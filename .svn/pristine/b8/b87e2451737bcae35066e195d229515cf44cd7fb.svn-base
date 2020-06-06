using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:dms_monthnode_saleDAO
    /// </summary>
    public partial class dms_monthnode_saleDAO
    {
        public dms_monthnode_saleDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dms_monthnode_sale");
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
        public bool Add(XHD.Model.dms_monthnode_sale model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dms_monthnode_sale(");
            strSql.Append("year,monthnode,admin_user_name,name,d_pid,d_pname,salemoney_personal,backmoney_personal,realmoney_personal,base_personal,plan_personal,cha_personal,wcl_personal,personal_bonus,personal_champion,create_time)");
            strSql.Append(" values (");
            strSql.Append("@year,@monthnode,@admin_user_name,@name,@d_pid,@d_pname,@salemoney_personal,@backmoney_personal,@realmoney_personal,@base_personal,@plan_personal,@cha_personal,@wcl_personal,@personal_bonus,@personal_champion,@create_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@year", MySqlDbType.VarChar,4),
					new MySqlParameter("@monthnode", MySqlDbType.VarChar,4),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@name", MySqlDbType.VarChar,60),
					new MySqlParameter("@d_pid", MySqlDbType.VarChar,20),
					new MySqlParameter("@d_pname", MySqlDbType.VarChar,60),
					new MySqlParameter("@salemoney_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@backmoney_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@realmoney_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@base_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@plan_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@cha_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@wcl_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime)};
            parameters[0].Value = model.year;
            parameters[1].Value = model.monthnode;
            parameters[2].Value = model.admin_user_name;
            parameters[3].Value = model.name;
            parameters[4].Value = model.d_pid;
            parameters[5].Value = model.d_pname;
            parameters[6].Value = model.salemoney_personal;
            parameters[7].Value = model.backmoney_personal;
            parameters[8].Value = model.realmoney_personal;
            parameters[9].Value = model.base_personal;
            parameters[10].Value = model.plan_personal;
            parameters[11].Value = model.cha_personal;
            parameters[12].Value = model.wcl_personal;
            parameters[13].Value = model.personal_bonus;
            parameters[14].Value = model.personal_champion;
            parameters[15].Value = model.create_time;

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
        public bool Update(XHD.Model.dms_monthnode_sale model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_monthnode_sale set ");
            strSql.Append("year=@year,");
            strSql.Append("monthnode=@monthnode,");
            strSql.Append("admin_user_name=@admin_user_name,");
            strSql.Append("name=@name,");
            strSql.Append("d_pid=@d_pid,");
            strSql.Append("d_pname=@d_pname,");
            strSql.Append("salemoney_personal=@salemoney_personal,");
            strSql.Append("backmoney_personal=@backmoney_personal,");
            strSql.Append("realmoney_personal=@realmoney_personal,");
            strSql.Append("base_personal=@base_personal,");
            strSql.Append("plan_personal=@plan_personal,");
            strSql.Append("cha_personal=@cha_personal,");
            strSql.Append("wcl_personal=@wcl_personal,");
            strSql.Append("personal_bonus=@personal_bonus,");
            strSql.Append("personal_champion=@personal_champion,");
            strSql.Append("create_time=@create_time");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@year", MySqlDbType.VarChar,4),
					new MySqlParameter("@monthnode", MySqlDbType.VarChar,4),
					new MySqlParameter("@admin_user_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@name", MySqlDbType.VarChar,60),
					new MySqlParameter("@d_pid", MySqlDbType.VarChar,20),
					new MySqlParameter("@d_pname", MySqlDbType.VarChar,60),
					new MySqlParameter("@salemoney_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@backmoney_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@realmoney_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@base_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@plan_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@cha_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@wcl_personal", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@personal_champion", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.year;
            parameters[1].Value = model.monthnode;
            parameters[2].Value = model.admin_user_name;
            parameters[3].Value = model.name;
            parameters[4].Value = model.d_pid;
            parameters[5].Value = model.d_pname;
            parameters[6].Value = model.salemoney_personal;
            parameters[7].Value = model.backmoney_personal;
            parameters[8].Value = model.realmoney_personal;
            parameters[9].Value = model.base_personal;
            parameters[10].Value = model.plan_personal;
            parameters[11].Value = model.cha_personal;
            parameters[12].Value = model.wcl_personal;
            parameters[13].Value = model.personal_bonus;
            parameters[14].Value = model.personal_champion;
            parameters[15].Value = model.create_time;
            parameters[16].Value = model.id;

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
            strSql.Append("delete from dms_monthnode_sale ");
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
            strSql.Append("delete from dms_monthnode_sale ");
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
        public XHD.Model.dms_monthnode_sale GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,year,monthnode,admin_user_name,name,d_pid,d_pname,salemoney_personal,backmoney_personal,realmoney_personal,base_personal,plan_personal,cha_personal,wcl_personal,personal_bonus,personal_champion,create_time from dms_monthnode_sale ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.dms_monthnode_sale model = new XHD.Model.dms_monthnode_sale();
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
        public XHD.Model.dms_monthnode_sale DataRowToModel(DataRow row)
        {
            XHD.Model.dms_monthnode_sale model = new XHD.Model.dms_monthnode_sale();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["year"] != null)
                {
                    model.year = row["year"].ToString();
                }
                if (row["monthnode"] != null)
                {
                    model.monthnode = row["monthnode"].ToString();
                }
                if (row["admin_user_name"] != null)
                {
                    model.admin_user_name = row["admin_user_name"].ToString();
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["d_pid"] != null)
                {
                    model.d_pid = row["d_pid"].ToString();
                }
                if (row["d_pname"] != null)
                {
                    model.d_pname = row["d_pname"].ToString();
                }
                if (row["salemoney_personal"] != null && row["salemoney_personal"].ToString() != "")
                {
                    model.salemoney_personal = decimal.Parse(row["salemoney_personal"].ToString());
                }
                if (row["backmoney_personal"] != null && row["backmoney_personal"].ToString() != "")
                {
                    model.backmoney_personal = decimal.Parse(row["backmoney_personal"].ToString());
                }
                if (row["realmoney_personal"] != null && row["realmoney_personal"].ToString() != "")
                {
                    model.realmoney_personal = decimal.Parse(row["realmoney_personal"].ToString());
                }
                if (row["base_personal"] != null && row["base_personal"].ToString() != "")
                {
                    model.base_personal = decimal.Parse(row["base_personal"].ToString());
                }
                if (row["plan_personal"] != null && row["plan_personal"].ToString() != "")
                {
                    model.plan_personal = decimal.Parse(row["plan_personal"].ToString());
                }
                if (row["cha_personal"] != null && row["cha_personal"].ToString() != "")
                {
                    model.cha_personal = decimal.Parse(row["cha_personal"].ToString());
                }
                if (row["wcl_personal"] != null && row["wcl_personal"].ToString() != "")
                {
                    model.wcl_personal = decimal.Parse(row["wcl_personal"].ToString());
                }
                if (row["personal_bonus"] != null && row["personal_bonus"].ToString() != "")
                {
                    model.personal_bonus = decimal.Parse(row["personal_bonus"].ToString());
                }
                if (row["personal_champion"] != null && row["personal_champion"].ToString() != "")
                {
                    model.personal_champion = decimal.Parse(row["personal_champion"].ToString());
                }
                if (row["create_time"] != null && row["create_time"].ToString() != "")
                {
                    model.create_time = DateTime.Parse(row["create_time"].ToString());
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
            strSql.Append("select id,year,monthnode,admin_user_name,name,d_pid,d_pname,salemoney_personal,backmoney_personal,realmoney_personal,base_personal,plan_personal,cha_personal,wcl_personal,personal_bonus,personal_champion,create_time ");
            strSql.Append(" FROM dms_monthnode_sale ");
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
            strSql.Append("select count(1) FROM dms_monthnode_sale ");
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
            strSql.Append(")AS Row, T.*  from dms_monthnode_sale T ");
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
            parameters[0].Value = "dms_monthnode_sale";
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
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteBySql(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dms_monthnode_sale ");
            strSql.Append(" where " + sqlWhere);
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
        #endregion  ExtensionMethod
    }
}

