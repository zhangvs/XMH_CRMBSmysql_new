using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_set_bonusDAO
    /// </summary>
    public partial class ecs_set_bonusDAO
    {
        public ecs_set_bonusDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_set_bonus");
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
        public bool Add(XHD.Model.ecs_set_bonus model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_set_bonus(");
            strSql.Append("one_bonus,two_bonus,three_bonus,four_bonus,week_one_bonus,week_two_bonus,week_three_bonus,week_four_bonus,month_bonus,team_one_bonus,team_two_bonus,team_three_bonus,team_four_bonus,team_month_bonus,team_dabiao,team_dabiao2)");
            strSql.Append(" values (");
            strSql.Append("@one_bonus,@two_bonus,@three_bonus,@four_bonus,@week_one_bonus,@week_two_bonus,@week_three_bonus,@week_four_bonus,@month_bonus,@team_one_bonus,@team_two_bonus,@team_three_bonus,@team_four_bonus,@team_month_bonus,@team_dabiao,@team_dabiao2)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@one_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@two_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@three_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@four_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@week_one_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@week_two_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@week_three_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@week_four_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@month_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_one_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_two_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_three_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_four_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_month_bonus", MySqlDbType.Decimal,10),
					new MySqlParameter("@team_dabiao", MySqlDbType.Text),
					new MySqlParameter("@team_dabiao2", MySqlDbType.Text)};
            parameters[0].Value = model.one_bonus;
            parameters[1].Value = model.two_bonus;
            parameters[2].Value = model.three_bonus;
            parameters[3].Value = model.four_bonus;
            parameters[4].Value = model.week_one_bonus;
            parameters[5].Value = model.week_two_bonus;
            parameters[6].Value = model.week_three_bonus;
            parameters[7].Value = model.week_four_bonus;
            parameters[8].Value = model.month_bonus;
            parameters[9].Value = model.team_one_bonus;
            parameters[10].Value = model.team_two_bonus;
            parameters[11].Value = model.team_three_bonus;
            parameters[12].Value = model.team_four_bonus;
            parameters[13].Value = model.team_month_bonus;
            parameters[14].Value = model.team_dabiao;
            parameters[15].Value = model.team_dabiao2;

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
        public bool Update(XHD.Model.ecs_set_bonus model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_set_bonus set ");
            strSql.Append("one_bonus=@one_bonus,");
            strSql.Append("two_bonus=@two_bonus,");
            strSql.Append("three_bonus=@three_bonus,");
            strSql.Append("four_bonus=@four_bonus,");
            strSql.Append("week_one_bonus=@week_one_bonus,");
            strSql.Append("week_two_bonus=@week_two_bonus,");
            strSql.Append("week_three_bonus=@week_three_bonus,");
            strSql.Append("week_four_bonus=@week_four_bonus,");
            strSql.Append("month_bonus=@month_bonus,");
            strSql.Append("team_one_bonus=@team_one_bonus,");
            strSql.Append("team_two_bonus=@team_two_bonus,");
            strSql.Append("team_three_bonus=@team_three_bonus,");
            strSql.Append("team_four_bonus=@team_four_bonus,");
            strSql.Append("team_month_bonus=@team_month_bonus,");
            strSql.Append("team_dabiao=@team_dabiao,");
            strSql.Append("team_dabiao2=@team_dabiao2");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@one_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@two_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@three_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@four_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@week_one_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@week_two_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@week_three_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@week_four_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@month_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_one_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_two_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_three_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_four_bonus", MySqlDbType.Int32,10),
					new MySqlParameter("@team_month_bonus", MySqlDbType.Decimal,10),
					new MySqlParameter("@team_dabiao", MySqlDbType.Text),
					new MySqlParameter("@team_dabiao2", MySqlDbType.Text),
					new MySqlParameter("@id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.one_bonus;
            parameters[1].Value = model.two_bonus;
            parameters[2].Value = model.three_bonus;
            parameters[3].Value = model.four_bonus;
            parameters[4].Value = model.week_one_bonus;
            parameters[5].Value = model.week_two_bonus;
            parameters[6].Value = model.week_three_bonus;
            parameters[7].Value = model.week_four_bonus;
            parameters[8].Value = model.month_bonus;
            parameters[9].Value = model.team_one_bonus;
            parameters[10].Value = model.team_two_bonus;
            parameters[11].Value = model.team_three_bonus;
            parameters[12].Value = model.team_four_bonus;
            parameters[13].Value = model.team_month_bonus;
            parameters[14].Value = model.team_dabiao;
            parameters[15].Value = model.team_dabiao2;
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
            strSql.Append("delete from ecs_set_bonus ");
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
            strSql.Append("delete from ecs_set_bonus ");
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
        public XHD.Model.ecs_set_bonus GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,one_bonus,two_bonus,three_bonus,four_bonus,week_one_bonus,week_two_bonus,week_three_bonus,week_four_bonus,month_bonus,team_one_bonus,team_two_bonus,team_three_bonus,team_four_bonus,team_month_bonus,team_dabiao,team_dabiao2 from ecs_set_bonus ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.ecs_set_bonus model = new XHD.Model.ecs_set_bonus();
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
        public XHD.Model.ecs_set_bonus DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_set_bonus model = new XHD.Model.ecs_set_bonus();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["one_bonus"] != null && row["one_bonus"].ToString() != "")
                {
                    model.one_bonus = int.Parse(row["one_bonus"].ToString());
                }
                if (row["two_bonus"] != null && row["two_bonus"].ToString() != "")
                {
                    model.two_bonus = int.Parse(row["two_bonus"].ToString());
                }
                if (row["three_bonus"] != null && row["three_bonus"].ToString() != "")
                {
                    model.three_bonus = int.Parse(row["three_bonus"].ToString());
                }
                if (row["four_bonus"] != null && row["four_bonus"].ToString() != "")
                {
                    model.four_bonus = int.Parse(row["four_bonus"].ToString());
                }
                if (row["week_one_bonus"] != null && row["week_one_bonus"].ToString() != "")
                {
                    model.week_one_bonus = int.Parse(row["week_one_bonus"].ToString());
                }
                if (row["week_two_bonus"] != null && row["week_two_bonus"].ToString() != "")
                {
                    model.week_two_bonus = int.Parse(row["week_two_bonus"].ToString());
                }
                if (row["week_three_bonus"] != null && row["week_three_bonus"].ToString() != "")
                {
                    model.week_three_bonus = int.Parse(row["week_three_bonus"].ToString());
                }
                if (row["week_four_bonus"] != null && row["week_four_bonus"].ToString() != "")
                {
                    model.week_four_bonus = int.Parse(row["week_four_bonus"].ToString());
                }
                if (row["month_bonus"] != null && row["month_bonus"].ToString() != "")
                {
                    model.month_bonus = int.Parse(row["month_bonus"].ToString());
                }
                if (row["team_one_bonus"] != null && row["team_one_bonus"].ToString() != "")
                {
                    model.team_one_bonus = int.Parse(row["team_one_bonus"].ToString());
                }
                if (row["team_two_bonus"] != null && row["team_two_bonus"].ToString() != "")
                {
                    model.team_two_bonus = int.Parse(row["team_two_bonus"].ToString());
                }
                if (row["team_three_bonus"] != null && row["team_three_bonus"].ToString() != "")
                {
                    model.team_three_bonus = int.Parse(row["team_three_bonus"].ToString());
                }
                if (row["team_four_bonus"] != null && row["team_four_bonus"].ToString() != "")
                {
                    model.team_four_bonus = int.Parse(row["team_four_bonus"].ToString());
                }
                if (row["team_month_bonus"] != null && row["team_month_bonus"].ToString() != "")
                {
                    model.team_month_bonus = decimal.Parse(row["team_month_bonus"].ToString());
                }
                if (row["team_dabiao"] != null)
                {
                    model.team_dabiao = row["team_dabiao"].ToString();
                }
                if (row["team_dabiao2"] != null)
                {
                    model.team_dabiao2 = row["team_dabiao2"].ToString();
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
            strSql.Append("select id,one_bonus,two_bonus,three_bonus,four_bonus,week_one_bonus,week_two_bonus,week_three_bonus,week_four_bonus,month_bonus,team_one_bonus,team_two_bonus,team_three_bonus,team_four_bonus,team_month_bonus,team_dabiao,team_dabiao2 ");
            strSql.Append(" FROM ecs_set_bonus ");
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
            strSql.Append("select count(1) FROM ecs_set_bonus ");
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
            strSql.Append(")AS Row, T.*  from ecs_set_bonus T ");
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
            parameters[0].Value = "ecs_set_bonus";
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

