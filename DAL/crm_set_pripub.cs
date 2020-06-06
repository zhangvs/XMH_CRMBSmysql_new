using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_set_pripub
    /// </summary>
    public partial class crm_set_pripub
    {
        public crm_set_pripub()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "crm_set_pripub");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_set_pripub");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_set_pripub");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_set_pripub model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_set_pripub(");
            strSql.Append("Id,factory_Id,current_year,pri_Year,pri_Season,pri_Month,pri_Week,pri_Time,C_createId,C_createName,C_createDate)");
            strSql.Append(" values (");
            strSql.Append("@Id,@factory_Id,@current_year,@pri_Year,@pri_Season,@pri_Month,@pri_Week,@pri_Time,@C_createId,@C_createName,@C_createDate)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@current_year", MySqlDbType.Int32,4),
					new MySqlParameter("@pri_Year", MySqlDbType.VarChar,1),
					new MySqlParameter("@pri_Season", MySqlDbType.VarChar,1),
					new MySqlParameter("@pri_Month", MySqlDbType.VarChar,1),
					new MySqlParameter("@pri_Week", MySqlDbType.VarChar,1),
					new MySqlParameter("@pri_Time", MySqlDbType.VarChar,1),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.factory_Id;
            parameters[2].Value = model.current_year;
            parameters[3].Value = model.pri_Year;
            parameters[4].Value = model.pri_Season;
            parameters[5].Value = model.pri_Month;
            parameters[6].Value = model.pri_Week;
            parameters[7].Value = model.pri_Time;
            parameters[8].Value = model.C_createId;
            parameters[9].Value = model.C_createName;
            parameters[10].Value = model.C_createDate;

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
        public bool Update(XHD.Model.crm_set_pripub model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_set_pripub set ");
            strSql.Append("current_year=@current_year,");
            strSql.Append("pri_Year=@pri_Year,");
            strSql.Append("pri_Season=@pri_Season,");
            strSql.Append("pri_Month=@pri_Month,");
            strSql.Append("pri_Week=@pri_Week,");
            strSql.Append("pri_Time=@pri_Time,");
            strSql.Append("C_createId=@C_createId,");
            strSql.Append("C_createName=@C_createName,");
            strSql.Append("C_createDate=@C_createDate");
            strSql.Append(" where factory_Id=@factory_Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@current_year", MySqlDbType.Int32,4),
					new MySqlParameter("@pri_Year", MySqlDbType.VarChar,1),
					new MySqlParameter("@pri_Season", MySqlDbType.VarChar,1),
					new MySqlParameter("@pri_Month", MySqlDbType.VarChar,1),
					new MySqlParameter("@pri_Week", MySqlDbType.VarChar,1),
					new MySqlParameter("@pri_Time", MySqlDbType.VarChar,1),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createName", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@factory_Id", MySqlDbType.VarChar,60)};
            parameters[0].Value = model.current_year;
            parameters[1].Value = model.pri_Year;
            parameters[2].Value = model.pri_Season;
            parameters[3].Value = model.pri_Month;
            parameters[4].Value = model.pri_Week;
            parameters[5].Value = model.pri_Time;
            parameters[6].Value = model.C_createId;
            parameters[7].Value = model.C_createName;
            parameters[8].Value = model.C_createDate;
            parameters[9].Value = model.factory_Id;

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
            strSql.Append("delete from crm_set_pripub ");
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
            strSql.Append("delete from crm_set_pripub ");
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
        public XHD.Model.crm_set_pripub GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,factory_Id,current_year,pri_Year,pri_Season,pri_Month,pri_Week,pri_Time,C_createId,C_createName,C_createDate from crm_set_pripub ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            XHD.Model.crm_set_pripub model = new XHD.Model.crm_set_pripub();
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
        public XHD.Model.crm_set_pripub DataRowToModel(DataRow row)
        {
            XHD.Model.crm_set_pripub model = new XHD.Model.crm_set_pripub();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["factory_Id"] != null)
                {
                    model.factory_Id = row["factory_Id"].ToString();
                }
                if (row["current_year"] != null && row["current_year"].ToString() != "")
                {
                    model.current_year = int.Parse(row["current_year"].ToString());
                }
                if (row["pri_Year"] != null)
                {
                    model.pri_Year = row["pri_Year"].ToString();
                }
                if (row["pri_Season"] != null)
                {
                    model.pri_Season = row["pri_Season"].ToString();
                }
                if (row["pri_Month"] != null)
                {
                    model.pri_Month = row["pri_Month"].ToString();
                }
                if (row["pri_Week"] != null)
                {
                    model.pri_Week = row["pri_Week"].ToString();
                }
                if (row["pri_Time"] != null)
                {
                    model.pri_Time = row["pri_Time"].ToString();
                }
                if (row["C_createId"] != null && row["C_createId"].ToString() != "")
                {
                    model.C_createId = int.Parse(row["C_createId"].ToString());
                }
                if (row["C_createName"] != null)
                {
                    model.C_createName = row["C_createName"].ToString();
                }
                if (row["C_createDate"] != null && row["C_createDate"].ToString() != "")
                {
                    model.C_createDate = DateTime.Parse(row["C_createDate"].ToString());
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
            strSql.Append("select Id,factory_Id,current_year,pri_Year,pri_Season,pri_Month,pri_Week,pri_Time,C_createId,C_createName,C_createDate ");
            strSql.Append(" FROM crm_set_pripub ");
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
            strSql.Append("select count(1) FROM crm_set_pripub ");
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
            strSql.Append(")AS Row, T.*  from crm_set_pripub T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #region 获取转移数据
        /*
        /// <summary>
        /// 获取转移数据>>
        /// </summary>
        */
        public DataSet GetTransferId(DateTime start, int end, string empid, string facoty_id, decimal feat)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("  select c.id from crm_customer as c ");
            strSql.Append("  where c.Create_date <'" + start + "'");
            strSql.Append("  and c.privatecustomer_Id=52");
            strSql.Append("  and c.privatecustomer='私客'");
            strSql.Append("  and c.factory_id = '" + facoty_id + "'");
            strSql.Append("  and c.BeSeats_id in (" + empid + ")");
            strSql.Append("   and c.id not in");
            strSql.Append("  (select p.Customer_id as id from crm_customer_protect as p");
            strSql.Append("  where p.apply_etime>='" + end + "' and p.isInvalid=0 and p.isSucceed=1) ");
            strSql.Append("   and c.id not in");
            strSql.Append("  (select of.customer_Id as id from crm_order_feat as of)");
            strSql.Append("   UNION ALL	   ");
            strSql.Append(" select c.id from crm_customer as c inner join (select fe.Customer_id ,sum(fe.order_feat ) as a,IFNULL(sum(fe.sales_return),0)  as b from crm_order_feat  as fe group by fe.Customer_id ) as cc on  cc.Customer_id=c.id  and  (cc.a +cc.b)<" + feat);
            strSql.Append(" where c.Create_date <'" + start + "'");
            strSql.Append(" and c.privatecustomer_Id=52");
            strSql.Append(" and c.privatecustomer='私客'");
            strSql.Append(" and c.BeSeats_id in (" + empid + ")");
            strSql.Append(" and c.factory_id = '" + facoty_id + "'");
            strSql.Append("  and c.id not in");
            strSql.Append(" (select p.Customer_id as id from crm_customer_protect as p");
            strSql.Append(" where p.apply_etime>='" + end + "' and p.isInvalid=0 and p.isSucceed=1)");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion

        #region 更新客户状态为公客
        public bool UpdateCustomerStatus(string idlist, string factory_Id, int statusId, string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer set ");
            strSql.Append("privatecustomer_Id=" + statusId + ", ");
            strSql.Append("privatecustomer='" + status + "' ");
            strSql.Append(" where id in(" + idlist + ")");
            strSql.Append(" and Factory_Id='" + factory_Id + "'");

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
        #endregion

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
            parameters[0].Value = "crm_set_pripub";
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

