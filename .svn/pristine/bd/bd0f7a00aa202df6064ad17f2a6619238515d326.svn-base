using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:Param_Area
    /// </summary>
    public partial class Param_Area
    {
        public Param_Area()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("region_id", "Param_Area");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int region_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Param_Area");
            strSql.Append(" where region_id=@region_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@region_id", MySqlDbType.Int32,4)			};
            parameters[0].Value = region_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.Param_Area model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Param_Area(");
            strSql.Append("region_id,parent_id,region_name,region_type,region_order)");
            strSql.Append(" values (");
            strSql.Append("@region_id,@parent_id,@region_name,@region_type,@region_order)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@region_id", MySqlDbType.Int32,4),
					new MySqlParameter("@parent_id", MySqlDbType.Int32,4),
					new MySqlParameter("@region_name", MySqlDbType.VarString,50),
					new MySqlParameter("@region_type", MySqlDbType.Int32,4),
					new MySqlParameter("@region_order", MySqlDbType.Int32,4)};
            parameters[0].Value = model.region_id;
            parameters[1].Value = model.parent_id;
            parameters[2].Value = model.region_name;
            parameters[3].Value = model.region_type;
            parameters[4].Value = model.region_order;

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
        public bool Update(XHD.Model.Param_Area model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Param_Area set ");
            strSql.Append("parent_id=@parent_id,");
            strSql.Append("region_name=@region_name,");
            strSql.Append("region_type=@region_type,");
            strSql.Append("region_order=@region_order");
            strSql.Append(" where region_id=@region_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@parent_id", MySqlDbType.Int32,4),
					new MySqlParameter("@region_name", MySqlDbType.VarString,50),
					new MySqlParameter("@region_type", MySqlDbType.Int32,4),
					new MySqlParameter("@region_order", MySqlDbType.Int32,4),
					new MySqlParameter("@region_id", MySqlDbType.Int32,4)};
            parameters[0].Value = model.parent_id;
            parameters[1].Value = model.region_name;
            parameters[2].Value = model.region_type;
            parameters[3].Value = model.region_order;
            parameters[4].Value = model.region_id;

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
        public bool Delete(int region_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Param_Area ");
            strSql.Append(" where region_id=@region_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@region_id", MySqlDbType.Int32,4)			};
            parameters[0].Value = region_id;

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
        public bool DeleteList(string region_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Param_Area ");
            strSql.Append(" where region_id in (" + region_idlist + ")  ");
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
        public XHD.Model.Param_Area GetModel(int region_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select region_id,parent_id,region_name,region_type,region_order from Param_Area ");
            strSql.Append(" where region_id=@region_id limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@region_id", MySqlDbType.Int32,4)			};
            parameters[0].Value = region_id;

            XHD.Model.Param_Area model = new XHD.Model.Param_Area();
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
        public XHD.Model.Param_Area DataRowToModel(DataRow row)
        {
            XHD.Model.Param_Area model = new XHD.Model.Param_Area();
            if (row != null)
            {
                if (row["region_id"] != null && row["region_id"].ToString() != "")
                {
                    model.region_id = int.Parse(row["region_id"].ToString());
                }
                if (row["parent_id"] != null && row["parent_id"].ToString() != "")
                {
                    model.parent_id = int.Parse(row["parent_id"].ToString());
                }
                if (row["region_name"] != null)
                {
                    model.region_name = row["region_name"].ToString();
                }
                if (row["region_type"] != null && row["region_type"].ToString() != "")
                {
                    model.region_type = int.Parse(row["region_type"].ToString());
                }
                if (row["region_order"] != null && row["region_order"].ToString() != "")
                {
                    model.region_order = int.Parse(row["region_order"].ToString());
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
            strSql.Append("select region_id,parent_id,region_name,region_type,region_order ");
            strSql.Append(" FROM Param_Area ");
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
           
            strSql.Append(" region_id,parent_id,region_name,region_type,region_order ");
            strSql.Append(" FROM Param_Area ");
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Param_Area ");
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
                strSql.Append("order by T.region_id desc");
            }
            strSql.Append(")AS Row, T.*  from Param_Area T ");
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
            parameters[0].Value = "Param_Area";
            parameters[1].Value = "region_id";
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

