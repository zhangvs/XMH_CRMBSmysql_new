using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
	/// <summary>
	/// ���ݷ�����:CRM_order_details
	/// </summary>
	public partial class CRM_order_details
	{
		public CRM_order_details()
		{}
		#region  Method



		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(XHD.Model.CRM_order_details model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CRM_order_details(");
			strSql.Append("order_id,product_id,product_name,price,quantity,unit,amount)");
			strSql.Append(" values (");
			strSql.Append("@order_id,@product_id,@product_name,@price,@quantity,@unit,@amount)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int32,4),
					new MySqlParameter("@product_id", MySqlDbType.Int32,4),
					new MySqlParameter("@product_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@price", MySqlDbType.Float,8),
					new MySqlParameter("@quantity", MySqlDbType.Int32,4),
					new MySqlParameter("@unit", MySqlDbType.VarChar,250),
					new MySqlParameter("@amount", MySqlDbType.Float,8)};
			parameters[0].Value = model.order_id;
			parameters[1].Value = model.product_id;
			parameters[2].Value = model.product_name;
			parameters[3].Value = model.price;
			parameters[4].Value = model.quantity;
			parameters[5].Value = model.unit;
			parameters[6].Value = model.amount;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(XHD.Model.CRM_order_details model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CRM_order_details set ");
			strSql.Append("order_id=@order_id,");
			strSql.Append("product_id=@product_id,");
			strSql.Append("product_name=@product_name,");
			strSql.Append("price=@price,");
			strSql.Append("quantity=@quantity,");
			strSql.Append("unit=@unit,");
			strSql.Append("amount=@amount");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@order_id", MySqlDbType.Int32,4),
					new MySqlParameter("@product_id", MySqlDbType.Int32,4),
					new MySqlParameter("@product_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@price", MySqlDbType.Float,8),
					new MySqlParameter("@quantity", MySqlDbType.Int32,4),
					new MySqlParameter("@unit", MySqlDbType.VarChar,250),
					new MySqlParameter("@amount", MySqlDbType.Float,8)};
			parameters[0].Value = model.order_id;
			parameters[1].Value = model.product_id;
			parameters[2].Value = model.product_name;
			parameters[3].Value = model.price;
			parameters[4].Value = model.quantity;
			parameters[5].Value = model.unit;
			parameters[6].Value = model.amount;

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
		public bool Delete(string wherestr)
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CRM_order_details ");
			strSql.Append(" where "+wherestr);
			MySqlParameter[] parameters = {
};

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
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select order_id,product_id,product_name,price,quantity,unit,amount ");
			strSql.Append(" FROM CRM_order_details ");
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
			
			strSql.Append(" order_id,product_id,product_name,price,quantity,unit,amount ");
			strSql.Append(" FROM CRM_order_details ");
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

		
		#endregion  Method
	}
}

