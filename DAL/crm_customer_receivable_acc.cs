using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using XHD.DBUtility;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// ���ݷ�����:crm_customer_receivable_acc
    /// </summary>
    public partial class crm_customer_receivable_acc
    {
        public crm_customer_receivable_acc()
        { }
        #region  BasicMethod

        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("Id", "crm_customer_receivable_acc");
        }

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_customer_receivable_acc");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Add(XHD.Model.crm_customer_receivable_acc model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_customer_receivable_acc(");
            strSql.Append("Id,Settlement_Time,Settlement_value,Factory_Id,Serialnumber,Customer_Id,Customer,BeSeats_id,BeSeats_uid,BeSeats)");
            strSql.Append(" values (");
            strSql.Append("@Id,@Settlement_Time,@Settlement_value,@Factory_Id,@Serialnumber,@Customer_Id,@Customer,@BeSeats_id,@BeSeats_uid,@BeSeats)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Settlement_Time", MySqlDbType.DateTime),
					new MySqlParameter("@Settlement_value", MySqlDbType.Decimal,18),
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Serialnumber", MySqlDbType.VarChar,60),
					new MySqlParameter("@Customer_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Customer", MySqlDbType.VarChar,200),
					new MySqlParameter("@BeSeats_id", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@BeSeats", MySqlDbType.VarChar,250)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.Settlement_Time;
            parameters[2].Value = model.Settlement_value;
            parameters[3].Value = model.Factory_Id;
            parameters[4].Value = model.Serialnumber;
            parameters[5].Value = model.Customer_Id;
            parameters[6].Value = model.Customer;
            parameters[7].Value = model.BeSeats_id;
            parameters[8].Value = model.BeSeats_uid;
            parameters[9].Value = model.BeSeats;

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
        /// ����һ������
        /// </summary>
        public bool Update(XHD.Model.crm_customer_receivable_acc model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_receivable_acc set ");
            strSql.Append("Settlement_Time=@Settlement_Time,");
            strSql.Append("Settlement_value=@Settlement_value,");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("Serialnumber=@Serialnumber,");
            strSql.Append("Customer_Id=@Customer_Id,");
            strSql.Append("Customer=@Customer,");
            strSql.Append("BeSeats_id=@BeSeats_id,");
            strSql.Append("BeSeats_uid=@BeSeats_uid,");
            strSql.Append("BeSeats=@BeSeats");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Settlement_Time", MySqlDbType.DateTime),
					new MySqlParameter("@Settlement_value", MySqlDbType.Decimal,18),
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Serialnumber", MySqlDbType.VarChar,60),
					new MySqlParameter("@Customer_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Customer", MySqlDbType.VarChar,200),
					new MySqlParameter("@BeSeats_id", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@BeSeats", MySqlDbType.VarChar,250),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Settlement_Time;
            parameters[1].Value = model.Settlement_value;
            parameters[2].Value = model.Factory_Id;
            parameters[3].Value = model.Serialnumber;
            parameters[4].Value = model.Customer_Id;
            parameters[5].Value = model.Customer;
            parameters[6].Value = model.BeSeats_id;
            parameters[7].Value = model.BeSeats_uid;
            parameters[8].Value = model.BeSeats;
            parameters[9].Value = model.Id;

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
        /// ɾ��һ������
        /// </summary>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_receivable_acc ");
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
        /// ����ɾ������
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_receivable_acc ");
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
        /// �õ�һ������ʵ��
        /// </summary>
        public XHD.Model.crm_customer_receivable_acc GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Settlement_Time,Settlement_value,Factory_Id,Serialnumber,Customer_Id,Customer,BeSeats_id,BeSeats_uid,BeSeats from crm_customer_receivable_acc ");
            strSql.Append(" where Id=@Id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
            parameters[0].Value = Id;

            XHD.Model.crm_customer_receivable_acc model = new XHD.Model.crm_customer_receivable_acc();
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
        /// �õ�һ������ʵ��
        /// </summary>
        public XHD.Model.crm_customer_receivable_acc DataRowToModel(DataRow row)
        {
            XHD.Model.crm_customer_receivable_acc model = new XHD.Model.crm_customer_receivable_acc();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Settlement_Time"] != null && row["Settlement_Time"].ToString() != "")
                {
                    model.Settlement_Time = DateTime.Parse(row["Settlement_Time"].ToString());
                }
                if (row["Settlement_value"] != null && row["Settlement_value"].ToString() != "")
                {
                    model.Settlement_value = decimal.Parse(row["Settlement_value"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["Serialnumber"] != null)
                {
                    model.Serialnumber = row["Serialnumber"].ToString();
                }
                if (row["Customer_Id"] != null && row["Customer_Id"].ToString() != "")
                {
                    model.Customer_Id = int.Parse(row["Customer_Id"].ToString());
                }
                if (row["Customer"] != null)
                {
                    model.Customer = row["Customer"].ToString();
                }
                if (row["BeSeats_id"] != null && row["BeSeats_id"].ToString() != "")
                {
                    model.BeSeats_id = int.Parse(row["BeSeats_id"].ToString());
                }
                if (row["BeSeats_uid"] != null)
                {
                    model.BeSeats_uid = row["BeSeats_uid"].ToString();
                }
                if (row["BeSeats"] != null)
                {
                    model.BeSeats = row["BeSeats"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Settlement_Time,Settlement_value,Factory_Id,Serialnumber,Customer_Id,Customer,BeSeats_id,BeSeats_uid,BeSeats ");
            strSql.Append(" FROM crm_customer_receivable_acc ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM crm_customer_receivable_acc ");
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
        /// ��ҳ��ȡ�����б�
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
            strSql.Append(")AS Row, T.*  from crm_customer_receivable_acc T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// ��ҳ��ȡ�����б�
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
            parameters[0].Value = "crm_customer_receivable_acc";
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

