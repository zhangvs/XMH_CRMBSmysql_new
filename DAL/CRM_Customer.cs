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
    /// ���ݷ�����:CRM_Customer
    /// </summary>
    public partial class CRM_Customer
    {
        public CRM_Customer()
        { }

        XHD.DAL.ecs_users _ecsuser = new ecs_users();

        #region  Method

        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("id", "CRM_Customer");
        }

        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <returns></returns>
        public int GetCount(string flag, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();

            int count = 0;
            switch (flag.Trim())
            {
                case "myCustomer":  //�ҵĿͻ�
                case "tunLInk":     //����δ��ϵ�ͻ�
                case "sunLink":     //7��δ��ϵ�ͻ�
                case "funLink":     //14��δ��ϵ�ͻ�
                case "munLink":     //����δ��ϵ�ͻ�
                case "dataAllCus":  //����δ��ϵ(����Ȩ����)
                case "reCustomer":  //����վ�ͻ�
                    strSql.Append("select count(id) from CRM_Customer ");
                    if (strWhere.Trim() != "")
                        strSql.Append(" where " + strWhere);

                    count = Convert.ToInt32(DbHelperMySQL.GetSingle(strSql.ToString()));

                    break;
                case "todayUnPhone":    //����δ�ӵ绰
                case "tadayPhone":      //���յ绰
                case "yesterdayPhone":  //����δ��
                    strSql = new StringBuilder();
                    count = 0;

                    strSql.Append("select count(id) from HJ_Phone_Records");
                    if (strWhere.Trim() != "")
                        strSql.Append(" where " + strWhere);

                    count = Convert.ToInt32(DbHelperMySQL.GetSingle(strSql.ToString()));
                    break;
                default:
                    break;
            }

            #region   ��ʷ

            /*
            //�ҵĿͻ�������δ��ϵ�ͻ���7��δ��ϵ�ͻ���14��δ��ϵ�ͻ�������δ��ϵ�ͻ�������δ��ϵ(����Ȩ����)������վ�ͻ�
            if (flag == "myCustomer" || flag == "tunLInk" || flag == "sunLink" || flag == "funLink" || flag == "munLink" || flag == "dataAllCus" || flag == "reCustomer")
            {
                strSql.Append("select count(1) from CRM_Customer");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" where " + strWhere);
                }

                count = Convert.ToInt32(DbHelperMySQL.GetSingle(strSql.ToString()));
            }
            //����δ�ӵ绰�����յ绰������δ��
            else if (flag == "todayUnPhone" || flag == "tadayPhone" || flag == "yesterdayPhone")
            {
                strSql.Append("select count(1) from HJ_Phone_Records");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" where " + strWhere);
                }
                count = Convert.ToInt32(DbHelperMySQL.GetSingle(strSql.ToString()));
            }
             * */
            #endregion

            return count;
        }



        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CRM_Customer");
            strSql.Append(" where id=@id ");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = id;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(XHD.Model.CRM_Customer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CRM_Customer(");
            strSql.Append("Factory_Id,Serialnumber,Customer,address,tel,fax,site,industry_id,industry,Nation_id,Nation,Provinces_id,Provinces,City_id,City,District_id,District,CustomerType_id,CustomerType,CustomerLevel_id,CustomerLevel,CustomerSource_id,CustomerSource,DesCripe,Remarks,Department_id,Department,Employee_id,Employee_uid,Employee,FollowUp_id,FollowUp,CustomerValue_id,CustomerValue,PhoneIsValid_id,PhoneIsValid,BeSeats_id,BeSeats_uid,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,lastfollow,Create_id,Create_name,Create_date,isDelete,Delete_time)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@Serialnumber,@Customer,@address,@tel,@fax,@site,@industry_id,@industry,@Nation_id,@Nation,@Provinces_id,@Provinces,@City_id,@City,@District_id,@District,@CustomerType_id,@CustomerType,@CustomerLevel_id,@CustomerLevel,@CustomerSource_id,@CustomerSource,@DesCripe,@Remarks,@Department_id,@Department,@Employee_id,@Employee_uid,@Employee,@FollowUp_id,@FollowUp,@CustomerValue_id,@CustomerValue,@PhoneIsValid_id,@PhoneIsValid,@BeSeats_id,@BeSeats_uid,@BeSeats,@BeSeats_depid,@BeSeats_depname,@privatecustomer_Id,@privatecustomer,@lastfollow,@Create_id,@Create_name,@Create_date,@isDelete,@Delete_time)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarString,60),
					new MySqlParameter("@Serialnumber", MySqlDbType.VarChar,250),
					new MySqlParameter("@Customer", MySqlDbType.VarChar,250),
					new MySqlParameter("@address", MySqlDbType.VarChar,250),
					new MySqlParameter("@tel", MySqlDbType.VarChar,250),
					new MySqlParameter("@fax", MySqlDbType.VarChar,250),
					new MySqlParameter("@site", MySqlDbType.VarChar,250),
					new MySqlParameter("@industry_id", MySqlDbType.Int32,4),
					new MySqlParameter("@industry", MySqlDbType.VarChar,250),
					new MySqlParameter("@Nation_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Nation", MySqlDbType.VarChar,250),
					new MySqlParameter("@Provinces_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Provinces", MySqlDbType.VarChar,250),
					new MySqlParameter("@City_id", MySqlDbType.Int32,4),
					new MySqlParameter("@City", MySqlDbType.VarChar,250),
					new MySqlParameter("@District_id", MySqlDbType.Int32,4),
					new MySqlParameter("@District", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerType_id", MySqlDbType.Int32,4),
					new MySqlParameter("@CustomerType", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerLevel_id", MySqlDbType.Int32,4),
					new MySqlParameter("@CustomerLevel", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerSource_id", MySqlDbType.Int32,4),
					new MySqlParameter("@CustomerSource", MySqlDbType.VarChar,250),
					new MySqlParameter("@DesCripe", MySqlDbType.VarChar,4000),
					new MySqlParameter("@Remarks", MySqlDbType.VarChar,4000),
					new MySqlParameter("@Department_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Department", MySqlDbType.VarChar,250),
					new MySqlParameter("@Employee_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Employee_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@Employee", MySqlDbType.VarChar,250),
					new MySqlParameter("@FollowUp_id", MySqlDbType.Int32,4),
					new MySqlParameter("@FollowUp", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerValue_id", MySqlDbType.Int32,4),
					new MySqlParameter("@CustomerValue", MySqlDbType.VarChar,250),
					new MySqlParameter("@PhoneIsValid_id", MySqlDbType.Int32,4),
					new MySqlParameter("@PhoneIsValid", MySqlDbType.VarChar,250),
					new MySqlParameter("@BeSeats_id", MySqlDbType.Int32,4),
					new MySqlParameter("@BeSeats_uid", MySqlDbType.VarChar,100),
					new MySqlParameter("@BeSeats", MySqlDbType.VarChar,250),
                    new MySqlParameter("@BeSeats_depid", MySqlDbType.Int32,4),
					new MySqlParameter("@BeSeats_depname", MySqlDbType.VarChar,250),
					new MySqlParameter("@privatecustomer_Id", MySqlDbType.Int32,4),
					new MySqlParameter("@privatecustomer", MySqlDbType.VarChar,50),
					new MySqlParameter("@lastfollow", MySqlDbType.DateTime),
					new MySqlParameter("@Create_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Create_name", MySqlDbType.VarChar,250),
					new MySqlParameter("@Create_date", MySqlDbType.DateTime),
					new MySqlParameter("@isDelete", MySqlDbType.Int32,4),
					new MySqlParameter("@Delete_time", MySqlDbType.DateTime)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Serialnumber;
            parameters[2].Value = model.Customer;
            parameters[3].Value = model.address;
            parameters[4].Value = model.tel;
            parameters[5].Value = model.fax;
            parameters[6].Value = model.site;
            parameters[7].Value = model.industry_id;
            parameters[8].Value = model.industry;
            parameters[9].Value = model.Nation_id;
            parameters[10].Value = model.Nation;
            parameters[11].Value = model.Provinces_id;
            parameters[12].Value = model.Provinces;
            parameters[13].Value = model.City_id;
            parameters[14].Value = model.City;
            parameters[15].Value = model.District_id;
            parameters[16].Value = model.District;
            parameters[17].Value = model.CustomerType_id;
            parameters[18].Value = model.CustomerType;
            parameters[19].Value = model.CustomerLevel_id;
            parameters[20].Value = model.CustomerLevel;
            parameters[21].Value = model.CustomerSource_id;
            parameters[22].Value = model.CustomerSource;
            parameters[23].Value = model.DesCripe;
            parameters[24].Value = model.Remarks;
            parameters[25].Value = model.Department_id;
            parameters[26].Value = model.Department;
            parameters[27].Value = model.Employee_id;
            parameters[28].Value = model.Employee_uid;
            parameters[29].Value = model.Employee;
            parameters[30].Value = model.FollowUp_id;
            parameters[31].Value = model.FollowUp;
            parameters[32].Value = model.CustomerValue_id;
            parameters[33].Value = model.CustomerValue;
            parameters[34].Value = model.PhoneIsValid_id;
            parameters[35].Value = model.PhoneIsValid;
            parameters[36].Value = model.BeSeats_id;
            parameters[37].Value = model.BeSeats_uid;
            parameters[38].Value = model.BeSeats;
            parameters[39].Value = model.BeSeats_depid;
            parameters[40].Value = model.BeSeats_depname;
            parameters[41].Value = model.privatecustomer_Id;
            parameters[42].Value = model.privatecustomer;
            parameters[43].Value = model.lastfollow;
            parameters[44].Value = model.Create_id;
            parameters[45].Value = model.Create_name;
            parameters[46].Value = model.Create_date;
            parameters[47].Value = model.isDelete;
            parameters[48].Value = model.Delete_time;

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
        /// ����һ������
        /// </summary>  
        /// 
        public bool Update(XHD.Model.CRM_Customer model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Customer set ");
            strSql.Append("Serialnumber=@Serialnumber,");
            strSql.Append("Customer=@Customer,");
            strSql.Append("address=@address,");
            strSql.Append("tel=@tel,");
            strSql.Append("fax=@fax,");
            strSql.Append("site=@site,");
            strSql.Append("industry=@industry,");
            strSql.Append("Provinces_id=@Provinces_id,");
            strSql.Append("Provinces=@Provinces,");
            strSql.Append("City_id=@City_id,");
            strSql.Append("City=@City,");
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
            strSql.Append("Employee=@Employee,");
            strSql.Append("privatecustomer=@privatecustomer,");
            strSql.Append("industry_id=@industry_id,");
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
            strSql.Append("Nation_id=@Nation_id,");
            strSql.Append("Nation=@Nation,");
            strSql.Append("District_id=@District_id,");
            strSql.Append("District=@District,");
            strSql.Append("emp_handnum=@emp_handnum");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Serialnumber", MySqlDbType.VarChar,250),
					new MySqlParameter("@Customer", MySqlDbType.VarChar,250),
					new MySqlParameter("@address", MySqlDbType.VarChar,250),
					new MySqlParameter("@tel", MySqlDbType.VarChar,250),
					new MySqlParameter("@fax", MySqlDbType.VarChar,250),
					new MySqlParameter("@site", MySqlDbType.VarChar,250),
					new MySqlParameter("@industry", MySqlDbType.VarChar,250),
					new MySqlParameter("@Provinces_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Provinces", MySqlDbType.VarChar,250),
					new MySqlParameter("@City_id", MySqlDbType.Int32,4),
					new MySqlParameter("@City", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerType_id", MySqlDbType.Int32,4),
					new MySqlParameter("@CustomerType", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerLevel_id", MySqlDbType.Int32,4),
					new MySqlParameter("@CustomerLevel", MySqlDbType.VarChar,250),
					new MySqlParameter("@CustomerSource_id", MySqlDbType.Int32,4),
					new MySqlParameter("@CustomerSource", MySqlDbType.VarChar,250),
					new MySqlParameter("@DesCripe", MySqlDbType.VarChar,4000),
					new MySqlParameter("@Remarks", MySqlDbType.VarChar,4000),
					new MySqlParameter("@Department_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Department", MySqlDbType.VarChar,250),
					new MySqlParameter("@Employee_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Employee", MySqlDbType.VarChar,250),
					new MySqlParameter("@privatecustomer", MySqlDbType.VarChar,50),
                    new MySqlParameter("@industry_id",MySqlDbType.Int32,4),
                    new MySqlParameter("@FollowUp_id",MySqlDbType.Int32,4),
                    new MySqlParameter("@FollowUp",MySqlDbType.VarChar,250),
                    new MySqlParameter("@CustomerValue_id",MySqlDbType.Int32,4),
                    new MySqlParameter("@CustomerValue",MySqlDbType.VarChar,250),
                    new MySqlParameter("@PhoneIsValid_id",MySqlDbType.Int32,4),
                    new MySqlParameter("@PhoneIsValid",MySqlDbType.VarChar,250),
                    new MySqlParameter("@BeSeats_id",MySqlDbType.Int32,4),
                    new MySqlParameter("@BeSeats_uid",MySqlDbType.VarChar,100),
                    new MySqlParameter("@BeSeats",MySqlDbType.VarChar,250),
                    new MySqlParameter("@BeSeats_depid", MySqlDbType.Int32,4),
					new MySqlParameter("@BeSeats_depname", MySqlDbType.VarChar,250),
                    new MySqlParameter("@privatecustomer_Id",MySqlDbType.Int32,4),
                    new MySqlParameter("@Nation_id",MySqlDbType.Int32,4),
                    new MySqlParameter("@Nation",MySqlDbType.VarChar,250),
                    new MySqlParameter("@District_id",MySqlDbType.Int32,4),
                    new MySqlParameter("@District",MySqlDbType.VarChar,250),
                    new MySqlParameter("@emp_handnum",MySqlDbType.Int32,4),
					new MySqlParameter("@id", MySqlDbType.Int32,4)};
            parameters[0].Value = model.Serialnumber;
            parameters[1].Value = model.Customer;
            parameters[2].Value = model.address;
            parameters[3].Value = model.tel;
            parameters[4].Value = model.fax;
            parameters[5].Value = model.site;
            parameters[6].Value = model.industry;
            parameters[7].Value = model.Provinces_id;
            parameters[8].Value = model.Provinces;
            parameters[9].Value = model.City_id;
            parameters[10].Value = model.City;
            parameters[11].Value = model.CustomerType_id;
            parameters[12].Value = model.CustomerType;
            parameters[13].Value = model.CustomerLevel_id;
            parameters[14].Value = model.CustomerLevel;
            parameters[15].Value = model.CustomerSource_id;
            parameters[16].Value = model.CustomerSource;
            parameters[17].Value = model.DesCripe;
            parameters[18].Value = model.Remarks;
            parameters[19].Value = model.Department_id;
            parameters[20].Value = model.Department;
            parameters[21].Value = model.Employee_id;
            parameters[22].Value = model.Employee;
            parameters[23].Value = model.privatecustomer;
            parameters[24].Value = model.industry_id;
            parameters[25].Value = model.FollowUp_id;
            parameters[26].Value = model.FollowUp;
            parameters[27].Value = model.CustomerValue_id;
            parameters[28].Value = model.CustomerValue;
            parameters[29].Value = model.PhoneIsValid_id;
            parameters[30].Value = model.PhoneIsValid;
            parameters[31].Value = model.BeSeats_id;
            parameters[32].Value = model.BeSeats_uid;
            parameters[33].Value = model.BeSeats;
            parameters[34].Value = model.BeSeats_depid;
            parameters[35].Value = model.BeSeats_depname;
            parameters[36].Value = model.privatecustomer_Id;
            parameters[37].Value = model.Nation_id;
            parameters[38].Value = model.Nation;
            parameters[39].Value = model.District_id;
            parameters[40].Value = model.District;
            parameters[41].Value = model.emp_handnum;
            parameters[42].Value = model.id;

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
        public bool Transfer(XHD.Model.CRM_Customer model, XHD.Model.ecs_admin_user adminModel, string c_tel)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;
            string strWhere = string.Empty;
            //���Ŀͻ����еĹ�ϵ
            strSql = string.Format(@"update CRM_Customer set Serialnumber='{0}',Customer='{1}',address='{2}',tel='{3}',fax='{4}',site='{5}',industry='{6}',Provinces_id='{7}',
                                     Provinces='{8}',City_id='{9}',City='{10}',CustomerType_id='{11}',CustomerType='{12}',CustomerLevel_id='{13}',CustomerLevel='{14}',CustomerSource_id='{15}',
                                     CustomerSource='{16}',DesCripe='{17}',Remarks='{18}',Department_id='{19}',Department='{20}',Employee_id='{21}',Employee='{22}',privatecustomer='{23}',
                                     industry_id='{24}',FollowUp_id='{25}',FollowUp='{26}',CustomerValue_id='{27}',CustomerValue='{28}',PhoneIsValid_id='{29}',PhoneIsValid='{30}',
                                     BeSeats_id='{31}',BeSeats_uid='{32}',BeSeats='{33}',BeSeats_depid='{34}',BeSeats_depname='{35}',privatecustomer_Id='{36}',Nation_id='{37}',
                                     Nation='{38}',District_id='{39}',District='{40}' where id='{41}'",
                                     model.Serialnumber, model.Customer, model.address, model.tel, model.fax, model.site, model.industry, model.Provinces_id, model.Provinces,
                                     model.City_id, model.City, model.CustomerType_id, model.CustomerType, model.CustomerLevel_id, model.CustomerLevel, model.CustomerSource_id,
                                     model.CustomerSource, model.DesCripe, model.Remarks, model.Department_id, model.Department, model.Employee_id, model.Employee, model.privatecustomer,
                                     model.industry_id, model.FollowUp_id, model.FollowUp, model.CustomerValue_id, model.CustomerValue, model.PhoneIsValid_id, model.PhoneIsValid,
                                     model.BeSeats_id, model.BeSeats_uid, model.BeSeats, model.BeSeats_depid, model.BeSeats_depname, model.privatecustomer_Id, model.Nation_id,
                                     model.Nation, model.District_id, model.District, model.id);

            strSqlList.Add(strSql);

            if (!string.IsNullOrEmpty(c_tel))
            {
                if (model.Factory_Id == "1000")
                    strWhere = " and dealer_id=0";
                else
                    strWhere = " and dealer_id=4";

                //1.��ѯ�̳����Ƿ���ڸÿͻ�
                DataSet ds = _ecsuser.GetListId(" user_name in (" + c_tel + ") " + strWhere + "");

                //2.�����̳��϶Կͻ�����ϯ
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
        /// ����ת�ͻ�
        /// </summary>
        public bool Update_batch(XHD.Model.CRM_Customer model, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Customer set ");
            strSql.Append("BeSeats_depid=@BeSeats_depid,");
            strSql.Append("BeSeats_depname=@BeSeats_depname,");
            strSql.Append("BeSeats_id=@BeSeats_id,");
            strSql.Append("BeSeats=@BeSeats");
            // strSql.Append(" where BeSeats_id=@Create_id");
            if (strWhere.Trim() != "")
            {
                //strSql.Append(" and " + strWhere);
                strSql.Append(" where " + strWhere);
            }
            MySqlParameter[] parameters = {					
					new MySqlParameter("@BeSeats_depid", MySqlDbType.Int32,4),
					new MySqlParameter("@BeSeats_depname", MySqlDbType.VarChar,250),
					new MySqlParameter("@BeSeats_id", MySqlDbType.Int32,4),
					new MySqlParameter("@BeSeats", MySqlDbType.VarChar,250),
                    new MySqlParameter("@Create_id", MySqlDbType.Int32,4)
                                        };
            parameters[0].Value = model.BeSeats_depid;
            parameters[1].Value = model.BeSeats_depname;
            parameters[2].Value = model.Employee_id;
            parameters[3].Value = model.Employee;
            parameters[4].Value = model.Create_id;

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
        /// ����ת�ͻ�Ϊ����
        /// </summary>
        public bool TransferMass(string id, string factory_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Customer set ");
            strSql.Append("privatecustomer='����'");
            strSql.Append(",privatecustomer_Id=(select id from  Param_SysParam where params_name='����' and parentid=12 and Factory_Id='" + factory_Id + "' limit 1)");
            strSql.Append(" where id  in(" + id + ")");
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
        /// �޸�emp_handnum������
        /// </summary>
        public bool UpdateHandNumById(int id, int emp_handnum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Customer set emp_handnum='" + emp_handnum + "'");
            strSql.Append("  where id = " + id);
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
        /// ����ת�ͻ���ĳһԱ��
        /// </summary>
        public bool TransferPrivate(string id, int empId, string dep, int depId, string factory_Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Customer set ");
            strSql.Append("privatecustomer='˽��'");
            strSql.Append(",privatecustomer_Id=(select id from  Param_SysParam where params_name='˽��' and parentid=12 and Factory_Id='" + factory_Id + "' limit 1)");
            strSql.Append(",BeSeats_id='" + empId + "'");
            strSql.Append(",BeSeats_uid=(select  uid from hr_employee where ID='" + empId + "' and Factory_Id='" + factory_Id + "' limit 1)");
            strSql.Append(",BeSeats=(select name from hr_employee where ID='" + empId + "' and Factory_Id='" + factory_Id + "' limit 1)");
            strSql.Append(",BeSeats_depname='" + dep + "'");
            strSql.Append(",BeSeats_depid='" + depId + "'");
            strSql.Append(" where id  in(" + id + ")");

            int rows = DbHelperMySQL.ExecuteSql(strSql.ToString());
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
        /// ����ת�ͻ���ĳһԱ��
        /// </summary>
        public bool TransferPrivates(string id, XHD.Model.hr_employee model, XHD.Model.ecs_admin_user adminModel, string c_tel)
        {
            List<string> strSqlList = new List<string>();
            string strSql = string.Empty;
            string strWhere = string.Empty;

            //���Ŀͻ����еĹ�ϵ
            strSql = string.Format(@" update CRM_Customer set privatecustomer='˽��',privatecustomer_Id=(select id from  Param_SysParam where params_name='˽��' and parentid=12 limit 1), 
                                     BeSeats_id='{0}',BeSeats_uid=(select  uid from hr_employee where ID='{1}' and Factory_Id='{2}' limit 1),
                                     BeSeats=(select name from hr_employee where ID='{3}' and Factory_Id='{4}' limit 1),
                                     BeSeats_depname='{5}',BeSeats_depid='{6}' where id in ({7})",
                                     model.ID, model.ID, model.factory_Id, model.ID, model.factory_Id, model.dname, model.d_id, id);

            strSqlList.Add(strSql);

            if (!string.IsNullOrEmpty(c_tel))
            {
                //1.��ѯ�̳����Ƿ���ڸÿͻ�
                if (model.factory_Id == "1000")
                    strWhere = " and dealer_id=0";
                else if (model.factory_Id == "1005")
                    strWhere = " and dealer_id=4";

                DataSet ds = _ecsuser.GetListId(" user_name in (" + c_tel.Trim() + ") " + strWhere + "");

                //2.�����̳��϶Կͻ�����ϯ
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        int userId = Convert.ToInt32(ds.Tables[0].Rows[i]["user_id"]);
                        strSql = string.Format(@" update ecs_users set user_market_area='{0}', admin_user_name='{1}',admin_user_id='{2}',admin_u_real_name='{3}' where user_id = '{4}'",
                                                 adminModel.admin_market_area, adminModel.user_name, adminModel.user_id, adminModel.real_name, userId);

                        #region ��־
                        //DAL.Sys_log log = new DAL.Sys_log();
                        //Model.Sys_log logModel = new Model.Sys_log();
                        //logModel.Factory_Id = model.factory_Id;
                        //logModel.EventType = "�ͻ�ת��";
                        //logModel.EventID = userId.ToString();
                        //logModel.EventTitle = "�ͻ�ת��";
                        //logModel.Original_txt = strSql;
                        //logModel.Current_txt = strSql;
                        //logModel.UserID = adminModel.user_id;
                        //logModel.UserName = adminModel.real_name;
                        //logModel.IPStreet = "";
                        //logModel.EventDate = DateTime.Now;
                        //log.Add(logModel);
                        #endregion

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
        /// Ԥɾ��
        /// </summary>
        public bool AdvanceDelete(int id, int isDelete, string time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Customer set ");
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
        /// Ԥɾ��
        /// </summary>
        public bool AdvanceDeletes(string id, int isDelete, string factory_Id, string time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Customer set ");
            strSql.Append("isDelete=" + isDelete);
            strSql.Append(",Delete_time='" + time + "'");
            strSql.Append(" where id  in(" + id + ") and Factory_Id='" + factory_Id + "'");
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
        /// �ҵĿͻ�ɾ��
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDelete"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool Deletes(string id, int isDelete, string factory_Id, string time)
        {
            List<string> strSqlList = new List<string>();
            //�޸Ŀͻ���״̬
            string strSql = string.Format(@"update CRM_Customer set isDelete='{0}',Delete_time='{1}' where id in ({2}) and Factory_Id='{3}'", isDelete, time, id, factory_Id);
            strSqlList.Add(strSql);

            //�޸Ŀͻ�����ϵ�˵���Ϣ
            strSql = string.Format(@"update crm_contact set isDelete='{0}',Delete_time='{1}' where  C_customerid in ({2}) and Factory_Id='{3}'", isDelete, time, id, factory_Id);
            strSqlList.Add(strSql);

            //�޸Ŀͻ��ĸ�����Ϣ
            strSql = string.Format(@"update crm_follow set isDelete='{0}',Delete_time='{1}' where Customer_id in ({2}) and Factory_Id='{3}'", isDelete, time, id, factory_Id);
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
        /// ɾ��һ������
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CRM_Customer ");
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
        /// ɾ���������
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        public bool DeleteAll(string idList, string factory_Id)
        {
            List<string> strSqlList = new List<string>();
            //�޸Ŀͻ���״̬
            string strSql = string.Format(@"Delete from CRM_Customer where id in ({0}) and Factory_Id='{1}'", idList, factory_Id);
            strSqlList.Add(strSql);

            //�޸Ŀͻ�����ϵ�˵���Ϣ
            strSql = string.Format(@"Delete from crm_contact where  C_customerid in ({0}) and Factory_Id='{1}'", idList, factory_Id);
            strSqlList.Add(strSql);

            //�޸Ŀͻ��ĸ�����Ϣ
            strSql = string.Format(@"Delete from crm_follow where Customer_id in ({0}) and Factory_Id='{1}'", idList, factory_Id);
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
        /// ɾ��һ������
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CRM_Customer ");
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
        /// �õ�һ������ʵ��
        /// </summary>
        public XHD.Model.CRM_Customer GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select  id,Factory_Id,myFactory_Id,Serialnumber,Customer,address,tel,fax,site,industry_id,industry,Nation_id,Nation,Provinces_id,Provinces,
                        City_id,City,District_id,District,CustomerType_id,CustomerType,CustomerLevel_id,CustomerLevel,CustomerSource_id,CustomerSource,DesCripe,
                        Remarks,Department_id,Department,Employee_id,Employee_uid,Employee,FollowUp_id,FollowUp,CustomerValue_id,CustomerValue,PhoneIsValid_id,
                        PhoneIsValid,BeSeats_id,BeSeats_uid,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,lastfollow,Create_id,Create_name,
                        Create_date,isDelete,Delete_time,emp_handnum from CRM_Customer ");
            strSql.Append(" where id=@id  limit 1");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,4)
            };
            parameters[0].Value = id;

            XHD.Model.CRM_Customer model = new XHD.Model.CRM_Customer();
            DataSet ds = DbHelperMySQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Factory_Id"] != null)
                {
                    model.Factory_Id = ds.Tables[0].Rows[0]["Factory_Id"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Serialnumber"] != null)
                {
                    model.Serialnumber = ds.Tables[0].Rows[0]["Serialnumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Customer"] != null)
                {
                    model.Customer = ds.Tables[0].Rows[0]["Customer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["address"] != null)
                {
                    model.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["tel"] != null)
                {
                    model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fax"] != null)
                {
                    model.fax = ds.Tables[0].Rows[0]["fax"].ToString();
                }
                if (ds.Tables[0].Rows[0]["site"] != null)
                {
                    model.site = ds.Tables[0].Rows[0]["site"].ToString();
                }
                if (ds.Tables[0].Rows[0]["industry_id"] != null && ds.Tables[0].Rows[0]["industry_id"].ToString() != "")
                {
                    model.industry_id = int.Parse(ds.Tables[0].Rows[0]["industry_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["industry"] != null)
                {
                    model.industry = ds.Tables[0].Rows[0]["industry"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Nation_id"] != null && ds.Tables[0].Rows[0]["Nation_id"].ToString() != "")
                {
                    model.Nation_id = int.Parse(ds.Tables[0].Rows[0]["Nation_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Nation"] != null)
                {
                    model.Nation = ds.Tables[0].Rows[0]["Nation"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Provinces_id"] != null && ds.Tables[0].Rows[0]["Provinces_id"].ToString() != "")
                {
                    model.Provinces_id = int.Parse(ds.Tables[0].Rows[0]["Provinces_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Provinces"] != null)
                {
                    model.Provinces = ds.Tables[0].Rows[0]["Provinces"].ToString();
                }
                if (ds.Tables[0].Rows[0]["City_id"] != null && ds.Tables[0].Rows[0]["City_id"].ToString() != "")
                {
                    model.City_id = int.Parse(ds.Tables[0].Rows[0]["City_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["City"] != null)
                {
                    model.City = ds.Tables[0].Rows[0]["City"].ToString();
                }
                if (ds.Tables[0].Rows[0]["District_id"] != null && ds.Tables[0].Rows[0]["District_id"].ToString() != "")
                {
                    model.District_id = int.Parse(ds.Tables[0].Rows[0]["District_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["District"] != null)
                {
                    model.District = ds.Tables[0].Rows[0]["District"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CustomerType_id"] != null && ds.Tables[0].Rows[0]["CustomerType_id"].ToString() != "")
                {
                    model.CustomerType_id = int.Parse(ds.Tables[0].Rows[0]["CustomerType_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CustomerType"] != null)
                {
                    model.CustomerType = ds.Tables[0].Rows[0]["CustomerType"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CustomerLevel_id"] != null && ds.Tables[0].Rows[0]["CustomerLevel_id"].ToString() != "")
                {
                    model.CustomerLevel_id = int.Parse(ds.Tables[0].Rows[0]["CustomerLevel_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CustomerLevel"] != null)
                {
                    model.CustomerLevel = ds.Tables[0].Rows[0]["CustomerLevel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CustomerSource_id"] != null && ds.Tables[0].Rows[0]["CustomerSource_id"].ToString() != "")
                {
                    model.CustomerSource_id = int.Parse(ds.Tables[0].Rows[0]["CustomerSource_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CustomerSource"] != null)
                {
                    model.CustomerSource = ds.Tables[0].Rows[0]["CustomerSource"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DesCripe"] != null)
                {
                    model.DesCripe = ds.Tables[0].Rows[0]["DesCripe"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Remarks"] != null)
                {
                    model.Remarks = ds.Tables[0].Rows[0]["Remarks"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Department_id"] != null && ds.Tables[0].Rows[0]["Department_id"].ToString() != "")
                {
                    model.Department_id = int.Parse(ds.Tables[0].Rows[0]["Department_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Department"] != null)
                {
                    model.Department = ds.Tables[0].Rows[0]["Department"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Employee_id"] != null && ds.Tables[0].Rows[0]["Employee_id"].ToString() != "")
                {
                    model.Employee_id = int.Parse(ds.Tables[0].Rows[0]["Employee_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Employee_uid"] != null)
                {
                    model.Employee_uid = ds.Tables[0].Rows[0]["Employee_uid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Employee"] != null)
                {
                    model.Employee = ds.Tables[0].Rows[0]["Employee"].ToString();
                }
                if (ds.Tables[0].Rows[0]["FollowUp_id"] != null && ds.Tables[0].Rows[0]["FollowUp_id"].ToString() != "")
                {
                    model.FollowUp_id = int.Parse(ds.Tables[0].Rows[0]["FollowUp_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FollowUp"] != null)
                {
                    model.FollowUp = ds.Tables[0].Rows[0]["FollowUp"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CustomerValue_id"] != null && ds.Tables[0].Rows[0]["CustomerValue_id"].ToString() != "")
                {
                    model.CustomerValue_id = int.Parse(ds.Tables[0].Rows[0]["CustomerValue_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CustomerValue"] != null)
                {
                    model.CustomerValue = ds.Tables[0].Rows[0]["CustomerValue"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PhoneIsValid_id"] != null && ds.Tables[0].Rows[0]["PhoneIsValid_id"].ToString() != "")
                {
                    model.PhoneIsValid_id = int.Parse(ds.Tables[0].Rows[0]["PhoneIsValid_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PhoneIsValid"] != null)
                {
                    model.PhoneIsValid = ds.Tables[0].Rows[0]["PhoneIsValid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BeSeats_id"] != null && ds.Tables[0].Rows[0]["BeSeats_id"].ToString() != "")
                {
                    model.BeSeats_id = int.Parse(ds.Tables[0].Rows[0]["BeSeats_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BeSeats_uid"] != null)
                {
                    model.BeSeats_uid = ds.Tables[0].Rows[0]["BeSeats_uid"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BeSeats"] != null)
                {
                    model.BeSeats = ds.Tables[0].Rows[0]["BeSeats"].ToString();
                }
                if (ds.Tables[0].Rows[0]["BeSeats_depid"] != null && ds.Tables[0].Rows[0]["BeSeats_depid"].ToString() != "")
                {
                    model.BeSeats_depid = int.Parse(ds.Tables[0].Rows[0]["BeSeats_depid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BeSeats_depname"] != null)
                {
                    model.BeSeats_depname = ds.Tables[0].Rows[0]["BeSeats_depname"].ToString();
                }
                if (ds.Tables[0].Rows[0]["privatecustomer_Id"] != null && ds.Tables[0].Rows[0]["privatecustomer_Id"].ToString() != "")
                {
                    model.privatecustomer_Id = int.Parse(ds.Tables[0].Rows[0]["privatecustomer_Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["privatecustomer"] != null)
                {
                    model.privatecustomer = ds.Tables[0].Rows[0]["privatecustomer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["lastfollow"] != null && ds.Tables[0].Rows[0]["lastfollow"].ToString() != "")
                {
                    model.lastfollow = DateTime.Parse(ds.Tables[0].Rows[0]["lastfollow"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Create_id"] != null && ds.Tables[0].Rows[0]["Create_id"].ToString() != "")
                {
                    model.Create_id = int.Parse(ds.Tables[0].Rows[0]["Create_id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Create_name"] != null)
                {
                    model.Create_name = ds.Tables[0].Rows[0]["Create_name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Create_date"] != null && ds.Tables[0].Rows[0]["Create_date"].ToString() != "")
                {
                    model.Create_date = DateTime.Parse(ds.Tables[0].Rows[0]["Create_date"].ToString());
                }
                if (ds.Tables[0].Rows[0]["isDelete"] != null && ds.Tables[0].Rows[0]["isDelete"].ToString() != "")
                {
                    model.isDelete = int.Parse(ds.Tables[0].Rows[0]["isDelete"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Delete_time"] != null && ds.Tables[0].Rows[0]["Delete_time"].ToString() != "")
                {
                    model.Delete_time = DateTime.Parse(ds.Tables[0].Rows[0]["Delete_time"].ToString());
                }

                //if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                //{
                //    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["Serialnumber"] != null && ds.Tables[0].Rows[0]["Serialnumber"].ToString() != "")
                //{
                //    model.Serialnumber = ds.Tables[0].Rows[0]["Serialnumber"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["Customer"] != null && ds.Tables[0].Rows[0]["Customer"].ToString() != "")
                //{
                //    model.Customer = ds.Tables[0].Rows[0]["Customer"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["address"] != null && ds.Tables[0].Rows[0]["address"].ToString() != "")
                //{
                //    model.address = ds.Tables[0].Rows[0]["address"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["tel"] != null && ds.Tables[0].Rows[0]["tel"].ToString() != "")
                //{
                //    model.tel = ds.Tables[0].Rows[0]["tel"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["fax"] != null && ds.Tables[0].Rows[0]["fax"].ToString() != "")
                //{
                //    model.fax = ds.Tables[0].Rows[0]["fax"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["site"] != null && ds.Tables[0].Rows[0]["site"].ToString() != "")
                //{
                //    model.site = ds.Tables[0].Rows[0]["site"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["industry"] != null && ds.Tables[0].Rows[0]["industry"].ToString() != "")
                //{
                //    model.industry = ds.Tables[0].Rows[0]["industry"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["Nation_id"] != null && ds.Tables[0].Rows[0]["Nation_id"].ToString() != "")
                //{
                //    model.Provinces_id = int.Parse(ds.Tables[0].Rows[0]["Nation_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["Nation"] != null && ds.Tables[0].Rows[0]["Nation"].ToString() != "")
                //{
                //    model.Provinces = ds.Tables[0].Rows[0]["Nation"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["Provinces_id"] != null && ds.Tables[0].Rows[0]["Provinces_id"].ToString() != "")
                //{
                //    model.Provinces_id = int.Parse(ds.Tables[0].Rows[0]["Provinces_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["Provinces"] != null && ds.Tables[0].Rows[0]["Provinces"].ToString() != "")
                //{
                //    model.Provinces = ds.Tables[0].Rows[0]["Provinces"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["City_id"] != null && ds.Tables[0].Rows[0]["City_id"].ToString() != "")
                //{
                //    model.City_id = int.Parse(ds.Tables[0].Rows[0]["City_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["City"] != null && ds.Tables[0].Rows[0]["City"].ToString() != "")
                //{
                //    model.City = ds.Tables[0].Rows[0]["City"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["District_id"] != null && ds.Tables[0].Rows[0]["District_id"].ToString() != "")
                //{
                //    model.City_id = int.Parse(ds.Tables[0].Rows[0]["District_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["District"] != null && ds.Tables[0].Rows[0]["District"].ToString() != "")
                //{
                //    model.City = ds.Tables[0].Rows[0]["District"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["CustomerType_id"] != null && ds.Tables[0].Rows[0]["CustomerType_id"].ToString() != "")
                //{
                //    model.CustomerType_id = int.Parse(ds.Tables[0].Rows[0]["CustomerType_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["CustomerType"] != null && ds.Tables[0].Rows[0]["CustomerType"].ToString() != "")
                //{
                //    model.CustomerType = ds.Tables[0].Rows[0]["CustomerType"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["CustomerLevel_id"] != null && ds.Tables[0].Rows[0]["CustomerLevel_id"].ToString() != "")
                //{
                //    model.CustomerLevel_id = int.Parse(ds.Tables[0].Rows[0]["CustomerLevel_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["CustomerLevel"] != null && ds.Tables[0].Rows[0]["CustomerLevel"].ToString() != "")
                //{
                //    model.CustomerLevel = ds.Tables[0].Rows[0]["CustomerLevel"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["CustomerSource_id"] != null && ds.Tables[0].Rows[0]["CustomerSource_id"].ToString() != "")
                //{
                //    model.CustomerSource_id = int.Parse(ds.Tables[0].Rows[0]["CustomerSource_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["CustomerSource"] != null && ds.Tables[0].Rows[0]["CustomerSource"].ToString() != "")
                //{
                //    model.CustomerSource = ds.Tables[0].Rows[0]["CustomerSource"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["DesCripe"] != null && ds.Tables[0].Rows[0]["DesCripe"].ToString() != "")
                //{
                //    model.DesCripe = ds.Tables[0].Rows[0]["DesCripe"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["Remarks"] != null && ds.Tables[0].Rows[0]["Remarks"].ToString() != "")
                //{
                //    model.Remarks = ds.Tables[0].Rows[0]["Remarks"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["Department_id"] != null && ds.Tables[0].Rows[0]["Department_id"].ToString() != "")
                //{
                //    model.Department_id = int.Parse(ds.Tables[0].Rows[0]["Department_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["Department"] != null && ds.Tables[0].Rows[0]["Department"].ToString() != "")
                //{
                //    model.Department = ds.Tables[0].Rows[0]["Department"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["Employee_id"] != null && ds.Tables[0].Rows[0]["Employee_id"].ToString() != "")
                //{
                //    model.Employee_id = int.Parse(ds.Tables[0].Rows[0]["Employee_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["Employee"] != null && ds.Tables[0].Rows[0]["Employee"].ToString() != "")
                //{
                //    model.Employee = ds.Tables[0].Rows[0]["Employee"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["privatecustomer"] != null && ds.Tables[0].Rows[0]["privatecustomer"].ToString() != "")
                //{
                //    model.privatecustomer = ds.Tables[0].Rows[0]["privatecustomer"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["lastfollow"] != null && ds.Tables[0].Rows[0]["lastfollow"].ToString() != "")
                //{
                //    model.lastfollow = DateTime.Parse(ds.Tables[0].Rows[0]["lastfollow"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["Create_id"] != null && ds.Tables[0].Rows[0]["Create_id"].ToString() != "")
                //{
                //    model.Create_id = int.Parse(ds.Tables[0].Rows[0]["Create_id"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["Create_name"] != null && ds.Tables[0].Rows[0]["Create_name"].ToString() != "")
                //{
                //    model.Create_name = ds.Tables[0].Rows[0]["Create_name"].ToString();
                //}
                //if (ds.Tables[0].Rows[0]["Create_date"] != null && ds.Tables[0].Rows[0]["Create_date"].ToString() != "")
                //{
                //    model.Create_date = DateTime.Parse(ds.Tables[0].Rows[0]["Create_date"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["isDelete"] != null && ds.Tables[0].Rows[0]["isDelete"].ToString() != "")
                //{
                //    model.isDelete = int.Parse(ds.Tables[0].Rows[0]["isDelete"].ToString());
                //}
                //if (ds.Tables[0].Rows[0]["Delete_time"] != null && ds.Tables[0].Rows[0]["Delete_time"].ToString() != "")
                //{
                //    model.Delete_time = DateTime.Parse(ds.Tables[0].Rows[0]["Delete_time"].ToString());
                //}
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,myFactory_Id,Serialnumber,Customer,address,tel,fax,site,industry_id,industry,Nation_id,Nation,District_id,District,Provinces_id,Provinces,City_id,City,CustomerType_id,CustomerType,CustomerLevel_id,CustomerLevel,CustomerSource_id,CustomerSource,DesCripe,Remarks,Department_id,Department,Employee_id,Employee,lastfollow,Create_id,Create_name,Create_date,isDelete,Delete_time,FollowUp_id,FollowUp,CustomerValue_id,CustomerValue,PhoneIsValid_id,PhoneIsValid,BeSeats_id,BeSeats_uid,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,emp_handnum ");
            strSql.Append(" FROM CRM_Customer");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ��������б��Խӽ��
        /// </summary>
        public DataSet GetListKingDee(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select c.id FNumber,c.Customer FName,c.address FAddress,c.tel FPhone,CONCAT(c.Nation_id,',',c.Provinces_id,',',c.City_id) Kehufenlei,h.emp_code KeHuFuZeRen");
            strSql.Append(" FROM CRM_Customer c left join hr_employee h on c.BeSeats_id=h.id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ��������б��Խӽ������ת��
        /// </summary>
        public DataSet GetModelListKingDeeTrans(string strWhere, string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select c.id FNumber,c.Customer FName,c.address FAddress,c.tel FPhone,CONCAT(c.Nation_id,',',c.Provinces_id,',',c.City_id) Kehufenlei,'" + code + "' KeHuFuZeRen");
            strSql.Append(" FROM CRM_Customer c left join hr_employee h on c.BeSeats_id=h.id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetListLink(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.address,C.tel,C.fax,C.site,C.industry_id,C.industry,C.Nation_id,C.Nation,C.Provinces_id,C.Provinces,C.City_id,C.City,C.District_id,C.District,C.CustomerType_id,C.CustomerType,C.CustomerLevel_id,C.CustomerLevel,C.CustomerSource_id,C.CustomerSource,C.DesCripe,C.Remarks,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_id,C.Create_name,C.Create_date,C.isDelete,C.Delete_time,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.PhoneIsValid_id,C.PhoneIsValid,C.BeSeats_id,C.BeSeats_uid,C.BeSeats_depid,C.BeSeats_depname,C.BeSeats,C.emp_handnum,C.privatecustomer_Id,L.id as lid,L.C_name,L.C_sex,L.C_department,L.C_position,L.C_birthday,L.C_tel,L.C_fax,L.C_email,L.C_mobone,C_mobtwo,L.C_QQ,L.C_hobby,L.C_remarks,L.C_customerid ");
            strSql.Append(" FROM CRM_Customer C left join CRM_Contact L on C.id=L.C_customerid");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,myFactory_Id,Serialnumber,Customer,address,tel,fax,site,industry_id,industry,Nation_id,Nation,Provinces_id,Provinces,City_id,City,District_id,District,CustomerType_id,CustomerType,CustomerLevel_id,CustomerLevel,CustomerSource_id,CustomerSource,DesCripe,Remarks,Department_id,Department,Employee_id,Employee_uid,Employee,FollowUp_id,FollowUp,CustomerValue_id,CustomerValue,PhoneIsValid_id,PhoneIsValid,BeSeats_id,BeSeats_uid,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,lastfollow,Create_id,Create_name,Create_date,isDelete,Delete_time,emp_handnum ");
            strSql.Append(" FROM CRM_Customer ");
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
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select id,Factory_Id,myFactory_Id,Serialnumber,Customer,tel,fax,site,industry,Nation,Provinces,City,District,CustomerType,CustomerLevel,CustomerSource,Department_id,Department,Employee_id,Employee,FollowUp_id,FollowUp,CustomerValue_id,CustomerValue,BeSeats_id,BeSeats,BeSeats_depid,BeSeats_depname,privatecustomer_Id,privatecustomer,lastfollow,Create_date,emp_handnum FROM CRM_Customer ");
            strSql1.Append(" select count(id) FROM CRM_Customer ");
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
        /// ��ȡ�ҵĳɽ��ͻ�
        /// </summary>
        public DataSet GetList_transaction(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@" select  distinct C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,
                                C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer,
                                C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum
                                FROM CRM_Customer C inner join (select * from crm_contact where isdelete=0 and is_existence_business=1 group by c_customerid) L on C.id=L.c_customerid ");
            strSql1.Append(" select count(C.id) FROM CRM_Customer C  inner join  (select * from crm_contact where isdelete=0 and is_existence_business=1 group by c_customerid) L on C.id=L.c_customerid ");
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
        /// ��ȡ�ҵĳɽ��ͻ�������������
        /// </summary>
        public DataSet GetListContactFollow_transaction(int PageSize, int PageIndex, string strWhere, string strWhere1, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@" select  distinct C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,
                                C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer,
                                C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum
                                FROM CRM_Customer C inner join (select * from crm_contact where isdelete=0 and is_existence_business=1 group by c_customerid) L on C.id=L.c_customerid 
                                inner join (select * from crm_follow " + strWhere1 + " group by customer_id) F on F.customer_id=C.id ");
            strSql1.Append(" select count(C.id) FROM CRM_Customer C  inner join  (select * from crm_contact where isdelete=0 and is_existence_business=1 group by c_customerid) L on C.id=L.c_customerid  inner join (select * from crm_follow " + strWhere1 + " group by customer_id) F on F.customer_id=C.id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }





        ///// <summary>
        ///// ��ҳ��ȡ�����б�select t.c_name,t.c_tel,r
        ///// </summary>
        //public DataSet GetListBill(int PageSize, int PageIndex, string strSqlOne,string strSqlTwo, string filedOrder, out string Total)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    StringBuilder strSql1 = new StringBuilder();
        //    strSql.Append(" select ca.id as c_idList,IFNULL(ca.credit_day,0) as credit_day,IFNULL(ca.credit_total,0) as credit_total,c.id,c.Factory_Id,c.Serialnumber,c.Customer,c.tel,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,c.privatecustomer_Id,c.privatecustomer,c.isDelete,a.first_receivable FROM CRM_Customer c ");
        //    strSql.Append(" inner join ( ");
        //    strSql.Append(" SELECT group_concat(id ) id,C_customerid,SUM(credit_day) as credit_day, SUM(credit_total) as credit_total   FROM crm_contact   WHERE C_customerid in (select id FROM crm_customer ) GROUP BY C_customerid ");
        //    strSql.Append(" ) as ca on c.id=ca.C_customerid ");
        //    strSql.Append(" left join  ( ");
        //    strSql.Append(" select  C_customerid, sum(period_start)   as first_receivable  FROM xmh_fms.fms_ac_period  where " + strSqlTwo + " group by C_customerid ");
        //    strSql.Append(" ) as a on a.C_customerid =c.id ");

        //    strSql1.Append(" select count(c.id) FROM CRM_Customer c ");
        //    strSql1.Append(" inner join ( ");
        //    strSql1.Append(" SELECT group_concat(id ) id,C_customerid   FROM crm_contact   WHERE C_customerid in (select id FROM crm_customer ) GROUP BY C_customerid ");
        //    strSql1.Append(" ) as ca on c.id=ca.C_customerid ");

        //    if (strSqlOne.Trim() != "")
        //    {
        //        strSql.Append(" where " + strSqlOne);
        //        strSql1.Append(" where " + strSqlOne);
        //    }
        //    strSql.Append(" limit " + (PageIndex - 1) * PageSize + "," + PageSize); //order by " + filedOrder + "
        //    Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
        //    return DbHelperMySQL.Query(strSql.ToString());
        //}

        /// <summary>
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetListBill(int PageSize, int PageIndex, string strSqlOne, string strSqlTwo, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("SELECT  distinct *  from (");
            strSql.Append(" select c.id,c.Factory_Id,c.Serialnumber,c.Customer,c.tel,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,c.privatecustomer_Id,c.privatecustomer,c.isDelete FROM CRM_Customer c ");
            strSql.Append(" inner join CRM_Contact as CT on  C.id=CT.C_customerid  ");

            if (strSqlOne.Trim() != "")
            {
                strSql.Append(" where " + strSqlOne);
            }

            strSql.Append(" ) as u ");

            //strSql.Append(" left join  ( ");
            //strSql.Append(" select  C_customerid, sum(period_start)   as first_receivable  FROM xmh_fms.fms_ac_period  where " + strSqlTwo + " group by C_customerid ");
            //strSql.Append(" ) as a on a.C_customerid =c.id ");

            //strSql1.Append(" select count(c.id) FROM CRM_Customer c");

            strSql1.Append(" SELECT  count(distinct u.id)  from (");
            strSql1.Append(" select c.id,c.Factory_Id,c.Serialnumber,c.Customer,c.tel,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,c.privatecustomer_Id,c.privatecustomer,c.isDelete FROM CRM_Customer c ");
            strSql1.Append(" inner join CRM_Contact as CT on  C.id=CT.C_customerid  ");

            if (strSqlOne.Trim() != "")
            {
                strSql1.Append(" where " + strSqlOne);
            }

            strSql1.Append(" ) as u ");

            strSql.Append("  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        ///// <summary>
        ///// ���ؿͻ�������
        ///// </summary>
        //public DataSet GetListBills(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    StringBuilder strSql1 = new StringBuilder();
        //    strSql.Append(" select c.id,c.C_name,c.C_tel,c.credit_total,c.credit_day,u.id as C_customerid,u.Customer,u.Factory_Id,u.BeSeats_id, ");
        //    strSql.Append(" u.BeSeats_uid,u.BeSeats,u.BeSeats_depid,u.privatecustomer,concat(c.C_name,',',c.C_tel,',',u.Customer) as cus_name, ");
        //    strSql.Append(" ifnull(a.available_points,0) as score, ifnull(pk.period_start,0) as period_start ");
        //    //strSql.Append(" ifnull(pa1.deliveryAmount,0) as deliveryAmount,ifnull(pa2.collectedAmount,0) as collectedAmount,");
        //    //strSql.Append(" ifnull(pa3.return_total,0) as return_total,ifnull(pa4.transferAmount,0) as transferAmount ");
        //    strSql.Append(" from  crm_contact c  ");
        //    strSql.Append(" inner join  crm_customer u on c.C_customerid=u.id ");
        //    //strSql.Append(" left join ( select sum(d.money) as deliveryAmount,d.user_id from ( ");
        //    //strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id  ");
        //    //strSql.Append("   ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(1,10)  and  d.`status` ='1'   GROUP BY d.user_id ");
        //    //strSql.Append(" ) as pa1 on c.id=pa1.user_id ");
        //    //strSql.Append(" left join ( select sum(d.money) as collectedAmount,d.user_id from (  ");
        //    //strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id ");
        //    //strSql.Append(" ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(2,20)  and  d.`status` ='1'   GROUP BY d.user_id   ");
        //    //strSql.Append(" ) as pa2 on c.id=pa2.user_id ");
        //    //strSql.Append(" left join ( select sum(d.money) as return_total,d.user_id from (   ");
        //    //strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p  left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id  ");
        //    //strSql.Append(" ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(3,30)  and  d.`status` ='1'   GROUP BY d.user_id   ");
        //    //strSql.Append(" ) as pa3 on c.id=pa3.user_id ");
        //    //strSql.Append(" left join ( select sum(d.money) as transferAmount,d.user_id from ( ");
        //    //strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p  left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id  ");
        //    //strSql.Append(" ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(4,40)  and  d.`status` ='1'   GROUP BY d.user_id ");
        //    //strSql.Append(" ) as pa4 on c.id=pa4.user_id ");         
        //    strSql.Append(" left join ( select p.C_userid,p.period_start from xmh_fms.fms_ac_period p inner join  (select max(Id) Id from xmh_fms.fms_ac_period  where C_type='0' and Is_stop='0'  group by C_userid ) as v on v.id=p.id) as pk on pk.C_userid=c.id ");         
        //    strSql.Append(" left join  xmh_shop.shop_user_account a on a.user_id=c.id ");//available_points

        //    strSql1.Append(" select count(c.id) from crm_contact c ");
        //    strSql1.Append(" inner join  crm_customer u on c.C_customerid=u.id   ");

        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //        strSql1.Append(" where " + strWhere);
        //    }
        //    strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
        //    Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
        //    return DbHelperMySQL.Query(strSql.ToString());
        //}


        /// <summary>
        /// ���ؿͻ�������
        /// </summary>
        public DataSet GetListBills(int PageSize, int PageIndex, string strWhere,string strSqlTwo, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select c.id,c.C_name,c.C_tel,c.credit_total,c.credit_day,c.is_account_lock,u.id as C_customerid,u.Customer,u.Serialnumber,u.Factory_Id,u.BeSeats_id, ");
            strSql.Append(" u.BeSeats_uid,u.BeSeats,u.BeSeats_depid,u.privatecustomer,concat(c.C_name,',',c.C_tel,',',u.Customer) as cus_name,e.emp_code,d.dept_code_kingdee, ");
            strSql.Append(" ifnull(a.available_points,0) as score, ifnull(pk.period_start,0) as period_start, ");
            strSql.Append(" ifnull(pa1.deliveryAmount,0) as deliveryAmount,ifnull(pa2.collectedAmount,0) as collectedAmount,");
            strSql.Append(" ifnull(pa3.return_total,0) as return_total,ifnull(pa4.transferAmount,0) as transferAmount, ");
            strSql.Append(" (ifnull(pk.period_start,0)+ifnull(pa1.deliveryAmount,0)-if(ifnull(pa2.collectedAmount,0)<=0,ABS(ifnull(pa2.collectedAmount,0)),concat('-',ifnull(pa2.collectedAmount,0))) -ABS(ifnull(pa3.return_total,0))+ifnull(pa4.transferAmount,0)) as receivable_account ");
            strSql.Append(" from  crm_contact c  ");
            strSql.Append(" inner join  crm_customer u on c.C_customerid=u.id ");
            strSql.Append(" left join ( select sum(d.money) as deliveryAmount,d.user_id from ( ");
            strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id  ");
            strSql.Append("   ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(1,10)  and  d.`status` ='1'  " + strSqlTwo + "  GROUP BY d.user_id ");
            strSql.Append(" ) as pa1 on c.id=pa1.user_id ");
            strSql.Append(" left join ( select sum(d.money) as collectedAmount,d.user_id from (  ");
            strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id ");
            strSql.Append(" ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(2,20,5,50)  and  d.`status` ='1'  " + strSqlTwo + "  GROUP BY d.user_id   ");
            strSql.Append(" ) as pa2 on c.id=pa2.user_id ");
            strSql.Append(" left join ( select sum(d.money) as return_total,d.user_id from (   ");
            strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p  left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id  ");
            strSql.Append(" ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(3,30)  and  d.`status` ='1'  " + strSqlTwo + "  GROUP BY d.user_id   ");
            strSql.Append(" ) as pa3 on c.id=pa3.user_id ");
            strSql.Append(" left join ( select sum(d.money) as transferAmount,d.user_id from ( ");
            strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p  left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id  ");
            strSql.Append(" ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(4,40)  and  d.`status` ='1'  " + strSqlTwo + "  GROUP BY d.user_id ");
            strSql.Append(" ) as pa4 on c.id=pa4.user_id ");
            strSql.Append(" left join ( select p.C_userid,p.period_start from xmh_fms.fms_ac_period p inner join  (select max(Id) Id from xmh_fms.fms_ac_period  where C_type='0' and Is_stop='0'  group by C_userid ) as v on v.id=p.id) as pk on pk.C_userid=c.id ");
            strSql.Append(" left join  xmh_shop.shop_user_account a on a.user_id=c.id ");//available_points
            strSql.Append(" left join  hr_employee e on e.ID=u.BeSeats_id  ");
            strSql.Append(" left join  hr_department d on d.id=e.d_id  ");


            strSql1.Append(" select count(c.id) from crm_contact c ");
            strSql1.Append(" inner join  crm_customer u on c.C_customerid=u.id   ");

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
        /// ���ؿͻ�������
        /// </summary>
        public DataSet GetListBillAll(string strWhere, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select c.id,c.C_name,c.C_tel,c.credit_total,c.credit_day,u.id as C_customerid,u.Customer,u.Factory_Id,u.BeSeats_id, ");
            strSql.Append(" u.BeSeats_uid,u.BeSeats,u.privatecustomer,concat(c.C_name,',',c.C_tel,',',u.Customer) as cus_name ");
            strSql.Append(" from  crm_contact c  ");
            strSql.Append(" inner join  crm_customer u on c.C_customerid=u.id  ");

            strSql1.Append(" select count(c.id) from crm_contact c ");
            strSql1.Append(" inner join  crm_customer u on c.C_customerid=u.id   ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// ��ȡ��������
        /// </summary>
        public DataSet GetListExcel(string strWhere)
        {
            //StringBuilder strSql = new StringBuilder();
            //strSql.Append(" select c.id,c.Factory_Id,c.Serialnumber,c.Customer,c.tel,c.BeSeats_id,c.BeSeats_uid,c.BeSeats,c.privatecustomer_Id,c.privatecustomer,a.first_receivable FROM CRM_Customer c ");
            //strSql.Append(" left join  (select  C_customerid, sum(period_start)   as first_receivable  FROM xmh_fms.fms_ac_period  where " + strWhere + " group by C_customerid ) as a ");
            //strSql.Append(" on a.C_customerid =c.id ");


            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select c.id,c.C_name,c.C_tel,c.credit_total,c.credit_day,c.is_account_lock,u.id as C_customerid,u.Customer,u.Serialnumber,u.Factory_Id,u.BeSeats_id, ");
            strSql.Append(" u.BeSeats_uid,u.BeSeats,u.BeSeats_depid,u.privatecustomer,concat(c.C_name,',',c.C_tel,',',u.Customer) as cus_name, ");
            strSql.Append(" ifnull(a.available_points,0) as score, ifnull(pk.period_start,0) as period_start, ");
            strSql.Append(" ifnull(pa1.deliveryAmount,0) as deliveryAmount,ifnull(pa2.collectedAmount,0) as collectedAmount,");
            strSql.Append(" ifnull(pa3.return_total,0) as return_total,ifnull(pa4.transferAmount,0) as transferAmount, ");
            strSql.Append(" (ifnull(pk.period_start,0)+ifnull(pa1.deliveryAmount,0)-if(ifnull(pa2.collectedAmount,0)<=0,ABS(ifnull(pa2.collectedAmount,0)),concat('-',ifnull(pa2.collectedAmount,0))) -ABS(ifnull(pa3.return_total,0))+ifnull(pa4.transferAmount,0)) as receivable_account ");
            strSql.Append(" from  crm_contact c  ");
            strSql.Append(" inner join  crm_customer u on c.C_customerid=u.id ");
            strSql.Append(" left join ( select sum(d.money) as deliveryAmount,d.user_id from ( ");
            strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id  ");
            strSql.Append("   ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(1,10)  and  d.`status` ='1'   GROUP BY d.user_id ");
            strSql.Append(" ) as pa1 on c.id=pa1.user_id ");
            strSql.Append(" left join ( select sum(d.money) as collectedAmount,d.user_id from (  ");
            strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id ");
            strSql.Append(" ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(2,20,5,50)  and  d.`status` ='1'   GROUP BY d.user_id   ");
            strSql.Append(" ) as pa2 on c.id=pa2.user_id ");
            strSql.Append(" left join ( select sum(d.money) as return_total,d.user_id from (   ");
            strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p  left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id  ");
            strSql.Append(" ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(3,30)  and  d.`status` ='1'   GROUP BY d.user_id   ");
            strSql.Append(" ) as pa3 on c.id=pa3.user_id ");
            strSql.Append(" left join ( select sum(d.money) as transferAmount,d.user_id from ( ");
            strSql.Append(" select p.id,p.money,p.user_id,p.type,p.add_time,ifnull(ap.date,'1970-01-01') date,p.`status` from xmh_shop.shop_progress_payments p  left join ( select max(period_start_date) date,c_userid from xmh_fms.fms_ac_period group by c_userid ) ap on ap.c_userid=p.user_id  ");
            strSql.Append(" ) d  where d.add_time>= UNIX_TIMESTAMP(d.date)  and d.type in(4,40)  and  d.`status` ='1'   GROUP BY d.user_id ");
            strSql.Append(" ) as pa4 on c.id=pa4.user_id ");
            strSql.Append(" left join ( select p.C_userid,p.period_start from xmh_fms.fms_ac_period p inner join  (select max(Id) Id from xmh_fms.fms_ac_period  where C_type='0' and Is_stop='0'  group by C_userid ) as v on v.id=p.id) as pk on pk.C_userid=c.id ");
            strSql.Append(" left join  xmh_shop.shop_user_account a on a.user_id=c.id ");//available_points

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            return DbHelperMySQL.Query(strSql.ToString());
        }



        /// <summary>
        /// ��ҳ��ȡ��ʹ�õĴ�ͻ�
        /// </summary>
        public DataSet GetListFactory(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.privatecustomer,C.lastfollow,C.Create_date,C.emp_handnum,s.IsDelete FROM CRM_Customer C inner join sys_factoryinfo s on C.myFactory_Id = s.Factory_Id ");
            strSql1.Append(" select count(C.id) FROM CRM_Customer C inner join sys_factoryinfo s on C.myFactory_Id = s.Factory_Id ");
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
        /// ��������б�
        /// </summary>
        public DataSet GetListEmp(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,
                             C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,
                             C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.privatecustomer,C.lastfollow,C.Create_date,C.emp_handnum,h.emp_code FROM CRM_Customer C left join hr_employee as h on C.BeSeats_id=h.id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ��ȡ�ͻ�����ID
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet getCustomerIdAll(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"select id,customer FROM CRM_Customer");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// ��ҳ��ȡ�����б�
        /// </summary>
        public DataSet GetListEmp(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(@" C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,
                             C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.emp_handnum,
                             C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.privatecustomer,C.lastfollow,C.Create_date FROM CRM_Customer C left join hr_employee as h on c.BeSeats_id=h.id ");
            strSql1.Append(" select count(C.id) FROM CRM_Customer C left join hr_employee as h on c.BeSeats_id=h.id ");
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
        ///��ϵ�˻�������б�
        /// </summary>
        public DataSet GetListContact(int PageSize, int PageIndex, string strWhere, string key, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@"select distinct C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,
                            C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,
                            C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.emp_handnum FROM CRM_Customer C left join CRM_Contact L on  C.id =L.C_customerid ");
            strSql1.Append(" select count(C.id) FROM CRM_Customer C  left join CRM_Contact L on  C.id =L.C_customerid ");
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
        ///��ϵ�˻�������б�
        /// </summary>
        public DataSet GetListContact1(int PageSize, int PageIndex, string strWhere, string key, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@"select distinct C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,
                            C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,
                            C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.emp_handnum FROM CRM_Customer C left join CRM_Contact L on  C.id =L.C_customerid ");
            strSql1.Append(" select count(C.id) FROM CRM_Customer C  left join CRM_Contact L on  C.id =L.C_customerid ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            if (key.Trim() != "")
            {
                strSql.Append(" and  " + key );
                strSql1.Append(" and  " + key);
            }
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        ///��ϵ�˻������
        /// </summary>
        public DataSet GetAllContact(string strWhere, string key)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.emp_handnum FROM CRM_Customer C left join CRM_Contact L on  C.id =L.C_customerid ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql.Append(" and  L.C_name like '%" + key + "%'");
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// �������ݻ�������б�
        /// </summary>
        public DataSet GetListContactFollow(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@" select distinct C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,
                                C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer,
                                C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum
                                FROM CRM_Customer C  inner join CRM_Follow F on  C.id =F.Customer_id ");
            strSql1.Append(" select count(distinct C.id) FROM CRM_Customer C inner join CRM_Follow F on  C.id =F.Customer_id ");
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
        /// /�������ݻ�������б�(��Ч�Ĵ�ͻ�)
        /// </summary>
        public DataSet GetListContactFollowEnd(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@" select distinct C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,
                                C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer,
                                C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum,s.IsDelete
                                FROM CRM_Customer C  inner join CRM_Follow F on  C.id =F.Customer_id inner join sys_factoryinfo s on C.myFactory_Id = s.Factory_Id");
            strSql1.Append(" select count(distinct C.id) FROM CRM_Customer C inner join CRM_Follow F on  C.id =F.Customer_id inner join sys_factoryinfo s on C.myFactory_Id = s.Factory_Id");
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
        /// �����ۺϲ�ѯ��ȡ�ͻ���Ϣ
        /// </summary>
        public DataSet GetListSynthesis(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("SELECT  distinct *  from (");
            strSql.Append(@"    select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,
                                C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,
                                C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.privatecustomer,C.lastfollow,C.Create_date,C.emp_handnum 
                                FROM CRM_Customer as C inner join CRM_Contact as CT on  C.id=CT.C_customerid  ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }
            strSql.Append("  Union all");
            strSql.Append(@"    select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,
                                C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,
                                C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.privatecustomer,C.lastfollow,C.Create_date,C.emp_handnum
                                FROM CRM_Customer as C inner join CRM_Follow as F on C.id=F.customer_id   ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }
            strSql.Append(") as unioninfo");
            //strSql.Append(" WHERE F.Follow like '%" + key + "%' and C.id not in ( SELECT top " + (PageIndex - 1) * PageSize + " C.id FROM CRM_Customer C ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(@"  select  count(distinct id)  from 
                                (select  c.id
                                FROM CRM_Customer as C
                                inner join CRM_Contact as CT on  C.id=CT.C_customerid  ");
            if (strWhere1.Trim() != "")
            {
                strSql1.Append(" where " + strWhere1);
            }
            strSql1.Append("  Union all");
            strSql1.Append(@"  select  c.id
                               FROM CRM_Customer as C
                               inner join CRM_Follow as F on C.id=F.customer_id  ");
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
        /// �����ۺϲ�ѯ��ȡ�ͻ���Ϣ
        /// </summary>
        public DataSet GetListSynthesis(string strWhere1, string strWhere2)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("SELECT  distinct *  from (");
            strSql.Append(@"    select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,
                                C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,
                                C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.privatecustomer,C.lastfollow,C.Create_date,C.emp_handnum 
                                FROM CRM_Customer as C inner join CRM_Contact as CT on  C.id=CT.C_customerid  ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }
            strSql.Append("  Union all");
            strSql.Append(@"    select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,
                                C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,
                                C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.privatecustomer,C.lastfollow,C.Create_date,C.emp_handnum 
                                FROM CRM_Customer as C inner join CRM_Follow as F on C.id=F.customer_id   ");
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
        /// /�������ݻ�������б�
        /// </summary>
        public DataSet GetListContactFollowEmp(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@" select distinct C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.emp_handnum,
                                C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,
                                C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id 
                                FROM CRM_Customer C  inner join CRM_Follow F on  C.id =F.Customer_id left join hr_employee as h on c.BeSeats_id=h.id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// �������ݻ�������б�
        /// </summary>
        public DataSet GetListContactFollowEmp(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(@" select distinct C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.emp_handnum,
                                C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,
                                C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id 
                                FROM CRM_Customer C  inner join CRM_Follow F on  C.id =F.Customer_id left join hr_employee as h on c.BeSeats_id=h.id");
            strSql1.Append(" select count(distinct C.id) FROM CRM_Customer C inner join CRM_Follow F on  C.id =F.Customer_id left join hr_employee as h on c.BeSeats_id=h.id");
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
        /// ��˾�绰��ϵ�绰��������б�
        /// </summary>
        //public DataSet GetListByTel(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    StringBuilder strSql1 = new StringBuilder();
        //    strSql.Append(" select distinct C.id,C.Factory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id  FROM crm_customer c left join crm_contact a on c.id = a.C_customerid ");
        //    //strSql.Append(" WHERE F.Follow like '%" + key + "%' and C.id not in ( SELECT top " + (PageIndex - 1) * PageSize + " C.id FROM CRM_Customer C ");
        //    //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
        //    strSql1.Append(" select count(C.id) FROM crm_customer c left join crm_contact a on c.id = a.C_customerid ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //        strSql1.Append(" where " + strWhere);
        //    }
        //    strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
        //    Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
        //    return DbHelperMySQL.Query(strSql.ToString());
        //}

        public DataSet GetListByTel(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
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
            strSql.Append(" select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum  FROM crm_customer c ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }
            strSql.Append(") as unioninfo");

            //strSql.Append(" WHERE F.Follow like '%" + key + "%' and C.id not in ( SELECT top " + (PageIndex - 1) * PageSize + " C.id FROM CRM_Customer C ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append("select  count(distinct id)  from(");
            strSql1.Append(" select C.id FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid ");
            if (strWhere1.Trim() != "")
            {
                strSql1.Append(" where " + strWhere1);
            }
            strSql1.Append("  Union all");
            strSql1.Append(" select C.id FROM crm_customer c ");
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
        /// ��˾�绰��ϵ�绰�������
        /// </summary>
        //public DataSet GetAllListByTel(string strWhere)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" select distinct C.id,C.Factory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.emp_handnum  FROM crm_customer C inner join crm_contact a on c.id = a.C_customerid ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //    }
        //    return DbHelperMySQL.Query(strSql.ToString());
        //}

        public DataSet GetAllListByTel(string strWhere1, string strWhere2)
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
            strSql.Append(" select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum  FROM crm_customer c ");
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
        ///�������ݻ������
        /// </summary>
        public DataSet GetAllContactFollow(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.BeSeats_depid,C.BeSeats_depname,C.privatecustomer_Id,C.emp_handnum FROM CRM_Customer C  left join CRM_Follow F on  C.id =F.Customer_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// ����������
        /// </summary>
        public bool UpdateLastFollow(string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Customer set lastfollow='" + DateTime.Now + "'");
            //strSql.Append("[lastfollow] = isnull((select max(Follow_date) as Followdate from dbo.CRM_Follow where CRM_Customer.id=CRM_Follow.Customer_id),Create_date)");
            strSql.Append(" where CRM_Customer.id=" + id);

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

        public DataSet Reports_year(string items, int year, string where)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("if OBJECT_ID('Tempdb..#t') is not null ");
            //strSql.Append("    drop TABLE  #t ");
            ////strSql.Append("go");
            //strSql.Append(" begin ");
            ////strSql.Append("    --Ԥͳ�Ʊ� #t");
            //strSql.Append("    select ");
            //strSql.Append("        " + items + ",'m'+convert(varchar,month(Create_date)) mm,count(id)tNum into #t ");
            //strSql.Append("    from dbo.CRM_Customer ");
            //strSql.Append("    where timestampdiff(YEAR,[Create_date],'" + year + "-1-1')=0 and isDelete=0 ");
            //if (where.Trim() != "")
            //{
            //    strSql.Append(" and " + where);
            //}
            //strSql.Append("    group by " + items + ",'m'+convert(varchar,month(Create_date)) ");

            ////strSql.Append("    --����SQL");
            //strSql.Append("    declare @sql varchar(8000) ");
            //strSql.Append("    set @sql='select " + items + " items ' ");
            //strSql.Append("    select @sql = @sql + ',sum(case mm when ' + char(39) +mm+ char(39) + ' then tNum else 0 end) ['+ mm +']' ");
            //strSql.Append("        from (select distinct mm from #t)as data ");
            //strSql.Append("    set @sql = @sql + ' from #t group by " + items + "' ");

            //strSql.Append("    exec(@sql) ");
            //strSql.Append(" end ");
            ////strSql.Append("go");
            strSql.Append("   select " + items + " as items ,");
            strSql.Append(" 	MAX(CASE mm WHEN '1' THEN tNum ELSE 0 END ) 'm1',       ");
            strSql.Append("     MAX(CASE mm WHEN '2' THEN tNum ELSE 0 END ) 'm2',       ");
            strSql.Append("     MAX(CASE mm WHEN '3' THEN tNum ELSE 0 END ) 'm3',       ");
            strSql.Append("     MAX(CASE mm WHEN '4' THEN tNum ELSE 0 END ) 'm4',       ");
            strSql.Append("     MAX(CASE mm WHEN '5' THEN tNum ELSE 0 END ) 'm5',       ");
            strSql.Append("     MAX(CASE mm WHEN '6' THEN tNum ELSE 0 END ) 'm6',       ");
            strSql.Append("     MAX(CASE mm WHEN '7' THEN tNum ELSE 0 END ) 'm7',       ");
            strSql.Append("     MAX(CASE mm WHEN '8' THEN tNum ELSE 0 END ) 'm8',       ");
            strSql.Append("     MAX(CASE mm WHEN '9' THEN tNum ELSE 0 END ) 'm9',       ");
            strSql.Append("     MAX(CASE mm WHEN '10' THEN tNum ELSE 0 END ) 'm10',     ");
            strSql.Append("     MAX(CASE mm WHEN '11' THEN tNum ELSE 0 END ) 'm11',     ");
            strSql.Append("     MAX(CASE mm WHEN '12' THEN tNum ELSE 0 END ) 'm12'      ");
            strSql.Append(" from");
            strSql.Append("    (select ");
            strSql.Append(" (case (ISNULL(" + items + ") || LENGTH(trim(" + items + "))<1) when 1  then 'δ����' else " + items + "  end)  as  " + items + ",  ");
            strSql.Append("    month(Create_date) mm,count(id)tNum ");
            strSql.Append("    from CRM_Customer ");
            strSql.Append("    where YEAR(Create_date)='" + year + "' and isDelete=0");
            if (where.Trim() != "")
            {
                strSql.Append(" and " + where);
            }
            strSql.Append("    group by (case (ISNULL(" + items + ") || LENGTH(trim(" + items + "))<1) when 1  then 'δ����' else " + items + "  end),month(Create_date)) tt ");
            strSql.Append(" group by " + items + "  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet Reports_month(string items, int year, int month, string where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("   select " + items + " as items ,");
            strSql.Append(" 	MAX(CASE dd WHEN '1' THEN tNum ELSE 0 END ) 'd1',       ");
            strSql.Append("     MAX(CASE dd WHEN '2' THEN tNum ELSE 0 END ) 'd2',       ");
            strSql.Append("     MAX(CASE dd WHEN '3' THEN tNum ELSE 0 END ) 'd3',       ");
            strSql.Append("     MAX(CASE dd WHEN '4' THEN tNum ELSE 0 END ) 'd4',       ");
            strSql.Append("     MAX(CASE dd WHEN '5' THEN tNum ELSE 0 END ) 'd5',       ");
            strSql.Append("     MAX(CASE dd WHEN '6' THEN tNum ELSE 0 END ) 'd6',       ");
            strSql.Append("     MAX(CASE dd WHEN '7' THEN tNum ELSE 0 END ) 'd7',       ");
            strSql.Append("     MAX(CASE dd WHEN '8' THEN tNum ELSE 0 END ) 'd8',       ");
            strSql.Append("     MAX(CASE dd WHEN '9' THEN tNum ELSE 0 END ) 'd9',       ");
            strSql.Append("     MAX(CASE dd WHEN '10' THEN tNum ELSE 0 END ) 'd10',     ");
            strSql.Append("     MAX(CASE dd WHEN '11' THEN tNum ELSE 0 END ) 'd11',     ");
            strSql.Append("     MAX(CASE dd WHEN '12' THEN tNum ELSE 0 END ) 'd12',      ");
            strSql.Append("     MAX(CASE dd WHEN '13' THEN tNum ELSE 0 END ) 'd13',      ");
            strSql.Append("     MAX(CASE dd WHEN '14' THEN tNum ELSE 0 END ) 'd14',      ");
            strSql.Append("     MAX(CASE dd WHEN '15' THEN tNum ELSE 0 END ) 'd15',      ");
            strSql.Append("     MAX(CASE dd WHEN '16' THEN tNum ELSE 0 END ) 'd16',      ");
            strSql.Append("     MAX(CASE dd WHEN '17' THEN tNum ELSE 0 END ) 'd17',      ");
            strSql.Append("     MAX(CASE dd WHEN '18' THEN tNum ELSE 0 END ) 'd18',      ");
            strSql.Append("     MAX(CASE dd WHEN '19' THEN tNum ELSE 0 END ) 'd19',      ");
            strSql.Append("     MAX(CASE dd WHEN '20' THEN tNum ELSE 0 END ) 'd20',      ");
            strSql.Append("     MAX(CASE dd WHEN '21' THEN tNum ELSE 0 END ) 'd21',      ");
            strSql.Append("     MAX(CASE dd WHEN '22' THEN tNum ELSE 0 END ) 'd22',      ");
            strSql.Append("     MAX(CASE dd WHEN '23' THEN tNum ELSE 0 END ) 'd23',      ");
            strSql.Append("     MAX(CASE dd WHEN '24' THEN tNum ELSE 0 END ) 'd24',      ");
            strSql.Append("     MAX(CASE dd WHEN '25' THEN tNum ELSE 0 END ) 'd25',      ");
            strSql.Append("     MAX(CASE dd WHEN '26' THEN tNum ELSE 0 END ) 'd26',      ");
            strSql.Append("     MAX(CASE dd WHEN '27' THEN tNum ELSE 0 END ) 'd27',      ");
            strSql.Append("     MAX(CASE dd WHEN '28' THEN tNum ELSE 0 END ) 'd28',      ");
            strSql.Append("     MAX(CASE dd WHEN '29' THEN tNum ELSE 0 END ) 'd29',      ");
            strSql.Append("     MAX(CASE dd WHEN '30' THEN tNum ELSE 0 END ) 'd30',      ");
            strSql.Append("     MAX(CASE dd WHEN '31' THEN tNum ELSE 0 END ) 'd31'      ");
            strSql.Append(" from");
            strSql.Append("    (select ");
            strSql.Append(" (case (ISNULL(" + items + ") || LENGTH(trim(" + items + "))<1) when 1  then 'δ����' else " + items + "  end)  as  " + items + ",  ");
            strSql.Append("    DAYOFMONTH(Create_date) dd,count(id)tNum ");
            strSql.Append("    from CRM_Customer ");
            strSql.Append("    where year(Create_date)='" + year + "' and month(Create_date)='" + month + "' and isDelete=0 ");
            if (where.Trim() != "")
            {
                strSql.Append(" and " + where);
            }
            strSql.Append("    group by (case (ISNULL(" + items + ") || LENGTH(trim(" + items + "))<1) when 1  then 'δ����' else " + items + "  end),DAYOFMONTH(Create_date)) tt ");
            //strSql.Append("    group by " + items + ",DAYOFMONTH(Create_date)) ss ");
            strSql.Append(" group by " + items + "  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// ͬ�Ȼ��ȡ��ͻ�������
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public DataSet Compared(string year1, string month1, string year2, string month2, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select count(id) as yy,");
            strSql.Append(" SUM(case when YEAR( Create_date)=('" + year1 + "') and MONTH(Create_date)=('" + month1 + "') then 1 else 0 end) as dt1, ");
            strSql.Append(" SUM(case when YEAR( Create_date)=('" + year2 + "') and MONTH(Create_date)=('" + month2 + "') then 1 else 0 end) as dt2 ");
            strSql.Append(" FROM CRM_Customer WHERE isDelete=0 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// �ͻ����͡�ͬ�Ȼ��ȡ�
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public DataSet Compared_type(string year1, string month1, string year2, string month2, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select (case (ISNULL(CustomerType) || LENGTH(trim(CustomerType))<1) when 1  then 'δ����' else CustomerType end) as yy,");
            strSql.Append(" count(CustomerType) as xx,");
            strSql.Append(" SUM(case when YEAR( Create_date)=('" + year1 + "') and MONTH(Create_date)=('" + month1 + "') then 1 else 0 end) as dt1, ");
            strSql.Append(" SUM(case when YEAR( Create_date)=('" + year2 + "') and MONTH(Create_date)=('" + month2 + "') then 1 else 0 end) as dt2 ");
            strSql.Append(" FROM CRM_Customer  WHERE isDelete=0 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append(" group by (case (ISNULL(CustomerType) || LENGTH(trim(CustomerType))<1) when 1  then 'δ����' else CustomerType end)");

            return DbHelperMySQL.Query(strSql.ToString());

        }

        /// <summary>
        /// �ͻ�����ͬ�Ȼ��ȡ�
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public DataSet Compared_level(string year1, string month1, string year2, string month2, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select (case (ISNULL(CustomerLevel) || LENGTH(trim(CustomerLevel))<1) when 1  then 'δ����' else CustomerLevel end) as yy,");
            strSql.Append(" count(CustomerLevel) as xx,");
            strSql.Append(" SUM(case when YEAR( Create_date)=('" + year1 + "') and MONTH(Create_date)=('" + month1 + "') then 1 else 0 end) as dt1, ");
            strSql.Append(" SUM(case when YEAR( Create_date)=('" + year2 + "') and MONTH(Create_date)=('" + month2 + "') then 1 else 0 end) as dt2 ");
            strSql.Append(" FROM CRM_Customer  WHERE isDelete=0 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append(" group by (case (ISNULL(CustomerLevel) || LENGTH(trim(CustomerLevel))<1) when 1  then 'δ����' else CustomerLevel end)");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// �ͻ���Դ��ͬ�Ȼ��ȡ�
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public DataSet Compared_source(string year1, string month1, string year2, string month2, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select (case (ISNULL(CustomerSource) || LENGTH(trim(CustomerSource))<1) when 1  then 'δ����' else CustomerSource end) as yy,");
            strSql.Append(" count(CustomerSource) as xx,");
            strSql.Append(" SUM(case when YEAR( Create_date)=('" + year1 + "') and MONTH(Create_date)=('" + month1 + "') then 1 else 0 end) as dt1, ");
            strSql.Append(" SUM(case when YEAR( Create_date)=('" + year2 + "') and MONTH(Create_date)=('" + month2 + "') then 1 else 0 end) as dt2 ");
            strSql.Append(" FROM CRM_Customer WHERE isDelete=0 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append("group by (case (ISNULL(CustomerSource) || LENGTH(trim(CustomerSource))<1) when 1  then 'δ����' else CustomerSource end)");


            return DbHelperMySQL.Query(strSql.ToString());
        }

        public DataSet Compared_empcusadd(string year1, string month1, string year2, string month2, string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select hr_employee.name as yy,");
            strSql.Append(" SUM(case when YEAR( CRM_Customer.Create_date)=('" + year1 + "') and MONTH(CRM_Customer.create_date)=('" + month1 + "') then 1 else 0 end) as dt1, ");
            strSql.Append(" SUM(case when YEAR( CRM_Customer.Create_date)=('" + year2 + "') and MONTH(CRM_Customer.create_date)=('" + month2 + "') then 1 else 0 end) as dt2 ");
            strSql.Append(" FROM hr_employee left outer join  CRM_Customer ");
            strSql.Append(" on hr_employee.ID=CRM_Customer.Create_id ");
            strSql.Append(" where  CRM_Customer.isDelete=0 and hr_employee.ID in " + idlist);
            strSql.Append(" group by hr_employee.name,hr_employee.ID ");
            strSql.Append(" order by hr_employee.ID ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// �ͻ�����ͳ��
        /// </summary>
        public DataSet report_empcus(int year, string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select id,name,yy,");
            strSql.Append(" MAX(CASE mm WHEN '1' THEN cn ELSE 0 END ) 'm1',      ");
            strSql.Append(" MAX(CASE mm WHEN '2' THEN cn ELSE 0 END ) 'm2',      ");
            strSql.Append(" MAX(CASE mm WHEN '3' THEN cn ELSE 0 END ) 'm3',      ");
            strSql.Append(" MAX(CASE mm WHEN '4' THEN cn ELSE 0 END ) 'm4',      ");
            strSql.Append(" MAX(CASE mm WHEN '5' THEN cn ELSE 0 END ) 'm5',      ");
            strSql.Append(" MAX(CASE mm WHEN '6' THEN cn ELSE 0 END ) 'm6',      ");
            strSql.Append(" MAX(CASE mm WHEN '7' THEN cn ELSE 0 END ) 'm7',      ");
            strSql.Append(" MAX(CASE mm WHEN '8' THEN cn ELSE 0 END ) 'm8',      ");
            strSql.Append(" MAX(CASE mm WHEN '9' THEN cn ELSE 0 END ) 'm9',      ");
            strSql.Append(" MAX(CASE mm WHEN '10' THEN cn ELSE 0 END ) 'm10',    ");
            strSql.Append(" MAX(CASE mm WHEN '11' THEN cn ELSE 0 END ) 'm11',    ");
            strSql.Append(" MAX(CASE mm WHEN '12' THEN cn ELSE 0 END ) 'm12'     ");
            strSql.Append(" from");
            strSql.Append(" (SELECT   hr_employee.ID, hr_employee.name, COUNT(derivedtbl_1.id) AS cn, YEAR(derivedtbl_1.Create_date) AS yy, ");
            strSql.Append(" MONTH(derivedtbl_1.Create_date) AS mm");
            strSql.Append(" FROM      hr_employee LEFT OUTER JOIN");
            strSql.Append("  (SELECT   id, Create_id, Create_date");
            strSql.Append("  FROM      CRM_Customer");
            strSql.Append("  WHERE isdelete=0 and  (YEAR(Create_date) = " + year + ")) AS derivedtbl_1 ON hr_employee.ID = derivedtbl_1.Create_id");
            strSql.Append(" WHERE hr_employee.ID in " + idlist);
            strSql.Append(" GROUP BY hr_employee.ID, hr_employee.name, YEAR(derivedtbl_1.Create_date), MONTH(derivedtbl_1.Create_date),YEAR(derivedtbl_1.Create_date)) as tt");
            strSql.Append(" group by id,name,yy ");

            return DbHelperMySQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �ͻ�����ͳ����
        /// </summary>
        public DataSet report_empcus(int year, int months, string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select id,name,yy,mm,");
            strSql.Append(" 	MAX(CASE dd WHEN '1' THEN tNum ELSE 0 END ) 'd1',       ");
            strSql.Append("     MAX(CASE dd WHEN '2' THEN tNum ELSE 0 END ) 'd2',       ");
            strSql.Append("     MAX(CASE dd WHEN '3' THEN tNum ELSE 0 END ) 'd3',       ");
            strSql.Append("     MAX(CASE dd WHEN '4' THEN tNum ELSE 0 END ) 'd4',       ");
            strSql.Append("     MAX(CASE dd WHEN '5' THEN tNum ELSE 0 END ) 'd5',       ");
            strSql.Append("     MAX(CASE dd WHEN '6' THEN tNum ELSE 0 END ) 'd6',       ");
            strSql.Append("     MAX(CASE dd WHEN '7' THEN tNum ELSE 0 END ) 'd7',       ");
            strSql.Append("     MAX(CASE dd WHEN '8' THEN tNum ELSE 0 END ) 'd8',       ");
            strSql.Append("     MAX(CASE dd WHEN '9' THEN tNum ELSE 0 END ) 'd9',       ");
            strSql.Append("     MAX(CASE dd WHEN '10' THEN tNum ELSE 0 END ) 'd10',     ");
            strSql.Append("     MAX(CASE dd WHEN '11' THEN tNum ELSE 0 END ) 'd11',     ");
            strSql.Append("     MAX(CASE dd WHEN '12' THEN tNum ELSE 0 END ) 'd12',      ");
            strSql.Append("     MAX(CASE dd WHEN '13' THEN tNum ELSE 0 END ) 'd13',      ");
            strSql.Append("     MAX(CASE dd WHEN '14' THEN tNum ELSE 0 END ) 'd14',      ");
            strSql.Append("     MAX(CASE dd WHEN '15' THEN tNum ELSE 0 END ) 'd15',      ");
            strSql.Append("     MAX(CASE dd WHEN '16' THEN tNum ELSE 0 END ) 'd16',      ");
            strSql.Append("     MAX(CASE dd WHEN '17' THEN tNum ELSE 0 END ) 'd17',      ");
            strSql.Append("     MAX(CASE dd WHEN '18' THEN tNum ELSE 0 END ) 'd18',      ");
            strSql.Append("     MAX(CASE dd WHEN '19' THEN tNum ELSE 0 END ) 'd19',      ");
            strSql.Append("     MAX(CASE dd WHEN '20' THEN tNum ELSE 0 END ) 'd20',      ");
            strSql.Append("     MAX(CASE dd WHEN '21' THEN tNum ELSE 0 END ) 'd21',      ");
            strSql.Append("     MAX(CASE dd WHEN '22' THEN tNum ELSE 0 END ) 'd22',      ");
            strSql.Append("     MAX(CASE dd WHEN '23' THEN tNum ELSE 0 END ) 'd23',      ");
            strSql.Append("     MAX(CASE dd WHEN '24' THEN tNum ELSE 0 END ) 'd24',      ");
            strSql.Append("     MAX(CASE dd WHEN '25' THEN tNum ELSE 0 END ) 'd25',      ");
            strSql.Append("     MAX(CASE dd WHEN '26' THEN tNum ELSE 0 END ) 'd26',      ");
            strSql.Append("     MAX(CASE dd WHEN '27' THEN tNum ELSE 0 END ) 'd27',      ");
            strSql.Append("     MAX(CASE dd WHEN '28' THEN tNum ELSE 0 END ) 'd28',      ");
            strSql.Append("     MAX(CASE dd WHEN '29' THEN tNum ELSE 0 END ) 'd29',      ");
            strSql.Append("     MAX(CASE dd WHEN '30' THEN tNum ELSE 0 END ) 'd30',      ");
            strSql.Append("     MAX(CASE dd WHEN '31' THEN tNum ELSE 0 END ) 'd31'      ");

            strSql.Append(" from");
            strSql.Append(" (SELECT   hr_employee.ID, hr_employee.name, COUNT(derivedtbl_1.id) AS tNum,YEAR(derivedtbl_1.Create_date) AS yy,MONTH(derivedtbl_1.Create_date) AS mm, ");
            strSql.Append(" DAYOFMONTH(derivedtbl_1.Create_date) AS dd");
            strSql.Append(" FROM      hr_employee LEFT OUTER JOIN");
            strSql.Append("  (SELECT   id, Create_id, Create_date");
            strSql.Append("  FROM      CRM_Customer");
            strSql.Append("  WHERE isdelete=0 and  (YEAR(Create_date) = '" + year + "' and month(Create_date)='" + months + "' " + ")) AS derivedtbl_1 ON hr_employee.ID = derivedtbl_1.Create_id");
            strSql.Append(" WHERE hr_employee.ID in " + idlist);
            strSql.Append(" GROUP BY hr_employee.ID, hr_employee.name, DAYOFMONTH(derivedtbl_1.Create_date),YEAR(derivedtbl_1.Create_date),MONTH(derivedtbl_1.Create_date)) as tt");
            strSql.Append(" group by id,name,yy,mm ");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ������ǰҳ
        /// </summary>
        /// <param name="PageSize"></param>
        /// <param name="PageIndex"></param>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <param name="Total"></param>
        /// <returns></returns>
        public DataSet ToExcelOnePage(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" Factory_Id  'FactoryNumber',");
            strSql.Append(" Customer as 'Customer',");
            strSql.Append(" address as 'Address',");
            strSql.Append(" tel as 'Tel',");
            strSql.Append(" fax as 'Fax',");
            strSql.Append(" site as 'Site',");
            strSql.Append(" industry as 'Industry',");
            strSql.Append(" Nation as 'Nation',");
            strSql.Append(" Provinces as 'Provinces',");
            strSql.Append(" City as 'City',");
            strSql.Append(" District as 'District',");
            strSql.Append(" CustomerType as 'CustomerType',");
            strSql.Append(" CustomerLevel as 'CustomerLevel',");
            strSql.Append(" CustomerSource as 'CustomerSource',");
            strSql.Append(" FollowUp as 'FollowUp',");
            strSql.Append(" CustomerValue as 'CustomerValue',");
            strSql.Append(" BeSeats as 'BeSeats',");
            strSql.Append(" DesCripe as 'DesCripe',");
            strSql.Append(" Remarks as 'Remarks',");
            strSql.Append(" Department as 'Department',");
            strSql.Append(" BeSeats_depname as 'BeSeats_depname',");
            strSql.Append(" Employee as 'Employee',");
            strSql.Append(" privatecustomer as 'CustomerStatus'");
            strSql.Append(" FROM CRM_Customer ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM CRM_Customer ");
            //strSql.Append(" where " + strWhere + ") ");
            strSql1.Append(" select count(id) FROM CRM_Customer ");
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
        /// ToExcel
        /// </summary>
        public DataSet ToExcel(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" Factory_Id  as 'FactoryNumber',");
            strSql.Append(" Customer as 'Customer',");
            strSql.Append(" address as 'Address',");
            strSql.Append(" tel as 'Tel',");
            strSql.Append(" fax as 'Fax',");
            strSql.Append(" site as 'Site',");
            strSql.Append(" industry as 'Industry',");
            strSql.Append(" Nation as 'Nation',");
            strSql.Append(" Provinces as 'Provinces',");
            strSql.Append(" City as 'City',");
            strSql.Append(" District as 'District',");
            strSql.Append(" CustomerType as 'CustomerType',");
            strSql.Append(" CustomerLevel as 'CustomerLevel',");
            strSql.Append(" CustomerSource as 'CustomerSource',");
            strSql.Append(" FollowUp as 'FollowUp',");
            strSql.Append(" CustomerValue as 'CustomerValue',");
            strSql.Append(" BeSeats as 'BeSeats',");
            strSql.Append(" DesCripe as 'DesCripe',");
            strSql.Append(" Remarks as 'Remarks',");
            strSql.Append(" Department as 'Department',");
            strSql.Append(" BeSeats_depname as 'BeSeats_depname',");
            strSql.Append(" Employee as 'Employee',");
            strSql.Append(" privatecustomer as 'CustomerStatus'");
            strSql.Append(" FROM CRM_Customer ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            //string str = Encoding.Unicode.GetString(Encoding.Unicode.GetBytes(strSql.ToString()));
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ����
        /// </summary>
        public bool ToImport(int emp_id, string create_name, DateTime create_date)
        {
            StringBuilder strSql0 = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            StringBuilder strSql3 = new StringBuilder();
            StringBuilder strSql4 = new StringBuilder();
            StringBuilder strSql5 = new StringBuilder();
            StringBuilder strSql6 = new StringBuilder();
            StringBuilder strSql7 = new StringBuilder();
            StringBuilder strSql8 = new StringBuilder();
            StringBuilder strSql9 = new StringBuilder();
            StringBuilder strSql10 = new StringBuilder();
            StringBuilder strSql11 = new StringBuilder();
            StringBuilder strSql12 = new StringBuilder();
            StringBuilder strSql13 = new StringBuilder();
            StringBuilder strSql14 = new StringBuilder();
            StringBuilder strSql15 = new StringBuilder();
            StringBuilder strSql16 = new StringBuilder();
            StringBuilder strSql17 = new StringBuilder();
            StringBuilder strSql18 = new StringBuilder();

            strSql0.Append("UPDATE [dbo].[CRM_Customer] SET [isDelete]=0 WHERE [isDelete] is null");
            strSql1.Append("UPDATE [dbo].[CRM_Customer] SET [industry_id] = (select  id from Param_SysParam where params_name=CRM_Customer.industry and parentid=8 and Factory_Id=CRM_Customer.Factory_Id limit `1)");
            strSql2.Append("UPDATE [dbo].[CRM_Customer] SET [CustomerType_id] = (select  id from Param_SysParam where params_name=CRM_Customer.CustomerType and parentid=1 and Factory_Id=CRM_Customer.Factory_Id limit 1)");
            strSql3.Append("UPDATE [dbo].[CRM_Customer] SET [CustomerLevel_id] = (select  id from Param_SysParam where params_name=CRM_Customer.CustomerLevel and parentid=2 and Factory_Id=CRM_Customer.Factory_Id limit 1)");
            strSql4.Append("UPDATE [dbo].[CRM_Customer] SET [CustomerSource_id] = (select id from Param_SysParam where params_name=CRM_Customer.CustomerSource and parentid=3 and Factory_Id=CRM_Customer.Factory_Id limit 1)");

            strSql17.Append("UPDATE [dbo].[CRM_Customer] SET [Nation_id] = (select  region_id from Param_Area where region_name=CRM_Customer.Nation limit 1)");
            strSql5.Append("UPDATE [dbo].[CRM_Customer] SET [Provinces_id] = (select  region_id from Param_Area where region_name=CRM_Customer.Provinces limit 1)");
            strSql6.Append("UPDATE [dbo].[CRM_Customer] SET [City_id] = (select  region_id from Param_Area where region_name=CRM_Customer.City limit 1)");
            strSql18.Append("UPDATE [dbo].[CRM_Customer] SET [District_id] = (select  region_id from Param_Area where region_name=CRM_Customer.District limit 1)");

            strSql7.Append("UPDATE [dbo].[CRM_Customer] SET [Department_id] = (select  id from hr_department where d_name=CRM_Customer.Department and Factory_Id=CRM_Customer.Factory_Id limit 1)");
            strSql8.Append("UPDATE [dbo].[CRM_Customer] SET [Employee_id] = (select ID from hr_employee where name=CRM_Customer.Employee and Factory_Id=CRM_Customer.Factory_Id limit 1)");
            strSql10.Append("UPDATE [dbo].[CRM_Customer] SET [FollowUp_id] = (select  id from Param_SysParam where params_name=CRM_Customer.FollowUp and parentid=9 and Factory_Id=CRM_Customer.Factory_Id limit 1)");
            strSql11.Append("UPDATE [dbo].[CRM_Customer] SET [CustomerValue_id] = (select  id from Param_SysParam where params_name=CRM_Customer.CustomerValue and parentid=10 and Factory_Id=CRM_Customer.Factory_Id limit 1)");
            strSql12.Append("UPDATE [dbo].[CRM_Customer] SET [BeSeats_id] = (select  ID from hr_employee where name=CRM_Customer.BeSeats and Factory_Id=CRM_Customer.Factory_Id limit 1)");

            //�ͻ�״̬
            strSql13.Append("UPDATE [dbo].[CRM_Customer] SET [privatecustomer_Id] = (select id from  Param_SysParam where params_name=CRM_Customer.privatecustomer and parentid=12 and Factory_Id=CRM_Customer.Factory_Id limit 1)");
            strSql15.Append("UPDATE [dbo].[CRM_Customer] SET [Employee_uid] = (select  ID from hr_employee where name=CRM_Customer.Employee and Factory_Id=CRM_Customer.Factory_Id limit 1)");
            strSql16.Append("UPDATE [dbo].[CRM_Customer] SET [BeSeats_uid] = (select  uid from hr_employee where name=CRM_Customer.BeSeats and Factory_Id=CRM_Customer.Factory_Id limit 1)");
            strSql17.Append("UPDATE [dbo].[CRM_Customer] SET [BeSeats_depid] = (select  id from hr_department where d_name=CRM_Customer.BeSeats_depname and Factory_Id=CRM_Customer.Factory_Id limit 1)");


            strSql9.Append(string.Format("UPDATE [dbo].[CRM_Customer] SET Create_id={0},Create_name='{1}',Create_date='{2}' where emp_id is null ", emp_id, create_name, create_name));

            int rows0 = DbHelperMySQL.ExecuteSql(strSql0.ToString());
            int rows1 = DbHelperMySQL.ExecuteSql(strSql1.ToString());
            int rows2 = DbHelperMySQL.ExecuteSql(strSql2.ToString());
            int rows3 = DbHelperMySQL.ExecuteSql(strSql3.ToString());
            int rows4 = DbHelperMySQL.ExecuteSql(strSql4.ToString());
            int rows5 = DbHelperMySQL.ExecuteSql(strSql5.ToString());
            int rows6 = DbHelperMySQL.ExecuteSql(strSql6.ToString());
            int rows7 = DbHelperMySQL.ExecuteSql(strSql7.ToString());
            int rows8 = DbHelperMySQL.ExecuteSql(strSql8.ToString());
            int rows10 = DbHelperMySQL.ExecuteSql(strSql10.ToString());
            int rows11 = DbHelperMySQL.ExecuteSql(strSql11.ToString());
            int rows12 = DbHelperMySQL.ExecuteSql(strSql12.ToString());
            int rows13 = DbHelperMySQL.ExecuteSql(strSql13.ToString());
            int rows15 = DbHelperMySQL.ExecuteSql(strSql15.ToString());
            int rows16 = DbHelperMySQL.ExecuteSql(strSql16.ToString());
            int rows17 = DbHelperMySQL.ExecuteSql(strSql17.ToString());
            int rows18 = DbHelperMySQL.ExecuteSql(strSql18.ToString());

            if (rows0 > 0 && rows1 > 0 && rows2 > 0 && rows3 > 0 && rows4 > 0 && rows5 > 0 && rows6 > 0 && rows7 > 0 && rows8 > 0 && rows10 > 0 && rows11 > 0 && rows12 > 0 && rows13 > 0 && rows15 > 0 && rows16 > 0 && rows17 > 0 && rows18 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ͳ��©��
        /// </summary>
        public DataSet Funnel(string strWhere, string year, string whereStr1)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from ");
            strSql.Append("( ");
            strSql.Append("	select  ");
            strSql.Append("		a.params_name as CustomerType, ");
            strSql.Append("		a.id as CustomerType_id, ");
            strSql.Append("		a.params_order , ");
            strSql.Append("		COUNT(b.id) as cc  ");
            strSql.Append("	from  ");
            strSql.Append("		Param_SysParam as a left join ( ");
            strSql.Append("			select * from CRM_Customer  ");

            if (year.Trim() != "")
            {
                strSql.Append("			where timestampdiff(year,Create_date,'" + year + "-01-01')=0  ");
            }
            if (whereStr1.Trim() != "")
            {
                strSql.Append(whereStr1);
            }
            strSql.Append("			)as b  ");
            strSql.Append("		on a.id = b.CustomerType_id  ");
            strSql.Append("	where a.parentid = 1 ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" and  " + strWhere);
            }

            strSql.Append("	group by  ");
            strSql.Append("		a.params_name, ");
            strSql.Append("		a.id, ");
            strSql.Append("		a.params_order ");
            strSql.Append(") as t1 ");
            strSql.Append("order by params_order ");

            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// ��ϵͳ�ư������ͺ�˽��
        /// </summary>
        public DataSet Contact_Statistics(string idlist, string serchstr)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,name, sum(CASE  mm>3 WHEN  1 THEN cn ELSE 0 END ) 'd3',  ");
            strSql.Append("sum(CASE mm>7 WHEN  1 THEN cn ELSE 0 END ) 'd7',                   ");
            strSql.Append("sum(CASE mm>14 WHEN  1 THEN cn ELSE 0 END ) 'd14',                 ");
            strSql.Append("sum(CASE nn!=0  WHEN  1 THEN cn ELSE 0 END ) 'mm'                      ");
            strSql.Append("from (  ");
            strSql.Append("SELECT   hr_employee.ID, hr_employee.name, COUNT(derivedtbl_1.id) AS cn, TIMESTAMPDIFF(DAY,derivedtbl_1.lastfollow, curdate())AS mm,  TIMESTAMPDIFF(month,derivedtbl_1.lastfollow, curdate())AS nn    ");
            strSql.Append("FROM   	hr_employee LEFT OUTER JOIN    ");
            strSql.Append("(SELECT   id, BeSeats_id, lastfollow    ");
            strSql.Append("FROM     	 CRM_Customer              ");
            strSql.Append("WHERE  ifnull(isdelete,0)=0 " + serchstr + ") AS derivedtbl_1 ON hr_employee.ID = derivedtbl_1.BeSeats_id ");
            strSql.Append(" WHERE hr_employee.ID in " + idlist);
            strSql.Append("GROUP BY hr_employee.ID, hr_employee.name, TIMESTAMPDIFF(DAY,derivedtbl_1.lastfollow, curdate()) )tt   ");
            strSql.Append("GROUP BY  id,name  ");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //�ͷ��ľ�����
        public DataSet Dealer(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select distinct f.* from sys_factoryinfo as f inner join  crm_customer as c on c.myFactory_Id=f.Factory_Id ");
            strSql1.Append(" select count(distinct f.Factory_Id) from sys_factoryinfo  as f inner join  crm_customer as c on c.myFactory_Id=f.Factory_Id ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            // strSql.Append(")");
            //  strSql1.Append(")");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //���ݹ�˾���ƾ�����

        public DataSet Dealer(int PageSize, int PageIndex, string strWhere, string key, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select distinct abc.* from crm_customer as u inner join ( ");
            strSql.Append(" select c.Myfactory_id,f.*  from crm_customer as c inner join sys_factoryinfo as f on c.myFactory_Id=f.Factory_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append("  ) as abc on u.factory_id=abc.Myfactory_id ");
            strSql.Append("  where u.customer like '%" + key + "%'");

            strSql1.Append(" select count( distinct  abc.id) from crm_customer as u inner join ( ");
            strSql1.Append(" select c.Myfactory_id,f.*  from crm_customer as c inner join sys_factoryinfo as f on c.myFactory_Id=f.Factory_id ");
            if (strWhere.Trim() != "")
            {
                strSql1.Append(" where " + strWhere);
            }
            strSql1.Append("  ) as abc on u.factory_id=abc.Myfactory_id ");
            strSql1.Append("  where u.customer like '%" + key + "%'");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet SearchDealer(int PageSize, int PageIndex, string strWhere, string strWhere2, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select distinct abc.* from crm_customer as u right join ( ");
            strSql.Append(" select c.Myfactory_id,f.*  from crm_customer as c inner join sys_factoryinfo as f on c.myFactory_Id=f.Factory_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append("  ) as abc on u.factory_id=abc.Myfactory_id ");
            strSql.Append("  where " + strWhere2);

            strSql1.Append(" select count( distinct  abc.id) from crm_customer as u right join ( ");
            strSql1.Append(" select c.Myfactory_id,f.*  from crm_customer as c inner join sys_factoryinfo as f on c.myFactory_Id=f.Factory_id ");
            if (strWhere.Trim() != "")
            {
                strSql1.Append(" where " + strWhere);
            }
            strSql1.Append("  ) as abc on u.factory_id=abc.Myfactory_id ");
            strSql1.Append("  where " + strWhere2);
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //������ϵ��ʽ��ѯ
        public DataSet DealerByPhone(int PageSize, int PageIndex, string strWhere, string key, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select distinct abc.* from crm_customer as u inner join ( ");
            strSql.Append(" select c.Myfactory_id,f.*  from crm_customer as c inner join sys_factoryinfo as f on c.myFactory_Id=f.Factory_id ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append("  ) as abc on u.factory_id=abc.Myfactory_id ");
            strSql.Append("inner join crm_contact as t on u.id=t.C_customerid ");
            strSql.Append("  where  t.C_tel like '%" + key + "%'  or t.C_mobone like '%" + key + "%'  or t.C_mobtwo like '%" + key + "%' or u.tel  like '%" + key + "%' ");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);

            strSql1.Append(" select count( distinct  abc.id) from crm_customer as u inner join ( ");
            strSql1.Append(" select c.Myfactory_id,f.*  from crm_customer as c inner join sys_factoryinfo as f on c.myFactory_Id=f.Factory_id ");
            if (strWhere.Trim() != "")
            {
                strSql1.Append(" where " + strWhere);
            }
            strSql1.Append("  ) as abc on u.factory_id=abc.Myfactory_id ");
            strSql1.Append("inner join crm_contact as t on u.id=t.C_customerid ");
            strSql1.Append("  where  t.C_tel like '%" + key + "%'  or t.C_mobone like '%" + key + "%'  or t.C_mobtwo like '%" + key + "%' or u.tel  like '%" + key + "%' ");
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //�ͷ������̵Ŀͻ�
        public DataSet DealerCot(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select * from sys_factoryinfo ");
            strSql1.Append(" select count(*) from sys_factoryinfo ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            // strSql.Append(")");
            //  strSql1.Append(")");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string strWhere2, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select distinct f.Factory_Id  from  sys_factoryinfo  as f inner join ");
            strSql.Append(" (select  * from  crm_customer  ");
            strSql1.Append(" select distinct f.Factory_Id  from  sys_factoryinfo  as f inner join ");
            strSql1.Append(" (select  * from  crm_customer  ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(") as t on t. myFactory_Id=f.Factory_Id ");
            strSql1.Append(") as t on t. myFactory_Id=f.Factory_Id ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
                strSql1.Append(" where " + strWhere2);
            }


            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }
        //�ͷ������̵Ŀͻ�
        public DataSet Dealer_customer(int PageSize, int PageIndex, string strWhere, string strWhere2, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();



            strSql.Append(" select xx.* from(");
            strSql.Append(" (select * from 	((");
            strSql.Append(" select distinct myFactory_Id from crm_customer ");
            // strSql.Append(" select distinct myFactory_Id from crm_customer ");
            // strSql.Append(" select distinct myFactory_Id from crm_customer ");
            strSql1.Append(" select  count(*) from(");
            strSql1.Append(" (select * from 	((");
            strSql1.Append(" select distinct myFactory_Id from crm_customer ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" ) rr inner join (select Factory_Id from  sys_factoryinfo where IsDelete<>'1')ss on ss.Factory_Id=rr.myFactory_Id) ) aa  ");
            strSql.Append("	inner join crm_customer xx on aa.myFactory_Id=xx.Factory_Id) ");
            strSql.Append(" where " + strWhere2);

            strSql1.Append(" ) rr inner join (select Factory_Id from  sys_factoryinfo where IsDelete<>'1')ss on ss.Factory_Id=rr.myFactory_Id) ) aa  ");
            strSql1.Append(" inner join crm_customer xx on aa.myFactory_Id=xx.Factory_Id) ");
            strSql1.Append(" where " + strWhere2);

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ͨ���ֻ��Ż�˾���ƾ�ȷ��ȡ�ͻ�
        /// </summary>
        public DataSet exactSearch(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
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
            strSql.Append(" select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum  FROM crm_customer c ");
            if (strWhere2.Trim() != "")
            {
                strSql.Append(" where " + strWhere2);
            }
            strSql.Append(") as unioninfo");

            //strSql.Append(" WHERE F.Follow like '%" + key + "%' and C.id not in ( SELECT top " + (PageIndex - 1) * PageSize + " C.id FROM CRM_Customer C ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append("select  count(distinct id)  from(");
            strSql1.Append(" select C.id FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid ");
            if (strWhere1.Trim() != "")
            {
                strSql1.Append(" where " + strWhere1);
            }
            strSql1.Append("  Union all");
            strSql1.Append(" select C.id FROM crm_customer c ");
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
        /// ͨ���ֻ��š���˾���ơ���ϵ�˾�ȷ��ȡ�ͻ�
        /// </summary>
        public DataSet exactGet(int PageSize, int PageIndex, string strWhere1, string strWhere2, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();

            strSql.Append("SELECT  distinct *  from (");
            strSql.Append(" select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum,a.id as userId, a.C_tel,a.C_name  FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid ");
            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
            }
            strSql.Append("  Union all");
            strSql.Append(" select C.id,C.Factory_Id,C.myFactory_Id,C.Serialnumber,C.Customer,C.tel,C.fax,C.site,C.industry,C.Nation,C.Provinces,C.City,C.District,C.CustomerType,C.CustomerLevel,C.CustomerSource,C.Department_id,C.Department,C.Employee_id,C.Employee,C.privatecustomer,C.lastfollow,C.Create_date,C.FollowUp_id,C.FollowUp,C.CustomerValue_id,C.CustomerValue,C.BeSeats_id,C.BeSeats,C.privatecustomer_Id,C.emp_handnum,a.id as userId, a.C_tel,a.C_name  FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid ");
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
            strSql1.Append(" select C.id FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid ");
            if (strWhere2.Trim() != "")
            {
                strSql1.Append(" where " + strWhere2);
            }
            strSql1.Append(") as unioninfo");
            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// ͨ���ֻ��š���˾���ơ���ϵ�˾�ȷ��ȡ�ͻ�
        public DataSet getCusInfo(int PageSize, int PageIndex, string strWhere1, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select  c.id,c.Factory_Id,c.Customer,c.tel,c.privatecustomer,c.privatecustomer_Id, ");
            strSql.Append(" a.id as userId, a.C_tel,a.C_name ");
            strSql.Append(" FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid ");
            //strSql.Append(" left join (  select  i.user_id, r.goods_id,count(r.order_id) as ordernum  from xmh_shop.shop_order_goods r ");
            //strSql.Append(" inner join  xmh_shop.shop_order_info i on r.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null  group by i.user_id )  ");
            //strSql.Append(" as oi on oi.user_id=a.id ");

            strSql1.Append(" select count(c.id) FROM crm_customer c inner join crm_contact a on c.id = a.C_customerid ");
            //strSql1.Append(" left join (  select  i.user_id, r.goods_id,count(r.order_id) as ordernum  from xmh_shop.shop_order_goods r ");
            //strSql1.Append(" inner join  xmh_shop.shop_order_info i on r.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null  group by i.user_id )  ");
            //strSql1.Append(" as oi on oi.user_id=a.id ");

            if (strWhere1.Trim() != "")
            {
                strSql.Append(" where " + strWhere1);
                strSql1.Append(" where " + strWhere1);
            }

            strSql.Append(" order by " + filedOrder + "  limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //��ѯ�ͻ��Ķ�����
        public DataSet getCusOrderNum(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append(" select * from (");
            strSql.Append(" select i.user_id, r.goods_id,count(r.order_id) as ordernum,i.add_time from xmh_shop.shop_order_goods r ");
            strSql.Append(" inner join  xmh_shop.shop_order_info i on r.order_id= i.order_id and i.order_status !=9 and i.erp_time is not null  group by i.user_id   ");
            strSql.Append(" ) as o ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            return DbHelperMySQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}
