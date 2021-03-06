﻿using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:dms_team_bonusDAO
    /// </summary>
    public partial class dms_team_bonusDAO
    {
        public dms_team_bonusDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dms_team_bonus");
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
        public bool Add(XHD.Model.dms_team_bonus model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dms_team_bonus(");
            strSql.Append("year,monthnode,d_pid,d_pname,salemoney_team,backmoney_team,realmoney_team,plan_team,base_team,cha_team,wcl_team,team_bonus,team_champion,create_time,create_name)");
            strSql.Append(" values (");
            strSql.Append("@year,@monthnode,@d_pid,@d_pname,@salemoney_team,@backmoney_team,@realmoney_team,@plan_team,@base_team,@cha_team,@wcl_team,@team_bonus,@team_champion,@create_time,@create_name)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@year", MySqlDbType.VarChar,4),
					new MySqlParameter("@monthnode", MySqlDbType.VarChar,4),
					new MySqlParameter("@d_pid", MySqlDbType.VarChar,10),
					new MySqlParameter("@d_pname", MySqlDbType.VarChar,60),
					new MySqlParameter("@salemoney_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@backmoney_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@realmoney_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@plan_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@base_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@cha_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@wcl_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@team_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@team_champion", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,60)};
            parameters[0].Value = model.year;
            parameters[1].Value = model.monthnode;
            parameters[2].Value = model.d_pid;
            parameters[3].Value = model.d_pname;
            parameters[4].Value = model.salemoney_team;
            parameters[5].Value = model.backmoney_team;
            parameters[6].Value = model.realmoney_team;
            parameters[7].Value = model.plan_team;
            parameters[8].Value = model.base_team;
            parameters[9].Value = model.cha_team;
            parameters[10].Value = model.wcl_team;
            parameters[11].Value = model.team_bonus;
            parameters[12].Value = model.team_champion;
            parameters[13].Value = model.create_time;
            parameters[14].Value = model.create_name;

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
        public bool Update(XHD.Model.dms_team_bonus model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_team_bonus set ");
            strSql.Append("year=@year,");
            strSql.Append("monthnode=@monthnode,");
            strSql.Append("d_pid=@d_pid,");
            strSql.Append("d_pname=@d_pname,");
            strSql.Append("salemoney_team=@salemoney_team,");
            strSql.Append("backmoney_team=@backmoney_team,");
            strSql.Append("realmoney_team=@realmoney_team,");
            strSql.Append("plan_team=@plan_team,");
            strSql.Append("base_team=@base_team,");
            strSql.Append("cha_team=@cha_team,");
            strSql.Append("wcl_team=@wcl_team,");
            strSql.Append("team_bonus=@team_bonus,");
            strSql.Append("team_champion=@team_champion,");
            strSql.Append("create_time=@create_time,");
            strSql.Append("create_name=@create_name");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@year", MySqlDbType.VarChar,4),
					new MySqlParameter("@monthnode", MySqlDbType.VarChar,4),
					new MySqlParameter("@d_pid", MySqlDbType.VarChar,10),
					new MySqlParameter("@d_pname", MySqlDbType.VarChar,60),
					new MySqlParameter("@salemoney_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@backmoney_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@realmoney_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@plan_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@base_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@cha_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@wcl_team", MySqlDbType.Decimal,18),
					new MySqlParameter("@team_bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@team_champion", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.year;
            parameters[1].Value = model.monthnode;
            parameters[2].Value = model.d_pid;
            parameters[3].Value = model.d_pname;
            parameters[4].Value = model.salemoney_team;
            parameters[5].Value = model.backmoney_team;
            parameters[6].Value = model.realmoney_team;
            parameters[7].Value = model.plan_team;
            parameters[8].Value = model.base_team;
            parameters[9].Value = model.cha_team;
            parameters[10].Value = model.wcl_team;
            parameters[11].Value = model.team_bonus;
            parameters[12].Value = model.team_champion;
            parameters[13].Value = model.create_time;
            parameters[14].Value = model.create_name;
            parameters[15].Value = model.id;

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
            strSql.Append("delete from dms_team_bonus ");
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
            strSql.Append("delete from dms_team_bonus ");
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
        public XHD.Model.dms_team_bonus GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,year,monthnode,d_pid,d_pname,salemoney_team,backmoney_team,realmoney_team,plan_team,base_team,cha_team,wcl_team,team_bonus,team_champion,create_time,create_name from dms_team_bonus ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.dms_team_bonus model = new XHD.Model.dms_team_bonus();
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
        public XHD.Model.dms_team_bonus DataRowToModel(DataRow row)
        {
            XHD.Model.dms_team_bonus model = new XHD.Model.dms_team_bonus();
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
                if (row["d_pid"] != null)
                {
                    model.d_pid = row["d_pid"].ToString();
                }
                if (row["d_pname"] != null)
                {
                    model.d_pname = row["d_pname"].ToString();
                }
                if (row["salemoney_team"] != null && row["salemoney_team"].ToString() != "")
                {
                    model.salemoney_team = decimal.Parse(row["salemoney_team"].ToString());
                }
                if (row["backmoney_team"] != null && row["backmoney_team"].ToString() != "")
                {
                    model.backmoney_team = decimal.Parse(row["backmoney_team"].ToString());
                }
                if (row["realmoney_team"] != null && row["realmoney_team"].ToString() != "")
                {
                    model.realmoney_team = decimal.Parse(row["realmoney_team"].ToString());
                }
                if (row["plan_team"] != null && row["plan_team"].ToString() != "")
                {
                    model.plan_team = decimal.Parse(row["plan_team"].ToString());
                }
                if (row["base_team"] != null && row["base_team"].ToString() != "")
                {
                    model.base_team = decimal.Parse(row["base_team"].ToString());
                }
                if (row["cha_team"] != null && row["cha_team"].ToString() != "")
                {
                    model.cha_team = decimal.Parse(row["cha_team"].ToString());
                }
                if (row["wcl_team"] != null && row["wcl_team"].ToString() != "")
                {
                    model.wcl_team = decimal.Parse(row["wcl_team"].ToString());
                }
                if (row["team_bonus"] != null && row["team_bonus"].ToString() != "")
                {
                    model.team_bonus = decimal.Parse(row["team_bonus"].ToString());
                }
                if (row["team_champion"] != null && row["team_champion"].ToString() != "")
                {
                    model.team_champion = decimal.Parse(row["team_champion"].ToString());
                }
                if (row["create_time"] != null && row["create_time"].ToString() != "")
                {
                    model.create_time = DateTime.Parse(row["create_time"].ToString());
                }
                if (row["create_name"] != null)
                {
                    model.create_name = row["create_name"].ToString();
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
            strSql.Append("select id,year,monthnode,d_pid,d_pname,salemoney_team,backmoney_team,realmoney_team,plan_team,base_team,cha_team,wcl_team,team_bonus,team_champion,create_time,create_name ");
            strSql.Append(" FROM dms_team_bonus ");
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
            strSql.Append("select count(1) FROM dms_team_bonus ");
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
            strSql.Append(")AS Row, T.*  from dms_team_bonus T ");
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
            parameters[0].Value = "dms_team_bonus";
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
        /// 获得数据列表
        /// </summary>
        public DataSet Sum_Champion_Bonus(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum(team_bonus)+sum(team_champion) sum_champion_bonus ");
            strSql.Append(" FROM dms_team_bonus ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteBySql(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dms_team_bonus ");
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

