using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XHD.DBUtility;

namespace FMS_DAL
{
    /// <summary>
    /// 数据访问类:wms_voucher
    /// </summary>
    public partial class wms_voucher
    {
        public wms_voucher()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long voucher_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from wms_voucher");
            strSql.Append(" where voucher_id=@voucher_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@voucher_id", MySqlDbType.Int64,20)			};
            parameters[0].Value = voucher_id;

            return Wms_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.wms_voucher model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into wms_voucher(");
            strSql.Append("voucher_id,emp_code,emp_name,voucher_date,order_date,voucher_no,voucher_type,voucher_name,pay_type,pay_name,suppliers_erp_code,suppliers_name,order_sn,pay_money,pay_surplus,sup_money,sup_surplus,inv_money,inv_surplus,need_inv,need_surplus,adjust_money,adjust_surplus,period_money,period_inv,remark,is_del,red_rush,push_erp,push_kingdee,push_finish,day_send)");
            strSql.Append(" values (");
            strSql.Append("@voucher_id,@emp_code,@emp_name,@voucher_date,@order_date,@voucher_no,@voucher_type,@voucher_name,@pay_type,@pay_name,@suppliers_erp_code,@suppliers_name,@order_sn,@pay_money,@pay_surplus,@sup_money,@sup_surplus,@inv_money,@inv_surplus,@need_inv,@need_surplus,@adjust_money,@adjust_surplus,@period_money,@period_inv,@remark,@is_del,@red_rush,@push_erp,@push_kingdee,@push_finish,@day_send)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@voucher_id", MySqlDbType.Int64,20),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@voucher_date", MySqlDbType.DateTime),
					new MySqlParameter("@order_date", MySqlDbType.DateTime),
					new MySqlParameter("@voucher_no", MySqlDbType.VarChar,30),
					new MySqlParameter("@voucher_type", MySqlDbType.Int16,2),
					new MySqlParameter("@voucher_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@pay_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@pay_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,200),
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,50),
					new MySqlParameter("@pay_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@pay_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@sup_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@sup_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@inv_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@inv_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@need_inv", MySqlDbType.Decimal,15),
					new MySqlParameter("@need_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@adjust_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@adjust_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@period_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@period_inv", MySqlDbType.Decimal,15),
					new MySqlParameter("@remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@is_del", MySqlDbType.Int16,2),
					new MySqlParameter("@red_rush", MySqlDbType.Int16,2),
					new MySqlParameter("@push_erp", MySqlDbType.Int16,2),
					new MySqlParameter("@push_kingdee", MySqlDbType.Int16,2),
					new MySqlParameter("@push_finish", MySqlDbType.Int16,2),
					new MySqlParameter("@day_send", MySqlDbType.Int16,2)};
            parameters[0].Value = model.voucher_id;
            parameters[1].Value = model.emp_code;
            parameters[2].Value = model.emp_name;
            parameters[3].Value = model.voucher_date;
            parameters[4].Value = model.order_date;
            parameters[5].Value = model.voucher_no;
            parameters[6].Value = model.voucher_type;
            parameters[7].Value = model.voucher_name;
            parameters[8].Value = model.pay_type;
            parameters[9].Value = model.pay_name;
            parameters[10].Value = model.suppliers_erp_code;
            parameters[11].Value = model.suppliers_name;
            parameters[12].Value = model.order_sn;
            parameters[13].Value = model.pay_money;
            parameters[14].Value = model.pay_surplus;
            parameters[15].Value = model.sup_money;
            parameters[16].Value = model.sup_surplus;
            parameters[17].Value = model.inv_money;
            parameters[18].Value = model.inv_surplus;
            parameters[19].Value = model.need_inv;
            parameters[20].Value = model.need_surplus;
            parameters[21].Value = model.adjust_money;
            parameters[22].Value = model.adjust_surplus;
            parameters[23].Value = model.period_money;
            parameters[24].Value = model.period_inv;
            parameters[25].Value = model.remark;
            parameters[26].Value = model.is_del;
            parameters[27].Value = model.red_rush;
            parameters[28].Value = model.push_erp;
            parameters[29].Value = model.push_kingdee;
            parameters[30].Value = model.push_finish;
            parameters[31].Value = model.day_send;

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
        public bool Update(FMS_Model.wms_voucher model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update wms_voucher set ");
            strSql.Append("emp_code=@emp_code,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("voucher_date=@voucher_date,");
            strSql.Append("order_date=@order_date,");
            strSql.Append("voucher_no=@voucher_no,");
            strSql.Append("voucher_type=@voucher_type,");
            strSql.Append("voucher_name=@voucher_name,");
            strSql.Append("pay_type=@pay_type,");
            strSql.Append("pay_name=@pay_name,");
            strSql.Append("suppliers_erp_code=@suppliers_erp_code,");
            strSql.Append("suppliers_name=@suppliers_name,");
            strSql.Append("order_sn=@order_sn,");
            strSql.Append("pay_money=@pay_money,");
            strSql.Append("pay_surplus=@pay_surplus,");
            strSql.Append("sup_money=@sup_money,");
            strSql.Append("sup_surplus=@sup_surplus,");
            strSql.Append("inv_money=@inv_money,");
            strSql.Append("inv_surplus=@inv_surplus,");
            strSql.Append("need_inv=@need_inv,");
            strSql.Append("need_surplus=@need_surplus,");
            strSql.Append("adjust_money=@adjust_money,");
            strSql.Append("adjust_surplus=@adjust_surplus,");
            strSql.Append("period_money=@period_money,");
            strSql.Append("period_inv=@period_inv,");
            strSql.Append("remark=@remark,");
            strSql.Append("is_del=@is_del,");
            strSql.Append("red_rush=@red_rush,");
            strSql.Append("push_erp=@push_erp,");
            strSql.Append("push_kingdee=@push_kingdee,");
            strSql.Append("push_finish=@push_finish,");
            strSql.Append("day_send=@day_send");
            strSql.Append(" where voucher_id=@voucher_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@voucher_date", MySqlDbType.DateTime),
					new MySqlParameter("@order_date", MySqlDbType.DateTime),
					new MySqlParameter("@voucher_no", MySqlDbType.VarChar,30),
					new MySqlParameter("@voucher_type", MySqlDbType.Int16,2),
					new MySqlParameter("@voucher_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@pay_type", MySqlDbType.VarChar,50),
					new MySqlParameter("@pay_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,200),
					new MySqlParameter("@order_sn", MySqlDbType.VarChar,50),
					new MySqlParameter("@pay_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@pay_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@sup_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@sup_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@inv_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@inv_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@need_inv", MySqlDbType.Decimal,15),
					new MySqlParameter("@need_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@adjust_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@adjust_surplus", MySqlDbType.Decimal,20),
					new MySqlParameter("@period_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@period_inv", MySqlDbType.Decimal,15),
					new MySqlParameter("@remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@is_del", MySqlDbType.Int16,2),
					new MySqlParameter("@red_rush", MySqlDbType.Int16,2),
					new MySqlParameter("@push_erp", MySqlDbType.Int16,2),
					new MySqlParameter("@push_kingdee", MySqlDbType.Int16,2),
					new MySqlParameter("@push_finish", MySqlDbType.Int16,2),
					new MySqlParameter("@day_send", MySqlDbType.Int16,2),
					new MySqlParameter("@voucher_id", MySqlDbType.Int64,20)};
            parameters[0].Value = model.emp_code;
            parameters[1].Value = model.emp_name;
            parameters[2].Value = model.voucher_date;
            parameters[3].Value = model.order_date;
            parameters[4].Value = model.voucher_no;
            parameters[5].Value = model.voucher_type;
            parameters[6].Value = model.voucher_name;
            parameters[7].Value = model.pay_type;
            parameters[8].Value = model.pay_name;
            parameters[9].Value = model.suppliers_erp_code;
            parameters[10].Value = model.suppliers_name;
            parameters[11].Value = model.order_sn;
            parameters[12].Value = model.pay_money;
            parameters[13].Value = model.pay_surplus;
            parameters[14].Value = model.sup_money;
            parameters[15].Value = model.sup_surplus;
            parameters[16].Value = model.inv_money;
            parameters[17].Value = model.inv_surplus;
            parameters[18].Value = model.need_inv;
            parameters[19].Value = model.need_surplus;
            parameters[20].Value = model.adjust_money;
            parameters[21].Value = model.adjust_surplus;
            parameters[22].Value = model.period_money;
            parameters[23].Value = model.period_inv;
            parameters[24].Value = model.remark;
            parameters[25].Value = model.is_del;
            parameters[26].Value = model.red_rush;
            parameters[27].Value = model.push_erp;
            parameters[28].Value = model.push_kingdee;
            parameters[29].Value = model.push_finish;
            parameters[30].Value = model.day_send;
            parameters[31].Value = model.voucher_id;

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
        public bool Delete(long voucher_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from wms_voucher ");
            strSql.Append(" where voucher_id=@voucher_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@voucher_id", MySqlDbType.Int64,20)			};
            parameters[0].Value = voucher_id;

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
        public bool DeleteList(string voucher_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from wms_voucher ");
            strSql.Append(" where voucher_id in (" + voucher_idlist + ")  ");
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
        public FMS_Model.wms_voucher GetModel(long voucher_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select voucher_id,emp_code,emp_name,voucher_date,order_date,voucher_no,voucher_type,voucher_name,pay_type,pay_name,suppliers_erp_code,suppliers_name,order_sn,pay_money,pay_surplus,sup_money,sup_surplus,inv_money,inv_surplus,need_inv,need_surplus,adjust_money,adjust_surplus,period_money,period_inv,remark,is_del,red_rush,push_erp,push_kingdee,push_finish,day_send from wms_voucher ");
            strSql.Append(" where voucher_id=@voucher_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@voucher_id", MySqlDbType.Int64,20)			};
            parameters[0].Value = voucher_id;

            FMS_Model.wms_voucher model = new FMS_Model.wms_voucher();
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
        public FMS_Model.wms_voucher DataRowToModel(DataRow row)
        {
            FMS_Model.wms_voucher model = new FMS_Model.wms_voucher();
            if (row != null)
            {
                if (row["voucher_id"] != null && row["voucher_id"].ToString() != "")
                {
                    model.voucher_id = long.Parse(row["voucher_id"].ToString());
                }
                if (row["emp_code"] != null)
                {
                    model.emp_code = row["emp_code"].ToString();
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["voucher_date"] != null && row["voucher_date"].ToString() != "")
                {
                    model.voucher_date = DateTime.Parse(row["voucher_date"].ToString());
                }
                if (row["order_date"] != null && row["order_date"].ToString() != "")
                {
                    model.order_date = DateTime.Parse(row["order_date"].ToString());
                }
                if (row["voucher_no"] != null)
                {
                    model.voucher_no = row["voucher_no"].ToString();
                }
                if (row["voucher_type"] != null && row["voucher_type"].ToString() != "")
                {
                    model.voucher_type = int.Parse(row["voucher_type"].ToString());
                }
                if (row["voucher_name"] != null)
                {
                    model.voucher_name = row["voucher_name"].ToString();
                }
                if (row["pay_type"] != null)
                {
                    model.pay_type = row["pay_type"].ToString();
                }
                if (row["pay_name"] != null)
                {
                    model.pay_name = row["pay_name"].ToString();
                }
                if (row["suppliers_erp_code"] != null)
                {
                    model.suppliers_erp_code = row["suppliers_erp_code"].ToString();
                }
                if (row["suppliers_name"] != null)
                {
                    model.suppliers_name = row["suppliers_name"].ToString();
                }
                if (row["order_sn"] != null)
                {
                    model.order_sn = row["order_sn"].ToString();
                }
                if (row["pay_money"] != null && row["pay_money"].ToString() != "")
                {
                    model.pay_money = decimal.Parse(row["pay_money"].ToString());
                }
                if (row["pay_surplus"] != null && row["pay_surplus"].ToString() != "")
                {
                    model.pay_surplus = decimal.Parse(row["pay_surplus"].ToString());
                }
                if (row["sup_money"] != null && row["sup_money"].ToString() != "")
                {
                    model.sup_money = decimal.Parse(row["sup_money"].ToString());
                }
                if (row["sup_surplus"] != null && row["sup_surplus"].ToString() != "")
                {
                    model.sup_surplus = decimal.Parse(row["sup_surplus"].ToString());
                }
                if (row["inv_money"] != null && row["inv_money"].ToString() != "")
                {
                    model.inv_money = decimal.Parse(row["inv_money"].ToString());
                }
                if (row["inv_surplus"] != null && row["inv_surplus"].ToString() != "")
                {
                    model.inv_surplus = decimal.Parse(row["inv_surplus"].ToString());
                }
                if (row["need_inv"] != null && row["need_inv"].ToString() != "")
                {
                    model.need_inv = decimal.Parse(row["need_inv"].ToString());
                }
                if (row["need_surplus"] != null && row["need_surplus"].ToString() != "")
                {
                    model.need_surplus = decimal.Parse(row["need_surplus"].ToString());
                }
                if (row["adjust_money"] != null && row["adjust_money"].ToString() != "")
                {
                    model.adjust_money = decimal.Parse(row["adjust_money"].ToString());
                }
                if (row["adjust_surplus"] != null && row["adjust_surplus"].ToString() != "")
                {
                    model.adjust_surplus = decimal.Parse(row["adjust_surplus"].ToString());
                }
                if (row["period_money"] != null && row["period_money"].ToString() != "")
                {
                    model.period_money = decimal.Parse(row["period_money"].ToString());
                }
                if (row["period_inv"] != null && row["period_inv"].ToString() != "")
                {
                    model.period_inv = decimal.Parse(row["period_inv"].ToString());
                }
                if (row["remark"] != null)
                {
                    model.remark = row["remark"].ToString();
                }
                if (row["is_del"] != null && row["is_del"].ToString() != "")
                {
                    model.is_del = int.Parse(row["is_del"].ToString());
                }
                if (row["red_rush"] != null && row["red_rush"].ToString() != "")
                {
                    model.red_rush = int.Parse(row["red_rush"].ToString());
                }
                if (row["push_erp"] != null && row["push_erp"].ToString() != "")
                {
                    model.push_erp = int.Parse(row["push_erp"].ToString());
                }
                if (row["push_kingdee"] != null && row["push_kingdee"].ToString() != "")
                {
                    model.push_kingdee = int.Parse(row["push_kingdee"].ToString());
                }
                if (row["push_finish"] != null && row["push_finish"].ToString() != "")
                {
                    model.push_finish = int.Parse(row["push_finish"].ToString());
                }
                if (row["day_send"] != null && row["day_send"].ToString() != "")
                {
                    model.day_send = int.Parse(row["day_send"].ToString());
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
            strSql.Append("select voucher_id,emp_code,emp_name,voucher_date,order_date,voucher_no,voucher_type,voucher_name,pay_type,pay_name,suppliers_erp_code,suppliers_name,order_sn,pay_money,pay_surplus,sup_money,sup_surplus,inv_money,inv_surplus,need_inv,need_surplus,adjust_money,adjust_surplus,period_money,period_inv,remark,is_del,red_rush,push_erp,push_kingdee,push_finish,day_send ");
            strSql.Append(" FROM wms_voucher ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return Wms_DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM wms_voucher ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = Wms_DbHelperMySQL.GetSingle(strSql.ToString());
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
                strSql.Append("order by T.voucher_id desc");
            }
            strSql.Append(")AS Row, T.*  from wms_voucher T ");
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
            parameters[0].Value = "wms_voucher";
            parameters[1].Value = "voucher_id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return Wms_DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

