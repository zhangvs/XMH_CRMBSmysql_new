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
	/// 数据访问类:wms_invoice_order
	/// </summary>
	public partial class wms_invoice_order
	{
		public wms_invoice_order()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long inv_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from wms_invoice_order");
			strSql.Append(" where inv_id=@inv_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@inv_id", MySqlDbType.Int64,20)			};
			parameters[0].Value = inv_id;

			return Wms_DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FMS_Model.wms_invoice_order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into wms_invoice_order(");
			strSql.Append("inv_id,inv_sn,inv_list,inv_time,set_time,audit_time,account_no,account_name,suppliers_erp_code,suppliers_name,emp_name,emp_code,audit_name,audit_code,total_money,tax_money,ntax_money,remark,inv_status,push_erp,is_del,red_rush)");
			strSql.Append(" values (");
			strSql.Append("@inv_id,@inv_sn,@inv_list,@inv_time,@set_time,@audit_time,@account_no,@account_name,@suppliers_erp_code,@suppliers_name,@emp_name,@emp_code,@audit_name,@audit_code,@total_money,@tax_money,@ntax_money,@remark,@inv_status,@push_erp,@is_del,@red_rush)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@inv_id", MySqlDbType.Int64,20),
					new MySqlParameter("@inv_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@inv_list", MySqlDbType.VarChar,60),
					new MySqlParameter("@inv_time", MySqlDbType.DateTime),
					new MySqlParameter("@set_time", MySqlDbType.DateTime),
					new MySqlParameter("@audit_time", MySqlDbType.DateTime),
					new MySqlParameter("@account_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@account_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,200),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@audit_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@audit_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@total_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@tax_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@ntax_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@inv_status", MySqlDbType.Int16,2),
					new MySqlParameter("@push_erp", MySqlDbType.Int16,2),
					new MySqlParameter("@is_del", MySqlDbType.Int16,2),
					new MySqlParameter("@red_rush", MySqlDbType.Int16,2)};
			parameters[0].Value = model.inv_id;
			parameters[1].Value = model.inv_sn;
			parameters[2].Value = model.inv_list;
			parameters[3].Value = model.inv_time;
			parameters[4].Value = model.set_time;
			parameters[5].Value = model.audit_time;
			parameters[6].Value = model.account_no;
			parameters[7].Value = model.account_name;
			parameters[8].Value = model.suppliers_erp_code;
			parameters[9].Value = model.suppliers_name;
			parameters[10].Value = model.emp_name;
			parameters[11].Value = model.emp_code;
			parameters[12].Value = model.audit_name;
			parameters[13].Value = model.audit_code;
			parameters[14].Value = model.total_money;
			parameters[15].Value = model.tax_money;
			parameters[16].Value = model.ntax_money;
			parameters[17].Value = model.remark;
			parameters[18].Value = model.inv_status;
			parameters[19].Value = model.push_erp;
			parameters[20].Value = model.is_del;
			parameters[21].Value = model.red_rush;

			int rows=Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(FMS_Model.wms_invoice_order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update wms_invoice_order set ");
			strSql.Append("inv_sn=@inv_sn,");
			strSql.Append("inv_list=@inv_list,");
			strSql.Append("inv_time=@inv_time,");
			strSql.Append("set_time=@set_time,");
			strSql.Append("audit_time=@audit_time,");
			strSql.Append("account_no=@account_no,");
			strSql.Append("account_name=@account_name,");
			strSql.Append("suppliers_erp_code=@suppliers_erp_code,");
			strSql.Append("suppliers_name=@suppliers_name,");
			strSql.Append("emp_name=@emp_name,");
			strSql.Append("emp_code=@emp_code,");
			strSql.Append("audit_name=@audit_name,");
			strSql.Append("audit_code=@audit_code,");
			strSql.Append("total_money=@total_money,");
			strSql.Append("tax_money=@tax_money,");
			strSql.Append("ntax_money=@ntax_money,");
			strSql.Append("remark=@remark,");
			strSql.Append("inv_status=@inv_status,");
			strSql.Append("push_erp=@push_erp,");
			strSql.Append("is_del=@is_del,");
			strSql.Append("red_rush=@red_rush");
			strSql.Append(" where inv_id=@inv_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@inv_sn", MySqlDbType.VarChar,20),
					new MySqlParameter("@inv_list", MySqlDbType.VarChar,60),
					new MySqlParameter("@inv_time", MySqlDbType.DateTime),
					new MySqlParameter("@set_time", MySqlDbType.DateTime),
					new MySqlParameter("@audit_time", MySqlDbType.DateTime),
					new MySqlParameter("@account_no", MySqlDbType.VarChar,20),
					new MySqlParameter("@account_name", MySqlDbType.VarChar,100),
					new MySqlParameter("@suppliers_erp_code", MySqlDbType.VarChar,50),
					new MySqlParameter("@suppliers_name", MySqlDbType.VarChar,200),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@emp_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@audit_name", MySqlDbType.VarChar,50),
					new MySqlParameter("@audit_code", MySqlDbType.VarChar,20),
					new MySqlParameter("@total_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@tax_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@ntax_money", MySqlDbType.Decimal,15),
					new MySqlParameter("@remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@inv_status", MySqlDbType.Int16,2),
					new MySqlParameter("@push_erp", MySqlDbType.Int16,2),
					new MySqlParameter("@is_del", MySqlDbType.Int16,2),
					new MySqlParameter("@red_rush", MySqlDbType.Int16,2),
					new MySqlParameter("@inv_id", MySqlDbType.Int64,20)};
			parameters[0].Value = model.inv_sn;
			parameters[1].Value = model.inv_list;
			parameters[2].Value = model.inv_time;
			parameters[3].Value = model.set_time;
			parameters[4].Value = model.audit_time;
			parameters[5].Value = model.account_no;
			parameters[6].Value = model.account_name;
			parameters[7].Value = model.suppliers_erp_code;
			parameters[8].Value = model.suppliers_name;
			parameters[9].Value = model.emp_name;
			parameters[10].Value = model.emp_code;
			parameters[11].Value = model.audit_name;
			parameters[12].Value = model.audit_code;
			parameters[13].Value = model.total_money;
			parameters[14].Value = model.tax_money;
			parameters[15].Value = model.ntax_money;
			parameters[16].Value = model.remark;
			parameters[17].Value = model.inv_status;
			parameters[18].Value = model.push_erp;
			parameters[19].Value = model.is_del;
			parameters[20].Value = model.red_rush;
			parameters[21].Value = model.inv_id;

			int rows=Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(long inv_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from wms_invoice_order ");
			strSql.Append(" where inv_id=@inv_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@inv_id", MySqlDbType.Int64,20)			};
			parameters[0].Value = inv_id;

			int rows=Wms_DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string inv_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from wms_invoice_order ");
			strSql.Append(" where inv_id in ("+inv_idlist + ")  ");
			int rows=Wms_DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		public FMS_Model.wms_invoice_order GetModel(long inv_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select inv_id,inv_sn,inv_list,inv_time,set_time,audit_time,account_no,account_name,suppliers_erp_code,suppliers_name,emp_name,emp_code,audit_name,audit_code,total_money,tax_money,ntax_money,remark,inv_status,push_erp,is_del,red_rush from wms_invoice_order ");
			strSql.Append(" where inv_id=@inv_id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@inv_id", MySqlDbType.Int64,20)			};
			parameters[0].Value = inv_id;

			FMS_Model.wms_invoice_order model=new FMS_Model.wms_invoice_order();
			DataSet ds=Wms_DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public FMS_Model.wms_invoice_order DataRowToModel(DataRow row)
		{
			FMS_Model.wms_invoice_order model=new FMS_Model.wms_invoice_order();
			if (row != null)
			{
				if(row["inv_id"]!=null && row["inv_id"].ToString()!="")
				{
					model.inv_id=long.Parse(row["inv_id"].ToString());
				}
				if(row["inv_sn"]!=null)
				{
					model.inv_sn=row["inv_sn"].ToString();
				}
				if(row["inv_list"]!=null)
				{
					model.inv_list=row["inv_list"].ToString();
				}
				if(row["inv_time"]!=null && row["inv_time"].ToString()!="")
				{
					model.inv_time=DateTime.Parse(row["inv_time"].ToString());
				}
				if(row["set_time"]!=null && row["set_time"].ToString()!="")
				{
					model.set_time=DateTime.Parse(row["set_time"].ToString());
				}
				if(row["audit_time"]!=null && row["audit_time"].ToString()!="")
				{
					model.audit_time=DateTime.Parse(row["audit_time"].ToString());
				}
				if(row["account_no"]!=null)
				{
					model.account_no=row["account_no"].ToString();
				}
				if(row["account_name"]!=null)
				{
					model.account_name=row["account_name"].ToString();
				}
				if(row["suppliers_erp_code"]!=null)
				{
					model.suppliers_erp_code=row["suppliers_erp_code"].ToString();
				}
				if(row["suppliers_name"]!=null)
				{
					model.suppliers_name=row["suppliers_name"].ToString();
				}
				if(row["emp_name"]!=null)
				{
					model.emp_name=row["emp_name"].ToString();
				}
				if(row["emp_code"]!=null)
				{
					model.emp_code=row["emp_code"].ToString();
				}
				if(row["audit_name"]!=null)
				{
					model.audit_name=row["audit_name"].ToString();
				}
				if(row["audit_code"]!=null)
				{
					model.audit_code=row["audit_code"].ToString();
				}
				if(row["total_money"]!=null && row["total_money"].ToString()!="")
				{
					model.total_money=decimal.Parse(row["total_money"].ToString());
				}
				if(row["tax_money"]!=null && row["tax_money"].ToString()!="")
				{
					model.tax_money=decimal.Parse(row["tax_money"].ToString());
				}
				if(row["ntax_money"]!=null && row["ntax_money"].ToString()!="")
				{
					model.ntax_money=decimal.Parse(row["ntax_money"].ToString());
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["inv_status"]!=null && row["inv_status"].ToString()!="")
				{
					model.inv_status=int.Parse(row["inv_status"].ToString());
				}
				if(row["push_erp"]!=null && row["push_erp"].ToString()!="")
				{
					model.push_erp=int.Parse(row["push_erp"].ToString());
				}
				if(row["is_del"]!=null && row["is_del"].ToString()!="")
				{
					model.is_del=int.Parse(row["is_del"].ToString());
				}
				if(row["red_rush"]!=null && row["red_rush"].ToString()!="")
				{
					model.red_rush=int.Parse(row["red_rush"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select inv_id,inv_sn,inv_list,inv_time,set_time,audit_time,account_no,account_name,suppliers_erp_code,suppliers_name,emp_name,emp_code,audit_name,audit_code,total_money,tax_money,ntax_money,remark,inv_status,push_erp,is_del,red_rush ");
			strSql.Append(" FROM wms_invoice_order ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return Wms_DbHelperMySQL.Query(strSql.ToString());
		}



        /// <summary>
        /// model_list获取数据集
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<FMS_Model.wms_invoice_order> NewGetList(string strWhere)
        {
            List<FMS_Model.wms_invoice_order> list = new List<FMS_Model.wms_invoice_order>();
            DataSet ds = GetList(strWhere);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    FMS_Model.wms_invoice_order tempbill = new FMS_Model.wms_invoice_order();
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
        //    strSql.Append("select count(1) FROM wms_invoice_order ");
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.inv_id desc");
			}
			strSql.Append(")AS Row, T.*  from wms_invoice_order T ");
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
			parameters[0].Value = "wms_invoice_order";
			parameters[1].Value = "inv_id";
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

