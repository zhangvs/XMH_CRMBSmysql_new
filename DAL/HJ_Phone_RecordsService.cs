using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references

namespace XHD.DAL
{
    public partial class HJ_Phone_RecordsService
    {
        public HJ_Phone_RecordsService()
        { }

        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XHD.Model.HJ_Phone_RecordsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into hj_phone_records(");
            strSql.Append("Factory_Id,tq_PhoneState,PhoneNum,Phone_Cust,Phone_Emp,Phone_Seat,CallTime,Time_Begin,Time_End,Id_Emp,EmpName,EmpDID,EmpDName,EmpIdCard,Customerid,Customer,CusAttribution,ContactName,File_Path,CallType,Answered,Appraise_Level,Remark,DialingRoute,InboundQueue,BusinessClass,ProceState,MemAccount,MediaSources,IsThirdParty,Evaluation,Clue,Relay)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@tq_PhoneState,@PhoneNum,@Phone_Cust,@Phone_Emp,@Phone_Seat,@CallTime,@Time_Begin,@Time_End,@Id_Emp,@EmpName,@EmpDID,@EmpDName,@EmpIdCard,@Customerid,@Customer,@CusAttribution,@ContactName,@File_Path,@CallType,@Answered,@Appraise_Level,@Remark,@DialingRoute,@InboundQueue,@BusinessClass,@ProceState,@MemAccount,@MediaSources,@IsThirdParty,@Evaluation,@Clue,@Relay)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@tq_PhoneState", MySqlDbType.VarChar,1),
					new MySqlParameter("@PhoneNum", MySqlDbType.VarChar,20),
					new MySqlParameter("@Phone_Cust", MySqlDbType.VarChar,20),
					new MySqlParameter("@Phone_Emp", MySqlDbType.VarChar,20),
					new MySqlParameter("@Phone_Seat", MySqlDbType.VarChar,20),
					new MySqlParameter("@CallTime", MySqlDbType.DateTime),
					new MySqlParameter("@Time_Begin", MySqlDbType.DateTime),
					new MySqlParameter("@Time_End", MySqlDbType.DateTime),
					new MySqlParameter("@Id_Emp", MySqlDbType.Int32,11),
					new MySqlParameter("@EmpName", MySqlDbType.VarChar,50),
					new MySqlParameter("@EmpDID", MySqlDbType.Int32,11),
					new MySqlParameter("@EmpDName", MySqlDbType.VarChar,50),
					new MySqlParameter("@EmpIdCard", MySqlDbType.VarChar,50),
					new MySqlParameter("@Customerid", MySqlDbType.Int32,11),
					new MySqlParameter("@Customer", MySqlDbType.VarChar,250),
					new MySqlParameter("@CusAttribution", MySqlDbType.VarChar,100),
					new MySqlParameter("@ContactName", MySqlDbType.VarChar,50),
					new MySqlParameter("@File_Path", MySqlDbType.VarChar,500),
					new MySqlParameter("@CallType", MySqlDbType.VarChar,1),
					new MySqlParameter("@Answered", MySqlDbType.VarChar,1),
					new MySqlParameter("@Appraise_Level", MySqlDbType.VarChar,1),
					new MySqlParameter("@Remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@DialingRoute", MySqlDbType.VarChar,100),
					new MySqlParameter("@InboundQueue", MySqlDbType.VarChar,100),
					new MySqlParameter("@BusinessClass", MySqlDbType.VarChar,100),
					new MySqlParameter("@ProceState", MySqlDbType.VarChar,1),
					new MySqlParameter("@MemAccount", MySqlDbType.VarChar,50),
					new MySqlParameter("@MediaSources", MySqlDbType.VarChar,100),
					new MySqlParameter("@IsThirdParty", MySqlDbType.VarChar,1),
					new MySqlParameter("@Evaluation", MySqlDbType.LongText),
					new MySqlParameter("@Clue", MySqlDbType.LongText),
					new MySqlParameter("@Relay", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.tq_PhoneState;
            parameters[2].Value = model.PhoneNum;
            parameters[3].Value = model.Phone_Cust;
            parameters[4].Value = model.Phone_Emp;
            parameters[5].Value = model.Phone_Seat;
            parameters[6].Value = model.CallTime;
            parameters[7].Value = model.Time_Begin;
            parameters[8].Value = model.Time_End;
            parameters[9].Value = model.Id_Emp;
            parameters[10].Value = model.EmpName;
            parameters[11].Value = model.EmpDID;
            parameters[12].Value = model.EmpDName;
            parameters[13].Value = model.EmpIdCard;
            parameters[14].Value = model.Customerid;
            parameters[15].Value = model.Customer;
            parameters[16].Value = model.CusAttribution;
            parameters[17].Value = model.ContactName;
            parameters[18].Value = model.File_Path;
            parameters[19].Value = model.CallType;
            parameters[20].Value = model.Answered;
            parameters[21].Value = model.Appraise_Level;
            parameters[22].Value = model.Remark;
            parameters[23].Value = model.DialingRoute;
            parameters[24].Value = model.InboundQueue;
            parameters[25].Value = model.BusinessClass;
            parameters[26].Value = model.ProceState;
            parameters[27].Value = model.MemAccount;
            parameters[28].Value = model.MediaSources;
            parameters[29].Value = model.IsThirdParty;
            parameters[30].Value = model.Evaluation;
            parameters[31].Value = model.Clue;
            parameters[32].Value = model.Relay;

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
        public bool Update(XHD.Model.HJ_Phone_RecordsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hj_phone_records set ");
            strSql.Append("tq_PhoneState=@tq_PhoneState,");
            strSql.Append("CallTime=@CallTime,");
            strSql.Append("Time_Begin=@Time_Begin,");
            strSql.Append("Time_End=@Time_End,");
            strSql.Append("File_Path=@File_Path,");
            strSql.Append("Answered=@Answered,");
            strSql.Append("Appraise_Level=@Appraise_Level,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("DialingRoute=@DialingRoute,");
            strSql.Append("InboundQueue=@InboundQueue,");
            strSql.Append("BusinessClass=@BusinessClass,");
            strSql.Append("ProceState=@ProceState,");
            strSql.Append("MemAccount=@MemAccount,");
            strSql.Append("MediaSources=@MediaSources,");
            strSql.Append("IsThirdParty=@IsThirdParty,");
            strSql.Append("Evaluation=@Evaluation,");
            strSql.Append("Clue=@Clue,");
            strSql.Append("Relay=@Relay,");
            strSql.Append("Phone_Seat=@Phone_Seat,");
            strSql.Append("Phone_Cust=@Phone_Cust");
            strSql.Append(" where PhoneNum=@PhoneNum");
            strSql.Append(" and Factory_Id=@Factory_Id ");

            MySqlParameter[] parameters = {
					new MySqlParameter("@tq_PhoneState", MySqlDbType.VarChar,1),
					new MySqlParameter("@CallTime", MySqlDbType.DateTime),
					new MySqlParameter("@Time_Begin", MySqlDbType.DateTime),
					new MySqlParameter("@Time_End", MySqlDbType.DateTime),
					new MySqlParameter("@File_Path", MySqlDbType.VarChar,500),
					new MySqlParameter("@Answered", MySqlDbType.VarChar,1),
					new MySqlParameter("@Appraise_Level", MySqlDbType.VarChar,1),
					new MySqlParameter("@Remark", MySqlDbType.VarChar,200),
					new MySqlParameter("@DialingRoute", MySqlDbType.VarChar,100),
					new MySqlParameter("@InboundQueue", MySqlDbType.VarChar,100),
					new MySqlParameter("@BusinessClass", MySqlDbType.VarChar,100),
					new MySqlParameter("@ProceState", MySqlDbType.VarChar,1),
					new MySqlParameter("@MemAccount", MySqlDbType.VarChar,50),
					new MySqlParameter("@MediaSources", MySqlDbType.VarChar,100),
					new MySqlParameter("@IsThirdParty", MySqlDbType.VarChar,1),
					new MySqlParameter("@Evaluation", MySqlDbType.LongText),
					new MySqlParameter("@Clue", MySqlDbType.LongText),
					new MySqlParameter("@Relay", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Phone_Seat", MySqlDbType.VarChar,50),
                    new MySqlParameter("@Phone_Cust", MySqlDbType.VarChar,50),
					new MySqlParameter("@PhoneNum", MySqlDbType.VarChar,20),
                    new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60)};
            parameters[0].Value = model.tq_PhoneState;
            parameters[1].Value = model.CallTime;
            parameters[2].Value = model.Time_Begin;
            parameters[3].Value = model.Time_End;
            parameters[4].Value = model.File_Path;
            parameters[5].Value = model.Answered;
            parameters[6].Value = model.Appraise_Level;
            parameters[7].Value = model.Remark;
            parameters[8].Value = model.DialingRoute;
            parameters[9].Value = model.InboundQueue;
            parameters[10].Value = model.BusinessClass;
            parameters[11].Value = model.ProceState;
            parameters[12].Value = model.MemAccount;
            parameters[13].Value = model.MediaSources;
            parameters[14].Value = model.IsThirdParty;
            parameters[15].Value = model.Evaluation;
            parameters[16].Value = model.Clue;
            parameters[17].Value = model.Relay;
            parameters[18].Value = model.Phone_Seat;
            parameters[19].Value = model.Phone_Cust;
            parameters[20].Value = model.PhoneNum;
            parameters[21].Value = model.Factory_Id;

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
        /// 获得数据列表
        /// </summary>
        public DataSet GetListPhone(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,tq_PhoneState,PhoneNum,Phone_Cust,Phone_Emp,Phone_Seat,CallTime,Time_Begin,Time_End,Id_Emp,EmpName,EmpDID,EmpDName,EmpIdCard,Customerid,Customer,CusAttribution,ContactName,File_Path,CallType,Answered,Appraise_Level,Remark,DialingRoute,InboundQueue,BusinessClass,ProceState,MemAccount,MediaSources,IsThirdParty,Evaluation,Clue,Relay ");
            strSql.Append(" FROM hj_phone_records ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XHD.Model.HJ_Phone_RecordsInfo DataRowToModel(DataRow row)
        {
            XHD.Model.HJ_Phone_RecordsInfo model = new XHD.Model.HJ_Phone_RecordsInfo();
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
                if (row["tq_PhoneState"] != null)
                {
                    model.tq_PhoneState = row["tq_PhoneState"].ToString();
                }
                if (row["PhoneNum"] != null)
                {
                    model.PhoneNum = row["PhoneNum"].ToString();
                }
                if (row["Phone_Cust"] != null)
                {
                    model.Phone_Cust = row["Phone_Cust"].ToString();
                }
                if (row["Phone_Emp"] != null)
                {
                    model.Phone_Emp = row["Phone_Emp"].ToString();
                }
                if (row["Phone_Seat"] != null)
                {
                    model.Phone_Seat = row["Phone_Seat"].ToString();
                }
                if (row["CallTime"] != null && row["CallTime"].ToString() != "")
                {
                    model.CallTime = DateTime.Parse(row["CallTime"].ToString());
                }
                if (row["Time_Begin"] != null && row["Time_Begin"].ToString() != "")
                {
                    model.Time_Begin = DateTime.Parse(row["Time_Begin"].ToString());
                }
                if (row["Time_End"] != null && row["Time_End"].ToString() != "")
                {
                    model.Time_End = DateTime.Parse(row["Time_End"].ToString());
                }
                if (row["Id_Emp"] != null && row["Id_Emp"].ToString() != "")
                {
                    model.Id_Emp = int.Parse(row["Id_Emp"].ToString());
                }
                if (row["EmpName"] != null)
                {
                    model.EmpName = row["EmpName"].ToString();
                }
                if (row["EmpDID"] != null && row["EmpDID"].ToString() != "")
                {
                    model.EmpDID = int.Parse(row["EmpDID"].ToString());
                }
                if (row["EmpDName"] != null)
                {
                    model.EmpDName = row["EmpDName"].ToString();
                }
                if (row["EmpIdCard"] != null)
                {
                    model.EmpIdCard = row["EmpIdCard"].ToString();
                }
                if (row["Customerid"] != null && row["Customerid"].ToString() != "")
                {
                    model.Customerid = int.Parse(row["Customerid"].ToString());
                }
                if (row["Customer"] != null)
                {
                    model.Customer = row["Customer"].ToString();
                }
                if (row["CusAttribution"] != null)
                {
                    model.CusAttribution = row["CusAttribution"].ToString();
                }
                if (row["ContactName"] != null)
                {
                    model.ContactName = row["ContactName"].ToString();
                }
                if (row["File_Path"] != null)
                {
                    model.File_Path = row["File_Path"].ToString();
                }
                if (row["CallType"] != null)
                {
                    model.CallType = row["CallType"].ToString();
                }
                if (row["Answered"] != null)
                {
                    model.Answered = row["Answered"].ToString();
                }
                if (row["Appraise_Level"] != null)
                {
                    model.Appraise_Level = row["Appraise_Level"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["DialingRoute"] != null)
                {
                    model.DialingRoute = row["DialingRoute"].ToString();
                }
                if (row["InboundQueue"] != null)
                {
                    model.InboundQueue = row["InboundQueue"].ToString();
                }
                if (row["BusinessClass"] != null)
                {
                    model.BusinessClass = row["BusinessClass"].ToString();
                }
                if (row["ProceState"] != null)
                {
                    model.ProceState = row["ProceState"].ToString();
                }
                if (row["MemAccount"] != null)
                {
                    model.MemAccount = row["MemAccount"].ToString();
                }
                if (row["MediaSources"] != null)
                {
                    model.MediaSources = row["MediaSources"].ToString();
                }
                if (row["IsThirdParty"] != null)
                {
                    model.IsThirdParty = row["IsThirdParty"].ToString();
                }
                if (row["Evaluation"] != null)
                {
                    model.Evaluation = row["Evaluation"].ToString();
                }
                if (row["Clue"] != null)
                {
                    model.Clue = row["Clue"].ToString();
                }
                if (row["Relay"] != null)
                {
                    model.Relay = row["Relay"].ToString();
                }
            }
            return model;
        }
        /// <summary>
        /// 批量转客户
        /// </summary>
        public bool Update_batch(XHD.Model.CRM_Customer model, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CRM_Customer set ");
            strSql.Append("Department_id=@Department_id,");
            strSql.Append("Department=@Department,");
            strSql.Append("Employee_id=@Employee_id,");
            strSql.Append("Employee=@Employee");
            strSql.Append(" where Employee_id=@Create_id");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            MySqlParameter[] parameters = {					
					new MySqlParameter("@Department_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Department", MySqlDbType.VarChar,250),
					new MySqlParameter("@Employee_id", MySqlDbType.Int32,4),
					new MySqlParameter("@Employee", MySqlDbType.VarChar,250),
                    new MySqlParameter("@Create_id", MySqlDbType.Int32,4)
                                        };
            parameters[0].Value = model.Department_id;
            parameters[1].Value = model.Department;
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  P.id,P.PhoneNum,P.Phone_Cust,P.Phone_Emp,P.Time_Begin,P.Time_End,TIMESTAMPDIFF(SECOND,P.CallTime,P.Time_Begin) as BellTime,p.CallTime,P.Id_Emp,TIMESTAMPDIFF(SECOND,P.Time_Begin,P.Time_End) as TalkTime,P.EmpName,P.EmpDName,P.EmpIdCard,P.Customerid,P.Customer,P.CusAttribution,P.ContactName,P.File_Path,P.CallType,P.Answered,P.Appraise_Level,P.Remark,P.DialingRoute,P.InboundQueue,P.BusinessClass,P.ProceState,P.MemAccount,P.MediaSources,P.IsThirdParty,P.Evaluation,P.Phone_Seat,P.Clue,P.Relay,P.tq_PhoneState,P.Factory_Id,P.EmpDID FROM HJ_Phone_Records P ");
            //strSql.Append(" WHERE   P.Id not in ( SELECT top " + (PageIndex - 1) * PageSize + " P.Id FROM HJ_Phone_Records P ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(P.Id) FROM HJ_Phone_Records P ");
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
        public DataSet GetListOnePage(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  id,File_Path FROM HJ_Phone_Records ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM HJ_Phone_Records ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM HJ_Phone_Records ");
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
        /// 获得数据列表
        /// </summary>
        public DataTable GetListProc(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" id FROM HJ_Phone_Records ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM HJ_Phone_Records ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM HJ_Phone_Records ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
                strSql1.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder + " limit " + (PageIndex - 1) * PageSize + "," + PageSize);
            Total = DbHelperMySQL.Query(strSql1.ToString()).Tables[0].Rows[0][0].ToString();
            return DbHelperMySQL.Query(strSql.ToString()).Tables[0];
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Serialnumber,Customer,address,tel,fax,site,industry_id,industry,Provinces_id,Provinces,City_id,City,CustomerType_id,CustomerType,CustomerLevel_id,CustomerLevel,CustomerSource_id,CustomerSource,DesCripe,Remarks,Department_id,Department,Employee_id,Employee,privatecustomer,lastfollow,Create_id,Create_name,Create_date,isDelete,Delete_time,FollowUp_id,FollowUp,CustomerValue_id,CustomerValue,PhoneIsValid_id,PhoneIsValid,BeSeats_id,BeSeats ");
            strSql.Append(" FROM CRM_Customer");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetOneList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,File_Path ");
            strSql.Append(" FROM HJ_Phone_Records");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //批量处理所有数据
        public bool UpdateProcess(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update HJ_Phone_Records set ");
            strSql.Append("ProceState=1");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
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

        public DataTable GetAll(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,File_Path ");
            strSql.Append(" FROM HJ_Phone_Records");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString()).Tables[0];
        }


        /// <summary>
        /// 导出当前页
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
            strSql.Append(" P.id, P.PhoneNum as '电话编号',");
            strSql.Append(" A.C_name as '姓名',");
            strSql.Append(" P.Customer as '公司名称',");
            strSql.Append(" P.Phone_Cust as '电话号码',");
            strSql.Append(" P.CusAttribution as '归属地',");
            strSql.Append(" P.Answered as '是否接通',");
            strSql.Append(" (timestampdiff(second, P.CallTime,P.Time_Begin)) as '响铃时间(秒)',");
            strSql.Append(" (timestampdiff(second, P.Time_Begin,P.Time_End))as '通话时间(秒)',");
            strSql.Append(" P.CallTime as '拨打时间',");
            strSql.Append(" P.EmpName as '拨打方',");
            strSql.Append(" P.DialingRoute as '拨号路由',");
            strSql.Append(" P.InboundQueue as '呼入队列',");
            strSql.Append(" P.Appraise_Level as '满意度评价',");
            strSql.Append(" P.BusinessClass as '业务类别',");
            strSql.Append(" P.ProceState as '处理状态',");
            strSql.Append(" P.MemAccount as '会员账号',");
            strSql.Append(" P.MediaSources as '媒体来源',");
            strSql.Append(" P.Evaluation as '评价',");
            strSql.Append(" P.Remark as '电话备注',");
            strSql.Append(" P.EmpName as '接打人',");
            strSql.Append(" P.EmpDName as '所属部门',");
            strSql.Append(" P.EmpIdCard as '座席工号',");
            strSql.Append(" P.Phone_Seat as '座席电话'");
            strSql.Append(" FROM HJ_Phone_Records P");
            strSql.Append(" left join  CRM_Contact A on P.Customerid=A.C_customerid");
            //strSql.Append(" WHERE  A.IsDefaultContact=1 and  P.Id not in ( SELECT top " + (PageIndex - 1) * PageSize + " P.Id FROM HJ_Phone_Records P ");
            //strSql.Append(" where " + strWhere + " ) ");
            strSql1.Append(" select count(P.Id) FROM HJ_Phone_Records P ");
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
            strSql.Append(" P.PhoneNum as '电话编号',");
            strSql.Append(" A.C_name as '姓名',");
            strSql.Append(" P.Customer as '公司名称',");
            strSql.Append(" P.Phone_Cust as '电话号码',");
            strSql.Append(" P.CusAttribution as '归属地',");
            strSql.Append(" P.Answered as '是否接通',");
            strSql.Append(" (timestampdiff(second, P.CallTime,P.Time_Begin)) as '响铃时间(秒)',");
            strSql.Append(" (timestampdiff(second, P.Time_Begin,P.Time_End))as '通话时间(秒)',");
            strSql.Append(" P.CallTime as '拨打时间',");
            strSql.Append(" P.EmpName as '拨打方',");
            strSql.Append(" P.DialingRoute as '拨号路由',");
            strSql.Append(" P.InboundQueue as '呼入队列',");
            strSql.Append(" P.Appraise_Level as '满意度评价',");
            strSql.Append(" P.BusinessClass as '业务类别',");
            strSql.Append(" P.ProceState as '处理状态',");
            strSql.Append(" P.MemAccount as '会员账号',");
            strSql.Append(" P.MediaSources as '媒体来源',");
            strSql.Append(" P.Evaluation as '评价',");
            strSql.Append(" P.Remark as '电话备注',");
            strSql.Append(" P.EmpName as '接打人',");
            strSql.Append(" P.EmpDName as '所属部门',");
            strSql.Append(" P.EmpIdCard as '座席工号',");
            strSql.Append(" P.Phone_Seat as '座席电话'");
            strSql.Append(" FROM HJ_Phone_Records P");
            strSql.Append(" left join  CRM_Contact A on P.Customerid=A.C_customerid");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //电话年度统计
        public DataSet Phone_year(string items, int year, string where)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("if OBJECT_ID('Tempdb..#t') is not null ");
            //strSql.Append("    drop TABLE  #t ");
            ////strSql.Append("go");
            //strSql.Append(" begin ");
            //strSql.Append("    --预统计表 #t");
            strSql.Append("   select " + items + " as items,");
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
            strSql.Append("        " + items + ",month(CallTime) mm,count(id)tNum  ");
            strSql.Append("    from HJ_Phone_Records ");
            strSql.Append("    where year(CallTime)=" + year);
            if (where.Trim() != "")
            {
                strSql.Append(" and " + where);
            }
            strSql.Append("    group by " + items + ",month(CallTime)) tt ");
            strSql.Append(" group by " + items + "  ");
            //strSql.Append("    --生成SQL");
            //strSql.Append("    declare @sql varchar(8000) ");
            //strSql.Append("    set @sql='select " + items + " items ' ");
            //strSql.Append("    select @sql = @sql + ',sum(case mm when ' + char(39) +mm+ char(39) + ' then tNum else 0 end) ['+ mm +']' ");
            //strSql.Append("        from (select distinct mm from #t)as data ");
            //strSql.Append("    set @sql = @sql + ' from #t group by " + items + "' ");

            //strSql.Append("    exec(@sql) ");
            //strSql.Append(" end ");
            //strSql.Append("go");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        //电话综合年统计
        public DataSet Phone_year(string items, int year, string where, bool temp)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("if OBJECT_ID('Tempdb..#t') is not null ");
            //strSql.Append("    drop TABLE  #t ");
            ////strSql.Append("go");
            //strSql.Append(" begin ");
            //strSql.Append("    --预统计表 #t");
            strSql.Append("   select items,");
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
            strSql.Append("    ( select         month(CallTime) mm, ");
            strSql.Append("  case when CallType=0 and answered = 0 then 1 	");
            strSql.Append("  when CallType=0 and answered = 1 then 2		");
            strSql.Append("  when CallType=1 and answered = 0 then 3		");
            strSql.Append("  when CallType=1 and answered = 1 then 4		");
            strSql.Append("  else 0 end items,							");
            strSql.Append("  count(id)tNum 								");
            strSql.Append("    from HJ_Phone_Records ");
            strSql.Append("    where year(CallTime)=" + year);
            if (where.Trim() != "")
            {
                strSql.Append(" and " + where);
            }
            strSql.Append("    group by month(CallTime),CallType,answered) tt ");
            strSql.Append(" group by items ");
            //strSql.Append("    --生成SQL");
            //strSql.Append("    declare @sql varchar(8000) ");
            //strSql.Append("    set @sql='select " + items + " items ' ");
            //strSql.Append("    select @sql = @sql + ',sum(case mm when ' + char(39) +mm+ char(39) + ' then tNum else 0 end) ['+ mm +']' ");
            //strSql.Append("        from (select distinct mm from #t)as data ");
            //strSql.Append("    set @sql = @sql + ' from #t group by " + items + "' ");
            //strSql.Append("    exec(@sql) ");

            //新方法
            //strSql.Append(" DECLARE @sql_str VARCHAR(8000)                                                                                      ");
            //strSql.Append(" DECLARE @sql_col VARCHAR(8000)                                                                                      ");
            //strSql.Append(" SELECT @sql_col = ISNULL(@sql_col + ',','') + QUOTENAME([mm]) FROM [#t] GROUP BY [mm]       ");
            //strSql.Append(" SET @sql_str = '                                                                                                    ");
            //strSql.Append(" SELECT * FROM (                                                                                                     ");
            //strSql.Append("     SELECT [items],[mm],[tNum] FROM [#t]) p PIVOT                                           ");
            //strSql.Append("     (SUM([tNum]) FOR [mm] IN ( '+ @sql_col +') ) AS pvt                                                      ");
            //strSql.Append(" ORDER BY pvt.[items]'                                                                                            ");
            //strSql.Append(" PRINT (@sql_str)                                                                                                    ");
            //strSql.Append(" EXEC (@sql_str)                                                                                                     ");

            //strSql.Append(" end ");
            //strSql.Append("go");
            return DbHelperMySQL.Query(strSql.ToString());
        }

        //电话年度统计
        public DataSet Phone_month(string items, int year,int month, string where)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("if OBJECT_ID('Tempdb..#t') is not null ");
            //strSql.Append("    drop TABLE  #t ");
            ////strSql.Append("go");
            //strSql.Append(" begin ");
            //strSql.Append("    --预统计表 #t");
            strSql.Append("   select " + items + " as items,");
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
            strSql.Append("        " + items + ",DAYOFMONTH(CallTime) dd,count(id)tNum  ");
            strSql.Append("    from HJ_Phone_Records ");
            strSql.Append("    where year(CallTime)='" + year + "' and month(CallTime)='" + month + "' ");
            //strSql.Append("    where timestampdiff(Month,CallTime,'" + year + "-"+month+"-1')=0");
            if (where.Trim() != "")
            {
                strSql.Append(" and " + where);
            }
            strSql.Append("    group by " + items + ",DAYOFMONTH(CallTime)) tt ");
            strSql.Append(" group by " + items + "  ");
            //strSql.Append("    --生成SQL");
            //strSql.Append("    declare @sql varchar(8000) ");
            //strSql.Append("    set @sql='select " + items + " items ' ");
            //strSql.Append("    select @sql = @sql + ',sum(case mm when ' + char(39) +mm+ char(39) + ' then tNum else 0 end) ['+ mm +']' ");
            //strSql.Append("        from (select distinct mm from #t)as data ");
            //strSql.Append("    set @sql = @sql + ' from #t group by " + items + "' ");

            //strSql.Append("    exec(@sql) ");
            //strSql.Append(" end ");
            //strSql.Append("go");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        //电话综合年统计
        public DataSet Phone_month(string items, int year, int month, string where, bool temp)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("if OBJECT_ID('Tempdb..#t') is not null ");
            //strSql.Append("    drop TABLE  #t ");
            ////strSql.Append("go");
            //strSql.Append(" begin ");
            //strSql.Append("    --预统计表 #t");
            strSql.Append("   select items,");
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
            strSql.Append("    ( select         DAYOFMONTH(CallTime) dd, ");
            strSql.Append("  case when CallType=0 and answered = 0 then 1 	");
            strSql.Append("  when CallType=0 and answered = 1 then 2		");
            strSql.Append("  when CallType=1 and answered = 0 then 3		");
            strSql.Append("  when CallType=1 and answered = 1 then 4		");
            strSql.Append("  else 0 end items,							");
            strSql.Append("  count(id)tNum 								");
            strSql.Append("    from HJ_Phone_Records ");
            strSql.Append("    where year(CallTime)='" + year + "' and month(CallTime)='" + month + "' ");
            //strSql.Append("    where timestampdiff(Month,CallTime,'" + year + "-" + month + "-1')=0");
            if (where.Trim() != "")
            {
                strSql.Append(" and " + where);
            }
            strSql.Append("    group by DAYOFMONTH(CallTime),CallType,answered) tt ");
            strSql.Append(" group by items ");
            //strSql.Append("    --生成SQL");
            //strSql.Append("    declare @sql varchar(8000) ");
            //strSql.Append("    set @sql='select " + items + " items ' ");
            //strSql.Append("    select @sql = @sql + ',sum(case mm when ' + char(39) +mm+ char(39) + ' then tNum else 0 end) ['+ mm +']' ");
            //strSql.Append("        from (select distinct mm from #t)as data ");
            //strSql.Append("    set @sql = @sql + ' from #t group by " + items + "' ");
            //strSql.Append("    exec(@sql) ");

            //新方法
            //strSql.Append(" DECLARE @sql_str VARCHAR(8000)                                                                                      ");
            //strSql.Append(" DECLARE @sql_col VARCHAR(8000)                                                                                      ");
            //strSql.Append(" SELECT @sql_col = ISNULL(@sql_col + ',','') + QUOTENAME([mm]) FROM [#t] GROUP BY [mm]       ");
            //strSql.Append(" SET @sql_str = '                                                                                                    ");
            //strSql.Append(" SELECT * FROM (                                                                                                     ");
            //strSql.Append("     SELECT [items],[mm],[tNum] FROM [#t]) p PIVOT                                           ");
            //strSql.Append("     (SUM([tNum]) FOR [mm] IN ( '+ @sql_col +') ) AS pvt                                                      ");
            //strSql.Append(" ORDER BY pvt.[items]'                                                                                            ");
            //strSql.Append(" PRINT (@sql_str)                                                                                                    ");
            //strSql.Append(" EXEC (@sql_str)                                                                                                     ");

            //strSql.Append(" end ");
            //strSql.Append("go");
            return DbHelperMySQL.Query(strSql.ToString());
        }
        

        #endregion  Method
    }
}
