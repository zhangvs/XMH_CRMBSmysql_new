using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:hr_employee_Arc
    /// </summary>
    public partial class hr_employee_Arc
    {
        public hr_employee_Arc()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from hr_employee_arc");
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
        public int Add(Model.hr_employee_ArcInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into hr_employee_arc(");
            strSql.Append("Factory_Id,Date_Entry,Date_Regular,Date_Leave,Date_Create,Create_Id,Create_Name,Leave_Reason_Id,Leave_Reason,Emp_Id,Emp_Name,Emp_No,Emp_Sex,Emp_IsMarried,Emp_Age,Emp_BirthDate,Emp_DepId,Emp_DepName,Emp_PostId,Emp_PostName,Emp_QQ,Emp_Phone,Emp_OfficeTel,Emp_Workplace,Emp_Identity,Emp_IdentityAddress,Emp_Address,Edu_Political,Edu_Degree,Edu_SchoolTag,Edu_Profession,Edu_GraduationDate,Edu_CertificateNo,Entry_Sub_Diploma,Entry_Sub_Identity,Entry_Sub_Photo,Entry_Sub_BankCardNo,Entry_Sub_POLICECHECK,Entry_Sub_HBVFive,Entry_Sub_Certificate,Entry_Sub_DrivingLicense,Entry_Salary_Pro,Entry_Salary_Regular,Entry_BankCardNo,Entry_BankCardName,Fam_Father,Fam_FatherDate,Fam_FatherTel,Fam_Mother,Fam_MotherDate,Fam_MotherTel,Fam_Partner,Fam_PartnerDate,Fam_PartnerTel,Fam_Other,Fam_OtherDate,Fam_OtherTel,InformationSource_Id,InformationSource)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@Date_Entry,@Date_Regular,@Date_Leave,@Date_Create,@Create_Id,@Create_Name,@Leave_Reason_Id,@Leave_Reason,@Emp_Id,@Emp_Name,@Emp_No,@Emp_Sex,@Emp_IsMarried,@Emp_Age,@Emp_BirthDate,@Emp_DepId,@Emp_DepName,@Emp_PostId,@Emp_PostName,@Emp_QQ,@Emp_Phone,@Emp_OfficeTel,@Emp_Workplace,@Emp_Identity,@Emp_IdentityAddress,@Emp_Address,@Edu_Political,@Edu_Degree,@Edu_SchoolTag,@Edu_Profession,@Edu_GraduationDate,@Edu_CertificateNo,@Entry_Sub_Diploma,@Entry_Sub_Identity,@Entry_Sub_Photo,@Entry_Sub_BankCardNo,@Entry_Sub_POLICECHECK,@Entry_Sub_HBVFive,@Entry_Sub_Certificate,@Entry_Sub_DrivingLicense,@Entry_Salary_Pro,@Entry_Salary_Regular,@Entry_BankCardNo,@Entry_BankCardName,@Fam_Father,@Fam_FatherDate,@Fam_FatherTel,@Fam_Mother,@Fam_MotherDate,@Fam_MotherTel,@Fam_Partner,@Fam_PartnerDate,@Fam_PartnerTel,@Fam_Other,@Fam_OtherDate,@Fam_OtherTel,@InformationSource_Id,@InformationSource)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Date_Entry", MySqlDbType.DateTime),
					new MySqlParameter("@Date_Regular", MySqlDbType.DateTime),
					new MySqlParameter("@Date_Leave", MySqlDbType.DateTime),
					new MySqlParameter("@Date_Create", MySqlDbType.DateTime),
					new MySqlParameter("@Create_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_Name", MySqlDbType.VarChar,20),
					new MySqlParameter("@Leave_Reason_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Leave_Reason", MySqlDbType.VarChar,50),
					new MySqlParameter("@Emp_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_Name", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_No", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_Sex", MySqlDbType.VarChar,4),
					new MySqlParameter("@Emp_IsMarried", MySqlDbType.VarChar,4),
					new MySqlParameter("@Emp_Age", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_BirthDate", MySqlDbType.DateTime),
					new MySqlParameter("@Emp_DepId", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_DepName", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_PostId", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_PostName", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_QQ", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_Phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_OfficeTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_Workplace", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_Identity", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_IdentityAddress", MySqlDbType.VarChar,50),
					new MySqlParameter("@Emp_Address", MySqlDbType.VarChar,50),
					new MySqlParameter("@Edu_Political", MySqlDbType.VarChar,20),
					new MySqlParameter("@Edu_Degree", MySqlDbType.VarChar,20),
					new MySqlParameter("@Edu_SchoolTag", MySqlDbType.VarChar,50),
					new MySqlParameter("@Edu_Profession", MySqlDbType.VarChar,50),
					new MySqlParameter("@Edu_GraduationDate", MySqlDbType.DateTime),
					new MySqlParameter("@Edu_CertificateNo", MySqlDbType.VarChar,50),
					new MySqlParameter("@Entry_Sub_Diploma", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_Identity", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_Photo", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_BankCardNo", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_POLICECHECK", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_HBVFive", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_Certificate", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_DrivingLicense", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Salary_Pro", MySqlDbType.Decimal,10),
					new MySqlParameter("@Entry_Salary_Regular", MySqlDbType.Decimal,10),
					new MySqlParameter("@Entry_BankCardNo", MySqlDbType.VarChar,20),
					new MySqlParameter("@Entry_BankCardName", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_Father", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_FatherDate", MySqlDbType.DateTime),
					new MySqlParameter("@Fam_FatherTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_Mother", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_MotherDate", MySqlDbType.DateTime),
					new MySqlParameter("@Fam_MotherTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_Partner", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_PartnerDate", MySqlDbType.DateTime),
					new MySqlParameter("@Fam_PartnerTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_Other", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_OtherDate", MySqlDbType.DateTime),
					new MySqlParameter("@Fam_OtherTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@InformationSource_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@InformationSource", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Date_Entry;
            parameters[2].Value = model.Date_Regular;
            parameters[3].Value = model.Date_Leave;
            parameters[4].Value = model.Date_Create;
            parameters[5].Value = model.Create_Id;
            parameters[6].Value = model.Create_Name;
            parameters[7].Value = model.Leave_Reason_Id;
            parameters[8].Value = model.Leave_Reason;
            parameters[9].Value = model.Emp_Id;
            parameters[10].Value = model.Emp_Name;
            parameters[11].Value = model.Emp_No;
            parameters[12].Value = model.Emp_Sex;
            parameters[13].Value = model.Emp_IsMarried;
            parameters[14].Value = model.Emp_Age;
            parameters[15].Value = model.Emp_BirthDate;
            parameters[16].Value = model.Emp_DepId;
            parameters[17].Value = model.Emp_DepName;
            parameters[18].Value = model.Emp_PostId;
            parameters[19].Value = model.Emp_PostName;
            parameters[20].Value = model.Emp_QQ;
            parameters[21].Value = model.Emp_Phone;
            parameters[22].Value = model.Emp_OfficeTel;
            parameters[23].Value = model.Emp_Workplace;
            parameters[24].Value = model.Emp_Identity;
            parameters[25].Value = model.Emp_IdentityAddress;
            parameters[26].Value = model.Emp_Address;
            parameters[27].Value = model.Edu_Political;
            parameters[28].Value = model.Edu_Degree;
            parameters[29].Value = model.Edu_SchoolTag;
            parameters[30].Value = model.Edu_Profession;
            parameters[31].Value = model.Edu_GraduationDate;
            parameters[32].Value = model.Edu_CertificateNo;
            parameters[33].Value = model.Entry_Sub_Diploma;
            parameters[34].Value = model.Entry_Sub_Identity;
            parameters[35].Value = model.Entry_Sub_Photo;
            parameters[36].Value = model.Entry_Sub_BankCardNo;
            parameters[37].Value = model.Entry_Sub_POLICECHECK;
            parameters[38].Value = model.Entry_Sub_HBVFive;
            parameters[39].Value = model.Entry_Sub_Certificate;
            parameters[40].Value = model.Entry_Sub_DrivingLicense;
            parameters[41].Value = model.Entry_Salary_Pro;
            parameters[42].Value = model.Entry_Salary_Regular;
            parameters[43].Value = model.Entry_BankCardNo;
            parameters[44].Value = model.Entry_BankCardName;
            parameters[45].Value = model.Fam_Father;
            parameters[46].Value = model.Fam_FatherDate;
            parameters[47].Value = model.Fam_FatherTel;
            parameters[48].Value = model.Fam_Mother;
            parameters[49].Value = model.Fam_MotherDate;
            parameters[50].Value = model.Fam_MotherTel;
            parameters[51].Value = model.Fam_Partner;
            parameters[52].Value = model.Fam_PartnerDate;
            parameters[53].Value = model.Fam_PartnerTel;
            parameters[54].Value = model.Fam_Other;
            parameters[55].Value = model.Fam_OtherDate;
            parameters[56].Value = model.Fam_OtherTel;
            parameters[57].Value = model.InformationSource_Id;
            parameters[58].Value = model.InformationSource;

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
        public bool Update(Model.hr_employee_ArcInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_employee_arc set ");
            strSql.Append("Factory_Id=@Factory_Id,");
            strSql.Append("Date_Entry=@Date_Entry,");
            strSql.Append("Date_Regular=@Date_Regular,");
            strSql.Append("Date_Leave=@Date_Leave,");
            strSql.Append("Date_Create=@Date_Create,");
            strSql.Append("Create_Id=@Create_Id,");
            strSql.Append("Create_Name=@Create_Name,");
            strSql.Append("Leave_Reason_Id=@Leave_Reason_Id,");
            strSql.Append("Leave_Reason=@Leave_Reason,");
            strSql.Append("Emp_Id=@Emp_Id,");
            strSql.Append("Emp_Name=@Emp_Name,");
            strSql.Append("Emp_No=@Emp_No,");
            strSql.Append("Emp_Sex=@Emp_Sex,");
            strSql.Append("Emp_IsMarried=@Emp_IsMarried,");
            strSql.Append("Emp_Age=@Emp_Age,");
            strSql.Append("Emp_BirthDate=@Emp_BirthDate,");
            strSql.Append("Emp_DepId=@Emp_DepId,");
            strSql.Append("Emp_DepName=@Emp_DepName,");
            strSql.Append("Emp_PostId=@Emp_PostId,");
            strSql.Append("Emp_PostName=@Emp_PostName,");
            strSql.Append("Emp_QQ=@Emp_QQ,");
            strSql.Append("Emp_Phone=@Emp_Phone,");
            strSql.Append("Emp_OfficeTel=@Emp_OfficeTel,");
            strSql.Append("Emp_Workplace=@Emp_Workplace,");
            strSql.Append("Emp_Identity=@Emp_Identity,");
            strSql.Append("Emp_IdentityAddress=@Emp_IdentityAddress,");
            strSql.Append("Emp_Address=@Emp_Address,");
            strSql.Append("Edu_Political=@Edu_Political,");
            strSql.Append("Edu_Degree=@Edu_Degree,");
            strSql.Append("Edu_SchoolTag=@Edu_SchoolTag,");
            strSql.Append("Edu_Profession=@Edu_Profession,");
            strSql.Append("Edu_GraduationDate=@Edu_GraduationDate,");
            strSql.Append("Edu_CertificateNo=@Edu_CertificateNo,");
            strSql.Append("Entry_Sub_Diploma=@Entry_Sub_Diploma,");
            strSql.Append("Entry_Sub_Identity=@Entry_Sub_Identity,");
            strSql.Append("Entry_Sub_Photo=@Entry_Sub_Photo,");
            strSql.Append("Entry_Sub_BankCardNo=@Entry_Sub_BankCardNo,");
            strSql.Append("Entry_Sub_POLICECHECK=@Entry_Sub_POLICECHECK,");
            strSql.Append("Entry_Sub_HBVFive=@Entry_Sub_HBVFive,");
            strSql.Append("Entry_Sub_Certificate=@Entry_Sub_Certificate,");
            strSql.Append("Entry_Sub_DrivingLicense=@Entry_Sub_DrivingLicense,");
            strSql.Append("Entry_Salary_Pro=@Entry_Salary_Pro,");
            strSql.Append("Entry_Salary_Regular=@Entry_Salary_Regular,");
            strSql.Append("Entry_BankCardNo=@Entry_BankCardNo,");
            strSql.Append("Entry_BankCardName=@Entry_BankCardName,");
            strSql.Append("Fam_Father=@Fam_Father,");
            strSql.Append("Fam_FatherDate=@Fam_FatherDate,");
            strSql.Append("Fam_FatherTel=@Fam_FatherTel,");
            strSql.Append("Fam_Mother=@Fam_Mother,");
            strSql.Append("Fam_MotherDate=@Fam_MotherDate,");
            strSql.Append("Fam_MotherTel=@Fam_MotherTel,");
            strSql.Append("Fam_Partner=@Fam_Partner,");
            strSql.Append("Fam_PartnerDate=@Fam_PartnerDate,");
            strSql.Append("Fam_PartnerTel=@Fam_PartnerTel,");
            strSql.Append("Fam_Other=@Fam_Other,");
            strSql.Append("Fam_OtherDate=@Fam_OtherDate,");
            strSql.Append("Fam_OtherTel=@Fam_OtherTel,");
            strSql.Append("InformationSource_Id=@InformationSource_Id,");
            strSql.Append("InformationSource=@InformationSource");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Factory_Id", MySqlDbType.VarChar,60),
					new MySqlParameter("@Date_Entry", MySqlDbType.DateTime),
					new MySqlParameter("@Date_Regular", MySqlDbType.DateTime),
					new MySqlParameter("@Date_Leave", MySqlDbType.DateTime),
					new MySqlParameter("@Date_Create", MySqlDbType.DateTime),
					new MySqlParameter("@Create_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Create_Name", MySqlDbType.VarChar,20),
					new MySqlParameter("@Leave_Reason_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Leave_Reason", MySqlDbType.VarChar,50),
					new MySqlParameter("@Emp_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_Name", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_No", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_Sex", MySqlDbType.VarChar,4),
					new MySqlParameter("@Emp_IsMarried", MySqlDbType.VarChar,4),
					new MySqlParameter("@Emp_Age", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_BirthDate", MySqlDbType.DateTime),
					new MySqlParameter("@Emp_DepId", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_DepName", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_PostId", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_PostName", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_QQ", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_Phone", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_OfficeTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_Workplace", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_Identity", MySqlDbType.VarChar,20),
					new MySqlParameter("@Emp_IdentityAddress", MySqlDbType.VarChar,50),
					new MySqlParameter("@Emp_Address", MySqlDbType.VarChar,50),
					new MySqlParameter("@Edu_Political", MySqlDbType.VarChar,20),
					new MySqlParameter("@Edu_Degree", MySqlDbType.VarChar,20),
					new MySqlParameter("@Edu_SchoolTag", MySqlDbType.VarChar,50),
					new MySqlParameter("@Edu_Profession", MySqlDbType.VarChar,50),
					new MySqlParameter("@Edu_GraduationDate", MySqlDbType.DateTime),
					new MySqlParameter("@Edu_CertificateNo", MySqlDbType.VarChar,50),
					new MySqlParameter("@Entry_Sub_Diploma", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_Identity", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_Photo", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_BankCardNo", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_POLICECHECK", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_HBVFive", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_Certificate", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Sub_DrivingLicense", MySqlDbType.VarChar,1),
					new MySqlParameter("@Entry_Salary_Pro", MySqlDbType.Decimal,10),
					new MySqlParameter("@Entry_Salary_Regular", MySqlDbType.Decimal,10),
					new MySqlParameter("@Entry_BankCardNo", MySqlDbType.VarChar,20),
					new MySqlParameter("@Entry_BankCardName", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_Father", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_FatherDate", MySqlDbType.DateTime),
					new MySqlParameter("@Fam_FatherTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_Mother", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_MotherDate", MySqlDbType.DateTime),
					new MySqlParameter("@Fam_MotherTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_Partner", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_PartnerDate", MySqlDbType.DateTime),
					new MySqlParameter("@Fam_PartnerTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_Other", MySqlDbType.VarChar,20),
					new MySqlParameter("@Fam_OtherDate", MySqlDbType.DateTime),
					new MySqlParameter("@Fam_OtherTel", MySqlDbType.VarChar,20),
					new MySqlParameter("@InformationSource_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@InformationSource", MySqlDbType.VarChar,50),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Date_Entry;
            parameters[2].Value = model.Date_Regular;
            parameters[3].Value = model.Date_Leave;
            parameters[4].Value = model.Date_Create;
            parameters[5].Value = model.Create_Id;
            parameters[6].Value = model.Create_Name;
            parameters[7].Value = model.Leave_Reason_Id;
            parameters[8].Value = model.Leave_Reason;
            parameters[9].Value = model.Emp_Id;
            parameters[10].Value = model.Emp_Name;
            parameters[11].Value = model.Emp_No;
            parameters[12].Value = model.Emp_Sex;
            parameters[13].Value = model.Emp_IsMarried;
            parameters[14].Value = model.Emp_Age;
            parameters[15].Value = model.Emp_BirthDate;
            parameters[16].Value = model.Emp_DepId;
            parameters[17].Value = model.Emp_DepName;
            parameters[18].Value = model.Emp_PostId;
            parameters[19].Value = model.Emp_PostName;
            parameters[20].Value = model.Emp_QQ;
            parameters[21].Value = model.Emp_Phone;
            parameters[22].Value = model.Emp_OfficeTel;
            parameters[23].Value = model.Emp_Workplace;
            parameters[24].Value = model.Emp_Identity;
            parameters[25].Value = model.Emp_IdentityAddress;
            parameters[26].Value = model.Emp_Address;
            parameters[27].Value = model.Edu_Political;
            parameters[28].Value = model.Edu_Degree;
            parameters[29].Value = model.Edu_SchoolTag;
            parameters[30].Value = model.Edu_Profession;
            parameters[31].Value = model.Edu_GraduationDate;
            parameters[32].Value = model.Edu_CertificateNo;
            parameters[33].Value = model.Entry_Sub_Diploma;
            parameters[34].Value = model.Entry_Sub_Identity;
            parameters[35].Value = model.Entry_Sub_Photo;
            parameters[36].Value = model.Entry_Sub_BankCardNo;
            parameters[37].Value = model.Entry_Sub_POLICECHECK;
            parameters[38].Value = model.Entry_Sub_HBVFive;
            parameters[39].Value = model.Entry_Sub_Certificate;
            parameters[40].Value = model.Entry_Sub_DrivingLicense;
            parameters[41].Value = model.Entry_Salary_Pro;
            parameters[42].Value = model.Entry_Salary_Regular;
            parameters[43].Value = model.Entry_BankCardNo;
            parameters[44].Value = model.Entry_BankCardName;
            parameters[45].Value = model.Fam_Father;
            parameters[46].Value = model.Fam_FatherDate;
            parameters[47].Value = model.Fam_FatherTel;
            parameters[48].Value = model.Fam_Mother;
            parameters[49].Value = model.Fam_MotherDate;
            parameters[50].Value = model.Fam_MotherTel;
            parameters[51].Value = model.Fam_Partner;
            parameters[52].Value = model.Fam_PartnerDate;
            parameters[53].Value = model.Fam_PartnerTel;
            parameters[54].Value = model.Fam_Other;
            parameters[55].Value = model.Fam_OtherDate;
            parameters[56].Value = model.Fam_OtherTel;
            parameters[57].Value = model.InformationSource_Id;
            parameters[58].Value = model.InformationSource;
            parameters[59].Value = model.id;

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
            strSql.Append("delete from hr_employee_arc ");
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
            strSql.Append("delete from hr_employee_arc ");
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
        public Model.hr_employee_ArcInfo GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Factory_Id,Date_Entry,Date_Regular,Date_Leave,Date_Create,Create_Id,Create_Name,Leave_Reason_Id,Leave_Reason,Emp_Id,Emp_Name,Emp_No,Emp_Sex,Emp_IsMarried,Emp_Age,Emp_BirthDate,Emp_DepId,Emp_DepName,Emp_PostId,Emp_PostName,Emp_QQ,Emp_Phone,Emp_OfficeTel,Emp_Workplace,Emp_Identity,Emp_IdentityAddress,Emp_Address,Edu_Political,Edu_Degree,Edu_SchoolTag,Edu_Profession,Edu_GraduationDate,Edu_CertificateNo,Entry_Sub_Diploma,Entry_Sub_Identity,Entry_Sub_Photo,Entry_Sub_BankCardNo,Entry_Sub_POLICECHECK,Entry_Sub_HBVFive,Entry_Sub_Certificate,Entry_Sub_DrivingLicense,Entry_Salary_Pro,Entry_Salary_Regular,Entry_BankCardNo,Entry_BankCardName,Fam_Father,Fam_FatherDate,Fam_FatherTel,Fam_Mother,Fam_MotherDate,Fam_MotherTel,Fam_Partner,Fam_PartnerDate,Fam_PartnerTel,Fam_Other,Fam_OtherDate,Fam_OtherTel,InformationSource_Id,InformationSource from hr_employee_arc ");
            strSql.Append(" where id=@id");
            MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
            parameters[0].Value = id;

            Model.hr_employee_ArcInfo model = new Model.hr_employee_ArcInfo();
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
        public Model.hr_employee_ArcInfo DataRowToModel(DataRow row)
        {
            Model.hr_employee_ArcInfo model = new Model.hr_employee_ArcInfo();
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
                if (row["Date_Entry"] != null && row["Date_Entry"].ToString() != "")
                {
                    model.Date_Entry = DateTime.Parse(row["Date_Entry"].ToString());
                }
                if (row["Date_Regular"] != null && row["Date_Regular"].ToString() != "")
                {
                    model.Date_Regular = DateTime.Parse(row["Date_Regular"].ToString());
                }
                if (row["Date_Leave"] != null && row["Date_Leave"].ToString() != "")
                {
                    model.Date_Leave = DateTime.Parse(row["Date_Leave"].ToString());
                }
                if (row["Date_Create"] != null && row["Date_Create"].ToString() != "")
                {
                    model.Date_Create = DateTime.Parse(row["Date_Create"].ToString());
                }
                if (row["Create_Id"] != null && row["Create_Id"].ToString() != "")
                {
                    model.Create_Id = int.Parse(row["Create_Id"].ToString());
                }
                if (row["Create_Name"] != null)
                {
                    model.Create_Name = row["Create_Name"].ToString();
                }
                if (row["Leave_Reason_Id"] != null && row["Leave_Reason_Id"].ToString() != "")
                {
                    model.Leave_Reason_Id = int.Parse(row["Leave_Reason_Id"].ToString());
                }
                if (row["Leave_Reason"] != null)
                {
                    model.Leave_Reason = row["Leave_Reason"].ToString();
                }
                if (row["Emp_Id"] != null && row["Emp_Id"].ToString() != "")
                {
                    model.Emp_Id = int.Parse(row["Emp_Id"].ToString());
                }
                if (row["Emp_Name"] != null)
                {
                    model.Emp_Name = row["Emp_Name"].ToString();
                }
                if (row["Emp_No"] != null)
                {
                    model.Emp_No = row["Emp_No"].ToString();
                }
                if (row["Emp_Sex"] != null)
                {
                    model.Emp_Sex = row["Emp_Sex"].ToString();
                }
                if (row["Emp_IsMarried"] != null)
                {
                    model.Emp_IsMarried = row["Emp_IsMarried"].ToString();
                }
                if (row["Emp_Age"] != null && row["Emp_Age"].ToString() != "")
                {
                    model.Emp_Age = int.Parse(row["Emp_Age"].ToString());
                }
                if (row["Emp_BirthDate"] != null && row["Emp_BirthDate"].ToString() != "")
                {
                    model.Emp_BirthDate = DateTime.Parse(row["Emp_BirthDate"].ToString());
                }
                if (row["Emp_DepId"] != null && row["Emp_DepId"].ToString() != "")
                {
                    model.Emp_DepId = int.Parse(row["Emp_DepId"].ToString());
                }
                if (row["Emp_DepName"] != null)
                {
                    model.Emp_DepName = row["Emp_DepName"].ToString();
                }
                if (row["Emp_PostId"] != null && row["Emp_PostId"].ToString() != "")
                {
                    model.Emp_PostId = int.Parse(row["Emp_PostId"].ToString());
                }
                if (row["Emp_PostName"] != null)
                {
                    model.Emp_PostName = row["Emp_PostName"].ToString();
                }
                if (row["Emp_QQ"] != null)
                {
                    model.Emp_QQ = row["Emp_QQ"].ToString();
                }
                if (row["Emp_Phone"] != null)
                {
                    model.Emp_Phone = row["Emp_Phone"].ToString();
                }
                if (row["Emp_OfficeTel"] != null)
                {
                    model.Emp_OfficeTel = row["Emp_OfficeTel"].ToString();
                }
                if (row["Emp_Workplace"] != null)
                {
                    model.Emp_Workplace = row["Emp_Workplace"].ToString();
                }
                if (row["Emp_Identity"] != null)
                {
                    model.Emp_Identity = row["Emp_Identity"].ToString();
                }
                if (row["Emp_IdentityAddress"] != null)
                {
                    model.Emp_IdentityAddress = row["Emp_IdentityAddress"].ToString();
                }
                if (row["Emp_Address"] != null)
                {
                    model.Emp_Address = row["Emp_Address"].ToString();
                }
                if (row["Edu_Political"] != null)
                {
                    model.Edu_Political = row["Edu_Political"].ToString();
                }
                if (row["Edu_Degree"] != null)
                {
                    model.Edu_Degree = row["Edu_Degree"].ToString();
                }
                if (row["Edu_SchoolTag"] != null)
                {
                    model.Edu_SchoolTag = row["Edu_SchoolTag"].ToString();
                }
                if (row["Edu_Profession"] != null)
                {
                    model.Edu_Profession = row["Edu_Profession"].ToString();
                }
                if (row["Edu_GraduationDate"] != null && row["Edu_GraduationDate"].ToString() != "")
                {
                    model.Edu_GraduationDate = DateTime.Parse(row["Edu_GraduationDate"].ToString());
                }
                if (row["Edu_CertificateNo"] != null)
                {
                    model.Edu_CertificateNo = row["Edu_CertificateNo"].ToString();
                }
                if (row["Entry_Sub_Diploma"] != null)
                {
                    model.Entry_Sub_Diploma = row["Entry_Sub_Diploma"].ToString();
                }
                if (row["Entry_Sub_Identity"] != null)
                {
                    model.Entry_Sub_Identity = row["Entry_Sub_Identity"].ToString();
                }
                if (row["Entry_Sub_Photo"] != null)
                {
                    model.Entry_Sub_Photo = row["Entry_Sub_Photo"].ToString();
                }
                if (row["Entry_Sub_BankCardNo"] != null)
                {
                    model.Entry_Sub_BankCardNo = row["Entry_Sub_BankCardNo"].ToString();
                }
                if (row["Entry_Sub_POLICECHECK"] != null)
                {
                    model.Entry_Sub_POLICECHECK = row["Entry_Sub_POLICECHECK"].ToString();
                }
                if (row["Entry_Sub_HBVFive"] != null)
                {
                    model.Entry_Sub_HBVFive = row["Entry_Sub_HBVFive"].ToString();
                }
                if (row["Entry_Sub_Certificate"] != null)
                {
                    model.Entry_Sub_Certificate = row["Entry_Sub_Certificate"].ToString();
                }
                if (row["Entry_Sub_DrivingLicense"] != null)
                {
                    model.Entry_Sub_DrivingLicense = row["Entry_Sub_DrivingLicense"].ToString();
                }
                if (row["Entry_Salary_Pro"] != null && row["Entry_Salary_Pro"].ToString() != "")
                {
                    model.Entry_Salary_Pro = decimal.Parse(row["Entry_Salary_Pro"].ToString());
                }
                if (row["Entry_Salary_Regular"] != null && row["Entry_Salary_Regular"].ToString() != "")
                {
                    model.Entry_Salary_Regular = decimal.Parse(row["Entry_Salary_Regular"].ToString());
                }
                if (row["Entry_BankCardNo"] != null)
                {
                    model.Entry_BankCardNo = row["Entry_BankCardNo"].ToString();
                }
                if (row["Entry_BankCardName"] != null)
                {
                    model.Entry_BankCardName = row["Entry_BankCardName"].ToString();
                }
                if (row["Fam_Father"] != null)
                {
                    model.Fam_Father = row["Fam_Father"].ToString();
                }
                if (row["Fam_FatherDate"] != null && row["Fam_FatherDate"].ToString() != "")
                {
                    model.Fam_FatherDate = DateTime.Parse(row["Fam_FatherDate"].ToString());
                }
                if (row["Fam_FatherTel"] != null)
                {
                    model.Fam_FatherTel = row["Fam_FatherTel"].ToString();
                }
                if (row["Fam_Mother"] != null)
                {
                    model.Fam_Mother = row["Fam_Mother"].ToString();
                }
                if (row["Fam_MotherDate"] != null && row["Fam_MotherDate"].ToString() != "")
                {
                    model.Fam_MotherDate = DateTime.Parse(row["Fam_MotherDate"].ToString());
                }
                if (row["Fam_MotherTel"] != null)
                {
                    model.Fam_MotherTel = row["Fam_MotherTel"].ToString();
                }
                if (row["Fam_Partner"] != null)
                {
                    model.Fam_Partner = row["Fam_Partner"].ToString();
                }
                if (row["Fam_PartnerDate"] != null && row["Fam_PartnerDate"].ToString() != "")
                {
                    model.Fam_PartnerDate = DateTime.Parse(row["Fam_PartnerDate"].ToString());
                }
                if (row["Fam_PartnerTel"] != null)
                {
                    model.Fam_PartnerTel = row["Fam_PartnerTel"].ToString();
                }
                if (row["Fam_Other"] != null)
                {
                    model.Fam_Other = row["Fam_Other"].ToString();
                }
                if (row["Fam_OtherDate"] != null && row["Fam_OtherDate"].ToString() != "")
                {
                    model.Fam_OtherDate = DateTime.Parse(row["Fam_OtherDate"].ToString());
                }
                if (row["Fam_OtherTel"] != null)
                {
                    model.Fam_OtherTel = row["Fam_OtherTel"].ToString();
                }
                if (row["InformationSource_Id"] != null && row["InformationSource_Id"].ToString() != "")
                {
                    model.InformationSource_Id = int.Parse(row["InformationSource_Id"].ToString());
                }
                if (row["InformationSource"] != null)
                {
                    model.InformationSource = row["InformationSource"].ToString();
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
            strSql.Append("select id,Factory_Id,Date_Entry,Date_Regular,Date_Leave,Date_Create,Create_Id,Create_Name,Leave_Reason_Id,Leave_Reason,Emp_Id,Emp_Name,Emp_No,Emp_Sex,Emp_IsMarried,Emp_Age,Emp_BirthDate,Emp_DepId,Emp_DepName,Emp_PostId,Emp_PostName,Emp_QQ,Emp_Phone,Emp_OfficeTel,Emp_Workplace,Emp_Identity,Emp_IdentityAddress,Emp_Address,Edu_Political,Edu_Degree,Edu_SchoolTag,Edu_Profession,Edu_GraduationDate,Edu_CertificateNo,Entry_Sub_Diploma,Entry_Sub_Identity,Entry_Sub_Photo,Entry_Sub_BankCardNo,Entry_Sub_POLICECHECK,Entry_Sub_HBVFive,Entry_Sub_Certificate,Entry_Sub_DrivingLicense,Entry_Salary_Pro,Entry_Salary_Regular,Entry_BankCardNo,Entry_BankCardName,Fam_Father,Fam_FatherDate,Fam_FatherTel,Fam_Mother,Fam_MotherDate,Fam_MotherTel,Fam_Partner,Fam_PartnerDate,Fam_PartnerTel,Fam_Other,Fam_OtherDate,Fam_OtherTel,InformationSource_Id,InformationSource ");
            strSql.Append(" FROM hr_employee_Arc ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            //strSql.Append("select ");
            strSql.Append("Select * FROM hr_employee_Arc ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM hr_employee_Arc ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM hr_employee_Arc ");
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
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");

            strSql.Append(" id,Factory_Id,Date_Entry,Date_Regular,Date_Leave,Date_Create,Create_Id,Create_Name,Leave_Reason_Id,Leave_Reason,Emp_Id,Emp_Name,Emp_No,Emp_Sex,Emp_IsMarried,Emp_Age,Emp_BirthDate,Emp_DepId,Emp_DepName,Emp_PostId,Emp_PostName,Emp_QQ,Emp_Phone,Emp_OfficeTel,Emp_Workplace,Emp_Identity,Emp_IdentityAddress,Emp_Address,Edu_Political,Edu_Degree,Edu_SchoolTag,Edu_Profession,Edu_GraduationDate,Edu_CertificateNo,Entry_Sub_Diploma,Entry_Sub_Identity,Entry_Sub_Photo,Entry_Sub_BankCardNo,Entry_Sub_POLICECHECK,Entry_Sub_HBVFive,Entry_Sub_Certificate,Entry_Sub_DrivingLicense,Entry_Salary_Pro,Entry_Salary_Regular,Entry_BankCardNo,Entry_BankCardName,Fam_Father,Fam_FatherDate,Fam_FatherTel,Fam_Mother,Fam_MotherDate,Fam_MotherTel,Fam_Partner,Fam_PartnerDate,Fam_PartnerTel,Fam_Other,Fam_OtherDate,Fam_OtherTel,InformationSource_Id,InformationSource ");
            strSql.Append(" FROM hr_employee_Arc ");
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
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM hr_employee_arc ");
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
            strSql.Append(")AS Row, T.*  from hr_employee_Arc T ");
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
        /// 分页获取数据列表
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
            parameters[0].Value = "hr_employee_arc";
            parameters[1].Value = "id";
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

