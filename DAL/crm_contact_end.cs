using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references

namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:crm_contact_end
    /// </summary>
    public partial class crm_contact_end
    {
        public crm_contact_end()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_contact_end");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsLink(int customerid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_contact_end");
            strSql.Append(" where C_customerid_end=@customerid and IsDefaultContact=1 and isDelete=0 ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@customerid", MySqlDbType.Int32,4)};
            parameters[0].Value = customerid;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_contact_end model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_contact_end(");
            strSql.Append("Factory_Id,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_extentel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid_end,C_customername_end,C_createId,C_createDate,isDelete,Delete_time,IsDefaultContact)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@C_name,@C_sex,@C_department,@C_position,@C_birthday,@C_tel,@C_extentel,@C_fax,@C_email,@C_mobone,@C_mobtwo,@C_QQ,@C_add,@C_hobby,@C_remarks,@C_customerid_end,@C_customername_end,@C_createId,@C_createDate,@isDelete,@Delete_time,@IsDefaultContact)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_sex", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_department", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_position", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_birthday", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_tel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_extentel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_fax", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_email", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobone", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobtwo", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_QQ", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_add", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_hobby", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_remarks", MySqlDbType.LongText),
					new MySqlParameter("@C_customerid_end", MySqlDbType.Int32,11),
					new MySqlParameter("@C_customername_end", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,11),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime),
					new MySqlParameter("@IsDefaultContact", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.C_name;
            parameters[2].Value = model.C_sex;
            parameters[3].Value = model.C_department;
            parameters[4].Value = model.C_position;
            parameters[5].Value = model.C_birthday;
            parameters[6].Value = model.C_tel;
            parameters[7].Value = model.C_extentel;
            parameters[8].Value = model.C_fax;
            parameters[9].Value = model.C_email;
            parameters[10].Value = model.C_mobone;
            parameters[11].Value = model.C_mobtwo;
            parameters[12].Value = model.C_QQ;
            parameters[13].Value = model.C_add;
            parameters[14].Value = model.C_hobby;
            parameters[15].Value = model.C_remarks;
            parameters[16].Value = model.C_customerid_end;
            parameters[17].Value = model.C_customername_end;
            parameters[18].Value = model.C_createId;
            parameters[19].Value = model.C_createDate;
            parameters[20].Value = model.isDelete;
            parameters[21].Value = model.Delete_time;
            parameters[22].Value = model.IsDefaultContact;

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
        public bool Update(XHD.Model.crm_contact_end model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_contact_end set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("C_name=@C_name,");
            strSql.Append("C_sex=@C_sex,");
            strSql.Append("C_department=@C_department,");
            strSql.Append("C_position=@C_position,");
            strSql.Append("C_birthday=@C_birthday,");
            strSql.Append("C_tel=@C_tel,");
            strSql.Append("C_extentel=@C_extentel,");
            strSql.Append("C_fax=@C_fax,");
            strSql.Append("C_email=@C_email,");
            strSql.Append("C_mobone=@C_mobone,");
            strSql.Append("C_mobtwo=@C_mobtwo,");
            strSql.Append("C_QQ=@C_QQ,");
            strSql.Append("C_add=@C_add,");
            strSql.Append("C_hobby=@C_hobby,");
            strSql.Append("C_remarks=@C_remarks,");
            strSql.Append("C_customerid_end=@C_customerid_end,");
            strSql.Append("C_customername_end=@C_customername_end,");
            strSql.Append("C_createId=@C_createId,");
            strSql.Append("C_createDate=@C_createDate");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_sex", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_department", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_position", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_birthday", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_tel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_extentel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_fax", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_email", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobone", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobtwo", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_QQ", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_add", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_hobby", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_remarks", MySqlDbType.LongText),
					new MySqlParameter("@C_customerid_end", MySqlDbType.Int32,11),
					new MySqlParameter("@C_customername_end", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,11),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.C_name;
            parameters[2].Value = model.C_sex;
            parameters[3].Value = model.C_department;
            parameters[4].Value = model.C_position;
            parameters[5].Value = model.C_birthday;
            parameters[6].Value = model.C_tel;
            parameters[7].Value = model.C_extentel;
            parameters[8].Value = model.C_fax;
            parameters[9].Value = model.C_email;
            parameters[10].Value = model.C_mobone;
            parameters[11].Value = model.C_mobtwo;
            parameters[12].Value = model.C_QQ;
            parameters[13].Value = model.C_add;
            parameters[14].Value = model.C_hobby;
            parameters[15].Value = model.C_remarks;
            parameters[16].Value = model.C_customerid_end;
            parameters[17].Value = model.C_customername_end;
            parameters[18].Value = model.C_createId;
            parameters[19].Value = model.C_createDate;
            parameters[20].Value = model.id;

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
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_contact_end ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

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
        public bool IsDelete(int id)
        {

            string strSql = string.Empty;
            strSql = string.Format("update crm_contact_end set isDelete=1 where id='{0}'", id);

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_contact_end ");
            strSql.Append(" where id in (" + idlist + ")  ");
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
        public XHD.Model.crm_contact_end GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_extentel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid_end,C_customername_end,C_createId,C_createDate,isDelete,Delete_time,IsDefaultContact from crm_contact_end ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.crm_contact_end model = new XHD.Model.crm_contact_end();
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
        public XHD.Model.crm_contact_end DataRowToModel(DataRow row)
        {
            XHD.Model.crm_contact_end model = new XHD.Model.crm_contact_end();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["Factory_Id"] != null)
                {
                    model.Factory_Id = row["Factory_Id"].ToString();
                }
                if (row["C_name"] != null)
                {
                    model.C_name = row["C_name"].ToString();
                }
                if (row["C_sex"] != null)
                {
                    model.C_sex = row["C_sex"].ToString();
                }
                if (row["C_department"] != null)
                {
                    model.C_department = row["C_department"].ToString();
                }
                if (row["C_position"] != null)
                {
                    model.C_position = row["C_position"].ToString();
                }
                if (row["C_birthday"] != null)
                {
                    model.C_birthday = row["C_birthday"].ToString();
                }
                if (row["C_tel"] != null)
                {
                    model.C_tel = row["C_tel"].ToString();
                }
                if (row["C_extentel"] != null)
                {
                    model.C_extentel = row["C_extentel"].ToString();
                }
                if (row["C_fax"] != null)
                {
                    model.C_fax = row["C_fax"].ToString();
                }
                if (row["C_email"] != null)
                {
                    model.C_email = row["C_email"].ToString();
                }
                if (row["C_mobone"] != null)
                {
                    model.C_mobone = row["C_mobone"].ToString();
                }
                if (row["C_mobtwo"] != null)
                {
                    model.C_mobtwo = row["C_mobtwo"].ToString();
                }
                if (row["C_QQ"] != null)
                {
                    model.C_QQ = row["C_QQ"].ToString();
                }
                if (row["C_add"] != null)
                {
                    model.C_add = row["C_add"].ToString();
                }
                if (row["C_hobby"] != null)
                {
                    model.C_hobby = row["C_hobby"].ToString();
                }
                if (row["C_remarks"] != null)
                {
                    model.C_remarks = row["C_remarks"].ToString();
                }
                if (row["C_customerid_end"] != null && row["C_customerid_end"].ToString() != "")
                {
                    model.C_customerid_end = int.Parse(row["C_customerid_end"].ToString());
                }
                if (row["C_customername_end"] != null)
                {
                    model.C_customername_end = row["C_customername_end"].ToString();
                }
                if (row["C_createId"] != null && row["C_createId"].ToString() != "")
                {
                    model.C_createId = int.Parse(row["C_createId"].ToString());
                }
                if (row["C_createDate"] != null && row["C_createDate"].ToString() != "")
                {
                    model.C_createDate = DateTime.Parse(row["C_createDate"].ToString());
                }
                if (row["isDelete"] != null && row["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(row["isDelete"].ToString());
                }
                if (row["Delete_time"] != null && row["Delete_time"].ToString() != "")
                {
                    model.Delete_time = DateTime.Parse(row["Delete_time"].ToString());
                }
                if (row["IsDefaultContact"] != null && row["IsDefaultContact"].ToString() != "")
                {
                    model.IsDefaultContact = int.Parse(row["IsDefaultContact"].ToString());
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
            strSql.Append("select id,Factory_Id,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_extentel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid_end,C_customername_end,C_createId,C_createDate,isDelete,Delete_time,IsDefaultContact ");
            strSql.Append(" FROM crm_contact_end ");
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
            strSql.Append("select count(1) FROM crm_contact_end ");
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
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from crm_contact_end T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select * FROM crm_contact_end");
            strSql1.Append(" select count(id) FROM crm_contact_end ");
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListEcsUser(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select c.* ,u.user_name,u.user_money,u.pay_points,u.last_login,u.last_ip,u.reg_time FROM crm_contact_end c left join ecs_users u on c.C_tel = u.user_name");
            strSql1.Append(" select count(c.id) FROM crm_contact_end c left join ecs_users u on c.C_tel = u.user_name");
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
        /// 判断公司电话，联系电话，电话1，电话2是否存在重复
        /// </summary>
        public DataSet checkPhone(string strTel, string strWhere1, string strWhere2, string strFactoryid)
        {
            DataSet ds = null;
            if (!string.IsNullOrEmpty(strTel))
            {
                string strSql = string.Format(@" select c.id,c.Factory_Id,c.Employee_id,c.Employee_uid,c.Employee,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,e.tq_seatId,a.C_name,c.Customer_end
                                             FROM crm_customer_end c join crm_contact_end a on c.id = a.C_customerid_end
                                             left join hr_employee as e on c.BeSeats_uid=e.uid
                                             where (a.C_tel='{0}' or a.c_mobone='{0}' or a.c_mobtwo='{0}') and c.Factory_Id='{1}' and c.isDelete=0", strTel, strFactoryid);
                if (strWhere1.Trim() != "")
                {
                    strSql += " and " + strWhere1;
                }
                ds = DbHelperMySQL.Query(strSql.ToString());
                if (ds == null || ds.Tables[0].Rows.Count <= 0)
                {
                    strSql = string.Format(@" select c.id,c.Factory_Id,c.Employee_id,c.Employee_uid,c.Employee,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,e.tq_seatId,'' as C_name,c.Customer_end
                                             FROM crm_customer_end c left join hr_employee as e on c.BeSeats_uid=e.uid
                                             where c.tel='{0}' and c.Factory_Id='{1}' and c.isDelete=0", strTel, strFactoryid);
                    if (strWhere2.Trim() != "")
                    {
                        strSql += " and " + strWhere2;
                    }
                    ds = DbHelperMySQL.Query(strSql.ToString());
                }
            }

            return ds;
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsLinks(int customerid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_contact_end");
            strSql.Append(" where C_customerid_end=@customerid ");
            strSql.Append(" and IsDefaultContact=1 ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@customerid", MySqlDbType.Int32,4)};
            parameters[0].Value = customerid;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

