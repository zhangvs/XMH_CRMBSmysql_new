using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// ���ݷ�����:CRM_order
	/// </summary>
	public partial class CRM_order
	{
		public CRM_order()
		{}
		#region  Method

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "CRM_order"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CRM_order");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(XHD.Model.CRM_order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CRM_order(");
			strSql.Append("Serialnumber,Customer_id,Customer_name,Order_date,pay_type_id,pay_type,Order_details,Order_status_id,Order_status,Order_amount,create_id,create_date,C_dep_id,C_dep_name,C_emp_id,C_emp_name,F_dep_id,F_dep_name,F_emp_id,F_emp_name,receive_money,arrears_money,invoice_money,arrears_invoice,isDelete,Delete_time)");
			strSql.Append(" values (");
			strSql.Append("@Serialnumber,@Customer_id,@Customer_name,@Order_date,@pay_type_id,@pay_type,@Order_details,@Order_status_id,@Order_status,@Order_amount,@create_id,@create_date,@C_dep_id,@C_dep_name,@C_emp_id,@C_emp_name,@F_dep_id,@F_dep_name,@F_emp_id,@F_emp_name,@receive_money,@arrears_money,@invoice_money,@arrears_invoice,@isDelete,@Delete_time)");
			strSql.Append(";select @@IDENTITY");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Serialnumber", MySqlDbType.VarChar,250),
					new MySqlParameter("@Customer_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Customer_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@Order_date", MySqlDbType.DateTime),
					new MySqlParameter("@pay_type_id", MySqlDbType.Int32,4),
					new MySqlParameter("@pay_type", MySqlDbType.VarChar,250),
					new MySqlParameter("@Order_details", MySqlDbType.VarChar),
					new MySqlParameter("@Order_status_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Order_status", MySqlDbType.VarChar,250),
					new MySqlParameter("@Order_amount", MySqlDbType.Float,8),
					new MySqlParameter("@create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@create_date", MySqlDbType.DateTime),
					new MySqlParameter("@C_dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@C_dep_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_emp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@C_emp_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@F_dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@F_dep_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@F_emp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@F_emp_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@receive_money", MySqlDbType.Float,8),
					new MySqlParameter("@arrears_money", MySqlDbType.Float,8),
					new MySqlParameter("@invoice_money", MySqlDbType.Float,8),
					new MySqlParameter("@arrears_invoice", MySqlDbType.Float,8),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,4),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime)};
			parameters[0].Value = model.Serialnumber;
			parameters[1].Value = model.Customer_id;
			parameters[2].Value = model.Customer_name;
			parameters[3].Value = model.Order_date;
			parameters[4].Value = model.pay_type_id;
			parameters[5].Value = model.pay_type;
			parameters[6].Value = model.Order_details;
			parameters[7].Value = model.Order_status_id;
			parameters[8].Value = model.Order_status;
			parameters[9].Value = model.Order_amount;
			parameters[10].Value = model.create_id;
			parameters[11].Value = model.create_date;
			parameters[12].Value = model.C_dep_id;
			parameters[13].Value = model.C_dep_name;
			parameters[14].Value = model.C_emp_id;
			parameters[15].Value = model.C_emp_name;
			parameters[16].Value = model.F_dep_id;
			parameters[17].Value = model.F_dep_name;
			parameters[18].Value = model.F_emp_id;
			parameters[19].Value = model.F_emp_name;
			parameters[20].Value = model.receive_money;
			parameters[21].Value = model.arrears_money;
			parameters[22].Value = model.invoice_money;
			parameters[23].Value = model.arrears_invoice;
			parameters[24].Value = model.isDelete;
			parameters[25].Value = model.Delete_time;

			object obj = DbHelperMySQL.GetSingle(strSql.ToString(),parameters);
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
		/// ����һ������
		/// </summary>
		public bool Update(XHD.Model.CRM_order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CRM_order set ");
			strSql.Append("Customer_id=@Customer_id,");
			strSql.Append("Customer_name=@Customer_name,");
			strSql.Append("Order_date=@Order_date,");
			strSql.Append("pay_type_id=@pay_type_id,");
			strSql.Append("pay_type=@pay_type,");
			strSql.Append("Order_details=@Order_details,");
			strSql.Append("Order_status_id=@Order_status_id,");
			strSql.Append("Order_status=@Order_status,");
			strSql.Append("Order_amount=@Order_amount,");
			strSql.Append("C_dep_id=@C_dep_id,");
			strSql.Append("C_dep_name=@C_dep_name,");
			strSql.Append("C_emp_id=@C_emp_id,");
			strSql.Append("C_emp_name=@C_emp_name,");
			strSql.Append("F_dep_id=@F_dep_id,");
			strSql.Append("F_dep_name=@F_dep_name,");
			strSql.Append("F_emp_id=@F_emp_id,");
			strSql.Append("F_emp_name=@F_emp_name,");
			strSql.Append("receive_money=@receive_money,");
			strSql.Append("arrears_money=@arrears_money,");
			strSql.Append("invoice_money=@invoice_money,");
			strSql.Append("arrears_invoice=@arrears_invoice");

			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {	
					new MySqlParameter("@Customer_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Customer_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@Order_date", MySqlDbType.DateTime),
					new MySqlParameter("@pay_type_id", MySqlDbType.Int32,4),
					new MySqlParameter("@pay_type", MySqlDbType.VarChar,250),
					new MySqlParameter("@Order_details", MySqlDbType.VarChar),
					new MySqlParameter("@Order_status_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Order_status", MySqlDbType.VarChar,250),
					new MySqlParameter("@Order_amount", MySqlDbType.Float,8),					
					new MySqlParameter("@C_dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@C_dep_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_emp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@C_emp_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@F_dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@F_dep_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@F_emp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@F_emp_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@receive_money", MySqlDbType.Float,8),
					new MySqlParameter("@arrears_money", MySqlDbType.Float,8),
					new MySqlParameter("@invoice_money", MySqlDbType.Float,8),
					new MySqlParameter("@arrears_invoice", MySqlDbType.Float,8),
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
			parameters[0].Value = model.Customer_id;
			parameters[1].Value = model.Customer_name;
			parameters[2].Value = model.Order_date;
			parameters[3].Value = model.pay_type_id;
			parameters[4].Value = model.pay_type;
			parameters[5].Value = model.Order_details;
			parameters[6].Value = model.Order_status_id;
			parameters[7].Value = model.Order_status;
			parameters[8].Value = model.Order_amount;			
			parameters[9].Value = model.C_dep_id;
			parameters[10].Value = model.C_dep_name;
			parameters[11].Value = model.C_emp_id;
			parameters[12].Value = model.C_emp_name;
			parameters[13].Value = model.F_dep_id;
			parameters[14].Value = model.F_dep_name;
			parameters[15].Value = model.F_emp_id;
			parameters[16].Value = model.F_emp_name;
			parameters[17].Value = model.receive_money;
			parameters[18].Value = model.arrears_money;
			parameters[19].Value = model.invoice_money;
			parameters[20].Value = model.arrears_invoice;
			parameters[21].Value = model.id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
        /// ����
        /// </summary>
        public bool Update_batch(XHD.Model.CRM_order model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_order set ");            
            strSql.Append("F_dep_id=@F_dep_id,");
            strSql.Append("F_dep_name=@F_dep_name,");
            strSql.Append("F_emp_id=@F_emp_id,");
            strSql.Append("F_emp_name=@F_emp_name");
            strSql.Append(" where F_emp_id=@create_id");
            MySqlParameter[] parameters = {					
					new MySqlParameter("@F_dep_id", MySqlDbType.Int32,4),
					new MySqlParameter("@F_dep_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@F_emp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@F_emp_name", MySqlDbType.VarChar,250),		
					new MySqlParameter("@create_id", MySqlDbType.Int32,4)};
            
            parameters[0].Value = model.F_dep_id;
            parameters[1].Value = model.F_dep_name;
            parameters[2].Value = model.F_emp_id;
            parameters[3].Value = model.F_emp_name;
            parameters[4].Value = model.create_id;

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
		/// Ԥɾ��
		/// </summary>
		public bool AdvanceDelete(int id, int isDelete, string time)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("update CRM_order set ");
			strSql.Append("isDelete=" + isDelete);
			strSql.Append(",Delete_time='" + time + "'");
			strSql.Append(" where id=" + id);
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
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CRM_order ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)
};
			parameters[0].Value = id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CRM_order ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
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
		/// �õ�һ������ʵ��
		/// </summary>
		public XHD.Model.CRM_order GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Serialnumber,Customer_id,Customer_name,Order_date,pay_type_id,pay_type,Order_details,Order_status_id,Order_status,Order_amount,create_id,create_date,C_dep_id,C_dep_name,C_emp_id,C_emp_name,F_dep_id,F_dep_name,F_emp_id,F_emp_name,receive_money,arrears_money,invoice_money,arrears_invoice,isDelete,Delete_time from CRM_order ");
			strSql.Append(" where id=@id limit 1");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)
};
			parameters[0].Value = id;

			XHD.Model.CRM_order model=new XHD.Model.CRM_order();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Serialnumber"]!=null && ds.Tables[0].Rows[0]["Serialnumber"].ToString()!="")
				{
					model.Serialnumber=ds.Tables[0].Rows[0]["Serialnumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Customer_id"]!=null && ds.Tables[0].Rows[0]["Customer_id"].ToString()!="")
				{
					model.Customer_id=int.Parse(ds.Tables[0].Rows[0]["Customer_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Customer_name"]!=null && ds.Tables[0].Rows[0]["Customer_name"].ToString()!="")
				{
					model.Customer_name=ds.Tables[0].Rows[0]["Customer_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Order_date"]!=null && ds.Tables[0].Rows[0]["Order_date"].ToString()!="")
				{
					model.Order_date=DateTime.Parse(ds.Tables[0].Rows[0]["Order_date"].ToString());
				}
				if(ds.Tables[0].Rows[0]["pay_type_id"]!=null && ds.Tables[0].Rows[0]["pay_type_id"].ToString()!="")
				{
					model.pay_type_id=int.Parse(ds.Tables[0].Rows[0]["pay_type_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["pay_type"]!=null && ds.Tables[0].Rows[0]["pay_type"].ToString()!="")
				{
					model.pay_type=ds.Tables[0].Rows[0]["pay_type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Order_details"]!=null && ds.Tables[0].Rows[0]["Order_details"].ToString()!="")
				{
					model.Order_details=ds.Tables[0].Rows[0]["Order_details"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Order_status_id"]!=null && ds.Tables[0].Rows[0]["Order_status_id"].ToString()!="")
				{
					model.Order_status_id=int.Parse(ds.Tables[0].Rows[0]["Order_status_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Order_status"]!=null && ds.Tables[0].Rows[0]["Order_status"].ToString()!="")
				{
					model.Order_status=ds.Tables[0].Rows[0]["Order_status"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Order_amount"]!=null && ds.Tables[0].Rows[0]["Order_amount"].ToString()!="")
				{
					model.Order_amount=decimal.Parse(ds.Tables[0].Rows[0]["Order_amount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["create_id"]!=null && ds.Tables[0].Rows[0]["create_id"].ToString()!="")
				{
					model.create_id=int.Parse(ds.Tables[0].Rows[0]["create_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["create_date"]!=null && ds.Tables[0].Rows[0]["create_date"].ToString()!="")
				{
					model.create_date=DateTime.Parse(ds.Tables[0].Rows[0]["create_date"].ToString());
				}
				if(ds.Tables[0].Rows[0]["C_dep_id"]!=null && ds.Tables[0].Rows[0]["C_dep_id"].ToString()!="")
				{
					model.C_dep_id=int.Parse(ds.Tables[0].Rows[0]["C_dep_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["C_dep_name"]!=null && ds.Tables[0].Rows[0]["C_dep_name"].ToString()!="")
				{
					model.C_dep_name=ds.Tables[0].Rows[0]["C_dep_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["C_emp_id"]!=null && ds.Tables[0].Rows[0]["C_emp_id"].ToString()!="")
				{
					model.C_emp_id=int.Parse(ds.Tables[0].Rows[0]["C_emp_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["C_emp_name"]!=null && ds.Tables[0].Rows[0]["C_emp_name"].ToString()!="")
				{
					model.C_emp_name=ds.Tables[0].Rows[0]["C_emp_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["F_dep_id"]!=null && ds.Tables[0].Rows[0]["F_dep_id"].ToString()!="")
				{
					model.F_dep_id=int.Parse(ds.Tables[0].Rows[0]["F_dep_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["F_dep_name"]!=null && ds.Tables[0].Rows[0]["F_dep_name"].ToString()!="")
				{
					model.F_dep_name=ds.Tables[0].Rows[0]["F_dep_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["F_emp_id"]!=null && ds.Tables[0].Rows[0]["F_emp_id"].ToString()!="")
				{
					model.F_emp_id=int.Parse(ds.Tables[0].Rows[0]["F_emp_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["F_emp_name"]!=null && ds.Tables[0].Rows[0]["F_emp_name"].ToString()!="")
				{
					model.F_emp_name=ds.Tables[0].Rows[0]["F_emp_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["receive_money"]!=null && ds.Tables[0].Rows[0]["receive_money"].ToString()!="")
				{
					model.receive_money=decimal.Parse(ds.Tables[0].Rows[0]["receive_money"].ToString());
				}
				if(ds.Tables[0].Rows[0]["arrears_money"]!=null && ds.Tables[0].Rows[0]["arrears_money"].ToString()!="")
				{
					model.arrears_money=decimal.Parse(ds.Tables[0].Rows[0]["arrears_money"].ToString());
				}
				if(ds.Tables[0].Rows[0]["invoice_money"]!=null && ds.Tables[0].Rows[0]["invoice_money"].ToString()!="")
				{
					model.invoice_money=decimal.Parse(ds.Tables[0].Rows[0]["invoice_money"].ToString());
				}
				if(ds.Tables[0].Rows[0]["arrears_invoice"]!=null && ds.Tables[0].Rows[0]["arrears_invoice"].ToString()!="")
				{
					model.arrears_invoice=decimal.Parse(ds.Tables[0].Rows[0]["arrears_invoice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isDelete"]!=null && ds.Tables[0].Rows[0]["isDelete"].ToString()!="")
				{
					model.isDelete=int.Parse(ds.Tables[0].Rows[0]["isDelete"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Delete_time"]!=null && ds.Tables[0].Rows[0]["Delete_time"].ToString()!="")
				{
					model.Delete_time=DateTime.Parse(ds.Tables[0].Rows[0]["Delete_time"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,Factory_Id,Serialnumber,Customer_id,Customer_name,Order_date,pay_type_id,pay_type,Order_details,Order_status_id,Order_status,Order_amount,create_id,create_date,C_dep_id,C_dep_name,C_emp_id,C_emp_name,F_dep_id,F_dep_name,F_emp_id,F_emp_name,receive_money,arrears_money,invoice_money,arrears_invoice,isDelete,Delete_time ");
			strSql.Append(" FROM CRM_order ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			
			strSql.Append(" id,Serialnumber,Customer_id,Customer_name,Order_date,pay_type_id,pay_type,Order_details,Order_status_id,Order_status,Order_amount,create_id,create_date,C_dep_id,C_dep_name,C_emp_id,C_emp_name,F_dep_id,F_dep_name,F_emp_id,F_emp_name,receive_money,arrears_money,invoice_money,arrears_invoice,isDelete,Delete_time ");
			strSql.Append(" FROM CRM_order ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
            }
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
		{
			StringBuilder strSql = new StringBuilder();
			StringBuilder strSql1 = new StringBuilder();
			strSql.Append("select ");
			strSql.Append("  * FROM CRM_order ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_order ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
			strSql1.Append(" select count(id) FROM CRM_order ");
			if (strWhere.Trim() != "")
			{
			    strSql.Append(" where " + strWhere);
			    strSql1.Append(" where " + strWhere);
			}
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
			Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
			return DbHelperMySQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ���·�Ʊ
        /// </summary>
        public bool UpdateInvoice(string orderid)
        {
            StringBuilder strSql1 = new StringBuilder();
            strSql1.Append(" /*���·�Ʊ*/ ");
            strSql1.Append(" UPDATE CRM_order SET ");
            strSql1.Append("     invoice_money=(SELECT SUM(ISNULL(invoice_amount,0)) AS Expr1 FROM CRM_invoice WHERE ( ISNULL(isDelete,0)=0 and  order_id='" + orderid + "'))  ");
            strSql1.Append(" WHERE (id='" + orderid + "') ");

            StringBuilder strSql2 = new StringBuilder();
            strSql2.Append(" /*���·�Ʊ*/ ");
            strSql2.Append(" UPDATE CRM_order SET ");
            strSql2.Append("     arrears_invoice= ISNULL(Order_amount,0) - ISNULL(invoice_money,0)  ");
            strSql2.Append(" WHERE (id='" + orderid + "') ");

            int rows1 = DbHelperMySQL.ExecuteSql(strSql1.ToString());
            int rows2 = DbHelperMySQL.ExecuteSql(strSql2.ToString());

            if (rows1 > 0 && rows2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// ���·�Ʊ
        /// </summary>
        public bool UpdateReceive(string orderid)
        {
            StringBuilder strSql1 = new StringBuilder();
            strSql1.Append(" /*�����տ�*/ ");
            strSql1.Append(" UPDATE CRM_order SET ");
            strSql1.Append("     receive_money=(SELECT SUM(ISNULL(Receive_amount,0)) AS Expr1 FROM CRM_receive WHERE ( ISNULL(isDelete,0)=0 and order_id='" + orderid + "'))  ");
            strSql1.Append(" WHERE (id='" + orderid + "') ");

            StringBuilder strSql2 = new StringBuilder();
            strSql2.Append(" /*�����տ�*/ ");
            strSql2.Append(" UPDATE CRM_order SET ");
            strSql2.Append("     arrears_money= ISNULL(Order_amount,0) - ISNULL(receive_money,0)  ");
            strSql2.Append(" WHERE (id='" + orderid + "') ");

            int rows1 = DbHelperMySQL.ExecuteSql(strSql1.ToString());
            int rows2 = DbHelperMySQL.ExecuteSql(strSql2.ToString());

            if (rows1 > 0 && rows2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		#endregion  Method
	}
}

