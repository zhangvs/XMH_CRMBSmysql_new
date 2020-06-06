using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:dms_brand_percentageDAO
    /// </summary>
    public partial class dms_brand_percentageDAO
    {
        public dms_brand_percentageDAO()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from dms_brand_percentage");
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
        public bool Add(XHD.Model.dms_brand_percentage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into dms_brand_percentage(");
            strSql.Append("year,month,bc_user_name,bc_real_name,bc_brand_id,bc_brand_name,base_brand,plan_brand,bp_percentage,salemoney_brand,backmoney_brand,realmoney_brand,cha_brand,wcl_brand,percentage_brand,create_time)");
            strSql.Append(" values (");
            strSql.Append("@year,@month,@bc_user_name,@bc_real_name,@bc_brand_id,@bc_brand_name,@base_brand,@plan_brand,@bp_percentage,@salemoney_brand,@backmoney_brand,@realmoney_brand,@cha_brand,@wcl_brand,@percentage_brand,@create_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@year", MySqlDbType.VarChar,4),
					new MySqlParameter("@month", MySqlDbType.VarChar,2),
					new MySqlParameter("@bc_user_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@bc_real_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@bc_brand_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@bc_brand_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@base_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@plan_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@bp_percentage", MySqlDbType.Decimal,18),
					new MySqlParameter("@salemoney_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@backmoney_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@realmoney_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@cha_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@wcl_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@percentage_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime)};
            parameters[0].Value = model.year;
            parameters[1].Value = model.month;
            parameters[2].Value = model.bc_user_name;
            parameters[3].Value = model.bc_real_name;
            parameters[4].Value = model.bc_brand_id;
            parameters[5].Value = model.bc_brand_name;
            parameters[6].Value = model.base_brand;
            parameters[7].Value = model.plan_brand;
            parameters[8].Value = model.bp_percentage;
            parameters[9].Value = model.salemoney_brand;
            parameters[10].Value = model.backmoney_brand;
            parameters[11].Value = model.realmoney_brand;
            parameters[12].Value = model.cha_brand;
            parameters[13].Value = model.wcl_brand;
            parameters[14].Value = model.percentage_brand;
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
        public bool Update(XHD.Model.dms_brand_percentage model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update dms_brand_percentage set ");
            strSql.Append("year=@year,");
            strSql.Append("month=@month,");
            strSql.Append("bc_user_name=@bc_user_name,");
            strSql.Append("bc_real_name=@bc_real_name,");
            strSql.Append("bc_brand_id=@bc_brand_id,");
            strSql.Append("bc_brand_name=@bc_brand_name,");
            strSql.Append("base_brand=@base_brand,");
            strSql.Append("plan_brand=@plan_brand,");
            strSql.Append("bp_percentage=@bp_percentage,");
            strSql.Append("salemoney_brand=@salemoney_brand,");
            strSql.Append("backmoney_brand=@backmoney_brand,");
            strSql.Append("realmoney_brand=@realmoney_brand,");
            strSql.Append("cha_brand=@cha_brand,");
            strSql.Append("wcl_brand=@wcl_brand,");
            strSql.Append("percentage_brand=@percentage_brand,");
            strSql.Append("create_time=@create_time");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@year", MySqlDbType.VarChar,4),
					new MySqlParameter("@month", MySqlDbType.VarChar,2),
					new MySqlParameter("@bc_user_name", MySqlDbType.VarChar,20),
					new MySqlParameter("@bc_real_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@bc_brand_id", MySqlDbType.VarChar,20),
					new MySqlParameter("@bc_brand_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@base_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@plan_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@bp_percentage", MySqlDbType.Decimal,18),
					new MySqlParameter("@salemoney_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@backmoney_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@realmoney_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@cha_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@wcl_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@percentage_brand", MySqlDbType.Decimal,18),
					new MySqlParameter("@create_time", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.year;
            parameters[1].Value = model.month;
            parameters[2].Value = model.bc_user_name;
            parameters[3].Value = model.bc_real_name;
            parameters[4].Value = model.bc_brand_id;
            parameters[5].Value = model.bc_brand_name;
            parameters[6].Value = model.base_brand;
            parameters[7].Value = model.plan_brand;
            parameters[8].Value = model.bp_percentage;
            parameters[9].Value = model.salemoney_brand;
            parameters[10].Value = model.backmoney_brand;
            parameters[11].Value = model.realmoney_brand;
            parameters[12].Value = model.cha_brand;
            parameters[13].Value = model.wcl_brand;
            parameters[14].Value = model.percentage_brand;
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
            strSql.Append("delete from dms_brand_percentage ");
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
            strSql.Append("delete from dms_brand_percentage ");
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
        public XHD.Model.dms_brand_percentage GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,year,month,bc_user_name,bc_real_name,bc_brand_id,bc_brand_name,base_brand,plan_brand,bp_percentage,salemoney_brand,backmoney_brand,realmoney_brand,cha_brand,wcl_brand,percentage_brand,create_time from dms_brand_percentage ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.dms_brand_percentage model = new XHD.Model.dms_brand_percentage();
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
        public XHD.Model.dms_brand_percentage DataRowToModel(DataRow row)
        {
            XHD.Model.dms_brand_percentage model = new XHD.Model.dms_brand_percentage();
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
                if (row["month"] != null)
                {
                    model.month = row["month"].ToString();
                }
                if (row["bc_user_name"] != null)
                {
                    model.bc_user_name = row["bc_user_name"].ToString();
                }
                if (row["bc_real_name"] != null)
                {
                    model.bc_real_name = row["bc_real_name"].ToString();
                }
                if (row["bc_brand_id"] != null)
                {
                    model.bc_brand_id = row["bc_brand_id"].ToString();
                }
                if (row["bc_brand_name"] != null)
                {
                    model.bc_brand_name = row["bc_brand_name"].ToString();
                }
                if (row["base_brand"] != null && row["base_brand"].ToString() != "")
                {
                    model.base_brand = decimal.Parse(row["base_brand"].ToString());
                }
                if (row["plan_brand"] != null && row["plan_brand"].ToString() != "")
                {
                    model.plan_brand = decimal.Parse(row["plan_brand"].ToString());
                }
                if (row["bp_percentage"] != null && row["bp_percentage"].ToString() != "")
                {
                    model.bp_percentage = decimal.Parse(row["bp_percentage"].ToString());
                }
                if (row["salemoney_brand"] != null && row["salemoney_brand"].ToString() != "")
                {
                    model.salemoney_brand = decimal.Parse(row["salemoney_brand"].ToString());
                }
                if (row["backmoney_brand"] != null && row["backmoney_brand"].ToString() != "")
                {
                    model.backmoney_brand = decimal.Parse(row["backmoney_brand"].ToString());
                }
                if (row["realmoney_brand"] != null && row["realmoney_brand"].ToString() != "")
                {
                    model.realmoney_brand = decimal.Parse(row["realmoney_brand"].ToString());
                }
                if (row["cha_brand"] != null && row["cha_brand"].ToString() != "")
                {
                    model.cha_brand = decimal.Parse(row["cha_brand"].ToString());
                }
                if (row["wcl_brand"] != null && row["wcl_brand"].ToString() != "")
                {
                    model.wcl_brand = decimal.Parse(row["wcl_brand"].ToString());
                }
                if (row["percentage_brand"] != null && row["percentage_brand"].ToString() != "")
                {
                    model.percentage_brand = decimal.Parse(row["percentage_brand"].ToString());
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
            strSql.Append("select id,year,month,bc_user_name,bc_real_name,bc_brand_id,bc_brand_name,base_brand,plan_brand,bp_percentage,salemoney_brand,backmoney_brand,realmoney_brand,cha_brand,wcl_brand,percentage_brand,create_time ");
            strSql.Append(" FROM dms_brand_percentage ");
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
            strSql.Append("select count(1) FROM dms_brand_percentage ");
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
            strSql.Append(")AS Row, T.*  from dms_brand_percentage T ");
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
            parameters[0].Value = "dms_brand_percentage";
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
        public DataSet GetListOrderByPercentage(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select percentage_brand_sum,id,year,month,bc_user_name,bc_real_name,bc_brand_id,bc_brand_name,base_brand,plan_brand,bp_percentage,salemoney_brand,backmoney_brand,realmoney_brand,cha_brand,wcl_brand,percentage_brand,create_time  from dms_brand_percentage ");
            strSql.Append(" left join (SELECT bc_user_name uname,sum(percentage_brand) percentage_brand_sum from dms_brand_percentage  ");
            strSql.Append("  where "+strWhere+"  group by uname ");
            strSql.Append(" ) wclsum on wclsum.uname=dms_brand_percentage.bc_user_name ");
            strSql.Append("  where " + strWhere + "  ");
            strSql.Append(" order by percentage_brand_sum desc,percentage_brand desc ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteBySql(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from dms_brand_percentage ");
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

