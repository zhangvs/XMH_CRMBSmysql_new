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
    /// 数据访问类:crm_customer_handnum
    /// </summary>
    public partial class crm_customer_handnum
    {
        public crm_customer_handnum()
        { }

        XHD.DAL.ecs_users _ecsuser = new ecs_users();
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_customer_handnum");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.crm_customer_handnum model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_customer_handnum(");
            strSql.Append("Factory_Id,customer_id,customer,BeSeats_id_old,BeSeats_old,BeSeats_uid_old,BeSeats_depid_old,BeSeats_depname_old,emp_id,emp_uid,emp_name,Start_date,End_date,operation_emp_id,operation_emp_uid,operation_emp_name)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@customer_id,@customer,@BeSeats_id_old,@BeSeats_old,@BeSeats_uid_old,@BeSeats_depid_old,@BeSeats_depname_old,@emp_id,@emp_uid,@emp_name,@Start_date,@End_date,@operation_emp_id,@operation_emp_uid,@operation_emp_name)");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
                    new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
                    new MySqlParameter("@customer", MySqlDbType.VarChar,200),
                    new MySqlParameter("@BeSeats_id_old", MySqlDbType.Int32,11),
                    new MySqlParameter("@BeSeats_old", MySqlDbType.VarChar,250),
                    new MySqlParameter("@BeSeats_uid_old", MySqlDbType.VarChar,100),
                    new MySqlParameter("@BeSeats_depid_old", MySqlDbType.Int32,11),
                    new MySqlParameter("@BeSeats_depname_old", MySqlDbType.VarChar,60),
                    new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
                    new MySqlParameter("@emp_uid", MySqlDbType.VarChar,100),
                    new MySqlParameter("@emp_name", MySqlDbType.VarChar,250),
                    new MySqlParameter("@Start_date", MySqlDbType.DateTime),
                    new MySqlParameter("@End_date", MySqlDbType.DateTime),
                    new MySqlParameter("@operation_emp_id", MySqlDbType.Int32,11),
                    new MySqlParameter("@operation_emp_uid", MySqlDbType.VarChar,100),
                    new MySqlParameter("@operation_emp_name", MySqlDbType.VarChar,250)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.customer_id;
            parameters[2].Value = model.customer;
            parameters[3].Value = model.BeSeats_id_old;
            parameters[4].Value = model.BeSeats_old;
            parameters[5].Value = model.BeSeats_uid_old;
            parameters[6].Value = model.BeSeats_depid_old;
            parameters[7].Value = model.BeSeats_depname_old;
            parameters[8].Value = model.emp_id;
            parameters[9].Value = model.emp_uid;
            parameters[10].Value = model.emp_name;
            parameters[11].Value = model.Start_date;
            parameters[12].Value = model.End_date;
            parameters[13].Value = model.operation_emp_id;
            parameters[14].Value = model.operation_emp_uid;
            parameters[15].Value = model.operation_emp_name;

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
        /// 增加一条数据
        /// </summary>
        public bool Insert(XHD.Model.crm_customer_handnum modelhandnum, XHD.Model.CRM_Customer model)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;
            string strWhere = string.Empty;

            //1.更新crm_customer_handnum：更新上一条记录的结束时间
            strSql = string.Format(@"update crm_customer_handnum set  End_date='{0}'  where id= (select max( bb1.id ) as a1 from  (select id,Factory_Id,customer_id from  crm_customer_handnum) as bb1 where bb1.customer_id='{1}') ",
                                     modelhandnum.Start_date, modelhandnum.customer_id);

            strSqlList.Add(strSql);

            //2.crm_customer_handnum：保存新的更新记录
            strSql = string.Format(@" INSERT INTO crm_customer_handnum(Factory_Id,customer_id,customer,BeSeats_id_old,BeSeats_old,BeSeats_uid_old,BeSeats_depid_old,BeSeats_depname_old,
                                      emp_id,emp_uid,emp_name,Start_date,End_date,operation_emp_id,operation_emp_uid,operation_emp_name)
                                      VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}','{11}','{12}','{13}','{14}','{15}')",
                                      modelhandnum.Factory_Id, modelhandnum.customer_id, modelhandnum.customer, modelhandnum.BeSeats_id_old, modelhandnum.BeSeats_old,
                                      modelhandnum.BeSeats_uid_old, modelhandnum.BeSeats_depid_old, modelhandnum.BeSeats_depname_old, modelhandnum.emp_id, modelhandnum.emp_uid,
                                      modelhandnum.emp_name, modelhandnum.Start_date, modelhandnum.Start_date, modelhandnum.operation_emp_id, modelhandnum.operation_emp_uid, modelhandnum.operation_emp_name);
            strSqlList.Add(strSql);

            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
            if (rows >= 0)
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
        public bool Adds(XHD.Model.crm_customer_handnum modelhandnum, XHD.Model.CRM_Customer model, XHD.Model.ecs_admin_user adminModel, string c_tel)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;
            string strWhere = string.Empty;

            //1.更改客户表的信息
            strSql = string.Format(@"update CRM_Customer set BeSeats_id='{0}',BeSeats_uid='{1}',BeSeats='{2}',BeSeats_depid='{3}',BeSeats_depname='{4}',emp_handnum='{5}' where id='{6}'",
                                     model.BeSeats_id, model.BeSeats_uid, model.BeSeats, model.BeSeats_depid, model.BeSeats_depname, model.emp_handnum, model.id);

            strSqlList.Add(strSql);

            //2.更新crm_customer_handnum：更新上一条记录的结束时间
            strSql = string.Format(@"update crm_customer_handnum set  End_date='{0}'  where id= (select max( bb1.id ) as a1 from  (select id,Factory_Id,customer_id from  crm_customer_handnum) as bb1 where bb1.customer_id='{1}') ",
                                     modelhandnum.Start_date, modelhandnum.customer_id);

            strSqlList.Add(strSql);

            //3.crm_customer_handnum：保存新的更新记录
            strSql = string.Format(@" INSERT INTO crm_customer_handnum(Factory_Id,customer_id,customer,BeSeats_id_old,BeSeats_old,BeSeats_uid_old,BeSeats_depid_old,BeSeats_depname_old,
                                      emp_id,emp_uid,emp_name,Start_date,End_date,operation_emp_id,operation_emp_uid,operation_emp_name)
                                      VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}','{11}','{12}','{13}','{14}','{15}')",
                                      modelhandnum.Factory_Id, modelhandnum.customer_id, modelhandnum.customer, modelhandnum.BeSeats_id_old, modelhandnum.BeSeats_old,
                                      modelhandnum.BeSeats_uid_old, modelhandnum.BeSeats_depid_old, modelhandnum.BeSeats_depname_old, modelhandnum.emp_id, modelhandnum.emp_uid,
                                      modelhandnum.emp_name, modelhandnum.Start_date, modelhandnum.Start_date, modelhandnum.operation_emp_id, modelhandnum.operation_emp_uid, modelhandnum.operation_emp_name);
            strSqlList.Add(strSql);


            //4.更新商城上的客户与客服对应关系
            if (!string.IsNullOrEmpty(c_tel))
            {
                //1.查询商城上是否存在该客户
                if (model.Factory_Id == "1000")
                    strWhere = " and dealer_id=0";
                else if (model.Factory_Id == "1005")
                    strWhere = " and dealer_id=4";

                DataSet ds = _ecsuser.GetListId(" user_name in (" + c_tel.Trim() + ") " + strWhere + "");

                //2.更改商城上对客户的座席
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        int userId = Convert.ToInt32(ds.Tables[0].Rows[i]["user_id"]);
                        strSql = string.Format(@" update ecs_users set user_market_area='{0}', admin_user_name='{1}',admin_user_id='{2}',admin_u_real_name='{3}' where user_id = '{4}'",
                                                 adminModel.admin_market_area, adminModel.user_name, adminModel.user_id, adminModel.real_name, userId);

                        strSqlList.Add(strSql);
                    }
                }
            }


            int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
            if (rows >= 0)
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
        public bool Update(XHD.Model.crm_customer_handnum model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_handnum set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("customer_id=@customer_id,");
            strSql.Append("customer=@customer,");
            strSql.Append("BeSeats_id_old=@BeSeats_id_old,");
            strSql.Append("BeSeats_old=@BeSeats_old,");
            strSql.Append("BeSeats_uid_old=@BeSeats_uid_old,");
            strSql.Append("BeSeats_depid_old=@BeSeats_depid_old,");
            strSql.Append("BeSeats_depname_old=@BeSeats_depname_old,");
            strSql.Append("emp_id=@emp_id,");
            strSql.Append("emp_uid=@emp_uid,");
            strSql.Append("emp_name=@emp_name,");
            strSql.Append("Start_date=@Start_date,");
            strSql.Append("End_date=@End_date,");
            strSql.Append("operation_emp_id=@operation_emp_id,");
            strSql.Append("operation_emp_uid=@operation_emp_uid,");
            strSql.Append("operation_emp_name=@operation_emp_name");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
					new MySqlParameter("@customer", MySqlDbType.VarChar,200),
					new MySqlParameter("@BeSeats_id_old", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_old", MySqlDbType.VarChar,250),
					new MySqlParameter("@BeSeats_uid_old", MySqlDbType.VarChar,100),
					new MySqlParameter("@BeSeats_depid_old", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_depname_old", MySqlDbType.VarChar,60),
					new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@emp_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@emp_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@Start_date", MySqlDbType.DateTime),
					new MySqlParameter("@End_date", MySqlDbType.DateTime),
					new MySqlParameter("@operation_emp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@operation_emp_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@operation_emp_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.customer_id;
            parameters[2].Value = model.customer;
            parameters[3].Value = model.BeSeats_id_old;
            parameters[4].Value = model.BeSeats_old;
            parameters[5].Value = model.BeSeats_uid_old;
            parameters[6].Value = model.BeSeats_depid_old;
            parameters[7].Value = model.BeSeats_depname_old;
            parameters[8].Value = model.emp_id;
            parameters[9].Value = model.emp_uid;
            parameters[10].Value = model.emp_name;
            parameters[11].Value = model.Start_date;
            parameters[12].Value = model.End_date;
            parameters[13].Value = model.operation_emp_id;
            parameters[14].Value = model.operation_emp_uid;
            parameters[15].Value = model.operation_emp_name;
            parameters[16].Value = model.id;

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
            strSql.Append("delete from crm_customer_handnum ");
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_handnum ");
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
        public XHD.Model.crm_customer_handnum GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,customer_id,customer,BeSeats_id_old,BeSeats_old,BeSeats_uid_old,BeSeats_depid_old,BeSeats_depname_old,emp_id,emp_uid,emp_name,Start_date,End_date,operation_emp_id,operation_emp_uid,operation_emp_name from crm_customer_handnum ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.crm_customer_handnum model = new XHD.Model.crm_customer_handnum();
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
        public XHD.Model.crm_customer_handnum DataRowToModel(DataRow row)
        {
            XHD.Model.crm_customer_handnum model = new XHD.Model.crm_customer_handnum();
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
                if (row["customer_id"] != null && row["customer_id"].ToString() != "")
                {
                    model.customer_id = int.Parse(row["customer_id"].ToString());
                }
                if (row["customer"] != null)
                {
                    model.customer = row["customer"].ToString();
                }
                if (row["BeSeats_id_old"] != null && row["BeSeats_id_old"].ToString() != "")
                {
                    model.BeSeats_id_old = int.Parse(row["BeSeats_id_old"].ToString());
                }
                if (row["BeSeats_old"] != null)
                {
                    model.BeSeats_old = row["BeSeats_old"].ToString();
                }
                if (row["BeSeats_uid_old"] != null)
                {
                    model.BeSeats_uid_old = row["BeSeats_uid_old"].ToString();
                }
                if (row["BeSeats_depid_old"] != null && row["BeSeats_depid_old"].ToString() != "")
                {
                    model.BeSeats_depid_old = int.Parse(row["BeSeats_depid_old"].ToString());
                }
                if (row["BeSeats_depname_old"] != null)
                {
                    model.BeSeats_depname_old = row["BeSeats_depname_old"].ToString();
                }
                if (row["emp_id"] != null && row["emp_id"].ToString() != "")
                {
                    model.emp_id = int.Parse(row["emp_id"].ToString());
                }
                if (row["emp_uid"] != null)
                {
                    model.emp_uid = row["emp_uid"].ToString();
                }
                if (row["emp_name"] != null)
                {
                    model.emp_name = row["emp_name"].ToString();
                }
                if (row["Start_date"] != null && row["Start_date"].ToString() != "")
                {
                    model.Start_date = DateTime.Parse(row["Start_date"].ToString());
                }
                if (row["End_date"] != null && row["End_date"].ToString() != "")
                {
                    model.End_date = DateTime.Parse(row["End_date"].ToString());
                }
                if (row["operation_emp_id"] != null && row["operation_emp_id"].ToString() != "")
                {
                    model.operation_emp_id = int.Parse(row["operation_emp_id"].ToString());
                }
                if (row["operation_emp_uid"] != null)
                {
                    model.operation_emp_uid = row["operation_emp_uid"].ToString();
                }
                if (row["operation_emp_name"] != null)
                {
                    model.operation_emp_name = row["operation_emp_name"].ToString();
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
            strSql.Append("select id,Factory_Id,customer_id,customer,BeSeats_id_old,BeSeats_old,BeSeats_uid_old,BeSeats_depid_old,BeSeats_depname_old,emp_id,emp_uid,emp_name,Start_date,End_date,operation_emp_id,operation_emp_uid,operation_emp_name ");
            strSql.Append(" FROM crm_customer_handnum ");
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
            strSql.Append("select h.id,h.Factory_Id,h.customer_id,h.customer,h.BeSeats_id_old,h.BeSeats_old,h.BeSeats_uid_old,h.BeSeats_depid_old,h.BeSeats_depname_old,e.emp_code ");
            strSql.Append(" FROM crm_customer_handnum  h");
            strSql.Append(" inner join hr_employee e on h.BeSeats_id_old = e.ID");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByCusId(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@" select * from  crm_customer_handnum ");
            strSql1.Append(" select count(id) FROM crm_customer_handnum ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod


        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}


//        /// <summary>
//        /// 更新一条数据
//        /// </summary>
//        public bool Update(XHD.Model.crm_customer_handnum model)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("update crm_customer_handnum set ");
//            strSql.Append("customer_id=@customer_id,");
//            strSql.Append("customer=@customer,");
//            strSql.Append("emp_id=@emp_id,");
//            strSql.Append("emp_uid=@emp_uid,");
//            strSql.Append("emp_name=@emp_name,");
//            strSql.Append("Start_date=@Start_date,");
//            strSql.Append("End_date=@End_date");
//            strSql.Append(" where id=@id");
//            MySqlParameter[] parameters = {
//                    new MySqlParameter("@customer_id", MySqlDbType.Int32,11),
//                    new MySqlParameter("@customer", MySqlDbType.VarChar,200),
//                    new MySqlParameter("@emp_id", MySqlDbType.Int32,11),
//                    new MySqlParameter("@emp_uid", MySqlDbType.VarChar,100),
//                    new MySqlParameter("@emp_name", MySqlDbType.VarChar,250),
//                    new MySqlParameter("@Start_date", MySqlDbType.DateTime),
//                    new MySqlParameter("@End_date", MySqlDbType.DateTime),
//                    new MySqlParameter("@id", MySqlDbType.Int32,11)};
//            parameters[0].Value = model.customer_id;
//            parameters[1].Value = model.customer;
//            parameters[2].Value = model.emp_id;
//            parameters[3].Value = model.emp_uid;
//            parameters[4].Value = model.emp_name;
//            parameters[5].Value = model.Start_date;
//            parameters[6].Value = model.End_date;
//            parameters[7].Value = model.id;

//            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString(), parameters);
//            if (rows > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

