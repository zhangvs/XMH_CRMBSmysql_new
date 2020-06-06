using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:shop_progress_payments
    /// </summary>
    public partial class shop_progress_payments
    {
        public shop_progress_payments()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return Shop_DbHelperMySQL.GetMaxID("id", "shop_progress_payments");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from shop_progress_payments");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            return Shop_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FMS_Model.shop_progress_payments model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into shop_progress_payments(");
            strSql.Append("id,type,order_sn,add_time,money,user_id,employee_id,emp_code,msg,status,start_valid_time,user_yingshou)");
            strSql.Append(" values (");
            strSql.Append("@id,@type,@order_sn,@add_time,@money,@user_id,@employee_id,@emp_code,@msg,@status,@start_valid_time,@user_yingshou)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11),
					new MySqlParameter("@type", MySqlDbType.Int16,2),
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@money", MySqlDbType.Decimal,11),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@employee_id", MySqlDbType.Int32,8),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,10),
					new MySqlParameter("@msg", MySqlDbType.VarChar,300),
					new MySqlParameter("@status", MySqlDbType.Int16,2),
					new MySqlParameter("@start_valid_time", MySqlDbType.Int32,11),
					new MySqlParameter("@user_yingshou", MySqlDbType.Decimal,11)};
            parameters[0].Value = model.id;
            parameters[1].Value = model.type;
            parameters[2].Value = model.order_sn;
            parameters[3].Value = model.add_time;
            parameters[4].Value = model.money;
            parameters[5].Value = model.user_id;
            parameters[6].Value = model.employee_id;
            parameters[7].Value = model.emp_code;
            parameters[8].Value = model.msg;
            parameters[9].Value = model.status;
            parameters[10].Value = model.start_valid_time;
            parameters[11].Value = model.user_yingshou;

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
        public bool Update(FMS_Model.shop_progress_payments model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update shop_progress_payments set ");
            strSql.Append("type=@type,");
            strSql.Append("order_sn=@order_sn,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("money=@money,");
            strSql.Append("user_id=@user_id,");
            strSql.Append("employee_id=@employee_id,");
            strSql.Append("emp_code=@emp_code,");
            strSql.Append("msg=@msg,");
            strSql.Append("status=@status,");
            strSql.Append("start_valid_time=@start_valid_time,");
            strSql.Append("user_yingshou=@user_yingshou");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@type", MySqlDbType.Int16,2),
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@add_time", MySqlDbType.Int32,11),
					new MySqlParameter("@money", MySqlDbType.Decimal,11),
					new MySqlParameter("@user_id", MySqlDbType.Int32,11),
					new MySqlParameter("@employee_id", MySqlDbType.Int32,8),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,10),
					new MySqlParameter("@msg", MySqlDbType.VarChar,300),
					new MySqlParameter("@status", MySqlDbType.Int16,2),
					new MySqlParameter("@start_valid_time", MySqlDbType.Int32,11),
					new MySqlParameter("@user_yingshou", MySqlDbType.Decimal,11),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.type;
            parameters[1].Value = model.order_sn;
            parameters[2].Value = model.add_time;
            parameters[3].Value = model.money;
            parameters[4].Value = model.user_id;
            parameters[5].Value = model.employee_id;
            parameters[6].Value = model.emp_code;
            parameters[7].Value = model.msg;
            parameters[8].Value = model.status;
            parameters[9].Value = model.start_valid_time;
            parameters[10].Value = model.user_yingshou;
            parameters[11].Value = model.id;

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
            strSql.Append("delete from shop_progress_payments ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
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
            strSql.Append("delete from shop_progress_payments ");
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
        public FMS_Model.shop_progress_payments GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,type,order_sn,add_time,money,user_id,employee_id,emp_code,msg,status,start_valid_time,user_yingshou from shop_progress_payments ");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,11)			};
            parameters[0].Value = id;

            FMS_Model.shop_progress_payments model = new FMS_Model.shop_progress_payments();
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
        public FMS_Model.shop_progress_payments DataRowToModel(DataRow row)
        {
            FMS_Model.shop_progress_payments model = new FMS_Model.shop_progress_payments();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["type"] != null && row["type"].ToString() != "")
                {
                    model.type = int.Parse(row["type"].ToString());
                }
                if (row["order_sn"] != null)
                {
                    model.order_sn = row["order_sn"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = int.Parse(row["add_time"].ToString());
                }
                if (row["money"] != null && row["money"].ToString() != "")
                {
                    model.money = decimal.Parse(row["money"].ToString());
                }
                if (row["user_id"] != null && row["user_id"].ToString() != "")
                {
                    model.user_id = int.Parse(row["user_id"].ToString());
                }
                if (row["employee_id"] != null && row["employee_id"].ToString() != "")
                {
                    model.employee_id = int.Parse(row["employee_id"].ToString());
                }
                if (row["emp_code"] != null)
                {
                    model.emp_code = row["emp_code"].ToString();
                }
                if (row["msg"] != null)
                {
                    model.msg = row["msg"].ToString();
                }
                if (row["status"] != null && row["status"].ToString() != "")
                {
                    model.status = int.Parse(row["status"].ToString());
                }
                if (row["start_valid_time"] != null && row["start_valid_time"].ToString() != "")
                {
                    model.start_valid_time = int.Parse(row["start_valid_time"].ToString());
                }
                if (row["user_yingshou"] != null && row["user_yingshou"].ToString() != "")
                {
                    model.user_yingshou = decimal.Parse(row["user_yingshou"].ToString());
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
            strSql.Append("select id,type,order_sn,add_time,money,user_id,employee_id,emp_code,msg,status,start_valid_time,user_yingshou ");
            strSql.Append(" FROM shop_progress_payments ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetLists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,type,order_sn,add_time,money,user_id,employee_id,emp_code,msg,status,start_valid_time,user_yingshou ");
            strSql.Append(" FROM shop_progress_payments ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by id desc limit 1");

            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetMoney(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select user_id,sum(money) as money,type ");
            strSql.Append(" FROM shop_progress_payments ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" GROUP BY type ");
            return Shop_DbHelperMySQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

