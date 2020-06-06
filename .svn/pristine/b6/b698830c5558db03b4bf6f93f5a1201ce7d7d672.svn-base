using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_spe_order
    /// </summary>
    public partial class scm_spe_order
    {
        public scm_spe_order()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "scm_spe_order");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_spe_order");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.scm_spe_order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_spe_order(");
            strSql.Append("Id,order_id_old,order_sn_old,oerder_old_date,create_date,create_userid,create_username,order_money_old,order_suppliersid,province_id,city_id,district_id,issplit)");
            strSql.Append(" values (");
            strSql.Append("@Id,@order_id_old,@order_sn_old,@oerder_old_date,@create_date,@create_userid,@create_username,@order_money_old,@order_suppliersid,@province_id,@city_id,@district_id,@issplit)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_id_old", MySqlDbType.Int32,11),
					new MySqlParameter("@order_sn_old", MySqlDbType.VarChar,20),
					new MySqlParameter("@oerder_old_date", MySqlDbType.Int32,11),
					new MySqlParameter("@create_date", MySqlDbType.Int32,11),
					new MySqlParameter("@create_userid", MySqlDbType.Int32,11),
					new MySqlParameter("@create_username", MySqlDbType.VarChar,20),
					new MySqlParameter("@order_money_old", MySqlDbType.Decimal,18),
					new MySqlParameter("@order_suppliersid", MySqlDbType.VarChar,20),
					new MySqlParameter("@province_id", MySqlDbType.Int32,11),
					new MySqlParameter("@city_id", MySqlDbType.Int32,11),
					new MySqlParameter("@district_id", MySqlDbType.Int32,11),
                    new MySqlParameter("@issplit", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.order_id_old;
            parameters[2].Value = model.order_sn_old;
            parameters[3].Value = model.oerder_old_date;
            parameters[4].Value = model.create_date;
            parameters[5].Value = model.create_userid;
            parameters[6].Value = model.create_username;
            parameters[7].Value = model.order_money_old;
            parameters[8].Value = model.order_suppliersid;
            parameters[9].Value = model.province_id;
            parameters[10].Value = model.city_id;
            parameters[11].Value = model.district_id;
            parameters[12].Value = model.issplit;

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
        public bool Update(XHD.Model.scm_spe_order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_spe_order set ");
            strSql.Append("order_id_old=@order_id_old,");
            strSql.Append("order_sn_old=@order_sn_old,");
            strSql.Append("oerder_old_date=@oerder_old_date,");
            strSql.Append("create_date=@create_date,");
            strSql.Append("create_userid=@create_userid,");
            strSql.Append("create_username=@create_username,");
            strSql.Append("order_money_old=@order_money_old,");
            strSql.Append("order_suppliersid=@order_suppliersid,");
            strSql.Append("province_id=@province_id,");
            strSql.Append("city_id=@city_id,");
            strSql.Append("district_id=@district_id,");
            strSql.Append("issplit=@issplit");
            strSql.Append(" where Id=@Id ");

            MySqlParameter[] parameters = {
					new MySqlParameter("@order_id_old", MySqlDbType.Int32,11),
					new MySqlParameter("@order_sn_old", MySqlDbType.VarChar,20),
					new MySqlParameter("@oerder_old_date", MySqlDbType.Int32,11),
					new MySqlParameter("@create_date", MySqlDbType.Int32,11),
					new MySqlParameter("@create_userid", MySqlDbType.Int32,11),
					new MySqlParameter("@create_username", MySqlDbType.VarChar,20),
					new MySqlParameter("@order_money_old", MySqlDbType.Decimal,18),
					new MySqlParameter("@order_suppliersid", MySqlDbType.VarChar,20),
					new MySqlParameter("@province_id", MySqlDbType.Int32,11),
					new MySqlParameter("@city_id", MySqlDbType.Int32,11),
					new MySqlParameter("@district_id", MySqlDbType.Int32,11),
                    new MySqlParameter("@issplit", MySqlDbType.Int32,11),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.order_id_old;
            parameters[1].Value = model.order_sn_old;
            parameters[2].Value = model.oerder_old_date;
            parameters[3].Value = model.create_date;
            parameters[4].Value = model.create_userid;
            parameters[5].Value = model.create_username;
            parameters[6].Value = model.order_money_old;
            parameters[7].Value = model.order_suppliersid;
            parameters[8].Value = model.province_id;
            parameters[9].Value = model.city_id;
            parameters[10].Value = model.district_id;
            parameters[11].Value = model.issplit;
            parameters[12].Value = model.Id;

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
            strSql.Append("delete from scm_spe_order ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
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
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from scm_spe_order ");
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
        public XHD.Model.scm_spe_order GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,order_id_old,order_sn_old,oerder_old_date,create_date,create_userid,create_username,order_money_old,order_suppliersid,province_id,city_id,district_id,issplit from scm_spe_order ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            XHD.Model.scm_spe_order model = new XHD.Model.scm_spe_order();
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
        public XHD.Model.scm_spe_order DataRowToModel(DataRow row)
        {
            XHD.Model.scm_spe_order model = new XHD.Model.scm_spe_order();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["order_id_old"] != null && row["order_id_old"].ToString() != "")
                {
                    model.order_id_old = int.Parse(row["order_id_old"].ToString());
                }
                if (row["order_sn_old"] != null)
                {
                    model.order_sn_old = row["order_sn_old"].ToString();
                }
                if (row["oerder_old_date"] != null && row["oerder_old_date"].ToString() != "")
                {
                    model.oerder_old_date = int.Parse(row["oerder_old_date"].ToString());
                }
                if (row["create_date"] != null && row["create_date"].ToString() != "")
                {
                    model.create_date = int.Parse(row["create_date"].ToString());
                }
                if (row["create_userid"] != null && row["create_userid"].ToString() != "")
                {
                    model.create_userid = int.Parse(row["create_userid"].ToString());
                }
                if (row["create_username"] != null)
                {
                    model.create_username = row["create_username"].ToString();
                }
                if (row["order_money_old"] != null && row["order_money_old"].ToString() != "")
                {
                    model.order_money_old = decimal.Parse(row["order_money_old"].ToString());
                }
                if (row["order_suppliersid"] != null)
                {
                    model.order_suppliersid = row["order_suppliersid"].ToString();
                }
                if (row["province_id"] != null && row["province_id"].ToString() != "")
                {
                    model.province_id = int.Parse(row["province_id"].ToString());
                }
                if (row["city_id"] != null && row["city_id"].ToString() != "")
                {
                    model.city_id = int.Parse(row["city_id"].ToString());
                }
                if (row["district_id"] != null && row["district_id"].ToString() != "")
                {
                    model.district_id = int.Parse(row["district_id"].ToString());
                }
                if (row["issplit"] != null && row["issplit"].ToString() != "")
                {
                    model.issplit = int.Parse(row["issplit"].ToString());
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
            strSql.Append("select Id,order_id_old,order_sn_old,oerder_old_date,create_date,create_userid,create_username,order_money_old,order_suppliersid,province_id,city_id,district_id ");
            strSql.Append(" FROM scm_spe_order ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            strSql.Append("select distinct so.Id,so.order_id_old,so.order_sn_old,so.oerder_old_date,so.create_date,so.create_userid,so.create_username,so.order_money_old,so.order_suppliersid,so.province_id,so.city_id,so.district_id,s.suppliers_name,r.region_name ");
            strSql.Append("FROM scm_spe_order so ");
            strSql.Append("INNER JOIN scm_spe_goods sg ON sg.spe_order_id=so.id ");
            strSql.Append("INNER JOIN ecs_suppliers s ON s.suppliers_id=so.order_suppliersid ");
            strSql.Append("LEFT JOIN ecs_region r ON r.region_id=so.province_id ");
            strSql1.Append(" select count(distinct so.id) FROM scm_spe_order so ");
            strSql1.Append("INNER JOIN scm_spe_goods sg ON sg.spe_order_id=so.id ");
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
        /// 增加数据
        /// </summary>
        public bool AddInfo(int empid, string empname, string suppliers_id, int time, decimal money)
        {
            string strSql = @"INSERT INTO scm_spe_order (order_id_old,order_sn_old,oerder_old_date,create_date,create_userid,create_username,order_money_old,order_suppliersid,province_id,city_id,district_id,issplit)
                              SELECT oi.order_id,oi.order_sn,oi.erp_time,unix_timestamp(now()),'{0}','{1}',SUM(g.inv_warn_price*og.goods_number),g.suppliers_id,oi.province,oi.city,oi.district,
                              CASE SUM(g.inv_warn_price*og.goods_number)>{2} WHEN 0 THEN 0 ELSE 1 END
                              FROM
                              	(SELECT * FROM ecs_order_info	WHERE	order_id NOT IN (SELECT	order_id_old FROM scm_spe_order WHERE order_suppliersid = '{3}')
                              		AND order_status != 9
                              		AND erp_time is not null 
                                    AND erp_time >= 1451577600
                              	) oi
                              INNER JOIN ecs_order_goods og ON oi.order_id = og.order_id
                              INNER JOIN ecs_goods g ON og.goods_id = g.goods_id
                              AND g.suppliers_id = '{4}'
                              GROUP BY og.order_id";
            strSql = String.Format(strSql, empid, empname, money, suppliers_id, suppliers_id);

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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM scm_spe_order ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from scm_spe_order T ");
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
            parameters[0].Value = "scm_spe_order";
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

