using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using XHD.DBUtility;

namespace XHD.DAL.shop
{
    /// <summary>
    /// 数据访问类:shop_authorize
    /// </summary>
    public partial class shop_authorize
    {
        public shop_authorize()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("id", "shop_authorize");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_authorize");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
            parameters[0].Value = id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.shop_authorize model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_authorize(");
            strSql.Append("id,user_id,apply_admin_id,cat,show_seal,company_name,brand_id,brand,country,province,city,district,comment,add_time,auditor,audit_status,audit_time,audit_notes,is_available,code)");
            strSql.Append(" values (");
            strSql.Append("@id,@user_id,@apply_admin_id,@cat,@show_seal,@company_name,@brand_id,@brand,@country,@province,@city,@district,@comment,@add_time,@auditor,@audit_status,@audit_time,@audit_notes,@is_available,@code)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@cat", MySqlDbType.Int32,6),
					new MySqlParameter("@show_seal", MySqlDbType.Int32,2),
					new MySqlParameter("@company_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@brand_id", MySqlDbType.Int32,11),
					new MySqlParameter("@brand", MySqlDbType.VarChar,100),
					new MySqlParameter("@country", MySqlDbType.Int32,10),
					new MySqlParameter("@province", MySqlDbType.Int32,10),
					new MySqlParameter("@city", MySqlDbType.Int32,10),
					new MySqlParameter("@district", MySqlDbType.VarChar,255),
					new MySqlParameter("@comment", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.VarChar,20),
					new MySqlParameter("@auditor", MySqlDbType.Int32,11),
					new MySqlParameter("@audit_status", MySqlDbType.Int32,2),
					new MySqlParameter("@audit_time", MySqlDbType.VarChar,20),
					new MySqlParameter("@audit_notes", MySqlDbType.VarChar,255),
					new MySqlParameter("@is_available", MySqlDbType.Int32,2),
					new MySqlParameter("@code", MySqlDbType.VarChar,8)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.apply_admin_id;
            parameters[3].Value = model.cat;
            parameters[4].Value = model.show_seal;
            parameters[5].Value = model.company_name;
            parameters[6].Value = model.brand_id;
            parameters[7].Value = model.brand;
            parameters[8].Value = model.country;
            parameters[9].Value = model.province;
            parameters[10].Value = model.city;
            parameters[11].Value = model.district;
            parameters[12].Value = model.comment;
            parameters[13].Value = model.add_time;
            parameters[14].Value = model.auditor;
            parameters[15].Value = model.audit_status;
            parameters[16].Value = model.audit_time;
            parameters[17].Value = model.audit_notes;
            parameters[18].Value = model.is_available;
            parameters[19].Value = model.code;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(XHD.Model.shop_authorize model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_authorize set ");
            strSql.Append("user_id=@user_id,");
            strSql.Append("apply_admin_id=@apply_admin_id,");
            strSql.Append("cat=@cat,");
            strSql.Append("show_seal=@show_seal,");
            strSql.Append("company_name=@company_name,");
            strSql.Append("brand_id=@brand_id,");
            strSql.Append("brand=@brand,");
            strSql.Append("country=@country,");
            strSql.Append("province=@province,");
            strSql.Append("city=@city,");
            strSql.Append("district=@district,");
            strSql.Append("comment=@comment,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("auditor=@auditor,");
            strSql.Append("audit_status=@audit_status,");
            strSql.Append("audit_time=@audit_time,");
            strSql.Append("audit_notes=@audit_notes,");
            strSql.Append("is_available=@is_available,");
            strSql.Append("code=@code");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@apply_admin_id", MySqlDbType.Int32,11),
					new MySqlParameter("@cat", MySqlDbType.Int32,6),
					new MySqlParameter("@show_seal", MySqlDbType.Int32,2),
					new MySqlParameter("@company_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@brand_id", MySqlDbType.Int32,11),
					new MySqlParameter("@brand", MySqlDbType.VarChar,100),
					new MySqlParameter("@country", MySqlDbType.Int32,10),
					new MySqlParameter("@province", MySqlDbType.Int32,10),
					new MySqlParameter("@city", MySqlDbType.Int32,10),
					new MySqlParameter("@district", MySqlDbType.VarChar,255),
					new MySqlParameter("@comment", MySqlDbType.VarChar,255),
					new MySqlParameter("@add_time", MySqlDbType.VarChar,20),
					new MySqlParameter("@auditor", MySqlDbType.Int32,11),
					new MySqlParameter("@audit_status", MySqlDbType.Int32,2),
					new MySqlParameter("@audit_time", MySqlDbType.VarChar,20),
					new MySqlParameter("@audit_notes", MySqlDbType.VarChar,255),
					new MySqlParameter("@is_available", MySqlDbType.Int32,2),
					new MySqlParameter("@code", MySqlDbType.VarChar,8),
					new MySqlParameter("@id", MySqlDbType.Int32,10)};
            parameters[0].Value = model.user_id;
            parameters[1].Value = model.apply_admin_id;
            parameters[2].Value = model.cat;
            parameters[3].Value = model.show_seal;
            parameters[4].Value = model.company_name;
            parameters[5].Value = model.brand_id;
            parameters[6].Value = model.brand;
            parameters[7].Value = model.country;
            parameters[8].Value = model.province;
            parameters[9].Value = model.city;
            parameters[10].Value = model.district;
            parameters[11].Value = model.comment;
            parameters[12].Value = model.add_time;
            parameters[13].Value = model.auditor;
            parameters[14].Value = model.audit_status;
            parameters[15].Value = model.audit_time;
            parameters[16].Value = model.audit_notes;
            parameters[17].Value = model.is_available;
            parameters[18].Value = model.code;
            parameters[19].Value = model.id;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
            strSql.Append("delete from shop_authorize ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
            parameters[0].Value = id;

            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
            strSql.Append("delete from shop_authorize ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public XHD.Model.shop_authorize GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select r1.region_name rname1,r2.region_name rname2,sa.id,sa.user_id,sa.apply_admin_id,sa.cat,sa.show_seal,sa.company_name,sa.brand_id,sa.brand,sa.country,sa.province,sa.city,sa.district,sa.comment,sa.add_time,sa.auditor,sa.audit_status,sa.audit_time,sa.audit_notes,sa.is_available,sa.code from shop_authorize sa ");
            strSql.Append(" left join xmh_shop.shop_region r1 on r1.region_id=sa.province ");
            strSql.Append(" left join xmh_shop.shop_region r2 on r2.region_id=sa.city ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,10)			};
            parameters[0].Value = id;

            XHD.Model.shop_authorize model = new XHD.Model.shop_authorize();
            DataSet ds = Shop_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public XHD.Model.shop_authorize DataRowToModel(DataRow row)
        {
            XHD.Model.shop_authorize model = new XHD.Model.shop_authorize();
            if (row != null)
            {
                if (row["rname1"] != null)
                {
                    model.rname1 = row["rname1"].ToString();
                }
                if (row["rname2"] != null)
                {
                    model.rname2 = row["rname2"].ToString();
                }
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["apply_admin_id"] != null && row["apply_admin_id"].ToString() != "")
                {
                    model.apply_admin_id = int.Parse(row["apply_admin_id"].ToString());
                }
                if (row["cat"] != null && row["cat"].ToString() != "")
                {
                    model.cat = int.Parse(row["cat"].ToString());
                }
                if (row["show_seal"] != null && row["show_seal"].ToString() != "")
                {
                    model.show_seal = int.Parse(row["show_seal"].ToString());
                }
                if (row["company_name"] != null)
                {
                    model.company_name = row["company_name"].ToString();
                }
                if (row["brand_id"] != null && row["brand_id"].ToString() != "")
                {
                    model.brand_id = int.Parse(row["brand_id"].ToString());
                }
                if (row["brand"] != null)
                {
                    model.brand = row["brand"].ToString();
                }
                if (row["country"] != null && row["country"].ToString() != "")
                {
                    model.country = int.Parse(row["country"].ToString());
                }
                if (row["province"] != null && row["province"].ToString() != "")
                {
                    model.province = int.Parse(row["province"].ToString());
                }
                if (row["city"] != null && row["city"].ToString() != "")
                {
                    model.city = int.Parse(row["city"].ToString());
                }
                if (row["district"] != null)
                {
                    model.district = row["district"].ToString();
                }
                if (row["comment"] != null)
                {
                    model.comment = row["comment"].ToString();
                }
                if (row["add_time"] != null)
                {
                    model.add_time = row["add_time"].ToString();
                }
                if (row["auditor"] != null && row["auditor"].ToString() != "")
                {
                    model.auditor = int.Parse(row["auditor"].ToString());
                }
                if (row["audit_status"] != null && row["audit_status"].ToString() != "")
                {
                    model.audit_status = int.Parse(row["audit_status"].ToString());
                }
                if (row["audit_time"] != null)
                {
                    model.audit_time = row["audit_time"].ToString();
                }
                if (row["audit_notes"] != null)
                {
                    model.audit_notes = row["audit_notes"].ToString();
                }
                if (row["is_available"] != null && row["is_available"].ToString() != "")
                {
                    model.is_available = int.Parse(row["is_available"].ToString());
                }
                if (row["code"] != null)
                {
                    model.code = row["code"].ToString();
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
            strSql.Append("select id,user_id,apply_admin_id,cat,show_seal,company_name,brand_id,brand,country,province,city,district,comment,add_time,auditor,audit_status,audit_time,audit_notes,is_available ");
            strSql.Append(" FROM shop_authorize ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM shop_authorize ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString());
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
            strSql.Append(")AS Row, T.*  from shop_authorize T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return Shop_DbHelperMySQL.Query(strSql.ToString());
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
            parameters[0].Value = "shop_authorize";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return Shop_DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
