using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_set_nodeDAO
    /// </summary>
    public partial class ecs_set_nodeDAO
    {
        public ecs_set_nodeDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int node_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_set_node");
            strSql.Append(" where node_id=@node_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@node_id", MySqlDbType.Int32)
			};
            parameters[0].Value = node_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_set_node model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_set_node(");
            strSql.Append("node_year,node_month,node_one1,node_one2,node_two1,node_two2,node_three1,node_three2,node_four1,node_four2,telnum1,telnum2,telnum3,telnum4)");
            strSql.Append(" values (");
            strSql.Append("@node_year,@node_month,@node_one1,@node_one2,@node_two1,@node_two2,@node_three1,@node_three2,@node_four1,@node_four2,@telnum1,@telnum2,@telnum3,@telnum4)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@node_year", MySqlDbType.Int32,4),
					new MySqlParameter("@node_month", MySqlDbType.Int32,2),
					new MySqlParameter("@node_one1", MySqlDbType.Int32,2),
					new MySqlParameter("@node_one2", MySqlDbType.Int32,2),
					new MySqlParameter("@node_two1", MySqlDbType.Int32,2),
					new MySqlParameter("@node_two2", MySqlDbType.Int32,2),
					new MySqlParameter("@node_three1", MySqlDbType.Int32,2),
					new MySqlParameter("@node_three2", MySqlDbType.Int32,2),
					new MySqlParameter("@node_four1", MySqlDbType.Int32,2),
					new MySqlParameter("@node_four2", MySqlDbType.Int32,2),
					new MySqlParameter("@telnum1", MySqlDbType.Int32,10),
					new MySqlParameter("@telnum2", MySqlDbType.Int32,10),
					new MySqlParameter("@telnum3", MySqlDbType.Int32,10),
					new MySqlParameter("@telnum4", MySqlDbType.Int32,10)};
            parameters[0].Value = model.node_year;
            parameters[1].Value = model.node_month;
            parameters[2].Value = model.node_one1;
            parameters[3].Value = model.node_one2;
            parameters[4].Value = model.node_two1;
            parameters[5].Value = model.node_two2;
            parameters[6].Value = model.node_three1;
            parameters[7].Value = model.node_three2;
            parameters[8].Value = model.node_four1;
            parameters[9].Value = model.node_four2;
            parameters[10].Value = model.telnum1;
            parameters[11].Value = model.telnum2;
            parameters[12].Value = model.telnum3;
            parameters[13].Value = model.telnum4;

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
        public bool Update(XHD.Model.ecs_set_node model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_set_node set ");
            strSql.Append("node_year=@node_year,");
            strSql.Append("node_month=@node_month,");
            strSql.Append("node_one1=@node_one1,");
            strSql.Append("node_one2=@node_one2,");
            strSql.Append("node_two1=@node_two1,");
            strSql.Append("node_two2=@node_two2,");
            strSql.Append("node_three1=@node_three1,");
            strSql.Append("node_three2=@node_three2,");
            strSql.Append("node_four1=@node_four1,");
            strSql.Append("node_four2=@node_four2,");
            strSql.Append("telnum1=@telnum1,");
            strSql.Append("telnum2=@telnum2,");
            strSql.Append("telnum3=@telnum3,");
            strSql.Append("telnum4=@telnum4");
            strSql.Append(" where node_id=@node_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@node_year", MySqlDbType.Int32,4),
					new MySqlParameter("@node_month", MySqlDbType.Int32,2),
					new MySqlParameter("@node_one1", MySqlDbType.Int32,2),
					new MySqlParameter("@node_one2", MySqlDbType.Int32,2),
					new MySqlParameter("@node_two1", MySqlDbType.Int32,2),
					new MySqlParameter("@node_two2", MySqlDbType.Int32,2),
					new MySqlParameter("@node_three1", MySqlDbType.Int32,2),
					new MySqlParameter("@node_three2", MySqlDbType.Int32,2),
					new MySqlParameter("@node_four1", MySqlDbType.Int32,2),
					new MySqlParameter("@node_four2", MySqlDbType.Int32,2),
					new MySqlParameter("@telnum1", MySqlDbType.Int32,10),
					new MySqlParameter("@telnum2", MySqlDbType.Int32,10),
					new MySqlParameter("@telnum3", MySqlDbType.Int32,10),
					new MySqlParameter("@telnum4", MySqlDbType.Int32,10),
					new MySqlParameter("@node_id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.node_year;
            parameters[1].Value = model.node_month;
            parameters[2].Value = model.node_one1;
            parameters[3].Value = model.node_one2;
            parameters[4].Value = model.node_two1;
            parameters[5].Value = model.node_two2;
            parameters[6].Value = model.node_three1;
            parameters[7].Value = model.node_three2;
            parameters[8].Value = model.node_four1;
            parameters[9].Value = model.node_four2;
            parameters[10].Value = model.telnum1;
            parameters[11].Value = model.telnum2;
            parameters[12].Value = model.telnum3;
            parameters[13].Value = model.telnum4;
            parameters[14].Value = model.node_id;

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
        public bool Delete(int node_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_set_node ");
            strSql.Append(" where node_id=@node_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@node_id", MySqlDbType.Int32)
			};
            parameters[0].Value = node_id;

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
        public bool DeleteList(string node_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_set_node ");
            strSql.Append(" where node_id in (" + node_idlist + ")  ");
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
        public XHD.Model.ecs_set_node GetModel(int node_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select node_id,node_year,node_month,node_one1,node_one2,node_two1,node_two2,node_three1,node_three2,node_four1,node_four2,telnum1,telnum2,telnum3,telnum4 from ecs_set_node ");
            strSql.Append(" where node_id=@node_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@node_id", MySqlDbType.Int32)
			};
            parameters[0].Value = node_id;

            XHD.Model.ecs_set_node model = new XHD.Model.ecs_set_node();
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
        public XHD.Model.ecs_set_node DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_set_node model = new XHD.Model.ecs_set_node();
            if (row != null)
            {
                if (row["node_id"] != null && row["node_id"].ToString() != "")
                {
                    model.node_id = int.Parse(row["node_id"].ToString());
                }
                if (row["node_year"] != null && row["node_year"].ToString() != "")
                {
                    model.node_year = int.Parse(row["node_year"].ToString());
                }
                if (row["node_month"] != null && row["node_month"].ToString() != "")
                {
                    model.node_month = int.Parse(row["node_month"].ToString());
                }
                if (row["node_one1"] != null && row["node_one1"].ToString() != "")
                {
                    model.node_one1 = int.Parse(row["node_one1"].ToString());
                }
                if (row["node_one2"] != null && row["node_one2"].ToString() != "")
                {
                    model.node_one2 = int.Parse(row["node_one2"].ToString());
                }
                if (row["node_two1"] != null && row["node_two1"].ToString() != "")
                {
                    model.node_two1 = int.Parse(row["node_two1"].ToString());
                }
                if (row["node_two2"] != null && row["node_two2"].ToString() != "")
                {
                    model.node_two2 = int.Parse(row["node_two2"].ToString());
                }
                if (row["node_three1"] != null && row["node_three1"].ToString() != "")
                {
                    model.node_three1 = int.Parse(row["node_three1"].ToString());
                }
                if (row["node_three2"] != null && row["node_three2"].ToString() != "")
                {
                    model.node_three2 = int.Parse(row["node_three2"].ToString());
                }
                if (row["node_four1"] != null && row["node_four1"].ToString() != "")
                {
                    model.node_four1 = int.Parse(row["node_four1"].ToString());
                }
                if (row["node_four2"] != null && row["node_four2"].ToString() != "")
                {
                    model.node_four2 = int.Parse(row["node_four2"].ToString());
                }
                if (row["telnum1"] != null && row["telnum1"].ToString() != "")
                {
                    model.telnum1 = int.Parse(row["telnum1"].ToString());
                }
                if (row["telnum2"] != null && row["telnum2"].ToString() != "")
                {
                    model.telnum2 = int.Parse(row["telnum2"].ToString());
                }
                if (row["telnum3"] != null && row["telnum3"].ToString() != "")
                {
                    model.telnum3 = int.Parse(row["telnum3"].ToString());
                }
                if (row["telnum4"] != null && row["telnum4"].ToString() != "")
                {
                    model.telnum4 = int.Parse(row["telnum4"].ToString());
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
            strSql.Append("select node_id,node_year,node_month,node_one1,node_one2,node_two1,node_two2,node_three1,node_three2,node_four1,node_four2,telnum1,telnum2,telnum3,telnum4 ");
            strSql.Append(" FROM ecs_set_node ");
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
            strSql.Append("select count(1) FROM ecs_set_node ");
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
                strSql.Append("order by T.node_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_set_node T ");
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
            parameters[0].Value = "ecs_set_node";
            parameters[1].Value = "node_id";
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

