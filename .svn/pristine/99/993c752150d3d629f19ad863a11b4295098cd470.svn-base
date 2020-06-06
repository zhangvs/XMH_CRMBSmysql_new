using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:shop_user_address
    /// </summary>
    public partial class shop_user_address
    {
        public shop_user_address()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int address_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_user_address");
            strSql.Append(" where address_id=@address_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@address_id", MySqlDbType.Int32,8)			};
            parameters[0].Value = address_id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.shop_user_address model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_user_address(");
            strSql.Append("address_name,user_id,consignee,email,country,province,city,district,address,zipcode,tel,mobile,sign_building,best_time,is_default,is_invoice)");
            strSql.Append(" values (");
            strSql.Append("@address_name,@user_id,@consignee,@email,@country,@province,@city,@district,@address,@zipcode,@tel,@mobile,@sign_building,@best_time,@is_default,@is_invoice)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@address_id", MySqlDbType.Int32,8),
					new MySqlParameter("@address_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@user_id", MySqlDbType.Int32,8),
					new MySqlParameter("@consignee", MySqlDbType.VarChar,60),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@country", MySqlDbType.Int32,5),
					new MySqlParameter("@province", MySqlDbType.Int32,5),
					new MySqlParameter("@city", MySqlDbType.Int32,5),
					new MySqlParameter("@district", MySqlDbType.Int32,5),
					new MySqlParameter("@address", MySqlDbType.VarChar,120),
					new MySqlParameter("@zipcode", MySqlDbType.VarChar,60),
					new MySqlParameter("@tel", MySqlDbType.VarChar,60),
					new MySqlParameter("@mobile", MySqlDbType.VarChar,60),
					new MySqlParameter("@sign_building", MySqlDbType.VarChar,120),
					new MySqlParameter("@best_time", MySqlDbType.VarChar,120),
					new MySqlParameter("@is_default", MySqlDbType.Int32,1),
					new MySqlParameter("@is_invoice", MySqlDbType.Int32,1)};
            parameters[0].Value = model.address_id;
            parameters[1].Value = model.address_name;
            parameters[2].Value = model.user_id;
            parameters[3].Value = model.consignee;
            parameters[4].Value = model.email;
            parameters[5].Value = model.country;
            parameters[6].Value = model.province;
            parameters[7].Value = model.city;
            parameters[8].Value = model.district;
            parameters[9].Value = model.address;
            parameters[10].Value = model.zipcode;
            parameters[11].Value = model.tel;
            parameters[12].Value = model.mobile;
            parameters[13].Value = model.sign_building;
            parameters[14].Value = model.best_time;
            parameters[15].Value = model.is_default;
            parameters[16].Value = model.is_invoice;

            object obj = Shop_DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(XHD.Model.shop_user_address model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_user_address set ");
            strSql.Append("address_name=@address_name,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("consignee=@consignee,");
            strSql.Append("email=@email,");
            strSql.Append("country=@country,");
            strSql.Append("province=@province,");
            strSql.Append("city=@city,");
            strSql.Append("district=@district,");
            strSql.Append("address=@address,");
            strSql.Append("zipcode=@zipcode,");
            strSql.Append("tel=@tel,");
            strSql.Append("mobile=@mobile,");
            strSql.Append("sign_building=@sign_building,");
            strSql.Append("best_time=@best_time,");
            strSql.Append("is_default=@is_default,");
            strSql.Append("is_invoice=@is_invoice");
            strSql.Append(" where address_id=@address_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@address_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@user_id", MySqlDbType.Int32,8),
					new MySqlParameter("@consignee", MySqlDbType.VarChar,60),
					new MySqlParameter("@email", MySqlDbType.VarChar,60),
					new MySqlParameter("@country", MySqlDbType.Int32,5),
					new MySqlParameter("@province", MySqlDbType.Int32,5),
					new MySqlParameter("@city", MySqlDbType.Int32,5),
					new MySqlParameter("@district", MySqlDbType.Int32,5),
					new MySqlParameter("@address", MySqlDbType.VarChar,120),
					new MySqlParameter("@zipcode", MySqlDbType.VarChar,60),
					new MySqlParameter("@tel", MySqlDbType.VarChar,60),
					new MySqlParameter("@mobile", MySqlDbType.VarChar,60),
					new MySqlParameter("@sign_building", MySqlDbType.VarChar,120),
					new MySqlParameter("@best_time", MySqlDbType.VarChar,120),
					new MySqlParameter("@is_default", MySqlDbType.Int32,1),
					new MySqlParameter("@is_invoice", MySqlDbType.Int32,1),
					new MySqlParameter("@address_id", MySqlDbType.Int32,8)};
            parameters[0].Value = model.address_name;
            parameters[1].Value = model.user_id;
            parameters[2].Value = model.consignee;
            parameters[3].Value = model.email;
            parameters[4].Value = model.country;
            parameters[5].Value = model.province;
            parameters[6].Value = model.city;
            parameters[7].Value = model.district;
            parameters[8].Value = model.address;
            parameters[9].Value = model.zipcode;
            parameters[10].Value = model.tel;
            parameters[11].Value = model.mobile;
            parameters[12].Value = model.sign_building;
            parameters[13].Value = model.best_time;
            parameters[14].Value = model.is_default;
            parameters[15].Value = model.is_invoice;
            parameters[16].Value = model.address_id;

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
        public bool Delete(int address_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_user_address ");
            strSql.Append(" where address_id=@address_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@address_id", MySqlDbType.Int32,8)			};
            parameters[0].Value = address_id;

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
        public bool DeleteList(string address_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from shop_user_address ");
            strSql.Append(" where address_id in (" + address_idlist + ")  ");
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
        public XHD.Model.shop_user_address GetModel(int address_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select address_id,address_name,user_id,consignee,email,country,province,city,district,address,zipcode,tel,mobile,sign_building,best_time,is_default,is_invoice from shop_user_address ");
            strSql.Append(" where address_id=@address_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@address_id", MySqlDbType.Int32,8)			};
            parameters[0].Value = address_id;

            XHD.Model.shop_user_address model = new XHD.Model.shop_user_address();
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
        public XHD.Model.shop_user_address DataRowToModel(DataRow row)
        {
            XHD.Model.shop_user_address model = new XHD.Model.shop_user_address();
            if (row != null)
            {
                if (row["address_id"] != null && row["address_id"].ToString() != "")
                {
                    model.address_id = int.Parse(row["address_id"].ToString());
                }
                if (row["address_name"] != null)
                {
                    model.address_name = row["address_name"].ToString();
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["consignee"] != null)
                {
                    model.consignee = row["consignee"].ToString();
                }
                if (row["email"] != null)
                {
                    model.email = row["email"].ToString();
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
                if (row["district"] != null && row["district"].ToString() != "")
                {
                    model.district = int.Parse(row["district"].ToString());
                }
                if (row["address"] != null)
                {
                    model.address = row["address"].ToString();
                }
                if (row["zipcode"] != null)
                {
                    model.zipcode = row["zipcode"].ToString();
                }
                if (row["tel"] != null)
                {
                    model.tel = row["tel"].ToString();
                }
                if (row["mobile"] != null)
                {
                    model.mobile = row["mobile"].ToString();
                }
                if (row["sign_building"] != null)
                {
                    model.sign_building = row["sign_building"].ToString();
                }
                if (row["best_time"] != null)
                {
                    model.best_time = row["best_time"].ToString();
                }
                if (row["is_default"] != null && row["is_default"].ToString() != "")
                {
                    model.is_default = int.Parse(row["is_default"].ToString());
                }
                if (row["is_invoice"] != null && row["is_invoice"].ToString() != "")
                {
                    model.is_invoice = int.Parse(row["is_invoice"].ToString());
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
            strSql.Append("select address_id,address_name,user_id,consignee,email,country,province,city,district,address,zipcode,tel,mobile,sign_building,best_time,is_default,is_invoice ");
            strSql.Append(" FROM shop_user_address ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAddress(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.address_id,a.address_name,a.user_id,a.consignee,a.email,a.country,a.province,a.city,a.district,a.address,a.zipcode,a.tel,a.mobile,a.sign_building,a.best_time,a.is_default,a.is_invoice, ");
            strSql.Append("  r1.region_name as province_name,r2.region_name as city_name,r3.region_name as district_name");
            strSql.Append(" FROM shop_user_address  as a ");
            strSql.Append(" left join shop_region as r1 on a.province=r1.region_id");
            strSql.Append(" left join shop_region as r2 on a.city=r2.region_id");
            strSql.Append(" left join shop_region as r3 on a.district=r3.region_id");
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
            strSql.Append("select count(1) FROM shop_user_address ");
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
                strSql.Append("order by T.address_id desc");
            }
            strSql.Append(")AS Row, T.*  from shop_user_address T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 取消默认地址
        /// </summary>
        public bool cancelDefault(int user_id)
        {
            string strSql = string.Empty;
            strSql = string.Format("update shop_user_address set is_default=0 where user_id={0}", user_id);
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 设置默认地址
        /// </summary>
        public bool setDefault(int address_id)
        {
            string strSql = string.Empty;
            strSql = string.Format("update shop_user_address set is_default=1 where address_id={0}", address_id);
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 取消发票默认地址
        /// </summary>
        public bool cancelInvoice(int user_id)
        {
            string strSql = string.Empty;
            strSql = string.Format("update shop_user_address set is_invoice=0 where user_id={0}", user_id);
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 设置发票默认地址
        /// </summary>
        public bool setInvoice(int address_id)
        {
            string strSql = string.Empty;
            strSql = string.Format("update shop_user_address set is_invoice=1 where address_id={0}", address_id);
            int rows = Shop_DbHelperMySQL.ExecuteSql(strSql.ToString());
            if (rows >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            parameters[0].Value = "shop_user_address";
            parameters[1].Value = "address_id";
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

