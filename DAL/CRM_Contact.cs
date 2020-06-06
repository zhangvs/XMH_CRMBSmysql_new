using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;
using System.Collections.Generic;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:CRM_Contact
    /// </summary>
    public partial class CRM_Contact
    {
        public CRM_Contact()
        { }
        #region  Method


        XHD.DAL.ecs_users _ecsuser = new ecs_users();

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "CRM_Contact");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CRM_Contact");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsLink(int customerid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CRM_Contact");
            strSql.Append(" where C_customerid=@customerid and IsDefaultContact=1 and isDelete=0 ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@customerid", MySqlDbType.Int32,4)};
            parameters[0].Value = customerid;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        //根据条件查询某客户是否存在联系人
        public bool IfExistsLink(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from  crm_customer c left join crm_contact a on c.id = a.C_customerid ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsLinks(int customerid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CRM_Contact");
            strSql.Append(" where C_customerid=@customerid ");
            strSql.Append(" and IsDefaultContact=1 ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@customerid", MySqlDbType.Int32,4)};
            parameters[0].Value = customerid;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsLinks(string phone, string strfactoryId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CRM_Contact");
            strSql.Append(" where (C_tel=@phone ");
            strSql.Append(" or C_mobone=@phone ");
            strSql.Append(" or C_mobtwo=@phone) and Factory_Id=@factory and isDelete=0");
            MySqlParameter[] parameters = {
					new MySqlParameter("@phone", MySqlDbType.VarChar,50),
                    new MySqlParameter("@factory",MySqlDbType.VarChar,60)};
            parameters[0].Value = phone;
            parameters[1].Value = strfactoryId;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.CRM_Contact model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CRM_Contact(");
            strSql.Append("Factory_Id,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid,C_customername,C_createId,C_createDate,isDelete,Delete_time,IsDefaultContact,C_extentel)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@C_name,@C_sex,@C_department,@C_position,@C_birthday,@C_tel,@C_fax,@C_email,@C_mobone,@C_mobtwo,@C_QQ,@C_add,@C_hobby,@C_remarks,@C_customerid,@C_customername,@C_createId,@C_createDate,@isDelete,@Delete_time,@IsDefaultContact,@C_extentel)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@C_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_sex", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_department", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_position", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_birthday", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_tel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_fax", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_email", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobone", MySqlDbType.VarChar,250),
                    new MySqlParameter("@C_mobtwo", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_QQ", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_add", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_hobby", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_remarks", MySqlDbType.VarChar),
					new MySqlParameter("@C_customerid", MySqlDbType.Int32,4),
					new MySqlParameter("@C_customername", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_createId", MySqlDbType.Int32,4),
					new MySqlParameter("@C_createDate", MySqlDbType.DateTime),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,4),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime),
                    new MySqlParameter("@IsDefaultContact",MySqlDbType.Int32,4),
                    new MySqlParameter("@C_extentel", MySqlDbType.VarChar,250),};

            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.C_name;
            parameters[2].Value = model.C_sex;
            parameters[3].Value = model.C_department;
            parameters[4].Value = model.C_position;
            parameters[5].Value = model.C_birthday;
            parameters[6].Value = model.C_tel;
            parameters[7].Value = model.C_fax;
            parameters[8].Value = model.C_email;
            parameters[9].Value = model.C_mobone;
            parameters[10].Value = model.C_mobtwo;
            parameters[11].Value = model.C_QQ;
            parameters[12].Value = model.C_add;
            parameters[13].Value = model.C_hobby;
            parameters[14].Value = model.C_remarks;
            parameters[15].Value = model.C_customerid;
            parameters[16].Value = model.C_customername;
            parameters[17].Value = model.C_createId;
            parameters[18].Value = model.C_createDate;
            parameters[19].Value = model.isDelete;
            parameters[20].Value = model.Delete_time;
            parameters[21].Value = model.IsDefaultContact;
            parameters[22].Value = model.C_extentel;

            object obj = DbHelperMySQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(XHD.Model.CRM_Contact model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Contact set ");
            strSql.Append("C_name=@C_name,");
            strSql.Append("C_sex=@C_sex,");
            strSql.Append("C_department=@C_department,");
            strSql.Append("C_position=@C_position,");
            strSql.Append("C_birthday=@C_birthday,");
            strSql.Append("C_tel=@C_tel,");
            strSql.Append("C_fax=@C_fax,");
            strSql.Append("C_email=@C_email,");
            strSql.Append("C_mobone=@C_mobone,");
            strSql.Append("C_mobtwo=@C_mobtwo,");
            strSql.Append("C_QQ=@C_QQ,");
            strSql.Append("C_add=@C_add,");
            strSql.Append("C_hobby=@C_hobby,");
            strSql.Append("C_remarks=@C_remarks,");
            strSql.Append("C_customerid=@C_customerid,");
            strSql.Append("C_customername=@C_customername,");
            strSql.Append("C_extentel=@C_extentel");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@C_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_sex", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_department", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_position", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_birthday", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_tel", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_fax", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_email", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_mobone", MySqlDbType.VarChar,250),
                    new MySqlParameter("@C_mobtwo", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_QQ", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_add", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_hobby", MySqlDbType.VarChar,250),
					new MySqlParameter("@C_remarks", MySqlDbType.VarChar),
					new MySqlParameter("@C_customerid", MySqlDbType.Int32,4),
					new MySqlParameter("@C_customername", MySqlDbType.VarChar,250),  
                    new MySqlParameter("@C_extentel", MySqlDbType.VarChar,250), 
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = model.C_name;
            parameters[1].Value = model.C_sex;
            parameters[2].Value = model.C_department;
            parameters[3].Value = model.C_position;
            parameters[4].Value = model.C_birthday;
            parameters[5].Value = model.C_tel;
            parameters[6].Value = model.C_fax;
            parameters[7].Value = model.C_email;
            parameters[8].Value = model.C_mobone;
            parameters[9].Value = model.C_mobtwo;
            parameters[10].Value = model.C_QQ;
            parameters[11].Value = model.C_add;
            parameters[12].Value = model.C_hobby;
            parameters[13].Value = model.C_remarks;
            parameters[14].Value = model.C_customerid;
            parameters[15].Value = model.C_customername;
            parameters[16].Value = model.C_extentel;
            parameters[17].Value = model.id;

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
        public bool UpdateContact(XHD.Model.CRM_Contact model, int userId)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;

            //修改crm联系人的电话
            strSql = string.Format(@" Update CRM_Contact set C_name='{0}',C_sex='{1}',C_department='{2}',C_position='{3}',C_birthday='{4}',C_tel='{5}',C_fax='{6}',C_email='{7}',
                                                             C_mobone='{8}',C_mobtwo='{9}',C_QQ='{10}',C_add='{11}',C_hobby='{12}',C_remarks='{13}',C_customerid='{14}',
                                                             C_customername='{15}',C_extentel='{16}' where id='{17}'",
                                                             model.C_name, model.C_sex, model.C_department, model.C_position, model.C_birthday, model.C_tel, model.C_fax, model.C_email,
                                                             model.C_mobone, model.C_mobtwo, model.C_QQ, model.C_add, model.C_hobby, model.C_remarks, model.C_customerid,
                                                             model.C_customername, model.C_extentel, model.id);

            strSqlList.Add(strSql);

            //修改商城

            strSql = string.Format(@" update ecs_users set user_name='{0}' where user_id='{1}'", model.C_tel, userId);
            strSqlList.Add(strSql);

            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
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
        public bool UpdateBillBank(int flag, string account, string userId)
        {
            string strSql = string.Empty;

            switch (flag)
            {
                case 1:
                    strSql = string.Format(@" Update CRM_Contact set bill_bank_code1='{0}' where  id='{1}'", account, userId);
                    break;
                case 2:
                    strSql = string.Format(@" Update CRM_Contact set bill_bank_code2='{0}' where  id='{1}'", account, userId);
                    break;
                case 3:
                    strSql = string.Format(@" Update CRM_Contact set bill_bank_code3='{0}' where  id='{1}'", account, userId);
                    break;
                case 4:
                    strSql = string.Format(@" Update CRM_Contact set bill_bank_code4='{0}' where  id='{1}'", account, userId);
                    break;
                case 5:
                    strSql = string.Format(@" Update CRM_Contact set bill_bank_code5='{0}' where  id='{1}'", account, userId);
                    break;
                case 6:
                    strSql = string.Format(@" Update CRM_Contact set bill_bank_code6='{0}' where  id='{1}'", account, userId);
                    break;
                default:
                    break;
            }
            int rows = DbHelperMySQL.ExecuteSql(strSql);
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
        /// 预删除
        /// </summary>
        public bool AdvanceDelete(int id, int isDelete, string time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Contact set ");
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CRM_Contact ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CRM_Contact ");
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
        public XHD.Model.CRM_Contact GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  id,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid,C_customername,C_createId,C_createDate,isDelete,Delete_time,C_extentel from CRM_Contact ");
            strSql.Append(" where id=@id  limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = id;

            XHD.Model.CRM_Contact model = new XHD.Model.CRM_Contact();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["C_name"] != null && ds.Tables[0].Rows[0]["C_name"].ToString() != "")
                {
                    model.C_name = ds.Tables[0].Rows[0]["C_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_sex"] != null && ds.Tables[0].Rows[0]["C_sex"].ToString() != "")
                {
                    model.C_sex = ds.Tables[0].Rows[0]["C_sex"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_department"] != null && ds.Tables[0].Rows[0]["C_department"].ToString() != "")
                {
                    model.C_department = ds.Tables[0].Rows[0]["C_department"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_position"] != null && ds.Tables[0].Rows[0]["C_position"].ToString() != "")
                {
                    model.C_position = ds.Tables[0].Rows[0]["C_position"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_birthday"] != null && ds.Tables[0].Rows[0]["C_birthday"].ToString() != "")
                {
                    model.C_birthday = ds.Tables[0].Rows[0]["C_birthday"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_tel"] != null && ds.Tables[0].Rows[0]["C_tel"].ToString() != "")
                {
                    model.C_tel = ds.Tables[0].Rows[0]["C_tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_fax"] != null && ds.Tables[0].Rows[0]["C_fax"].ToString() != "")
                {
                    model.C_fax = ds.Tables[0].Rows[0]["C_fax"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_email"] != null && ds.Tables[0].Rows[0]["C_email"].ToString() != "")
                {
                    model.C_email = ds.Tables[0].Rows[0]["C_email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_mobone"] != null && ds.Tables[0].Rows[0]["C_mobone"].ToString() != "")
                {
                    model.C_mobone = ds.Tables[0].Rows[0]["C_mobone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_mobtwo"] != null && ds.Tables[0].Rows[0]["C_mobtwo"].ToString() != "")
                {
                    model.C_mobtwo = ds.Tables[0].Rows[0]["C_mobtwo"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_QQ"] != null && ds.Tables[0].Rows[0]["C_QQ"].ToString() != "")
                {
                    model.C_QQ = ds.Tables[0].Rows[0]["C_QQ"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_add"] != null && ds.Tables[0].Rows[0]["C_add"].ToString() != "")
                {
                    model.C_add = ds.Tables[0].Rows[0]["C_add"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_hobby"] != null && ds.Tables[0].Rows[0]["C_hobby"].ToString() != "")
                {
                    model.C_hobby = ds.Tables[0].Rows[0]["C_hobby"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_remarks"] != null && ds.Tables[0].Rows[0]["C_remarks"].ToString() != "")
                {
                    model.C_remarks = ds.Tables[0].Rows[0]["C_remarks"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_customerid"] != null && ds.Tables[0].Rows[0]["C_customerid"].ToString() != "")
                {
                    model.C_customerid = int.Parse(ds.Tables[0].Rows[0]["C_customerid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["C_customername"] != null && ds.Tables[0].Rows[0]["C_customername"].ToString() != "")
                {
                    model.C_customername = ds.Tables[0].Rows[0]["C_customername"].ToString();
                }
                if (ds.Tables[0].Rows[0]["C_createId"] != null && ds.Tables[0].Rows[0]["C_createId"].ToString() != "")
                {
                    model.C_createId = int.Parse(ds.Tables[0].Rows[0]["C_createId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["C_createDate"] != null && ds.Tables[0].Rows[0]["C_createDate"].ToString() != "")
                {
                    model.C_createDate = DateTime.Parse(ds.Tables[0].Rows[0]["C_createDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["isDelete"] != null && ds.Tables[0].Rows[0]["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(ds.Tables[0].Rows[0]["isDelete"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Delete_time"] != null && ds.Tables[0].Rows[0]["Delete_time"].ToString() != "")
                {
                    model.Delete_time = DateTime.Parse(ds.Tables[0].Rows[0]["Delete_time"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid,C_customername,C_createId,C_createDate,isDelete,Delete_time,C_extentel,credit_day,credit_total ");
            strSql.Append(" FROM CRM_Contact ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetLists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select u.id as customer_id,u.Serialnumber,u.Customer,u.BeSeats,u.BeSeats_id,u.BeSeats_uid,e.emp_code,d.dept_code_kingdee,C.* "); 
            strSql.Append(" FROM CRM_Contact C inner join crm_customer u on c.C_customerid =u.id ");
            strSql.Append(" left join hr_employee as e on u.BeSeats_id=e.ID ");
            strSql.Append(" left join hr_department as d on d.id=e.d_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select u.Serialnumber,u.Customer,u.BeSeats,u.BeSeats_id,u.BeSeats_uid,C.id,e.tel as empTel,C.Factory_Id,C.C_name,C.C_sex,C.C_department,C.C_position,C.C_birthday,C.C_tel,C.C_fax,C.C_email,C.C_mobone,C.C_mobtwo,C.C_QQ,C.C_add,C.C_hobby,C.C_remarks,C.C_customerid,C.C_customername,C.C_createId,C.C_createDate,C.isDelete,C.Delete_time,C.C_extentel,C.tax_company_name ");
            strSql.Append(" FROM CRM_Contact C inner join crm_customer u on c.C_customerid =u.id inner join hr_employee e on e.ID=u.BeSeats_id  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");

            strSql.Append(" id,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid,C_customername,C_createId,C_createDate,isDelete,Delete_time,C_extentel ");
            strSql.Append(" FROM CRM_Contact ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append("  limit " + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select * FROM CRM_Contact ");
            strSql1.Append(" select count(id) FROM CRM_Contact ");
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
        public DataSet GetListShop(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select * FROM CRM_Contact  ");
            strSql1.Append(" select count(id) FROM CRM_Contact  ");
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
        public DataSet GetLists(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select c.*,u.BeSeats_id,u.BeSeats_uid FROM CRM_Contact  c inner join crm_customer u on c.C_customerid=u.id ");
            strSql1.Append(" select count(c.id) FROM CRM_Contact  c inner join crm_customer u on c.C_customerid=u.id  ");
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
            strSql.Append("select c.* ,u.user_name,u.user_money,u.pay_points,u.last_login,u.last_ip,u.reg_time FROM CRM_Contact c left join ecs_users u on c.C_tel = right(u.user_name,LENGTH(c.C_tel))");
            strSql1.Append(" select count(c.id) FROM CRM_Contact c left join ecs_users u on c.C_tel = right(u.user_name,LENGTH(c.C_tel))");
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
        public DataSet GetListShopEcsUser(int PageSize, int PageIndex, string strWhere, string sqlOne, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select c.* ,u.user_name as shop_user_name,u.user_money,u.pay_points,u.last_login,u.last_ip,u.reg_time FROM CRM_Contact c left join ecs_users u on c.C_tel = right(u.user_name,LENGTH(c.C_tel)) " + sqlOne + "");
            strSql1.Append(" select count(c.id) FROM CRM_Contact c left join ecs_users u on c.C_tel = right(u.user_name,LENGTH(c.C_tel))" + sqlOne + "");
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
        /// 由联系人电话查询信息
        /// </summary>
        public DataSet GetDateByPhone(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,C_name,C_tel,C_customerid,C_customername,C_createId");
            strSql.Append(" FROM CRM_Contact");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据联系人电话与员工信息判断客户是否存在
        /// </summary>
        public DataSet GetCusInfo(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select c.id,c.Factory_Id,c.BeSeats_id,c.BeSeats_uid,c.BeSeats");
            strSql.Append(" FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据联系电话，获取所属坐席
        /// </summary>
        public DataSet GetSeatByTel(string strTel)
        {
            DataSet ds = null;
            if (!string.IsNullOrEmpty(strTel))
            {
                string strSql = string.Format(@" select c.id,c.Factory_Id,c.Employee_id,c.Employee_uid,c.Employee,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,e.tq_seatId,a.C_name,c.Customer
                                             FROM crm_customer c join crm_contact a on c.id = a.C_customerid
                                             left join hr_employee as e on c.BeSeats_uid=e.uid
                                             where (a.C_tel='{0}' or a.c_mobone='{0}' or a.c_mobtwo='{0}') ", strTel);

                ds = DbHelperMySQL.Query(strSql.ToString());
                if (ds == null || ds.Tables[0].Rows.Count <= 0)
                {
                    strSql = string.Format(@" select c.id,c.Factory_Id,c.Employee_id,c.Employee_uid,c.Employee,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,e.tq_seatId,'' as C_name,c.Customer
                                             FROM crm_customer c left join hr_employee as e on c.BeSeats_uid=e.uid
                                             where c.tel='{0}'", strTel);
                    ds = DbHelperMySQL.Query(strSql.ToString());
                }
            }

            return ds;
        }

        /// <summary>
        /// 根据联系电话，获取所属坐席
        /// </summary>
        public DataSet GetSeatByTel(string strTel, string strFactoryid)
        {
            DataSet ds = null;
            if (!string.IsNullOrEmpty(strTel))
            {
                string strSql = string.Format(@" select c.id,c.Factory_Id,c.Employee_id,c.Employee_uid,c.Employee,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,e.tq_seatId,a.C_name,c.Customer,c.privatecustomer_Id
                                             FROM crm_customer c join crm_contact a on c.id = a.C_customerid
                                             left join hr_employee as e on c.BeSeats_uid=e.uid
                                             where (a.C_tel='{0}' or a.c_mobone='{0}' or a.c_mobtwo='{0}') and c.Factory_Id='{1}' and c.isDelete=0", strTel, strFactoryid);

                ds = DbHelperMySQL.Query(strSql.ToString());
                if (ds == null || ds.Tables[0].Rows.Count <= 0)
                {
                    strSql = string.Format(@" select c.id,c.Factory_Id,c.Employee_id,c.Employee_uid,c.Employee,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,e.tq_seatId,'' as C_name,c.Customer,c.privatecustomer_Id
                                             FROM crm_customer c left join hr_employee as e on c.BeSeats_uid=e.uid
                                             where c.tel='{0}' and c.Factory_Id='{1}' and c.isDelete=0", strTel, strFactoryid);
                    ds = DbHelperMySQL.Query(strSql.ToString());
                }
            }

            return ds;
        }

        /// <summary>
        /// 判断公司电话，联系电话，电话1，电话2是否存在重复
        /// </summary>
        public DataSet checkPhone(string strTel, string strWhere1, string strWhere2, string strFactoryid)
        {
            DataSet ds = null;
            if (!string.IsNullOrEmpty(strTel))
            {
                string strSql = string.Format(@" select c.id,c.Factory_Id,c.Employee_id,c.Employee_uid,c.Employee,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,e.tq_seatId,a.C_name,c.Customer
                                             FROM crm_customer c join crm_contact a on c.id = a.C_customerid
                                             left join hr_employee as e on c.BeSeats_uid=e.uid
                                             where (a.C_tel='{0}' or a.c_mobone='{0}' or a.c_mobtwo='{0}') and c.Factory_Id='{1}' ", strTel, strFactoryid);
                if (strWhere1.Trim() != "")
                {
                    strSql += " and " + strWhere1;
                }
                ds = DbHelperMySQL.Query(strSql.ToString());
                if (ds == null || ds.Tables[0].Rows.Count <= 0)
                {
                    strSql = string.Format(@" select c.id,c.Factory_Id,c.Employee_id,c.Employee_uid,c.Employee,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,e.tq_seatId,'' as C_name,c.Customer
                                             FROM crm_customer c left join hr_employee as e on c.BeSeats_uid=e.uid
                                             where c.tel='{0}' and c.Factory_Id='{1}' ", strTel, strFactoryid);
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
        /// 合并联系人
        /// </summary>
        public bool merga(int cid, string idlist, string factoryID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Contact set ");
            strSql.Append("C_customerid=" + cid);
            strSql.Append(" where id in (" + idlist + ")");
            strSql.Append(" and factory_id='" + factoryID + "'");
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
        #endregion  Method
    }
}

