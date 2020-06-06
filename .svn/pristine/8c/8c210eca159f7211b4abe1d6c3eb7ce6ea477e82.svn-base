using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:fms_supply_bank
    /// </summary>
    public partial class fms_supply_bank
    {
        public fms_supply_bank()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return FMS_DbHelperMySQL.GetMaxID("Id", "fms_supply_bank");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from fms_supply_bank");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            return FMS_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.fms_supply_bank model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fms_supply_bank(");
            strSql.Append("Id,factoryId,suppliers_id,suppliers_code,suppliers_name,supply_bank,supply_bankCode,pay_count,create_Id,create_code,create_name,create_date,Is_stop)");
            strSql.Append(" values (");
            strSql.Append("@Id,@factoryId,@suppliers_id,@suppliers_code,@suppliers_name,@supply_bank,@supply_bankCode,@pay_count,@create_Id,@create_code,@create_name,@create_date,@Is_stop)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@factoryId", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@suppliers_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,300),
					new MySqlParameter("@supply_bank", MySqlDbType.VarChar,100),
					new MySqlParameter("@supply_bankCode", MySqlDbType.VarChar,60),
					new MySqlParameter("@pay_count", MySqlDbType.Int32,11),
					new MySqlParameter("@create_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@Is_stop", MySqlDbType.Int16,1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.factoryId;
            parameters[2].Value = model.suppliers_id;
            parameters[3].Value = model.suppliers_code;
            parameters[4].Value = model.suppliers_name;
            parameters[5].Value = model.supply_bank;
            parameters[6].Value = model.supply_bankCode;
            parameters[7].Value = model.pay_count;
            parameters[8].Value = model.create_Id;
            parameters[9].Value = model.create_code;
            parameters[10].Value = model.create_name;
            parameters[11].Value = model.create_date;
            parameters[12].Value = model.Is_stop;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(FMS_Model.fms_supply_bank model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fms_supply_bank set ");
            strSql.Append("factoryId=@factoryId,");
            strSql.Append("suppliers_id=@suppliers_id,");
            strSql.Append("suppliers_code=@suppliers_code,");
            strSql.Append("suppliers_name=@suppliers_name,");
            strSql.Append("supply_bank=@supply_bank,");
            strSql.Append("supply_bankCode=@supply_bankCode,");
            strSql.Append("pay_count=@pay_count,");
            strSql.Append("create_Id=@create_Id,");
            strSql.Append("create_code=@create_code,");
            strSql.Append("create_name=@create_name,");
            strSql.Append("create_date=@create_date,");
            strSql.Append("Is_stop=@Is_stop");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@factoryId", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_id", MySqlDbType.Int32,11),
					new MySqlParameter("@suppliers_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,300),
					new MySqlParameter("@supply_bank", MySqlDbType.VarChar,100),
					new MySqlParameter("@supply_bankCode", MySqlDbType.VarChar,60),
					new MySqlParameter("@pay_count", MySqlDbType.Int32,11),
					new MySqlParameter("@create_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@create_code", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@Is_stop", MySqlDbType.Int16,1),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.factoryId;
            parameters[1].Value = model.suppliers_id;
            parameters[2].Value = model.suppliers_code;
            parameters[3].Value = model.suppliers_name;
            parameters[4].Value = model.supply_bank;
            parameters[5].Value = model.supply_bankCode;
            parameters[6].Value = model.pay_count;
            parameters[7].Value = model.create_Id;
            parameters[8].Value = model.create_code;
            parameters[9].Value = model.create_name;
            parameters[10].Value = model.create_date;
            parameters[11].Value = model.Is_stop;
            parameters[12].Value = model.Id;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
            strSql.Append("delete from fms_supply_bank ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
            strSql.Append("delete from fms_supply_bank ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = FMS_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public FMS_Model.fms_supply_bank GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factoryId,suppliers_id,suppliers_code,suppliers_name,supply_bank,supply_bankCode,pay_count,create_Id,create_code,create_name,create_date,Is_stop from fms_supply_bank ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            FMS_Model.fms_supply_bank model = new FMS_Model.fms_supply_bank();
            DataSet ds = FMS_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public FMS_Model.fms_supply_bank DataRowToModel(DataRow row)
        {
            FMS_Model.fms_supply_bank model = new FMS_Model.fms_supply_bank();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factoryId"] != null)
                {
                    model.factoryId = row["factoryId"].ToString();
                }
                if (row["suppliers_id"] != null && row["suppliers_id"].ToString() != "")
                {
                    model.suppliers_id = int.Parse(row["suppliers_id"].ToString());
                }
                if (row["suppliers_code"] != null)
                {
                    model.suppliers_code = row["suppliers_code"].ToString();
                }
                if (row["suppliers_name"] != null)
                {
                    model.suppliers_name = row["suppliers_name"].ToString();
                }
                if (row["supply_bank"] != null)
                {
                    model.supply_bank = row["supply_bank"].ToString();
                }
                if (row["supply_bankCode"] != null)
                {
                    model.supply_bankCode = row["supply_bankCode"].ToString();
                }
                if (row["pay_count"] != null && row["pay_count"].ToString() != "")
                {
                    model.pay_count = int.Parse(row["pay_count"].ToString());
                }
                if (row["create_Id"] != null && row["create_Id"].ToString() != "")
                {
                    model.create_Id = int.Parse(row["create_Id"].ToString());
                }
                if (row["create_code"] != null)
                {
                    model.create_code = row["create_code"].ToString();
                }
                if (row["create_name"] != null)
                {
                    model.create_name = row["create_name"].ToString();
                }
                if (row["create_date"] != null && row["create_date"].ToString() != "")
                {
                    model.create_date = DateTime.Parse(row["create_date"].ToString());
                }
                if (row["Is_stop"] != null && row["Is_stop"].ToString() != "")
                {
                    model.Is_stop = int.Parse(row["Is_stop"].ToString());
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
            strSql.Append("select Id,factoryId,suppliers_id,suppliers_code,suppliers_name,supply_bank,supply_bankCode,pay_count,create_Id,create_code,create_name,create_date,Is_stop ");
            strSql.Append(" FROM fms_supply_bank ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return FMS_DbHelperMySQL.Query(strSql.ToString());
        }

        ///// <summary>
        ///// 获取记录总数
        ///// </summary>
        //public int GetRecordCount(string strWhere)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select count(1) FROM fms_supply_bank ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //    }
        //    object obj = DbHelperSQL.GetSingle(strSql.ToString());
        //    if (obj == null)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return Convert.ToInt32(obj);
        //    }
        //}
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
            strSql.Append(")AS Row, T.*  from fms_supply_bank T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return FMS_DbHelperMySQL.Query(strSql.ToString());
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
            parameters[0].Value = "fms_supply_bank";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return FMS_DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
