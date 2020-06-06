using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:ecs_goods_activity
    /// </summary>
    public partial class ecs_goods_activity
    {
        public ecs_goods_activity()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int act_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ecs_goods_activity");
            strSql.Append(" where act_id=@act_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@act_id", MySqlDbType.Int32)
			};
            parameters[0].Value = act_id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.ecs_goods_activity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ecs_goods_activity(");
            strSql.Append("act_name,act_desc,act_type,goods_id,product_id,goods_name,start_time,end_time,is_finished,ext_info)");
            strSql.Append(" values (");
            strSql.Append("@act_name,@act_desc,@act_type,@goods_id,@product_id,@goods_name,@start_time,@end_time,@is_finished,@ext_info)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@act_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@act_desc", MySqlDbType.Text),
					new MySqlParameter("@act_type", MySqlDbType.Byte,3),
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8),
					new MySqlParameter("@product_id", MySqlDbType.Int32,8),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@start_time", MySqlDbType.Int32,10),
					new MySqlParameter("@end_time", MySqlDbType.Int32,10),
					new MySqlParameter("@is_finished", MySqlDbType.Byte,3),
					new MySqlParameter("@ext_info", MySqlDbType.Text)};
            parameters[0].Value = model.act_name;
            parameters[1].Value = model.act_desc;
            parameters[2].Value = model.act_type;
            parameters[3].Value = model.goods_id;
            parameters[4].Value = model.product_id;
            parameters[5].Value = model.goods_name;
            parameters[6].Value = model.start_time;
            parameters[7].Value = model.end_time;
            parameters[8].Value = model.is_finished;
            parameters[9].Value = model.ext_info;

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
        public bool Update(XHD.Model.ecs_goods_activity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ecs_goods_activity set ");
            strSql.Append("act_name=@act_name,");
            strSql.Append("act_desc=@act_desc,");
            strSql.Append("act_type=@act_type,");
            strSql.Append("goods_id=@goods_id,");
            strSql.Append("product_id=@product_id,");
            strSql.Append("goods_name=@goods_name,");
            strSql.Append("start_time=@start_time,");
            strSql.Append("end_time=@end_time,");
            strSql.Append("is_finished=@is_finished,");
            strSql.Append("ext_info=@ext_info");
            strSql.Append(" where act_id=@act_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@act_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@act_desc", MySqlDbType.Text),
					new MySqlParameter("@act_type", MySqlDbType.Byte,3),
					new MySqlParameter("@goods_id", MySqlDbType.Int32,8),
					new MySqlParameter("@product_id", MySqlDbType.Int32,8),
					new MySqlParameter("@goods_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@start_time", MySqlDbType.Int32,10),
					new MySqlParameter("@end_time", MySqlDbType.Int32,10),
					new MySqlParameter("@is_finished", MySqlDbType.Byte,3),
					new MySqlParameter("@ext_info", MySqlDbType.Text),
					new MySqlParameter("@act_id", MySqlDbType.Int32,8)};
            parameters[0].Value = model.act_name;
            parameters[1].Value = model.act_desc;
            parameters[2].Value = model.act_type;
            parameters[3].Value = model.goods_id;
            parameters[4].Value = model.product_id;
            parameters[5].Value = model.goods_name;
            parameters[6].Value = model.start_time;
            parameters[7].Value = model.end_time;
            parameters[8].Value = model.is_finished;
            parameters[9].Value = model.ext_info;
            parameters[10].Value = model.act_id;

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
        public bool Delete(int act_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_goods_activity ");
            strSql.Append(" where act_id=@act_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@act_id", MySqlDbType.Int32)
			};
            parameters[0].Value = act_id;

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
        public bool DeleteList(string act_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ecs_goods_activity ");
            strSql.Append(" where act_id in (" + act_idlist + ")  ");
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
        public XHD.Model.ecs_goods_activity GetModel(int act_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select act_id,act_name,act_desc,act_type,goods_id,product_id,goods_name,start_time,end_time,is_finished,ext_info from ecs_goods_activity ");
            strSql.Append(" where act_id=@act_id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@act_id", MySqlDbType.Int32)
			};
            parameters[0].Value = act_id;

            XHD.Model.ecs_goods_activity model = new XHD.Model.ecs_goods_activity();
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
        public XHD.Model.ecs_goods_activity DataRowToModel(DataRow row)
        {
            XHD.Model.ecs_goods_activity model = new XHD.Model.ecs_goods_activity();
            if (row != null)
            {
                //model.act_id=row["act_id"].ToString();
                if (row["act_name"] != null)
                {
                    model.act_name = row["act_name"].ToString();
                }
                if (row["act_desc"] != null)
                {
                    model.act_desc = row["act_desc"].ToString();
                }
                if (row["act_type"] != null && row["act_type"].ToString() != "")
                {
                    model.act_type = int.Parse(row["act_type"].ToString());
                }
                //model.goods_id=row["goods_id"].ToString();
                //model.product_id=row["product_id"].ToString();
                if (row["goods_name"] != null)
                {
                    model.goods_name = row["goods_name"].ToString();
                }
                if (row["start_time"] != null && row["start_time"].ToString() != "")
                {
                    model.start_time = int.Parse(row["start_time"].ToString());
                }
                if (row["end_time"] != null && row["end_time"].ToString() != "")
                {
                    model.end_time = int.Parse(row["end_time"].ToString());
                }
                if (row["is_finished"] != null && row["is_finished"].ToString() != "")
                {
                    model.is_finished = int.Parse(row["is_finished"].ToString());
                }
                if (row["ext_info"] != null)
                {
                    model.ext_info = row["ext_info"].ToString();
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
            strSql.Append("select act_id,act_name,act_desc,act_type,goods_id,product_id,goods_name,start_time,end_time,is_finished,ext_info ");
            strSql.Append(" FROM ecs_goods_activity ");
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
            strSql.Append("select count(1) FROM ecs_goods_activity ");
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
                strSql.Append("order by T.act_id desc");
            }
            strSql.Append(")AS Row, T.*  from ecs_goods_activity T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();     
            strSql.Append("Select * FROM ecs_goods_activity ");
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
            strSql.Append("select * FROM ecs_goods_activity");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_Contact ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(act_id) FROM ecs_goods_activity ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
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
            parameters[0].Value = "ecs_goods_activity";
            parameters[1].Value = "act_id";
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

