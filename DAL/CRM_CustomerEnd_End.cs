using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using XHD.DBUtility;

namespace XHD.DAL
{
    public partial class CRM_CustomerEnd_End
    {
        public CRM_CustomerEnd_End()
        { }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XHD.Model.crm_customer_end model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update crm_customer_end set ");
            //strSql.Append("Factory_Id=@Factory_Id,");
            //strSql.Append("Dealer_Id=@Dealer_Id,");
            //strSql.Append("Dealer_Code=@Dealer_Code,");
            //strSql.Append("Dealer_Name=@Dealer_Name,");
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
            //strSql.Append("BeSeats_id=@BeSeats_id,");
            //strSql.Append("BeSeats_uid=@BeSeats_uid,");
            //strSql.Append("BeSeats=@BeSeats,");
            //strSql.Append("BeSeats_depid=@BeSeats_depid,");
            //strSql.Append("BeSeats_depname=@BeSeats_depname,");
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
        /// 大经销商获取终端分页数据列表
        /// </summary>
        public DataSet GetListEnd(int PageSize, int PageIndex, string strWhere, string myfactory_id, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@" select  E.id,E.Dealer_Id,E.Dealer_Code,E.Dealer_Name,E.Factory_Id,E.Serialnumber_end,E.Customer_end,E.address,E.tel,E.fax,E.site,
                                E.industry_id,E.industry,E.Nation_id,E.Nation,E.Provinces_id,E.Provinces,E.City_id,E.City,E.District_id,E.District,
                                E.CustomerType_id,E.CustomerType,E.CustomerLevel_id,E.CustomerLevel,E.CustomerSource_id,E.CustomerSource,E.DesCripe,
                                E.Remarks,E.Department_id,E.Department,E.Employee_id,E.Employee,E.privatecustomer,E.lastfollow,E.Create_id,E.Create_name,
                                E.Create_date,E.isDelete,E.Delete_time,E.FollowUp_id,E.FollowUp,E.CustomerValue_id,E.CustomerValue,E.PhoneIsValid_id,E.state_allot,E.type_belong,E.state_allot_end
                                FROM crm_customer_end  as E inner join crm_customer as C on E.Dealer_Id=C.id and C.myFactory_Id='" + myfactory_id + "'");
            strSql1.Append(" select count(E.id)  FROM crm_customer_end  as E inner join crm_customer as C on E.Dealer_Id=C.id and C.myFactory_Id='" + myfactory_id + "'");
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
        /// 大经销商获取终端数据列表
        /// </summary>
        public DataSet GetListEnd(string strWhere, string myfactory_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@" select  E.id,E.Dealer_Id,E.Dealer_Code,E.Dealer_Name,E.Factory_Id,E.Serialnumber_end,E.Customer_end,E.address,E.tel,E.fax,E.site,
                                E.industry_id,E.industry,E.Nation_id,E.Nation,E.Provinces_id,E.Provinces,E.City_id,E.City,E.District_id,E.District,
                                E.CustomerType_id,E.CustomerType,E.CustomerLevel_id,E.CustomerLevel,E.CustomerSource_id,E.CustomerSource,E.DesCripe,
                                E.Remarks,E.Department_id,E.Department,E.Employee_id,E.Employee,E.privatecustomer,E.lastfollow,E.Create_id,E.Create_name,
                                E.Create_date,E.isDelete,E.Delete_time,E.FollowUp_id,E.FollowUp,E.CustomerValue_id,E.CustomerValue,E.PhoneIsValid_id,E.state_allot,E.type_belong,E.state_allot_end
                                FROM crm_customer_end  as E inner join crm_customer as C on E.Dealer_Id=C.id and C.myFactory_Id='" + myfactory_id + "'");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 通过联系人姓名获取数据
        /// </summary>
        public DataSet GetListContact(int PageSize, int PageIndex, string strWhere, string myfactory_id, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@" select  E.id,E.Dealer_Id,E.Dealer_Code,E.Dealer_Name,E.Factory_Id,E.Serialnumber_end,E.Customer_end,E.address,E.tel,E.fax,E.site,
                                E.industry_id,E.industry,E.Nation_id,E.Nation,E.Provinces_id,E.Provinces,E.City_id,E.City,E.District_id,E.District,
                                E.CustomerType_id,E.CustomerType,E.CustomerLevel_id,E.CustomerLevel,E.CustomerSource_id,E.CustomerSource,E.DesCripe,
                                E.Remarks,E.Department_id,E.Department,E.Employee_id,E.Employee,E.privatecustomer,E.lastfollow,E.Create_id,E.Create_name,
                                E.Create_date,E.isDelete,E.Delete_time,E.FollowUp_id,E.FollowUp,E.CustomerValue_id,E.CustomerValue,E.PhoneIsValid_id,E.state_allot,E.type_belong,E.state_allot_end
                                FROM crm_customer_end  as E inner join crm_customer as C on E.Dealer_Id=C.id and C.myFactory_Id='" + myfactory_id + "' inner join crm_contact_end as T on E.id=T.C_customerid_end ");
            strSql1.Append(" select count(E.id)  FROM crm_customer_end  as E inner join crm_customer as C on E.Dealer_Id=C.id and C.myFactory_Id='" + myfactory_id + "' inner join crm_contact_end as T on E.id=T.C_customerid_end ");
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
        /// 通过联系人姓名获取数据
        /// </summary>
        public DataSet GetListContact(string strWhere, string myfactory_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@" select  E.id,E.Dealer_Id,E.Dealer_Code,E.Dealer_Name,E.Factory_Id,E.Serialnumber_end,E.Customer_end,E.address,E.tel,E.fax,E.site,
                                E.industry_id,E.industry,E.Nation_id,E.Nation,E.Provinces_id,E.Provinces,E.City_id,E.City,E.District_id,E.District,
                                E.CustomerType_id,E.CustomerType,E.CustomerLevel_id,E.CustomerLevel,E.CustomerSource_id,E.CustomerSource,E.DesCripe,
                                E.Remarks,E.Department_id,E.Department,E.Employee_id,E.Employee,E.privatecustomer,E.lastfollow,E.Create_id,E.Create_name,
                                E.Create_date,E.isDelete,E.Delete_time,E.FollowUp_id,E.FollowUp,E.CustomerValue_id,E.CustomerValue,E.PhoneIsValid_id,E.state_allot,E.type_belong,E.state_allot_end
                                FROM crm_customer_end  as E inner join crm_customer as C on E.Dealer_Id=C.id and C.myFactory_Id='" + myfactory_id + "' inner join crm_contact_end as T on E.id=T.C_customerid_end ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //分配终端客户给客服
        public bool publicAllot(string id, XHD.Model.crm_customer_end model)
        {
            string strSql = string.Empty;

            //更改客户表中的关系
            strSql = string.Format(@" update crm_customer_end set Employee_id='{0}',Employee='{1}',Department_id='{2}',Department='{3}',Employee_uid='{4}',state_allot_end='{5}' where id in ({6}) and factory_id='{7}'",
                                     model.BeSeats_id, model.BeSeats, model.BeSeats_depid, model.BeSeats_depname, model.BeSeats_uid, model.state_allot_end, id, model.Factory_Id);
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
    }
}
