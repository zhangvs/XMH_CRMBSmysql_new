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
    /// 数据访问类:crm_customer_end
    /// </summary>
    public partial class crm_customer_end
    {
        public crm_customer_end()
        { }

        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crm_customer_end");
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
        public int Add(XHD.Model.crm_customer_end model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into crm_customer_end(");
            strSql.Append("Factory_Id,Dealer_Id,Dealer_Code,Dealer_Name,Serialnumber_end,Customer_end,address,tel,fax,site,industry_id,industry,Nation_id,Nation,Provinces_id,Provinces,City_id,City,District_id,District,CustomerType_id,CustomerType,CustomerLevel_id,CustomerLevel,CustomerSource_id,CustomerSource,DesCripe,Remarks,Department_id,Department,Employee_id,Employee_uid,Employee,FollowUp_id,FollowUp,CustomerValue_id,CustomerValue,PhoneIsValid_id,PhoneIsValid,BeSeats_id,BeSeats_uid,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,lastfollow,Create_id,Create_name,Create_date,isDelete,Delete_time,emp_handnum,state_allot,type_belong,state_allot_end)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@Dealer_Id,@Dealer_Code,@Dealer_Name,@Serialnumber_end,@Customer_end,@address,@tel,@fax,@site,@industry_id,@industry,@Nation_id,@Nation,@Provinces_id,@Provinces,@City_id,@City,@District_id,@District,@CustomerType_id,@CustomerType,@CustomerLevel_id,@CustomerLevel,@CustomerSource_id,@CustomerSource,@DesCripe,@Remarks,@Department_id,@Department,@Employee_id,@Employee_uid,@Employee,@FollowUp_id,@FollowUp,@CustomerValue_id,@CustomerValue,@PhoneIsValid_id,@PhoneIsValid,@BeSeats_id,@BeSeats_uid,@BeSeats,@BeSeats_depid,@BeSeats_depname,@privatecustomer_Id,@privatecustomer,@lastfollow,@Create_id,@Create_name,@Create_date,@isDelete,@Delete_time,@emp_handnum,@state_allot,@type_belong,@state_allot_end)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Dealer_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Dealer_Code", MySqlDbType.VarChar,60),
					new MySqlParameter("@Dealer_Name", MySqlDbType.VarChar,60),
					new MySqlParameter("@Serialnumber_end", MySqlDbType.VarChar,60),
					new MySqlParameter("@Customer_end", MySqlDbType.VarChar,200),
					new MySqlParameter("@address", MySqlDbType.VarChar,250),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@fax", MySqlDbType.VarChar,50),
					new MySqlParameter("@site", MySqlDbType.VarChar,250),
					new MySqlParameter("@industry_id", MySqlDbType.Int32,11),
					new MySqlParameter("@industry", MySqlDbType.VarChar,250),
					new MySqlParameter("@Nation_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Nation", MySqlDbType.VarChar,250),
					new MySqlParameter("@Provinces_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Provinces", MySqlDbType.VarChar,250),
					new MySqlParameter("@City_id", MySqlDbType.Int32,11),
					new MySqlParameter("@City", MySqlDbType.VarChar,250),
					new MySqlParameter("@District_id", MySqlDbType.Int32,11),
					new MySqlParameter("@District", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerType_id", MySqlDbType.Int32,11),
					new MySqlParameter("@CustomerType", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerLevel_id", MySqlDbType.Int32,11),
					new MySqlParameter("@CustomerLevel", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerSource_id", MySqlDbType.Int32,11),
					new MySqlParameter("@CustomerSource", MySqlDbType.VarChar,250),
					new MySqlParameter("@DesCripe", MySqlDbType.Text),
					new MySqlParameter("@Remarks", MySqlDbType.Text),
					new MySqlParameter("@Department_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Department", MySqlDbType.VarChar,250),
					new MySqlParameter("@Employee_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Employee_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@Employee", MySqlDbType.VarChar,250),
					new MySqlParameter("@FollowUp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@FollowUp", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerValue_id", MySqlDbType.Int32,11),
					new MySqlParameter("@CustomerValue", MySqlDbType.VarChar,250),
					new MySqlParameter("@PhoneIsValid_id", MySqlDbType.Int32,11),
					new MySqlParameter("@PhoneIsValid", MySqlDbType.VarChar,250),
					new MySqlParameter("@BeSeats_id", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@BeSeats", MySqlDbType.VarChar,250),
					new MySqlParameter("@BeSeats_depid", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_depname", MySqlDbType.VarChar,60),
					new MySqlParameter("@privatecustomer_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@privatecustomer", MySqlDbType.VarChar,50),
					new MySqlParameter("@lastfollow", MySqlDbType.DateTime),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,11),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime),
					new MySqlParameter("@emp_handnum", MySqlDbType.Int32,11),
					new MySqlParameter("@state_allot", MySqlDbType.VarChar,1),
					new MySqlParameter("@type_belong", MySqlDbType.VarChar,1),
                    new MySqlParameter("@state_allot_end", MySqlDbType.VarChar,1)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Dealer_Id;
            parameters[2].Value = model.Dealer_Code;
            parameters[3].Value = model.Dealer_Name;
            parameters[4].Value = model.Serialnumber_end;
            parameters[5].Value = model.Customer_end;
            parameters[6].Value = model.address;
            parameters[7].Value = model.tel;
            parameters[8].Value = model.fax;
            parameters[9].Value = model.site;
            parameters[10].Value = model.industry_id;
            parameters[11].Value = model.industry;
            parameters[12].Value = model.Nation_id;
            parameters[13].Value = model.Nation;
            parameters[14].Value = model.Provinces_id;
            parameters[15].Value = model.Provinces;
            parameters[16].Value = model.City_id;
            parameters[17].Value = model.City;
            parameters[18].Value = model.District_id;
            parameters[19].Value = model.District;
            parameters[20].Value = model.CustomerType_id;
            parameters[21].Value = model.CustomerType;
            parameters[22].Value = model.CustomerLevel_id;
            parameters[23].Value = model.CustomerLevel;
            parameters[24].Value = model.CustomerSource_id;
            parameters[25].Value = model.CustomerSource;
            parameters[26].Value = model.DesCripe;
            parameters[27].Value = model.Remarks;
            parameters[28].Value = model.Department_id;
            parameters[29].Value = model.Department;
            parameters[30].Value = model.Employee_id;
            parameters[31].Value = model.Employee_uid;
            parameters[32].Value = model.Employee;
            parameters[33].Value = model.FollowUp_id;
            parameters[34].Value = model.FollowUp;
            parameters[35].Value = model.CustomerValue_id;
            parameters[36].Value = model.CustomerValue;
            parameters[37].Value = model.PhoneIsValid_id;
            parameters[38].Value = model.PhoneIsValid;
            parameters[39].Value = model.BeSeats_id;
            parameters[40].Value = model.BeSeats_uid;
            parameters[41].Value = model.BeSeats;
            parameters[42].Value = model.BeSeats_depid;
            parameters[43].Value = model.BeSeats_depname;
            parameters[44].Value = model.privatecustomer_Id;
            parameters[45].Value = model.privatecustomer;
            parameters[46].Value = model.lastfollow;
            parameters[47].Value = model.Create_id;
            parameters[48].Value = model.Create_name;
            parameters[49].Value = model.Create_date;
            parameters[50].Value = model.isDelete;
            parameters[51].Value = model.Delete_time;
            parameters[52].Value = model.emp_handnum;
            parameters[53].Value = model.state_allot;
            parameters[54].Value = model.type_belong;
            parameters[55].Value = model.state_allot_end;

            //object obj = DbHelperMySQL.GetSingle(strSql.ToString(), parameters);

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
        public bool Update(XHD.Model.crm_customer_end model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_end set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("Dealer_Id=@Dealer_Id,");
            strSql.Append("Dealer_Code=@Dealer_Code,");
            strSql.Append("Dealer_Name=@Dealer_Name,");
            strSql.Append("Serialnumber_end=@Serialnumber_end,");
            strSql.Append("Customer_end=@Customer_end,");
            strSql.Append("address=@address,");
            strSql.Append("tel=@tel,");
            strSql.Append("fax=@fax,");
            strSql.Append("site=@site,");
            strSql.Append("industry_id=@industry_id,");
            strSql.Append("industry=@industry,");
            strSql.Append("Nation_id=@Nation_id,");
            strSql.Append("Nation=@Nation,");
            strSql.Append("Provinces_id=@Provinces_id,");
            strSql.Append("Provinces=@Provinces,");
            strSql.Append("City_id=@City_id,");
            strSql.Append("City=@City,");
            strSql.Append("District_id=@District_id,");
            strSql.Append("District=@District,");
            strSql.Append("CustomerType_id=@CustomerType_id,");
            strSql.Append("CustomerType=@CustomerType,");
            strSql.Append("CustomerLevel_id=@CustomerLevel_id,");
            strSql.Append("CustomerLevel=@CustomerLevel,");
            strSql.Append("CustomerSource_id=@CustomerSource_id,");
            strSql.Append("CustomerSource=@CustomerSource,");
            strSql.Append("DesCripe=@DesCripe,");
            strSql.Append("Remarks=@Remarks,");
            strSql.Append("Department_id=@Department_id,");
            strSql.Append("Department=@Department,");
            strSql.Append("Employee_id=@Employee_id,");
            strSql.Append("Employee_uid=@Employee_uid,");
            strSql.Append("Employee=@Employee,");
            strSql.Append("FollowUp_id=@FollowUp_id,");
            strSql.Append("FollowUp=@FollowUp,");
            strSql.Append("CustomerValue_id=@CustomerValue_id,");
            strSql.Append("CustomerValue=@CustomerValue,");
            strSql.Append("PhoneIsValid_id=@PhoneIsValid_id,");
            strSql.Append("PhoneIsValid=@PhoneIsValid,");
            strSql.Append("BeSeats_id=@BeSeats_id,");
            strSql.Append("BeSeats_uid=@BeSeats_uid,");
            strSql.Append("BeSeats=@BeSeats,");
            strSql.Append("BeSeats_depid=@BeSeats_depid,");
            strSql.Append("BeSeats_depname=@BeSeats_depname,");
            strSql.Append("privatecustomer_Id=@privatecustomer_Id,");
            strSql.Append("privatecustomer=@privatecustomer,");
            //strSql.Append("lastfollow=@lastfollow,");
            //strSql.Append("Create_id=@Create_id,");
            //strSql.Append("Create_name=@Create_name,");
            //strSql.Append("Create_date=@Create_date,");
            strSql.Append("isDelete=@isDelete,");
            strSql.Append("Delete_time=@Delete_time,");
            strSql.Append("emp_handnum=@emp_handnum,");
            //strSql.Append("state_allot=@state_allot,");
            //strSql.Append("type_belong=@type_belong");
            strSql.Append("state_allot_end=@state_allot_end");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Dealer_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Dealer_Code", MySqlDbType.VarChar,60),
					new MySqlParameter("@Dealer_Name", MySqlDbType.VarChar,60),
					new MySqlParameter("@Serialnumber_end", MySqlDbType.VarChar,60),
					new MySqlParameter("@Customer_end", MySqlDbType.VarChar,200),
					new MySqlParameter("@address", MySqlDbType.VarChar,250),
					new MySqlParameter("@tel", MySqlDbType.VarChar,50),
					new MySqlParameter("@fax", MySqlDbType.VarChar,50),
					new MySqlParameter("@site", MySqlDbType.VarChar,250),
					new MySqlParameter("@industry_id", MySqlDbType.Int32,11),
					new MySqlParameter("@industry", MySqlDbType.VarChar,250),
					new MySqlParameter("@Nation_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Nation", MySqlDbType.VarChar,250),
					new MySqlParameter("@Provinces_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Provinces", MySqlDbType.VarChar,250),
					new MySqlParameter("@City_id", MySqlDbType.Int32,11),
					new MySqlParameter("@City", MySqlDbType.VarChar,250),
					new MySqlParameter("@District_id", MySqlDbType.Int32,11),
					new MySqlParameter("@District", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerType_id", MySqlDbType.Int32,11),
					new MySqlParameter("@CustomerType", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerLevel_id", MySqlDbType.Int32,11),
					new MySqlParameter("@CustomerLevel", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerSource_id", MySqlDbType.Int32,11),
					new MySqlParameter("@CustomerSource", MySqlDbType.VarChar,250),
					new MySqlParameter("@DesCripe", MySqlDbType.Text),
					new MySqlParameter("@Remarks", MySqlDbType.Text),
					new MySqlParameter("@Department_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Department", MySqlDbType.VarChar,250),
					new MySqlParameter("@Employee_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Employee_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@Employee", MySqlDbType.VarChar,250),
					new MySqlParameter("@FollowUp_id", MySqlDbType.Int32,11),
					new MySqlParameter("@FollowUp", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerValue_id", MySqlDbType.Int32,11),
					new MySqlParameter("@CustomerValue", MySqlDbType.VarChar,250),
					new MySqlParameter("@PhoneIsValid_id", MySqlDbType.Int32,11),
					new MySqlParameter("@PhoneIsValid", MySqlDbType.VarChar,250),
					new MySqlParameter("@BeSeats_id", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@BeSeats", MySqlDbType.VarChar,250),
					new MySqlParameter("@BeSeats_depid", MySqlDbType.Int32,11),
					new MySqlParameter("@BeSeats_depname", MySqlDbType.VarChar,60),
					new MySqlParameter("@privatecustomer_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@privatecustomer", MySqlDbType.VarChar,50),
					new MySqlParameter("@lastfollow", MySqlDbType.DateTime),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,11),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime),
					new MySqlParameter("@emp_handnum", MySqlDbType.Int32,11),
					new MySqlParameter("@state_allot", MySqlDbType.VarChar,1),
					new MySqlParameter("@type_belong", MySqlDbType.VarChar,1),
                    new MySqlParameter("@state_allot_end", MySqlDbType.VarChar,1),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Dealer_Id;
            parameters[2].Value = model.Dealer_Code;
            parameters[3].Value = model.Dealer_Name;
            parameters[4].Value = model.Serialnumber_end;
            parameters[5].Value = model.Customer_end;
            parameters[6].Value = model.address;
            parameters[7].Value = model.tel;
            parameters[8].Value = model.fax;
            parameters[9].Value = model.site;
            parameters[10].Value = model.industry_id;
            parameters[11].Value = model.industry;
            parameters[12].Value = model.Nation_id;
            parameters[13].Value = model.Nation;
            parameters[14].Value = model.Provinces_id;
            parameters[15].Value = model.Provinces;
            parameters[16].Value = model.City_id;
            parameters[17].Value = model.City;
            parameters[18].Value = model.District_id;
            parameters[19].Value = model.District;
            parameters[20].Value = model.CustomerType_id;
            parameters[21].Value = model.CustomerType;
            parameters[22].Value = model.CustomerLevel_id;
            parameters[23].Value = model.CustomerLevel;
            parameters[24].Value = model.CustomerSource_id;
            parameters[25].Value = model.CustomerSource;
            parameters[26].Value = model.DesCripe;
            parameters[27].Value = model.Remarks;
            parameters[28].Value = model.Department_id;
            parameters[29].Value = model.Department;
            parameters[30].Value = model.Employee_id;
            parameters[31].Value = model.Employee_uid;
            parameters[32].Value = model.Employee;
            parameters[33].Value = model.FollowUp_id;
            parameters[34].Value = model.FollowUp;
            parameters[35].Value = model.CustomerValue_id;
            parameters[36].Value = model.CustomerValue;
            parameters[37].Value = model.PhoneIsValid_id;
            parameters[38].Value = model.PhoneIsValid;
            parameters[39].Value = model.BeSeats_id;
            parameters[40].Value = model.BeSeats_uid;
            parameters[41].Value = model.BeSeats;
            parameters[42].Value = model.BeSeats_depid;
            parameters[43].Value = model.BeSeats_depname;
            parameters[44].Value = model.privatecustomer_Id;
            parameters[45].Value = model.privatecustomer;
            parameters[46].Value = model.lastfollow;
            parameters[47].Value = model.Create_id;
            parameters[48].Value = model.Create_name;
            parameters[49].Value = model.Create_date;
            parameters[50].Value = model.isDelete;
            parameters[51].Value = model.Delete_time;
            parameters[52].Value = model.emp_handnum;
            parameters[53].Value = model.state_allot;
            parameters[54].Value = model.type_belong;
            parameters[55].Value = model.state_allot_end;
            parameters[56].Value = model.id;

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
            strSql.Append("delete from crm_customer_end ");
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
        /// 我的终端客户删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool Deletes(string id, int isDelete, string factory_Id, string time)
        {
            List<string> strSqlList = new List<string>();
            //修改客户的状态
            string strSql = string.Format(@"update crm_customer_end set state_allot='{0}', isDelete='{1}',Delete_time='{2}' where id in ({3}) and Factory_Id='{4}'", 0, isDelete, time, id, factory_Id);
            strSqlList.Add(strSql);

            //修改客户的联系人的信息
            strSql = string.Format(@"update crm_contact_end set isDelete='{0}',Delete_time='{1}' where  C_customerid_end in ({2}) and Factory_Id='{3}'", isDelete, time, id, factory_Id);
            strSqlList.Add(strSql);

            ////修改客户的跟进信息
            //strSql = string.Format(@"update crm_follow set isDelete='{0}',Delete_time='{1}' where Customer_id in ({2}) and Factory_Id='{3}'", isDelete, time, id, factory_Id);
            //strSqlList.Add(strSql);

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from crm_customer_end ");
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
        /// 级联批量删除
        /// </summary>
        public bool DeleteListAll(string id, string factory_Id)
        {
            List<string> strSqlList = new List<string>();
            //修改客户的状态
            string strSql = string.Format(@"delete from crm_customer_end where id in({0}) and factory_id='{1}'", id, factory_Id);
            strSqlList.Add(strSql);

            //修改客户的联系人的信息
            strSql = string.Format(@"delete from crm_contact_end  where  C_customerid_end in ({0}) and Factory_Id='{1}'", id, factory_Id);
            strSqlList.Add(strSql);

            ////修改客户的跟进信息
            //strSql = string.Format(@"update crm_follow set isDelete='{0}',Delete_time='{1}' where Customer_id in ({2}) and Factory_Id='{3}'", isDelete, time, id, factory_Id);
            //strSqlList.Add(strSql);

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
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.crm_customer_end GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,Dealer_Id,Dealer_Code,Dealer_Name,Serialnumber_end,Customer_end,address,tel,fax,site,industry_id,industry,Nation_id,Nation,Provinces_id,Provinces,City_id,City,District_id,District,CustomerType_id,CustomerType,CustomerLevel_id,CustomerLevel,CustomerSource_id,CustomerSource,DesCripe,Remarks,Department_id,Department,Employee_id,Employee_uid,Employee,FollowUp_id,FollowUp,CustomerValue_id,CustomerValue,PhoneIsValid_id,PhoneIsValid,BeSeats_id,BeSeats_uid,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,lastfollow,Create_id,Create_name,Create_date,isDelete,Delete_time,emp_handnum,state_allot,type_belong,state_allot_end from crm_customer_end ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            XHD.Model.crm_customer_end model = new XHD.Model.crm_customer_end();
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
        public XHD.Model.crm_customer_end DataRowToModel(DataRow row)
        {
            XHD.Model.crm_customer_end model = new XHD.Model.crm_customer_end();
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
                if (row["Dealer_Id"] != null && row["Dealer_Id"].ToString() != "")
                {
                    model.Dealer_Id = int.Parse(row["Dealer_Id"].ToString());
                }
                if (row["Dealer_Code"] != null)
                {
                    model.Dealer_Code = row["Dealer_Code"].ToString();
                }
                if (row["Dealer_Name"] != null)
                {
                    model.Dealer_Name = row["Dealer_Name"].ToString();
                }
                if (row["Serialnumber_end"] != null)
                {
                    model.Serialnumber_end = row["Serialnumber_end"].ToString();
                }
                if (row["Customer_end"] != null)
                {
                    model.Customer_end = row["Customer_end"].ToString();
                }
                if (row["address"] != null)
                {
                    model.address = row["address"].ToString();
                }
                if (row["tel"] != null)
                {
                    model.tel = row["tel"].ToString();
                }
                if (row["fax"] != null)
                {
                    model.fax = row["fax"].ToString();
                }
                if (row["site"] != null)
                {
                    model.site = row["site"].ToString();
                }
                if (row["industry_id"] != null && row["industry_id"].ToString() != "")
                {
                    model.industry_id = int.Parse(row["industry_id"].ToString());
                }
                if (row["industry"] != null)
                {
                    model.industry = row["industry"].ToString();
                }
                if (row["Nation_id"] != null && row["Nation_id"].ToString() != "")
                {
                    model.Nation_id = int.Parse(row["Nation_id"].ToString());
                }
                if (row["Nation"] != null)
                {
                    model.Nation = row["Nation"].ToString();
                }
                if (row["Provinces_id"] != null && row["Provinces_id"].ToString() != "")
                {
                    model.Provinces_id = int.Parse(row["Provinces_id"].ToString());
                }
                if (row["Provinces"] != null)
                {
                    model.Provinces = row["Provinces"].ToString();
                }
                if (row["City_id"] != null && row["City_id"].ToString() != "")
                {
                    model.City_id = int.Parse(row["City_id"].ToString());
                }
                if (row["City"] != null)
                {
                    model.City = row["City"].ToString();
                }
                if (row["District_id"] != null && row["District_id"].ToString() != "")
                {
                    model.District_id = int.Parse(row["District_id"].ToString());
                }
                if (row["District"] != null)
                {
                    model.District = row["District"].ToString();
                }
                if (row["CustomerType_id"] != null && row["CustomerType_id"].ToString() != "")
                {
                    model.CustomerType_id = int.Parse(row["CustomerType_id"].ToString());
                }
                if (row["CustomerType"] != null)
                {
                    model.CustomerType = row["CustomerType"].ToString();
                }
                if (row["CustomerLevel_id"] != null && row["CustomerLevel_id"].ToString() != "")
                {
                    model.CustomerLevel_id = int.Parse(row["CustomerLevel_id"].ToString());
                }
                if (row["CustomerLevel"] != null)
                {
                    model.CustomerLevel = row["CustomerLevel"].ToString();
                }
                if (row["CustomerSource_id"] != null && row["CustomerSource_id"].ToString() != "")
                {
                    model.CustomerSource_id = int.Parse(row["CustomerSource_id"].ToString());
                }
                if (row["CustomerSource"] != null)
                {
                    model.CustomerSource = row["CustomerSource"].ToString();
                }
                if (row["DesCripe"] != null)
                {
                    model.DesCripe = row["DesCripe"].ToString();
                }
                if (row["Remarks"] != null)
                {
                    model.Remarks = row["Remarks"].ToString();
                }
                if (row["Department_id"] != null && row["Department_id"].ToString() != "")
                {
                    model.Department_id = int.Parse(row["Department_id"].ToString());
                }
                if (row["Department"] != null)
                {
                    model.Department = row["Department"].ToString();
                }
                if (row["Employee_id"] != null && row["Employee_id"].ToString() != "")
                {
                    model.Employee_id = int.Parse(row["Employee_id"].ToString());
                }
                if (row["Employee_uid"] != null)
                {
                    model.Employee_uid = row["Employee_uid"].ToString();
                }
                if (row["Employee"] != null)
                {
                    model.Employee = row["Employee"].ToString();
                }
                if (row["FollowUp_id"] != null && row["FollowUp_id"].ToString() != "")
                {
                    model.FollowUp_id = int.Parse(row["FollowUp_id"].ToString());
                }
                if (row["FollowUp"] != null)
                {
                    model.FollowUp = row["FollowUp"].ToString();
                }
                if (row["CustomerValue_id"] != null && row["CustomerValue_id"].ToString() != "")
                {
                    model.CustomerValue_id = int.Parse(row["CustomerValue_id"].ToString());
                }
                if (row["CustomerValue"] != null)
                {
                    model.CustomerValue = row["CustomerValue"].ToString();
                }
                if (row["PhoneIsValid_id"] != null && row["PhoneIsValid_id"].ToString() != "")
                {
                    model.PhoneIsValid_id = int.Parse(row["PhoneIsValid_id"].ToString());
                }
                if (row["PhoneIsValid"] != null)
                {
                    model.PhoneIsValid = row["PhoneIsValid"].ToString();
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
                if (row["BeSeats_depid"] != null && row["BeSeats_depid"].ToString() != "")
                {
                    model.BeSeats_depid = int.Parse(row["BeSeats_depid"].ToString());
                }
                if (row["BeSeats_depname"] != null)
                {
                    model.BeSeats_depname = row["BeSeats_depname"].ToString();
                }
                if (row["privatecustomer_Id"] != null && row["privatecustomer_Id"].ToString() != "")
                {
                    model.privatecustomer_Id = int.Parse(row["privatecustomer_Id"].ToString());
                }
                if (row["privatecustomer"] != null)
                {
                    model.privatecustomer = row["privatecustomer"].ToString();
                }
                if (row["lastfollow"] != null && row["lastfollow"].ToString() != "")
                {
                    model.lastfollow = DateTime.Parse(row["lastfollow"].ToString());
                }
                if (row["Create_id"] != null && row["Create_id"].ToString() != "")
                {
                    model.Create_id = int.Parse(row["Create_id"].ToString());
                }
                if (row["Create_name"] != null)
                {
                    model.Create_name = row["Create_name"].ToString();
                }
                if (row["Create_date"] != null && row["Create_date"].ToString() != "")
                {
                    model.Create_date = DateTime.Parse(row["Create_date"].ToString());
                }
                if (row["isDelete"] != null && row["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(row["isDelete"].ToString());
                }
                if (row["Delete_time"] != null && row["Delete_time"].ToString() != "")
                {
                    model.Delete_time = DateTime.Parse(row["Delete_time"].ToString());
                }
                if (row["emp_handnum"] != null && row["emp_handnum"].ToString() != "")
                {
                    model.emp_handnum = int.Parse(row["emp_handnum"].ToString());
                }
                if (row["state_allot"] != null)
                {
                    model.state_allot = row["state_allot"].ToString();
                }
                if (row["type_belong"] != null)
                {
                    model.type_belong = row["type_belong"].ToString();
                }
                if (row["state_allot_end"] != null)
                {
                    model.type_belong = row["state_allot_end"].ToString();
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
            strSql.Append("select id,Factory_Id,Dealer_Id,Dealer_Code,Dealer_Name,Serialnumber_end,Customer_end,address,tel,fax,site,industry_id,industry,Nation_id,Nation,Provinces_id,Provinces,City_id,City,District_id,District,CustomerType_id,CustomerType,CustomerLevel_id,CustomerLevel,CustomerSource_id,CustomerSource,DesCripe,Remarks,Department_id,Department,Employee_id,Employee_uid,Employee,FollowUp_id,FollowUp,CustomerValue_id,CustomerValue,PhoneIsValid_id,PhoneIsValid,BeSeats_id,BeSeats_uid,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,lastfollow,Create_id,Create_name,Create_date,isDelete,Delete_time,emp_handnum,state_allot,type_belong,state_allot_end ");
            strSql.Append(" FROM crm_customer_end ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListLink(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id,L.id as lid,L.C_name,L.C_sex,L.C_department,L.C_position,L.C_birthday,L.C_tel,L.C_fax,L.C_email,L.C_mobone,C_mobtwo,L.C_QQ,L.C_hobby,L.C_remarks,L.C_customerid_end ");
            strSql.Append(" FROM crm_customer_end C left join crm_contact_end L on C.id=L.C_customerid_end");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 我的终端客户列表分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select id,Factory_Id,Dealer_Code,Dealer_Name,Serialnumber_end,Customer_end,address,tel,fax,site,industry,Nation,Provinces,City,District,CustomerType,CustomerLevel,CustomerSource,Department_id,Department,Employee_id,Employee,FollowUp,CustomerValue,BeSeats_id,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,lastfollow,Create_name,Create_date,emp_handnum,state_allot,type_belong FROM crm_customer_end ");
            strSql1.Append(" select count(id) FROM crm_customer_end ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //客服分配终端客户
        public bool allot(string id, XHD.Model.crm_customer_end model)
        {
            string strSql = string.Empty;

            //更改客户表中的关系
            strSql = string.Format(@" update crm_customer_end set Dealer_Id='{0}',Dealer_Code='{1}',Dealer_Name='{2}',state_allot='{3}' where id in ({4})",
                                     model.Dealer_Id, model.Dealer_Code, model.Dealer_Name, model.state_allot, id);


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

        //分配终端客户给客服
        public bool publicAllot(string id, XHD.Model.crm_customer_end model)
        {
            string strSql = string.Empty;

            //更改客户表中的关系
            strSql = string.Format(@" update crm_customer_end set BeSeats_id='{0}',BeSeats='{1}',BeSeats_depid='{2}',BeSeats_depname='{3}',BeSeats_uid='{4}',state_allot='{5}' where id in ({6}) and factory_id='{7}'",
                                     model.BeSeats_id, model.BeSeats, model.BeSeats_depid, model.BeSeats_depname, model.BeSeats_uid, model.state_allot, id, model.Factory_Id);
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
        ///联系人获得数据列表
        /// </summary>
        public DataSet GetListContact(int PageSize, int PageIndex, string strWhere, string key, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@" select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id,
                                L.id as lid,L.C_name,L.C_sex,L.C_department,L.C_position,L.C_birthday,L.C_tel,L.C_fax,L.C_email,L.C_mobone,C_mobtwo,
                                L.C_QQ,L.C_hobby,L.C_remarks,L.C_customerid_end
                                FROM crm_customer_end C left join crm_contact_end L on  C.id =L.C_customerid_end ");
            strSql1.Append(" select count(C.id) FROM crm_customer_end C  left join crm_contact_end L on  C.id =L.C_customerid_end ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
                strSql.Append(" and  L.C_name like '%" + key + "%'");
                strSql1.Append(" and  L.C_name like '%" + key + "%'");
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        ///联系人获得数据
        /// </summary>
        public DataSet GetAllContact(string strWhere, string key)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(@" select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id,
                                L.id as lid,L.C_name,L.C_sex,L.C_department,L.C_position,L.C_birthday,L.C_tel,L.C_fax,L.C_email,L.C_mobone,C_mobtwo,
                                L.C_QQ,L.C_hobby,L.C_remarks,L.C_customerid_end
                                FROM crm_customer_end C left join crm_contact_end L on  C.id =L.C_customerid_end ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql.Append(" and  L.C_name like '%" + key + "%'");
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 公司电话联系电话获得数据列表,
        // a.id as lid,a.C_name,a.C_sex,a.C_department,a.C_position,a.C_birthday,a.C_tel,a.C_fax,a.C_email,a.C_mobone,a.C_mobtwo,
        // a.C_QQ,a.C_hobby,a.C_remarks,a.C_customerid_end
        /// </summary>
        public DataSet GetListByTel(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append("SELECT  distinct *  from (");
            strSql.Append(@" select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end c inner join crm_contact_end a on c.id = a.C_customerid_end ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }
            strSql.Append("  Union all");
            strSql.Append(@" select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end c ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }
            strSql.Append(") as unioninfo");

            //strSql.Append(" WHERE F.Follow like '%" + key + "%' and C.id not in ( SELECT top " + (PageIndex - 1) * PageSize + " C.id FROM CRM_Customer C ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append("select  count(distinct id)  from(");
            strSql1.Append(" select C.id FROM crm_customer_end c inner join crm_contact_end a on c.id = a.C_customerid_end ");
            if (strWhere1.Trim() != "")
            {
                strSql1.Append(" where " + strWhere1);
            }
            strSql1.Append("  Union all");
            strSql1.Append(" select C.id FROM crm_customer_end c ");
            if (strWhere2.Trim() != "")
            {
                strSql1.Append(" where " + strWhere2);
            }
            strSql1.Append(") as unioninfo");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据综合查询获取客户信息
        /// </summary>
        public DataSet GetListSynthesis(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("SELECT  distinct *  from (");
            strSql.Append(@"    select  C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end as C inner join crm_contact_end as CT on  C.id=CT.C_customerid_end  ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }
            strSql.Append("  Union all");
            strSql.Append(@"    select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end as C inner join CRM_Follow_end as F on C.id=F.Customer_id_end   ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }
            strSql.Append(") as unioninfo");
            //strSql.Append(" WHERE F.Follow like '%" + key + "%' and C.id not in ( SELECT top " + (PageIndex - 1) * PageSize + " C.id FROM CRM_Customer C ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(@"  select  count(distinct id)  from 
                                (select  c.id
                                FROM crm_customer_end as C
                                inner join crm_contact_end as CT on  C.id=CT.C_customerid_end  ");
            if (strWhere1.Trim() != "")
            {
                strSql1.Append(" where " + strWhere1);
            }
            strSql1.Append("  Union all");
            strSql1.Append(@"  select  c.id
                               FROM crm_customer_end as C
                               inner join CRM_Follow_end as F on C.id=F.Customer_id_end  ");
            if (strWhere2.Trim() != "")
            {
                strSql1.Append(" where " + strWhere2);
            }
            strSql1.Append(" ) as unioninfo");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 根据综合查询获取客户信息
        /// </summary>
        public DataSet GetListSynthesis(string strWhere1, string strWhere2)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("SELECT  distinct *  from (");
            strSql.Append(@"    select  C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end as C inner join crm_contact_end as CT on  C.id=CT.C_customerid_end  ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }
            strSql.Append("  Union all");
            strSql.Append(@"    select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end as C inner join CRM_Follow_end as F on C.id=F.Customer_id_end   ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }
            strSql.Append(") as unioninfo"); ;
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 公司电话联系电话获得数据列表,
        public DataSet GetAllListByTel(string strWhere1, string strWhere2)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append("SELECT  distinct *  from (");
            strSql.Append(@" select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end c inner join crm_contact_end a on c.id = a.C_customerid_end ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }
            strSql.Append("  Union all");
            strSql.Append(@" select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end c ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }
            strSql.Append(") as unioninfo");

            //strSql.Append(" WHERE F.Follow like '%" + key + "%' and C.id not in ( SELECT top " + (PageIndex - 1) * PageSize + " C.id FROM CRM_Customer C ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        ///跟进内容获得数据
        /// </summary>
        public DataSet GetAllContactFollow(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(@" select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end as C inner join CRM_Follow_end as F on C.id=F.Customer_id_end ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 跟进内容获得数据列表
        /// </summary>
        public DataSet GetListContactFollow(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@"select C.id,C.Dealer_Id,C.Dealer_Code,C.Dealer_Name,C.Factory_Id,C.Serialnumber_end,C.Customer_end,C.address,C.tel,C.fax,C.site,
                                C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,
                                C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,
                                C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,
                                C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,
                                C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id
                                FROM crm_customer_end as C inner join CRM_Follow_end as F on C.id=F.Customer_id_end  ");
            strSql1.Append(" select count(distinct C.id) FROM crm_customer_end C inner join CRM_Follow_end F on  C.id =F.Customer_id_end ");
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
        /// 终端客户列表【权限内】
        /// </summary>
        public DataSet GetListCustomerEndAll(int PageSize, int PageIndex, string strWhere1, string strWhere2,string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" SELECT  distinct *  from (");
            strSql.Append(@"   select id , Factory_Id,Dealer_Name,Customer_end,address,tel,fax,site,industry,Nation,Provinces,City,District,CustomerType,CustomerLevel,CustomerSource,Department_id,Department,Employee_id,Employee,FollowUp_id,FollowUp,CustomerValue_id,
                                CustomerValue,BeSeats_id,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,lastfollow,Create_date,emp_handnum,state_allot,1 as type from crm_customer_end ");           
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }

            strSql.Append("  Union all");
            strSql.Append(@"   select cu.id,cu.myFactory_Id as Factory_Id ,'',cu.Customer as Customer_end,cu.address,cu.tel,cu.fax,cu.site,cu.industry,cu.Nation,cu.Provinces,cu.City,cu.District,cu.CustomerType,cu.CustomerLevel,cu.CustomerSource,cu.Department_id,cu.Department,
                               cu.Employee_id,cu.Employee,cu.FollowUp_id,cu.FollowUp,cu.CustomerValue_id,cu.CustomerValue,cu.BeSeats_id,cu.BeSeats,cu.BeSeats_depid,cu.BeSeats_depname,cu.privatecustomer_Id,cu.privatecustomer,cu.lastfollow,cu.Create_date,cu.emp_handnum,'',2 as type from crm_customer cu                               
                                inner join  (  select s.Factory_Id from crm_customer c  inner join sys_factoryinfo s on c.myFactory_Id=s.Factory_Id  " + strWhere + " ) as d on cu.Factory_Id = d.Factory_Id ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }

            strSql.Append(") as unioninfo");

            strSql1.Append(@"  select  count(distinct id)  from 
                                (select  id
                                FROM crm_customer_end ");
            if (strWhere1.Trim() != "")
            {
                strSql1.Append(" where " + strWhere1);
            }
            strSql1.Append("  Union all");
            strSql1.Append(@"  select  cu.id
                               FROM crm_customer as cu
                               inner join ( select s.Factory_Id from crm_customer c  inner join sys_factoryinfo s on c.myFactory_Id=s.Factory_Id " + strWhere + " ) as d on cu.Factory_Id = d.Factory_Id  ");
            if (strWhere2.Trim() != "")
            {
                strSql1.Append(" where " + strWhere2);
            }
            strSql1.Append(" ) as unioninfo");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        ///联系人获得数据列表
        /// </summary>
        public DataSet GetListContact(int PageSize, int PageIndex, string strWhere1, string strWhere2, string key,string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" SELECT  distinct *  from (");
            strSql.Append(@"    select ce.id , ce.Factory_Id,ce.Dealer_Name,ce.Customer_end,ce.address,ce.tel,ce.fax,ce.site,ce.industry,ce.Nation,ce.Provinces,ce.City,ce.District,ce.CustomerType,ce.CustomerLevel,ce.CustomerSource,ce.Department_id,
                                 ce.Department,ce.Employee_id,ce.Employee,ce.FollowUp_id,ce.FollowUp,ce.CustomerValue_id, ce.CustomerValue,ce.BeSeats_id,ce.BeSeats,ce.BeSeats_depid,ce.BeSeats_depname,ce.privatecustomer_Id,ce.privatecustomer,
                               ce.lastfollow,ce.Create_date,ce.emp_handnum,ce.state_allot from crm_customer_end ce
                                left join crm_contact_end L on  ce.id =L.C_customerid_end");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
                strSql.Append(" and  L.C_name like '%" + key + "%'");
            }

            strSql.Append("  Union all");
            strSql.Append(@"   select cu.id,cu.myFactory_Id as Factory_Id ,'',cu.Customer as Customer_end,cu.address,cu.tel,cu.fax,cu.site,cu.industry,cu.Nation,cu.Provinces,cu.City,cu.District,cu.CustomerType,cu.CustomerLevel,cu.CustomerSource,cu.Department_id,cu.Department,
                               cu.Employee_id,cu.Employee,cu.FollowUp_id,cu.FollowUp,cu.CustomerValue_id,cu.CustomerValue,cu.BeSeats_id,cu.BeSeats,cu.BeSeats_depid,cu.BeSeats_depname,cu.privatecustomer_Id,cu.privatecustomer,cu.lastfollow,cu.Create_date,cu.emp_handnum,'' from crm_customer cu                               
                                inner join  (  select distinct(s.Factory_Id) from crm_customer c  inner join sys_factoryinfo s on c.myFactory_Id=s.Factory_Id  "+strWhere+" ) as d on cu.Factory_Id = d.Factory_Id  left join CRM_Contact L on  cu.id =L.C_customerid");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
                strSql.Append(" and  L.C_name like '%" + key + "%'");
            }

            strSql.Append(") as unioninfo");

            strSql1.Append(@"  select  count(distinct id)  from (
                                select  ce.id FROM crm_customer_end ce left join crm_contact_end L on  ce.id =L.C_customerid_end");
            if (strWhere1.Trim() != "")
            {
                strSql1.Append(" where " + strWhere1);
                strSql1.Append(" and  L.C_name like '%" + key + "%'");
            }
            strSql1.Append("  Union all");
            strSql1.Append(@"  select  cu.id
                               FROM crm_customer as cu
                               inner join ( select distinct(s.Factory_Id) from crm_customer c  inner join sys_factoryinfo s on c.myFactory_Id=s.Factory_Id " + strWhere + "  ) as d on cu.Factory_Id = d.Factory_Id  left join CRM_Contact L on  cu.id = L.C_customerid");
            if (strWhere2.Trim() != "")
            {
                strSql1.Append(" where " + strWhere2);
                strSql1.Append(" and  L.C_name like '%" + key + "%'");
            }
            strSql1.Append(" ) as unioninfo");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }



        //联系方式查询
        public DataSet GetListByTelAll(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append("SELECT  distinct *  from (");
            strSql.Append(" select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum  FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }
            strSql.Append("  Union all");
            strSql.Append(@"   select cu.id,cu.myFactory_Id as Factory_Id ,'',cu.Customer as Customer_end,cu.address,cu.tel,cu.fax,cu.site,cu.industry,cu.Nation,cu.Provinces,cu.City,cu.District,cu.CustomerType,cu.CustomerLevel,cu.CustomerSource,cu.Department_id,cu.Department,
                               cu.Employee_id,cu.Employee,cu.FollowUp_id,cu.FollowUp,cu.CustomerValue_id,cu.CustomerValue,cu.BeSeats_id,cu.BeSeats,cu.BeSeats_depid,cu.BeSeats_depname,cu.privatecustomer_Id,cu.privatecustomer,cu.lastfollow,cu.Create_date,cu.emp_handnum,'' from crm_customer cu                               
                                inner join  (  select s.Factory_Id from crm_customer c  inner join sys_factoryinfo s on c.myFactory_Id=s.Factory_Id  ) as d on cu.Factory_Id = d.Factory_Id ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }
            strSql.Append(") as unioninfo");


            strSql1.Append("select  count(distinct id)  from(");
            strSql1.Append(" select C.id FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid ");
            if (strWhere1.Trim() != "")
            {
                strSql1.Append(" where " + strWhere1);
            }
            strSql1.Append("  Union all");
            strSql1.Append(@"  select  cu.id
                               FROM crm_customer as cu
                               inner join ( select s.Factory_Id from crm_customer c  inner join sys_factoryinfo s on c.myFactory_Id=s.Factory_Id  ) as d on cu.Factory_Id = d.Factory_Id  ");
            if (strWhere2.Trim() != "")
            {
                strSql1.Append(" where " + strWhere2);
            }
            strSql1.Append(") as unioninfo");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 更新最后跟进
        /// </summary>
        public bool UpdateLastFollow(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_end set lastfollow='" + DateTime.Now + "'");
            //strSql.Append("[lastfollow] = isnull((select max(Follow_date) as Followdate from dbo.CRM_Follow where CRM_Customer.id=CRM_Follow.Customer_id),Create_date)");
            strSql.Append(" where crm_customer_end.id=" + id);

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

        //转为我的客户
        public bool ToMyClients(string factory_Id, string customerendId, int customerId, string idList)
        {
            List<string> strSqlList = new List<string>();
            crm_contact_end contactend=new crm_contact_end ();                   //终端客户联系人
            CRM_Contact contact = new CRM_Contact();                             //我的客户联系人
            CRM_Customer customer = new CRM_Customer();
            Model.CRM_Contact modelcontact = new Model.CRM_Contact();

            string strSql = string.Empty;

            //查询终端联系人信息
            DataSet dt = contactend.GetList("C_customerid_end='" + customerendId + "' and isDelete=0");
            if (dt != null && dt.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    //联系人信息添加
                    strSql = string.Format(@"insert into CRM_Contact (Factory_Id,C_name,C_sex,C_department,C_position,C_birthday,C_tel,C_fax,C_email,C_mobone,C_mobtwo,C_QQ,C_add,C_hobby,C_remarks,C_customerid,
                                                                      C_customername,C_createId,C_createDate,isDelete,Delete_time,IsDefaultContact,C_extentel)
                                          values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}' )",
                                          dt.Tables[0].Rows[i]["Factory_Id"].ToString(), dt.Tables[0].Rows[i]["C_name"].ToString(), dt.Tables[0].Rows[i]["C_sex"].ToString(), dt.Tables[0].Rows[i]["C_department"].ToString(),
                                          dt.Tables[0].Rows[i]["C_position"].ToString(), dt.Tables[0].Rows[i]["C_birthday"].ToString(), dt.Tables[0].Rows[i]["C_tel"].ToString(), dt.Tables[0].Rows[i]["C_fax"].ToString(),
                                          dt.Tables[0].Rows[i]["C_email"].ToString(), dt.Tables[0].Rows[i]["C_mobone"].ToString(), dt.Tables[0].Rows[i]["C_mobtwo"].ToString(), dt.Tables[0].Rows[i]["C_QQ"].ToString(),
                                          dt.Tables[0].Rows[i]["C_add"].ToString(), dt.Tables[0].Rows[i]["C_hobby"].ToString(), dt.Tables[0].Rows[i]["C_remarks"].ToString(), customerId, dt.Tables[0].Rows[i]["C_customername_end"].ToString(),
                                          Convert.ToInt32(dt.Tables[0].Rows[i]["C_createId"].ToString()), Convert.ToDateTime(dt.Tables[0].Rows[i]["C_createDate"].ToString()), 0, Convert.ToDateTime(dt.Tables[0].Rows[i]["C_createDate"].ToString()),
                                          Convert.ToInt32(dt.Tables[0].Rows[i]["IsDefaultContact"].ToString()), dt.Tables[0].Rows[i]["C_extentel"].ToString());
                    strSqlList.Add(strSql);
                }
                int rows = DbHelperMySQL.ExecuteSqlTran(strSqlList);
                if (rows > 0)
                {
                    Deletes(idList, 1, factory_Id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    return true;
                }
                else
                {
                    customer.Delete(customerId);
                    return false;
                }
            }
            else
            {
                Deletes(idList, 1, factory_Id, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                return true;
            }
           
        }
        #endregion  BasicMethod

        public DataSet Dealer_customer(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();



            strSql.Append(" select xx.* from(");
            strSql.Append(" select bb.* from(");
            strSql.Append(" select distinct myFactory_Id from crm_customer ");
            strSql1.Append(" select  count(*) from(");
            strSql1.Append(" select bb.* from(");
            strSql1.Append(" select distinct myFactory_Id from crm_customer ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" and (myFactory_Id is not null)) aa  ");
            strSql.Append(" inner join crm_customer bb on aa.myFactory_Id=bb.Factory_Id) xx ");
            strSql.Append(" inner join sys_factoryinfo cc on xx.Factory_Id=cc.Factory_Id  ");
            strSql.Append("  where privatecustomer_id <>'50' ");
            strSql.Append(" union all select  Factory_Id,Customer_end as Customer from crm_customer_end ");
            strSql1.Append(" and (myFactory_Id is not null)) aa  ");

            strSql1.Append(" inner  join crm_customer bb on aa.myFactory_Id=bb.Factory_Id) xx ");
            strSql1.Append(" inner join sys_factoryinfo cc on xx.Factory_Id=cc.Factory_Id  ");
            strSql1.Append("  where privatecustomer_id <>'50' ");
            strSql1.Append(" union all select  Factory_Id,Customer_end as Customer from crm_customer_end  ");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet Dealer_customer_all(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();


            strSql.Append(" select xx.id, xx.Customer,xx.myFactory_Id,xx.tel,xx.CustomerType,xx.CustomerLevel,xx.CustomerSource,xx.FollowUp,xx.CustomerValue,xx.Nation,xx.Provinces,xx.City,xx.District,xx.industry,xx.BeSeats,xx.BeSeats_depname,xx.Employee,xx.Department,xx.privatecustomer,xx.lastfollow,xx.Create_date from(");
            strSql.Append(" select * from(");
            strSql.Append(" (select distinct myFactory_Id from crm_customer ");
            strSql1.Append(" select  sum(num) from(");
            strSql1.Append(" select  count(*) as num from(");
            strSql1.Append(" select bb.* from(");
            strSql1.Append(" select distinct myFactory_Id from crm_customer ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" ) rr inner join  ( ");
            strSql.Append("select Factory_Id from  sys_factoryinfo where IsDelete<>'1' ");
            strSql.Append(")ss on ss.Factory_Id=rr.myFactory_Id ");
            strSql.Append(") ) aa  ");
            strSql.Append("left join crm_customer xx");
            strSql.Append("on aa.myFactory_Id=xx.Factory_Id)");                   
            strSql.Append(" union all select end.id, end.Customer_end as Customer,'' as myFactory_Id,end.tel,end.CustomerType,end.CustomerLevel,end.CustomerSource,end.FollowUp,end.CustomerValue,end.Nation,end.Provinces,end.City,end.District,end.industry,end.BeSeats,end.BeSeats_depname,end.Employee,end.Department,end.privatecustomer,end.lastfollow,end.Create_date from crm_customer_end as end");
            strSql1.Append(" and (myFactory_Id is not null)) aa  ");

            strSql1.Append(" inner  join crm_customer bb on aa.myFactory_Id=bb.Factory_Id) xx ");
            strSql1.Append(" inner join sys_factoryinfo cc on xx.Factory_Id=cc.Factory_Id  ");
            strSql1.Append("  where privatecustomer_id <>'50' ");
            strSql1.Append(" union all select count(*) as num from crm_customer_end  as end) as abc");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

