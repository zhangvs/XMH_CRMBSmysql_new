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
    /// 数据访问类:wms_adjust_bill
    /// </summary>
    public partial class wms_adjust_bill
    {
        public wms_adjust_bill()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long adjust_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from wms_adjust_bill");
            strSql.Append(" where adjust_id=@adjust_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@adjust_id", MySqlDbType.Int64,20)			};
            parameters[0].Value = adjust_id;

            return Wms_DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(FMS_Model.wms_adjust_bill model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into wms_adjust_bill(");
            strSql.Append("adjust_id,adjust_sn,emp_code,emp_name,insert_time,set_time,adj_type,money,suppliers_erp_code,suppliers_name,num_debit,num_credit,account_no,account_name,audit_name,audit_code,remark,status,push_kingdee,is_del)");
            strSql.Append(" values (");
            strSql.Append("@adjust_id,@adjust_sn,@emp_code,@emp_name,@insert_time,@set_time,@adj_type,@money,@suppliers_erp_code,@suppliers_name,@num_debit,@num_credit,@account_no,@account_name,@audit_name,@audit_code,@remark,@status,@push_kingdee,@is_del)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@adjust_id", MySqlDbType.Int64,20),
					new MySqlParameter("@adjust_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@insert_time", MySqlDbType.DateTime),
					new MySqlParameter("@set_time", MySqlDbType.DateTime),
					new MySqlParameter("@adj_type", MySqlDbType.Int16,2),
					new MySqlParameter("@money", MySqlDbType.Decimal,15),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@num_debit", MySqlDbType.VarChar,20),
					new MySqlParameter("@num_credit", MySqlDbType.VarChar,20),
					new MySqlParameter("@account_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@account_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@audit_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@audit_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@status", MySqlDbType.Int16,2),
					new MySqlParameter("@push_kingdee", MySqlDbType.Int16,2),
					new MySqlParameter("@is_del", MySqlDbType.Int16,2)};
            parameters[0].Value = model.adjust_id;
            parameters[1].Value = model.adjust_sn;
            parameters[2].Value = model.emp_code;
            parameters[3].Value = model.emp_name;
            parameters[4].Value = model.insert_time;
            parameters[5].Value = model.set_time;
            parameters[6].Value = model.adj_type;
            parameters[7].Value = model.money;
            parameters[8].Value = model.suppliers_erp_code;
            parameters[9].Value = model.suppliers_name;
            parameters[10].Value = model.num_debit;
            parameters[11].Value = model.num_credit;
            parameters[12].Value = model.account_no;
            parameters[13].Value = model.account_name;
            parameters[14].Value = model.audit_name;
            parameters[15].Value = model.audit_code;
            parameters[16].Value = model.remark;
            parameters[17].Value = model.status;
            parameters[18].Value = model.push_kingdee;
            parameters[19].Value = model.is_del;

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
        public bool Update(FMS_Model.wms_adjust_bill model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update wms_adjust_bill set ");
            strSql.Append("adjust_sn=@adjust_sn,");
            strSql.Append("emp_code=@emp_code,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("insert_time=@insert_time,");
            strSql.Append("set_time=@set_time,");
            strSql.Append("adj_type=@adj_type,");
            strSql.Append("money=@money,");
            strSql.Append("suppliers_erp_code=@suppliers_erp_code,");
            strSql.Append("suppliers_name=@suppliers_name,");
            strSql.Append("num_debit=@num_debit,");
            strSql.Append("num_credit=@num_credit,");
            strSql.Append("account_no=@account_no,");
            strSql.Append("account_name=@account_name,");
            strSql.Append("audit_name=@audit_name,");
            strSql.Append("audit_code=@audit_code,");
            strSql.Append("remark=@remark,");
            strSql.Append("status=@status,");
            strSql.Append("push_kingdee=@push_kingdee,");
            strSql.Append("is_del=@is_del");
            strSql.Append(" where adjust_id=@adjust_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@adjust_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,60),
					new MySqlParameter("@insert_time", MySqlDbType.DateTime),
					new MySqlParameter("@set_time", MySqlDbType.DateTime),
					new MySqlParameter("@adj_type", MySqlDbType.Int16,2),
					new MySqlParameter("@money", MySqlDbType.Decimal,15),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@num_debit", MySqlDbType.VarChar,20),
					new MySqlParameter("@num_credit", MySqlDbType.VarChar,20),
					new MySqlParameter("@account_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@account_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@audit_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@audit_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@status", MySqlDbType.Int16,2),
					new MySqlParameter("@push_kingdee", MySqlDbType.Int16,2),
					new MySqlParameter("@is_del", MySqlDbType.Int16,2),
					new MySqlParameter("@adjust_id", MySqlDbType.Int64,20)};
            parameters[0].Value = model.adjust_sn;
            parameters[1].Value = model.emp_code;
            parameters[2].Value = model.emp_name;
            parameters[3].Value = model.insert_time;
            parameters[4].Value = model.set_time;
            parameters[5].Value = model.adj_type;
            parameters[6].Value = model.money;
            parameters[7].Value = model.suppliers_erp_code;
            parameters[8].Value = model.suppliers_name;
            parameters[9].Value = model.num_debit;
            parameters[10].Value = model.num_credit;
            parameters[11].Value = model.account_no;
            parameters[12].Value = model.account_name;
            parameters[13].Value = model.audit_name;
            parameters[14].Value = model.audit_code;
            parameters[15].Value = model.remark;
            parameters[16].Value = model.status;
            parameters[17].Value = model.push_kingdee;
            parameters[18].Value = model.is_del;
            parameters[19].Value = model.adjust_id;

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
        public bool Delete(long adjust_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from wms_adjust_bill ");
            strSql.Append(" where adjust_id=@adjust_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@adjust_id", MySqlDbType.Int64,20)			};
            parameters[0].Value = adjust_id;

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
        public bool DeleteList(string adjust_idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from wms_adjust_bill ");
            strSql.Append(" where adjust_id in (" + adjust_idlist + ")  ");
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
        public FMS_Model.wms_adjust_bill GetModel(long adjust_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select adjust_id,adjust_sn,emp_code,emp_name,insert_time,set_time,adj_type,money,suppliers_erp_code,suppliers_name,num_debit,num_credit,account_no,account_name,audit_name,audit_code,remark,status,push_kingdee,is_del from wms_adjust_bill ");
            strSql.Append(" where adjust_id=@adjust_id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@adjust_id", MySqlDbType.Int64,20)			};
            parameters[0].Value = adjust_id;

            FMS_Model.wms_adjust_bill model = new FMS_Model.wms_adjust_bill();
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
        public FMS_Model.wms_adjust_bill DataRowToModel(DataRow row)
        {
            FMS_Model.wms_adjust_bill model = new FMS_Model.wms_adjust_bill();
            if (row != null)
            {
                if (row["adjust_id"] != null && row["adjust_id"].ToString() != "")
                {
                    model.adjust_id = long.Parse(row["adjust_id"].ToString());
                }
                if (row["adjust_sn"] != null)
                {
                    model.adjust_sn = row["adjust_sn"].ToString();
                }
                if (row["emp_code"] != null)
                {
                    model.emp_code = row["emp_code"].ToString();
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["insert_time"] != null && row["insert_time"].ToString() != "")
                {
                    model.insert_time = DateTime.Parse(row["insert_time"].ToString());
                }
                if (row["set_time"] != null && row["set_time"].ToString() != "")
                {
                    model.set_time = DateTime.Parse(row["set_time"].ToString());
                }
                if (row["adj_type"] != null && row["adj_type"].ToString() != "")
                {
                    model.adj_type = int.Parse(row["adj_type"].ToString());
                }
                if (row["money"] != null && row["money"].ToString() != "")
                {
                    model.money = decimal.Parse(row["money"].ToString());
                }
                if (row["suppliers_erp_code"] != null)
                {
                    model.suppliers_erp_code = row["suppliers_erp_code"].ToString();
                }
                if (row["suppliers_name"] != null)
                {
                    model.suppliers_name = row["suppliers_name"].ToString();
                }
                if (row["num_debit"] != null)
                {
                    model.num_debit = row["num_debit"].ToString();
                }
                if (row["num_credit"] != null)
                {
                    model.num_credit = row["num_credit"].ToString();
                }
                if (row["account_no"] != null)
                {
                    model.account_no = row["account_no"].ToString();
                }
                if (row["account_name"] != null)
                {
                    model.account_name = row["account_name"].ToString();
                }
                if (row["audit_name"] != null)
                {
                    model.audit_name = row["audit_name"].ToString();
                }
                if (row["audit_code"] != null)
                {
                    model.audit_code = row["audit_code"].ToString();
                }
                if (row["remark"] != null)
                {
                    model.remark = row["remark"].ToString();
                }
                if (row["status"] != null && row["status"].ToString() != "")
                {
                    model.status = int.Parse(row["status"].ToString());
                }
                if (row["push_kingdee"] != null && row["push_kingdee"].ToString() != "")
                {
                    model.push_kingdee = int.Parse(row["push_kingdee"].ToString());
                }
                if (row["is_del"] != null && row["is_del"].ToString() != "")
                {
                    model.is_del = int.Parse(row["is_del"].ToString());
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
            strSql.Append("select adjust_id,adjust_sn,emp_code,emp_name,insert_time,set_time,adj_type,money,suppliers_erp_code,suppliers_name,num_debit,num_credit,account_no,account_name,audit_name,audit_code,remark,status,push_kingdee,is_del ");
            strSql.Append(" FROM wms_adjust_bill ");
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
            strSql.Append("select count(1) FROM wms_adjust_bill ");
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
                strSql.Append("order by T.adjust_id desc");
            }
            strSql.Append(")AS Row, T.*  from wms_adjust_bill T ");
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
            parameters[0].Value = "wms_adjust_bill";
            parameters[1].Value = "adjust_id";
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

