using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_supplydear_relate
    /// </summary>
    public partial class scm_supplydear_relate
    {
        public scm_supplydear_relate()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_supplydear_relate");
            strSql.Append(" where " + strWhere);

            return DbHelperMySQL.Exists(strSql.ToString());
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_supplydear_relate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_supplydear_relate(");
            strSql.Append("factory_id,suppliers_id,suppliers_name,dear_id,dear_name,descpt,type,handle_name,handle_id,handle_time)");
            strSql.Append(" values (");
            strSql.Append("@factory_id,@suppliers_id,@suppliers_name,@dear_id,@dear_name,@descpt,@type,@handle_name,@handle_id,@handle_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@dear_id", MySqlDbType.Int32,11),
					new MySqlParameter("@dear_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@descpt", MySqlDbType.VarChar,500),
					new MySqlParameter("@type", MySqlDbType.VarChar,10),
					new MySqlParameter("@handle_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@handle_id", MySqlDbType.Int32,11),
					new MySqlParameter("@handle_time", MySqlDbType.DateTime)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.suppliers_name;
            parameters[3].Value = model.dear_id;
            parameters[4].Value = model.dear_name;
            parameters[5].Value = model.descpt;
            parameters[6].Value = model.type;
            parameters[7].Value = model.handle_name;
            parameters[8].Value = model.handle_id;
            parameters[9].Value = model.handle_time;

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
        public bool Update(XHD.Model.scm_supplydear_relate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_supplydear_relate set ");
            strSql.Append("factory_id=@factory_id,");
            strSql.Append("suppliers_id=@suppliers_id,");
            strSql.Append("suppliers_name=@suppliers_name,");
            strSql.Append("dear_id=@dear_id,");
            strSql.Append("dear_name=@dear_name,");
            strSql.Append("descpt=@descpt,");
            strSql.Append("type=@type,");
            strSql.Append("handle_name=@handle_name,");
            strSql.Append("handle_id=@handle_id,");
            strSql.Append("handle_time=@handle_time");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factory_id", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@dear_id", MySqlDbType.Int32,11),
					new MySqlParameter("@dear_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@descpt", MySqlDbType.VarChar,500),
					new MySqlParameter("@type", MySqlDbType.VarChar,10),
					new MySqlParameter("@handle_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@handle_id", MySqlDbType.Int32,11),
					new MySqlParameter("@handle_time", MySqlDbType.DateTime),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factory_id;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.suppliers_name;
            parameters[3].Value = model.dear_id;
            parameters[4].Value = model.dear_name;
            parameters[5].Value = model.descpt;
            parameters[6].Value = model.type;
            parameters[7].Value = model.handle_name;
            parameters[8].Value = model.handle_id;
            parameters[9].Value = model.handle_time;
            parameters[10].Value = model.Id;

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
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_supplydear_relate ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

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

        public bool DeleteByDear(string dear_id, string suppliers_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_supplydear_relate ");
            strSql.Append(" where dear_id=" + dear_id);
            strSql.Append(" and suppliers_id=" + suppliers_id);
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_supplydear_relate ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        public XHD.Model.scm_supplydear_relate GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_id,suppliers_id,suppliers_name,dear_id,dear_name,descpt,type from scm_supplydear_relate ");
            strSql.Append(" where Id=@Id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
            parameters[0].Value = Id;

            XHD.Model.scm_supplydear_relate model = new XHD.Model.scm_supplydear_relate();
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
        public XHD.Model.scm_supplydear_relate DataRowToModel(DataRow row)
        {
            XHD.Model.scm_supplydear_relate model = new XHD.Model.scm_supplydear_relate();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factory_id"] != null)
                {
                    model.factory_id = row["factory_id"].ToString();
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                if (row["suppliers_name"] != null)
                {
                    model.suppliers_name = row["suppliers_name"].ToString();
                }
                if (row["dear_id"] != null && row["dear_id"].ToString() != "")
                {
                    model.dear_id = int.Parse(row["dear_id"].ToString());
                }
                if (row["dear_name"] != null)
                {
                    model.dear_name = row["dear_name"].ToString();
                }
                if (row["descpt"] != null)
                {
                    model.descpt = row["descpt"].ToString();
                }
                if (row["type"] != null)
                {
                    model.type = row["type"].ToString();
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
            strSql.Append("select Id,factory_id,suppliers_id,suppliers_name,dear_id,dear_name,descpt,type ");
            strSql.Append(" FROM scm_supplydear_relate ");
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
            strSql.Append("select count(1) FROM scm_supplydear_relate ");
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
                strSql.Append("order by T.Id descpt");
            }
            strSql.Append(")AS Row, T.*  from scm_supplydear_relate T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select Id,factory_id,suppliers_id,suppliers_name,dear_id,dear_name,descpt,type ");
            strSql.Append(" FROM scm_supplydear_relate ");
            strSql1.Append(" select count(1) from scm_supplydear_relate ");
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
        /// 列表
        /// </summary>
        public DataSet GetSupply(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select Id,factory_id,suppliers_id,suppliers_name,count(dear_id) as num ");
            strSql.Append(" FROM scm_supplydear_relate ");
            strSql1.Append(" select count(1) from ( ");
            strSql1.Append(" select * from scm_supplydear_relate ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" group by  suppliers_id");
            strSql1.Append(" group by  suppliers_id");
            strSql1.Append(" ) as abc");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetDear(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select Id,factory_id,suppliers_id,suppliers_name,dear_id,dear_name,descpt,type,handle_name,handle_id,handle_time from scm_supplydear_relate  ");
            strSql1.Append(" select count(1) from scm_supplydear_relate ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet getDearByOrder(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select  distinct oi.user_id,u.u_company,u.user_name,u.u_real_name");
            strSql.Append(" from  ecs_order_goods as og ");
            strSql.Append(" inner join ecs_goods as g on g.goods_id=og.goods_id and g.suppliers_id=" + strWhere);
            strSql.Append(" inner join ecs_order_info as oi on oi.order_id=og.order_id  and oi.order_status !=9 and oi.erp_time  is not null");
            strSql.Append(" inner join ecs_users as u on oi.user_id=u.user_id");
            strSql.Append(" where oi.user_id not in(select dear_id from scm_supplydear_relate where suppliers_id=" + strWhere + ")");

            strSql1.Append(" select  count(distinct oi.user_id)");
            strSql1.Append(" from  ecs_order_goods as og ");
            strSql1.Append(" inner join ecs_goods as g on g.goods_id=og.goods_id and g.suppliers_id=" + strWhere);
            strSql1.Append(" inner join ecs_order_info as oi on oi.order_id=og.order_id  and oi.order_status !=9 and oi.erp_time  is not null");
            strSql1.Append(" inner join ecs_users as u on oi.user_id=u.user_id");
            strSql1.Append(" where oi.user_id not in(select dear_id from scm_supplydear_relate where suppliers_id=" + strWhere + ")");
            //if (strWhere.Trim() != "")
            //{
            //    strSql.Append(" where " + strWhere);
            //    strSql1.Append(" where " + strWhere);
            //}
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet getDearByOrder(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select  distinct oi.user_id,u.u_company,u.user_name,u.u_real_name");
            strSql.Append(" from  ecs_order_goods as og ");
            strSql.Append(" inner join ecs_goods as g on g.goods_id=og.goods_id and g.suppliers_id=" + strWhere + " and g.goods_sn2 not in (94200,94165,94166)");
            strSql.Append(" inner join ecs_order_info as oi on oi.order_id=og.order_id  and oi.order_status !=9 and oi.erp_time  is not null");
            strSql.Append(" inner join ecs_users as u on oi.user_id=u.user_id");
            strSql.Append(" where oi.user_id not in(select dear_id from scm_supplydear_relate where suppliers_id=" + strWhere + ")");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet getDearCLByOrder(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select  distinct oi.user_id,u.u_company,u.user_name,u.u_real_name");
            strSql.Append(" from  ecs_order_goods as og ");
            strSql.Append(" inner join ecs_goods as g on g.goods_id=og.goods_id and g.suppliers_id=" + strWhere + " and g.goods_sn2 in (94200,94165,94166)");
            strSql.Append(" inner join ecs_order_info as oi on oi.order_id=og.order_id  and oi.order_status !=9 and oi.erp_time  is not null");
            strSql.Append(" inner join ecs_users as u on oi.user_id=u.user_id");
            strSql.Append(" where oi.user_id not in(select dear_id from scm_supplydear_relate where suppliers_id=" + strWhere + ")");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //改进后的，不区分94200,94165,94166的所有经销商
        public DataSet getDearByOrderS(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append(" select  distinct oi.user_id,u.u_company,u.user_name,u.u_real_name");
            strSql.Append(" from  ecs_order_goods as og ");
            strSql.Append(" inner join ecs_goods as g on g.goods_id=og.goods_id and g.suppliers_id=" + strWhere);
            strSql.Append(" inner join ecs_order_info as oi on oi.order_id=og.order_id  and oi.order_status !=9 and oi.erp_time  is not null");
            strSql.Append(" inner join ecs_users as u on oi.user_id=u.user_id");
            strSql.Append(" where oi.user_id not in(select dear_id from scm_supplydear_relate where suppliers_id=" + strWhere + ")");
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
            parameters[0].Value = "scm_supplydear_relate";
            parameters[1].Value = "Id";
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

