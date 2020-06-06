/**  版本信息模板在安装目录下，可自行修改。
* hr_Wage_Info.cs
*
* 功 能： N/A
* 类 名： hr_Wage_Info
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/10/7 13:02:46   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XHD.DBUtility;
using MySql.Data.MySqlClient;//Please add references
namespace XHD.DAL
{
    /// <summary>
    /// 数据访问类:hr_Wage_Info
    /// </summary>
    public partial class hr_Wage_Info
    {
        public hr_Wage_Info()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperMySQL.GetMaxID("ID", "hr_Wage_Info");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from hr_Wage_Info");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,11)};
            parameters[0].Value = ID;

            return DbHelperMySQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(XHD.Model.hr_Wage_Info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into hr_Wage_Info(");
            strSql.Append("Factory_Id,Emp_Id,Emp_Name,Emp_Dept_Id,Wage_Month,Wage_RunDay,Wage_Base,Wage_Miss,Wage_Full,Wage_Late,Wage_RunNo_Debit,Wage_Real,Wage_Base_Actual,Wage_JiXiao,Wage_Bonus,Wage_Work_Years,Wage_Grant_Phone,Wage_Grant_Othe,Wage_Total_Should,Wage_Debit_Meals,Wage_Debit_Social,Wage_Debit_Othe,Wage_Debit_Total,Emp_Score,Wage_Score,Wage_Total_All,Wage_Remark,Wage_Date,Creat_Date,Creat_UserID,Creat_UserName,Date_Emp)");
            strSql.Append(" values (");
            strSql.Append("@Factory_Id,@Emp_Id,@Emp_Name,@Emp_Dept_Id,@Wage_Month,@Wage_RunDay,@Wage_Base,@Wage_Miss,@Wage_Full,@Wage_Late,@Wage_RunNo_Debit,@Wage_Real,@Wage_Base_Actual,@Wage_JiXiao,@Wage_Bonus,@Wage_Work_Years,@Wage_Grant_Phone,@Wage_Grant_Othe,@Wage_Total_Should,@Wage_Debit_Meals,@Wage_Debit_Social,@Wage_Debit_Othe,@Wage_Debit_Total,@Emp_Score,@Wage_Score,@Wage_Total_All,@Wage_Remark,@Wage_Date,@Creat_Date,@Creat_UserID,@Creat_UserName,@Date_Emp)");
            strSql.Append(";select @@IDENTITY");
            MySqlParameter[] parameters = {
                    new MySqlParameter("@Factory_Id",MySqlDbType.VarChar,60),
					new MySqlParameter("@Emp_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_Name", MySqlDbType.VarChar,50),
					new MySqlParameter("@Emp_Dept_Id", MySqlDbType.Int32,11),
				    new MySqlParameter("@Wage_Month", MySqlDbType.Int16,6),
					new MySqlParameter("@Wage_RunDay", MySqlDbType.Double),
					new MySqlParameter("@Wage_Base", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Miss", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Full", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Late", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_RunNo_Debit", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Real", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Base_Actual", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_JiXiao", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Work_Years", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Grant_Phone", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Grant_Othe", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Total_Should", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Debit_Meals", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Debit_Social", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Debit_Othe", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Debit_Total", MySqlDbType.Decimal,18),
					new MySqlParameter("@Emp_Score", MySqlDbType.Int32,11),
					new MySqlParameter("@Wage_Score", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Total_All", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Remark", MySqlDbType.Text),
					new MySqlParameter("@Wage_Date", MySqlDbType.VarChar,50),
					new MySqlParameter("@Creat_Date", MySqlDbType.VarChar,50),
					new MySqlParameter("@Creat_UserID", MySqlDbType.VarChar,10),
					new MySqlParameter("@Creat_UserName", MySqlDbType.VarChar,10),
                    new MySqlParameter("@Date_Emp", MySqlDbType.VarChar,20)};
            parameters[0].Value = model.Factory_Id;
            parameters[1].Value = model.Emp_Id;
            parameters[2].Value = model.Emp_Name;
            parameters[3].Value = model.Emp_Dept_Id;
            parameters[4].Value = model.Wage_Month;
            parameters[5].Value = model.Wage_RunDay;
            parameters[6].Value = model.Wage_Base;
            parameters[7].Value = model.Wage_Miss;
            parameters[8].Value = model.Wage_Full;
            parameters[9].Value = model.Wage_Late;
            parameters[10].Value = model.Wage_RunNo_Debit;
            parameters[11].Value = model.Wage_Real;
            parameters[12].Value = model.Wage_Base_Actual;
            parameters[13].Value = model.Wage_JiXiao;
            parameters[14].Value = model.Wage_Bonus;
            parameters[15].Value = model.Wage_Work_Years;
            parameters[16].Value = model.Wage_Grant_Phone;
            parameters[17].Value = model.Wage_Grant_Othe;
            parameters[18].Value = model.Wage_Total_Should;
            parameters[19].Value = model.Wage_Debit_Meals;
            parameters[20].Value = model.Wage_Debit_Social;
            parameters[21].Value = model.Wage_Debit_Othe;
            parameters[22].Value = model.Wage_Debit_Total;
            parameters[23].Value = model.Emp_Score;
            parameters[24].Value = model.Wage_Score;
            parameters[25].Value = model.Wage_Total_All;
            parameters[26].Value = model.Wage_Remark;
            parameters[27].Value = model.Wage_Date;
            parameters[28].Value = model.Creat_Date;
            parameters[29].Value = model.Creat_UserID;
            parameters[30].Value = model.Creat_UserName;
            parameters[31].Value = model.Date_Emp;

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
        public bool Update(XHD.Model.hr_Wage_Info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update hr_Wage_Info set ");
            strSql.Append("Emp_Id=@Emp_Id,");
            strSql.Append("Emp_Name=@Emp_Name,");
            strSql.Append("Emp_Dept_Id=@Emp_Dept_Id,");
            strSql.Append("Wage_Month=@Wage_Month,");
            strSql.Append("Wage_RunDay=@Wage_RunDay,");
            strSql.Append("Wage_Base=@Wage_Base,");
            strSql.Append("Wage_Miss=@Wage_Miss,");
            strSql.Append("Wage_Full=@Wage_Full,");
            strSql.Append("Wage_Late=@Wage_Late,");
            strSql.Append("Wage_RunNo_Debit=@Wage_RunNo_Debit,");
            strSql.Append("Wage_Real=@Wage_Real,");
            strSql.Append("Wage_Base_Actual=@Wage_Base_Actual,");
            strSql.Append("Wage_JiXiao=@Wage_JiXiao,");
            strSql.Append("Wage_Bonus=@Wage_Bonus,");
            strSql.Append("Wage_Work_Years=@Wage_Work_Years,");
            strSql.Append("Wage_Grant_Phone=@Wage_Grant_Phone,");
            strSql.Append("Wage_Grant_Othe=@Wage_Grant_Othe,");
            strSql.Append("Wage_Total_Should=@Wage_Total_Should,");
            strSql.Append("Wage_Debit_Meals=@Wage_Debit_Meals,");
            strSql.Append("Wage_Debit_Social=@Wage_Debit_Social,");
            strSql.Append("Wage_Debit_Othe=@Wage_Debit_Othe,");
            strSql.Append("Wage_Debit_Total=@Wage_Debit_Total,");
            strSql.Append("Emp_Score=@Emp_Score,");
            strSql.Append("Wage_Score=@Wage_Score,");
            strSql.Append("Wage_Total_All=@Wage_Total_All,");
            strSql.Append("Wage_Remark=@Wage_Remark,");
            strSql.Append("Wage_Date=@Wage_Date,");
            strSql.Append("Creat_Date=@Creat_Date,");
            strSql.Append("Creat_UserID=@Creat_UserID,");
            strSql.Append("Creat_UserName=@Creat_UserName");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@Emp_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Emp_Name", MySqlDbType.VarChar,50),
					new MySqlParameter("@Emp_Dept_Id", MySqlDbType.Int32,11),
					new MySqlParameter("@Wage_Month", MySqlDbType.Int16,6),
					new MySqlParameter("@Wage_RunDay", MySqlDbType.Double),
					new MySqlParameter("@Wage_Base", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Miss", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Full", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Late", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_RunNo_Debit", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Real", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Base_Actual", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_JiXiao", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Bonus", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Work_Years", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Grant_Phone", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Grant_Othe", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Total_Should", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Debit_Meals", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Debit_Social", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Debit_Othe", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Debit_Total", MySqlDbType.Decimal,18),
					new MySqlParameter("@Emp_Score", MySqlDbType.Int32,11),
					new MySqlParameter("@Wage_Score", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Total_All", MySqlDbType.Decimal,18),
					new MySqlParameter("@Wage_Remark", MySqlDbType.Text),
					new MySqlParameter("@Wage_Date", MySqlDbType.VarChar,50),
					new MySqlParameter("@Creat_Date", MySqlDbType.VarChar,50),
					new MySqlParameter("@Creat_UserID", MySqlDbType.VarChar,10),
					new MySqlParameter("@Creat_UserName", MySqlDbType.VarChar,10),
					new MySqlParameter("@ID", MySqlDbType.Int32,11)};
            parameters[0].Value = model.Emp_Id;
            parameters[1].Value = model.Emp_Name;
            parameters[2].Value = model.Emp_Dept_Id;
            parameters[3].Value = model.Wage_Month;
            parameters[4].Value = model.Wage_RunDay;
            parameters[5].Value = model.Wage_Base;
            parameters[6].Value = model.Wage_Miss;
            parameters[7].Value = model.Wage_Full;
            parameters[8].Value = model.Wage_Late;
            parameters[9].Value = model.Wage_RunNo_Debit;
            parameters[10].Value = model.Wage_Real;
            parameters[11].Value = model.Wage_Base_Actual;
            parameters[12].Value = model.Wage_JiXiao;
            parameters[13].Value = model.Wage_Bonus;
            parameters[14].Value = model.Wage_Work_Years;
            parameters[15].Value = model.Wage_Grant_Phone;
            parameters[16].Value = model.Wage_Grant_Othe;
            parameters[17].Value = model.Wage_Total_Should;
            parameters[18].Value = model.Wage_Debit_Meals;
            parameters[19].Value = model.Wage_Debit_Social;
            parameters[20].Value = model.Wage_Debit_Othe;
            parameters[21].Value = model.Wage_Debit_Total;
            parameters[22].Value = model.Emp_Score;
            parameters[23].Value = model.Wage_Score;
            parameters[24].Value = model.Wage_Total_All;
            parameters[25].Value = model.Wage_Remark;
            parameters[26].Value = model.Wage_Date;
            parameters[27].Value = model.Creat_Date;
            parameters[28].Value = model.Creat_UserID;
            parameters[29].Value = model.Creat_UserName;
            parameters[30].Value = model.ID;

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
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from hr_Wage_Info ");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,11)			};
            parameters[0].Value = ID;

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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from hr_Wage_Info ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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
        public XHD.Model.hr_Wage_Info GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Factory_Id,Emp_Id,Emp_Name,Emp_Dept_Id,Date_Emp,Wage_Month,Wage_RunDay,Wage_Base,Wage_Miss,Wage_Full,Wage_Late,Wage_RunNo_Debit,Wage_Real,Wage_Base_Actual,Wage_JiXiao,Wage_Bonus,Wage_Work_Years,Wage_Grant_Phone,Wage_Grant_Othe,Wage_Total_Should,Wage_Debit_Meals,Wage_Debit_Social,Wage_Debit_Othe,Wage_Debit_Total,Emp_Score,Wage_Score,Wage_Total_All,Wage_Remark,Wage_Date,Creat_Date,Creat_UserID,Creat_UserName from hr_Wage_Info limit 1");
            strSql.Append(" where ID=@ID");
            MySqlParameter[] parameters = {
					new MySqlParameter("@ID", MySqlDbType.Int32,11)			};
            parameters[0].Value = ID;

            XHD.Model.hr_Wage_Info model = new XHD.Model.hr_Wage_Info();
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
        public XHD.Model.hr_Wage_Info DataRowToModel(DataRow row)
        {
            XHD.Model.hr_Wage_Info model = new XHD.Model.hr_Wage_Info();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Emp_Id"] != null && row["Emp_Id"].ToString() != "")
                {
                    model.Emp_Id = int.Parse(row["Emp_Id"].ToString());
                }
                if (row["Emp_Name"] != null)
                {
                    model.Emp_Name = row["Emp_Name"].ToString();
                }
                if (row["Emp_Dept_Id"] != null && row["Emp_Dept_Id"].ToString() != "")
                {
                    model.Emp_Dept_Id = int.Parse(row["Emp_Dept_Id"].ToString());
                }
                if (row["Wage_Month"] != null && row["Wage_Month"].ToString() != "")
                {
                    model.Wage_Month = int.Parse(row["Wage_Month"].ToString());
                }
                if (row["Wage_RunDay"] != null && row["Wage_RunDay"].ToString() != "")
                {
                    model.Wage_RunDay = decimal.Parse(row["Wage_RunDay"].ToString());
                }
                if (row["Wage_Base"] != null && row["Wage_Base"].ToString() != "")
                {
                    model.Wage_Base = decimal.Parse(row["Wage_Base"].ToString());
                }
                if (row["Wage_Miss"] != null && row["Wage_Miss"].ToString() != "")
                {
                    model.Wage_Miss = decimal.Parse(row["Wage_Miss"].ToString());
                }
                if (row["Wage_Full"] != null && row["Wage_Full"].ToString() != "")
                {
                    model.Wage_Full = decimal.Parse(row["Wage_Full"].ToString());
                }
                if (row["Wage_Late"] != null && row["Wage_Late"].ToString() != "")
                {
                    model.Wage_Late = decimal.Parse(row["Wage_Late"].ToString());
                }
                if (row["Wage_RunNo_Debit"] != null && row["Wage_RunNo_Debit"].ToString() != "")
                {
                    model.Wage_RunNo_Debit = decimal.Parse(row["Wage_RunNo_Debit"].ToString());
                }
                if (row["Wage_Real"] != null && row["Wage_Real"].ToString() != "")
                {
                    model.Wage_Real = decimal.Parse(row["Wage_Real"].ToString());
                }
                if (row["Wage_Base_Actual"] != null && row["Wage_Base_Actual"].ToString() != "")
                {
                    model.Wage_Base_Actual = decimal.Parse(row["Wage_Base_Actual"].ToString());
                }
                if (row["Wage_JiXiao"] != null && row["Wage_JiXiao"].ToString() != "")
                {
                    model.Wage_JiXiao = decimal.Parse(row["Wage_JiXiao"].ToString());
                }
                if (row["Wage_Bonus"] != null && row["Wage_Bonus"].ToString() != "")
                {
                    model.Wage_Bonus = decimal.Parse(row["Wage_Bonus"].ToString());
                }
                if (row["Wage_Work_Years"] != null && row["Wage_Work_Years"].ToString() != "")
                {
                    model.Wage_Work_Years = decimal.Parse(row["Wage_Work_Years"].ToString());
                }
                if (row["Wage_Grant_Phone"] != null && row["Wage_Grant_Phone"].ToString() != "")
                {
                    model.Wage_Grant_Phone = decimal.Parse(row["Wage_Grant_Phone"].ToString());
                }
                if (row["Wage_Grant_Othe"] != null && row["Wage_Grant_Othe"].ToString() != "")
                {
                    model.Wage_Grant_Othe = decimal.Parse(row["Wage_Grant_Othe"].ToString());
                }
                if (row["Wage_Total_Should"] != null && row["Wage_Total_Should"].ToString() != "")
                {
                    model.Wage_Total_Should = decimal.Parse(row["Wage_Total_Should"].ToString());
                }
                if (row["Wage_Debit_Meals"] != null && row["Wage_Debit_Meals"].ToString() != "")
                {
                    model.Wage_Debit_Meals = decimal.Parse(row["Wage_Debit_Meals"].ToString());
                }
                if (row["Wage_Debit_Social"] != null && row["Wage_Debit_Social"].ToString() != "")
                {
                    model.Wage_Debit_Social = decimal.Parse(row["Wage_Debit_Social"].ToString());
                }
                if (row["Wage_Debit_Othe"] != null && row["Wage_Debit_Othe"].ToString() != "")
                {
                    model.Wage_Debit_Othe = decimal.Parse(row["Wage_Debit_Othe"].ToString());
                }
                if (row["Wage_Debit_Total"] != null && row["Wage_Debit_Total"].ToString() != "")
                {
                    model.Wage_Debit_Total = decimal.Parse(row["Wage_Debit_Total"].ToString());
                }
                if (row["Emp_Score"] != null && row["Emp_Score"].ToString() != "")
                {
                    model.Emp_Score = int.Parse(row["Emp_Score"].ToString());
                }
                if (row["Wage_Score"] != null && row["Wage_Score"].ToString() != "")
                {
                    model.Wage_Score = decimal.Parse(row["Wage_Score"].ToString());
                }
                if (row["Wage_Total_All"] != null && row["Wage_Total_All"].ToString() != "")
                {
                    model.Wage_Total_All = decimal.Parse(row["Wage_Total_All"].ToString());
                }
                if (row["Wage_Remark"] != null)
                {
                    model.Wage_Remark = row["Wage_Remark"].ToString();
                }
                if (row["Wage_Date"] != null)
                {
                    model.Wage_Date = row["Wage_Date"].ToString();
                }
                if (row["Creat_Date"] != null)
                {
                    model.Creat_Date = row["Creat_Date"].ToString();
                }
                if (row["Creat_UserID"] != null)
                {
                    model.Creat_UserID = row["Creat_UserID"].ToString();
                }
                if (row["Creat_UserName"] != null)
                {
                    model.Creat_UserName = row["Creat_UserName"].ToString();
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
            strSql.Append("select ID,Factory_Id,Emp_Id,Emp_Name,Emp_Dept_Id,Date_Emp,Wage_Month,Wage_RunDay,Wage_Base,Wage_Miss,Wage_Full,Wage_Late,Wage_RunNo_Debit,Wage_Real,Wage_Base_Actual,Wage_JiXiao,Wage_Bonus,Wage_Work_Years,Wage_Grant_Phone,Wage_Grant_Othe,Wage_Total_Should,Wage_Debit_Meals,Wage_Debit_Social,Wage_Debit_Othe,Wage_Debit_Total,Emp_Score,Wage_Score,Wage_Total_All,Wage_Remark,Wage_Date,Creat_Date,Creat_UserID,Creat_UserName ");
            strSql.Append(" FROM hr_Wage_Info ");
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

            strSql.Append(" ID,Factory_Id,Emp_Id,Emp_Name,Emp_Dept_Id,Date_Emp,Wage_Month,Wage_RunDay,Wage_Base,Wage_Miss,Wage_Full,Wage_Late,Wage_RunNo_Debit,Wage_Real,Wage_Base_Actual,Wage_JiXiao,Wage_Bonus,Wage_Work_Years,Wage_Grant_Phone,Wage_Grant_Othe,Wage_Total_Should,Wage_Debit_Meals,Wage_Debit_Social,Wage_Debit_Othe,Wage_Debit_Total,Emp_Score,Wage_Score,Wage_Total_All,Wage_Remark,Wage_Date,Creat_Date,Creat_UserID,Creat_UserName ");
            strSql.Append(" FROM hr_Wage_Info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM hr_Wage_Info ");
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
        public DataSet GetList(int PageSize, int PageIndex, string strWhere, string filedOrder, out string Total)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql.Append("select ");
            strSql.Append("  * FROM hr_Wage_Info ");
            //strSql.Append(" WHERE id not in ( SELECT top " + (PageIndex - 1) * PageSize + " id FROM hr_Wage_Info ");
            //strSql.Append(" where " + strWhere + " order by " + filedOrder + " ) ");
            strSql1.Append(" select count(id) FROM hr_Wage_Info ");
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
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from hr_Wage_Info T ");
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
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "hr_Wage_Info";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
