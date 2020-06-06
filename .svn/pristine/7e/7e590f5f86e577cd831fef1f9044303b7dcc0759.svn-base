using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:scm_spe_order_detail
    /// </summary>
    public partial class scm_spe_order_detail
    {
        public scm_spe_order_detail()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "scm_spe_order_detail");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from scm_spe_order_detail");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.scm_spe_order_detail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into scm_spe_order_detail(");
            strSql.Append("id,spe_order_id,my_order_code,my_order_money,province_id,city_id,district_id,order_suppliersid,order_old_date)");
            strSql.Append(" values (");
            strSql.Append("@id,@spe_order_id,@my_order_code,@my_order_money,@province_id,@city_id,@district_id,@order_suppliersid,@order_old_date)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@spe_order_id", MySqlDbType.Int32,11),
					new MySqlParameter("@my_order_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@my_order_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@province_id", MySqlDbType.Int32,11),
					new MySqlParameter("@city_id", MySqlDbType.Int32,11),
					new MySqlParameter("@district_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_suppliersid", MySqlDbType.Int32,11),
                    new MySqlParameter("@order_old_date", MySqlDbType.Int32,11)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.spe_order_id;
            parameters[2].Value = model.my_order_code;
            parameters[3].Value = model.my_order_money;
            parameters[4].Value = model.province_id;
            parameters[5].Value = model.city_id;
            parameters[6].Value = model.district_id;
            parameters[7].Value = model.order_suppliersid;
            parameters[8].Value = model.order_old_date;

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
        public bool Update(XHD.Model.scm_spe_order_detail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update scm_spe_order_detail set ");
            strSql.Append("spe_order_id=@spe_order_id,");
            strSql.Append("my_order_code=@my_order_code,");
            strSql.Append("my_order_money=@my_order_money,");
            strSql.Append("province_id=@province_id,");
            strSql.Append("city_id=@city_id,");
            strSql.Append("district_id=@district_id,");
            strSql.Append("order_suppliersid=@order_suppliersid,");
            strSql.Append("order_old_date=@order_old_date");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@spe_order_id", MySqlDbType.Int32,11),
					new MySqlParameter("@my_order_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@my_order_money", MySqlDbType.Decimal,10),
					new MySqlParameter("@province_id", MySqlDbType.Int32,11),
					new MySqlParameter("@city_id", MySqlDbType.Int32,11),
					new MySqlParameter("@district_id", MySqlDbType.Int32,11),
					new MySqlParameter("@order_suppliersid", MySqlDbType.Int32,11),
                    new MySqlParameter("@order_old_date", MySqlDbType.Int32,11),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.spe_order_id;
            parameters[1].Value = model.my_order_code;
            parameters[2].Value = model.my_order_money;
            parameters[3].Value = model.province_id;
            parameters[4].Value = model.city_id;
            parameters[5].Value = model.district_id;
            parameters[6].Value = model.order_suppliersid;
            parameters[7].Value = model.order_old_date;
            parameters[8].Value = model.id;

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
            strSql.Append("delete from scm_spe_order_detail ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
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
            strSql.Append("delete from scm_spe_order_detail ");
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
        public XHD.Model.scm_spe_order_detail GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,spe_order_id,my_order_code,my_order_money,province_id,city_id,district_id,order_suppliersid,order_old_date from scm_spe_order_detail ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            XHD.Model.scm_spe_order_detail model = new XHD.Model.scm_spe_order_detail();
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
        public XHD.Model.scm_spe_order_detail DataRowToModel(DataRow row)
        {
            XHD.Model.scm_spe_order_detail model = new XHD.Model.scm_spe_order_detail();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["spe_order_id"] != null && row["spe_order_id"].ToString() != "")
                {
                    model.spe_order_id = int.Parse(row["spe_order_id"].ToString());
                }
                if (row["my_order_code"] != null)
                {
                    model.my_order_code = row["my_order_code"].ToString();
                }
                if (row["my_order_money"] != null && row["my_order_money"].ToString() != "")
                {
                    model.my_order_money = decimal.Parse(row["my_order_money"].ToString());
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
                if (row["order_suppliersid"] != null && row["order_suppliersid"].ToString() != "")
                {
                    model.order_suppliersid = int.Parse(row["order_suppliersid"].ToString());
                }
                if (row["order_old_date"] != null && row["order_old_date"].ToString() != "")
                {
                    model.order_old_date = int.Parse(row["order_old_date"].ToString());
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
            strSql.Append("select id,spe_order_id,my_order_code,my_order_money,province_id,city_id,district_id,order_suppliersid,order_old_date ");
            strSql.Append(" FROM scm_spe_order_detail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet GetListInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,spe_order_id,my_order_code,my_order_money,province_id,city_id,district_id,order_suppliersid,r.region_name,r1.region_name city_name,order_old_date ");
            strSql.Append(" FROM scm_spe_order_detail od left join ecs_region r on od.province_id=r.region_id");
            strSql.Append(" left join ecs_region r1 on od.city_id=r1.region_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 增加数据
        /// </summary>
        public bool AddInfo(decimal money, int suppliers_id)
        {
            string strSql = @"INSERT INTO scm_spe_order_detail(spe_order_id,my_order_code,my_order_money,province_id,city_id,district_id,order_suppliersid,order_old_date)
                              SELECT id, CONCAT(order_sn_old,'-',id),order_money_old,province_id,city_id,district_id,order_suppliersid,oerder_old_date
                              FROM scm_spe_order WHERE
                              	Id NOT IN (
                              		SELECT
                              			spe_order_id
                              		FROM
                              			scm_spe_order_detail
                              	)
                              AND order_money_old < {0} AND order_suppliersid={1}";
            strSql = String.Format(strSql, money, suppliers_id);

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
            strSql.Append("select count(1) FROM scm_spe_order_detail ");
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
            strSql.Append(")AS Row, T.*  from scm_spe_order_detail T ");
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
            parameters[0].Value = "scm_spe_order_detail";
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

