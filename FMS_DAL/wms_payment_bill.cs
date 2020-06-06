using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;
using System.Collections.Generic;//Please add references
namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:wms_payment_bill
    /// </summary>
    public partial class wms_payment_bill
    {
        public wms_payment_bill()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long pay_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from wms_payment_bill");
            strSql.Append(" where pay_id=@pay_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_id", MySqlDbType.Int64,20)			};
            parameters[0].Value = pay_id;

            return Wms_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.wms_payment_bill model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into wms_payment_bill(");
            strSql.Append("pay_id,pay_sn,emp_no,emp_name,emp_audit,add_time,v_time,review_time,pay_time,pay_status,review_status,red_rush,pa_no,payment_account,suppliers_erp_code,suppliers_name,ra_no,receive_account,pay_disc,remark,is_del,emp_pay,pay_money)");
            strSql.Append(" values (");
            strSql.Append("@pay_id,@pay_sn,@emp_no,@emp_name,@emp_audit,@add_time,@v_time,@review_time,@pay_time,@pay_status,@review_status,@red_rush,@pa_no,@payment_account,@suppliers_erp_code,@suppliers_name,@ra_no,@receive_account,@pay_disc,@remark,@is_del,@emp_pay,@pay_money)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_id", MySqlDbType.Int64,20),
					new MySqlParameter("@pay_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@emp_audit", MySqlDbType.VarChar,50),
					new MySqlParameter("@add_time", MySqlDbType.DateTime),
					new MySqlParameter("@v_time", MySqlDbType.DateTime),
					new MySqlParameter("@review_time", MySqlDbType.DateTime),
					new MySqlParameter("@pay_time", MySqlDbType.DateTime),
					new MySqlParameter("@pay_status", MySqlDbType.Int16,2),
					new MySqlParameter("@review_status", MySqlDbType.Int16,2),
					new MySqlParameter("@red_rush", MySqlDbType.Int16,2),
					new MySqlParameter("@pa_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@payment_account", MySqlDbType.VarChar,100),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@ra_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@receive_account", MySqlDbType.VarChar,100),
					new MySqlParameter("@pay_disc", MySqlDbType.VarChar,100),
					new MySqlParameter("@remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@is_del", MySqlDbType.Int16,2),
					new MySqlParameter("@emp_pay", MySqlDbType.VarChar,50),
					new MySqlParameter("@pay_money", MySqlDbType.Decimal,12)};
            parameters[0].Value = model.pay_id;
            parameters[1].Value = model.pay_sn;
            parameters[2].Value = model.emp_no;
            parameters[3].Value = model.emp_name;
            parameters[4].Value = model.emp_audit;
            parameters[5].Value = model.add_time;
            parameters[6].Value = model.v_time;
            parameters[7].Value = model.review_time;
            parameters[8].Value = model.pay_time;
            parameters[9].Value = model.pay_status;
            parameters[10].Value = model.review_status;
            parameters[11].Value = model.red_rush;
            parameters[12].Value = model.pa_no;
            parameters[13].Value = model.payment_account;
            parameters[14].Value = model.suppliers_erp_code;
            parameters[15].Value = model.suppliers_name;
            parameters[16].Value = model.ra_no;
            parameters[17].Value = model.receive_account;
            parameters[18].Value = model.pay_disc;
            parameters[19].Value = model.remark;
            parameters[20].Value = model.is_del;
            parameters[21].Value = model.emp_pay;
            parameters[22].Value = model.pay_money;

            int rows = Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(FMS_Model.wms_payment_bill model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update wms_payment_bill set ");
            strSql.Append("pay_sn=@pay_sn,");
            strSql.Append("emp_no=@emp_no,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("emp_audit=@emp_audit,");
            strSql.Append("add_time=@add_time,");
            strSql.Append("v_time=@v_time,");
            strSql.Append("review_time=@review_time,");
            strSql.Append("pay_time=@pay_time,");
            strSql.Append("pay_status=@pay_status,");
            strSql.Append("review_status=@review_status,");
            strSql.Append("red_rush=@red_rush,");
            strSql.Append("pa_no=@pa_no,");
            strSql.Append("payment_account=@payment_account,");
            strSql.Append("suppliers_erp_code=@suppliers_erp_code,");
            strSql.Append("suppliers_name=@suppliers_name,");
            strSql.Append("ra_no=@ra_no,");
            strSql.Append("receive_account=@receive_account,");
            strSql.Append("pay_disc=@pay_disc,");
            strSql.Append("remark=@remark,");
            strSql.Append("is_del=@is_del,");
            strSql.Append("emp_pay=@emp_pay,");
            strSql.Append("pay_money=@pay_money");
            strSql.Append(" where pay_id=@pay_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@emp_audit", MySqlDbType.VarChar,50),
					new MySqlParameter("@add_time", MySqlDbType.DateTime),
					new MySqlParameter("@v_time", MySqlDbType.DateTime),
					new MySqlParameter("@review_time", MySqlDbType.DateTime),
					new MySqlParameter("@pay_time", MySqlDbType.DateTime),
					new MySqlParameter("@pay_status", MySqlDbType.Int16,2),
					new MySqlParameter("@review_status", MySqlDbType.Int16,2),
					new MySqlParameter("@red_rush", MySqlDbType.Int16,2),
					new MySqlParameter("@pa_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@payment_account", MySqlDbType.VarChar,100),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@ra_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@receive_account", MySqlDbType.VarChar,100),
					new MySqlParameter("@pay_disc", MySqlDbType.VarChar,100),
					new MySqlParameter("@remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@is_del", MySqlDbType.Int16,2),
					new MySqlParameter("@emp_pay", MySqlDbType.VarChar,50),
					new MySqlParameter("@pay_money", MySqlDbType.Decimal,12),
					new MySqlParameter("@pay_id", MySqlDbType.Int64,20)};
            parameters[0].Value = model.pay_sn;
            parameters[1].Value = model.emp_no;
            parameters[2].Value = model.emp_name;
            parameters[3].Value = model.emp_audit;
            parameters[4].Value = model.add_time;
            parameters[5].Value = model.v_time;
            parameters[6].Value = model.review_time;
            parameters[7].Value = model.pay_time;
            parameters[8].Value = model.pay_status;
            parameters[9].Value = model.review_status;
            parameters[10].Value = model.red_rush;
            parameters[11].Value = model.pa_no;
            parameters[12].Value = model.payment_account;
            parameters[13].Value = model.suppliers_erp_code;
            parameters[14].Value = model.suppliers_name;
            parameters[15].Value = model.ra_no;
            parameters[16].Value = model.receive_account;
            parameters[17].Value = model.pay_disc;
            parameters[18].Value = model.remark;
            parameters[19].Value = model.is_del;
            parameters[20].Value = model.emp_pay;
            parameters[21].Value = model.pay_money;
            parameters[22].Value = model.pay_id;

            int rows = Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(long pay_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from wms_payment_bill ");
            strSql.Append(" where pay_id=@pay_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_id", MySqlDbType.Int64,20)			};
            parameters[0].Value = pay_id;

            int rows = Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string pay_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from wms_payment_bill ");
            strSql.Append(" where pay_id in (" + pay_idlist + ")  ");
            int rows = Wms_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        public FMS_Model.wms_payment_bill GetModel(long pay_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select pay_id,pay_sn,emp_no,emp_name,emp_audit,add_time,v_time,review_time,pay_time,pay_status,review_status,red_rush,pa_no,payment_account,suppliers_erp_code,suppliers_name,ra_no,receive_account,pay_disc,remark,is_del,emp_pay,pay_money from wms_payment_bill ");
            strSql.Append(" where pay_id=@pay_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@pay_id", MySqlDbType.Int64,20)			};
            parameters[0].Value = pay_id;

            FMS_Model.wms_payment_bill model = new FMS_Model.wms_payment_bill();
            DataSet ds = Wms_DbHelperMySQL.Query(strSql.ToString(), parameters);
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
        public FMS_Model.wms_payment_bill DataRowToModel(DataRow row)
        {
            FMS_Model.wms_payment_bill model = new FMS_Model.wms_payment_bill();
            if (row != null)
            {
                if (row["pay_id"] != null && row["pay_id"].ToString() != "")
                {
                    model.pay_id = long.Parse(row["pay_id"].ToString());
                }
                if (row["pay_sn"] != null)
                {
                    model.pay_sn = row["pay_sn"].ToString();
                }
                if (row["emp_no"] != null)
                {
                    model.emp_no = row["emp_no"].ToString();
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["emp_audit"] != null)
                {
                    model.emp_audit = row["emp_audit"].ToString();
                }
                if (row["add_time"] != null && row["add_time"].ToString() != "")
                {
                    model.add_time = DateTime.Parse(row["add_time"].ToString());
                }
                if (row["v_time"] != null && row["v_time"].ToString() != "")
                {
                    model.v_time = DateTime.Parse(row["v_time"].ToString());
                }
                if (row["review_time"] != null && row["review_time"].ToString() != "")
                {
                    model.review_time = DateTime.Parse(row["review_time"].ToString());
                }
                if (row["pay_time"] != null && row["pay_time"].ToString() != "")
                {
                    model.pay_time = DateTime.Parse(row["pay_time"].ToString());
                }
                if (row["pay_status"] != null && row["pay_status"].ToString() != "")
                {
                    model.pay_status = int.Parse(row["pay_status"].ToString());
                }
                if (row["review_status"] != null && row["review_status"].ToString() != "")
                {
                    model.review_status = int.Parse(row["review_status"].ToString());
                }
                if (row["red_rush"] != null && row["red_rush"].ToString() != "")
                {
                    model.red_rush = int.Parse(row["red_rush"].ToString());
                }
                if (row["pa_no"] != null)
                {
                    model.pa_no = row["pa_no"].ToString();
                }
                if (row["payment_account"] != null)
                {
                    model.payment_account = row["payment_account"].ToString();
                }
                if (row["suppliers_erp_code"] != null)
                {
                    model.suppliers_erp_code = row["suppliers_erp_code"].ToString();
                }
                if (row["suppliers_name"] != null)
                {
                    model.suppliers_name = row["suppliers_name"].ToString();
                }
                if (row["ra_no"] != null)
                {
                    model.ra_no = row["ra_no"].ToString();
                }
                if (row["receive_account"] != null)
                {
                    model.receive_account = row["receive_account"].ToString();
                }
                if (row["pay_disc"] != null)
                {
                    model.pay_disc = row["pay_disc"].ToString();
                }
                if (row["remark"] != null)
                {
                    model.remark = row["remark"].ToString();
                }
                if (row["is_del"] != null && row["is_del"].ToString() != "")
                {
                    model.is_del = int.Parse(row["is_del"].ToString());
                }
                if (row["emp_pay"] != null)
                {
                    model.emp_pay = row["emp_pay"].ToString();
                }
                if (row["pay_money"] != null && row["pay_money"].ToString() != "")
                {
                    model.pay_money = decimal.Parse(row["pay_money"].ToString());
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
            strSql.Append("select pay_id,pay_sn,emp_no,emp_name,emp_audit,add_time,v_time,review_time,pay_time,pay_status,review_status,red_rush,pa_no,payment_account,suppliers_erp_code,suppliers_name,ra_no,receive_account,pay_disc,remark,is_del,emp_pay,pay_money ");
            strSql.Append(" FROM wms_payment_bill ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Wms_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// model_list获取数据集
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<FMS_Model.wms_payment_bill> NewGetList(string strWhere)
        {
            List<FMS_Model.wms_payment_bill> list = new List<FMS_Model.wms_payment_bill>();
            DataSet ds = GetList(strWhere);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    FMS_Model.wms_payment_bill tempbill = new FMS_Model.wms_payment_bill();
                    tempbill = DataRowToModel(dr);
                    list.Add(tempbill);
                }
                return list;
            }
            else
                return null;
            
        }

        ///// <summary>
        ///// 获取记录总数
        ///// </summary>
        //public int GetRecordCount(string strWhere)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select count(1) FROM wms_payment_bill ");
        //    if(strWhere.Trim()!="")
        //    {
        //        strSql.Append(" where "+strWhere);
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
                strSql.Append("order by T.pay_id desc");
            }
            strSql.Append(")AS Row, T.*  from wms_payment_bill T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return Wms_DbHelperMySQL.Query(strSql.ToString());
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
            parameters[0].Value = "wms_payment_bill";
            parameters[1].Value = "pay_id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return Wms_DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod}
    }

}